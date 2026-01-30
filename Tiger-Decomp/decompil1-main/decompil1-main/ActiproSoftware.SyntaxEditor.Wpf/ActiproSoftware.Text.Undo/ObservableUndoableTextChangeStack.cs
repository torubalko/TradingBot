using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Undo;

[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class ObservableUndoableTextChangeStack : DisposableObject, INotifyCollectionChanged, IUndoableTextChangeStack, IEnumerable<IUndoableTextChange>, IEnumerable
{
	private IUndoableTextChangeStack D8q;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler K82;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NotifyCollectionChangedEventHandler o87;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler V8i;

	internal static ObservableUndoableTextChangeStack d1o;

	public int Capacity
	{
		get
		{
			return D8q.Capacity;
		}
		set
		{
			D8q.Capacity = value;
		}
	}

	public int Count => D8q.Count;

	public bool IsAtSavePoint => D8q.IsAtSavePoint;

	public event EventHandler CapacityChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = K82;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref K82, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = K82;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref K82, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = o87;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref o87, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = o87;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref o87, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	public event EventHandler StackChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = V8i;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref V8i, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = V8i;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref V8i, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ObservableUndoableTextChangeStack(IUndoableTextChangeStack stack)
	{
		grA.DaB7cz();
		base._002Ector();
		if (stack == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197932));
		}
		D8q = stack;
		stack.CapacityChanged += H89;
		stack.StackChanged += x8y;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private void H89(object P_0, EventArgs P_1)
	{
		K82?.Invoke(this, P_1);
	}

	private void x8y(object P_0, EventArgs P_1)
	{
		V8i?.Invoke(this, P_1);
		o87?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	public bool Contains(IUndoableTextChange textChange)
	{
		return IndexOf(textChange) != -1;
	}

	public void CopyTo(IUndoableTextChange[] array, int arrayIndex)
	{
		D8q.CopyTo(array, arrayIndex);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (D8q != null)
			{
				D8q.CapacityChanged -= H89;
				D8q.StackChanged -= x8y;
			}
			D8q = null;
		}
		base.Dispose(disposing);
	}

	public IEnumerator<IUndoableTextChange> GetEnumerator()
	{
		return D8q.GetEnumerator();
	}

	public IUndoableTextChange GetTextChange(int index)
	{
		return D8q.GetTextChange(index);
	}

	public int IndexOf(IUndoableTextChange textChange)
	{
		return D8q.IndexOf(textChange);
	}

	internal static bool I1Q()
	{
		return d1o == null;
	}

	internal static ObservableUndoableTextChangeStack I1y()
	{
		return d1o;
	}
}
