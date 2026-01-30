using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032;

public abstract class Ed25519
{
	public enum Algorithm
	{
		Ed25519,
		Ed25519ctx,
		Ed25519ph
	}

	private class F : X25519Field
	{
	}

	private class PointAccum
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();

		internal int[] z = X25519Field.Create();

		internal int[] u = X25519Field.Create();

		internal int[] v = X25519Field.Create();
	}

	private class PointAffine
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();
	}

	private class PointExt
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();

		internal int[] z = X25519Field.Create();

		internal int[] t = X25519Field.Create();
	}

	private class PointPrecomp
	{
		internal int[] ypx_h = X25519Field.Create();

		internal int[] ymx_h = X25519Field.Create();

		internal int[] xyd = X25519Field.Create();
	}

	private const long M08L = 255L;

	private const long M28L = 268435455L;

	private const long M32L = 4294967295L;

	private const int CoordUints = 8;

	private const int PointBytes = 32;

	private const int ScalarUints = 8;

	private const int ScalarBytes = 32;

	public static readonly int PrehashSize = 64;

	public static readonly int PublicKeySize = 32;

	public static readonly int SecretKeySize = 32;

	public static readonly int SignatureSize = 64;

	private static readonly byte[] Dom2Prefix = new byte[32]
	{
		83, 105, 103, 69, 100, 50, 53, 53, 49, 57,
		32, 110, 111, 32, 69, 100, 50, 53, 53, 49,
		57, 32, 99, 111, 108, 108, 105, 115, 105, 111,
		110, 115
	};

	private static readonly uint[] P = new uint[8] { 4294967277u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 2147483647u };

	private static readonly uint[] L = new uint[8] { 1559614445u, 1477600026u, 2734136534u, 350157278u, 0u, 0u, 0u, 268435456u };

	private const int L0 = -50998291;

	private const int L1 = 19280294;

	private const int L2 = 127719000;

	private const int L3 = -6428113;

	private const int L4 = 5343;

	private static readonly int[] B_x = new int[10] { 52811034, 25909283, 8072341, 50637101, 13785486, 30858332, 20483199, 20966410, 43936626, 4379245 };

	private static readonly int[] B_y = new int[10] { 40265304, 26843545, 6710886, 53687091, 13421772, 40265318, 26843545, 6710886, 53687091, 13421772 };

	private static readonly int[] C_d = new int[10] { 56195235, 47411844, 25868126, 40503822, 57364, 58321048, 30416477, 31930572, 57760639, 10749657 };

	private static readonly int[] C_d2 = new int[10] { 45281625, 27714825, 18181821, 13898781, 114729, 49533232, 60832955, 30306712, 48412415, 4722099 };

	private static readonly int[] C_d4 = new int[10] { 23454386, 55429651, 2809210, 27797563, 229458, 31957600, 54557047, 27058993, 29715967, 9444199 };

	private const int WnafWidthBase = 7;

	private const int PrecompBlocks = 8;

	private const int PrecompTeeth = 4;

	private const int PrecompSpacing = 8;

	private const int PrecompPoints = 8;

	private const int PrecompMask = 7;

	private static readonly object precompLock = new object();

	private static PointExt[] precompBaseTable = null;

	private static int[] precompBase = null;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		uint[] t = new uint[16];
		DecodeScalar(r, 0, t);
		uint[] u = new uint[8];
		DecodeScalar(k, 0, u);
		uint[] v = new uint[8];
		DecodeScalar(s, 0, v);
		Nat256.MulAddTo(u, v, t);
		byte[] result = new byte[64];
		for (int i = 0; i < t.Length; i++)
		{
			Encode32(t[i], result, i * 4);
		}
		return ReduceScalar(result);
	}

	private static bool CheckContextVar(byte[] ctx, byte phflag)
	{
		if (ctx != null || phflag != 0)
		{
			if (ctx != null)
			{
				return ctx.Length < 256;
			}
			return false;
		}
		return true;
	}

	private static int CheckPoint(int[] x, int[] y)
	{
		int[] t = X25519Field.Create();
		int[] u = X25519Field.Create();
		int[] v = X25519Field.Create();
		X25519Field.Sqr(x, u);
		X25519Field.Sqr(y, v);
		X25519Field.Mul(u, v, t);
		X25519Field.Sub(v, u, v);
		X25519Field.Mul(t, C_d, t);
		X25519Field.AddOne(t);
		X25519Field.Sub(t, v, t);
		X25519Field.Normalize(t);
		return X25519Field.IsZero(t);
	}

	private static int CheckPoint(int[] x, int[] y, int[] z)
	{
		int[] t = X25519Field.Create();
		int[] u = X25519Field.Create();
		int[] v = X25519Field.Create();
		int[] w = X25519Field.Create();
		X25519Field.Sqr(x, u);
		X25519Field.Sqr(y, v);
		X25519Field.Sqr(z, w);
		X25519Field.Mul(u, v, t);
		X25519Field.Sub(v, u, v);
		X25519Field.Mul(v, w, v);
		X25519Field.Sqr(w, w);
		X25519Field.Mul(t, C_d, t);
		X25519Field.Add(t, w, t);
		X25519Field.Sub(t, v, t);
		X25519Field.Normalize(t);
		return X25519Field.IsZero(t);
	}

	private static bool CheckPointVar(byte[] p)
	{
		uint[] t = new uint[8];
		Decode32(p, 0, t, 0, 8);
		t[7] &= 2147483647u;
		return !Nat256.Gte(t, P);
	}

	private static bool CheckScalarVar(byte[] s, uint[] n)
	{
		DecodeScalar(s, 0, n);
		return !Nat256.Gte(n, L);
	}

	private static byte[] Copy(byte[] buf, int off, int len)
	{
		byte[] result = new byte[len];
		Array.Copy(buf, off, result, 0, len);
		return result;
	}

	private static IDigest CreateDigest()
	{
		return new Sha512Digest();
	}

	public static IDigest CreatePrehash()
	{
		return CreateDigest();
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

	private static bool DecodePointVar(byte[] p, int pOff, bool negate, PointAffine r)
	{
		byte[] py = Copy(p, pOff, 32);
		if (!CheckPointVar(py))
		{
			return false;
		}
		int x_0 = (py[31] & 0x80) >> 7;
		py[31] &= 127;
		X25519Field.Decode(py, 0, r.y);
		int[] u = X25519Field.Create();
		int[] v = X25519Field.Create();
		X25519Field.Sqr(r.y, u);
		X25519Field.Mul(C_d, u, v);
		X25519Field.SubOne(u);
		X25519Field.AddOne(v);
		if (!X25519Field.SqrtRatioVar(u, v, r.x))
		{
			return false;
		}
		X25519Field.Normalize(r.x);
		if (x_0 == 1 && X25519Field.IsZeroVar(r.x))
		{
			return false;
		}
		if (negate ^ (x_0 != (r.x[0] & 1)))
		{
			X25519Field.Negate(r.x, r.x);
		}
		return true;
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		Decode32(k, kOff, n, 0, 8);
	}

	private static void Dom2(IDigest d, byte phflag, byte[] ctx)
	{
		if (ctx != null)
		{
			int n = Dom2Prefix.Length;
			byte[] t = new byte[n + 2 + ctx.Length];
			Dom2Prefix.CopyTo(t, 0);
			t[n] = phflag;
			t[n + 1] = (byte)ctx.Length;
			ctx.CopyTo(t, n + 2);
			d.BlockUpdate(t, 0, t.Length);
		}
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

	private static int EncodePoint(PointAccum p, byte[] r, int rOff)
	{
		int[] x = X25519Field.Create();
		int[] y = X25519Field.Create();
		X25519Field.Inv(p.z, y);
		X25519Field.Mul(p.x, y, x);
		X25519Field.Mul(p.y, y, y);
		X25519Field.Normalize(x);
		X25519Field.Normalize(y);
		int result = CheckPoint(x, y);
		X25519Field.Encode(y, r, rOff);
		r[rOff + 32 - 1] |= (byte)((x[0] & 1) << 7);
		return result;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
		random.NextBytes(k);
	}

	public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
	{
		IDigest digest = CreateDigest();
		byte[] h = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(h, 0);
		byte[] s = new byte[32];
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
		uint[] t = new uint[16];
		uint c = 0u;
		int tPos = t.Length;
		int i = 8;
		while (--i >= 0)
		{
			uint next = n[i];
			t[--tPos] = (next >> 16) | (c << 16);
			c = (t[--tPos] = next);
		}
		sbyte[] ws = new sbyte[253];
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

	private static void ImplSign(IDigest d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		Dom2(d, phflag, ctx);
		d.BlockUpdate(h, 32, 32);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0);
		byte[] array = ReduceScalar(h);
		byte[] R = new byte[32];
		ScalarMultBaseEncoded(array, R, 0);
		Dom2(d, phflag, ctx);
		d.BlockUpdate(R, 0, 32);
		d.BlockUpdate(pk, pkOff, 32);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0);
		byte[] k = ReduceScalar(h);
		byte[] sourceArray = CalculateS(array, k, s);
		Array.Copy(R, 0, sig, sigOff, 32);
		Array.Copy(sourceArray, 0, sig, sigOff + 32, 32);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		IDigest digest = CreateDigest();
		byte[] h = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(h, 0);
		byte[] s = new byte[32];
		PruneScalar(h, 0, s);
		byte[] pk = new byte[32];
		ScalarMultBaseEncoded(s, pk, 0);
		ImplSign(digest, h, s, pk, 0, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		IDigest digest = CreateDigest();
		byte[] h = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(h, 0);
		byte[] s = new byte[32];
		PruneScalar(h, 0, s);
		ImplSign(digest, h, s, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		byte[] R = Copy(sig, sigOff, 32);
		byte[] S = Copy(sig, sigOff + 32, 32);
		if (!CheckPointVar(R))
		{
			return false;
		}
		uint[] nS = new uint[8];
		if (!CheckScalarVar(S, nS))
		{
			return false;
		}
		PointAffine pA = new PointAffine();
		if (!DecodePointVar(pk, pkOff, negate: true, pA))
		{
			return false;
		}
		IDigest digest = CreateDigest();
		byte[] h = new byte[digest.GetDigestSize()];
		Dom2(digest, phflag, ctx);
		digest.BlockUpdate(R, 0, 32);
		digest.BlockUpdate(pk, pkOff, 32);
		digest.BlockUpdate(m, mOff, mLen);
		digest.DoFinal(h, 0);
		byte[] k = ReduceScalar(h);
		uint[] nA = new uint[8];
		DecodeScalar(k, 0, nA);
		PointAccum pR = new PointAccum();
		ScalarMultStrausVar(nS, nA, pA, pR);
		byte[] check = new byte[32];
		if (EncodePoint(pR, check, 0) != 0)
		{
			return Arrays.AreEqual(check, R);
		}
		return false;
	}

	private static bool IsNeutralElementVar(int[] x, int[] y)
	{
		if (X25519Field.IsZeroVar(x))
		{
			return X25519Field.IsOneVar(y);
		}
		return false;
	}

	private static bool IsNeutralElementVar(int[] x, int[] y, int[] z)
	{
		if (X25519Field.IsZeroVar(x))
		{
			return X25519Field.AreEqualVar(y, z);
		}
		return false;
	}

	private static void PointAdd(PointExt p, PointAccum r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] d = X25519Field.Create();
		int[] e = r.u;
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = r.v;
		X25519Field.Apm(r.y, r.x, b, a);
		X25519Field.Apm(p.y, p.x, d, c);
		X25519Field.Mul(a, c, a);
		X25519Field.Mul(b, d, b);
		X25519Field.Mul(r.u, r.v, c);
		X25519Field.Mul(c, p.t, c);
		X25519Field.Mul(c, C_d2, c);
		X25519Field.Mul(r.z, p.z, d);
		X25519Field.Add(d, d, d);
		X25519Field.Apm(b, a, h, e);
		X25519Field.Apm(d, c, g, f);
		X25519Field.Carry(g);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
	}

	private static void PointAdd(PointExt p, PointExt r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] d = X25519Field.Create();
		int[] e = X25519Field.Create();
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = X25519Field.Create();
		X25519Field.Apm(p.y, p.x, b, a);
		X25519Field.Apm(r.y, r.x, d, c);
		X25519Field.Mul(a, c, a);
		X25519Field.Mul(b, d, b);
		X25519Field.Mul(p.t, r.t, c);
		X25519Field.Mul(c, C_d2, c);
		X25519Field.Mul(p.z, r.z, d);
		X25519Field.Add(d, d, d);
		X25519Field.Apm(b, a, h, e);
		X25519Field.Apm(d, c, g, f);
		X25519Field.Carry(g);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
		X25519Field.Mul(e, h, r.t);
	}

	private static void PointAddVar(bool negate, PointExt p, PointAccum r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] d = X25519Field.Create();
		int[] e = r.u;
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = r.v;
		int[] nc;
		int[] nd;
		int[] nf;
		int[] ng;
		if (negate)
		{
			nc = d;
			nd = c;
			nf = g;
			ng = f;
		}
		else
		{
			nc = c;
			nd = d;
			nf = f;
			ng = g;
		}
		X25519Field.Apm(r.y, r.x, b, a);
		X25519Field.Apm(p.y, p.x, nd, nc);
		X25519Field.Mul(a, c, a);
		X25519Field.Mul(b, d, b);
		X25519Field.Mul(r.u, r.v, c);
		X25519Field.Mul(c, p.t, c);
		X25519Field.Mul(c, C_d2, c);
		X25519Field.Mul(r.z, p.z, d);
		X25519Field.Add(d, d, d);
		X25519Field.Apm(b, a, h, e);
		X25519Field.Apm(d, c, ng, nf);
		X25519Field.Carry(ng);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
	}

	private static void PointAddVar(bool negate, PointExt p, PointExt q, PointExt r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] d = X25519Field.Create();
		int[] e = X25519Field.Create();
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = X25519Field.Create();
		int[] nc;
		int[] nd;
		int[] nf;
		int[] ng;
		if (negate)
		{
			nc = d;
			nd = c;
			nf = g;
			ng = f;
		}
		else
		{
			nc = c;
			nd = d;
			nf = f;
			ng = g;
		}
		X25519Field.Apm(p.y, p.x, b, a);
		X25519Field.Apm(q.y, q.x, nd, nc);
		X25519Field.Mul(a, c, a);
		X25519Field.Mul(b, d, b);
		X25519Field.Mul(p.t, q.t, c);
		X25519Field.Mul(c, C_d2, c);
		X25519Field.Mul(p.z, q.z, d);
		X25519Field.Add(d, d, d);
		X25519Field.Apm(b, a, h, e);
		X25519Field.Apm(d, c, ng, nf);
		X25519Field.Carry(ng);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
		X25519Field.Mul(e, h, r.t);
	}

	private static void PointAddPrecomp(PointPrecomp p, PointAccum r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] e = r.u;
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = r.v;
		X25519Field.Apm(r.y, r.x, b, a);
		X25519Field.Mul(a, p.ymx_h, a);
		X25519Field.Mul(b, p.ypx_h, b);
		X25519Field.Mul(r.u, r.v, c);
		X25519Field.Mul(c, p.xyd, c);
		X25519Field.Apm(b, a, h, e);
		X25519Field.Apm(r.z, c, g, f);
		X25519Field.Carry(g);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
	}

	private static PointExt PointCopy(PointAccum p)
	{
		PointExt r = new PointExt();
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		X25519Field.Copy(p.z, 0, r.z, 0);
		X25519Field.Mul(p.u, p.v, r.t);
		return r;
	}

	private static PointExt PointCopy(PointAffine p)
	{
		PointExt r = new PointExt();
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		PointExtendXY(r);
		return r;
	}

	private static PointExt PointCopy(PointExt p)
	{
		PointExt r = new PointExt();
		PointCopy(p, r);
		return r;
	}

	private static void PointCopy(PointAffine p, PointAccum r)
	{
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		PointExtendXY(r);
	}

	private static void PointCopy(PointExt p, PointExt r)
	{
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		X25519Field.Copy(p.z, 0, r.z, 0);
		X25519Field.Copy(p.t, 0, r.t, 0);
	}

	private static void PointDouble(PointAccum r)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		int[] c = X25519Field.Create();
		int[] e = r.u;
		int[] f = X25519Field.Create();
		int[] g = X25519Field.Create();
		int[] h = r.v;
		X25519Field.Sqr(r.x, a);
		X25519Field.Sqr(r.y, b);
		X25519Field.Sqr(r.z, c);
		X25519Field.Add(c, c, c);
		X25519Field.Apm(a, b, h, g);
		X25519Field.Add(r.x, r.y, e);
		X25519Field.Sqr(e, e);
		X25519Field.Sub(h, e, e);
		X25519Field.Add(c, g, f);
		X25519Field.Carry(f);
		X25519Field.Mul(e, f, r.x);
		X25519Field.Mul(g, h, r.y);
		X25519Field.Mul(f, g, r.z);
	}

	private static void PointExtendXY(PointAccum p)
	{
		X25519Field.One(p.z);
		X25519Field.Copy(p.x, 0, p.u, 0);
		X25519Field.Copy(p.y, 0, p.v, 0);
	}

	private static void PointExtendXY(PointExt p)
	{
		X25519Field.One(p.z);
		X25519Field.Mul(p.x, p.y, p.t);
	}

	private static void PointLookup(int block, int index, PointPrecomp p)
	{
		int off = block * 8 * 3 * 10;
		for (int i = 0; i < 8; i++)
		{
			int cond = (i ^ index) - 1 >> 31;
			X25519Field.CMov(cond, precompBase, off, p.ypx_h, 0);
			off += 10;
			X25519Field.CMov(cond, precompBase, off, p.ymx_h, 0);
			off += 10;
			X25519Field.CMov(cond, precompBase, off, p.xyd, 0);
			off += 10;
		}
	}

	private static void PointLookup(uint[] x, int n, int[] table, PointExt r)
	{
		uint window = GetWindow4(x, n);
		int sign = (int)((window >> 3) ^ 1);
		int abs = (int)((window ^ (uint)(-sign)) & 7);
		int i = 0;
		int off = 0;
		for (; i < 8; i++)
		{
			int cond = (i ^ abs) - 1 >> 31;
			X25519Field.CMov(cond, table, off, r.x, 0);
			off += 10;
			X25519Field.CMov(cond, table, off, r.y, 0);
			off += 10;
			X25519Field.CMov(cond, table, off, r.z, 0);
			off += 10;
			X25519Field.CMov(cond, table, off, r.t, 0);
			off += 10;
		}
		X25519Field.CNegate(sign, r.x);
		X25519Field.CNegate(sign, r.t);
	}

	private static void PointLookup(int[] table, int index, PointExt r)
	{
		int off = 40 * index;
		X25519Field.Copy(table, off, r.x, 0);
		off += 10;
		X25519Field.Copy(table, off, r.y, 0);
		off += 10;
		X25519Field.Copy(table, off, r.z, 0);
		off += 10;
		X25519Field.Copy(table, off, r.t, 0);
	}

	private static int[] PointPrecompute(PointAffine p, int count)
	{
		PointExt q = PointCopy(p);
		PointExt d = PointCopy(q);
		PointAdd(q, d);
		int[] table = X25519Field.CreateTable(count * 4);
		int off = 0;
		int i = 0;
		while (true)
		{
			X25519Field.Copy(q.x, 0, table, off);
			off += 10;
			X25519Field.Copy(q.y, 0, table, off);
			off += 10;
			X25519Field.Copy(q.z, 0, table, off);
			off += 10;
			X25519Field.Copy(q.t, 0, table, off);
			off += 10;
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
		PointExt d = new PointExt();
		PointAddVar(negate: false, p, p, d);
		PointExt[] table = new PointExt[count];
		table[0] = PointCopy(p);
		for (int i = 1; i < count; i++)
		{
			PointAddVar(negate: false, table[i - 1], d, table[i] = new PointExt());
		}
		return table;
	}

	private static void PointSetNeutral(PointAccum p)
	{
		X25519Field.Zero(p.x);
		X25519Field.One(p.y);
		X25519Field.One(p.z);
		X25519Field.Zero(p.u);
		X25519Field.One(p.v);
	}

	private static void PointSetNeutral(PointExt p)
	{
		X25519Field.Zero(p.x);
		X25519Field.One(p.y);
		X25519Field.One(p.z);
		X25519Field.Zero(p.t);
	}

	public static void Precompute()
	{
		lock (precompLock)
		{
			if (precompBase != null)
			{
				return;
			}
			PointExt b = new PointExt();
			X25519Field.Copy(B_x, 0, b.x, 0);
			X25519Field.Copy(B_y, 0, b.y, 0);
			PointExtendXY(b);
			precompBaseTable = PointPrecomputeVar(b, 32);
			PointAccum p = new PointAccum();
			X25519Field.Copy(B_x, 0, p.x, 0);
			X25519Field.Copy(B_y, 0, p.y, 0);
			PointExtendXY(p);
			precompBase = X25519Field.CreateTable(192);
			int off = 0;
			for (int i = 0; i < 8; i++)
			{
				PointExt[] ds = new PointExt[4];
				PointExt sum = new PointExt();
				PointSetNeutral(sum);
				for (int t = 0; t < 4; t++)
				{
					PointExt q = PointCopy(p);
					PointAddVar(negate: true, sum, q, sum);
					PointDouble(p);
					ds[t] = PointCopy(p);
					if (i + t != 10)
					{
						for (int s = 1; s < 8; s++)
						{
							PointDouble(p);
						}
					}
				}
				PointExt[] points = new PointExt[8];
				int k = 0;
				points[k++] = sum;
				for (int j = 0; j < 3; j++)
				{
					int size = 1 << j;
					int j2 = 0;
					while (j2 < size)
					{
						PointAddVar(negate: false, points[k - size], ds[j], points[k] = new PointExt());
						j2++;
						k++;
					}
				}
				int[] cs = X25519Field.CreateTable(8);
				int[] u = X25519Field.Create();
				X25519Field.Copy(points[0].z, 0, u, 0);
				X25519Field.Copy(u, 0, cs, 0);
				int i2 = 0;
				while (++i2 < 8)
				{
					X25519Field.Mul(u, points[i2].z, u);
					X25519Field.Copy(u, 0, cs, i2 * 10);
				}
				X25519Field.Add(u, u, u);
				X25519Field.InvVar(u, u);
				i2--;
				int[] t2 = X25519Field.Create();
				while (i2 > 0)
				{
					int j3 = i2--;
					X25519Field.Copy(cs, i2 * 10, t2, 0);
					X25519Field.Mul(t2, u, t2);
					X25519Field.Copy(t2, 0, cs, j3 * 10);
					X25519Field.Mul(u, points[j3].z, u);
				}
				X25519Field.Copy(u, 0, cs, 0);
				for (int l = 0; l < 8; l++)
				{
					PointExt obj = points[l];
					int[] x = X25519Field.Create();
					int[] y = X25519Field.Create();
					X25519Field.Copy(cs, l * 10, y, 0);
					X25519Field.Mul(obj.x, y, x);
					X25519Field.Mul(obj.y, y, y);
					PointPrecomp r = new PointPrecomp();
					X25519Field.Apm(y, x, r.ypx_h, r.ymx_h);
					X25519Field.Mul(x, y, r.xyd);
					X25519Field.Mul(r.xyd, C_d4, r.xyd);
					X25519Field.Normalize(r.ypx_h);
					X25519Field.Normalize(r.ymx_h);
					X25519Field.Copy(r.ypx_h, 0, precompBase, off);
					off += 10;
					X25519Field.Copy(r.ymx_h, 0, precompBase, off);
					off += 10;
					X25519Field.Copy(r.xyd, 0, precompBase, off);
					off += 10;
				}
			}
		}
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
		Array.Copy(n, nOff, r, 0, 32);
		r[0] &= 248;
		r[31] &= 127;
		r[31] |= 64;
	}

	private static byte[] ReduceScalar(byte[] n)
	{
		long x00 = (long)Decode32(n, 0) & 0xFFFFFFFFL;
		long x1 = (long)(Decode24(n, 4) << 4) & 0xFFFFFFFFL;
		long x2 = (long)Decode32(n, 7) & 0xFFFFFFFFL;
		long x3 = (long)(Decode24(n, 11) << 4) & 0xFFFFFFFFL;
		long x4 = (long)Decode32(n, 14) & 0xFFFFFFFFL;
		long x5 = (long)(Decode24(n, 18) << 4) & 0xFFFFFFFFL;
		long x6 = (long)Decode32(n, 21) & 0xFFFFFFFFL;
		long x7 = (long)(Decode24(n, 25) << 4) & 0xFFFFFFFFL;
		long x8 = (long)Decode32(n, 28) & 0xFFFFFFFFL;
		long x9 = (long)(Decode24(n, 32) << 4) & 0xFFFFFFFFL;
		long x10 = (long)Decode32(n, 35) & 0xFFFFFFFFL;
		long x11 = (long)(Decode24(n, 39) << 4) & 0xFFFFFFFFL;
		long x12 = (long)Decode32(n, 42) & 0xFFFFFFFFL;
		long x13 = (long)(Decode24(n, 46) << 4) & 0xFFFFFFFFL;
		long x14 = (long)Decode32(n, 49) & 0xFFFFFFFFL;
		long x15 = (long)(Decode24(n, 53) << 4) & 0xFFFFFFFFL;
		long x16 = (long)Decode32(n, 56) & 0xFFFFFFFFL;
		long x17 = (long)(Decode24(n, 60) << 4) & 0xFFFFFFFFL;
		long x18 = (long)n[63] & 0xFFL;
		x9 -= x18 * -50998291;
		x10 -= x18 * 19280294;
		x11 -= x18 * 127719000;
		x12 -= x18 * -6428113;
		x13 -= x18 * 5343;
		x17 += x16 >> 28;
		x16 &= 0xFFFFFFF;
		x8 -= x17 * -50998291;
		x9 -= x17 * 19280294;
		x10 -= x17 * 127719000;
		x11 -= x17 * -6428113;
		x12 -= x17 * 5343;
		x7 -= x16 * -50998291;
		x8 -= x16 * 19280294;
		x9 -= x16 * 127719000;
		x10 -= x16 * -6428113;
		x11 -= x16 * 5343;
		x15 += x14 >> 28;
		x14 &= 0xFFFFFFF;
		x6 -= x15 * -50998291;
		x7 -= x15 * 19280294;
		x8 -= x15 * 127719000;
		x9 -= x15 * -6428113;
		x10 -= x15 * 5343;
		x5 -= x14 * -50998291;
		x6 -= x14 * 19280294;
		x7 -= x14 * 127719000;
		x8 -= x14 * -6428113;
		x9 -= x14 * 5343;
		x13 += x12 >> 28;
		x12 &= 0xFFFFFFF;
		x4 -= x13 * -50998291;
		x5 -= x13 * 19280294;
		x6 -= x13 * 127719000;
		x7 -= x13 * -6428113;
		x8 -= x13 * 5343;
		x12 += x11 >> 28;
		x11 &= 0xFFFFFFF;
		x3 -= x12 * -50998291;
		x4 -= x12 * 19280294;
		x5 -= x12 * 127719000;
		x6 -= x12 * -6428113;
		x7 -= x12 * 5343;
		x11 += x10 >> 28;
		x10 &= 0xFFFFFFF;
		x2 -= x11 * -50998291;
		x3 -= x11 * 19280294;
		x4 -= x11 * 127719000;
		x5 -= x11 * -6428113;
		x6 -= x11 * 5343;
		x10 += x9 >> 28;
		x9 &= 0xFFFFFFF;
		x1 -= x10 * -50998291;
		x2 -= x10 * 19280294;
		x3 -= x10 * 127719000;
		x4 -= x10 * -6428113;
		x5 -= x10 * 5343;
		x8 += x7 >> 28;
		x7 &= 0xFFFFFFF;
		x9 += x8 >> 28;
		x8 &= 0xFFFFFFF;
		long t = (x8 >> 27) & 1;
		x9 += t;
		x00 -= x9 * -50998291;
		x1 -= x9 * 19280294;
		x2 -= x9 * 127719000;
		x3 -= x9 * -6428113;
		x4 -= x9 * 5343;
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
		x9 = x8 >> 28;
		x8 &= 0xFFFFFFF;
		x9 -= t;
		x00 += x9 & -50998291;
		x1 += x9 & 0x12631A6;
		x2 += x9 & 0x79CD658;
		x3 += x9 & -6428113;
		x4 += x9 & 0x14DF;
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
		byte[] r = new byte[32];
		Encode56((ulong)(x00 | (x1 << 28)), r, 0);
		Encode56((ulong)(x2 | (x3 << 28)), r, 7);
		Encode56((ulong)(x4 | (x5 << 28)), r, 14);
		Encode56((ulong)(x6 | (x7 << 28)), r, 21);
		Encode32((uint)x8, r, 28);
		return r;
	}

	private static void ScalarMult(byte[] k, PointAffine p, PointAccum r)
	{
		uint[] n = new uint[8];
		DecodeScalar(k, 0, n);
		Nat.ShiftDownBits(8, n, 3, 1u);
		Nat.CAdd(8, (int)(~n[0] & 1), n, L, n);
		Nat.ShiftDownBit(8, n, 0u);
		int[] table = PointPrecompute(p, 8);
		PointExt q = new PointExt();
		PointCopy(p, r);
		PointLookup(table, 7, q);
		PointAdd(q, r);
		int w = 62;
		while (true)
		{
			PointLookup(n, w, table, q);
			PointAdd(q, r);
			PointDouble(r);
			PointDouble(r);
			PointDouble(r);
			if (--w >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBase(byte[] k, PointAccum r)
	{
		Precompute();
		uint[] n = new uint[8];
		DecodeScalar(k, 0, n);
		Nat.CAdd(8, (int)(~n[0] & 1), n, L, n);
		Nat.ShiftDownBit(8, n, 1u);
		for (int i = 0; i < 8; i++)
		{
			n[i] = Interleave.Shuffle2(n[i]);
		}
		PointPrecomp p = new PointPrecomp();
		PointSetNeutral(r);
		int cOff = 28;
		while (true)
		{
			for (int b = 0; b < 8; b++)
			{
				uint num = n[b] >> cOff;
				int sign = (int)((num >> 3) & 1);
				int abs = (int)((num ^ (uint)(-sign)) & 7);
				PointLookup(b, abs, p);
				X25519Field.CSwap(sign, p.ypx_h, p.ymx_h);
				X25519Field.CNegate(sign, p.xyd);
				PointAddPrecomp(p, r);
			}
			if ((cOff -= 4) >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
		PointAccum p = new PointAccum();
		ScalarMultBase(k, p);
		if (EncodePoint(p, r, rOff) == 0)
		{
			throw new InvalidOperationException();
		}
	}

	internal static void ScalarMultBaseYZ(byte[] k, int kOff, int[] y, int[] z)
	{
		byte[] n = new byte[32];
		PruneScalar(k, kOff, n);
		PointAccum p = new PointAccum();
		ScalarMultBase(n, p);
		if (CheckPoint(p.x, p.y, p.z) == 0)
		{
			throw new InvalidOperationException();
		}
		X25519Field.Copy(p.y, 0, y, 0);
		X25519Field.Copy(p.z, 0, z, 0);
	}

	private static void ScalarMultOrderVar(PointAffine p, PointAccum r)
	{
		int width = 5;
		sbyte[] ws_p = GetWnafVar(L, width);
		PointExt[] tp = PointPrecomputeVar(PointCopy(p), 1 << width - 2);
		PointSetNeutral(r);
		int bit = 252;
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

	private static void ScalarMultStrausVar(uint[] nb, uint[] np, PointAffine p, PointAccum r)
	{
		Precompute();
		int width = 5;
		sbyte[] ws_b = GetWnafVar(nb, 7);
		sbyte[] ws_p = GetWnafVar(np, width);
		PointExt[] tp = PointPrecomputeVar(PointCopy(p), 1 << width - 2);
		PointSetNeutral(r);
		int bit = 252;
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

	public static void Sign(byte[] sk, int skOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte[] ctx = null;
		byte phflag = 0;
		ImplSign(sk, skOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte[] ctx = null;
		byte phflag = 0;
		ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
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

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		ImplSign(sk, skOff, ctx, phflag, m, 0, m.Length, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		ImplSign(sk, skOff, pk, pkOff, ctx, phflag, m, 0, m.Length, sig, sigOff);
	}

	public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
	{
		PointAffine p = new PointAffine();
		if (!DecodePointVar(pk, pkOff, negate: false, p))
		{
			return false;
		}
		X25519Field.Normalize(p.x);
		X25519Field.Normalize(p.y);
		if (IsNeutralElementVar(p.x, p.y))
		{
			return false;
		}
		PointAccum r = new PointAccum();
		ScalarMultOrderVar(p, r);
		X25519Field.Normalize(r.x);
		X25519Field.Normalize(r.y);
		X25519Field.Normalize(r.z);
		return IsNeutralElementVar(r.x, r.y, r.z);
	}

	public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
	{
		PointAffine p = new PointAffine();
		return DecodePointVar(pk, pkOff, negate: false, p);
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen)
	{
		byte[] ctx = null;
		byte phflag = 0;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, mOff, mLen);
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

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph)
	{
		byte[] m = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(m, 0))
		{
			throw new ArgumentException("ph");
		}
		byte phflag = 1;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, phflag, m, 0, m.Length);
	}
}
