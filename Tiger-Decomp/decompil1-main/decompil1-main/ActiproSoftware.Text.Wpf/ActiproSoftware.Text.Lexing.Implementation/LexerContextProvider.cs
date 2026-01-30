using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class LexerContextProvider : DisposableObject
{
	private class OW
	{
		public ILineByLineLexerContext qs8;

		public int psT;

		private static OW Mf3;

		public OW()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool nfC()
		{
			return Mf3 == null;
		}

		internal static OW Vfw()
		{
			return Mf3;
		}
	}

	private class u5 : ILexerTarget
	{
		private bool AsM;

		private LexerContextProvider dsw;

		private int QsH;

		private int lsP;

		private int Csp;

		private OW Hsb;

		private ILineByLineLexerContext QsC;

		private int OsU;

		private List<IToken> Psa;

		private ITextSnapshot ksj;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool tsF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int Psx;

		internal static u5 Nfa;

		bool ILexerTarget.HasInitialContext => Hsb != null;

		public u5(LexerContextProvider P_0, OW P_1, TextSnapshotRange P_2, int P_3, bool P_4)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			Psa = new List<IToken>();
			base._002Ector();
			dsw = P_0;
			Hsb = P_1;
			ksj = P_2.Snapshot;
			Csp = P_2.StartOffset;
			lsP = P_2.EndOffset;
			OsU = Math.Max(lsP, P_3);
			AsM = P_4;
			if (lsP != ksj.Length)
			{
				int num = 0;
				if (false)
				{
					int num2;
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				lsP++;
				if (ksj.Length == 0)
				{
					Csp = -1;
				}
			}
		}

		void ILexerTarget.OnPostParse(int P_0)
		{
			if (fss() == 0)
			{
				osI(P_0);
			}
		}

		ILexerContext ILexerTarget.OnPreParse(ref int P_0)
		{
			if (Hsb == null)
			{
				QsH = Math.Max(-1, ksj.Lines.IndexOf(P_0) - 1);
				ILineByLineLexerContext lineByLineLexerContext = dsw.A2U(ref QsH);
				QsH = Math.Max(0, QsH);
				P_0 = ksj.Lines.GetLineTextRange(QsH).StartOffset + lineByLineLexerContext.Character;
				return lineByLineLexerContext;
			}
			QsH = ksj.Lines.IndexOf(P_0);
			return Hsb.qs8;
		}

		bool ILexerTarget.OnTokenParsed(IToken P_0, ILexicalScopeStateNode P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18224));
			}
			LineByLineLexerContext lineByLineLexerContext = new LineByLineLexerContext
			{
				Character = P_0.StartPosition.Character,
				ScopeState = P_1
			};
			if (P_0.StartOffset < lsP && P_0.EndOffset > Csp)
			{
				Psa.Add(P_0);
				QsC = lineByLineLexerContext;
			}
			if (P_0.EndPosition.Line > QsH)
			{
				bool flag = false;
				if (AsM)
				{
					flag = dsw.d2x(P_0.StartPosition.Line, lineByLineLexerContext);
					for (int i = P_0.StartPosition.Line + 1; i < P_0.EndPosition.Line; i++)
					{
						flag = dsw.d2x(i, new LineByLineLexerContext
						{
							CompleteLineToken = P_0
						});
						if (flag && P_0.EndOffset >= Math.Max(lsP, OsU))
						{
							Tsm(flag);
							osI(Math.Max(Math.Max(lsP, OsU), ksj.Lines[i].StartOffset - 1));
							return false;
						}
					}
				}
				QsH = P_0.EndPosition.Line;
				if (P_0.EndOffset >= lsP && (flag || P_0.EndOffset >= OsU))
				{
					Tsm(flag);
					return false;
				}
			}
			return true;
		}

		[SpecialName]
		[CompilerGenerated]
		internal bool ss2()
		{
			return tsF;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Tsm(bool P_0)
		{
			tsF = P_0;
		}

		[SpecialName]
		internal ILineByLineLexerContext dsh()
		{
			return QsC;
		}

		[SpecialName]
		internal List<IToken> psL()
		{
			return Psa;
		}

		[SpecialName]
		[CompilerGenerated]
		internal int fss()
		{
			return Psx;
		}

		[SpecialName]
		[CompilerGenerated]
		private void osI(int P_0)
		{
			Psx = P_0;
		}

		internal static bool zf7()
		{
			return Nfa == null;
		}

		internal static u5 IfJ()
		{
			return Nfa;
		}
	}

	private ICodeDocument R2O;

	private int p2l;

	private List<ILineByLineLexerContext> F2i;

	private object K2W;

	private static LexerContextProvider EPN;

	public LexerContextProvider(ICodeDocument document)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		p2l = -1;
		F2i = new List<ILineByLineLexerContext>();
		K2W = new object();
		base._002Ector();
		if (document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		R2O = document;
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		document.LanguageChanged += s2a;
		document.AddTextChangedEventHandler(G2j, EventHandlerPriority.High);
	}

	private static OW b2b(IList<IToken> P_0, ILineByLineLexerContext P_1)
	{
		if (P_0 != null && P_0.Count > 0 && P_1 != null)
		{
			return new OW
			{
				qs8 = P_1,
				psT = P_0[P_0.Count - 1].StartOffset
			};
		}
		return null;
	}

	private void L2C(int P_0)
	{
		if (P_0 >= F2i.Count)
		{
			F2i.AddRange(new ILineByLineLexerContext[P_0 - F2i.Count + 1]);
		}
	}

	private ILineByLineLexerContext A2U(ref int P_0)
	{
		if (P_0 >= 0)
		{
			L2C(P_0);
			for (P_0 = Math.Min(P_0, p2l); P_0 >= 0; P_0--)
			{
				ILineByLineLexerContext lineByLineLexerContext = F2i[P_0];
				if (lineByLineLexerContext != null && lineByLineLexerContext.CompleteLineToken == null)
				{
					return lineByLineLexerContext;
				}
			}
		}
		return new LineByLineLexerContext();
	}

	private void s2a(object P_0, SyntaxLanguageChangedEventArgs P_1)
	{
		lock (K2W)
		{
			b2F();
		}
	}

	private void G2j(object P_0, TextSnapshotChangedEventArgs P_1)
	{
		lock (K2W)
		{
			IList<ITextChangeOperation> operations = P_1.TextChange.Operations;
			foreach (ITextChangeOperation item in operations)
			{
				if (item.IsTextReplacement)
				{
					b2F();
				}
				else
				{
					if (item.StartPosition.Line >= F2i.Count)
					{
						continue;
					}
					int line = item.StartPosition.Line;
					if (item.LinesDelta == 0)
					{
						ILineByLineLexerContext lineByLineLexerContext = F2i[line];
						if (lineByLineLexerContext != null && lineByLineLexerContext.CompleteLineToken == null && item.StartPosition.Character <= lineByLineLexerContext.Character)
						{
							lineByLineLexerContext.Character += item.LengthDelta;
						}
					}
					p2l = Math.Max(-1, Math.Min(p2l, line - 1));
					if (item.LinesDeleted > 0 && line + 1 < F2i.Count)
					{
						F2i.RemoveRange(line + 1, Math.Min(item.LinesDeleted, F2i.Count - line - 1));
					}
					if (item.LinesInserted > 0 && line + 1 < F2i.Count)
					{
						F2i.InsertRange(line + 1, new ILineByLineLexerContext[item.LinesInserted]);
					}
				}
			}
		}
	}

	private void b2F()
	{
		F2i.Clear();
		p2l = -1;
	}

	private bool d2x(int P_0, ILineByLineLexerContext P_1)
	{
		L2C(P_0);
		ILexerContext lexerContext = F2i[P_0];
		bool result;
		if (P_1 == null && lexerContext == null)
		{
			result = true;
		}
		else if (P_1 != null)
		{
			if (P_1.Equals(lexerContext))
			{
				result = true;
			}
			else
			{
				F2i[P_0] = P_1;
				result = false;
			}
		}
		else
		{
			F2i[P_0] = P_1;
			result = false;
		}
		p2l = Math.Max(p2l, P_0);
		return result;
	}

	private TextSnapshotRange V2g(TextSnapshotRange P_0)
	{
		int num = P_0.StartOffset;
		if (P_0.Snapshot != R2O.CurrentSnapshot)
		{
			ITextVersion version = P_0.Snapshot.Version;
			ITextVersion version2 = R2O.CurrentSnapshot.Version;
			if (version.Number <= version2.Number)
			{
				ITextVersion textVersion = version;
				int num2 = 0;
				if (DPj() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
				{
					IList<ITextChangeRangedOperation> operations = textVersion.Operations;
					if (operations != null)
					{
						foreach (ITextChangeRangedOperation item in operations)
						{
							num = Math.Min(num, item.StartOffset);
						}
					}
					textVersion = textVersion.Next;
					goto default;
				}
				default:
					if (textVersion == null || textVersion == version2)
					{
						break;
					}
					goto case 1;
				}
			}
		}
		if (P_0.StartOffset != num)
		{
			P_0 = new TextSnapshotRange(P_0.Snapshot, num, P_0.EndOffset);
		}
		return P_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && R2O != null)
		{
			R2O.LanguageChanged -= s2a;
			R2O.RemoveTextChangedEventHandler(G2j, EventHandlerPriority.High);
			R2O = null;
		}
		base.Dispose(disposing);
	}

	public ITokenSet GetTokens(ILexer lexer, TextSnapshotRange desiredSnapshotRange, object parseContext, bool canUpdateLineContexts, out int invalidateThroughOffset)
	{
		invalidateThroughOffset = desiredSnapshotRange.EndOffset;
		TokenSet result;
		lock (K2W)
		{
			OW oW = parseContext as OW;
			int num;
			if (oW != null && oW.psT <= desiredSnapshotRange.StartOffset)
			{
				num = 1;
				if (DPj() != null)
				{
					goto IL_0046;
				}
				goto IL_004a;
			}
			oW = null;
			TextSnapshotRange snapshotRange = V2g(desiredSnapshotRange);
			goto IL_0122;
			IL_019c:
			bool flag = default(bool);
			u5 u = new u5(this, oW, desiredSnapshotRange, invalidateThroughOffset, flag && canUpdateLineContexts);
			num = 0;
			if (DPj() == null)
			{
				num = 0;
			}
			goto IL_004a;
			IL_0264:
			TextPositionRange textPositionRange = default(TextPositionRange);
			if (textPositionRange.Lines == 1 && textPositionRange.StartPosition.Line <= p2l)
			{
				ILineByLineLexerContext lineByLineLexerContext = F2i[textPositionRange.StartPosition.Line];
				if (lineByLineLexerContext != null)
				{
					IToken completeLineToken = lineByLineLexerContext.CompleteLineToken;
					if (completeLineToken != null)
					{
						return new TokenSet(snapshotRange.TextRange, new IToken[1] { completeLineToken }, null);
					}
				}
			}
			goto IL_019c;
			IL_0122:
			flag = snapshotRange.Snapshot == R2O.CurrentSnapshot;
			if (flag)
			{
				textPositionRange = snapshotRange.Snapshot.TextRangeToPositionRange(snapshotRange.TextRange);
				num = 2;
				if (!SPr())
				{
					goto IL_0046;
				}
				goto IL_004a;
			}
			goto IL_019c;
			IL_0046:
			int num2 = default(int);
			num = num2;
			goto IL_004a;
			IL_004a:
			switch (num)
			{
			default:
				lexer.Parse(snapshotRange, u);
				result = new TokenSet(desiredSnapshotRange, u.psL(), b2b(u.psL(), u.dsh()));
				invalidateThroughOffset = (u.ss2() ? u.fss() : snapshotRange.Snapshot.Length);
				goto end_IL_0038;
			case 1:
				break;
			case 2:
				goto IL_0264;
			}
			snapshotRange = new TextSnapshotRange(desiredSnapshotRange.Snapshot, oW.psT, desiredSnapshotRange.EndOffset);
			goto IL_0122;
			end_IL_0038:;
		}
		return result;
	}

	internal static bool SPr()
	{
		return EPN == null;
	}

	internal static LexerContextProvider DPj()
	{
		return EPN;
	}
}
