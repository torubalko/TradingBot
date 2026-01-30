using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "ExternalChartPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ExternalChartPeriodType
{
	[EnumMember(Value = "Minute")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMinute")]
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
	Month
}
