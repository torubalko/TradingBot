using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "RegressionType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum RegressionType
{
	[mQYh4Ti4nGsawZaMqRVA("RegressionTypeEnumChannel")]
	[EnumMember(Value = "Channel")]
	Channel,
	[mQYh4Ti4nGsawZaMqRVA("RegressionTypeEnumAsynChannel")]
	[EnumMember(Value = "AsynChannel")]
	AsynChannel,
	[mQYh4Ti4nGsawZaMqRVA("RegressionTypeEnumStdChannel")]
	[EnumMember(Value = "StdChannel")]
	StdChannel,
	[mQYh4Ti4nGsawZaMqRVA("RegressionTypeEnumStdErrorChannel")]
	[EnumMember(Value = "StdErrorChannel")]
	StdErrorChannel,
	[EnumMember(Value = "UpDownTrend")]
	[mQYh4Ti4nGsawZaMqRVA("RegressionTypeEnumUpDownTrend")]
	UpDownTrend
}
