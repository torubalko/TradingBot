using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class RsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly int[] SPECIAL_E_VALUES = new int[5] { 3, 5, 17, 257, 65537 };

	private static readonly int SPECIAL_E_HIGHEST = SPECIAL_E_VALUES[SPECIAL_E_VALUES.Length - 1];

	private static readonly int SPECIAL_E_BITS = BigInteger.ValueOf(SPECIAL_E_HIGHEST).BitLength;

	protected static readonly BigInteger One = BigInteger.One;

	protected static readonly BigInteger DefaultPublicExponent = BigInteger.ValueOf(65537L);

	protected const int DefaultTests = 100;

	protected RsaKeyGenerationParameters parameters;

	public virtual void Init(KeyGenerationParameters parameters)
	{
		if (parameters is RsaKeyGenerationParameters)
		{
			this.parameters = (RsaKeyGenerationParameters)parameters;
		}
		else
		{
			this.parameters = new RsaKeyGenerationParameters(DefaultPublicExponent, parameters.Random, parameters.Strength, 100);
		}
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		int qBitlength;
		BigInteger e;
		BigInteger p;
		BigInteger q;
		BigInteger n;
		BigInteger pSub1;
		BigInteger qSub1;
		BigInteger d;
		do
		{
			int strength = parameters.Strength;
			int pBitlength = (strength + 1) / 2;
			qBitlength = strength - pBitlength;
			int mindiffbits = strength / 3;
			int minWeight = strength >> 2;
			e = parameters.PublicExponent;
			p = ChooseRandomPrime(pBitlength, e);
			while (true)
			{
				q = ChooseRandomPrime(qBitlength, e);
				if (q.Subtract(p).Abs().BitLength < mindiffbits)
				{
					continue;
				}
				n = p.Multiply(q);
				if (n.BitLength != strength)
				{
					p = p.Max(q);
					continue;
				}
				if (WNafUtilities.GetNafWeight(n) >= minWeight)
				{
					break;
				}
				p = ChooseRandomPrime(pBitlength, e);
			}
			if (p.CompareTo(q) < 0)
			{
				BigInteger bigInteger = p;
				p = q;
				q = bigInteger;
			}
			pSub1 = p.Subtract(One);
			qSub1 = q.Subtract(One);
			BigInteger gcd = pSub1.Gcd(qSub1);
			BigInteger lcm = pSub1.Divide(gcd).Multiply(qSub1);
			d = e.ModInverse(lcm);
		}
		while (d.BitLength <= qBitlength);
		BigInteger dP = d.Remainder(pSub1);
		BigInteger dQ = d.Remainder(qSub1);
		BigInteger qInv = BigIntegers.ModOddInverse(p, q);
		return new AsymmetricCipherKeyPair(new RsaKeyParameters(isPrivate: false, n, e), new RsaPrivateCrtKeyParameters(n, e, d, p, q, dP, dQ, qInv));
	}

	protected virtual BigInteger ChooseRandomPrime(int bitlength, BigInteger e)
	{
		bool eIsKnownOddPrime = e.BitLength <= SPECIAL_E_BITS && Arrays.Contains(SPECIAL_E_VALUES, e.IntValue);
		BigInteger p;
		do
		{
			p = new BigInteger(bitlength, 1, parameters.Random);
		}
		while (p.Mod(e).Equals(One) || !p.IsProbablePrime(parameters.Certainty, randomlySelected: true) || (!eIsKnownOddPrime && !e.Gcd(p.Subtract(One)).Equals(One)));
		return p;
	}
}
