using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace XnCphcHqoPcPGCkgYLFw;

internal static class EncwAYHqYSg6vo08yxsi
{
	private static readonly string DpVHqlGUEhl;

	private static readonly string GMEHq4wn0Jy;

	private static readonly UnicodeEncoding jiyHqD0Eo1I;

	private static EncwAYHqYSg6vo08yxsi KxuGd3D6CrnG6PlDXVE0;

	private static byte[] pWbHqvYkSKJ(byte[] P_0, bool P_1 = false)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		lRA88kD6mheOaZVrY0Ta(rSACryptoServiceProvider, DpVHqlGUEhl);
		return rSACryptoServiceProvider.Encrypt(P_0, P_1);
	}

	private static byte[] XEtHqBmOtUS(byte[] P_0, bool P_1 = false)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		lRA88kD6mheOaZVrY0Ta(rSACryptoServiceProvider, GMEHq4wn0Jy);
		return rSACryptoServiceProvider.Decrypt(P_0, P_1);
	}

	public static byte[] l6SHqaWXoEI(string P_0)
	{
		int num = 1;
		int num2 = num;
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!WQ2q8fD6h8ngfb8LbnH7(P_0))
				{
					try
					{
						TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								array2 = pWbHqvYkSKJ((byte[])QX5WahD6wXdx9TtUEswR(tripleDESCryptoServiceProvider));
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
								{
									num3 = 0;
								}
								break;
							default:
							{
								byte[] array = pWbHqvYkSKJ(tripleDESCryptoServiceProvider.IV);
								byte[] bytes = jiyHqD0Eo1I.GetBytes(P_0);
								MemoryStream memoryStream = new MemoryStream();
								memoryStream.Write(array2, 0, array2.Length);
								memoryStream.Write(array, 0, array.Length);
								CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
								PA8xFwD67MieOTQ4dXop(cryptoStream, bytes, 0, bytes.Length);
								cryptoStream.FlushFinalBlock();
								return memoryStream.ToArray();
							}
							}
						}
					}
					catch (CryptographicException)
					{
						return null;
					}
					catch (Exception)
					{
						return null;
					}
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return null;
			}
		}
	}

	public static string IayHqiu7VFU(byte[] P_0)
	{
		if (P_0 != null)
		{
			if (P_0.Length != 0)
			{
				string result = default(string);
				try
				{
					byte[] array = P_0.Take(128).ToArray();
					byte[] array2 = P_0.Skip(128).Take(128).ToArray();
					byte[] key = XEtHqBmOtUS(array);
					byte[] iV = XEtHqBmOtUS(array2);
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
					{
						Key = key,
						IV = iV
					};
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
					cryptoStream.Write(P_0, 256, P_0.Length - 256);
					cryptoStream.FlushFinalBlock();
					int num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num = 1;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							result = (string)kFNT94D6AWD3grLZUm4O(jiyHqD0Eo1I, T2WvclD68wEX9HWn1neX(memoryStream));
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
							{
								num = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (CryptographicException)
				{
					result = null;
				}
				catch (Exception)
				{
					result = null;
				}
				return result;
			}
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
		}
		return null;
	}

	static EncwAYHqYSg6vo08yxsi()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				DpVHqlGUEhl = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -616842429);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				JbFONFD6P8GRBX9Px4SZ();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				GMEHq4wn0Jy = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1347052571);
				jiyHqD0Eo1I = new UnicodeEncoding();
				return;
			}
		}
	}

	internal static void lRA88kD6mheOaZVrY0Ta(object P_0, object P_1)
	{
		((AsymmetricAlgorithm)P_0).FromXmlString((string)P_1);
	}

	internal static bool hbmiftD6r9cQaexmlT5F()
	{
		return KxuGd3D6CrnG6PlDXVE0 == null;
	}

	internal static EncwAYHqYSg6vo08yxsi EGLhDKD6K2GdXgs5WF2O()
	{
		return KxuGd3D6CrnG6PlDXVE0;
	}

	internal static bool WQ2q8fD6h8ngfb8LbnH7(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object QX5WahD6wXdx9TtUEswR(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).Key;
	}

	internal static void PA8xFwD67MieOTQ4dXop(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static object T2WvclD68wEX9HWn1neX(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object kFNT94D6AWD3grLZUm4O(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void JbFONFD6P8GRBX9Px4SZ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
