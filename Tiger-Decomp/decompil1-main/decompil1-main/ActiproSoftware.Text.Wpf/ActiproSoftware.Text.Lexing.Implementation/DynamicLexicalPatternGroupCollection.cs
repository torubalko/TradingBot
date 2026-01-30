using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalPatternGroupCollection : KeyedObservableCollection<DynamicLexicalPatternGroup>, IDynamicLexicalPatternGroupCollection, IKeyedObservableCollection<DynamicLexicalPatternGroup>, IObservableCollection<DynamicLexicalPatternGroup>, IList<DynamicLexicalPatternGroup>, ICollection<DynamicLexicalPatternGroup>, IEnumerable<DynamicLexicalPatternGroup>, IEnumerable
{
	private DynamicLexicalState M2T;

	internal static DynamicLexicalPatternGroupCollection b5a;

	public DynamicLexicalPatternGroupCollection(DynamicLexicalState parentLexicalState)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		M2T = parentLexicalState;
	}

	protected override void OnItemAdded(int index, DynamicLexicalPatternGroup value)
	{
		base.OnItemAdded(index, value);
		if (value != null && M2T != null)
		{
			value.LexicalState = M2T;
		}
	}

	protected override void OnItemRemoving(int index, DynamicLexicalPatternGroup value)
	{
		base.OnItemRemoving(index, value);
		if (value != null && M2T != null && value.LexicalState == M2T)
		{
			value.LexicalState = null;
		}
	}

	[SpecialName]
	bool ICollection<DynamicLexicalPatternGroup>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool O57()
	{
		return b5a == null;
	}

	internal static DynamicLexicalPatternGroupCollection M5J()
	{
		return b5a;
	}
}
