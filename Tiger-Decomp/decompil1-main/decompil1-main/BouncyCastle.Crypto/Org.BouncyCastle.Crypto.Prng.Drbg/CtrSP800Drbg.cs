using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Prng.Drbg;

public class CtrSP800Drbg : ISP80090Drbg
{
	private static readonly long TDEA_RESEED_MAX = 2147483648L;

	private static readonly long AES_RESEED_MAX = 140737488355328L;

	private static readonly int TDEA_MAX_BITS_REQUEST = 4096;

	private static readonly int AES_MAX_BITS_REQUEST = 262144;

	private readonly IEntropySource mEntropySource;

	private readonly IBlockCipher mEngine;

	private readonly int mKeySizeInBits;

	private readonly int mSeedLength;

	private readonly int mSecurityStrength;

	private byte[] mKey;

	private byte[] mV;

	private long mReseedCounter;

	private bool mIsTdea;

	private static readonly byte[] K_BITS = Hex.DecodeStrict("000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F");

	public int BlockSize => mV.Length * 8;

	public CtrSP800Drbg(IBlockCipher engine, int keySizeInBits, int securityStrength, IEntropySource entropySource, byte[] personalizationString, byte[] nonce)
	{
		if (securityStrength > 256)
		{
			throw new ArgumentException("Requested security strength is not supported by the derivation function");
		}
		if (GetMaxSecurityStrength(engine, keySizeInBits) < securityStrength)
		{
			throw new ArgumentException("Requested security strength is not supported by block cipher and key size");
		}
		if (entropySource.EntropySize < securityStrength)
		{
			throw new ArgumentException("Not enough entropy for security strength required");
		}
		mEntropySource = entropySource;
		mEngine = engine;
		mKeySizeInBits = keySizeInBits;
		mSecurityStrength = securityStrength;
		mSeedLength = keySizeInBits + engine.GetBlockSize() * 8;
		mIsTdea = IsTdea(engine);
		byte[] entropy = GetEntropy();
		CTR_DRBG_Instantiate_algorithm(entropy, nonce, personalizationString);
	}

	private void CTR_DRBG_Instantiate_algorithm(byte[] entropy, byte[] nonce, byte[] personalisationString)
	{
		byte[] seedMaterial = Arrays.ConcatenateAll(entropy, nonce, personalisationString);
		byte[] seed = Block_Cipher_df(seedMaterial, mSeedLength);
		int outlen = mEngine.GetBlockSize();
		mKey = new byte[(mKeySizeInBits + 7) / 8];
		mV = new byte[outlen];
		CTR_DRBG_Update(seed, mKey, mV);
		mReseedCounter = 1L;
	}

	private void CTR_DRBG_Update(byte[] seed, byte[] key, byte[] v)
	{
		byte[] temp = new byte[seed.Length];
		byte[] outputBlock = new byte[mEngine.GetBlockSize()];
		int i = 0;
		int outLen = mEngine.GetBlockSize();
		mEngine.Init(forEncryption: true, new KeyParameter(ExpandKey(key)));
		for (; i * outLen < seed.Length; i++)
		{
			AddOneTo(v);
			mEngine.ProcessBlock(v, 0, outputBlock, 0);
			int bytesToCopy = ((temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen));
			Array.Copy(outputBlock, 0, temp, i * outLen, bytesToCopy);
		}
		XOR(temp, seed, temp, 0);
		Array.Copy(temp, 0, key, 0, key.Length);
		Array.Copy(temp, key.Length, v, 0, v.Length);
	}

	private void CTR_DRBG_Reseed_algorithm(byte[] additionalInput)
	{
		byte[] seedMaterial = Arrays.Concatenate(GetEntropy(), additionalInput);
		seedMaterial = Block_Cipher_df(seedMaterial, mSeedLength);
		CTR_DRBG_Update(seedMaterial, mKey, mV);
		mReseedCounter = 1L;
	}

