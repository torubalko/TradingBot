using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.Enums;

[DataContract(Name = "ObjectTextAlignment", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ObjectTextAlignment
{
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumLeftTop")]
	[EnumMember(Value = "LeftTop")]
	LeftTop,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumLeftMiddle")]
	[EnumMember(Value = "LeftMiddle")]
	LeftMiddle,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumLeftBottom")]
	[EnumMember(Value = "LeftBottom")]
	LeftBottom,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumCenterTop")]
	[EnumMember(Value = "CenterTop")]
	CenterTop,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumCenterMiddle")]
	[EnumMember(Value = "CenterMiddle")]
	CenterMiddle,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumCenterBottom")]
	[EnumMember(Value = "CenterBottom")]
	CenterBottom,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumRightTop")]
	[EnumMember(Value = "RightTop")]
	RightTop,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumRightMiddle")]
	[EnumMember(Value = "RightMiddle")]
	RightMiddle,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumRightBottom")]
	[EnumMember(Value = "RightBottom")]
	RightBottom,
	[mQYh4Ti4nGsawZaMqRVA("ObjectTextAlignmentEnumHide")]
	[EnumMember(Value = "Hide")]
	Hide
}
