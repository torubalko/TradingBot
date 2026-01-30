using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using A6axDDGGKi8DOb3rxDca;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using TigerTrade.Dx.Enums;
using VbYeMsGfGBlbxImmfCXc;
using wNtF4vGfbEasqaPYrQyw;

namespace TigerTrade.Dx;

public sealed class DxVisualQueue
{
	[Serializable]
	[CompilerGenerated]
	private sealed class AFR3VjGBLLi0ZshcG9Sw
	{
		public static readonly AFR3VjGBLLi0ZshcG9Sw t8EGBsMDasP;

		public static Func<ie4WSIGGrGgj3Eas0lVN> RXjGBXrQh2M;

		internal static AFR3VjGBLLi0ZshcG9Sw qcZfMMkdSkLxN9KbNWLO;

		static AFR3VjGBLLi0ZshcG9Sw()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
					qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
					t8EGBsMDasP = new AFR3VjGBLLi0ZshcG9Sw();
					return;
				}
			}
		}

		public AFR3VjGBLLi0ZshcG9Sw()
		{
			jDgFoQkdeN4dQ67I5mW1();
			base._002Ector();
		}

		internal ie4WSIGGrGgj3Eas0lVN ErBGBewCVaw()
		{
			return new ie4WSIGGrGgj3Eas0lVN();
		}

		internal static bool t8piRAkdxuLMJHR3PlJJ()
		{
			return qcZfMMkdSkLxN9KbNWLO == null;
		}

		internal static AFR3VjGBLLi0ZshcG9Sw JBSHnZkdLJcwpohrCd0O()
		{
			return qcZfMMkdSkLxN9KbNWLO;
		}

		internal static void jDgFoQkdeN4dQ67I5mW1()
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		}
	}

	private readonly bKnGOlGfnm63RpB8BYr7<ie4WSIGGrGgj3Eas0lVN> dxPool;

	private static DxVisualQueue y8rHd1kjCAWxf2D32wM5;

	internal List<ie4WSIGGrGgj3Eas0lVN> Commands { get; }

	internal Rect ClientRect { get; set; }

	internal Rect PrevRect { get; set; }

	public bool Empty { get; set; }

	public DxVisualQueue()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		dxPool = new bKnGOlGfnm63RpB8BYr7<ie4WSIGGrGgj3Eas0lVN>(new u8p40XGfDDId7WOEjXgy<ie4WSIGGrGgj3Eas0lVN>(() => new ie4WSIGGrGgj3Eas0lVN()), 16384);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_3eb68d8d5ff548b8b5f6ee0645c6cc4e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Commands = new List<ie4WSIGGrGgj3Eas0lVN>();
	}

	public void Set(Rect rect)
	{
		Empty = false;
		ClientRect = rect;
		PrevRect = default(Rect);
		Commands.Clear();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dfe9f5da877a401b848251d2d558dcec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Complete()
	{
		Empty = false;
		ClientRect = default(Rect);
		PrevRect = default(Rect);
		foreach (ie4WSIGGrGgj3Eas0lVN command in Commands)
		{
			command.aakGYHFZWcx(dxPool);
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_625649b49e194040b4ce727cb6f9ee27 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		while (true)
		{
			Commands.Clear();
			int num2 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2e8ef27ff10e46d5944c0ff54cb39537 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
		}
	}

	public void Clear(XColor color)
	{
		Commands.Add(ie4WSIGGrGgj3Eas0lVN.Clear(dxPool, color));
	}

	public void SetClip(Rect rect)
	{
		Commands.Add(ie4WSIGGrGgj3Eas0lVN.i94GGmYGKND(dxPool, rect));
	}

	public void ResetClip()
	{
		Commands.Add(ie4WSIGGrGgj3Eas0lVN.cU6GGhvsQ7Y(dxPool));
	}

	public void DrawLine(XPen pen, Point p1, Point p2)
	{
		if (pen != null && pen.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.o7vGGwufnpM(dxPool, rNqigKkjhONTsZK5YBfF(DpsT1xkjmEb1AFZvmgcQ(pen)), p1, p2, pen.Values));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_1ecf08483ad04bb2aa32d881f01b6bdc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void DrawLine(XPen pen, double x1, double y1, double x2, double y2)
	{
		DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
	}

	public void DrawLines(XPen pen, Point[] points)
	{
		if (pen == null)
		{
			return;
		}
		if (!pen.IsValid)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9e61d8add8d44babb7ee69056242227b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.fqXGGp1qGAF(dxPool, points, pen.Brush.Color, _0020: false, pen.Width, J1cUEukjwA67YKObcVfI(pen), _0020: false));
		}
	}

	public void DrawLines(XPen pen, Point[] points, int pointsLength)
	{
		if (pen != null && pen.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.NelGGuV1Upx(dxPool, points, pointsLength, ((XBrush)DpsT1xkjmEb1AFZvmgcQ(pen)).Color, _0020: false, pen.Width, pen.Style, _0020: false));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_6edfa0dadf694d2ca40748e5143727d5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void DrawSmoothLines(XPen pen, Point[] points)
	{
		if (pen == null)
		{
			return;
		}
		if (!pen.IsValid)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_d8dfc4bf987547c385760d806fa39030 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.fqXGGp1qGAF(dxPool, points, rNqigKkjhONTsZK5YBfF(pen.Brush), _0020: false, pen.Width, pen.Style, _0020: true));
		}
	}

	public void DrawRectangle(XPen pen, Rect rect)
	{
		if (pen != null && pen.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.Gq9GG7qxkWd(dxPool, rNqigKkjhONTsZK5YBfF(DpsT1xkjmEb1AFZvmgcQ(pen)), rect, WLN9fNkj7Qfs3P4GGFWP(pen), pen.Style));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void FillRectangle(XBrush brush, Rect rect)
	{
		if (brush != null && brush.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.WrPGG87NYij(dxPool, brush.Color, rect));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_c2e150130d354ba88208e31c0cb582bd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void DrawRectangles(XPen pen, Rect[] rects)
	{
		int num = 0;
		while (true)
		{
			int num2;
			if (num >= rects.Length)
			{
				num2 = 2;
			}
			else
			{
				Rect rect = rects[num];
				DrawRectangle(pen, rect);
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_625649b49e194040b4ce727cb6f9ee27 == 0)
				{
					num2 = 0;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					num++;
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_6d5d3c8cbc2d408ab6adb1ecc4804915 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
		}
	}

	public void FillRectangles(XBrush brush, Rect[] rects)
	{
		int num = 0;
		Rect rect = default(Rect);
		while (true)
		{
			int num2;
			if (num >= rects.Length)
			{
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_37442e8fbe0a4d0b81152928e1eb527c == 0)
				{
					num2 = 2;
				}
			}
			else
			{
				rect = rects[num];
				num2 = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_10b7977984684a30b2d10583321d7520 == 0)
				{
					num2 = 1;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					FillRectangle(brush, rect);
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dd9d08d16b46492585868817bd5b329f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			num++;
		}
	}

	public void FillGradientRectangle(XBrush brush, XBrush brush2, int dir, Rect rect)
	{
		if (brush == null || !brush.IsValid || brush2 == null)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_6ca4a8d08a994194b4c56703451ca043 != 0)
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
			if (!brush2.IsValid)
			{
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_23c0df2b361f4cd8810a5300adca24b7 != 0)
				{
					num = 1;
				}
				continue;
			}
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.ybtGGAecFui(dxPool, rNqigKkjhONTsZK5YBfF(brush), brush2.Color, dir, rect));
			return;
		}
	}

	public void DrawRoundedRectangle(XPen pen, Rect rect, Point radius)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (pen.IsValid)
				{
					Commands.Add(ie4WSIGGrGgj3Eas0lVN.z8hGGPRTHc8(dxPool, pen.Brush.Color, rect, radius, pen.Width, pen.Style));
				}
				return;
			case 1:
				if (pen == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_50d7f2900625405b9ea932152c20c879 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void FillRoundedRectangle(XBrush brush, Rect rect, Point radius)
	{
		if (brush != null && brush.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.pJoGGJOZ1Lj(dxPool, brush.Color, rect, radius));
		}
	}

	public void DrawPolygon(XPen pen, Point[] points)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (pen != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f1601605e25a48e58f87674317e812a9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				if (pen.IsValid)
				{
					Commands.Add(ie4WSIGGrGgj3Eas0lVN.fqXGGp1qGAF(dxPool, points, ((XBrush)DpsT1xkjmEb1AFZvmgcQ(pen)).Color, _0020: true, pen.Width, pen.Style, _0020: false));
				}
				return;
			}
		}
	}

	public void FillPolygon(XBrush brush, Point[] points)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (brush != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_4244154882d84aceb472cc9692dc853e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				if (brush.IsValid)
				{
					Commands.Add(ie4WSIGGrGgj3Eas0lVN.NDIGGzhfOP9(dxPool, points, brush.Color, _0020: true));
				}
				return;
			}
		}
	}

	public void DrawArc(XPen pen, Point p1, Point p2, double radius, double angle)
	{
		if (pen != null && pen.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.k4SGY0VrJmK(dxPool, rNqigKkjhONTsZK5YBfF(pen.Brush), p1, p2, radius, angle, pen.Width, pen.Style));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_50d7f2900625405b9ea932152c20c879 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void DrawEllipse(XPen pen, Point center, double radiusX, double radiusY)
	{
		if (pen != null && pen.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.psvGGFVN02U(dxPool, pen.Brush.Color, center, radiusX, radiusY, WLN9fNkj7Qfs3P4GGFWP(pen), pen.Style));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ddce9f0563524ee592adad7a07e5ceaf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void FillEllipse(XBrush brush, Point center, double radiusX, double radiusY)
	{
		if (brush != null && brush.IsValid)
		{
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.n8JGG3YUkTN(dxPool, rNqigKkjhONTsZK5YBfF(brush), center, radiusX, radiusY));
		}
	}

	public void DrawString(string text, XFont font, XBrush brush, Rect rect, XTextAlignment alignment = XTextAlignment.Left)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (font == null || brush == null || !brush.IsValid)
				{
					return;
				}
				Commands.Add(ie4WSIGGrGgj3Eas0lVN.ioQGY2NBCr2(dxPool, text, font, brush.Color, rect, alignment));
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				if (string.IsNullOrEmpty(text))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ded015a90dce459db73af52f540d8af2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void DrawString(string text, XFont font, XBrush brush, double x, double y, XTextAlignment alignment = XTextAlignment.Left)
	{
		if (string.IsNullOrEmpty(text) || font == null)
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f1601605e25a48e58f87674317e812a9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				break;
			case 1:
				if (brush == null)
				{
					return;
				}
				break;
			case 0:
				return;
			}
			if (!brush.IsValid)
			{
				break;
			}
			Size size = a5UwPEkj81xbKK7Ta3nY(font, text);
			Rect rect = new Rect(x, y, size.Width, size.Height);
			Commands.Add(ie4WSIGGrGgj3Eas0lVN.ioQGY2NBCr2(dxPool, text, font, brush.Color, rect, alignment));
			num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3c56040434a4a628f0f01cc04d0408d == 0)
			{
				num = 0;
			}
		}
	}

	public void DrawStrings(string text, XFont font, XBrush brush, Rect rect, XTextAlignment alignment = XTextAlignment.Left)
	{
		double num = p8OXnEkjA25OT7BmBcc9(font);
		double num2 = (rect.Bottom - rect.Top) / 2.0;
		int num3 = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_e3a78f5673ba492cb3624f6fd9b0982f == 0)
		{
			num3 = 0;
		}
		switch (num3)
		{
		}
		Rect rect2 = new Rect(rect.Left, rect.Top + num2 - num / 2.0, rect.Width, num);
		DrawString(text, font, brush, rect2, alignment);
	}

	static DxVisualQueue()
	{
		UOqm01kjP0dg12hMPymJ();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WQNxyxkjrtqWdUDDaOEw()
	{
		return y8rHd1kjCAWxf2D32wM5 == null;
	}

	internal static DxVisualQueue UjIyAfkjKdpc5rvENceH()
	{
		return y8rHd1kjCAWxf2D32wM5;
	}

	internal static object DpsT1xkjmEb1AFZvmgcQ(object P_0)
	{
		return ((XPen)P_0).Brush;
	}

	internal static XColor rNqigKkjhONTsZK5YBfF(object P_0)
	{
		return ((XBrush)P_0).Color;
	}

	internal static XDashStyle J1cUEukjwA67YKObcVfI(object P_0)
	{
		return ((XPen)P_0).Style;
	}

	internal static int WLN9fNkj7Qfs3P4GGFWP(object P_0)
	{
		return ((XPen)P_0).Width;
	}

	internal static Size a5UwPEkj81xbKK7Ta3nY(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static double p8OXnEkjA25OT7BmBcc9(object P_0)
	{
		return ((XFont)P_0).GetHeight();
	}

	internal static void UOqm01kjP0dg12hMPymJ()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}
}
