using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

internal class InputSource : IInputSource
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputMouseWheelEventArgs> jkT;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputMouseWheelEventArgs> ukB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputTouchEventArgs> ckp;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputTouchEventArgs> Lkb;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputTouchEventArgs> Pky;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputSourceEventArgs> Gkf;

	private static InputSource cJD;

	public event EventHandler<InputMouseWheelEventArgs> MouseWheel
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputMouseWheelEventArgs> eventHandler = jkT;
			EventHandler<InputMouseWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputMouseWheelEventArgs> value2 = (EventHandler<InputMouseWheelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jkT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputMouseWheelEventArgs> eventHandler = jkT;
			EventHandler<InputMouseWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputMouseWheelEventArgs> value2 = (EventHandler<InputMouseWheelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jkT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputMouseWheelEventArgs> PreviewMouseWheel
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputMouseWheelEventArgs> eventHandler = ukB;
			EventHandler<InputMouseWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputMouseWheelEventArgs> value2 = (EventHandler<InputMouseWheelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ukB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputMouseWheelEventArgs> eventHandler = ukB;
			EventHandler<InputMouseWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputMouseWheelEventArgs> value2 = (EventHandler<InputMouseWheelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ukB, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputTouchEventArgs> PreviewTouchDown
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputTouchEventArgs> eventHandler = ckp;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ckp, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputTouchEventArgs> eventHandler = ckp;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ckp, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputTouchEventArgs> PreviewTouchMove
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputTouchEventArgs> eventHandler = Lkb;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Lkb, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputTouchEventArgs> eventHandler = Lkb;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Lkb, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputTouchEventArgs> PreviewTouchUp
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputTouchEventArgs> eventHandler = Pky;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Pky, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputTouchEventArgs> eventHandler = Pky;
			EventHandler<InputTouchEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTouchEventArgs> value2 = (EventHandler<InputTouchEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Pky, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputSourceEventArgs> TouchFrameReported
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputSourceEventArgs> eventHandler = Gkf;
			EventHandler<InputSourceEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputSourceEventArgs> value2 = (EventHandler<InputSourceEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Gkf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputSourceEventArgs> eventHandler = Gkf;
			EventHandler<InputSourceEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputSourceEventArgs> value2 = (EventHandler<InputSourceEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Gkf, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public void CaptureMouse(IInputElement element)
	{
		Mouse.Capture(element);
	}

	public void NotifyMouseWheel(MouseWheelEventArgs args)
	{
		if (jkT != null)
		{
			jkT(this, new InputMouseWheelEventArgs(new InputMouseWheelFrame(args)));
		}
	}

	public void NotifyPreviewMouseWheel(MouseWheelEventArgs args)
	{
		if (ukB != null)
		{
			ukB(this, new InputMouseWheelEventArgs(new InputMouseWheelFrame(args)));
		}
	}

	public void NotifyPreviewTouchDown(TouchEventArgs args)
	{
		if (ckp != null)
		{
			ckp(this, new InputTouchEventArgs(args));
		}
	}

	public void NotifyPreviewTouchMove(TouchEventArgs args)
	{
		if (Lkb != null)
		{
			Lkb(this, new InputTouchEventArgs(args));
		}
	}

	public void NotifyPreviewTouchUp(TouchEventArgs args)
	{
		if (Pky != null)
		{
			Pky(this, new InputTouchEventArgs(args));
		}
	}

	public void NotifyTouchFrameReported(TouchFrameEventArgs args)
	{
		if (Gkf != null)
		{
			Gkf(this, new InputSourceEventArgs(new InputTouchFrame(args)));
		}
	}

	public InputSource()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool pJ2()
	{
		return cJD == null;
	}

	internal static InputSource RJl()
	{
		return cJD;
	}
}
