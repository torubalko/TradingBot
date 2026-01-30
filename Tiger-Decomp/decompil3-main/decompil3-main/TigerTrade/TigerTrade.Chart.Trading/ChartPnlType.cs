using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Trading;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartPnlType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Trading")]
public enum ChartPnlType
{
	[Xdm5MC2tN0JMGo5PMYU("ChartPnlTypeEnumPoints")]
	[EnumMember(Value = "Points")]
	Points,
	[Xdm5MC2tN0JMGo5PMYU("ChartPnlTypeEnumMoney")]
	[EnumMember(Value = "Money")]
	Money,
	[Xdm5MC2tN0JMGo5PMYU("ChartPnlTypeEnumPercent")]
	[EnumMember(Value = "Percent")]
	Percent,
	[Xdm5MC2tN0JMGo5PMYU("ChartPnlTypeEnumHidden")]
	[EnumMember(Value = "Hidden")]
	Hidden
}
