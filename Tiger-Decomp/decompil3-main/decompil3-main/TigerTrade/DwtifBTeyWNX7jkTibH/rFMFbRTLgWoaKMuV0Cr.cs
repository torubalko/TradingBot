using System;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace DwtifBTeyWNX7jkTibH;

[DataContract(Name = "AllPriceSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal sealed class rFMFbRTLgWoaKMuV0Cr : KqZtUj2kTEAQfYBkeSKy
{
	private DateTime UnKTMr57mR;

	private DateTime XX3TObRBlB;

	private TimeSpan cZVTqjrC8u;

	private TimeSpan wK5TISFKeW;

	private int jTmTW9P5PV;

	private static rFMFbRTLgWoaKMuV0Cr pKF8iV44ppqGYOKAGnCg;

	[DataMember(Name = "StartDate")]
	public DateTime StartDate
	{
		get
		{
			return UnKTMr57mR;
		}
		set
		{
			if (!(dateTime == UnKTMr57mR))
			{
				UnKTMr57mR = dateTime;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342722876));
			}
		}
	}

	[DataMember(Name = "EndDate")]
	public DateTime EndDate
	{
		get
		{
			return XX3TObRBlB;
		}
		set
		{
			if (!b9hlqJ4D0863aP5E7y7I(dateTime, XX3TObRBlB))
			{
				XX3TObRBlB = dateTime;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr((string)Ejp5fj4D2UaT6lN1gDiv(-1522697859 ^ -1522715443));
			}
		}
	}

	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return cZVTqjrC8u;
		}
		set
		{
			if (!(timeSpan == cZVTqjrC8u))
			{
				cZVTqjrC8u = timeSpan;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520142307));
			}
		}
	}

	[DataMember(Name = "EndTime")]
	public TimeSpan EndTime
	{
		get
		{
			return wK5TISFKeW;
		}
		set
		{
			if (!sUtHO14DHM3Q2r7LoWpu(timeSpan, wK5TISFKeW))
			{
				wK5TISFKeW = timeSpan;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr((string)Ejp5fj4D2UaT6lN1gDiv(0x7F645F3C ^ 0x7F6413BE));
			}
		}
	}

	[DataMember(Name = "PriceScale")]
	public int PriceScale
	{
		get
		{
			return jTmTW9P5PV;
		}
		set
		{
			num = Math.Max(1, num);
			if (num != jTmTW9P5PV)
			{
				jTmTW9P5PV = num;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606913820));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
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

	public override string DefaultTitle => Resources.AllPriceControlTitle;

	public rFMFbRTLgWoaKMuV0Cr()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.vlP2kmioDGU = DefaultTitle;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				EndTime = BHXKs34D9LEncKillqbT(86399.0);
				PriceScale = 1;
				return;
			case 1:
			{
				EndDate = TimeHelper.LocalTime.Date;
				StartTime = BHXKs34D9LEncKillqbT(0.0);
				int num2 = 2;
				num = num2;
				continue;
			}
			}
			StartDate = lxXvN74DfSMr3cpQWeBX().Date;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
			{
				num = 1;
			}
		}
	}

	static rFMFbRTLgWoaKMuV0Cr()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool JZ1FoO44u2gnFEU6QPDM()
	{
		return pKF8iV44ppqGYOKAGnCg == null;
	}

	internal static rFMFbRTLgWoaKMuV0Cr R4uJCU44zKNOfZe0pCr1()
	{
		return pKF8iV44ppqGYOKAGnCg;
	}

	internal static bool b9hlqJ4D0863aP5E7y7I(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static object Ejp5fj4D2UaT6lN1gDiv(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool sUtHO14DHM3Q2r7LoWpu(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime lxXvN74DfSMr3cpQWeBX()
	{
		return TimeHelper.LocalTime;
	}

	internal static TimeSpan BHXKs34D9LEncKillqbT(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}
}
