using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartCellViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ChartCellViewType
{
	[EnumMember(Value = "Solid")]
	[Xdm5MC2tN0JMGo5PMYU("ChartCellViewTypeEnumSolid")]
	Solid,
	[EnumMember(Value = "Bars")]
	[Xdm5MC2tN0JMGo5PMYU("ChartCellViewTypeEnumBars")]
	Bars,
	[EnumMember(Value = "BorderedBars")]
	[Xdm5MC2tN0JMGo5PMYU("ChartCellViewTypeEnumBorderedBars")]
	BorderedBars
}
