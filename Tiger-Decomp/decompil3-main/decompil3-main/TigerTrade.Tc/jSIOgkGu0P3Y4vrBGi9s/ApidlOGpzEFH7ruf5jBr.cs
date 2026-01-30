using System.ComponentModel;
using System.Runtime.Serialization;
using TigerTrade.Core.UI.Converters;

namespace jSIOgkGu0P3Y4vrBGi9s;

[DataContract(Name = "PriceStrategySelectionMode", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Common")]
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ApidlOGpzEFH7ruf5jBr
{
	[EnumMember(Value = "UnifiedOpen")]
	[Description("[Unified] Open Only")]
	UnifiedOpen,
	[EnumMember(Value = "PartClose")]
	[Description("[Unified] Part Close")]
	PartClose,
	[Description("[Isolated] Lifo")]
	[EnumMember(Value = "IsolatedLifo")]
	IsolatedLifo,
	[EnumMember(Value = "IsolatedFifo")]
	[Description("[Isolated] Fifo")]
	IsolatedFifo,
	[Description("[Isolated] Open Only")]
	[EnumMember(Value = "IsolatedOpen")]
	IsolatedOpen
}
