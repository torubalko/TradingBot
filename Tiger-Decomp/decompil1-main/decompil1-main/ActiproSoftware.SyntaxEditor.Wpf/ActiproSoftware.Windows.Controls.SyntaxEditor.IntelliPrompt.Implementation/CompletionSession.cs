using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Navigation;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public class CompletionSession : IntelliPromptSessionBase, ICompletionSession, IIntelliPromptSession, IServiceLocator, IEditorDocumentTextChangeEventSink, IEditorViewKeyInputEventSink, IEditorViewPointerInputEventSink, IEditorViewSelectionChangeEventSink, IEditorViewTextInputEventSink
{
	[Flags]
	private enum v7i
	{

	}

	private class a7c
	{
		private v7i Arj;

		internal static a7c ojN;

		public a7c()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal bool pr4(v7i P_0)
		{
			return (Arj & P_0) == P_0;
		}

		internal void Nro(v7i P_0, bool P_1)
		{
			if (!P_1)
			{
				Arj &= ~P_0;
			}
			else
			{
				Arj |= P_0;
			}
		}

		internal static bool EjH()
		{
			return ojN == null;
		}

		internal static a7c Njj()
		{
			return ojN;
		}
	}

	private class P7p : QuickInfoSession
	{
		internal static P7p gjM;

		public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.CompletionDescriptionTip;

		protected override void OnViewKeyDown(IEditorView P_0, KeyEventArgs P_1)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(1014));
			}
			Key key = P_1.Key;
			Key key2 = key;
			if (key2 != Key.Escape)
			{
				base.OnViewKeyDown(P_0, P_1);
			}
		}

		public P7p()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool Ij3()
		{
			return gjM == null;
		}

		internal static P7p Ljv()
		{
			return gjM;
		}
	}

	private CharClass w1B;

	private string n1V;

	private CharClass G1r;

	private IntelliPromptCompletionList J1s;

	private Popup D1k;

	private double V1S;

	private double x19;

	private TimeSpan b1y;

	private P7p y1q;

	private BTZ J12;

	private P4 G17;

	private ICompletionItemCollectionView M1i;

	private uY Y1p;

	private a7c F1M;

	private ICompletionItemMatcherCollection I1O;

	private yo i1U;

	private CompletionSelection x1J;

	private TextSnapshotRange Y1t;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Q1Z;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<CancelEventArgs> j1h;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler o1N;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler i1d;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object G1z;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CompletionMatchOptions iFW;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private RequestNavigateEventHandler jFP;

	private static CompletionSession vLx;

	[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public CharClass AllowedCharacters
	{
		get
		{
			return w1B;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(191580));
			}
			w1B = value;
		}
	}

	public override Rect? Bounds => (D1k != null) ? GetPopupBounds(D1k) : ((Rect?)null);

	public bool CanCommitWithoutPopup
	{
		get
		{
			return F1M.pr4((v7i)4);
		}
		set
		{
			F1M.Nro((v7i)4, value);
		}
	}

	public bool CanFilterUnmatchedItems
	{
		get
		{
			return F1M.pr4((v7i)8);
		}
		set
		{
			if (CanFilterUnmatchedItems != value)
			{
				F1M.Nro((v7i)8, value);
				ApplyFilters();
			}
		}
	}

	protected override bool CanOpenForReadOnlyTextRanges => false;

	public bool CanHighlightMatchedText
	{
		get
		{
			return F1M.pr4((v7i)16);
		}
		set
		{
			F1M.Nro((v7i)16, value);
		}
	}

	public override bool ClosesOnLostFocus => true;

	[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
	public CharClass CommitCharacters
	{
		get
		{
			return G1r;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(191580));
			}
			G1r = value;
		}
	}

	public object Context
	{
		[CompilerGenerated]
		get
		{
			return G1z;
		}
		[CompilerGenerated]
		set
		{
			G1z = value;
		}
	}

	public double ControlKeyDownOpacity
	{
		get
		{
			return V1S;
		}
		set
		{
			V1S = Math.Max(0.0, Math.Min(1.0, value));
			if (y1q != null)
			{
				y1q.ControlKeyDownOpacity = V1S;
			}
		}
	}

	public double DescriptionTipMaxWidth
	{
		get
		{
			return x19;
		}
		set
		{
			x19 = value;
		}
	}

	public TimeSpan DescriptionTipShowDelay
	{
		get
		{
			return b1y;
		}
		set
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(1.0);
			if (value < timeSpan)
			{
				value = timeSpan;
			}
			b1y = value;
		}
	}

	public ICompletionItemCollectionView FilteredItems => M1i;

	public ICompletionFilterCollection Filters => Y1p;

	public bool IsEnterKeyHandledOnCommit
	{
		get
		{
			return F1M.pr4((v7i)32);
		}
		set
		{
			F1M.Nro((v7i)32, value);
		}
	}

	public ICompletionItemMatcherCollection ItemMatchers
	{
		get
		{
			if (I1O == null)
			{
				I1O = new ql();
				I1O.Add(new OO());
				I1O.Add(new on());
				I1O.Add(new MC());
				I1O.Add(new mm());
			}
			return I1O;
		}
	}

	public ICompletionItemCollection Items => i1U;

	public CompletionMatchOptions MatchOptions
	{
		[CompilerGenerated]
		get
		{
			return iFW;
		}
		[CompilerGenerated]
		set
		{
			iFW = value;
		}
	}

	protected virtual Rect? PlacementRectangle => null;

	public bool RequiresFilterOnTextChange
	{
		get
		{
			return F1M.pr4((v7i)64);
		}
		set
		{
			F1M.Nro((v7i)64, value);
		}
	}

	public CompletionSelection Selection
	{
		get
		{
			return x1J;
		}
		set
		{
			SetSelection(value, scrollToMiddle: true);
		}
	}

	public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.Completion;

	public string TypedText
	{
		get
		{
			if (n1V != null)
			{
				return n1V;
			}
			if (Y1t.IsDeleted)
			{
				return string.Empty;
			}
			n1V = Y1t.Text;
			if (!string.IsNullOrEmpty(n1V) && char.IsWhiteSpace(n1V[0]) && !w1B.Contains(' '))
			{
				n1V = n1V.TrimStart();
			}
			return n1V;
		}
	}

	public event EventHandler Committed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Q1Z;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Q1Z, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Q1Z;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Q1Z, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CancelEventArgs> Committing
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CancelEventArgs> eventHandler = j1h;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref j1h, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CancelEventArgs> eventHandler = j1h;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref j1h, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = i1d;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref i1d, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = i1d;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref i1d, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event RequestNavigateEventHandler RequestNavigate
	{
		[CompilerGenerated]
		add
		{
			RequestNavigateEventHandler requestNavigateEventHandler = jFP;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Combine(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref jFP, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestNavigateEventHandler requestNavigateEventHandler = jFP;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Remove(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref jFP, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void t1I(EventHandler value)
	{
		EventHandler eventHandler = o1N;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref o1N, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void e15(EventHandler value)
	{
		EventHandler eventHandler = o1N;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref o1N, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public CompletionSession()
	{
		grA.DaB7cz();
		V1S = 0.25;
		x19 = 800.0;
		b1y = TimeSpan.FromMilliseconds(400.0);
		y1q = new P7p();
		Y1p = new uY();
		F1M = new a7c();
		i1U = new yo();
		base._002Ector();
		w1B = new CharClass('_');
		G1r = CharClass.All;
		M1i = new gy(i1U)
		{
			Filter = w1o
		};
		CanCommitWithoutPopup = true;
		CanHighlightMatchedText = true;
		IsEnterKeyHandledOnCommit = true;
		int num = 0;
		if (1 == 0)
		{
			goto IL_009b;
		}
		goto IL_009f;
		IL_009b:
		int num2;
		num = num2;
		goto IL_009f;
		IL_009f:
		do
		{
			switch (num)
			{
			case 1:
				RegisterService((IEditorViewKeyInputEventSink)this);
				RegisterService((IEditorViewSelectionChangeEventSink)this);
				RegisterService((IEditorViewTextInputEventSink)this);
				return;
			}
			MatchOptions = CompletionMatchOptions.None;
			RegisterService((IEditorDocumentTextChangeEventSink)this);
			num = 1;
		}
		while (true);
		goto IL_009b;
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		OnDocumentTextChanged(editor, e);
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		OnDocumentTextChanging(editor, e);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyDown(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyDown(view, e);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyUp(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyUp(view, e);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerEntered(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerExited(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerHovered(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerMoved(IEditorView view, InputPointerEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerPressed(IEditorView view, InputPointerButtonEventArgs e)
	{
		OnViewPointerPressed(view, e);
	}

	void IEditorViewPointerInputEventSink.NotifyPointerReleased(IEditorView view, InputPointerButtonEventArgs e)
	{
	}

	void IEditorViewPointerInputEventSink.NotifyPointerWheel(IEditorView view, InputPointerWheelEventArgs e)
	{
	}

	void IEditorViewTextInputEventSink.NotifyTextInput(IEditorView view, TextCompositionEventArgs e)
	{
		OnViewTextInput(view, e);
	}

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		OnViewSelectionChanged(view, e);
	}

	public void CloseDescriptionTip()
	{
		if (y1q.IsOpen)
		{
			y1q.Close(cancelled: true);
		}
	}

	private void I1m()
	{
		S1C();
	}

	public void RestartDescriptionTipTimer()
	{
		if (J12 != null)
		{
			J12.Stop();
		}
		CloseDescriptionTip();
		if (J12 != null)
		{
			J12.Start((int)b1y.TotalMilliseconds);
		}
	}

	private void S1C()
	{
		if (base.IsOpen && J1s != null && x1J != null)
		{
			object obj = ((x1J.Item.DescriptionProvider != null) ? x1J.Item.DescriptionProvider.GetContent() : null);
			if (obj != null && J1s.JQd(out var placementTarget, out var placementRectangle))
			{
				CloseDescriptionTip();
				L1H();
				y1q.Content = obj;
				y1q.Open(base.View, PlacementMode.Right, placementTarget, placementRectangle);
				return;
			}
		}
		CloseDescriptionTip();
	}

	private void r1u(bool P_0)
	{
		if (M1i != null)
		{
			int count = M1i.Count;
			M1i.Refresh();
			int num = 0;
			if (XLL() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			P_0 |= count != M1i.Count;
		}
		if (P_0 && J1s != null)
		{
			J1s.mQh(_0020: true);
		}
	}

	private CompletionSelection R11(string P_0, bool P_1)
	{
		ICompletionItemMatcherCollection itemMatchers = ItemMatchers;
		if (itemMatchers == null)
		{
			return null;
		}
		CompletionSelection completionSelection = null;
		if (!string.IsNullOrEmpty(P_0))
		{
			if (P_1)
			{
				foreach (ICompletionItemMatcher item in itemMatchers)
				{
					CompletionSelection completionSelection2 = item.Match(this, M1i, P_0, P_1);
					if (completionSelection2 != null && !completionSelection2.Equals(completionSelection))
					{
						if (completionSelection2.State != CompletionSelectionState.Full || completionSelection != null)
						{
							completionSelection = null;
							break;
						}
						completionSelection = completionSelection2;
					}
				}
			}
			else
			{
				foreach (ICompletionItemMatcher item2 in itemMatchers)
				{
					completionSelection = item2.Match(this, M1i, P_0, P_1);
					if (completionSelection != null)
					{
						break;
					}
				}
			}
		}
		return completionSelection;
	}

	internal IEnumerable<StringFilterCapture> K1F(ICompletionItem P_0)
	{
		if (P_0 == null || !CanHighlightMatchedText)
		{
			yield break;
		}
		string typedText = TypedText;
		if (string.IsNullOrEmpty(typedText) || ((MatchOptions & CompletionMatchOptions.TargetsDisplayText) != CompletionMatchOptions.TargetsDisplayText && !(P_0.Text == P_0.AutoCompletePreText)))
		{
			yield break;
		}
		ICompletionItemMatcherCollection matchers = ItemMatchers;
		if (matchers == null)
		{
			yield break;
		}
		foreach (ICompletionItemMatcher matcher in matchers)
		{
			IEnumerable<TextRange> highlightedRanges = matcher.GetHighlightedTextRanges(this, P_0, typedText);
			if (highlightedRanges == null)
			{
				continue;
			}
			foreach (TextRange highlightedRange in highlightedRanges)
			{
				yield return new StringFilterCapture(highlightedRange.StartOffset, highlightedRange.Length);
			}
			yield break;
		}
	}

	private bool s13(char P_0)
	{
		if (char.IsLetterOrDigit(P_0))
		{
			return true;
		}
		return w1B.Contains(P_0);
	}

	private bool y1R(char P_0)
	{
		return G1r.Contains(P_0);
	}

	private void G1Y(object P_0, object P_1)
	{
		if (base.IsOpen)
		{
			Close(cancelled: true);
		}
	}

	private void c14(object P_0, EventArgs P_1)
	{
		if (J1s != null && !F1M.pr4((v7i)2))
		{
			ICompletionItem completionItem = J1s.SelectedItem;
			SetSelection((completionItem != null) ? new CompletionSelection(completionItem, CompletionSelectionState.Full) : null, scrollToMiddle: false);
		}
	}

	private bool w1o(object P_0)
	{
		bool result = default(bool);
		if (!(P_0 is ICompletionItem completionItem))
		{
			result = false;
			goto IL_02aa;
		}
		bool flag = default(bool);
		int num;
		if (CanFilterUnmatchedItems)
		{
			if (G17 == null)
			{
				G17 = new P4();
			}
			flag = G17.Filter(this, completionItem) == CompletionFilterResult.Excluded;
			num = 0;
			if (XLL() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		goto IL_0258;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_02f7;
		}
		goto IL_02aa;
		IL_02f7:
		if (!flag)
		{
			goto IL_0258;
		}
		result = false;
		goto IL_02aa;
		IL_02aa:
		return result;
		IL_0258:
		Dictionary<string, CompletionFilterResult> dictionary = null;
		int num4 = default(int);
		foreach (ICompletionFilter filter in Filters)
		{
			if (filter == null || !filter.IsActive)
			{
				continue;
			}
			if (filter.Filter(this, completionItem) != CompletionFilterResult.Excluded)
			{
				if (!string.IsNullOrEmpty(filter.GroupName))
				{
					if (dictionary == null)
					{
						dictionary = new Dictionary<string, CompletionFilterResult>();
					}
					dictionary[filter.GroupName] = CompletionFilterResult.Included;
				}
				continue;
			}
			int num3 = 1;
			if (!QLa())
			{
				num3 = num4;
			}
			while (true)
			{
				switch (num3)
				{
				default:
					result = false;
					goto end_IL_008f;
				case 1:
					if (!string.IsNullOrEmpty(filter.GroupName))
					{
						if (dictionary == null)
						{
							dictionary = new Dictionary<string, CompletionFilterResult>();
						}
						if (!dictionary.TryGetValue(filter.GroupName, out var _))
						{
							dictionary[filter.GroupName] = CompletionFilterResult.Excluded;
						}
						break;
					}
					num3 = 0;
					if (XLL() != null)
					{
						num3 = 0;
					}
					continue;
				}
				goto IL_0154;
				continue;
				end_IL_008f:
				break;
			}
			goto IL_02aa;
			IL_0154:;
		}
		if (dictionary != null && dictionary.Any((KeyValuePair<string, CompletionFilterResult> pair) => pair.Value == CompletionFilterResult.Excluded))
		{
			result = false;
			num = 1;
			if (!QLa())
			{
				num = 1;
			}
			goto IL_0009;
		}
		result = true;
		goto IL_02aa;
	}

	[SpecialName]
	private int q1n()
	{
		return (x1J != null) ? M1i.IndexOf(x1J.Item) : (-1);
	}

	private void M1j()
	{
		int num = q1n();
		if (num < M1i.Count - 1)
		{
			SetSelection(new CompletionSelection(M1i[num + 1], CompletionSelectionState.Full), scrollToMiddle: false);
		}
	}

	private void g1w()
	{
		int num = q1n();
		if (num > 0)
		{
			SetSelection(new CompletionSelection(M1i[num - 1], CompletionSelectionState.Full), scrollToMiddle: false);
		}
	}

	internal void SetSelection(CompletionSelection value, bool scrollToMiddle)
	{
		if (value != null)
		{
			if (x1J != null && x1J.Item == value.Item)
			{
				if (x1J.State == value.State)
				{
					return;
				}
				scrollToMiddle = false;
			}
		}
		else if (x1J == null)
		{
			return;
		}
		x1J = value;
		if (J1s != null)
		{
			F1M.Nro((v7i)2, _0020: true);
			try
			{
				J1s.IQN(x1J, scrollToMiddle);
			}
			finally
			{
				F1M.Nro((v7i)2, _0020: false);
			}
		}
		RestartDescriptionTipTimer();
		OnSelectionChanged(EventArgs.Empty);
	}

	internal void R16(string P_0, bool P_1)
	{
		if (F1M.pr4((v7i)1))
		{
			return;
		}
		if (P_1 && J1s != null && (RequiresFilterOnTextChange || CanFilterUnmatchedItems))
		{
			r1u(_0020: false);
			RestartDescriptionTipTimer();
		}
		o1N?.Invoke(this, EventArgs.Empty);
		CompletionSelection completionSelection = R11(P_0, _0020: false);
		if (completionSelection != null)
		{
			SetSelection(completionSelection, scrollToMiddle: true);
			return;
		}
		if (Selection != null)
		{
			if (Selection.State == CompletionSelectionState.Full)
			{
				SetSelection(new CompletionSelection(Selection.Item, CompletionSelectionState.Partial), scrollToMiddle: true);
			}
			return;
		}
		ICompletionItem completionItem = M1i.OfType<ICompletionItem>().FirstOrDefault();
		if (completionItem != null)
		{
			SetSelection(new CompletionSelection(completionItem, CompletionSelectionState.Partial), scrollToMiddle: false);
		}
	}

	public void ApplyFilters()
	{
		r1u(_0020: true);
	}

	public void Cancel()
	{
		if (base.IsOpen && !F1M.pr4((v7i)1))
		{
			Close(cancelled: true);
		}
	}

	public void Commit()
	{
		if (!base.IsOpen || x1J == null)
		{
			return;
		}
		CancelEventArgs e = new CancelEventArgs();
		OnCommitting(e);
		if (e.Cancel || !base.IsOpen || x1J == null)
		{
			return;
		}
		F1M.Nro((v7i)1, _0020: true);
		try
		{
			EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(base.View);
			editorViewTextChangeOptions.CheckReadOnly = true;
			ITextChange textChange = base.View.SyntaxEditor.Document.CreateTextChange(TextChangeTypes.AutoComplete, editorViewTextChangeOptions);
			TextRange textRange = Y1t.TranslateTo(textChange.Snapshot, TextRangeTrackingModes.Default).TextRange;
			textChange.ReplaceText(textRange, x1J.Item.AutoCompletePostText ?? string.Empty);
			textChange.InsertText(textRange.FirstOffset, x1J.Item.AutoCompletePreText ?? string.Empty);
			textChange.Apply();
			OnCommitted(EventArgs.Empty);
			Close(cancelled: false);
		}
		finally
		{
			F1M.Nro((v7i)1, _0020: false);
		}
	}

	protected override void OnClosed(CancelEventArgs e)
	{
		if (base.View != null && D1k != null)
		{
			base.View.SyntaxEditor.ElementTransparencyManager.UjX(D1k.Child);
		}
		Y1t = TextSnapshotRange.Deleted;
		int num = 0;
		if (!QLa())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		n1V = null;
		SetSelection(null, scrollToMiddle: false);
		n1b();
		base.OnClosed(e);
	}

	protected virtual void OnCommitted(EventArgs e)
	{
		Q1Z?.Invoke(this, e);
	}

	protected virtual void OnCommitting(CancelEventArgs e)
	{
		j1h?.Invoke(this, e);
	}

	protected virtual void OnDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		TextSnapshotRange y1t = TranslateTrackedSnapshotRange(Y1t, e.NewSnapshot);
		n1V = null;
		if (y1t.IsDeleted || y1t.StartOffset < Y1t.StartOffset)
		{
			Cancel();
			return;
		}
		Y1t = y1t;
		R16(TypedText, _0020: true);
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
	}

	protected override void OnOpened(EventArgs e)
	{
		if (i1U.Count == 0)
		{
			Cancel();
			return;
		}
		if (!a1T())
		{
			Cancel();
			return;
		}
		Y1t = base.SnapshotRange;
		n1V = null;
		if (CanCommitWithoutPopup)
		{
			CompletionSelection completionSelection = R11(Y1t.GetText(LineTerminator.Newline), _0020: true);
			if (completionSelection != null)
			{
				SetSelection(completionSelection, scrollToMiddle: true);
				base.OnOpened(e);
				if (base.View != null && !vAE.E0C(base.View))
				{
					base.View.Focus();
				}
				Commit();
				return;
			}
		}
		Reposition();
		if (D1k == null)
		{
			return;
		}
		R16(TypedText, RequiresFilterOnTextChange || CanFilterUnmatchedItems);
		D1k.IsOpen = true;
		if (base.View != null)
		{
			if (D1k != null)
			{
				base.View.SyntaxEditor.ElementTransparencyManager.ojG(D1k.Child, ControlKeyDownOpacity);
			}
			J12 = base.View.SyntaxEditor.FGR().PLW(Q7Z.tqM(191594), I1m);
			RestartDescriptionTipTimer();
		}
		base.OnOpened(e);
		if (base.View != null && !vAE.E0C(base.View))
		{
			base.View.Focus();
		}
	}

	protected virtual void OnSelectionChanged(EventArgs e)
	{
		i1d?.Invoke(this, e);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected virtual void OnViewKeyDown(IEditorView view, KeyEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		switch (e.Key)
		{
		case Key.Prior:
			if (vAE.A0o() == ModifierKeys.None && J1s != null)
			{
				ICompletionItem completionItem2 = J1s.nQM(_0020: false);
				if (completionItem2 != null)
				{
					SetSelection(new CompletionSelection(completionItem2, CompletionSelectionState.Full), scrollToMiddle: false);
					e.Handled = true;
				}
			}
			break;
		case Key.Next:
			if (vAE.A0o() == ModifierKeys.None && J1s != null)
			{
				ICompletionItem completionItem = J1s.nQM(_0020: true);
				if (completionItem != null)
				{
					SetSelection(new CompletionSelection(completionItem, CompletionSelectionState.Full), scrollToMiddle: false);
					e.Handled = true;
				}
			}
			break;
		case Key.Down:
			if (vAE.A0o() == ModifierKeys.None && J1s != null)
			{
				if (Selection != null && Selection.State == CompletionSelectionState.Partial)
				{
					SetSelection(new CompletionSelection(Selection.Item, CompletionSelectionState.Full), scrollToMiddle: false);
				}
				else
				{
					M1j();
				}
				e.Handled = true;
			}
			break;
		case Key.Return:
		{
			ModifierKeys modifierKeys = vAE.A0o();
			ModifierKeys modifierKeys2 = modifierKeys;
			if (modifierKeys2 != ModifierKeys.None && modifierKeys2 != ModifierKeys.Control)
			{
				break;
			}
			if (Selection != null && Selection.State == CompletionSelectionState.Full)
			{
				Commit();
				if (IsEnterKeyHandledOnCommit)
				{
					e.Handled = true;
				}
			}
			else
			{
				Cancel();
			}
			break;
		}
		case Key.Escape:
			if (vAE.A0o() == ModifierKeys.None)
			{
				Cancel();
				e.Handled = true;
			}
			break;
		case Key.Tab:
			if (vAE.A0o() == ModifierKeys.None)
			{
				Commit();
				e.Handled = true;
			}
			break;
		case Key.Up:
			if (vAE.A0o() == ModifierKeys.None && J1s != null)
			{
				if (Selection != null && Selection.State == CompletionSelectionState.Partial)
				{
					SetSelection(new CompletionSelection(Selection.Item, CompletionSelectionState.Full), scrollToMiddle: false);
				}
				else
				{
					g1w();
				}
				e.Handled = true;
			}
			break;
		}
	}

	protected virtual void OnViewKeyUp(IEditorView view, KeyEventArgs e)
	{
	}

	protected virtual void OnViewPointerPressed(IEditorView view, InputPointerButtonEventArgs e)
	{
		Close(cancelled: true);
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view == base.View && !Y1t.IntersectsWith(view.Selection.EndOffset))
		{
			Cancel();
		}
	}

	protected virtual void OnViewTextInput(IEditorView view, TextCompositionEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		string text = e.Text;
		string text2 = text;
		int num = 0;
		int num3 = default(int);
		while (num < text2.Length)
		{
			char c = text2[num];
			int num2;
			if (!s13(c))
			{
				if (Selection != null)
				{
					num2 = 0;
					if (!QLa())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_00ba;
			}
			num++;
			continue;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (y1R(c))
					{
						Commit();
						return;
					}
					break;
				default:
					if (Selection.State != CompletionSelectionState.Full)
					{
						break;
					}
					goto IL_00a5;
				}
				break;
				IL_00a5:
				num2 = 1;
				if (XLL() == null)
				{
					continue;
				}
				goto IL_0005;
			}
			goto IL_00ba;
			IL_0005:
			num2 = num3;
			goto IL_0009;
			IL_00ba:
			Cancel();
			break;
		}
	}

	public void Open(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor == null || view.CurrentSnapshot == null)
		{
			return;
		}
		ITextBufferReader bufferReader = view.CurrentSnapshot.GetReader(view.Selection.EndOffset).BufferReader;
		if (bufferReader == null)
		{
			return;
		}
		int endOffset = view.Selection.EndOffset;
		int num = endOffset;
		int num2 = endOffset;
		while (!bufferReader.IsAtEnd)
		{
			char c = bufferReader.Read();
			if (c == '\n' || !s13(c))
			{
				break;
			}
			num2++;
		}
		bufferReader.Offset = endOffset;
		while (!bufferReader.IsAtStart)
		{
			char c2 = bufferReader.ReadReverse();
			if (c2 == '\n' || !s13(c2))
			{
				break;
			}
			num--;
		}
		if (num == endOffset)
		{
			num2 = endOffset;
		}
		Open(view, new TextRange(num, num2));
	}

	public void SortItems()
	{
		SortItems(new CompletionItemSortComparer(this));
	}

	public void SortItems(IComparer<ICompletionItem> comparer)
	{
		if (comparer == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(191632));
		}
		ICompletionItem[] array = new ICompletionItem[i1U.Count];
		i1U.CopyTo(array, 0);
		Array.Sort(array, comparer);
		using (i1U.CreateBatch())
		{
			i1U.Clear();
			i1U.AddRange(array);
		}
	}

	protected virtual TextSnapshotRange TranslateTrackedSnapshotRange(TextSnapshotRange snapshotRange, ITextSnapshot targetSnapshot)
	{
		return snapshotRange.TranslateTo(targetSnapshot, TextRangeTrackingModes.ExpandBothEdges);
	}

	private void L1H()
	{
		if (y1q != null)
		{
			double num = x19;
			if (J1s != null && !BrowserInteropHelper.IsBrowserHosted)
			{
				Point point = J1s.PointToScreen(new Point(0.0, 0.0));
				Point point2 = J1s.PointToScreen(new Point(J1s.ActualWidth, J1s.ActualHeight));
				Rect rect = new Rect(point.X, point.Y, point2.X - point.X, point2.Y - point.Y);
				Rect rect2 = eTh.vj5(rect);
				double num2 = Math.Max(Math.Max(0.0, rect.Left - rect2.Left - 3.0), Math.Max(0.0, rect2.Right - rect.Right - 3.0));
				num = Math.Max(100.0, double.IsNaN(num) ? num2 : Math.Min(num, num2));
			}
			y1q.MaxWidth = num;
		}
	}

	private void n1b()
	{
		if (J12 != null)
		{
			J12.Destroy();
		}
		CloseDescriptionTip();
		int num = 0;
		if (XLL() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (D1k != null)
		{
			D1k.Closed -= G1Y;
			D1k.IsOpen = false;
			D1k.PlacementTarget = null;
			D1k = null;
		}
		if (J1s != null)
		{
			J1s.oeK(c14);
			J1s = null;
		}
		if (y1q != null)
		{
			y1q.RequestNavigate -= D1L;
		}
	}

	private bool a1T()
	{
		J1s = CreatePopupContent();
		bool flag = J1s != null;
		int num = 0;
		if (XLL() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		ShadowChrome child = default(ShadowChrome);
		while (true)
		{
			switch (num)
			{
			default:
				if (flag)
				{
					D1k = new Popup();
					D1k.StaysOpen = true;
					if (!BrowserInteropHelper.IsBrowserHosted)
					{
						D1k.AllowsTransparency = true;
						child = tFB(base.View, J1s, _0020: false);
						num = 1;
						if (XLL() == null)
						{
							num = 1;
						}
						continue;
					}
					D1k.Child = J1s;
					break;
				}
				return false;
			case 1:
				D1k.Child = child;
				break;
			}
			break;
		}
		Dv.EFc(D1k, PlacementMode.Bottom);
		D1k.PlacementTarget = base.View.VisualElement;
		y1q.RequestNavigate += D1L;
		J1s.yeX(c14);
		D1k.Closed += G1Y;
		return true;
	}

	private void D1L(object P_0, RequestNavigateEventArgs P_1)
	{
		OnRequestNavigate(P_1);
	}

	protected virtual IntelliPromptCompletionList CreatePopupContent()
	{
		int num = 1;
		IntelliPromptCompletionList intelliPromptCompletionList = default(IntelliPromptCompletionList);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					intelliPromptCompletionList.DataContext = this;
					SyntaxEditor syntaxEditor = base.View.SyntaxEditor;
					double num3 = Math.Max(syntaxEditor.MinIntelliPromptZoomLevel, Math.Min(syntaxEditor.MaxIntelliPromptZoomLevel, syntaxEditor.ZoomLevel));
					intelliPromptCompletionList.LayoutTransform = new ScaleTransform
					{
						ScaleX = num3,
						ScaleY = num3
					};
					if (num3 > 1.0)
					{
						TextOptions.SetTextFormattingMode(intelliPromptCompletionList, TextFormattingMode.Ideal);
					}
					return intelliPromptCompletionList;
				}
				case 1:
					break;
				}
				intelliPromptCompletionList = new IntelliPromptCompletionList(this);
				num2 = 0;
			}
			while (XLL() == null);
		}
	}

	protected virtual void OnRequestNavigate(RequestNavigateEventArgs e)
	{
		jFP?.Invoke(this, e);
	}

	public override void Reposition()
	{
		if (D1k == null)
		{
			return;
		}
		Rect rect = PlacementRectangle ?? OF0(_0020: false);
		if (!rect.IsEmpty)
		{
			int num2 = default(int);
			while (true)
			{
				IIntelliPromptSession intelliPromptSession = base.View.SyntaxEditor.IntelliPrompt.Sessions[IntelliPromptSessionTypes.ParameterInfo];
				if (intelliPromptSession != null)
				{
					Rect? bounds = intelliPromptSession.Bounds;
					if (bounds.HasValue && !bounds.Value.IsEmpty)
					{
						rect.Y = Math.Min(rect.Top, bounds.Value.Top);
						rect.Height = Math.Max(rect.Bottom, bounds.Value.Bottom) - rect.Y + 2.0;
					}
				}
				int num;
				if (J1s != null)
				{
					num = 1;
					if (XLL() != null)
					{
						num = num2;
					}
					goto IL_0009;
				}
				goto IL_0021;
				IL_0009:
				switch (num)
				{
				case 2:
					continue;
				case 1:
					goto IL_0091;
				}
				D1k.HorizontalOffset++;
				D1k.HorizontalOffset--;
				return;
				IL_0091:
				SyntaxEditor syntaxEditor = base.View.SyntaxEditor;
				double num3 = Math.Max(syntaxEditor.MinIntelliPromptZoomLevel, Math.Min(syntaxEditor.MaxIntelliPromptZoomLevel, syntaxEditor.ZoomLevel));
				rect.X += J1s.HorizontalOffset * num3;
				goto IL_0021;
				IL_0021:
				if (!hFr(D1k, rect))
				{
					num = 0;
					if (!QLa())
					{
						num = 0;
					}
					goto IL_0009;
				}
				break;
			}
		}
		else
		{
			Cancel();
		}
	}

	internal static bool QLa()
	{
		return vLx == null;
	}

	internal static CompletionSession XLL()
	{
		return vLx;
	}
}
