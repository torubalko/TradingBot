using System;
using System.Collections.Generic;
using System.Threading;
using BcoytMGPUsbcVatGjnE4;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace HBn5hCYeh50VjeVE1aNX;

internal sealed class xBjPu0YemrsrZ4vv4Nj1
{
	private readonly Dictionary<string, nmx7s7GPtwKBjsWDiN4X> NmcYeA5oinA;

	private static xBjPu0YemrsrZ4vv4Nj1 SH9DuwS51V7OydBADn5t;

	public void V4yYew7nNeX(Symbol P_0, TickEvent P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> nmcYeA5oinA = NmcYeA5oinA;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
		{
			bool lockTaken = false;
			try
			{
				Monitor.Enter(nmcYeA5oinA, ref lockTaken);
				if (NmcYeA5oinA.ContainsKey(P_0.ID))
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 1:
						break;
					default:
						NmcYeA5oinA[P_0.ID].B9CGPTomDT2(P_1);
						return;
					}
				}
				NmcYeA5oinA.Add(P_0.ID, new nmx7s7GPtwKBjsWDiN4X(P_0.Step));
				break;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(nmcYeA5oinA);
				}
			}
		}
		}
	}

	public byte[] weSYe7GXRyl(string P_0)
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> nmcYeA5oinA = NmcYeA5oinA;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(nmcYeA5oinA, ref lockTaken);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => NmcYeA5oinA.ContainsKey(P_0) ? NmcYeA5oinA[P_0].cTAGPyTyIW4() : new byte[0], 
			};
		}
		finally
		{
			if (lockTaken)
			{
				uOBTg8S5xAcRw9oPebem(nmcYeA5oinA);
			}
		}
	}

	public void Clear()
	{
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> nmcYeA5oinA = NmcYeA5oinA;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(nmcYeA5oinA, ref lockTaken);
			NmcYeA5oinA.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				uOBTg8S5xAcRw9oPebem(nmcYeA5oinA);
			}
		}
	}

	public DateTime vwjYe8Xmopg(string P_0)
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, nmx7s7GPtwKBjsWDiN4X> nmcYeA5oinA = default(Dictionary<string, nmx7s7GPtwKBjsWDiN4X>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				nmcYeA5oinA = NmcYeA5oinA;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(nmcYeA5oinA, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					if (NmcYeA5oinA.ContainsKey(P_0))
					{
						return NmcYeA5oinA[P_0].KIlGPZKqjr6();
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(nmcYeA5oinA);
				}
			}
			return DateTime.MinValue;
		}
	}

	public xBjPu0YemrsrZ4vv4Nj1()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		NmcYeA5oinA = new Dictionary<string, nmx7s7GPtwKBjsWDiN4X>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static xBjPu0YemrsrZ4vv4Nj1()
	{
		hsAhPBS5LJPVFtyfupjP();
		mC6lAAS5eqLEb6gkNkML();
	}

	internal static bool u6J2GeS554gd6f2fB7GH()
	{
		return SH9DuwS51V7OydBADn5t == null;
	}

	internal static xBjPu0YemrsrZ4vv4Nj1 GpTFXlS5SnjZ9fO6TTOH()
	{
		return SH9DuwS51V7OydBADn5t;
	}

	internal static void uOBTg8S5xAcRw9oPebem(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void hsAhPBS5LJPVFtyfupjP()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void mC6lAAS5eqLEb6gkNkML()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
