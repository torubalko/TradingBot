using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class CodeSnippetDeclarationBase : ICodeSnippetDeclaration
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string SC4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string BCo;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string xCj;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool BCw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string WC6;

	internal static CodeSnippetDeclarationBase lxh;

	public string DefaultText
	{
		[CompilerGenerated]
		get
		{
			return SC4;
		}
		[CompilerGenerated]
		set
		{
			SC4 = value;
		}
	}

	public string FunctionInvocation
	{
		[CompilerGenerated]
		get
		{
			return BCo;
		}
		[CompilerGenerated]
		set
		{
			BCo = value;
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return xCj;
		}
		[CompilerGenerated]
		set
		{
			xCj = value;
		}
	}

	public bool IsEditable
	{
		[CompilerGenerated]
		get
		{
			return BCw;
		}
		[CompilerGenerated]
		set
		{
			BCw = value;
		}
	}

	public string ToolTip
	{
		[CompilerGenerated]
		get
		{
			return WC6;
		}
		[CompilerGenerated]
		set
		{
			WC6 = value;
		}
	}

	protected CodeSnippetDeclarationBase()
	{
		grA.DaB7cz();
		base._002Ector();
		IsEditable = true;
	}

	internal static bool Lx6()
	{
		return lxh == null;
	}

	internal static CodeSnippetDeclarationBase zxK()
	{
		return lxh;
	}
}
