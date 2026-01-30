using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterFilterType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ClusterFilterType
{
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumNone")]
	[EnumMember(Value = "None")]
	None,
	[EnumMember(Value = "Volume")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumVolume")]
	Volume,
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumTrades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[EnumMember(Value = "Bid")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumBid")]
	Bid,
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumAsk")]
	[EnumMember(Value = "Ask")]
	Ask,
	[EnumMember(Value = "Delta")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumDelta")]
	Delta,
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumDeltaPlus")]
	[EnumMember(Value = "DeltaPlus")]
	DeltaPlus,
	[EnumMember(Value = "DeltaMinus")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterFilterTypeEnumDeltaMinus")]
	DeltaMinus
}
