using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Drawings.Enums;

[DataContract(Name = "ChartSeriesDotStyle", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ChartSeriesDotStyle
{
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesDotStyleEnumPoint")]
	[EnumMember(Value = "Point")]
	Point,
	[EnumMember(Value = "Circle")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesDotStyleEnumCircle")]
	Circle,
	[EnumMember(Value = "Cross")]
	[mQYh4Ti4nGsawZaMqRVA("ChartSeriesDotStyleEnumCross")]
	Cross
}
