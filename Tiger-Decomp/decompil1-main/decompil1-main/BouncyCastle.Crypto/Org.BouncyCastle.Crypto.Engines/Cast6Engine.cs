using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public sealed class Cast6Engine : Cast5Engine
{
	private const int ROUNDS = 12;

	private const int BLOCK_SIZE = 16;

	private int[] _Kr = new int[48];

	private uint[] _Km = new uint[48];

	private int[] _Tr = new int[192];

	private uint[] _Tm = new uint[192];

	private uint[] _workingKey = new uint[8];

	public override string AlgorithmName => "CAST6";

	public override void Reset()
	{
	}

	public override int GetBlockSize()
	{
		return 16;
	}

	internal override void SetKey(byte[] key)
	{
		uint Cm = 1518500249u;
		uint Mm = 1859775393u;
		int Cr = 19;
		int Mr = 17;
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				_Tm[i * 8 + j] = Cm;
				Cm += Mm;
				_Tr[i * 8 + j] = Cr;
				Cr = (Cr + Mr) & 0x1F;
			}
		}
		byte[] tmpKey = new byte[64];
		key.CopyTo(tmpKey, 0);
		for (int k = 0; k < 8; k++)
		{
			_workingKey[k] = Pack.BE_To_UInt32(tmpKey, k * 4);
		}
		for (int l = 0; l < 12; l++)
		{
			int i2 = l * 2 * 8;
			_workingKey[6] ^= Cast5Engine.F1(_workingKey[7], _Tm[i2], _Tr[i2]);
			_workingKey[5] ^= Cast5Engine.F2(_workingKey[6], _Tm[i2 + 1], _Tr[i2 + 1]);
			_workingKey[4] ^= Cast5Engine.F3(_workingKey[5], _Tm[i2 + 2], _Tr[i2 + 2]);
			_workingKey[3] ^= Cast5Engine.F1(_workingKey[4], _Tm[i2 + 3], _Tr[i2 + 3]);
			_workingKey[2] ^= Cast5Engine.F2(_workingKey[3], _Tm[i2 + 4], _Tr[i2 + 4]);
			_workingKey[1] ^= Cast5Engine.F3(_workingKey[2], _Tm[i2 + 5], _Tr[i2 + 5]);
			_workingKey[0] ^= Cast5Engine.F1(_workingKey[1], _Tm[i2 + 6], _Tr[i2 + 6]);
			_workingKey[7] ^= Cast5Engine.F2(_workingKey[0], _Tm[i2 + 7], _Tr[i2 + 7]);
			i2 = (l * 2 + 1) * 8;
			_workingKey[6] ^= Cast5Engine.F1(_workingKey[7], _Tm[i2], _Tr[i2]);
			_workingKey[5] ^= Cast5Engine.F2(_workingKey[6], _Tm[i2 + 1], _Tr[i2 + 1]);
			_workingKey[4] ^= Cast5Engine.F3(_workingKey[5], _Tm[i2 + 2], _Tr[i2 + 2]);
			_workingKey[3] ^= Cast5Engine.F1(_workingKey[4], _Tm[i2 + 3], _Tr[i2 + 3]);
			_workingKey[2] ^= Cast5Engine.F2(_workingKey[3], _Tm[i2 + 4], _Tr[i2 + 4]);
			_workingKey[1] ^= Cast5Engine.F3(_workingKey[2], _Tm[i2 + 5], _Tr[i2 + 5]);
			_workingKey[0] ^= Cast5Engine.F1(_workingKey[1], _Tm[i2 + 6], _Tr[i2 + 6]);
			_workingKey[7] ^= Cast5Engine.F2(_workingKey[0], _Tm[i2 + 7], _Tr[i2 + 7]);
			_Kr[l * 4] = (int)(_workingKey[0] & 0x1F);
			_Kr[l * 4 + 1] = (int)(_workingKey[2] & 0x1F);
			_Kr[l * 4 + 2] = (int)(_workingKey[4] & 0x1F);
			_Kr[l * 4 + 3] = (int)(_workingKey[6] & 0x1F);
			_Km[l * 4] = _workingKey[7];
			_Km[l * 4 + 1] = _workingKey[5];
			_Km[l * 4 + 2] = _workingKey[3];
			_Km[l * 4 + 3] = _workingKey[1];
		}
	}

	internal override int EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
	{
		uint A = Pack.BE_To_UInt32(src, srcIndex);
		uint B = Pack.BE_To_UInt32(src, srcIndex + 4);
		uint C = Pack.BE_To_UInt32(src, srcIndex + 8);
		uint D = Pack.BE_To_UInt32(src, srcIndex + 12);
		uint[] result = new uint[4];
		CAST_Encipher(A, B, C, D, result);
		Pack.UInt32_To_BE(result[0], dst, dstIndex);
		Pack.UInt32_To_BE(result[1], dst, dstIndex + 4);
		Pack.UInt32_To_BE(result[2], dst, dstIndex + 8);
		Pack.UInt32_To_BE(result[3], dst, dstIndex + 12);
		return 16;
	}

	internal override int DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
	{
		uint A = Pack.BE_To_UInt32(src, srcIndex);
		uint B = Pack.BE_To_UInt32(src, srcIndex + 4);
		uint C = Pack.BE_To_UInt32(src, srcIndex + 8);
		uint D = Pack.BE_To_UInt32(src, srcIndex + 12);
		uint[] result = new uint[4];
		CAST_Decipher(A, B, C, D, result);
		Pack.UInt32_To_BE(result[0], dst, dstIndex);
		Pack.UInt32_To_BE(result[1], dst, dstIndex + 4);
		Pack.UInt32_To_BE(result[2], dst, dstIndex + 8);
		Pack.UInt32_To_BE(result[3], dst, dstIndex + 12);
		return 16;
	}

	private void CAST_Encipher(uint A, uint B, uint C, uint D, uint[] result)
	{
		for (int i = 0; i < 6; i++)
		{
			int x = i * 4;
			C ^= Cast5Engine.F1(D, _Km[x], _Kr[x]);
			B ^= Cast5Engine.F2(C, _Km[x + 1], _Kr[x + 1]);
			A ^= Cast5Engine.F3(B, _Km[x + 2], _Kr[x + 2]);
			D ^= Cast5Engine.F1(A, _Km[x + 3], _Kr[x + 3]);
		}
		for (int j = 6; j < 12; j++)
		{
			int x2 = j * 4;
			D ^= Cast5Engine.F1(A, _Km[x2 + 3], _Kr[x2 + 3]);
			A ^= Cast5Engine.F3(B, _Km[x2 + 2], _Kr[x2 + 2]);
			B ^= Cast5Engine.F2(C, _Km[x2 + 1], _Kr[x2 + 1]);
			C ^= Cast5Engine.F1(D, _Km[x2], _Kr[x2]);
		}
		result[0] = A;
		result[1] = B;
		result[2] = C;
		result[3] = D;
	}

	private void CAST_Decipher(uint A, uint B, uint C, uint D, uint[] result)
	{
		for (int i = 0; i < 6; i++)
		{
			int x = (11 - i) * 4;
			C ^= Cast5Engine.F1(D, _Km[x], _Kr[x]);
			B ^= Cast5Engine.F2(C, _Km[x + 1], _Kr[x + 1]);
			A ^= Cast5Engine.F3(B, _Km[x + 2], _Kr[x + 2]);
			D ^= Cast5Engine.F1(A, _Km[x + 3], _Kr[x + 3]);
		}
		for (int j = 6; j < 12; j++)
		{
			int x2 = (11 - j) * 4;
			D ^= Cast5Engine.F1(A, _Km[x2 + 3], _Kr[x2 + 3]);
			A ^= Cast5Engine.F3(B, _Km[x2 + 2], _Kr[x2 + 2]);
			B ^= Cast5Engine.F2(C, _Km[x2 + 1], _Kr[x2 + 1]);
			C ^= Cast5Engine.F1(D, _Km[x2], _Kr[x2]);
		}
		result[0] = A;
		result[1] = B;
		result[2] = C;
		result[3] = D;
	}
}
