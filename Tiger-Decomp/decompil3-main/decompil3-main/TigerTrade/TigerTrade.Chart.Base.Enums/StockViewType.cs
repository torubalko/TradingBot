using System.Runtime.Serialization;

namespace TigerTrade.Chart.Base.Enums;

[DataContract(Name = "StockViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum StockViewType
{
	[EnumMember(Value = "Candles")]
	Candles,
	[EnumMember(Value = "Bars")]
	Bars,
	[EnumMember(Value = "Line")]
	Line,
	[EnumMember(Value = "Area")]
	Area,
	[EnumMember(Value = "Clusters")]
	Clusters
}
