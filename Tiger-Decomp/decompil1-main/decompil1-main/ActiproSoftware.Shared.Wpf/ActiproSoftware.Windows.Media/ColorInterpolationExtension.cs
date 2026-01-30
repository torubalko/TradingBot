using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[TypeConverter(typeof(ColorInterpolationExtensionConverter))]
[MarkupExtensionReturnType(typeof(Color))]
public class ColorInterpolationExtension : MarkupExtension
{
	internal class ColorInterpolationExtensionConverter : TypeConverter
	{
		private static ColorInterpolationExtensionConverter FjY;

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		[SecuritySafeCritical]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType != typeof(InstanceDescriptor))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			if (!(value is ColorInterpolationExtension colorInterpolationExtension))
			{
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136784));
			}
			return new InstanceDescriptor(typeof(ColorInterpolationExtension).GetConstructor(new Type[3]
			{
				typeof(Color),
				typeof(Color),
				typeof(double)
			}), new object[3] { colorInterpolationExtension.Color1, colorInterpolationExtension.Color2, colorInterpolationExtension.Percentage });
		}

		public ColorInterpolationExtensionConverter()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool Wjt()
		{
			return FjY == null;
		}

		internal static ColorInterpolationExtensionConverter Djf()
		{
			return FjY;
		}
	}

	private Color RoZ;

	private Color Fon;

	private double Coa;

	internal static ColorInterpolationExtension M7t;

	[ConstructorArgument("color1")]
	public Color Color1
	{
		get
		{
			return RoZ;
		}
		set
		{
			bool flag = false;
			RoZ = value;
		}
	}

	[ConstructorArgument("color2")]
	public Color Color2
	{
		get
		{
			return Fon;
		}
		set
		{
			bool flag = false;
			Fon = value;
		}
	}

	[ConstructorArgument("percentage")]
	public double Percentage
	{
		get
		{
			return Coa;
		}
		set
		{
			Coa = value;
		}
	}

	public ColorInterpolationExtension()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public ColorInterpolationExtension(Color color1, Color color2, double percentage)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		bool flag = false;
		bool flag2 = false;
		RoZ = color1;
		Fon = color2;
		Coa = percentage;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return UIColor.FromMix(RoZ, Fon, Math.Max(0.0, Math.Min(1.0, Coa))).ToColor();
	}

	internal static bool l7f()
	{
		return M7t == null;
	}

	internal static ColorInterpolationExtension x77()
	{
		return M7t;
	}
}
