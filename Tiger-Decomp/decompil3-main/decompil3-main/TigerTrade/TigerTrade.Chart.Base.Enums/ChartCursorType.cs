using System.Runtime.Serialization;

namespace TigerTrade.Chart.Base.Enums;

[DataContract(Name = "ChartCursorType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ChartCursorType
{
	[EnumMember(Value = "Default")]
	Default,
	[EnumMember(Value = "Pointer")]
	Pointer,
	[EnumMember(Value = "LocalCross")]
	LocalCross,
	[EnumMember(Value = "GlobalCross")]
	GlobalCross,
	[EnumMember(Value = "GlobalCrossWithScroll")]
	GlobalCrossWithScroll
}
