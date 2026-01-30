using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
[TemplatePart(Name = "PART_Gripper", Type = typeof(FrameworkElement))]
public class PropertyGridSummaryContentControl : ContentControl
{
	private FrameworkElement rEX;

	private InputAdapter vE2;

	private double rEv;

	private Point? bE8;

	public static readonly DependencyProperty CanAutoSizeProperty;

	public static readonly DependencyProperty IsResizableProperty;

	internal static PropertyGridSummaryContentControl is6;

	public bool CanAutoSize
	{
		get
		{
			return (bool)GetValue(CanAutoSizeProperty);
		}
		set
		{
			SetValue(CanAutoSizeProperty, value);
		}
	}

	public bool IsResizable
	{
		get
		{
			return (bool)GetValue(IsResizableProperty);
		}
		set
		{
			SetValue(IsResizableProperty, value);
		}
	}

	public PropertyGridSummaryContentControl()
	{
		fc.taYSkz();
		base._002Ector();
		base.DefaultStyleKey = typeof(PropertyGridSummaryContentControl);
	}

	[SpecialName]
	private FrameworkElement OEu()
	{
		return rEX;
	}

	[SpecialName]
	private void HEO(FrameworkElement value)
	{
		if (rEX == value)
		{
			return;
		}
		int num;
		if (vE2 != null)
		{
			vE2.AttachedEventKinds = InputAdapterEventKinds.None;
			vE2.DoubleTapped -= EEM;
			vE2.PointerCaptureLost -= DEG;
			vE2.PointerMoved -= MEe;
			vE2.PointerPressed -= IEr;
			num = 1;
			if (!RsF())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_013d;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			vE2.PointerCaptureLost += DEG;
			vE2.PointerMoved += MEe;
			vE2.PointerPressed += IEr;
			vE2.PointerReleased += DEG;
			vE2.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.DoubleTapped;
			return;
		}
		vE2.PointerReleased -= DEG;
		vE2 = null;
		goto IL_013d;
		IL_013d:
		rEX = value;
		if (rEX == null)
		{
			return;
		}
		vE2 = new InputAdapter(rEX);
		vE2.DoubleTapped += EEM;
		num = 0;
		if (!RsF())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void EEM(object P_0, InputDoubleTappedEventArgs P_1)
	{
		if (CanAutoSize)
		{
			AutoSize();
		}
	}

	private void MEe(object P_0, InputPointerEventArgs P_1)
	{
		if (bE8.HasValue)
		{
			PropertyGrid ancestor = VisualTreeHelperExtended.GetAncestor<PropertyGrid>(this);
			if (ancestor != null)
			{
				Point position = P_1.GetPosition(ancestor);
				base.Height = Math.Max(base.MinHeight, Math.Min(base.MaxHeight, Math.Min(ancestor.ActualHeight - 30.0, rEv + (bE8.Value.Y - position.Y))));
			}
		}
	}

	private void IEr(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (!P_1.IsPrimaryButton)
		{
			return;
		}
		PropertyGrid ancestor = VisualTreeHelperExtended.GetAncestor<PropertyGrid>(this);
		if (ancestor != null)
		{
			bE8 = P_1.GetPosition(ancestor);
			rEv = (double.IsNaN(base.Height) ? base.ActualHeight : base.Height);
			if (vE2 != null)
			{
				vE2.CapturePointer(P_1);
			}
		}
	}

	private void DEG(object P_0, InputPointerEventArgs P_1)
	{
		bE8 = null;
		if (vE2 != null)
		{
			vE2.ReleasePointerCaptures();
		}
	}

	public void AutoSize()
	{
		base.Width = double.NaN;
		base.Height = double.NaN;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		HEO(GetTemplateChild(xv.hTz(9716)) as FrameworkElement);
	}

	static PropertyGridSummaryContentControl()
	{
		fc.taYSkz();
		CanAutoSizeProperty = DependencyProperty.Register(xv.hTz(9744), typeof(bool), typeof(PropertyGridSummaryContentControl), new PropertyMetadata(true));
		IsResizableProperty = DependencyProperty.Register(xv.hTz(9770), typeof(bool), typeof(PropertyGridSummaryContentControl), new PropertyMetadata(true));
	}

	internal static bool RsF()
	{
		return is6 == null;
	}

	internal static PropertyGridSummaryContentControl yss()
	{
		return is6;
	}
}
