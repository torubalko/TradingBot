using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerApplicationSpecific : Asn1Object
{
	private readonly bool isConstructed;

	private readonly int tag;

	private readonly byte[] octets;

	public int ApplicationTag => tag;

	internal DerApplicationSpecific(bool isConstructed, int tag, byte[] octets)
	{
		this.isConstructed = isConstructed;
		this.tag = tag;
		this.octets = octets;
	}

	public DerApplicationSpecific(int tag, byte[] octets)
		: this(isConstructed: false, tag, octets)
	{
	}

	public DerApplicationSpecific(int tag, Asn1Encodable obj)
		: this(isExplicit: true, tag, obj)
	{
	}

	public DerApplicationSpecific(bool isExplicit, int tag, Asn1Encodable obj)
	{
		Asn1Object asn1Obj = obj.ToAsn1Object();
		byte[] data = asn1Obj.GetDerEncoded();
		isConstructed = Asn1TaggedObject.IsConstructed(isExplicit, asn1Obj);
		this.tag = tag;
		if (isExplicit)
		{
			octets = data;
			return;
		}
		int lenBytes = GetLengthOfHeader(data);
		byte[] tmp = new byte[data.Length - lenBytes];
		Array.Copy(data, lenBytes, tmp, 0, tmp.Length);
		octets = tmp;
	}

	public DerApplicationSpecific(int tagNo, Asn1EncodableVector vec)
	{
		tag = tagNo;
		isConstructed = true;
		MemoryStream bOut = new MemoryStream();
		for (int i = 0; i != vec.Count; i++)
		{
			try
			{
				byte[] bs = vec[i].GetDerEncoded();
				bOut.Write(bs, 0, bs.Length);
			}
			catch (IOException innerException)
			{
				throw new InvalidOperationException("malformed object", innerException);
			}
		}
		octets = bOut.ToArray();
	}

	private int GetLengthOfHeader(byte[] data)
	{
		int length = data[1];
		if (length == 128)
		{
			return 2;
		}
		if (length > 127)
		{
			int size = length & 0x7F;
			if (size > 4)
			{
				throw new InvalidOperationException("DER length more than 4 bytes: " + size);
			}
			return size + 2;
		}
		return 2;
	}

	public bool IsConstructed()
	{
		return isConstructed;
	}

	public byte[] GetContents()
	{
		return octets;
	}

	public Asn1Object GetObject()
	{
		return Asn1Object.FromByteArray(GetContents());
	}

	public Asn1Object GetObject(int derTagNo)
	{
		if (derTagNo >= 31)
		{
			throw new IOException("unsupported tag number");
		}
		byte[] orig = GetEncoded();
		byte[] tmp = ReplaceTagNumber(derTagNo, orig);
		if ((orig[0] & 0x20) != 0)
		{
			tmp[0] |= 32;
		}
		return Asn1Object.FromByteArray(tmp);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, tag, octets.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		int flags = 64;
		if (isConstructed)
		{
			flags |= 0x20;
		}
		asn1Out.WriteEncodingDL(withID, flags, tag, octets);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerApplicationSpecific other))
		{
			return false;
		}
		if (isConstructed == other.isConstructed && tag == other.tag)
		{
			return Arrays.AreEqual(octets, other.octets);
		}
		return false;
	}

	protected override int Asn1GetHashCode()
	{
		return isConstructed.GetHashCode() ^ tag.GetHashCode() ^ Arrays.GetHashCode(octets);
	}

	private byte[] ReplaceTagNumber(int newTag, byte[] input)
	{
		int num = input[0] & 0x1F;
		int index = 1;
		if (num == 31)
		{
			int b = input[index++];
			if ((b & 0x7F) == 0)
			{
				throw new IOException("corrupted stream - invalid high tag number found");
			}
			while ((b & 0x80) != 0)
			{
				b = input[index++];
			}
		}
		int remaining = input.Length - index;
		byte[] tmp = new byte[1 + remaining];
		tmp[0] = (byte)newTag;
		Array.Copy(input, index, tmp, 1, remaining);
		return tmp;
	}
}
