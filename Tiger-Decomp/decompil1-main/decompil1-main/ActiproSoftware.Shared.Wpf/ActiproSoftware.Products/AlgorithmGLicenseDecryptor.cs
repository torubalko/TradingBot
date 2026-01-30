using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

internal class AlgorithmGLicenseDecryptor
{
	[Serializable]
	[SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "Typical constructors are not used.")]
	[SuppressMessage("Microsoft.Design", "CA1064:ExceptionsShouldBePublic", Justification = "Exception is caught and handled internally.")]
	internal class LicenseException : ApplicationException
	{
		private int I62;

		internal static LicenseException P6S;

		internal int ExceptionType => I62;

		internal LicenseException(int exceptionType)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
			I62 = exceptionType;
		}

		internal static bool N6B()
		{
			return P6S == null;
		}

		internal static LicenseException N6A()
		{
			return P6S;
		}
	}

	internal enum LicenseExceptionType
	{
		None = 0,
		Other = 1,
		InvalidLicenseKeyLength = 2,
		InvalidLicenseKeyVersion = 3,
		InvalidProductCode = 4,
		InvalidLicenseType = 5,
		InvalidLicensee = 6,
		InvalidPlatform = 7,
		InvalidVersionNumber = 8,
		ConflictingProductCode = 20,
		ConflictingVersionNumber = 21,
		FailedChecksum = 30,
		DesignModeProhibited = 40,
		LicenseKeyDateTampering = 41,
		UnlicensedProduct = 42
	}

	internal enum LicenseUsageAllowed
	{
		All,
		Invalid,
		Invalid2,
		RuntimeOnly
	}

	private DateTime Ial;

	private byte vaA;

	private string daC;

	private string RaY;

	private AssemblyLicenseType VaI;

	private byte Oax;

	private byte Nar;

	private ushort HaZ;

	private AssemblyPlatform jan;

	private AlgorithmGLicenseProductCodes Iaa;

	private LicenseUsageAllowed Faq;

	private static byte[] LaW;

	private static byte[] DaU;

	private static byte[] DaH;

	private static byte[] ra6;

	private static byte[] RaV;

	private static byte[] ka5;

	private static byte[] IaR;

	private static byte[] uaE;

	private static byte[] pas;

	private static byte[] taL;

	internal static AlgorithmGLicenseDecryptor H1T;

	internal DateTime Date
	{
		get
		{
			return Ial;
		}
		set
		{
			Ial = value;
			DateTime dateTime = new DateTime(2002, 1, 1);
			byte[] array = new byte[12];
			PaQ(RaY, array);
			ia7(array, IaR, (uint)(Ial - dateTime).Days);
			VaO(array);
		}
	}

	internal byte LicenseCount => vaA;

	internal string Licensee => daC;

	internal string LicenseKey => RaY;

	internal AssemblyLicenseType LicenseType => VaI;

	internal byte MajorVersion => Oax;

	internal byte MinorVersion => Nar;

	internal ushort OrganizationID
	{
		get
		{
			return HaZ;
		}
		set
		{
			HaZ = value;
			byte[] array = new byte[12];
			PaQ(RaY, array);
			ia7(array, uaE, HaZ);
			VaO(array);
		}
	}

	internal AssemblyPlatform Platform => jan;

	internal AlgorithmGLicenseProductCodes ProductCodes => Iaa;

	internal LicenseUsageAllowed UsageAllowed
	{
		get
		{
			return Faq;
		}
		set
		{
			Faq = value;
			byte[] array = new byte[12];
			PaQ(RaY, array);
			ia7(array, taL, (uint)Faq);
			VaO(array);
		}
	}

	internal AlgorithmGLicenseDecryptor(string licensee, string licenseKey)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		daC = licensee;
		RaY = Ga4(licenseKey);
		Sa2();
	}

	private static string Ga4(string P_0)
	{
		if (P_0 == null)
		{
			yak(LicenseExceptionType.InvalidLicenseKeyLength);
		}
		string text = string.Empty;
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			char c2 = c;
			char c3 = c2;
			if (c3 != ' ' && c3 != '-')
			{
				text += c;
			}
		}
		if (text.Length != 25)
		{
			yak(LicenseExceptionType.InvalidLicenseKeyLength);
		}
		if (!text.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(928), StringComparison.Ordinal))
		{
			yak(LicenseExceptionType.InvalidLicenseKeyVersion);
		}
		return text;
	}

	private static uint Rau(uint P_0, byte[] P_1, uint P_2)
	{
		uint num = P_0 & 0xFFFF;
		uint num2 = (P_0 >> 16) & 0xFFFF;
		uint num3 = 0u;
		if (P_1 == null)
		{
			return 1u;
		}
		while (P_2 != 0)
		{
			uint num4 = ((P_2 < 5552) ? P_2 : 5552u);
			P_2 -= num4;
			while (true)
			{
				switch (num4)
				{
				default:
				{
					int num5 = 0;
					while (num5 < 16)
					{
						num += P_1[num3];
						num2 += num;
						num5++;
						num3++;
					}
					num4 -= 16;
					continue;
				}
				case 1u:
				case 2u:
				case 3u:
				case 4u:
				case 5u:
				case 6u:
				case 7u:
				case 8u:
				case 9u:
				case 10u:
				case 11u:
				case 12u:
				case 13u:
				case 14u:
				case 15u:
					do
					{
						num += P_1[num3];
						num3++;
						num2 += num;
					}
					while (--num4 != 0);
					break;
				case 0u:
					break;
				}
				break;
			}
			num %= 65521;
			num2 %= 65521;
		}
		return (num2 << 16) | num;
	}

	private void Sa2()
	{
		la0();
		DateTime dateTime = new DateTime(2002, 1, 1);
		byte[] array = new byte[12];
		PaQ(RaY, array);
		uint iaa = vae(array, LaW);
		Iaa = (AlgorithmGLicenseProductCodes)iaa;
		iaa = vae(array, pas);
		ia7(array, pas, 0u);
		if (iaa != gao(LicenseKey, Iaa, array))
		{
			yak(LicenseExceptionType.FailedChecksum);
		}
		iaa = vae(array, DaU);
		Oax = (byte)(iaa / 10);
		Nar = (byte)(iaa % 10);
		iaa = vae(array, DaH);
		VaI = (AssemblyLicenseType)iaa;
		iaa = vae(array, ra6);
		char c = (char)iaa;
		iaa = vae(array, RaV);
		vaA = (byte)iaa;
		iaa = vae(array, ka5);
		jan = (AssemblyPlatform)iaa;
		iaa = vae(array, uaE);
		HaZ = (ushort)iaa;
		iaa = vae(array, IaR);
		Ial = dateTime.AddDays(iaa);
		iaa = vae(array, taL);
		Faq = (LicenseUsageAllowed)iaa;
		if ((uint)Iaa < 1u || (uint)Iaa > 1048575u)
		{
			yak(LicenseExceptionType.InvalidProductCode);
		}
		if (Oax < 0 || Oax > 51 || Nar < 0 || Nar > 9)
		{
			yak(LicenseExceptionType.InvalidVersionNumber);
		}
		if ((byte)VaI < 1 || (byte)VaI > 4)
		{
			yak(LicenseExceptionType.InvalidLicenseType);
		}
		if ((byte)jan < 1 || (byte)jan > 6)
		{
			yak(LicenseExceptionType.InvalidPlatform);
		}
		string text = Oax.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129274), CultureInfo.InvariantCulture) + Nar.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242), CultureInfo.InvariantCulture);
		if (RaY.Substring(3, 3) != text)
		{
			yak(LicenseExceptionType.ConflictingVersionNumber);
		}
		if (VaI == AssemblyLicenseType.Full && (daC == null || daC.Length == 0 || !daC.StartsWith(c.ToString(), StringComparison.OrdinalIgnoreCase)))
		{
			yak(LicenseExceptionType.InvalidLicensee);
		}
	}

	private static uint vae(byte[] P_0, byte[] P_1)
	{
		uint num = 0u;
		for (int i = 0; i < P_1.Length; i++)
		{
			byte b = P_1[i];
			byte b2 = (byte)(1 << 7 - b % 8);
			if ((P_0[b / 8] & b2) != 0)
			{
				num |= (uint)(1 << (i & 0x1F));
			}
		}
		return num;
	}

	private static void ia7(byte[] P_0, byte[] P_1, uint P_2)
	{
		int num = P_1.Length;
		if (P_2 >= 1 << (num & 0x1F))
		{
			yak(LicenseExceptionType.Other);
		}
		byte b = 0;
		int num2 = 0;
		int num4 = default(int);
		while (true)
		{
			bool flag = num2 < num;
			int num3 = 0;
			if (!i1X())
			{
				num3 = 0;
			}
			while (true)
			{
				switch (num3)
				{
				case 1:
					return;
				case 2:
					break;
				default:
					if (!flag)
					{
						if (P_0.Length * 8 <= b)
						{
							yak(LicenseExceptionType.Other);
						}
						for (int i = 0; i < num; i++)
						{
							bool flag2 = (P_2 & (1 << i)) != 0;
							byte b2 = P_1[i];
							byte b3 = (byte)(1 << 7 - b2 % 8);
							if (!flag2)
							{
								P_0[b2 / 8] = (byte)(P_0[b2 / 8] & (byte)(~b3));
							}
							else
							{
								P_0[b2 / 8] = (byte)(P_0[b2 / 8] | b3);
							}
						}
						num3 = 1;
						if (U1U() != null)
						{
							num3 = num4;
						}
					}
					else
					{
						if (b < P_1[num2])
						{
							b = P_1[num2];
						}
						num2++;
						num3 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private static ushort DaF(char P_0)
	{
		int num = 1;
		int num2 = num;
		ushort num3 = default(ushort);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = 0;
				num2 = 0;
				if (U1U() == null)
				{
					num2 = 0;
				}
				continue;
			}
			while (true)
			{
				if (num3 >= WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129282).Length)
				{
					return ushort.MaxValue;
				}
				if (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129282)[num3] != P_0)
				{
					num3++;
					continue;
				}
				break;
			}
			return num3;
		}
	}

	private static byte gao(string P_0, AlgorithmGLicenseProductCodes P_1, byte[] P_2)
	{
		byte[] array = new byte[9];
		for (int i = 0; i < 5; i++)
		{
			array[i] = (byte)P_0[i];
		}
		array[5] = (byte)(P_1 & (AlgorithmGLicenseProductCodes.Bars | AlgorithmGLicenseProductCodes.MicroCharts | AlgorithmGLicenseProductCodes.Charts | AlgorithmGLicenseProductCodes.SyntaxEditorWebLanguagesAddon));
		array[6] = (byte)(P_1 & (AlgorithmGLicenseProductCodes.Editors | AlgorithmGLicenseProductCodes.Views | AlgorithmGLicenseProductCodes.UnusedEssentials | AlgorithmGLicenseProductCodes.SyntaxEditorDotNetLanguagesAddon));
		array[7] = (byte)(P_1 & (AlgorithmGLicenseProductCodes.Navigation | AlgorithmGLicenseProductCodes.Docking | AlgorithmGLicenseProductCodes.Gauge | AlgorithmGLicenseProductCodes.Grids));
		array[8] = (byte)(P_1 & (AlgorithmGLicenseProductCodes.Wizard | AlgorithmGLicenseProductCodes.SyntaxEditor | AlgorithmGLicenseProductCodes.Ribbon | AlgorithmGLicenseProductCodes.BarCode));
		uint num = Rau(0u, array, 9u);
		num = Rau(num, P_2, (uint)P_2.Length);
		ushort num2 = (ushort)(((num & 0xFFFF0000u) >> 16) ^ (num & 0xFFFF));
		return (byte)(((num2 & 0xFF00) >> 8) ^ (num2 & 0xFF));
	}

	private static void PaQ(string P_0, byte[] P_1)
	{
		ushort num = 11;
		uint num2 = 0u;
		uint num3 = 0u;
		int num4 = 6;
		while (num2 < P_1.Length && num3 < 90)
		{
			ushort num5 = DaF(P_0[num4++]);
			if (num5 == ushort.MaxValue)
			{
				yak(LicenseExceptionType.Other);
			}
			num5 = (ushort)(num5 << (int)num);
			P_1[num2] |= (byte)((num5 & 0xFF00) >> 8);
			P_1[num2 + 1] = (byte)(P_1[num2 + 1] | (byte)(num5 & 0xFF));
			if (num < 8)
			{
				num += 3;
				num2++;
			}
			else
			{
				num -= 5;
			}
			num3 += 5;
		}
	}

	private void VaO(byte[] P_0)
	{
		ia7(P_0, pas, 0u);
		ia7(P_0, pas, gao(RaY, Iaa, P_0));
		string text = string.Empty;
		for (int i = 0; i < 18; i++)
		{
			byte b = 0;
			for (byte b2 = 0; b2 < 5; b2++)
			{
				int num = i * 5 + b2;
				byte b3 = (byte)(1 << 7 - num % 8);
				if ((P_0[num / 8] & b3) != 0)
				{
					b |= (byte)Math.Pow(2.0, 4 - b2);
				}
			}
			text += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129282)[b];
		}
		RaY = RaY.Substring(0, 6) + text + RaY.Substring(RaY.Length - 1, 1);
	}

	private void la0()
	{
		Iaa = AlgorithmGLicenseProductCodes.Invalid;
		Oax = 0;
		Nar = 0;
		VaI = AssemblyLicenseType.Invalid;
		vaA = 0;
		jan = AssemblyPlatform.Invalid;
		HaZ = 0;
		Ial = DateTime.Now;
	}

	private static void yak(LicenseExceptionType P_0)
	{
		throw new LicenseException((int)P_0);
	}

	static AlgorithmGLicenseDecryptor()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		LaW = new byte[20]
		{
			4, 7, 18, 22, 23, 32, 38, 41, 48, 56,
			60, 61, 63, 68, 72, 73, 74, 76, 84, 85
		};
		DaU = new byte[9] { 2, 12, 29, 35, 44, 46, 67, 81, 87 };
		DaH = new byte[3] { 0, 34, 42 };
		ra6 = new byte[7] { 9, 21, 31, 36, 52, 64, 88 };
		RaV = new byte[8] { 8, 16, 20, 27, 49, 55, 69, 79 };
		ka5 = new byte[3] { 6, 26, 83 };
		IaR = new byte[14]
		{
			3, 10, 17, 24, 30, 37, 40, 47, 50, 53,
			65, 70, 78, 82
		};
		uaE = new byte[16]
		{
			1, 11, 15, 19, 28, 33, 39, 45, 51, 54,
			58, 62, 71, 75, 80, 89
		};
		pas = new byte[8] { 5, 13, 25, 43, 57, 66, 77, 86 };
		taL = new byte[2] { 14, 59 };
	}

	internal static bool i1X()
	{
		return H1T == null;
	}

	internal static AlgorithmGLicenseDecryptor U1U()
	{
		return H1T;
	}
}
