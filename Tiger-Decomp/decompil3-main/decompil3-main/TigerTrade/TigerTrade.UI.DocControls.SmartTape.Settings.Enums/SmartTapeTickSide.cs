using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.UI.DocControls.SmartTape.Settings.Enums;

[DataContract(Name = "SmartTapeTickSide", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.SmartTape.Settings")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum SmartTapeTickSide
{
	[Xdm5MC2tN0JMGo5PMYU("SmartTapeTickSideEnumAny")]
	[EnumMember(Value = "Any")]
	Any,
	[Xdm5MC2tN0JMGo5PMYU("SmartTapeTickSideEnumBuy")]
	[EnumMember(Value = "Buy")]
	Buy,
	[EnumMember(Value = "Sell")]
	[Xdm5MC2tN0JMGo5PMYU("SmartTapeTickSideEnumSell")]
	Sell
}
