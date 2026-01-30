using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class Xx : IClassificationTag, ITag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ICodeSnippetDeclaration CCr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool BCs;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool MCk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool ACS;

	internal static Xx PxE;

	public IClassificationType ClassificationType
	{
		get
		{
			if (IsActive || !nC8())
			{
				return nC8() ? cT.CodeSnippetDependentField : cT.CodeSnippetField;
			}
			return null;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return BCs;
		}
		[CompilerGenerated]
		set
		{
			BCs = bCs;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public ICodeSnippetDeclaration xCH()
	{
		return CCr;
	}

	[SpecialName]
	[CompilerGenerated]
	public void jCb(ICodeSnippetDeclaration P_0)
	{
		CCr = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool nC8()
	{
		return MCk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void FCI(bool P_0)
	{
		MCk = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool fC0()
	{
		return ACS;
	}

	[SpecialName]
	[CompilerGenerated]
	public void pCB(bool P_0)
	{
		ACS = P_0;
	}

	public Xx()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool Rxw()
	{
		return PxE == null;
	}

	internal static Xx bxu()
	{
		return PxE;
	}
}
