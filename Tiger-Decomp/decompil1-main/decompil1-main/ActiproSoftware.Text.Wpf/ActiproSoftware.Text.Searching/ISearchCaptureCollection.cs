using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Searching;

public interface ISearchCaptureCollection : IKeyedObservableCollection<ISearchCapture>, IObservableCollection<ISearchCapture>, IList<ISearchCapture>, ICollection<ISearchCapture>, IEnumerable<ISearchCapture>, IEnumerable
{
}
