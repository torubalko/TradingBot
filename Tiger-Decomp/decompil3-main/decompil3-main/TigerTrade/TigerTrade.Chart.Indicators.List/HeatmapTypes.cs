using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "HeatmapTypes", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum HeatmapTypes
{
	[Description("Dark To Orange")]
	[EnumMember(Value = "DarkToOrange")]
	DarkToOrange,
	[Description("Dark To Red")]
	[EnumMember(Value = "DarkToRed")]
	DarkToRed,
	[EnumMember(Value = "Grayscale")]
	[Description("Grayscale")]
	Grayscale
}
