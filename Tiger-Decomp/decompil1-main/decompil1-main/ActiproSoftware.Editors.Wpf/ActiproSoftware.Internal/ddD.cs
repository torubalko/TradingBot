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

internal static class ddD
{
	public static readonly Size wqK;

	public static readonly Size jqR;

	public static readonly Size rqd;

	public static readonly Size vq9;

	public static readonly Size oq5;

	internal static ddD eAW;

	public static string NqT(Size? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		double value = P_0.Value.Width;
		double value2 = P_0.Value.Height;
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

	public static IList<IPart> EqI(string P_0, CultureInfo P_1)
	{
		P_0 = qdP.uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		ldw ldw2 = new ldw();
		ldw2.Format = P_0;
		list.Add(ldw2);
		ME mE = new ME();
		mE.Text = qdP.GDb();
		list.Add(mE);
		Idd idd = new Idd();
		idd.Format = P_0;
		list.Add(idd);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Size aqb(Size P_0, double P_1, Size? P_2, Size? P_3, SpinWrapping P_4, int? P_5)
	{
		Size size = new Size(P_0.Width, P_2.HasValue ? P_2.Value.Height : 0.0);
		Size size2 = new Size(P_0.Width, P_3.HasValue ? P_3.Value.Height : double.MaxValue);
		try
		{
			P_0.Height = Math.Max(0.0, qdP.wDY(P_0.Height, P_1, size.Height, size2.Height, P_4, P_5));
			P_0 = bqG(P_0, size, size2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? size2 : size);
		}
		return P_0;
	}

	public static Size JqD(Size P_0, double P_1, Size? P_2, Size? P_3, SpinWrapping P_4, int? P_5)
	{
		Size size = new Size(P_2.HasValue ? P_2.Value.Width : 0.0, P_0.Height);
		Size size2 = new Size(P_3.HasValue ? P_3.Value.Width : double.MaxValue, P_0.Height);
		try
		{
			P_0.Width = Math.Max(0.0, qdP.wDY(P_0.Width, P_1, size.Width, size2.Width, P_4, P_5));
			P_0 = bqG(P_0, size, size2, P_5);
		}
		catch (ArgumentException)
		{
			P_0 = ((P_1 > 0.0) ? size2 : size);
		}
		return P_0;
	}

	public static Size bqG(Size P_0, Size P_1, Size P_2, int? P_3)
	{
		return new Size(qdP.jDO(P_0.Width, P_1.Width, P_2.Width, P_3), qdP.jDO(P_0.Height, P_1.Height, P_2.Height, P_3));
	}

	public static Size jqq(Size P_0, Size P_1, Size P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		return new Size(qdP.JDT(P_0.Width, P_1.Width, P_2.Width, P_3, P_4, P_5, P_6), qdP.JDT(P_0.Height, P_1.Height, P_2.Height, P_3, P_4, P_5, P_6));
	}

	public static bool qqu(string P_0, string P_1, out Size? P_2)
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
		double? num2 = default(double?);
		bool hasValue = default(bool);
		int num3;
		if (!match.Success)
		{
			int num = P_0.IndexOf(text, StringComparison.OrdinalIgnoreCase);
			if (num != -1)
			{
				if (!string.IsNullOrEmpty(P_0.Substring(num + 1).Trim()))
				{
					num = -1;
				}
			}
			else
			{
				num = P_0.Length;
			}
			if (num <= 0)
			{
				goto IL_0248;
			}
			num2 = null;
			qdP.DDI(P_0.Substring(0, num).Trim(), P_1, out num2);
			hasValue = num2.HasValue;
			num3 = 2;
			if (PAa() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			num3 = 1;
			if (PAa() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
		IL_0248:
		return false;
		IL_0009:
		while (true)
		{
			double? num5;
			double? num6;
			switch (num3)
			{
			case 1:
				goto IL_00cc;
			default:
				qdP.DDI(match.Groups[1].Value, P_1, out num5);
				qdP.DDI(match.Groups[2].Value, P_1, out num6);
				try
				{
					P_2 = new Size(num5.HasValue ? num5.Value : 0.0, num6.HasValue ? num6.Value : 0.0);
					return true;
				}
				catch (ArgumentException)
				{
				}
				break;
			case 2:
				if (hasValue)
				{
					try
					{
						P_2 = new Size(num2.Value, num2.Value);
						return true;
					}
					catch (ArgumentException)
					{
					}
				}
				break;
			}
			break;
			IL_00cc:
			num5 = null;
			num6 = null;
			num3 = 0;
			if (PAa() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0248;
	}

	static ddD()
	{
		awj.QuEwGz();
		wqK = new Size(5.0, 5.0);
		jqR = new Size(0.0, 0.0);
		rqd = new Size(100000.0, 100000.0);
		vq9 = new Size(0.0, 0.0);
		oq5 = new Size(1.0, 1.0);
	}

	internal static bool zAr()
	{
		return eAW == null;
	}

	internal static ddD PAa()
	{
		return eAW;
	}
}
