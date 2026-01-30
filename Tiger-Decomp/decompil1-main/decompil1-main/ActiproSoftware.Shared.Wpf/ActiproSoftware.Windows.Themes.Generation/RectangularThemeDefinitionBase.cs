using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public abstract class RectangularThemeDefinitionBase : ThemeDefinition
{
	private static RectangularThemeDefinitionBase Cf7;

	protected RectangularThemeDefinitionBase(string themeName, ThemeIntent intent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(themeName, intent);
		ResetButtonCornerRadius();
		ResetCheckBoxCornerRadius();
		ResetScrollBarThumbCornerRadius();
		ResetTabCornerRadius();
		ResetToolBarButtonCornerRadius();
	}

	public override void ResetButtonCornerRadius()
	{
		base.ButtonCornerRadius = 0.0;
	}

	public override bool ShouldSerializeButtonCornerRadius()
	{
		return base.ButtonCornerRadius != 0.0;
	}

	public override void ResetCheckBoxCornerRadius()
	{
		base.CheckBoxCornerRadius = 0.0;
	}

	public override bool ShouldSerializeCheckBoxCornerRadius()
	{
		return base.CheckBoxCornerRadius != 0.0;
	}

	public override void ResetScrollBarThumbCornerRadius()
	{
		base.ScrollBarThumbCornerRadius = 0.0;
	}

	public override bool ShouldSerializeScrollBarThumbCornerRadius()
	{
		return base.ScrollBarThumbCornerRadius != 0.0;
	}

	public override void ResetTabCornerRadius()
	{
		base.TabCornerRadius = 0.0;
	}

	public override bool ShouldSerializeTabCornerRadius()
	{
		return base.TabCornerRadius != 0.0;
	}

	public override void ResetToolBarButtonCornerRadius()
	{
		base.ToolBarButtonCornerRadius = 0.0;
	}

	public override bool ShouldSerializeToolBarButtonCornerRadius()
	{
		return base.ToolBarButtonCornerRadius != 0.0;
	}

	internal static bool RfH()
	{
		return Cf7 == null;
	}

	internal static RectangularThemeDefinitionBase GfJ()
	{
		return Cf7;
	}
}
