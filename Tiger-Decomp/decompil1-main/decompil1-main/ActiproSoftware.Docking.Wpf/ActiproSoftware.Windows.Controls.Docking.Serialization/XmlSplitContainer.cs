using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("SplitContainer")]
public class XmlSplitContainer : XmlDockingObject
{
	private XmlDockingObjectCollection WO1;

	[CompilerGenerated]
	private Orientation yON;

	[CompilerGenerated]
	private Size mOQ;

	internal static XmlSplitContainer Efx;

	[XmlAttribute]
	public Orientation Orientation
	{
		[CompilerGenerated]
		get
		{
			return yON;
		}
		[CompilerGenerated]
		set
		{
			yON = value;
		}
	}

	[XmlElement("UIElement")]
	public XmlDockingObjectCollection Children => WO1;

	[XmlIgnore]
	public Size DockedSize
	{
		[CompilerGenerated]
		get
		{
			return mOQ;
		}
		[CompilerGenerated]
		set
		{
			mOQ = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlAttribute("DockedSize")]
	public string DockedSizeSerializable
	{
		get
		{
			return XmlObjectBase.SizeToString(DockedSize);
		}
		set
		{
			DockedSize = XmlObjectBase.StringToSize(value).Value;
		}
	}

	public XmlSplitContainer()
	{
		IVH.CecNqz();
		WO1 = new XmlDockingObjectCollection();
		base._002Ector();
		DockedSize = new Size(200.0, 200.0);
	}

	internal override void Deserialize(DependencyObject obj)
	{
		SplitContainer obj2 = obj as SplitContainer;
		if (obj2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		obj2.WaW(DockedSize);
		obj2.Orientation = Orientation;
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is SplitContainer splitContainer))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		DockedSize = splitContainer.Daa();
		Orientation = splitContainer.Orientation;
	}

	public virtual bool ShouldSerializeDockedSizeSerializable()
	{
		return DockedSize != new Size(200.0, 200.0);
	}

	internal static bool jfR()
	{
		return Efx == null;
	}

	internal static XmlSplitContainer hfD()
	{
		return Efx;
	}
}
