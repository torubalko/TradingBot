using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using acmMvaGuskFRcnLr3b5U;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using BNBOZvajeQsiwHdpScOq;
using D9oCu3aEgyKPNPKmY7V8;
using G0m0LeY0yZvUaQA4Kqfc;
using hdxmyvY0GJLbsbDrtINk;
using hLNgjdadfJmAYwpjL3jr;
using HUGROmaQL20CgL29Z5vy;
using jhuDCPG8d8bbdl4R91vn;
using jSIOgkGu0P3Y4vrBGi9s;
using K1GcsD5GTtMSlaiJI0Xh;
using k56rXOGpHcZIas56ia8y;
using k7lvGwG7nsmvY8cRB5pp;
using lFFs11G39ohaRVknaFPC;
using LPq3llG3QX4HMCBL7b1Q;
using mSYjIBY5SCuicGLQpXrK;
using OhwR2LaxHYJ0lj0C9GSK;
using OWhORdGzgDWLWxLpUFfx;
using p9D0WNaxgVP5IJuowluK;
using qCQIuYGJryFOsEw3GPHq;
using QGBcuKoF6l1BCNnN4Xyj;
using r8oOHiajFPNBXu6XiAHj;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Collections;
using TigerTrade.Tc.Connectors.Simulator.Player;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using TigerTrade.Tc.Properties;
using tpDLBrGJAci5JWh2s4im;
using TpfAZxGpdyO6SBbUrRDP;
using U0vBVyGFnRQg4TAEWduY;
using UCPBeBajRMRrbWD7Bpen;
using UMI2GBGJ3kloSb47d3eV;
using uPAbnGG980DscR4DZEMf;
using UVhXm6Y0O4TJCA9neyIZ;
using WgpZwxGJT3LVlqrS4Ppx;
using x97CE55GhEYKgt7TSVZT;
using YwOHcaGh4KFYtOqgwQoU;
using zJnmCrGAyrNEB66VU5ww;
using zYk4HMY07vN4gSi3TYcE;

namespace TigerTrade.Tc.Manager;

public static class DataManager
{
	[CompilerGenerated]
	private sealed class UOc6OCaRRH6QuLSv4Smw
	{
		public Symbol LfDaRMk0JKn;

		internal static UOc6OCaRRH6QuLSv4Smw SOgsoMxFCL0pekJ2Kpev;

