using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "BarSearchConditions", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum BarSearchConditions
{
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumGreaterThenSource")]
	[EnumMember(Value = "GreaterThenSource")]
	GreaterThenSource,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumGreaterThenValue")]
	[EnumMember(Value = "GreaterThenValue")]
	GreaterThenValue,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumLessThenSource")]
	[EnumMember(Value = "LessThenSource")]
	LessThenSource,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumLessThenValue")]
	[EnumMember(Value = "LessThenValue")]
	LessThenValue,
	[EnumMember(Value = "EqualSource")]
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumEqualSource")]
	EqualSource,
	[EnumMember(Value = "EqualValue")]
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertConditionsEnumEqualValue")]
	EqualValue
}
