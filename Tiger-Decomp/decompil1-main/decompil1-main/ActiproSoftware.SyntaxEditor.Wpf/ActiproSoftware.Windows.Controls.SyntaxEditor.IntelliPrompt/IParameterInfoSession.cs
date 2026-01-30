using System;
using System.Windows.Input;
using System.Windows.Navigation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IParameterInfoSession : IIntelliPromptSession, IServiceLocator
{
	object Content { get; }

	int DisplaySelectedIndex { get; }

	bool HasSelectionChanged { get; }

	bool IsArrowKeySelectionEnabled { get; }

	ISignatureItemCollection Items { get; }

	double MaxWidth { get; }

	ISignatureItem Selection { get; set; }

	ICommand SelectNextCommand { get; }

	ICommand SelectPreviousCommand { get; }

	event RequestNavigateEventHandler RequestNavigate;

	event EventHandler SelectionChanged;

	void Refresh();

	void SelectNext();

	void SelectPrevious();
}
