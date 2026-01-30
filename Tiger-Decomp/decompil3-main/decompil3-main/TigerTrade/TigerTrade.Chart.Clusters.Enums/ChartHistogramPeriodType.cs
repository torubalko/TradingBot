using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartHistogramRangeType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ChartHistogramPeriodType
{
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumCurrentDay")]
	[EnumMember(Value = "CurrentDay")]
	CurrentDay,
	[EnumMember(Value = "LastDay")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumLastDay")]
	LastDay,
	[EnumMember(Value = "CurrentWeek")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumCurrentWeek")]
	CurrentWeek,
	[EnumMember(Value = "LastWeek")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumLastWeek")]
	LastWeek,
	[EnumMember(Value = "CurrentMonth")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumCurrentMonth")]
	CurrentMonth,
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumLastMonth")]
	[EnumMember(Value = "LastMonth")]
	LastMonth,
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramPeriodTypeEnumContract")]
	[EnumMember(Value = "Contract")]
	Contract
}
