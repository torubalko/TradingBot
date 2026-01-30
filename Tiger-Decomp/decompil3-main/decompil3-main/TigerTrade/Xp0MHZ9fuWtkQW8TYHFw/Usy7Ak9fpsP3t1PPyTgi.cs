using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace Xp0MHZ9fuWtkQW8TYHFw;

internal static class Usy7Ak9fpsP3t1PPyTgi
{
	private static readonly TripleDESCryptoServiceProvider Dj299HtRwkH;

	internal static Usy7Ak9fpsP3t1PPyTgi DxQ8Fbbb8dIrnqH1yX3I;

	static Usy7Ak9fpsP3t1PPyTgi()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Dj299HtRwkH.IV = (byte[])Nn6BUMbb3oMhfGksNQ7o("", Dj299HtRwkH.BlockSize / 8);
				return;
			case 1:
				HZjWVUbbJ9OUZi08dAXj();
				Dj299HtRwkH = new TripleDESCryptoServiceProvider();
				u7NXXabbFQAKsCSgamxX(Dj299HtRwkH, yR49fzY3AYM(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435847737), Dj299HtRwkH.KeySize / 8));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static byte[] yR49fzY3AYM(string P_0, int P_1)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = (byte[])qaIy70bbpGa2fWYRNow2(Encoding.Unicode, P_0);
		byte[] array2 = (byte[])sL8qVAbbu5Bq5cjPJMfF(sHA1CryptoServiceProvider, array);
		byte[] array3 = new byte[P_1];
		int num = 0;
		int num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
				return array3;
			}
			if (num >= Math.Min(P_1, array2.Length))
			{
				num2 = 2;
				continue;
			}
			array3[num] = array2[num];
			num++;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
			{
				num2 = 0;
			}
		}
	}

	public static string dmW990WPw10(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = "";
		}
		try
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, Dj299HtRwkH.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		catch (Exception)
		{
			return "";
		}
	}

	public static string sRK992L9rD1(string P_0)
	{
		if (CVtoH4bbz606Px7jTbEo(P_0))
		{
			P_0 = "";
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(P_0);
			MemoryStream memoryStream = new MemoryStream();
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			default:
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)YktSZObN0DIHihkAVDfj(Dj299HtRwkH), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				return (string)AnT1xYbN25rUSwEd2Ytb(Encoding.Unicode, memoryStream.ToArray());
			}
			}
		}
		catch (Exception)
		{
			return "";
		}
	}

	internal static void HZjWVUbbJ9OUZi08dAXj()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void u7NXXabbFQAKsCSgamxX(object P_0, object P_1)
	{
		((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
	}

	internal static object Nn6BUMbb3oMhfGksNQ7o(object P_0, int P_1)
	{
		return yR49fzY3AYM((string)P_0, P_1);
	}

	internal static bool lYCLfybbAEIEQsL0t4PH()
	{
		return DxQ8Fbbb8dIrnqH1yX3I == null;
	}

	internal static Usy7Ak9fpsP3t1PPyTgi IcOqqxbbPnO84GhClwNi()
	{
		return DxQ8Fbbb8dIrnqH1yX3I;
	}

	internal static object qaIy70bbpGa2fWYRNow2(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object sL8qVAbbu5Bq5cjPJMfF(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static bool CVtoH4bbz606Px7jTbEo(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object YktSZObN0DIHihkAVDfj(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor();
	}

	internal static object AnT1xYbN25rUSwEd2Ytb(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}
}
