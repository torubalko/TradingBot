using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("ToolWindow")]
public class XmlToolWindow : XmlDockingWindow
{
	[CompilerGenerated]
	private Size VOB;

	internal static XmlToolWindow dfV;

	[XmlIgnore]
	public Size ContainerAutoHideSize
	{
		[CompilerGenerated]
		get
		{
			return VOB;
		}
		[CompilerGenerated]
		set
		{
			VOB = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlAttribute("ContainerAutoHideSize")]
	public string ContainerAutoHideSizeSerializable
	{
		get
		{
			return XmlObjectBase.SizeToString(ContainerAutoHideSize);
		}
		set
		{
			ContainerAutoHideSize = XmlObjectBase.StringToSize(value).Value;
		}
	}

	public XmlToolWindow()
	{
		IVH.CecNqz();
		base._002Ector();
		ContainerAutoHideSize = new Size(200.0, 200.0);
	}

	internal override void Deserialize(DependencyObject obj)
	{
		ToolWindow obj2 = obj as ToolWindow;
		if (obj2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		obj2.ContainerAutoHideSize = ContainerAutoHideSize;
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is ToolWindow toolWindow))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		ContainerAutoHideSize = toolWindow.iBv();
	}

	public virtual bool ShouldSerializeContainerAutoHideSizeSerializable()
	{
		return ContainerAutoHideSize != new Size(200.0, 200.0);
	}

	internal static bool Of3()
	{
		return dfV == null;
	}

	internal static XmlToolWindow Pfr()
	{
		return dfV;
	}
}
