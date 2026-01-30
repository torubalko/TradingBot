using System.Windows.Input;
using System.Xml;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditAction : IKeyedObject, ICommand
{
	bool CanRecordInMacro { get; }

	bool CanExecute(IEditorView view);

	CommandBinding CreateCommandBinding();

	CommandBinding CreateCommandBinding(ICommand alternateCommand);

	void Execute(IEditorView view);

	void ReadFromXml(XmlReader reader);

	void WriteToXml(XmlWriter writer);
}
