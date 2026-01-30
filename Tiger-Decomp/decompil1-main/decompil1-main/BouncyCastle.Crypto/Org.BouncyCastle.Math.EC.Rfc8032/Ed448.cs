using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032;

public abstract class Ed448
{
	public enum Algorithm
	{
		Ed448,
		Ed448ph
	}

	private class F : X448Field
	{
	}

	private class PointExt
	{
		internal uint[] x = X448Field.Create();

		internal uint[] y = X448Field.Create();

		internal uint[] z = X448Field.Create();
	}

	private class PointPrecomp
	{
		internal uint[] x = X448Field.Create();

		internal uint[] y = X448Field.Create();
	}

	private const ulong M26UL = 67108863uL;

	private const ulong M28UL = 268435455uL;

	private const int CoordUints = 14;

	private const int PointBytes = 57;

	private const int ScalarUints = 14;

	private const int ScalarBytes = 57;

	public static readonly int PrehashSize = 64;

	public static readonly int PublicKeySize = 57;

	public static readonly int SecretKeySize = 57;

	public static readonly int SignatureSize = 114;

	private static readonly byte[] Dom4Prefix = new byte[8] { 83, 105, 103, 69, 100, 52, 52, 56 };

	private static readonly uint[] P = new uint[14]
	{
		4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967294u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 4294967295u
	};

	private static readonly uint[] L = new uint[14]
	{
		2874688755u, 595116690u, 2378534741u, 560775794u, 2933274256u, 3293502281u, 2093622249u, 4294967295u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 1073741823u
	};

	private const int L_0 = 78101261;

	private const int L_1 = 141809365;

	private const int L_2 = 175155932;

	private const int L_3 = 64542499;

	private const int L_4 = 158326419;

	private const int L_5 = 191173276;

	private const int L_6 = 104575268;

	private const int L_7 = 137584065;

	private const int L4_0 = 43969588;

	private const int L4_1 = 30366549;

	private const int L4_2 = 163752818;

	private const int L4_3 = 258169998;

	private const int L4_4 = 96434764;

	private const int L4_5 = 227822194;

	private const int L4_6 = 149865618;

	private const int L4_7 = 550336261;

	private static readonly uint[] B_x = new uint[16]
	{
		118276190u, 40534716u, 9670182u, 135141552u, 85017403u, 259173222u, 68333082u, 171784774u, 174973732u, 15824510u,
		73756743u, 57518561u, 94773951u, 248652241u, 107736333u, 82941708u
	};

	private static readonly uint[] B_y = new uint[16]
	{
		36764180u, 8885695u, 130592152u, 20104429u, 163904957u, 30304195u, 121295871u, 5901357u, 125344798u, 171541512u,
		175338348u, 209069246u, 3626697u, 38307682u, 24032956u, 110359655u
	};

	private const int C_d = -39081;

	private const int WnafWidthBase = 7;

	private const int PrecompBlocks = 5;

	private const int PrecompTeeth = 5;

	private const int PrecompSpacing = 18;

	private const int PrecompPoints = 16;

	private const int PrecompMask = 15;

	private static readonly object precompLock = new object();

	private static PointExt[] precompBaseTable = null;

