using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using Ha9I1wna0XjsKnZiPJll;
using s8CVoTnYOlGDs7vDiB5f;
using t0cUvd9rWKdvEo0FrvfQ;
using TuAMtrl1Nd3XoZQQUXf0;

namespace wojq2qnlxYntegq4Zkmn;

[DefaultMember("Item")]
internal sealed class kf6GjanlSIbsiRsjsETs : IEnumerable<vJGfm5nYMCEZFuST02my>, IEnumerable, IDisposable
{
	private readonly List<vJGfm5nYMCEZFuST02my> RXInlQKEWqP;

	private static kf6GjanlSIbsiRsjsETs YnkSPgbufdb8WU6k2s0P;

	public int Count => fxGgtSbuvJr3tiwvvxYH(RXInlQKEWqP);

	public void YZlnlLOy8Es(vJGfm5nYMCEZFuST02my P_0)
	{
		RXInlQKEWqP.Add(P_0);
	}

	public int rS4nleytH5v(vJGfm5nYMCEZFuST02my P_0)
	{
		return RXInlQKEWqP.IndexOf(P_0);
	}

	public void IDUnlsbfgYx(int P_0, vJGfm5nYMCEZFuST02my P_1)
	{
		RXInlQKEWqP.Insert(P_0, P_1);
	}

	public void Remove(vJGfm5nYMCEZFuST02my area)
	{
		RXInlQKEWqP.Remove(area);
	}

	public void s7GnlXca9Ep(int P_0)
	{
		crOpt9buGQeZDSqbDUYb(RXInlQKEWqP, P_0);
	}

	public void Clear()
	{
		foreach (vJGfm5nYMCEZFuST02my item in RXInlQKEWqP)
		{
			item.OHUnYJQYVAL(out var array, out var array2);
			xnWqxt9rIxkL0gKJjgWl.mn19rVvMxuZ((string)tQXPWQbuoq8Z0QitIJWK(wTuTU5buYyD6GlOTSuIE(item)), array, array2);
		}
		RXInlQKEWqP.Clear();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[SpecialName]
	public vJGfm5nYMCEZFuST02my s8Fnlj882ml(int P_0)
	{
		return RXInlQKEWqP[P_0];
	}

	public IEnumerator<vJGfm5nYMCEZFuST02my> GetEnumerator()
	{
		return RXInlQKEWqP.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)RXInlQKEWqP).GetEnumerator();
	}

	public void Dispose()
	{
		foreach (vJGfm5nYMCEZFuST02my item in RXInlQKEWqP)
		{
			krd9ZrbuBaClgRjlBoiE(item);
		}
	}

	public kf6GjanlSIbsiRsjsETs()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		RXInlQKEWqP = new List<vJGfm5nYMCEZFuST02my>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static kf6GjanlSIbsiRsjsETs()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool TviTyWbu9bfTPpIVS33h()
	{
		return YnkSPgbufdb8WU6k2s0P == null;
	}

	internal static kf6GjanlSIbsiRsjsETs gfg96Ubunb0FBLXXKj9c()
	{
		return YnkSPgbufdb8WU6k2s0P;
	}

	internal static void crOpt9buGQeZDSqbDUYb(object P_0, int P_1)
	{
		((List<vJGfm5nYMCEZFuST02my>)P_0).RemoveAt(P_1);
	}

	internal static object wTuTU5buYyD6GlOTSuIE(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Chart;
	}

	internal static object tQXPWQbuoq8Z0QitIJWK(object P_0)
	{
		return ((JWWhw2nBzBKPn08eRh08)P_0).Xl8naQX8iZn();
	}

	internal static int fxGgtSbuvJr3tiwvvxYH(object P_0)
	{
		return ((List<vJGfm5nYMCEZFuST02my>)P_0).Count;
	}

	internal static void krd9ZrbuBaClgRjlBoiE(object P_0)
	{
		((vJGfm5nYMCEZFuST02my)P_0).Dispose();
	}
}
