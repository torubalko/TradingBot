using System;
using System.IO;
using System.Text;
using BfZtb759KlUg4482QKym;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.OpenSsl;
using qRd6L7ac9HiGyTkgsTFB;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;

namespace JFTYgsac0q3XUbNNjxGO;

internal static class ua2OrTaXzxs2PyC5iUL0
{
	internal static ua2OrTaXzxs2PyC5iUL0 j7cmVjxwH9hCxH0vIAg2;

	public static Ed25519PrivateKeyParameters Ajgac2SHYau(string P_0, string P_1 = null)
	{
		Ed25519PrivateKeyParameters result = default(Ed25519PrivateKeyParameters);
		try
		{
			using StringReader reader = new StringReader(P_0.Trim());
			object obj;
			int num;
			if (string.IsNullOrEmpty(P_1))
			{
				obj = new PemReader(reader).ReadObject();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
				{
					num = 0;
				}
				goto IL_0030;
			}
			obj = Lgf2GSxwnRrg8UqI2iW5(new PemReader(reader, new op88tNacfhbjuWxOOYIK(P_1)));
			goto IL_011e;
			IL_011e:
			object obj2 = obj;
			num = 3;
			goto IL_0030;
			IL_0030:
			Ed25519PrivateKeyParameters ed25519PrivateKeyParameters = default(Ed25519PrivateKeyParameters);
			Ed25519PrivateKeyParameters ed25519PrivateKeyParameters2 = default(Ed25519PrivateKeyParameters);
			while (true)
			{
				switch (num)
				{
				case 5:
					if (ed25519PrivateKeyParameters != null)
					{
						goto case 6;
					}
					if (obj2 is AsymmetricCipherKeyPair asymmetricCipherKeyPair)
					{
						ed25519PrivateKeyParameters2 = asymmetricCipherKeyPair.Private as Ed25519PrivateKeyParameters;
						if (ed25519PrivateKeyParameters2 != null)
						{
							num = 4;
							continue;
						}
						goto case 2;
					}
					throw new InvalidOperationException(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-842040449 ^ -842102103));
				case 4:
					result = ed25519PrivateKeyParameters2;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
					{
						num = 1;
					}
					continue;
				case 3:
				{
					ed25519PrivateKeyParameters = obj2 as Ed25519PrivateKeyParameters;
					int num2 = 5;
					num = num2;
					continue;
				}
				case 1:
					goto end_IL_0030;
				case 6:
					result = ed25519PrivateKeyParameters;
					goto end_IL_0030;
				case 2:
					throw new NotSupportedException(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346924771));
				}
				goto IL_011e;
				continue;
				end_IL_0030:
				break;
			}
		}
		catch (Exception arg)
		{
			LogManager.WriteError(string.Format((string)V9bZqrxwGhSOXVd52BgQ(0x28BBDCA ^ 0x28A4FFA), arg));
			int num3 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
			{
				num3 = 0;
			}
			result = num3 switch
			{
				_ => null, 
			};
		}
		return result;
	}

	public static string WQ5acHCha3E(Ed25519PrivateKeyParameters P_0, string P_1)
	{
		Ed25519Signer ed25519Signer = new Ed25519Signer();
		ed25519Signer.Init(forSigning: true, P_0);
		byte[] bytes = Encoding.UTF8.GetBytes(P_1);
		ed25519Signer.BlockUpdate(bytes, 0, bytes.Length);
		return Convert.ToBase64String((byte[])tmc1AjxwYUmkwlDAd7iO(ed25519Signer));
	}

	static ua2OrTaXzxs2PyC5iUL0()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Lgf2GSxwnRrg8UqI2iW5(object P_0)
	{
		return ((PemReader)P_0).ReadObject();
	}

	internal static object V9bZqrxwGhSOXVd52BgQ(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool nS7H6pxwfkLGCKVVJXs7()
	{
		return j7cmVjxwH9hCxH0vIAg2 == null;
	}

	internal static ua2OrTaXzxs2PyC5iUL0 YmdA50xw9dQHgA42hyPJ()
	{
		return j7cmVjxwH9hCxH0vIAg2;
	}

	internal static object tmc1AjxwYUmkwlDAd7iO(object P_0)
	{
		return ((Ed25519Signer)P_0).GenerateSignature();
	}
}
