using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IContentProvider
{
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	object GetContent();
}
