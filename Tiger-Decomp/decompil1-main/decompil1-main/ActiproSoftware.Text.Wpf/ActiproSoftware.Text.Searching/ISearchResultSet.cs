namespace ActiproSoftware.Text.Searching;

public interface ISearchResultSet
{
	ISearchOptions Options { get; set; }

	SearchOperationType OperationType { get; set; }

	ISearchResultCollection Results { get; }

	bool Wrapped { get; set; }
}
