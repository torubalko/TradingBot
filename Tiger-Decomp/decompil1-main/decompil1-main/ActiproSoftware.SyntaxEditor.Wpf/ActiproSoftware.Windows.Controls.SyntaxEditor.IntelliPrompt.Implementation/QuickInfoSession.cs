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
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class QuickInfoSession : IntelliPromptSessionBase, IEditorDocumentTextChangeEventSink, IEditorViewKeyInputEventSink, IEditorViewSelectionChangeEventSink, INotifyPropertyChanged, IQuickInfoSession, IIntelliPromptSession, IServiceLocator
{
	private object content;

	private object P3t;

	private double c3Z;

	private double m3h;

	private PlacementMode Y3N;

	private UIElement F3d;

	private Rect V3z;

	private IntelliPromptQuickInfo ARW;

	private Popup JRP;

	private TextSnapshotRange ERE;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private RequestNavigateEventHandler rRc;

	private static QuickInfoSession Fgn;

	public override Rect? Bounds => (JRP != null) ? GetPopupBounds(JRP) : ((Rect?)null);

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

	public object Context
	{
		get
		{
			return P3t;
		}
		set
		{
			if (P3t != value)
			{
				P3t = value;
				NotifyPropertyChanged(Q7Z.tqM(192690));
			}
		}
	}

	public double ControlKeyDownOpacity
	{
		get
		{
			return c3Z;
		}
		set
		{
			value = Math.Max(0.0, Math.Min(1.0, value));
			if (c3Z != value)
			{
				c3Z = value;
				NotifyPropertyChanged(Q7Z.tqM(9592));
			}
		}
	}

	public double MaxWidth
	{
		get
		{
			return m3h;
		}
		set
		{
			if (!double.IsInfinity(value))
			{
				m3h = value;
			}
			else
			{
				m3h = double.NaN;
			}
			if (ARW == null)
			{
				return;
			}
			int num = 0;
			if (!ygq())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!double.IsNaN(m3h))
			{
				ARW.MaxWidth = m3h;
			}
			else
			{
				ARW.ClearValue(FrameworkElement.MaxWidthProperty);
			}
		}
	}

	public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.QuickInfo;

	public event PropertyChangedEventHandler PropertyChanged;

	public event RequestNavigateEventHandler RequestNavigate
	{
		[CompilerGenerated]
		add
		{
			RequestNavigateEventHandler requestNavigateEventHandler = rRc;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Combine(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref rRc, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RequestNavigateEventHandler requestNavigateEventHandler = rRc;
			RequestNavigateEventHandler requestNavigateEventHandler2;
			do
			{
				requestNavigateEventHandler2 = requestNavigateEventHandler;
				RequestNavigateEventHandler value2 = (RequestNavigateEventHandler)Delegate.Remove(requestNavigateEventHandler2, value);
				requestNavigateEventHandler = Interlocked.CompareExchange(ref rRc, value2, requestNavigateEventHandler2);
			}
			while ((object)requestNavigateEventHandler != requestNavigateEventHandler2);
		}
	}

	public QuickInfoSession()
	{
		grA.DaB7cz();
		c3Z = 0.25;
		m3h = 1000.0;
		Y3N = PlacementMode.Bottom;
		V3z = Rect.Empty;
		base._002Ector();
		RegisterService((IEditorDocumentTextChangeEventSink)this);
		RegisterService((IEditorViewKeyInputEventSink)this);
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		RegisterService((IEditorViewSelectionChangeEventSink)this);
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

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		OnViewSelectionChanged(view, e);
	}

	private void p3M(object P_0, object P_1)
	{
		if (base.IsOpen)
		{
			Close(cancelled: true);
		}
	}

	protected void NotifyPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	protected override void OnClosed(CancelEventArgs e)
	{
		if (base.View != null && JRP != null)
		{
			base.View.SyntaxEditor.ElementTransparencyManager.UjX(JRP.Child);
		}
		ERE = TextSnapshotRange.Deleted;
		V3O();
		base.OnClosed(e);
		if (!base.IsOpen)
		{
			Y3N = PlacementMode.Bottom;
			F3d = null;
			V3z = Rect.Empty;
		}
	}

	protected virtual void OnDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		bool flag = !ERE.IsDeleted;
		int num = 0;
		if (!ygq())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			ERE = ERE.TranslateTo(e.NewSnapshot, TextRangeTrackingModes.ExpandBothEdges);
			if (ERE.IsDeleted)
			{
				Close(cancelled: true);
			}
		}
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
	}

	protected override void OnOpened(EventArgs e)
	{
		if (Content == null)
		{
			Close(cancelled: true);
			return;
		}
		if (!g3U())
		{
			Close(cancelled: true);
			return;
		}
		ERE = base.SnapshotRange;
		Reposition();
		if (JRP != null)
		{
			JRP.IsOpen = true;
			if (base.View != null && JRP != null)
			{
				base.View.SyntaxEditor.ElementTransparencyManager.ojG(JRP.Child, ControlKeyDownOpacity);
			}
			base.OnOpened(e);
		}
	}

	protected virtual void OnViewKeyDown(IEditorView view, KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		Key key = e.Key;
		Key key2 = key;
		if (key2 == Key.Escape && vAE.A0o() == ModifierKeys.None)
		{
			Close(cancelled: true);
			e.Handled = true;
		}
	}

	protected virtual void OnViewKeyUp(IEditorView view, KeyEventArgs e)
	{
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view == base.View && !ERE.IsDeleted && !ERE.IntersectsWith(view.Selection.EndOffset))
		{
			Close(cancelled: true);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "placement")]
	[SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "placementRectangle")]
	[SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "placementTarget")]
	public void Open(IEditorView view, PlacementMode placement, UIElement placementTarget, Rect placementRectangle)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		Y3N = placement;
		V3z = placementRectangle;
		F3d = placementTarget;
		Open(view, ActiproSoftware.Text.TextRange.Deleted);
	}

	private void V3O()
	{
		if (JRP != null)
		{
			JRP.Closed -= p3M;
			JRP.IsOpen = false;
			JRP.PlacementTarget = null;
			JRP = null;
		}
		if (ARW != null)
		{
			ARW.RemoveHandler(Hyperlink.RequestNavigateEvent, new RequestNavigateEventHandler(F3J));
			ARW = null;
		}
	}

	private bool g3U()
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
				case 1:
					break;
				default:
					if (ARW != null)
					{
						JRP = new Popup();
						JRP.StaysOpen = true;
						if (!BrowserInteropHelper.IsBrowserHosted)
						{
							JRP.AllowsTransparency = true;
							OFV(JRP);
							ShadowChrome child = tFB(base.View, ARW, _0020: true);
							JRP.Child = child;
							num2 = 2;
							if (!ygq())
							{
								num2 = 0;
							}
							goto IL_0012;
						}
						JRP.Child = ARW;
						goto case 2;
					}
					return false;
				case 2:
					Dv.EFc(JRP, Y3N);
					JRP.PlacementTarget = F3d ?? base.View.VisualElement;
					ARW.AddHandler(Hyperlink.RequestNavigateEvent, new RequestNavigateEventHandler(F3J));
					JRP.Closed += p3M;
					return true;
				}
				ARW = CreatePopupContent();
				num2 = 0;
			}
			while (Wgx() == null);
		}
	}

	private void F3J(object P_0, RequestNavigateEventArgs P_1)
	{
		OnRequestNavigate(P_1);
	}

	protected virtual IntelliPromptQuickInfo CreatePopupContent()
	{
		IntelliPromptQuickInfo intelliPromptQuickInfo = new IntelliPromptQuickInfo(this);
		intelliPromptQuickInfo.DataContext = this;
		SyntaxEditor syntaxEditor = base.View.SyntaxEditor;
		double num = Math.Max(syntaxEditor.MinIntelliPromptZoomLevel, Math.Min(syntaxEditor.MaxIntelliPromptZoomLevel, syntaxEditor.ZoomLevel));
		intelliPromptQuickInfo.LayoutTransform = new ScaleTransform
		{
			ScaleX = num,
			ScaleY = num
		};
		if (num > 1.0)
		{
			TextOptions.SetTextFormattingMode(intelliPromptQuickInfo, TextFormattingMode.Ideal);
		}
		double num2 = Math.Max(100.0, m3h);
		num2 /= Math.Max(1.0, num);
		if (double.IsNaN(num2))
		{
			intelliPromptQuickInfo.ClearValue(FrameworkElement.MaxWidthProperty);
		}
		else
		{
			intelliPromptQuickInfo.MaxWidth = num2;
		}
		if (syntaxEditor.BorderBrush is SolidColorBrush { Color: { A: >0 } } solidColorBrush)
		{
			intelliPromptQuickInfo.BorderBrush = solidColorBrush;
		}
		Color defaultBackgroundColor = base.View.DefaultBackgroundColor;
		if (defaultBackgroundColor.A > 0)
		{
			intelliPromptQuickInfo.Background = vAE.F0K(defaultBackgroundColor);
		}
		intelliPromptQuickInfo.Foreground = vAE.F0K(base.View.DefaultForegroundColor);
		return intelliPromptQuickInfo;
	}

	protected virtual void OnRequestNavigate(RequestNavigateEventArgs e)
	{
		rRc?.Invoke(this, e);
	}

	public override void Reposition()
	{
		if (JRP == null)
		{
			return;
		}
		if (F3d != null)
		{
			if (!hFr(JRP, V3z))
			{
				JRP.HorizontalOffset++;
				JRP.HorizontalOffset--;
			}
			return;
		}
		Rect rect = OF0(_0020: false);
		int num = 1;
		if (Wgx() == null)
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (rect.IsEmpty)
				{
					Close(cancelled: true);
					return;
				}
				rect.Offset(0.0, -1.0);
				rect.Height += 2.0;
				if (!hFr(JRP, rect))
				{
					JRP.HorizontalOffset++;
					JRP.HorizontalOffset--;
					num = 0;
					if (!ygq())
					{
						num = num2;
					}
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	internal static bool ygq()
	{
		return Fgn == null;
	}

	internal static QuickInfoSession Wgx()
	{
		return Fgn;
	}
}
