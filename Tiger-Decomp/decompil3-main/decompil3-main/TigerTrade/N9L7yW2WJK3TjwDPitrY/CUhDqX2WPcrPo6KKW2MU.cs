using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Docking;
using ECOEgqlSad8NUJZ2Dr9n;
using g30OaY2q1xL3L3DCMU4V;
using jrVHBO2tB45VdH0ZIih4;
using NOhwrI2WISbYksEUI9XB;
using ocMo2C2OFi7RLs2TMtAp;
using OWUMXkHkWgCUprHQ3jb9;
using pu8i3x2qxWou7Y2yhIuQ;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace N9L7yW2WJK3TjwDPitrY;

internal class CUhDqX2WPcrPo6KKW2MU : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private ruI5XW2OJpKMlnG7xFDS zCE2tnueLtF;

	private string jfK2tGvcbvl;

	private bool gdB2tY6d4r9;

	internal AdvancedTabControl AdvancedTabControl;

	internal AdvancedTabItem MainTab;

	internal q3y5ol2tvutj2ObxUZJH Target1;

	private bool w1S2tow26Ih;

	private static CUhDqX2WPcrPo6KKW2MU cew0cc436onYqgZXXiB7;

	public string StrategyName
	{
		get
		{
			return jfK2tGvcbvl;
		}
		set
		{
			if (!(text == jfK2tGvcbvl))
			{
				jfK2tGvcbvl = text;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342690528));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
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

	public bool LinkToSymbol
	{
		get
		{
			return gdB2tY6d4r9;
		}
		set
		{
			if (flag != gdB2tY6d4r9)
			{
				gdB2tY6d4r9 = flag;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46623835));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
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

	public CUhDqX2WPcrPo6KKW2MU()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void StrategySetupWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
		StrategyName = (string)QgQm3C43qZeCNfNXW1c9(zCE2tnueLtF);
		LinkToSymbol = zCE2tnueLtF.LinkToSymbol;
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		case 1:
			return;
		}
		using List<qfL3oI2qS67RcmXFC7LV>.Enumerator enumerator = zCE2tnueLtF.j432qaUATBv.GetEnumerator();
		qfL3oI2qS67RcmXFC7LV current = default(qfL3oI2qS67RcmXFC7LV);
		while (true)
		{
			int num3;
			if (!enumerator.MoveNext())
			{
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
				{
					num3 = 0;
				}
			}
			else
			{
				current = enumerator.Current;
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
				{
					num3 = 0;
				}
			}
			while (true)
			{
				switch (num3)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					num++;
					if (num != 1)
					{
						goto IL_0089;
					}
					OlX2WFDC0k2(Target1, current);
					break;
				case 3:
					break;
				case 2:
					goto IL_0089;
				}
				break;
				IL_0089:
				q3y5ol2tvutj2ObxUZJH q3y5ol2tvutj2ObxUZJH = new q3y5ol2tvutj2ObxUZJH();
				OlX2WFDC0k2(q3y5ol2tvutj2ObxUZJH, current);
				AdvancedTabItem newItem = new AdvancedTabItem
				{
					Content = q3y5ol2tvutj2ObxUZJH,
					CanClose = true,
					Header = zMtsqb43Ie3nFdaEngiP(TigerTrade.Properties.Resources.StrategySetupWindowTarget, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53774322), (AdvancedTabControl.Items.Count + 1).ToString())
				};
				AdvancedTabControl.Items.Add(newItem);
				int num4 = 3;
				num3 = num4;
			}
		}
	}

	private void OlX2WFDC0k2(q3y5ol2tvutj2ObxUZJH P_0, qfL3oI2qS67RcmXFC7LV P_1)
	{
		fSPaYe43Wawxiesdcmc4(P_0, P_1.QuantityIsEnabled);
		P_0.Quantity = P_1.Quantity;
		int num = 8;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				P_0.StopLossTrailingStep.PercentValue = P_1.US02Is5KhM7;
				BtlsCf433imWa4ObVZrl(P_0.StopLossBreakeven, aYJRvi43FM5X9IWihJe7(P_1));
				num = 7;
				break;
			case 2:
				B5KcxZ43ZCeoKRdcMW3Y(P_0.StopLossBreakeven, zUM7XA43hGHpOt7D88ZJ(P_1));
				num = 6;
				break;
			case 7:
				P_0.StopLossBreakevenPlus.PercentValue = P_1.L0r2IqWp0vj;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 0;
				}
				break;
			case 5:
				acx57I43t2JSsdICIJQe(P_0.StopLoss, P_1.StopLossValueType);
				((S4bA972WqWNc8NF1tOvl)b3LaWg43UAWlRFAUXCTX(P_0)).ValueType = RrF9qh43TBYa1Zqm8CmN(P_1);
				P_0.StopLossTrailingStep.ValueType = IVvifj43yHsK5mtVLbAN(P_1);
				P_0.StopLossBreakeven.ValueType = P_1.iti2IjKpxAC;
				P_0.StopLossBreakevenPlus.ValueType = P_1.q9c2I6qesjw;
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num = 1;
				}
				break;
			case 4:
				P_0.StopLossTrailingStep.AbsoluteValue = On57Gf43mrfjKyRbEtsf(P_1);
				num = 2;
				break;
			case 9:
				P_0.TakeProfitTrailing.AbsoluteValue = P_1.csw2qqPbHuC;
				P_0.StopLoss.IsEnabled = P_1.uZ82qtGpqay;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num = 3;
				}
				break;
			case 8:
				P_0.TakeProfit.ValueType = P_1.Ueu2qz9exDH;
				P_0.TakeProfitTrailing.ValueType = P_1.uFa2InO8QEu;
				num = 5;
				break;
			case 6:
				YWMgvF438GjLQoi9iIOv(iAbfl543wRhkExb5Niwx(P_0), BSK5aX437hMRs9tOw8RR(P_1));
				num = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				oJ0Vh243rp8qF36ocbVE(P_0.StopLoss, lS3wmg43CXJsYm5LYEqs(P_1));
				P_0.StopLossTrailing.IsEnabled = P_1.HQJ2qVGg4w4;
				P_0.StopLossTrailing.AbsoluteValue = TBBOAn43KjCFfnkQC8eb(P_1);
				num = 4;
				break;
			case 11:
				((S4bA972WqWNc8NF1tOvl)u1mEbe43Ad4MQXRhckjP(P_0)).AbsoluteValue = P_1.StopLossBreakevenPlus;
				P_0.TakeProfit.PercentValue = x8b5dU43P1h6rB3jRkbc(P_1);
				P_0.TakeProfitTrailing.PercentValue = P_1.a7U2IoHZ0HI;
				((S4bA972WqWNc8NF1tOvl)jBRMMH43JX9GujFe1Yvo(P_0)).PercentValue = P_1.Fi32Il3vvUY;
				P_0.StopLossTrailing.PercentValue = P_1.Uqr2I1BGcDL;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 10:
				B5KcxZ43ZCeoKRdcMW3Y(P_0.TakeProfit, P_1.wTp2qEQgsb3);
				P_0.TakeProfit.AbsoluteValue = P_1.TakeProfitSize;
				P_0.TakeProfitTrailing.IsEnabled = WiUV9S43Vj8RFFwpUBlv(P_1);
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num = 9;
				}
				break;
			}
		}
	}

	private void BuK2W3MnxCS(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		zCE2tnueLtF.StrategyName = StrategyName;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
		{
			num = 0;
		}
		IEnumerator<AdvancedTabItem> enumerator = default(IEnumerator<AdvancedTabItem>);
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						q3y5ol2tvutj2ObxUZJH q3y5ol2tvutj2ObxUZJH;
						while (true)
						{
							q3y5ol2tvutj2ObxUZJH = anEKBs43zcFyRTHONvoy(enumerator.Current) as q3y5ol2tvutj2ObxUZJH;
							int num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
							{
								num2 = 1;
							}
							switch (num2)
							{
							default:
								continue;
							case 1:
								break;
							}
							break;
						}
						if (q3y5ol2tvutj2ObxUZJH != null)
						{
							qfL3oI2qS67RcmXFC7LV obj = new qfL3oI2qS67RcmXFC7LV
							{
								QuantityIsEnabled = q3y5ol2tvutj2ObxUZJH.QuantityIsEnabled,
								Quantity = q3y5ol2tvutj2ObxUZJH.Quantity,
								Ueu2qz9exDH = q3y5ol2tvutj2ObxUZJH.TakeProfit.ValueType,
								uFa2InO8QEu = q3y5ol2tvutj2ObxUZJH.TakeProfitTrailing.ValueType,
								StopLossValueType = NXf8SB4p0ImcsPu3V9ss(q3y5ol2tvutj2ObxUZJH.StopLoss)
							};
							JfFP254p2FmJRiILj9r3(obj, NXf8SB4p0ImcsPu3V9ss(q3y5ol2tvutj2ObxUZJH.StopLossTrailing));
							obj.zx32IxMQW5N = ((S4bA972WqWNc8NF1tOvl)HE4EOT4pH4nTmUoYs5wl(q3y5ol2tvutj2ObxUZJH)).ValueType;
							obj.iti2IjKpxAC = q3y5ol2tvutj2ObxUZJH.StopLossBreakeven.ValueType;
							fQ3Ekv4pfJJdhLQFAPHA(obj, q3y5ol2tvutj2ObxUZJH.StopLossBreakevenPlus.ValueType);
							obj.wTp2qEQgsb3 = q3y5ol2tvutj2ObxUZJH.TakeProfit.IsEnabled;
							obj.TakeProfitSize = ji5ylA4pnrgG8Vwl3V2p(y6wyUK4p9StbO2mir66k(q3y5ol2tvutj2ObxUZJH));
							obj.soh2q6jt0yi = UAOLxY4pGR89tmxZ1fwY(q3y5ol2tvutj2ObxUZJH.TakeProfitTrailing);
							obj.csw2qqPbHuC = ((S4bA972WqWNc8NF1tOvl)bIB0ty4pYTGCrvCkwvRK(q3y5ol2tvutj2ObxUZJH)).AbsoluteValue;
							obj.uZ82qtGpqay = ((S4bA972WqWNc8NF1tOvl)jBRMMH43JX9GujFe1Yvo(q3y5ol2tvutj2ObxUZJH)).IsEnabled;
							obj.StopLossSize = q3y5ol2tvutj2ObxUZJH.StopLoss.AbsoluteValue;
							obj.HQJ2qVGg4w4 = q3y5ol2tvutj2ObxUZJH.StopLossTrailing.IsEnabled;
							l7wwW04poSw2iVXDygnL(obj, q3y5ol2tvutj2ObxUZJH.StopLossTrailing.AbsoluteValue);
							TrsYEj4pvTDRENAGyhOu(obj, ji5ylA4pnrgG8Vwl3V2p(q3y5ol2tvutj2ObxUZJH.StopLossTrailingStep));
							obj.dpG2q8Tdq3Q = q3y5ol2tvutj2ObxUZJH.StopLossBreakeven.IsEnabled;
							obj.hYW2qJK2vSk = q3y5ol2tvutj2ObxUZJH.StopLossBreakeven.AbsoluteValue;
							obj.StopLossBreakevenPlus = ji5ylA4pnrgG8Vwl3V2p(q3y5ol2tvutj2ObxUZJH.StopLossBreakevenPlus);
							obj.vfg2IHeCi5h = q3y5ol2tvutj2ObxUZJH.TakeProfit.PercentValue;
							RryEOP4paFq1T8fvEgJN(obj, vr960A4pBaIg62H4QiP3(q3y5ol2tvutj2ObxUZJH.TakeProfitTrailing));
							AFjrfk4piHJVObcxpHYu(obj, q3y5ol2tvutj2ObxUZJH.StopLoss.PercentValue);
							obj.Uqr2I1BGcDL = q3y5ol2tvutj2ObxUZJH.StopLossTrailing.PercentValue;
							obj.US02Is5KhM7 = vr960A4pBaIg62H4QiP3(q3y5ol2tvutj2ObxUZJH.StopLossTrailingStep);
							obj.tQC2IdfvOK1 = q3y5ol2tvutj2ObxUZJH.StopLossBreakeven.PercentValue;
							obj.L0r2IqWp0vj = vr960A4pBaIg62H4QiP3(q3y5ol2tvutj2ObxUZJH.StopLossBreakevenPlus);
							qfL3oI2qS67RcmXFC7LV item = obj;
							zCE2tnueLtF.j432qaUATBv.Add(item);
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						fCD7OF4pl71PC2UeurV0(enumerator);
					}
				}
				Close();
				num = 2;
				break;
			default:
				zNMxSp43p6pv3bDycFEK(zCE2tnueLtF, LinkToSymbol);
				QKB8QZ43u4n2MJtBZtk1(zCE2tnueLtF.j432qaUATBv);
				enumerator = AdvancedTabControl.Items.Cast<AdvancedTabItem>().GetEnumerator();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void iLf2WpVsWhg(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	public static bool PiL2WuQgRWM(Window P_0, ruI5XW2OJpKMlnG7xFDS P_1)
	{
		CUhDqX2WPcrPo6KKW2MU cUhDqX2WPcrPo6KKW2MU = new CUhDqX2WPcrPo6KKW2MU();
		G31WUn4p4GJlls7kTUKQ(cUhDqX2WPcrPo6KKW2MU, P_0);
		cUhDqX2WPcrPo6KKW2MU.zCE2tnueLtF = P_1;
		return cUhDqX2WPcrPo6KKW2MU.ShowDialog() == true;
	}

	private void K7m2Wz1Ly9I(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		AdvancedTabItem advancedTabItem = default(AdvancedTabItem);
		while (true)
		{
			switch (num2)
			{
			default:
				AdvancedTabControl.Items.Add(advancedTabItem);
				FJdPC44pNMKKM6NswsHN(advancedTabItem, true);
				return;
			case 1:
			{
				AdvancedTabItem obj = new AdvancedTabItem
				{
					Content = new q3y5ol2tvutj2ObxUZJH()
				};
				nUKat14pDjubZ681926m(obj, true);
				obj.Header = TigerTrade.Properties.Resources.StrategySetupWindowTarget + (string)Gdx57q4pb5kJ2fgFn9ga(-1461949456 ^ -1461958070) + (AdvancedTabControl.Items.Count + 1);
				advancedTabItem = obj;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void J1L2t0iVRMm(object P_0, AdvancedTabItemEventArgs P_1)
	{
		int num = 0;
		IEnumerator<AdvancedTabItem> enumerator = AdvancedTabControl.Items.Cast<AdvancedTabItem>().GetEnumerator();
		try
		{
			AdvancedTabItem current = default(AdvancedTabItem);
			while (true)
			{
				int num2;
				if (!enumerator.MoveNext())
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					current = enumerator.Current;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
					{
						num2 = 1;
					}
				}
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!object.Equals(current, hunHye4pkZ4Pulq9ycAp(P_1)))
					{
						num++;
						current.Header = TigerTrade.Properties.Resources.StrategySetupWindowTarget + (string)Gdx57q4pb5kJ2fgFn9ga(0x3544E813 ^ 0x3544C9A9) + num;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				fCD7OF4pl71PC2UeurV0(enumerator);
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!w1S2tow26Ih)
		{
			w1S2tow26Ih = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri((string)Gdx57q4pb5kJ2fgFn9ga(0x12620268 ^ 0x1262CCDE), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)eoiiJP4p1YTHZLhq7gto(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			MainTab = (AdvancedTabItem)P_1;
			num = 3;
			goto IL_0009;
		case 5:
			((Button)P_1).Click += iLf2WpVsWhg;
			break;
		case 4:
			((Button)P_1).Click += BuK2W3MnxCS;
			num = 2;
			goto IL_0009;
		default:
			w1S2tow26Ih = true;
			break;
		case 3:
			Target1 = (q3y5ol2tvutj2ObxUZJH)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			{
				AdvancedTabControl = (AdvancedTabControl)P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 2:
				break;
			case 1:
				YDqSFP4p5FJe2ATNy8c1(AdvancedTabControl, new EventHandler(K7m2Wz1Ly9I));
				AdvancedTabControl.TabClosing += J1L2t0iVRMm;
				break;
			case 0:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	static CUhDqX2WPcrPo6KKW2MU()
	{
		K4eTvg4pS21PbD2pmJ1G();
	}

	internal static bool CiSm9643MGn1fQsus32Z()
	{
		return cew0cc436onYqgZXXiB7 == null;
	}

	internal static CUhDqX2WPcrPo6KKW2MU N1mu2r43O2hh7Pkva4dt()
	{
		return cew0cc436onYqgZXXiB7;
	}

	internal static object QgQm3C43qZeCNfNXW1c9(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).StrategyName;
	}

	internal static object zMtsqb43Ie3nFdaEngiP(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void fSPaYe43Wawxiesdcmc4(object P_0, bool P_1)
	{
		((q3y5ol2tvutj2ObxUZJH)P_0).QuantityIsEnabled = P_1;
	}

	internal static void acx57I43t2JSsdICIJQe(object P_0, Gj4CGR2qkJAGuEwyLmy3 P_1)
	{
		((S4bA972WqWNc8NF1tOvl)P_0).ValueType = P_1;
	}

	internal static object b3LaWg43UAWlRFAUXCTX(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).StopLossTrailing;
	}

	internal static Gj4CGR2qkJAGuEwyLmy3 RrF9qh43TBYa1Zqm8CmN(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).Ekt2IbSNbp7;
	}

	internal static Gj4CGR2qkJAGuEwyLmy3 IVvifj43yHsK5mtVLbAN(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).zx32IxMQW5N;
	}

	internal static void B5KcxZ43ZCeoKRdcMW3Y(object P_0, bool P_1)
	{
		((S4bA972WqWNc8NF1tOvl)P_0).IsEnabled = P_1;
	}

	internal static bool WiUV9S43Vj8RFFwpUBlv(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).soh2q6jt0yi;
	}

	internal static decimal lS3wmg43CXJsYm5LYEqs(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).StopLossSize;
	}

	internal static void oJ0Vh243rp8qF36ocbVE(object P_0, decimal P_1)
	{
		((S4bA972WqWNc8NF1tOvl)P_0).Value = P_1;
	}

	internal static decimal TBBOAn43KjCFfnkQC8eb(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).DO02qKjTSE2;
	}

	internal static decimal On57Gf43mrfjKyRbEtsf(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).StopLossTrailingStep;
	}

	internal static bool zUM7XA43hGHpOt7D88ZJ(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).dpG2q8Tdq3Q;
	}

	internal static object iAbfl543wRhkExb5Niwx(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).StopLossBreakeven;
	}

	internal static decimal BSK5aX437hMRs9tOw8RR(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).hYW2qJK2vSk;
	}

	internal static void YWMgvF438GjLQoi9iIOv(object P_0, decimal P_1)
	{
		((S4bA972WqWNc8NF1tOvl)P_0).AbsoluteValue = P_1;
	}

	internal static object u1mEbe43Ad4MQXRhckjP(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).StopLossBreakevenPlus;
	}

	internal static decimal x8b5dU43P1h6rB3jRkbc(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).vfg2IHeCi5h;
	}

	internal static object jBRMMH43JX9GujFe1Yvo(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).StopLoss;
	}

	internal static decimal aYJRvi43FM5X9IWihJe7(object P_0)
	{
		return ((qfL3oI2qS67RcmXFC7LV)P_0).tQC2IdfvOK1;
	}

	internal static void BtlsCf433imWa4ObVZrl(object P_0, decimal P_1)
	{
		((S4bA972WqWNc8NF1tOvl)P_0).PercentValue = P_1;
	}

	internal static void zNMxSp43p6pv3bDycFEK(object P_0, bool P_1)
	{
		((ruI5XW2OJpKMlnG7xFDS)P_0).LinkToSymbol = P_1;
	}

	internal static void QKB8QZ43u4n2MJtBZtk1(object P_0)
	{
		((List<qfL3oI2qS67RcmXFC7LV>)P_0).Clear();
	}

	internal static object anEKBs43zcFyRTHONvoy(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}

	internal static Gj4CGR2qkJAGuEwyLmy3 NXf8SB4p0ImcsPu3V9ss(object P_0)
	{
		return ((S4bA972WqWNc8NF1tOvl)P_0).ValueType;
	}

	internal static void JfFP254p2FmJRiILj9r3(object P_0, Gj4CGR2qkJAGuEwyLmy3 P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).Ekt2IbSNbp7 = P_1;
	}

	internal static object HE4EOT4pH4nTmUoYs5wl(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).StopLossTrailingStep;
	}

	internal static void fQ3Ekv4pfJJdhLQFAPHA(object P_0, Gj4CGR2qkJAGuEwyLmy3 P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).q9c2I6qesjw = P_1;
	}

	internal static object y6wyUK4p9StbO2mir66k(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).TakeProfit;
	}

	internal static decimal ji5ylA4pnrgG8Vwl3V2p(object P_0)
	{
		return ((S4bA972WqWNc8NF1tOvl)P_0).AbsoluteValue;
	}

	internal static bool UAOLxY4pGR89tmxZ1fwY(object P_0)
	{
		return ((S4bA972WqWNc8NF1tOvl)P_0).IsEnabled;
	}

	internal static object bIB0ty4pYTGCrvCkwvRK(object P_0)
	{
		return ((q3y5ol2tvutj2ObxUZJH)P_0).TakeProfitTrailing;
	}

	internal static void l7wwW04poSw2iVXDygnL(object P_0, decimal P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).DO02qKjTSE2 = P_1;
	}

	internal static void TrsYEj4pvTDRENAGyhOu(object P_0, decimal P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).StopLossTrailingStep = P_1;
	}

	internal static decimal vr960A4pBaIg62H4QiP3(object P_0)
	{
		return ((S4bA972WqWNc8NF1tOvl)P_0).PercentValue;
	}

	internal static void RryEOP4paFq1T8fvEgJN(object P_0, decimal P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).a7U2IoHZ0HI = P_1;
	}

	internal static void AFjrfk4piHJVObcxpHYu(object P_0, decimal P_1)
	{
		((qfL3oI2qS67RcmXFC7LV)P_0).Fi32Il3vvUY = P_1;
	}

	internal static void fCD7OF4pl71PC2UeurV0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void G31WUn4p4GJlls7kTUKQ(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static void nUKat14pDjubZ681926m(object P_0, bool P_1)
	{
		((AdvancedTabItem)P_0).CanClose = P_1;
	}

	internal static object Gdx57q4pb5kJ2fgFn9ga(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void FJdPC44pNMKKM6NswsHN(object P_0, bool P_1)
	{
		((TabItem)P_0).IsSelected = P_1;
	}

	internal static object hunHye4pkZ4Pulq9ycAp(object P_0)
	{
		return ((AdvancedTabItemEventArgs)P_0).TabItem;
	}

	internal static object eoiiJP4p1YTHZLhq7gto(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void YDqSFP4p5FJe2ATNy8c1(object P_0, object P_1)
	{
		((AdvancedTabControl)P_0).NewTabRequested += (EventHandler)P_1;
	}

	internal static void K4eTvg4pS21PbD2pmJ1G()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
