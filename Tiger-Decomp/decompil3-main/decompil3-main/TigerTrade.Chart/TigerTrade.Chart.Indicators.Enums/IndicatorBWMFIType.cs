using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "IndicatorBWMFIType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum IndicatorBWMFIType
{
	[EnumMember(Value = "Ticks")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMfiTicks")]
	Ticks,
	[EnumMember(Value = "Real")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMfiReal")]
	Real
}
