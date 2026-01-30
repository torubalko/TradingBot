using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Manager;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class ExitStrategy : ICloneable
{
	[CompilerGenerated]
	private sealed class yxvGpbaq6HbBbJAa6ghx
	{
		public string DO6aqOxWEa5;

		internal static yxvGpbaq6HbBbJAa6ghx TWZFiExz0hFIrX72SpcC;

		public yxvGpbaq6HbBbJAa6ghx()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool tocaqMGwM1K(ExitStrategyTarget s)
		{
			return (string)M4XsyZxzf0sayCbW9qfM(s) == DO6aqOxWEa5;
		}

		static yxvGpbaq6HbBbJAa6ghx()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool PsuCE7xz2JWWfsH0OtK5()
		{
			return TWZFiExz0hFIrX72SpcC == null;
		}

		internal static yxvGpbaq6HbBbJAa6ghx AWHFcPxzHP3k2JvKSyCu()
		{
			return TWZFiExz0hFIrX72SpcC;
		}

		internal static object M4XsyZxzf0sayCbW9qfM(object P_0)
		{
			return ((ExitStrategyTarget)P_0).ID;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class GRcJHwaqqe8IiUQNJTfF
	{
		public static readonly GRcJHwaqqe8IiUQNJTfF kVOaqWnFJ6K;

		public static Func<ExitStrategyTarget, ExitStrategyTarget> V9IaqtXhgv6;

		internal static GRcJHwaqqe8IiUQNJTfF uBTiKvxz9AMY1Cxd6G9y;

		static GRcJHwaqqe8IiUQNJTfF()
		{
			P4r77JxzYofJEHgrZK97();
			cPYwO6xzonNkdeCskbXT();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			kVOaqWnFJ6K = new GRcJHwaqqe8IiUQNJTfF();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public GRcJHwaqqe8IiUQNJTfF()
		{
			g5Llp0xzv2i6okKbKSb5();
			base._002Ector();
		}

		internal ExitStrategyTarget omtaqISFYVN(ExitStrategyTarget t)
		{
			return (ExitStrategyTarget)pheT2CxzB5ULDY4bQZfV(t);
		}

		internal static void P4r77JxzYofJEHgrZK97()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void cPYwO6xzonNkdeCskbXT()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool IhjVX6xznP590PeoeLGv()
		{
			return uBTiKvxz9AMY1Cxd6G9y == null;
		}

		internal static GRcJHwaqqe8IiUQNJTfF OsGN7pxzG5cxGBraQeE1()
		{
			return uBTiKvxz9AMY1Cxd6G9y;
		}

		internal static void g5Llp0xzv2i6okKbKSb5()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static object pheT2CxzB5ULDY4bQZfV(object P_0)
		{
			return ((ExitStrategyTarget)P_0).Clone();
		}
	}

	private List<ExitStrategyTarget> _targets;

	private static ExitStrategy i9NVwN5JTsqQbiwYwIMZ;

	public List<ExitStrategyTarget> Targets
	{
		get
		{
			return _targets ?? (_targets = new List<ExitStrategyTarget>());
		}
		set
		{
			_targets = value;
		}
	}

	public bool IsMultiStrategy => Targets.Count > 1;

	public ExitStrategyTarget GetStrategySingleTarget(bool create)
	{
		if (Targets.Count > 1)
		{
			return null;
		}
		if (Targets.Count != 0)
		{
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return Targets[0];
			}
		}
		else if (create)
		{
			Targets.Add(new ExitStrategyTarget());
			return Targets[0];
		}
		return null;
	}

	public List<ExitStrategyTarget> GetTargets()
	{
		return Targets.ToList();
	}

	public ExitStrategyTarget GetTarget(string id)
	{
		yxvGpbaq6HbBbJAa6ghx CS_0024_003C_003E8__locals2 = new yxvGpbaq6HbBbJAa6ghx();
		CS_0024_003C_003E8__locals2.DO6aqOxWEa5 = id;
		return Targets.FirstOrDefault((ExitStrategyTarget s) => (string)yxvGpbaq6HbBbJAa6ghx.M4XsyZxzf0sayCbW9qfM(s) == CS_0024_003C_003E8__locals2.DO6aqOxWEa5);
	}

	public void Clear(bool isClosePosition = false)
	{
		int num = 1;
		int num2 = num;
		List<Order> list2 = default(List<Order>);
		List<ExitStrategyTarget>.Enumerator enumerator = default(List<ExitStrategyTarget>.Enumerator);
		ExitStrategyTarget current = default(ExitStrategyTarget);
		Order current2 = default(Order);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
			{
				List<ExitStrategyTarget> list = Targets.ToList();
				list2 = new List<Order>();
				enumerator = list.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
				{
					num2 = 0;
				}
				continue;
			}
			}
			try
			{
				while (true)
				{
					IL_01c5:
					int num3;
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
						{
							num3 = 0;
						}
					}
					else
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							list2.Add((Order)dkQkNT5Jr8JunTLsI07u(current));
							num3 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							list2.Add(current.SlOrder);
							current.SlOrder = null;
							AWMsQo5JC0OQ9g8n3xna(current);
							goto IL_01db;
						case 3:
							if (hdafga5JVt2PLqGfqO7R(current) == null)
							{
								goto IL_01db;
							}
							goto case 4;
						case 1:
							current.TpOrder = null;
							bEMhnd5JKfijukyS2Tvq(current);
							break;
						case 2:
							goto end_IL_0159;
							IL_01db:
							if (dkQkNT5Jr8JunTLsI07u(current) != null)
							{
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_01c5;
						continue;
						end_IL_0159:
						break;
					}
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			XbIxdP5JmR9nnDAGAImj(Targets);
			using List<Order>.Enumerator enumerator2 = list2.GetEnumerator();
			while (true)
			{
				int num4;
				if (!enumerator2.MoveNext())
				{
					num4 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
					{
						num4 = 1;
					}
				}
				else
				{
					current2 = enumerator2.Current;
					if (!isClosePosition)
					{
						goto IL_00cb;
					}
					current2.CancelInitiator = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-842040449 ^ -842033423);
					num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
					{
						num4 = 0;
					}
				}
				switch (num4)
				{
				case 1:
					return;
				}
				goto IL_00cb;
				IL_00cb:
				DataManager.ClientCancelOrder(current2);
			}
		}
	}

	public DateTime GetUpdateTime()
	{
		DateTime dateTime = DateTime.MinValue;
		using (List<ExitStrategyTarget>.Enumerator enumerator = Targets.ToList().GetEnumerator())
		{
			ExitStrategyTarget current = default(ExitStrategyTarget);
			while (true)
			{
				int num;
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					if (!R0Qf7D5JhaoIPAqf1Zxi(current.UpdateTime, dateTime))
					{
						continue;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de != 0)
					{
						num = 0;
					}
				}
				switch (num)
				{
				case 1:
					dateTime = current.UpdateTime;
					continue;
				case 0:
					break;
				}
				break;
			}
		}
		return dateTime;
	}

	internal void SaveOrderIDs()
	{
		using List<ExitStrategyTarget>.Enumerator enumerator = Targets.ToList().GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.SaveOrderIDs();
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Init(ExitStrategy strategy)
	{
		Clear();
		foreach (ExitStrategyTarget target in strategy.Targets)
		{
			Targets.Add(target);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
	}

	public object Clone()
	{
		return new ExitStrategy
		{
			_targets = new List<ExitStrategyTarget>(_targets.Select((ExitStrategyTarget t) => (ExitStrategyTarget)GRcJHwaqqe8IiUQNJTfF.pheT2CxzB5ULDY4bQZfV(t)))
		};
	}

	public ExitStrategy()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static ExitStrategy()
	{
		Y87i6d5Jw2486rWr5P0j();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool TvvPPx5JyNlTVXAU3tkb()
	{
		return i9NVwN5JTsqQbiwYwIMZ == null;
	}

	internal static ExitStrategy fsEKat5JZ0JWJ5nlb4B0()
	{
		return i9NVwN5JTsqQbiwYwIMZ;
	}

	internal static object hdafga5JVt2PLqGfqO7R(object P_0)
	{
		return ((ExitStrategyTarget)P_0).SlOrder;
	}

	internal static void AWMsQo5JC0OQ9g8n3xna(object P_0)
	{
		((ExitStrategyTarget)P_0).ClearSl();
	}

	internal static object dkQkNT5Jr8JunTLsI07u(object P_0)
	{
		return ((ExitStrategyTarget)P_0).TpOrder;
	}

	internal static void bEMhnd5JKfijukyS2Tvq(object P_0)
	{
		((ExitStrategyTarget)P_0).ClearTp();
	}

	internal static void XbIxdP5JmR9nnDAGAImj(object P_0)
	{
		((List<ExitStrategyTarget>)P_0).Clear();
	}

	internal static bool R0Qf7D5JhaoIPAqf1Zxi(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static void Y87i6d5Jw2486rWr5P0j()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
