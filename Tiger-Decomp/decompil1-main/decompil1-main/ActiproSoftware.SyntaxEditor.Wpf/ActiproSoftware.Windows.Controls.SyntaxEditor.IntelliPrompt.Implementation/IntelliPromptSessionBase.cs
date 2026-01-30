using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Themes;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public abstract class IntelliPromptSessionBase : IIntelliPromptSession, IServiceLocator
{
	private object fF9;

	private Dictionary<object, object> SFy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CancelEventArgs> sFq;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler FF2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CollectionChangeEventArgs<object>> AF7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<CollectionChangeEventArgs<object>> eFi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool BFp;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange LFM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEditorView YFO;

	internal static IntelliPromptSessionBase yLV;

	public abstract Rect? Bounds { get; }

	protected virtual bool CanOpenForReadOnlyTextRanges => true;

	public abstract bool ClosesOnLostFocus { get; }

	public bool IsOpen
	{
		[CompilerGenerated]
		get
		{
			return BFp;
		}
		[CompilerGenerated]
		private set
		{
			BFp = value;
		}
	}

	public abstract IIntelliPromptSessionType SessionType { get; }

	public TextSnapshotRange SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return LFM;
		}
		[CompilerGenerated]
		private set
		{
			LFM = value;
		}
	}

	public object SyncRoot => fF9;

	public IEditorView View
	{
		[CompilerGenerated]
		get
		{
			return YFO;
		}
		[CompilerGenerated]
		private set
		{
			YFO = value;
		}
	}

	public event EventHandler<CancelEventArgs> Closed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CancelEventArgs> eventHandler = sFq;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sFq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CancelEventArgs> eventHandler = sFq;
			EventHandler<CancelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CancelEventArgs> value2 = (EventHandler<CancelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sFq, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler Opened
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = FF2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref FF2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = FF2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref FF2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<object>> ServiceAdded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = AF7;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AF7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = AF7;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref AF7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<object>> ServiceRemoved
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = eFi;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eFi, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = eFi;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eFi, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected IntelliPromptSessionBase()
	{
		grA.DaB7cz();
		fF9 = new object();
		SFy = new Dictionary<object, object>();
		base._002Ector();
		SnapshotRange = TextSnapshotRange.Deleted;
	}

	internal Rect OF0(bool P_0)
	{
		Rect result = Rect.Empty;
		if (IsOpen)
		{
			TextSnapshotRange textSnapshotRange = SnapshotRange.TranslateTo(View.CurrentSnapshot, TextRangeTrackingModes.ExpandLastEdge);
			ITextViewLine viewLine = View.GetViewLine(textSnapshotRange.StartOffset);
			int offset = Math.Max(textSnapshotRange.StartOffset, textSnapshotRange.EndOffset - 1);
			ITextViewLine viewLine2 = View.GetViewLine(offset);
			if (viewLine.Visibility != TextViewLineVisibility.Hidden)
			{
				if (viewLine2.Visibility != TextViewLineVisibility.Hidden)
				{
					Rect rect = View.TransformFromTextArea(viewLine.GetCharacterBounds(textSnapshotRange.StartOffset).Rect);
					Rect rect2 = View.TransformFromTextArea(viewLine2.GetCharacterBounds(offset).Rect);
					result = new Rect(rect.Left, rect.Top, Math.Max(0.0, rect2.Right - rect.Left), Math.Max(0.0, rect2.Bottom - rect.Top));
				}
				else
				{
					result = View.TransformFromTextArea(viewLine.GetCharacterBounds(textSnapshotRange.StartOffset).Rect);
				}
			}
			else if (viewLine2.Visibility != TextViewLineVisibility.Hidden)
			{
				result = View.TransformFromTextArea(viewLine2.GetCharacterBounds(offset).Rect);
			}
			if (P_0 && !result.IsEmpty)
			{
				ITextViewLine currentViewLine = View.CurrentViewLine;
				if (currentViewLine.Visibility != TextViewLineVisibility.Hidden)
				{
					Rect rect3 = View.TransformFromTextArea(currentViewLine.GetCharacterBounds(View.Selection.EndOffset).Rect);
					result = new Rect(result.Left, rect3.Top, result.Width, rect3.Height);
				}
			}
		}
		return result;
	}

	public IEnumerable<object> GetAllServiceTypes()
	{
		lock (fF9)
		{
			foreach (object key in SFy.Keys)
			{
				yield return key;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public T GetService<T>()
	{
		return (T)GetService(typeof(T));
	}

	public object GetService(object serviceType)
	{
		lock (fF9)
		{
			if (SFy.TryGetValue(serviceType, out var value))
			{
				return value;
			}
			return null;
		}
	}

	public void RegisterService<T>(T service)
	{
		RegisterService(typeof(T), service);
	}

	public void RegisterService(object serviceType, object service)
	{
		if (serviceType == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192566));
		}
		if (service == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192592));
		}
		lock (fF9)
		{
			UnregisterService(serviceType);
			SFy.Add(serviceType, service);
		}
		OnServiceAdded(new CollectionChangeEventArgs<object>(-1, service));
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public void UnregisterService<T>()
	{
		UnregisterService(typeof(T));
	}

	public void UnregisterService(object serviceType)
	{
		object obj = null;
		lock (fF9)
		{
			if (SFy.ContainsKey(serviceType))
			{
				obj = GetService(serviceType);
				SFy.Remove(serviceType);
			}
		}
		if (obj != null)
		{
			OnServiceRemoved(new CollectionChangeEventArgs<object>(-1, obj));
		}
	}

	public void Close(bool cancelled)
	{
		if (!IsOpen)
		{
			return;
		}
		int num2;
		if (View.SyntaxEditor != null && View.SyntaxEditor.IntelliPrompt != null && View.SyntaxEditor.IntelliPrompt.Sessions != null)
		{
			int num = View.SyntaxEditor.IntelliPrompt.Sessions.IndexOf(this);
			if (num != -1)
			{
				View.SyntaxEditor.IntelliPrompt.Sessions.Remove(this);
				num2 = 0;
				if (JLc() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_0009;
			}
		}
		goto IL_00f0;
		IL_0009:
		switch (num2)
		{
		case 1:
			SnapshotRange = TextSnapshotRange.Deleted;
			View = null;
			return;
		}
		goto IL_00f0;
		IL_00f0:
		IsOpen = false;
		OnClosed(new CancelEventArgs(cancelled));
		if (!IsOpen)
		{
			num2 = 1;
			if (!SLI())
			{
				num2 = 0;
			}
			goto IL_0009;
		}
	}

	protected virtual void OnClosed(CancelEventArgs e)
	{
		sFq?.Invoke(this, e);
	}

	protected virtual void OnOpened(EventArgs e)
	{
		FF2?.Invoke(this, e);
	}

	protected virtual void OnServiceAdded(CollectionChangeEventArgs<object> e)
	{
		AF7?.Invoke(this, e);
	}

	protected virtual void OnServiceRemoved(CollectionChangeEventArgs<object> e)
	{
		eFi?.Invoke(this, e);
	}

	public void Open(IEditorView view, TextRange textRange)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (IsOpen)
		{
			throw new InvalidOperationException(SR.GetString(SRName.ExSessionAlreadyOpen));
		}
		if (CanOpenForReadOnlyTextRanges || !view.SyntaxEditor.Document.IsTextRangeReadOnly(textRange))
		{
			SnapshotRange = new TextSnapshotRange(view.CurrentSnapshot, textRange);
			View = view;
			IsOpen = true;
			if (view.SyntaxEditor != null && view.SyntaxEditor.IntelliPrompt != null && view.SyntaxEditor.IntelliPrompt.Sessions != null)
			{
				view.SyntaxEditor.IntelliPrompt.Sessions.Add(this);
			}
			OnOpened(EventArgs.Empty);
		}
	}

	public abstract void Reposition();

	internal ShadowChrome tFB(IEditorView P_0, UIElement P_1, bool P_2)
	{
		ShadowChrome shadowChrome = new ShadowChrome();
		shadowChrome.Child = P_1;
		if (P_0 != null)
		{
			if (P_0.VisualElement.TryFindResource(AssetResourceKeys.PopupShadowDirectionDoubleKey) is double direction)
			{
				shadowChrome.Direction = direction;
			}
			if (P_0.VisualElement.TryFindResource(AssetResourceKeys.ShadowOpacityNormalDoubleKey) is double shadowOpacity)
			{
				shadowChrome.ShadowOpacity = shadowOpacity;
			}
			if (P_0.VisualElement.TryFindResource(P_2 ? AssetResourceKeys.ToolTipShadowElevationInt32Key : AssetResourceKeys.PopupShadowElevationInt32Key) is int elevation)
			{
				shadowChrome.Elevation = elevation;
			}
		}
		shadowChrome.Margin = shadowChrome.ShadowThickness;
		return shadowChrome;
	}

	internal void OFV(Popup P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		try
		{
			SyntaxEditor syntaxEditor = View.SyntaxEditor;
			Point point = syntaxEditor.PointToScreen(new Point(0.0, 0.0));
			Point point2 = syntaxEditor.PointToScreen(new Point(syntaxEditor.ActualWidth, syntaxEditor.ActualHeight));
			Rect rect = new Rect(point.X, point.Y, point2.X - point.X, point2.Y - point.Y);
			P_0.MaxHeight = Math.Max(250.0, eTh.vj5(rect).Height / 2.0 - 2.0 * View.DefaultLineHeight);
		}
		catch
		{
		}
	}

	internal bool hFr(Popup P_0, Rect P_1)
	{
		Thickness thickness = default(Thickness);
		if (P_0 != null && P_0.Child is ShadowChrome shadowChrome)
		{
			thickness = shadowChrome.Margin;
		}
		if (thickness.Left > 0.0)
		{
			P_1.X -= thickness.Left;
			P_1.Width += thickness.Left;
		}
		if (thickness.Right > 0.0)
		{
			P_1.Width += thickness.Right;
		}
		if (P_0.PlacementRectangle != P_1)
		{
			P_0.PlacementRectangle = P_1;
			return true;
		}
		return false;
	}

	protected Rect? GetPopupBounds(Popup popup)
	{
		if (popup != null && popup.IsOpen && popup.Child != null && View != null)
		{
			FrameworkElement frameworkElement = popup.Child as FrameworkElement;
			FrameworkElement visualElement = View.VisualElement;
			if (frameworkElement != null && PresentationSource.FromVisual(frameworkElement) != null && visualElement != null)
			{
				popup.UpdateLayout();
				if (SecurityHelper.IsFullTrust)
				{
					Rect rect = new Rect(frameworkElement.PointToScreen(new Point(0.0, 0.0)), frameworkElement.PointToScreen(new Point(frameworkElement.ActualWidth, frameworkElement.ActualHeight)));
					return new Rect(visualElement.PointFromScreen(rect.TopLeft), visualElement.PointFromScreen(rect.BottomRight));
				}
				if (popup.PlacementTarget == View.VisualElement)
				{
					PlacementMode placement = popup.Placement;
					PlacementMode placementMode = placement;
					if (placementMode == PlacementMode.Bottom)
					{
						return new Rect(popup.PlacementRectangle.Left + popup.HorizontalOffset, popup.PlacementRectangle.Bottom + popup.VerticalOffset, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
					}
				}
			}
		}
		return null;
	}

	internal static bool SLI()
	{
		return yLV == null;
	}

	internal static IntelliPromptSessionBase JLc()
	{
		return yLV;
	}
}
