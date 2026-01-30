using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class ColorEditBox : PartEditBoxBase<Color?>
{
	private ColorPicker picker;

	public static readonly DependencyProperty DefaultValueProperty;

	public static readonly DependencyProperty HasSwatchProperty;

	public static readonly DependencyProperty HasTextProperty;

	public static readonly DependencyProperty IsAlphaEnabledProperty;

	public static readonly DependencyProperty IsInitialValueComparedOnPopupProperty;

	public static readonly DependencyProperty SwatchBrushProperty;

	public static readonly DependencyProperty SwatchMarginProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler kCw;

	internal static ColorEditBox VH;

	public Color DefaultValue
	{
		get
		{
			return (Color)GetValue(DefaultValueProperty);
		}
		set
		{
			SetValue(DefaultValueProperty, value);
		}
	}

	protected override bool HasPopupButtonWhenReadOnly => true;

	public bool HasSwatch
	{
		get
		{
			return (bool)GetValue(HasSwatchProperty);
		}
		set
		{
			SetValue(HasSwatchProperty, value);
		}
	}

	public bool HasText
	{
		get
		{
			return (bool)GetValue(HasTextProperty);
		}
		set
		{
			SetValue(HasTextProperty, value);
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

	public bool IsInitialValueComparedOnPopup
	{
		get
		{
			return (bool)GetValue(IsInitialValueComparedOnPopupProperty);
		}
		set
		{
			SetValue(IsInitialValueComparedOnPopupProperty, value);
		}
	}

	public Brush SwatchBrush
	{
		get
		{
			return (Brush)GetValue(SwatchBrushProperty);
		}
		private set
		{
			SetValue(SwatchBrushProperty, value);
		}
	}

	public Thickness SwatchMargin
	{
		get
		{
			return (Thickness)GetValue(SwatchMarginProperty);
		}
		set
		{
			SetValue(SwatchMarginProperty, value);
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = kCw;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref kCw, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = kCw;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref kCw, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ColorEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ColorEditBox);
	}

	private static void YC4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ColorEditBox colorEditBox = (ColorEditBox)P_0;
		if (!colorEditBox.IsAlphaEnabled && colorEditBox.Value.HasValue && colorEditBox.Value.Value.A < byte.MaxValue)
		{
			colorEditBox.Value = Color.FromArgb(byte.MaxValue, colorEditBox.Value.Value.R, colorEditBox.Value.Value.G, colorEditBox.Value.Value.B);
		}
		colorEditBox.InvalidateParts();
		colorEditBox.QTc();
	}

	private void TCB()
	{
		if (!base.IntermediateValue.HasValue)
		{
			SwatchBrush = new LinearGradientBrush
			{
				StartPoint = new Point(0.0, 0.0),
				EndPoint = new Point(1.0, 1.0),
				GradientStops = 
				{
					new GradientStop
					{
						Offset = 0.47,
						Color = Color.FromArgb(0, byte.MaxValue, 0, 0)
					},
					new GradientStop
					{
						Offset = 0.471,
						Color = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0)
					},
					new GradientStop
					{
						Offset = 0.529,
						Color = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0)
					},
					new GradientStop
					{
						Offset = 0.53,
						Color = Color.FromArgb(0, byte.MaxValue, 0, 0)
					}
				}
			};
		}
		else
		{
			SwatchBrush = new SolidColorBrush(base.IntermediateValue.Value);
		}
	}

	protected internal override string ConvertToString(Color? valueToConvert)
	{
		return VdT.Hb0(valueToConvert, IsAlphaEnabled) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Color?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Color?> incrementalChangeRequest = new IncrementalChangeRequest<Color?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.Maximum = Colors.White;
		incrementalChangeRequest.Minimum = Colors.Black;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? DefaultValue;
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return VdT.qbY(IsAlphaEnabled);
	}

	protected override bool IsValidValue(Color? value)
	{
		if (value.HasValue)
		{
			return true;
		}
		return base.IsNullAllowed;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		picker = GetTemplateChild(QdM.AR8(2520)) as ColorPicker;
		TCB();
	}

	protected override void OnIntermediateValueChanged(Color? oldValue, Color? newValue)
	{
		base.OnIntermediateValueChanged(oldValue, newValue);
		TCB();
	}

	protected override void OnPopupOpened()
	{
		base.OnPopupOpened();
		if (picker != null)
		{
			picker.ComparisonValue = base.Value ?? Colors.Transparent;
		}
	}

	protected override void RaiseValueChangedEvent()
	{
		kCw?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Color?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Color?>.ValueProperty, DefaultValue);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Color? value)
	{
		bool result;
		if (!VdT.vbI(textToConvert, IsAlphaEnabled, out value))
		{
			result = false;
		}
		else if (value.HasValue)
		{
			result = true;
			int num = 0;
			if (!dU())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = base.IsNullAllowed;
		}
		return result;
	}

	static ColorEditBox()
	{
		awj.QuEwGz();
		DefaultValueProperty = DependencyProperty.Register(QdM.AR8(1898), typeof(Color), typeof(ColorEditBox), new PropertyMetadata(VdT.abb));
		HasSwatchProperty = DependencyProperty.Register(QdM.AR8(1248), typeof(bool), typeof(ColorEditBox), new PropertyMetadata(true));
		HasTextProperty = DependencyProperty.Register(QdM.AR8(1270), typeof(bool), typeof(ColorEditBox), new PropertyMetadata(true));
		IsAlphaEnabledProperty = DependencyProperty.Register(QdM.AR8(1288), typeof(bool), typeof(ColorEditBox), new PropertyMetadata(true, YC4));
		IsInitialValueComparedOnPopupProperty = DependencyProperty.Register(QdM.AR8(2546), typeof(bool), typeof(ColorEditBox), new PropertyMetadata(true));
		SwatchBrushProperty = DependencyProperty.Register(QdM.AR8(1358), typeof(Brush), typeof(ColorEditBox), new PropertyMetadata(null));
		SwatchMarginProperty = DependencyProperty.Register(QdM.AR8(1384), typeof(Thickness), typeof(ColorEditBox), new PropertyMetadata(new Thickness(3.0, 3.0, 0.0, 3.0)));
	}

	internal static bool dU()
	{
		return VH == null;
	}

	internal static ColorEditBox T9()
	{
		return VH;
	}
}
