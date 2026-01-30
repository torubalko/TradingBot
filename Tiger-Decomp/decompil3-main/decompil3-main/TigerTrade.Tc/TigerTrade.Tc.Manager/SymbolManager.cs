using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using EyD6NKGhRYBSlyBqPfrJ;
using fpjPLXGPacNJhTx1uJh2;
using K1GcsD5GTtMSlaiJI0Xh;
using lw70ZYGA0ikS64oTFfFl;
using ODirSkaXU8pcm7mx906e;
using rknQZnGPN5ryJDSSp6ls;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Properties;
using waDpctGJom9MvAveNXHq;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Manager;

public static class SymbolManager
{
	private class MWN0vdaMZjHbdHLs70FJ
	{
		public Symbol Symbol;

		public bool UVEaMVB25NN;

		internal static MWN0vdaMZjHbdHLs70FJ QBT79TxpQhAmMtic5rjx;

		public MWN0vdaMZjHbdHLs70FJ(Symbol P_0)
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Symbol = P_0;
		}

		static MWN0vdaMZjHbdHLs70FJ()
		{
			uAJ3iLxpRgHOhlcvCLSh();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool gPtdYPxpdL7Bb4c7IZ4J()
		{
			return QBT79TxpQhAmMtic5rjx == null;
		}

		internal static MWN0vdaMZjHbdHLs70FJ RrGQFbxpgL1fdeBXK1bf()
		{
			return QBT79TxpQhAmMtic5rjx;
		}

		internal static void uAJ3iLxpRgHOhlcvCLSh()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[CompilerGenerated]
	private sealed class aovBXsaMCX4y1vFDBpZG
	{
		public Symbol huAaMK6MKBF;

		private static aovBXsaMCX4y1vFDBpZG xOLsmCxp6b8IwPvCrMfc;

		public aovBXsaMCX4y1vFDBpZG()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal void AZiaMrTcw0j()
		{
			SymbolManager.SymbolUpdated?.Invoke(huAaMK6MKBF);
		}

		static aovBXsaMCX4y1vFDBpZG()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool g2kJFMxpMOY9sg1P9FbB()
		{
			return xOLsmCxp6b8IwPvCrMfc == null;
		}

		internal static aovBXsaMCX4y1vFDBpZG EiEQWrxpOLVFfPSsywoV()
		{
			return xOLsmCxp6b8IwPvCrMfc;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class vpLbB3aMmdKhEFjrslt7
	{
		public static readonly vpLbB3aMmdKhEFjrslt7 XjNaMzLCJRn;

		public static Func<string, Symbol> WtAaO0UMSIk;

		public static Func<Symbol, bool> d3JaO2xyR52;

		public static Func<Symbol, bool> vKTaOHfvS5F;

		public static Func<Symbol, string> nLSaOfFM47I;

		public static Func<Symbol, DateTime> zKmaO9agLl5;

		public static Func<Symbol, bool> iO1aOnrmStF;

		public static Func<Symbol, bool> YTLaOGRxg4i;

		public static Func<Symbol, string> JbyaOYrv5o3;

		public static Func<string, string> xncaOoQr9Tn;

		public static Func<string, string> LkCaOvQ1gpb;

		public static Func<MWN0vdaMZjHbdHLs70FJ, Symbol> DLHaOBr8GJI;

		internal static vpLbB3aMmdKhEFjrslt7 CeEb2txpqbw3kh64eEO4;

		static vpLbB3aMmdKhEFjrslt7()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			XjNaMzLCJRn = new vpLbB3aMmdKhEFjrslt7();
		}

		public vpLbB3aMmdKhEFjrslt7()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal Symbol dkCaMhS1RnP(string id)
		{
			if (!Symbols.TryGetValue(id, out var value))
			{
				return null;
			}
			return value;
		}

		internal bool Nt8aMw2EvRF(Symbol symbol)
		{
			return symbol != null;
		}

		internal bool cLOaM7HU84n(Symbol s)
		{
			return s.Type == SymbolType.Option;
		}

		internal string rGHaM8KlaXy(Symbol o)
		{
			return o.OptAsset;
		}

		internal DateTime ARkaMAGmna3(Symbol o)
		{
			return o.Expiration;
		}

		internal bool qLkaMPkDi76(Symbol w)
		{
			return w.IsCrypto;
		}

		internal bool S5YaMJEgWNm(Symbol s)
		{
			if (gLfUsCxptT9SNTxkYKn8(s.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-165474503 ^ -165419483)))
			{
				return s.Exchange != (string)XiWcj9xpUI2wLGKX3jcS(-1736566656 ^ -1736511368);
			}
			return false;
		}

		internal string zOWaMF6R41T(Symbol s)
		{
			return s.Exchange;
		}

		internal string CNjaM3JLYIv(string o)
		{
			return o;
		}

		internal string OfTaMpcJm1i(string e)
		{
			return e;
		}

		internal Symbol BZpaMut8qla(MWN0vdaMZjHbdHLs70FJ cp)
		{
			return cp.Symbol;
		}

		internal static bool UshSrcxpIapNNttGqlMb()
		{
			return CeEb2txpqbw3kh64eEO4 == null;
		}

		internal static vpLbB3aMmdKhEFjrslt7 Hxf2OoxpWytsDobSgY6Z()
		{
			return CeEb2txpqbw3kh64eEO4;
		}

		internal static bool gLfUsCxptT9SNTxkYKn8(object P_0, object P_1)
		{
			return (string)P_0 != (string)P_1;
		}

		internal static object XiWcj9xpUI2wLGKX3jcS(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class teTdwoaOarVWlAaMvdw9
	{
		public bool n9NaOl7icKW;

		public SymbolType xmfaO4pxjwC;

		public string GYGaODJ9y3X;

		internal static teTdwoaOarVWlAaMvdw9 eC8lOJxpT8b2soh5ChWO;

		public teTdwoaOarVWlAaMvdw9()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool NyCaOix6BdS(Symbol s)
		{
			if ((n9NaOl7icKW ? (y8sp4KxpVnV9uaiYmxs8(s) != xmfaO4pxjwC) : (s.Type == xmfaO4pxjwC)) && fjKrkOxpChEDHkjU7UaE(s.Code, GYGaODJ9y3X))
			{
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => !vExuMNxprvLkhq9c3Mum(s), 
				};
			}
			return false;
		}

		static teTdwoaOarVWlAaMvdw9()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool bUOCKnxpy8HodAIiqLSY()
		{
			return eC8lOJxpT8b2soh5ChWO == null;
		}

		internal static teTdwoaOarVWlAaMvdw9 MpMKlixpZ6N3p8IuhZuI()
		{
			return eC8lOJxpT8b2soh5ChWO;
		}

		internal static SymbolType y8sp4KxpVnV9uaiYmxs8(object P_0)
		{
			return ((Symbol)P_0).Type;
		}

		internal static bool fjKrkOxpChEDHkjU7UaE(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool vExuMNxprvLkhq9c3Mum(object P_0)
		{
			return ((Symbol)P_0).IsDeleted;
		}
	}

	[CompilerGenerated]
	private sealed class Vg3H5waObtXJ7kgkNcmL
	{
		public Symbol UlkaOkeMEAV;

		private static Vg3H5waObtXJ7kgkNcmL eG9x2YxpKnwNC7HsLjYJ;

		public Vg3H5waObtXJ7kgkNcmL()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool LrlaON9B6a9(zExvlHGPbQsZv9T8F5T0 f)
		{
			return S8YP2Expwos1bR5uHocJ(f) == UlkaOkeMEAV.Type;
		}

		static Vg3H5waObtXJ7kgkNcmL()
		{
			xwNDMNxp7RAfTHaNqncw();
			w8Bktqxp8biJeYc8MPQA();
		}

		internal static bool MQuPWVxpmVc2sEqAb8Us()
		{
			return eG9x2YxpKnwNC7HsLjYJ == null;
		}

		internal static Vg3H5waObtXJ7kgkNcmL zBehpyxphhLUyZ6qSM0x()
		{
			return eG9x2YxpKnwNC7HsLjYJ;
		}

		internal static SymbolType S8YP2Expwos1bR5uHocJ(object P_0)
		{
			return ((zExvlHGPbQsZv9T8F5T0)P_0).Type;
		}

		internal static void xwNDMNxp7RAfTHaNqncw()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void w8Bktqxp8biJeYc8MPQA()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[CompilerGenerated]
	private sealed class eyiCasaO1GP5bbye8nMe
	{
		public string tRSaOSFeptF;

		private static eyiCasaO1GP5bbye8nMe kgOWU0xpA8xaUrnSPjTv;

		public eyiCasaO1GP5bbye8nMe()
		{
			kpelcuxpFMthQToEBFJj();
			base._002Ector();
		}

		internal bool I3naO5c5gvu(Symbol s)
		{
			return s.Name.Equals(tRSaOSFeptF);
		}

		static eyiCasaO1GP5bbye8nMe()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void kpelcuxpFMthQToEBFJj()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool AiU5nKxpPtk1GSLi9IZU()
		{
			return kgOWU0xpA8xaUrnSPjTv == null;
		}

		internal static eyiCasaO1GP5bbye8nMe xAOhv8xpJmiaN1kDapgU()
		{
			return kgOWU0xpA8xaUrnSPjTv;
		}
	}

	[CompilerGenerated]
	private sealed class UdbcUuaOxiQXNjrqojab
	{
		public Symbol iERaOetnD3l;

		internal static UdbcUuaOxiQXNjrqojab w9YhBexp3AFeArBvwSoZ;

		public UdbcUuaOxiQXNjrqojab()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool p3baOLIX1Vo(string exch)
		{
			return exch == iERaOetnD3l.Exchange;
		}

		static UdbcUuaOxiQXNjrqojab()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool u2sbDSxppgXZMeyofIEk()
		{
			return w9YhBexp3AFeArBvwSoZ == null;
		}

		internal static UdbcUuaOxiQXNjrqojab XtRN4ZxpurdtrQGkTH0k()
		{
			return w9YhBexp3AFeArBvwSoZ;
		}
	}

	[CompilerGenerated]
	private sealed class fNvoAgaOssBSEPKi0yaT
	{
		public string SjLaOE03EQ5;

		public Symbol COQaOQ9GRin;

		internal static fNvoAgaOssBSEPKi0yaT bO1Pprxpzb2I9E65gfbJ;

		public fNvoAgaOssBSEPKi0yaT()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool WQEaOXFrY47(Symbol s)
		{
			return fMKqZ1xuHaqT4TP8ZXks(s.Name, SjLaOE03EQ5);
		}

		internal MWN0vdaMZjHbdHLs70FJ Hd4aOcXJyGo(string e)
		{
			return new MWN0vdaMZjHbdHLs70FJ(COQaOQ9GRin);
		}

		internal bool I1paOjeaH8X(MWN0vdaMZjHbdHLs70FJ cp)
		{
			return cp.Symbol != COQaOQ9GRin;
		}

		static fNvoAgaOssBSEPKi0yaT()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool Qkco2Hxu04Y99ZT4aLt6()
		{
			return bO1Pprxpzb2I9E65gfbJ == null;
		}

		internal static fNvoAgaOssBSEPKi0yaT juftSjxu2VsAfYGM4kbl()
		{
			return bO1Pprxpzb2I9E65gfbJ;
		}

		internal static bool fMKqZ1xuHaqT4TP8ZXks(object P_0, object P_1)
		{
			return ((string)P_0).Equals((string)P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct d6Q3kqaOdYp5cQnMqg4n
	{
		public Symbol Y3laOgqH6rh;
	}

	[CompilerGenerated]
	private sealed class geeZ8naORwjmFYtxxRt4 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
	{
		private int GrlaO6b6FN3;

		private string DeOaOMRrEae;

		private int ipWaOOeVwH3;

		private Symbol nIWaOqhKxNb;

		public Symbol JiJaOIc4MR8;

		private bool X1raOWbnKOI;

		public bool LUyaOtnSNmO;

		private bool VOeaOUms8C9;

		public bool tcdaOTtgxjC;

		private d6Q3kqaOdYp5cQnMqg4n IyVaOyPgxYG;

		private HashSet<string> kcvaOZs013H;

		private string[] BB4aOV7OwoS;

		private int DLXaOCP3kqr;

		private static geeZ8naORwjmFYtxxRt4 YlaeNUxuGOQ9gdigUYMQ;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return DeOaOMRrEae;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return DeOaOMRrEae;
			}
		}

		[DebuggerHidden]
		public geeZ8naORwjmFYtxxRt4(int _003C_003E1__state)
		{
			DUhEg2xuvvKnMfcT0imm();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			GrlaO6b6FN3 = _003C_003E1__state;
			ipWaOOeVwH3 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (GrlaO6b6FN3)
			{
			case 2:
				break;
			case 0:
				goto IL_0287;
			case 1:
				goto IL_0295;
			default:
				goto IL_03e1;
			}
			GrlaO6b6FN3 = -1;
			int num = 12;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
			{
				num = 8;
			}
			goto IL_0009;
			IL_0287:
			GrlaO6b6FN3 = -1;
			IyVaOyPgxYG.Y3laOgqH6rh = nIWaOqhKxNb;
			int num2 = 14;
			num = num2;
			goto IL_0009;
			IL_0295:
			GrlaO6b6FN3 = -1;
			goto IL_0323;
			IL_0009:
			string item2 = default(string);
			string item = default(string);
			string text2 = default(string);
			string text = default(string);
			string text3 = default(string);
			while (true)
			{
				switch (num)
				{
				case 14:
					kcvaOZs013H = null;
					if (X1raOWbnKOI & VOeaOUms8C9)
					{
						kcvaOZs013H = JLFqEJGJYiHaSdoROJXI.aFKGJBIwWtd();
						num = 5;
						continue;
					}
					goto case 5;
				case 15:
					if (kcvaOZs013H.Contains(item2))
					{
						num = 10;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
						{
							num = 6;
						}
						continue;
					}
					goto case 12;
				case 18:
					if (!vm6G5dxu4TsYUSGC3KNO(IyVaOyPgxYG.Y3laOgqH6rh))
					{
						num = 17;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
						{
							num = 10;
						}
						continue;
					}
					goto case 12;
				default:
					return true;
				case 3:
					if (VOeaOUms8C9)
					{
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
						{
							num = 2;
						}
						continue;
					}
					goto IL_00c7;
				case 6:
					GrlaO6b6FN3 = 1;
					num = 11;
					continue;
				case 13:
					if (DLXaOCP3kqr < BB4aOV7OwoS.Length)
					{
						num = 9;
						continue;
					}
					BB4aOV7OwoS = null;
					return false;
				case 12:
					DLXaOCP3kqr++;
					num = 13;
					continue;
				case 16:
					return false;
				case 11:
					return true;
				case 1:
					if (X1raOWbnKOI)
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
						{
							num = 1;
						}
						continue;
					}
					goto IL_00c7;
				case 7:
					return false;
				case 2:
					if (!kcvaOZs013H.Contains(item))
					{
						break;
					}
					goto IL_00c7;
				case 5:
					text2 = (string)((!IyVaOyPgxYG.Y3laOgqH6rh.IsBinance) ? IyVaOyPgxYG.Y3laOgqH6rh.Exchange : (rKcEl1xuBcdPnIk1LUOH(IyVaOyPgxYG.Y3laOgqH6rh) ? YlOichxualN6DgHtseVI(-5977659 ^ -6023453) : YlOichxualN6DgHtseVI(0xAD5B8B3 ^ 0xAD551AF)));
					item = GetExchangeWithType(text2, ref IyVaOyPgxYG);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
					{
						num = 1;
					}
					continue;
				case 4:
				case 9:
					text = BB4aOV7OwoS[DLXaOCP3kqr];
					if (text == (string)NAFHaOxuii4Av0GOw1A7(IyVaOyPgxYG.Y3laOgqH6rh))
					{
						goto case 12;
					}
					if (GJZjQ1xulRk9fau7karv(text, AutoSwitchExchanges[0]))
					{
						num = 18;
						continue;
					}
					goto case 17;
				case 17:
					text3 = ((!(text == AutoSwitchExchanges[0])) ? text : (rKcEl1xuBcdPnIk1LUOH(IyVaOyPgxYG.Y3laOgqH6rh) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-671204305 ^ -671161591) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1999650146 ^ -1999688830)));
					item2 = GetExchangeWithType(text3, ref IyVaOyPgxYG);
					if (X1raOWbnKOI)
					{
						goto case 15;
					}
					goto case 10;
				case 8:
					DLXaOCP3kqr = 0;
					goto case 13;
				case 10:
					{
						DeOaOMRrEae = text3;
						GrlaO6b6FN3 = 2;
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
						{
							num = 0;
						}
						continue;
					}
					IL_00c7:
					DeOaOMRrEae = text2;
					num = 6;
					continue;
				}
				break;
			}
			goto IL_0323;
			IL_0323:
			if (VOeaOUms8C9)
			{
				BB4aOV7OwoS = AutoSwitchExchanges;
				num = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
				{
					num = 8;
				}
			}
			else
			{
				num = 7;
			}
			goto IL_0009;
			IL_03e1:
			num = 16;
			goto IL_0009;
			static string GetExchangeWithType(string exchange, ref d6Q3kqaOdYp5cQnMqg4n P_1)
			{
				if (!s5XKje5hL5Zd5QoYtaVY(exchange, LErUR15mJwtSSy1OitMk(0x6AB40973 ^ 0x6AB4ED9B)))
				{
					return exchange;
				}
				if (!pdTj915h5Dy39eUKRG5J(P_1.Y3laOgqH6rh))
				{
					return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D1E085);
				}
				return (string)LErUR15mJwtSSy1OitMk(0x5CD4F15 ^ 0x5CDAB67);
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			geeZ8naORwjmFYtxxRt4 geeZ8naORwjmFYtxxRt;
			if (GrlaO6b6FN3 == -2 && ipWaOOeVwH3 == Environment.CurrentManagedThreadId)
			{
				GrlaO6b6FN3 = 0;
				geeZ8naORwjmFYtxxRt = this;
			}
			else
			{
				geeZ8naORwjmFYtxxRt = new geeZ8naORwjmFYtxxRt4(0);
			}
			geeZ8naORwjmFYtxxRt.nIWaOqhKxNb = JiJaOIc4MR8;
			geeZ8naORwjmFYtxxRt.VOeaOUms8C9 = tcdaOTtgxjC;
			geeZ8naORwjmFYtxxRt.X1raOWbnKOI = LUyaOtnSNmO;
			return geeZ8naORwjmFYtxxRt;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		static geeZ8naORwjmFYtxxRt4()
		{
			KqlE0qxuDihqqQv6P7sP();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void DUhEg2xuvvKnMfcT0imm()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool Kx7mqyxuYwhUKyTbKhqN()
		{
			return YlaeNUxuGOQ9gdigUYMQ == null;
		}

		internal static geeZ8naORwjmFYtxxRt4 BrEmd9xuoErFLhCYlnM4()
		{
			return YlaeNUxuGOQ9gdigUYMQ;
		}

		internal static bool rKcEl1xuBcdPnIk1LUOH(object P_0)
		{
			return ((Symbol)P_0).IsCryptoFuture;
		}

		internal static object YlOichxualN6DgHtseVI(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static object NAFHaOxuii4Av0GOw1A7(object P_0)
		{
			return ((SymbolBase)P_0).Exchange;
		}

		internal static bool GJZjQ1xulRk9fau7karv(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool vm6G5dxu4TsYUSGC3KNO(object P_0)
		{
			return ((Symbol)P_0).IsBinance;
		}

		internal static void KqlE0qxuDihqqQv6P7sP()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[CompilerGenerated]
	private sealed class YJvBbjaOrCRA5LG5Epc8 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
	{
		private int fEqaOKEgJpS;

		private string rhxaOmt0pMj;

		private int h5raOhM6cPX;

		private bool et4aOwsStFJ;

		public bool KATaO7bImNQ;

		private Symbol ulgaO8ZY0Ur;

		public Symbol FEIaOAJ7Yg7;

		private HashSet<string> RDjaOPFdMxI;

		private string[] S9DaOJhHvSP;

		private int O32aOFdyYBK;

		private static YJvBbjaOrCRA5LG5Epc8 i16oFoxubOBbK8Xcu7uo;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return rhxaOmt0pMj;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return rhxaOmt0pMj;
			}
		}

		[DebuggerHidden]
		public YJvBbjaOrCRA5LG5Epc8(int _003C_003E1__state)
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
			fEqaOKEgJpS = _003C_003E1__state;
			h5raOhM6cPX = Environment.CurrentManagedThreadId;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = 7;
			string text = default(string);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					string item;
					switch (num2)
					{
					case 12:
					case 14:
						text = S9DaOJhHvSP[O32aOFdyYBK];
						num2 = 13;
						continue;
					case 8:
						O32aOFdyYBK = 0;
						num = 3;
						break;
					case 13:
						if (ILF3cbxu1SxbS9YoOkh6(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x741B85CB ^ 0x741B5AED)))
						{
							text = (string)(ulgaO8ZY0Ur.IsCryptoFuture ? ntZimwxu5BX3oeP3C7qA(-1736566656 ^ -1736511076) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB15A74C));
						}
						if (text == ulgaO8ZY0Ur.Exchange)
						{
							goto case 5;
						}
						if (text == (string)ntZimwxu5BX3oeP3C7qA(-962524685 ^ -962466533))
						{
							if (!ulgaO8ZY0Ur.IsCryptoFuture)
							{
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
								{
									num2 = 2;
								}
								continue;
							}
							obj = ntZimwxu5BX3oeP3C7qA(-1325234765 ^ -1325244099);
						}
						else
						{
							obj = text;
						}
						goto IL_034e;
					case 9:
						rhxaOmt0pMj = text;
						fEqaOKEgJpS = 1;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						RDjaOPFdMxI = JLFqEJGJYiHaSdoROJXI.aFKGJBIwWtd();
						num2 = 8;
						continue;
					case 6:
						switch (num3)
						{
						default:
							return false;
						case 0:
							fEqaOKEgJpS = -1;
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
							{
								num2 = 0;
							}
							break;
						case 1:
							fEqaOKEgJpS = -1;
							num2 = 5;
							break;
						}
						continue;
					case 7:
						num3 = fEqaOKEgJpS;
						num2 = 6;
						continue;
					case 10:
						S9DaOJhHvSP = AutoSwitchExchanges;
						if (et4aOwsStFJ)
						{
							num = 4;
							break;
						}
						goto case 8;
					case 5:
						O32aOFdyYBK++;
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
						{
							num2 = 11;
						}
						continue;
					case 2:
						obj = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-991861155 ^ -991854033);
						goto IL_034e;
					case 3:
					case 11:
						if (O32aOFdyYBK >= S9DaOJhHvSP.Length)
						{
							return false;
						}
						num2 = 14;
						continue;
					case 1:
						RDjaOPFdMxI = null;
						num2 = 10;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 != 0)
						{
							num2 = 3;
						}
						continue;
					default:
						{
							return true;
						}
						IL_034e:
						item = (string)obj;
						if (!et4aOwsStFJ)
						{
							goto case 9;
						}
						if (RDjaOPFdMxI.Contains(item))
						{
							num2 = 9;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 5;
					}
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			YJvBbjaOrCRA5LG5Epc8 yJvBbjaOrCRA5LG5Epc;
			if (fEqaOKEgJpS == -2 && h5raOhM6cPX == Environment.CurrentManagedThreadId)
			{
				fEqaOKEgJpS = 0;
				yJvBbjaOrCRA5LG5Epc = this;
			}
			else
			{
				yJvBbjaOrCRA5LG5Epc = new YJvBbjaOrCRA5LG5Epc8(0);
			}
			yJvBbjaOrCRA5LG5Epc.ulgaO8ZY0Ur = FEIaOAJ7Yg7;
			yJvBbjaOrCRA5LG5Epc.et4aOwsStFJ = KATaO7bImNQ;
			return yJvBbjaOrCRA5LG5Epc;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		static YJvBbjaOrCRA5LG5Epc8()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			J565TvxuSVBrEQhCLrdo();
		}

		internal static bool t7Q8OLxuNmjeRoAPrso3()
		{
			return i16oFoxubOBbK8Xcu7uo == null;
		}

		internal static YJvBbjaOrCRA5LG5Epc8 RPCEOFxukynjq7JvM0Iv()
		{
			return i16oFoxubOBbK8Xcu7uo;
		}

		internal static bool ILF3cbxu1SxbS9YoOkh6(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static object ntZimwxu5BX3oeP3C7qA(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static void J565TvxuSVBrEQhCLrdo()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[CompilerGenerated]
	private static Action m_FavoritesReady;

	[CompilerGenerated]
	private static Action m_BunchOfOptionsUpdated;

	private static readonly Dictionary<string, Symbol> Symbols;

	private static readonly string[] AutoSwitchExchanges;

	private static readonly object Locker;

	private static bool _updated;

	private static List<Symbol> _symbolsList;

	private static readonly k9p9plGPBaJKBGQLlurk SymbolMap;

	private static readonly qwN1XxG8zBbBXaPblFVi LinkSymbolMap;

	private static bool _initialLoadCompleted;

	private static bool _inInitialLoad;

	private static readonly List<zExvlHGPbQsZv9T8F5T0> Types;

	private static SymbolManager o4jqCh5mqP7sVbkxKkvc;

	public static DateTime ClientSpecLastUpdate { get; set; }

	public static event Action FavoritesReady
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			Action action2 = default(Action);
			Action action = default(Action);
			Action value2 = default(Action);
			while (true)
			{
				switch (num2)
				{
				default:
					action2 = action;
					value2 = (Action)Delegate.Combine(action2, value);
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					action = Interlocked.CompareExchange(ref SymbolManager.m_FavoritesReady, value2, action2);
					if ((object)action == action2)
					{
						return;
					}
					goto default;
				case 1:
					action = SymbolManager.m_FavoritesReady;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			Action action = default(Action);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					action = SymbolManager.m_FavoritesReady;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 1:
					break;
				}
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref SymbolManager.m_FavoritesReady, value2, action2);
				}
				while ((object)action != action2);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public static event Action<Symbol> SymbolUpdated;

	public static event Action BunchOfOptionsUpdated
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			Action action2 = default(Action);
			Action action = default(Action);
			Action value2 = default(Action);
			while (true)
			{
				switch (num2)
				{
				default:
					action2 = action;
					value2 = (Action)Delegate.Combine(action2, value);
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					action = Interlocked.CompareExchange(ref SymbolManager.m_BunchOfOptionsUpdated, value2, action2);
					if ((object)action == action2)
					{
						return;
					}
					goto default;
				case 1:
					action = SymbolManager.m_BunchOfOptionsUpdated;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			Action action2 = default(Action);
			Action action = default(Action);
			while (true)
			{
				switch (num2)
				{
				case 2:
					action2 = SymbolManager.m_BunchOfOptionsUpdated;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
				{
					Action value2 = (Action)ihwH4Y5mtABDXgmnbLra(action, value);
					action2 = Interlocked.CompareExchange(ref SymbolManager.m_BunchOfOptionsUpdated, value2, action);
					if ((object)action2 == action)
					{
						return;
					}
					break;
				}
				case 1:
					break;
				}
				action = action2;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public static int GetDepthLimit(string symbolId)
	{
		if (Acj0FgGhg83F5A0lfPa4.gXQGwnDx4da() != null)
		{
			if (!Acj0FgGhg83F5A0lfPa4.gXQGwnDx4da().TryGetValue(symbolId, out var value))
			{
				return 0;
			}
			return value;
		}
		return 0;
	}

	public static void LoadOrUpdate(byte[] data, DateTime utcSpecChangedTime, bool isSpecUpdate = false)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		BinaryReader binaryReader = default(BinaryReader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 1:
				if (data != null)
				{
					if (data.Length != 0)
					{
						using MemoryStream memoryStream = new MemoryStream();
						using MemoryStream stream = new MemoryStream(data);
						using GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress);
						SGpKWL5mUbOE7W4IfFS0(gZipStream, memoryStream);
						memoryStream.Position = 0L;
						int num3;
						if (!_initialLoadCompleted)
						{
							num3 = 3;
							goto IL_0059;
						}
						int num4 = 0;
						goto IL_016d;
						IL_016d:
						flag = (byte)num4 != 0;
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
						{
							num3 = 1;
						}
						goto IL_0059;
						IL_0059:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 1:
								_inInitialLoad = flag;
								binaryReader = new BinaryReader(memoryStream);
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								try
								{
									ReadSymbolsData(utcSpecChangedTime, binaryReader, isSpecUpdate);
								}
								finally
								{
									if (binaryReader != null)
									{
										((IDisposable)binaryReader).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
								}
								if (flag)
								{
									num3 = 2;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto IL_0133;
							case 2:
								{
									_initialLoadCompleted = true;
									goto IL_0133;
								}
								IL_0133:
								_inInitialLoad = false;
								return;
							}
							break;
						}
						num4 = ((!isSpecUpdate) ? 1 : 0);
						goto IL_016d;
					}
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	private static void ReadSymbolsData(DateTime utcSpecChangedTime, BinaryReader reader, bool isSpecUpdate)
	{
		bool flag = false;
		Action bunchOfOptionsUpdated;
		string id = default(string);
		SymbolType symbolType = default(SymbolType);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		int num12 = default(int);
		double num8 = default(double);
		double num9 = default(double);
		int num10 = default(int);
		double num11 = default(double);
		int num5 = default(int);
		int pnlPrecision = default(int);
		string text = default(string);
		string description = default(string);
		string mapping = default(string);
		bool isDeleted = default(bool);
		double num13 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		Hashtable additionalData = default(Hashtable);
		Symbol symbol3 = default(Symbol);
		int num3 = default(int);
		Symbol symbol2 = default(Symbol);
		Symbol symbol = default(Symbol);
		int num4 = default(int);
		int num15 = default(int);
		double num2 = default(double);
		int num14 = default(int);
		while (true)
		{
			int num;
			if (dBEnc65hniO4ScW586XQ(reader.BaseStream) >= ((Stream)CRowwO5hGeKmWKoEfZJJ(reader)).Length - 1)
			{
				if (flag)
				{
					bunchOfOptionsUpdated = SymbolManager.BunchOfOptionsUpdated;
					if (bunchOfOptionsUpdated != null)
					{
						break;
					}
					num = 16;
					goto IL_0009;
				}
				return;
			}
			goto IL_0356;
			IL_0009:
			while (true)
			{
				int num23;
				object obj;
				Symbol obj2;
				Symbol obj5;
				switch (num)
				{
				case 7:
				{
					Symbol symbol5 = new Symbol(id, symbolType);
					I82E4J5mCl5XQCXygFyt(symbol5, text2);
					symbol5.Currency = text3;
					VOa8AC5mruSrpGl16LRS(symbol5, text4);
					symbol5.LotSize = num12;
					symbol5.PointValue = num8;
					symbol5.Step = num9;
					symbol5.Precision = num10;
					symbol5.SizeStep = num11;
					symbol5.SizePrecision = num5;
					symbol5.PnlPrecision = pnlPrecision;
					symbol5.Name = text;
					symbol5.Description = description;
					symbol5.Mapping = mapping;
					symbol5.IsDeleted = isDeleted;
					symbol5.LotStep = num13;
					symbol5.MinQty = num6;
					symbol5.MinNotional = num7;
					symbol5.AdditionalData = additionalData;
					AddOrUpdate(symbol5, isSpecUpdate);
					num = 24;
					continue;
				}
				case 5:
					num10 = rrlqPZ5mTkVU0bGG2Obd(reader);
					num11 = reader.ReadDouble();
					num = 8;
					continue;
				case 22:
					AddOrUpdate(symbol3, isSpecUpdate);
					num23 = 6;
					goto IL_0005;
				default:
					mapping = (string)MX7UNb5myTRiSI8hrycs(reader);
					isDeleted = GRvDs55mZfAoW92GcSib(reader);
					num13 = reader.ReadDouble();
					num = 18;
					continue;
				case 24:
					goto end_IL_0009;
				case 11:
					switch (symbolType)
					{
					case SymbolType.Index:
					case SymbolType.Stock:
					case SymbolType.Currency:
					case SymbolType.Crypto:
					case SymbolType.Forex:
						break;
					default:
						goto end_IL_0009;
					case SymbolType.Option:
						goto IL_040f;
					case SymbolType.Future:
						goto IL_056f;
					}
					goto case 7;
				case 6:
					num3 = reader.ReadInt32();
					num = 10;
					continue;
				case 26:
					num12 = reader.ReadInt32();
					num8 = reader.ReadDouble();
					num9 = reader.ReadDouble();
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
					{
						num = 0;
					}
					continue;
				case 4:
					FireSymbolUpdatedEvent(symbol3);
					goto end_IL_0009;
				case 17:
					break;
				case 1:
					CVhl3F5h0ZyqMR12d3Dg(symbol2, symbol);
					num23 = 19;
					goto IL_0005;
				case 20:
					if (num4 >= num3)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 12:
					obj = null;
					goto IL_063f;
				case 10:
					num4 = 0;
					num23 = 20;
					goto IL_0005;
				case 23:
					text4 = reader.ReadString();
					num = 26;
					continue;
				case 15:
					if (GW5Bk65mzbXHEVEbvKZN(symbol2) == SymbolType.Future)
					{
						num = 13;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
						{
							num = 12;
						}
						continue;
					}
					goto case 1;
				case 25:
					num15++;
					goto IL_0561;
				case 18:
					num6 = WLMWmP5mVKZ7M35iqgmA(reader);
					num7 = reader.ReadDouble();
					if (!reader.ReadBoolean())
					{
						num = 12;
						continue;
					}
					obj = TWc2meaXtaO97TKI70iG.r9SaXTLt3K8(reader);
					goto IL_063f;
				case 19:
					AddOrUpdate(symbol, isSpecUpdate);
					num = 25;
					continue;
				case 2:
					text2 = (string)MX7UNb5myTRiSI8hrycs(reader);
					text3 = reader.ReadString();
					num = 23;
					continue;
				case 21:
					text = (string)MX7UNb5myTRiSI8hrycs(reader);
					description = reader.ReadString();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
					{
						num = 0;
					}
					continue;
				case 8:
					num5 = rrlqPZ5mTkVU0bGG2Obd(reader);
					pnlPrecision = reader.ReadInt32();
					num = 21;
					continue;
				case 14:
					num4++;
					goto case 20;
				case 13:
					symbol.ContractValue = num2;
					symbol.NeedHistoryCorrect = true;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 != 0)
					{
						num = 1;
					}
					continue;
				case 9:
				{
					object id2 = MX7UNb5myTRiSI8hrycs(reader);
					string code = (string)MX7UNb5myTRiSI8hrycs(reader);
					string name = (string)MX7UNb5myTRiSI8hrycs(reader);
					long ticks = reader.ReadInt64();
					long ticks2 = jEcu4L5m8Uc40gsHF7yb(reader);
					string mapping2 = (string)MX7UNb5myTRiSI8hrycs(reader);
					bool value = GRvDs55mZfAoW92GcSib(reader);
					double num16 = reader.ReadDouble();
					double num17 = WLMWmP5mVKZ7M35iqgmA(reader);
					double num18 = reader.ReadDouble();
					Hashtable hashtable = (Hashtable)(reader.ReadBoolean() ? EbdEld5mAioCIUwYkf1e(reader) : null);
					int num19 = reader.ReadInt32();
					double num20 = WLMWmP5mVKZ7M35iqgmA(reader);
					num2 = reader.ReadDouble();
					int num21 = rrlqPZ5mTkVU0bGG2Obd(reader);
					double num22 = reader.ReadDouble();
					string description2 = reader.ReadString();
					double value2 = ((hashtable != null && xKjQ9p5mPXSCHeZocJfL(hashtable, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338810230))) ? ((double)VKNb5m5mFRtqKYqkTUq2(hashtable, LErUR15mJwtSSy1OitMk(-2017337494 ^ -2017379114))) : 1.0);
					bool flag2 = OFZBjy5m3vfVdiWEHfZX(symbol2);
					Symbol obj3 = new Symbol((string)id2, symbol2, new DateTime(ticks), new DateTime(ticks2))
					{
						Code = code,
						Name = name,
						Mapping = mapping2
					};
					yUBBXO5mpeUcClHBEwwU(obj3, value);
					obj3.LotStep = ((num16 != 0.0 || flag2) ? num16 : num13);
					obj3.MinQty = ((num17 != 0.0 || flag2) ? num17 : num6);
					obj3.MinNotional = ((num18 != 0.0 || flag2) ? num18 : num7);
					obj3.AdditionalData = hashtable;
					obj3.LotSize = ((num19 != 0 || flag2) ? num19 : num12);
					obj3.Step = ((num20 != 0.0 || flag2) ? num20 : num9);
					obj3.SizeStep = ((num2 != 0.0 || flag2) ? num2 : num11);
					obj3.Precision = ((num21 != 0 || flag2) ? num21 : num10);
					obj3.PointValue = ((num22 != 0.0 || flag2) ? num22 : num8);
					obj3.Description = description2;
					zfFJot5muFqywqe5htfC(obj3, value2);
					symbol = obj3;
					symbol.ContractValue = ((symbol.AdditionalData != null && symbol.AdditionalData.ContainsKey(LErUR15mJwtSSy1OitMk(-671204305 ^ -671162477))) ? ((double)symbol.AdditionalData[LErUR15mJwtSSy1OitMk(0x735715F1 ^ 0x7357F64D)]) : 1.0);
					if (symbol2.IsGateIo)
					{
						num = 15;
						continue;
					}
					goto case 1;
				}
				case 3:
				{
					string id3 = reader.ReadString();
					string code2 = reader.ReadString();
					string longCode = reader.ReadString();
					string optAsset = reader.ReadString();
					long ticks3 = reader.ReadInt64();
					int optType = rrlqPZ5mTkVU0bGG2Obd(reader);
					double optStrike = WLMWmP5mVKZ7M35iqgmA(reader);
					string text5 = reader.ReadString();
					string description3 = reader.ReadString();
					string mapping3 = reader.ReadString();
					double pointValue = reader.ReadDouble();
					double step = reader.ReadDouble();
					int precision = reader.ReadInt32();
					bool isDeleted2 = reader.ReadBoolean();
					Hashtable additionalData2 = (GRvDs55mZfAoW92GcSib(reader) ? TWc2meaXtaO97TKI70iG.r9SaXTLt3K8(reader) : null);
					Symbol obj4 = new Symbol(id3, symbol3, new DateTime(ticks3), new DateTime(ticks3))
					{
						Code = code2,
						LongCode = longCode,
						OptAsset = optAsset,
						OptType = (SymbolOptType)optType,
						OptStrike = optStrike
					};
					R7YMko5mhD2DgjEkPAV3(obj4, text5);
					obj4.Description = description3;
					obj4.Mapping = mapping3;
					obj4.PointValue = pointValue;
					obj4.Step = step;
					obj4.Precision = precision;
					obj4.IsDeleted = isDeleted2;
					obj4.AdditionalData = additionalData2;
					Symbol symbol4 = obj4;
					symbol3.AddStrike(symbol4);
					AddOrUpdate(symbol4, isSpecUpdate);
					num = 14;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
					{
						num = 1;
					}
					continue;
				}
				case 16:
					return;
					IL_056f:
					obj2 = new Symbol(id, symbolType)
					{
						Code = text2,
						Currency = text3,
						Exchange = text4,
						PointValue = num8,
						Step = num9
					};
					AjPmxb5mKUVNyIbG2ZHQ(obj2, num10);
					oYPYbs5mmKit45JKtfA8(obj2, num11);
					obj2.SizePrecision = num5;
					obj2.PnlPrecision = pnlPrecision;
					R7YMko5mhD2DgjEkPAV3(obj2, text);
					obj2.Description = description;
					obj2.Mapping = mapping;
					obj2.IsDeleted = isDeleted;
					YHpKjC5mwGcFZ9dxbZgQ(obj2, num12);
					obj2.LotStep = num13;
					ycnUaH5m7bHjJnUuvF37(obj2, num6);
					obj2.MinNotional = num7;
					obj2.AdditionalData = additionalData;
					symbol2 = obj2;
					AddOrUpdate(symbol2, isSpecUpdate: false);
					num14 = rrlqPZ5mTkVU0bGG2Obd(reader);
					num15 = 0;
					goto IL_0561;
					IL_0561:
					if (num15 >= num14)
					{
						symbol2.UpdateCurrentContract(TimeHelper.GetCurrDate(symbol2.Exchange));
						goto end_IL_0009;
					}
					goto case 9;
					IL_063f:
					additionalData = (Hashtable)obj;
					num23 = 11;
					goto IL_0005;
					IL_0005:
					num = num23;
					continue;
					IL_040f:
					flag = true;
					obj5 = new Symbol(id, symbolType)
					{
						Code = text2
					};
					DGtyTy5h2RS1wcnbdevP(obj5, text3);
					obj5.Exchange = text4;
					fhpvi45hHARMk3XS7Fjb(obj5, num8);
					WFFt6E5hfYJwwopmNmm2(obj5, num9);
					AjPmxb5mKUVNyIbG2ZHQ(obj5, num10);
					obj5.SizeStep = num11;
					CnK6Ju5h9as1aLENPEre(obj5, num5);
					obj5.PnlPrecision = pnlPrecision;
					obj5.Name = text;
					obj5.Description = description;
					obj5.Mapping = mapping;
					obj5.IsDeleted = isDeleted;
					obj5.AdditionalData = additionalData;
					symbol3 = obj5;
					num = 22;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
					{
						num = 20;
					}
					continue;
				}
				goto IL_0356;
				continue;
				end_IL_0009:
				break;
			}
			ClientSpecLastUpdate = utcSpecChangedTime;
			continue;
			IL_0356:
			symbolType = (SymbolType)rrlqPZ5mTkVU0bGG2Obd(reader);
			id = (string)MX7UNb5myTRiSI8hrycs(reader);
			num = 2;
			goto IL_0009;
		}
		o02Zey5hY5ZLf5XMoVTh(bunchOfOptionsUpdated);
	}

	public static void UpdateCryptoSymbols(DateTime utcSpecChangedTime, IList<Symbol> cryptoSymbols)
	{
		foreach (Symbol cryptoSymbol in cryptoSymbols)
		{
			if (cryptoSymbol.Type == SymbolType.Crypto)
			{
				AddOrUpdate(cryptoSymbol, isSpecUpdate: true, isRefreshSymbols: true);
			}
			ClientSpecLastUpdate = utcSpecChangedTime;
		}
	}

	public static void FireSymbolUpdatedEvent(Symbol symbol)
	{
		aovBXsaMCX4y1vFDBpZG aovBXsaMCX4y1vFDBpZG = new aovBXsaMCX4y1vFDBpZG();
		aovBXsaMCX4y1vFDBpZG.huAaMK6MKBF = symbol;
		Bjtt8t5horfgORd11Y9Q((Action)delegate
		{
			SymbolManager.SymbolUpdated?.Invoke(aovBXsaMCX4y1vFDBpZG.huAaMK6MKBF);
		});
	}

	private static void AddOrUpdate(Symbol symbol, bool isSpecUpdate, bool isRefreshSymbols = false)
	{
		object locker = Locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				int num2 = 9;
				Symbol value2 = default(Symbol);
				while (true)
				{
					double value;
					switch (num2)
					{
					case 7:
						Qmgiui5h4wAOTbrgRQkr(symbol);
						goto case 10;
					case 3:
						Symbols.Add(symbol.ID, symbol);
						SymbolMap.qnAGPiOC6Ps(symbol);
						if (isSpecUpdate)
						{
							goto case 11;
						}
						if (!_inInitialLoad)
						{
							num2 = 4;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
							{
								num2 = 11;
							}
							continue;
						}
						goto case 10;
					case 11:
						LogManager.WriteInfo((string)ojrl4J5hlVVkDynT8imH(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380566944), symbol.ID));
						num2 = 6;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
						{
							num2 = 7;
						}
						continue;
					case 2:
						if (!value2.UpdateFields(symbol))
						{
							num2 = 10;
							continue;
						}
						goto case 12;
					case 9:
						if (Acj0FgGhg83F5A0lfPa4.BBMGwgfPKSv() && OFZBjy5m3vfVdiWEHfZX(symbol))
						{
							return;
						}
						if ((SGLoUs5hv20984bdpYeh(symbol) || symbol.IsOkxX) && symbol.Type == SymbolType.Future)
						{
							num2 = 4;
							continue;
						}
						goto IL_0123;
					case 10:
						_updated = true;
						return;
					case 8:
						symbol.NeedHistoryCorrect = true;
						goto IL_0123;
					case 4:
						if (symbol.ContractValue > 1000.0)
						{
							num2 = 8;
							continue;
						}
						goto IL_0123;
					case 5:
						symbol.ContractValue = symbol.MinQty;
						value = ((symbol.SizeStep < 1.0) ? BX1FoA5haKjNOP0LqI0s(symbol) : 1.0);
						break;
					case 6:
						if (symbol.IsBitget)
						{
							fhpvi45hHARMk3XS7Fjb(symbol, 1.0);
							MUUVKd5hiEZRG6pqdi00(symbol, symbol.SizeStep);
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 1;
					case 1:
						if (!Symbols.TryGetValue(symbol.ID, out value2))
						{
							num2 = 3;
							continue;
						}
						goto default;
					case 12:
						FireSymbolUpdatedEvent(value2);
						goto case 10;
					default:
						{
							if (isRefreshSymbols)
							{
								return;
							}
							goto case 2;
						}
						IL_0123:
						if (aijhCx5hB86b3AqFv6VM(symbol) && symbol.IsCryptoFuture)
						{
							num2 = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 6;
					}
					oYPYbs5mmKit45JKtfA8(symbol, value);
					num2 = 6;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(locker);
				}
			}
		}
	}

	public static Symbol Get(string id)
	{
		object locker = Locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				if (RnCUGV5hDvNDtihpfy82(id))
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 1:
						goto IL_008b;
					}
					goto IL_003c;
				}
				goto IL_008b;
				IL_008b:
				if (!Symbols.ContainsKey(id))
				{
					goto IL_003c;
				}
				object result = Symbols[id];
				goto IL_00ab;
				IL_003c:
				result = null;
				goto IL_00ab;
				IL_00ab:
				return (Symbol)result;
			}
			finally
			{
				if (lockTaken)
				{
					tmv8Cw5hbof8FS1KYXZm(locker);
				}
			}
		}
	}

