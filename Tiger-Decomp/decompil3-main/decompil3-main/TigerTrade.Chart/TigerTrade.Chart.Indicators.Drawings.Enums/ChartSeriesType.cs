using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Drawings.Enums;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ChartSeriesType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
public enum ChartSeriesType
{
	[EnumMember(Value = "Line")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesTypeEnumLine")]
	Line,
	[EnumMember(Value = "Points")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesTypeEnumPoints")]
	Points,
	[EnumMember(Value = "Columns")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesTypeEnumColumns")]
	Columns,
	[EnumMember(Value = "Area")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesTypeEnumArea")]
	Area,
	[EnumMember(Value = "Region")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesTypeEnumRegion")]
	Region
}
