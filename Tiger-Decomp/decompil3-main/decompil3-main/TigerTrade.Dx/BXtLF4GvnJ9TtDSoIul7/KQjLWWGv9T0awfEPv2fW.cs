using System;
using System.Collections.Generic;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.DirectWrite;
using SharpDX.Mathematics.Interop;
using SuIZeDGv88DJtpVQTnxc;
using TigerTrade.Dx;

namespace BXtLF4GvnJ9TtDSoIul7;

internal class KQjLWWGv9T0awfEPv2fW : IDisposable
{
	private readonly Factory i3CGvBy34xZ;

	private readonly List<string> fNOGvaEMfmo;

	private readonly ggbkDsGv7puxxSt1Wrqc k4nGviShvXb;

	private readonly FontCollection RgYGvlp6mst;

	private readonly FontCollection cahGv4TeUah;

	private readonly Dictionary<string, FontFamily> rOeGvDVTypA;

	private readonly Dictionary<(string, bool), FontFace> tb1Gvb5l8Vo;

	public static readonly KQjLWWGv9T0awfEPv2fW wRWGvNkVkDn;

	private static KQjLWWGv9T0awfEPv2fW hpjWEQkEUebDBXFDbj66;

	public IReadOnlyCollection<string> Fonts => fNOGvaEMfmo;

