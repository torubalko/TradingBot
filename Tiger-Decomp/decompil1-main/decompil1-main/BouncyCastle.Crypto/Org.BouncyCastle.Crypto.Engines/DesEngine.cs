using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class DesEngine : IBlockCipher
{
	internal const int BLOCK_SIZE = 8;

	private int[] workingKey;

	private static readonly short[] bytebit = new short[8] { 128, 64, 32, 16, 8, 4, 2, 1 };

	private static readonly int[] bigbyte = new int[24]
	{
		8388608, 4194304, 2097152, 1048576, 524288, 262144, 131072, 65536, 32768, 16384,
		8192, 4096, 2048, 1024, 512, 256, 128, 64, 32, 16,
		8, 4, 2, 1
	};

	private static readonly byte[] pc1 = new byte[56]
	{
		56, 48, 40, 32, 24, 16, 8, 0, 57, 49,
		41, 33, 25, 17, 9, 1, 58, 50, 42, 34,
		26, 18, 10, 2, 59, 51, 43, 35, 62, 54,
		46, 38, 30, 22, 14, 6, 61, 53, 45, 37,
		29, 21, 13, 5, 60, 52, 44, 36, 28, 20,
		12, 4, 27, 19, 11, 3
	};

	private static readonly byte[] totrot = new byte[16]
	{
		1, 2, 4, 6, 8, 10, 12, 14, 15, 17,
		19, 21, 23, 25, 27, 28
	};

	private static readonly byte[] pc2 = new byte[48]
	{
		13, 16, 10, 23, 0, 4, 2, 27, 14, 5,
		20, 9, 22, 18, 11, 3, 25, 7, 15, 6,
		26, 19, 12, 1, 40, 51, 30, 36, 46, 54,
		29, 39, 50, 44, 32, 47, 43, 48, 38, 55,
		33, 52, 45, 41, 49, 35, 28, 31
	};

	private static readonly uint[] SP1 = new uint[64]
	{
		16843776u, 0u, 65536u, 16843780u, 16842756u, 66564u, 4u, 65536u, 1024u, 16843776u,
		16843780u, 1024u, 16778244u, 16842756u, 16777216u, 4u, 1028u, 16778240u, 16778240u, 66560u,
		66560u, 16842752u, 16842752u, 16778244u, 65540u, 16777220u, 16777220u, 65540u, 0u, 1028u,
		66564u, 16777216u, 65536u, 16843780u, 4u, 16842752u, 16843776u, 16777216u, 16777216u, 1024u,
		16842756u, 65536u, 66560u, 16777220u, 1024u, 4u, 16778244u, 66564u, 16843780u, 65540u,
		16842752u, 16778244u, 16777220u, 1028u, 66564u, 16843776u, 1028u, 16778240u, 16778240u, 0u,
		65540u, 66560u, 0u, 16842756u
	};

	private static readonly uint[] SP2 = new uint[64]
	{
		2148565024u, 2147516416u, 32768u, 1081376u, 1048576u, 32u, 2148532256u, 2147516448u, 2147483680u, 2148565024u,
		2148564992u, 2147483648u, 2147516416u, 1048576u, 32u, 2148532256u, 1081344u, 1048608u, 2147516448u, 0u,
		2147483648u, 32768u, 1081376u, 2148532224u, 1048608u, 2147483680u, 0u, 1081344u, 32800u, 2148564992u,
		2148532224u, 32800u, 0u, 1081376u, 2148532256u, 1048576u, 2147516448u, 2148532224u, 2148564992u, 32768u,
		2148532224u, 2147516416u, 32u, 2148565024u, 1081376u, 32u, 32768u, 2147483648u, 32800u, 2148564992u,
		1048576u, 2147483680u, 1048608u, 2147516448u, 2147483680u, 1048608u, 1081344u, 0u, 2147516416u, 32800u,
		2147483648u, 2148532256u, 2148565024u, 1081344u
	};

	private static readonly uint[] SP3 = new uint[64]
	{
		520u, 134349312u, 0u, 134348808u, 134218240u, 0u, 131592u, 134218240u, 131080u, 134217736u,
		134217736u, 131072u, 134349320u, 131080u, 134348800u, 520u, 134217728u, 8u, 134349312u, 512u,
		131584u, 134348800u, 134348808u, 131592u, 134218248u, 131584u, 131072u, 134218248u, 8u, 134349320u,
		512u, 134217728u, 134349312u, 134217728u, 131080u, 520u, 131072u, 134349312u, 134218240u, 0u,
		512u, 131080u, 134349320u, 134218240u, 134217736u, 512u, 0u, 134348808u, 134218248u, 131072u,
		134217728u, 134349320u, 8u, 131592u, 131584u, 134217736u, 134348800u, 134218248u, 520u, 134348800u,
		131592u, 8u, 134348808u, 131584u
	};

	private static readonly uint[] SP4 = new uint[64]
	{
		8396801u, 8321u, 8321u, 128u, 8396928u, 8388737u, 8388609u, 8193u, 0u, 8396800u,
		8396800u, 8396929u, 129u, 0u, 8388736u, 8388609u, 1u, 8192u, 8388608u, 8396801u,
		128u, 8388608u, 8193u, 8320u, 8388737u, 1u, 8320u, 8388736u, 8192u, 8396928u,
		8396929u, 129u, 8388736u, 8388609u, 8396800u, 8396929u, 129u, 0u, 0u, 8396800u,
		8320u, 8388736u, 8388737u, 1u, 8396801u, 8321u, 8321u, 128u, 8396929u, 129u,
		1u, 8192u, 8388609u, 8193u, 8396928u, 8388737u, 8193u, 8320u, 8388608u, 8396801u,
		128u, 8388608u, 8192u, 8396928u
	};

	private static readonly uint[] SP5 = new uint[64]
	{
		256u, 34078976u, 34078720u, 1107296512u, 524288u, 256u, 1073741824u, 34078720u, 1074266368u, 524288u,
		33554688u, 1074266368u, 1107296512u, 1107820544u, 524544u, 1073741824u, 33554432u, 1074266112u, 1074266112u, 0u,
		1073742080u, 1107820800u, 1107820800u, 33554688u, 1107820544u, 1073742080u, 0u, 1107296256u, 34078976u, 33554432u,
		1107296256u, 524544u, 524288u, 1107296512u, 256u, 33554432u, 1073741824u, 34078720u, 1107296512u, 1074266368u,
		33554688u, 1073741824u, 1107820544u, 34078976u, 1074266368u, 256u, 33554432u, 1107820544u, 1107820800u, 524544u,
		1107296256u, 1107820800u, 34078720u, 0u, 1074266112u, 1107296256u, 524544u, 33554688u, 1073742080u, 524288u,
		0u, 1074266112u, 34078976u, 1073742080u
	};

	private static readonly uint[] SP6 = new uint[64]
	{
		536870928u, 541065216u, 16384u, 541081616u, 541065216u, 16u, 541081616u, 4194304u, 536887296u, 4210704u,
		4194304u, 536870928u, 4194320u, 536887296u, 536870912u, 16400u, 0u, 4194320u, 536887312u, 16384u,
		4210688u, 536887312u, 16u, 541065232u, 541065232u, 0u, 4210704u, 541081600u, 16400u, 4210688u,
		541081600u, 536870912u, 536887296u, 16u, 541065232u, 4210688u, 541081616u, 4194304u, 16400u, 536870928u,
		4194304u, 536887296u, 536870912u, 16400u, 536870928u, 541081616u, 4210688u, 541065216u, 4210704u, 541081600u,
		0u, 541065232u, 16u, 16384u, 541065216u, 4210704u, 16384u, 4194320u, 536887312u, 0u,
		541081600u, 536870912u, 4194320u, 536887312u
	};

	private static readonly uint[] SP7 = new uint[64]
	{
		2097152u, 69206018u, 67110914u, 0u, 2048u, 67110914u, 2099202u, 69208064u, 69208066u, 2097152u,
		0u, 67108866u, 2u, 67108864u, 69206018u, 2050u, 67110912u, 2099202u, 2097154u, 67110912u,
		67108866u, 69206016u, 69208064u, 2097154u, 69206016u, 2048u, 2050u, 69208066u, 2099200u, 2u,
		67108864u, 2099200u, 67108864u, 2099200u, 2097152u, 67110914u, 67110914u, 69206018u, 69206018u, 2u,
		2097154u, 67108864u, 67110912u, 2097152u, 69208064u, 2050u, 2099202u, 69208064u, 2050u, 67108866u,
		69208066u, 69206016u, 2099200u, 0u, 2u, 69208066u, 0u, 2099202u, 69206016u, 2048u,
		67108866u, 67110912u, 2048u, 2097154u
	};

	private static readonly uint[] SP8 = new uint[64]
	{
		268439616u, 4096u, 262144u, 268701760u, 268435456u, 268439616u, 64u, 268435456u, 262208u, 268697600u,
		268701760u, 266240u, 268701696u, 266304u, 4096u, 64u, 268697600u, 268435520u, 268439552u, 4160u,
		266240u, 262208u, 268697664u, 268701696u, 4160u, 0u, 0u, 268697664u, 268435520u, 268439552u,
		266304u, 262144u, 266304u, 262144u, 268701696u, 4096u, 64u, 268697664u, 4096u, 266304u,
		268439552u, 64u, 268435520u, 268697600u, 268697664u, 268435456u, 262144u, 268439616u, 0u, 268701760u,
		262208u, 268435520u, 268697600u, 268439552u, 268439616u, 0u, 268701760u, 266240u, 266240u, 4160u,
		4160u, 262208u, 268435456u, 268701696u
	};

	public virtual string AlgorithmName => "DES";

	public virtual bool IsPartialBlockOkay => false;

	public virtual int[] GetWorkingKey()
	{
		return workingKey;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to DES init - " + Platform.GetTypeName(parameters));
		}
		workingKey = GenerateWorkingKey(forEncryption, ((KeyParameter)parameters).GetKey());
	}

	public virtual int GetBlockSize()
	{
		return 8;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey == null)
		{
			throw new InvalidOperationException("DES engine not initialised");
		}
		Check.DataLength(input, inOff, 8, "input buffer too short");
		Check.OutputLength(output, outOff, 8, "output buffer too short");
		DesFunc(workingKey, input, inOff, output, outOff);
		return 8;
	}

	public virtual void Reset()
	{
	}

	protected static int[] GenerateWorkingKey(bool encrypting, byte[] key)
	{
		int[] newKey = new int[32];
		bool[] pc1m = new bool[56];
		bool[] pcr = new bool[56];
		for (int j = 0; j < 56; j++)
		{
			int l = pc1[j];
			pc1m[j] = (key[l >>> 3] & bytebit[l & 7]) != 0;
		}
		for (int i = 0; i < 16; i++)
		{
			int m = ((!encrypting) ? (15 - i << 1) : (i << 1));
			int n = m + 1;
			newKey[m] = (newKey[n] = 0);
			for (int k = 0; k < 28; k++)
			{
				int l2 = k + totrot[i];
				if (l2 < 28)
				{
					pcr[k] = pc1m[l2];
				}
				else
				{
					pcr[k] = pc1m[l2 - 28];
				}
			}
			for (int num = 28; num < 56; num++)
			{
				int l2 = num + totrot[i];
				if (l2 < 56)
				{
					pcr[num] = pc1m[l2];
				}
				else
				{
					pcr[num] = pc1m[l2 - 28];
				}
			}
			for (int num2 = 0; num2 < 24; num2++)
			{
				if (pcr[pc2[num2]])
				{
					newKey[m] |= bigbyte[num2];
				}
				if (pcr[pc2[num2 + 24]])
				{
					newKey[n] |= bigbyte[num2];
				}
			}
		}
		for (int num3 = 0; num3 != 32; num3 += 2)
		{
			int i2 = newKey[num3];
			int i3 = newKey[num3 + 1];
			newKey[num3] = ((i2 & 0xFC0000) << 6) | ((i2 & 0xFC0) << 10) | ((i3 & 0xFC0000) >>> 10) | ((i3 & 0xFC0) >>> 6);
			newKey[num3 + 1] = ((i2 & 0x3F000) << 12) | ((i2 & 0x3F) << 16) | ((i3 & 0x3F000) >>> 4) | (i3 & 0x3F);
		}
		return newKey;
	}

	internal static void DesFunc(int[] wKey, byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		uint left = Pack.BE_To_UInt32(input, inOff);
		uint right = Pack.BE_To_UInt32(input, inOff + 4);
		uint work = ((left >> 4) ^ right) & 0xF0F0F0F;
		right ^= work;
		left ^= work << 4;
		work = ((left >> 16) ^ right) & 0xFFFF;
		right ^= work;
		left ^= work << 16;
		work = ((right >> 2) ^ left) & 0x33333333;
		left ^= work;
		right ^= work << 2;
		work = ((right >> 8) ^ left) & 0xFF00FF;
		left ^= work;
		right ^= work << 8;
		right = (right << 1) | (right >> 31);
		work = (left ^ right) & 0xAAAAAAAAu;
		left ^= work;
		right ^= work;
		left = (left << 1) | (left >> 31);
		for (int round = 0; round < 8; round++)
		{
			work = (right << 28) | (right >> 4);
			work ^= (uint)wKey[round * 4];
			uint fval = SP7[work & 0x3F];
			fval |= SP5[(work >> 8) & 0x3F];
			fval |= SP3[(work >> 16) & 0x3F];
			fval |= SP1[(work >> 24) & 0x3F];
			work = right ^ (uint)wKey[round * 4 + 1];
			fval |= SP8[work & 0x3F];
			fval |= SP6[(work >> 8) & 0x3F];
			fval |= SP4[(work >> 16) & 0x3F];
			fval |= SP2[(work >> 24) & 0x3F];
			left ^= fval;
			work = (left << 28) | (left >> 4);
			work ^= (uint)wKey[round * 4 + 2];
			fval = SP7[work & 0x3F];
			fval |= SP5[(work >> 8) & 0x3F];
			fval |= SP3[(work >> 16) & 0x3F];
			fval |= SP1[(work >> 24) & 0x3F];
			work = left ^ (uint)wKey[round * 4 + 3];
			fval |= SP8[work & 0x3F];
			fval |= SP6[(work >> 8) & 0x3F];
			fval |= SP4[(work >> 16) & 0x3F];
			fval |= SP2[(work >> 24) & 0x3F];
			right ^= fval;
		}
		right = (right << 31) | (right >> 1);
		work = (left ^ right) & 0xAAAAAAAAu;
		left ^= work;
		right ^= work;
		left = (left << 31) | (left >> 1);
		work = ((left >> 8) ^ right) & 0xFF00FF;
		right ^= work;
		left ^= work << 8;
		work = ((left >> 2) ^ right) & 0x33333333;
		right ^= work;
		left ^= work << 2;
		work = ((right >> 16) ^ left) & 0xFFFF;
		left ^= work;
		right ^= work << 16;
		work = ((right >> 4) ^ left) & 0xF0F0F0F;
		left ^= work;
		right ^= work << 4;
		Pack.UInt32_To_BE(right, outBytes, outOff);
		Pack.UInt32_To_BE(left, outBytes, outOff + 4);
	}
}
