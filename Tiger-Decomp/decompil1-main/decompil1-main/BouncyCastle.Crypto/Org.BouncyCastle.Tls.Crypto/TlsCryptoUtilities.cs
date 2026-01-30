using System;

namespace Org.BouncyCastle.Tls.Crypto;

public abstract class TlsCryptoUtilities
{
	private static readonly byte[] Tls13Prefix = new byte[6] { 116, 108, 115, 49, 51, 32 };

	public static int GetHash(short hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			1 => 1, 
			2 => 2, 
			3 => 3, 
			4 => 4, 
			5 => 5, 
			6 => 6, 
			_ => throw new ArgumentException("specified HashAlgorithm invalid: " + HashAlgorithm.GetText(hashAlgorithm)), 
		};
	}

	public static int GetHashForHmac(int macAlgorithm)
	{
		return macAlgorithm switch
		{
			1 => 1, 
			2 => 2, 
			3 => 4, 
			4 => 5, 
			5 => 6, 
			_ => throw new ArgumentException("specified MacAlgorithm not an HMAC: " + MacAlgorithm.GetText(macAlgorithm)), 
		};
	}

	public static int GetHashForPrf(int prfAlgorithm)
	{
		switch (prfAlgorithm)
		{
		case 0:
		case 1:
			throw new ArgumentException("legacy PRF not a valid algorithm");
		case 2:
		case 4:
			return 4;
		case 3:
		case 5:
			return 5;
		case 7:
			return 7;
		default:
			throw new ArgumentException("unknown PrfAlgorithm: " + PrfAlgorithm.GetText(prfAlgorithm));
		}
	}

	public static int GetHashOutputSize(int cryptoHashAlgorithm)
	{
		switch (cryptoHashAlgorithm)
		{
		case 1:
			return 16;
		case 2:
			return 20;
		case 3:
			return 28;
		case 4:
		case 7:
			return 32;
		case 5:
			return 48;
		case 6:
			return 64;
		default:
			throw new ArgumentException();
		}
	}

	public static int GetSignature(short signatureAlgorithm)
	{
		return signatureAlgorithm switch
		{
			1 => 1, 
			2 => 2, 
			3 => 3, 
			4 => 4, 
			5 => 5, 
			6 => 6, 
			7 => 7, 
			8 => 8, 
			9 => 9, 
			10 => 10, 
			11 => 11, 
			64 => 64, 
			65 => 65, 
			_ => throw new ArgumentException("specified SignatureAlgorithm invalid: " + SignatureAlgorithm.GetText(signatureAlgorithm)), 
		};
	}

	public static TlsSecret HkdfExpandLabel(TlsSecret secret, int cryptoHashAlgorithm, string label, byte[] context, int length)
	{
		int labelLength = label.Length;
		if (labelLength < 1)
		{
			throw new TlsFatalAlert(80);
		}
		int contextLength = context.Length;
		int expandedLabelLength = Tls13Prefix.Length + labelLength;
		byte[] hkdfLabel = new byte[2 + (1 + expandedLabelLength) + (1 + contextLength)];
		TlsUtilities.CheckUint16(length);
		TlsUtilities.WriteUint16(length, hkdfLabel, 0);
		TlsUtilities.CheckUint8(expandedLabelLength);
		TlsUtilities.WriteUint8(expandedLabelLength, hkdfLabel, 2);
		Array.Copy(Tls13Prefix, 0, hkdfLabel, 3, Tls13Prefix.Length);
		int labelPos = 2 + (1 + Tls13Prefix.Length);
		for (int i = 0; i < labelLength; i++)
		{
			char c = label[i];
			hkdfLabel[labelPos + i] = (byte)c;
		}
		TlsUtilities.WriteOpaque8(context, hkdfLabel, 2 + (1 + expandedLabelLength));
		return secret.HkdfExpand(cryptoHashAlgorithm, hkdfLabel, length);
	}
}
