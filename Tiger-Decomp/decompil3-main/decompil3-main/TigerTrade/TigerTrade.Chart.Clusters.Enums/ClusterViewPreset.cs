using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterViewPreset", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ClusterViewPreset
{
	[EnumMember(Value = "Volume")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolume")]
	Volume,
	[EnumMember(Value = "VolumeProfile")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeProfile")]
	VolumeProfile,
	[EnumMember(Value = "VolumeHistogram")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeHistogram")]
	VolumeHistogram,
	[EnumMember(Value = "VolumeDeltaColored")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaColoredVolume")]
	VolumeDeltaColored,
	[EnumMember(Value = "VolumeProfileDeltaColored")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaColoredVolumeProfile")]
	VolumeProfileDeltaColored,
	[EnumMember(Value = "VolumeTrade")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeTrade")]
	VolumeTrade,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeTradeProfile")]
	[EnumMember(Value = "VolumeTradeProfile")]
	VolumeTradeProfile,
	[EnumMember(Value = "VolumeTradeHistogram")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeTradeHistogram")]
	VolumeTradeHistogram,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeDelta")]
	[EnumMember(Value = "VolumeDelta")]
	VolumeDelta,
	[EnumMember(Value = "VolumeDeltaProfile")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeDeltaProfile")]
	VolumeDeltaProfile,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumVolumeDeltaHistogram")]
	[EnumMember(Value = "VolumeDeltaHistogram")]
	VolumeDeltaHistogram,
	[EnumMember(Value = "Trades")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumTrades")]
	Trades,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumTradesProfile")]
	[EnumMember(Value = "TradesProfile")]
	TradesProfile,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumTradesHistogram")]
	[EnumMember(Value = "TradesHistogram")]
	TradesHistogram,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaColoredTrades")]
	[EnumMember(Value = "TradesDeltaColored")]
	TradesDeltaColored,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaColoredTradesProfile")]
	[EnumMember(Value = "TradesProfileDeltaColored")]
	TradesProfileDeltaColored,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAsk")]
	[EnumMember(Value = "BidAsk")]
	BidAsk,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskLadder")]
	[EnumMember(Value = "BidAskLadder")]
	BidAskLadder,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskProfile")]
	[EnumMember(Value = "BidAskProfile")]
	BidAskProfile,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskHistogram")]
	[EnumMember(Value = "BidAskHistogram")]
	BidAskHistogram,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskVolumeProfile")]
	[EnumMember(Value = "BidAskVolumeProfile")]
	BidAskVolumeProfile,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskDeltaProfile")]
	[EnumMember(Value = "BidAskDeltaProfile")]
	BidAskDeltaProfile,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumBidAskImbalance")]
	[EnumMember(Value = "BidAskImbalance")]
	BidAskImbalance,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDelta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaProfile")]
	[EnumMember(Value = "DeltaProfile")]
	DeltaProfile,
	[EnumMember(Value = "DeltaHistogram")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumDeltaHistogram")]
	DeltaHistogram,
	[EnumMember(Value = "OpenPos")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumOpenPos")]
	OpenPos,
	[EnumMember(Value = "OpenPosProfile")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumOpenPosProfile")]
	OpenPosProfile,
	[EnumMember(Value = "OpenPosHistogram")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterViewPresetEnumOpenPosHistogram")]
	OpenPosHistogram
}
