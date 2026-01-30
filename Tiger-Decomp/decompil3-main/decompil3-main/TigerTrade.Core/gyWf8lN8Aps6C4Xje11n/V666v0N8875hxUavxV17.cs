using System;
using System.Reflection;
using nff6NvN8pYC4xeKDOd05;

namespace gyWf8lN8Aps6C4Xje11n;

internal class V666v0N8875hxUavxV17
{
	internal static ModuleHandle aDJN8P8KTTm;

	private static V666v0N8875hxUavxV17 vix8OWkofSBIdCL3lJJu;

	internal static RuntimeTypeHandle cHJk4pLGZX2(int token)
	{
		return aDJN8P8KTTm.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	internal static RuntimeFieldHandle Gluk4ufQxe7(int token)
	{
		return aDJN8P8KTTm.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	static V666v0N8875hxUavxV17()
	{
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
		aDJN8P8KTTm = C1d0C8koYIKhrI5IhpwW(((object[])vYcErOkoGFqC4pbyFbXf(typeof(V666v0N8875hxUavxV17).Assembly))[0]);
	}

	internal static bool mpmPPsko9bXvf2ZwMvlb()
	{
		return vix8OWkofSBIdCL3lJJu == null;
	}

	internal static V666v0N8875hxUavxV17 LjAkTGkonS66Q6YV9ZJm()
	{
		return vix8OWkofSBIdCL3lJJu;
	}

	internal static object vYcErOkoGFqC4pbyFbXf(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	internal static ModuleHandle C1d0C8koYIKhrI5IhpwW(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
