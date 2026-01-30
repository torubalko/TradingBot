using System;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal class i2
{
	internal delegate void NI(object o);

	internal static Module VD;

	private static i2 yx;

	internal static void jQ9Sff(int typemdt)
	{
		Type type = VD.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num2 = default(int);
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)VD.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			int num = 0;
			if (cp() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public i2()
	{
		ns.vQ9Sfz();
		base._002Ector();
	}

	static i2()
	{
		ns.vQ9Sfz();
		VD = typeof(i2).Assembly.ManifestModule;
	}

	internal static bool wl()
	{
		return yx == null;
	}

	internal static i2 cp()
	{
		return yx;
	}
}
