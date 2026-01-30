using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Utility;

public interface IKeyedObservableCollection<T> : IObservableCollection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class, IKeyedObject
{
	T this[string key] { get; }

	bool Contains(string key);

	int IndexOf(string key);

	bool Remove(string key);
}
