using System;
using System.Reflection;
using rE4lpnT863QnijKQK5;

namespace oRZtxCaSAYh6EEGEIZ;

internal class Idt5pgryuYoFVQiX6j
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module Kh2o8BSHbd;

	internal static Idt5pgryuYoFVQiX6j wwk;

	internal static void WrmWXX(int typemdt)
	{
		Type type = Kh2o8BSHbd.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		int num3 = default(int);
		while (num < fields.Length)
		{
			FieldInfo fieldInfo = fields[num];
			MethodInfo method = (MethodInfo)Kh2o8BSHbd.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num++;
			int num2 = 0;
			if (!bwF())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
	}

	public Idt5pgryuYoFVQiX6j()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static Idt5pgryuYoFVQiX6j()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Kh2o8BSHbd = typeof(Idt5pgryuYoFVQiX6j).Assembly.ManifestModule;
	}

	internal static bool bwF()
	{
		return wwk == null;
	}

	internal static Idt5pgryuYoFVQiX6j xwd()
	{
		return wwk;
	}
}
