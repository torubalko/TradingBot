using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace deZWP8i7qq2A3lcy58by;

public class n70vAvi7ONDeJjpo4yfQ : ButtonBase
{
	public static readonly DependencyProperty dL9i7KRLqvN;

	public static readonly DependencyProperty Q32i7mgVENh;

	public static readonly DependencyProperty UHHi7hFXbTK;

	public static readonly DependencyProperty C3Ti7wWS2O0;

	internal static n70vAvi7ONDeJjpo4yfQ bkwuYaXnkV7QIjvXyiP4;

	public string Hint
	{
		get
		{
			return (string)GetValue(dL9i7KRLqvN);
		}
		set
		{
			SetValue(dL9i7KRLqvN, value2);
		}
	}

	public bool IsHintShowed
	{
		get
		{
			return (bool)GetValue(Q32i7mgVENh);
		}
		set
		{
			SetValue(Q32i7mgVENh, flag);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(UHHi7hFXbTK);
		}
		set
		{
			wwIEJcXnx1moavLZDC9D(this, UHHi7hFXbTK, flag);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(C3Ti7wWS2O0);
		}
		set
		{
			SetValue(C3Ti7wWS2O0, flag);
		}
	}

	public n70vAvi7ONDeJjpo4yfQ()
	{
		Kh6NOeXnS7SK8Pm8pCF0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.DefaultStyleKey = Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554446));
			base.MouseEnter += Sp8i7INodJ6;
			base.MouseLeave += atki7WDvdIL;
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_113e95068e254c89a378914a91938c11 != 0)
			{
				num = 1;
			}
		}
	}

	private void Sp8i7INodJ6(object P_0, MouseEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				IsHintShowed = true;
				return;
			case 2:
				flag = lkuKIEXnLWZpxHAixh69(Hint);
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_80afc7eb1a6e4a8ea5ca9a872ecf5362 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (flag)
				{
					return;
				}
				goto default;
			}
		}
	}

	private void atki7WDvdIL(object P_0, MouseEventArgs P_1)
	{
		IsHintShowed = false;
	}

	static n70vAvi7ONDeJjpo4yfQ()
	{
		SrwdBFXneqJqRo6lUS5J();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b4b4871b155545a9b8d73b1a4ed5e230 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				UHHi7hFXbTK = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x6F7F734B ^ 0x6F7F72FF), Type.GetTypeFromHandle(Gt3osNXnXppC0OpfHn8v(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554446)));
				C3Ti7wWS2O0 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0xC1DDB3B ^ 0xC1DDAF7), sfOGj1XncHXpVdQR3n49(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554446)));
				num = 2;
				break;
			case 1:
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				dL9i7KRLqvN = DependencyProperty.Register((string)nVXS0WXnskOx3MQuGZSL(-225822163 ^ -225821791), Type.GetTypeFromHandle(Gt3osNXnXppC0OpfHn8v(16777225)), sfOGj1XncHXpVdQR3n49(Gt3osNXnXppC0OpfHn8v(33554446)));
				Q32i7mgVENh = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1009517961 ^ -1009517585), Type.GetTypeFromHandle(Gt3osNXnXppC0OpfHn8v(16777220)), sfOGj1XncHXpVdQR3n49(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554446)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_26b3e8355b0647d7acbfe1c7692947fd != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void Kh6NOeXnS7SK8Pm8pCF0()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static bool YgEZeLXn11wS3BE5ux2g()
	{
		return bkwuYaXnkV7QIjvXyiP4 == null;
	}

	internal static n70vAvi7ONDeJjpo4yfQ adse02Xn53j8UQrXmIgk()
	{
		return bkwuYaXnkV7QIjvXyiP4;
	}

	internal static void wwIEJcXnx1moavLZDC9D(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static bool lkuKIEXnLWZpxHAixh69(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void SrwdBFXneqJqRo6lUS5J()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static object nVXS0WXnskOx3MQuGZSL(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static RuntimeTypeHandle Gt3osNXnXppC0OpfHn8v(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type sfOGj1XncHXpVdQR3n49(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
