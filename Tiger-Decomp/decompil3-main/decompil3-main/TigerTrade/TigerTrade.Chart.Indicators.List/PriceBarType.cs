using System.Runtime.Serialization;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "PriceBarType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum PriceBarType
{
	[EnumMember(Value = "OHLC")]
	OHLC,
	[EnumMember(Value = "HLC")]
	HLC,
	[EnumMember(Value = "HL")]
	HL
}
