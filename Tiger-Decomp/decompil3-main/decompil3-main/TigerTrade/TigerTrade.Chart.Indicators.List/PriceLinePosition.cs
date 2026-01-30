using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "PriceLinePosition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum PriceLinePosition
{
	[EnumMember(Value = "Hide")]
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsLinePositionHide")]
	Hide,
	[EnumMember(Value = "Right")]
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsLinePositionRight")]
	Right,
	[EnumMember(Value = "Left")]
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsLinePositionLeft")]
	Left,
	[EnumMember(Value = "Full")]
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsLinePositionFull")]
	Full
}
