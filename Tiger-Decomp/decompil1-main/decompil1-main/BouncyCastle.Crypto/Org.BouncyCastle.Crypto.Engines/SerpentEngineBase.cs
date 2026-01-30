using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public abstract class SerpentEngineBase : IBlockCipher
{
	protected static readonly int BlockSize = 16;

	internal const int ROUNDS = 32;

	internal const int PHI = -1640531527;

	protected bool encrypting;

	protected int[] wKey;

	protected int X0;

	protected int X1;

	protected int X2;

	protected int X3;

	public virtual string AlgorithmName => "Serpent";

	public virtual bool IsPartialBlockOkay => false;

	public virtual void Init(bool encrypting, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to " + AlgorithmName + " init - " + Platform.GetTypeName(parameters));
		}
		this.encrypting = encrypting;
		wKey = MakeWorkingKey(((KeyParameter)parameters).GetKey());
	}

	public virtual int GetBlockSize()
	{
		return BlockSize;
	}

	public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (wKey == null)
		{
			throw new InvalidOperationException(AlgorithmName + " not initialised");
		}
		Check.DataLength(input, inOff, BlockSize, "input buffer too short");
		Check.OutputLength(output, outOff, BlockSize, "output buffer too short");
		if (encrypting)
		{
			EncryptBlock(input, inOff, output, outOff);
		}
		else
		{
			DecryptBlock(input, inOff, output, outOff);
		}
		return BlockSize;
	}

	public virtual void Reset()
	{
	}

	protected static int RotateLeft(int x, int bits)
	{
		return (x << bits) | (x >>> 32 - bits);
	}

	private static int RotateRight(int x, int bits)
	{
		return (x >>> bits) | (x << 32 - bits);
	}

	protected void Sb0(int a, int b, int c, int d)
	{
		int t1 = a ^ d;
		int t3 = c ^ t1;
		int t4 = b ^ t3;
		X3 = (a & d) ^ t4;
		int t7 = a ^ (b & t1);
		X2 = t4 ^ (c | t7);
		int t12 = X3 & (t3 ^ t7);
		X1 = ~t3 ^ t12;
		X0 = t12 ^ ~t7;
	}

	protected void Ib0(int a, int b, int c, int d)
	{
		int t1 = ~a;
		int t2 = a ^ b;
		int t4 = d ^ (t1 | t2);
		int t5 = c ^ t4;
		X2 = t2 ^ t5;
		int t8 = t1 ^ (d & t2);
		X1 = t4 ^ (X2 & t8);
		X3 = (a & t4) ^ (t5 | X1);
		X0 = X3 ^ (t5 ^ t8);
	}

	protected void Sb1(int a, int b, int c, int d)
	{
		int t2 = b ^ ~a;
		int t5 = c ^ (a | t2);
		X2 = d ^ t5;
		int t7 = b ^ (d | t2);
		int t8 = t2 ^ X2;
		X3 = t8 ^ (t5 & t7);
		int t11 = t5 ^ t7;
		X1 = X3 ^ t11;
		X0 = t5 ^ (t8 & t11);
	}

	protected void Ib1(int a, int b, int c, int d)
	{
		int t1 = b ^ d;
		int t3 = a ^ (b & t1);
		int t4 = t1 ^ t3;
		X3 = c ^ t4;
		int t7 = b ^ (t1 & t3);
		int t8 = X3 | t7;
		X1 = t3 ^ t8;
		int t10 = ~X1;
		int t11 = X3 ^ t7;
		X0 = t10 ^ t11;
		X2 = t4 ^ (t10 | t11);
	}

	protected void Sb2(int a, int b, int c, int d)
	{
		int t1 = ~a;
		int t2 = b ^ d;
		int t3 = c & t1;
		X0 = t2 ^ t3;
		int t5 = c ^ t1;
		int t6 = c ^ X0;
		int t7 = b & t6;
		X3 = t5 ^ t7;
		X2 = a ^ ((d | t7) & (X0 | t5));
		X1 = t2 ^ X3 ^ (X2 ^ (d | t1));
	}

	protected void Ib2(int a, int b, int c, int d)
	{
		int t1 = b ^ d;
		int t2 = ~t1;
		int t3 = a ^ c;
		int t4 = c ^ t1;
		int t5 = b & t4;
		X0 = t3 ^ t5;
		int t7 = a | t2;
		int t8 = d ^ t7;
		int t9 = t3 | t8;
		X3 = t1 ^ t9;
		int t11 = ~t4;
		int t12 = X0 | X3;
		X1 = t11 ^ t12;
		X2 = (d & t11) ^ (t3 ^ t12);
	}

	protected void Sb3(int a, int b, int c, int d)
	{
		int t1 = a ^ b;
		int num = a & c;
		int t3 = a | d;
		int t4 = c ^ d;
		int t5 = t1 & t3;
		int t6 = num | t5;
		X2 = t4 ^ t6;
		int t8 = b ^ t3;
		int t9 = t6 ^ t8;
		int t10 = t4 & t9;
		X0 = t1 ^ t10;
		int t12 = X2 & X0;
		X1 = t9 ^ t12;
		X3 = (b | d) ^ (t4 ^ t12);
	}

	protected void Ib3(int a, int b, int c, int d)
	{
		int num = a | b;
		int t2 = b ^ c;
		int t3 = b & t2;
		int t4 = a ^ t3;
		int t5 = c ^ t4;
		int t6 = d | t4;
		X0 = t2 ^ t6;
		int t8 = t2 | t6;
		int t9 = d ^ t8;
		X2 = t5 ^ t9;
		int t11 = num ^ t9;
		int t12 = X0 & t11;
		X3 = t4 ^ t12;
		X1 = X3 ^ (X0 ^ t11);
	}

	protected void Sb4(int a, int b, int c, int d)
	{
		int t1 = a ^ d;
		int t2 = d & t1;
		int t3 = c ^ t2;
		int t4 = b | t3;
		X3 = t1 ^ t4;
		int t6 = ~b;
		int t7 = t1 | t6;
		X0 = t3 ^ t7;
		int t9 = a & X0;
		int t10 = t1 ^ t6;
		int t11 = t4 & t10;
		X2 = t9 ^ t11;
		X1 = a ^ t3 ^ (t10 & X2);
	}

	protected void Ib4(int a, int b, int c, int d)
	{
		int t1 = c | d;
		int t2 = a & t1;
		int t3 = b ^ t2;
		int t4 = a & t3;
		int t5 = c ^ t4;
		X1 = d ^ t5;
		int t7 = ~a;
		int t8 = t5 & X1;
		X3 = t3 ^ t8;
		int t10 = X1 | t7;
		int t11 = d ^ t10;
		X0 = X3 ^ t11;
		X2 = (t3 & t11) ^ (X1 ^ t7);
	}

	protected void Sb5(int a, int b, int c, int d)
	{
		int t1 = ~a;
		int num = a ^ b;
		int t3 = a ^ d;
		int t4 = c ^ t1;
		int t5 = num | t3;
		X0 = t4 ^ t5;
		int t7 = d & X0;
		int t8 = num ^ X0;
		X1 = t7 ^ t8;
		int t10 = t1 | X0;
		int t11 = num | t7;
		int t12 = t3 ^ t10;
		X2 = t11 ^ t12;
		X3 = b ^ t7 ^ (X1 & t12);
	}

	protected void Ib5(int a, int b, int c, int d)
	{
		int t1 = ~c;
		int t2 = b & t1;
		int t3 = d ^ t2;
		int t4 = a & t3;
		int t5 = b ^ t1;
		X3 = t4 ^ t5;
		int t7 = b | X3;
		int t8 = a & t7;
		X1 = t3 ^ t8;
		int t10 = a | d;
		int t11 = t1 ^ t7;
		X0 = t10 ^ t11;
		X2 = (b & t10) ^ (t4 | (a ^ c));
	}

	protected void Sb6(int a, int b, int c, int d)
	{
		int num = ~a;
		int t2 = a ^ d;
		int t3 = b ^ t2;
		int t4 = num | t2;
		int t5 = c ^ t4;
		X1 = b ^ t5;
		int t7 = t2 | X1;
		int t8 = d ^ t7;
		int t9 = t5 & t8;
		X2 = t3 ^ t9;
		int t11 = t5 ^ t8;
		X0 = X2 ^ t11;
		X3 = ~t5 ^ (t3 & t11);
	}

	protected void Ib6(int a, int b, int c, int d)
	{
		int t1 = ~a;
		int t2 = a ^ b;
		int t3 = c ^ t2;
		int t4 = c | t1;
		int t5 = d ^ t4;
		X1 = t3 ^ t5;
		int t7 = t3 & t5;
		int t8 = t2 ^ t7;
		int t9 = b | t8;
		X3 = t5 ^ t9;
		int t11 = b | X3;
		X0 = t8 ^ t11;
		X2 = (d & t1) ^ (t3 ^ t11);
	}

	protected void Sb7(int a, int b, int c, int d)
	{
		int t1 = b ^ c;
		int t2 = c & t1;
		int t3 = d ^ t2;
		int t4 = a ^ t3;
		int t5 = d | t1;
		int t6 = t4 & t5;
		X1 = b ^ t6;
		int t8 = t3 | X1;
		int t9 = a & t4;
		X3 = t1 ^ t9;
		int t11 = t4 ^ t8;
		int t12 = X3 & t11;
		X2 = t3 ^ t12;
		X0 = ~t11 ^ (X3 & X2);
	}

	protected void Ib7(int a, int b, int c, int d)
	{
		int t3 = c | (a & b);
		int t4 = d & (a | b);
		X3 = t3 ^ t4;
		int t6 = ~d;
		int t7 = b ^ t4;
		int t9 = t7 | (X3 ^ t6);
		X1 = a ^ t9;
		X0 = c ^ t7 ^ (d | X1);
		X2 = t3 ^ X1 ^ (X0 ^ (a & X3));
	}

	protected void LT()
	{
		int x0 = RotateLeft(X0, 13);
		int x2 = RotateLeft(X2, 3);
		int x3 = X1 ^ x0 ^ x2;
		int x4 = X3 ^ x2 ^ (x0 << 3);
		X1 = RotateLeft(x3, 1);
		X3 = RotateLeft(x4, 7);
		X0 = RotateLeft(x0 ^ X1 ^ X3, 5);
		X2 = RotateLeft(x2 ^ X3 ^ (X1 << 7), 22);
	}

	protected void InverseLT()
	{
		int x2 = RotateRight(X2, 22) ^ X3 ^ (X1 << 7);
		int x3 = RotateRight(X0, 5) ^ X1 ^ X3;
		int x4 = RotateRight(X3, 7);
		int x5 = RotateRight(X1, 1);
		X3 = x4 ^ x2 ^ (x3 << 3);
		X1 = x5 ^ x3 ^ x2;
		X2 = RotateRight(x2, 3);
		X0 = RotateRight(x3, 13);
	}

	protected abstract int[] MakeWorkingKey(byte[] key);

	protected abstract void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff);

	protected abstract void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff);
}
