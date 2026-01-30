using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Packaging;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Resources;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Themes;

public static class DataGridCursors
{
	private static Cursor NI;

	private static Cursor Ng;

	internal static DataGridCursors lA;

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static Cursor ColumnResizeCursor
	{
		get
		{
			if (NI == null)
			{
				try
				{
					StreamResourceInfo resourceStream = Application.GetResourceStream(i2(new Uri(ActiproSoftware.Internal.Ng.cn(150), UriKind.Relative)));
					if (resourceStream == null)
					{
						NI = Cursors.SizeWE;
					}
					else
					{
						NI = new Cursor(resourceStream.Stream);
					}
				}
				catch
				{
					NI = Cursors.SizeWE;
				}
			}
			return NI;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static Cursor RowResizeCursor
	{
		get
		{
			if (Ng == null)
			{
				try
				{
					StreamResourceInfo resourceStream = Application.GetResourceStream(i2(new Uri(ActiproSoftware.Internal.Ng.cn(256), UriKind.Relative)));
					if (resourceStream == null)
					{
						Ng = Cursors.SizeNS;
					}
					else
					{
						Ng = new Cursor(resourceStream.Stream);
					}
				}
				catch
				{
					Ng = Cursors.SizeNS;
				}
			}
			return Ng;
		}
	}

	private static Uri i2(Uri P_0)
	{
		if (P_0.IsAbsoluteUri)
		{
			throw new ArgumentException(ActiproSoftware.Internal.Ng.cn(0), ActiproSoftware.Internal.Ng.cn(60));
		}
		return PackUriHelper.Create(new Uri(ActiproSoftware.Internal.Ng.cn(86), UriKind.Absolute), new Uri(ActiproSoftware.Internal.Ng.cn(120) + Assembly.GetExecutingAssembly().GetName().Name + ActiproSoftware.Internal.Ng.cn(126) + P_0, UriKind.Relative));
	}

	internal static bool tc()
	{
		return lA == null;
	}

	internal static DataGridCursors S8()
	{
		return lA;
	}
}
