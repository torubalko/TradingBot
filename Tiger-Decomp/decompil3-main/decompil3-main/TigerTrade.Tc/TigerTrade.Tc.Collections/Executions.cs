using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Executions
{
	[CompilerGenerated]
	private sealed class TcbXDYiop8P6u74aR0Es
	{
		public Symbol Db5ioz4G1lv;

		public Account Ft2iv0pK6sJ;

		internal static TcbXDYiop8P6u74aR0Es Mc1yN1LMBeTka5YVMWHb;

		public TcbXDYiop8P6u74aR0Es()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool LMjiou1x8oW(Execution e)
		{
			if (dQcd9HLMDMRta7jAH5xr(JKPB9oLM4RD2kFHqepN8(ihVGPsLMlqiEpL0CUZbC(e)), Db5ioz4G1lv.ID))
			{
				return e.Account.AccountID == (string)u268cbLMbW7rdn8L03mf(Ft2iv0pK6sJ);
			}
			return false;
		}

		static TcbXDYiop8P6u74aR0Es()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool m8GasrLMaixL5laGB9xo()
		{
			return Mc1yN1LMBeTka5YVMWHb == null;
		}

		internal static TcbXDYiop8P6u74aR0Es UgwN3ELMi99BIJo2Y1g8()
		{
			return Mc1yN1LMBeTka5YVMWHb;
		}

		internal static object ihVGPsLMlqiEpL0CUZbC(object P_0)
		{
			return ((Execution)P_0).Symbol;
		}

		internal static object JKPB9oLM4RD2kFHqepN8(object P_0)
		{
			return ((Symbol)P_0).ID;
		}

		internal static bool dQcd9HLMDMRta7jAH5xr(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object u268cbLMbW7rdn8L03mf(object P_0)
		{
			return ((Account)P_0).AccountID;
		}
	}

	private readonly Dictionary<string, Execution> DdQad0XKodt;

	private readonly object XrEad2wViLl;

	private static Executions CRLpNNxA5u66iy3Y5XB3;

	public bool oqaaQF0WQgk(Execution P_0)
	{
		object xrEad2wViLl = XrEad2wViLl;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool result;
			try
			{
				Monitor.Enter(xrEad2wViLl, ref lockTaken);
				int num2;
				if (string.IsNullOrEmpty(P_0.ExecutionID) || DdQad0XKodt.ContainsKey(P_0.CombinedID))
				{
					result = false;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
					{
						num2 = 0;
					}
					goto IL_002a;
				}
				goto IL_008d;
				IL_002a:
				switch (num2)
				{
				default:
					goto end_IL_0018;
				case 1:
					break;
				case 0:
					goto end_IL_0018;
				case 2:
					goto end_IL_0018;
				}
				goto IL_008d;
				IL_008d:
				DdQad0XKodt.Add((string)S6piNOxALufmAjNdMbdP(P_0), P_0);
				result = true;
				num2 = 2;
				goto IL_002a;
				end_IL_0018:;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(xrEad2wViLl);
				}
			}
			return result;
		}
		}
	}

	public bool mcgaQ39WEFU(Execution P_0)
	{
		bool result;
		lock (XrEad2wViLl)
		{
			result = P_0 != null && DdQad0XKodt.ContainsKey(P_0.ExecutionID);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		return result;
	}

	public Execution lB4aQprkgp0(string P_0)
	{
		object xrEad2wViLl = XrEad2wViLl;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(xrEad2wViLl, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
				{
					num2 = 1;
				}
				object result;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (DdQad0XKodt.ContainsKey(P_0))
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						result = null;
						break;
					default:
						result = DdQad0XKodt[P_0];
						break;
					}
					break;
				}
				return (Execution)result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(xrEad2wViLl);
				}
			}
		}
	}

	public List<Execution> oqbaQuGWZjD(Symbol P_0, Account P_1)
	{
		TcbXDYiop8P6u74aR0Es CS_0024_003C_003E8__locals6 = new TcbXDYiop8P6u74aR0Es();
		CS_0024_003C_003E8__locals6.Db5ioz4G1lv = P_0;
		CS_0024_003C_003E8__locals6.Ft2iv0pK6sJ = P_1;
		if (CS_0024_003C_003E8__locals6.Db5ioz4G1lv == null || CS_0024_003C_003E8__locals6.Ft2iv0pK6sJ == null)
		{
			return null;
		}
		lock (XrEad2wViLl)
		{
			return DdQad0XKodt.Values.Where((Execution e) => TcbXDYiop8P6u74aR0Es.dQcd9HLMDMRta7jAH5xr(TcbXDYiop8P6u74aR0Es.JKPB9oLM4RD2kFHqepN8(TcbXDYiop8P6u74aR0Es.ihVGPsLMlqiEpL0CUZbC(e)), CS_0024_003C_003E8__locals6.Db5ioz4G1lv.ID) && e.Account.AccountID == (string)TcbXDYiop8P6u74aR0Es.u268cbLMbW7rdn8L03mf(CS_0024_003C_003E8__locals6.Ft2iv0pK6sJ)).ToList();
		}
	}

	public List<Execution> eyZaQzUvcVy()
	{
		lock (XrEad2wViLl)
		{
			return DdQad0XKodt.Values.ToList();
		}
	}

	public void Clear()
	{
		lock (XrEad2wViLl)
		{
			DdQad0XKodt.Clear();
		}
	}

	public Executions()
	{
		eGMRdDxAex0mi1jY6c1I();
		DdQad0XKodt = new Dictionary<string, Execution>();
		XrEad2wViLl = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Executions()
	{
		oLa12MxAsncZGfZDydHS();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object S6piNOxALufmAjNdMbdP(object P_0)
	{
		return ((Execution)P_0).CombinedID;
	}

	internal static bool yp2hn4xAS850IIZpvXbl()
	{
		return CRLpNNxA5u66iy3Y5XB3 == null;
	}

	internal static Executions CeUa8XxAxCT0H8XeVINt()
	{
		return CRLpNNxA5u66iy3Y5XB3;
	}

	internal static void eGMRdDxAex0mi1jY6c1I()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void oLa12MxAsncZGfZDydHS()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
