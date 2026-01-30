using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ExternalChartBorderType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ExternalChartBorderType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBorderNone")]
	[EnumMember(Value = "None")]
	None,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBorderBox")]
	[EnumMember(Value = "Box")]
	Box,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBorderColoredBox")]
	[EnumMember(Value = "ColoredBox")]
	ColoredBox,
	[EnumMember(Value = "Candle")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBorderCandle")]
	Candle,
	[EnumMember(Value = "ColoredCandle")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBorderColoredCandle")]
	ColoredCandle
}
