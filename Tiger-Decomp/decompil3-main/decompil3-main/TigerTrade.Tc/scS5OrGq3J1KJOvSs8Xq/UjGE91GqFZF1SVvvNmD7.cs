using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using t2RXnxGI0scLRJTKppKt;
using x97CE55GhEYKgt7TSVZT;

namespace scS5OrGq3J1KJOvSs8Xq;

internal class UjGE91GqFZF1SVvvNmD7 : YmAWnOGqzQWxN1OoHkp8
{
	private object H0AGqpqmaHg;

	private bool Y9mGqusdwDn;

	internal static UjGE91GqFZF1SVvvNmD7 N9TTKl56uTLhGWvUlJNq;

	public void YVglYY3itdJ()
	{
		lock (H0AGqpqmaHg)
		{
			Y9mGqusdwDn = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Monitor.PulseAll(H0AGqpqmaHg);
		}
	}

	public void vjhlYoMgWsq()
	{
		int num = 1;
		int num2 = num;
		object h0AGqpqmaHg = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				h0AGqpqmaHg = H0AGqpqmaHg;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(h0AGqpqmaHg, ref lockTaken);
				while (!Y9mGqusdwDn)
				{
					YPfR3J5M2vChlRdIVBOt(H0AGqpqmaHg);
				}
				int num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						Y9mGqusdwDn = false;
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					tK6Xls5MHSvXZPeiaBgq(h0AGqpqmaHg);
				}
			}
		}
	}

	public UjGE91GqFZF1SVvvNmD7()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		H0AGqpqmaHg = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UjGE91GqFZF1SVvvNmD7()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool orqb3W56zVBBg3oCsB4x()
	{
		return N9TTKl56uTLhGWvUlJNq == null;
	}

	internal static UjGE91GqFZF1SVvvNmD7 dosF245M0ZrA1bjx42cE()
	{
		return N9TTKl56uTLhGWvUlJNq;
	}

	internal static bool YPfR3J5M2vChlRdIVBOt(object P_0)
	{
		return Monitor.Wait(P_0);
	}

	internal static void tK6Xls5MHSvXZPeiaBgq(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
