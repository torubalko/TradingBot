using System.Windows;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

internal class OdX : FrameworkElement
{
	public static readonly DependencyProperty qIU;

	internal static OdX ESB;

	public object rIN(BindingBase P_0, object P_1)
	{
		try
		{
			if (P_1 != null)
			{
				base.DataContext = P_1;
			}
			BindingOperations.SetBinding(this, qIU, P_0);
			return GetValue(qIU);
		}
		finally
		{
			ClearValue(qIU);
			if (P_1 != null)
			{
				ClearValue(FrameworkElement.DataContextProperty);
			}
		}
	}

	public OdX()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	static OdX()
	{
		awj.QuEwGz();
		qIU = DependencyProperty.Register(QdM.AR8(1828), typeof(object), typeof(OdX), new PropertyMetadata(null));
	}

	internal static bool nSW()
	{
		return ESB == null;
	}

	internal static OdX KSr()
	{
		return ESB;
	}
}
