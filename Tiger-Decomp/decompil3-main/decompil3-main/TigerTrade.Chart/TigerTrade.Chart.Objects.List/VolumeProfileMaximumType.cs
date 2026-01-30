using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "VolumeProfileMaximumType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum VolumeProfileMaximumType
{
	[Description("Volume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[Description("Trades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[EnumMember(Value = "Delta")]
	[Description("Delta")]
	Delta,
	[EnumMember(Value = "DeltaPlus")]
	[Description("Delta+")]
	DeltaPlus,
	[Description("Delta-")]
	[EnumMember(Value = "DeltaMinus")]
	DeltaMinus,
	[EnumMember(Value = "Bid")]
	[Description("Bid")]
	Bid,
	[EnumMember(Value = "Ask")]
	[Description("Ask")]
	Ask
}
