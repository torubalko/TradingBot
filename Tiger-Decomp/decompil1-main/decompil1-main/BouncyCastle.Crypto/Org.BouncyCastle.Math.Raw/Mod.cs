using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.Raw;

internal abstract class Mod
{
	private static readonly SecureRandom RandomSource = new SecureRandom();

	private const int M30 = 1073741823;

	private const ulong M32UL = 4294967295uL;

	public static void CheckedModOddInverse(uint[] m, uint[] x, uint[] z)
	{
		if (ModOddInverse(m, x, z) == 0)
		{
			throw new ArithmeticException("Inverse does not exist.");
		}
	}

	public static void CheckedModOddInverseVar(uint[] m, uint[] x, uint[] z)
	{
		if (!ModOddInverseVar(m, x, z))
		{
			throw new ArithmeticException("Inverse does not exist.");
		}
	}

	public static uint Inverse32(uint d)
	{
		uint x = d;
		x *= 2 - d * x;
		x *= 2 - d * x;
		x *= 2 - d * x;
		return x * (2 - d * x);
	}

	public static uint ModOddInverse(uint[] m, uint[] x, uint[] z)
	{
		int len32 = m.Length;
		int bits = (len32 << 5) - Integers.NumberOfLeadingZeros((int)m[len32 - 1]);
		int len33 = (bits + 29) / 30;
		int[] t = new int[4];
		int[] D = new int[len33];
		int[] E = new int[len33];
		int[] F = new int[len33];
		int[] G = new int[len33];
		int[] M = new int[len33];
		E[0] = 1;
		Encode30(bits, x, 0, G, 0);
		Encode30(bits, m, 0, M, 0);
		Array.Copy(M, 0, F, 0, len33);
		int eta = -1;
		int m0Inv32 = (int)Inverse32((uint)M[0]);
		int maxDivsteps = GetMaximumDivsteps(bits);
		for (int divSteps = 0; divSteps < maxDivsteps; divSteps += 30)
		{
			eta = Divsteps30(eta, F[0], G[0], t);
			UpdateDE30(len33, D, E, t, m0Inv32, M);
			UpdateFG30(len33, F, G, t);
		}
		int signF = F[len33 - 1] >> 31;
		CNegate30(len33, signF, F);
		CNormalize30(len33, signF, D, M);
		Decode30(bits, D, 0, z, 0);
		return (uint)(EqualTo(len33, F, 1) & EqualToZero(len33, G));
	}

	public static bool ModOddInverseVar(uint[] m, uint[] x, uint[] z)
	{
		int len32 = m.Length;
		int bits = (len32 << 5) - Integers.NumberOfLeadingZeros((int)m[len32 - 1]);
		int len33 = (bits + 29) / 30;
		int[] t = new int[4];
		int[] D = new int[len33];
		int[] E = new int[len33];
		int[] F = new int[len33];
		int[] G = new int[len33];
		int[] M = new int[len33];
		E[0] = 1;
		Encode30(bits, x, 0, G, 0);
		Encode30(bits, m, 0, M, 0);
		Array.Copy(M, 0, F, 0, len33);
		int clzG = Integers.NumberOfLeadingZeros(G[len33 - 1] | 1) - (len33 * 30 + 2 - bits);
		int eta = -1 - clzG;
		int lenDE = len33;
		int lenFG = len33;
		int m0Inv32 = (int)Inverse32((uint)M[0]);
		int maxDivsteps = GetMaximumDivsteps(bits);
		int divsteps = 0;
		while (!IsZero(lenFG, G))
		{
			if (divsteps >= maxDivsteps)
			{
				return false;
			}
			divsteps += 30;
			eta = Divsteps30Var(eta, F[0], G[0], t);
			UpdateDE30(lenDE, D, E, t, m0Inv32, M);
			UpdateFG30(lenFG, F, G, t);
			int fn = F[lenFG - 1];
			int gn = G[lenFG - 1];
			if (((lenFG - 2 >> 31) | (fn ^ (fn >> 31)) | (gn ^ (gn >> 31))) == 0)
			{
				F[lenFG - 2] |= fn << 30;
				G[lenFG - 2] |= gn << 30;
				lenFG--;
			}
		}
		int num = F[lenFG - 1] >> 31;
		int signD = D[lenDE - 1] >> 31;
		if (signD < 0)
		{
			signD = Add30(lenDE, D, M);
		}
		if (num < 0)
		{
			signD = Negate30(lenDE, D);
			Negate30(lenFG, F);
		}
		if (!IsOne(lenFG, F))
		{
			return false;
		}
		if (signD < 0)
		{
			signD = Add30(lenDE, D, M);
		}
		Decode30(bits, D, 0, z, 0);
		return true;
	}

