using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpV3SignatureGenerator
{
	private PublicKeyAlgorithmTag keyAlgorithm;

	private HashAlgorithmTag hashAlgorithm;

	private PgpPrivateKey privKey;

	private ISigner sig;

	private IDigest dig;

	private int signatureType;

	private byte lastb;

	public PgpV3SignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
	{
		this.keyAlgorithm = keyAlgorithm;
		this.hashAlgorithm = hashAlgorithm;
		dig = DigestUtilities.GetDigest(PgpUtilities.GetDigestName(hashAlgorithm));
		sig = SignerUtilities.GetSigner(PgpUtilities.GetSignatureName(keyAlgorithm, hashAlgorithm));
	}

	public void InitSign(int sigType, PgpPrivateKey key)
	{
		InitSign(sigType, key, null);
	}

	public void InitSign(int sigType, PgpPrivateKey key, SecureRandom random)
	{
		privKey = key;
		signatureType = sigType;
		try
		{
			ICipherParameters cp = key.Key;
			if (random != null)
			{
				cp = new ParametersWithRandom(key.Key, random);
			}
			sig.Init(forSigning: true, cp);
		}
		catch (InvalidKeyException exception)
		{
			throw new PgpException("invalid key.", exception);
		}
		dig.Reset();
		lastb = 0;
	}

	public void Update(byte b)
	{
		if (signatureType == 1)
		{
			doCanonicalUpdateByte(b);
		}
		else
		{
			doUpdateByte(b);
		}
	}

	private void doCanonicalUpdateByte(byte b)
	{
		switch (b)
		{
		case 13:
			doUpdateCRLF();
			break;
		case 10:
			if (lastb != 13)
			{
				doUpdateCRLF();
			}
			break;
		default:
			doUpdateByte(b);
			break;
		}
		lastb = b;
	}

	private void doUpdateCRLF()
	{
		doUpdateByte(13);
		doUpdateByte(10);
	}

	private void doUpdateByte(byte b)
	{
		sig.Update(b);
		dig.Update(b);
	}

	public void Update(byte[] b)
	{
		if (signatureType == 1)
		{
			for (int i = 0; i != b.Length; i++)
			{
				doCanonicalUpdateByte(b[i]);
			}
		}
		else
		{
			sig.BlockUpdate(b, 0, b.Length);
			dig.BlockUpdate(b, 0, b.Length);
		}
	}

	public void Update(byte[] b, int off, int len)
	{
		if (signatureType == 1)
		{
			int finish = off + len;
			for (int i = off; i != finish; i++)
			{
				doCanonicalUpdateByte(b[i]);
			}
		}
		else
		{
			sig.BlockUpdate(b, off, len);
			dig.BlockUpdate(b, off, len);
		}
	}

	public PgpOnePassSignature GenerateOnePassVersion(bool isNested)
	{
		return new PgpOnePassSignature(new OnePassSignaturePacket(signatureType, hashAlgorithm, keyAlgorithm, privKey.KeyId, isNested));
	}

	public PgpSignature Generate()
	{
		long creationTime = DateTimeUtilities.CurrentUnixMs() / 1000;
		byte[] hData = new byte[5]
		{
			(byte)signatureType,
			(byte)(creationTime >> 24),
			(byte)(creationTime >> 16),
			(byte)(creationTime >> 8),
			(byte)creationTime
		};
		sig.BlockUpdate(hData, 0, hData.Length);
		dig.BlockUpdate(hData, 0, hData.Length);
		byte[] sigBytes = sig.GenerateSignature();
		byte[] digest = DigestUtilities.DoFinal(dig);
		byte[] fingerPrint = new byte[2]
		{
			digest[0],
			digest[1]
		};
		MPInteger[] sigValues = ((keyAlgorithm == PublicKeyAlgorithmTag.RsaSign || keyAlgorithm == PublicKeyAlgorithmTag.RsaGeneral) ? PgpUtilities.RsaSigToMpi(sigBytes) : PgpUtilities.DsaSigToMpi(sigBytes));
		return new PgpSignature(new SignaturePacket(3, signatureType, privKey.KeyId, keyAlgorithm, hashAlgorithm, creationTime * 1000, fingerPrint, sigValues));
	}
}
