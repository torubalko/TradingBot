using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class BerBitString : DerBitString
{
	private const int DefaultSegmentLimit = 1000;

	private readonly int segmentLimit;

	private readonly DerBitString[] elements;

	private bool IsConstructed
	{
		get
		{
			if (elements == null)
			{
				return contents.Length > segmentLimit;
			}
			return true;
		}
	}

	internal static byte[] FlattenBitStrings(DerBitString[] bitStrings)
	{
		int count = bitStrings.Length;
		switch (count)
		{
		case 0:
			return new byte[1];
		case 1:
			return bitStrings[0].contents;
		default:
		{
			int last = count - 1;
			int totalLength = 0;
			for (int i = 0; i < last; i++)
			{
				byte[] elementContents = bitStrings[i].contents;
				if (elementContents[0] != 0)
				{
					throw new ArgumentException("only the last nested bitstring can have padding", "bitStrings");
				}
				totalLength += elementContents.Length - 1;
			}
			byte[] lastElementContents = bitStrings[last].contents;
			byte padBits = lastElementContents[0];
			totalLength += lastElementContents.Length;
			byte[] contents = new byte[totalLength];
			contents[0] = padBits;
			int pos = 1;
			for (int j = 0; j < count; j++)
			{
				byte[] array = bitStrings[j].contents;
				int length = array.Length - 1;
				Array.Copy(array, 1, contents, pos, length);
				pos += length;
			}
			return contents;
		}
		}
	}

	public BerBitString(byte data, int padBits)
		: base(data, padBits)
	{
		elements = null;
		segmentLimit = 1000;
	}

	public BerBitString(byte[] data)
		: this(data, 0)
	{
	}

	public BerBitString(byte[] data, int padBits)
		: this(data, padBits, 1000)
	{
	}

	public BerBitString(byte[] data, int padBits, int segmentLimit)
		: base(data, padBits)
	{
		elements = null;
		this.segmentLimit = segmentLimit;
	}

	public BerBitString(int namedBits)
		: base(namedBits)
	{
		elements = null;
		segmentLimit = 1000;
	}

	public BerBitString(Asn1Encodable obj)
		: this(obj.GetDerEncoded(), 0)
	{
	}

	public BerBitString(DerBitString[] elements)
		: this(elements, 1000)
	{
	}

	public BerBitString(DerBitString[] elements, int segmentLimit)
		: base(FlattenBitStrings(elements), check: false)
	{
		this.elements = elements;
		this.segmentLimit = segmentLimit;
	}

	internal BerBitString(byte[] contents, bool check)
		: base(contents, check)
	{
		elements = null;
		segmentLimit = 1000;
	}

	internal override int EncodedLength(bool withID)
	{
		throw Platform.CreateNotImplementedException("BerBitString.EncodedLength");
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		if (!asn1Out.IsBer)
		{
			base.Encode(asn1Out, withID);
			return;
		}
		if (!IsConstructed)
		{
			DerBitString.Encode(asn1Out, withID, contents, 0, contents.Length);
			return;
		}
		asn1Out.WriteIdentifier(withID, 35);
		asn1Out.WriteByte(128);
		if (elements != null)
		{
			Asn1Object[] primitives = elements;
			asn1Out.WritePrimitives(primitives);
		}
		else if (contents.Length >= 2)
		{
			byte pad = contents[0];
			int length = contents.Length;
			int remaining = length - 1;
			int segmentLength = segmentLimit - 1;
			while (remaining > segmentLength)
			{
				DerBitString.Encode(asn1Out, withID: true, 0, contents, length - remaining, segmentLength);
				remaining -= segmentLength;
			}
			DerBitString.Encode(asn1Out, withID: true, pad, contents, length - remaining, remaining);
		}
		asn1Out.WriteByte(0);
		asn1Out.WriteByte(0);
	}
}
