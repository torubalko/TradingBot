using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Searching;

public interface ISearchResultCollection : IList<ISearchResult>, ICollection<ISearchResult>, IEnumerable<ISearchResult>, IEnumerable
{
}
