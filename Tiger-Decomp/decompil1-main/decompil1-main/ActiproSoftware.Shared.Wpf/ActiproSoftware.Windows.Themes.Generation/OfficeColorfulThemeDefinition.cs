using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public class OfficeColorfulThemeDefinition : OfficeThemeDefinitionBase
{
	private ColorFamilyName F7i;

	private static OfficeColorfulThemeDefinition xth;

	public OfficeColorfulThemeDefinition(string themeName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(themeName, ColorFamilyName.Blue);
	}

	public OfficeColorfulThemeDefinition(string themeName, ColorFamilyName colorFamilyName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, ThemeIntent.Light);
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		F7i = colorFamilyName;
		ResetBarItemBackgroundStateKind();
		ResetListItemBackgroundStateKind();
		ResetPrimaryAccentColorFamilyName();
		ResetWindowBorderKind();
		ResetWindowColorFamilyName();
		ResetWindowTitleBarBackgroundKind();
	}

	public override void ResetBarItemBackgroundStateKind()
	{
		base.BarItemBackgroundStateKind = BackgroundStateKind.HighContrast;
	}

	public override bool ShouldSerializeBarItemBackgroundStateKind()
	{
		return base.BarItemBackgroundStateKind != BackgroundStateKind.HighContrast;
	}

	public override void ResetListItemBackgroundStateKind()
	{
		base.ListItemBackgroundStateKind = BackgroundStateKind.HighContrast;
	}

	public override bool ShouldSerializeListItemBackgroundStateKind()
	{
		return base.ListItemBackgroundStateKind != BackgroundStateKind.HighContrast;
	}

	public override void ResetPrimaryAccentColorFamilyName()
	{
		base.PrimaryAccentColorFamilyName = F7i;
	}

	public override bool ShouldSerializePrimaryAccentColorFamilyName()
	{
		return base.PrimaryAccentColorFamilyName != F7i;
	}

	public override void ResetWindowBorderKind()
	{
		base.WindowBorderKind = WindowBorderKind.Accent;
	}

	public override bool ShouldSerializeWindowBorderKind()
	{
		return base.WindowBorderKind != WindowBorderKind.Accent;
	}

	public override void ResetWindowColorFamilyName()
	{
		base.WindowColorFamilyName = F7i;
	}

	public override bool ShouldSerializeWindowColorFamilyName()
	{
		return base.WindowColorFamilyName != F7i;
	}

	public override void ResetWindowTitleBarBackgroundKind()
	{
		base.WindowTitleBarBackgroundKind = WindowTitleBarBackgroundKind.Accent;
	}

	public override bool ShouldSerializeWindowTitleBarBackgroundKind()
	{
		return base.WindowTitleBarBackgroundKind != WindowTitleBarBackgroundKind.Accent;
	}

	internal static bool FtP()
	{
		return xth == null;
	}

	internal static OfficeColorfulThemeDefinition ytW()
	{
		return xth;
	}
}
