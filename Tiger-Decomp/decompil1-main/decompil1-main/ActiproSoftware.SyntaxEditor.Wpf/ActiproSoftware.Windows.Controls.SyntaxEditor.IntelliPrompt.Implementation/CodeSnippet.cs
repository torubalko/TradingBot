using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippet : ICodeSnippet, ICodeSnippetMetadata
{
	private List<ICodeSnippetDeclaration> sCK;

	private List<string> DCf;

	private List<string> DCD;

	private List<ICodeSnippetAssemblyReference> VCg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string aCQ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string cCe;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CodeSnippetKind lCl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string dCA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string HCv;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string rCm;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string SCC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string bCu;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CodeSnippetTypes FC1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object DCF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string IC3;

	internal static CodeSnippet yxb;

	public string Author
	{
		[CompilerGenerated]
		get
		{
			return aCQ;
		}
		[CompilerGenerated]
		set
		{
			aCQ = value;
		}
	}

	public string CodeDelimiter
	{
		[CompilerGenerated]
		get
		{
			return cCe;
		}
		[CompilerGenerated]
		set
		{
			cCe = value;
		}
	}

	public CodeSnippetKind CodeKind
	{
		[CompilerGenerated]
		get
		{
			return lCl;
		}
		[CompilerGenerated]
		set
		{
			lCl = value;
		}
	}

	public string CodeLanguage
	{
		[CompilerGenerated]
		get
		{
			return dCA;
		}
		[CompilerGenerated]
		set
		{
			dCA = value;
		}
	}

	public string CodeText
	{
		[CompilerGenerated]
		get
		{
			return HCv;
		}
		[CompilerGenerated]
		set
		{
			HCv = value;
		}
	}

	public IList<ICodeSnippetDeclaration> Declarations
	{
		get
		{
			if (sCK == null)
			{
				sCK = new List<ICodeSnippetDeclaration>();
			}
			return sCK;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return rCm;
		}
		[CompilerGenerated]
		set
		{
			rCm = value;
		}
	}

	public string HelpUrl
	{
		[CompilerGenerated]
		get
		{
			return SCC;
		}
		[CompilerGenerated]
		set
		{
			SCC = value;
		}
	}

	public IList<string> ImportedNamespaces
	{
		get
		{
			if (DCf == null)
			{
				DCf = new List<string>();
			}
			return DCf;
		}
	}

	public IList<string> Keywords
	{
		get
		{
			if (DCD == null)
			{
				DCD = new List<string>();
			}
			return DCD;
		}
	}

	public IList<ICodeSnippetAssemblyReference> References
	{
		get
		{
			if (VCg == null)
			{
				VCg = new List<ICodeSnippetAssemblyReference>();
			}
			return VCg;
		}
	}

	public string Shortcut
	{
		[CompilerGenerated]
		get
		{
			return bCu;
		}
		[CompilerGenerated]
		set
		{
			bCu = value;
		}
	}

	public CodeSnippetTypes SnippetTypes
	{
		[CompilerGenerated]
		get
		{
			return FC1;
		}
		[CompilerGenerated]
		set
		{
			FC1 = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return DCF;
		}
		[CompilerGenerated]
		set
		{
			DCF = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return IC3;
		}
		[CompilerGenerated]
		set
		{
			IC3 = value;
		}
	}

	public CodeSnippet()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	ICodeSnippet ICodeSnippetMetadata.GetCodeSnippet()
	{
		return this;
	}

	internal static bool rxs()
	{
		return yxb == null;
	}

	internal static CodeSnippet nxP()
	{
		return yxb;
	}
}
