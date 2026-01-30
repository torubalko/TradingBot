using System;
using System.IO;

namespace MailKit.Security.Ntlm;

internal sealed class MD4 : IDisposable
{
	private const int S11 = 3;

	private const int S12 = 7;

	private const int S13 = 11;

	private const int S14 = 19;

	private const int S21 = 3;

	private const int S22 = 5;

	private const int S23 = 9;

	private const int S24 = 13;

	private const int S31 = 3;

	private const int S32 = 9;

	private const int S33 = 11;

	private const int S34 = 15;

	private bool disposed;

	private byte[] hashValue;

	private byte[] buffered;

	private uint[] state;

	private uint[] count;

	private uint[] x;

	public byte[] Hash
	{
		get
		{
			if (hashValue == null)
			{
				throw new InvalidOperationException("No hash value computed.");
			}
			return hashValue;
		}
	}

	public MD4()
	{
		buffered = new byte[64];
		state = new uint[4];
		count = new uint[2];
		x = new uint[16];
		Initialize();
	}

	~MD4()
	{
		Dispose(disposing: false);
	}

	private void HashCore(byte[] block, int offset, int size)
	{
		int num = (int)((count[0] >> 3) & 0x3F);
		count[0] += (uint)(size << 3);
		if (count[0] < size << 3)
		{
			count[1]++;
		}
		count[1] += (uint)(size >> 29);
		int num2 = 64 - num;
		int i = 0;
		if (size >= num2)
		{
			Buffer.BlockCopy(block, offset, buffered, num, num2);
			MD4Transform(buffered, 0);
			for (i = num2; i + 63 < size; i += 64)
			{
				MD4Transform(block, offset + i);
			}
			num = 0;
		}
		Buffer.BlockCopy(block, offset + i, buffered, num, size - i);
	}

	private byte[] HashFinal()
	{
		byte[] array = new byte[8];
		Encode(array, count);
		uint num = (count[0] >> 3) & 0x3F;
		int num2 = (int)((num < 56) ? (56 - num) : (120 - num));
		HashCore(Padding(num2), 0, num2);
		HashCore(array, 0, 8);
		byte[] array2 = new byte[16];
		Encode(array2, state);
		return array2;
	}

	public void Initialize()
	{
		count[0] = 0u;
		count[1] = 0u;
		state[0] = 1732584193u;
		state[1] = 4023233417u;
		state[2] = 2562383102u;
		state[3] = 271733878u;
		Array.Clear(buffered, 0, 64);
		Array.Clear(x, 0, 16);
	}

	private static byte[] Padding(int length)
	{
		if (length > 0)
		{
			byte[] array = new byte[length];
			array[0] = 128;
			return array;
		}
		return null;
	}

	private static uint F(uint x, uint y, uint z)
	{
		return (x & y) | (~x & z);
	}

	private static uint G(uint x, uint y, uint z)
	{
		return (x & y) | (x & z) | (y & z);
	}

	private static uint H(uint x, uint y, uint z)
	{
		return x ^ y ^ z;
	}

	private static uint ROL(uint x, byte n)
	{
		return (x << (int)n) | (x >> 32 - n);
	}

	private static void FF(ref uint a, uint b, uint c, uint d, uint x, byte s)
	{
		a += F(b, c, d) + x;
		a = ROL(a, s);
	}

	private static void GG(ref uint a, uint b, uint c, uint d, uint x, byte s)
	{
		a += G(b, c, d) + x + 1518500249;
		a = ROL(a, s);
	}

	private static void HH(ref uint a, uint b, uint c, uint d, uint x, byte s)
	{
		a += H(b, c, d) + x + 1859775393;
		a = ROL(a, s);
	}

	private static void Encode(byte[] output, uint[] input)
	{
		int num = 0;
		for (int i = 0; i < output.Length; i += 4)
		{
			output[i] = (byte)input[num];
			output[i + 1] = (byte)(input[num] >> 8);
			output[i + 2] = (byte)(input[num] >> 16);
			output[i + 3] = (byte)(input[num] >> 24);
			num++;
		}
	}

	private static void Decode(uint[] output, byte[] input, int index)
	{
		int num = 0;
		int num2 = index;
		while (num < output.Length)
		{
			output[num] = (uint)(input[num2] | (input[num2 + 1] << 8) | (input[num2 + 2] << 16) | (input[num2 + 3] << 24));
			num++;
			num2 += 4;
		}
	}

