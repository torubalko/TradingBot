using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers;

public class Gost3410Signer : IDsaExt, IDsa
{
	private Gost3410KeyParameters key;

	private SecureRandom random;

	public virtual string AlgorithmName => "GOST3410";

	public virtual BigInteger Order => key.Parameters.Q;

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		if (forSigning)
		{
			if (parameters is ParametersWithRandom)
			{
				ParametersWithRandom rParam = (ParametersWithRandom)parameters;
				random = rParam.Random;
				parameters = rParam.Parameters;
			}
			else
			{
				random = new SecureRandom();
			}
			if (!(parameters is Gost3410PrivateKeyParameters))
			{
				throw new InvalidKeyException("GOST3410 private key required for signing");
			}
			key = (Gost3410PrivateKeyParameters)parameters;
		}
		else
		{
			if (!(parameters is Gost3410PublicKeyParameters))
			{
				throw new InvalidKeyException("GOST3410 public key required for signing");
			}
			key = (Gost3410PublicKeyParameters)parameters;
		}
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		byte[] mRev = Arrays.Reverse(message);
		BigInteger m = new BigInteger(1, mRev);
		Gost3410Parameters parameters = key.Parameters;
		BigInteger k;
		do
		{
			k = new BigInteger(parameters.Q.BitLength, random);
		}
		while (k.CompareTo(parameters.Q) >= 0);
		BigInteger r = parameters.A.ModPow(k, parameters.P).Mod(parameters.Q);
		BigInteger s = k.Multiply(m).Add(((Gost3410PrivateKeyParameters)key).X.Multiply(r)).Mod(parameters.Q);
		return new BigInteger[2] { r, s };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		byte[] mRev = Arrays.Reverse(message);
		BigInteger m = new BigInteger(1, mRev);
		Gost3410Parameters parameters = key.Parameters;
		if (r.SignValue < 0 || parameters.Q.CompareTo(r) <= 0)
		{
			return false;
		}
		if (s.SignValue < 0 || parameters.Q.CompareTo(s) <= 0)
		{
			return false;
		}
		BigInteger v = m.ModPow(parameters.Q.Subtract(BigInteger.Two), parameters.Q);
		BigInteger z1 = s.Multiply(v).Mod(parameters.Q);
		BigInteger z2 = parameters.Q.Subtract(r).Multiply(v).Mod(parameters.Q);
		z1 = parameters.A.ModPow(z1, parameters.P);
		z2 = ((Gost3410PublicKeyParameters)key).Y.ModPow(z2, parameters.P);
		return z1.Multiply(z2).Mod(parameters.P).Mod(parameters.Q)
			.Equals(r);
	}
}
