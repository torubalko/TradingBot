using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators;

public class Asn1CipherBuilderWithKey : ICipherBuilderWithKey, ICipherBuilder
{
	private readonly KeyParameter encKey;

	private AlgorithmIdentifier algorithmIdentifier;

	public object AlgorithmDetails => algorithmIdentifier;

	public ICipherParameters Key => encKey;

	public Asn1CipherBuilderWithKey(DerObjectIdentifier encryptionOID, int keySize, SecureRandom random)
	{
		if (random == null)
		{
			random = new SecureRandom();
		}
		CipherKeyGenerator keyGen = CipherKeyGeneratorFactory.CreateKeyGenerator(encryptionOID, random);
		encKey = new KeyParameter(keyGen.GenerateKey());
		algorithmIdentifier = AlgorithmIdentifierFactory.GenerateEncryptionAlgID(encryptionOID, encKey.GetKey().Length * 8, random);
	}

	public int GetMaxOutputSize(int inputLen)
	{
		throw new NotImplementedException();
	}

	public ICipher BuildCipher(Stream stream)
	{
		object cipher = EnvelopedDataHelper.CreateContentCipher(forEncryption: true, encKey, algorithmIdentifier);
		if (cipher is IStreamCipher)
		{
			cipher = new BufferedStreamCipher((IStreamCipher)cipher);
		}
		if (stream == null)
		{
			stream = new MemoryStream();
		}
		return new BufferedCipherWrapper((IBufferedCipher)cipher, stream);
	}
}
