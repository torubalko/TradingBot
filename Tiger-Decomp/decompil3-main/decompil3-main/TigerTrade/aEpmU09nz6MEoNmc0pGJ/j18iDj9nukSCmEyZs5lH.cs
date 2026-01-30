using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Windows.Themes;
using ActiproSoftware.Windows.Themes.Generation;
using aeXChk9vAhkf7Zm8SpOk;
using AMj7i59xpIF2mbHGTtbm;
using bl7Or1fDrLHNeTtGhT82;
using DQIo3790ym4PqFa5dl3o;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using gcAbRF916T4NoamN5KIq;
using Ji6wvg9k3QpQZWdR8bsf;
using jS3Y2j9pTQRy0FnOknFG;
using NHkZqbf77HnCtq0ER8ta;
using nwrd0o9063oan8ctC0ZK;
using OuMGRfHbB3V7u7Da4hq3;
using pt0FBR91ItQpvpimPGdP;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.List;
using TigerTrade.Config;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.DocControls.Charting.Settings;
using TigerTrade.UI.DocControls.Trading.Settings;
using TU1GsM2Dm9QaIaTGcmUQ;
using TuAMtrl1Nd3XoZQQUXf0;
using UQo6BdfP2mN8TGiUMEQT;
using vwaruI999smF85ZbYXcY;
using xfdMo0lS4TP9pN36Goka;
using XFouJw91ETyLclFXBXxS;
using zkHtNg9fImUaeO7bxwVW;
using zlck9A92XhonsRBe1pDI;

namespace aEpmU09nz6MEoNmc0pGJ;

internal static class j18iDj9nukSCmEyZs5lH
{
	[Serializable]
	[CompilerGenerated]
	private sealed class z6g3k4nJPkZbJycYKQLD
	{
		public static readonly z6g3k4nJPkZbJycYKQLD UQpnJ3BhIgh;

		public static Func<FileInfo, DateTime> Q7NnJpjpfyq;

		public static Func<FileInfo, DateTime> ImAnJuifwGg;

		private static z6g3k4nJPkZbJycYKQLD lsLdfsNOpc2WGZMVDANN;

		static z6g3k4nJPkZbJycYKQLD()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			UQpnJ3BhIgh = new z6g3k4nJPkZbJycYKQLD();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public z6g3k4nJPkZbJycYKQLD()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal DateTime dfXnJJDiVH9(FileInfo file)
		{
			return file.CreationTime;
		}

		internal DateTime BdxnJFa3tR2(FileInfo file)
		{
			return nQt17RNq0YsrP59x928i(file);
		}

		internal static bool qeVe68NOu25dkWhSBZHZ()
		{
			return lsLdfsNOpc2WGZMVDANN == null;
		}

		internal static z6g3k4nJPkZbJycYKQLD WW16xlNOzoYmpTeXVK99()
		{
			return lsLdfsNOpc2WGZMVDANN;
		}

		internal static DateTime nQt17RNq0YsrP59x928i(object P_0)
		{
			return ((FileSystemInfo)P_0).CreationTime;
		}
	}

	[CompilerGenerated]
	private sealed class Ay9adxnJzQvQjWm2Y12g
	{
		public string aOQnF2BbE1d;

		public Func<ObjectBase, bool> rVmnFHC81IL;

		internal static Ay9adxnJzQvQjWm2Y12g aZHcWJNq2jxUESimelME;

		public Ay9adxnJzQvQjWm2Y12g()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool wQenF028xZ7(ObjectBase obj)
		{
			if (obj is HorizontalLineObject)
			{
				return dMqwd0Nq90A2bt9tSyrW(obj.SymbolID, aOQnF2BbE1d);
			}
			return true;
		}

		static Ay9adxnJzQvQjWm2Y12g()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool vZ80WXNqHfea6Xg7ny6M()
		{
			return aZHcWJNq2jxUESimelME == null;
		}

		internal static Ay9adxnJzQvQjWm2Y12g hjsusRNqfHwdH0TNHSWr()
		{
			return aZHcWJNq2jxUESimelME;
		}

