using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public abstract class LexicalScopeBase : ILexicalScope
{
	private ILexicalStateTransition B25;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool g26;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalState d2Z;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object v20;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalStateTransition W2v;

	internal static LexicalScopeBase nPK;

	ILexicalState ILexicalScope.LexicalState => LexicalStateCore;

	ILexicalStateTransition ILexicalScope.ParentTransition => B25;

	public bool IsAncestorEndScopeCheckEnabled
	{
		[CompilerGenerated]
		get
		{
			return g26;
		}
		[CompilerGenerated]
		set
		{
			g26 = value;
		}
	}

	protected internal ILexicalState LexicalStateCore
	{
		[CompilerGenerated]
		get
		{
			return d2Z;
		}
		[CompilerGenerated]
		set
		{
			d2Z = value;
		}
	}

	protected internal ILexicalStateTransition ParentTransitionCore
	{
		get
		{
			return B25;
		}
		set
		{
			if (B25 == value)
			{
				return;
			}
			if (B25 is LexicalStateTransition lexicalStateTransition && lexicalStateTransition.ParentLexicalScope == this)
			{
				lexicalStateTransition.ParentLexicalScope = null;
			}
			B25 = value;
			LexicalStateTransition lexicalStateTransition2 = B25 as LexicalStateTransition;
			bool flag = lexicalStateTransition2 != null;
			int num = 0;
			if (IPo() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				lexicalStateTransition2.ParentLexicalScope = this;
			}
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return v20;
		}
		[CompilerGenerated]
		set
		{
			v20 = value;
		}
	}

	public ILexicalStateTransition Transition
	{
		[CompilerGenerated]
		get
		{
			return W2v;
		}
		[CompilerGenerated]
		set
		{
			W2v = value;
		}
	}

	protected LexicalScopeBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		IsAncestorEndScopeCheckEnabled = true;
	}

	public abstract MergableLexerResult IsScopeEnd(ITextBufferReader reader);

	public abstract MergableLexerResult IsScopeStart(ITextBufferReader reader);

	internal static bool APl()
	{
		return nPK == null;
	}

	internal static LexicalScopeBase IPo()
	{
		return nPK;
	}
}
