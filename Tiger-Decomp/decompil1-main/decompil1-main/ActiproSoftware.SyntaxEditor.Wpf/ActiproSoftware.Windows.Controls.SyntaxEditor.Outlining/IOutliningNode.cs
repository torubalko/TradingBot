using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface IOutliningNode : IEnumerable<IOutliningNode>, IEnumerable
{
	int Count { get; }

	IOutliningNodeDefinition Definition { get; }

	bool IsCollapsed { get; set; }

	bool IsOpen { get; }

	bool IsRoot { get; }

	IOutliningNode ParentNode { get; }

	TextSnapshotRange SnapshotRange { get; }

	IOutliningNode this[int index] { get; }

	IOutliningNode FindNodeRecursive(int offset);

	string ToTreeString(int indentLevel);
}
