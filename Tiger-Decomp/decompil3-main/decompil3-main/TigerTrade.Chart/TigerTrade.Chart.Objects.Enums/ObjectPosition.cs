using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Objects.Enums;

[DataContract(Name = "ObjectPosition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ObjectPosition
{
	[mQYh4Ti4nGsawZaMqRVA("ObjectPositionEnumFront")]
	[EnumMember(Value = "Front")]
	Front,
	[mQYh4Ti4nGsawZaMqRVA("ObjectPositionEnumBack")]
	[EnumMember(Value = "Back")]
	Back
}
