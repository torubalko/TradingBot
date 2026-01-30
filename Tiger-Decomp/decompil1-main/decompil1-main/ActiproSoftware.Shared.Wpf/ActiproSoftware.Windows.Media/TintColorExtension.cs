using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[TypeConverter(typeof(TintColorExtensionConverter))]
[MarkupExtensionReturnType(typeof(Color))]
public class TintColorExtension : MarkupExtension
{
	internal class TintColorExtensionConverter : TypeConverter
	{
		private static TintColorExtensionConverter Tj3;

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
			if (!(value is TintColorExtension tintColorExtension))
			{
				int num = 0;
				if (!GjN())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136908));
				}
			}
			return new InstanceDescriptor(typeof(TintColorExtension).GetConstructor(new Type[2]
			{
				typeof(Color),
				typeof(Color)
			}), new object[2] { tintColorExtension.UQm, tintColorExtension.WQw });
		}

		public TintColorExtensionConverter()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool GjN()
		{
			return Tj3 == null;
		}

		internal static TintColorExtensionConverter hjO()
		{
			return Tj3;
		}
	}

	private Color UQm;

	private Color WQw;

	internal static TintColorExtension k75;

	[ConstructorArgument("baseColor")]
	public Color BaseColor
	{
		get
		{
			return UQm;
		}
		set
		{
			bool flag = false;
			UQm = value;
		}
	}

	[ConstructorArgument("tintColor")]
	public Color TintColor
	{
		get
		{
			return WQw;
		}
		set
		{
			bool flag = false;
			WQw = value;
		}
	}

	public TintColorExtension()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public TintColorExtension(Color baseColor, Color tintColor)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		UQm = baseColor;
		WQw = tintColor;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		UIColor uIColor = UIColor.FromColor(WQw);
		uIColor.HlsLightness *= 0.75;
		return UQm.Tint(uIColor.ToColor());
	}

	internal static bool k7m()
	{
		return k75 == null;
	}

	internal static TintColorExtension Y7Z()
	{
		return k75;
	}
}
