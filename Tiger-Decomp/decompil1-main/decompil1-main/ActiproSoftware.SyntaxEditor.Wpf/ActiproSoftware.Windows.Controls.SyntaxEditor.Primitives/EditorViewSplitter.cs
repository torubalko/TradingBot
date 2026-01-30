using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorViewSplitter : Control
{
	private InputAdapter QQC;

	private DateTime xQu;

	private Point wQ1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerEventArgs> dQF;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerEventArgs> FQ3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerEventArgs> VQR;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler BQY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool fQ4;

	internal static EditorViewSplitter EBG;

	public bool IsDragging
	{
		[CompilerGenerated]
		get
		{
			return fQ4;
		}
		[CompilerGenerated]
		private set
		{
			fQ4 = value;
		}
	}

	public event EventHandler<InputPointerEventArgs> DragCompleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = dQF;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref dQF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = dQF;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref dQF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> DragDelta
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = FQ3;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref FQ3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = FQ3;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref FQ3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> DragStarted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = VQR;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref VQR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = VQR;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref VQR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler Toggled
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = BQY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BQY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = BQY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BQY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public EditorViewSplitter()
	{
		grA.DaB7cz();
		xQu = DateTime.Today;
		base._002Ector();
		base.DefaultStyleKey = typeof(EditorViewSplitter);
		EQG();
	}

	private void EQG()
	{
		QQC = new InputAdapter(this);
		QQC.PointerCaptureLost += AQf;
		QQC.PointerMoved += DQD;
		QQC.PointerPressed += FQg;
		QQC.PointerReleased += UQQ;
		QQC.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	private void yQX(InputPointerEventArgs P_0)
	{
		if (IsDragging)
		{
			IsDragging = false;
			mQe(P_0);
		}
	}

	private Point NQK(InputPointerEventArgs P_0)
	{
		EditorViewHost ancestor = VisualTreeHelperExtended.GetAncestor<EditorViewHost>(this);
		if (ancestor == null)
		{
			return P_0.GetPosition(this);
		}
		return P_0.GetPosition(ancestor);
	}

	private void AQf(object P_0, InputPointerEventArgs P_1)
	{
		yQX(P_1);
	}

	private void DQD(object P_0, InputPointerEventArgs P_1)
	{
		if (IsDragging)
		{
			KQl(P_1);
		}
	}

	private void FQg(object P_0, InputPointerButtonEventArgs P_1)
	{
		DateTime dateTime = xQu;
		Point point = wQ1;
		xQu = DateTime.Now;
		wQ1 = P_1.GetPosition(this);
		if (P_1 != null && P_1.IsPrimaryButton)
		{
			if (!vAE.L0A(point, wQ1, dateTime, xQu, P_1.DeviceKind == InputDeviceKind.Touch))
			{
				StartDrag(P_1);
				return;
			}
			P_1.Handled = true;
			IQv();
		}
	}

	private void UQQ(object P_0, InputPointerButtonEventArgs P_1)
	{
		yQX(P_1);
		QQC.ReleasePointerCaptures();
	}

	private void mQe(InputPointerEventArgs P_0)
	{
		dQF?.Invoke(this, P_0);
	}

	private void KQl(InputPointerEventArgs P_0)
	{
		FQ3?.Invoke(this, P_0);
	}

	private void hQA(InputPointerEventArgs P_0)
	{
		VQR?.Invoke(this, P_0);
	}

	private void IQv()
	{
		BQY?.Invoke(this, EventArgs.Empty);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void StartDrag(InputPointerButtonEventArgs sourceEventArgs)
	{
		if (sourceEventArgs != null)
		{
			sourceEventArgs.Handled = true;
			QQC.CapturePointer(sourceEventArgs, this);
			IsDragging = true;
			hQA(sourceEventArgs);
		}
	}

	internal static bool FBN()
	{
		return EBG == null;
	}

	internal static EditorViewSplitter gBH()
	{
		return EBG;
	}
}
