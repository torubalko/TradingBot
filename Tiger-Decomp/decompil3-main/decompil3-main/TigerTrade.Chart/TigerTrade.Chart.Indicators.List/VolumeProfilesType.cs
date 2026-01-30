using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "VolumeProfilesType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum VolumeProfilesType
{
	[Description("Volume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[EnumMember(Value = "Trades")]
	[Description("Trades")]
	Trades,
	[EnumMember(Value = "Delta")]
	[Description("Delta")]
	Delta,
	[Description("Bid x Ask")]
	[EnumMember(Value = "BidAsk")]
	BidAsk
}
