using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators;

public class DHBasicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private DHKeyGenerationParameters param;

	public virtual void Init(KeyGenerationParameters parameters)
	{
		param = (DHKeyGenerationParameters)parameters;
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		DHKeyGeneratorHelper instance = DHKeyGeneratorHelper.Instance;
		DHParameters dhp = param.Parameters;
		BigInteger x = instance.CalculatePrivate(dhp, param.Random);
		return new AsymmetricCipherKeyPair(new DHPublicKeyParameters(instance.CalculatePublic(dhp, x), dhp), new DHPrivateKeyParameters(x, dhp));
	}
}
