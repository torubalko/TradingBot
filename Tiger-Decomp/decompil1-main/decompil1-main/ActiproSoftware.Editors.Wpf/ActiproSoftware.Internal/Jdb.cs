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

internal static class Jdb
{
	public static readonly Vector iux;

	public static readonly Vector Bu0;

	public static readonly Vector xuY;

	public static readonly Vector pug;

	public static readonly Vector Duo;

	internal static Jdb dAt;

	public static string Tuj(Vector? P_0, string P_1)
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

	public static IList<IPart> WuP(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		nd3 nd9 = new nd3();
		nd9.Format = P_0;
		list.Add(nd9);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		EdL edL = new EdL();
		edL.Format = P_0;
		list.Add(edL);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Vector Mu2(Vector P_0, double P_1, Vector? P_2, Vector? P_3, SpinWrapping P_4, int? P_5)
	{
		Vector vector = new Vector(P_2.HasValue ? P_2.Value.X : double.MinValue, P_0.Y);
		Vector vector2 = new Vector(P_3.HasValue ? P_3.Value.X : double.MaxValue, P_0.Y);
		try
		{
			P_0.X = qdP.wDY(P_0.X, P_1, vector.X, vector2.X, P_4, P_5);
			P_0 = Euf(P_0, vector, vector2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? vector2 : vector);
		}
		return P_0;
	}

	public static Vector Yua(Vector P_0, double P_1, Vector? P_2, Vector? P_3, SpinWrapping P_4, int? P_5)
	{
		Vector vector = new Vector(P_0.X, P_2.HasValue ? P_2.Value.Y : double.MinValue);
		Vector vector2 = new Vector(P_0.X, P_3.HasValue ? P_3.Value.Y : double.MaxValue);
		try
		{
			P_0.Y = qdP.wDY(P_0.Y, P_1, vector.Y, vector2.Y, P_4, P_5);
			P_0 = Euf(P_0, vector, vector2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? vector2 : vector);
		}
		return P_0;
	}

	public static Vector Euf(Vector P_0, Vector P_1, Vector P_2, int? P_3)
	{
		return new Vector(qdP.jDO(P_0.X, P_1.X, P_2.X, P_3), qdP.jDO(P_0.Y, P_1.Y, P_2.Y, P_3));
	}

	public static Vector Xul(Vector P_0, Vector P_1, Vector P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new Vector(qdP.JDT(P_0.X, P_1.X, P_2.X, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Y, P_1.Y, P_2.Y, P_3, P_4, P_5, P_6));
	}

	public static bool luX(string P_0, string P_1, out Vector? P_2)
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
			P_2 = new Vector(num.HasValue ? num.Value : 0.0, num2.HasValue ? num2.Value : 0.0);
			return true;
		}
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
				P_2 = new Vector(num4.Value, num4.Value);
				return true;
			}
		}
		return false;
	}

	static Jdb()
	{
		awj.QuEwGz();
		iux = new Vector(5.0, 5.0);
		Bu0 = new Vector(0.0, 0.0);
		xuY = new Vector(100000.0, 100000.0);
		pug = new Vector(-100000.0, -100000.0);
		Duo = new Vector(1.0, 1.0);
	}

	internal static bool dAe()
	{
		return dAt == null;
	}

	internal static Jdb CAO()
	{
		return dAt;
	}
}
