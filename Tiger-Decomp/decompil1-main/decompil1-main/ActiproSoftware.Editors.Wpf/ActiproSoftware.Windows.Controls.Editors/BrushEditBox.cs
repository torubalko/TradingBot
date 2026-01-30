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

public class BrushEditBox : PartEditBoxBase<Brush>
{
	public static readonly DependencyProperty CanReuseBrushProperty;

	public static readonly DependencyProperty HasSwatchProperty;

	public static readonly DependencyProperty HasTextProperty;

	public static readonly DependencyProperty IsAlphaEnabledProperty;

	public static readonly DependencyProperty IsGradientAllowedProperty;

	public static readonly DependencyProperty SwatchBrushProperty;

	public static readonly DependencyProperty SwatchMarginProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler MVI;

	internal static BrushEditBox M5;

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
			EventHandler eventHandler = MVI;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MVI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = MVI;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MVI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BrushEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(BrushEditBox);
	}

	private static void IVo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		BrushEditBox brushEditBox = (BrushEditBox)P_0;
		if (!brushEditBox.IsGradientAllowed && brushEditBox.Value is GradientBrush)
		{
			brushEditBox.ResetValue();
		}
	}

	private void BVO()
	{
		if (base.IntermediateValue == null)
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
			SwatchBrush = base.IntermediateValue;
		}
	}

	protected internal override string ConvertToString(Brush valueToConvert)
	{
		return sdm.VbQ(valueToConvert, IsAlphaEnabled) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Brush> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		return null;
	}

	protected override IList<IPart> GenerateParts()
	{
		return sdm.CbV();
	}

	protected override bool IsValidValue(Brush value)
	{
		if (value != null)
		{
			return true;
		}
		return base.IsNullAllowed;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		BVO();
	}

	protected override void OnIntermediateValueChanged(Brush oldValue, Brush newValue)
	{
		base.OnIntermediateValueChanged(oldValue, newValue);
		BVO();
	}

	protected override void RaiseValueChangedEvent()
	{
		MVI?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Brush>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Brush>.ValueProperty, sdm.Vb6);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Brush value)
	{
		if (sdm.WbC(textToConvert, IsAlphaEnabled, out value))
		{
			if (value == null)
			{
				return base.IsNullAllowed;
			}
			return true;
		}
		return false;
	}

	static BrushEditBox()
	{
		awj.QuEwGz();
		CanReuseBrushProperty = DependencyProperty.Register(QdM.AR8(1218), typeof(bool), typeof(BrushEditBox), new PropertyMetadata(true));
		HasSwatchProperty = DependencyProperty.Register(QdM.AR8(1248), typeof(bool), typeof(BrushEditBox), new PropertyMetadata(true));
		HasTextProperty = DependencyProperty.Register(QdM.AR8(1270), typeof(bool), typeof(BrushEditBox), new PropertyMetadata(true));
		IsAlphaEnabledProperty = DependencyProperty.Register(QdM.AR8(1288), typeof(bool), typeof(BrushEditBox), new PropertyMetadata(true));
		IsGradientAllowedProperty = DependencyProperty.Register(QdM.AR8(1320), typeof(bool), typeof(BrushEditBox), new PropertyMetadata(true, IVo));
		SwatchBrushProperty = DependencyProperty.Register(QdM.AR8(1358), typeof(Brush), typeof(BrushEditBox), new PropertyMetadata(null));
		SwatchMarginProperty = DependencyProperty.Register(QdM.AR8(1384), typeof(Thickness), typeof(BrushEditBox), new PropertyMetadata(new Thickness(3.0, 3.0, 0.0, 3.0)));
	}

	internal static bool uI()
	{
		return M5 == null;
	}

	internal static BrushEditBox U6()
	{
		return M5;
	}
}
