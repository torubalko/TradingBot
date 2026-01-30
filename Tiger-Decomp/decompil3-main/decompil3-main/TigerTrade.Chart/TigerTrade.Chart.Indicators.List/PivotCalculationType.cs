using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "PivotCalculationType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum PivotCalculationType
{
	[Description("Classic")]
	[EnumMember(Value = "Classic")]
	Classic,
	[EnumMember(Value = "Woodie")]
	[Description("Woodie")]
	Woodie,
	[EnumMember(Value = "Camarilla")]
	[Description("Camarilla")]
	Camarilla,
	[EnumMember(Value = "DeMark")]
	[Description("DeMark")]
	DeMark,
	[EnumMember(Value = "Fibonacci")]
	[Description("Fibonacci")]
	Fibonacci
}
