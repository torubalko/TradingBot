using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Crypto.Operators;

public class Asn1KeyWrapper : IKeyWrapper
{
	private string algorithm;

	private IKeyWrapper wrapper;

	public object AlgorithmDetails => wrapper.AlgorithmDetails;

	public Asn1KeyWrapper(string algorithm, X509Certificate cert)
	{
		this.algorithm = algorithm;
		wrapper = KeyWrapperUtil.WrapperForName(algorithm, cert.GetPublicKey());
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, X509Certificate cert)
		: this(algorithm, cert.GetPublicKey())
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, ICipherParameters key)
		: this(algorithm, null, key)
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, X509Certificate cert)
		: this(algorithm, parameters, cert.GetPublicKey())
	{
	}

	public Asn1KeyWrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, ICipherParameters key)
	{
		this.algorithm = algorithm.Id;
		if (algorithm.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			RsaesOaepParameters oaepParams = RsaesOaepParameters.GetInstance(parameters);
			WrapperProvider provider;
			if (oaepParams.MaskGenAlgorithm.Algorithm.Equals(PkcsObjectIdentifiers.IdMgf1))
			{
				AlgorithmIdentifier digAlg = AlgorithmIdentifier.GetInstance(oaepParams.MaskGenAlgorithm.Parameters);
				provider = new RsaOaepWrapperProvider(oaepParams.HashAlgorithm.Algorithm, digAlg.Algorithm);
			}
			else
			{
				provider = new RsaOaepWrapperProvider(oaepParams.HashAlgorithm.Algorithm, oaepParams.MaskGenAlgorithm.Algorithm);
			}
			wrapper = (IKeyWrapper)provider.CreateWrapper(forWrapping: true, key);
		}
		else
		{
			if (!algorithm.Equals(PkcsObjectIdentifiers.RsaEncryption))
			{
				throw new ArgumentException("unknown algorithm: " + algorithm.Id);
			}
			wrapper = new RsaPkcs1Wrapper(forWrapping: true, key);
		}
	}

	public IBlockResult Wrap(byte[] keyData)
	{
		return wrapper.Wrap(keyData);
	}
}
