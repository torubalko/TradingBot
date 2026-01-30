using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public abstract class MergableLexerBase : IMergableLexer, ILexer, IKeyedObject
{
	private class m6 : DisposableObject
	{
		private MergableLexerBase hsg;

		private static m6 wMt;

		public m6(MergableLexerBase P_0)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			hsg = P_0;
			P_0.smc();
		}

		protected override void Dispose(bool P_0)
		{
			if (hsg != null)
			{
				hsg.smm();
				hsg = null;
			}
			base.Dispose(P_0);
		}

		internal static bool iMW()
		{
			return wMt == null;
		}

		internal static m6 SMn()
		{
			return wMt;
		}
	}

	private int vmh;

	private object Umd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler HmL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalState bmq;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string qms;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ILexicalStateIdProvider emI;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITokenIdProvider Rm7;

	internal static MergableLexerBase kPS;

	string IKeyedObject.Key => KeyCore;

	ITokenIdProvider ILexer.TokenIdProvider => TokenIdProviderCore;

	ILexicalState IMergableLexer.DefaultLexicalState => DefaultLexicalStateCore;

	ILexicalStateIdProvider IMergableLexer.LexicalStateIdProvider => LexicalStateIdProviderCore;

	protected ILexicalState DefaultLexicalStateCore
	{
		[CompilerGenerated]
		get
		{
			return bmq;
		}
		[CompilerGenerated]
		set
		{
			bmq = value;
		}
	}

	protected string KeyCore
	{
		[CompilerGenerated]
		get
		{
			return qms;
		}
		[CompilerGenerated]
		set
		{
			qms = value;
		}
	}

	protected ILexicalStateIdProvider LexicalStateIdProviderCore
	{
		[CompilerGenerated]
		get
		{
			return emI;
		}
		[CompilerGenerated]
		set
		{
			emI = value;
		}
	}

	protected ITokenIdProvider TokenIdProviderCore
	{
		[CompilerGenerated]
		get
		{
			return Rm7;
		}
		[CompilerGenerated]
		set
		{
			Rm7 = value;
		}
	}

	public event EventHandler Changed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = HmL;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref HmL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = HmL;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref HmL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected MergableLexerBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Umd = new object();
		base._002Ector();
		KeyCore = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8454);
	}

	private void smm()
	{
		bool flag = false;
		lock (Umd)
		{
			if (vmh > 0)
			{
				vmh--;
			}
			flag = vmh == 0;
		}
		if (flag)
		{
			OnChanged(EventArgs.Empty);
		}
	}

	private void smc()
	{
		lock (Umd)
		{
			vmh++;
		}
	}

	public IDisposable CreateChangeBatch()
	{
		return new m6(this);
	}

	public virtual IMergableToken CreateDocumentEndToken(int startOffset, TextPosition startPosition, ILexicalState lexicalState)
	{
		return new MergableToken(startOffset, 0, startPosition, startPosition, MergableLexerFlags.None, lexicalState, new LexicalStateTokenData(lexicalState, -1));
	}

	public virtual IMergableToken CreateToken(int startOffset, int length, TextPosition startPosition, TextPosition endPosition, MergableLexerFlags lexerFlags, ILexicalState lexicalState, IMergableTokenLexerData lexerData)
	{
		return new MergableToken(startOffset, length, startPosition, endPosition, lexerFlags, lexicalState, lexerData);
	}

	public virtual MergableLexerResult GetDefaultToken(ITextBufferReader reader, ILexicalState lexicalState)
	{
		if (reader == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7880));
		}
		if (lexicalState == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7896));
		}
		reader.Read();
		return new MergableLexerResult(MatchType.LooseMatch, new LexicalStateTokenData(lexicalState, (byte)lexicalState.DefaultTokenId));
	}

	protected virtual TextSnapshotRange GetIncrementalParseRange(TextSnapshotRange snapshotRange)
	{
		return new TextSnapshotRange(snapshotRange.Snapshot, snapshotRange.StartLine.StartOffset, snapshotRange.EndOffset);
	}

	public abstract IEnumerable<ILexicalStateTransition> GetAllLexicalStateTransitions();

	public abstract MergableLexerResult GetNextToken(ITextBufferReader reader, ILexicalState lexicalState);

	protected virtual void OnChanged(EventArgs e)
	{
		HmL?.Invoke(this, e);
	}

	public virtual TextRange Parse(TextSnapshotRange snapshotRange, ILexerTarget parseTarget)
	{
		if (parseTarget == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8476));
		}
		if (!parseTarget.HasInitialContext)
		{
			snapshotRange = GetIncrementalParseRange(snapshotRange);
		}
		return MergableLexerCoordinator.Parse(snapshotRange, parseTarget);
	}

	internal static bool gPB()
	{
		return kPS == null;
	}

	internal static MergableLexerBase KPz()
	{
		return kPS;
	}
}
