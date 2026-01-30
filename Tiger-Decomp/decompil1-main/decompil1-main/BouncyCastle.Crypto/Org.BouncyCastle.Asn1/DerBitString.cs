using System;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerBitString : DerStringBase
{
	private static readonly char[] table = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	internal readonly byte[] contents;

	public virtual int PadBits => contents[0];

	public virtual int IntValue
	{
		get
		{
			int value = 0;
			int end = System.Math.Min(5, contents.Length - 1);
			for (int i = 1; i < end; i++)
			{
				value |= contents[i] << 8 * (i - 1);
			}
			if (1 <= end && end < 5)
			{
				int padBits = contents[0];
				byte der = (byte)(contents[end] & (255 << padBits));
				value |= der << 8 * (end - 1);
			}
			return value;
		}
	}

	public static DerBitString GetInstance(object obj)
	{
		if (obj == null || obj is DerBitString)
		{
			return (DerBitString)obj;
		}
		if (obj is byte[])
		{
			try
			{
				return (DerBitString)Asn1Object.FromByteArray((byte[])obj);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("encoding error in GetInstance: " + ex.ToString());
			}
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
	}

	public static DerBitString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerBitString)
		{
			return GetInstance(o);
		}
		return CreatePrimitive(((Asn1OctetString)o).GetOctets());
	}

	public DerBitString(byte data, int padBits)
	{
		if (padBits > 7 || padBits < 0)
		{
			throw new ArgumentException("pad bits cannot be greater than 7 or less than 0", "padBits");
		}
		contents = new byte[2]
		{
			(byte)padBits,
			data
		};
	}

	public DerBitString(byte[] data)
		: this(data, 0)
	{
	}

	public DerBitString(byte[] data, int padBits)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (padBits < 0 || padBits > 7)
		{
			throw new ArgumentException("must be in the range 0 to 7", "padBits");
		}
		if (data.Length == 0 && padBits != 0)
		{
			throw new ArgumentException("if 'data' is empty, 'padBits' must be 0");
		}
		contents = Arrays.Prepend(data, (byte)padBits);
	}

	public DerBitString(int namedBits)
	{
		if (namedBits == 0)
		{
			contents = new byte[1];
			return;
		}
		int bytes = (BigInteger.BitLen(namedBits) + 7) / 8;
		byte[] data = new byte[1 + bytes];
		for (int i = 1; i < bytes; i++)
		{
			data[i] = (byte)namedBits;
			namedBits >>= 8;
		}
		data[bytes] = (byte)namedBits;
		int padBits;
		for (padBits = 0; (namedBits & (1 << padBits)) == 0; padBits++)
		{
		}
		data[0] = (byte)padBits;
		contents = data;
	}

	public DerBitString(Asn1Encodable obj)
		: this(obj.GetDerEncoded())
	{
	}

	internal DerBitString(byte[] contents, bool check)
	{
		if (check)
		{
			if (contents == null)
			{
				throw new ArgumentNullException("contents");
			}
			if (contents.Length < 1)
			{
				throw new ArgumentException("cannot be empty", "contents");
			}
			int padBits = contents[0];
			if (padBits > 0)
			{
				if (contents.Length < 2)
				{
					throw new ArgumentException("zero length data with non-zero pad bits", "contents");
				}
				if (padBits > 7)
				{
					throw new ArgumentException("pad bits cannot be greater than 7 or less than 0", "contents");
				}
			}
		}
		this.contents = contents;
	}

	public virtual byte[] GetOctets()
	{
		if (contents[0] != 0)
		{
			throw new InvalidOperationException("attempt to get non-octet aligned data from BIT STRING");
		}
		return Arrays.CopyOfRange(contents, 1, contents.Length);
	}

	public virtual byte[] GetBytes()
	{
		if (contents.Length == 1)
		{
			return Asn1OctetString.EmptyOctets;
		}
		int padBits = contents[0];
		byte[] array = Arrays.CopyOfRange(contents, 1, contents.Length);
		array[array.Length - 1] &= (byte)(255 << padBits);
		return array;
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, contents.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		int padBits = contents[0];
		int last = contents.Length - 1;
		byte num = contents[last];
		byte lastOctetDer = (byte)(contents[last] & (255 << padBits));
		if (num == lastOctetDer)
		{
			asn1Out.WriteEncodingDL(withID, 3, contents);
		}
		else
		{
			asn1Out.WriteEncodingDL(withID, 3, contents, 0, last, lastOctetDer);
		}
	}

	protected override int Asn1GetHashCode()
	{
		if (contents.Length < 2)
		{
			return 1;
		}
		int padBits = contents[0];
		int last = contents.Length - 1;
		byte lastOctetDer = (byte)(contents[last] & (255 << padBits));
		return (Arrays.GetHashCode(contents, 0, last) * 257) ^ lastOctetDer;
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerBitString that))
		{
			return false;
		}
		byte[] thisContents = contents;
		byte[] thatContents = that.contents;
		int length = thisContents.Length;
		if (thatContents.Length != length)
		{
			return false;
		}
		if (length == 1)
		{
			return true;
		}
		int last = length - 1;
		for (int i = 0; i < last; i++)
		{
			if (thisContents[i] != thatContents[i])
			{
				return false;
			}
		}
		int padBits = thisContents[0];
		byte num = (byte)(thisContents[last] & (255 << padBits));
		byte thatLastOctetDer = (byte)(thatContents[last] & (255 << padBits));
		return num == thatLastOctetDer;
	}

	public override string GetString()
	{
		StringBuilder buffer = new StringBuilder("#");
		byte[] str = GetDerEncoded();
		for (int i = 0; i != str.Length; i++)
		{
			uint ubyte = str[i];
			buffer.Append(table[(ubyte >> 4) & 0xF]);
			buffer.Append(table[str[i] & 0xF]);
		}
		return buffer.ToString();
	}

	internal static int EncodedLength(bool withID, int contentsLength)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
	}

	internal static void Encode(Asn1OutputStream asn1Out, bool withID, byte[] buf, int off, int len)
	{
		asn1Out.WriteEncodingDL(withID, 3, buf, off, len);
	}

	internal static void Encode(Asn1OutputStream asn1Out, bool withID, byte pad, byte[] buf, int off, int len)
	{
		asn1Out.WriteEncodingDL(withID, 3, pad, buf, off, len);
	}

	internal static DerBitString CreatePrimitive(byte[] contents)
	{
		int length = contents.Length;
		if (length < 1)
		{
			throw new ArgumentException("truncated BIT STRING detected", "contents");
		}
		int padBits = contents[0];
		if (padBits > 0)
		{
			if (padBits > 7 || length < 2)
			{
				throw new ArgumentException("invalid pad bits detected", "contents");
			}
			byte finalOctet = contents[length - 1];
			if (finalOctet != (byte)(finalOctet & (255 << padBits)))
			{
				return new BerBitString(contents, check: false);
			}
		}
		return new DerBitString(contents, check: false);
	}
}
