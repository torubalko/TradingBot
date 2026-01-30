using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Parts.HotKeys;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "PeriodHotKey", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.HotKeys")]
public enum PeriodHotKey
{
	[EnumMember(Value = "None")]
	[Xdm5MC2tN0JMGo5PMYU("PeriodHotKeyEnumNone")]
	None,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod1")]
	[EnumMember(Value = "Period1")]
	Period1,
	[EnumMember(Value = "Period2")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod2")]
	Period2,
	[EnumMember(Value = "Period3")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod3")]
	Period3,
	[EnumMember(Value = "Period4")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod4")]
	Period4,
	[EnumMember(Value = "Period5")]
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod5")]
	Period5,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod6")]
	[EnumMember(Value = "Period6")]
	Period6,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod7")]
	[EnumMember(Value = "Period7")]
	Period7,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod8")]
	[EnumMember(Value = "Period8")]
	Period8,
	[Xdm5MC2tN0JMGo5PMYU("CommonHotKeysPeriod9")]
	[EnumMember(Value = "Period9")]
	Period9
}
