using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputAdapter
{
	private class QU
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int aHJ;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point lH9;

		private static QU Je6;

		[SpecialName]
		[CompilerGenerated]
		public int JHy()
		{
			return aHJ;
		}

		[SpecialName]
		[CompilerGenerated]
		public void wHf(int P_0)
		{
			aHJ = P_0;
		}

		public bool vHb(Point P_0)
		{
			return new Rect(fHS().X - 3.0, fHS().Y - 3.0, 6.0, 6.0).Contains(P_0);
		}

		[SpecialName]
		[CompilerGenerated]
		public Point fHS()
		{
			return lH9;
		}

		[SpecialName]
		[CompilerGenerated]
		public void tH3(Point P_0)
		{
			lH9 = P_0;
		}

		public QU()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool bew()
		{
			return Je6 == null;
		}

		internal static QU uek()
		{
			return Je6;
		}
	}

	private InputAdapterEventKinds i0r;

	private WeakReference y0Z;

	private static readonly DependencyProperty x0n;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputDoubleTappedEventArgs> t0a;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputKeyEventArgs> d0q;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputKeyEventArgs> V0W;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerEventArgs> d0U;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerEventArgs> b0H;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputPointerEventArgs> D06;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<InputPointerEventArgs> u0V;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerButtonEventArgs> D05;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerButtonEventArgs> f0R;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputPointerWheelEventArgs> K0E;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<InputTappedEventArgs> j0s;

	internal static InputAdapter mJ7;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public InputAdapterEventKinds AttachedEventKinds
	{
		get
		{
			return i0r;
		}
		set
		{
			if (i0r == value)
			{
				return;
			}
			UIElement targetElement = TargetElement;
			if (targetElement == null)
			{
				value = InputAdapterEventKinds.None;
			}
			if (IsAttached && targetElement != null)
			{
				if (IsAttachedTo(InputAdapterEventKinds.KeyDown))
				{
					targetElement.KeyDown -= O0u;
				}
				if (IsAttachedTo(InputAdapterEventKinds.KeyUp))
				{
					targetElement.KeyUp -= v02;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerCaptureLost))
				{
					targetElement.LostMouseCapture -= x0e;
					targetElement.LostTouchCapture -= x0e;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerPressed) || IsAttachedTo(InputAdapterEventKinds.Tapped) || IsAttachedTo(InputAdapterEventKinds.DoubleTapped))
				{
					targetElement.MouseDown -= q0Q;
					targetElement.TouchDown -= n0k;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerEntered))
				{
					targetElement.MouseEnter -= U07;
					targetElement.TouchEnter -= y0l;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerExited))
				{
					targetElement.MouseLeave -= C0F;
					targetElement.TouchLeave -= w0A;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerMoved))
				{
					targetElement.MouseMove -= b0o;
					targetElement.TouchMove -= y0C;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerReleased) || IsAttachedTo(InputAdapterEventKinds.Tapped) || IsAttachedTo(InputAdapterEventKinds.DoubleTapped))
				{
					targetElement.MouseUp -= F0O;
					targetElement.TouchUp -= l0Y;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerWheelChanged))
				{
					targetElement.MouseWheel -= i00;
				}
			}
			i0r = value;
			if (IsAttached)
			{
				if (IsAttachedTo(InputAdapterEventKinds.KeyDown))
				{
					targetElement.KeyDown += O0u;
				}
				if (IsAttachedTo(InputAdapterEventKinds.KeyUp))
				{
					targetElement.KeyUp += v02;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerCaptureLost))
				{
					targetElement.LostMouseCapture += x0e;
					targetElement.LostTouchCapture += x0e;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerPressed) || IsAttachedTo(InputAdapterEventKinds.Tapped) || IsAttachedTo(InputAdapterEventKinds.DoubleTapped))
				{
					targetElement.MouseDown += q0Q;
					targetElement.TouchDown += n0k;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerEntered))
				{
					targetElement.MouseEnter += U07;
					targetElement.TouchEnter += y0l;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerExited))
				{
					targetElement.MouseLeave += C0F;
					targetElement.TouchLeave += w0A;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerMoved))
				{
					targetElement.MouseMove += b0o;
					targetElement.TouchMove += y0C;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerReleased) || IsAttachedTo(InputAdapterEventKinds.Tapped) || IsAttachedTo(InputAdapterEventKinds.DoubleTapped))
				{
					targetElement.MouseUp += F0O;
					targetElement.TouchUp += l0Y;
				}
				if (IsAttachedTo(InputAdapterEventKinds.PointerWheelChanged))
				{
					targetElement.MouseWheel += i00;
				}
			}
		}
	}

	public bool IsAttached => i0r != InputAdapterEventKinds.None;

	public UIElement TargetElement
	{
		get
		{
			if (y0Z != null && y0Z.IsAlive)
			{
				return y0Z.Target as UIElement;
			}
			return null;
		}
	}

	public event EventHandler<InputDoubleTappedEventArgs> DoubleTapped
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputDoubleTappedEventArgs> eventHandler = t0a;
			EventHandler<InputDoubleTappedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputDoubleTappedEventArgs> value2 = (EventHandler<InputDoubleTappedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref t0a, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputDoubleTappedEventArgs> eventHandler = t0a;
			EventHandler<InputDoubleTappedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputDoubleTappedEventArgs> value2 = (EventHandler<InputDoubleTappedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref t0a, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputKeyEventArgs> KeyDown
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputKeyEventArgs> eventHandler = d0q;
			EventHandler<InputKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputKeyEventArgs> value2 = (EventHandler<InputKeyEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d0q, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputKeyEventArgs> eventHandler = d0q;
			EventHandler<InputKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputKeyEventArgs> value2 = (EventHandler<InputKeyEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d0q, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputKeyEventArgs> KeyUp
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputKeyEventArgs> eventHandler = V0W;
			EventHandler<InputKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputKeyEventArgs> value2 = (EventHandler<InputKeyEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref V0W, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputKeyEventArgs> eventHandler = V0W;
			EventHandler<InputKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputKeyEventArgs> value2 = (EventHandler<InputKeyEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref V0W, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> PointerCaptureLost
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = d0U;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d0U, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = d0U;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref d0U, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> PointerEntered
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = b0H;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref b0H, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = b0H;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref b0H, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> PointerExited
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = D06;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref D06, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = D06;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref D06, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerEventArgs> PointerMoved
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerEventArgs> eventHandler = u0V;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref u0V, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerEventArgs> eventHandler = u0V;
			EventHandler<InputPointerEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerEventArgs> value2 = (EventHandler<InputPointerEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref u0V, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerButtonEventArgs> PointerPressed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerButtonEventArgs> eventHandler = D05;
			EventHandler<InputPointerButtonEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerButtonEventArgs> value2 = (EventHandler<InputPointerButtonEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref D05, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerButtonEventArgs> eventHandler = D05;
			EventHandler<InputPointerButtonEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerButtonEventArgs> value2 = (EventHandler<InputPointerButtonEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref D05, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerButtonEventArgs> PointerReleased
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerButtonEventArgs> eventHandler = f0R;
			EventHandler<InputPointerButtonEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerButtonEventArgs> value2 = (EventHandler<InputPointerButtonEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref f0R, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerButtonEventArgs> eventHandler = f0R;
			EventHandler<InputPointerButtonEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerButtonEventArgs> value2 = (EventHandler<InputPointerButtonEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref f0R, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputPointerWheelEventArgs> PointerWheelChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputPointerWheelEventArgs> eventHandler = K0E;
			EventHandler<InputPointerWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerWheelEventArgs> value2 = (EventHandler<InputPointerWheelEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref K0E, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputPointerWheelEventArgs> eventHandler = K0E;
			EventHandler<InputPointerWheelEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputPointerWheelEventArgs> value2 = (EventHandler<InputPointerWheelEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref K0E, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<InputTappedEventArgs> Tapped
	{
		[CompilerGenerated]
		add
		{
			EventHandler<InputTappedEventArgs> eventHandler = j0s;
			EventHandler<InputTappedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTappedEventArgs> value2 = (EventHandler<InputTappedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref j0s, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<InputTappedEventArgs> eventHandler = j0s;
			EventHandler<InputTappedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<InputTappedEventArgs> value2 = (EventHandler<InputTappedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref j0s, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public InputAdapter(UIElement element)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (element == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(98474));
		}
		y0Z = new WeakReference(element);
	}

	private static bool l0m(MouseEventArgs P_0)
	{
		if (P_0 != null)
		{
			return P_0.StylusDevice != null && P_0.StylusDevice.TabletDevice != null && P_0.StylusDevice.TabletDevice.Type == TabletDeviceType.Touch;
		}
		return false;
	}

	private void C0w(object P_0, InputEventArgs P_1, InputPointerButtonKind P_2)
	{
		EventHandler<InputPointerButtonEventArgs> eventHandler = D05;
		bool flag = eventHandler != null;
		int num = 0;
		if (oJJ() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		QU qU = default(QU);
		UIElement uIElement = default(UIElement);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (qU == null)
				{
					qU = new QU();
					d0x(uIElement, qU);
				}
				qU.wHf(P_1.GetClickCount());
				qU.tH3(P_1.GetPosition(uIElement));
				return;
			}
			if (flag)
			{
				eventHandler(P_0, new InputPointerButtonEventArgs(P_1, P_2));
			}
			if (P_2 != InputPointerButtonKind.Primary || P_1 == null || P_1.Handled)
			{
				return;
			}
			uIElement = P_0 as UIElement;
			if (uIElement == null)
			{
				return;
			}
			qU = y0I(uIElement);
			num = 1;
			if (nJH())
			{
				continue;
			}
			break;
		}
		goto IL_0005;
	}

	private void L04(object P_0, InputEventArgs P_1, InputPointerButtonKind P_2)
	{
		f0R?.Invoke(P_0, new InputPointerButtonEventArgs(P_1, P_2));
		if (P_2 != InputPointerButtonKind.Primary || !(P_0 is UIElement uIElement))
		{
			return;
		}
		QU qU = y0I(uIElement);
		if (qU == null)
		{
			return;
		}
		if (qU.vHb(P_1.GetPosition(uIElement)))
		{
			if (qU.JHy() % 2 == 1)
			{
				j0s?.Invoke(uIElement, new InputTappedEventArgs(P_1));
			}
			else
			{
				t0a?.Invoke(uIElement, new InputDoubleTappedEventArgs(P_1));
			}
		}
		uIElement.ClearValue(x0n);
	}

	private void O0u(object P_0, KeyEventArgs P_1)
	{
		d0q?.Invoke(P_0, new InputKeyEventArgs(P_1));
	}

	private void v02(object P_0, KeyEventArgs P_1)
	{
		V0W?.Invoke(P_0, new InputKeyEventArgs(P_1));
	}

	private void x0e(object P_0, InputEventArgs P_1)
	{
		d0U?.Invoke(P_0, new InputPointerEventArgs(P_1));
	}

	private void U07(object P_0, InputEventArgs P_1)
	{
		if (!l0m(P_1 as MouseEventArgs))
		{
			b0H?.Invoke(P_0, new InputPointerEventArgs(P_1));
		}
	}

	private void C0F(object P_0, InputEventArgs P_1)
	{
		if (!l0m(P_1 as MouseEventArgs))
		{
			D06?.Invoke(P_0, new InputPointerEventArgs(P_1));
		}
	}

	private void b0o(object P_0, InputEventArgs P_1)
	{
		if (!l0m(P_1 as MouseEventArgs))
		{
			u0V?.Invoke(P_0, new InputPointerEventArgs(P_1));
		}
	}

	private void q0Q(object P_0, InputEventArgs P_1)
	{
		InputPointerButtonKind inputPointerButtonKind = InputPointerButtonKind.Primary;
		if (P_1 is MouseButtonEventArgs e)
		{
			if (l0m(e))
			{
				return;
			}
			inputPointerButtonKind = e.ChangedButton switch
			{
				MouseButton.Middle => InputPointerButtonKind.Middle, 
				MouseButton.Right => InputPointerButtonKind.Secondary, 
				MouseButton.XButton1 => InputPointerButtonKind.Extended1, 
				MouseButton.XButton2 => InputPointerButtonKind.Extended2, 
				_ => InputPointerButtonKind.Primary, 
			};
		}
		C0w(P_0, P_1, inputPointerButtonKind);
	}

	private void F0O(object P_0, InputEventArgs P_1)
	{
		InputPointerButtonKind inputPointerButtonKind = InputPointerButtonKind.Primary;
		if (P_1 is MouseButtonEventArgs e)
		{
			if (l0m(e))
			{
				return;
			}
			inputPointerButtonKind = e.ChangedButton switch
			{
				MouseButton.Middle => InputPointerButtonKind.Middle, 
				MouseButton.Right => InputPointerButtonKind.Secondary, 
				MouseButton.XButton1 => InputPointerButtonKind.Extended1, 
				MouseButton.XButton2 => InputPointerButtonKind.Extended2, 
				_ => InputPointerButtonKind.Primary, 
			};
		}
		L04(P_0, P_1, inputPointerButtonKind);
	}

	private void i00(object P_0, MouseWheelEventArgs P_1)
	{
		K0E?.Invoke(P_0, new InputPointerWheelEventArgs(P_1));
	}

	private void n0k(object P_0, TouchEventArgs P_1)
	{
		C0w(P_0, P_1, InputPointerButtonKind.Primary);
	}

	private void y0l(object P_0, TouchEventArgs P_1)
	{
		b0H?.Invoke(P_0, new InputPointerEventArgs(P_1));
	}

	private void w0A(object P_0, TouchEventArgs P_1)
	{
		D06?.Invoke(P_0, new InputPointerEventArgs(P_1));
	}

	private void y0C(object P_0, TouchEventArgs P_1)
	{
		u0V?.Invoke(P_0, new InputPointerEventArgs(P_1));
	}

	private void l0Y(object P_0, TouchEventArgs P_1)
	{
		L04(P_0, P_1, InputPointerButtonKind.Primary);
	}

	private static QU y0I(DependencyObject P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (QU)P_0.GetValue(x0n);
	}

	private static void d0x(DependencyObject P_0, QU P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		P_0.SetValue(x0n, P_1);
	}

	public bool CapturePointer(InputPointerEventArgs e)
	{
		return CapturePointer(e, TargetElement);
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public bool CapturePointer(InputPointerEventArgs e, UIElement targetElement)
	{
		if (e != null && targetElement != null)
		{
			switch (e.DeviceKind)
			{
			case InputDeviceKind.Mouse:
				return targetElement.CaptureMouse();
			case InputDeviceKind.Stylus:
				return targetElement.CaptureStylus();
			case InputDeviceKind.Touch:
				if (e.WrappedEventArgs is TouchEventArgs { TouchDevice: not null } e2)
				{
					return e2.TouchDevice.Capture(targetElement);
				}
				break;
			}
		}
		return false;
	}

	public bool IsAttachedTo(InputAdapterEventKinds kind)
	{
		return (i0r & kind) == kind;
	}

	public void ReleasePointerCaptures()
	{
		UIElement targetElement = TargetElement;
		if (targetElement != null)
		{
			if (targetElement.AreAnyTouchesCaptured)
			{
				targetElement.ReleaseAllTouchCaptures();
			}
			if (targetElement.IsMouseCaptured)
			{
				targetElement.ReleaseMouseCapture();
			}
			if (targetElement.IsStylusCaptured)
			{
				targetElement.ReleaseStylusCapture();
			}
		}
	}

	static InputAdapter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		x0n = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110510), typeof(QU), typeof(InputAdapter), new PropertyMetadata(null));
	}

	internal static bool nJH()
	{
		return mJ7 == null;
	}

	internal static InputAdapter oJJ()
	{
		return mJ7;
	}
}
