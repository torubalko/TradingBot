using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;

namespace pcNaAaYXICmvM8EDADY4;

[DataContract(Name = "Mt5Settings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.TradeClient")]
internal sealed class TGsif1YXq0JNqauctK1A : gpnr5oG8Q1cRMmiYT0Ut
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Jg7yXVaWK4hM5awqlJAy
	{
		public static readonly Jg7yXVaWK4hM5awqlJAy MpSaWhimUWO;

		public static Func<Process, string> mLfaWwwrgLf;

		private static Jg7yXVaWK4hM5awqlJAy BhEbWSL22TCA3befMaY4;

		static Jg7yXVaWK4hM5awqlJAy()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					GOIsdPL29A1b5efn0mf3();
					sT2dXCL2nm8i9deQTAoQ();
					MpSaWhimUWO = new Jg7yXVaWK4hM5awqlJAy();
					return;
				case 1:
					F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public Jg7yXVaWK4hM5awqlJAy()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string d8IaWmOBH5I(Process process)
		{
			return System.IO.Path.GetDirectoryName(process.MainModule.FileName);
		}

		internal static void GOIsdPL29A1b5efn0mf3()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void sT2dXCL2nm8i9deQTAoQ()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool O5BVEBL2HoMB6To63x0V()
		{
			return BhEbWSL22TCA3befMaY4 == null;
		}

		internal static Jg7yXVaWK4hM5awqlJAy fwRNjfL2frfB7dgkbfhR()
		{
			return BhEbWSL22TCA3befMaY4;
		}
	}

	[CompilerGenerated]
	private string bVLYXTAvF5W;

	internal static TGsif1YXq0JNqauctK1A XLUP2XSxtVPI7AVXEtqT;

	[DataMember(Name = "Path")]
	public string Path
	{
		[CompilerGenerated]
		get
		{
			return bVLYXTAvF5W;
		}
		[CompilerGenerated]
		set
		{
			bVLYXTAvF5W = text;
		}
	}

	public TGsif1YXq0JNqauctK1A()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		Path = "";
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static List<string> XMHYXWGGwMc()
	{
		List<string> list = new List<string>();
		try
		{
			Process[] processesByName = Process.GetProcessesByName(Environment.Is64BitProcess ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F1B023) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2002318893 ^ -2002363687));
			list.AddRange(processesByName.Select((Process process) => System.IO.Path.GetDirectoryName(process.MainModule.FileName)));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
		return list;
	}

	static TGsif1YXq0JNqauctK1A()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		c17QCRSxytlsLgwYFZyb();
	}

	internal static bool T8p2mZSxUJhdcvKJ3o3w()
	{
		return XLUP2XSxtVPI7AVXEtqT == null;
	}

	internal static TGsif1YXq0JNqauctK1A LwxHcvSxT7nfBLRKpoZg()
	{
		return XLUP2XSxtVPI7AVXEtqT;
	}

	internal static void c17QCRSxytlsLgwYFZyb()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
