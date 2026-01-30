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
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using aoP01sFJf5y8YNhtSvg;
using cIbiwrHkfBj4h5ErI7rI;
using ECOEgqlSad8NUJZ2Dr9n;
using LaZOWyFOjh4chJI2X4r;
using MaiPJPvBVenctTqZP170;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using waDpctGJom9MvAveNXHq;
using Wg2rfsvBIhefKLVcldl2;

namespace ee8oxLF1aprMB1S4U0o;

internal class mNaFVDFkuRdVdpLCms5 : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	[CompilerGenerated]
	private sealed class xckL62ncJGvtxjYWN6nf
	{
		public HashSet<string> M7Ync3dQ0ak;

		internal static xckL62ncJGvtxjYWN6nf IClwGsNaJIs8mNQ3Sy96;

		public xckL62ncJGvtxjYWN6nf()
		{
			wpRsZLNapMc7jBGDgJYo();
			base._002Ector();
		}

		internal bool FlkncFrqLfM(Symbol s)
		{
			if (!s.IsGateIo && M7Ync3dQ0ak.Contains(JLFqEJGJYiHaSdoROJXI.WTeGJv6DrNH(s.Exchange) ? s.Exchange : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D51BE18)))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					return true;
				}
			}
			if (s.IsGateIo)
			{
				return M7Ync3dQ0ak.Contains((string)WOXGYGNazc4YlZvtCNqK(s.Exchange, ylhCXBNauhSAWpJ4Pa4S(0x24085900 ^ 0x240878BA), s.IsCryptoFuture ? ylhCXBNauhSAWpJ4Pa4S(0x6E2DFBED ^ 0x6E2D9627) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB134DE)));
			}
			return false;
		}

		static xckL62ncJGvtxjYWN6nf()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void wpRsZLNapMc7jBGDgJYo()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool DQbk9cNaFjoFCH3OUsAG()
		{
			return IClwGsNaJIs8mNQ3Sy96 == null;
		}

		internal static xckL62ncJGvtxjYWN6nf FdafV1Na32dYM0YImBCF()
		{
			return IClwGsNaJIs8mNQ3Sy96;
		}

		internal static object ylhCXBNauhSAWpJ4Pa4S(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object WOXGYGNazc4YlZvtCNqK(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}
	}

	[CompilerGenerated]
	private sealed class NYUPtTncpLTTeP3lORg1
	{
		public string I6QnjbQBRK2;

		internal static NYUPtTncpLTTeP3lORg1 J6t7bfNi0AmcM9GDD481;

		public NYUPtTncpLTTeP3lORg1()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool oLlncuY84fp(Symbol s)
		{
			if (s.Exchange == I6QnjbQBRK2)
			{
				return s.Type == SymbolType.Currency;
			}
			return false;
		}

		internal bool TOlnczEuf3I(Symbol s)
		{
			if (s.Exchange == I6QnjbQBRK2)
			{
				return s.Type == SymbolType.Future;
			}
			return false;
		}

		internal bool KuYnj0SwCal(Symbol s)
		{
			if (ppWvArNifjJr8wF6PoFg(s.Exchange, I6QnjbQBRK2))
			{
				return R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Index;
			}
			return false;
		}

		internal bool Muwnj2Imgwg(Symbol s)
		{
			if ((string)UW5riSNinrEivUXfeBDm(s) == I6QnjbQBRK2)
			{
				return R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Stock;
			}
			return false;
		}

		internal bool f8onjHerQvr(Symbol s)
		{
			return (string)UW5riSNinrEivUXfeBDm(s) == I6QnjbQBRK2;
		}

		internal bool el1njf9ucvl(Symbol s)
		{
			return ppWvArNifjJr8wF6PoFg(s.Exchange, I6QnjbQBRK2);
		}

		internal bool CQ0nj9qu8ks(Symbol s)
		{
			if (ppWvArNifjJr8wF6PoFg(s.Exchange, I6QnjbQBRK2))
			{
				return R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Crypto;
			}
			return false;
		}

		internal bool Q2unjn5s7Xy(Symbol s)
		{
			if ((string)UW5riSNinrEivUXfeBDm(s) == I6QnjbQBRK2)
			{
				return s.Type == SymbolType.Crypto;
			}
			return false;
		}

		internal bool Td5njGybP7O(Symbol s)
		{
			if (ppWvArNifjJr8wF6PoFg(s.Exchange, I6QnjbQBRK2))
			{
				return s.Type == SymbolType.Crypto;
			}
			return false;
		}

		internal bool waUnjYCHaOJ(Symbol s)
		{
			if (ppWvArNifjJr8wF6PoFg(s.Exchange, I6QnjbQBRK2))
			{
				return R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Crypto;
			}
			return false;
		}

		internal bool wTJnjo6WXEq(Symbol s)
		{
			if (s.Exchange == I6QnjbQBRK2)
			{
				return R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Future;
			}
			return false;
		}

		internal bool jOcnjvIKTAn(Symbol s)
		{
			if ((string)UW5riSNinrEivUXfeBDm(s) == I6QnjbQBRK2)
			{
				return s.Type != SymbolType.Future;
			}
			return false;
		}

		internal bool h0dnjBq9cla(Symbol s)
		{
			if (s.Exchange == I6QnjbQBRK2)
			{
				return s.Type == SymbolType.Crypto;
			}
			return false;
		}

		internal bool NPknjayAQrq(Symbol s)
		{
			if (s.Exchange == I6QnjbQBRK2)
			{
				return s.Type == SymbolType.Future;
			}
			return false;
		}

		internal bool HWAnji9OjpF(Symbol s)
		{
			if (ppWvArNifjJr8wF6PoFg(UW5riSNinrEivUXfeBDm(s), I6QnjbQBRK2))
			{
				return s.Type == SymbolType.Crypto;
			}
			return false;
		}

		internal bool fFenjlD0DvB(Symbol s)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return !s.IsDeleted;
				case 1:
					if (R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Crypto || (s.Type == SymbolType.Future && !CgX4hENiGblrFyZK8Zfw(s)))
					{
						goto default;
					}
					goto IL_0032;
				case 2:
					{
						if (s.Exchange == I6QnjbQBRK2)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto IL_0032;
					}
					IL_0032:
					return false;
				}
			}
		}

		internal bool qfhnj4RbK24(Symbol s)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (s.Exchange == I6QnjbQBRK2)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_002e;
				default:
					{
						if (s.Type == SymbolType.Crypto || (s.Type == SymbolType.Future && !s.IsMaster))
						{
							return !s.IsDeleted;
						}
						goto IL_002e;
					}
					IL_002e:
					return false;
				}
			}
		}

		internal bool Gy5njDmBA0R(Symbol s)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!(s.Exchange == I6QnjbQBRK2))
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (R3B0RFNi9G5YhlLGcwo8(s) != SymbolType.Crypto)
					{
						if (R3B0RFNi9G5YhlLGcwo8(s) == SymbolType.Future && !s.IsMaster)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
					goto default;
				default:
					return !s.IsDeleted;
				case 1:
					break;
				}
				break;
			}
			return false;
		}

		static NYUPtTncpLTTeP3lORg1()
		{
			DEyQUjNiYMBOiRbmsFcq();
		}

		internal static bool QxGyZDNi2efhAc73mwuA()
		{
			return J6t7bfNi0AmcM9GDD481 == null;
		}

		internal static NYUPtTncpLTTeP3lORg1 V9sT95NiHaco0Iak3AeZ()
		{
			return J6t7bfNi0AmcM9GDD481;
		}

		internal static bool ppWvArNifjJr8wF6PoFg(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static SymbolType R3B0RFNi9G5YhlLGcwo8(object P_0)
		{
			return ((Symbol)P_0).Type;
		}

		internal static object UW5riSNinrEivUXfeBDm(object P_0)
		{
			return ((SymbolBase)P_0).Exchange;
		}

		internal static bool CgX4hENiGblrFyZK8Zfw(object P_0)
		{
			return ((Symbol)P_0).IsMaster;
		}

		internal static void DEyQUjNiYMBOiRbmsFcq()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class XWe4NNnjNdmmTKB9uUHA
	{
		public string y4ynj1SDnDh;

		private static XWe4NNnjNdmmTKB9uUHA p1NxMjNioQfoxljYUn6d;

		public XWe4NNnjNdmmTKB9uUHA()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool K7RnjkjLYie(Symbol s)
		{
			return (string)iOSCIaNiaBgnePL9oumT(s) == y4ynj1SDnDh;
		}

		static XWe4NNnjNdmmTKB9uUHA()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool AWgr0aNivHYu3c7yK0n7()
		{
			return p1NxMjNioQfoxljYUn6d == null;
		}

		internal static XWe4NNnjNdmmTKB9uUHA W4qmPqNiBYCVehQBnBD1()
		{
			return p1NxMjNioQfoxljYUn6d;
		}

		internal static object iOSCIaNiaBgnePL9oumT(object P_0)
		{
			return ((Symbol)P_0).Currency;
		}
	}

	[CompilerGenerated]
	private sealed class iUKxE1nj5xAueeinLv6U
	{
		public string lONnjxOnkmA;

		private static iUKxE1nj5xAueeinLv6U tLRMMXNiipOHuBwrkiXc;

		public iUKxE1nj5xAueeinLv6U()
		{
			esXlKRNiDtoro6uovgtQ();
			base._002Ector();
		}

		internal bool HyOnjSJKLdq(Symbol s)
		{
			return yKFHuYNibFgBrDRlwXUM(s.Currency, lONnjxOnkmA);
		}

		static iUKxE1nj5xAueeinLv6U()
		{
			xk9gYVNiNpHOpW5uBQrx();
		}

		internal static void esXlKRNiDtoro6uovgtQ()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool wpCRyvNilkGwfeei97V8()
		{
			return tLRMMXNiipOHuBwrkiXc == null;
		}

		internal static iUKxE1nj5xAueeinLv6U Mr43bwNi4SxIuVPA7FUd()
		{
			return tLRMMXNiipOHuBwrkiXc;
		}

		internal static bool yKFHuYNibFgBrDRlwXUM(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void xk9gYVNiNpHOpW5uBQrx()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class yafV59njLUhAFGYxkwkS
	{
		public string z1bnjsQSZ3p;

		internal static yafV59njLUhAFGYxkwkS tOcPONNikbwHaoGcIu6V;

		public yafV59njLUhAFGYxkwkS()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool fJ2njeMC89g(Symbol s)
		{
			return ojLoQLNiSmuLlQS2dm86(s.Currency, z1bnjsQSZ3p);
		}

		static yafV59njLUhAFGYxkwkS()
		{
			YdV3YxNixZ4Rgcl7LOUA();
		}

		internal static bool Kvr8WGNi1Ln7ISylYONx()
		{
			return tOcPONNikbwHaoGcIu6V == null;
		}

		internal static yafV59njLUhAFGYxkwkS F7pKHWNi52CL8hjWEC8n()
		{
			return tOcPONNikbwHaoGcIu6V;
		}

		internal static bool ojLoQLNiSmuLlQS2dm86(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void YdV3YxNixZ4Rgcl7LOUA()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class OUh0F2njXZNu6MEJpVau
	{
		public string zjnnjjxqi4V;

		internal static OUh0F2njXZNu6MEJpVau b8mjW8NiLs1uSLxiHnyq;

		public OUh0F2njXZNu6MEJpVau()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool MtPnjcQANXs(Symbol s)
		{
			return (string)nBMNE4NiXavNZydZc53H(s) == zjnnjjxqi4V;
		}

		static OUh0F2njXZNu6MEJpVau()
		{
			V2jvvfNicAbsBfKQ6eo8();
		}

		internal static bool s9N4KBNieLDTCCHBNQd1()
		{
			return b8mjW8NiLs1uSLxiHnyq == null;
		}

		internal static OUh0F2njXZNu6MEJpVau eJ42YlNis17LWEdexKZ2()
		{
			return b8mjW8NiLs1uSLxiHnyq;
		}

		internal static object nBMNE4NiXavNZydZc53H(object P_0)
		{
			return ((Symbol)P_0).Currency;
		}

		internal static void V2jvvfNicAbsBfKQ6eo8()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class ArOv6BnjExLHF4J0ioXt
	{
		public HashSet<string> GConjdHdrtP;

		public Func<Symbol, bool> n0Ynjg3a0aB;

		internal static ArOv6BnjExLHF4J0ioXt Ykrxq2NijSrKwQQSNBd7;

		public ArOv6BnjExLHF4J0ioXt()
		{
			hKlH3DNidNKxo8vt0WsA();
			base._002Ector();
		}

		internal bool WosnjQ18IS4(Symbol symbol)
		{
			return !GConjdHdrtP.Contains(symbol.Currency);
		}

		static ArOv6BnjExLHF4J0ioXt()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void hKlH3DNidNKxo8vt0WsA()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool l0meH3NiETqJSQX5Vt9m()
		{
			return Ykrxq2NijSrKwQQSNBd7 == null;
		}

		internal static ArOv6BnjExLHF4J0ioXt pdMphWNiQXrXE3IbkpC8()
		{
			return Ykrxq2NijSrKwQQSNBd7;
		}
	}

	[CompilerGenerated]
	private sealed class hNQBfrnjRr2Ih0CCgawW
	{
		public string nPfnjMsUrqE;

		private static hNQBfrnjRr2Ih0CCgawW GqEEDONig6wMUcCO6Cwl;

		public hNQBfrnjRr2Ih0CCgawW()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool tLYnj6Vb1yK(Symbol s)
		{
			return T2dwSdNiMTIxWr8GxpGF(s.Currency, nPfnjMsUrqE);
		}

		static hNQBfrnjRr2Ih0CCgawW()
		{
			CWpcA9NiOP8i2EncwtBF();
		}

		internal static bool tMbYg1NiRpwB4Gs24Vnl()
		{
			return GqEEDONig6wMUcCO6Cwl == null;
		}

		internal static hNQBfrnjRr2Ih0CCgawW l7ZnnXNi68gyuyiUoeii()
		{
			return GqEEDONig6wMUcCO6Cwl;
		}

		internal static bool T2dwSdNiMTIxWr8GxpGF(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void CWpcA9NiOP8i2EncwtBF()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class EWhpfxnjOyBQ22ldYLHr
	{
		public HashSet<string> WeInjI2glbl;

		public Func<Symbol, bool> cxcnjWq3fK7;

		internal static EWhpfxnjOyBQ22ldYLHr FLg0WsNiqQkfioTP7Rlk;

		public EWhpfxnjOyBQ22ldYLHr()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool W4anjqPuj9J(Symbol symbol)
		{
			return !WeInjI2glbl.Contains(symbol.Currency);
		}

		static EWhpfxnjOyBQ22ldYLHr()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool lMm6f5NiIuFVTb3p10Ju()
		{
			return FLg0WsNiqQkfioTP7Rlk == null;
		}

		internal static EWhpfxnjOyBQ22ldYLHr M9tflWNiWdGX6cVk8YbQ()
		{
			return FLg0WsNiqQkfioTP7Rlk;
		}
	}

	[CompilerGenerated]
	private sealed class GWkRB3njtIvPpYTbIM8i
	{
		public string KlynjTA4HoW;

		internal static GWkRB3njtIvPpYTbIM8i tN8SyrNitLAyutRTyDPg;

		public GWkRB3njtIvPpYTbIM8i()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool RrvnjUjyT6S(Symbol s)
		{
			return s.Currency == KlynjTA4HoW;
		}

		static GWkRB3njtIvPpYTbIM8i()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool r1IyH3NiU9A4u659qGiJ()
		{
			return tN8SyrNitLAyutRTyDPg == null;
		}

		internal static GWkRB3njtIvPpYTbIM8i LZ2s6yNiT9ekfZv1hs3j()
		{
			return tN8SyrNitLAyutRTyDPg;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class L1CKQvnjysYct0mwdUU4
	{
		public static readonly L1CKQvnjysYct0mwdUU4 H6fnEee95NR;

		public static Func<Symbol, bool> RuZnEsGm7PU;

		public static Func<string, string> YDZnEXkC5n0;

		public static Func<Symbol, string> rBlnEcbxqyA;

		public static Func<Symbol, string> BBenEjItNYt;

		public static Func<Symbol, string> e1lnEEStf7d;

		public static Func<Symbol, string> eNQnEQMW42u;

		public static Func<Symbol, string> mDEnEduv8Ux;

		public static Func<Symbol, string> Wk4nEgnlskU;

		public static Func<Symbol, string> z9cnERXpasL;

		public static Func<Symbol, string> UIenE6yvxdJ;

		public static Func<Symbol, string> M0HnEMNCZdl;

		public static Func<string, string> IO3nEO3y9Da;

		public static Func<Symbol, string> pKfnEqui9Kn;

		public static Func<Symbol, bool> USjnEIoPds4;

		public static Func<Symbol, string> yJAnEWXXloL;

		public static Func<Symbol, string> j3lnEtU3xiw;

		public static Func<string, string> PMtnEUAtv1i;

		public static Func<Symbol, string> JbmnET2lHTM;

		public static Func<Symbol, string> TBenEyjsZ04;

		public static Func<string, string> BWKnEZScAYH;

		public static Func<Symbol, string> LyjnEVY3sjg;

		public static Func<string, string> NnPnECUhbty;

		public static Func<Symbol, bool> rqinErhxUIQ;

		public static Func<Symbol, string> zMXnEKDyM9Y;

		public static Func<Symbol, string> xd3nEmxrhiy;

		public static Func<Symbol, string> CVtnEhpG1Mk;

		public static Func<Symbol, string> fQHnEwcQyIu;

		public static Func<string, string> kS0nE7F7Kia;

		public static Func<Symbol, string> Y1QnE8pkn5C;

		public static Func<Symbol, bool> XuwnEAkOjyl;

		public static Func<Symbol, string> cGGnEPVWAhb;

		public static Func<Symbol, string> rqsnEJDbOBx;

		public static Func<Symbol, string> G4mnEFAfLQm;

		public static Func<string, string> qfNnE37POvI;

		public static Func<Symbol, string> ojInEpBQsAw;

		public static Func<Symbol, string> SOknEuIgs2t;

		public static Func<Symbol, string> bfNnEzGp1hp;

		public static Func<Symbol, string> rhAnQ0TrMyq;

		public static Func<Symbol, string> VXWnQ2HadJt;

		public static Func<IGrouping<string, Symbol>, string> AG6nQHecGI8;

		public static Func<Symbol, string> VWknQfYaPk4;

		public static Func<Symbol, string> TuSnQ94p7JI;

		internal static L1CKQvnjysYct0mwdUU4 vYkSpSNiyymk0Uneu688;

		static L1CKQvnjysYct0mwdUU4()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					H6fnEee95NR = new L1CKQvnjysYct0mwdUU4();
					return;
				case 1:
					U5IrK0NiC3Sl4vSIcL4v();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public L1CKQvnjysYct0mwdUU4()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool lhHnjZsIJ9w(Symbol s)
		{
			return !Kn3NMtHkHjy4eIsknyks.BTsHk9LkJvJ(s);
		}

		internal string tacnjV9tn8d(string ex)
		{
			return ex;
		}

		internal string I18njCUPIHA(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string jlynjrRTGqn(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string c71njKv1hO5(Symbol c)
		{
			return c.Name;
		}

		internal string krvnjmM20TN(Symbol s)
		{
			return s.Name;
		}

		internal string Y77njhsKkTA(Symbol s)
		{
			return s.Name;
		}

		internal string V63njwl2K5o(Symbol s)
		{
			return s.Name;
		}

		internal string K21nj7QaVN4(Symbol c)
		{
			return c.Name;
		}

		internal string jMKnj8im2uL(Symbol c)
		{
			return c.Name;
		}

		internal string MO0njAegoHX(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string PnCnjPfR815(string c)
		{
			return c;
		}

		internal string ENhnjJG5J0b(Symbol s)
		{
			return s.Name;
		}

		internal bool MGenjFFHJGm(Symbol s)
		{
			if (s.Exchange == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD55E9C))
			{
				return s.Type == SymbolType.Future;
			}
			return false;
		}

		internal string WKdnj3paCNy(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string moonjpGx5ts(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string l02njuwD8vq(string c)
		{
			return c;
		}

		internal string D7tnjzUn921(Symbol s)
		{
			return s.Name;
		}

		internal string jNRnE0sNLuM(Symbol s)
		{
			return s.Name;
		}

		internal string OF4nE2gUQPc(string c)
		{
			return c;
		}

		internal string cxCnEHJKOA5(Symbol s)
		{
			return s.Name;
		}

		internal string xXknEfTyiEV(string c)
		{
			return c;
		}

		internal bool Wp3nE9IxkAj(Symbol s)
		{
			return rdmQyGNiKds00RoWIRnr(s);
		}

		internal string moYnEnIB2Xq(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string z9CnEGKsUyT(Symbol c)
		{
			return c.Name;
		}

		internal string dgpnEY0CsBI(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string dFGnEoxo8qN(Symbol s)
		{
			return s.Name;
		}

		internal string R6OnEvY9iZT(string c)
		{
			return c;
		}

		internal string xeDnEB5jW0B(Symbol s)
		{
			return s.Name;
		}

		internal bool FHHnEa0jNyd(Symbol s)
		{
			return s.IsMaster;
		}

		internal string KI3nEiXawmB(Symbol s)
		{
			return s.Name;
		}

		internal string ByanElQh5Xi(Symbol c)
		{
			return (string)WCGR4lNirWLu7tVehBPd(c);
		}

		internal string zURnE4cmEhe(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string btxnEDLDIKO(string c)
		{
			return c;
		}

		internal string dQsnEb9n7T5(Symbol s)
		{
			return (string)WCGR4lNirWLu7tVehBPd(s);
		}

		internal string kxqnENFSN8d(Symbol o)
		{
			return (string)fVlpoxNimitXH6xv2Dw1(o);
		}

		internal string CnFnEkIv3jc(Symbol o)
		{
			return o.Code;
		}

		internal string XVNnE1EpIjN(Symbol o)
		{
			return o.Code;
		}

		internal string lrrnE5HgTXW(Symbol s)
		{
			return s.Currency;
		}

		internal string E9GnES0R0Os(IGrouping<string, Symbol> s)
		{
			return s.Key;
		}

		internal string TINnExw2AJv(Symbol x)
		{
			return x.Name;
		}

		internal string QOAnELbgGKr(Symbol c)
		{
			return c.Name;
		}

		internal static void U5IrK0NiC3Sl4vSIcL4v()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool RQov4YNiZQQCdHxbDNKM()
		{
			return vYkSpSNiyymk0Uneu688 == null;
		}

		internal static L1CKQvnjysYct0mwdUU4 UFC6K2NiVOBdYOa5uZE0()
		{
			return vYkSpSNiyymk0Uneu688;
		}

		internal static object WCGR4lNirWLu7tVehBPd(object P_0)
		{
			return ((Symbol)P_0).Name;
		}

		internal static bool rdmQyGNiKds00RoWIRnr(object P_0)
		{
			return ((Symbol)P_0).IsMaster;
		}

		internal static object fVlpoxNimitXH6xv2Dw1(object P_0)
		{
			return ((Symbol)P_0).Code;
		}
	}

	[CompilerGenerated]
	private sealed class NO0o1unQnFkDf0FFc3Vp
	{
		public string K81nQYdTF0s;

		private static NO0o1unQnFkDf0FFc3Vp scnHI2NihpZG8VnkhHWl;

		public NO0o1unQnFkDf0FFc3Vp()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool EkInQG5YgL8(Symbol s)
		{
			if ((string)qssRPlNi8J4Wp8RGfsFZ(s) == K81nQYdTF0s)
			{
				return PEDGqSNiAfNhHKiCwhAu(s) == SymbolType.Future;
			}
			return false;
		}

		static NO0o1unQnFkDf0FFc3Vp()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool cc6jQwNiwJZ3LtL8pG0A()
		{
			return scnHI2NihpZG8VnkhHWl == null;
		}

		internal static NO0o1unQnFkDf0FFc3Vp YuvkO4Ni7uj2BGInfo4H()
		{
			return scnHI2NihpZG8VnkhHWl;
		}

		internal static object qssRPlNi8J4Wp8RGfsFZ(object P_0)
		{
			return ((SymbolBase)P_0).Exchange;
		}

		internal static SymbolType PEDGqSNiAfNhHKiCwhAu(object P_0)
		{
			return ((Symbol)P_0).Type;
		}
	}

	private readonly t7Wto9FMbOhxvJPJoJ4 UvfFRgGVv4;

	internal TreeListBox TreeListBoxSymbols;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool WtcF6OGgWv;

	private static mNaFVDFkuRdVdpLCms5 K2RDNY4LRD2xvEq7cKFd;

	public mNaFVDFkuRdVdpLCms5()
	{
		nG9jKa4LOPqPBfvyUUyO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				UvfFRgGVv4.IsCheckable = false;
				num = 2;
				continue;
			case 2:
				return;
			}
			InitializeComponent();
			t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ = new t7Wto9FMbOhxvJPJoJ4();
			B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ, TigerTrade.Properties.Resources.SelectSymbolsWindowSymbolsList);
			UvfFRgGVv4 = t7Wto9FMbOhxvJPJoJ;
			bZfbyK4LImHg1JVKgjhO(TreeListBoxSymbols, UvfFRgGVv4);
			UvfFRgGVv4.IsExpanded = true;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
			{
				num = 1;
			}
		}
	}

	private void ktOF5mg5OE(object P_0, TreeListBoxItemExpansionEventArgs P_1)
	{
		int num = 7;
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ = default(t7Wto9FMbOhxvJPJoJ4);
		xckL62ncJGvtxjYWN6nf xckL62ncJGvtxjYWN6nf = default(xckL62ncJGvtxjYWN6nf);
		List<Symbol>.Enumerator enumerator = default(List<Symbol>.Enumerator);
		string item = default(string);
		HashSet<string> hashSet = default(HashSet<string>);
		List<Symbol> list = default(List<Symbol>);
		NYUPtTncpLTTeP3lORg1 nYUPtTncpLTTeP3lORg = default(NYUPtTncpLTTeP3lORg1);
		uint num6 = default(uint);
		string text = default(string);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ25 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ20 = default(t7Wto9FMbOhxvJPJoJ4);
		HashSet<string> hashSet3 = default(HashSet<string>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ50 = default(t7Wto9FMbOhxvJPJoJ4);
		HashSet<string> hashSet4 = default(HashSet<string>);
		List<Symbol> source4 = default(List<Symbol>);
		IEnumerator<Symbol> enumerator3 = default(IEnumerator<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ26 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ27 = default(t7Wto9FMbOhxvJPJoJ4);
		IEnumerator<string> enumerator4 = default(IEnumerator<string>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ14 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ15 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ38 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ32 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ21 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ33 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ28 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ55 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ9 = default(t7Wto9FMbOhxvJPJoJ4);
		aK6fJ1vBqhWwwCm6KEi5 aK6fJ1vBqhWwwCm6KEi = default(aK6fJ1vBqhWwwCm6KEi5);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ10 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 item16 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ19 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ13 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ4 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ66 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ49 = default(t7Wto9FMbOhxvJPJoJ4);
		HashSet<string> hashSet5 = default(HashSet<string>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ51 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ42 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ40 = default(t7Wto9FMbOhxvJPJoJ4);
		EWhpfxnjOyBQ22ldYLHr eWhpfxnjOyBQ22ldYLHr = default(EWhpfxnjOyBQ22ldYLHr);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ18 = default(t7Wto9FMbOhxvJPJoJ4);
		List<Symbol> list3 = default(List<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ30 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ31 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ23 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ11 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ12 = default(t7Wto9FMbOhxvJPJoJ4);
		List<Symbol> list2 = default(List<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ8 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ5 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ69 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ2 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ35 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ46 = default(t7Wto9FMbOhxvJPJoJ4);
		IEnumerable<Symbol> source8 = default(IEnumerable<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 item17 = default(t7Wto9FMbOhxvJPJoJ4);
		XWe4NNnjNdmmTKB9uUHA xWe4NNnjNdmmTKB9uUHA = default(XWe4NNnjNdmmTKB9uUHA);
		List<Symbol> list5 = default(List<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 item13 = default(t7Wto9FMbOhxvJPJoJ4);
		IOrderedEnumerable<Symbol> orderedEnumerable6 = default(IOrderedEnumerable<Symbol>);
		IEnumerable<Symbol> source6 = default(IEnumerable<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ44 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 item10 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 item9 = default(t7Wto9FMbOhxvJPJoJ4);
		HashSet<string> hashSet2 = default(HashSet<string>);
		List<Symbol> list4 = default(List<Symbol>);
		yafV59njLUhAFGYxkwkS CS_0024_003C_003E8__locals23;
		t7Wto9FMbOhxvJPJoJ4 item20 = default(t7Wto9FMbOhxvJPJoJ4);
		List<Symbol> source3 = default(List<Symbol>);
		List<Symbol> source2 = default(List<Symbol>);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ17 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 item5 = default(t7Wto9FMbOhxvJPJoJ4);
		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ3 = default(t7Wto9FMbOhxvJPJoJ4);
		Symbol current2 = default(Symbol);
		Symbol current9 = default(Symbol);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (JZHGHU4LtpdKNI7m4kj0(t7Wto9FMbOhxvJPJoJ.Children) > 0)
					{
						return;
					}
					t7Wto9FMbOhxvJPJoJ.IsLoading = true;
					if (t7Wto9FMbOhxvJPJoJ == UvfFRgGVv4)
					{
						xckL62ncJGvtxjYWN6nf = new xckL62ncJGvtxjYWN6nf();
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 8;
				case 3:
					try
					{
						while (enumerator.MoveNext())
						{
							Symbol current = enumerator.Current;
							int num3 = 2;
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 2:
									item = current.Exchange;
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
									{
										num3 = 0;
									}
									continue;
								default:
									if (!(current.Exchange == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68DEE0F ^ 0x68D824D)))
									{
										num3 = 3;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_00b7;
								case 3:
									{
										if (!BALt4G4LVbEH3jOlZfUw(current.Exchange, f0ct0p4LZFQhw8kdIeLM(-338769610 ^ -338778774)))
										{
											break;
										}
										goto IL_00b7;
									}
									IL_00b7:
									item = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002295469);
									num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							}
							if (!hashSet.Contains(item))
							{
								hashSet.Add(item);
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto default;
				case 8:
					t7Wto9FMbOhxvJPJoJ.IsLoading = false;
					num2 = 5;
					break;
				case 1:
					list = list.Where(xckL62ncJGvtxjYWN6nf.FlkncFrqLfM).ToList();
					goto end_IL_0012;
				case 7:
					t7Wto9FMbOhxvJPJoJ = SiaMWX4LW6XegvgfqV3w(P_1) as t7Wto9FMbOhxvJPJoJ4;
					num2 = 6;
					break;
				case 5:
					return;
				case 4:
					t7Wto9FMbOhxvJPJoJ.Children.Clear();
					hashSet = new HashSet<string>();
					list = (from s in SymbolManager.GetAll()
						where !Kn3NMtHkHjy4eIsknyks.BTsHk9LkJvJ(s)
						select s).ToList();
					if (!Yc1ZIk4LTEG5jWjue3LK(yBg8lR4LUcQ5aDpTS2vg()) || tltSLj4LyOjlutJICkv5(j18iDj9nukSCmEyZs5lH.Settings) == AppTradeMode.Player)
					{
						xckL62ncJGvtxjYWN6nf.M7Ync3dQ0ak = new HashSet<string>();
						goto end_IL_0012;
					}
					num2 = 2;
					break;
				case 2:
					xckL62ncJGvtxjYWN6nf.M7Ync3dQ0ak = JLFqEJGJYiHaSdoROJXI.aFKGJBIwWtd();
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num2 = 0;
					}
					break;
				default:
				{
					using (IEnumerator<string> enumerator2 = hashSet.OrderBy((string ex) => ex).GetEnumerator())
					{
						while (true)
						{
							int num4;
							if (!enumerator2.MoveNext())
							{
								num4 = 79;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
								{
									num4 = 19;
								}
								goto IL_0283;
							}
							goto IL_34ab;
							IL_34ab:
							nYUPtTncpLTTeP3lORg = new NYUPtTncpLTTeP3lORg1();
							num4 = 31;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
							{
								num4 = 73;
							}
							goto IL_0283;
							IL_0283:
							while (true)
							{
								int num9;
								switch (num4)
								{
								case 65:
									if (num6 != 1339068711)
									{
										if (num6 != 1610380443)
										{
											num4 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
											{
												num4 = 7;
											}
											continue;
										}
										goto IL_1140;
									}
									goto IL_360b;
								case 74:
									if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D3159DB)))
									{
										num4 = 45;
										continue;
									}
									goto case 57;
								case 40:
								{
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ24 = new t7Wto9FMbOhxvJPJoJ4();
									B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ24, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
									DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ24, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311298247));
									t7Wto9FMbOhxvJPJoJ25 = t7Wto9FMbOhxvJPJoJ24;
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ25);
									num4 = 100;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
									{
										num4 = 73;
									}
									continue;
								}
								case 115:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ20);
									num4 = 18;
									continue;
								case 114:
									try
									{
										while (enumerator.MoveNext())
										{
											while (true)
											{
												Symbol current13 = enumerator.Current;
												if (!hashSet3.Contains(current13.Currency))
												{
													int num21 = 0;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
													{
														num21 = 0;
													}
													switch (num21)
													{
													case 1:
														continue;
													}
													hashSet3.Add((string)QSdJaw4LAKBLdZE84TTH(current13));
												}
												break;
											}
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 116;
								case 28:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ50);
									num4 = 53;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
									{
										num4 = 52;
									}
									continue;
								case 101:
									try
									{
										while (enumerator.MoveNext())
										{
											Symbol current26 = enumerator.Current;
											int num43 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
											{
												num43 = 1;
											}
											while (true)
											{
												switch (num43)
												{
												default:
													hashSet4.Add((string)QSdJaw4LAKBLdZE84TTH(current26));
													break;
												case 1:
													if (!hashSet4.Contains(current26.Currency))
													{
														num43 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
														{
															num43 = 0;
														}
														continue;
													}
													break;
												}
												break;
											}
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 107;
								case 19:
								{
									ArOv6BnjExLHF4J0ioXt CS_0024_003C_003E8__locals21 = new ArOv6BnjExLHF4J0ioXt();
									CS_0024_003C_003E8__locals21.GConjdHdrtP = new HashSet<string>();
									source4 = (from s in list.Where(nYUPtTncpLTTeP3lORg.h0dnjBq9cla)
										orderby s.Name
										select s).ToList();
									enumerator3 = source4.Where((Symbol symbol) => !CS_0024_003C_003E8__locals21.GConjdHdrtP.Contains(symbol.Currency)).GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											Symbol current6 = enumerator3.Current;
											int num14 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
											{
												num14 = 0;
											}
											switch (num14)
											{
											}
											CS_0024_003C_003E8__locals21.GConjdHdrtP.Add((string)QSdJaw4LAKBLdZE84TTH(current6));
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									t7Wto9FMbOhxvJPJoJ26 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(0x11D1040B ^ 0x11D13EBB),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(-1736566656 ^ -1736542932)
									};
									t7Wto9FMbOhxvJPJoJ27.Children.Add(t7Wto9FMbOhxvJPJoJ26);
									enumerator4 = CS_0024_003C_003E8__locals21.GConjdHdrtP.OrderBy((string c) => c).GetEnumerator();
									num4 = 110;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
									{
										num4 = 67;
									}
									continue;
								}
								case 17:
									t7Wto9FMbOhxvJPJoJ14.Children.Add(t7Wto9FMbOhxvJPJoJ15);
									num9 = 108;
									goto IL_027f;
								case 8:
								case 14:
								case 21:
								case 34:
								case 44:
								case 45:
								case 48:
								case 63:
								case 68:
								case 69:
								case 70:
								case 71:
								case 86:
								case 94:
								case 105:
								case 118:
									break;
								case 1:
								{
									t7Wto9FMbOhxvJPJoJ38 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(0x68C7EAE6 ^ 0x68C784F0),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(0x28C965BE ^ 0x28C90812)
									};
									IOrderedEnumerable<Symbol> orderedEnumerable5 = from s in list
										where s.Exchange == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD55E9C) && s.Type == SymbolType.Future
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s;
									EhgFxSafgw(t7Wto9FMbOhxvJPJoJ38, orderedEnumerable5);
									num4 = 16;
									continue;
								}
								case 87:
									if (BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690501485)))
									{
										goto case 50;
									}
									break;
								case 51:
									goto IL_1140;
								case 16:
									if (t7Wto9FMbOhxvJPJoJ38.Children.Any())
									{
										num4 = 26;
										continue;
									}
									goto IL_1f4d;
								case 89:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ32);
									synFSKIMWU(list, t7Wto9FMbOhxvJPJoJ32, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
									num4 = 71;
									continue;
								case 4:
									t7Wto9FMbOhxvJPJoJ21.Children.Add(t7Wto9FMbOhxvJPJoJ33);
									num4 = 35;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
									{
										num4 = 78;
									}
									continue;
								case 37:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ28);
									num9 = 32;
									goto IL_027f;
								case 43:
									if (num6 != 2132487982)
									{
										num4 = 59;
										continue;
									}
									goto case 106;
								case 59:
									switch (num6)
									{
									case 2204885439u:
										break;
									default:
										goto end_IL_0283;
									case 2618539384u:
										goto IL_315f;
									}
									goto case 74;
								case 82:
									try
									{
										while (enumerator.MoveNext())
										{
											Symbol current18 = enumerator.Current;
											IOrderedEnumerable<Symbol> orderedEnumerable4 = from c in current18.GetContracts()
												where !ljYFLbRetF(c)
												orderby c.Name
												select c;
											if (!orderedEnumerable4.Any())
											{
												continue;
											}
											int num29 = 3;
											while (true)
											{
												switch (num29)
												{
												case 2:
													break;
												default:
													if (t7Wto9FMbOhxvJPJoJ55.Children.Any())
													{
														t7Wto9FMbOhxvJPJoJ9.Children.Add(t7Wto9FMbOhxvJPJoJ55);
														num29 = 2;
														continue;
													}
													break;
												case 3:
													t7Wto9FMbOhxvJPJoJ55 = null;
													enumerator3 = orderedEnumerable4.GetEnumerator();
													try
													{
														while (enumerator3.MoveNext())
														{
															Symbol current19 = enumerator3.Current;
															int num30 = 1;
															if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
															{
																num30 = 1;
															}
															while (true)
															{
																switch (num30)
																{
																case 1:
																	aK6fJ1vBqhWwwCm6KEi = jQb29i4LPLqccRLAq3Ri(current19);
																	num30 = 4;
																	continue;
																case 5:
																	t7Wto9FMbOhxvJPJoJ10.Children.Add(item16);
																	break;
																default:
																	if (aK6fJ1vBqhWwwCm6KEi == (aK6fJ1vBqhWwwCm6KEi5)1)
																	{
																		goto IL_145b;
																	}
																	goto case 3;
																case 2:
																{
																	t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ56 = new t7Wto9FMbOhxvJPJoJ4();
																	t7Wto9FMbOhxvJPJoJ56.Name = current19.Name;
																	t7Wto9FMbOhxvJPJoJ56.Path = (string)f0ct0p4LZFQhw8kdIeLM(0x2BD86B18 ^ 0x2BD806A2);
																	t7Wto9FMbOhxvJPJoJ56.UTPFUh7JhO(current19.ID);
																	PJyj2j4L82PboVgykDYE(t7Wto9FMbOhxvJPJoJ56, true);
																	t7Wto9FMbOhxvJPJoJ4 item15 = t7Wto9FMbOhxvJPJoJ56;
																	t7Wto9FMbOhxvJPJoJ55.Children.Add(item15);
																	break;
																}
																case 4:
																	if (aK6fJ1vBqhWwwCm6KEi != (aK6fJ1vBqhWwwCm6KEi5)3)
																	{
																		num30 = 0;
																		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
																		{
																			num30 = 0;
																		}
																		continue;
																	}
																	goto IL_145b;
																case 3:
																	{
																		if (aK6fJ1vBqhWwwCm6KEi == (aK6fJ1vBqhWwwCm6KEi5)2)
																		{
																			t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ57 = new t7Wto9FMbOhxvJPJoJ4();
																			t7Wto9FMbOhxvJPJoJ57.Name = current19.Name;
																			t7Wto9FMbOhxvJPJoJ57.Path = (string)f0ct0p4LZFQhw8kdIeLM(-1251569705 ^ -1251548563);
																			t7Wto9FMbOhxvJPJoJ57.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current19));
																			PJyj2j4L82PboVgykDYE(t7Wto9FMbOhxvJPJoJ57, true);
																			item16 = t7Wto9FMbOhxvJPJoJ57;
																			num30 = 5;
																			continue;
																		}
																		break;
																	}
																	IL_145b:
																	if (t7Wto9FMbOhxvJPJoJ55 == null)
																	{
																		t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ58 = new t7Wto9FMbOhxvJPJoJ4();
																		B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ58, current18.Name);
																		t7Wto9FMbOhxvJPJoJ58.Path = (string)f0ct0p4LZFQhw8kdIeLM(-45476899 ^ -45449727);
																		t7Wto9FMbOhxvJPJoJ55 = t7Wto9FMbOhxvJPJoJ58;
																		num30 = 2;
																		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
																		{
																			num30 = 1;
																		}
																		continue;
																	}
																	goto case 2;
																}
																break;
															}
														}
													}
													finally
													{
														enumerator3?.Dispose();
													}
													goto case 1;
												case 1:
													if (t7Wto9FMbOhxvJPJoJ55 != null)
													{
														num29 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
														{
															num29 = 0;
														}
														continue;
													}
													break;
												}
												break;
											}
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 30;
								case 41:
									text = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2;
									num6 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
									if (num6 <= 2020397624)
									{
										if (num6 <= 1041130325)
										{
											goto IL_3284;
										}
										goto case 61;
									}
									if (num6 > 2770757464u)
									{
										if (num6 <= 3670628538u)
										{
											num4 = 4;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
											{
												num4 = 5;
											}
											continue;
										}
										goto case 92;
									}
									num4 = 93;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
									{
										num4 = 28;
									}
									continue;
								case 36:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ14);
									num4 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
									{
										num4 = 0;
									}
									continue;
								case 60:
									t7Wto9FMbOhxvJPJoJ19 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5AB44),
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D315965)
									};
									num4 = 81;
									continue;
								case 42:
									goto IL_1972;
								case 109:
									if (t7Wto9FMbOhxvJPJoJ13.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ4.Children.Add(t7Wto9FMbOhxvJPJoJ13);
										num4 = 86;
										continue;
									}
									break;
								case 110:
									try
									{
										while (enumerator4.MoveNext())
										{
											hNQBfrnjRr2Ih0CCgawW CS_0024_003C_003E8__locals24 = new hNQBfrnjRr2Ih0CCgawW();
											int num38 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
											{
												num38 = 0;
											}
											while (true)
											{
												switch (num38)
												{
												case 1:
													break;
												default:
												{
													CS_0024_003C_003E8__locals24.nPfnjMsUrqE = enumerator4.Current;
													IEnumerable<Symbol> source9 = source4.Where((Symbol s) => hNQBfrnjRr2Ih0CCgawW.T2dwSdNiMTIxWr8GxpGF(s.Currency, CS_0024_003C_003E8__locals24.nPfnjMsUrqE));
													t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ65 = new t7Wto9FMbOhxvJPJoJ4();
													B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ65, CS_0024_003C_003E8__locals24.nPfnjMsUrqE);
													DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ65, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44552155));
													t7Wto9FMbOhxvJPJoJ66 = t7Wto9FMbOhxvJPJoJ65;
													t7Wto9FMbOhxvJPJoJ26.Children.Add(t7Wto9FMbOhxvJPJoJ66);
													enumerator3 = source9.OrderBy((Symbol s) => s.Name).GetEnumerator();
													num38 = 1;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
													{
														num38 = 1;
													}
													continue;
												}
												}
												break;
											}
											try
											{
												while (enumerator3.MoveNext())
												{
													while (true)
													{
														Symbol current24 = enumerator3.Current;
														t7Wto9FMbOhxvJPJoJ4 obj8 = new t7Wto9FMbOhxvJPJoJ4
														{
															Name = current24.Name,
															Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801475528)
														};
														Mdhv0A4LKtjaTQ7nouVq(obj8, current24.ID);
														obj8.IsExpanded = true;
														t7Wto9FMbOhxvJPJoJ4 item21 = obj8;
														t7Wto9FMbOhxvJPJoJ66.Children.Add(item21);
														int num39 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
														{
															num39 = 0;
														}
														switch (num39)
														{
														case 1:
															continue;
														}
														break;
													}
												}
											}
											finally
											{
												if (enumerator3 != null)
												{
													EA6VMq4Lh7Hyc5USMbh0(enumerator3);
												}
											}
										}
									}
									finally
									{
										enumerator4?.Dispose();
									}
									goto case 62;
								case 108:
									synFSKIMWU(list, t7Wto9FMbOhxvJPJoJ15, (string)f0ct0p4LZFQhw8kdIeLM(--737722733 ^ 0x2BF8AD2F));
									num4 = 23;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
									{
										num4 = 44;
									}
									continue;
								case 33:
									t7Wto9FMbOhxvJPJoJ25.Children.Add(t7Wto9FMbOhxvJPJoJ49);
									enumerator4 = hashSet5.OrderBy((string c) => c).GetEnumerator();
									num4 = 4;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
									{
										num4 = 39;
									}
									continue;
								case 50:
								{
									t7Wto9FMbOhxvJPJoJ4 obj6 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2
									};
									DBWsLL4LCho5WPbxbywX(obj6, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x130FEA25 ^ 0x130F87BD));
									t7Wto9FMbOhxvJPJoJ51 = obj6;
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								case 73:
									nYUPtTncpLTTeP3lORg.I6QnjbQBRK2 = enumerator2.Current;
									num4 = 41;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
									{
										num4 = 23;
									}
									continue;
								case 57:
									t7Wto9FMbOhxvJPJoJ42 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2,
										Path = (string)f0ct0p4LZFQhw8kdIeLM(--871424829 ^ 0x33F08EA5)
									};
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ42);
									hashSet3 = new HashSet<string>();
									num4 = 20;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
									{
										num4 = 20;
									}
									continue;
								case 5:
									if (num6 != 3516542306u)
									{
										num4 = 12;
										continue;
									}
									if (!(text == (string)f0ct0p4LZFQhw8kdIeLM(0x2CBEEA31 ^ 0x2CBE8687)))
									{
										break;
									}
									goto case 40;
								case 46:
									t7Wto9FMbOhxvJPJoJ40 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(-1606927328 ^ -1606921688),
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240834AC)
									};
									t7Wto9FMbOhxvJPJoJ21.Children.Add(t7Wto9FMbOhxvJPJoJ40);
									num4 = 84;
									continue;
								case 80:
									try
									{
										while (enumerator3.MoveNext())
										{
											Symbol current16 = enumerator3.Current;
											eWhpfxnjOyBQ22ldYLHr.WeInjI2glbl.Add((string)QSdJaw4LAKBLdZE84TTH(current16));
										}
										int num26 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
										{
											num26 = 0;
										}
										switch (num26)
										{
										case 0:
											break;
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									t7Wto9FMbOhxvJPJoJ18 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(0x6F7F734B ^ 0x6F7F49FB),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(-520155535 ^ -520133667)
									};
									num4 = 63;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
									{
										num4 = 64;
									}
									continue;
								case 67:
								{
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ48 = new t7Wto9FMbOhxvJPJoJ4();
									B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ48, f0ct0p4LZFQhw8kdIeLM(-624753169 ^ -624738465));
									t7Wto9FMbOhxvJPJoJ48.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1DB697);
									t7Wto9FMbOhxvJPJoJ49 = t7Wto9FMbOhxvJPJoJ48;
									num4 = 13;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
									{
										num4 = 33;
									}
									continue;
								}
								case 26:
									t7Wto9FMbOhxvJPJoJ14.Children.Add(t7Wto9FMbOhxvJPJoJ38);
									goto IL_1f4d;
								case 52:
									eWhpfxnjOyBQ22ldYLHr = new EWhpfxnjOyBQ22ldYLHr();
									eWhpfxnjOyBQ22ldYLHr.WeInjI2glbl = new HashSet<string>();
									num4 = 68;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
									{
										num4 = 88;
									}
									continue;
								case 97:
									enumerator = list3.GetEnumerator();
									num4 = 101;
									continue;
								case 2:
									if (num6 != 207070566)
									{
										break;
									}
									goto case 58;
								case 104:
									if (num6 != 702486649)
									{
										if (num6 != 1041130325)
										{
											break;
										}
										if (!(text == (string)f0ct0p4LZFQhw8kdIeLM(-2017337494 ^ -2017349120)))
										{
											num4 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
											{
												num4 = 69;
											}
											continue;
										}
										goto case 77;
									}
									goto IL_3236;
								case 15:
								{
									t7Wto9FMbOhxvJPJoJ4 obj5 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(0x6F7F734B ^ 0x6F7F1D7D)
									};
									DBWsLL4LCho5WPbxbywX(obj5, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380534740));
									t7Wto9FMbOhxvJPJoJ15 = obj5;
									num4 = 17;
									continue;
								}
								case 47:
									try
									{
										while (enumerator3.MoveNext())
										{
											Symbol current7;
											while (true)
											{
												current7 = enumerator3.Current;
												int num15 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
												{
													num15 = 1;
												}
												switch (num15)
												{
												case 1:
													goto end_IL_23fd;
												}
												continue;
												end_IL_23fd:
												break;
											}
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ29 = new t7Wto9FMbOhxvJPJoJ4();
											B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ29, current7.Name);
											t7Wto9FMbOhxvJPJoJ29.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F09B8E);
											Mdhv0A4LKtjaTQ7nouVq(t7Wto9FMbOhxvJPJoJ29, delPg94LwvSL747LoogP(current7));
											PJyj2j4L82PboVgykDYE(t7Wto9FMbOhxvJPJoJ29, true);
											t7Wto9FMbOhxvJPJoJ4 item7 = t7Wto9FMbOhxvJPJoJ29;
											t7Wto9FMbOhxvJPJoJ30.Children.Add(item7);
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									if (t7Wto9FMbOhxvJPJoJ30.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ31.Children.Add(t7Wto9FMbOhxvJPJoJ30);
										num4 = 42;
										continue;
									}
									goto IL_1972;
								case 83:
									goto IL_2572;
								case 76:
									if (num6 != 3887724832u)
									{
										num4 = 118;
										continue;
									}
									goto case 87;
								case 81:
								{
									t7Wto9FMbOhxvJPJoJ21.Children.Add(t7Wto9FMbOhxvJPJoJ19);
									enumerator3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.oLlncuY84fp)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).GetEnumerator();
									try
									{
										while (true)
										{
											if (!enumerator3.MoveNext())
											{
												int num12 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
												{
													num12 = 0;
												}
												switch (num12)
												{
												case 1:
													goto IL_18a3;
												case 0:
													break;
												}
												break;
											}
											goto IL_18a3;
											IL_18a3:
											Symbol current5 = enumerator3.Current;
											t7Wto9FMbOhxvJPJoJ4 obj4 = new t7Wto9FMbOhxvJPJoJ4
											{
												Name = (string)bIITL14LrEMmS6o2UfXU(current5),
												Path = (string)f0ct0p4LZFQhw8kdIeLM(-1047165041 ^ -1047139787)
											};
											Mdhv0A4LKtjaTQ7nouVq(obj4, current5.ID);
											obj4.IsExpanded = true;
											t7Wto9FMbOhxvJPJoJ4 item6 = obj4;
											t7Wto9FMbOhxvJPJoJ19.Children.Add(item6);
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											enumerator3.Dispose();
											int num13 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
											{
												num13 = 0;
											}
											switch (num13)
											{
											case 0:
												break;
											}
										}
									}
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ22 = new t7Wto9FMbOhxvJPJoJ4();
									B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ22, f0ct0p4LZFQhw8kdIeLM(0x6F7F734B ^ 0x6F7F1E81));
									t7Wto9FMbOhxvJPJoJ22.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD55F6C);
									t7Wto9FMbOhxvJPJoJ23 = t7Wto9FMbOhxvJPJoJ22;
									num4 = 54;
									continue;
								}
								case 13:
									if (t7Wto9FMbOhxvJPJoJ11.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ20.Children.Add(t7Wto9FMbOhxvJPJoJ11);
									}
									if (t7Wto9FMbOhxvJPJoJ12.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ20.Children.Add(t7Wto9FMbOhxvJPJoJ12);
									}
									break;
								case 92:
									if (num6 > 3887724832u)
									{
										if (num6 != 4122702944u)
										{
											num4 = 83;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
											{
												num4 = 83;
											}
											continue;
										}
										goto case 113;
									}
									if (num6 != 3777067153u)
									{
										num9 = 76;
										goto IL_027f;
									}
									if (BALt4G4LVbEH3jOlZfUw(text, f0ct0p4LZFQhw8kdIeLM(0x4662F6AF ^ 0x46629A2F)))
									{
										t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ37 = new t7Wto9FMbOhxvJPJoJ4();
										B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ37, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
										DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ37, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57742889));
										t7Wto9FMbOhxvJPJoJ14 = t7Wto9FMbOhxvJPJoJ37;
										num4 = 36;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
										{
											num4 = 1;
										}
										continue;
									}
									break;
								case 102:
								{
									try
									{
										while (true)
										{
											if (!enumerator4.MoveNext())
											{
												int num7 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
												{
													num7 = 1;
												}
												switch (num7)
												{
												case 1:
													goto end_IL_28d9;
												}
											}
											OUh0F2njXZNu6MEJpVau CS_0024_003C_003E8__locals19 = new OUh0F2njXZNu6MEJpVau();
											CS_0024_003C_003E8__locals19.zjnnjjxqi4V = enumerator4.Current;
											IEnumerable<Symbol> enumerable = list2.Where((Symbol s) => (string)OUh0F2njXZNu6MEJpVau.nBMNE4NiXavNZydZc53H(s) == CS_0024_003C_003E8__locals19.zjnnjjxqi4V);
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ6 = new t7Wto9FMbOhxvJPJoJ4();
											B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ6, CS_0024_003C_003E8__locals19.zjnnjjxqi4V);
											t7Wto9FMbOhxvJPJoJ6.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801475538);
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ7 = t7Wto9FMbOhxvJPJoJ6;
											t7Wto9FMbOhxvJPJoJ8.Children.Add(t7Wto9FMbOhxvJPJoJ7);
											enumerator3 = enumerable.GetEnumerator();
											try
											{
												while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
												{
													Symbol current3 = enumerator3.Current;
													int num8 = 0;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
													{
														num8 = 0;
													}
													while (true)
													{
														switch (num8)
														{
														default:
														{
															t7Wto9FMbOhxvJPJoJ4 obj = new t7Wto9FMbOhxvJPJoJ4
															{
																Name = (string)bIITL14LrEMmS6o2UfXU(current3)
															};
															DBWsLL4LCho5WPbxbywX(obj, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xAD5B8B3 ^ 0xAD5D509));
															obj.UTPFUh7JhO(current3.ID);
															PJyj2j4L82PboVgykDYE(obj, true);
															t7Wto9FMbOhxvJPJoJ4 item4 = obj;
															t7Wto9FMbOhxvJPJoJ7.Children.Add(item4);
															num8 = 0;
															if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
															{
																num8 = 1;
															}
															continue;
														}
														case 1:
															break;
														}
														break;
													}
												}
											}
											finally
											{
												enumerator3?.Dispose();
											}
											continue;
											end_IL_28d9:
											break;
										}
									}
									finally
									{
										if (enumerator4 != null)
										{
											EA6VMq4Lh7Hyc5USMbh0(enumerator4);
										}
									}
									t7Wto9FMbOhxvJPJoJ9 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1DB56F),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(0x16AD7E76 ^ 0x16AD13DA)
									};
									t7Wto9FMbOhxvJPJoJ4 obj2 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(-602153869 ^ -602164723)
									};
									DBWsLL4LCho5WPbxbywX(obj2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BF8ACC1));
									t7Wto9FMbOhxvJPJoJ10 = obj2;
									enumerator = (from s in list.Where(nYUPtTncpLTTeP3lORg.wTJnjo6WXEq)
										where L1CKQvnjysYct0mwdUU4.rdmQyGNiKds00RoWIRnr(s)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).ToList().GetEnumerator();
									num4 = 82;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
									{
										num4 = 4;
									}
									continue;
								}
								case 99:
									t7Wto9FMbOhxvJPJoJ4.Children.Add(t7Wto9FMbOhxvJPJoJ5);
									num4 = 109;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
									{
										num4 = 78;
									}
									continue;
								case 35:
									if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801475422))
									{
										goto case 11;
									}
									break;
								case 25:
									try
									{
										while (true)
										{
											if (!B3AUtk4LmR6vx6nnvdFK(enumerator3))
											{
												int num44 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
												{
													num44 = 1;
												}
												switch (num44)
												{
												case 1:
													goto end_IL_2b84;
												}
											}
											Symbol current27 = enumerator3.Current;
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ70 = new t7Wto9FMbOhxvJPJoJ4();
											B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ70, current27.Name);
											t7Wto9FMbOhxvJPJoJ70.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46629B15);
											t7Wto9FMbOhxvJPJoJ70.UTPFUh7JhO(current27.ID);
											t7Wto9FMbOhxvJPJoJ70.IsExpanded = true;
											t7Wto9FMbOhxvJPJoJ4 item23 = t7Wto9FMbOhxvJPJoJ70;
											t7Wto9FMbOhxvJPJoJ33.Children.Add(item23);
											continue;
											end_IL_2b84:
											break;
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											EA6VMq4Lh7Hyc5USMbh0(enumerator3);
										}
									}
									goto case 46;
								case 54:
									t7Wto9FMbOhxvJPJoJ21.Children.Add(t7Wto9FMbOhxvJPJoJ23);
									num4 = 3;
									continue;
								case 20:
								{
									t7Wto9FMbOhxvJPJoJ4 obj10 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(-602153869 ^ -602151229)
									};
									DBWsLL4LCho5WPbxbywX(obj10, f0ct0p4LZFQhw8kdIeLM(0x32DEA4F1 ^ 0x32DEC95D));
									t7Wto9FMbOhxvJPJoJ8 = obj10;
									num4 = 96;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
									{
										num4 = 18;
									}
									continue;
								}
								case 98:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ69);
									num4 = 52;
									continue;
								case 75:
									goto IL_2e4b;
								case 64:
									t7Wto9FMbOhxvJPJoJ69.Children.Add(t7Wto9FMbOhxvJPJoJ18);
									num4 = 45;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
									{
										num4 = 85;
									}
									continue;
								case 93:
									if (num6 > 2618539384u)
									{
										if (num6 == 2658020261u)
										{
											if (BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D5556E2)))
											{
												goto case 50;
											}
											break;
										}
										goto IL_0b3a;
									}
									num4 = 43;
									continue;
								case 112:
									t7Wto9FMbOhxvJPJoJ28.Children.Add(t7Wto9FMbOhxvJPJoJ2);
									goto IL_2365;
								case 12:
									if (num6 != 3573002156u)
									{
										if (num6 != 3670628538u)
										{
											num4 = 21;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
											{
												num4 = 70;
											}
											continue;
										}
										goto case 35;
									}
									goto case 49;
								case 106:
									if (!BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671198983)))
									{
										break;
									}
									num4 = 4;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
									{
										num4 = 40;
									}
									continue;
								case 31:
									t7Wto9FMbOhxvJPJoJ35 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57753857),
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487E9C2)
									};
									t7Wto9FMbOhxvJPJoJ14.Children.Add(t7Wto9FMbOhxvJPJoJ35);
									num4 = 58;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
									{
										num4 = 117;
									}
									continue;
								case 6:
									if (t7Wto9FMbOhxvJPJoJ8.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ42.Children.Add(t7Wto9FMbOhxvJPJoJ8);
									}
									break;
								case 77:
								{
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ41 = new t7Wto9FMbOhxvJPJoJ4();
									B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ41, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
									DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ41, f0ct0p4LZFQhw8kdIeLM(0x404ED0BE ^ 0x404EBD26));
									t7Wto9FMbOhxvJPJoJ4 = t7Wto9FMbOhxvJPJoJ41;
									num4 = 27;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
									{
										num4 = 10;
									}
									continue;
								}
								case 10:
									t7Wto9FMbOhxvJPJoJ28 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2,
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325209557)
									};
									num4 = 37;
									continue;
								case 100:
									t7Wto9FMbOhxvJPJoJ46 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(-1774602229 ^ -1774594623),
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F643290)
									};
									t7Wto9FMbOhxvJPJoJ25.Children.Add(t7Wto9FMbOhxvJPJoJ46);
									num9 = 72;
									goto IL_027f;
								case 9:
									goto IL_3236;
								case 111:
									if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056696152)))
									{
										break;
									}
									goto IL_38b1;
								case 23:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ21);
									num4 = 60;
									continue;
								case 95:
									t7Wto9FMbOhxvJPJoJ33 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = (string)f0ct0p4LZFQhw8kdIeLM(0x24085900 ^ 0x240834FA),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(0x2C8374E4 ^ 0x2C831948)
									};
									num9 = 4;
									goto IL_027f;
								case 66:
									try
									{
										while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
										{
											while (true)
											{
												Symbol current22 = enumerator3.Current;
												int num33;
												if (current22.Type == SymbolType.Crypto)
												{
													num33 = 0;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
													{
														num33 = 0;
													}
													goto IL_332d;
												}
												goto IL_33e5;
												IL_33e5:
												if (r4l1jg4LJlinXcPi7IF6(current22) != SymbolType.Future)
												{
													break;
												}
												t7Wto9FMbOhxvJPJoJ4 item18 = new t7Wto9FMbOhxvJPJoJ4(current22);
												t7Wto9FMbOhxvJPJoJ12.Children.Add(item18);
												num33 = 2;
												goto IL_332d;
												IL_332d:
												switch (num33)
												{
												default:
												{
													t7Wto9FMbOhxvJPJoJ4 item19 = new t7Wto9FMbOhxvJPJoJ4(current22);
													t7Wto9FMbOhxvJPJoJ11.Children.Add(item19);
													break;
												}
												case 2:
													break;
												case 1:
													goto IL_33e5;
												case 3:
													continue;
												}
												break;
											}
										}
									}
									finally
									{
										if (enumerator3 == null)
										{
											int num34 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
											{
												num34 = 0;
											}
											switch (num34)
											{
											case 0:
												break;
											}
										}
										else
										{
											EA6VMq4Lh7Hyc5USMbh0(enumerator3);
										}
									}
									goto case 13;
								case 24:
									goto IL_34ab;
								default:
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ51);
									num4 = 22;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
									{
										num4 = 0;
									}
									continue;
								case 38:
									goto IL_360b;
								case 90:
									try
									{
										while (enumerator3.MoveNext())
										{
											while (true)
											{
												Symbol current20 = enumerator3.Current;
												if (!KjEZOi4L7L5tiXgAC78e(current20))
												{
													break;
												}
												int num31 = 2;
												while (true)
												{
													switch (num31)
													{
													case 1:
														goto IL_37b7;
													case 2:
														source8 = from symbol in current20.GetContracts()
															where !ljYFLbRetF(symbol)
															select symbol;
														num31 = 1;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
														{
															num31 = 1;
														}
														continue;
													case 3:
														goto IL_3817;
													}
													break;
													IL_3817:
													t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ59 = new t7Wto9FMbOhxvJPJoJ4();
													t7Wto9FMbOhxvJPJoJ59.Name = current20.Name;
													t7Wto9FMbOhxvJPJoJ59.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D315D94);
													t7Wto9FMbOhxvJPJoJ59.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current20));
													t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ60 = t7Wto9FMbOhxvJPJoJ59;
													t7Wto9FMbOhxvJPJoJ50.Children.Add(t7Wto9FMbOhxvJPJoJ60);
													IEnumerator<Symbol> enumerator5 = source8.OrderBy((Symbol c) => c.Name).GetEnumerator();
													try
													{
														while (B3AUtk4LmR6vx6nnvdFK(enumerator5))
														{
															Symbol current21 = enumerator5.Current;
															int num32 = 1;
															if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
															{
																num32 = 0;
															}
															while (true)
															{
																switch (num32)
																{
																case 1:
																{
																	t7Wto9FMbOhxvJPJoJ4 obj7 = new t7Wto9FMbOhxvJPJoJ4
																	{
																		Name = current21.Name
																	};
																	DBWsLL4LCho5WPbxbywX(obj7, f0ct0p4LZFQhw8kdIeLM(-1878953018 ^ -1878974852));
																	Mdhv0A4LKtjaTQ7nouVq(obj7, current21.ID);
																	obj7.IsExpanded = true;
																	item17 = obj7;
																	num32 = 0;
																	if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
																	{
																		num32 = 0;
																	}
																	continue;
																}
																}
																break;
															}
															t7Wto9FMbOhxvJPJoJ60.Children.Add(item17);
														}
													}
													finally
													{
														if (enumerator5 != null)
														{
															EA6VMq4Lh7Hyc5USMbh0(enumerator5);
														}
													}
													goto end_IL_37a9;
													IL_37b7:
													if (!source8.Any())
													{
														goto end_IL_37a9;
													}
													num31 = 3;
												}
												continue;
												end_IL_37a9:
												break;
											}
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									break;
								case 55:
									if (num6 != 1903672507)
									{
										if (num6 != 1945420267)
										{
											break;
										}
										if (!(text == (string)f0ct0p4LZFQhw8kdIeLM(--500511424 ^ 0x1DD55F44)))
										{
											num4 = 8;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
											{
												num4 = 21;
											}
											continue;
										}
										goto case 10;
									}
									goto case 111;
								case 30:
									if (t7Wto9FMbOhxvJPJoJ9.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ42.Children.Add(t7Wto9FMbOhxvJPJoJ9);
									}
									if (t7Wto9FMbOhxvJPJoJ10.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ42.Children.Add(t7Wto9FMbOhxvJPJoJ10);
										num4 = 6;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
										{
											num4 = 6;
										}
										continue;
									}
									goto case 6;
								case 39:
									try
									{
										while (true)
										{
											int num27;
											if (enumerator4.MoveNext())
											{
												xWe4NNnjNdmmTKB9uUHA = new XWe4NNnjNdmmTKB9uUHA();
												xWe4NNnjNdmmTKB9uUHA.y4ynj1SDnDh = enumerator4.Current;
												num27 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
												{
													num27 = 0;
												}
											}
											else
											{
												num27 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
												{
													num27 = 1;
												}
											}
											switch (num27)
											{
											default:
											{
												IEnumerable<Symbol> source7 = list5.Where(xWe4NNnjNdmmTKB9uUHA.K7RnjkjLYie);
												t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ52 = new t7Wto9FMbOhxvJPJoJ4();
												B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ52, xWe4NNnjNdmmTKB9uUHA.y4ynj1SDnDh);
												t7Wto9FMbOhxvJPJoJ52.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x37419C98);
												t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ53 = t7Wto9FMbOhxvJPJoJ52;
												t7Wto9FMbOhxvJPJoJ49.Children.Add(t7Wto9FMbOhxvJPJoJ53);
												enumerator3 = source7.OrderBy((Symbol s) => s.Name).GetEnumerator();
												try
												{
													while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
													{
														Symbol current17 = enumerator3.Current;
														t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ54 = new t7Wto9FMbOhxvJPJoJ4();
														B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ54, current17.Name);
														DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ54, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671198827));
														t7Wto9FMbOhxvJPJoJ54.UTPFUh7JhO(current17.ID);
														PJyj2j4L82PboVgykDYE(t7Wto9FMbOhxvJPJoJ54, true);
														t7Wto9FMbOhxvJPJoJ4 item14 = t7Wto9FMbOhxvJPJoJ54;
														int num28 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
														{
															num28 = 0;
														}
														while (true)
														{
															switch (num28)
															{
															default:
																t7Wto9FMbOhxvJPJoJ53.Children.Add(item14);
																num28 = 1;
																if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
																{
																	num28 = 1;
																}
																continue;
															case 1:
																break;
															}
															break;
														}
													}
												}
												finally
												{
													if (enumerator3 != null)
													{
														EA6VMq4Lh7Hyc5USMbh0(enumerator3);
													}
												}
												continue;
											}
											case 1:
												break;
											}
											break;
										}
									}
									finally
									{
										enumerator4?.Dispose();
									}
									break;
								case 91:
									goto IL_3b6b;
								case 27:
								{
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ4);
									IOrderedEnumerable<Symbol> orderedEnumerable3 = from o in list.Where(nYUPtTncpLTTeP3lORg.fFenjlD0DvB)
										orderby (string)L1CKQvnjysYct0mwdUU4.fVlpoxNimitXH6xv2Dw1(o)
										select o;
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ47 = new t7Wto9FMbOhxvJPJoJ4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C4381));
									t7Wto9FMbOhxvJPJoJ5 = new t7Wto9FMbOhxvJPJoJ4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530028921));
									t7Wto9FMbOhxvJPJoJ13 = new t7Wto9FMbOhxvJPJoJ4((string)f0ct0p4LZFQhw8kdIeLM(--18459671 ^ 0x119C1DD));
									enumerator3 = orderedEnumerable3.GetEnumerator();
									try
									{
										while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
										{
											Symbol current15 = enumerator3.Current;
											int num23;
											if (current15.Type == SymbolType.Crypto)
											{
												num23 = 3;
												goto IL_3e73;
											}
											goto IL_3f0e;
											IL_3f99:
											t7Wto9FMbOhxvJPJoJ4 item11 = new t7Wto9FMbOhxvJPJoJ4(current15);
											t7Wto9FMbOhxvJPJoJ5.Children.Add(item11);
											num23 = 1;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
											{
												num23 = 5;
											}
											goto IL_3e73;
											IL_3e73:
											while (true)
											{
												switch (num23)
												{
												case 3:
													item13 = new t7Wto9FMbOhxvJPJoJ4(current15);
													num23 = 0;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
													{
														num23 = 0;
													}
													continue;
												default:
													t7Wto9FMbOhxvJPJoJ47.Children.Add(item13);
													goto IL_3fee;
												case 2:
													break;
												case 4:
													goto IL_3f99;
												case 5:
												case 6:
													goto IL_3fee;
												case 1:
												{
													t7Wto9FMbOhxvJPJoJ4 item12 = new t7Wto9FMbOhxvJPJoJ4(current15);
													t7Wto9FMbOhxvJPJoJ13.Children.Add(item12);
													int num24 = 6;
													num23 = num24;
													continue;
												}
												}
												break;
											}
											goto IL_3f0e;
											IL_3f0e:
											if (r4l1jg4LJlinXcPi7IF6(current15) != SymbolType.Future || !rfHiJi4L31qZQ8MgGqHS(H7xmAP4LFJHPvFsqyaHT(current15), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842066491)))
											{
												if (r4l1jg4LJlinXcPi7IF6(current15) != SymbolType.Future)
												{
													continue;
												}
												num23 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
												{
													num23 = 0;
												}
												goto IL_3e73;
											}
											goto IL_3f99;
											IL_3fee:;
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											enumerator3.Dispose();
											int num25 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
											{
												num25 = 0;
											}
											switch (num25)
											{
											case 0:
												break;
											}
										}
									}
									if (t7Wto9FMbOhxvJPJoJ47.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ4.Children.Add(t7Wto9FMbOhxvJPJoJ47);
									}
									if (t7Wto9FMbOhxvJPJoJ5.Children.Any())
									{
										num4 = 99;
										continue;
									}
									goto case 109;
								}
								case 61:
									if (num6 <= 1619544453)
									{
										num4 = 65;
										continue;
									}
									goto IL_3c64;
								case 119:
									goto IL_3c64;
								case 72:
									synFSKIMWU(list, t7Wto9FMbOhxvJPJoJ46, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
									hashSet5 = new HashSet<string>();
									list5 = (from s in list.Where(nYUPtTncpLTTeP3lORg.CQ0nj9qu8ks)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).ToList();
									enumerator = list5.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											Symbol current14 = enumerator.Current;
											int num22 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
											{
												num22 = 0;
											}
											switch (num22)
											{
											}
											hashSet5.Add(current14.Currency);
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 67;
								case 49:
									if (BALt4G4LVbEH3jOlZfUw(text, f0ct0p4LZFQhw8kdIeLM(0xECA3F28 ^ 0xECA525C)))
									{
										t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ61 = new t7Wto9FMbOhxvJPJoJ4();
										B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ61, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
										t7Wto9FMbOhxvJPJoJ61.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F7606);
										t7Wto9FMbOhxvJPJoJ20 = t7Wto9FMbOhxvJPJoJ61;
										num4 = 46;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
										{
											num4 = 115;
										}
										continue;
									}
									break;
								case 22:
									hashSet4 = new HashSet<string>();
									num4 = 29;
									continue;
								case 103:
									goto IL_3d0f;
								case 62:
								{
									t7Wto9FMbOhxvJPJoJ4 obj9 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DEC93B)
									};
									DBWsLL4LCho5WPbxbywX(obj9, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x809D767));
									t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ67 = obj9;
									t7Wto9FMbOhxvJPJoJ27.Children.Add(t7Wto9FMbOhxvJPJoJ67);
									enumerator = (from s in list.Where(nYUPtTncpLTTeP3lORg.NPknjayAQrq)
										where s.IsMaster
										orderby s.Name
										select s).ToList().GetEnumerator();
									try
									{
										while (true)
										{
											int num40;
											if (!enumerator.MoveNext())
											{
												num40 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
												{
													num40 = 1;
												}
											}
											else
											{
												orderedEnumerable6 = from c in enumerator.Current.GetContracts()
													where !ljYFLbRetF(c)
													orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(c)
													select c;
												if (!orderedEnumerable6.Any())
												{
													continue;
												}
												num40 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
												{
													num40 = 0;
												}
											}
											switch (num40)
											{
											default:
												enumerator3 = orderedEnumerable6.GetEnumerator();
												try
												{
													while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
													{
														while (true)
														{
															Symbol current25 = enumerator3.Current;
															t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ68 = new t7Wto9FMbOhxvJPJoJ4();
															t7Wto9FMbOhxvJPJoJ68.Name = current25.Name;
															t7Wto9FMbOhxvJPJoJ68.Path = (string)f0ct0p4LZFQhw8kdIeLM(0x706541F3 ^ 0x70652C49);
															t7Wto9FMbOhxvJPJoJ68.UTPFUh7JhO(current25.ID);
															PJyj2j4L82PboVgykDYE(t7Wto9FMbOhxvJPJoJ68, true);
															t7Wto9FMbOhxvJPJoJ4 item22 = t7Wto9FMbOhxvJPJoJ68;
															t7Wto9FMbOhxvJPJoJ67.Children.Add(item22);
															int num41 = 0;
															if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
															{
																num41 = 0;
															}
															switch (num41)
															{
															case 1:
																continue;
															}
															break;
														}
													}
												}
												finally
												{
													if (enumerator3 != null)
													{
														enumerator3.Dispose();
														int num42 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
														{
															num42 = 0;
														}
														switch (num42)
														{
														case 0:
															break;
														}
													}
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									break;
								}
								case 113:
									if (!BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741BE967)))
									{
										break;
									}
									goto IL_38b1;
								case 11:
									t7Wto9FMbOhxvJPJoJ32 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2,
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962501525)
									};
									num4 = 89;
									continue;
								case 7:
									if (num6 != 1619544453)
									{
										break;
									}
									if (!BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123793509)))
									{
										num9 = 8;
										goto IL_027f;
									}
									goto IL_38b1;
								case 58:
									if (!BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90280438)))
									{
										num9 = 34;
										goto IL_027f;
									}
									goto case 11;
								case 3:
									enumerator3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.TOlnczEuf3I)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).GetEnumerator();
									try
									{
										while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
										{
											Symbol current11 = enumerator3.Current;
											int num19 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
											{
												num19 = 0;
											}
											while (true)
											{
												switch (num19)
												{
												case 3:
													if (source6.Any())
													{
														t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ45 = new t7Wto9FMbOhxvJPJoJ4();
														B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ45, current11.Name);
														DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ45, f0ct0p4LZFQhw8kdIeLM(0x7DB10E6E ^ 0x7DB163B2));
														t7Wto9FMbOhxvJPJoJ45.UTPFUh7JhO(current11.ID);
														t7Wto9FMbOhxvJPJoJ44 = t7Wto9FMbOhxvJPJoJ45;
														num19 = 1;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
														{
															num19 = 0;
														}
														continue;
													}
													break;
												case 1:
													t7Wto9FMbOhxvJPJoJ23.Children.Add(t7Wto9FMbOhxvJPJoJ44);
													num19 = 2;
													continue;
												default:
													if (current11.IsMaster)
													{
														source6 = from symbol in current11.GetContracts()
															where !ljYFLbRetF(symbol)
															select symbol;
														num19 = 2;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
														{
															num19 = 3;
														}
														continue;
													}
													break;
												case 2:
												{
													IEnumerator<Symbol> enumerator5 = source6.OrderBy((Symbol c) => c.Name).GetEnumerator();
													try
													{
														while (true)
														{
															int num20;
															if (!B3AUtk4LmR6vx6nnvdFK(enumerator5))
															{
																num20 = 0;
																if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
																{
																	num20 = 1;
																}
															}
															else
															{
																Symbol current12 = enumerator5.Current;
																t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ43 = new t7Wto9FMbOhxvJPJoJ4();
																B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ43, bIITL14LrEMmS6o2UfXU(current12));
																t7Wto9FMbOhxvJPJoJ43.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB464C9);
																t7Wto9FMbOhxvJPJoJ43.UTPFUh7JhO(current12.ID);
																t7Wto9FMbOhxvJPJoJ43.IsExpanded = true;
																item10 = t7Wto9FMbOhxvJPJoJ43;
																num20 = 0;
																if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
																{
																	num20 = 0;
																}
															}
															switch (num20)
															{
															case 1:
																goto end_IL_0669;
															}
															t7Wto9FMbOhxvJPJoJ44.Children.Add(item10);
															continue;
															end_IL_0669:
															break;
														}
													}
													finally
													{
														if (enumerator5 != null)
														{
															EA6VMq4Lh7Hyc5USMbh0(enumerator5);
														}
													}
													break;
												}
												}
												break;
											}
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									goto case 95;
								case 78:
									enumerator3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.KuYnj0SwCal)
										orderby s.Name
										select s).GetEnumerator();
									num4 = 25;
									continue;
								case 84:
									enumerator3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.Muwnj2Imgwg)
										orderby s.Name
										select s).GetEnumerator();
									try
									{
										while (true)
										{
											int num18;
											if (enumerator3.MoveNext())
											{
												Symbol current10 = enumerator3.Current;
												t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ39 = new t7Wto9FMbOhxvJPJoJ4();
												t7Wto9FMbOhxvJPJoJ39.Name = current10.Name;
												t7Wto9FMbOhxvJPJoJ39.Path = (string)f0ct0p4LZFQhw8kdIeLM(0x28C965BE ^ 0x28C90804);
												t7Wto9FMbOhxvJPJoJ39.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current10));
												t7Wto9FMbOhxvJPJoJ39.IsExpanded = true;
												item9 = t7Wto9FMbOhxvJPJoJ39;
												num18 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
												{
													num18 = 0;
												}
											}
											else
											{
												num18 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
												{
													num18 = 1;
												}
											}
											switch (num18)
											{
											case 1:
												goto end_IL_16f5;
											}
											t7Wto9FMbOhxvJPJoJ40.Children.Add(item9);
											continue;
											end_IL_16f5:
											break;
										}
									}
									finally
									{
										enumerator3?.Dispose();
									}
									break;
								case 53:
									enumerator3 = (from c in list.Where(nYUPtTncpLTTeP3lORg.el1njf9ucvl)
										orderby c.Name
										select c).GetEnumerator();
									num4 = 90;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
									{
										num4 = 50;
									}
									continue;
								case 117:
									enumerator4 = hashSet2.OrderBy((string c) => c).GetEnumerator();
									try
									{
										while (enumerator4.MoveNext())
										{
											iUKxE1nj5xAueeinLv6U CS_0024_003C_003E8__locals22 = new iUKxE1nj5xAueeinLv6U();
											CS_0024_003C_003E8__locals22.lONnjxOnkmA = enumerator4.Current;
											IEnumerable<Symbol> source5 = list4.Where((Symbol s) => iUKxE1nj5xAueeinLv6U.yKFHuYNibFgBrDRlwXUM(s.Currency, CS_0024_003C_003E8__locals22.lONnjxOnkmA));
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ34 = new t7Wto9FMbOhxvJPJoJ4
											{
												Name = CS_0024_003C_003E8__locals22.lONnjxOnkmA,
												Path = (string)f0ct0p4LZFQhw8kdIeLM(0x4297C3EB ^ 0x4297AE47)
											};
											t7Wto9FMbOhxvJPJoJ35.Children.Add(t7Wto9FMbOhxvJPJoJ34);
											enumerator3 = source5.OrderBy((Symbol s) => s.Name).GetEnumerator();
											try
											{
												while (true)
												{
													if (!enumerator3.MoveNext())
													{
														int num16 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
														{
															num16 = 0;
														}
														switch (num16)
														{
														case 1:
															goto IL_2130;
														case 0:
															break;
														}
														break;
													}
													goto IL_2130;
													IL_2130:
													Symbol current8 = enumerator3.Current;
													t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ36 = new t7Wto9FMbOhxvJPJoJ4();
													t7Wto9FMbOhxvJPJoJ36.Name = current8.Name;
													t7Wto9FMbOhxvJPJoJ36.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087104060);
													t7Wto9FMbOhxvJPJoJ36.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current8));
													t7Wto9FMbOhxvJPJoJ36.IsExpanded = true;
													t7Wto9FMbOhxvJPJoJ4 item8 = t7Wto9FMbOhxvJPJoJ36;
													t7Wto9FMbOhxvJPJoJ34.Children.Add(item8);
												}
											}
											finally
											{
												if (enumerator3 != null)
												{
													EA6VMq4Lh7Hyc5USMbh0(enumerator3);
												}
											}
										}
									}
									finally
									{
										enumerator4?.Dispose();
									}
									goto case 15;
								case 29:
									list3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.Td5njGybP7O)
										orderby s.Name
										select s).ToList();
									num4 = 97;
									continue;
								case 107:
									enumerator4 = hashSet4.OrderBy((string c) => c).GetEnumerator();
									try
									{
										while (B3AUtk4LmR6vx6nnvdFK(enumerator4))
										{
											while (true)
											{
												CS_0024_003C_003E8__locals23 = new yafV59njLUhAFGYxkwkS();
												int num35 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
												{
													num35 = 1;
												}
												switch (num35)
												{
												case 1:
													break;
												default:
													continue;
												}
												break;
											}
											CS_0024_003C_003E8__locals23.z1bnjsQSZ3p = enumerator4.Current;
											IEnumerable<Symbol> enumerable2 = list3.Where((Symbol s) => yafV59njLUhAFGYxkwkS.ojLoQLNiSmuLlQS2dm86(s.Currency, CS_0024_003C_003E8__locals23.z1bnjsQSZ3p));
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ62 = new t7Wto9FMbOhxvJPJoJ4();
											B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ62, CS_0024_003C_003E8__locals23.z1bnjsQSZ3p);
											t7Wto9FMbOhxvJPJoJ62.Path = (string)f0ct0p4LZFQhw8kdIeLM(0x1AB79299 ^ 0x1AB7FF35);
											t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ63 = t7Wto9FMbOhxvJPJoJ62;
											t7Wto9FMbOhxvJPJoJ51.Children.Add(t7Wto9FMbOhxvJPJoJ63);
											enumerator3 = enumerable2.GetEnumerator();
											try
											{
												while (true)
												{
													int num36;
													if (!enumerator3.MoveNext())
													{
														num36 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
														{
															num36 = 0;
														}
													}
													else
													{
														Symbol current23 = enumerator3.Current;
														t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ64 = new t7Wto9FMbOhxvJPJoJ4();
														t7Wto9FMbOhxvJPJoJ64.Name = (string)bIITL14LrEMmS6o2UfXU(current23);
														t7Wto9FMbOhxvJPJoJ64.Path = (string)f0ct0p4LZFQhw8kdIeLM(0x20B584D2 ^ 0x20B5E968);
														t7Wto9FMbOhxvJPJoJ64.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current23));
														t7Wto9FMbOhxvJPJoJ64.IsExpanded = true;
														item20 = t7Wto9FMbOhxvJPJoJ64;
														num36 = 1;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
														{
															num36 = 0;
														}
													}
													switch (num36)
													{
													case 1:
														goto IL_0ed2;
													case 0:
														break;
													}
													break;
													IL_0ed2:
													t7Wto9FMbOhxvJPJoJ63.Children.Add(item20);
												}
											}
											finally
											{
												if (enumerator3 == null)
												{
													int num37 = 0;
													if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
													{
														num37 = 0;
													}
													switch (num37)
													{
													case 0:
														break;
													}
												}
												else
												{
													EA6VMq4Lh7Hyc5USMbh0(enumerator3);
												}
											}
										}
									}
									finally
									{
										enumerator4?.Dispose();
									}
									break;
								case 96:
									list2 = (from s in list.Where(nYUPtTncpLTTeP3lORg.waUnjYCHaOJ)
										orderby s.Name
										select s).ToList();
									enumerator = list2.GetEnumerator();
									num4 = 114;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
									{
										num4 = 110;
									}
									continue;
								case 116:
									enumerator4 = hashSet3.OrderBy((string c) => c).GetEnumerator();
									num4 = 102;
									continue;
								case 56:
									enumerator3 = source3.OrderBy((Symbol s) => (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)).GetEnumerator();
									num4 = 47;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
									{
										num4 = 7;
									}
									continue;
								case 88:
									source2 = (from s in list.Where(nYUPtTncpLTTeP3lORg.HWAnji9OjpF)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).ToList();
									enumerator3 = source2.Where(eWhpfxnjOyBQ22ldYLHr.W4anjqPuj9J).GetEnumerator();
									num4 = 80;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
									{
										num4 = 60;
									}
									continue;
								case 85:
									enumerator4 = eWhpfxnjOyBQ22ldYLHr.WeInjI2glbl.OrderBy((string c) => c).GetEnumerator();
									try
									{
										while (true)
										{
											int num10;
											if (!B3AUtk4LmR6vx6nnvdFK(enumerator4))
											{
												num10 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
												{
													num10 = 1;
												}
											}
											else
											{
												GWkRB3njtIvPpYTbIM8i CS_0024_003C_003E8__locals20 = new GWkRB3njtIvPpYTbIM8i();
												CS_0024_003C_003E8__locals20.KlynjTA4HoW = enumerator4.Current;
												IEnumerable<Symbol> source = source2.Where((Symbol s) => s.Currency == CS_0024_003C_003E8__locals20.KlynjTA4HoW);
												t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ16 = new t7Wto9FMbOhxvJPJoJ4();
												B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ16, CS_0024_003C_003E8__locals20.KlynjTA4HoW);
												t7Wto9FMbOhxvJPJoJ16.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C90812);
												t7Wto9FMbOhxvJPJoJ17 = t7Wto9FMbOhxvJPJoJ16;
												t7Wto9FMbOhxvJPJoJ18.Children.Add(t7Wto9FMbOhxvJPJoJ17);
												enumerator3 = source.OrderBy((Symbol s) => (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)).GetEnumerator();
												num10 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
												{
													num10 = 0;
												}
											}
											switch (num10)
											{
											default:
												try
												{
													while (B3AUtk4LmR6vx6nnvdFK(enumerator3))
													{
														Symbol current4 = enumerator3.Current;
														int num11 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
														{
															num11 = 0;
														}
														while (true)
														{
															switch (num11)
															{
															default:
															{
																t7Wto9FMbOhxvJPJoJ4 obj3 = new t7Wto9FMbOhxvJPJoJ4
																{
																	Name = (string)bIITL14LrEMmS6o2UfXU(current4),
																	Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x37419C8E)
																};
																Mdhv0A4LKtjaTQ7nouVq(obj3, delPg94LwvSL747LoogP(current4));
																obj3.IsExpanded = true;
																item5 = obj3;
																num11 = 1;
																if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
																{
																	num11 = 0;
																}
																continue;
															}
															case 1:
																break;
															}
															break;
														}
														t7Wto9FMbOhxvJPJoJ17.Children.Add(item5);
													}
												}
												finally
												{
													enumerator3?.Dispose();
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator4 != null)
										{
											EA6VMq4Lh7Hyc5USMbh0(enumerator4);
										}
									}
									break;
								case 18:
								{
									IOrderedEnumerable<Symbol> orderedEnumerable2 = from o in list.Where(nYUPtTncpLTTeP3lORg.qfhnj4RbK24)
										orderby o.Code
										select o;
									t7Wto9FMbOhxvJPJoJ11 = new t7Wto9FMbOhxvJPJoJ4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBED081));
									t7Wto9FMbOhxvJPJoJ12 = new t7Wto9FMbOhxvJPJoJ4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198970772));
									enumerator3 = orderedEnumerable2.GetEnumerator();
									num4 = 66;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
									{
										num4 = 17;
									}
									continue;
								}
								case 32:
								{
									IOrderedEnumerable<Symbol> orderedEnumerable = from o in list.Where(nYUPtTncpLTTeP3lORg.Gy5njDmBA0R)
										orderby o.Code
										select o;
									t7Wto9FMbOhxvJPJoJ2 = new t7Wto9FMbOhxvJPJoJ4((string)f0ct0p4LZFQhw8kdIeLM(-1461292091 ^ -1461302923));
									t7Wto9FMbOhxvJPJoJ3 = new t7Wto9FMbOhxvJPJoJ4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774594623));
									enumerator3 = orderedEnumerable.GetEnumerator();
									try
									{
										while (true)
										{
											IL_2d3d:
											int num5;
											if (!enumerator3.MoveNext())
											{
												num5 = 2;
											}
											else
											{
												current2 = enumerator3.Current;
												num5 = 3;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
												{
													num5 = 3;
												}
											}
											while (true)
											{
												switch (num5)
												{
												case 3:
													if (current2.Type == SymbolType.Crypto)
													{
														t7Wto9FMbOhxvJPJoJ4 item2 = new t7Wto9FMbOhxvJPJoJ4(current2);
														t7Wto9FMbOhxvJPJoJ2.Children.Add(item2);
														num5 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
														{
															num5 = 0;
														}
														continue;
													}
													if (current2.Type == SymbolType.Future)
													{
														t7Wto9FMbOhxvJPJoJ4 item3 = new t7Wto9FMbOhxvJPJoJ4(current2);
														t7Wto9FMbOhxvJPJoJ3.Children.Add(item3);
														num5 = 0;
														if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
														{
															num5 = 1;
														}
														continue;
													}
													break;
												case 2:
													goto end_IL_2ced;
												}
												goto IL_2d3d;
												continue;
												end_IL_2ced:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											EA6VMq4Lh7Hyc5USMbh0(enumerator3);
										}
									}
									if (t7Wto9FMbOhxvJPJoJ2.Children.Any())
									{
										num4 = 112;
										continue;
									}
									goto IL_2365;
								}
								case 79:
									goto end_IL_1085;
									IL_027f:
									num4 = num9;
									continue;
									IL_1f4d:
									hashSet2 = new HashSet<string>();
									list4 = (from s in list.Where(nYUPtTncpLTTeP3lORg.Q2unjn5s7Xy)
										orderby (string)L1CKQvnjysYct0mwdUU4.WCGR4lNirWLu7tVehBPd(s)
										select s).ToList();
									enumerator = list4.GetEnumerator();
									try
									{
										while (true)
										{
											int num17;
											if (enumerator.MoveNext())
											{
												current9 = enumerator.Current;
												num17 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
												{
													num17 = 1;
												}
											}
											else
											{
												num17 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
												{
													num17 = 0;
												}
											}
											switch (num17)
											{
											case 1:
												if (!hashSet2.Contains(current9.Currency))
												{
													hashSet2.Add((string)QSdJaw4LAKBLdZE84TTH(current9));
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
									}
									goto case 31;
									IL_2365:
									if (t7Wto9FMbOhxvJPJoJ3.Children.Any())
									{
										t7Wto9FMbOhxvJPJoJ28.Children.Add(t7Wto9FMbOhxvJPJoJ3);
									}
									break;
									end_IL_0283:
									break;
								}
								break;
								IL_0b3a:
								if (num6 == 2769128249u)
								{
									if (!(text == (string)f0ct0p4LZFQhw8kdIeLM(-448941864 ^ -448930746)))
									{
										break;
									}
									goto IL_2ee8;
								}
								if (num6 != 2770757464u)
								{
									break;
								}
								goto IL_3b6b;
								IL_3d0f:
								if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047146177)))
								{
									break;
								}
								goto IL_2ee8;
								IL_3b6b:
								if (BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962663325)))
								{
									t7Wto9FMbOhxvJPJoJ4 obj11 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2
									};
									DBWsLL4LCho5WPbxbywX(obj11, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C14A9));
									t7Wto9FMbOhxvJPJoJ21 = obj11;
									num4 = 23;
								}
								else
								{
									num4 = 63;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
									{
										num4 = 19;
									}
								}
								continue;
								IL_2ee8:
								t7Wto9FMbOhxvJPJoJ4 obj12 = new t7Wto9FMbOhxvJPJoJ4
								{
									Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2
								};
								DBWsLL4LCho5WPbxbywX(obj12, f0ct0p4LZFQhw8kdIeLM(-1009517961 ^ -1009543185));
								t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ71 = obj12;
								t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ71);
								enumerator3 = (from s in list.Where(nYUPtTncpLTTeP3lORg.f8onjHerQvr)
									orderby s.Name
									select s).GetEnumerator();
								try
								{
									while (enumerator3.MoveNext())
									{
										Symbol current28 = enumerator3.Current;
										int num45 = 1;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
										{
											num45 = 1;
										}
										while (true)
										{
											switch (num45)
											{
											case 1:
											{
												t7Wto9FMbOhxvJPJoJ4 obj13 = new t7Wto9FMbOhxvJPJoJ4
												{
													Name = current28.Name
												};
												DBWsLL4LCho5WPbxbywX(obj13, f0ct0p4LZFQhw8kdIeLM(-203064540 ^ -203090274));
												obj13.UTPFUh7JhO((string)delPg94LwvSL747LoogP(current28));
												obj13.IsExpanded = true;
												t7Wto9FMbOhxvJPJoJ4 item24 = obj13;
												t7Wto9FMbOhxvJPJoJ71.Children.Add(item24);
												num45 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
												{
													num45 = 0;
												}
												continue;
											}
											}
											break;
										}
									}
								}
								finally
								{
									enumerator3?.Dispose();
								}
								break;
								IL_1972:
								t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ72 = new t7Wto9FMbOhxvJPJoJ4();
								B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ72, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583318900));
								DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ72, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746EB9A9));
								t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ73 = t7Wto9FMbOhxvJPJoJ72;
								t7Wto9FMbOhxvJPJoJ31.Children.Add(t7Wto9FMbOhxvJPJoJ73);
								synFSKIMWU(list, t7Wto9FMbOhxvJPJoJ73, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
								break;
								IL_360b:
								if (!(text == (string)f0ct0p4LZFQhw8kdIeLM(0x7D553BE0 ^ 0x7D55048C)))
								{
									break;
								}
								goto IL_2ee8;
								IL_315f:
								if (text == (string)f0ct0p4LZFQhw8kdIeLM(0xB15786A ^ 0xB151526))
								{
									t7Wto9FMbOhxvJPJoJ27 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2,
										Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D315951)
									};
									t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ27);
									num4 = 11;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
									{
										num4 = 19;
									}
								}
								else
								{
									num4 = 94;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
									{
										num4 = 6;
									}
								}
								continue;
								IL_2572:
								if (num6 != 4147010490u)
								{
									num4 = 68;
									continue;
								}
								if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73574C69)))
								{
									break;
								}
								goto IL_38b1;
								IL_38b1:
								t7Wto9FMbOhxvJPJoJ4 obj14 = new t7Wto9FMbOhxvJPJoJ4
								{
									Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2
								};
								DBWsLL4LCho5WPbxbywX(obj14, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108554748));
								t7Wto9FMbOhxvJPJoJ50 = obj14;
								num4 = 28;
								continue;
								IL_1140:
								if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD5651A)))
								{
									break;
								}
								goto IL_38b1;
								IL_3236:
								if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04707C)))
								{
									break;
								}
								goto IL_2ee8;
								IL_3c64:
								if (num6 > 1945420267)
								{
									if (num6 != 1976993578)
									{
										if (num6 == 2020397624 && text == (string)f0ct0p4LZFQhw8kdIeLM(0x11D1040B ^ 0x11D15C0D))
										{
											goto IL_38b1;
										}
										break;
									}
									if (BALt4G4LVbEH3jOlZfUw(text, f0ct0p4LZFQhw8kdIeLM(0x16AD7E76 ^ 0x16AD1328)))
									{
										t7Wto9FMbOhxvJPJoJ69 = new t7Wto9FMbOhxvJPJoJ4
										{
											Name = nYUPtTncpLTTeP3lORg.I6QnjbQBRK2,
											Path = (string)f0ct0p4LZFQhw8kdIeLM(0x130FEA25 ^ 0x130F87BD)
										};
										num4 = 98;
										continue;
									}
									break;
								}
								num4 = 55;
								continue;
								IL_2e4b:
								t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ74 = new t7Wto9FMbOhxvJPJoJ4();
								B4snr04LqjMn8PI5vrvt(t7Wto9FMbOhxvJPJoJ74, nYUPtTncpLTTeP3lORg.I6QnjbQBRK2);
								DBWsLL4LCho5WPbxbywX(t7Wto9FMbOhxvJPJoJ74, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673707303));
								t7Wto9FMbOhxvJPJoJ31 = t7Wto9FMbOhxvJPJoJ74;
								t7Wto9FMbOhxvJPJoJ.Children.Add(t7Wto9FMbOhxvJPJoJ31);
								source3 = list.Where(nYUPtTncpLTTeP3lORg.jOcnjvIKTAn).ToList();
								if (source3.Any())
								{
									t7Wto9FMbOhxvJPJoJ30 = new t7Wto9FMbOhxvJPJoJ4
									{
										Name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181349210),
										Path = (string)f0ct0p4LZFQhw8kdIeLM(0x2BD86B18 ^ 0x2BD806B4)
									};
									num4 = 56;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
									{
										num4 = 36;
									}
									continue;
								}
								goto IL_1972;
								IL_3284:
								if (num6 <= 207070566)
								{
									if (num6 != 62387165)
									{
										if (num6 != 121984828)
										{
											num4 = 2;
											continue;
										}
										goto IL_3d0f;
									}
									if (!BALt4G4LVbEH3jOlZfUw(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127444586)))
									{
										break;
									}
									goto IL_2e4b;
								}
								if (num6 != 433752978)
								{
									num4 = 104;
									continue;
								}
								if (!BALt4G4LVbEH3jOlZfUw(text, f0ct0p4LZFQhw8kdIeLM(0x746ED405 ^ 0x746E8C1F)))
								{
									num4 = 14;
									continue;
								}
								goto IL_38b1;
							}
							continue;
							end_IL_1085:
							break;
						}
					}
					goto case 8;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = list.GetEnumerator();
			num = 3;
		}
	}

	private void synFSKIMWU(IList<Symbol> P_0, t7Wto9FMbOhxvJPJoJ4 P_1, string P_2)
	{
		NO0o1unQnFkDf0FFc3Vp CS_0024_003C_003E8__locals2 = new NO0o1unQnFkDf0FFc3Vp();
		CS_0024_003C_003E8__locals2.K81nQYdTF0s = P_2;
		List<IGrouping<string, Symbol>> list = (from s in P_0
			where (string)NO0o1unQnFkDf0FFc3Vp.qssRPlNi8J4Wp8RGfsFZ(s) == CS_0024_003C_003E8__locals2.K81nQYdTF0s && NO0o1unQnFkDf0FFc3Vp.PEDGqSNiAfNhHKiCwhAu(s) == SymbolType.Future
			group s by s.Currency into s
			orderby s.Key
			select s).ToList();
		if (list.Count == 0)
		{
			return;
		}
		if (list.Count == 1)
		{
			EhgFxSafgw(P_1, list.First());
		}
		foreach (IGrouping<string, Symbol> item in list)
		{
			t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ = new t7Wto9FMbOhxvJPJoJ4
			{
				Name = item.Key,
				Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999655848)
			};
			EhgFxSafgw(t7Wto9FMbOhxvJPJoJ, item);
			if (t7Wto9FMbOhxvJPJoJ.Children.Count != 0)
			{
				P_1.Children.Add(t7Wto9FMbOhxvJPJoJ);
			}
		}
	}

	private void EhgFxSafgw(t7Wto9FMbOhxvJPJoJ4 P_0, IEnumerable<Symbol> P_1)
	{
		foreach (Symbol item2 in P_1.OrderBy((Symbol x) => x.Name))
		{
			if (!item2.IsMaster)
			{
				continue;
			}
			IEnumerable<Symbol> source = from symbol in item2.GetContracts()
				where !ljYFLbRetF(symbol)
				select symbol;
			if (!source.Any())
			{
				continue;
			}
			t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ = new t7Wto9FMbOhxvJPJoJ4();
			t7Wto9FMbOhxvJPJoJ.Name = item2.Name;
			t7Wto9FMbOhxvJPJoJ.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F7642);
			t7Wto9FMbOhxvJPJoJ.UTPFUh7JhO(item2.ID);
			t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ2 = t7Wto9FMbOhxvJPJoJ;
			P_0.Children.Add(t7Wto9FMbOhxvJPJoJ2);
			foreach (Symbol item3 in source.OrderBy((Symbol c) => c.Name))
			{
				t7Wto9FMbOhxvJPJoJ4 t7Wto9FMbOhxvJPJoJ3 = new t7Wto9FMbOhxvJPJoJ4();
				t7Wto9FMbOhxvJPJoJ3.Name = item3.Name;
				t7Wto9FMbOhxvJPJoJ3.Path = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527103498);
				t7Wto9FMbOhxvJPJoJ3.UTPFUh7JhO(item3.ID);
				t7Wto9FMbOhxvJPJoJ3.IsExpanded = true;
				t7Wto9FMbOhxvJPJoJ4 item = t7Wto9FMbOhxvJPJoJ3;
				t7Wto9FMbOhxvJPJoJ2.Children.Add(item);
			}
		}
	}

	private bool ljYFLbRetF(Symbol P_0)
	{
		if (P_0.Expiration < Tr4UV54LpEIdwa6Nq2Lm(P_0.Exchange))
		{
			return !DataManager.Player;
		}
		return false;
	}

	private void NIVFe2xGOT(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		Close();
	}

	private void gKiFsD3y7X(object P_0, RoutedEventArgs P_1)
	{
		bPkRD54LuJ5W8x3OUOVR(this);
	}

	public HashSet<string> wndFXboo63()
	{
		HashSet<string> result = new HashSet<string>();
		foreach (HHOU6AFPMb0k62giSmc item in UvfFRgGVv4.Children)
		{
			FheFcxXQlq(item, ref result);
		}
		return result;
	}

	private void FheFcxXQlq(HHOU6AFPMb0k62giSmc P_0, ref HashSet<string> P_1)
	{
		if (P_0 is t7Wto9FMbOhxvJPJoJ4 { IsChecked: var flag } t7Wto9FMbOhxvJPJoJ)
		{
			bool flag2 = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					P_1.Add(t7Wto9FMbOhxvJPJoJ.fPFFtV1CTc());
					break;
				default:
					if (flag == flag2)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
						{
							num = 3;
						}
						continue;
					}
					break;
				case 3:
					if (t7Wto9FMbOhxvJPJoJ.Path == (string)f0ct0p4LZFQhw8kdIeLM(-673683647 ^ -673707269) && !g0rTbO4LzwIeqa3Y9vGA(t7Wto9FMbOhxvJPJoJ.fPFFtV1CTc()))
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				break;
			}
		}
		IEnumerator<HHOU6AFPMb0k62giSmc> enumerator = P_0.Children.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				HHOU6AFPMb0k62giSmc current = enumerator.Current;
				FheFcxXQlq(current, ref P_1);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
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
			if (enumerator != null)
			{
				EA6VMq4Lh7Hyc5USMbh0(enumerator);
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!WtcF6OGgWv)
		{
			WtcF6OGgWv = true;
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710477126), UriKind.Relative);
			aXxQ5a4e06v6HGOPeJXl(this, uri);
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
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				WtcF6OGgWv = true;
				num2 = 4;
				break;
			case 1:
				switch (P_0)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					TreeListBoxSymbols = (TreeListBox)P_1;
					TreeListBoxSymbols.ItemExpanding += ktOF5mg5OE;
					return;
				case 3:
					ButtonCancel = (Button)P_1;
					ButtonCancel.Click += gKiFsD3y7X;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					ButtonOk = (Button)P_1;
					ButtonOk.Click += NIVFe2xGOT;
					num2 = 3;
					break;
				}
				break;
			case 4:
				return;
			case 3:
				return;
			}
		}
	}

	[CompilerGenerated]
	private bool RFxFjpaX3g(Symbol P_0)
	{
		return !ljYFLbRetF(P_0);
	}

	[CompilerGenerated]
	private bool sx0FEOP1PX(Symbol P_0)
	{
		return !ljYFLbRetF(P_0);
	}

	[CompilerGenerated]
	private bool vr5FQQJJPX(Symbol P_0)
	{
		return !ljYFLbRetF(P_0);
	}

	[CompilerGenerated]
	private bool EagFd8vV7H(Symbol P_0)
	{
		return !ljYFLbRetF(P_0);
	}

	[CompilerGenerated]
	private bool DeMFgRBaAG(Symbol P_0)
	{
		return !ljYFLbRetF(P_0);
	}

	static mNaFVDFkuRdVdpLCms5()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void nG9jKa4LOPqPBfvyUUyO()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void B4snr04LqjMn8PI5vrvt(object P_0, object P_1)
	{
		((HHOU6AFPMb0k62giSmc)P_0).Name = (string)P_1;
	}

	internal static void bZfbyK4LImHg1JVKgjhO(object P_0, object P_1)
	{
		((TreeListBox)P_0).RootItem = P_1;
	}

	internal static bool UG9X0m4L6GoNABUIEeN6()
	{
		return K2RDNY4LRD2xvEq7cKFd == null;
	}

	internal static mNaFVDFkuRdVdpLCms5 eynQ1p4LMRLPNvKZeydx()
	{
		return K2RDNY4LRD2xvEq7cKFd;
	}

	internal static object SiaMWX4LW6XegvgfqV3w(object P_0)
	{
		return ((TreeListBoxItemEventArgs)P_0).Item;
	}

	internal static int JZHGHU4LtpdKNI7m4kj0(object P_0)
	{
		return ((Collection<HHOU6AFPMb0k62giSmc>)P_0).Count;
	}

	internal static object yBg8lR4LUcQ5aDpTS2vg()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool Yc1ZIk4LTEG5jWjue3LK(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).HideDisconnectedSymbols;
	}

	internal static AppTradeMode tltSLj4LyOjlutJICkv5(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TradeMode;
	}

	internal static object f0ct0p4LZFQhw8kdIeLM(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool BALt4G4LVbEH3jOlZfUw(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void DBWsLL4LCho5WPbxbywX(object P_0, object P_1)
	{
		((t7Wto9FMbOhxvJPJoJ4)P_0).Path = (string)P_1;
	}

	internal static object bIITL14LrEMmS6o2UfXU(object P_0)
	{
		return ((Symbol)P_0).Name;
	}

	internal static void Mdhv0A4LKtjaTQ7nouVq(object P_0, object P_1)
	{
		((t7Wto9FMbOhxvJPJoJ4)P_0).UTPFUh7JhO((string)P_1);
	}

	internal static bool B3AUtk4LmR6vx6nnvdFK(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void EA6VMq4Lh7Hyc5USMbh0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object delPg94LwvSL747LoogP(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static bool KjEZOi4L7L5tiXgAC78e(object P_0)
	{
		return ((Symbol)P_0).IsMaster;
	}

	internal static void PJyj2j4L82PboVgykDYE(object P_0, bool P_1)
	{
		((HHOU6AFPMb0k62giSmc)P_0).IsExpanded = P_1;
	}

	internal static object QSdJaw4LAKBLdZE84TTH(object P_0)
	{
		return ((Symbol)P_0).Currency;
	}

	internal static aK6fJ1vBqhWwwCm6KEi5 jQb29i4LPLqccRLAq3Ri(object P_0)
	{
		return RDOac8vBZCoV47cZZyo3.zlrvBCOYB64((Symbol)P_0);
	}

	internal static SymbolType r4l1jg4LJlinXcPi7IF6(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static object H7xmAP4LFJHPvFsqyaHT(object P_0)
	{
		return ((Symbol)P_0).Code;
	}

	internal static bool rfHiJi4L31qZQ8MgGqHS(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static DateTime Tr4UV54LpEIdwa6Nq2Lm(object P_0)
	{
		return TimeHelper.GetCurrDate((string)P_0);
	}

	internal static void bPkRD54LuJ5W8x3OUOVR(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static bool g0rTbO4LzwIeqa3Y9vGA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void aXxQ5a4e06v6HGOPeJXl(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}
}
