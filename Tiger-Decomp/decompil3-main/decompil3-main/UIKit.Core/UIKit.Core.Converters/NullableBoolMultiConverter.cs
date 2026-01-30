using System;
using System.Globalization;
using System.Windows.Data;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core.Converters;

public class NullableBoolMultiConverter : IMultiValueConverter
{
	internal static NullableBoolMultiConverter YtTmfgXBzmwP9NndHYLE;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 0;
		int num2 = 12;
		object result = default(object);
		int num4 = default(int);
		bool flag = default(bool);
		object obj3 = default(object);
		string text = default(string);
		bool flag2 = default(bool);
		object obj2 = default(object);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 10:
			case 11:
				return result;
			case 7:
				if (num4 != 0)
				{
					num3 = 5;
					goto IL_0005;
				}
				goto default;
			default:
				result = false;
				num2 = 11;
				break;
			case 2:
				flag = (bool)obj3;
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_113e95068e254c89a378914a91938c11 != 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				if (j4tkBnXaHCol1KNw2YPZ(text) || HPlMsPXafp4ndvOnUjTg(text.ToLower(), bool.FalseString.ToLower()))
				{
					goto default;
				}
				goto case 5;
			case 14:
			{
				if (flag2)
				{
					result = false;
					goto case 10;
				}
				object obj = obj2;
				obj3 = obj;
				num2 = 8;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_aaee87d70b4c49aab4b237d8e1fb4ee6 != 0)
				{
					num2 = 5;
				}
				break;
			}
			case 1:
				text = obj3 as string;
				if (text != null)
				{
					goto case 9;
				}
				goto case 5;
			case 8:
				if (!(obj3 is bool))
				{
					if (obj3 is int)
					{
						num4 = (int)obj3;
						num2 = 7;
						break;
					}
					goto case 1;
				}
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_839435b576b741b9b9b22142d05dd2f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			case 12:
				if (num < P_0.Length)
				{
					obj2 = P_0[num];
					flag2 = obj2 == null;
					num3 = 14;
					goto IL_0005;
				}
				result = true;
				num2 = 10;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_eb5248e0c761453cb12954b91b9ede6d != 0)
				{
					num2 = 9;
				}
				break;
			case 3:
			case 6:
				if (flag)
				{
					num2 = 13;
					break;
				}
				goto default;
			case 5:
			case 13:
				{
					num++;
					num2 = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5e0114e6421d4bf1bbeb31361714f3af != 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_0005:
				num2 = num3;
				break;
			}
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return null;
	}

	public NullableBoolMultiConverter()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static NullableBoolMultiConverter()
	{
		RCPsn3Xa9keWfKIxYDBw();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool j4tkBnXaHCol1KNw2YPZ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool HPlMsPXafp4ndvOnUjTg(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool Duu8aeXa0Pk6nUm3KT9S()
	{
		return YtTmfgXBzmwP9NndHYLE == null;
	}

	internal static NullableBoolMultiConverter u3cx0HXa2YkXuymSZtG6()
	{
		return YtTmfgXBzmwP9NndHYLE;
	}

	internal static void RCPsn3Xa9keWfKIxYDBw()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}
}
