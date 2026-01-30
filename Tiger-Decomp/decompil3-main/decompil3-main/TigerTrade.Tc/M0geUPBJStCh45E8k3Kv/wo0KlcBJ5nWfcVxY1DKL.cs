using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using ccQsjKB3DQgmOmrxiR4v;
using EyD6NKGhRYBSlyBqPfrJ;
using gQ80RYoF52Cr7su4JSBU;
using IHLdB8BJUOSHRJoqeLsG;
using K1GcsD5GTtMSlaiJI0Xh;
using KZpdimB3uVCXOkVMyii5;
using lFFs11G39ohaRVknaFPC;
using Newtonsoft.Json.Linq;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace M0geUPBJStCh45E8k3Kv;

internal sealed class wo0KlcBJ5nWfcVxY1DKL : vdq7k7oF1bjOLTKJ5ZnM
{
	private static long SX5BJXjNpFa;

	private readonly List<vmttEfB346JyLX7kcXcA> BnsBJcY1Ef8;

	private readonly object o4EBJjbvqZJ;

	private long NBvBJEsFFPA;

	private long hrcBJQ7OlUR;

	private long iRiBJdFphlR;

	private int iPUBJgHcOnC;

	private bool YDOBJRnh0pI;

	private static wo0KlcBJ5nWfcVxY1DKL JMYKU7xtn8H2XwEiZDEI;

	[SpecialName]
	public long kTPBJelnO8h()
	{
		return SX5BJXjNpFa;
	}

