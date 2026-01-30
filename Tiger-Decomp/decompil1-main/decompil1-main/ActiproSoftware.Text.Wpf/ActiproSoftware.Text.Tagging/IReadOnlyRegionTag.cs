namespace ActiproSoftware.Text.Tagging;

public interface IReadOnlyRegionTag : ITag
{
	bool IncludeFirstEdge { get; set; }

	bool IncludeLastEdge { get; set; }

	bool IsReadOnly { get; }
}
