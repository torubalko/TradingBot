using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class GradientStopThumb : Control
{
	private InputAdapter aOW;

	private Point oOi;

	public static readonly DependencyProperty IsDraggingProperty;

	public static readonly DependencyProperty IsDraggingToRemoveProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	internal static GradientStopThumb Tji;

	public bool IsDragging
	{
		get
		{
			return (bool)GetValue(IsDraggingProperty);
		}
		private set
		{
			SetValue(IsDraggingProperty, value);
		}
	}

	public bool IsDraggingToRemove
	{
		get
		{
			return (bool)GetValue(IsDraggingToRemoveProperty);
		}
		private set
		{
			SetValue(IsDraggingToRemoveProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public GradientStopThumb()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(GradientStopThumb);
		eOA();
	}

	private void eOA()
	{
		aOW = new InputAdapter(this);
		aOW.PointerCaptureLost += sOy;
		aOW.PointerMoved += XOm;
		aOW.PointerPressed += VOS;
		aOW.PointerReleased += DO1;
		aOW.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	private void OO3(double P_0)
	{
		GradientStopSlider gradientStopSlider = LO8();
		if (gradientStopSlider == null || !(VisualTreeHelper.GetParent(this) is GradientStopSliderPanel))
		{
			return;
		}
		double val = 0.0;
		double val2 = 1.0;
		IList<GradientStopThumb> list = gradientStopSlider.Bjb();
		int num = list.IndexOf(this);
		if (num != -1)
		{
			if (num > 0 && list[num - 1].DataContext is GradientStop gradientStop)
			{
				val = gradientStop.Offset;
			}
			if (num < list.Count - 1 && list[num + 1].DataContext is GradientStop gradientStop2)
			{
				val2 = gradientStop2.Offset;
			}
			if (base.DataContext is GradientStop gradientStop3)
			{
				gradientStopSlider.IjV(gradientStop3, Math.Max(val, Math.Min(val2, gradientStop3.Offset + P_0)));
			}
		}
	}

	private void sOy(object P_0, InputPointerEventArgs P_1)
	{
		IsDragging = false;
		IsDraggingToRemove = false;
	}

	private void XOm(object P_0, InputPointerEventArgs P_1)
	{
		if (P_1 == null || !IsDragging)
		{
			return;
		}
		GradientStopSlider gradientStopSlider = LO8();
		if (gradientStopSlider == null)
		{
			return;
		}
		GradientStopSliderPanel gradientStopSliderPanel = VisualTreeHelper.GetParent(this) as GradientStopSliderPanel;
		bool flag = gradientStopSliderPanel != null;
		int num = 1;
		if (!pj5())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		Point position = default(Point);
		double val2 = default(double);
		double val3 = default(double);
		IList<GradientStopThumb> list = default(IList<GradientStopThumb>);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				double num3 = 40.0;
				IsDraggingToRemove = gradientStopSlider.Ej0() && (position.Y < 0.0 - num3 || position.Y > base.ActualHeight + num3);
				val2 = 0.0;
				val3 = 1.0;
				list = gradientStopSlider.Bjb();
				num4 = list.IndexOf(this);
				if (num4 == -1)
				{
					return;
				}
				if (num4 > 0 && list[num4 - 1].DataContext is GradientStop gradientStop2)
				{
					val2 = gradientStop2.Offset;
					num = 0;
					if (pj5())
					{
						continue;
					}
					break;
				}
				goto default;
			}
			case 3:
				if (base.DataContext is GradientStop gradientStop)
				{
					double actualWidth = gradientStopSliderPanel.ActualWidth;
					double num2 = position.X + base.ActualWidth / 2.0 - oOi.X;
					double val = num2 / Math.Max(1.0, actualWidth);
					gradientStopSlider.IjV(gradientStop, Math.Max(val2, Math.Min(val3, val)));
				}
				return;
			case 1:
				if (!flag)
				{
					return;
				}
				position = P_1.GetPosition(gradientStopSliderPanel);
				num = 2;
				continue;
			default:
				if (num4 >= list.Count - 1 || !(list[num4 + 1].DataContext is GradientStop gradientStop3))
				{
					goto case 3;
				}
				val3 = gradientStop3.Offset;
				num = 3;
				if (kjI() == null)
				{
					continue;
				}
				break;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num5 = default(int);
		num = num5;
		goto IL_0009;
	}

	private void VOS(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null)
		{
			P_1.Handled = true;
			oOi = P_1.GetPosition(this);
			aOW.CapturePointer(P_1);
			int num = 0;
			if (!pj5())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			Focus();
		}
		IsDragging = true;
		LO8()?.ksz(this);
	}

	private void DO1(object P_0, InputPointerButtonEventArgs P_1)
	{
		bool isDraggingToRemove = IsDraggingToRemove;
		IsDragging = false;
		IsDraggingToRemove = false;
		aOW.ReleasePointerCaptures();
		if (isDraggingToRemove)
		{
			RemoveIfAllowed();
		}
	}

	public void RemoveIfAllowed()
	{
		GradientStopSlider gradientStopSlider = LO8();
		if (gradientStopSlider == null || !gradientStopSlider.Ej0())
		{
			return;
		}
		if (Ad6.Pu9(this))
		{
			IList<GradientStopThumb> list = gradientStopSlider.Bjb();
			if (list.Count > 1)
			{
				int num = list.IndexOf(this);
				if (num != -1)
				{
					num = ((num <= 0) ? (num + 1) : (num - 1));
					list[num].Focus();
				}
			}
		}
		gradientStopSlider.RemoveSelectedStop();
	}

	[SpecialName]
	private GradientStopSlider LO8()
	{
		return VisualTreeHelperExtended.GetAncestor<GradientStopSlider>(this);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e != null && !e.Handled && Ad6.suc() == ModifierKeys.None)
		{
			switch (e.Key)
			{
			case Key.Delete:
				e.Handled = true;
				RemoveIfAllowed();
				break;
			case Key.Left:
				e.Handled = true;
				OO3(-0.01);
				break;
			case Key.Space:
				e.Handled = true;
				LO8()?.ksz(this);
				break;
			case Key.Right:
				e.Handled = true;
				OO3(0.01);
				break;
			}
		}
	}

	static GradientStopThumb()
	{
		awj.QuEwGz();
		IsDraggingProperty = DependencyProperty.Register(QdM.AR8(24436), typeof(bool), typeof(GradientStopThumb), new PropertyMetadata(false));
		IsDraggingToRemoveProperty = DependencyProperty.Register(QdM.AR8(24460), typeof(bool), typeof(GradientStopThumb), new PropertyMetadata(false));
		IsSelectedProperty = DependencyProperty.Register(QdM.AR8(22234), typeof(bool), typeof(GradientStopThumb), new PropertyMetadata(false));
	}

	internal static bool pj5()
	{
		return Tji == null;
	}

	internal static GradientStopThumb kjI()
	{
		return Tji;
	}
}
