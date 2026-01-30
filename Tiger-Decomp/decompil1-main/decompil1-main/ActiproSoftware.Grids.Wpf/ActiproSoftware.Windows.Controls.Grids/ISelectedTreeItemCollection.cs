using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ActiproSoftware.Windows.Controls.Grids;

public interface ISelectedTreeItemCollection : IList<object>, ICollection<object>, IEnumerable<object>, IEnumerable, INotifyCollectionChanged
{
}
