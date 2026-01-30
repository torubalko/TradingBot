using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Config.Common;

[DataContract(Name = "AppLanguage", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum AppLanguage
{
	[EnumMember(Value = "System")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumSystem")]
	System,
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumEnglish")]
	[EnumMember(Value = "English")]
	English,
	[EnumMember(Value = "Russian")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumRussian")]
	Russian,
	[EnumMember(Value = "Portuguese")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumPortuguese")]
	Portuguese,
	[EnumMember(Value = "Spanish")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumSpanish")]
	Spanish,
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumTurkish")]
	[EnumMember(Value = "Turkish")]
	Turkish,
	[EnumMember(Value = "Ukraine")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumUkraine")]
	Ukraine,
	[EnumMember(Value = "Chinese")]
	[Xdm5MC2tN0JMGo5PMYU("AppLanguageEnumChinese")]
	Chinese
}
