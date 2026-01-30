using System;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal class zVO
{
	internal delegate void kVg(object o);

	internal static Module csL;

	internal static zVO RL0;

	internal static void yecNqq(int typemdt)
	{
		Type type = csL.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		int num3 = default(int);
		while (num < fields.Length)
		{
			FieldInfo fieldInfo = fields[num];
			MethodInfo method = (MethodInfo)csL.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num++;
			int num2 = 0;
			if (XLH() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
	}

	public zVO()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	static zVO()
	{
		IVH.CecNqz();
		csL = typeof(zVO).Assembly.ManifestModule;
	}

	internal static bool lL1()
	{
		return RL0 == null;
	}

	internal static zVO XLH()
	{
		return RL0;
	}
}
