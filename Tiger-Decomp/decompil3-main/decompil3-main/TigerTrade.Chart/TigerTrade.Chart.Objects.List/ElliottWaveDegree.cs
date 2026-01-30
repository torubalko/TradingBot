using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "ElliottWaveDegree", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ElliottWaveDegree
{
	[EnumMember(Value = "GrandSupercycle")]
	[Description("Grand Supercycle")]
	GrandSupercycle,
	[EnumMember(Value = "Supercycle")]
	[Description("Supercycle")]
	Supercycle,
	[EnumMember(Value = "Cycle")]
	[Description("Cycle")]
	Cycle,
	[Description("Primary")]
	[EnumMember(Value = "Primary")]
	Primary,
	[EnumMember(Value = "Intermediate")]
	[Description("Intermediate")]
	Intermediate,
	[EnumMember(Value = "Minor")]
	[Description("Minor")]
	Minor,
	[Description("Minute")]
	[EnumMember(Value = "Minute")]
	Minute,
	[Description("Minuette")]
	[EnumMember(Value = "Minuette")]
	Minuette,
	[EnumMember(Value = "Subminuette")]
	[Description("Subminuette")]
	Subminuette
}
