using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;

namespace TigerTrade.Chart.Alerts;

[DataContract(Name = "ChartAlertExecution", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Alerts")]
public enum ChartAlertExecution
{
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertExecutionEnumEveryTime")]
	[EnumMember(Value = "EveryTime")]
	EveryTime,
	[mQYh4Ti4nGsawZaMqRVA("ChartAlertExecutionEnumOnlyOnce")]
	[EnumMember(Value = "OnlyOnce")]
	OnlyOnce
}
