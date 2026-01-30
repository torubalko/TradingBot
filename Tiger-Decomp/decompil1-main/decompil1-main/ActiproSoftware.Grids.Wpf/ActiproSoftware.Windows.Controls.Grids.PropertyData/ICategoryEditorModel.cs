using System;
using System.Windows;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface ICategoryEditorModel : IDataModel, IDisposable
{
	DataTemplate EditorTemplate { get; }

	object EditorTemplateKey { get; }
}
