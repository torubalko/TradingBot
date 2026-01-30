using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Text.Tagging;

public interface ISquiggleTag : ITag
{
	IClassificationType ClassificationType { get; set; }

	IContentProvider ContentProvider { get; set; }
}
