using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public class UnitConverter : TypeConverter
{
	private static UnitConverter NMo;

	private static InstanceDescriptor gN(object P_0)
	{
		Unit unit = (Unit)P_0;
		MemberInfo memberInfo = null;
		object[] arguments = null;
		if (unit.IsEmpty)
		{
			memberInfo = typeof(Unit).GetField(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996));
		}
		else
		{
			memberInfo = typeof(Unit).GetConstructor(new Type[2]
			{
				typeof(double),
				typeof(UnitType)
			});
			arguments = new object[2] { unit.Value, unit.Type };
		}
		if (null != memberInfo)
		{
			return new InstanceDescriptor(memberInfo, arguments);
		}
		return null;
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return typeof(string) == sourceType || base.CanConvertFrom(context, sourceType);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (typeof(string) != destinationType && typeof(InstanceDescriptor) != destinationType)
		{
			return base.CanConvertTo(context, destinationType);
		}
		return true;
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value == null)
		{
			return null;
		}
		if (!(value is string text))
		{
			return base.ConvertFrom(context, culture, value);
		}
		string text2 = text.Trim();
		if (text2.Length == 0)
		{
			return Unit.Empty;
		}
		return Unit.Parse(text2, culture ?? CultureInfo.CurrentCulture);
	}

	[SecuritySafeCritical]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (typeof(string) != destinationType)
		{
			if (typeof(InstanceDescriptor) != destinationType || value == null)
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			if (BrowserInteropHelper.IsBrowserHosted)
			{
				return null;
			}
			return gN(value);
		}
		if (value != null)
		{
			Unit unit = (Unit)value;
			if (!unit.IsEmpty)
			{
				return unit.ToString(culture);
			}
		}
		return string.Empty;
	}

	public UnitConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool rM5()
	{
		return NMo == null;
	}

	internal static UnitConverter oMm()
	{
		return NMo;
	}
}
