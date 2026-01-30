using System;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal class hdE
{
	internal delegate void NdC(object o);

	internal static Module fRD;

	internal static hdE ted;

	internal static void RuEwGG(int typemdt)
	{
		Type type = fRD.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)fRD.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public hdE()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	static hdE()
	{
		awj.QuEwGz();
		fRD = typeof(hdE).Assembly.ManifestModule;
	}

	internal static bool nev()
	{
		return ted == null;
	}

	internal static hdE Dep()
	{
		return ted;
	}
}
