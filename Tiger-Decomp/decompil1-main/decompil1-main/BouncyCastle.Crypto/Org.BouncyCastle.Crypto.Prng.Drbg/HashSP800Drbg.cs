using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng.Drbg;

public class HashSP800Drbg : ISP80090Drbg
{
	private static readonly byte[] ONE;

	private static readonly long RESEED_MAX;

	private static readonly int MAX_BITS_REQUEST;

	private static readonly IDictionary seedlens;

	private readonly IDigest mDigest;

	private readonly IEntropySource mEntropySource;

	private readonly int mSecurityStrength;

	private readonly int mSeedLength;

	private byte[] mV;

	private byte[] mC;

	private long mReseedCounter;

	public int BlockSize => mDigest.GetDigestSize() * 8;

	static HashSP800Drbg()
	{
		ONE = new byte[1] { 1 };
		RESEED_MAX = 140737488355328L;
		MAX_BITS_REQUEST = 262144;
		seedlens = Platform.CreateHashtable();
		seedlens.Add("SHA-1", 440);
		seedlens.Add("SHA-224", 440);
		seedlens.Add("SHA-256", 440);
		seedlens.Add("SHA-512/256", 440);
		seedlens.Add("SHA-512/224", 440);
		seedlens.Add("SHA-384", 888);
		seedlens.Add("SHA-512", 888);
	}

	public HashSP800Drbg(IDigest digest, int securityStrength, IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
	{
		if (securityStrength > DrbgUtilities.GetMaxSecurityStrength(digest))
		{
			throw new ArgumentException("Requested security strength is not supported by the derivation function");
		}
		if (entropySource.EntropySize < securityStrength)
		{
			throw new ArgumentException("Not enough entropy for security strength required");
		}
		mDigest = digest;
		mEntropySource = entropySource;
		mSecurityStrength = securityStrength;
		mSeedLength = (int)seedlens[digest.AlgorithmName];
		byte[] entropy = GetEntropy();
		byte[] seedMaterial = Arrays.ConcatenateAll(entropy, nonce, personalizationString);
		byte[] seed = DrbgUtilities.HashDF(mDigest, seedMaterial, mSeedLength);
		mV = seed;
		byte[] subV = new byte[mV.Length + 1];
		Array.Copy(mV, 0, subV, 1, mV.Length);
		mC = DrbgUtilities.HashDF(mDigest, subV, mSeedLength);
		mReseedCounter = 1L;
	}

	public int Generate(byte[] output, byte[] additionalInput, bool predictionResistant)
	{
		int numberOfBits = output.Length * 8;
		if (numberOfBits > MAX_BITS_REQUEST)
		{
			throw new ArgumentException("Number of bits per request limited to " + MAX_BITS_REQUEST, "output");
		}
		if (mReseedCounter > RESEED_MAX)
		{
			return -1;
		}
		if (predictionResistant)
		{
			Reseed(additionalInput);
			additionalInput = null;
		}
		if (additionalInput != null)
		{
			byte[] newInput = new byte[1 + mV.Length + additionalInput.Length];
			newInput[0] = 2;
			Array.Copy(mV, 0, newInput, 1, mV.Length);
			Array.Copy(additionalInput, 0, newInput, 1 + mV.Length, additionalInput.Length);
			byte[] w = Hash(newInput);
			AddTo(mV, w);
		}
		byte[] sourceArray = hashgen(mV, numberOfBits);
		byte[] subH = new byte[mV.Length + 1];
		Array.Copy(mV, 0, subH, 1, mV.Length);
		subH[0] = 3;
		AddTo(shorter: Hash(subH), longer: mV);
		AddTo(mV, mC);
		AddTo(shorter: new byte[4]
		{
			(byte)(mReseedCounter >> 24),
			(byte)(mReseedCounter >> 16),
			(byte)(mReseedCounter >> 8),
			(byte)mReseedCounter
		}, longer: mV);
		mReseedCounter++;
		Array.Copy(sourceArray, 0, output, 0, output.Length);
		return numberOfBits;
	}

	private byte[] GetEntropy()
	{
		byte[] entropy = mEntropySource.GetEntropy();
		if (entropy.Length < (mSecurityStrength + 7) / 8)
		{
			throw new InvalidOperationException("Insufficient entropy provided by entropy source");
		}
		return entropy;
	}

	private void AddTo(byte[] longer, byte[] shorter)
	{
		int off = longer.Length - shorter.Length;
		uint carry = 0u;
		int i = shorter.Length;
		while (--i >= 0)
		{
			carry += (uint)(longer[off + i] + shorter[i]);
			longer[off + i] = (byte)carry;
			carry >>= 8;
		}
		i = off;
		while (--i >= 0)
		{
			carry += longer[i];
			longer[i] = (byte)carry;
			carry >>= 8;
		}
	}

	public void Reseed(byte[] additionalInput)
	{
		byte[] entropy = GetEntropy();
		byte[] seedMaterial = Arrays.ConcatenateAll(ONE, mV, entropy, additionalInput);
		byte[] seed = DrbgUtilities.HashDF(mDigest, seedMaterial, mSeedLength);
		mV = seed;
		byte[] subV = new byte[mV.Length + 1];
		subV[0] = 0;
		Array.Copy(mV, 0, subV, 1, mV.Length);
		mC = DrbgUtilities.HashDF(mDigest, subV, mSeedLength);
		mReseedCounter = 1L;
	}

	private byte[] Hash(byte[] input)
	{
		byte[] hash = new byte[mDigest.GetDigestSize()];
		DoHash(input, hash);
		return hash;
	}

	private void DoHash(byte[] input, byte[] output)
	{
		mDigest.BlockUpdate(input, 0, input.Length);
		mDigest.DoFinal(output, 0);
	}

	private byte[] hashgen(byte[] input, int lengthInBits)
	{
		int digestSize = mDigest.GetDigestSize();
		int m = lengthInBits / 8 / digestSize;
		byte[] data = new byte[input.Length];
		Array.Copy(input, 0, data, 0, input.Length);
		byte[] W = new byte[lengthInBits / 8];
		byte[] dig = new byte[mDigest.GetDigestSize()];
		for (int i = 0; i <= m; i++)
		{
			DoHash(data, dig);
			int bytesToCopy = ((W.Length - i * dig.Length > dig.Length) ? dig.Length : (W.Length - i * dig.Length));
			Array.Copy(dig, 0, W, i * dig.Length, bytesToCopy);
			AddTo(data, ONE);
		}
		return W;
	}
}
