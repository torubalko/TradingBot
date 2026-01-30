using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Base.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "DataCycleDataType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum DataCycleDataType
{
	[EnumMember(Value = "Clusters")]
	[Xdm5MC2tN0JMGo5PMYU("DataCycleDataTypeEnumClusters")]
	Clusters,
	[EnumMember(Value = "BasicBars")]
	[Xdm5MC2tN0JMGo5PMYU("DataCycleDataTypeEnumBasicBars")]
	BasicBars,
	[EnumMember(Value = "ExtendedBars")]
	[Xdm5MC2tN0JMGo5PMYU("DataCycleDataTypeEnumExtendedBars")]
	ExtendedBars
}
