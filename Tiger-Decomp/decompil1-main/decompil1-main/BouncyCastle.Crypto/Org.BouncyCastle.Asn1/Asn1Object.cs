using System;
using System.IO;

namespace Org.BouncyCastle.Asn1;

public abstract class Asn1Object : Asn1Encodable
{
	public override void EncodeTo(Stream output)
	{
		Asn1OutputStream.Create(output).WriteObject(this);
	}

	public override void EncodeTo(Stream output, string encoding)
	{
		Asn1OutputStream.Create(output, encoding).WriteObject(this);
	}

	public static Asn1Object FromByteArray(byte[] data)
	{
		try
		{
			MemoryStream input = new MemoryStream(data, writable: false);
			Asn1Object result = new Asn1InputStream(input, data.Length).ReadObject();
			if (input.Position != input.Length)
			{
				throw new IOException("extra data found after object");
			}
			return result;
		}
		catch (InvalidCastException)
		{
			throw new IOException("cannot recognise object in byte array");
		}
	}

	public static Asn1Object FromStream(Stream inStr)
	{
		try
		{
			return new Asn1InputStream(inStr).ReadObject();
		}
		catch (InvalidCastException)
		{
			throw new IOException("cannot recognise object in stream");
		}
	}

	public sealed override Asn1Object ToAsn1Object()
	{
		return this;
	}

	internal abstract int EncodedLength(bool withID);

	internal abstract void Encode(Asn1OutputStream asn1Out, bool withID);

	protected abstract bool Asn1Equals(Asn1Object asn1Object);

	protected abstract int Asn1GetHashCode();

	internal bool CallAsn1Equals(Asn1Object obj)
	{
		return Asn1Equals(obj);
	}

	internal int CallAsn1GetHashCode()
	{
		return Asn1GetHashCode();
	}
}
