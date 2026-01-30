using System;
using System.IO;

namespace Org.BouncyCastle.Asn1;

public class Asn1StreamParser
{
	private readonly Stream _in;

	private readonly int _limit;

	private readonly byte[][] tmpBuffers;

	public Asn1StreamParser(Stream input)
		: this(input, Asn1InputStream.FindLimit(input))
	{
	}

	public Asn1StreamParser(byte[] encoding)
		: this(new MemoryStream(encoding, writable: false), encoding.Length)
	{
	}

	public Asn1StreamParser(Stream input, int limit)
		: this(input, limit, new byte[16][])
	{
	}

	internal Asn1StreamParser(Stream input, int limit, byte[][] tmpBuffers)
	{
		if (!input.CanRead)
		{
			throw new ArgumentException("Expected stream to be readable", "input");
		}
		_in = input;
		_limit = limit;
		this.tmpBuffers = tmpBuffers;
	}

	internal IAsn1Convertible ReadIndef(int tagValue)
	{
		return tagValue switch
		{
			8 => new DerExternalParser(this), 
			4 => new BerOctetStringParser(this), 
			16 => new BerSequenceParser(this), 
			17 => new BerSetParser(this), 
			_ => throw new Asn1Exception("unknown BER object encountered: 0x" + tagValue.ToString("X")), 
		};
	}

	internal IAsn1Convertible ReadImplicit(bool constructed, int tag)
	{
		if (_in is IndefiniteLengthInputStream)
		{
			if (!constructed)
			{
				throw new IOException("indefinite-length primitive encoding encountered");
			}
			return ReadIndef(tag);
		}
		if (constructed)
		{
			switch (tag)
			{
			case 17:
				return new DerSetParser(this);
			case 16:
				return new DerSequenceParser(this);
			case 4:
				return new BerOctetStringParser(this);
			}
		}
		else
		{
			switch (tag)
			{
			case 17:
				throw new Asn1Exception("sequences must use constructed encoding (see X.690 8.9.1/8.10.1)");
			case 16:
				throw new Asn1Exception("sets must use constructed encoding (see X.690 8.11.1/8.12.1)");
			case 4:
				return new DerOctetStringParser((DefiniteLengthInputStream)_in);
			}
		}
		throw new Asn1Exception("implicit tagging not implemented");
	}

	internal Asn1Object ReadTaggedObject(bool constructed, int tag)
	{
		if (!constructed)
		{
			DefiniteLengthInputStream defIn = (DefiniteLengthInputStream)_in;
			return new DerTaggedObject(explicitly: false, tag, new DerOctetString(defIn.ToArray()));
		}
		Asn1EncodableVector v = ReadVector();
		if (_in is IndefiniteLengthInputStream)
		{
			if (v.Count != 1)
			{
				return new BerTaggedObject(explicitly: false, tag, BerSequence.FromVector(v));
			}
			return new BerTaggedObject(explicitly: true, tag, v[0]);
		}
		if (v.Count != 1)
		{
			return new DerTaggedObject(explicitly: false, tag, DerSequence.FromVector(v));
		}
		return new DerTaggedObject(explicitly: true, tag, v[0]);
	}

	public virtual IAsn1Convertible ReadObject()
	{
		int tag = _in.ReadByte();
		if (tag == -1)
		{
			return null;
		}
		Set00Check(enabled: false);
		int tagNo = Asn1InputStream.ReadTagNumber(_in, tag);
		bool isConstructed = (tag & 0x20) != 0;
		int length = Asn1InputStream.ReadLength(_in, _limit, tagNo == 4 || tagNo == 16 || tagNo == 17 || tagNo == 8);
		if (length < 0)
		{
			if (!isConstructed)
			{
				throw new IOException("indefinite-length primitive encoding encountered");
			}
			Asn1StreamParser sp = new Asn1StreamParser(new IndefiniteLengthInputStream(_in, _limit), _limit, tmpBuffers);
			if ((tag & 0xC0) != 0)
			{
				if ((tag & 0x40) != 0)
				{
					return new BerApplicationSpecificParser(tagNo, sp);
				}
				return new BerTaggedObjectParser(constructed: true, tagNo, sp);
			}
			return sp.ReadIndef(tagNo);
		}
		DefiniteLengthInputStream defIn = new DefiniteLengthInputStream(_in, length, _limit);
		if ((tag & 0xC0) != 0)
		{
			if ((tag & 0x40) != 0)
			{
				return new DerApplicationSpecific(isConstructed, tagNo, defIn.ToArray());
			}
			return new BerTaggedObjectParser(isConstructed, tagNo, new Asn1StreamParser(defIn, defIn.Remaining, tmpBuffers));
		}
		if (!isConstructed)
		{
			if (tagNo == 4)
			{
				return new DerOctetStringParser(defIn);
			}
			try
			{
				return Asn1InputStream.CreatePrimitiveDerObject(tagNo, defIn, tmpBuffers);
			}
			catch (ArgumentException exception)
			{
				throw new Asn1Exception("corrupted stream detected", exception);
			}
		}
		Asn1StreamParser sp2 = new Asn1StreamParser(defIn, defIn.Remaining, tmpBuffers);
		return tagNo switch
		{
			4 => new BerOctetStringParser(sp2), 
			16 => new DerSequenceParser(sp2), 
			17 => new DerSetParser(sp2), 
			8 => new DerExternalParser(sp2), 
			_ => throw new IOException("unknown tag " + tagNo + " encountered"), 
		};
	}

	private void Set00Check(bool enabled)
	{
		if (_in is IndefiniteLengthInputStream)
		{
			((IndefiniteLengthInputStream)_in).SetEofOn00(enabled);
		}
	}

	internal Asn1EncodableVector ReadVector()
	{
		IAsn1Convertible obj = ReadObject();
		if (obj == null)
		{
			return new Asn1EncodableVector(0);
		}
		Asn1EncodableVector v = new Asn1EncodableVector();
		do
		{
			v.Add(obj.ToAsn1Object());
		}
		while ((obj = ReadObject()) != null);
		return v;
	}
}
