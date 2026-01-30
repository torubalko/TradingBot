using System;
using System.IO;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace u6fBRhYqedGKNWaNEwBZ;

internal class fSe09yYqLrWV6gXnueCG : IDisposable
{
	private readonly BinaryReader YOTYqgqZX32;

	internal static fSe09yYqLrWV6gXnueCG UoBmJcSXVwCDfC05mOTl;

	public fSe09yYqLrWV6gXnueCG(byte[] P_0, bool P_1)
	{
		VGF9gQSXK2eIy9l971oV();
		base._002Ector();
		YOTYqgqZX32 = new BinaryReader(new MemoryStream(P_0));
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				if (!P_1)
				{
					num = 3;
					continue;
				}
				break;
			case 3:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			tWtYqcnxmEg();
			NjbYqs43VaK();
			tWtYqcnxmEg();
			NjbYqs43VaK();
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
			{
				num = 0;
			}
		}
	}

	public long NjbYqs43VaK()
	{
		long num = 0L;
		int num2 = 0;
		while (true)
		{
			int num3 = Y51idDSXmygX8x2JGfON(YOTYqgqZX32.BaseStream);
			if (num3 == -1)
			{
				break;
			}
			num |= (long)(num3 & 0x7F) << num2;
			num2 += 7;
			if ((num3 & 0x80) != 0)
			{
				continue;
			}
			int num4 = 3;
			while (true)
			{
				switch (num4)
				{
				case 3:
					if (num2 < 64)
					{
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
						{
							num4 = 0;
						}
						break;
					}
					goto default;
				default:
					return num;
				case 1:
					if ((num3 & 0x40) != 0)
					{
						num4 = 2;
						break;
					}
					goto default;
				case 2:
					num |= -(1L << num2);
					num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		}
		throw new EndOfStreamException();
	}

	public bool pWjYqXA2J0U()
	{
		return YOTYqgqZX32.ReadBoolean();
	}

	public byte tWtYqcnxmEg()
	{
		return YOTYqgqZX32.ReadByte();
	}

	public int qPVYqjl7Fma()
	{
		return YOTYqgqZX32.ReadInt32();
	}

	public long uSUYqEZ0jNv()
	{
		return ECZSL0SXhp3x2Aa84B4N(YOTYqgqZX32);
	}

	public double tUeYqQuT84c()
	{
		return Alb1J0SXwnsWRaiWysno(YOTYqgqZX32);
	}

	public string Nr3Yqd6Guuu()
	{
		return YOTYqgqZX32.ReadString();
	}

	public void Dispose()
	{
		YOTYqgqZX32?.Dispose();
	}

	static fSe09yYqLrWV6gXnueCG()
	{
		uEWHToSX7k6o49fXxeqx();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void VGF9gQSXK2eIy9l971oV()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool xGR2LGSXCXT3P17CDMsk()
	{
		return UoBmJcSXVwCDfC05mOTl == null;
	}

	internal static fSe09yYqLrWV6gXnueCG drPmE6SXrT3dUL9Rk7o1()
	{
		return UoBmJcSXVwCDfC05mOTl;
	}

	internal static int Y51idDSXmygX8x2JGfON(object P_0)
	{
		return ((Stream)P_0).ReadByte();
	}

	internal static long ECZSL0SXhp3x2Aa84B4N(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}

	internal static double Alb1J0SXwnsWRaiWysno(object P_0)
	{
		return ((BinaryReader)P_0).ReadDouble();
	}

	internal static void uEWHToSX7k6o49fXxeqx()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
