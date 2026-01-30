using System;
using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

internal class AlgorithmGLicenseEncryptor
{
	private static byte[] sa8;

	private static byte[] caD;

	private static byte[] baP;

	private static byte[] laG;

	private static byte[] Oa1;

	private static byte[] zaz;

	private static byte[] zqc;

	private static byte[] yqj;

	private static byte[] xqv;

	private static byte[] hqX;

	private static byte[] KqT;

	internal static AlgorithmGLicenseEncryptor H1L;

	public AlgorithmGLicenseEncryptor()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	private uint Had(uint P_0, byte[] P_1, uint P_2)
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

	private string faN(AlgorithmGLicenseProductCodes P_0, byte P_1, byte P_2, AssemblyLicenseType P_3, string P_4, byte P_5, AssemblyPlatform P_6, ushort P_7, DateTime P_8)
	{
		byte[] array = new byte[12];
		string empty = string.Empty;
		empty = P_6 switch
		{
			AssemblyPlatform.AspNet => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129350), 
			AssemblyPlatform.Silverlight => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129360), 
			AssemblyPlatform.WindowsForms => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129370), 
			AssemblyPlatform.Universal => (P_1 >= 16) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129390) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129380), 
			AssemblyPlatform.Wpf => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123230), 
			_ => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129400), 
		} + P_1.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129274), CultureInfo.InvariantCulture) + P_2.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242), CultureInfo.InvariantCulture);
		DateTime dateTime = new DateTime(2002, 1, 1);
		if (P_8 < dateTime)
		{
			P_8 = dateTime;
		}
		WaM(array, sa8, (uint)P_0);
		WaM(array, caD, (uint)(P_1 * 10 + P_2));
		WaM(array, baP, (uint)P_3);
		WaM(array, laG, P_4[0]);
		WaM(array, Oa1, P_5);
		WaM(array, zaz, (uint)P_6);
		WaM(array, yqj, P_7);
		WaM(array, zqc, (uint)(P_8 - dateTime).Days);
		WaM(array, hqX, 0u);
		if (KqT.Length != 0)
		{
			WaM(array, KqT, 0u);
		}
		WaM(array, xqv, Gag(empty, P_0, array));
		for (int i = 0; i < 18; i++)
		{
			byte b = 0;
			for (byte b2 = 0; b2 < 5; b2++)
			{
				int num = i * 5 + b2;
				byte b3 = (byte)(1 << 7 - num % 8);
				if ((array[num / 8] & b3) != 0)
				{
					b |= (byte)Math.Pow(2.0, 4 - b2);
				}
			}
			empty += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129282)[b];
		}
		empty += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(928);
		return zaK(empty);
	}

	private void WaM(byte[] P_0, byte[] P_1, uint P_2)
	{
		int num = P_1.Length;
		if (P_2 >= 1 << num)
		{
			throw new ApplicationException();
		}
		byte b = 0;
		for (int i = 0; i < num; i++)
		{
			if (b < P_1[i])
			{
				b = P_1[i];
			}
		}
		if (P_0.Length * 8 <= b)
		{
			throw new ApplicationException();
		}
		for (int j = 0; j < num; j++)
		{
			bool flag = (P_2 & (1 << j)) != 0;
			byte b2 = P_1[j];
			byte b3 = (byte)(1 << 7 - b2 % 8);
			if (flag)
			{
				P_0[b2 / 8] = (byte)(P_0[b2 / 8] | b3);
			}
			else
			{
				P_0[b2 / 8] = (byte)(P_0[b2 / 8] & (byte)(~b3));
			}
		}
	}

	private string zaK(string P_0)
	{
		return P_0.Substring(0, 6) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(6, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(11, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(16, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(21);
	}

	private byte Gag(string P_0, AlgorithmGLicenseProductCodes P_1, byte[] P_2)
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
		uint num = Had(0u, array, 9u);
		num = Had(num, P_2, (uint)P_2.Length);
		ushort num2 = (ushort)(((num & 0xFFFF0000u) >> 16) ^ (num & 0xFFFF));
		return (byte)(((num2 & 0xFF00) >> 8) ^ (num2 & 0xFF));
	}

	public string EncryptBeta(AlgorithmGLicenseProductCodes productCodes, byte majorVersion, byte minorVersion, AssemblyPlatform platform, DateTime expirationDate)
	{
		return faN(productCodes, majorVersion, minorVersion, AssemblyLicenseType.Beta, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129410), 1, platform, 13, expirationDate);
	}

	public string EncryptEvaluation(AlgorithmGLicenseProductCodes productCodes, byte majorVersion, byte minorVersion, AssemblyPlatform platform)
	{
		return EncryptEvaluation(productCodes, majorVersion, minorVersion, platform, null);
	}

	public string EncryptEvaluation(AlgorithmGLicenseProductCodes productCodes, byte majorVersion, byte minorVersion, AssemblyPlatform platform, string licensee)
	{
		if (string.IsNullOrEmpty(licensee))
		{
			licensee = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129422);
		}
		return faN(productCodes, majorVersion, minorVersion, AssemblyLicenseType.Evaluation, licensee, 1, platform, 180, DateTime.Today.AddDays(180.0));
	}

	public string EncryptFull(AlgorithmGLicenseProductCodes productCodes, byte majorVersion, byte minorVersion, AssemblyLicenseType licenseType, string licensee, byte licenseCount, AssemblyPlatform platform, ushort organizationID, DateTime date)
	{
		return faN(productCodes, majorVersion, minorVersion, AssemblyLicenseType.Full, licensee, licenseCount, platform, organizationID, date);
	}

	public string EncryptPreRelease(AlgorithmGLicenseProductCodes productCodes, byte majorVersion, byte minorVersion, AssemblyPlatform platform, DateTime expirationDate)
	{
		return faN(productCodes, majorVersion, minorVersion, AssemblyLicenseType.Prerelease, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129446), 1, platform, 45, expirationDate);
	}

	static AlgorithmGLicenseEncryptor()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		sa8 = new byte[20]
		{
			4, 7, 18, 22, 23, 32, 38, 41, 48, 56,
			60, 61, 63, 68, 72, 73, 74, 76, 84, 85
		};
		caD = new byte[9] { 2, 12, 29, 35, 44, 46, 67, 81, 87 };
		baP = new byte[3] { 0, 34, 42 };
		laG = new byte[7] { 9, 21, 31, 36, 52, 64, 88 };
		Oa1 = new byte[8] { 8, 16, 20, 27, 49, 55, 69, 79 };
		zaz = new byte[3] { 6, 26, 83 };
		zqc = new byte[14]
		{
			3, 10, 17, 24, 30, 37, 40, 47, 50, 53,
			65, 70, 78, 82
		};
		yqj = new byte[16]
		{
			1, 11, 15, 19, 28, 33, 39, 45, 51, 54,
			58, 62, 71, 75, 80, 89
		};
		xqv = new byte[8] { 5, 13, 25, 43, 57, 66, 77, 86 };
		hqX = new byte[2] { 14, 59 };
		KqT = new byte[0];
	}

	internal static bool N14()
	{
		return H1L == null;
	}

	internal static AlgorithmGLicenseEncryptor I1s()
	{
		return H1L;
	}
}
