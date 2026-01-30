using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

public class DockingWindowDeserializingEventArgs : EventArgs
{
	[CompilerGenerated]
	private bool iJ5;

	[CompilerGenerated]
	private XmlDockingWindow LJy;

	[CompilerGenerated]
	private DockingWindow LJo;

	internal static DockingWindowDeserializingEventArgs rHq;

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return iJ5;
		}
		[CompilerGenerated]
		set
		{
			iJ5 = value;
		}
	}

	public XmlDockingWindow Node
	{
		[CompilerGenerated]
		get
		{
			return LJy;
		}
		[CompilerGenerated]
		private set
		{
			LJy = value;
		}
	}

	public DockingWindow Window
	{
		[CompilerGenerated]
		get
		{
			return LJo;
		}
		[CompilerGenerated]
		set
		{
			LJo = value;
		}
	}

	public DockingWindowDeserializingEventArgs(DockingWindow window, XmlDockingWindow node)
	{
		IVH.CecNqz();
		base._002Ector();
		Window = window;
		Node = node;
	}

	internal static bool PHw()
	{
		return rHq == null;
	}

	internal static DockingWindowDeserializingEventArgs QHg()
	{
		return rHq;
	}
}
