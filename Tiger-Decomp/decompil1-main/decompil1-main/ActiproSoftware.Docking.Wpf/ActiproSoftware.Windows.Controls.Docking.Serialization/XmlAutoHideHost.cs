using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("AutoHideHost")]
public class XmlAutoHideHost : XmlObjectBase
{
	private XmlAutoHideTabStripCollection tnp;

	internal static XmlAutoHideHost qHr;

	[XmlElement("AutoHideTabStrip")]
	public XmlAutoHideTabStripCollection Children => tnp;

	public XmlAutoHideHost()
	{
		IVH.CecNqz();
		tnp = new XmlAutoHideTabStripCollection();
		base._002Ector();
	}

	internal static bool CHz()
	{
		return qHr == null;
	}

	internal static XmlAutoHideHost Nf0()
	{
		return qHr;
	}
}
