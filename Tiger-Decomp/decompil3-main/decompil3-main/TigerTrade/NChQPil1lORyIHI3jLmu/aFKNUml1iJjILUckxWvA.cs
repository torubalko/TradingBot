using System;
using System.Reflection;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace NChQPil1lORyIHI3jLmu;

internal class aFKNUml1iJjILUckxWvA
{
	internal delegate void qPt2mXl1Ds6PqZNPU6cf(object o);

	internal static Module crul14iYrTj;

	internal static aFKNUml1iJjILUckxWvA BIBo86Nyjh3ZekJirTOH;

	internal static void PtjNhVIgBYs(int typemdt)
	{
		Type type = OILAYKNydp6LueuWLc5b(crul14iYrTj, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		if (NlyLMANyQ7KHdcSZHW7m() != null)
		{
			num = 0;
		}
		FieldInfo fieldInfo = default(FieldInfo);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
			{
				MethodInfo methodInfo = (MethodInfo)crul14iYrTj.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)gMJmjaNygQqOd7Ac3TbF(type, methodInfo));
				num = 3;
				continue;
			}
			case 3:
				num2++;
				break;
			default:
				num2 = 0;
				break;
			}
			if (num2 >= fields.Length)
			{
				int num3 = 2;
				num = num3;
				continue;
			}
			fieldInfo = fields[num2];
			num = 1;
			if (!QW9sp0NyE0gnT1I825KI())
			{
				num = 1;
			}
		}
	}

	public aFKNUml1iJjILUckxWvA()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static aFKNUml1iJjILUckxWvA()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				crul14iYrTj = Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33556121)).Assembly.ManifestModule;
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type OILAYKNydp6LueuWLc5b(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static object gMJmjaNygQqOd7Ac3TbF(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	internal static bool QW9sp0NyE0gnT1I825KI()
	{
		return BIBo86Nyjh3ZekJirTOH == null;
	}

	internal static aFKNUml1iJjILUckxWvA NlyLMANyQ7KHdcSZHW7m()
	{
		return BIBo86Nyjh3ZekJirTOH;
	}
}
