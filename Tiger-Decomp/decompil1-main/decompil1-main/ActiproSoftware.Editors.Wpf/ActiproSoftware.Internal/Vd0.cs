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

internal static class Vd0
{
	public static readonly Int32Rect HGP;

	public static readonly Int32Rect gG2;

	public static readonly Int32Rect uGa;

	public static readonly Int32Rect gGf;

	public static readonly Int32Rect qGl;

	internal static Vd0 TS4;

	public static string eDz(Int32Rect? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		int x = P_0.Value.X;
		int y10 = P_0.Value.Y;
		int width = P_0.Value.Width;
		int height = P_0.Value.Height;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(cdY.JDe(x, P_1));
		stringBuilder.Append(cdY.zDN());
		stringBuilder.Append(cdY.JDe(y10, P_1));
		stringBuilder.Append(cdY.zDN());
		stringBuilder.Append(cdY.JDe(width, P_1));
		stringBuilder.Append(cdY.zDN());
		stringBuilder.Append(cdY.JDe(height, P_1));
		return stringBuilder.ToString();
	}

	public static IList<IPart> gGQ(string P_0, CultureInfo P_1)
	{
		P_0 = cdY.MDE(P_0, P_1);
		List<IPart> list = new List<IPart>();
		R5 r = new R5();
		r.Format = P_0;
		list.Add(r);
		ME mE = new ME();
		mE.Text = cdY.zDN();
		list.Add(mE);
		FR fR = new FR();
		fR.Format = P_0;
		list.Add(fR);
		mE = new ME();
		mE.Text = cdY.zDN();
		list.Add(mE);
		Sr sr = new Sr();
		sr.Format = P_0;
		list.Add(sr);
		mE = new ME();
		mE.Text = cdY.zDN();
		list.Add(mE);
		S7 s = new S7();
		s.Format = P_0;
		list.Add(s);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Int32Rect PGV(Int32Rect P_0, int P_1, Int32Rect? P_2, Int32Rect? P_3, SpinWrapping P_4)
	{
		Int32Rect int32Rect = new Int32Rect(P_0.X, P_0.Y, P_0.Width, P_2.HasValue ? P_2.Value.Height : 0);
		Int32Rect int32Rect2 = new Int32Rect(P_0.X, P_0.Y, P_0.Width, P_3.HasValue ? P_3.Value.Height : int.MaxValue);
		try
		{
			P_0.Height = Math.Max(0, cdY.YD7(P_0.Height, P_1, int32Rect.Height, int32Rect2.Height, P_4));
			P_0 = LGs(P_0, int32Rect, int32Rect2);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0) ? int32Rect2 : int32Rect);
		}
		return P_0;
	}

	public static Int32Rect aGC(Int32Rect P_0, int P_1, Int32Rect? P_2, Int32Rect? P_3, SpinWrapping P_4)
	{
		Int32Rect int32Rect = new Int32Rect(P_0.X, P_0.Y, P_2.HasValue ? P_2.Value.Width : 0, P_0.Height);
		Int32Rect int32Rect2 = new Int32Rect(P_0.X, P_0.Y, P_3.HasValue ? P_3.Value.Width : int.MaxValue, P_0.Height);
		try
		{
			P_0.Width = Math.Max(0, cdY.YD7(P_0.Width, P_1, int32Rect.Width, int32Rect2.Width, P_4));
			P_0 = LGs(P_0, int32Rect, int32Rect2);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0) ? int32Rect2 : int32Rect);
		}
		return P_0;
	}

	public static Int32Rect jG6(Int32Rect P_0, int P_1, Int32Rect? P_2, Int32Rect? P_3, SpinWrapping P_4)
	{
		Int32Rect int32Rect = new Int32Rect(P_2.HasValue ? P_2.Value.X : int.MinValue, P_0.Y, P_0.Width, P_0.Height);
		Int32Rect int32Rect2 = new Int32Rect(P_3.HasValue ? P_3.Value.X : int.MaxValue, P_0.Y, P_0.Width, P_0.Height);
		try
		{
			P_0.X = cdY.YD7(P_0.X, P_1, int32Rect.X, int32Rect2.X, P_4);
			P_0 = LGs(P_0, int32Rect, int32Rect2);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0) ? int32Rect2 : int32Rect);
		}
		return P_0;
	}

	public static Int32Rect bGM(Int32Rect P_0, int P_1, Int32Rect? P_2, Int32Rect? P_3, SpinWrapping P_4)
	{
		Int32Rect int32Rect = new Int32Rect(P_0.X, P_2.HasValue ? P_2.Value.Y : int.MinValue, P_0.Width, P_0.Height);
		Int32Rect int32Rect2 = new Int32Rect(P_0.X, P_3.HasValue ? P_3.Value.Y : int.MaxValue, P_0.Width, P_0.Height);
		try
		{
			P_0.Y = cdY.YD7(P_0.Y, P_1, int32Rect.Y, int32Rect2.Y, P_4);
			P_0 = LGs(P_0, int32Rect, int32Rect2);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0) ? int32Rect2 : int32Rect);
		}
		return P_0;
	}

	public static Int32Rect LGs(Int32Rect P_0, Int32Rect P_1, Int32Rect P_2)
	{
		return new Int32Rect(cdY.fD4(P_1.X, cdY.eDB(P_0.X, P_2.X)), cdY.fD4(P_1.Y, cdY.eDB(P_0.Y, P_2.Y)), cdY.fD4(P_1.Width, cdY.eDB(P_0.Width, P_2.Width)), cdY.fD4(P_1.Height, cdY.eDB(P_0.Height, P_2.Height)));
	}

	public static bool iGj(string P_0, string P_1, out Int32Rect? P_2)
	{
		P_2 = null;
		string text;
		string pattern;
		int num;
		if (!string.IsNullOrEmpty(P_0))
		{
			text = cdY.zDN().Trim();
			pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(26576), new object[1] { text });
			num = 0;
			if (!ES0())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		return true;
		IL_0009:
		Match match = default(Match);
		bool success = default(bool);
		int? num3 = default(int?);
		int? num4 = default(int?);
		int? num5 = default(int?);
		int num7 = default(int);
		while (true)
		{
			int? num6;
			int? num2;
			switch (num)
			{
			case 2:
			{
				int? num8 = null;
				cdY.cDw(match.Groups[1].Value, P_1, out num6);
				cdY.cDw(match.Groups[2].Value, P_1, out num8);
				P_2 = new Int32Rect(0, 0, num6.HasValue ? num6.Value : 0, num8.HasValue ? num8.Value : 0);
				return true;
			}
			case 3:
				if (success)
				{
					num3 = null;
					num4 = null;
					num5 = null;
					num2 = null;
					cdY.cDw(match.Groups[1].Value, P_1, out num3);
					cdY.cDw(match.Groups[2].Value, P_1, out num4);
					cdY.cDw(match.Groups[3].Value, P_1, out num5);
					num = 1;
					if (ES0())
					{
						continue;
					}
				}
				else
				{
					pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(28218), new object[1] { text });
					Regex regex = new Regex(pattern, RegexOptions.Singleline);
					match = regex.Match(P_0);
					if (!match.Success)
					{
						return false;
					}
					num6 = null;
					num7 = 2;
				}
				break;
			case 1:
				cdY.cDw(match.Groups[4].Value, P_1, out num2);
				P_2 = new Int32Rect(num3.HasValue ? num3.Value : 0, num4.HasValue ? num4.Value : 0, num5.HasValue ? num5.Value : 0, num2.HasValue ? num2.Value : 0);
				return true;
			default:
			{
				Regex regex = new Regex(pattern, RegexOptions.Singleline);
				match = regex.Match(P_0);
				success = match.Success;
				num = 3;
				if (CS7() == null)
				{
					continue;
				}
				break;
			}
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		num = num7;
		goto IL_0009;
	}

	static Vd0()
	{
		awj.QuEwGz();
		HGP = new Int32Rect(5, 5, 5, 5);
		gG2 = new Int32Rect(0, 0, 0, 0);
		uGa = new Int32Rect(100000, 100000, 100000, 100000);
		gGf = new Int32Rect(-100000, -100000, 0, 0);
		qGl = new Int32Rect(1, 1, 1, 1);
	}

	internal static bool ES0()
	{
		return TS4 == null;
	}

	internal static Vd0 CS7()
	{
		return TS4;
	}
}
