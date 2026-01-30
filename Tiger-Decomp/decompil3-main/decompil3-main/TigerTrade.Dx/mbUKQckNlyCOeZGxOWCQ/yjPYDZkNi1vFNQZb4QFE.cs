using System;
using System.Reflection;
using H59IbFkNkUTQB7uIfts0;

namespace mbUKQckNlyCOeZGxOWCQ;

internal class yjPYDZkNi1vFNQZb4QFE
{
	internal static ModuleHandle SgTkN4VHLJP;

	internal static yjPYDZkNi1vFNQZb4QFE mYDrtekgcJ9opDog3joA;

	internal static RuntimeTypeHandle z9KkWDtnqUA(int token)
	{
		return SgTkN4VHLJP.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle PkakWbkp8X6(int token)
	{
		return SgTkN4VHLJP.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	static yjPYDZkNi1vFNQZb4QFE()
	{
		FHvihtkgQwGQcexNDGYs();
		SgTkN4VHLJP = LJSdbskgguaXjoAFGcSj(((object[])YK2DWnkgd6IUSCakWGs3(typeof(yjPYDZkNi1vFNQZb4QFE).Assembly))[0]);
	}

	internal static bool hPgWKVkgjOJ80BIhTkMh()
	{
		return mYDrtekgcJ9opDog3joA == null;
	}

	internal static yjPYDZkNi1vFNQZb4QFE CfGSk1kgEYLTPIKYu9H3()
	{
		return mYDrtekgcJ9opDog3joA;
	}

	internal static void FHvihtkgQwGQcexNDGYs()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object YK2DWnkgd6IUSCakWGs3(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	internal static ModuleHandle LJSdbskgguaXjoAFGcSj(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
