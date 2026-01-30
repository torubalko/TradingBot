using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public abstract class LexicalStateBase : ILexicalState, IKeyedObject
{
	private ILexicalStateCollection I23;

	private ILexicalScopeCollection n2J;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int b2X;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Q2N;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int O2R;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string g2f;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexer q2t;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object O2Q;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalStateTransition x2n;

	private static LexicalStateBase uPk;

	ILexicalStateCollection ILexicalState.ChildLexicalStates => I23;

	ILexer ILexicalState.Lexer => LexerCore;

	ILexicalScopeCollection ILexicalState.LexicalScopes => n2J;

	protected ILexicalStateCollection ChildLexicalStatesCore => I23;

	public int DefaultTokenId
	{
		[CompilerGenerated]
		get
		{
			return b2X;
		}
		[CompilerGenerated]
		set
		{
			b2X = value;
		}
	}

	public string DefaultTokenKey
	{
		[CompilerGenerated]
		get
		{
			return Q2N;
		}
		[CompilerGenerated]
		set
		{
			Q2N = value;
		}
	}

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return O2R;
		}
		[CompilerGenerated]
		set
		{
			O2R = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return g2f;
		}
		[CompilerGenerated]
		private set
		{
			g2f = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	protected internal ILexer LexerCore
	{
		[CompilerGenerated]
		get
		{
			return q2t;
		}
		[CompilerGenerated]
		set
		{
			q2t = value;
		}
	}

	protected ILexicalScopeCollection LexicalScopesCore => n2J;

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return O2Q;
		}
		[CompilerGenerated]
		set
		{
			O2Q = value;
		}
	}

	public ILexicalStateTransition Transition
	{
		[CompilerGenerated]
		get
		{
			return x2n;
		}
		[CompilerGenerated]
		set
		{
			x2n = value;
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected LexicalStateBase(int id, string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Id = id;
		Key = key;
		DefaultTokenKey = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7862);
		I23 = CreateChildLexicalStates();
		n2J = CreateLexicalScopes();
	}

	protected virtual ILexicalStateCollection CreateChildLexicalStates()
	{
		return new LexicalStateCollection(null);
	}

	protected virtual ILexicalScopeCollection CreateLexicalScopes()
	{
		return new LexicalScopeCollection(this);
	}

	internal static bool sPX()
	{
		return uPk == null;
	}

	internal static LexicalStateBase HP3()
	{
		return uPk;
	}
}
