using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators;

public class Asn1KeyUnwrapper : IKeyUnwrapper
{
	private string algorithm;

	private IKeyUnwrapper wrapper;

	public object AlgorithmDetails => wrapper.AlgorithmDetails;

	public Asn1KeyUnwrapper(string algorithm, ICipherParameters key)
	{
		this.algorithm = algorithm;
		wrapper = KeyWrapperUtil.UnwrapperForName(algorithm, key);
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, ICipherParameters key)
		: this(algorithm, null, key)
	{
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, ICipherParameters key)
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
			wrapper = (IKeyUnwrapper)provider.CreateWrapper(forWrapping: false, key);
			return;
		}
		if (algorithm.Equals(PkcsObjectIdentifiers.RsaEncryption))
		{
			RsaesOaepParameters oaepParams2 = RsaesOaepParameters.GetInstance(parameters);
			if (oaepParams2.MaskGenAlgorithm.Algorithm.Equals(PkcsObjectIdentifiers.IdMgf1))
			{
				AlgorithmIdentifier digAlg2 = AlgorithmIdentifier.GetInstance(oaepParams2.MaskGenAlgorithm.Parameters);
				new RsaOaepWrapperProvider(oaepParams2.HashAlgorithm.Algorithm, digAlg2.Algorithm);
			}
			else
			{
				new RsaOaepWrapperProvider(oaepParams2.HashAlgorithm.Algorithm, oaepParams2.MaskGenAlgorithm.Algorithm);
			}
			wrapper = new RsaPkcs1Wrapper(forWrapping: false, key);
			return;
		}
		throw new ArgumentException("unknown algorithm: " + algorithm.Id);
	}

	public IBlockResult Unwrap(byte[] keyData, int offSet, int length)
	{
		return wrapper.Unwrap(keyData, offSet, length);
	}
}
