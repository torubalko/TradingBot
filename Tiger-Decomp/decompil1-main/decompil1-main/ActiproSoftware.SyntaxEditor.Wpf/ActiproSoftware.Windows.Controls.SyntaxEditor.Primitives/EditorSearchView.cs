using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

public class EditorSearchView : SearchViewBase
{
	private int zKw;

	public static readonly DependencyProperty SyntaxEditorProperty;

	internal static EditorSearchView dB4;

	public override IEditorView TargetView => SyntaxEditor?.ActiveView;

	public SyntaxEditor SyntaxEditor
	{
		get
		{
			return (SyntaxEditor)GetValue(SyntaxEditorProperty);
		}
		set
		{
			SetValue(SyntaxEditorProperty, value);
		}
	}

	public EditorSearchView()
	{
		grA.DaB7cz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EditorSearchView);
	}

	private static int YK4(SearchOperationType P_0, IEditorSearchOptions P_1)
	{
		return (P_0.GetHashCode() * 64) ^ (P_1.FindText ?? string.Empty).GetHashCode() ^ (P_1.MatchCase.GetHashCode() * 2) ^ (P_1.MatchWholeWord.GetHashCode() * 4) ^ (P_1.ReplaceText ?? string.Empty).GetHashCode() ^ (P_1.Scope.GetHashCode() * 32) ^ (P_1.PatternProvider ?? ActiproSoftware.Text.Searching.SearchPatternProviders.Normal).Key.GetHashCode() ^ (P_1.SearchUp.GetHashCode() * 8);
	}

	protected override void OnSearching(SearchOperationType operationType)
	{
		IEditorSearchOptions searchOptions = base.SearchOptions;
		if (searchOptions == null)
		{
			return;
		}
		int num = zKw;
		zKw = YK4(operationType, searchOptions);
		int num2 = 0;
		if (!zBD())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (zKw != num)
		{
			TargetView?.Searcher.SetSearchStartOffset(searchOptions);
		}
	}

	private static void mKo(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EditorSearchView editorSearchView = (EditorSearchView)P_0;
		if (P_1.OldValue is SyntaxEditor syntaxEditor)
		{
			syntaxEditor.ViewSelectionChanged -= editorSearchView.BKj;
		}
		SyntaxEditor syntaxEditor2 = P_1.NewValue as SyntaxEditor;
		bool flag = syntaxEditor2 != null;
		int num = 0;
		if (!zBD())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			syntaxEditor2.ViewSelectionChanged += editorSearchView.BKj;
		}
		editorSearchView.RaiseCanExecuteChangedForCommands();
	}

	private void BKj(object P_0, EditorViewSelectionEventArgs P_1)
	{
		if (P_1.CanResetSearchStartOffset)
		{
			P_1.View.Searcher.SetSearchStartOffset(base.SearchOptions);
		}
	}

	static EditorSearchView()
	{
		grA.DaB7cz();
		SyntaxEditorProperty = DependencyProperty.Register(Q7Z.tqM(1676), typeof(SyntaxEditor), typeof(EditorSearchView), new PropertyMetadata(null, mKo));
	}

	internal static bool zBD()
	{
		return dB4 == null;
	}

	internal static EditorSearchView FBB()
	{
		return dB4;
	}
}
