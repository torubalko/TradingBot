using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1;

public class Asn1InputStream : FilterStream
{
	private readonly int limit;

	internal readonly byte[][] tmpBuffers;

	internal virtual int Limit => limit;

	internal static int FindLimit(Stream input)
	{
		if (input is LimitedInputStream)
		{
			return ((LimitedInputStream)input).Limit;
		}
		if (input is Asn1InputStream)
		{
			return ((Asn1InputStream)input).Limit;
		}
		if (input is MemoryStream)
		{
			MemoryStream mem = (MemoryStream)input;
			return (int)(mem.Length - mem.Position);
		}
		return int.MaxValue;
	}

	public Asn1InputStream(Stream input)
		: this(input, FindLimit(input))
	{
	}

	public Asn1InputStream(byte[] input)
		: this(new MemoryStream(input, writable: false), input.Length)
	{
	}

	public Asn1InputStream(Stream input, int limit)
		: this(input, limit, new byte[16][])
	{
	}

	internal Asn1InputStream(Stream input, int limit, byte[][] tmpBuffers)
		: base(input)
	{
		this.limit = limit;
		this.tmpBuffers = tmpBuffers;
	}

	private Asn1Object BuildObject(int tag, int tagNo, int length)
	{
		bool isConstructed = (tag & 0x20) != 0;
		DefiniteLengthInputStream defIn = new DefiniteLengthInputStream(this, length, limit);
		if ((tag & 0xC0) != 0)
		{
			if ((tag & 0x40) != 0)
			{
				return new DerApplicationSpecific(isConstructed, tagNo, defIn.ToArray());
			}
			return new Asn1StreamParser(defIn, defIn.Remaining, tmpBuffers).ReadTaggedObject(isConstructed, tagNo);
		}
		if (!isConstructed)
		{
			return CreatePrimitiveDerObject(tagNo, defIn, tmpBuffers);
		}
		return tagNo switch
		{
			3 => BuildConstructedBitString(ReadVector(defIn)), 
			4 => BuildConstructedOctetString(ReadVector(defIn)), 
			16 => CreateDerSequence(defIn), 
			17 => CreateDerSet(defIn), 
			8 => new DerExternal(ReadVector(defIn)), 
			_ => throw new IOException("unknown tag " + tagNo + " encountered"), 
		};
	}

	internal virtual Asn1EncodableVector ReadVector()
	{
		Asn1Object o = ReadObject();
		if (o == null)
		{
			return new Asn1EncodableVector(0);
		}
		Asn1EncodableVector v = new Asn1EncodableVector();
		do
		{
			v.Add(o);
		}
		while ((o = ReadObject()) != null);
		return v;
	}

	internal virtual Asn1EncodableVector ReadVector(DefiniteLengthInputStream defIn)
	{
		int remaining = defIn.Remaining;
		if (remaining < 1)
		{
			return new Asn1EncodableVector(0);
		}
		return new Asn1InputStream(defIn, remaining, tmpBuffers).ReadVector();
	}

	internal virtual DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
	{
		return DerSequence.FromVector(ReadVector(dIn));
	}

	internal virtual DerSet CreateDerSet(DefiniteLengthInputStream dIn)
	{
		return DerSet.FromVector(ReadVector(dIn), needsSorting: false);
	}

	public Asn1Object ReadObject()
	{
		int tag = ReadByte();
		if (tag <= 0)
		{
			if (tag == 0)
			{
				throw new IOException("unexpected end-of-contents marker");
			}
			return null;
		}
		int tagNo = ReadTagNumber(this, tag);
		int length = ReadLength(this, limit, isParsing: false);
		if (length >= 0)
		{
			try
			{
				return BuildObject(tag, tagNo, length);
			}
			catch (ArgumentException exception)
			{
				throw new Asn1Exception("corrupted stream detected", exception);
			}
		}
		if ((tag & 0x20) == 0)
		{
			throw new IOException("indefinite-length primitive encoding encountered");
		}
		Asn1StreamParser sp = new Asn1StreamParser(new IndefiniteLengthInputStream(this, limit), limit, tmpBuffers);
		if ((tag & 0xC0) != 0)
		{
			if ((tag & 0x40) != 0)
			{
				return new BerApplicationSpecificParser(tagNo, sp).ToAsn1Object();
			}
			return new BerTaggedObjectParser(constructed: true, tagNo, sp).ToAsn1Object();
		}
		return tagNo switch
		{
			4 => BerOctetStringParser.Parse(sp), 
			16 => BerSequenceParser.Parse(sp), 
			17 => BerSetParser.Parse(sp), 
			8 => DerExternalParser.Parse(sp), 
			_ => throw new IOException("unknown BER object encountered"), 
		};
	}

	internal virtual DerBitString BuildConstructedBitString(Asn1EncodableVector contentsElements)
	{
		DerBitString[] bitStrings = new DerBitString[contentsElements.Count];
		for (int i = 0; i != bitStrings.Length; i++)
		{
			if (!(contentsElements[i] is DerBitString bitString))
			{
				throw new Asn1Exception("unknown object encountered in constructed BIT STRING: " + Platform.GetTypeName(contentsElements[i]));
			}
			bitStrings[i] = bitString;
		}
		return new BerBitString(bitStrings);
	}

	internal virtual Asn1OctetString BuildConstructedOctetString(Asn1EncodableVector contentsElements)
	{
		Asn1OctetString[] octetStrings = new Asn1OctetString[contentsElements.Count];
		for (int i = 0; i != octetStrings.Length; i++)
		{
			if (!(contentsElements[i] is Asn1OctetString octetString))
			{
				throw new Asn1Exception("unknown object encountered in constructed OCTET STRING: " + Platform.GetTypeName(contentsElements[i]));
			}
			octetStrings[i] = octetString;
		}
		return new BerOctetString(octetStrings);
	}

