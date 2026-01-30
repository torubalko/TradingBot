using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using dpoTZ395JPmKdIOgCedl;
using Dq9qGtf0S8tbnXB1O4NE;
using ECOEgqlSad8NUJZ2Dr9n;
using hsXMqc959OpvL9l48R2A;
using iH5BaVGvRYNiuoSuPkOE;
using inUerCfHMLVDbG9HvwwZ;
using oDRxSAHn4Ifbwj9u9hwd;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using W4BXnjf5KNoQq2fwC7Ij;

namespace nAvYJWf1bMGCThCuJqPY;

internal class mrGdQof1Dl8Jsg7DRfOq : eUUrAWf5r4OjP4HGXMMb, IComponentConnector
{
	private readonly DxVisualQueue DmXf1evtHsB;

	private readonly bIERVFGvgMwfTW5qIt0Y MBaf1sB2beH;

	internal mrGdQof1Dl8Jsg7DRfOq MarketEngineControlName;

	internal DxHwndHost HwndHost;

	internal ROKWRrHnlCLqN5xmrZo0 LotWidget;

	private bool uOTf1c6ucUI;

	internal static mrGdQof1Dl8Jsg7DRfOq g0Pkc5D7sW5sHMlr9KSN;

	public mrGdQof1Dl8Jsg7DRfOq()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		DmXf1evtHsB = new DxVisualQueue();
		MBaf1sB2beH = new bIERVFGvgMwfTW5qIt0Y();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				InitializeComponent();
				HwndHost.OnTimerTick += xaUf1kjwSdp;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				HwndHost.OnRenderVisual += kQpf15pPeia;
				HwndHost.SizeChanged += RBNf1STdMFc;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void jUjf1NJ6T0S()
	{
		R5FyMJD7EIRcThVe9p53(HwndHost, ((MhMDPU9v8rkigy1ao0Th)EeNqtcD7j0m9sCL0hIZZ()).DomUpdateRate);
	}

	private void xaUf1kjwSdp()
	{
		V4if1dKbLOO();
		n82P76D7Ql2LrhERIG8P(LotWidget, AKnfxPJ5PuD());
	}

