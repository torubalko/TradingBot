using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("Track")]
public class XmlTrack : XmlDockingObject
{
	[CompilerGenerated]
	private Size KOK;

	[CompilerGenerated]
	private DateTime hOJ;

	[CompilerGenerated]
	private Guid mOn;

	private static XmlTrack s8c;

	[XmlIgnore]
	public Size ContainerDockedSize
	{
		[CompilerGenerated]
		get
		{
			return KOK;
		}
		[CompilerGenerated]
		set
		{
			KOK = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlAttribute("ContainerDockedSize")]
	public string ContainerDockedSizeSerializable
	{
		get
		{
			return XmlObjectBase.SizeToString(ContainerDockedSize);
		}
		set
		{
			ContainerDockedSize = XmlObjectBase.StringToSize(value).Value;
		}
	}

	[XmlAttribute]
	public DateTime CreationDateTime
	{
		[CompilerGenerated]
		get
		{
			return hOJ;
		}
		[CompilerGenerated]
		set
		{
			hOJ = value;
		}
	}

	[XmlAttribute]
	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			return mOn;
		}
		[CompilerGenerated]
		set
		{
			mOn = value;
		}
	}

	public XmlTrack()
	{
		IVH.CecNqz();
		base._002Ector();
		ContainerDockedSize = new Size(200.0, 200.0);
	}

	internal override void Deserialize(DependencyObject obj)
	{
		bv obj2 = obj as bv;
		if (obj2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		obj2.ContainerDockedSize = ContainerDockedSize;
		obj2.lCM = CreationDateTime;
		obj2.UniqueId = UniqueId;
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is bv bv))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		ContainerDockedSize = bv.ContainerDockedSize;
		CreationDateTime = bv.lCM;
		UniqueId = bv.UniqueId;
	}

	public virtual bool ShouldSerializeContainerDockedSizeSerializable()
	{
		return ContainerDockedSize != new Size(200.0, 200.0);
	}

	public virtual bool ShouldSerializeUniqueId()
	{
		return UniqueId != Guid.Empty;
	}

	internal static bool q8M()
	{
		return s8c == null;
	}

	internal static XmlTrack N8h()
	{
		return s8c;
	}
}
