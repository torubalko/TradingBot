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
using ActiproSoftware.Windows.Controls;
using BfZtb759KlUg4482QKym;
using deZWP8i7qq2A3lcy58by;
using K1GcsD5GTtMSlaiJI0Xh;
using mG7ZbBaeTKns1XlK1xAT;
using RRGeI95GVMJEHGH0bnkl;
using TigerTrade.Core.UI.Commands;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Config.UI;

internal class ConnectionIndicators : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class HOT7iEiY3L4C9BwGtr1u
	{
		public int SyKiYuHeqbn;

		internal static HOT7iEiY3L4C9BwGtr1u C2G1HsL6awPhXc0PiMaA;

		public HOT7iEiY3L4C9BwGtr1u()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool WnhiYptqLBh(gZE1IoaeUYyr4B5hitju i)
		{
			return i.Id == SyKiYuHeqbn;
		}

		static HOT7iEiY3L4C9BwGtr1u()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			tryF29L64aJXmDcPKVEq();
		}

		internal static bool lB51ysL6ir37DgkXN5Q2()
		{
			return C2G1HsL6awPhXc0PiMaA == null;
		}

		internal static HOT7iEiY3L4C9BwGtr1u aKhSj6L6lCMMxliX9PEZ()
		{
			return C2G1HsL6awPhXc0PiMaA;
		}

		internal static void tryF29L64aJXmDcPKVEq()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[CompilerGenerated]
	private Action<int, string> m_IndicatorChanged;

	public static readonly DependencyProperty LMJaeOI9qk6;

	public static readonly DependencyProperty JRCaeq3ZiLf;

	[CompilerGenerated]
	private readonly ICommand LpxaeIkr2TK;

	[CompilerGenerated]
	private readonly ObservableCollection<gZE1IoaeUYyr4B5hitju> ikUaeWTHH4i;

	internal ConnectionIndicators ConnectionIndicatorsControl;

	internal n70vAvi7ONDeJjpo4yfQ NoGroupButton;

	private bool FdgaetbYUnZ;

	internal static ConnectionIndicators KqVKZtxmbWJCLuohQnhK;

	public string ConnectionID
	{
		get
		{
			return (string)GetValue(LMJaeOI9qk6);
		}
		set
		{
			SetValue(LMJaeOI9qk6, value2);
		}
	}

	public int Indicator
	{
		get
		{
			return (int)FjX0oDxm5iiJVjpYqSFy(this, JRCaeq3ZiLf);
		}
		set
		{
			rhUA1GxmSA7TDEw7OAnp(this, JRCaeq3ZiLf, num);
		}
	}

	public ICommand IndicatorClickedCommand
	{
		[CompilerGenerated]
		get
		{
			return LpxaeIkr2TK;
		}
	}

	public ObservableCollection<gZE1IoaeUYyr4B5hitju> Indicators
	{
		[CompilerGenerated]
		get
		{
			return ikUaeWTHH4i;
		}
	}

	public event Action<int, string> IndicatorChanged
	{
		[CompilerGenerated]
		add
		{
			Action<int, string> action = this.m_IndicatorChanged;
			Action<int, string> action2;
			do
			{
				action2 = action;
				Action<int, string> value2 = (Action<int, string>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_IndicatorChanged, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<int, string> action = this.m_IndicatorChanged;
			Action<int, string> action2;
			do
			{
				action2 = action;
				Action<int, string> value2 = (Action<int, string>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_IndicatorChanged, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public ConnectionIndicators()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		LpxaeIkr2TK = new RelayCommand(rpoaesvF5W9);
		ikUaeWTHH4i = new ObservableCollection<gZE1IoaeUYyr4B5hitju>();
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				InitializeComponent();
				return;
			case 4:
				num2 = 1;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Indicators.Add(new gZE1IoaeUYyr4B5hitju(num2));
				num2++;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
				{
					num = 0;
				}
				break;
			default:
				if (num2 >= 27)
				{
					afhThmxm1474rXecnXSg(this, new RoutedEventHandler(GZNaeLnhHsS));
					num = 3;
				}
				else
				{
					num = 2;
				}
				break;
			}
		}
	}

	private void GZNaeLnhHsS(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				NoGroupButton.IsSelected = true;
				NoGroupButton.IsActive = true;
				return;
			case 1:
				if (Indicator != 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static xMwWnM52GwREsTxmuOyY Um2aeey0J8X<xMwWnM52GwREsTxmuOyY>(DependencyObject P_0) where xMwWnM52GwREsTxmuOyY : DependencyObject
	{
		DependencyObject parent = LogicalTreeHelper.GetParent(P_0);
		if (parent == null)
		{
			return null;
		}
		return (parent as xMwWnM52GwREsTxmuOyY) ?? Um2aeey0J8X<xMwWnM52GwREsTxmuOyY>(parent);
	}

	private void rpoaesvF5W9(object P_0)
	{
		if (!(P_0 is gZE1IoaeUYyr4B5hitju gZE1IoaeUYyr4B5hitju))
		{
			return;
		}
		PopupButton popupButton = Um2aeey0J8X<PopupButton>(this);
		int num;
		if (popupButton != null)
		{
			num = 2;
			goto IL_0009;
		}
		goto IL_007a;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				popupButton.IsPopupOpen = false;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				break;
			case 0:
				return;
			}
			break;
		}
		goto IL_007a;
		IL_007a:
		Action<int, string> action = this.IndicatorChanged;
		if (action != null)
		{
			action(EAqUpTxmx6AvunuKGtmQ(gZE1IoaeUYyr4B5hitju), ConnectionID);
			return;
		}
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	private static void atFaeXc1b4P(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		HOT7iEiY3L4C9BwGtr1u CS_0024_003C_003E8__locals3 = new HOT7iEiY3L4C9BwGtr1u();
		if (!(P_0 is ConnectionIndicators connectionIndicators))
		{
			return;
		}
		int num = 2;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
		{
			num = 5;
		}
		object newValue = default(object);
		gZE1IoaeUYyr4B5hitju gZE1IoaeUYyr4B5hitju = default(gZE1IoaeUYyr4B5hitju);
		IEnumerator<gZE1IoaeUYyr4B5hitju> enumerator = default(IEnumerator<gZE1IoaeUYyr4B5hitju>);
		while (true)
		{
			switch (num)
			{
			default:
				if (newValue is int)
				{
					CS_0024_003C_003E8__locals3.SyKiYuHeqbn = (int)newValue;
					num = 2;
					break;
				}
				return;
			case 4:
				return;
			case 6:
				if (gZE1IoaeUYyr4B5hitju == null)
				{
					return;
				}
				gZE1IoaeUYyr4B5hitju.IsSelected = true;
				num = 4;
				break;
			case 2:
				enumerator = connectionIndicators.Indicators.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.IsSelected = false;
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				if (CS_0024_003C_003E8__locals3.SyKiYuHeqbn == 0)
				{
					LxRorsxmL9pvg2sE4kv7(connectionIndicators.NoGroupButton, true);
					connectionIndicators.NoGroupButton.IsActive = true;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
					{
						num = 3;
					}
				}
				else
				{
					connectionIndicators.NoGroupButton.IsSelected = false;
					T7WrswxmeumfTZli44EW(connectionIndicators.NoGroupButton, false);
					gZE1IoaeUYyr4B5hitju = connectionIndicators.Indicators.FirstOrDefault((gZE1IoaeUYyr4B5hitju i) => i.Id == CS_0024_003C_003E8__locals3.SyKiYuHeqbn);
					num = 6;
				}
				break;
			case 5:
				newValue = P_1.NewValue;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	private void omCaec7xNJ7(object P_0, RoutedEventArgs P_1)
	{
		PopupButton popupButton = Um2aeey0J8X<PopupButton>(this);
		int num;
		if (popupButton != null)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_003d;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		popupButton.IsPopupOpen = false;
		goto IL_003d;
		IL_003d:
		Action<int, string> action = this.IndicatorChanged;
		if (action == null)
		{
			return;
		}
		action(0, ConnectionID);
		num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!FdgaetbYUnZ)
		{
			FdgaetbYUnZ = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
			{
				Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461292091 ^ -1461215437), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				break;
			}
			case 0:
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		if (P_0 == 1)
		{
			ConnectionIndicatorsControl = (ConnectionIndicators)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
			{
				num = 0;
			}
		}
		else if (P_0 == 2)
		{
			NoGroupButton = (n70vAvi7ONDeJjpo4yfQ)P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			NoGroupButton.Click += omCaec7xNJ7;
			break;
		case 2:
			FdgaetbYUnZ = true;
			break;
		case 0:
			break;
		}
	}

	static ConnectionIndicators()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			KcNmeSxmstlr2AQSvvNh();
			LMJaeOI9qk6 = DependencyProperty.Register((string)rV85jgxmX6852g4CwVoW(0x2BD86B18 ^ 0x2BD9866A), K32JpJxmcPFDlhAmyUxQ(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777225)), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33555970)), new PropertyMetadata(null));
			JRCaeq3ZiLf = (DependencyProperty)YHUq3TxmjNYADSEQnwxo(rV85jgxmX6852g4CwVoW(-165474503 ^ -165433679), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777219)), Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33555970)), new PropertyMetadata(0, atFaeXc1b4P));
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void afhThmxm1474rXecnXSg(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static bool xFdstDxmNhDeO64NyP4u()
	{
		return KqVKZtxmbWJCLuohQnhK == null;
	}

	internal static ConnectionIndicators mKGo8PxmkC1n2Qw9W7wJ()
	{
		return KqVKZtxmbWJCLuohQnhK;
	}

	internal static object FjX0oDxm5iiJVjpYqSFy(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void rhUA1GxmSA7TDEw7OAnp(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static int EAqUpTxmx6AvunuKGtmQ(object P_0)
	{
		return ((gZE1IoaeUYyr4B5hitju)P_0).Id;
	}

	internal static void LxRorsxmL9pvg2sE4kv7(object P_0, bool P_1)
	{
		((n70vAvi7ONDeJjpo4yfQ)P_0).IsSelected = P_1;
	}

	internal static void T7WrswxmeumfTZli44EW(object P_0, bool P_1)
	{
		((n70vAvi7ONDeJjpo4yfQ)P_0).IsActive = P_1;
	}

	internal static void KcNmeSxmstlr2AQSvvNh()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object rV85jgxmX6852g4CwVoW(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static Type K32JpJxmcPFDlhAmyUxQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YHUq3TxmjNYADSEQnwxo(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
