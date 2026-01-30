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

internal static class XdB
{
	public static readonly CornerRadius Nbc;

	public static readonly CornerRadius cbH;

	public static readonly CornerRadius cbL;

	public static readonly CornerRadius FbF;

	public static readonly CornerRadius GbA;

	internal static XdB hS8;

	public static string dbD(CornerRadius? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		double value = P_0.Value.TopLeft;
		double value2 = P_0.Value.TopRight;
		double value3 = P_0.Value.BottomRight;
		double value4 = P_0.Value.BottomLeft;
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

	public static IList<IPart> PbG(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		zy zy2 = new zy();
		zy2.Format = P_0;
		list.Add(zy2);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		uV uV2 = new uV();
		uV2.Format = P_0;
		list.Add(uV2);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		Lx lx = new Lx();
		lx.Format = P_0;
		list.Add(lx);
		mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		yP yP2 = new yP();
		yP2.Format = P_0;
		list.Add(yP2);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static CornerRadius Hbq(CornerRadius P_0, double P_1, CornerRadius? P_2, CornerRadius? P_3, SpinWrapping P_4, int? P_5)
	{
		CornerRadius cornerRadius = new CornerRadius(P_0.TopLeft, P_0.TopRight, P_0.BottomRight, P_2.HasValue ? P_2.Value.BottomLeft : 0.0);
		CornerRadius cornerRadius2 = new CornerRadius(P_0.TopLeft, P_0.TopRight, P_0.BottomRight, P_3.HasValue ? P_3.Value.BottomLeft : double.MaxValue);
		try
		{
			P_0.BottomLeft = Math.Max(0.0, qdP.wDY(P_0.BottomLeft, P_1, cornerRadius.BottomLeft, cornerRadius2.BottomLeft, P_4, P_5));
			P_0 = Obd(P_0, cornerRadius, cornerRadius2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? cornerRadius2 : cornerRadius);
		}
		return P_0;
	}

	public static CornerRadius Jbu(CornerRadius P_0, double P_1, CornerRadius? P_2, CornerRadius? P_3, SpinWrapping P_4, int? P_5)
	{
		CornerRadius cornerRadius = new CornerRadius(P_2.HasValue ? P_2.Value.TopLeft : double.MinValue, P_0.TopRight, P_0.BottomRight, P_0.BottomLeft);
		CornerRadius cornerRadius2 = new CornerRadius(P_3.HasValue ? P_3.Value.TopLeft : double.MaxValue, P_0.TopRight, P_0.BottomRight, P_0.BottomLeft);
		try
		{
			P_0.TopLeft = Math.Max(0.0, qdP.wDY(P_0.TopLeft, P_1, cornerRadius.TopLeft, cornerRadius2.TopLeft, P_4, P_5));
			P_0 = Obd(P_0, cornerRadius, cornerRadius2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? cornerRadius2 : cornerRadius);
		}
		return P_0;
	}

	public static CornerRadius jbK(CornerRadius P_0, double P_1, CornerRadius? P_2, CornerRadius? P_3, SpinWrapping P_4, int? P_5)
	{
		CornerRadius cornerRadius = new CornerRadius(P_0.TopLeft, P_0.TopRight, P_2.HasValue ? P_2.Value.BottomRight : 0.0, P_0.BottomLeft);
		CornerRadius cornerRadius2 = new CornerRadius(P_0.TopLeft, P_0.TopRight, P_3.HasValue ? P_3.Value.BottomRight : double.MaxValue, P_0.BottomLeft);
		try
		{
			P_0.BottomRight = Math.Max(0.0, qdP.wDY(P_0.BottomRight, P_1, cornerRadius.BottomRight, cornerRadius2.BottomRight, P_4, P_5));
			P_0 = Obd(P_0, cornerRadius, cornerRadius2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? cornerRadius2 : cornerRadius);
		}
		return P_0;
	}

	public static CornerRadius abR(CornerRadius P_0, double P_1, CornerRadius? P_2, CornerRadius? P_3, SpinWrapping P_4, int? P_5)
	{
		CornerRadius cornerRadius = new CornerRadius(P_0.TopLeft, P_2.HasValue ? P_2.Value.TopRight : double.MinValue, P_0.BottomRight, P_0.BottomLeft);
		CornerRadius cornerRadius2 = new CornerRadius(P_0.TopLeft, P_3.HasValue ? P_3.Value.TopRight : double.MaxValue, P_0.BottomRight, P_0.BottomLeft);
		try
		{
			P_0.TopRight = Math.Max(0.0, qdP.wDY(P_0.TopRight, P_1, cornerRadius.TopRight, cornerRadius2.TopRight, P_4, P_5));
			P_0 = Obd(P_0, cornerRadius, cornerRadius2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? cornerRadius2 : cornerRadius);
		}
		return P_0;
	}

	public static CornerRadius Obd(CornerRadius P_0, CornerRadius P_1, CornerRadius P_2, int? P_3)
	{
		return new CornerRadius(qdP.jDO(P_0.TopLeft, P_1.TopLeft, P_2.TopLeft, P_3), qdP.jDO(P_0.TopRight, P_1.TopRight, P_2.TopRight, P_3), qdP.jDO(P_0.BottomRight, P_1.BottomRight, P_2.BottomRight, P_3), qdP.jDO(P_0.BottomLeft, P_1.BottomLeft, P_2.BottomLeft, P_3));
	}

	public static CornerRadius Tb9(CornerRadius P_0, CornerRadius P_1, CornerRadius P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new CornerRadius(qdP.JDT(P_0.TopLeft, P_1.TopLeft, P_2.TopLeft, P_3, P_4, P_5, P_6), qdP.JDT(P_0.TopRight, P_1.TopRight, P_2.TopRight, P_3, P_4, P_5, P_6), qdP.JDT(P_0.BottomRight, P_1.BottomRight, P_2.BottomRight, P_3, P_4, P_5, P_6), qdP.JDT(P_0.BottomLeft, P_1.BottomLeft, P_2.BottomLeft, P_3, P_4, P_5, P_6));
	}

	public static bool Gb5(string P_0, string P_1, out CornerRadius? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		string text = qdP.GDb().Trim();
		string pattern = string.Format(CultureInfo.InvariantCulture, QdM.AR8(26576), new object[1] { text });
		Regex regex = new Regex(pattern, RegexOptions.Singleline);
		int num = 2;
		if (GSQ() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		Match match = default(Match);
		int num3 = default(int);
		double? num2 = default(double?);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				double? num4 = null;
				double? num5 = null;
				double? num6 = null;
				double? num7 = null;
				qdP.DDI(match.Groups[1].Value, P_1, out num4);
				qdP.DDI(match.Groups[2].Value, P_1, out num5);
				qdP.DDI(match.Groups[3].Value, P_1, out num6);
				qdP.DDI(match.Groups[4].Value, P_1, out num7);
				try
				{
					P_2 = new CornerRadius(num4.HasValue ? num4.Value : 0.0, num5.HasValue ? num5.Value : 0.0, num6.HasValue ? num6.Value : 0.0, num7.HasValue ? num7.Value : 0.0);
					return true;
				}
				catch (ArgumentException)
				{
				}
				goto IL_031c;
			}
			case 2:
				match = regex.Match(P_0);
				if (match.Success)
				{
					num = 2;
					if (JS1())
					{
						num = 3;
					}
					continue;
				}
				num3 = P_0.IndexOf(text, StringComparison.OrdinalIgnoreCase);
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
					num2 = null;
					num = 1;
					if (GSQ() == null)
					{
						continue;
					}
					break;
				}
				goto IL_031c;
			case 1:
				qdP.DDI(P_0.Substring(0, num3).Trim(), P_1, out num2);
				if (!num2.HasValue)
				{
					goto IL_031c;
				}
				num = 0;
				if (GSQ() == null)
				{
					continue;
				}
				break;
			default:
				{
					try
					{
						P_2 = new CornerRadius(num2.Value);
						return true;
					}
					catch (ArgumentException)
					{
					}
					goto IL_031c;
				}
				IL_031c:
				return false;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num8 = default(int);
		num = num8;
		goto IL_0009;
	}

	static XdB()
	{
		awj.QuEwGz();
		Nbc = new CornerRadius(0.0, 0.0, 0.0, 0.0);
		cbH = new CornerRadius(5.0, 5.0, 5.0, 5.0);
		cbL = new CornerRadius(50.0, 50.0, 50.0, 50.0);
		FbF = new CornerRadius(0.0, 0.0, 0.0, 0.0);
		GbA = new CornerRadius(1.0, 1.0, 1.0, 1.0);
	}

	internal static bool JS1()
	{
		return hS8 == null;
	}

	internal static XdB GSQ()
	{
		return hS8;
	}
}
