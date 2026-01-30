using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class ThreefishEngine : IBlockCipher
{
	private abstract class ThreefishCipher
	{
		protected readonly ulong[] t;

		protected readonly ulong[] kw;

		protected ThreefishCipher(ulong[] kw, ulong[] t)
		{
			this.kw = kw;
			this.t = t;
		}

		internal abstract void EncryptBlock(ulong[] block, ulong[] outWords);

		internal abstract void DecryptBlock(ulong[] block, ulong[] outWords);
	}

	private sealed class Threefish256Cipher : ThreefishCipher
	{
		private const int ROTATION_0_0 = 14;

		private const int ROTATION_0_1 = 16;

		private const int ROTATION_1_0 = 52;

		private const int ROTATION_1_1 = 57;

		private const int ROTATION_2_0 = 23;

		private const int ROTATION_2_1 = 40;

		private const int ROTATION_3_0 = 5;

		private const int ROTATION_3_1 = 37;

		private const int ROTATION_4_0 = 25;

		private const int ROTATION_4_1 = 33;

		private const int ROTATION_5_0 = 46;

		private const int ROTATION_5_1 = 12;

		private const int ROTATION_6_0 = 58;

		private const int ROTATION_6_1 = 22;

		private const int ROTATION_7_0 = 32;

		private const int ROTATION_7_1 = 32;

		public Threefish256Cipher(ulong[] kw, ulong[] t)
			: base(kw, t)
		{
		}

		internal override void EncryptBlock(ulong[] block, ulong[] outWords)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod5 = MOD5;
			int[] mod6 = MOD3;
			if (kw.Length != 9)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			b0 += kw[0];
			b1 += kw[1] + t[0];
			b2 += kw[2] + t[1];
			b3 += kw[3];
			for (int d = 1; d < 18; d += 2)
			{
				int dm5 = mod5[d];
				int dm6 = mod6[d];
				b1 = RotlXor(b1, 14, b0 += b1);
				b3 = RotlXor(b3, 16, b2 += b3);
				b3 = RotlXor(b3, 52, b0 += b3);
				b1 = RotlXor(b1, 57, b2 += b1);
				b1 = RotlXor(b1, 23, b0 += b1);
				b3 = RotlXor(b3, 40, b2 += b3);
				b3 = RotlXor(b3, 5, b0 += b3);
				b1 = RotlXor(b1, 37, b2 += b1);
				b0 += kw[dm5];
				b1 += kw[dm5 + 1] + t[dm6];
				b2 += kw[dm5 + 2] + t[dm6 + 1];
				b3 += kw[dm5 + 3] + (uint)d;
				b1 = RotlXor(b1, 25, b0 += b1);
				b3 = RotlXor(b3, 33, b2 += b3);
				b3 = RotlXor(b3, 46, b0 += b3);
				b1 = RotlXor(b1, 12, b2 += b1);
				b1 = RotlXor(b1, 58, b0 += b1);
				b3 = RotlXor(b3, 22, b2 += b3);
				b3 = RotlXor(b3, 32, b0 += b3);
				b1 = RotlXor(b1, 32, b2 += b1);
				b0 += kw[dm5 + 1];
				b1 += kw[dm5 + 2] + t[dm6 + 1];
				b2 += kw[dm5 + 3] + t[dm6 + 2];
				b3 += kw[dm5 + 4] + (uint)d + 1;
			}
			outWords[0] = b0;
			outWords[1] = b1;
			outWords[2] = b2;
			outWords[3] = b3;
		}

		internal override void DecryptBlock(ulong[] block, ulong[] state)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod5 = MOD5;
			int[] mod6 = MOD3;
			if (kw.Length != 9)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			for (int d = 17; d >= 1; d -= 2)
			{
				int dm5 = mod5[d];
				int dm6 = mod6[d];
				b0 -= kw[dm5 + 1];
				b1 -= kw[dm5 + 2] + t[dm6 + 1];
				b2 -= kw[dm5 + 3] + t[dm6 + 2];
				b3 -= kw[dm5 + 4] + (uint)d + 1;
				b3 = XorRotr(b3, 32, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 32, b2);
				b2 -= b1;
				b1 = XorRotr(b1, 58, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 22, b2);
				b2 -= b3;
				b3 = XorRotr(b3, 46, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 12, b2);
				b2 -= b1;
				b1 = XorRotr(b1, 25, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 33, b2);
				b2 -= b3;
				b0 -= kw[dm5];
				b1 -= kw[dm5 + 1] + t[dm6];
				b2 -= kw[dm5 + 2] + t[dm6 + 1];
				b3 -= kw[dm5 + 3] + (uint)d;
				b3 = XorRotr(b3, 5, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 37, b2);
				b2 -= b1;
				b1 = XorRotr(b1, 23, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 40, b2);
				b2 -= b3;
				b3 = XorRotr(b3, 52, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 57, b2);
				b2 -= b1;
				b1 = XorRotr(b1, 14, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 16, b2);
				b2 -= b3;
			}
			b0 -= kw[0];
			b1 -= kw[1] + t[0];
			b2 -= kw[2] + t[1];
			b3 -= kw[3];
			state[0] = b0;
			state[1] = b1;
			state[2] = b2;
			state[3] = b3;
		}
	}

	private sealed class Threefish512Cipher : ThreefishCipher
	{
		private const int ROTATION_0_0 = 46;

		private const int ROTATION_0_1 = 36;

		private const int ROTATION_0_2 = 19;

		private const int ROTATION_0_3 = 37;

		private const int ROTATION_1_0 = 33;

		private const int ROTATION_1_1 = 27;

		private const int ROTATION_1_2 = 14;

		private const int ROTATION_1_3 = 42;

		private const int ROTATION_2_0 = 17;

		private const int ROTATION_2_1 = 49;

		private const int ROTATION_2_2 = 36;

		private const int ROTATION_2_3 = 39;

		private const int ROTATION_3_0 = 44;

		private const int ROTATION_3_1 = 9;

		private const int ROTATION_3_2 = 54;

		private const int ROTATION_3_3 = 56;

		private const int ROTATION_4_0 = 39;

		private const int ROTATION_4_1 = 30;

		private const int ROTATION_4_2 = 34;

		private const int ROTATION_4_3 = 24;

		private const int ROTATION_5_0 = 13;

		private const int ROTATION_5_1 = 50;

		private const int ROTATION_5_2 = 10;

		private const int ROTATION_5_3 = 17;

		private const int ROTATION_6_0 = 25;

		private const int ROTATION_6_1 = 29;

		private const int ROTATION_6_2 = 39;

		private const int ROTATION_6_3 = 43;

		private const int ROTATION_7_0 = 8;

		private const int ROTATION_7_1 = 35;

		private const int ROTATION_7_2 = 56;

		private const int ROTATION_7_3 = 22;

		internal Threefish512Cipher(ulong[] kw, ulong[] t)
			: base(kw, t)
		{
		}

		internal override void EncryptBlock(ulong[] block, ulong[] outWords)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod9 = MOD9;
			int[] mod10 = MOD3;
			if (kw.Length != 17)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			ulong b4 = block[4];
			ulong b5 = block[5];
			ulong b6 = block[6];
			ulong b7 = block[7];
			b0 += kw[0];
			b1 += kw[1];
			b2 += kw[2];
			b3 += kw[3];
			b4 += kw[4];
			b5 += kw[5] + t[0];
			b6 += kw[6] + t[1];
			b7 += kw[7];
			for (int d = 1; d < 18; d += 2)
			{
				int dm9 = mod9[d];
				int dm10 = mod10[d];
				b1 = RotlXor(b1, 46, b0 += b1);
				b3 = RotlXor(b3, 36, b2 += b3);
				b5 = RotlXor(b5, 19, b4 += b5);
				b7 = RotlXor(b7, 37, b6 += b7);
				b1 = RotlXor(b1, 33, b2 += b1);
				b7 = RotlXor(b7, 27, b4 += b7);
				b5 = RotlXor(b5, 14, b6 += b5);
				b3 = RotlXor(b3, 42, b0 += b3);
				b1 = RotlXor(b1, 17, b4 += b1);
				b3 = RotlXor(b3, 49, b6 += b3);
				b5 = RotlXor(b5, 36, b0 += b5);
				b7 = RotlXor(b7, 39, b2 += b7);
				b1 = RotlXor(b1, 44, b6 += b1);
				b7 = RotlXor(b7, 9, b0 += b7);
				b5 = RotlXor(b5, 54, b2 += b5);
				b3 = RotlXor(b3, 56, b4 += b3);
				b0 += kw[dm9];
				b1 += kw[dm9 + 1];
				b2 += kw[dm9 + 2];
				b3 += kw[dm9 + 3];
				b4 += kw[dm9 + 4];
				b5 += kw[dm9 + 5] + t[dm10];
				b6 += kw[dm9 + 6] + t[dm10 + 1];
				b7 += kw[dm9 + 7] + (uint)d;
				b1 = RotlXor(b1, 39, b0 += b1);
				b3 = RotlXor(b3, 30, b2 += b3);
				b5 = RotlXor(b5, 34, b4 += b5);
				b7 = RotlXor(b7, 24, b6 += b7);
				b1 = RotlXor(b1, 13, b2 += b1);
				b7 = RotlXor(b7, 50, b4 += b7);
				b5 = RotlXor(b5, 10, b6 += b5);
				b3 = RotlXor(b3, 17, b0 += b3);
				b1 = RotlXor(b1, 25, b4 += b1);
				b3 = RotlXor(b3, 29, b6 += b3);
				b5 = RotlXor(b5, 39, b0 += b5);
				b7 = RotlXor(b7, 43, b2 += b7);
				b1 = RotlXor(b1, 8, b6 += b1);
				b7 = RotlXor(b7, 35, b0 += b7);
				b5 = RotlXor(b5, 56, b2 += b5);
				b3 = RotlXor(b3, 22, b4 += b3);
				b0 += kw[dm9 + 1];
				b1 += kw[dm9 + 2];
				b2 += kw[dm9 + 3];
				b3 += kw[dm9 + 4];
				b4 += kw[dm9 + 5];
				b5 += kw[dm9 + 6] + t[dm10 + 1];
				b6 += kw[dm9 + 7] + t[dm10 + 2];
				b7 += kw[dm9 + 8] + (uint)d + 1;
			}
			outWords[0] = b0;
			outWords[1] = b1;
			outWords[2] = b2;
			outWords[3] = b3;
			outWords[4] = b4;
			outWords[5] = b5;
			outWords[6] = b6;
			outWords[7] = b7;
		}

		internal override void DecryptBlock(ulong[] block, ulong[] state)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod9 = MOD9;
			int[] mod10 = MOD3;
			if (kw.Length != 17)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			ulong b4 = block[4];
			ulong b5 = block[5];
			ulong b6 = block[6];
			ulong b7 = block[7];
			for (int d = 17; d >= 1; d -= 2)
			{
				int dm9 = mod9[d];
				int dm10 = mod10[d];
				b0 -= kw[dm9 + 1];
				b1 -= kw[dm9 + 2];
				b2 -= kw[dm9 + 3];
				b3 -= kw[dm9 + 4];
				b4 -= kw[dm9 + 5];
				b5 -= kw[dm9 + 6] + t[dm10 + 1];
				b6 -= kw[dm9 + 7] + t[dm10 + 2];
				b7 -= kw[dm9 + 8] + (uint)d + 1;
				b1 = XorRotr(b1, 8, b6);
				b6 -= b1;
				b7 = XorRotr(b7, 35, b0);
				b0 -= b7;
				b5 = XorRotr(b5, 56, b2);
				b2 -= b5;
				b3 = XorRotr(b3, 22, b4);
				b4 -= b3;
				b1 = XorRotr(b1, 25, b4);
				b4 -= b1;
				b3 = XorRotr(b3, 29, b6);
				b6 -= b3;
				b5 = XorRotr(b5, 39, b0);
				b0 -= b5;
				b7 = XorRotr(b7, 43, b2);
				b2 -= b7;
				b1 = XorRotr(b1, 13, b2);
				b2 -= b1;
				b7 = XorRotr(b7, 50, b4);
				b4 -= b7;
				b5 = XorRotr(b5, 10, b6);
				b6 -= b5;
				b3 = XorRotr(b3, 17, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 39, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 30, b2);
				b2 -= b3;
				b5 = XorRotr(b5, 34, b4);
				b4 -= b5;
				b7 = XorRotr(b7, 24, b6);
				b6 -= b7;
				b0 -= kw[dm9];
				b1 -= kw[dm9 + 1];
				b2 -= kw[dm9 + 2];
				b3 -= kw[dm9 + 3];
				b4 -= kw[dm9 + 4];
				b5 -= kw[dm9 + 5] + t[dm10];
				b6 -= kw[dm9 + 6] + t[dm10 + 1];
				b7 -= kw[dm9 + 7] + (uint)d;
				b1 = XorRotr(b1, 44, b6);
				b6 -= b1;
				b7 = XorRotr(b7, 9, b0);
				b0 -= b7;
				b5 = XorRotr(b5, 54, b2);
				b2 -= b5;
				b3 = XorRotr(b3, 56, b4);
				b4 -= b3;
				b1 = XorRotr(b1, 17, b4);
				b4 -= b1;
				b3 = XorRotr(b3, 49, b6);
				b6 -= b3;
				b5 = XorRotr(b5, 36, b0);
				b0 -= b5;
				b7 = XorRotr(b7, 39, b2);
				b2 -= b7;
				b1 = XorRotr(b1, 33, b2);
				b2 -= b1;
				b7 = XorRotr(b7, 27, b4);
				b4 -= b7;
				b5 = XorRotr(b5, 14, b6);
				b6 -= b5;
				b3 = XorRotr(b3, 42, b0);
				b0 -= b3;
				b1 = XorRotr(b1, 46, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 36, b2);
				b2 -= b3;
				b5 = XorRotr(b5, 19, b4);
				b4 -= b5;
				b7 = XorRotr(b7, 37, b6);
				b6 -= b7;
			}
			b0 -= kw[0];
			b1 -= kw[1];
			b2 -= kw[2];
			b3 -= kw[3];
			b4 -= kw[4];
			b5 -= kw[5] + t[0];
			b6 -= kw[6] + t[1];
			b7 -= kw[7];
			state[0] = b0;
			state[1] = b1;
			state[2] = b2;
			state[3] = b3;
			state[4] = b4;
			state[5] = b5;
			state[6] = b6;
			state[7] = b7;
		}
	}

	private sealed class Threefish1024Cipher : ThreefishCipher
	{
		private const int ROTATION_0_0 = 24;

		private const int ROTATION_0_1 = 13;

		private const int ROTATION_0_2 = 8;

		private const int ROTATION_0_3 = 47;

		private const int ROTATION_0_4 = 8;

		private const int ROTATION_0_5 = 17;

		private const int ROTATION_0_6 = 22;

		private const int ROTATION_0_7 = 37;

		private const int ROTATION_1_0 = 38;

		private const int ROTATION_1_1 = 19;

		private const int ROTATION_1_2 = 10;

		private const int ROTATION_1_3 = 55;

		private const int ROTATION_1_4 = 49;

		private const int ROTATION_1_5 = 18;

		private const int ROTATION_1_6 = 23;

		private const int ROTATION_1_7 = 52;

		private const int ROTATION_2_0 = 33;

		private const int ROTATION_2_1 = 4;

		private const int ROTATION_2_2 = 51;

		private const int ROTATION_2_3 = 13;

		private const int ROTATION_2_4 = 34;

		private const int ROTATION_2_5 = 41;

		private const int ROTATION_2_6 = 59;

		private const int ROTATION_2_7 = 17;

		private const int ROTATION_3_0 = 5;

		private const int ROTATION_3_1 = 20;

		private const int ROTATION_3_2 = 48;

		private const int ROTATION_3_3 = 41;

		private const int ROTATION_3_4 = 47;

		private const int ROTATION_3_5 = 28;

		private const int ROTATION_3_6 = 16;

		private const int ROTATION_3_7 = 25;

		private const int ROTATION_4_0 = 41;

		private const int ROTATION_4_1 = 9;

		private const int ROTATION_4_2 = 37;

		private const int ROTATION_4_3 = 31;

		private const int ROTATION_4_4 = 12;

		private const int ROTATION_4_5 = 47;

		private const int ROTATION_4_6 = 44;

		private const int ROTATION_4_7 = 30;

		private const int ROTATION_5_0 = 16;

		private const int ROTATION_5_1 = 34;

		private const int ROTATION_5_2 = 56;

		private const int ROTATION_5_3 = 51;

		private const int ROTATION_5_4 = 4;

		private const int ROTATION_5_5 = 53;

		private const int ROTATION_5_6 = 42;

		private const int ROTATION_5_7 = 41;

		private const int ROTATION_6_0 = 31;

		private const int ROTATION_6_1 = 44;

		private const int ROTATION_6_2 = 47;

		private const int ROTATION_6_3 = 46;

		private const int ROTATION_6_4 = 19;

		private const int ROTATION_6_5 = 42;

		private const int ROTATION_6_6 = 44;

		private const int ROTATION_6_7 = 25;

		private const int ROTATION_7_0 = 9;

		private const int ROTATION_7_1 = 48;

		private const int ROTATION_7_2 = 35;

		private const int ROTATION_7_3 = 52;

		private const int ROTATION_7_4 = 23;

		private const int ROTATION_7_5 = 31;

		private const int ROTATION_7_6 = 37;

		private const int ROTATION_7_7 = 20;

		public Threefish1024Cipher(ulong[] kw, ulong[] t)
			: base(kw, t)
		{
		}

		internal override void EncryptBlock(ulong[] block, ulong[] outWords)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod17 = MOD17;
			int[] mod18 = MOD3;
			if (kw.Length != 33)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			ulong b4 = block[4];
			ulong b5 = block[5];
			ulong b6 = block[6];
			ulong b7 = block[7];
			ulong b8 = block[8];
			ulong b9 = block[9];
			ulong b10 = block[10];
			ulong b11 = block[11];
			ulong b12 = block[12];
			ulong b13 = block[13];
			ulong b14 = block[14];
			ulong b15 = block[15];
			b0 += kw[0];
			b1 += kw[1];
			b2 += kw[2];
			b3 += kw[3];
			b4 += kw[4];
			b5 += kw[5];
			b6 += kw[6];
			b7 += kw[7];
			b8 += kw[8];
			b9 += kw[9];
			b10 += kw[10];
			b11 += kw[11];
			b12 += kw[12];
			b13 += kw[13] + t[0];
			b14 += kw[14] + t[1];
			b15 += kw[15];
			for (int d = 1; d < 20; d += 2)
			{
				int dm17 = mod17[d];
				int dm18 = mod18[d];
				b1 = RotlXor(b1, 24, b0 += b1);
				b3 = RotlXor(b3, 13, b2 += b3);
				b5 = RotlXor(b5, 8, b4 += b5);
				b7 = RotlXor(b7, 47, b6 += b7);
				b9 = RotlXor(b9, 8, b8 += b9);
				b11 = RotlXor(b11, 17, b10 += b11);
				b13 = RotlXor(b13, 22, b12 += b13);
				b15 = RotlXor(b15, 37, b14 += b15);
				b9 = RotlXor(b9, 38, b0 += b9);
				b13 = RotlXor(b13, 19, b2 += b13);
				b11 = RotlXor(b11, 10, b6 += b11);
				b15 = RotlXor(b15, 55, b4 += b15);
				b7 = RotlXor(b7, 49, b10 += b7);
				b3 = RotlXor(b3, 18, b12 += b3);
				b5 = RotlXor(b5, 23, b14 += b5);
				b1 = RotlXor(b1, 52, b8 += b1);
				b7 = RotlXor(b7, 33, b0 += b7);
				b5 = RotlXor(b5, 4, b2 += b5);
				b3 = RotlXor(b3, 51, b4 += b3);
				b1 = RotlXor(b1, 13, b6 += b1);
				b15 = RotlXor(b15, 34, b12 += b15);
				b13 = RotlXor(b13, 41, b14 += b13);
				b11 = RotlXor(b11, 59, b8 += b11);
				b9 = RotlXor(b9, 17, b10 += b9);
				b15 = RotlXor(b15, 5, b0 += b15);
				b11 = RotlXor(b11, 20, b2 += b11);
				b13 = RotlXor(b13, 48, b6 += b13);
				b9 = RotlXor(b9, 41, b4 += b9);
				b1 = RotlXor(b1, 47, b14 += b1);
				b5 = RotlXor(b5, 28, b8 += b5);
				b3 = RotlXor(b3, 16, b10 += b3);
				b7 = RotlXor(b7, 25, b12 += b7);
				b0 += kw[dm17];
				b1 += kw[dm17 + 1];
				b2 += kw[dm17 + 2];
				b3 += kw[dm17 + 3];
				b4 += kw[dm17 + 4];
				b5 += kw[dm17 + 5];
				b6 += kw[dm17 + 6];
				b7 += kw[dm17 + 7];
				b8 += kw[dm17 + 8];
				b9 += kw[dm17 + 9];
				b10 += kw[dm17 + 10];
				b11 += kw[dm17 + 11];
				b12 += kw[dm17 + 12];
				b13 += kw[dm17 + 13] + t[dm18];
				b14 += kw[dm17 + 14] + t[dm18 + 1];
				b15 += kw[dm17 + 15] + (uint)d;
				b1 = RotlXor(b1, 41, b0 += b1);
				b3 = RotlXor(b3, 9, b2 += b3);
				b5 = RotlXor(b5, 37, b4 += b5);
				b7 = RotlXor(b7, 31, b6 += b7);
				b9 = RotlXor(b9, 12, b8 += b9);
				b11 = RotlXor(b11, 47, b10 += b11);
				b13 = RotlXor(b13, 44, b12 += b13);
				b15 = RotlXor(b15, 30, b14 += b15);
				b9 = RotlXor(b9, 16, b0 += b9);
				b13 = RotlXor(b13, 34, b2 += b13);
				b11 = RotlXor(b11, 56, b6 += b11);
				b15 = RotlXor(b15, 51, b4 += b15);
				b7 = RotlXor(b7, 4, b10 += b7);
				b3 = RotlXor(b3, 53, b12 += b3);
				b5 = RotlXor(b5, 42, b14 += b5);
				b1 = RotlXor(b1, 41, b8 += b1);
				b7 = RotlXor(b7, 31, b0 += b7);
				b5 = RotlXor(b5, 44, b2 += b5);
				b3 = RotlXor(b3, 47, b4 += b3);
				b1 = RotlXor(b1, 46, b6 += b1);
				b15 = RotlXor(b15, 19, b12 += b15);
				b13 = RotlXor(b13, 42, b14 += b13);
				b11 = RotlXor(b11, 44, b8 += b11);
				b9 = RotlXor(b9, 25, b10 += b9);
				b15 = RotlXor(b15, 9, b0 += b15);
				b11 = RotlXor(b11, 48, b2 += b11);
				b13 = RotlXor(b13, 35, b6 += b13);
				b9 = RotlXor(b9, 52, b4 += b9);
				b1 = RotlXor(b1, 23, b14 += b1);
				b5 = RotlXor(b5, 31, b8 += b5);
				b3 = RotlXor(b3, 37, b10 += b3);
				b7 = RotlXor(b7, 20, b12 += b7);
				b0 += kw[dm17 + 1];
				b1 += kw[dm17 + 2];
				b2 += kw[dm17 + 3];
				b3 += kw[dm17 + 4];
				b4 += kw[dm17 + 5];
				b5 += kw[dm17 + 6];
				b6 += kw[dm17 + 7];
				b7 += kw[dm17 + 8];
				b8 += kw[dm17 + 9];
				b9 += kw[dm17 + 10];
				b10 += kw[dm17 + 11];
				b11 += kw[dm17 + 12];
				b12 += kw[dm17 + 13];
				b13 += kw[dm17 + 14] + t[dm18 + 1];
				b14 += kw[dm17 + 15] + t[dm18 + 2];
				b15 += kw[dm17 + 16] + (uint)d + 1;
			}
			outWords[0] = b0;
			outWords[1] = b1;
			outWords[2] = b2;
			outWords[3] = b3;
			outWords[4] = b4;
			outWords[5] = b5;
			outWords[6] = b6;
			outWords[7] = b7;
			outWords[8] = b8;
			outWords[9] = b9;
			outWords[10] = b10;
			outWords[11] = b11;
			outWords[12] = b12;
			outWords[13] = b13;
			outWords[14] = b14;
			outWords[15] = b15;
		}

		internal override void DecryptBlock(ulong[] block, ulong[] state)
		{
			ulong[] kw = base.kw;
			ulong[] t = base.t;
			int[] mod17 = MOD17;
			int[] mod18 = MOD3;
			if (kw.Length != 33)
			{
				throw new ArgumentException();
			}
			if (t.Length != 5)
			{
				throw new ArgumentException();
			}
			ulong b0 = block[0];
			ulong b1 = block[1];
			ulong b2 = block[2];
			ulong b3 = block[3];
			ulong b4 = block[4];
			ulong b5 = block[5];
			ulong b6 = block[6];
			ulong b7 = block[7];
			ulong b8 = block[8];
			ulong b9 = block[9];
			ulong b10 = block[10];
			ulong b11 = block[11];
			ulong b12 = block[12];
			ulong b13 = block[13];
			ulong b14 = block[14];
			ulong b15 = block[15];
			for (int d = 19; d >= 1; d -= 2)
			{
				int dm17 = mod17[d];
				int dm18 = mod18[d];
				b0 -= kw[dm17 + 1];
				b1 -= kw[dm17 + 2];
				b2 -= kw[dm17 + 3];
				b3 -= kw[dm17 + 4];
				b4 -= kw[dm17 + 5];
				b5 -= kw[dm17 + 6];
				b6 -= kw[dm17 + 7];
				b7 -= kw[dm17 + 8];
				b8 -= kw[dm17 + 9];
				b9 -= kw[dm17 + 10];
				b10 -= kw[dm17 + 11];
				b11 -= kw[dm17 + 12];
				b12 -= kw[dm17 + 13];
				b13 -= kw[dm17 + 14] + t[dm18 + 1];
				b14 -= kw[dm17 + 15] + t[dm18 + 2];
				b15 -= kw[dm17 + 16] + (uint)d + 1;
				b15 = XorRotr(b15, 9, b0);
				b0 -= b15;
				b11 = XorRotr(b11, 48, b2);
				b2 -= b11;
				b13 = XorRotr(b13, 35, b6);
				b6 -= b13;
				b9 = XorRotr(b9, 52, b4);
				b4 -= b9;
				b1 = XorRotr(b1, 23, b14);
				b14 -= b1;
				b5 = XorRotr(b5, 31, b8);
				b8 -= b5;
				b3 = XorRotr(b3, 37, b10);
				b10 -= b3;
				b7 = XorRotr(b7, 20, b12);
				b12 -= b7;
				b7 = XorRotr(b7, 31, b0);
				b0 -= b7;
				b5 = XorRotr(b5, 44, b2);
				b2 -= b5;
				b3 = XorRotr(b3, 47, b4);
				b4 -= b3;
				b1 = XorRotr(b1, 46, b6);
				b6 -= b1;
				b15 = XorRotr(b15, 19, b12);
				b12 -= b15;
				b13 = XorRotr(b13, 42, b14);
				b14 -= b13;
				b11 = XorRotr(b11, 44, b8);
				b8 -= b11;
				b9 = XorRotr(b9, 25, b10);
				b10 -= b9;
				b9 = XorRotr(b9, 16, b0);
				b0 -= b9;
				b13 = XorRotr(b13, 34, b2);
				b2 -= b13;
				b11 = XorRotr(b11, 56, b6);
				b6 -= b11;
				b15 = XorRotr(b15, 51, b4);
				b4 -= b15;
				b7 = XorRotr(b7, 4, b10);
				b10 -= b7;
				b3 = XorRotr(b3, 53, b12);
				b12 -= b3;
				b5 = XorRotr(b5, 42, b14);
				b14 -= b5;
				b1 = XorRotr(b1, 41, b8);
				b8 -= b1;
				b1 = XorRotr(b1, 41, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 9, b2);
				b2 -= b3;
				b5 = XorRotr(b5, 37, b4);
				b4 -= b5;
				b7 = XorRotr(b7, 31, b6);
				b6 -= b7;
				b9 = XorRotr(b9, 12, b8);
				b8 -= b9;
				b11 = XorRotr(b11, 47, b10);
				b10 -= b11;
				b13 = XorRotr(b13, 44, b12);
				b12 -= b13;
				b15 = XorRotr(b15, 30, b14);
				b14 -= b15;
				b0 -= kw[dm17];
				b1 -= kw[dm17 + 1];
				b2 -= kw[dm17 + 2];
				b3 -= kw[dm17 + 3];
				b4 -= kw[dm17 + 4];
				b5 -= kw[dm17 + 5];
				b6 -= kw[dm17 + 6];
				b7 -= kw[dm17 + 7];
				b8 -= kw[dm17 + 8];
				b9 -= kw[dm17 + 9];
				b10 -= kw[dm17 + 10];
				b11 -= kw[dm17 + 11];
				b12 -= kw[dm17 + 12];
				b13 -= kw[dm17 + 13] + t[dm18];
				b14 -= kw[dm17 + 14] + t[dm18 + 1];
				b15 -= kw[dm17 + 15] + (uint)d;
				b15 = XorRotr(b15, 5, b0);
				b0 -= b15;
				b11 = XorRotr(b11, 20, b2);
				b2 -= b11;
				b13 = XorRotr(b13, 48, b6);
				b6 -= b13;
				b9 = XorRotr(b9, 41, b4);
				b4 -= b9;
				b1 = XorRotr(b1, 47, b14);
				b14 -= b1;
				b5 = XorRotr(b5, 28, b8);
				b8 -= b5;
				b3 = XorRotr(b3, 16, b10);
				b10 -= b3;
				b7 = XorRotr(b7, 25, b12);
				b12 -= b7;
				b7 = XorRotr(b7, 33, b0);
				b0 -= b7;
				b5 = XorRotr(b5, 4, b2);
				b2 -= b5;
				b3 = XorRotr(b3, 51, b4);
				b4 -= b3;
				b1 = XorRotr(b1, 13, b6);
				b6 -= b1;
				b15 = XorRotr(b15, 34, b12);
				b12 -= b15;
				b13 = XorRotr(b13, 41, b14);
				b14 -= b13;
				b11 = XorRotr(b11, 59, b8);
				b8 -= b11;
				b9 = XorRotr(b9, 17, b10);
				b10 -= b9;
				b9 = XorRotr(b9, 38, b0);
				b0 -= b9;
				b13 = XorRotr(b13, 19, b2);
				b2 -= b13;
				b11 = XorRotr(b11, 10, b6);
				b6 -= b11;
				b15 = XorRotr(b15, 55, b4);
				b4 -= b15;
				b7 = XorRotr(b7, 49, b10);
				b10 -= b7;
				b3 = XorRotr(b3, 18, b12);
				b12 -= b3;
				b5 = XorRotr(b5, 23, b14);
				b14 -= b5;
				b1 = XorRotr(b1, 52, b8);
				b8 -= b1;
				b1 = XorRotr(b1, 24, b0);
				b0 -= b1;
				b3 = XorRotr(b3, 13, b2);
				b2 -= b3;
				b5 = XorRotr(b5, 8, b4);
				b4 -= b5;
				b7 = XorRotr(b7, 47, b6);
				b6 -= b7;
				b9 = XorRotr(b9, 8, b8);
				b8 -= b9;
				b11 = XorRotr(b11, 17, b10);
				b10 -= b11;
				b13 = XorRotr(b13, 22, b12);
				b12 -= b13;
				b15 = XorRotr(b15, 37, b14);
				b14 -= b15;
			}
			b0 -= kw[0];
			b1 -= kw[1];
			b2 -= kw[2];
			b3 -= kw[3];
			b4 -= kw[4];
			b5 -= kw[5];
			b6 -= kw[6];
			b7 -= kw[7];
			b8 -= kw[8];
			b9 -= kw[9];
			b10 -= kw[10];
			b11 -= kw[11];
			b12 -= kw[12];
			b13 -= kw[13] + t[0];
			b14 -= kw[14] + t[1];
			b15 -= kw[15];
			state[0] = b0;
			state[1] = b1;
			state[2] = b2;
			state[3] = b3;
			state[4] = b4;
			state[5] = b5;
			state[6] = b6;
			state[7] = b7;
			state[8] = b8;
			state[9] = b9;
			state[10] = b10;
			state[11] = b11;
			state[12] = b12;
			state[13] = b13;
			state[14] = b14;
			state[15] = b15;
		}
	}

	public const int BLOCKSIZE_256 = 256;

	public const int BLOCKSIZE_512 = 512;

	public const int BLOCKSIZE_1024 = 1024;

	private const int TWEAK_SIZE_BYTES = 16;

	private const int TWEAK_SIZE_WORDS = 2;

	private const int ROUNDS_256 = 72;

	private const int ROUNDS_512 = 72;

	private const int ROUNDS_1024 = 80;

	private const int MAX_ROUNDS = 80;

	private const ulong C_240 = 2004413935125273122uL;

	private static readonly int[] MOD9;

	private static readonly int[] MOD17;

	private static readonly int[] MOD5;

	private static readonly int[] MOD3;

	private readonly int blocksizeBytes;

	private readonly int blocksizeWords;

	private readonly ulong[] currentBlock;

	private readonly ulong[] t = new ulong[5];

	private readonly ulong[] kw;

	private readonly ThreefishCipher cipher;

	private bool forEncryption;

	public virtual string AlgorithmName => "Threefish-" + blocksizeBytes * 8;

	public virtual bool IsPartialBlockOkay => false;

	static ThreefishEngine()
	{
		MOD9 = new int[80];
		MOD17 = new int[MOD9.Length];
		MOD5 = new int[MOD9.Length];
		MOD3 = new int[MOD9.Length];
		for (int i = 0; i < MOD9.Length; i++)
		{
			MOD17[i] = i % 17;
			MOD9[i] = i % 9;
			MOD5[i] = i % 5;
			MOD3[i] = i % 3;
		}
	}

	public ThreefishEngine(int blocksizeBits)
	{
		blocksizeBytes = blocksizeBits / 8;
		blocksizeWords = blocksizeBytes / 8;
		currentBlock = new ulong[blocksizeWords];
		kw = new ulong[2 * blocksizeWords + 1];
		switch (blocksizeBits)
		{
		case 256:
			cipher = new Threefish256Cipher(kw, t);
			break;
		case 512:
			cipher = new Threefish512Cipher(kw, t);
			break;
		case 1024:
			cipher = new Threefish1024Cipher(kw, t);
			break;
		default:
			throw new ArgumentException("Invalid blocksize - Threefish is defined with block size of 256, 512, or 1024 bits");
		}
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		byte[] keyBytes;
		byte[] tweakBytes;
		if (parameters is TweakableBlockCipherParameters)
		{
			TweakableBlockCipherParameters obj = (TweakableBlockCipherParameters)parameters;
			keyBytes = obj.Key.GetKey();
			tweakBytes = obj.Tweak;
		}
		else
		{
			if (!(parameters is KeyParameter))
			{
				throw new ArgumentException("Invalid parameter passed to Threefish init - " + Platform.GetTypeName(parameters));
			}
			keyBytes = ((KeyParameter)parameters).GetKey();
			tweakBytes = null;
		}
		ulong[] keyWords = null;
		ulong[] tweakWords = null;
		if (keyBytes != null)
		{
			if (keyBytes.Length != blocksizeBytes)
			{
				throw new ArgumentException("Threefish key must be same size as block (" + blocksizeBytes + " bytes)");
			}
			keyWords = new ulong[blocksizeWords];
			for (int i = 0; i < keyWords.Length; i++)
			{
				keyWords[i] = BytesToWord(keyBytes, i * 8);
			}
		}
		if (tweakBytes != null)
		{
			if (tweakBytes.Length != 16)
			{
				throw new ArgumentException("Threefish tweak must be " + 16 + " bytes");
			}
			tweakWords = new ulong[2]
			{
				BytesToWord(tweakBytes, 0),
				BytesToWord(tweakBytes, 8)
			};
		}
		Init(forEncryption, keyWords, tweakWords);
	}

	internal void Init(bool forEncryption, ulong[] key, ulong[] tweak)
	{
		this.forEncryption = forEncryption;
		if (key != null)
		{
			SetKey(key);
		}
		if (tweak != null)
		{
			SetTweak(tweak);
		}
	}

	private void SetKey(ulong[] key)
	{
		if (key.Length != blocksizeWords)
		{
			throw new ArgumentException("Threefish key must be same size as block (" + blocksizeWords + " words)");
		}
		ulong knw = 2004413935125273122uL;
		for (int i = 0; i < blocksizeWords; i++)
		{
			kw[i] = key[i];
			knw ^= kw[i];
		}
		kw[blocksizeWords] = knw;
		Array.Copy(kw, 0, kw, blocksizeWords + 1, blocksizeWords);
	}

	private void SetTweak(ulong[] tweak)
	{
		if (tweak.Length != 2)
		{
			throw new ArgumentException("Tweak must be " + 2 + " words.");
		}
		t[0] = tweak[0];
		t[1] = tweak[1];
		t[2] = t[0] ^ t[1];
		t[3] = t[0];
		t[4] = t[1];
	}

	public virtual int GetBlockSize()
	{
		return blocksizeBytes;
	}

	public virtual void Reset()
	{
	}

	public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		if (outOff + blocksizeBytes > outBytes.Length)
		{
			throw new DataLengthException("Output buffer too short");
		}
		if (inOff + blocksizeBytes > inBytes.Length)
		{
			throw new DataLengthException("Input buffer too short");
		}
		for (int i = 0; i < blocksizeBytes; i += 8)
		{
			currentBlock[i >> 3] = BytesToWord(inBytes, inOff + i);
		}
		ProcessBlock(currentBlock, currentBlock);
		for (int j = 0; j < blocksizeBytes; j += 8)
		{
			WordToBytes(currentBlock[j >> 3], outBytes, outOff + j);
		}
		return blocksizeBytes;
	}

	internal int ProcessBlock(ulong[] inWords, ulong[] outWords)
	{
		if (kw[blocksizeWords] == 0L)
		{
			throw new InvalidOperationException("Threefish engine not initialised");
		}
		if (inWords.Length != blocksizeWords)
		{
			throw new DataLengthException("Input buffer too short");
		}
		if (outWords.Length != blocksizeWords)
		{
			throw new DataLengthException("Output buffer too short");
		}
		if (forEncryption)
		{
			cipher.EncryptBlock(inWords, outWords);
		}
		else
		{
			cipher.DecryptBlock(inWords, outWords);
		}
		return blocksizeWords;
	}

	internal static ulong BytesToWord(byte[] bytes, int off)
	{
		if (off + 8 > bytes.Length)
		{
			throw new ArgumentException();
		}
		int index = off;
		return ((ulong)bytes[index++] & 0xFFuL) | (((ulong)bytes[index++] & 0xFFuL) << 8) | (((ulong)bytes[index++] & 0xFFuL) << 16) | (((ulong)bytes[index++] & 0xFFuL) << 24) | (((ulong)bytes[index++] & 0xFFuL) << 32) | (((ulong)bytes[index++] & 0xFFuL) << 40) | (((ulong)bytes[index++] & 0xFFuL) << 48) | (((ulong)bytes[index++] & 0xFFuL) << 56);
	}

	internal static void WordToBytes(ulong word, byte[] bytes, int off)
	{
		if (off + 8 > bytes.Length)
		{
			throw new ArgumentException();
		}
		int index = off;
		bytes[index++] = (byte)word;
		bytes[index++] = (byte)(word >> 8);
		bytes[index++] = (byte)(word >> 16);
		bytes[index++] = (byte)(word >> 24);
		bytes[index++] = (byte)(word >> 32);
		bytes[index++] = (byte)(word >> 40);
		bytes[index++] = (byte)(word >> 48);
		bytes[index++] = (byte)(word >> 56);
	}

	private static ulong RotlXor(ulong x, int n, ulong xor)
	{
		return ((x << n) | (x >> 64 - n)) ^ xor;
	}

	private static ulong XorRotr(ulong x, int n, ulong xor)
	{
		ulong xored = x ^ xor;
		return (xored >> n) | (xored << 64 - n);
	}
}
