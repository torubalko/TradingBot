using System;
using System.Reflection;
using rE4lpnT863QnijKQK5;

namespace oRZtxCaSAYh6EEGEIZ;

internal class Idt5pgryuYoFVQiX6j
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module Kh2o8BSHbd;

	internal static Idt5pgryuYoFVQiX6j wZ2;

	internal static void BN1hJJ(int typemdt)
	{
		Type type = Kh2o8BSHbd.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)Kh2o8BSHbd.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Idt5pgryuYoFVQiX6j()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	static Idt5pgryuYoFVQiX6j()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		Kh2o8BSHbd = typeof(Idt5pgryuYoFVQiX6j).Assembly.ManifestModule;
	}

	internal static bool WZq()
	{
		return wZ2 == null;
	}

	internal static Idt5pgryuYoFVQiX6j nZc()
	{
		return wZ2;
	}
}
