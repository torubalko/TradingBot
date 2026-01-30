using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "DeltaViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum DeltaViewType
{
	[EnumMember(Value = "Columns")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsColumns")]
	Columns,
	[EnumMember(Value = "Candles")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsCandles")]
	Candles
}
