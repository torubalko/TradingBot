using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IHitTestResult
{
	TagSnapshotRange<IIntraTextSpacerTag> IntraTextSpacerTag { get; }

	Point Location { get; }

	int Offset { get; }

	TextPosition Position { get; }

	ITextSnapshot Snapshot { get; }

	SyntaxEditor SyntaxEditor { get; }

	Point TextAreaLocation { get; }

	HitTestResultType Type { get; }

	IEditorView View { get; }

	ITextViewLine ViewLine { get; }

	IEditorViewMargin ViewMargin { get; }

	FrameworkElement VisualElement { get; }

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ITextSnapshotReader GetReader();
}
