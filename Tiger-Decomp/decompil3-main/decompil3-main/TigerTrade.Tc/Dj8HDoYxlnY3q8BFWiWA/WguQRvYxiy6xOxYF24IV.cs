using System;
using System.IO;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace Dj8HDoYxlnY3q8BFWiWA;

internal sealed class WguQRvYxiy6xOxYF24IV : BinaryReader
{
	internal static WguQRvYxiy6xOxYF24IV CNQK6xSbAcdefHSRVMqM;

	public WguQRvYxiy6xOxYF24IV(Stream P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector(P_0);
	}

	public long i0MYx46Ra5S()
	{
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
		{
			num3 = 0;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num3)
			{
			default:
				num4 = jl1ATISb31gdx3BkyHxj(kiFvi1SbFN4EMkFtfUuc(this));
				if (num4 == -1)
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
					{
						num3 = 1;
					}
				}
				else
				{
					num |= (long)(num4 & 0x7F) << num2;
					num3 = 3;
				}
				break;
			case 1:
				throw new EndOfStreamException();
			case 2:
				if ((num4 & 0x80) == 0)
				{
					if (num2 < 64 && (num4 & 0x40) != 0)
					{
						num |= -(1L << num2);
					}
					return num;
				}
				goto default;
			case 3:
				num2 += 7;
				num3 = 2;
				break;
			}
		}
	}

	public uint RCNYxDcNRh6()
	{
		int num = 1;
		int num2 = num;
		uint num4 = default(uint);
		int num5 = default(int);
		uint num3 = default(uint);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = 0u;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				num5 = 0;
				break;
			case 2:
				return num4;
			case 3:
				if (num3 == uint.MaxValue)
				{
					throw new EndOfStreamException();
				}
				num4 |= (num3 & 0x7F) << num5;
				if ((num3 & 0x80) != 0)
				{
					num5 += 7;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			num3 = (uint)jl1ATISb31gdx3BkyHxj(kiFvi1SbFN4EMkFtfUuc(this));
			num2 = 3;
		}
	}

	public long MdEYxb2TmTZ(long P_0)
	{
		uint num = RCNYxDcNRh6();
		if (num == 268435455)
		{
			return P_0 + i0MYx46Ra5S();
		}
		return P_0 + num;
	}

	public static long fEjYxNFo7Vl(DateTime P_0)
	{
		return P_0.Ticks / 10000;
	}

	public static DateTime UeyYxk2fIWu(long P_0)
	{
		return new DateTime(P_0 * 10000);
	}

	static WguQRvYxiy6xOxYF24IV()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool gfJaSHSbP17pRWjUB3qf()
	{
		return CNQK6xSbAcdefHSRVMqM == null;
	}

	internal static WguQRvYxiy6xOxYF24IV KQCR0CSbJloI5S8pUfuu()
	{
		return CNQK6xSbAcdefHSRVMqM;
	}

	internal static object kiFvi1SbFN4EMkFtfUuc(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static int jl1ATISb31gdx3BkyHxj(object P_0)
	{
		return ((Stream)P_0).ReadByte();
	}
}
