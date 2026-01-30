using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "ClusterSearchPriceRangeDirection", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ClusterSearchPriceRangeDirection
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBoth")]
	[EnumMember(Value = "All")]
	All,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDownward")]
	[EnumMember(Value = "Downward")]
	Downward,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsUpward")]
	[EnumMember(Value = "Upward")]
	Upward
}
