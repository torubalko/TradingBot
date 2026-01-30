using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterStatisticPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ClusterStatisticPeriodType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDay")]
	[EnumMember(Value = "Day")]
	Day,
	[EnumMember(Value = "Week")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsVisibleBars")]
	[EnumMember(Value = "VisibleBars")]
	VisibleBars,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAllBars")]
	[EnumMember(Value = "AllBars")]
	AllBars
}
