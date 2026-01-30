using System;
using System.IO;

namespace Org.BouncyCastle.Asn1;

public class DerExternal : Asn1Object
{
	private DerObjectIdentifier directReference;

	private DerInteger indirectReference;

	private Asn1Object dataValueDescriptor;

	private int encoding;

	private Asn1Object externalContent;

	public Asn1Object DataValueDescriptor
	{
		get
		{
			return dataValueDescriptor;
		}
		set
		{
			dataValueDescriptor = value;
		}
	}

	public DerObjectIdentifier DirectReference
	{
		get
		{
			return directReference;
		}
		set
		{
			directReference = value;
		}
	}

	public int Encoding
	{
		get
		{
			return encoding;
		}
		set
		{
			if (encoding < 0 || encoding > 2)
			{
				throw new InvalidOperationException("invalid encoding value: " + encoding);
			}
			encoding = value;
		}
	}

	public Asn1Object ExternalContent
	{
		get
		{
			return externalContent;
		}
		set
		{
			externalContent = value;
		}
	}

	public DerInteger IndirectReference
	{
		get
		{
			return indirectReference;
		}
		set
		{
			indirectReference = value;
		}
	}

	public DerExternal(Asn1EncodableVector vector)
	{
		int offset = 0;
		Asn1Object enc = GetObjFromVector(vector, offset);
		if (enc is DerObjectIdentifier)
		{
			directReference = (DerObjectIdentifier)enc;
			offset++;
			enc = GetObjFromVector(vector, offset);
		}
		if (enc is DerInteger)
		{
			indirectReference = (DerInteger)enc;
			offset++;
			enc = GetObjFromVector(vector, offset);
		}
		if (!(enc is Asn1TaggedObject))
		{
			dataValueDescriptor = enc;
			offset++;
			enc = GetObjFromVector(vector, offset);
		}
		if (vector.Count != offset + 1)
		{
			throw new ArgumentException("input vector too large", "vector");
		}
		if (!(enc is Asn1TaggedObject))
		{
			throw new ArgumentException("No tagged object found in vector. Structure doesn't seem to be of type External", "vector");
		}
		Asn1TaggedObject obj = (Asn1TaggedObject)enc;
		Encoding = obj.TagNo;
		if (encoding < 0 || encoding > 2)
		{
			throw new InvalidOperationException("invalid encoding value");
		}
		externalContent = obj.GetObject();
	}

	public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1Object dataValueDescriptor, DerTaggedObject externalData)
		: this(directReference, indirectReference, dataValueDescriptor, externalData.TagNo, externalData.ToAsn1Object())
	{
	}

	public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1Object dataValueDescriptor, int encoding, Asn1Object externalData)
	{
		DirectReference = directReference;
		IndirectReference = indirectReference;
		DataValueDescriptor = dataValueDescriptor;
		Encoding = encoding;
		ExternalContent = externalData.ToAsn1Object();
	}

	internal override int EncodedLength(bool withID)
	{
		int contentsLength = 0;
		if (directReference != null)
		{
			contentsLength += directReference.EncodedLength(withID: true);
		}
		if (indirectReference != null)
		{
			contentsLength += indirectReference.EncodedLength(withID: true);
		}
		if (dataValueDescriptor != null)
		{
			contentsLength += dataValueDescriptor.GetDerEncoded().Length;
		}
		contentsLength += new DerTaggedObject(8, externalContent).EncodedLength(withID: true);
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		MemoryStream ms = new MemoryStream();
		WriteEncodable(ms, directReference);
		WriteEncodable(ms, indirectReference);
		WriteEncodable(ms, dataValueDescriptor);
		WriteEncodable(ms, new DerTaggedObject(8, externalContent));
		asn1Out.WriteEncodingDL(withID, 40, ms.ToArray());
	}

	protected override int Asn1GetHashCode()
	{
		int ret = externalContent.GetHashCode();
		if (directReference != null)
		{
			ret ^= directReference.GetHashCode();
		}
		if (indirectReference != null)
		{
			ret ^= indirectReference.GetHashCode();
		}
		if (dataValueDescriptor != null)
		{
			ret ^= dataValueDescriptor.GetHashCode();
		}
		return ret;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (this == asn1Object)
		{
			return true;
		}
		if (!(asn1Object is DerExternal other))
		{
			return false;
		}
		if (object.Equals(directReference, other.directReference) && object.Equals(indirectReference, other.indirectReference) && object.Equals(dataValueDescriptor, other.dataValueDescriptor))
		{
			return externalContent.Equals(other.externalContent);
		}
		return false;
	}

	private static Asn1Object GetObjFromVector(Asn1EncodableVector v, int index)
	{
		if (v.Count <= index)
		{
			throw new ArgumentException("too few objects in input vector", "v");
		}
		return v[index].ToAsn1Object();
	}

	private static void WriteEncodable(MemoryStream ms, Asn1Encodable e)
	{
		if (e != null)
		{
			byte[] bs = e.GetDerEncoded();
			ms.Write(bs, 0, bs.Length);
		}
	}
}
