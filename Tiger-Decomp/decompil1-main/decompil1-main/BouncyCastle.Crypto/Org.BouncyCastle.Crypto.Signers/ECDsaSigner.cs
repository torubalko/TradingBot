using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class ECDsaSigner : IDsaExt, IDsa
{
	private static readonly BigInteger Eight = BigInteger.ValueOf(8L);

	protected readonly IDsaKCalculator kCalculator;

	protected ECKeyParameters key;

	protected SecureRandom random;

	public virtual string AlgorithmName => "ECDSA";

	public virtual BigInteger Order => key.Parameters.N;

	public ECDsaSigner()
	{
		kCalculator = new RandomDsaKCalculator();
	}

	public ECDsaSigner(IDsaKCalculator kCalculator)
	{
		this.kCalculator = kCalculator;
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		SecureRandom providedRandom = null;
		if (forSigning)
		{
			if (parameters is ParametersWithRandom)
			{
				ParametersWithRandom obj = (ParametersWithRandom)parameters;
				providedRandom = obj.Random;
				parameters = obj.Parameters;
			}
			if (!(parameters is ECPrivateKeyParameters))
			{
				throw new InvalidKeyException("EC private key required for signing");
			}
			key = (ECPrivateKeyParameters)parameters;
		}
		else
		{
			if (!(parameters is ECPublicKeyParameters))
			{
				throw new InvalidKeyException("EC public key required for verification");
			}
			key = (ECPublicKeyParameters)parameters;
		}
		random = InitSecureRandom(forSigning && !kCalculator.IsDeterministic, providedRandom);
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		ECDomainParameters ec = key.Parameters;
		BigInteger n = ec.N;
		BigInteger e = CalculateE(n, message);
		BigInteger d = ((ECPrivateKeyParameters)key).D;
		if (kCalculator.IsDeterministic)
		{
			kCalculator.Init(n, d, message);
		}
		else
		{
			kCalculator.Init(n, random);
		}
		ECMultiplier basePointMultiplier = CreateBasePointMultiplier();
		BigInteger r;
		BigInteger s;
		while (true)
		{
			BigInteger k = kCalculator.NextK();
			r = basePointMultiplier.Multiply(ec.G, k).Normalize().AffineXCoord.ToBigInteger().Mod(n);
			if (r.SignValue != 0)
			{
				s = BigIntegers.ModOddInverse(n, k).Multiply(e.Add(d.Multiply(r))).Mod(n);
				if (s.SignValue != 0)
				{
					break;
				}
			}
		}
		return new BigInteger[2] { r, s };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		BigInteger n = key.Parameters.N;
		if (r.SignValue < 1 || s.SignValue < 1 || r.CompareTo(n) >= 0 || s.CompareTo(n) >= 0)
		{
			return false;
		}
		BigInteger bigInteger = CalculateE(n, message);
		BigInteger c = BigIntegers.ModOddInverseVar(n, s);
		BigInteger u1 = bigInteger.Multiply(c).Mod(n);
		BigInteger u2 = r.Multiply(c).Mod(n);
		ECPoint g = key.Parameters.G;
		ECPoint Q = ((ECPublicKeyParameters)key).Q;
		ECPoint point = ECAlgorithms.SumOfTwoMultiplies(g, u1, Q, u2);
		if (point.IsInfinity)
		{
			return false;
		}
		ECCurve curve = point.Curve;
		if (curve != null)
		{
			BigInteger cofactor = curve.Cofactor;
			if (cofactor != null && cofactor.CompareTo(Eight) <= 0)
			{
				ECFieldElement D = GetDenominator(curve.CoordinateSystem, point);
				if (D != null && !D.IsZero)
				{
					ECFieldElement X = point.XCoord;
					while (curve.IsValidFieldElement(r))
					{
						if (curve.FromBigInteger(r).Multiply(D).Equals(X))
						{
							return true;
						}
						r = r.Add(n);
					}
					return false;
				}
			}
		}
		return point.Normalize().AffineXCoord.ToBigInteger().Mod(n).Equals(r);
	}

	protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
	{
		int messageBitLength = message.Length * 8;
		BigInteger trunc = new BigInteger(1, message);
		if (n.BitLength < messageBitLength)
		{
			trunc = trunc.ShiftRight(messageBitLength - n.BitLength);
		}
		return trunc;
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return new FixedPointCombMultiplier();
	}

	protected virtual ECFieldElement GetDenominator(int coordinateSystem, ECPoint p)
	{
		switch (coordinateSystem)
		{
		case 1:
		case 6:
		case 7:
			return p.GetZCoord(0);
		case 2:
		case 3:
		case 4:
			return p.GetZCoord(0).Square();
		default:
			return null;
		}
	}

	protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
	{
		if (needed)
		{
			if (provided == null)
			{
				return new SecureRandom();
			}
			return provided;
		}
		return null;
	}
}
