using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using RRGeI95GVMJEHGH0bnkl;
using x97CE55GhEYKgt7TSVZT;

namespace WE6Hf0aXR8SSUZsDjIUK;

public class ATbgJSaXgNE0oPXm1B5T : DependencyObject, IMultiValueConverter
{
	public static readonly DependencyProperty apHaXIfoX40;

	public static readonly DependencyProperty q6NaXWkmGW0;

	private static ATbgJSaXgNE0oPXm1B5T CTdchuxhTRWiDDOtb82P;

	public object EqualValue
	{
		get
		{
			return GetValue(apHaXIfoX40);
		}
		set
		{
			SetValue(apHaXIfoX40, value2);
		}
	}

	public object NotEqualValue
	{
		get
		{
			return GetValue(q6NaXWkmGW0);
		}
		set
		{
			SetValue(q6NaXWkmGW0, value2);
		}
	}

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0.Length < 2)
		{
			return EqualValue;
		}
		IEnumerator<object> enumerator = P_0.Skip(1).GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				while (AxjbAUxhVFPEGcyVR9Fm(enumerator))
				{
					if (!enumerator.Current.Equals(P_0[0]))
					{
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
						{
							num2 = 1;
						}
						switch (num2)
						{
						case 1:
							return NotEqualValue;
						}
					}
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			return EqualValue;
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return Array.Empty<object>();
	}

	public ATbgJSaXgNE0oPXm1B5T()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static ATbgJSaXgNE0oPXm1B5T()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				apHaXIfoX40 = DependencyProperty.Register(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-90307782 ^ -90182426), L7IxN5xhCZBkxTjeZox0(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777237)), Type.GetTypeFromHandle(EwHhXCxhrHPOUFpASdGO(33555982)));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				q6NaXWkmGW0 = DependencyProperty.Register(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x12620268 ^ 0x1263ED9C), L7IxN5xhCZBkxTjeZox0(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777237)), L7IxN5xhCZBkxTjeZox0(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33555982)));
				return;
			}
		}
	}

	internal static bool qk2rmYxhyLKRkWKrxTY9()
	{
		return CTdchuxhTRWiDDOtb82P == null;
	}

	internal static ATbgJSaXgNE0oPXm1B5T cUUSW5xhZvDGxpjCcEuu()
	{
		return CTdchuxhTRWiDDOtb82P;
	}

	internal static bool AxjbAUxhVFPEGcyVR9Fm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Type L7IxN5xhCZBkxTjeZox0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle EwHhXCxhrHPOUFpASdGO(int token)
	{
		return mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(token);
	}
}
