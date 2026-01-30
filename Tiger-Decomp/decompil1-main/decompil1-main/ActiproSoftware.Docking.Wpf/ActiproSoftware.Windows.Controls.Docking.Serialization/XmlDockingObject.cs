using System;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

public abstract class XmlDockingObject : XmlObjectBase
{
	private static XmlDockingObject cfY;

	internal virtual void Deserialize(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
	}

	internal virtual void Serialize(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
	}

	protected XmlDockingObject()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool FfC()
	{
		return cfY == null;
	}

	internal static XmlDockingObject wfK()
	{
		return cfY;
	}
}
