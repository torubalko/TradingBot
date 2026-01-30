using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Trading;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartOrderType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Trading")]
public enum ChartOrderType
{
	[Xdm5MC2tN0JMGo5PMYU("ChartOrderTypeEnumMarket")]
	[EnumMember(Value = "Market")]
	Market,
	[Xdm5MC2tN0JMGo5PMYU("ChartOrderTypeEnumLimit")]
	[EnumMember(Value = "Limit")]
	Limit,
	[Xdm5MC2tN0JMGo5PMYU("ChartOrderTypeEnumStop")]
	[EnumMember(Value = "Stop")]
	Stop,
	[Xdm5MC2tN0JMGo5PMYU("ChartOrderTypeEnumStopLimit")]
	[EnumMember(Value = "StopLimit")]
	StopLimit
}