	internal static int ReadTagNumber(Stream s, int tag)
	{
		int tagNo = tag & 0x1F;
		if (tagNo == 31)
		{
			tagNo = 0;
			int b = s.ReadByte();
			if (b < 31)
			{
				if (b < 0)
				{
					throw new EndOfStreamException("EOF found inside tag value.");
				}
				throw new IOException("corrupted stream - high tag number < 31 found");
			}
			if ((b & 0x7F) == 0)
			{
				throw new IOException("corrupted stream - invalid high tag number found");
			}
			while ((b & 0x80) != 0)
			{
				if ((uint)tagNo >> 24 != 0)
				{
					throw new IOException("Tag number more than 31 bits");
				}
				tagNo |= b & 0x7F;
				tagNo <<= 7;
				b = s.ReadByte();
				if (b < 0)
				{
					throw new EndOfStreamException("EOF found inside tag value.");
				}
			}
			tagNo |= b & 0x7F;
		}
		return tagNo;
	}

	internal static int ReadLength(Stream s, int limit, bool isParsing)
	{
		int length = s.ReadByte();
		if (length >>> 7 == 0)
		{
			return length;
		}
		if (128 == length)
		{
			return -1;
		}
		if (length < 0)
		{
			throw new EndOfStreamException("EOF found when length expected");
		}
		if (255 == length)
		{
			throw new IOException("invalid long form definite-length 0xFF");
		}
		int octetsCount = length & 0x7F;
		int octetsPos = 0;
		length = 0;
		do
		{
			int octet = s.ReadByte();
			if (octet < 0)
			{
				throw new EndOfStreamException("EOF found reading length");
			}
			if ((uint)length >> 23 != 0)
			{
				throw new IOException("long form definite-length more than 31 bits");
			}
			length = (length << 8) + octet;
		}
		while (++octetsPos < octetsCount);
		if (length >= limit && !isParsing)
		{
			throw new IOException("corrupted stream - out of bounds length found: " + length + " >= " + limit);
		}
		return length;
	}

	private static byte[] GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		int len = defIn.Remaining;
		if (len >= tmpBuffers.Length)
		{
			return defIn.ToArray();
		}
		byte[] buf = tmpBuffers[len];
		if (buf == null)
		{
			buf = (tmpBuffers[len] = new byte[len]);
		}
		defIn.ReadAllIntoByteArray(buf);
		return buf;
	}

	private static char[] GetBmpCharBuffer(DefiniteLengthInputStream defIn)
	{
		int remainingBytes = defIn.Remaining;
		if ((remainingBytes & 1) != 0)
		{
			throw new IOException("malformed BMPString encoding encountered");
		}
		char[] str = new char[remainingBytes / 2];
		int stringPos = 0;
		byte[] buf = new byte[8];
		while (remainingBytes >= 8)
		{
			if (Streams.ReadFully(defIn, buf, 0, 8) != 8)
			{
				throw new EndOfStreamException("EOF encountered in middle of BMPString");
			}
			str[stringPos] = (char)((buf[0] << 8) | (buf[1] & 0xFF));
			str[stringPos + 1] = (char)((buf[2] << 8) | (buf[3] & 0xFF));
			str[stringPos + 2] = (char)((buf[4] << 8) | (buf[5] & 0xFF));
			str[stringPos + 3] = (char)((buf[6] << 8) | (buf[7] & 0xFF));
			stringPos += 4;
			remainingBytes -= 8;
		}
		if (remainingBytes > 0)
		{
			if (Streams.ReadFully(defIn, buf, 0, remainingBytes) != remainingBytes)
			{
				throw new EndOfStreamException("EOF encountered in middle of BMPString");
			}
			int bufPos = 0;
			do
			{
				int b1 = buf[bufPos++] << 8;
				int b2 = buf[bufPos++] & 0xFF;
				str[stringPos++] = (char)(b1 | b2);
			}
			while (bufPos < remainingBytes);
		}
		if (defIn.Remaining != 0 || str.Length != stringPos)
		{
			throw new InvalidOperationException();
		}
		return str;
	}

	internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
	{
		switch (tagNo)
		{
		case 30:
			return new DerBmpString(GetBmpCharBuffer(defIn));
		case 1:
			return DerBoolean.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 10:
			return DerEnumerated.FromOctetString(GetBuffer(defIn, tmpBuffers));
		case 6:
			return DerObjectIdentifier.CreatePrimitive(GetBuffer(defIn, tmpBuffers), clone: true);
		default:
		{
			byte[] bytes = defIn.ToArray();
			switch (tagNo)
			{
			case 3:
				return DerBitString.CreatePrimitive(bytes);
			case 24:
				return new DerGeneralizedTime(bytes);
			case 27:
				return new DerGeneralString(bytes);
			case 25:
				return new DerGraphicString(bytes);
			case 22:
				return new DerIA5String(bytes);
			case 2:
				return new DerInteger(bytes, clone: false);
			case 5:
				if (bytes.Length != 0)
				{
					throw new InvalidOperationException("malformed NULL encoding encountered");
				}
				return DerNull.Instance;
			case 18:
				return new DerNumericString(bytes);
			case 4:
				return new DerOctetString(bytes);
			case 19:
				return new DerPrintableString(bytes);
			case 20:
				return new DerT61String(bytes);
			case 28:
				return new DerUniversalString(bytes);
			case 23:
				return new DerUtcTime(bytes);
			case 12:
				return new DerUtf8String(bytes);
			case 21:
				return new DerVideotexString(bytes);
			case 26:
				return new DerVisibleString(bytes);
			default:
				throw new IOException("unknown tag " + tagNo + " encountered");
			}
		}
		}
	}
}
