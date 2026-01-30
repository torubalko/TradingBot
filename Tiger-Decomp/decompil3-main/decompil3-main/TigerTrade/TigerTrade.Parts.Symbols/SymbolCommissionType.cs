using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Parts.Symbols;

[DataContract(Name = "SymbolCommissionType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Symbols")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum SymbolCommissionType
{
	[Xdm5MC2tN0JMGo5PMYU("SymbolCommissionTypeEnumFixed")]
	[EnumMember(Value = "Fixed")]
	Fixed,
	[Xdm5MC2tN0JMGo5PMYU("SymbolCommissionTypeEnumPercentage")]
	[EnumMember(Value = "Percentage")]
	Percentage
}
