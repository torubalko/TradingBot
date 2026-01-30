using System;
using System.Globalization;
using System.Windows.Media;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;

namespace TigerTrade.Dx;

public struct XColor : IXmlSerializable
{
	private byte _a;

	private byte _r;

	private byte _g;

	private byte _b;

	internal int Hash;

	internal float R;

	internal float G;

	internal float B;

	internal float A;

	internal static object tValyEkEa29wQFi8BI4j;

	public bool IsTransparent => _a == 0;

	public double Sqrt { get; private set; }

	public byte Alpha => _a;

	internal bool IsValid { get; private set; }

	public static XColor IncorrectValue => new XColor(66, 66, 66, 66);

	public XColor(Color color)
	{
		kB9vr5kE4EeXi6Oaa20i();
		this = new XColor(color.A, color.R, color.G, color.B);
	}

	public XColor(byte a, Color color)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		this = new XColor(a, color.R, color.G, color.B);
	}

	public XColor(byte a, byte r, byte g, byte b)
	{
		kB9vr5kE4EeXi6Oaa20i();
		int num;
		if (a + r + g + b == 0)
		{
			_a = 0;
			_r = byte.MaxValue;
			_g = byte.MaxValue;
			num = 2;
			goto IL_0009;
		}
		goto IL_00bc;
		IL_00bc:
		_a = a;
		num = 5;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				Sqrt = Math.Sqrt(_r * _r + _g * _g + _b * _b);
				num2 = 7;
				goto IL_0005;
			case 1:
				Hash = (_a << 24) | (_r << 16) | (_g << 8) | _b;
				R = (float)(int)_r / 255f;
				G = (float)(int)_g / 255f;
				B = (float)(int)_b / 255f;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a37a4622ccdb43ca9169ef0d80d56ae1 == 0)
				{
					num = 0;
				}
				continue;
			case 6:
				break;
			default:
				A = (float)(int)_a / 255f;
				num = 4;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_d618dd8bd4644035a29fb0441cb43344 == 0)
				{
					num = 4;
				}
				continue;
			case 7:
				IsValid = true;
				return;
			case 3:
				_g = g;
				_b = b;
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_432f46d1d7314c65a511e6124fe643b3 == 0)
				{
					num = 1;
				}
				continue;
			case 5:
				_r = r;
				num2 = 3;
				goto IL_0005;
			case 2:
				{
					_b = byte.MaxValue;
					goto case 1;
				}
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		goto IL_00bc;
	}

	public override int GetHashCode()
	{
		return Hash;
	}

	public static implicit operator Color(XColor color)
	{
		return Color.FromArgb(color._a, color._r, color._g, color._b);
	}

	public static implicit operator XColor(Color color)
	{
		return new XColor(color);
	}

	public static bool operator ==(XColor color1, XColor color2)
	{
		if (color1._r != color2._r)
		{
			return false;
		}
		if (color1._g != color2._g)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_864675f4630f4f79a61c0e443925db5c != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => false, 
			};
		}
		if (color1._b != color2._b)
		{
			return false;
		}
		if (color1._a != color2._a)
		{
			return false;
		}
		return true;
	}

	public static bool operator !=(XColor color1, XColor color2)
	{
		return !(color1 == color2);
	}

	public static XColor FromArgb(byte a, byte r, byte g, byte b)
	{
		return new XColor(a, r, g, b);
	}

	public XColor ChangeOpacity(decimal value, decimal maxValue)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(maxValue == 0m))
				{
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_3eb68d8d5ff548b8b5f6ee0645c6cc4e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00d8;
			case 2:
				if (!(value == maxValue))
				{
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00d8;
			default:
				{
					decimal num3 = 245m / maxValue * value;
					num3 = num3 + 20m - num3 % 30m;
					return new XColor((byte)xibiEhkEDsxmlcEyGLtt(num3, 230m), _r, _g, _b);
				}
				IL_00d8:
				return new XColor(byte.MaxValue, _r, _g, _b);
			}
		}
	}

	public XColor ChangeOpacity(decimal value, decimal maxValue, XColor background)
	{
		if (value == maxValue || zMruGKkEbm2wYhPQFjyP(maxValue, 0m))
		{
			return new XColor(byte.MaxValue, _r, _g, _b);
		}
		decimal num = kPjLIVkENDoOVunZcKbo(245m, maxValue) * value;
		int num2 = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_b749e1546471496da8da7b839f969bb6 != 0)
		{
			num2 = 0;
		}
		decimal num3 = default(decimal);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return new XColor(byte.MaxValue, YcIgPYkE5pYBlUd7EjLN(vRKrPQkE1KTnaFsOGLks(_r, num) + (decimal)background._r * num3), YcIgPYkE5pYBlUd7EjLN(b82a5dkESRdkhGO2rfKw(_g) * num + b82a5dkESRdkhGO2rfKw(background._g) * num3), (byte)(b82a5dkESRdkhGO2rfKw(_b) * num + (decimal)background._b * num3));
			}
			num = kPjLIVkENDoOVunZcKbo(Math.Min(num + 20m - num % 30m, 230m), 255m);
			num3 = FYIq0ukEkpbBqc5cycD7(1m, num);
			num2 = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_435adc9cca494f0c843e4414401f799f == 0)
			{
				num2 = 1;
			}
		}
	}

	public XColor ChangeOpacity(long value, long maxValue, XColor background)
	{
		if (value != maxValue && maxValue != 0L)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71bb8832f147473987544a7fa3578a88 != 0)
			{
				num = 1;
			}
			double num3 = default(double);
			while (true)
			{
				switch (num)
				{
				case 1:
					num3 = 245.0 / (double)maxValue * (double)value;
					num3 = zM9PrwkExMyT2K323Sti(num3 + 20.0 - num3 % 30.0, 230.0) / 255.0;
					num = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dd11dc8fd7944dd1aa43a7ff9cc7db54 == 0)
					{
						num = 0;
					}
					break;
				default:
				{
					double num2 = 1.0 - num3;
					return new XColor(byte.MaxValue, (byte)((double)(int)_r * num3 + (double)(int)background._r * num2), (byte)((double)(int)_g * num3 + (double)(int)background._g * num2), (byte)((double)(int)_b * num3 + (double)(int)background._b * num2));
				}
				}
			}
		}
		return new XColor(byte.MaxValue, _r, _g, _b);
	}

	private static void Write(XmlWriter writer, Color color)
	{
		writer.WriteAttributeString((string)yyhaUEkELgvlRNHEZAA3(-225822163 ^ -225821387), ((color.A << 24) | (color.R << 16) | (color.G << 8) | color.B).ToString((string)yyhaUEkELgvlRNHEZAA3(-203064540 ^ -203064318)));
	}

	private static Color Read(XmlReader reader)
	{
		int num = NpEZhikEXHolydN4QYIC(WtnR7qkEeSYy3U33AA0X(reader, yyhaUEkELgvlRNHEZAA3(0x68C7EAE6 ^ 0x68C7EDFE)), NumberStyles.HexNumber, IZ8gu7kEsBjpfMovgAmF());
		return Color.FromArgb((byte)(num >> 24), (byte)(num >> 16), (byte)(num >> 8), (byte)num);
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		int num = 5;
		Color color = default(Color);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_a = 0;
					_r = byte.MaxValue;
					num = 6;
					break;
				case 3:
					Hash = (_a << 24) | (_r << 16) | (_g << 8) | _b;
					R = (float)(int)_r / 255f;
					G = (float)(int)_g / 255f;
					B = (float)(int)_b / 255f;
					A = (float)(int)_a / 255f;
					Sqrt = Math.Sqrt(_r * _r + _g * _g + _b * _b);
					num2 = 6;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_4244154882d84aceb472cc9692dc853e == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					_a = color.A;
					_r = color.R;
					_g = color.G;
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_1ecf08483ad04bb2aa32d881f01b6bdc == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_b = color.B;
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_0dddf5ef66c34125ab2fb5b0d18a207d == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					_g = byte.MaxValue;
					_b = byte.MaxValue;
					num2 = 3;
					continue;
				case 1:
					if (_a + _r + _g + _b == 0)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 5:
					color = Read(reader);
					num = 4;
					break;
				case 7:
					IsValid = true;
					return;
				}
				break;
			}
		}
	}

	public void WriteXml(XmlWriter writer)
	{
		Color color = x5Bl5vkEcFF5l2MtOPyj(_a, _r, _g, _b);
		iOFJ9OkEj864ajvq2eKc(writer, color);
	}

	static XColor()
	{
		RV6RVTkEEZ87PJMqJipa();
		CylP5TkEQjmKFGVNpFoa();
	}

	internal static bool lPgv2jkEiYRORbqGwOvA()
	{
		return tValyEkEa29wQFi8BI4j == null;
	}

	internal static object X8fFmjkElWvNyyFJ00df()
	{
		return tValyEkEa29wQFi8BI4j;
	}

	internal static void kB9vr5kE4EeXi6Oaa20i()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static decimal xibiEhkEDsxmlcEyGLtt(decimal P_0, decimal P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool zMruGKkEbm2wYhPQFjyP(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static decimal kPjLIVkENDoOVunZcKbo(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static decimal FYIq0ukEkpbBqc5cycD7(decimal P_0, decimal P_1)
	{
		return P_0 - P_1;
	}

	internal static decimal vRKrPQkE1KTnaFsOGLks(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static byte YcIgPYkE5pYBlUd7EjLN(decimal P_0)
	{
		return (byte)P_0;
	}

	internal static decimal b82a5dkESRdkhGO2rfKw(byte P_0)
	{
		return P_0;
	}

	internal static double zM9PrwkExMyT2K323Sti(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object yyhaUEkELgvlRNHEZAA3(int P_0)
	{
		return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
	}

	internal static object WtnR7qkEeSYy3U33AA0X(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static object IZ8gu7kEsBjpfMovgAmF()
	{
		return NumberFormatInfo.InvariantInfo;
	}

	internal static int NpEZhikEXHolydN4QYIC(object P_0, NumberStyles P_1, object P_2)
	{
		return int.Parse((string)P_0, P_1, (IFormatProvider)P_2);
	}

	internal static Color x5Bl5vkEcFF5l2MtOPyj(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static void iOFJ9OkEj864ajvq2eKc(object P_0, Color color)
	{
		Write((XmlWriter)P_0, color);
	}

	internal static void RV6RVTkEEZ87PJMqJipa()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}

	internal static void CylP5TkEQjmKFGVNpFoa()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}
}
