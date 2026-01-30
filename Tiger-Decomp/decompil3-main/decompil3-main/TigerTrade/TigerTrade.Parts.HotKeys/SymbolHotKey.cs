using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Parts.HotKeys;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "SymbolHotKey", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.HotKeys")]
public enum SymbolHotKey
{
	[Xdm5MC2tN0JMGo5PMYU("SymbolHotKeyEnumNone")]
	[EnumMember(Value = "None")]
	None,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysSymbol1")]
	[EnumMember(Value = "Symbol1")]
	Symbol1,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysSymbol2")]
	[EnumMember(Value = "Symbol2")]
	Symbol2,
	[EnumMember(Value = "Symbol3")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysSymbol3")]
	Symbol3,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysSymbol4")]
	[EnumMember(Value = "Symbol4")]
	Symbol4,
	[EnumMember(Value = "Symbol5")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysSymbol5")]
	Symbol5
}
