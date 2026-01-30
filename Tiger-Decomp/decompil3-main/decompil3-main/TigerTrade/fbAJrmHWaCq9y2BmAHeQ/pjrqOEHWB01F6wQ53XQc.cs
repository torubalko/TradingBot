using System;
using System.IO;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace fbAJrmHWaCq9y2BmAHeQ;

internal abstract class pjrqOEHWB01F6wQ53XQc : IDisposable
{
	private readonly BinaryWriter khWHWSVc88N;

	internal static pjrqOEHWB01F6wQ53XQc Km0j2UDOwecURkVw7SVD;

	protected pjrqOEHWB01F6wQ53XQc(Stream P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		khWHWSVc88N = new BinaryWriter(P_0);
	}

	protected void Hh2HWi1l00v(long P_0)
	{
		int num = 1;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (P_0 >= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 2:
					if ((num4 & 0x40) == 0)
					{
						khWHWSVc88N.BaseStream.WriteByte((byte)num4);
						return;
					}
					break;
				default:
					num4 = (int)(P_0 & 0x7F);
					P_0 >>= 7;
					if (P_0 == 0L)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 6:
					eIi4hnDOA3xZnyM8pMXa(zJP4qoDOPjZocOZri4E2(khWHWSVc88N), (byte)num3);
					return;
				case 5:
					num3 = (int)(P_0 & 0x7F);
					P_0 >>= 7;
					if (P_0 == -1)
					{
						num2 = 4;
						continue;
					}
					goto IL_0126;
				case 4:
					{
						if ((num3 & 0x40) != 0)
						{
							goto end_IL_0012;
						}
						goto IL_0126;
					}
					IL_0126:
					eIi4hnDOA3xZnyM8pMXa(zJP4qoDOPjZocOZri4E2(khWHWSVc88N), (byte)(num3 | 0x80));
					goto case 5;
				}
				eIi4hnDOA3xZnyM8pMXa(khWHWSVc88N.BaseStream, (byte)(num4 | 0x80));
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	protected void LOVHWlmHTlV(bool P_0)
	{
		khWHWSVc88N.Write(P_0);
	}

	protected void MGTHW40uCgF(byte P_0)
	{
		khWHWSVc88N.Write(P_0);
	}

	protected void oHUHWDJZro9(int P_0)
	{
		khWHWSVc88N.Write(P_0);
	}

	protected void n1bHWbm11GV(ushort P_0)
	{
		Dh2FNSDOJwRn0E3KwuWY(khWHWSVc88N, P_0);
	}

	protected void sKZHWNkKBt9(long P_0)
	{
		khWHWSVc88N.Write(P_0);
	}

	protected void SXnHWkoNEsv(uint P_0)
	{
		PLwLYXDOFK5oQjq1RMQG(khWHWSVc88N, P_0);
	}

	protected void eRUHW1VVQpC(double P_0)
	{
		BBQxYHDO3qgAssXihfQb(khWHWSVc88N, P_0);
	}

	protected void jebHW5jrdjh(string P_0)
	{
		G41RctDOpvIbTXlkFI6x(khWHWSVc88N, P_0);
	}

	public void Dispose()
	{
		khWHWSVc88N?.Dispose();
	}

	static pjrqOEHWB01F6wQ53XQc()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool PbinlGDO7XlWX7uKnIhT()
	{
		return Km0j2UDOwecURkVw7SVD == null;
	}

	internal static pjrqOEHWB01F6wQ53XQc eJsN7yDO8iVOlR8hEEsN()
	{
		return Km0j2UDOwecURkVw7SVD;
	}

	internal static void eIi4hnDOA3xZnyM8pMXa(object P_0, byte P_1)
	{
		((Stream)P_0).WriteByte(P_1);
	}

	internal static object zJP4qoDOPjZocOZri4E2(object P_0)
	{
		return ((BinaryWriter)P_0).BaseStream;
	}

	internal static void Dh2FNSDOJwRn0E3KwuWY(object P_0, ushort P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void PLwLYXDOFK5oQjq1RMQG(object P_0, uint P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void BBQxYHDO3qgAssXihfQb(object P_0, double P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void G41RctDOpvIbTXlkFI6x(object P_0, object P_1)
	{
		((BinaryWriter)P_0).Write((string)P_1);
	}
}
