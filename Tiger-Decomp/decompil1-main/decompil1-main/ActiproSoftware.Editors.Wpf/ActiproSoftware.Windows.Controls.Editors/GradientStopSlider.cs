using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_Checkerboard", Type = typeof(Path))]
[TemplatePart(Name = "PART_Panel", Type = typeof(Panel))]
[ContentProperty("ActiveBrush")]
public class GradientStopSlider : Control
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public GradientStopSlider VuZ;

		public GradientBrush Xut;

		internal static _003C_003Ec__DisplayClass43_0 NtC;

		public _003C_003Ec__DisplayClass43_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal void Wui()
		{
			VuZ.TrackGradientBrush = Xut;
		}

		internal static bool stE()
		{
			return NtC == null;
		}

		internal static _003C_003Ec__DisplayClass43_0 Wt3()
		{
			return NtC;
		}
	}

	private InputAdapter gjq;

	private GradientStopSliderPanel Aju;

	private DelegateCommand<object> djK;

	private DelegateCommand<object> ijR;

	private DelegateCommand<object> Qjd;

	public static readonly DependencyProperty ActiveBrushProperty;

	public static readonly DependencyProperty CanAddStopsProperty;

	public static readonly DependencyProperty CanRemoveStopsProperty;

	public static readonly DependencyProperty CanReuseBrushProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	public static readonly DependencyProperty SelectedStopIndexProperty;

	public static readonly DependencyProperty TrackGradientBrushProperty;

	public static readonly DependencyProperty TrackHeightProperty;

	internal static GradientStopSlider EBT;

	public Brush ActiveBrush
	{
		get
		{
			return (Brush)GetValue(ActiveBrushProperty);
		}
		set
		{
			SetValue(ActiveBrushProperty, value);
		}
	}

	public ICommand AddStopCommand
	{
		get
		{
			if (djK == null)
			{
				djK = new DelegateCommand<object>(delegate
				{
					AddStop();
				}, (object P_0) => CanAddStops);
			}
			return djK;
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

	public bool CanReuseBrush
	{
		get
		{
			return (bool)GetValue(CanReuseBrushProperty);
		}
		set
		{
			SetValue(CanReuseBrushProperty, value);
		}
	}

	public ICommand RemoveSelectedStopCommand
	{
		get
		{
			if (ijR == null)
			{
				ijR = new DelegateCommand<object>(delegate
				{
					RemoveSelectedStop();
				}, (object P_0) => Ej0() && SelectedStopIndex != -1);
			}
			return ijR;
		}
	}

	public ICommand ReverseStopsCommand
	{
		get
		{
			if (Qjd == null)
			{
				Qjd = new DelegateCommand<object>(delegate
				{
					ReverseStops();
				}, (object P_0) => Bjb().Count > 0);
			}
			return Qjd;
		}
	}

	public Color SelectedColor
	{
		get
		{
			return (Color)GetValue(SelectedColorProperty);
		}
		set
		{
			SetValue(SelectedColorProperty, value);
		}
	}

	public int SelectedStopIndex
	{
		get
		{
			return (int)GetValue(SelectedStopIndexProperty);
		}
		set
		{
			SetValue(SelectedStopIndexProperty, value);
		}
	}

	public GradientBrush TrackGradientBrush
	{
		get
		{
			return (GradientBrush)GetValue(TrackGradientBrushProperty);
		}
		private set
		{
			SetValue(TrackGradientBrushProperty, value);
		}
	}

	public double TrackHeight
	{
		get
		{
			return (double)GetValue(TrackHeightProperty);
		}
		set
		{
			SetValue(TrackHeightProperty, value);
		}
	}

	public GradientStopSlider()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(GradientStopSlider);
		Bse();
		base.SizeChanged += KsN;
	}

	private void Bse()
	{
		gjq = new InputAdapter(this);
		gjq.DoubleTapped += VsB;
		gjq.AttachedEventKinds = InputAdapterEventKinds.DoubleTapped;
	}

	[SpecialName]
	internal bool Ej0()
	{
		if (CanRemoveStops && ActiveBrush is GradientBrush gradientBrush)
		{
			int num = 0;
			if (pBf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (gradientBrush.GradientStops.Count > 1)
			{
				return true;
			}
		}
		return false;
	}

	private PathGeometry Nsk()
	{
		PathGeometry pathGeometry = new PathGeometry();
		double actualWidth = base.ActualWidth;
		double actualHeight = base.ActualHeight;
		int num = 6;
		int num5 = default(int);
		for (double num2 = 0.0; num2 < actualWidth; num2 += (double)num)
		{
			for (double num3 = 0.0; num3 < actualHeight; num3 += (double)num)
			{
				while ((num2 % (double)(2 * num) != 0.0 || num3 % (double)(2 * num) != (double)num) && (num2 % (double)(2 * num) != (double)num || num3 % (double)(2 * num) != 0.0))
				{
					PathFigure pathFigure = new PathFigure
					{
						IsClosed = true,
						StartPoint = new Point(num2, num3)
					};
					int num4 = 1;
					if (!qBk())
					{
						goto IL_0005;
					}
					goto IL_0009;
					IL_017e:
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2 + (double)num, num3)
					});
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2 + (double)num, num3 + (double)num)
					});
					num5 = 2;
					goto IL_0005;
					IL_0009:
					switch (num4)
					{
					case 2:
						goto IL_0153;
					case 1:
						goto IL_017e;
					}
					continue;
					IL_0153:
					pathFigure.Segments.Add(new LineSegment
					{
						Point = new Point(num2, num3 + (double)num)
					});
					pathGeometry.Figures.Add(pathFigure);
					break;
					IL_0005:
					num4 = num5;
					goto IL_0009;
				}
			}
		}
		return pathGeometry;
	}

	private static void CsE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		gradientStopSlider.ujP();
	}

	private static void Is7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		gradientStopSlider.WjM();
	}

	private static void Ds4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		gradientStopSlider.WjM();
	}

	private void VsB(object P_0, InputDoubleTappedEventArgs P_1)
	{
		if (Aju != null && CanAddStops)
		{
			double value = Math.Max(0.0, Math.Min(1.0, P_1.GetPosition(Aju).X / Aju.ActualWidth));
			AddStop(value);
		}
	}

	private static void psh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		GradientStop gradientStop = gradientStopSlider.CjT();
		Color color = (Color)P_1.NewValue;
		if (gradientStop != null && gradientStop.Color != color)
		{
			gradientStopSlider.wjC(gradientStop, color);
		}
	}

	private static void csw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		if (gradientStopSlider.Aju == null)
		{
			return;
		}
		int selectedStopIndex = gradientStopSlider.SelectedStopIndex;
		int num = 0;
		if (pBf() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		IList<GradientStopThumb> list = gradientStopSlider.Bjb();
		for (int i = 0; i < list.Count; i++)
		{
			list[i].IsSelected = i == selectedStopIndex;
		}
		gradientStopSlider.Ejs();
	}

	private void KsN(object P_0, SizeChangedEventArgs P_1)
	{
		zj6();
	}

	private static void bsU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GradientStopSlider gradientStopSlider = (GradientStopSlider)P_0;
		gradientStopSlider.Jjj();
	}

	[SpecialName]
	private GradientStopSliderPanel Ejg()
	{
		return Aju;
	}

	[SpecialName]
	private void Rjo(GradientStopSliderPanel value)
	{
		Aju = value;
	}

	[SpecialName]
	private GradientStop CjT()
	{
		int selectedStopIndex = SelectedStopIndex;
		GradientBrush gradientBrush = ActiveBrush as GradientBrush;
		int num = 0;
		if (pBf() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (gradientBrush != null && selectedStopIndex >= 0 && selectedStopIndex < gradientBrush.GradientStops.Count)
			{
				return gradientBrush.GradientStops[selectedStopIndex];
			}
			return null;
		}
	}

	internal void ksz(GradientStopThumb P_0)
	{
		if (P_0 != null)
		{
			int num = Bjb().IndexOf(P_0);
			if (num != -1)
			{
				SelectedStopIndex = num;
			}
		}
	}

	[SpecialName]
	internal IList<GradientStopThumb> Bjb()
	{
		if (Aju != null)
		{
			return Aju.Children.OfType<GradientStopThumb>().ToArray();
		}
		return new GradientStopThumb[0];
	}

	private void xjQ(IEnumerable<GradientStop> P_0)
	{
		GradientBrush gradientBrush = ActiveBrush as GradientBrush;
		if (gradientBrush != null && P_0 != null)
		{
			if (!CanReuseBrush || gradientBrush == null || gradientBrush.IsFrozen)
			{
				gradientBrush = ((!(gradientBrush is LinearGradientBrush linearGradientBrush)) ? ((GradientBrush)((!(gradientBrush is RadialGradientBrush)) ? null : new RadialGradientBrush())) : ((GradientBrush)new LinearGradientBrush
				{
					StartPoint = linearGradientBrush.StartPoint,
					EndPoint = linearGradientBrush.EndPoint
				}));
			}
			else
			{
				gradientBrush.GradientStops.Clear();
			}
			if (gradientBrush != null)
			{
				foreach (GradientStop item in P_0)
				{
					gradientBrush.GradientStops.Add(new GradientStop
					{
						Offset = item.Offset,
						Color = item.Color
					});
				}
			}
		}
		if (!CanReuseBrush && gradientBrush != null && ActiveBrush != gradientBrush)
		{
			ActiveBrush = gradientBrush;
		}
		else
		{
			ujP();
		}
		Jjj();
		Ejs();
	}

	internal void IjV(GradientStop P_0, double P_1)
	{
		if (!(ActiveBrush is GradientBrush gradientBrush))
		{
			return;
		}
		GradientStop[] array = gradientBrush.GradientStops.ToArray();
		int num = Array.IndexOf(array, P_0);
		if (num != -1)
		{
			int num2 = 0;
			if (!qBk())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			array[num] = new GradientStop
			{
				Offset = P_1,
				Color = P_0.Color
			};
			xjQ(array);
		}
	}

	internal void wjC(GradientStop P_0, Color P_1)
	{
		if (ActiveBrush is GradientBrush gradientBrush)
		{
			GradientStop[] array = gradientBrush.GradientStops.ToArray();
			int num = Array.IndexOf(array, P_0);
			if (num != -1)
			{
				array[num] = new GradientStop
				{
					Offset = P_0.Offset,
					Color = P_1
				};
				xjQ(array);
			}
		}
	}

	private void zj6()
	{
		if (GetTemplateChild(QdM.AR8(19632)) is Path path)
		{
			path.Data = Nsk();
		}
	}

	private void WjM()
	{
		djK?.RaiseCanExecuteChanged();
		ijR?.RaiseCanExecuteChanged();
		Qjd?.RaiseCanExecuteChanged();
	}

	private void Ejs()
	{
		int selectedStopIndex = SelectedStopIndex;
		IList<GradientStopThumb> list = Bjb();
		if (selectedStopIndex >= 0 && selectedStopIndex < list.Count && list[selectedStopIndex].DataContext is GradientStop gradientStop)
		{
			SelectedColor = gradientStop.Color;
		}
	}

	private void Jjj()
	{
		if (Aju == null)
		{
			SelectedStopIndex = -1;
			return;
		}
		if (!(ActiveBrush is GradientBrush gradientBrush))
		{
			Aju.Children.Clear();
			SelectedStopIndex = -1;
			return;
		}
		IList<GradientStopThumb> list = Bjb();
		int count = gradientBrush.GradientStops.Count;
		for (int i = 0; i < Math.Max(list.Count, count); i++)
		{
			if (i < count)
			{
				GradientStop gradientStop = gradientBrush.GradientStops[i];
				if (i < list.Count)
				{
					GradientStopThumb gradientStopThumb = list[i];
					gradientStopThumb.Background = new SolidColorBrush
					{
						Color = gradientStop.Color
					};
					gradientStopThumb.DataContext = gradientStop;
					gradientStopThumb.TabIndex = i;
					Aju.InvalidateArrange();
				}
				else
				{
					Aju.Children.Add(new GradientStopThumb
					{
						Background = new SolidColorBrush
						{
							Color = gradientStop.Color
						},
						DataContext = gradientStop,
						TabIndex = i
					});
				}
			}
			else
			{
				Aju.Children.Remove(list[i]);
			}
		}
		SelectedStopIndex = Math.Max(-1, Math.Min(count - 1, Math.Max(0, SelectedStopIndex)));
	}

	private void ujP()
	{
		_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass43_0();
		CS_0024_003C_003E8__locals8.VuZ = this;
		CS_0024_003C_003E8__locals8.Xut = ActiveBrush as GradientBrush;
		if (CS_0024_003C_003E8__locals8.Xut != null)
		{
			GradientBrush gradientBrush = CS_0024_003C_003E8__locals8.Xut;
			CS_0024_003C_003E8__locals8.Xut = new LinearGradientBrush
			{
				EndPoint = new Point(1.0, 0.0)
			};
			foreach (GradientStop gradientStop in gradientBrush.GradientStops)
			{
				CS_0024_003C_003E8__locals8.Xut.GradientStops.Add(new GradientStop
				{
					Offset = gradientStop.Offset,
					Color = gradientStop.Color
				});
			}
		}
		base.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
		{
			CS_0024_003C_003E8__locals8.VuZ.TrackGradientBrush = CS_0024_003C_003E8__locals8.Xut;
		});
		WjM();
	}

	public void AddStop()
	{
		AddStop(null);
	}

	public void AddStop(double? stopOffset)
	{
		if (!(ActiveBrush is GradientBrush { IsFrozen: false } gradientBrush))
		{
			return;
		}
		int i = 0;
		List<GradientStop> list = gradientBrush.GradientStops.ToList();
		if (stopOffset.HasValue)
		{
			double num;
			for (num = Math.Max(0.0, Math.Min(1.0, stopOffset.Value)); i < list.Count && !(num <= list[i].Offset); i++)
			{
			}
			list.Insert(i, new GradientStop
			{
				Offset = num,
				Color = SelectedColor
			});
		}
		else if (list.Count > 1)
		{
			int num2 = Math.Max(0, Math.Min(list.Count - 1, SelectedStopIndex));
			int num3 = num2;
			int num4 = num2 + 1;
			if (num4 >= list.Count)
			{
				num3--;
				num4--;
			}
			i = num4;
			list.Insert(i, new GradientStop
			{
				Offset = Math.Min(list[num3].Offset, list[num4].Offset) + (Math.Max(list[num3].Offset, list[num4].Offset) - Math.Min(list[num3].Offset, list[num4].Offset)) / 2.0,
				Color = SelectedColor
			});
		}
		else
		{
			bool flag = list.Count > 0 && list[0].Offset == 0.0;
			double offset = (flag ? 1.0 : 0.0);
			i = (flag ? list.Count : 0);
			list.Insert(i, new GradientStop
			{
				Offset = offset,
				Color = SelectedColor
			});
		}
		xjQ(list);
		SelectedStopIndex = i;
	}

	protected override Size MeasureOverride(Size constraint)
	{
		Size result = base.MeasureOverride(constraint);
		if (double.IsPositiveInfinity(constraint.Width))
		{
			result.Width = 200.0;
		}
		return result;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Rjo(GetTemplateChild(QdM.AR8(19670)) as GradientStopSliderPanel);
		Jjj();
		WjM();
		zj6();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new GradientStopSliderAutomationPeer(this);
	}

	public void Refresh()
	{
		ujP();
		Jjj();
		Ejs();
	}

	public void RemoveSelectedStop()
	{
		if (!(ActiveBrush is GradientBrush { IsFrozen: false } gradientBrush))
		{
			return;
		}
		int selectedStopIndex = SelectedStopIndex;
		List<GradientStop> list = gradientBrush.GradientStops.ToList();
		if (selectedStopIndex >= 0 && selectedStopIndex < list.Count)
		{
			int num = 0;
			if (pBf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			list.RemoveAt(selectedStopIndex);
			xjQ(list);
		}
	}

	public void ReverseStops()
	{
		if (!(ActiveBrush is GradientBrush gradientBrush))
		{
			return;
		}
		GradientStop[] array = gradientBrush.GradientStops.Reverse().ToArray();
		GradientStop[] array2 = array;
		int num2 = default(int);
		foreach (GradientStop gradientStop in array2)
		{
			gradientStop.Offset = Math.Max(0.0, Math.Min(1.0, 1.0 - gradientStop.Offset));
			int num = 0;
			if (pBf() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
		}
		xjQ(array);
	}

	static GradientStopSlider()
	{
		awj.QuEwGz();
		ActiveBrushProperty = DependencyProperty.Register(QdM.AR8(19694), typeof(Brush), typeof(GradientStopSlider), new PropertyMetadata(null, CsE));
		CanAddStopsProperty = DependencyProperty.Register(QdM.AR8(19720), typeof(bool), typeof(GradientStopSlider), new PropertyMetadata(true, Is7));
		CanRemoveStopsProperty = DependencyProperty.Register(QdM.AR8(19746), typeof(bool), typeof(GradientStopSlider), new PropertyMetadata(true, Ds4));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		CanReuseBrushProperty = DependencyProperty.Register(QdM.AR8(1218), typeof(bool), typeof(GradientStopSlider), new PropertyMetadata(true));
		SelectedColorProperty = DependencyProperty.Register(QdM.AR8(1798), typeof(Color), typeof(GradientStopSlider), new PropertyMetadata(VdT.abb, psh));
		SelectedStopIndexProperty = DependencyProperty.Register(QdM.AR8(19778), typeof(int), typeof(GradientStopSlider), new PropertyMetadata(-1, csw));
		TrackGradientBrushProperty = DependencyProperty.Register(QdM.AR8(19816), typeof(Brush), typeof(GradientStopSlider), new PropertyMetadata(null, bsU));
		TrackHeightProperty = DependencyProperty.Register(QdM.AR8(19856), typeof(double), typeof(GradientStopSlider), new PropertyMetadata(12.0));
	}

	[CompilerGenerated]
	private void Cj2(object P_0)
	{
		AddStop();
	}

	[CompilerGenerated]
	private bool aja(object P_0)
	{
		return CanAddStops;
	}

	[CompilerGenerated]
	private void Rjf(object P_0)
	{
		RemoveSelectedStop();
	}

	[CompilerGenerated]
	private bool Xjl(object P_0)
	{
		return Ej0() && SelectedStopIndex != -1;
	}

	[CompilerGenerated]
	private void AjX(object P_0)
	{
		ReverseStops();
	}

	[CompilerGenerated]
	private bool ajx(object P_0)
	{
		return Bjb().Count > 0;
	}

	internal static bool qBk()
	{
		return EBT == null;
	}

	internal static GradientStopSlider pBf()
	{
		return EBT;
	}
}
