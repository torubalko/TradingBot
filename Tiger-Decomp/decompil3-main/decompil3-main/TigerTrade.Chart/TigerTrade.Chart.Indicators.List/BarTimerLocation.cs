using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.List;

[DataContract(Name = "BarTimerLocation", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum BarTimerLocation
{
	[EnumMember(Value = "LeftTop")]
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumLeftTop")]
	LeftTop,
	[EnumMember(Value = "LeftMiddle")]
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumLeftMiddle")]
	LeftMiddle,
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumLeftBottom")]
	[EnumMember(Value = "LeftBottom")]
	LeftBottom,
	[EnumMember(Value = "CenterTop")]
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumCenterTop")]
	CenterTop,
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumCenterMiddle")]
	[EnumMember(Value = "CenterMiddle")]
	CenterMiddle,
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumCenterBottom")]
	[EnumMember(Value = "CenterBottom")]
	CenterBottom,
	[EnumMember(Value = "RightTop")]
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumRightTop")]
	RightTop,
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumRightMiddle")]
	[EnumMember(Value = "RightMiddle")]
	RightMiddle,
	[mQYh4Ti4nGsawZaMqRVA("BarTimerLocationEnumRightBottom")]
	[EnumMember(Value = "RightBottom")]
	RightBottom
}
