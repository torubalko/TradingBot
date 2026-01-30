using System;
using System.Reflection;
using HExkDCsORifnalUv1owx;
using rXssPVsOOYd71bKiWjYb;
using UxBecVsOUPcejrh1NEnp;
using vGgPQ4s6WEgjxnvUb1Vk;

namespace XtyZDDs6MnbLyDWy0Fdf;

internal class wmXYxTs66Y4Supqa5jHK
{
	internal delegate void Y2FvbUs6qlNerwUwRj2j(object o);

	internal static Module cFds6OlLLt8;

	private static wmXYxTs66Y4Supqa5jHK SL3MF4sCPbnkpAOWhQnQ;

	internal static void yf0sAZKg6mA(int typemdt)
	{
		Type type = SYC4C1sC3nJyZsNoxPrB(cFds6OlLLt8, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		if (IrCC68sCF4XR6m2eKerN() == null)
		{
			num = 0;
		}
		int num2 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				if (IrCC68sCF4XR6m2eKerN() == null)
				{
					num = 1;
				}
				break;
			case 3:
			{
				MethodInfo method = (MethodInfo)tQY5EMsCuX4CtrhjDxn9(cFds6OlLLt8, r1o6oTsCpy37WPaeDLne(fieldInfo) + 100663296);
				ruEG0GsCzqhP6OK5bM8j(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
				num2++;
				num = 2;
				if (!nyQsv4sCJCfjnRW68HM9())
				{
					num = 1;
				}
				break;
			}
			case 1:
			case 2:
				if (num2 < fields.Length)
				{
					fieldInfo = fields[num2];
					num = 3;
					if (IrCC68sCF4XR6m2eKerN() != null)
					{
						num = 1;
					}
					break;
				}
				return;
			}
		}
	}

	public wmXYxTs66Y4Supqa5jHK()
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
		base._002Ector();
	}

	static wmXYxTs66Y4Supqa5jHK()
	{
		Je5Bbtsr0J824S6qIju0();
		vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		pLYXr9sr2CnMFWA9YqQ8();
		cFds6OlLLt8 = (Module)iLn9gVsr9K3t4Frsht4l(p0IZ6csrf94Dm1IrbtM1(e2J0fHsrHh1hPUtSI6lV(33554445)).Assembly);
	}

	internal static Type SYC4C1sC3nJyZsNoxPrB(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static int r1o6oTsCpy37WPaeDLne(object P_0)
	{
		return ((MemberInfo)P_0).MetadataToken;
	}

	internal static object tQY5EMsCuX4CtrhjDxn9(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveMethod(P_1);
	}

	internal static void ruEG0GsCzqhP6OK5bM8j(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool nyQsv4sCJCfjnRW68HM9()
	{
		return SL3MF4sCPbnkpAOWhQnQ == null;
	}

	internal static wmXYxTs66Y4Supqa5jHK IrCC68sCF4XR6m2eKerN()
	{
		return SL3MF4sCPbnkpAOWhQnQ;
	}

	internal static void Je5Bbtsr0J824S6qIju0()
	{
		qhHWErs6IBu8qtqJbdvd.DI9s6AAreQp();
	}

	internal static void pLYXr9sr2CnMFWA9YqQ8()
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
	}

	internal static RuntimeTypeHandle e2J0fHsrHh1hPUtSI6lV(int token)
	{
		return d2cMH7sOMiUbRG7HML9r.gKjsArZ2Fe1(token);
	}

	internal static Type p0IZ6csrf94Dm1IrbtM1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object iLn9gVsr9K3t4Frsht4l(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
