using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class CollectionChangeEventArgs<T> : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int AVx;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T RVg;

	internal static object etx;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return AVx;
		}
		[CompilerGenerated]
		private set
		{
			AVx = value;
		}
	}

	public T Item
	{
		[CompilerGenerated]
		get
		{
			return RVg;
		}
		[CompilerGenerated]
		private set
		{
			RVg = value;
		}
	}

	public CollectionChangeEventArgs(int index, T item)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Index = index;
		Item = item;
	}

	internal static bool dtT()
	{
		return etx == null;
	}

	internal static object ktk()
	{
		return etx;
	}
}
