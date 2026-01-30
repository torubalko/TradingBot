using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal static class fTO
{
	private static IDataStore jRd;

	private static bool? nRz;

	internal static fTO BAl;

	public static bool bRt()
	{
		if (!nRz.HasValue)
		{
			nRz = true;
			try
			{
				UIPermission uIPermission = new UIPermission(UIPermissionClipboard.AllClipboard);
				uIPermission.Demand();
			}
			catch (SecurityException)
			{
				nRz = false;
			}
		}
		return nRz.Value;
	}

	public static IDataStore ARZ()
	{
		if (bRt())
		{
			return new cTH();
		}
		return new eAS();
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static IDataStore WRh()
	{
		if (bRt())
		{
			try
			{
				return new cTH(Clipboard.GetDataObject());
			}
			catch (SystemException)
			{
			}
			return null;
		}
		return jRd;
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static bool iRN(IDataStore P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (bRt())
		{
			IDataObject dataObject = P_0.ToDataObject();
			if (dataObject != null)
			{
				try
				{
					Clipboard.SetDataObject(dataObject, copy: true);
				}
				catch (SystemException)
				{
					return false;
				}
			}
			return dataObject != null;
		}
		jRd = P_0;
		return true;
	}

	internal static bool WAW()
	{
		return BAl == null;
	}

	internal static fTO pAS()
	{
		return BAl;
	}
}
