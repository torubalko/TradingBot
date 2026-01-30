using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class AesLightEngine : IBlockCipher
{
	private static readonly byte[] S = new byte[256]
	{
		99, 124, 119, 123, 242, 107, 111, 197, 48, 1,
		103, 43, 254, 215, 171, 118, 202, 130, 201, 125,
		250, 89, 71, 240, 173, 212, 162, 175, 156, 164,
		114, 192, 183, 253, 147, 38, 54, 63, 247, 204,
		52, 165, 229, 241, 113, 216, 49, 21, 4, 199,
		35, 195, 24, 150, 5, 154, 7, 18, 128, 226,
		235, 39, 178, 117, 9, 131, 44, 26, 27, 110,
		90, 160, 82, 59, 214, 179, 41, 227, 47, 132,
		83, 209, 0, 237, 32, 252, 177, 91, 106, 203,
		190, 57, 74, 76, 88, 207, 208, 239, 170, 251,
		67, 77, 51, 133, 69, 249, 2, 127, 80, 60,
		159, 168, 81, 163, 64, 143, 146, 157, 56, 245,
		188, 182, 218, 33, 16, 255, 243, 210, 205, 12,
		19, 236, 95, 151, 68, 23, 196, 167, 126, 61,
		100, 93, 25, 115, 96, 129, 79, 220, 34, 42,
		144, 136, 70, 238, 184, 20, 222, 94, 11, 219,
		224, 50, 58, 10, 73, 6, 36, 92, 194, 211,
		172, 98, 145, 149, 228, 121, 231, 200, 55, 109,
		141, 213, 78, 169, 108, 86, 244, 234, 101, 122,
		174, 8, 186, 120, 37, 46, 28, 166, 180, 198,
		232, 221, 116, 31, 75, 189, 139, 138, 112, 62,
		181, 102, 72, 3, 246, 14, 97, 53, 87, 185,
		134, 193, 29, 158, 225, 248, 152, 17, 105, 217,
		142, 148, 155, 30, 135, 233, 206, 85, 40, 223,
		140, 161, 137, 13, 191, 230, 66, 104, 65, 153,
		45, 15, 176, 84, 187, 22
	};

	private static readonly byte[] Si = new byte[256]
	{
		82, 9, 106, 213, 48, 54, 165, 56, 191, 64,
		163, 158, 129, 243, 215, 251, 124, 227, 57, 130,
		155, 47, 255, 135, 52, 142, 67, 68, 196, 222,
		233, 203, 84, 123, 148, 50, 166, 194, 35, 61,
		238, 76, 149, 11, 66, 250, 195, 78, 8, 46,
		161, 102, 40, 217, 36, 178, 118, 91, 162, 73,
		109, 139, 209, 37, 114, 248, 246, 100, 134, 104,
		152, 22, 212, 164, 92, 204, 93, 101, 182, 146,
		108, 112, 72, 80, 253, 237, 185, 218, 94, 21,
		70, 87, 167, 141, 157, 132, 144, 216, 171, 0,
		140, 188, 211, 10, 247, 228, 88, 5, 184, 179,
		69, 6, 208, 44, 30, 143, 202, 63, 15, 2,
		193, 175, 189, 3, 1, 19, 138, 107, 58, 145,
		17, 65, 79, 103, 220, 234, 151, 242, 207, 206,
		240, 180, 230, 115, 150, 172, 116, 34, 231, 173,
		53, 133, 226, 249, 55, 232, 28, 117, 223, 110,
		71, 241, 26, 113, 29, 41, 197, 137, 111, 183,
		98, 14, 170, 24, 190, 27, 252, 86, 62, 75,
		198, 210, 121, 32, 154, 219, 192, 254, 120, 205,
		90, 244, 31, 221, 168, 51, 136, 7, 199, 49,
		177, 18, 16, 89, 39, 128, 236, 95, 96, 81,
		127, 169, 25, 181, 74, 13, 45, 229, 122, 159,
		147, 201, 156, 239, 160, 224, 59, 77, 174, 42,
		245, 176, 200, 235, 187, 60, 131, 83, 153, 97,
		23, 43, 4, 126, 186, 119, 214, 38, 225, 105,
		20, 99, 85, 33, 12, 125
	};

	private static readonly byte[] rcon = new byte[30]
	{
		1, 2, 4, 8, 16, 32, 64, 128, 27, 54,
		108, 216, 171, 77, 154, 47, 94, 188, 99, 198,
		151, 53, 106, 212, 179, 125, 250, 239, 197, 145
	};

	private const uint m1 = 2155905152u;

	private const uint m2 = 2139062143u;

	private const uint m3 = 27u;

	private const uint m4 = 3233857728u;

	private const uint m5 = 1061109567u;

	private int ROUNDS;

	private uint[][] WorkingKey;

	private bool forEncryption;

	private const int BLOCK_SIZE = 16;

	public virtual string AlgorithmName => "AES";

	public virtual bool IsPartialBlockOkay => false;

	private static uint Shift(uint r, int shift)
	{
		return (r >> shift) | (r << 32 - shift);
	}

	private static uint FFmulX(uint x)
	{
		return ((x & 0x7F7F7F7F) << 1) ^ (((x & 0x80808080u) >> 7) * 27);
	}

	private static uint FFmulX2(uint x)
	{
		uint num = (x & 0x3F3F3F3F) << 2;
		uint t1 = x & 0xC0C0C0C0u;
		t1 ^= t1 >> 1;
		return num ^ (t1 >> 2) ^ (t1 >> 5);
	}

	private static uint Mcol(uint x)
	{
		uint t0 = Shift(x, 8);
		uint t1 = x ^ t0;
		return Shift(t1, 16) ^ t0 ^ FFmulX(t1);
	}

	private static uint Inv_Mcol(uint x)
	{
		uint t0 = x;
		uint t1 = t0 ^ Shift(t0, 8);
		t0 ^= FFmulX(t1);
		t1 ^= FFmulX2(t0);
		return t0 ^ (t1 ^ Shift(t1, 16));
	}

	private static uint SubWord(uint x)
	{
		return (uint)(S[x & 0xFF] | (S[(x >> 8) & 0xFF] << 8) | (S[(x >> 16) & 0xFF] << 16) | (S[(x >> 24) & 0xFF] << 24));
	}

	private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
	{
		int keyLen = key.Length;
		if (keyLen < 16 || keyLen > 32 || (keyLen & 7) != 0)
		{
			throw new ArgumentException("Key length not 128/192/256 bits.");
		}
		int KC = keyLen >> 2;
		ROUNDS = KC + 6;
		uint[][] W = new uint[ROUNDS + 1][];
		for (int i = 0; i <= ROUNDS; i++)
		{
			W[i] = new uint[4];
		}
		switch (KC)
		{
		case 4:
		{
			uint t14 = Pack.LE_To_UInt32(key, 0);
			W[0][0] = t14;
			uint t15 = Pack.LE_To_UInt32(key, 4);
			W[0][1] = t15;
			uint t16 = Pack.LE_To_UInt32(key, 8);
			W[0][2] = t16;
			uint t17 = Pack.LE_To_UInt32(key, 12);
			W[0][3] = t17;
			for (int l = 1; l <= 10; l++)
			{
				uint u3 = SubWord(Shift(t17, 8)) ^ AesLightEngine.rcon[l - 1];
				t14 ^= u3;
				W[l][0] = t14;
				t15 ^= t14;
				W[l][1] = t15;
				t16 ^= t15;
				W[l][2] = t16;
				t17 ^= t16;
				W[l][3] = t17;
			}
			break;
		}
		case 6:
		{
			uint t8 = Pack.LE_To_UInt32(key, 0);
			W[0][0] = t8;
			uint t9 = Pack.LE_To_UInt32(key, 4);
			W[0][1] = t9;
			uint t10 = Pack.LE_To_UInt32(key, 8);
			W[0][2] = t10;
			uint t11 = Pack.LE_To_UInt32(key, 12);
			W[0][3] = t11;
			uint t12 = Pack.LE_To_UInt32(key, 16);
			W[1][0] = t12;
			uint t13 = Pack.LE_To_UInt32(key, 20);
			W[1][1] = t13;
			uint rcon2 = 1u;
			uint u2 = SubWord(Shift(t13, 8)) ^ rcon2;
			rcon2 <<= 1;
			t8 ^= u2;
			W[1][2] = t8;
			t9 ^= t8;
			W[1][3] = t9;
			t10 ^= t9;
			W[2][0] = t10;
			t11 ^= t10;
			W[2][1] = t11;
			t12 ^= t11;
			W[2][2] = t12;
			t13 ^= t12;
			W[2][3] = t13;
			for (int k = 3; k < 12; k += 3)
			{
				u2 = SubWord(Shift(t13, 8)) ^ rcon2;
				rcon2 <<= 1;
				t8 ^= u2;
				W[k][0] = t8;
				t9 ^= t8;
				W[k][1] = t9;
				t10 ^= t9;
				W[k][2] = t10;
				t11 ^= t10;
				W[k][3] = t11;
				t12 ^= t11;
				W[k + 1][0] = t12;
				t13 ^= t12;
				W[k + 1][1] = t13;
				u2 = SubWord(Shift(t13, 8)) ^ rcon2;
				rcon2 <<= 1;
				t8 ^= u2;
				W[k + 1][2] = t8;
				t9 ^= t8;
				W[k + 1][3] = t9;
				t10 ^= t9;
				W[k + 2][0] = t10;
				t11 ^= t10;
				W[k + 2][1] = t11;
				t12 ^= t11;
				W[k + 2][2] = t12;
				t13 ^= t12;
				W[k + 2][3] = t13;
			}
			u2 = SubWord(Shift(t13, 8)) ^ rcon2;
			t8 ^= u2;
			W[12][0] = t8;
			t9 ^= t8;
			W[12][1] = t9;
			t10 ^= t9;
			W[12][2] = t10;
			t11 ^= t10;
			W[12][3] = t11;
			break;
		}
		case 8:
		{
			uint t0 = Pack.LE_To_UInt32(key, 0);
			W[0][0] = t0;
			uint t1 = Pack.LE_To_UInt32(key, 4);
			W[0][1] = t1;
			uint t2 = Pack.LE_To_UInt32(key, 8);
			W[0][2] = t2;
			uint t3 = Pack.LE_To_UInt32(key, 12);
			W[0][3] = t3;
			uint t4 = Pack.LE_To_UInt32(key, 16);
			W[1][0] = t4;
			uint t5 = Pack.LE_To_UInt32(key, 20);
			W[1][1] = t5;
			uint t6 = Pack.LE_To_UInt32(key, 24);
			W[1][2] = t6;
			uint t7 = Pack.LE_To_UInt32(key, 28);
			W[1][3] = t7;
			uint rcon = 1u;
			uint u;
			for (int j = 2; j < 14; j += 2)
			{
				u = SubWord(Shift(t7, 8)) ^ rcon;
				rcon <<= 1;
				t0 ^= u;
				W[j][0] = t0;
				t1 ^= t0;
				W[j][1] = t1;
				t2 ^= t1;
				W[j][2] = t2;
				t3 ^= t2;
				W[j][3] = t3;
				u = SubWord(t3);
				t4 ^= u;
				W[j + 1][0] = t4;
				t5 ^= t4;
				W[j + 1][1] = t5;
				t6 ^= t5;
				W[j + 1][2] = t6;
				t7 ^= t6;
				W[j + 1][3] = t7;
			}
			u = SubWord(Shift(t7, 8)) ^ rcon;
			t0 ^= u;
			W[14][0] = t0;
			t1 ^= t0;
			W[14][1] = t1;
			t2 ^= t1;
			W[14][2] = t2;
			t3 ^= t2;
			W[14][3] = t3;
			break;
		}
		default:
			throw new InvalidOperationException("Should never get here");
		}
		if (!forEncryption)
		{
			for (int m = 1; m < ROUNDS; m++)
			{
				uint[] w = W[m];
				for (int n = 0; n < 4; n++)
				{
					w[n] = Inv_Mcol(w[n]);
				}
			}
		}
		return W;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter keyParameter))
		{
			throw new ArgumentException("invalid parameter passed to AES init - " + Platform.GetTypeName(parameters));
		}
		WorkingKey = GenerateWorkingKey(keyParameter.GetKey(), forEncryption);
		this.forEncryption = forEncryption;
	}

	public virtual int GetBlockSize()
	{
		return 16;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (WorkingKey == null)
		{
			throw new InvalidOperationException("AES engine not initialised");
		}
		Check.DataLength(input, inOff, 16, "input buffer too short");
		Check.OutputLength(output, outOff, 16, "output buffer too short");
		if (forEncryption)
		{
			EncryptBlock(input, inOff, output, outOff, WorkingKey);
		}
		else
		{
			DecryptBlock(input, inOff, output, outOff, WorkingKey);
		}
		return 16;
	}

	public virtual void Reset()
	{
	}

	private void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
	{
		uint C0 = Pack.LE_To_UInt32(input, inOff);
		uint C1 = Pack.LE_To_UInt32(input, inOff + 4);
		uint C2 = Pack.LE_To_UInt32(input, inOff + 8);
		uint num = Pack.LE_To_UInt32(input, inOff + 12);
		uint[] kw = KW[0];
		uint t0 = C0 ^ kw[0];
		uint t1 = C1 ^ kw[1];
		uint t2 = C2 ^ kw[2];
		uint r3 = num ^ kw[3];
		int r4 = 1;
		uint r5;
		uint r6;
		uint r7;
		while (r4 < ROUNDS - 1)
		{
			kw = KW[r4++];
			r5 = Mcol((uint)(S[t0 & 0xFF] ^ (S[(t1 >> 8) & 0xFF] << 8) ^ (S[(t2 >> 16) & 0xFF] << 16) ^ (S[(r3 >> 24) & 0xFF] << 24))) ^ kw[0];
			r6 = Mcol((uint)(S[t1 & 0xFF] ^ (S[(t2 >> 8) & 0xFF] << 8) ^ (S[(r3 >> 16) & 0xFF] << 16) ^ (S[(t0 >> 24) & 0xFF] << 24))) ^ kw[1];
			r7 = Mcol((uint)(S[t2 & 0xFF] ^ (S[(r3 >> 8) & 0xFF] << 8) ^ (S[(t0 >> 16) & 0xFF] << 16) ^ (S[(t1 >> 24) & 0xFF] << 24))) ^ kw[2];
			r3 = Mcol((uint)(S[r3 & 0xFF] ^ (S[(t0 >> 8) & 0xFF] << 8) ^ (S[(t1 >> 16) & 0xFF] << 16) ^ (S[(t2 >> 24) & 0xFF] << 24))) ^ kw[3];
			kw = KW[r4++];
			t0 = Mcol((uint)(S[r5 & 0xFF] ^ (S[(r6 >> 8) & 0xFF] << 8) ^ (S[(r7 >> 16) & 0xFF] << 16) ^ (S[(r3 >> 24) & 0xFF] << 24))) ^ kw[0];
			t1 = Mcol((uint)(S[r6 & 0xFF] ^ (S[(r7 >> 8) & 0xFF] << 8) ^ (S[(r3 >> 16) & 0xFF] << 16) ^ (S[(r5 >> 24) & 0xFF] << 24))) ^ kw[1];
			t2 = Mcol((uint)(S[r7 & 0xFF] ^ (S[(r3 >> 8) & 0xFF] << 8) ^ (S[(r5 >> 16) & 0xFF] << 16) ^ (S[(r6 >> 24) & 0xFF] << 24))) ^ kw[2];
			r3 = Mcol((uint)(S[r3 & 0xFF] ^ (S[(r5 >> 8) & 0xFF] << 8) ^ (S[(r6 >> 16) & 0xFF] << 16) ^ (S[(r7 >> 24) & 0xFF] << 24))) ^ kw[3];
		}
		kw = KW[r4++];
		r5 = Mcol((uint)(S[t0 & 0xFF] ^ (S[(t1 >> 8) & 0xFF] << 8) ^ (S[(t2 >> 16) & 0xFF] << 16) ^ (S[(r3 >> 24) & 0xFF] << 24))) ^ kw[0];
		r6 = Mcol((uint)(S[t1 & 0xFF] ^ (S[(t2 >> 8) & 0xFF] << 8) ^ (S[(r3 >> 16) & 0xFF] << 16) ^ (S[(t0 >> 24) & 0xFF] << 24))) ^ kw[1];
		r7 = Mcol((uint)(S[t2 & 0xFF] ^ (S[(r3 >> 8) & 0xFF] << 8) ^ (S[(t0 >> 16) & 0xFF] << 16) ^ (S[(t1 >> 24) & 0xFF] << 24))) ^ kw[2];
		r3 = Mcol((uint)(S[r3 & 0xFF] ^ (S[(t0 >> 8) & 0xFF] << 8) ^ (S[(t1 >> 16) & 0xFF] << 16) ^ (S[(t2 >> 24) & 0xFF] << 24))) ^ kw[3];
		kw = KW[r4];
		C0 = (uint)(S[r5 & 0xFF] ^ (S[(r6 >> 8) & 0xFF] << 8) ^ (S[(r7 >> 16) & 0xFF] << 16) ^ (S[(r3 >> 24) & 0xFF] << 24)) ^ kw[0];
		C1 = (uint)(S[r6 & 0xFF] ^ (S[(r7 >> 8) & 0xFF] << 8) ^ (S[(r3 >> 16) & 0xFF] << 16) ^ (S[(r5 >> 24) & 0xFF] << 24)) ^ kw[1];
		C2 = (uint)(S[r7 & 0xFF] ^ (S[(r3 >> 8) & 0xFF] << 8) ^ (S[(r5 >> 16) & 0xFF] << 16) ^ (S[(r6 >> 24) & 0xFF] << 24)) ^ kw[2];
		int n = S[r3 & 0xFF] ^ (S[(r5 >> 8) & 0xFF] << 8) ^ (S[(r6 >> 16) & 0xFF] << 16) ^ (S[(r7 >> 24) & 0xFF] << 24) ^ (int)kw[3];
		Pack.UInt32_To_LE(C0, output, outOff);
		Pack.UInt32_To_LE(C1, output, outOff + 4);
		Pack.UInt32_To_LE(C2, output, outOff + 8);
		Pack.UInt32_To_LE((uint)n, output, outOff + 12);
	}

	private void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff, uint[][] KW)
	{
		uint C0 = Pack.LE_To_UInt32(input, inOff);
		uint C1 = Pack.LE_To_UInt32(input, inOff + 4);
		uint C2 = Pack.LE_To_UInt32(input, inOff + 8);
		uint num = Pack.LE_To_UInt32(input, inOff + 12);
		uint[] kw = KW[ROUNDS];
		uint t0 = C0 ^ kw[0];
		uint t1 = C1 ^ kw[1];
		uint t2 = C2 ^ kw[2];
		uint r3 = num ^ kw[3];
		int r4 = ROUNDS - 1;
		uint r5;
		uint r6;
		uint r7;
		while (r4 > 1)
		{
			kw = KW[r4--];
			r5 = Inv_Mcol((uint)(Si[t0 & 0xFF] ^ (Si[(r3 >> 8) & 0xFF] << 8) ^ (Si[(t2 >> 16) & 0xFF] << 16) ^ (Si[(t1 >> 24) & 0xFF] << 24))) ^ kw[0];
			r6 = Inv_Mcol((uint)(Si[t1 & 0xFF] ^ (Si[(t0 >> 8) & 0xFF] << 8) ^ (Si[(r3 >> 16) & 0xFF] << 16) ^ (Si[(t2 >> 24) & 0xFF] << 24))) ^ kw[1];
			r7 = Inv_Mcol((uint)(Si[t2 & 0xFF] ^ (Si[(t1 >> 8) & 0xFF] << 8) ^ (Si[(t0 >> 16) & 0xFF] << 16) ^ (Si[(r3 >> 24) & 0xFF] << 24))) ^ kw[2];
			r3 = Inv_Mcol((uint)(Si[r3 & 0xFF] ^ (Si[(t2 >> 8) & 0xFF] << 8) ^ (Si[(t1 >> 16) & 0xFF] << 16) ^ (Si[(t0 >> 24) & 0xFF] << 24))) ^ kw[3];
			kw = KW[r4--];
			t0 = Inv_Mcol((uint)(Si[r5 & 0xFF] ^ (Si[(r3 >> 8) & 0xFF] << 8) ^ (Si[(r7 >> 16) & 0xFF] << 16) ^ (Si[(r6 >> 24) & 0xFF] << 24))) ^ kw[0];
			t1 = Inv_Mcol((uint)(Si[r6 & 0xFF] ^ (Si[(r5 >> 8) & 0xFF] << 8) ^ (Si[(r3 >> 16) & 0xFF] << 16) ^ (Si[(r7 >> 24) & 0xFF] << 24))) ^ kw[1];
			t2 = Inv_Mcol((uint)(Si[r7 & 0xFF] ^ (Si[(r6 >> 8) & 0xFF] << 8) ^ (Si[(r5 >> 16) & 0xFF] << 16) ^ (Si[(r3 >> 24) & 0xFF] << 24))) ^ kw[2];
			r3 = Inv_Mcol((uint)(Si[r3 & 0xFF] ^ (Si[(r7 >> 8) & 0xFF] << 8) ^ (Si[(r6 >> 16) & 0xFF] << 16) ^ (Si[(r5 >> 24) & 0xFF] << 24))) ^ kw[3];
		}
		kw = KW[1];
		r5 = Inv_Mcol((uint)(Si[t0 & 0xFF] ^ (Si[(r3 >> 8) & 0xFF] << 8) ^ (Si[(t2 >> 16) & 0xFF] << 16) ^ (Si[(t1 >> 24) & 0xFF] << 24))) ^ kw[0];
		r6 = Inv_Mcol((uint)(Si[t1 & 0xFF] ^ (Si[(t0 >> 8) & 0xFF] << 8) ^ (Si[(r3 >> 16) & 0xFF] << 16) ^ (Si[(t2 >> 24) & 0xFF] << 24))) ^ kw[1];
		r7 = Inv_Mcol((uint)(Si[t2 & 0xFF] ^ (Si[(t1 >> 8) & 0xFF] << 8) ^ (Si[(t0 >> 16) & 0xFF] << 16) ^ (Si[(r3 >> 24) & 0xFF] << 24))) ^ kw[2];
		r3 = Inv_Mcol((uint)(Si[r3 & 0xFF] ^ (Si[(t2 >> 8) & 0xFF] << 8) ^ (Si[(t1 >> 16) & 0xFF] << 16) ^ (Si[(t0 >> 24) & 0xFF] << 24))) ^ kw[3];
		kw = KW[0];
		C0 = (uint)(Si[r5 & 0xFF] ^ (Si[(r3 >> 8) & 0xFF] << 8) ^ (Si[(r7 >> 16) & 0xFF] << 16) ^ (Si[(r6 >> 24) & 0xFF] << 24)) ^ kw[0];
		C1 = (uint)(Si[r6 & 0xFF] ^ (Si[(r5 >> 8) & 0xFF] << 8) ^ (Si[(r3 >> 16) & 0xFF] << 16) ^ (Si[(r7 >> 24) & 0xFF] << 24)) ^ kw[1];
		C2 = (uint)(Si[r7 & 0xFF] ^ (Si[(r6 >> 8) & 0xFF] << 8) ^ (Si[(r5 >> 16) & 0xFF] << 16) ^ (Si[(r3 >> 24) & 0xFF] << 24)) ^ kw[2];
		int n = Si[r3 & 0xFF] ^ (Si[(r7 >> 8) & 0xFF] << 8) ^ (Si[(r6 >> 16) & 0xFF] << 16) ^ (Si[(r5 >> 24) & 0xFF] << 24) ^ (int)kw[3];
		Pack.UInt32_To_LE(C0, output, outOff);
		Pack.UInt32_To_LE(C1, output, outOff + 4);
		Pack.UInt32_To_LE(C2, output, outOff + 8);
		Pack.UInt32_To_LE((uint)n, output, outOff + 12);
	}
}
