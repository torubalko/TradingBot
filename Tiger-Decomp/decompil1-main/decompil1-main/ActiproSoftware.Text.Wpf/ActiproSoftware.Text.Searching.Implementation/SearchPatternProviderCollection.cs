using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

public class SearchPatternProviderCollection : SimpleObservableCollection<ISearchPatternProvider>, ISearchPatternProviderCollection, IList<ISearchPatternProvider>, ICollection<ISearchPatternProvider>, IEnumerable<ISearchPatternProvider>, IEnumerable, IList, ICollection
{
	internal static SearchPatternProviderCollection MVh;

	public SearchPatternProviderCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<ISearchPatternProvider>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	[SpecialName]
	bool IList.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool PVQ()
	{
		return MVh == null;
	}

	internal static SearchPatternProviderCollection JVx()
	{
		return MVh;
	}
}
