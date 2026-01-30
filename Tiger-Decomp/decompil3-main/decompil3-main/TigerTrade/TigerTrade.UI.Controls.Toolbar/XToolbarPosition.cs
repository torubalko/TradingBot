using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.UI.Controls.Toolbar;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "XToolbarPosition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.UI.Controls.Toolbar")]
public enum XToolbarPosition
{
	[Xdm5MC2tN0JMGo5PMYU("ToolbarPositionEnumTop")]
	[EnumMember(Value = "Top")]
	Top,
	[EnumMember(Value = "Left")]
	[Xdm5MC2tN0JMGo5PMYU("ToolbarPositionEnumLeft")]
	Left,
	[EnumMember(Value = "Right")]
	[Xdm5MC2tN0JMGo5PMYU("ToolbarPositionEnumRight")]
	Right,
	[EnumMember(Value = "Bottom")]
	[Xdm5MC2tN0JMGo5PMYU("ToolbarPositionEnumBottom")]
	Bottom,
	[EnumMember(Value = "None")]
	[Xdm5MC2tN0JMGo5PMYU("ToolbarPositionEnumNone")]
	None
}
