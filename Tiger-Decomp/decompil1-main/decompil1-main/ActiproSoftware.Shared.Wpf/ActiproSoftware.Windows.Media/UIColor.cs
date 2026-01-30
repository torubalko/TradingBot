using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public struct UIColor
{
	internal struct HSBColor
	{
		private double b;

		private double RWz;

		private double DUc;

		internal static object Hjq;

		internal double B
		{
			get
			{
				return b;
			}
			set
			{
				b = Math.Max(0.0, Math.Min(1.0, value));
			}
		}

		internal double H
		{
			get
			{
				return RWz;
			}
			set
			{
				RWz = Math.Max(0.0, Math.Min(360.0, value));
			}
		}

		internal double S
		{
			get
			{
				return DUc;
			}
			set
			{
				DUc = Math.Max(0.0, Math.Min(1.0, value));
			}
		}

		public HSBColor(double h, double s, double b)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			RWz = 0.0;
			DUc = 0.0;
			this.b = 0.0;
			H = h;
			S = s;
			B = b;
		}

		private static void hWG(double P_0, double P_1, double P_2, out byte P_3, out byte P_4, out byte P_5)
		{
			P_0 = Math.Min(1.0, Math.Max(0.0, P_0 / 360.0));
			P_1 = Math.Min(1.0, Math.Max(0.0, P_1));
			P_2 = Math.Min(1.0, Math.Max(0.0, P_2));
			int num;
			if (P_1 == 0.0)
			{
				num = 2;
				if (vjn() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_02d2;
			IL_01fa:
			double num3;
			double num2 = num3;
			double num5;
			double num4 = num5;
			double num6 = P_2;
			num = 3;
			goto IL_0009;
			IL_0005:
			int num7 = default(int);
			num = num7;
			goto IL_0009;
			IL_0009:
			switch (num)
			{
			case 2:
				num2 = (num4 = (num6 = P_2));
				break;
			case 1:
			case 3:
				break;
			default:
				goto IL_02d2;
			}
			goto IL_00e9;
			IL_00e9:
			P_3 = (byte)Math.Min(Math.Max(num2 * 255.0, 0.0), 255.0);
			P_4 = (byte)Math.Min(Math.Max(num4 * 255.0, 0.0), 255.0);
			P_5 = (byte)Math.Min(Math.Max(num6 * 255.0, 0.0), 255.0);
			return;
			IL_02d2:
			double num8 = (P_0 - Math.Floor(P_0)) * 6.0;
			int num9 = (int)num8;
			double num10 = num8 - (double)num9;
			num5 = P_2 * (1.0 - P_1);
			double num11 = P_2 * (1.0 - P_1 * num10);
			num3 = P_2 * (1.0 - P_1 * (1.0 - num10));
			switch (num9 % 6)
			{
			case 1:
				goto IL_0080;
			case 3:
				goto IL_01d5;
			case 0:
				goto IL_01de;
			case 4:
				goto IL_01fa;
			case 2:
				goto IL_0214;
			}
			num2 = P_2;
			num4 = num5;
			num6 = num11;
			goto IL_00e9;
			IL_01de:
			num2 = P_2;
			num4 = num3;
			num6 = num5;
			goto IL_00e9;
			IL_0080:
			num2 = num11;
			num4 = P_2;
			num6 = num5;
			goto IL_00e9;
			IL_0214:
			num2 = num5;
			num4 = P_2;
			num6 = num3;
			goto IL_00e9;
			IL_01d5:
			num2 = num5;
			num4 = num11;
			num6 = P_2;
			num = 1;
			if (vjn() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}

		private static void UW1(double P_0, double P_1, double P_2, out double P_3, out double P_4, out double P_5)
		{
			P_0 = Math.Min(1.0, Math.Max(0.0, P_0 / 255.0));
			P_1 = Math.Min(1.0, Math.Max(0.0, P_1 / 255.0));
			P_2 = Math.Min(1.0, Math.Max(0.0, P_2 / 255.0));
			double num = Math.Min(P_0, Math.Min(P_1, P_2));
			int num2 = 1;
			if (!KjG())
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0005:
			int num3 = default(int);
			num2 = num3;
			goto IL_0009;
			IL_0009:
			bool flag = default(bool);
			double num4 = default(double);
			double num5 = default(double);
			do
			{
				IL_0009_2:
				switch (num2)
				{
				default:
					if (!flag)
					{
						if (P_1 == num4)
						{
							P_3 = 2.0 + (P_2 - P_0) / num5;
						}
						else
						{
							P_3 = 4.0 + (P_0 - P_1) / num5;
						}
					}
					else
					{
						P_3 = (P_1 - P_2) / num5;
					}
					if (!(P_3 < 0.0))
					{
						goto case 2;
					}
					P_3 += 6.0;
					num2 = 2;
					goto IL_0009_2;
				case 1:
					num4 = Math.Max(P_0, Math.Max(P_1, P_2));
					P_3 = 0.0;
					P_4 = 0.0;
					P_5 = num4;
					if (num != num4)
					{
						break;
					}
					goto IL_0020;
				case 2:
					{
						P_3 /= 6.0;
						goto IL_0020;
					}
					IL_0020:
					P_3 = Math.Min(1.0, Math.Max(0.0, P_3)) * 360.0;
					P_4 = Math.Min(1.0, Math.Max(0.0, P_4));
					P_5 = Math.Min(1.0, Math.Max(0.0, P_5));
					return;
				}
				num5 = num4 - num;
				P_4 = num5 / num4;
				flag = P_0 == num4;
				num2 = 0;
			}
			while (vjn() == null);
			goto IL_0005;
		}

		public static implicit operator Color(HSBColor color)
		{
			hWG(color.H, color.S, color.B, out var r, out var g, out var b);
			return Color.FromArgb(byte.MaxValue, r, g, b);
		}

		public static implicit operator HSBColor(Color color)
		{
			UW1((int)color.R, (int)color.G, (int)color.B, out var h, out var s, out var num);
			return new HSBColor(h, s, num);
		}

		internal static bool KjG()
		{
			return Hjq == null;
		}

		internal static object vjn()
		{
			return Hjq;
		}
	}

	internal struct HLSColor
	{
		private double YUX;

		private double SUT;

		private double lUB;

		internal static object Gj0;

		internal double H
		{
			get
			{
				return YUX;
			}
			set
			{
				YUX = Math.Max(0.0, Math.Min(360.0, value));
			}
		}

		internal double L
		{
			get
			{
				return SUT;
			}
			set
			{
				SUT = Math.Max(0.0, Math.Min(1.0, value));
			}
		}

		internal double S
		{
			get
			{
				return lUB;
			}
			set
			{
				lUB = Math.Max(0.0, Math.Min(1.0, value));
			}
		}

		public HLSColor(double h, double l, double s)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			YUX = 0.0;
			SUT = 0.0;
			lUB = 0.0;
			H = h;
			L = l;
			S = s;
		}

		private static void dUj(double P_0, double P_1, double P_2, out byte P_3, out byte P_4, out byte P_5)
		{
			P_0 /= 360.0;
			double num2;
			double num3;
			double num = (num2 = (num3 = P_1));
			int num4;
			if (!(P_1 <= 0.5))
			{
				num4 = 0;
				if (!Rjb())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			double num5 = P_1 * (1.0 + P_2);
			goto IL_02f8;
			IL_0192:
			P_3 = (byte)Math.Min(Math.Max(num * 255.0, 0.0), 255.0);
			P_4 = (byte)Math.Min(Math.Max(num2 * 255.0, 0.0), 255.0);
			num4 = 4;
			goto IL_0009;
			IL_02f8:
			double num6 = num5;
			double num7 = default(double);
			double num8 = default(double);
			int num9 = default(int);
			double num10 = default(double);
			if (num6 > 0.0)
			{
				num7 = P_1 + P_1 - num6;
				num8 = (num6 - num7) / num6;
				P_0 *= 6.0;
				num9 = (int)P_0;
				num10 = P_0 - (double)num9;
				num4 = 3;
				goto IL_0009;
			}
			goto IL_0192;
			IL_0005:
			int num11 = default(int);
			num4 = num11;
			goto IL_0009;
			IL_0009:
			double num13 = default(double);
			double num14 = default(double);
			int num16 = default(int);
			while (true)
			{
				switch (num4)
				{
				case 3:
					break;
				case 1:
					goto IL_00f0;
				case 4:
					P_5 = (byte)Math.Min(Math.Max(num3 * 255.0, 0.0), 255.0);
					return;
				default:
					goto end_IL_0009;
				case 2:
					goto IL_02bd;
				}
				double num12 = num6 * num8 * num10;
				num13 = num7 + num12;
				num14 = num6 - num12;
				int num15 = num9 % 6;
				num16 = num15;
				num4 = 1;
				if (fj1() == null)
				{
					continue;
				}
				goto IL_0005;
				IL_02bd:
				num3 = num7;
				goto IL_0192;
				IL_00f0:
				switch (num16)
				{
				case 3:
					num = num7;
					num2 = num14;
					num3 = num6;
					break;
				case 5:
					num = num6;
					num2 = num7;
					num3 = num14;
					break;
				case 0:
					num = num6;
					num2 = num13;
					num4 = 2;
					if (!Rjb())
					{
						num4 = 0;
					}
					continue;
				case 4:
					num = num13;
					num2 = num7;
					num3 = num6;
					break;
				case 2:
					num = num7;
					num2 = num6;
					num3 = num13;
					break;
				case 1:
					num = num14;
					num2 = num6;
					num3 = num7;
					break;
				}
				goto IL_0192;
				continue;
				end_IL_0009:
				break;
			}
			num5 = P_1 + P_2 - P_1 * P_2;
			goto IL_02f8;
		}

		private static void JUv(int P_0, int P_1, int P_2, out double P_3, out double P_4, out double P_5)
		{
			double num = (double)P_0 / 255.0;
			double num2 = (double)P_1 / 255.0;
			double num3 = (double)P_2 / 255.0;
			P_3 = 0.0;
			P_5 = 0.0;
			P_4 = 0.0;
			double val = Math.Max(num, num2);
			val = Math.Max(val, num3);
			double val2 = Math.Min(num, num2);
			val2 = Math.Min(val2, num3);
			P_4 = (val2 + val) / 2.0;
			if (P_4 <= 0.0)
			{
				return;
			}
			double num4 = (P_5 = val - val2);
			if (!(P_5 > 0.0))
			{
				return;
			}
			P_5 /= ((P_4 <= 0.5) ? (val + val2) : (2.0 - val - val2));
			double num5 = (val - num) / num4;
			int num6 = 0;
			if (fj1() != null)
			{
				num6 = 0;
			}
			double num9 = default(double);
			double num7 = default(double);
			bool flag = default(bool);
			while (true)
			{
				switch (num6)
				{
				default:
					num9 = (val - num2) / num4;
					num7 = (val - num3) / num4;
					if (num != val)
					{
						flag = num2 == val;
						num6 = 1;
						if (fj1() != null)
						{
							num6 = 0;
						}
						break;
					}
					P_3 = ((num2 == val2) ? (5.0 + num7) : (1.0 - num9));
					goto case 2;
				case 2:
					P_3 /= 6.0;
					P_3 *= 360.0;
					return;
				case 1:
					if (flag)
					{
						P_3 = ((num3 == val2) ? (1.0 + num5) : (3.0 - num7));
						int num8 = 2;
						num6 = num8;
						break;
					}
					P_3 = ((num == val2) ? (3.0 + num9) : (5.0 - num5));
					goto case 2;
				}
			}
		}

		public static implicit operator Color(HLSColor color)
		{
			dUj(color.H, color.L, color.S, out var r, out var g, out var b);
			return Color.FromArgb(byte.MaxValue, r, g, b);
		}

		public static implicit operator HLSColor(Color color)
		{
			JUv(color.R, color.G, color.B, out var h, out var l, out var s);
			return new HLSColor(h, l, s);
		}

		internal static bool Rjb()
		{
			return Gj0 == null;
		}

		internal static object fj1()
		{
			return Gj0;
		}
	}

	private Color AQ7;

	internal static object T7r;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "A")]
	public byte A
	{
		get
		{
			return AQ7.A;
		}
		set
		{
			AQ7 = Color.FromArgb(value, AQ7.R, AQ7.G, AQ7.B);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "B")]
	public byte B
	{
		get
		{
			return AQ7.B;
		}
		set
		{
			AQ7 = Color.FromArgb(AQ7.A, AQ7.R, AQ7.G, value);
		}
	}

	public bool ExceedsW3CBrightnessThreshold => W3CBrightness > 125;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "G")]
	public byte G
	{
		get
		{
			return AQ7.G;
		}
		set
		{
			AQ7 = Color.FromArgb(AQ7.A, AQ7.R, value, AQ7.B);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hls")]
	public double HlsHue
	{
		get
		{
			return ((HLSColor)AQ7).H;
		}
		set
		{
			byte a = AQ7.A;
			HLSColor hLSColor = AQ7;
			hLSColor.H = value;
			AQ7 = hLSColor;
			AQ7.A = a;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hls")]
	public double HlsLightness
	{
		get
		{
			return ((HLSColor)AQ7).L;
		}
		set
		{
			byte a = AQ7.A;
			HLSColor hLSColor = AQ7;
			hLSColor.L = value;
			AQ7 = hLSColor;
			AQ7.A = a;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hls")]
	public double HlsSaturation
	{
		get
		{
			return ((HLSColor)AQ7).S;
		}
		set
		{
			byte a = AQ7.A;
			HLSColor hLSColor = AQ7;
			hLSColor.S = value;
			AQ7 = hLSColor;
			AQ7.A = a;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
	public double HsbBrightness
	{
		get
		{
			return ((HSBColor)AQ7).B;
		}
		set
		{
			byte a = AQ7.A;
			HSBColor hSBColor = AQ7;
			hSBColor.B = value;
			AQ7 = hSBColor;
			AQ7.A = a;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
	public double HsbHue
	{
		get
		{
			return ((HSBColor)AQ7).H;
		}
		set
		{
			byte a = AQ7.A;
			HSBColor hSBColor = AQ7;
			hSBColor.H = value;
			AQ7 = hSBColor;
			AQ7.A = a;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
	public double HsbSaturation
	{
		get
		{
			return ((HSBColor)AQ7).S;
		}
		set
		{
			byte a = AQ7.A;
			HSBColor hSBColor = AQ7;
			hSBColor.S = value;
			AQ7 = hSBColor;
			AQ7.A = a;
		}
	}

	public bool IsGrayscale => AQ7.R == AQ7.G && AQ7.G == AQ7.B;

	public bool IsLight => W3CBrightness > 178;

	public byte Luminance => (byte)(YQu(AQ7) * 255.0);

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "R")]
	public byte R
	{
		get
		{
			return AQ7.R;
		}
		set
		{
			AQ7 = Color.FromArgb(AQ7.A, value, AQ7.G, AQ7.B);
		}
	}

	public byte W3CBrightness => Convert.ToByte((double)(int)AQ7.R * 0.299 + (double)(int)AQ7.G * 0.587 + (double)(int)AQ7.B * 0.114);

	private UIColor(Color color)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		AQ7 = color;
	}

	private static byte MQ4(Color P_0)
	{
		return (byte)(0.2126 * (double)(int)P_0.R + 0.7152 * (double)(int)P_0.G + 0.0722 * (double)(int)P_0.B);
	}

	private static double YQu(Color P_0)
	{
		double num = (double)(int)P_0.R / 255.0;
		double num2 = (double)(int)P_0.G / 255.0;
		double num3 = (double)(int)P_0.B / 255.0;
		double num4 = ((num <= 0.03928) ? (num / 12.92) : Math.Pow((num + 0.055) / 1.055, 2.4));
		double num5 = ((num2 <= 0.03928) ? (num2 / 12.92) : Math.Pow((num2 + 0.055) / 1.055, 2.4));
		double num6 = ((num3 <= 0.03928) ? (num3 / 12.92) : Math.Pow((num3 + 0.055) / 1.055, 2.4));
		return 0.2126 * num4 + 0.7152 * num5 + 0.0722 * num6;
	}

	private static byte NQ2(string P_0)
	{
		if (P_0 != null)
		{
			int result;
			if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(942), StringComparison.Ordinal))
			{
				if (int.TryParse(P_0.Substring(0, P_0.Length - 1), out result))
				{
					return (byte)Math.Max(0.0, Math.Min(255.0, (double)result / 100.0 * 255.0));
				}
			}
			else if (int.TryParse(P_0, out result))
			{
				int num = 0;
				if (!M7I())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => (byte)Math.Max(0, Math.Min(255, result)), 
				};
			}
		}
		return 0;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static bool YQe(string P_0, bool P_1, out UIColor P_2)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			P_2 = new UIColor(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			return false;
		}
		bool flag = P_0.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106782), StringComparison.OrdinalIgnoreCase);
		string text = P_0;
		if (flag)
		{
			text = text.Substring(1);
		}
		if (text.Length == 3)
		{
			text = text.Substring(0, 1) + text.Substring(0, 1) + text.Substring(1, 1) + text.Substring(1, 1) + text.Substring(2, 1) + text.Substring(2, 1);
		}
		byte result5;
		byte result6;
		byte result7;
		if (text.Length == 8)
		{
			if (byte.TryParse(text.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result) && byte.TryParse(text.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result2) && byte.TryParse(text.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result3) && byte.TryParse(text.Substring(6, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result4))
			{
				P_2 = new UIColor(Color.FromArgb(result, result2, result3, result4));
				return true;
			}
		}
		else if (text.Length == 6 && byte.TryParse(text.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result5) && byte.TryParse(text.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result6) && byte.TryParse(text.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result7))
		{
			P_2 = new UIColor(Color.FromArgb(byte.MaxValue, result5, result6, result7));
			return true;
		}
		if (flag)
		{
			if (P_1)
			{
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106788), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106920));
			}
			P_2 = new UIColor(Color.FromArgb(byte.MaxValue, 0, 0, 0));
			return false;
		}
		int num = (P_0.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106934), StringComparison.Ordinal) ? 3 : (P_0.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106946), StringComparison.Ordinal) ? 4 : 0));
		if (num > 0)
		{
			Match match = null;
			switch (num)
			{
			case 3:
				match = Regex.Match(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106960));
				if (match != null && match.Groups != null && match.Groups.Count == num + 1)
				{
					P_2 = FromRgb(NQ2(match.Groups[1].Value), NQ2(match.Groups[2].Value), NQ2(match.Groups[3].Value));
					return true;
				}
				break;
			case 4:
			{
				match = Regex.Match(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107066));
				if (match != null && match.Groups != null && match.Groups.Count >= num + 1 && !string.IsNullOrEmpty(match.Groups[4].Value) && double.TryParse(match.Groups[4].Value, out var result8))
				{
					P_2 = FromArgb((byte)Math.Max(0.0, Math.Min(255.0, Math.Max(0.0, Math.Min(1.0, result8)) * 255.0)), NQ2(match.Groups[1].Value), NQ2(match.Groups[2].Value), NQ2(match.Groups[3].Value));
					return true;
				}
				break;
			}
			}
		}
		return TryFromName(P_0, out P_2);
	}

	public void AdaptToBackground(Color backColor, bool isHighContrast)
	{
		HLSColor hLSColor = backColor;
		AdaptToBackground(hLSColor.H, hLSColor.L, hLSColor.S, isHighContrast);
	}

	public void AdaptToBackground(double backColorHue, double backColorLightness, double backColorSaturation, bool isHighContrast)
	{
		if (AQ7.A <= 0)
		{
			return;
		}
		backColorHue = Math.Max(0.0, Math.Min(360.0, backColorHue));
		backColorLightness = Math.Max(0.0, Math.Min(1.0, backColorLightness));
		backColorSaturation = Math.Max(0.0, Math.Min(1.0, backColorSaturation));
		HLSColor hLSColor = AQ7;
		double h = hLSColor.H;
		double l = hLSColor.L;
		double s = hLSColor.S;
		double num = 0.25;
		double num2 = Math.Abs(82.0 / 85.0 - l);
		double num3 = Math.Max(0.0, 1.0 - s / num);
		double num4 = Math.Max(0.0, 1.0 - num2 / num) * num3;
		if (backColorLightness >= 0.5)
		{
			if (l >= 82.0 / 85.0)
			{
				double num5 = (1.0 - backColorLightness) / 0.03529411764705881;
				l = Math.Max(0.0, Math.Min(1.0, (l - 1.0) * num5 + 1.0));
			}
			else
			{
				l *= backColorLightness / (82.0 / 85.0);
			}
		}
		else if (l >= 82.0 / 85.0)
		{
			double num6 = (l - 1.0) / -0.03529411764705881;
			l = Math.Max(0.0, Math.Min(1.0, backColorLightness * num6));
		}
		else
		{
			double val = ((s < 0.2) ? 1.0 : ((s > 0.3) ? 0.0 : (1.0 - (s - 0.2) / 0.1)));
			double val2 = Math.Min(1.0, Math.Abs(h - 37.0) / 20.0);
			double num7 = Math.Max(val, val2);
			double num8 = ((backColorLightness - 1.0) * (2.0 / 3.0) / (82.0 / 85.0) + 1.0) * num7 + 2.0 / 3.0 * (1.0 - num7);
			l = ((!(l >= 2.0 / 3.0)) ? Math.Max(0.0, Math.Min(1.0, (num8 - 1.0) / (2.0 / 3.0) * l + 1.0)) : Math.Max(0.0, Math.Min(1.0, (num8 - backColorLightness) / -0.33333333333333337 * (l - 82.0 / 85.0) + backColorLightness)));
		}
		h = h * (1.0 - num3) + backColorHue * num3;
		s = s * (1.0 - num4) + backColorSaturation * num4;
		if (isHighContrast)
		{
			double num9 = ((l <= 0.3) ? 0.0 : ((l >= 0.7) ? 1.0 : ((l - 0.3) / 0.4)));
			l = Math.Max(0.0, Math.Min(1.0, num9 * (1.0 - s) + l * s));
		}
		AQ7 = FromAhls(AQ7.A, h, l, s).ToColor();
	}

	public void Darken(double percentage)
	{
		if (percentage < 0.0 || percentage > 1.0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107212));
		}
		HlsLightness *= 1.0 - percentage;
	}

	public bool Equals(Color obj)
	{
		return AQ7 == obj;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is UIColor))
		{
			return false;
		}
		UIColor uIColor = this;
		UIColor uIColor2 = (UIColor)obj;
		return uIColor.AQ7 == uIColor2.AQ7;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ahls")]
	public static UIColor FromAhls(byte alpha, double hue, double lightness, double saturation)
	{
		Color color = new HLSColor(hue, lightness, saturation);
		return new UIColor(Color.FromArgb(alpha, color.R, color.G, color.B));
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ahsb")]
	public static UIColor FromAhsb(byte alpha, double hue, double saturation, double brightness)
	{
		Color color = new HSBColor(hue, saturation, brightness);
		return new UIColor(Color.FromArgb(alpha, color.R, color.G, color.B));
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Argb")]
	public static UIColor FromArgb(byte alpha, byte red, byte green, byte blue)
	{
		return new UIColor(Color.FromArgb(alpha, red, green, blue));
	}

	public static UIColor FromColor(Color color)
	{
		return new UIColor(color);
	}

	public static UIColor FromColorComplement(Color color)
	{
		return FromColorComplement(color, color.A);
	}

	public static UIColor FromColorComplement(Color color, byte alpha)
	{
		return new UIColor(Color.FromArgb(alpha, (byte)(~color.R), (byte)(~color.G), (byte)(~color.B)));
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hls")]
	public static UIColor FromHls(double hue, double lightness, double saturation)
	{
		return new UIColor(new HLSColor(hue, lightness, saturation));
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
	public static UIColor FromHsb(double hue, double saturation, double brightness)
	{
		return new UIColor(new HSBColor(hue, saturation, brightness));
	}

	public static UIColor FromMix(Color color1, Color color2, double percentage)
	{
		byte r = (byte)Math.Round((double)(int)color1.R - (double)(color1.R - color2.R) * percentage, MidpointRounding.AwayFromZero);
		byte g = (byte)Math.Round((double)(int)color1.G - (double)(color1.G - color2.G) * percentage, MidpointRounding.AwayFromZero);
		byte b = (byte)Math.Round((double)(int)color1.B - (double)(color1.B - color2.B) * percentage, MidpointRounding.AwayFromZero);
		return new UIColor(Color.FromArgb(byte.MaxValue, r, g, b));
	}

	public static UIColor FromName(string name)
	{
		TryFromName(name, out var color);
		return color;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rgb")]
	public static UIColor FromRgb(byte red, byte green, byte blue)
	{
		return new UIColor(Color.FromArgb(byte.MaxValue, red, green, blue));
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static UIColor FromWebColor(string text)
	{
		YQe(text, _0020: true, out var result);
		return result;
	}

	public double GetContrastRatioWith(UIColor contrastingColor)
	{
		double val = YQu(AQ7);
		double val2 = YQu(contrastingColor.AQ7);
		return (Math.Max(val, val2) + 0.05) / (Math.Min(val, val2) + 0.05);
	}

	public override int GetHashCode()
	{
		return AQ7.GetHashCode();
	}

	public static Color[] GetStandardCustomColors()
	{
		return new Color[48]
		{
			Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 192, 192),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 224, 192),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, 192),
			Color.FromArgb(byte.MaxValue, 192, byte.MaxValue, 192),
			Color.FromArgb(byte.MaxValue, 192, byte.MaxValue, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 192, 192, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 192, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 224, 224, 224),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 128, 128),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 192, 128),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128),
			Color.FromArgb(byte.MaxValue, 128, byte.MaxValue, 128),
			Color.FromArgb(byte.MaxValue, 128, byte.MaxValue, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 128, 128, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 128, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 192, 192, 192),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 128, 0),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0),
			Color.FromArgb(byte.MaxValue, 0, byte.MaxValue, 0),
			Color.FromArgb(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 0, 0, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue),
			Color.FromArgb(byte.MaxValue, 128, 128, 128),
			Color.FromArgb(byte.MaxValue, 192, 0, 0),
			Color.FromArgb(byte.MaxValue, 192, 64, 0),
			Color.FromArgb(byte.MaxValue, 192, 192, 0),
			Color.FromArgb(byte.MaxValue, 0, 192, 0),
			Color.FromArgb(byte.MaxValue, 0, 192, 192),
			Color.FromArgb(byte.MaxValue, 0, 0, 192),
			Color.FromArgb(byte.MaxValue, 192, 0, 192),
			Color.FromArgb(byte.MaxValue, 64, 64, 64),
			Color.FromArgb(byte.MaxValue, 128, 0, 0),
			Color.FromArgb(byte.MaxValue, 128, 64, 0),
			Color.FromArgb(byte.MaxValue, 128, 128, 0),
			Color.FromArgb(byte.MaxValue, 0, 128, 0),
			Color.FromArgb(byte.MaxValue, 0, 128, 128),
			Color.FromArgb(byte.MaxValue, 0, 0, 128),
			Color.FromArgb(byte.MaxValue, 128, 0, 128),
			Color.FromArgb(byte.MaxValue, 0, 0, 0),
			Color.FromArgb(byte.MaxValue, 64, 0, 0),
			Color.FromArgb(byte.MaxValue, 128, 64, 64),
			Color.FromArgb(byte.MaxValue, 64, 64, 0),
			Color.FromArgb(byte.MaxValue, 0, 64, 0),
			Color.FromArgb(byte.MaxValue, 0, 64, 64),
			Color.FromArgb(byte.MaxValue, 0, 0, 64),
			Color.FromArgb(byte.MaxValue, 64, 0, 64)
		};
	}

	public static Color[] GetSystemColors()
	{
		return new Color[30]
		{
			SystemColors.ActiveBorderColor,
			SystemColors.ActiveCaptionColor,
			SystemColors.ActiveCaptionTextColor,
			SystemColors.AppWorkspaceColor,
			SystemColors.ControlColor,
			SystemColors.ControlDarkColor,
			SystemColors.ControlDarkDarkColor,
			SystemColors.ControlLightColor,
			SystemColors.ControlLightLightColor,
			SystemColors.ControlTextColor,
			SystemColors.DesktopColor,
			SystemColors.GradientActiveCaptionColor,
			SystemColors.GradientInactiveCaptionColor,
			SystemColors.GrayTextColor,
			SystemColors.HighlightColor,
			SystemColors.HighlightTextColor,
			SystemColors.HotTrackColor,
			SystemColors.InactiveBorderColor,
			SystemColors.InactiveCaptionColor,
			SystemColors.InactiveCaptionTextColor,
			SystemColors.InfoColor,
			SystemColors.InfoTextColor,
			SystemColors.MenuBarColor,
			SystemColors.MenuColor,
			SystemColors.MenuHighlightColor,
			SystemColors.MenuTextColor,
			SystemColors.ScrollBarColor,
			SystemColors.WindowColor,
			SystemColors.WindowFrameColor,
			SystemColors.WindowTextColor
		};
	}

	public static Color GetTintedColor(Color baseColor, Color tintColor)
	{
		if (baseColor.A == 0 || tintColor.A == 0)
		{
			return baseColor;
		}
		double num = (int)MQ4(baseColor);
		int num2 = ((!(num < 128.0)) ? 255 : 0);
		double num3 = Math.Abs((num - 128.0) / 128.0);
		return Color.FromArgb(baseColor.A, (byte)(tintColor.R + (int)((double)(num2 - tintColor.R) * num3)), (byte)(tintColor.G + (int)((double)(num2 - tintColor.G) * num3)), (byte)(tintColor.B + (int)((double)(num2 - tintColor.B) * num3)));
	}

	public static Color[] GetWebColors()
	{
		return new Color[139]
		{
			Colors.Transparent,
			Colors.Black,
			Colors.DimGray,
			Colors.Gray,
			Colors.DarkGray,
			Colors.Silver,
			Colors.LightGray,
			Colors.Gainsboro,
			Colors.WhiteSmoke,
			Colors.White,
			Colors.RosyBrown,
			Colors.IndianRed,
			Colors.Brown,
			Colors.Firebrick,
			Colors.LightCoral,
			Colors.Maroon,
			Colors.DarkRed,
			Colors.Red,
			Colors.Snow,
			Colors.MistyRose,
			Colors.Salmon,
			Colors.Tomato,
			Colors.DarkSalmon,
			Colors.Coral,
			Colors.OrangeRed,
			Colors.LightSalmon,
			Colors.Sienna,
			Colors.SeaShell,
			Colors.Chocolate,
			Colors.SaddleBrown,
			Colors.SandyBrown,
			Colors.PeachPuff,
			Colors.Peru,
			Colors.Linen,
			Colors.Bisque,
			Colors.DarkOrange,
			Colors.BurlyWood,
			Colors.Tan,
			Colors.AntiqueWhite,
			Colors.NavajoWhite,
			Colors.BlanchedAlmond,
			Colors.PapayaWhip,
			Colors.Moccasin,
			Colors.Orange,
			Colors.Wheat,
			Colors.OldLace,
			Colors.FloralWhite,
			Colors.DarkGoldenrod,
			Colors.Cornsilk,
			Colors.Gold,
			Colors.Khaki,
			Colors.LemonChiffon,
			Colors.PaleGoldenrod,
			Colors.DarkKhaki,
			Colors.Beige,
			Colors.LightGoldenrodYellow,
			Colors.Olive,
			Colors.Yellow,
			Colors.LightYellow,
			Colors.Ivory,
			Colors.OliveDrab,
			Colors.YellowGreen,
			Colors.DarkOliveGreen,
			Colors.GreenYellow,
			Colors.Chartreuse,
			Colors.LawnGreen,
			Colors.DarkSeaGreen,
			Colors.ForestGreen,
			Colors.LimeGreen,
			Colors.PaleGreen,
			Colors.DarkGreen,
			Colors.Green,
			Colors.Lime,
			Colors.Honeydew,
			Colors.SeaGreen,
			Colors.MediumSeaGreen,
			Colors.SpringGreen,
			Colors.MintCream,
			Colors.MediumSpringGreen,
			Colors.MediumAquamarine,
			Colors.Aquamarine,
			Colors.Turquoise,
			Colors.LightSeaGreen,
			Colors.MediumTurquoise,
			Colors.DarkSlateGray,
			Colors.PaleTurquoise,
			Colors.Teal,
			Colors.DarkCyan,
			Colors.Aqua,
			Colors.Cyan,
			Colors.LightCyan,
			Colors.Azure,
			Colors.DarkTurquoise,
			Colors.CadetBlue,
			Colors.PowderBlue,
			Colors.LightBlue,
			Colors.DeepSkyBlue,
			Colors.SkyBlue,
			Colors.LightSkyBlue,
			Colors.SteelBlue,
			Colors.AliceBlue,
			Colors.DodgerBlue,
			Colors.SlateGray,
			Colors.LightSlateGray,
			Colors.LightSteelBlue,
			Colors.CornflowerBlue,
			Colors.RoyalBlue,
			Colors.MidnightBlue,
			Colors.Lavender,
			Colors.Navy,
			Colors.DarkBlue,
			Colors.MediumBlue,
			Colors.Blue,
			Colors.GhostWhite,
			Colors.SlateBlue,
			Colors.DarkSlateBlue,
			Colors.MediumSlateBlue,
			Colors.MediumPurple,
			Colors.BlueViolet,
			Colors.Indigo,
			Colors.DarkOrchid,
			Colors.DarkViolet,
			Colors.MediumOrchid,
			Colors.Thistle,
			Colors.Plum,
			Colors.Violet,
			Colors.Purple,
			Colors.DarkMagenta,
			Colors.Magenta,
			Colors.Fuchsia,
			Colors.Orchid,
			Colors.MediumVioletRed,
			Colors.DeepPink,
			Colors.HotPink,
			Colors.LavenderBlush,
			Colors.PaleVioletRed,
			Colors.Crimson,
			Colors.Pink,
			Colors.LightPink
		};
	}

	public void Grayscale()
	{
		byte luminance = Luminance;
		AQ7 = Color.FromArgb(AQ7.A, luminance, luminance, luminance);
	}

	public void Lighten(double percentage)
	{
		if (percentage < 0.0 || percentage > 1.0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107212));
		}
		HlsLightness += (1.0 - HlsLightness) * percentage;
	}

	public void Tint(Color tintColor)
	{
		AQ7 = GetTintedColor(AQ7, tintColor);
	}

	public Color ToColor()
	{
		return AQ7;
	}

	public string ToWebColor()
	{
		return ToWebColor(AQ7.A < byte.MaxValue);
	}

	public string ToWebColor(bool includeAlpha)
	{
		string text = AQ7.A.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107236), CultureInfo.InvariantCulture);
		string text2 = AQ7.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107236), CultureInfo.InvariantCulture);
		string text3 = AQ7.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107236), CultureInfo.InvariantCulture);
		string text4 = AQ7.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107236), CultureInfo.InvariantCulture);
		if (!includeAlpha)
		{
			text = string.Empty;
		}
		else if (text.Length == 1)
		{
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242) + text;
		}
		if (text2.Length == 1)
		{
			text2 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242) + text2;
		}
		if (text3.Length == 1)
		{
			text3 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242) + text3;
		}
		if (text4.Length == 1)
		{
			text4 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242) + text4;
		}
		return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107248), text, text2, text3, text4).ToUpperInvariant();
	}

	public override string ToString()
	{
		return ToWebColor();
	}

	public static bool TryFromName(string name, out UIColor color)
	{
		PropertyInfo[] properties = typeof(Colors).GetProperties();
		PropertyInfo[] array = properties;
		int num = 0;
		MethodInfo getMethod = default(MethodInfo);
		int num3 = default(int);
		while (num < array.Length)
		{
			PropertyInfo propertyInfo = array[num];
			bool flag = string.Compare(propertyInfo.Name, name, StringComparison.OrdinalIgnoreCase) == 0 && propertyInfo.PropertyType == typeof(Color);
			int num2 = 0;
			if (!M7I())
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					color = new UIColor((Color)getMethod.Invoke(null, null));
					return true;
				}
				if (!flag)
				{
					num++;
					break;
				}
				getMethod = propertyInfo.GetGetMethod();
				num2 = 1;
				if (!M7I())
				{
					num2 = num3;
				}
			}
		}
		color = new UIColor(Color.FromArgb(byte.MaxValue, 0, 0, 0));
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public static bool TryFromWebColor(string text, out UIColor color)
	{
		return YQe(text, _0020: false, out color);
	}

	public static bool operator ==(UIColor left, UIColor right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(UIColor left, UIColor right)
	{
		return !(left == right);
	}

	internal static bool M7I()
	{
		return T7r == null;
	}

	internal static object Y7D()
	{
		return T7r;
	}
}
