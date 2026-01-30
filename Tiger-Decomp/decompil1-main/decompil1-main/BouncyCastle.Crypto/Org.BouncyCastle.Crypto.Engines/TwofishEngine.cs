using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public sealed class TwofishEngine : IBlockCipher
{
	private static readonly byte[,] P = new byte[2, 256]
	{
		{
			169, 103, 179, 232, 4, 253, 163, 118, 154, 146,
			128, 120, 228, 221, 209, 56, 13, 198, 53, 152,
			24, 247, 236, 108, 67, 117, 55, 38, 250, 19,
			148, 72, 242, 208, 139, 48, 132, 84, 223, 35,
			25, 91, 61, 89, 243, 174, 162, 130, 99, 1,
			131, 46, 217, 81, 155, 124, 166, 235, 165, 190,
			22, 12, 227, 97, 192, 140, 58, 245, 115, 44,
			37, 11, 187, 78, 137, 107, 83, 106, 180, 241,
			225, 230, 189, 69, 226, 244, 182, 102, 204, 149,
			3, 86, 212, 28, 30, 215, 251, 195, 142, 181,
			233, 207, 191, 186, 234, 119, 57, 175, 51, 201,
			98, 113, 129, 121, 9, 173, 36, 205, 249, 216,
			229, 197, 185, 77, 68, 8, 134, 231, 161, 29,
			170, 237, 6, 112, 178, 210, 65, 123, 160, 17,
			49, 194, 39, 144, 32, 246, 96, 255, 150, 92,
			177, 171, 158, 156, 82, 27, 95, 147, 10, 239,
			145, 133, 73, 238, 45, 79, 143, 59, 71, 135,
			109, 70, 214, 62, 105, 100, 42, 206, 203, 47,
			252, 151, 5, 122, 172, 127, 213, 26, 75, 14,
			167, 90, 40, 20, 63, 41, 136, 60, 76, 2,
			184, 218, 176, 23, 85, 31, 138, 125, 87, 199,
			141, 116, 183, 196, 159, 114, 126, 21, 34, 18,
			88, 7, 153, 52, 110, 80, 222, 104, 101, 188,
			219, 248, 200, 168, 43, 64, 220, 254, 50, 164,
			202, 16, 33, 240, 211, 93, 15, 0, 111, 157,
			54, 66, 74, 94, 193, 224
		},
		{
			117, 243, 198, 244, 219, 123, 251, 200, 74, 211,
			230, 107, 69, 125, 232, 75, 214, 50, 216, 253,
			55, 113, 241, 225, 48, 15, 248, 27, 135, 250,
			6, 63, 94, 186, 174, 91, 138, 0, 188, 157,
			109, 193, 177, 14, 128, 93, 210, 213, 160, 132,
			7, 20, 181, 144, 44, 163, 178, 115, 76, 84,
			146, 116, 54, 81, 56, 176, 189, 90, 252, 96,
			98, 150, 108, 66, 247, 16, 124, 40, 39, 140,
			19, 149, 156, 199, 36, 70, 59, 112, 202, 227,
			133, 203, 17, 208, 147, 184, 166, 131, 32, 255,
			159, 119, 195, 204, 3, 111, 8, 191, 64, 231,
			43, 226, 121, 12, 170, 130, 65, 58, 234, 185,
			228, 154, 164, 151, 126, 218, 122, 23, 102, 148,
			161, 29, 61, 240, 222, 179, 11, 114, 167, 28,
			239, 209, 83, 62, 143, 51, 38, 95, 236, 118,
			42, 73, 129, 136, 238, 33, 196, 26, 235, 217,
			197, 57, 153, 205, 173, 49, 139, 1, 24, 35,
			221, 31, 78, 45, 249, 72, 79, 242, 101, 142,
			120, 92, 88, 25, 141, 229, 152, 87, 103, 127,
			5, 100, 175, 99, 182, 254, 245, 183, 60, 165,
			206, 233, 104, 68, 224, 77, 67, 105, 41, 46,
			172, 21, 89, 168, 10, 158, 110, 71, 223, 52,
			53, 106, 207, 220, 34, 201, 192, 155, 137, 212,
			237, 171, 18, 162, 13, 82, 187, 2, 47, 169,
			215, 97, 30, 180, 80, 4, 246, 194, 22, 37,
			134, 86, 85, 9, 190, 145
		}
	};

	private const int P_00 = 1;

	private const int P_01 = 0;

	private const int P_02 = 0;

	private const int P_03 = 1;

	private const int P_04 = 1;

	private const int P_10 = 0;

	private const int P_11 = 0;

	private const int P_12 = 1;

	private const int P_13 = 1;

	private const int P_14 = 0;

	private const int P_20 = 1;

	private const int P_21 = 1;

	private const int P_22 = 0;

	private const int P_23 = 0;

	private const int P_24 = 0;

	private const int P_30 = 0;

	private const int P_31 = 1;

	private const int P_32 = 1;

	private const int P_33 = 0;

	private const int P_34 = 1;

	private const int GF256_FDBK = 361;

	private const int GF256_FDBK_2 = 180;

	private const int GF256_FDBK_4 = 90;

	private const int RS_GF_FDBK = 333;

	private const int ROUNDS = 16;

	private const int MAX_ROUNDS = 16;

	private const int BLOCK_SIZE = 16;

	private const int MAX_KEY_BITS = 256;

	private const int INPUT_WHITEN = 0;

	private const int OUTPUT_WHITEN = 4;

	private const int ROUND_SUBKEYS = 8;

	private const int TOTAL_SUBKEYS = 40;

	private const int SK_STEP = 33686018;

	private const int SK_BUMP = 16843009;

	private const int SK_ROTL = 9;

	private bool encrypting;

	private int[] gMDS0 = new int[256];

	private int[] gMDS1 = new int[256];

	private int[] gMDS2 = new int[256];

	private int[] gMDS3 = new int[256];

	private int[] gSubKeys;

	private int[] gSBox;

	private int k64Cnt;

	private byte[] workingKey;

	public string AlgorithmName => "Twofish";

	public bool IsPartialBlockOkay => false;

	public TwofishEngine()
	{
		int[] m1 = new int[2];
		int[] mX = new int[2];
		int[] mY = new int[2];
		for (int i = 0; i < 256; i++)
		{
			int j = (m1[0] = P[0, i] & 0xFF);
			mX[0] = Mx_X(j) & 0xFF;
			mY[0] = Mx_Y(j) & 0xFF;
			j = (m1[1] = P[1, i] & 0xFF);
			mX[1] = Mx_X(j) & 0xFF;
			mY[1] = Mx_Y(j) & 0xFF;
			gMDS0[i] = m1[1] | (mX[1] << 8) | (mY[1] << 16) | (mY[1] << 24);
			gMDS1[i] = mY[0] | (mY[0] << 8) | (mX[0] << 16) | (m1[0] << 24);
			gMDS2[i] = mX[1] | (mY[1] << 8) | (m1[1] << 16) | (mY[1] << 24);
			gMDS3[i] = mX[0] | (m1[0] << 8) | (mY[0] << 16) | (mX[0] << 24);
		}
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to Twofish init - " + Platform.GetTypeName(parameters));
		}
		encrypting = forEncryption;
		workingKey = ((KeyParameter)parameters).GetKey();
		int keyBits = workingKey.Length * 8;
		if (keyBits != 128 && keyBits != 192 && keyBits != 256)
		{
			throw new ArgumentException("Key length not 128/192/256 bits.");
		}
		k64Cnt = workingKey.Length / 8;
		SetKey(workingKey);
	}

	public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey == null)
		{
			throw new InvalidOperationException("Twofish not initialised");
		}
		Check.DataLength(input, inOff, 16, "input buffer too short");
		Check.OutputLength(output, outOff, 16, "output buffer too short");
		if (encrypting)
		{
			EncryptBlock(input, inOff, output, outOff);
		}
		else
		{
			DecryptBlock(input, inOff, output, outOff);
		}
		return 16;
	}

	public void Reset()
	{
		if (workingKey != null)
		{
			SetKey(workingKey);
		}
	}

	public int GetBlockSize()
	{
		return 16;
	}

	private void SetKey(byte[] key)
	{
		int[] k32e = new int[4];
		int[] k32o = new int[4];
		int[] sBoxKeys = new int[4];
		gSubKeys = new int[40];
		for (int i = 0; i < k64Cnt; i++)
		{
			int p = i * 8;
			k32e[i] = (int)Pack.LE_To_UInt32(key, p);
			k32o[i] = (int)Pack.LE_To_UInt32(key, p + 4);
			sBoxKeys[k64Cnt - 1 - i] = RS_MDS_Encode(k32e[i], k32o[i]);
		}
		for (int j = 0; j < 20; j++)
		{
			int q = j * 33686018;
			int A = F32(q, k32e);
			int B = F32(q + 16843009, k32o);
			B = Integers.RotateLeft(B, 8);
			A += B;
			gSubKeys[j * 2] = A;
			A += B;
			gSubKeys[j * 2 + 1] = Integers.RotateLeft(A, 9);
		}
		int k0 = sBoxKeys[0];
		int k1 = sBoxKeys[1];
		int k2 = sBoxKeys[2];
		int k3 = sBoxKeys[3];
		gSBox = new int[1024];
		for (int l = 0; l < 256; l++)
		{
			int b1;
			int b2;
			int b3;
			int b0 = (b1 = (b2 = (b3 = l)));
			switch (k64Cnt & 3)
			{
			case 1:
				gSBox[l * 2] = gMDS0[(P[0, b0] & 0xFF) ^ M_b0(k0)];
				gSBox[l * 2 + 1] = gMDS1[(P[0, b1] & 0xFF) ^ M_b1(k0)];
				gSBox[l * 2 + 512] = gMDS2[(P[1, b2] & 0xFF) ^ M_b2(k0)];
				gSBox[l * 2 + 513] = gMDS3[(P[1, b3] & 0xFF) ^ M_b3(k0)];
				continue;
			case 0:
				b0 = (P[1, b0] & 0xFF) ^ M_b0(k3);
				b1 = (P[0, b1] & 0xFF) ^ M_b1(k3);
				b2 = (P[0, b2] & 0xFF) ^ M_b2(k3);
				b3 = (P[1, b3] & 0xFF) ^ M_b3(k3);
				goto case 3;
			case 3:
				b0 = (P[1, b0] & 0xFF) ^ M_b0(k2);
				b1 = (P[1, b1] & 0xFF) ^ M_b1(k2);
				b2 = (P[0, b2] & 0xFF) ^ M_b2(k2);
				b3 = (P[0, b3] & 0xFF) ^ M_b3(k2);
				break;
			case 2:
				break;
			default:
				continue;
			}
			gSBox[l * 2] = gMDS0[(P[0, (P[0, b0] & 0xFF) ^ M_b0(k1)] & 0xFF) ^ M_b0(k0)];
			gSBox[l * 2 + 1] = gMDS1[(P[0, (P[1, b1] & 0xFF) ^ M_b1(k1)] & 0xFF) ^ M_b1(k0)];
			gSBox[l * 2 + 512] = gMDS2[(P[1, (P[0, b2] & 0xFF) ^ M_b2(k1)] & 0xFF) ^ M_b2(k0)];
			gSBox[l * 2 + 513] = gMDS3[(P[1, (P[1, b3] & 0xFF) ^ M_b3(k1)] & 0xFF) ^ M_b3(k0)];
		}
	}

	private void EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
	{
		int x0 = (int)Pack.LE_To_UInt32(src, srcIndex) ^ gSubKeys[0];
		int x1 = (int)Pack.LE_To_UInt32(src, srcIndex + 4) ^ gSubKeys[1];
		int x2 = (int)Pack.LE_To_UInt32(src, srcIndex + 8) ^ gSubKeys[2];
		int x3 = (int)Pack.LE_To_UInt32(src, srcIndex + 12) ^ gSubKeys[3];
		int k = 8;
		for (int r = 0; r < 16; r += 2)
		{
			int t0 = Fe32_0(x0);
			int t1 = Fe32_3(x1);
			x2 ^= t0 + t1 + gSubKeys[k++];
			x2 = Integers.RotateRight(x2, 1);
			x3 = Integers.RotateLeft(x3, 1) ^ (t0 + 2 * t1 + gSubKeys[k++]);
			t0 = Fe32_0(x2);
			t1 = Fe32_3(x3);
			x0 ^= t0 + t1 + gSubKeys[k++];
			x0 = Integers.RotateRight(x0, 1);
			x1 = Integers.RotateLeft(x1, 1) ^ (t0 + 2 * t1 + gSubKeys[k++]);
		}
		Pack.UInt32_To_LE((uint)(x2 ^ gSubKeys[4]), dst, dstIndex);
		Pack.UInt32_To_LE((uint)(x3 ^ gSubKeys[5]), dst, dstIndex + 4);
		Pack.UInt32_To_LE((uint)(x0 ^ gSubKeys[6]), dst, dstIndex + 8);
		Pack.UInt32_To_LE((uint)(x1 ^ gSubKeys[7]), dst, dstIndex + 12);
	}

	private void DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
	{
		int x2 = (int)Pack.LE_To_UInt32(src, srcIndex) ^ gSubKeys[4];
		int x3 = (int)Pack.LE_To_UInt32(src, srcIndex + 4) ^ gSubKeys[5];
		int x4 = (int)Pack.LE_To_UInt32(src, srcIndex + 8) ^ gSubKeys[6];
		int x5 = (int)Pack.LE_To_UInt32(src, srcIndex + 12) ^ gSubKeys[7];
		int k = 39;
		for (int r = 0; r < 16; r += 2)
		{
			int t0 = Fe32_0(x2);
			int t1 = Fe32_3(x3);
			x5 ^= t0 + 2 * t1 + gSubKeys[k--];
			x4 = Integers.RotateLeft(x4, 1) ^ (t0 + t1 + gSubKeys[k--]);
			x5 = Integers.RotateRight(x5, 1);
			t0 = Fe32_0(x4);
			t1 = Fe32_3(x5);
			x3 ^= t0 + 2 * t1 + gSubKeys[k--];
			x2 = Integers.RotateLeft(x2, 1) ^ (t0 + t1 + gSubKeys[k--]);
			x3 = Integers.RotateRight(x3, 1);
		}
		Pack.UInt32_To_LE((uint)(x4 ^ gSubKeys[0]), dst, dstIndex);
		Pack.UInt32_To_LE((uint)(x5 ^ gSubKeys[1]), dst, dstIndex + 4);
		Pack.UInt32_To_LE((uint)(x2 ^ gSubKeys[2]), dst, dstIndex + 8);
		Pack.UInt32_To_LE((uint)(x3 ^ gSubKeys[3]), dst, dstIndex + 12);
	}

	private int F32(int x, int[] k32)
	{
		int b0 = M_b0(x);
		int b1 = M_b1(x);
		int b2 = M_b2(x);
		int b3 = M_b3(x);
		int k33 = k32[0];
		int k34 = k32[1];
		int k35 = k32[2];
		int k36 = k32[3];
		int result = 0;
		switch (k64Cnt & 3)
		{
		case 1:
			result = gMDS0[(P[0, b0] & 0xFF) ^ M_b0(k33)] ^ gMDS1[(P[0, b1] & 0xFF) ^ M_b1(k33)] ^ gMDS2[(P[1, b2] & 0xFF) ^ M_b2(k33)] ^ gMDS3[(P[1, b3] & 0xFF) ^ M_b3(k33)];
			break;
		case 0:
			b0 = (P[1, b0] & 0xFF) ^ M_b0(k36);
			b1 = (P[0, b1] & 0xFF) ^ M_b1(k36);
			b2 = (P[0, b2] & 0xFF) ^ M_b2(k36);
			b3 = (P[1, b3] & 0xFF) ^ M_b3(k36);
			goto case 3;
		case 3:
			b0 = (P[1, b0] & 0xFF) ^ M_b0(k35);
			b1 = (P[1, b1] & 0xFF) ^ M_b1(k35);
			b2 = (P[0, b2] & 0xFF) ^ M_b2(k35);
			b3 = (P[0, b3] & 0xFF) ^ M_b3(k35);
			goto case 2;
		case 2:
			result = gMDS0[(P[0, (P[0, b0] & 0xFF) ^ M_b0(k34)] & 0xFF) ^ M_b0(k33)] ^ gMDS1[(P[0, (P[1, b1] & 0xFF) ^ M_b1(k34)] & 0xFF) ^ M_b1(k33)] ^ gMDS2[(P[1, (P[0, b2] & 0xFF) ^ M_b2(k34)] & 0xFF) ^ M_b2(k33)] ^ gMDS3[(P[1, (P[1, b3] & 0xFF) ^ M_b3(k34)] & 0xFF) ^ M_b3(k33)];
			break;
		}
		return result;
	}

	private int RS_MDS_Encode(int k0, int k1)
	{
		int r = k1;
		for (int i = 0; i < 4; i++)
		{
			r = RS_rem(r);
		}
		r ^= k0;
		for (int j = 0; j < 4; j++)
		{
			r = RS_rem(r);
		}
		return r;
	}

	private int RS_rem(int x)
	{
		int b = (x >>> 24) & 0xFF;
		int g2 = ((b << 1) ^ (((b & 0x80) != 0) ? 333 : 0)) & 0xFF;
		int g3 = (b >>> 1) ^ (((b & 1) != 0) ? 166 : 0) ^ g2;
		return (x << 8) ^ (g3 << 24) ^ (g2 << 16) ^ (g3 << 8) ^ b;
	}

	private int LFSR1(int x)
	{
		return (x >> 1) ^ (((x & 1) != 0) ? 180 : 0);
	}

	private int LFSR2(int x)
	{
		return (x >> 2) ^ (((x & 2) != 0) ? 180 : 0) ^ (((x & 1) != 0) ? 90 : 0);
	}

	private int Mx_X(int x)
	{
		return x ^ LFSR2(x);
	}

	private int Mx_Y(int x)
	{
		return x ^ LFSR1(x) ^ LFSR2(x);
	}

	private int M_b0(int x)
	{
		return x & 0xFF;
	}

	private int M_b1(int x)
	{
		return (x >>> 8) & 0xFF;
	}

	private int M_b2(int x)
	{
		return (x >>> 16) & 0xFF;
	}

	private int M_b3(int x)
	{
		return (x >>> 24) & 0xFF;
	}

	private int Fe32_0(int x)
	{
		return gSBox[2 * (x & 0xFF)] ^ gSBox[1 + 2 * ((x >>> 8) & 0xFF)] ^ gSBox[512 + 2 * ((x >>> 16) & 0xFF)] ^ gSBox[513 + 2 * ((x >>> 24) & 0xFF)];
	}

	private int Fe32_3(int x)
	{
		return gSBox[2 * ((x >>> 24) & 0xFF)] ^ gSBox[1 + 2 * (x & 0xFF)] ^ gSBox[512 + 2 * ((x >>> 8) & 0xFF)] ^ gSBox[513 + 2 * ((x >>> 16) & 0xFF)];
	}
}
