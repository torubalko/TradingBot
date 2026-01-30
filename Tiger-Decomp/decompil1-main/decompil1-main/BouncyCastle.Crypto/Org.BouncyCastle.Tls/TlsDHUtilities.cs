using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsDHUtilities
{
	public static TlsDHConfig CreateNamedDHConfig(TlsContext context, int namedGroup)
	{
		if (namedGroup < 0 || NamedGroup.GetFiniteFieldBits(namedGroup) < 1)
		{
			return null;
		}
		bool padded = TlsUtilities.IsTlsV13(context);
		return new TlsDHConfig(namedGroup, padded);
	}

	public static DHGroup GetDHGroup(TlsDHConfig dhConfig)
	{
		int namedGroup = dhConfig.NamedGroup;
		if (namedGroup >= 0)
		{
			return GetNamedDHGroup(namedGroup);
		}
		return dhConfig.ExplicitGroup;
	}

	public static DHGroup GetNamedDHGroup(int namedGroup)
	{
		return namedGroup switch
		{
			256 => DHStandardGroups.rfc7919_ffdhe2048, 
			257 => DHStandardGroups.rfc7919_ffdhe3072, 
			258 => DHStandardGroups.rfc7919_ffdhe4096, 
			259 => DHStandardGroups.rfc7919_ffdhe6144, 
			260 => DHStandardGroups.rfc7919_ffdhe8192, 
			_ => null, 
		};
	}

	public static int GetMinimumFiniteFieldBits(int cipherSuite)
	{
		if (!IsDHCipherSuite(cipherSuite))
		{
			return 0;
		}
		return 1;
	}

	public static bool IsDHCipherSuite(int cipherSuite)
	{
		switch (TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite))
		{
		case 3:
		case 5:
		case 7:
		case 9:
		case 11:
		case 14:
			return true;
		default:
			return false;
		}
	}

	public static int GetNamedGroupForDHParameters(BigInteger p, BigInteger g)
	{
		int[] namedGroups = new int[5] { 256, 257, 258, 259, 260 };
		foreach (int namedGroup in namedGroups)
		{
			DHGroup dhGroup = GetNamedDHGroup(namedGroup);
			if (dhGroup != null && dhGroup.P.Equals(p) && dhGroup.G.Equals(g))
			{
				return namedGroup;
			}
		}
		return -1;
	}

	public static DHGroup GetStandardGroupForDHParameters(BigInteger p, BigInteger g)
	{
		DHGroup[] standardGroups = new DHGroup[13]
		{
			DHStandardGroups.rfc7919_ffdhe2048,
			DHStandardGroups.rfc7919_ffdhe3072,
			DHStandardGroups.rfc7919_ffdhe4096,
			DHStandardGroups.rfc7919_ffdhe6144,
			DHStandardGroups.rfc7919_ffdhe8192,
			DHStandardGroups.rfc3526_1536,
			DHStandardGroups.rfc3526_2048,
			DHStandardGroups.rfc3526_3072,
			DHStandardGroups.rfc3526_4096,
			DHStandardGroups.rfc3526_6144,
			DHStandardGroups.rfc3526_8192,
			DHStandardGroups.rfc5996_768,
			DHStandardGroups.rfc5996_1024
		};
		foreach (DHGroup dhGroup in standardGroups)
		{
			if (dhGroup != null && dhGroup.P.Equals(p) && dhGroup.G.Equals(g))
			{
				return dhGroup;
			}
		}
		return null;
	}

	public static TlsDHConfig ReceiveDHConfig(TlsContext context, TlsDHGroupVerifier dhGroupVerifier, Stream input)
	{
		BigInteger p = ReadDHParameter(input);
		BigInteger g = ReadDHParameter(input);
		int namedGroup = GetNamedGroupForDHParameters(p, g);
		if (namedGroup < 0)
		{
			DHGroup dhGroup = GetStandardGroupForDHParameters(p, g);
			if (dhGroup == null)
			{
				dhGroup = new DHGroup(p, null, g, 0);
			}
			if (!dhGroupVerifier.Accept(dhGroup))
			{
				throw new TlsFatalAlert(71);
			}
			return new TlsDHConfig(dhGroup);
		}
		int[] clientSupportedGroups = context.SecurityParameters.ClientSupportedGroups;
		if (clientSupportedGroups == null || Arrays.Contains(clientSupportedGroups, namedGroup))
		{
			return new TlsDHConfig(namedGroup, padded: false);
		}
		throw new TlsFatalAlert(47);
	}

	public static BigInteger ReadDHParameter(Stream input)
	{
		return new BigInteger(1, TlsUtilities.ReadOpaque16(input, 1));
	}

	public static void WriteDHConfig(TlsDHConfig dhConfig, Stream output)
	{
		DHGroup dHGroup = GetDHGroup(dhConfig);
		WriteDHParameter(dHGroup.P, output);
		WriteDHParameter(dHGroup.G, output);
	}

	public static void WriteDHParameter(BigInteger x, Stream output)
	{
		TlsUtilities.WriteOpaque16(BigIntegers.AsUnsignedByteArray(x), output);
	}
}
