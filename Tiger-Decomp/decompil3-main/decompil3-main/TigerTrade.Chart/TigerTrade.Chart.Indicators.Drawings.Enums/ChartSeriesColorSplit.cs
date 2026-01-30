using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Drawings.Enums;

[DataContract(Name = "ChartSeriesColorSplit", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ChartSeriesColorSplit
{
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesColorSplitEnumNo")]
	[EnumMember(Value = "NoSplit")]
	NoSplit,
	[EnumMember(Value = "UpDown")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesColorSplitEnumUpDown")]
	UpDown,
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesColorSplitEnumUpDownZero")]
	[EnumMember(Value = "UpDownZero")]
	UpDownZero
}
