using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
public class SimpleObservableCollection<T> : Collection<T> where T : class
{
	private class rM : IDisposable
	{
		private int lqS;

		private static object scf;

		[SpecialName]
		public bool VLy()
		{
			return lqS > 0;
		}

		public void Dispose()
		{
			lqS--;
		}

		public void Enter()
		{
			lqS++;
		}

		public rM()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool mcM()
		{
			return scf == null;
		}

		internal static object ncZ()
		{
			return scf;
		}
	}

	private readonly rM pBm;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<CollectionChangeEventArgs<T>> PBc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CollectionChangeEventArgs<T>> IBh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<CollectionChangeEventArgs<T>> BBd;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<CollectionChangeEventArgs<T>> OBL;

	private static object cWh;

	public virtual bool IsReadOnly => false;

	public event EventHandler<CollectionChangeEventArgs<T>> ItemAdding
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = PBc;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PBc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = PBc;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref PBc, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<T>> ItemAdded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = IBh;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IBh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = IBh;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IBh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<T>> ItemRemoving
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = BBd;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BBd, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = BBd;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref BBd, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CollectionChangeEventArgs<T>> ItemRemoved
	{
		[CompilerGenerated]
		add
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = OBL;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OBL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<CollectionChangeEventArgs<T>> eventHandler = OBL;
			EventHandler<CollectionChangeEventArgs<T>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CollectionChangeEventArgs<T>> value2 = (EventHandler<CollectionChangeEventArgs<T>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OBL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private bool BB2()
	{
		return (IBh != null && IBh.GetInvocationList().Length > 1) || (PBc != null && PBc.GetInvocationList().Length > 1) || (OBL != null && OBL.GetInvocationList().Length > 1) || (BBd != null && BBd.GetInvocationList().Length > 1);
	}

	protected IDisposable BlockReentrancy()
	{
		pBm.Enter();
		return pBm;
	}

	protected virtual void CheckReadOnly()
	{
		if (IsReadOnly)
		{
			throw new NotSupportedException(SR.GetString(SRName.ExReadOnlyCollection));
		}
	}

	protected void CheckReentrancy()
	{
		if (pBm.VLy() && BB2())
		{
			throw new InvalidOperationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5290));
		}
	}

	protected override void ClearItems()
	{
		CheckReadOnly();
		CheckReentrancy();
		T[] array = new T[base.Count];
		CopyTo(array, 0);
		int num3 = default(int);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			OnItemRemoving(num, array[num]);
			int num2 = 0;
			if (!mWQ())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		base.ClearItems();
		for (int num4 = array.Length - 1; num4 >= 0; num4--)
		{
			OnItemRemoved(num4, array[num4]);
		}
	}

	protected override void InsertItem(int index, T item)
	{
		CheckReadOnly();
		CheckReentrancy();
		OnItemAdding(index, item);
		base.InsertItem(index, item);
		OnItemAdded(index, item);
	}

	protected virtual void OnItemAdded(int index, T value)
	{
		using (BlockReentrancy())
		{
			IBh?.Invoke(this, new CollectionChangeEventArgs<T>(index, value));
		}
	}

	protected virtual void OnItemAdding(int index, T value)
	{
		using (BlockReentrancy())
		{
			PBc?.Invoke(this, new CollectionChangeEventArgs<T>(index, value));
		}
	}

	protected virtual void OnItemRemoved(int index, T value)
	{
		using (BlockReentrancy())
		{
			OBL?.Invoke(this, new CollectionChangeEventArgs<T>(index, value));
		}
	}

	protected virtual void OnItemRemoving(int index, T value)
	{
		using (BlockReentrancy())
		{
			BBd?.Invoke(this, new CollectionChangeEventArgs<T>(index, value));
		}
	}

	protected override void RemoveItem(int index)
	{
		CheckReadOnly();
		CheckReentrancy();
		T value = base[index];
		OnItemRemoving(index, value);
		base.RemoveItem(index);
		OnItemRemoved(index, value);
	}

	protected override void SetItem(int index, T item)
	{
		CheckReadOnly();
		CheckReentrancy();
		T val = base[index];
		if (item != val)
		{
			OnItemRemoving(index, val);
			OnItemAdding(index, item);
			base.SetItem(index, item);
			OnItemRemoved(index, val);
			OnItemAdded(index, item);
		}
	}

	public SimpleObservableCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		pBm = new rM();
		base._002Ector();
	}

	internal static bool mWQ()
	{
		return cWh == null;
	}

	internal static object aWx()
	{
		return cWh;
	}
}
