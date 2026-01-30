using System;
using System.IO;
using System.Threading;
using BfZtb759KlUg4482QKym;
using JRwshAGIG9TQVUyhbBfS;
using K1GcsD5GTtMSlaiJI0Xh;
using moF8YxGOi5FwsSIWeLap;
using x97CE55GhEYKgt7TSVZT;

namespace pRyW3dGIHuKegJRGmAhq;

internal class Wl9aYpGI29sF3F7DYw7u : aL93kCGInkTPJhJQ0CIA, IDisposable
{
	private BinaryWriter RqZGIfuoMsX;

	private object USpGI96hI1r;

	private static Wl9aYpGI29sF3F7DYw7u j2sc6o5MG0MQEEDkPfPe;

	public Wl9aYpGI29sF3F7DYw7u(Stream P_0)
	{
		ffMj195MvRYNwbp32fyR();
		USpGI96hI1r = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		RqZGIfuoMsX = new BinaryWriter(P_0);
	}

	public void UKelYvIQf4p(gVcH0dGOaoPveD5KlIGw P_0)
	{
		int num = 1;
		int num2 = num;
		object uSpGI96hI1r = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uSpGI96hI1r = USpGI96hI1r;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(uSpGI96hI1r, ref lockTaken);
				RqZGIfuoMsX.Write(P_0.r1dGOlRY1Z3());
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(uSpGI96hI1r);
				}
			}
		}
	}

	public void Dispose()
	{
		rN0iTb5MBUEiXNn4vrp0(RqZGIfuoMsX);
	}

	static Wl9aYpGI29sF3F7DYw7u()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		Vtwd2X5Ma8EdcWSt05so();
	}

	internal static void ffMj195MvRYNwbp32fyR()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool dMKJ7E5MYg1bIJXRv3FL()
	{
		return j2sc6o5MG0MQEEDkPfPe == null;
	}

	internal static Wl9aYpGI29sF3F7DYw7u ntcG9C5MovhFvT6R0xbM()
	{
		return j2sc6o5MG0MQEEDkPfPe;
	}

	internal static void rN0iTb5MBUEiXNn4vrp0(object P_0)
	{
		((BinaryWriter)P_0).Dispose();
	}

	internal static void Vtwd2X5Ma8EdcWSt05so()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
