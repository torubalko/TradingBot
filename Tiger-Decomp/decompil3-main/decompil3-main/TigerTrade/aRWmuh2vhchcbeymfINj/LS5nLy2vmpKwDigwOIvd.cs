using System;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace aRWmuh2vhchcbeymfINj;

internal sealed class LS5nLy2vmpKwDigwOIvd
{
	[CompilerGenerated]
	private readonly double plC2vJPCfhp;

	[CompilerGenerated]
	private readonly double d7H2vFTVWVO;

	[CompilerGenerated]
	private readonly double C8h2v3svGUE;

	internal static LS5nLy2vmpKwDigwOIvd lijX9N4qXjMoCa0JARlP;

	public double Min
	{
		[CompilerGenerated]
		get
		{
			return plC2vJPCfhp;
		}
	}

	public double Max
	{
		[CompilerGenerated]
		get
		{
			return d7H2vFTVWVO;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public double q6B2vAKb6ES()
	{
		return C8h2v3svGUE;
	}

	public LS5nLy2vmpKwDigwOIvd(double P_0, double P_1, int P_2)
	{
		vSTe3L4qEwuoBVDVbRcZ();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				plC2vJPCfhp = Math.Floor(P_0 / q6B2vAKb6ES()) * q6B2vAKb6ES();
				d7H2vFTVWVO = Math.Ceiling(P_1 / q6B2vAKb6ES()) * q6B2vAKb6ES();
				return;
			case 1:
			{
				double num2 = vur3UJ4qQE3ZwKIVegUI(P_1 - P_0, _0020: false);
				C8h2v3svGUE = vur3UJ4qQE3ZwKIVegUI(num2 / (double)(P_2 - 1), _0020: true);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	private static double u2e2vwVQrie(double P_0, bool P_1)
	{
		double y = Math.Floor(Math.Log10(P_0));
		double num = P_0 / Math.Pow(10.0, y);
		int num2 = 7;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			default:
				return num3 * Math.Pow(10.0, y);
			case 4:
				num3 = 10.0;
				goto default;
			case 6:
				if (num < 3.0)
				{
					num3 = 2.0;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				if (num < 7.0)
				{
					num3 = 5.0;
					goto default;
				}
				goto case 9;
			case 3:
				if (num <= 2.0)
				{
					num3 = 2.0;
					goto default;
				}
				goto case 5;
			case 7:
				if (P_1)
				{
					if (!(num < 1.5))
					{
						goto case 6;
					}
					num3 = 1.0;
				}
				else
				{
					if (!(num <= 1.0))
					{
						goto case 3;
					}
					num3 = 1.0;
				}
				goto default;
			case 5:
				if (num <= 5.0)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 9:
				num3 = 10.0;
				goto default;
			case 8:
				num3 = 5.0;
				num2 = 2;
				break;
			}
		}
	}

	static LS5nLy2vmpKwDigwOIvd()
	{
		uhaa1R4qdtZYIIKNv1Ej();
	}

	internal static void vSTe3L4qEwuoBVDVbRcZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static double vur3UJ4qQE3ZwKIVegUI(double P_0, bool P_1)
	{
		return u2e2vwVQrie(P_0, P_1);
	}

	internal static bool eaRAxr4qcnRyYS0sMJ6O()
	{
		return lijX9N4qXjMoCa0JARlP == null;
	}

	internal static LS5nLy2vmpKwDigwOIvd fNRxSX4qj8I0oej3BNLQ()
	{
		return lijX9N4qXjMoCa0JARlP;
	}

	internal static void uhaa1R4qdtZYIIKNv1Ej()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
