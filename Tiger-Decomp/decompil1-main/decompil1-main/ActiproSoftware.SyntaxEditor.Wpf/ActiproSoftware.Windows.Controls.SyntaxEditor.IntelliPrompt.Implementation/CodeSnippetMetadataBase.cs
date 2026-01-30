using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class CodeSnippetMetadataBase : ICodeSnippetMetadata
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CodeSnippetKind vCM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string FCO;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string wCU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string zCJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CodeSnippetTypes yCt;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string QCZ;

	private static CodeSnippetMetadataBase saq;

	public CodeSnippetKind CodeKind
	{
		[CompilerGenerated]
		get
		{
			return vCM;
		}
		[CompilerGenerated]
		set
		{
			vCM = value;
		}
	}

	public string CodeLanguage
	{
		[CompilerGenerated]
		get
		{
			return FCO;
		}
		[CompilerGenerated]
		set
		{
			FCO = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return wCU;
		}
		[CompilerGenerated]
		set
		{
			wCU = value;
		}
	}

	public string Shortcut
	{
		[CompilerGenerated]
		get
		{
			return zCJ;
		}
		[CompilerGenerated]
		set
		{
			zCJ = value;
		}
	}

	public CodeSnippetTypes SnippetTypes
	{
		[CompilerGenerated]
		get
		{
			return yCt;
		}
		[CompilerGenerated]
		set
		{
			yCt = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return QCZ;
		}
		[CompilerGenerated]
		set
		{
			QCZ = value;
		}
	}

	protected CodeSnippetMetadataBase()
	{
		grA.DaB7cz();
		base._002Ector();
		SnippetTypes = CodeSnippetTypes.Expansion;
	}

	public abstract ICodeSnippet GetCodeSnippet();

	internal static bool uax()
	{
		return saq == null;
	}

	internal static CodeSnippetMetadataBase Waa()
	{
		return saq;
	}
}
