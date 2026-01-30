using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class DirectImageSourceProvider : IImageSourceProvider
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource XFG;

	private static DirectImageSourceProvider kLZ;

	public ImageSource ImageSource
	{
		[CompilerGenerated]
		get
		{
			return XFG;
		}
		[CompilerGenerated]
		set
		{
			XFG = value;
		}
	}

	public DirectImageSourceProvider(ImageSource imageSource)
	{
		grA.DaB7cz();
		base._002Ector();
		ImageSource = imageSource;
	}

	ImageSource IImageSourceProvider.GetImageSource()
	{
		return ImageSource;
	}

	internal static bool wLF()
	{
		return kLZ == null;
	}

	internal static DirectImageSourceProvider kL9()
	{
		return kLZ;
	}
}
