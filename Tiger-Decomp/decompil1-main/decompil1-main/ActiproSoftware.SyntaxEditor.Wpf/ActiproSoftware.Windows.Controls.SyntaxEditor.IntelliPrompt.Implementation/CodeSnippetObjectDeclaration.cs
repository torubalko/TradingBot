using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetObjectDeclaration : CodeSnippetDeclarationBase, ICodeSnippetObjectDeclaration, ICodeSnippetDeclaration
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string fCh;

	private static CodeSnippetObjectDeclaration jaL;

	public string Type
	{
		[CompilerGenerated]
		get
		{
			return fCh;
		}
		[CompilerGenerated]
		set
		{
			fCh = value;
		}
	}

	public CodeSnippetObjectDeclaration()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool Wag()
	{
		return jaL == null;
	}

	internal static CodeSnippetObjectDeclaration zaA()
	{
		return jaL;
	}
}
