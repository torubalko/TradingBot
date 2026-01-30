using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class SignatureItem : ISignatureItem
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IContentProvider TRG;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object hRX;

	private static SignatureItem cgS;

	public IContentProvider ContentProvider
	{
		[CompilerGenerated]
		get
		{
			return TRG;
		}
		[CompilerGenerated]
		set
		{
			TRG = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return hRX;
		}
		[CompilerGenerated]
		set
		{
			hRX = value;
		}
	}

	public SignatureItem(IContentProvider contentProvider)
	{
		grA.DaB7cz();
		this._002Ector(contentProvider, null);
	}

	public SignatureItem(IContentProvider contentProvider, object tag)
	{
		grA.DaB7cz();
		base._002Ector();
		ContentProvider = contentProvider;
		Tag = tag;
	}

	internal static bool hgk()
	{
		return cgS == null;
	}

	internal static SignatureItem agZ()
	{
		return cgS;
	}
}
