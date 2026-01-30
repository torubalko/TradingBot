using System.Runtime.Serialization;

namespace TigerTrade.Tc.Data;

[DataContract(Name = "Side", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Storage")]
public enum Side
{
	[EnumMember(Value = "Buy")]
	Buy,
	[EnumMember(Value = "Sell")]
	Sell
}
