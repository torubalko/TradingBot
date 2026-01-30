using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Serialization;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[XmlType("DocumentWindow")]
public class XmlDocumentWindow : XmlDockingWindow
{
	[CompilerGenerated]
	private string yOw;

	internal static XmlDocumentWindow ofI;

	[XmlAttribute]
	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return yOw;
		}
		[CompilerGenerated]
		set
		{
			yOw = value;
		}
	}

	internal override void Deserialize(DependencyObject obj)
	{
		DocumentWindow obj2 = obj as DocumentWindow;
		if (obj2 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Deserialize(obj);
		obj2.FileName = FileName;
	}

	internal override void Serialize(DependencyObject obj)
	{
		if (!(obj is DocumentWindow documentWindow))
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		base.Serialize(obj);
		FileName = documentWindow.FileName;
	}

	public virtual bool ShouldSerializeFileName()
	{
		return !string.IsNullOrEmpty(FileName);
	}

	public XmlDocumentWindow()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool jfa()
	{
		return ofI == null;
	}

	internal static XmlDocumentWindow sfX()
	{
		return ofI;
	}
}
