using System.Runtime.Serialization;

namespace TigerTrade.Config.Common;

[DataContract(Name = "AppTradeMode", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
public enum AppTradeMode
{
	[EnumMember(Value = "Live")]
	Live,
	[EnumMember(Value = "Simulator")]
	Simulator,
	[EnumMember(Value = "Player")]
	Player
}
