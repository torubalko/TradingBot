using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Parts.HotKeys;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartMouseControl", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.HotKeys")]
public enum ChartMouseControl
{
	[EnumMember(Value = "Auto")]
	[Xdm5MC2tN0JMGo5PMYU("ChartMouseControlEnumAuto")]
	Auto,
	[Xdm5MC2tN0JMGo5PMYU("ChartMouseControlEnumBuySell")]
	[EnumMember(Value = "BuySell")]
	BuySell
}
