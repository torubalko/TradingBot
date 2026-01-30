using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "BigTradesObjectType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum BigTradesObjectType
{
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsRectangle")]
	[EnumMember(Value = "Rectangle")]
	Rectangle,
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsTriangle")]
	[EnumMember(Value = "Triangle")]
	Triangle,
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsDiamond")]
	[EnumMember(Value = "Diamond")]
	Diamond,
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsCircle")]
	[EnumMember(Value = "Circle")]
	Circle,
	[EnumMember(Value = "SelectionOnly")]
	[Xdm5MC2tN0JMGo5PMYU("ChartIndicatorsSelectionOnly")]
	SelectionOnly
}
