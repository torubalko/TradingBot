using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("AutoHideTabStrip")]
public class XmlAutoHideTabStrip : XmlObjectBase
{
	private XmlToolWindowContainerCollection Ons;

	private Side Pnq;

	internal static XmlAutoHideTabStrip Ef1;

	[XmlElement("ToolWindowContainer")]
	public XmlToolWindowContainerCollection Children => Ons;

	[XmlAttribute]
	public Side Side
	{
		get
		{
			return Pnq;
		}
		set
		{
			Pnq = value;
		}
	}

	public XmlAutoHideTabStrip()
	{
		IVH.CecNqz();
		Ons = new XmlToolWindowContainerCollection();
		Pnq = Side.Right;
		base._002Ector();
	}

	internal static bool pfH()
	{
		return Ef1 == null;
	}

	internal static XmlAutoHideTabStrip Dff()
	{
		return Ef1;
	}
}
