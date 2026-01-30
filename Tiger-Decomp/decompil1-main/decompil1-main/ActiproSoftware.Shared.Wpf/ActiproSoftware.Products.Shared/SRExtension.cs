using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Shared;

[MarkupExtensionReturnType(typeof(string))]
[TypeConverter(typeof(SRExtensionConverter))]
public class SRExtension : MarkupExtension
{
	internal class SRExtensionConverter : TypeConverter
	{
		private static SRExtensionConverter H6s;

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
			SRExtension sRExtension = value as SRExtension;
			bool flag = sRExtension == null;
			int num = 0;
			if (J6p() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(137162));
				}
				return new InstanceDescriptor(typeof(SRExtension).GetConstructor(new Type[1] { typeof(string) }), new object[1] { sRExtension.Name });
			}
		}

		public SRExtensionConverter()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool S6i()
		{
			return H6s == null;
		}

		internal static SRExtensionConverter J6p()
		{
			return H6s;
		}
	}

	private string name;

	internal static SRExtension ngr;

	[ConstructorArgument("name")]
	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592));
			}
			name = value;
		}
	}

	public SRExtension()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public SRExtension(string name)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (name == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135872));
		}
		this.name = name;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (name != null)
		{
			try
			{
				Enum.Parse(typeof(SRName), name);
			}
			catch (ArgumentException)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135964), new object[1] { name }));
			}
			return SR.GetString(name);
		}
		throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135884));
	}

	internal static bool TgI()
	{
		return ngr == null;
	}

	internal static SRExtension ggD()
	{
		return ngr;
	}
}
