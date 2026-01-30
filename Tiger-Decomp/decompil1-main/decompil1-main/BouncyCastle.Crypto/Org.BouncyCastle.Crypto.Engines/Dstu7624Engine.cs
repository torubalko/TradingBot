using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class Dstu7624Engine : IBlockCipher
{
	private ulong[] internalState;

	private ulong[] workingKey;

	private ulong[][] roundKeys;

	private int wordsInBlock;

	private int wordsInKey;

	private const int ROUNDS_128 = 10;

	private const int ROUNDS_256 = 14;

	private const int ROUNDS_512 = 18;

	private int roundsAmount;

	private bool forEncryption;

	private const ulong mdsMatrix = 290207332435296513uL;

	private const ulong mdsInvMatrix = 14616231584692868525uL;

	private static readonly byte[] S0 = new byte[256]
	{
		168, 67, 95, 6, 107, 117, 108, 89, 113, 223,
		135, 149, 23, 240, 216, 9, 109, 243, 29, 203,
		201, 77, 44, 175, 121, 224, 151, 253, 111, 75,
		69, 57, 62, 221, 163, 79, 180, 182, 154, 14,
		31, 191, 21, 225, 73, 210, 147, 198, 146, 114,
		158, 97, 209, 99, 250, 238, 244, 25, 213, 173,
		88, 164, 187, 161, 220, 242, 131, 55, 66, 228,
		122, 50, 156, 204, 171, 74, 143, 110, 4, 39,
		46, 231, 226, 90, 150, 22, 35, 43, 194, 101,
		102, 15, 188, 169, 71, 65, 52, 72, 252, 183,
		106, 136, 165, 83, 134, 249, 91, 219, 56, 123,
		195, 30, 34, 51, 36, 40, 54, 199, 178, 59,
		142, 119, 186, 245, 20, 159, 8, 85, 155, 76,
		254, 96, 92, 218, 24, 70, 205, 125, 33, 176,
		63, 27, 137, 255, 235, 132, 105, 58, 157, 215,
		211, 112, 103, 64, 181, 222, 93, 48, 145, 177,
		120, 17, 1, 229, 0, 104, 152, 160, 197, 2,
		166, 116, 45, 11, 162, 118, 179, 190, 206, 189,
		174, 233, 138, 49, 28, 236, 241, 153, 148, 170,
		246, 38, 47, 239, 232, 140, 53, 3, 212, 127,
		251, 5, 193, 94, 144, 32, 61, 130, 247, 234,
		10, 13, 126, 248, 80, 26, 196, 7, 87, 184,
		60, 98, 227, 200, 172, 82, 100, 16, 208, 217,
		19, 12, 18, 41, 81, 185, 207, 214, 115, 141,
		129, 84, 192, 237, 78, 68, 167, 42, 133, 37,
		230, 202, 124, 139, 86, 128
	};

	private static readonly byte[] S1 = new byte[256]
	{
		206, 187, 235, 146, 234, 203, 19, 193, 233, 58,
		214, 178, 210, 144, 23, 248, 66, 21, 86, 180,
		101, 28, 136, 67, 197, 92, 54, 186, 245, 87,
		103, 141, 49, 246, 100, 88, 158, 244, 34, 170,
		117, 15, 2, 177, 223, 109, 115, 77, 124, 38,
		46, 247, 8, 93, 68, 62, 159, 20, 200, 174,
		84, 16, 216, 188, 26, 107, 105, 243, 189, 51,
		171, 250, 209, 155, 104, 78, 22, 149, 145, 238,
		76, 99, 142, 91, 204, 60, 25, 161, 129, 73,
		123, 217, 111, 55, 96, 202, 231, 43, 72, 253,
		150, 69, 252, 65, 18, 13, 121, 229, 137, 140,
		227, 32, 48, 220, 183, 108, 74, 181, 63, 151,
		212, 98, 45, 6, 164, 165, 131, 95, 42, 218,
		201, 0, 126, 162, 85, 191, 17, 213, 156, 207,
		14, 10, 61, 81, 125, 147, 27, 254, 196, 71,
		9, 134, 11, 143, 157, 106, 7, 185, 176, 152,
		24, 50, 113, 75, 239, 59, 112, 160, 228, 64,
		255, 195, 169, 230, 120, 249, 139, 70, 128, 30,
		56, 225, 184, 168, 224, 12, 35, 118, 29, 37,
		36, 5, 241, 110, 148, 40, 154, 132, 232, 163,
		79, 119, 211, 133, 226, 82, 242, 130, 80, 122,
		47, 116, 83, 179, 97, 175, 57, 53, 222, 205,
		31, 153, 172, 173, 114, 44, 221, 208, 135, 190,
		94, 166, 236, 4, 198, 3, 52, 251, 219, 89,
		182, 194, 1, 240, 90, 237, 167, 102, 33, 127,
		138, 39, 199, 192, 41, 215
	};

	private static readonly byte[] S2 = new byte[256]
	{
		147, 217, 154, 181, 152, 34, 69, 252, 186, 106,
		223, 2, 159, 220, 81, 89, 74, 23, 43, 194,
		148, 244, 187, 163, 98, 228, 113, 212, 205, 112,
		22, 225, 73, 60, 192, 216, 92, 155, 173, 133,
		83, 161, 122, 200, 45, 224, 209, 114, 166, 44,
		196, 227, 118, 120, 183, 180, 9, 59, 14, 65,
		76, 222, 178, 144, 37, 165, 215, 3, 17, 0,
		195, 46, 146, 239, 78, 18, 157, 125, 203, 53,
		16, 213, 79, 158, 77, 169, 85, 198, 208, 123,
		24, 151, 211, 54, 230, 72, 86, 129, 143, 119,
		204, 156, 185, 226, 172, 184, 47, 21, 164, 124,
		218, 56, 30, 11, 5, 214, 20, 110, 108, 126,
		102, 253, 177, 229, 96, 175, 94, 51, 135, 201,
		240, 93, 109, 63, 136, 141, 199, 247, 29, 233,
		236, 237, 128, 41, 39, 207, 153, 168, 80, 15,
		55, 36, 40, 48, 149, 210, 62, 91, 64, 131,
		179, 105, 87, 31, 7, 28, 138, 188, 32, 235,
		206, 142, 171, 238, 49, 162, 115, 249, 202, 58,
		26, 251, 13, 193, 254, 250, 242, 111, 189, 150,
		221, 67, 82, 182, 8, 243, 174, 190, 25, 137,
		50, 38, 176, 234, 75, 100, 132, 130, 107, 245,
		121, 191, 1, 95, 117, 99, 27, 35, 61, 104,
		42, 101, 232, 145, 246, 255, 19, 88, 241, 71,
		10, 127, 197, 167, 231, 97, 90, 6, 70, 68,
		66, 4, 160, 219, 57, 134, 84, 170, 140, 52,
		33, 139, 248, 12, 116, 103
	};

	private static readonly byte[] S3 = new byte[256]
	{
		104, 141, 202, 77, 115, 75, 78, 42, 212, 82,
		38, 179, 84, 30, 25, 31, 34, 3, 70, 61,
		45, 74, 83, 131, 19, 138, 183, 213, 37, 121,
		245, 189, 88, 47, 13, 2, 237, 81, 158, 17,
		242, 62, 85, 94, 209, 22, 60, 102, 112, 93,
		243, 69, 64, 204, 232, 148, 86, 8, 206, 26,
		58, 210, 225, 223, 181, 56, 110, 14, 229, 244,
		249, 134, 233, 79, 214, 133, 35, 207, 50, 153,
		49, 20, 174, 238, 200, 72, 211, 48, 161, 146,
		65, 177, 24, 196, 44, 113, 114, 68, 21, 253,
		55, 190, 95, 170, 155, 136, 216, 171, 137, 156,
		250, 96, 234, 188, 98, 12, 36, 166, 168, 236,
		103, 32, 219, 124, 40, 221, 172, 91, 52, 126,
		16, 241, 123, 143, 99, 160, 5, 154, 67, 119,
		33, 191, 39, 9, 195, 159, 182, 215, 41, 194,
		235, 192, 164, 139, 140, 29, 251, 255, 193, 178,
		151, 46, 248, 101, 246, 117, 7, 4, 73, 51,
		228, 217, 185, 208, 66, 199, 108, 144, 0, 142,
		111, 80, 1, 197, 218, 71, 63, 205, 105, 162,
		226, 122, 167, 198, 147, 15, 10, 6, 230, 43,
		150, 163, 28, 175, 106, 18, 132, 57, 231, 176,
		130, 247, 254, 157, 135, 92, 129, 53, 222, 180,
		165, 252, 128, 239, 203, 187, 107, 118, 186, 90,
		125, 120, 11, 149, 227, 173, 116, 152, 59, 54,
		100, 109, 220, 240, 89, 169, 76, 23, 127, 145,
		184, 201, 87, 27, 224, 97
	};

	private static readonly byte[] T0 = new byte[256]
	{
		164, 162, 169, 197, 78, 201, 3, 217, 126, 15,
		210, 173, 231, 211, 39, 91, 227, 161, 232, 230,
		124, 42, 85, 12, 134, 57, 215, 141, 184, 18,
		111, 40, 205, 138, 112, 86, 114, 249, 191, 79,
		115, 233, 247, 87, 22, 172, 80, 192, 157, 183,
		71, 113, 96, 196, 116, 67, 108, 31, 147, 119,
		220, 206, 32, 140, 153, 95, 68, 1, 245, 30,
		135, 94, 97, 44, 75, 29, 129, 21, 244, 35,
		214, 234, 225, 103, 241, 127, 254, 218, 60, 7,
		83, 106, 132, 156, 203, 2, 131, 51, 221, 53,
		226, 89, 90, 152, 165, 146, 100, 4, 6, 16,
		77, 28, 151, 8, 49, 238, 171, 5, 175, 121,
		160, 24, 70, 109, 252, 137, 212, 199, 255, 240,
		207, 66, 145, 248, 104, 10, 101, 142, 182, 253,
		195, 239, 120, 76, 204, 158, 48, 46, 188, 11,
		84, 26, 166, 187, 38, 128, 72, 148, 50, 125,
		167, 63, 174, 34, 61, 102, 170, 246, 0, 93,
		189, 74, 224, 59, 180, 23, 139, 159, 118, 176,
		36, 154, 37, 99, 219, 235, 122, 62, 92, 179,
		177, 41, 242, 202, 88, 110, 216, 168, 47, 117,
		223, 20, 251, 19, 73, 136, 178, 236, 228, 52,
		45, 150, 198, 58, 237, 149, 14, 229, 133, 107,
		64, 33, 155, 9, 25, 43, 82, 222, 69, 163,
		250, 81, 194, 181, 209, 144, 185, 243, 55, 193,
		13, 186, 65, 17, 56, 123, 190, 208, 213, 105,
		54, 200, 98, 27, 130, 143
	};

	private static readonly byte[] T1 = new byte[256]
	{
		131, 242, 42, 235, 233, 191, 123, 156, 52, 150,
		141, 152, 185, 105, 140, 41, 61, 136, 104, 6,
		57, 17, 76, 14, 160, 86, 64, 146, 21, 188,
		179, 220, 111, 248, 38, 186, 190, 189, 49, 251,
		195, 254, 128, 97, 225, 122, 50, 210, 112, 32,
		161, 69, 236, 217, 26, 93, 180, 216, 9, 165,
		85, 142, 55, 118, 169, 103, 16, 23, 54, 101,
		177, 149, 98, 89, 116, 163, 80, 47, 75, 200,
		208, 143, 205, 212, 60, 134, 18, 29, 35, 239,
		244, 83, 25, 53, 230, 127, 94, 214, 121, 81,
		34, 20, 247, 30, 74, 66, 155, 65, 115, 45,
		193, 92, 166, 162, 224, 46, 211, 40, 187, 201,
		174, 106, 209, 90, 48, 144, 132, 249, 178, 88,
		207, 126, 197, 203, 151, 228, 22, 108, 250, 176,
		109, 31, 82, 153, 13, 78, 3, 145, 194, 77,
		100, 119, 159, 221, 196, 73, 138, 154, 36, 56,
		167, 87, 133, 199, 124, 125, 231, 246, 183, 172,
		39, 70, 222, 223, 59, 215, 158, 43, 11, 213,
		19, 117, 240, 114, 182, 157, 27, 1, 63, 68,
		229, 135, 253, 7, 241, 171, 148, 24, 234, 252,
		58, 130, 95, 5, 84, 219, 0, 139, 227, 72,
		12, 202, 120, 137, 10, 255, 62, 91, 129, 238,
		113, 226, 218, 44, 184, 181, 204, 110, 168, 107,
		173, 96, 198, 8, 4, 2, 232, 245, 79, 164,
		243, 192, 206, 67, 37, 28, 33, 51, 15, 175,
		71, 237, 102, 99, 147, 170
	};

	private static readonly byte[] T2 = new byte[256]
	{
		69, 212, 11, 67, 241, 114, 237, 164, 194, 56,
		230, 113, 253, 182, 58, 149, 80, 68, 75, 226,
		116, 107, 30, 17, 90, 198, 180, 216, 165, 138,
		112, 163, 168, 250, 5, 217, 151, 64, 201, 144,
		152, 143, 220, 18, 49, 44, 71, 106, 153, 174,
		200, 127, 249, 79, 93, 150, 111, 244, 179, 57,
		33, 218, 156, 133, 158, 59, 240, 191, 239, 6,
		238, 229, 95, 32, 16, 204, 60, 84, 74, 82,
		148, 14, 192, 40, 246, 86, 96, 162, 227, 15,
		236, 157, 36, 131, 126, 213, 124, 235, 24, 215,
		205, 221, 120, 255, 219, 161, 9, 208, 118, 132,
		117, 187, 29, 26, 47, 176, 254, 214, 52, 99,
		53, 210, 42, 89, 109, 77, 119, 231, 142, 97,
		207, 159, 206, 39, 245, 128, 134, 199, 166, 251,
		248, 135, 171, 98, 63, 223, 72, 0, 20, 154,
		189, 91, 4, 146, 2, 37, 101, 76, 83, 12,
		242, 41, 175, 23, 108, 65, 48, 233, 147, 85,
		247, 172, 104, 38, 196, 125, 202, 122, 62, 160,
		55, 3, 193, 54, 105, 102, 8, 22, 167, 188,
		197, 211, 34, 183, 19, 70, 50, 232, 87, 136,
		43, 129, 178, 78, 100, 28, 170, 145, 88, 46,
		155, 92, 27, 81, 115, 66, 35, 1, 110, 243,
		13, 190, 61, 10, 45, 31, 103, 51, 25, 123,
		94, 234, 222, 139, 203, 169, 140, 141, 173, 73,
		130, 228, 186, 195, 21, 209, 224, 137, 252, 177,
		185, 181, 7, 121, 184, 225
	};

	private static readonly byte[] T3 = new byte[256]
	{
		178, 182, 35, 17, 167, 136, 197, 166, 57, 143,
		196, 232, 115, 34, 67, 195, 130, 39, 205, 24,
		81, 98, 45, 247, 92, 14, 59, 253, 202, 155,
		13, 15, 121, 140, 16, 76, 116, 28, 10, 142,
		124, 148, 7, 199, 94, 20, 161, 33, 87, 80,
		78, 169, 128, 217, 239, 100, 65, 207, 60, 238,
		46, 19, 41, 186, 52, 90, 174, 138, 97, 51,
		18, 185, 85, 168, 21, 5, 246, 3, 6, 73,
		181, 37, 9, 22, 12, 42, 56, 252, 32, 244,
		229, 127, 215, 49, 43, 102, 111, 255, 114, 134,
		240, 163, 47, 120, 0, 188, 204, 226, 176, 241,
		66, 180, 48, 95, 96, 4, 236, 165, 227, 139,
		231, 29, 191, 132, 123, 230, 129, 248, 222, 216,
		210, 23, 206, 75, 71, 214, 105, 108, 25, 153,
		154, 1, 179, 133, 177, 249, 89, 194, 55, 233,
		200, 160, 237, 79, 137, 104, 109, 213, 38, 145,
		135, 88, 189, 201, 152, 220, 117, 192, 118, 245,
		103, 107, 126, 235, 82, 203, 209, 91, 159, 11,
		219, 64, 146, 26, 250, 172, 228, 225, 113, 31,
		101, 141, 151, 158, 149, 144, 93, 183, 193, 175,
		84, 251, 2, 224, 53, 187, 58, 77, 173, 44,
		61, 86, 8, 27, 74, 147, 106, 171, 184, 122,
		242, 125, 218, 63, 254, 62, 190, 234, 170, 68,
		198, 208, 54, 72, 112, 150, 119, 36, 83, 223,
		243, 131, 40, 50, 69, 30, 164, 211, 162, 70,
		110, 156, 221, 99, 212, 157
	};

	public virtual string AlgorithmName => "DSTU7624";

	public virtual bool IsPartialBlockOkay => false;

	public Dstu7624Engine(int blockSizeBits)
	{
		if (blockSizeBits != 128 && blockSizeBits != 256 && blockSizeBits != 512)
		{
			throw new ArgumentException("unsupported block length: only 128/256/512 are allowed");
		}
		wordsInBlock = blockSizeBits / 64;
		internalState = new ulong[wordsInBlock];
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("Invalid parameter passed to Dstu7624Engine Init");
		}
		this.forEncryption = forEncryption;
		byte[] keyBytes = ((KeyParameter)parameters).GetKey();
		int keyBitLength = keyBytes.Length << 3;
		int blockBitLength = wordsInBlock << 6;
		if (keyBitLength != 128 && keyBitLength != 256 && keyBitLength != 512)
		{
			throw new ArgumentException("unsupported key length: only 128/256/512 are allowed");
		}
		if (keyBitLength != blockBitLength && keyBitLength != 2 * blockBitLength)
		{
			throw new ArgumentException("Unsupported key length");
		}
		switch (keyBitLength)
		{
		case 128:
			roundsAmount = 10;
			break;
		case 256:
			roundsAmount = 14;
			break;
		case 512:
			roundsAmount = 18;
			break;
		}
		wordsInKey = keyBitLength / 64;
		roundKeys = new ulong[roundsAmount + 1][];
		for (int roundKeyIndex = 0; roundKeyIndex < roundKeys.Length; roundKeyIndex++)
		{
			roundKeys[roundKeyIndex] = new ulong[wordsInBlock];
		}
		workingKey = new ulong[wordsInKey];
		if (keyBytes.Length != wordsInKey * 8)
		{
			throw new ArgumentException("Invalid key parameter passed to Dstu7624Engine Init");
		}
		Pack.LE_To_UInt64(keyBytes, 0, workingKey);
		ulong[] tempKeys = new ulong[wordsInBlock];
		WorkingKeyExpandKT(workingKey, tempKeys);
		WorkingKeyExpandEven(workingKey, tempKeys);
		WorkingKeyExpandOdd();
	}

	private void WorkingKeyExpandKT(ulong[] workingKey, ulong[] tempKeys)
	{
		ulong[] k0 = new ulong[wordsInBlock];
		ulong[] k1 = new ulong[wordsInBlock];
		internalState = new ulong[wordsInBlock];
		internalState[0] += (ulong)(wordsInBlock + wordsInKey + 1);
		if (wordsInBlock == wordsInKey)
		{
			Array.Copy(workingKey, 0, k0, 0, k0.Length);
			Array.Copy(workingKey, 0, k1, 0, k1.Length);
		}
		else
		{
			Array.Copy(workingKey, 0, k0, 0, wordsInBlock);
			Array.Copy(workingKey, wordsInBlock, k1, 0, wordsInBlock);
		}
		for (int wordIndex = 0; wordIndex < internalState.Length; wordIndex++)
		{
			internalState[wordIndex] += k0[wordIndex];
		}
		EncryptionRound();
		for (int i = 0; i < internalState.Length; i++)
		{
			internalState[i] ^= k1[i];
		}
		EncryptionRound();
		for (int j = 0; j < internalState.Length; j++)
		{
			internalState[j] += k0[j];
		}
		EncryptionRound();
		Array.Copy(internalState, 0, tempKeys, 0, wordsInBlock);
	}

	private void WorkingKeyExpandEven(ulong[] workingKey, ulong[] tempKey)
	{
		ulong[] initialData = new ulong[wordsInKey];
		ulong[] tempRoundKey = new ulong[wordsInBlock];
		int round = 0;
		Array.Copy(workingKey, 0, initialData, 0, wordsInKey);
		ulong tmv = 281479271743489uL;
		while (true)
		{
			for (int wordIndex = 0; wordIndex < wordsInBlock; wordIndex++)
			{
				tempRoundKey[wordIndex] = tempKey[wordIndex] + tmv;
			}
			for (int i = 0; i < wordsInBlock; i++)
			{
				internalState[i] = initialData[i] + tempRoundKey[i];
			}
			EncryptionRound();
			for (int j = 0; j < wordsInBlock; j++)
			{
				internalState[j] ^= tempRoundKey[j];
			}
			EncryptionRound();
			for (int k = 0; k < wordsInBlock; k++)
			{
				internalState[k] += tempRoundKey[k];
			}
			Array.Copy(internalState, 0, roundKeys[round], 0, wordsInBlock);
			if (roundsAmount == round)
			{
				break;
			}
			if (wordsInKey != wordsInBlock)
			{
				round += 2;
				tmv <<= 1;
				for (int l = 0; l < wordsInBlock; l++)
				{
					tempRoundKey[l] = tempKey[l] + tmv;
				}
				for (int m = 0; m < wordsInBlock; m++)
				{
					internalState[m] = initialData[wordsInBlock + m] + tempRoundKey[m];
				}
				EncryptionRound();
				for (int n = 0; n < wordsInBlock; n++)
				{
					internalState[n] ^= tempRoundKey[n];
				}
				EncryptionRound();
				for (int num = 0; num < wordsInBlock; num++)
				{
					internalState[num] += tempRoundKey[num];
				}
				Array.Copy(internalState, 0, roundKeys[round], 0, wordsInBlock);
				if (roundsAmount == round)
				{
					break;
				}
			}
			round += 2;
			tmv <<= 1;
			ulong temp = initialData[0];
			for (int num2 = 1; num2 < initialData.Length; num2++)
			{
				initialData[num2 - 1] = initialData[num2];
			}
			initialData[initialData.Length - 1] = temp;
		}
	}

	private void WorkingKeyExpandOdd()
	{
		for (int roundIndex = 1; roundIndex < roundsAmount; roundIndex += 2)
		{
			RotateLeft(roundKeys[roundIndex - 1], roundKeys[roundIndex]);
		}
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey == null)
		{
			throw new InvalidOperationException("Dstu7624Engine not initialised");
		}
		Check.DataLength(input, inOff, GetBlockSize(), "input buffer too short");
		Check.OutputLength(output, outOff, GetBlockSize(), "output buffer too short");
		if (forEncryption)
		{
			if (wordsInBlock == 2)
			{
				EncryptBlock_128(input, inOff, output, outOff);
			}
			else
			{
				Pack.LE_To_UInt64(input, inOff, internalState);
				AddRoundKey(0);
				int round = 0;
				while (true)
				{
					EncryptionRound();
					if (++round == roundsAmount)
					{
						break;
					}
					XorRoundKey(round);
				}
				AddRoundKey(roundsAmount);
				Pack.UInt64_To_LE(internalState, output, outOff);
			}
		}
		else if (wordsInBlock == 2)
		{
			DecryptBlock_128(input, inOff, output, outOff);
		}
		else
		{
			Pack.LE_To_UInt64(input, inOff, internalState);
			SubRoundKey(roundsAmount);
			int round2 = roundsAmount;
			while (true)
			{
				DecryptionRound();
				if (--round2 == 0)
				{
					break;
				}
				XorRoundKey(round2);
			}
			SubRoundKey(0);
			Pack.UInt64_To_LE(internalState, output, outOff);
		}
		return GetBlockSize();
	}

	private void EncryptionRound()
	{
		SubBytes();
		ShiftRows();
		MixColumns();
	}

	private void DecryptionRound()
	{
		MixColumnsInv();
		InvShiftRows();
		InvSubBytes();
	}

	private void DecryptBlock_128(byte[] input, int inOff, byte[] output, int outOff)
	{
		ulong c0 = Pack.LE_To_UInt64(input, inOff);
		ulong c1 = Pack.LE_To_UInt64(input, inOff + 8);
		ulong[] roundKey = roundKeys[roundsAmount];
		c0 -= roundKey[0];
		c1 -= roundKey[1];
		int round = roundsAmount;
		while (true)
		{
			c0 = MixColumnInv(c0);
			c1 = MixColumnInv(c1);
			uint lo0 = (uint)c0;
			uint hi0 = (uint)(c0 >> 32);
			uint lo1 = (uint)c1;
			uint hi1 = (uint)(c1 >> 32);
			byte num = T0[lo0 & 0xFF];
			byte t1 = T1[(lo0 >> 8) & 0xFF];
			byte t2 = T2[(lo0 >> 16) & 0xFF];
			byte t3 = T3[lo0 >> 24];
			lo0 = (uint)(num | (t1 << 8) | (t2 << 16) | (t3 << 24));
			byte num2 = T0[hi1 & 0xFF];
			byte t5 = T1[(hi1 >> 8) & 0xFF];
			byte t6 = T2[(hi1 >> 16) & 0xFF];
			byte t7 = T3[hi1 >> 24];
			hi1 = (uint)(num2 | (t5 << 8) | (t6 << 16) | (t7 << 24));
			c0 = lo0 | ((ulong)hi1 << 32);
			byte num3 = T0[lo1 & 0xFF];
			byte t8 = T1[(lo1 >> 8) & 0xFF];
			byte t9 = T2[(lo1 >> 16) & 0xFF];
			byte t10 = T3[lo1 >> 24];
			lo1 = (uint)(num3 | (t8 << 8) | (t9 << 16) | (t10 << 24));
			byte num4 = T0[hi0 & 0xFF];
			byte t11 = T1[(hi0 >> 8) & 0xFF];
			byte t12 = T2[(hi0 >> 16) & 0xFF];
			byte t13 = T3[hi0 >> 24];
			hi0 = (uint)(num4 | (t11 << 8) | (t12 << 16) | (t13 << 24));
			c1 = lo1 | ((ulong)hi0 << 32);
			if (--round == 0)
			{
				break;
			}
			roundKey = roundKeys[round];
			c0 ^= roundKey[0];
			c1 ^= roundKey[1];
		}
		roundKey = roundKeys[0];
		c0 -= roundKey[0];
		c1 -= roundKey[1];
		Pack.UInt64_To_LE(c0, output, outOff);
		Pack.UInt64_To_LE(c1, output, outOff + 8);
	}

	private void EncryptBlock_128(byte[] input, int inOff, byte[] output, int outOff)
	{
		ulong c0 = Pack.LE_To_UInt64(input, inOff);
		ulong c1 = Pack.LE_To_UInt64(input, inOff + 8);
		ulong[] roundKey = roundKeys[0];
		c0 += roundKey[0];
		c1 += roundKey[1];
		int round = 0;
		while (true)
		{
			uint lo0 = (uint)c0;
			uint hi0 = (uint)(c0 >> 32);
			uint lo1 = (uint)c1;
			uint hi1 = (uint)(c1 >> 32);
			byte num = S0[lo0 & 0xFF];
			byte t1 = S1[(lo0 >> 8) & 0xFF];
			byte t2 = S2[(lo0 >> 16) & 0xFF];
			byte t3 = S3[lo0 >> 24];
			lo0 = (uint)(num | (t1 << 8) | (t2 << 16) | (t3 << 24));
			byte num2 = S0[hi1 & 0xFF];
			byte t5 = S1[(hi1 >> 8) & 0xFF];
			byte t6 = S2[(hi1 >> 16) & 0xFF];
			byte t7 = S3[hi1 >> 24];
			hi1 = (uint)(num2 | (t5 << 8) | (t6 << 16) | (t7 << 24));
			c0 = lo0 | ((ulong)hi1 << 32);
			byte num3 = S0[lo1 & 0xFF];
			byte t8 = S1[(lo1 >> 8) & 0xFF];
			byte t9 = S2[(lo1 >> 16) & 0xFF];
			byte t10 = S3[lo1 >> 24];
			lo1 = (uint)(num3 | (t8 << 8) | (t9 << 16) | (t10 << 24));
			byte num4 = S0[hi0 & 0xFF];
			byte t11 = S1[(hi0 >> 8) & 0xFF];
			byte t12 = S2[(hi0 >> 16) & 0xFF];
			byte t13 = S3[hi0 >> 24];
			hi0 = (uint)(num4 | (t11 << 8) | (t12 << 16) | (t13 << 24));
			c1 = lo1 | ((ulong)hi0 << 32);
			c0 = MixColumn(c0);
			c1 = MixColumn(c1);
			if (++round == roundsAmount)
			{
				break;
			}
			roundKey = roundKeys[round];
			c0 ^= roundKey[0];
			c1 ^= roundKey[1];
		}
		roundKey = roundKeys[roundsAmount];
		c0 += roundKey[0];
		c1 += roundKey[1];
		Pack.UInt64_To_LE(c0, output, outOff);
		Pack.UInt64_To_LE(c1, output, outOff + 8);
	}

	private void SubBytes()
	{
		for (int i = 0; i < wordsInBlock; i++)
		{
			ulong num = internalState[i];
			uint lo = (uint)num;
			uint hi = (uint)(num >> 32);
			byte num2 = S0[lo & 0xFF];
			byte t1 = S1[(lo >> 8) & 0xFF];
			byte t2 = S2[(lo >> 16) & 0xFF];
			byte t3 = S3[lo >> 24];
			lo = (uint)(num2 | (t1 << 8) | (t2 << 16) | (t3 << 24));
			byte num3 = S0[hi & 0xFF];
			byte t5 = S1[(hi >> 8) & 0xFF];
			byte t6 = S2[(hi >> 16) & 0xFF];
			byte t7 = S3[hi >> 24];
			hi = (uint)(num3 | (t5 << 8) | (t6 << 16) | (t7 << 24));
			internalState[i] = lo | ((ulong)hi << 32);
		}
	}

	private void InvSubBytes()
	{
		for (int i = 0; i < wordsInBlock; i++)
		{
			ulong num = internalState[i];
			uint lo = (uint)num;
			uint hi = (uint)(num >> 32);
			byte num2 = T0[lo & 0xFF];
			byte t1 = T1[(lo >> 8) & 0xFF];
			byte t2 = T2[(lo >> 16) & 0xFF];
			byte t3 = T3[lo >> 24];
			lo = (uint)(num2 | (t1 << 8) | (t2 << 16) | (t3 << 24));
			byte num3 = T0[hi & 0xFF];
			byte t5 = T1[(hi >> 8) & 0xFF];
			byte t6 = T2[(hi >> 16) & 0xFF];
			byte t7 = T3[hi >> 24];
			hi = (uint)(num3 | (t5 << 8) | (t6 << 16) | (t7 << 24));
			internalState[i] = lo | ((ulong)hi << 32);
		}
	}

	private void ShiftRows()
	{
		switch (wordsInBlock)
		{
		case 2:
		{
			ulong c12 = internalState[0];
			ulong c13 = internalState[1];
			ulong d3 = (c12 ^ c13) & 0xFFFFFFFF00000000uL;
			c12 ^= d3;
			c13 ^= d3;
			internalState[0] = c12;
			internalState[1] = c13;
			break;
		}
		case 4:
		{
			ulong c8 = internalState[0];
			ulong c9 = internalState[1];
			ulong c10 = internalState[2];
			ulong c11 = internalState[3];
			ulong d2 = (c8 ^ c10) & 0xFFFFFFFF00000000uL;
			c8 ^= d2;
			c10 ^= d2;
			d2 = (c9 ^ c11) & 0xFFFFFFFF0000L;
			c9 ^= d2;
			c11 ^= d2;
			d2 = (c8 ^ c9) & 0xFFFF0000FFFF0000uL;
			c8 ^= d2;
			c9 ^= d2;
			d2 = (c10 ^ c11) & 0xFFFF0000FFFF0000uL;
			c10 ^= d2;
			c11 ^= d2;
			internalState[0] = c8;
			internalState[1] = c9;
			internalState[2] = c10;
			internalState[3] = c11;
			break;
		}
		case 8:
		{
			ulong c0 = internalState[0];
			ulong c1 = internalState[1];
			ulong c2 = internalState[2];
			ulong c3 = internalState[3];
			ulong c4 = internalState[4];
			ulong c5 = internalState[5];
			ulong c6 = internalState[6];
			ulong c7 = internalState[7];
			ulong d = (c0 ^ c4) & 0xFFFFFFFF00000000uL;
			c0 ^= d;
			c4 ^= d;
			d = (c1 ^ c5) & 0xFFFFFFFF000000L;
			c1 ^= d;
			c5 ^= d;
			d = (c2 ^ c6) & 0xFFFFFFFF0000L;
			c2 ^= d;
			c6 ^= d;
			d = (c3 ^ c7) & 0xFFFFFFFF00L;
			c3 ^= d;
			c7 ^= d;
			d = (c0 ^ c2) & 0xFFFF0000FFFF0000uL;
			c0 ^= d;
			c2 ^= d;
			d = (c1 ^ c3) & 0xFFFF0000FFFF00L;
			c1 ^= d;
			c3 ^= d;
			d = (c4 ^ c6) & 0xFFFF0000FFFF0000uL;
			c4 ^= d;
			c6 ^= d;
			d = (c5 ^ c7) & 0xFFFF0000FFFF00L;
			c5 ^= d;
			c7 ^= d;
			d = (c0 ^ c1) & 0xFF00FF00FF00FF00uL;
			c0 ^= d;
			c1 ^= d;
			d = (c2 ^ c3) & 0xFF00FF00FF00FF00uL;
			c2 ^= d;
			c3 ^= d;
			d = (c4 ^ c5) & 0xFF00FF00FF00FF00uL;
			c4 ^= d;
			c5 ^= d;
			d = (c6 ^ c7) & 0xFF00FF00FF00FF00uL;
			c6 ^= d;
			c7 ^= d;
			internalState[0] = c0;
			internalState[1] = c1;
			internalState[2] = c2;
			internalState[3] = c3;
			internalState[4] = c4;
			internalState[5] = c5;
			internalState[6] = c6;
			internalState[7] = c7;
			break;
		}
		default:
			throw new InvalidOperationException("unsupported block length: only 128/256/512 are allowed");
		}
	}

	private void InvShiftRows()
	{
		switch (wordsInBlock)
		{
		case 2:
		{
			ulong c12 = internalState[0];
			ulong c13 = internalState[1];
			ulong d3 = (c12 ^ c13) & 0xFFFFFFFF00000000uL;
			c12 ^= d3;
			c13 ^= d3;
			internalState[0] = c12;
			internalState[1] = c13;
			break;
		}
		case 4:
		{
			ulong c8 = internalState[0];
			ulong c9 = internalState[1];
			ulong c10 = internalState[2];
			ulong c11 = internalState[3];
			ulong d2 = (c8 ^ c9) & 0xFFFF0000FFFF0000uL;
			c8 ^= d2;
			c9 ^= d2;
			d2 = (c10 ^ c11) & 0xFFFF0000FFFF0000uL;
			c10 ^= d2;
			c11 ^= d2;
			d2 = (c8 ^ c10) & 0xFFFFFFFF00000000uL;
			c8 ^= d2;
			c10 ^= d2;
			d2 = (c9 ^ c11) & 0xFFFFFFFF0000L;
			c9 ^= d2;
			c11 ^= d2;
			internalState[0] = c8;
			internalState[1] = c9;
			internalState[2] = c10;
			internalState[3] = c11;
			break;
		}
		case 8:
		{
			ulong c0 = internalState[0];
			ulong c1 = internalState[1];
			ulong c2 = internalState[2];
			ulong c3 = internalState[3];
			ulong c4 = internalState[4];
			ulong c5 = internalState[5];
			ulong c6 = internalState[6];
			ulong c7 = internalState[7];
			ulong d = (c0 ^ c1) & 0xFF00FF00FF00FF00uL;
			c0 ^= d;
			c1 ^= d;
			d = (c2 ^ c3) & 0xFF00FF00FF00FF00uL;
			c2 ^= d;
			c3 ^= d;
			d = (c4 ^ c5) & 0xFF00FF00FF00FF00uL;
			c4 ^= d;
			c5 ^= d;
			d = (c6 ^ c7) & 0xFF00FF00FF00FF00uL;
			c6 ^= d;
			c7 ^= d;
			d = (c0 ^ c2) & 0xFFFF0000FFFF0000uL;
			c0 ^= d;
			c2 ^= d;
			d = (c1 ^ c3) & 0xFFFF0000FFFF00L;
			c1 ^= d;
			c3 ^= d;
			d = (c4 ^ c6) & 0xFFFF0000FFFF0000uL;
			c4 ^= d;
			c6 ^= d;
			d = (c5 ^ c7) & 0xFFFF0000FFFF00L;
			c5 ^= d;
			c7 ^= d;
			d = (c0 ^ c4) & 0xFFFFFFFF00000000uL;
			c0 ^= d;
			c4 ^= d;
			d = (c1 ^ c5) & 0xFFFFFFFF000000L;
			c1 ^= d;
			c5 ^= d;
			d = (c2 ^ c6) & 0xFFFFFFFF0000L;
			c2 ^= d;
			c6 ^= d;
			d = (c3 ^ c7) & 0xFFFFFFFF00L;
			c3 ^= d;
			c7 ^= d;
			internalState[0] = c0;
			internalState[1] = c1;
			internalState[2] = c2;
			internalState[3] = c3;
			internalState[4] = c4;
			internalState[5] = c5;
			internalState[6] = c6;
			internalState[7] = c7;
			break;
		}
		default:
			throw new InvalidOperationException("unsupported block length: only 128/256/512 are allowed");
		}
	}

	private void AddRoundKey(int round)
	{
		ulong[] roundKey = roundKeys[round];
		for (int i = 0; i < wordsInBlock; i++)
		{
			internalState[i] += roundKey[i];
		}
	}

	private void SubRoundKey(int round)
	{
		ulong[] roundKey = roundKeys[round];
		for (int i = 0; i < wordsInBlock; i++)
		{
			internalState[i] -= roundKey[i];
		}
	}

	private void XorRoundKey(int round)
	{
		ulong[] roundKey = roundKeys[round];
		for (int i = 0; i < wordsInBlock; i++)
		{
			internalState[i] ^= roundKey[i];
		}
	}

	private static ulong MixColumn(ulong c)
	{
		ulong x1 = MulX(c);
		ulong u = Rotate(8, c) ^ c;
		u ^= Rotate(16, u);
		u ^= Rotate(48, c);
		ulong v = MulX2(u ^ c ^ x1);
		return u ^ Rotate(32, v) ^ Rotate(40, x1) ^ Rotate(48, x1);
	}

	private void MixColumns()
	{
		for (int col = 0; col < wordsInBlock; col++)
		{
			internalState[col] = MixColumn(internalState[col]);
		}
	}

	private static ulong MixColumnInv(ulong c)
	{
		ulong u0 = c;
		u0 ^= Rotate(8, u0);
		u0 ^= Rotate(32, u0);
		u0 ^= Rotate(48, c);
		ulong t = u0 ^ c;
		ulong c48 = Rotate(48, c);
		ulong c56 = Rotate(56, c);
		ulong u7 = t ^ c56;
		ulong u8 = Rotate(56, t);
		u8 ^= MulX(u7);
		ulong u9 = Rotate(16, t) ^ c;
		u9 ^= Rotate(40, MulX(u8) ^ c);
		ulong u10 = t ^ c48;
		u10 ^= MulX(u9);
		ulong u11 = Rotate(16, u0);
		u11 ^= MulX(u10);
		ulong u12 = t ^ Rotate(24, c) ^ c48 ^ c56;
		u12 ^= MulX(u11);
		ulong u13 = Rotate(32, t) ^ c ^ c56;
		u13 ^= MulX(u12);
		return u0 ^ MulX(Rotate(40, u13));
	}

	private void MixColumnsInv()
	{
		for (int col = 0; col < wordsInBlock; col++)
		{
			internalState[col] = MixColumnInv(internalState[col]);
		}
	}

	private static ulong MulX(ulong n)
	{
		return ((n & 0x7F7F7F7F7F7F7F7FL) << 1) ^ (((n & 0x8080808080808080uL) >> 7) * 29);
	}

	private static ulong MulX2(ulong n)
	{
		return ((n & 0x3F3F3F3F3F3F3F3FL) << 2) ^ (((n & 0x8080808080808080uL) >> 6) * 29) ^ (((n & 0x4040404040404040L) >> 6) * 29);
	}

	private static ulong Rotate(int n, ulong x)
	{
		return (x >> n) | (x << -n);
	}

	private void RotateLeft(ulong[] x, ulong[] z)
	{
		switch (wordsInBlock)
		{
		case 2:
		{
			ulong x14 = x[0];
			ulong x15 = x[1];
			z[0] = (x14 >> 56) | (x15 << 8);
			z[1] = (x15 >> 56) | (x14 << 8);
			break;
		}
		case 4:
		{
			ulong x10 = x[0];
			ulong x11 = x[1];
			ulong x12 = x[2];
			ulong x13 = x[3];
			z[0] = (x11 >> 24) | (x12 << 40);
			z[1] = (x12 >> 24) | (x13 << 40);
			z[2] = (x13 >> 24) | (x10 << 40);
			z[3] = (x10 >> 24) | (x11 << 40);
			break;
		}
		case 8:
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			ulong x6 = x[4];
			ulong x7 = x[5];
			ulong x8 = x[6];
			ulong x9 = x[7];
			z[0] = (x4 >> 24) | (x5 << 40);
			z[1] = (x5 >> 24) | (x6 << 40);
			z[2] = (x6 >> 24) | (x7 << 40);
			z[3] = (x7 >> 24) | (x8 << 40);
			z[4] = (x8 >> 24) | (x9 << 40);
			z[5] = (x9 >> 24) | (x2 << 40);
			z[6] = (x2 >> 24) | (x3 << 40);
			z[7] = (x3 >> 24) | (x4 << 40);
			break;
		}
		default:
			throw new InvalidOperationException("unsupported block length: only 128/256/512 are allowed");
		}
	}

	public virtual int GetBlockSize()
	{
		return wordsInBlock << 3;
	}

	public virtual void Reset()
	{
		Array.Clear(internalState, 0, internalState.Length);
	}
}
