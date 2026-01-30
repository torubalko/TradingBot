using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class Salsa20Engine : IStreamCipher
{
	public static readonly int DEFAULT_ROUNDS = 20;

	private const int StateSize = 16;

	private static readonly uint[] TAU_SIGMA = Pack.LE_To_UInt32(Strings.ToAsciiByteArray("expand 16-byte kexpand 32-byte k"), 0, 8);

	[Obsolete]
	protected static readonly byte[] sigma = Strings.ToAsciiByteArray("expand 32-byte k");

	[Obsolete]
	protected static readonly byte[] tau = Strings.ToAsciiByteArray("expand 16-byte k");

	protected int rounds;

	private int index;

	internal uint[] engineState = new uint[16];

	internal uint[] x = new uint[16];

	private byte[] keyStream = new byte[64];

	private bool initialised;

	private uint cW0;

	private uint cW1;

	private uint cW2;

	protected virtual int NonceSize => 8;

	public virtual string AlgorithmName
	{
		get
		{
			string name = "Salsa20";
			if (rounds != DEFAULT_ROUNDS)
			{
				name = name + "/" + rounds;
			}
			return name;
		}
	}

	internal void PackTauOrSigma(int keyLength, uint[] state, int stateOffset)
	{
		int tsOff = (keyLength - 16) / 4;
		state[stateOffset] = TAU_SIGMA[tsOff];
		state[stateOffset + 1] = TAU_SIGMA[tsOff + 1];
		state[stateOffset + 2] = TAU_SIGMA[tsOff + 2];
		state[stateOffset + 3] = TAU_SIGMA[tsOff + 3];
	}

	public Salsa20Engine()
		: this(DEFAULT_ROUNDS)
	{
	}

	public Salsa20Engine(int rounds)
	{
		if (rounds <= 0 || (rounds & 1) != 0)
		{
			throw new ArgumentException("'rounds' must be a positive, even number");
		}
		this.rounds = rounds;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		ParametersWithIV obj = (parameters as ParametersWithIV) ?? throw new ArgumentException(AlgorithmName + " Init requires an IV", "parameters");
		byte[] iv = obj.GetIV();
		if (iv == null || iv.Length != NonceSize)
		{
			throw new ArgumentException(AlgorithmName + " requires exactly " + NonceSize + " bytes of IV");
		}
		ICipherParameters keyParam = obj.Parameters;
		if (keyParam == null)
		{
			if (!initialised)
			{
				throw new InvalidOperationException(AlgorithmName + " KeyParameter can not be null for first initialisation");
			}
			SetKey(null, iv);
		}
		else
		{
			if (!(keyParam is KeyParameter))
			{
				throw new ArgumentException(AlgorithmName + " Init parameters must contain a KeyParameter (or null for re-init)");
			}
			SetKey(((KeyParameter)keyParam).GetKey(), iv);
		}
		Reset();
		initialised = true;
	}

	public virtual byte ReturnByte(byte input)
	{
		if (LimitExceeded())
		{
			throw new MaxBytesExceededException("2^70 byte limit per IV; Change IV");
		}
		if (index == 0)
		{
			GenerateKeyStream(keyStream);
			AdvanceCounter();
		}
		byte result = (byte)(keyStream[index] ^ input);
		index = (index + 1) & 0x3F;
		return result;
	}

	protected virtual void AdvanceCounter()
	{
		if (++engineState[8] == 0)
		{
			engineState[9]++;
		}
	}

	public virtual void ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
	{
		if (!initialised)
		{
			throw new InvalidOperationException(AlgorithmName + " not initialised");
		}
		Check.DataLength(inBytes, inOff, len, "input buffer too short");
		Check.OutputLength(outBytes, outOff, len, "output buffer too short");
		if (LimitExceeded((uint)len))
		{
			throw new MaxBytesExceededException("2^70 byte limit per IV would be exceeded; Change IV");
		}
		for (int i = 0; i < len; i++)
		{
			if (index == 0)
			{
				GenerateKeyStream(keyStream);
				AdvanceCounter();
			}
			outBytes[i + outOff] = (byte)(keyStream[index] ^ inBytes[i + inOff]);
			index = (index + 1) & 0x3F;
		}
	}

	public virtual void Reset()
	{
		index = 0;
		ResetLimitCounter();
		ResetCounter();
	}

	protected virtual void ResetCounter()
	{
		engineState[8] = (engineState[9] = 0u);
	}

	protected virtual void SetKey(byte[] keyBytes, byte[] ivBytes)
	{
		if (keyBytes != null)
		{
			if (keyBytes.Length != 16 && keyBytes.Length != 32)
			{
				throw new ArgumentException(AlgorithmName + " requires 128 bit or 256 bit key");
			}
			int tsOff = (keyBytes.Length - 16) / 4;
			engineState[0] = TAU_SIGMA[tsOff];
			engineState[5] = TAU_SIGMA[tsOff + 1];
			engineState[10] = TAU_SIGMA[tsOff + 2];
			engineState[15] = TAU_SIGMA[tsOff + 3];
			Pack.LE_To_UInt32(keyBytes, 0, engineState, 1, 4);
			Pack.LE_To_UInt32(keyBytes, keyBytes.Length - 16, engineState, 11, 4);
		}
		Pack.LE_To_UInt32(ivBytes, 0, engineState, 6, 2);
	}

	protected virtual void GenerateKeyStream(byte[] output)
	{
		SalsaCore(rounds, engineState, x);
		Pack.UInt32_To_LE(x, output, 0);
	}

	internal static void SalsaCore(int rounds, uint[] input, uint[] x)
	{
		if (input.Length != 16)
		{
			throw new ArgumentException();
		}
		if (x.Length != 16)
		{
			throw new ArgumentException();
		}
		if (rounds % 2 != 0)
		{
			throw new ArgumentException("Number of rounds must be even");
		}
		uint x2 = input[0];
		uint x3 = input[1];
		uint x4 = input[2];
		uint x5 = input[3];
		uint x6 = input[4];
		uint x7 = input[5];
		uint x8 = input[6];
		uint x9 = input[7];
		uint x10 = input[8];
		uint x11 = input[9];
		uint x12 = input[10];
		uint x13 = input[11];
		uint x14 = input[12];
		uint x15 = input[13];
		uint x16 = input[14];
		uint x17 = input[15];
		for (int i = rounds; i > 0; i -= 2)
		{
			x6 ^= Integers.RotateLeft(x2 + x14, 7);
			x10 ^= Integers.RotateLeft(x6 + x2, 9);
			x14 ^= Integers.RotateLeft(x10 + x6, 13);
			x2 ^= Integers.RotateLeft(x14 + x10, 18);
			x11 ^= Integers.RotateLeft(x7 + x3, 7);
			x15 ^= Integers.RotateLeft(x11 + x7, 9);
			x3 ^= Integers.RotateLeft(x15 + x11, 13);
			x7 ^= Integers.RotateLeft(x3 + x15, 18);
			x16 ^= Integers.RotateLeft(x12 + x8, 7);
			x4 ^= Integers.RotateLeft(x16 + x12, 9);
			x8 ^= Integers.RotateLeft(x4 + x16, 13);
			x12 ^= Integers.RotateLeft(x8 + x4, 18);
			x5 ^= Integers.RotateLeft(x17 + x13, 7);
			x9 ^= Integers.RotateLeft(x5 + x17, 9);
			x13 ^= Integers.RotateLeft(x9 + x5, 13);
			x17 ^= Integers.RotateLeft(x13 + x9, 18);
			x3 ^= Integers.RotateLeft(x2 + x5, 7);
			x4 ^= Integers.RotateLeft(x3 + x2, 9);
			x5 ^= Integers.RotateLeft(x4 + x3, 13);
			x2 ^= Integers.RotateLeft(x5 + x4, 18);
			x8 ^= Integers.RotateLeft(x7 + x6, 7);
			x9 ^= Integers.RotateLeft(x8 + x7, 9);
			x6 ^= Integers.RotateLeft(x9 + x8, 13);
			x7 ^= Integers.RotateLeft(x6 + x9, 18);
			x13 ^= Integers.RotateLeft(x12 + x11, 7);
			x10 ^= Integers.RotateLeft(x13 + x12, 9);
			x11 ^= Integers.RotateLeft(x10 + x13, 13);
			x12 ^= Integers.RotateLeft(x11 + x10, 18);
			x14 ^= Integers.RotateLeft(x17 + x16, 7);
			x15 ^= Integers.RotateLeft(x14 + x17, 9);
			x16 ^= Integers.RotateLeft(x15 + x14, 13);
			x17 ^= Integers.RotateLeft(x16 + x15, 18);
		}
		x[0] = x2 + input[0];
		x[1] = x3 + input[1];
		x[2] = x4 + input[2];
		x[3] = x5 + input[3];
		x[4] = x6 + input[4];
		x[5] = x7 + input[5];
		x[6] = x8 + input[6];
		x[7] = x9 + input[7];
		x[8] = x10 + input[8];
		x[9] = x11 + input[9];
		x[10] = x12 + input[10];
		x[11] = x13 + input[11];
		x[12] = x14 + input[12];
		x[13] = x15 + input[13];
		x[14] = x16 + input[14];
		x[15] = x17 + input[15];
	}

	private void ResetLimitCounter()
	{
		cW0 = 0u;
		cW1 = 0u;
		cW2 = 0u;
	}

	private bool LimitExceeded()
	{
		if (++cW0 == 0 && ++cW1 == 0)
		{
			return (++cW2 & 0x20) != 0;
		}
		return false;
	}

	private bool LimitExceeded(uint len)
	{
		uint old = cW0;
		cW0 += len;
		if (cW0 < old && ++cW1 == 0)
		{
			return (++cW2 & 0x20) != 0;
		}
		return false;
	}
}
