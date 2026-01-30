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

internal static class kdo
{
	public static readonly Rect nGn;

	public static readonly Rect nGJ;

	public static readonly Rect wGe;

	public static readonly Rect bGk;

	public static readonly Rect jGE;

	internal static kdo JSf;

	public static string QG1(Rect? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		double value = P_0.Value.X;
		double value2 = P_0.Value.Y;
		double value3 = P_0.Value.Width;
		double value4 = P_0.Value.Height;
		if (P_1 == QdM.AR8(18772) || P_1 == QdM.AR8(2648))
		{
			value = Math.Round(value, 4);
			value2 = Math.Round(value2, 4);
			value3 = Math.Round(value3, 4);
			value4 = Math.Round(value4, 4);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(qdP.SDl(value, P_1));
		stringBuilder.Append(qdP.GDb());
		stringBuilder.Append(qdP.SDl(value2, P_1));
		stringBuilder.Append(qdP.GDb());
		stringBuilder.Append(qdP.SDl(value3, P_1));
		stringBuilder.Append(qdP.GDb());
		stringBuilder.Append(qdP.SDl(value4, P_1));
		return stringBuilder.ToString();
	}

	public static IList<IPart> PG8(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		pJ pJ2 = new pJ();
		pJ2.Format = P_0;
		list.Add(pJ2);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		pz pz2 = new pz();
		pz2.Format = P_0;
		list.Add(pz2);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		kl kl2 = new kl();
		kl2.Format = P_0;
		list.Add(kl2);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		gn gn2 = new gn();
		gn2.Format = P_0;
		list.Add(gn2);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Rect yGr(Rect P_0, double P_1, Rect? P_2, Rect? P_3, SpinWrapping P_4, int? P_5)
	{
		Rect rect = new Rect(P_0.X, P_0.Y, P_0.Width, P_2.HasValue ? P_2.Value.Height : 0.0);
		Rect rect2 = new Rect(P_0.X, P_0.Y, P_0.Width, P_3.HasValue ? P_3.Value.Height : double.MaxValue);
		try
		{
			P_0.Height = Math.Max(0.0, qdP.wDY(P_0.Height, P_1, rect.Height, rect2.Height, P_4, P_5));
			P_0 = yGi(P_0, rect, rect2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? rect2 : rect);
		}
		return P_0;
	}

	public static Rect aGv(Rect P_0, double P_1, Rect? P_2, Rect? P_3, SpinWrapping P_4, int? P_5)
	{
		Rect rect = new Rect(P_0.X, P_0.Y, P_2.HasValue ? P_2.Value.Width : 0.0, P_0.Height);
		Rect rect2 = new Rect(P_0.X, P_0.Y, P_3.HasValue ? P_3.Value.Width : double.MaxValue, P_0.Height);
		try
		{
			P_0.Width = Math.Max(0.0, qdP.wDY(P_0.Width, P_1, rect.Width, rect2.Width, P_4, P_5));
			P_0 = yGi(P_0, rect, rect2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? rect2 : rect);
		}
		return P_0;
	}

	public static Rect AGp(Rect P_0, double P_1, Rect? P_2, Rect? P_3, SpinWrapping P_4, int? P_5)
	{
		Rect rect = new Rect(P_2.HasValue ? P_2.Value.X : double.MinValue, P_0.Y, P_0.Width, P_0.Height);
		Rect rect2 = new Rect(P_3.HasValue ? P_3.Value.X : double.MaxValue, P_0.Y, P_0.Width, P_0.Height);
		try
		{
			P_0.X = qdP.wDY(P_0.X, P_1, rect.X, rect2.X, P_4, P_5);
			P_0 = yGi(P_0, rect, rect2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? rect2 : rect);
		}
		return P_0;
	}

	public static Rect RGW(Rect P_0, double P_1, Rect? P_2, Rect? P_3, SpinWrapping P_4, int? P_5)
	{
		Rect rect = new Rect(P_0.X, P_2.HasValue ? P_2.Value.Y : double.MinValue, P_0.Width, P_0.Height);
		Rect rect2 = new Rect(P_0.X, P_3.HasValue ? P_3.Value.Y : double.MaxValue, P_0.Width, P_0.Height);
		try
		{
			P_0.Y = qdP.wDY(P_0.Y, P_1, rect.Y, rect2.Y, P_4, P_5);
			P_0 = yGi(P_0, rect, rect2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? rect2 : rect);
		}
		return P_0;
	}

	public static Rect yGi(Rect P_0, Rect P_1, Rect P_2, int? P_3)
	{
		return new Rect(qdP.jDO(P_0.X, P_1.X, P_2.X, P_3), qdP.jDO(P_0.Y, P_1.Y, P_2.Y, P_3), qdP.jDO(P_0.Width, P_1.Width, P_2.Width, P_3), qdP.jDO(P_0.Height, P_1.Height, P_2.Height, P_3));
	}

	public static Rect XGZ(Rect P_0, Rect P_1, Rect P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new Rect(qdP.JDT(P_0.X, P_1.X, P_2.X, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Y, P_1.Y, P_2.Y, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Width, P_1.Width, P_2.Width, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Height, P_1.Height, P_2.Height, P_3, P_4, P_5, P_6));
	}

	public static bool xGt(string P_0, string P_1, out Rect? P_2)
	{
		int num = 3;
		Match match = default(Match);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double? num6;
				double? num3;
				double? num4;
				double? num5;
				switch (num2)
				{
				default:
					num6 = null;
					num2 = 1;
					if (fSN())
					{
						continue;
					}
					break;
				case 2:
				{
					if (string.IsNullOrEmpty(P_0))
					{
						return true;
					}
					string text = qdP.GDb().Trim();
					string pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(26576), new object[1] { text });
					Regex regex = new Regex(pattern, RegexOptions.Singleline);
					match = regex.Match(P_0);
					if (!match.Success)
					{
						pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(28218), new object[1] { text });
						regex = new Regex(pattern, RegexOptions.Singleline);
						match = regex.Match(P_0);
						if (match.Success)
						{
							double? num7 = null;
							double? num8 = null;
							qdP.DDI(match.Groups[1].Value, P_1, out num7);
							qdP.DDI(match.Groups[2].Value, P_1, out num8);
							try
							{
								P_2 = new Rect(0.0, 0.0, num7.HasValue ? num7.Value : 0.0, num8.HasValue ? num8.Value : 0.0);
								return true;
							}
							catch (ArgumentException)
							{
							}
						}
						goto IL_01dc;
					}
					num3 = null;
					num4 = null;
					num5 = null;
					num2 = 0;
					if (fSN())
					{
						continue;
					}
					break;
				}
				case 3:
					P_2 = null;
					num2 = 2;
					continue;
				case 1:
					{
						qdP.DDI(match.Groups[1].Value, P_1, out num3);
						qdP.DDI(match.Groups[2].Value, P_1, out num4);
						qdP.DDI(match.Groups[3].Value, P_1, out num5);
						qdP.DDI(match.Groups[4].Value, P_1, out num6);
						try
						{
							P_2 = new Rect(num3.HasValue ? num3.Value : 0.0, num4.HasValue ? num4.Value : 0.0, num5.HasValue ? num5.Value : 0.0, num6.HasValue ? num6.Value : 0.0);
							return true;
						}
						catch (ArgumentException)
						{
						}
						goto IL_01dc;
					}
					IL_01dc:
					return false;
				}
				break;
			}
		}
	}

	static kdo()
	{
		awj.QuEwGz();
		nGn = new Rect(5.0, 5.0, 5.0, 5.0);
		nGJ = new Rect(0.0, 0.0, 0.0, 0.0);
		wGe = new Rect(100000.0, 100000.0, 100000.0, 100000.0);
		bGk = new Rect(-100000.0, -100000.0, 0.0, 0.0);
		jGE = new Rect(1.0, 1.0, 1.0, 1.0);
	}

	internal static bool fSN()
	{
		return JSf == null;
	}

	internal static kdo OSL()
	{
		return JSf;
	}
}
