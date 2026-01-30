using System;
using System.Reflection;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using RRGeI95GVMJEHGH0bnkl;
using x97CE55GhEYKgt7TSVZT;

namespace Ej8JRQ59ZbVWjiQwhlc6;

internal class rtBm4p59y0so1bXa4WcN
{
	internal delegate void DeLBRu59ClYlNaHYTOPi(object o);

	internal static Module cTR59VviqNN;

	private static rtBm4p59y0so1bXa4WcN agfDEhLMFeXuIWH2gqGM;

	internal static void eKgLybNS33B(int typemdt)
	{
		Type type = pjV7hBLMuu4CaHr7VrK7(cTR59VviqNN, 33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 0;
		int num2 = 2;
		if (AgnY9gLMpcoj9Bc7UPte() != null)
		{
			num2 = 0;
		}
		FieldInfo fieldInfo = default(FieldInfo);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
			case 3:
				if (num >= fields.Length)
				{
					num2 = 0;
					if (AgnY9gLMpcoj9Bc7UPte() == null)
					{
						num2 = 0;
					}
					break;
				}
				fieldInfo = fields[num];
				methodInfo = (MethodInfo)cTR59VviqNN.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				num2 = 0;
				if (AgnY9gLMpcoj9Bc7UPte() == null)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				fieldInfo.SetValue(null, (MulticastDelegate)KMcDmFLMzEL2tyZPjM38(type, methodInfo));
				num++;
				num2 = 3;
				break;
			}
		}
	}

	public rtBm4p59y0so1bXa4WcN()
	{
		OAMmlRLO0i8Gy3V30afg();
		base._002Ector();
	}

	static rtBm4p59y0so1bXa4WcN()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		cTR59VviqNN = Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33556041)).Assembly.ManifestModule;
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type pjV7hBLMuu4CaHr7VrK7(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static object KMcDmFLMzEL2tyZPjM38(Type P_0, object P_1)
	{
		return Delegate.CreateDelegate(P_0, (MethodInfo)P_1);
	}

	internal static bool OEMyr7LM3tG6WEZuH7pa()
	{
		return agfDEhLMFeXuIWH2gqGM == null;
	}

	internal static rtBm4p59y0so1bXa4WcN AgnY9gLMpcoj9Bc7UPte()
	{
		return agfDEhLMFeXuIWH2gqGM;
	}

	internal static void OAMmlRLO0i8Gy3V30afg()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