	private void XOR(byte[] output, byte[] a, byte[] b, int bOff)
	{
		for (int i = 0; i < output.Length; i++)
		{
			output[i] = (byte)(a[i] ^ b[bOff + i]);
		}
	}

	private void AddOneTo(byte[] longer)
	{
		uint carry = 1u;
		int i = longer.Length;
		while (--i >= 0)
		{
			carry += longer[i];
			longer[i] = (byte)carry;
			carry >>= 8;
		}
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

	private byte[] Block_Cipher_df(byte[] inputString, int bitLength)
	{
		int outLen = mEngine.GetBlockSize();
		int L = inputString.Length;
		int N = bitLength / 8;
		byte[] S = new byte[(8 + L + 1 + outLen - 1) / outLen * outLen];
		copyIntToByteArray(S, L, 0);
		copyIntToByteArray(S, N, 4);
		Array.Copy(inputString, 0, S, 8, L);
		S[8 + L] = 128;
		byte[] temp = new byte[mKeySizeInBits / 8 + outLen];
		byte[] bccOut = new byte[outLen];
		byte[] IV = new byte[outLen];
		int i = 0;
		byte[] K = new byte[mKeySizeInBits / 8];
		Array.Copy(K_BITS, 0, K, 0, K.Length);
		for (; i * outLen * 8 < mKeySizeInBits + outLen * 8; i++)
		{
			copyIntToByteArray(IV, i, 0);
			BCC(bccOut, K, IV, S);
			int bytesToCopy = ((temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen));
			Array.Copy(bccOut, 0, temp, i * outLen, bytesToCopy);
		}
		byte[] X = new byte[outLen];
		Array.Copy(temp, 0, K, 0, K.Length);
		Array.Copy(temp, K.Length, X, 0, X.Length);
		temp = new byte[bitLength / 2];
		i = 0;
		mEngine.Init(forEncryption: true, new KeyParameter(ExpandKey(K)));
		for (; i * outLen < temp.Length; i++)
		{
			mEngine.ProcessBlock(X, 0, X, 0);
			int bytesToCopy2 = ((temp.Length - i * outLen > outLen) ? outLen : (temp.Length - i * outLen));
			Array.Copy(X, 0, temp, i * outLen, bytesToCopy2);
		}
		return temp;
	}

	private void BCC(byte[] bccOut, byte[] k, byte[] iV, byte[] data)
	{
		int outlen = mEngine.GetBlockSize();
		byte[] chainingValue = new byte[outlen];
		int n = data.Length / outlen;
		byte[] inputBlock = new byte[outlen];
		mEngine.Init(forEncryption: true, new KeyParameter(ExpandKey(k)));
		mEngine.ProcessBlock(iV, 0, chainingValue, 0);
		for (int i = 0; i < n; i++)
		{
			XOR(inputBlock, chainingValue, data, i * outlen);
			mEngine.ProcessBlock(inputBlock, 0, chainingValue, 0);
		}
		Array.Copy(chainingValue, 0, bccOut, 0, bccOut.Length);
	}

	private void copyIntToByteArray(byte[] buf, int value, int offSet)
	{
		buf[offSet] = (byte)(value >> 24);
		buf[offSet + 1] = (byte)(value >> 16);
		buf[offSet + 2] = (byte)(value >> 8);
		buf[offSet + 3] = (byte)value;
	}

	public int Generate(byte[] output, byte[] additionalInput, bool predictionResistant)
	{
		if (mIsTdea)
		{
			if (mReseedCounter > TDEA_RESEED_MAX)
			{
				return -1;
			}
			if (DrbgUtilities.IsTooLarge(output, TDEA_MAX_BITS_REQUEST / 8))
			{
				throw new ArgumentException("Number of bits per request limited to " + TDEA_MAX_BITS_REQUEST, "output");
			}
		}
		else
		{
			if (mReseedCounter > AES_RESEED_MAX)
			{
				return -1;
			}
			if (DrbgUtilities.IsTooLarge(output, AES_MAX_BITS_REQUEST / 8))
			{
				throw new ArgumentException("Number of bits per request limited to " + AES_MAX_BITS_REQUEST, "output");
			}
		}
		if (predictionResistant)
		{
			CTR_DRBG_Reseed_algorithm(additionalInput);
			additionalInput = null;
		}
		if (additionalInput != null)
		{
			additionalInput = Block_Cipher_df(additionalInput, mSeedLength);
			CTR_DRBG_Update(additionalInput, mKey, mV);
		}
		else
		{
			additionalInput = new byte[mSeedLength];
		}
		byte[] tmp = new byte[mV.Length];
		mEngine.Init(forEncryption: true, new KeyParameter(ExpandKey(mKey)));
		for (int i = 0; i <= output.Length / tmp.Length; i++)
		{
			int bytesToCopy = ((output.Length - i * tmp.Length > tmp.Length) ? tmp.Length : (output.Length - i * mV.Length));
			if (bytesToCopy != 0)
			{
				AddOneTo(mV);
				mEngine.ProcessBlock(mV, 0, tmp, 0);
				Array.Copy(tmp, 0, output, i * tmp.Length, bytesToCopy);
			}
		}
		CTR_DRBG_Update(additionalInput, mKey, mV);
		mReseedCounter++;
		return output.Length * 8;
	}

	public void Reseed(byte[] additionalInput)
	{
		CTR_DRBG_Reseed_algorithm(additionalInput);
	}

	private bool IsTdea(IBlockCipher cipher)
	{
		if (!cipher.AlgorithmName.Equals("DESede"))
		{
			return cipher.AlgorithmName.Equals("TDEA");
		}
		return true;
	}

	private int GetMaxSecurityStrength(IBlockCipher cipher, int keySizeInBits)
	{
		if (IsTdea(cipher) && keySizeInBits == 168)
		{
			return 112;
		}
		if (cipher.AlgorithmName.Equals("AES"))
		{
			return keySizeInBits;
		}
		return -1;
	}

	private byte[] ExpandKey(byte[] key)
	{
		if (mIsTdea)
		{
			byte[] tmp = new byte[24];
			PadKey(key, 0, tmp, 0);
			PadKey(key, 7, tmp, 8);
			PadKey(key, 14, tmp, 16);
			return tmp;
		}
		return key;
	}

	private void PadKey(byte[] keyMaster, int keyOff, byte[] tmp, int tmpOff)
	{
		tmp[tmpOff] = (byte)(keyMaster[keyOff] & 0xFE);
		tmp[tmpOff + 1] = (byte)((keyMaster[keyOff] << 7) | ((keyMaster[keyOff + 1] & 0xFC) >> 1));
		tmp[tmpOff + 2] = (byte)((keyMaster[keyOff + 1] << 6) | ((keyMaster[keyOff + 2] & 0xF8) >> 2));
		tmp[tmpOff + 3] = (byte)((keyMaster[keyOff + 2] << 5) | ((keyMaster[keyOff + 3] & 0xF0) >> 3));
		tmp[tmpOff + 4] = (byte)((keyMaster[keyOff + 3] << 4) | ((keyMaster[keyOff + 4] & 0xE0) >> 4));
		tmp[tmpOff + 5] = (byte)((keyMaster[keyOff + 4] << 3) | ((keyMaster[keyOff + 5] & 0xC0) >> 5));
		tmp[tmpOff + 6] = (byte)((keyMaster[keyOff + 5] << 2) | ((keyMaster[keyOff + 6] & 0x80) >> 6));
		tmp[tmpOff + 7] = (byte)(keyMaster[keyOff + 6] << 1);
		DesParameters.SetOddParity(tmp, tmpOff, 8);
	}
}