	public static uint[] Random(uint[] p)
	{
		int len = p.Length;
		uint[] s = Nat.Create(len);
		uint m = p[len - 1];
		m |= m >> 1;
		m |= m >> 2;
		m |= m >> 4;
		m |= m >> 8;
		m |= m >> 16;
		do
		{
			byte[] bytes = new byte[len << 2];
			RandomSource.NextBytes(bytes);
			Pack.BE_To_UInt32(bytes, 0, s);
			s[len - 1] &= m;
		}
		while (Nat.Gte(len, s, p));
		return s;
	}

	private static int Add30(int len30, int[] D, int[] M)
	{
		int c = 0;
		int last = len30 - 1;
		for (int i = 0; i < last; i++)
		{
			c += D[i] + M[i];
			D[i] = c & 0x3FFFFFFF;
			c >>= 30;
		}
		return (D[last] = c + (D[last] + M[last])) >> 30;
	}

	private static void CNegate30(int len30, int cond, int[] D)
	{
		int c = 0;
		int last = len30 - 1;
		for (int i = 0; i < last; i++)
		{
			c += (D[i] ^ cond) - cond;
			D[i] = c & 0x3FFFFFFF;
			c >>= 30;
		}
		c += (D[last] ^ cond) - cond;
		D[last] = c;
	}

	private static void CNormalize30(int len30, int condNegate, int[] D, int[] M)
	{
		int last = len30 - 1;
		int c = 0;
		int condAdd = D[last] >> 31;
		for (int i = 0; i < last; i++)
		{
			int di = D[i] + (M[i] & condAdd);
			di = (di ^ condNegate) - condNegate;
			c += di;
			D[i] = c & 0x3FFFFFFF;
			c >>= 30;
		}
		int di2 = D[last] + (M[last] & condAdd);
		di2 = (di2 ^ condNegate) - condNegate;
		c += di2;
		D[last] = c;
		int c2 = 0;
		int condAdd2 = D[last] >> 31;
		for (int j = 0; j < last; j++)
		{
			int di3 = D[j] + (M[j] & condAdd2);
			c2 += di3;
			D[j] = c2 & 0x3FFFFFFF;
			c2 >>= 30;
		}
		int di4 = D[last] + (M[last] & condAdd2);
		c2 += di4;
		D[last] = c2;
	}

	private static void Decode30(int bits, int[] x, int xOff, uint[] z, int zOff)
	{
		int avail = 0;
		ulong data = 0uL;
		while (bits > 0)
		{
			for (; avail < System.Math.Min(32, bits); avail += 30)
			{
				data |= (ulong)((long)x[xOff++] << avail);
			}
			z[zOff++] = (uint)data;
			data >>= 32;
			avail -= 32;
			bits -= 32;
		}
	}

	private static int Divsteps30(int eta, int f0, int g0, int[] t)
	{
		int u = 1;
		int v = 0;
		int q = 0;
		int r = 1;
		int f1 = f0;
		int g1 = g0;
		for (int i = 0; i < 30; i++)
		{
			int c1 = eta >> 31;
			int c2 = -(g1 & 1);
			int x = (f1 ^ c1) - c1;
			int y = (u ^ c1) - c1;
			int z = (v ^ c1) - c1;
			g1 += x & c2;
			q += y & c2;
			r += z & c2;
			c1 &= c2;
			eta = (eta ^ c1) - (c1 + 1);
			f1 += g1 & c1;
			u += q & c1;
			v += r & c1;
			g1 >>= 1;
			u <<= 1;
			v <<= 1;
		}
		t[0] = u;
		t[1] = v;
		t[2] = q;
		t[3] = r;
		return eta;
	}

	private static int Divsteps30Var(int eta, int f0, int g0, int[] t)
	{
		int u = 1;
		int v = 0;
		int q = 0;
		int r = 1;
		int f1 = f0;
		int g1 = g0;
		int i = 30;
		while (true)
		{
			int zeros = Integers.NumberOfTrailingZeros(g1 | (-1 << i));
			g1 >>= zeros;
			u <<= zeros;
			v <<= zeros;
			eta -= zeros;
			i -= zeros;
			if (i <= 0)
			{
				break;
			}
			int w;
			if (eta < 0)
			{
				eta = -eta;
				int num = f1;
				f1 = g1;
				g1 = -num;
				int num2 = u;
				u = q;
				q = -num2;
				int num3 = v;
				v = r;
				r = -num3;
				int limit = ((eta + 1 > i) ? i : (eta + 1));
				int m = (-1 >>> 32 - limit) & 0x3F;
				w = (f1 * g1 * (f1 * f1 - 2)) & m;
			}
			else
			{
				int limit = ((eta + 1 > i) ? i : (eta + 1));
				int m = (-1 >>> 32 - limit) & 0xF;
				w = f1 + (((f1 + 1) & 4) << 1);
				w = (-w * g1) & m;
			}
			g1 += f1 * w;
			q += u * w;
			r += v * w;
		}
		t[0] = u;
		t[1] = v;
		t[2] = q;
		t[3] = r;
		return eta;
	}