		public UOc6OCaRRH6QuLSv4Smw()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool VfnaR6QOE8l(AdVNpgG79ErxvcbgBD1J con)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (con.mWXlYwTb86e.MarketData)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					if (con.mWXlYwTb86e.IsConnected && !((ConnectionInfo)qKOGwjxFmTfq6vFpl3Mi(con)).Simulator)
					{
						return YYh5w3xFw3a3RJrkQsMA(q7jPWuxFhCPBVQK30oXj(con), LfDaRMk0JKn) != null;
					}
					break;
				}
				break;
			}
			return false;
		}

		static UOc6OCaRRH6QuLSv4Smw()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool FoeWxZxFrulExOF42AZp()
		{
			return SOgsoMxFCL0pekJ2Kpev == null;
		}

		internal static UOc6OCaRRH6QuLSv4Smw fnZ8g2xFKJFwLMskFSZJ()
		{
			return SOgsoMxFCL0pekJ2Kpev;
		}

		internal static object qKOGwjxFmTfq6vFpl3Mi(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
		}

		internal static object q7jPWuxFhCPBVQK30oXj(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).TnYlYCCpDAI();
		}

		internal static object YYh5w3xFw3a3RJrkQsMA(object P_0, object P_1)
		{
			return ((iUurRSaEdsHhvxFJgcBd)P_0).f0oaEMlfDjn((Symbol)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class V6cYR8aRO1EWeUF1WZns
	{
		public Symbol dw5aRI6hbw3;

		private static V6cYR8aRO1EWeUF1WZns Y6ikLExF7ZsLFapPr92U;

		public V6cYR8aRO1EWeUF1WZns()
		{
			QZu59KxFPjnSrumgIiXy();
			base._002Ector();
		}

		internal bool YW2aRqSfPEU(AdVNpgG79ErxvcbgBD1J con)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 1:
					if (con.mWXlYwTb86e.MarketData)
					{
						if (rhadYvxFJBsOqjrcesBN(con.mWXlYwTb86e) && !IJgcNgxF3nVuObgfjrev(jymCKExFFY5Ife8kYpdw(con)))
						{
							return con.NGZlYyv6dJg.jemaQZBB4Zt(dw5aRI6hbw3.ID) != null;
						}
						goto default;
					}
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static V6cYR8aRO1EWeUF1WZns()
		{
			AMZoZ5xFpynFd7t5IPvC();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void QZu59KxFPjnSrumgIiXy()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool jfUyPLxF8lAAEyE6y47T()
		{
			return Y6ikLExF7ZsLFapPr92U == null;
		}

		internal static V6cYR8aRO1EWeUF1WZns Dv5ns4xFAwor8yDDEPNt()
		{
			return Y6ikLExF7ZsLFapPr92U;
		}

		internal static bool rhadYvxFJBsOqjrcesBN(object P_0)
		{
			return ((ConnectionInfo)P_0).IsConnected;
		}

		internal static object jymCKExFFY5Ife8kYpdw(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
		}

		internal static bool IJgcNgxF3nVuObgfjrev(object P_0)
		{
			return ((ConnectionInfo)P_0).Simulator;
		}

		internal static void AMZoZ5xFpynFd7t5IPvC()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class lQdg1kaRWHWKGyuJA0w9
	{
		public static readonly lQdg1kaRWHWKGyuJA0w9 Hg4a60CTtcE;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> xeva62U97Cq;

		public static Func<AdVNpgG79ErxvcbgBD1J, ConnectionInfo> ORZa6Hekn6h;

		public static Func<Account, bool> JYsa6fJNUWE;

		public static Func<Portfolio, bool> hVva695EV7p;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> Sjwa6nxc3Uh;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> UgXa6G0tF24;

		public static Func<AdVNpgG79ErxvcbgBD1J, IEnumerable<Account>> ekDa6YcJgpi;

		public static Func<Order, bool> ueaa6ob8xop;

		public static Func<Order, Account> X6va6vx3U3E;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> RsBa6BKtyK0;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> x5Za6ap2n6i;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> DiCa6iK3yfo;

		public static Func<AdVNpgG79ErxvcbgBD1J, int> f75a6lZcRx5;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> gdHa64pWNJQ;

		public static Func<AdVNpgG79ErxvcbgBD1J, int> qGSa6DvoISy;

		public static Func<Order, bool> pata6b4qtew;

		public static Func<Order, bool> pg4a6N8cb40;

		public static Func<AdVNpgG79ErxvcbgBD1J, bool> MZYa6kQCSE8;

		public static Func<UserPosition, bool> gCBa616VTJt;

		public static Func<AdVNpgG79ErxvcbgBD1J, int> KAJa65hSgfM;

		public static Func<string, AdVNpgG79ErxvcbgBD1J> nZja6SNnjn1;

		public static Func<AdVNpgG79ErxvcbgBD1J, int> bgCa6xsO91G;

		private static lQdg1kaRWHWKGyuJA0w9 Qsc0LixFutAs1GqsLyKU;

		static lQdg1kaRWHWKGyuJA0w9()
		{
			KvhQ0Vx32G12mWmtYecY();
			M9Vg5Kx3HGKMaVMYsU6N();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			Hg4a60CTtcE = new lQdg1kaRWHWKGyuJA0w9();
		}

		public lQdg1kaRWHWKGyuJA0w9()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool Ur0aRteZXLa(AdVNpgG79ErxvcbgBD1J c)
		{
			if (!((ConnectionInfo)w9ENsRx3fio1ks4kd7ou(c)).Simulator)
			{
				return !aBGHcvx391fCLHDplmEe(c.mWXlYwTb86e);
			}
			return false;
		}

		internal ConnectionInfo Nj9aRU5BNgs(AdVNpgG79ErxvcbgBD1J c)
		{
			return c.mWXlYwTb86e;
		}

		internal bool XIYaRTfeNc0(Account a)
		{
			return ALYTpVx3nV5BJAgcJk8y(a.AccountID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82871888) + (Player ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225718695) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB1AD38)));
		}

		internal bool sBWaRyNbIKv(Portfolio p)
		{
			return p.Name == (string)WFrJk9x3GEjVDofWwky8(0x50C1C840 ^ 0x50C0877C);
		}

		internal bool HhhaRZm0lWU(AdVNpgG79ErxvcbgBD1J connection)
		{
			return !((ConnectionInfo)w9ENsRx3fio1ks4kd7ou(connection)).Simulator;
		}

		internal bool zicaRVqaj7q(AdVNpgG79ErxvcbgBD1J connection)
		{
			if (!RS799Rx3YOJpX2Qp5po6(connection.mWXlYwTb86e))
			{
				return !aBGHcvx391fCLHDplmEe(connection.mWXlYwTb86e);
			}
			return false;
		}

		internal IEnumerable<Account> W6HaRCq0mrE(AdVNpgG79ErxvcbgBD1J connection)
		{
			return connection.m3jlYd926hA.H4saEsREVA4();
		}

		internal bool OAlaRr5hhZN(Order w)
		{
			return Gxj7gZx3okPliV20yS77(w) != null;
		}

		internal Account JJwaRKJlQXM(Order g)
		{
			return g.Account;
		}

		internal bool TBVaRmEmHfQ(AdVNpgG79ErxvcbgBD1J c)
		{
			return !c.mWXlYwTb86e.Simulator;
		}

		internal bool kCUaRhrZJMM(AdVNpgG79ErxvcbgBD1J connection)
		{
			return connection.mWXlYwTb86e.MarketData;
		}

		internal bool rVaaRwOAiFS(AdVNpgG79ErxvcbgBD1J c)
		{
			return !c.mWXlYwTb86e.Simulator;
		}

		internal int hfaaR7Naae9(AdVNpgG79ErxvcbgBD1J connection)
		{
			return ((Orders)CvhG4ix3vcSAsM6G6Yar(connection)).VlLaQixssUY(OrderGroup.All, (string)null).Count;
		}

		internal bool MLGaR8puZK0(AdVNpgG79ErxvcbgBD1J c)
		{
			if (((ConnectionInfo)w9ENsRx3fio1ks4kd7ou(c)).IsConnected)
			{
				return !((ConnectionInfo)w9ENsRx3fio1ks4kd7ou(c)).Simulator;
			}
			return false;
		}

		internal int s82aRAaJ0b5(AdVNpgG79ErxvcbgBD1J connection)
		{
			return ((Orders)CvhG4ix3vcSAsM6G6Yar(connection)).VlLaQixssUY(OrderGroup.All, (string)null).Count;
		}

		internal bool G04aRPTKJFa(Order w)
		{
			return B8Ifg0x3BEQPJeyQBL22(w.Account);
		}

		internal bool p9SaRJpZwmT(Order w)
		{
			return !w.Account.IsPlayer;
		}

		internal bool uBqaRFkWjLT(AdVNpgG79ErxvcbgBD1J c)
		{
			return !c.mWXlYwTb86e.Simulator;
		}

		internal int B78aR3AQl4S(AdVNpgG79ErxvcbgBD1J connection)
		{
			return connection.mxqlYWdjLU2.GetAll().Count((UserPosition p) => p.Size != 0);
		}

		internal bool uElaRp0QfOA(UserPosition p)
		{
			return p.Size != 0;
		}

		internal AdVNpgG79ErxvcbgBD1J DBkaRunKRnm(string id)
		{
			return Connections.Get(id);
		}

		internal int xTpaRzPUeQJ(AdVNpgG79ErxvcbgBD1J connection)
		{
			return connection.o6ElY3YBWqG();
		}

		internal static void KvhQ0Vx32G12mWmtYecY()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void M9Vg5Kx3HGKMaVMYsU6N()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool OACbrAxFzffY7CyCRWHc()
		{
			return Qsc0LixFutAs1GqsLyKU == null;
		}

		internal static lQdg1kaRWHWKGyuJA0w9 oS0LlQx30r3g9an1L766()
		{
			return Qsc0LixFutAs1GqsLyKU;
		}

		internal static object w9ENsRx3fio1ks4kd7ou(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
		}

		internal static bool aBGHcvx391fCLHDplmEe(object P_0)
		{
			return ((ConnectionInfo)P_0).Trust;
		}

		internal static bool ALYTpVx3nV5BJAgcJk8y(object P_0, object P_1)
		{
			return ((string)P_0).StartsWith((string)P_1);
		}

		internal static object WFrJk9x3GEjVDofWwky8(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool RS799Rx3YOJpX2Qp5po6(object P_0)
		{
			return ((ConnectionInfo)P_0).Simulator;
		}

		internal static object Gxj7gZx3okPliV20yS77(object P_0)
		{
			return ((Order)P_0).Account;
		}

		internal static object CvhG4ix3vcSAsM6G6Yar(object P_0)
		{
			return ((AdVNpgG79ErxvcbgBD1J)P_0).yuplYRm5htt;
		}

		internal static bool B8Ifg0x3BEQPJeyQBL22(object P_0)
		{
			return ((Account)P_0).IsPlayer;
		}
	}

	[CompilerGenerated]
	private sealed class yyGJKKa6L6PoC53njlnP
	{
		public Symbol PsTa6XaFJy7;

		private static yyGJKKa6L6PoC53njlnP gf43oLx3aqFLfBXADh4c;

		public yyGJKKa6L6PoC53njlnP()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool I0La6eQguCR(Portfolio p)
		{
			if (p.Currency == PsTa6XaFJy7.Currency)
			{
				return MGrtotx3DT5hr4wfXrgO(p.Name, xWTRd3x34EI04YaplByE(-962524685 ^ -962469611));
			}
			return false;
		}

		internal bool eEua6smcXXR(Portfolio p)
		{
			return fqPUvRx3bAaVJURPlR7i(p.Currency, PsTa6XaFJy7.Currency);
		}

		static yyGJKKa6L6PoC53njlnP()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool vVCGo5x3iET7w1gGsUwC()
		{
			return gf43oLx3aqFLfBXADh4c == null;
		}

		internal static yyGJKKa6L6PoC53njlnP FGU1WYx3lqmLdb0iI4Qq()
		{
			return gf43oLx3aqFLfBXADh4c;
		}

		internal static object xWTRd3x34EI04YaplByE(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool MGrtotx3DT5hr4wfXrgO(object P_0, object P_1)
		{
			return ((string)P_0).Contains((string)P_1);
		}

		internal static bool fqPUvRx3bAaVJURPlR7i(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class Ns4Khfa6cIMJQkGCobPc
	{
		public string VxSa6ExZ6uJ;

		public yyGJKKa6L6PoC53njlnP FoOa6QKO6bs;

		private static Ns4Khfa6cIMJQkGCobPc JOuBb3x3NoouNgCg8Lbg;

		public Ns4Khfa6cIMJQkGCobPc()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool Tqja6jHOxWk(Portfolio p)
		{
			if (WUx42Ux3SHWidSvFq8Sg(p.Currency, U9iJMux35XIi3bMFb6Zb(FoOa6QKO6bs.PsTa6XaFJy7)))
			{
				return uC03kmx3x5ZZGSO0XNPp(p.UniqueID, VxSa6ExZ6uJ);
			}
			return false;
		}

		static Ns4Khfa6cIMJQkGCobPc()
		{
			On70dIx3LfIjRPDvFOEG();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool a7voE7x3kB4p0TYPoqvZ()
		{
			return JOuBb3x3NoouNgCg8Lbg == null;
		}

		internal static Ns4Khfa6cIMJQkGCobPc lUC5Svx31nuQ80GrW2f0()
		{
			return JOuBb3x3NoouNgCg8Lbg;
		}

		internal static object U9iJMux35XIi3bMFb6Zb(object P_0)
		{
			return ((Symbol)P_0).Currency;
		}

		internal static bool WUx42Ux3SHWidSvFq8Sg(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static bool uC03kmx3x5ZZGSO0XNPp(object P_0, object P_1)
		{
			return ((string)P_0).Contains((string)P_1);
		}

		internal static void On70dIx3LfIjRPDvFOEG()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[CompilerGenerated]
	private sealed class hDRuxva6dmLlOmcge4ql
	{
		public string oxHa6R0Lpvd;

		internal static hDRuxva6dmLlOmcge4ql hiQOaMx3eCt2HJia9sN2;

		public hDRuxva6dmLlOmcge4ql()
		{
			Mps91Jx3cKTj7FFU1UvU();
			base._002Ector();
		}

		internal bool rLwa6gT7ANL(AdVNpgG79ErxvcbgBD1J c)
		{
			return TbdROYx3jF3KBRalxj7Z(c.NGZlYyv6dJg, oxHa6R0Lpvd) != null;
		}

		static hDRuxva6dmLlOmcge4ql()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			o2Nu3gx3EK7cxlnf8Iee();
		}

		internal static void Mps91Jx3cKTj7FFU1UvU()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool OD5s8yx3sjckdFtP4vBB()
		{
			return hiQOaMx3eCt2HJia9sN2 == null;
		}

		internal static hDRuxva6dmLlOmcge4ql F10sywx3XkTDQ2yosbmE()
		{
			return hiQOaMx3eCt2HJia9sN2;
		}

		internal static object TbdROYx3jF3KBRalxj7Z(object P_0, object P_1)
		{
			return ((Securities)P_0).jemaQZBB4Zt((string)P_1);
		}

		internal static void o2Nu3gx3EK7cxlnf8Iee()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private static readonly ActivitySource activitySource;

	private static readonly RJQ40bG97fddixgFUWO6.ftDG8nGG2P2BKodOfpKp instrumentation;

	[CompilerGenerated]
	private static Action m_OnUpdateAccount;

	[CompilerGenerated]
	private static Action m_OnClearMarket;

	[CompilerGenerated]
	private static Action m_OnUpdateFilters;

	[CompilerGenerated]
	private static Action m_OnReferralDetected;

	private static readonly Connections Connections;

	private static readonly XGPMikadHJMQKPWwUlio Tickers;

	private static readonly Queue<anI4lfGJ8TTwhTlujQ36> Buffer;

	private static readonly ConcurrentQueue<anI4lfGJ8TTwhTlujQ36> QueueMarketEvents;

	private static readonly Queue<QO3Z1DajgOh2CTyqOCfs> QueueTradeData;

	private static readonly Queue<Order> UiQueueOrders;

	private static readonly Queue<Execution> UiQueueExecution;

	private static readonly List<string> IdsConnection;

	private static readonly K8qrSoGhl2LgcSAFZZIZ _autoDetectConnectionService;

	private static DataManager sUjh1d5r1uQeFeFWfXmM;

	private static int TradeMode { get; set; }

	public static bool Simulator { get; private set; }

	public static bool Player { get; private set; }

	public static event Action<EventOwner<SecurityEvent>> OnSecurityEvent;

	public static event Action<EventOwner<TickEvent>> OnTickEvent;

	public static event Action<EventOwner<MarketDepthDiffEvent>> OnDiffEvent;

	public static event Action<EventOwner<MarketDepthFullEvent>> OnFullEvent;

	public static event Action<EventOwner<TicksResponseEvent>> OnTicksEvent;

	public static event Action<ConnectionInfo, string> OnError;

	public static event Action<ConnectionInfo, string> OnInfo;

	public static event Action<ConnectionInfo> OnConnected;

	public static event Action<ConnectionInfo> OnDisconnected;

	public static event Action<ConnectionInfo> OnAccountsReady;

	public static event Action OnUpdateAccount
	{
		[CompilerGenerated]
		add
		{
			Action action = DataManager.m_OnUpdateAccount;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
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
					action = Interlocked.CompareExchange(ref DataManager.m_OnUpdateAccount, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			Action action2 = default(Action);
			Action action = default(Action);
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					Action value2 = (Action)bH09KU5rxBDWcJ45kKlV(action2, value);
					action = Interlocked.CompareExchange(ref DataManager.m_OnUpdateAccount, value2, action2);
					if ((object)action == action2)
					{
						return;
					}
					break;
				}
				case 1:
					action = DataManager.m_OnUpdateAccount;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				action2 = action;
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	public static event Action OnClearMarket
	{
		[CompilerGenerated]
		add
		{
			Action action = DataManager.m_OnClearMarket;
			Action action2;
			do
			{
				action2 = action;
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						Action value2 = (Action)vijp7J5rLc4dTfIOp05L(action2, value);
						action = Interlocked.CompareExchange(ref DataManager.m_OnClearMarket, value2, action2);
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
						{
							num = 0;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = DataManager.m_OnClearMarket;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange(ref DataManager.m_OnClearMarket, value2, action2);
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
				{
					num = 0;
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
						break;
					}
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public static event Action OnUpdateFilters
	{
		[CompilerGenerated]
		add
		{
			Action action = DataManager.m_OnUpdateFilters;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
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
					action = Interlocked.CompareExchange(ref DataManager.m_OnUpdateFilters, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			Action action = DataManager.m_OnUpdateFilters;
			while (true)
			{
				Action action2 = action;
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
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
						break;
					}
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref DataManager.m_OnUpdateFilters, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public static event Action OnReferralDetected
	{
		[CompilerGenerated]
		add
		{
			Action action = DataManager.m_OnReferralDetected;
			while (true)
			{
				Action action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
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
						break;
					}
					action = Interlocked.CompareExchange(ref DataManager.m_OnReferralDetected, value2, action2);
					if ((object)action != action2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			Action action2 = default(Action);
			Action action = default(Action);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref DataManager.m_OnReferralDetected, value2, action2);
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					if ((object)action == action2)
					{
						return;
					}
					goto default;
				case 1:
					action = DataManager.m_OnReferralDetected;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static event Action<string> OnShowTTBrokerPromo;

	public static event Action<UM9rvMGue9VnVEmAkGdP> OnMarginCall;

	public static event Action<Order> OnOrder;

	public static event Action<IEnumerable<Order>> OnOrders;

	public static event Action<OrderInfo> OnOrderInfo;

	public static event Action<Execution> OnExecution;

	public static event Action<IEnumerable<Execution>> OnExecutions;

	public static event Action<Position> OnPosition;

	public static event Action<UserPosition> OnUserPosition;

	public static event Action<UserDeal> OnUserDeal;

	public static event Action<Portfolio> OnPortfolio;

	public static event Action<Leverage> OnLeverage;

	public static event Action<ge4THKY0Mmg6Aqt6g6cu> OnTelegramMessage;

	public static event Action<BarsResponce> OnBarsObtained;

	static DataManager()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		tYSZne5reOsQSgYqAU7L();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				UiQueueOrders = new Queue<Order>();
				num = 3;
				break;
			case 3:
				UiQueueExecution = new Queue<Execution>();
				_autoDetectConnectionService = new K8qrSoGhl2LgcSAFZZIZ();
				IdsConnection = new List<string>();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 5:
				Connections = new Connections();
				Buffer = new Queue<anI4lfGJ8TTwhTlujQ36>(256);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
				{
					num = 1;
				}
				break;
			case 2:
				activitySource = new ActivitySource((string)qQ7OmW5rs4wc5Jse6eY6(-3429745 ^ -3443325));
				instrumentation = RJQ40bG97fddixgFUWO6.JptG9J4fvNs;
				Tickers = new XGPMikadHJMQKPWwUlio();
				num = 5;
				break;
			case 1:
			{
				QueueMarketEvents = new ConcurrentQueue<anI4lfGJ8TTwhTlujQ36>();
				QueueTradeData = new Queue<QO3Z1DajgOh2CTyqOCfs>();
				int num2 = 4;
				num = num2;
				break;
			}
			}
		}
	}

	public static void ProcessUiTablesOrders()
	{
		Queue<Order> uiQueueOrders = UiQueueOrders;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(uiQueueOrders, ref lockTaken);
			int num = 2;
			int num2 = num;
			List<Order> list = default(List<Order>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
				{
					while (UiQueueOrders.Count > 0)
					{
						Order item = UiQueueOrders.Dequeue();
						list.Add(item);
					}
					Action<IEnumerable<Order>> onOrders = DataManager.OnOrders;
					if (onOrders == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					onOrders(list);
					return;
				}
				case 3:
					break;
				case 2:
					if (UiQueueOrders.Count == 0)
					{
						return;
					}
					break;
				}
				list = new List<Order>();
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
				{
					num2 = 1;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				BFTL4a5rXIC31fDFRX9N(uiQueueOrders);
			}
		}
	}

	public static void ProcessUiTablesExecutions()
	{
		Queue<Execution> uiQueueExecution = UiQueueExecution;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				Monitor.Enter(uiQueueExecution, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
				{
					num2 = 0;
				}
				List<Execution> list = default(List<Execution>);
				while (true)
				{
					switch (num2)
					{
					default:
						if (UiQueueExecution.Count == 0)
						{
							return;
						}
						goto case 1;
					case 2:
						DataManager.OnExecutions?.Invoke(list);
						return;
					case 3:
						if (UiQueueExecution.Count > 0)
						{
							Execution item = UiQueueExecution.Dequeue();
							list.Add(item);
							num2 = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
							{
								num2 = 3;
							}
						}
						else
						{
							num2 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
							{
								num2 = 2;
							}
						}
						break;
					case 1:
						list = new List<Execution>();
						goto case 3;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(uiQueueExecution);
				}
			}
		}
	}

	public static void ProcessMarketEvents()
	{
		int num = 1;
		int num2 = num;
		anI4lfGJ8TTwhTlujQ36 anI4lfGJ8TTwhTlujQ = default(anI4lfGJ8TTwhTlujQ36);
		jDhdBvGJCYyeucPOsxGw jDhdBvGJCYyeucPOsxGw = default(jDhdBvGJCYyeucPOsxGw);
		TicksResponseEvent ticksResponseEvent = default(TicksResponseEvent);
		SecurityEvent securityEvent = default(SecurityEvent);
		EventOwner<TickEvent> eventOwner = default(EventOwner<TickEvent>);
		MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
		EventOwner<MarketDepthDiffEvent> eventOwner5 = default(EventOwner<MarketDepthDiffEvent>);
		MarketDepthDiffEvent marketDepthDiffEvent = default(MarketDepthDiffEvent);
		EventOwner<MarketDepthFullEvent> eventOwner2 = default(EventOwner<MarketDepthFullEvent>);
		EventOwner<TicksResponseEvent> eventOwner3 = default(EventOwner<TicksResponseEvent>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Buffer.Clear();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			default:
			{
				anI4lfGJ8TTwhTlujQ36 result;
				while (QueueMarketEvents.TryDequeue(out result))
				{
					Buffer.Enqueue(result);
				}
				break;
			}
			case 2:
				try
				{
					j7hE9bGJUtiuJ2DVMLti j7hE9bGJUtiuJ2DVMLti = anI4lfGJ8TTwhTlujQ as j7hE9bGJUtiuJ2DVMLti;
					int num3;
					if (j7hE9bGJUtiuJ2DVMLti == null)
					{
						jDhdBvGJCYyeucPOsxGw = anI4lfGJ8TTwhTlujQ as jDhdBvGJCYyeucPOsxGw;
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
						{
							num3 = 0;
						}
					}
					else
					{
						num3 = 13;
					}
					while (true)
					{
						int num4;
						switch (num3)
						{
						case 8:
							break;
						case 11:
							if (ticksResponseEvent == null)
							{
								break;
							}
							goto case 9;
						case 1:
							if (jDhdBvGJCYyeucPOsxGw == null)
							{
								num3 = 7;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							HistoryPlayerModule.RiseSecDataChanged(jDhdBvGJCYyeucPOsxGw);
							num4 = 14;
							goto IL_00c2;
						case 14:
							break;
						case 3:
							break;
						case 17:
						{
							if (securityEvent == null)
							{
								if (anI4lfGJ8TTwhTlujQ is TickEvent oKPGiektYF2yWuacLNwG)
								{
									eventOwner = IlvHiXGF9pA6U4gUK5bq.JoWGFYLGguA();
									eventOwner.k1pGJpywlFB(oKPGiektYF2yWuacLNwG);
									num3 = 14;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
									{
										num3 = 15;
									}
								}
								else
								{
									marketDepthFullEvent = anI4lfGJ8TTwhTlujQ as MarketDepthFullEvent;
									num3 = 4;
								}
								continue;
							}
							EventOwner<SecurityEvent> eventOwner4 = IlvHiXGF9pA6U4gUK5bq.ffQGFG4Iy67();
							eventOwner4.k1pGJpywlFB(securityEvent);
							DataManager.OnSecurityEvent?.Invoke(eventOwner4);
							break;
						}
						case 2:
						case 18:
							eventOwner5 = IlvHiXGF9pA6U4gUK5bq.LyvGFvAaOok();
							eventOwner5.k1pGJpywlFB(marketDepthDiffEvent);
							num3 = 10;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
							{
								num3 = 10;
							}
							continue;
						case 4:
							if (marketDepthFullEvent != null)
							{
								eventOwner2 = IlvHiXGF9pA6U4gUK5bq.cKNGFo0ZLQq();
								num3 = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
								{
									num3 = 5;
								}
								continue;
							}
							marketDepthDiffEvent = anI4lfGJ8TTwhTlujQ as MarketDepthDiffEvent;
							if (marketDepthDiffEvent == null)
							{
								ticksResponseEvent = anI4lfGJ8TTwhTlujQ as TicksResponseEvent;
								num3 = 11;
								continue;
							}
							num4 = 18;
							goto IL_00c2;
						case 13:
							HistoryPlayerModule.RiseStateChanged(j7hE9bGJUtiuJ2DVMLti);
							break;
						case 10:
						{
							Action<EventOwner<MarketDepthDiffEvent>> onDiffEvent = DataManager.OnDiffEvent;
							if (onDiffEvent == null)
							{
								break;
							}
							onDiffEvent(eventOwner5);
							num3 = 16;
							continue;
						}
						case 19:
						{
							Action<EventOwner<MarketDepthFullEvent>> onFullEvent = DataManager.OnFullEvent;
							if (onFullEvent == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
								{
									num3 = 0;
								}
							}
							else
							{
								onFullEvent(eventOwner2);
								num3 = 3;
							}
							continue;
						}
						case 9:
							eventOwner3 = IlvHiXGF9pA6U4gUK5bq.RRRGFBQBDTS();
							num3 = 12;
							continue;
						case 12:
						{
							eventOwner3.k1pGJpywlFB(ticksResponseEvent);
							Action<EventOwner<TicksResponseEvent>> onTicksEvent = DataManager.OnTicksEvent;
							if (onTicksEvent == null)
							{
								break;
							}
							onTicksEvent(eventOwner3);
							num3 = 6;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						case 5:
							eventOwner2.k1pGJpywlFB(marketDepthFullEvent);
							num3 = 19;
							continue;
						case 16:
							break;
						case 7:
							securityEvent = anI4lfGJ8TTwhTlujQ as SecurityEvent;
							num3 = 17;
							continue;
						case 15:
						{
							Action<EventOwner<TickEvent>> onTickEvent = DataManager.OnTickEvent;
							if (onTickEvent == null)
							{
								break;
							}
							onTickEvent(eventOwner);
							num3 = 8;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
							{
								num3 = 8;
							}
							continue;
						}
						case 0:
							break;
						case 6:
							break;
							IL_00c2:
							num3 = num4;
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					mjoPw85rcCEcLLUGZfw1(ex);
				}
				break;
			}
			if (Pw6hTK5rjNS8vrFtehVM(Buffer) <= 0)
			{
				break;
			}
			anI4lfGJ8TTwhTlujQ = Buffer.Dequeue();
			num2 = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
			{
				num2 = 0;
			}
		}
	}

	private static void SecurityChangedExt(g62JgfGp2rGReTRRFt16 ticker)
	{
		if (!Player)
		{
			IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = Connections.GetAll().GetEnumerator();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.p2JlYeJO25d(ticker);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						}
					}
					return;
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
		}
		GetSimConnection().p2JlYeJO25d(ticker);
	}

	private static void MarketEvents(AdVNpgG79ErxvcbgBD1J tradeClient, List<anI4lfGJ8TTwhTlujQ36> marketEvents)
	{
		if (marketEvents == null || marketEvents.Count == 0)
		{
			return;
		}
		g62JgfGp2rGReTRRFt16 g62JgfGp2rGReTRRFt = null;
		foreach (anI4lfGJ8TTwhTlujQ36 marketEvent in marketEvents)
		{
			EnqueueMarketEvent(tradeClient.mWXlYwTb86e, marketEvent);
			g62JgfGp2rGReTRRFt = Tickers.nrWadns1HTl(marketEvent.Symbol);
			if (g62JgfGp2rGReTRRFt == null)
			{
				continue;
			}
			if (!(marketEvent is MarketDepthFullEvent marketDepthFullEvent))
			{
				if (!(marketEvent is SecurityEvent securityEvent))
				{
					if (marketEvent is TickEvent tickEvent)
					{
						g62JgfGp2rGReTRRFt.GeFGpnx3wDN(tickEvent);
					}
				}
				else
				{
					g62JgfGp2rGReTRRFt.fuUGpf2fvak(securityEvent);
				}
			}
			else
			{
				g62JgfGp2rGReTRRFt.TYKGp9ASNfS(marketDepthFullEvent);
			}
			if (g62JgfGp2rGReTRRFt.KJ8GpGGsKiV())
			{
				SecurityChangedExt(g62JgfGp2rGReTRRFt);
			}
		}
	}

	public static void ProcessTradeData()
	{
		int num = 1;
		int num2 = num;
		Queue<QO3Z1DajgOh2CTyqOCfs> queueTradeData = default(Queue<QO3Z1DajgOh2CTyqOCfs>);
		QO3Z1DajgOh2CTyqOCfs qO3Z1DajgOh2CTyqOCfs = default(QO3Z1DajgOh2CTyqOCfs);
		QJKLHqY0TN2le5RyfwYX qJKLHqY0TN2le5RyfwYX = default(QJKLHqY0TN2le5RyfwYX);
		while (true)
		{
			switch (num2)
			{
			case 1:
				queueTradeData = QueueTradeData;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(queueTradeData, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						try
						{
							int num4;
							Action onReferralDetected;
							Action<ConnectionInfo> onAccountsReady;
							Action<string> onShowTTBrokerPromo;
							Action<ConnectionInfo> onConnected;
							Action<ConnectionInfo, string> onInfo;
							switch (LIMYYC5rEoDVDFnfSmjE(qO3Z1DajgOh2CTyqOCfs))
							{
							case (iK1S7sajLQV8P7VTMdUU)6:
							{
								Action<UserPosition> onUserPosition = DataManager.OnUserPosition;
								if (onUserPosition == null)
								{
									num4 = 18;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
									{
										num4 = 9;
									}
									goto IL_00e0;
								}
								onUserPosition((UserPosition)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
							}
							case iK1S7sajLQV8P7VTMdUU.Execution:
							{
								Action<Execution> onExecution = DataManager.OnExecution;
								if (onExecution == null)
								{
									num4 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
									{
										num4 = 0;
									}
									goto IL_00e0;
								}
								onExecution((Execution)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								goto IL_01fc;
							}
							case (iK1S7sajLQV8P7VTMdUU)7:
							{
								Action<UserDeal> onUserDeal = DataManager.OnUserDeal;
								if (onUserDeal == null)
								{
									num4 = 7;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
									{
										num4 = 25;
									}
								}
								else
								{
									onUserDeal((UserDeal)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
									num4 = 3;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
									{
										num4 = 20;
									}
								}
								goto IL_00e0;
							}
							case (iK1S7sajLQV8P7VTMdUU)10:
							{
								Action<ge4THKY0Mmg6Aqt6g6cu> onTelegramMessage = DataManager.OnTelegramMessage;
								if (onTelegramMessage == null)
								{
									num4 = 11;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
									{
										num4 = 7;
									}
									goto IL_00e0;
								}
								onTelegramMessage((ge4THKY0Mmg6Aqt6g6cu)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
							}
							case (iK1S7sajLQV8P7VTMdUU)3:
								goto IL_035b;
							case iK1S7sajLQV8P7VTMdUU.Position:
								DataManager.OnPosition?.Invoke((Position)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
							case (iK1S7sajLQV8P7VTMdUU)11:
								DataManager.OnMarginCall?.Invoke((UM9rvMGue9VnVEmAkGdP)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
							case (iK1S7sajLQV8P7VTMdUU)8:
								goto IL_03e8;
							case (iK1S7sajLQV8P7VTMdUU)1:
								goto IL_03f9;
							case iK1S7sajLQV8P7VTMdUU.Order:
								goto IL_0454;
							case iK1S7sajLQV8P7VTMdUU.Leverage:
								{
									Action<Leverage> onLeverage = DataManager.OnLeverage;
									if (onLeverage == null)
									{
										num4 = 10;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
										{
											num4 = 10;
										}
									}
									else
									{
										onLeverage((Leverage)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
										num4 = 4;
									}
									goto IL_00e0;
								}
								IL_04e3:
								onReferralDetected = DataManager.OnReferralDetected;
								if (onReferralDetected == null)
								{
									num4 = 8;
								}
								else
								{
									onReferralDetected();
									num4 = 19;
								}
								goto IL_00e0;
								IL_01fc:
								UiQueueExecution.Enqueue((Execution)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
								IL_02d0:
								onAccountsReady = DataManager.OnAccountsReady;
								if (onAccountsReady == null)
								{
									num4 = 9;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
									{
										num4 = 4;
									}
								}
								else
								{
									onAccountsReady(qJKLHqY0TN2le5RyfwYX.Info);
									num4 = 21;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
									{
										num4 = 26;
									}
								}
								goto IL_00e0;
								IL_00e0:
								switch (num4)
								{
								case 22:
									break;
								case 1:
									goto IL_01fc;
								case 4:
									break;
								case 23:
									goto IL_02d0;
								case 2:
									goto IL_035b;
								case 7:
									goto IL_036c;
								case 19:
									break;
								case 12:
									goto IL_03ad;
								case 26:
									break;
								case 24:
									break;
								case 17:
									goto IL_03e8;
								case 6:
									goto IL_03f9;
								case 16:
									break;
								case 5:
									break;
								case 15:
									goto IL_0454;
								case 21:
									goto IL_0465;
								case 13:
									break;
								case 20:
									break;
								default:
									goto IL_04e3;
								case 3:
									break;
								case 9:
									break;
								case 27:
									break;
								case 8:
									break;
								case 14:
									break;
								case 11:
									break;
								case 18:
									break;
								case 25:
									break;
								case 10:
									break;
								}
								break;
								IL_0454:
								DataManager.OnOrder?.Invoke((Order)nX7xPe5rQWIw06guyw4E(qO3Z1DajgOh2CTyqOCfs));
								UiQueueOrders.Enqueue((Order)nX7xPe5rQWIw06guyw4E(qO3Z1DajgOh2CTyqOCfs));
								num4 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
								{
									num4 = 24;
								}
								goto IL_00e0;
								IL_03e8:
								DataManager.OnPortfolio?.Invoke((Portfolio)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
								IL_035b:
								DataManager.OnOrderInfo?.Invoke((OrderInfo)qO3Z1DajgOh2CTyqOCfs.h1FajMUlcly());
								break;
								IL_0465:
								onShowTTBrokerPromo = DataManager.OnShowTTBrokerPromo;
								if (onShowTTBrokerPromo == null)
								{
									num4 = 14;
								}
								else
								{
									onShowTTBrokerPromo(qJKLHqY0TN2le5RyfwYX.Message);
									num4 = 21;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
									{
										num4 = 22;
									}
								}
								goto IL_00e0;
								IL_0512:
								onConnected = DataManager.OnConnected;
								if (onConnected != null)
								{
									onConnected((ConnectionInfo)mHo0qv5rd9o2KL3lt7RH(qJKLHqY0TN2le5RyfwYX));
									break;
								}
								num4 = 3;
								goto IL_00e0;
								IL_03f9:
								qJKLHqY0TN2le5RyfwYX = (QJKLHqY0TN2le5RyfwYX)nX7xPe5rQWIw06guyw4E(qO3Z1DajgOh2CTyqOCfs);
								switch (qJKLHqY0TN2le5RyfwYX.Type)
								{
								case (PClehAY0w6qA6HkeMrBZ)5:
									goto IL_02d0;
								case PClehAY0w6qA6HkeMrBZ.Error:
									goto IL_036c;
								case PClehAY0w6qA6HkeMrBZ.Info:
									goto IL_03ad;
								case (PClehAY0w6qA6HkeMrBZ)10:
									goto IL_0465;
								case (PClehAY0w6qA6HkeMrBZ)6:
									goto IL_04a4;
								case (PClehAY0w6qA6HkeMrBZ)9:
									goto IL_04e3;
								case PClehAY0w6qA6HkeMrBZ.Connected:
									goto IL_0512;
								case PClehAY0w6qA6HkeMrBZ.Disconnected:
									DataManager.OnDisconnected?.Invoke(qJKLHqY0TN2le5RyfwYX.Info);
									goto end_IL_0255;
								case PClehAY0w6qA6HkeMrBZ.StopLoss:
								case PClehAY0w6qA6HkeMrBZ.TakeProfit:
									goto end_IL_0255;
								}
								num4 = 13;
								goto IL_00e0;
								IL_036c:
								DataManager.OnError?.Invoke(qJKLHqY0TN2le5RyfwYX.Info, (string)hIs55B5rgild5CXPW2gf(qJKLHqY0TN2le5RyfwYX));
								break;
								IL_04a4:
								if (Player)
								{
									Action onClearMarket = DataManager.OnClearMarket;
									if (onClearMarket == null)
									{
										break;
									}
									onClearMarket();
									num4 = 11;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
									{
										num4 = 16;
									}
									goto IL_00e0;
								}
								break;
								IL_03ad:
								onInfo = DataManager.OnInfo;
								if (onInfo == null)
								{
									num4 = 27;
								}
								else
								{
									onInfo(qJKLHqY0TN2le5RyfwYX.Info, qJKLHqY0TN2le5RyfwYX.Message);
									num4 = 5;
								}
								goto IL_00e0;
								end_IL_0255:
								break;
							}
						}
						catch (Exception e)
						{
							LogManager.WriteError(e);
						}
						break;
					}
					if (qIBpuj5rRorHnHE7eMam(QueueTradeData) <= 0)
					{
						break;
					}
					qO3Z1DajgOh2CTyqOCfs = QueueTradeData.Dequeue();
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
					{
						num3 = 1;
					}
				}
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(queueTradeData);
				}
			}
		}
	}

	private static void TradeData(List<QO3Z1DajgOh2CTyqOCfs> tradeData)
	{
		if (tradeData == null || tradeData.Count == 0)
		{
			return;
		}
		lock (QueueTradeData)
		{
			foreach (QO3Z1DajgOh2CTyqOCfs tradeDatum in tradeData)
			{
				QueueTradeData.Enqueue(tradeDatum);
			}
		}
	}

	internal static void InitConnections()
	{
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = Connections.GetAll().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				AdVNpgG79ErxvcbgBD1J current = enumerator.Current;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				try
				{
					current.GaTlY1SBHLM();
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				LOOeJ35r6PMrSTdCb7x7(enumerator);
			}
		}
	}

	internal static void SubscribeClient(AdVNpgG79ErxvcbgBD1J tradeClient)
	{
		if (tradeClient == null)
		{
			return;
		}
		Connections.Add(tradeClient);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			tradeClient.GaAlY4Xnb6C(MarketEvents);
			tradeClient.eFhlYNuxl5e(TradeData);
		}
		catch (Exception ex)
		{
			mjoPw85rcCEcLLUGZfw1(ex);
		}
	}

	internal static void UnSubscribeClient(AdVNpgG79ErxvcbgBD1J tradeClient)
	{
		if (tradeClient == null)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			tradeClient.bpVlYDGuVdh(MarketEvents);
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (G8svQm5rMn2WXfMujFb9(tradeClient.mWXlYwTb86e))
					{
						tradeClient.Disconnect();
					}
					tradeClient.Dispose();
					goto end_IL_006e;
				}
				tradeClient.kjglYkl39LK(TradeData);
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_006e:
				break;
			}
		}
		catch (Exception ex)
		{
			mjoPw85rcCEcLLUGZfw1(ex);
		}
		HNEgIi5rIQvA3LMAcOew(Connections, L3JAFs5rqoBkrOwEexSu(KlqRyB5rOueDanU1Og57(tradeClient)));
	}

	internal static void UnSubscribeClients()
	{
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = Connections.GetAll().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				UnSubscribeClient(enumerator.Current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				LOOeJ35r6PMrSTdCb7x7(enumerator);
			}
		}
	}

	internal static bool ContainsTradeClient(string id)
	{
		return Connections.ContainsTradeClient(id);
	}

	public static void Subscribe(SubscriptionFlags flags, params Symbol[] symbols)
	{
		int num = 3;
		int num2 = num;
		Security security = default(Security);
		V6cYR8aRO1EWeUF1WZns v6cYR8aRO1EWeUF1WZns = default(V6cYR8aRO1EWeUF1WZns);
		Symbol symbol = default(Symbol);
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J2 = default(AdVNpgG79ErxvcbgBD1J);
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = default(AdVNpgG79ErxvcbgBD1J);
		MarketDepth marketDepth = default(MarketDepth);
		Symbol[] array = default(Symbol[]);
		int num3 = default(int);
		UOc6OCaRRH6QuLSv4Smw uOc6OCaRRH6QuLSv4Smw = default(UOc6OCaRRH6QuLSv4Smw);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 13:
				security = null;
				v6cYR8aRO1EWeUF1WZns.dw5aRI6hbw3 = (Symbol)wiSrMe5rWF36WChDVdUQ(symbol);
				adVNpgG79ErxvcbgBD1J2 = null;
				if (v6cYR8aRO1EWeUF1WZns.dw5aRI6hbw3 != null)
				{
					if (!Player)
					{
						goto case 12;
					}
					goto case 10;
				}
				goto IL_02bb;
			case 12:
				adVNpgG79ErxvcbgBD1J2 = Connections.GetAll().FirstOrDefault(v6cYR8aRO1EWeUF1WZns.YW2aRqSfPEU);
				goto IL_02ee;
			case 19:
				PIQac25ryAoSMnopwj1F(adVNpgG79ErxvcbgBD1J.mWXlYwTb86e, marketDepth.GetEvent(symbol));
				goto case 5;
			case 2:
				array = symbols;
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				adVNpgG79ErxvcbgBD1J2 = (AdVNpgG79ErxvcbgBD1J)HUc7nX5rtNTpALYNUmHm();
				goto IL_02ee;
			case 9:
				if (v6cYR8aRO1EWeUF1WZns.dw5aRI6hbw3.ID != symbol.ID)
				{
					num2 = 6;
					continue;
				}
				goto IL_0074;
			default:
				obj2 = null;
				break;
			case 1:
				if (num3 >= array.Length)
				{
					num2 = 14;
					continue;
				}
				symbol = array[num3];
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
				{
					num2 = 17;
				}
				continue;
			case 17:
				if (!flags.HasFlag(SubscriptionFlags.Level2))
				{
					num2 = 12;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
					{
						num2 = 15;
					}
				}
				else
				{
					uOc6OCaRRH6QuLSv4Smw = new UOc6OCaRRH6QuLSv4Smw();
					num2 = 8;
				}
				continue;
			case 3:
				AFoGv5GAT4PeYBusSBbk.Subscribe(flags, Tickers, symbols);
				num2 = 2;
				continue;
			case 4:
			case 16:
				if (adVNpgG79ErxvcbgBD1J == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj2 = ((iUurRSaEdsHhvxFJgcBd)xj6I8I5rUKvYcXXyl0EC(adVNpgG79ErxvcbgBD1J)).f0oaEMlfDjn(uOc6OCaRRH6QuLSv4Smw.LfDaRMk0JKn);
				break;
			case 7:
				if (marketDepth != null)
				{
					PIQac25ryAoSMnopwj1F(adVNpgG79ErxvcbgBD1J.mWXlYwTb86e, fZMm9S5rTsIGcBrg5tB2(marketDepth, uOc6OCaRRH6QuLSv4Smw.LfDaRMk0JKn));
					if (!(uOc6OCaRRH6QuLSv4Smw.LfDaRMk0JKn.ID != symbol.ID))
					{
						num2 = 5;
						continue;
					}
					goto case 19;
				}
				goto case 5;
			case 18:
				adVNpgG79ErxvcbgBD1J = (AdVNpgG79ErxvcbgBD1J)HUc7nX5rtNTpALYNUmHm();
				num2 = 16;
				continue;
			case 14:
				return;
			case 6:
				EnqueueMarketEvent(adVNpgG79ErxvcbgBD1J2.mWXlYwTb86e, security.GetEvent(symbol));
				goto IL_0074;
			case 8:
				marketDepth = null;
				uOc6OCaRRH6QuLSv4Smw.LfDaRMk0JKn = (Symbol)wiSrMe5rWF36WChDVdUQ(symbol);
				adVNpgG79ErxvcbgBD1J = null;
				if (uOc6OCaRRH6QuLSv4Smw.LfDaRMk0JKn != null)
				{
					if (!Player)
					{
						adVNpgG79ErxvcbgBD1J = Connections.GetAll().FirstOrDefault(uOc6OCaRRH6QuLSv4Smw.VfnaR6QOE8l);
						num2 = 4;
					}
					else
					{
						num2 = 18;
					}
					continue;
				}
				goto case 7;
			case 11:
				obj = null;
				goto IL_0420;
			case 5:
			case 15:
				{
					if (flags.HasFlag(SubscriptionFlags.Level1))
					{
						v6cYR8aRO1EWeUF1WZns = new V6cYR8aRO1EWeUF1WZns();
						num2 = 13;
						continue;
					}
					goto IL_0074;
				}
				IL_02bb:
				if (security != null)
				{
					EnqueueMarketEvent((ConnectionInfo)KlqRyB5rOueDanU1Og57(adVNpgG79ErxvcbgBD1J2), (anI4lfGJ8TTwhTlujQ36)qCK02P5rZcfaiKWrT3TM(security, v6cYR8aRO1EWeUF1WZns.dw5aRI6hbw3));
					num2 = 9;
					continue;
				}
				goto IL_0074;
				IL_0074:
				num3++;
				goto case 1;
				IL_0420:
				security = (Security)obj;
				goto IL_02bb;
				IL_02ee:
				if (adVNpgG79ErxvcbgBD1J2 == null)
				{
					num2 = 11;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
					{
						num2 = 11;
					}
					continue;
				}
				obj = adVNpgG79ErxvcbgBD1J2.NGZlYyv6dJg.jemaQZBB4Zt(v6cYR8aRO1EWeUF1WZns.dw5aRI6hbw3.ID);
				goto IL_0420;
			}
			marketDepth = (MarketDepth)obj2;
			num2 = 5;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
			{
				num2 = 7;
			}
		}
	}

	private static void EnqueueMarketEvent(ConnectionInfo connection, anI4lfGJ8TTwhTlujQ36 marketEvent)
	{
		if (yJ80yG5rVsniAUbfMXkF(_autoDetectConnectionService, connection, marketEvent))
		{
			QueueMarketEvents.Enqueue(marketEvent);
		}
	}

	public static void UnSubscribe(SubscriptionFlags flags, params Symbol[] symbols)
	{
		AFoGv5GAT4PeYBusSBbk.WIDGAZnGmDT(flags, Tickers, symbols);
	}

	internal static IList<AdVNpgG79ErxvcbgBD1J> GetConnections()
	{
		return Connections.GetAll();
	}

	internal static AdVNpgG79ErxvcbgBD1J GetConnection(string id)
	{
		return Connections.Get(id);
	}

	private static AdVNpgG79ErxvcbgBD1J GetSimConnection()
	{
		return (AdVNpgG79ErxvcbgBD1J)jsO7805rCyeG0XKO8MyC(Connections, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F55E538 ^ 0x7F554658));
	}

	private static AdVNpgG79ErxvcbgBD1J GetTrustConnection()
	{
		return (AdVNpgG79ErxvcbgBD1J)jsO7805rCyeG0XKO8MyC(Connections, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x148727EA));
	}

	public static IEnumerable<ConnectionInfo> GetConnectionsInfo()
	{
		return (from c in Connections.GetAll()
			where !((ConnectionInfo)lQdg1kaRWHWKGyuJA0w9.w9ENsRx3fio1ks4kd7ou(c)).Simulator && !lQdg1kaRWHWKGyuJA0w9.aBGHcvx391fCLHDplmEe(c.mWXlYwTb86e)
			select c.mWXlYwTb86e).ToList();
	}

	public static ConnectionInfo GetConnectionInfo(string id)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!string.IsNullOrEmpty(id))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = null;
				break;
			default:
				obj = Connections.Get(id);
				break;
			}
			break;
		}
		if (obj == null)
		{
			return null;
		}
		return (ConnectionInfo)KlqRyB5rOueDanU1Og57(obj);
	}

	public static double GetLeverage(string connectionID, Symbol symbol)
	{
		return ((AdVNpgG79ErxvcbgBD1J)jsO7805rCyeG0XKO8MyC(Connections, connectionID))?.RkZlYKBPjkj().SacaEzspYXI(symbol) ?? 0.0;
	}

	public static List<Account> GetSimAccounts()
	{
		return new List<Account>(from a in GetSimConnection().m3jlYd926hA.H4saEsREVA4()
			where lQdg1kaRWHWKGyuJA0w9.ALYTpVx3nV5BJAgcJk8y(a.AccountID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82871888) + (Player ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225718695) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB1AD38)))
			select a);
	}

	public static double GetFreeMargin(string connectionId, Symbol symbol)
	{
		yyGJKKa6L6PoC53njlnP CS_0024_003C_003E8__locals7 = new yyGJKKa6L6PoC53njlnP();
		CS_0024_003C_003E8__locals7.PsTa6XaFJy7 = symbol;
		AdVNpgG79ErxvcbgBD1J connection = GetConnection(connectionId);
		int num = 2;
		List<Portfolio> source = default(List<Portfolio>);
		Ns4Khfa6cIMJQkGCobPc ns4Khfa6cIMJQkGCobPc = default(Ns4Khfa6cIMJQkGCobPc);
		while (true)
		{
			Portfolio portfolio;
			switch (num)
			{
			case 7:
				portfolio = source.FirstOrDefault((Portfolio p) => p.Currency == CS_0024_003C_003E8__locals7.PsTa6XaFJy7.Currency && yyGJKKa6L6PoC53njlnP.MGrtotx3DT5hr4wfXrgO(p.Name, yyGJKKa6L6PoC53njlnP.xWTRd3x34EI04YaplByE(-962524685 ^ -962469611)));
				goto IL_00ec;
			case 4:
				portfolio = source.FirstOrDefault((Portfolio p) => yyGJKKa6L6PoC53njlnP.fqPUvRx3bAaVJURPlR7i(p.Currency, CS_0024_003C_003E8__locals7.PsTa6XaFJy7.Currency));
				goto IL_00ec;
			case 5:
				return -1.0;
			case 8:
				source = ((Yf7Wh7aQx5n0OwURsfH6)lkT8MK5rrZcCsRjfCR0A(connection)).ltcaQXEchQi();
				if (CS_0024_003C_003E8__locals7.PsTa6XaFJy7.IsTigerX)
				{
					ns4Khfa6cIMJQkGCobPc = new Ns4Khfa6cIMJQkGCobPc();
					ns4Khfa6cIMJQkGCobPc.FoOa6QKO6bs = CS_0024_003C_003E8__locals7;
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
					{
						num = 1;
					}
					break;
				}
				if (QJj9I45rKocfPNqZ9BOY(CS_0024_003C_003E8__locals7.PsTa6XaFJy7))
				{
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
					{
						num = 7;
					}
					break;
				}
				goto case 1;
			case 2:
				if (connection != null)
				{
					num = 8;
					break;
				}
				goto case 5;
			case 1:
				if (!CS_0024_003C_003E8__locals7.PsTa6XaFJy7.IsBackpack)
				{
					goto case 4;
				}
				goto default;
			case 6:
				portfolio = source.FirstOrDefault(ns4Khfa6cIMJQkGCobPc.Tqja6jHOxWk);
				goto IL_00ec;
			case 3:
				ns4Khfa6cIMJQkGCobPc.VxSa6ExZ6uJ = (string)(ns4Khfa6cIMJQkGCobPc.FoOa6QKO6bs.PsTa6XaFJy7.IsOkxX ? qQ7OmW5rs4wc5Jse6eY6(-1962651919 ^ -1962634807) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6D18F862 ^ 0x6D182744));
				num = 6;
				break;
			default:
				{
					portfolio = source.FirstOrDefault((Portfolio p) => p.Name == (string)lQdg1kaRWHWKGyuJA0w9.WFrJk9x3GEjVDofWwky8(0x50C1C840 ^ 0x50C0877C));
					goto IL_00ec;
				}
				IL_00ec:
				return portfolio?.FreeMargin ?? (-1.0);
			}
		}
	}

	public static Account GetAccount(string accountID)
	{
		if (iZjbiJ5rmZIumNebPjKI())
		{
			return GetSimConnection().m3jlYd926hA.N07aELTPF6E(accountID);
		}
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = default(AdVNpgG79ErxvcbgBD1J);
		int num;
		if (!string.IsNullOrEmpty(accountID))
		{
			string connectionID = (string)X2vFbu5rhRGqcXWNVe0u(accountID);
			adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
			if (adVNpgG79ErxvcbgBD1J == null)
			{
				goto IL_0088;
			}
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			return null;
		}
		if (adVNpgG79ErxvcbgBD1J.mWXlYwTb86e.Simulator)
		{
			goto IL_0088;
		}
		return (Account)PuVk4r5r7qYDwBvnRc3G(me63bw5rwgYA2LSEOpgm(adVNpgG79ErxvcbgBD1J), accountID);
		IL_0088:
		return null;
	}

	public static List<Account> GetAccounts(Symbol symbol, bool isOfflineAccount = false)
	{
		if (Simulator)
		{
			return GetSimAccounts();
		}
		List<Account> list = new List<Account>();
		symbol = symbol?.GetSymbol();
		if (symbol == null)
		{
			return list;
		}
		List<AdVNpgG79ErxvcbgBD1J> list2 = (from connection in Connections.GetAll(!isOfflineAccount)
			where !((ConnectionInfo)lQdg1kaRWHWKGyuJA0w9.w9ENsRx3fio1ks4kd7ou(connection)).Simulator
			select connection).ToList();
		foreach (AdVNpgG79ErxvcbgBD1J item in list2)
		{
			foreach (Account item2 in item.m3jlYd926hA.H4saEsREVA4())
			{
				if (item2.Trust)
				{
					if (item2.TrustAccounts == null || item2.TrustAccounts.Count == 0)
					{
						continue;
					}
					bool flag = false;
					foreach (AdVNpgG79ErxvcbgBD1J item3 in list2)
					{
						foreach (KeyValuePair<string, decimal> trustAccount in item2.TrustAccounts)
						{
							Account account = item3.m3jlYd926hA.N07aELTPF6E(trustAccount.Key);
							if (account != null)
							{
								Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = item3.B5jlYEmv1MN.LPiaEyKvEyx(symbol);
								if (rybo1XGzd9ch5SOUQC2H != null && (!account.ContainsClassCodes() || account.ContainsClassCode(rybo1XGzd9ch5SOUQC2H.kbJGztBrI0l())))
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							list.Add(item2);
							break;
						}
					}
				}
				else if (symbol.IsTigerX && item2.Name.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-962524685 ^ -962483423)))
				{
					list.Add(item2);
				}
				else if (symbol.IsBitget && item2.Name.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2C8374E4 ^ 0x2C83D7D6)))
				{
					list.Add(item2);
				}
				else
				{
					Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H2 = item.B5jlYEmv1MN.LPiaEyKvEyx(symbol);
					if (rybo1XGzd9ch5SOUQC2H2 != null && (!item2.ContainsClassCodes() || item2.ContainsClassCode(rybo1XGzd9ch5SOUQC2H2.kbJGztBrI0l())))
					{
						list.Add(item2);
					}
				}
			}
		}
		return list;
	}

	public static List<Account> GetAccounts()
	{
		if (Simulator)
		{
			return GetSimAccounts();
		}
		return (from connection in Connections.GetAll(isConnected: true)
			where !lQdg1kaRWHWKGyuJA0w9.RS799Rx3YOJpX2Qp5po6(connection.mWXlYwTb86e) && !lQdg1kaRWHWKGyuJA0w9.aBGHcvx391fCLHDplmEe(connection.mWXlYwTb86e)
			select connection).SelectMany((AdVNpgG79ErxvcbgBD1J connection) => connection.m3jlYd926hA.H4saEsREVA4()).ToList();
	}

	private static UserPositions GetUserPositions(string connectionID)
	{
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
		if (adVNpgG79ErxvcbgBD1J == null)
		{
			return new UserPositions();
		}
		return (UserPositions)RHHrk15r8iZ96m0R2UTG(adVNpgG79ErxvcbgBD1J);
	}

	public static UserPosition GetUserPosition(Symbol symbol, Account account)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (symbol != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0064;
			default:
				{
					if (account != null)
					{
						symbol = symbol.GetSymbol();
						if (symbol == null)
						{
							return null;
						}
						return (UserPosition)vfIl8D5rAPjrDKheNBlZ(GetUserPositions(account.ConnectionID), symbol, account);
					}
					goto IL_0064;
				}
				IL_0064:
				return null;
			}
		}
	}

	private static int GetUserPositionsCount(Symbol symbol, Account account)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (account != null)
				{
					return RqVZoC5rF1JeoS6FfVp9(((Positions)Dojej75rJrSA795ZZw7R(jsO7805rCyeG0XKO8MyC(Connections, EMHCj75rP65lIlOlCTNm(account)))).AV9aQ6MXMs8(symbol.ID));
				}
				goto IL_0024;
			case 1:
				{
					if (symbol != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0024;
				}
				IL_0024:
				return 0;
			}
		}
	}

	public static bool IsTradeAllowed(UserPosition position)
	{
		int num = 4;
		int num2 = num;
		Account account = default(Account);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return false;
			case 1:
				return true;
			case 4:
				if (position == null)
				{
					obj = null;
					goto IL_0111;
				}
				num2 = 3;
				break;
			case 2:
				if (Fs2qec5rzPHBFnXqJHkO(position.Symbol, account) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				{
					obj = position.AccountID;
					goto IL_0111;
				}
				IL_0111:
				if (!YRswM25r35nMh90f84K4(obj))
				{
					account = (Account)LitEcB5rpbuV63ZN71XZ(position.AccountID);
					if (account == null)
					{
						return true;
					}
					if (aZ5YGN5rupeXwj4VbZu4(account.Connection.TradeClientName, qQ7OmW5rs4wc5Jse6eY6(-2017337494 ^ -2017362794)) && GetUserPositionsCount(position.Symbol, account) > 1)
					{
						return false;
					}
					if (account.HedgeMode)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static bool IsTradeAllowed(Symbol symbol)
	{
		if (!qdPMfa5K0W4dEvoltF7E() && !Simulator)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (symbol == null || !symbol.IsSplicedFutures)
					{
						break;
					}
					goto case 2;
				case 2:
					if (!hqGhwZ5K2HppcH75WhgB(symbol))
					{
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				default:
					return false;
				}
				break;
			}
		}
		return true;
	}

	public static bool IsClientConnected(string connectionID)
	{
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
		if (adVNpgG79ErxvcbgBD1J != null)
		{
			return G8svQm5rMn2WXfMujFb9(KlqRyB5rOueDanU1Og57(adVNpgG79ErxvcbgBD1J));
		}
		return false;
	}

	public static void ClientConnect(string connectionID)
	{
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
		if (adVNpgG79ErxvcbgBD1J == null)
		{
			return;
		}
		if (Player)
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
				{
					Action<ConnectionInfo, string> onError = DataManager.OnError;
					if (onError == null)
					{
						return;
					}
					onError((ConnectionInfo)KlqRyB5rOueDanU1Og57(adVNpgG79ErxvcbgBD1J), Resources.CommonUnableConnectinPlayer);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
					{
						num = 1;
					}
					continue;
				}
				case 2:
					break;
				}
				if (!Simulator)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
				{
					num = 0;
				}
			}
		}
		adVNpgG79ErxvcbgBD1J.lihlfMp6ULY();
	}

	public static void ClientDisconnect(string connectionID)
	{
		((AdVNpgG79ErxvcbgBD1J)jsO7805rCyeG0XKO8MyC(Connections, connectionID))?.EL3lnODvZSu();
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
		if (adVNpgG79ErxvcbgBD1J == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
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
			adVNpgG79ErxvcbgBD1J.Disconnect();
		}
	}

	internal static gpnr5oG8Q1cRMmiYT0Ut GetClientSettings(string connectionId)
	{
		return Connections.Get(connectionId)?.LSslYPBx4Vu;
	}

	internal static qXLXHlax25yCgG9femcG GetClientProxy(string connectionId)
	{
		C3trUsajJIHJMtdo9pBg c3trUsajJIHJMtdo9pBg = GetClientSettings(connectionId)?.j6RloBnORGD();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (c3trUsajJIHJMtdo9pBg != null)
			{
				return rwlc60axdATOINfnxFFP.JYhaxV3KmOl().O6CaxthB4xR(c3trUsajJIHJMtdo9pBg.Id);
			}
			return null;
		}
	}

	internal static void SetClientProxy(qXLXHlax25yCgG9femcG proxyData, string connectionId)
	{
		int num = 1;
		int num2 = num;
		C3trUsajJIHJMtdo9pBg c3trUsajJIHJMtdo9pBg = default(C3trUsajJIHJMtdo9pBg);
		while (true)
		{
			switch (num2)
			{
			case 1:
				c3trUsajJIHJMtdo9pBg = C3trUsajJIHJMtdo9pBg.A9lajpTRHI3(proxyData);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				gpnr5oG8Q1cRMmiYT0Ut clientSettings = GetClientSettings(connectionId);
				clientSettings?.krqloaeIlq6(c3trUsajJIHJMtdo9pBg);
				clientSettings?.gpqG8g0ePAk();
				return;
			}
			}
		}
	}

	public static void ClientPlaceOrder(Order order)
	{
		if (order?.Account == null)
		{
			return;
		}
		int num;
		if (order != null)
		{
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		object obj = null;
		goto IL_00f4;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				break;
			case 0:
				return;
			case 1:
				goto IL_0068;
			case 2:
				goto end_IL_0009;
			case 4:
				return;
			}
			Action<ConnectionInfo, string> onError = DataManager.OnError;
			if (onError == null)
			{
				num = 4;
				continue;
			}
			onError((ConnectionInfo)EQFegf5K91BNiIqEEyck(order), Resources.CommonCanNotTradeSlicedFutures);
			return;
			IL_0068:
			if (!IsTradeAllowed((Symbol)YtO2Kj5KfmEt46VmAEHJ(order)))
			{
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num = 3;
				}
				continue;
			}
			goto IL_012f;
			continue;
			end_IL_0009:
			break;
		}
		obj = order.Account;
		goto IL_00f4;
		IL_00f4:
		if (XKwI3tY0nucYTgRjk1NJ.D91Y0YYo7tX((Account)obj))
		{
			if (!((Account)ELY6vg5KHf0mfkEKFlCB(order)).IsLive)
			{
				goto IL_012f;
			}
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_012f:
		Connections.Get(order.Account.ConnectionID)?.rXVlY5KWTqS(order);
	}

	public static void ClientModifyOrder(Order order)
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
			case 1:
				obj = null;
				break;
			case 0:
				return;
			case 2:
				if (order == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = order.Account;
				break;
			}
			if (obj != null)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
			{
				num2 = 0;
			}
		}
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(((Account)ELY6vg5KHf0mfkEKFlCB(order)).ConnectionID);
		if (adVNpgG79ErxvcbgBD1J != null)
		{
			GpWqnx5Kn28UIlFQgly1(adVNpgG79ErxvcbgBD1J, order);
		}
	}

	public static void ClientCancelAllOrder(params Order[] orders)
	{
		int num = 5;
		int num2 = num;
		Order order = default(Order);
		while (true)
		{
			object obj3;
			object obj2;
			Account obj;
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				obj3 = null;
				goto IL_00a3;
			case 3:
				obj2 = null;
				goto IL_00c6;
			case 1:
				if (order == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				obj2 = order.Account;
				goto IL_00c6;
			case 5:
				if (orders == null)
				{
					num2 = 4;
					continue;
				}
				obj3 = orders.FirstOrDefault();
				goto IL_00a3;
			case 2:
				{
					obj = order?.Account;
					break;
				}
				IL_00c6:
				if (obj2 != null)
				{
					num2 = 2;
					continue;
				}
				return;
				IL_00a3:
				order = (Order)obj3;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			if (!XKwI3tY0nucYTgRjk1NJ.D91Y0YYo7tX(obj))
			{
				break;
			}
			object obj4 = jsO7805rCyeG0XKO8MyC(Connections, ((Account)ELY6vg5KHf0mfkEKFlCB(order)).ConnectionID);
			if (obj4 == null)
			{
				break;
			}
			((AdVNpgG79ErxvcbgBD1J)obj4).ddu5DfYWQWg(orders);
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
			{
				num2 = 0;
			}
		}
	}

	public static void ClientCancelOrder(Order order)
	{
		if (order?.Account == null)
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
		{
			num = 1;
		}
		while (true)
		{
			object obj2;
			switch (num)
			{
			default:
				return;
			case 3:
				obj2 = null;
				goto IL_00eb;
			case 0:
				return;
			case 1:
				if (order == null)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
					{
						num = 3;
					}
					break;
				}
				obj2 = order.Account;
				goto IL_00eb;
			case 2:
				{
					if (G8svQm5rMn2WXfMujFb9(stj8vR5KGQwcIR0IkrLV(ELY6vg5KHf0mfkEKFlCB(order))))
					{
						object obj = jsO7805rCyeG0XKO8MyC(Connections, order.Account.ConnectionID);
						if (obj != null)
						{
							f56Aqm5KYxtp2C3k1MlO(obj, order);
						}
						return;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
					{
						num = 0;
					}
					break;
				}
				IL_00eb:
				if (!XKwI3tY0nucYTgRjk1NJ.D91Y0YYo7tX((Account)obj2))
				{
					return;
				}
				num = 2;
				break;
			}
		}
	}

	private static void ClientCancelAllOrders(params Order[] orders)
	{
		IEnumerator<IGrouping<Account, Order>> enumerator = (from g in orders
			where lQdg1kaRWHWKGyuJA0w9.Gxj7gZx3okPliV20yS77(g) != null
			group g by g.Account).GetEnumerator();
		try
		{
			IGrouping<Account, Order> current = default(IGrouping<Account, Order>);
			while (true)
			{
				int num2;
				if (!o7uk0U5KvjAWcM8EC2Lr(enumerator))
				{
					int num = 2;
					num2 = num;
					goto IL_0029;
				}
				goto IL_009b;
				IL_0029:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_009b;
				case 2:
					return;
				}
				if (jvnAIi5KoEF9eGHv57N6(current.Key))
				{
					Connections.Get((string)EMHCj75rP65lIlOlCTNm(current.Key))?.ddu5DfYWQWg(current.ToArray());
				}
				continue;
				IL_009b:
				current = enumerator.Current;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
				{
					num2 = 1;
				}
				goto IL_0029;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				LOOeJ35r6PMrSTdCb7x7(enumerator);
			}
		}
	}

	public static void ClientCancelAllOrders(OrderGroup group)
	{
		int num = 1;
		int num2 = num;
		Order[] array = default(Order[]);
		Order[] array2 = default(Order[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!iZjbiJ5rmZIumNebPjKI())
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
			{
				foreach (Order item in ((Orders)ar6oWh5KBeHClKijJJVs(GetSimConnection())).VlLaQixssUY(group, (string)null))
				{
					item.CancelInitiator = (string)qQ7OmW5rs4wc5Jse6eY6(0x2C8374E4 ^ 0x2C83ABA6);
					item.SlTpClose = true;
					dBRjlf5KawE59htEdubv(item);
				}
				return;
			}
			}
			using IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator2 = (from c in Connections.GetAll(isConnected: true)
				where !c.mWXlYwTb86e.Simulator
				select c).GetEnumerator();
			while (true)
			{
				int num3;
				if (!enumerator2.MoveNext())
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
					{
						num3 = 0;
					}
					goto IL_004c;
				}
				goto IL_00ad;
				IL_0143:
				dBRjlf5KawE59htEdubv(array[0]);
				continue;
				IL_00db:
				ClientCancelAllOrders(array);
				continue;
				IL_00ad:
				array = ((Orders)ar6oWh5KBeHClKijJJVs(enumerator2.Current)).VlLaQixssUY(group, (string)null).ToArray();
				num3 = 2;
				goto IL_004c;
				IL_004c:
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 3:
						break;
					case 1:
						goto end_IL_004c;
					case 2:
						array2 = array;
						num4 = 0;
						num3 = 3;
						continue;
					case 4:
						goto IL_0143;
					case 0:
						return;
					}
					for (; num4 < array2.Length; num4++)
					{
						Order obj = array2[num4];
						obj.CancelInitiator = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6AB40973 ^ 0x6AB4D631);
						i9MSNY5KiPO2EWAe6KjR(obj, true);
					}
					if (array.Length == 1)
					{
						int num5 = 4;
						num3 = num5;
						continue;
					}
					goto IL_00db;
					continue;
					end_IL_004c:
					break;
				}
				goto IL_00ad;
			}
		}
	}

	public static void ClientUpdateUserPosition(UserPositionData position)
	{
		if (position == null || !XKwI3tY0nucYTgRjk1NJ.YZ2Y0oSIoZq(position))
		{
			return;
		}
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(position.ConnectionID);
		int num;
		if (adVNpgG79ErxvcbgBD1J == null)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
			{
				num = 1;
			}
		}
		else
		{
			pbrn5l5KlQDnR4iSj1Sp(adVNpgG79ErxvcbgBD1J, position);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
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

	public static void ClientRequestTicks(Symbol symbol, string requestID, string targetID, bool customData)
	{
		if (symbol == null || YRswM25r35nMh90f84K4(requestID))
		{
			return;
		}
		int num;
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = default(IEnumerator<AdVNpgG79ErxvcbgBD1J>);
		if (qdPMfa5K0W4dEvoltF7E())
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
			{
				num = 1;
			}
		}
		else
		{
			enumerator = (from connection in Connections.GetAll()
				where connection.mWXlYwTb86e.MarketData
				select connection).GetEnumerator();
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			APF9Ou5K4p7cFGSitwd3(GetSimConnection(), new TicksRequest(symbol, requestID, targetID, customData));
			return;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				APF9Ou5K4p7cFGSitwd3(enumerator.Current, new TicksRequest(symbol, requestID, targetID, customData));
			}
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 0:
				break;
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
	}

	public static List<Order> GetOrders(Symbol symbol, Account account)
	{
		if (symbol == null || account == null)
		{
			return null;
		}
		return Connections.Get(account.ConnectionID)?.yuplYRm5htt.WhJaQBZfeMq(symbol.GetSymbol(), account);
	}

	internal static List<Order> GetOrders(string trustID)
	{
		List<Order> list = new List<Order>();
		if (string.IsNullOrEmpty(trustID))
		{
			return list;
		}
		foreach (AdVNpgG79ErxvcbgBD1J item in Connections.GetAll())
		{
			if (!item.mWXlYwTb86e.Trust)
			{
				list.AddRange(item.yuplYRm5htt.LHmaQasmvtB(trustID));
			}
		}
		return list;
	}

	public static List<Execution> GetExecutions(Symbol symbol, Account account)
	{
		if (symbol == null || account == null)
		{
			return null;
		}
		return Connections.Get(account.ConnectionID)?.NtFlYMnmNgk.oqbaQuGWZjD(symbol.GetSymbol(), account);
	}

	public static int GetOrdersCount()
	{
		return (from c in Connections.GetAll()
			where !c.mWXlYwTb86e.Simulator
			select c).Sum((AdVNpgG79ErxvcbgBD1J connection) => ((Orders)lQdg1kaRWHWKGyuJA0w9.CvhG4ix3vcSAsM6G6Yar(connection)).VlLaQixssUY(OrderGroup.All, (string)null).Count);
	}

	public static int GetOrdersCountWithMode()
	{
		if (!Player)
		{
			if (!Simulator)
			{
				return (from c in Connections.GetAll()
					where ((ConnectionInfo)lQdg1kaRWHWKGyuJA0w9.w9ENsRx3fio1ks4kd7ou(c)).IsConnected && !((ConnectionInfo)lQdg1kaRWHWKGyuJA0w9.w9ENsRx3fio1ks4kd7ou(c)).Simulator
					select c).Sum((AdVNpgG79ErxvcbgBD1J connection) => ((Orders)lQdg1kaRWHWKGyuJA0w9.CvhG4ix3vcSAsM6G6Yar(connection)).VlLaQixssUY(OrderGroup.All, (string)null).Count);
			}
			if (iZjbiJ5rmZIumNebPjKI())
			{
				return GetSimConnection().yuplYRm5htt.VlLaQixssUY(OrderGroup.All).Count((Order w) => !w.Account.IsPlayer);
			}
			return xqawyr5KD4VctcRl7cAm();
		}
		return ((AdVNpgG79ErxvcbgBD1J)HUc7nX5rtNTpALYNUmHm()).yuplYRm5htt.VlLaQixssUY(OrderGroup.All).Count((Order w) => lQdg1kaRWHWKGyuJA0w9.B8Ifg0x3BEQPJeyQBL22(w.Account));
	}

	public static int GetPositionsCount()
	{
		return (from c in Connections.GetAll()
			where !c.mWXlYwTb86e.Simulator
			select c).Sum((AdVNpgG79ErxvcbgBD1J connection) => connection.mxqlYWdjLU2.GetAll().Count((UserPosition p) => p.Size != 0));
	}

	public static void SyncSlTp()
	{
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = Connections.GetAll().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				hLVnrV5KbYR15YAXArXL(enumerator.Current);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				LOOeJ35r6PMrSTdCb7x7(enumerator);
			}
		}
	}

	public static void LoadTrustAccounts(List<TrustAccount> accounts)
	{
		(GetTrustConnection() as XV7Dh4Y55scSeUkkg5qt)?.vCvY5x2RNiB(accounts);
	}

	public static void SetTradeMode(int tradeMode, bool init)
	{
		if (tradeMode == TradeMode)
		{
			return;
		}
		TradeMode = tradeMode;
		bool flag = false;
		int num;
		if (tradeMode != 1)
		{
			if (tradeMode == 2)
			{
				goto IL_00cc;
			}
			num = 6;
		}
		else
		{
			SeEJmP5KNi3n4GSRMEcP(value: true);
			Player = false;
			flag = true;
			num = 8;
		}
		goto IL_0009;
		IL_00cc:
		Simulator = true;
		aKicIp5K1t5P4m4NDttP(value: true);
		IdsConnection.Clear();
		num = 12;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
		{
			num = 6;
		}
		goto IL_0009;
		IL_0009:
		List<Symbol>.Enumerator enumerator = default(List<Symbol>.Enumerator);
		while (true)
		{
			int num2;
			Action onUpdateAccount;
			switch (num)
			{
			default:
				return;
			case 8:
				Y1uhY45Kk5BbGALiBS6P();
				num = 10;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
				{
					num = 3;
				}
				continue;
			case 4:
				return;
			case 12:
				foreach (AdVNpgG79ErxvcbgBD1J item in Connections.GetAll())
				{
					int num4;
					if (item.mWXlYwTb86e.IsConnecting)
					{
						num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
						{
							num4 = 0;
						}
						goto IL_011d;
					}
					goto IL_014e;
					IL_011d:
					switch (num4)
					{
					case 2:
						goto IL_014e;
					}
					IdsConnection.Add(((ConnectionInfo)KlqRyB5rOueDanU1Og57(item)).ConnectionID);
					CiFqVM5KSVKGElgl5ckN(item);
					continue;
					IL_014e:
					if (!l56U6K5K5awpq0GqPVk5(item.mWXlYwTb86e))
					{
						continue;
					}
					num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
					{
						num4 = 1;
					}
					goto IL_011d;
				}
				goto case 10;
			case 1:
				Y1uhY45Kk5BbGALiBS6P();
				goto case 10;
			case 3:
				break;
			case 6:
			case 7:
				Simulator = false;
				num2 = 5;
				goto IL_0005;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						Symbol current = enumerator.Current;
						if (MaK9GV5KxOMJnxMSWHJM(current) != SymbolType.Future)
						{
							continue;
						}
						int num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (QnJrU55KL9lcufVlhsea(current))
								{
									num3 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							default:
								current.UpdateCurrentContract(A4diRa5KeOOysSModMxO(current.Exchange));
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
				goto IL_0047;
			case 10:
				if (init)
				{
					return;
				}
				if (flag)
				{
					num = 9;
					continue;
				}
				goto IL_0047;
			case 11:
			{
				Action onUpdateFilters = DataManager.OnUpdateFilters;
				if (onUpdateFilters == null)
				{
					return;
				}
				OLdRap5KsBsU50p1p7MF(onUpdateFilters);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
				{
					num = 0;
				}
				continue;
			}
			case 9:
				enumerator = SymbolManager.GetAll().GetEnumerator();
				num2 = 2;
				goto IL_0005;
			case 0:
				return;
			case 5:
				{
					Player = false;
					flag = true;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
					{
						num = 1;
					}
					continue;
				}
				IL_0047:
				DataManager.OnClearMarket?.Invoke();
				onUpdateAccount = DataManager.OnUpdateAccount;
				if (onUpdateAccount == null)
				{
					num = 11;
					continue;
				}
				onUpdateAccount();
				goto case 11;
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		goto IL_00cc;
	}

	public static bool FilterAccount(Account account)
	{
		return FilterAccount(account.AccountID);
	}

	public static bool FilterAccount(string accountID)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return true;
				case 3:
					if (Player && md9L545KXSXnXsrqrFJ7(accountID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--855742383 ^ 0x33013173)))
					{
						return true;
					}
					return false;
				case 1:
					if (Simulator)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return !accountID.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F645F3C ^ 0x7F648044));
				default:
					if (qdPMfa5K0W4dEvoltF7E())
					{
						break;
					}
					if (accountID.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962634911)))
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			num = 3;
		}
	}

	public static void ClientTransferFunds(string connectionID, yBkHHnoFRLCqi3Cf0Cg9 transferParams)
	{
		AdVNpgG79ErxvcbgBD1J adVNpgG79ErxvcbgBD1J = Connections.Get(connectionID);
		if (adVNpgG79ErxvcbgBD1J != null)
		{
			Uy43FB5Kc9JLB5I1uXZo(adVNpgG79ErxvcbgBD1J, transferParams);
		}
	}

	internal static void GuiAsync(Action action)
	{
		int num = 3;
		int num2 = num;
		Dispatcher dispatcher = default(Dispatcher);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (dispatcher != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			default:
				if (!xxbrkb5KjcocsNEL6w2W(dispatcher))
				{
					if (dispatcher.CheckAccess())
					{
						OLdRap5KsBsU50p1p7MF(action);
					}
					else
					{
						dispatcher.BeginInvoke(action);
					}
				}
				return;
			case 3:
			{
				Application current = Application.Current;
				if (current == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num2 = 2;
					}
					continue;
				}
				obj = current.Dispatcher;
				break;
			}
			case 2:
				obj = null;
				break;
			}
			dispatcher = (Dispatcher)obj;
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static void AutoConnect()
	{
		using IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = (from connection in Connections.GetAll()
			orderby connection.o6ElY3YBWqG()
			select connection).GetEnumerator();
		while (o7uk0U5KvjAWcM8EC2Lr(enumerator))
		{
			enumerator.Current.AutoConnect();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
	}

	internal static AdVNpgG79ErxvcbgBD1J[] GetMarketDataConnections(string symbolId)
	{
		hDRuxva6dmLlOmcge4ql CS_0024_003C_003E8__locals2 = new hDRuxva6dmLlOmcge4ql();
		CS_0024_003C_003E8__locals2.oxHa6R0Lpvd = symbolId;
		return (from c in Connections.GetAll()
			where hDRuxva6dmLlOmcge4ql.TbdROYx3jF3KBRalxj7Z(c.NGZlYyv6dJg, CS_0024_003C_003E8__locals2.oxHa6R0Lpvd) != null
			select c).ToArray();
	}

	public static void SetPositionPriceStrategy(int strategy)
	{
		lsawIP5KQusTNWfCdWO0(EJMxQ95KErpyAqnVEPKL(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x404ED0BE ^ 0x404E0F10), UserPosition.GetPriceStrategyName((ApidlOGpzEFH7ruf5jBr)strategy)));
		IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = Connections.GetAll().GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.aJQlYj1h7or((ApidlOGpzEFH7ruf5jBr)strategy);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
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
				LOOeJ35r6PMrSTdCb7x7(enumerator);
			}
		}
	}

	internal static bool o9BgBT5r5eVvriAOIg8q()
	{
		return sUjh1d5r1uQeFeFWfXmM == null;
	}

	internal static DataManager YnG3Sq5rS94vpaF8vnDI()
	{
		return sUjh1d5r1uQeFeFWfXmM;
	}

	internal static object bH09KU5rxBDWcJ45kKlV(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object vijp7J5rLc4dTfIOp05L(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void tYSZne5reOsQSgYqAU7L()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object qQ7OmW5rs4wc5Jse6eY6(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void BFTL4a5rXIC31fDFRX9N(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void mjoPw85rcCEcLLUGZfw1(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static int Pw6hTK5rjNS8vrFtehVM(object P_0)
	{
		return ((Queue<anI4lfGJ8TTwhTlujQ36>)P_0).Count;
	}

	internal static iK1S7sajLQV8P7VTMdUU LIMYYC5rEoDVDFnfSmjE(object P_0)
	{
		return ((QO3Z1DajgOh2CTyqOCfs)P_0).Type;
	}

	internal static object nX7xPe5rQWIw06guyw4E(object P_0)
	{
		return ((QO3Z1DajgOh2CTyqOCfs)P_0).h1FajMUlcly();
	}

	internal static object mHo0qv5rd9o2KL3lt7RH(object P_0)
	{
		return ((QJKLHqY0TN2le5RyfwYX)P_0).Info;
	}

	internal static object hIs55B5rgild5CXPW2gf(object P_0)
	{
		return ((QJKLHqY0TN2le5RyfwYX)P_0).Message;
	}

	internal static int qIBpuj5rRorHnHE7eMam(object P_0)
	{
		return ((Queue<QO3Z1DajgOh2CTyqOCfs>)P_0).Count;
	}

	internal static void LOOeJ35r6PMrSTdCb7x7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool G8svQm5rMn2WXfMujFb9(object P_0)
	{
		return ((ConnectionInfo)P_0).IsConnected;
	}

	internal static object KlqRyB5rOueDanU1Og57(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).mWXlYwTb86e;
	}

	internal static object L3JAFs5rqoBkrOwEexSu(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectionID;
	}

	internal static void HNEgIi5rIQvA3LMAcOew(object P_0, object P_1)
	{
		((Connections)P_0).Remove((string)P_1);
	}

	internal static object wiSrMe5rWF36WChDVdUQ(object P_0)
	{
		return ((Symbol)P_0).GetSymbol();
	}

	internal static object HUc7nX5rtNTpALYNUmHm()
	{
		return GetSimConnection();
	}

	internal static object xj6I8I5rUKvYcXXyl0EC(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).TnYlYCCpDAI();
	}

	internal static object fZMm9S5rTsIGcBrg5tB2(object P_0, object P_1)
	{
		return ((MarketDepth)P_0).GetEvent((Symbol)P_1);
	}

	internal static void PIQac25ryAoSMnopwj1F(object P_0, object P_1)
	{
		EnqueueMarketEvent((ConnectionInfo)P_0, (anI4lfGJ8TTwhTlujQ36)P_1);
	}

	internal static object qCK02P5rZcfaiKWrT3TM(object P_0, object P_1)
	{
		return ((Security)P_0).GetEvent((Symbol)P_1);
	}

	internal static bool yJ80yG5rVsniAUbfMXkF(object P_0, object P_1, object P_2)
	{
		return ((K8qrSoGhl2LgcSAFZZIZ)P_0).a1SGhDw5nBC((ConnectionInfo)P_1, (anI4lfGJ8TTwhTlujQ36)P_2);
	}

	internal static object jsO7805rCyeG0XKO8MyC(object P_0, object P_1)
	{
		return ((Connections)P_0).Get((string)P_1);
	}

	internal static object lkT8MK5rrZcCsRjfCR0A(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).PK9lYTkx6L9();
	}

	internal static bool QJj9I45rKocfPNqZ9BOY(object P_0)
	{
		return ((Symbol)P_0).IsBitget;
	}

	internal static bool iZjbiJ5rmZIumNebPjKI()
	{
		return Simulator;
	}

	internal static object X2vFbu5rhRGqcXWNVe0u(object P_0)
	{
		return Account.GetConnectionID((string)P_0);
	}

	internal static object me63bw5rwgYA2LSEOpgm(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).m3jlYd926hA;
	}

	internal static object PuVk4r5r7qYDwBvnRc3G(object P_0, object P_1)
	{
		return ((Accounts)P_0).N07aELTPF6E((string)P_1);
	}

	internal static object RHHrk15r8iZ96m0R2UTG(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).mxqlYWdjLU2;
	}

	internal static object vfIl8D5rAPjrDKheNBlZ(object P_0, object P_1, object P_2)
	{
		return ((UserPositions)P_0).Get((Symbol)P_1, (Account)P_2);
	}

	internal static object EMHCj75rP65lIlOlCTNm(object P_0)
	{
		return ((Account)P_0).ConnectionID;
	}

	internal static object Dojej75rJrSA795ZZw7R(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).FxalYqgjyul;
	}

	internal static int RqVZoC5rF1JeoS6FfVp9(object P_0)
	{
		return ((List<Position>)P_0).Count;
	}

	internal static bool YRswM25r35nMh90f84K4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object LitEcB5rpbuV63ZN71XZ(object P_0)
	{
		return GetAccount((string)P_0);
	}

	internal static bool aZ5YGN5rupeXwj4VbZu4(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int Fs2qec5rzPHBFnXqJHkO(object P_0, object P_1)
	{
		return GetUserPositionsCount((Symbol)P_0, (Account)P_1);
	}

	internal static bool qdPMfa5K0W4dEvoltF7E()
	{
		return Player;
	}

	internal static bool hqGhwZ5K2HppcH75WhgB(object P_0)
	{
		return ((Symbol)P_0).IsMoex;
	}

	internal static object ELY6vg5KHf0mfkEKFlCB(object P_0)
	{
		return ((Order)P_0).Account;
	}

	internal static object YtO2Kj5KfmEt46VmAEHJ(object P_0)
	{
		return ((Order)P_0).Symbol;
	}

	internal static object EQFegf5K91BNiIqEEyck(object P_0)
	{
		return ((Order)P_0).Connection;
	}

	internal static void GpWqnx5Kn28UIlFQgly1(object P_0, object P_1)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).QCGlYSKmhRh((Order)P_1);
	}

	internal static object stj8vR5KGQwcIR0IkrLV(object P_0)
	{
		return ((Account)P_0).Connection;
	}

	internal static void f56Aqm5KYxtp2C3k1MlO(object P_0, object P_1)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).f10lYxo1VNk((Order)P_1);
	}

	internal static bool jvnAIi5KoEF9eGHv57N6(object P_0)
	{
		return XKwI3tY0nucYTgRjk1NJ.D91Y0YYo7tX((Account)P_0);
	}

	internal static bool o7uk0U5KvjAWcM8EC2Lr(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object ar6oWh5KBeHClKijJJVs(object P_0)
	{
		return ((AdVNpgG79ErxvcbgBD1J)P_0).yuplYRm5htt;
	}

	internal static void dBRjlf5KawE59htEdubv(object P_0)
	{
		ClientCancelOrder((Order)P_0);
	}

	internal static void i9MSNY5KiPO2EWAe6KjR(object P_0, bool value)
	{
		((Order)P_0).SlTpClose = value;
	}

	internal static void pbrn5l5KlQDnR4iSj1Sp(object P_0, object P_1)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).KbclYLp5CIy((UserPositionData)P_1);
	}

	internal static void APF9Ou5K4p7cFGSitwd3(object P_0, object P_1)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).PnDlYXj2m35((TicksRequest)P_1);
	}

	internal static int xqawyr5KD4VctcRl7cAm()
	{
		return GetOrdersCount();
	}

	internal static void hLVnrV5KbYR15YAXArXL(object P_0)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).Xi7lYcLJWLY();
	}

	internal static void SeEJmP5KNi3n4GSRMEcP(bool value)
	{
		Simulator = value;
	}

	internal static void Y1uhY45Kk5BbGALiBS6P()
	{
		RestoreConnections();
		static void RestoreConnections()
		{
			if (umKjPr5KdblWDXeZPP0L(IdsConnection) != 0)
			{
				IEnumerator<AdVNpgG79ErxvcbgBD1J> enumerator = IdsConnection.Select((string id) => Connections.Get(id)).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						AdVNpgG79ErxvcbgBD1J current = enumerator.Current;
						if (current == null)
						{
							int num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
							{
								num = 0;
							}
							switch (num)
							{
							}
						}
						else
						{
							current.lihlfMp6ULY();
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						LOOeJ35r6PMrSTdCb7x7(enumerator);
					}
				}
			}
			BhTTO65Kg4Q6eCNlDUbv(IdsConnection);
		}
	}

	internal static void aKicIp5K1t5P4m4NDttP(bool value)
	{
		Player = value;
	}

	internal static bool l56U6K5K5awpq0GqPVk5(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectState;
	}

	internal static void CiFqVM5KSVKGElgl5ckN(object P_0)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).Disconnect();
	}

	internal static SymbolType MaK9GV5KxOMJnxMSWHJM(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static bool QnJrU55KL9lcufVlhsea(object P_0)
	{
		return ((Symbol)P_0).IsMaster;
	}

	internal static DateTime A4diRa5KeOOysSModMxO(object P_0)
	{
		return TimeHelper.GetCurrDate((string)P_0);
	}

	internal static void OLdRap5KsBsU50p1p7MF(object P_0)
	{
		P_0();
	}

	internal static bool md9L545KXSXnXsrqrFJ7(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static void Uy43FB5Kc9JLB5I1uXZo(object P_0, object P_1)
	{
		((AdVNpgG79ErxvcbgBD1J)P_0).BuT5D9ShyPN((yBkHHnoFRLCqi3Cf0Cg9)P_1);
	}

	internal static bool xxbrkb5KjcocsNEL6w2W(object P_0)
	{
		return ((Dispatcher)P_0).HasShutdownStarted;
	}

	internal static object EJMxQ95KErpyAqnVEPKL(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void lsawIP5KQusTNWfCdWO0(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static int umKjPr5KdblWDXeZPP0L(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void BhTTO65Kg4Q6eCNlDUbv(object P_0)
	{
		((List<string>)P_0).Clear();
	}
}
