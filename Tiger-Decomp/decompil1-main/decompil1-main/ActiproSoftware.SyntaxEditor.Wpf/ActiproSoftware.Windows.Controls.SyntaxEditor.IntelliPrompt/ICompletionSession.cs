using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Navigation;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionSession : IIntelliPromptSession, IServiceLocator
{
	CharClass AllowedCharacters { get; }

	bool CanCommitWithoutPopup { get; }

	bool CanFilterUnmatchedItems { get; }

	bool CanHighlightMatchedText { get; }

	CharClass CommitCharacters { get; }

	object Context { get; }

	double ControlKeyDownOpacity { get; }

	double DescriptionTipMaxWidth { get; }

	TimeSpan DescriptionTipShowDelay { get; }

	ICompletionItemCollectionView FilteredItems { get; }

	ICompletionFilterCollection Filters { get; }

	bool IsEnterKeyHandledOnCommit { get; }

	ICompletionItemMatcherCollection ItemMatchers { get; }

	ICompletionItemCollection Items { get; }

	CompletionMatchOptions MatchOptions { get; }

	bool RequiresFilterOnTextChange { get; set; }

	CompletionSelection Selection { get; set; }

	string TypedText { get; }

	event EventHandler Committed;

	event EventHandler<CancelEventArgs> Committing;

	event RequestNavigateEventHandler RequestNavigate;

	event EventHandler SelectionChanged;

	void ApplyFilters();

	void Cancel();

	void CloseDescriptionTip();

	void Commit();

	void Open(IEditorView view);

	void RestartDescriptionTipTimer();

	void SortItems();

	void SortItems(IComparer<ICompletionItem> comparer);
}
