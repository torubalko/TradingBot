using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "VolumeProfileType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public enum VolumeProfileType
{
	[Description("Volume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[Description("Trades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[Description("Delta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[Description("Bid x Ask")]
	[EnumMember(Value = "BidAsk")]
	BidAsk
}
