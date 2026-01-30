using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Lexing.Implementation;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextSnapshotReader : ITextSnapshotReader
{
	private ITextBufferReader nhR;

	private IWordBreakFinder Vhf;

	private int nht;

	private ITokenSet XhQ;

	private int Vhn;

	private IDictionary<IMergableLexer, ISyntaxLanguage> RhG;

	private ITextSnapshotReaderOptions Xhe;

	private ITokenSet fhy;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot thz;

	internal static TextSnapshotReader D28;

	public ITextBufferReader BufferReader => nhR;

	public char Character => nhR.Peek();

	public bool IsAtSnapshotEnd => nhR.IsAtEnd;

	public bool IsAtSnapshotLineEnd => IsCharacterLineTerminator || IsAtSnapshotEnd;

	public bool IsAtSnapshotLineStart => IsAtSnapshotStart || PeekCharacterReverse() == '\n';

	public bool IsAtSnapshotStart => nhR.IsAtStart;

	public bool IsAtTokenStart
	{
		get
		{
			IToken token = Token;
			if (token == null)
			{
				return false;
			}
			return nhR.Offset == token.StartOffset;
		}
	}

	public bool IsCharacterLineTerminator => Character == '\n';

	public bool IsCharacterWhitespace => char.IsWhiteSpace(Character);

	public ISyntaxLanguage Language
	{
		get
		{
			ISyntaxLanguage syntaxLanguage = ((Snapshot.Document is ICodeDocument codeDocument) ? codeDocument.Language : null);
			if (RhG == null)
			{
				RhG = MergableLexerCoordinator.GetChildLexerLanguageMappings(syntaxLanguage);
			}
			if (Token is IMergableToken { Lexer: { } lexer } && RhG.TryGetValue(lexer, out var value))
			{
				return value;
			}
			return syntaxLanguage;
		}
	}

	public int Length => nhR.Length;

	public int Offset
	{
		get
		{
			return nhR.Offset;
		}
		set
		{
			nhR.Offset = value;
		}
	}

	public ITextSnapshotReaderOptions Options => Xhe;

	public TextPosition Position => nhR.Position;

	public ITextSnapshot Snapshot
	{
		[CompilerGenerated]
		get
		{
			return thz;
		}
		[CompilerGenerated]
		private set
		{
			thz = value;
		}
	}

	public ITextSnapshotLine SnapshotLine => Snapshot.Lines[Position.Line];

	public IToken Token
	{
		get
		{
			ehX();
			if (XhQ != null && nht != -1)
			{
				return XhQ[nht];
			}
			return null;
		}
	}

	public string TokenText
	{
		get
		{
			IToken token = Token;
			if (token != null)
			{
				return Snapshot.GetSubstring(token.TextRange, LineTerminator.Newline);
			}
			return null;
		}
	}

	internal TextSnapshotReader(ITextSnapshot snapshot, ITextBufferReader bufferReader)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		nht = -1;
		Vhn = -1;
		Xhe = new TextSnapshotReaderOptions();
		base._002Ector();
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (bufferReader == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9210));
		}
		Snapshot = snapshot;
		nhR = bufferReader;
	}

	private IToken ghk()
	{
		IToken token = Token;
		int num;
		IToken result = default(IToken);
		if (token == null)
		{
			num = 3;
			if (!Q2L())
			{
				goto IL_0005;
			}
		}
		else
		{
			if (token.EndOffset != nhR.Length)
			{
				nhR.Offset = token.EndOffset;
				token = Token;
				if (token != null)
				{
					goto IL_0185;
				}
				goto IL_01b5;
			}
			nhR.Offset = nhR.Length;
			result = null;
			num = 0;
			if (!Q2L())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_00e7:
		return result;
		IL_0185:
		result = token;
		goto IL_00e7;
		IL_0112:
		if (token == null)
		{
			result = null;
			num = 2;
			goto IL_0009;
		}
		goto IL_0185;
		IL_01b5:
		if (!nhR.IsAtEnd)
		{
			nhR.Read();
			token = Token;
			num = 1;
			if (R2s() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0112;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 3:
			while (!nhR.IsAtEnd)
			{
				nhR.Read();
				token = Token;
				if (token != null)
				{
					break;
				}
			}
			result = token;
			break;
		case 1:
			goto IL_00f4;
		}
		goto IL_00e7;
		IL_00f4:
		if (token != null)
		{
			goto IL_0112;
		}
		goto IL_01b5;
	}

	private IToken yhE()
	{
		IToken token = Token;
		int num;
		if (token != null)
		{
			if (token.StartOffset != 0)
			{
				nhR.Offset = token.StartOffset - 1;
				num = 0;
				if (!Q2L())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			nhR.Offset = 0;
			return null;
		}
		while (!nhR.IsAtStart)
		{
			nhR.ReadReverse();
			token = Token;
			if (token != null)
			{
				break;
			}
		}
		return token;
		IL_0009:
		bool flag = default(bool);
		do
		{
			switch (num)
			{
			case 1:
				if (flag)
				{
					nhR.Offset = token.StartOffset;
				}
				return token;
			}
			token = Token;
			flag = token != null;
			num = 1;
		}
		while (Q2L());
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private ITokenSet qhr(int P_0)
	{
		int num = default(int);
		if (XhQ == null)
		{
			num = 3;
			goto IL_0005;
		}
		ITokenSet result = default(ITokenSet);
		int num2;
		if (!XhQ.TextRange.Contains(P_0))
		{
			if (P_0 != nhR.Length || XhQ.TextRange.EndOffset != P_0)
			{
				if (fhy != null && fhy.TextRange.Contains(P_0))
				{
					result = fhy;
					goto IL_0188;
				}
				num2 = 0;
				if (R2s() != null)
				{
					goto IL_0005;
				}
			}
			else
			{
				result = XhQ;
				num2 = 0;
				if (Q2L())
				{
					num2 = 2;
				}
			}
		}
		else
		{
			num2 = 1;
			if (!Q2L())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num2)
		{
		case 3:
			result = null;
			break;
		default:
		{
			if (Vhn < XhQ.TextRange.StartOffset)
			{
				int num3 = Math.Max(50, Xhe.DefaultTokenLoadBufferLength);
				result = vh3(new TextRange(Math.Max(0, P_0 - Math.Max(1, (int)((double)num3 * 0.85))), Math.Min(nhR.Length, P_0 + Math.Max(1, (int)((double)num3 * 0.15)))), null);
				break;
			}
			int num4 = Math.Max(50, Xhe.DefaultTokenLoadBufferLength);
			TextRange textRange = new TextRange(Math.Max(0, P_0 - Math.Max(1, (int)((double)num4 * 0.15))), Math.Min(nhR.Length, P_0 + Math.Max(1, (int)((double)num4 * 0.85))));
			if (XhQ.LastToken != null && XhQ.LastToken.StartOffset > textRange.StartOffset)
			{
				textRange = new TextRange(XhQ.LastToken.StartOffset, textRange.EndOffset);
			}
			result = vh3(textRange, XhQ.ParseContext);
			break;
		}
		case 2:
			break;
		case 1:
			result = XhQ;
			break;
		}
		goto IL_0188;
		IL_0005:
		num2 = num;
		goto IL_0009;
		IL_0188:
		return result;
	}

	private ITokenSet vh3(TextRange P_0, object P_1)
	{
		ICodeDocument codeDocument = Snapshot.Document as ICodeDocument;
		ITagger<ITokenTag> value = null;
		if (codeDocument != null && codeDocument.Properties.TryGetValue<ITagger<ITokenTag>>(typeof(ITagger<ITokenTag>), out value))
		{
			if (value is TokenTagger tokenTagger)
			{
				ISyntaxLanguage language = codeDocument.Language;
				ILexer lexer = null;
				if (language != null)
				{
					lexer = language.GetService<ILexer>();
				}
				if (lexer == null)
				{
					return null;
				}
				int invalidateThroughOffset;
				return tokenTagger.GetTokensInternal(lexer, new TextSnapshotRange(Snapshot, P_0), P_1, out invalidateThroughOffset);
			}
			IEnumerable<TagSnapshotRange<ITokenTag>> tags = value.GetTags(new NormalizedTextSnapshotRangeCollection(new TextSnapshotRange(Snapshot, P_0)), P_1);
			return new TokenSet(P_0, tags, null);
		}
		return null;
	}

	private IWordBreakFinder ohJ()
	{
		if (Vhf != null)
		{
			int num = 0;
			if (!Q2L())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => Vhf, 
			};
		}
		if (!(Snapshot.Document is ICodeDocument { Language: not null } codeDocument))
		{
			Vhf = new DefaultWordBreakFinder();
		}
		else
		{
			Vhf = codeDocument.Language.GetService<IWordBreakFinder>() ?? new DefaultWordBreakFinder();
		}
		return Vhf;
	}

	private void ehX()
	{
		if (nhR.Offset == Vhn)
		{
			return;
		}
		Vhn = nhR.Offset;
		bool flag = XhQ == null;
		int num = 0;
		if (R2s() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		do
		{
			ITokenSet xhQ;
			switch (num)
			{
			case 1:
				break;
			default:
				if (flag)
				{
					int num2 = Math.Max(50, Xhe.InitialTokenLoadBufferLength);
					XhQ = vh3(new TextRange(Math.Max(0, (!Xhe.PrimaryScanDirection.HasValue) ? (Vhn - num2 / 2) : ((Xhe.PrimaryScanDirection == TextScanDirection.Forward) ? Vhn : (Vhn - num2))), Math.Min(nhR.Length, (!Xhe.PrimaryScanDirection.HasValue) ? (Vhn + num2 / 2) : ((Xhe.PrimaryScanDirection == TextScanDirection.Forward) ? (Vhn + num2) : (Vhn + 1)))), null);
					break;
				}
				xhQ = XhQ;
				XhQ = qhr(Vhn);
				if (xhQ == XhQ)
				{
					break;
				}
				goto IL_0049;
			}
			if (XhQ == null)
			{
				nht = -1;
			}
			else
			{
				nht = XhQ.IndexOf(Vhn, nht);
			}
			return;
			IL_0049:
			fhy = xhQ;
			num = 1;
		}
		while (R2s() == null);
		goto IL_0005;
		IL_0005:
		int num3 = default(int);
		num = num3;
		goto IL_0009;
	}

	public void GoToCurrentSnapshotLineEnd()
	{
		Offset = Snapshot.Lines[Position.Line].EndOffset;
	}

	public void GoToCurrentSnapshotLineStart()
	{
		Offset = Snapshot.Lines[Position.Line].StartOffset;
	}

	public void GoToCurrentTokenStart()
	{
		IToken token = Token;
		if (token != null)
		{
			Offset = token.StartOffset;
		}
	}

	public bool GoToCurrentWordEnd()
	{
		IWordBreakFinder wordBreakFinder = ohJ();
		int offset = nhR.Offset;
		nhR.Offset = wordBreakFinder.FindCurrentWordEnd(new TextSnapshotOffset(Snapshot, offset));
		return nhR.Offset != offset;
	}

	public bool GoToCurrentWordStart()
	{
		IWordBreakFinder wordBreakFinder = ohJ();
		int offset = nhR.Offset;
		nhR.Offset = wordBreakFinder.FindCurrentWordStart(new TextSnapshotOffset(Snapshot, offset));
		return nhR.Offset != offset;
	}

	public bool GoToNextMatchingTokenById(int startTokenId, int endTokenId)
	{
		int num = 1;
		while (!nhR.IsAtEnd)
		{
			IToken token = ghk();
			if (token == null)
			{
				continue;
			}
			if (token.Id == endTokenId)
			{
				if (--num <= 0)
				{
					Offset = token.StartOffset;
					return true;
				}
			}
			else if (token.Id == startTokenId)
			{
				num++;
			}
		}
		return false;
	}

	public void GoToNextSnapshotLineStart()
	{
		Offset = Math.Min(nhR.Length, Snapshot.Lines[Position.Line].EndOffset + 1);
	}

	public bool GoToNextToken()
	{
		return ghk() != null;
	}

	public bool GoToNextToken(int count)
	{
		int num = 0;
		bool result;
		int num3 = default(int);
		while (true)
		{
			if (num < count)
			{
				if (ghk() == null)
				{
					result = false;
					int num2 = 0;
					if (!Q2L())
					{
						num2 = num3;
					}
					switch (num2)
					{
					}
					break;
				}
				num++;
				continue;
			}
			result = true;
			break;
		}
		return result;
	}

	public bool GoToNextToken(Predicate<IToken> predicate)
	{
		if (predicate == null)
		{
			return GoToNextToken();
		}
		while (!nhR.IsAtEnd)
		{
			IToken obj = ghk();
			if (predicate(obj))
			{
				return true;
			}
		}
		return false;
	}

	public bool GoToNextTokenWithId(int id)
	{
		while (!nhR.IsAtEnd)
		{
			IToken token = ghk();
			if (token != null && token.Id == id)
			{
				return true;
			}
		}
		return false;
	}

	public bool GoToNextTokenWithId(params int[] ids)
	{
		if (ids != null)
		{
			while (!nhR.IsAtEnd)
			{
				IToken token = ghk();
				if (token == null || Array.IndexOf(ids, token.Id) == -1)
				{
					continue;
				}
				return true;
			}
		}
		return false;
	}

	public bool GoToNextTokenWithKey(string key)
	{
		while (!nhR.IsAtEnd)
		{
			IToken token = ghk();
			if (token != null && token.Key == key)
			{
				return true;
			}
		}
		return false;
	}

	public bool GoToNextTokenWithKey(params string[] keys)
	{
		if (keys != null)
		{
			while (!nhR.IsAtEnd)
			{
				IToken token = ghk();
				if (token != null && Array.IndexOf(keys, token.Key) != -1)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool GoToNextWordStart()
	{
		IWordBreakFinder wordBreakFinder = ohJ();
		int offset = nhR.Offset;
		nhR.Offset = wordBreakFinder.FindNextWordStart(new TextSnapshotOffset(Snapshot, offset));
		return nhR.Offset != offset && nhR.Offset != nhR.Length;
	}

	public bool GoToPreviousMatchingTokenById(int endTokenId, int startTokenId)
	{
		int num = 1;
		int num3 = default(int);
		while (!nhR.IsAtStart)
		{
			IToken token = yhE();
			if (token == null)
			{
				continue;
			}
			int num2;
			if (token.Id != startTokenId)
			{
				if (token.Id != endTokenId)
				{
					continue;
				}
				num++;
				num2 = 1;
				if (!Q2L())
				{
					goto IL_0005;
				}
			}
			else
			{
				if (--num > 0)
				{
					continue;
				}
				num2 = 0;
				if (R2s() != null)
				{
					goto IL_0005;
				}
			}
			goto IL_0009;
			IL_0009:
			switch (num2)
			{
			case 1:
				continue;
			}
			Offset = token.StartOffset;
			return true;
			IL_0005:
			num2 = num3;
			goto IL_0009;
		}
		return false;
	}

	public void GoToPreviousSnapshotLineEnd()
	{
		Offset = Math.Max(0, Snapshot.Lines[Position.Line].StartOffset - 1);
	}

	public bool GoToPreviousToken()
	{
		return yhE() != null;
	}

	public bool GoToPreviousToken(int count)
	{
		for (int i = 0; i < count; i++)
		{
			if (yhE() == null)
			{
				return false;
			}
		}
		return true;
	}

	public bool GoToPreviousToken(Predicate<IToken> predicate)
	{
		if (predicate == null)
		{
			return GoToPreviousToken();
		}
		while (!nhR.IsAtStart)
		{
			IToken obj = yhE();
			if (predicate(obj))
			{
				return true;
			}
		}
		return false;
	}

	public bool GoToPreviousTokenWithId(int id)
	{
		bool flag;
		int num2 = default(int);
		do
		{
			if (!nhR.IsAtStart)
			{
				IToken token = yhE();
				flag = token != null && token.Id == id;
				int num = 0;
				if (R2s() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				continue;
			}
			return false;
		}
		while (!flag);
		return true;
	}

	public bool GoToPreviousTokenWithId(params int[] ids)
	{
		if (ids != null)
		{
			while (!nhR.IsAtStart)
			{
				IToken token = yhE();
				if (token != null && Array.IndexOf(ids, token.Id) != -1)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool GoToPreviousTokenWithKey(string key)
	{
		while (!nhR.IsAtStart)
		{
			IToken token = yhE();
			if (token == null || !(token.Key == key))
			{
				continue;
			}
			return true;
		}
		return false;
	}

	public bool GoToPreviousTokenWithKey(params string[] keys)
	{
		if (keys != null)
		{
			while (!nhR.IsAtStart)
			{
				IToken token = yhE();
				if (token == null || Array.IndexOf(keys, token.Key) == -1)
				{
					continue;
				}
				return true;
			}
		}
		return false;
	}

	public bool GoToPreviousWordStart()
	{
		IWordBreakFinder wordBreakFinder = ohJ();
		int offset = nhR.Offset;
		nhR.Offset = wordBreakFinder.FindPreviousWordStart(new TextSnapshotOffset(Snapshot, offset));
		return nhR.Offset != offset;
	}

	public void GoToSnapshotEnd()
	{
		Offset = nhR.Length;
	}

	public void GoToSnapshotStart()
	{
		Offset = 0;
	}

	public char PeekCharacter()
	{
		return nhR.Peek();
	}

	public char PeekCharacterReverse()
	{
		return nhR.PeekReverse();
	}

	public string PeekText(int maxCharCount)
	{
		if (maxCharCount < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9238));
		}
		string result;
		if (!nhR.IsAtEnd)
		{
			int length = Math.Min(maxCharCount, nhR.Length - nhR.Offset);
			result = nhR.GetSubstring(nhR.Offset, length);
			int num = 0;
			if (R2s() != null)
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
			result = string.Empty;
		}
		return result;
	}

	public string PeekTextReverse(int maxCharCount)
	{
		if (maxCharCount >= 0)
		{
			if (!nhR.IsAtStart)
			{
				int num = Math.Min(maxCharCount, nhR.Offset);
				return nhR.GetSubstring(nhR.Offset - num, num);
			}
			return string.Empty;
		}
		throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9238));
	}

	public IToken PeekToken()
	{
		return Token;
	}

	public IToken PeekTokenReverse()
	{
		int offset = nhR.Offset;
		IToken result = yhE();
		nhR.Offset = offset;
		return result;
	}

	public char ReadCharacter()
	{
		return nhR.Read();
	}

	public char ReadCharacterReverse()
	{
		return nhR.ReadReverse();
	}

	public bool ReadCharacterReverseThrough(char ch)
	{
		return nhR.ReadReverseThrough(ch);
	}

	public bool ReadCharacterReverseThrough(char ch, int minOffset)
	{
		return nhR.ReadReverseThrough(ch, minOffset);
	}

	public bool ReadCharacterThrough(char ch)
	{
		return nhR.ReadThrough(ch);
	}

	public bool ReadCharacterThrough(char ch, int maxOffset)
	{
		return nhR.ReadThrough(ch, maxOffset);
	}

	public string ReadText(int maxCharCount)
	{
		if (maxCharCount < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9238));
		}
		if (!nhR.IsAtEnd)
		{
			int num = Math.Min(maxCharCount, nhR.Length - nhR.Offset);
			string substring = nhR.GetSubstring(nhR.Offset, num);
			nhR.Offset += num;
			return substring;
		}
		return string.Empty;
	}

	public string ReadTextReverse(int maxCharCount)
	{
		if (maxCharCount < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9238));
		}
		if (!nhR.IsAtStart)
		{
			int num = Math.Min(maxCharCount, nhR.Offset);
			nhR.Offset -= num;
			return nhR.GetSubstring(nhR.Offset, num);
		}
		return string.Empty;
	}

	public IToken ReadToken()
	{
		IToken token = Token;
		if (token == null)
		{
			ReadCharacter();
		}
		else
		{
			nhR.Offset = token.EndOffset;
		}
		return token;
	}

	public IToken ReadTokenReverse()
	{
		return yhE();
	}

	public void SeekCharacter(int delta)
	{
		if (delta > 0)
		{
			nhR.Offset = Math.Min(nhR.Offset + delta, nhR.Length);
		}
		else
		{
			nhR.Offset = Math.Max(nhR.Offset + delta, 0);
		}
	}

	internal static bool Q2L()
	{
		return D28 == null;
	}

	internal static TextSnapshotReader R2s()
	{
		return D28;
	}
}
