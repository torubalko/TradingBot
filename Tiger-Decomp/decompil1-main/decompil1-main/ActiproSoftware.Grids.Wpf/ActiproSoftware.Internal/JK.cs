using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class JK
{
	public static readonly DependencyProperty VEj;

	internal static JK Ds9;

	private static void eE9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		FrameworkElement frameworkElement = P_0 as FrameworkElement;
		SelectiveScrollingOrientation selectiveScrollingOrientation = (SelectiveScrollingOrientation)P_1.NewValue;
		int num = 0;
		if (!as8())
		{
			int num2 = default(int);
			num = num2;
		}
		ScrollViewer ancestor = default(ScrollViewer);
		TranslateTransform translateTransform = default(TranslateTransform);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (selectiveScrollingOrientation != SelectiveScrollingOrientation.Horizontal)
				{
					Binding binding = new Binding();
					binding.Path = new PropertyPath(xv.hTz(9796));
					binding.Source = ancestor;
					Binding binding2 = binding;
					BindingOperations.SetBinding(translateTransform, TranslateTransform.XProperty, binding2);
				}
				if (selectiveScrollingOrientation != SelectiveScrollingOrientation.Vertical)
				{
					Binding binding = new Binding();
					binding.Path = new PropertyPath(xv.hTz(9832));
					binding.Source = ancestor;
					Binding binding3 = binding;
					BindingOperations.SetBinding(translateTransform, TranslateTransform.YProperty, binding3);
				}
				frameworkElement.RenderTransform = translateTransform;
				return;
			}
			ancestor = VisualTreeHelperExtended.GetAncestor<ScrollViewer>(frameworkElement);
			if (ancestor == null || frameworkElement == null)
			{
				return;
			}
			if (frameworkElement.RenderTransform is TranslateTransform target)
			{
				BindingOperations.ClearBinding(target, TranslateTransform.XProperty);
				BindingOperations.ClearBinding(target, TranslateTransform.YProperty);
			}
			if (selectiveScrollingOrientation == SelectiveScrollingOrientation.Both)
			{
				frameworkElement.RenderTransform = null;
				return;
			}
			translateTransform = new TranslateTransform();
			num = 1;
			if (!as8())
			{
				num = 0;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static SelectiveScrollingOrientation fE3(FrameworkElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		return (SelectiveScrollingOrientation)P_0.GetValue(VEj);
	}

	public static void OEL(FrameworkElement P_0, SelectiveScrollingOrientation P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		P_0.SetValue(VEj, P_1);
	}

	public JK()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static JK()
	{
		fc.taYSkz();
		VEj = DependencyProperty.RegisterAttached(xv.hTz(9864), typeof(SelectiveScrollingOrientation), typeof(JK), new PropertyMetadata(SelectiveScrollingOrientation.Both, eE9));
	}

	internal static bool as8()
	{
		return Ds9 == null;
	}

	internal static JK lsk()
	{
		return Ds9;
	}
}
