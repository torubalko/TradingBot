using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Parts.HotKeys;

[DataContract(Name = "MarketMouseControl", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.HotKeys")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum MarketMouseControl
{
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumDisableMouse")]
	[EnumMember(Value = "Disabled")]
	Disabled,
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumAuto")]
	[EnumMember(Value = "Auto")]
	Auto,
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumBuySellStop")]
	[EnumMember(Value = "BuySellStop")]
	BuySellStop,
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumBuySell")]
	[EnumMember(Value = "BuySell")]
	BuySell,
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumSellBuy")]
	[EnumMember(Value = "SellBuy")]
	SellBuy,
	[EnumMember(Value = "MarketLimit")]
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumMarketLimit")]
	MarketLimit,
	[EnumMember(Value = "LimitMarket")]
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumLimitMarket")]
	LimitMarket,
	[Xdm5MC2tN0JMGo5PMYU("TradeMouseControlEnumPlaceCancel")]
	[EnumMember(Value = "PlaceCancel")]
	PlaceCancel
}
