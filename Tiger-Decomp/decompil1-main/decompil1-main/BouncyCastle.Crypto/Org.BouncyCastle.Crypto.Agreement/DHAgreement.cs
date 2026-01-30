using System;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement;

public class DHAgreement
{
	private DHPrivateKeyParameters key;

	private DHParameters dhParams;

	private BigInteger privateValue;

	private SecureRandom random;

	public void Init(ICipherParameters parameters)
	{
		AsymmetricKeyParameter kParam;
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)parameters;
			random = rParam.Random;
			kParam = (AsymmetricKeyParameter)rParam.Parameters;
		}
		else
		{
			random = new SecureRandom();
			kParam = (AsymmetricKeyParameter)parameters;
		}
		if (!(kParam is DHPrivateKeyParameters))
		{
			throw new ArgumentException("DHEngine expects DHPrivateKeyParameters");
		}
		key = (DHPrivateKeyParameters)kParam;
		dhParams = key.Parameters;
	}

	public BigInteger CalculateMessage()
	{
		DHKeyPairGenerator dHKeyPairGenerator = new DHKeyPairGenerator();
		dHKeyPairGenerator.Init(new DHKeyGenerationParameters(random, dhParams));
		AsymmetricCipherKeyPair dhPair = dHKeyPairGenerator.GenerateKeyPair();
		privateValue = ((DHPrivateKeyParameters)dhPair.Private).X;
		return ((DHPublicKeyParameters)dhPair.Public).Y;
	}

	public BigInteger CalculateAgreement(DHPublicKeyParameters pub, BigInteger message)
	{
		if (pub == null)
		{
			throw new ArgumentNullException("pub");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (!pub.Parameters.Equals(dhParams))
		{
			throw new ArgumentException("Diffie-Hellman public key has wrong parameters.");
		}
		BigInteger p = dhParams.P;
		BigInteger peerY = pub.Y;
		if (peerY == null || peerY.CompareTo(BigInteger.One) <= 0 || peerY.CompareTo(p.Subtract(BigInteger.One)) >= 0)
		{
			throw new ArgumentException("Diffie-Hellman public key is weak");
		}
		BigInteger result = peerY.ModPow(privateValue, p);
		if (result.Equals(BigInteger.One))
		{
			throw new InvalidOperationException("Shared key can't be 1");
		}
		return message.ModPow(key.X, p).Multiply(result).Mod(p);
	}
}
