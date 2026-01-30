using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[DataContract(Name = "IndicatorViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum IndicatorViewType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsColumns")]
	[EnumMember(Value = "Columns")]
	Columns,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsCandles")]
	[EnumMember(Value = "Candles")]
	Candles,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsLine")]
	[EnumMember(Value = "Line")]
	Line
}
