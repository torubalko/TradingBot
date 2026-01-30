using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface IClassificationTypeRegistry : IEnumerable<IClassificationType>, IEnumerable
{
	int Count { get; }

	IClassificationType this[string key] { get; }
}
