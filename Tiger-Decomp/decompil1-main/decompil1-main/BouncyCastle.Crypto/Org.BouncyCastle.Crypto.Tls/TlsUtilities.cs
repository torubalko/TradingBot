using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class TlsUtilities
{
	public static readonly byte[] EmptyBytes = new byte[0];

	public static readonly short[] EmptyShorts = new short[0];

	public static readonly int[] EmptyInts = new int[0];

	public static readonly long[] EmptyLongs = new long[0];

	internal static readonly byte[] SSL_CLIENT = new byte[4] { 67, 76, 78, 84 };

	internal static readonly byte[] SSL_SERVER = new byte[4] { 83, 82, 86, 82 };

	internal static readonly byte[][] SSL3_CONST = GenSsl3Const();

	public static void CheckUint8(int i)
	{
		if (!IsValidUint8(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint8(long i)
	{
		if (!IsValidUint8(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint16(int i)
	{
		if (!IsValidUint16(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint16(long i)
	{
		if (!IsValidUint16(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint24(int i)
	{
		if (!IsValidUint24(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint24(long i)
	{
		if (!IsValidUint24(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint32(long i)
	{
		if (!IsValidUint32(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint48(long i)
	{
		if (!IsValidUint48(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static void CheckUint64(long i)
	{
		if (!IsValidUint64(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public static bool IsValidUint8(int i)
	{
		return (i & 0xFF) == i;
	}

	public static bool IsValidUint8(long i)
	{
		return (i & 0xFF) == i;
	}

	public static bool IsValidUint16(int i)
	{
		return (i & 0xFFFF) == i;
	}

	public static bool IsValidUint16(long i)
	{
		return (i & 0xFFFF) == i;
	}

	public static bool IsValidUint24(int i)
	{
		return (i & 0xFFFFFF) == i;
	}

	public static bool IsValidUint24(long i)
	{
		return (i & 0xFFFFFF) == i;
	}

	public static bool IsValidUint32(long i)
	{
		return (i & 0xFFFFFFFFu) == i;
	}

	public static bool IsValidUint48(long i)
	{
		return (i & 0xFFFFFFFFFFFFL) == i;
	}

	public static bool IsValidUint64(long i)
	{
		return true;
	}

	public static bool IsSsl(TlsContext context)
	{
		return context.ServerVersion.IsSsl;
	}

	public static bool IsTlsV11(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version.GetEquivalentTLSVersion());
	}

	public static bool IsTlsV11(TlsContext context)
	{
		return IsTlsV11(context.ServerVersion);
	}

	public static bool IsTlsV12(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTLSVersion());
	}

	public static bool IsTlsV12(TlsContext context)
	{
		return IsTlsV12(context.ServerVersion);
	}

	public static void WriteUint8(byte i, Stream output)
	{
		output.WriteByte(i);
	}

	public static void WriteUint8(byte i, byte[] buf, int offset)
	{
		buf[offset] = i;
	}

	public static void WriteUint16(int i, Stream output)
	{
		output.WriteByte((byte)(i >> 8));
		output.WriteByte((byte)i);
	}

	public static void WriteUint16(int i, byte[] buf, int offset)
	{
		buf[offset] = (byte)(i >> 8);
		buf[offset + 1] = (byte)i;
	}

	public static void WriteUint24(int i, Stream output)
	{
		output.WriteByte((byte)(i >> 16));
		output.WriteByte((byte)(i >> 8));
		output.WriteByte((byte)i);
	}

	public static void WriteUint24(int i, byte[] buf, int offset)
	{
		buf[offset] = (byte)(i >> 16);
		buf[offset + 1] = (byte)(i >> 8);
		buf[offset + 2] = (byte)i;
	}

	public static void WriteUint32(long i, Stream output)
	{
		output.WriteByte((byte)(i >> 24));
		output.WriteByte((byte)(i >> 16));
		output.WriteByte((byte)(i >> 8));
		output.WriteByte((byte)i);
	}

	public static void WriteUint32(long i, byte[] buf, int offset)
	{
		buf[offset] = (byte)(i >> 24);
		buf[offset + 1] = (byte)(i >> 16);
		buf[offset + 2] = (byte)(i >> 8);
		buf[offset + 3] = (byte)i;
	}

	public static void WriteUint48(long i, Stream output)
	{
		output.WriteByte((byte)(i >> 40));
		output.WriteByte((byte)(i >> 32));
		output.WriteByte((byte)(i >> 24));
		output.WriteByte((byte)(i >> 16));
		output.WriteByte((byte)(i >> 8));
		output.WriteByte((byte)i);
	}

	public static void WriteUint48(long i, byte[] buf, int offset)
	{
		buf[offset] = (byte)(i >> 40);
		buf[offset + 1] = (byte)(i >> 32);
		buf[offset + 2] = (byte)(i >> 24);
		buf[offset + 3] = (byte)(i >> 16);
		buf[offset + 4] = (byte)(i >> 8);
		buf[offset + 5] = (byte)i;
	}

	public static void WriteUint64(long i, Stream output)
	{
		output.WriteByte((byte)(i >> 56));
		output.WriteByte((byte)(i >> 48));
		output.WriteByte((byte)(i >> 40));
		output.WriteByte((byte)(i >> 32));
		output.WriteByte((byte)(i >> 24));
		output.WriteByte((byte)(i >> 16));
		output.WriteByte((byte)(i >> 8));
		output.WriteByte((byte)i);
	}

	public static void WriteUint64(long i, byte[] buf, int offset)
	{
		buf[offset] = (byte)(i >> 56);
		buf[offset + 1] = (byte)(i >> 48);
		buf[offset + 2] = (byte)(i >> 40);
		buf[offset + 3] = (byte)(i >> 32);
		buf[offset + 4] = (byte)(i >> 24);
		buf[offset + 5] = (byte)(i >> 16);
		buf[offset + 6] = (byte)(i >> 8);
		buf[offset + 7] = (byte)i;
	}

	public static void WriteOpaque8(byte[] buf, Stream output)
	{
		WriteUint8((byte)buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteOpaque16(byte[] buf, Stream output)
	{
		WriteUint16(buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteOpaque24(byte[] buf, Stream output)
	{
		WriteUint24(buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteUint8Array(byte[] uints, Stream output)
	{
		output.Write(uints, 0, uints.Length);
	}

	public static void WriteUint8Array(byte[] uints, byte[] buf, int offset)
	{
		for (int i = 0; i < uints.Length; i++)
		{
			WriteUint8(uints[i], buf, offset);
			offset++;
		}
	}

	public static void WriteUint8ArrayWithUint8Length(byte[] uints, Stream output)
	{
		CheckUint8(uints.Length);
		WriteUint8((byte)uints.Length, output);
		WriteUint8Array(uints, output);
	}

	public static void WriteUint8ArrayWithUint8Length(byte[] uints, byte[] buf, int offset)
	{
		CheckUint8(uints.Length);
		WriteUint8((byte)uints.Length, buf, offset);
		WriteUint8Array(uints, buf, offset + 1);
	}

	public static void WriteUint16Array(int[] uints, Stream output)
	{
		for (int i = 0; i < uints.Length; i++)
		{
			WriteUint16(uints[i], output);
		}
	}

	public static void WriteUint16Array(int[] uints, byte[] buf, int offset)
	{
		for (int i = 0; i < uints.Length; i++)
		{
			WriteUint16(uints[i], buf, offset);
			offset += 2;
		}
	}

	public static void WriteUint16ArrayWithUint16Length(int[] uints, Stream output)
	{
		int i = 2 * uints.Length;
		CheckUint16(i);
		WriteUint16(i, output);
		WriteUint16Array(uints, output);
	}

	public static void WriteUint16ArrayWithUint16Length(int[] uints, byte[] buf, int offset)
	{
		int i = 2 * uints.Length;
		CheckUint16(i);
		WriteUint16(i, buf, offset);
		WriteUint16Array(uints, buf, offset + 2);
	}

	public static byte DecodeUint8(byte[] buf)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (buf.Length != 1)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadUint8(buf, 0);
	}

	public static byte[] DecodeUint8ArrayWithUint8Length(byte[] buf)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		int count = ReadUint8(buf, 0);
		if (buf.Length != count + 1)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] uints = new byte[count];
		for (int i = 0; i < count; i++)
		{
			uints[i] = ReadUint8(buf, i + 1);
		}
		return uints;
	}

	public static byte[] EncodeOpaque8(byte[] buf)
	{
		CheckUint8(buf.Length);
		return Arrays.Prepend(buf, (byte)buf.Length);
	}

	public static byte[] EncodeUint8(byte val)
	{
		CheckUint8(val);
		byte[] extensionData = new byte[1];
		WriteUint8(val, extensionData, 0);
		return extensionData;
	}

	public static byte[] EncodeUint8ArrayWithUint8Length(byte[] uints)
	{
		byte[] result = new byte[1 + uints.Length];
		WriteUint8ArrayWithUint8Length(uints, result, 0);
		return result;
	}

	public static byte[] EncodeUint16ArrayWithUint16Length(int[] uints)
	{
		int length = 2 * uints.Length;
		byte[] result = new byte[2 + length];
		WriteUint16ArrayWithUint16Length(uints, result, 0);
		return result;
	}

	public static byte ReadUint8(Stream input)
	{
		int num = input.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		return (byte)num;
	}

	public static byte ReadUint8(byte[] buf, int offset)
	{
		return buf[offset];
	}

	public static int ReadUint16(Stream input)
	{
		int num = input.ReadByte();
		int i2 = input.ReadByte();
		if (i2 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 8) | i2;
	}

	public static int ReadUint16(byte[] buf, int offset)
	{
		return (buf[offset] << 8) | buf[++offset];
	}

	public static int ReadUint24(Stream input)
	{
		int num = input.ReadByte();
		int i2 = input.ReadByte();
		int i3 = input.ReadByte();
		if (i3 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 16) | (i2 << 8) | i3;
	}

	public static int ReadUint24(byte[] buf, int offset)
	{
		return (buf[offset] << 16) | (buf[++offset] << 8) | buf[++offset];
	}

	public static long ReadUint32(Stream input)
	{
		int num = input.ReadByte();
		int i2 = input.ReadByte();
		int i3 = input.ReadByte();
		int i4 = input.ReadByte();
		if (i4 < 0)
		{
			throw new EndOfStreamException();
		}
		return (uint)((num << 24) | (i2 << 16) | (i3 << 8) | i4);
	}

	public static long ReadUint32(byte[] buf, int offset)
	{
		return (uint)((buf[offset] << 24) | (buf[++offset] << 16) | (buf[++offset] << 8) | buf[++offset]);
	}

	public static long ReadUint48(Stream input)
	{
		int num = ReadUint24(input);
		int lo = ReadUint24(input);
		return ((num & 0xFFFFFFFFu) << 24) | (lo & 0xFFFFFFFFu);
	}

	public static long ReadUint48(byte[] buf, int offset)
	{
		int num = ReadUint24(buf, offset);
		int lo = ReadUint24(buf, offset + 3);
		return ((num & 0xFFFFFFFFu) << 24) | (lo & 0xFFFFFFFFu);
	}

	public static byte[] ReadAllOrNothing(int length, Stream input)
	{
		if (length < 1)
		{
			return EmptyBytes;
		}
		byte[] buf = new byte[length];
		int read = Streams.ReadFully(input, buf);
		if (read == 0)
		{
			return null;
		}
		if (read != length)
		{
			throw new EndOfStreamException();
		}
		return buf;
	}

	public static byte[] ReadFully(int length, Stream input)
	{
		if (length < 1)
		{
			return EmptyBytes;
		}
		byte[] buf = new byte[length];
		if (length != Streams.ReadFully(input, buf))
		{
			throw new EndOfStreamException();
		}
		return buf;
	}

	public static void ReadFully(byte[] buf, Stream input)
	{
		if (Streams.ReadFully(input, buf, 0, buf.Length) < buf.Length)
		{
			throw new EndOfStreamException();
		}
	}

	public static byte[] ReadOpaque8(Stream input)
	{
		byte[] array = new byte[ReadUint8(input)];
		ReadFully(array, input);
		return array;
	}

	public static byte[] ReadOpaque16(Stream input)
	{
		byte[] array = new byte[ReadUint16(input)];
		ReadFully(array, input);
		return array;
	}

	public static byte[] ReadOpaque24(Stream input)
	{
		return ReadFully(ReadUint24(input), input);
	}

	public static byte[] ReadUint8Array(int count, Stream input)
	{
		byte[] uints = new byte[count];
		for (int i = 0; i < count; i++)
		{
			uints[i] = ReadUint8(input);
		}
		return uints;
	}

	public static int[] ReadUint16Array(int count, Stream input)
	{
		int[] uints = new int[count];
		for (int i = 0; i < count; i++)
		{
			uints[i] = ReadUint16(input);
		}
		return uints;
	}

	public static ProtocolVersion ReadVersion(byte[] buf, int offset)
	{
		return ProtocolVersion.Get(buf[offset], buf[offset + 1]);
	}

	public static ProtocolVersion ReadVersion(Stream input)
	{
		int major = input.ReadByte();
		int i2 = input.ReadByte();
		if (i2 < 0)
		{
			throw new EndOfStreamException();
		}
		return ProtocolVersion.Get(major, i2);
	}

	public static int ReadVersionRaw(byte[] buf, int offset)
	{
		return (buf[offset] << 8) | buf[offset + 1];
	}

	public static int ReadVersionRaw(Stream input)
	{
		int num = input.ReadByte();
		int i2 = input.ReadByte();
		if (i2 < 0)
		{
			throw new EndOfStreamException();
		}
		return (num << 8) | i2;
	}

	public static Asn1Object ReadAsn1Object(byte[] encoding)
	{
		MemoryStream input = new MemoryStream(encoding, writable: false);
		Asn1Object result = new Asn1InputStream(input, encoding.Length).ReadObject();
		if (result == null)
		{
			throw new TlsFatalAlert(50);
		}
		if (input.Position != input.Length)
		{
			throw new TlsFatalAlert(50);
		}
		return result;
	}

	public static Asn1Object ReadDerObject(byte[] encoding)
	{
		Asn1Object asn1Object = ReadAsn1Object(encoding);
		if (!Arrays.AreEqual(asn1Object.GetEncoded("DER"), encoding))
		{
			throw new TlsFatalAlert(50);
		}
		return asn1Object;
	}

	public static void WriteGmtUnixTime(byte[] buf, int offset)
	{
		int t = (int)(DateTimeUtilities.CurrentUnixMs() / 1000);
		buf[offset] = (byte)(t >> 24);
		buf[offset + 1] = (byte)(t >> 16);
		buf[offset + 2] = (byte)(t >> 8);
		buf[offset + 3] = (byte)t;
	}

	public static void WriteVersion(ProtocolVersion version, Stream output)
	{
		output.WriteByte((byte)version.MajorVersion);
		output.WriteByte((byte)version.MinorVersion);
	}

	public static void WriteVersion(ProtocolVersion version, byte[] buf, int offset)
	{
		buf[offset] = (byte)version.MajorVersion;
		buf[offset + 1] = (byte)version.MinorVersion;
	}

	public static IList GetAllSignatureAlgorithms()
	{
		IList list = Platform.CreateArrayList(4);
		list.Add((byte)0);
		list.Add((byte)1);
		list.Add((byte)2);
		list.Add((byte)3);
		return list;
	}

	public static IList GetDefaultDssSignatureAlgorithms()
	{
		return VectorOfOne(new SignatureAndHashAlgorithm(2, 2));
	}

	public static IList GetDefaultECDsaSignatureAlgorithms()
	{
		return VectorOfOne(new SignatureAndHashAlgorithm(2, 3));
	}

	public static IList GetDefaultRsaSignatureAlgorithms()
	{
		return VectorOfOne(new SignatureAndHashAlgorithm(2, 1));
	}

	public static byte[] GetExtensionData(IDictionary extensions, int extensionType)
	{
		if (extensions != null)
		{
			return (byte[])extensions[extensionType];
		}
		return null;
	}

	public static IList GetDefaultSupportedSignatureAlgorithms()
	{
		byte[] hashAlgorithms = new byte[5] { 2, 3, 4, 5, 6 };
		byte[] signatureAlgorithms = new byte[3] { 1, 2, 3 };
		IList result = Platform.CreateArrayList();
		for (int i = 0; i < signatureAlgorithms.Length; i++)
		{
			for (int j = 0; j < hashAlgorithms.Length; j++)
			{
				result.Add(new SignatureAndHashAlgorithm(hashAlgorithms[j], signatureAlgorithms[i]));
			}
		}
		return result;
	}

	public static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(TlsContext context, TlsSignerCredentials signerCredentials)
	{
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
		if (IsTlsV12(context))
		{
			signatureAndHashAlgorithm = signerCredentials.SignatureAndHashAlgorithm;
			if (signatureAndHashAlgorithm == null)
			{
				throw new TlsFatalAlert(80);
			}
		}
		return signatureAndHashAlgorithm;
	}

	public static bool HasExpectedEmptyExtensionData(IDictionary extensions, int extensionType, byte alertDescription)
	{
		byte[] extension_data = GetExtensionData(extensions, extensionType);
		if (extension_data == null)
		{
			return false;
		}
		if (extension_data.Length != 0)
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return true;
	}

	public static TlsSession ImportSession(byte[] sessionID, SessionParameters sessionParameters)
	{
		return new TlsSessionImpl(sessionID, sessionParameters);
	}

	public static bool IsSignatureAlgorithmsExtensionAllowed(ProtocolVersion clientVersion)
	{
		return ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(clientVersion.GetEquivalentTLSVersion());
	}

	public static void AddSignatureAlgorithmsExtension(IDictionary extensions, IList supportedSignatureAlgorithms)
	{
		extensions[13] = CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
	}

	public static IList GetSignatureAlgorithmsExtension(IDictionary extensions)
	{
		byte[] extensionData = GetExtensionData(extensions, 13);
		if (extensionData != null)
		{
			return ReadSignatureAlgorithmsExtension(extensionData);
		}
		return null;
	}

	public static byte[] CreateSignatureAlgorithmsExtension(IList supportedSignatureAlgorithms)
	{
		MemoryStream buf = new MemoryStream();
		EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms, allowAnonymous: false, buf);
		return buf.ToArray();
	}

	public static IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream buf = new MemoryStream(extensionData, writable: false);
		IList result = ParseSupportedSignatureAlgorithms(allowAnonymous: false, buf);
		TlsProtocol.AssertEmpty(buf);
		return result;
	}

	public static void EncodeSupportedSignatureAlgorithms(IList supportedSignatureAlgorithms, bool allowAnonymous, Stream output)
	{
		if (supportedSignatureAlgorithms == null)
		{
			throw new ArgumentNullException("supportedSignatureAlgorithms");
		}
		if (supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		int i = 2 * supportedSignatureAlgorithms.Count;
		CheckUint16(i);
		WriteUint16(i, output);
		foreach (SignatureAndHashAlgorithm entry in supportedSignatureAlgorithms)
		{
			if (!allowAnonymous && entry.Signature == 0)
			{
				throw new ArgumentException("SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
			}
			entry.Encode(output);
		}
	}

	public static IList ParseSupportedSignatureAlgorithms(bool allowAnonymous, Stream input)
	{
		int length = ReadUint16(input);
		if (length < 2 || (length & 1) != 0)
		{
			throw new TlsFatalAlert(50);
		}
		int count = length / 2;
		IList supportedSignatureAlgorithms = Platform.CreateArrayList(count);
		for (int i = 0; i < count; i++)
		{
			SignatureAndHashAlgorithm entry = SignatureAndHashAlgorithm.Parse(input);
			if (!allowAnonymous && entry.Signature == 0)
			{
				throw new TlsFatalAlert(47);
			}
			supportedSignatureAlgorithms.Add(entry);
		}
		return supportedSignatureAlgorithms;
	}

	public static void VerifySupportedSignatureAlgorithm(IList supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
	{
		if (supportedSignatureAlgorithms == null)
		{
			throw new ArgumentNullException("supportedSignatureAlgorithms");
		}
		if (supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		if (signatureAlgorithm == null)
		{
			throw new ArgumentNullException("signatureAlgorithm");
		}
		if (signatureAlgorithm.Signature != 0)
		{
			foreach (SignatureAndHashAlgorithm entry in supportedSignatureAlgorithms)
			{
				if (entry.Hash == signatureAlgorithm.Hash && entry.Signature == signatureAlgorithm.Signature)
				{
					return;
				}
			}
		}
		throw new TlsFatalAlert(47);
	}

	public static byte[] PRF(TlsContext context, byte[] secret, string asciiLabel, byte[] seed, int size)
	{
		if (context.ServerVersion.IsSsl)
		{
			throw new InvalidOperationException("No PRF available for SSLv3 session");
		}
		byte[] label = Strings.ToByteArray(asciiLabel);
		byte[] labelSeed = Concat(label, seed);
		int prfAlgorithm = context.SecurityParameters.PrfAlgorithm;
		if (prfAlgorithm == 0)
		{
			return PRF_legacy(secret, label, labelSeed, size);
		}
		IDigest digest = CreatePrfHash(prfAlgorithm);
		byte[] buf = new byte[size];
		HMacHash(digest, secret, labelSeed, buf);
		return buf;
	}

	public static byte[] PRF_legacy(byte[] secret, string asciiLabel, byte[] seed, int size)
	{
		byte[] label = Strings.ToByteArray(asciiLabel);
		byte[] labelSeed = Concat(label, seed);
		return PRF_legacy(secret, label, labelSeed, size);
	}

	internal static byte[] PRF_legacy(byte[] secret, byte[] label, byte[] labelSeed, int size)
	{
		int s_half = (secret.Length + 1) / 2;
		byte[] s1 = new byte[s_half];
		byte[] s2 = new byte[s_half];
		Array.Copy(secret, 0, s1, 0, s_half);
		Array.Copy(secret, secret.Length - s_half, s2, 0, s_half);
		byte[] b1 = new byte[size];
		byte[] b2 = new byte[size];
		HMacHash(CreateHash(1), s1, labelSeed, b1);
		HMacHash(CreateHash(2), s2, labelSeed, b2);
		for (int i = 0; i < size; i++)
		{
			b1[i] ^= b2[i];
		}
		return b1;
	}

	internal static byte[] Concat(byte[] a, byte[] b)
	{
		byte[] c = new byte[a.Length + b.Length];
		Array.Copy(a, 0, c, 0, a.Length);
		Array.Copy(b, 0, c, a.Length, b.Length);
		return c;
	}

	internal static void HMacHash(IDigest digest, byte[] secret, byte[] seed, byte[] output)
	{
		HMac mac = new HMac(digest);
		mac.Init(new KeyParameter(secret));
		byte[] a = seed;
		int size = digest.GetDigestSize();
		int iterations = (output.Length + size - 1) / size;
		byte[] buf = new byte[mac.GetMacSize()];
		byte[] buf2 = new byte[mac.GetMacSize()];
		for (int i = 0; i < iterations; i++)
		{
			mac.BlockUpdate(a, 0, a.Length);
			mac.DoFinal(buf, 0);
			a = buf;
			mac.BlockUpdate(a, 0, a.Length);
			mac.BlockUpdate(seed, 0, seed.Length);
			mac.DoFinal(buf2, 0);
			Array.Copy(buf2, 0, output, size * i, System.Math.Min(size, output.Length - size * i));
		}
	}

	internal static void ValidateKeyUsage(X509CertificateStructure c, int keyUsageBits)
	{
		X509Extensions exts = c.TbsCertificate.Extensions;
		if (exts != null)
		{
			X509Extension ext = exts.GetExtension(X509Extensions.KeyUsage);
			if (ext != null && (KeyUsage.GetInstance(ext).GetBytes()[0] & keyUsageBits) != keyUsageBits)
			{
				throw new TlsFatalAlert(46);
			}
		}
	}

	internal static byte[] CalculateKeyBlock(TlsContext context, int size)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] master_secret = securityParameters.MasterSecret;
		byte[] seed = Concat(securityParameters.ServerRandom, securityParameters.ClientRandom);
		if (IsSsl(context))
		{
			return CalculateKeyBlock_Ssl(master_secret, seed, size);
		}
		return PRF(context, master_secret, "key expansion", seed, size);
	}

	internal static byte[] CalculateKeyBlock_Ssl(byte[] master_secret, byte[] random, int size)
	{
		IDigest md5 = CreateHash(1);
		IDigest sha1 = CreateHash(2);
		int md5Size = md5.GetDigestSize();
		byte[] shatmp = new byte[sha1.GetDigestSize()];
		byte[] tmp = new byte[size + md5Size];
		int i = 0;
		int pos = 0;
		while (pos < size)
		{
			byte[] ssl3Const = SSL3_CONST[i];
			sha1.BlockUpdate(ssl3Const, 0, ssl3Const.Length);
			sha1.BlockUpdate(master_secret, 0, master_secret.Length);
			sha1.BlockUpdate(random, 0, random.Length);
			sha1.DoFinal(shatmp, 0);
			md5.BlockUpdate(master_secret, 0, master_secret.Length);
			md5.BlockUpdate(shatmp, 0, shatmp.Length);
			md5.DoFinal(tmp, pos);
			pos += md5Size;
			i++;
		}
		return Arrays.CopyOfRange(tmp, 0, size);
	}

	internal static byte[] CalculateMasterSecret(TlsContext context, byte[] pre_master_secret)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] seed = (securityParameters.IsExtendedMasterSecret ? securityParameters.SessionHash : Concat(securityParameters.ClientRandom, securityParameters.ServerRandom));
		if (IsSsl(context))
		{
			return CalculateMasterSecret_Ssl(pre_master_secret, seed);
		}
		string asciiLabel = (securityParameters.IsExtendedMasterSecret ? ExporterLabel.extended_master_secret : "master secret");
		return PRF(context, pre_master_secret, asciiLabel, seed, 48);
	}

	internal static byte[] CalculateMasterSecret_Ssl(byte[] pre_master_secret, byte[] random)
	{
		IDigest md5 = CreateHash(1);
		IDigest sha1 = CreateHash(2);
		int md5Size = md5.GetDigestSize();
		byte[] shatmp = new byte[sha1.GetDigestSize()];
		byte[] rval = new byte[md5Size * 3];
		int pos = 0;
		for (int i = 0; i < 3; i++)
		{
			byte[] ssl3Const = SSL3_CONST[i];
			sha1.BlockUpdate(ssl3Const, 0, ssl3Const.Length);
			sha1.BlockUpdate(pre_master_secret, 0, pre_master_secret.Length);
			sha1.BlockUpdate(random, 0, random.Length);
			sha1.DoFinal(shatmp, 0);
			md5.BlockUpdate(pre_master_secret, 0, pre_master_secret.Length);
			md5.BlockUpdate(shatmp, 0, shatmp.Length);
			md5.DoFinal(rval, pos);
			pos += md5Size;
		}
		return rval;
	}

	internal static byte[] CalculateVerifyData(TlsContext context, string asciiLabel, byte[] handshakeHash)
	{
		if (IsSsl(context))
		{
			return handshakeHash;
		}
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] master_secret = securityParameters.MasterSecret;
		int verify_data_length = securityParameters.VerifyDataLength;
		return PRF(context, master_secret, asciiLabel, handshakeHash, verify_data_length);
	}

	public static IDigest CreateHash(byte hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			1 => new MD5Digest(), 
			2 => new Sha1Digest(), 
			3 => new Sha224Digest(), 
			4 => new Sha256Digest(), 
			5 => new Sha384Digest(), 
			6 => new Sha512Digest(), 
			_ => throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm"), 
		};
	}

	public static IDigest CreateHash(SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		if (signatureAndHashAlgorithm != null)
		{
			return CreateHash(signatureAndHashAlgorithm.Hash);
		}
		return new CombinedHash();
	}

	public static IDigest CloneHash(byte hashAlgorithm, IDigest hash)
	{
		return hashAlgorithm switch
		{
			1 => new MD5Digest((MD5Digest)hash), 
			2 => new Sha1Digest((Sha1Digest)hash), 
			3 => new Sha224Digest((Sha224Digest)hash), 
			4 => new Sha256Digest((Sha256Digest)hash), 
			5 => new Sha384Digest((Sha384Digest)hash), 
			6 => new Sha512Digest((Sha512Digest)hash), 
			_ => throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm"), 
		};
	}

	public static IDigest CreatePrfHash(int prfAlgorithm)
	{
		if (prfAlgorithm == 0)
		{
			return new CombinedHash();
		}
		return CreateHash(GetHashAlgorithmForPrfAlgorithm(prfAlgorithm));
	}

	public static IDigest ClonePrfHash(int prfAlgorithm, IDigest hash)
	{
		if (prfAlgorithm == 0)
		{
			return new CombinedHash((CombinedHash)hash);
		}
		return CloneHash(GetHashAlgorithmForPrfAlgorithm(prfAlgorithm), hash);
	}

	public static byte GetHashAlgorithmForPrfAlgorithm(int prfAlgorithm)
	{
		return prfAlgorithm switch
		{
			0 => throw new ArgumentException("legacy PRF not a valid algorithm", "prfAlgorithm"), 
			1 => 4, 
			2 => 5, 
			_ => throw new ArgumentException("unknown PrfAlgorithm", "prfAlgorithm"), 
		};
	}

	public static DerObjectIdentifier GetOidForHashAlgorithm(byte hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			1 => PkcsObjectIdentifiers.MD5, 
			2 => X509ObjectIdentifiers.IdSha1, 
			3 => NistObjectIdentifiers.IdSha224, 
			4 => NistObjectIdentifiers.IdSha256, 
			5 => NistObjectIdentifiers.IdSha384, 
			6 => NistObjectIdentifiers.IdSha512, 
			_ => throw new ArgumentException("unknown HashAlgorithm", "hashAlgorithm"), 
		};
	}

	internal static short GetClientCertificateType(Certificate clientCertificate, Certificate serverCertificate)
	{
		if (clientCertificate.IsEmpty)
		{
			return -1;
		}
		X509CertificateStructure x509Cert = clientCertificate.GetCertificateAt(0);
		SubjectPublicKeyInfo keyInfo = x509Cert.SubjectPublicKeyInfo;
		try
		{
			AsymmetricKeyParameter publicKey = PublicKeyFactory.CreateKey(keyInfo);
			if (publicKey.IsPrivate)
			{
				throw new TlsFatalAlert(80);
			}
			if (publicKey is RsaKeyParameters)
			{
				ValidateKeyUsage(x509Cert, 128);
				return 1;
			}
			if (publicKey is DsaPublicKeyParameters)
			{
				ValidateKeyUsage(x509Cert, 128);
				return 2;
			}
			if (publicKey is ECPublicKeyParameters)
			{
				ValidateKeyUsage(x509Cert, 128);
				return 64;
			}
			throw new TlsFatalAlert(43);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(43, alertCause);
		}
	}

	internal static void TrackHashAlgorithms(TlsHandshakeHash handshakeHash, IList supportedSignatureAlgorithms)
	{
		if (supportedSignatureAlgorithms == null)
		{
			return;
		}
		foreach (SignatureAndHashAlgorithm supportedSignatureAlgorithm in supportedSignatureAlgorithms)
		{
			byte hashAlgorithm = supportedSignatureAlgorithm.Hash;
			if (HashAlgorithm.IsRecognized(hashAlgorithm))
			{
				handshakeHash.TrackHashAlgorithm(hashAlgorithm);
			}
		}
	}

	public static bool HasSigningCapability(byte clientCertificateType)
	{
		if ((uint)(clientCertificateType - 1) <= 1u || clientCertificateType == 64)
		{
			return true;
		}
		return false;
	}

	public static TlsSigner CreateTlsSigner(byte clientCertificateType)
	{
		return clientCertificateType switch
		{
			2 => new TlsDssSigner(), 
			64 => new TlsECDsaSigner(), 
			1 => new TlsRsaSigner(), 
			_ => throw new ArgumentException("not a type with signing capability", "clientCertificateType"), 
		};
	}

	private static byte[][] GenSsl3Const()
	{
		int n = 10;
		byte[][] arr = new byte[n][];
		for (int i = 0; i < n; i++)
		{
			byte[] b = new byte[i + 1];
			Arrays.Fill(b, (byte)(65 + i));
			arr[i] = b;
		}
		return arr;
	}

	private static IList VectorOfOne(object obj)
	{
		IList list = Platform.CreateArrayList(1);
		list.Add(obj);
		return list;
	}

	public static int GetCipherType(int ciphersuite)
	{
		switch (GetEncryptionAlgorithm(ciphersuite))
		{
		case 10:
		case 11:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 103:
		case 104:
			return 2;
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 12:
		case 13:
		case 14:
			return 1;
		case 0:
		case 1:
		case 2:
			return 0;
		default:
			throw new TlsFatalAlert(80);
		}
	}

	public static int GetEncryptionAlgorithm(int ciphersuite)
	{
		switch (ciphersuite)
		{
		case 10:
		case 13:
		case 16:
		case 19:
		case 22:
		case 27:
		case 139:
		case 143:
		case 147:
		case 49155:
		case 49160:
		case 49165:
		case 49170:
		case 49175:
		case 49178:
		case 49179:
		case 49180:
		case 49204:
			return 7;
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 60:
		case 62:
		case 63:
		case 64:
		case 103:
		case 108:
		case 140:
		case 144:
		case 148:
		case 174:
		case 178:
		case 182:
		case 49156:
		case 49161:
		case 49166:
		case 49171:
		case 49176:
		case 49181:
		case 49182:
		case 49183:
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49205:
		case 49207:
			return 8;
		case 49308:
		case 49310:
		case 49316:
		case 49318:
		case 49324:
			return 15;
		case 49312:
		case 49314:
		case 49320:
		case 49322:
		case 49326:
			return 16;
		case 156:
		case 158:
		case 160:
		case 162:
		case 164:
		case 166:
		case 168:
		case 170:
		case 172:
		case 49195:
		case 49197:
		case 49199:
		case 49201:
			return 10;
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 61:
		case 104:
		case 105:
		case 106:
		case 107:
		case 109:
		case 141:
		case 145:
		case 149:
		case 175:
		case 179:
		case 183:
		case 49157:
		case 49162:
		case 49167:
		case 49172:
		case 49177:
		case 49184:
		case 49185:
		case 49186:
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49206:
		case 49208:
			return 9;
		case 49309:
		case 49311:
		case 49317:
		case 49319:
		case 49325:
			return 17;
		case 49313:
		case 49315:
		case 49321:
		case 49323:
		case 49327:
			return 18;
		case 157:
		case 159:
		case 161:
		case 163:
		case 165:
		case 167:
		case 169:
		case 171:
		case 173:
		case 49196:
		case 49198:
		case 49200:
		case 49202:
			return 11;
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 191:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
		case 49300:
		case 49302:
		case 49304:
		case 49306:
			return 12;
		case 49274:
		case 49276:
		case 49278:
		case 49280:
		case 49282:
		case 49284:
		case 49286:
		case 49288:
		case 49290:
		case 49292:
		case 49294:
		case 49296:
		case 49298:
			return 19;
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
		case 137:
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
		case 197:
		case 49267:
		case 49269:
		case 49271:
		case 49273:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			return 13;
		case 49275:
		case 49277:
		case 49279:
		case 49281:
		case 49283:
		case 49285:
		case 49287:
		case 49289:
		case 49291:
		case 49293:
		case 49295:
		case 49297:
		case 49299:
			return 20;
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
			return 21;
		case 1:
			return 0;
		case 2:
		case 44:
		case 45:
		case 46:
		case 49153:
		case 49158:
		case 49163:
		case 49168:
		case 49173:
		case 49209:
			return 0;
		case 59:
		case 176:
		case 180:
		case 184:
		case 49210:
			return 0;
		case 177:
		case 181:
		case 185:
		case 49211:
			return 0;
		case 4:
		case 24:
			return 2;
		case 5:
		case 138:
		case 142:
		case 146:
		case 49154:
		case 49159:
		case 49164:
		case 49169:
		case 49174:
		case 49203:
			return 2;
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
		case 155:
			return 14;
		default:
			throw new TlsFatalAlert(80);
		}
	}

	public static int GetKeyExchangeAlgorithm(int ciphersuite)
	{
		switch (ciphersuite)
		{
		case 24:
		case 27:
		case 52:
		case 58:
		case 70:
		case 108:
		case 109:
		case 137:
		case 155:
		case 166:
		case 167:
		case 191:
		case 197:
		case 49284:
		case 49285:
			return 11;
		case 13:
		case 48:
		case 54:
		case 62:
		case 66:
		case 104:
		case 133:
		case 151:
		case 164:
		case 165:
		case 187:
		case 193:
		case 49282:
		case 49283:
			return 7;
		case 16:
		case 49:
		case 55:
		case 63:
		case 67:
		case 105:
		case 134:
		case 152:
		case 160:
		case 161:
		case 188:
		case 194:
		case 49278:
		case 49279:
			return 9;
		case 19:
		case 50:
		case 56:
		case 64:
		case 68:
		case 106:
		case 135:
		case 153:
		case 162:
		case 163:
		case 189:
		case 195:
		case 49280:
		case 49281:
			return 3;
		case 45:
		case 142:
		case 143:
		case 144:
		case 145:
		case 170:
		case 171:
		case 178:
		case 179:
		case 180:
		case 181:
		case 49296:
		case 49297:
		case 49302:
		case 49303:
		case 49318:
		case 49319:
		case 49322:
		case 49323:
		case 52397:
			return 14;
		case 22:
		case 51:
		case 57:
		case 69:
		case 103:
		case 107:
		case 136:
		case 154:
		case 158:
		case 159:
		case 190:
		case 196:
		case 49276:
		case 49277:
		case 49310:
		case 49311:
		case 49314:
		case 49315:
		case 52394:
			return 5;
		case 49173:
		case 49174:
		case 49175:
		case 49176:
		case 49177:
			return 20;
		case 49153:
		case 49154:
		case 49155:
		case 49156:
		case 49157:
		case 49189:
		case 49190:
		case 49197:
		case 49198:
		case 49268:
		case 49269:
		case 49288:
		case 49289:
			return 16;
		case 49163:
		case 49164:
		case 49165:
		case 49166:
		case 49167:
		case 49193:
		case 49194:
		case 49201:
		case 49202:
		case 49272:
		case 49273:
		case 49292:
		case 49293:
			return 18;
		case 49158:
		case 49159:
		case 49160:
		case 49161:
		case 49162:
		case 49187:
		case 49188:
		case 49195:
		case 49196:
		case 49266:
		case 49267:
		case 49286:
		case 49287:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52393:
			return 17;
		case 49203:
		case 49204:
		case 49205:
		case 49206:
		case 49207:
		case 49208:
		case 49209:
		case 49210:
		case 49211:
		case 49306:
		case 49307:
		case 52396:
			return 24;
		case 49168:
		case 49169:
		case 49170:
		case 49171:
		case 49172:
		case 49191:
		case 49192:
		case 49199:
		case 49200:
		case 49270:
		case 49271:
		case 49290:
		case 49291:
		case 52392:
			return 19;
		case 44:
		case 138:
		case 139:
		case 140:
		case 141:
		case 168:
		case 169:
		case 174:
		case 175:
		case 176:
		case 177:
		case 49294:
		case 49295:
		case 49300:
		case 49301:
		case 49316:
		case 49317:
		case 49320:
		case 49321:
		case 52395:
			return 13;
		case 1:
		case 2:
		case 4:
		case 5:
		case 10:
		case 47:
		case 53:
		case 59:
		case 60:
		case 61:
		case 65:
		case 132:
		case 150:
		case 156:
		case 157:
		case 186:
		case 192:
		case 49274:
		case 49275:
		case 49308:
		case 49309:
		case 49312:
		case 49313:
		case 52398:
			return 1;
		case 46:
		case 146:
		case 147:
		case 148:
		case 149:
		case 172:
		case 173:
		case 182:
		case 183:
		case 184:
		case 185:
		case 49298:
		case 49299:
		case 49304:
		case 49305:
			return 15;
		case 49178:
		case 49181:
		case 49184:
			return 21;
		case 49180:
		case 49183:
		case 49186:
			return 22;
		case 49179:
		case 49182:
		case 49185:
			return 23;
		default:
			throw new TlsFatalAlert(80);
		}
	}

	public static int GetMacAlgorithm(int ciphersuite)
	{
		switch (ciphersuite)
		{
		case 156:
		case 157:
		case 158:
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
		case 165:
		case 166:
		case 167:
		case 168:
		case 169:
		case 170:
		case 171:
		case 172:
		case 173:
		case 49195:
		case 49196:
		case 49197:
		case 49198:
		case 49199:
		case 49200:
		case 49201:
		case 49202:
		case 49274:
		case 49275:
		case 49276:
		case 49277:
		case 49278:
		case 49279:
		case 49280:
		case 49281:
		case 49282:
		case 49283:
		case 49284:
		case 49285:
		case 49286:
		case 49287:
		case 49288:
		case 49289:
		case 49290:
		case 49291:
		case 49292:
		case 49293:
		case 49294:
		case 49295:
		case 49296:
		case 49297:
		case 49298:
		case 49299:
		case 49308:
		case 49309:
		case 49310:
		case 49311:
		case 49312:
		case 49313:
		case 49314:
		case 49315:
		case 49316:
		case 49317:
		case 49318:
		case 49319:
		case 49320:
		case 49321:
		case 49322:
		case 49323:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
			return 0;
		case 1:
		case 4:
		case 24:
			return 1;
		case 2:
		case 5:
		case 10:
		case 13:
		case 16:
		case 19:
		case 22:
		case 27:
		case 44:
		case 45:
		case 46:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 132:
		case 133:
		case 134:
		case 135:
		case 136:
		case 137:
		case 138:
		case 139:
		case 140:
		case 141:
		case 142:
		case 143:
		case 144:
		case 145:
		case 146:
		case 147:
		case 148:
		case 149:
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
		case 155:
		case 49153:
		case 49154:
		case 49155:
		case 49156:
		case 49157:
		case 49158:
		case 49159:
		case 49160:
		case 49161:
		case 49162:
		case 49163:
		case 49164:
		case 49165:
		case 49166:
		case 49167:
		case 49168:
		case 49169:
		case 49170:
		case 49171:
		case 49172:
		case 49173:
		case 49174:
		case 49175:
		case 49176:
		case 49177:
		case 49178:
		case 49179:
		case 49180:
		case 49181:
		case 49182:
		case 49183:
		case 49184:
		case 49185:
		case 49186:
		case 49203:
		case 49204:
		case 49205:
		case 49206:
		case 49209:
			return 2;
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 103:
		case 104:
		case 105:
		case 106:
		case 107:
		case 108:
		case 109:
		case 174:
		case 176:
		case 178:
		case 180:
		case 182:
		case 184:
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 191:
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
		case 197:
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49207:
		case 49210:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
		case 49300:
		case 49302:
		case 49304:
		case 49306:
			return 3;
		case 175:
		case 177:
		case 179:
		case 181:
		case 183:
		case 185:
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49208:
		case 49211:
		case 49267:
		case 49269:
		case 49271:
		case 49273:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			return 4;
		default:
			throw new TlsFatalAlert(80);
		}
	}

	public static ProtocolVersion GetMinimumVersion(int ciphersuite)
	{
		if (ciphersuite <= 197)
		{
			if (ciphersuite <= 109)
			{
				if ((uint)(ciphersuite - 59) <= 5u || (uint)(ciphersuite - 103) <= 6u)
				{
					goto IL_006a;
				}
			}
			else if ((uint)(ciphersuite - 156) <= 17u || (uint)(ciphersuite - 186) <= 11u)
			{
				goto IL_006a;
			}
		}
		else if (ciphersuite <= 49299)
		{
			if ((uint)(ciphersuite - 49187) <= 15u || (uint)(ciphersuite - 49266) <= 33u)
			{
				goto IL_006a;
			}
		}
		else if ((uint)(ciphersuite - 49308) <= 19u || (uint)(ciphersuite - 52392) <= 6u)
		{
			goto IL_006a;
		}
		return ProtocolVersion.SSLv3;
		IL_006a:
		return ProtocolVersion.TLSv12;
	}

	public static bool IsAeadCipherSuite(int ciphersuite)
	{
		return 2 == GetCipherType(ciphersuite);
	}

	public static bool IsBlockCipherSuite(int ciphersuite)
	{
		return 1 == GetCipherType(ciphersuite);
	}

	public static bool IsStreamCipherSuite(int ciphersuite)
	{
		return GetCipherType(ciphersuite) == 0;
	}

	public static bool IsValidCipherSuiteForSignatureAlgorithms(int cipherSuite, IList sigAlgs)
	{
		int keyExchangeAlgorithm;
		try
		{
			keyExchangeAlgorithm = GetKeyExchangeAlgorithm(cipherSuite);
		}
		catch (IOException)
		{
			return true;
		}
		switch (keyExchangeAlgorithm)
		{
		case 11:
		case 12:
		case 20:
			return sigAlgs.Contains((byte)0);
		case 5:
		case 6:
		case 19:
		case 23:
			return sigAlgs.Contains((byte)1);
		case 3:
		case 4:
		case 22:
			return sigAlgs.Contains((byte)2);
		case 17:
			return sigAlgs.Contains((byte)3);
		default:
			return true;
		}
	}

	public static bool IsValidCipherSuiteForVersion(int cipherSuite, ProtocolVersion serverVersion)
	{
		return GetMinimumVersion(cipherSuite).IsEqualOrEarlierVersionOf(serverVersion.GetEquivalentTLSVersion());
	}

	public static IList GetUsableSignatureAlgorithms(IList sigHashAlgs)
	{
		if (sigHashAlgs == null)
		{
			return GetAllSignatureAlgorithms();
		}
		IList v = Platform.CreateArrayList(4);
		v.Add((byte)0);
		foreach (SignatureAndHashAlgorithm sigHashAlg in sigHashAlgs)
		{
			byte sigAlg = sigHashAlg.Signature;
			if (!v.Contains(sigAlg))
			{
				v.Add(sigAlg);
			}
		}
		return v;
	}

	public static bool IsTimeout(SocketException e)
	{
		return SocketError.TimedOut == e.SocketErrorCode;
	}
}
