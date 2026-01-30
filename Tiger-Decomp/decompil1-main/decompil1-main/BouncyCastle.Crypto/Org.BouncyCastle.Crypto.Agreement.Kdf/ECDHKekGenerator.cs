using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf;

public class ECDHKekGenerator : IDerivationFunction
{
	private readonly IDerivationFunction kdf;

	private DerObjectIdentifier algorithm;

	private int keySize;

	private byte[] z;

	public virtual IDigest Digest => kdf.Digest;

	public ECDHKekGenerator(IDigest digest)
	{
		kdf = new Kdf2BytesGenerator(digest);
	}

	public virtual void Init(IDerivationParameters param)
	{
		DHKdfParameters parameters = (DHKdfParameters)param;
		algorithm = parameters.Algorithm;
		keySize = parameters.KeySize;
		z = parameters.GetZ();
	}

	public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
	{
		DerSequence s = new DerSequence(new AlgorithmIdentifier(algorithm, DerNull.Instance), new DerTaggedObject(explicitly: true, 2, new DerOctetString(Pack.UInt32_To_BE((uint)keySize))));
		kdf.Init(new KdfParameters(z, s.GetDerEncoded()));
		return kdf.GenerateBytes(outBytes, outOff, len);
	}
}
