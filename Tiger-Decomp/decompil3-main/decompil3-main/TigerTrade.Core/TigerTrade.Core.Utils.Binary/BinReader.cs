using System;
using System.IO;
using System.IO.Compression;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.Utils.Binary;

public abstract class BinReader<T> : IDisposable
{
	private long _leb128Value;

	private int _leb128Shift;

	private long _leb128B;

	private readonly BinaryReader _reader;

	private static object UYefX0kfApWI2rsfr9SN;

	public bool IsEmpty { get; }

	public T LastItem { get; private set; }

	public T PrevItem { get; private set; }

	protected BinReader(byte[] data)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3251a113e608497585c7df3489d778ef == 0)
		{
			num = 0;
		}
		MemoryStream memoryStream2 = default(MemoryStream);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				return;
			case 1:
				try
				{
					using GZipStream gZipStream = new GZipStream(memoryStream2, CompressionMode.Decompress);
					gZipStream.CopyTo(memoryStream);
				}
				finally
				{
					((IDisposable)memoryStream2)?.Dispose();
				}
				memoryStream.Position = 0L;
				_reader = new BinaryReader(memoryStream);
				num = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_111ce34c9179465eb46c2ea77239c778 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 4:
				_reader = new BinaryReader(new MemoryStream(data));
				num = 1;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_4b667f69655b4e888f7b8b5f64388261 != 0)
				{
					num = 3;
				}
				break;
			case 2:
				IsEmpty = data == null || data.Length == 0;
				if (IsEmpty)
				{
					return;
				}
				if (IsGZipHeader(data))
				{
					memoryStream = new MemoryStream();
					memoryStream2 = new MemoryStream(data);
					num = 1;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d3878af610b846108a5237604e24fce3 == 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 4;
				}
				break;
			}
		}
	}

	private static bool IsGZipHeader(byte[] data)
	{
		if (data.Length >= 2 && data[0] == 31)
		{
			return data[1] == 139;
		}
		return false;
	}

	protected long ReadLeb128()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_leb128B = _reader.BaseStream.ReadByte();
				if (_leb128B == -1)
				{
					throw new EndOfStreamException();
				}
				_leb128Value |= (_leb128B & 0x7F) << _leb128Shift;
				_leb128Shift += 7;
				if ((_leb128B & 0x80) != 0L)
				{
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_92c4ace445eb447c9e2014e7097157ae == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				_leb128Value = 0L;
				num2 = 3;
				break;
			case 1:
				if (_leb128Shift < 64)
				{
					num2 = 2;
					break;
				}
				goto IL_00e4;
			case 3:
				_leb128Shift = 0;
				_leb128B = 0L;
				num2 = 5;
				break;
			case 2:
				{
					if ((_leb128B & 0x40) != 0L)
					{
						_leb128Value |= -(1L << _leb128Shift);
					}
					goto IL_00e4;
				}
				IL_00e4:
				return _leb128Value;
			}
		}
	}

	protected bool ReadBool()
	{
		return _reader.ReadBoolean();
	}

	protected byte ReadByte()
	{
		return _reader.ReadByte();
	}

	protected int ReadInt32()
	{
		return _reader.ReadInt32();
	}

	protected long ReadLong()
	{
		return _reader.ReadInt64();
	}

	protected double ReadDouble()
	{
		return _reader.ReadDouble();
	}

	protected string ReadString()
	{
		return _reader.ReadString();
	}

	protected byte[] ReadStringAsBytes()
	{
		long num = ReadLeb128();
		if (num < 1)
		{
			return Array.Empty<byte>();
		}
		byte[] array = new byte[num];
		_reader.Read(array, 0, array.Length);
		int num2 = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_9311b07277ff480b8eff60475e1a8f34 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => array, 
		};
	}

	protected ushort ReadUInt16()
	{
		return _reader.ReadUInt16();
	}

	protected abstract T ReadItem();

	public bool Read()
	{
		if (!IsEmpty)
		{
			try
			{
				PrevItem = LastItem;
				int num = 1;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_1438775f5b664920ae174a26aded5441 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						LastItem = default(T);
						if (_reader.BaseStream.Position >= _reader.BaseStream.Length - 1)
						{
							return false;
						}
						LastItem = ReadItem();
						num = 0;
						if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_6646d59cf92743dc861b4d59be507f19 == 0)
						{
							num = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public virtual void Reset()
	{
		_reader.BaseStream.Position = 0L;
		LastItem = default(T);
		PrevItem = default(T);
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_111ce34c9179465eb46c2ea77239c778 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Dispose()
	{
		_reader?.Dispose();
	}

	static BinReader()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool YX3rTLkfP5epiDaaqUMm()
	{
		return UYefX0kfApWI2rsfr9SN == null;
	}

	internal static object TLDws2kfJsG2xFhHD8Q0()
	{
		return UYefX0kfApWI2rsfr9SN;
	}
}
