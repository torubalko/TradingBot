using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "IndicatorMaType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum IndicatorMaType
{
	[EnumMember(Value = "SMA")]
	[Description("SMA")]
	SMA,
	[EnumMember(Value = "EMA")]
	[Description("EMA")]
	EMA,
	[Description("WMA")]
	[EnumMember(Value = "WMA")]
	WMA,
	[EnumMember(Value = "DEMA")]
	[Description("DEMA")]
	DEMA,
	[Description("TEMA")]
	[EnumMember(Value = "TEMA")]
	TEMA,
	[Description("TMA")]
	[EnumMember(Value = "TMA")]
	TMA,
	[Description("KAMA")]
	[EnumMember(Value = "KAMA")]
	KAMA,
	[Description("MAMA")]
	[EnumMember(Value = "MAMA")]
	MAMA,
	[Description("T3")]
	[EnumMember(Value = "T3")]
	T3,
	[Description("SMMA")]
	[EnumMember(Value = "SMMA")]
	SMMA
}
