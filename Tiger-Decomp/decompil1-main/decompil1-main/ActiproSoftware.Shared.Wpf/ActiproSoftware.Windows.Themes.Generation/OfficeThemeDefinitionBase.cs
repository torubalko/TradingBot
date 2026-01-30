using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public abstract class OfficeThemeDefinitionBase : RectangularThemeDefinitionBase
{
	private static OfficeThemeDefinitionBase Ktz;

	protected OfficeThemeDefinitionBase(string themeName, ThemeIntent intent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, intent);
		ResetColorPaletteKind();
		ResetGrayMin();
		ResetGraySilverRatio();
		ResetRequireDarkerBorders();
	}

	public override void ResetColorPaletteKind()
	{
		base.ColorPaletteKind = ColorPaletteKind.Office;
	}

	public override bool ShouldSerializeColorPaletteKind()
	{
		return base.ColorPaletteKind != ColorPaletteKind.Office;
	}

	public override void ResetGrayMin()
	{
		base.GrayMin = 17;
	}

	public override bool ShouldSerializeGrayMin()
	{
		return base.GrayMin != 17;
	}

	public override void ResetGraySilverRatio()
	{
		base.GraySilverRatio = 0.55;
	}

	public override bool ShouldSerializeGraySilverRatio()
	{
		return base.GraySilverRatio != 0.55;
	}

	public override void ResetRequireDarkerBorders()
	{
		base.RequireDarkerBorders = false;
	}

	public override bool ShouldSerializeRequireDarkerBorders()
	{
		return base.RequireDarkerBorders;
	}

	internal static bool EfK()
	{
		return Ktz == null;
	}

	internal static OfficeThemeDefinitionBase TfM()
	{
		return Ktz;
	}
}
