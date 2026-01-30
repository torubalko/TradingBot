using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class LexicalScopeStateNode : ILexicalScopeStateNode
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalScope z21;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalState y24;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalScopeStateNode z2K;

	internal static LexicalScopeStateNode sPE;

	public ILexicalScope LexicalScope
	{
		[CompilerGenerated]
		get
		{
			return z21;
		}
		[CompilerGenerated]
		set
		{
			z21 = value;
		}
	}

	public ILexicalState LexicalState
	{
		[CompilerGenerated]
		get
		{
			return y24;
		}
		[CompilerGenerated]
		set
		{
			y24 = value;
		}
	}

	public ILexicalScopeStateNode Parent
	{
		[CompilerGenerated]
		get
		{
			return z2K;
		}
		[CompilerGenerated]
		set
		{
			z2K = value;
		}
	}

	[SpecialName]
	private int R2o()
	{
		int num = 0;
		for (ILexicalScopeStateNode lexicalScopeStateNode = this; lexicalScopeStateNode != null; lexicalScopeStateNode = lexicalScopeStateNode.Parent)
		{
			num++;
		}
		return num;
	}

	public override bool Equals(object obj)
	{
		ILexicalScopeStateNode lexicalScopeStateNode = obj as ILexicalScopeStateNode;
		if (lexicalScopeStateNode == this)
		{
			return true;
		}
		if (lexicalScopeStateNode == null)
		{
			return false;
		}
		if (LexicalState != lexicalScopeStateNode.LexicalState || LexicalScope != lexicalScopeStateNode.LexicalScope)
		{
			return false;
		}
		if (Parent != null)
		{
			return Parent.Equals(lexicalScopeStateNode.Parent);
		}
		return lexicalScopeStateNode.Parent == null;
	}

	public override int GetHashCode()
	{
		return ((LexicalScope != null) ? LexicalScope.GetHashCode() : 0) ^ ((LexicalState != null) ? LexicalState.GetHashCode() : 0) ^ base.GetHashCode();
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8146) + R2o() + ((LexicalState != null) ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8206) + LexicalState.Key) : string.Empty) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public LexicalScopeStateNode()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool uPG()
	{
		return sPE == null;
	}

	internal static LexicalScopeStateNode qPh()
	{
		return sPE;
	}
}
