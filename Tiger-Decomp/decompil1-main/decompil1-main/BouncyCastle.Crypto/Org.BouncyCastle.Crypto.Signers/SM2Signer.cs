using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Signers;

public class SM2Signer : ISigner
{
	private readonly IDsaKCalculator kCalculator = new RandomDsaKCalculator();

	private readonly IDigest digest;

	private readonly IDsaEncoding encoding;

	private ECDomainParameters ecParams;

	private ECPoint pubPoint;

	private ECKeyParameters ecKey;

	private byte[] z;

	public virtual string AlgorithmName => "SM2Sign";

	public SM2Signer()
		: this(StandardDsaEncoding.Instance, new SM3Digest())
	{
	}

	public SM2Signer(IDigest digest)
		: this(StandardDsaEncoding.Instance, digest)
	{
	}

	public SM2Signer(IDsaEncoding encoding)
		: this(encoding, new SM3Digest())
	{
	}

	public SM2Signer(IDsaEncoding encoding, IDigest digest)
	{
		this.encoding = encoding;
		this.digest = digest;
	}

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		ICipherParameters baseParam;
		byte[] userID;
		if (parameters is ParametersWithID)
		{
			baseParam = ((ParametersWithID)parameters).Parameters;
			userID = ((ParametersWithID)parameters).GetID();
			if (userID.Length >= 8192)
			{
				throw new ArgumentException("SM2 user ID must be less than 2^16 bits long");
			}
		}
		else
		{
			baseParam = parameters;
			userID = Hex.DecodeStrict("31323334353637383132333435363738");
		}
		if (forSigning)
		{
			if (baseParam is ParametersWithRandom)
			{
				ParametersWithRandom rParam = (ParametersWithRandom)baseParam;
				ecKey = (ECKeyParameters)rParam.Parameters;
				ecParams = ecKey.Parameters;
				kCalculator.Init(ecParams.N, rParam.Random);
			}
			else
			{
				ecKey = (ECKeyParameters)baseParam;
				ecParams = ecKey.Parameters;
				kCalculator.Init(ecParams.N, new SecureRandom());
			}
			pubPoint = CreateBasePointMultiplier().Multiply(ecParams.G, ((ECPrivateKeyParameters)ecKey).D).Normalize();
		}
		else
		{
			ecKey = (ECKeyParameters)baseParam;
			ecParams = ecKey.Parameters;
			pubPoint = ((ECPublicKeyParameters)ecKey).Q;
		}
		digest.Reset();
		z = GetZ(userID);
		digest.BlockUpdate(z, 0, z.Length);
	}

	public virtual void Update(byte b)
	{
		digest.Update(b);
	}

	public virtual void BlockUpdate(byte[] buf, int off, int len)
	{
		digest.BlockUpdate(buf, off, len);
	}

	public virtual bool VerifySignature(byte[] signature)
	{
		try
		{
			BigInteger[] rs = encoding.Decode(ecParams.N, signature);
			return VerifySignature(rs[0], rs[1]);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public virtual void Reset()
	{
		if (z != null)
		{
			digest.Reset();
			digest.BlockUpdate(z, 0, z.Length);
		}
	}

	public virtual byte[] GenerateSignature()
	{
		byte[] eHash = DigestUtilities.DoFinal(digest);
		BigInteger n = ecParams.N;
		BigInteger e = CalculateE(n, eHash);
		BigInteger d = ((ECPrivateKeyParameters)ecKey).D;
		ECMultiplier basePointMultiplier = CreateBasePointMultiplier();
		BigInteger r;
		BigInteger s;
		while (true)
		{
			BigInteger k = kCalculator.NextK();
			ECPoint p = basePointMultiplier.Multiply(ecParams.G, k).Normalize();
			r = e.Add(p.AffineXCoord.ToBigInteger()).Mod(n);
			if (r.SignValue != 0 && !r.Add(k).Equals(n))
			{
				BigInteger bigInteger = BigIntegers.ModOddInverse(n, d.Add(BigIntegers.One));
				s = k.Subtract(r.Multiply(d)).Mod(n);
				s = bigInteger.Multiply(s).Mod(n);
				if (s.SignValue != 0)
				{
					break;
				}
			}
		}
		try
		{
			return encoding.Encode(ecParams.N, r, s);
		}
		catch (Exception ex)
		{
			throw new CryptoException("unable to encode signature: " + ex.Message, ex);
		}
	}

	private bool VerifySignature(BigInteger r, BigInteger s)
	{
		BigInteger n = ecParams.N;
		if (r.CompareTo(BigInteger.One) < 0 || r.CompareTo(n) >= 0)
		{
			return false;
		}
		if (s.CompareTo(BigInteger.One) < 0 || s.CompareTo(n) >= 0)
		{
			return false;
		}
		byte[] eHash = DigestUtilities.DoFinal(digest);
		BigInteger e = CalculateE(n, eHash);
		BigInteger t = r.Add(s).Mod(n);
		if (t.SignValue == 0)
		{
			return false;
		}
		ECPoint q = ((ECPublicKeyParameters)ecKey).Q;
		ECPoint x1y1 = ECAlgorithms.SumOfTwoMultiplies(ecParams.G, s, q, t).Normalize();
		if (x1y1.IsInfinity)
		{
			return false;
		}
		return r.Equals(e.Add(x1y1.AffineXCoord.ToBigInteger()).Mod(n));
	}

	private byte[] GetZ(byte[] userID)
	{
		AddUserID(digest, userID);
		AddFieldElement(digest, ecParams.Curve.A);
		AddFieldElement(digest, ecParams.Curve.B);
		AddFieldElement(digest, ecParams.G.AffineXCoord);
		AddFieldElement(digest, ecParams.G.AffineYCoord);
		AddFieldElement(digest, pubPoint.AffineXCoord);
		AddFieldElement(digest, pubPoint.AffineYCoord);
		return DigestUtilities.DoFinal(digest);
	}

	private void AddUserID(IDigest digest, byte[] userID)
	{
		int len = userID.Length * 8;
		digest.Update((byte)(len >> 8));
		digest.Update((byte)len);
		digest.BlockUpdate(userID, 0, userID.Length);
	}

	private void AddFieldElement(IDigest digest, ECFieldElement v)
	{
		byte[] p = v.GetEncoded();
		digest.BlockUpdate(p, 0, p.Length);
	}

	protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
	{
		return new BigInteger(1, message);
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return new FixedPointCombMultiplier();
	}
}
