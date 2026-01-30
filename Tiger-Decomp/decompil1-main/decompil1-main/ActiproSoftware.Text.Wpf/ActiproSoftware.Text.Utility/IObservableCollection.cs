using System;
using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text.Utility;

public interface IObservableCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : class
{
	event EventHandler<CollectionChangeEventArgs<T>> ItemAdding;

	event EventHandler<CollectionChangeEventArgs<T>> ItemAdded;

	event EventHandler<CollectionChangeEventArgs<T>> ItemRemoving;

	event EventHandler<CollectionChangeEventArgs<T>> ItemRemoved;
}
