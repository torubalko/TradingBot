using System;
using System.Reflection;
using lmDVLFXTelX8TWB2gCPn;
using Mp0rQhXtcD2M433xKykv;
using nXNMiwXTSjaRAVOuyCXd;
using WUsie0XTELvQJLckfItk;

namespace jEgdwUXtLxVsqcXxILc3;

internal class bpj6JSXtx7P08OtOwbYM
{
	internal delegate void qK49rwXtsSpSnnk7twCU(object o);

	internal static Module CbtXtekRZvI;

	internal static bpj6JSXtx7P08OtOwbYM lNcZ7BX8KHUb5j67IwlS;

	internal static void QYJXuueMUKn(int typemdt)
	{
		Type type = CbtXtekRZvI.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 1;
		if (!pOvmmIX8mnYbMtnsCGBG())
		{
			num = 1;
		}
		int num2 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				num2 = 0;
				goto IL_0054;
			case 3:
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num = 2;
				if (!pOvmmIX8mnYbMtnsCGBG())
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				{
					num2++;
					goto IL_0054;
				}
				IL_0054:
				if (num2 >= fields.Length)
				{
					return;
				}
				fieldInfo = fields[num2];
				method = (MethodInfo)CbtXtekRZvI.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num = 3;
				break;
			}
		}
	}

	public bpj6JSXtx7P08OtOwbYM()
	{
		YMQMOvX8wZHb7vF86xfi();
		base._002Ector();
	}

	static bpj6JSXtx7P08OtOwbYM()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				T2OXZhXtXqRemtkpvtX8.g1uXtTdsjEL();
				num2 = 0;
				if (true)
				{
					num2 = 0;
				}
				break;
			default:
				opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
				ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
				CbtXtekRZvI = (Module)ayPbaOX87SxQqDtduabW(Type.GetTypeFromHandle(S8SBvUXTLqIAjCXUcTDe.rpfXz2bfOh8(33554456)).Assembly);
				return;
			}
		}
	}

	internal static bool pOvmmIX8mnYbMtnsCGBG()
	{
		return lNcZ7BX8KHUb5j67IwlS == null;
	}

	internal static bpj6JSXtx7P08OtOwbYM MBsQOqX8hw9l3cKN5Nrt()
	{
		return lNcZ7BX8KHUb5j67IwlS;
	}

	internal static void YMQMOvX8wZHb7vF86xfi()
	{
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
	}

	internal static object ayPbaOX87SxQqDtduabW(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