	private static void Encode30(int bits, uint[] x, int xOff, int[] z, int zOff)
	{
		int avail = 0;
		ulong data = 0uL;
		while (bits > 0)
		{
			if (avail < System.Math.Min(30, bits))
			{
				data |= ((ulong)x[xOff++] & 0xFFFFFFFFuL) << avail;
				avail += 32;
			}
			z[zOff++] = (int)data & 0x3FFFFFFF;
			data >>= 30;
			avail -= 30;
			bits -= 30;
		}
	}

	private static int EqualTo(int len, int[] x, int y)
	{
		int d = x[0] ^ y;
		for (int i = 1; i < len; i++)
		{
			d |= x[i];
		}
		d = (d >>> 1) | (d & 1);
		return d - 1 >> 31;
	}

	private static int EqualToZero(int len, int[] x)
	{
		int d = 0;
		for (int i = 0; i < len; i++)
		{
			d |= x[i];
		}
		d = (d >>> 1) | (d & 1);
		return d - 1 >> 31;
	}

	private static int GetMaximumDivsteps(int bits)
	{
		return (49 * bits + ((bits < 46) ? 80 : 47)) / 17;
	}

	private static bool IsOne(int len, int[] x)
	{
		if (x[0] != 1)
		{
			return false;
		}
		for (int i = 1; i < len; i++)
		{
			if (x[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	private static bool IsZero(int len, int[] x)
	{
		if (x[0] != 0)
		{
			return false;
		}
		for (int i = 1; i < len; i++)
		{
			if (x[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	private static int Negate30(int len30, int[] D)
	{
		int c = 0;
		int last = len30 - 1;
		for (int i = 0; i < last; i++)
		{
			c -= D[i];
			D[i] = c & 0x3FFFFFFF;
			c >>= 30;
		}
		return (D[last] = c - D[last]) >> 30;
	}

	private static void UpdateDE30(int len30, int[] D, int[] E, int[] t, int m0Inv32, int[] M)
	{
		int u = t[0];
		int v = t[1];
		int q = t[2];
		int r = t[3];
		int sd = D[len30 - 1] >> 31;
		int se = E[len30 - 1] >> 31;
		int md = (u & sd) + (v & se);
		int me = (q & sd) + (r & se);
		int mi = M[0];
		int di = D[0];
		int ei = E[0];
		long cd = (long)u * (long)di + (long)v * (long)ei;
		long ce = (long)q * (long)di + (long)r * (long)ei;
		md -= (m0Inv32 * (int)cd + md) & 0x3FFFFFFF;
		me -= (m0Inv32 * (int)ce + me) & 0x3FFFFFFF;
		cd += (long)mi * (long)md;
		ce += (long)mi * (long)me;
		cd >>= 30;
		ce >>= 30;
		for (int i = 1; i < len30; i++)
		{
			mi = M[i];
			di = D[i];
			ei = E[i];
			cd += (long)u * (long)di + (long)v * (long)ei + (long)mi * (long)md;
			ce += (long)q * (long)di + (long)r * (long)ei + (long)mi * (long)me;
			D[i - 1] = (int)cd & 0x3FFFFFFF;
			cd >>= 30;
			E[i - 1] = (int)ce & 0x3FFFFFFF;
			ce >>= 30;
		}
		D[len30 - 1] = (int)cd;
		E[len30 - 1] = (int)ce;
	}

	private static void UpdateFG30(int len30, int[] F, int[] G, int[] t)
	{
		int u = t[0];
		int v = t[1];
		int q = t[2];
		int r = t[3];
		int fi = F[0];
		int gi = G[0];
		long cf = (long)u * (long)fi + (long)v * (long)gi;
		long cg = (long)q * (long)fi + (long)r * (long)gi;
		cf >>= 30;
		cg >>= 30;
		for (int i = 1; i < len30; i++)
		{
			fi = F[i];
			gi = G[i];
			cf += (long)u * (long)fi + (long)v * (long)gi;
			cg += (long)q * (long)fi + (long)r * (long)gi;
			F[i - 1] = (int)cf & 0x3FFFFFFF;
			cf >>= 30;
			G[i - 1] = (int)cg & 0x3FFFFFFF;
			cg >>= 30;
		}
		F[len30 - 1] = (int)cf;
		G[len30 - 1] = (int)cg;
	}
}
