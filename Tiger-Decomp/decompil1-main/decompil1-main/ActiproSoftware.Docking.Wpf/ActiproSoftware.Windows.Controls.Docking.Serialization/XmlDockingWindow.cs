using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

public abstract class XmlDockingWindow : XmlDockingObject
{
	private WindowState GnV;

	[CompilerGenerated]
	private Guid inP;

	[CompilerGenerated]
	private string Wnf;

	[CompilerGenerated]
	private string bnU;

	[CompilerGenerated]
	private Size wnc;

	[CompilerGenerated]
	private bool hn4;

	[CompilerGenerated]
	private DateTime jnj;

	[CompilerGenerated]
	private Rect? BnZ;

	[CompilerGenerated]
	private Rect? Rnb;

	[CompilerGenerated]
	private XmlDockingWindowState xnA;

	[CompilerGenerated]
	private TabLayoutKind vnH;

	[CompilerGenerated]
	private Type in0;

	private static XmlDockingWindow dfh;

	[XmlAttribute]
	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			return inP;
		}
		[CompilerGenerated]
		set
		{
			inP = value;
		}
	}

	[XmlAttribute]
	public string SerializationId
	{
		[CompilerGenerated]
		get
		{
			return Wnf;
		}
		[CompilerGenerated]
		set
		{
			Wnf = value;
		}
	}

	[XmlAttribute]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return bnU;
		}
		[CompilerGenerated]
		set
		{
			bnU = value;
		}
	}

	[XmlIgnore]
	public Size ContainerDockedSize
	{
		[CompilerGenerated]
		get
		{
			return wnc;
		}
		[CompilerGenerated]
		set
		{
			wnc = value;
		}
	}

	[XmlAttribute("ContainerDockedSize")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
	public bool IsOpen
	{
		[CompilerGenerated]
		get
		{
			return hn4;
		}
		[CompilerGenerated]
		set
		{
			hn4 = value;
		}
	}

	[XmlAttribute]
	public DateTime LastActiveDateTime
	{
		[CompilerGenerated]
		get
		{
			return jnj;
		}
		[CompilerGenerated]
		set
		{
			jnj = value;
		}
	}

	[XmlIgnore]
	public Rect? StandardMdiBounds
	{
		[CompilerGenerated]
		get
		{
			return BnZ;
		}
		[CompilerGenerated]
		set
		{
			BnZ = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlAttribute("StandardMdiBounds")]
	public string StandardMdiBoundsSerializable
	{
		get
		{
			return XmlObjectBase.RectToString(StandardMdiBounds);
		}
		set
		{
			StandardMdiBounds = XmlObjectBase.StringToRect(value);
		}
	}

	[XmlIgnore]
	public Rect? StandardMdiRestoreBounds
	{
		[CompilerGenerated]
		get
		{
			return Rnb;
		}
		[CompilerGenerated]
		set
		{
			Rnb = value;
		}
	}

	[XmlAttribute("StandardMdiRestoreBounds")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public string StandardMdiRestoreBoundsSerializable
	{
		get
		{
			return XmlObjectBase.RectToString(StandardMdiRestoreBounds);
		}
		set
		{
			StandardMdiRestoreBounds = XmlObjectBase.StringToRect(value);
		}
	}

	[XmlAttribute]
	public WindowState StandardMdiWindowState
	{
		get
		{
			return GnV;
		}
		set
		{
			GnV = value;
		}
	}

	[XmlAttribute]
	public XmlDockingWindowState State
	{
		[CompilerGenerated]
		get
		{
			return xnA;
		}
		[CompilerGenerated]
		set
		{
			xnA = value;
		}
	}

	[XmlAttribute]
	public TabLayoutKind TabbedMdiLayoutKind
	{
		[CompilerGenerated]
		get
		{
			return vnH;
		}
		[CompilerGenerated]
		set
		{
			vnH = value;
		}
	}

	[XmlIgnore]
	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public Type Type
	{
		[CompilerGenerated]
		get
		{
			return in0;
		}
		[CompilerGenerated]
		set
		{
			in0 = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[XmlAttribute("Type")]
	public string TypeSerializable
	{
		get
		{
			return XmlObjectBase.TypeToString(Type);
		}
		set
		{
			Type = XmlObjectBase.StringToType(value);
		}
	}

	protected XmlDockingWindow()
	{
		IVH.CecNqz();
		base._002Ector();
		ContainerDockedSize = new Size(200.0, 200.0);
		LastActiveDateTime = DateTime.MinValue;
	}

	internal DockingWindow knF()
	{
		DockingWindow dockingWindow = null;
		if (!(Type != null))
		{
			if (GetType() == typeof(XmlToolWindow))
			{
				dockingWindow = new ToolWindow();
				int num = 0;
				if (!BfL())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else if (GetType() == typeof(XmlDocumentWindow))
			{
				dockingWindow = new DocumentWindow();
			}
		}
		else
		{
			dockingWindow = Activator.CreateInstance(Type) as DockingWindow;
		}
		if (dockingWindow != null)
		{
			if (!string.IsNullOrEmpty(SerializationId))
			{
				dockingWindow.SerializationId = SerializationId;
			}
			if (!string.IsNullOrEmpty(Name))
			{
				dockingWindow.Name = Name;
			}
		}
		return dockingWindow;
	}

	internal override void Deserialize(DependencyObject obj)
	{
		int num = 2;
		DockingWindow dockingWindow = default(DockingWindow);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					dockingWindow = obj as DockingWindow;
					num2 = 1;
					if (BfL())
					{
						continue;
					}
					break;
				case 1:
					if (dockingWindow == null)
					{
						throw new ArgumentNullException(vVK.ssH(15298));
					}
					base.Deserialize(obj);
					dockingWindow.ContainerDockedSize = ContainerDockedSize;
					if (LastActiveDateTime > DateTime.MinValue)
					{
						dockingWindow.LastActiveDateTime = LastActiveDateTime;
					}
					if (StandardMdiBounds.HasValue && !StandardMdiBounds.Value.IsEmpty)
					{
						dockingWindow.StandardMdiBounds = StandardMdiBounds.Value;
					}
					dockingWindow.StandardMdiWindowState = StandardMdiWindowState;
					dockingWindow.TabbedMdiLayoutKind = TabbedMdiLayoutKind;
					if (UniqueId != Guid.Empty)
					{
						num2 = 0;
						if (kfl() == null)
						{
							continue;
						}
						break;
					}
					goto IL_0088;
				default:
					{
						dockingWindow.UniqueId = UniqueId;
						goto IL_0088;
					}
					IL_0088:
					switch (State)
					{
					case XmlDockingWindowState.Docked:
						dockingWindow.zIH(DockingWindowState.Docked);
						break;
					case XmlDockingWindowState.AutoHide:
						dockingWindow.zIH(DockingWindowState.AutoHide);
						break;
					case XmlDockingWindowState.Document:
						dockingWindow.zIH(DockingWindowState.Document);
						break;
					default:
						dockingWindow.zIH((!(dockingWindow is ToolWindow)) ? DockingWindowState.Document : DockingWindowState.Docked);
						break;
					}
					return;
				}
				break;
			}
		}
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is DockingWindow dockingWindow))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		ContainerDockedSize = dockingWindow.Skx();
		Name = dockingWindow.Name;
		IsOpen = dockingWindow.IsCurrentlyOpen;
		LastActiveDateTime = dockingWindow.LastActiveDateTime;
		int num = 1;
		if (kfl() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
		{
			SerializationId = dockingWindow.SerializationId;
			StandardMdiBounds = dockingWindow.StandardMdiBounds;
			StandardMdiWindowState = dockingWindow.StandardMdiWindowState;
			TabbedMdiLayoutKind = dockingWindow.TabbedMdiLayoutKind;
			UniqueId = dockingWindow.UniqueId;
			DockingWindowState dockingWindowState = dockingWindow.QkM();
			if (dockingWindowState == DockingWindowState.Document)
			{
				State = XmlDockingWindowState.Document;
				break;
			}
			if (dockingWindowState == DockingWindowState.AutoHide)
			{
				State = XmlDockingWindowState.AutoHide;
				break;
			}
			goto default;
		}
		default:
			State = XmlDockingWindowState.Docked;
			break;
		}
		Type type = obj.GetType();
		if (type != typeof(ToolWindow) && type != typeof(DocumentWindow))
		{
			Type = type;
		}
	}

	public virtual bool ShouldSerializeContainerDockedSizeSerializable()
	{
		return ContainerDockedSize != new Size(200.0, 200.0);
	}

	public virtual bool ShouldSerializeLastActiveDateTime()
	{
		return LastActiveDateTime > DateTime.MinValue;
	}

	public virtual bool ShouldSerializeName()
	{
		return !string.IsNullOrEmpty(Name);
	}

	public virtual bool ShouldSerializeSerializationId()
	{
		return !string.IsNullOrEmpty(SerializationId);
	}

	public virtual bool ShouldSerializeStandardMdiBoundsSerializable()
	{
		if (StandardMdiBounds.HasValue)
		{
			return !StandardMdiBounds.Value.IsEmpty;
		}
		return false;
	}

	public virtual bool ShouldSerializeStandardMdiWindowState()
	{
		return StandardMdiWindowState != WindowState.Normal;
	}

	public virtual bool ShouldSerializeTabbedMdiLayoutKind()
	{
		return TabbedMdiLayoutKind != TabLayoutKind.Normal;
	}

	public virtual bool ShouldSerializeTypeSerializable()
	{
		return Type != null;
	}

	public virtual bool ShouldSerializeUniqueId()
	{
		return UniqueId != Guid.Empty;
	}

	internal static bool BfL()
	{
		return dfh == null;
	}

	internal static XmlDockingWindow kfl()
	{
		return dfh;
	}
}
