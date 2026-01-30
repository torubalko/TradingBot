using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.ColorSelection.Primitives;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection;

[TemplatePart(Name = "PART_ThumbPanel", Type = typeof(GradientBrushThumbPanel))]
[TemplatePart(Name = "PART_Spectrum", Type = typeof(FrameworkElement))]
public class GradientBrushSlider : Control
{
	private FrameworkElement FZE;

	private GradientBrushThumbPanel tZs;

	private int VZL;

	private bool DZd;

	public static readonly RoutedEvent SelectedBrushChangedEvent;

	private static readonly DependencyPropertyKey wZN;

	private static readonly DependencyPropertyKey zZM;

	public static readonly DependencyProperty ActiveGradientBrushProperty;

	public static readonly DependencyProperty CanAddStopsProperty;

	public static readonly DependencyProperty CanRemoveStopsProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty SelectedBrushProperty;

	public static readonly DependencyProperty SelectedStopProperty;

	private static RoutedCommand EZK;

	private static RoutedCommand xZg;

	private static RoutedCommand xZ8;

	private static GradientBrushSlider tbh;

	public static RoutedCommand AddStopCommand => EZK;

	public static RoutedCommand RemoveStopCommand => xZg;

	public static RoutedCommand ReverseStopsCommand => xZ8;

	public Brush ActiveGradientBrush
	{
		get
		{
			return (Brush)GetValue(ActiveGradientBrushProperty);
		}
		private set
		{
			SetValue(wZN, value);
		}
	}

	public bool CanAddStops
	{
		get
		{
			return (bool)GetValue(CanAddStopsProperty);
		}
		set
		{
			SetValue(CanAddStopsProperty, value);
		}
	}

