using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalMacroCollection : KeyedObservableCollection<DynamicLexicalMacro>, IDynamicLexicalMacroCollection, IKeyedObservableCollection<DynamicLexicalMacro>, IObservableCollection<DynamicLexicalMacro>, IList<DynamicLexicalMacro>, ICollection<DynamicLexicalMacro>, IEnumerable<DynamicLexicalMacro>, IEnumerable, IRegexMacroMap
{
	private static DynamicLexicalMacroCollection B56;

	public RegexNode GetRegexNodeForMacro(string key)
	{
		return base[key]?.GetRegexNode(this);
	}

	public DynamicLexicalMacroCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<DynamicLexicalMacro>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool U5E()
	{
		return B56 == null;
	}

	internal static DynamicLexicalMacroCollection g5G()
	{
		return B56;
	}
}
