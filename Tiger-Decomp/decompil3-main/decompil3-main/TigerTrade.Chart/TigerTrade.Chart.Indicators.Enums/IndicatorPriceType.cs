using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[DataContract(Name = "IndicatorPriceType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum IndicatorPriceType
{
	[Description("Open")]
	[EnumMember(Value = "Open")]
	Open,
	[Description("High")]
	[EnumMember(Value = "High")]
	High,
	[Description("Low")]
	[EnumMember(Value = "Low")]
	Low,
	[Description("Close")]
	[EnumMember(Value = "Close")]
	Close,
	[Description("Median")]
	[EnumMember(Value = "Median")]
	Median,
	[Description("Typical")]
	[EnumMember(Value = "Typical")]
	Typical
}
