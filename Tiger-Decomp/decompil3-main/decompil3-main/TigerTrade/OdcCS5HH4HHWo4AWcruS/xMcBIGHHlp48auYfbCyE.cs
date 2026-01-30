using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace OdcCS5HH4HHWo4AWcruS;

public class xMcBIGHHlp48auYfbCyE : Panel
{
	public static readonly DependencyProperty m4cHHLiFDkk;

	public static readonly DependencyProperty GclHHeul6sQ;

	internal static xMcBIGHHlp48auYfbCyE DivqNeDl0qY2KXXiP8W5;

	public int ColumnsCount
	{
		get
		{
			return (int)GetValue(m4cHHLiFDkk);
		}
		set
		{
			SetValue(m4cHHLiFDkk, num);
		}
	}

	public double FixedColumnWidth
	{
		get
		{
			return (double)GetValue(GclHHeul6sQ);
		}
		set
		{
			SetValue(GclHHeul6sQ, num);
		}
	}

	private double dMmHHD5an2G(double P_0)
	{
		if (double.IsNaN(FixedColumnWidth))
		{
			return P_0 / (double)ColumnsCount;
		}
		return FixedColumnWidth;
	}

	private double lfHHHbunMZG()
	{
		int num = 1;
		int num2 = num;
		int num4 = default(int);
		Size desiredSize = default(Size);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 4:
			{
				if (num4 >= base.InternalChildren.Count)
				{
					num2 = 3;
					continue;
				}
				UIElement uIElement = base.InternalChildren[num4];
				desiredSize = uIElement.DesiredSize;
				if (desiredSize.Height > num3)
				{
					desiredSize = uIElement.DesiredSize;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			case 1:
				num3 = 0.0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				num4 = 0;
				goto case 4;
			case 3:
				return num3;
			case 2:
				num3 = desiredSize.Height;
				break;
			}
			num4++;
			num2 = 4;
		}
	}

	[SpecialName]
	private int C0yHHSkWE2V()
	{
		if (base.InternalChildren.Count != 0)
		{
			return (base.InternalChildren.Count - 1) / ColumnsCount + 1;
		}
		return 0;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		int num = 2;
		int num2 = num;
		double num3 = default(double);
		Size availableSize = default(Size);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = dMmHHD5an2G(P_0.Width);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				availableSize = new Size(num3, double.MaxValue);
				num4 = 0;
				goto IL_004a;
			case 3:
				num4++;
				goto IL_004a;
			default:
				{
					object obj = OXZC0ODlf2Lfxf435mMA(base.InternalChildren, num4);
					if (obj == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 3;
						}
						break;
					}
					((UIElement)obj).Measure(availableSize);
					goto case 3;
				}
				IL_004a:
				if (num4 >= base.InternalChildren.Count)
				{
					return new Size(num3 * (double)ColumnsCount, lfHHHbunMZG() * (double)C0yHHSkWE2V());
				}
				goto default;
			}
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double num = lfHHHbunMZG();
		double num2 = dMmHHD5an2G(P_0.Width);
		int num3 = 0;
		while (true)
		{
			int num4;
			if (num3 >= kjwnerDlnNvv3otM9AFL(base.InternalChildren))
			{
				num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
				{
					num4 = 0;
				}
			}
			else
			{
				UIElement uIElement = ((UIElementCollection)o2ccClDl9uEC4t2h5bpV(this))[num3];
				if (uIElement != null)
				{
					uIElement.Arrange(new Rect((double)(num3 % ColumnsCount) * num2, (double)(num3 / ColumnsCount) * num, num2, num));
					goto IL_008b;
				}
				num4 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num4 = 1;
				}
			}
			goto IL_0009;
			IL_008b:
			num3++;
			num4 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
			{
				num4 = 1;
			}
			goto IL_0009;
			IL_0009:
			switch (num4)
			{
			case 2:
				continue;
			case 1:
				goto IL_008b;
			}
			return new Size(P_0.Width, num * (double)C0yHHSkWE2V());
		}
	}

	public xMcBIGHHlp48auYfbCyE()
	{
		i7W2P1DlGG8XfIldPhnv();
		base._002Ector();
	}

	static xMcBIGHHlp48auYfbCyE()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		i7W2P1DlGG8XfIldPhnv();
		m4cHHLiFDkk = (DependencyProperty)Hy9FZeDlBl3YmeThiJiM(qxMxXLDlYv325Al3WSAu(-527080372 ^ -527145136), iJNxy0Dloepxvjxco77n(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777220)), iJNxy0Dloepxvjxco77n(WmV7TgDlvaagWFAhSjgS(33555209)), new PropertyMetadata(2));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		GclHHeul6sQ = (DependencyProperty)Hy9FZeDlBl3YmeThiJiM(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B24683), iJNxy0Dloepxvjxco77n(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), iJNxy0Dloepxvjxco77n(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555209)), new PropertyMetadata(double.NaN));
	}

	internal static bool geCRi0Dl2ajTmhR2iUip()
	{
		return DivqNeDl0qY2KXXiP8W5 == null;
	}

	internal static xMcBIGHHlp48auYfbCyE gk66QrDlHl9GG610FCnt()
	{
		return DivqNeDl0qY2KXXiP8W5;
	}

	internal static object OXZC0ODlf2Lfxf435mMA(object P_0, int P_1)
	{
		return ((UIElementCollection)P_0)[P_1];
	}

	internal static object o2ccClDl9uEC4t2h5bpV(object P_0)
	{
		return ((Panel)P_0).InternalChildren;
	}

	internal static int kjwnerDlnNvv3otM9AFL(object P_0)
	{
		return ((UIElementCollection)P_0).Count;
	}

	internal static void i7W2P1DlGG8XfIldPhnv()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object qxMxXLDlYv325Al3WSAu(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Type iJNxy0Dloepxvjxco77n(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle WmV7TgDlvaagWFAhSjgS(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object Hy9FZeDlBl3YmeThiJiM(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