	public wo0KlcBJ5nWfcVxY1DKL()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		BnsBJcY1Ef8 = new List<vmttEfB346JyLX7kcXcA>();
		o4EBJjbvqZJ = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			YDOBJRnh0pI = false;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
			{
				num = 1;
			}
		}
	}

	protected override long m23lvbn47Kv(decimal P_0, Symbol P_1)
	{
		return (long)(P_0 / (decimal)P_1.SizeStep);
	}

	public bool d8pBJxZ63P8(fvCFMcBJtCjklGOFEtCg P_0)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		IEnumerator<JArray> enumerator = default(IEnumerator<JArray>);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = o4EBJjbvqZJ;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				YDOBJRnh0pI = true;
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					default:
						BnsBJcY1Ef8.Clear();
						goto end_IL_0037;
					case 5:
						try
						{
							while (kaf7k4xtBI7brIwg1mpC(enumerator))
							{
								JArray current2 = enumerator.Current;
								U4ioFLPLW7Z(((JToken)b4kZFLxtvy4PLMuW4GDu(current2, 0)).ToObject<double>(), ((JToken)b4kZFLxtvy4PLMuW4GDu(current2, 1)).ToObject<double>());
								int num6 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								}
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
						foreach (JArray item in P_0.Asks)
						{
							int num7 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							}
							i5KoFxXiln5(item[0].ToObject<double>(), ((JToken)b4kZFLxtvy4PLMuW4GDu(item, 1)).ToObject<double>());
						}
						goto IL_02dd;
					case 3:
						if (P_0 == null)
						{
							result = false;
							num3 = 6;
							break;
						}
						SX5BJXjNpFa++;
						if (NBvBJEsFFPA <= FiiMUSxtocZNsFjO3ONM(P_0))
						{
							num3 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
							{
								num3 = 1;
							}
							break;
						}
						goto IL_02dd;
					case 4:
					{
						Clear();
						int num4 = 2;
						num3 = num4;
						break;
					}
					case 2:
						enumerator = P_0.Bids.GetEnumerator();
						num3 = 5;
						break;
					case 1:
						iRiBJdFphlR = P_0.LastUpdateId;
						num3 = 4;
						break;
					case 6:
						{
							return result;
						}
						IL_02dd:
						foreach (vmttEfB346JyLX7kcXcA item2 in BnsBJcY1Ef8)
						{
							int num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							}
							rQBBJLHXant(item2);
						}
						goto default;
					}
					continue;
					end_IL_0037:
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
			return true;
		}
	}

	public bool rQBBJLHXant(vmttEfB346JyLX7kcXcA P_0)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		long num4 = default(long);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = o4EBJjbvqZJ;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				if (YDOBJRnh0pI)
				{
					goto IL_0134;
				}
				int num3;
				if (NBvBJEsFFPA == 0L)
				{
					num3 = 6;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num3 = 4;
					}
					goto IL_0037;
				}
				goto IL_0234;
				IL_00d3:
				num4 = ((P_0.VvhB3Lr3Hkq > 0) ? nTdGs3xtiyxlXnijaqIj(P_0) : P_0.vurB35biKVK);
				num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
				{
					num3 = 1;
				}
				goto IL_0037;
				IL_0134:
				if (P_0.dPDB3dyfrBg <= iRiBJdFphlR)
				{
					num3 = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
					{
						num3 = 8;
					}
					goto IL_0037;
				}
				goto IL_00d3;
				IL_0234:
				if (hrcBJQ7OlUR < P_0.dPDB3dyfrBg)
				{
					hrcBJQ7OlUR = P_0.dPDB3dyfrBg;
				}
				BnsBJcY1Ef8.Add(P_0);
				result = false;
				num3 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
				{
					num3 = 4;
				}
				goto IL_0037;
				IL_0037:
				while (true)
				{
					switch (num3)
					{
					default:
					{
						using (List<wkU4qaB3px04BBpJlC3L>.Enumerator enumerator = P_0.hGjB3U3IGAt().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								wkU4qaB3px04BBpJlC3L current2 = enumerator.Current;
								i5KoFxXiln5(hAWYqIxtlVf7DStEduUF(current2), d6oDXtxt4PpAWjWjdbxF(current2));
							}
							int num7 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							case 0:
								break;
							}
						}
						goto case 2;
					}
					case 9:
						break;
					case 1:
						if (Acj0FgGhg83F5A0lfPa4.cDNGwEleiAl())
						{
							iPUBJgHcOnC = Math.Max(0, (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + Acj0FgGhg83F5A0lfPa4.q3hGwXLLhPb() - num4));
						}
						foreach (wkU4qaB3px04BBpJlC3L item in P_0.IqtB3Ib2Beg())
						{
							U4ioFLPLW7Z(item.Price, item.Quantity);
							int num6 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							}
						}
						goto default;
					case 2:
						result = true;
						goto end_IL_0025;
					case 8:
						result = false;
						num3 = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 != 0)
						{
							num3 = 7;
						}
						continue;
					case 5:
						goto IL_0134;
					case 7:
						goto end_IL_0025;
					case 3:
						goto IL_0234;
					case 4:
						goto end_IL_0025;
					case 6:
					{
						NBvBJEsFFPA = ((P_0.LastUpdateId > 0) ? (BBV48fxtaUEyhbqCNHvt(P_0) + 1) : P_0.nkGB3j15lwZ);
						int num5 = 3;
						num3 = num5;
						continue;
					}
					}
					break;
				}
				goto IL_00d3;
				end_IL_0025:;
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

	public override void odClvnSDwKl(Symbol P_0, MarketDepthFullEvent P_1)
	{
		tVxJ92xtDeydhtHaAAGU(P_1, iPUBJgHcOnC);
		object obj = o4EBJjbvqZJ;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			base.odClvnSDwKl(P_0, P_1);
		}
		finally
		{
			if (lockTaken)
			{
				Lq8DJ2xtbICsENOjfFNB(obj);
			}
		}
	}

	static wo0KlcBJ5nWfcVxY1DKL()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WScwRoxtGKP9csGYrDqy()
	{
		return JMYKU7xtn8H2XwEiZDEI == null;
	}

	internal static wo0KlcBJ5nWfcVxY1DKL b1bDRFxtYCRXyRnb8ARs()
	{
		return JMYKU7xtn8H2XwEiZDEI;
	}

	internal static long FiiMUSxtocZNsFjO3ONM(object P_0)
	{
		return ((fvCFMcBJtCjklGOFEtCg)P_0).LastUpdateId;
	}

	internal static object b4kZFLxtvy4PLMuW4GDu(object P_0, int P_1)
	{
		return ((JArray)P_0)[P_1];
	}

	internal static bool kaf7k4xtBI7brIwg1mpC(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static long BBV48fxtaUEyhbqCNHvt(object P_0)
	{
		return ((vmttEfB346JyLX7kcXcA)P_0).LastUpdateId;
	}

	internal static long nTdGs3xtiyxlXnijaqIj(object P_0)
	{
		return ((vmttEfB346JyLX7kcXcA)P_0).VvhB3Lr3Hkq;
	}

	internal static double hAWYqIxtlVf7DStEduUF(object P_0)
	{
		return ((wkU4qaB3px04BBpJlC3L)P_0).Price;
	}

	internal static double d6oDXtxt4PpAWjWjdbxF(object P_0)
	{
		return ((wkU4qaB3px04BBpJlC3L)P_0).Quantity;
	}

	internal static void tVxJ92xtDeydhtHaAAGU(object P_0, int P_1)
	{
		((MarketDepthDiffEvent)P_0).LastPing = P_1;
	}

	internal static void Lq8DJ2xtbICsENOjfFNB(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
