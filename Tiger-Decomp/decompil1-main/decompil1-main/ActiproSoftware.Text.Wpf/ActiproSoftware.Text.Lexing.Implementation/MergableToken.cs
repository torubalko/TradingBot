using System.Diagnostics.CodeAnalysis;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class MergableToken : TokenBase, IMergableToken, IToken
{
	private MergableLexerFlags wmY;

	private IMergableTokenLexerData kmo;

	private ILexicalState WmD;

	private static MergableToken JUW;

	public virtual string AutoCaseCorrectText
	{
		get
		{
			string result;
			if (kmo is DynamicLexicalPatternTokenData { LexicalPattern: not null } dynamicLexicalPatternTokenData && dynamicLexicalPatternTokenData.LexicalPattern.LexicalPatternGroup != null && dynamicLexicalPatternTokenData.LexicalPattern.LexicalPatternGroup.PatternType == DynamicLexicalPatternType.Explicit)
			{
				result = dynamicLexicalPatternTokenData.LexicalPattern.Pattern;
				int num = 0;
				if (dUA() != null)
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
				result = null;
			}
			return result;
		}
	}

	public virtual IClassificationType ClassificationType => (kmo != null) ? kmo.ClassificationType : null;

	public virtual ILexicalState DeclaringLexicalState => (kmo != null) ? kmo.LexicalState : null;

	public override int Id => (kmo != null) ? kmo.TokenId : (-2);

	public override string Key => (kmo != null) ? kmo.TokenKey : null;

	public IMergableLexer Lexer => (kmo != null) ? kmo.Lexer : null;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	protected IMergableTokenLexerData LexerData => kmo;

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	protected MergableLexerFlags LexerFlags => wmY;

	public virtual ILexicalScope LexicalScope => (kmo != null) ? kmo.LexicalScope : null;

	public virtual ILexicalState LexicalState => WmD;

	public override int LexicalStateId
	{
		get
		{
			if (LexicalState != null)
			{
				return LexicalState.Id;
			}
			return 0;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	public MergableToken(int startOffset, int length, TextPosition startPosition, TextPosition endPosition, MergableLexerFlags lexerFlags, ILexicalState lexicalState, IMergableTokenLexerData lexerData)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(startOffset, length, startPosition, endPosition);
		wmY = lexerFlags;
		WmD = lexicalState;
		kmo = lexerData;
	}

	public virtual bool HasFlag(MergableLexerFlags flag)
	{
		return (wmY & flag) == flag;
	}

	public virtual void SetFlag(MergableLexerFlags flag, bool setBit)
	{
		if (!setBit)
		{
			wmY &= ~flag;
		}
		else
		{
			wmY |= flag;
		}
	}

	internal static bool BUn()
	{
		return JUW == null;
	}

	internal static MergableToken dUA()
	{
		return JUW;
	}
}
