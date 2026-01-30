using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

public abstract class XmlDockingWindowContainer : XmlDockingObject
{
	private XmlDockingObjectCollection Knh;

	[CompilerGenerated]
	private Size dng;

	[CompilerGenerated]
	private Guid KnX;

	internal static XmlDockingWindowContainer vf9;

	[XmlElement("UIElement")]
	public XmlDockingObjectCollection Children => Knh;

	[XmlIgnore]
	public Size DockedSize
	{
		[CompilerGenerated]
		get
		{
			return dng;
		}
		[CompilerGenerated]
		set
		{
			dng = value;
		}
	}

	[XmlAttribute("DockedSize")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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

	[XmlAttribute]
	public Guid SelectedWindowUniqueId
	{
		[CompilerGenerated]
		get
		{
			return KnX;
		}
		[CompilerGenerated]
		set
		{
			KnX = value;
		}
	}

	protected XmlDockingWindowContainer()
	{
		IVH.CecNqz();
		Knh = new XmlDockingObjectCollection();
		base._002Ector();
		DockedSize = new Size(200.0, 200.0);
	}

	internal override void Deserialize(DependencyObject obj)
	{
		wH obj2 = obj as wH;
		if (obj2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		obj2.DockedSize = DockedSize;
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is wH wH))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		DockedSize = wH.DockedSize;
	}

	public virtual bool ShouldSerializeDockedSizeSerializable()
	{
		return DockedSize != new Size(200.0, 200.0);
	}

	public virtual bool ShouldSerializeSelectedWindowUniqueId()
	{
		return SelectedWindowUniqueId != Guid.Empty;
	}

	internal static bool Cfm()
	{
		return vf9 == null;
	}

	internal static XmlDockingWindowContainer yfo()
	{
		return vf9;
	}
}
