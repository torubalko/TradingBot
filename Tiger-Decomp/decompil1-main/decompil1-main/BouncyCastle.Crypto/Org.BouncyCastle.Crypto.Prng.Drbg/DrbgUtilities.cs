using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng.Drbg;

internal class DrbgUtilities
{
	private static readonly IDictionary maxSecurityStrengths;

	static DrbgUtilities()
	{
		maxSecurityStrengths = Platform.CreateHashtable();
		maxSecurityStrengths.Add("SHA-1", 128);
		maxSecurityStrengths.Add("SHA-224", 192);
		maxSecurityStrengths.Add("SHA-256", 256);
		maxSecurityStrengths.Add("SHA-384", 256);
		maxSecurityStrengths.Add("SHA-512", 256);
		maxSecurityStrengths.Add("SHA-512/224", 192);
		maxSecurityStrengths.Add("SHA-512/256", 256);
	}

	internal static int GetMaxSecurityStrength(IDigest d)
	{
		return (int)maxSecurityStrengths[d.AlgorithmName];
	}

	internal static int GetMaxSecurityStrength(IMac m)
	{
		string name = m.AlgorithmName;
		return (int)maxSecurityStrengths[name.Substring(0, name.IndexOf("/"))];
	}

	internal static byte[] HashDF(IDigest digest, byte[] seedMaterial, int seedLength)
	{
		byte[] temp = new byte[(seedLength + 7) / 8];
		int len = temp.Length / digest.GetDigestSize();
		int counter = 1;
		byte[] dig = new byte[digest.GetDigestSize()];
		for (int i = 0; i <= len; i++)
		{
			digest.Update((byte)counter);
			digest.Update((byte)(seedLength >> 24));
			digest.Update((byte)(seedLength >> 16));
			digest.Update((byte)(seedLength >> 8));
			digest.Update((byte)seedLength);
			digest.BlockUpdate(seedMaterial, 0, seedMaterial.Length);
			digest.DoFinal(dig, 0);
			int bytesToCopy = ((temp.Length - i * dig.Length > dig.Length) ? dig.Length : (temp.Length - i * dig.Length));
			Array.Copy(dig, 0, temp, i * dig.Length, bytesToCopy);
			counter++;
		}
		if (seedLength % 8 != 0)
		{
			int shift = 8 - seedLength % 8;
			uint carry = 0u;
			for (int j = 0; j != temp.Length; j++)
			{
				uint b = temp[j];
				temp[j] = (byte)((b >> shift) | (carry << 8 - shift));
				carry = b;
			}
		}
		return temp;
	}

	internal static bool IsTooLarge(byte[] bytes, int maxBytes)
	{
		if (bytes != null)
		{
			return bytes.Length > maxBytes;
		}
		return false;
	}
}
