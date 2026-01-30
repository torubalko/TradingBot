using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.Field;

internal class GF2Polynomial : IPolynomial
{
	protected readonly int[] exponents;

	public virtual int Degree => exponents[exponents.Length - 1];

	internal GF2Polynomial(int[] exponents)
	{
		this.exponents = Arrays.Clone(exponents);
	}

	public virtual int[] GetExponentsPresent()
	{
		return Arrays.Clone(exponents);
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is GF2Polynomial other))
		{
			return false;
		}
		return Arrays.AreEqual(exponents, other.exponents);
	}

	public override int GetHashCode()
	{
		return Arrays.GetHashCode(exponents);
	}
}
