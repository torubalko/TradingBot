using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "DepthOfMarketScaleAlignment", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum DepthOfMarketScaleAlignment
{
	[EnumMember(Value = "Left")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsScaleAlignmentLeft")]
	Left,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsScaleAlignmentRight")]
	[EnumMember(Value = "Right")]
	Right
}
