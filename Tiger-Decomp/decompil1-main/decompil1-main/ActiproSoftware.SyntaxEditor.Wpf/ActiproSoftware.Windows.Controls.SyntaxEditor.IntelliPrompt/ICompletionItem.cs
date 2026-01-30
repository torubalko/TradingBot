using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionItem
{
	string AutoCompletePostText { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PreText")]
	string AutoCompletePreText { get; }

	IContentProvider DescriptionProvider { get; }

	IImageSourceProvider ImageSourceProvider { get; }

	object Tag { get; set; }

	string Text { get; }
}
