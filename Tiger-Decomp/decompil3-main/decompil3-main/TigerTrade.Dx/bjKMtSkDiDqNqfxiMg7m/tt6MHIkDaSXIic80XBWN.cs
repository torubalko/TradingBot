using System;
using System.Reflection;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using mbUKQckNlyCOeZGxOWCQ;

namespace bjKMtSkDiDqNqfxiMg7m;

internal class tt6MHIkDaSXIic80XBWN
{
	internal delegate void spXikEkD4SV27DNc2PFU(object o);

	internal static Module CBbkDlvwUmK;

	private static tt6MHIkDaSXIic80XBWN eO4SCGkdFyrweW0TNjVq;

	internal static void u5nkWiWKFlF(int typemdt)
	{
		Type type = XAehE4kduugfG9kNqMUN(CBbkDlvwUmK, 33554432 + typemdt);
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
				num2 = 0;
				if (Y1E7w5kd3MtkK178kh5d())
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
				if (NHx9dIkdptI5E4OTf1DD() == null)
				{
					num2 = 1;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					dt7BHqkdzw1dFsVAlmrB(fieldInfo, null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
					num++;
					num2 = 1;
					if (NHx9dIkdptI5E4OTf1DD() == null)
					{
						num2 = 2;
					}
					continue;
				default:
					method = (MethodInfo)CBbkDlvwUmK.ResolveMethod(fieldInfo.MetadataToken + 100663296);
					num2 = 3;
					continue;
				case 2:
					break;
				}
				break;
			}
		}
	}

	public tt6MHIkDaSXIic80XBWN()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
	}

	static tt6MHIkDaSXIic80XBWN()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		CBbkDlvwUmK = (Module)J6pW6Dkg2DKAKqAlixBT(Type.GetTypeFromHandle(zAP29Hkg0pcyCb1RtoeH(33554482)).Assembly);
	}

	internal static Type XAehE4kduugfG9kNqMUN(object P_0, int P_1)
	{
		return ((Module)P_0).ResolveType(P_1);
	}

	internal static void dt7BHqkdzw1dFsVAlmrB(object P_0, object P_1, object P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool Y1E7w5kd3MtkK178kh5d()
	{
		return eO4SCGkdFyrweW0TNjVq == null;
	}

	internal static tt6MHIkDaSXIic80XBWN NHx9dIkdptI5E4OTf1DD()
	{
		return eO4SCGkdFyrweW0TNjVq;
	}

	internal static RuntimeTypeHandle zAP29Hkg0pcyCb1RtoeH(int token)
	{
		return yjPYDZkNi1vFNQZb4QFE.z9KkWDtnqUA(token);
	}

	internal static object J6pW6Dkg2DKAKqAlixBT(object P_0)
	{
		return ((Assembly)P_0).ManifestModule;
	}
}
