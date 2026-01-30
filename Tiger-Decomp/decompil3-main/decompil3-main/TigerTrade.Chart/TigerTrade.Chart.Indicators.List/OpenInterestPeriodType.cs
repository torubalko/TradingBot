using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "OpenInterestPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum OpenInterestPeriodType
{
	[EnumMember(Value = "Bar")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBar")]
	Bar,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDay")]
	[EnumMember(Value = "Day")]
	Day,
	[EnumMember(Value = "Week")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAllBars")]
	[EnumMember(Value = "AllBars")]
	AllBars
}