	private KQjLWWGv9T0awfEPv2fW()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
		i3CGvBy34xZ = new Factory();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_dca72933032c4a8e93671b633cde2f65 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 2:
				RgYGvlp6mst = new FontCollection(i3CGvBy34xZ, k4nGviShvXb, BXPfTgkEVeK8Cgupe02N(Ee1pdAkEZPA1j2nk8tKy(k4nGviShvXb)));
				tb1Gvb5l8Vo = new Dictionary<(string, bool), FontFace>();
				cahGv4TeUah = i3CGvBy34xZ.GetSystemFontCollection(sWXcY2kEC87tMT7sAswt(true));
				num = 3;
				break;
			case 1:
				CyJguMkErbr8e6CUH5lu(fNOGvaEMfmo);
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ddce9f0563524ee592adad7a07e5ceaf == 0)
				{
					num = 4;
				}
				break;
			case 3:
			{
				rOeGvDVTypA = new Dictionary<string, FontFamily>();
				FontCollection rgYGvlp6mst = RgYGvlp6mst;
				IDictionary<string, FontFamily> families = rOeGvDVTypA;
				XSQGvo4i6hd(rgYGvlp6mst, in families);
				FontCollection fontCollection = cahGv4TeUah;
				families = rOeGvDVTypA;
				XSQGvo4i6hd(fontCollection, in families);
				fNOGvaEMfmo = new List<string>(rOeGvDVTypA.Keys);
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_432f46d1d7314c65a511e6124fe643b3 != 0)
				{
					num = 1;
				}
				break;
			}
			default:
				k4nGviShvXb = new ggbkDsGv7puxxSt1Wrqc(i3CGvBy34xZ);
				num = 2;
				break;
			}
		}
	}

	public FontFamily CpyGvGevEPI(string P_0)
	{
		if (rOeGvDVTypA.TryGetValue(P_0, out var value))
		{
			return value;
		}
		return rOeGvDVTypA[vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0xECA3F28 ^ 0xECA3806)];
	}

	public FontFace GYJGvYymN3K(XFont P_0)
	{
		int num = 1;
		int num2 = num;
		FontFace value = default(FontFace);
		FontFamily fontFamily = default(FontFamily);
		FontWeight weight = default(FontWeight);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return value;
			default:
				fontFamily = CpyGvGevEPI((string)AK3V7akEKXZGxlTU6YIO(P_0));
				if (!tb1Gvb5l8Vo.TryGetValue(((string)AK3V7akEKXZGxlTU6YIO(P_0), P_0.Bold), out value))
				{
					weight = (P_0.Bold ? FontWeight.Bold : FontWeight.Normal);
					num2 = 3;
					break;
				}
				goto case 2;
			case 3:
				value = new FontFace(fontFamily.GetFirstMatchingFont(weight, FontStretch.Normal, FontStyle.Normal));
				tb1Gvb5l8Vo.Add(((string)AK3V7akEKXZGxlTU6YIO(P_0), P_0.Bold), value);
				num2 = 2;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_de21cd78737049749dce66b024a96c1f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				value = null;
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_05692657bf2742bd873f9ce176ecb3de == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
		TNymZMkEmygbptr5Jgqa(i3CGvBy34xZ);
		k4nGviShvXb.Dispose();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_96140636b3f14f3d80555da48eaec1f2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				gJQEBxkEhYqxOWJeGy7I(tb1Gvb5l8Vo);
				int num2 = 2;
				num = num2;
				continue;
			}
			case 2:
				zJS8wykEwY7lLjxrQlCy(rOeGvDVTypA);
				AKODJakE74yhMNMoNHWM(fNOGvaEMfmo);
				return;
			}
			RgYGvlp6mst.Dispose();
			cahGv4TeUah.Dispose();
			num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ddce9f0563524ee592adad7a07e5ceaf == 0)
			{
				num = 1;
			}
		}
	}

	private void XSQGvo4i6hd(FontCollection P_0, in IDictionary<string, FontFamily> families)
	{
		int num = 3;
		int num3 = default(int);
		string key = default(string);
		FontFamily fontFamily = default(FontFamily);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 1:
					num3++;
					goto case 2;
				default:
					families.Add(key, fontFamily);
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71862513ffe24172acf3377a71840acf != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (num3 >= f1LiC6kE88cs8QGSKVDd(P_0))
					{
						goto end_IL_0012;
					}
					fontFamily = P_0.GetFontFamily(num3);
					key = fontFamily.FamilyNames.GetString(0);
					if (families.ContainsKey(key))
					{
						fontFamily.Dispose();
						goto case 1;
					}
					goto default;
				case 3:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_c2e150130d354ba88208e31c0cb582bd == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	static KQjLWWGv9T0awfEPv2fW()
	{
		RvqnhQkEAMrYm7Aox4fC();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_d618dd8bd4644035a29fb0441cb43344 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		wRWGvNkVkDn = new KQjLWWGv9T0awfEPv2fW();
	}

	internal static object Ee1pdAkEZPA1j2nk8tKy(object P_0)
	{
		return ((ggbkDsGv7puxxSt1Wrqc)P_0).Key;
	}

	internal static DataPointer BXPfTgkEVeK8Cgupe02N(object P_0)
	{
		return (DataStream)P_0;
	}

	internal static RawBool sWXcY2kEC87tMT7sAswt(bool P_0)
	{
		return P_0;
	}

	internal static void CyJguMkErbr8e6CUH5lu(object P_0)
	{
		((List<string>)P_0).Sort();
	}

	internal static bool tw2WMmkETreDu0XD7n68()
	{
		return hpjWEQkEUebDBXFDbj66 == null;
	}

	internal static KQjLWWGv9T0awfEPv2fW eG2RD2kEyQeyiQJHibRN()
	{
		return hpjWEQkEUebDBXFDbj66;
	}

	internal static object AK3V7akEKXZGxlTU6YIO(object P_0)
	{
		return ((XFont)P_0).Name;
	}

	internal static void TNymZMkEmygbptr5Jgqa(object P_0)
	{
		((DisposeBase)P_0).Dispose();
	}

	internal static void gJQEBxkEhYqxOWJeGy7I(object P_0)
	{
		((Dictionary<(string, bool), FontFace>)P_0).Clear();
	}

	internal static void zJS8wykEwY7lLjxrQlCy(object P_0)
	{
		((Dictionary<string, FontFamily>)P_0).Clear();
	}

	internal static void AKODJakE74yhMNMoNHWM(object P_0)
	{
		((List<string>)P_0).Clear();
	}

	internal static int f1LiC6kE88cs8QGSKVDd(object P_0)
	{
		return ((FontCollection)P_0).FontFamilyCount;
	}

	internal static void RvqnhQkEAMrYm7Aox4fC()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}
}
