using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Utility;

public interface IServiceLocator
{
	object SyncRoot { get; }

	event EventHandler<CollectionChangeEventArgs<object>> ServiceAdded;

	event EventHandler<CollectionChangeEventArgs<object>> ServiceRemoved;

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	IEnumerable<object> GetAllServiceTypes();

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	T GetService<T>();

	object GetService(object serviceType);

	void RegisterService<T>(T service);

	void RegisterService(object serviceType, object service);

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	void UnregisterService<T>();

	void UnregisterService(object serviceType);
}
