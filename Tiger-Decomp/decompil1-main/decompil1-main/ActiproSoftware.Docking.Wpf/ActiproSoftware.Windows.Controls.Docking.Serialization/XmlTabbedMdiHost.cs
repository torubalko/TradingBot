using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("TabbedMdiHost")]
public class XmlTabbedMdiHost : XmlObjectBase
{
	[CompilerGenerated]
	private XmlObjectBase YOW;

	internal static XmlTabbedMdiHost RfZ;

	[XmlElement("Content")]
	public XmlObjectBase Content
	{
		[CompilerGenerated]
		get
		{
			return YOW;
		}
		[CompilerGenerated]
		set
		{
			YOW = value;
		}
	}

	public XmlTabbedMdiHost()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool vfu()
	{
		return RfZ == null;
	}

	internal static XmlTabbedMdiHost bfy()
	{
		return RfZ;
	}
}
