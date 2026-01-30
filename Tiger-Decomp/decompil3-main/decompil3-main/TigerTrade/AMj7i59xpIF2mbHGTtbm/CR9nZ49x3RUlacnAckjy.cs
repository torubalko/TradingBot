using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using O4MOGg9s9Mb8ki42CBMv;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace AMj7i59xpIF2mbHGTtbm;

[DataContract(Name = "ChartAreaSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Settings")]
internal sealed class CR9nZ49x3RUlacnAckjy : VUcpcX9sfGdSlTmYZQvV
{
	[Serializable]
	[CompilerGenerated]
	private sealed class fSSSYMnFOcVnO5pTbdNG
	{
		public static readonly fSSSYMnFOcVnO5pTbdNG MLknFWVELZk;

		public static Func<IndicatorBase, IndicatorBase> ieLnFtMxOan;

		public static Func<ObjectBase, ObjectBase> iJ2nFUM2LUo;

		private static fSSSYMnFOcVnO5pTbdNG eECac4NqWfgSGKqtTbsA;

		static fSSSYMnFOcVnO5pTbdNG()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			MLknFWVELZk = new fSSSYMnFOcVnO5pTbdNG();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public fSSSYMnFOcVnO5pTbdNG()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal IndicatorBase fWHnFqMm9ey(IndicatorBase x)
		{
			return (IndicatorBase)x.Clone();
		}

		internal ObjectBase RTsnFIrmGqJ(ObjectBase x)
		{
			return (ObjectBase)x.Clone();
		}

		internal static bool I8MXrmNqtXAXVrCg8WDL()
		{
			return eECac4NqWfgSGKqtTbsA == null;
		}

		internal static fSSSYMnFOcVnO5pTbdNG eGcxlpNqUm0HiEWN3h6t()
		{
			return eECac4NqWfgSGKqtTbsA;
		}
	}

	[CompilerGenerated]
	private bool yoI9L4MSQMB;

	[CompilerGenerated]
	private double Kn29LDwMqdV;

	[CompilerGenerated]
	private double GvC9LbyVdrC;

	private double AvI9LNuh7Rm;

	private List<IndicatorBase> Njj9LkXEbCV;

	private List<ObjectBase> nmQ9L19gN3d;

	private static CR9nZ49x3RUlacnAckjy CoL4SEbX9m8aFA72YkNU;

	[DataMember(Name = "AxisYAutoScale")]
	public bool O5c9L0lq8xM
	{
		[CompilerGenerated]
		get
		{
			return yoI9L4MSQMB;
		}
		[CompilerGenerated]
		set
		{
			yoI9L4MSQMB = flag;
		}
	}

	[DataMember(Name = "AxisYMinY")]
	public double tGx9LfShjhS
	{
		[CompilerGenerated]
		get
		{
			return Kn29LDwMqdV;
		}
		[CompilerGenerated]
		set
		{
			Kn29LDwMqdV = kn29LDwMqdV;
		}
	}

	[DataMember(Name = "AxisYMaxY")]
	public double fvV9LGhbj47
	{
		[CompilerGenerated]
		get
		{
			return GvC9LbyVdrC;
		}
		[CompilerGenerated]
		set
		{
			GvC9LbyVdrC = gvC9LbyVdrC;
		}
	}

	[DataMember(Name = "HeightPercent")]
	public double xQf9Lvc4eGy
	{
		get
		{
			return AvI9LNuh7Rm;
		}
		set
		{
			num = Math.Max(num, 1.0);
			AvI9LNuh7Rm = num;
		}
	}

	[DataMember(Name = "Indicators")]
	public List<IndicatorBase> Indicators
	{
		get
		{
			return Njj9LkXEbCV ?? (Njj9LkXEbCV = new List<IndicatorBase>());
		}
		set
		{
			Njj9LkXEbCV = njj9LkXEbCV;
		}
	}

	[DataMember(Name = "Objects")]
	public List<ObjectBase> Objects
	{
		get
		{
			return nmQ9L19gN3d ?? (nmQ9L19gN3d = new List<ObjectBase>());
		}
		set
		{
			nmQ9L19gN3d = list;
		}
	}

	public CR9nZ49x3RUlacnAckjy()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		xQf9Lvc4eGy = 1.0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Objects = new List<ObjectBase>();
				return;
			case 1:
				Indicators = new List<IndicatorBase>();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override object Clone()
	{
		return new CR9nZ49x3RUlacnAckjy
		{
			xQf9Lvc4eGy = xQf9Lvc4eGy,
			Indicators = new List<IndicatorBase>(Indicators.Select((IndicatorBase x) => (IndicatorBase)x.Clone())),
			Objects = new List<ObjectBase>(Objects.Select((ObjectBase x) => (ObjectBase)x.Clone()))
		};
	}

	static CR9nZ49x3RUlacnAckjy()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool aXXe2TbXnBKU4HtKJoOH()
	{
		return CoL4SEbX9m8aFA72YkNU == null;
	}

	internal static CR9nZ49x3RUlacnAckjy pqqcWabXG9E394W7K64Q()
	{
		return CoL4SEbX9m8aFA72YkNU;
	}
}