	private static uint[] precompBase = null;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		uint[] t = new uint[28];
		DecodeScalar(r, 0, t);
		uint[] u = new uint[14];
		DecodeScalar(k, 0, u);
		uint[] v = new uint[14];
		DecodeScalar(s, 0, v);
		Nat.MulAddTo(14, u, v, t);
		byte[] result = new byte[114];
		for (int i = 0; i < t.Length; i++)
		{
			Encode32(t[i], result, i * 4);
		}
		return ReduceScalar(result);
	}

	private static bool CheckContextVar(byte[] ctx)
	{
		if (ctx != null)
		{
			return ctx.Length < 256;
		}
		return false;
	}

	private static int CheckPoint(uint[] x, uint[] y)
	{
		uint[] t = X448Field.Create();
		uint[] u = X448Field.Create();
		uint[] v = X448Field.Create();
		X448Field.Sqr(x, u);
		X448Field.Sqr(y, v);
		X448Field.Mul(u, v, t);
		X448Field.Add(u, v, u);
		X448Field.Mul(t, 39081u, t);
		X448Field.SubOne(t);
		X448Field.Add(t, u, t);
		X448Field.Normalize(t);
		return X448Field.IsZero(t);
	}

	private static int CheckPoint(uint[] x, uint[] y, uint[] z)
	{
		uint[] t = X448Field.Create();
		uint[] u = X448Field.Create();
		uint[] v = X448Field.Create();
		uint[] w = X448Field.Create();
		X448Field.Sqr(x, u);
		X448Field.Sqr(y, v);
		X448Field.Sqr(z, w);
		X448Field.Mul(u, v, t);
		X448Field.Add(u, v, u);
		X448Field.Mul(u, w, u);
		X448Field.Sqr(w, w);
		X448Field.Mul(t, 39081u, t);
		X448Field.Sub(t, w, t);
		X448Field.Add(t, u, t);
		X448Field.Normalize(t);
		return X448Field.IsZero(t);
	}

	private static bool CheckPointVar(byte[] p)
	{
		if ((p[56] & 0x7F) != 0)
		{
			return false;
		}
		uint[] t = new uint[14];
		Decode32(p, 0, t, 0, 14);
		return !Nat.Gte(14, t, P);
	}

	private static bool CheckScalarVar(byte[] s, uint[] n)
	{
		if (s[56] != 0)
		{
			return false;
		}
		DecodeScalar(s, 0, n);
		return !Nat.Gte(14, n, L);
	}

	private static byte[] Copy(byte[] buf, int off, int len)
	{
		byte[] result = new byte[len];
		Array.Copy(buf, off, result, 0, len);
		return result;
	}

	public static IXof CreatePrehash()
	{
		return CreateXof();
	}

	private static IXof CreateXof()
	{
		return new ShakeDigest(256);
	}

	private static uint Decode16(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8));
	}

	private static uint Decode24(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16));
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	private static void Decode32(byte[] bs, int bsOff, uint[] n, int nOff, int nLen)
	{
		for (int i = 0; i < nLen; i++)
		{
			n[nOff + i] = Decode32(bs, bsOff + i * 4);
		}
	}

	private static bool DecodePointVar(byte[] p, int pOff, bool negate, PointExt r)
	{
		byte[] py = Copy(p, pOff, 57);
		if (!CheckPointVar(py))
		{
			return false;
		}
		int x_0 = (py[56] & 0x80) >> 7;
		py[56] &= 127;
		X448Field.Decode(py, 0, r.y);
		uint[] u = X448Field.Create();
		uint[] v = X448Field.Create();
		X448Field.Sqr(r.y, u);
		X448Field.Mul(u, 39081u, v);
		X448Field.Negate(u, u);
		X448Field.AddOne(u);
		X448Field.AddOne(v);
		if (!X448Field.SqrtRatioVar(u, v, r.x))
		{
			return false;
		}
		X448Field.Normalize(r.x);
		if (x_0 == 1 && X448Field.IsZeroVar(r.x))
		{
			return false;
		}
		if (negate ^ (x_0 != (r.x[0] & 1)))
		{
			X448Field.Negate(r.x, r.x);
		}
		PointExtendXY(r);
		return true;
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		Decode32(k, kOff, n, 0, 14);
	}

	private static void Dom4(IXof d, byte phflag, byte[] ctx)
	{
		int n = Dom4Prefix.Length;
		byte[] t = new byte[n + 2 + ctx.Length];
		Dom4Prefix.CopyTo(t, 0);
		t[n] = phflag;
		t[n + 1] = (byte)ctx.Length;
		ctx.CopyTo(t, n + 2);
		d.BlockUpdate(t, 0, t.Length);
	}

	private static void Encode24(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
		bs[++off] = (byte)(n >> 24);
	}

	private static void Encode56(ulong n, byte[] bs, int off)
	{
		Encode32((uint)n, bs, off);
		Encode24((uint)(n >> 32), bs, off + 4);
	}

	private static int EncodePoint(PointExt p, byte[] r, int rOff)
	{
		uint[] x = X448Field.Create();
		uint[] y = X448Field.Create();
		X448Field.Inv(p.z, y);
		X448Field.Mul(p.x, y, x);
		X448Field.Mul(p.y, y, y);
		X448Field.Normalize(x);
		X448Field.Normalize(y);
		int result = CheckPoint(x, y);
		X448Field.Encode(y, r, rOff);
		r[rOff + 57 - 1] = (byte)((x[0] & 1) << 7);
		return result;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
		random.NextBytes(k);
	}

	public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
	{
		IXof xof = CreateXof();
		byte[] h = new byte[114];
		xof.BlockUpdate(sk, skOff, SecretKeySize);
		xof.DoFinal(h, 0, h.Length);
		byte[] s = new byte[57];
		PruneScalar(h, 0, s);
		ScalarMultBaseEncoded(s, pk, pkOff);
	}

	private static uint GetWindow4(uint[] x, int n)
	{
		int w = n >>> 3;
		int b = (n & 7) << 2;
		return (x[w] >> b) & 0xF;
	}

	private static sbyte[] GetWnafVar(uint[] n, int width)
	{
		uint[] t = new uint[28];
		uint c = 0u;
		int tPos = t.Length;
		int i = 14;
		while (--i >= 0)
		{
			uint next = n[i];
			t[--tPos] = (next >> 16) | (c << 16);
			c = (t[--tPos] = next);
		}
		sbyte[] ws = new sbyte[447];
		int lead = 32 - width;
		uint carry = 0u;
		int j = 0;
		int i2 = 0;
		while (i2 < t.Length)
		{
			uint word = t[i2];
			while (j < 16)
			{
				uint word16 = word >> j;
				if ((word16 & 1) == carry)
				{
					j++;
					continue;
				}
				uint digit = (word16 | 1) << lead;
				carry = digit >> 31;
				ws[(i2 << 4) + j] = (sbyte)((int)digit >> lead);
				j += width;
			}
			i2++;
			j -= 16;
		}
		return ws;
	}

	private static void ImplSign(IXof d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		Dom4(d, phflag, ctx);
		d.BlockUpdate(h, 57, 57);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0, h.Length);
		byte[] array = ReduceScalar(h);
		byte[] R = new byte[57];
		ScalarMultBaseEncoded(array, R, 0);
		Dom4(d, phflag, ctx);
		d.BlockUpdate(R, 0, 57);
		d.BlockUpdate(pk, pkOff, 57);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0, h.Length);
		byte[] k = ReduceScalar(h);
		byte[] sourceArray = CalculateS(array, k, s);
		Array.Copy(R, 0, sig, sigOff, 57);
		Array.Copy(sourceArray, 0, sig, sigOff + 57, 57);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		IXof xof = CreateXof();
		byte[] h = new byte[114];
		xof.BlockUpdate(sk, skOff, SecretKeySize);
		xof.DoFinal(h, 0, h.Length);
		byte[] s = new byte[57];
		PruneScalar(h, 0, s);
		byte[] pk = new byte[57];
		ScalarMultBaseEncoded(s, pk, 0);
		ImplSign(xof, h, s, pk, 0, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		IXof xof = CreateXof();
		byte[] h = new byte[114];
		xof.BlockUpdate(sk, skOff, SecretKeySize);
		xof.DoFinal(h, 0, h.Length);
		byte[] s = new byte[57];
		PruneScalar(h, 0, s);
		ImplSign(xof, h, s, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		byte[] R = Copy(sig, sigOff, 57);
		byte[] S = Copy(sig, sigOff + 57, 57);
		if (!CheckPointVar(R))
		{
			return false;
		}
		uint[] nS = new uint[14];
		if (!CheckScalarVar(S, nS))
		{
			return false;
		}
		PointExt pA = new PointExt();
		if (!DecodePointVar(pk, pkOff, negate: true, pA))
		{
			return false;
		}
		IXof xof = CreateXof();
		byte[] h = new byte[114];
		Dom4(xof, phflag, ctx);
		xof.BlockUpdate(R, 0, 57);
		xof.BlockUpdate(pk, pkOff, 57);
		xof.BlockUpdate(m, mOff, mLen);
		xof.DoFinal(h, 0, h.Length);
		byte[] k = ReduceScalar(h);
		uint[] nA = new uint[14];
		DecodeScalar(k, 0, nA);
		PointExt pR = new PointExt();
		ScalarMultStrausVar(nS, nA, pA, pR);
		byte[] check = new byte[57];
		if (EncodePoint(pR, check, 0) != 0)
		{
			return Arrays.AreEqual(check, R);
		}
		return false;
	}

	private static bool IsNeutralElementVar(uint[] x, uint[] y)
	{
		if (X448Field.IsZeroVar(x))
		{
			return X448Field.IsOneVar(y);
		}
		return false;
	}

	private static bool IsNeutralElementVar(uint[] x, uint[] y, uint[] z)
	{
		if (X448Field.IsZeroVar(x))
		{
			return X448Field.AreEqualVar(y, z);
		}
		return false;
	}

	private static void PointAdd(PointExt p, PointExt r)
	{
		uint[] a = X448Field.Create();
		uint[] b = X448Field.Create();
		uint[] c = X448Field.Create();
		uint[] d = X448Field.Create();
		uint[] e = X448Field.Create();
		uint[] f = X448Field.Create();
		uint[] g = X448Field.Create();
		uint[] h = X448Field.Create();
		X448Field.Mul(p.z, r.z, a);
		X448Field.Sqr(a, b);
		X448Field.Mul(p.x, r.x, c);
		X448Field.Mul(p.y, r.y, d);
		X448Field.Mul(c, d, e);
		X448Field.Mul(e, 39081u, e);
		X448Field.Add(b, e, f);
		X448Field.Sub(b, e, g);
		X448Field.Add(p.x, p.y, b);
		X448Field.Add(r.x, r.y, e);
		X448Field.Mul(b, e, h);
		X448Field.Add(d, c, b);
		X448Field.Sub(d, c, e);
		X448Field.Carry(b);
		X448Field.Sub(h, b, h);
		X448Field.Mul(h, a, h);
		X448Field.Mul(e, a, e);
		X448Field.Mul(f, h, r.x);
		X448Field.Mul(e, g, r.y);
		X448Field.Mul(f, g, r.z);
	}

	private static void PointAddVar(bool negate, PointExt p, PointExt r)
	{
		uint[] a = X448Field.Create();
		uint[] b = X448Field.Create();
		uint[] c = X448Field.Create();
		uint[] d = X448Field.Create();
		uint[] e = X448Field.Create();
		uint[] f = X448Field.Create();
		uint[] g = X448Field.Create();
		uint[] h = X448Field.Create();
		uint[] nb;
		uint[] ne;
		uint[] nf;
		uint[] ng;
		if (negate)
		{
			nb = e;
			ne = b;
			nf = g;
			ng = f;
			X448Field.Sub(p.y, p.x, h);
		}
		else
		{
			nb = b;
			ne = e;
			nf = f;
			ng = g;
			X448Field.Add(p.y, p.x, h);
		}
		X448Field.Mul(p.z, r.z, a);
		X448Field.Sqr(a, b);
		X448Field.Mul(p.x, r.x, c);
		X448Field.Mul(p.y, r.y, d);
		X448Field.Mul(c, d, e);
		X448Field.Mul(e, 39081u, e);
		X448Field.Add(b, e, nf);
		X448Field.Sub(b, e, ng);
		X448Field.Add(r.x, r.y, e);
		X448Field.Mul(h, e, h);
		X448Field.Add(d, c, nb);
		X448Field.Sub(d, c, ne);
		X448Field.Carry(nb);
		X448Field.Sub(h, b, h);
		X448Field.Mul(h, a, h);
		X448Field.Mul(e, a, e);
		X448Field.Mul(f, h, r.x);
		X448Field.Mul(e, g, r.y);
		X448Field.Mul(f, g, r.z);
	}

	private static void PointAddPrecomp(PointPrecomp p, PointExt r)
	{
		uint[] b = X448Field.Create();
		uint[] c = X448Field.Create();
		uint[] d = X448Field.Create();
		uint[] e = X448Field.Create();
		uint[] f = X448Field.Create();
		uint[] g = X448Field.Create();
		uint[] h = X448Field.Create();
		X448Field.Sqr(r.z, b);
		X448Field.Mul(p.x, r.x, c);
		X448Field.Mul(p.y, r.y, d);
		X448Field.Mul(c, d, e);
		X448Field.Mul(e, 39081u, e);
		X448Field.Add(b, e, f);
		X448Field.Sub(b, e, g);
		X448Field.Add(p.x, p.y, b);
		X448Field.Add(r.x, r.y, e);
		X448Field.Mul(b, e, h);
		X448Field.Add(d, c, b);
		X448Field.Sub(d, c, e);
		X448Field.Carry(b);
		X448Field.Sub(h, b, h);
		X448Field.Mul(h, r.z, h);
		X448Field.Mul(e, r.z, e);
		X448Field.Mul(f, h, r.x);
		X448Field.Mul(e, g, r.y);
		X448Field.Mul(f, g, r.z);
	}

	private static PointExt PointCopy(PointExt p)
	{
		PointExt r = new PointExt();
		PointCopy(p, r);
		return r;
	}

	private static void PointCopy(PointExt p, PointExt r)
	{
		X448Field.Copy(p.x, 0, r.x, 0);
		X448Field.Copy(p.y, 0, r.y, 0);
		X448Field.Copy(p.z, 0, r.z, 0);
	}

	private static void PointDouble(PointExt r)
	{
		uint[] b = X448Field.Create();
		uint[] c = X448Field.Create();
		uint[] d = X448Field.Create();
		uint[] e = X448Field.Create();
		uint[] h = X448Field.Create();
		uint[] j = X448Field.Create();
		X448Field.Add(r.x, r.y, b);
		X448Field.Sqr(b, b);
		X448Field.Sqr(r.x, c);
		X448Field.Sqr(r.y, d);
		X448Field.Add(c, d, e);
		X448Field.Carry(e);
		X448Field.Sqr(r.z, h);
		X448Field.Add(h, h, h);
		X448Field.Carry(h);
		X448Field.Sub(e, h, j);
		X448Field.Sub(b, e, b);
		X448Field.Sub(c, d, c);
		X448Field.Mul(b, j, r.x);
		X448Field.Mul(e, c, r.y);
		X448Field.Mul(e, j, r.z);
	}

	private static void PointExtendXY(PointExt p)
	{
		X448Field.One(p.z);
	}

	private static void PointLookup(int block, int index, PointPrecomp p)
	{
		int off = block * 16 * 2 * 16;
		for (int i = 0; i < 16; i++)
		{
			int cond = (i ^ index) - 1 >> 31;
			X448Field.CMov(cond, precompBase, off, p.x, 0);
			off += 16;
			X448Field.CMov(cond, precompBase, off, p.y, 0);
			off += 16;
		}
	}

	private static void PointLookup(uint[] x, int n, uint[] table, PointExt r)
	{
		uint window = GetWindow4(x, n);
		int sign = (int)((window >> 3) ^ 1);
		int abs = (int)((window ^ (uint)(-sign)) & 7);
		int i = 0;
		int off = 0;
		for (; i < 8; i++)
		{
			int cond = (i ^ abs) - 1 >> 31;
			X448Field.CMov(cond, table, off, r.x, 0);
			off += 16;
			X448Field.CMov(cond, table, off, r.y, 0);
			off += 16;
			X448Field.CMov(cond, table, off, r.z, 0);
			off += 16;
		}
		X448Field.CNegate(sign, r.x);
	}

	private static uint[] PointPrecompute(PointExt p, int count)
	{
		PointExt q = PointCopy(p);
		PointExt d = PointCopy(q);
		PointDouble(d);
		uint[] table = X448Field.CreateTable(count * 3);
		int off = 0;
		int i = 0;
		while (true)
		{
			X448Field.Copy(q.x, 0, table, off);
			off += 16;
			X448Field.Copy(q.y, 0, table, off);
			off += 16;
			X448Field.Copy(q.z, 0, table, off);
			off += 16;
			if (++i == count)
			{
				break;
			}
			PointAdd(d, q);
		}
		return table;
	}

	private static PointExt[] PointPrecomputeVar(PointExt p, int count)
	{
		PointExt d = PointCopy(p);
		PointDouble(d);
		PointExt[] table = new PointExt[count];
		table[0] = PointCopy(p);
		for (int i = 1; i < count; i++)
		{
			table[i] = PointCopy(table[i - 1]);
			PointAddVar(negate: false, d, table[i]);
		}
		return table;
	}

	private static void PointSetNeutral(PointExt p)
	{
		X448Field.Zero(p.x);
		X448Field.One(p.y);
		X448Field.One(p.z);
	}

	public static void Precompute()
	{
		lock (precompLock)
		{
			if (precompBase != null)
			{
				return;
			}
			PointExt p = new PointExt();
			X448Field.Copy(B_x, 0, p.x, 0);
			X448Field.Copy(B_y, 0, p.y, 0);
			PointExtendXY(p);
			precompBaseTable = PointPrecomputeVar(p, 32);
			precompBase = X448Field.CreateTable(160);
			int off = 0;
			for (int b = 0; b < 5; b++)
			{
				PointExt[] ds = new PointExt[5];
				PointExt sum = new PointExt();
				PointSetNeutral(sum);
				for (int t = 0; t < 5; t++)
				{
					PointAddVar(negate: true, p, sum);
					PointDouble(p);
					ds[t] = PointCopy(p);
					if (b + t != 8)
					{
						for (int s = 1; s < 18; s++)
						{
							PointDouble(p);
						}
					}
				}
				PointExt[] points = new PointExt[16];
				int k = 0;
				points[k++] = sum;
				for (int i = 0; i < 4; i++)
				{
					int size = 1 << i;
					int j = 0;
					while (j < size)
					{
						points[k] = PointCopy(points[k - size]);
						PointAddVar(negate: false, ds[i], points[k]);
						j++;
						k++;
					}
				}
				uint[] cs = X448Field.CreateTable(16);
				uint[] u = X448Field.Create();
				X448Field.Copy(points[0].z, 0, u, 0);
				X448Field.Copy(u, 0, cs, 0);
				int i2 = 0;
				while (++i2 < 16)
				{
					X448Field.Mul(u, points[i2].z, u);
					X448Field.Copy(u, 0, cs, i2 * 16);
				}
				X448Field.InvVar(u, u);
				i2--;
				uint[] t2 = X448Field.Create();
				while (i2 > 0)
				{
					int j2 = i2--;
					X448Field.Copy(cs, i2 * 16, t2, 0);
					X448Field.Mul(t2, u, t2);
					X448Field.Copy(t2, 0, cs, j2 * 16);
					X448Field.Mul(u, points[j2].z, u);
				}
				X448Field.Copy(u, 0, cs, 0);
				for (int l = 0; l < 16; l++)
				{
					PointExt q = points[l];
					X448Field.Copy(cs, l * 16, q.z, 0);
					X448Field.Mul(q.x, q.z, q.x);
					X448Field.Mul(q.y, q.z, q.y);
					X448Field.Copy(q.x, 0, precompBase, off);
					off += 16;
					X448Field.Copy(q.y, 0, precompBase, off);
					off += 16;
				}
			}
		}
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
		Array.Copy(n, nOff, r, 0, 56);
		r[0] &= 252;
		r[55] |= 128;
		r[56] = 0;
	}

	private static byte[] ReduceScalar(byte[] n)
	{
		ulong x00 = Decode32(n, 0);
		ulong x1 = Decode24(n, 4) << 4;
		ulong x2 = Decode32(n, 7);
		ulong x3 = Decode24(n, 11) << 4;
		ulong x4 = Decode32(n, 14);
		ulong x5 = Decode24(n, 18) << 4;
		ulong x6 = Decode32(n, 21);
		ulong x7 = Decode24(n, 25) << 4;
		ulong x8 = Decode32(n, 28);
		ulong x9 = Decode24(n, 32) << 4;
		ulong x10 = Decode32(n, 35);
		ulong x11 = Decode24(n, 39) << 4;
		ulong x12 = Decode32(n, 42);
		ulong x13 = Decode24(n, 46) << 4;
		ulong x14 = Decode32(n, 49);
		ulong x15 = Decode24(n, 53) << 4;
		ulong x16 = Decode32(n, 56);
		ulong x17 = Decode24(n, 60) << 4;
		ulong x18 = Decode32(n, 63);
		ulong x19 = Decode24(n, 67) << 4;
		ulong x20 = Decode32(n, 70);
		ulong x21 = Decode24(n, 74) << 4;
		ulong x22 = Decode32(n, 77);
		ulong x23 = Decode24(n, 81) << 4;
		ulong x24 = Decode32(n, 84);
		ulong x25 = Decode24(n, 88) << 4;
		ulong x26 = Decode32(n, 91);
		ulong x27 = Decode24(n, 95) << 4;
		ulong x28 = Decode32(n, 98);
		ulong x29 = Decode24(n, 102) << 4;
		ulong x30 = Decode32(n, 105);
		ulong x31 = Decode24(n, 109) << 4;
		ulong x32 = Decode16(n, 112);
		x16 += x32 * 43969588;
		x17 += x32 * 30366549;
		x18 += x32 * 163752818;
		x19 += x32 * 258169998;
		x20 += x32 * 96434764;
		x21 += x32 * 227822194;
		x22 += x32 * 149865618;
		x23 += x32 * 550336261;
		x31 += x30 >> 28;
		x30 &= 0xFFFFFFF;
		x15 += x31 * 43969588;
		x16 += x31 * 30366549;
		x17 += x31 * 163752818;
		x18 += x31 * 258169998;
		x19 += x31 * 96434764;
		x20 += x31 * 227822194;
		x21 += x31 * 149865618;
		x22 += x31 * 550336261;
		x14 += x30 * 43969588;
		x15 += x30 * 30366549;
		x16 += x30 * 163752818;
		x17 += x30 * 258169998;
		x18 += x30 * 96434764;
		x19 += x30 * 227822194;
		x20 += x30 * 149865618;
		x21 += x30 * 550336261;
		x29 += x28 >> 28;
		x28 &= 0xFFFFFFF;
		x13 += x29 * 43969588;
		x14 += x29 * 30366549;
		x15 += x29 * 163752818;
		x16 += x29 * 258169998;
		x17 += x29 * 96434764;
		x18 += x29 * 227822194;
		x19 += x29 * 149865618;
		x20 += x29 * 550336261;
		x12 += x28 * 43969588;
		x13 += x28 * 30366549;
		x14 += x28 * 163752818;
		x15 += x28 * 258169998;
		x16 += x28 * 96434764;
		x17 += x28 * 227822194;
		x18 += x28 * 149865618;
		x19 += x28 * 550336261;
		x27 += x26 >> 28;
		x26 &= 0xFFFFFFF;
		x11 += x27 * 43969588;
		x12 += x27 * 30366549;
		x13 += x27 * 163752818;
		x14 += x27 * 258169998;
		x15 += x27 * 96434764;
		x16 += x27 * 227822194;
		x17 += x27 * 149865618;
		x18 += x27 * 550336261;
		x10 += x26 * 43969588;
		x11 += x26 * 30366549;
		x12 += x26 * 163752818;
		x13 += x26 * 258169998;
		x14 += x26 * 96434764;
		x15 += x26 * 227822194;
		x16 += x26 * 149865618;
		x17 += x26 * 550336261;
		x25 += x24 >> 28;
		x24 &= 0xFFFFFFF;
		x9 += x25 * 43969588;
		x10 += x25 * 30366549;
		x11 += x25 * 163752818;
		x12 += x25 * 258169998;
		x13 += x25 * 96434764;
		x14 += x25 * 227822194;
		x15 += x25 * 149865618;
		x16 += x25 * 550336261;
		x21 += x20 >> 28;
		x20 &= 0xFFFFFFF;
		x22 += x21 >> 28;
		x21 &= 0xFFFFFFF;
		x23 += x22 >> 28;
		x22 &= 0xFFFFFFF;
		x24 += x23 >> 28;
		x23 &= 0xFFFFFFF;
		x8 += x24 * 43969588;
		x9 += x24 * 30366549;
		x10 += x24 * 163752818;
		x11 += x24 * 258169998;
		x12 += x24 * 96434764;
		x13 += x24 * 227822194;
		x14 += x24 * 149865618;
		x15 += x24 * 550336261;
		x7 += x23 * 43969588;
		x8 += x23 * 30366549;
		x9 += x23 * 163752818;
		x10 += x23 * 258169998;
		x11 += x23 * 96434764;
		x12 += x23 * 227822194;
		x13 += x23 * 149865618;
		x14 += x23 * 550336261;
		x6 += x22 * 43969588;
		x7 += x22 * 30366549;
		x8 += x22 * 163752818;
		x9 += x22 * 258169998;
		x10 += x22 * 96434764;
		x11 += x22 * 227822194;
		x12 += x22 * 149865618;
		x13 += x22 * 550336261;
		x18 += x17 >> 28;
		x17 &= 0xFFFFFFF;
		x19 += x18 >> 28;
		x18 &= 0xFFFFFFF;
		x20 += x19 >> 28;
		x19 &= 0xFFFFFFF;
		x21 += x20 >> 28;
		x20 &= 0xFFFFFFF;
		x5 += x21 * 43969588;
		x6 += x21 * 30366549;
		x7 += x21 * 163752818;
		x8 += x21 * 258169998;
		x9 += x21 * 96434764;
		x10 += x21 * 227822194;
		x11 += x21 * 149865618;
		x12 += x21 * 550336261;
		x4 += x20 * 43969588;
		x5 += x20 * 30366549;
		x6 += x20 * 163752818;
		x7 += x20 * 258169998;
		x8 += x20 * 96434764;
		x9 += x20 * 227822194;
		x10 += x20 * 149865618;
		x11 += x20 * 550336261;
		x3 += x19 * 43969588;
		x4 += x19 * 30366549;
		x5 += x19 * 163752818;
		x6 += x19 * 258169998;
		x7 += x19 * 96434764;
		x8 += x19 * 227822194;
		x9 += x19 * 149865618;
		x10 += x19 * 550336261;
		x15 += x14 >> 28;
		x14 &= 0xFFFFFFF;
		x16 += x15 >> 28;
		x15 &= 0xFFFFFFF;
		x17 += x16 >> 28;
		x16 &= 0xFFFFFFF;
		x18 += x17 >> 28;
		x17 &= 0xFFFFFFF;
		x2 += x18 * 43969588;
		x3 += x18 * 30366549;
		x4 += x18 * 163752818;
		x5 += x18 * 258169998;
		x6 += x18 * 96434764;
		x7 += x18 * 227822194;
		x8 += x18 * 149865618;
		x9 += x18 * 550336261;
		x1 += x17 * 43969588;
		x2 += x17 * 30366549;
		x3 += x17 * 163752818;
		x4 += x17 * 258169998;
		x5 += x17 * 96434764;
		x6 += x17 * 227822194;
		x7 += x17 * 149865618;
		x8 += x17 * 550336261;
		x16 *= 4;
		x16 += x15 >> 26;
		x15 &= 0x3FFFFFF;
		x16++;
		x00 += x16 * 78101261;
		x1 += x16 * 141809365;
		x2 += x16 * 175155932;
		x3 += x16 * 64542499;
		x4 += x16 * 158326419;
		x5 += x16 * 191173276;
		x6 += x16 * 104575268;
		x7 += x16 * 137584065;
		x1 += x00 >> 28;
		x00 &= 0xFFFFFFF;
		x2 += x1 >> 28;
		x1 &= 0xFFFFFFF;
		x3 += x2 >> 28;
		x2 &= 0xFFFFFFF;
		x4 += x3 >> 28;
		x3 &= 0xFFFFFFF;
		x5 += x4 >> 28;
		x4 &= 0xFFFFFFF;
		x6 += x5 >> 28;
		x5 &= 0xFFFFFFF;
		x7 += x6 >> 28;
		x6 &= 0xFFFFFFF;
		x8 += x7 >> 28;
		x7 &= 0xFFFFFFF;
		x9 += x8 >> 28;
		x8 &= 0xFFFFFFF;
		x10 += x9 >> 28;
		x9 &= 0xFFFFFFF;
		x11 += x10 >> 28;
		x10 &= 0xFFFFFFF;
		x12 += x11 >> 28;
		x11 &= 0xFFFFFFF;
		x13 += x12 >> 28;
		x12 &= 0xFFFFFFF;
		x14 += x13 >> 28;
		x13 &= 0xFFFFFFF;
		x15 += x14 >> 28;
		x14 &= 0xFFFFFFF;
		x16 = x15 >> 26;
		x15 &= 0x3FFFFFF;
		x16--;
		x00 -= x16 & 0x4A7BB0D;
		x1 -= x16 & 0x873D6D5;
		x2 -= x16 & 0xA70AADC;
		x3 -= x16 & 0x3D8D723;
		x4 -= x16 & 0x96FDE93;
		x5 -= x16 & 0xB65129C;
		x6 -= x16 & 0x63BB124;
		x7 -= x16 & 0x8335DC1;
		x1 += (ulong)((long)x00 >> 28);
		x00 &= 0xFFFFFFF;
		x2 += (ulong)((long)x1 >> 28);
		x1 &= 0xFFFFFFF;
		x3 += (ulong)((long)x2 >> 28);
		x2 &= 0xFFFFFFF;
		x4 += (ulong)((long)x3 >> 28);
		x3 &= 0xFFFFFFF;
		x5 += (ulong)((long)x4 >> 28);
		x4 &= 0xFFFFFFF;
		x6 += (ulong)((long)x5 >> 28);
		x5 &= 0xFFFFFFF;
		x7 += (ulong)((long)x6 >> 28);
		x6 &= 0xFFFFFFF;
		x8 += (ulong)((long)x7 >> 28);
		x7 &= 0xFFFFFFF;
		x9 += (ulong)((long)x8 >> 28);
		x8 &= 0xFFFFFFF;
		x10 += (ulong)((long)x9 >> 28);
		x9 &= 0xFFFFFFF;
		x11 += (ulong)((long)x10 >> 28);
		x10 &= 0xFFFFFFF;
		x12 += (ulong)((long)x11 >> 28);
		x11 &= 0xFFFFFFF;
		x13 += (ulong)((long)x12 >> 28);
		x12 &= 0xFFFFFFF;
		x14 += (ulong)((long)x13 >> 28);
		x13 &= 0xFFFFFFF;
		x15 += (ulong)((long)x14 >> 28);
		x14 &= 0xFFFFFFF;
		byte[] r = new byte[57];
		Encode56(x00 | (x1 << 28), r, 0);
		Encode56(x2 | (x3 << 28), r, 7);
		Encode56(x4 | (x5 << 28), r, 14);
		Encode56(x6 | (x7 << 28), r, 21);
		Encode56(x8 | (x9 << 28), r, 28);
		Encode56(x10 | (x11 << 28), r, 35);
		Encode56(x12 | (x13 << 28), r, 42);
		Encode56(x14 | (x15 << 28), r, 49);
		return r;
	}

	private static void ScalarMult(byte[] k, PointExt p, PointExt r)
	{
		uint[] n = new uint[14];
		DecodeScalar(k, 0, n);
		Nat.ShiftDownBits(14, n, 2, 0u);
		Nat.CAdd(14, (int)(~n[0] & 1), n, L, n);
		Nat.ShiftDownBit(14, n, 1u);
		uint[] table = PointPrecompute(p, 8);
		PointExt q = new PointExt();
		PointLookup(n, 111, table, r);
		for (int w = 110; w >= 0; w--)
		{
			for (int i = 0; i < 4; i++)
			{
				PointDouble(r);
			}
			PointLookup(n, w, table, q);
			PointAdd(q, r);
		}
		for (int j = 0; j < 2; j++)
		{
			PointDouble(r);
		}
	}

	private static void ScalarMultBase(byte[] k, PointExt r)
	{
		Precompute();
		uint[] n = new uint[15];
		DecodeScalar(k, 0, n);
		n[14] = 4 + Nat.CAdd(14, (int)(~n[0] & 1), n, L, n);
		Nat.ShiftDownBit(n.Length, n, 0u);
		PointPrecomp p = new PointPrecomp();
		PointSetNeutral(r);
		int cOff = 17;
		while (true)
		{
			int tPos = cOff;
			for (int b = 0; b < 5; b++)
			{
				uint w = 0u;
				for (int t = 0; t < 5; t++)
				{
					uint tBit = n[tPos >> 5] >> tPos;
					w &= (uint)(~(1 << t));
					w ^= tBit << t;
					tPos += 18;
				}
				int sign = (int)((w >> 4) & 1);
				int abs = (int)((w ^ (uint)(-sign)) & 0xF);
				PointLookup(b, abs, p);
				X448Field.CNegate(sign, p.x);
				PointAddPrecomp(p, r);
			}
			if (--cOff >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
		PointExt p = new PointExt();
		ScalarMultBase(k, p);
		if (EncodePoint(p, r, rOff) == 0)
		{
			throw new InvalidOperationException();
		}
	}

	internal static void ScalarMultBaseXY(byte[] k, int kOff, uint[] x, uint[] y)
	{
		byte[] n = new byte[57];
		PruneScalar(k, kOff, n);
		PointExt p = new PointExt();
		ScalarMultBase(n, p);
		if (CheckPoint(p.x, p.y, p.z) == 0)
		{
			throw new InvalidOperationException();
		}
		X448Field.Copy(p.x, 0, x, 0);
		X448Field.Copy(p.y, 0, y, 0);
	}

	private static void ScalarMultOrderVar(PointExt p, PointExt r)
	{
		int width = 5;
		sbyte[] ws_p = GetWnafVar(L, width);
		PointExt[] tp = PointPrecomputeVar(p, 1 << width - 2);
		PointSetNeutral(r);
		int bit = 446;
		while (true)
		{
			int wp = ws_p[bit];
			if (wp != 0)
			{
				int sign = wp >> 31;
				int index = (wp ^ sign) >> 1;
				PointAddVar(sign != 0, tp[index], r);
			}
			if (--bit >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultStrausVar(uint[] nb, uint[] np, PointExt p, PointExt r)
	{
		Precompute();
		int width = 5;
		sbyte[] ws_b = GetWnafVar(nb, 7);
		sbyte[] ws_p = GetWnafVar(np, width);
		PointExt[] tp = PointPrecomputeVar(p, 1 << width - 2);
		PointSetNeutral(r);
		int bit = 446;
		while (true)
		{
			int wb = ws_b[bit];
			if (wb != 0)
			{
				int sign = wb >> 31;
				int index = (wb ^ sign) >> 1;
				PointAddVar(sign != 0, precompBaseTable[index], r);
			}
			int wp = ws_p[bit];
			if (wp != 0)
			{
				int sign2 = wp >> 31;
				int index2 = (wp ^ sign2) >> 1;
				PointAddVar(sign2 != 0, tp[index2], r);
			}
			if (--bit >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte phflag = 0;
		ImplSign(sk, skOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte phflag = 0;
		ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
		byte phflag = 1;
		ImplSign(sk, skOff, ctx, phflag, ph, phOff, PrehashSize, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
		byte phflag = 1;
		ImplSign(sk, skOff, pk, pkOff, ctx, phflag, ph, phOff, PrehashSize, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, IXof ph, byte[] sig, int sigOff)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0, PrehashSize))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		ImplSign(sk, skOff, ctx, phflag, m, 0, m.Length, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, IXof ph, byte[] sig, int sigOff)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0, PrehashSize))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, 0, m.Length, sig, sigOff);
	}

	public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
	{
		PointExt p = new PointExt();
		if (!DecodePointVar(pk, pkOff, negate: false, p))
		{
			return false;
		}
		X448Field.Normalize(p.x);
		X448Field.Normalize(p.y);
		X448Field.Normalize(p.z);
		if (IsNeutralElementVar(p.x, p.y, p.z))
		{
			return false;
		}
		PointExt r = new PointExt();
		ScalarMultOrderVar(p, r);
		X448Field.Normalize(r.x);
		X448Field.Normalize(r.y);
		X448Field.Normalize(r.z);
		return IsNeutralElementVar(r.x, r.y, r.z);
	}

	public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
	{
		PointExt p = new PointExt();
		return DecodePointVar(pk, pkOff, negate: false, p);
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
	{
		byte phflag = 0;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, mOff, mLen);
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff)
	{
		byte phflag = 1;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, ph, phOff, PrehashSize);
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, IXof ph)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0, PrehashSize))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, 0, m.Length);
	}
}