		internal static bool dMqwd0Nq90A2bt9tSyrW(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private static MhMDPU9v8rkigy1ao0Th e619oghYXRU;

	private static zObClP99fKcOtAs5v4hK IVG9oRYiCrK;

	private static oPtcN290TuwfxN9qnftN e2O9o6QysvL;

	private static lvva2q92sGGEos9amhJM DbN9oMFsMHE;

	private static u3qUF590RA7GwKS6JVMx aBL9oOpiqba;

	[CompilerGenerated]
	private static readonly string cOh9oqArUMe;

	[CompilerGenerated]
	private static readonly ServiceManagerServersConfig QgF9oIJkbtn;

	[CompilerGenerated]
	private static readonly string bnV9oWEWcNN;

	[CompilerGenerated]
	private static readonly string n359otcyBwH;

	[CompilerGenerated]
	private static readonly string gqp9oUO9mn4;

	[CompilerGenerated]
	private static readonly string rsr9oTppbiK;

	[CompilerGenerated]
	private static readonly string HLl9oyDuZj6;

	[CompilerGenerated]
	private static readonly string WxT9oZp9Inn;

	[CompilerGenerated]
	private static readonly string Qxr9oVEZOYn;

	[CompilerGenerated]
	private static readonly string t2T9oCXlbns;

	[CompilerGenerated]
	private static readonly string Ced9or1gC8j;

	[CompilerGenerated]
	private static readonly string ykp9oK5fGGI;

	[CompilerGenerated]
	private static readonly string wF99ompm7CY;

	[CompilerGenerated]
	private static readonly string Adu9oh1H8Qy;

	[CompilerGenerated]
	private static readonly string KAN9ow5AveD;

	[CompilerGenerated]
	private static readonly string WJ99o7P5NLY;

	[CompilerGenerated]
	private static readonly string gul9o8GBbWu;

	[CompilerGenerated]
	private static readonly string VvA9oAUhi9I;

	[CompilerGenerated]
	private static readonly string WQD9oPdafsg;

	[CompilerGenerated]
	private static readonly string wJp9oJLCDO5;

	[CompilerGenerated]
	private static readonly string zhE9oFUvAT9;

	[CompilerGenerated]
	private static readonly string PNf9o3dI4yx;

	[CompilerGenerated]
	private static readonly string V8K9opwAjVW;

	[CompilerGenerated]
	private static readonly string CNO9ou06sny;

	[CompilerGenerated]
	private static readonly string qCt9oztOcxG;

	[CompilerGenerated]
	private static readonly string i7p9v0b6iTH;

	[CompilerGenerated]
	private static readonly string K9f9v2qHGH1;

	[CompilerGenerated]
	private static readonly string jyn9vHxJSRV;

	[CompilerGenerated]
	private static readonly string sSf9vfk3wck;

	[CompilerGenerated]
	private static readonly string ITB9v9977Cn;

	[CompilerGenerated]
	private static readonly string f459vn7Natp;

	[CompilerGenerated]
	private static readonly string ohq9vGKctgI;

	[CompilerGenerated]
	private static readonly string Jk29vYD609F;

	[CompilerGenerated]
	private static readonly string jAQ9voZatfZ;

	[CompilerGenerated]
	private static readonly string JJC9vv0dWQQ;

	[CompilerGenerated]
	private static readonly string BLw9vBU1P9q;

	[CompilerGenerated]
	private static readonly string p5g9vawDY5p;

	[CompilerGenerated]
	private static readonly string uF29viDNPye;

	[CompilerGenerated]
	private static readonly string OoI9vlMDCEe;

	[CompilerGenerated]
	private static readonly string b409v4FByJu;

	[CompilerGenerated]
	private static readonly string fXI9vDY2uCD;

	[CompilerGenerated]
	private static readonly string XkG9vbg7hOC;

	[CompilerGenerated]
	private static readonly string GbG9vNTDysL;

	[CompilerGenerated]
	private static readonly string mvw9vki5ZcN;

	[CompilerGenerated]
	private static readonly string BmW9v10FKGD;

	[CompilerGenerated]
	private static readonly string K1C9v54j8Fw;

	[CompilerGenerated]
	private static readonly string SVW9vSKoRZ1;

	[CompilerGenerated]
	private static readonly string Nq69vxwOtct;

	[CompilerGenerated]
	private static readonly string xPZ9vLD7Qpi;

	[CompilerGenerated]
	private static readonly string N4h9vevbRot;

	[CompilerGenerated]
	private static readonly string KTv9vs68YgL;

	[CompilerGenerated]
	private static readonly string BkM9vXwk9h0;

	[CompilerGenerated]
	private static readonly string Sjm9vcHTu9i;

	[CompilerGenerated]
	private static readonly string NUW9vjlARSv;

	[CompilerGenerated]
	private static readonly string CUl9vExW3Di;

	[CompilerGenerated]
	private static readonly string sot9vQJrLnD;

	[CompilerGenerated]
	private static readonly string Ivi9vd4wsEE;

	[CompilerGenerated]
	private static readonly string Flp9vg1oF7k;

	[CompilerGenerated]
	private static readonly string KLQ9vRBrlKc;

	public static readonly string Uoh9v6fS7bO;

	public static readonly string Wed9vMLTjki;

	public static readonly int N259vOnrlKI;

	public static readonly bool VUi9vquhfBp;

	public static readonly bool IV49vI1ywq5;

	public static readonly bool XGg9vWgMCmU;

	public static readonly bool aWs9vtQlOlv;

	public static readonly bool nUi9vUo9G42;

	public static readonly string vJb9vT64tbL;

	public static readonly string NVB9vyCl7LX;

	public static readonly string eFU9vZ5IPof;

	public static readonly string Hru9vVBmt3t;

	public static readonly string q0E9vCePlgg;

	public static readonly int c7J9vrcQKpk;

	public static readonly int rUD9vKWYEeL;

	public static readonly int SaK9vmwSo4g;

	public static readonly ResourceKey[] K1N9vhmtwut;

	public static readonly ResourceKey[] LSm9vwU4f0G;

	[CompilerGenerated]
	private static byte[] Xdc9v7NFYWv;

	private static j18iDj9nukSCmEyZs5lH DpfvDWbN3A4E4m8nAXj8;

	public static MhMDPU9v8rkigy1ao0Th Settings
	{
		get
		{
			return e619oghYXRU ?? (e619oghYXRU = new MhMDPU9v8rkigy1ao0Th());
		}
		private set
		{
			e619oghYXRU = mhMDPU9v8rkigy1ao0Th;
		}
	}

	[SpecialName]
	public static zObClP99fKcOtAs5v4hK lmf9GS9l7aG()
	{
		return IVG9oRYiCrK ?? (IVG9oRYiCrK = new zObClP99fKcOtAs5v4hK());
	}

	[SpecialName]
	public static void JrL9GxHF3Ki(zObClP99fKcOtAs5v4hK P_0)
	{
		IVG9oRYiCrK = P_0;
	}

	[SpecialName]
	public static oPtcN290TuwfxN9qnftN aFH9GeRevRU()
	{
		return e2O9o6QysvL ?? (e2O9o6QysvL = new oPtcN290TuwfxN9qnftN());
	}

	[SpecialName]
	public static void dKa9GsYUHp6(oPtcN290TuwfxN9qnftN P_0)
	{
		e2O9o6QysvL = P_0;
	}

	[SpecialName]
	public static lvva2q92sGGEos9amhJM zKh9GcEn9U6()
	{
		return DbN9oMFsMHE ?? (DbN9oMFsMHE = new lvva2q92sGGEos9amhJM());
	}

	[SpecialName]
	public static void rH99GjraMou(lvva2q92sGGEos9amhJM P_0)
	{
		DbN9oMFsMHE = P_0;
	}

	[SpecialName]
	public static u3qUF590RA7GwKS6JVMx Jly9GQYhP29()
	{
		return aBL9oOpiqba ?? (aBL9oOpiqba = new u3qUF590RA7GwKS6JVMx());
	}

	[SpecialName]
	public static void H4u9Gd0kMGW(u3qUF590RA7GwKS6JVMx P_0)
	{
		aBL9oOpiqba = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private static string n869GRKDGuj()
	{
		return cOh9oqArUMe;
	}

	[SpecialName]
	[CompilerGenerated]
	private static ServiceManagerServersConfig d0Q9GMfnd8w()
	{
		return QgF9oIJkbtn;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string Gkq9Gq4JkDc()
	{
		return bnV9oWEWcNN;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string xMY9GW43dIb()
	{
		return n359otcyBwH;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string mCD9GU85vS2()
	{
		return gqp9oUO9mn4;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string kNf9Gywmt7w()
	{
		return rsr9oTppbiK;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string mna9GVvNbOe()
	{
		return HLl9oyDuZj6;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string das9Gr3ODK2()
	{
		return WxT9oZp9Inn;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string eZd9Gm6yXJ5()
	{
		return Qxr9oVEZOYn;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string RSq9GwbUK4R()
	{
		return t2T9oCXlbns;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string l7y9G8ajPMA()
	{
		return Ced9or1gC8j;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string dZ49GPCfTj6()
	{
		return ykp9oK5fGGI;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string FPW9GFYV9Ek()
	{
		return wF99ompm7CY;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string vjC9GpGPcJ8()
	{
		return Adu9oh1H8Qy;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string ftc9GzgaJPr()
	{
		return KAN9ow5AveD;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string Jeg9Y2gpkPo()
	{
		return WJ99o7P5NLY;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string Yq09Yf1tIYs()
	{
		return gul9o8GBbWu;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string S1E9Ynw8O5O()
	{
		return VvA9oAUhi9I;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string gS39YYTAXvU()
	{
		return WQD9oPdafsg;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string C3y9YvqNCJC()
	{
		return wJp9oJLCDO5;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string rlF9YaFvdWh()
	{
		return zhE9oFUvAT9;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string GI39YlTdTIj()
	{
		return PNf9o3dI4yx;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string cte9YDt0Xx9()
	{
		return V8K9opwAjVW;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string nic9YN6rxI4()
	{
		return CNO9ou06sny;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string nkM9Y1PbtPI()
	{
		return qCt9oztOcxG;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string hPU9YSZpChk()
	{
		return i7p9v0b6iTH;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string kSv9YLoJZTw()
	{
		return K9f9v2qHGH1;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string XJ99YsKmAGF()
	{
		return jyn9vHxJSRV;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string LyJ9YcWvVoP()
	{
		return sSf9vfk3wck;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string Dli9YEskHv8()
	{
		return ITB9v9977Cn;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string BKa9YdoZe7l()
	{
		return f459vn7Natp;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string ywt9YRtsQAv()
	{
		return ohq9vGKctgI;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string IUj9YMx4ysI()
	{
		return Jk29vYD609F;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string q6o9Yqo6BNu()
	{
		return jAQ9voZatfZ;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string khS9YWoMqIJ()
	{
		return JJC9vv0dWQQ;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string eE99YUh0cLi()
	{
		return BLw9vBU1P9q;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string OHL9YyCAFYS()
	{
		return p5g9vawDY5p;
	}

	public static string UyX9G0frMuo(DateTime P_0)
	{
		string path = Convert.ToBase64String((byte[])hYHhIObNzWP0jgrL0UfF(Encoding.UTF8, string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x76984417), P_0))) + (string)epmkO3bk0aXnWowyZoHg(-894902996 ^ -894759124);
		return Path.Combine((string)LDlwqMbk2tJOjLirru85(), path);
	}

	public static string Bl69G2OdN8o(DateTime P_0)
	{
		string path = Convert.ToBase64String((byte[])hYHhIObNzWP0jgrL0UfF(Encoding.UTF8, string.Format((string)epmkO3bk0aXnWowyZoHg(-181342698 ^ -181087396), P_0))) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741857CB);
		return Path.Combine(mtr9YPp5CVF(), path);
	}

	[SpecialName]
	[CompilerGenerated]
	public static string CRv9YVAuekG()
	{
		return uF29viDNPye;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string qNQ9YrYSR67()
	{
		return OoI9vlMDCEe;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string aYr9YmGALFf()
	{
		return b409v4FByJu;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string XYj9YwcaluC()
	{
		return fXI9vDY2uCD;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string mLg9Y85wxp8()
	{
		return XkG9vbg7hOC;
	}

	[SpecialName]
	public static string mtr9YPp5CVF()
	{
		return mLg9Y85wxp8();
	}

	[SpecialName]
	[CompilerGenerated]
	public static string bXa9YFle5xG()
	{
		return GbG9vNTDysL;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string YZj9YpD9GB1()
	{
		return mvw9vki5ZcN;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string c1j9YzNyHvu()
	{
		return BmW9v10FKGD;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string L4n9o27aDQm()
	{
		return K1C9v54j8Fw;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string lCu9ofqd5fi()
	{
		return SVW9vSKoRZ1;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string Abi9on7rerI()
	{
		return Nq69vxwOtct;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string voU9oYo2733()
	{
		return xPZ9vLD7Qpi;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string C5B9ov83PGI()
	{
		return N4h9vevbRot;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string PDT9oanp9Nd()
	{
		return KTv9vs68YgL;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string vGk9olcoPd2()
	{
		return BkM9vXwk9h0;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string huf9oDPRMFW()
	{
		return Sjm9vcHTu9i;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string iOr9oNmvRlI()
	{
		return NUW9vjlARSv;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string i6R9o1EfKTn()
	{
		return CUl9vExW3Di;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string RxW9oSBlh75()
	{
		return sot9vQJrLnD;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string HYL9oLoa6PD()
	{
		return Ivi9vd4wsEE;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string ejH9osYePKs()
	{
		return Flp9vg1oF7k;
	}

	[SpecialName]
	[CompilerGenerated]
	public static string zQ09occ1hRy()
	{
		return KLQ9vRBrlKc;
	}

	static j18iDj9nukSCmEyZs5lH()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 7;
		int result = default(int);
		bool result2 = default(bool);
		while (true)
		{
			int n259vOnrlKI;
			switch (num)
			{
			case 5:
				jAQ9voZatfZ = Path.Combine((string)NAAAqwbkieo754d7eK27(), (string)epmkO3bk0aXnWowyZoHg(-837284864 ^ -837007020));
				JJC9vv0dWQQ = Path.Combine(mna9GVvNbOe(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B4FC98));
				num = 8;
				break;
			case 23:
				Ced9or1gC8j = Path.Combine(xMY9GW43dIb(), (string)epmkO3bk0aXnWowyZoHg(-1878953018 ^ -1878707698));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num = 0;
				}
				break;
			case 21:
			{
				XGg9vWgMCmU = false;
				if (!int.TryParse((string)pXIFsYbknhIF3UpbWBXv(UTfXh8bk9a7OIuw8dIGI(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC199B2D)), out var result5))
				{
					goto case 25;
				}
				SaK9vmwSo4g = result5;
				num = 20;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
				{
					num = 25;
				}
				break;
			}
			case 9:
				i7p9v0b6iTH = Path.Combine(kNf9Gywmt7w(), (string)epmkO3bk0aXnWowyZoHg(-617064403 ^ -616817775));
				num = 22;
				break;
			case 29:
				NUW9vjlARSv = Path.Combine(CRv9YVAuekG(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B7034B));
				p5g9vawDY5p = Path.Combine((string)rfB2eDbkDfiGpJMfTRPu(), (string)epmkO3bk0aXnWowyZoHg(-3429745 ^ -3150457));
				CUl9vExW3Di = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F51A5EE));
				sot9vQJrLnD = Path.Combine(i6R9o1EfKTn(), (string)epmkO3bk0aXnWowyZoHg(-377195341 ^ -377474149));
				num = 16;
				break;
			case 4:
				vJb9vT64tbL = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1CC50C);
				NVB9vyCl7LX = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F6062EC);
				num = 22;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
				{
					num = 39;
				}
				break;
			case 32:
				q0E9vCePlgg = (string)epmkO3bk0aXnWowyZoHg(0x11D1040B ^ 0x11D53B0F);
				c7J9vrcQKpk = 40;
				rUD9vKWYEeL = 16;
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
				{
					num = 44;
				}
				break;
			case 37:
			{
				if (!int.TryParse(ConfigurationManager.AppSettings[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127701792)], out var result3))
				{
					num = 41;
					break;
				}
				n259vOnrlKI = result3;
				goto IL_1046;
			}
			case 30:
				VvA9oAUhi9I = Path.Combine((string)eQ7MUDbka88NOUV8vKfP(), (string)epmkO3bk0aXnWowyZoHg(0x7D553BE0 ^ 0x7D517956));
				num = 11;
				break;
			case 13:
				SVW9vSKoRZ1 = Path.Combine(aYr9YmGALFf(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017093330));
				num = 26;
				break;
			case 18:
				if (result >= 501)
				{
					goto IL_0c08;
				}
				goto case 20;
			case 40:
				Jk29vYD609F = (string)Omw3kvbkoPJWVy0Klrye(mna9GVvNbOe(), epmkO3bk0aXnWowyZoHg(0x28BBDCA ^ 0x28FF8FA));
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
				{
					num = 0;
				}
				break;
			case 27:
				WxT9oZp9Inn = (string)Omw3kvbkoPJWVy0Klrye(Gkq9Gq4JkDc(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842319347));
				num = 34;
				break;
			case 22:
				K9f9v2qHGH1 = Path.Combine((string)NAAAqwbkieo754d7eK27(), (string)epmkO3bk0aXnWowyZoHg(0x385FFAB ^ 0x381BC4F));
				jyn9vHxJSRV = Path.Combine((string)NAAAqwbkieo754d7eK27(), (string)epmkO3bk0aXnWowyZoHg(0x22BF43FC ^ 0x22BB07FA));
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 14;
				}
				break;
			case 24:
				qCt9oztOcxG = Path.Combine((string)eQ7MUDbka88NOUV8vKfP(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29456514));
				num = 9;
				break;
			case 19:
			{
				if (bool.TryParse(((NameValueCollection)UTfXh8bk9a7OIuw8dIGI())[(string)epmkO3bk0aXnWowyZoHg(0x6D18F862 ^ 0x6D1CB8E2)], out var result4))
				{
					nUi9vUo9G42 = result4;
				}
				IV49vI1ywq5 = JbRPUrbkGrwn4siKfAF6(pXIFsYbknhIF3UpbWBXv(ConfigurationManager.AppSettings, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342459398)));
				cOh9oqArUMe = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68DEE0F ^ 0x689AED9), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E00661E));
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
				{
					num = 15;
				}
				break;
			}
			case 11:
				PNf9o3dI4yx = Path.Combine(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7390913C));
				num = 43;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num = 37;
				}
				break;
			case 36:
				bnV9oWEWcNN = (string)Omw3kvbkoPJWVy0Klrye(n869GRKDGuj(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108281158));
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num = 2;
				}
				break;
			case 7:
				VUi9vquhfBp = false;
				IV49vI1ywq5 = false;
				XGg9vWgMCmU = false;
				aWs9vtQlOlv = false;
				nUi9vUo9G42 = false;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
				{
					num = 4;
				}
				break;
			case 6:
				n359otcyBwH = (string)Omw3kvbkoPJWVy0Klrye(Frt5CRbkv9JMJ9T6i51R(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x80DFBFD));
				gqp9oUO9mn4 = Path.Combine(Gkq9Gq4JkDc(), (string)epmkO3bk0aXnWowyZoHg(0x24B0B9E6 ^ 0x24B0A5C8));
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num = 12;
				}
				break;
			case 44:
				SaK9vmwSo4g = 500;
				K1N9vhmtwut = new ResourceKey[14]
				{
					AssetResourceKeys.WindowTitleBarForegroundActiveBrushKey,
					AssetResourceKeys.WindowTitleBarForegroundInactiveBrushKey,
					(ResourceKey)zo9kiFbkH79MgCKruD5Y(),
					AssetResourceKeys.WindowTitleBarForegroundInactiveBrushKey,
					AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveDisabledBrushKey,
					AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveHoverBrushKey,
					(ResourceKey)p7iuAObkfLSOxqiR3yqn(),
					AssetResourceKeys.CloseWindowTitleBarButtonForegroundActivePressedBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundActiveDisabledBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundActiveHoverBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundActiveNormalBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundActivePressedBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundInactiveDisabledBrushKey,
					AssetResourceKeys.WindowTitleBarButtonForegroundInactiveNormalBrushKey
				};
				LSm9vwU4f0G = new ResourceKey[2]
				{
					AssetResourceKeys.WindowTitleBarBackgroundActiveBrushKey,
					AssetResourceKeys.WindowTitleBarBackgroundInactiveBrushKey
				};
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num = 17;
				}
				break;
			case 14:
				sSf9vfk3wck = Path.Combine(mna9GVvNbOe(), (string)epmkO3bk0aXnWowyZoHg(-617064403 ^ -616817661));
				ITB9v9977Cn = (string)Omw3kvbkoPJWVy0Klrye(mna9GVvNbOe(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E29BF8F));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num = 10;
				}
				break;
			case 28:
				KTv9vs68YgL = Path.Combine((string)rfB2eDbkDfiGpJMfTRPu(), (string)epmkO3bk0aXnWowyZoHg(-710503328 ^ -710749492));
				num = 33;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num = 12;
				}
				break;
			case 26:
				Nq69vxwOtct = Path.Combine(aYr9YmGALFf(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x4264BF2));
				xPZ9vLD7Qpi = Path.Combine((string)rfB2eDbkDfiGpJMfTRPu(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3150593));
				N4h9vevbRot = Path.Combine((string)rfB2eDbkDfiGpJMfTRPu(), (string)epmkO3bk0aXnWowyZoHg(0x684F243E ^ 0x684B62B2));
				num = 28;
				break;
			case 33:
				BkM9vXwk9h0 = Path.Combine(aYr9YmGALFf(), (string)epmkO3bk0aXnWowyZoHg(0x706541F3 ^ 0x70610731));
				num = 31;
				break;
			case 3:
				gul9o8GBbWu = Path.Combine((string)eQ7MUDbka88NOUV8vKfP(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -124054211));
				VvA9oAUhi9I = (string)Omw3kvbkoPJWVy0Klrye(eQ7MUDbka88NOUV8vKfP(), epmkO3bk0aXnWowyZoHg(-371631841 ^ -371385431));
				num = 2;
				break;
			case 43:
				V8K9opwAjVW = Path.Combine(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203343796));
				CNO9ou06sny = Path.Combine(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBAA9BB));
				num = 14;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 24;
				}
				break;
			case 42:
				OoI9vlMDCEe = Path.Combine((string)f3CPbAbk4KY6cUcN64J8(), (string)epmkO3bk0aXnWowyZoHg(-1801468030 ^ -1801462868));
				XkG9vbg7hOC = Path.Combine(CRv9YVAuekG(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -449186518));
				b409v4FByJu = (string)Omw3kvbkoPJWVy0Klrye(CRv9YVAuekG(), epmkO3bk0aXnWowyZoHg(-1461949456 ^ -1462228298));
				fXI9vDY2uCD = (string)Omw3kvbkoPJWVy0Klrye(CRv9YVAuekG(), epmkO3bk0aXnWowyZoHg(0x2BD86B18 ^ 0x2BD87A56));
				GbG9vNTDysL = (string)Omw3kvbkoPJWVy0Klrye(f3CPbAbk4KY6cUcN64J8(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -124055121));
				mvw9vki5ZcN = (string)Omw3kvbkoPJWVy0Klrye(f3CPbAbk4KY6cUcN64J8(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45197885));
				BmW9v10FKGD = (string)Omw3kvbkoPJWVy0Klrye(CRv9YVAuekG(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7390945E));
				K1C9v54j8Fw = Path.Combine(CRv9YVAuekG(), (string)epmkO3bk0aXnWowyZoHg(0x2D3134C9 ^ 0x2D3572F1));
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 13;
				}
				break;
			case 8:
				BLw9vBU1P9q = Path.Combine(mna9GVvNbOe(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6255501));
				num = 30;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num = 35;
				}
				break;
			case 12:
				rsr9oTppbiK = Path.Combine(Gkq9Gq4JkDc(), (string)epmkO3bk0aXnWowyZoHg(0x20B584D2 ^ 0x20B1C594));
				HLl9oyDuZj6 = Path.Combine(Gkq9Gq4JkDc(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339048342));
				num = 27;
				break;
			case 41:
				n259vOnrlKI = 9055;
				goto IL_1046;
			case 38:
				if (result > 4)
				{
					num = 18;
					break;
				}
				goto IL_0c08;
			case 10:
				f459vn7Natp = Path.Combine(mna9GVvNbOe(), (string)epmkO3bk0aXnWowyZoHg(0x34407BB ^ 0x340432B));
				ohq9vGKctgI = Path.Combine((string)NAAAqwbkieo754d7eK27(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BDC2FD2));
				WJ99o7P5NLY = (string)Omw3kvbkoPJWVy0Klrye(mna9GVvNbOe(), epmkO3bk0aXnWowyZoHg(--18459671 ^ 0x11DE8E9));
				num = 30;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 40;
				}
				break;
			case 31:
				Sjm9vcHTu9i = (string)Omw3kvbkoPJWVy0Klrye(aYr9YmGALFf(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-60853733 ^ -61131583));
				num = 29;
				break;
			case 15:
				QgF9oIJkbtn = (ServiceManagerServersConfig)ybecSObkYwxQojWW6M9X(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B70543));
				num = 36;
				break;
			case 34:
				Qxr9oVEZOYn = Path.Combine(xMY9GW43dIb(), (string)epmkO3bk0aXnWowyZoHg(0x7ADBF691 ^ 0x7ADFB71F));
				t2T9oCXlbns = Path.Combine((string)r6wl5NbkB4nhkglAXbci(), (string)epmkO3bk0aXnWowyZoHg(0x6D18F862 ^ 0x6D1CB9CA));
				num = 23;
				break;
			case 39:
				eFU9vZ5IPof = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5C97123);
				Hru9vVBmt3t = (string)epmkO3bk0aXnWowyZoHg(-1009517961 ^ -1009269551);
				num = 32;
				break;
			case 1:
				aWs9vtQlOlv = result2;
				num = 19;
				break;
			case 35:
				uF29viDNPye = Path.Combine((string)Y1NKjmbklPcrpANyUOSB(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E006316));
				num = 42;
				break;
			case 16:
				Ivi9vd4wsEE = (string)Omw3kvbkoPJWVy0Klrye(i6R9o1EfKTn(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB50D11));
				Flp9vg1oF7k = Path.Combine((string)IJKFPtbkbL5PjStScq27(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371384797));
				KLQ9vRBrlKc = Path.Combine((string)Y1NKjmbklPcrpANyUOSB(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002563427));
				if (int.TryParse(((NameValueCollection)UTfXh8bk9a7OIuw8dIGI())[(string)epmkO3bk0aXnWowyZoHg(-673683647 ^ -673439713)], out result))
				{
					num = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num = 38;
					}
					break;
				}
				goto IL_0c08;
			case 20:
				c7J9vrcQKpk = result;
				goto IL_0c08;
			default:
				ykp9oK5fGGI = Path.Combine((string)r6wl5NbkB4nhkglAXbci(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710748784));
				wF99ompm7CY = Path.Combine(xMY9GW43dIb(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690755989));
				Adu9oh1H8Qy = Path.Combine((string)eQ7MUDbka88NOUV8vKfP(), (string)epmkO3bk0aXnWowyZoHg(--500511424 ^ 0x1DD17084));
				KAN9ow5AveD = Path.Combine(xMY9GW43dIb(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461949456 ^ -1462228586));
				num = 3;
				break;
			case 25:
				SaK9vmwSo4g = Math.Min(1000, Math.Max(10, SaK9vmwSo4g));
				num = 16;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 37;
				}
				break;
			case 2:
				WQD9oPdafsg = Path.Combine(kNf9Gywmt7w(), (string)epmkO3bk0aXnWowyZoHg(0x4297C3EB ^ 0x42938131));
				wJp9oJLCDO5 = Path.Combine(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741FC6CB));
				zhE9oFUvAT9 = (string)Omw3kvbkoPJWVy0Klrye(kNf9Gywmt7w(), epmkO3bk0aXnWowyZoHg(--146713930 ^ 0x8BAEE6C));
				num = 30;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
				{
					num = 29;
				}
				break;
			case 17:
				{
					Uoh9v6fS7bO = (string)(ConfigurationManager.AppSettings[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583076830)] ?? epmkO3bk0aXnWowyZoHg(-617064403 ^ -616798291));
					Wed9vMLTjki = ConfigurationManager.AppSettings[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181087838)] ?? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x381C071);
					VUi9vquhfBp = false;
					num = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
					{
						num = 0;
					}
					break;
				}
				IL_0c08:
				f3p9GHFOF1e();
				return;
				IL_1046:
				N259vOnrlKI = n259vOnrlKI;
				if (bool.TryParse((string)pXIFsYbknhIF3UpbWBXv(ConfigurationManager.AppSettings, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123549758)), out result2))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 19;
			}
		}
	}

	public static void f3p9GHFOF1e()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					PP8xkbbkNueCGpnMSjud(c1j9YzNyHvu());
					num = 6;
					break;
				case 3:
					a519GfA06x2(bXa9YFle5xG());
					a519GfA06x2(YZj9YpD9GB1());
					num2 = 4;
					continue;
				case 8:
					PP8xkbbkNueCGpnMSjud(w9HhN8bkkOrZjko7XoVK());
					a519GfA06x2((string)eQ7MUDbka88NOUV8vKfP());
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					a519GfA06x2(aYr9YmGALFf());
					a519GfA06x2(XYj9YwcaluC());
					num = 3;
					break;
				default:
					a519GfA06x2(Gkq9Gq4JkDc());
					PP8xkbbkNueCGpnMSjud(xMY9GW43dIb());
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					a519GfA06x2((string)q86Wjqbk1SkQWxadMBDU());
					PP8xkbbkNueCGpnMSjud(HYL9oLoa6PD());
					a519GfA06x2(ejH9osYePKs());
					a519GfA06x2(zQ09occ1hRy());
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					a519GfA06x2((string)NAAAqwbkieo754d7eK27());
					a519GfA06x2(das9Gr3ODK2());
					a519GfA06x2((string)f3CPbAbk4KY6cUcN64J8());
					a519GfA06x2(qNQ9YrYSR67());
					num2 = 5;
					continue;
				case 1:
					a519GfA06x2(n869GRKDGuj());
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private static void a519GfA06x2(string P_0)
	{
		if (!Directory.Exists(P_0))
		{
			Directory.CreateDirectory(P_0);
		}
	}

	public static void DJG9G9We2IA()
	{
		try
		{
			if (File.Exists((string)Omw3kvbkoPJWVy0Klrye(aYr9YmGALFf(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D7D14A))))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else if (File.Exists(Path.Combine(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404A972C))))
			{
				File.Move((string)Omw3kvbkoPJWVy0Klrye(kNf9Gywmt7w(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529772661)), Path.Combine((string)rfB2eDbkDfiGpJMfTRPu(), (string)epmkO3bk0aXnWowyZoHg(0x2BD86B18 ^ 0x2BDC2C8A)));
			}
		}
		catch (Exception ex)
		{
			Gl5XIGbk5icyp7pJ9OcM(ex);
		}
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo((string)RHA7QSbkSdv2jYPuIj38());
			IEnumerator<FileInfo> enumerator = (from file in directoryInfo.GetFiles(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181098078), SearchOption.AllDirectories)
				orderby file.CreationTime descending
				select file).Skip(15).GetEnumerator();
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					try
					{
						while (O5rA1XbkLNFpsvpicbpY(enumerator))
						{
							enumerator.Current.Delete();
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					goto end_IL_08d9;
				}
				try
				{
					while (enumerator.MoveNext())
					{
						HBZNxPbkxOtkZGAvc00t(enumerator.Current);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.Dispose();
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
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
				enumerator = (from file in directoryInfo.GetFiles(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746A93C9), SearchOption.AllDirectories)
					orderby z6g3k4nJPkZbJycYKQLD.nQt17RNq0YsrP59x928i(file) descending
					select file).Skip(15).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_08d9:
				break;
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
		FA7lFrbkeanp39G3TN1W(ConfigSerializer.LoadFromFile<MhMDPU9v8rkigy1ao0Th>(vjC9GpGPcJ8()) ?? new MhMDPU9v8rkigy1ao0Th());
		JrL9GxHF3Ki(ConfigSerializer.LoadFromFile<zObClP99fKcOtAs5v4hK>(lCu9ofqd5fi()) ?? new zObClP99fKcOtAs5v4hK());
		oPtcN290TuwfxN9qnftN oPtcN290TuwfxN9qnftN = ConfigSerializer.LoadFromFile<oPtcN290TuwfxN9qnftN>((string)RnFrbsbksfXLeWYpa83c());
		int num4;
		if (oPtcN290TuwfxN9qnftN == null)
		{
			num4 = 27;
			goto IL_0009;
		}
		goto IL_0c2d;
		IL_0c62:
		u3qUF590RA7GwKS6JVMx u3qUF590RA7GwKS6JVMx = new u3qUF590RA7GwKS6JVMx();
		goto IL_0c67;
		IL_0c67:
		H4u9Gd0kMGW(u3qUF590RA7GwKS6JVMx);
		num4 = 30;
		goto IL_0009;
		IL_0009:
		ThemeDefinition themeDefinition = default(ThemeDefinition);
		while (true)
		{
			int num5;
			switch (num4)
			{
			default:
				if (((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).FontSize < 10 || Settings.FontSize > 20)
				{
					Settings.FontSize = 14;
				}
				UYcdvCbkdbktyX06sPeS(Dn9i2Abkce33EoyFoynt(Application.Current), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309549786), (double)Settings.FontSize);
				num4 = 12;
				continue;
			case 9:
				return;
			case 21:
				ThemeManager.ApplyTheme();
				if (Settings.IconsColor.IsTransparent)
				{
					Settings.IconsColor = lkshbqbk6vqHrrmMPdff();
				}
				UYcdvCbkdbktyX06sPeS(Dn9i2Abkce33EoyFoynt(Application.Current), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFE1254), new SolidColorBrush(Settings.IconsColor));
				num5 = 3;
				goto IL_0005;
			case 24:
				RpOpxq91jD3gNPA5cpBR.UAQ91Qkq1t6();
				num4 = 22;
				continue;
			case 19:
				LogManager.WriteInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73535D83));
				zVLaqo91qecSjPA3glYj.cAw91W9F5aM();
				num4 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
				{
					num4 = 4;
				}
				continue;
			case 22:
				if (!((Version)CCBANPbkrhrAjED6tdcR(Settings) == null))
				{
					num4 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num4 = 23;
					}
					continue;
				}
				goto IL_0b9b;
			case 6:
				if (!(Settings.Version == null))
				{
					goto case 22;
				}
				LogManager.WriteInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606648892));
				num4 = 24;
				continue;
			case 30:
				Pfm9G4pHJdW(Settings.Language);
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num4 = 26;
				}
				continue;
			case 25:
				if (Settings.MarketFontSize > 30)
				{
					goto IL_00bd;
				}
				goto case 20;
			case 8:
				GDT0dybkZsaSB5YYH52T(Settings, MhMDPU9v8rkigy1ao0Th.fjW9bIT90oq);
				goto IL_01a9;
			case 15:
				TimeHelper.AppLocalTime = Settings.LocalTime;
				if (string.IsNullOrEmpty(((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).FontName))
				{
					Settings.FontName = (string)epmkO3bk0aXnWowyZoHg(0xB15786A ^ 0xB152E38);
					num4 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num4 = 2;
					}
					continue;
				}
				goto case 5;
			case 10:
				themeDefinition.DefaultFontFamily = (FontFamily)bMwHDBbkjlex1kIBfTDg(Settings.FontName);
				num4 = 16;
				continue;
			case 4:
				if (((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).Version != nRFqo49kFMgmB0IF2keU.Version)
				{
					LogManager.WriteInfo(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x381B76D), CCBANPbkrhrAjED6tdcR(Settings), nRFqo49kFMgmB0IF2keU.Version));
				}
				Settings.Version = nRFqo49kFMgmB0IF2keU.Version;
				num4 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num4 = 4;
				}
				continue;
			case 7:
				if (isvFW2bkUMKLGK5l0CPZ(Settings) <= 30)
				{
					goto case 18;
				}
				goto IL_07bd;
			case 17:
				if (((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).ChartFontSize <= 30)
				{
					goto IL_0186;
				}
				goto IL_079b;
			case 3:
				QLKcyNHbv6jSgsunUGEm.dXBHbDD5tMf(new SolidColorBrush(Settings.TitleBarBackgroundColor), Rbk3SabkMbOQErgSi2qW(Settings.TitleBarBackgroundColor, MhMDPU9v8rkigy1ao0Th.kLM9blKWLFl), LSm9vwU4f0G);
				DmlncSbkOduQ6rsli1eG(new SolidColorBrush(((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).TitleBarForegroundColor), Rbk3SabkMbOQErgSi2qW(((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).TitleBarForegroundColor, MhMDPU9v8rkigy1ao0Th.kLM9blKWLFl), K1N9vhmtwut);
				if (Settings.IconsSize < 10 || uMe8fRbkqJOq20O20ixy(Settings) > 30)
				{
					Settings.IconsSize = 10;
					num4 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
					{
						num4 = 11;
					}
					continue;
				}
				goto case 11;
			case 2:
				if (!p342ETbkKW8MRdMc81OZ(Settings))
				{
					goto IL_0428;
				}
				goto case 31;
			case 1:
				((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).ChartFontName = (string)epmkO3bk0aXnWowyZoHg(-44540535 ^ -44561445);
				goto IL_05bc;
			case 16:
				themeDefinition.BaseFontSize = iNfZkGbkRTmDKLFfEFfS(Settings);
				num4 = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
				{
					num4 = 21;
				}
				continue;
			case 31:
				xco9GnHj4tS();
				goto IL_0428;
			case 11:
				UYcdvCbkdbktyX06sPeS(Application.Current.Resources, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002316913), (double)uMe8fRbkqJOq20O20ixy(Settings));
				num5 = 28;
				goto IL_0005;
			case 29:
				KatNee91RJkhEYqUPL49.fM091Md9EyQ();
				num4 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num4 = 2;
				}
				continue;
			case 23:
				if (!((Version)CCBANPbkrhrAjED6tdcR(Settings) <= new Version(6, 8, 8704, 37074)))
				{
					goto case 2;
				}
				goto IL_0b9b;
			case 18:
				if (CJCiutbkyrkd3IigxGyT(Settings).IsTransparent)
				{
					num4 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num4 = 0;
					}
					continue;
				}
				goto IL_01a9;
			case 12:
				themeDefinition = ThemeManager.GetThemeDefinition((string)g4Uiqkbkg09deYksca3M());
				num4 = 14;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num4 = 7;
				}
				continue;
			case 32:
				UvM9GberQCt();
				num4 = 15;
				continue;
			case 5:
				((ResourceDictionary)Dn9i2Abkce33EoyFoynt(Application.Current))[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F13A4)] = bMwHDBbkjlex1kIBfTDg(((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).FontName);
				Application.Current.Resources[tTxQVNbkEOU9WQVWlDmp()] = XFont.GetFont((string)n1evCDbkQechaeYgJL05(l2AfCGbkXIUsQ2d6MXaO()));
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num4 = 0;
				}
				continue;
			case 20:
				if (isvFW2bkUMKLGK5l0CPZ(Settings) >= 8)
				{
					num4 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
					{
						num4 = 2;
					}
					continue;
				}
				goto IL_07bd;
			case 28:
				if (string.IsNullOrEmpty((string)x6yNUVbkIF6kpRIet5dT(Settings)))
				{
					num4 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
					{
						num4 = 0;
					}
					continue;
				}
				goto IL_05bc;
			case 14:
				if (themeDefinition != null)
				{
					num4 = 10;
					continue;
				}
				goto case 21;
			case 26:
				I5N9GDPgNFo(Settings.AppTheme);
				num4 = 32;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num4 = 4;
				}
				continue;
			case 27:
				break;
			case 13:
				goto IL_0c62;
				IL_05bc:
				if (Settings.ChartFontSize >= 8)
				{
					num4 = 17;
					continue;
				}
				goto IL_079b;
				IL_0005:
				num4 = num5;
				continue;
				IL_0428:
				if (Settings.Version == null)
				{
					goto case 19;
				}
				if (((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).Version <= new Version(7, 0, 9205, 24774))
				{
					num4 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
					{
						num4 = 19;
					}
					continue;
				}
				goto case 4;
				IL_01a9:
				if (Klhi93bkVPBpMwIwp5Hk(l2AfCGbkXIUsQ2d6MXaO()) <= 0)
				{
					Ug2AfUbkCjJLNWMl8YD6(l2AfCGbkXIUsQ2d6MXaO(), 50);
					num4 = 6;
					continue;
				}
				goto case 6;
				IL_079b:
				((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).ChartFontSize = 14;
				goto IL_0186;
				IL_0186:
				if (string.IsNullOrEmpty((string)IosoojbkWXQe6PIaG2sp(Settings)))
				{
					((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).MarketFontName = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5D280);
				}
				if (((MhMDPU9v8rkigy1ao0Th)l2AfCGbkXIUsQ2d6MXaO()).MarketFontSize >= 8)
				{
					num4 = 25;
					continue;
				}
				goto IL_00bd;
				IL_00bd:
				ohE6Y9bktS6TP1vkP2we(Settings, 14);
				num4 = 20;
				continue;
				IL_0b9b:
				LogManager.WriteInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x73909A6C));
				num4 = 29;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num4 = 25;
				}
				continue;
				IL_07bd:
				dF1XWjbkT96Bw7GtEE2y(Settings, 14);
				num4 = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num4 = 12;
				}
				continue;
			}
			break;
		}
		oPtcN290TuwfxN9qnftN = new oPtcN290TuwfxN9qnftN();
		goto IL_0c2d;
		IL_0c2d:
		dKa9GsYUHp6(oPtcN290TuwfxN9qnftN);
		rH99GjraMou(ConfigSerializer.LoadFromFile<lvva2q92sGGEos9amhJM>(voU9oYo2733()) ?? new lvva2q92sGGEos9amhJM());
		u3qUF590RA7GwKS6JVMx = ConfigSerializer.LoadFromFile<u3qUF590RA7GwKS6JVMx>(C5B9ov83PGI());
		if (u3qUF590RA7GwKS6JVMx == null)
		{
			num4 = 13;
			goto IL_0009;
		}
		goto IL_0c67;
	}

	private static void xco9GnHj4tS()
	{
		if (!Directory.Exists(mCD9GU85vS2()))
		{
			return;
		}
		string[] files = Directory.GetFiles(mCD9GU85vS2());
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		ChartingSettings chartingSettings = default(ChartingSettings);
		TradingSettings tradingSettings = default(TradingSettings);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (num2 < files.Length)
				{
					goto case 2;
				}
				return;
			default:
				num2 = 0;
				goto case 3;
			case 2:
			{
				string text = files[num2];
				try
				{
					if (vO5xKlbkmLx7CQDrZ8SI(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90262680)))
					{
						goto IL_01d7;
					}
					goto IL_01fc;
					IL_01fc:
					if (vO5xKlbkmLx7CQDrZ8SI(text, epmkO3bk0aXnWowyZoHg(0x28C965BE ^ 0x28C9D5D8)))
					{
						chartingSettings = ConfigSerializer.LoadFromFile<ChartingSettings>(text, (DataContractResolver)MxX8JHbk8cRhso8clFnA());
						if (chartingSettings != null && !string.IsNullOrEmpty((string)DNdUNGbkhM8GG4V1UuZa(chartingSettings)))
						{
							goto IL_01af;
						}
						break;
					}
					int num3 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num3 = 6;
					}
					goto IL_0090;
					IL_01d7:
					tradingSettings = ConfigSerializer.LoadFromFile<TradingSettings>(text);
					if (tradingSettings == null)
					{
						break;
					}
					if (string.IsNullOrEmpty((string)DNdUNGbkhM8GG4V1UuZa(tradingSettings)))
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num3 = 0;
						}
					}
					else
					{
						string text2 = tradingSettings.Qom210PQiuE;
						MarketSettings marketSettings = (MarketSettings)u6x8hvbkwkVdq4piU6HG(tradingSettings);
						((NeyDU62DKFU8Qyxyvfd6<string>)rheNxsbk76EEwMHw9THO(tradingSettings)).Clear();
						qEr9GGxTeZV(text2, marketSettings);
						int num4 = 3;
						num3 = num4;
					}
					goto IL_0090;
					IL_01af:
					object obj = DNdUNGbkhM8GG4V1UuZa(chartingSettings);
					MarketSettings marketSettings2 = chartingSettings.MarketSettings;
					((NeyDU62DKFU8Qyxyvfd6<string>)rheNxsbk76EEwMHw9THO(chartingSettings)).Clear();
					qEr9GGxTeZV((string)obj, marketSettings2);
					R9S9GYd7WQ5(chartingSettings);
					ConfigSerializer.SaveToFile(chartingSettings, text, jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns());
					num3 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num3 = 1;
					}
					goto IL_0090;
					IL_0090:
					while (true)
					{
						switch (num3)
						{
						case 6:
							break;
						case 3:
							ConfigSerializer.SaveToFile(tradingSettings, text);
							num3 = 7;
							continue;
						case 0:
							break;
						case 1:
							goto IL_01af;
						case 5:
							goto IL_01d7;
						case 4:
							goto IL_01fc;
						case 7:
							break;
						case 2:
							break;
						}
						break;
					}
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
				}
				break;
			}
			case 1:
				return;
			}
			num2++;
			num = 3;
		}
	}

