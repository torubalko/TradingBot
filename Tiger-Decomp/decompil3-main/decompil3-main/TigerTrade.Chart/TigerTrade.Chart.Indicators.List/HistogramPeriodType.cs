using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "HistogramPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum HistogramPeriodType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMinute")]
	[EnumMember(Value = "Minute")]
	Minute,
	[EnumMember(Value = "Hour")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHour")]
	Hour,
	[EnumMember(Value = "Day")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDay")]
	Day,
	[EnumMember(Value = "Week")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month,
	[EnumMember(Value = "AllBars")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAllBars")]
	AllBars,
	[EnumMember(Value = "CustomDate")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsCustomDates")]
	CustomDate
}
