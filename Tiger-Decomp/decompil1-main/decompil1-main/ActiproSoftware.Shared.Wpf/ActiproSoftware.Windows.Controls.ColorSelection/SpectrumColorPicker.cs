using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection;

public class SpectrumColorPicker : Control
{
	private bool Rnf;

	private bool eni;

	private static ICommand LnS;

	public static readonly RoutedEvent SelectedColorChangedEvent;

	private static readonly DependencyPropertyKey Hn3;

	private static readonly DependencyPropertyKey dnt;

	public static readonly DependencyProperty AProperty;

	public static readonly DependencyProperty BProperty;

	public static readonly DependencyProperty DisabledOpacityProperty;

	public static readonly DependencyProperty GProperty;

	public static readonly DependencyProperty InitialColorProperty;

	public static readonly DependencyProperty InitialColorBrushProperty;

	public static readonly DependencyProperty IsColorSwatchRowVisibleProperty;

	public static readonly DependencyProperty IsInitialColorVisibleProperty;

	public static readonly DependencyProperty RProperty;

	public static readonly DependencyProperty SelectedColorProperty;

	public static readonly DependencyProperty SelectedColorBrushProperty;

	internal static SpectrumColorPicker jbz;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "A")]
	public byte A
	{
		get
		{
			return (byte)GetValue(AProperty);
		}
		set
		{
			SetValue(AProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "B")]
	public byte B
	{
		get
		{
			return (byte)GetValue(BProperty);
		}
		set
		{
			SetValue(BProperty, value);
		}
	}

	public double DisabledOpacity
	{
		get
		{
			return (double)GetValue(DisabledOpacityProperty);
		}
		set
		{
			SetValue(DisabledOpacityProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "G")]
	public byte G
	{
		get
		{
			return (byte)GetValue(GProperty);
		}
		set
		{
			SetValue(GProperty, value);
		}
	}

	public Color InitialColor
	{
		get
		{
			return (Color)GetValue(InitialColorProperty);
		}
		set
		{
			SetValue(InitialColorProperty, value);
		}
	}

	public Brush InitialColorBrush
	{
		get
		{
			return (Brush)GetValue(InitialColorBrushProperty);
		}
		private set
		{
			SetValue(Hn3, value);
		}
	}

	public bool IsColorSwatchRowVisible
	{
		get
		{
			return (bool)GetValue(IsColorSwatchRowVisibleProperty);
		}
		set
		{
			SetValue(IsColorSwatchRowVisibleProperty, value);
		}
	}

	public bool IsInitialColorVisible
	{
		get
		{
			return (bool)GetValue(IsInitialColorVisibleProperty);
		}
		set
		{
			SetValue(IsInitialColorVisibleProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "R")]
	public byte R
	{
		get
		{
			return (byte)GetValue(RProperty);
		}
		set
		{
			SetValue(RProperty, value);
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

	public Brush SelectedColorBrush
	{
		get
		{
			return (Brush)GetValue(SelectedColorBrushProperty);
		}
		private set
		{
			SetValue(dnt, value);
		}
	}

	public static ICommand SetColor
	{
		get
		{
			if (LnS == null)
			{
				LnS = new RoutedCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122720), typeof(SpectrumColorPicker));
			}
			return LnS;
		}
	}

	[Description("Occurs when the value of the SelectedColor property is changed.")]
	public event RoutedPropertyChangedEventHandler<Color> SelectedColorChanged
	{
		add
		{
			AddHandler(SelectedColorChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectedColorChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static SpectrumColorPicker()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		SelectedColorChangedEvent = EventManager.RegisterRoutedEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121992), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Color>), typeof(SpectrumColorPicker));
		int num = 1;
		if (false)
		{
			int num2;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				CommandManager.RegisterClassCommandBinding(typeof(SpectrumColorPicker), new CommandBinding(SetColor, hZz));
				return;
			case 1:
				Hn3 = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122456), typeof(Brush), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(null));
				dnt = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122494), typeof(Brush), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(null));
				AProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110352), typeof(byte), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(byte.MaxValue, hZP));
				BProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122534), typeof(byte), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(byte.MaxValue, hZP));
				DisabledOpacityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97558), typeof(double), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(1.0), (object obj) => ValidationHelper.ValidateDoubleIsBetweenInclusive(obj, 0.0, 1.0));
				GProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(928), typeof(byte), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(byte.MaxValue, hZP));
				InitialColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122540), typeof(Color), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(Colors.White, FrameworkPropertyMetadataOptions.AffectsRender, JZG));
				InitialColorBrushProperty = Hn3.DependencyProperty;
				IsColorSwatchRowVisibleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122568), typeof(bool), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(true));
				IsInitialColorVisibleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122618), typeof(bool), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(true));
				RProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122664), typeof(byte), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(byte.MaxValue, hZP));
				SelectedColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122100), typeof(Color), typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(Colors.Beige, FrameworkPropertyMetadataOptions.AffectsRender, wZ1));
				SelectedColorBrushProperty = dnt.DependencyProperty;
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(typeof(SpectrumColorPicker)));
				Control.IsTabStopProperty.OverrideMetadata(typeof(SpectrumColorPicker), new FrameworkPropertyMetadata(false));
				num = 0;
				if (true)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public SpectrumColorPicker()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		AddHandler(SpectrumSlice.SelectedColorChangedEvent, new RoutedEventHandler(dnc));
		AddHandler(SpectrumSlider.SelectedColorChangedEvent, new RoutedEventHandler(rnj));
		InitialColorBrush = KZD(InitialColor);
		SelectedColorBrush = KZD(SelectedColor);
	}

	private static SolidColorBrush KZD(Color P_0)
	{
		SolidColorBrush solidColorBrush = new SolidColorBrush(P_0);
		solidColorBrush.Freeze();
		return solidColorBrush;
	}

	private static void hZP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumColorPicker spectrumColorPicker = (SpectrumColorPicker)P_0;
		if (!spectrumColorPicker.Rnf)
		{
			spectrumColorPicker.SelectedColor = Color.FromArgb(spectrumColorPicker.A, spectrumColorPicker.R, spectrumColorPicker.G, spectrumColorPicker.B);
		}
	}

	private static void JZG(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumColorPicker spectrumColorPicker = (SpectrumColorPicker)P_0;
		spectrumColorPicker.InitialColorBrush = KZD(spectrumColorPicker.InitialColor);
	}

	private static void wZ1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SpectrumColorPicker spectrumColorPicker = (SpectrumColorPicker)P_0;
		if (!spectrumColorPicker.Rnf)
		{
			spectrumColorPicker.SelectedColorBrush = KZD(spectrumColorPicker.SelectedColor);
			Color oldValue = (Color)P_1.OldValue;
			Color newValue = (Color)P_1.NewValue;
			spectrumColorPicker.Rnf = true;
			try
			{
				spectrumColorPicker.A = newValue.A;
				spectrumColorPicker.R = newValue.R;
				spectrumColorPicker.G = newValue.G;
				spectrumColorPicker.B = newValue.B;
			}
			finally
			{
				spectrumColorPicker.Rnf = false;
			}
			spectrumColorPicker.xnv();
			spectrumColorPicker.OnSelectedColorChanged(oldValue, newValue);
		}
	}

	private static void hZz(object P_0, ExecutedRoutedEventArgs P_1)
	{
		if (P_1.Source is SpectrumColorPicker spectrumColorPicker && P_1.Parameter is Color)
		{
			spectrumColorPicker.SelectedColor = (Color)P_1.Parameter;
		}
	}

	private void dnc(object P_0, RoutedEventArgs P_1)
	{
		if (base.IsLoaded)
		{
			try
			{
				eni = true;
				SelectedColor = rnX().SelectedColor;
			}
			finally
			{
				eni = false;
			}
		}
	}

	private void rnj(object P_0, RoutedEventArgs P_1)
	{
		rnX().BaseColor = BnB().SelectedColor;
	}

	[SpecialName]
	private SpectrumSlice rnX()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122670)) as SpectrumSlice;
	}

	[SpecialName]
	private SpectrumSlider BnB()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(122694)) as SpectrumSlider;
	}

	private void xnv()
	{
		if (BnB() == null || rnX() == null)
		{
			return;
		}
		Rnf = true;
		try
		{
			Color selectedColor = SelectedColor;
			if (!eni)
			{
				BnB().Value = UIColor.FromColor(selectedColor).HsbHue;
			}
			rnX().SelectedColor = selectedColor;
		}
		finally
		{
			Rnf = false;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		xnv();
	}

	protected virtual void OnSelectedColorChanged(Color oldValue, Color newValue)
	{
		RoutedPropertyChangedEventArgs<Color> e = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue, SelectedColorChangedEvent);
		e.Source = this;
		RaiseEvent(e);
	}

	internal static bool U1K()
	{
		return jbz == null;
	}

	internal static SpectrumColorPicker W1M()
	{
		return jbz;
	}
}
