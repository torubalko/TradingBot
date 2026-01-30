namespace ActiproSoftware.Text.RegularExpressions;

internal interface IRegexMacroMap
{
	RegexNode GetRegexNodeForMacro(string key);
}
