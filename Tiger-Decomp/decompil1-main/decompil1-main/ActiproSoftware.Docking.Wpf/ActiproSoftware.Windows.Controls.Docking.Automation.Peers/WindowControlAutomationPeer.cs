using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class WindowControlAutomationPeer : FrameworkElementAutomationPeer, ITransformProvider, IWindowProvider
{
	internal static WindowControlAutomationPeer sCy;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool ITransformProvider.CanMove => true;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool ITransformProvider.CanResize
	{
		get
		{
			ResizeMode resizeMode = ((WindowControl)base.Owner).ResizeMode;
			if ((uint)resizeMode <= 1u)
			{
				return false;
			}
			return true;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool ITransformProvider.CanRotate => false;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	WindowInteractionState IWindowProvider.InteractionState => WindowInteractionState.ReadyForUserInteraction;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IWindowProvider.IsModal => false;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IWindowProvider.IsTopmost => ((WindowControl)base.Owner).IsActive;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IWindowProvider.Maximizable => ((WindowControl)base.Owner).IsMaximizeButtonVisible;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IWindowProvider.Minimizable => ((WindowControl)base.Owner).IsMinimizeButtonVisible;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	WindowVisualState IWindowProvider.VisualState => nRS(((WindowControl)base.Owner).WindowState);

	public WindowControlAutomationPeer(WindowControl owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void ITransformProvider.Move(double x, double y)
	{
		WindowControl obj = (WindowControl)base.Owner;
		obj.Left = x;
		obj.Top = y;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void ITransformProvider.Resize(double width, double height)
	{
		WindowControl obj = (WindowControl)base.Owner;
		obj.Width = width;
		obj.Height = height;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void ITransformProvider.Rotate(double degrees)
	{
		throw new InvalidOperationException();
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IWindowProvider.Close()
	{
		((WindowControl)base.Owner).Close();
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IWindowProvider.SetVisualState(WindowVisualState state)
	{
		((WindowControl)base.Owner).WindowState = lRR(state);
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IWindowProvider.WaitForInputIdle(int milliseconds)
	{
		return true;
	}

	private static WindowState lRR(WindowVisualState P_0)
	{
		if (P_0 == WindowVisualState.Normal)
		{
			return WindowState.Normal;
		}
		if (WindowVisualState.Minimized == P_0)
		{
			return WindowState.Minimized;
		}
		return WindowState.Maximized;
	}

	private static WindowVisualState nRS(WindowState P_0)
	{
		if (P_0 == WindowState.Normal)
		{
			return WindowVisualState.Normal;
		}
		if (WindowState.Minimized == P_0)
		{
			return WindowVisualState.Minimized;
		}
		return WindowVisualState.Maximized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void lRL(bool P_0, bool P_1)
	{
		if (P_0 != P_1)
		{
			RaisePropertyChangedEvent(WindowPatternIdentifiers.CanMaximizeProperty, P_0, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void YR3(bool P_0, bool P_1)
	{
		if (P_0 != P_1)
		{
			RaisePropertyChangedEvent(WindowPatternIdentifiers.CanMinimizeProperty, P_0, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void aR6(bool P_0, bool P_1)
	{
		if (P_0 != P_1)
		{
			RaisePropertyChangedEvent(WindowPatternIdentifiers.IsTopmostProperty, P_0, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void lR9(WindowState P_0, WindowState P_1)
	{
		if (P_0 != P_1)
		{
			RaisePropertyChangedEvent(WindowPatternIdentifiers.WindowVisualStateProperty, nRS(P_0), nRS(P_1));
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Window;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24204);
	}

	protected override string GetNameCore()
	{
		if (base.Owner is WindowControl windowControl && !string.IsNullOrEmpty(windowControl.Title))
		{
			return windowControl.Title;
		}
		return base.GetNameCore();
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Transform || patternInterface == PatternInterface.Window)
		{
			return this;
		}
		return null;
	}

	internal static bool mCV()
	{
		return sCy == null;
	}

	internal static WindowControlAutomationPeer mC3()
	{
		return sCy;
	}
}
