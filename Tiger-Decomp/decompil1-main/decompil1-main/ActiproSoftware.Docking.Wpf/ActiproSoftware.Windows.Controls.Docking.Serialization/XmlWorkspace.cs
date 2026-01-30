using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("Workspace")]
public class XmlWorkspace : XmlDockingObject
{
	[CompilerGenerated]
	private XmlObjectBase jOO;

	private static XmlWorkspace s8L;

	[XmlElement("Content")]
	public XmlObjectBase Content
	{
		[CompilerGenerated]
		get
		{
			return jOO;
		}
		[CompilerGenerated]
		set
		{
			jOO = value;
		}
	}

	public XmlWorkspace()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool W8l()
	{
		return s8L == null;
	}

	internal static XmlWorkspace c89()
	{
		return s8L;
	}
}
