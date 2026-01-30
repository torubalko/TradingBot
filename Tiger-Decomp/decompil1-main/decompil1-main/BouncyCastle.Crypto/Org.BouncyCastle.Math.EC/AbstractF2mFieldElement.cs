using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractF2mFieldElement : ECFieldElement
{
	public virtual bool HasFastTrace => false;

	public virtual ECFieldElement HalfTrace()
	{
		int fieldSize = FieldSize;
		if ((fieldSize & 1) == 0)
		{
			throw new InvalidOperationException("Half-trace only defined for odd m");
		}
		int n = fieldSize + 1 >> 1;
		int k = 31 - Integers.NumberOfLeadingZeros(n);
		int nk = 1;
		ECFieldElement ht = this;
		while (k > 0)
		{
			ht = ht.SquarePow(nk << 1).Add(ht);
			nk = n >> --k;
			if ((nk & 1) != 0)
			{
				ht = ht.SquarePow(2).Add(this);
			}
		}
		return ht;
	}

	public virtual int Trace()
	{
		int m = FieldSize;
		int k = 31 - Integers.NumberOfLeadingZeros(m);
		int mk = 1;
		ECFieldElement tr = this;
		while (k > 0)
		{
			tr = tr.SquarePow(mk).Add(tr);
			mk = m >> --k;
			if ((mk & 1) != 0)
			{
				tr = tr.Square().Add(this);
			}
		}
		if (tr.IsZero)
		{
			return 0;
		}
		if (tr.IsOne)
		{
			return 1;
		}
		throw new InvalidOperationException("Internal error in trace calculation");
	}
}
