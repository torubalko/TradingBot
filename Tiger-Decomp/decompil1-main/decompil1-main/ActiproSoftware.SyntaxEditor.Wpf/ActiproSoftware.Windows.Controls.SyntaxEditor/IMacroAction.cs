using System.Windows.Input;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IMacroAction : IEditAction, IKeyedObject, ICommand
{
	bool IsEmpty { get; }

	void Add(IEditAction action);
}
