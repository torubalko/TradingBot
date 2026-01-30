using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace EBwZqeajkUULymgLZ6pW;

internal static class bKiVl7ajN7b8mPCIOURL
{
	private static readonly TripleDESCryptoServiceProvider DkoajxALSPl;

	private static bKiVl7ajN7b8mPCIOURL HLFD7ix7fB1MAqvKuJeh;

	static bKiVl7ajN7b8mPCIOURL()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				DkoajxALSPl.Key = (byte[])Nv9s0px7vk7jJvicxdWi(kHdE3hx7YUNVPJDW6NRU(0x7DB10E6E ^ 0x7DB0FD36), AiAy1Jx7oYS2onLxx5vU(DkoajxALSPl) / 8);
				DkoajxALSPl.IV = (byte[])Nv9s0px7vk7jJvicxdWi("", DkoajxALSPl.BlockSize / 8);
				return;
			case 1:
				F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			rZk9VRx7GeAKDpX5ZB0W();
			DkoajxALSPl = new TripleDESCryptoServiceProvider();
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num2 = 2;
			}
		}
	}

	private static byte[] rbkaj1CZVou(string P_0, int P_1)
	{
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				goto IL_0046;
			case 1:
				array2 = new byte[P_1];
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
				byte[] bytes = Encoding.Unicode.GetBytes(P_0);
				array = sHA1CryptoServiceProvider.ComputeHash(bytes);
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 3:
				{
					array2[num3] = array[num3];
					num3++;
					goto IL_0046;
				}
				IL_0046:
				if (num3 >= wvdLAtx7BxHvNBWQ0Zia(P_1, array.Length))
				{
					return array2;
				}
				goto case 3;
			}
		}
	}

	public static string I1Uaj5WJ3yL(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				P_0 = "";
				goto IL_0025;
			case 1:
				{
					if (!string.IsNullOrEmpty(P_0))
					{
						goto IL_0025;
					}
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0025:
				try
				{
					byte[] bytes = Encoding.Unicode.GetBytes(P_0);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)abkW2Bx7aKx4VSXKgcYe(DkoajxALSPl), CryptoStreamMode.Write);
					cryptoStream.Write(bytes, 0, bytes.Length);
					IKbgjvx7i4wmLjZZUf9a(cryptoStream);
					return (string)s54h3wx74O8OYUve9tZp(olqVRtx7lG6TXLkLlAhw(memoryStream));
				}
				catch (Exception)
				{
					return "";
				}
			}
		}
	}

	public static string GcUajSSfECS(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return "";
			case 1:
				if (!string.IsNullOrEmpty(P_0))
				{
					string result;
					try
					{
						byte[] array = Convert.FromBase64String(P_0);
						using MemoryStream memoryStream = new MemoryStream();
						using ICryptoTransform transform = EeRSPBx7D0rJOpTMKc0d(DkoajxALSPl);
						using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						ITdIgix7bURcMGDe19TP(cryptoStream, array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						result = Encoding.Unicode.GetString(memoryStream.ToArray());
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception)
					{
						result = "";
					}
					return result;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void rZk9VRx7GeAKDpX5ZB0W()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object kHdE3hx7YUNVPJDW6NRU(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static int AiAy1Jx7oYS2onLxx5vU(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).KeySize;
	}

	internal static object Nv9s0px7vk7jJvicxdWi(object P_0, int P_1)
	{
		return rbkaj1CZVou((string)P_0, P_1);
	}

	internal static bool TdKqHIx79OIjqcT8Eklt()
	{
		return HLFD7ix7fB1MAqvKuJeh == null;
	}

	internal static bKiVl7ajN7b8mPCIOURL fCyDHLx7n8LP1eQ1dmkc()
	{
		return HLFD7ix7fB1MAqvKuJeh;
	}

	internal static int wvdLAtx7BxHvNBWQ0Zia(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object abkW2Bx7aKx4VSXKgcYe(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).CreateEncryptor();
	}

	internal static void IKbgjvx7i4wmLjZZUf9a(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object olqVRtx7lG6TXLkLlAhw(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static object s54h3wx74O8OYUve9tZp(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static object EeRSPBx7D0rJOpTMKc0d(object P_0)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor();
	}

	internal static void ITdIgix7bURcMGDe19TP(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}
}
