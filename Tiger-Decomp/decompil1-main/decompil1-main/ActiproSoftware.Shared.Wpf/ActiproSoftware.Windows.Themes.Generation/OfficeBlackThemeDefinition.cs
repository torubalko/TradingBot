using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal class OfficeBlackThemeDefinition : OfficeThemeDefinitionBase
{
	private ColorFamilyName a7f;

	private static OfficeBlackThemeDefinition Pts;

	public OfficeBlackThemeDefinition(string themeName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, ThemeIntent.Dark);
		a7f = ColorFamilyName.Gray;
		ResetIntent();
		ResetBaseGrayscaleSaturation();
		ResetButtonBorderContrastKind();
		ResetContainerBorderContrastKind();
		ResetGrayMin();
		ResetPopupBorderContrastKind();
		ResetPrimaryAccentColorFamilyName();
		ResetWindowColorFamilyName();
	}

	public override void ResetBaseGrayscaleSaturation()
	{
		base.BaseGrayscaleSaturation = 0;
	}

	public override bool ShouldSerializeBaseGrayscaleSaturation()
	{
		return base.BaseGrayscaleSaturation != 0;
	}

	public override void ResetButtonBorderContrastKind()
	{
		base.ButtonBorderContrastKind = BorderContrastKind.Low;
	}

	public override bool ShouldSerializeButtonBorderContrastKind()
	{
		return base.ButtonBorderContrastKind != BorderContrastKind.Low;
	}

	public override void ResetContainerBorderContrastKind()
	{
		base.ContainerBorderContrastKind = BorderContrastKind.Low;
	}

	public override bool ShouldSerializeContainerBorderContrastKind()
	{
		return base.ContainerBorderContrastKind != BorderContrastKind.Low;
	}

	public override void ResetGrayMin()
	{
		base.GrayMin = 9;
	}

	public override bool ShouldSerializeGrayMin()
	{
		return base.GrayMin != 9;
	}

	public override void ResetPopupBorderContrastKind()
	{
		base.PopupBorderContrastKind = BorderContrastKind.Low;
	}

	public override bool ShouldSerializePopupBorderContrastKind()
	{
		return base.PopupBorderContrastKind != BorderContrastKind.Low;
	}

	public override void ResetPrimaryAccentColorFamilyName()
	{
		base.PrimaryAccentColorFamilyName = a7f;
	}

	public override bool ShouldSerializePrimaryAccentColorFamilyName()
	{
		return base.PrimaryAccentColorFamilyName != a7f;
	}

	public override void ResetWindowColorFamilyName()
	{
		base.WindowColorFamilyName = a7f;
	}

	public override bool ShouldSerializeWindowColorFamilyName()
	{
		return base.WindowColorFamilyName != a7f;
	}

	internal static bool Nti()
	{
		return Pts == null;
	}

	internal static OfficeBlackThemeDefinition ftp()
	{
		return Pts;
	}
}
