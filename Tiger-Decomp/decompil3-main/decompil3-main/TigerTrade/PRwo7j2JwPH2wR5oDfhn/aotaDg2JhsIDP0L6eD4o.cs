using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using cIbiwrHkfBj4h5ErI7rI;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using isnQObHkoBLhLETXDS3X;
using LxkBMPH3MZ8ObkVk5Atk;
using TigerTrade.Config.Common;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using v0gxFx27QfQao4Ot85dR;
using waDpctGJom9MvAveNXHq;
using wE4CpeH3AF16tgcTfoUP;
using xfdMo0lS4TP9pN36Goka;
using XsDptMfu1TZDPkNQ2KkJ;

namespace PRwo7j2JwPH2wR5oDfhn;

internal sealed class aotaDg2JhsIDP0L6eD4o : aUQvKjHk6H77hbYGG0GM, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private sealed class Xdbr4dnI2sLSLnc9FveG
	{
		public aotaDg2JhsIDP0L6eD4o TJAnIf9hQib;

		public Symbol HRHnI9RvrOu;

		internal static Xdbr4dnI2sLSLnc9FveG TtoBy4N1lhW9rvFulyBq;

		public Xdbr4dnI2sLSLnc9FveG()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void B92nIHMZ2sP()
		{
			int num = 1;
			int num2 = num;
			object kuv2FUuYvWq = default(object);
			while (true)
			{
				switch (num2)
				{
				case 1:
					kuv2FUuYvWq = TJAnIf9hQib.kuv2FUuYvWq;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(kuv2FUuYvWq, ref lockTaken);
					Dictionary<Symbol, string> dictionary = TJAnIf9hQib.jMC2JFTTYhr(new List<Symbol> { HRHnI9RvrOu });
					string value = TJAnIf9hQib.MNc2F9pBP0S(HRHnI9RvrOu.Name);
					if (X5sagrN1bm7UDEGgiCK7(dictionary) <= 0)
					{
						return;
					}
					int num3;
					if (TJAnIf9hQib.F7P2JulFNFT(new KeyValuePair<Symbol, string>(HRHnI9RvrOu, value), TJAnIf9hQib.Rub2FtApcNU))
					{
						TJAnIf9hQib.Symbols.Add(HRHnI9RvrOu);
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num3 = 0;
						}
						goto IL_0037;
					}
					goto IL_008d;
					IL_008d:
					if (TJAnIf9hQib.MMx2FWHuiUj != null)
					{
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
						{
							num3 = 1;
						}
						goto IL_0037;
					}
					return;
					IL_0037:
					switch (num3)
					{
					case 1:
						TJAnIf9hQib.MMx2FWHuiUj[HRHnI9RvrOu] = value;
						return;
					}
					goto IL_008d;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(kuv2FUuYvWq);
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
			}
		}

		static Xdbr4dnI2sLSLnc9FveG()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool LG0CXHN14TXywEKOCkn2()
		{
			return TtoBy4N1lhW9rvFulyBq == null;
		}

		internal static Xdbr4dnI2sLSLnc9FveG kLrLR7N1DTVcY2w1kqRt()
		{
			return TtoBy4N1lhW9rvFulyBq;
		}

		internal static int X5sagrN1bm7UDEGgiCK7(object P_0)
		{
			return ((Dictionary<Symbol, string>)P_0).Count;
		}
	}

	[CompilerGenerated]
	private sealed class urORbBnInhXdPHbl0tsD
	{
		public HashSet<string> LR0nIY55c5i;

		internal static urORbBnInhXdPHbl0tsD HjUEJjN1NyQihEWwQyFq;

		public urORbBnInhXdPHbl0tsD()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool jAXnIGYm6c3(Symbol s)
		{
			if (s.IsGateIo || !LR0nIY55c5i.Contains((string)(vbrANbN1S7PqjtrqAtHm(dyT80MN15CNX2W39XKY1(s)) ? s.Exchange : gh6mZeN1x8thn7dBjlUw(0x4220DA8 ^ 0x4268850))))
			{
				if (s.IsGateIo)
				{
					return LR0nIY55c5i.Contains(s.Exchange + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90299776) + (cZ98Z2N1LtcDnxSxuERg(s) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3301FA65) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E041C40)));
				}
				return false;
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => true, 
			};
		}

		static urORbBnInhXdPHbl0tsD()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool PZ7YAwN1kZ476g3MuRjY()
		{
			return HjUEJjN1NyQihEWwQyFq == null;
		}

		internal static urORbBnInhXdPHbl0tsD iciJB4N11ISb05W5KxSK()
		{
			return HjUEJjN1NyQihEWwQyFq;
		}

		internal static object dyT80MN15CNX2W39XKY1(object P_0)
		{
			return ((SymbolBase)P_0).Exchange;
		}

		internal static bool vbrANbN1S7PqjtrqAtHm(object P_0)
		{
			return JLFqEJGJYiHaSdoROJXI.WTeGJv6DrNH((string)P_0);
		}

		internal static object gh6mZeN1x8thn7dBjlUw(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static bool cZ98Z2N1LtcDnxSxuERg(object P_0)
		{
			return ((Symbol)P_0).IsCryptoFuture;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class lItJKgnIobNuHR0acq02
	{
		public static readonly lItJKgnIobNuHR0acq02 ECEnIDDppWm;

		public static Func<Symbol, bool> YXPnIbSEXfA;

		public static Func<Symbol, bool> KIdnINJAbq5;

		public static Func<Symbol, bool> ehDnIkpOt0y;

		public static Func<Symbol, Symbol> arPnI1Ma96L;

		public static Func<Symbol, string> LcbnI521Igb;

		public static Func<KeyValuePair<Symbol, string>, Symbol> HwsnISwGohe;

		internal static lItJKgnIobNuHR0acq02 ugf2JIN1eVhyjNrpIlMT;

		static lItJKgnIobNuHR0acq02()
		{
			NBwyNoN1c9yBdeg0Do68();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			ECEnIDDppWm = new lItJKgnIobNuHR0acq02();
		}

		public lItJKgnIobNuHR0acq02()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool wNdnIvCHfyA(Symbol w)
		{
			if (AGQE8ZN1jYuWNv633lCI(w) == SymbolType.Future)
			{
				if (w.IsCryptoFuture)
				{
					if (!SORCcJN1E1y7iF7EK1Zl(w))
					{
						goto IL_0067;
					}
				}
				else
				{
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				return !lV8muNN1QNRifEPNCUS4(w);
			}
			goto IL_0067;
			IL_0067:
			return true;
		}

		internal bool bJwnIBhlgxK(Symbol w)
		{
			return w.Type == SymbolType.Crypto;
		}

		internal bool xgtnIawlKS6(Symbol w)
		{
			if (w.IsCrypto)
			{
				return AGQE8ZN1jYuWNv633lCI(w) == SymbolType.Future;
			}
			return false;
		}

		internal Symbol QHenIiWLFVy(Symbol key)
		{
			return key;
		}

		internal string iWInIlcLG46(Symbol s)
		{
			return (string)vj0ABJN1deeXVlBhJhBZ(s);
		}

		internal Symbol AajnI4oCkJe(KeyValuePair<Symbol, string> symbol)
		{
			return symbol.Key;
		}

		internal static void NBwyNoN1c9yBdeg0Do68()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool SZVnyuN1st8m5VULuurp()
		{
			return ugf2JIN1eVhyjNrpIlMT == null;
		}

		internal static lItJKgnIobNuHR0acq02 pU39FMN1Xo7Nt8Nq036Q()
		{
			return ugf2JIN1eVhyjNrpIlMT;
		}

		internal static SymbolType AGQE8ZN1jYuWNv633lCI(object P_0)
		{
			return ((Symbol)P_0).Type;
		}

		internal static bool SORCcJN1E1y7iF7EK1Zl(object P_0)
		{
			return ((Symbol)P_0).IsMaster;
		}

		internal static bool lV8muNN1QNRifEPNCUS4(object P_0)
		{
			return ((Symbol)P_0).IsCryptoFuture;
		}

		internal static object vj0ABJN1deeXVlBhJhBZ(object P_0)
		{
			return ((Symbol)P_0).Name;
		}
	}

	[CompilerGenerated]
	private sealed class b7FNEenIxDoEVZ6nyDIh
	{
		public aotaDg2JhsIDP0L6eD4o P8LnIeZLHnc;

		public string a7cnIsXy6Gd;

		private static b7FNEenIxDoEVZ6nyDIh j6krt5N1gFt3OKKBSE17;

		public b7FNEenIxDoEVZ6nyDIh()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool mnhnILTV323(KeyValuePair<Symbol, string> symbol)
		{
			return P8LnIeZLHnc.F7P2JulFNFT(symbol, a7cnIsXy6Gd);
		}

		static b7FNEenIxDoEVZ6nyDIh()
		{
			oCvuxlN1MaGCIC1XJCVZ();
		}

		internal static bool E7fHdeN1RgWkNl7k8qq4()
		{
			return j6krt5N1gFt3OKKBSE17 == null;
		}

		internal static b7FNEenIxDoEVZ6nyDIh UKDDbcN16ZLJ64tXiFEV()
		{
			return j6krt5N1gFt3OKKBSE17;
		}

		internal static void oCvuxlN1MaGCIC1XJCVZ()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private Dictionary<Symbol, string> MMx2FWHuiUj;

	private string Rub2FtApcNU;

	private readonly object kuv2FUuYvWq;

	public static readonly DependencyProperty WTY2FTcmGg5;

	public static readonly DependencyProperty YuZ2FytVYvD;

	public static readonly DependencyProperty mYC2FZhbBvV;

	public static readonly DependencyProperty Ydq2FV3ixGF;

	public static readonly DependencyProperty JjS2FCc4RJ4;

	public static readonly DependencyProperty c8T2FrpcHK4;

	public static readonly DependencyProperty bS32FKepTD3;

	public static readonly DependencyProperty F0a2Fm9v9GH;

	public static readonly DependencyProperty ARY2Fhs92pI;

	public static readonly DependencyProperty fjC2FwBMyqD;

	[CompilerGenerated]
	private readonly List<string> DQi2F71xwtc;

	[CompilerGenerated]
	private Action<Symbol> m_SymbolSelected;

	private string x9e2F8DCCGr;

	[CompilerGenerated]
	private LOaTZ5HkYs6IUi82qZ8y<Symbol> IOE2FA3Q4Zj;

	private Symbol eOv2FPHQDjc;

	private Symbol Y0r2FJbc1Cd;

	internal TextBox TextBoxSearch;

	internal ListView SymbolsList;

	private bool oQH2FFduyLu;

	private static aotaDg2JhsIDP0L6eD4o t9tjJMDYeuWvxnxXXPoQ;

	public bool IsAutoFocus
	{
		get
		{
			return (bool)GetValue(WTY2FTcmGg5);
		}
		set
		{
			SetValue(WTY2FTcmGg5, flag);
		}
	}

	public bool ShowIndexes
	{
		get
		{
			return (bool)GetValue(YuZ2FytVYvD);
		}
		set
		{
			SetValue(YuZ2FytVYvD, flag);
		}
	}

	public bool ShowFavorites
	{
		get
		{
			return (bool)GetValue(mYC2FZhbBvV);
		}
		set
		{
			SetValue(mYC2FZhbBvV, flag);
		}
	}

	public bool CurrentFutures
	{
		get
		{
			return (bool)GetValue(Ydq2FV3ixGF);
		}
		set
		{
			kccY82DYc6dj6QPoy3xG(this, Ydq2FV3ixGF, flag);
		}
	}

	public Thickness InnerBorderThickness
	{
		get
		{
			return (Thickness)GetValue(JjS2FCc4RJ4);
		}
		set
		{
			kccY82DYc6dj6QPoy3xG(this, JjS2FCc4RJ4, thickness);
		}
	}

	public bfvIex27Er0lPTIgUD0b MarketLocked
	{
		get
		{
			return (bfvIex27Er0lPTIgUD0b)GetValue(c8T2FrpcHK4);
		}
		set
		{
			SetValue(c8T2FrpcHK4, bfvIex27Er0lPTIgUD0b);
		}
	}

	public string CurrentExchange
	{
		get
		{
			return (string)GetValue(bS32FKepTD3);
		}
		set
		{
			SetValue(bS32FKepTD3, value2);
		}
	}

	public bool IsExchangeLocked
	{
		get
		{
			return (bool)GetValue(F0a2Fm9v9GH);
		}
		set
		{
			SetValue(F0a2Fm9v9GH, flag);
		}
	}

	public string LockedExchange
	{
		get
		{
			return (string)GetValue(ARY2Fhs92pI);
		}
		set
		{
			kccY82DYc6dj6QPoy3xG(this, ARY2Fhs92pI, text);
		}
	}

	public string Value
	{
		get
		{
			return (string)GetValue(fjC2FwBMyqD);
		}
		set
		{
			SetValue(fjC2FwBMyqD, value2);
		}
	}

	public string SearchString
	{
		get
		{
			return x9e2F8DCCGr;
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
					x9e2F8DCCGr = text;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					cY7HkOvo1nf((string)zgjRhDDYdXiyPr1OVOoN(0x2D313048 ^ 0x2D311BBC));
					lay2J3FdD1u(x9e2F8DCCGr);
					return;
				}
			}
		}
	}

	public LOaTZ5HkYs6IUi82qZ8y<Symbol> Symbols
	{
		[CompilerGenerated]
		get
		{
			return IOE2FA3Q4Zj;
		}
		[CompilerGenerated]
		set
		{
			IOE2FA3Q4Zj = iOE2FA3Q4Zj;
		}
	}

	public Symbol SelectedSymbol
	{
		get
		{
			return eOv2FPHQDjc;
		}
		set
		{
			Symbol symbol = (eOv2FPHQDjc = symbol2);
			cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x1198053));
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					Y0r2FJbc1Cd = null;
					Value = symbol.ID;
					return;
				case 2:
				{
					if (symbol == null)
					{
						return;
					}
					Action<Symbol> action = this.SymbolSelected;
					if (action == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
						{
							num = 0;
						}
						break;
					}
					action(symbol);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
					{
						num = 1;
					}
					break;
				}
				}
			}
		}
	}

	public Symbol HoveredSymbol
	{
		get
		{
			return Y0r2FJbc1Cd;
		}
		set
		{
			Y0r2FJbc1Cd = y0r2FJbc1Cd;
			cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839696552));
		}
	}

	public event Action<Symbol> SymbolSelected
	{
		[CompilerGenerated]
		add
		{
			Action<Symbol> action = this.m_SymbolSelected;
			Action<Symbol> action2;
			do
			{
				action2 = action;
				Action<Symbol> value2 = (Action<Symbol>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_SymbolSelected, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<Symbol> action = this.m_SymbolSelected;
			Action<Symbol> action2;
			do
			{
				action2 = action;
				Action<Symbol> value2 = (Action<Symbol>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_SymbolSelected, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public List<string> tij2FcYYKvp()
	{
		return DQi2F71xwtc;
	}

	public aotaDg2JhsIDP0L6eD4o()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		kuv2FUuYvWq = new object();
		DQi2F71xwtc = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				InitializeComponent();
				num = 2;
				continue;
			case 2:
				SymbolManager.FavoritesReady += R0O2JJUB7ms;
				return;
			}
			Symbols = new LOaTZ5HkYs6IUi82qZ8y<Symbol>();
			g8QXObDYjLmI9QFLUnbu(this, new RoutedEventHandler(bPn2JPY8tpx));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num = 1;
			}
		}
	}

	private static void sIH2J7ZFxEN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is aotaDg2JhsIDP0L6eD4o aotaDg2JhsIDP0L6eD4o2))
		{
			return;
		}
		aotaDg2JhsIDP0L6eD4o2.MMx2FWHuiUj = null;
		if (!hyZ43GDYEv9RThaob6Lu(aotaDg2JhsIDP0L6eD4o2))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
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
			aotaDg2JhsIDP0L6eD4o2.lay2J3FdD1u(aotaDg2JhsIDP0L6eD4o2.SearchString ?? "");
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
			{
				num = 1;
			}
		}
	}

	private static void k4k2J8gq3OJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is aotaDg2JhsIDP0L6eD4o aotaDg2JhsIDP0L6eD4o2))
		{
			return;
		}
		aotaDg2JhsIDP0L6eD4o2.MMx2FWHuiUj = null;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!hyZ43GDYEv9RThaob6Lu(aotaDg2JhsIDP0L6eD4o2))
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
				{
					num = 0;
				}
				break;
			default:
				aotaDg2JhsIDP0L6eD4o2.lay2J3FdD1u(aotaDg2JhsIDP0L6eD4o2.SearchString ?? "");
				return;
			}
		}
	}

	private void nv32JAv6ixR(Symbol P_0)
	{
		int num = 2;
		int num2 = num;
		Xdbr4dnI2sLSLnc9FveG xdbr4dnI2sLSLnc9FveG = default(Xdbr4dnI2sLSLnc9FveG);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				xdbr4dnI2sLSLnc9FveG = new Xdbr4dnI2sLSLnc9FveG();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				xdbr4dnI2sLSLnc9FveG.TJAnIf9hQib = this;
				xdbr4dnI2sLSLnc9FveG.HRHnI9RvrOu = P_0;
				if (!base.IsVisible)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num2 = 0;
					}
					break;
				}
				CS1Nh2DYQbQoIHQ0aCvR(base.Dispatcher, new Action(xdbr4dnI2sLSLnc9FveG.B92nIHMZ2sP), Array.Empty<object>());
				return;
			}
		}
	}

	private void bPn2JPY8tpx(object P_0, RoutedEventArgs P_1)
	{
		if (IsAutoFocus)
		{
			TextBoxSearch.Focus();
		}
	}

	private void R0O2JJUB7ms()
	{
		Symbols.Clear();
		SelectedSymbol = null;
		int num;
		IEnumerator<p4gwA9H36qTSRys5LY33> enumerator = default(IEnumerator<p4gwA9H36qTSRys5LY33>);
		if (!ShowFavorites)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
			{
				num = 0;
			}
		}
		else
		{
			enumerator = vUDXImH38MJqxh3d1b5K.XerH33ZuLFy().GetEnumerator();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			try
			{
				while (enumerator.MoveNext())
				{
					Symbol symbol = (Symbol)wKcIN9DYglgMtgXT2jAW(enumerator.Current.QA0H3WLB2Gj);
					int num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							Symbols.Add(symbol);
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
							if (symbol != null && (ShowIndexes || symbol.Type != SymbolType.Index) && !Kn3NMtHkHjy4eIsknyks.BTsHk9LkJvJ(symbol))
							{
								num2 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
								{
									num2 = 2;
								}
								continue;
							}
							break;
						}
						break;
					}
				}
				break;
			}
			finally
			{
				if (enumerator != null)
				{
					sOROBCDYR0cBq03fQ8vi(enumerator);
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		case 0:
			break;
		}
	}

	private Dictionary<Symbol, string> jMC2JFTTYhr(IList<Symbol> P_0)
	{
		List<Symbol> source = (from symbol in P_0.Where(delegate(Symbol w)
			{
				if (lItJKgnIobNuHR0acq02.AGQE8ZN1jYuWNv633lCI(w) == SymbolType.Future)
				{
					if (w.IsCryptoFuture)
					{
						if (!lItJKgnIobNuHR0acq02.SORCcJN1E1y7iF7EK1Zl(w))
						{
							goto IL_0067;
						}
					}
					else
					{
						int num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
						{
							num = 0;
						}
						switch (num)
						{
						}
					}
					return !lItJKgnIobNuHR0acq02.lV8muNN1QNRifEPNCUS4(w);
				}
				goto IL_0067;
				IL_0067:
				return true;
			})
			where !tij2FcYYKvp().Contains(symbol.ID)
			select symbol).ToList();
		if (MarketLocked != bfvIex27Er0lPTIgUD0b.None && j18iDj9nukSCmEyZs5lH.Settings.ShowOnlyLockedMarketSymbols)
		{
			switch (MarketLocked)
			{
			case (bfvIex27Er0lPTIgUD0b)2:
				source = source.Where((Symbol w) => w.Type == SymbolType.Crypto).ToList();
				break;
			case (bfvIex27Er0lPTIgUD0b)1:
				source = source.Where((Symbol w) => w.IsCrypto && lItJKgnIobNuHR0acq02.AGQE8ZN1jYuWNv633lCI(w) == SymbolType.Future).ToList();
				break;
			}
		}
		if (j18iDj9nukSCmEyZs5lH.Settings.HideDisconnectedSymbols && j18iDj9nukSCmEyZs5lH.Settings.TradeMode != AppTradeMode.Player)
		{
			urORbBnInhXdPHbl0tsD CS_0024_003C_003E8__locals3 = new urORbBnInhXdPHbl0tsD();
			CS_0024_003C_003E8__locals3.LR0nIY55c5i = JLFqEJGJYiHaSdoROJXI.aFKGJBIwWtd();
			source = source.Where(delegate(Symbol s)
			{
				if (!s.IsGateIo && CS_0024_003C_003E8__locals3.LR0nIY55c5i.Contains((string)(urORbBnInhXdPHbl0tsD.vbrANbN1S7PqjtrqAtHm(urORbBnInhXdPHbl0tsD.dyT80MN15CNX2W39XKY1(s)) ? s.Exchange : urORbBnInhXdPHbl0tsD.gh6mZeN1x8thn7dBjlUw(0x4220DA8 ^ 0x4268850))))
				{
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
					{
						num = 0;
					}
					return num switch
					{
						_ => true, 
					};
				}
				return s.IsGateIo && CS_0024_003C_003E8__locals3.LR0nIY55c5i.Contains(s.Exchange + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90299776) + (urORbBnInhXdPHbl0tsD.cZ98Z2N1LtcDnxSxuERg(s) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3301FA65) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E041C40)));
			}).ToList();
		}
		return source.ToDictionary((Symbol key) => key, (Symbol symbol) => MNc2F9pBP0S((string)GJsjUvDYKdhoHx68UcHb(symbol)));
	}

	private void lay2J3FdD1u(string P_0)
	{
		int num;
		if (!string.IsNullOrEmpty(P_0))
		{
			SelectedSymbol = null;
			if (MMx2FWHuiUj != null)
			{
				goto IL_01b5;
			}
			MMx2FWHuiUj = jMC2JFTTYhr(SymbolManager.GetAll());
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
			{
				num = 0;
			}
		}
		else
		{
			R0O2JJUB7ms();
			MMx2FWHuiUj = jMC2JFTTYhr(SymbolManager.GetAll());
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
			{
				num = 3;
			}
		}
		goto IL_0009;
		IL_0009:
		string text = default(string);
		List<Symbol> list = default(List<Symbol>);
		IEnumerable<Symbol> source = default(IEnumerable<Symbol>);
		Dictionary<Symbol, string> dictionary = default(Dictionary<Symbol, string>);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				Rub2FtApcNU = string.Empty;
				int num2 = 6;
				num = num2;
				continue;
			}
			case 1:
				Rub2FtApcNU = text;
				list = source.ToList();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num = 0;
				}
				continue;
			default:
				IjrUxDDY6k17peOWjanZ(Symbols);
				Symbols.X9ZHkvvG9Ps(list);
				return;
			case 5:
				break;
			case 3:
				Rub2FtApcNU = string.Empty;
				return;
			case 6:
				goto end_IL_0009;
			case 7:
				source = wrs2JpmKPX9(dictionary, text);
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
				{
					num = 4;
				}
				continue;
			case 4:
				goto IL_01e9;
			}
			if (text.StartsWith(Rub2FtApcNU))
			{
				dictionary = jMC2JFTTYhr(Symbols);
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
				{
					num = 7;
				}
				continue;
			}
			goto IL_00e1;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_01b5;
		IL_01e9:
		source = source.OrderBy((Symbol s) => (string)lItJKgnIobNuHR0acq02.vj0ABJN1deeXVlBhJhBZ(s));
		num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_00e1:
		source = wrs2JpmKPX9(MMx2FWHuiUj, text);
		goto IL_01e9;
		IL_01b5:
		text = MNc2F9pBP0S(P_0);
		if (!string.IsNullOrEmpty(Rub2FtApcNU))
		{
			num = 5;
			goto IL_0009;
		}
		goto IL_00e1;
	}

	private IEnumerable<Symbol> wrs2JpmKPX9(IEnumerable<KeyValuePair<Symbol, string>> P_0, string P_1)
	{
		b7FNEenIxDoEVZ6nyDIh CS_0024_003C_003E8__locals6 = new b7FNEenIxDoEVZ6nyDIh();
		CS_0024_003C_003E8__locals6.P8LnIeZLHnc = this;
		CS_0024_003C_003E8__locals6.a7cnIsXy6Gd = P_1;
		CS_0024_003C_003E8__locals6.a7cnIsXy6Gd = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203060420) + CS_0024_003C_003E8__locals6.a7cnIsXy6Gd;
		return from symbol in P_0
			where CS_0024_003C_003E8__locals6.P8LnIeZLHnc.F7P2JulFNFT(symbol, CS_0024_003C_003E8__locals6.a7cnIsXy6Gd)
			select symbol.Key;
	}

	private bool F7P2JulFNFT(KeyValuePair<Symbol, string> P_0, string P_1)
	{
		Symbol key = P_0.Key;
		string value = P_0.Value;
		if (!ShowIndexes && key.Type == SymbolType.Index)
		{
			return false;
		}
		if (Kn3NMtHkHjy4eIsknyks.BTsHk9LkJvJ(key))
		{
			return false;
		}
		if (string.IsNullOrEmpty(P_1))
		{
			return false;
		}
		return Regex.IsMatch(value, P_1, RegexOptions.IgnoreCase);
	}

	private void qrZ2JzhuAHk(object P_0, KeyEventArgs P_1)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (P_1.Key != Key.Back && Symbols != null)
				{
					num2 = 2;
					break;
				}
				return;
			default:
				Value = HoveredSymbol.ID;
				Y0r2FJbc1Cd = null;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 2:
			{
				if (Symbols.Count == 0)
				{
					return;
				}
				HoveredSymbol = HoveredSymbol ?? Symbols.FirstOrDefault();
				if (HoveredSymbol == null)
				{
					return;
				}
				Action<Symbol> action = this.SymbolSelected;
				if (action == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				action(HoveredSymbol);
				goto default;
			}
			case 4:
				if (P_1.Key == Key.Return)
				{
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			}
		}
	}

	private void Vnf2F0r8b7P(object P_0, KeyEventArgs P_1)
	{
		if (!Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift))
		{
			goto IL_0023;
		}
		int num = 9;
		goto IL_00d4;
		IL_0023:
		num = 1;
		goto IL_00d4;
		IL_00d4:
		int shift = num;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
		{
			num2 = 1;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
				break;
			default:
				MoveUp(shift);
				return;
			case 3:
				if (P_1.Key == Key.Up)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 1:
				if (wAfDVFDYMBhovhvb7Vim(P_1) == Key.Down)
				{
					MoveDown(shift);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 3;
			}
			break;
		}
		goto IL_0023;
	}

	private void MoveDown(int shift)
	{
		if (Symbols == null || Symbols.Count == 0)
		{
			return;
		}
		int num = default(int);
		int num2;
		if (HoveredSymbol != null)
		{
			num = Symbols.IndexOf(HoveredSymbol);
			if (num == Symbols.Count - 1)
			{
				return;
			}
			num += shift;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_010a;
		IL_010a:
		HoveredSymbol = Symbols.FirstOrDefault();
		num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
		{
			num2 = 0;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			default:
				if (num >= bFsDMhDYOE5MOrLZJVpL(Symbols))
				{
					num = bFsDMhDYOE5MOrLZJVpL(Symbols) - 1;
					num2 = 2;
					continue;
				}
				goto case 2;
			case 1:
				return;
			case 4:
				break;
			case 3:
				return;
			case 2:
				HoveredSymbol = Symbols[num];
				SymbolsList.ScrollIntoView(HoveredSymbol);
				num2 = 3;
				continue;
			}
			break;
		}
		goto IL_010a;
	}

	private void MoveUp(int shift)
	{
		if (Symbols == null || bFsDMhDYOE5MOrLZJVpL(Symbols) == 0)
		{
			return;
		}
		int num = Symbols.IndexOf(HoveredSymbol);
		if (num <= 0)
		{
			return;
		}
		num -= shift;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				if (num >= 0)
				{
					break;
				}
				goto case 1;
			case 3:
				SymbolsList.ScrollIntoView(HoveredSymbol);
				num2 = 2;
				continue;
			case 2:
				return;
			case 1:
				num = 0;
				break;
			}
			HoveredSymbol = Symbols[num];
			int num3 = 3;
			num2 = num3;
		}
	}

	private void ViewModelControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (base.IsVisible)
		{
			MMx2FWHuiUj = null;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					SymbolManager.SymbolUpdated += nv32JAv6ixR;
					return;
				}
				SearchString = "";
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
				{
					num = 1;
				}
			}
		}
		SymbolManager.SymbolUpdated -= nv32JAv6ixR;
	}

	private void ryw2F2iRjhS(object P_0, MouseEventArgs P_1)
	{
		ListViewItem listViewItem = P_0 as ListViewItem;
		int num;
		if (listViewItem == null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		object obj = listViewItem.Content;
		goto IL_0074;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		obj = null;
		goto IL_0074;
		IL_0074:
		if (obj != BindingOperations.DisconnectedSource)
		{
			HoveredSymbol = As6O0gDYqIEUmKZH8Zmu(listViewItem) as Symbol;
			return;
		}
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private void LMR2FHWc3jD(object P_0, MouseButtonEventArgs P_1)
	{
		ListViewItem listViewItem = P_0 as ListViewItem;
		if (((listViewItem != null) ? lFj67bDYIxlK1uNYIbEh(listViewItem) : null) == BindingOperations.DisconnectedSource)
		{
			return;
		}
		int num;
		if (listViewItem == null)
		{
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		object obj = drv0VbDYWfSR9iBnArtu(listViewItem);
		goto IL_00d5;
		IL_0009:
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				if (symbol != null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num = 1;
					}
					continue;
				}
				return;
			case 1:
				SelectedSymbol = symbol;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num = 0;
				}
				continue;
			case 0:
				return;
			case 3:
				break;
			}
			break;
		}
		obj = null;
		goto IL_00d5;
		IL_00d5:
		symbol = obj as Symbol;
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
		{
			num = 2;
		}
		goto IL_0009;
	}

	private void NQY2Ff1EeQ0(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!((string)HBNGGFDYURuTeSWEySVE(SlgqNPDYt4OEyDEGn0mb(SearchString))).EndsWith(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123791434)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = SearchString;
				break;
			default:
				obj = null;
				break;
			}
			break;
		}
		b8AkysfukSBAWXjMK6sm.juPfuqdenpe((string)obj);
	}

	private string MNc2F9pBP0S(string P_0)
	{
		if (!j18iDj9nukSCmEyZs5lH.Settings.DelimiterInUse)
		{
			return new string(P_0.Where(char.IsLetterOrDigit).ToArray());
		}
		return P_0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!oQH2FFduyLu)
		{
			oQH2FFduyLu = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x1195C51), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 1:
			((Button)P_1).Click += NQY2Ff1EeQ0;
			break;
		case 2:
			TextBoxSearch = (TextBox)P_1;
			TextBoxSearch.KeyDown += qrZ2JzhuAHk;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 3:
			SymbolsList = (ListView)P_1;
			num = 2;
			goto IL_0009;
		default:
			{
				oQH2FFduyLu = true;
				break;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					return;
				case 1:
					TextBoxSearch.PreviewKeyDown += Vnf2F0r8b7P;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 4)
		{
			return;
		}
		EventSetter eventSetter = new EventSetter();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.PreviewMouseLeftButtonUpEvent;
				num = 2;
				continue;
			case 2:
				HqrSsBDYynK1c7Bg1rNN(eventSetter, new MouseButtonEventHandler(LMR2FHWc3jD));
				((Style)P_1).Setters.Add(eventSetter);
				return;
			case 3:
				xUFOk6DYTVuMrbo6KIIS(eventSetter, UIElement.MouseEnterEvent);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num = 0;
				}
				continue;
			}
			eventSetter.Handler = new MouseEventHandler(ryw2F2iRjhS);
			((Style)P_1).Setters.Add(eventSetter);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
			{
				num = 1;
			}
		}
	}

	static aotaDg2JhsIDP0L6eD4o()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				ARY2Fhs92pI = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x35446BF9), cy0l4cDYrkAbdnMulXni(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), cy0l4cDYrkAbdnMulXni(fCZFI8DYVDhkLd1gY5fi(33555154)), new PropertyMetadata(null, sIH2J7ZFxEN));
				fjC2FwBMyqD = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056705984), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(""));
				return;
			case 4:
				vyoZ5LDYZLHp0t8LxIfb();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				F0a2Fm9v9GH = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C76920), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(false, sIH2J7ZFxEN));
				num2 = 5;
				continue;
			case 2:
				c8T2FrpcHK4 = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(zgjRhDDYdXiyPr1OVOoN(-176525661 ^ -176493431), Type.GetTypeFromHandle(fCZFI8DYVDhkLd1gY5fi(33555136)), Type.GetTypeFromHandle(fCZFI8DYVDhkLd1gY5fi(33555154)), new PropertyMetadata(bfvIex27Er0lPTIgUD0b.None, k4k2J8gq3OJ));
				bS32FKepTD3 = DependencyProperty.Register((string)zgjRhDDYdXiyPr1OVOoN(-671204305 ^ -671167147), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(null));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			WTY2FTcmGg5 = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123791536), Type.GetTypeFromHandle(fCZFI8DYVDhkLd1gY5fi(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(false));
			YuZ2FytVYvD = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624691943), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(fCZFI8DYVDhkLd1gY5fi(33555154)), new PropertyMetadata(true));
			mYC2FZhbBvV = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B048F6), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), cy0l4cDYrkAbdnMulXni(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(true));
			Ydq2FV3ixGF = DependencyProperty.Register((string)zgjRhDDYdXiyPr1OVOoN(0x37B74BDF ^ 0x37B7BAF1), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(fCZFI8DYVDhkLd1gY5fi(33555154)), new PropertyMetadata(false));
			JjS2FCc4RJ4 = (DependencyProperty)UrmGvNDYCVVyuJIYvph9(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380570418), cy0l4cDYrkAbdnMulXni(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777469)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555154)), new PropertyMetadata(new Thickness(1.0)));
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num2 = 2;
			}
		}
	}

	[CompilerGenerated]
	private bool ER92FnXPP4r(Symbol P_0)
	{
		return !tij2FcYYKvp().Contains(P_0.ID);
	}

	[CompilerGenerated]
	private string iTS2FGJtDqK(Symbol P_0)
	{
		return MNc2F9pBP0S((string)GJsjUvDYKdhoHx68UcHb(P_0));
	}

	internal static bool snheugDYsYakx7ZE1LUh()
	{
		return t9tjJMDYeuWvxnxXXPoQ == null;
	}

	internal static aotaDg2JhsIDP0L6eD4o uAPEaPDYXr6vF9JBpim1()
	{
		return t9tjJMDYeuWvxnxXXPoQ;
	}

	internal static void kccY82DYc6dj6QPoy3xG(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void g8QXObDYjLmI9QFLUnbu(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static bool hyZ43GDYEv9RThaob6Lu(object P_0)
	{
		return ((UIElement)P_0).IsVisible;
	}

	internal static object CS1Nh2DYQbQoIHQ0aCvR(object P_0, object P_1, object P_2)
	{
		return ((Dispatcher)P_0).BeginInvoke((Delegate)P_1, (object[])P_2);
	}

	internal static object zgjRhDDYdXiyPr1OVOoN(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object wKcIN9DYglgMtgXT2jAW(object P_0)
	{
		return SymbolManager.Get((string)P_0);
	}

	internal static void sOROBCDYR0cBq03fQ8vi(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void IjrUxDDY6k17peOWjanZ(object P_0)
	{
		((Collection<Symbol>)P_0).Clear();
	}

	internal static Key wAfDVFDYMBhovhvb7Vim(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static int bFsDMhDYOE5MOrLZJVpL(object P_0)
	{
		return ((Collection<Symbol>)P_0).Count;
	}

	internal static object As6O0gDYqIEUmKZH8Zmu(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}

	internal static object lFj67bDYIxlK1uNYIbEh(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}

	internal static object drv0VbDYWfSR9iBnArtu(object P_0)
	{
		return ((FrameworkElement)P_0).DataContext;
	}

	internal static object SlgqNPDYt4OEyDEGn0mb(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object HBNGGFDYURuTeSWEySVE(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void xUFOk6DYTVuMrbo6KIIS(object P_0, object P_1)
	{
		((EventSetter)P_0).Event = (RoutedEvent)P_1;
	}

	internal static void HqrSsBDYynK1c7Bg1rNN(object P_0, object P_1)
	{
		((EventSetter)P_0).Handler = (Delegate)P_1;
	}

	internal static void vyoZ5LDYZLHp0t8LxIfb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static RuntimeTypeHandle fCZFI8DYVDhkLd1gY5fi(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object UrmGvNDYCVVyuJIYvph9(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static Type cy0l4cDYrkAbdnMulXni(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object GJsjUvDYKdhoHx68UcHb(object P_0)
	{
		return ((Symbol)P_0).Name;
	}
}
