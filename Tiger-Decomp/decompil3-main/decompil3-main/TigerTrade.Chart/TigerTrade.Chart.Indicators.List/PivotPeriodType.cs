using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "PivotPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum PivotPeriodType
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
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	[EnumMember(Value = "Week")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month
}
