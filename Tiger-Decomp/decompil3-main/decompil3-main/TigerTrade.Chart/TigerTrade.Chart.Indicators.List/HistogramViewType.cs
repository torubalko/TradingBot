using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "HistogramViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum HistogramViewType
{
	[mQYh4Ti4nGsawZaMqRVA("Volume")]
	[EnumMember(Value = "Volume")]
	Volume,
	[EnumMember(Value = "Trades")]
	[mQYh4Ti4nGsawZaMqRVA("Trades")]
	Trades,
	[mQYh4Ti4nGsawZaMqRVA("Delta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[mQYh4Ti4nGsawZaMqRVA("Bid x Ask")]
	[EnumMember(Value = "BidAsk")]
	BidAsk
}
