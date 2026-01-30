using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "VolumeProfilesPeriodType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum VolumeProfilesPeriodType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMinute")]
	[EnumMember(Value = "Minute")]
	Minute,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsHour")]
	[EnumMember(Value = "Hour")]
	Hour,
	[EnumMember(Value = "Day")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDay")]
	Day,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsWeek")]
	[EnumMember(Value = "Week")]
	Week,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsMonth")]
	[EnumMember(Value = "Month")]
	Month
}
