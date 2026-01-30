using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class KeccakDigest : IDigest, IMemoable
{
	private static readonly ulong[] KeccakRoundConstants = new ulong[24]
	{
		1uL, 32898uL, 9223372036854808714uL, 9223372039002292224uL, 32907uL, 2147483649uL, 9223372039002292353uL, 9223372036854808585uL, 138uL, 136uL,
		2147516425uL, 2147483658uL, 2147516555uL, 9223372036854775947uL, 9223372036854808713uL, 9223372036854808579uL, 9223372036854808578uL, 9223372036854775936uL, 32778uL, 9223372039002259466uL,
		9223372039002292353uL, 9223372036854808704uL, 2147483649uL, 9223372039002292232uL
	};

	private ulong[] state = new ulong[25];

	protected byte[] dataQueue = new byte[192];

	protected int rate;

	protected int bitsInQueue;

	protected internal int fixedOutputLength;

	protected bool squeezing;

	public virtual string AlgorithmName => "Keccak-" + fixedOutputLength;

	public KeccakDigest()
		: this(288)
	{
	}

	public KeccakDigest(int bitLength)
	{
		Init(bitLength);
	}

	public KeccakDigest(KeccakDigest source)
	{
		CopyIn(source);
	}

	private void CopyIn(KeccakDigest source)
	{
		Array.Copy(source.state, 0, state, 0, source.state.Length);
		Array.Copy(source.dataQueue, 0, dataQueue, 0, source.dataQueue.Length);
		rate = source.rate;
		bitsInQueue = source.bitsInQueue;
		fixedOutputLength = source.fixedOutputLength;
		squeezing = source.squeezing;
	}

	public virtual int GetDigestSize()
	{
		return fixedOutputLength >> 3;
	}

	public virtual void Update(byte input)
	{
		Absorb(input);
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int len)
	{
		Absorb(input, inOff, len);
	}

	public virtual int DoFinal(byte[] output, int outOff)
	{
		Squeeze(output, outOff, fixedOutputLength);
		Reset();
		return GetDigestSize();
	}

	protected virtual int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
	{
		if (partialBits > 0)
		{
			AbsorbBits(partialByte, partialBits);
		}
		Squeeze(output, outOff, fixedOutputLength);
		Reset();
		return GetDigestSize();
	}

	public virtual void Reset()
	{
		Init(fixedOutputLength);
	}

	public virtual int GetByteLength()
	{
		return rate >> 3;
	}

	private void Init(int bitLength)
	{
		switch (bitLength)
		{
		case 128:
		case 224:
		case 256:
		case 288:
		case 384:
		case 512:
			InitSponge(1600 - (bitLength << 1));
			break;
		default:
			throw new ArgumentException("must be one of 128, 224, 256, 288, 384, or 512.", "bitLength");
		}
	}

	private void InitSponge(int rate)
	{
		if (rate <= 0 || rate >= 1600 || (rate & 0x3F) != 0)
		{
			throw new InvalidOperationException("invalid rate value");
		}
		this.rate = rate;
		Array.Clear(state, 0, state.Length);
		Arrays.Fill(dataQueue, 0);
		bitsInQueue = 0;
		squeezing = false;
		fixedOutputLength = 1600 - rate >> 1;
	}

	protected void Absorb(byte data)
	{
		if ((bitsInQueue & 7) != 0)
		{
			throw new InvalidOperationException("attempt to absorb with odd length queue");
		}
		if (squeezing)
		{
			throw new InvalidOperationException("attempt to absorb while squeezing");
		}
		dataQueue[bitsInQueue >> 3] = data;
		if ((bitsInQueue += 8) == rate)
		{
			KeccakAbsorb(dataQueue, 0);
			bitsInQueue = 0;
		}
	}

	protected void Absorb(byte[] data, int off, int len)
	{
		if ((bitsInQueue & 7) != 0)
		{
			throw new InvalidOperationException("attempt to absorb with odd length queue");
		}
		if (squeezing)
		{
			throw new InvalidOperationException("attempt to absorb while squeezing");
		}
		int bytesInQueue = bitsInQueue >> 3;
		int rateBytes = rate >> 3;
		int available = rateBytes - bytesInQueue;
		if (len < available)
		{
			Array.Copy(data, off, dataQueue, bytesInQueue, len);
			bitsInQueue += len << 3;
			return;
		}
		int count = 0;
		if (bytesInQueue > 0)
		{
			Array.Copy(data, off, dataQueue, bytesInQueue, available);
			count += available;
			KeccakAbsorb(dataQueue, 0);
		}
		int remaining;
		while ((remaining = len - count) >= rateBytes)
		{
			KeccakAbsorb(data, off + count);
			count += rateBytes;
		}
		Array.Copy(data, off + count, dataQueue, 0, remaining);
		bitsInQueue = remaining << 3;
	}

	protected void AbsorbBits(int data, int bits)
	{
		if (bits < 1 || bits > 7)
		{
			throw new ArgumentException("must be in the range 1 to 7", "bits");
		}
		if ((bitsInQueue & 7) != 0)
		{
			throw new InvalidOperationException("attempt to absorb with odd length queue");
		}
		if (squeezing)
		{
			throw new InvalidOperationException("attempt to absorb while squeezing");
		}
		int mask = (1 << bits) - 1;
		dataQueue[bitsInQueue >> 3] = (byte)(data & mask);
		bitsInQueue += bits;
	}

	private void PadAndSwitchToSqueezingPhase()
	{
		dataQueue[bitsInQueue >> 3] |= (byte)(1 << (bitsInQueue & 7));
		if (++bitsInQueue == rate)
		{
			KeccakAbsorb(dataQueue, 0);
		}
		else
		{
			int full = bitsInQueue >> 6;
			int partial = bitsInQueue & 0x3F;
			int off = 0;
			for (int i = 0; i < full; i++)
			{
				state[i] ^= Pack.LE_To_UInt64(dataQueue, off);
				off += 8;
			}
			if (partial > 0)
			{
				ulong mask = (ulong)((1L << partial) - 1);
				state[full] ^= Pack.LE_To_UInt64(dataQueue, off) & mask;
			}
		}
		state[rate - 1 >> 6] ^= 9223372036854775808uL;
		bitsInQueue = 0;
		squeezing = true;
	}

	protected void Squeeze(byte[] output, int offset, long outputLength)
	{
		if (!squeezing)
		{
			PadAndSwitchToSqueezingPhase();
		}
		if ((outputLength & 7) != 0L)
		{
			throw new InvalidOperationException("outputLength not a multiple of 8");
		}
		int partialBlock;
		for (long i = 0L; i < outputLength; i += partialBlock)
		{
			if (bitsInQueue == 0)
			{
				KeccakExtract();
			}
			partialBlock = (int)System.Math.Min(bitsInQueue, outputLength - i);
			Array.Copy(dataQueue, rate - bitsInQueue >> 3, output, offset + (int)(i >> 3), partialBlock >> 3);
			bitsInQueue -= partialBlock;
		}
	}

	private void KeccakAbsorb(byte[] data, int off)
	{
		int count = rate >> 6;
		for (int i = 0; i < count; i++)
		{
			state[i] ^= Pack.LE_To_UInt64(data, off);
			off += 8;
		}
		KeccakPermutation();
	}

	private void KeccakExtract()
	{
		KeccakPermutation();
		Pack.UInt64_To_LE(state, 0, rate >> 6, dataQueue, 0);
		bitsInQueue = rate;
	}

	private void KeccakPermutation()
	{
		ulong[] A = state;
		ulong a00 = A[0];
		ulong a1 = A[1];
		ulong a2 = A[2];
		ulong a3 = A[3];
		ulong a4 = A[4];
		ulong a5 = A[5];
		ulong a6 = A[6];
		ulong a7 = A[7];
		ulong a8 = A[8];
		ulong a9 = A[9];
		ulong a10 = A[10];
		ulong a11 = A[11];
		ulong a12 = A[12];
		ulong a13 = A[13];
		ulong a14 = A[14];
		ulong a15 = A[15];
		ulong a16 = A[16];
		ulong a17 = A[17];
		ulong a18 = A[18];
		ulong a19 = A[19];
		ulong a20 = A[20];
		ulong a21 = A[21];
		ulong a22 = A[22];
		ulong a23 = A[23];
		ulong a24 = A[24];
		for (int i = 0; i < 24; i++)
		{
			ulong c0 = a00 ^ a5 ^ a10 ^ a15 ^ a20;
			ulong c1 = a1 ^ a6 ^ a11 ^ a16 ^ a21;
			ulong c2 = a2 ^ a7 ^ a12 ^ a17 ^ a22;
			ulong c3 = a3 ^ a8 ^ a13 ^ a18 ^ a23;
			ulong c4 = a4 ^ a9 ^ a14 ^ a19 ^ a24;
			ulong d1 = ((c1 << 1) | (c1 >> 63)) ^ c4;
			ulong d2 = ((c2 << 1) | (c2 >> 63)) ^ c0;
			ulong d3 = ((c3 << 1) | (c3 >> 63)) ^ c1;
			ulong d4 = ((c4 << 1) | (c4 >> 63)) ^ c2;
			ulong d5 = ((c0 << 1) | (c0 >> 63)) ^ c3;
			a00 ^= d1;
			a5 ^= d1;
			a10 ^= d1;
			a15 ^= d1;
			a20 ^= d1;
			a1 ^= d2;
			a6 ^= d2;
			a11 ^= d2;
			a16 ^= d2;
			a21 ^= d2;
			a2 ^= d3;
			a7 ^= d3;
			a12 ^= d3;
			a17 ^= d3;
			a22 ^= d3;
			a3 ^= d4;
			a8 ^= d4;
			a13 ^= d4;
			a18 ^= d4;
			a23 ^= d4;
			a4 ^= d5;
			a9 ^= d5;
			a14 ^= d5;
			a19 ^= d5;
			a24 ^= d5;
			c1 = (a1 << 1) | (a1 >> 63);
			a1 = (a6 << 44) | (a6 >> 20);
			a6 = (a9 << 20) | (a9 >> 44);
			a9 = (a22 << 61) | (a22 >> 3);
			a22 = (a14 << 39) | (a14 >> 25);
			a14 = (a20 << 18) | (a20 >> 46);
			a20 = (a2 << 62) | (a2 >> 2);
			a2 = (a12 << 43) | (a12 >> 21);
			a12 = (a13 << 25) | (a13 >> 39);
			a13 = (a19 << 8) | (a19 >> 56);
			a19 = (a23 << 56) | (a23 >> 8);
			a23 = (a15 << 41) | (a15 >> 23);
			a15 = (a4 << 27) | (a4 >> 37);
			a4 = (a24 << 14) | (a24 >> 50);
			a24 = (a21 << 2) | (a21 >> 62);
			a21 = (a8 << 55) | (a8 >> 9);
			a8 = (a16 << 45) | (a16 >> 19);
			a16 = (a5 << 36) | (a5 >> 28);
			a5 = (a3 << 28) | (a3 >> 36);
			a3 = (a18 << 21) | (a18 >> 43);
			a18 = (a17 << 15) | (a17 >> 49);
			a17 = (a11 << 10) | (a11 >> 54);
			a11 = (a7 << 6) | (a7 >> 58);
			a7 = (a10 << 3) | (a10 >> 61);
			a10 = c1;
			c0 = a00 ^ (~a1 & a2);
			c1 = a1 ^ (~a2 & a3);
			a2 ^= ~a3 & a4;
			a3 ^= ~a4 & a00;
			a4 ^= ~a00 & a1;
			a00 = c0;
			a1 = c1;
			c0 = a5 ^ (~a6 & a7);
			c1 = a6 ^ (~a7 & a8);
			a7 ^= ~a8 & a9;
			a8 ^= ~a9 & a5;
			a9 ^= ~a5 & a6;
			a5 = c0;
			a6 = c1;
			c0 = a10 ^ (~a11 & a12);
			c1 = a11 ^ (~a12 & a13);
			a12 ^= ~a13 & a14;
			a13 ^= ~a14 & a10;
			a14 ^= ~a10 & a11;
			a10 = c0;
			a11 = c1;
			c0 = a15 ^ (~a16 & a17);
			c1 = a16 ^ (~a17 & a18);
			a17 ^= ~a18 & a19;
			a18 ^= ~a19 & a15;
			a19 ^= ~a15 & a16;
			a15 = c0;
			a16 = c1;
			c0 = a20 ^ (~a21 & a22);
			c1 = a21 ^ (~a22 & a23);
			a22 ^= ~a23 & a24;
			a23 ^= ~a24 & a20;
			a24 ^= ~a20 & a21;
			a20 = c0;
			a21 = c1;
			a00 ^= KeccakRoundConstants[i];
		}
		A[0] = a00;
		A[1] = a1;
		A[2] = a2;
		A[3] = a3;
		A[4] = a4;
		A[5] = a5;
		A[6] = a6;
		A[7] = a7;
		A[8] = a8;
		A[9] = a9;
		A[10] = a10;
		A[11] = a11;
		A[12] = a12;
		A[13] = a13;
		A[14] = a14;
		A[15] = a15;
		A[16] = a16;
		A[17] = a17;
		A[18] = a18;
		A[19] = a19;
		A[20] = a20;
		A[21] = a21;
		A[22] = a22;
		A[23] = a23;
		A[24] = a24;
	}

	public virtual IMemoable Copy()
	{
		return new KeccakDigest(this);
	}

	public virtual void Reset(IMemoable other)
	{
		CopyIn((KeccakDigest)other);
	}
}