	private static void qEr9GGxTeZV(string P_0, MarketSettings P_1)
	{
		P_1.ClusterSettings.Clear();
		((CR1isWfDCD1A4fwfUJUf)lUNSXnbkAfbtIdnDgFYw(P_1)).Clear();
		P_1.VisualSettings.Clear();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				IpOF5EbkPfodrFjm2hgl(P_1);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				qvMpZRbkJ2SPccRJ7g5j(P_1.UniversalSignalLevels);
				((YiXl9IfP06OkWU6fDkUP)gLmwhebkF4nbRN7qlWZL(P_1)).Levels.Clear();
				VEXJq8bkpK5Lmp1rIuJp(((YiXl9IfP06OkWU6fDkUP)pdiibmbk362vlCRMRQL1(P_1)).Levels);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static bool R9S9GYd7WQ5(ChartingSettings P_0)
	{
		bool result = false;
		try
		{
			Ay9adxnJzQvQjWm2Y12g CS_0024_003C_003E8__locals2 = new Ay9adxnJzQvQjWm2Y12g();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (i6UVKdbkujlme7QeExvu(P_0.ChartSettings.Areas[0].Objects) == 0)
					{
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				case 2:
					return false;
				}
				break;
			}
			CS_0024_003C_003E8__locals2.aOQnF2BbE1d = P_0.Qom210PQiuE;
			List<ObjectBase> list = default(List<ObjectBase>);
			foreach (CR9nZ49x3RUlacnAckjy area in P_0.ChartSettings.Areas)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						result = true;
						area.Objects = list;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						list = area.Objects.Where((ObjectBase obj) => !(obj is HorizontalLineObject) || Ay9adxnJzQvQjWm2Y12g.dMqwd0Nq90A2bt9tSyrW(obj.SymbolID, CS_0024_003C_003E8__locals2.aOQnF2BbE1d)).ToList();
						if (i6UVKdbkujlme7QeExvu(list) != area.Objects.Count)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
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
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
		return result;
	}

	public static void Pvm9GoIbX5i()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				AKU9GBKmZQ5();
				Os19GalyoqM();
				U1rHcKb10yYCZ2BVZMW5();
				return;
			case 1:
				RSBESmbkz4ugmdO3nYRq();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void HYr9GvOgDhd()
	{
		ConfigSerializer.SaveToFile(Settings, vjC9GpGPcJ8());
	}

	public static void AKU9GBKmZQ5()
	{
		ConfigSerializer.SaveToFile((zObClP99fKcOtAs5v4hK)qMGNk0b12piXM0Gs8Jg0(), lCu9ofqd5fi());
	}

	public static void Os19GalyoqM()
	{
		ConfigSerializer.SaveToFile(aFH9GeRevRU(), Abi9on7rerI());
	}

	public static void yO49GioLLx0()
	{
		ConfigSerializer.SaveToFile(zKh9GcEn9U6(), voU9oYo2733());
	}

	public static void mF79Gl3VoKe()
	{
		ConfigSerializer.SaveToFile(Jly9GQYhP29(), C5B9ov83PGI());
	}

	private static void Pfm9G4pHJdW(AppLanguage P_0)
	{
		int num;
		switch (P_0)
		{
		case AppLanguage.Ukraine:
			((Thread)Gx7c8Xb1HL8SZxg8S5f5()).CurrentCulture = new CultureInfo((string)epmkO3bk0aXnWowyZoHg(-53782092 ^ -53538644));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case AppLanguage.Turkish:
			GpqPcWb1fje5cRxVWodt(Thread.CurrentThread, new CultureInfo((string)epmkO3bk0aXnWowyZoHg(0x741B85CB ^ 0x741FCCDB)));
			NdGsqhb1G5jGXJbsYV2w(Thread.CurrentThread, new CultureInfo((string)epmkO3bk0aXnWowyZoHg(0x60620FC1 ^ 0x606646D1)));
			num = 12;
			goto IL_0009;
		case AppLanguage.Spanish:
			goto IL_02af;
		case AppLanguage.Chinese:
			Thread.CurrentThread.CurrentCulture = new CultureInfo((string)epmkO3bk0aXnWowyZoHg(0x3E0426F0 ^ 0x3E006FD0));
			num = 7;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		case AppLanguage.Russian:
			goto IL_039a;
		case AppLanguage.English:
			GpqPcWb1fje5cRxVWodt(Gx7c8Xb1HL8SZxg8S5f5(), new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B4AAC3)));
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838620412));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case AppLanguage.Portuguese:
			{
				GpqPcWb1fje5cRxVWodt(Thread.CurrentThread, new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203345372)));
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
				{
					num = 3;
				}
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					((Thread)Gx7c8Xb1HL8SZxg8S5f5()).CurrentUICulture = new CultureInfo((string)epmkO3bk0aXnWowyZoHg(0x86EFEF6 ^ 0x86AB7EE));
					CultureInfo.DefaultThreadCurrentUICulture = (CultureInfo)e7KI9ub19fTYKVpIK8eP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127699508));
					goto end_IL_0158;
				case 9:
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D181B42));
					CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture((string)epmkO3bk0aXnWowyZoHg(-2123795572 ^ -2123788116));
					num = 11;
					continue;
				case 12:
					TecIIUb1nPU2DuAWNN3a(CultureInfo.CreateSpecificCulture(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311569487)));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num = 4;
					}
					continue;
				case 1:
					CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture((string)epmkO3bk0aXnWowyZoHg(0x68DEE0F ^ 0x68E0F13));
					goto end_IL_0158;
				case 3:
					break;
				case 2:
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127699492));
					CultureInfo.DefaultThreadCurrentUICulture = (CultureInfo)e7KI9ub19fTYKVpIK8eP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D357DC1));
					goto end_IL_0158;
				case 5:
					goto IL_02af;
				case 7:
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371388353));
					TecIIUb1nPU2DuAWNN3a(CultureInfo.CreateSpecificCulture((string)epmkO3bk0aXnWowyZoHg(0xC1DDB3B ^ 0xC19921B)));
					goto end_IL_0158;
				case 10:
					goto IL_039a;
				case 4:
				case 8:
				case 11:
					goto end_IL_0158;
				case 6:
				{
					Thread.CurrentThread.CurrentUICulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -58012337));
					TecIIUb1nPU2DuAWNN3a(e7KI9ub19fTYKVpIK8eP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-838841832 ^ -838597864)));
					int num2 = 8;
					num = num2;
					continue;
				}
				}
				break;
			}
			goto case AppLanguage.Turkish;
			IL_039a:
			Thread.CurrentThread.CurrentCulture = new CultureInfo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690534563));
			num = 9;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num = 3;
			}
			goto IL_0009;
			IL_02af:
			Thread.CurrentThread.CurrentCulture = new CultureInfo((string)epmkO3bk0aXnWowyZoHg(-842040449 ^ -842321289));
			num = 2;
			goto IL_0009;
			end_IL_0158:
			break;
		}
		Qr2EX6b1YCyaik9s7AAx(FrameworkElement.LanguageProperty, Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777265)), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
	}

	public static void I5N9GDPgNFo(AppTheme P_0)
	{
		ThemeManager.BeginUpdate();
		try
		{
			MaMkOwb1orJ8Cw0xd69Q(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x34401B3) + P_0);
			QLKcyNHbv6jSgsunUGEm.iXKHblLD6j1(P_0);
		}
		finally
		{
			hTiOPKb1vXGwmbSQtXyH();
		}
	}

	private static void UvM9GberQCt()
	{
		ActiproSoftware.Products.Grids.SR.SetCustomString(ActiproSoftware.Products.Grids.SRName.UIPropertyGridRemoveButtonToolTip.ToString(), TigerTrade.Properties.Resources.ActiproPropertyGridCollectionRemoveHint);
		KDiRQnb1BbUshHDykYDN(ActiproSoftware.Products.Grids.SRName.UIPropertyGridAddChildButtonToolTip.ToString(), TigerTrade.Properties.Resources.ActiproPropertyGridCollectionAddHint);
		ActiproSoftware.Products.Editors.SR.SetCustomString(ActiproSoftware.Products.Editors.SRName.UISpinnerDecrementButtonToolTip.ToString(), (string)OynJjqb1aWdfOnKpam7F());
		ActiproSoftware.Products.Editors.SRName sRName = ActiproSoftware.Products.Editors.SRName.UISpinnerIncrementButtonToolTip;
		int num = 18;
		ActiproSoftware.Products.Docking.SRName sRName2 = default(ActiproSoftware.Products.Docking.SRName);
		while (true)
		{
			switch (num)
			{
			case 12:
				sRName = ActiproSoftware.Products.Editors.SRName.UICalendarTodayButtonText;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 0;
				}
				break;
			case 7:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UIToolWindowContainerToggleAutoHideButtonToolTip;
				eK8DaRb1byag668b2Li9(sRName2.ToString(), DJEBuTb1LXeWp9xMIIFx());
				num = 6;
				break;
			case 2:
				eK8DaRb1byag668b2Li9(sRName2.ToString(), XMFa8cb1k8knNiL7t0SU());
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMoveToNewHorizontalContainerText;
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 10;
				}
				break;
			case 8:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandCloseWindowText;
				num = 9;
				break;
			case 9:
				eK8DaRb1byag668b2Li9(sRName2.ToString(), N03Ni2b1DFIMjq0CV0W9());
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandCloseOthersText;
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), TigerTrade.Properties.Resources.UICommandCloseOthersText);
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 4;
				}
				break;
			case 6:
				eK8DaRb1byag668b2Li9(ActiproSoftware.Products.Docking.SRName.UICommandMoveToNextContainerText.ToString(), TigerTrade.Properties.Resources.UICommandMoveToNextContainerText);
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMoveToPreviousContainerText;
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), (string)jJ1OlZb1eJtJbB1oOy8w());
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num = 10;
				}
				break;
			case 18:
				iITQUVb1lVIvRv3SX3VL(sRName.ToString(), nb30rNb1itkxycafbUEF());
				num = 12;
				break;
			case 1:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMakeDockedWindowText;
				eK8DaRb1byag668b2Li9(sRName2.ToString(), TigerTrade.Properties.Resources.UICommandMakeDockedWindowText);
				num = 14;
				break;
			case 19:
			{
				sRName = ActiproSoftware.Products.Editors.SRName.UICalendarClearButtonText;
				int num2 = 17;
				num = num2;
				break;
			}
			case 14:
				eK8DaRb1byag668b2Li9(ActiproSoftware.Products.Docking.SRName.UICommandMakeDocumentWindowText.ToString(), TigerTrade.Properties.Resources.UICommandMakeDocumentWindowText);
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandToggleWindowAutoHideStateText;
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), (string)LCaYDkb152tkvJmpMy9R());
				num = 5;
				break;
			case 17:
				ActiproSoftware.Products.Editors.SR.SetCustomString(sRName.ToString(), (string)q4309Fb14DrK0suPVDap());
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
				{
					num = 4;
				}
				break;
			case 16:
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), (string)JdjrYRb1SNrjvC3DK5TX());
				sRName2 = ActiproSoftware.Products.Docking.SRName.UIToolWindowContainerCloseButtonToolTip;
				eK8DaRb1byag668b2Li9(sRName2.ToString(), FehYHpb1xJFnJSSwVBkg());
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
				{
					num = 7;
				}
				break;
			case 3:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMakeFloatingWindowText;
				num = 15;
				break;
			case 5:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UIToolWindowContainerOptionsButtonToolTip;
				num = 16;
				break;
			case 11:
				return;
			case 4:
				ActiproSoftware.Products.Docking.SR.SetCustomString(ActiproSoftware.Products.Docking.SRName.UICommandCloseAllDocumentsText.ToString(), TigerTrade.Properties.Resources.UICommandCloseAllDocumentsText);
				ActiproSoftware.Products.Docking.SR.SetCustomString(ActiproSoftware.Products.Docking.SRName.UICommandCloseAllInContainerText.ToString(), TigerTrade.Properties.Resources.UICommandCloseAllInContainerText);
				ActiproSoftware.Products.Docking.SR.SetCustomString(ActiproSoftware.Products.Docking.SRName.UICommandPinTabText.ToString(), (string)AyNd9Zb1N8TbyNXOGcaa());
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMoveToNewVerticalContainerText;
				num = 2;
				break;
			case 13:
				sRName2 = ActiproSoftware.Products.Docking.SRName.UICommandMoveToPrimaryMdiHostText;
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), TigerTrade.Properties.Resources.UICommandMoveToPrimaryMdiHostText);
				num = 11;
				break;
			default:
				iITQUVb1lVIvRv3SX3VL(sRName.ToString(), TigerTrade.Properties.Resources.UICalendarTodayButtonText);
				num = 19;
				break;
			case 10:
				ActiproSoftware.Products.Docking.SR.SetCustomString(sRName2.ToString(), TigerTrade.Properties.Resources.UICommandMoveToNewHorizontalContainerText);
				num = 3;
				break;
			case 15:
				eK8DaRb1byag668b2Li9(sRName2.ToString(), PorMi7b11YZI8YnbFxo4());
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static byte[] yEw9oEWYO8C()
	{
		return Xdc9v7NFYWv;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void Uq19oQxeQT7(byte[] P_0)
	{
		Xdc9v7NFYWv = P_0;
	}

	public static void JS19GNMQu30(byte[] P_0, DateTime P_1)
	{
		Uq19oQxeQT7(P_0);
		NK5Qq9b1sQVVsNI0INNY(P_1);
	}

	public static n8Wl8O9fqNNZCRNuFMKd v8M9GkJB4pg(AppServer P_0)
	{
		string text = P_0.ToString();
		return d0Q9GMfnd8w().ServiceManagerServers.X8K9f6ItNut(text);
	}

	internal static bool WXo9K8bNpTJZ4q21aEjH()
	{
		return DpfvDWbN3A4E4m8nAXj8 == null;
	}

	internal static j18iDj9nukSCmEyZs5lH Q2qj5jbNuEdTvFKCwIu2()
	{
		return DpfvDWbN3A4E4m8nAXj8;
	}

	internal static object hYHhIObNzWP0jgrL0UfF(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object epmkO3bk0aXnWowyZoHg(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object LDlwqMbk2tJOjLirru85()
	{
		return mtr9YPp5CVF();
	}

	internal static object zo9kiFbkH79MgCKruD5Y()
	{
		return AssetResourceKeys.WindowTitleBarForegroundActiveBrushKey;
	}

	internal static object p7iuAObkfLSOxqiR3yqn()
	{
		return AssetResourceKeys.CloseWindowTitleBarButtonForegroundActiveNormalBrushKey;
	}

	internal static object UTfXh8bk9a7OIuw8dIGI()
	{
		return ConfigurationManager.AppSettings;
	}

	internal static object pXIFsYbknhIF3UpbWBXv(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static bool JbRPUrbkGrwn4siKfAF6(object P_0)
	{
		return Convert.ToBoolean((string)P_0);
	}

	internal static object ybecSObkYwxQojWW6M9X(object P_0)
	{
		return ConfigurationManager.GetSection((string)P_0);
	}

	internal static object Omw3kvbkoPJWVy0Klrye(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object Frt5CRbkv9JMJ9T6i51R()
	{
		return Gkq9Gq4JkDc();
	}

	internal static object r6wl5NbkB4nhkglAXbci()
	{
		return xMY9GW43dIb();
	}

	internal static object eQ7MUDbka88NOUV8vKfP()
	{
		return kNf9Gywmt7w();
	}

	internal static object NAAAqwbkieo754d7eK27()
	{
		return mna9GVvNbOe();
	}

	internal static object Y1NKjmbklPcrpANyUOSB()
	{
		return n869GRKDGuj();
	}

	internal static object f3CPbAbk4KY6cUcN64J8()
	{
		return CRv9YVAuekG();
	}

	internal static object rfB2eDbkDfiGpJMfTRPu()
	{
		return aYr9YmGALFf();
	}

	internal static object IJKFPtbkbL5PjStScq27()
	{
		return i6R9o1EfKTn();
	}

	internal static void PP8xkbbkNueCGpnMSjud(object P_0)
	{
		a519GfA06x2((string)P_0);
	}

	internal static object w9HhN8bkkOrZjko7XoVK()
	{
		return mCD9GU85vS2();
	}

	internal static object q86Wjqbk1SkQWxadMBDU()
	{
		return L4n9o27aDQm();
	}

	internal static void Gl5XIGbk5icyp7pJ9OcM(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object RHA7QSbkSdv2jYPuIj38()
	{
		return zQ09occ1hRy();
	}

	internal static void HBZNxPbkxOtkZGAvc00t(object P_0)
	{
		((FileSystemInfo)P_0).Delete();
	}

	internal static bool O5rA1XbkLNFpsvpicbpY(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void FA7lFrbkeanp39G3TN1W(object P_0)
	{
		Settings = (MhMDPU9v8rkigy1ao0Th)P_0;
	}

	internal static object RnFrbsbksfXLeWYpa83c()
	{
		return Abi9on7rerI();
	}

	internal static object l2AfCGbkXIUsQ2d6MXaO()
	{
		return Settings;
	}

	internal static object Dn9i2Abkce33EoyFoynt(object P_0)
	{
		return ((Application)P_0).Resources;
	}

	internal static object bMwHDBbkjlex1kIBfTDg(object P_0)
	{
		return XFont.GetFont((string)P_0);
	}

	internal static object tTxQVNbkEOU9WQVWlDmp()
	{
		return SystemFonts.CaptionFontFamilyKey;
	}

	internal static object n1evCDbkQechaeYgJL05(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).FontName;
	}

	internal static void UYcdvCbkdbktyX06sPeS(object P_0, object P_1, object P_2)
	{
		((ResourceDictionary)P_0)[P_1] = P_2;
	}

	internal static object g4Uiqkbkg09deYksca3M()
	{
		return ThemeManager.CurrentTheme;
	}

	internal static int iNfZkGbkRTmDKLFfEFfS(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).FontSize;
	}

	internal static Color lkshbqbk6vqHrrmMPdff()
	{
		return Colors.SteelBlue;
	}

	internal static bool Rbk3SabkMbOQErgSi2qW(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void DmlncSbkOduQ6rsli1eG(object P_0, bool P_1, object P_2)
	{
		QLKcyNHbv6jSgsunUGEm.dXBHbDD5tMf(P_0, P_1, (ResourceKey[])P_2);
	}

	internal static int uMe8fRbkqJOq20O20ixy(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).IconsSize;
	}

	internal static object x6yNUVbkIF6kpRIet5dT(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartFontName;
	}

	internal static object IosoojbkWXQe6PIaG2sp(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).MarketFontName;
	}

	internal static void ohE6Y9bktS6TP1vkP2we(object P_0, int P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).MarketFontSize = P_1;
	}

	internal static int isvFW2bkUMKLGK5l0CPZ(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).MarketPosFontSize;
	}

	internal static void dF1XWjbkT96Bw7GtEE2y(object P_0, int P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).MarketPosFontSize = P_1;
	}

	internal static XColor CJCiutbkyrkd3IigxGyT(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameForegroundColor;
	}

	internal static void GDT0dybkZsaSB5YYH52T(object P_0, XColor P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameForegroundColor = P_1;
	}

	internal static int Klhi93bkVPBpMwIwp5Hk(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameFontSize;
	}

	internal static void Ug2AfUbkCjJLNWMl8YD6(object P_0, int P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).ChartSymbolNameFontSize = P_1;
	}

	internal static object CCBANPbkrhrAjED6tdcR(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).Version;
	}

	internal static bool p342ETbkKW8MRdMc81OZ(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SyncLevels;
	}

	internal static bool vO5xKlbkmLx7CQDrZ8SI(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object DNdUNGbkhM8GG4V1UuZa(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).Qom210PQiuE;
	}

	internal static object u6x8hvbkwkVdq4piU6HG(object P_0)
	{
		return ((TradingSettings)P_0).MarketSettings;
	}

	internal static object rheNxsbk76EEwMHw9THO(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).cK121ntjdg5;
	}

	internal static object MxX8JHbk8cRhso8clFnA()
	{
		return jjKtVJ9pUSOpdg38tqnP.PV29p3fNsns();
	}

	internal static object lUNSXnbkAfbtIdnDgFYw(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static void IpOF5EbkPfodrFjm2hgl(object P_0)
	{
		((MarketSettings)P_0).Clear();
	}

	internal static void qvMpZRbkJ2SPccRJ7g5j(object P_0)
	{
		((List<HorizontalLineObject>)P_0).Clear();
	}

	internal static object gLmwhebkF4nbRN7qlWZL(object P_0)
	{
		return ((MarketSettings)P_0).SignalLevels;
	}

	internal static object pdiibmbk362vlCRMRQL1(object P_0)
	{
		return ((MarketSettings)P_0).Levels;
	}

	internal static void VEXJq8bkpK5Lmp1rIuJp(object P_0)
	{
		((Dictionary<string, List<BpmEftf7wYbuVebk5Vku>>)P_0).Clear();
	}

	internal static int i6UVKdbkujlme7QeExvu(object P_0)
	{
		return ((List<ObjectBase>)P_0).Count;
	}

	internal static void RSBESmbkz4ugmdO3nYRq()
	{
		HYr9GvOgDhd();
	}

	internal static void U1rHcKb10yYCZ2BVZMW5()
	{
		yO49GioLLx0();
	}

	internal static object qMGNk0b12piXM0Gs8Jg0()
	{
		return lmf9GS9l7aG();
	}

	internal static object Gx7c8Xb1HL8SZxg8S5f5()
	{
		return Thread.CurrentThread;
	}

	internal static void GpqPcWb1fje5cRxVWodt(object P_0, object P_1)
	{
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}

	internal static object e7KI9ub19fTYKVpIK8eP(object P_0)
	{
		return CultureInfo.CreateSpecificCulture((string)P_0);
	}

	internal static void TecIIUb1nPU2DuAWNN3a(object P_0)
	{
		CultureInfo.DefaultThreadCurrentUICulture = (CultureInfo)P_0;
	}

	internal static void NdGsqhb1G5jGXJbsYV2w(object P_0, object P_1)
	{
		((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
	}

	internal static void Qr2EX6b1YCyaik9s7AAx(object P_0, Type P_1, object P_2)
	{
		((DependencyProperty)P_0).OverrideMetadata(P_1, (PropertyMetadata)P_2);
	}

	internal static void MaMkOwb1orJ8Cw0xd69Q(object P_0)
	{
		ThemeManager.CurrentTheme = (string)P_0;
	}

	internal static void hTiOPKb1vXGwmbSQtXyH()
	{
		ThemeManager.EndUpdate();
	}

	internal static void KDiRQnb1BbUshHDykYDN(object P_0, object P_1)
	{
		ActiproSoftware.Products.Grids.SR.SetCustomString((string)P_0, (string)P_1);
	}

	internal static object OynJjqb1aWdfOnKpam7F()
	{
		return TigerTrade.Properties.Resources.ActiproSpinEditorDecrementValueHint;
	}

	internal static object nb30rNb1itkxycafbUEF()
	{
		return TigerTrade.Properties.Resources.ActiproSpinEditorIncrementValueHint;
	}

	internal static void iITQUVb1lVIvRv3SX3VL(object P_0, object P_1)
	{
		ActiproSoftware.Products.Editors.SR.SetCustomString((string)P_0, (string)P_1);
	}

	internal static object q4309Fb14DrK0suPVDap()
	{
		return TigerTrade.Properties.Resources.UICalendarClearButtonText;
	}

	internal static object N03Ni2b1DFIMjq0CV0W9()
	{
		return TigerTrade.Properties.Resources.UICommandCloseWindowText;
	}

	internal static void eK8DaRb1byag668b2Li9(object P_0, object P_1)
	{
		ActiproSoftware.Products.Docking.SR.SetCustomString((string)P_0, (string)P_1);
	}

	internal static object AyNd9Zb1N8TbyNXOGcaa()
	{
		return TigerTrade.Properties.Resources.UICommandPinTabText;
	}

	internal static object XMFa8cb1k8knNiL7t0SU()
	{
		return TigerTrade.Properties.Resources.UICommandMoveToNewVerticalContainerText;
	}

	internal static object PorMi7b11YZI8YnbFxo4()
	{
		return TigerTrade.Properties.Resources.UICommandMakeFloatingWindowText;
	}

	internal static object LCaYDkb152tkvJmpMy9R()
	{
		return TigerTrade.Properties.Resources.UICommandToggleWindowAutoHideStateText;
	}

	internal static object JdjrYRb1SNrjvC3DK5TX()
	{
		return TigerTrade.Properties.Resources.UIToolWindowContainerOptionsButtonToolTip;
	}

	internal static object FehYHpb1xJFnJSSwVBkg()
	{
		return TigerTrade.Properties.Resources.UIToolWindowContainerCloseButtonToolTip;
	}

	internal static object DJEBuTb1LXeWp9xMIIFx()
	{
		return TigerTrade.Properties.Resources.UIToolWindowContainerToggleAutoHideButtonToolTip;
	}

	internal static object jJ1OlZb1eJtJbB1oOy8w()
	{
		return TigerTrade.Properties.Resources.UICommandMoveToPreviousContainerText;
	}

	internal static void NK5Qq9b1sQVVsNI0INNY(DateTime P_0)
	{
		SymbolManager.ClientSpecLastUpdate = P_0;
	}
}
