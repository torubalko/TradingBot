using System.ComponentModel;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;
using TigerTrade.Core.UI.Converters;

namespace OHR1Vy8IqpXfI835Uvb;

[DataContract(Name = "WatchlistFieldToFilter", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
internal enum t1m2w38qWLpU04cWlNb
{
	[Xdm5MC2tN0JMGo5PMYU("WatchlistFieldToFilterEnumNone")]
	[EnumMember(Value = "None")]
	None,
	[EnumMember(Value = "Trades")]
	[Xdm5MC2tN0JMGo5PMYU("SecurityViewModelTrades")]
	Trades,
	[EnumMember(Value = "Value")]
	[Xdm5MC2tN0JMGo5PMYU("SecurityViewModelValue")]
	Value,
	[EnumMember(Value = "Change")]
	[Xdm5MC2tN0JMGo5PMYU("SecurityViewModelChange")]
	Change
}
