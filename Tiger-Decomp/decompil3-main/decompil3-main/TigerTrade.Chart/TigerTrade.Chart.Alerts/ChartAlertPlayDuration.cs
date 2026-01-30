using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;

namespace TigerTrade.Chart.Alerts;

[DataContract(Name = "ChartAlertPlayDuration", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Alerts")]
public enum ChartAlertPlayDuration
{
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertPlayDurationEnumOnce")]
	[EnumMember(Value = "Once")]
	Once,
	[EnumMember(Value = "Seconds5")]
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertPlayDurationEnumSeconds5")]
	Seconds5,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertPlayDurationEnumSeconds10")]
	[EnumMember(Value = "Seconds10")]
	Seconds10,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertPlayDurationEnumSeconds30")]
	[EnumMember(Value = "Seconds30")]
	Seconds30,
	[EnumMember(Value = "Minute")]
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertPlayDurationEnumMinute")]
	Minute
}
