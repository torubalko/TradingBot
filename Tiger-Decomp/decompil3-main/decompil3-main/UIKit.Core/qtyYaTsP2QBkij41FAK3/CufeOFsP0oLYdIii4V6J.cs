using System;
using System.Reflection;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace qtyYaTsP2QBkij41FAK3;

internal class CufeOFsP0oLYdIii4V6J
{
	internal delegate void JDw0CEsPfDsGWU0mWRj8(object o);

	internal static Module LoOsPHNLcQ4;

	internal static CufeOFsP0oLYdIii4V6J mdRyk5Xi6Z3GEyPTKn8O;

	internal static void q7kX1z99LqX(int typemdt)
	{
		Type type = LoOsPHNLcQ4.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				num2 = 0;
				num = 1;
				if (ru2PflXiOT2506OOjeAH() != null)
				{
					num = 1;
				}
				continue;
			case 3:
				num2++;
				num = 0;
				if (!UjjHqcXiMugF0g7Q4RiH())
				{
					num = 0;
				}
				continue;
			}
			if (num2 >= fields.Length)
			{
				return;
			}
			FieldInfo fieldInfo = fields[num2];
			MethodInfo method = (MethodInfo)wq2TtJXiqHZlbXeemgc3(LoOsPHNLcQ4, fieldInfo.MetadataToken + 100663296);
			jk0McKXiIkMe6H8vHNfl(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			num = 3;
			if (!UjjHqcXiMugF0g7Q4RiH())
			{
				num = 3;
			}
		}
	}

	public CufeOFsP0oLYdIii4V6J()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static CufeOFsP0oLYdIii4V6J()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		EMYtYSXiWIWPtLY8Fx42();
		LoOsPHNLcQ4 = (Module)H9iuysXiUVnYXxKK1v8T(I2sVm3XitccwH6noeYFw(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554493)).Assembly);
		int num = 0;
		if (1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object wq2TtJXiqHZlbXeemgc3(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveMethod(P_1);
	}

	internal static void jk0McKXiIkMe6H8vHNfl(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool UjjHqcXiMugF0g7Q4RiH()
	{
		return mdRyk5Xi6Z3GEyPTKn8O == null;
	}

	internal static CufeOFsP0oLYdIii4V6J ru2PflXiOT2506OOjeAH()
	{
		return mdRyk5Xi6Z3GEyPTKn8O;
	}

	internal static void EMYtYSXiWIWPtLY8Fx42()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static Type I2sVm3XitccwH6noeYFw(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object H9iuysXiUVnYXxKK1v8T(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
