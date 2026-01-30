using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("DockSiteLayout")]
public class XmlDockSiteLayout : XmlObjectBase
{
	private XmlDocumentWindowCollection kny;

	private XmlRaftingHostCollection bno;

	private XmlToolWindowCollection Unt;

	[CompilerGenerated]
	private XmlAutoHideHost mnu;

	[CompilerGenerated]
	private XmlObjectBase Knz;

	[CompilerGenerated]
	private DockSiteSerializationBehavior kOi;

	[CompilerGenerated]
	private int eOd;

	private static XmlDockSiteLayout mf2;

	[XmlElement("AutoHideHost")]
	public XmlAutoHideHost AutoHideHost
	{
		[CompilerGenerated]
		get
		{
			return mnu;
		}
		[CompilerGenerated]
		set
		{
			mnu = value;
		}
	}

	[XmlElement("Content")]
	public XmlObjectBase Content
	{
		[CompilerGenerated]
		get
		{
			return Knz;
		}
		[CompilerGenerated]
		set
		{
			Knz = value;
		}
	}

	public XmlDocumentWindowCollection DocumentWindows => kny;

	public XmlRaftingHostCollection RaftingHosts => bno;

	[XmlAttribute]
	public DockSiteSerializationBehavior SerializationFormat
	{
		[CompilerGenerated]
		get
		{
			return kOi;
		}
		[CompilerGenerated]
		set
		{
			kOi = value;
		}
	}

	public XmlToolWindowCollection ToolWindows => Unt;

	[XmlAttribute]
	public int Version
	{
		[CompilerGenerated]
		get
		{
			return eOd;
		}
		[CompilerGenerated]
		set
		{
			eOd = value;
		}
	}

	public XmlDockSiteLayout()
	{
		IVH.CecNqz();
		kny = new XmlDocumentWindowCollection();
		bno = new XmlRaftingHostCollection();
		Unt = new XmlToolWindowCollection();
		base._002Ector();
		Version = 2;
	}

	public virtual bool ShouldSerializeDocumentWindows()
	{
		return DocumentWindows.Count != 0;
	}

	public virtual bool ShouldSerializeRaftingHosts()
	{
		return RaftingHosts.Count != 0;
	}

	public virtual bool ShouldSerializeToolWindows()
	{
		return ToolWindows.Count != 0;
	}

	public virtual bool ShouldSerializeVersion()
	{
		return Version >= 2;
	}

	internal static bool Hf6()
	{
		return mf2 == null;
	}

	internal static XmlDockSiteLayout nfW()
	{
		return mf2;
	}
}
