namespace ActiproSoftware.Text.RegularExpressions;

internal static class RegexOpCode
{
	internal const int Char = 1;

	internal const int NotChar = 2;

	internal const int CharClass = 3;

	internal const int String = 4;

	internal const int DocumentStart = 5;

	internal const int DocumentEnd = 6;

	internal const int LineStart = 7;

	internal const int LineEnd = 8;

	internal const int WordBoundary = 9;

	internal const int NonWordBoundary = 10;

	internal const int LazyBranch = 16;

	internal const int BranchMark = 17;

	internal const int NullCount = 18;

	internal const int SetCount = 19;

	internal const int BranchCount = 20;

	internal const int NullMark = 21;

	internal const int SetMark = 22;

	internal const int CaptureMark = 23;

	internal const int GetMark = 24;

	internal const int SetJump = 25;

	internal const int BackJump = 26;

	internal const int ForeJump = 27;

	internal const int GoTo = 28;

	internal const int Stop = 29;

	internal const int LeftToRight = 30;

	internal const int RightToLeft = 31;

	internal const int WordChar = 32;

	internal const int NonWordChar = 33;

	internal const int AllChar = 34;

	internal const int NoneChar = 35;

	internal const int AlphaChar = 36;

	internal const int NonAlphaChar = 37;

	internal const int DigitChar = 38;

	internal const int NonDigitChar = 39;

	internal const int HexDigitChar = 40;

	internal const int NonHexDigitChar = 41;

	internal const int WhitespaceChar = 42;

	internal const int NonWhitespaceChar = 43;

	internal const int LineTerminatorChar = 44;

	internal const int NonLineTerminatorChar = 45;

	internal const int LineTerminatorWhitespaceChar = 46;

	internal const int NonLineTerminatorWhitespaceChar = 47;
}
