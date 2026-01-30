using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using h7pRxxHvpGDBceteGLrG;
using SVLQlNHa1ViNwN8dmp2O;
using TigerTrade.Annotations;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Tc.Data;
using TigerTrade.UI.Common;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;
using xIFN882xDj3AcM7r1d4F;

namespace nurrNfHBFTpECeCp0ctO;

internal class dOOWCqHBJISX7vgN2JyE : UserControl, INotifyPropertyChanged, IComponentConnector
{
	[CompilerGenerated]
	private sealed class udM8XFntgNWcIsliaKRd
	{
		public KeyValuePair<int, Symbol> E2Rnt6r6MgL;

		private static udM8XFntgNWcIsliaKRd vqH2ixNSx8rNOTXR1rsA;

		public udM8XFntgNWcIsliaKRd()
		{
			tx4FSwNSsjiL7nMCaMnX();
			base._002Ector();
		}

		internal bool hJ0ntRoqdN4(DgUPqAHakN4WtFULT61i g)
		{
			return UOMj75NSXjIdxu1Og1lx(g) == E2Rnt6r6MgL.Key;
		}

		static udM8XFntgNWcIsliaKRd()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void tx4FSwNSsjiL7nMCaMnX()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool dkxH9ONSLt5AVG4ctf68()
		{
			return vqH2ixNSx8rNOTXR1rsA == null;
		}

		internal static udM8XFntgNWcIsliaKRd PWT3pINSeUw7X1nTdsEs()
		{
			return vqH2ixNSx8rNOTXR1rsA;
		}

		internal static int UOMj75NSXjIdxu1Og1lx(object P_0)
		{
			return ((DgUPqAHakN4WtFULT61i)P_0).Id;
		}
	}

	[CompilerGenerated]
	private Action<int, bool> m_GroupChanged;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	public static readonly DependencyProperty e2mHailRoCe;

	public static readonly DependencyProperty GsaHalxrNpN;

	public static readonly DependencyProperty pj1Ha4UrNG7;

	[CompilerGenerated]
	private readonly ObservableCollection<DgUPqAHakN4WtFULT61i> DgcHaDcdRJh;

	[CompilerGenerated]
	private readonly ObservableCollection<DgUPqAHakN4WtFULT61i> LvLHabWWZRt;

	internal dOOWCqHBJISX7vgN2JyE LinkGroup;

	private bool DL7HaNFKRLK;

	internal static dOOWCqHBJISX7vgN2JyE kKICOBDNeKMZkZj0AOa7;

	public ICommand GroupSelected
	{
		get
		{
			return (ICommand)GetValue(e2mHailRoCe);
		}
		set
		{
			SetValue(e2mHailRoCe, value2);
		}
	}

	public int CurrentGroup
	{
		get
		{
			return (int)t1A06FDNQXX1VLvFVJ51(this, GsaHalxrNpN);
		}
		set
		{
			SetValue(GsaHalxrNpN, num);
		}
	}

	public bool ActiveGroupNotUsed
	{
		get
		{
			return (bool)GetValue(pj1Ha4UrNG7);
		}
		set
		{
			G4qJO6DNdGDeC4xyUdmh(this, pj1Ha4UrNG7, flag);
		}
	}

	public ObservableCollection<DgUPqAHakN4WtFULT61i> UsedGroups
	{
		[CompilerGenerated]
		get
		{
			return DgcHaDcdRJh;
		}
	}

	public ObservableCollection<DgUPqAHakN4WtFULT61i> AvailableGroups
	{
		[CompilerGenerated]
		get
		{
			return LvLHabWWZRt;
		}
	}

