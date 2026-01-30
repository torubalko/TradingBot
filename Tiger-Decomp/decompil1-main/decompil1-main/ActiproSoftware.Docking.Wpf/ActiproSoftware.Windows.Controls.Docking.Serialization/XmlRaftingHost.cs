using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("RaftingHost")]
public class XmlRaftingHost : XmlDockingObject
{
	[CompilerGenerated]
	private Guid bO2;

	[CompilerGenerated]
	private XmlAutoHideHost TOe;

	[CompilerGenerated]
	private XmlObjectBase BOG;

	[CompilerGenerated]
	private Point? NOI;

	[CompilerGenerated]
	private Size TOk;

	[CompilerGenerated]
	private WindowState bOC;

	internal static XmlRaftingHost RfF;

	[XmlAttribute]
	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			return bO2;
		}
		[CompilerGenerated]
		set
		{
			bO2 = value;
		}
	}

	[XmlElement("AutoHideHost")]
	public XmlAutoHideHost AutoHideHost
	{
		[CompilerGenerated]
		get
		{
			return TOe;
		}
		[CompilerGenerated]
		set
		{
			TOe = value;
		}
	}

	[XmlElement("Content")]
	public XmlObjectBase Content
	{
		[CompilerGenerated]
		get
		{
			return BOG;
		}
		[CompilerGenerated]
		set
		{
			BOG = value;
		}
	}

	[XmlIgnore]
	public Point? Location
	{
		[CompilerGenerated]
		get
		{
			return NOI;
		}
		[CompilerGenerated]
		set
		{
			NOI = value;
		}
	}

	[XmlAttribute("Location")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string LocationSerializable
	{
		get
		{
			return XmlObjectBase.PointToString(Location);
		}
		set
		{
			Location = XmlObjectBase.StringToPoint(value);
		}
	}

	[XmlIgnore]
	public Size Size
	{
		[CompilerGenerated]
		get
		{
			return TOk;
		}
		[CompilerGenerated]
		set
		{
			TOk = value;
		}
	}

	[XmlAttribute("Size")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string SizeSerializable
	{
		get
		{
			return XmlObjectBase.SizeToString(Size);
		}
		set
		{
			Size = XmlObjectBase.StringToSize(value).Value;
		}
	}

	[XmlAttribute]
	public WindowState WindowState
	{
		[CompilerGenerated]
		get
		{
			return bOC;
		}
		[CompilerGenerated]
		set
		{
			bOC = value;
		}
	}

	internal override void Deserialize(DependencyObject obj)
	{
		if (!(obj is DockHost dockHost))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		dockHost.XeK(Location);
		dockHost.beO(Size);
		dockHost.Qeb(WindowState);
		if (UniqueId != Guid.Empty)
		{
			dockHost.UniqueId = UniqueId;
		}
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is DockHost dockHost))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		WindowState = dockHost.zeZ();
		Location = dockHost.GeB();
		Size = dockHost.Hen();
		UniqueId = dockHost.UniqueId;
	}

	public virtual bool ShouldSerializeUniqueId()
	{
		return UniqueId != Guid.Empty;
	}

	public XmlRaftingHost()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool ffd()
	{
		return RfF == null;
	}

	internal static XmlRaftingHost lf7()
	{
		return RfF;
	}
}
