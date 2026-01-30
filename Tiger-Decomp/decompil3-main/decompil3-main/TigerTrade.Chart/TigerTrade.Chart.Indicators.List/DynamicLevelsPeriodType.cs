using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "DynamicLevelsPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum DynamicLevelsPeriodType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHour")]
	[EnumMember(Value = "Hour")]
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
	AllBars
}
