using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "VolumeProfilesMaximumType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum VolumeProfilesMaximumType
{
	[EnumMember(Value = "Volume")]
	[Description("Volume")]
	Volume,
	[Description("Trades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[Description("Delta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[EnumMember(Value = "DeltaPlus")]
	[Description("Delta+")]
	DeltaPlus,
	[EnumMember(Value = "DeltaMinus")]
	[Description("Delta-")]
	DeltaMinus,
	[Description("Bid")]
	[EnumMember(Value = "Bid")]
	Bid,
	[EnumMember(Value = "Ask")]
	[Description("Ask")]
	Ask
}
