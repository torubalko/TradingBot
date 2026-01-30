using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class DirectContentProvider : IContentProvider
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object GFx;

	internal static DirectContentProvider KLW;

	public object Content
	{
		[CompilerGenerated]
		get
		{
			return GFx;
		}
		[CompilerGenerated]
		set
		{
			GFx = value;
		}
	}

	public DirectContentProvider(object content)
	{
		grA.DaB7cz();
		base._002Ector();
		Content = content;
	}

	object IContentProvider.GetContent()
	{
		return Content;
	}

	internal static bool jLS()
	{
		return KLW == null;
	}

	internal static DirectContentProvider yLk()
	{
		return KLW;
	}
}
