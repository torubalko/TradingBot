using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartHistogramViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ChartHistogramViewType
{
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramViewTypeEnumNone")]
	[EnumMember(Value = "None")]
	None,
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramViewTypeEnumVolume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramViewTypeEnumTrades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[EnumMember(Value = "Delta")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramViewTypeEnumDelta")]
	Delta,
	[EnumMember(Value = "BidAsk")]
	[Xdm5MC2tN0JMGo5PMYU("ChartHistogramViewTypeEnumBidAsk")]
	BidAsk
}
