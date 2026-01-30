using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Config.Common;

[DataContract(Name = "AppTheme", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum AppServer
{
	[Xdm5MC2tN0JMGo5PMYU("Automatically")]
	[EnumMember(Value = "Automatically")]
	Automatically,
	[EnumMember(Value = "Server1")]
	[Xdm5MC2tN0JMGo5PMYU("AppServerEnumServer1")]
	Server1,
	[Xdm5MC2tN0JMGo5PMYU("AppServerEnumServer2")]
	[EnumMember(Value = "Server2")]
	Server2,
	[Xdm5MC2tN0JMGo5PMYU("AppServerEnumServer3")]
	[EnumMember(Value = "Server3")]
	Server3,
	[EnumMember(Value = "Server4")]
	[Xdm5MC2tN0JMGo5PMYU("AppServerEnumServer4")]
	Server4,
	NotDefined
}
