using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators;

public class ElGamalKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private ElGamalKeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
		param = (ElGamalKeyGenerationParameters)parameters;
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		DHKeyGeneratorHelper instance = DHKeyGeneratorHelper.Instance;
		ElGamalParameters egp = param.Parameters;
		DHParameters dhp = new DHParameters(egp.P, egp.G, null, 0, egp.L);
		BigInteger x = instance.CalculatePrivate(dhp, param.Random);
		return new AsymmetricCipherKeyPair(new ElGamalPublicKeyParameters(instance.CalculatePublic(dhp, x), egp), new ElGamalPrivateKeyParameters(x, egp));
	}
}
