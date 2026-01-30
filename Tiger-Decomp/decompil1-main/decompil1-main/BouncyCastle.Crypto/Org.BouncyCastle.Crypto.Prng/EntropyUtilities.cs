using System;

namespace Org.BouncyCastle.Crypto.Prng;

public abstract class EntropyUtilities
{
	public static byte[] GenerateSeed(IEntropySource entropySource, int numBytes)
	{
		byte[] bytes = new byte[numBytes];
		int toCopy;
		for (int count = 0; count < numBytes; count += toCopy)
		{
			byte[] entropy = entropySource.GetEntropy();
			toCopy = System.Math.Min(bytes.Length, numBytes - count);
			Array.Copy(entropy, 0, bytes, count, toCopy);
		}
		return bytes;
	}
}
