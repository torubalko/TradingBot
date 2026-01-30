using System;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using TigerTrade.Chart.Base;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace KOWTjitUGjuJFvGRVgp;

[DataContract(Name = "VolSearchSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal sealed class zZ77elttXdmgb52J26H : KqZtUj2kTEAQfYBkeSKy
{
	private DataCycle Gu4tAT1fun;

	private TimeSpan XdvtPdOECd;

	private TimeSpan bQEtJaOiMH;

	private int NpAtF3OK9C;

	private int R79t3R7MGK;

	private int MbUtpUMgSI;

	internal static zZ77elttXdmgb52J26H HlH1Xc4lKykbFYoBJpWH;

	[DataMember(Name = "DataCycle")]
	public DataCycle DataCycle
	{
		get
		{
			return Gu4tAT1fun ?? (Gu4tAT1fun = (DataCycle)hQ5usQ4lweinoyiQeOMe());
		}
		set
		{
			if (!object.Equals(dataCycle, Gu4tAT1fun))
			{
				Gu4tAT1fun = dataCycle;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr((string)gEbbET4l70BMn8ayiX13(0x6D18F862 ^ 0x6D18B188));
			}
		}
	}

	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return XdvtPdOECd;
		}
		set
		{
			if (!(timeSpan == XdvtPdOECd))
			{
				XdvtPdOECd = timeSpan;
				ifWlfmRSlkr((string)gEbbET4l70BMn8ayiX13(-624753169 ^ -624735869));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
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

	[DataMember(Name = "EndTime")]
	public TimeSpan EndTime
	{
		get
		{
			return bQEtJaOiMH;
		}
		set
		{
			if (!lmhaMC4l8b1WBih51l9v(timeSpan, bQEtJaOiMH))
			{
				bQEtJaOiMH = timeSpan;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-165474503 ^ -165461061));
			}
		}
	}

	[DataMember(Name = "BarSizeFrom")]
	public int BarSizeFrom
	{
		get
		{
			return NpAtF3OK9C;
		}
		set
		{
			num = Math.Max(0, num);
			if (num != NpAtF3OK9C)
			{
				NpAtF3OK9C = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774586721));
			}
		}
	}

	[DataMember(Name = "BarSizeTo")]
	public int BarSizeTo
	{
		get
		{
			return R79t3R7MGK;
		}
		set
		{
			num = WTDnHm4lAbkE5gfHGklq(0, num);
			if (num == R79t3R7MGK)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				R79t3R7MGK = num;
				ifWlfmRSlkr((string)gEbbET4l70BMn8ayiX13(-837284864 ^ -837271378));
			}
		}
	}

	[DataMember(Name = "PriceScale")]
	public int PriceScale
	{
		get
		{
			return MbUtpUMgSI;
		}
		set
		{
			num = Math.Max(1, num);
			if (num != MbUtpUMgSI)
			{
				MbUtpUMgSI = num;
				ifWlfmRSlkr((string)gEbbET4l70BMn8ayiX13(-838841832 ^ -838859044));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
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

	public override string DefaultTitle => Resources.VolSearchControlTitle;

	public zZ77elttXdmgb52J26H()
	{
		SdgFsu4lPkGusugPi5SI();
		base._002Ector();
		base.vlP2kmioDGU = (string)XuoaOR4lJEsF1N1wrM6J(this);
		DataCycle = DataCycle.Minute;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				StartTime = TimeSpan.FromSeconds(0.0);
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				EndTime = TimeSpan.FromSeconds(86399.0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 0;
				}
				break;
			default:
				BarSizeFrom = 0;
				num = 2;
				break;
			case 2:
				BarSizeTo = 0;
				PriceScale = 1;
				return;
			}
		}
	}

	static zZ77elttXdmgb52J26H()
	{
		n7GSle4lFjiHV1ayYS5y();
	}

	internal static object hQ5usQ4lweinoyiQeOMe()
	{
		return DataCycle.Minute;
	}

	internal static bool cgs7bF4lmgUcTup9Imki()
	{
		return HlH1Xc4lKykbFYoBJpWH == null;
	}

	internal static zZ77elttXdmgb52J26H rLINqP4lhqKGwher3O7x()
	{
		return HlH1Xc4lKykbFYoBJpWH;
	}

	internal static object gEbbET4l70BMn8ayiX13(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool lmhaMC4l8b1WBih51l9v(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static int WTDnHm4lAbkE5gfHGklq(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void SdgFsu4lPkGusugPi5SI()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object XuoaOR4lJEsF1N1wrM6J(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).DefaultTitle;
	}

	internal static void n7GSle4lFjiHV1ayYS5y()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
