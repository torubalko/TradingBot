using System.Collections.Generic;

namespace TigerTrade.Core.UI.Common;

public interface IDynamicProperty
{
	bool GetPropertyHasStandardValues(string propertyName);

	bool GetPropertyReadOnly(string propertyName);

	IEnumerable<object> GetPropertyStandardValues(string propertyName);

	bool GetPropertyVisibility(string propertyName);
}
