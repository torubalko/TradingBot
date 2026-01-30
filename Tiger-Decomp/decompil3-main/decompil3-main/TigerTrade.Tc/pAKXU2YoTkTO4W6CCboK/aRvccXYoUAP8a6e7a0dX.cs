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

namespace pAKXU2YoTkTO4W6CCboK;

[DataContract(Name = "QuikSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.TradeClient")]
internal sealed class aRvccXYoUAP8a6e7a0dX : gpnr5oG8Q1cRMmiYT0Ut
{
	[Serializable]
	[CompilerGenerated]
	private sealed class CVXMHKaIsjoqvxf0oB1q
	{
		public static readonly CVXMHKaIsjoqvxf0oB1q pUEaIj1hTXr;

		public static Func<Process, bool> aJIaIEpHRh2;

		public static Func<Process, string> dAnaIQdgHhE;

		internal static CVXMHKaIsjoqvxf0oB1q Satnf4xzKbRR8MHFnMhK;

		static CVXMHKaIsjoqvxf0oB1q()
		{
			X6l5WExzwKKhk0d9grJf();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			pUEaIj1hTXr = new CVXMHKaIsjoqvxf0oB1q();
		}

		public CVXMHKaIsjoqvxf0oB1q()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool pZhaIXVBABV(Process process)
		{
			return process.MainWindowTitle.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-602153869 ^ -602264757));
		}

		internal string cBKaIcuL8jh(Process process)
		{
			return System.IO.Path.GetDirectoryName((string)X83qnPxz7iq2NLKUm0rV(process.MainModule));
		}

		internal static void X6l5WExzwKKhk0d9grJf()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static bool FngppIxzmJQJPQQ2D2Q3()
		{
			return Satnf4xzKbRR8MHFnMhK == null;
		}

		internal static CVXMHKaIsjoqvxf0oB1q O4pRQRxzhCTJGxuesgif()
		{
			return Satnf4xzKbRR8MHFnMhK;
		}

		internal static object X83qnPxz7iq2NLKUm0rV(object P_0)
		{
			return ((ProcessModule)P_0).FileName;
		}
	}

	[CompilerGenerated]
	private string aGEYomX5Qtt;

	[CompilerGenerated]
	private bool aLSYohEnsU8;

	private static aRvccXYoUAP8a6e7a0dX ofKLqSSvtecIRoLjkhRS;

	[DataMember(Name = "Path")]
	public string Path
	{
		[CompilerGenerated]
		get
		{
			return aGEYomX5Qtt;
		}
		[CompilerGenerated]
		set
		{
			aGEYomX5Qtt = text;
		}
	}

	[DataMember(Name = "AddClientCode")]
	public bool YVhYoKw66qp
	{
		[CompilerGenerated]
		get
		{
			return aLSYohEnsU8;
		}
		[CompilerGenerated]
		set
		{
			aLSYohEnsU8 = flag;
		}
	}

	public aRvccXYoUAP8a6e7a0dX()
	{
		Xis61PSvyX4b0si9TkWr();
		base._002Ector();
		Path = "";
		YVhYoKw66qp = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static List<string> eCdYoy90sK7()
	{
		List<string> list = new List<string>();
		try
		{
			Process[] processesByName = Process.GetProcessesByName(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x12620268 ^ 0x1263364C));
			list.AddRange(from process in processesByName
				where process.MainWindowTitle.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-602153869 ^ -602264757))
				select System.IO.Path.GetDirectoryName((string)CVXMHKaIsjoqvxf0oB1q.X83qnPxz7iq2NLKUm0rV(process.MainModule)));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
		return list;
	}

	static aRvccXYoUAP8a6e7a0dX()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Gbkp1mSvUp89l2afbWPw()
	{
		return ofKLqSSvtecIRoLjkhRS == null;
	}

	internal static aRvccXYoUAP8a6e7a0dX kJii0mSvT6HAjH9rC7GT()
	{
		return ofKLqSSvtecIRoLjkhRS;
	}

	internal static void Xis61PSvyX4b0si9TkWr()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
