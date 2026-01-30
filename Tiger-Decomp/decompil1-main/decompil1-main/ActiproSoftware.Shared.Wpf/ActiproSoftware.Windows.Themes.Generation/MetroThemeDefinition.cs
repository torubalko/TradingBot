using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public class MetroThemeDefinition : RectangularThemeDefinitionBase
{
	private static MetroThemeDefinition VtU;

	public MetroThemeDefinition(string themeName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(themeName, ThemeIntent.Light);
	}

	public MetroThemeDefinition(string themeName, ThemeIntent intent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, intent);
		ResetGrayMin();
		ResetGraySilverRatio();
		ResetRequireDarkerBorders();
		ResetStatusBarBackgroundKind();
		ResetWindowBorderKind();
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

	internal static bool ttL()
	{
		return VtU == null;
	}

	internal static MetroThemeDefinition it4()
	{
		return VtU;
	}
}
