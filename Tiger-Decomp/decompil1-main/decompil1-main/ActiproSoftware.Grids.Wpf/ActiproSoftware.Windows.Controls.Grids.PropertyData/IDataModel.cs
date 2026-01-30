using System;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface IDataModel : IDisposable
{
	bool CanAutoDispose { get; }

	DataModelCollection Children { get; }

	string Description { get; }

	string DisplayName { get; }

	bool IsExpanded { get; set; }

	bool IsInitialized { get; set; }

	bool IsModified { get; }

	bool IsRoot { get; }

	bool IsSelected { get; set; }

	string Name { get; }

	IDataModel Parent { get; set; }

	DataModelSortComparer SortComparer { get; set; }

	DataModelSortImportance SortImportance { get; }

	int SortOrder { get; }

	object Tag { get; set; }
}