	private void MD4Transform(byte[] block, int index)
	{
		uint a = state[0];
		uint a2 = state[1];
		uint a3 = state[2];
		uint a4 = state[3];
		Decode(x, block, index);
		FF(ref a, a2, a3, a4, x[0], 3);
		FF(ref a4, a, a2, a3, x[1], 7);
		FF(ref a3, a4, a, a2, x[2], 11);
		FF(ref a2, a3, a4, a, x[3], 19);
		FF(ref a, a2, a3, a4, x[4], 3);
		FF(ref a4, a, a2, a3, x[5], 7);
		FF(ref a3, a4, a, a2, x[6], 11);
		FF(ref a2, a3, a4, a, x[7], 19);
		FF(ref a, a2, a3, a4, x[8], 3);
		FF(ref a4, a, a2, a3, x[9], 7);
		FF(ref a3, a4, a, a2, x[10], 11);
		FF(ref a2, a3, a4, a, x[11], 19);
		FF(ref a, a2, a3, a4, x[12], 3);
		FF(ref a4, a, a2, a3, x[13], 7);
		FF(ref a3, a4, a, a2, x[14], 11);
		FF(ref a2, a3, a4, a, x[15], 19);
		GG(ref a, a2, a3, a4, x[0], 3);
		GG(ref a4, a, a2, a3, x[4], 5);
		GG(ref a3, a4, a, a2, x[8], 9);
		GG(ref a2, a3, a4, a, x[12], 13);
		GG(ref a, a2, a3, a4, x[1], 3);
		GG(ref a4, a, a2, a3, x[5], 5);
		GG(ref a3, a4, a, a2, x[9], 9);
		GG(ref a2, a3, a4, a, x[13], 13);
		GG(ref a, a2, a3, a4, x[2], 3);
		GG(ref a4, a, a2, a3, x[6], 5);
		GG(ref a3, a4, a, a2, x[10], 9);
		GG(ref a2, a3, a4, a, x[14], 13);
		GG(ref a, a2, a3, a4, x[3], 3);
		GG(ref a4, a, a2, a3, x[7], 5);
		GG(ref a3, a4, a, a2, x[11], 9);
		GG(ref a2, a3, a4, a, x[15], 13);
		HH(ref a, a2, a3, a4, x[0], 3);
		HH(ref a4, a, a2, a3, x[8], 9);
		HH(ref a3, a4, a, a2, x[4], 11);
		HH(ref a2, a3, a4, a, x[12], 15);
		HH(ref a, a2, a3, a4, x[2], 3);
		HH(ref a4, a, a2, a3, x[10], 9);
		HH(ref a3, a4, a, a2, x[6], 11);
		HH(ref a2, a3, a4, a, x[14], 15);
		HH(ref a, a2, a3, a4, x[1], 3);
		HH(ref a4, a, a2, a3, x[9], 9);
		HH(ref a3, a4, a, a2, x[5], 11);
		HH(ref a2, a3, a4, a, x[13], 15);
		HH(ref a, a2, a3, a4, x[3], 3);
		HH(ref a4, a, a2, a3, x[11], 9);
		HH(ref a3, a4, a, a2, x[7], 11);
		HH(ref a2, a3, a4, a, x[15], 15);
		state[0] += a;
		state[1] += a2;
		state[2] += a3;
		state[3] += a4;
	}

	public byte[] ComputeHash(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || offset > buffer.Length - count)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (disposed)
		{
			throw new ObjectDisposedException("MD4");
		}
		HashCore(buffer, offset, count);
		hashValue = HashFinal();
		Initialize();
		return hashValue;
	}

	public byte[] ComputeHash(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return ComputeHash(buffer, 0, buffer.Length);
	}

	public byte[] ComputeHash(Stream inputStream)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (disposed)
		{
			throw new ObjectDisposedException("MD4");
		}
		byte[] array = new byte[4096];
		int num;
		do
		{
			if ((num = inputStream.Read(array, 0, array.Length)) > 0)
			{
				HashCore(array, 0, num);
			}
		}
		while (num > 0);
		hashValue = HashFinal();
		Initialize();
		return hashValue;
	}

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputBuffer == null)
		{
			throw new ArgumentNullException("inputBuffer");
		}
		if (inputOffset < 0 || inputOffset > inputBuffer.Length)
		{
			throw new ArgumentOutOfRangeException("inputOffset");
		}
		if (inputCount < 0 || inputOffset > inputBuffer.Length - inputCount)
		{
			throw new ArgumentOutOfRangeException("inputCount");
		}
		if (outputBuffer != null && (outputOffset < 0 || outputOffset > outputBuffer.Length - inputCount))
		{
			throw new ArgumentOutOfRangeException("outputOffset");
		}
		HashCore(inputBuffer, inputOffset, inputCount);
		if (outputBuffer != null)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
		}
		return inputCount;
	}

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		if (inputCount < 0)
		{
			throw new ArgumentOutOfRangeException("inputCount");
		}
		byte[] array = new byte[inputCount];
		Buffer.BlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
		HashCore(inputBuffer, inputOffset, inputCount);
		hashValue = HashFinal();
		Initialize();
		return array;
	}

	private void Dispose(bool disposing)
	{
		if (buffered != null)
		{
			Array.Clear(buffered, 0, buffered.Length);
			buffered = null;
		}
		if (state != null)
		{
			Array.Clear(state, 0, state.Length);
			state = null;
		}
		if (count != null)
		{
			Array.Clear(count, 0, count.Length);
			count = null;
		}
		if (x != null)
		{
			Array.Clear(x, 0, x.Length);
			x = null;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
		disposed = true;
	}
}
