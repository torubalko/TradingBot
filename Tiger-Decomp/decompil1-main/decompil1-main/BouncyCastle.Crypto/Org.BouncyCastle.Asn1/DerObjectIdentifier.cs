using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerObjectIdentifier : Asn1Object
{
	private readonly string identifier;

	private byte[] contents;

	private const long LONG_LIMIT = 72057594037927808L;

	private static readonly DerObjectIdentifier[] cache = new DerObjectIdentifier[1024];

	public string Id => identifier;

	public static DerObjectIdentifier FromContents(byte[] contents)
	{
		return CreatePrimitive(contents, clone: true);
	}

	public static DerObjectIdentifier GetInstance(object obj)
	{
		if (obj == null || obj is DerObjectIdentifier)
		{
			return (DerObjectIdentifier)obj;
		}
		if (obj is Asn1Encodable)
		{
			Asn1Object asn1Obj = ((Asn1Encodable)obj).ToAsn1Object();
			if (asn1Obj is DerObjectIdentifier)
			{
				return (DerObjectIdentifier)asn1Obj;
			}
		}
		if (obj is byte[])
		{
			return (DerObjectIdentifier)Asn1Object.FromByteArray((byte[])obj);
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static DerObjectIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		Asn1Object o = obj.GetObject();
		if (explicitly || o is DerObjectIdentifier)
		{
			return GetInstance(o);
		}
		return FromContents(Asn1OctetString.GetInstance(o).GetOctets());
	}

	public DerObjectIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (!IsValidIdentifier(identifier))
		{
			throw new FormatException("string " + identifier + " not an OID");
		}
		this.identifier = identifier;
	}

	internal DerObjectIdentifier(DerObjectIdentifier oid, string branchID)
	{
		if (!IsValidBranchID(branchID, 0))
		{
			throw new ArgumentException("string " + branchID + " not a valid OID branch", "branchID");
		}
		identifier = oid.Id + "." + branchID;
	}

	public virtual DerObjectIdentifier Branch(string branchID)
	{
		return new DerObjectIdentifier(this, branchID);
	}

	public virtual bool On(DerObjectIdentifier stem)
	{
		string id = Id;
		string stemId = stem.Id;
		if (id.Length > stemId.Length && id[stemId.Length] == '.')
		{
			return Platform.StartsWith(id, stemId);
		}
		return false;
	}

	internal DerObjectIdentifier(byte[] contents, bool clone)
	{
		identifier = MakeOidStringFromBytes(contents);
		this.contents = (clone ? Arrays.Clone(contents) : contents);
	}

	private void WriteField(Stream outputStream, long fieldValue)
	{
		byte[] result = new byte[9];
		int pos = 8;
		result[pos] = (byte)(fieldValue & 0x7F);
		while (fieldValue >= 128)
		{
			fieldValue >>= 7;
			result[--pos] = (byte)((fieldValue & 0x7F) | 0x80);
		}
		outputStream.Write(result, pos, 9 - pos);
	}

	private void WriteField(Stream outputStream, BigInteger fieldValue)
	{
		int byteCount = (fieldValue.BitLength + 6) / 7;
		if (byteCount == 0)
		{
			outputStream.WriteByte(0);
			return;
		}
		BigInteger tmpValue = fieldValue;
		byte[] tmp = new byte[byteCount];
		for (int i = byteCount - 1; i >= 0; i--)
		{
			tmp[i] = (byte)((tmpValue.IntValue & 0x7F) | 0x80);
			tmpValue = tmpValue.ShiftRight(7);
		}
		tmp[byteCount - 1] &= 127;
		outputStream.Write(tmp, 0, tmp.Length);
	}

	private void DoOutput(MemoryStream bOut)
	{
		OidTokenizer tok = new OidTokenizer(identifier);
		string token = tok.NextToken();
		int first = int.Parse(token) * 40;
		token = tok.NextToken();
		if (token.Length <= 18)
		{
			WriteField(bOut, first + long.Parse(token));
		}
		else
		{
			WriteField(bOut, new BigInteger(token).Add(BigInteger.ValueOf(first)));
		}
		while (tok.HasMoreTokens)
		{
			token = tok.NextToken();
			if (token.Length <= 18)
			{
				WriteField(bOut, long.Parse(token));
			}
			else
			{
				WriteField(bOut, new BigInteger(token));
			}
		}
	}

	private byte[] GetContents()
	{
		lock (this)
		{
			if (contents == null)
			{
				MemoryStream bOut = new MemoryStream();
				DoOutput(bOut);
				contents = bOut.ToArray();
			}
			return contents;
		}
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, GetContents().Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 6, GetContents());
	}

	protected override int Asn1GetHashCode()
	{
		return identifier.GetHashCode();
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerObjectIdentifier other))
		{
			return false;
		}
		return identifier.Equals(other.identifier);
	}

	public override string ToString()
	{
		return identifier;
	}

	private static bool IsValidBranchID(string branchID, int start)
	{
		int digitCount = 0;
		int pos = branchID.Length;
		while (--pos >= start)
		{
			char ch = branchID[pos];
			if (ch == '.')
			{
				if (digitCount == 0 || (digitCount > 1 && branchID[pos + 1] == '0'))
				{
					return false;
				}
				digitCount = 0;
			}
			else
			{
				if ('0' > ch || ch > '9')
				{
					return false;
				}
				digitCount++;
			}
		}
		if (digitCount == 0 || (digitCount > 1 && branchID[pos + 1] == '0'))
		{
			return false;
		}
		return true;
	}

	private static bool IsValidIdentifier(string identifier)
	{
		if (identifier.Length < 3 || identifier[1] != '.')
		{
			return false;
		}
		char first = identifier[0];
		if (first < '0' || first > '2')
		{
			return false;
		}
		return IsValidBranchID(identifier, 2);
	}

	private static string MakeOidStringFromBytes(byte[] bytes)
	{
		StringBuilder objId = new StringBuilder();
		long value = 0L;
		BigInteger bigValue = null;
		bool first = true;
		for (int i = 0; i != bytes.Length; i++)
		{
			int b = bytes[i];
			if (value <= 72057594037927808L)
			{
				value += b & 0x7F;
				if ((b & 0x80) == 0)
				{
					if (first)
					{
						if (value < 40)
						{
							objId.Append('0');
						}
						else if (value < 80)
						{
							objId.Append('1');
							value -= 40;
						}
						else
						{
							objId.Append('2');
							value -= 80;
						}
						first = false;
					}
					objId.Append('.');
					objId.Append(value);
					value = 0L;
				}
				else
				{
					value <<= 7;
				}
				continue;
			}
			if (bigValue == null)
			{
				bigValue = BigInteger.ValueOf(value);
			}
			bigValue = bigValue.Or(BigInteger.ValueOf(b & 0x7F));
			if ((b & 0x80) == 0)
			{
				if (first)
				{
					objId.Append('2');
					bigValue = bigValue.Subtract(BigInteger.ValueOf(80L));
					first = false;
				}
				objId.Append('.');
				objId.Append(bigValue);
				bigValue = null;
				value = 0L;
			}
			else
			{
				bigValue = bigValue.ShiftLeft(7);
			}
		}
		return objId.ToString();
	}

	internal static DerObjectIdentifier CreatePrimitive(byte[] contents, bool clone)
	{
		int first = Arrays.GetHashCode(contents) & 0x3FF;
		lock (cache)
		{
			DerObjectIdentifier entry = cache[first];
			if (entry != null && Arrays.AreEqual(contents, entry.GetContents()))
			{
				return entry;
			}
			return cache[first] = new DerObjectIdentifier(contents, clone);
		}
	}
}
