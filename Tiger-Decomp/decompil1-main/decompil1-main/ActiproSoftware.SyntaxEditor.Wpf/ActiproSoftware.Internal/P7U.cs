using System;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal class P7U
{
	internal delegate void u7G(object o);

	internal static Module yqL;

	internal static P7U bic;

	internal static void saB7cc(int typemdt)
	{
		Type type = yqL.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)yqL.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
		int num = 0;
		if (fiT() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public P7U()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	static P7U()
	{
		grA.DaB7cz();
		yqL = typeof(P7U).Assembly.ManifestModule;
	}

	internal static bool fid()
	{
		return bic == null;
	}

	internal static P7U fiT()
	{
		return bic;
	}
}
