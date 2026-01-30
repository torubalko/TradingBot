using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class SearchOverlayPane : SearchViewBase, IOverlayPane, IKeyedObject
{
	private DelegateCommand<object> QlA;

	private bool klv;

	private bool qlm;

	private IEditorView blC;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler Klu;

	public static readonly DependencyProperty ControlKeyDownOpacityProperty;

	internal static SearchOverlayPane g0N;

	public ICommand CloseCommand
	{
		get
		{
			if (QlA == null)
			{
				QlA = new DelegateCommand<object>(delegate
				{
					Close();
				});
			}
			return QlA;
		}
	}

	public virtual OverlayPaneInstanceKind InstanceKind => OverlayPaneInstanceKind.Single;

	public string Key => Q7Z.tqM(9576);

	public override IEditorView TargetView => blC;

	public UIElement VisualElement => this;

	public double ControlKeyDownOpacity
	{
		get
		{
			return (double)GetValue(ControlKeyDownOpacityProperty);
		}
		set
		{
			SetValue(ControlKeyDownOpacityProperty, value);
		}
	}

	public event EventHandler Closed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Klu;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Klu, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Klu;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Klu, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SearchOverlayPane(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		blC = view;
		base.SearchOptions = view.SyntaxEditor.SearchOptions;
		base.DefaultStyleKey = typeof(SearchOverlayPane);
	}

	private void klK(bool P_0)
	{
		if (blC == null)
		{
			return;
		}
		if (P_0)
		{
			if (!klv)
			{
				blC.SelectionChanged += elf;
				klv = true;
				int num = 0;
				if (!R0H())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
		else if (klv)
		{
			blC.SelectionChanged -= elf;
			klv = false;
		}
	}

	private void elf(object P_0, EditorViewSelectionEventArgs P_1)
	{
		if (P_1 != null && P_1.CanResetSearchStartOffset)
		{
			IEditorSearchOptions searchOptions = base.SearchOptions;
			if (searchOptions != null && searchOptions.Scope == EditorSearchScope.Selection)
			{
				qlm = true;
			}
		}
	}

	internal void rlD()
	{
		qlm = false;
		IEditorSearchOptions searchOptions = base.SearchOptions;
		if (searchOptions != null)
		{
			klK(_0020: true);
			blC.IsIncrementalSearchActive = false;
			if (blC.SyntaxEditor.IsSearchResultHighlightingEnabled)
			{
				blC.HighlightedResultSearchOptions = searchOptions;
			}
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private bool Olg(Key P_0, bool P_1)
	{
		ModifierKeys modifierKeys = vAE.A0o();
		switch (modifierKeys)
		{
		case ModifierKeys.None:
		case ModifierKeys.Shift:
			switch (P_0)
			{
			case System.Windows.Input.Key.Escape:
				Close();
				break;
			case System.Windows.Input.Key.Tab:
				if (Keyboard.FocusedElement is UIElement uIElement)
				{
					TraversalRequest request = new TraversalRequest((modifierKeys != ModifierKeys.None) ? FocusNavigationDirection.Previous : FocusNavigationDirection.Next);
					uIElement.MoveFocus(request);
					return true;
				}
				break;
			}
			break;
		case ModifierKeys.Alt:
			switch (P_0)
			{
			case System.Windows.Input.Key.A:
				if (base.IsReplaceVisible && base.ReplaceAllCommand.CanExecute(null))
				{
					base.ReplaceAllCommand.Execute(null);
					return true;
				}
				break;
			case System.Windows.Input.Key.C:
				if (base.IsOptionsPanelExpanded)
				{
					IEditorSearchOptions searchOptions3 = base.SearchOptions;
					if (searchOptions3 != null)
					{
						searchOptions3.MatchCase = !searchOptions3.MatchCase;
						return true;
					}
				}
				break;
			case System.Windows.Input.Key.E:
				if (base.IsOptionsPanelExpanded)
				{
					base.UseRegularExpressions = !base.UseRegularExpressions;
					return true;
				}
				break;
			case System.Windows.Input.Key.R:
				if (base.IsReplaceVisible && base.ReplaceNextCommand.CanExecute(null))
				{
					base.ReplaceNextCommand.Execute(null);
					return true;
				}
				break;
			case System.Windows.Input.Key.U:
				if (base.IsOptionsPanelExpanded)
				{
					IEditorSearchOptions searchOptions2 = base.SearchOptions;
					if (searchOptions2 != null)
					{
						searchOptions2.SearchUp = !searchOptions2.SearchUp;
						return true;
					}
				}
				break;
			case System.Windows.Input.Key.W:
				if (base.IsOptionsPanelExpanded)
				{
					IEditorSearchOptions searchOptions = base.SearchOptions;
					if (searchOptions != null)
					{
						searchOptions.MatchWholeWord = !searchOptions.MatchWholeWord;
						return true;
					}
				}
				break;
			}
			break;
		}
		ICommand command = blC.SyntaxEditor.MGQ(modifierKeys, P_0);
		if (command != null)
		{
			if (command is SearchActionBase searchActionBase && searchActionBase.CanExecute(blC))
			{
				searchActionBase.Execute(blC);
				return true;
			}
			return P_1;
		}
		return false;
	}

	private void llQ()
	{
		OnClosed();
	}

	internal void sle(bool P_0)
	{
		Duration animationDuration = base.AnimationDuration;
		base.AnimationDuration = TimeSpan.Zero;
		base.IsReplaceVisible = P_0;
		base.AnimationDuration = animationDuration;
	}

	public void Activate()
	{
		qlm = false;
		IEditorSearchOptions searchOptions = base.SearchOptions;
		if (blC != null && searchOptions != null)
		{
			blC.Searcher.SetSearchStartOffset(searchOptions);
		}
		FocusFindWhatTextBox();
	}

	public void Close()
	{
		IEditorSearchOptions searchOptions = base.SearchOptions;
		Il1();
		klK(_0020: false);
		llQ();
		if (searchOptions != null && blC.HighlightedResultSearchOptions == searchOptions)
		{
			blC.HighlightedResultSearchOptions = null;
		}
	}

	protected virtual void OnClosed()
	{
		Klu?.Invoke(this, EventArgs.Empty);
	}

	protected override void OnFindSearchOptionsChanged()
	{
		ylF();
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		base.OnKeyDown(e);
		Key key = ((e.Key == System.Windows.Input.Key.System) ? e.SystemKey : e.Key);
		e.Handled = Olg(key, _0020: true);
	}

	protected override void OnSearchScopeChanged()
	{
		qlm = false;
		if (blC != null)
		{
			blC.Searcher.SetSearchStartOffset(base.SearchOptions);
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (!base.IsKeyboardFocusWithin)
		{
			int num = 0;
			if (!R0H())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else if (qlm)
		{
			qlm = false;
			IEditorSearchOptions searchOptions = base.SearchOptions;
			if (blC != null && searchOptions != null && searchOptions.Scope == EditorSearchScope.Selection)
			{
				blC.Searcher.SetSearchStartOffset(searchOptions);
			}
		}
	}

	static SearchOverlayPane()
	{
		grA.DaB7cz();
		ControlKeyDownOpacityProperty = DependencyProperty.Register(Q7Z.tqM(9592), typeof(double), typeof(SearchOverlayPane), new PropertyMetadata(0.25));
	}

	[CompilerGenerated]
	private void qll(object P_0)
	{
		Close();
	}

	internal static bool R0H()
	{
		return g0N == null;
	}

	internal static SearchOverlayPane l0j()
	{
		return g0N;
	}
}
