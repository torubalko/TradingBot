using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Shared;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
public class Resources
{
	private static ResourceManager UqC;

	private static CultureInfo gqY;

	internal static Resources wgc;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (UqC == null)
			{
				ResourceManager uqC = new ResourceManager("ActiproSoftware.Products.Shared.Resources", typeof(Resources).Assembly);
				UqC = uqC;
			}
			return UqC;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return gqY;
		}
		set
		{
			gqY = value;
		}
	}

	public static string ExNotSupportedReadOnlyCollection => ResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135580), gqY);

	public static string UICommandCloseWindowText => ResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135648), gqY);

	public static string UICommandMaximizeWindowText => ResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135700), gqY);

	public static string UICommandMinimizeWindowText => ResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135758), gqY);

	public static string UICommandRestoreWindowText => ResourceManager.GetString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135816), gqY);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool jgu()
	{
		return wgc == null;
	}

	internal static Resources Cgo()
	{
		return wgc;
	}
}
