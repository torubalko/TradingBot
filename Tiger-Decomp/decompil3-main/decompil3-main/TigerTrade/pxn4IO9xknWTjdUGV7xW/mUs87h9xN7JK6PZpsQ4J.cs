using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace pxn4IO9xknWTjdUGV7xW;

[DataContract(Name = "TransferAccountType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Trading")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum mUs87h9xN7JK6PZpsQ4J
{
	[EnumMember(Value = "Spot")]
	[Xdm5MC2tN0JMGo5PMYU("TransferAccountTypeSpot")]
	Spot,
	[Xdm5MC2tN0JMGo5PMYU("TransferAccountTypeUsdtM")]
	[EnumMember(Value = "UsdtM")]
	UsdtM
}