	public static Symbol[] Get(params string[] ids)
	{
		int num = 1;
		int num2 = num;
		object locker = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				locker = Locker;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				Symbol value;
				return (from id in ids
					select (!Symbols.TryGetValue(id, out value)) ? null : value into symbol
					where symbol != null
					select symbol).ToArray();
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(locker);
				}
			}
		}
	}

	internal static Symbol Get(string id, string code, string codeClass = "")
	{
		object locker = Locker;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				int num2 = 2;
				object result;
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 1:
						result = null;
						break;
					case 2:
						text = SymbolMap.I1IGPlHmZK0(id, code, codeClass);
						if (!RnCUGV5hDvNDtihpfy82(text) && Symbols.ContainsKey(text))
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					default:
						result = Symbols[text];
						break;
					}
					break;
				}
				return (Symbol)result;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(locker);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
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
		}
	}

	internal static List<string> GetCodes(string id)
	{
		lock (Locker)
		{
			return SymbolMap.B80GP4hx40J(id);
		}
	}

	internal static Symbol Get(SymbolType type, string code, bool ignoreType)
	{
		int num = 3;
		int num2 = num;
		object locker = default(object);
		bool lockTaken = default(bool);
		teTdwoaOarVWlAaMvdw9 teTdwoaOarVWlAaMvdw = default(teTdwoaOarVWlAaMvdw9);
		while (true)
		{
			switch (num2)
			{
			case 1:
				locker = Locker;
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				teTdwoaOarVWlAaMvdw.n9NaOl7icKW = ignoreType;
				teTdwoaOarVWlAaMvdw.xmfaO4pxjwC = type;
				teTdwoaOarVWlAaMvdw.GYGaODJ9y3X = code;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				teTdwoaOarVWlAaMvdw = new teTdwoaOarVWlAaMvdw9();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
				{
					num2 = 2;
				}
				continue;
			}
			try
			{
				Monitor.Enter(locker, ref lockTaken);
				return Symbols.Values.FirstOrDefault(teTdwoaOarVWlAaMvdw.NyCaOix6BdS);
			}
			finally
			{
				if (lockTaken)
				{
					tmv8Cw5hbof8FS1KYXZm(locker);
				}
			}
		}
	}

	public static List<Symbol> GetAll()
	{
		lock (Locker)
		{
			if (_updated || _symbolsList == null)
			{
				_symbolsList = Symbols.Values.ToList();
				_updated = false;
			}
			return _symbolsList;
		}
	}

	public static bool AreExchangesRelated(string exchange1, string exchange2)
	{
		if (RnCUGV5hDvNDtihpfy82(exchange1) || RnCUGV5hDvNDtihpfy82(exchange2))
		{
			return false;
		}
		if (exchange1 == exchange2)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => true, 
			};
		}
		bool num2 = Trd4es5hNP4n2ueUEoUC(exchange1, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F03C1B));
		bool flag = exchange2.StartsWith((string)LErUR15mJwtSSy1OitMk(0x3544E813 ^ 0x35443735));
		return num2 && flag;
	}

	public static Symbol FindSymbolOnExchangeWithRelated(Symbol symbol, string targetExchange, SymbolType? targetType = null, Func<Symbol, bool> isExcludeSymbol = null)
	{
		if (symbol == null || string.IsNullOrEmpty(targetExchange))
		{
			return null;
		}
		string baseCurrency = symbol.GetBaseCurrency(excludeMultiplier: true);
		string currency = symbol.Currency;
		string text = symbol.Name.Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962627829), "");
		lock (Locker)
		{
			List<Symbol> all = GetAll();
			Symbol symbol2 = null;
			Symbol symbol3 = null;
			foreach (Symbol item in all)
			{
				if ((targetType.HasValue && item.Type != targetType.Value) || !item.IsLinkable || (isExcludeSymbol != null && isExcludeSymbol(item)) || (item.Exchange != targetExchange && !AreExchangesRelated(item.Exchange, targetExchange)))
				{
					continue;
				}
				if (symbol2 == null && (item.Name == symbol.Name || item.Name.Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD55B49), "") == text))
				{
					symbol2 = item;
					if (item.Exchange == targetExchange)
					{
						return symbol2;
					}
				}
				if (symbol3 == null && baseCurrency != null && currency != null && item.GetBaseCurrency(excludeMultiplier: true) == baseCurrency && item.Currency == currency)
				{
					symbol3 = item;
					if (item.Exchange == targetExchange && symbol2 == null)
					{
						return symbol3;
					}
				}
			}
			return symbol2 ?? symbol3;
		}
	}

	public static List<Symbol> GetAllOptions()
	{
		lock (Locker)
		{
			return (from o in Symbols.Values
				where o.Type == SymbolType.Option
				orderby o.OptAsset, o.Expiration
				select o).ToList();
		}
	}

	public static IEnumerable<string> GetAllExchange(bool isCrypto = false)
	{
		lock (Locker)
		{
			IEnumerable<Symbol> source;
			if (!isCrypto)
			{
				IEnumerable<Symbol> all = GetAll();
				source = all;
			}
			else
			{
				source = from w in GetAll()
					where w.IsCrypto
					select w;
			}
			return (from o in (from s in source
					where vpLbB3aMmdKhEFjrslt7.gLfUsCxptT9SNTxkYKn8(s.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-165474503 ^ -165419483)) && s.Exchange != (string)vpLbB3aMmdKhEFjrslt7.XiWcj9xpUI2wLGKX3jcS(-1736566656 ^ -1736511368)
					select s.Exchange).Distinct()
				orderby o
				select o).ToList();
		}
	}

	public static string GetNameDomTemplate(Symbol symbol, bool isIndividual = false)
	{
		Vg3H5waObtXJ7kgkNcmL CS_0024_003C_003E8__locals4 = new Vg3H5waObtXJ7kgkNcmL();
		CS_0024_003C_003E8__locals4.UlkaOkeMEAV = symbol;
		if (CS_0024_003C_003E8__locals4.UlkaOkeMEAV == null)
		{
			return (string)LErUR15mJwtSSy1OitMk(-894902996 ^ -894944980);
		}
		string text = CS_0024_003C_003E8__locals4.UlkaOkeMEAV.Exchange;
		int num = 3;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
		{
			num = 2;
		}
		object obj;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!b1BxiI5hkviE5nNtXngv(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--134855371 ^ 0x80965ED)))
				{
					num = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 2;
			case 2:
				text = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461930794);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
				{
					num = 0;
				}
				continue;
			default:
			{
				zExvlHGPbQsZv9T8F5T0 zExvlHGPbQsZv9T8F5T = Types.FirstOrDefault((zExvlHGPbQsZv9T8F5T0 f) => Vg3H5waObtXJ7kgkNcmL.S8YP2Expwos1bR5uHocJ(f) == CS_0024_003C_003E8__locals4.UlkaOkeMEAV.Type);
				if (zExvlHGPbQsZv9T8F5T == null)
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
					{
						num = 1;
					}
					continue;
				}
				obj = zExvlHGPbQsZv9T8F5T.ShortName;
				break;
			}
			case 1:
				obj = null;
				break;
			}
			break;
		}
		string text2 = (string)obj;
		if (!isIndividual)
		{
			return text2 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1763895751 ^ -1763838951) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2123795572 ^ -2123786344);
		}
		return text2 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2123795572 ^ -2123787860) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28B345BB ^ 0x28B3A19B);
	}

	public static string GetNameLotsTemplate(Symbol symbol)
	{
		if (symbol == null)
		{
			return string.Empty;
		}
		string text = symbol.Exchange;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return (string)eShF0H5h1X4BWyGH5KUp((symbol.Type == SymbolType.Future) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461292091 ^ -1461282921) : LErUR15mJwtSSy1OitMk(--871424829 ^ 0x33F0077F), LErUR15mJwtSSy1OitMk(-377195341 ^ -377188143), text);
			default:
				if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7FAC6D)))
				{
					text = (string)LErUR15mJwtSSy1OitMk(0x7DB10E6E ^ 0x7DB1D148);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public static IEnumerable<zExvlHGPbQsZv9T8F5T0> GetAllTypes()
	{
		return Types;
	}

	public static void Clear()
	{
		object locker = Locker;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(locker, ref lockTaken);
			Symbols.Clear();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			SymbolMap.Clear();
			_updated = true;
		}
		finally
		{
			if (lockTaken)
			{
				tmv8Cw5hbof8FS1KYXZm(locker);
			}
		}
	}

	public static void RiseFavoritesReady()
	{
		SymbolManager.FavoritesReady?.Invoke();
	}

	public static Symbol FindSwitchPair(Symbol symbol, Func<Symbol, bool> isExcludeSymbol, bool hideDisconnectedSymbols, bool autoSwitchExchangeMode)
	{
		eyiCasaO1GP5bbye8nMe CS_0024_003C_003E8__locals15 = new eyiCasaO1GP5bbye8nMe();
		if (symbol == null || !symbol.IsLinkable || !LinkSymbolMap.MrnGA2KjbvT(symbol))
		{
			return null;
		}
		string currency = symbol.Currency;
		string baseCurrency = symbol.GetBaseCurrency(excludeMultiplier: true);
		string baseCurrency2 = symbol.GetBaseCurrency();
		List<Symbol> all = GetAll();
		SymbolType symbolType = ((symbol.Type == SymbolType.Future) ? SymbolType.Crypto : SymbolType.Future);
		CS_0024_003C_003E8__locals15.tRSaOSFeptF = LinkSymbolMap.wCVGAHKZ5i9(symbol);
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals15.tRSaOSFeptF))
		{
			Symbol symbol2 = all.FirstOrDefault((Symbol s) => s.Name.Equals(CS_0024_003C_003E8__locals15.tRSaOSFeptF));
			if (symbol2 != null)
			{
				currency = symbol2.Currency;
				baseCurrency = symbol2.GetBaseCurrency(excludeMultiplier: true);
				baseCurrency2 = symbol2.GetBaseCurrency();
			}
		}
		new List<Symbol>();
		string[] array = GetAnotherTypeExchanges(symbol, autoSwitchExchangeMode, hideDisconnectedSymbols).ToArray();
		int num = int.MaxValue;
		Symbol result = null;
		bool flag = false;
		for (int num2 = 0; num2 < all.Count; num2++)
		{
			UdbcUuaOxiQXNjrqojab CS_0024_003C_003E8__locals16 = new UdbcUuaOxiQXNjrqojab();
			CS_0024_003C_003E8__locals16.iERaOetnD3l = all[num2];
			if (CS_0024_003C_003E8__locals16.iERaOetnD3l.Type != symbolType)
			{
				continue;
			}
			int num3 = Array.FindIndex(array, (string exch) => exch == CS_0024_003C_003E8__locals16.iERaOetnD3l.Exchange);
			if (num3 < 0 || num3 > num)
			{
				continue;
			}
			string baseCurrency3 = CS_0024_003C_003E8__locals16.iERaOetnD3l.GetBaseCurrency();
			bool flag2 = baseCurrency3 == baseCurrency2;
			bool flag3 = false;
			if (!flag2)
			{
				string baseCurrency4 = CS_0024_003C_003E8__locals16.iERaOetnD3l.GetBaseCurrency(excludeMultiplier: true);
				flag3 = ((symbolType == SymbolType.Future) ? (baseCurrency4 == baseCurrency2) : (baseCurrency3 == baseCurrency));
			}
			if ((flag2 || flag3) && CS_0024_003C_003E8__locals16.iERaOetnD3l.IsLinkable && CS_0024_003C_003E8__locals16.iERaOetnD3l.Currency == currency && !isExcludeSymbol(CS_0024_003C_003E8__locals16.iERaOetnD3l) && LinkSymbolMap.MrnGA2KjbvT(CS_0024_003C_003E8__locals16.iERaOetnD3l) && (!flag2 || !IsFixedTermCryptoFut(CS_0024_003C_003E8__locals16.iERaOetnD3l)))
			{
				if (num3 == 0 && flag2)
				{
					return CS_0024_003C_003E8__locals16.iERaOetnD3l;
				}
				if (num3 < num || (num3 == num && !flag && flag2) || (num3 == num && !flag && !flag2))
				{
					num = num3;
					result = CS_0024_003C_003E8__locals16.iERaOetnD3l;
					flag = flag2;
				}
			}
		}
		return result;
	}

	private static bool IsFixedTermCryptoFut(Symbol s)
	{
		if (!pdTj915h5Dy39eUKRG5J(s))
		{
			return false;
		}
		DateTime expiration = s.Expiration;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => expiration.Year < 2100, 
		};
	}

	public static List<Symbol> FindSwitchSymbols(Symbol symbol, Func<Symbol, bool> isExcludeSymbol, bool hideDisconnectedSymbols)
	{
		fNvoAgaOssBSEPKi0yaT CS_0024_003C_003E8__locals15 = new fNvoAgaOssBSEPKi0yaT();
		CS_0024_003C_003E8__locals15.COQaOQ9GRin = symbol;
		if (CS_0024_003C_003E8__locals15.COQaOQ9GRin == null || !CS_0024_003C_003E8__locals15.COQaOQ9GRin.IsLinkable || !LinkSymbolMap.MrnGA2KjbvT(CS_0024_003C_003E8__locals15.COQaOQ9GRin))
		{
			return null;
		}
		string currency = CS_0024_003C_003E8__locals15.COQaOQ9GRin.Currency;
		string baseCurrency = CS_0024_003C_003E8__locals15.COQaOQ9GRin.GetBaseCurrency(excludeMultiplier: true);
		string baseCurrency2 = CS_0024_003C_003E8__locals15.COQaOQ9GRin.GetBaseCurrency();
		List<Symbol> all = GetAll();
		CS_0024_003C_003E8__locals15.SjLaOE03EQ5 = LinkSymbolMap.wCVGAHKZ5i9(CS_0024_003C_003E8__locals15.COQaOQ9GRin);
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals15.SjLaOE03EQ5))
		{
			Symbol symbol2 = all.FirstOrDefault((Symbol s) => fNvoAgaOssBSEPKi0yaT.fMKqZ1xuHaqT4TP8ZXks(s.Name, CS_0024_003C_003E8__locals15.SjLaOE03EQ5));
			if (symbol2 != null)
			{
				currency = symbol2.Currency;
				baseCurrency = symbol2.GetBaseCurrency(excludeMultiplier: true);
				baseCurrency2 = symbol2.GetBaseCurrency();
			}
		}
		new List<Symbol>();
		Dictionary<string, MWN0vdaMZjHbdHLs70FJ> dictionary = GetSameTypeExchanges(CS_0024_003C_003E8__locals15.COQaOQ9GRin, hideDisconnectedSymbols).ToDictionary((string e) => e, (string e) => new MWN0vdaMZjHbdHLs70FJ(CS_0024_003C_003E8__locals15.COQaOQ9GRin));
		foreach (Symbol item in all)
		{
			if (item.Type != CS_0024_003C_003E8__locals15.COQaOQ9GRin.Type || !dictionary.TryGetValue(item.Exchange, out var value) || value.UVEaMVB25NN || !item.IsLinkable || !(item.Currency == currency) || isExcludeSymbol(item) || !LinkSymbolMap.MrnGA2KjbvT(item))
			{
				continue;
			}
			if (item.GetBaseCurrency() == baseCurrency2)
			{
				if (!IsFixedTermCryptoFut(item))
				{
					value.Symbol = item;
					value.UVEaMVB25NN = true;
				}
			}
			else if (item.GetBaseCurrency(excludeMultiplier: true) == baseCurrency)
			{
				value.Symbol = item;
			}
		}
		return (from cp in dictionary.Values
			where cp.Symbol != CS_0024_003C_003E8__locals15.COQaOQ9GRin
			select cp.Symbol).ToList();
	}

	public static bool IsCryptoSymbolConnected(Symbol symbol)
	{
		int num = 1;
		int num2 = num;
		string item = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				return JLFqEJGJYiHaSdoROJXI.aFKGJBIwWtd().Contains(item);
			case 1:
				if (!symbol.IsGateIo)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = (pdTj915h5Dy39eUKRG5J(symbol) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-57768881 ^ -57777983) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074085322));
				break;
			default:
				obj = symbol.Exchange;
				break;
			}
			item = (string)obj;
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
			{
				num2 = 2;
			}
		}
	}

	[IteratorStateMachine(typeof(geeZ8naORwjmFYtxxRt4))]
	private static IEnumerable<string> GetAnotherTypeExchanges(Symbol symbol, bool autoSwitchExchangeMode, bool hideDisconnectedSymbols)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new geeZ8naORwjmFYtxxRt4(-2)
		{
			JiJaOIc4MR8 = symbol,
			tcdaOTtgxjC = autoSwitchExchangeMode,
			LUyaOtnSNmO = hideDisconnectedSymbols
		};
	}

	[IteratorStateMachine(typeof(YJvBbjaOrCRA5LG5Epc8))]
	private static IEnumerable<string> GetSameTypeExchanges(Symbol symbol, bool hideDisconnectedSymbols)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new YJvBbjaOrCRA5LG5Epc8(-2)
		{
			FEIaOAJ7Yg7 = symbol,
			KATaO7bImNQ = hideDisconnectedSymbols
		};
	}

	static SymbolManager()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					AutoSwitchExchanges = new string[11]
					{
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841444993),
						(string)LErUR15mJwtSSy1OitMk(0x315AB1E3 ^ 0x315A5363),
						(string)LErUR15mJwtSSy1OitMk(-1774602229 ^ -1774622925),
						(string)LErUR15mJwtSSy1OitMk(-82860344 ^ -82886024),
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4297C3EB ^ 0x4297273B),
						(string)LErUR15mJwtSSy1OitMk(0x6AB40973 ^ 0x6AB4AA41),
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x34407BB ^ 0x344E353),
						(string)LErUR15mJwtSSy1OitMk(0x7F55E538 ^ 0x7F55467A),
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380550490),
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA81BD0),
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3544E813 ^ 0x35440D19)
					};
					Locker = new object();
					SymbolMap = new k9p9plGPBaJKBGQLlurk();
					LinkSymbolMap = new qwN1XxG8zBbBXaPblFVi();
					Types = new List<zExvlHGPbQsZv9T8F5T0>
					{
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeAll, SymbolType.Unknown),
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeSpot, SymbolType.Crypto),
						new zExvlHGPbQsZv9T8F5T0((string)qG1Fqw5hSpAfMpcYl6Nw(), SymbolType.Future),
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeStock, SymbolType.Stock),
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeForex, SymbolType.Forex),
						new zExvlHGPbQsZv9T8F5T0((string)uf7SR05hx4xaSDIVIefk(), SymbolType.Index),
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeOption, SymbolType.Option),
						new zExvlHGPbQsZv9T8F5T0(Resources.SymbolsTypeCurrency, SymbolType.Currency)
					};
					return;
				case 3:
					F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			Symbols = new Dictionary<string, Symbol>();
			num = 4;
		}
	}

	internal static bool L91swE5mIbarpV98PP22()
	{
		return o4jqCh5mqP7sVbkxKkvc == null;
	}

	internal static SymbolManager sNoKZo5mWTylye6paHHj()
	{
		return o4jqCh5mqP7sVbkxKkvc;
	}

	internal static object ihwH4Y5mtABDXgmnbLra(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void SGpKWL5mUbOE7W4IfFS0(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static int rrlqPZ5mTkVU0bGG2Obd(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	internal static object MX7UNb5myTRiSI8hrycs(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	internal static bool GRvDs55mZfAoW92GcSib(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	internal static double WLMWmP5mVKZ7M35iqgmA(object P_0)
	{
		return ((BinaryReader)P_0).ReadDouble();
	}

	internal static void I82E4J5mCl5XQCXygFyt(object P_0, object P_1)
	{
		((Symbol)P_0).Code = (string)P_1;
	}

	internal static void VOa8AC5mruSrpGl16LRS(object P_0, object P_1)
	{
		((SymbolBase)P_0).Exchange = (string)P_1;
	}

	internal static void AjPmxb5mKUVNyIbG2ZHQ(object P_0, int value)
	{
		((Symbol)P_0).Precision = value;
	}

	internal static void oYPYbs5mmKit45JKtfA8(object P_0, double value)
	{
		((SymbolBase)P_0).SizeStep = value;
	}

	internal static void R7YMko5mhD2DgjEkPAV3(object P_0, object P_1)
	{
		((Symbol)P_0).Name = (string)P_1;
	}

	internal static void YHpKjC5mwGcFZ9dxbZgQ(object P_0, int value)
	{
		((Symbol)P_0).LotSize = value;
	}

	internal static void ycnUaH5m7bHjJnUuvF37(object P_0, double value)
	{
		((Symbol)P_0).MinQty = value;
	}

	internal static long jEcu4L5m8Uc40gsHF7yb(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}

	internal static object EbdEld5mAioCIUwYkf1e(object P_0)
	{
		return TWc2meaXtaO97TKI70iG.r9SaXTLt3K8((BinaryReader)P_0);
	}

	internal static bool xKjQ9p5mPXSCHeZocJfL(object P_0, object P_1)
	{
		return ((Hashtable)P_0).ContainsKey(P_1);
	}

	internal static object LErUR15mJwtSSy1OitMk(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object VKNb5m5mFRtqKYqkTUq2(object P_0, object P_1)
	{
		return ((Hashtable)P_0)[P_1];
	}

	internal static bool OFZBjy5m3vfVdiWEHfZX(object P_0)
	{
		return ((Symbol)P_0).IsCrypto;
	}

	internal static void yUBBXO5mpeUcClHBEwwU(object P_0, bool value)
	{
		((Symbol)P_0).IsDeleted = value;
	}

	internal static void zfFJot5muFqywqe5htfC(object P_0, double value)
	{
		((SymbolBase)P_0).ContractValue = value;
	}

	internal static SymbolType GW5Bk65mzbXHEVEbvKZN(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static void CVhl3F5h0ZyqMR12d3Dg(object P_0, object P_1)
	{
		((Symbol)P_0).AddContract((Symbol)P_1);
	}

	internal static void DGtyTy5h2RS1wcnbdevP(object P_0, object P_1)
	{
		((Symbol)P_0).Currency = (string)P_1;
	}

	internal static void fhpvi45hHARMk3XS7Fjb(object P_0, double value)
	{
		((Symbol)P_0).PointValue = value;
	}

	internal static void WFFt6E5hfYJwwopmNmm2(object P_0, double value)
	{
		((SymbolBase)P_0).Step = value;
	}

	internal static void CnK6Ju5h9as1aLENPEre(object P_0, int value)
	{
		((Symbol)P_0).SizePrecision = value;
	}

	internal static long dBEnc65hniO4ScW586XQ(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static object CRowwO5hGeKmWKoEfZJJ(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static void o02Zey5hY5ZLf5XMoVTh(object P_0)
	{
		P_0();
	}

	internal static void Bjtt8t5horfgORd11Y9Q(object P_0)
	{
		DataManager.GuiAsync((Action)P_0);
	}

	internal static bool SGLoUs5hv20984bdpYeh(object P_0)
	{
		return ((Symbol)P_0).IsOKX;
	}

	internal static bool aijhCx5hB86b3AqFv6VM(object P_0)
	{
		return ((Symbol)P_0).IsGateIo;
	}

	internal static double BX1FoA5haKjNOP0LqI0s(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static void MUUVKd5hiEZRG6pqdi00(object P_0, double value)
	{
		((Symbol)P_0).LotStep = value;
	}

	internal static object ojrl4J5hlVVkDynT8imH(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void Qmgiui5h4wAOTbrgRQkr(object P_0)
	{
		FireSymbolUpdatedEvent((Symbol)P_0);
	}

	internal static bool RnCUGV5hDvNDtihpfy82(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void tmv8Cw5hbof8FS1KYXZm(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool Trd4es5hNP4n2ueUEoUC(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool b1BxiI5hkviE5nNtXngv(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object eShF0H5h1X4BWyGH5KUp(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool pdTj915h5Dy39eUKRG5J(object P_0)
	{
		return ((Symbol)P_0).IsCryptoFuture;
	}

	internal static object qG1Fqw5hSpAfMpcYl6Nw()
	{
		return Resources.SymbolsTypeFuture;
	}

	internal static object uf7SR05hx4xaSDIVIefk()
	{
		return Resources.SymbolsTypeIndex;
	}

	internal static bool s5XKje5hL5Zd5QoYtaVY(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
