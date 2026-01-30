using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace V67xSwgHMjgFEG89pLo;

public class bJASOyg2t3QIu15TD8s : UserControl, IComponentConnector
{
	internal ListBox ListScripts;

	private bool IcagnkPnpJ;

	private static bJASOyg2t3QIu15TD8s FtE3dc4YKNBcAReHGfAU;

	public bJASOyg2t3QIu15TD8s()
	{
		ngNGOK4YwWiL8Txy4yh5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void J0wgfvqimC(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer scrollViewer = vxUg9f5xrY<ScrollViewer>(this);
		if (scrollViewer != null)
		{
			scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - (double)P_1.Delta / 3.0);
			KDKFnX4Y7O6qGF1pWyhP(P_1, true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static mUVybklavbT6xaXl4oHG vxUg9f5xrY<mUVybklavbT6xaXl4oHG>(DependencyObject P_0) where mUVybklavbT6xaXl4oHG : DependencyObject
	{
		if (P_0 == null)
		{
			return null;
		}
		for (int i = 0; i < VisualTreeHelper.GetChildrenCount(P_0); i++)
		{
			DependencyObject child = VisualTreeHelper.GetChild(P_0, i);
			if (child is mUVybklavbT6xaXl4oHG)
			{
				return child as mUVybklavbT6xaXl4oHG;
			}
			mUVybklavbT6xaXl4oHG val = vxUg9f5xrY<mUVybklavbT6xaXl4oHG>(child);
			if (val != null)
			{
				return val;
			}
		}
		return null;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!IcagnkPnpJ)
		{
			IcagnkPnpJ = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7394EDA4), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 == 1)
		{
			ListScripts = (ListBox)P_1;
			RMXD6y4Y8QDXIlYB7BiH(ListScripts, new MouseWheelEventHandler(J0wgfvqimC));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			IcagnkPnpJ = true;
		}
	}

	static bJASOyg2t3QIu15TD8s()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void ngNGOK4YwWiL8Txy4yh5()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool UdHt9B4Ym2TL8cOtZobI()
	{
		return FtE3dc4YKNBcAReHGfAU == null;
	}

	internal static bJASOyg2t3QIu15TD8s rrtB1Z4Yhb48a6OtZC1L()
	{
		return FtE3dc4YKNBcAReHGfAU;
	}

	internal static void KDKFnX4Y7O6qGF1pWyhP(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static void RMXD6y4Y8QDXIlYB7BiH(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewMouseWheel += (MouseWheelEventHandler)P_1;
	}
}
