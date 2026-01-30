using System.Collections.Generic;

namespace ActiproSoftware.Text.Utility;

public interface IOrderable : IKeyedObject
{
	IEnumerable<Ordering> Orderings { get; }
}
