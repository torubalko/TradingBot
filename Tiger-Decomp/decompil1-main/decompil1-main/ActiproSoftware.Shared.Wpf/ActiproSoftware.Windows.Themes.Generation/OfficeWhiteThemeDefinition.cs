using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public class OfficeWhiteThemeDefinition : OfficeThemeDefinitionBase
{
	private ColorFamilyName b7S;

	private static OfficeWhiteThemeDefinition nfY;

	public OfficeWhiteThemeDefinition(string themeName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(themeName, ColorFamilyName.Blue);
	}

	public OfficeWhiteThemeDefinition(string themeName, ColorFamilyName colorFamilyName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, ThemeIntent.White);
		b7S = colorFamilyName;
		ResetPrimaryAccentColorFamilyName();
		ResetStatusBarBackgroundKind();
		ResetWindowBorderKind();
		ResetWindowColorFamilyName();
	}

	public override void ResetPrimaryAccentColorFamilyName()
	{
		base.PrimaryAccentColorFamilyName = b7S;
	}

	public override bool ShouldSerializePrimaryAccentColorFamilyName()
	{
		return base.PrimaryAccentColorFamilyName != b7S;
	}

	public override void ResetStatusBarBackgroundKind()
	{
		base.StatusBarBackgroundKind = StatusBarBackgroundKind.Accent;
	}

	public override bool ShouldSerializeStatusBarBackgroundKind()
	{
		return base.StatusBarBackgroundKind != StatusBarBackgroundKind.Accent;
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
		base.WindowColorFamilyName = b7S;
	}

	public override bool ShouldSerializeWindowColorFamilyName()
	{
		return base.WindowColorFamilyName != b7S;
	}

	internal static bool nft()
	{
		return nfY == null;
	}

	internal static OfficeWhiteThemeDefinition kff()
	{
		return nfY;
	}
}
