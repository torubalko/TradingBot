using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "ClusterSearchObjectType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum ClusterSearchObjectType
{
	[EnumMember(Value = "Rectangle")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsRectangle")]
	Rectangle,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsTriangle")]
	[EnumMember(Value = "Triangle")]
	Triangle,
	[EnumMember(Value = "Diamond")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsDiamond")]
	Diamond,
	[EnumMember(Value = "Circle")]
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsCircle")]
	Circle,
	[mQYh4Ti4nGsawZaMqRVA("ChartIndicatorsSelectionOnly")]
	[EnumMember(Value = "SelectionOnly")]
	SelectionOnly
}
