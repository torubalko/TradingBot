using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[DataContract(Name = "ClusterBorderType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ClusterBorderType
{
	[Xdm5MC2tN0JMGo5PMYU("ClusterBorderTypeEnumNone")]
	[EnumMember(Value = "None")]
	None,
	[EnumMember(Value = "Box")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterBorderTypeEnumBox")]
	Box,
	[EnumMember(Value = "ColoredBox")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterBorderTypeEnumColoredBox")]
	ColoredBox,
	[Xdm5MC2tN0JMGo5PMYU("ClusterBorderTypeEnumCandle")]
	[EnumMember(Value = "Candle")]
	Candle,
	[EnumMember(Value = "ColoredCandle")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterBorderTypeEnumColoredCandle")]
	ColoredCandle
}
