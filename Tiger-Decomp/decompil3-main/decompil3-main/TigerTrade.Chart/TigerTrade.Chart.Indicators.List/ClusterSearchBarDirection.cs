using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterSearchBarDirection", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ClusterSearchBarDirection
{
	[EnumMember(Value = "Any")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAny")]
	Any,
	[EnumMember(Value = "Up")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsUp")]
	Up,
	[EnumMember(Value = "Down")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDown")]
	Down
}
