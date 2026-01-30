using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Automation.Peers;

public class AnimatedProgressBarAutomationPeer : RangeBaseAutomationPeer, IRangeValueProvider, IValueProvider
{
	internal static AnimatedProgressBarAutomationPeer j1g;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IRangeValueProvider.IsReadOnly => true;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	double IRangeValueProvider.LargeChange => double.NaN;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	double IRangeValueProvider.SmallChange => double.NaN;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IValueProvider.IsReadOnly => true;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	string IValueProvider.Value
	{
		get
		{
			AnimatedProgressBar animatedProgressBar = (AnimatedProgressBar)base.Owner;
			return animatedProgressBar.State.ToString();
		}
	}

	public AnimatedProgressBarAutomationPeer(AnimatedProgressBar owner)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(owner);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RaiseValuePropertyChangedEvent(OperationState oldValue, OperationState newValue)
	{
		if (oldValue != newValue)
		{
			RaisePropertyChangedEvent(ValuePatternIdentifiers.ValueProperty, oldValue.ToString(), newValue.ToString());
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.ProgressBar;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (PatternInterface.Value == patternInterface)
		{
			return this;
		}
		if (PatternInterface.RangeValue == patternInterface)
		{
			AnimatedProgressBar animatedProgressBar = (AnimatedProgressBar)base.Owner;
			if (animatedProgressBar.IsIndeterminate)
			{
				return null;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IRangeValueProvider.SetValue(double value)
	{
		throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123002));
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IValueProvider.SetValue(string value)
	{
		throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123104));
	}

	internal static bool I18()
	{
		return j1g == null;
	}

	internal static AnimatedProgressBarAutomationPeer Q1j()
	{
		return j1g;
	}
}
