using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Config.Common;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "AppTimeZone", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
public enum AppTimeZone
{
	[Xdm5MC2tN0JMGo5PMYU("AppTimeEnumUTC")]
	[EnumMember(Value = "UTC")]
	UTC,
	[Xdm5MC2tN0JMGo5PMYU("AppTimeEnumKyiv")]
	[EnumMember(Value = "Kyiv")]
	Kyiv,
	[EnumMember(Value = "Moscow")]
	[Xdm5MC2tN0JMGo5PMYU("AppTimeEnumMoscow")]
	Moscow,
	[Xdm5MC2tN0JMGo5PMYU("AppTimeEnumNewYork")]
	[EnumMember(Value = "NewYork")]
	NewYork,
	[EnumMember(Value = "Chicago")]
	[Xdm5MC2tN0JMGo5PMYU("AppTimeEnumChicago")]
	Chicago
}
