using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Searching.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[TemplatePart(Name = "PART_CloseButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_ReplaceWithTextBox", Type = typeof(TextBox))]
[TemplatePart(Name = "PART_FindAllButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_UseRegularExpressionsButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_SearchUpButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_SearchScopeComboBox", Type = typeof(ComboBox))]
[TemplatePart(Name = "PART_ModeToggleButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_ReplaceAllButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_ReplaceNextButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_MatchWholeWordButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_MatchCaseButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_FindNextButton", Type = typeof(ButtonBase))]
[TemplatePart(Name = "PART_FindWhatTextBox", Type = typeof(TextBox))]
public abstract class SearchViewBase : Control
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public IEditorSearchOptions xVY;

		public IEditorView NV4;

		public SearchViewBase kVo;

		internal static _003C_003Ec__DisplayClass15_0 VHl;

		public _003C_003Ec__DisplayClass15_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool xHW()
		{
			return VHl == null;
		}

		internal static _003C_003Ec__DisplayClass15_0 HHS()
		{
			return VHl;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public TextSnapshotOffset SVw;

		public CancellationToken YV6;

		public _003C_003Ec__DisplayClass15_0 MVH;

		private static _003C_003Ec__DisplayClass15_1 iHk;

		public _003C_003Ec__DisplayClass15_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void LVj()
		{
			try
			{
				_003C_003Ec__DisplayClass15_2 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_2();
				int num = 0;
				if (aHF() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				_003C_003Ec__DisplayClass15_.NVn = this;
				TextRange searchTextRange = ((MVH.xVY.Scope == EditorSearchScope.Selection) ? MVH.NV4.Searcher.SelectionScopeSnapshotRange.TextRange : SVw.Snapshot.TextRange);
				_003C_003Ec__DisplayClass15_.AVL = Math.Max(searchTextRange.FirstOffset, Math.Min(searchTextRange.LastOffset, SVw.Offset));
				_003C_003Ec__DisplayClass15_.AVT = SVw.Snapshot.FindNext(MVH.xVY, _003C_003Ec__DisplayClass15_.AVL, canWrap: true, searchTextRange, YV6);
				vAE.d0c<object>(MVH.kVo, _003C_003Ec__DisplayClass15_.XVb, null);
			}
			catch (InvalidRegexPatternException)
			{
			}
		}

		internal static bool JHZ()
		{
			return iHk == null;
		}

		internal static _003C_003Ec__DisplayClass15_1 aHF()
		{
			return iHk;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_2
	{
		public ISearchResultSet AVT;

		public int AVL;

		public _003C_003Ec__DisplayClass15_1 NVn;

		internal static _003C_003Ec__DisplayClass15_2 OH9;

		public _003C_003Ec__DisplayClass15_2()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void XVb(object o)
		{
			NVn.MVH.kVo.HasNoSearchResults = AVT == null || AVT.Results.Count == 0;
			if (AVT != null && AVT.Results.Count > 0 && NVn.SVw.Snapshot == NVn.MVH.NV4.CurrentSnapshot && (NVn.MVH.xVY.SearchUp ? NVn.MVH.NV4.Selection.LastOffset : NVn.MVH.NV4.Selection.FirstOffset) == AVL)
			{
				using (NVn.MVH.NV4.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoResetSearchStartOffset))
				{
					NVn.MVH.NV4.Selection.SelectRange(AVT.Results[0].TextRange);
				}
			}
		}

		internal static bool jHJ()
		{
			return OH9 == null;
		}

		internal static _003C_003Ec__DisplayClass15_2 bHR()
		{
			return OH9;
		}
	}

	private CancellationTokenSource Jly;

	private TextBox Slq;

	private bool xl2;

	private TextBox Tl7;

	private ReadOnlyCollection<ISearchPatternProvider> Cli;

	private DelegateCommand<object> Flp;

	private DelegateCommand<object> JlM;

	private DelegateCommand<object> olO;

	private DelegateCommand<object> tlU;

	private DelegateCommand<object> nlJ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Mlt;

	public static readonly DependencyProperty AnimationDurationProperty;

	public static readonly DependencyProperty ButtonStyleProperty;

	public static readonly DependencyProperty CanToggleReplaceProperty;

	public static readonly DependencyProperty HasNoSearchResultsProperty;

	public static readonly DependencyProperty IsFindAllButtonVisibleProperty;

	public static readonly DependencyProperty IsOptionsPanelExpandedProperty;

	public static readonly DependencyProperty IsReplaceVisibleProperty;

	public static readonly DependencyProperty SearchOptionsProperty;

	public static readonly DependencyProperty SearchPatternProviderFactoryProperty;

	public static readonly DependencyProperty UseRegularExpressionsProperty;

	private static SearchViewBase c0M;

	public ICommand FindAllCommand
	{
		get
		{
			if (Flp == null)
			{
				Flp = new DelegateCommand<object>(delegate
				{
					try
					{
						IEditorView targetView = TargetView;
						IEditorSearchOptions searchOptions = SearchOptions;
						if (targetView != null && searchOptions != null)
						{
							OnSearching(SearchOperationType.FindAll);
							targetView.Searcher.FindAll(searchOptions);
						}
					}
					catch (InvalidRegexPatternException ex)
					{
						Nlj(ex.Message);
					}
				}, delegate
				{
					IEditorView targetView = TargetView;
					IEditorSearchOptions searchOptions = SearchOptions;
					return targetView != null && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
				});
			}
			return Flp;
		}
	}

	public ICommand FindNextCommand
	{
		get
		{
			if (JlM == null)
			{
				JlM = new DelegateCommand<object>(delegate
				{
					try
					{
						IEditorView targetView = TargetView;
						IEditorSearchOptions searchOptions = SearchOptions;
						if (targetView != null && searchOptions != null)
						{
							OnSearching(SearchOperationType.FindNext);
							targetView.Searcher.FindNext(searchOptions);
						}
					}
					catch (InvalidRegexPatternException ex)
					{
						Nlj(ex.Message);
					}
				}, delegate
				{
					IEditorView targetView = TargetView;
					IEditorSearchOptions searchOptions = SearchOptions;
					return targetView != null && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
				});
			}
			return JlM;
		}
	}

	protected TextBox FindWhatTextBox
	{
		get
		{
			return Slq;
		}
		private set
		{
			if (Slq != null)
			{
				Slq.GotFocus -= SlY;
				Slq.KeyDown -= ll3;
				Slq.PreviewMouseLeftButtonDown -= kl4;
			}
			Slq = value;
			if (Slq != null)
			{
				Slq.GotFocus += SlY;
				Slq.KeyDown += ll3;
				Slq.PreviewMouseLeftButtonDown += kl4;
				int num = 0;
				if (!A03())
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
	}

	public ICommand ReplaceAllCommand
	{
		get
		{
			if (olO == null)
			{
				olO = new DelegateCommand<object>(delegate
				{
					try
					{
						IEditorView targetView = TargetView;
						IEditorSearchOptions searchOptions = SearchOptions;
						if (targetView != null && searchOptions != null)
						{
							OnSearching(SearchOperationType.ReplaceAll);
							targetView.Searcher.ReplaceAll(searchOptions);
						}
					}
					catch (InvalidRegexPatternException ex)
					{
						Nlj(ex.Message);
					}
				}, delegate
				{
					int num = 1;
					IEditorView targetView = default(IEditorView);
					while (true)
					{
						int num2 = num;
						do
						{
							switch (num2)
							{
							default:
							{
								IEditorSearchOptions searchOptions = SearchOptions;
								return targetView != null && !targetView.SyntaxEditor.Document.IsReadOnly && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
							}
							case 1:
								break;
							}
							targetView = TargetView;
							num2 = 0;
						}
						while (r0v() == null);
					}
				});
			}
			return olO;
		}
	}

	public ICommand ReplaceNextCommand
	{
		get
		{
			if (tlU == null)
			{
				tlU = new DelegateCommand<object>(delegate
				{
					try
					{
						IEditorView targetView = TargetView;
						IEditorSearchOptions searchOptions = SearchOptions;
						if (targetView != null && searchOptions != null)
						{
							OnSearching(SearchOperationType.ReplaceNext);
							targetView.Searcher.ReplaceNext(searchOptions);
						}
					}
					catch (InvalidRegexPatternException ex)
					{
						Nlj(ex.Message);
					}
				}, delegate
				{
					IEditorView targetView = TargetView;
					IEditorSearchOptions searchOptions = SearchOptions;
					return targetView != null && !targetView.SyntaxEditor.Document.IsReadOnly && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
				});
			}
			return tlU;
		}
	}

	protected TextBox ReplaceWithTextBox
	{
		get
		{
			return Tl7;
		}
		private set
		{
			if (Tl7 != null)
			{
				Tl7.GotFocus -= SlY;
				Tl7.KeyDown -= XlR;
				Tl7.PreviewMouseLeftButtonDown -= kl4;
			}
			Tl7 = value;
			if (Tl7 != null)
			{
				Tl7.GotFocus += SlY;
				Tl7.KeyDown += XlR;
				Tl7.PreviewMouseLeftButtonDown += kl4;
			}
		}
	}

	public abstract IEditorView TargetView { get; }

	public ICommand ToggleOptionsPanelExpandedCommand
	{
		get
		{
			if (nlJ == null)
			{
				nlJ = new DelegateCommand<object>(delegate
				{
					IsOptionsPanelExpanded = !IsOptionsPanelExpanded;
				});
			}
			return nlJ;
		}
	}

	public Duration AnimationDuration
	{
		get
		{
			return (Duration)GetValue(AnimationDurationProperty);
		}
		set
		{
			SetValue(AnimationDurationProperty, value);
		}
	}

	public Style ButtonStyle
	{
		get
		{
			return (Style)GetValue(ButtonStyleProperty);
		}
		set
		{
			SetValue(ButtonStyleProperty, value);
		}
	}

	public bool CanToggleReplace
	{
		get
		{
			return (bool)GetValue(CanToggleReplaceProperty);
		}
		set
		{
			SetValue(CanToggleReplaceProperty, value);
		}
	}

	public bool HasNoSearchResults
	{
		get
		{
			return (bool)GetValue(HasNoSearchResultsProperty);
		}
		set
		{
			SetValue(HasNoSearchResultsProperty, value);
		}
	}

	public bool IsFindAllButtonVisible
	{
		get
		{
			return (bool)GetValue(IsFindAllButtonVisibleProperty);
		}
		set
		{
			SetValue(IsFindAllButtonVisibleProperty, value);
		}
	}

	public bool IsOptionsPanelExpanded
	{
		get
		{
			return (bool)GetValue(IsOptionsPanelExpandedProperty);
		}
		set
		{
			SetValue(IsOptionsPanelExpandedProperty, value);
		}
	}

	public bool IsReplaceVisible
	{
		get
		{
			return (bool)GetValue(IsReplaceVisibleProperty);
		}
		set
		{
			SetValue(IsReplaceVisibleProperty, value);
		}
	}

	public IEditorSearchOptions SearchOptions
	{
		get
		{
			return (IEditorSearchOptions)GetValue(SearchOptionsProperty);
		}
		set
		{
			SetValue(SearchOptionsProperty, value);
		}
	}

	public ReadOnlyCollection<ISearchPatternProvider> SearchPatternProviders => Cli;

	public ISearchPatternProviderFactory SearchPatternProviderFactory
	{
		get
		{
			return (ISearchPatternProviderFactory)GetValue(SearchPatternProviderFactoryProperty);
		}
		set
		{
			SetValue(SearchPatternProviderFactoryProperty, value);
		}
	}

	public bool UseRegularExpressions
	{
		get
		{
			return (bool)GetValue(UseRegularExpressionsProperty);
		}
		set
		{
			SetValue(UseRegularExpressionsProperty, value);
		}
	}

	public event EventHandler SearchOptionsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Mlt;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Mlt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Mlt;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Mlt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected SearchViewBase()
	{
		grA.DaB7cz();
		base._002Ector();
		IlH(null, SearchOptions as INotifyPropertyChanged);
		Alw();
	}

	internal void Il1()
	{
		if (Jly != null)
		{
			Jly.Cancel();
			Jly.Dispose();
			Jly = null;
		}
	}

	internal void ylF()
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.kVo = this;
		_003C_003Ec__DisplayClass15_.NV4 = TargetView;
		_003C_003Ec__DisplayClass15_.xVY = SearchOptions;
		if (_003C_003Ec__DisplayClass15_.NV4 != null && _003C_003Ec__DisplayClass15_.xVY != null && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass15_.xVY.FindText))
		{
			_003C_003Ec__DisplayClass15_.xVY = _003C_003Ec__DisplayClass15_.xVY.Clone() as IEditorSearchOptions;
			if (_003C_003Ec__DisplayClass15_.xVY != null)
			{
				_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass15_1();
				CS_0024_003C_003E8__locals17.MVH = _003C_003Ec__DisplayClass15_;
				CS_0024_003C_003E8__locals17.SVw = new TextSnapshotOffset(CS_0024_003C_003E8__locals17.MVH.NV4.CurrentSnapshot, CS_0024_003C_003E8__locals17.MVH.xVY.SearchUp ? CS_0024_003C_003E8__locals17.MVH.NV4.Selection.LastOffset : CS_0024_003C_003E8__locals17.MVH.NV4.Selection.FirstOffset);
				Il1();
				Jly = new CancellationTokenSource();
				CS_0024_003C_003E8__locals17.YV6 = Jly.Token;
				Task.Factory.StartNew(delegate
				{
					try
					{
						_003C_003Ec__DisplayClass15_2 _003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_2();
						int num = 0;
						if (_003C_003Ec__DisplayClass15_1.aHF() != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						default:
						{
							_003C_003Ec__DisplayClass15_2.NVn = CS_0024_003C_003E8__locals17;
							TextRange searchTextRange = ((CS_0024_003C_003E8__locals17.MVH.xVY.Scope == EditorSearchScope.Selection) ? CS_0024_003C_003E8__locals17.MVH.NV4.Searcher.SelectionScopeSnapshotRange.TextRange : CS_0024_003C_003E8__locals17.SVw.Snapshot.TextRange);
							_003C_003Ec__DisplayClass15_2.AVL = Math.Max(searchTextRange.FirstOffset, Math.Min(searchTextRange.LastOffset, CS_0024_003C_003E8__locals17.SVw.Offset));
							_003C_003Ec__DisplayClass15_2.AVT = CS_0024_003C_003E8__locals17.SVw.Snapshot.FindNext(CS_0024_003C_003E8__locals17.MVH.xVY, _003C_003Ec__DisplayClass15_2.AVL, canWrap: true, searchTextRange, CS_0024_003C_003E8__locals17.YV6);
							vAE.d0c<object>(CS_0024_003C_003E8__locals17.MVH.kVo, _003C_003Ec__DisplayClass15_2.XVb, null);
							break;
						}
						}
					}
					catch (InvalidRegexPatternException)
					{
					}
				}, CS_0024_003C_003E8__locals17.YV6);
				return;
			}
		}
		HasNoSearchResults = false;
	}

	private void ll3(object P_0, KeyEventArgs P_1)
	{
		OnFindWhatTextBoxKeyDown(P_1);
	}

	private void XlR(object P_0, KeyEventArgs P_1)
	{
		OnReplaceWithTextBoxKeyDown(P_1);
	}

	private void SlY(object P_0, RoutedEventArgs P_1)
	{
		if (!xl2 && P_1.OriginalSource is TextBox textBox)
		{
			textBox.SelectAll();
		}
	}

	private void kl4(object P_0, MouseButtonEventArgs P_1)
	{
		if (!(P_1.OriginalSource is DependencyObject source) || !(VisualTreeHelperExtended.GetAncestor(source, typeof(TextBox)) is TextBox { IsKeyboardFocusWithin: false } textBox))
		{
			return;
		}
		try
		{
			xl2 = true;
			textBox.Focus();
		}
		finally
		{
			xl2 = false;
		}
	}

	private void Ylo()
	{
		OnSearchOptionsChanged();
	}

	private static void Nlj(string P_0)
	{
		MessageBox.Show(P_0);
	}

	private void Alw()
	{
		List<ISearchPatternProvider> list = new List<ISearchPatternProvider>();
		if (SearchPatternProviderFactory != null)
		{
			ISearchPatternProviderCollection searchPatternProviderCollection = SearchPatternProviderFactory.CreateProviders();
			if (searchPatternProviderCollection != null)
			{
				foreach (ISearchPatternProvider item in searchPatternProviderCollection)
				{
					list.Add(item);
				}
			}
		}
		if (list.Count == 0)
		{
			list.Add(ActiproSoftware.Text.Searching.SearchPatternProviders.Normal);
		}
		Cli = list.AsReadOnly();
	}

	public bool FocusFindWhatTextBox()
	{
		if (Slq != null)
		{
			Slq.SelectAll();
			return Slq.Focus();
		}
		return false;
	}

	protected virtual void OnFindSearchOptionsChanged()
	{
	}

	protected virtual void OnFindWhatTextBoxKeyDown(KeyEventArgs e)
	{
		if (e == null || e.Handled)
		{
			return;
		}
		Key key = e.Key;
		Key key2 = key;
		if (key2 != Key.Return)
		{
			return;
		}
		ModifierKeys modifierKeys = vAE.A0o();
		IEditorSearchOptions searchOptions = default(IEditorSearchOptions);
		bool flag = default(bool);
		int num;
		int num2 = default(int);
		switch (modifierKeys)
		{
		case ModifierKeys.None:
		case ModifierKeys.Shift:
			searchOptions = SearchOptions;
			flag = searchOptions != null;
			num = 1;
			if (!A03())
			{
				goto IL_0005;
			}
			goto IL_0009;
		case ModifierKeys.Alt:
		case ModifierKeys.Alt | ModifierKeys.Control:
			break;
		case ModifierKeys.Control:
			{
				if (IsFindAllButtonVisible)
				{
					num = 0;
					if (r0v() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				break;
			}
			IL_0009:
			switch (num)
			{
			default:
				FindAllCommand.Execute(null);
				e.Handled = true;
				break;
			case 1:
				if (flag)
				{
					searchOptions.SearchUp = modifierKeys == ModifierKeys.Shift;
				}
				FindNextCommand.Execute(null);
				e.Handled = true;
				break;
			}
			break;
			IL_0005:
			num = num2;
			goto IL_0009;
		}
	}

	protected virtual void OnReplaceWithTextBoxKeyDown(KeyEventArgs e)
	{
		if (e == null || e.Handled)
		{
			return;
		}
		Key key = e.Key;
		Key key2 = key;
		if (key2 != Key.Return)
		{
			return;
		}
		ModifierKeys modifierKeys = vAE.A0o();
		ModifierKeys modifierKeys2 = modifierKeys;
		ModifierKeys modifierKeys3 = modifierKeys2;
		if (modifierKeys3 == ModifierKeys.None || modifierKeys3 == ModifierKeys.Shift)
		{
			IEditorSearchOptions searchOptions = SearchOptions;
			if (searchOptions != null)
			{
				searchOptions.SearchUp = modifierKeys == ModifierKeys.Shift;
			}
			ReplaceNextCommand.Execute(null);
			e.Handled = true;
		}
	}

	protected virtual void OnSearching(SearchOperationType operationType)
	{
	}

	protected virtual void OnSearchOptionsChanged()
	{
		Mlt?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnSearchScopeChanged()
	{
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected virtual void RaiseCanExecuteChangedForCommands()
	{
		if (Flp != null)
		{
			Flp.RaiseCanExecuteChanged();
		}
		if (JlM != null)
		{
			JlM.RaiseCanExecuteChanged();
		}
		if (olO != null)
		{
			olO.RaiseCanExecuteChanged();
		}
		if (tlU != null)
		{
			tlU.RaiseCanExecuteChanged();
			int num = 0;
			if (r0v() != null)
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

	private static void ol6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SearchViewBase searchViewBase = (SearchViewBase)P_0;
		INotifyPropertyChanged notifyPropertyChanged = P_1.OldValue as INotifyPropertyChanged;
		INotifyPropertyChanged notifyPropertyChanged2 = P_1.NewValue as INotifyPropertyChanged;
		searchViewBase.IlH(notifyPropertyChanged, notifyPropertyChanged2);
	}

	private void IlH(INotifyPropertyChanged P_0, INotifyPropertyChanged P_1)
	{
		if (P_0 != null)
		{
			P_0.PropertyChanged -= Vlb;
		}
		if (P_1 != null)
		{
			P_1.PropertyChanged += Vlb;
		}
		RaiseCanExecuteChangedForCommands();
		zln();
		Ylo();
	}

	private void Vlb(object P_0, PropertyChangedEventArgs P_1)
	{
		RaiseCanExecuteChangedForCommands();
		IEditorSearchOptions searchOptions = SearchOptions;
		if (searchOptions != null)
		{
			UseRegularExpressions = searchOptions.PatternProvider == ActiproSoftware.Text.Searching.SearchPatternProviders.RegularExpression;
		}
		zln();
		Ylo();
		if (P_1 != null)
		{
			if (P_1.PropertyName == Q7Z.tqM(9638))
			{
				OnSearchScopeChanged();
			}
			string propertyName = P_1.PropertyName;
			string text = propertyName;
			if ((text == Q7Z.tqM(9652) || text == Q7Z.tqM(9672) || text == Q7Z.tqM(9694) || text == Q7Z.tqM(9726) || text == Q7Z.tqM(9638)) && vAE.y0m(this))
			{
				OnFindSearchOptionsChanged();
			}
		}
	}

	private static void hlT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SearchViewBase searchViewBase = (SearchViewBase)P_0;
		searchViewBase.Alw();
	}

	private static void nlL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SearchViewBase searchViewBase = (SearchViewBase)P_0;
		IEditorSearchOptions searchOptions = searchViewBase.SearchOptions;
		if (searchOptions != null)
		{
			searchOptions.PatternProvider = (searchViewBase.UseRegularExpressions ? ActiproSoftware.Text.Searching.SearchPatternProviders.RegularExpression : ActiproSoftware.Text.Searching.SearchPatternProviders.Normal);
		}
	}

	private void zln()
	{
		bool flag = SearchOptions?.SearchUp ?? false;
		if (GetTemplateChild(Q7Z.tqM(9760)) is ButtonBase element)
		{
			ToolTipService.SetToolTip(element, SR.GetString(SRName.UISearchOverlayPaneFindNextButtonToolTip, flag ? Q7Z.tqM(9810) : Q7Z.tqM(9802)));
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		FindWhatTextBox = GetTemplateChild(Q7Z.tqM(9830)) as TextBox;
		ReplaceWithTextBox = GetTemplateChild(Q7Z.tqM(9874)) as TextBox;
		if (GetTemplateChild(Q7Z.tqM(9924)) is ButtonBase element)
		{
			ToolTipService.SetToolTip(element, SR.GetString(SRName.UISearchOverlayPaneFindAllButtonToolTip));
		}
		zln();
		if (GetTemplateChild(Q7Z.tqM(9964)) is ButtonBase element2)
		{
			ToolTipService.SetToolTip(element2, SR.GetString(SRName.UISearchOverlayPaneReplaceAllButtonToolTip, Q7Z.tqM(10010)));
		}
		if (GetTemplateChild(Q7Z.tqM(10024)) is ButtonBase element3)
		{
			ToolTipService.SetToolTip(element3, SR.GetString(SRName.UISearchOverlayPaneReplaceNextButtonToolTip, Q7Z.tqM(10072)));
		}
		if (GetTemplateChild(Q7Z.tqM(10086)) is ButtonBase element4)
		{
			ToolTipService.SetToolTip(element4, SR.GetString(SRName.UISearchOverlayPaneMatchCaseButtonToolTip, Q7Z.tqM(10130)));
		}
		if (GetTemplateChild(Q7Z.tqM(10144)) is ButtonBase element5)
		{
			ToolTipService.SetToolTip(element5, SR.GetString(SRName.UISearchOverlayPaneMatchWholeWordButtonToolTip, Q7Z.tqM(10198)));
		}
		if (GetTemplateChild(Q7Z.tqM(10212)) is ButtonBase element6)
		{
			ToolTipService.SetToolTip(element6, SR.GetString(SRName.UISearchOverlayPaneUseRegularExpressionsButtonToolTip, Q7Z.tqM(10280)));
		}
		if (GetTemplateChild(Q7Z.tqM(10294)) is ButtonBase element7)
		{
			ToolTipService.SetToolTip(element7, SR.GetString(SRName.UISearchOverlayPaneSearchUpButtonToolTip, Q7Z.tqM(10336)));
		}
		if (GetTemplateChild(Q7Z.tqM(10350)) is ButtonBase element8)
		{
			ToolTipService.SetToolTip(element8, SR.GetString(SRName.UISearchOverlayPaneToggleReplaceButtonToolTip));
		}
		if (GetTemplateChild(Q7Z.tqM(10396)) is ButtonBase element9)
		{
			ToolTipService.SetToolTip(element9, SR.GetString(SRName.UISearchOverlayPaneCloseButtonToolTip, Q7Z.tqM(10432)));
		}
	}

	static SearchViewBase()
	{
		grA.DaB7cz();
		AnimationDurationProperty = DependencyProperty.RegisterAttached(Q7Z.tqM(10442), typeof(Duration), typeof(SearchViewBase), new PropertyMetadata(new Duration(TimeSpan.FromMilliseconds(100.0))));
		ButtonStyleProperty = DependencyProperty.Register(Q7Z.tqM(10480), typeof(Style), typeof(SearchViewBase), new PropertyMetadata(null));
		CanToggleReplaceProperty = DependencyProperty.Register(Q7Z.tqM(10506), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(true));
		HasNoSearchResultsProperty = DependencyProperty.Register(Q7Z.tqM(10542), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(false));
		IsFindAllButtonVisibleProperty = DependencyProperty.Register(Q7Z.tqM(10582), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(false));
		IsOptionsPanelExpandedProperty = DependencyProperty.Register(Q7Z.tqM(10630), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(false));
		IsReplaceVisibleProperty = DependencyProperty.Register(Q7Z.tqM(10678), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(false));
		SearchOptionsProperty = DependencyProperty.Register(Q7Z.tqM(6772), typeof(IEditorSearchOptions), typeof(SearchViewBase), new PropertyMetadata(EditorSearchOptions.Default, ol6));
		SearchPatternProviderFactoryProperty = DependencyProperty.Register(Q7Z.tqM(10714), typeof(ISearchPatternProviderFactory), typeof(SearchViewBase), new PropertyMetadata(new DefaultSearchPatternProviderFactory(), hlT));
		UseRegularExpressionsProperty = DependencyProperty.Register(Q7Z.tqM(10774), typeof(bool), typeof(SearchViewBase), new PropertyMetadata(false, nlL));
	}

	[CompilerGenerated]
	private void bl8(object P_0)
	{
		try
		{
			IEditorView targetView = TargetView;
			IEditorSearchOptions searchOptions = SearchOptions;
			if (targetView != null && searchOptions != null)
			{
				OnSearching(SearchOperationType.FindAll);
				targetView.Searcher.FindAll(searchOptions);
			}
		}
		catch (InvalidRegexPatternException ex)
		{
			Nlj(ex.Message);
		}
	}

	[CompilerGenerated]
	private bool XlI(object P_0)
	{
		IEditorView targetView = TargetView;
		IEditorSearchOptions searchOptions = SearchOptions;
		return targetView != null && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
	}

	[CompilerGenerated]
	private void Ul5(object P_0)
	{
		try
		{
			IEditorView targetView = TargetView;
			IEditorSearchOptions searchOptions = SearchOptions;
			if (targetView != null && searchOptions != null)
			{
				OnSearching(SearchOperationType.FindNext);
				targetView.Searcher.FindNext(searchOptions);
			}
		}
		catch (InvalidRegexPatternException ex)
		{
			Nlj(ex.Message);
		}
	}

	[CompilerGenerated]
	private bool Fl0(object P_0)
	{
		IEditorView targetView = TargetView;
		IEditorSearchOptions searchOptions = SearchOptions;
		return targetView != null && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
	}

	[CompilerGenerated]
	private void KlB(object P_0)
	{
		try
		{
			IEditorView targetView = TargetView;
			IEditorSearchOptions searchOptions = SearchOptions;
			if (targetView != null && searchOptions != null)
			{
				OnSearching(SearchOperationType.ReplaceAll);
				targetView.Searcher.ReplaceAll(searchOptions);
			}
		}
		catch (InvalidRegexPatternException ex)
		{
			Nlj(ex.Message);
		}
	}

	[CompilerGenerated]
	private bool NlV(object P_0)
	{
		int num = 1;
		IEditorView targetView = default(IEditorView);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					IEditorSearchOptions searchOptions = SearchOptions;
					return targetView != null && !targetView.SyntaxEditor.Document.IsReadOnly && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
				}
				case 1:
					break;
				}
				targetView = TargetView;
				num2 = 0;
			}
			while (r0v() == null);
		}
	}

	[CompilerGenerated]
	private void Hlr(object P_0)
	{
		try
		{
			IEditorView targetView = TargetView;
			IEditorSearchOptions searchOptions = SearchOptions;
			if (targetView != null && searchOptions != null)
			{
				OnSearching(SearchOperationType.ReplaceNext);
				targetView.Searcher.ReplaceNext(searchOptions);
			}
		}
		catch (InvalidRegexPatternException ex)
		{
			Nlj(ex.Message);
		}
	}

	[CompilerGenerated]
	private bool rls(object P_0)
	{
		IEditorView targetView = TargetView;
		IEditorSearchOptions searchOptions = SearchOptions;
		return targetView != null && !targetView.SyntaxEditor.Document.IsReadOnly && searchOptions != null && !string.IsNullOrEmpty(searchOptions.FindText);
	}

	[CompilerGenerated]
	private void flk(object P_0)
	{
		IsOptionsPanelExpanded = !IsOptionsPanelExpanded;
	}

	internal static bool A03()
	{
		return c0M == null;
	}

	internal static SearchViewBase r0v()
	{
		return c0M;
	}
}
