using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class SyntaxLanguage : ISyntaxLanguage, IKeyedObject, IServiceLocator
{
	private object Scg;

	private Dictionary<object, object> EcO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CollectionChangeEventArgs<object>> Rcl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CollectionChangeEventArgs<object>> Tci;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string rcW;

	private static SyntaxLanguage HUY;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return rcW;
		}
		[CompilerGenerated]
		protected set
		{
			rcW = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PlainText")]
	public static SyntaxLanguage PlainText => new PlainTextSyntaxLanguage();

	public object SyncRoot => Scg;

	public event EventHandler<CollectionChangeEventArgs<object>> ServiceAdded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = Rcl;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Rcl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = Rcl;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Rcl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<object>> ServiceRemoved
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = Tci;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Tci, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<object>> eventHandler = Tci;
			EventHandler<CollectionChangeEventArgs<object>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<object>> value2 = (EventHandler<CollectionChangeEventArgs<object>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Tci, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public SyntaxLanguage(string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Scg = new object();
		EcO = new Dictionary<object, object>();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		Key = key;
		RegisterService((IWordBreakFinder)new DefaultWordBreakFinder());
	}

	public IEnumerable<object> GetAllServiceTypes()
	{
		lock (Scg)
		{
			foreach (object key in EcO.Keys)
			{
				yield return key;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public T GetService<T>()
	{
		return (T)GetService(typeof(T));
	}

	public object GetService(object serviceType)
	{
		lock (Scg)
		{
			if (EcO.TryGetValue(serviceType, out var value))
			{
				return value;
			}
			return null;
		}
	}

	protected virtual void OnServiceAdded(CollectionChangeEventArgs<object> e)
	{
		Rcl?.Invoke(this, e);
	}

	protected virtual void OnServiceRemoved(CollectionChangeEventArgs<object> e)
	{
		Tci?.Invoke(this, e);
	}

	public void RegisterService<T>(T service)
	{
		RegisterService(typeof(T), service);
	}

	public void RegisterService(object serviceType, object service)
	{
		if (serviceType == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8732));
		}
		if (service == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8758));
		}
		lock (Scg)
		{
			UnregisterService(serviceType);
			EcO.Add(serviceType, service);
		}
		OnServiceAdded(new CollectionChangeEventArgs<object>(-1, service));
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public void UnregisterService<T>()
	{
		UnregisterService(typeof(T));
	}

	public void UnregisterService(object serviceType)
	{
		object obj = null;
		lock (Scg)
		{
			if (EcO.ContainsKey(serviceType))
			{
				obj = GetService(serviceType);
				EcO.Remove(serviceType);
			}
		}
		if (obj != null)
		{
			OnServiceRemoved(new CollectionChangeEventArgs<object>(-1, obj));
		}
	}

	internal static bool nUe()
	{
		return HUY == null;
	}

	internal static SyntaxLanguage lUg()
	{
		return HUY;
	}
}
