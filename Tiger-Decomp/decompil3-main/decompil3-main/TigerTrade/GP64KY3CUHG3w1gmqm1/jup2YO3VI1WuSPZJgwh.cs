using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using AATf3mfJjZpwVnWWKVaj;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Primitives;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AQB6mgf3wjOUxVfiEwwS;
using bl7Or1fDrLHNeTtGhT82;
using CA00IGfn6UyfKXYOM3Is;
using CfRULU2btb1wjWVeHetO;
using CjttZVHEzEWfhqQAXjq2;
using CnCI7u2nBRrKUMVOI0eu;
using CrFtHPuvP7Ob5vDkI3B;
using cY9HKMfP6DC0C8LIwE00;
using dpoTZ395JPmKdIOgCedl;
using Dq9qGtf0S8tbnXB1O4NE;
using ECOEgqlSad8NUJZ2Dr9n;
using ERYrrtfAii1p1u2fKgSW;
using Fb8gFFHFUNPFVH1wej60;
using FbEh2t9xijg3wW8B3f8g;
using frVhYEG2rKDqTejMVStw;
using FRWSJefvmjvdhsvbqpSj;
using ft4IOl2kyqsXh3EvCREm;
using Gr29Orf7gQ0hYTcjv5xg;
using GwAxeSHHpSUfiieBdRr0;
using gxD08uHfRlYxqcar8kRI;
using GZ2P1p2nUOwcS3pa9CZv;
using iCB0AL2fIRb7BF0NvFlP;
using If1oyCHiFG4LnIUAsfeE;
using inUerCfHMLVDbG9HvwwZ;
using J3rFECfGQmHQ9sLCyCue;
using jKxkD8HfxfM8pAInciSU;
using k2djPS9h3aXysXOe0uK1;
using kHAs2cfl7hDVW64jByhf;
using lFsEWXfkgLYLS0FUKGT5;
using LKPssPfwOEBXRql5l3eT;
using LPq3llG3QX4HMCBL7b1Q;
using lYnHpK20R1M7D7DHOK9Z;
using M7Qhok2zS37wTYN0rqJn;
using mjh1ZU2Dj2wC6DxZG11n;
using n4LmhZHDb0i8YpSGr2Xl;
using nAvYJWf1bMGCThCuJqPY;
using nDRVH5fO2N3bDxUGOOrY;
using NHkZqbf77HnCtq0ER8ta;
using NjRsCt2WsDfbeZXtjdEb;
using NsWD4W9miMxRbFU3fsu9;
using NT979y9m45Sv3wCbqRk9;
using o1srKL9PWRC5v3sURMga;
using ocMo2C2OFi7RLs2TMtAp;
using OeDfor9RTp5UsIKlhnMc;
using OZ65ngfB5c7bG1vuvCsP;
using PGh1t097dKGNtpYw9WbJ;
using pieN9WfFYEsJTSrYSp5q;
using PosIhkfBXsapbL9iTTDK;
using pxn4IO9xknWTjdUGV7xW;
using q6Lcl3fBRQ8ycXy3QOHi;
using Q9SRf6fP4t6MCx6w6Nh8;
using QGBcuKoF6l1BCNnN4Xyj;
using RNVda52xiPon1C9Km8N2;
using ROhuQx9FcGTLTqPCaJ0j;
using scqDIK3IgvatbTpcZJG;
using tD39i62nM81VScsBfmmJ;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.List;
using TigerTrade.Chart.Trading;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Controls.Notifications;
using TigerTrade.UI.DocControls.Common.Link;
using TigerTrade.UI.DocControls.Trading.Controls.MarketTrader;
using TigerTrade.UI.DocControls.Trading.Settings;
using TigerTrade.UI.Windows;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;
using u32xe92XlvPUasWqNL4b;
using UkCBLCfHuQFl5NlX4Kva;
using UMI2GBGJ3kloSb47d3eV;
using UQo6BdfP2mN8TGiUMEQT;
using USRHnUfw24BLQEfEWDPm;
using uZqyk925mKGgabaJGJq6;
using V9ObVI9gCxZjgUce1Uw4;
using W4BXnjf5KNoQq2fwC7Ij;
using W6AYNifP3Wtfy4tlsRwe;
using w9hQBe20HnWxvgk0I5BS;
using waDpctGJom9MvAveNXHq;
using WkeonX2f4J94VEB2cM3i;
using wOu7adH9ySPbXWlURJCL;
using wse3wd2zgF9O4VW2DUfZ;
using xhulFc2DTsAififEkcHC;
using xIFN882xDj3AcM7r1d4F;
using XUi8EWf1E6l7gdu7kUS9;
using YA6KVZ2VqOjEMGvnhFsg;
using yDO8qofhQHpBlOTGIf1I;
using zElFka21P2MCOULmbbpW;
using zgMYdJf4fc58NIsUuLGN;

namespace GP64KY3CUHG3w1gmqm1;

