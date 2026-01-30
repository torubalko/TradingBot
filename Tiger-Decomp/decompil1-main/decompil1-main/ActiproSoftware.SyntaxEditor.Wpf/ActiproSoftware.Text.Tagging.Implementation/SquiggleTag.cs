using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class SquiggleTag : ISquiggleTag, ITag
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IClassificationType UIL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IContentProvider cIn;

	private static SquiggleTag I56;

	public IClassificationType ClassificationType
	{
		[CompilerGenerated]
		get
		{
			return UIL;
		}
		[CompilerGenerated]
		set
		{
			UIL = value;
		}
	}

	public IContentProvider ContentProvider
	{
		[CompilerGenerated]
		get
		{
			return cIn;
		}
		[CompilerGenerated]
		set
		{
			cIn = value;
		}
	}

	public SquiggleTag()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	public SquiggleTag(IClassificationType classificationType)
	{
		grA.DaB7cz();
		this._002Ector(classificationType, null);
	}

	public SquiggleTag(IContentProvider contentProvider)
	{
		grA.DaB7cz();
		this._002Ector(null, contentProvider);
	}

	public SquiggleTag(IClassificationType classificationType, IContentProvider contentProvider)
	{
		grA.DaB7cz();
		this._002Ector();
		ClassificationType = classificationType;
		ContentProvider = contentProvider;
	}

	internal static bool r5K()
	{
		return I56 == null;
	}

	internal static SquiggleTag O5C()
	{
		return I56;
	}
}
