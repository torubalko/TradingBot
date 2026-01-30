using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Serialization;

public class ItemSerializationEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object vou;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private XmlObjectBase ro2;

	private static ItemSerializationEventArgs BfB;

	public object Item
	{
		[CompilerGenerated]
		get
		{
			return vou;
		}
		[CompilerGenerated]
		private set
		{
			vou = value;
		}
	}

	public XmlObjectBase Node
	{
		[CompilerGenerated]
		get
		{
			return ro2;
		}
		[CompilerGenerated]
		private set
		{
			ro2 = value;
		}
	}

	public ItemSerializationEventArgs(object item, XmlObjectBase node)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Item = item;
		Node = node;
	}

	internal static bool pfA()
	{
		return BfB == null;
	}

	internal static ItemSerializationEventArgs ufV()
	{
		return BfB;
	}
}
