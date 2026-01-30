using System.Collections.Generic;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace bGgiEBaQIIXPkZpK2qqv;

internal sealed class M4FRMSaQqALMnxmxBFnN
{
	private readonly Dictionary<string, double> fSdaQUJXYPa;

	private readonly object CVAaQTFeaI8;

	internal static M4FRMSaQqALMnxmxBFnN m5DiqBxAHqgWit9TRDeU;

	public double UBvaQWQk1yR(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return 0.0;
		}
		double result = default(double);
		lock (CVAaQTFeaI8)
		{
			int num;
			if (fSdaQUJXYPa.TryGetValue(P_0, out var value))
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 1;
				}
			}
			else
			{
				result = 0.0;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 1:
				result = value;
				break;
			case 0:
				break;
			}
		}
		return result;
	}

	public void MtjaQtO1MSZ(string P_0, double P_1)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		object cVAaQTFeaI = CVAaQTFeaI8;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool lockTaken = false;
			try
			{
				Monitor.Enter(cVAaQTFeaI, ref lockTaken);
				int num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
					{
						if (!fSdaQUJXYPa.TryGetValue(P_0, out var _))
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
							{
								num2 = 0;
							}
							break;
						}
						fSdaQUJXYPa[P_0] = P_1;
						return;
					}
					default:
						fSdaQUJXYPa.Add(P_0, P_1);
						return;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(cVAaQTFeaI);
				}
			}
		}
		}
	}

	public M4FRMSaQqALMnxmxBFnN()
	{
		f4fQLKxAnSM7rBZ7NNJ2();
		fSdaQUJXYPa = new Dictionary<string, double>();
		CVAaQTFeaI8 = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static M4FRMSaQqALMnxmxBFnN()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		Ew2Tl5xAGARJZUPomewS();
	}

	internal static bool zAw0OHxAfFR8LL8Ls3CB()
	{
		return m5DiqBxAHqgWit9TRDeU == null;
	}

	internal static M4FRMSaQqALMnxmxBFnN QJLoMjxA9UCGtdekbBZX()
	{
		return m5DiqBxAHqgWit9TRDeU;
	}

	internal static void f4fQLKxAnSM7rBZ7NNJ2()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void Ew2Tl5xAGARJZUPomewS()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
