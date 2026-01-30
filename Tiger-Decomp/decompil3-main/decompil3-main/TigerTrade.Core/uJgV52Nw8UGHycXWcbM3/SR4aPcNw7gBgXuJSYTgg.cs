using System;
using System.Reflection;
using EDugZvNwF6e5LYsQZ3C5;
using gyWf8lN8Aps6C4Xje11n;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace uJgV52Nw8UGHycXWcbM3;

internal class SR4aPcNw7gBgXuJSYTgg
{
	internal delegate void rr0K20NwP56wUR0RJXUV(object o);

	internal static Module X6QNwAPyTUU;

	internal static SR4aPcNw7gBgXuJSYTgg t9dd62kYjWfbtAU0uH5Y;

	internal static void eTck4J2lK7D(int typemdt)
	{
		Type type = X6QNwAPyTUU.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			int num2;
			if (num >= fields.Length)
			{
				num2 = 1;
				if (DwppZIkYQUWq9Rs4AWTg() == null)
				{
					num2 = 1;
				}
				goto IL_0009;
			}
			goto IL_00d9;
			IL_00d9:
			fieldInfo = fields[num];
			num2 = 2;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					MethodInfo method = (MethodInfo)VNXorQkYdM8swvUn6WHY(X6QNwAPyTUU, fieldInfo.MetadataToken + 100663296);
					fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num++;
					num2 = 0;
					if (DwppZIkYQUWq9Rs4AWTg() == null)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
					return;
				case 3:
					goto IL_00d9;
				}
				break;
			}
		}
	}

	public SR4aPcNw7gBgXuJSYTgg()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
	}

	static SR4aPcNw7gBgXuJSYTgg()
	{
		f5eO4WkYgM1gTPMqeANR();
		cTVoREkYR3j2f7eNpBh0();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		X6QNwAPyTUU = (Module)njJIlQkYMafUfkDWne8x(Type.GetTypeFromHandle(OojksnkY6Do6KEXVr761(33554506)).Assembly);
	}

	internal static object VNXorQkYdM8swvUn6WHY(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveMethod(P_1);
	}

	internal static bool jmQvnekYEqLQOrycgvq1()
	{
		return t9dd62kYjWfbtAU0uH5Y == null;
	}

	internal static SR4aPcNw7gBgXuJSYTgg DwppZIkYQUWq9Rs4AWTg()
	{
		return t9dd62kYjWfbtAU0uH5Y;
	}

	internal static void f5eO4WkYgM1gTPMqeANR()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}

	internal static void cTVoREkYR3j2f7eNpBh0()
	{
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static RuntimeTypeHandle OojksnkY6Do6KEXVr761(int token)
	{
		return V666v0N8875hxUavxV17.cHJk4pLGZX2(token);
	}

	internal static object njJIlQkYMafUfkDWne8x(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
