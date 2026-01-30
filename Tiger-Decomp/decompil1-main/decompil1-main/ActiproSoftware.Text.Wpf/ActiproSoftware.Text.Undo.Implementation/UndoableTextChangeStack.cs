using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Undo.Implementation;

internal class UndoableTextChangeStack : IUndoableTextChangeStack, IEnumerable<IUndoableTextChange>, IEnumerable
{
	private int qBZ;

	private int QB0;

	private List<IUndoableTextChange> zBv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler WBY;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler wBo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool uBD;

	internal static UndoableTextChangeStack qnU;

	public bool ContainsOrigin
	{
		[CompilerGenerated]
		get
		{
			return uBD;
		}
		[CompilerGenerated]
		set
		{
			uBD = value;
		}
	}

	internal bool ContainsSavePoint => QB0 >= 0;

	public int Capacity
	{
		get
		{
			return qBZ;
		}
		set
		{
			if (qBZ != value)
			{
				qBZ = value;
				if (mB6())
				{
					OnStackChanged(EventArgs.Empty);
				}
				OnCapacityChanged(EventArgs.Empty);
			}
		}
	}

	public int Count => zBv.Count;

	public bool IsAtSavePoint
	{
		get
		{
			return QB0 == 0;
		}
		internal set
		{
			QB0 = ((!value) ? (-1) : 0);
		}
	}

	public event EventHandler CapacityChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = WBY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WBY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = WBY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref WBY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler StackChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = wBo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wBo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = wBo;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wBo, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal UndoableTextChangeStack()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		qBZ = 100;
		QB0 = -1;
		base._002Ector();
		zBv = new List<IUndoableTextChange>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal void Clear(bool containsOrigin)
	{
		zBv.Clear();
		QB0 = -1;
		ContainsOrigin = containsOrigin;
		OnStackChanged(EventArgs.Empty);
	}

	internal IUndoableTextChange Peek()
	{
		if (zBv.Count == 0)
		{
			return null;
		}
		return zBv[0];
	}

	internal IUndoableTextChange Pop()
	{
		if (zBv.Count != 0)
		{
			QB0 = Math.Max(-1, QB0 - 1);
			IUndoableTextChange result = zBv[0];
			zBv.RemoveAt(0);
			OnStackChanged(EventArgs.Empty);
			return result;
		}
		return null;
	}

	internal bool Push(IUndoableTextChange textChange)
	{
		if (ContainsSavePoint)
		{
			QB0++;
		}
		zBv.Insert(0, textChange);
		bool result = mB6();
		OnStackChanged(EventArgs.Empty);
		return result;
	}

	private bool mB6()
	{
		if (qBZ >= 0 && zBv.Count > qBZ)
		{
			int num = zBv.Count - qBZ;
			zBv.RemoveRange(zBv.Count - num, num);
			if (QB0 >= zBv.Count)
			{
				QB0 = -1;
			}
			ContainsOrigin = false;
			return true;
		}
		int num2 = 0;
		if (Nnq() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		return num2 switch
		{
			_ => false, 
		};
	}

	public void CopyTo(IUndoableTextChange[] array, int arrayIndex)
	{
		zBv.CopyTo(array, arrayIndex);
	}

	public IEnumerator<IUndoableTextChange> GetEnumerator()
	{
		return zBv.GetEnumerator();
	}

	public IUndoableTextChange GetTextChange(int index)
	{
		if (index < 0 || index >= zBv.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502));
		}
		return zBv[index];
	}

	public int IndexOf(IUndoableTextChange textChange)
	{
		return zBv.IndexOf(textChange);
	}

	protected virtual void OnCapacityChanged(EventArgs e)
	{
		WBY?.Invoke(this, e);
	}

	protected virtual void OnStackChanged(EventArgs e)
	{
		wBo?.Invoke(this, e);
	}

	internal static bool Cn2()
	{
		return qnU == null;
	}

	internal static UndoableTextChangeStack Nnq()
	{
		return qnU;
	}
}
