using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Spinnable")]
public interface ISpinnablePart<T> : IPart
{
	bool ApplyIncrementalChange(IncrementalChangeRequest<T> request);
}
