using System;
using System.Runtime.CompilerServices;
using System.Threading;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using Gx0QOoYLedrPVEaoo7GC;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace QXU65DYL4YQUxjbgafXX;

internal sealed class uHxtTNYLlW2MfD5UYMw5
{
	[CompilerGenerated]
	private Action<TicksRequest, byte[]> kfYYLSYYWl9;

	private readonly OrBfQyYLLY4N9oy1sBI9 hl5YLxRruKo;

	internal static uHxtTNYLlW2MfD5UYMw5 Juki1uSNZrFnITUsriQp;

	[SpecialName]
	[CompilerGenerated]
	public void xBlYLkNj49Y(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = kfYYLSYYWl9;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref kfYYLSYYWl9, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ftDYL1LJ4DG(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = kfYYLSYYWl9;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref kfYYLSYYWl9, value, action2);
		}
		while ((object)action != action2);
	}

	public void lhiYLD5vMrs(TicksRequest P_0)
	{
		kfYYLSYYWl9?.Invoke(P_0, (byte[])Ixf80JSNKigWkUkoPQSS(hl5YLxRruKo, ((Symbol)eKJXfkSNrY4uQnBbvu4N(P_0)).ID));
	}

	public void jqUYLbOXFJ1(Symbol P_0, TickEvent P_1)
	{
		hl5YLxRruKo.O01YLsQkA5g(P_0, P_1);
	}

	public void Q92YLNjr8tp()
	{
		hl5YLxRruKo.Clear();
	}

	public uHxtTNYLlW2MfD5UYMw5()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		hl5YLxRruKo = new OrBfQyYLLY4N9oy1sBI9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static uHxtTNYLlW2MfD5UYMw5()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		bDkPLtSNmnEjjOvnBkGC();
	}

	internal static object eKJXfkSNrY4uQnBbvu4N(object P_0)
	{
		return ((TicksRequest)P_0).InternalSymbol;
	}

	internal static object Ixf80JSNKigWkUkoPQSS(object P_0, object P_1)
	{
		return ((OrBfQyYLLY4N9oy1sBI9)P_0).pQOYLXaC82N((string)P_1);
	}

	internal static bool bRsostSNVKC7ePsblm77()
	{
		return Juki1uSNZrFnITUsriQp == null;
	}

	internal static uHxtTNYLlW2MfD5UYMw5 S7kHpfSNChdPT0poDaxm()
	{
		return Juki1uSNZrFnITUsriQp;
	}

	internal static void bDkPLtSNmnEjjOvnBkGC()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
