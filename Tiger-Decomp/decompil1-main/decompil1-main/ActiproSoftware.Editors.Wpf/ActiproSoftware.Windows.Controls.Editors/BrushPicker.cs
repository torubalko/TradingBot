using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_GradientStopSlider", Type = typeof(GradientStopSlider))]
[TemplatePart(Name = "PART_BrushKindSelector", Type = typeof(Selector))]
public class BrushPicker : PickerBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public BrushPicker guF;

		private static _003C_003Ec__DisplayClass29_0 otr;

		public _003C_003Ec__DisplayClass29_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal void guL()
		{
			guF.wVG();
		}

		internal static bool Pta()
		{
			return otr == null;
		}

		internal static _003C_003Ec__DisplayClass29_0 Wtj()
		{
			return otr;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public BrushPicker yu3;

		internal static _003C_003Ec__DisplayClass30_0 atG;

		public _003C_003Ec__DisplayClass30_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal void kuA()
		{
			yu3.jVq();
		}

		internal static bool WtJ()
		{
			return atG == null;
		}

		internal static _003C_003Ec__DisplayClass30_0 Tth()
		{
			return atG;
		}
	}

	private Selector bVr;

	private GradientStopSlider aVv;

	private bool vVp;

	public static readonly DependencyProperty AddGradientStopButtonToolTipProperty;

	public static readonly DependencyProperty BrushKindProperty;

	public static readonly DependencyProperty CanReuseBrushProperty;

	public static readonly DependencyProperty IsAlphaEnabledProperty;

	public static readonly DependencyProperty IsGradientProperty;

	public static readonly DependencyProperty IsGradientAllowedProperty;

	public static readonly DependencyProperty IsNullProperty;

	public static readonly DependencyProperty IsNullAllowedProperty;

	public static readonly DependencyProperty RemoveGradientStopButtonToolTipProperty;

	public static readonly DependencyProperty ReverseGradientStopsButtonToolTipProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	public static readonly DependencyProperty ValueProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler wVW;

	internal static BrushPicker QX;

	public object AddGradientStopButtonToolTip
	{
		get
		{
			return GetValue(AddGradientStopButtonToolTipProperty);
		}
		set
		{
			SetValue(AddGradientStopButtonToolTipProperty, value);
		}
	}

	public BrushKind BrushKind
	{
		get
		{
			return (BrushKind)GetValue(BrushKindProperty);
		}
		private set
		{
			SetValue(BrushKindProperty, value);
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

	public bool IsAlphaEnabled
	{
		get
		{
			return (bool)GetValue(IsAlphaEnabledProperty);
		}
		set
		{
			SetValue(IsAlphaEnabledProperty, value);
		}
	}

	public bool IsGradient
	{
		get
		{
			return (bool)GetValue(IsGradientProperty);
		}
		private set
		{
			SetValue(IsGradientProperty, value);
		}
	}

	public bool IsGradientAllowed
	{
		get
		{
			return (bool)GetValue(IsGradientAllowedProperty);
		}
		set
		{
			SetValue(IsGradientAllowedProperty, value);
		}
	}

	public bool IsNull
	{
		get
		{
			return (bool)GetValue(IsNullProperty);
		}
		private set
		{
			SetValue(IsNullProperty, value);
		}
	}

	public bool IsNullAllowed
	{
		get
		{
			return (bool)GetValue(IsNullAllowedProperty);
		}
		set
		{
			SetValue(IsNullAllowedProperty, value);
		}
	}

	public object RemoveGradientStopButtonToolTip
	{
		get
		{
			return GetValue(RemoveGradientStopButtonToolTipProperty);
		}
		set
		{
			SetValue(RemoveGradientStopButtonToolTipProperty, value);
		}
	}

	public object ReverseGradientStopsButtonToolTip
	{
		get
		{
			return GetValue(ReverseGradientStopsButtonToolTipProperty);
		}
		set
		{
			SetValue(ReverseGradientStopsButtonToolTipProperty, value);
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

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Brush Value
	{
		get
		{
			return (Brush)GetValue(ValueProperty);
		}
		set
		{
			SetValue(ValueProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = wVW;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wVW, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = wVW;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wVW, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BrushPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(BrushPicker);
	}

	[SpecialName]
	private Selector TVL()
	{
		return bVr;
	}

	[SpecialName]
	private void HVF(Selector value)
	{
		if (bVr == value)
		{
			return;
		}
		bool flag = bVr != null;
		int num = 0;
		if (!lK())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			bVr.SelectionChanged -= oVu;
		}
		bVr = value;
		if (bVr != null)
		{
			bVr.SelectionChanged += oVu;
		}
	}

	private void iVb(BrushKind P_0)
	{
		switch (P_0)
		{
		case BrushKind.SolidColor:
			Value = new SolidColorBrush
			{
				Color = SelectedColor
			};
			break;
		case BrushKind.HorizontalLinearGradient:
		case BrushKind.VerticalLinearGradient:
		case BrushKind.DiagonalDownwardLinearGradient:
		case BrushKind.DiagonalUpwardLinearGradient:
		{
			Point startPoint = new Point(0.0, 0.0);
			Point endPoint = new Point(1.0, 0.0);
			switch (P_0)
			{
			case BrushKind.VerticalLinearGradient:
				endPoint = new Point(0.0, 1.0);
				break;
			case BrushKind.DiagonalDownwardLinearGradient:
				endPoint = new Point(1.0, 1.0);
				break;
			case BrushKind.DiagonalUpwardLinearGradient:
				startPoint = new Point(0.0, 1.0);
				break;
			}
			LinearGradientBrush linearGradientBrush = Value as LinearGradientBrush;
			if (CanReuseBrush && linearGradientBrush != null && !linearGradientBrush.IsFrozen)
			{
				linearGradientBrush.StartPoint = startPoint;
				linearGradientBrush.EndPoint = endPoint;
				break;
			}
			GradientBrush gradientBrush2 = Value as GradientBrush;
			linearGradientBrush = new LinearGradientBrush
			{
				StartPoint = startPoint,
				EndPoint = endPoint
			};
			if (gradientBrush2 != null && gradientBrush2.GradientStops.Count > 0)
			{
				foreach (GradientStop gradientStop in gradientBrush2.GradientStops)
				{
					linearGradientBrush.GradientStops.Add(new GradientStop
					{
						Offset = gradientStop.Offset,
						Color = gradientStop.Color
					});
				}
			}
			else
			{
				linearGradientBrush.GradientStops.Add(new GradientStop
				{
					Offset = 0.0,
					Color = SelectedColor
				});
				linearGradientBrush.GradientStops.Add(new GradientStop
				{
					Offset = 1.0,
					Color = SelectedColor
				});
			}
			Value = linearGradientBrush;
			break;
		}
		case BrushKind.RadialGradient:
		{
			RadialGradientBrush radialGradientBrush = Value as RadialGradientBrush;
			if (CanReuseBrush && radialGradientBrush != null && !radialGradientBrush.IsFrozen)
			{
				break;
			}
			GradientBrush gradientBrush = Value as GradientBrush;
			radialGradientBrush = new RadialGradientBrush();
			if (gradientBrush != null && gradientBrush.GradientStops.Count > 0)
			{
				foreach (GradientStop gradientStop2 in gradientBrush.GradientStops)
				{
					radialGradientBrush.GradientStops.Add(new GradientStop
					{
						Offset = gradientStop2.Offset,
						Color = gradientStop2.Color
					});
				}
			}
			else
			{
				radialGradientBrush.GradientStops.Add(new GradientStop
				{
					Offset = 0.0,
					Color = SelectedColor
				});
				radialGradientBrush.GradientStops.Add(new GradientStop
				{
					Offset = 1.0,
					Color = SelectedColor
				});
			}
			Value = radialGradientBrush;
			break;
		}
		default:
			if (Value != null)
			{
				Value = null;
			}
			break;
		}
	}

	private void aVD(Action P_0)
	{
		if (!base.IsLoaded)
		{
			base.Dispatcher.BeginInvoke(DispatcherPriority.DataBind, P_0);
		}
		else
		{
			P_0();
		}
	}

	private void wVG()
	{
		if (!IsGradientAllowed && Value is GradientBrush)
		{
			iVb(BrushKind.SolidColor);
		}
	}

	private void jVq()
	{
		if (!IsNullAllowed && Value == null)
		{
			iVb(BrushKind.SolidColor);
		}
	}

	private void oVu(object P_0, SelectionChangedEventArgs P_1)
	{
		if (vVp || bVr == null)
		{
			return;
		}
		try
		{
			vVp = true;
			BrushKind brushKind = BrushKind.None;
			object selectedValue = bVr.SelectedValue;
			if (selectedValue is BrushKind || selectedValue is int)
			{
				brushKind = (BrushKind)selectedValue;
			}
			iVb(brushKind);
			eVc();
			TVH();
		}
		finally
		{
			vVp = false;
		}
	}

	private static void VVK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals3.guF = (BrushPicker)P_0;
		CS_0024_003C_003E8__locals3.guF.aVD(delegate
		{
			CS_0024_003C_003E8__locals3.guF.wVG();
		});
	}

	private static void iVR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass30_0();
		CS_0024_003C_003E8__locals3.yu3 = (BrushPicker)P_0;
		CS_0024_003C_003E8__locals3.yu3.aVD(delegate
		{
			CS_0024_003C_003E8__locals3.yu3.jVq();
		});
	}

	private static void rVd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BrushPicker brushPicker = (BrushPicker)P_0;
		if (!brushPicker.vVp)
		{
			try
			{
				brushPicker.vVp = true;
				brushPicker.iVb(brushPicker.BrushKind);
			}
			finally
			{
				brushPicker.vVp = false;
			}
		}
	}

	private static void eV9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BrushPicker brushPicker = (BrushPicker)P_0;
		if (!brushPicker.vVp)
		{
			try
			{
				brushPicker.vVp = true;
				brushPicker.eVc();
				brushPicker.TVH();
			}
			finally
			{
				brushPicker.vVp = false;
			}
		}
		brushPicker.GV5();
	}

	[SpecialName]
	private GradientStopSlider FV3()
	{
		return aVv;
	}

	[SpecialName]
	private void oVy(GradientStopSlider value)
	{
		aVv = value;
	}

	private void GV5()
	{
		wVW?.Invoke(this, EventArgs.Empty);
	}

	private void eVc()
	{
		Brush value = Value;
		if (value is SolidColorBrush)
		{
			BrushKind = BrushKind.SolidColor;
		}
		else if (value is LinearGradientBrush { StartPoint: { X: var x }, EndPoint: var endPoint } linearGradientBrush)
		{
			if (x == endPoint.X)
			{
				BrushKind = BrushKind.VerticalLinearGradient;
			}
			else if (linearGradientBrush.StartPoint.Y == linearGradientBrush.EndPoint.Y)
			{
				BrushKind = BrushKind.HorizontalLinearGradient;
			}
			else if ((linearGradientBrush.StartPoint.X < linearGradientBrush.EndPoint.X && linearGradientBrush.StartPoint.Y < linearGradientBrush.EndPoint.Y) || (linearGradientBrush.StartPoint.X > linearGradientBrush.EndPoint.X && linearGradientBrush.StartPoint.Y > linearGradientBrush.EndPoint.Y))
			{
				BrushKind = BrushKind.DiagonalDownwardLinearGradient;
			}
			else
			{
				BrushKind = BrushKind.DiagonalUpwardLinearGradient;
			}
		}
		else if (value is RadialGradientBrush)
		{
			BrushKind = BrushKind.RadialGradient;
		}
		else
		{
			BrushKind = BrushKind.None;
		}
		IsNull = BrushKind == BrushKind.None;
		IsGradient = value is GradientBrush;
		if (bVr != null)
		{
			bVr.SelectedValue = BrushKind;
		}
	}

	private void TVH()
	{
		switch (BrushKind)
		{
		case BrushKind.SolidColor:
			if (Value is SolidColorBrush solidColorBrush)
			{
				SelectedColor = solidColorBrush.Color;
			}
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		HVF(GetTemplateChild(QdM.AR8(1412)) as Selector);
		oVy(GetTemplateChild(QdM.AR8(1460)) as GradientStopSlider);
		try
		{
			vVp = true;
			eVc();
		}
		finally
		{
			vVp = false;
		}
	}

	static BrushPicker()
	{
		awj.QuEwGz();
		AddGradientStopButtonToolTipProperty = DependencyProperty.Register(QdM.AR8(1510), typeof(object), typeof(BrushPicker), new PropertyMetadata(SR.GetString(SRName.UIBrushPickerAddGradientStopButtonToolTip)));
		BrushKindProperty = DependencyProperty.Register(QdM.AR8(1570), typeof(BrushKind), typeof(BrushPicker), new PropertyMetadata(BrushKind.None));
		CanReuseBrushProperty = DependencyProperty.Register(QdM.AR8(1218), typeof(bool), typeof(BrushPicker), new PropertyMetadata(true));
		IsAlphaEnabledProperty = DependencyProperty.Register(QdM.AR8(1288), typeof(bool), typeof(BrushPicker), new PropertyMetadata(true));
		IsGradientProperty = DependencyProperty.Register(QdM.AR8(1592), typeof(bool), typeof(BrushPicker), new PropertyMetadata(false));
		IsGradientAllowedProperty = DependencyProperty.Register(QdM.AR8(1320), typeof(bool), typeof(BrushPicker), new PropertyMetadata(true, VVK));
		IsNullProperty = DependencyProperty.Register(QdM.AR8(1616), typeof(bool), typeof(BrushPicker), new PropertyMetadata(true));
		IsNullAllowedProperty = DependencyProperty.Register(QdM.AR8(1632), typeof(bool), typeof(BrushPicker), new PropertyMetadata(true, iVR));
		RemoveGradientStopButtonToolTipProperty = DependencyProperty.Register(QdM.AR8(1662), typeof(object), typeof(BrushPicker), new PropertyMetadata(SR.GetString(SRName.UIBrushPickerRemoveGradientStopButtonToolTip)));
		ReverseGradientStopsButtonToolTipProperty = DependencyProperty.Register(QdM.AR8(1728), typeof(object), typeof(BrushPicker), new PropertyMetadata(SR.GetString(SRName.UIBrushPickerReverseGradientStopsButtonToolTip)));
		SelectedColorProperty = DependencyProperty.Register(QdM.AR8(1798), typeof(Color), typeof(BrushPicker), new PropertyMetadata(VdT.abb, rVd));
		ValueProperty = DependencyProperty.Register(QdM.AR8(1828), typeof(Brush), typeof(BrushPicker), new PropertyMetadata(null, eV9));
	}

	internal static bool lK()
	{
		return QX == null;
	}

	internal static BrushPicker xC()
	{
		return QX;
	}
}
