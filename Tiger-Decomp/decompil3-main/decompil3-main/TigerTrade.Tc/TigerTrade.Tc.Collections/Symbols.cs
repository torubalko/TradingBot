using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Symbols
{
	private readonly Dictionary<string, Symbol> HtnaQPccgNI;

	private readonly object yZ3aQJ3yCmu;

	internal static Symbols qARJP9xAlF6YlA0LHh3J;

	public bool SY5aQwDGc26(Symbol P_0)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = yZ3aQJ3yCmu;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num3;
				if (P_0 != null)
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
					{
						num3 = 0;
					}
					goto IL_0064;
				}
				goto IL_0091;
				IL_0064:
				while (true)
				{
					switch (num3)
					{
					default:
						if (!HtnaQPccgNI.ContainsKey((string)tMUjA4xAbfj09htpOeVD(P_0)))
						{
							goto IL_007a;
						}
						break;
					case 1:
						goto end_IL_0064;
					case 2:
						goto end_IL_0064;
					}
					goto IL_0091;
					IL_007a:
					HtnaQPccgNI.Add(P_0.ID, P_0);
					result = true;
					num3 = 2;
					continue;
					end_IL_0064:
					break;
				}
				goto end_IL_0052;
				IL_0091:
				result = false;
				num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num3 = 1;
				}
				goto IL_0064;
				end_IL_0052:;
			}
			finally
			{
				if (!lockTaken)
				{
					int num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				else
				{
					Monitor.Exit(obj);
				}
			}
			return result;
		}
	}

	public bool Remove(Symbol symbol)
	{
		object obj = yZ3aQJ3yCmu;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool result = default(bool);
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
				{
					num2 = 2;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (symbol != null && HtnaQPccgNI.ContainsKey(symbol.ID))
						{
							break;
						}
						result = false;
						goto end_IL_003f;
					case 1:
						goto end_IL_003f;
					}
					HtnaQPccgNI.Remove(symbol.ID);
					result = true;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
					{
						num2 = 1;
					}
					continue;
					end_IL_003f:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			return result;
		}
		}
	}

	public bool ErhaQ7r6tCT(string P_0)
	{
		if (!q2gr4FxANM9OSZl2Mexj(P_0))
		{
			object obj = yZ3aQJ3yCmu;
			bool lockTaken = false;
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					return HtnaQPccgNI.ContainsKey(P_0);
				}
				finally
				{
					if (lockTaken)
					{
						zYeANkxAkmk8QyJeqkpp(obj);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
				}
			default:
			{
				bool result = default(bool);
				return result;
			}
			}
		}
		return false;
	}

	public Symbol zPcaQ83NZPD(string P_0)
	{
		int num = 2;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = yZ3aQJ3yCmu;
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (string.IsNullOrEmpty(P_0))
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					_ => HtnaQPccgNI.ContainsKey(P_0) ? HtnaQPccgNI[P_0] : null, 
				};
			}
			finally
			{
				if (lockTaken)
				{
					zYeANkxAkmk8QyJeqkpp(obj);
				}
			}
		}
	}

	public List<Symbol> PxQaQAQjT9K()
	{
		lock (yZ3aQJ3yCmu)
		{
			return HtnaQPccgNI.Values.ToList();
		}
	}

	public void Clear()
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = yZ3aQJ3yCmu;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				HtnaQPccgNI.Clear();
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public Symbols()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		HtnaQPccgNI = new Dictionary<string, Symbol>();
		yZ3aQJ3yCmu = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Symbols()
	{
		g7q0tixA12AuFjSG5Zuh();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object tMUjA4xAbfj09htpOeVD(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static bool qQ7MLLxA4W6HaHfioPlu()
	{
		return qARJP9xAlF6YlA0LHh3J == null;
	}

	internal static Symbols OK2mK8xADyYn24EiC06y()
	{
		return qARJP9xAlF6YlA0LHh3J;
	}

	internal static bool q2gr4FxANM9OSZl2Mexj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void zYeANkxAkmk8QyJeqkpp(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void g7q0tixA12AuFjSG5Zuh()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
