using System.Windows;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

internal class up : FrameworkElement
{
	public static readonly DependencyProperty rEm;

	private static up DFd;

	public DE lEN<DE>(BindingBase P_0, object P_1) where DE : class
	{
		object value;
		try
		{
			if (P_1 != null)
			{
				base.DataContext = P_1;
			}
			BindingOperations.SetBinding(this, rEm, P_0);
			value = GetValue(rEm);
		}
		finally
		{
			ClearValue(rEm);
			if (P_1 != null)
			{
				ClearValue(FrameworkElement.DataContextProperty);
			}
		}
		return value as DE;
	}

	public bool GEl(BindingBase P_0, object P_1)
	{
		object value;
		try
		{
			if (P_1 != null)
			{
				base.DataContext = P_1;
			}
			BindingOperations.SetBinding(this, rEm, P_0);
			value = GetValue(rEm);
		}
		finally
		{
			ClearValue(rEm);
			if (P_1 != null)
			{
				ClearValue(FrameworkElement.DataContextProperty);
			}
		}
		if (value != null)
		{
			return (bool)value;
		}
		return false;
	}

	public void UEg(Binding P_0, object P_1, object P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		BindingMode mode = P_0.Mode;
		if (mode != BindingMode.TwoWay && mode != BindingMode.OneWayToSource)
		{
			return;
		}
		try
		{
			if (P_1 != null)
			{
				base.DataContext = P_1;
			}
			BindingOperations.SetBinding(this, rEm, P_0);
			SetValue(rEm, P_2);
		}
		finally
		{
			ClearValue(rEm);
			if (P_1 != null)
			{
				ClearValue(FrameworkElement.DataContextProperty);
			}
		}
	}

	public up()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static up()
	{
		fc.taYSkz();
		rEm = DependencyProperty.Register(xv.hTz(8634), typeof(object), typeof(up), new PropertyMetadata(null));
	}

	internal static bool KFN()
	{
		return DFd == null;
	}

	internal static up VF3()
	{
		return DFd;
	}
}
