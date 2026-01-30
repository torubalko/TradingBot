using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators;

public class DesKeyGenerator : CipherKeyGenerator
{
	public DesKeyGenerator()
	{
	}

	internal DesKeyGenerator(int defaultStrength)
		: base(defaultStrength)
	{
	}

	protected override void engineInit(KeyGenerationParameters parameters)
	{
		base.engineInit(parameters);
		if (strength == 0 || strength == 7)
		{
			strength = 8;
		}
		else if (strength != 8)
		{
			throw new ArgumentException("DES key must be " + 64 + " bits long.");
		}
	}

	protected override byte[] engineGenerateKey()
	{
		byte[] newKey = new byte[8];
		do
		{
			random.NextBytes(newKey);
			DesParameters.SetOddParity(newKey);
		}
		while (DesParameters.IsWeakKey(newKey, 0));
		return newKey;
	}
}
