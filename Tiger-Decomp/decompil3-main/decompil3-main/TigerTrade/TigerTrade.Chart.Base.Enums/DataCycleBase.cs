using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Base.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "DataCycleBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum DataCycleBase
{
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumSecond")]
	[EnumMember(Value = "Second")]
	Second,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumMinute")]
	[EnumMember(Value = "Minute")]
	Minute,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumHour")]
	[EnumMember(Value = "Hour")]
	Hour,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumDay")]
	[EnumMember(Value = "Day")]
	Day,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumWeek")]
	[EnumMember(Value = "Week")]
	Week,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumMonth")]
	[EnumMember(Value = "Month")]
	Month,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumYear")]
	[EnumMember(Value = "Year")]
	Year,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumTick")]
	[EnumMember(Value = "Tick")]
	Tick,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumVolume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumDelta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumRange")]
	[EnumMember(Value = "Range")]
	Range,
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumRenko")]
	[EnumMember(Value = "Renko")]
	Renko,
	[EnumMember(Value = "Reversal")]
	[Xdm5MC2tN0JMGo5PMYU("DataCycleBaseEnumReversal")]
	Reversal
}
