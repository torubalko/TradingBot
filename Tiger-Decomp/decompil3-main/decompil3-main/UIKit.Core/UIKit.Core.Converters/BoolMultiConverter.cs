using System;
using System.Globalization;
using System.Windows.Data;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core.Converters;

public class BoolMultiConverter : IMultiValueConverter
{
	internal static BoolMultiConverter ndg0cBXBCmdHFgXZu9IR;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 0;
		object obj = default(object);
		object result = default(object);
		object obj3 = default(object);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			if (num < P_0.Length)
			{
				obj = P_0[num];
				num2 = 2;
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2aca65174e2e4ee8910c4728495ecb10 == 0)
				{
					num2 = 0;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 12:
				{
					result = false;
					int num3 = 11;
					num2 = num3;
					continue;
				}
				case 3:
				case 4:
				case 7:
				case 8:
				case 9:
					num++;
					num2 = 10;
					continue;
				default:
					result = true;
					goto case 11;
				case 6:
					if ((int)obj3 == 0)
					{
						goto case 12;
					}
					goto case 3;
				case 5:
					if (flag)
					{
						num2 = 2;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b27b24728ab74165bf1db9dac9d36fc6 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 12;
				case 11:
					return result;
				case 1:
					if (obj3 is string text)
					{
						if (!((string)iFsbfNXBmrZgHhx3JllS(text) == bool.FalseString.ToLower()))
						{
							num2 = 1;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 12;
					}
					goto case 3;
				case 10:
					break;
				case 2:
				{
					object obj2 = obj;
					obj3 = obj2;
					if (obj3 is bool)
					{
						flag = (bool)obj3;
						goto case 5;
					}
					if (!(obj3 is int))
					{
						num2 = 1;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_bdc18810d6a64e4595bd8812b2a35dea == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				}
				}
				break;
			}
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return null;
	}

	public BoolMultiConverter()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static BoolMultiConverter()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object iFsbfNXBmrZgHhx3JllS(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool Ls8U8BXBrSKXUbqfr2Jb()
	{
		return ndg0cBXBCmdHFgXZu9IR == null;
	}

	internal static BoolMultiConverter aMYUZmXBKIOh9QeC3uVM()
	{
		return ndg0cBXBCmdHFgXZu9IR;
	}
}