	public event Action<int, bool> GroupChanged
	{
		[CompilerGenerated]
		add
		{
			Action<int, bool> action = this.m_GroupChanged;
			Action<int, bool> action2;
			do
			{
				action2 = action;
				Action<int, bool> value2 = (Action<int, bool>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_GroupChanged, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<int, bool> action = this.m_GroupChanged;
			Action<int, bool> action2;
			do
			{
				action2 = action;
				Action<int, bool> value2 = (Action<int, bool>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_GroupChanged, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)bMJefBDNcLS6lpcLLJie(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public dOOWCqHBJISX7vgN2JyE()
	{
		T8WHG9DNjTbUjKE3EtpA();
		base._002Ector();
		GroupSelected = new RelayCommand(LIvHB3HjaHd);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				P1LHBzbUW61();
				num = 3;
				break;
			default:
				maAHBpvkdM6();
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 2;
				}
				break;
			case 1:
				DgcHaDcdRJh = new ObservableCollection<DgUPqAHakN4WtFULT61i>();
				LvLHabWWZRt = new ObservableCollection<DgUPqAHakN4WtFULT61i>();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num = 0;
				}
				break;
			case 3:
				jmUaUZDNEbZ0SY6B6LjY(this, new RoutedEventHandler(rFHHa0e2amQ));
				InitializeComponent();
				return;
			}
		}
	}

	private void LIvHB3HjaHd(object P_0)
	{
		if (!(P_0 is int num))
		{
			return;
		}
		PopupButton.FT8HbRuwyZd();
		Action<int, bool> action = this.GroupChanged;
		if (action == null)
		{
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
		else
		{
			action((num != -1) ? num : 0, num == -1);
		}
	}

	private void maAHBpvkdM6()
	{
		foreach (var item in bqfvjsHv3IX2qp6XlY1i.b6PHB0gAQla.NB7HvuKL4Dl())
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			AvailableGroups.Add(new DgUPqAHakN4WtFULT61i(item.Item1, item.Item2));
		}
	}

	private void XcGHBu7Qgox(object P_0, EventArgs P_1)
	{
		UsedGroups.Clear();
		P1LHBzbUW61();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		qd3Ha2p1vWO(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x118B51F));
	}

	private void P1LHBzbUW61()
	{
		int num = 1;
		int num2 = num;
		Dictionary<int, Symbol>.Enumerator enumerator = default(Dictionary<int, Symbol>.Enumerator);
		udM8XFntgNWcIsliaKRd udM8XFntgNWcIsliaKRd = default(udM8XFntgNWcIsliaKRd);
		DgUPqAHakN4WtFULT61i dgUPqAHakN4WtFULT61i = default(DgUPqAHakN4WtFULT61i);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = OqHyre2x4ermamEtk9EZ.yjj2x15VIvY().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_006a:
					int num3;
					if (enumerator.MoveNext())
					{
						udM8XFntgNWcIsliaKRd = new udM8XFntgNWcIsliaKRd();
						num3 = 2;
					}
					else
					{
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num3 = 1;
						}
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (dgUPqAHakN4WtFULT61i == null)
							{
								break;
							}
							dgUPqAHakN4WtFULT61i.Symbol = ((udM8XFntgNWcIsliaKRd.E2Rnt6r6MgL.Value != null) ? (udM8XFntgNWcIsliaKRd.E2Rnt6r6MgL.Value.Name + (string)ptUA8BDNgemriLaJaNZj(-842040449 ^ -842048827) + udM8XFntgNWcIsliaKRd.E2Rnt6r6MgL.Value.Exchange) : null);
							dgUPqAHakN4WtFULT61i.IsEnabled = false;
							UsedGroups.Add(dgUPqAHakN4WtFULT61i);
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							udM8XFntgNWcIsliaKRd.E2Rnt6r6MgL = enumerator.Current;
							if (udM8XFntgNWcIsliaKRd.E2Rnt6r6MgL.Key > 0)
							{
								dgUPqAHakN4WtFULT61i = AvailableGroups.FirstOrDefault(udM8XFntgNWcIsliaKRd.hJ0ntRoqdN4);
								int num4 = 3;
								num3 = num4;
								continue;
							}
							break;
						case 1:
							goto end_IL_0033;
						}
						goto IL_006a;
						continue;
						end_IL_0033:
						break;
					}
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			IEnumerator<DgUPqAHakN4WtFULT61i> enumerator2 = AvailableGroups.Except(UsedGroups).GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					h0JCtpDNRgc3HDlwcKZq(enumerator2.Current, true);
				}
				return;
			}
			finally
			{
				if (enumerator2 != null)
				{
					uah5stDN6bqWFsBRQjFF(enumerator2);
				}
			}
		}
	}

	private void rFHHa0e2amQ(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				P1LHBzbUW61();
				qd3Ha2p1vWO((string)ptUA8BDNgemriLaJaNZj(-1009517961 ^ -1009589377));
				return;
			case 1:
				UsedGroups.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void qd3Ha2p1vWO([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!DL7HaNFKRLK)
		{
			DL7HaNFKRLK = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841561223), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num2 = 0;
					}
					break;
				}
				DL7HaNFKRLK = true;
				return;
			default:
				LinkGroup = (dOOWCqHBJISX7vgN2JyE)P_1;
				return;
			}
		}
	}

	static dOOWCqHBJISX7vgN2JyE()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				e2mHailRoCe = (DependencyProperty)Au6jVnDNO1FkCR3w6xbe(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D28F7E), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), eLXSWcDNMFldZVl9mpU5(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555247)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
				{
					num = 0;
				}
				break;
			default:
				GsaHalxrNpN = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B6521B), Type.GetTypeFromHandle(j71twlDNqr54hXaQSghJ(16777220)), eLXSWcDNMFldZVl9mpU5(j71twlDNqr54hXaQSghJ(33555247)));
				pj1Ha4UrNG7 = DependencyProperty.Register((string)ptUA8BDNgemriLaJaNZj(-2074141628 ^ -2074212956), eLXSWcDNMFldZVl9mpU5(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555247)));
				return;
			}
		}
	}

	internal static bool edAYI5DNs4V1oo7nBBok()
	{
		return kKICOBDNeKMZkZj0AOa7 == null;
	}

	internal static dOOWCqHBJISX7vgN2JyE n6Ae1qDNXGdvrmDIEaBW()
	{
		return kKICOBDNeKMZkZj0AOa7;
	}

	internal static object bMJefBDNcLS6lpcLLJie(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void T8WHG9DNjTbUjKE3EtpA()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void jmUaUZDNEbZ0SY6B6LjY(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static object t1A06FDNQXX1VLvFVJ51(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void G4qJO6DNdGDeC4xyUdmh(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object ptUA8BDNgemriLaJaNZj(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void h0JCtpDNRgc3HDlwcKZq(object P_0, bool P_1)
	{
		((DgUPqAHakN4WtFULT61i)P_0).IsEnabled = P_1;
	}

	internal static void uah5stDN6bqWFsBRQjFF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type eLXSWcDNMFldZVl9mpU5(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Au6jVnDNO1FkCR3w6xbe(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static RuntimeTypeHandle j71twlDNqr54hXaQSghJ(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
