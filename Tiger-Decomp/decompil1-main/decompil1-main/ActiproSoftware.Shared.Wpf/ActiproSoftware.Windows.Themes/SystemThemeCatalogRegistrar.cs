using System.ComponentModel;
using System.Windows;
using ActiproSoftware.Windows.Themes.Generation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

[Browsable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class SystemThemeCatalogRegistrar : ThemeCatalogRegistrarBase<SystemThemeCatalog>
{
	private bool Y40;

	internal static SystemThemeCatalogRegistrar wMP;

	public bool IsSharedLibrary
	{
		get
		{
			return Y40;
		}
		set
		{
			if (Y40 == value)
			{
				return;
			}
			Y40 = value;
			if (!Y40)
			{
				return;
			}
			bool isInDesignMode = DesignerProperties.GetIsInDesignMode(new DependencyObject());
			int num = 0;
			if (uMz() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (isInDesignMode)
			{
				ResourceDictionary resourceDictionary = new ThemeGenerator().Generate(new ThemeDefinition(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(94896)));
				if (resourceDictionary != null)
				{
					base.MergedDictionaries.Add(resourceDictionary);
				}
			}
		}
	}

	public SystemThemeCatalogRegistrar()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool zMW()
	{
		return wMP == null;
	}

	internal static SystemThemeCatalogRegistrar uMz()
	{
		return wMP;
	}
}
