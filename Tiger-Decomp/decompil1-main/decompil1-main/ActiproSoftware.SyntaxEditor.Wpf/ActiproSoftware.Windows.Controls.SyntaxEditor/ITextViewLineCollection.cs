using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextViewLineCollection : IList<ITextViewLine>, ICollection<ITextViewLine>, IEnumerable<ITextViewLine>, IEnumerable
{
	TextPosition FirstVisiblePosition { get; }

	int FullyVisibleCount { get; }

	double MaxWidth { get; }

	TextSnapshotRange SnapshotRange { get; }
}
