using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterSearchDataType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ClusterSearchDataType
{
	[EnumMember(Value = "Volume")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsVolume")]
	Volume,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMaxVol")]
	[EnumMember(Value = "MaxVolume")]
	MaxVol,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsTrades")]
	[EnumMember(Value = "Trades")]
	Trades,
	[EnumMember(Value = "Bid")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBid")]
	Bid,
	[EnumMember(Value = "Ask")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAsk")]
	Ask,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDelta")]
	[EnumMember(Value = "Delta")]
	Delta,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDeltaPlus")]
	[EnumMember(Value = "DeltaPlus")]
	DeltaPlus,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDeltaMinus")]
	[EnumMember(Value = "DeltaMinus")]
	DeltaMinus
}
