using System.Collections;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class DHParameter : Asn1Encodable
{
	internal DerInteger p;

	internal DerInteger g;

	internal DerInteger l;

	public BigInteger P => p.PositiveValue;

	public BigInteger G => g.PositiveValue;

	public BigInteger L
	{
		get
		{
			if (l != null)
			{
				return l.PositiveValue;
			}
			return null;
		}
	}

	public DHParameter(BigInteger p, BigInteger g, int l)
	{
		this.p = new DerInteger(p);
		this.g = new DerInteger(g);
		if (l != 0)
		{
			this.l = new DerInteger(l);
		}
	}

	public DHParameter(Asn1Sequence seq)
	{
		IEnumerator e = seq.GetEnumerator();
		e.MoveNext();
		p = (DerInteger)e.Current;
		e.MoveNext();
		g = (DerInteger)e.Current;
		if (e.MoveNext())
		{
			l = (DerInteger)e.Current;
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector v = new Asn1EncodableVector(p, g);
		v.AddOptional(l);
		return new DerSequence(v);
	}
}
