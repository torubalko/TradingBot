using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Config.Common;

[DataContract(Name = "AppTheme", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum AppTheme
{
	[EnumMember(Value = "MetroDark")]
	[Xdm5MC2tN0JMGo5PMYU("AppThemeEnumDark")]
	MetroDark,
	[EnumMember(Value = "MetroLight")]
	[Xdm5MC2tN0JMGo5PMYU("AppThemeEnumLight")]
	MetroLight
}
