using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("StandardMdiHost")]
public class XmlStandardMdiHost : XmlObjectBase
{
	private XmlDockingObjectCollection COm;

	[CompilerGenerated]
	private bool fOa;

	private static XmlStandardMdiHost AfE;

	[XmlAttribute]
	public bool AreWindowsMaximized
	{
		[CompilerGenerated]
		get
		{
			return fOa;
		}
		[CompilerGenerated]
		set
		{
			fOa = value;
		}
	}

	[XmlElement("UIElement")]
	public XmlDockingObjectCollection Children => COm;

	public XmlStandardMdiHost()
	{
		IVH.CecNqz();
		COm = new XmlDockingObjectCollection();
		base._002Ector();
	}

	internal static bool cfk()
	{
		return AfE == null;
	}

	internal static XmlStandardMdiHost tfq()
	{
		return AfE;
	}
}
