using System;
using System.Reflection;
using frv4s5X5SOo66jNvMvO6;
using hkZMMTXxD6qN8IAyOFGI;
using MhxjOdXxkI6wEJmk4G3f;
using PWXKwRXxL9cVgWUpa4xk;

namespace kN7XaiX5NS4gZCodwt8Z;

internal class hU1P6IX5belAIbp0T0Xn
{
	internal delegate void biPS7IX51KTRNaRRZBqJ(object o);

	internal static Module H3NX5kC7MS6;

	private static hU1P6IX5belAIbp0T0Xn uep3H2XgZIYgus6O9AFB;

	internal static void idrXtnabIve(int typemdt)
	{
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		int num3 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		FieldInfo[] fields = default(FieldInfo[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type = H3NX5kC7MS6.ResolveType(33554432 + typemdt);
				num2 = 0;
				if (nPVhRrXgCw3L0fqaGgBQ() == null)
				{
					num2 = 1;
				}
				continue;
			default:
				num3++;
				num2 = 3;
				continue;
			case 4:
			{
				MethodInfo method = (MethodInfo)H3NX5kC7MS6.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				k6qhq2Xgra3IANxfinmp(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2 = 0;
				if (nPVhRrXgCw3L0fqaGgBQ() == null)
				{
					num2 = 0;
				}
				continue;
			}
			case 3:
				break;
			case 1:
				fields = type.GetFields();
				num3 = 0;
				break;
			}
			if (num3 < fields.Length)
			{
				fieldInfo = fields[num3];
				num2 = 4;
				continue;
			}
			break;
		}
	}

	public hU1P6IX5belAIbp0T0Xn()
	{
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		base._002Ector();
	}

	static hU1P6IX5belAIbp0T0Xn()
	{
		RMpEErX55SDH1mxasQVF.v64X5Ol3UFK();
		inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		int num = 0;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		}
		H3NX5kC7MS6 = (Module)Ye8Y3aXgmiqIDR0JOQsr(Type.GetTypeFromHandle(QcxYwyXgK0B9bbGY3ZB9(33554446)).Assembly);
	}

	internal static void k6qhq2Xgra3IANxfinmp(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool wUBIxoXgVlQ63HkIlqY1()
	{
		return uep3H2XgZIYgus6O9AFB == null;
	}

	internal static hU1P6IX5belAIbp0T0Xn nPVhRrXgCw3L0fqaGgBQ()
	{
		return uep3H2XgZIYgus6O9AFB;
	}

	internal static RuntimeTypeHandle QcxYwyXgK0B9bbGY3ZB9(int token)
	{
		return yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(token);
	}

	internal static object Ye8Y3aXgmiqIDR0JOQsr(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
