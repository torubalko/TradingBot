using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "HistogramCellViewType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum HistogramCellViewType
{
	[EnumMember(Value = "Solid")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHistogramCellTypeSolid")]
	Solid,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHistogramCellTypeBars")]
	[EnumMember(Value = "Bars")]
	Bars,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHistogramCellTypeBorderedBars")]
	[EnumMember(Value = "BorderedBars")]
	BorderedBars
}
