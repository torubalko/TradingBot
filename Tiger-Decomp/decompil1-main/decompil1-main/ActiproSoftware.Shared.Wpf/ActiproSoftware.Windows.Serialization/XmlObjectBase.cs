using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Serialization;

[Serializable]
public abstract class XmlObjectBase
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object Joe;

	internal static XmlObjectBase ifL;

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return Joe;
		}
		[CompilerGenerated]
		set
		{
			Joe = value;
		}
	}

	protected static string PointToString(Point? point)
	{
		return point.HasValue ? new PointConverter().ConvertToInvariantString(point.Value) : null;
	}

	protected static string RectToString(Rect? rect)
	{
		return rect.HasValue ? new RectConverter().ConvertToInvariantString(rect.Value) : null;
	}

	protected static string SizeToString(Size? size)
	{
		return size.HasValue ? new SizeConverter().ConvertToInvariantString(size.Value) : null;
	}

	protected static Point? StringToPoint(string text)
	{
		return (Point?)(string.IsNullOrEmpty(text) ? null : new PointConverter().ConvertFromInvariantString(text));
	}

	protected static Rect? StringToRect(string text)
	{
		return (Rect?)(string.IsNullOrEmpty(text) ? null : new RectConverter().ConvertFromInvariantString(text));
	}

	protected static Size? StringToSize(string text)
	{
		return (Size?)(string.IsNullOrEmpty(text) ? null : new SizeConverter().ConvertFromInvariantString(text));
	}

	protected static Type StringToType(string text)
	{
		return Type.GetType(text);
	}

	protected static string TypeToString(Type type)
	{
		if (type == null)
		{
			return null;
		}
		string assemblyQualifiedName = type.AssemblyQualifiedName;
		int num = assemblyQualifiedName.IndexOf(',');
		if (num == -1 || num == assemblyQualifiedName.Length - 1)
		{
			return null;
		}
		num = assemblyQualifiedName.IndexOf(',', num + 1);
		if (num == -1 || num == assemblyQualifiedName.Length - 1)
		{
			return null;
		}
		return assemblyQualifiedName.Substring(0, num);
	}

	protected XmlObjectBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Of4()
	{
		return ifL == null;
	}

	internal static XmlObjectBase pfs()
	{
		return ifL;
	}
}
