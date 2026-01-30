using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters;

public class DHPublicKeyParameters : DHKeyParameters
{
	private readonly BigInteger y;

	public virtual BigInteger Y => y;

	private static BigInteger Validate(BigInteger y, DHParameters dhParams)
	{
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		BigInteger p = dhParams.P;
		if (y.CompareTo(BigInteger.Two) < 0 || y.CompareTo(p.Subtract(BigInteger.Two)) > 0)
		{
			throw new ArgumentException("invalid DH public key", "y");
		}
		BigInteger q = dhParams.Q;
		if (q == null)
		{
			return y;
		}
		if (p.TestBit(0) && p.BitLength - 1 == q.BitLength && p.ShiftRight(1).Equals(q))
		{
			if (1 == Legendre(y, p))
			{
				return y;
			}
		}
		else if (BigInteger.One.Equals(y.ModPow(q, p)))
		{
			return y;
		}
		throw new ArgumentException("value does not appear to be in correct group", "y");
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		: base(isPrivate: false, parameters)
	{
		this.y = Validate(y, parameters);
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		: base(isPrivate: false, parameters, algorithmOid)
	{
		this.y = Validate(y, parameters);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is DHPublicKeyParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected bool Equals(DHPublicKeyParameters other)
	{
		if (y.Equals(other.y))
		{
			return Equals((DHKeyParameters)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return y.GetHashCode() ^ base.GetHashCode();
	}

	private static int Legendre(BigInteger a, BigInteger b)
	{
		int bitLength = b.BitLength;
		uint[] A = Nat.FromBigInteger(bitLength, a);
		uint[] B = Nat.FromBigInteger(bitLength, b);
		int r = 0;
		int len = B.Length;
		while (true)
		{
			if (A[0] == 0)
			{
				Nat.ShiftDownWord(len, A, 0u);
				continue;
			}
			int shift = Integers.NumberOfTrailingZeros((int)A[0]);
			if (shift > 0)
			{
				Nat.ShiftDownBits(len, A, shift, 0u);
				int bits = (int)B[0];
				r ^= (bits ^ (bits >> 1)) & (shift << 1);
			}
			int cmp = Nat.Compare(len, A, B);
			if (cmp == 0)
			{
				break;
			}
			if (cmp < 0)
			{
				r ^= (int)(A[0] & B[0]);
				uint[] array = A;
				A = B;
				B = array;
			}
			while (A[len - 1] == 0)
			{
				len--;
			}
			Nat.Sub(len, A, B, A);
		}
		if (!Nat.IsOne(len, B))
		{
			return 0;
		}
		return 1 - (r & 2);
	}
}
