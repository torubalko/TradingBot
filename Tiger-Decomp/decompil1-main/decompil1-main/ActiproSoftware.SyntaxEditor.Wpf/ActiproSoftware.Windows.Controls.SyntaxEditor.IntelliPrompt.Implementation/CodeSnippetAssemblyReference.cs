using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetAssemblyReference : ICodeSnippetAssemblyReference
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string sCR;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string qCY;

	private static CodeSnippetAssemblyReference Lxo;

	public string Assembly
	{
		[CompilerGenerated]
		get
		{
			return sCR;
		}
		[CompilerGenerated]
		set
		{
			sCR = value;
		}
	}

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return qCY;
		}
		[CompilerGenerated]
		set
		{
			qCY = value;
		}
	}

	public CodeSnippetAssemblyReference()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool JxQ()
	{
		return Lxo == null;
	}

	internal static CodeSnippetAssemblyReference axy()
	{
		return Lxo;
	}
}
