using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using HpUKI02xdqwk72InKmDi;
using isnQObHkoBLhLETXDS3X;
using LPq3llG3QX4HMCBL7b1Q;
using Ox59HVA9Q7wHSnlqfC0;
using PMcgNO73xwFCF4saBbt;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TKdb2d8nH8oaoQTg5UL;
using tpDLBrGJAci5JWh2s4im;
using TuAMtrl1Nd3XoZQQUXf0;
using UMI2GBGJ3kloSb47d3eV;
using yH1aSw95cBMPqRpT6nEr;

namespace sL7Qd3PzB2IHxr16rkE;

internal sealed class xvlOxcPuYOQyocL2U3J : xRgq7gHkTVINiHGAKc0y, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class NeWUZ1ncZs0YwWnvKvFg
	{
		public static readonly NeWUZ1ncZs0YwWnvKvFg yPTncmbLKID;

		public static Func<OH1uQS7FddMfiLAwow4, bool> CMjnchhKkOx;

		public static Func<OH1uQS7FddMfiLAwow4, string> mfFncwOFliv;

		public static Func<NR8mtNAffxeTPx6Q9TH, string> QZ2nc7VMc99;

		public static Func<NR8mtNAffxeTPx6Q9TH, string> xiXnc8bwuSc;

		private static NeWUZ1ncZs0YwWnvKvFg SSFgbSNaKKw3IZk3fGst;

		static NeWUZ1ncZs0YwWnvKvFg()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			CJlcKyNawArq5CJWtXFU();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			yPTncmbLKID = new NeWUZ1ncZs0YwWnvKvFg();
		}

		public NeWUZ1ncZs0YwWnvKvFg()
		{
			CJlcKyNawArq5CJWtXFU();
			base._002Ector();
		}

		internal bool bP3ncV1Svre(OH1uQS7FddMfiLAwow4 k)
		{
			return !string.IsNullOrEmpty(k.IO57zZ2d5T);
		}

		internal string vljncCHsgD8(OH1uQS7FddMfiLAwow4 k)
		{
			return k.IO57zZ2d5T;
		}

		internal string ilGncrFHvVA(NR8mtNAffxeTPx6Q9TH s)
		{
			return (string)t737b9Na7rxsbKjpvdLu(s.Symbol);
		}

		internal string faRncKLnM35(NR8mtNAffxeTPx6Q9TH s)
		{
			return s.Symbol.ID;
		}

		internal static void CJlcKyNawArq5CJWtXFU()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool bp3NSRNamw4pqCYuXIaT()
		{
			return SSFgbSNaKKw3IZk3fGst == null;
		}

		internal static NeWUZ1ncZs0YwWnvKvFg LiabvpNahJPM6p8fpY8j()
		{
			return SSFgbSNaKKw3IZk3fGst;
		}

		internal static object t737b9Na7rxsbKjpvdLu(object P_0)
		{
			return ((Symbol)P_0).ID;
		}
	}

	private static readonly int qveJtDCR2R;

	private readonly DispatcherTimer mYFJUINnBm;

	[CompilerGenerated]
	private Action<string> Lu8JTGca3J;

	[CompilerGenerated]
	private readonly wmtHg889rdXfLxdgtOb NuWJyaOph0;

	[CompilerGenerated]
	private readonly LOaTZ5HkYs6IUi82qZ8y<NR8mtNAffxeTPx6Q9TH> YgfJZLnbYH;

	private readonly Dictionary<string, NR8mtNAffxeTPx6Q9TH> m8kJVyALIM;

	private readonly Dictionary<string, EventOwner<SecurityEvent>> rFmJCbKGSB;

	private bool ofhJrMEZ9D;

	private NR8mtNAffxeTPx6Q9TH TusJKtJFRL;

	private int XfXJmprDM4;

	private static xvlOxcPuYOQyocL2U3J GfqXCf4xgpjoXSpsggh2;

	public wmtHg889rdXfLxdgtOb Settings
	{
		[CompilerGenerated]
		get
		{
			return NuWJyaOph0;
		}
	}

	public string SymbolFilter
	{
		get
		{
			return (string)(TFohR04xMVclHaCM5RAS(Settings) ?? string.Empty);
		}
		set
		{
			string text = text2.Trim();
			if (!((string)TFohR04xMVclHaCM5RAS(Settings) == text))
			{
				Settings.SymbolFilter = text;
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 0:
					break;
				case 1:
					zQuJ01DCrQ();
					WArJYNWKLH();
					break;
				}
			}
		}
	}

	public LOaTZ5HkYs6IUi82qZ8y<NR8mtNAffxeTPx6Q9TH> Securities
	{
		[CompilerGenerated]
		get
		{
			return YgfJZLnbYH;
		}
	}

	public NR8mtNAffxeTPx6Q9TH SelectedSecurity
	{
		get
		{
			return TusJKtJFRL;
		}
		set
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						JZYHkZsWiJ6((string)hfsNMq4xUWI6gCqxpYCQ(0x28B345BB ^ 0x28B32FCD));
						JZYHkZsWiJ6((string)hfsNMq4xUWI6gCqxpYCQ(0x24B0B9E6 ^ 0x24B0D37C));
						JZYHkZsWiJ6((string)hfsNMq4xUWI6gCqxpYCQ(0x4662F6AF ^ 0x46629C1F));
						JZYHkZsWiJ6((string)hfsNMq4xUWI6gCqxpYCQ(-225822163 ^ -225816345));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						if (j18iDj9nukSCmEyZs5lH.Settings.TickerSwitchingMode == IknmHh95XIeQvfxb4I0a.uSr95jaMU03)
						{
							H8XJl3lY80();
						}
						return;
					case 1:
						return;
					case 2:
						if (!object.Equals(nR8mtNAffxeTPx6Q9TH, TusJKtJFRL))
						{
							TusJKtJFRL = nR8mtNAffxeTPx6Q9TH;
							num = 3;
							goto end_IL_0012;
						}
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
						{
							num2 = 1;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
			}
		}
	}

	public bool CanMoveUp
	{
		get
		{
			if (SelectedSecurity != null)
			{
				return Securities.IndexOf(SelectedSecurity) != 0;
			}
			return false;
		}
	}

	public bool CanMoveDown
	{
		get
		{
			if (SelectedSecurity != null)
			{
				return Securities.IndexOf(SelectedSecurity) != zLFUoI4xPPsxNyvblarK(Securities) - 1;
			}
			return false;
		}
	}

	public bool CanRemove => SelectedSecurity != null;

	public int EditGroupId
	{
		get
		{
			return XfXJmprDM4;
		}
		set
		{
			if (XfXJmprDM4 != num)
			{
				XfXJmprDM4 = num;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530030115));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				rm3JSL2BaV();
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public void qU5JqW8TtY(Action<string> P_0)
	{
		Action<string> action = Lu8JTGca3J;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Lu8JTGca3J, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Jx9JIfCb2M(Action<string> P_0)
	{
		Action<string> action = Lu8JTGca3J;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Lu8JTGca3J, value, action2);
		}
		while ((object)action != action2);
	}

	private void zQuJ01DCrQ()
	{
		IEnumerator<NR8mtNAffxeTPx6Q9TH> enumerator = Securities.GetEnumerator();
		try
		{
			while (HsrO6d4xqXcRntPQW2J1(enumerator))
			{
				NR8mtNAffxeTPx6Q9TH current = enumerator.Current;
				current.wEQA1iIpNC = o3kJnrq9xS((string)un6dtb4xOikeJuQNa1hw(current.Symbol));
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
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
			if (enumerator != null)
			{
				enumerator.Dispose();
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
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
	}

	[SpecialName]
	private SubscriptionFlags LyvJjB4f7V()
	{
		if (!ofhJrMEZ9D)
		{
			return SubscriptionFlags.Level1;
		}
		return SubscriptionFlags.Level1 | SubscriptionFlags.OpenInterest;
	}

	public xvlOxcPuYOQyocL2U3J(wmtHg889rdXfLxdgtOb P_0)
	{
		VEJTOm4xIMqeog7qjXXn();
		m8kJVyALIM = new Dictionary<string, NR8mtNAffxeTPx6Q9TH>();
		rFmJCbKGSB = new Dictionary<string, EventOwner<SecurityEvent>>();
		base._002Ector();
		mYFJUINnBm = new DispatcherTimer
		{
			Interval = TimeSpan.FromMilliseconds(qveJtDCR2R)
		};
		mYFJUINnBm.Tick += e7yJoclFa4;
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				YgfJZLnbYH = new LOaTZ5HkYs6IUi82qZ8y<NR8mtNAffxeTPx6Q9TH>();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				NuWJyaOph0 = P_0;
				num2 = 4;
				break;
			case 3:
				DataManager.OnSecurityEvent += oV3Jfl7XjB;
				((MhMDPU9v8rkigy1ao0Th)swkjsc4xtG3tBCB2UpPJ()).PropertyChanged += lZ6J2YjDnf;
				return;
			default:
				EditGroupId = nprF6c4xWappCAu12Fsd(P_0);
				num2 = 3;
				break;
			case 1:
				CollectionViewSource.GetDefaultView(Securities).Filter = Filter;
				SetSorting();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void lZ6J2YjDnf(object P_0, PropertyChangedEventArgs P_1)
	{
		string propertyName = P_1.PropertyName;
		if (!(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x385EDCF)) && !(propertyName == (string)hfsNMq4xUWI6gCqxpYCQ(0x4297C3EB ^ 0x4297D4AF)))
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					QhSJvbdg1l();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				case 0:
					return;
				case 3:
					if (!(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BEC760)))
					{
						if (!(propertyName == (string)hfsNMq4xUWI6gCqxpYCQ(0x7F645F3C ^ 0x7F643576)))
						{
							return;
						}
						B8pJxSSSlT();
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num = 1;
						}
					}
					else
					{
						num = 2;
					}
					break;
				}
			}
		}
		rm3JSL2BaV();
	}

	public void U65JHnXZ8J()
	{
		AddSymbols(Settings.ySF8omJND7.Select(SymbolManager.Get));
	}

	private void AddSymbols(IEnumerable<Symbol> symbols)
	{
		List<NR8mtNAffxeTPx6Q9TH> list = new List<NR8mtNAffxeTPx6Q9TH>();
		Dictionary<string, OH1uQS7FddMfiLAwow4> dictionary = Settings.TFW8aql5aq.Where((OH1uQS7FddMfiLAwow4 k) => !string.IsNullOrEmpty(k.IO57zZ2d5T)).ToDictionary((OH1uQS7FddMfiLAwow4 k) => k.IO57zZ2d5T);
		bool flag = Settings.Filter?.iqN8h5MFZr() ?? false;
		List<Symbol> list2 = new List<Symbol>();
		foreach (Symbol symbol in symbols)
		{
			if (symbol != null && !symbol.IsDeleted && !m8kJVyALIM.ContainsKey(symbol.ID))
			{
				NR8mtNAffxeTPx6Q9TH nR8mtNAffxeTPx6Q9TH = new NR8mtNAffxeTPx6Q9TH(symbol);
				nR8mtNAffxeTPx6Q9TH.hFBAbjxxm7 = XqvJGQPXGi(nR8mtNAffxeTPx6Q9TH);
				nR8mtNAffxeTPx6Q9TH.wEQA1iIpNC = o3kJnrq9xS(nR8mtNAffxeTPx6Q9TH.Symbol.Name);
				nR8mtNAffxeTPx6Q9TH.GroupChanged += fe7Ji12ONS;
				if (dictionary.TryGetValue(symbol.ID, out var value))
				{
					nR8mtNAffxeTPx6Q9TH.kw4AonLVtg(value);
				}
				m8kJVyALIM.Add(symbol.ID, nR8mtNAffxeTPx6Q9TH);
				list.Add(nR8mtNAffxeTPx6Q9TH);
				list2.Add(symbol);
			}
		}
		Securities.X9ZHkvvG9Ps(list);
		DataManager.Subscribe(LyvJjB4f7V(), list2.ToArray());
		if (flag)
		{
			rm3JSL2BaV();
		}
	}

	private void oV3Jfl7XjB(EventOwner<SecurityEvent> P_0)
	{
		if (m8kJVyALIM.ContainsKey(P_0.Value.Symbol.ID))
		{
			if (rFmJCbKGSB.TryGetValue(P_0.Value.Symbol.ID, out var value))
			{
				value.Uw7GF03Qn6r();
			}
			rFmJCbKGSB[P_0.Value.Symbol.ID] = P_0;
			P_0.TKjGJzSd8Na();
		}
	}

	public void pdeJ9YZSEl()
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		Dictionary<string, EventOwner<SecurityEvent>>.ValueCollection.Enumerator enumerator = default(Dictionary<string, EventOwner<SecurityEvent>>.ValueCollection.Enumerator);
		NR8mtNAffxeTPx6Q9TH value = default(NR8mtNAffxeTPx6Q9TH);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (rFmJCbKGSB.Count == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num2 = 1;
					}
					break;
				}
				flag = false;
				enumerator = rFmJCbKGSB.Values.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				enumerator = rFmJCbKGSB.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Uw7GF03Qn6r();
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				rFmJCbKGSB.Clear();
				num2 = 4;
				break;
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						EventOwner<SecurityEvent> current = enumerator.Current;
						int num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (m8kJVyALIM.TryGetValue(((Symbol)TEbhqB4xTa7Ye6ebJGwd(current.Value)).ID, out value))
								{
									num3 = 3;
									continue;
								}
								break;
							case 3:
								value.d3JAGghkCa(current.Value);
								flag2 = XqvJGQPXGi(value);
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								if (flag2 != Y0UbVD4xywarbjg4hXZO(value))
								{
									flag = true;
									value.hFBAbjxxm7 = flag2;
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 3;
			case 1:
				return;
			case 4:
				if (flag)
				{
					rm3JSL2BaV();
				}
				return;
			}
		}
	}

	private bool o3kJnrq9xS(string P_0)
	{
		string value = (((MhMDPU9v8rkigy1ao0Th)swkjsc4xtG3tBCB2UpPJ()).DelimiterInUse ? SymbolFilter : new string(SymbolFilter.Where(char.IsLetterOrDigit).ToArray()));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (!string.IsNullOrEmpty(SymbolFilter))
			{
				return P_0.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
			}
			return true;
		}
	}

	private bool XqvJGQPXGi(NR8mtNAffxeTPx6Q9TH P_0)
	{
		return Settings.Filter?.nVb8TfrTKA(P_0) ?? true;
	}

	private void WArJYNWKLH()
	{
		mYFJUINnBm.Stop();
		XcWXJj4xZkPrlFOU7GL5(mYFJUINnBm);
	}

	private void e7yJoclFa4(object P_0, EventArgs P_1)
	{
		PBEbRN4xV0L0CmtPbeJs(mYFJUINnBm);
		QhSJvbdg1l();
	}

	public void QhSJvbdg1l()
	{
		int num = 1;
		int num2 = num;
		IEnumerator<NR8mtNAffxeTPx6Q9TH> enumerator = default(IEnumerator<NR8mtNAffxeTPx6Q9TH>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = Securities.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					NR8mtNAffxeTPx6Q9TH current;
					while (true)
					{
						current = enumerator.Current;
						current.hFBAbjxxm7 = XqvJGQPXGi(current);
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 1:
							continue;
						}
						break;
					}
					c1ECMR4xrXglkmtnkqBe(current, o3kJnrq9xS(((Symbol)eTqknJ4xCWO9UVWpADUl(current)).Name));
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			rm3JSL2BaV();
			return;
		}
	}

	public void uiCJBJ8mO5(params Symbol[] symbols)
	{
		if (symbols == null)
		{
			goto IL_01b9;
		}
		int num;
		if (symbols.Length != 0)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		return;
		IL_0091:
		rm3JSL2BaV();
		num = 7;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0080:
		KlxugL4xhXcjs0I2PCSi(LyvJjB4f7V(), symbols);
		goto IL_0091;
		IL_0009:
		NR8mtNAffxeTPx6Q9TH nR8mtNAffxeTPx6Q9TH = default(NR8mtNAffxeTPx6Q9TH);
		Symbol symbol = default(Symbol);
		int num2 = default(int);
		Symbol[] array = default(Symbol[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				nR8mtNAffxeTPx6Q9TH = new NR8mtNAffxeTPx6Q9TH(symbol);
				vn7xAD4xKA4SVwfnNQwG(nR8mtNAffxeTPx6Q9TH, XqvJGQPXGi(nR8mtNAffxeTPx6Q9TH));
				num = 5;
				continue;
			case 2:
				Securities.Add(nR8mtNAffxeTPx6Q9TH);
				goto IL_00fb;
			case 3:
				num2 = 0;
				goto IL_01fe;
			default:
				if (symbol != null && !m8kJVyALIM.ContainsKey(symbol.ID))
				{
					num = 4;
					continue;
				}
				goto IL_00fb;
			case 7:
				return;
			case 5:
				nR8mtNAffxeTPx6Q9TH.wEQA1iIpNC = o3kJnrq9xS((string)un6dtb4xOikeJuQNa1hw(nR8mtNAffxeTPx6Q9TH.Symbol));
				num = 8;
				continue;
			case 8:
				nR8mtNAffxeTPx6Q9TH.GroupChanged += fe7Ji12ONS;
				m8kJVyALIM.Add((string)WTiJpV4xmE7CJm1prkq1(symbol), nR8mtNAffxeTPx6Q9TH);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
				{
					num = 2;
				}
				continue;
			case 1:
				break;
			case 6:
				{
					symbol = array[num2];
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num = 0;
					}
					continue;
				}
				IL_01fe:
				if (num2 >= array.Length)
				{
					goto IL_0080;
				}
				goto case 6;
				IL_00fb:
				num2++;
				goto IL_01fe;
			}
			break;
		}
		goto IL_01b9;
		IL_01b9:
		if (symbols != null)
		{
			array = symbols;
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_0091;
	}

	public void e5DJaARq4I(bool P_0)
	{
		ofhJrMEZ9D = P_0;
		if (!Securities.Any())
		{
			return;
		}
		Symbol[] array = (Symbol[])nCIlrx4xwErkXpfLRgmb(Securities.Select((NR8mtNAffxeTPx6Q9TH s) => (string)NeWUZ1ncZs0YwWnvKvFg.t737b9Na7rxsbKjpvdLu(s.Symbol)).ToArray());
		int num;
		if (P_0)
		{
			DataManager.Subscribe(SubscriptionFlags.OpenInterest, array);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
			{
				num = 0;
			}
		}
		else
		{
			SUUk6Y4x7515aZVNquka(SubscriptionFlags.OpenInterest, array);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	private void fe7Ji12ONS(NR8mtNAffxeTPx6Q9TH P_0)
	{
		if (EditGroupId != TXnZLf2xQQjRCdhLYH7T.NoGroupValue)
		{
			CollectionViewSource.GetDefaultView(Securities).Refresh();
		}
	}

	public void H8XJl3lY80()
	{
		if (TusJKtJFRL == null)
		{
			return;
		}
		Action<string> action = Lu8JTGca3J;
		if (action == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			action((string)WTiJpV4xmE7CJm1prkq1(TusJKtJFRL.Symbol));
		}
	}

	public void MoveUp()
	{
		if (SelectedSecurity != null)
		{
			IYiJ4N7vG0(-1);
		}
	}

	public void MoveDown()
	{
		if (SelectedSecurity != null)
		{
			IYiJ4N7vG0(1);
		}
	}

	private void IYiJ4N7vG0(int P_0)
	{
		NR8mtNAffxeTPx6Q9TH nR8mtNAffxeTPx6Q9TH = SelectedSecurity;
		sv5JDgCuHq();
		int num = 2;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 = Securities.IndexOf(nR8mtNAffxeTPx6Q9TH);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
				{
					num = 0;
				}
				break;
			case 3:
				SelectedSecurity = nR8mtNAffxeTPx6Q9TH;
				return;
			case 1:
				if (num2 < Securities.Count)
				{
					nycgLF4x8XiiRth73HfB(Securities, num3);
					Securities.Insert(num3 + P_0, nR8mtNAffxeTPx6Q9TH);
					num = 3;
					break;
				}
				goto case 3;
			default:
				num2 = num3 + P_0;
				if (num3 < 0 || num2 < 0)
				{
					goto case 3;
				}
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void sv5JDgCuHq()
	{
		int num = 1;
		int num2 = num;
		ICollectionView defaultView = default(ICollectionView);
		while (true)
		{
			switch (num2)
			{
			case 1:
				defaultView = CollectionViewSource.GetDefaultView(Securities);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (defaultView.SortDescriptions.Count != 0)
				{
					wySJbqbEaF(defaultView);
				}
				return;
			}
		}
	}

	private void wySJbqbEaF(ICollectionView P_0)
	{
		IEnumerable<NR8mtNAffxeTPx6Q9TH> enumerable = dIoJN5qb4Z(P_0);
		P_0.SortDescriptions.Clear();
		PWIROL4xA2WSvYjqnL3U(Securities);
		Securities.X9ZHkvvG9Ps(enumerable);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static IEnumerable<NR8mtNAffxeTPx6Q9TH> dIoJN5qb4Z(ICollectionView P_0)
	{
		ListCollectionView listCollectionView = (ListCollectionView)P_0;
		List<NR8mtNAffxeTPx6Q9TH> list = new List<NR8mtNAffxeTPx6Q9TH>(listCollectionView.Count);
		for (int i = 0; i < listCollectionView.Count; i++)
		{
			NR8mtNAffxeTPx6Q9TH item = (NR8mtNAffxeTPx6Q9TH)listCollectionView.GetItemAt(i);
			list.Add(item);
		}
		return list;
	}

	public void Remove()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				if (SelectedSecurity == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
					{
						num2 = 1;
					}
					break;
				}
				Symbol symbol = SymbolManager.Get((string)WTiJpV4xmE7CJm1prkq1(SelectedSecurity.Symbol));
				if (symbol == null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
					{
						num2 = 1;
					}
					break;
				}
				DataManager.UnSubscribe(LyvJjB4f7V(), symbol);
				goto case 3;
			}
			case 1:
				return;
			case 3:
				m8kJVyALIM.Remove(((Symbol)eTqknJ4xCWO9UVWpADUl(SelectedSecurity)).ID);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Securities.Remove(SelectedSecurity);
				return;
			}
		}
	}

	public void TEUJkyy6ns()
	{
		Symbol[] symbols = SymbolManager.Get(Securities.Select((NR8mtNAffxeTPx6Q9TH s) => s.Symbol.ID).ToArray());
		DataManager.UnSubscribe(LyvJjB4f7V(), symbols);
	}

	public void Clear()
	{
		TEUJkyy6ns();
		m8kJVyALIM.Clear();
		Securities.Clear();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private bool Filter(object o)
	{
		NR8mtNAffxeTPx6Q9TH nR8mtNAffxeTPx6Q9TH = (NR8mtNAffxeTPx6Q9TH)o;
		if (kdfJ18AwVy(nR8mtNAffxeTPx6Q9TH) && IsVisible((Symbol)eTqknJ4xCWO9UVWpADUl(nR8mtNAffxeTPx6Q9TH)))
		{
			return nR8mtNAffxeTPx6Q9TH.iwlA5fwMQt();
		}
		return false;
	}

	private static bool IsVisible(Symbol symbol)
	{
		if (j18iDj9nukSCmEyZs5lH.Settings.TradeMode == AppTradeMode.Player && ((MhMDPU9v8rkigy1ao0Th)swkjsc4xtG3tBCB2UpPJ()).ConfigViewDeletedSymbols)
		{
			return true;
		}
		return !yeMFvX4xJnpv8Q5npwJx(symbol);
	}

	private bool kdfJ18AwVy(NR8mtNAffxeTPx6Q9TH P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0.GroupId != EditGroupId)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0062;
			default:
				{
					if (EditGroupId != gohkJd4xFZodvGpVBZHa())
					{
						if (EditGroupId == nyNfsr4x3FipmJEMDcPo())
						{
							return P_0.GroupId != gohkJd4xFZodvGpVBZHa();
						}
						return false;
					}
					goto IL_0062;
				}
				IL_0062:
				return true;
			}
		}
	}

	private static bool EyPJ5axg7b(Symbol P_0)
	{
		if (!(Q0CuJu4xpb8JDqovP36p(P_0) != default(DateTime)) || !jXUiJ14xzYjXfmdqyWar(Q0CuJu4xpb8JDqovP36p(P_0), TimeHelper.GetCurrDate((string)UGnwAl4xupNF76Yrhn69(P_0))))
		{
			return OhWCZp4L07JZbAMTXKku(P_0);
		}
		return true;
	}

	private void SetSorting()
	{
		((ICollectionViewLiveShaping)CollectionViewSource.GetDefaultView(Securities)).IsLiveSorting = true;
	}

	public void SetSorting(string propertyName, ListSortDirection? listSortDirection)
	{
		ListCollectionView listCollectionView = (ListCollectionView)CollectionViewSource.GetDefaultView(Securities);
		listCollectionView.SortDescriptions.Clear();
		if (listSortDirection.HasValue)
		{
			listCollectionView.SortDescriptions.Add(new SortDescription(propertyName, listSortDirection.Value));
		}
	}

	private void rm3JSL2BaV()
	{
		ICollectionView defaultView = CollectionViewSource.GetDefaultView(Securities);
		if (defaultView != null)
		{
			jo4VuA4L2mxQ9dYbGs7h(defaultView);
		}
	}

	private void B8pJxSSSlT()
	{
		Task.Run(delegate
		{
			IEnumerator<NR8mtNAffxeTPx6Q9TH> enumerator = Securities.GetEnumerator();
			try
			{
				while (HsrO6d4xqXcRntPQW2J1(enumerator))
				{
					DBxqVU4L9gXxOEOQ9apX(enumerator.Current);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					maWnii4LnX9oNTTeJpqi(enumerator);
				}
			}
		});
	}

	public void Dispose()
	{
		mYFJUINnBm.Tick -= e7yJoclFa4;
		mYFJUINnBm.Stop();
		DataManager.OnSecurityEvent -= oV3Jfl7XjB;
		lGB4WY4LHODclgynVaUH(j18iDj9nukSCmEyZs5lH.Settings, new PropertyChangedEventHandler(lZ6J2YjDnf));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static xvlOxcPuYOQyocL2U3J()
	{
		xSmHQ64LfSOmogOTHRJu();
		VEJTOm4xIMqeog7qjXXn();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		qveJtDCR2R = 500;
	}

	[CompilerGenerated]
	private void sTZJLi3nqQ()
	{
		IEnumerator<NR8mtNAffxeTPx6Q9TH> enumerator = Securities.GetEnumerator();
		try
		{
			while (HsrO6d4xqXcRntPQW2J1(enumerator))
			{
				DBxqVU4L9gXxOEOQ9apX(enumerator.Current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				maWnii4LnX9oNTTeJpqi(enumerator);
			}
		}
	}

	internal static object TFohR04xMVclHaCM5RAS(object P_0)
	{
		return ((wmtHg889rdXfLxdgtOb)P_0).SymbolFilter;
	}

	internal static bool vQmrJc4xRBp3TfKo4EXS()
	{
		return GfqXCf4xgpjoXSpsggh2 == null;
	}

	internal static xvlOxcPuYOQyocL2U3J tKrlRH4x6cJV59oCAU9g()
	{
		return GfqXCf4xgpjoXSpsggh2;
	}

	internal static object un6dtb4xOikeJuQNa1hw(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static bool HsrO6d4xqXcRntPQW2J1(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void VEJTOm4xIMqeog7qjXXn()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static int nprF6c4xWappCAu12Fsd(object P_0)
	{
		return ((wmtHg889rdXfLxdgtOb)P_0).eUL84Si48S;
	}

	internal static object swkjsc4xtG3tBCB2UpPJ()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object hfsNMq4xUWI6gCqxpYCQ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object TEbhqB4xTa7Ye6ebJGwd(object P_0)
	{
		return ((anI4lfGJ8TTwhTlujQ36)P_0).Symbol;
	}

	internal static bool Y0UbVD4xywarbjg4hXZO(object P_0)
	{
		return ((NR8mtNAffxeTPx6Q9TH)P_0).hFBAbjxxm7;
	}

	internal static void XcWXJj4xZkPrlFOU7GL5(object P_0)
	{
		((DispatcherTimer)P_0).Start();
	}

	internal static void PBEbRN4xV0L0CmtPbeJs(object P_0)
	{
		((DispatcherTimer)P_0).Stop();
	}

	internal static object eTqknJ4xCWO9UVWpADUl(object P_0)
	{
		return ((NR8mtNAffxeTPx6Q9TH)P_0).Symbol;
	}

	internal static void c1ECMR4xrXglkmtnkqBe(object P_0, bool P_1)
	{
		((NR8mtNAffxeTPx6Q9TH)P_0).wEQA1iIpNC = P_1;
	}

	internal static void vn7xAD4xKA4SVwfnNQwG(object P_0, bool P_1)
	{
		((NR8mtNAffxeTPx6Q9TH)P_0).hFBAbjxxm7 = P_1;
	}

	internal static object WTiJpV4xmE7CJm1prkq1(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void KlxugL4xhXcjs0I2PCSi(SubscriptionFlags P_0, object P_1)
	{
		DataManager.Subscribe(P_0, (Symbol[])P_1);
	}

	internal static object nCIlrx4xwErkXpfLRgmb(object P_0)
	{
		return SymbolManager.Get((string[])P_0);
	}

	internal static void SUUk6Y4x7515aZVNquka(SubscriptionFlags P_0, object P_1)
	{
		DataManager.UnSubscribe(P_0, (Symbol[])P_1);
	}

	internal static void nycgLF4x8XiiRth73HfB(object P_0, int P_1)
	{
		((Collection<NR8mtNAffxeTPx6Q9TH>)P_0).RemoveAt(P_1);
	}

	internal static void PWIROL4xA2WSvYjqnL3U(object P_0)
	{
		((Collection<NR8mtNAffxeTPx6Q9TH>)P_0).Clear();
	}

	internal static int zLFUoI4xPPsxNyvblarK(object P_0)
	{
		return ((Collection<NR8mtNAffxeTPx6Q9TH>)P_0).Count;
	}

	internal static bool yeMFvX4xJnpv8Q5npwJx(object P_0)
	{
		return EyPJ5axg7b((Symbol)P_0);
	}

	internal static int gohkJd4xFZodvGpVBZHa()
	{
		return TXnZLf2xQQjRCdhLYH7T.NoGroupValue;
	}

	internal static int nyNfsr4x3FipmJEMDcPo()
	{
		return TXnZLf2xQQjRCdhLYH7T.AllGroupsValue;
	}

	internal static DateTime Q0CuJu4xpb8JDqovP36p(object P_0)
	{
		return ((Symbol)P_0).Expiration;
	}

	internal static object UGnwAl4xupNF76Yrhn69(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static bool jXUiJ14xzYjXfmdqyWar(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static bool OhWCZp4L07JZbAMTXKku(object P_0)
	{
		return ((Symbol)P_0).IsDeleted;
	}

	internal static void jo4VuA4L2mxQ9dYbGs7h(object P_0)
	{
		((ICollectionView)P_0).Refresh();
	}

	internal static void lGB4WY4LHODclgynVaUH(object P_0, object P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static void xSmHQ64LfSOmogOTHRJu()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void DBxqVU4L9gXxOEOQ9apX(object P_0)
	{
		((NR8mtNAffxeTPx6Q9TH)P_0).uvoAvpLifb();
	}

	internal static void maWnii4LnX9oNTTeJpqi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