internal sealed class jup2YO3VI1WuSPZJgwh : waq1Af2bWXQbeynqsiXl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Sa0aRFnQkBHHrB19y9wT
	{
		public static readonly Sa0aRFnQkBHHrB19y9wT WKhnQe7rZAl;

		public static Func<BpmEftf7wYbuVebk5Vku, bool> ReAnQs5Zu5L;

		public static Func<HorizontalLineObject, bool> wimnQXysj7u;

		public static Func<BpmEftf7wYbuVebk5Vku, bool> zATnQclD6Br;

		public static Func<BpmEftf7wYbuVebk5Vku, bool> qpYnQjvin49;

		public static Func<ex6KFw2WejF3Y0Rqo9YD, bool> Hg0nQEgRmZD;

		internal static Sa0aRFnQkBHHrB19y9wT SD6BF7Nl0cJkmk2yr1rq;

		static Sa0aRFnQkBHHrB19y9wT()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					jfdPf8Nlf19oNgpAJ6uS();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					WKhnQe7rZAl = new Sa0aRFnQkBHHrB19y9wT();
					return;
				}
			}
		}

		public Sa0aRFnQkBHHrB19y9wT()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool IAbnQ10nk1a(BpmEftf7wYbuVebk5Vku lvl)
		{
			return ((tQdY3yfPR6B0dxodinwZ)lvl).YNJfPtJgce2;
		}

		internal bool pjHnQ5mXSsS(HorizontalLineObject universalSignalLevel)
		{
			return string.IsNullOrEmpty((string)xgZGA6Nl98OcYL5Hn5UA(universalSignalLevel));
		}

		internal bool YDBnQSdo4gf(BpmEftf7wYbuVebk5Vku lvl)
		{
			return auB0CGNlnvVRrsgogtGn((tQdY3yfPR6B0dxodinwZ)lvl);
		}

		internal bool YMTnQxkZ6Vn(BpmEftf7wYbuVebk5Vku lvl)
		{
			return ((tQdY3yfPR6B0dxodinwZ)lvl).YNJfPtJgce2;
		}

		internal bool WFQnQLs9eTX(ex6KFw2WejF3Y0Rqo9YD s)
		{
			return s.JgL2WdI2A3a().z9l2O3qrToV();
		}

		internal static void jfdPf8Nlf19oNgpAJ6uS()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool DdKGu8Nl2T1fU2nHkwbH()
		{
			return SD6BF7Nl0cJkmk2yr1rq == null;
		}

		internal static Sa0aRFnQkBHHrB19y9wT iqv74mNlHBS5IOblVe80()
		{
			return SD6BF7Nl0cJkmk2yr1rq;
		}

		internal static object xgZGA6Nl98OcYL5Hn5UA(object P_0)
		{
			return ((ObjectBase)P_0).ObjectID;
		}

		internal static bool auB0CGNlnvVRrsgogtGn(object P_0)
		{
			return ((tQdY3yfPR6B0dxodinwZ)P_0).YNJfPtJgce2;
		}
	}

	[CompilerGenerated]
	private sealed class UY7WKDnQQy9LXw65Pbpi
	{
		public BpmEftf7wYbuVebk5Vku Ho8nQgoDFYw;

		internal static UY7WKDnQQy9LXw65Pbpi HwjKQHNlGgtd05yENs1B;

		public UY7WKDnQQy9LXw65Pbpi()
		{
			dT72N5NlvvEQROYIiSul();
			base._002Ector();
		}

		internal bool rcVnQdoTaKS(HorizontalLineObject l)
		{
			return GAasLMNlawlTwTxlx135(l.ObjectID, lT5vTlNlBUTJOqg93U9F(Ho8nQgoDFYw));
		}

		static UY7WKDnQQy9LXw65Pbpi()
		{
			c6J901NliBq9gT8mK2Ao();
		}

		internal static void dT72N5NlvvEQROYIiSul()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool PDxjT3NlYE8e44UoJbdM()
		{
			return HwjKQHNlGgtd05yENs1B == null;
		}

		internal static UY7WKDnQQy9LXw65Pbpi YaOMMNNlo1S2oYjABETp()
		{
			return HwjKQHNlGgtd05yENs1B;
		}

		internal static object lT5vTlNlBUTJOqg93U9F(object P_0)
		{
			return ((BpmEftf7wYbuVebk5Vku)P_0).balf7pvwCJI;
		}

		internal static bool GAasLMNlawlTwTxlx135(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void c6J901NliBq9gT8mK2Ao()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class Xk01qCnQRGKSpHLKWC9x
	{
		public string qGPnQMMjZgE;

		internal static Xk01qCnQRGKSpHLKWC9x cTf1VgNllfedm6vo6uhx;

		public Xk01qCnQRGKSpHLKWC9x()
		{
			F6Yy5XNlbSQU2guVDlP8();
			base._002Ector();
		}

		internal bool dMWnQ6uhJk7(BpmEftf7wYbuVebk5Vku l)
		{
			return (string)VG8oCnNlNkFVTioT06UG(l as cHDH2xfPlID4okPS4Qpr) == qGPnQMMjZgE;
		}

		static Xk01qCnQRGKSpHLKWC9x()
		{
			stiLiDNlkfUSMX0pxsbj();
		}

		internal static void F6Yy5XNlbSQU2guVDlP8()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool yqGsTcNl4ZmJ7KthCdF8()
		{
			return cTf1VgNllfedm6vo6uhx == null;
		}

		internal static Xk01qCnQRGKSpHLKWC9x shlIfGNlD6JubqsaufWX()
		{
			return cTf1VgNllfedm6vo6uhx;
		}

		internal static object VG8oCnNlNkFVTioT06UG(object P_0)
		{
			return ((cHDH2xfPlID4okPS4Qpr)P_0).XXnfPDsHymw();
		}

		internal static void stiLiDNlkfUSMX0pxsbj()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class rIkMUenQOxqkqbwnF0ya
	{
		public E5ZRLJfvK5UFeYCuZIcl h83nQWxqyTg;

		private static rIkMUenQOxqkqbwnF0ya NIjYrgNl1ikR6sOJNhWp;

		public rIkMUenQOxqkqbwnF0ya()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool iWHnQqQMmWL(BpmEftf7wYbuVebk5Vku l)
		{
			return zxTIk1NlLh88221d70KW(swKphpNlxrYS5kjiMHSD(l as cHDH2xfPlID4okPS4Qpr), h83nQWxqyTg.aDbfvwGf6HI());
		}

		internal bool LOAnQIQY3Un(BpmEftf7wYbuVebk5Vku l)
		{
			return zxTIk1NlLh88221d70KW(swKphpNlxrYS5kjiMHSD(l as cHDH2xfPlID4okPS4Qpr), h83nQWxqyTg.fbgfvAgVpun());
		}

		static rIkMUenQOxqkqbwnF0ya()
		{
			FnABTZNle2b8WEs2ux8H();
		}

		internal static bool XcB4nENl5tnYjjUXKoBT()
		{
			return NIjYrgNl1ikR6sOJNhWp == null;
		}

		internal static rIkMUenQOxqkqbwnF0ya ztBVytNlSAG0TEIx4JZh()
		{
			return NIjYrgNl1ikR6sOJNhWp;
		}

		internal static object swKphpNlxrYS5kjiMHSD(object P_0)
		{
			return ((cHDH2xfPlID4okPS4Qpr)P_0).XXnfPDsHymw();
		}

		internal static bool zxTIk1NlLh88221d70KW(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void FnABTZNle2b8WEs2ux8H()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class AvPVdFnQtfD0E8fI1m2e
	{
		public string rB1nQTtjIdF;

		internal static AvPVdFnQtfD0E8fI1m2e aDy0vxNlsXUjWH13xalx;

		public AvPVdFnQtfD0E8fI1m2e()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool dR1nQURUCEY(BpmEftf7wYbuVebk5Vku l)
		{
			return (string)VSLDiGNljwEEP1RBWLZ1(l as cHDH2xfPlID4okPS4Qpr) == rB1nQTtjIdF;
		}

		static AvPVdFnQtfD0E8fI1m2e()
		{
			a2tJFLNlEXVuehgOgehL();
		}

		internal static bool WmZiVUNlXGcTf7aS4HTq()
		{
			return aDy0vxNlsXUjWH13xalx == null;
		}

		internal static AvPVdFnQtfD0E8fI1m2e k0m1XaNlc6knUPoLICOc()
		{
			return aDy0vxNlsXUjWH13xalx;
		}

		internal static object VSLDiGNljwEEP1RBWLZ1(object P_0)
		{
			return ((cHDH2xfPlID4okPS4Qpr)P_0).XXnfPDsHymw();
		}

		internal static void a2tJFLNlEXVuehgOgehL()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private TradingSettings vCNppNY9xh;

	[CompilerGenerated]
	private int? s2ipuqtGDD;

	private bool U88pz84cOT;

	private bool Yf0u0W3stl;

	private MarketSettings Yusu2kWUP1;

	private readonly vOadlr9xaVCgXpG0X5P3 tGJuH3h7mp;

	private readonly pPoPrc3qBX4fc5gckU0 Oltuf3oL6B;

	private lFstfvuoXTH8701fWFf stcu9vAiSU;

	private zUNI16202mQmpx9T2Hxb TA9unPmdcl;

	private bool MtiuGodGoW;

	internal jup2YO3VI1WuSPZJgwh ThisControl;

	internal Slider SliderZoom;

	internal ContentControl PopupPlace;

	internal Popup PopupSelectSymbols;

	internal ToolBarTray ToolBarTrayTop;

	internal ToolBarTray ToolBarTrayBottom;

	internal ToolBarTray ToolBarTrayLeft;

	internal ToolBarTray ToolBarTrayRight;

	internal AnimatedExpander TradeSettingsExpander;

	internal DockPanel MarketSettingsPanel;

	internal Button ButtonCloseTradeSettings;

	internal AnimatedExpander MarketTraderExpander;

	internal MarketTraderControl MarketTraderControl;

	internal mrGdQof1Dl8Jsg7DRfOq Market;

	private bool MYFuY9YILY;

	private static jup2YO3VI1WuSPZJgwh VZGEK34eV7rA7fKrFZ3H;

	public lFstfvuoXTH8701fWFf ViewModel
	{
		get
		{
			return stcu9vAiSU;
		}
		set
		{
			stcu9vAiSU = lFstfvuoXTH8701fWFf;
			KEi2Soek3o0(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741BF57B));
		}
	}

	public zUNI16202mQmpx9T2Hxb TradeSettingsControl
	{
		get
		{
			object obj = TA9unPmdcl;
			if (obj == null)
			{
				obj = new zUNI16202mQmpx9T2Hxb
				{
					Name = (string)jqdeOo4eKgiRI3O5pbjF(-1774602229 ^ -1774597939)
				};
				F5CwmN4em54Wbnu1ioQo(obj, 300.0);
			}
			zUNI16202mQmpx9T2Hxb result = (zUNI16202mQmpx9T2Hxb)obj;
			TA9unPmdcl = (zUNI16202mQmpx9T2Hxb)obj;
			return result;
		}
	}

	public override int LinkGroup
	{
		get
		{
			TradingSettings tradingSettings = vCNppNY9xh;
			int? num3;
			int? num;
			if (tradingSettings == null)
			{
				num = null;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				num3 = num;
			}
			else
			{
				num3 = tradingSettings.LinkGroupID;
			}
			num = num3;
			return num.GetValueOrDefault();
		}
		protected set
		{
			vCNppNY9xh.LinkGroupID = value2;
			Symbol symbol = iu52S2PbqF0();
			if (symbol != null)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				SetSymbol(symbol);
			}
		}
	}

	public override bool LinkActiveWindow
	{
		get
		{
			return vCNppNY9xh?.LinkActiveWindow ?? false;
		}
		protected set
		{
			vCNppNY9xh.LinkActiveWindow = flag;
		}
	}

	public bool IsMarketLocked => base.DocLinkContext.IsMarketLocked;

	[SpecialName]
	[CompilerGenerated]
	public int? CwYp7ya87n()
	{
		return s2ipuqtGDD;
	}

	[SpecialName]
	[CompilerGenerated]
	public void JUvp8cAh5m(int? P_0)
	{
		s2ipuqtGDD = P_0;
	}

	public jup2YO3VI1WuSPZJgwh(DockingWindow P_0)
	{
		WpHavP4ehN3WFCBY6oNi();
		tGJuH3h7mp = new vOadlr9xaVCgXpG0X5P3(200);
		base._002Ector(P_0, lOqyZR2xahfYNVbq7H4p.Trading);
		Q5v2kOaqAYe.QFAG2zTpFli(base.YZD2bKK0Yxb);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
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
				Q5v2kOaqAYe.I1JGHHk9Qd1(Timer2Tick);
				InitializeComponent();
				vCNppNY9xh = aJ42S93GFJy<TradingSettings>(EGk2SmdrsFj()) ?? new TradingSettings();
				num = 2;
				break;
			case 0:
				return;
			case 3:
				base.DocLinkContext.SymbolType = FEM2x99fKpn.Value;
				num = 5;
				break;
			case 6:
				base.DocLinkContext.PropertyChanged += Asv3r1lrMm;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				base.DocLinkContext.NoSwitchPair = iEd1DD4e7EpvL4Tg8j59(vCNppNY9xh);
				base.DocLinkContext.IsExchangeLocked = vCNppNY9xh.IsExchangeLocked;
				base.DocLinkContext.LockedExchange = (string)YuMpeF4e88B5i15175HO(vCNppNY9xh);
				Market.Ub6f1RDY7uw(vCNppNY9xh.MarketSettings, vCNppNY9xh);
				Market.jUjf1NJ6T0S();
				num = 6;
				break;
			case 2:
				Oltuf3oL6B = new pPoPrc3qBX4fc5gckU0(vCNppNY9xh);
				Xul9UB4ewIbAOQRNbGxU(base.DocLinkContext, vCNppNY9xh.IsMarketLocked);
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num = 7;
				}
				break;
			case 4:
				IUX2xncaSZt = FEM2x99fKpn;
				if (FEM2x99fKpn.HasValue)
				{
					num = 3;
					break;
				}
				goto case 5;
			case 7:
				FEM2x99fKpn = (SymbolType?)vCNppNY9xh.LockedMarketSymbolType;
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	private void Asv3r1lrMm(object P_0, PropertyChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (PiRdLU4eP6bfF2V9Ch3L(OGGFLF4eAc5gQrtNiSgc(P_1), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB150966)))
				{
					break;
				}
				return;
			case 2:
				if (P_1.PropertyName == (string)jqdeOo4eKgiRI3O5pbjF(-90307782 ^ -90278962))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			case 1:
				break;
			}
			break;
		}
		ViewModel?.g2IuNeC9Ga();
	}

	private void TuF3Ky9N0x(object P_0, PropertyChangedEventArgs P_1)
	{
		int num = 6;
		int num2 = num;
		string propertyName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002290561)))
				{
					U88pz84cOT = true;
				}
				return;
			case 3:
				return;
			default:
				vCNppNY9xh.MarketSettings.RecalculateBaseLot(Yusu2kWUP1);
				num2 = 4;
				break;
			case 6:
				propertyName = P_1.PropertyName;
				num2 = 5;
				break;
			case 1:
				if (PiRdLU4eP6bfF2V9Ch3L(propertyName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193010244)) || PiRdLU4eP6bfF2V9Ch3L(propertyName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746EA569)))
				{
					Oltuf3oL6B.uPr3tlxi8L();
					return;
				}
				if (propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123787715))
				{
					if (!Yf0u0W3stl)
					{
						return;
					}
					Yf0u0W3stl = false;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 5:
				if (propertyName == (string)jqdeOo4eKgiRI3O5pbjF(-530053095 ^ -530024139))
				{
					QqVL4t4eJohD4vfCiweC(Oltuf3oL6B);
					U88pz84cOT = true;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	private void K3j3mRLELo(object P_0, PropertyChangedEventArgs P_1)
	{
		string propertyName = P_1.PropertyName;
		int num2;
		if (!(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3417273)))
		{
			if (propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x12627390))
			{
				Market.HwndHost.SetTimerInterval(j18iDj9nukSCmEyZs5lH.Settings.DomUpdateRate);
				int num = 4;
				num2 = num;
			}
			else
			{
				if (!(propertyName == (string)jqdeOo4eKgiRI3O5pbjF(0x9F0F634 ^ 0x9F08422)))
				{
					if (!PiRdLU4eP6bfF2V9Ch3L(propertyName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -617076197)))
					{
						goto IL_0034;
					}
					goto IL_007d;
				}
				num2 = 3;
			}
		}
		else
		{
			SetSwitchMarketStatus(base.Symbol?.IsLinkable ?? false);
			num2 = 2;
		}
		goto IL_0009;
		IL_0034:
		if (!(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04549E)) && !(propertyName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461970584)))
		{
			return;
		}
		goto IL_007d;
		IL_0009:
		switch (num2)
		{
		case 4:
			return;
		case 3:
			goto IL_007d;
		case 1:
			return;
		case 2:
			return;
		}
		goto IL_0034;
		IL_007d:
		Market.NeedRedraw(_0020: true);
		num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
		{
			num2 = 1;
		}
		goto IL_0009;
	}

	private void nPs3hsAFOA(int P_0 = 0)
	{
		int num = 3;
		int num2 = num;
		MarketSettings marketSettings = default(MarketSettings);
		MarketSettings marketSettings2 = default(MarketSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				kDi3wVNbfP(marketSettings.UniversalSignalLevels, vCNppNY9xh.MarketSettings.SignalLevels.IDQfPHZll5G((string)yVQVLd4eupt8puSOQgZq(vCNppNY9xh)));
				num2 = 4;
				break;
			case 5:
				marketSettings.UniversalSignalLevels = marketSettings2.UniversalSignalLevels;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (JR62S6js1Bp())
				{
					MarketSettings marketSettings3 = new MarketSettings();
					rVMKpw4eFNFEdyiFVxt9(marketSettings3, Guid.NewGuid().ToString());
					marketSettings3.ContainsTheme = false;
					MexLBV4e3mggAonED8LM(marketSettings3, false);
					marketSettings3.PresetAdjViaScrollMode = vCNppNY9xh.MarketSettings.PresetAdjViaScrollMode;
					marketSettings = marketSettings3;
					marketSettings.CopySettings((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), saveTemplate: true, withLots: true, applyTemplate: false, withLevels: true, vCNppNY9xh.Qom210PQiuE);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num2 = 2;
					}
				}
				break;
			case 1:
				marketSettings2 = (MarketSettings)(YyMvfa4ez3dugQ59kYaT(jqdeOo4eKgiRI3O5pbjF(0x6E2DFBED ^ 0x6E2D892B), yVQVLd4eupt8puSOQgZq(vCNppNY9xh)) ?? marketSettings);
				num2 = 5;
				break;
			case 4:
			{
				List<BpmEftf7wYbuVebk5Vku> list = (from lvl in ((YiXl9IfP06OkWU6fDkUP)lgmcOX4s0jGvkPpntGjk(marketSettings)).IDQfPHZll5G(vCNppNY9xh.Qom210PQiuE)
					where ((tQdY3yfPR6B0dxodinwZ)lvl).YNJfPtJgce2
					select lvl).ToList();
				((YiXl9IfP06OkWU6fDkUP)lgmcOX4s0jGvkPpntGjk(marketSettings)).Ia0fPf3Ad95(vCNppNY9xh.Qom210PQiuE, list);
				marketSettings.Levels.Ia0fPf3Ad95((string)yVQVLd4eupt8puSOQgZq(vCNppNY9xh), marketSettings.Levels.IDQfPHZll5G(vCNppNY9xh.Qom210PQiuE));
				if (seXOpL4sHJDFWDKNHirB(DSK7UK4s2C6SiQmrGArN(marketSettings)))
				{
					marketSettings.Account = aW1pHpqHfh(vCNppNY9xh.Qom210PQiuE);
				}
				EKVIQxfkdb0qc2T2DNLL.ulFfkT3srwY(zBI2Sjoyuyr(), vCNppNY9xh.Qom210PQiuE, marketSettings, P_0);
				return;
			}
			}
		}
	}

	private void kDi3wVNbfP(List<HorizontalLineObject> P_0, List<BpmEftf7wYbuVebk5Vku> P_1)
	{
		foreach (HorizontalLineObject item in P_0.Where((HorizontalLineObject universalSignalLevel) => string.IsNullOrEmpty((string)Sa0aRFnQkBHHrB19y9wT.xgZGA6Nl98OcYL5Hn5UA(universalSignalLevel))))
		{
			item.ObjectID = Guid.NewGuid().ToString();
			LogInfo(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E045420), vCNppNY9xh.Qom210PQiuE, item.Price));
		}
		List<HorizontalLineObject> list = new List<HorizontalLineObject>(P_0);
		using List<BpmEftf7wYbuVebk5Vku>.Enumerator enumerator2 = P_1.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			UY7WKDnQQy9LXw65Pbpi CS_0024_003C_003E8__locals3 = new UY7WKDnQQy9LXw65Pbpi();
			CS_0024_003C_003E8__locals3.Ho8nQgoDFYw = enumerator2.Current;
			if (CS_0024_003C_003E8__locals3.Ho8nQgoDFYw is tQdY3yfPR6B0dxodinwZ { YNJfPtJgce2: false } tQdY3yfPR6B0dxodinwZ)
			{
				int num = list.FindIndex((HorizontalLineObject l) => UY7WKDnQQy9LXw65Pbpi.GAasLMNlawlTwTxlx135(l.ObjectID, UY7WKDnQQy9LXw65Pbpi.lT5vTlNlBUTJOqg93U9F(CS_0024_003C_003E8__locals3.Ho8nQgoDFYw)));
				if (num >= 0)
				{
					list[num].Alert.Active = tQdY3yfPR6B0dxodinwZ.Alert.IsActive;
					list.RemoveAt(num);
				}
			}
		}
	}

	private List<BpmEftf7wYbuVebk5Vku> aNW37vPPeA(Symbol P_0, List<HorizontalLineObject> P_1)
	{
		List<BpmEftf7wYbuVebk5Vku> list = new List<BpmEftf7wYbuVebk5Vku>();
		if (P_0 == null)
		{
			return list;
		}
		foreach (HorizontalLineObject item in P_1)
		{
			if (!(item.SymbolID != P_0.ID))
			{
				tQdY3yfPR6B0dxodinwZ tQdY3yfPR6B0dxodinwZ = new tQdY3yfPR6B0dxodinwZ
				{
					balf7pvwCJI = item.ObjectID,
					YNJfPtJgce2 = false,
					u2Uf80PdXgt = P_0.Step,
					YHbf8fE2TKg = P_0.Precision,
					Text = item.Text,
					RealPrice = item.Price,
					LineColor = item.LineColor,
					ActiveAlertLineColor = item.ActiveAlertLineColor,
					LineWidth = item.LineWidth,
					LineStyle = item.LineStyle
				};
				tQdY3yfPR6B0dxodinwZ.Alert.Copy(item.Alert, copyActive: true);
				list.Add(tQdY3yfPR6B0dxodinwZ);
			}
		}
		return list;
	}

	protected override void OnEditLotExecute(MarketSettings P_0)
	{
		int num;
		object obj;
		if (P_0.ChoiceOfCurrency)
		{
			if (Xjr2NuoB2iw() == 0L)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num = 0;
				}
			}
			else
			{
				Account account = Account;
				if (account != null)
				{
					obj = YNRY934sfvZVrrlH44LX(account);
					goto IL_00aa;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num = 1;
				}
			}
			goto IL_0009;
		}
		goto IL_0082;
		IL_0082:
		base.OnEditLotExecute(P_0);
		return;
		IL_0009:
		double num2 = default(double);
		switch (num)
		{
		case 2:
			base.CurrencyFreeMargin = num2;
			break;
		case 1:
			goto IL_009f;
		}
		goto IL_0082;
		IL_00aa:
		num2 = mVmMkK4s9F6QcBfvA5WC(obj, base.Symbol);
		num = 2;
		goto IL_0009;
		IL_009f:
		obj = null;
		goto IL_00aa;
	}

	protected override void OnSetLeverage(double P_0)
	{
		if (!gSuEEg4sngyHQFpBOdU9(MarketTraderControl.ViewModel))
		{
			MarketTraderControl.ViewModel.Leverage = P_0;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			base.Leverage = P_0;
		}
	}

	protected override void SetSwitchMarketStatus(bool P_0)
	{
		if (!j18iDj9nukSCmEyZs5lH.Settings.MarketShowMarketButton)
		{
			base.SetSwitchMarketStatus(_0020: false);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
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
			base.SetSwitchMarketStatus(P_0);
		}
	}

	protected override int GetDataScale(string P_0)
	{
		return vCNppNY9xh.MarketSettings.GetDataScale(P_0);
	}

	private double JLW38MA3gp()
	{
		if (ViewModel == null || Market == null)
		{
			return 0.0;
		}
		Market.wyOfSKBQnal(out var num, out var num2, out var num3);
		int num4 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
		{
			num4 = 0;
		}
		return num4 switch
		{
			_ => (double)(num2 - num) / (double)num3 * (double)ViewModel.DataScale / 2.0, 
		};
	}

	private void oCf3AiCgJK(BAEtAp2DUfuBKyaAJXwQ P_0)
	{
		int num = 1;
		int num2 = num;
		BlmlL92DciZPrtYF1X4r blmlL92DciZPrtYF1X4r = default(BlmlL92DciZPrtYF1X4r);
		IEnumerator<ToolBar> enumerator2 = default(IEnumerator<ToolBar>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				Q0Hjwp4soL1ePo3NXq3y(ysBJuVHH3iwGVb253LJm.qKIHHzlmlOx(), this);
				return;
			case 1:
				blmlL92DciZPrtYF1X4r = P_0.Type;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				{
					switch (blmlL92DciZPrtYF1X4r)
					{
					case (BlmlL92DciZPrtYF1X4r)8:
						Market.ScrollCenter();
						return;
					case (BlmlL92DciZPrtYF1X4r)6:
						return;
					case (BlmlL92DciZPrtYF1X4r)5:
						Vr9pDYMFrh();
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					default:
						return;
					case (BlmlL92DciZPrtYF1X4r)7:
						break;
					case (BlmlL92DciZPrtYF1X4r)4:
						ApplyTheme((brG9LqfO0TVwbKGahwYo)((P_0.MUR2DZAdtqg() == null) ? IwdJX64sGqrCBGAr2nNM() : (P_0.MUR2DZAdtqg() as brG9LqfO0TVwbKGahwYo)), global: false);
						return;
					}
					foreach (ToolBarTray item in new List<ToolBarTray> { ToolBarTrayTop, ToolBarTrayLeft, ToolBarTrayRight, ToolBarTrayBottom })
					{
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								enumerator2 = item.ToolBars.GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							try
							{
								while (enumerator2.MoveNext())
								{
									BindingOperations.ClearBinding(enumerator2.Current, ItemsControl.ItemsSourceProperty);
									int num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
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
								if (enumerator2 != null)
								{
									BZOLKu4sYeFTtsjj2Nbs(enumerator2);
								}
							}
							break;
						}
						item.ToolBars.Clear();
					}
					goto case 3;
				}
				end_IL_0012:
				break;
			}
		}
	}

	private void rr93Pvgu7U()
	{
		if (base.Symbol == null || !DJZIL54sBtWgYkynNBcZ(RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)))
		{
			return;
		}
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = (ypqMIv9maFM0tRwF0xMh)cUent24sadqsJDXJh6o2(iry2NPTGQJC(), base.Symbol.ID);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
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
				if (ypqMIv9maFM0tRwF0xMh == null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
					{
						num = 0;
					}
					break;
				}
				pCDdlo4si0LuaIfiVQmE(RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl), ypqMIv9maFM0tRwF0xMh);
				return;
			case 0:
				return;
			}
		}
	}

	protected override void Dispose(bool P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Q5v2kOaqAYe.QmGGH06wrkk(base.YZD2bKK0Yxb);
				num2 = 4;
				break;
			case 2:
				base.DocLinkContext.PropertyChanged -= Asv3r1lrMm;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				hBCvUb4s4wTFQmgKVnWL(Q5v2kOaqAYe, new EventHandler(Timer2Tick));
				base.Dispose(P_0);
				return;
			case 5:
				EKVIQxfkdb0qc2T2DNLL.QVPfkP4XjQI(wX4pfWpv0i);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				c8EcTUfGEuMy2llFqsdF.IYnfGFGwd0b(NGa3ujyycB);
				c8EcTUfGEuMy2llFqsdF.bQSfGuA4AhP(NmK3zO7Llp);
				if (!Vsa2SyQkClw())
				{
					Market.HfYf1xAYqQ7();
				}
				DataManager.OnOrderInfo -= base.CP72Nv9gyMh;
				num2 = 5;
				break;
			case 1:
				SAmtD64slUQsMwvk7Iqb(new Action(FOO33TAsGu));
				c8EcTUfGEuMy2llFqsdF.ilSfY2T4NuE(Bhx3pwDdBJ);
				num2 = 3;
				break;
			}
		}
	}

	public override void Serialize()
	{
		SaveSettings(EGk2SmdrsFj(), kop2Sw1sSfc(), 0);
	}

	protected override void SaveSettings(string P_0, string P_1, int P_2)
	{
		int num;
		if (!JR62S6js1Bp())
		{
			if (!string.IsNullOrEmpty((string)yVQVLd4eupt8puSOQgZq(vCNppNY9xh)))
			{
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 5;
				}
				goto IL_0009;
			}
		}
		else if (base.Symbol != null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0146;
		IL_0146:
		vCNppNY9xh.IsMarketLocked = base.DocLinkContext.IsMarketLocked;
		vCNppNY9xh.LockedMarketSymbolType = (int)FEM2x99fKpn.GetValueOrDefault();
		num = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
		{
			num = 2;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				vCNppNY9xh.IsSymbolSwitchError = base.DocLinkContext.NoSwitchPair;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 2;
				}
				continue;
			case 1:
				((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).SignalLevels.Ia0fPf3Ad95(base.Symbol.ID, Market.cDAf1tTHAUJ(base.Symbol));
				vCNppNY9xh.MarketSettings.Levels.Ia0fPf3Ad95(base.Symbol.ID, Market.YsJf1WZHLW7(base.Symbol));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				SKfGF84sDC4QpEnlBUw4(vCNppNY9xh, base.DocLinkContext.IsExchangeLocked);
				ekCWet4sbTaEoZONe1sB(vCNppNY9xh, base.DocLinkContext.LockedExchange);
				n8S2SGJFdMU(vCNppNY9xh, P_0);
				nPs3hsAFOA(P_2);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
				{
					num = 4;
				}
				continue;
			case 5:
				bsVp2Hrnge((string)yVQVLd4eupt8puSOQgZq(vCNppNY9xh));
				break;
			case 4:
				return;
			}
			break;
		}
		goto IL_0146;
	}

	private void XJh3JwlxPf()
	{
		int num = 21;
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					xtFZfM4sNxeg1p59a6So(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
					num2 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					num3 = CwYp7ya87n();
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
				{
					MarketSettings marketSettings = vCNppNY9xh.MarketSettings;
					num3 = CwYp7ya87n();
					pX4tsO4skLEHT349Bvt9(marketSettings, num3.Value);
					goto IL_0157;
				}
				default:
					z6kMSs25KYyGVf55FxBT.PXY2S88S5Ph(oCf3AiCgJK);
					pQVON44sSHpPaN2Cx9jH(new Action(ia0pi4t4GK));
					num2 = 10;
					continue;
				case 2:
					mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446AC450));
					num = 15;
					break;
				case 6:
					NjbpMh2XWm();
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num2 = 14;
					}
					continue;
				case 12:
					if (base.Symbol == null)
					{
						vCNppNY9xh.MarketSettings.CopySettings(new MarketSettings(isCommon: true), saveTemplate: false, withLots: false);
					}
					qgcJBq4sx0xUX3b5YG26(this);
					num2 = 6;
					continue;
				case 8:
					if (num3.HasValue)
					{
						num2 = 5;
						continue;
					}
					goto IL_0157;
				case 1:
					Market.Ft4fS5ks29B(Q81pInvAn5);
					Market.tmVfSLOf92d(WlopccISKL);
					Market.HrVfSXp2Dv5(yPMpv0qKwg);
					Market.x2HfSg3c6iF(fRrpjTwXHG);
					num2 = 7;
					continue;
				case 9:
					ViewModel = new lFstfvuoXTH8701fWFf(this, vCNppNY9xh);
					ysBJuVHH3iwGVb253LJm.qKIHHzlmlOx().cPMHfc4R8gI(this);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					g152bmNFH7f();
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 12;
					}
					continue;
				case 21:
					vCNppNY9xh.WNsuupAvUm();
					num2 = 20;
					continue;
				case 4:
					PpS2SH4LJi3(vCNppNY9xh.vlP2kmioDGU);
					Market.THef5eP2ION(zBI2Sjoyuyr());
					Market.R5nfSDWPKg4(gbDpnqlDeV);
					Market.Command += NfbpGisjBZ;
					Market.EditViewOpenCommand = new RelayCommand(wHL3Figxkk);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					MarketTraderControl.InitializeComponent();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					dAgpOZse8c();
					eGIpqjwrs4();
					Pqj2NbP7hq2();
					DataManager.OnOrderInfo += base.CP72Nv9gyMh;
					EKVIQxfkdb0qc2T2DNLL.A5VfkA73wNe(wX4pfWpv0i);
					num2 = 2;
					continue;
				case 3:
					Market.UiPf5DpWuUL(iry2NPTGQJC());
					Market.U63f1VCdb1A();
					num2 = 16;
					continue;
				case 11:
					return;
				case 15:
					ia0pi4t4GK();
					iQq2brFhdFC(j18iDj9nukSCmEyZs5lH.rUD9vKWYEeL, 500);
					num2 = 3;
					continue;
				case 16:
					if (base.DocLinkContext.IsSwitchEnabled)
					{
						SetSwitchMarketStatus(j18iDj9nukSCmEyZs5lH.Settings.MarketShowMarketButton);
					}
					rs92SMnpCBe(_0020: true);
					num2 = 22;
					continue;
				case 13:
					MarketTraderControl.SetSettings(vCNppNY9xh);
					num = 18;
					break;
				case 19:
					c8EcTUfGEuMy2llFqsdF.ClqfGpsloas(NmK3zO7Llp);
					num2 = 11;
					continue;
				case 7:
					Market.egqfSE593UV(RCLpZay43t);
					TkYpeAHLV1((DataCycle)g5TECk4s5xH7pCO0Oc5g(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)));
					vx9pscng8q(vCNppNY9xh.MarketSettings.DataScale);
					MarketTraderControl.Command += NfbpGisjBZ;
					MarketTraderControl.ViewModel.Ii12HQB1yhq(zmup9UEkgw);
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					{
						MtiuGodGoW = false;
						c8EcTUfGEuMy2llFqsdF.WUqfYfsZiwD(FOO33TAsGu);
						c8EcTUfGEuMy2llFqsdF.kBnfY0c1Dj6(Bhx3pwDdBJ);
						c8EcTUfGEuMy2llFqsdF.yyLfGJ2NrvZ(NGa3ujyycB);
						num = 19;
						break;
					}
					IL_0157:
					P4VpCKEkim();
					((MhMDPU9v8rkigy1ao0Th)wjjUAY4s1LxDDgaTwL0n()).PropertyChanged += K3j3mRLELo;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	protected override void LinkPropertyChanged(int P_0, string P_1, object P_2)
	{
		if (P_0 != S67Uu24sLkELpGTL9I6t(this))
		{
			goto IL_0023;
		}
		int num2;
		if (P_0 <= 0)
		{
			int num = 2;
			num2 = num;
			goto IL_0009;
		}
		goto IL_005a;
		IL_005a:
		base.LinkPropertyChanged(P_0, P_1, P_2);
		int visibleDepthIndex = default(int);
		if (P_1 == (string)jqdeOo4eKgiRI3O5pbjF(0x50C1C840 ^ 0x50C1BBD4))
		{
			if (!(P_2 is int))
			{
				return;
			}
			visibleDepthIndex = (int)P_2;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
			{
				num2 = 1;
			}
		}
		else
		{
			num2 = 3;
		}
		goto IL_0009;
		IL_0023:
		if (!LinkActiveWindow)
		{
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_005a;
		IL_0009:
		switch (num2)
		{
		default:
			return;
		case 2:
			break;
		case 3:
			return;
		case 0:
			return;
		case 1:
			SetVisibleDepth(visibleDepthIndex, notifyLinkedWindows: false);
			return;
		}
		goto IL_0023;
	}

	private void wHL3Figxkk(object P_0)
	{
		bhXpTE4seeVrpPZe2XpS(this, D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
	}

	private void TradingControl_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (JR62S6js1Bp())
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!MtiuGodGoW)
				{
					MtiuGodGoW = true;
					zmNNvY4sXTwPaNfsMZp1(ty3xXb4sscuA5QTPPBiB(this), new Action(XJh3JwlxPf), DispatcherPriority.ContextIdle, Array.Empty<object>());
				}
				return;
			}
		}
	}

	protected override void Timer1Tick(bool P_0)
	{
		if (!JR62S6js1Bp() || !P_0)
		{
			return;
		}
		Oltuf3oL6B.wvD3UvmYYY();
		Market.NeedRedraw();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				rr93Pvgu7U();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Timer2Tick(object P_0, EventArgs P_1)
	{
		int num = 5;
		int num2 = num;
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = default(CoPfjK9hF3ASs5TbM8OK);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 8:
				return;
			case 9:
				if (U88pz84cOT)
				{
					U88pz84cOT = false;
					MExWIY4s6VdCCKCbPrMm(this, EGk2SmdrsFj(), kop2Sw1sSfc(), 2000);
				}
				MarketTraderControl.ViewModel.IsTradeAllowed = RvxSNT4sO50u0SaBsn0p(REIjnE4sMZdpohiKDa0O(ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position)) && DataManager.IsTradeAllowed(base.Symbol);
				if (GZL2N534PhQ(MarketTraderControl.ViewModel.Account) == null)
				{
					return;
				}
				NSB0IM4sqGQDXuG8E1fk(ViewModel, MarketTraderControl.ViewModel.IsTradeAllowed);
				num2 = 8;
				break;
			case 10:
				return;
			case 2:
				IGoEiJ4sEhMEhHOTPQcV(coPfjK9hF3ASs5TbM8OK, 0L);
				goto IL_01fd;
			case 7:
				pCDdlo4si0LuaIfiVQmE(MarketTraderControl.ViewModel, ypqMIv9maFM0tRwF0xMh);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				if (((z48ObB20gSriKUfj18p3)RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)).IsEnabled)
				{
					num2 = 7;
					break;
				}
				goto case 9;
			case 5:
				if (JR62S6js1Bp())
				{
					LbNpag6l2u();
					if (base.Symbol == null)
					{
						num2 = 10;
						break;
					}
					ypqMIv9maFM0tRwF0xMh = iry2NPTGQJC().fuulnktHjJ4(base.Symbol.ID);
					if (ypqMIv9maFM0tRwF0xMh == null)
					{
						return;
					}
					coPfjK9hF3ASs5TbM8OK = ((t4J54f97Q2MUX30RSwuQ)x0xNSs4scq1qt9UXfEfc(ypqMIv9maFM0tRwF0xMh)).Position;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 6:
				if (XgES7F4sji2NgFe7Jiym(coPfjK9hF3ASs5TbM8OK) != 0L)
				{
					goto IL_01fd;
				}
				coPfjK9hF3ASs5TbM8OK.RMg9wpA6CUj(0L);
				num2 = 2;
				break;
			default:
				ViewModel.StopLossIsChecked = JJWKGK4sgZUub5ehyw3Z(coPfjK9hF3ASs5TbM8OK) || A2i9Zp4sRjpNF4TXKGVj(coPfjK9hF3ASs5TbM8OK) != 0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				{
					MarketTraderControl.ViewModel.TakeProfitIsActive = coPfjK9hF3ASs5TbM8OK.MuD9wXlvwMr() || coPfjK9hF3ASs5TbM8OK.mfq9w3ApRCG() != 0;
					MarketTraderControl.ViewModel.StopLossIsActive = JJWKGK4sgZUub5ehyw3Z(coPfjK9hF3ASs5TbM8OK) || coPfjK9hF3ASs5TbM8OK.d919wPySHGR() != 0;
					Market.NeedRedraw();
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num2 = 2;
					}
					break;
				}
				IL_01fd:
				Rke9tT4sdo5eTUSbOtwq(ViewModel, coPfjK9hF3ASs5TbM8OK.MuD9wXlvwMr() || JOtsfi4sQXdIHx67gMXs(coPfjK9hF3ASs5TbM8OK) != 0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void ResetView(bool P_0 = false)
	{
		cT1Qdb4sIlABayVdFPV7(Market);
		kjc7Gl9PIEfKaxcEBwuk obj = iry2NPTGQJC().fuulnktHjJ4(base.Symbol?.ID)?.lEVl9w6fCd9();
		int num;
		if (obj == null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		long num2 = obj.LastPrice;
		goto IL_0111;
		IL_0009:
		long num3 = default(long);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 3:
				if (num3 == 0L)
				{
					return;
				}
				vCNppNY9xh.MarketSettings.CurrentPrice = num3;
				if (!Yf0u0W3stl)
				{
					num = 2;
					continue;
				}
				Yf0u0W3stl = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num = 0;
				}
				continue;
			default:
				vCNppNY9xh.MarketSettings.RecalculateBaseLot(Yusu2kWUP1);
				return;
			case 1:
				break;
			}
			break;
		}
		num2 = 0L;
		goto IL_0111;
		IL_0111:
		num3 = num2 * GetDataScale(base.Symbol?.ID);
		num = 3;
		goto IL_0009;
	}

	protected override void UpdateView()
	{
		Market.NeedRedraw(_0020: true);
	}

	protected override string GetSymbolID()
	{
		return vCNppNY9xh?.Qom210PQiuE;
	}

	protected override void OnConnectionLost()
	{
		vCNppNY9xh.MarketSettings.QuotesComing = false;
	}

	protected override void SetAccount()
	{
		Account account = (Account)LdNYOr4sWAsud7lKgxO5(vCNppNY9xh);
		SetAccount(account);
		LNw2bh7EuSM();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void OnRegisterSymbol(Symbol P_0)
	{
		int num = 23;
		MarketSettings marketSettings = default(MarketSettings);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					Yf0u0W3stl = true;
					num2 = 19;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 12;
					}
					continue;
				case 10:
					iRC7FN4srSSI3q5MsYph(vCNppNY9xh);
					bB8ute4sTI3u2QCY2h9e(vCNppNY9xh, false);
					num2 = 6;
					continue;
				case 23:
					TsyprKw6jF();
					num2 = 22;
					continue;
				case 15:
					if (EAThcm4sKZL0oZfOkvVN(vCNppNY9xh.MarketSettings))
					{
						num = 14;
						break;
					}
					goto IL_0084;
				case 4:
				{
					vCNppNY9xh.Qom210PQiuE = (string)dHgqrT4sUuwmGxsWgPCW(P_0);
					vCNppNY9xh.LotStep = lnxVbd4syr2ffqAe3L8F(P_0);
					lFstfvuoXTH8701fWFf lFstfvuoXTH8701fWFf = ViewModel;
					if (lFstfvuoXTH8701fWFf == null)
					{
						num2 = 18;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
						{
							num2 = 15;
						}
						continue;
					}
					lFstfvuoXTH8701fWFf.g2IuNeC9Ga();
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num2 = 7;
					}
					continue;
				}
				case 3:
					if (dimBaK4swAB7DLtoKYXT(vCNppNY9xh.MarketSettings.LotsExchangeId, marketSettings.LotsId))
					{
						num2 = 17;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 19;
				case 9:
					Hru2Na5NVdK();
					ia0pi4t4GK();
					LbNpag6l2u();
					num2 = 25;
					continue;
				case 14:
					if (!flag)
					{
						vCNppNY9xh.MarketSettings.SetPreset(base.Symbol);
					}
					goto IL_0084;
				case 11:
					SetAccount();
					Oltuf3oL6B.I6b3WPupQc(iry2NPTGQJC().fuulnktHjJ4(P_0.ID));
					num2 = 24;
					continue;
				case 24:
					P4VpCKEkim();
					FOO33TAsGu();
					return;
				case 22:
					base.Leverage = 1.0;
					base.CurrencyFreeMargin = -1.0;
					flag = ((EpdvD7f3hWq8UlJ32f6V)zif3dF4stOl7cKl3qILc(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).KTHf3z56Hl0.Values.ContainsKey((string)dHgqrT4sUuwmGxsWgPCW(P_0));
					((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).IsDefaultLots = true;
					bB8ute4sTI3u2QCY2h9e(vCNppNY9xh, false);
					num2 = 4;
					continue;
				case 8:
					HWK2NwN6miy(P_0, vCNppNY9xh.MarketSettings);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
					{
						num2 = 15;
					}
					continue;
				case 5:
					NKDDtX4sCdNTRSNtNcbp(vCNppNY9xh.MarketSettings, string.Empty);
					num2 = 10;
					continue;
				default:
					if (!seXOpL4sHJDFWDKNHirB(marketSettings.LotsId))
					{
						num = 3;
						break;
					}
					goto case 19;
				case 13:
					if (marketSettings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 2:
					vCNppNY9xh.MarketSettings.ChoiceOfCurrency = true;
					vCNppNY9xh.MarketSettings.ChoiceOfPercents = P_0.IsCryptoFuture;
					h34HRY4sVpOMsamuyh1o(vCNppNY9xh.MarketSettings, F3MFug4sZjCq42rUXJvk(P_0));
					vCNppNY9xh.MarketSettings.BaseCurrency = P_0.GetBaseCurrency();
					((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).QuotesComing = false;
					goto case 10;
				case 20:
					Det2buBqW3W();
					GMp2NDZiGuB();
					num2 = 9;
					continue;
				case 12:
					eGIpqjwrs4();
					num2 = 20;
					continue;
				case 6:
					bsVp2Hrnge(P_0.ID);
					num = 8;
					break;
				case 25:
					KYC2bzML06I();
					num2 = 11;
					continue;
				case 17:
					if (JBEUaS4s7sNyDVOQ7p26(marketSettings) || marketSettings.ExecuteInPercents)
					{
						((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).CopyLots(marketSettings);
						U88pz84cOT = true;
						goto case 19;
					}
					Yusu2kWUP1 = marketSettings;
					num2 = 21;
					continue;
				case 7:
				case 18:
					if (JLFqEJGJYiHaSdoROJXI.xmKGJaYrkMM(P_0))
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num2 = 1;
						}
						continue;
					}
					vCNppNY9xh.MarketSettings.ChoiceOfCurrency = false;
					vCNppNY9xh.MarketSettings.ChoiceOfPercents = false;
					vCNppNY9xh.MarketSettings.QuotesComing = false;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (!P_0.IsExcludedCommonLots)
					{
						marketSettings = (MarketSettings)c1R1Nc4sh1DRtdkRZNOt(qRycBF4smsivE3xDlAZN(P_0));
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 19;
				case 1:
					vCNppNY9xh.MarketSettings.QuoteCurrency = string.Empty;
					num2 = 5;
					continue;
				case 19:
					{
						MarketTraderControl.SetSymbol(P_0);
						Market.Aulf5StwUFV(P_0.ID);
						NjbpMh2XWm();
						dAgpOZse8c();
						num2 = 12;
						continue;
					}
					IL_0084:
					if (P_0.IsCrypto)
					{
						num = 16;
						break;
					}
					goto case 19;
				}
				break;
			}
		}
	}

	public void FOO33TAsGu()
	{
		if (base.Symbol == null)
		{
			return;
		}
		bool flag = false;
		_ = Market.axFf1ARQQOr().Levels;
		HashSet<string> hashSet = new HashSet<string>();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
		{
			num = 1;
		}
		E5ZRLJfvK5UFeYCuZIcl e5ZRLJfvK5UFeYCuZIcl = default(E5ZRLJfvK5UFeYCuZIcl);
		cHDH2xfPlID4okPS4Qpr cHDH2xfPlID4okPS4Qpr = default(cHDH2xfPlID4okPS4Qpr);
		int num2 = default(int);
		IEnumerator<E5ZRLJfvK5UFeYCuZIcl> enumerator = default(IEnumerator<E5ZRLJfvK5UFeYCuZIcl>);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 4:
				if (bBemsL4s3aPl18AK0woD(e5ZRLJfvK5UFeYCuZIcl) != cHDH2xfPlID4okPS4Qpr.OriginalPrice)
				{
					num3 = 5;
					goto IL_0005;
				}
				goto case 2;
			case 3:
				flag = true;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num = 2;
				}
				continue;
			case 7:
				hashSet.Add(e5ZRLJfvK5UFeYCuZIcl.fbgfvAgVpun());
				num3 = 9;
				goto IL_0005;
			case 9:
				if (e5ZRLJfvK5UFeYCuZIcl.TargetPrice != (double)cHDH2xfPlID4okPS4Qpr.Price)
				{
					cHDH2xfPlID4okPS4Qpr.RealPrice = (decimal)cHHDMB4sFhjXi7KZjPrg(e5ZRLJfvK5UFeYCuZIcl);
					num = 6;
					continue;
				}
				goto case 4;
			case 8:
				flag = true;
				goto case 2;
			case 6:
				flag = true;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num = 4;
				}
				continue;
			case 11:
				return;
			case 10:
				if (e5ZRLJfvK5UFeYCuZIcl == null)
				{
					Market.axFf1ARQQOr().Remove(cHDH2xfPlID4okPS4Qpr);
					num3 = 3;
					goto IL_0005;
				}
				num = 7;
				continue;
			case 5:
				cHDH2xfPlID4okPS4Qpr.OriginalPrice = bBemsL4s3aPl18AK0woD(e5ZRLJfvK5UFeYCuZIcl);
				num = 8;
				continue;
			case 2:
				num2--;
				goto IL_03be;
			case 1:
				{
					num2 = PHTVuU4s8Qvgke4A1kkv(Market.axFf1ARQQOr().Levels) - 1;
					goto IL_03be;
				}
				IL_0005:
				num = num3;
				continue;
				IL_03be:
				if (num2 < 0)
				{
					enumerator = c8EcTUfGEuMy2llFqsdF.c29fGRFIai9(base.Symbol).GetEnumerator();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num = 0;
					}
					continue;
				}
				cHDH2xfPlID4okPS4Qpr = Market.axFf1ARQQOr().Levels[num2] as cHDH2xfPlID4okPS4Qpr;
				if (!Qb6cBV4sPhtExQW7EiWs(NGeY8B4sAgBvsRIicJ2n(Market), cHDH2xfPlID4okPS4Qpr))
				{
					e5ZRLJfvK5UFeYCuZIcl = (E5ZRLJfvK5UFeYCuZIcl)vHu86L4sJd4ZW40fbmGn(cHDH2xfPlID4okPS4Qpr.XXnfPDsHymw());
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num = 10;
					}
					continue;
				}
				goto case 2;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					while (true)
					{
						IL_02b7:
						E5ZRLJfvK5UFeYCuZIcl current = enumerator.Current;
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							case 2:
								if (!hashSet.Contains(current.fbgfvAgVpun()))
								{
									cHDH2xfPlID4okPS4Qpr cHDH2xfPlID4okPS4Qpr2 = new cHDH2xfPlID4okPS4Qpr(current, base.Symbol.Step, base.Symbol.Precision, _0020: true);
									SWPNNn4spEU8iNSklij8(Market.axFf1ARQQOr(), cHDH2xfPlID4okPS4Qpr2);
									flag = true;
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
									{
										num4 = 1;
									}
									continue;
								}
								break;
							case 1:
								break;
							default:
								goto IL_02b7;
							}
							break;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator == null)
				{
					int num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num5 = 0;
					}
					switch (num5)
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
			if (!flag)
			{
				num = 11;
				continue;
			}
			Market.NeedRedraw();
			return;
		}
	}

	public void Bhx3pwDdBJ(string P_0, double P_1, double P_2)
	{
		Xk01qCnQRGKSpHLKWC9x CS_0024_003C_003E8__locals2 = new Xk01qCnQRGKSpHLKWC9x();
		CS_0024_003C_003E8__locals2.qGPnQMMjZgE = P_0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
		{
			num = 1;
		}
		cHDH2xfPlID4okPS4Qpr cHDH2xfPlID4okPS4Qpr = default(cHDH2xfPlID4okPS4Qpr);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				cHDH2xfPlID4okPS4Qpr = Market.axFf1ARQQOr().Levels.FirstOrDefault((BpmEftf7wYbuVebk5Vku l) => (string)Xk01qCnQRGKSpHLKWC9x.VG8oCnNlNkFVTioT06UG(l as cHDH2xfPlID4okPS4Qpr) == CS_0024_003C_003E8__locals2.qGPnQMMjZgE) as cHDH2xfPlID4okPS4Qpr;
				if (cHDH2xfPlID4okPS4Qpr == null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
					{
						num = 0;
					}
					break;
				}
				SprnKF4suHJGU95VMeli(cHDH2xfPlID4okPS4Qpr, P_1);
				cHDH2xfPlID4okPS4Qpr.RealPrice = (decimal)P_2;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				uW02ka4szpKRrnLktHuK(cHDH2xfPlID4okPS4Qpr, true);
				Market.NeedRedraw();
				return;
			case 0:
				return;
			}
		}
	}

	public void NGa3ujyycB(E5ZRLJfvK5UFeYCuZIcl P_0)
	{
		rIkMUenQOxqkqbwnF0ya CS_0024_003C_003E8__locals6 = new rIkMUenQOxqkqbwnF0ya();
		CS_0024_003C_003E8__locals6.h83nQWxqyTg = P_0;
		cHDH2xfPlID4okPS4Qpr cHDH2xfPlID4okPS4Qpr = default(cHDH2xfPlID4okPS4Qpr);
		int num;
		if (iUwqH24X0xx6M7uSwpMq(CS_0024_003C_003E8__locals6.h83nQWxqyTg) == base.Symbol)
		{
			cHDH2xfPlID4okPS4Qpr = ((G2gR30fAanPKf0TTFLoc)NGeY8B4sAgBvsRIicJ2n(Market)).Levels.FirstOrDefault((BpmEftf7wYbuVebk5Vku l) => rIkMUenQOxqkqbwnF0ya.zxTIk1NlLh88221d70KW(rIkMUenQOxqkqbwnF0ya.swKphpNlxrYS5kjiMHSD(l as cHDH2xfPlID4okPS4Qpr), CS_0024_003C_003E8__locals6.h83nQWxqyTg.aDbfvwGf6HI())) as cHDH2xfPlID4okPS4Qpr;
			if (cHDH2xfPlID4okPS4Qpr == null)
			{
				cHDH2xfPlID4okPS4Qpr = Market.axFf1ARQQOr().Levels.FirstOrDefault((BpmEftf7wYbuVebk5Vku l) => rIkMUenQOxqkqbwnF0ya.zxTIk1NlLh88221d70KW(rIkMUenQOxqkqbwnF0ya.swKphpNlxrYS5kjiMHSD(l as cHDH2xfPlID4okPS4Qpr), CS_0024_003C_003E8__locals6.h83nQWxqyTg.fbgfvAgVpun())) as cHDH2xfPlID4okPS4Qpr;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num = 1;
				}
			}
			else
			{
				num = 2;
			}
		}
		else
		{
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
			{
				num = 0;
			}
		}
		cHDH2xfPlID4okPS4Qpr cHDH2xfPlID4okPS4Qpr2 = default(cHDH2xfPlID4okPS4Qpr);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 3:
				if (cHDH2xfPlID4okPS4Qpr != null)
				{
					return;
				}
				cHDH2xfPlID4okPS4Qpr2 = new cHDH2xfPlID4okPS4Qpr(CS_0024_003C_003E8__locals6.h83nQWxqyTg, gKwrDf4XHarOHGiaqCt9(base.Symbol), base.Symbol.Precision, _0020: true);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				cHDH2xfPlID4okPS4Qpr.KUIfPbpN218((string)B84akm4X21k3rnR0amO3(CS_0024_003C_003E8__locals6.h83nQWxqyTg));
				cHDH2xfPlID4okPS4Qpr.IsSynchronized = true;
				Market.NeedRedraw();
				return;
			default:
				SWPNNn4spEU8iNSklij8(Market.axFf1ARQQOr(), cHDH2xfPlID4okPS4Qpr2);
				Market.NeedRedraw();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void NmK3zO7Llp(string P_0)
	{
		AvPVdFnQtfD0E8fI1m2e CS_0024_003C_003E8__locals2 = new AvPVdFnQtfD0E8fI1m2e();
		CS_0024_003C_003E8__locals2.rB1nQTtjIdF = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
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
			BpmEftf7wYbuVebk5Vku bpmEftf7wYbuVebk5Vku = ((G2gR30fAanPKf0TTFLoc)NGeY8B4sAgBvsRIicJ2n(Market)).Levels.FirstOrDefault((BpmEftf7wYbuVebk5Vku l) => (string)AvPVdFnQtfD0E8fI1m2e.VSLDiGNljwEEP1RBWLZ1(l as cHDH2xfPlID4okPS4Qpr) == CS_0024_003C_003E8__locals2.rB1nQTtjIdF);
			if (bpmEftf7wYbuVebk5Vku == null)
			{
				return;
			}
			Market.axFf1ARQQOr().Remove(bpmEftf7wYbuVebk5Vku);
			Market.NeedRedraw();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
			{
				num = 1;
			}
		}
	}

	private void Qafp0D1uu4(MarketSettings P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vCNppNY9xh.MarketSettings.CurrentPrice == 0L)
				{
					Yusu2kWUP1 = P_0;
					Yf0u0W3stl = true;
					return;
				}
				Yf0u0W3stl = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				vCNppNY9xh.MarketSettings.CurrentPrice = Xjr2NuoB2iw();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				J7HwG54XfoUP6H6Xepwi(vCNppNY9xh.MarketSettings, P_0);
				return;
			}
		}
	}

	private void bsVp2Hrnge(string P_0)
	{
		MarketSettings marketSettings = (MarketSettings)YyMvfa4ez3dugQ59kYaT(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416957051), P_0);
		MarketSettings marketSettings2 = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB();
		MarketSettings marketSettings3 = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x70653231));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
		{
			num = 0;
		}
		MarketSettings marketSettings4 = default(MarketSettings);
		bool flag = default(bool);
		MarketSettings marketSettings5 = default(MarketSettings);
		List<BpmEftf7wYbuVebk5Vku> list = default(List<BpmEftf7wYbuVebk5Vku>);
		while (true)
		{
			int num2;
			Symbol obj;
			switch (num)
			{
			case 18:
				if (!kwTiR44X9ZypKRdJxZmy(marketSettings4))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 23;
			case 4:
			case 7:
				if (!flag)
				{
					num = 14;
					continue;
				}
				goto case 12;
			case 23:
			case 24:
				if (!string.IsNullOrEmpty(marketSettings5.CommonTemplateID))
				{
					num = 22;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num = 21;
					}
					continue;
				}
				goto case 5;
			case 12:
				vCNppNY9xh.MarketSettings.EditQuoteCurrency = false;
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num = 21;
				}
				continue;
			case 22:
				if (dimBaK4swAB7DLtoKYXT(eoLMDN4XGIRLHbVD2nL2(marketSettings5), jq3ePa4XommNAkX5BQsb(marketSettings)))
				{
					if (!marketSettings5.SetNewSymbol)
					{
						num2 = 16;
						goto IL_0005;
					}
					goto case 5;
				}
				num = 5;
				continue;
			case 5:
				vCNppNY9xh.MarketSettings.CopySettings(marketSettings, saveTemplate: false, withLots: true, applyTemplate: false, withLevels: false);
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num = 0;
				}
				continue;
			case 14:
				HWeHv84XBfsVEFbFefRk(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), marketSettings2);
				num = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num = 12;
				}
				continue;
			case 11:
				flag = true;
				goto IL_00bb;
			case 20:
				((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).LotsExchangeId = marketSettings.LotsExchangeId;
				return;
			case 21:
				((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.ExitStrategy = null;
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num = 1;
				}
				continue;
			case 9:
				if (!seXOpL4sHJDFWDKNHirB(marketSettings4.CommonTemplateID))
				{
					if (!((string)eoLMDN4XGIRLHbVD2nL2(marketSettings4) != (string)pE9Zau4XYcmhgZXyuRRP(marketSettings)))
					{
						num = 23;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
						{
							num = 3;
						}
						continue;
					}
					goto case 18;
				}
				goto case 23;
			default:
				marketSettings4 = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB(SymbolManager.GetNameDomTemplate(base.Symbol));
				marketSettings5 = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB(SymbolManager.GetNameDomTemplate(base.Symbol, isIndividual: true));
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 0;
				}
				continue;
			case 17:
				if (!marketSettings2.SetNewSymbol)
				{
					marketSettings.CopyCommonSettings(marketSettings2);
				}
				goto IL_019b;
			case 8:
				list.AddRange(((YiXl9IfP06OkWU6fDkUP)lgmcOX4s0jGvkPpntGjk(marketSettings)).IDQfPHZll5G(P_0));
				((YiXl9IfP06OkWU6fDkUP)lgmcOX4s0jGvkPpntGjk(vCNppNY9xh.MarketSettings)).Ia0fPf3Ad95(P_0, list);
				((YiXl9IfP06OkWU6fDkUP)shqjfv4Xvm60UeX1sr72(vCNppNY9xh.MarketSettings)).Ia0fPf3Ad95(P_0, marketSettings.Levels.IDQfPHZll5G(P_0));
				num = 20;
				continue;
			case 3:
				if (!(marketSettings2.CommonTemplateID != marketSettings.CommonTemplateID))
				{
					goto IL_019b;
				}
				goto case 17;
			case 13:
				vCNppNY9xh.MarketSettings.LotsExchangeId = null;
				return;
			case 19:
				HWeHv84XBfsVEFbFefRk(vCNppNY9xh.MarketSettings, marketSettings4);
				num = 11;
				continue;
			case 2:
				HWeHv84XBfsVEFbFefRk(vCNppNY9xh.MarketSettings, marketSettings2);
				flag = true;
				goto IL_0582;
			case 16:
				marketSettings.CopyIndividualSettings(marketSettings5);
				goto case 5;
			case 1:
				marketSettings.CopyCommonSettings(marketSettings4);
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num = 24;
				}
				continue;
			case 15:
				vCNppNY9xh.MarketSettings.IsDefaultLots = false;
				if (!j18iDj9nukSCmEyZs5lH.Settings.SyncLevels)
				{
					return;
				}
				obj = base.Symbol ?? SymbolManager.Get(P_0);
				break;
			case 10:
				flag = true;
				goto IL_0185;
			case 6:
				{
					flag = false;
					if (marketSettings != null)
					{
						if (!string.IsNullOrEmpty(marketSettings2.CommonTemplateID))
						{
							num = 3;
							continue;
						}
						goto IL_019b;
					}
					if (!seXOpL4sHJDFWDKNHirB(marketSettings2.CommonTemplateID))
					{
						num = 2;
						continue;
					}
					goto IL_0582;
				}
				IL_0582:
				if (!seXOpL4sHJDFWDKNHirB(eoLMDN4XGIRLHbVD2nL2(marketSettings3)))
				{
					ocASog4XndqjQRedYtrL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), marketSettings3);
					num = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
					{
						num = 7;
					}
					continue;
				}
				goto IL_0185;
				IL_0185:
				if (seXOpL4sHJDFWDKNHirB(marketSettings4.CommonTemplateID))
				{
					goto IL_00bb;
				}
				goto case 19;
				IL_019b:
				if (string.IsNullOrEmpty(marketSettings3.CommonTemplateID) || !dimBaK4swAB7DLtoKYXT(marketSettings3.CommonTemplateID, marketSettings.IndividualTemplateID) || kwTiR44X9ZypKRdJxZmy(marketSettings3))
				{
					goto case 9;
				}
				ocASog4XndqjQRedYtrL(marketSettings, marketSettings3);
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 3;
				}
				continue;
				IL_00bb:
				if (string.IsNullOrEmpty(marketSettings5.CommonTemplateID))
				{
					num2 = 7;
					goto IL_0005;
				}
				vCNppNY9xh.MarketSettings.CopyIndividualSettings(marketSettings5);
				flag = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 4;
				}
				continue;
				IL_0005:
				num = num2;
				continue;
			}
			Symbol symbol = obj;
			list = aNW37vPPeA(symbol, marketSettings.UniversalSignalLevels);
			num = 8;
		}
	}

	private string aW1pHpqHfh(string P_0)
	{
		return ((MarketSettings)YyMvfa4ez3dugQ59kYaT(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087109960), P_0))?.Account;
	}

	protected override void OnMarketSettingsUpdated(string P_0, string P_1, MarketSettings P_2)
	{
		if (P_0 == zBI2Sjoyuyr() || base.Symbol == null)
		{
			return;
		}
		int num = 3;
		List<BpmEftf7wYbuVebk5Vku> list = default(List<BpmEftf7wYbuVebk5Vku>);
		List<BpmEftf7wYbuVebk5Vku> collection = default(List<BpmEftf7wYbuVebk5Vku>);
		while (true)
		{
			switch (num)
			{
			case 3:
				if ((string)dHgqrT4sUuwmGxsWgPCW(base.Symbol) != P_1)
				{
					return;
				}
				TsyprKw6jF();
				if (j18iDj9nukSCmEyZs5lH.Settings.SyncLevels)
				{
					bool num2 = uWX4TW4XaiLSRNxcMhxJ(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x3544E1EF));
					list = aNW37vPPeA(base.Symbol, P_2.UniversalSignalLevels);
					if (!num2)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
						{
							num = 1;
						}
						break;
					}
					collection = (from lvl in P_2.SignalLevels.IDQfPHZll5G(P_1)
						where Sa0aRFnQkBHHrB19y9wT.auB0CGNlnvVRrsgogtGn((tQdY3yfPR6B0dxodinwZ)lvl)
						select lvl).ToList();
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
					{
						num = 7;
					}
					break;
				}
				goto IL_01a1;
			case 4:
				return;
			default:
				((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).PresetAdjViaScrollMode = oZWqub4XlSMGeN6qnJZL(P_2);
				RgUn4j4XDxZq74IS9kWS(MarketTraderControl, hkeGDI4X4SQfJn5pXLhI(vCNppNY9xh.MarketSettings.TradeSettings));
				P4VpCKEkim();
				U88pz84cOT = false;
				num = 4;
				break;
			case 7:
			{
				xhmlkb4Xi6h2VwAoJiIC(shqjfv4Xvm60UeX1sr72(vCNppNY9xh.MarketSettings), P_2.Levels);
				NjbpMh2XWm();
				int num3 = 2;
				num = num3;
				break;
			}
			case 2:
			case 5:
				list.AddRange(collection);
				vCNppNY9xh.MarketSettings.SignalLevels.Ia0fPf3Ad95(P_1, list);
				dAgpOZse8c();
				goto IL_01a1;
			case 1:
			case 6:
				{
					collection = (from lvl in ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).SignalLevels.IDQfPHZll5G(P_1)
						where ((tQdY3yfPR6B0dxodinwZ)lvl).YNJfPtJgce2
						select lvl).ToList();
					num = 5;
					break;
				}
				IL_01a1:
				vCNppNY9xh.MarketSettings.CopyPresets(P_2, saveTemplate: false);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void OnCommonLotsUpdated(string P_0, MarketSettings P_1)
	{
		if (base.Symbol == null)
		{
			return;
		}
		int num2;
		if (!base.Symbol.IsCrypto)
		{
			int num = 4;
			num2 = num;
		}
		else
		{
			if (P_0 != SymbolManager.GetNameLotsTemplate(base.Symbol) || base.Symbol.IsExcludedCommonLots)
			{
				return;
			}
			TsyprKw6jF();
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num2 = 1;
			}
		}
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				ibYlXK4XbiPFqrY1GY2e(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), P_1);
				break;
			case 5:
				if (P_1.ExecuteInPercents)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				Qafp0D1uu4(P_1);
				break;
			case 4:
				return;
			case 2:
				return;
			case 1:
				if (!JBEUaS4s7sNyDVOQ7p26(P_1))
				{
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			}
			P4VpCKEkim();
			U88pz84cOT = true;
			num2 = 2;
		}
	}

	private void wX4pfWpv0i(string P_0)
	{
		string text = P_0.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838845964), string.Empty);
		int num;
		if (text != stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x42279AE))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00de;
		IL_0009:
		MarketSettings marketSettings = default(MarketSettings);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (marketSettings.IsIndividual && !marketSettings.SetNewSymbol)
				{
					vCNppNY9xh.MarketSettings.CopyIndividualSettings(marketSettings);
				}
				else if (!marketSettings.SetNewSymbol)
				{
					HWeHv84XBfsVEFbFefRk(vCNppNY9xh.MarketSettings, marketSettings);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			case 1:
				return;
			case 2:
				return;
			}
			if (!(text != (string)L2uPeB4XNNGkfs0kH0Gy(base.Symbol, false)))
			{
				break;
			}
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
			{
				num = 2;
			}
		}
		goto IL_00de;
		IL_00de:
		marketSettings = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB(P_0);
		num = 3;
		goto IL_0009;
	}

	protected override void OnRegisterAccount(Account P_0)
	{
		vCNppNY9xh.Ddk2kVPVJWO(P_0?.AccountID);
		uHI6C94XkQFl7xMdqyjk(MarketTraderControl.ViewModel, P_0?.AccountID);
		Det2buBqW3W();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ia0pi4t4GK();
				num = 2;
				continue;
			case 2:
				KYC2bzML06I();
				return;
			}
			GMp2NDZiGuB();
			Hru2Na5NVdK();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
			{
				num = 0;
			}
		}
	}

	protected override void OnUnRegisterAccount(Account P_0)
	{
		((z48ObB20gSriKUfj18p3)RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)).Account = "";
	}

	private void zmup9UEkgw(string P_0)
	{
		SetAccount(DataManager.GetAccount(P_0));
	}

	private void gbDpnqlDeV(FX2hNmfFGUQfi0wdaZLW P_0)
	{
		int num;
		switch (IGyIAY4X1ZbOagt6x9C6(P_0))
		{
		default:
			Market.ContextMenu = null;
			num = 2;
			goto IL_0009;
		case FX2hNmfFGUQfi0wdaZLW.Positions.Cluster:
			Market.ContextMenu = (ContextMenu)DrsySQ4X5HnLOGvBHCSO(base.Resources, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82849138));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case FX2hNmfFGUQfi0wdaZLW.Positions.Settings:
		{
			Y43KBu2nt2tdxWysSevH y43KBu2nt2tdxWysSevH = new Y43KBu2nt2tdxWysSevH();
			uDQ5qf4XLWpOdwpX3UET(y43KBu2nt2tdxWysSevH, base.ParentWindow);
			y43KBu2nt2tdxWysSevH.TradeSettingsControl.MarketSettings = vCNppNY9xh.MarketSettings;
			TlKR6Q4XeDpS0CtKpAmP(y43KBu2nt2tdxWysSevH.TradeSettingsControl);
			Y43KBu2nt2tdxWysSevH.Lux2nT3jHei((NCopbS2n6A8BFZsh7eNY)1);
			y43KBu2nt2tdxWysSevH.ShowDialog();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		case FX2hNmfFGUQfi0wdaZLW.Positions.LotWidget:
			SsWJhR4XxZrRv8GNIowj(Market, (ContextMenu)base.Resources[jqdeOo4eKgiRI3O5pbjF(-1606927328 ^ -1606924110)]);
			num = 3;
			goto IL_0009;
		case FX2hNmfFGUQfi0wdaZLW.Positions.Panel:
			Market.ContextMenu = (ContextMenu)DrsySQ4X5HnLOGvBHCSO(base.Resources, jqdeOo4eKgiRI3O5pbjF(--871424829 ^ 0x33F09727));
			break;
		case FX2hNmfFGUQfi0wdaZLW.Positions.Graph:
			{
				SsWJhR4XxZrRv8GNIowj(Market, (ContextMenu)((ResourceDictionary)r4Ewxq4XSDkUQOr7g496(this))[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017350908)]);
				break;
			}
			IL_0009:
			switch (num)
			{
			case 2:
				break;
			case 1:
				U88pz84cOT = true;
				Market.Focus();
				break;
			case 3:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	private void NfbpGisjBZ(j3bgDY9gV2i9bttJ1fiQ P_0)
	{
		int? num = null;
		LogInfo((string)MVOnRc4XsbZHIA7lNf1c(jqdeOo4eKgiRI3O5pbjF(-837284864 ^ -837257026), P_0?.ToString()));
		int num2 = 16;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
		{
			num2 = 24;
		}
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				BuyMarket(P_0.Quantity, P_0.Kvl9RQgO1sv());
				return;
			case 18:
				return;
			case 0:
				return;
			case 25:
				return;
			case 30:
				DPW2NQvQtB6(VYaVHl4XcOlF9kPglWUh(P_0), dmxKwc4XQCniHdEyICHg(P_0), num, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).OrderValidity, (Hashtable)wO6tnV4XRLdPjBfRfEva(P_0));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num2 = 16;
				}
				break;
			case 4:
				return;
			case 8:
				uun2NgMNce1(VYaVHl4XcOlF9kPglWUh(P_0), P_0.Price, num);
				return;
			case 15:
				return;
			case 31:
				return;
			case 27:
				WLc2NKwa6JS((int)P_0.Quantity);
				return;
			case 26:
				i8s2NWZMPYr(dmxKwc4XQCniHdEyICHg(P_0));
				rVO2NU70NU3(P_0.Price);
				num2 = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
				{
					num2 = 0;
				}
				break;
			case 29:
				return;
			case 23:
				return;
			case 10:
				SellMarket(P_0.Quantity);
				return;
			case 12:
				SellMarket(VYaVHl4XcOlF9kPglWUh(P_0), P_0.Kvl9RQgO1sv());
				num2 = 23;
				break;
			case 21:
				return;
			case 16:
				return;
			case 14:
				BuyLimit(P_0.Quantity, base.Symbol.GetShortPrice(P_0.Iy19RLkeCeC()), 0, HPZdn64XdkGp0DaBQp0M(vCNppNY9xh.MarketSettings.TradeSettings), P_0.Kvl9RQgO1sv());
				num2 = 22;
				break;
			case 24:
				if (base.Symbol == null)
				{
					return;
				}
				ypqMIv9maFM0tRwF0xMh = iry2NPTGQJC().fuulnktHjJ4(base.Symbol.ID);
				num2 = 17;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
				{
					num2 = 13;
				}
				break;
			case 28:
				return;
			case 17:
			{
				int num3;
				switch (BelOMC4XXZVhjHOxfogk(P_0))
				{
				case (nDujbt9RUocG2LJtIN4X)39:
					CSb2NOhpFq1(_0020: false);
					return;
				case (nDujbt9RUocG2LJtIN4X)37:
					if (MarketTraderControl.ViewModel.CanTransferFunds)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
						{
							num2 = 3;
						}
						goto end_IL_0009;
					}
					return;
				case nDujbt9RUocG2LJtIN4X.TakeProfit:
					TakeProfit();
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num2 = 4;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)36:
					fRrpjTwXHG((int)dmxKwc4XQCniHdEyICHg(P_0));
					return;
				case nDujbt9RUocG2LJtIN4X.SellLimit:
					num = base.Symbol.GetOffset(vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderOffset, vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderPercentOffset, P_0.Price, vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					num2 = 19;
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)34:
					RurplLiLyI();
					num2 = 28;
					goto end_IL_0009;
				case nDujbt9RUocG2LJtIN4X.StopLoss:
					StopLoss();
					return;
				case (nDujbt9RUocG2LJtIN4X)5:
					if (ypqMIv9maFM0tRwF0xMh == null)
					{
						return;
					}
					num = base.Symbol.GetOffset(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.TriggerOrderOffset, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).TriggerOrderPercentOffset, P_0.Price / joJdkB4XMrXtr4Kkh0AK(ypqMIv9maFM0tRwF0xMh), ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
					{
						num2 = 7;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)11:
					if (ypqMIv9maFM0tRwF0xMh != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
						{
							num2 = 4;
						}
						goto end_IL_0009;
					}
					return;
				case nDujbt9RUocG2LJtIN4X.ClosePosition:
					ClosePosition();
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num2 = 13;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)9:
					if (P_0.hd19RcfNKbe())
					{
						Jec2NR1P86B(P_0.Quantity, base.Symbol.GetShortPrice(P_0.Iy19RLkeCeC()), null, vCNppNY9xh.MarketSettings.TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
						return;
					}
					if (ypqMIv9maFM0tRwF0xMh == null)
					{
						return;
					}
					num = base.Symbol.GetOffset(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.StopOrderOffset, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.StopOrderPercentOffset, P_0.Price / ypqMIv9maFM0tRwF0xMh.UJElnHayjot, vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					Jec2NR1P86B(P_0.Quantity, P_0.Price, num, HPZdn64XdkGp0DaBQp0M(aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))), P_0.Kvl9RQgO1sv());
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 11;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)8:
					if (!P_0.hd19RcfNKbe())
					{
						SellLimit(VYaVHl4XcOlF9kPglWUh(P_0), dmxKwc4XQCniHdEyICHg(P_0), 0, vCNppNY9xh.MarketSettings.TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
					}
					else
					{
						SellLimit(VYaVHl4XcOlF9kPglWUh(P_0), base.Symbol.GetShortPrice(P_0.Iy19RLkeCeC()), 0, vCNppNY9xh.MarketSettings.TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
					}
					return;
				default:
					return;
				case nDujbt9RUocG2LJtIN4X.BuyMarket:
					if (P_0.hd19RcfNKbe())
					{
						num3 = 6;
						goto IL_0005;
					}
					BuyMarket(VYaVHl4XcOlF9kPglWUh(P_0));
					return;
				case (nDujbt9RUocG2LJtIN4X)13:
				case (nDujbt9RUocG2LJtIN4X)18:
				case (nDujbt9RUocG2LJtIN4X)19:
				case (nDujbt9RUocG2LJtIN4X)20:
				case (nDujbt9RUocG2LJtIN4X)21:
				case (nDujbt9RUocG2LJtIN4X)22:
				case (nDujbt9RUocG2LJtIN4X)23:
				case (nDujbt9RUocG2LJtIN4X)24:
				case (nDujbt9RUocG2LJtIN4X)25:
				case (nDujbt9RUocG2LJtIN4X)26:
				case (nDujbt9RUocG2LJtIN4X)29:
				case (nDujbt9RUocG2LJtIN4X)30:
					return;
				case (nDujbt9RUocG2LJtIN4X)3:
					if (P_0.hd19RcfNKbe())
					{
						DPW2NQvQtB6(P_0.Quantity, base.Symbol.GetShortPrice(P_0.Iy19RLkeCeC()), null, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).OrderValidity, P_0.Kvl9RQgO1sv());
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
						{
							num2 = 2;
						}
					}
					else if (ypqMIv9maFM0tRwF0xMh != null)
					{
						num = base.Symbol.GetOffset(vCNppNY9xh.MarketSettings.TradeSettings.StopOrderOffset, vCNppNY9xh.MarketSettings.TradeSettings.StopOrderPercentOffset, P_0.Price / ypqMIv9maFM0tRwF0xMh.UJElnHayjot, BLiFEZ4XEkbwpFd6IDK7(aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
						num2 = 30;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 21;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)31:
					if (P_0.Quantity == 0.0)
					{
						return;
					}
					h7D2NZHPbRH((int)VYaVHl4XcOlF9kPglWUh(P_0));
					dCV2NCrBMX5((int)VYaVHl4XcOlF9kPglWUh(P_0));
					num2 = 27;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 5;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)4:
					if (P_0.hd19RcfNKbe())
					{
						xdi2Nd9phCK(P_0.Quantity, base.Symbol.GetShortPrice(P_0.Iy19RLkeCeC()), base.Symbol.GetShortPrice(iY0O974X6ffOF4dSnhuD(P_0)), vCNppNY9xh.MarketSettings.TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
					}
					return;
				case nDujbt9RUocG2LJtIN4X.CancelAll:
					CancelAllOrders();
					return;
				case (nDujbt9RUocG2LJtIN4X)2:
					if (CyAECZ4XgIM2VwBUqiuj(P_0))
					{
						num2 = 14;
						goto end_IL_0009;
					}
					BuyLimit(P_0.Quantity, dmxKwc4XQCniHdEyICHg(P_0), 0, vCNppNY9xh.MarketSettings.TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
					return;
				case (nDujbt9RUocG2LJtIN4X)28:
					kQJ2NyjMACh(dmxKwc4XQCniHdEyICHg(P_0), oPWon34XIgSna5AkwbJo(P_0));
					SIZ2NViJWbs(P_0.Price, P_0.Q6K9R5T1PJn());
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num2 = 2;
					}
					goto end_IL_0009;
				case nDujbt9RUocG2LJtIN4X.SetLeverage:
					SetLeverage(X6oFvC4XOtJ7SEtfnw76(P_0));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)10:
					if (CyAECZ4XgIM2VwBUqiuj(P_0))
					{
						ell2N6w5bLt(P_0.Quantity, LBsj7x4Xq6WyYsQlwdKK(base.Symbol, X6oFvC4XOtJ7SEtfnw76(P_0)), base.Symbol.GetShortPrice(P_0.yTq9RsvEb5L()), HPZdn64XdkGp0DaBQp0M(aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)), P_0.Kvl9RQgO1sv());
						num3 = 31;
						goto IL_0005;
					}
					return;
				case nDujbt9RUocG2LJtIN4X.CancelAsks:
					CancelAskOrders();
					return;
				case nDujbt9RUocG2LJtIN4X.SellMarket:
					break;
				case nDujbt9RUocG2LJtIN4X.ReversePosition:
					ReversePosition();
					return;
				case nDujbt9RUocG2LJtIN4X.BuyLimit:
					num = base.Symbol.GetOffset(vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderOffset, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).LimitOrderPercentOffset, P_0.Price, BLiFEZ4XEkbwpFd6IDK7(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					BuyLimit(P_0.Quantity, dmxKwc4XQCniHdEyICHg(P_0), num, HPZdn64XdkGp0DaBQp0M(vCNppNY9xh.MarketSettings.TradeSettings), P_0.Kvl9RQgO1sv());
					return;
				case (nDujbt9RUocG2LJtIN4X)38:
					CSb2NOhpFq1(_0020: true);
					num2 = 18;
					goto end_IL_0009;
				case nDujbt9RUocG2LJtIN4X.CancelBids:
					CancelBidOrders();
					num2 = 20;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num2 = 14;
					}
					goto end_IL_0009;
				case (nDujbt9RUocG2LJtIN4X)27:
					{
						mMC2NqEoxW2(P_0.Price);
						num2 = 26;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
						{
							num2 = 24;
						}
						goto end_IL_0009;
					}
					IL_0005:
					num2 = num3;
					goto end_IL_0009;
				}
				if (!P_0.hd19RcfNKbe())
				{
					num2 = 10;
					break;
				}
				goto case 12;
			}
			case 22:
				return;
			case 7:
				return;
			case 1:
				SYe2NM1kDo3(VYaVHl4XcOlF9kPglWUh(P_0), P_0.Price, num);
				return;
			case 19:
				SellLimit(P_0.Quantity, P_0.Price, num, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.OrderValidity, P_0.Kvl9RQgO1sv());
				return;
			case 11:
				return;
			case 20:
				return;
			case 9:
				return;
			case 5:
				num = base.Symbol.GetOffset(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.TriggerOrderOffset, vCNppNY9xh.MarketSettings.TradeSettings.TriggerOrderPercentOffset, dmxKwc4XQCniHdEyICHg(P_0) / ypqMIv9maFM0tRwF0xMh.UJElnHayjot, BLiFEZ4XEkbwpFd6IDK7(vCNppNY9xh.MarketSettings.TradeSettings) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				return;
			case 2:
				lFP2NrEIxIv(dmxKwc4XQCniHdEyICHg(P_0), oPWon34XIgSna5AkwbJo(P_0));
				return;
			case 3:
				{
					yBkHHnoFRLCqi3Cf0Cg9 yBkHHnoFRLCqi3Cf0Cg = new yBkHHnoFRLCqi3Cf0Cg9(((mUs87h9xN7JK6PZpsQ4J)P_0.Price/*cast due to .constrained prefix*/).ToString(), ((mUs87h9xN7JK6PZpsQ4J)oPWon34XIgSna5AkwbJo(P_0)/*cast due to .constrained prefix*/).ToString(), leUCoL4XWttBiK13wy7w(P_0.Quantity));
					yBkHHnoFRLCqi3Cf0Cg.Options = wkD2NhkYcfc();
					TransferFunds(yBkHHnoFRLCqi3Cf0Cg);
					num2 = 29;
					break;
				}
				end_IL_0009:
				break;
			}
		}
	}

	private void SetVisibleDepth(int visibleDepthIndex, bool notifyLinkedWindows = true)
	{
		if (visibleDepthIndex < 0 || visibleDepthIndex > vCNppNY9xh.MarketSettings.VisualSettings.VisibleDepths.Length - 1)
		{
			return;
		}
		((SH4fZjfBgpnJAYxtUbu4)XYq3Vb4XtogMeAcK2Sul(vCNppNY9xh.MarketSettings)).LastVisibleDepthIndex = visibleDepthIndex;
		double num = ((SH4fZjfBgpnJAYxtUbu4)XYq3Vb4XtogMeAcK2Sul(vCNppNY9xh.MarketSettings)).VisibleDepths[visibleDepthIndex].Value / 50.0;
		Market.wyOfSKBQnal(out var num2, out var num3, out var num4);
		int num5 = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
		{
			num5 = 2;
		}
		double num6 = default(double);
		while (true)
		{
			switch (num5)
			{
			case 1:
				return;
			case 3:
				OqHyre2x4ermamEtk9EZ.PropertyChanged(LinkGroup, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82848420), visibleDepthIndex);
				return;
			default:
				ViewModel.DataScale = BeXYlb4XUfivCH2kuAJA(1, (int)(num6 + 0.5));
				HL6pXLd6eL();
				if (!notifyLinkedWindows)
				{
					num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
					{
						num5 = 1;
					}
					break;
				}
				goto case 3;
			case 2:
				num6 = (double)num4 * num / (double)(num3 - num2);
				num5 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
				{
					num5 = 0;
				}
				break;
			}
		}
	}

	private void OcPpYlgJXf()
	{
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Q8e8To4XTKIngleit01D(vCNppNY9xh.MarketSettings.VisualSettings) >= vCNppNY9xh.MarketSettings.VisualSettings.VisibleDepths.Length - 1)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).VisualSettings.LastVisibleDepthIndex + 1;
				break;
			default:
				num3 = 0;
				break;
			}
			break;
		}
		int visibleDepthIndex = num3;
		SetVisibleDepth(visibleDepthIndex);
	}

	private void DfjpoT4Nl1()
	{
		int visibleDepthIndex = ((vCNppNY9xh.MarketSettings.VisualSettings.LastVisibleDepthIndex > 0) ? (vCNppNY9xh.MarketSettings.VisualSettings.LastVisibleDepthIndex - 1) : (((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).VisualSettings.VisibleDepths.Length - 1));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		SetVisibleDepth(visibleDepthIndex);
	}

	private void yPMpv0qKwg(int P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				DfjpoT4Nl1();
				return;
			case 1:
				if (P_0 <= 0)
				{
					if (P_0 >= 0)
					{
						return;
					}
					goto case 2;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				break;
			default:
				OcPpYlgJXf();
				return;
			}
		}
	}

	protected override void OnPreviewKeyDown(KeyEventArgs P_0)
	{
		int num = 30;
		DataCycle dataCycle = default(DataCycle);
		ChartPnlType chartPnlType = default(ChartPnlType);
		DataCycle dataCycle2 = default(DataCycle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.PnlType = ChartPnlType.Points;
					goto IL_069a;
				case 29:
					if (!(P_0.OriginalSource is TextBox))
					{
						num2 = 42;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
						{
							num2 = 27;
						}
						continue;
					}
					return;
				case 5:
					vCNppNY9xh.MarketSettings.DataCycle = dataCycle;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num2 = 33;
					}
					continue;
				case 30:
					bepGnF4XyubHfwAU8uXB(this, P_0);
					num = 29;
					break;
				case 11:
					if (chartPnlType == ChartPnlType.Hidden)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 41:
					if (UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.cIg9SxcqqxK))
					{
						num2 = 15;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
						{
							num2 = 23;
						}
						continue;
					}
					if (NVYwSH4Xh9J5oPI3nAC6(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.W6T9S4kJl6L) || NVYwSH4Xh9J5oPI3nAC6(vspL39fH6Hd69qemUHrA.Market.SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.lQK9SLPq1Fg))
					{
						SetVisibleDepth(8);
						u9RjOr4XwIn8vYgElwrM(P_0, true);
						return;
					}
					if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().HideAllToolBars.Check(P_0))
					{
						if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().HideDomToolBars.Check(P_0))
						{
							num2 = 35;
							continue;
						}
						if (HCNE034XAGTK0Io5v4G2(((KedBU3f05IsrqcZmlPn5)COSvwm4X8Zes8ThEYDBJ()).SwitchToNextTimeframe, P_0))
						{
							dataCycle = fKvKggHFteRddgHojOPb.VrFHFZQNdhM(vCNppNY9xh.MarketSettings.DataCycle);
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						if (!((UQpOEF95Pl27GeSpKZ6s)DB2f5V4XPdBWWnnJRSoM(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY())).Check(P_0))
						{
							if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().TransferFunds.Check(P_0))
							{
								if (HCNE034XAGTK0Io5v4G2(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).ChangePnlDisplayMode, P_0))
								{
									chartPnlType = vCNppNY9xh.MarketSettings.TradeSettings.PnlType;
									num2 = 49;
									continue;
								}
								if (HCNE034XAGTK0Io5v4G2(kCHXxb4c08OxbvQr9hKq(HDCVke4XmWYrQZSCBGLS()), P_0))
								{
									if (((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).PositionSizeDisplayType == OnRZP7fwMaIGMRJa0UZR.RXcfwIii4Nl)
									{
										num2 = 45;
										continue;
									}
									CR1isWfDCD1A4fwfUJUf tradeSettings = vCNppNY9xh.MarketSettings.TradeSettings;
									OnRZP7fwMaIGMRJa0UZR onRZP7fwMaIGMRJa0UZR = tradeSettings.PositionSizeDisplayType;
									SiGjGM4c26bV2dL2tCbi(tradeSettings, onRZP7fwMaIGMRJa0UZR + 1);
									goto IL_0cc0;
								}
								if (vspL39fH6Hd69qemUHrA.Market.DeleteAllPriceLevels.Check(P_0))
								{
									gx9UOh4cHbilPhCQVwiy(vCNppNY9xh.MarketSettings.Levels, dHgqrT4sUuwmGxsWgPCW(base.Symbol));
									num2 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
									{
										num2 = 7;
									}
								}
								else if (vspL39fH6Hd69qemUHrA.Market.ChangeVolumeType.Check(P_0))
								{
									((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.MarketDepthViewType = G5WDO0fBspkJC1m1nhXd.P9FfBcwqeNY(((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).MarketDepthViewType);
									num2 = 26;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
									{
										num2 = 6;
									}
								}
								else if (!((UQpOEF95Pl27GeSpKZ6s)Gudk7M4cGNY9uKW35K0F(vspL39fH6Hd69qemUHrA.Market)).Check(P_0))
								{
									if (((UQpOEF95Pl27GeSpKZ6s)xD1DY54cojEQ47fUdaFc(vspL39fH6Hd69qemUHrA.Market)).Check(P_0))
									{
										LogInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29707810));
										num2 = 25;
										continue;
									}
									num2 = 40;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
									{
										num2 = 37;
									}
								}
								else
								{
									xVp9fn4cYdfowWdNTDDu(vCNppNY9xh.MarketSettings.VisualSettings, G5WDO0fBspkJC1m1nhXd.GBtfBj0hLjI(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).VisualSettings.DomRuler));
									u9RjOr4XwIn8vYgElwrM(P_0, true);
									num2 = 37;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
									{
										num2 = 34;
									}
								}
								continue;
							}
							if (!GHZMX04XFbOBqQecvMDx(RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)))
							{
								return;
							}
							goto case 19;
						}
						num2 = 15;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
						{
							num2 = 10;
						}
						continue;
					}
					j18iDj9nukSCmEyZs5lH.Settings.IsDomToolBarsVisible = !j18iDj9nukSCmEyZs5lH.Settings.IsDomToolBarsVisible;
					j18iDj9nukSCmEyZs5lH.Settings.IsChartToolBarsVisible = !j18iDj9nukSCmEyZs5lH.Settings.IsChartToolBarsVisible;
					P_0.Handled = true;
					return;
				case 14:
					if (NVYwSH4Xh9J5oPI3nAC6(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.Xlj9S1PXAPv))
					{
						num2 = 43;
						continue;
					}
					if (UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.vnE9SaoHshq) || UQpOEF95Pl27GeSpKZ6s.Check((UQpOEF95Pl27GeSpKZ6s)DLnkJ64XKO5dwqDOt5ME(vspL39fH6Hd69qemUHrA.Market), UQpOEF95Pl27GeSpKZ6s.Brn9S5rbbJu))
					{
						SetVisibleDepth(5);
						P_0.Handled = true;
						return;
					}
					if (!NVYwSH4Xh9J5oPI3nAC6(DLnkJ64XKO5dwqDOt5ME(vspL39fH6Hd69qemUHrA.Market), UQpOEF95Pl27GeSpKZ6s.MVg9SiKH5QV))
					{
						num2 = 38;
						continue;
					}
					goto case 16;
				case 7:
					NjbpMh2XWm();
					((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).SignalLevels.yalfP9nMZxk(base.Symbol.ID);
					num2 = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
					{
						num2 = 7;
					}
					continue;
				case 20:
					LogInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D3141E7));
					StopLoss();
					P_0.Handled = true;
					return;
				case 13:
					P_0.Handled = true;
					return;
				case 34:
					if (!o7E0Fw4XVqPBL1Akj7jO(P_0) && !P_0.IsRepeat)
					{
						if (VSomYr4XC8i9W2whodRq(P_0) == Key.None)
						{
							num = 46;
							break;
						}
						nsoV3Q4XrKobQhDggRF6(this, MVOnRc4XsbZHIA7lNf1c(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446AC3FA), P_0.Key.ToString()));
						num2 = 39;
						continue;
					}
					return;
				case 3:
					u9RjOr4XwIn8vYgElwrM(P_0, true);
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num2 = 50;
					}
					continue;
				case 47:
					return;
				case 24:
					P_0.Handled = true;
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 31;
					}
					continue;
				case 15:
					dataCycle2 = (DataCycle)DibQAW4XJf7wu6jrgYAD(vCNppNY9xh.MarketSettings.DataCycle);
					num2 = 12;
					continue;
				case 27:
					return;
				case 26:
					vbDDUC4cnwfBXJ0vdCBt(xK1PRp4cfVfE7ZkgUAfC(vCNppNY9xh.MarketSettings), wBp4084c9yXyHtjOpDi8(vCNppNY9xh.MarketSettings.TradeSettings));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
					{
						num2 = 3;
					}
					continue;
				case 35:
					j18iDj9nukSCmEyZs5lH.Settings.IsDomToolBarsVisible = !pUbkUf4X7PhloL5EgV8c(j18iDj9nukSCmEyZs5lH.Settings);
					u9RjOr4XwIn8vYgElwrM(P_0, true);
					return;
				case 48:
					P_0.Handled = true;
					return;
				case 40:
					if (!vspL39fH6Hd69qemUHrA.Market.SetStopLoss.Check(P_0))
					{
						if (!vspL39fH6Hd69qemUHrA.Market.DomOneClickSetup.Check(P_0))
						{
							num2 = 2;
							continue;
						}
						vCNppNY9xh.MarketSettings.DomOneClickSetup = !vCNppNY9xh.MarketSettings.DomOneClickSetup;
						u9RjOr4XwIn8vYgElwrM(P_0, true);
						num2 = 32;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 20;
				case 28:
					dAgpOZse8c();
					u9RjOr4XwIn8vYgElwrM(P_0, true);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 4;
					}
					continue;
				case 22:
					return;
				case 38:
					if (!UQpOEF95Pl27GeSpKZ6s.Check(vspL39fH6Hd69qemUHrA.Market.SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.wGO9SSMGKt8))
					{
						if (!UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.yp19Sl4YuF4))
						{
							num2 = 41;
							continue;
						}
						goto case 23;
					}
					num2 = 16;
					continue;
				case 12:
					if (dataCycle2 != null)
					{
						((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).DataCycle = dataCycle2;
					}
					P_0.Handled = true;
					return;
				case 21:
					return;
				case 19:
				{
					yBkHHnoFRLCqi3Cf0Cg9 yBkHHnoFRLCqi3Cf0Cg = new yBkHHnoFRLCqi3Cf0Cg9(gW2V5g4X3Ue2HWgJnOGU(j18iDj9nukSCmEyZs5lH.Settings).ToString(), CXeYIf4XpRpZrnjVE9Yt(j18iDj9nukSCmEyZs5lH.Settings).ToString(), ((MhMDPU9v8rkigy1ao0Th)wjjUAY4s1LxDDgaTwL0n()).TransferFundsAmount);
					yBkHHnoFRLCqi3Cf0Cg.Options = wkD2NhkYcfc();
					TransferFunds(yBkHHnoFRLCqi3Cf0Cg);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
					{
						num2 = 22;
					}
					continue;
				}
				case 42:
					if (fd8bVi4XZb2DsSPB8DFB(P_0) is EmbeddedTextBox)
					{
						return;
					}
					num2 = 34;
					continue;
				case 32:
					return;
				case 2:
					if (((UQpOEF95Pl27GeSpKZ6s)egMHur4cvCcrdc5vFAd8(vspL39fH6Hd69qemUHrA.Market)).Check(P_0))
					{
						OpenInstrumentChart();
						u9RjOr4XwIn8vYgElwrM(P_0, true);
						num2 = 18;
						continue;
					}
					return;
				case 37:
					return;
				case 44:
					P_0.Handled = true;
					return;
				case 50:
					return;
				case 16:
					SetVisibleDepth(6);
					num = 44;
					break;
				case 49:
					if (chartPnlType != ChartPnlType.Percent)
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 23:
					SetVisibleDepth(7);
					P_0.Handled = true;
					num = 21;
					break;
				case 18:
					return;
				case 36:
				case 43:
					SetVisibleDepth(4);
					num2 = 24;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					P_0.Handled = true;
					return;
				case 10:
					if (UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.xpC9SNioayQ))
					{
						goto IL_028f;
					}
					if (UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.uxp9SvJFers) || NVYwSH4Xh9J5oPI3nAC6(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.HFc9SkjjJhf))
					{
						SetVisibleDepth(3);
						P_0.Handled = true;
						num = 27;
						break;
					}
					if (UQpOEF95Pl27GeSpKZ6s.Check((UQpOEF95Pl27GeSpKZ6s)DLnkJ64XKO5dwqDOt5ME(vspL39fH6Hd69qemUHrA.Market), UQpOEF95Pl27GeSpKZ6s.oNZ9SBcxPEY))
					{
						num2 = 36;
						continue;
					}
					goto case 14;
				case 9:
					if (dataCycle != null)
					{
						num2 = 5;
						continue;
					}
					goto case 33;
				case 1:
				{
					CR1isWfDCD1A4fwfUJUf tradeSettings2 = ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings;
					ChartPnlType chartPnlType2 = Qhr20b4XuhAppZPTle2r(tradeSettings2);
					jZwmI24XzHXgcQDKUwsl(tradeSettings2, chartPnlType2 + 1);
					goto IL_069a;
				}
				case 46:
					return;
				case 31:
					return;
				case 25:
					TakeProfit();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num2 = 17;
					}
					continue;
				case 17:
					P_0.Handled = true;
					return;
				case 6:
					SetVisibleDepth(1);
					num2 = 8;
					continue;
				case 4:
					return;
				case 33:
					P_0.Handled = true;
					num2 = 47;
					continue;
				case 45:
					((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.PositionSizeDisplayType = OnRZP7fwMaIGMRJa0UZR.lV7fwqCq3W9;
					goto IL_0cc0;
				case 39:
					{
						if (UQpOEF95Pl27GeSpKZ6s.Check((UQpOEF95Pl27GeSpKZ6s)DLnkJ64XKO5dwqDOt5ME(vspL39fH6Hd69qemUHrA.Market), UQpOEF95Pl27GeSpKZ6s.Rnp9SGqwMxA) || UQpOEF95Pl27GeSpKZ6s.Check(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.tNe9SDePlak))
						{
							SetVisibleDepth(0);
							num2 = 13;
							continue;
						}
						if (UQpOEF95Pl27GeSpKZ6s.Check((UQpOEF95Pl27GeSpKZ6s)DLnkJ64XKO5dwqDOt5ME(HDCVke4XmWYrQZSCBGLS()), UQpOEF95Pl27GeSpKZ6s.Uka9SYQPEtI))
						{
							num2 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						if (UQpOEF95Pl27GeSpKZ6s.Check(vspL39fH6Hd69qemUHrA.Market.SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.XU59SbIRJxx))
						{
							goto case 6;
						}
						if (!UQpOEF95Pl27GeSpKZ6s.Check(vspL39fH6Hd69qemUHrA.Market.SetVisibleDepth, UQpOEF95Pl27GeSpKZ6s.Kel9So1eDHs))
						{
							num2 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto IL_028f;
					}
					IL_0cc0:
					P_0.Handled = true;
					return;
					IL_028f:
					SetVisibleDepth(2);
					num2 = 48;
					continue;
					IL_069a:
					P_0.Handled = true;
					return;
				}
				break;
			}
		}
	}

	private void Market_KeyDown(object sender, KeyEventArgs e)
	{
		int num = 1;
		int num2 = num;
		int? offset = default(int?);
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		double quantityReal = default(double);
		double num5 = default(double);
		double quantityReal2 = default(double);
		double num10 = default(double);
		double num11 = default(double);
		double quantityReal4 = default(double);
		Hashtable options = default(Hashtable);
		double quantityReal3 = default(double);
		double num8 = default(double);
		double num17 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				return;
			case 1:
				if (e.OriginalSource is TextBox)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (e.OriginalSource is EmbeddedTextBox || o7E0Fw4XVqPBL1Akj7jO(e))
			{
				return;
			}
			if (e.Key == Key.None)
			{
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num2 = 2;
				}
				continue;
			}
			string text = "";
			try
			{
				if (((KedBU3f05IsrqcZmlPn5)COSvwm4X8Zes8ThEYDBJ()).AdjPresetSizeViaScroll.Check(e))
				{
					if (vCNppNY9xh.MarketSettings.PresetAdjViaScrollMode || vCNppNY9xh.IsExtendedLotsInDOMShowed)
					{
						e.Handled = true;
						return;
					}
					goto IL_0ff9;
				}
				goto IL_16e6;
				IL_00d7:
				int num3;
				while (true)
				{
					int num6;
					double num12;
					double num9;
					switch (num3)
					{
					case 4:
						return;
					case 23:
						return;
					case 27:
						return;
					case 50:
						return;
					case 120:
						return;
					case 8:
						break;
					case 6:
						((TradingSettings)tiNq3I4cqHRnjGqpyjPU(ViewModel)).MarketSettings.Preset1IsSelected = true;
						num3 = 26;
						continue;
					case 44:
						offset = base.Symbol.GetOffset(((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).LimitOrderOffset, vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderPercentOffset, DWdoIa4cjVAWROjLWyiW(b90tpw4csOdniyIGXyiT(ypqMIv9maFM0tRwF0xMh)), vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
						num3 = 40;
						continue;
					case 56:
						u9RjOr4XwIn8vYgElwrM(e, true);
						num3 = 107;
						continue;
					case 65:
						goto IL_03bb;
					case 84:
						goto IL_03fc;
					case 122:
						if (HCNE034XAGTK0Io5v4G2(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).SetBreakevenStopLoss, e))
						{
							num6 = 77;
							goto IL_00d3;
						}
						if (vspL39fH6Hd69qemUHrA.Market.SetNoStrategy.Check(e))
						{
							text = (string)jqdeOo4eKgiRI3O5pbjF(-2017337494 ^ -2017351448);
							LogInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D3E178));
							num3 = 21;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
							{
								num3 = 105;
							}
							continue;
						}
						goto IL_0adc;
					case 106:
						e.Handled = true;
						num3 = 27;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
						{
							num3 = 101;
						}
						continue;
					case 63:
					{
						if (!zjFphYRBVo(out var num4))
						{
							return;
						}
						quantityReal = p9XOm94cNZpHqNSqHPwL(num4, x9WESE4c5J8h6CqeLHYt(ypqMIv9maFM0tRwF0xMh.OpZl98KAYgk()) * joJdkB4XMrXtr4Kkh0AK(ypqMIv9maFM0tRwF0xMh), base.Symbol.LotStep, gKwrDf4XHarOHGiaqCt9(base.Symbol), num5, sKWEkV4cSpUyQAaMcgeJ(base.Symbol));
						goto IL_19b0;
					}
					case 128:
						if (!((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).CancelBids.Check(e))
						{
							if (vspL39fH6Hd69qemUHrA.Market.CancelAsks.Check(e))
							{
								text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x24082E0E);
								num6 = 22;
								goto IL_00d3;
							}
							goto case 93;
						}
						goto case 102;
					case 38:
						ClosePosition();
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
					case 115:
						u9RjOr4XwIn8vYgElwrM(e, true);
						num3 = 63;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
						{
							num3 = 82;
						}
						continue;
					case 124:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB17448);
						num6 = 6;
						goto IL_00d3;
					case 113:
						nsoV3Q4XrKobQhDggRF6(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D554CB2));
						Market.SetBreakevenStopLoss();
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num3 = 1;
						}
						continue;
					case 95:
						LogInfo((string)jqdeOo4eKgiRI3O5pbjF(0x50C1C840 ^ 0x50C1BD3A) + e.Key);
						num3 = 72;
						continue;
					case 64:
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
					case 28:
						options = null;
						num6 = 80;
						goto IL_00d3;
					case 123:
					case 130:
						quantityReal2 = JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(num10, ypqMIv9maFM0tRwF0xMh.OpZl98KAYgk().BidPrice * ypqMIv9maFM0tRwF0xMh.UJElnHayjot, base.Symbol.LotStep, base.Symbol.Step, num11, base.Symbol.SizeStep);
						num3 = 44;
						continue;
					case 48:
						text = (string)jqdeOo4eKgiRI3O5pbjF(0x746ED405 ^ 0x746EA195);
						num3 = 107;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
						{
							num3 = 127;
						}
						continue;
					case 21:
						LogInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736548164));
						YZMpQQQfhC();
						num3 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
						{
							num3 = 64;
						}
						continue;
					case 69:
						((MarketSettings)D3Twqm4epV7tBTfp7yTI(ViewModel.Settings)).Preset5IsSelected = true;
						e.Handled = true;
						goto default;
					case 67:
						options = null;
						num3 = 29;
						continue;
					case 105:
						tx4pB9jQSG();
						num3 = 56;
						continue;
					case 15:
						vCNppNY9xh.MarketSettings.CurrentPreset.PercentSize++;
						num3 = 66;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num3 = 104;
						}
						continue;
					case 88:
						if (ypqMIv9maFM0tRwF0xMh == null)
						{
							return;
						}
						if (base.Symbol != null)
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 78;
					case 32:
						Market.Scroll(-50);
						e.Handled = true;
						goto default;
					case 10:
						goto IL_0adc;
					case 45:
						goto IL_0b20;
					case 62:
						if (ypqMIv9maFM0tRwF0xMh == null)
						{
							return;
						}
						goto case 81;
					case 17:
						LogInfo((string)jqdeOo4eKgiRI3O5pbjF(-90307782 ^ -90276926));
						OsDpgtnvsV();
						e.Handled = true;
						goto default;
					case 9:
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
					case 5:
						goto IL_0b88;
					case 110:
						goto IL_0bf2;
					case 24:
						e.Handled = true;
						num3 = 41;
						continue;
					case 87:
						if (xCdooR4cDnGvewx5YPYS(vCNppNY9xh.MarketSettings))
						{
							num3 = 88;
							continue;
						}
						goto IL_19b0;
					case 126:
						if (Market.iJaf1hBN7vk().OltfAW7OUUJ() != null && VSomYr4XC8i9W2whodRq(e) == Key.Delete)
						{
							num3 = 48;
							continue;
						}
						goto case 98;
					case 118:
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
					case 78:
						num12 = oXZHn74cblbk5dFU9wDw(base.Symbol);
						goto IL_20e9;
					case 54:
						offset = null;
						num3 = 86;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
						{
							num3 = 55;
						}
						continue;
					case 125:
						goto IL_0d4e;
					case 81:
						quantityReal4 = ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).CurrentPreset.Size;
						num3 = 116;
						continue;
					case 80:
						SellLimit(quantityReal2, null, offset, ChartOrderValidity.Day, options);
						e.Handled = true;
						num3 = 43;
						continue;
					case 116:
						if (!JBEUaS4s7sNyDVOQ7p26(vCNppNY9xh.MarketSettings))
						{
							num6 = 90;
							goto IL_00d3;
						}
						goto IL_1970;
					case 129:
						text = (string)jqdeOo4eKgiRI3O5pbjF(--927068468 ^ 0x374184D2);
						Market.MAUfSaMQQNU();
						e.Handled = true;
						num3 = 50;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
						{
							num3 = 92;
						}
						continue;
					case 72:
						vCNppNY9xh.MarketSettings.PresetAdjViaScrollMode = true;
						u9RjOr4XwIn8vYgElwrM(e, true);
						Market.NeedRedraw();
						return;
					case 61:
						CancelAllOrders();
						num3 = 53;
						continue;
					case 85:
						if (HCNE034XAGTK0Io5v4G2(aZGZMF4cCQpWeGMRZMZa(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY()), e))
						{
							text = (string)jqdeOo4eKgiRI3O5pbjF(-1583344314 ^ -1583321304);
							((MarketSettings)D3Twqm4epV7tBTfp7yTI(tiNq3I4cqHRnjGqpyjPU(ViewModel))).Preset4IsSelected = true;
							num3 = 50;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
							{
								num3 = 52;
							}
							continue;
						}
						if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().OrderSize5.Check(e))
						{
							num3 = 60;
							continue;
						}
						goto default;
					case 34:
						options = null;
						goto case 7;
					case 39:
						if (!vspL39fH6Hd69qemUHrA.Market.ReduceOnlyMode.Check())
						{
							options = null;
							goto IL_1533;
						}
						num3 = 119;
						continue;
					case 49:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297B427);
						num3 = 12;
						continue;
					case 117:
						goto end_IL_00d7;
					case 22:
						CancelAskOrders();
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
					case 33:
						ClosePosition();
						e.Handled = true;
						goto default;
					case 18:
						if (JBEUaS4s7sNyDVOQ7p26(vCNppNY9xh.MarketSettings))
						{
							goto case 88;
						}
						goto case 87;
					case 25:
					case 79:
						u9RjOr4XwIn8vYgElwrM(e, true);
						num3 = 74;
						continue;
					case 98:
						if (((G2gR30fAanPKf0TTFLoc)KtmD9w4camRRph8QCyXI(Market)).OltfAW7OUUJ() != null && VSomYr4XC8i9W2whodRq(e) == Key.Delete)
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315AC455);
							Market.dQZfSBQVPfu();
							u9RjOr4XwIn8vYgElwrM(e, true);
							num3 = 62;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
							{
								num3 = 112;
							}
							continue;
						}
						if (Market.axFf1ARQQOr().OltfAW7OUUJ() != null && e.Key == Key.Delete)
						{
							num3 = 59;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
							{
								num3 = 129;
							}
							continue;
						}
						if (((UQpOEF95Pl27GeSpKZ6s)plOYQo4ciTObZSkyh1Bj(HDCVke4XmWYrQZSCBGLS())).Check(e))
						{
							num3 = 8;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
							{
								num3 = 70;
							}
							continue;
						}
						if (!HCNE034XAGTK0Io5v4G2(LioO1H4c1ka7gnUokq9T(HDCVke4XmWYrQZSCBGLS()), e))
						{
							if (!((UQpOEF95Pl27GeSpKZ6s)mNF08U4cxxY0DhSmCgxm(vspL39fH6Hd69qemUHrA.Market)).Check(e))
							{
								goto IL_03bb;
							}
							text = (string)jqdeOo4eKgiRI3O5pbjF(0x1EFE0A28 ^ 0x1EFE7C74);
							num6 = 38;
						}
						else
						{
							text = (string)jqdeOo4eKgiRI3O5pbjF(-2123795572 ^ -2123823672);
							quantityReal = csnmyq4c4HHimkvHocgK(JGLLZl4clCmBintCyUsR(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)));
							num6 = 18;
						}
						goto IL_00d3;
					case 83:
						ViewModel.Settings.MarketSettings.CurrentPreset.QuoteSize = K3FvE34cOpoDaDD2lefb(JGLLZl4clCmBintCyUsR(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)));
						num3 = 55;
						continue;
					case 114:
						if (((KedBU3f05IsrqcZmlPn5)COSvwm4X8Zes8ThEYDBJ()).OrderSizeUp.Check(e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F6270);
							if (vCNppNY9xh.MarketSettings.ExecuteInQuoteCurrency)
							{
								vCNppNY9xh.MarketSettings.CurrentPreset.QuoteSize++;
								num6 = 83;
								goto IL_00d3;
							}
							goto case 42;
						}
						if (((UQpOEF95Pl27GeSpKZ6s)ipn5ex4ctUkbBEyQsaNq(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY())).Check(e))
						{
							text = (string)jqdeOo4eKgiRI3O5pbjF(-338769610 ^ -338775234);
							if (!JBEUaS4s7sNyDVOQ7p26(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)))
							{
								goto IL_0428;
							}
							EpdvD7f3hWq8UlJ32f6V currentPreset = vCNppNY9xh.MarketSettings.CurrentPreset;
							double num13 = currentPreset.QuoteSize;
							J7To0t4cUYfI7kvS6owM(currentPreset, num13 - 1.0);
							ViewModel.Settings.MarketSettings.CurrentPreset.QuoteSize = ((EpdvD7f3hWq8UlJ32f6V)JGLLZl4clCmBintCyUsR(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).QuoteSize;
							goto case 25;
						}
						if (((UQpOEF95Pl27GeSpKZ6s)T4o14O4cyuP69lKRE7hy(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY())).Check(e))
						{
							goto case 124;
						}
						goto IL_1d32;
					case 59:
						e.Handled = true;
						goto default;
					case 104:
						((TradingSettings)tiNq3I4cqHRnjGqpyjPU(ViewModel)).MarketSettings.CurrentPreset.PercentSize = mrT5mM4cIb2m9wtIo6oA(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).CurrentPreset);
						num3 = 131;
						continue;
					case 19:
						vCNppNY9xh.MarketSettings.CurrentPreset.Size++;
						chHgyK4cWyLxajnM6bjA(JGLLZl4clCmBintCyUsR(ViewModel.Settings.MarketSettings), ((EpdvD7f3hWq8UlJ32f6V)JGLLZl4clCmBintCyUsR(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).Size);
						num3 = 58;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
						{
							num3 = 76;
						}
						continue;
					case 127:
						adnMUu4cBheAKnXhPbWR(Market);
						num3 = 118;
						continue;
					case 47:
						goto IL_13ee;
					case 12:
						((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).UseTriggers = !SHfX744cdfwrZ4KepPbl(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
						nsoV3Q4XrKobQhDggRF6(this, (string)jqdeOo4eKgiRI3O5pbjF(-1461292091 ^ -1461320659) + ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).UseTriggers);
						num3 = 75;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
						{
							num3 = 41;
						}
						continue;
					case 94:
						u9RjOr4XwIn8vYgElwrM(e, true);
						num3 = 58;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
						{
							num3 = 51;
						}
						continue;
					case 70:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD3903);
						num3 = 14;
						continue;
					case 35:
						if (((UQpOEF95Pl27GeSpKZ6s)QyM1Lk4ccPhmZyNaiavo(HDCVke4XmWYrQZSCBGLS())).Check(e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991883037);
							if (ypqMIv9maFM0tRwF0xMh == null)
							{
								return;
							}
							quantityReal2 = vCNppNY9xh.MarketSettings.CurrentPreset.Size;
							num6 = 36;
							goto IL_00d3;
						}
						goto case 37;
					case 99:
						goto IL_1492;
					case 2:
						if (base.Symbol.IsGateIo)
						{
							if (base.Symbol.Type != SymbolType.Future)
							{
								num3 = 78;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
								{
									num3 = 45;
								}
								continue;
							}
							num12 = 1.0;
							goto IL_20e9;
						}
						goto case 78;
					case 93:
						if (HCNE034XAGTK0Io5v4G2(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).CancelAll, e))
						{
							text = (string)jqdeOo4eKgiRI3O5pbjF(-842040449 ^ -842048849);
							num6 = 61;
							goto IL_00d3;
						}
						goto case 122;
					case 102:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2D8D1B);
						num3 = 57;
						continue;
					case 51:
						num9 = oXZHn74cblbk5dFU9wDw(base.Symbol);
						goto IL_2123;
					case 71:
					case 73:
						goto IL_1690;
					case 68:
						goto IL_16e6;
					case 1:
						e.Handled = true;
						num6 = 121;
						goto IL_00d3;
					case 26:
						e.Handled = true;
						goto default;
					case 119:
						options = new Hashtable { [jqdeOo4eKgiRI3O5pbjF(0x769C7931 ^ 0x769C0F1D)] = true };
						goto IL_1533;
					case 100:
						RtmrpV4cMlIZ91Zhd9Qm(vspL39fH6Hd69qemUHrA.Market.TurnCustomRulerOn);
						num3 = 9;
						continue;
					case 36:
						if (!vCNppNY9xh.MarketSettings.ExecuteInQuoteCurrency && !xCdooR4cDnGvewx5YPYS(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)))
						{
							goto case 44;
						}
						if (base.Symbol == null || !base.Symbol.IsGateIo)
						{
							goto case 51;
						}
						if (base.Symbol.Type != SymbolType.Future)
						{
							num3 = 37;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
							{
								num3 = 51;
							}
							continue;
						}
						num9 = 1.0;
						goto IL_2123;
					case 90:
						goto IL_1832;
					case 96:
						ViewModel.Settings.MarketSettings.CurrentPreset.Size = ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).CurrentPreset.Size;
						num6 = 79;
						goto IL_00d3;
					default:
						if (e.Handled)
						{
							Market.NeedRedraw();
						}
						return;
					case 89:
						goto IL_1970;
					case 14:
						quantityReal3 = csnmyq4c4HHimkvHocgK(JGLLZl4clCmBintCyUsR(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)));
						if (!JBEUaS4s7sNyDVOQ7p26(vCNppNY9xh.MarketSettings) && !xCdooR4cDnGvewx5YPYS(vCNppNY9xh.MarketSettings))
						{
							goto IL_0bcf;
						}
						goto IL_0d20;
					case 40:
						if (vspL39fH6Hd69qemUHrA.Market.ReduceOnlyMode.Check())
						{
							num3 = 20;
							continue;
						}
						goto case 28;
					case 42:
						if (vCNppNY9xh.MarketSettings.ExecuteInPercents)
						{
							num3 = 15;
							continue;
						}
						goto case 19;
					case 75:
						Market.NeedRedraw(_0020: true);
						num6 = 115;
						goto IL_00d3;
					case 60:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x60627547);
						num3 = 69;
						continue;
					case 7:
						BuyMarket(quantityReal3, options);
						e.Handled = true;
						num3 = 30;
						continue;
					case 97:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -60879917);
						num3 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
						{
							num3 = 100;
						}
						continue;
					case 109:
					{
						if (!zjFphYRBVo(out var num7))
						{
							return;
						}
						quantityReal3 = p9XOm94cNZpHqNSqHPwL(num7, ypqMIv9maFM0tRwF0xMh.OpZl98KAYgk().AskPrice * ypqMIv9maFM0tRwF0xMh.UJElnHayjot, base.Symbol.LotStep, base.Symbol.Step, num8, base.Symbol.SizeStep);
						goto IL_0bcf;
					}
					case 20:
					{
						Hashtable hashtable = new Hashtable();
						object obj = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127443208);
						MwZ2fN4cEsKN7kR5nNUs(hashtable, obj, true);
						options = hashtable;
						goto case 80;
					}
					case 103:
						if (((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).TurnCustomRulerOn.Check(e))
						{
							num3 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
							{
								num3 = 97;
							}
							continue;
						}
						goto case 114;
					case 66:
						if (vspL39fH6Hd69qemUHrA.Market.ScrollCenterAll.Check(e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7BD84B);
							z6kMSs25KYyGVf55FxBT.gKM25wGZHtJ((BlmlL92DciZPrtYF1X4r)8);
							num3 = 111;
							continue;
						}
						goto case 103;
					case 57:
						CancelBidOrders();
						num3 = 24;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
						{
							num3 = 2;
						}
						continue;
					case 91:
						e.Handled = true;
						goto default;
					case 52:
						e.Handled = true;
						goto default;
					case 31:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BED558);
						num3 = 21;
						continue;
					case 77:
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746EA323);
						num3 = 113;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num3 = 25;
						}
						continue;
					case 53:
						e.Handled = true;
						num3 = 16;
						continue;
					case 55:
					case 76:
					case 131:
						e.Handled = true;
						goto default;
					case 11:
					case 29:
						SellMarket(quantityReal, options);
						num3 = 94;
						continue;
					case 37:
						if (!HCNE034XAGTK0Io5v4G2(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).ReversePosition, e))
						{
							goto case 128;
						}
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074121584);
						ReversePosition();
						e.Handled = true;
						goto default;
					case 111:
						u9RjOr4XwIn8vYgElwrM(e, true);
						num3 = 108;
						continue;
					case 86:
						{
							ypqMIv9maFM0tRwF0xMh = iry2NPTGQJC().fuulnktHjJ4(base.Symbol?.ID);
							num3 = 126;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
							{
								num3 = 49;
							}
							continue;
						}
						IL_0bcf:
						if (MYJhBV4ckqVcCL3HhDve(vspL39fH6Hd69qemUHrA.Market.ReduceOnlyMode))
						{
							options = new Hashtable { [stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD3939)] = true };
							num3 = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 34;
						IL_19b0:
						if (MYJhBV4ckqVcCL3HhDve(vspL39fH6Hd69qemUHrA.Market.ReduceOnlyMode))
						{
							options = new Hashtable { [jqdeOo4eKgiRI3O5pbjF(0x9F0F634 ^ 0x9F08018)] = true };
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 67;
						IL_00d3:
						num3 = num6;
						continue;
						IL_2123:
						num11 = num9;
						if (!zjFphYRBVo(out num10))
						{
							return;
						}
						num3 = 123;
						continue;
						IL_1533:
						BuyLimit(quantityReal4, null, offset, ChartOrderValidity.Day, options);
						u9RjOr4XwIn8vYgElwrM(e, true);
						goto default;
						IL_20e9:
						num5 = num12;
						num3 = 62;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
						{
							num3 = 63;
						}
						continue;
					}
					if (HCNE034XAGTK0Io5v4G2(((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).ScrollUp, e))
					{
						Market.Scroll(50);
						num3 = 59;
						continue;
					}
					if (HCNE034XAGTK0Io5v4G2(vspL39fH6Hd69qemUHrA.Market.ScrollDown, e))
					{
						text = (string)jqdeOo4eKgiRI3O5pbjF(-894902996 ^ -894917538);
						num3 = 32;
						continue;
					}
					goto IL_13ee;
					IL_0d20:
					if (ypqMIv9maFM0tRwF0xMh == null)
					{
						return;
					}
					if (base.Symbol != null)
					{
						num3 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
						{
							num3 = 2;
						}
						continue;
					}
					goto IL_1eb6;
					IL_11b9:
					offset = base.Symbol.GetOffset(vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderOffset, vCNppNY9xh.MarketSettings.TradeSettings.LimitOrderPercentOffset, Tx4Jkg4cXr2gWAbJWJhC(b90tpw4csOdniyIGXyiT(ypqMIv9maFM0tRwF0xMh)), vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
					num3 = 19;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num3 = 39;
					}
					continue;
					IL_0b20:
					if (!HCNE034XAGTK0Io5v4G2(wIBCWj4cgi9C7pSxgx5B(HDCVke4XmWYrQZSCBGLS()), e))
					{
						if (((UQpOEF95Pl27GeSpKZ6s)pMvePv4cR4hTTlGv6xpA(HDCVke4XmWYrQZSCBGLS())).Check(e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063343387);
							num3 = 17;
						}
						else if (HCNE034XAGTK0Io5v4G2(vspL39fH6Hd69qemUHrA.Market.TurnUpPriceScale, e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD54BE6);
							WlopccISKL(1);
							num3 = 106;
						}
						else if (((UQpOEF95Pl27GeSpKZ6s)BU6wDp4c6JEeLYojGN3O(vspL39fH6Hd69qemUHrA.Market)).Check(e))
						{
							text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA88660);
							WlopccISKL(-1);
							u9RjOr4XwIn8vYgElwrM(e, true);
							num3 = 13;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							num3 = 8;
						}
					}
					else
					{
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86E8680);
						LogInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774600021));
						KgSpdMaHHh();
						e.Handled = true;
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
						{
							num3 = 0;
						}
					}
					continue;
					IL_0b88:
					if (!base.Symbol.IsGateIo || base.Symbol.Type != SymbolType.Future)
					{
						goto IL_1eb6;
					}
					double num14 = 1.0;
					goto IL_20d4;
					IL_1832:
					if (vCNppNY9xh.MarketSettings.ExecuteInPercents)
					{
						num3 = 83;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num3 = 89;
						}
						continue;
					}
					goto IL_11b9;
					IL_03fc:
					text = (string)jqdeOo4eKgiRI3O5pbjF(-1962651919 ^ -1962657701);
					num3 = 62;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
					{
						num3 = 60;
					}
					continue;
					IL_1eb6:
					num14 = oXZHn74cblbk5dFU9wDw(base.Symbol);
					goto IL_20d4;
					IL_0428:
					if (!vCNppNY9xh.MarketSettings.ExecuteInPercents)
					{
						EpdvD7f3hWq8UlJ32f6V currentPreset2 = vCNppNY9xh.MarketSettings.CurrentPreset;
						double num13 = csnmyq4c4HHimkvHocgK(currentPreset2);
						currentPreset2.Size = num13 - 1.0;
						num3 = 96;
						continue;
					}
					object obj2 = JGLLZl4clCmBintCyUsR(vCNppNY9xh.MarketSettings);
					int num15 = ((EpdvD7f3hWq8UlJ32f6V)obj2).PercentSize;
					fj90IL4cTpOjsynVYow2(obj2, num15 - 1);
					((EpdvD7f3hWq8UlJ32f6V)JGLLZl4clCmBintCyUsR(((TradingSettings)tiNq3I4cqHRnjGqpyjPU(ViewModel)).MarketSettings)).PercentSize = mrT5mM4cIb2m9wtIo6oA(vCNppNY9xh.MarketSettings.CurrentPreset);
					num3 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num3 = 25;
					}
					continue;
					IL_0bf2:
					if (zjFphYRBVo(out var num16))
					{
						quantityReal4 = JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(num16, ypqMIv9maFM0tRwF0xMh.OpZl98KAYgk().AskPrice * ypqMIv9maFM0tRwF0xMh.UJElnHayjot, base.Symbol.LotStep, base.Symbol.Step, num17, base.Symbol.SizeStep);
						goto IL_11b9;
					}
					num3 = 50;
					continue;
					IL_13ee:
					if (vspL39fH6Hd69qemUHrA.Market.ScrollCenter.Check(e))
					{
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B33C31);
						Market.ScrollCenter();
						e.Handled = true;
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
						{
							num3 = 3;
						}
					}
					else
					{
						num3 = 66;
					}
					continue;
					IL_20d4:
					num8 = num14;
					num3 = 109;
					continue;
					IL_1d32:
					if (!((UQpOEF95Pl27GeSpKZ6s)IIm9Es4cZ4Gste9E8tcO(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY())).Check(e))
					{
						if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().OrderSize3.Check(e))
						{
							num3 = 85;
							continue;
						}
						goto IL_0d4e;
					}
					text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45454877);
					Bv1lEn4cVTb28tXwyr5N(D3Twqm4epV7tBTfp7yTI(ViewModel.Settings), true);
					num3 = 38;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
					{
						num3 = 91;
					}
					continue;
					IL_0adc:
					if (((UQpOEF95Pl27GeSpKZ6s)aPXJZK4cQoSyMFbymNHJ(vspL39fH6Hd69qemUHrA.Market)).Check(e))
					{
						num3 = 49;
						continue;
					}
					if (vspL39fH6Hd69qemUHrA.Market.SetServerAlertLevel.Check(e))
					{
						num3 = 31;
						continue;
					}
					goto IL_0b20;
					IL_210e:
					double num18;
					num17 = num18;
					num3 = 110;
					continue;
					IL_1690:
					num18 = base.Symbol.ContractValue;
					goto IL_210e;
					IL_0d4e:
					text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD3543);
					((TradingSettings)tiNq3I4cqHRnjGqpyjPU(ViewModel)).MarketSettings.Preset3IsSelected = true;
					e.Handled = true;
					num3 = 46;
					continue;
					IL_1970:
					if (base.Symbol == null)
					{
						goto IL_1690;
					}
					if (!NWHBx04cLxm6ihY3ijne(base.Symbol))
					{
						num3 = 71;
						continue;
					}
					if (d9ijCB4cecA3XlCcSNZ4(base.Symbol) != SymbolType.Future)
					{
						num3 = 73;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
						{
							num3 = 7;
						}
						continue;
					}
					num18 = 1.0;
					goto IL_210e;
					IL_03bb:
					if (HCNE034XAGTK0Io5v4G2(vspL39fH6Hd69qemUHrA.Market.ClosePositionAndOrders, e))
					{
						text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251542611);
						CancelAllOrders();
						num3 = 33;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
						{
							num3 = 8;
						}
						continue;
					}
					if (!((NMTiYCfHpOuSq61sDR0L)HDCVke4XmWYrQZSCBGLS()).BuyLimit.Check(e))
					{
						num3 = 35;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
						{
							num3 = 7;
						}
						continue;
					}
					goto IL_03fc;
					continue;
					end_IL_00d7:
					break;
				}
				goto IL_0ff9;
				IL_1492:
				nsoV3Q4XrKobQhDggRF6(this, MVOnRc4XsbZHIA7lNf1c(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x42278D2), e.Key.ToString()));
				num3 = 54;
				goto IL_00d7;
				IL_16e6:
				if (e.IsRepeat)
				{
					return;
				}
				goto IL_1492;
				IL_0ff9:
				text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153236167);
				num3 = 95;
				goto IL_00d7;
			}
			catch (Exception ex)
			{
				sfpvDY4cr7XfpUJ86FA0(MVOnRc4XsbZHIA7lNf1c(jqdeOo4eKgiRI3O5pbjF(-1461949456 ^ -1461972626), text), ex);
				return;
			}
		}
	}

	private void tx4pB9jQSG()
	{
		ex6KFw2WejF3Y0Rqo9YD ex6KFw2WejF3Y0Rqo9YD = ((z48ObB20gSriKUfj18p3)RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)).Strategies.FirstOrDefault((ex6KFw2WejF3Y0Rqo9YD s) => s.JgL2WdI2A3a().z9l2O3qrToV());
		if (ex6KFw2WejF3Y0Rqo9YD != null)
		{
			((z48ObB20gSriKUfj18p3)RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)).SelectedStrategy = ex6KFw2WejF3Y0Rqo9YD;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
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

	private void Market_KeyUp(object sender, KeyEventArgs e)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				JnZBZy4cwjGk0VLdJwYC(AW63q04ch6M4C38My6AV(HDCVke4XmWYrQZSCBGLS()));
				return;
			case 2:
				eXqyHB4cKxy1SYWXqDlp(Market);
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				if (((UQpOEF95Pl27GeSpKZ6s)wIBCWj4cgi9C7pSxgx5B(vspL39fH6Hd69qemUHrA.Market)).Check(e))
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
					{
						num2 = 0;
					}
				}
				else if (!vspL39fH6Hd69qemUHrA.Market.SetServerAlertLevel.Check(e))
				{
					if (((UQpOEF95Pl27GeSpKZ6s)pMvePv4cR4hTTlGv6xpA(vspL39fH6Hd69qemUHrA.Market)).Check(e))
					{
						pjGKoN4cmGGxl8R74SHr(Market);
						return;
					}
					if (!vspL39fH6Hd69qemUHrA.Market.TurnCustomRulerOn.Check(e))
					{
						if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().AdjPresetSizeViaScroll.Check(e))
						{
							oR9i9a4c7WW5HdaNZHxf(vCNppNY9xh.MarketSettings, false);
						}
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					Market.f4Of5PKy2ua();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 0:
				return;
			case 4:
				return;
			}
		}
	}

	private void LbNpag6l2u()
	{
		int num;
		string text = default(string);
		if (base.Symbol == null)
		{
			if (vCNppNY9xh.zDi2k7CwL38)
			{
				num = 6;
			}
			else
			{
				PpS2SH4LJi3(vCNppNY9xh.DefaultTitle);
				int num2 = 14;
				num = num2;
			}
		}
		else
		{
			text = (string)(nB1ZH44c8Sf6BtgbbcvF(vCNppNY9xh) ? vCNppNY9xh.vlP2kmioDGU : gbnGar4cAxwxx405YtOV(wjjUAY4s1LxDDgaTwL0n()));
			num = 7;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
			{
				num = 9;
			}
		}
		string text2 = default(string);
		while (true)
		{
			string text3;
			switch (num)
			{
			case 4:
				text2 = text2.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -617078049), (string)l2aNc64c3E9kGwffnm3A(iry2NPTGQJC().DataCycle));
				num = 3;
				break;
			case 1:
				text = text.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C03EF), JLW38MA3gp().ToString((string)jqdeOo4eKgiRI3O5pbjF(-165474503 ^ -165448237)));
				num = 7;
				break;
			case 14:
				return;
			case 16:
				PpS2SH4LJi3(text);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num = 12;
				}
				break;
			default:
				text = (string)U5ppWi4cJQtmtw1FHla7(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53795994), GetDataScale(GetSymbolID()).ToString());
				num = 15;
				break;
			case 8:
				if (text.Contains((string)jqdeOo4eKgiRI3O5pbjF(0x24B0B9E6 ^ 0x24B0F038)))
				{
					text = (string)U5ppWi4cJQtmtw1FHla7(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F0BFEA), base.Symbol.Exchange);
				}
				if (iWhZXE4cPGoyD4MGt6TA(text, jqdeOo4eKgiRI3O5pbjF(0x2BD86B18 ^ 0x2BD811EA)))
				{
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num = 11;
					}
					break;
				}
				goto IL_03bf;
			case 11:
				text = text.Replace((string)jqdeOo4eKgiRI3O5pbjF(0x769C7931 ^ 0x769C03C3), (string)l2aNc64c3E9kGwffnm3A(ht799Z4cFRp8fdtbwwom(iry2NPTGQJC())));
				goto IL_03bf;
			case 7:
				if (text.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB440A7)))
				{
					text = (string)U5ppWi4cJQtmtw1FHla7(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBEA3E5), base.Symbol.Name);
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num = 8;
					}
					break;
				}
				goto case 8;
			case 3:
				PpS2SH4LJi3(text2);
				num = 2;
				break;
			case 5:
				if (text.Contains((string)jqdeOo4eKgiRI3O5pbjF(-2108526692 ^ -2108549810)))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 15;
			case 13:
				text3 = ((Akr2k2PGDPZ().Value >= 0.0) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342746396) : "") + Akr2k2PGDPZ().Value.ToString((string)jqdeOo4eKgiRI3O5pbjF(-1736566656 ^ -1736543884));
				goto IL_038a;
			case 15:
				if (iWhZXE4cPGoyD4MGt6TA(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BED794)))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 7;
			case 12:
				return;
			case 2:
				return;
			case 10:
				text2 = text2.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446ACDDA), "");
				text2 = text2.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2D80E5), "");
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 3;
				}
				break;
			case 6:
				text2 = vCNppNY9xh.vlP2kmioDGU;
				text2 = text2.Replace((string)jqdeOo4eKgiRI3O5pbjF(0x7ADBF691 ^ 0x7ADBBF45), "");
				text2 = (string)U5ppWi4cJQtmtw1FHla7(text2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198977928), "");
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num = 8;
				}
				break;
			case 9:
				{
					text = text.Replace((string)jqdeOo4eKgiRI3O5pbjF(-198991962 ^ -198974108), "").Trim();
					if (iWhZXE4cPGoyD4MGt6TA(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841475181)))
					{
						text = text.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878967796), vCNppNY9xh.DefaultTitle);
						goto case 5;
					}
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num = 0;
					}
					break;
				}
				IL_03bf:
				if (iWhZXE4cPGoyD4MGt6TA(text, jqdeOo4eKgiRI3O5pbjF(0x2BD86B18 ^ 0x2BD811E6)))
				{
					text = (string)U5ppWi4cJQtmtw1FHla7(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD5483E), base.Symbol.FormatPrice(rQY2NFIWrTj()));
				}
				if (!iWhZXE4cPGoyD4MGt6TA(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130F912D)))
				{
					goto case 16;
				}
				text3 = "";
				if (Akr2k2PGDPZ().HasValue)
				{
					num = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num = 7;
					}
					break;
				}
				goto IL_038a;
				IL_038a:
				text = (string)U5ppWi4cJQtmtw1FHla7(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D17F03), text3);
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num = 16;
				}
				break;
			}
		}
	}

	public override void SetCustomTitle(string P_0)
	{
		vCNppNY9xh.vlP2kmioDGU = P_0;
		vCNppNY9xh.zDi2k7CwL38 = !string.IsNullOrEmpty(P_0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		LbNpag6l2u();
	}

	private void ia0pi4t4GK()
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		((nbVNlXfPFDThbGYvhE91)b4dwIe4cpA3LGMuVd3I6(Market)).BfEfJ9AlsyZ().Clear();
		int num4 = 2;
		UserDeal current = default(UserDeal);
		while (true)
		{
			switch (num4)
			{
			case 1:
				return;
			case 4:
				Market.NeedRedraw();
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
				{
					num4 = 1;
				}
				break;
			case 3:
			{
				using (List<UserDeal>.Enumerator enumerator = h8uiRtfnRZ9JJpkepmSl.zJKfntsbo6Z(base.Symbol.CurrentSymbolID(), Account.AccountID).GetEnumerator())
				{
					while (true)
					{
						int num5;
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							if (!(oBmk744cuDo9GHZ2qFRN(current) > vCNppNY9xh.OYgzQQs1Bc))
							{
								goto IL_008f;
							}
							num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
							{
								num5 = 1;
							}
						}
						else
						{
							num5 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
							{
								num5 = 2;
							}
						}
						goto IL_004f;
						IL_004f:
						while (true)
						{
							switch (num5)
							{
							case 3:
								num += current.Points;
								num2 += current.Profit;
								num5 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_0187;
							case 2:
								goto end_IL_012b;
							}
							break;
						}
						((nbVNlXfPFDThbGYvhE91)b4dwIe4cpA3LGMuVd3I6(Market)).BfEfJ9AlsyZ().AddFirst(new EypMKqfJcHkrJccrH5P0
						{
							Quantity = current.MaxQuantity,
							Profit = current.Points,
							Side = current.Side
						});
						goto IL_008f;
						IL_008f:
						if (!(current.CloseTime > vCNppNY9xh.pZrzcDVmHI))
						{
							continue;
						}
						num5 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
						{
							num5 = 2;
						}
						goto IL_004f;
						IL_0187:
						num3 += current.Comission;
						continue;
						end_IL_012b:
						break;
					}
				}
				goto IL_01ec;
			}
			case 2:
				if (base.Symbol != null && Account != null)
				{
					int num6 = 3;
					num4 = num6;
					break;
				}
				goto IL_01ec;
			default:
				{
					iVhxbp4j2j30diMUsdra(Market.Info, num3);
					num4 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num4 = 2;
					}
					break;
				}
				IL_01ec:
				Ev435f4czPrQBjD4uZfg(Market.Info, num);
				DXXhGG4j0BUI78tgvucH(b4dwIe4cpA3LGMuVd3I6(Market), num2 - num3);
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
				{
					num4 = 0;
				}
				break;
			}
		}
	}

	private void ClearPnl()
	{
		int num = 2;
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
				Market.Info.WQSfJ0gvkG1(0.0);
				iVhxbp4j2j30diMUsdra(Market.Info, 0.0);
				vCNppNY9xh.pZrzcDVmHI = bkJMHD4jHQulfyeWMhu6(base.Symbol.Exchange);
				Market.NeedRedraw();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Market.Info.TotalPoints = 0.0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void ClearDeals()
	{
		AYRys04jf41kKtjRwTLe(Market.Info.BfEfJ9AlsyZ());
		vCNppNY9xh.OYgzQQs1Bc = bkJMHD4jHQulfyeWMhu6(base.Symbol.Exchange);
	}

	protected override void OnTick(Tick P_0)
	{
		Market.U63f1VCdb1A();
	}

	protected override void OnDom(MarketDepth P_0)
	{
		Market.U63f1VCdb1A();
	}

	protected override void OnSecurity(EventOwner<SecurityEvent> P_0)
	{
		Market.U63f1VCdb1A();
		if (vCNppNY9xh.MarketSettings.CurrentPrice == 0L)
		{
			OnEditLotExecute(vCNppNY9xh.MarketSettings);
			KYC2bzML06I();
		}
	}

	protected override void OnUserPosition(UserPosition P_0)
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = iry2NPTGQJC().fuulnktHjJ4(base.Symbol?.ID);
		if (ypqMIv9maFM0tRwF0xMh != null)
		{
			if (P_0.AccountID.StartsWith(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-837284864 ^ -837282832)))
			{
				goto IL_04c0;
			}
			goto IL_05fc;
		}
		int num = 10;
		goto IL_0009;
		IL_013c:
		int num2 = 12;
		goto IL_0005;
		IL_04c0:
		if (b2mcTw4j9qhfHfy7pINj(ypqMIv9maFM0tRwF0xMh.lEVl9w6fCd9()) == 0L)
		{
			num = 6;
			goto IL_0009;
		}
		goto IL_05fc;
		IL_05d3:
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0005:
		num = num2;
		goto IL_0009;
		IL_05fc:
		if (P_0.Size == 0L)
		{
			num2 = 13;
			goto IL_0005;
		}
		goto IL_05d3;
		IL_0009:
		int? num6 = default(int?);
		double num5 = default(double);
		double? num4 = default(double?);
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = default(ruI5XW2OJpKMlnG7xFDS);
		bool flag = default(bool);
		while (true)
		{
			double num3;
			double num7;
			switch (num)
			{
			case 16:
				break;
			case 10:
				return;
			case 8:
				num3 = num6.Value;
				goto IL_0749;
			case 9:
				goto IL_0135;
			case 14:
				goto IL_014a;
			case 3:
			case 17:
				goto IL_01b6;
			case 5:
				goto IL_02a7;
			case 13:
				P_0.LastSizeTriggeredStrategy = 0L;
				num = 11;
				continue;
			case 18:
				LogInfo((string)Dv7Ukw4jilHFWvinqEMK(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841470455), num5, coPfjK9hF3ASs5TbM8OK.LastSize, P_0.Size));
				goto IL_01b6;
			case 15:
			case 19:
				goto IL_043c;
			case 7:
				goto end_IL_0009;
			case 2:
				goto IL_0586;
			case 11:
				goto IL_05d3;
			case 6:
				return;
			case 12:
				goto IL_0615;
			case 4:
				goto IL_063b;
			case 1:
				goto IL_0686;
			default:
				{
					num3 = num4.Value;
					goto IL_0749;
				}
				IL_0749:
				num7 = num3;
				nsoV3Q4XrKobQhDggRF6(this, string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45455341), num7, EcsQdW4jBHetbODhJZYx(coPfjK9hF3ASs5TbM8OK), P_0.Size));
				num = 14;
				continue;
			}
			goto IL_00bb;
			IL_0686:
			ruI5XW2OJpKMlnG7xFDS = MarketTraderControl.ViewModel.SelectedStrategy?.JgL2WdI2A3a();
			if (P_0.Size != 0L && wsEEKs4jnPF00xBfc0PO(P_0) != PNDWlW4jGIfR6jUrnds2(P_0))
			{
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num = 1;
				}
				continue;
			}
			goto IL_05a4;
			IL_0586:
			if (!j18iDj9nukSCmEyZs5lH.Settings.DynamicSlTp)
			{
				if (j18iDj9nukSCmEyZs5lH.Settings.DynamicSlTp)
				{
					num = 19;
					continue;
				}
				goto IL_063b;
			}
			goto IL_06b9;
			IL_0135:
			if (ruI5XW2OJpKMlnG7xFDS == null)
			{
				goto IL_00bb;
			}
			goto IL_013c;
			IL_05a4:
			coPfjK9hF3ASs5TbM8OK.LastSize = P_0.Size;
			Market.NeedRedraw();
			return;
			IL_02a7:
			if (coPfjK9hF3ASs5TbM8OK.IH09wlBiQOi(ypqMIv9maFM0tRwF0xMh, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).TakeProfitSize, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.TakeProfitPercentSize, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitRange, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitPercentRange, flag, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitOffset, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitPercentOffset, vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq))
			{
				if (!flag)
				{
					num6 = ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).TakeProfitSize;
					num = 8;
					continue;
				}
				num4 = vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitPercentSize;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_014a;
			IL_063b:
			if (P_0.LastSizeTriggeredStrategy != 0L)
			{
				num = 15;
				continue;
			}
			goto IL_06b9;
			IL_00bb:
			if (!DJlxUX4jvAmo8PHjK33x(coPfjK9hF3ASs5TbM8OK))
			{
				flag = ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).TakeProfitValueType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq;
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_014a;
			IL_0615:
			if (!ruI5XW2OJpKMlnG7xFDS.z9l2O3qrToV())
			{
				if (QyMuIv4jY0OJRXSRqmlc(P_0.Size) >= Math.Abs(PNDWlW4jGIfR6jUrnds2(P_0)))
				{
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
					{
						num = 2;
					}
					continue;
				}
				goto IL_043c;
			}
			num = 16;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
			{
				num = 5;
			}
			continue;
			IL_043c:
			if (Math.Sign(P_0.Size) == Math.Sign(PNDWlW4jGIfR6jUrnds2(P_0)))
			{
				goto IL_00bb;
			}
			goto IL_06b9;
			IL_01b6:
			k7gTls4jlbOijlAFPebu(P_0, P_0.Size);
			goto IL_05a4;
			IL_06b9:
			object format = jqdeOo4eKgiRI3O5pbjF(-1461292091 ^ -1461319465);
			H2WxiZ9mljPsQ9ncZgPc h2WxiZ9mljPsQ9ncZgPc = iry2NPTGQJC();
			int? num8;
			if (h2WxiZ9mljPsQ9ncZgPc == null)
			{
				num6 = null;
				num8 = num6;
			}
			else
			{
				num8 = h2WxiZ9mljPsQ9ncZgPc.UJElnHayjot;
			}
			LogInfo((string)MVOnRc4XsbZHIA7lNf1c(string.Format((string)format, num8), string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x70653A95), F0CtXt4jooWFf50ScbqA(ruI5XW2OJpKMlnG7xFDS), coPfjK9hF3ASs5TbM8OK.LastSize, wsEEKs4jnPF00xBfc0PO(P_0))));
			coPfjK9hF3ASs5TbM8OK.fQm9w98FDov(ypqMIv9maFM0tRwF0xMh, ruI5XW2OJpKMlnG7xFDS, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitOffset, vCNppNY9xh.MarketSettings.TradeSettings.TakeProfitPercentOffset, vCNppNY9xh.MarketSettings.TradeSettings.StopLossOffset, vCNppNY9xh.MarketSettings.TradeSettings.StopLossPercentOffset, vCNppNY9xh.MarketSettings.TradeSettings.OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num = 17;
			}
			continue;
			IL_014a:
			if (coPfjK9hF3ASs5TbM8OK.MLM9wsnZGqb())
			{
				num = 3;
				continue;
			}
			bool flag2 = dRXjVu4jatKQWxi9vEPl(vCNppNY9xh.MarketSettings.TradeSettings) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq;
			if (coPfjK9hF3ASs5TbM8OK.FKk9wnu6Wwq(ypqMIv9maFM0tRwF0xMh, vCNppNY9xh.MarketSettings.TradeSettings.StopLossSize, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.StopLossPercentSize, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.StopLossRange, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.StopLossPercentRange, flag2, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).StopLossOffset, vCNppNY9xh.MarketSettings.TradeSettings.StopLossPercentOffset, BLiFEZ4XEkbwpFd6IDK7(vCNppNY9xh.MarketSettings.TradeSettings) == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq))
			{
				double num9;
				if (!flag2)
				{
					num6 = vCNppNY9xh.MarketSettings.TradeSettings.StopLossSize;
					num9 = num6.Value;
				}
				else
				{
					num4 = vCNppNY9xh.MarketSettings.TradeSettings.StopLossPercentSize;
					num9 = num4.Value;
				}
				num5 = num9;
				num = 18;
				continue;
			}
			goto IL_01b6;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_04c0;
	}

	private void RurplLiLyI()
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = iry2NPTGQJC().fuulnktHjJ4(base.Symbol?.ID);
		if (ypqMIv9maFM0tRwF0xMh == null)
		{
			return;
		}
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position;
		if (XgES7F4sji2NgFe7Jiym(coPfjK9hF3ASs5TbM8OK) == 0L)
		{
			return;
		}
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = ((z48ObB20gSriKUfj18p3)RnOuMX4sv3RIEKu8ZLfg(MarketTraderControl)).SelectedStrategy?.JgL2WdI2A3a();
		int num;
		if (ruI5XW2OJpKMlnG7xFDS != null)
		{
			if (ruI5XW2OJpKMlnG7xFDS.z9l2O3qrToV())
			{
				nsoV3Q4XrKobQhDggRF6(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BED058));
				coPfjK9hF3ASs5TbM8OK.ClearExitStrategy();
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 3;
				}
			}
			else
			{
				num = 2;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
			{
				num = 1;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				LogInfo(string.Format((string)jqdeOo4eKgiRI3O5pbjF(0x684F243E ^ 0x684F58F0), coPfjK9hF3ASs5TbM8OK.PositionSize));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num = 0;
				}
				break;
			case 3:
			case 5:
				Market.NeedRedraw();
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				break;
			default:
				coPfjK9hF3ASs5TbM8OK.fQm9w98FDov(ypqMIv9maFM0tRwF0xMh, ruI5XW2OJpKMlnG7xFDS, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.TakeProfitOffset, ((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings.TakeProfitPercentOffset, vCNppNY9xh.MarketSettings.TradeSettings.StopLossOffset, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).StopLossPercentOffset, ((CR1isWfDCD1A4fwfUJUf)aK4F9v4XjAHE5GKtkIaL(vCNppNY9xh.MarketSettings)).OffsetsType == MOWYtTHiJiOZMqTggitO.do2Hi3HlkDq);
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
				{
					num = 5;
				}
				break;
			case 4:
				return;
			case 1:
				return;
			}
		}
	}

	protected override void OnUserDeal(UserDeal P_0)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (P_0 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
				case 3:
					Market.NeedRedraw();
					return;
				}
				break;
			}
			LinkedList<EypMKqfJcHkrJccrH5P0> linkedList = ((nbVNlXfPFDThbGYvhE91)b4dwIe4cpA3LGMuVd3I6(Market)).BfEfJ9AlsyZ();
			EypMKqfJcHkrJccrH5P0 obj = new EypMKqfJcHkrJccrH5P0
			{
				Quantity = irw2Mp4j4jB3NDRfg0jP(P_0)
			};
			h8a9L14jbMCiT4EfosqX(obj, HYHyYC4jDwd9br9x5Jwf(P_0));
			obj.Side = wJ0MIJ4jNd5xQIkrIqIA(P_0);
			linkedList.AddFirst(obj);
			nbVNlXfPFDThbGYvhE91 nbVNlXfPFDThbGYvhE = Market.Info;
			Ev435f4czPrQBjD4uZfg(nbVNlXfPFDThbGYvhE, u4oTr34jkLEtXBbhHyAn(nbVNlXfPFDThbGYvhE) + P_0.Points);
			nbVNlXfPFDThbGYvhE91 nbVNlXfPFDThbGYvhE2 = Market.Info;
			nbVNlXfPFDThbGYvhE2.WQSfJ0gvkG1(nbVNlXfPFDThbGYvhE2.ndvfPzC7tMR() + (P_0.Profit - P_0.Comission));
			Market.Info.Comission += P_0.Comission;
			num = 3;
		}
	}

	protected override void OnOrder(Order P_0)
	{
		Market.NeedRedraw();
	}

	protected override void OnInitStopLoss()
	{
		MHYxMv4j1OfR1VwDfkif(Market);
	}

	protected override void OnInitTakeProfit()
	{
		Market.J4nfS268g6l();
	}

	private void UCGp42nmeT()
	{
		MjUJTC2nvtuDik3h4XKo.xgs2nNtygWa(base.ParentWindow, zBI2Sjoyuyr(), vCNppNY9xh.MarketSettings.Theme, ApplyTheme);
	}

	private void ApplyTheme(brG9LqfO0TVwbKGahwYo theme, bool global)
	{
		if (!global)
		{
			vCNppNY9xh.MarketSettings.Theme.NecfOHpeQu4(theme);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
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
			jnwdik4j53v9Lg0FijIF((BlmlL92DciZPrtYF1X4r)4, theme);
		}
	}

	private void Vr9pDYMFrh()
	{
		xtFZfM4sNxeg1p59a6So(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
		Market.NeedRedraw(_0020: true);
	}

	private void HlxpbD6F0A(bool P_0, zUNI16202mQmpx9T2Hxb.UJajCjnQr63UFbiRQ2if P_1 = (zUNI16202mQmpx9T2Hxb.UJajCjnQr63UFbiRQ2if)0)
	{
		int num;
		if (P_0 && (base.RenderSize.Width < 500.0 || base.RenderSize.Height < 500.0) && TradeSettingsExpander.Visibility != Visibility.Visible)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
			{
				num = 0;
			}
		}
		else
		{
			vCNppNY9xh.ShowTradeSettings = true;
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Market.Focus();
				return;
			case 5:
				TradeSettingsExpander.IsExpanded = P_0;
				return;
			default:
			{
				Y43KBu2nt2tdxWysSevH obj = new Y43KBu2nt2tdxWysSevH
				{
					Owner = base.ParentWindow,
					TradeSettingsControl = 
					{
						MarketSettings = (MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)
					}
				};
				v7ZNtE4jSpBthQRPPCSl(obj.TradeSettingsControl, P_1);
				obj.TradeSettingsControl.jXC20GxSneC();
				LMOBEg4jx0SjjnJkN1Aq((NCopbS2n6A8BFZsh7eNY)2);
				obj.ShowDialog();
				num = 3;
				break;
			}
			case 4:
				kUeiO14jsdTFdJD5MU5B(fKJvdU4jeDlmIhQ9ueic(MarketSettingsPanel), TradeSettingsControl);
				goto IL_003a;
			case 2:
				bOqnkh4jLY7vkSxM65ZK(TradeSettingsControl, vCNppNY9xh.MarketSettings);
				num = 6;
				break;
			case 3:
				U88pz84cOT = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num = 1;
				}
				break;
			case 6:
				{
					v7ZNtE4jSpBthQRPPCSl(TradeSettingsControl, P_1);
					if (!MarketSettingsPanel.Children.OfType<zUNI16202mQmpx9T2Hxb>().Any())
					{
						num = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
						{
							num = 0;
						}
						break;
					}
					goto IL_003a;
				}
				IL_003a:
				TradeSettingsExpander.Visibility = Visibility.Visible;
				num = 5;
				break;
			}
		}
	}

	private void kK9pNBbQjf()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vCNppNY9xh.ShowTradeSettings = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				TradeSettingsExpander.Visibility = Visibility.Collapsed;
				dsv36H4jXsp2T2WB04Vt(TradeSettingsExpander, false);
				Market.Focus();
				return;
			}
		}
	}

	private void iMypk0BvQ7(object P_0, RoutedEventArgs P_1)
	{
		kK9pNBbQjf();
	}

	private void nVyp1OM2av(object P_0, RoutedEventArgs P_1)
	{
		OpenInstrumentChart();
	}

	private void OpenInstrumentChart()
	{
		MainWindow mainWindow = ((hNXfXl9U6G1YI9MQ7eq)EeJ2CJ4jclox9sINeGDj()).MainWindow;
		DocumentWindow documentWindow = mainWindow.NewWindow(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BD86116), base.DockSite);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
		{
			num = 1;
		}
		DBmQUM2XiyOP3m87eGbR dBmQUM2XiyOP3m87eGbR = default(DBmQUM2XiyOP3m87eGbR);
		while (true)
		{
			switch (num)
			{
			default:
				dBmQUM2XiyOP3m87eGbR.riG2XmDFJ0S(new DataCycle(DataCycleBase.Minute, 5), null);
				dBmQUM2XiyOP3m87eGbR.SetSymbol(base.Symbol);
				num = 3;
				break;
			case 1:
				if (documentWindow == null)
				{
					return;
				}
				dBmQUM2XiyOP3m87eGbR = pL10YF4jjqDLhdFyX4V7(documentWindow) as DBmQUM2XiyOP3m87eGbR;
				if (dBmQUM2XiyOP3m87eGbR != null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				documentWindow.Float(new Size(800.0, 600.0));
				mainWindow.SetTitle(documentWindow);
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void cfbp5PoFxy(object P_0, RoutedEventArgs P_1)
	{
		TradeSettingsControl.VDC20YJUhms();
	}

	private void ePdpSjA6lL(object P_0, RoutedEventArgs P_1)
	{
		TradeSettingsControl.jXC20GxSneC();
	}

	public void t8Ypx81Ftn(string P_0)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0);
		int num2;
		if (num <= 1838173794)
		{
			if (num > 914524308)
			{
				if (num <= 1266317451)
				{
					if (num == 1161660398)
					{
						if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161612846))
						{
							vCNppNY9xh.MarketSettings.PanelShowTotalPoints = !waxiyl4jdyIToQNVEDCe(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
						}
					}
					else
					{
						if (num == 1204531090)
						{
							goto IL_014d;
						}
						if (num == 1266317451)
						{
							goto IL_0229;
						}
					}
				}
				else
				{
					if (num == 1325532356)
					{
						if (!PiRdLU4eP6bfF2V9Ch3L(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842070589)))
						{
							num2 = 43;
							goto IL_0009;
						}
						goto IL_0b36;
					}
					if (num == 1462740399)
					{
						goto IL_03d8;
					}
					if (num == 1838173794)
					{
						goto IL_032e;
					}
				}
				goto IL_0654;
			}
			num2 = 5;
		}
		else
		{
			if (num > 2715640210u)
			{
				goto IL_09f7;
			}
			if (num > 2061495720)
			{
				if (num == 2100425008)
				{
					if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C794DE)))
					{
						goto IL_0654;
					}
					goto IL_0d17;
				}
				if (num == 2259858004u)
				{
					goto IL_0bea;
				}
				if (num == 2715640210u)
				{
					goto IL_0789;
				}
				num2 = 19;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 25;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num2 = 16;
				}
			}
		}
		goto IL_0009;
		IL_0654:
		Market.NeedRedraw(_0020: true);
		return;
		IL_07be:
		PopupButton.ClosePopupCommand.Execute(null, null);
		num2 = 48;
		goto IL_0009;
		IL_09f7:
		if (num > 3278710309u)
		{
			if (num != 3630834884u)
			{
				num2 = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
				{
					num2 = 11;
				}
				goto IL_0009;
			}
			goto IL_0a68;
		}
		int num3;
		if (num != 2792084858u)
		{
			num3 = 51;
			goto IL_0005;
		}
		goto IL_05d2;
		IL_03d8:
		if (!PiRdLU4eP6bfF2V9Ch3L(P_0, jqdeOo4eKgiRI3O5pbjF(-44540535 ^ -44556253)))
		{
			goto IL_0654;
		}
		num2 = 32;
		goto IL_0009;
		IL_0229:
		if (!PiRdLU4eP6bfF2V9Ch3L(P_0, jqdeOo4eKgiRI3O5pbjF(0x16AD7E76 ^ 0x16AD51DC)))
		{
			goto IL_0654;
		}
		goto IL_0ac3;
		IL_0789:
		if (!PiRdLU4eP6bfF2V9Ch3L(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC9B4AF)))
		{
			num2 = 58;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
			{
				num2 = 34;
			}
		}
		else
		{
			Sq86h64jRBaUoHQqs4gH(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), !p8mD9E4jguUeew39RlhQ(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)));
			num2 = 20;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
			{
				num2 = 28;
			}
		}
		goto IL_0009;
		IL_032e:
		if (PiRdLU4eP6bfF2V9Ch3L(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F0D37)))
		{
			num2 = 57;
			goto IL_0009;
		}
		goto IL_0654;
		IL_0b18:
		num3 = 44;
		goto IL_0005;
		IL_0a68:
		if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181365952)))
		{
			goto IL_0654;
		}
		goto IL_07be;
		IL_0ac3:
		((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).GraphShowBidOfferBalance = !vCNppNY9xh.MarketSettings.GraphShowBidOfferBalance;
		goto IL_0654;
		IL_014d:
		if (P_0 == (string)jqdeOo4eKgiRI3O5pbjF(-490987856 ^ -490970232))
		{
			num2 = 20;
			goto IL_0009;
		}
		goto IL_0654;
		IL_0665:
		InVTxi4jEwbmMK7NuNSV(PopupButton.ClosePopupCommand, null, null);
		num2 = 10;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
		{
			num2 = 30;
		}
		goto IL_0009;
		IL_0bea:
		if (P_0 == (string)jqdeOo4eKgiRI3O5pbjF(0x3544E813 ^ 0x354495ED))
		{
			Vfr7G04j66YXbySN7ed3(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh), !vCNppNY9xh.MarketSettings.PanelShowDeals);
			goto IL_0654;
		}
		num2 = 59;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
		{
			num2 = 7;
		}
		goto IL_0009;
		IL_0d35:
		if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127440554)))
		{
			goto IL_0654;
		}
		num3 = 40;
		goto IL_0005;
		IL_0b36:
		rqXt2r4jq1s6LPvGAE15(Market.EditViewOpenCommand, null);
		vCNppNY9xh.IsExtendedLotsInDOMShowed = true;
		goto IL_0654;
		IL_0005:
		num2 = num3;
		goto IL_0009;
		IL_0d17:
		HlxpbD6F0A(_0020: true, (zUNI16202mQmpx9T2Hxb.UJajCjnQr63UFbiRQ2if)1);
		goto IL_0654;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 30:
				StopLoss();
				goto IL_0654;
			case 35:
				break;
			case 6:
				goto IL_0229;
			case 50:
			case 57:
				HlxpbD6F0A(_0020: true);
				goto IL_0654;
			case 46:
				goto IL_032e;
			case 53:
				ClearPnl();
				goto IL_0654;
			case 3:
				pvFp6ilE78(null);
				goto IL_0654;
			case 51:
				if (num != 3046197644u)
				{
					num2 = 47;
					continue;
				}
				goto case 45;
			case 38:
				goto IL_03d8;
			case 20:
				qRUNhyHDDQmkuIovYJo1.M9QHDSa5bDu(new IwHSujHfgQ5ID4wOQN5X(ysBJuVHH3iwGVb253LJm.qKIHHzlmlOx())
				{
					Owner = base.ParentWindow
				}, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198975318) + zBI2Sjoyuyr());
				num2 = 31;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
				{
					num2 = 19;
				}
				continue;
			case 40:
			case 56:
				HlxpbD6F0A(_0020: true);
				goto IL_0654;
			case 45:
				if (!PiRdLU4eP6bfF2V9Ch3L(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3301E98B)))
				{
					num2 = 36;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 53;
			case 33:
				goto IL_0588;
			case 47:
				if (num != 3278710309u)
				{
					goto IL_0654;
				}
				goto case 26;
			case 10:
				goto IL_05d2;
			case 1:
			case 12:
			case 14:
			case 16:
			case 17:
			case 19:
			case 23:
			case 27:
			case 28:
			case 29:
			case 31:
			case 36:
			case 39:
			case 41:
			case 43:
			case 44:
			case 49:
			case 55:
			case 58:
			case 59:
				goto IL_0654;
			case 52:
				goto IL_0665;
			case 9:
				if (num == 312977878)
				{
					if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC9E20F))
					{
						goto case 3;
					}
					goto IL_0654;
				}
				num2 = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num2 = 29;
				}
				continue;
			case 4:
			case 37:
				u4QkNS4jONiGbwfp3g8D(vCNppNY9xh.MarketSettings, !XdxQMW4jMCSQne51rKHl(vCNppNY9xh.MarketSettings));
				goto IL_0654;
			case 22:
				goto IL_0732;
			case 8:
				goto IL_0789;
			case 11:
				goto IL_07be;
			case 25:
				goto IL_0824;
			case 54:
				goto IL_09f7;
			case 5:
				goto IL_0a08;
			case 21:
				goto IL_0a68;
			default:
				goto IL_0ac3;
			case 24:
				if (num == 3997072569u && PiRdLU4eP6bfF2V9Ch3L(P_0, jqdeOo4eKgiRI3O5pbjF(-3429745 ^ -3419005)))
				{
					ClearDeals();
				}
				goto IL_0654;
			case 26:
				if (P_0 == (string)jqdeOo4eKgiRI3O5pbjF(-1309555870 ^ -1309557074))
				{
					vCNppNY9xh.ShowMarketTrader = !vCNppNY9xh.ShowMarketTrader;
					ggWcNb4jQffl6IBVfB1V(MarketTraderControl.ViewModel, vCNppNY9xh.ShowMarketTrader);
					num2 = 49;
					continue;
				}
				goto IL_0b18;
			case 32:
				UCGp42nmeT();
				num2 = 16;
				continue;
			case 34:
				goto IL_0b36;
			case 48:
				TakeProfit();
				num2 = 27;
				continue;
			case 42:
				goto IL_0b99;
			case 2:
				goto IL_0bea;
			case 13:
				goto IL_0c4c;
			case 7:
				goto IL_0cd1;
			case 18:
				goto IL_0d17;
			case 15:
				goto IL_0d35;
			}
			break;
			IL_0cd1:
			if (num == 740138773)
			{
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DEDA9F)))
				{
					goto IL_0654;
				}
				num2 = 37;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num2 = 24;
				}
				continue;
			}
			num2 = 22;
			continue;
			IL_0824:
			if (num == 2048954422)
			{
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x12627C8A)))
				{
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num2 = 14;
					}
					continue;
				}
				goto IL_0b99;
			}
			if (num != 2061495720)
			{
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			goto IL_0d35;
			IL_0b99:
			vCNppNY9xh.IsLotsInDOMShowed = false;
			num2 = 23;
			continue;
			IL_0a08:
			if (num > 312977878)
			{
				if (num != 666033858)
				{
					num2 = 7;
					continue;
				}
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153234039))
				{
					goto IL_0588;
				}
			}
			else
			{
				if (num != 137864150)
				{
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x4662EA8F))
				{
					HlxpbD6F0A(_0020: true);
				}
			}
			goto IL_0654;
			IL_0732:
			if (num != 914524308)
			{
				num2 = 17;
				continue;
			}
			if (PiRdLU4eP6bfF2V9Ch3L(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673703659)))
			{
				RkX2S0jhpO3();
				num2 = 12;
				continue;
			}
			num2 = 41;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
			{
				num2 = 21;
			}
			continue;
			IL_0c4c:
			if (num == 3881513226u)
			{
				if (PiRdLU4eP6bfF2V9Ch3L(P_0, jqdeOo4eKgiRI3O5pbjF(-1161619942 ^ -1161598838)))
				{
					IGMpR7B8Hl(null);
				}
				goto IL_0654;
			}
			num2 = 24;
			continue;
			IL_0588:
			xAs2SB8odxC();
			goto IL_0654;
		}
		goto IL_014d;
		IL_05d2:
		if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD5C5DD)))
		{
			goto IL_0654;
		}
		goto IL_0665;
	}

	protected override void ResetSymbol()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Market.ResetSymbol();
				vCNppNY9xh.MarketSettings.ResetVisibleSettings();
				e1H7t04jIleV8cUvb6Er(vCNppNY9xh, string.Empty);
				ggWcNb4jQffl6IBVfB1V(MarketTraderControl.ViewModel, false);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.ResetSymbol();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				base.Leverage = 1.0;
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				base.CurrencyFreeMargin = -1.0;
				Serialize();
				return;
			}
		}
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		oMfCmB4jWVETZ7NuqmAR(base.DocLinkContext, isActiveWindow);
		SsS253ZUwy8(groupID);
	}

	private void SymbolSearchControl_SymbolSelected(Symbol symbol)
	{
		PopupButton.ClosePopupCommand.Execute(null, null);
		PopupSelectSymbols.IsOpen = false;
		TQ525pb1OP3(symbol);
		Market.Focus();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void PeriodSelectControl_PeriodChanged(DataCycle dataCycle)
	{
		((RoutedCommand)lXvrhW4jtChhi4kXU4Cg()).Execute((object)null, (IInputElement)null);
		vCNppNY9xh.MarketSettings.DataCycle = dataCycle;
	}

	protected override void SetPeriod(DataCycle P_0)
	{
		P_0.StartDate = ViewModel.DataCycle.StartDate;
		P_0.EndDate = ((DataCycle)mJY8uy4jUWfg71WqNG5b(ViewModel)).EndDate;
		FxBT6D4jT4w3qqWcN6IW(vCNppNY9xh.MarketSettings, P_0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void JhtpL3N4Dx()
	{
		oCf3AiCgJK(new BAEtAp2DUfuBKyaAJXwQ((BlmlL92DciZPrtYF1X4r)7));
	}

	public void TkYpeAHLV1(DataCycle P_0)
	{
		P_0.DataType = DataCycleDataType.Clusters;
		ViewModel.DataCycle = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 1:
			return;
		}
		iry2NPTGQJC().wZ69mscyCxE(new DataCycle(P_0), _0020: false);
		LbNpag6l2u();
		try
		{
			if (!JR62S6js1Bp() || base.Symbol == null)
			{
				return;
			}
			while (eBW2SW89kvb())
			{
				W1SF6s21AP43c8EaVVZK.rfh25fHlPPj((string)K4rbUK4jyKGNfgXXxwmx(base.Symbol), P_0);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
			}
		}
		catch
		{
		}
	}

	public void vx9pscng8q(int P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pX4tsO4skLEHT349Bvt9(vCNppNY9xh.MarketSettings, P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			ViewModel.DataScale = P_0;
			iry2NPTGQJC().UJElnHayjot = P_0;
			H2WxiZ9mljPsQ9ncZgPc h2WxiZ9mljPsQ9ncZgPc = iry2NPTGQJC();
			Symbol symbol = base.Symbol;
			h2WxiZ9mljPsQ9ncZgPc.LEU9mIyUslf((string)((symbol != null) ? iXT0vW4jZbiSwBk8NXWN(symbol) : null), x612kgVpoMx);
			Hru2Na5NVdK();
			try
			{
				if (!JR62S6js1Bp() || base.Symbol == null)
				{
					return;
				}
				int num3;
				if (!eBW2SW89kvb())
				{
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num3 = 0;
					}
					goto IL_0084;
				}
				goto IL_00f2;
				IL_0084:
				switch (num3)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					break;
				case 1:
					return;
				}
				goto IL_00f2;
				IL_00f2:
				YnpFWR4jVWA7xAtEyBTd(K4rbUK4jyKGNfgXXxwmx(base.Symbol), P_0);
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num3 = 1;
				}
				goto IL_0084;
			}
			catch
			{
				return;
			}
		}
	}

	private void HL6pXLd6eL()
	{
		if (vCNppNY9xh.MarketSettings.DataScale == RjdSdX4jClY2jJhA9cyQ(ViewModel) && iry2NPTGQJC().UJElnHayjot == ViewModel.DataScale)
		{
			return;
		}
		pX4tsO4skLEHT349Bvt9(vCNppNY9xh.MarketSettings, ViewModel.DataScale);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
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
				iry2NPTGQJC().UJElnHayjot = ViewModel.DataScale;
				iry2NPTGQJC().LEU9mIyUslf(base.Symbol?.ID, x612kgVpoMx);
				Hru2Na5NVdK();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void WlopccISKL(int P_0)
	{
		if (P_0 > 0)
		{
			ViewModel.anUuD1ujYc();
		}
		else
		{
			while (true)
			{
				int num;
				if (P_0 < 0)
				{
					k3yoSS4jriO88Z0LtVlQ(ViewModel);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 2;
				}
				switch (num)
				{
				case 1:
					continue;
				}
				break;
			}
		}
		HL6pXLd6eL();
	}

	private void fRrpjTwXHG(int P_0)
	{
		PNG2N7687nr(vCNppNY9xh.MarketSettings, P_0);
	}

	private void tWfpEpuvJe(object P_0, MouseButtonEventArgs P_1)
	{
		ViewModel.Settings.MarketSettings.ScaleValue = 0;
	}

	protected override void OnClearMarket()
	{
		slkCx24jKlttIPxl5MUt(Market);
	}

	private void YZMpQQQfhC()
	{
		if (Market.axFf1ARQQOr().OltfAW7OUUJ() == null)
		{
			if (pOPDS14jm5r3rXFkJTud(NGeY8B4sAgBvsRIicJ2n(Market)) == null)
			{
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 2:
					break;
				case 1:
					goto IL_0068;
				default:
					goto IL_00d8;
				}
			}
			pQhLrt4jwa5KDry9bWSt(Market);
			goto IL_00a7;
		}
		goto IL_00d8;
		IL_00d8:
		XUTBHi4j7Yid15g2Zn17(Market);
		goto IL_00a7;
		IL_0068:
		uAErvr4jhWe99GaOJV02(Market);
		goto IL_00a7;
		IL_00a7:
		Market.NeedRedraw(_0020: true);
	}

	private void KgSpdMaHHh()
	{
		int num;
		if (RrRhCG4j82KPIVD3PMpq(Market.Smtf170DVgj()) != null)
		{
			Market.dQZfSBQVPfu();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0096;
		IL_0009:
		switch (num)
		{
		default:
			Market.NeedRedraw(_0020: true);
			return;
		case 3:
			break;
		}
		goto IL_0096;
		IL_0096:
		if (Market.Smtf170DVgj().BojfATVS0J1() != null)
		{
			Market.ixIfSYPVmwr();
			num = 2;
		}
		else
		{
			Market.lwwfS9qL45i();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 1;
			}
		}
		goto IL_0009;
	}

	private void OsDpgtnvsV()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Market.NeedRedraw(_0020: true);
				return;
			case 3:
				if (((G2gR30fAanPKf0TTFLoc)hnBgW84jACdAHgHqE8mx(Market)).OltfAW7OUUJ() != null)
				{
					Market.fxLfSvPCdht();
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
					{
						num2 = 2;
					}
				}
				break;
			case 2:
				if (Market.iJaf1hBN7vk().BojfATVS0J1() != null)
				{
					yl0A6q4jJKtR3kTQ3WsD(Market);
					goto default;
				}
				OBhVcR4jPPFNauE7J4qD(Market);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void IGMpR7B8Hl(BpmEftf7wYbuVebk5Vku P_0)
	{
		if (base.Symbol == null)
		{
			return;
		}
		int num;
		if (!(P_0 is tQdY3yfPR6B0dxodinwZ))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0089;
		IL_0089:
		vCNppNY9xh.MarketSettings.SignalLevels.Ia0fPf3Ad95(base.Symbol.ID, Market.cDAf1tTHAUJ(base.Symbol));
		num = 2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				DOqwN32flQmmhZv1KMOS.FdY2fDIpJJ1(base.ParentWindow, vCNppNY9xh.MarketSettings, base.Symbol, dAgpOZse8c, P_0);
				return;
			case 3:
				break;
			default:
				if (P_0 is cHDH2xfPlID4okPS4Qpr)
				{
					pet1XG4jFZNTihYyqmjW(base.ParentWindow);
					return;
				}
				vCNppNY9xh.MarketSettings.Levels.Ia0fPf3Ad95(base.Symbol.ID, Market.YsJf1WZHLW7(base.Symbol));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num = 1;
				}
				continue;
			case 1:
				pa3iON2fqVc4ICxK2fCG.up32fW8gi8s(base.ParentWindow, vCNppNY9xh.MarketSettings, base.Symbol, NjbpMh2XWm, P_0);
				return;
			}
			break;
		}
		goto IL_0089;
	}

	private void pvFp6ilE78(BpmEftf7wYbuVebk5Vku P_0)
	{
		if (base.Symbol != null)
		{
			vCNppNY9xh.MarketSettings.SignalLevels.Ia0fPf3Ad95(base.Symbol.ID, Market.cDAf1tTHAUJ(base.Symbol));
			CE7iwT4j3utKnPyV9OC7(base.ParentWindow, vCNppNY9xh.MarketSettings, base.Symbol, new DOqwN32flQmmhZv1KMOS.ak4J8wnda0d955a2HliP(dAgpOZse8c), P_0);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
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

	private void NjbpMh2XWm()
	{
		if (base.Symbol != null)
		{
			Market.fOQf1MepYBE(base.Symbol, vCNppNY9xh.MarketSettings.Levels.IDQfPHZll5G(base.Symbol.ID));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
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
			Market.fOQf1MepYBE(null, new List<BpmEftf7wYbuVebk5Vku>());
		}
	}

	private void dAgpOZse8c()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Market.Xngf1Oy3n6d(base.Symbol, vCNppNY9xh.MarketSettings.SignalLevels.IDQfPHZll5G(base.Symbol.ID));
				return;
			case 1:
				if (base.Symbol == null)
				{
					Market.Xngf1Oy3n6d(null, new List<BpmEftf7wYbuVebk5Vku>());
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void eGIpqjwrs4()
	{
		if (base.Symbol != null)
		{
			List<BpmEftf7wYbuVebk5Vku> list = c8EcTUfGEuMy2llFqsdF.c29fGRFIai9(base.Symbol).Select((Func<E5ZRLJfvK5UFeYCuZIcl, BpmEftf7wYbuVebk5Vku>)((E5ZRLJfvK5UFeYCuZIcl P_0) => new cHDH2xfPlID4okPS4Qpr(P_0, base.Symbol.Step, imd4wW4ES9pZkDPtCZLl(base.Symbol)))).ToList();
			Market.e4Bf1qSXWsC(base.Symbol, list);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
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

	private void Q81pInvAn5(BpmEftf7wYbuVebk5Vku P_0)
	{
		IGMpR7B8Hl(P_0);
	}

	public void BMvpWdGLa4(int? P_0)
	{
		if (P_0.HasValue)
		{
			if (ViewModel == null)
			{
				vCNppNY9xh.MarketSettings.DataScale = P_0.Value;
			}
			else
			{
				vx9pscng8q(P_0.Value);
			}
		}
	}

	public void qtZpt5cDHs(DataCycle P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (P_0 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (ViewModel != null)
				{
					TkYpeAHLV1(new DataCycle(P_0));
				}
				else
				{
					FxBT6D4jT4w3qqWcN6IW(vCNppNY9xh.MarketSettings, new DataCycle(P_0));
				}
				return;
			case 0:
				return;
			}
		}
	}

	private void WhQpUxoLct()
	{
		U88pz84cOT = true;
	}

	private void WnJpTqy152(object P_0, KeyEventArgs P_1)
	{
		if (P_1.Key != Key.Return)
		{
			return;
		}
		RoutedCommand closePopupCommand = PopupButton.ClosePopupCommand;
		if (closePopupCommand != null && wnl7WB4jpiT8wEuXuXpy(closePopupCommand, null, null))
		{
			InVTxi4jEwbmMK7NuNSV(lXvrhW4jtChhi4kXU4Cg(), null, null);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
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

	private void aMFpy6qcNJ(object P_0, EventArgs P_1)
	{
		HL6pXLd6eL();
	}

	private void ToolbarItemOrderSize_OnPopupOpening(object sender, RoutedEventArgs e)
	{
		OnEditLotExecute((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh));
		Market.juif1L9ghbr();
	}

	private void RCLpZay43t(int P_0)
	{
		((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).ClusterSettings.ClusterWidth += P_0;
	}

	protected override void OpenSymbolsPopup()
	{
		ViewModel.g2IuNeC9Ga();
		int num;
		if (ysBJuVHH3iwGVb253LJm.qKIHHzlmlOx().YEiHfjvLIKV(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176524697)) && j18iDj9nukSCmEyZs5lH.Settings.IsDomToolBarsVisible)
		{
			ViewModel.IsSymbolsPopupOpen = true;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
			{
				num = 1;
			}
		}
		else
		{
			C5LgZa4juPDCeQYqxRFX(PopupSelectSymbols, true);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
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

	private void GBgpV8dYrK(object P_0, KeyEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_1.Key == Key.Escape)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				C5LgZa4juPDCeQYqxRFX(PopupSelectSymbols, false);
				Market.Focus();
				u9RjOr4XwIn8vYgElwrM(P_1, true);
				return;
			}
		}
	}

	private void PeriodButtonClick(object sender, RoutedEventArgs e)
	{
		if (!(sender is wgyvRFH9TatlGu9hT9fS wgyvRFH9TatlGu9hT9fS))
		{
			return;
		}
		while (true)
		{
			DataCycle dataCycle = wgyvRFH9TatlGu9hT9fS.Period;
			int num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (dataCycle == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
						{
							num = 1;
						}
						continue;
					}
					DataCycle dataCycle2 = new DataCycle(dataCycle)
					{
						DataType = d0GXdx4jz5iYsEqjuNih(g5TECk4s5xH7pCO0Oc5g(vCNppNY9xh.MarketSettings)),
						StartDate = vCNppNY9xh.MarketSettings.DataCycle.StartDate,
						EndDate = vCNppNY9xh.MarketSettings.DataCycle.EndDate
					};
					vCNppNY9xh.MarketSettings.DataCycle = dataCycle2;
					return;
				}
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void P4VpCKEkim()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Market.iJaf1hBN7vk().fMTfArZKbcv(WhQpUxoLct);
					return;
				default:
					i4Kx1a4E0gJ3MEk8AHVW(zif3dF4stOl7cKl3qILc(vCNppNY9xh.MarketSettings), new PropertyChangedEventHandler(TuF3Ky9N0x));
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					pvSN8q4En7G3kcAnsTY3(Market.Smtf170DVgj(), new Action(WhQpUxoLct));
					num2 = 2;
					continue;
				case 3:
					((wNkTg8flwnoQb0vtSgf4)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).PropertyChanged += TuF3Ky9N0x;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					vCNppNY9xh.PropertyChanged += TuF3Ky9N0x;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					break;
				case 6:
					AraHYu4EfKyop3xtHO2p(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).Levels, new PropertyChangedEventHandler(TuF3Ky9N0x));
					ChEduq4E9GUqQMtuKnrJ(XYq3Vb4XtogMeAcK2Sul(vCNppNY9xh.MarketSettings), new PropertyChangedEventHandler(TuF3Ky9N0x));
					vCNppNY9xh.MarketSettings.ClusterSettings.PropertyChanged += TuF3Ky9N0x;
					ChEduq4E9GUqQMtuKnrJ(vCNppNY9xh.MarketSettings.TradeSettings, new PropertyChangedEventHandler(TuF3Ky9N0x));
					MarketTraderControl.PropertyChanged += TuF3Ky9N0x;
					num2 = 5;
					continue;
				}
				break;
			}
			i4Kx1a4E0gJ3MEk8AHVW(vCNppNY9xh.MarketSettings.Preset2, new PropertyChangedEventHandler(TuF3Ky9N0x));
			((EpdvD7f3hWq8UlJ32f6V)GgkCwc4E2VQUkV1tBTq2(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh))).PropertyChanged += TuF3Ky9N0x;
			i4Kx1a4E0gJ3MEk8AHVW(vCNppNY9xh.MarketSettings.Preset4, new PropertyChangedEventHandler(TuF3Ky9N0x));
			i4Kx1a4E0gJ3MEk8AHVW(DICM7K4EHmvZtyPJpg2c(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)), new PropertyChangedEventHandler(TuF3Ky9N0x));
			AraHYu4EfKyop3xtHO2p(lgmcOX4s0jGvkPpntGjk(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)), new PropertyChangedEventHandler(TuF3Ky9N0x));
			num = 6;
		}
	}

	private void TsyprKw6jF()
	{
		vCNppNY9xh.PropertyChanged -= TuF3Ky9N0x;
		vShQQ14EGChcl6hfHiw4(vCNppNY9xh.MarketSettings, new PropertyChangedEventHandler(TuF3Ky9N0x));
		((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).Preset1.PropertyChanged -= TuF3Ky9N0x;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				HEjF5L4EoAZOksktkf8n(GgkCwc4E2VQUkV1tBTq2(vCNppNY9xh.MarketSettings), new PropertyChangedEventHandler(TuF3Ky9N0x));
				((EpdvD7f3hWq8UlJ32f6V)wsHPQ94EvscZhDbPkjM3(vCNppNY9xh.MarketSettings)).PropertyChanged -= TuF3Ky9N0x;
				num = 3;
				break;
			case 2:
				MarketTraderControl.PropertyChanged -= TuF3Ky9N0x;
				Market.Smtf170DVgj().PM4fAKA1mht(WhQpUxoLct);
				fJY56Q4EB3HDtIoJKOfD(Market.iJaf1hBN7vk(), new Action(WhQpUxoLct));
				return;
			default:
				vCNppNY9xh.MarketSettings.VisualSettings.PropertyChanged -= TuF3Ky9N0x;
				vShQQ14EGChcl6hfHiw4(xK1PRp4cfVfE7ZkgUAfC(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)), new PropertyChangedEventHandler(TuF3Ky9N0x));
				vShQQ14EGChcl6hfHiw4(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).TradeSettings, new PropertyChangedEventHandler(TuF3Ky9N0x));
				num = 2;
				break;
			case 3:
				HEjF5L4EoAZOksktkf8n(((MarketSettings)D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)).Preset5, new PropertyChangedEventHandler(TuF3Ky9N0x));
				num = 4;
				break;
			case 1:
				HEjF5L4EoAZOksktkf8n(GYHFHG4EYp1jg70evi3m(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)), new PropertyChangedEventHandler(TuF3Ky9N0x));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num = 5;
				}
				break;
			case 4:
				vCNppNY9xh.MarketSettings.SignalLevels.PropertyChanged -= TuF3Ky9N0x;
				vCNppNY9xh.MarketSettings.Levels.PropertyChanged -= TuF3Ky9N0x;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void FgHpKUTdw4(object P_0, KeyEventArgs P_1)
	{
		if (((KedBU3f05IsrqcZmlPn5)COSvwm4X8Zes8ThEYDBJ()).AdjPresetSizeViaScroll.Check(P_1))
		{
			P_1.Handled = true;
		}
	}

	protected override XColor GetCursorMarkerTextColor()
	{
		return YKQKOV4EiYgdf56GNZO4(xnYtPm4EaZTf2xTOmCAv(Market));
	}

	private void Market_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (((UQpOEF95Pl27GeSpKZ6s)DQrkDh4ElU1FMpLdbmVj(HDCVke4XmWYrQZSCBGLS())).Check())
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				vo5pmkbLsl(e.Delta);
				e.Handled = true;
				return;
			}
		}
	}

	private void vo5pmkbLsl(int P_0)
	{
		int num = tGJuH3h7mp.beE9xlnxlyK();
		int num2;
		if (num >= 2)
		{
			if (num >= 6)
			{
				goto IL_00a0;
			}
			num2 = 10;
		}
		else
		{
			num2 = 20;
		}
		goto IL_0149;
		IL_0149:
		int num3 = num2;
		int num4 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
		{
			num4 = 2;
		}
		long num6 = default(long);
		while (true)
		{
			switch (num4)
			{
			case 4:
				if (num6 >= 1)
				{
					num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num4 = 0;
					}
					continue;
				}
				return;
			case 3:
				QnCQFT4EbgIqjubBnd23(vCNppNY9xh.MarketSettings.VisualSettings);
				return;
			default:
				vCNppNY9xh.MarketSettings.DomQuoteMaxSize = num6;
				num4 = 3;
				continue;
			case 1:
				break;
			case 2:
			{
				long num5 = fVNP8L4E4YCv1HpPC2lW(P_0) * Math.Max(1L, vCNppNY9xh.MarketSettings.DomQuoteMaxSize / num3);
				num6 = Rn0VtI4EDGjA3AvIhKl0(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)) + num5;
				num4 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
				{
					num4 = 4;
				}
				continue;
			}
			}
			break;
		}
		goto IL_00a0;
		IL_00a0:
		num2 = 2;
		goto IL_0149;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!MYFuY9YILY)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			default:
			{
				Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999651408), UriKind.Relative);
				TosnTE4ENjh11CM7odwt(this, uri);
				return;
			}
			case 1:
				MYFuY9YILY = true;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					return;
				default:
					goto IL_0105;
				case 4:
					return;
				case 8:
					return;
				case 1:
					switch (P_0)
					{
					case 10:
						break;
					case 7:
						goto IL_006c;
					case 2:
						SliderZoom = (Slider)P_1;
						SliderZoom.MouseDoubleClick += tWfpEpuvJe;
						return;
					case 13:
						goto end_IL_0012;
					case 9:
						ToolBarTrayBottom = (ToolBarTray)P_1;
						return;
					case 16:
						goto IL_00ee;
					case 3:
					case 4:
					case 5:
						goto IL_0105;
					case 6:
						PopupPlace = (ContentControl)P_1;
						return;
					case 17:
						Market = (mrGdQof1Dl8Jsg7DRfOq)P_1;
						return;
					case 14:
						goto IL_0136;
					default:
						goto IL_01b4;
					case 1:
						goto IL_01ce;
					case 12:
						TradeSettingsExpander = (AnimatedExpander)P_1;
						TradeSettingsExpander.Collapsed += cfbp5PoFxy;
						TradeSettingsExpander.Expanded += ePdpSjA6lL;
						return;
					case 8:
						goto IL_0222;
					case 11:
						ToolBarTrayRight = (ToolBarTray)P_1;
						return;
					case 15:
						goto IL_0267;
					}
					ToolBarTrayLeft = (ToolBarTray)P_1;
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
					{
						num2 = 5;
					}
					break;
				case 7:
					goto IL_01ce;
				case 2:
					PopupSelectSymbols.PreviewKeyDown += GBgpV8dYrK;
					return;
				case 9:
					return;
				case 6:
					return;
					IL_0267:
					MarketTraderExpander = (AnimatedExpander)P_1;
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num2 = 1;
					}
					break;
					IL_006c:
					PopupSelectSymbols = (Popup)P_1;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
					{
						num2 = 1;
					}
					break;
					IL_0222:
					ToolBarTrayTop = (ToolBarTray)P_1;
					num2 = 3;
					break;
					IL_01ce:
					ThisControl = (jup2YO3VI1WuSPZJgwh)P_1;
					return;
					IL_01b4:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
					{
						num2 = 0;
					}
					break;
					IL_0105:
					MYFuY9YILY = true;
					return;
					IL_0136:
					ButtonCloseTradeSettings = (Button)P_1;
					ButtonCloseTradeSettings.Click += iMypk0BvQ7;
					num2 = 6;
					break;
					IL_00ee:
					MarketTraderControl = (MarketTraderControl)P_1;
					num2 = 4;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			MarketSettingsPanel = (DockPanel)P_1;
			num = 8;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 4:
			xFSKGK4EkTIotvloICBH((Button)P_1, new RoutedEventHandler(nVyp1OM2av));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			((Border)P_1).KeyDown += FgHpKUTdw4;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 5:
			{
				((Int32EditBox)P_1).KeyUp += WnJpTqy152;
				((Int32EditBox)P_1).ValueChanged += aMFpy6qcNJ;
				break;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private bool zjFphYRBVo(out double P_0)
	{
		if (xCdooR4cDnGvewx5YPYS(D3Twqm4epV7tBTfp7yTI(vCNppNY9xh)))
		{
			double num = mVmMkK4s9F6QcBfvA5WC(Account?.ConnectionID, base.Symbol);
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				object connectionID;
				switch (num2)
				{
				case 1:
					return false;
				case 3:
					return true;
				default:
				{
					Account account = Account;
					if (account == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					connectionID = account.ConnectionID;
					break;
				}
				case 2:
					connectionID = null;
					break;
				}
				double leverage = DataManager.GetLeverage((string)connectionID, base.Symbol);
				if (num < -5E-324 || leverage < double.Epsilon)
				{
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)KJoIlM4E1j6xPeE6t934(TigerTrade.Properties.Resources.ResourceManager, jqdeOo4eKgiRI3O5pbjF(0x86EFEF6 ^ 0x86E8144)), (string)KJoIlM4E1j6xPeE6t934(JYYww94E5H2E4UTOUo0v(), jqdeOo4eKgiRI3O5pbjF(-57768881 ^ -57738345)), NotificationType.Error));
					P_0 = -1.0;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					P_0 = JLFqEJGJYiHaSdoROJXI.k62GJ45Rvfj(num, leverage, vCNppNY9xh.MarketSettings.CurrentPreset.PercentSize);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num2 = 3;
					}
				}
			}
		}
		P_0 = vCNppNY9xh.MarketSettings.CurrentPreset.QuoteSize;
		return true;
	}

	[CompilerGenerated]
	private BpmEftf7wYbuVebk5Vku h3Apw1Rf3W(E5ZRLJfvK5UFeYCuZIcl P_0)
	{
		return new cHDH2xfPlID4okPS4Qpr(P_0, base.Symbol.Step, imd4wW4ES9pZkDPtCZLl(base.Symbol));
	}

	static jup2YO3VI1WuSPZJgwh()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Apv8PH4eCoXPq5IR22U2()
	{
		return VZGEK34eV7rA7fKrFZ3H == null;
	}

	internal static jup2YO3VI1WuSPZJgwh OvOyRV4er8GK9nJIaNaC()
	{
		return VZGEK34eV7rA7fKrFZ3H;
	}

	internal static object jqdeOo4eKgiRI3O5pbjF(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void F5CwmN4em54Wbnu1ioQo(object P_0, double P_1)
	{
		((FrameworkElement)P_0).Width = P_1;
	}

	internal static void WpHavP4ehN3WFCBY6oNi()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void Xul9UB4ewIbAOQRNbGxU(object P_0, bool P_1)
	{
		((DocLinkContext)P_0).IsMarketLocked = P_1;
	}

	internal static bool iEd1DD4e7EpvL4Tg8j59(object P_0)
	{
		return ((TradingSettings)P_0).IsSymbolSwitchError;
	}

	internal static object YuMpeF4e88B5i15175HO(object P_0)
	{
		return ((TradingSettings)P_0).LockedExchange;
	}

	internal static object OGGFLF4eAc5gQrtNiSgc(object P_0)
	{
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	internal static bool PiRdLU4eP6bfF2V9Ch3L(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void QqVL4t4eJohD4vfCiweC(object P_0)
	{
		((pPoPrc3qBX4fc5gckU0)P_0).uPr3tlxi8L();
	}

	internal static void rVMKpw4eFNFEdyiFVxt9(object P_0, object P_1)
	{
		((MarketSettings)P_0).TemplateID = (string)P_1;
	}

	internal static void MexLBV4e3mggAonED8LM(object P_0, bool value)
	{
		((MarketSettings)P_0).ContainsPeriod = value;
	}

	internal static object D3Twqm4epV7tBTfp7yTI(object P_0)
	{
		return ((TradingSettings)P_0).MarketSettings;
	}

	internal static object yVQVLd4eupt8puSOQgZq(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).Qom210PQiuE;
	}

	internal static object YyMvfa4ez3dugQ59kYaT(object P_0, object P_1)
	{
		return EKVIQxfkdb0qc2T2DNLL.hvRfkWM7bY4((string)P_0, (string)P_1);
	}

	internal static object lgmcOX4s0jGvkPpntGjk(object P_0)
	{
		return ((MarketSettings)P_0).SignalLevels;
	}

	internal static object DSK7UK4s2C6SiQmrGArN(object P_0)
	{
		return ((MarketSettings)P_0).Account;
	}

	internal static bool seXOpL4sHJDFWDKNHirB(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object YNRY934sfvZVrrlH44LX(object P_0)
	{
		return ((Account)P_0).ConnectionID;
	}

	internal static double mVmMkK4s9F6QcBfvA5WC(object P_0, object P_1)
	{
		return DataManager.GetFreeMargin((string)P_0, (Symbol)P_1);
	}

	internal static bool gSuEEg4sngyHQFpBOdU9(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).vJn2H0NlctN();
	}

	internal static object IwdJX64sGqrCBGAr2nNM()
	{
		return wsrDWBfhEyqEYOXKI8P0.kGbfhO7l1ih();
	}

	internal static void BZOLKu4sYeFTtsjj2Nbs(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void Q0Hjwp4soL1ePo3NXq3y(object P_0, object P_1)
	{
		((FY07xYHfSCiM5E3465o7)P_0).cPMHfc4R8gI((UserControl)P_1);
	}

	internal static object RnOuMX4sv3RIEKu8ZLfg(object P_0)
	{
		return ((MarketTraderControl)P_0).ViewModel;
	}

	internal static bool DJZIL54sBtWgYkynNBcZ(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).IsEnabled;
	}

	internal static object cUent24sadqsJDXJh6o2(object P_0, object P_1)
	{
		return ((H2WxiZ9mljPsQ9ncZgPc)P_0).fuulnktHjJ4((string)P_1);
	}

	internal static void pCDdlo4si0LuaIfiVQmE(object P_0, object P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).v9b20TUKTDl((ypqMIv9maFM0tRwF0xMh)P_1);
	}

	internal static void SAmtD64slUQsMwvk7Iqb(object P_0)
	{
		c8EcTUfGEuMy2llFqsdF.HICfY9v6h5d((Action)P_0);
	}

	internal static void hBCvUb4s4wTFQmgKVnWL(object P_0, object P_1)
	{
		((nawYUmG2C9dJMZEo3okg)P_0).zGbGHfYR7sJ((EventHandler)P_1);
	}

	internal static void SKfGF84sDC4QpEnlBUw4(object P_0, bool P_1)
	{
		((TradingSettings)P_0).IsExchangeLocked = P_1;
	}

	internal static void ekCWet4sbTaEoZONe1sB(object P_0, object P_1)
	{
		((TradingSettings)P_0).LockedExchange = (string)P_1;
	}

	internal static void xtFZfM4sNxeg1p59a6So(object P_0)
	{
		((MarketSettings)P_0).PrepareFonts();
	}

	internal static void pX4tsO4skLEHT349Bvt9(object P_0, int value)
	{
		((MarketSettings)P_0).DataScale = value;
	}

	internal static object wjjUAY4s1LxDDgaTwL0n()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object g5TECk4s5xH7pCO0Oc5g(object P_0)
	{
		return ((MarketSettings)P_0).DataCycle;
	}

	internal static void pQVON44sSHpPaN2Cx9jH(object P_0)
	{
		h8uiRtfnRZ9JJpkepmSl.iWhfnmR8dlj((Action)P_0);
	}

	internal static void qgcJBq4sx0xUX3b5YG26(object P_0)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).InitLink();
	}

	internal static int S67Uu24sLkELpGTL9I6t(object P_0)
	{
		return ((z6kMSs25KYyGVf55FxBT)P_0).LinkGroup;
	}

	internal static void bhXpTE4seeVrpPZe2XpS(object P_0, object P_1)
	{
		((waq1Af2bWXQbeynqsiXl)P_0).OnEditLotExecute((MarketSettings)P_1);
	}

	internal static object ty3xXb4sscuA5QTPPBiB(object P_0)
	{
		return ((DispatcherObject)P_0).Dispatcher;
	}

	internal static object zmNNvY4sXTwPaNfsMZp1(object P_0, object P_1, DispatcherPriority P_2, object P_3)
	{
		return ((Dispatcher)P_0).BeginInvoke((Delegate)P_1, P_2, (object[])P_3);
	}

	internal static object x0xNSs4scq1qt9UXfEfc(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).d73l9JpDb23;
	}

	internal static long XgES7F4sji2NgFe7Jiym(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionSize;
	}

	internal static void IGoEiJ4sEhMEhHOTPQcV(object P_0, long P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).jPs9wJ1xvmD(P_1);
	}

	internal static long JOtsfi4sQXdIHx67gMXs(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).mfq9w3ApRCG();
	}

	internal static void Rke9tT4sdo5eTUSbOtwq(object P_0, bool P_1)
	{
		((lFstfvuoXTH8701fWFf)P_0).TakeProfitIsChecked = P_1;
	}

	internal static bool JJWKGK4sgZUub5ehyw3Z(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).MLM9wsnZGqb();
	}

	internal static long A2i9Zp4sRjpNF4TXKGVj(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).d919wPySHGR();
	}

	internal static void MExWIY4s6VdCCKCbPrMm(object P_0, object P_1, object P_2, int P_3)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).SaveSettings((string)P_1, (string)P_2, P_3);
	}

	internal static object REIjnE4sMZdpohiKDa0O(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).XlV9wd4ELTW();
	}

	internal static bool RvxSNT4sO50u0SaBsn0p(object P_0)
	{
		return DataManager.IsTradeAllowed((UserPosition)P_0);
	}

	internal static void NSB0IM4sqGQDXuG8E1fk(object P_0, bool P_1)
	{
		((lFstfvuoXTH8701fWFf)P_0).IsTradeAllowed = P_1;
	}

	internal static void cT1Qdb4sIlABayVdFPV7(object P_0)
	{
		((cXwoI5f1jl9EMXW8XL7D)P_0).xRQf1Z7D9iT();
	}

	internal static object LdNYOr4sWAsud7lKgxO5(object P_0)
	{
		return T3TrZWfB19BlXX1UJ3Ie.Q1gfBxw3D56((TradingSettings)P_0);
	}

	internal static object zif3dF4stOl7cKl3qILc(object P_0)
	{
		return ((MarketSettings)P_0).Preset1;
	}

	internal static object dHgqrT4sUuwmGxsWgPCW(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void bB8ute4sTI3u2QCY2h9e(object P_0, bool P_1)
	{
		((TradingSettings)P_0).IsExtendedLotsInDOMShowed = P_1;
	}

	internal static double lnxVbd4syr2ffqAe3L8F(object P_0)
	{
		return ((Symbol)P_0).LotStep;
	}

	internal static object F3MFug4sZjCq42rUXJvk(object P_0)
	{
		return ((Symbol)P_0).Currency;
	}

	internal static void h34HRY4sVpOMsamuyh1o(object P_0, object P_1)
	{
		((MarketSettings)P_0).QuoteCurrency = (string)P_1;
	}

	internal static void NKDDtX4sCdNTRSNtNcbp(object P_0, object P_1)
	{
		((MarketSettings)P_0).BaseCurrency = (string)P_1;
	}

	internal static void iRC7FN4srSSI3q5MsYph(object P_0)
	{
		((TradingSettings)P_0).WNsuupAvUm();
	}

	internal static bool EAThcm4sKZL0oZfOkvVN(object P_0)
	{
		return ((MarketSettings)P_0).IsDefaultLots;
	}

	internal static object qRycBF4smsivE3xDlAZN(object P_0)
	{
		return SymbolManager.GetNameLotsTemplate((Symbol)P_0);
	}

	internal static object c1R1Nc4sh1DRtdkRZNOt(object P_0)
	{
		return EKVIQxfkdb0qc2T2DNLL.TghfktGum0g((string)P_0);
	}

	internal static bool dimBaK4swAB7DLtoKYXT(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool JBEUaS4s7sNyDVOQ7p26(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInQuoteCurrency;
	}

	internal static int PHTVuU4s8Qvgke4A1kkv(object P_0)
	{
		return ((List<BpmEftf7wYbuVebk5Vku>)P_0).Count;
	}

	internal static object NGeY8B4sAgBvsRIicJ2n(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).axFf1ARQQOr();
	}

	internal static bool Qb6cBV4sPhtExQW7EiWs(object P_0, object P_1)
	{
		return ((G2gR30fAanPKf0TTFLoc)P_0).qWYfADeVptG((BpmEftf7wYbuVebk5Vku)P_1);
	}

	internal static object vHu86L4sJd4ZW40fbmGn(object P_0)
	{
		return c8EcTUfGEuMy2llFqsdF.QEEfGMfSstB((string)P_0);
	}

	internal static double cHHDMB4sFhjXi7KZjPrg(object P_0)
	{
		return ((E5ZRLJfvK5UFeYCuZIcl)P_0).TargetPrice;
	}

	internal static double bBemsL4s3aPl18AK0woD(object P_0)
	{
		return ((E5ZRLJfvK5UFeYCuZIcl)P_0).OriginalPrice;
	}

	internal static void SWPNNn4spEU8iNSklij8(object P_0, object P_1)
	{
		((G2gR30fAanPKf0TTFLoc)P_0).jMXfAbLdmrt((BpmEftf7wYbuVebk5Vku)P_1);
	}

	internal static void SprnKF4suHJGU95VMeli(object P_0, double P_1)
	{
		((cHDH2xfPlID4okPS4Qpr)P_0).OriginalPrice = P_1;
	}

	internal static void uW02ka4szpKRrnLktHuK(object P_0, bool P_1)
	{
		((cHDH2xfPlID4okPS4Qpr)P_0).IsSynchronized = P_1;
	}

	internal static object iUwqH24X0xx6M7uSwpMq(object P_0)
	{
		return ((E5ZRLJfvK5UFeYCuZIcl)P_0).Symbol;
	}

	internal static object B84akm4X21k3rnR0amO3(object P_0)
	{
		return ((E5ZRLJfvK5UFeYCuZIcl)P_0).fbgfvAgVpun();
	}

	internal static double gKwrDf4XHarOHGiaqCt9(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static void J7HwG54XfoUP6H6Xepwi(object P_0, object P_1)
	{
		((MarketSettings)P_0).RecalculateBaseLot((MarketSettings)P_1);
	}

	internal static bool kwTiR44X9ZypKRdJxZmy(object P_0)
	{
		return ((MarketSettings)P_0).SetNewSymbol;
	}

	internal static void ocASog4XndqjQRedYtrL(object P_0, object P_1)
	{
		((MarketSettings)P_0).CopyIndividualSettings((MarketSettings)P_1);
	}

	internal static object eoLMDN4XGIRLHbVD2nL2(object P_0)
	{
		return ((MarketSettings)P_0).CommonTemplateID;
	}

	internal static object pE9Zau4XYcmhgZXyuRRP(object P_0)
	{
		return ((MarketSettings)P_0).SpecialCommonTemplateID;
	}

	internal static object jq3ePa4XommNAkX5BQsb(object P_0)
	{
		return ((MarketSettings)P_0).SpecialIndividualTemplateID;
	}

	internal static object shqjfv4Xvm60UeX1sr72(object P_0)
	{
		return ((MarketSettings)P_0).Levels;
	}

	internal static void HWeHv84XBfsVEFbFefRk(object P_0, object P_1)
	{
		((MarketSettings)P_0).CopyCommonSettings((MarketSettings)P_1);
	}

	internal static bool uWX4TW4XaiLSRNxcMhxJ(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static void xhmlkb4Xi6h2VwAoJiIC(object P_0, object P_1)
	{
		((YiXl9IfP06OkWU6fDkUP)P_0).vhafPnugja4((YiXl9IfP06OkWU6fDkUP)P_1);
	}

	internal static bool oZWqub4XlSMGeN6qnJZL(object P_0)
	{
		return ((MarketSettings)P_0).PresetAdjViaScrollMode;
	}

	internal static object hkeGDI4X4SQfJn5pXLhI(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).ExitStrategy;
	}

	internal static void RgUn4j4XDxZq74IS9kWS(object P_0, object P_1)
	{
		((MarketTraderControl)P_0).SetStrategy((string)P_1);
	}

	internal static void ibYlXK4XbiPFqrY1GY2e(object P_0, object P_1)
	{
		((MarketSettings)P_0).CopyLots((MarketSettings)P_1);
	}

	internal static object L2uPeB4XNNGkfs0kH0Gy(object P_0, bool P_1)
	{
		return SymbolManager.GetNameDomTemplate((Symbol)P_0, P_1);
	}

	internal static void uHI6C94XkQFl7xMdqyjk(object P_0, object P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).Account = (string)P_1;
	}

	internal static FX2hNmfFGUQfi0wdaZLW.Positions IGyIAY4X1ZbOagt6x9C6(object P_0)
	{
		return ((FX2hNmfFGUQfi0wdaZLW)P_0).Position;
	}

	internal static object DrsySQ4X5HnLOGvBHCSO(object P_0, object P_1)
	{
		return ((ResourceDictionary)P_0)[P_1];
	}

	internal static object r4Ewxq4XSDkUQOr7g496(object P_0)
	{
		return ((FrameworkElement)P_0).Resources;
	}

	internal static void SsWJhR4XxZrRv8GNIowj(object P_0, object P_1)
	{
		((FrameworkElement)P_0).ContextMenu = (ContextMenu)P_1;
	}

	internal static void uDQ5qf4XLWpOdwpX3UET(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static void TlKR6Q4XeDpS0CtKpAmP(object P_0)
	{
		((zUNI16202mQmpx9T2Hxb)P_0).jXC20GxSneC();
	}

	internal static object MVOnRc4XsbZHIA7lNf1c(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static nDujbt9RUocG2LJtIN4X BelOMC4XXZVhjHOxfogk(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).gr39RNXWFfO();
	}

	internal static double VYaVHl4XcOlF9kPglWUh(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).Quantity;
	}

	internal static object aK4F9v4XjAHE5GKtkIaL(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static MOWYtTHiJiOZMqTggitO BLiFEZ4XEkbwpFd6IDK7(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).OffsetsType;
	}

	internal static long dmxKwc4XQCniHdEyICHg(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).Price;
	}

	internal static ChartOrderValidity HPZdn64XdkGp0DaBQp0M(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).OrderValidity;
	}

	internal static bool CyAECZ4XgIM2VwBUqiuj(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).hd19RcfNKbe();
	}

	internal static object wO6tnV4XRLdPjBfRfEva(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).Kvl9RQgO1sv();
	}

	internal static double iY0O974X6ffOF4dSnhuD(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).yTq9RsvEb5L();
	}

	internal static int joJdkB4XMrXtr4Kkh0AK(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static double X6oFvC4XOtJ7SEtfnw76(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).Iy19RLkeCeC();
	}

	internal static long LBsj7x4Xq6WyYsQlwdKK(object P_0, double P_1)
	{
		return ((Symbol)P_0).GetShortPrice(P_1);
	}

	internal static long oPWon34XIgSna5AkwbJo(object P_0)
	{
		return ((j3bgDY9gV2i9bttJ1fiQ)P_0).Q6K9R5T1PJn();
	}

	internal static decimal leUCoL4XWttBiK13wy7w(double P_0)
	{
		return (decimal)P_0;
	}

	internal static object XYq3Vb4XtogMeAcK2Sul(object P_0)
	{
		return ((MarketSettings)P_0).VisualSettings;
	}

	internal static int BeXYlb4XUfivCH2kuAJA(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static int Q8e8To4XTKIngleit01D(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).LastVisibleDepthIndex;
	}

	internal static void bepGnF4XyubHfwAU8uXB(object P_0, object P_1)
	{
		((UIElement)P_0).OnPreviewKeyDown((KeyEventArgs)P_1);
	}

	internal static object fd8bVi4XZb2DsSPB8DFB(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static bool o7E0Fw4XVqPBL1Akj7jO(object P_0)
	{
		return ((RoutedEventArgs)P_0).Handled;
	}

	internal static Key VSomYr4XC8i9W2whodRq(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static void nsoV3Q4XrKobQhDggRF6(object P_0, object P_1)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).LogInfo((string)P_1);
	}

	internal static object DLnkJ64XKO5dwqDOt5ME(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SetVisibleDepth;
	}

	internal static object HDCVke4XmWYrQZSCBGLS()
	{
		return vspL39fH6Hd69qemUHrA.Market;
	}

	internal static bool NVYwSH4Xh9J5oPI3nAC6(object P_0, object P_1)
	{
		return UQpOEF95Pl27GeSpKZ6s.Check((UQpOEF95Pl27GeSpKZ6s)P_0, (UQpOEF95Pl27GeSpKZ6s)P_1);
	}

	internal static void u9RjOr4XwIn8vYgElwrM(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static bool pUbkUf4X7PhloL5EgV8c(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).IsDomToolBarsVisible;
	}

	internal static object COSvwm4X8Zes8ThEYDBJ()
	{
		return vspL39fH6Hd69qemUHrA.YXwfHUcZiBY();
	}

	internal static bool HCNE034XAGTK0Io5v4G2(object P_0, object P_1)
	{
		return ((UQpOEF95Pl27GeSpKZ6s)P_0).Check((KeyEventArgs)P_1);
	}

	internal static object DB2f5V4XPdBWWnnJRSoM(object P_0)
	{
		return ((KedBU3f05IsrqcZmlPn5)P_0).SwitchToPrevTimeframe;
	}

	internal static object DibQAW4XJf7wu6jrgYAD(object P_0)
	{
		return fKvKggHFteRddgHojOPb.HFXHFVSOWcP((DataCycle)P_0);
	}

	internal static bool GHZMX04XFbOBqQecvMDx(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).CanTransferFunds;
	}

	internal static mUs87h9xN7JK6PZpsQ4J gW2V5g4X3Ue2HWgJnOGU(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TransferFrom;
	}

	internal static mUs87h9xN7JK6PZpsQ4J CXeYIf4XpRpZrnjVE9Yt(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TransferTo;
	}

	internal static ChartPnlType Qhr20b4XuhAppZPTle2r(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).PnlType;
	}

	internal static void jZwmI24XzHXgcQDKUwsl(object P_0, ChartPnlType P_1)
	{
		((CR1isWfDCD1A4fwfUJUf)P_0).PnlType = P_1;
	}

	internal static object kCHXxb4c08OxbvQr9hKq(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).ChangePosSizelDisplayType;
	}

	internal static void SiGjGM4c26bV2dL2tCbi(object P_0, OnRZP7fwMaIGMRJa0UZR P_1)
	{
		((CR1isWfDCD1A4fwfUJUf)P_0).PositionSizeDisplayType = P_1;
	}

	internal static void gx9UOh4cHbilPhCQVwiy(object P_0, object P_1)
	{
		((YiXl9IfP06OkWU6fDkUP)P_0).yalfP9nMZxk((string)P_1);
	}

	internal static object xK1PRp4cfVfE7ZkgUAfC(object P_0)
	{
		return ((MarketSettings)P_0).ClusterSettings;
	}

	internal static bRGA9Ifw05O8oh1kygRX wBp4084c9yXyHtjOpDi8(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).MarketDepthViewType;
	}

	internal static void vbDDUC4cnwfBXJ0vdCBt(object P_0, bRGA9Ifw05O8oh1kygRX P_1)
	{
		((LYn4tAf4HSV4yrcb7PrO)P_0).ChartClusterViewType = P_1;
	}

	internal static object Gudk7M4cGNY9uKW35K0F(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).ChangeModeRuler;
	}

	internal static void xVp9fn4cYdfowWdNTDDu(object P_0, LFjXBvf7dDRMWAqKcQ4V P_1)
	{
		((SH4fZjfBgpnJAYxtUbu4)P_0).DomRuler = P_1;
	}

	internal static object xD1DY54cojEQ47fUdaFc(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SetTakeProfit;
	}

	internal static object egMHur4cvCcrdc5vFAd8(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).OpenInstrumentChart;
	}

	internal static void adnMUu4cBheAKnXhPbWR(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).fxLfSvPCdht();
	}

	internal static object KtmD9w4camRRph8QCyXI(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).Smtf170DVgj();
	}

	internal static object plOYQo4ciTObZSkyh1Bj(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).BuyMarket;
	}

	internal static object JGLLZl4clCmBintCyUsR(object P_0)
	{
		return ((MarketSettings)P_0).CurrentPreset;
	}

	internal static double csnmyq4c4HHimkvHocgK(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).Size;
	}

	internal static bool xCdooR4cDnGvewx5YPYS(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInPercents;
	}

	internal static double oXZHn74cblbk5dFU9wDw(object P_0)
	{
		return ((SymbolBase)P_0).ContractValue;
	}

	internal static double p9XOm94cNZpHqNSqHPwL(double P_0, long P_1, double P_2, double P_3, double P_4, double P_5)
	{
		return JLFqEJGJYiHaSdoROJXI.q1nGJi4WVQh(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	internal static bool MYJhBV4ckqVcCL3HhDve(object P_0)
	{
		return ((UQpOEF95Pl27GeSpKZ6s)P_0).Check();
	}

	internal static object LioO1H4c1ka7gnUokq9T(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SellMarket;
	}

	internal static long x9WESE4c5J8h6CqeLHYt(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).BidPrice;
	}

	internal static double sKWEkV4cSpUyQAaMcgeJ(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static object mNF08U4cxxY0DhSmCgxm(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).ClosePosition;
	}

	internal static bool NWHBx04cLxm6ihY3ijne(object P_0)
	{
		return ((Symbol)P_0).IsGateIo;
	}

	internal static SymbolType d9ijCB4cecA3XlCcSNZ4(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static object b90tpw4csOdniyIGXyiT(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).OpZl98KAYgk();
	}

	internal static long Tx4Jkg4cXr2gWAbJWJhC(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).MOr9F63nWYw();
	}

	internal static object QyM1Lk4ccPhmZyNaiavo(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SellLimit;
	}

	internal static long DWdoIa4cjVAWROjLWyiW(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).sZK9Ftv0iH4();
	}

	internal static void MwZ2fN4cEsKN7kR5nNUs(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0)[P_1] = P_2;
	}

	internal static object aPXJZK4cQoSyMFbymNHJ(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SetOrderMode;
	}

	internal static bool SHfX744cdfwrZ4KepPbl(object P_0)
	{
		return ((MarketSettings)P_0).UseTriggers;
	}

	internal static object wIBCWj4cgi9C7pSxgx5B(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SetSignalPriceLevel;
	}

	internal static object pMvePv4cR4hTTlGv6xpA(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).SetPriceLevel;
	}

	internal static object BU6wDp4c6JEeLYojGN3O(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).TurnDownPriceScale;
	}

	internal static void RtmrpV4cMlIZ91Zhd9Qm(object P_0)
	{
		vspL39fH6Hd69qemUHrA.qVufHOm1oGC((UQpOEF95Pl27GeSpKZ6s)P_0);
	}

	internal static double K3FvE34cOpoDaDD2lefb(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize;
	}

	internal static object tiNq3I4cqHRnjGqpyjPU(object P_0)
	{
		return ((lFstfvuoXTH8701fWFf)P_0).Settings;
	}

	internal static int mrT5mM4cIb2m9wtIo6oA(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).PercentSize;
	}

	internal static void chHgyK4cWyLxajnM6bjA(object P_0, double P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).Size = P_1;
	}

	internal static object ipn5ex4ctUkbBEyQsaNq(object P_0)
	{
		return ((KedBU3f05IsrqcZmlPn5)P_0).OrderSizeDown;
	}

	internal static void J7To0t4cUYfI7kvS6owM(object P_0, double P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize = P_1;
	}

	internal static void fj90IL4cTpOjsynVYow2(object P_0, int P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).PercentSize = P_1;
	}

	internal static object T4o14O4cyuP69lKRE7hy(object P_0)
	{
		return ((KedBU3f05IsrqcZmlPn5)P_0).OrderSize1;
	}

	internal static object IIm9Es4cZ4Gste9E8tcO(object P_0)
	{
		return ((KedBU3f05IsrqcZmlPn5)P_0).OrderSize2;
	}

	internal static void Bv1lEn4cVTb28tXwyr5N(object P_0, bool value)
	{
		((MarketSettings)P_0).Preset2IsSelected = value;
	}

	internal static object aZGZMF4cCQpWeGMRZMZa(object P_0)
	{
		return ((KedBU3f05IsrqcZmlPn5)P_0).OrderSize4;
	}

	internal static void sfpvDY4cr7XfpUJ86FA0(object P_0, object P_1)
	{
		LogManager.WriteError((string)P_0, (Exception)P_1);
	}

	internal static void eXqyHB4cKxy1SYWXqDlp(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).awJf5JATcXh();
	}

	internal static void pjGKoN4cmGGxl8R74SHr(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).eBxf5FkP81k();
	}

	internal static object AW63q04ch6M4C38My6AV(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).TurnCustomRulerOn;
	}

	internal static void JnZBZy4cwjGk0VLdJwYC(object P_0)
	{
		vspL39fH6Hd69qemUHrA.xCYfHqyUP6y((UQpOEF95Pl27GeSpKZ6s)P_0);
	}

	internal static void oR9i9a4c7WW5HdaNZHxf(object P_0, bool value)
	{
		((MarketSettings)P_0).PresetAdjViaScrollMode = value;
	}

	internal static bool nB1ZH44c8Sf6BtgbbcvF(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).zDi2k7CwL38;
	}

	internal static object gbnGar4cAxwxx405YtOV(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).yAF9iJ7CbM8;
	}

	internal static bool iWhZXE4cPGoyD4MGt6TA(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object U5ppWi4cJQtmtw1FHla7(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object ht799Z4cFRp8fdtbwwom(object P_0)
	{
		return ((H2WxiZ9mljPsQ9ncZgPc)P_0).DataCycle;
	}

	internal static object l2aNc64c3E9kGwffnm3A(object P_0)
	{
		return ((DataCycle)P_0).ShortName;
	}

	internal static object b4dwIe4cpA3LGMuVd3I6(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).Info;
	}

	internal static DateTime oBmk744cuDo9GHZ2qFRN(object P_0)
	{
		return ((UserDeal)P_0).LocalTime;
	}

	internal static void Ev435f4czPrQBjD4uZfg(object P_0, double P_1)
	{
		((nbVNlXfPFDThbGYvhE91)P_0).TotalPoints = P_1;
	}

	internal static void DXXhGG4j0BUI78tgvucH(object P_0, double P_1)
	{
		((nbVNlXfPFDThbGYvhE91)P_0).WQSfJ0gvkG1(P_1);
	}

	internal static void iVhxbp4j2j30diMUsdra(object P_0, double P_1)
	{
		((nbVNlXfPFDThbGYvhE91)P_0).Comission = P_1;
	}

	internal static DateTime bkJMHD4jHQulfyeWMhu6(object P_0)
	{
		return TimeHelper.GetCurrTime((string)P_0);
	}

	internal static void AYRys04jf41kKtjRwTLe(object P_0)
	{
		((LinkedList<EypMKqfJcHkrJccrH5P0>)P_0).Clear();
	}

	internal static long b2mcTw4j9qhfHfy7pINj(object P_0)
	{
		return ((kjc7Gl9PIEfKaxcEBwuk)P_0).LastPrice;
	}

	internal static long wsEEKs4jnPF00xBfc0PO(object P_0)
	{
		return ((UserPosition)P_0).Size;
	}

	internal static long PNDWlW4jGIfR6jUrnds2(object P_0)
	{
		return ((UserPosition)P_0).LastSizeTriggeredStrategy;
	}

	internal static long QyMuIv4jY0OJRXSRqmlc(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object F0CtXt4jooWFf50ScbqA(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).StrategyName;
	}

	internal static bool DJlxUX4jvAmo8PHjK33x(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).MuD9wXlvwMr();
	}

	internal static long EcsQdW4jBHetbODhJZYx(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).LastSize;
	}

	internal static MOWYtTHiJiOZMqTggitO dRXjVu4jatKQWxi9vEPl(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).StopLossValueType;
	}

	internal static object Dv7Ukw4jilHFWvinqEMK(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void k7gTls4jlbOijlAFPebu(object P_0, long P_1)
	{
		((UserPosition)P_0).LastSizeTriggeredStrategy = P_1;
	}

	internal static double irw2Mp4j4jB3NDRfg0jP(object P_0)
	{
		return ((UserDeal)P_0).MaxQuantity;
	}

	internal static double HYHyYC4jDwd9br9x5Jwf(object P_0)
	{
		return ((UserDeal)P_0).Points;
	}

	internal static void h8a9L14jbMCiT4EfosqX(object P_0, double P_1)
	{
		((EypMKqfJcHkrJccrH5P0)P_0).Profit = P_1;
	}

	internal static TigerTrade.Tc.Data.Side wJ0MIJ4jNd5xQIkrIqIA(object P_0)
	{
		return ((UserDeal)P_0).Side;
	}

	internal static double u4oTr34jkLEtXBbhHyAn(object P_0)
	{
		return ((nbVNlXfPFDThbGYvhE91)P_0).TotalPoints;
	}

	internal static void MHYxMv4j1OfR1VwDfkif(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).DdWfSHnEDyG();
	}

	internal static void jnwdik4j53v9Lg0FijIF(BlmlL92DciZPrtYF1X4r P_0, object P_1)
	{
		z6kMSs25KYyGVf55FxBT.oJP25heTyYW(P_0, P_1);
	}

	internal static void v7ZNtE4jSpBthQRPPCSl(object P_0, zUNI16202mQmpx9T2Hxb.UJajCjnQr63UFbiRQ2if P_1)
	{
		((zUNI16202mQmpx9T2Hxb)P_0).Category = P_1;
	}

	internal static void LMOBEg4jx0SjjnJkN1Aq(NCopbS2n6A8BFZsh7eNY P_0)
	{
		Y43KBu2nt2tdxWysSevH.Lux2nT3jHei(P_0);
	}

	internal static void bOqnkh4jLY7vkSxM65ZK(object P_0, object P_1)
	{
		((zUNI16202mQmpx9T2Hxb)P_0).MarketSettings = (MarketSettings)P_1;
	}

	internal static object fKJvdU4jeDlmIhQ9ueic(object P_0)
	{
		return ((Panel)P_0).Children;
	}

	internal static int kUeiO14jsdTFdJD5MU5B(object P_0, object P_1)
	{
		return ((UIElementCollection)P_0).Add((UIElement)P_1);
	}

	internal static void dsv36H4jXsp2T2WB04Vt(object P_0, bool P_1)
	{
		((Expander)P_0).IsExpanded = P_1;
	}

	internal static object EeJ2CJ4jclox9sINeGDj()
	{
		return hNXfXl9U6G1YI9MQ7eq.Instance;
	}

	internal static object pL10YF4jjqDLhdFyX4V7(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}

	internal static void InVTxi4jEwbmMK7NuNSV(object P_0, object P_1, object P_2)
	{
		((RoutedCommand)P_0).Execute(P_1, (IInputElement)P_2);
	}

	internal static void ggWcNb4jQffl6IBVfB1V(object P_0, bool P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).IsEnabled = P_1;
	}

	internal static bool waxiyl4jdyIToQNVEDCe(object P_0)
	{
		return ((MarketSettings)P_0).PanelShowTotalPoints;
	}

	internal static bool p8mD9E4jguUeew39RlhQ(object P_0)
	{
		return ((MarketSettings)P_0).PanelShowTotalNetPnl;
	}

	internal static void Sq86h64jRBaUoHQqs4gH(object P_0, bool value)
	{
		((MarketSettings)P_0).PanelShowTotalNetPnl = value;
	}

	internal static void Vfr7G04j66YXbySN7ed3(object P_0, bool value)
	{
		((MarketSettings)P_0).PanelShowDeals = value;
	}

	internal static bool XdxQMW4jMCSQne51rKHl(object P_0)
	{
		return ((MarketSettings)P_0).GraphShowTicks;
	}

	internal static void u4QkNS4jONiGbwfp3g8D(object P_0, bool value)
	{
		((MarketSettings)P_0).GraphShowTicks = value;
	}

	internal static void rqXt2r4jq1s6LPvGAE15(object P_0, object P_1)
	{
		((ICommand)P_0).Execute(P_1);
	}

	internal static void e1H7t04jIleV8cUvb6Er(object P_0, object P_1)
	{
		((KqZtUj2kTEAQfYBkeSKy)P_0).Qom210PQiuE = (string)P_1;
	}

	internal static void oMfCmB4jWVETZ7NuqmAR(object P_0, bool P_1)
	{
		((DocLinkContext)P_0).LinkActiveWindow = P_1;
	}

	internal static object lXvrhW4jtChhi4kXU4Cg()
	{
		return PopupButton.ClosePopupCommand;
	}

	internal static object mJY8uy4jUWfg71WqNG5b(object P_0)
	{
		return ((lFstfvuoXTH8701fWFf)P_0).DataCycle;
	}

	internal static void FxBT6D4jT4w3qqWcN6IW(object P_0, object P_1)
	{
		((MarketSettings)P_0).DataCycle = (DataCycle)P_1;
	}

	internal static object K4rbUK4jyKGNfgXXxwmx(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static object iXT0vW4jZbiSwBk8NXWN(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void YnpFWR4jVWA7xAtEyBTd(object P_0, int P_1)
	{
		W1SF6s21AP43c8EaVVZK.ppf252L0P7B((string)P_0, P_1);
	}

	internal static int RjdSdX4jClY2jJhA9cyQ(object P_0)
	{
		return ((lFstfvuoXTH8701fWFf)P_0).DataScale;
	}

	internal static void k3yoSS4jriO88Z0LtVlQ(object P_0)
	{
		((lFstfvuoXTH8701fWFf)P_0).tGvubgWA6Q();
	}

	internal static void slkCx24jKlttIPxl5MUt(object P_0)
	{
		((cXwoI5f1jl9EMXW8XL7D)P_0).Yeyf1y4JDmE();
	}

	internal static object pOPDS14jm5r3rXFkJTud(object P_0)
	{
		return ((G2gR30fAanPKf0TTFLoc)P_0).BojfATVS0J1();
	}

	internal static void uAErvr4jhWe99GaOJV02(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).vZQfSnC75kN();
	}

	internal static void pQhLrt4jwa5KDry9bWSt(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).pXZfSoCCOKq();
	}

	internal static void XUTBHi4j7Yid15g2Zn17(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).MAUfSaMQQNU();
	}

	internal static object RrRhCG4j82KPIVD3PMpq(object P_0)
	{
		return ((G2gR30fAanPKf0TTFLoc)P_0).OltfAW7OUUJ();
	}

	internal static object hnBgW84jACdAHgHqE8mx(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).iJaf1hBN7vk();
	}

	internal static void OBhVcR4jPPFNauE7J4qD(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).YjrfSffa1YH();
	}

	internal static void yl0A6q4jJKtR3kTQ3WsD(object P_0)
	{
		((eUUrAWf5r4OjP4HGXMMb)P_0).mlXfSGyUTII();
	}

	internal static bool pet1XG4jFZNTihYyqmjW(object P_0)
	{
		return XjEly62VOR4KivRmLFDq.R7l2VIn9uHq((Window)P_0);
	}

	internal static bool CE7iwT4j3utKnPyV9OC7(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return DOqwN32flQmmhZv1KMOS.FdY2fDIpJJ1((Window)P_0, (MarketSettings)P_1, (Symbol)P_2, (DOqwN32flQmmhZv1KMOS.ak4J8wnda0d955a2HliP)P_3, (BpmEftf7wYbuVebk5Vku)P_4);
	}

	internal static bool wnl7WB4jpiT8wEuXuXpy(object P_0, object P_1, object P_2)
	{
		return ((RoutedCommand)P_0).CanExecute(P_1, (IInputElement)P_2);
	}

	internal static void C5LgZa4juPDCeQYqxRFX(object P_0, bool P_1)
	{
		((Popup)P_0).IsOpen = P_1;
	}

	internal static DataCycleDataType d0GXdx4jz5iYsEqjuNih(object P_0)
	{
		return ((DataCycle)P_0).DataType;
	}

	internal static void i4Kx1a4E0gJ3MEk8AHVW(object P_0, object P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static object GgkCwc4E2VQUkV1tBTq2(object P_0)
	{
		return ((MarketSettings)P_0).Preset3;
	}

	internal static object DICM7K4EHmvZtyPJpg2c(object P_0)
	{
		return ((MarketSettings)P_0).Preset5;
	}

	internal static void AraHYu4EfKyop3xtHO2p(object P_0, object P_1)
	{
		((YiXl9IfP06OkWU6fDkUP)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static void ChEduq4E9GUqQMtuKnrJ(object P_0, object P_1)
	{
		((wNkTg8flwnoQb0vtSgf4)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static void pvSN8q4En7G3kcAnsTY3(object P_0, object P_1)
	{
		((G2gR30fAanPKf0TTFLoc)P_0).fMTfArZKbcv((Action)P_1);
	}

	internal static void vShQQ14EGChcl6hfHiw4(object P_0, object P_1)
	{
		((wNkTg8flwnoQb0vtSgf4)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static object GYHFHG4EYp1jg70evi3m(object P_0)
	{
		return ((MarketSettings)P_0).Preset2;
	}

	internal static void HEjF5L4EoAZOksktkf8n(object P_0, object P_1)
	{
		((EpdvD7f3hWq8UlJ32f6V)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static object wsHPQ94EvscZhDbPkjM3(object P_0)
	{
		return ((MarketSettings)P_0).Preset4;
	}

	internal static void fJY56Q4EB3HDtIoJKOfD(object P_0, object P_1)
	{
		((G2gR30fAanPKf0TTFLoc)P_0).PM4fAKA1mht((Action)P_1);
	}

	internal static object xnYtPm4EaZTf2xTOmCAv(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).Theme;
	}

	internal static XColor YKQKOV4EiYgdf56GNZO4(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).TextColor;
	}

	internal static object DQrkDh4ElU1FMpLdbmVj(object P_0)
	{
		return ((NMTiYCfHpOuSq61sDR0L)P_0).AdjustOrderBookScale;
	}

	internal static int fVNP8L4E4YCv1HpPC2lW(int P_0)
	{
		return Math.Sign(P_0);
	}

	internal static long Rn0VtI4EDGjA3AvIhKl0(object P_0)
	{
		return ((MarketSettings)P_0).DomQuoteMaxSize;
	}

	internal static void QnCQFT4EbgIqjubBnd23(object P_0)
	{
		((SH4fZjfBgpnJAYxtUbu4)P_0).CmDfBqabLT3();
	}

	internal static void TosnTE4ENjh11CM7odwt(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void xFSKGK4EkTIotvloICBH(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static object KJoIlM4E1j6xPeE6t934(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetString((string)P_1);
	}

	internal static object JYYww94E5H2E4UTOUo0v()
	{
		return TigerTrade.Properties.Resources.ResourceManager;
	}

	internal static int imd4wW4ES9pZkDPtCZLl(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}
}
