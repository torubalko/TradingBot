using System;
using System.Reflection;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;

namespace HMIyn6Ly6wQVIyntraLI;

internal class lbCWTULyR3LVZn8ohxey
{
	internal delegate void zCVH75LyOm1lF6iEuOO7(object o);

	internal static Module OOhLyMxgaiQ;

	internal static lbCWTULyR3LVZn8ohxey SV5ECUeTglYOImECBA4k;

	internal static void r6NehHScWJv(int typemdt)
	{
		Type type = sIutXoeTMfvtEkaNv49j(OOhLyMxgaiQ, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo method = default(MethodInfo);
		while (true)
		{
			int num2;
			if (num < fields.Length)
			{
				fieldInfo = fields[num];
				method = (MethodInfo)OOhLyMxgaiQ.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num2 = 0;
				if (!xDZ6jEeTRHTbomg51ng3())
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
				if (xDZ6jEeTRHTbomg51ng3())
				{
					num2 = 3;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					LEjigieTO8NsgX9sxrui(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num2 = 2;
					continue;
				case 2:
					num++;
					num2 = 1;
					if (!xDZ6jEeTRHTbomg51ng3())
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
		}
	}

	public lbCWTULyR3LVZn8ohxey()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static lbCWTULyR3LVZn8ohxey()
	{
		WNiUdCeTqcPOBPM4Rjwj();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (true)
		{
			num = 0;
		}
		switch (num)
		{
		}
		v9MT1ReTInolqqYMt6kP();
		OOhLyMxgaiQ = Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554799)).Assembly.ManifestModule;
	}

	internal static Type sIutXoeTMfvtEkaNv49j(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static void LEjigieTO8NsgX9sxrui(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool xDZ6jEeTRHTbomg51ng3()
	{
		return SV5ECUeTglYOImECBA4k == null;
	}

	internal static lbCWTULyR3LVZn8ohxey vv9hu8eT6Z4vxxjDsWgg()
	{
		return SV5ECUeTglYOImECBA4k;
	}

	internal static void WNiUdCeTqcPOBPM4Rjwj()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void v9MT1ReTInolqqYMt6kP()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}
}
