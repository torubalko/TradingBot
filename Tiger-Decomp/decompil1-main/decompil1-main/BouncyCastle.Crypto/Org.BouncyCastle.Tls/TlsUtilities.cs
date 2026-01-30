using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Bsi;
using Org.BouncyCastle.Asn1.Eac;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public abstract class TlsUtilities
{
	private static readonly byte[] DowngradeTlsV11 = Hex.DecodeStrict("444F574E47524400");

	private static readonly byte[] DowngradeTlsV12 = Hex.DecodeStrict("444F574E47524401");

	private static readonly IDictionary CertSigAlgOids = CreateCertSigAlgOids();

	private static readonly IList DefaultSupportedSigAlgs = CreateDefaultSupportedSigAlgs();

	public static readonly byte[] EmptyBytes = new byte[0];

	public static readonly short[] EmptyShorts = new short[0];

	public static readonly int[] EmptyInts = new int[0];

	public static readonly long[] EmptyLongs = new long[0];

	public static readonly string[] EmptyStrings = new string[0];

	internal static short MinimumHashStrict = 2;

	internal static short MinimumHashPreferred = 4;

	private static void AddCertSigAlgOid(IDictionary d, DerObjectIdentifier oid, SignatureAndHashAlgorithm sigAndHash)
	{
		d[oid.Id] = sigAndHash;
	}

	private static void AddCertSigAlgOid(IDictionary d, DerObjectIdentifier oid, short hashAlgorithm, short signatureAlgorithm)
	{
		AddCertSigAlgOid(d, oid, SignatureAndHashAlgorithm.GetInstance(hashAlgorithm, signatureAlgorithm));
	}

	private static IDictionary CreateCertSigAlgOids()
	{
		IDictionary dictionary = Platform.CreateHashtable();
		AddCertSigAlgOid(dictionary, NistObjectIdentifiers.DsaWithSha224, 3, 2);
		AddCertSigAlgOid(dictionary, NistObjectIdentifiers.DsaWithSha256, 4, 2);
		AddCertSigAlgOid(dictionary, NistObjectIdentifiers.DsaWithSha384, 5, 2);
		AddCertSigAlgOid(dictionary, NistObjectIdentifiers.DsaWithSha512, 6, 2);
		AddCertSigAlgOid(dictionary, OiwObjectIdentifiers.DsaWithSha1, 2, 2);
		AddCertSigAlgOid(dictionary, OiwObjectIdentifiers.Sha1WithRsa, 2, 1);
		AddCertSigAlgOid(dictionary, PkcsObjectIdentifiers.Sha1WithRsaEncryption, 2, 1);
		AddCertSigAlgOid(dictionary, PkcsObjectIdentifiers.Sha224WithRsaEncryption, 3, 1);
		AddCertSigAlgOid(dictionary, PkcsObjectIdentifiers.Sha256WithRsaEncryption, 4, 1);
		AddCertSigAlgOid(dictionary, PkcsObjectIdentifiers.Sha384WithRsaEncryption, 5, 1);
		AddCertSigAlgOid(dictionary, PkcsObjectIdentifiers.Sha512WithRsaEncryption, 6, 1);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.ECDsaWithSha1, 2, 3);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.ECDsaWithSha224, 3, 3);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.ECDsaWithSha256, 4, 3);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.ECDsaWithSha384, 5, 3);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.ECDsaWithSha512, 6, 3);
		AddCertSigAlgOid(dictionary, X9ObjectIdentifiers.IdDsaWithSha1, 2, 2);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_ECDSA_SHA_1, 2, 3);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_ECDSA_SHA_224, 3, 3);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_ECDSA_SHA_256, 4, 3);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_ECDSA_SHA_384, 5, 3);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_ECDSA_SHA_512, 6, 3);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_1, 2, 1);
		AddCertSigAlgOid(dictionary, EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_256, 4, 1);
		AddCertSigAlgOid(dictionary, BsiObjectIdentifiers.ecdsa_plain_SHA1, 2, 3);
		AddCertSigAlgOid(dictionary, BsiObjectIdentifiers.ecdsa_plain_SHA224, 3, 3);
		AddCertSigAlgOid(dictionary, BsiObjectIdentifiers.ecdsa_plain_SHA256, 4, 3);
		AddCertSigAlgOid(dictionary, BsiObjectIdentifiers.ecdsa_plain_SHA384, 5, 3);
		AddCertSigAlgOid(dictionary, BsiObjectIdentifiers.ecdsa_plain_SHA512, 6, 3);
		AddCertSigAlgOid(dictionary, EdECObjectIdentifiers.id_Ed25519, SignatureAndHashAlgorithm.ed25519);
		AddCertSigAlgOid(dictionary, EdECObjectIdentifiers.id_Ed448, SignatureAndHashAlgorithm.ed448);
		AddCertSigAlgOid(dictionary, RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256, SignatureAndHashAlgorithm.gostr34102012_256);
		AddCertSigAlgOid(dictionary, RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512, SignatureAndHashAlgorithm.gostr34102012_512);
		return dictionary;
	}

	private static IList CreateDefaultSupportedSigAlgs()
	{
		IList list = Platform.CreateArrayList();
		list.Add(SignatureAndHashAlgorithm.ed25519);
		list.Add(SignatureAndHashAlgorithm.ed448);
		list.Add(SignatureAndHashAlgorithm.GetInstance(4, 3));
		list.Add(SignatureAndHashAlgorithm.GetInstance(5, 3));
		list.Add(SignatureAndHashAlgorithm.GetInstance(6, 3));
		list.Add(SignatureAndHashAlgorithm.rsa_pss_rsae_sha256);
		list.Add(SignatureAndHashAlgorithm.rsa_pss_rsae_sha384);
		list.Add(SignatureAndHashAlgorithm.rsa_pss_rsae_sha512);
		list.Add(SignatureAndHashAlgorithm.rsa_pss_pss_sha256);
		list.Add(SignatureAndHashAlgorithm.rsa_pss_pss_sha384);
		list.Add(SignatureAndHashAlgorithm.rsa_pss_pss_sha512);
		list.Add(SignatureAndHashAlgorithm.GetInstance(4, 1));
		list.Add(SignatureAndHashAlgorithm.GetInstance(5, 1));
		list.Add(SignatureAndHashAlgorithm.GetInstance(6, 1));
		list.Add(SignatureAndHashAlgorithm.GetInstance(4, 2));
		list.Add(SignatureAndHashAlgorithm.GetInstance(5, 2));
		list.Add(SignatureAndHashAlgorithm.GetInstance(6, 2));
		list.Add(SignatureAndHashAlgorithm.GetInstance(3, 3));
		list.Add(SignatureAndHashAlgorithm.GetInstance(3, 1));
		list.Add(SignatureAndHashAlgorithm.GetInstance(3, 2));
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 3));
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 1));
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 2));
		return list;
	}

	public static void CheckUint8(short i)
	{
		if (!IsValidUint8(i))
		{
			throw new TlsFatalAlert(80);
		}
	}

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

	public static bool IsValidUint8(short i)
	{
		return (i & 0xFF) == i;
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

	public static bool IsTlsV10(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
	}

	public static bool IsTlsV10(TlsContext context)
	{
		return IsTlsV10(context.ServerVersion);
	}

	public static bool IsTlsV11(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
	}

	public static bool IsTlsV11(TlsContext context)
	{
		return IsTlsV11(context.ServerVersion);
	}

	public static bool IsTlsV12(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
	}

	public static bool IsTlsV12(TlsContext context)
	{
		return IsTlsV12(context.ServerVersion);
	}

	public static bool IsTlsV13(ProtocolVersion version)
	{
		return ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
	}

	public static bool IsTlsV13(TlsContext context)
	{
		return IsTlsV13(context.ServerVersion);
	}

	public static void WriteUint8(short i, Stream output)
	{
		output.WriteByte((byte)i);
	}

	public static void WriteUint8(int i, Stream output)
	{
		output.WriteByte((byte)i);
	}

	public static void WriteUint8(short i, byte[] buf, int offset)
	{
		buf[offset] = (byte)i;
	}

	public static void WriteUint8(int i, byte[] buf, int offset)
	{
		buf[offset] = (byte)i;
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
		CheckUint8(buf.Length);
		WriteUint8(buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteOpaque8(byte[] data, byte[] buf, int off)
	{
		CheckUint8(data.Length);
		WriteUint8(data.Length, buf, off);
		Array.Copy(data, 0, buf, off + 1, data.Length);
	}

	public static void WriteOpaque16(byte[] buf, Stream output)
	{
		CheckUint16(buf.Length);
		WriteUint16(buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteOpaque16(byte[] data, byte[] buf, int off)
	{
		CheckUint16(data.Length);
		WriteUint16(data.Length, buf, off);
		Array.Copy(data, 0, buf, off + 2, data.Length);
	}

	public static void WriteOpaque24(byte[] buf, Stream output)
	{
		CheckUint24(buf.Length);
		WriteUint24(buf.Length, output);
		output.Write(buf, 0, buf.Length);
	}

	public static void WriteOpaque24(byte[] data, byte[] buf, int off)
	{
		CheckUint24(data.Length);
		WriteUint24(data.Length, buf, off);
		Array.Copy(data, 0, buf, off + 3, data.Length);
	}

	public static void WriteUint8Array(short[] u8s, Stream output)
	{
		for (int i = 0; i < u8s.Length; i++)
		{
			WriteUint8(u8s[i], output);
		}
	}

	public static void WriteUint8Array(short[] u8s, byte[] buf, int offset)
	{
		for (int i = 0; i < u8s.Length; i++)
		{
			WriteUint8(u8s[i], buf, offset);
			offset++;
		}
	}

	public static void WriteUint8ArrayWithUint8Length(short[] u8s, Stream output)
	{
		CheckUint8(u8s.Length);
		WriteUint8(u8s.Length, output);
		WriteUint8Array(u8s, output);
	}

	public static void WriteUint8ArrayWithUint8Length(short[] u8s, byte[] buf, int offset)
	{
		CheckUint8(u8s.Length);
		WriteUint8(u8s.Length, buf, offset);
		WriteUint8Array(u8s, buf, offset + 1);
	}

	public static void WriteUint16Array(int[] u16s, Stream output)
	{
		for (int i = 0; i < u16s.Length; i++)
		{
			WriteUint16(u16s[i], output);
		}
	}

	public static void WriteUint16Array(int[] u16s, byte[] buf, int offset)
	{
		for (int i = 0; i < u16s.Length; i++)
		{
			WriteUint16(u16s[i], buf, offset);
			offset += 2;
		}
	}

	public static void WriteUint16ArrayWithUint16Length(int[] u16s, Stream output)
	{
		int i = 2 * u16s.Length;
		CheckUint16(i);
		WriteUint16(i, output);
		WriteUint16Array(u16s, output);
	}

	public static void WriteUint16ArrayWithUint16Length(int[] u16s, byte[] buf, int offset)
	{
		int i = 2 * u16s.Length;
		CheckUint16(i);
		WriteUint16(i, buf, offset);
		WriteUint16Array(u16s, buf, offset + 2);
	}

	public static byte[] DecodeOpaque8(byte[] buf)
	{
		return DecodeOpaque8(buf, 0);
	}

	public static byte[] DecodeOpaque8(byte[] buf, int minLength)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (buf.Length < 1)
		{
			throw new TlsFatalAlert(50);
		}
		short length = ReadUint8(buf, 0);
		if (buf.Length != length + 1 || length < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return CopyOfRangeExact(buf, 1, buf.Length);
	}

	public static byte[] DecodeOpaque16(byte[] buf)
	{
		return DecodeOpaque16(buf, 0);
	}

	public static byte[] DecodeOpaque16(byte[] buf, int minLength)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (buf.Length < 2)
		{
			throw new TlsFatalAlert(50);
		}
		int length = ReadUint16(buf, 0);
		if (buf.Length != length + 2 || length < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return CopyOfRangeExact(buf, 2, buf.Length);
	}

	public static short DecodeUint8(byte[] buf)
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

	public static short[] DecodeUint8ArrayWithUint8Length(byte[] buf)
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
		short[] uints = new short[count];
		for (int i = 0; i < count; i++)
		{
			uints[i] = ReadUint8(buf, i + 1);
		}
		return uints;
	}

	public static int DecodeUint16(byte[] buf)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (buf.Length != 2)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadUint16(buf, 0);
	}

	public static long DecodeUint32(byte[] buf)
	{
		if (buf == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (buf.Length != 4)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadUint32(buf, 0);
	}

	public static byte[] EncodeOpaque8(byte[] buf)
	{
		CheckUint8(buf.Length);
		return Arrays.Prepend(buf, (byte)buf.Length);
	}

	public static byte[] EncodeOpaque16(byte[] buf)
	{
		CheckUint16(buf.Length);
		byte[] r = new byte[2 + buf.Length];
		WriteUint16(buf.Length, r, 0);
		Array.Copy(buf, 0, r, 2, buf.Length);
		return r;
	}

	public static byte[] EncodeOpaque24(byte[] buf)
	{
		CheckUint24(buf.Length);
		byte[] r = new byte[3 + buf.Length];
		WriteUint24(buf.Length, r, 0);
		Array.Copy(buf, 0, r, 3, buf.Length);
		return r;
	}

	public static byte[] EncodeUint8(short u8)
	{
		CheckUint8(u8);
		byte[] encoding = new byte[1];
		WriteUint8(u8, encoding, 0);
		return encoding;
	}

	public static byte[] EncodeUint8ArrayWithUint8Length(short[] u8s)
	{
		byte[] result = new byte[1 + u8s.Length];
		WriteUint8ArrayWithUint8Length(u8s, result, 0);
		return result;
	}

	public static byte[] EncodeUint16(int u16)
	{
		CheckUint16(u16);
		byte[] encoding = new byte[2];
		WriteUint16(u16, encoding, 0);
		return encoding;
	}

	public static byte[] EncodeUint16ArrayWithUint16Length(int[] u16s)
	{
		int length = 2 * u16s.Length;
		byte[] result = new byte[2 + length];
		WriteUint16ArrayWithUint16Length(u16s, result, 0);
		return result;
	}

	public static byte[] EncodeUint24(int u24)
	{
		CheckUint24(u24);
		byte[] encoding = new byte[3];
		WriteUint24(u24, encoding, 0);
		return encoding;
	}

	public static byte[] EncodeUint32(long u32)
	{
		CheckUint32(u32);
		byte[] encoding = new byte[4];
		WriteUint32(u32, encoding, 0);
		return encoding;
	}

	public static byte[] EncodeVersion(ProtocolVersion version)
	{
		return new byte[2]
		{
			(byte)version.MajorVersion,
			(byte)version.MinorVersion
		};
	}

	public static int ReadInt32(byte[] buf, int offset)
	{
		return (buf[offset] << 24) | ((buf[++offset] & 0xFF) << 16) | ((buf[++offset] & 0xFF) << 8) | (buf[++offset] & 0xFF);
	}

	public static short ReadUint8(Stream input)
	{
		int num = input.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		return (short)num;
	}

	public static short ReadUint8(byte[] buf, int offset)
	{
		return (short)(buf[offset] & 0xFF);
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
		return ((buf[offset] & 0xFF) << 8) | (buf[++offset] & 0xFF);
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
		return ((buf[offset] & 0xFF) << 16) | ((buf[++offset] & 0xFF) << 8) | (buf[++offset] & 0xFF);
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
		return ((num << 24) | (i2 << 16) | (i3 << 8) | i4) & 0xFFFFFFFFu;
	}

	public static long ReadUint32(byte[] buf, int offset)
	{
		return (((buf[offset] & 0xFF) << 24) | ((buf[++offset] & 0xFF) << 16) | ((buf[++offset] & 0xFF) << 8) | (buf[++offset] & 0xFF)) & 0xFFFFFFFFu;
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
		int length = buf.Length;
		if (length > 0 && length != Streams.ReadFully(input, buf))
		{
			throw new EndOfStreamException();
		}
	}

	public static byte[] ReadOpaque8(Stream input)
	{
		return ReadFully(ReadUint8(input), input);
	}

	public static byte[] ReadOpaque8(Stream input, int minLength)
	{
		short num = ReadUint8(input);
		if (num < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadFully(num, input);
	}

	public static byte[] ReadOpaque8(Stream input, int minLength, int maxLength)
	{
		short length = ReadUint8(input);
		if (length < minLength || maxLength < length)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadFully(length, input);
	}

	public static byte[] ReadOpaque16(Stream input)
	{
		return ReadFully(ReadUint16(input), input);
	}

	public static byte[] ReadOpaque16(Stream input, int minLength)
	{
		int num = ReadUint16(input);
		if (num < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadFully(num, input);
	}

	public static byte[] ReadOpaque24(Stream input)
	{
		return ReadFully(ReadUint24(input), input);
	}

	public static byte[] ReadOpaque24(Stream input, int minLength)
	{
		int num = ReadUint24(input);
		if (num < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadFully(num, input);
	}

	public static short[] ReadUint8Array(int count, Stream input)
	{
		short[] uints = new short[count];
		for (int i = 0; i < count; i++)
		{
			uints[i] = ReadUint8(input);
		}
		return uints;
	}

	public static short[] ReadUint8ArrayWithUint8Length(Stream input, int minLength)
	{
		short num = ReadUint8(input);
		if (num < minLength)
		{
			throw new TlsFatalAlert(50);
		}
		return ReadUint8Array(num, input);
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

	public static Asn1Object ReadAsn1Object(byte[] encoding)
	{
		Asn1InputStream asn1 = new Asn1InputStream(encoding);
		Asn1Object result = asn1.ReadObject();
		if (result == null)
		{
			throw new TlsFatalAlert(50);
		}
		if (asn1.ReadObject() != null)
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

	public static void AddIfSupported(IList supportedAlgs, TlsCrypto crypto, SignatureAndHashAlgorithm alg)
	{
		if (crypto.HasSignatureAndHashAlgorithm(alg))
		{
			supportedAlgs.Add(alg);
		}
	}

	public static void AddIfSupported(IList supportedGroups, TlsCrypto crypto, int namedGroup)
	{
		if (crypto.HasNamedGroup(namedGroup))
		{
			supportedGroups.Add(namedGroup);
		}
	}

	public static void AddIfSupported(IList supportedGroups, TlsCrypto crypto, int[] namedGroups)
	{
		for (int i = 0; i < namedGroups.Length; i++)
		{
			AddIfSupported(supportedGroups, crypto, namedGroups[i]);
		}
	}

	public static bool AddToSet(IList s, int i)
	{
		bool num = !s.Contains(i);
		if (num)
		{
			s.Add(i);
		}
		return num;
	}

	public static IList GetDefaultDssSignatureAlgorithms()
	{
		return GetDefaultSignatureAlgorithms(2);
	}

	public static IList GetDefaultECDsaSignatureAlgorithms()
	{
		return GetDefaultSignatureAlgorithms(3);
	}

	public static IList GetDefaultRsaSignatureAlgorithms()
	{
		return GetDefaultSignatureAlgorithms(1);
	}

	public static SignatureAndHashAlgorithm GetDefaultSignatureAlgorithm(short signatureAlgorithm)
	{
		if ((uint)(signatureAlgorithm - 1) <= 2u)
		{
			return SignatureAndHashAlgorithm.GetInstance(2, signatureAlgorithm);
		}
		return null;
	}

	public static IList GetDefaultSignatureAlgorithms(short signatureAlgorithm)
	{
		SignatureAndHashAlgorithm sigAndHashAlg = GetDefaultSignatureAlgorithm(signatureAlgorithm);
		if (sigAndHashAlg != null)
		{
			return VectorOfOne(sigAndHashAlg);
		}
		return Platform.CreateArrayList();
	}

	public static IList GetDefaultSupportedSignatureAlgorithms(TlsContext context)
	{
		TlsCrypto crypto = context.Crypto;
		IList result = Platform.CreateArrayList(DefaultSupportedSigAlgs.Count);
		foreach (SignatureAndHashAlgorithm sigAndHashAlg in DefaultSupportedSigAlgs)
		{
			AddIfSupported(result, crypto, sigAndHashAlg);
		}
		return result;
	}

	public static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(TlsContext context, TlsCredentialedSigner signerCredentials)
	{
		return GetSignatureAndHashAlgorithm(context.ServerVersion, signerCredentials);
	}

	internal static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(ProtocolVersion negotiatedVersion, TlsCredentialedSigner signerCredentials)
	{
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
		if (IsTlsV12(negotiatedVersion))
		{
			signatureAndHashAlgorithm = signerCredentials.SignatureAndHashAlgorithm;
			if (signatureAndHashAlgorithm == null)
			{
				throw new TlsFatalAlert(80);
			}
		}
		return signatureAndHashAlgorithm;
	}

	public static byte[] GetExtensionData(IDictionary extensions, int extensionType)
	{
		if (extensions != null && extensions.Contains(extensionType))
		{
			return (byte[])extensions[extensionType];
		}
		return null;
	}

	public static bool HasExpectedEmptyExtensionData(IDictionary extensions, int extensionType, short alertDescription)
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

	internal static bool IsExtendedMasterSecretOptionalDtls(ProtocolVersion[] activeProtocolVersions)
	{
		if (!ProtocolVersion.Contains(activeProtocolVersions, ProtocolVersion.DTLSv12))
		{
			return ProtocolVersion.Contains(activeProtocolVersions, ProtocolVersion.DTLSv10);
		}
		return true;
	}

	internal static bool IsExtendedMasterSecretOptionalTls(ProtocolVersion[] activeProtocolVersions)
	{
		if (!ProtocolVersion.Contains(activeProtocolVersions, ProtocolVersion.TLSv12) && !ProtocolVersion.Contains(activeProtocolVersions, ProtocolVersion.TLSv11))
		{
			return ProtocolVersion.Contains(activeProtocolVersions, ProtocolVersion.TLSv10);
		}
		return true;
	}

	public static bool IsNullOrContainsNull(object[] array)
	{
		if (array == null)
		{
			return true;
		}
		int count = array.Length;
		for (int i = 0; i < count; i++)
		{
			if (array[i] == null)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsNullOrEmpty(byte[] array)
	{
		if (array != null)
		{
			return array.Length < 1;
		}
		return true;
	}

	public static bool IsNullOrEmpty(short[] array)
	{
		if (array != null)
		{
			return array.Length < 1;
		}
		return true;
	}

	public static bool IsNullOrEmpty(int[] array)
	{
		if (array != null)
		{
			return array.Length < 1;
		}
		return true;
	}

	public static bool IsNullOrEmpty(object[] array)
	{
		if (array != null)
		{
			return array.Length < 1;
		}
		return true;
	}

	public static bool IsNullOrEmpty(string s)
	{
		if (s != null)
		{
			return s.Length < 1;
		}
		return true;
	}

	public static bool IsNullOrEmpty(IList v)
	{
		if (v != null)
		{
			return v.Count < 1;
		}
		return true;
	}

	public static bool IsSignatureAlgorithmsExtensionAllowed(ProtocolVersion version)
	{
		if (version != null)
		{
			return ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}
		return false;
	}

	public static short GetLegacyClientCertType(short signatureAlgorithm)
	{
		return signatureAlgorithm switch
		{
			1 => 1, 
			2 => 2, 
			3 => 64, 
			_ => -1, 
		};
	}

	public static short GetLegacySignatureAlgorithmClient(short clientCertificateType)
	{
		return clientCertificateType switch
		{
			2 => 2, 
			64 => 3, 
			1 => 1, 
			_ => -1, 
		};
	}

	public static short GetLegacySignatureAlgorithmClientCert(short clientCertificateType)
	{
		switch (clientCertificateType)
		{
		case 2:
		case 4:
			return 2;
		case 64:
		case 66:
			return 3;
		case 1:
		case 3:
		case 65:
			return 1;
		default:
			return -1;
		}
	}

	public static short GetLegacySignatureAlgorithmServer(int keyExchangeAlgorithm)
	{
		switch (keyExchangeAlgorithm)
		{
		case 3:
		case 22:
			return 2;
		case 17:
			return 3;
		case 5:
		case 19:
		case 23:
			return 1;
		default:
			return -1;
		}
	}

	public static short GetLegacySignatureAlgorithmServerCert(int keyExchangeAlgorithm)
	{
		switch (keyExchangeAlgorithm)
		{
		case 3:
		case 7:
		case 22:
			return 2;
		case 16:
		case 17:
			return 3;
		case 1:
		case 5:
		case 9:
		case 15:
		case 18:
		case 19:
		case 23:
			return 1;
		default:
			return -1;
		}
	}

	public static IList GetLegacySupportedSignatureAlgorithms()
	{
		IList list = Platform.CreateArrayList(3);
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 2));
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 3));
		list.Add(SignatureAndHashAlgorithm.GetInstance(2, 1));
		return list;
	}

	public static void EncodeSupportedSignatureAlgorithms(IList supportedSignatureAlgorithms, Stream output)
	{
		if (supportedSignatureAlgorithms == null || supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		int i = 2 * supportedSignatureAlgorithms.Count;
		CheckUint16(i);
		WriteUint16(i, output);
		foreach (SignatureAndHashAlgorithm supportedSignatureAlgorithm in supportedSignatureAlgorithms)
		{
			if (supportedSignatureAlgorithm.Signature == 0)
			{
				throw new ArgumentException("SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
			}
			supportedSignatureAlgorithm.Encode(output);
		}
	}

	public static IList ParseSupportedSignatureAlgorithms(Stream input)
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
			SignatureAndHashAlgorithm sigAndHashAlg = SignatureAndHashAlgorithm.Parse(input);
			if (sigAndHashAlg.Signature != 0)
			{
				supportedSignatureAlgorithms.Add(sigAndHashAlg);
			}
		}
		return supportedSignatureAlgorithms;
	}

	public static void VerifySupportedSignatureAlgorithm(IList supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
	{
		if (supportedSignatureAlgorithms == null || supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
		{
			throw new ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
		}
		if (signatureAlgorithm == null)
		{
			throw new ArgumentNullException("signatureAlgorithm");
		}
		if (signatureAlgorithm.Signature == 0 || !ContainsSignatureAlgorithm(supportedSignatureAlgorithms, signatureAlgorithm))
		{
			throw new TlsFatalAlert(47);
		}
	}

	public static bool ContainsSignatureAlgorithm(IList supportedSignatureAlgorithms, SignatureAndHashAlgorithm signatureAlgorithm)
	{
		foreach (SignatureAndHashAlgorithm supportedSignatureAlgorithm in supportedSignatureAlgorithms)
		{
			if (supportedSignatureAlgorithm.Equals(signatureAlgorithm))
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainsAnySignatureAlgorithm(IList supportedSignatureAlgorithms, short signatureAlgorithm)
	{
		foreach (SignatureAndHashAlgorithm supportedSignatureAlgorithm in supportedSignatureAlgorithms)
		{
			if (supportedSignatureAlgorithm.Signature == signatureAlgorithm)
			{
				return true;
			}
		}
		return false;
	}

	public static TlsSecret Prf(SecurityParameters securityParameters, TlsSecret secret, string asciiLabel, byte[] seed, int length)
	{
		return secret.DeriveUsingPrf(securityParameters.PrfAlgorithm, asciiLabel, seed, length);
	}

	public static byte[] Clone(byte[] data)
	{
		if (data != null)
		{
			if (data.Length != 0)
			{
				return (byte[])data.Clone();
			}
			return EmptyBytes;
		}
		return null;
	}

	public static string[] Clone(string[] s)
	{
		if (s != null)
		{
			if (s.Length >= 1)
			{
				return (string[])s.Clone();
			}
			return EmptyStrings;
		}
		return null;
	}

	public static bool ConstantTimeAreEqual(int len, byte[] a, int aOff, byte[] b, int bOff)
	{
		int d = 0;
		for (int i = 0; i < len; i++)
		{
			d |= a[aOff + i] ^ b[bOff + i];
		}
		return d == 0;
	}

	public static byte[] CopyOfRangeExact(byte[] original, int from, int to)
	{
		int newLength = to - from;
		byte[] copy = new byte[newLength];
		Array.Copy(original, from, copy, 0, newLength);
		return copy;
	}

	internal static byte[] Concat(byte[] a, byte[] b)
	{
		byte[] c = new byte[a.Length + b.Length];
		Array.Copy(a, 0, c, 0, a.Length);
		Array.Copy(b, 0, c, a.Length, b.Length);
		return c;
	}

	internal static byte[] CalculateEndPointHash(TlsContext context, TlsCertificate certificate, byte[] enc)
	{
		return CalculateEndPointHash(context, certificate, enc, 0, enc.Length);
	}

	internal static byte[] CalculateEndPointHash(TlsContext context, TlsCertificate certificate, byte[] enc, int encOff, int encLen)
	{
		short hashAlgorithm = 0;
		string sigAlgOid = certificate.SigAlgOid;
		if (sigAlgOid != null)
		{
			if (PkcsObjectIdentifiers.IdRsassaPss.Id.Equals(sigAlgOid))
			{
				RsassaPssParameters pssParams = RsassaPssParameters.GetInstance(certificate.GetSigAlgParams());
				if (pssParams != null)
				{
					DerObjectIdentifier hashOid = pssParams.HashAlgorithm.Algorithm;
					if (NistObjectIdentifiers.IdSha256.Equals(hashOid))
					{
						hashAlgorithm = 4;
					}
					else if (NistObjectIdentifiers.IdSha384.Equals(hashOid))
					{
						hashAlgorithm = 5;
					}
					else if (NistObjectIdentifiers.IdSha512.Equals(hashOid))
					{
						hashAlgorithm = 6;
					}
				}
			}
			else if (CertSigAlgOids.Contains(sigAlgOid))
			{
				hashAlgorithm = ((SignatureAndHashAlgorithm)CertSigAlgOids[sigAlgOid]).Hash;
			}
		}
		switch (hashAlgorithm)
		{
		case 8:
			hashAlgorithm = 0;
			break;
		case 1:
		case 2:
			hashAlgorithm = 4;
			break;
		}
		if (hashAlgorithm != 0)
		{
			TlsHash hash = CreateHash(context.Crypto, hashAlgorithm);
			if (hash != null)
			{
				hash.Update(enc, encOff, encLen);
				return hash.CalculateHash();
			}
		}
		return EmptyBytes;
	}

	public static byte[] CalculateExporterSeed(SecurityParameters securityParameters, byte[] context)
	{
		byte[] cr = securityParameters.ClientRandom;
		byte[] sr = securityParameters.ServerRandom;
		if (context == null)
		{
			return Arrays.Concatenate(cr, sr);
		}
		if (!IsValidUint16(context.Length))
		{
			throw new ArgumentException("must have length less than 2^16 (or be null)", "context");
		}
		byte[] contextLength = new byte[2];
		WriteUint16(context.Length, contextLength, 0);
		return Arrays.ConcatenateAll(cr, sr, contextLength, context);
	}

	private static byte[] CalculateFinishedHmac(SecurityParameters securityParameters, TlsSecret baseKey, byte[] transcriptHash)
	{
		int prfCryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
		int prfHashLength = securityParameters.PrfHashLength;
		return CalculateFinishedHmac(prfCryptoHashAlgorithm, prfHashLength, baseKey, transcriptHash);
	}

	private static byte[] CalculateFinishedHmac(int prfCryptoHashAlgorithm, int prfHashLength, TlsSecret baseKey, byte[] transcriptHash)
	{
		TlsSecret finishedKey = TlsCryptoUtilities.HkdfExpandLabel(baseKey, prfCryptoHashAlgorithm, "finished", EmptyBytes, prfHashLength);
		try
		{
			return finishedKey.CalculateHmac(prfCryptoHashAlgorithm, transcriptHash, 0, transcriptHash.Length);
		}
		finally
		{
			finishedKey.Destroy();
		}
	}

	internal static TlsSecret CalculateMasterSecret(TlsContext context, TlsSecret preMasterSecret)
	{
		SecurityParameters sp = context.SecurityParameters;
		string asciiLabel;
		byte[] seed;
		if (sp.IsExtendedMasterSecret)
		{
			asciiLabel = "extended master secret";
			seed = sp.SessionHash;
		}
		else
		{
			asciiLabel = "master secret";
			seed = Concat(sp.ClientRandom, sp.ServerRandom);
		}
		return Prf(sp, preMasterSecret, asciiLabel, seed, 48);
	}

	internal static byte[] CalculatePskBinder(TlsCrypto crypto, bool isExternalPsk, int pskCryptoHashAlgorithm, TlsSecret earlySecret, byte[] transcriptHash)
	{
		int prfHashLength = TlsCryptoUtilities.GetHashOutputSize(pskCryptoHashAlgorithm);
		string label = (isExternalPsk ? "ext binder" : "res binder");
		byte[] emptyTranscriptHash = crypto.CreateHash(pskCryptoHashAlgorithm).CalculateHash();
		TlsSecret binderKey = DeriveSecret(pskCryptoHashAlgorithm, prfHashLength, earlySecret, label, emptyTranscriptHash);
		try
		{
			return CalculateFinishedHmac(pskCryptoHashAlgorithm, prfHashLength, binderKey, transcriptHash);
		}
		finally
		{
			binderKey.Destroy();
		}
	}

	internal static byte[] CalculateVerifyData(TlsContext context, TlsHandshakeHash handshakeHash, bool isServer)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (IsTlsV13(negotiatedVersion))
		{
			TlsSecret baseKey = (isServer ? securityParameters.BaseKeyServer : securityParameters.BaseKeyClient);
			byte[] transcriptHash = GetCurrentPrfHash(handshakeHash);
			return CalculateFinishedHmac(securityParameters, baseKey, transcriptHash);
		}
		if (negotiatedVersion.IsSsl)
		{
			return Ssl3Utilities.CalculateVerifyData(handshakeHash, isServer);
		}
		string asciiLabel = (isServer ? "server finished" : "client finished");
		byte[] prfHash = GetCurrentPrfHash(handshakeHash);
		TlsSecret master_secret = securityParameters.MasterSecret;
		int verify_data_length = securityParameters.VerifyDataLength;
		return Prf(securityParameters, master_secret, asciiLabel, prfHash, verify_data_length).Extract();
	}

	internal static void Establish13PhaseSecrets(TlsContext context, TlsSecret pskEarlySecret, TlsSecret sharedSecret)
	{
		TlsCrypto crypto = context.Crypto;
		SecurityParameters securityParameters = context.SecurityParameters;
		int cryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
		TlsSecret zeros = crypto.HkdfInit(cryptoHashAlgorithm);
		byte[] emptyTranscriptHash = crypto.CreateHash(cryptoHashAlgorithm).CalculateHash();
		TlsSecret earlySecret = pskEarlySecret;
		if (earlySecret == null)
		{
			earlySecret = crypto.HkdfInit(cryptoHashAlgorithm).HkdfExtract(cryptoHashAlgorithm, zeros);
		}
		if (sharedSecret == null)
		{
			sharedSecret = zeros;
		}
		TlsSecret handshakeSecret = DeriveSecret(securityParameters, earlySecret, "derived", emptyTranscriptHash).HkdfExtract(cryptoHashAlgorithm, sharedSecret);
		if (sharedSecret != zeros)
		{
			sharedSecret.Destroy();
		}
		TlsSecret masterSecret = DeriveSecret(securityParameters, handshakeSecret, "derived", emptyTranscriptHash).HkdfExtract(cryptoHashAlgorithm, zeros);
		securityParameters.m_earlySecret = earlySecret;
		securityParameters.m_handshakeSecret = handshakeSecret;
		securityParameters.m_masterSecret = masterSecret;
	}

	private static void Establish13TrafficSecrets(TlsContext context, byte[] transcriptHash, TlsSecret phaseSecret, string clientLabel, string serverLabel, RecordStream recordStream)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		securityParameters.m_trafficSecretClient = DeriveSecret(securityParameters, phaseSecret, clientLabel, transcriptHash);
		if (serverLabel != null)
		{
			securityParameters.m_trafficSecretServer = DeriveSecret(securityParameters, phaseSecret, serverLabel, transcriptHash);
		}
		recordStream.SetPendingCipher(InitCipher(context));
	}

	internal static void Establish13PhaseApplication(TlsContext context, byte[] serverFinishedTranscriptHash, RecordStream recordStream)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		TlsSecret phaseSecret = securityParameters.MasterSecret;
		Establish13TrafficSecrets(context, serverFinishedTranscriptHash, phaseSecret, "c ap traffic", "s ap traffic", recordStream);
		securityParameters.m_exporterMasterSecret = DeriveSecret(securityParameters, phaseSecret, "exp master", serverFinishedTranscriptHash);
	}

	internal static void Establish13PhaseEarly(TlsContext context, byte[] clientHelloTranscriptHash, RecordStream recordStream)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		TlsSecret phaseSecret = securityParameters.EarlySecret;
		if (recordStream != null)
		{
			Establish13TrafficSecrets(context, clientHelloTranscriptHash, phaseSecret, "c e traffic", null, recordStream);
		}
		securityParameters.m_earlyExporterMasterSecret = DeriveSecret(securityParameters, phaseSecret, "e exp master", clientHelloTranscriptHash);
	}

	internal static void Establish13PhaseHandshake(TlsContext context, byte[] serverHelloTranscriptHash, RecordStream recordStream)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		TlsSecret phaseSecret = securityParameters.HandshakeSecret;
		Establish13TrafficSecrets(context, serverHelloTranscriptHash, phaseSecret, "c hs traffic", "s hs traffic", recordStream);
		securityParameters.m_baseKeyClient = securityParameters.TrafficSecretClient;
		securityParameters.m_baseKeyServer = securityParameters.TrafficSecretServer;
	}

	internal static void Update13TrafficSecretLocal(TlsContext context)
	{
		Update13TrafficSecret(context, context.IsServer);
	}

	internal static void Update13TrafficSecretPeer(TlsContext context)
	{
		Update13TrafficSecret(context, !context.IsServer);
	}

	private static void Update13TrafficSecret(TlsContext context, bool forServer)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		TlsSecret current;
		if (forServer)
		{
			current = securityParameters.TrafficSecretServer;
			securityParameters.m_trafficSecretServer = Update13TrafficSecret(securityParameters, current);
		}
		else
		{
			current = securityParameters.TrafficSecretClient;
			securityParameters.m_trafficSecretClient = Update13TrafficSecret(securityParameters, current);
		}
		current?.Destroy();
	}

	private static TlsSecret Update13TrafficSecret(SecurityParameters securityParameters, TlsSecret secret)
	{
		return TlsCryptoUtilities.HkdfExpandLabel(secret, securityParameters.PrfCryptoHashAlgorithm, "traffic upd", EmptyBytes, securityParameters.PrfHashLength);
	}

	public static DerObjectIdentifier GetOidForHashAlgorithm(short hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			1 => PkcsObjectIdentifiers.MD5, 
			2 => X509ObjectIdentifiers.IdSha1, 
			3 => NistObjectIdentifiers.IdSha224, 
			4 => NistObjectIdentifiers.IdSha256, 
			5 => NistObjectIdentifiers.IdSha384, 
			6 => NistObjectIdentifiers.IdSha512, 
			_ => throw new ArgumentException("invalid HashAlgorithm: " + HashAlgorithm.GetText(hashAlgorithm)), 
		};
	}

	internal static int GetPrfAlgorithm(SecurityParameters securityParameters, int cipherSuite)
	{
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		bool isTlsV13 = IsTlsV13(negotiatedVersion);
		bool isTlsV12Exactly = !isTlsV13 && IsTlsV12(negotiatedVersion);
		bool isSsl = negotiatedVersion.IsSsl;
		if (cipherSuite <= 199)
		{
			switch (cipherSuite)
			{
			case 198:
			case 199:
				break;
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
			case 156:
			case 158:
			case 160:
			case 162:
			case 164:
			case 166:
			case 168:
			case 170:
			case 172:
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
				goto IL_03c5;
			case 157:
			case 159:
			case 161:
			case 163:
			case 165:
			case 167:
			case 169:
			case 171:
			case 173:
				goto IL_03d2;
			case 175:
			case 177:
			case 179:
			case 181:
			case 183:
			case 185:
				goto IL_03df;
			default:
				goto IL_03f6;
			}
			if (isTlsV13)
			{
				return 7;
			}
			throw new TlsFatalAlert(47);
		}
		switch (cipherSuite)
		{
		case 4865:
		case 4867:
		case 4868:
		case 4869:
			break;
		case 4866:
			goto IL_03ab;
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49195:
		case 49197:
		case 49199:
		case 49201:
		case 49212:
		case 49214:
		case 49216:
		case 49218:
		case 49220:
		case 49222:
		case 49224:
		case 49226:
		case 49228:
		case 49230:
		case 49232:
		case 49234:
		case 49236:
		case 49238:
		case 49240:
		case 49242:
		case 49244:
		case 49246:
		case 49248:
		case 49250:
		case 49252:
		case 49254:
		case 49256:
		case 49258:
		case 49260:
		case 49262:
		case 49264:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
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
		case 53249:
		case 53251:
		case 53253:
			goto IL_03c5;
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49196:
		case 49198:
		case 49200:
		case 49202:
		case 49213:
		case 49215:
		case 49217:
		case 49219:
		case 49221:
		case 49223:
		case 49225:
		case 49227:
		case 49229:
		case 49231:
		case 49233:
		case 49235:
		case 49237:
		case 49239:
		case 49241:
		case 49243:
		case 49245:
		case 49247:
		case 49249:
		case 49251:
		case 49253:
		case 49255:
		case 49257:
		case 49259:
		case 49261:
		case 49263:
		case 49265:
		case 49267:
		case 49269:
		case 49271:
		case 49273:
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
		case 53250:
			goto IL_03d2;
		case 49208:
		case 49211:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			goto IL_03df;
		default:
			goto IL_03f6;
		}
		if (isTlsV13)
		{
			return 4;
		}
		throw new TlsFatalAlert(47);
		IL_03d2:
		if (isTlsV12Exactly)
		{
			return 3;
		}
		throw new TlsFatalAlert(47);
		IL_03f6:
		if (isTlsV13)
		{
			throw new TlsFatalAlert(47);
		}
		if (isTlsV12Exactly)
		{
			return 2;
		}
		if (isSsl)
		{
			return 0;
		}
		return 1;
		IL_03c5:
		if (isTlsV12Exactly)
		{
			return 2;
		}
		throw new TlsFatalAlert(47);
		IL_03df:
		if (isTlsV13)
		{
			throw new TlsFatalAlert(47);
		}
		if (isTlsV12Exactly)
		{
			return 3;
		}
		if (isSsl)
		{
			return 0;
		}
		return 1;
		IL_03ab:
		if (isTlsV13)
		{
			return 5;
		}
		throw new TlsFatalAlert(47);
	}

	internal static int GetPrfAlgorithm13(int cipherSuite)
	{
		switch (cipherSuite)
		{
		case 4865:
		case 4867:
		case 4868:
		case 4869:
			return 4;
		case 4866:
			return 5;
		case 198:
		case 199:
			return 7;
		default:
			return -1;
		}
	}

	internal static int[] GetPrfAlgorithms13(int[] cipherSuites)
	{
		int[] result = new int[System.Math.Min(3, cipherSuites.Length)];
		int count = 0;
		for (int i = 0; i < cipherSuites.Length; i++)
		{
			int prfAlgorithm = GetPrfAlgorithm13(cipherSuites[i]);
			if (prfAlgorithm >= 0 && !Arrays.Contains(result, prfAlgorithm))
			{
				result[count++] = prfAlgorithm;
			}
		}
		return Truncate(result, count);
	}

	internal static byte[] CalculateSignatureHash(TlsContext context, SignatureAndHashAlgorithm algorithm, byte[] extraSignatureInput, DigestInputBuffer buf)
	{
		TlsCrypto crypto = context.Crypto;
		TlsHash tlsHash;
		if (algorithm != null)
		{
			tlsHash = CreateHash(crypto, algorithm.Hash);
		}
		else
		{
			TlsHash tlsHash2 = new CombinedHash(crypto);
			tlsHash = tlsHash2;
		}
		TlsHash h = tlsHash;
		SecurityParameters sp = context.SecurityParameters;
		byte[] randoms = Arrays.Concatenate(sp.ClientRandom, sp.ServerRandom);
		h.Update(randoms, 0, randoms.Length);
		if (extraSignatureInput != null)
		{
			h.Update(extraSignatureInput, 0, extraSignatureInput.Length);
		}
		buf.UpdateDigest(h);
		return h.CalculateHash();
	}

	internal static void SendSignatureInput(TlsContext context, byte[] extraSignatureInput, DigestInputBuffer buf, Stream output)
	{
		SecurityParameters sp = context.SecurityParameters;
		byte[] randoms = Arrays.Concatenate(sp.ClientRandom, sp.ServerRandom);
		output.Write(randoms, 0, randoms.Length);
		if (extraSignatureInput != null)
		{
			output.Write(extraSignatureInput, 0, extraSignatureInput.Length);
		}
		buf.CopyTo(output);
		Platform.Dispose(output);
	}

	internal static DigitallySigned GenerateCertificateVerifyClient(TlsClientContext clientContext, TlsCredentialedSigner credentialedSigner, TlsStreamSigner streamSigner, TlsHandshakeHash handshakeHash)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (IsTlsV13(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = GetSignatureAndHashAlgorithm(negotiatedVersion, credentialedSigner);
		byte[] signature;
		if (streamSigner != null)
		{
			handshakeHash.CopyBufferTo(streamSigner.GetOutputStream());
			signature = streamSigner.GetSignature();
		}
		else
		{
			byte[] hash;
			if (signatureAndHashAlgorithm == null)
			{
				hash = securityParameters.SessionHash;
			}
			else
			{
				int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(SignatureScheme.From(signatureAndHashAlgorithm));
				hash = handshakeHash.GetFinalHash(cryptoHashAlgorithm);
			}
			signature = credentialedSigner.GenerateRawSignature(hash);
		}
		return new DigitallySigned(signatureAndHashAlgorithm, signature);
	}

	internal static DigitallySigned Generate13CertificateVerify(TlsContext context, TlsCredentialedSigner credentialedSigner, TlsHandshakeHash handshakeHash)
	{
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = credentialedSigner.SignatureAndHashAlgorithm;
		if (signatureAndHashAlgorithm == null)
		{
			throw new TlsFatalAlert(80);
		}
		string contextString = (context.IsServer ? "TLS 1.3, server CertificateVerify" : "TLS 1.3, client CertificateVerify");
		byte[] signature = Generate13CertificateVerify(context.Crypto, credentialedSigner, contextString, handshakeHash, signatureAndHashAlgorithm);
		return new DigitallySigned(signatureAndHashAlgorithm, signature);
	}

	private static byte[] Generate13CertificateVerify(TlsCrypto crypto, TlsCredentialedSigner credentialedSigner, string contextString, TlsHandshakeHash handshakeHash, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		TlsStreamSigner streamSigner = credentialedSigner.GetStreamSigner();
		byte[] header = GetCertificateVerifyHeader(contextString);
		byte[] prfHash = GetCurrentPrfHash(handshakeHash);
		if (streamSigner != null)
		{
			Stream outputStream = streamSigner.GetOutputStream();
			outputStream.Write(header, 0, header.Length);
			outputStream.Write(prfHash, 0, prfHash.Length);
			return streamSigner.GetSignature();
		}
		int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(SignatureScheme.From(signatureAndHashAlgorithm));
		TlsHash tlsHash = crypto.CreateHash(cryptoHashAlgorithm);
		tlsHash.Update(header, 0, header.Length);
		tlsHash.Update(prfHash, 0, prfHash.Length);
		byte[] hash = tlsHash.CalculateHash();
		return credentialedSigner.GenerateRawSignature(hash);
	}

	internal static void VerifyCertificateVerifyClient(TlsServerContext serverContext, CertificateRequest certificateRequest, DigitallySigned certificateVerify, TlsHandshakeHash handshakeHash)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
		SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
		short signatureAlgorithm;
		if (sigAndHashAlg == null)
		{
			signatureAlgorithm = verifyingCert.GetLegacySignatureAlgorithm();
			short clientCertType = GetLegacyClientCertType(signatureAlgorithm);
			if (clientCertType < 0 || !Arrays.Contains(certificateRequest.CertificateTypes, clientCertType))
			{
				throw new TlsFatalAlert(43);
			}
		}
		else
		{
			signatureAlgorithm = sigAndHashAlg.Signature;
			if (!IsValidSignatureAlgorithmForCertificateVerify(signatureAlgorithm, certificateRequest.CertificateTypes))
			{
				throw new TlsFatalAlert(47);
			}
			VerifySupportedSignatureAlgorithm(securityParameters.ServerSigAlgs, sigAndHashAlg);
		}
		bool verified;
		try
		{
			TlsVerifier verifier = verifyingCert.CreateVerifier(signatureAlgorithm);
			TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(certificateVerify);
			if (streamVerifier != null)
			{
				handshakeHash.CopyBufferTo(streamVerifier.GetOutputStream());
				verified = streamVerifier.IsVerified();
			}
			else
			{
				byte[] hash;
				if (IsTlsV12(serverContext))
				{
					int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(SignatureScheme.From(sigAndHashAlg));
					hash = handshakeHash.GetFinalHash(cryptoHashAlgorithm);
				}
				else
				{
					hash = securityParameters.SessionHash;
				}
				verified = verifier.VerifyRawSignature(certificateVerify, hash);
			}
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			throw tlsFatalAlert;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(51, alertCause);
		}
		if (!verified)
		{
			throw new TlsFatalAlert(51);
		}
	}

	internal static void Verify13CertificateVerifyClient(TlsServerContext serverContext, CertificateRequest certificateRequest, DigitallySigned certificateVerify, TlsHandshakeHash handshakeHash)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
		SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
		VerifySupportedSignatureAlgorithm(securityParameters.ServerSigAlgs, sigAndHashAlg);
		int signatureScheme = SignatureScheme.From(sigAndHashAlg);
		bool verified;
		try
		{
			TlsVerifier verifier = verifyingCert.CreateVerifier(signatureScheme);
			verified = Verify13CertificateVerify(serverContext.Crypto, certificateVerify, verifier, "TLS 1.3, client CertificateVerify", handshakeHash);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			throw tlsFatalAlert;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(51, alertCause);
		}
		if (!verified)
		{
			throw new TlsFatalAlert(51);
		}
	}

	internal static void Verify13CertificateVerifyServer(TlsClientContext clientContext, DigitallySigned certificateVerify, TlsHandshakeHash handshakeHash)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
		SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
		VerifySupportedSignatureAlgorithm(securityParameters.ClientSigAlgs, sigAndHashAlg);
		int signatureScheme = SignatureScheme.From(sigAndHashAlg);
		bool verified;
		try
		{
			TlsVerifier verifier = verifyingCert.CreateVerifier(signatureScheme);
			verified = Verify13CertificateVerify(clientContext.Crypto, certificateVerify, verifier, "TLS 1.3, server CertificateVerify", handshakeHash);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			throw tlsFatalAlert;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(51, alertCause);
		}
		if (!verified)
		{
			throw new TlsFatalAlert(51);
		}
	}

	private static bool Verify13CertificateVerify(TlsCrypto crypto, DigitallySigned certificateVerify, TlsVerifier verifier, string contextString, TlsHandshakeHash handshakeHash)
	{
		TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(certificateVerify);
		byte[] header = GetCertificateVerifyHeader(contextString);
		byte[] prfHash = GetCurrentPrfHash(handshakeHash);
		if (streamVerifier != null)
		{
			Stream outputStream = streamVerifier.GetOutputStream();
			outputStream.Write(header, 0, header.Length);
			outputStream.Write(prfHash, 0, prfHash.Length);
			return streamVerifier.IsVerified();
		}
		int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(SignatureScheme.From(certificateVerify.Algorithm));
		TlsHash tlsHash = crypto.CreateHash(cryptoHashAlgorithm);
		tlsHash.Update(header, 0, header.Length);
		tlsHash.Update(prfHash, 0, prfHash.Length);
		byte[] hash = tlsHash.CalculateHash();
		return verifier.VerifyRawSignature(certificateVerify, hash);
	}

	private static byte[] GetCertificateVerifyHeader(string contextString)
	{
		int count = contextString.Length;
		byte[] header = new byte[64 + count + 1];
		for (int i = 0; i < 64; i++)
		{
			header[i] = 32;
		}
		for (int j = 0; j < count; j++)
		{
			char c = contextString[j];
			header[64 + j] = (byte)c;
		}
		header[64 + count] = 0;
		return header;
	}

	internal static void GenerateServerKeyExchangeSignature(TlsContext context, TlsCredentialedSigner credentials, byte[] extraSignatureInput, DigestInputBuffer digestBuffer)
	{
		SignatureAndHashAlgorithm algorithm = GetSignatureAndHashAlgorithm(context, credentials);
		TlsStreamSigner streamSigner = credentials.GetStreamSigner();
		byte[] signature;
		if (streamSigner != null)
		{
			SendSignatureInput(context, extraSignatureInput, digestBuffer, streamSigner.GetOutputStream());
			signature = streamSigner.GetSignature();
		}
		else
		{
			byte[] hash = CalculateSignatureHash(context, algorithm, extraSignatureInput, digestBuffer);
			signature = credentials.GenerateRawSignature(hash);
		}
		new DigitallySigned(algorithm, signature).Encode(digestBuffer);
	}

	internal static void VerifyServerKeyExchangeSignature(TlsContext context, Stream signatureInput, TlsCertificate serverCertificate, byte[] extraSignatureInput, DigestInputBuffer digestBuffer)
	{
		DigitallySigned digitallySigned = DigitallySigned.Parse(context, signatureInput);
		SecurityParameters securityParameters = context.SecurityParameters;
		int keyExchangeAlgorithm = securityParameters.KeyExchangeAlgorithm;
		SignatureAndHashAlgorithm sigAndHashAlg = digitallySigned.Algorithm;
		short signatureAlgorithm;
		if (sigAndHashAlg == null)
		{
			signatureAlgorithm = GetLegacySignatureAlgorithmServer(keyExchangeAlgorithm);
		}
		else
		{
			signatureAlgorithm = sigAndHashAlg.Signature;
			if (!IsValidSignatureAlgorithmForServerKeyExchange(signatureAlgorithm, keyExchangeAlgorithm))
			{
				throw new TlsFatalAlert(47);
			}
			VerifySupportedSignatureAlgorithm(securityParameters.ClientSigAlgs, sigAndHashAlg);
		}
		TlsVerifier verifier = serverCertificate.CreateVerifier(signatureAlgorithm);
		TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(digitallySigned);
		bool verified;
		if (streamVerifier != null)
		{
			SendSignatureInput(context, null, digestBuffer, streamVerifier.GetOutputStream());
			verified = streamVerifier.IsVerified();
		}
		else
		{
			byte[] hash = CalculateSignatureHash(context, sigAndHashAlg, null, digestBuffer);
			verified = verifier.VerifyRawSignature(digitallySigned, hash);
		}
		if (!verified)
		{
			throw new TlsFatalAlert(51);
		}
	}

	internal static void TrackHashAlgorithms(TlsHandshakeHash handshakeHash, IList supportedSignatureAlgorithms)
	{
		if (supportedSignatureAlgorithms == null)
		{
			return;
		}
		foreach (SignatureAndHashAlgorithm signatureAndHashAlgorithm in supportedSignatureAlgorithms)
		{
			int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(SignatureScheme.From(signatureAndHashAlgorithm));
			if (cryptoHashAlgorithm >= 0)
			{
				handshakeHash.TrackHashAlgorithm(cryptoHashAlgorithm);
			}
			else if (8 == signatureAndHashAlgorithm.Hash)
			{
				handshakeHash.ForceBuffering();
			}
		}
	}

	public static bool HasSigningCapability(short clientCertificateType)
	{
		if ((uint)(clientCertificateType - 1) <= 1u || clientCertificateType == 64)
		{
			return true;
		}
		return false;
	}

	public static IList VectorOfOne(object obj)
	{
		IList list = Platform.CreateArrayList(1);
		list.Add(obj);
		return list;
	}

	public static int GetCipherType(int cipherSuite)
	{
		return GetEncryptionAlgorithmType(GetEncryptionAlgorithm(cipherSuite));
	}

	public static int GetEncryptionAlgorithm(int cipherSuite)
	{
		switch (cipherSuite)
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
		case 4868:
		case 49308:
		case 49310:
		case 49316:
		case 49318:
		case 49324:
		case 53253:
			return 15;
		case 4869:
		case 49312:
		case 49314:
		case 49320:
		case 49322:
		case 49326:
		case 53251:
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
		case 4865:
		case 49195:
		case 49197:
		case 49199:
		case 49201:
		case 53249:
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
		case 4866:
		case 49196:
		case 49198:
		case 49200:
		case 49202:
		case 53250:
			return 11;
		case 49212:
		case 49214:
		case 49216:
		case 49218:
		case 49220:
		case 49222:
		case 49224:
		case 49226:
		case 49228:
		case 49230:
		case 49252:
		case 49254:
		case 49256:
		case 49264:
			return 22;
		case 49232:
		case 49234:
		case 49236:
		case 49238:
		case 49240:
		case 49242:
		case 49244:
		case 49246:
		case 49248:
		case 49250:
		case 49258:
		case 49260:
		case 49262:
			return 24;
		case 49213:
		case 49215:
		case 49217:
		case 49219:
		case 49221:
		case 49223:
		case 49225:
		case 49227:
		case 49229:
		case 49231:
		case 49253:
		case 49255:
		case 49257:
		case 49265:
			return 23;
		case 49233:
		case 49235:
		case 49237:
		case 49239:
		case 49241:
		case 49243:
		case 49245:
		case 49247:
		case 49249:
		case 49251:
		case 49259:
		case 49261:
		case 49263:
			return 25;
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
		case 4867:
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
			return 21;
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
		case 150:
		case 151:
		case 152:
		case 153:
		case 154:
		case 155:
			return 14;
		case 199:
			return 26;
		case 198:
			return 27;
		default:
			return -1;
		}
	}

	public static int GetEncryptionAlgorithmType(int encryptionAlgorithm)
	{
		switch (encryptionAlgorithm)
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
		case 24:
		case 25:
		case 26:
		case 27:
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
		case 22:
		case 23:
		case 28:
			return 1;
		case 0:
		case 1:
		case 2:
			return 0;
		default:
			return -1;
		}
	}

	public static int GetKeyExchangeAlgorithm(int cipherSuite)
	{
		switch (cipherSuite)
		{
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
		case 49222:
		case 49223:
		case 49242:
		case 49243:
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
		case 49214:
		case 49215:
		case 49240:
		case 49241:
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
		case 49216:
		case 49217:
		case 49236:
		case 49237:
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
		case 49218:
		case 49219:
		case 49238:
		case 49239:
		case 49280:
		case 49281:
			return 3;
		case 45:
		case 143:
		case 144:
		case 145:
		case 170:
		case 171:
		case 178:
		case 179:
		case 180:
		case 181:
		case 49254:
		case 49255:
		case 49260:
		case 49261:
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
		case 49220:
		case 49221:
		case 49234:
		case 49235:
		case 49276:
		case 49277:
		case 49310:
		case 49311:
		case 49314:
		case 49315:
		case 52394:
			return 5;
		case 49173:
		case 49175:
		case 49176:
		case 49177:
			return 20;
		case 49153:
		case 49155:
		case 49156:
		case 49157:
		case 49189:
		case 49190:
		case 49197:
		case 49198:
		case 49226:
		case 49227:
		case 49246:
		case 49247:
		case 49268:
		case 49269:
		case 49288:
		case 49289:
			return 16;
		case 49163:
		case 49165:
		case 49166:
		case 49167:
		case 49193:
		case 49194:
		case 49201:
		case 49202:
		case 49230:
		case 49231:
		case 49250:
		case 49251:
		case 49272:
		case 49273:
		case 49292:
		case 49293:
			return 18;
		case 49158:
		case 49160:
		case 49161:
		case 49162:
		case 49187:
		case 49188:
		case 49195:
		case 49196:
		case 49224:
		case 49225:
		case 49244:
		case 49245:
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
		case 49204:
		case 49205:
		case 49206:
		case 49207:
		case 49208:
		case 49209:
		case 49210:
		case 49211:
		case 49264:
		case 49265:
		case 49306:
		case 49307:
		case 52396:
		case 53249:
		case 53250:
		case 53251:
		case 53253:
			return 24;
		case 49168:
		case 49170:
		case 49171:
		case 49172:
		case 49191:
		case 49192:
		case 49199:
		case 49200:
		case 49228:
		case 49229:
		case 49248:
		case 49249:
		case 49270:
		case 49271:
		case 49290:
		case 49291:
		case 52392:
			return 19;
		case 198:
		case 199:
		case 4865:
		case 4866:
		case 4867:
		case 4868:
		case 4869:
			return 0;
		case 44:
		case 139:
		case 140:
		case 141:
		case 168:
		case 169:
		case 174:
		case 175:
		case 176:
		case 177:
		case 49252:
		case 49253:
		case 49258:
		case 49259:
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
		case 2:
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
		case 49212:
		case 49213:
		case 49232:
		case 49233:
		case 49274:
		case 49275:
		case 49308:
		case 49309:
		case 49312:
		case 49313:
			return 1;
		case 46:
		case 147:
		case 148:
		case 149:
		case 172:
		case 173:
		case 182:
		case 183:
		case 184:
		case 185:
		case 49256:
		case 49257:
		case 49262:
		case 49263:
		case 49298:
		case 49299:
		case 49304:
		case 49305:
		case 52398:
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
			return -1;
		}
	}

	public static IList GetKeyExchangeAlgorithms(int[] cipherSuites)
	{
		IList result = Platform.CreateArrayList();
		if (cipherSuites != null)
		{
			for (int i = 0; i < cipherSuites.Length; i++)
			{
				AddToSet(result, GetKeyExchangeAlgorithm(cipherSuites[i]));
			}
			result.Remove(-1);
		}
		return result;
	}

	public static int GetMacAlgorithm(int cipherSuite)
	{
		if (cipherSuite <= 49327)
		{
			switch (cipherSuite)
			{
			default:
				switch (cipherSuite)
				{
				case 4865:
				case 4866:
				case 4867:
				case 4868:
				case 4869:
				case 49195:
				case 49196:
				case 49197:
				case 49198:
				case 49199:
				case 49200:
				case 49201:
				case 49202:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
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
					break;
				case 49153:
				case 49155:
				case 49156:
				case 49157:
				case 49158:
				case 49160:
				case 49161:
				case 49162:
				case 49163:
				case 49165:
				case 49166:
				case 49167:
				case 49168:
				case 49170:
				case 49171:
				case 49172:
				case 49173:
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
				case 49204:
				case 49205:
				case 49206:
				case 49209:
					goto IL_0620;
				case 49187:
				case 49189:
				case 49191:
				case 49193:
				case 49207:
				case 49210:
				case 49212:
				case 49214:
				case 49216:
				case 49218:
				case 49220:
				case 49222:
				case 49224:
				case 49226:
				case 49228:
				case 49230:
				case 49252:
				case 49254:
				case 49256:
				case 49264:
				case 49266:
				case 49268:
				case 49270:
				case 49272:
				case 49300:
				case 49302:
				case 49304:
				case 49306:
					goto IL_0622;
				case 49188:
				case 49190:
				case 49192:
				case 49194:
				case 49208:
				case 49211:
				case 49213:
				case 49215:
				case 49217:
				case 49219:
				case 49221:
				case 49223:
				case 49225:
				case 49227:
				case 49229:
				case 49231:
				case 49253:
				case 49255:
				case 49257:
				case 49265:
				case 49267:
				case 49269:
				case 49271:
				case 49273:
				case 49301:
				case 49303:
				case 49305:
				case 49307:
					goto IL_0624;
				default:
					goto IL_0626;
				}
				break;
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
			case 198:
			case 199:
				break;
			case 2:
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
			case 139:
			case 140:
			case 141:
			case 143:
			case 144:
			case 145:
			case 147:
			case 148:
			case 149:
			case 150:
			case 151:
			case 152:
			case 153:
			case 154:
			case 155:
				goto IL_0620;
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
				goto IL_0622;
			case 175:
			case 177:
			case 179:
			case 181:
			case 183:
			case 185:
				goto IL_0624;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
			case 14:
			case 15:
			case 17:
			case 18:
			case 20:
			case 21:
			case 23:
			case 24:
			case 25:
			case 26:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 84:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
			case 117:
			case 118:
			case 119:
			case 120:
			case 121:
			case 122:
			case 123:
			case 124:
			case 125:
			case 126:
			case 127:
			case 128:
			case 129:
			case 130:
			case 131:
			case 138:
			case 142:
			case 146:
				goto IL_0626;
				IL_0624:
				return 4;
				IL_0622:
				return 3;
				IL_0620:
				return 2;
			}
		}
		else if ((uint)(cipherSuite - 52392) > 6u && (uint)(cipherSuite - 53249) > 2u && cipherSuite != 53253)
		{
			goto IL_0626;
		}
		return 0;
		IL_0626:
		return -1;
	}

	public static ProtocolVersion GetMinimumVersion(int cipherSuite)
	{
		if (cipherSuite <= 4869)
		{
			switch (cipherSuite)
			{
			case 198:
			case 199:
			case 4865:
			case 4866:
			case 4867:
			case 4868:
			case 4869:
				return ProtocolVersion.TLSv13;
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
				break;
			default:
				goto IL_036e;
			}
		}
		else if (cipherSuite <= 52398)
		{
			switch (cipherSuite)
			{
			default:
				if ((uint)(cipherSuite - 52392) <= 6u)
				{
					break;
				}
				goto IL_036e;
			case 49187:
			case 49188:
			case 49189:
			case 49190:
			case 49191:
			case 49192:
			case 49193:
			case 49194:
			case 49195:
			case 49196:
			case 49197:
			case 49198:
			case 49199:
			case 49200:
			case 49201:
			case 49202:
			case 49212:
			case 49213:
			case 49214:
			case 49215:
			case 49216:
			case 49217:
			case 49218:
			case 49219:
			case 49220:
			case 49221:
			case 49222:
			case 49223:
			case 49224:
			case 49225:
			case 49226:
			case 49227:
			case 49228:
			case 49229:
			case 49230:
			case 49231:
			case 49232:
			case 49233:
			case 49234:
			case 49235:
			case 49236:
			case 49237:
			case 49238:
			case 49239:
			case 49240:
			case 49241:
			case 49242:
			case 49243:
			case 49244:
			case 49245:
			case 49246:
			case 49247:
			case 49248:
			case 49249:
			case 49250:
			case 49251:
			case 49252:
			case 49253:
			case 49254:
			case 49255:
			case 49256:
			case 49257:
			case 49258:
			case 49259:
			case 49260:
			case 49261:
			case 49262:
			case 49263:
			case 49264:
			case 49265:
			case 49266:
			case 49267:
			case 49268:
			case 49269:
			case 49270:
			case 49271:
			case 49272:
			case 49273:
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
				break;
			case 49203:
			case 49204:
			case 49205:
			case 49206:
			case 49207:
			case 49208:
			case 49209:
			case 49210:
			case 49211:
			case 49300:
			case 49301:
			case 49302:
			case 49303:
			case 49304:
			case 49305:
			case 49306:
			case 49307:
				goto IL_036e;
			}
		}
		else if ((uint)(cipherSuite - 53249) > 2u && cipherSuite != 53253)
		{
			goto IL_036e;
		}
		return ProtocolVersion.TLSv12;
		IL_036e:
		return ProtocolVersion.SSLv3;
	}

	public static IList GetNamedGroupRoles(int[] cipherSuites)
	{
		return GetNamedGroupRoles(GetKeyExchangeAlgorithms(cipherSuites));
	}

	public static IList GetNamedGroupRoles(IList keyExchangeAlgorithms)
	{
		IList result = Platform.CreateArrayList();
		IEnumerator enumerator = keyExchangeAlgorithms.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				switch ((int)enumerator.Current)
				{
				case 3:
				case 5:
				case 7:
				case 9:
				case 11:
				case 14:
					AddToSet(result, 1);
					break;
				case 18:
				case 19:
				case 20:
				case 24:
					AddToSet(result, 2);
					break;
				case 16:
				case 17:
					AddToSet(result, 2);
					AddToSet(result, 3);
					break;
				case 0:
					AddToSet(result, 1);
					AddToSet(result, 2);
					break;
				}
			}
			return result;
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public static bool IsAeadCipherSuite(int cipherSuite)
	{
		return 2 == GetCipherType(cipherSuite);
	}

	public static bool IsBlockCipherSuite(int cipherSuite)
	{
		return 1 == GetCipherType(cipherSuite);
	}

	public static bool IsStreamCipherSuite(int cipherSuite)
	{
		return GetCipherType(cipherSuite) == 0;
	}

	public static bool IsValidCipherSuiteForSignatureAlgorithms(int cipherSuite, IList sigAlgs)
	{
		int keyExchangeAlgorithm = GetKeyExchangeAlgorithm(cipherSuite);
		switch (keyExchangeAlgorithm)
		{
		default:
			return true;
		case 0:
		case 3:
		case 5:
		case 17:
		case 19:
		case 22:
		case 23:
			foreach (short sigAlg in sigAlgs)
			{
				if (IsValidSignatureAlgorithmForServerKeyExchange(sigAlg, keyExchangeAlgorithm))
				{
					return true;
				}
			}
			return false;
		}
	}

	internal static bool IsValidCipherSuiteSelection(int[] offeredCipherSuites, int cipherSuite)
	{
		if (offeredCipherSuites != null && Arrays.Contains(offeredCipherSuites, cipherSuite) && cipherSuite != 0)
		{
			return !CipherSuite.IsScsv(cipherSuite);
		}
		return false;
	}

	internal static bool IsValidKeyShareSelection(ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, IDictionary clientAgreements, int keyShareGroup)
	{
		if (clientSupportedGroups != null && Arrays.Contains(clientSupportedGroups, keyShareGroup) && !clientAgreements.Contains(keyShareGroup))
		{
			return NamedGroup.CanBeNegotiated(keyShareGroup, negotiatedVersion);
		}
		return false;
	}

	internal static bool IsValidSignatureAlgorithmForCertificateVerify(short signatureAlgorithm, short[] clientCertificateTypes)
	{
		short clientCertificateType = SignatureAlgorithm.GetClientCertificateType(signatureAlgorithm);
		if (clientCertificateType >= 0)
		{
			return Arrays.Contains(clientCertificateTypes, clientCertificateType);
		}
		return false;
	}

	internal static bool IsValidSignatureAlgorithmForServerKeyExchange(short signatureAlgorithm, int keyExchangeAlgorithm)
	{
		switch (keyExchangeAlgorithm)
		{
		case 5:
		case 19:
		case 23:
			switch (signatureAlgorithm)
			{
			case 1:
			case 4:
			case 5:
			case 6:
			case 9:
			case 10:
			case 11:
				return true;
			default:
				return false;
			}
		case 3:
		case 22:
			return 2 == signatureAlgorithm;
		case 17:
			if (signatureAlgorithm == 3 || (uint)(signatureAlgorithm - 7) <= 1u)
			{
				return true;
			}
			return false;
		case 0:
			return signatureAlgorithm != 0;
		default:
			return false;
		}
	}

	public static bool IsValidSignatureSchemeForServerKeyExchange(int signatureScheme, int keyExchangeAlgorithm)
	{
		return IsValidSignatureAlgorithmForServerKeyExchange(SignatureScheme.GetSignatureAlgorithm(signatureScheme), keyExchangeAlgorithm);
	}

	public static bool IsValidVersionForCipherSuite(int cipherSuite, ProtocolVersion version)
	{
		version = version.GetEquivalentTlsVersion();
		ProtocolVersion minimumVersion = GetMinimumVersion(cipherSuite);
		if (minimumVersion == version)
		{
			return true;
		}
		if (!minimumVersion.IsEarlierVersionOf(version))
		{
			return false;
		}
		if (!ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(minimumVersion))
		{
			return ProtocolVersion.TLSv13.IsLaterVersionOf(version);
		}
		return true;
	}

	public static SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(TlsContext context, IList sigHashAlgs, short signatureAlgorithm)
	{
		return ChooseSignatureAndHashAlgorithm(context.ServerVersion, sigHashAlgs, signatureAlgorithm);
	}

	public static SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(ProtocolVersion negotiatedVersion, IList sigHashAlgs, short signatureAlgorithm)
	{
		if (!IsTlsV12(negotiatedVersion))
		{
			return null;
		}
		if (sigHashAlgs == null)
		{
			sigHashAlgs = GetDefaultSignatureAlgorithms(signatureAlgorithm);
		}
		SignatureAndHashAlgorithm result = null;
		foreach (SignatureAndHashAlgorithm sigHashAlg in sigHashAlgs)
		{
			if (sigHashAlg.Signature != signatureAlgorithm)
			{
				continue;
			}
			short hash = sigHashAlg.Hash;
			if (hash < MinimumHashStrict)
			{
				continue;
			}
			if (result == null)
			{
				result = sigHashAlg;
				continue;
			}
			short current = result.Hash;
			if (current < MinimumHashPreferred)
			{
				if (hash > current)
				{
					result = sigHashAlg;
				}
			}
			else if (hash >= MinimumHashPreferred && hash < current)
			{
				result = sigHashAlg;
			}
		}
		if (result == null)
		{
			throw new TlsFatalAlert(80);
		}
		return result;
	}

	public static IList GetUsableSignatureAlgorithms(IList sigHashAlgs)
	{
		if (sigHashAlgs == null)
		{
			IList list = Platform.CreateArrayList(3);
			list.Add((short)1);
			list.Add((short)2);
			list.Add((short)3);
			return list;
		}
		IList v = Platform.CreateArrayList();
		foreach (SignatureAndHashAlgorithm sigHashAlg in sigHashAlgs)
		{
			if (sigHashAlg.Hash >= MinimumHashStrict)
			{
				short sigAlg = sigHashAlg.Signature;
				if (!v.Contains(sigAlg))
				{
					v.Add(sigAlg);
				}
			}
		}
		return v;
	}

	public static int GetCommonCipherSuite13(ProtocolVersion negotiatedVersion, int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
	{
		int[] ordered = peerCipherSuites;
		int[] unordered = localCipherSuites;
		if (useLocalOrder)
		{
			ordered = localCipherSuites;
			unordered = peerCipherSuites;
		}
		foreach (int candidate in ordered)
		{
			if (Arrays.Contains(unordered, candidate) && IsValidVersionForCipherSuite(candidate, negotiatedVersion))
			{
				return candidate;
			}
		}
		return -1;
	}

	public static int[] GetCommonCipherSuites(int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
	{
		int[] ordered = peerCipherSuites;
		int[] unordered = localCipherSuites;
		if (useLocalOrder)
		{
			ordered = localCipherSuites;
			unordered = peerCipherSuites;
		}
		int count = 0;
		int limit = System.Math.Min(ordered.Length, unordered.Length);
		int[] candidates = new int[limit];
		foreach (int candidate in ordered)
		{
			if (!Contains(candidates, 0, count, candidate) && Arrays.Contains(unordered, candidate))
			{
				candidates[count++] = candidate;
			}
		}
		if (count < limit)
		{
			candidates = Arrays.CopyOf(candidates, count);
		}
		return candidates;
	}

	public static int[] GetSupportedCipherSuites(TlsCrypto crypto, int[] suites)
	{
		return GetSupportedCipherSuites(crypto, suites, 0, suites.Length);
	}

	public static int[] GetSupportedCipherSuites(TlsCrypto crypto, int[] suites, int suitesOff, int suitesCount)
	{
		int[] supported = new int[suitesCount];
		int count = 0;
		for (int i = 0; i < suitesCount; i++)
		{
			int suite = suites[suitesOff + i];
			if (IsSupportedCipherSuite(crypto, suite))
			{
				supported[count++] = suite;
			}
		}
		if (count < suitesCount)
		{
			supported = Arrays.CopyOf(supported, count);
		}
		return supported;
	}

	public static bool IsSupportedCipherSuite(TlsCrypto crypto, int cipherSuite)
	{
		if (IsSupportedKeyExchange(crypto, GetKeyExchangeAlgorithm(cipherSuite)) && crypto.HasEncryptionAlgorithm(GetEncryptionAlgorithm(cipherSuite)))
		{
			return crypto.HasMacAlgorithm(GetMacAlgorithm(cipherSuite));
		}
		return false;
	}

	public static bool IsSupportedKeyExchange(TlsCrypto crypto, int keyExchangeAlgorithm)
	{
		switch (keyExchangeAlgorithm)
		{
		case 7:
		case 9:
		case 11:
		case 14:
			return crypto.HasDHAgreement();
		case 3:
			if (crypto.HasDHAgreement())
			{
				return crypto.HasSignatureAlgorithm(2);
			}
			return false;
		case 5:
			if (crypto.HasDHAgreement())
			{
				return HasAnyRsaSigAlgs(crypto);
			}
			return false;
		case 16:
		case 18:
		case 20:
		case 24:
			return crypto.HasECDHAgreement();
		case 17:
			if (crypto.HasECDHAgreement())
			{
				if (!crypto.HasSignatureAlgorithm(3) && !crypto.HasSignatureAlgorithm(7))
				{
					return crypto.HasSignatureAlgorithm(8);
				}
				return true;
			}
			return false;
		case 19:
			if (crypto.HasECDHAgreement())
			{
				return HasAnyRsaSigAlgs(crypto);
			}
			return false;
		case 0:
		case 13:
			return true;
		case 1:
		case 15:
			return crypto.HasRsaEncryption();
		case 21:
			return crypto.HasSrpAuthentication();
		case 22:
			if (crypto.HasSrpAuthentication())
			{
				return crypto.HasSignatureAlgorithm(2);
			}
			return false;
		case 23:
			if (crypto.HasSrpAuthentication())
			{
				return HasAnyRsaSigAlgs(crypto);
			}
			return false;
		default:
			return false;
		}
	}

	internal static bool HasAnyRsaSigAlgs(TlsCrypto crypto)
	{
		if (!crypto.HasSignatureAlgorithm(1) && !crypto.HasSignatureAlgorithm(4) && !crypto.HasSignatureAlgorithm(5) && !crypto.HasSignatureAlgorithm(6) && !crypto.HasSignatureAlgorithm(9) && !crypto.HasSignatureAlgorithm(10))
		{
			return crypto.HasSignatureAlgorithm(11);
		}
		return true;
	}

	internal static byte[] GetCurrentPrfHash(TlsHandshakeHash handshakeHash)
	{
		return handshakeHash.ForkPrfHash().CalculateHash();
	}

	internal static void SealHandshakeHash(TlsContext context, TlsHandshakeHash handshakeHash, bool forceBuffering)
	{
		if (forceBuffering || !context.Crypto.HasAllRawSignatureAlgorithms())
		{
			handshakeHash.ForceBuffering();
		}
		handshakeHash.SealHashAlgorithms();
	}

	private static TlsHash CreateHash(TlsCrypto crypto, short hashAlgorithm)
	{
		int cryptoHashAlgorithm = TlsCryptoUtilities.GetHash(hashAlgorithm);
		return crypto.CreateHash(cryptoHashAlgorithm);
	}

	private static TlsKeyExchange CreateKeyExchangeClient(TlsClient client, int keyExchange)
	{
		TlsKeyExchangeFactory factory = client.GetKeyExchangeFactory();
		switch (keyExchange)
		{
		case 11:
			return factory.CreateDHanonKeyExchangeClient(keyExchange, client.GetDHGroupVerifier());
		case 7:
		case 9:
			return factory.CreateDHKeyExchange(keyExchange);
		case 3:
		case 5:
			return factory.CreateDheKeyExchangeClient(keyExchange, client.GetDHGroupVerifier());
		case 20:
			return factory.CreateECDHanonKeyExchangeClient(keyExchange);
		case 16:
		case 18:
			return factory.CreateECDHKeyExchange(keyExchange);
		case 17:
		case 19:
			return factory.CreateECDheKeyExchangeClient(keyExchange);
		case 1:
			return factory.CreateRsaKeyExchange(keyExchange);
		case 14:
			return factory.CreatePskKeyExchangeClient(keyExchange, client.GetPskIdentity(), client.GetDHGroupVerifier());
		case 13:
		case 15:
		case 24:
			return factory.CreatePskKeyExchangeClient(keyExchange, client.GetPskIdentity(), null);
		case 21:
		case 22:
		case 23:
			return factory.CreateSrpKeyExchangeClient(keyExchange, client.GetSrpIdentity(), client.GetSrpConfigVerifier());
		default:
			throw new TlsFatalAlert(80);
		}
	}

	private static TlsKeyExchange CreateKeyExchangeServer(TlsServer server, int keyExchange)
	{
		TlsKeyExchangeFactory factory = server.GetKeyExchangeFactory();
		switch (keyExchange)
		{
		case 11:
			return factory.CreateDHanonKeyExchangeServer(keyExchange, server.GetDHConfig());
		case 7:
		case 9:
			return factory.CreateDHKeyExchange(keyExchange);
		case 3:
		case 5:
			return factory.CreateDheKeyExchangeServer(keyExchange, server.GetDHConfig());
		case 20:
			return factory.CreateECDHanonKeyExchangeServer(keyExchange, server.GetECDHConfig());
		case 16:
		case 18:
			return factory.CreateECDHKeyExchange(keyExchange);
		case 17:
		case 19:
			return factory.CreateECDheKeyExchangeServer(keyExchange, server.GetECDHConfig());
		case 1:
			return factory.CreateRsaKeyExchange(keyExchange);
		case 14:
			return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), server.GetDHConfig(), null);
		case 24:
			return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), null, server.GetECDHConfig());
		case 13:
		case 15:
			return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), null, null);
		case 21:
		case 22:
		case 23:
			return factory.CreateSrpKeyExchangeServer(keyExchange, server.GetSrpLoginParameters());
		default:
			throw new TlsFatalAlert(80);
		}
	}

	internal static TlsKeyExchange InitKeyExchangeClient(TlsClientContext clientContext, TlsClient client)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		TlsKeyExchange tlsKeyExchange = CreateKeyExchangeClient(client, securityParameters.KeyExchangeAlgorithm);
		tlsKeyExchange.Init(clientContext);
		return tlsKeyExchange;
	}

	internal static TlsKeyExchange InitKeyExchangeServer(TlsServerContext serverContext, TlsServer server)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		TlsKeyExchange tlsKeyExchange = CreateKeyExchangeServer(server, securityParameters.KeyExchangeAlgorithm);
		tlsKeyExchange.Init(serverContext);
		return tlsKeyExchange;
	}

	internal static TlsCipher InitCipher(TlsContext context)
	{
		int cipherSuite = context.SecurityParameters.CipherSuite;
		int encryptionAlgorithm = GetEncryptionAlgorithm(cipherSuite);
		int macAlgorithm = GetMacAlgorithm(cipherSuite);
		if (encryptionAlgorithm < 0 || macAlgorithm < 0)
		{
			throw new TlsFatalAlert(80);
		}
		return context.Crypto.CreateCipher(new TlsCryptoParameters(context), encryptionAlgorithm, macAlgorithm);
	}

	public static void CheckPeerSigAlgs(TlsContext context, TlsCertificate[] peerCertPath)
	{
		if (context.IsServer)
		{
			CheckSigAlgOfClientCerts(context, peerCertPath);
		}
		else
		{
			CheckSigAlgOfServerCerts(context, peerCertPath);
		}
	}

	private static void CheckSigAlgOfClientCerts(TlsContext context, TlsCertificate[] clientCertPath)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		short[] clientCertTypes = securityParameters.ClientCertTypes;
		IList serverSigAlgsCert = securityParameters.ServerSigAlgsCert;
		int trustAnchorPos = clientCertPath.Length - 1;
		for (int i = 0; i < trustAnchorPos; i++)
		{
			TlsCertificate subjectCert = clientCertPath[i];
			TlsCertificate issuerCert = clientCertPath[i + 1];
			SignatureAndHashAlgorithm sigAndHashAlg = GetCertSigAndHashAlg(subjectCert, issuerCert);
			bool valid = false;
			if (sigAndHashAlg != null)
			{
				if (serverSigAlgsCert == null)
				{
					if (clientCertTypes != null)
					{
						for (int j = 0; j < clientCertTypes.Length; j++)
						{
							short signatureAlgorithm = GetLegacySignatureAlgorithmClientCert(clientCertTypes[j]);
							if (sigAndHashAlg.Signature == signatureAlgorithm)
							{
								valid = true;
								break;
							}
						}
					}
				}
				else
				{
					valid = ContainsSignatureAlgorithm(serverSigAlgsCert, sigAndHashAlg);
				}
			}
			if (!valid)
			{
				throw new TlsFatalAlert(42);
			}
		}
	}

	private static void CheckSigAlgOfServerCerts(TlsContext context, TlsCertificate[] serverCertPath)
	{
		SecurityParameters securityParameters = context.SecurityParameters;
		IList clientSigAlgsCert = securityParameters.ClientSigAlgsCert;
		IList clientSigAlgs = securityParameters.ClientSigAlgs;
		if (clientSigAlgs == clientSigAlgsCert || IsTlsV13(securityParameters.NegotiatedVersion))
		{
			clientSigAlgs = null;
		}
		int trustAnchorPos = serverCertPath.Length - 1;
		for (int i = 0; i < trustAnchorPos; i++)
		{
			TlsCertificate subjectCert = serverCertPath[i];
			TlsCertificate issuerCert = serverCertPath[i + 1];
			SignatureAndHashAlgorithm sigAndHashAlg = GetCertSigAndHashAlg(subjectCert, issuerCert);
			bool valid = false;
			if (sigAndHashAlg != null)
			{
				valid = ((clientSigAlgsCert != null) ? (ContainsSignatureAlgorithm(clientSigAlgsCert, sigAndHashAlg) || (clientSigAlgs != null && ContainsSignatureAlgorithm(clientSigAlgs, sigAndHashAlg))) : (GetLegacySignatureAlgorithmServerCert(securityParameters.KeyExchangeAlgorithm) == sigAndHashAlg.Signature));
			}
			if (!valid)
			{
				throw new TlsFatalAlert(42);
			}
		}
	}

	internal static void CheckTlsFeatures(Certificate serverCertificate, IDictionary clientExtensions, IDictionary serverExtensions)
	{
		byte[] tlsFeatures = serverCertificate.GetCertificateAt(0).GetExtension(TlsObjectIdentifiers.id_pe_tlsfeature);
		if (tlsFeatures == null)
		{
			return;
		}
		foreach (DerInteger item in Asn1Sequence.GetInstance(ReadDerObject(tlsFeatures)))
		{
			int extensionType = item.IntValueExact;
			CheckUint16(extensionType);
			if (clientExtensions.Contains(extensionType) && !serverExtensions.Contains(extensionType))
			{
				throw new TlsFatalAlert(46);
			}
		}
	}

	internal static void ProcessClientCertificate(TlsServerContext serverContext, Certificate clientCertificate, TlsKeyExchange keyExchange, TlsServer server)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		if (securityParameters.PeerCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		if (!IsTlsV13(securityParameters.NegotiatedVersion))
		{
			if (clientCertificate.IsEmpty)
			{
				keyExchange.SkipClientCredentials();
			}
			else
			{
				keyExchange.ProcessClientCertificate(clientCertificate);
			}
		}
		securityParameters.m_peerCertificate = clientCertificate;
		server.NotifyClientCertificate(clientCertificate);
	}

	internal static void ProcessServerCertificate(TlsClientContext clientContext, CertificateStatus serverCertificateStatus, TlsKeyExchange keyExchange, TlsAuthentication clientAuthentication, IDictionary clientExtensions, IDictionary serverExtensions)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		bool isTlsV13 = IsTlsV13(securityParameters.NegotiatedVersion);
		if (clientAuthentication == null)
		{
			if (isTlsV13)
			{
				throw new TlsFatalAlert(80);
			}
			keyExchange.SkipServerCredentials();
			securityParameters.m_tlsServerEndPoint = EmptyBytes;
			return;
		}
		Certificate serverCertificate = securityParameters.PeerCertificate;
		CheckTlsFeatures(serverCertificate, clientExtensions, serverExtensions);
		if (!isTlsV13)
		{
			keyExchange.ProcessServerCertificate(serverCertificate);
		}
		clientAuthentication.NotifyServerCertificate(new TlsServerCertificateImpl(serverCertificate, serverCertificateStatus));
	}

	internal static SignatureAndHashAlgorithm GetCertSigAndHashAlg(TlsCertificate subjectCert, TlsCertificate issuerCert)
	{
		string sigAlgOid = subjectCert.SigAlgOid;
		if (sigAlgOid != null)
		{
			if (!PkcsObjectIdentifiers.IdRsassaPss.Id.Equals(sigAlgOid))
			{
				if (!CertSigAlgOids.Contains(sigAlgOid))
				{
					return null;
				}
				return (SignatureAndHashAlgorithm)CertSigAlgOids[sigAlgOid];
			}
			RsassaPssParameters pssParams = RsassaPssParameters.GetInstance(subjectCert.GetSigAlgParams());
			if (pssParams != null)
			{
				DerObjectIdentifier hashOid = pssParams.HashAlgorithm.Algorithm;
				if (NistObjectIdentifiers.IdSha256.Equals(hashOid))
				{
					if (issuerCert.SupportsSignatureAlgorithmCA(9))
					{
						return SignatureAndHashAlgorithm.rsa_pss_pss_sha256;
					}
					if (issuerCert.SupportsSignatureAlgorithmCA(4))
					{
						return SignatureAndHashAlgorithm.rsa_pss_rsae_sha256;
					}
				}
				else if (NistObjectIdentifiers.IdSha384.Equals(hashOid))
				{
					if (issuerCert.SupportsSignatureAlgorithmCA(10))
					{
						return SignatureAndHashAlgorithm.rsa_pss_pss_sha384;
					}
					if (issuerCert.SupportsSignatureAlgorithmCA(5))
					{
						return SignatureAndHashAlgorithm.rsa_pss_rsae_sha384;
					}
				}
				else if (NistObjectIdentifiers.IdSha512.Equals(hashOid))
				{
					if (issuerCert.SupportsSignatureAlgorithmCA(11))
					{
						return SignatureAndHashAlgorithm.rsa_pss_pss_sha512;
					}
					if (issuerCert.SupportsSignatureAlgorithmCA(6))
					{
						return SignatureAndHashAlgorithm.rsa_pss_rsae_sha512;
					}
				}
			}
		}
		return null;
	}

	internal static CertificateRequest ValidateCertificateRequest(CertificateRequest certificateRequest, TlsKeyExchange keyExchange)
	{
		short[] validClientCertificateTypes = keyExchange.GetClientCertificateTypes();
		if (IsNullOrEmpty(validClientCertificateTypes))
		{
			throw new TlsFatalAlert(10);
		}
		certificateRequest = NormalizeCertificateRequest(certificateRequest, validClientCertificateTypes);
		if (certificateRequest == null)
		{
			throw new TlsFatalAlert(47);
		}
		return certificateRequest;
	}

	internal static CertificateRequest NormalizeCertificateRequest(CertificateRequest certificateRequest, short[] validClientCertificateTypes)
	{
		if (ContainsAll(validClientCertificateTypes, certificateRequest.CertificateTypes))
		{
			return certificateRequest;
		}
		short[] retained = RetainAll(certificateRequest.CertificateTypes, validClientCertificateTypes);
		if (retained.Length < 1)
		{
			return null;
		}
		return new CertificateRequest(retained, certificateRequest.SupportedSignatureAlgorithms, certificateRequest.CertificateAuthorities);
	}

	internal static bool Contains(int[] buf, int off, int len, int value)
	{
		for (int i = 0; i < len; i++)
		{
			if (value == buf[off + i])
			{
				return true;
			}
		}
		return false;
	}

	internal static bool ContainsAll(short[] container, short[] elements)
	{
		for (int i = 0; i < elements.Length; i++)
		{
			if (!Arrays.Contains(container, elements[i]))
			{
				return false;
			}
		}
		return true;
	}

	internal static short[] RetainAll(short[] retainer, short[] elements)
	{
		short[] retained = new short[System.Math.Min(retainer.Length, elements.Length)];
		int count = 0;
		for (int i = 0; i < elements.Length; i++)
		{
			if (Arrays.Contains(retainer, elements[i]))
			{
				retained[count++] = elements[i];
			}
		}
		return Truncate(retained, count);
	}

	internal static short[] Truncate(short[] a, int n)
	{
		if (n >= a.Length)
		{
			return a;
		}
		short[] t = new short[n];
		Array.Copy(a, 0, t, 0, n);
		return t;
	}

	internal static int[] Truncate(int[] a, int n)
	{
		if (n >= a.Length)
		{
			return a;
		}
		int[] t = new int[n];
		Array.Copy(a, 0, t, 0, n);
		return t;
	}

	internal static TlsCredentialedAgreement RequireAgreementCredentials(TlsCredentials credentials)
	{
		if (!(credentials is TlsCredentialedAgreement))
		{
			throw new TlsFatalAlert(80);
		}
		return (TlsCredentialedAgreement)credentials;
	}

	internal static TlsCredentialedDecryptor RequireDecryptorCredentials(TlsCredentials credentials)
	{
		if (!(credentials is TlsCredentialedDecryptor))
		{
			throw new TlsFatalAlert(80);
		}
		return (TlsCredentialedDecryptor)credentials;
	}

	internal static TlsCredentialedSigner RequireSignerCredentials(TlsCredentials credentials)
	{
		if (!(credentials is TlsCredentialedSigner))
		{
			throw new TlsFatalAlert(80);
		}
		return (TlsCredentialedSigner)credentials;
	}

	private static void CheckDowngradeMarker(byte[] randomBlock, byte[] downgradeMarker)
	{
		int len = downgradeMarker.Length;
		if (ConstantTimeAreEqual(len, downgradeMarker, 0, randomBlock, randomBlock.Length - len))
		{
			throw new TlsFatalAlert(47);
		}
	}

	internal static void CheckDowngradeMarker(ProtocolVersion version, byte[] randomBlock)
	{
		version = version.GetEquivalentTlsVersion();
		if (version.IsEqualOrEarlierVersionOf(ProtocolVersion.TLSv11))
		{
			CheckDowngradeMarker(randomBlock, DowngradeTlsV11);
		}
		if (version.IsEqualOrEarlierVersionOf(ProtocolVersion.TLSv12))
		{
			CheckDowngradeMarker(randomBlock, DowngradeTlsV12);
		}
	}

	internal static void WriteDowngradeMarker(ProtocolVersion version, byte[] randomBlock)
	{
		version = version.GetEquivalentTlsVersion();
		byte[] marker;
		if (ProtocolVersion.TLSv12 == version)
		{
			marker = DowngradeTlsV12;
		}
		else
		{
			if (!version.IsEqualOrEarlierVersionOf(ProtocolVersion.TLSv11))
			{
				throw new TlsFatalAlert(80);
			}
			marker = DowngradeTlsV11;
		}
		Array.Copy(marker, 0, randomBlock, randomBlock.Length - marker.Length, marker.Length);
	}

	internal static TlsAuthentication ReceiveServerCertificate(TlsClientContext clientContext, TlsClient client, MemoryStream buf)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		if (securityParameters.PeerCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		MemoryStream endPointHash = new MemoryStream();
		Certificate serverCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(client.GetMaxCertificateChainLength()), clientContext, buf, endPointHash);
		TlsProtocol.AssertEmpty(buf);
		if (serverCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(50);
		}
		securityParameters.m_peerCertificate = serverCertificate;
		securityParameters.m_tlsServerEndPoint = endPointHash.ToArray();
		TlsAuthentication authentication = client.GetAuthentication();
		if (authentication == null)
		{
			throw new TlsFatalAlert(80);
		}
		return authentication;
	}

	internal static TlsAuthentication Receive13ServerCertificate(TlsClientContext clientContext, TlsClient client, MemoryStream buf)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		if (securityParameters.PeerCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		Certificate serverCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(client.GetMaxCertificateChainLength()), clientContext, buf, null);
		TlsProtocol.AssertEmpty(buf);
		if (serverCertificate.GetCertificateRequestContext().Length != 0)
		{
			throw new TlsFatalAlert(47);
		}
		if (serverCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(50);
		}
		securityParameters.m_peerCertificate = serverCertificate;
		securityParameters.m_tlsServerEndPoint = null;
		TlsAuthentication authentication = client.GetAuthentication();
		if (authentication == null)
		{
			throw new TlsFatalAlert(80);
		}
		return authentication;
	}

	internal static TlsAuthentication Skip13ServerCertificate(TlsClientContext clientContext)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		if (securityParameters.PeerCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		securityParameters.m_peerCertificate = null;
		securityParameters.m_tlsServerEndPoint = null;
		return null;
	}

	public static bool ContainsNonAscii(byte[] bs)
	{
		for (int i = 0; i < bs.Length; i++)
		{
			if (bs[i] >= 128)
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainsNonAscii(string s)
	{
		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] >= '\u0080')
			{
				return true;
			}
		}
		return false;
	}

	internal static IDictionary AddKeyShareToClientHello(TlsClientContext clientContext, TlsClient client, IDictionary clientExtensions)
	{
		if (!IsTlsV13(clientContext.ClientVersion) || !clientExtensions.Contains(10))
		{
			return null;
		}
		int[] supportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(clientExtensions);
		IList keyShareGroups = client.GetEarlyKeyShareGroups();
		IDictionary clientAgreements = Platform.CreateHashtable(3);
		IList clientShares = Platform.CreateArrayList(2);
		CollectKeyShares(clientContext.Crypto, supportedGroups, keyShareGroups, clientAgreements, clientShares);
		TlsExtensionsUtilities.AddKeyShareClientHello(clientExtensions, clientShares);
		return clientAgreements;
	}

	internal static IDictionary AddKeyShareToClientHelloRetry(TlsClientContext clientContext, IDictionary clientExtensions, int keyShareGroup)
	{
		int[] supportedGroups = new int[1] { keyShareGroup };
		IList keyShareGroups = VectorOfOne(keyShareGroup);
		IDictionary clientAgreements = Platform.CreateHashtable(1);
		IList clientShares = Platform.CreateArrayList(1);
		CollectKeyShares(clientContext.Crypto, supportedGroups, keyShareGroups, clientAgreements, clientShares);
		TlsExtensionsUtilities.AddKeyShareClientHello(clientExtensions, clientShares);
		if (clientAgreements.Count < 1 || clientShares.Count < 1)
		{
			throw new TlsFatalAlert(80);
		}
		return clientAgreements;
	}

	private static void CollectKeyShares(TlsCrypto crypto, int[] supportedGroups, IList keyShareGroups, IDictionary clientAgreements, IList clientShares)
	{
		if (IsNullOrEmpty(supportedGroups) || keyShareGroups == null || keyShareGroups.Count < 1)
		{
			return;
		}
		foreach (int supportedGroup in supportedGroups)
		{
			if (!keyShareGroups.Contains(supportedGroup) || clientAgreements.Contains(supportedGroup) || !crypto.HasNamedGroup(supportedGroup))
			{
				continue;
			}
			TlsAgreement agreement = null;
			if (NamedGroup.RefersToASpecificCurve(supportedGroup))
			{
				if (crypto.HasECDHAgreement())
				{
					agreement = crypto.CreateECDomain(new TlsECConfig(supportedGroup)).CreateECDH();
				}
			}
			else if (NamedGroup.RefersToASpecificFiniteField(supportedGroup) && crypto.HasDHAgreement())
			{
				agreement = crypto.CreateDHDomain(new TlsDHConfig(supportedGroup, padded: true)).CreateDH();
			}
			if (agreement != null)
			{
				byte[] key_exchange = agreement.GenerateEphemeral();
				KeyShareEntry clientShare = new KeyShareEntry(supportedGroup, key_exchange);
				clientShares.Add(clientShare);
				clientAgreements[supportedGroup] = agreement;
			}
		}
	}

	internal static KeyShareEntry SelectKeyShare(IList clientShares, int keyShareGroup)
	{
		if (clientShares != null && 1 == clientShares.Count)
		{
			KeyShareEntry clientShare = (KeyShareEntry)clientShares[0];
			if (clientShare != null && clientShare.NamedGroup == keyShareGroup)
			{
				return clientShare;
			}
		}
		return null;
	}

	internal static KeyShareEntry SelectKeyShare(TlsCrypto crypto, ProtocolVersion negotiatedVersion, IList clientShares, int[] clientSupportedGroups, int[] serverSupportedGroups)
	{
		if (clientShares != null && !IsNullOrEmpty(clientSupportedGroups) && !IsNullOrEmpty(serverSupportedGroups))
		{
			foreach (KeyShareEntry clientShare in clientShares)
			{
				int group = clientShare.NamedGroup;
				if (NamedGroup.CanBeNegotiated(group, negotiatedVersion) && Arrays.Contains(serverSupportedGroups, group) && Arrays.Contains(clientSupportedGroups, group) && crypto.HasNamedGroup(group) && (!NamedGroup.RefersToASpecificCurve(group) || crypto.HasECDHAgreement()) && (!NamedGroup.RefersToASpecificFiniteField(group) || crypto.HasDHAgreement()))
				{
					return clientShare;
				}
			}
		}
		return null;
	}

	internal static int SelectKeyShareGroup(TlsCrypto crypto, ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, int[] serverSupportedGroups)
	{
		if (!IsNullOrEmpty(clientSupportedGroups) && !IsNullOrEmpty(serverSupportedGroups))
		{
			foreach (int group in clientSupportedGroups)
			{
				if (NamedGroup.CanBeNegotiated(group, negotiatedVersion) && Arrays.Contains(serverSupportedGroups, group) && crypto.HasNamedGroup(group) && (!NamedGroup.RefersToASpecificCurve(group) || crypto.HasECDHAgreement()) && (!NamedGroup.RefersToASpecificFiniteField(group) || crypto.HasDHAgreement()))
				{
					return group;
				}
			}
		}
		return -1;
	}

	internal static byte[] ReadEncryptedPms(TlsContext context, Stream input)
	{
		if (IsSsl(context))
		{
			return Ssl3Utilities.ReadEncryptedPms(input);
		}
		return ReadOpaque16(input);
	}

	internal static void WriteEncryptedPms(TlsContext context, byte[] encryptedPms, Stream output)
	{
		if (IsSsl(context))
		{
			Ssl3Utilities.WriteEncryptedPms(encryptedPms, output);
		}
		else
		{
			WriteOpaque16(encryptedPms, output);
		}
	}

	internal static byte[] GetSessionID(TlsSession tlsSession)
	{
		if (tlsSession != null)
		{
			byte[] sessionID = tlsSession.SessionID;
			if (sessionID != null && sessionID.Length != 0 && sessionID.Length <= 32)
			{
				return sessionID;
			}
		}
		return EmptyBytes;
	}

	internal static void AdjustTranscriptForRetry(TlsHandshakeHash handshakeHash)
	{
		byte[] currentPrfHash = GetCurrentPrfHash(handshakeHash);
		handshakeHash.Reset();
		int length = currentPrfHash.Length;
		CheckUint8(length);
		byte[] synthetic = new byte[4 + length];
		WriteUint8((short)254, synthetic, 0);
		WriteUint24(length, synthetic, 1);
		Array.Copy(currentPrfHash, 0, synthetic, 4, length);
		handshakeHash.Update(synthetic, 0, synthetic.Length);
	}

	internal static TlsCredentials EstablishClientCredentials(TlsAuthentication clientAuthentication, CertificateRequest certificateRequest)
	{
		return ValidateCredentials(clientAuthentication.GetClientCredentials(certificateRequest));
	}

	internal static TlsCredentialedSigner Establish13ClientCredentials(TlsAuthentication clientAuthentication, CertificateRequest certificateRequest)
	{
		return Validate13Credentials(clientAuthentication.GetClientCredentials(certificateRequest));
	}

	internal static void EstablishClientSigAlgs(SecurityParameters securityParameters, IDictionary clientExtensions)
	{
		securityParameters.m_clientSigAlgs = TlsExtensionsUtilities.GetSignatureAlgorithmsExtension(clientExtensions);
		securityParameters.m_clientSigAlgsCert = TlsExtensionsUtilities.GetSignatureAlgorithmsCertExtension(clientExtensions);
	}

	internal static TlsCredentials EstablishServerCredentials(TlsServer server)
	{
		return ValidateCredentials(server.GetCredentials());
	}

	internal static TlsCredentialedSigner Establish13ServerCredentials(TlsServer server)
	{
		return Validate13Credentials(server.GetCredentials());
	}

	internal static void EstablishServerSigAlgs(SecurityParameters securityParameters, CertificateRequest certificateRequest)
	{
		securityParameters.m_clientCertTypes = certificateRequest.CertificateTypes;
		securityParameters.m_serverSigAlgs = certificateRequest.SupportedSignatureAlgorithms;
		securityParameters.m_serverSigAlgsCert = certificateRequest.SupportedSignatureAlgorithmsCert;
		if (securityParameters.ServerSigAlgsCert == null)
		{
			securityParameters.m_serverSigAlgsCert = securityParameters.ServerSigAlgs;
		}
	}

	internal static TlsCredentials ValidateCredentials(TlsCredentials credentials)
	{
		if (credentials != null && 0 + ((credentials is TlsCredentialedAgreement) ? 1 : 0) + ((credentials is TlsCredentialedDecryptor) ? 1 : 0) + ((credentials is TlsCredentialedSigner) ? 1 : 0) != 1)
		{
			throw new TlsFatalAlert(80);
		}
		return credentials;
	}

	internal static TlsCredentialedSigner Validate13Credentials(TlsCredentials credentials)
	{
		if (credentials == null)
		{
			return null;
		}
		if (!(credentials is TlsCredentialedSigner))
		{
			throw new TlsFatalAlert(80);
		}
		return (TlsCredentialedSigner)credentials;
	}

	internal static void NegotiatedCipherSuite(SecurityParameters securityParameters, int cipherSuite)
	{
		securityParameters.m_cipherSuite = cipherSuite;
		securityParameters.m_keyExchangeAlgorithm = GetKeyExchangeAlgorithm(cipherSuite);
		int prfAlgorithm = (securityParameters.m_prfAlgorithm = GetPrfAlgorithm(securityParameters, cipherSuite));
		if ((uint)prfAlgorithm <= 1u)
		{
			securityParameters.m_prfCryptoHashAlgorithm = -1;
			securityParameters.m_prfHashLength = -1;
		}
		else
		{
			securityParameters.m_prfHashLength = TlsCryptoUtilities.GetHashOutputSize(securityParameters.m_prfCryptoHashAlgorithm = TlsCryptoUtilities.GetHashForPrf(prfAlgorithm));
		}
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (IsTlsV13(negotiatedVersion))
		{
			securityParameters.m_verifyDataLength = securityParameters.PrfHashLength;
		}
		else
		{
			securityParameters.m_verifyDataLength = (negotiatedVersion.IsSsl ? 36 : 12);
		}
	}

	internal static void NegotiatedVersion(SecurityParameters securityParameters)
	{
		if (!IsSignatureAlgorithmsExtensionAllowed(securityParameters.NegotiatedVersion))
		{
			securityParameters.m_clientSigAlgs = null;
			securityParameters.m_clientSigAlgsCert = null;
			return;
		}
		if (securityParameters.ClientSigAlgs == null)
		{
			securityParameters.m_clientSigAlgs = GetLegacySupportedSignatureAlgorithms();
		}
		if (securityParameters.ClientSigAlgsCert == null)
		{
			securityParameters.m_clientSigAlgsCert = securityParameters.ClientSigAlgs;
		}
	}

	internal static void NegotiatedVersionDtlsClient(TlsClientContext clientContext, TlsClient client)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (!ProtocolVersion.IsSupportedDtlsVersionClient(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		NegotiatedVersion(securityParameters);
		client.NotifyServerVersion(negotiatedVersion);
	}

	internal static void NegotiatedVersionDtlsServer(TlsServerContext serverContext)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		if (!ProtocolVersion.IsSupportedDtlsVersionServer(securityParameters.NegotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		NegotiatedVersion(securityParameters);
	}

	internal static void NegotiatedVersionTlsClient(TlsClientContext clientContext, TlsClient client)
	{
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (!ProtocolVersion.IsSupportedTlsVersionClient(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		NegotiatedVersion(securityParameters);
		client.NotifyServerVersion(negotiatedVersion);
	}

	internal static void NegotiatedVersionTlsServer(TlsServerContext serverContext)
	{
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		if (!ProtocolVersion.IsSupportedTlsVersionServer(securityParameters.NegotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		NegotiatedVersion(securityParameters);
	}

	internal static TlsSecret DeriveSecret(SecurityParameters securityParameters, TlsSecret secret, string label, byte[] transcriptHash)
	{
		int prfCryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
		int prfHashLength = securityParameters.PrfHashLength;
		return DeriveSecret(prfCryptoHashAlgorithm, prfHashLength, secret, label, transcriptHash);
	}

	internal static TlsSecret DeriveSecret(int prfCryptoHashAlgorithm, int prfHashLength, TlsSecret secret, string label, byte[] transcriptHash)
	{
		if (transcriptHash.Length != prfHashLength)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsCryptoUtilities.HkdfExpandLabel(secret, prfCryptoHashAlgorithm, label, transcriptHash, prfHashLength);
	}

	internal static TlsSecret GetSessionMasterSecret(TlsCrypto crypto, TlsSecret masterSecret)
	{
		if (masterSecret != null)
		{
			lock (masterSecret)
			{
				if (masterSecret.IsAlive())
				{
					return crypto.AdoptSecret(masterSecret);
				}
			}
		}
		return null;
	}

	internal static bool IsPermittedExtensionType13(int handshakeType, int extensionType)
	{
		switch (extensionType)
		{
		case 0:
		case 1:
		case 10:
		case 14:
		case 15:
		case 16:
		case 19:
		case 20:
			if (handshakeType == 1 || handshakeType == 8)
			{
				return true;
			}
			return false;
		case 5:
		case 18:
			if (handshakeType == 1 || handshakeType == 11 || handshakeType == 13)
			{
				return true;
			}
			return false;
		case 13:
		case 47:
		case 50:
			if (handshakeType == 1 || handshakeType == 13)
			{
				return true;
			}
			return false;
		case 21:
		case 45:
		case 49:
			if (handshakeType == 1)
			{
				return true;
			}
			return false;
		case 43:
		case 51:
			if ((uint)(handshakeType - 1) <= 1u || handshakeType == 6)
			{
				return true;
			}
			return false;
		case 41:
			if ((uint)(handshakeType - 1) <= 1u)
			{
				return true;
			}
			return false;
		case 42:
			if (handshakeType == 1 || handshakeType == 4 || handshakeType == 8)
			{
				return true;
			}
			return false;
		case 44:
			if (handshakeType == 1 || handshakeType == 6)
			{
				return true;
			}
			return false;
		case 48:
			if (handshakeType == 13)
			{
				return true;
			}
			return false;
		default:
			return !ExtensionType.IsRecognized(extensionType);
		}
	}

	internal static void CheckExtensionData13(IDictionary extensions, int handshakeType, short alertDescription)
	{
		foreach (int extensionType in extensions.Keys)
		{
			if (!IsPermittedExtensionType13(handshakeType, extensionType))
			{
				throw new TlsFatalAlert(alertDescription, "Invalid extension: " + ExtensionType.GetText(extensionType));
			}
		}
	}

	public static TlsSecret GenerateEncryptedPreMasterSecret(TlsContext context, TlsEncryptor encryptor, Stream output)
	{
		ProtocolVersion version = context.RsaPreMasterSecretVersion;
		TlsSecret tlsSecret = context.Crypto.GenerateRsaPreMasterSecret(version);
		byte[] encryptedPreMasterSecret = tlsSecret.Encrypt(encryptor);
		WriteEncryptedPms(context, encryptedPreMasterSecret, output);
		return tlsSecret;
	}

	public static bool IsTimeout(SocketException e)
	{
		return SocketError.TimedOut == e.SocketErrorCode;
	}

	internal static void AddPreSharedKeyToClientExtensions(TlsPsk[] psks, IDictionary clientExtensions)
	{
		IList identities = Platform.CreateArrayList(psks.Length);
		foreach (TlsPsk psk in psks)
		{
			identities.Add(new PskIdentity(psk.Identity, 0L));
		}
		TlsExtensionsUtilities.AddPreSharedKeyClientHello(clientExtensions, new OfferedPsks(identities));
	}

	internal static OfferedPsks.BindersConfig AddPreSharedKeyToClientHello(TlsClientContext clientContext, TlsClient client, IDictionary clientExtensions, int[] offeredCipherSuites)
	{
		if (!IsTlsV13(clientContext.ClientVersion))
		{
			return null;
		}
		TlsPskExternal[] pskExternals = GetPskExternalsClient(client, offeredCipherSuites);
		if (pskExternals == null)
		{
			return null;
		}
		short[] pskKeyExchangeModes = client.GetPskKeyExchangeModes();
		if (IsNullOrEmpty(pskKeyExchangeModes))
		{
			throw new TlsFatalAlert(80, "External PSKs configured but no PskKeyExchangeMode available");
		}
		TlsCrypto crypto = clientContext.Crypto;
		TlsPsk[] psks = pskExternals;
		TlsSecret[] pskEarlySecrets = GetPskEarlySecrets(crypto, psks);
		psks = pskExternals;
		int bindersSize = OfferedPsks.GetBindersSize(psks);
		psks = pskExternals;
		AddPreSharedKeyToClientExtensions(psks, clientExtensions);
		TlsExtensionsUtilities.AddPskKeyExchangeModesExtension(clientExtensions, pskKeyExchangeModes);
		psks = pskExternals;
		return new OfferedPsks.BindersConfig(psks, pskKeyExchangeModes, pskEarlySecrets, bindersSize);
	}

	internal static OfferedPsks.BindersConfig AddPreSharedKeyToClientHelloRetry(TlsClientContext clientContext, OfferedPsks.BindersConfig clientBinders, IDictionary clientExtensions)
	{
		int prfAlgorithm = GetPrfAlgorithm13(clientContext.SecurityParameters.CipherSuite);
		IList pskIndices = GetPskIndices(clientBinders.m_psks, prfAlgorithm);
		if (pskIndices.Count < 1)
		{
			return null;
		}
		OfferedPsks.BindersConfig result = clientBinders;
		int count = pskIndices.Count;
		if (count < clientBinders.m_psks.Length)
		{
			TlsPsk[] psks = new TlsPsk[count];
			TlsSecret[] earlySecrets = new TlsSecret[count];
			for (int i = 0; i < count; i++)
			{
				int j = (int)pskIndices[i];
				psks[i] = clientBinders.m_psks[j];
				earlySecrets[i] = clientBinders.m_earlySecrets[j];
			}
			int bindersSize = OfferedPsks.GetBindersSize(psks);
			result = new OfferedPsks.BindersConfig(psks, clientBinders.m_pskKeyExchangeModes, earlySecrets, bindersSize);
		}
		AddPreSharedKeyToClientExtensions(result.m_psks, clientExtensions);
		return result;
	}

	internal static OfferedPsks.SelectedConfig SelectPreSharedKey(TlsServerContext serverContext, TlsServer server, IDictionary clientHelloExtensions, HandshakeMessageInput clientHelloMessage, TlsHandshakeHash handshakeHash, bool afterHelloRetryRequest)
	{
		bool handshakeHashUpdated = false;
		OfferedPsks offeredPsks = TlsExtensionsUtilities.GetPreSharedKeyClientHello(clientHelloExtensions);
		if (offeredPsks != null)
		{
			short[] pskKeyExchangeModes = TlsExtensionsUtilities.GetPskKeyExchangeModesExtension(clientHelloExtensions);
			if (IsNullOrEmpty(pskKeyExchangeModes))
			{
				throw new TlsFatalAlert(109);
			}
			if (Arrays.Contains(pskKeyExchangeModes, 1))
			{
				TlsPskExternal psk = server.GetExternalPsk(offeredPsks.Identities);
				if (psk != null)
				{
					int index = offeredPsks.GetIndexOfIdentity(new PskIdentity(psk.Identity, 0L));
					if (index >= 0)
					{
						byte[] binder = (byte[])offeredPsks.Binders[index];
						TlsCrypto crypto = serverContext.Crypto;
						TlsSecret earlySecret = GetPskEarlySecret(crypto, psk);
						bool isExternalPsk = true;
						int pskCryptoHashAlgorithm = TlsCryptoUtilities.GetHashForPrf(psk.PrfAlgorithm);
						handshakeHashUpdated = true;
						int bindersSize = offeredPsks.BindersSize;
						clientHelloMessage.UpdateHashPrefix(handshakeHash, bindersSize);
						byte[] transcriptHash;
						if (afterHelloRetryRequest)
						{
							transcriptHash = handshakeHash.GetFinalHash(pskCryptoHashAlgorithm);
						}
						else
						{
							TlsHash hash = crypto.CreateHash(pskCryptoHashAlgorithm);
							handshakeHash.CopyBufferTo(new TlsHashSink(hash));
							transcriptHash = hash.CalculateHash();
						}
						clientHelloMessage.UpdateHashSuffix(handshakeHash, bindersSize);
						if (Arrays.ConstantTimeAreEqual(CalculatePskBinder(crypto, isExternalPsk, pskCryptoHashAlgorithm, earlySecret, transcriptHash), binder))
						{
							return new OfferedPsks.SelectedConfig(index, psk, pskKeyExchangeModes, earlySecret);
						}
					}
				}
			}
		}
		if (!handshakeHashUpdated)
		{
			clientHelloMessage.UpdateHash(handshakeHash);
		}
		return null;
	}

	internal static TlsSecret GetPskEarlySecret(TlsCrypto crypto, TlsPsk psk)
	{
		int cryptoHashAlgorithm = TlsCryptoUtilities.GetHashForPrf(psk.PrfAlgorithm);
		return crypto.HkdfInit(cryptoHashAlgorithm).HkdfExtract(cryptoHashAlgorithm, psk.Key);
	}

	internal static TlsSecret[] GetPskEarlySecrets(TlsCrypto crypto, TlsPsk[] psks)
	{
		int count = psks.Length;
		TlsSecret[] earlySecrets = new TlsSecret[count];
		for (int i = 0; i < count; i++)
		{
			earlySecrets[i] = GetPskEarlySecret(crypto, psks[i]);
		}
		return earlySecrets;
	}

	internal static TlsPskExternal[] GetPskExternalsClient(TlsClient client, int[] offeredCipherSuites)
	{
		IList externalPsks = client.GetExternalPsks();
		if (IsNullOrEmpty(externalPsks))
		{
			return null;
		}
		int[] prfAlgorithms = GetPrfAlgorithms13(offeredCipherSuites);
		int count = externalPsks.Count;
		TlsPskExternal[] result = new TlsPskExternal[count];
		for (int i = 0; i < count; i++)
		{
			if (!(externalPsks[i] is TlsPskExternal pskExternal))
			{
				throw new TlsFatalAlert(80, "External PSKs element is not a TlsPSKExternal");
			}
			if (!Arrays.Contains(prfAlgorithms, pskExternal.PrfAlgorithm))
			{
				throw new TlsFatalAlert(80, "External PSK incompatible with offered cipher suites");
			}
			result[i] = pskExternal;
		}
		return result;
	}

	internal static IList GetPskIndices(TlsPsk[] psks, int prfAlgorithm)
	{
		IList v = Platform.CreateArrayList(psks.Length);
		for (int i = 0; i < psks.Length; i++)
		{
			if (psks[i].PrfAlgorithm == prfAlgorithm)
			{
				v.Add(i);
			}
		}
		return v;
	}
}
