using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class HdN
{
	public static readonly Point JGA;

	public static readonly Point FG3;

	public static readonly Point YGy;

	public static readonly Point tGm;

	public static readonly Point xGS;

	internal static HdN wSM;

	public static string hGd(Point? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		double value = P_0.Value.X;
		double value2 = P_0.Value.Y;
		if (P_1 == QdM.AR8(18772) || P_1 == QdM.AR8(2648))
		{
			value = Math.Round(value, 4);
			value2 = Math.Round(value2, 4);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(qdP.SDl(value, P_1));
		stringBuilder.Append(qdP.GDb());
		stringBuilder.Append(qdP.SDl(value2, P_1));
		return stringBuilder.ToString();
	}

	public static IList<IPart> AG9(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		Rp rp = new Rp();
		rp.Format = P_0;
		list.Add(rp);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		Tt tt = new Tt();
		tt.Format = P_0;
		list.Add(tt);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Point CG5(Point P_0, double P_1, Point? P_2, Point? P_3, SpinWrapping P_4, int? P_5)
	{
		Point point = new Point(P_2.HasValue ? P_2.Value.X : double.MinValue, P_0.Y);
		Point point2 = new Point(P_3.HasValue ? P_3.Value.X : double.MaxValue, P_0.Y);
		try
		{
			P_0.X = qdP.wDY(P_0.X, P_1, point.X, point2.X, P_4, P_5);
			P_0 = EGH(P_0, point, point2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? point2 : point);
		}
		return P_0;
	}

	public static Point yGc(Point P_0, double P_1, Point? P_2, Point? P_3, SpinWrapping P_4, int? P_5)
	{
		Point point = new Point(P_0.X, P_2.HasValue ? P_2.Value.Y : double.MinValue);
		Point point2 = new Point(P_0.X, P_3.HasValue ? P_3.Value.Y : double.MaxValue);
		try
		{
			P_0.Y = qdP.wDY(P_0.Y, P_1, point.Y, point2.Y, P_4, P_5);
			P_0 = EGH(P_0, point, point2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? point2 : point);
		}
		return P_0;
	}

	public static Point EGH(Point P_0, Point P_1, Point P_2, int? P_3)
	{
		return new Point(qdP.jDO(P_0.X, P_1.X, P_2.X, P_3), qdP.jDO(P_0.Y, P_1.Y, P_2.Y, P_3));
	}

	public static Point mGL(Point P_0, Point P_1, Point P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new Point(qdP.JDT(P_0.X, P_1.X, P_2.X, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Y, P_1.Y, P_2.Y, P_3, P_4, P_5, P_6));
	}

	public static bool QGF(string P_0, string P_1, out Point? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		string text = qdP.GDb().Trim();
		string pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(28218), new object[1] { text });
		Regex regex = new Regex(pattern, RegexOptions.Singleline);
		Match match = regex.Match(P_0);
		if (match.Success)
		{
			double? num = null;
			double? num2 = null;
			qdP.DDI(match.Groups[1].Value, P_1, out num);
			qdP.DDI(match.Groups[2].Value, P_1, out num2);
			try
			{
				P_2 = new Point(num.HasValue ? num.Value : 0.0, num2.HasValue ? num2.Value : 0.0);
				return true;
			}
			catch (ArgumentException)
			{
			}
		}
		else
		{
			int num3 = P_0.IndexOf(text, StringComparison.OrdinalIgnoreCase);
			if (num3 == -1)
			{
				num3 = P_0.Length;
			}
			else if (!string.IsNullOrEmpty(P_0.Substring(num3 + 1).Trim()))
			{
				num3 = -1;
			}
			if (num3 > 0)
			{
				double? num4 = null;
				qdP.DDI(P_0.Substring(0, num3).Trim(), P_1, out num4);
				if (num4.HasValue)
				{
					try
					{
						P_2 = new Point(num4.Value, num4.Value);
						return true;
					}
					catch (ArgumentException)
					{
					}
				}
			}
		}
		return false;
	}

	static HdN()
	{
		awj.QuEwGz();
		JGA = new Point(5.0, 5.0);
		FG3 = new Point(0.0, 0.0);
		YGy = new Point(100000.0, 100000.0);
		tGm = new Point(-100000.0, -100000.0);
		xGS = new Point(1.0, 1.0);
	}

	internal static bool EST()
	{
		return wSM == null;
	}

	internal static HdN MSk()
	{
		return wSM;
	}
}
