using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AQB6mgf3wjOUxVfiEwwS;
using Bs9FfLq8LSV7wJhpolq;
using CjttZVHEzEWfhqQAXjq2;
using d3G2jt9MqabjmaXqI80L;
using EBnLmi9qWlLIutDAM7P4;
using ECOEgqlSad8NUJZ2Dr9n;
using Fb8gFFHFUNPFVH1wej60;
using JImXdX9qzB6OVpW11M5Z;
using kHAs2cfl7hDVW64jByhf;
using PMH7kB9LS7xf0LikQbe5;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Clusters.Enums;
using TigerTrade.Chart.Settings;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.Charting.Settings;
using TigerTrade.UI.DocControls.Common.Link;
using TuAMtrl1Nd3XoZQQUXf0;
using u32xe92XlvPUasWqNL4b;
using v0gxFx27QfQao4Ot85dR;

namespace CKdTRC2cOqO42kkJexwX;

internal sealed class C3n99U2cM72ZWgX9k0DW : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly ChartingSettings D8r2jg4la0J;

	private readonly DBmQUM2XiyOP3m87eGbR Eq02jRwOfiN;

	private bool YlM2j6aB7pr;

	private bool DwS2jMPH71j;

	private ICommand uOi2jOLH9YF;

	private ICommand Nwv2jqARPiv;

	private ICommand SCT2jI5dYfX;

	private ICommand GBR2jW5Phdg;

	private ICommand mYn2jty2l2J;

	private DataCycle qQ92jUkEaNx;

	private int Mqp2jTaEoF1;

	private bool VvS2jy8xk6Q;

	private bool wFg2jZNkQDP;

	private bool elo2jVWeoGV;

	private static C3n99U2cM72ZWgX9k0DW kvEuof4wYJNScDf3bwlX;

	public ChartingSettings Settings
	{
		[CompilerGenerated]
		get
		{
			return D8r2jg4la0J;
		}
	}

	public bool IsChartToolBarsVisible
	{
		get
		{
			return DwS2jMPH71j;
		}
		private set
		{
			if (flag != DwS2jMPH71j)
			{
				DwS2jMPH71j = flag;
				JZYHkZsWiJ6((string)xBXvMc4wNgtDW8im8vyE(-1522697859 ^ -1522678525));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
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
	}

	public zlrWq79quYbbxDu11FYh ZoomTool => Eq02jRwOfiN.Chart.ZoomTool;

	public string CurrentSize
	{
		get
		{
			int num = default(int);
			int num2;
			string text = default(string);
			if (!((MarketSettings)gibsph4wlbH1yGGMD0Vo(Settings)).ExecuteInQuoteCurrency)
			{
				if (!HpYosi4weIGgRnL270GF(Settings.MarketSettings))
				{
					return Convert.ToDecimal(uOFLcm4wXbGH8qcEljgD(bxDUAa4wsoB6nbRx9KJV(Settings.MarketSettings))).ToString(CultureInfo.InvariantCulture);
				}
				num = ((MarketSettings)gibsph4wlbH1yGGMD0Vo(Settings)).CurrentPreset.PercentSize;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				text = McPEV4q7m2685kMvrQH.bR1qJgPHqX(o7wWui4wSGuXPe55drsE(j18iDj9nukSCmEyZs5lH.Settings), _0020: false);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num2 = 0;
				}
			}
			return num2 switch
			{
				1 => num.ToString(CultureInfo.InvariantCulture), 
				_ => string.Format((string)hJrKy24wxoeAK6g5gNkd(xBXvMc4wNgtDW8im8vyE(-842040449 ^ -842007811), text, xBXvMc4wNgtDW8im8vyE(-90307782 ^ -90275146)), fDF5w54wLeGyt3NoSaWZ(((MarketSettings)gibsph4wlbH1yGGMD0Vo(Settings)).CurrentPreset)), 
			};
		}
	}

	public bool StockViewCandlesIsChecked => ((ChartSettings)oZEqGM4waVYLXq221K4O(Settings)).StockViewType == StockViewType.Candles;

	public bool StockViewBarsIsChecked => Settings.ChartSettings.StockViewType == StockViewType.Bars;

	public bool StockViewLineIsChecked => Settings.ChartSettings.StockViewType == StockViewType.Line;

	public bool StockViewAreaIsChecked => Settings.ChartSettings.StockViewType == StockViewType.Area;

	public bool StockViewClustersIsChecked => CFFc7e4wcKpWQZEyGewA(oZEqGM4waVYLXq221K4O(Settings)) == StockViewType.Clusters;

	public bool CursorPointerIsChecked => Settings.ChartSettings.CursorType == ChartCursorType.Pointer;

	public bool CursorLocalCrossIsChecked
	{
		get
		{
			if (Settings.ChartSettings.CursorType != ChartCursorType.LocalCross)
			{
				return Settings.ChartSettings.CursorType == ChartCursorType.Default;
			}
			return true;
		}
	}

	public bool CursorGlobalCrossIsChecked => ((ChartSettings)oZEqGM4waVYLXq221K4O(Settings)).CursorType == ChartCursorType.GlobalCross;

	public bool CursorGlobalCrossWithScrollIsChecked => Settings.ChartSettings.CursorType == ChartCursorType.GlobalCrossWithScroll;

	public string DataCycleShortName => ((DataCycle)rHKiI14wjxH6aIHX7i0d(Settings.ChartSettings)).ShortName;

	public bool ShowPanels
	{
		get
		{
			if (YlM2j6aB7pr)
			{
				return !Settings.HidePanels;
			}
			return false;
		}
		set
		{
			if (flag != YlM2j6aB7pr)
			{
				YlM2j6aB7pr = flag;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225802967));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
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
	}

	public ICommand MenuCommand => uOi2jOLH9YF ?? (uOi2jOLH9YF = new RelayCommand(delegate(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			Eq02jRwOfiN.PdP2X6Nc4gS(text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}));

	public ICommand ChartViewCommand => Nwv2jqARPiv ?? (Nwv2jqARPiv = new RelayCommand(delegate(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			H2ANRu4w6t0M38qVfyly(Eq02jRwOfiN, text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}));

	public ICommand ClusterPresetCommand => SCT2jI5dYfX ?? (SCT2jI5dYfX = new RelayCommand(delegate(object P_0)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = P_0 as string;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!string.IsNullOrEmpty(text))
				{
					Eq02jRwOfiN.hOB2XIBm0tE(text);
				}
				return;
			}
		}
	}));

	public string ClusterType
	{
		get
		{
			if (Settings.ChartSettings.StockViewType != StockViewType.Clusters)
			{
				return string.Empty;
			}
			return qMRhxD4wEtO7fiutrQVG(Settings.ChartSettings.ClusterSettings).ToString();
		}
	}

	public ICommand ChartCursorCommand => GBR2jW5Phdg ?? (GBR2jW5Phdg = new RelayCommand(delegate(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				Eq02jRwOfiN.PdP2X6Nc4gS(text);
				break;
			}
		}
	}));

	public ICommand DrawCommand => mYn2jty2l2J ?? (mYn2jty2l2J = new RelayCommand(delegate(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				mycy5LHEu3qqvRcny9Mb.TanHQByRbjC(text);
				Eq02jRwOfiN.Chart.uYW9uLtOwpS(text, null);
				break;
			}
		}
	}));

	public DataCycle DataCycle
	{
		get
		{
			return qQ92jUkEaNx;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!object.Equals(objA, qQ92jUkEaNx))
					{
						qQ92jUkEaNx = objA;
						JZYHkZsWiJ6((string)xBXvMc4wNgtDW8im8vyE(0x6E2DFBED ^ 0x6E2DB207));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int DataScale
	{
		get
		{
			return Mqp2jTaEoF1;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == Mqp2jTaEoF1)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
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
				Mqp2jTaEoF1 = num;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86E8FDA));
			}
		}
	}

	public DateTime? CalendarDate
	{
		get
		{
			return null;
		}
		set
		{
			if (dateTime.HasValue)
			{
				PopupButton.ClosePopupCommand.Execute(null, null);
				Eq02jRwOfiN.Chart.LoI9uB9MPBl(dateTime.Value.Date);
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7B1EF1));
			}
		}
	}

	public ObservableCollection<MenuItem> CustomObjects
	{
		get
		{
			ObservableCollection<MenuItem> observableCollection = new ObservableCollection<MenuItem>();
			foreach (vy1We39MOYmb6Ss3i1io item2 in DdW8419qIO2Mfk0ZN1xd.jh49qyHr9N7())
			{
				MenuItem item = new MenuItem
				{
					Header = item2.vrh9MtXy6fI(),
					Command = DrawCommand,
					CommandParameter = item2.ObjectName
				};
				observableCollection.Add(item);
			}
			return observableCollection;
		}
	}

	public Visibility CustomObjectsVisibility
	{
		get
		{
			if (CustomObjects.Count <= 0)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	public bool IsSymbolsPopupOpen
	{
		get
		{
			return VvS2jy8xk6Q;
		}
		set
		{
			if (VvS2jy8xk6Q != flag)
			{
				VvS2jy8xk6Q = flag;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487066C));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				rmF2ctrIrjq();
			}
		}
	}

	public bfvIex27Er0lPTIgUD0b MarketLocked
	{
		get
		{
			if (!zuKXY84wQn84Fec61xuX(Eq02jRwOfiN))
			{
				return bfvIex27Er0lPTIgUD0b.None;
			}
			switch (d7JfPW4wdGCJW95Fm1SY(Eq02jRwOfiN.DocLinkContext))
			{
			case SymbolType.Crypto:
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => (bfvIex27Er0lPTIgUD0b)2, 
				};
			}
			case SymbolType.Future:
				return (bfvIex27Er0lPTIgUD0b)1;
			default:
				return bfvIex27Er0lPTIgUD0b.None;
			}
		}
	}

	public bool ManualSelectDataType
	{
		get
		{
			return wFg2jZNkQDP;
		}
		set
		{
			if (wFg2jZNkQDP != flag)
			{
				wFg2jZNkQDP = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x37414E0C));
			}
		}
	}

	public bool IsMouseTradeOn
	{
		get
		{
			return elo2jVWeoGV;
		}
		set
		{
			if (elo2jVWeoGV != flag)
			{
				XG6mMr4wgTyWwKk04fLy(Settings, flag);
				SetProperty(ref elo2jVWeoGV, flag, (string)xBXvMc4wNgtDW8im8vyE(0x86EFEF6 ^ 0x86E4192));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
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
	}

	public C3n99U2cM72ZWgX9k0DW(DBmQUM2XiyOP3m87eGbR P_0, ChartingSettings P_1)
	{
		WZJ2xd4wBmmdSdQEhgov();
		base._002Ector();
		Eq02jRwOfiN = P_0;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 5:
				D8r2jg4la0J = P_1;
				fKvKggHFteRddgHojOPb.i9QHFrSPdFy(JVm2cW6cQhJ);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				((EpdvD7f3hWq8UlJ32f6V)B0j6tt4wDNVreahhHRvF(Settings.MarketSettings)).PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				};
				num = 2;
				break;
			case 1:
				j18iDj9nukSCmEyZs5lH.Settings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				};
				Settings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				};
				Settings.ChartSettings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				};
				((ChartSettings)oZEqGM4waVYLXq221K4O(Settings)).ClusterSettings.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(e));
				};
				dc51c94widtuTaPKN5DT(Settings.MarketSettings, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				});
				num = 6;
				break;
			case 2:
				Settings.MarketSettings.Preset4.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(e));
				};
				Settings.MarketSettings.Preset5.PropertyChanged += delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(e));
				};
				ShowPanels = true;
				IsChartToolBarsVisible = ((MhMDPU9v8rkigy1ao0Th)QVydPj4wb9WevC2grTpf()).IsChartToolBarsVisible;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
				{
					num = 3;
				}
				break;
			default:
				kkNPXu4w4ghIKQ3VEe75(Settings.MarketSettings.Preset2, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP(e.PropertyName);
				});
				num = 4;
				break;
			case 6:
				kkNPXu4w4ghIKQ3VEe75(((MarketSettings)gibsph4wlbH1yGGMD0Vo(Settings)).Preset1, (PropertyChangedEventHandler)delegate(object obj, PropertyChangedEventArgs e)
				{
					nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(e));
				});
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void rbX2cqLWdWY(int P_0)
	{
		Settings.MarketSettings.PresetID = P_0;
	}

	private void nfs2cI771NP(string P_0)
	{
		int num = 20;
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 24:
					return;
				case 16:
					IsMouseTradeOn = tgw2xO4w5sysdeSnuTnB(Settings);
					return;
				case 4:
					JZYHkZsWiJ6((string)xBXvMc4wNgtDW8im8vyE(0x78D396D8 ^ 0x78D32B40));
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306911648));
					JZYHkZsWiJ6((string)xBXvMc4wNgtDW8im8vyE(-1878953018 ^ -1878929978));
					return;
				case 13:
					return;
				case 2:
					return;
				case 11:
					return;
				case 1:
					return;
				case 18:
					return;
				case 17:
					if (num3 == 927636608)
					{
						if (P_0 == (string)xBXvMc4wNgtDW8im8vyE(0x1AB79299 ^ 0x1AB72E37))
						{
							JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371596259));
							JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F05E05));
							num2 = 15;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
							{
								num2 = 1;
							}
						}
						else
						{
							num2 = 8;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
							{
								num2 = 10;
							}
						}
					}
					else
					{
						num2 = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
						{
							num2 = 7;
						}
					}
					break;
				case 20:
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0);
					num2 = 19;
					break;
				case 15:
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C83C98C));
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
					{
						num2 = 1;
					}
					break;
				case 14:
					switch (num3)
					{
					case 3270069581u:
						break;
					case 2609711505u:
						if (!BFEors4wkM18Fb9BO3H8(P_0, xBXvMc4wNgtDW8im8vyE(-991861155 ^ -991875145)))
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
							{
								num2 = 0;
							}
							goto end_IL_0012;
						}
						Eq02jRwOfiN.rqW2XCq2dO8(Settings.ChartSettings.DataCycle);
						num2 = 23;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
						{
							num2 = 3;
						}
						goto end_IL_0012;
					default:
						return;
					}
					if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C9E4BA))
					{
						goto IL_06f2;
					}
					return;
				case 8:
					return;
				case 19:
					if (num3 > 1506567441)
					{
						if (num3 <= 3270069581u)
						{
							if (num3 != 2136810001)
							{
								num2 = 14;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
								{
									num2 = 12;
								}
							}
							else if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D314164))
							{
								Eq02jRwOfiN.GXT2XKU3Cpw(SlrXvE4w1PdPEu9yHRQ0(Settings.ChartSettings));
								num2 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
								{
									num2 = 11;
								}
							}
							else
							{
								num2 = 14;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
								{
									num2 = 18;
								}
							}
							break;
						}
						if (num3 <= 3462837544u)
						{
							switch (num3)
							{
							default:
								return;
							case 3334938871u:
								if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602185537)))
								{
									num2 = 12;
									goto end_IL_0012;
								}
								JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53745746));
								num2 = 5;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
								{
									num2 = 5;
								}
								goto end_IL_0012;
							case 3462837544u:
								if (BFEors4wkM18Fb9BO3H8(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2D478F)))
								{
									Eq02jRwOfiN.mFL2cGe9obK(Settings.ChartTrading);
									num2 = 16;
									goto end_IL_0012;
								}
								num = 13;
								break;
							}
							goto end_IL_0012_2;
						}
						switch (num3)
						{
						default:
							return;
						case 4035769824u:
							break;
						case 4243586282u:
							if (BFEors4wkM18Fb9BO3H8(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46624109)))
							{
								JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D318BCD));
							}
							return;
						}
						if (!(P_0 == (string)xBXvMc4wNgtDW8im8vyE(0x32DEA4F1 ^ 0x32DED6C7)))
						{
							return;
						}
					}
					else
					{
						if (num3 > 272298094)
						{
							if (num3 > 927636608)
							{
								num2 = 3;
								break;
							}
							goto case 6;
						}
						switch (num3)
						{
						case 43637510u:
							if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671186741))
							{
								JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606909408));
							}
							return;
						case 192205763u:
							break;
						default:
							num2 = 9;
							goto end_IL_0012;
						}
						if (!BFEors4wkM18Fb9BO3H8(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878920570)))
						{
							return;
						}
					}
					goto IL_06f2;
				case 10:
					return;
				case 6:
					if (num3 == 362859610)
					{
						if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297433F)))
						{
							return;
						}
						goto IL_06f2;
					}
					num2 = 17;
					break;
				case 23:
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42D818EF));
					num2 = 2;
					break;
				case 22:
					return;
				case 0:
					return;
				case 9:
					if (num3 == 272298094)
					{
						if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F64DE16)))
						{
							return;
						}
						goto IL_06f2;
					}
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 22;
					}
					break;
				case 7:
					return;
				case 3:
					switch (num3)
					{
					case 1506567441u:
						break;
					case 1344738335u:
						if (P_0 == (string)xBXvMc4wNgtDW8im8vyE(-1153206687 ^ -1153185249))
						{
							IsChartToolBarsVisible = j18iDj9nukSCmEyZs5lH.Settings.IsChartToolBarsVisible;
						}
						return;
					default:
						num2 = 8;
						goto end_IL_0012;
					}
					if (!BFEors4wkM18Fb9BO3H8(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203031662)))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_06f2;
				case 21:
					return;
				case 12:
					return;
				case 5:
					{
						JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x119125D));
						JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16ADC0F6));
						JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD5060B));
						num2 = 21;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
						{
							num2 = 5;
						}
						break;
					}
					IL_06f2:
					JZYHkZsWiJ6((string)xBXvMc4wNgtDW8im8vyE(-962524685 ^ -962492027));
					return;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
		}
	}

	private void JVm2cW6cQhJ()
	{
		Eq02jRwOfiN?.g7N2XrQWg3S();
	}

	public void rmF2ctrIrjq()
	{
		JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B7C9F5));
	}

	[CompilerGenerated]
	private void LuO2cUWslPn(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void VkA2cTVj9ua(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void poA2cyE8qDQ(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void LNh2cZinFud(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(P_1));
	}

	[CompilerGenerated]
	private void fYL2cVlnq1s(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void jWB2cC5oB7Z(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(P_1));
	}

	[CompilerGenerated]
	private void SrS2crlGZIo(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void xau2cKI06Lu(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP(P_1.PropertyName);
	}

	[CompilerGenerated]
	private void Q8y2cmjt63A(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(P_1));
	}

	[CompilerGenerated]
	private void SyJ2chgmOR9(object P_0, PropertyChangedEventArgs P_1)
	{
		nfs2cI771NP((string)RGi0U44wRpHWr4uY5HmO(P_1));
	}

	[CompilerGenerated]
	private void kjF2cwgnXJU(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			Eq02jRwOfiN.PdP2X6Nc4gS(text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
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

	[CompilerGenerated]
	private void ENd2c7BhEuq(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			H2ANRu4w6t0M38qVfyly(Eq02jRwOfiN, text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
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

	[CompilerGenerated]
	private void aMh2c8Ps3ow(object P_0)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = P_0 as string;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!string.IsNullOrEmpty(text))
				{
					Eq02jRwOfiN.hOB2XIBm0tE(text);
				}
				return;
			}
		}
	}

	[CompilerGenerated]
	private void WSt2cAlggYC(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Eq02jRwOfiN.PdP2X6Nc4gS(text);
		}
	}

	[CompilerGenerated]
	private void PuD2cPpUncF(object P_0)
	{
		string text = P_0 as string;
		if (!string.IsNullOrEmpty(text))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				mycy5LHEu3qqvRcny9Mb.TanHQByRbjC(text);
				Eq02jRwOfiN.Chart.uYW9uLtOwpS(text, null);
				break;
			}
		}
	}

	static C3n99U2cM72ZWgX9k0DW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void WZJ2xd4wBmmdSdQEhgov()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object oZEqGM4waVYLXq221K4O(object P_0)
	{
		return ((ChartingSettings)P_0).ChartSettings;
	}

	internal static void dc51c94widtuTaPKN5DT(object P_0, object P_1)
	{
		((wNkTg8flwnoQb0vtSgf4)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static object gibsph4wlbH1yGGMD0Vo(object P_0)
	{
		return ((ChartingSettings)P_0).MarketSettings;
	}

	internal static void kkNPXu4w4ghIKQ3VEe75(object P_0, object P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static object B0j6tt4wDNVreahhHRvF(object P_0)
	{
		return ((MarketSettings)P_0).Preset3;
	}

	internal static object QVydPj4wb9WevC2grTpf()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool A7LL0I4wogTHsqI3ZKu9()
	{
		return kvEuof4wYJNScDf3bwlX == null;
	}

	internal static C3n99U2cM72ZWgX9k0DW pd27Fd4wv4e4aq82pc1N()
	{
		return kvEuof4wYJNScDf3bwlX;
	}

	internal static object xBXvMc4wNgtDW8im8vyE(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool BFEors4wkM18Fb9BO3H8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int SlrXvE4w1PdPEu9yHRQ0(object P_0)
	{
		return ((ChartSettings)P_0).DataScale;
	}

	internal static bool tgw2xO4w5sysdeSnuTnB(object P_0)
	{
		return ((ChartingSettings)P_0).ChartTrading;
	}

	internal static int o7wWui4wSGuXPe55drsE(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).QuoteCurrencyOrderDecimals;
	}

	internal static object hJrKy24wxoeAK6g5gNkd(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static double fDF5w54wLeGyt3NoSaWZ(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize;
	}

	internal static bool HpYosi4weIGgRnL270GF(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInPercents;
	}

	internal static object bxDUAa4wsoB6nbRx9KJV(object P_0)
	{
		return ((MarketSettings)P_0).CurrentPreset;
	}

	internal static double uOFLcm4wXbGH8qcEljgD(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).Size;
	}

	internal static StockViewType CFFc7e4wcKpWQZEyGewA(object P_0)
	{
		return ((ChartSettings)P_0).StockViewType;
	}

	internal static object rHKiI14wjxH6aIHX7i0d(object P_0)
	{
		return ((ChartSettings)P_0).DataCycle;
	}

	internal static ClusterViewPreset qMRhxD4wEtO7fiutrQVG(object P_0)
	{
		return ((KO34fu9L5FtbhDmWJ1ad)P_0).ClusterPreset;
	}

	internal static bool zuKXY84wQn84Fec61xuX(object P_0)
	{
		return ((DBmQUM2XiyOP3m87eGbR)P_0).IsMarketLocked;
	}

	internal static SymbolType d7JfPW4wdGCJW95Fm1SY(object P_0)
	{
		return ((DocLinkContext)P_0).SymbolType;
	}

	internal static void XG6mMr4wgTyWwKk04fLy(object P_0, bool value)
	{
		((ChartingSettings)P_0).ChartTrading = value;
	}

	internal static object RGi0U44wRpHWr4uY5HmO(object P_0)
	{
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	internal static void H2ANRu4w6t0M38qVfyly(object P_0, object P_1)
	{
		((DBmQUM2XiyOP3m87eGbR)P_0).vHL2XqUxgWy((string)P_1);
	}
}
