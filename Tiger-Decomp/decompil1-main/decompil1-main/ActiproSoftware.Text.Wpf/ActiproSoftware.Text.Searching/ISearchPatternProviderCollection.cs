using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Searching;

public interface ISearchPatternProviderCollection : IList<ISearchPatternProvider>, ICollection<ISearchPatternProvider>, IEnumerable<ISearchPatternProvider>, IEnumerable, IList, ICollection
{
}
