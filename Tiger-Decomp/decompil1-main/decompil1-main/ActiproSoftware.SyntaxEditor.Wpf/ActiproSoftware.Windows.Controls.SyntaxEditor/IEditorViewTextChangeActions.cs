using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewTextChangeActions
{
	void Backspace();

	void BackspaceToPreviousWord();

	void ChangeCharacterCasing(CharacterCasing casing);

	void CommentLines();

	void ConvertSpacesToTabs();

	void ConvertTabsToSpaces();

	void Delete();

	void DeleteBlankLines();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	void DeleteHorizontalWhitespace();

	void DeleteLine();

	void DeleteToLineEnd();

	void DeleteToLineStart();

	void DeleteToNextWord();

	void Duplicate();

	void FormatDocument();

	void FormatSelection();

	void Indent();

	void InsertLineBreak();

	void MoveSelectedLinesDown();

	void MoveSelectedLinesUp();

	void OpenLineAbove();

	void OpenLineBelow();

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
	void Outdent();

	void PerformInsertTyping(string text);

	void PerformOverwriteTyping(string text);

	void PerformTyping(string text);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tabify")]
	void TabifySelectedLines();

	void ToggleCharacterCasing();

	void TransposeCharacters();

	void TransposeLines();

	void TransposeWords();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	void TrimAllTrailingWhitespace();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	void TrimTrailingWhitespace();

	void UncommentLines();

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untabify")]
	void UntabifySelectedLines();
}
