using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalPatternCollection : SimpleObservableCollection<DynamicLexicalPattern>, IDynamicLexicalPatternCollection, IObservableCollection<DynamicLexicalPattern>, IList<DynamicLexicalPattern>, ICollection<DynamicLexicalPattern>, IEnumerable<DynamicLexicalPattern>, IEnumerable
{
	private DynamicLexicalPatternGroup pTJ;

	internal static DynamicLexicalPatternCollection D5T;

	public DynamicLexicalPatternCollection(DynamicLexicalPatternGroup parentLexicalPatternGroup)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		pTJ = parentLexicalPatternGroup;
	}

	protected override void OnItemAdded(int index, DynamicLexicalPattern value)
	{
		base.OnItemAdded(index, value);
		if (pTJ != null && value != null)
		{
			value.LexicalPatternGroup = pTJ;
		}
	}

	protected override void OnItemRemoving(int index, DynamicLexicalPattern value)
	{
		base.OnItemRemoving(index, value);
		if (pTJ != null && value != null && value.LexicalPatternGroup == pTJ)
		{
			value.LexicalPatternGroup = null;
		}
	}

	[SpecialName]
	bool ICollection<DynamicLexicalPattern>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool S5k()
	{
		return D5T == null;
	}

	internal static DynamicLexicalPatternCollection Q5X()
	{
		return D5T;
	}
}
