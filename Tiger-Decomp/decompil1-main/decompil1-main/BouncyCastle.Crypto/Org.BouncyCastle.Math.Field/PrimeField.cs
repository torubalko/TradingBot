namespace Org.BouncyCastle.Math.Field;

internal class PrimeField : IFiniteField
{
	protected readonly BigInteger characteristic;

	public virtual BigInteger Characteristic => characteristic;

	public virtual int Dimension => 1;

	internal PrimeField(BigInteger characteristic)
	{
		this.characteristic = characteristic;
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is PrimeField other))
		{
			return false;
		}
		return characteristic.Equals(other.characteristic);
	}

	public override int GetHashCode()
	{
		return characteristic.GetHashCode();
	}
}
