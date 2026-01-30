using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class DelegateConverter : IValueConverter
{
	[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	public delegate object ConvertDelegate(object value, Type targetType, object parameter, CultureInfo culture);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ConvertDelegate ekH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ConvertDelegate Bk6;

	internal static DelegateConverter VNV;

	public ConvertDelegate ConvertCallback
	{
		[CompilerGenerated]
		get
		{
			return ekH;
		}
		[CompilerGenerated]
		set
		{
			ekH = value;
		}
	}

	public ConvertDelegate ConvertBackCallback
	{
		[CompilerGenerated]
		get
		{
			return Bk6;
		}
		[CompilerGenerated]
		set
		{
			Bk6 = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (ConvertCallback == null)
		{
			throw new NotSupportedException();
		}
		return ConvertCallback(value, targetType, parameter, culture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (ConvertBackCallback != null)
		{
			return ConvertBackCallback(value, targetType, parameter, culture);
		}
		throw new NotSupportedException();
	}

	public DelegateConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool zNT()
	{
		return VNV == null;
	}

	internal static DelegateConverter TNX()
	{
		return VNV;
	}
}
