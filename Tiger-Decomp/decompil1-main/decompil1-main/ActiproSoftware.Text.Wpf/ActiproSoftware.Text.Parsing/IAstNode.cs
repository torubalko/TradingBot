using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Parsing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ast")]
public interface IAstNode
{
	IList<IAstNode> Children { get; }

	int? EndOffset { get; set; }

	bool HasChildren { get; }

	int Id { get; }

	int Length { get; }

	IAstNode Parent { get; set; }

	int? StartOffset { get; set; }

	string Value { get; set; }

	bool Contains(int offset);

	IAstNode FindChildNode(int offset);

	IAstNode FindDescendantNode(int offset);

	string ToTreeString(int indentLevel);
}
