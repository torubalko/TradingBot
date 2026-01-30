using System;
using System.Text;
using MimeKit.IO.Filters;
using MimeKit.Utils;

namespace MimeKit.Tnef;

public class RtfCompressedToRtf : MimeFilterBase
{
	private enum FilterState
	{
		CompressedSize,
		UncompressedSize,
		Magic,
		Crc32,
		BeginControlRun,
		ReadControlOffset,
		ProcessControl,
		ReadLiteral,
		Complete
	}

	private const string DictionaryInitializerText = "{\\rtf1\\ansi\\mac\\deff0\\deftab720{\\fonttbl;}{\\f0\\fnil \\froman \\fswiss \\fmodern \\fscript \\fdecor MS Sans SerifSymbolArialTimes New RomanCourier{\\colortbl\\red0\\green0\\blue0\r\n\\par \\pard\\plain\\f0\\fs20\\b\\i\\u\\tab\\tx";

	private static readonly byte[] DictionaryInitializer = Encoding.ASCII.GetBytes("{\\rtf1\\ansi\\mac\\deff0\\deftab720{\\fonttbl;}{\\f0\\fnil \\froman \\fswiss \\fmodern \\fscript \\fdecor MS Sans SerifSymbolArialTimes New RomanCourier{\\colortbl\\red0\\green0\\blue0\r\n\\par \\pard\\plain\\f0\\fs20\\b\\i\\u\\tab\\tx");

	private readonly byte[] dict = new byte[4096];

	private readonly Crc32 crc32 = new Crc32();

	private FilterState state;

	private int uncompressedSize;

	private int compressedSize;

	private short dictWriteOffset;

	private short dictReadOffset;

	private short dictEndOffset;

	private byte flagCount;

	private byte flags;

	private int checksum;

	private int saved;

	private int size;

	public RtfCompressionMode CompressionMode { get; private set; }

	public bool IsValidCrc32 => crc32.Checksum == checksum;

	public RtfCompressedToRtf()
	{
		Buffer.BlockCopy(DictionaryInitializer, 0, dict, 0, DictionaryInitializer.Length);
		dictEndOffset = (dictWriteOffset = (short)DictionaryInitializer.Length);
	}

	private bool TryReadInt32(byte[] buffer, ref int index, int endIndex, out int value)
	{
		if (index == endIndex)
		{
			value = saved;
			return false;
		}
		int num = (saved >> 24) & 0xFF;
		saved &= 16777215;
		switch (num)
		{
		case 0:
			saved = buffer[index++];
			num++;
			if (index == endIndex)
			{
				break;
			}
			goto case 1;
		case 1:
			saved |= buffer[index++] << 8;
			num++;
			if (index == endIndex)
			{
				break;
			}
			goto case 2;
		case 2:
			saved |= buffer[index++] << 16;
			num++;
			if (index == endIndex)
			{
				break;
			}
			goto case 3;
		case 3:
			saved |= buffer[index++] << 24;
			num++;
			break;
		}
		value = saved;
		if (num == 4)
		{
			saved = 0;
			return true;
		}
		saved |= num << 24;
		return false;
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		int num = startIndex + length;
		int index = startIndex;
		if (state == FilterState.CompressedSize)
		{
			if (!TryReadInt32(input, ref index, num, out compressedSize))
			{
				outputLength = 0;
				outputIndex = 0;
				return input;
			}
			state = FilterState.UncompressedSize;
			compressedSize -= 12;
		}
		if (state == FilterState.UncompressedSize)
		{
			if (!TryReadInt32(input, ref index, num, out uncompressedSize))
			{
				outputLength = 0;
				outputIndex = 0;
				return input;
			}
			state = FilterState.Magic;
		}
		if (state == FilterState.Magic)
		{
			if (!TryReadInt32(input, ref index, num, out var value))
			{
				outputLength = 0;
				outputIndex = 0;
				return input;
			}
			CompressionMode = (RtfCompressionMode)value;
			state = FilterState.Crc32;
		}
		if (state == FilterState.Crc32)
		{
			if (!TryReadInt32(input, ref index, num, out checksum))
			{
				outputLength = 0;
				outputIndex = 0;
				return input;
			}
			state = FilterState.BeginControlRun;
		}
		if (CompressionMode != RtfCompressionMode.Compressed)
		{
			crc32.Update(input, index, num - index);
			outputLength = Math.Max(Math.Min(num - index, compressedSize - size), 0);
			size += outputLength;
			outputIndex = index;
			return input;
		}
		int num2 = Math.Abs(uncompressedSize - compressedSize);
		int val = num - index + num2;
		EnsureOutputSize(Math.Max(val, 4096), keep: false);
		outputLength = 0;
		outputIndex = 0;
		while (index < num && state != FilterState.Complete)
		{
			byte b = input[index++];
			crc32.Update(b);
			size++;
			switch (state)
			{
			case FilterState.BeginControlRun:
				flags = b;
				flagCount = 1;
				if ((flags & 1) != 0)
				{
					state = FilterState.ReadControlOffset;
				}
				else
				{
					state = FilterState.ReadLiteral;
				}
				break;
			case FilterState.ReadLiteral:
				EnsureOutputSize(outputLength + 1, keep: true);
				base.OutputBuffer[outputLength++] = b;
				dict[dictWriteOffset++] = b;
				dictEndOffset = Math.Max(dictWriteOffset, dictEndOffset);
				dictWriteOffset %= 4096;
				if (flagCount++ % 8 != 0)
				{
					flags >>= 1;
					if ((flags & 1) != 0)
					{
						state = FilterState.ReadControlOffset;
					}
					else
					{
						state = FilterState.ReadLiteral;
					}
				}
				else
				{
					state = FilterState.BeginControlRun;
				}
				break;
			case FilterState.ReadControlOffset:
				state = FilterState.ProcessControl;
				dictReadOffset = b;
				break;
			case FilterState.ProcessControl:
			{
				dictReadOffset = (short)((dictReadOffset << 4) | (b >> 4));
				int num3 = (b & 0xF) + 2;
				if (dictReadOffset == dictWriteOffset)
				{
					state = FilterState.Complete;
					break;
				}
				EnsureOutputSize(outputLength + num3, keep: true);
				int num4 = dictReadOffset + num3;
				while (dictReadOffset < num4)
				{
					b = dict[dictReadOffset++ % 4096];
					base.OutputBuffer[outputLength++] = b;
					dict[dictWriteOffset++] = b;
					dictEndOffset = Math.Max(dictWriteOffset, dictEndOffset);
					dictWriteOffset %= 4096;
				}
				if (flagCount++ % 8 != 0)
				{
					flags >>= 1;
					if ((flags & 1) != 0)
					{
						state = FilterState.ReadControlOffset;
					}
					else
					{
						state = FilterState.ReadLiteral;
					}
				}
				else
				{
					state = FilterState.BeginControlRun;
				}
				break;
			}
			}
		}
		return base.OutputBuffer;
	}

	public override void Reset()
	{
		Buffer.BlockCopy(DictionaryInitializer, 0, dict, 0, DictionaryInitializer.Length);
		dictEndOffset = (dictWriteOffset = (short)DictionaryInitializer.Length);
		state = FilterState.CompressedSize;
		dictReadOffset = 0;
		compressedSize = 0;
		crc32.Reset();
		flagCount = 0;
		checksum = 0;
		flags = 0;
		saved = 0;
		size = 0;
		base.Reset();
	}
}
