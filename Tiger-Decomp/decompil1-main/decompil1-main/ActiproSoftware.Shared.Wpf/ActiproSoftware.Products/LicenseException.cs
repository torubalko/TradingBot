using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
public class LicenseException : System.ComponentModel.LicenseException
{
	internal static LicenseException wgb;

	public LicenseException(string message)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(null, message);
	}

	public LicenseException(Type type, string message)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(type, null, message);
	}

	internal static bool yg1()
	{
		return wgb == null;
	}

	internal static LicenseException kgg()
	{
		return wgb;
	}
}
