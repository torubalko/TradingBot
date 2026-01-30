using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using OWhORdGzgDWLWxLpUFfx;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace fprdaNaEWFuJeq2YEWyX;

internal sealed class dHFhAOaEIWwWtAWXjMZE
{
	private readonly Dictionary<string, Rybo1XGzd9ch5SOUQC2H> rNIaEA1jWJs;

	private readonly Dictionary<string, string> qcGaEPsFP4B;

	private readonly Dictionary<string, string> RZtaEJbMlB6;

	private readonly Dictionary<long, string> JLXaEFmX2Il;

	private readonly object JN6aE3hpqrX;

	internal static dHFhAOaEIWwWtAWXjMZE hWCNO5x8Xr0j0VQlhfq0;

	public bool kihaEtiwr0b(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		int num = 1;
		int num2 = num;
		object jN6aE3hpqrX = default(object);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jN6aE3hpqrX = JN6aE3hpqrX;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					case 2:
						RZtaEJbMlB6.Add(P_0.Qa2Gz62Cyav(), ((Symbol)R9bE8Ix8EQK77U6HvMe2(P_0)).ID);
						if (P_0.VkTGzOwmSDE() > 0 && !JLXaEFmX2Il.ContainsKey(P_0.VkTGzOwmSDE()))
						{
							JLXaEFmX2Il.Add(VP3Wngx8dZTHZOQ2YF3c(P_0), (string)alF2R7x8g07GpRBYvXT6(P_0));
						}
						result = true;
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
						{
							num3 = 4;
						}
						continue;
					default:
						rNIaEA1jWJs.Add(P_0.Qa2Gz62Cyav(), P_0);
						qcGaEPsFP4B.Add((string)WPD4nyx8Qt7IcopyQEcT(R9bE8Ix8EQK77U6HvMe2(P_0)), P_0.Qa2Gz62Cyav());
						num3 = 2;
						continue;
					case 3:
						if (P_0 != null)
						{
							if (rNIaEA1jWJs.ContainsKey(P_0.Qa2Gz62Cyav()))
							{
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto default;
						}
						goto case 1;
					case 1:
						result = false;
						break;
					case 4:
						break;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
	}

	public bool Remove(Rybo1XGzd9ch5SOUQC2H symbol)
	{
		int num = 1;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				result = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
				{
					num2 = 0;
				}
				continue;
			}
			object jN6aE3hpqrX = JN6aE3hpqrX;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				int num3;
				if (symbol == null)
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
					{
						num3 = 0;
					}
					goto IL_006c;
				}
				goto IL_00f6;
				IL_006c:
				while (true)
				{
					switch (num3)
					{
					default:
						goto end_IL_006c;
					case 2:
						RZtaEJbMlB6.Remove(symbol.Qa2Gz62Cyav());
						if (VP3Wngx8dZTHZOQ2YF3c(symbol) > 0 && JLXaEFmX2Il.ContainsKey(symbol.VkTGzOwmSDE()))
						{
							JLXaEFmX2Il.Remove(symbol.VkTGzOwmSDE());
						}
						result = true;
						goto end_IL_006c;
					case 1:
						qcGaEPsFP4B.Remove((string)WPD4nyx8Qt7IcopyQEcT(symbol.Symbol));
						num3 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
						{
							num3 = 2;
						}
						continue;
					case 3:
						break;
					case 0:
						goto end_IL_006c;
					}
					goto IL_00f6;
					continue;
					end_IL_006c:
					break;
				}
				goto end_IL_005a;
				IL_00f6:
				if (rNIaEA1jWJs.ContainsKey(symbol.Qa2Gz62Cyav()))
				{
					rNIaEA1jWJs.Remove((string)alF2R7x8g07GpRBYvXT6(symbol));
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
					{
						num3 = 1;
					}
					goto IL_006c;
				}
				end_IL_005a:;
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
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
	}

	public bool AZSaEUY8Udq(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (string.IsNullOrEmpty(P_0))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num2 = 0;
					}
					break;
				}
				object jN6aE3hpqrX = JN6aE3hpqrX;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
					return rNIaEA1jWJs.ContainsKey(P_0);
				}
				finally
				{
					if (lockTaken)
					{
						h7w2tix8RIFIt9kq56uV(jN6aE3hpqrX);
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
				}
			}
			default:
				return false;
			}
		}
	}

	public Rybo1XGzd9ch5SOUQC2H TF9aETQJHbG(string P_0)
	{
		if (SYX8KHx86AEQLcOy4Foh(P_0))
		{
			return null;
		}
		object jN6aE3hpqrX = JN6aE3hpqrX;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool lockTaken = false;
			Rybo1XGzd9ch5SOUQC2H result;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				result = (qcGaEPsFP4B.ContainsKey(P_0) ? rKKaEZotPga(qcGaEPsFP4B[P_0]) : null);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
		}
	}

	public Rybo1XGzd9ch5SOUQC2H LPiaEyKvEyx(Symbol P_0)
	{
		int num = 1;
		int num2 = num;
		object jN6aE3hpqrX = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jN6aE3hpqrX = JN6aE3hpqrX;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			Rybo1XGzd9ch5SOUQC2H result;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				result = (qcGaEPsFP4B.ContainsKey(P_0.ID) ? rKKaEZotPga(qcGaEPsFP4B[(string)WPD4nyx8Qt7IcopyQEcT(P_0)]) : null);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
	}

	public Rybo1XGzd9ch5SOUQC2H rKKaEZotPga(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		object jN6aE3hpqrX = JN6aE3hpqrX;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			Rybo1XGzd9ch5SOUQC2H result;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				result = (rNIaEA1jWJs.ContainsKey(P_0) ? rNIaEA1jWJs[P_0] : null);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
		}
	}

	public Symbol SaLaEVQ2yBi(string P_0)
	{
		if (SYX8KHx86AEQLcOy4Foh(P_0))
		{
			return null;
		}
		object jN6aE3hpqrX = JN6aE3hpqrX;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			bool lockTaken = false;
			Symbol result = default(Symbol);
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				int num2;
				if (!rNIaEA1jWJs.ContainsKey(P_0))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
					{
						num2 = 1;
					}
					goto IL_0069;
				}
				object obj = rNIaEA1jWJs[P_0]?.Symbol;
				goto IL_00d4;
				IL_0069:
				switch (num2)
				{
				default:
					goto end_IL_0057;
				case 1:
					obj = null;
					break;
				case 0:
					goto end_IL_0057;
				}
				goto IL_00d4;
				IL_00d4:
				result = (Symbol)obj;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num2 = 0;
				}
				goto IL_0069;
				end_IL_0057:;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
			return result;
		}
		}
	}

	public Rybo1XGzd9ch5SOUQC2H EFSaEC50BKi(long P_0)
	{
		int num = 1;
		int num2 = num;
		object jN6aE3hpqrX = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				jN6aE3hpqrX = JN6aE3hpqrX;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				if (JLXaEFmX2Il.ContainsKey(P_0))
				{
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 1:
						break;
					default:
						goto IL_00c8;
					}
				}
				object result = null;
				goto IL_00da;
				IL_00c8:
				result = rKKaEZotPga(JLXaEFmX2Il[P_0]);
				goto IL_00da;
				IL_00da:
				return (Rybo1XGzd9ch5SOUQC2H)result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
		}
	}

	public string OyQaEr9VJTy(string P_0)
	{
		if (SYX8KHx86AEQLcOy4Foh(P_0))
		{
			return null;
		}
		object jN6aE3hpqrX = JN6aE3hpqrX;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => RZtaEJbMlB6.ContainsKey(P_0) ? RZtaEJbMlB6[P_0] : null, 
			};
		}
		finally
		{
			if (lockTaken)
			{
				h7w2tix8RIFIt9kq56uV(jN6aE3hpqrX);
			}
		}
	}

	public string BMvaEKm6pab(long P_0)
	{
		object jN6aE3hpqrX = JN6aE3hpqrX;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			string result;
			try
			{
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				if (JLXaEFmX2Il.ContainsKey(P_0))
				{
					goto IL_0069;
				}
				object obj = null;
				goto IL_00bb;
				IL_0069:
				obj = OyQaEr9VJTy(JLXaEFmX2Il[P_0]);
				goto IL_00bb;
				IL_00bb:
				result = (string)obj;
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					goto end_IL_0045;
				case 1:
					break;
				case 0:
					goto end_IL_0045;
				}
				goto IL_0069;
				end_IL_0045:;
			}
			finally
			{
				if (!lockTaken)
				{
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				else
				{
					h7w2tix8RIFIt9kq56uV(jN6aE3hpqrX);
				}
			}
			return result;
		}
		}
	}

	public string jJ9aEmIfcvN(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		lock (JN6aE3hpqrX)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => RZtaEJbMlB6.ContainsKey(P_0.Qa2Gz62Cyav()) ? RZtaEJbMlB6[(string)alF2R7x8g07GpRBYvXT6(P_0)] : null, 
			};
		}
	}

	public string n7UaEh2BjpS(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		object jN6aE3hpqrX = JN6aE3hpqrX;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
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
				Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
				object result;
				if (!qcGaEPsFP4B.TryGetValue(P_0, out var value))
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					result = null;
				}
				else
				{
					result = value;
				}
				return (string)result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(jN6aE3hpqrX);
				}
			}
		}
		}
	}

	public string saBaEwlGh6b(Symbol P_0)
	{
		lock (JN6aE3hpqrX)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => qcGaEPsFP4B.ContainsKey((string)WPD4nyx8Qt7IcopyQEcT(P_0)) ? qcGaEPsFP4B[P_0.ID] : null, 
			};
		}
	}

	public List<Rybo1XGzd9ch5SOUQC2H> U9OaE7VBPf7()
	{
		lock (JN6aE3hpqrX)
		{
			return rNIaEA1jWJs.Values.ToList();
		}
	}

	public void Clear()
	{
		object jN6aE3hpqrX = JN6aE3hpqrX;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(jN6aE3hpqrX, ref lockTaken);
			rNIaEA1jWJs.Clear();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					RZtaEJbMlB6.Clear();
					RMQgtxx8MPL5N7aeGenc(JLXaEFmX2Il);
					return;
				}
				qcGaEPsFP4B.Clear();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 1;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				h7w2tix8RIFIt9kq56uV(jN6aE3hpqrX);
			}
		}
	}

	public void mygaE805ApQ()
	{
		lock (JN6aE3hpqrX)
		{
			foreach (Rybo1XGzd9ch5SOUQC2H value in rNIaEA1jWJs.Values)
			{
				value.kHYGzP3WQN1 = false;
				value.E07GzJKBNZY = false;
				value.m54GzFaRoc7 = false;
			}
		}
	}

	public dHFhAOaEIWwWtAWXjMZE()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		rNIaEA1jWJs = new Dictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		qcGaEPsFP4B = new Dictionary<string, string>();
		RZtaEJbMlB6 = new Dictionary<string, string>();
		JLXaEFmX2Il = new Dictionary<long, string>();
		JN6aE3hpqrX = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static dHFhAOaEIWwWtAWXjMZE()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object R9bE8Ix8EQK77U6HvMe2(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Symbol;
	}

	internal static object WPD4nyx8Qt7IcopyQEcT(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static long VP3Wngx8dZTHZOQ2YF3c(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).VkTGzOwmSDE();
	}

	internal static object alF2R7x8g07GpRBYvXT6(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Qa2Gz62Cyav();
	}

	internal static bool H39K7ex8cHe54Uuu0RQF()
	{
		return hWCNO5x8Xr0j0VQlhfq0 == null;
	}

	internal static dHFhAOaEIWwWtAWXjMZE TSACbax8jKKIiVLSku8Y()
	{
		return hWCNO5x8Xr0j0VQlhfq0;
	}

	internal static void h7w2tix8RIFIt9kq56uV(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool SYX8KHx86AEQLcOy4Foh(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void RMQgtxx8MPL5N7aeGenc(object P_0)
	{
		((Dictionary<long, string>)P_0).Clear();
	}
}
