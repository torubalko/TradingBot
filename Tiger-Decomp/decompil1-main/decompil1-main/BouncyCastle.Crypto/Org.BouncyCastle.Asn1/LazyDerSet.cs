using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1;

internal class LazyDerSet : DerSet
{
	private byte[] encoded;

	public override Asn1Encodable this[int index]
	{
		get
		{
			Parse();
			return base[index];
		}
	}

	public override int Count
	{
		get
		{
			Parse();
			return base.Count;
		}
	}

	internal LazyDerSet(byte[] encoded)
	{
		if (encoded == null)
		{
			throw new ArgumentNullException("encoded");
		}
		this.encoded = encoded;
	}

	private void Parse()
	{
		lock (this)
		{
			if (encoded != null)
			{
				Asn1EncodableVector v = new LazyAsn1InputStream(encoded).ReadVector();
				elements = v.TakeElements();
				encoded = null;
			}
		}
	}

	public override IEnumerator GetEnumerator()
	{
		Parse();
		return base.GetEnumerator();
	}

	internal override int EncodedLength(bool withID)
	{
		lock (this)
		{
			if (encoded == null)
			{
				return base.EncodedLength(withID);
			}
			return Asn1OutputStream.GetLengthOfEncodingDL(withID, encoded.Length);
		}
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		lock (this)
		{
			if (encoded == null)
			{
				base.Encode(asn1Out, withID);
			}
			else
			{
				asn1Out.WriteEncodingDL(withID, 49, encoded);
			}
		}
	}
}
