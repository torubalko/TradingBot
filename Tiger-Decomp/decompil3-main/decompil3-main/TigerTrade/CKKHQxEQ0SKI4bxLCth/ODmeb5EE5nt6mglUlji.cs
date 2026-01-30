using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using zJRLkvjQYeLbRipD6tI;

namespace CKKHQxEQ0SKI4bxLCth;

internal class ODmeb5EE5nt6mglUlji : Y40wjbjEJwBDdxlJjPo<string>
{
	[CompilerGenerated]
	private readonly ObservableCollection<string> qVkEOc33H4;

	private static ODmeb5EE5nt6mglUlji vyVfoy4nycqDPWmGoM74;

	public ObservableCollection<string> Values
	{
		[CompilerGenerated]
		get
		{
			return qVkEOc33H4;
		}
	}

	public ODmeb5EE5nt6mglUlji(string P_0, string P_1, IEnumerable<string> P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0, P_1);
		qVkEOc33H4 = new ObservableCollection<string>(P_2);
	}

	public void PspEdC0j19(IEnumerable<string> P_0)
	{
		Values.Clear();
		foreach (string item in P_0)
		{
			Values.Add(item);
		}
		base.Value = P_0.FirstOrDefault();
	}

	[SpecialName]
	public int RisE6Uyux4()
	{
		int num = 0;
		while (true)
		{
			if (num >= Values.Count)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					return -1;
				case 1:
					break;
				}
				break;
			}
			if (NQmNkb4nCvYhMfA2UPma(Values[num], base.Value))
			{
				break;
			}
			num++;
		}
		return num;
	}

	public kBGHo0laodgpHJ2IARPe lSkEgT9HTR<q6bg3QlaYpHC2q9VKm74, kBGHo0laodgpHJ2IARPe>(IEnumerable<q6bg3QlaYpHC2q9VKm74> P_0, Func<q6bg3QlaYpHC2q9VKm74, kBGHo0laodgpHJ2IARPe> P_1)
	{
		q6bg3QlaYpHC2q9VKm74[] array = P_0.ToArray();
		int num = RisE6Uyux4();
		if (num >= 0 && num < array.Length)
		{
			return P_1(array[num]);
		}
		return default(kBGHo0laodgpHJ2IARPe);
	}

	static ODmeb5EE5nt6mglUlji()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool NQmNkb4nCvYhMfA2UPma(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool hxRdPF4nZXRvFE9Ljetu()
	{
		return vyVfoy4nycqDPWmGoM74 == null;
	}

	internal static ODmeb5EE5nt6mglUlji ChhHRL4nVcpiQeAwuMLj()
	{
		return vyVfoy4nycqDPWmGoM74;
	}
}
