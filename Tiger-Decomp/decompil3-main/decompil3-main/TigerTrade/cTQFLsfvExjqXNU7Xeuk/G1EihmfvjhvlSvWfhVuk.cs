using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace cTQFLsfvExjqXNU7Xeuk;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ServerAlertEventType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Parts.Alerts.AlertNotifier")]
internal enum G1EihmfvjhvlSvWfhVuk
{
	[EnumMember(Value = "create")]
	k2wfvQe1eSy,
	[EnumMember(Value = "update")]
	KHGfvdc1goE,
	[EnumMember(Value = "delete")]
	Delete,
	[EnumMember(Value = "notification")]
	Notification
}
