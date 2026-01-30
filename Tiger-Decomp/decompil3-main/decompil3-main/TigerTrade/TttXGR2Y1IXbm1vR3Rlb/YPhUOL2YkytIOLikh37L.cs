using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TttXGR2Y1IXbm1vR3Rlb;

[DataContract(Name = "StatisticsSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal sealed class YPhUOL2YkytIOLikh37L : KqZtUj2kTEAQfYBkeSKy
{
	private List<string> hyr2YZZXjcP;

	private List<(string, string)> uYU2YV0DA0Q;

	private List<string> Mbm2YCCgLVC;

	private List<string> DuK2YrvD6aQ;

	private DateTime? yGS2YKFHvjM;

	private DateTime? NCP2YmN3TaB;

	private TimeSpan Lq32YhSkkmN;

	private TimeSpan ixG2YwwWu3I;

	private bool w212Y7a07tG;

	[CompilerGenerated]
	private double J6x2Y8J6qQ5;

	[CompilerGenerated]
	private double Wof2YA268aQ;

	internal static YPhUOL2YkytIOLikh37L HPCkGf4MgFH61BhGyX1Y;

	[DataMember(Name = "Accounts")]
	[Obsolete("Backward compatibility")]
	public List<string> Accounts
	{
		get
		{
			return hyr2YZZXjcP ?? (hyr2YZZXjcP = new List<string>());
		}
		set
		{
			if (list != hyr2YZZXjcP)
			{
				hyr2YZZXjcP = list;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416979673));
			}
		}
	}

	[DataMember(Name = "AccountNameIds")]
	public List<(string AccountName, string AccountID)> AccountNameIds
	{
		get
		{
			return uYU2YV0DA0Q ?? (uYU2YV0DA0Q = new List<(string, string)>());
		}
		set
		{
			if (list != uYU2YV0DA0Q)
			{
				uYU2YV0DA0Q = list;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86E6612));
			}
		}
	}

	[DataMember(Name = "Symbols")]
	public List<string> Symbols
	{
		get
		{
			return Mbm2YCCgLVC ?? (Mbm2YCCgLVC = new List<string>());
		}
		set
		{
			if (list != Mbm2YCCgLVC)
			{
				Mbm2YCCgLVC = list;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44547763));
			}
		}
	}

	[DataMember(Name = "Tags")]
	public List<string> Tags
	{
		get
		{
			return DuK2YrvD6aQ ?? (DuK2YrvD6aQ = new List<string>());
		}
		set
		{
			if (list != DuK2YrvD6aQ)
			{
				DuK2YrvD6aQ = list;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801498478));
			}
		}
	}

	[DataMember(Name = "StartDate")]
	public DateTime? StartDate
	{
		get
		{
			return yGS2YKFHvjM;
		}
		set
		{
			if (!(dateTime == yGS2YKFHvjM))
			{
				yGS2YKFHvjM = dateTime;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602172951));
			}
		}
	}

	[DataMember(Name = "EndDate")]
	public DateTime? EndDate
	{
		get
		{
			return NCP2YmN3TaB;
		}
		set
		{
			if (!(dateTime == NCP2YmN3TaB))
			{
				NCP2YmN3TaB = dateTime;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435581023));
			}
		}
	}

	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return Lq32YhSkkmN;
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
					if (!KiYsLF4MMFwpbhxTMPHT(timeSpan, Lq32YhSkkmN))
					{
						Lq32YhSkkmN = timeSpan;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BEE126));
					}
					return;
				case 1:
					timeSpan = new TimeSpan(timeSpan.Ticks - timeSpan.Ticks % 600000000);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num2 = 0;
					}
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
			return ixG2YwwWu3I;
		}
		set
		{
			int num = 1;
			int num2 = num;
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 1:
					timeSpan = new TimeSpan(timeSpan2.Ticks - timeSpan2.Ticks % 600000000);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				timeSpan2 = timeSpan.Add(TimeSpan.FromTicks(599999999L));
				if (timeSpan2 == ixG2YwwWu3I)
				{
					return;
				}
				ixG2YwwWu3I = timeSpan2;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57751347));
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[DataMember(Name = "IsPnlWidgetWindow")]
	public bool IsPnlWidgetWindow
	{
		get
		{
			return w212Y7a07tG;
		}
		set
		{
			if (flag != w212Y7a07tG)
			{
				w212Y7a07tG = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr((string)hCuhCY4MOYNRPNMkscN6(0x12620268 ^ 0x12629B6C));
			}
		}
	}

	[DataMember(Name = "GridRow1Height")]
	public double x6R2YtQa6Vf
	{
		[CompilerGenerated]
		get
		{
			return J6x2Y8J6qQ5;
		}
		[CompilerGenerated]
		set
		{
			J6x2Y8J6qQ5 = j6x2Y8J6qQ;
		}
	}

	[DataMember(Name = "GridRow2Height")]
	public double U0v2YyMet6o
	{
		[CompilerGenerated]
		get
		{
			return Wof2YA268aQ;
		}
		[CompilerGenerated]
		set
		{
			Wof2YA268aQ = wof2YA268aQ;
		}
	}

	public override string DefaultTitle => Resources.StatisticsControlTitle;

	public YPhUOL2YkytIOLikh37L()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.vlP2kmioDGU = (string)MeZ4ue4Mq0NP34ca3aCP(this);
		StartDate = null;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				StartTime = TimeSpan.FromSeconds(0.0);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				EndDate = null;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				EndTime = TimeSpan.FromSeconds(86399.0);
				return;
			}
		}
	}

	static YPhUOL2YkytIOLikh37L()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool KiYsLF4MMFwpbhxTMPHT(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static bool oMa1J14MRQYxYJRNmoVT()
	{
		return HPCkGf4MgFH61BhGyX1Y == null;
	}

	internal static YPhUOL2YkytIOLikh37L JL44wA4M6F9r80OiDjXq()
	{
		return HPCkGf4MgFH61BhGyX1Y;
	}

	internal static object hCuhCY4MOYNRPNMkscN6(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object MeZ4ue4Mq0NP34ca3aCP(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).DefaultTitle;
	}
}
