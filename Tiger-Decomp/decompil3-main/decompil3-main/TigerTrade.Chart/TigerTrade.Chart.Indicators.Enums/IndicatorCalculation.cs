using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "IndicatorCalculation", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum IndicatorCalculation
{
	[mQYh4Ti4nGsawZaMqRVA("IndicatorCalculationEnumDefault")]
	[EnumMember(Value = "Default")]
	Default,
	[mQYh4Ti4nGsawZaMqRVA("IndicatorCalculationEnumOnEachTick")]
	[EnumMember(Value = "OnEachTick")]
	OnEachTick,
	[EnumMember(Value = "OnPriceChange")]
	[mQYh4Ti4nGsawZaMqRVA("IndicatorCalculationEnumOnPriceChange")]
	OnPriceChange,
	[mQYh4Ti4nGsawZaMqRVA("IndicatorCalculationEnumOnBarClose")]
	[EnumMember(Value = "OnBarClose")]
	OnBarClose
}
