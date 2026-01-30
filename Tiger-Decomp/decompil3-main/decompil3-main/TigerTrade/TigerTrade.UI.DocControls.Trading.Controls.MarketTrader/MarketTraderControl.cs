using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bl7Or1fDrLHNeTtGhT82;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using JPaDuU2m753Y01hck4QD;
using LKPssPfwOEBXRql5l3eT;
using lYnHpK20R1M7D7DHOK9Z;
using M7Qhok2zS37wTYN0rqJn;
using N9L7yW2WJK3TjwDPitrY;
using NjRsCt2WsDfbeZXtjdEb;
using nWrTsb2WBR9N8EXoRT6F;
using ocMo2C2OFi7RLs2TMtAp;
using PosIhkfBXsapbL9iTTDK;
using pxn4IO9xknWTjdUGV7xW;
using TigerTrade.Chart.Trading;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Controls.Notifications;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using V9ObVI9gCxZjgUce1Uw4;
using Vs7D1ifgOBnFeIIPKkYP;
using waDpctGJom9MvAveNXHq;
using wse3wd2zgF9O4VW2DUfZ;

namespace TigerTrade.UI.DocControls.Trading.Controls.MarketTrader;

internal sealed class MarketTraderControl : aUQvKjHk6H77hbYGG0GM, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private sealed class Rjye4snd0mqhCsdU2uTx
	{
		public string dC1ndou5Yyt;

		public string FVxndvvQ95u;

		public string VCHndBJmuep;

		internal static Rjye4snd0mqhCsdU2uTx Q3uTIqNlmDIZGtMliMFP;

		public Rjye4snd0mqhCsdU2uTx()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool G4bnd2rdhZH(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return syeZDUNl8i2TSGKadP2A(xBKLoRNl73fe5DTX8aA4(f), dC1ndou5Yyt);
		}

		internal bool EK1ndHp01Mc(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == FVxndvvQ95u;
		}

		internal bool eZMndflT7Mj(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == VCHndBJmuep;
		}

		internal bool BDtnd9BZjQb(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == FVxndvvQ95u;
		}

		internal bool SQXndnmkNJq(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == VCHndBJmuep;
		}

		internal bool uV1ndGeKggx(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return (string)xBKLoRNl73fe5DTX8aA4(f) == VCHndBJmuep;
		}

		internal bool Pr9ndYYLjID(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == VCHndBJmuep;
		}

		static Rjye4snd0mqhCsdU2uTx()
		{
			pLYHExNlAX3psW8pvJvl();
		}

		internal static bool vBGWySNlhirKxa5Hf5mM()
		{
			return Q3uTIqNlmDIZGtMliMFP == null;
		}

		internal static Rjye4snd0mqhCsdU2uTx nchSfrNlwQkkUgurksHS()
		{
			return Q3uTIqNlmDIZGtMliMFP;
		}

		internal static object xBKLoRNl73fe5DTX8aA4(object P_0)
		{
			return ((ex6KFw2WejF3Y0Rqo9YD)P_0).nQA2WjKj8f2();
		}

		internal static bool syeZDUNl8i2TSGKadP2A(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void pLYHExNlAX3psW8pvJvl()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private Symbol _symbol;

	internal DoubleEditBox SelectSizeEditBox;

	private bool _contentLoaded;

	internal static MarketTraderControl o3vIIH4QMQr5lpZRVPtb;

	public z48ObB20gSriKUfj18p3 ViewModel { get; private set; }

	public event Action<j3bgDY9gV2i9bttJ1fiQ> Command;

	public MarketTraderControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				T16LbD2WvuEJJRkHuI6J.ai72W1pJ0bT(BuildStrategiesList);
				RsVVe74QWxbkMB0J9PHN(j18iDj9nukSCmEyZs5lH.Settings, new PropertyChangedEventHandler(OnSettingsPropertyChanged));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
				{
					num = 0;
				}
				break;
			default:
				base.Unloaded += OnUnloaded;
				return;
			case 2:
				ViewModel = new z48ObB20gSriKUfj18p3();
				xyrgUw4QIOU442QxrdUY(this, false);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		T16LbD2WvuEJJRkHuI6J.hZj2W5hjdnu(BuildStrategiesList);
		j18iDj9nukSCmEyZs5lH.Settings.PropertyChanged -= OnSettingsPropertyChanged;
	}

	private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs args)
	{
		string text = (string)wWjw5T4QtSEPNQBvbGk3(args);
		int num;
		if (AbsZTB4QTNGXC0Mlmf3t(text, vt8wyn4QUiObOGijDBl0(-1878953018 ^ -1878982160)))
		{
			ViewModel.JZYHkZsWiJ6((string)vt8wyn4QUiObOGijDBl0(-338769610 ^ -338801420));
			ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009549395));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
			{
				num = 1;
			}
		}
		else
		{
			if (!(text == (string)vt8wyn4QUiObOGijDBl0(--871424829 ^ 0x33F066B3)))
			{
				return;
			}
			SaveExitStrategy();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
			{
				num = 3;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ViewModel.JZYHkZsWiJ6((string)vt8wyn4QUiObOGijDBl0(-602153869 ^ -602187391));
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x7065C7F9));
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x7065C7D1));
				num = 4;
				break;
			case 3:
				return;
			case 4:
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD538C5));
				num = 2;
				break;
			case 0:
				return;
			case 2:
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F06507));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void SetSettings(TradingSettings settings)
	{
		FkXnHB4QyjTZ9vRlfMoH(ViewModel, settings);
		BuildStrategiesList();
	}

	public void SetSymbol(Symbol symbol)
	{
		DjnRiB4QZjWfhMcBquyE(ViewModel, symbol.ID);
		ViewModel.Exchange = symbol.Exchange;
		_symbol = symbol;
		BuildStrategiesList();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void ButtonSize1_Click(object sender, RoutedEventArgs e)
	{
		ViewModel.zIa20y3bbIQ(1);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize2_Click(object sender, RoutedEventArgs e)
	{
		H2NRAC4QVVmRmVlQViPh(ViewModel, 2);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize3_Click(object sender, RoutedEventArgs e)
	{
		ViewModel.zIa20y3bbIQ(3);
		MD8QGp4QCFKYbhKaILO4(SelectSizeEditBox, false);
	}

	private void ButtonSize4_Click(object sender, RoutedEventArgs e)
	{
		ViewModel.zIa20y3bbIQ(4);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize5_Click(object sender, RoutedEventArgs e)
	{
		H2NRAC4QVVmRmVlQViPh(ViewModel, 5);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonCommand_Click(object sender, RoutedEventArgs e)
	{
		Button button = (Button)e.OriginalSource;
		if (!(button.CommandParameter is string))
		{
			return;
		}
		int num = 33;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
		{
			num = 10;
		}
		uint num2 = default(uint);
		string text = default(string);
		double sizeInBase2 = default(double);
		double sizeInBase6 = default(double);
		double sizeInBase4 = default(double);
		double sizeInBase3 = default(double);
		while (true)
		{
			int num3;
			switch (num)
			{
			case 32:
				return;
			case 17:
				return;
			case 1:
				return;
			case 35:
				if (num2 == 1957576550 && AbsZTB4QTNGXC0Mlmf3t(text, vt8wyn4QUiObOGijDBl0(-198991962 ^ -199026178)) && TryGetCurrentSizeInBase(X0cJ5g4QmDyGbibTVAen(ViewModel), out sizeInBase2))
				{
					num = 36;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num = 42;
					}
					break;
				}
				return;
			case 9:
				return;
			case 24:
				return;
			case 25:
				return;
			case 4:
			{
				if (BuN0yy4QKhuVDFJMbabm(sizeInBase6))
				{
					return;
				}
				Action<j3bgDY9gV2i9bttJ1fiQ> action8 = this.Command;
				if (action8 == null)
				{
					num = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
					{
						num = 6;
					}
					break;
				}
				action8(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(ViewModel.BmN22nt9TaU(), sizeInBase6));
				num3 = 41;
				goto IL_0005;
			}
			case 19:
				return;
			case 16:
				if (num2 == 298017482)
				{
					if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490968988)))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action3 = this.Command;
					if (action3 != null)
					{
						action3(j3bgDY9gV2i9bttJ1fiQ.ReversePosition());
						return;
					}
					num = 8;
				}
				else
				{
					num = 22;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
					{
						num = 1;
					}
				}
				break;
			case 6:
				return;
			case 3:
				num2 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
				if (num2 > 1957576550)
				{
					if (num2 <= 3000236465u)
					{
						if (num2 <= 2476200180u)
						{
							switch (num2)
							{
							case 2476200180u:
								if (!AbsZTB4QTNGXC0Mlmf3t(text, vt8wyn4QUiObOGijDBl0(--737722733 ^ 0x2BF847DF)))
								{
									return;
								}
								num = 10;
								break;
							case 2004852254u:
								if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16AD5FA6))
								{
									Action<j3bgDY9gV2i9bttJ1fiQ> action9 = this.Command;
									if (action9 == null)
									{
										return;
									}
									action9(j3bgDY9gV2i9bttJ1fiQ.CancelAll());
									num = 9;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
									{
										num = 7;
									}
								}
								else
								{
									num = 20;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
									{
										num = 3;
									}
								}
								break;
							default:
								num = 38;
								break;
							}
						}
						else if (num2 == 2628573300u)
						{
							if (AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x6062797F)))
							{
								if (!TryGetCurrentSizeInBase(JZvxLx4Qrr5XILuO7TEg(ViewModel), out var sizeInBase8))
								{
									return;
								}
								if (double.IsInfinity(sizeInBase8))
								{
									num = 5;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
									{
										num = 40;
									}
									break;
								}
								Action<j3bgDY9gV2i9bttJ1fiQ> action10 = this.Command;
								if (action10 == null)
								{
									return;
								}
								action10(j3bgDY9gV2i9bttJ1fiQ.SellLimit(HmLt2m4Qh61xQtVsWKit(ViewModel), sizeInBase8));
								num = 32;
							}
							else
							{
								num = 25;
							}
						}
						else
						{
							num = 11;
						}
						break;
					}
					if (num2 <= 3534501296u)
					{
						if (num2 == 3403315211u)
						{
							if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D18297))
							{
								BuySell(buy: true);
								num = 17;
								break;
							}
							return;
						}
						if (num2 == 3534501296u)
						{
							if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736544548)))
							{
								return;
							}
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
							{
								num = 0;
							}
							break;
						}
						num3 = 39;
					}
					else if (num2 != 3630834884u)
					{
						if (num2 == 3733551141u)
						{
							if (text == (string)vt8wyn4QUiObOGijDBl0(0x7ADBF691 ^ 0x7ADB7037))
							{
								BuySell(buy: false);
							}
							return;
						}
						if (num2 != 4147984405u || !(text == (string)vt8wyn4QUiObOGijDBl0(-2074141628 ^ -2074121398)))
						{
							return;
						}
						Action<j3bgDY9gV2i9bttJ1fiQ> action11 = this.Command;
						if (action11 == null)
						{
							return;
						}
						action11(j3bgDY9gV2i9bttJ1fiQ.CancelAsks());
						num3 = 6;
					}
					else
					{
						if (!(text == (string)vt8wyn4QUiObOGijDBl0(0x735715F1 ^ 0x735768A7)))
						{
							return;
						}
						Action<j3bgDY9gV2i9bttJ1fiQ> action12 = this.Command;
						if (action12 != null)
						{
							action12(j3bgDY9gV2i9bttJ1fiQ.TakeProfit());
							return;
						}
						num3 = 2;
					}
					goto IL_0005;
				}
				num = 31;
				break;
			case 39:
				return;
			case 22:
				return;
			case 45:
				return;
			case 33:
				text = button.CommandParameter.ToString();
				num = 3;
				break;
			case 31:
				if (num2 > 298017482)
				{
					if (num2 <= 1449205056)
					{
						if (num2 == 495788626)
						{
							if (!AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C76C6C)) || !TryGetCurrentSizeInBase(ViewModel.GSX22HWRhWu(), out var sizeInBase5))
							{
								return;
							}
							if (BuN0yy4QKhuVDFJMbabm(sizeInBase5))
							{
								num = 15;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
								{
									num = 15;
								}
								break;
							}
							Action<j3bgDY9gV2i9bttJ1fiQ> action5 = this.Command;
							if (action5 == null)
							{
								return;
							}
							action5(j3bgDY9gV2i9bttJ1fiQ.SellLimit(ViewModel.GSX22HWRhWu(), sizeInBase5));
							num = 18;
							break;
						}
						num3 = 44;
						goto IL_0005;
					}
					switch (num2)
					{
					default:
						num = 35;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
						{
							num = 9;
						}
						break;
					case 1515425823u:
						if (AbsZTB4QTNGXC0Mlmf3t(text, vt8wyn4QUiObOGijDBl0(0x404ED0BE ^ 0x404EA648)))
						{
							this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.CancelBids());
						}
						return;
					case 1548138422u:
						if (AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F05E1)) && TryGetCurrentSizeInBase(JZvxLx4Qrr5XILuO7TEg(ViewModel), out sizeInBase6))
						{
							num = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
							{
								num = 4;
							}
							break;
						}
						return;
					}
					break;
				}
				num = 13;
				break;
			case 34:
			{
				if (double.IsInfinity(sizeInBase4))
				{
					return;
				}
				Action<j3bgDY9gV2i9bttJ1fiQ> action6 = this.Command;
				if (action6 == null)
				{
					num = 12;
					break;
				}
				action6(j3bgDY9gV2i9bttJ1fiQ.SellMarket(sizeInBase4));
				return;
			}
			case 10:
				SetLeverage();
				return;
			case 37:
				return;
			case 13:
				if (num2 <= 209740820)
				{
					if (num2 == 144042150)
					{
						if (!AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADB705D)))
						{
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
							{
								num = 1;
							}
							break;
						}
						TransferFunds();
						num3 = 19;
						goto IL_0005;
					}
					if (num2 == 209740820 && text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73579399) && TryGetCurrentSizeInBase(ViewModel.GSX22HWRhWu(), out var sizeInBase7) && !BuN0yy4QKhuVDFJMbabm(sizeInBase7))
					{
						this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(JZvxLx4Qrr5XILuO7TEg(ViewModel), sizeInBase7));
					}
					return;
				}
				if (num2 != 271173071)
				{
					num = 16;
					break;
				}
				if (text == (string)vt8wyn4QUiObOGijDBl0(0x11D1040B ^ 0x11D1721D))
				{
					if (!TryGetCurrentSizeInBase(ViewModel.GSX22HWRhWu(), out sizeInBase3))
					{
						num = 14;
						break;
					}
					goto case 36;
				}
				num = 29;
				break;
			case 38:
				return;
			case 21:
				if (num2 != 3000236465u || !(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799498805)) || !TryGetCurrentSizeInBase(ViewModel.ObY20z8G50d(), out sizeInBase4))
				{
					return;
				}
				num = 28;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num = 34;
				}
				break;
			case 20:
				return;
			case 41:
				return;
			case 11:
				if (num2 == 2792084858u)
				{
					if (!AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153234161)))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
					if (action2 == null)
					{
						return;
					}
					action2(j3bgDY9gV2i9bttJ1fiQ.StopLoss());
					num = 23;
				}
				else
				{
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
					{
						num = 21;
					}
				}
				break;
			case 14:
				return;
			case 42:
			{
				if (BuN0yy4QKhuVDFJMbabm(sizeInBase2))
				{
					num = 30;
					break;
				}
				Action<j3bgDY9gV2i9bttJ1fiQ> action7 = this.Command;
				if (action7 == null)
				{
					return;
				}
				action7(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(ViewModel.ObY20z8G50d(), sizeInBase2));
				num = 37;
				break;
			}
			case 27:
				return;
			case 36:
				if (double.IsInfinity(sizeInBase3))
				{
					num = 43;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
					{
						num = 26;
					}
					break;
				}
				this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.BuyMarket(sizeInBase3));
				return;
			case 28:
				return;
			case 30:
				return;
			case 43:
				return;
			case 44:
				if (num2 == 1449205056)
				{
					if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1461916280)) || !TryGetCurrentSizeInBase(ViewModel.ObY20z8G50d(), out var sizeInBase) || double.IsInfinity(sizeInBase))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action4 = this.Command;
					if (action4 == null)
					{
						return;
					}
					action4(j3bgDY9gV2i9bttJ1fiQ.SellLimit(X0cJ5g4QmDyGbibTVAen(ViewModel), sizeInBase));
					num = 27;
				}
				else
				{
					num = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num = 23;
					}
				}
				break;
			case 29:
				return;
			case 7:
				return;
			case 12:
				return;
			case 40:
				return;
			case 15:
				return;
			case 18:
				return;
			default:
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
				if (action == null)
				{
					num = 5;
					break;
				}
				action((j3bgDY9gV2i9bttJ1fiQ)PTIH9l4QwjdNMYEaQ2Xh());
				num = 15;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
				{
					num = 26;
				}
				break;
			}
			case 5:
				return;
			case 26:
				return;
			case 8:
				return;
			case 23:
				return;
			case 2:
				return;
				IL_0005:
				num = num3;
				break;
			}
		}
	}

	private bool TryGetCurrentSizeInBase(long price, out double sizeInBase)
	{
		Account account = DataManager.GetAccount(((MarketSettings)oReOw64Q771wwQNEojfb(ViewModel)).Account);
		DataManager.GetLeverage(account?.ConnectionID, _symbol);
		double freeMargin = DataManager.GetFreeMargin((string)((account != null) ? eZqNTy4Q8VAQ64G0Lu8N(account) : null), _symbol);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
		{
			num = 0;
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
				K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6(TigerTrade.Properties.Resources.ResourceManager.GetString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315ACE51)), text, NotificationType.Error));
				goto IL_001b;
			default:
				{
					if (JLFqEJGJYiHaSdoROJXI.UAtGJlwm3mG(_symbol, ViewModel.Settings.ExecuteInQuoteCurrency, ViewModel.Settings.ExecuteInPercents, ViewModel.Leverage ?? (-1.0), freeMargin, QHifHB4QACfOFUXqKB0i(ViewModel), price, out sizeInBase, out text))
					{
						return true;
					}
					if (!string.IsNullOrEmpty(text))
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
						{
							num = 1;
						}
						break;
					}
					goto IL_001b;
				}
				IL_001b:
				return false;
			}
		}
	}

	private void SetLeverage()
	{
		if (ViewModel.Leverage.HasValue)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.SetLeverage(ViewModel.Leverage.Value));
		}
	}

	private void TransferFunds()
	{
		if (!(j18iDj9nukSCmEyZs5lH.Settings.TransferFundsAmount > 0m))
		{
			return;
		}
		Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
		if (action != null)
		{
			action(j3bgDY9gV2i9bttJ1fiQ.TransferFunds(sX4Ybf4QJXBw2li4VP4q(jvNXoo4QPxdM0oOgI1bt()), j18iDj9nukSCmEyZs5lH.Settings.TransferFrom, UBsT7E4QF56rtG3CV1hJ(jvNXoo4QPxdM0oOgI1bt())));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
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

	private void Pnl_OnMouseDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			ViewModel.TradingSettings.MarketSettings.TradeSettings.PnlType = G5WDO0fBspkJC1m1nhXd.uByfBd02EF7(((CR1isWfDCD1A4fwfUJUf)zZkxya4Q3U8X1LtqdwQN(ViewModel.TradingSettings.MarketSettings)).PnlType);
		}
	}

	private void Position_OnMouseDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			HAYGqf4d04pj1rvV1qQj(((MarketSettings)kfa9A94Qu8o9KZbxWOGj(wb7v504Qp7HjD0GfiQBW(ViewModel))).TradeSettings, G5WDO0fBspkJC1m1nhXd.ufJfBENqgtu(RKXaL64QzpBdPes1GoKx(zZkxya4Q3U8X1LtqdwQN(((TradingSettings)wb7v504Qp7HjD0GfiQBW(ViewModel)).MarketSettings))));
		}
	}

	private void BuySell(bool buy)
	{
		Hashtable hashtable = new Hashtable();
		if (ViewModel.OrderHidden && ViewModel.OrderHiddenVisibility == Visibility.Visible)
		{
			hashtable[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838808328)] = ViewModel.OrderHidden;
		}
		int num;
		if (E67RVC4d2HCFjaHEQfDG(ViewModel))
		{
			num = 6;
			goto IL_0009;
		}
		goto IL_0230;
		IL_00a4:
		if (ViewModel.OrderCloseOnly)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_017c;
		IL_017c:
		ChartOrderType chartOrderType = ViewModel.OrderType;
		num = 5;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				break;
			case 9:
				goto end_IL_0009;
			case 4:
				goto IL_0120;
			case 2:
				h6on4B4dHadMZDt66i9S(hashtable, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D17227), ViewModel.OrderReduceOnly);
				num = 9;
				continue;
			case 6:
				if (ViewModel.OrderPostOnlyVisibility == Visibility.Visible)
				{
					hashtable[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063393073)] = ViewModel.OrderPostOnly;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
					{
						num = 1;
					}
					continue;
				}
				goto IL_0230;
			case 1:
				goto IL_0230;
			case 5:
				goto IL_0245;
			case 7:
				return;
			case 0:
				return;
			case 8:
				return;
			}
			if (ViewModel.OrderCloseOnlyVisibility == Visibility.Visible)
			{
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 4;
				}
				continue;
			}
			goto IL_017c;
			IL_0245:
			switch (chartOrderType)
			{
			case ChartOrderType.StopLimit:
				this.Command?.Invoke(buy ? j3bgDY9gV2i9bttJ1fiQ.yqP9g7GncT4(gcTnED4dYC0SFTJ50nxp(ViewModel), ViewModel.OrderPrice2, ViewModel.OrderQuantity, hashtable) : j3bgDY9gV2i9bttJ1fiQ.Acs9gpTgtJW(ViewModel.OrderPrice1, ViewModel.OrderPrice2, ViewModel.OrderQuantity, hashtable));
				return;
			default:
				return;
			case ChartOrderType.Market:
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
				if (action2 == null)
				{
					num = 7;
					break;
				}
				action2((j3bgDY9gV2i9bttJ1fiQ)(buy ? pkvGo44dfVakEy0Qkvjs(ViewModel.OrderQuantity, hashtable) : j3bgDY9gV2i9bttJ1fiQ.twp9gAGPkZw(ViewModel.OrderQuantity, hashtable)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num = 0;
				}
				break;
			}
			case ChartOrderType.Limit:
				this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)(buy ? j3bgDY9gV2i9bttJ1fiQ.I5i9gmr7kNO(ViewModel.OrderPrice1, ViewModel.OrderQuantity, hashtable) : JbBuLm4dnO9mD19peelo(ViewModel.OrderPrice1, fCKwLE4d9rnYC4xNYoV4(ViewModel), hashtable)));
				return;
			case ChartOrderType.Stop:
			{
				Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
				if (action != null)
				{
					action((j3bgDY9gV2i9bttJ1fiQ)(buy ? q0K6l04dogDw4cN6MDgE(gcTnED4dYC0SFTJ50nxp(ViewModel), ViewModel.OrderQuantity, hashtable) : FaoWBv4dGOX0MgqYRpYM(ViewModel.OrderPrice1, ViewModel.OrderQuantity, hashtable)));
					return;
				}
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num = 8;
				}
				break;
			}
			}
			continue;
			IL_0120:
			hashtable[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45443879)] = ViewModel.OrderCloseOnly;
			goto IL_017c;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_00a4;
		IL_0230:
		if (ViewModel.OrderReduceOnly && ViewModel.OrderReduceOnlyVisibility == Visibility.Visible)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00a4;
	}

	private void StrategyButton_Click(object sender, RoutedEventArgs e)
	{
		int num = 1;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2D7CF7))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD53F8B))
					{
						AddStrategy();
						return;
					}
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x60628893))
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 5:
					break;
				case 6:
					if (!AbsZTB4QTNGXC0Mlmf3t(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7FF439)))
					{
						if (text == (string)vt8wyn4QUiObOGijDBl0(-1153206687 ^ -1153175055))
						{
							num2 = 5;
							continue;
						}
					}
					else
					{
						SetupStrategy();
					}
					return;
				case 2:
					ApplyStrategy();
					return;
				case 3:
					RemoveStrategy();
					return;
				case 1:
					text = XmUwfa4dvjLwEeKnHSFS((ButtonBase)sender).ToString();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			SetupTrading();
			num = 4;
		}
	}

	private void SetupTrading()
	{
		jgvOYw2mwtyvDxilWcWk.D3i2m80T8I9(base.ParentWindow, (MarketSettings)oReOw64Q771wwQNEojfb(ViewModel));
	}

	private void ComboBoxExitStrategies_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		SaveExitStrategy();
	}

	private void SaveExitStrategy()
	{
		((CR1isWfDCD1A4fwfUJUf)zZkxya4Q3U8X1LtqdwQN(ViewModel.Settings)).ExitStrategy = ((ex6KFw2WejF3Y0Rqo9YD)Wje2Ao4dB9W1KINWuj1D(ViewModel))?.nQA2WjKj8f2();
	}

	private void ApplyStrategy()
	{
		this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)oJ45rH4daFj4QLpRow3N());
	}

	private void AddStrategy()
	{
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = new ruI5XW2OJpKMlnG7xFDS
		{
			JW82q2WZSBL = Ub489X4di9b1dyZsrrf6().ToString(),
			StrategyName = TigerTrade.Properties.Resources.ChartTraderControlNewStrategy
		};
		if (!CUhDqX2WPcrPo6KKW2MU.PiL2WuQgRWM(base.ParentWindow, ruI5XW2OJpKMlnG7xFDS))
		{
			return;
		}
		int num;
		if (string.IsNullOrEmpty((string)lE6bKs4dlkBJfqGJvBPs(ruI5XW2OJpKMlnG7xFDS)))
		{
			num = 2;
			goto IL_0009;
		}
		goto IL_00dd;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				Odmkcy4d4CAqbZJE0Hur(ruI5XW2OJpKMlnG7xFDS, TigerTrade.Properties.Resources.ChartTraderControlStrategy);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_00dd;
		IL_00dd:
		ruI5XW2OJpKMlnG7xFDS.Ls62qoXGjhk = (Ro0IaZ4dDZAhxetoCMjE(ruI5XW2OJpKMlnG7xFDS) ? ViewModel.Symbol : null);
		T16LbD2WvuEJJRkHuI6J.zAg2W4rIpaO(ruI5XW2OJpKMlnG7xFDS);
		BuildStrategiesList((string)d1uJ5q4dbQSO8pA981wL(ruI5XW2OJpKMlnG7xFDS));
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private void RemoveStrategy()
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
				if (ViewModel.SelectedStrategy != null)
				{
					if (YesNoWindow.ShowWindow(base.ParentWindow, (string)JPw1kL4dNQeAFteCyuBc(), (string)WvKI2T4dklSmZc2O3EgP()))
					{
						T16LbD2WvuEJJRkHuI6J.Remove(ViewModel.SelectedStrategy.nQA2WjKj8f2());
						BuildStrategiesList();
					}
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetupStrategy()
	{
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = ViewModel.SelectedStrategy?.JgL2WdI2A3a();
		int num;
		if (ruI5XW2OJpKMlnG7xFDS == null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 1;
			}
		}
		else
		{
			zgjmWt4d1B7P9yCopi5y(base.ParentWindow, ruI5XW2OJpKMlnG7xFDS);
			ruI5XW2OJpKMlnG7xFDS.Ls62qoXGjhk = (ruI5XW2OJpKMlnG7xFDS.LinkToSymbol ? ViewModel.Symbol : null);
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				T16LbD2WvuEJJRkHuI6J.zAg2W4rIpaO(ruI5XW2OJpKMlnG7xFDS);
				BuildStrategiesList(ruI5XW2OJpKMlnG7xFDS.JW82q2WZSBL);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void SetStrategy(string strategyID)
	{
		BuildStrategiesList(strategyID);
	}

	private void BuildStrategiesList()
	{
		BuildStrategiesList(null);
	}

	private void BuildStrategiesList(string strategyID = "")
	{
		int num = 13;
		Rjye4snd0mqhCsdU2uTx rjye4snd0mqhCsdU2uTx = default(Rjye4snd0mqhCsdU2uTx);
		bool flag = default(bool);
		ex6KFw2WejF3Y0Rqo9YD ex6KFw2WejF3Y0Rqo9YD = default(ex6KFw2WejF3Y0Rqo9YD);
		ruI5XW2OJpKMlnG7xFDS current = default(ruI5XW2OJpKMlnG7xFDS);
		ex6KFw2WejF3Y0Rqo9YD item = default(ex6KFw2WejF3Y0Rqo9YD);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 29;
				case 5:
					if (!string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.dC1ndou5Yyt))
					{
						ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.G4bnd2rdhZH);
						goto case 23;
					}
					if (!flag && !Bid1lk4deoMPEj6cDdLa(rjye4snd0mqhCsdU2uTx.FVxndvvQ95u))
					{
						if (!j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
						{
							num = 30;
							break;
						}
						goto IL_00ef;
					}
					if (flag)
					{
						if (string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.FVxndvvQ95u))
						{
							goto case 26;
						}
						if (!GVuyy34ds8jgXV7mg7TC(jvNXoo4QPxdM0oOgI1bt()))
						{
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 3;
					}
					num2 = 26;
					continue;
				case 15:
					if (((MhMDPU9v8rkigy1ao0Th)jvNXoo4QPxdM0oOgI1bt()).SaveSelectedExitStrategy && !string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						t2jRPf4dXKNQeeThtnU5(ViewModel, ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.uV1ndGeKggx));
						num2 = 23;
						continue;
					}
					goto case 23;
				case 27:
					t2jRPf4dXKNQeeThtnU5(ViewModel, ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.EK1ndHp01Mc));
					num2 = 4;
					continue;
				case 26:
					if (Bid1lk4deoMPEj6cDdLa(rjye4snd0mqhCsdU2uTx.FVxndvvQ95u))
					{
						if (!GVuyy34ds8jgXV7mg7TC(j18iDj9nukSCmEyZs5lH.Settings))
						{
							num2 = 8;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
							{
								num2 = 18;
							}
							continue;
						}
						goto case 29;
					}
					goto case 23;
				case 29:
					if (!j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy)
					{
						num = 16;
						break;
					}
					if (!Bid1lk4deoMPEj6cDdLa(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 12:
					rjye4snd0mqhCsdU2uTx.dC1ndou5Yyt = strategyID;
					if (ViewModel.Settings != null)
					{
						if (vAUDWL4d5WxJgBatEj9y(ViewModel) == null)
						{
							num2 = 8;
							continue;
						}
						rjye4snd0mqhCsdU2uTx.FVxndvvQ95u = ViewModel.SelectedStrategy?.nQA2WjKj8f2();
						rjye4snd0mqhCsdU2uTx.VCHndBJmuep = ((CR1isWfDCD1A4fwfUJUf)zZkxya4Q3U8X1LtqdwQN(ViewModel.Settings)).ExitStrategy;
						if (rjye4snd0mqhCsdU2uTx.FVxndvvQ95u == null)
						{
							num = 24;
							break;
						}
						goto case 19;
					}
					return;
				case 19:
					g4vWfl4dSWnUq6S7RdG6(ViewModel.Strategies);
					num2 = 7;
					continue;
				case 7:
					flag = false;
					num2 = 22;
					continue;
				case 13:
					rjye4snd0mqhCsdU2uTx = new Rjye4snd0mqhCsdU2uTx();
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					if (!GVuyy34ds8jgXV7mg7TC(jvNXoo4QPxdM0oOgI1bt()))
					{
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 28;
				case 20:
					if (!string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						t2jRPf4dXKNQeeThtnU5(ViewModel, ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.Pr9ndYYLjID));
						num2 = 21;
						continue;
					}
					goto case 21;
				case 2:
					if (!string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 23;
				case 23:
				case 25:
					if (ViewModel.SelectedStrategy == null)
					{
						num = 10;
						break;
					}
					return;
				case 1:
					ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.BDtnd9BZjQb);
					goto case 23;
				case 21:
					if (j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && !string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						t2jRPf4dXKNQeeThtnU5(ViewModel, null);
						num2 = 25;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 23;
				case 28:
					if (GVuyy34ds8jgXV7mg7TC(jvNXoo4QPxdM0oOgI1bt()))
					{
						num2 = 2;
						continue;
					}
					goto case 23;
				case 14:
					ViewModel.SelectedStrategy = null;
					num2 = 25;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num2 = 29;
					}
					continue;
				case 10:
					ViewModel.SelectedStrategy = ex6KFw2WejF3Y0Rqo9YD;
					return;
				case 24:
					rjye4snd0mqhCsdU2uTx.FVxndvvQ95u = rjye4snd0mqhCsdU2uTx.VCHndBJmuep;
					num2 = 19;
					continue;
				case 3:
					if (j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						ViewModel.SelectedStrategy = null;
					}
					if (!GVuyy34ds8jgXV7mg7TC(jvNXoo4QPxdM0oOgI1bt()) && !string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						t2jRPf4dXKNQeeThtnU5(ViewModel, ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.SQXndnmkNJq));
						num = 15;
						break;
					}
					goto case 15;
				case 11:
					t2jRPf4dXKNQeeThtnU5(ViewModel, null);
					goto default;
				case 6:
					if (!string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						goto case 3;
					}
					goto case 17;
				case 17:
					ViewModel.SelectedStrategy = null;
					num2 = 3;
					continue;
				case 9:
					if (!string.IsNullOrEmpty(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						t2jRPf4dXKNQeeThtnU5(ViewModel, ViewModel.Strategies.FirstOrDefault(rjye4snd0mqhCsdU2uTx.eZMndflT7Mj));
						num2 = 28;
						continue;
					}
					goto case 28;
				case 22:
				{
					List<ruI5XW2OJpKMlnG7xFDS> list = T16LbD2WvuEJJRkHuI6J.Vv52WDDPVmk();
					object obj = SvBPwK4dximxug5a50jQ();
					string text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5037E);
					ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = new ruI5XW2OJpKMlnG7xFDS();
					ruI5XW2OJpKMlnG7xFDS.jrE2Op96Unu(_0020: true);
					ex6KFw2WejF3Y0Rqo9YD = new ex6KFw2WejF3Y0Rqo9YD((string)obj, text, ruI5XW2OJpKMlnG7xFDS);
					ViewModel.Strategies.Add(ex6KFw2WejF3Y0Rqo9YD);
					using (List<ruI5XW2OJpKMlnG7xFDS>.Enumerator enumerator = list.GetEnumerator())
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
								{
									num3 = 1;
								}
								goto IL_0194;
							}
							current = enumerator.Current;
							if (rjye4snd0mqhCsdU2uTx.FVxndvvQ95u == current.JW82q2WZSBL)
							{
								goto IL_01d8;
							}
							goto IL_0252;
							IL_020f:
							flag = true;
							goto IL_0252;
							IL_0194:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									goto IL_01d8;
								case 3:
									goto IL_020f;
								case 4:
									ViewModel.Strategies.Add(item);
									num3 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
									{
										num3 = 2;
									}
									continue;
								case 1:
									goto end_IL_01b2;
								}
								break;
							}
							continue;
							IL_0252:
							if (!string.IsNullOrEmpty((string)aReMRa4dLikc0UZaMeS7(current)) && current.Ls62qoXGjhk != ViewModel.Symbol)
							{
								continue;
							}
							item = new ex6KFw2WejF3Y0Rqo9YD((string)lE6bKs4dlkBJfqGJvBPs(current), (string)d1uJ5q4dbQSO8pA981wL(current), current);
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
							{
								num3 = 4;
							}
							goto IL_0194;
							IL_01d8:
							if (!string.IsNullOrEmpty(current.Ls62qoXGjhk))
							{
								goto IL_020f;
							}
							goto IL_0252;
							continue;
							end_IL_01b2:
							break;
						}
					}
					goto case 5;
				}
				default:
					if (!GVuyy34ds8jgXV7mg7TC(j18iDj9nukSCmEyZs5lH.Settings))
					{
						num2 = 20;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 30:
					ViewModel.SelectedStrategy = null;
					goto IL_00ef;
				case 8:
					return;
					IL_00ef:
					if (GVuyy34ds8jgXV7mg7TC(jvNXoo4QPxdM0oOgI1bt()) && Bid1lk4deoMPEj6cDdLa(rjye4snd0mqhCsdU2uTx.VCHndBJmuep))
					{
						num2 = 27;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	private void LeverageKeyDown(object sender, KeyEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (e.Key == Key.Return)
				{
					SetLeverage();
					LsM7Qj4dcmI7uxaHA6rT(ViewModel, false);
				}
				return;
			case 1:
				ViewModel.Hbc2H2EvPrX(_0020: true);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void LeverageLostFocus(object sender, RoutedEventArgs e)
	{
		LsM7Qj4dcmI7uxaHA6rT(ViewModel, false);
	}

	private void SelectSizeEditBox_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
	{
		int num = 1;
		int num2 = num;
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = gYaZ35fgMe1lUXl9Fd7Z.ewCfgqPoEij();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				int num3 = gVr7s24djqO28Y5A206k(e.Delta) * num4;
				Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
				if (action == null)
				{
					goto case 2;
				}
				action(j3bgDY9gV2i9bttJ1fiQ.Ens9RbmXcVa(num3));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
				{
					num2 = 2;
				}
				break;
			}
			case 2:
				CQh8Tl4dEPlsc4rGHYKc(e, true);
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583312130), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 21:
			((Button)target).Click += StrategyButton_Click;
			num = 9;
			goto IL_0009;
		case 13:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 24:
			((Button)target).Click += StrategyButton_Click;
			num = 5;
			goto IL_0009;
		case 28:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 12:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 26:
			isanK04ddBIZAjVRYtEE((DoubleEditBox)target, new RoutedEventHandler(LeverageLostFocus));
			((DoubleEditBox)target).KeyDown += LeverageKeyDown;
			num = 6;
			goto IL_0009;
		case 29:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			break;
		case 27:
			((Button)target).Click += ButtonCommand_Click;
			break;
		default:
			_contentLoaded = true;
			break;
		case 20:
			((ComboBox)target).SelectionChanged += ComboBoxExitStrategies_SelectionChanged;
			break;
		case 15:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 25:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(StrategyButton_Click));
			break;
		case 11:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			num = 8;
			goto IL_0009;
		case 10:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 8:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 23:
			((Button)target).Click += StrategyButton_Click;
			break;
		case 16:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
			{
				num = 7;
			}
			goto IL_0009;
		case 14:
			((Button)target).Click += ButtonCommand_Click;
			num = 3;
			goto IL_0009;
		case 22:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(StrategyButton_Click));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 19:
			SelectSizeEditBox = (DoubleEditBox)target;
			SelectSizeEditBox.PreviewMouseWheel += SelectSizeEditBox_PreviewMouseWheel;
			num = 10;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 10;
			}
			goto IL_0009;
		case 18:
			((Border)target).MouseDown += Pnl_OnMouseDown;
			num = 2;
			goto IL_0009;
		case 6:
			lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			break;
		case 17:
			((Border)target).MouseDown += Position_OnMouseDown;
			break;
		case 7:
			((Button)target).Click += ButtonCommand_Click;
			break;
		case 9:
			{
				((Button)target).Click += ButtonCommand_Click;
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 8:
				return;
			case 6:
				return;
			case 10:
				return;
			case 3:
				return;
			case 5:
				return;
			case 4:
				return;
			case 1:
				return;
			case 0:
				return;
			case 9:
				return;
			case 2:
				return;
			case 11:
				break;
			case 7:
				return;
			}
			goto case 6;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 1:
				switch (connectionId)
				{
				case 4:
					lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonSize4_Click));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					((Button)target).Click += ButtonSize5_Click;
					return;
				case 2:
					((Button)target).Click += ButtonSize2_Click;
					return;
				case 3:
					lGK1OM4dQPhZ6NjvDHxZ((Button)target, new RoutedEventHandler(ButtonSize3_Click));
					return;
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					((Button)target).Click += ButtonSize1_Click;
					return;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static MarketTraderControl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool OdPJA84QORdI9WwJ5NSl()
	{
		return o3vIIH4QMQr5lpZRVPtb == null;
	}

	internal static MarketTraderControl AFH1Ba4QqJKZvYyiP4lv()
	{
		return o3vIIH4QMQr5lpZRVPtb;
	}

	internal static void xyrgUw4QIOU442QxrdUY(object P_0, bool P_1)
	{
		((UIElement)P_0).Focusable = P_1;
	}

	internal static void RsVVe74QWxbkMB0J9PHN(object P_0, object P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static object wWjw5T4QtSEPNQBvbGk3(object P_0)
	{
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	internal static object vt8wyn4QUiObOGijDBl0(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool AbsZTB4QTNGXC0Mlmf3t(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void FkXnHB4QyjTZ9vRlfMoH(object P_0, object P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).JmR20MbixGa((TradingSettings)P_1);
	}

	internal static void DjnRiB4QZjWfhMcBquyE(object P_0, object P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).Symbol = (string)P_1;
	}

	internal static void H2NRAC4QVVmRmVlQViPh(object P_0, int P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).zIa20y3bbIQ(P_1);
	}

	internal static void MD8QGp4QCFKYbhKaILO4(object P_0, bool P_1)
	{
		((PartEditBoxBase<double?>)P_0).IsPopupOpen = P_1;
	}

	internal static long JZvxLx4Qrr5XILuO7TEg(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).GSX22HWRhWu();
	}

	internal static bool BuN0yy4QKhuVDFJMbabm(double P_0)
	{
		return double.IsInfinity(P_0);
	}

	internal static long X0cJ5g4QmDyGbibTVAen(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).ObY20z8G50d();
	}

	internal static long HmLt2m4Qh61xQtVsWKit(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).APa22oJSA2W();
	}

	internal static object PTIH9l4QwjdNMYEaQ2Xh()
	{
		return j3bgDY9gV2i9bttJ1fiQ.ClosePosition();
	}

	internal static object oReOw64Q771wwQNEojfb(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).Settings;
	}

	internal static object eZqNTy4Q8VAQ64G0Lu8N(object P_0)
	{
		return ((Account)P_0).ConnectionID;
	}

	internal static double QHifHB4QACfOFUXqKB0i(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).CurrentSize;
	}

	internal static object jvNXoo4QPxdM0oOgI1bt()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static decimal sX4Ybf4QJXBw2li4VP4q(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TransferFundsAmount;
	}

	internal static mUs87h9xN7JK6PZpsQ4J UBsT7E4QF56rtG3CV1hJ(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TransferTo;
	}

	internal static object zZkxya4Q3U8X1LtqdwQN(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static object wb7v504Qp7HjD0GfiQBW(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).TradingSettings;
	}

	internal static object kfa9A94Qu8o9KZbxWOGj(object P_0)
	{
		return ((TradingSettings)P_0).MarketSettings;
	}

	internal static OnRZP7fwMaIGMRJa0UZR RKXaL64QzpBdPes1GoKx(object P_0)
	{
		return ((CR1isWfDCD1A4fwfUJUf)P_0).PositionSizeDisplayType;
	}

	internal static void HAYGqf4d04pj1rvV1qQj(object P_0, OnRZP7fwMaIGMRJa0UZR P_1)
	{
		((CR1isWfDCD1A4fwfUJUf)P_0).PositionSizeDisplayType = P_1;
	}

	internal static bool E67RVC4d2HCFjaHEQfDG(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).OrderPostOnly;
	}

	internal static void h6on4B4dHadMZDt66i9S(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0)[P_1] = P_2;
	}

	internal static object pkvGo44dfVakEy0Qkvjs(double P_0, object P_1)
	{
		return j3bgDY9gV2i9bttJ1fiQ.YMs9gr9Zbmn(P_0, (Hashtable)P_1);
	}

	internal static double fCKwLE4d9rnYC4xNYoV4(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).OrderQuantity;
	}

	internal static object JbBuLm4dnO9mD19peelo(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.CFN9gJM2gRc(P_0, P_1, (Hashtable)P_2);
	}

	internal static object FaoWBv4dGOX0MgqYRpYM(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.pOE9g3tXJ5M(P_0, P_1, (Hashtable)P_2);
	}

	internal static double gcTnED4dYC0SFTJ50nxp(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).OrderPrice1;
	}

	internal static object q0K6l04dogDw4cN6MDgE(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.H439gweDgvv(P_0, P_1, (Hashtable)P_2);
	}

	internal static object XmUwfa4dvjLwEeKnHSFS(object P_0)
	{
		return ((ButtonBase)P_0).CommandParameter;
	}

	internal static object Wje2Ao4dB9W1KINWuj1D(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).SelectedStrategy;
	}

	internal static object oJ45rH4daFj4QLpRow3N()
	{
		return j3bgDY9gV2i9bttJ1fiQ.ExitStrategy();
	}

	internal static Guid Ub489X4di9b1dyZsrrf6()
	{
		return Guid.NewGuid();
	}

	internal static object lE6bKs4dlkBJfqGJvBPs(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).StrategyName;
	}

	internal static void Odmkcy4d4CAqbZJE0Hur(object P_0, object P_1)
	{
		((ruI5XW2OJpKMlnG7xFDS)P_0).StrategyName = (string)P_1;
	}

	internal static bool Ro0IaZ4dDZAhxetoCMjE(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).LinkToSymbol;
	}

	internal static object d1uJ5q4dbQSO8pA981wL(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).JW82q2WZSBL;
	}

	internal static object JPw1kL4dNQeAFteCyuBc()
	{
		return TigerTrade.Properties.Resources.ChartTraderControlRemoveStrategyTitle;
	}

	internal static object WvKI2T4dklSmZc2O3EgP()
	{
		return TigerTrade.Properties.Resources.ChartTraderControlRemoveStrategyMsg;
	}

	internal static bool zgjmWt4d1B7P9yCopi5y(object P_0, object P_1)
	{
		return CUhDqX2WPcrPo6KKW2MU.PiL2WuQgRWM((Window)P_0, (ruI5XW2OJpKMlnG7xFDS)P_1);
	}

	internal static object vAUDWL4d5WxJgBatEj9y(object P_0)
	{
		return ((z48ObB20gSriKUfj18p3)P_0).Symbol;
	}

	internal static void g4vWfl4dSWnUq6S7RdG6(object P_0)
	{
		((Collection<ex6KFw2WejF3Y0Rqo9YD>)P_0).Clear();
	}

	internal static object SvBPwK4dximxug5a50jQ()
	{
		return TigerTrade.Properties.Resources.ChartTraderControlStrategyNone;
	}

	internal static object aReMRa4dLikc0UZaMeS7(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).Ls62qoXGjhk;
	}

	internal static bool Bid1lk4deoMPEj6cDdLa(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool GVuyy34ds8jgXV7mg7TC(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SaveSelectedExitStrategy;
	}

	internal static void t2jRPf4dXKNQeeThtnU5(object P_0, object P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).SelectedStrategy = (ex6KFw2WejF3Y0Rqo9YD)P_1;
	}

	internal static void LsM7Qj4dcmI7uxaHA6rT(object P_0, bool P_1)
	{
		((z48ObB20gSriKUfj18p3)P_0).Hbc2H2EvPrX(P_1);
	}

	internal static int gVr7s24djqO28Y5A206k(int P_0)
	{
		return Math.Sign(P_0);
	}

	internal static void CQh8Tl4dEPlsc4rGHYKc(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static void lGK1OM4dQPhZ6NjvDHxZ(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void isanK04ddBIZAjVRYtEE(object P_0, object P_1)
	{
		((UIElement)P_0).LostFocus += (RoutedEventHandler)P_1;
	}
}
