using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IDataStore
{
	DataStoreTextKind TextKind { get; }

	object GetData(string format);

	bool GetDataPresent(string format);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	string GetText();

	void SetData(string format, object data);

	void SetText(string text, DataStoreTextKind textKind);

	IDataObject ToDataObject();
}
