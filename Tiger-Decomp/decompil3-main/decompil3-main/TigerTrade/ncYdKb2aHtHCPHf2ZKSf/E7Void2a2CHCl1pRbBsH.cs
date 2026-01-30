using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using dIk3mX23l260LgpAo3U7;
using ECOEgqlSad8NUJZ2Dr9n;
using MQCU1r2JmS7RUTRpngQN;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace ncYdKb2aHtHCPHf2ZKSf;

internal class E7Void2a2CHCl1pRbBsH : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private string m652aUmZtMY;

	private string eal2aTpQoGd;

	private DateTime HgS2ayLM0rB;

	private DateTime UZT2aZn47D2;

	private double HCH2aVkiSBp;

	private double m592aCCeofp;

	private Side LUt2ary85Gm;

	private double YNA2aKG2tXN;

	private double XAq2amWwS9Y;

	private double OVZ2ahuMCkm;

	private double Oxi2awi56F3;

	private string q3y2a7EMLpi;

	private string ASq2a8glYGP;

	private double YkR2aAqGRp0;

	private double rpT2aPqdqb2;

	[CompilerGenerated]
	private List<Side> luP2aJam8PB;

	private UserDeal OKS2aFg0KKs;

	private Symbol Rws2a3u4X9X;

	[CompilerGenerated]
	private bool y6S2apiMTBc;

	internal Eh9FNq23i1JY9nplrMpW AccountSelectCombo;

	internal Li572t2JKH213AbsVVkS SymbolSearchCombo;

	private bool pFj2auc3f5K;

	private static E7Void2a2CHCl1pRbBsH AbKYIj4qC7dmZUdHuqOc;

	public string Account
	{
		get
		{
			return m652aUmZtMY;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(text == m652aUmZtMY))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					m652aUmZtMY = text;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338766536));
					return;
				}
			}
		}
	}

	public string Symbol
	{
		get
		{
			return eal2aTpQoGd;
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
					if (!(text == eal2aTpQoGd))
					{
						eal2aTpQoGd = text;
						ifWlfmRSlkr((string)dId4964qmvNeJX2wfQ3E(0x86EFEF6 ^ 0x86EE19A));
						Symbol symbol = (Symbol)UIErfP4qhIIUwlubFFDb(eal2aTpQoGd);
						if (symbol == null)
						{
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
							{
								num2 = 0;
							}
						}
						else
						{
							PriceStep = POjJFV4qwfBrip316DcK(symbol);
							SizeStep = PMMIpQ4q7IDoQRuHllps(symbol);
							num2 = 3;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 3:
					return;
				case 2:
					return;
				}
			}
		}
	}

	public DateTime OpenTime
	{
		get
		{
			return HgS2ayLM0rB;
		}
		set
		{
			if (!(dateTime == HgS2ayLM0rB))
			{
				HgS2ayLM0rB = dateTime;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x60620FC1 ^ 0x606299AD));
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
	}

	public DateTime CloseTime
	{
		get
		{
			return UZT2aZn47D2;
		}
		set
		{
			if (!(dateTime == UZT2aZn47D2))
			{
				UZT2aZn47D2 = dateTime;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31A249));
			}
		}
	}

	public double OpenPrice
	{
		get
		{
			return HCH2aVkiSBp;
		}
		set
		{
			if (!hCH2aVkiSBp.Equals(HCH2aVkiSBp))
			{
				HCH2aVkiSBp = hCH2aVkiSBp;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7820C));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
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

	public double ClosePrice
	{
		get
		{
			return m592aCCeofp;
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
					if (!num3.Equals(m592aCCeofp))
					{
						m592aCCeofp = num3;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839665272));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Side Action
	{
		get
		{
			return LUt2ary85Gm;
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
					if (side != LUt2ary85Gm)
					{
						LUt2ary85Gm = side;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251569493));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public double MaxQuantity
	{
		get
		{
			return YNA2aKG2tXN;
		}
		set
		{
			if (num != YNA2aKG2tXN)
			{
				YNA2aKG2tXN = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECAA558));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
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

	public double Points
	{
		get
		{
			return XAq2amWwS9Y;
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
				case 1:
					if (num3 == XAq2amWwS9Y)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
						{
							num2 = 0;
						}
						break;
					}
					XAq2amWwS9Y = num3;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338796640));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public double Profit
	{
		get
		{
			return OVZ2ahuMCkm;
		}
		set
		{
			if (num != OVZ2ahuMCkm)
			{
				OVZ2ahuMCkm = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BFD976));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
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

	public double Comission
	{
		get
		{
			return Oxi2awi56F3;
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
					if (num3 != Oxi2awi56F3)
					{
						Oxi2awi56F3 = num3;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC98367));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Tags
	{
		get
		{
			return q3y2a7EMLpi;
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
				case 1:
					if (q3y2a7EMLpi == text)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
						{
							num2 = 0;
						}
						break;
					}
					q3y2a7EMLpi = text;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338797018));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public string Description
	{
		get
		{
			return ASq2a8glYGP;
		}
		set
		{
			if (!(ASq2a8glYGP == text))
			{
				ASq2a8glYGP = text;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7394EE82));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
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

	public double PriceStep
	{
		get
		{
			return YkR2aAqGRp0;
		}
		set
		{
			if (!ykR2aAqGRp.Equals(YkR2aAqGRp0))
			{
				YkR2aAqGRp0 = ykR2aAqGRp;
				ifWlfmRSlkr((string)dId4964qmvNeJX2wfQ3E(-2063361985 ^ -2063355827));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
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

	public double SizeStep
	{
		get
		{
			return rpT2aPqdqb2;
		}
		set
		{
			if (!num.Equals(rpT2aPqdqb2))
			{
				rpT2aPqdqb2 = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DE8C79));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
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

	public List<Side> Actions
	{
		[CompilerGenerated]
		get
		{
			return luP2aJam8PB;
		}
		[CompilerGenerated]
		set
		{
			luP2aJam8PB = list;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool cv12aIuwdxF()
	{
		return y6S2apiMTBc;
	}

	[SpecialName]
	[CompilerGenerated]
	public void RUR2aWl9RCM(bool P_0)
	{
		y6S2apiMTBc = P_0;
	}

	public E7Void2a2CHCl1pRbBsH()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				InitializeComponent();
				return;
			}
			PriceStep = 1.0;
			SizeStep = 1.0;
			Actions = new List<Side>
			{
				Side.Buy,
				Side.Sell
			};
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
			{
				num = 1;
			}
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					AccountSelectCombo.IsEnabled = cv12aIuwdxF();
					if (!cv12aIuwdxF())
					{
						goto end_IL_0012;
					}
					OpenTime = CpYG5g4q8ZZjuA75Cry5();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					SymbolSearchCombo.IsEnabled = cv12aIuwdxF();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					Points = OKS2aFg0KKs.Points;
					Profit = OKS2aFg0KKs.Profit;
					Comission = OKS2aFg0KKs.Comission;
					Tags = OKS2aFg0KKs.Tags;
					Description = OKS2aFg0KKs.Description;
					return;
				case 8:
					Action = OKS2aFg0KKs.Side;
					num2 = 6;
					break;
				case 5:
					ClosePrice = OKS2aFg0KKs.ClosePrice;
					num2 = 8;
					break;
				default:
					CloseTime = DateTime.Now;
					return;
				case 6:
					MaxQuantity = OKS2aFg0KKs.MaxQuantity;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
					{
						num2 = 3;
					}
					break;
				case 7:
					CloseTime = rdcshR4qJQ2EV8B0Z8wT(Rws2a3u4X9X, JmVj7K4qP5a38OdFgffa(OKS2aFg0KKs));
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					OpenTime = Rws2a3u4X9X.ConvertTimeToLocal(DvL0gF4qA2KJPytHtrXC(OKS2aFg0KKs));
					OpenPrice = OKS2aFg0KKs.OpenPrice;
					num2 = 7;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			Rws2a3u4X9X = (Symbol)UIErfP4qhIIUwlubFFDb(OKS2aFg0KKs.SymbolID);
			Symbol = OKS2aFg0KKs.SymbolID;
			Account = OKS2aFg0KKs.AccountID;
			num = 4;
		}
	}

	private void SMK2af9u7EG(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		int num;
		if (!cv12aIuwdxF())
		{
			num = 14;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
			{
				num = 9;
			}
			goto IL_0009;
		}
		goto IL_0386;
		IL_0009:
		Symbol symbol = default(Symbol);
		Account account = default(Account);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 11:
				OKS2aFg0KKs.OpenPrice = OpenPrice;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				if (symbol != null)
				{
					num = 13;
					continue;
				}
				return;
			case 13:
				if (account == null)
				{
					return;
				}
				dlo0vw4q3Sv9YamfaDnl(OKS2aFg0KKs, tG8TAK4qFrt5kXob6ng2(symbol));
				RWrPxh4qupBoL3Jmf38V(OKS2aFg0KKs, pvju4k4qpm3GnAvEGoQK(symbol));
				OKS2aFg0KKs.AccountID = account.AccountID;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
				{
					num = 2;
				}
				continue;
			case 5:
				OKS2aFg0KKs.MaxQuantity = MaxQuantity;
				OKS2aFg0KKs.Points = Points;
				OxLrSG4I2sE3fdaEw0IY(OKS2aFg0KKs, Profit);
				kOWI4Z4IH4Tf1NkMIW88(OKS2aFg0KKs, Comission);
				weKcAA4IfPtdojnCLTHy(OKS2aFg0KKs, Tags);
				Mly25y4I9rNbcqOTVwjo(OKS2aFg0KKs, Description);
				goto case 8;
			default:
				OKS2aFg0KKs.CloseTime = Rws2a3u4X9X.ConvertTimeFromLocal(CloseTime);
				BJI6kC4I0LZG1jEO4tMP(OKS2aFg0KKs, ClosePrice);
				XKcwTk4IYjZF5hp8fJGU(OKS2aFg0KKs, Action);
				num = 9;
				continue;
			case 12:
				OKS2aFg0KKs.Description = Description;
				num2 = 8;
				goto IL_0005;
			case 10:
				OKS2aFg0KKs.Comission = Comission;
				OKS2aFg0KKs.Tags = Tags;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num = 12;
				}
				continue;
			case 2:
				OKS2aFg0KKs.AccountName = account.Name;
				OKS2aFg0KKs.OpenTime = symbol.ConvertTimeFromLocal(OpenTime);
				OKS2aFg0KKs.OpenPrice = OpenPrice;
				num = 7;
				continue;
			case 7:
				WOBLgi4qz4a06NZLGGB9(OKS2aFg0KKs, symbol.ConvertTimeFromLocal(CloseTime));
				BJI6kC4I0LZG1jEO4tMP(OKS2aFg0KKs, ClosePrice);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num = 4;
				}
				continue;
			case 4:
				OKS2aFg0KKs.Side = Action;
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num = 5;
				}
				continue;
			case 9:
				OKS2aFg0KKs.MaxQuantity = MaxQuantity;
				OKS2aFg0KKs.Points = Points;
				OKS2aFg0KKs.Profit = Profit;
				num = 10;
				continue;
			case 8:
				Close();
				return;
			case 1:
			case 14:
				QIANNL4IGG9jm8rusa6s(OKS2aFg0KKs, Fe1aB04In5Z2d4pMQvir(Rws2a3u4X9X, OpenTime));
				num2 = 11;
				goto IL_0005;
			case 6:
				break;
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		goto IL_0386;
		IL_0386:
		symbol = SymbolManager.Get(Symbol);
		account = DataManager.GetAccount(Account);
		num = 3;
		goto IL_0009;
	}

	private void a812a9IpKmV(object P_0, RoutedEventArgs P_1)
	{
		TGrTOS4IoFWIlTAuGdR9(this);
	}

	public static bool FUl2anXWvyW(Window P_0, bool P_1, UserDeal P_2)
	{
		E7Void2a2CHCl1pRbBsH e7Void2a2CHCl1pRbBsH = new E7Void2a2CHCl1pRbBsH();
		e7Void2a2CHCl1pRbBsH.Owner = P_0;
		e7Void2a2CHCl1pRbBsH.RUR2aWl9RCM(P_1);
		e7Void2a2CHCl1pRbBsH.OKS2aFg0KKs = P_2;
		return e7Void2a2CHCl1pRbBsH.ShowDialog() == true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!pFj2auc3f5K)
		{
			pFj2auc3f5K = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841462589), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)X3UgUf4IvSRUJykY9DyF(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		default:
			pFj2auc3f5K = true;
			break;
		case 1:
			AccountSelectCombo = (Eh9FNq23i1JY9nplrMpW)P_1;
			break;
		case 3:
			((Button)P_1).Click += SMK2af9u7EG;
			num = 2;
			goto IL_0009;
		case 4:
			UZ8Hli4IBP11EoxHQGRh((Button)P_1, new RoutedEventHandler(a812a9IpKmV));
			break;
		case 2:
			{
				SymbolSearchCombo = (Li572t2JKH213AbsVVkS)P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
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
			case 1:
				break;
			case 0:
				return;
			case 2:
				return;
			}
			goto case 1;
		}
	}

	static E7Void2a2CHCl1pRbBsH()
	{
		oevHpw4IapM5vdWcSG1e();
	}

	internal static bool U1JnxW4qrfxlAjC5JkTr()
	{
		return AbKYIj4qC7dmZUdHuqOc == null;
	}

	internal static E7Void2a2CHCl1pRbBsH QvOi034qK1uLbaQsS1wv()
	{
		return AbKYIj4qC7dmZUdHuqOc;
	}

	internal static object dId4964qmvNeJX2wfQ3E(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object UIErfP4qhIIUwlubFFDb(object P_0)
	{
		return SymbolManager.Get((string)P_0);
	}

	internal static double POjJFV4qwfBrip316DcK(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static double PMMIpQ4q7IDoQRuHllps(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static DateTime CpYG5g4q8ZZjuA75Cry5()
	{
		return DateTime.Now;
	}

	internal static DateTime DvL0gF4qA2KJPytHtrXC(object P_0)
	{
		return ((UserDeal)P_0).OpenTime;
	}

	internal static DateTime JmVj7K4qP5a38OdFgffa(object P_0)
	{
		return ((UserDeal)P_0).CloseTime;
	}

	internal static DateTime rdcshR4qJQ2EV8B0Z8wT(object P_0, DateTime P_1)
	{
		return ((Symbol)P_0).ConvertTimeToLocal(P_1);
	}

	internal static object tG8TAK4qFrt5kXob6ng2(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void dlo0vw4q3Sv9YamfaDnl(object P_0, object P_1)
	{
		((UserDeal)P_0).SymbolID = (string)P_1;
	}

	internal static object pvju4k4qpm3GnAvEGoQK(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static void RWrPxh4qupBoL3Jmf38V(object P_0, object P_1)
	{
		((UserDeal)P_0).SymbolName = (string)P_1;
	}

	internal static void WOBLgi4qz4a06NZLGGB9(object P_0, DateTime P_1)
	{
		((UserDeal)P_0).CloseTime = P_1;
	}

	internal static void BJI6kC4I0LZG1jEO4tMP(object P_0, double P_1)
	{
		((UserDeal)P_0).ClosePrice = P_1;
	}

	internal static void OxLrSG4I2sE3fdaEw0IY(object P_0, double P_1)
	{
		((UserDeal)P_0).Profit = P_1;
	}

	internal static void kOWI4Z4IH4Tf1NkMIW88(object P_0, double P_1)
	{
		((UserDeal)P_0).Comission = P_1;
	}

	internal static void weKcAA4IfPtdojnCLTHy(object P_0, object P_1)
	{
		((UserDeal)P_0).Tags = (string)P_1;
	}

	internal static void Mly25y4I9rNbcqOTVwjo(object P_0, object P_1)
	{
		((UserDeal)P_0).Description = (string)P_1;
	}

	internal static DateTime Fe1aB04In5Z2d4pMQvir(object P_0, DateTime P_1)
	{
		return ((Symbol)P_0).ConvertTimeFromLocal(P_1);
	}

	internal static void QIANNL4IGG9jm8rusa6s(object P_0, DateTime P_1)
	{
		((UserDeal)P_0).OpenTime = P_1;
	}

	internal static void XKcwTk4IYjZF5hp8fJGU(object P_0, Side P_1)
	{
		((UserDeal)P_0).Side = P_1;
	}

	internal static void TGrTOS4IoFWIlTAuGdR9(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object X3UgUf4IvSRUJykY9DyF(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void UZ8Hli4IBP11EoxHQGRh(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void oevHpw4IapM5vdWcSG1e()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
