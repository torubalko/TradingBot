using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tintable")]
public class TintableBorder : Border
{
	public static readonly DependencyProperty TintColorProperty;

	private static TintableBorder Sbm;

	public Color TintColor
	{
		get
		{
			return (Color)GetValue(TintColorProperty);
		}
		set
		{
			SetValue(TintColorProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static TintableBorder()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		TintColorProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121640), typeof(Color), typeof(TintableBorder), new FrameworkPropertyMetadata(Colors.Transparent, IZj));
		Border.BackgroundProperty.OverrideMetadata(typeof(TintableBorder), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, null, srz));
		Border.BorderBrushProperty.OverrideMetadata(typeof(TintableBorder), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, Border.BorderBrushProperty.DefaultMetadata.PropertyChangedCallback, lZc));
	}

	private static object srz(DependencyObject P_0, object P_1)
	{
		if (!(P_0 is TintableBorder { TintColor: var tintColor }) || !(tintColor != Colors.Transparent) || !(P_1 is Brush brush))
		{
			return P_1;
		}
		return brush.Tint(tintColor);
	}

	private static object lZc(DependencyObject P_0, object P_1)
	{
		if (P_0 is TintableBorder { TintColor: var tintColor } && tintColor != Colors.Transparent && P_1 is Brush brush)
		{
			return brush.Tint(tintColor);
		}
		return P_1;
	}

	private static void IZj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is TintableBorder tintableBorder)
		{
			tintableBorder.CoerceValue(Border.BackgroundProperty);
			tintableBorder.CoerceValue(Border.BorderBrushProperty);
		}
	}

	public TintableBorder()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool ibZ()
	{
		return Sbm == null;
	}

	internal static TintableBorder vbr()
	{
		return Sbm;
	}
}
