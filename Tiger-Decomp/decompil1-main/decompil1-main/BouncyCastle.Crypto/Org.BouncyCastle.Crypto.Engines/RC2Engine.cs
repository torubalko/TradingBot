using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RC2Engine : IBlockCipher
{
	private static readonly byte[] piTable = new byte[256]
	{
		217, 120, 249, 196, 25, 221, 181, 237, 40, 233,
		253, 121, 74, 160, 216, 157, 198, 126, 55, 131,
		43, 118, 83, 142, 98, 76, 100, 136, 68, 139,
		251, 162, 23, 154, 89, 245, 135, 179, 79, 19,
		97, 69, 109, 141, 9, 129, 125, 50, 189, 143,
		64, 235, 134, 183, 123, 11, 240, 149, 33, 34,
		92, 107, 78, 130, 84, 214, 101, 147, 206, 96,
		178, 28, 115, 86, 192, 20, 167, 140, 241, 220,
		18, 117, 202, 31, 59, 190, 228, 209, 66, 61,
		212, 48, 163, 60, 182, 38, 111, 191, 14, 218,
		70, 105, 7, 87, 39, 242, 29, 155, 188, 148,
		67, 3, 248, 17, 199, 246, 144, 239, 62, 231,
		6, 195, 213, 47, 200, 102, 30, 215, 8, 232,
		234, 222, 128, 82, 238, 247, 132, 170, 114, 172,
		53, 77, 106, 42, 150, 26, 210, 113, 90, 21,
		73, 116, 75, 159, 208, 94, 4, 24, 164, 236,
		194, 224, 65, 110, 15, 81, 203, 204, 36, 145,
		175, 80, 161, 244, 112, 57, 153, 124, 58, 133,
		35, 184, 180, 122, 252, 2, 54, 91, 37, 85,
		151, 49, 45, 93, 250, 152, 227, 138, 146, 174,
		5, 223, 41, 16, 103, 108, 186, 201, 211, 0,
		230, 207, 225, 158, 168, 44, 99, 22, 1, 63,
		88, 226, 137, 169, 13, 56, 52, 27, 171, 51,
		255, 176, 187, 72, 12, 95, 185, 177, 205, 46,
		197, 243, 219, 71, 229, 165, 156, 119, 10, 166,
		32, 104, 254, 127, 193, 173
	};

	private const int BLOCK_SIZE = 8;

	private int[] workingKey;

	private bool encrypting;

	public virtual string AlgorithmName => "RC2";

	public virtual bool IsPartialBlockOkay => false;

	private int[] GenerateWorkingKey(byte[] key, int bits)
	{
		int[] xKey = new int[128];
		for (int i = 0; i != key.Length; i++)
		{
			xKey[i] = key[i] & 0xFF;
		}
		int len = key.Length;
		int x;
		if (len < 128)
		{
			int index = 0;
			x = xKey[len - 1];
			do
			{
				x = piTable[(x + xKey[index++]) & 0xFF] & 0xFF;
				xKey[len++] = x;
			}
			while (len < 128);
		}
		len = bits + 7 >> 3;
		x = (xKey[128 - len] = piTable[xKey[128 - len] & (255 >> (7 & -bits))] & 0xFF);
		for (int i2 = 128 - len - 1; i2 >= 0; i2--)
		{
			x = (xKey[i2] = piTable[x ^ xKey[i2 + len]] & 0xFF);
		}
		int[] newKey = new int[64];
		for (int j = 0; j != newKey.Length; j++)
		{
			newKey[j] = xKey[2 * j] + (xKey[2 * j + 1] << 8);
		}
		return newKey;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		encrypting = forEncryption;
		if (parameters is RC2Parameters)
		{
			RC2Parameters param = (RC2Parameters)parameters;
			workingKey = GenerateWorkingKey(param.GetKey(), param.EffectiveKeyBits);
			return;
		}
		if (parameters is KeyParameter)
		{
			byte[] key = ((KeyParameter)parameters).GetKey();
			workingKey = GenerateWorkingKey(key, key.Length * 8);
			return;
		}
		throw new ArgumentException("invalid parameter passed to RC2 init - " + Platform.GetTypeName(parameters));
	}

	public virtual void Reset()
	{
	}

	public virtual int GetBlockSize()
	{
		return 8;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey == null)
		{
			throw new InvalidOperationException("RC2 engine not initialised");
		}
		Check.DataLength(input, inOff, 8, "input buffer too short");
		Check.OutputLength(output, outOff, 8, "output buffer too short");
		if (encrypting)
		{
			EncryptBlock(input, inOff, output, outOff);
		}
		else
		{
			DecryptBlock(input, inOff, output, outOff);
		}
		return 8;
	}

	private int RotateWordLeft(int x, int y)
	{
		x &= 0xFFFF;
		return (x << y) | (x >> 16 - y);
	}

	private void EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int x76 = ((input[inOff + 7] & 0xFF) << 8) + (input[inOff + 6] & 0xFF);
		int x77 = ((input[inOff + 5] & 0xFF) << 8) + (input[inOff + 4] & 0xFF);
		int x78 = ((input[inOff + 3] & 0xFF) << 8) + (input[inOff + 2] & 0xFF);
		int x79 = ((input[inOff + 1] & 0xFF) << 8) + (input[inOff] & 0xFF);
		for (int i = 0; i <= 16; i += 4)
		{
			x79 = RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + workingKey[i], 1);
			x78 = RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + workingKey[i + 1], 2);
			x77 = RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + workingKey[i + 2], 3);
			x76 = RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + workingKey[i + 3], 5);
		}
		x79 += workingKey[x76 & 0x3F];
		x78 += workingKey[x79 & 0x3F];
		x77 += workingKey[x78 & 0x3F];
		x76 += workingKey[x77 & 0x3F];
		for (int j = 20; j <= 40; j += 4)
		{
			x79 = RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + workingKey[j], 1);
			x78 = RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + workingKey[j + 1], 2);
			x77 = RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + workingKey[j + 2], 3);
			x76 = RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + workingKey[j + 3], 5);
		}
		x79 += workingKey[x76 & 0x3F];
		x78 += workingKey[x79 & 0x3F];
		x77 += workingKey[x78 & 0x3F];
		x76 += workingKey[x77 & 0x3F];
		for (int k = 44; k < 64; k += 4)
		{
			x79 = RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + workingKey[k], 1);
			x78 = RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + workingKey[k + 1], 2);
			x77 = RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + workingKey[k + 2], 3);
			x76 = RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + workingKey[k + 3], 5);
		}
		outBytes[outOff] = (byte)x79;
		outBytes[outOff + 1] = (byte)(x79 >> 8);
		outBytes[outOff + 2] = (byte)x78;
		outBytes[outOff + 3] = (byte)(x78 >> 8);
		outBytes[outOff + 4] = (byte)x77;
		outBytes[outOff + 5] = (byte)(x77 >> 8);
		outBytes[outOff + 6] = (byte)x76;
		outBytes[outOff + 7] = (byte)(x76 >> 8);
	}

	private void DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int x76 = ((input[inOff + 7] & 0xFF) << 8) + (input[inOff + 6] & 0xFF);
		int x77 = ((input[inOff + 5] & 0xFF) << 8) + (input[inOff + 4] & 0xFF);
		int x78 = ((input[inOff + 3] & 0xFF) << 8) + (input[inOff + 2] & 0xFF);
		int x79 = ((input[inOff + 1] & 0xFF) << 8) + (input[inOff] & 0xFF);
		for (int i = 60; i >= 44; i -= 4)
		{
			x76 = RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + workingKey[i + 3]);
			x77 = RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + workingKey[i + 2]);
			x78 = RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + workingKey[i + 1]);
			x79 = RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + workingKey[i]);
		}
		x76 -= workingKey[x77 & 0x3F];
		x77 -= workingKey[x78 & 0x3F];
		x78 -= workingKey[x79 & 0x3F];
		x79 -= workingKey[x76 & 0x3F];
		for (int i2 = 40; i2 >= 20; i2 -= 4)
		{
			x76 = RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + workingKey[i2 + 3]);
			x77 = RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + workingKey[i2 + 2]);
			x78 = RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + workingKey[i2 + 1]);
			x79 = RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + workingKey[i2]);
		}
		x76 -= workingKey[x77 & 0x3F];
		x77 -= workingKey[x78 & 0x3F];
		x78 -= workingKey[x79 & 0x3F];
		x79 -= workingKey[x76 & 0x3F];
		for (int i3 = 16; i3 >= 0; i3 -= 4)
		{
			x76 = RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + workingKey[i3 + 3]);
			x77 = RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + workingKey[i3 + 2]);
			x78 = RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + workingKey[i3 + 1]);
			x79 = RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + workingKey[i3]);
		}
		outBytes[outOff] = (byte)x79;
		outBytes[outOff + 1] = (byte)(x79 >> 8);
		outBytes[outOff + 2] = (byte)x78;
		outBytes[outOff + 3] = (byte)(x78 >> 8);
		outBytes[outOff + 4] = (byte)x77;
		outBytes[outOff + 5] = (byte)(x77 >> 8);
		outBytes[outOff + 6] = (byte)x76;
		outBytes[outOff + 7] = (byte)(x76 >> 8);
	}
}