	public void s3Zf113WHBU(DxVisualQueue P_0)
	{
		int num = 2;
		int num2 = num;
		Rect rect = default(Rect);
		string switchSymbolNotFound = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				rect = new Rect(0.0, 0.0, dTDfxO2A1eG(), RT5fxR1KK3E());
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				XFont xFont = new XFont(j18iDj9nukSCmEyZs5lH.Settings.MarketFontName, rLePGGD7d8Ci3yCXGSBf(j18iDj9nukSCmEyZs5lH.Settings));
				XFont xFont2 = MBaf1sB2beH.YEnGv6YIrqK(switchSymbolNotFound, rect, xFont, 0.9);
				TSTHIWD7gOuAhbbDZpPH(P_0, switchSymbolNotFound, xFont2, new XBrush(((MhMDPU9v8rkigy1ao0Th)EeNqtcD7j0m9sCL0hIZZ()).ChartSymbolNameForegroundColor), rect, XTextAlignment.Center);
				return;
			}
			case 3:
				return;
			case 1:
				if (rect.Width == 0.0)
				{
					return;
				}
				if (rect.Height == 0.0)
				{
					num2 = 3;
					break;
				}
				switchSymbolNotFound = TigerTrade.Properties.Resources.SwitchSymbolNotFound;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void kQpf15pPeia(bool P_0)
	{
		try
		{
			DmXf1evtHsB.Set(lh5oFFD7RspijFENsCSe(HwndHost));
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					if (base.DataProvider != null)
					{
						H13fS8q8euf(DmXf1evtHsB, P_0);
						break;
					}
					goto case 3;
				case 3:
					DmXf1evtHsB.Clear(base.Theme.BackColor);
					if (LpquriD76PmgvST2BKUj(base.TradingSettings) && tQ7tmAD7MbnGv7YmNixB(j18iDj9nukSCmEyZs5lH.Settings) != Hk7JwA95f4JE5NL4LAvU.i2395GcKgay)
					{
						s3Zf113WHBU(DmXf1evtHsB);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				case 1:
					break;
				case 0:
					return;
				}
				HwndHost.Render(DmXf1evtHsB, null);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num = 0;
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	private void RBNf1STdMFc(object P_0, SizeChangedEventArgs P_1)
	{
		LotWidget.rSuHncCBT0a();
	}

	public override void NeedRedraw(bool P_0 = false)
	{
		HwndHost.InvalidateVisual(P_0);
	}

	public void HfYf1xAYqQ7()
	{
		HwndHost.OnTimerTick -= xaUf1kjwSdp;
		HwndHost.OnRenderVisual -= kQpf15pPeia;
		HwndHost.SizeChanged -= RBNf1STdMFc;
		HwndHost.Dispose();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void juif1L9ghbr()
	{
		LotWidget.CloseEditViewCommand.Execute(null);
	}

	private void MarketOnMouseEnter(object sender, MouseEventArgs e)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 2:
			{
				TradingSettings tradingSettings = base.TradingSettings;
				if (tradingSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = tradingSettings.MarketSettings;
				break;
			}
			case 3:
				DoWvGkD7Isn9uTvHDGa0(((KedBU3f05IsrqcZmlPn5)xErtyaD7qrovxZWfFwJC()).AdjPresetSizeViaScroll);
				ivItrRD7WVRlkDRobkqd(w4ghJID7OdmZcP6eBexr(base.TradingSettings), false);
				return;
			case 0:
				return;
			case 1:
				obj = null;
				break;
			}
			if (obj != null)
			{
				if (!((MarketSettings)w4ghJID7OdmZcP6eBexr(base.TradingSettings)).PresetAdjViaScrollMode || vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().AdjPresetSizeViaScroll.Check())
				{
					break;
				}
				num2 = 3;
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!uOTf1c6ucUI)
		{
			uOTf1c6ucUI = true;
			Uri resourceLocator = new Uri((string)JWQ2fYD7t5UClMVIt0Ry(0xECA3F28 ^ 0xECE24D2), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 1:
			MarketEngineControlName = (mrGdQof1Dl8Jsg7DRfOq)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			LotWidget = (ROKWRrHnlCLqN5xmrZo0)P_1;
			break;
		default:
			uOTf1c6ucUI = true;
			break;
		case 2:
			{
				HwndHost = (DxHwndHost)P_1;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 0;
				}
				goto IL_0009;
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

	static mrGdQof1Dl8Jsg7DRfOq()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool raoacBD7XHXmFc25gYpD()
	{
		return g0Pkc5D7sW5sHMlr9KSN == null;
	}

	internal static mrGdQof1Dl8Jsg7DRfOq GAFV5fD7caRn7WMG2kB0()
	{
		return g0Pkc5D7sW5sHMlr9KSN;
	}

	internal static object EeNqtcD7j0m9sCL0hIZZ()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static void R5FyMJD7EIRcThVe9p53(object P_0, int P_1)
	{
		((DxHwndHost)P_0).StartTimer(P_1);
	}

	internal static void n82P76D7Ql2LrhERIG8P(object P_0, double P_1)
	{
		((ROKWRrHnlCLqN5xmrZo0)P_0).LeftOffset = P_1;
	}

	internal static int rLePGGD7d8Ci3yCXGSBf(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameFontSize;
	}

	internal static void TSTHIWD7gOuAhbbDZpPH(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawStrings((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static Rect lh5oFFD7RspijFENsCSe(object P_0)
	{
		return ((DxHwndHost)P_0).ClientRect;
	}

	internal static bool LpquriD76PmgvST2BKUj(object P_0)
	{
		return ((TradingSettings)P_0).IsSymbolSwitchError;
	}

	internal static Hk7JwA95f4JE5NL4LAvU tQ7tmAD7MbnGv7YmNixB(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).NoMarketTypeMode;
	}

	internal static object w4ghJID7OdmZcP6eBexr(object P_0)
	{
		return ((TradingSettings)P_0).MarketSettings;
	}

	internal static object xErtyaD7qrovxZWfFwJC()
	{
		return vspL39fH6Hd69qemUHrA.YXwfHUcZiBY();
	}

	internal static void DoWvGkD7Isn9uTvHDGa0(object P_0)
	{
		vspL39fH6Hd69qemUHrA.xCYfHqyUP6y((UQpOEF95Pl27GeSpKZ6s)P_0);
	}

	internal static void ivItrRD7WVRlkDRobkqd(object P_0, bool value)
	{
		((MarketSettings)P_0).PresetAdjViaScrollMode = value;
	}

	internal static object JWQ2fYD7t5UClMVIt0Ry(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
