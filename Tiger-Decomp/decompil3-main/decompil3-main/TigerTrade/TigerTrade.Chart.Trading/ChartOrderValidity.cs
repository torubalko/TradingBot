using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Trading;

[DataContract(Name = "ChartOrderValidity", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Trading")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ChartOrderValidity
{
	[Description("DAY")]
	[EnumMember(Value = "Day")]
	Day,
	[Description("GTC")]
	[EnumMember(Value = "Gtc")]
	Gtc
}
