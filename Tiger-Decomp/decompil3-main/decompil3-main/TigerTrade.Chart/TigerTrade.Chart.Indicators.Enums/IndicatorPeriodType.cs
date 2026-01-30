using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "IndicatorPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum IndicatorPeriodType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDay")]
	[EnumMember(Value = "Day")]
	Day,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	[EnumMember(Value = "Week")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAllBars")]
	[EnumMember(Value = "AllBars")]
	AllBars
}
