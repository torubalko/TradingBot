using System;
using System.Text;
using ECOEgqlSad8NUJZ2Dr9n;
using GJKxjiHqE75NHHhTO9AC;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using TuAMtrl1Nd3XoZQQUXf0;

namespace UM3ii5HqN7aHA4UVxTTJ;

internal class CjxvwnHqb9jTV3EUvsWH
{
	private readonly Encoding oZYHq5lV0wV;

	private readonly AsymmetricKeyParameter OZHHqSsmODH;

	public readonly AsymmetricKeyParameter EoRHqxqMaEh;

	private static CjxvwnHqb9jTV3EUvsWH Q8G4JfD6J4wXYCn2wj6X;

	public CjxvwnHqb9jTV3EUvsWH()
	{
		MJyUyGD6pra7W1p9qyTf();
		oZYHq5lV0wV = Encoding.UTF8;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063567683));
				ECKeyGenerationParameters eCKeyGenerationParameters = new ECKeyGenerationParameters(X9ObjectIdentifiers.Prime256v1, new SecureRandom());
				dGiEuhD6u6luePwOmtmq(eCKeyPairGenerator, eCKeyGenerationParameters);
				AsymmetricCipherKeyPair asymmetricCipherKeyPair = eCKeyPairGenerator.GenerateKeyPair();
				OZHHqSsmODH = asymmetricCipherKeyPair.Private;
				EoRHqxqMaEh = asymmetricCipherKeyPair.Public;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	public string gQMHqkZf4Jj(string P_0, string P_1)
	{
		try
		{
			ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306964694));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					ECKeyGenerationParameters parameters = new ECKeyGenerationParameters((OZHHqSsmODH as ECPrivateKeyParameters).Parameters, new SecureRandom());
					eCKeyPairGenerator.Init(parameters);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
					{
						num = 0;
					}
					break;
				}
				default:
				{
					ECPublicKeyParameters eCPublicKeyParameters = VtDHq10C9V1(P_1);
					Yk3Od1Hqjai5LUixcs3l yk3Od1Hqjai5LUixcs3l = new Yk3Od1Hqjai5LUixcs3l(new ECDHBasicAgreement(), new Kdf2BytesGenerator(new Sha1Digest()), new HMac(new Sha1Digest()));
					byte[] derivation = Array.Empty<byte>();
					byte[] encoding = Array.Empty<byte>();
					IesWithCipherParameters iesWithCipherParameters = new IesWithCipherParameters(derivation, encoding, 128, -1);
					yk3Od1Hqjai5LUixcs3l.js7Hqdd1Nle(eCPublicKeyParameters, iesWithCipherParameters, eCKeyPairGenerator);
					byte[] bytes = oZYHq5lV0wV.GetBytes(P_0);
					return Convert.ToBase64String((byte[])tI0FKlD6zWDByHbQKSfZ(yk3Od1Hqjai5LUixcs3l, bytes, 0, bytes.Length));
				}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	private static ECPublicKeyParameters VtDHq10C9V1(string P_0)
	{
		return ftjUfWDM0Xy9q7dN3T09(Convert.FromBase64String(P_0)) as ECPublicKeyParameters;
	}

	static CjxvwnHqb9jTV3EUvsWH()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void MJyUyGD6pra7W1p9qyTf()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void dGiEuhD6u6luePwOmtmq(object P_0, object P_1)
	{
		((ECKeyPairGenerator)P_0).Init((KeyGenerationParameters)P_1);
	}

	internal static bool iFM6wSD6FO7BDXckEx3C()
	{
		return Q8G4JfD6J4wXYCn2wj6X == null;
	}

	internal static CjxvwnHqb9jTV3EUvsWH C9UEuCD63nHxliokaTi2()
	{
		return Q8G4JfD6J4wXYCn2wj6X;
	}

	internal static object tI0FKlD6zWDByHbQKSfZ(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Yk3Od1Hqjai5LUixcs3l)P_0).XqnHqq8qY24((byte[])P_1, P_2, P_3);
	}

	internal static object ftjUfWDM0Xy9q7dN3T09(object P_0)
	{
		return PublicKeyFactory.CreateKey((byte[])P_0);
	}
}
