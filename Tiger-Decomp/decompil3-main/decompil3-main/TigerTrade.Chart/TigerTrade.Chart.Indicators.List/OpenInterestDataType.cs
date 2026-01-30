using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "OpenInterestDataType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum OpenInterestDataType
{
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsAll")]
	[EnumMember(Value = "All")]
	All,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsBuys")]
	[EnumMember(Value = "Buys")]
	Buys,
	[EnumMember(Value = "Sells")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsSells")]
	Sells
}
