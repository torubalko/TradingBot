using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

public abstract class XmlDockingWindowRef : XmlDockingObject
{
	[CompilerGenerated]
	private Guid hn5;

	internal static XmlDockingWindowRef ffB;

	[XmlAttribute]
	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			return hn5;
		}
		[CompilerGenerated]
		set
		{
			hn5 = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XmlDockingWindowRef")]
	internal override void Deserialize(DependencyObject obj)
	{
		throw new InvalidOperationException(vVK.ssH(19804));
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is DockingWindow dockingWindow))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		UniqueId = dockingWindow.UniqueId;
	}

	public virtual bool ShouldSerializeUniqueId()
	{
		return UniqueId != Guid.Empty;
	}

	protected XmlDockingWindowRef()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool uf5()
	{
		return ffB == null;
	}

	internal static XmlDockingWindowRef ifj()
	{
		return ffB;
	}
}
