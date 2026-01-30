using System;

namespace ActiproSoftware.Windows.Data.Filtering;

public interface IDataFilter
{
	bool IsEnabled { get; set; }

	event EventHandler FilterChanged;

	DataFilterResult Filter(object item, object context);
}
