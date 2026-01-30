using System.Diagnostics.CodeAnalysis;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public abstract class ThemeCatalogRegistrarBase<T> : ResourceDictionary where T : ThemeCatalogBase, new()
{
	private static object mYt;

	protected ThemeCatalogRegistrarBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Register();
	}

	[SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
	public static void Register()
	{
		ThemeManager.RegisterThemeCatalog(new T());
	}

	internal static bool uYf()
	{
		return mYt == null;
	}

	internal static object MY7()
	{
		return mYt;
	}
}
