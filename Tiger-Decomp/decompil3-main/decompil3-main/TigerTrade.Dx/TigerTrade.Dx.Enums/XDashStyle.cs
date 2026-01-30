using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.Localization;
using TigerTrade.Core.UI.Converters;
using TigerTrade.Dx.Properties;

namespace TigerTrade.Dx.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "XDashStyle", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Dx")]
public enum XDashStyle
{
	[DescriptionLocalized(typeof(Resources), "XDashStyleEnumSolid")]
	[EnumMember(Value = "Solid")]
	Solid,
	[EnumMember(Value = "Dash")]
	[DescriptionLocalized(typeof(Resources), "XDashStyleEnumDash")]
	Dash,
	[DescriptionLocalized(typeof(Resources), "XDashStyleEnumDot")]
	[EnumMember(Value = "Dot")]
	Dot,
	[EnumMember(Value = "DashDot")]
	[DescriptionLocalized(typeof(Resources), "XDashStyleEnumDashDot")]
	DashDot,
	[DescriptionLocalized(typeof(Resources), "XDashStyleEnumDashDotDot")]
	[EnumMember(Value = "DashDotDot")]
	DashDotDot
}
