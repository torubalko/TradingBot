using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public class MergableLexerCoordinator
{
	private ILexerContext Rmw;

	private IMergableLexer tmH;

	private MergableLexerFlags kmP;

	private IMergableLexer rmp;

	private MergableLexerFlags Cmb;

	private List<ILexicalScope> KmC;

	private ILexicalState zmU;

	private List<ILexicalState> mma;

	private int Xmj;

	private int XmF;

	private ITextBufferReader tmx;

	private MergableLexerResult Xmg;

	private IMergableLexer emO;

	private ILexicalScopeStateNode nml;

	private int ymi;

	private TextPosition GmW;

	private IMergableToken Rm5;

	private int Nm6;

	private bool YmZ;

	private List<int> dm0;

	private List<IMergableToken> dmv;

	internal static MergableLexerCoordinator gUd;

	private MergableLexerCoordinator(ITextBufferReader reader, IMergableLexer rootLexer, ILexerContext context)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		kmP = MergableLexerFlags.None;
		KmC = new List<ILexicalScope>();
		mma = new List<ILexicalState>();
		base._002Ector();
		if (reader == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7880));
		}
		if (rootLexer == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8502));
		}
		tmx = reader;
		tmH = rootLexer;
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		rmp = rootLexer;
		emO = rootLexer;
		Rmw = context;
		zmU = rootLexer.DefaultLexicalState;
	}

	internal static IDictionary<IMergableLexer, ISyntaxLanguage> GetChildLexerLanguageMappings(ISyntaxLanguage rootLanguage)
	{
		if (rootLanguage == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8524));
		}
		Dictionary<IMergableLexer, ISyntaxLanguage> dictionary = new Dictionary<IMergableLexer, ISyntaxLanguage>();
		if (rootLanguage.GetService<ILexer>() is IMergableLexer mergableLexer)
		{
			PmM(dictionary, rootLanguage, mergableLexer);
		}
		return dictionary;
	}

	private static void PmM(Dictionary<IMergableLexer, ISyntaxLanguage> P_0, ISyntaxLanguage P_1, IMergableLexer P_2)
	{
		if (!P_0.ContainsKey(P_2))
		{
			P_0[P_2] = P_1;
		}
		IEnumerable<ILexicalStateTransition> allLexicalStateTransitions = P_2.GetAllLexicalStateTransitions();
		if (allLexicalStateTransitions == null)
		{
			return;
		}
		foreach (ILexicalStateTransition item in allLexicalStateTransitions)
		{
			if (item != null && item.ChildLanguage != null && item.ChildLexicalState != null)
			{
				P_2 = item.ChildLexicalState.Lexer as IMergableLexer;
				if (P_2 != null)
				{
					PmM(P_0, item.ChildLanguage, P_2);
				}
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public static MergableLexerCoordinator Create(ITextBufferReader reader, IMergableLexer rootLexer)
	{
		if (reader == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7880));
		}
		if (rootLexer != null)
		{
			return new MergableLexerCoordinator(reader, rootLexer, null);
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8502));
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public IMergableToken GetNextToken()
	{
		if (dmv != null)
		{
			if (YmZ)
			{
				if (dm0[0] < dmv.Count)
				{
					IMergableToken mergableToken = dmv[dm0[0]++];
					if (mergableToken != null)
					{
						while (tmx.Offset < mergableToken.EndOffset)
						{
							tmx.Read();
						}
					}
					return mergableToken;
				}
				dm0[0]++;
			}
			else if (dmv.Count > 0)
			{
				IMergableToken mergableToken2 = dmv[0];
				dmv.RemoveAt(0);
				if (mergableToken2 != null)
				{
					while (tmx.Offset < mergableToken2.EndOffset)
					{
						tmx.Read();
					}
				}
				return mergableToken2;
			}
		}
		if (Rm5 != null)
		{
			switch (kmP)
			{
			case MergableLexerFlags.ScopeStart:
			case MergableLexerFlags.DirectStateTransition:
				zmU = zmU.ChildLexicalStates[XmF];
				KmC.Insert(0, zmU.LexicalScopes[Xmj]);
				mma.Insert(0, zmU);
				nml = new LexicalScopeStateNode
				{
					LexicalScope = zmU.LexicalScopes[Xmj],
					LexicalState = zmU,
					Parent = nml
				};
				if (kmP == MergableLexerFlags.DirectStateTransition)
				{
					zmU = zmU.Transition.ChildLexicalState;
					mma[0] = zmU;
					nml.LexicalState = zmU;
				}
				tmH = rmp;
				rmp = (IMergableLexer)zmU.Lexer;
				break;
			case MergableLexerFlags.ScopeEnd:
			case MergableLexerFlags.ScopeStateTransitionStart:
			case MergableLexerFlags.ScopeStateTransitionEnd:
			{
				for (int num = XmF; num >= 0; num--)
				{
					nml = nml.Parent;
				}
				KmC.RemoveRange(0, XmF + 1);
				mma.RemoveRange(0, XmF + 1);
				MergableLexerFlags mergableLexerFlags = kmP;
				MergableLexerFlags mergableLexerFlags2 = mergableLexerFlags;
				if (mergableLexerFlags2 != MergableLexerFlags.ScopeStateTransitionStart)
				{
					if (mergableLexerFlags2 == MergableLexerFlags.ScopeStateTransitionEnd)
					{
						while (tmx.Offset > Rm5.StartOffset)
						{
							tmx.ReadReverse();
						}
						if (mma.Count > 0)
						{
							zmU = mma[0];
						}
						else
						{
							zmU = emO.DefaultLexicalState;
						}
					}
					else if (mma.Count > 0)
					{
						zmU = mma[0];
					}
					else
					{
						zmU = emO.DefaultLexicalState;
					}
				}
				else
				{
					zmU = Rm5.LexicalScope.Transition.ChildLexicalState;
					KmC.Insert(0, Rm5.LexicalScope.Transition.ChildLexicalScope);
					mma.Insert(0, zmU);
					nml = new LexicalScopeStateNode
					{
						LexicalScope = Rm5.LexicalScope.Transition.ChildLexicalScope,
						LexicalState = zmU,
						Parent = nml
					};
				}
				tmH = rmp;
				rmp = (IMergableLexer)zmU.Lexer;
				break;
			}
			}
		}
		else if (tmx.Offset > 0 && Rmw != null && Rmw.ScopeState != null)
		{
			nml = Rmw.ScopeState;
			for (zmU = nml.LexicalState; nml != null; nml = nml.Parent)
			{
				KmC.Add(nml.LexicalScope);
				mma.Add(nml.LexicalState);
			}
			nml = Rmw.ScopeState;
			if (mma.Count > 0)
			{
				zmU = mma[0];
			}
			else
			{
				zmU = emO.DefaultLexicalState;
			}
			rmp = (IMergableLexer)zmU.Lexer;
		}
		if (tmx.IsAtEnd)
		{
			kmP = MergableLexerFlags.None;
			return rmp.CreateDocumentEndToken(tmx.Offset, tmx.Position, zmU);
		}
		ymi = tmx.Offset;
		GmW = tmx.Position;
		Xmg = MergableLexerResult.NoMatch;
		Cmb = MergableLexerFlags.None;
		for (XmF = 0; XmF < mma.Count; XmF++)
		{
			ILexicalScope lexicalScope = KmC[XmF];
			if (lexicalScope.LexicalState == null || lexicalScope.LexicalState.Lexer != rmp)
			{
				Xmg = lexicalScope.IsScopeEnd(tmx);
				if (Xmg.MatchType != MatchType.NoMatch)
				{
					Cmb = MergableLexerFlags.ScopeEnd;
					break;
				}
			}
			if (!lexicalScope.IsAncestorEndScopeCheckEnabled)
			{
				break;
			}
		}
		if (Xmg.MatchType == MatchType.NoMatch)
		{
			for (XmF = 0; XmF < zmU.ChildLexicalStates.Count; XmF++)
			{
				ILexicalState lexicalState = zmU.ChildLexicalStates[XmF];
				for (Xmj = 0; Xmj < lexicalState.LexicalScopes.Count; Xmj++)
				{
					ILexicalScope lexicalScope2 = lexicalState.LexicalScopes[Xmj];
					Xmg = lexicalScope2.IsScopeStart(tmx);
					if (Xmg.MatchType != MatchType.NoMatch)
					{
						Cmb = MergableLexerFlags.ScopeStart;
						break;
					}
				}
				if (Xmg.MatchType != MatchType.NoMatch)
				{
					break;
				}
			}
		}
		if (Xmg.MatchType == MatchType.NoMatch)
		{
			Xmg = ((IMergableLexer)zmU.Lexer).GetNextToken(tmx, zmU);
		}
		if (Xmg.MatchType == MatchType.NoMatch)
		{
			for (XmF = 0; XmF < mma.Count; XmF++)
			{
				ILexicalScope lexicalScope3 = KmC[XmF];
				if (lexicalScope3.LexicalState == null || lexicalScope3.LexicalState.Lexer != rmp)
				{
					break;
				}
				Xmg = lexicalScope3.IsScopeEnd(tmx);
				if (Xmg.MatchType != MatchType.NoMatch)
				{
					Cmb = MergableLexerFlags.ScopeEnd;
					break;
				}
				if (!lexicalScope3.IsAncestorEndScopeCheckEnabled)
				{
					break;
				}
			}
		}
		if (Xmg.MatchType == MatchType.NoMatch)
		{
			Xmg = ((IMergableLexer)zmU.Lexer).GetDefaultToken(tmx, zmU);
		}
		switch (Cmb)
		{
		case MergableLexerFlags.ScopeStart:
			if (zmU.ChildLexicalStates[XmF].Transition != null)
			{
				Cmb = MergableLexerFlags.DirectStateTransition;
			}
			break;
		case MergableLexerFlags.ScopeEnd:
			if (Xmg.LexerData.LexicalScope != null)
			{
				if (Xmg.LexerData.LexicalScope.ParentTransition != null)
				{
					Cmb = MergableLexerFlags.ScopeStateTransitionEnd;
				}
				else if (Xmg.LexerData.LexicalScope.Transition != null)
				{
					Cmb = MergableLexerFlags.ScopeStateTransitionStart;
				}
			}
			break;
		}
		if (((kmP & MergableLexerFlags.DirectStateTransition) == MergableLexerFlags.DirectStateTransition || (kmP & MergableLexerFlags.ScopeStateTransitionStart) == MergableLexerFlags.ScopeStateTransitionStart) && rmp != tmH)
		{
			Cmb |= MergableLexerFlags.LanguageStart;
		}
		kmP = Cmb & (MergableLexerFlags.ScopeStart | MergableLexerFlags.ScopeEnd | MergableLexerFlags.DirectStateTransition | MergableLexerFlags.ScopeStateTransitionStart | MergableLexerFlags.ScopeStateTransitionEnd);
		MergableLexerFlags mergableLexerFlags3 = kmP;
		MergableLexerFlags mergableLexerFlags4 = mergableLexerFlags3;
		if ((mergableLexerFlags4 == MergableLexerFlags.ScopeEnd || mergableLexerFlags4 == MergableLexerFlags.ScopeStateTransitionEnd) && Rm5 != null)
		{
			if (XmF == mma.Count - 1)
			{
				if (emO != rmp)
				{
					if ((Cmb & MergableLexerFlags.LanguageStart) == MergableLexerFlags.LanguageStart)
					{
						Cmb &= ~MergableLexerFlags.LanguageStart;
					}
					else
					{
						Rm5.SetFlag(MergableLexerFlags.LanguageEnd, setBit: true);
					}
				}
			}
			else if (mma[XmF + 1].Lexer != rmp)
			{
				if ((Cmb & MergableLexerFlags.LanguageStart) == MergableLexerFlags.LanguageStart)
				{
					Cmb &= ~MergableLexerFlags.LanguageStart;
				}
				else
				{
					Rm5.SetFlag(MergableLexerFlags.LanguageEnd, setBit: true);
				}
			}
		}
		Nm6 = tmx.Offset - ymi;
		Rm5 = rmp.CreateToken(ymi, Nm6, GmW, tmx.Position, (MergableLexerFlags)((int)Cmb | ((Xmg.MatchType == MatchType.LooseMatch) ? 1 : 0)), zmU, Xmg.LexerData);
		if (Rm5 == null)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExNoMergableToken), new object[1] { rmp.GetType().FullName }));
		}
		if (YmZ)
		{
			dmv.Add(Rm5);
		}
		return Rm5;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	public static TextRange Parse(TextSnapshotRange snapshotRange, ILexerTarget lexerTarget)
	{
		if (snapshotRange.IsDeleted)
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextSnapshotRangeDeleted), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		if (lexerTarget == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8552));
		}
		if (!(snapshotRange.Snapshot.Document is ICodeDocument codeDocument))
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextSnapshotRequiresCodeDocument), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		int startOffset = snapshotRange.StartOffset;
		ILexerContext context = lexerTarget.OnPreParse(ref startOffset);
		int startOffset2 = snapshotRange.StartOffset;
		int num = snapshotRange.EndOffset;
		int endOffset = snapshotRange.EndOffset;
		ITextBufferReader bufferReader = snapshotRange.Snapshot.GetReader(startOffset).BufferReader;
		if (!(codeDocument.Language.GetService<ILexer>() is IMergableLexer mergableLexer))
		{
			throw new ArgumentException(SR.GetString(SRName.ExNoMergableLexer), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		if (mergableLexer.DefaultLexicalState == null)
		{
			throw new ArgumentException(SR.GetString(SRName.ExNoDefaultLexicalState));
		}
		MergableLexerCoordinator mergableLexerCoordinator = new MergableLexerCoordinator(bufferReader, mergableLexer, context);
		IMergableToken mergableToken = null;
		while (!bufferReader.IsAtEnd)
		{
			IMergableToken nextToken = mergableLexerCoordinator.GetNextToken();
			if (mergableToken != null && mergableToken.HasFlag(MergableLexerFlags.LanguageEnd))
			{
				lexerTarget.OnTokenParsed(mergableToken, mergableLexerCoordinator.nml);
			}
			if (lexerTarget.OnTokenParsed(nextToken, mergableLexerCoordinator.nml))
			{
				if (nextToken.StartOffset < startOffset2)
				{
					startOffset2 = nextToken.StartOffset;
				}
				if (bufferReader.Offset > num)
				{
					num = bufferReader.Offset;
				}
			}
			else if (bufferReader.Offset >= endOffset)
			{
				break;
			}
			mergableToken = nextToken;
		}
		if (bufferReader.IsAtEnd)
		{
			IMergableToken nextToken = mergableLexerCoordinator.GetNextToken();
			if (nextToken == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExNoMergableToken), new object[1] { mergableLexer.GetType().FullName }));
			}
			lexerTarget.OnTokenParsed(nextToken, mergableLexerCoordinator.nml);
		}
		lexerTarget.OnPostParse(mergableToken?.EndOffset ?? bufferReader.Offset);
		return new TextRange(startOffset2, num);
	}

	public bool Pop()
	{
		if (dm0.Count == 0)
		{
			return false;
		}
		dm0.RemoveAt(0);
		YmZ = dm0.Count > 0;
		return true;
	}

	public void Push()
	{
		if (dmv == null)
		{
			dmv = new List<IMergableToken>();
			dm0 = new List<int>();
		}
		if (dm0.Count > 0)
		{
			dm0.Insert(0, dm0[0]);
			int num = 0;
			if (!hUi())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			dm0.Insert(0, 0);
		}
		YmZ = true;
	}

	internal static bool hUi()
	{
		return gUd == null;
	}

	internal static MergableLexerCoordinator vUt()
	{
		return gUd;
	}
}
