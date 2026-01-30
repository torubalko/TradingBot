using ActiproSoftware.Text.Tagging.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

public interface IBreakpointIndicatorManager : ITextRangeIndicatorManager<BreakpointIndicatorTagger, BreakpointIndicatorTag>
{
	bool ToggleEnabledState(BreakpointIndicatorTag tag);
}
