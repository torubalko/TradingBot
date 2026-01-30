using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Clusters.Enums;

[DataContract(Name = "ClusterValueType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ClusterProportionType
{
	[Xdm5MC2tN0JMGo5PMYU("ClusterProportionTypeEnumCurrentBar")]
	[EnumMember(Value = "CurrentBar")]
	CurrentBar,
	[EnumMember(Value = "VisibleBars")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterProportionTypeEnumVisibleBars")]
	VisibleBars,
	[EnumMember(Value = "AllBars")]
	[Xdm5MC2tN0JMGo5PMYU("ClusterProportionTypeEnumAllBars")]
	AllBars,
	[Xdm5MC2tN0JMGo5PMYU("ClusterProportionTypeEnumCustomValue")]
	[EnumMember(Value = "CustomValue")]
	CustomValue
}