	public bool CanRemoveStops
	{
		get
		{
			return (bool)GetValue(CanRemoveStopsProperty);
		}
		set
		{
			SetValue(CanRemoveStopsProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public Brush SelectedBrush
	{
		get
		{
			return (Brush)GetValue(SelectedBrushProperty);
		}
		set
		{
			SetValue(SelectedBrushProperty, value);
		}
	}

	public GradientStop SelectedStop
	{
		get
		{
			return (GradientStop)GetValue(SelectedStopProperty);
		}
		private set
		{
			SetValue(zZM, value);
		}
	}

	[Description("Occurs when the value of the SelectedBrush property is changed.")]
	public event RoutedPropertyChangedEventHandler<Brush> SelectedBrushChanged
	{
		add
		{
			AddHandler(SelectedBrushChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectedBrushChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static GradientBrushSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedBrushChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122130), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Brush>), typeof(GradientBrushSlider));
		wZN = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122036), typeof(Brush), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(null, NZY));
		int num = 0;
		if (false)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
				SelectedStopProperty = zZM.DependencyProperty;
				EZK = new RoutedCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122290), typeof(GradientBrushSlider));
				xZg = new RoutedCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122308), typeof(GradientBrushSlider));
				xZ8 = new RoutedCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122332), typeof(GradientBrushSlider));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(GradientBrushSlider), new FrameworkPropertyMetadata(typeof(GradientBrushSlider)));
				Control.IsTabStopProperty.OverrideMetadata(typeof(GradientBrushSlider), new FrameworkPropertyMetadata(false));
				EventManager.RegisterClassHandler(typeof(GradientBrushSlider), GradientBrushThumb.SelectedEvent, new RoutedEventHandler(iZH));
				EventManager.RegisterClassHandler(typeof(GradientBrushSlider), GradientBrushThumb.UnselectedEvent, new RoutedEventHandler(IZ6));
				CommandManager.RegisterClassCommandBinding(typeof(GradientBrushSlider), new CommandBinding(AddStopCommand, zZx, FZI));
				CommandManager.RegisterClassCommandBinding(typeof(GradientBrushSlider), new CommandBinding(RemoveStopCommand, nZn, oZZ));
				CommandManager.RegisterClassCommandBinding(typeof(GradientBrushSlider), new CommandBinding(ReverseStopsCommand, XZa));
				return;
			}
			zZM = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122174), typeof(GradientStop), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(null));
			ActiveGradientBrushProperty = wZN.DependencyProperty;
			CanAddStopsProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122202), typeof(bool), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(true));
			CanRemoveStopsProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122228), typeof(bool), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(true));
			OrientationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116030), typeof(Orientation), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(Orientation.Horizontal, IZr));
			SelectedBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122260), typeof(Brush), typeof(GradientBrushSlider), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, JZW));
			num = 1;
		}
		while (0 == 0);
		goto IL_0005;
	}

	public GradientBrushSlider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DZd = true;
		base._002Ector();
		UpdateSlider();
	}

	private void MZC(object P_0, EventArgs P_1)
	{
		xZV();
	}

	private static void NZY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is GradientBrushSlider gradientBrushSlider)
		{
			if (P_1.OldValue is Brush brush)
			{
				brush.Changed -= gradientBrushSlider.MZC;
			}
			if (P_1.NewValue is Brush brush2)
			{
				brush2.Changed += gradientBrushSlider.MZC;
			}
		}
	}

	private static void FZI(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		P_1.CanExecute = false;
		P_1.Handled = true;
		if (P_0 is GradientBrushSlider { CanAddStops: not false } gradientBrushSlider && gradientBrushSlider.SelectedBrush is GradientBrush)
		{
			P_1.CanExecute = true;
		}
	}

	private static void zZx(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is GradientBrushSlider gradientBrushSlider)
		{
			gradientBrushSlider.AddStop();
		}
	}

	private static void IZr(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is GradientBrushSlider gradientBrushSlider)
		{
			gradientBrushSlider.UpdateSlider();
		}
	}

	private static void oZZ(object P_0, CanExecuteRoutedEventArgs P_1)
	{
		P_1.CanExecute = false;
		P_1.Handled = true;
		if (!(P_0 is GradientBrushSlider { CanRemoveStops: not false, ActiveGradientBrush: GradientBrush activeGradientBrush } gradientBrushSlider))
		{
			return;
		}
		if (P_1.Parameter is int)
		{
			int num = (int)P_1.Parameter;
			if (num >= 0 && num < activeGradientBrush.GradientStops.Count)
			{
				P_1.CanExecute = true;
			}
		}
		else
		{
			GradientStop gradientStop = (P_1.Parameter as GradientStop) ?? gradientBrushSlider.SelectedStop;
			if (gradientStop != null)
			{
				P_1.CanExecute = true;
			}
		}
	}

	private static void nZn(object P_0, ExecutedRoutedEventArgs P_1)
	{
		GradientBrushSlider gradientBrushSlider = P_0 as GradientBrushSlider;
		bool flag = gradientBrushSlider != null;
		int num = 1;
		if (!ybP())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		GradientBrush gradientBrush = default(GradientBrush);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag)
				{
					gradientBrush = gradientBrushSlider.ActiveGradientBrush as GradientBrush;
					flag2 = gradientBrush != null;
					num = 0;
					if (ybP())
					{
						continue;
					}
					goto end_IL_0009;
				}
				return;
			}
			if (!flag2)
			{
				return;
			}
			if (P_1.Parameter is int)
			{
				int num3 = (int)P_1.Parameter;
				if (num3 >= 0 && num3 < gradientBrush.GradientStops.Count)
				{
					gradientBrush.GradientStops.RemoveAt(num3);
					gradientBrushSlider.UpdateSlider();
				}
			}
			else
			{
				GradientStop gradientStop = (P_1.Parameter as GradientStop) ?? gradientBrushSlider.SelectedStop;
				if (gradientStop != null)
				{
					gradientBrush.GradientStops.Remove(gradientStop);
					gradientBrushSlider.UpdateSlider();
				}
			}
			return;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0005;
	}

	private static void XZa(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_0 is GradientBrushSlider gradientBrushSlider)
		{
			gradientBrushSlider.ReverseStops();
		}
	}

	private void oZq(object P_0, EventArgs P_1)
	{
		if (DZd)
		{
			UpdateSlider();
		}
	}

	private static void JZW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is GradientBrushSlider gradientBrushSlider)
		{
			Brush brush = P_1.OldValue as Brush;
			if (brush != null && !brush.IsFrozen)
			{
				brush.Changed -= gradientBrushSlider.oZq;
			}
			Brush brush2 = P_1.NewValue as Brush;
			if (brush2 != null && !brush2.IsFrozen)
			{
				brush2.Changed += gradientBrushSlider.oZq;
			}
			if (gradientBrushSlider.DZd)
			{
				gradientBrushSlider.UpdateSlider();
			}
			gradientBrushSlider.OnSelectedBrushChanged(brush, brush2);
		}
	}

	private void sZU(object P_0, MouseButtonEventArgs P_1)
	{
		if (FZE == null || !CanAddStops)
		{
			return;
		}
		int num2 = default(int);
		while (true)
		{
			Point position = P_1.GetPosition(FZE);
			double value = 0.0;
			int num = 1;
			if (!ybP())
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				if (Orientation == Orientation.Horizontal && FZE.ActualWidth != 0.0)
				{
					value = position.X / FZE.ActualWidth;
				}
				else if (FZE.ActualHeight != 0.0)
				{
					value = position.Y / FZE.ActualHeight;
				}
				AddStop(value.Range(0.0, 1.0));
				P_1.Handled = true;
				return;
			}
		}
	}

	private static void iZH(object P_0, RoutedEventArgs P_1)
	{
		GradientBrushSlider gradientBrushSlider = P_0 as GradientBrushSlider;
		GradientBrushThumb gradientBrushThumb = P_1.OriginalSource as GradientBrushThumb;
		if (gradientBrushSlider == null || gradientBrushThumb == null)
		{
			return;
		}
		gradientBrushSlider.SelectedStop = gradientBrushThumb.Stop;
		if (gradientBrushSlider.tZs == null)
		{
			return;
		}
		foreach (UIElement child in gradientBrushSlider.tZs.Children)
		{
			if (child is GradientBrushThumb gradientBrushThumb2 && gradientBrushThumb2 != gradientBrushThumb)
			{
				gradientBrushThumb2.IsSelected = false;
			}
		}
	}

	private static void IZ6(object P_0, RoutedEventArgs P_1)
	{
		GradientBrushSlider gradientBrushSlider = P_0 as GradientBrushSlider;
		GradientBrushThumb gradientBrushThumb = P_1.OriginalSource as GradientBrushThumb;
		if (gradientBrushSlider != null && gradientBrushThumb != null && gradientBrushSlider.SelectedStop == gradientBrushThumb.Stop)
		{
			gradientBrushSlider.SelectedStop = null;
		}
	}

	private void xZV()
	{
		DZd = false;
		try
		{
			if (!(ActiveGradientBrush is GradientBrush gradientBrush))
			{
				return;
			}
			if (!(SelectedBrush is GradientBrush gradientBrush2))
			{
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
				foreach (GradientStop gradientStop in gradientBrush.GradientStops)
				{
					linearGradientBrush.GradientStops.Add(gradientStop.CloneCurrentValue());
				}
				if (linearGradientBrush.CanFreeze)
				{
					linearGradientBrush.Freeze();
				}
				SelectedBrush = linearGradientBrush;
				return;
			}
			GradientBrush gradientBrush3 = gradientBrush2.CloneCurrentValue();
			if (gradientBrush3 == null)
			{
				return;
			}
			gradientBrush3.GradientStops.Clear();
			foreach (GradientStop gradientStop2 in gradientBrush.GradientStops)
			{
				gradientBrush3.GradientStops.Add(gradientStop2.CloneCurrentValue());
			}
			if (gradientBrush3.CanFreeze)
			{
				gradientBrush3.Freeze();
			}
			SelectedBrush = gradientBrush3;
		}
		finally
		{
			DZd = true;
		}
	}

	internal void UpdateSlider()
	{
		if (tZs != null)
		{
			tZs.Children.Clear();
		}
		SelectedStop = null;
		int vZL = VZL;
		VZL = 0;
		if (!(SelectedBrush is GradientBrush gradientBrush))
		{
			ActiveGradientBrush = null;
			return;
		}
		bool flag = Orientation == Orientation.Horizontal;
		LinearGradientBrush linearGradientBrush = new LinearGradientBrush
		{
			StartPoint = new Point(0.0, 0.0),
			EndPoint = (flag ? new Point(1.0, 0.0) : new Point(0.0, 1.0))
		};
		for (int i = 0; i < gradientBrush.GradientStops.Count; i++)
		{
			GradientStop gradientStop = gradientBrush.GradientStops[i].CloneCurrentValue();
			linearGradientBrush.GradientStops.Add(gradientStop);
			if (vZL == i)
			{
				SelectedStop = gradientStop;
			}
			if (tZs != null)
			{
				GradientBrushThumb gradientBrushThumb = new GradientBrushThumb
				{
					Stop = gradientStop,
					IsSelected = (vZL == i)
				};
				gradientBrushThumb.SetBinding(Control.BackgroundProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114108))
				{
					Source = gradientStop,
					Converter = new DelegateConverter
					{
						ConvertCallback = (object value, Type targetType, object parameter, CultureInfo culture) => (value is Color) ? ((Color)value).ToSolidColorBrush() : null
					}
				});
				gradientBrushThumb.SetBinding(GradientBrushThumbPanel.OffsetProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122360))
				{
					Source = gradientStop
				});
				gradientBrushThumb.SetBinding(GradientBrushThumb.OrientationProperty, new Binding(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116030))
				{
					Source = this
				});
				tZs.Children.Add(gradientBrushThumb);
			}
		}
		ActiveGradientBrush = linearGradientBrush;
	}

	public void AddStop()
	{
		GradientBrush gradientBrush = ((SelectedBrush is GradientBrush gradientBrush2) ? gradientBrush2.CloneCurrentValue() : new LinearGradientBrush
		{
			StartPoint = new Point(0.0, 0.0),
			EndPoint = new Point(1.0, 0.0)
		});
		if (gradientBrush.GradientStops.Count == 0)
		{
			gradientBrush.GradientStops.Add(new GradientStop
			{
				Color = Colors.White,
				Offset = 0.5
			});
		}
		else if (gradientBrush.GradientStops.Count == 1)
		{
			GradientStop gradientStop = gradientBrush.GradientStops[0];
			gradientBrush.GradientStops.Add(new GradientStop
			{
				Color = gradientStop.Color,
				Offset = gradientStop.Offset + (1.0 - gradientStop.Offset) / 2.0
			});
		}
		else
		{
			List<GradientStop> list = gradientBrush.GradientStops.OrderBy((GradientStop x) => x.Offset).ToList();
			GradientStop gradientStop2 = list[0];
			GradientStop gradientStop3 = list[1];
			GradientStop selectedStop = SelectedStop;
			if (selectedStop != null && list.Count != 2 && (selectedStop.Offset != list[0].Offset || selectedStop.Color != list[0].Color))
			{
				for (int num = 1; num < list.Count - 1; num++)
				{
					if (selectedStop.Offset == list[num].Offset || selectedStop.Color == list[num].Color)
					{
						gradientStop2 = list[num];
						gradientStop3 = list[num + 1];
						break;
					}
				}
			}
			if (gradientStop2 != null && gradientStop3 != null)
			{
				double offset = gradientStop2.Offset + (gradientStop3.Offset - gradientStop2.Offset) / 2.0;
				Color color = Color.FromArgb((byte)((double)(int)gradientStop2.Color.A + (double)(gradientStop3.Color.A - gradientStop2.Color.A) * 0.5), (byte)((double)(int)gradientStop2.Color.R + (double)(gradientStop3.Color.R - gradientStop2.Color.R) * 0.5), (byte)((double)(int)gradientStop2.Color.G + (double)(gradientStop3.Color.G - gradientStop2.Color.G) * 0.5), (byte)((double)(int)gradientStop2.Color.B + (double)(gradientStop3.Color.B - gradientStop2.Color.B) * 0.5));
				VZL = gradientBrush.GradientStops.Count;
				gradientBrush.GradientStops.Add(new GradientStop
				{
					Color = color,
					Offset = offset
				});
			}
		}
		if (gradientBrush.CanFreeze)
		{
			gradientBrush.Freeze();
		}
		SelectedBrush = gradientBrush;
	}

	public void AddStop(double offset)
	{
		if (offset < 0.0 || offset > 1.0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122376));
		}
		GradientBrush gradientBrush = ((SelectedBrush is GradientBrush gradientBrush2) ? gradientBrush2.CloneCurrentValue() : new LinearGradientBrush
		{
			StartPoint = new Point(0.0, 0.0),
			EndPoint = new Point(1.0, 0.0)
		});
		if (gradientBrush.GradientStops.Count == 0)
		{
			gradientBrush.GradientStops.Add(new GradientStop
			{
				Color = Colors.White,
				Offset = offset
			});
		}
		else if (gradientBrush.GradientStops.Count == 1)
		{
			GradientStop gradientStop = gradientBrush.GradientStops[0];
			gradientBrush.GradientStops.Add(new GradientStop
			{
				Color = gradientStop.Color,
				Offset = offset
			});
		}
		else
		{
			List<GradientStop> list = gradientBrush.GradientStops.OrderBy((GradientStop x) => x.Offset).ToList();
			GradientStop gradientStop2 = null;
			GradientStop gradientStop3 = null;
			for (int num = 0; num < list.Count; num++)
			{
				if (num == list.Count - 1 && list[num].Offset <= offset)
				{
					gradientStop2 = list[num];
					gradientStop3 = null;
					break;
				}
				gradientStop2 = gradientStop3;
				gradientStop3 = list[num];
				if (list[num].Offset > offset)
				{
					break;
				}
			}
			Color color = Colors.White;
			if (gradientStop2 != null && gradientStop3 != null)
			{
				if (gradientStop2.Offset == gradientStop3.Offset)
				{
					color = gradientStop2.Color;
				}
				else
				{
					double num2 = (offset - gradientStop2.Offset) / (gradientStop3.Offset - gradientStop2.Offset);
					color = Color.FromArgb((byte)((double)(int)gradientStop2.Color.A + (double)(gradientStop3.Color.A - gradientStop2.Color.A) * num2), (byte)((double)(int)gradientStop2.Color.R + (double)(gradientStop3.Color.R - gradientStop2.Color.R) * num2), (byte)((double)(int)gradientStop2.Color.G + (double)(gradientStop3.Color.G - gradientStop2.Color.G) * num2), (byte)((double)(int)gradientStop2.Color.B + (double)(gradientStop3.Color.B - gradientStop2.Color.B) * num2));
				}
			}
			else if (gradientStop2 != null)
			{
				color = gradientStop2.Color;
			}
			else if (gradientStop3 != null)
			{
				color = gradientStop3.Color;
			}
			VZL = gradientBrush.GradientStops.Count;
			gradientBrush.GradientStops.Add(new GradientStop
			{
				Color = color,
				Offset = offset
			});
		}
		if (gradientBrush.CanFreeze)
		{
			gradientBrush.Freeze();
		}
		SelectedBrush = gradientBrush;
	}

	public void InvalidateThumbArrange()
	{
		if (tZs != null)
		{
			tZs.InvalidateArrange();
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		bool flag = FZE != null;
		int num = 0;
		if (pbW() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			FZE.MouseDown -= sZU;
		}
		FZE = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122392)) as FrameworkElement;
		if (FZE != null)
		{
			FZE.MouseDown += sZU;
		}
		tZs = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122422)) as GradientBrushThumbPanel;
		UpdateSlider();
	}

	protected virtual void OnSelectedBrushChanged(Brush oldValue, Brush newValue)
	{
		RoutedPropertyChangedEventArgs<Brush> e = new RoutedPropertyChangedEventArgs<Brush>(oldValue, newValue, SelectedBrushChangedEvent);
		e.Source = this;
		RaiseEvent(e);
	}

	public bool RemoveSelectedStop()
	{
		int num = 1;
		GradientBrush gradientBrush = default(GradientBrush);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					GradientStop selectedStop = SelectedStop;
					if (gradientBrush != null && selectedStop != null && gradientBrush.GradientStops.Remove(selectedStop))
					{
						UpdateSlider();
						return true;
					}
					return false;
				}
				}
				gradientBrush = ActiveGradientBrush as GradientBrush;
				num2 = 0;
			}
			while (ybP());
		}
	}

	public void ReverseStops()
	{
		if (!(SelectedBrush is GradientBrush gradientBrush))
		{
			return;
		}
		GradientBrush gradientBrush2 = gradientBrush.CloneCurrentValue();
		foreach (GradientStop gradientStop in gradientBrush2.GradientStops)
		{
			gradientStop.Offset = (1.0 - gradientStop.Offset).Range(0.0, 1.0);
		}
		if (gradientBrush2.CanFreeze)
		{
			gradientBrush2.Freeze();
		}
		SelectedBrush = gradientBrush2;
		int num = 0;
		if (!ybP())
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

	internal static bool ybP()
	{
		return tbh == null;
	}

	internal static GradientBrushSlider pbW()
	{
		return tbh;
	}
}
