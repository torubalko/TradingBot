using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Config.Common;

[DataContract(Name = "AppNotifyPosition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum AppNotifyPosition
{
	[Xdm5MC2tN0JMGo5PMYU("AppNotifyPositionEnumBottomRight")]
	[EnumMember(Value = "BottomRight")]
	BottomRight,
	[EnumMember(Value = "TopRight")]
	[Xdm5MC2tN0JMGo5PMYU("AppNotifyPositionEnumTopRight")]
	TopRight,
	[Xdm5MC2tN0JMGo5PMYU("AppNotifyPositionEnumBottomLeft")]
	[EnumMember(Value = "BottomLeft")]
	BottomLeft,
	[EnumMember(Value = "TopLeft")]
	[Xdm5MC2tN0JMGo5PMYU("AppNotifyPositionEnumTopLeft")]
	TopLeft
}
