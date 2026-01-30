using System;
using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface IDataFactoryRequest
{
	bool AreAttachedPropertiesBrowsable { get; }

	bool AreCategoriesAutoExpanded { get; }

	bool AreInheritedPropertiesBrowsable { get; }

	bool AreNestedCategoriesSupported { get; }

	bool ArePropertiesAutoExpanded { get; }

	bool AreReadOnlyPropertiesBrowsable { get; }

	IEnumerable<Attribute> BrowsableAttributes { get; }

	IEnumerable<CategoryEditor> CategoryEditors { get; }

	CollectionPropertyDisplayMode CollectionPropertyDisplayMode { get; }

	IList<object> DataObjects { get; }

	bool IsCategorized { get; }

	bool IsHostReadOnly { get; }

	string MiscCategoryName { get; }

	IDataModel Parent { get; }

	IEnumerable<IPropertyModel> Properties { get; }

	PropertyExpandability PropertyExpandability { get; }

	DataModelSortComparer SortComparer { get; }

	object Source { get; }

	object Tag { get; set; }
}
