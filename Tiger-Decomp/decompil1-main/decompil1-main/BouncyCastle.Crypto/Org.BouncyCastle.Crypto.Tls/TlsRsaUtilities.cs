using System;
using System.IO;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class TlsRsaUtilities
{
	public static byte[] GenerateEncryptedPreMasterSecret(TlsContext context, RsaKeyParameters rsaServerPublicKey, Stream output)
	{
		byte[] premasterSecret = new byte[48];
		context.SecureRandom.NextBytes(premasterSecret);
		TlsUtilities.WriteVersion(context.ClientVersion, premasterSecret, 0);
		Pkcs1Encoding encoding = new Pkcs1Encoding(new RsaBlindedEngine());
		encoding.Init(forEncryption: true, new ParametersWithRandom(rsaServerPublicKey, context.SecureRandom));
		try
		{
			byte[] encryptedPreMasterSecret = encoding.ProcessBlock(premasterSecret, 0, premasterSecret.Length);
			if (TlsUtilities.IsSsl(context))
			{
				output.Write(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
			}
			else
			{
				TlsUtilities.WriteOpaque16(encryptedPreMasterSecret, output);
			}
		}
		catch (InvalidCipherTextException alertCause)
		{
			throw new TlsFatalAlert(80, alertCause);
		}
		return premasterSecret;
	}

	public static byte[] SafeDecryptPreMasterSecret(TlsContext context, RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
	{
		ProtocolVersion clientVersion = context.ClientVersion;
		bool versionNumberCheckDisabled = false;
		byte[] fallback = new byte[48];
		context.SecureRandom.NextBytes(fallback);
		byte[] M = Arrays.Clone(fallback);
		try
		{
			Pkcs1Encoding pkcs1Encoding = new Pkcs1Encoding(new RsaBlindedEngine(), fallback);
			pkcs1Encoding.Init(forEncryption: false, new ParametersWithRandom(rsaServerPrivateKey, context.SecureRandom));
			M = pkcs1Encoding.ProcessBlock(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
		}
		catch (Exception)
		{
		}
		if (!versionNumberCheckDisabled || !clientVersion.IsEqualOrEarlierVersionOf(ProtocolVersion.TLSv10))
		{
			int num = (clientVersion.MajorVersion ^ (M[0] & 0xFF)) | (clientVersion.MinorVersion ^ (M[1] & 0xFF));
			int num2 = num | (num >> 1);
			int num3 = num2 | (num2 >> 2);
			int mask = ~(((num3 | (num3 >> 4)) & 1) - 1);
			for (int i = 0; i < 48; i++)
			{
				M[i] = (byte)((M[i] & ~mask) | (fallback[i] & mask));
			}
		}
		return M;
	}
}
