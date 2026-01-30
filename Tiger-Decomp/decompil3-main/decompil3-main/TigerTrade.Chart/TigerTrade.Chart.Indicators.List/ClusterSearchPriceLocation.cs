using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterSearchPriceLocation", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ClusterSearchPriceLocation
{
	[EnumMember(Value = "Any")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAny")]
	Any,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHigh")]
	[EnumMember(Value = "High")]
	High,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsLow")]
	[EnumMember(Value = "Low")]
	Low,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHighLow")]
	[EnumMember(Value = "HighLow")]
	HighLow,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBody")]
	[EnumMember(Value = "Body")]
	Body,
	[EnumMember(Value = "Wick")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWick")]
	Wick,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsUpperWick")]
	[EnumMember(Value = "UpperWick")]
	UpperWick,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsLowerWick")]
	[EnumMember(Value = "LowerWick")]
	LowerWick
}
