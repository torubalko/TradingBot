using System;

namespace MimeKit.Utils;

internal class PackedByteArray
{
	private const int InitialBufferSize = 64;

	private ushort[] buffer;

	private int length;

	private int cursor;

	public int Count => length;

	public PackedByteArray()
	{
		buffer = new ushort[64];
		Clear();
	}

	private void EnsureBufferSize(int size)
	{
		if (buffer.Length <= size)
		{
			int newSize = (size + 63) & -64;
			Array.Resize(ref buffer, newSize);
		}
	}

	public void Add(byte item)
	{
		if (cursor < 0 || item != (byte)(buffer[cursor] & 0xFF) || (buffer[cursor] & 0xFF00) == 65280)
		{
			EnsureBufferSize(cursor + 2);
			buffer[++cursor] = (ushort)(0x100 | item);
		}
		else
		{
			buffer[cursor] += 256;
		}
		length++;
	}

	public void Clear()
	{
		cursor = -1;
		length = 0;
	}

	public void CopyTo(byte[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex + length > array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		int num = arrayIndex;
		for (int i = 0; i <= cursor; i++)
		{
			int num2 = (buffer[i] >> 8) & 0xFF;
			byte b = (byte)(buffer[i] & 0xFF);
			for (int j = 0; j < num2; j++)
			{
				array[num++] = b;
			}
		}
	}
}
