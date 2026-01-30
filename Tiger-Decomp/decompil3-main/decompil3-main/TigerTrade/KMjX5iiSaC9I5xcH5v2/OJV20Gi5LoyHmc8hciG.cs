using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using bqeVc6Hkcwja5r4ba3lC;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Tc.Connectors.Simulator.Player;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace KMjX5iiSaC9I5xcH5v2;

internal sealed class OJV20Gi5LoyHmc8hciG : xRgq7gHkTVINiHGAKc0y, SUjI66HkXtx9pE409e96
{
	private Symbol DwIi6a6gYY;

	private string DZniMFLufK;

	private DateTime jCniOISX7n;

	private DateTime IcLiqPsMPV;

	[CompilerGenerated]
	private string sF7iINOELu;

	internal static OJV20Gi5LoyHmc8hciG xm3SLplJNdmjg6uZii2R;

	[Browsable(false)]
	public Symbol SymbolInstance
	{
		get
		{
			return DwIi6a6gYY;
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
					if (symbol != DwIi6a6gYY)
					{
						DwIi6a6gYY = symbol;
						JZYHkZsWiJ6((string)xvCrt2lJ5ODgBobUxykl(-1522697859 ^ -1522704953));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description("CustomTemplate_SymbolCustomTemplate")]
	[bBo0Zd2ycQQr3LNHQf4("PlayerViewModelSymbol")]
	public string Symbol
	{
		get
		{
			return DZniMFLufK;
		}
		private set
		{
			if (!(DZniMFLufK == text))
			{
				DZniMFLufK = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839659570));
			}
		}
	}

	[Description("Text")]
	[bBo0Zd2ycQQr3LNHQf4("PlayerViewModelRecordDate")]
	public DateTime RecordDate
	{
		get
		{
			return jCniOISX7n;
		}
		private set
		{
			if (!(jCniOISX7n == dateTime))
			{
				jCniOISX7n = dateTime;
				JZYHkZsWiJ6((string)xvCrt2lJ5ODgBobUxykl(0x2C8374E4 ^ 0x2C835F38));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
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

	[Description("Text")]
	[bBo0Zd2ycQQr3LNHQf4("PlayerViewModelCurrentTime")]
	public DateTime CurrentTime
	{
		get
		{
			return IcLiqPsMPV;
		}
		private set
		{
			if (!xKkUeJlJSkjbVJOmQjK1(IcLiqPsMPV, dateTime))
			{
				IcLiqPsMPV = dateTime;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-837284864 ^ -837285048));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
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

	[Browsable(false)]
	public string FwTiRd8gfr
	{
		[CompilerGenerated]
		get
		{
			return sF7iINOELu;
		}
		[CompilerGenerated]
		set
		{
			sF7iINOELu = text;
		}
	}

	public OJV20Gi5LoyHmc8hciG(HistoryPlayerStats P_0)
	{
		t588prlJxqygs2Cnegkd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				SymbolInstance = SymbolManager.Get((string)OCQMfJlJLs0RCoLok6QY(P_0));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				RecordDate = aXpBkFlJem2Mso10UtGt(P_0);
				CurrentTime = P_0.CurrentTime;
				return;
			}
			FwTiRd8gfr = P_0.SymbolID;
			Symbol = P_0.SymbolName;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
			{
				num = 2;
			}
		}
	}

	public void U6Aix9k4np(HistoryPlayerStats P_0)
	{
		CurrentTime = P_0.CurrentTime;
	}

	public string p7dlf5mDray(string P_0)
	{
		return null;
	}

	public string mPRlfSGJFfc(string P_0)
	{
		if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x4222674)))
		{
			if (!ialNStlJsPsN3lDtSRtP(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2DFCA5)))
			{
				return null;
			}
			DateTime dateTime = CurrentTime;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				return dateTime.ToString((string)xvCrt2lJ5ODgBobUxykl(0x5CD4F15 ^ 0x5CD6F13)) + (string)xvCrt2lJ5ODgBobUxykl(0x32DEA4F1 ^ 0x32DE854B) + CurrentTime.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315AB6D7));
			}
		}
		return RecordDate.ToString((string)xvCrt2lJ5ODgBobUxykl(-962524685 ^ -962516491));
	}

	public string qgqlfxHoAfJ(string P_0)
	{
		return "";
	}

	static OJV20Gi5LoyHmc8hciG()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object xvCrt2lJ5ODgBobUxykl(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool UxiLIDlJkZI6Yu8hBmOr()
	{
		return xm3SLplJNdmjg6uZii2R == null;
	}

	internal static OJV20Gi5LoyHmc8hciG sGxOJ1lJ1LyhhDkIJStQ()
	{
		return xm3SLplJNdmjg6uZii2R;
	}

	internal static bool xKkUeJlJSkjbVJOmQjK1(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static void t588prlJxqygs2Cnegkd()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object OCQMfJlJLs0RCoLok6QY(object P_0)
	{
		return ((HistoryPlayerStats)P_0).SymbolID;
	}

	internal static DateTime aXpBkFlJem2Mso10UtGt(object P_0)
	{
		return ((HistoryPlayerStats)P_0).RecordDate;
	}

	internal static bool ialNStlJsPsN3lDtSRtP(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
