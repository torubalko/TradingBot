using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public interface IIntelliPromptSession : IServiceLocator
{
	Rect? Bounds { get; }

	bool ClosesOnLostFocus { get; }

	bool IsOpen { get; }

	IIntelliPromptSessionType SessionType { get; }

	TextSnapshotRange SnapshotRange { get; }

	IEditorView View { get; }

	event EventHandler<CancelEventArgs> Closed;

	event EventHandler Opened;

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "cancelled")]
	void Close(bool cancelled);

	void Open(IEditorView view, TextRange textRange);

	void Reposition();
}
