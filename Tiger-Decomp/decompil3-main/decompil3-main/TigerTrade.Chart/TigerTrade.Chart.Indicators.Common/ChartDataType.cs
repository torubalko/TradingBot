using System.Runtime.Serialization;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "ChartDataType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Common")]
public enum ChartDataType
{
	[EnumMember(Value = "None")]
	None,
	[EnumMember(Value = "Bar")]
	Bar,
	[EnumMember(Value = "Cluster")]
	Cluster
}
