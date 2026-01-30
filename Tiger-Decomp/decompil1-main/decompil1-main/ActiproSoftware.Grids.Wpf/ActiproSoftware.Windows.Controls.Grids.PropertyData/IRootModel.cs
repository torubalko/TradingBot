using System;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface IRootModel : IPropertyModel, IDataModel, IDisposable
{
	object Source { get; }
}
