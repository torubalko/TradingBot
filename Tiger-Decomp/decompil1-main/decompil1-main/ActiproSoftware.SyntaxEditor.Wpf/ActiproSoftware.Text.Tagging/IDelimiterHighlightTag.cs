using ActiproSoftware.Text.Analysis;

namespace ActiproSoftware.Text.Tagging;

public interface IDelimiterHighlightTag : ITag
{
	StructureMatchEdges MatchEdges { get; }
}
