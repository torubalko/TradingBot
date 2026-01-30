using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using Jf1VIKDZINSDRBiuBQc;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace EnbFBYDM2yQV9ADoCAu;

internal sealed class urBSmSD6tHrGPCBpwFe : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly ObservableCollection<eakZg1DyNSTxJkfMByw> adEDU4eUel;

	private readonly Dictionary<string, eakZg1DyNSTxJkfMByw> j10DT4GdZB;

	private static urBSmSD6tHrGPCBpwFe EYGaG0l3bFi1irf3MuYO;

	public ObservableCollection<eakZg1DyNSTxJkfMByw> Accounts
	{
		[CompilerGenerated]
		get
		{
			return adEDU4eUel;
		}
	}

	public urBSmSD6tHrGPCBpwFe()
	{
		aW7A4dl319QDF6aUaIkO();
		j10DT4GdZB = new Dictionary<string, eakZg1DyNSTxJkfMByw>();
		base._002Ector();
		adEDU4eUel = new ObservableCollection<eakZg1DyNSTxJkfMByw>();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				DataManager.OnPortfolio += delegate(Portfolio P_0)
				{
					int num2 = 1;
					int num3 = num2;
					eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw2 = default(eakZg1DyNSTxJkfMByw);
					while (true)
					{
						switch (num3)
						{
						case 2:
							jtG9tFl3sMn5RChc87hv(eakZg1DyNSTxJkfMByw2, P_0);
							liZKpjl3eWuCRgSyxmD2(eakZg1DyNSTxJkfMByw2, Filter(eakZg1DyNSTxJkfMByw2));
							return;
						default:
							eakZg1DyNSTxJkfMByw2 = j10DT4GdZB[P_0.PortfolioID];
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
							{
								num3 = 1;
							}
							break;
						case 3:
							return;
						case 1:
							if (j10DT4GdZB.ContainsKey(P_0.PortfolioID))
							{
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
								{
									num3 = 0;
								}
							}
							else
							{
								eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw = new eakZg1DyNSTxJkfMByw(P_0);
								eakZg1DyNSTxJkfMByw.IsVisible = Filter(eakZg1DyNSTxJkfMByw);
								j10DT4GdZB.Add(P_0.PortfolioID, eakZg1DyNSTxJkfMByw);
								Accounts.Add(eakZg1DyNSTxJkfMByw);
								num3 = 3;
							}
							break;
						}
					}
				};
				DataManager.OnUpdateFilters += delegate
				{
					SdYDqjw8lx();
				};
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num = 1;
				}
				break;
			case 1:
				((MhMDPU9v8rkigy1ao0Th)ElKOchl35TZxh9giAHBR()).PropertyChanged += SxTDOWmpBD;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void SxTDOWmpBD(object P_0, PropertyChangedEventArgs P_1)
	{
		if (P_1.PropertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD51DB2))
		{
			SdYDqjw8lx();
		}
	}

	public bool Filter(object obj)
	{
		int num = 1;
		int num2 = num;
		eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw = default(eakZg1DyNSTxJkfMByw);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (mT9VwOl3x6RliMKmOZJA(eakZg1DyNSTxJkfMByw.IcQDKSrKOs) != 0.0)
				{
					return !(((Portfolio)zrHH6Yl3LWGDiPgamls6(eakZg1DyNSTxJkfMByw)).BalanceUsd < 0.01);
				}
				return false;
			case 2:
				return false;
			case 1:
				eakZg1DyNSTxJkfMByw = obj as eakZg1DyNSTxJkfMByw;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (eakZg1DyNSTxJkfMByw != null)
			{
				if (d2RjPDl3S8QWgpC28vtl())
				{
					return false;
				}
				if (!j18iDj9nukSCmEyZs5lH.Settings.HideZeroBalances)
				{
					return true;
				}
				num2 = 3;
			}
			else
			{
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	private void SdYDqjw8lx()
	{
		IEnumerator<eakZg1DyNSTxJkfMByw> enumerator = Accounts.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				eakZg1DyNSTxJkfMByw current = enumerator.Current;
				liZKpjl3eWuCRgSyxmD2(current, Filter(current));
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		finally
		{
			if (enumerator == null)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				enumerator.Dispose();
			}
		}
	}

	[CompilerGenerated]
	private void PT4DISFWAq(Portfolio P_0)
	{
		int num = 1;
		int num2 = num;
		eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw2 = default(eakZg1DyNSTxJkfMByw);
		while (true)
		{
			switch (num2)
			{
			case 2:
				jtG9tFl3sMn5RChc87hv(eakZg1DyNSTxJkfMByw2, P_0);
				liZKpjl3eWuCRgSyxmD2(eakZg1DyNSTxJkfMByw2, Filter(eakZg1DyNSTxJkfMByw2));
				return;
			default:
				eakZg1DyNSTxJkfMByw2 = j10DT4GdZB[P_0.PortfolioID];
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 1:
				if (j10DT4GdZB.ContainsKey(P_0.PortfolioID))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					eakZg1DyNSTxJkfMByw eakZg1DyNSTxJkfMByw = new eakZg1DyNSTxJkfMByw(P_0);
					eakZg1DyNSTxJkfMByw.IsVisible = Filter(eakZg1DyNSTxJkfMByw);
					j10DT4GdZB.Add(P_0.PortfolioID, eakZg1DyNSTxJkfMByw);
					Accounts.Add(eakZg1DyNSTxJkfMByw);
					num2 = 3;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void n2fDWflHB9()
	{
		SdYDqjw8lx();
	}

	static urBSmSD6tHrGPCBpwFe()
	{
		ATaD72l3XmqvUJZy6TA8();
	}

	internal static void aW7A4dl319QDF6aUaIkO()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object ElKOchl35TZxh9giAHBR()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool igPyqil3NxDGDcfh4cdv()
	{
		return EYGaG0l3bFi1irf3MuYO == null;
	}

	internal static urBSmSD6tHrGPCBpwFe P7JvD4l3kceMH8FBjmel()
	{
		return EYGaG0l3bFi1irf3MuYO;
	}

	internal static bool d2RjPDl3S8QWgpC28vtl()
	{
		return DataManager.Simulator;
	}

	internal static double mT9VwOl3x6RliMKmOZJA(object P_0)
	{
		return ((Portfolio)P_0).Balance;
	}

	internal static object zrHH6Yl3LWGDiPgamls6(object P_0)
	{
		return ((eakZg1DyNSTxJkfMByw)P_0).IcQDKSrKOs;
	}

	internal static void liZKpjl3eWuCRgSyxmD2(object P_0, bool P_1)
	{
		((eakZg1DyNSTxJkfMByw)P_0).IsVisible = P_1;
	}

	internal static void jtG9tFl3sMn5RChc87hv(object P_0, object P_1)
	{
		((eakZg1DyNSTxJkfMByw)P_0).wV2DVsKAY8((Portfolio)P_1);
	}

	internal static void ATaD72l3XmqvUJZy6TA8()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
