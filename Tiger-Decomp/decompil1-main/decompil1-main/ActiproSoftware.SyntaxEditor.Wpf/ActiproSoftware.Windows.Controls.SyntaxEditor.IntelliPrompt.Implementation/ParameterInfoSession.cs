using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Navigation;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class ParameterInfoSession : IntelliPromptSessionBase, INotifyPropertyChanged, IParameterInfoSession, IIntelliPromptSession, IServiceLocator, IEditorViewKeyInputEventSink, IEditorViewPointerInputEventSink, IEditorViewSelectionChangeEventSink
{
	private int? p33;

	private object content;

	private double s3R;

	private bool O3Y;

	private bool H34;

	private hB N3o;

	private double V3j;

	private IntelliPromptParameterInfo v3w;

	private Popup e36;

	private PlacementMode V3H;

	private UIElement G3b;

	private Rect c3T;

	private ISignatureItem J3L;

	private DelegateCommand<object> z3n;

	private DelegateCommand<object> O38;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler B3I;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RequestNavigateEventHandler w35;

	private static ParameterInfoSession PLe;

	public override Rect? Bounds => (e36 != null) ? GetPopupBounds(e36) : ((Rect?)null);

	public override bool ClosesOnLostFocus => true;

	public object Content
	{
		get
		{
			return content;
		}
		set
		{
			if (content != value)
			{
				content = value;
				NotifyPropertyChanged(Q7Z.tqM(192628));
			}
		}
	}

	public double ControlKeyDownOpacity
	{
		get
		{
			return s3R;
		}
		set
		{
			value = Math.Max(0.0, Math.Min(1.0, value));
			if (s3R != value)
			{
				s3R = value;
				NotifyPropertyChanged(Q7Z.tqM(9592));
			}
		}
	}

	public int DisplaySelectedIndex => N3o.IndexOf(J3L) + 1;

	public bool HasSelectionChanged => O3Y;

	public bool IsArrowKeySelectionEnabled
	{
		get
		{
			return H34;
		}
		set
		{
			H34 = value;
		}
	}

	public ISignatureItemCollection Items => N3o;

	public double MaxWidth
	{
		get
		{
			return V3j;
		}
		set
		{
			if (!double.IsInfinity(value))
			{
				V3j = value;
			}
			else
			{
				V3j = double.NaN;
			}
			if (v3w == null)
			{
				return;
			}
			if (double.IsNaN(V3j))
			{
				v3w.ClearValue(FrameworkElement.MaxWidthProperty);
				int num = 0;
				if (!mLz())
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
			else
			{
				v3w.MaxWidth = V3j;
			}
		}
	}

	public ISignatureItem Selection
	{
		get
		{
			return J3L;
		}
		set
		{
			if (J3L != value)
			{
				J3L = value;
				O3Y = true;
				Refresh();
				NotifyPropertyChanged(Q7Z.tqM(192646));
				OnSelectionChanged(EventArgs.Empty);
			}
		}
	}

	public ICommand SelectNextCommand => z3n;

	public ICommand SelectPreviousCommand => O38;

	public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.ParameterInfo;

	public event PropertyChangedEventHandler PropertyChanged;

	public event EventHandler SelectionChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = B3I;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref B3I, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = B3I;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref B3I, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event RequestNavigateEventHandler RequestNavigate
	{
		[CompilerGenerated]
		add
		{
			RequestNavigateEventHandler requestNavigateEventHandler = w35;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Combine(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref w35, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestNavigateEventHandler requestNavigateEventHandler = w35;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Remove(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref w35, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
	}

	public ParameterInfoSession()
	{
		grA.DaB7cz();
		s3R = 0.25;
		H34 = true;
		N3o = new hB();
		V3j = 1000.0;
		V3H = PlacementMode.Bottom;
		c3T = Rect.Empty;
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		G3l();
		RegisterService((IEditorViewKeyInputEventSink)this);
		RegisterService((IEditorViewPointerInputEventSink)this);
		RegisterService((IEditorViewSelectionChangeEventSink)this);
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

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		OnViewSelectionChanged(view, e);
	}

	private void G3l()
	{
		z3n = new DelegateCommand<object>(delegate
		{
			SelectNext();
		});
		O38 = new DelegateCommand<object>(delegate
		{
			SelectPrevious();
		});
	}

	private void a3A(object P_0, object P_1)
	{
		if (base.IsOpen)
		{
			Close(cancelled: true);
		}
	}

	private void i3v()
	{
		object obj = null;
		if (J3L != null && J3L.ContentProvider != null)
		{
			obj = J3L.ContentProvider.GetContent();
		}
		Content = obj;
		if (v3w != null)
		{
			v3w.InvalidateMeasure();
		}
	}

	protected void NotifyPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	protected override void OnClosed(CancelEventArgs e)
	{
		if (base.View != null && e36 != null)
		{
			base.View.SyntaxEditor.ElementTransparencyManager.UjX(e36.Child);
		}
		l3m();
		base.OnClosed(e);
		if (!base.IsOpen)
		{
			V3H = PlacementMode.Bottom;
			G3b = null;
			c3T = Rect.Empty;
		}
	}

	protected override void OnOpened(EventArgs e)
	{
		if (J3L == null || !N3o.Contains(J3L))
		{
			SelectNext();
		}
		O3Y = false;
		if (Content == null)
		{
			Close(cancelled: true);
			return;
		}
		if (!U3C())
		{
			Close(cancelled: true);
			return;
		}
		base.View.SyntaxEditor.IntelliPrompt.CloseSessions(IntelliPromptSessionTypes.QuickInfo);
		Reposition();
		if (e36 != null)
		{
			e36.IsOpen = true;
			if (base.View != null && e36 != null)
			{
				base.View.SyntaxEditor.ElementTransparencyManager.ojG(e36.Child, ControlKeyDownOpacity);
			}
			base.OnOpened(e);
		}
	}

	protected virtual void OnSelectionChanged(EventArgs e)
	{
		B3I?.Invoke(this, e);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected virtual void OnViewKeyDown(IEditorView view, KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		switch (e.Key)
		{
		case Key.Down:
			if (IsArrowKeySelectionEnabled && vAE.A0o() == ModifierKeys.None && (N3o.Count != 1 || J3L == null))
			{
				SelectNext();
				e.Handled = true;
			}
			break;
		case Key.Escape:
			if (vAE.A0o() == ModifierKeys.None)
			{
				Close(cancelled: true);
				e.Handled = true;
			}
			break;
		case Key.Up:
			if (IsArrowKeySelectionEnabled && vAE.A0o() == ModifierKeys.None && (N3o.Count != 1 || J3L == null))
			{
				SelectPrevious();
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
		if (e != null && !e.Handled)
		{
			Close(cancelled: true);
		}
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view != base.View || !base.IsOpen)
		{
			return;
		}
		int startOffset = view.CurrentViewLine.StartOffset;
		if (p33 != startOffset)
		{
			p33 = startOffset;
			int num = 0;
			if (Tgm() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			view.SyntaxEditor.IntelliPrompt.RepositionAll();
		}
	}

	public void Refresh()
	{
		i3v();
		if (base.IsOpen)
		{
			if (base.View == null)
			{
				Reposition();
			}
			else
			{
				base.View.SyntaxEditor.IntelliPrompt.RepositionAll();
			}
		}
	}

	public void SelectNext()
	{
		if (N3o.Count == 0)
		{
			return;
		}
		if (J3L != null)
		{
			int num = N3o.IndexOf(J3L);
			if (num >= 0 && num < N3o.Count - 1)
			{
				Selection = N3o[num + 1];
				return;
			}
		}
		Selection = N3o[0];
	}

	public void SelectPrevious()
	{
		if (N3o.Count == 0)
		{
			return;
		}
		if (J3L != null)
		{
			int num = N3o.IndexOf(J3L);
			if (num > 0 && num < N3o.Count)
			{
				Selection = N3o[num - 1];
				return;
			}
		}
		Selection = N3o[N3o.Count - 1];
	}

	private void l3m()
	{
		if (e36 != null)
		{
			e36.Closed -= a3A;
			e36.IsOpen = false;
			e36.PlacementTarget = null;
			e36 = null;
		}
		if (v3w != null)
		{
			v3w.RemoveHandler(Hyperlink.RequestNavigateEvent, new RequestNavigateEventHandler(b3u));
			v3w = null;
			int num = 0;
			if (!mLz())
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

	private bool U3C()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					e36.Closed += a3A;
					return true;
				default:
					if (v3w != null)
					{
						e36 = new Popup();
						e36.StaysOpen = true;
						if (!BrowserInteropHelper.IsBrowserHosted)
						{
							e36.AllowsTransparency = true;
							OFV(e36);
							ShadowChrome child = tFB(base.View, v3w, _0020: true);
							e36.Child = child;
						}
						else
						{
							e36.Child = v3w;
						}
						Dv.EFc(e36, V3H);
						e36.PlacementTarget = G3b ?? base.View.VisualElement;
						v3w.AddHandler(Hyperlink.RequestNavigateEvent, new RequestNavigateEventHandler(b3u));
						num2 = 2;
						if (Tgm() != null)
						{
							num2 = 0;
						}
						goto IL_0012;
					}
					return false;
				case 1:
					break;
				}
				v3w = CreatePopupContent();
				num2 = 0;
			}
			while (Tgm() == null);
		}
	}

	private void b3u(object P_0, RequestNavigateEventArgs P_1)
	{
		OnRequestNavigate(P_1);
	}

	protected virtual IntelliPromptParameterInfo CreatePopupContent()
	{
		IntelliPromptParameterInfo intelliPromptParameterInfo = new IntelliPromptParameterInfo(this);
		intelliPromptParameterInfo.DataContext = this;
		SyntaxEditor syntaxEditor = base.View.SyntaxEditor;
		double num = Math.Max(syntaxEditor.MinIntelliPromptZoomLevel, Math.Min(syntaxEditor.MaxIntelliPromptZoomLevel, syntaxEditor.ZoomLevel));
		intelliPromptParameterInfo.LayoutTransform = new ScaleTransform
		{
			ScaleX = num,
			ScaleY = num
		};
		if (num > 1.0)
		{
			TextOptions.SetTextFormattingMode(intelliPromptParameterInfo, TextFormattingMode.Ideal);
		}
		double num2 = Math.Max(100.0, V3j);
		num2 /= Math.Max(1.0, num);
		if (double.IsNaN(num2))
		{
			intelliPromptParameterInfo.ClearValue(FrameworkElement.MaxWidthProperty);
		}
		else
		{
			intelliPromptParameterInfo.MaxWidth = num2;
		}
		if (syntaxEditor.BorderBrush is SolidColorBrush { Color: { A: >0 } } solidColorBrush)
		{
			intelliPromptParameterInfo.BorderBrush = solidColorBrush;
		}
		Color defaultBackgroundColor = base.View.DefaultBackgroundColor;
		if (defaultBackgroundColor.A > 0)
		{
			intelliPromptParameterInfo.Background = vAE.F0K(defaultBackgroundColor);
		}
		intelliPromptParameterInfo.Foreground = vAE.F0K(base.View.DefaultForegroundColor);
		return intelliPromptParameterInfo;
	}

	protected virtual void OnRequestNavigate(RequestNavigateEventArgs e)
	{
		w35?.Invoke(this, e);
	}

	public override void Reposition()
	{
		if (base.View != null)
		{
			p33 = base.View.CurrentViewLine.StartOffset;
		}
		if (e36 == null)
		{
			return;
		}
		if (G3b != null)
		{
			if (hFr(e36, c3T))
			{
				return;
			}
		}
		else
		{
			Rect rect = OF0(_0020: false);
			bool isEmpty = rect.IsEmpty;
			int num = 0;
			if (!mLz())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				if (isEmpty)
				{
					Close(cancelled: true);
					return;
				}
				rect.Offset(0.0, -1.0);
				rect.Height += 2.0;
				if (!hFr(e36, rect))
				{
					e36.HorizontalOffset++;
					e36.HorizontalOffset--;
				}
				return;
			}
		}
		e36.HorizontalOffset++;
		e36.HorizontalOffset--;
	}

	[CompilerGenerated]
	private void S31(object P_0)
	{
		SelectNext();
	}

	[CompilerGenerated]
	private void K3F(object P_0)
	{
		SelectPrevious();
	}

	internal static bool mLz()
	{
		return PLe == null;
	}

	internal static ParameterInfoSession Tgm()
	{
		return PLe;
	}
}
