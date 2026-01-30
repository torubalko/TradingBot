using System.Diagnostics.CodeAnalysis;
using System.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IImageSourceProvider
{
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ImageSource GetImageSource();
}
