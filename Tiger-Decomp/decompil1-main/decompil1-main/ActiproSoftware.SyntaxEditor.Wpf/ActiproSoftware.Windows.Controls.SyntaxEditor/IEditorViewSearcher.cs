using ActiproSoftware.Text;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewSearcher
{
	TextSnapshotRange SelectionScopeSnapshotRange { get; }

	ISearchResultSet FindAll(IEditorSearchOptions options);

	ISearchResultSet FindCurrentOrNext(IEditorSearchOptions options);

	ISearchResultSet FindNext(IEditorSearchOptions options);

	ISearchResultSet FindNextIncremental(bool searchUp);

	ISearchResultSet ReplaceNext(IEditorSearchOptions options);

	ISearchResultSet ReplaceAll(IEditorSearchOptions options);

	void SetSearchStartOffset(IEditorSearchOptions options);
}
