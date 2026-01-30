using System;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal class WX
{
	internal delegate void S2(object o);

	internal static Module WTj;

	internal static WX GXN;

	internal static void OaYSkk(int typemdt)
	{
		Type type = WTj.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)WTj.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public WX()
	{
		fc.taYSkz();
		base._002Ector();
	}

	static WX()
	{
		fc.taYSkz();
		WTj = typeof(WX).Assembly.ManifestModule;
	}

	internal static bool uX3()
	{
		return GXN == null;
	}

	internal static WX fXT()
	{
		return GXN;
	}
}
