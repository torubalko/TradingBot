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
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using b1neT39sxtGuKbVPRyqn;
using bl7Or1fDrLHNeTtGhT82;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using JPaDuU2m753Y01hck4QD;
using LKPssPfwOEBXRql5l3eT;
using M7Qhok2zS37wTYN0rqJn;
using N9L7yW2WJK3TjwDPitrY;
using ncN1IX26ahACtrvcwiFM;
using NjRsCt2WsDfbeZXtjdEb;
using nWrTsb2WBR9N8EXoRT6F;
using ocMo2C2OFi7RLs2TMtAp;
using PosIhkfBXsapbL9iTTDK;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Trading;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Controls.Notifications;
using TigerTrade.UI.DocControls.Charting.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using V9ObVI9gCxZjgUce1Uw4;
using Vs7D1ifgOBnFeIIPKkYP;
using waDpctGJom9MvAveNXHq;
using wse3wd2zgF9O4VW2DUfZ;

namespace TigerTrade.UI.DocControls.Charting.Controls.ChartTrader;

internal sealed class ChartTraderControl : aUQvKjHk6H77hbYGG0GM, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private sealed class d44JMGnMWt5Gm6ClQf9m
	{
		public string a63nMrjvYy5;

		public string L1YnMKG0Exb;

		public string aTFnMmdHvyi;

		private static d44JMGnMWt5Gm6ClQf9m yWOBCiNNNF2nLARvXi7D;

		public d44JMGnMWt5Gm6ClQf9m()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool TTonMtvqECm(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return (string)LrrlSDNN5AtBSrPNdvMS(f) == a63nMrjvYy5;
		}

		internal bool OdMnMUkONLU(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == L1YnMKG0Exb;
		}

		internal bool dHvnMT9V3NQ(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return (string)LrrlSDNN5AtBSrPNdvMS(f) == aTFnMmdHvyi;
		}

		internal bool sZ2nMyNB3Jh(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return CAjPAMNNSyAOVweyaRlg(LrrlSDNN5AtBSrPNdvMS(f), L1YnMKG0Exb);
		}

		internal bool X8inMZ4eEee(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == aTFnMmdHvyi;
		}

		internal bool lUZnMViji3N(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == aTFnMmdHvyi;
		}

		internal bool iiUnMCcBkG7(ex6KFw2WejF3Y0Rqo9YD f)
		{
			return f.nQA2WjKj8f2() == aTFnMmdHvyi;
		}

		static d44JMGnMWt5Gm6ClQf9m()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool I2gnE2NNkmlWFXMCcJRK()
		{
			return yWOBCiNNNF2nLARvXi7D == null;
		}

		internal static d44JMGnMWt5Gm6ClQf9m a5AbJXNN11dpLrfK8n2L()
		{
			return yWOBCiNNNF2nLARvXi7D;
		}

		internal static object LrrlSDNN5AtBSrPNdvMS(object P_0)
		{
			return ((ex6KFw2WejF3Y0Rqo9YD)P_0).nQA2WjKj8f2();
		}

		internal static bool CAjPAMNNSyAOVweyaRlg(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private Symbol _symbol;

	internal DoubleEditBox SelectSizeEditBox;

	private bool _contentLoaded;

	internal static ChartTraderControl eIMwVZ4Jc9JWaIvf21DN;

	public Tv9C1H26BMiXAuJrRQO7 ViewModel { get; private set; }

	public event Action<j3bgDY9gV2i9bttJ1fiQ> Command;

	public ChartTraderControl()
	{
		AbGmOL4JQdiSdc8g7PhQ();
		base._002Ector();
		ViewModel = new Tv9C1H26BMiXAuJrRQO7();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Oy1MXx4Jdt7EJJ3o0CO5(this, false);
				T16LbD2WvuEJJRkHuI6J.ai72W1pJ0bT(BuildStrategiesList);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				j18iDj9nukSCmEyZs5lH.Settings.PropertyChanged += OnSettingsPropertyChanged;
				base.Unloaded += OnUnloaded;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		HxUGLt4JgqRxhP2h8V8b(new Action(BuildStrategiesList));
		((MhMDPU9v8rkigy1ao0Th)l86SHa4JRwKwNwGisEGW()).PropertyChanged -= OnSettingsPropertyChanged;
	}

	private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs args)
	{
		string text = (string)ufbBKG4J69ZlsmajTr82(args);
		int num2;
		if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F017D)))
		{
			if (!Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839690964)))
			{
				return;
			}
			SaveExitStrategy();
			int num = 2;
			num2 = num;
		}
		else
		{
			ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530018853));
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
			{
				num2 = 0;
			}
		}
		while (true)
		{
			switch (num2)
			{
			case 3:
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487024C));
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527047622));
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -448973086));
				return;
			case 1:
				ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1D5D31));
				num2 = 3;
				continue;
			case 2:
				return;
			}
			ViewModel.JZYHkZsWiJ6((string)hUov0Y4JOLx0Q3L1qkim(0x24B0B9E6 ^ 0x24B03C3C));
			ViewModel.JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842006899));
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num2 = 1;
			}
		}
	}

	public void SetSettings(ChartingSettings settings)
	{
		ViewModel.mhD26lR2JA2(settings);
		BuildStrategiesList();
	}

	public void SetSymbol(Symbol symbol)
	{
		ViewModel.Symbol = (string)v5sm8e4JqkbJ5F1M3uNq(symbol);
		ViewModel.Exchange = symbol.Exchange;
		_symbol = symbol;
		BuildStrategiesList();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
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
		ViewModel.WDx26S82dYC(1);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize2_Click(object sender, RoutedEventArgs e)
	{
		BAw6mP4JIPHh0ghO9IuO(ViewModel, 2);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize3_Click(object sender, RoutedEventArgs e)
	{
		ViewModel.WDx26S82dYC(3);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize4_Click(object sender, RoutedEventArgs e)
	{
		BAw6mP4JIPHh0ghO9IuO(ViewModel, 4);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonSize5_Click(object sender, RoutedEventArgs e)
	{
		ViewModel.WDx26S82dYC(5);
		SelectSizeEditBox.IsPopupOpen = false;
	}

	private void ButtonCommand_Click(object sender, RoutedEventArgs e)
	{
		int num = 28;
		uint num3 = default(uint);
		string text = default(string);
		double sizeInBase3 = default(double);
		double sizeInBase5 = default(double);
		Button button = default(Button);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
				{
					if (num3 != 3000236465u || !(text == (string)hUov0Y4JOLx0Q3L1qkim(-165474503 ^ -165447299)) || !TryGetCurrentSizeInBase(ViewModel.Hde26U5aaCi(), out var sizeInBase))
					{
						return;
					}
					if (!double.IsInfinity(sizeInBase))
					{
						Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
						if (action == null)
						{
							num2 = 42;
							continue;
						}
						action(j3bgDY9gV2i9bttJ1fiQ.SellMarket(sizeInBase));
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
						{
							num2 = 11;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				}
				case 4:
					if (num3 != 144042150)
					{
						num2 = 5;
					}
					else if (Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B3C377)))
					{
						TransferFunds();
						num2 = 33;
					}
					else
					{
						num2 = 37;
					}
					continue;
				case 44:
					return;
				case 43:
					if (double.IsInfinity(sizeInBase3))
					{
						num2 = 26;
						continue;
					}
					this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(keSCj84JUBejxjMnWcgC(ViewModel), sizeInBase3));
					return;
				case 9:
					return;
				case 15:
					if (num3 <= 209740820)
					{
						num2 = 4;
						continue;
					}
					if (num3 == 271173071)
					{
						if (Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009546143)) && TryGetCurrentSizeInBase(ViewModel.dur26ZMhNI6(), out var sizeInBase6) && !double.IsInfinity(sizeInBase6))
						{
							this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.BuyMarket(sizeInBase6));
						}
						return;
					}
					num2 = 7;
					continue;
				case 16:
					return;
				case 0:
					return;
				case 6:
					return;
				case 5:
				{
					if (num3 != 209740820 || !Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB15FE02)) || !TryGetCurrentSizeInBase(ViewModel.dur26ZMhNI6(), out var sizeInBase8) || ba8MkA4JynFBGfSAcTuM(sizeInBase8))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action9 = this.Command;
					if (action9 == null)
					{
						return;
					}
					action9(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(QBqG7E4JtmRNo5FJfo18(ViewModel), sizeInBase8));
					num2 = 20;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 10:
					return;
				case 33:
					return;
				case 20:
					return;
				case 13:
					return;
				case 31:
					return;
				case 22:
				{
					if (num3 != 495788626)
					{
						num2 = 12;
						continue;
					}
					if (!(text == (string)hUov0Y4JOLx0Q3L1qkim(0x20B584D2 ^ 0x20B50258)) || TryGetCurrentSizeInBase(ViewModel.dur26ZMhNI6(), out var sizeInBase4) || ba8MkA4JynFBGfSAcTuM(sizeInBase4))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action3 = this.Command;
					if (action3 == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
						{
							num2 = 29;
						}
						continue;
					}
					action3(j3bgDY9gV2i9bttJ1fiQ.SellLimit(QBqG7E4JtmRNo5FJfo18(ViewModel), sizeInBase4));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 25:
					if (num3 == 1957576550)
					{
						if (Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878919778)) && TryGetCurrentSizeInBase(NBSwDe4JTe3K4heErBFC(ViewModel), out var sizeInBase2) && !double.IsInfinity(sizeInBase2))
						{
							Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
							if (action2 == null)
							{
								num2 = 8;
								continue;
							}
							action2(j3bgDY9gV2i9bttJ1fiQ.BuyLimit(ViewModel.Hde26U5aaCi(), sizeInBase2));
						}
						return;
					}
					num2 = 24;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 18;
					}
					continue;
				case 36:
					if (num3 == 2476200180u)
					{
						if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04A042))
						{
							SetLeverage();
							return;
						}
						num2 = 48;
					}
					else
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
						{
							num2 = 10;
						}
					}
					continue;
				case 11:
					return;
				case 12:
				{
					if (num3 == 1449205056 && text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31B2B1) && TryGetCurrentSizeInBase(NBSwDe4JTe3K4heErBFC(ViewModel), out var sizeInBase7) && !ba8MkA4JynFBGfSAcTuM(sizeInBase7))
					{
						this.Command?.Invoke(j3bgDY9gV2i9bttJ1fiQ.SellLimit(ViewModel.Hde26U5aaCi(), sizeInBase7));
					}
					return;
				}
				case 1:
					return;
				case 17:
				{
					if (double.IsInfinity(sizeInBase5))
					{
						return;
					}
					Action<j3bgDY9gV2i9bttJ1fiQ> action11 = this.Command;
					if (action11 == null)
					{
						num2 = 21;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					action11(j3bgDY9gV2i9bttJ1fiQ.SellLimit(ViewModel.Nre26hkSM3M(), sizeInBase5));
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				case 45:
					return;
				case 24:
					return;
				case 47:
					return;
				case 34:
					return;
				case 40:
					return;
				case 48:
					return;
				case 2:
					return;
				case 35:
					return;
				case 41:
					if (num3 > 298017482)
					{
						if (num3 <= 1449205056)
						{
							num2 = 22;
							continue;
						}
						if (num3 == 1515425823)
						{
							if (!Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D3E02E)))
							{
								return;
							}
							Action<j3bgDY9gV2i9bttJ1fiQ> action10 = this.Command;
							if (action10 == null)
							{
								num2 = 40;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
								{
									num2 = 46;
								}
								continue;
							}
							action10(j3bgDY9gV2i9bttJ1fiQ.CancelBids());
							num2 = 31;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
							{
								num2 = 11;
							}
							continue;
						}
						num = 38;
						break;
					}
					num2 = 15;
					continue;
				case 38:
					if (num3 != 1548138422)
					{
						num = 25;
						break;
					}
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198973172))
					{
						if (!TryGetCurrentSizeInBase(QBqG7E4JtmRNo5FJfo18(ViewModel), out sizeInBase3))
						{
							return;
						}
						num2 = 43;
					}
					else
					{
						num2 = 11;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
						{
							num2 = 13;
						}
					}
					continue;
				case 37:
					return;
				case 23:
					return;
				case 26:
					return;
				case 27:
					if (!(SZwIlf4JW5qoM3nt47SU(button) is string))
					{
						return;
					}
					num2 = 39;
					continue;
				case 32:
					return;
				case 39:
					text = button.CommandParameter.ToString();
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
					if (num3 <= 1957576550)
					{
						num2 = 41;
						continue;
					}
					if (num3 <= 3000236465u)
					{
						if (num3 > 2476200180u)
						{
							if (num3 == 2628573300u)
							{
								if (!Uamih44JM04NjqV7PPqp(text, hUov0Y4JOLx0Q3L1qkim(-1736566656 ^ -1736544706)))
								{
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
									{
										num2 = 0;
									}
									continue;
								}
								if (!TryGetCurrentSizeInBase(NBSwDe4JTe3K4heErBFC(ViewModel), out sizeInBase5))
								{
									num2 = 44;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
									{
										num2 = 5;
									}
									continue;
								}
								goto case 17;
							}
							if (num3 != 2792084858u)
							{
								num2 = 3;
								continue;
							}
							if (!Uamih44JM04NjqV7PPqp(text, hUov0Y4JOLx0Q3L1qkim(0x2D313048 ^ 0x2D314D26)))
							{
								return;
							}
							Action<j3bgDY9gV2i9bttJ1fiQ> action5 = this.Command;
							if (action5 == null)
							{
								return;
							}
							action5((j3bgDY9gV2i9bttJ1fiQ)J2eZmS4JCBuGyVXv7YIS());
							num2 = 10;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
							{
								num2 = 30;
							}
							continue;
						}
						if (num3 != 2004852254)
						{
							num2 = 36;
							continue;
						}
						if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878961642))
						{
							Action<j3bgDY9gV2i9bttJ1fiQ> action6 = this.Command;
							if (action6 == null)
							{
								num2 = 19;
								continue;
							}
							action6((j3bgDY9gV2i9bttJ1fiQ)zBFiCq4JVQdXEKWRuVrD());
						}
						return;
					}
					if (num3 > 3534501296u)
					{
						if (num3 != 3630834884u)
						{
							if (num3 != 3733551141u)
							{
								if (num3 != 4147984405u)
								{
									return;
								}
								if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7F0445))
								{
									Action<j3bgDY9gV2i9bttJ1fiQ> action7 = this.Command;
									if (action7 == null)
									{
										return;
									}
									action7(j3bgDY9gV2i9bttJ1fiQ.CancelAsks());
									num2 = 34;
									continue;
								}
								num = 35;
								break;
							}
							if (!(text == (string)hUov0Y4JOLx0Q3L1qkim(0x769C7931 ^ 0x769CFF97)))
							{
								return;
							}
							BuySell(buy: false);
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						if (text == (string)hUov0Y4JOLx0Q3L1qkim(--855742383 ^ 0x3301EAF9))
						{
							Action<j3bgDY9gV2i9bttJ1fiQ> action8 = this.Command;
							if (action8 != null)
							{
								action8(j3bgDY9gV2i9bttJ1fiQ.TakeProfit());
								num2 = 32;
								continue;
							}
						}
						return;
					}
					num2 = 14;
					continue;
				case 14:
					switch (num3)
					{
					default:
						num2 = 23;
						break;
					case 3403315211u:
						if (!Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203031112)))
						{
							return;
						}
						BuySell(buy: true);
						num2 = 21;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
						{
							num2 = 45;
						}
						break;
					case 3534501296u:
						if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002288753))
						{
							Action<j3bgDY9gV2i9bttJ1fiQ> action4 = this.Command;
							if (action4 == null)
							{
								num2 = 18;
								break;
							}
							action4(j3bgDY9gV2i9bttJ1fiQ.ClosePosition());
							num2 = 40;
							break;
						}
						return;
					}
					continue;
				case 7:
					if (num3 == 298017482)
					{
						if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315AC737))
						{
							this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)TJQ7pu4JZFdSaiI4lukA());
							return;
						}
						num2 = 47;
					}
					else
					{
						num2 = 16;
					}
					continue;
				case 28:
					button = (Button)e.OriginalSource;
					num2 = 27;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 20;
					}
					continue;
				case 8:
					return;
				case 42:
					return;
				case 21:
					return;
				case 29:
					return;
				case 18:
					return;
				case 46:
					return;
				case 19:
					return;
				case 30:
					return;
				}
				break;
			}
		}
	}

	private bool TryGetCurrentSizeInBase(long price, out double sizeInBase)
	{
		int num = 2;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
			{
				object obj2 = H6QCeW4JrYlM5dDPyfqm(ViewModel.Settings.Account);
				DataManager.GetLeverage(((Account)obj2)?.ConnectionID, _symbol);
				if (obj2 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = OnDSL94JKTnH1mFUf3ur(obj2);
				goto IL_00e4;
			}
			case 1:
				{
					obj = null;
					goto IL_00e4;
				}
				IL_00e4:
				num3 = IiWOuY4JmjSEMcZvqamR(obj, _symbol);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (!JLFqEJGJYiHaSdoROJXI.UAtGJlwm3mG(_symbol, ViewModel.Settings.ExecuteInQuoteCurrency, ViewModel.Settings.ExecuteInPercents, ViewModel.Leverage ?? (-1.0), num3, ViewModel.CurrentSize, price, out sizeInBase, out var text))
			{
				if (!dxjZPB4JhSLTbw5ewKE8(text))
				{
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6(TigerTrade.Properties.Resources.ResourceManager.GetString((string)hUov0Y4JOLx0Q3L1qkim(-962524685 ^ -962496959)), text, NotificationType.Error));
				}
				return false;
			}
			return true;
		}
	}

	private void SetLeverage()
	{
		if (!ViewModel.Leverage.HasValue)
		{
			return;
		}
		Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
		if (action != null)
		{
			action(j3bgDY9gV2i9bttJ1fiQ.SetLeverage(ViewModel.Leverage.Value));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
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

	private void TransferFunds()
	{
		if (!NhvJ9a4JwBW1dV4The7g(j18iDj9nukSCmEyZs5lH.Settings.TransferFundsAmount, 0m))
		{
			return;
		}
		Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
		if (action != null)
		{
			action(j3bgDY9gV2i9bttJ1fiQ.TransferFunds(((MhMDPU9v8rkigy1ao0Th)l86SHa4JRwKwNwGisEGW()).TransferFundsAmount, j18iDj9nukSCmEyZs5lH.Settings.TransferFrom, j18iDj9nukSCmEyZs5lH.Settings.TransferTo));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
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

	private void ToggleSwitchControl_Checked(object sender, RoutedEventArgs e)
	{
		((ChartingSettings)WHAVJ84J74QuDiI6kWv0(ViewModel)).ChartTrading = true;
	}

	private void ToggleSwitchControl_Unchecked(object sender, RoutedEventArgs e)
	{
		ViewModel.ChartingSettings.ChartTrading = false;
	}

	private void Pnl_OnMouseDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			ViewModel.ChartingSettings.ChartSettings.TradeSettings.PnlType = Woy4014JPLIUSQWOuSUe(nCykfw4JAKqAJY4JRRTa(KEWeCa4J88NSoOG5yT3F(ViewModel.ChartingSettings.ChartSettings)));
		}
	}

	private void Position_OnMouseDown(object sender, MouseButtonEventArgs e)
	{
		if (hCKH7i4JJdXEEyLFHr5b(e) == 2)
		{
			YcamOf4JF4G1NAxMRnJy(((ChartingSettings)WHAVJ84J74QuDiI6kWv0(ViewModel)).ChartSettings.TradeSettings, G5WDO0fBspkJC1m1nhXd.ufJfBENqgtu(((ChartingSettings)WHAVJ84J74QuDiI6kWv0(ViewModel)).ChartSettings.TradeSettings.PositionSizeDisplayType));
		}
	}

	private void BuySell(bool buy)
	{
		int num = 9;
		Hashtable hashtable = default(Hashtable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (ViewModel.OrderReduceOnlyVisibility == Visibility.Visible)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto IL_015a;
				case 8:
					if (ViewModel.OrderHidden && ViewModel.OrderHiddenVisibility == Visibility.Visible)
					{
						hashtable[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D31B6A8)] = stZafr4J3TAerPJnOiXZ(ViewModel);
					}
					if (ViewModel.OrderPostOnly)
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 0:
					return;
				case 5:
					return;
				case 4:
					if (uDyf594JpvsIwKxGISrp(ViewModel))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_015a;
				case 10:
					return;
				case 9:
					hashtable = new Hashtable();
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					hashtable[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063340013)] = ViewModel.OrderReduceOnly;
					goto IL_015a;
				case 7:
					if (ViewModel.OrderPostOnlyVisibility == Visibility.Visible)
					{
						break;
					}
					goto case 4;
				case 1:
					return;
				case 6:
					return;
					IL_015a:
					if (ViewModel.OrderCloseOnly && ViewModel.OrderCloseOnlyVisibility == Visibility.Visible)
					{
						xTWNc54JzFEY6CPVp5ge(hashtable, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C76DE2), Xo8Xhq4JugWxtsdnw82v(ViewModel));
					}
					switch (K6knfm4F0Pg5I5skZiy4(ViewModel))
					{
					case ChartOrderType.Limit:
						this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)(buy ? UsaE724F9KpZNrhZJj7L(ViewModel.OrderPrice1, ViewModel.OrderQuantity, hashtable) : DamhK34FfSgrdUcvhPA7(af0Tev4FHyyJXTdSQiVC(ViewModel), kKMAow4F2uZsXqpMw3FV(ViewModel), hashtable)));
						return;
					case ChartOrderType.Market:
					{
						Action<j3bgDY9gV2i9bttJ1fiQ> action2 = this.Command;
						if (action2 == null)
						{
							return;
						}
						action2(buy ? j3bgDY9gV2i9bttJ1fiQ.YMs9gr9Zbmn(ViewModel.OrderQuantity, hashtable) : j3bgDY9gV2i9bttJ1fiQ.twp9gAGPkZw(kKMAow4F2uZsXqpMw3FV(ViewModel), hashtable));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
						{
							num2 = 0;
						}
						break;
					}
					default:
						num2 = 5;
						break;
					case ChartOrderType.Stop:
					{
						Action<j3bgDY9gV2i9bttJ1fiQ> action3 = this.Command;
						if (action3 == null)
						{
							return;
						}
						action3((j3bgDY9gV2i9bttJ1fiQ)(buy ? j3bgDY9gV2i9bttJ1fiQ.H439gweDgvv(ViewModel.OrderPrice1, ViewModel.OrderQuantity, hashtable) : Yud9Fb4FnNmt6NC6gWGu(ViewModel.OrderPrice1, ViewModel.OrderQuantity, hashtable)));
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num2 = 1;
						}
						break;
					}
					case ChartOrderType.StopLimit:
					{
						Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
						if (action == null)
						{
							num2 = 6;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
							{
								num2 = 2;
							}
						}
						else
						{
							action((j3bgDY9gV2i9bttJ1fiQ)(buy ? mO5qcU4FYO1kU2Rc4UGu(ViewModel.OrderPrice1, ViewModel.OrderPrice2, ViewModel.OrderQuantity, hashtable) : j3bgDY9gV2i9bttJ1fiQ.Acs9gpTgtJW(ViewModel.OrderPrice1, V6bAqw4FGa8IQacmZMqd(ViewModel), ViewModel.OrderQuantity, hashtable)));
							num2 = 10;
						}
						break;
					}
					}
					continue;
				}
				break;
			}
			hashtable[hUov0Y4JOLx0Q3L1qkim(--927068468 ^ 0x374177C4)] = ViewModel.OrderPostOnly;
			num = 4;
		}
	}

	private void StrategyButton_Click(object sender, RoutedEventArgs e)
	{
		int num = 4;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				text = SZwIlf4JW5qoM3nt47SU((ButtonBase)sender).ToString();
				num2 = 3;
				break;
			case 3:
				if (!Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251604275)))
				{
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962620471))
					{
						AddStrategy();
						return;
					}
					if (Uamih44JM04NjqV7PPqp(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82894438)))
					{
						RemoveStrategy();
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!(text == (string)hUov0Y4JOLx0Q3L1qkim(0x7DB10E6E ^ 0x7DB1891C)))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
						{
							num2 = 0;
						}
						break;
					}
					SetupStrategy();
					return;
				}
				ApplyStrategy();
				return;
			case 1:
				if (text == (string)hUov0Y4JOLx0Q3L1qkim(-837284864 ^ -837252208))
				{
					SetupTrading();
					num2 = 2;
					break;
				}
				return;
			case 2:
				return;
			case 0:
				return;
			}
		}
	}

	private void SetupTrading()
	{
		jgvOYw2mwtyvDxilWcWk.D3i2m80T8I9(base.ParentWindow, ViewModel.ChartingSettings.MarketSettings);
	}

	private void ComboBoxExitStrategies_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		SaveExitStrategy();
	}

	private void SaveExitStrategy()
	{
		OsO46y4FopUrC5idp5Hn(ViewModel.Settings.TradeSettings, ViewModel.SelectedStrategy?.nQA2WjKj8f2());
	}

	private void ApplyStrategy()
	{
		this.Command?.Invoke((j3bgDY9gV2i9bttJ1fiQ)sMOjlt4FvPdx24dEYTGj());
	}

	private void AddStrategy()
	{
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = new ruI5XW2OJpKMlnG7xFDS
		{
			JW82q2WZSBL = n8k9uH4FBmNWPnaVMFkB().ToString(),
			StrategyName = TigerTrade.Properties.Resources.ChartTraderControlNewStrategy
		};
		int num;
		if (CUhDqX2WPcrPo6KKW2MU.PiL2WuQgRWM(base.ParentWindow, ruI5XW2OJpKMlnG7xFDS))
		{
			if (!dxjZPB4JhSLTbw5ewKE8(ruI5XW2OJpKMlnG7xFDS.StrategyName))
			{
				goto IL_00dd;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
			{
				num = 0;
			}
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
				goto IL_0089;
			case 2:
				break;
			}
			break;
			IL_0089:
			ruI5XW2OJpKMlnG7xFDS.StrategyName = TigerTrade.Properties.Resources.ChartTraderControlStrategy;
			num = 2;
		}
		goto IL_00dd;
		IL_00dd:
		ruI5XW2OJpKMlnG7xFDS.Ls62qoXGjhk = (cdE3KF4Faof733v5Atp5(ruI5XW2OJpKMlnG7xFDS) ? ViewModel.Symbol : null);
		T16LbD2WvuEJJRkHuI6J.zAg2W4rIpaO(ruI5XW2OJpKMlnG7xFDS);
		BuildStrategiesList(ruI5XW2OJpKMlnG7xFDS.JW82q2WZSBL);
	}

	private void RemoveStrategy()
	{
		if (U0uNE64FixbkoNyUkA6M(ViewModel) != null && RS7iJC4F41rEK1ag2WYb(base.ParentWindow, TigerTrade.Properties.Resources.ChartTraderControlRemoveStrategyTitle, HqpFUg4FluiSQwulX2cT()))
		{
			umGDrZ4FDSVHGTN9gq06(((ex6KFw2WejF3Y0Rqo9YD)U0uNE64FixbkoNyUkA6M(ViewModel)).nQA2WjKj8f2());
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				BuildStrategiesList();
				break;
			case 0:
				break;
			}
		}
	}

	public void SetupStrategy()
	{
		int num = 2;
		int num2 = num;
		ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = default(ruI5XW2OJpKMlnG7xFDS);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				BuildStrategiesList((string)NdARDs4FNMRgijVBLZuG(ruI5XW2OJpKMlnG7xFDS));
				return;
			case 3:
				if (ruI5XW2OJpKMlnG7xFDS == null)
				{
					return;
				}
				CUhDqX2WPcrPo6KKW2MU.PiL2WuQgRWM(base.ParentWindow, ruI5XW2OJpKMlnG7xFDS);
				sZYOEL4FbHfEpVKk47Cy(ruI5XW2OJpKMlnG7xFDS, ruI5XW2OJpKMlnG7xFDS.LinkToSymbol ? ViewModel.Symbol : null);
				T16LbD2WvuEJJRkHuI6J.zAg2W4rIpaO(ruI5XW2OJpKMlnG7xFDS);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
			{
				ex6KFw2WejF3Y0Rqo9YD ex6KFw2WejF3Y0Rqo9YD = ViewModel.SelectedStrategy;
				if (ex6KFw2WejF3Y0Rqo9YD == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = ex6KFw2WejF3Y0Rqo9YD.JgL2WdI2A3a();
				break;
			}
			case 1:
				obj = null;
				break;
			}
			ruI5XW2OJpKMlnG7xFDS = (ruI5XW2OJpKMlnG7xFDS)obj;
			num2 = 3;
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

	private void BuildStrategiesList(string strategyID)
	{
		int num = 14;
		d44JMGnMWt5Gm6ClQf9m d44JMGnMWt5Gm6ClQf9m = default(d44JMGnMWt5Gm6ClQf9m);
		ex6KFw2WejF3Y0Rqo9YD ex6KFw2WejF3Y0Rqo9YD = default(ex6KFw2WejF3Y0Rqo9YD);
		bool flag = default(bool);
		List<ruI5XW2OJpKMlnG7xFDS>.Enumerator enumerator = default(List<ruI5XW2OJpKMlnG7xFDS>.Enumerator);
		ruI5XW2OJpKMlnG7xFDS current = default(ruI5XW2OJpKMlnG7xFDS);
		ex6KFw2WejF3Y0Rqo9YD item = default(ex6KFw2WejF3Y0Rqo9YD);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && dxjZPB4JhSLTbw5ewKE8(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						goto end_IL_0012;
					}
					goto IL_0202;
				case 21:
					ViewModel.SelectedStrategy = null;
					goto IL_0202;
				case 23:
					if (!((MhMDPU9v8rkigy1ao0Th)l86SHa4JRwKwNwGisEGW()).SaveSelectedExitStrategy && string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						ViewModel.SelectedStrategy = null;
					}
					if (G45glH4Fe7E6I5caZ0uj(l86SHa4JRwKwNwGisEGW()) && string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						goto case 11;
					}
					goto IL_0222;
				case 20:
				case 28:
					if (ViewModel.SelectedStrategy == null)
					{
						Qn6UeC4FLRQpJs3eQi8j(ViewModel, ex6KFw2WejF3Y0Rqo9YD);
					}
					return;
				case 7:
					if (j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_012b;
				case 11:
					ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.OdMnMUkONLU);
					goto IL_0222;
				case 6:
					Qn6UeC4FLRQpJs3eQi8j(ViewModel, null);
					num2 = 7;
					break;
				case 14:
					d44JMGnMWt5Gm6ClQf9m = new d44JMGnMWt5Gm6ClQf9m();
					num2 = 13;
					break;
				case 25:
					if (flag || dxjZPB4JhSLTbw5ewKE8(d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb))
					{
						goto case 19;
					}
					num2 = 23;
					break;
				case 18:
					ViewModel.SelectedStrategy = null;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 20;
					}
					break;
				case 24:
				{
					GwQXth4FkhTxq7HBTbZr(ViewModel.Strategies);
					flag = false;
					List<ruI5XW2OJpKMlnG7xFDS> list = T16LbD2WvuEJJRkHuI6J.Vv52WDDPVmk();
					object obj = R83R184F1VfnbMAHijrS();
					string text = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x33011003);
					ruI5XW2OJpKMlnG7xFDS ruI5XW2OJpKMlnG7xFDS = new ruI5XW2OJpKMlnG7xFDS();
					ruI5XW2OJpKMlnG7xFDS.jrE2Op96Unu(_0020: true);
					ex6KFw2WejF3Y0Rqo9YD = new ex6KFw2WejF3Y0Rqo9YD((string)obj, text, ruI5XW2OJpKMlnG7xFDS);
					ViewModel.Strategies.Add(ex6KFw2WejF3Y0Rqo9YD);
					enumerator = list.GetEnumerator();
					num2 = 26;
					break;
				}
				case 1:
					Qn6UeC4FLRQpJs3eQi8j(ViewModel, null);
					goto IL_012b;
				case 13:
					d44JMGnMWt5Gm6ClQf9m.a63nMrjvYy5 = strategyID;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.sZ2nMyNB3Jh);
					goto case 20;
				case 8:
					if (!dxjZPB4JhSLTbw5ewKE8(d44JMGnMWt5Gm6ClQf9m.a63nMrjvYy5))
					{
						num2 = 22;
						break;
					}
					goto case 25;
				case 19:
					if (flag)
					{
						num2 = 12;
						break;
					}
					goto default;
				case 15:
					ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.X8inMZ4eEee);
					goto IL_0155;
				case 3:
					if (ViewModel.Settings == null)
					{
						return;
					}
					if (ViewModel.Symbol == null)
					{
						num2 = 17;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb = ViewModel.SelectedStrategy?.nQA2WjKj8f2();
						num2 = 27;
					}
					break;
				case 9:
					if (string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						num2 = 6;
						break;
					}
					goto case 7;
				case 12:
					if (string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 16;
				case 22:
					Qn6UeC4FLRQpJs3eQi8j(ViewModel, ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.TTonMtvqECm));
					goto case 20;
				case 26:
					try
					{
						while (true)
						{
							if (enumerator.MoveNext())
							{
								current = enumerator.Current;
								if (!Uamih44JM04NjqV7PPqp(d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb, current.JW82q2WZSBL))
								{
									goto IL_065f;
								}
								goto IL_06bd;
							}
							int num3 = 2;
							goto IL_05ab;
							IL_067d:
							item = new ex6KFw2WejF3Y0Rqo9YD((string)v0CCfY4FxamuppP6tUwT(current), (string)NdARDs4FNMRgijVBLZuG(current), current);
							num3 = 3;
							goto IL_05ab;
							IL_05ab:
							switch (num3)
							{
							case 3:
								break;
							default:
								goto IL_065f;
							case 1:
								goto IL_067d;
							case 4:
								goto IL_06bd;
							case 2:
								goto end_IL_060b;
							}
							ViewModel.Strategies.Add(item);
							continue;
							IL_06bd:
							if (!string.IsNullOrEmpty((string)DmBX3b4F5gFaY1c1E8Pc(current)))
							{
								flag = true;
								goto IL_065f;
							}
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
							{
								num3 = 0;
							}
							goto IL_05ab;
							IL_065f:
							if (!string.IsNullOrEmpty((string)DmBX3b4F5gFaY1c1E8Pc(current)) && G30vmN4FSEBGLLfGOQwu(current.Ls62qoXGjhk, ViewModel.Symbol))
							{
								continue;
							}
							goto IL_067d;
							continue;
							end_IL_060b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 8;
				case 16:
					if (!j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy)
					{
						num2 = 9;
						break;
					}
					goto case 7;
				default:
					if (string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb))
					{
						if (!j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
						{
							ViewModel.SelectedStrategy = null;
							num2 = 5;
							break;
						}
						goto case 5;
					}
					goto case 20;
				case 10:
					d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb = d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi;
					num2 = 24;
					break;
				case 27:
					d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi = ViewModel.Settings.TradeSettings.ExitStrategy;
					if (d44JMGnMWt5Gm6ClQf9m.L1YnMKG0Exb == null)
					{
						num2 = 10;
						break;
					}
					goto case 24;
				case 2:
					ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.lUZnMViji3N);
					goto case 20;
				case 17:
					return;
					IL_0202:
					if (!((MhMDPU9v8rkigy1ao0Th)l86SHa4JRwKwNwGisEGW()).SaveSelectedExitStrategy && !dxjZPB4JhSLTbw5ewKE8(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.iiUnMCcBkG7);
					}
					if (j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && !string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
						{
							num2 = 18;
						}
						break;
					}
					goto case 20;
					IL_0155:
					if (!G45glH4Fe7E6I5caZ0uj(j18iDj9nukSCmEyZs5lH.Settings))
					{
						num2 = 28;
						break;
					}
					if (dxjZPB4JhSLTbw5ewKE8(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						goto case 20;
					}
					goto case 2;
					IL_0222:
					if (!G45glH4Fe7E6I5caZ0uj(j18iDj9nukSCmEyZs5lH.Settings) && !string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						ViewModel.SelectedStrategy = ViewModel.Strategies.FirstOrDefault(d44JMGnMWt5Gm6ClQf9m.dHvnMT9V3NQ);
					}
					if (G45glH4Fe7E6I5caZ0uj(j18iDj9nukSCmEyZs5lH.Settings) && !string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 20;
					IL_012b:
					if (!j18iDj9nukSCmEyZs5lH.Settings.SaveSelectedExitStrategy && !string.IsNullOrEmpty(d44JMGnMWt5Gm6ClQf9m.aTFnMmdHvyi))
					{
						num2 = 15;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0155;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 21;
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
			case 1:
				ViewModel.QhV2MUJhEDE(_0020: true);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (e.Key == Key.Return)
				{
					SetLeverage();
					gUom4i4Fsw8FD5ojVV8u(ViewModel, false);
				}
				return;
			}
		}
	}

	private void LeverageLostFocus(object sender, RoutedEventArgs e)
	{
		ViewModel.QhV2MUJhEDE(_0020: false);
	}

	private void SelectSizeEditBox_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num4 = gYaZ35fgMe1lUXl9Fd7Z.ewCfgqPoEij();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				int num3 = Math.Sign(lyatVI4FXniKuUtg1l7k(e)) * num4;
				Action<j3bgDY9gV2i9bttJ1fiQ> action = this.Command;
				if (action == null)
				{
					goto default;
				}
				action(j3bgDY9gV2i9bttJ1fiQ.Ens9RbmXcVa(num3));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				e.Handled = true;
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
			Uri resourceLocator = new Uri((string)hUov0Y4JOLx0Q3L1qkim(0x68C7EAE6 ^ 0x68C72790), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					return;
				case 4:
					switch (connectionId)
					{
					case 11:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 29:
						((Button)target).Click += ButtonCommand_Click;
						num2 = 5;
						goto end_IL_0012;
					case 27:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 10:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonCommand_Click));
						return;
					case 12:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonCommand_Click));
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					default:
						num2 = 3;
						goto end_IL_0012;
					case 14:
						((Button)target).Click += ButtonCommand_Click;
						num2 = 12;
						goto end_IL_0012;
					case 26:
						zheB1q4FjCj3BxGcPIKd((DoubleEditBox)target, new RoutedEventHandler(LeverageLostFocus));
						((DoubleEditBox)target).KeyDown += LeverageKeyDown;
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
						{
							num2 = 8;
						}
						goto end_IL_0012;
					case 23:
						((Button)target).Click += StrategyButton_Click;
						return;
					case 17:
						((Border)target).MouseDown += Position_OnMouseDown;
						num2 = 6;
						goto end_IL_0012;
					case 8:
						break;
					case 28:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 19:
						SelectSizeEditBox = (DoubleEditBox)target;
						num2 = 11;
						goto end_IL_0012;
					case 7:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 25:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(StrategyButton_Click));
						return;
					case 20:
						((ComboBox)target).SelectionChanged += ComboBoxExitStrategies_SelectionChanged;
						return;
					case 15:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonCommand_Click));
						return;
					case 18:
						((Border)target).MouseDown += Pnl_OnMouseDown;
						return;
					case 22:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(StrategyButton_Click));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					case 24:
						((Button)target).Click += StrategyButton_Click;
						num2 = 10;
						goto end_IL_0012;
					case 13:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 9:
						((Button)target).Click += ButtonCommand_Click;
						return;
					case 16:
						TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonCommand_Click));
						return;
					case 21:
						((Button)target).Click += StrategyButton_Click;
						num2 = 2;
						goto end_IL_0012;
					case 6:
						((Button)target).Click += ButtonCommand_Click;
						return;
					}
					goto end_IL_0012_2;
				case 9:
					return;
				case 0:
					return;
				case 11:
					SelectSizeEditBox.PreviewMouseWheel += SelectSizeEditBox_PreviewMouseWheel;
					return;
				case 10:
					return;
				case 12:
					return;
				case 5:
					return;
				case 3:
					_contentLoaded = true;
					num2 = 9;
					break;
				case 6:
					return;
				case 2:
					return;
				case 1:
					return;
				case 7:
					return;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
			TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonCommand_Click));
			num = 7;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 2:
			((Button)target).Click += ButtonSize2_Click;
			break;
		case 1:
			TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonSize1_Click));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 5:
			((Button)target).Click += ButtonSize5_Click;
			break;
		case 4:
			TgVygM4FcVN3C6YZFndu((Button)target, new RoutedEventHandler(ButtonSize4_Click));
			break;
		case 3:
			{
				((Button)target).Click += ButtonSize3_Click;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			}
			break;
		}
	}

	static ChartTraderControl()
	{
		u0h8Bf4FEDVNFNkKeN7O();
	}

	internal static bool TOXClb4JjwdD9pkV2o8R()
	{
		return eIMwVZ4Jc9JWaIvf21DN == null;
	}

	internal static ChartTraderControl gfQ6qP4JEpYgigusOenh()
	{
		return eIMwVZ4Jc9JWaIvf21DN;
	}

	internal static void AbGmOL4JQdiSdc8g7PhQ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void Oy1MXx4Jdt7EJJ3o0CO5(object P_0, bool P_1)
	{
		((UIElement)P_0).Focusable = P_1;
	}

	internal static void HxUGLt4JgqRxhP2h8V8b(object P_0)
	{
		T16LbD2WvuEJJRkHuI6J.hZj2W5hjdnu((Action)P_0);
	}

	internal static object l86SHa4JRwKwNwGisEGW()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object ufbBKG4J69ZlsmajTr82(object P_0)
	{
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	internal static bool Uamih44JM04NjqV7PPqp(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object hUov0Y4JOLx0Q3L1qkim(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object v5sm8e4JqkbJ5F1M3uNq(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void BAw6mP4JIPHh0ghO9IuO(object P_0, int P_1)
	{
		((Tv9C1H26BMiXAuJrRQO7)P_0).WDx26S82dYC(P_1);
	}

	internal static object SZwIlf4JW5qoM3nt47SU(object P_0)
	{
		return ((ButtonBase)P_0).CommandParameter;
	}

	internal static long QBqG7E4JtmRNo5FJfo18(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).dur26ZMhNI6();
	}

	internal static long keSCj84JUBejxjMnWcgC(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).QiM26r5xjnV();
	}

	internal static long NBSwDe4JTe3K4heErBFC(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).Hde26U5aaCi();
	}

	internal static bool ba8MkA4JynFBGfSAcTuM(double P_0)
	{
		return double.IsInfinity(P_0);
	}

	internal static object TJQ7pu4JZFdSaiI4lukA()
	{
		return j3bgDY9gV2i9bttJ1fiQ.ReversePosition();
	}

	internal static object zBFiCq4JVQdXEKWRuVrD()
	{
		return j3bgDY9gV2i9bttJ1fiQ.CancelAll();
	}

	internal static object J2eZmS4JCBuGyVXv7YIS()
	{
		return j3bgDY9gV2i9bttJ1fiQ.StopLoss();
	}

	internal static object H6QCeW4JrYlM5dDPyfqm(object P_0)
	{
		return DataManager.GetAccount((string)P_0);
	}

	internal static object OnDSL94JKTnH1mFUf3ur(object P_0)
	{
		return ((Account)P_0).ConnectionID;
	}

	internal static double IiWOuY4JmjSEMcZvqamR(object P_0, object P_1)
	{
		return DataManager.GetFreeMargin((string)P_0, (Symbol)P_1);
	}

	internal static bool dxjZPB4JhSLTbw5ewKE8(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool NhvJ9a4JwBW1dV4The7g(decimal P_0, decimal P_1)
	{
		return P_0 > P_1;
	}

	internal static object WHAVJ84J74QuDiI6kWv0(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).ChartingSettings;
	}

	internal static object KEWeCa4J88NSoOG5yT3F(object P_0)
	{
		return ((ChartSettings)P_0).TradeSettings;
	}

	internal static ChartPnlType nCykfw4JAKqAJY4JRRTa(object P_0)
	{
		return ((dyykKj9sS7wbwJvEPZ4K)P_0).PnlType;
	}

	internal static ChartPnlType Woy4014JPLIUSQWOuSUe(ChartPnlType P_0)
	{
		return G5WDO0fBspkJC1m1nhXd.uByfBd02EF7(P_0);
	}

	internal static int hCKH7i4JJdXEEyLFHr5b(object P_0)
	{
		return ((MouseButtonEventArgs)P_0).ClickCount;
	}

	internal static void YcamOf4JF4G1NAxMRnJy(object P_0, OnRZP7fwMaIGMRJa0UZR P_1)
	{
		((dyykKj9sS7wbwJvEPZ4K)P_0).PositionSizeDisplayType = P_1;
	}

	internal static bool stZafr4J3TAerPJnOiXZ(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderHidden;
	}

	internal static bool uDyf594JpvsIwKxGISrp(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderReduceOnly;
	}

	internal static bool Xo8Xhq4JugWxtsdnw82v(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderCloseOnly;
	}

	internal static void xTWNc54JzFEY6CPVp5ge(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0)[P_1] = P_2;
	}

	internal static ChartOrderType K6knfm4F0Pg5I5skZiy4(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderType;
	}

	internal static double kKMAow4F2uZsXqpMw3FV(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderQuantity;
	}

	internal static double af0Tev4FHyyJXTdSQiVC(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderPrice1;
	}

	internal static object DamhK34FfSgrdUcvhPA7(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.CFN9gJM2gRc(P_0, P_1, (Hashtable)P_2);
	}

	internal static object UsaE724F9KpZNrhZJj7L(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.I5i9gmr7kNO(P_0, P_1, (Hashtable)P_2);
	}

	internal static object Yud9Fb4FnNmt6NC6gWGu(double P_0, double P_1, object P_2)
	{
		return j3bgDY9gV2i9bttJ1fiQ.pOE9g3tXJ5M(P_0, P_1, (Hashtable)P_2);
	}

	internal static double V6bAqw4FGa8IQacmZMqd(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).OrderPrice2;
	}

	internal static object mO5qcU4FYO1kU2Rc4UGu(double P_0, double P_1, double P_2, object P_3)
	{
		return j3bgDY9gV2i9bttJ1fiQ.yqP9g7GncT4(P_0, P_1, P_2, (Hashtable)P_3);
	}

	internal static void OsO46y4FopUrC5idp5Hn(object P_0, object P_1)
	{
		((CR1isWfDCD1A4fwfUJUf)P_0).ExitStrategy = (string)P_1;
	}

	internal static object sMOjlt4FvPdx24dEYTGj()
	{
		return j3bgDY9gV2i9bttJ1fiQ.ExitStrategy();
	}

	internal static Guid n8k9uH4FBmNWPnaVMFkB()
	{
		return Guid.NewGuid();
	}

	internal static bool cdE3KF4Faof733v5Atp5(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).LinkToSymbol;
	}

	internal static object U0uNE64FixbkoNyUkA6M(object P_0)
	{
		return ((Tv9C1H26BMiXAuJrRQO7)P_0).SelectedStrategy;
	}

	internal static object HqpFUg4FluiSQwulX2cT()
	{
		return TigerTrade.Properties.Resources.ChartTraderControlRemoveStrategyMsg;
	}

	internal static bool RS7iJC4F41rEK1ag2WYb(object P_0, object P_1, object P_2)
	{
		return YesNoWindow.ShowWindow((Window)P_0, (string)P_1, (string)P_2);
	}

	internal static void umGDrZ4FDSVHGTN9gq06(object P_0)
	{
		T16LbD2WvuEJJRkHuI6J.Remove((string)P_0);
	}

	internal static void sZYOEL4FbHfEpVKk47Cy(object P_0, object P_1)
	{
		((ruI5XW2OJpKMlnG7xFDS)P_0).Ls62qoXGjhk = (string)P_1;
	}

	internal static object NdARDs4FNMRgijVBLZuG(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).JW82q2WZSBL;
	}

	internal static void GwQXth4FkhTxq7HBTbZr(object P_0)
	{
		((Collection<ex6KFw2WejF3Y0Rqo9YD>)P_0).Clear();
	}

	internal static object R83R184F1VfnbMAHijrS()
	{
		return TigerTrade.Properties.Resources.ChartTraderControlStrategyNone;
	}

	internal static object DmBX3b4F5gFaY1c1E8Pc(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).Ls62qoXGjhk;
	}

	internal static bool G30vmN4FSEBGLLfGOQwu(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object v0CCfY4FxamuppP6tUwT(object P_0)
	{
		return ((ruI5XW2OJpKMlnG7xFDS)P_0).StrategyName;
	}

	internal static void Qn6UeC4FLRQpJs3eQi8j(object P_0, object P_1)
	{
		((Tv9C1H26BMiXAuJrRQO7)P_0).SelectedStrategy = (ex6KFw2WejF3Y0Rqo9YD)P_1;
	}

	internal static bool G45glH4Fe7E6I5caZ0uj(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SaveSelectedExitStrategy;
	}

	internal static void gUom4i4Fsw8FD5ojVV8u(object P_0, bool P_1)
	{
		((Tv9C1H26BMiXAuJrRQO7)P_0).QhV2MUJhEDE(P_1);
	}

	internal static int lyatVI4FXniKuUtg1l7k(object P_0)
	{
		return ((MouseWheelEventArgs)P_0).Delta;
	}

	internal static void TgVygM4FcVN3C6YZFndu(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void zheB1q4FjCj3BxGcPIKd(object P_0, object P_1)
	{
		((UIElement)P_0).LostFocus += (RoutedEventHandler)P_1;
	}

	internal static void u0h8Bf4FEDVNFNkKeN7O()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
