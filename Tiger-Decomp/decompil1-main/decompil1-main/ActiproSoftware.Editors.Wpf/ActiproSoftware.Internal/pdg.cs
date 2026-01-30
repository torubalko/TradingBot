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

internal static class pdg
{
	public static readonly Thickness Nq1;

	public static readonly Thickness Xq8;

	public static readonly Thickness Fqr;

	public static readonly Thickness qqv;

	public static readonly Thickness qqp;

	internal static pdg WAj;

	public static string Vqc(Thickness? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		double value = P_0.Value.Left;
		double value2 = P_0.Value.Top;
		double value3 = P_0.Value.Right;
		double value4 = P_0.Value.Bottom;
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

	public static IList<IPart> nqH(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		mdH mdH2 = new mdH();
		mdH2.Format = P_0;
		list.Add(mdH2);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		Qdf qdf = new Qdf();
		qdf.Format = P_0;
		list.Add(qdf);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		IdG idG = new IdG();
		idG.Format = P_0;
		list.Add(idG);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		qd2 qd3 = new qd2();
		qd3.Format = P_0;
		list.Add(qd3);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Thickness FqL(Thickness P_0, double P_1, Thickness? P_2, Thickness? P_3, SpinWrapping P_4, int? P_5)
	{
		Thickness thickness = new Thickness(P_0.Left, P_0.Top, P_0.Right, P_2.HasValue ? P_2.Value.Bottom : 0.0);
		Thickness thickness2 = new Thickness(P_0.Left, P_0.Top, P_0.Right, P_3.HasValue ? P_3.Value.Bottom : double.MaxValue);
		try
		{
			P_0.Bottom = Math.Max(0.0, qdP.wDY(P_0.Bottom, P_1, thickness.Bottom, thickness2.Bottom, P_4, P_5));
			P_0 = qqy(P_0, thickness, thickness2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? thickness2 : thickness);
		}
		return P_0;
	}

	public static Thickness EqF(Thickness P_0, double P_1, Thickness? P_2, Thickness? P_3, SpinWrapping P_4, int? P_5)
	{
		Thickness thickness = new Thickness(P_2.HasValue ? P_2.Value.Left : double.MinValue, P_0.Top, P_0.Right, P_0.Bottom);
		Thickness thickness2 = new Thickness(P_3.HasValue ? P_3.Value.Left : double.MaxValue, P_0.Top, P_0.Right, P_0.Bottom);
		try
		{
			P_0.Left = Math.Max(0.0, qdP.wDY(P_0.Left, P_1, thickness.Left, thickness2.Left, P_4, P_5));
			P_0 = qqy(P_0, thickness, thickness2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? thickness2 : thickness);
		}
		return P_0;
	}

	public static Thickness IqA(Thickness P_0, double P_1, Thickness? P_2, Thickness? P_3, SpinWrapping P_4, int? P_5)
	{
		Thickness thickness = new Thickness(P_0.Left, P_0.Top, P_2.HasValue ? P_2.Value.Right : 0.0, P_0.Bottom);
		Thickness thickness2 = new Thickness(P_0.Left, P_0.Top, P_3.HasValue ? P_3.Value.Right : double.MaxValue, P_0.Bottom);
		try
		{
			P_0.Right = Math.Max(0.0, qdP.wDY(P_0.Right, P_1, thickness.Right, thickness2.Right, P_4, P_5));
			P_0 = qqy(P_0, thickness, thickness2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? thickness2 : thickness);
		}
		return P_0;
	}

	public static Thickness Vq3(Thickness P_0, double P_1, Thickness? P_2, Thickness? P_3, SpinWrapping P_4, int? P_5)
	{
		Thickness thickness = new Thickness(P_0.Left, P_2.HasValue ? P_2.Value.Top : double.MinValue, P_0.Right, P_0.Bottom);
		Thickness thickness2 = new Thickness(P_0.Left, P_3.HasValue ? P_3.Value.Top : double.MaxValue, P_0.Right, P_0.Bottom);
		try
		{
			P_0.Top = Math.Max(0.0, qdP.wDY(P_0.Top, P_1, thickness.Top, thickness2.Top, P_4, P_5));
			P_0 = qqy(P_0, thickness, thickness2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? thickness2 : thickness);
		}
		return P_0;
	}

	public static Thickness qqy(Thickness P_0, Thickness P_1, Thickness P_2, int? P_3)
	{
		return new Thickness(qdP.jDO(P_0.Left, P_1.Left, P_2.Left, P_3), qdP.jDO(P_0.Top, P_1.Top, P_2.Top, P_3), qdP.jDO(P_0.Right, P_1.Right, P_2.Right, P_3), qdP.jDO(P_0.Bottom, P_1.Bottom, P_2.Bottom, P_3));
	}

	public static Thickness mqm(Thickness P_0, Thickness P_1, Thickness P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new Thickness(qdP.JDT(P_0.Left, P_1.Left, P_2.Left, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Top, P_1.Top, P_2.Top, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Right, P_1.Right, P_2.Right, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Bottom, P_1.Bottom, P_2.Bottom, P_3, P_4, P_5, P_6));
	}

	public static bool bqS(string P_0, string P_1, out Thickness? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		string text = qdP.GDb().Trim();
		string pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(26576), new object[1] { text });
		Regex regex = new Regex(pattern, RegexOptions.Singleline);
		Match match = regex.Match(P_0);
		if (match.Success)
		{
			double? num = null;
			double? num2 = null;
			double? num3 = null;
			double? num4 = null;
			qdP.DDI(match.Groups[1].Value, P_1, out num);
			qdP.DDI(match.Groups[2].Value, P_1, out num2);
			qdP.DDI(match.Groups[3].Value, P_1, out num3);
			qdP.DDI(match.Groups[4].Value, P_1, out num4);
			try
			{
				P_2 = new Thickness(num.HasValue ? num.Value : 0.0, num2.HasValue ? num2.Value : 0.0, num3.HasValue ? num3.Value : 0.0, num4.HasValue ? num4.Value : 0.0);
				return true;
			}
			catch (ArgumentException)
			{
			}
		}
		else
		{
			pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(28338), new object[1] { text });
			regex = new Regex(pattern, RegexOptions.Singleline);
			match = regex.Match(P_0);
			if (match.Success)
			{
				double? num5 = null;
				double? num6 = null;
				qdP.DDI(match.Groups[1].Value, P_1, out num5);
				qdP.DDI(match.Groups[2].Value, P_1, out num6);
				try
				{
					P_2 = new Thickness(num5.HasValue ? num5.Value : 0.0, num6.HasValue ? num6.Value : 0.0, num5.HasValue ? num5.Value : 0.0, num6.HasValue ? num6.Value : 0.0);
					return true;
				}
				catch (ArgumentException)
				{
				}
			}
			else
			{
				int num7 = P_0.IndexOf(text, StringComparison.OrdinalIgnoreCase);
				if (num7 == -1)
				{
					num7 = P_0.Length;
				}
				else if (!string.IsNullOrEmpty(P_0.Substring(num7 + 1).Trim()))
				{
					num7 = -1;
				}
				if (num7 > 0)
				{
					double? num8 = null;
					qdP.DDI(P_0.Substring(0, num7).Trim(), P_1, out num8);
					if (num8.HasValue)
					{
						try
						{
							P_2 = new Thickness(num8.Value);
							return true;
						}
						catch (ArgumentException)
						{
						}
					}
				}
			}
		}
		return false;
	}

	static pdg()
	{
		awj.QuEwGz();
		Nq1 = new Thickness(5.0, 5.0, 5.0, 5.0);
		Xq8 = new Thickness(0.0, 0.0, 0.0, 0.0);
		Fqr = new Thickness(100.0, 100.0, 100.0, 100.0);
		qqv = new Thickness(0.0, 0.0, 0.0, 0.0);
		qqp = new Thickness(1.0, 1.0, 1.0, 1.0);
	}

	internal static bool HAG()
	{
		return WAj == null;
	}

	internal static pdg WAJ()
	{
		return WAj;
	}
}
