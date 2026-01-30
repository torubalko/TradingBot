using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters;

public class RsaKeyGenerationParameters : KeyGenerationParameters
{
	private readonly BigInteger publicExponent;

	private readonly int certainty;

	public BigInteger PublicExponent => publicExponent;

	public int Certainty => certainty;

	public RsaKeyGenerationParameters(BigInteger publicExponent, SecureRandom random, int strength, int certainty)
		: base(random, strength)
	{
		this.publicExponent = publicExponent;
		this.certainty = certainty;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is RsaKeyGenerationParameters other))
		{
			return false;
		}
		if (certainty == other.certainty)
		{
			return publicExponent.Equals(other.publicExponent);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return certainty.GetHashCode() ^ publicExponent.GetHashCode();
	}
}
