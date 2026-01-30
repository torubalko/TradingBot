using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class xdU
{
	public static readonly TimeSpan vuQ;

	public static readonly TimeSpan WuV;

	public static readonly TimeSpan guC;

	public static readonly TimeSpan Wu6;

	public static readonly TimeSpan duM;

	private static Regex xus;

	private static xdU IAh;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static IPart hqW(string P_0, string P_1, IPart P_2)
	{
		ME mE2;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0))
		{
		case 3032550497u:
		{
			if (!(P_0 == QdM.AR8(28410)))
			{
				break;
			}
			Ad9 ad = new Ad9();
			ad.Format = P_1;
			return ad;
		}
		case 1769114507u:
		{
			if (!(P_0 == QdM.AR8(28430)))
			{
				break;
			}
			Wdk wdk = new Wdk();
			wdk.Format = P_1;
			return wdk;
		}
		case 63569407u:
		{
			if (!(P_0 == QdM.AR8(28450)))
			{
				break;
			}
			HdO hdO = new HdO();
			hdO.Format = P_1;
			return hdO;
		}
		case 774093339u:
		{
			if (!(P_0 == QdM.AR8(28486)))
			{
				break;
			}
			dg dg2 = new dg();
			dg2.Text = P_1 ?? string.Empty;
			return dg2;
		}
		case 1715923473u:
		{
			if (!(P_0 == QdM.AR8(28516)))
			{
				break;
			}
			td1 td2 = new td1();
			td2.Format = P_1;
			return td2;
		}
		case 2285524807u:
		{
			if (!(P_0 == QdM.AR8(28538)))
			{
				break;
			}
			Ddj ddj = new Ddj();
			ddj.Format = P_1;
			return ddj;
		}
		case 306597803u:
		{
			if (!(P_0 == QdM.AR8(28564)))
			{
				break;
			}
			xdI xdI2 = new xdI();
			xdI2.Format = P_1;
			return xdI2;
		}
		case 572892822u:
		{
			if (!(P_0 == QdM.AR8(26822)))
			{
				break;
			}
			Id4 id = new Id4();
			id.Format = P_1;
			return id;
		}
		case 2731729802u:
		{
			if (!(P_0 == QdM.AR8(28590)))
			{
				break;
			}
			CdA cdA = new CdA();
			cdA.Format = P_1;
			return cdA;
		}
		case 708488923u:
			if (!(P_0 == QdM.AR8(28642)))
			{
				break;
			}
			goto IL_0340;
		case 535917593u:
			if (!(P_0 == QdM.AR8(26976)))
			{
				break;
			}
			goto IL_0340;
		case 1748879461u:
			{
				if (!(P_0 == QdM.AR8(27018)))
				{
					break;
				}
				goto IL_0340;
			}
			IL_0340:
			if (P_0 == QdM.AR8(26976))
			{
				P_1 = yqn(P_1);
			}
			if (P_2 is ME mE && !mE.fkx())
			{
				mE.Text += P_1;
				break;
			}
			mE2 = new ME();
			mE2.Text = P_1 ?? string.Empty;
			return mE2;
		}
		return null;
	}

	private static string eqi(string P_0, string P_1)
	{
		if (!string.IsNullOrEmpty(P_0) && !string.IsNullOrEmpty(P_1) && !Qqt(P_1))
		{
			IList<IPart> list = Bqe(P_1);
			nd8.oGR(list, P_0);
			string value = null;
			string value2 = null;
			string value3 = null;
			string value4 = null;
			string value5 = null;
			foreach (IPart item in list)
			{
				if (item.Length > 0)
				{
					if (item is HdO || item is Wdk)
					{
						value = item.StringValue;
					}
					else if (item is td1)
					{
						value2 = item.StringValue;
					}
					else if (item is Ddj)
					{
						value3 = item.StringValue;
					}
					else if (item is xdI)
					{
						value4 = item.StringValue;
					}
					else if (item is CdA || item is Id4)
					{
						value5 = item.StringValue;
					}
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (string.IsNullOrEmpty(value))
			{
				value = QdM.AR8(2092);
			}
			stringBuilder.Append(value);
			stringBuilder.Append(QdM.AR8(2104));
			if (string.IsNullOrEmpty(value2))
			{
				value2 = QdM.AR8(2092);
			}
			stringBuilder.Append(value2);
			stringBuilder.Append(QdM.AR8(19056));
			if (string.IsNullOrEmpty(value3))
			{
				value3 = QdM.AR8(2092);
			}
			stringBuilder.Append(value3);
			stringBuilder.Append(QdM.AR8(19056));
			if (string.IsNullOrEmpty(value4))
			{
				value4 = QdM.AR8(2092);
			}
			stringBuilder.Append(value4);
			stringBuilder.Append(QdM.AR8(2104));
			if (string.IsNullOrEmpty(value5))
			{
				value5 = QdM.AR8(2092);
			}
			stringBuilder.Append(value5);
			return stringBuilder.ToString();
		}
		return P_0;
	}

	private static string pqZ(char P_0)
	{
		char c = P_0;
		char c2 = c;
		int num;
		if ((uint)c2 > 84u)
		{
			if ((uint)c2 <= 104u)
			{
				if (c2 == 'c')
				{
					goto IL_0147;
				}
				if (c2 != 'g')
				{
					goto IL_0248;
				}
				return QdM.AR8(28722);
			}
			if (c2 == 'm')
			{
				return QdM.AR8(28816);
			}
			num = 0;
			if (dAA() != null)
			{
				num = 0;
			}
		}
		else
		{
			int num2;
			if ((uint)c2 > 72u)
			{
				if (c2 == 'M')
				{
					return QdM.AR8(28848);
				}
				if (c2 == 'S')
				{
					return QdM.AR8(28912);
				}
				if (c2 == 'T')
				{
					goto IL_0147;
				}
				num2 = 3;
			}
			else
			{
				num2 = 2;
			}
			num = num2;
		}
		switch (num)
		{
		case 1:
			goto IL_0248;
		case 2:
			goto IL_0282;
		case 3:
			goto IL_029a;
		}
		if (c2 == 's')
		{
			return QdM.AR8(28884);
		}
		if (c2 == 't')
		{
			goto IL_0147;
		}
		goto IL_029a;
		IL_029a:
		throw new FormatException(QdM.AR8(27128));
		IL_0248:
		if (c2 == 'h')
		{
			return QdM.AR8(28942);
		}
		goto IL_029a;
		IL_0282:
		switch (c2)
		{
		case 'H':
			return QdM.AR8(28978);
		case 'G':
			return QdM.AR8(28770);
		}
		goto IL_029a;
		IL_0147:
		return QdM.AR8(28672);
	}

	public static bool Qqt(string P_0)
	{
		return !string.IsNullOrEmpty(P_0) && P_0.Length == 1 && QdM.AR8(29020).IndexOf(P_0[0]) != -1;
	}

	private static string yqn(string P_0)
	{
		return Regex.Replace(P_0, QdM.AR8(27212), QdM.AR8(27236));
	}

	public static string IqJ(IList<IPart> P_0, TimeSpan P_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < P_0.Count; i++)
		{
			IPart part = P_0[i];
			if (part is Ad9)
			{
				if (P_1.TotalMilliseconds < 0.0)
				{
					stringBuilder.Append(CultureInfo.CurrentCulture.NumberFormat.NegativeSign);
				}
			}
			else if (part is Wdk wdk)
			{
				if (wdk.IsOptional && P_1.Days == 0)
				{
					i++;
				}
				else
				{
					stringBuilder.Append(Math.Abs(P_1.Days).ToString(wdk.AIS, CultureInfo.CurrentCulture));
				}
			}
			else if (part is td1 td2)
			{
				stringBuilder.Append(Math.Abs(P_1.Hours).ToString(td2.aI1(), CultureInfo.CurrentCulture));
			}
			else if (part is Ddj ddj)
			{
				stringBuilder.Append(Math.Abs(P_1.Minutes).ToString(ddj.YIi(), CultureInfo.CurrentCulture));
			}
			else if (part is xdI xdI2)
			{
				stringBuilder.Append(Math.Abs(P_1.Seconds).ToString(xdI2.HIt(), CultureInfo.CurrentCulture));
			}
			else if (part is Id4 id)
			{
				if (P_1.Milliseconds == 0 && id.IsOptional)
				{
					continue;
				}
				string text = Math.Abs(P_1.Milliseconds).ToString(id.bIp(), CultureInfo.CurrentCulture);
				if (id.RIr() && !string.IsNullOrEmpty(text) && text[text.Length - 1] == '0')
				{
					int num = text.LastIndexOfAny(new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });
					if (num != -1)
					{
						text = text.Substring(0, num + 1);
					}
				}
				stringBuilder.Append(text);
			}
			else if (part is ME mE && (i >= P_0.Count - 1 || !(P_0[i + 1] is Id4 id2) || P_1.Milliseconds != 0 || !id2.IsOptional))
			{
				stringBuilder.Append(mE.Text);
			}
		}
		return stringBuilder.ToString();
	}

	public static IList<IPart> Bqe(string P_0)
	{
		string input = Iqk(P_0);
		IPart part = null;
		List<IPart> list = new List<IPart>();
		MatchCollection matchCollection = xus.Matches(input);
		foreach (Match item in matchCollection)
		{
			int num = 0;
			foreach (Group group in item.Groups)
			{
				if (group.Success && num != 0)
				{
					string text = xus.GroupNameFromNumber(num);
					IPart part2 = hqW(text, group.Value, part);
					if (part2 != null)
					{
						list.Add(part2);
						part = part2;
					}
				}
				num++;
			}
		}
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string Iqk(string P_0)
	{
		if (P_0 != null)
		{
			P_0 = P_0.Trim();
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = QdM.AR8(18772);
		}
		bool flag = P_0.Length == 1;
		int num = 0;
		if (dAA() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (flag)
			{
				P_0 = pqZ(P_0[0]);
			}
			return P_0;
		}
	}

	public static TimeSpan PqE(TimeSpan P_0, int P_1, TimeSpan? P_2, TimeSpan? P_3, SpinWrapping P_4)
	{
		TimeSpan timeSpan = P_2 ?? TimeSpan.MinValue;
		TimeSpan timeSpan2 = P_3 ?? TimeSpan.MaxValue;
		try
		{
			int num = 0;
			int num2 = int.MaxValue;
			P_0 = ((P_1 >= 0) ? ((P_0.Days == num2 && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(num, P_0.Hours, P_0.Minutes, P_0.Seconds, P_0.Milliseconds) : ((P_0.Days + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromDays(P_1)) : new TimeSpan(num2, P_0.Hours, P_0.Minutes, P_0.Seconds, P_0.Milliseconds))) : ((P_0.Days == num && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(num2, P_0.Hours, P_0.Minutes, P_0.Seconds, P_0.Milliseconds) : ((P_0.Days + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromDays(P_1)) : new TimeSpan(num, P_0.Hours, P_0.Minutes, P_0.Seconds, P_0.Milliseconds))));
			P_0 = UqU(P_0, timeSpan, timeSpan2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? timeSpan2 : timeSpan);
		}
		return P_0;
	}

	public static TimeSpan Yq7(TimeSpan P_0, int P_1, TimeSpan? P_2, TimeSpan? P_3, SpinWrapping P_4)
	{
		TimeSpan timeSpan = P_2 ?? TimeSpan.MinValue;
		TimeSpan timeSpan2 = P_3 ?? TimeSpan.MaxValue;
		try
		{
			int num = 0;
			int num2 = 23;
			P_0 = ((P_1 >= 0) ? ((P_0.Hours == num2 && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, num, P_0.Minutes, P_0.Seconds, P_0.Milliseconds) : ((P_0.Hours + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromHours(P_1)) : new TimeSpan(P_0.Days, num2, P_0.Minutes, P_0.Seconds, P_0.Milliseconds))) : ((P_0.Hours == num && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, num2, P_0.Minutes, P_0.Seconds, P_0.Milliseconds) : ((P_0.Hours + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromHours(P_1)) : new TimeSpan(P_0.Days, num, P_0.Minutes, P_0.Seconds, P_0.Milliseconds))));
			P_0 = UqU(P_0, timeSpan, timeSpan2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? timeSpan2 : timeSpan);
		}
		return P_0;
	}

	public static TimeSpan cq4(TimeSpan P_0, int P_1, TimeSpan? P_2, TimeSpan? P_3, SpinWrapping P_4)
	{
		TimeSpan timeSpan = P_2 ?? TimeSpan.MinValue;
		TimeSpan timeSpan2 = P_3 ?? TimeSpan.MaxValue;
		try
		{
			int num = 0;
			int num2 = 999;
			P_0 = ((P_1 >= 0) ? ((P_0.Milliseconds == num2 && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, P_0.Seconds, num) : ((P_0.Milliseconds + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromMilliseconds(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, P_0.Seconds, num2))) : ((P_0.Milliseconds == num && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, P_0.Seconds, num2) : ((P_0.Milliseconds + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromMilliseconds(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, P_0.Seconds, num))));
			P_0 = UqU(P_0, timeSpan, timeSpan2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? timeSpan2 : timeSpan);
		}
		return P_0;
	}

	public static TimeSpan KqB(TimeSpan P_0, int P_1, TimeSpan? P_2, TimeSpan? P_3, SpinWrapping P_4)
	{
		TimeSpan timeSpan = P_2 ?? TimeSpan.MinValue;
		TimeSpan timeSpan2 = P_3 ?? TimeSpan.MaxValue;
		try
		{
			int num = 0;
			int num2 = 59;
			P_0 = ((P_1 >= 0) ? ((P_0.Minutes == num2 && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, num, P_0.Seconds, P_0.Milliseconds) : ((P_0.Minutes + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromMinutes(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, num2, P_0.Seconds, P_0.Milliseconds))) : ((P_0.Minutes == num && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, num2, P_0.Seconds, P_0.Milliseconds) : ((P_0.Minutes + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromMinutes(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, num, P_0.Seconds, P_0.Milliseconds))));
			P_0 = UqU(P_0, timeSpan, timeSpan2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? timeSpan2 : timeSpan);
		}
		return P_0;
	}

	public static TimeSpan aqh(TimeSpan P_0, int P_1, TimeSpan? P_2, TimeSpan? P_3, SpinWrapping P_4)
	{
		TimeSpan timeSpan = P_2 ?? TimeSpan.MinValue;
		TimeSpan timeSpan2 = P_3 ?? TimeSpan.MaxValue;
		try
		{
			int num = 0;
			int num2 = 59;
			P_0 = ((P_1 >= 0) ? ((P_0.Seconds == num2 && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, num, P_0.Milliseconds) : ((P_0.Seconds + P_1 < num2 || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromSeconds(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, num2, P_0.Milliseconds))) : ((P_0.Seconds == num && P_4 == SpinWrapping.SimpleWrap) ? new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, num2, P_0.Milliseconds) : ((P_0.Seconds + P_1 > num || P_4 == SpinWrapping.Wrap) ? P_0.Add(TimeSpan.FromSeconds(P_1)) : new TimeSpan(P_0.Days, P_0.Hours, P_0.Minutes, num, P_0.Milliseconds))));
			P_0 = UqU(P_0, timeSpan, timeSpan2);
		}
		catch (ArgumentOutOfRangeException)
		{
			P_0 = ((P_1 > 0) ? timeSpan2 : timeSpan);
		}
		return P_0;
	}

	public static TimeSpan Dqw(TimeSpan P_0, TimeSpan P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static TimeSpan NqN(TimeSpan P_0, TimeSpan P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	public static TimeSpan UqU(TimeSpan P_0, TimeSpan P_1, TimeSpan P_2)
	{
		return Dqw(P_1, NqN(P_0, P_2));
	}

	public static bool Hqz(string P_0, string P_1, out TimeSpan? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		if (TimeSpan.TryParseExact(P_0, new string[6]
		{
			P_1,
			QdM.AR8(29046),
			QdM.AR8(18772),
			QdM.AR8(2648),
			QdM.AR8(18796),
			QdM.AR8(18802)
		}, CultureInfo.CurrentCulture, out var result))
		{
			P_2 = result;
			return true;
		}
		if (TimeSpan.TryParse(P_0, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result;
			return true;
		}
		string text = eqi(P_0, P_1);
		if (text != P_0 && TimeSpan.TryParse(text, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result;
			return true;
		}
		return false;
	}

	static xdU()
	{
		awj.QuEwGz();
		vuQ = new TimeSpan(7, 3, 5, 5, 50);
		WuV = TimeSpan.MaxValue;
		guC = TimeSpan.MinValue;
		Wu6 = new TimeSpan(1, 1, 1, 1, 1);
		duM = TimeSpan.Zero;
		xus = new Regex(QdM.AR8(29052), RegexOptions.ExplicitCapture | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant);
	}

	internal static bool UAS()
	{
		return IAh == null;
	}

	internal static xdU dAA()
	{
		return IAh;
	}
}
