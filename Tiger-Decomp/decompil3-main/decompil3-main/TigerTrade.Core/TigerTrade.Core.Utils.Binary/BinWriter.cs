using System.IO;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.Utils.Binary;

public abstract class BinWriter
{
	private readonly BinaryWriter _writer;

	internal static BinWriter WnEhs4kfFUCIEx76dmLy;

	protected BinWriter()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		_writer = new BinaryWriter(new MemoryStream());
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_86a1fc4a6b4043dcb945211754e2ad90 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected void WriteLeb128(long value)
	{
		if (value < 0)
		{
			goto IL_0059;
		}
		goto IL_00f6;
		IL_00f6:
		int num = (int)(value & 0x7F);
		value >>= 7;
		int num2 = 1;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_886e202b3f2f4f6dbb66ec0188f50627 == 0)
		{
			num2 = 2;
		}
		goto IL_0009;
		IL_003b:
		ocOYlJkfznln7PwqdWeQ(KAQHgwkfu2ZBwcBdEcg5(_writer), (byte)(num | 0x80));
		goto IL_00f6;
		IL_0009:
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				break;
			case 0:
				return;
			case 1:
				goto end_IL_0009;
			case 2:
				goto IL_0066;
			case 5:
				goto IL_00a3;
			case 3:
				goto IL_0103;
			}
			if ((num3 & 0x40) != 0)
			{
				_writer.BaseStream.WriteByte((byte)num3);
				return;
			}
			goto IL_00b6;
			IL_0103:
			if ((num & 0x40) == 0)
			{
				_writer.BaseStream.WriteByte((byte)num);
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_cffb9074f7244a46a7e8c2f280b0a849 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			goto IL_003b;
			IL_00b6:
			_writer.BaseStream.WriteByte((byte)(num3 | 0x80));
			num2 = 1;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_a883f9217a0145f6ad83c958cbe5302c != 0)
			{
				num2 = 1;
			}
			continue;
			IL_0066:
			if (value == 0L)
			{
				num2 = 3;
				continue;
			}
			goto IL_003b;
			IL_00a3:
			if (value == -1)
			{
				num2 = 4;
				continue;
			}
			goto IL_00b6;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0059;
		IL_0059:
		num3 = (int)(value & 0x7F);
		value >>= 7;
		num2 = 4;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_024b7dc8ad0444029044c5845d055c38 != 0)
		{
			num2 = 5;
		}
		goto IL_0009;
	}

	protected void Write(bool value)
	{
		_writer.Write(value);
	}

	protected void Write(byte value)
	{
		_writer.Write(value);
	}

	protected void Write(int value)
	{
		S0LP5tk90OEbK5xYsFDS(_writer, value);
	}

	protected void Write(long value)
	{
		_writer.Write(value);
	}

	protected void Write(double value)
	{
		ESx4Lqk92xV26ipssd9b(_writer, value);
	}

	protected void Write(string value)
	{
		_writer.Write(value);
	}

	protected byte[] GetStreamData()
	{
		return (KAQHgwkfu2ZBwcBdEcg5(_writer) as MemoryStream)?.ToArray();
	}

	static BinWriter()
	{
		opRoNkk9HonqNjQRFlmo();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool oGdAlKkf3t5Pb4CrcYpE()
	{
		return WnEhs4kfFUCIEx76dmLy == null;
	}

	internal static BinWriter UVsVu7kfp8jXlMTcpR7c()
	{
		return WnEhs4kfFUCIEx76dmLy;
	}

	internal static object KAQHgwkfu2ZBwcBdEcg5(object P_0)
	{
		return ((BinaryWriter)P_0).BaseStream;
	}

	internal static void ocOYlJkfznln7PwqdWeQ(object P_0, byte P_1)
	{
		((Stream)P_0).WriteByte(P_1);
	}

	internal static void S0LP5tk90OEbK5xYsFDS(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void ESx4Lqk92xV26ipssd9b(object P_0, double P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void opRoNkk9HonqNjQRFlmo()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}
}
