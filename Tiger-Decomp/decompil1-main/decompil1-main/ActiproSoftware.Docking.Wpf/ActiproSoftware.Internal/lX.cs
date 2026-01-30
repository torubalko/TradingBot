using System.Collections.Generic;

namespace ActiproSoftware.Internal;

internal interface lX
{
	IEnumerable<lX> ChildNodes { get; }
}
