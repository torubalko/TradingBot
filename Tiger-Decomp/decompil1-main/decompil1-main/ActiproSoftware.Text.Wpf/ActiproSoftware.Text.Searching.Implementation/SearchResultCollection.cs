using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class SearchResultCollection : SimpleObservableCollection<ISearchResult>, ISearchResultCollection, IList<ISearchResult>, ICollection<ISearchResult>, IEnumerable<ISearchResult>, IEnumerable
{
	internal static SearchResultCollection sV3;

	public SearchResultCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	[SpecialName]
	bool ICollection<ISearchResult>.get_IsReadOnly()
	{
		return IsReadOnly;
	}

	internal static bool dVC()
	{
		return sV3 == null;
	}

	internal static SearchResultCollection dVw()
	{
		return sV3;
	}
}
