using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TuAMtrl1Nd3XoZQQUXf0;

namespace OenvRDHFM4UEmgd04YLD;

[DataContract(Name = "PeriodsCollection", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Periods")]
internal sealed class VFjquqHF6WkrYGAMBAX6
{
	private List<DataCycle> JpvHFWHhw4Y;

	private static VFjquqHF6WkrYGAMBAX6 opdM9ZDZfCIULvXbuLDc;

	public static List<DataCycle> Default => new List<DataCycle>
	{
		new DataCycle(DataCycleBase.Tick, 1),
		new DataCycle(DataCycleBase.Second, 5),
		new DataCycle(DataCycleBase.Second, 15),
		new DataCycle(DataCycleBase.Second, 30),
		new DataCycle(DataCycleBase.Minute, 1),
		new DataCycle(DataCycleBase.Minute, 5),
		new DataCycle(DataCycleBase.Minute, 15),
		new DataCycle(DataCycleBase.Minute, 30),
		new DataCycle(DataCycleBase.Hour, 1),
		new DataCycle(DataCycleBase.Hour, 4),
		new DataCycle(DataCycleBase.Day, 1),
		new DataCycle(DataCycleBase.Week, 1),
		new DataCycle(DataCycleBase.Month, 1),
		new DataCycle(DataCycleBase.Year, 1)
	};

	[DataMember(Name = "Periods")]
	[Browsable(false)]
	public List<DataCycle> Periods
	{
		get
		{
			return JpvHFWHhw4Y ?? (JpvHFWHhw4Y = new List<DataCycle>(Default));
		}
		set
		{
			JpvHFWHhw4Y = jpvHFWHhw4Y;
		}
	}

	public VFjquqHF6WkrYGAMBAX6()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static VFjquqHF6WkrYGAMBAX6()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool JZlZGhDZ9rfZHjRC6HQF()
	{
		return opdM9ZDZfCIULvXbuLDc == null;
	}

	internal static VFjquqHF6WkrYGAMBAX6 ucJcbeDZnfU421jGGn7Z()
	{
		return opdM9ZDZfCIULvXbuLDc;
	}
}
