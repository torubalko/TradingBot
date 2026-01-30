using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class ProgrammaticLexicalScope : LexicalScopeBase
{
	private ProgrammaticLexicalScopeMatch zm1;

	private ProgrammaticLexicalScopeMatch tm4;

	private static ProgrammaticLexicalScope zUV;

	public ProgrammaticLexicalScope(ProgrammaticLexicalScopeMatch isScopeStartDelegate, ProgrammaticLexicalScopeMatch isScopeEndDelegate)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		tm4 = isScopeStartDelegate;
		zm1 = isScopeEndDelegate;
	}

	public override MergableLexerResult IsScopeEnd(ITextBufferReader reader)
	{
		return zm1(reader, this);
	}

	public override MergableLexerResult IsScopeStart(ITextBufferReader reader)
	{
		return tm4(reader, this);
	}

	internal static bool DUb()
	{
		return zUV == null;
	}

	internal static ProgrammaticLexicalScope iU1()
	{
		return zUV;
	}
}
