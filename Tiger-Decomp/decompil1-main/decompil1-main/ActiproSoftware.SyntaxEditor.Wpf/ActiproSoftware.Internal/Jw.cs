using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class Jw : DisposableObject
{
	private UIElement YFw;

	private SyntaxEditor rF6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler qFH;

	private static Jw cLM;

	[SpecialName]
	[CompilerGenerated]
	public void fF4(EventHandler P_0)
	{
		EventHandler eventHandler = qFH;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref qFH, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void nFo(EventHandler P_0)
	{
		EventHandler eventHandler = qFH;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref qFH, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public Jw(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		rF6 = P_0;
	}

	private void CFu(UIElement P_0)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = YFw == P_0;
				num2 = 0;
				if (ILv() != null)
				{
					num2 = 0;
				}
				continue;
			}
			if (flag)
			{
				return;
			}
			if (YFw != null)
			{
				vAE.T0G<object>(YFw, delegate
				{
					YFw.LostKeyboardFocus -= WF1;
				}, null);
			}
			YFw = P_0;
			if (YFw != null)
			{
				YFw.LostKeyboardFocus += WF1;
			}
			return;
		}
	}

	private void WF1(object P_0, KeyboardFocusChangedEventArgs P_1)
	{
		PFF();
	}

	protected override void Dispose(bool P_0)
	{
		base.Dispose(P_0);
		CFu(null);
	}

	[SpecialName]
	public bool WFR()
	{
		bool result = default(bool);
		if (vAE.E0C(rF6.ActiveView))
		{
			result = true;
			goto IL_0091;
		}
		if (vAE.u0Q() is UIElement source)
		{
			Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(source);
			if (ancestorPopup != null)
			{
				UIElement uIElement = ancestorPopup.PlacementTarget;
				while (uIElement != null)
				{
					if (!rF6.IsAncestorOf(uIElement))
					{
						uIElement = VisualTreeHelperExtended.GetAncestorPopup(uIElement)?.PlacementTarget;
						continue;
					}
					goto IL_00de;
				}
			}
		}
		result = false;
		int num = 1;
		if (ILv() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0091:
		return result;
		IL_0009:
		switch (num)
		{
		default:
			result = true;
			break;
		case 1:
			break;
		}
		goto IL_0091;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_00de:
		num = 0;
		if (!fL3())
		{
			goto IL_0005;
		}
		goto IL_0009;
	}

	public void PFF()
	{
		if (!WFR() || !(vAE.u0Q() is UIElement uIElement))
		{
			CFu(null);
			qFH?.Invoke(this, EventArgs.Empty);
			return;
		}
		CFu(uIElement);
		int num = 0;
		if (!fL3())
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

	[CompilerGenerated]
	private void DF3(object P_0)
	{
		YFw.LostKeyboardFocus -= WF1;
	}

	internal static bool fL3()
	{
		return cLM == null;
	}

	internal static Jw ILv()
	{
		return cLM;
	}
}
