using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class Gost3410ParametersGenerator
{
	private int size;

	private int typeproc;

	private SecureRandom init_random;

	public void Init(int size, int typeProcedure, SecureRandom random)
	{
		this.size = size;
		typeproc = typeProcedure;
		init_random = random;
	}

	private int procedure_A(int x0, int c, BigInteger[] pq, int size)
	{
		while (x0 < 0 || x0 > 65536)
		{
			x0 = init_random.NextInt() / 32768;
		}
		while (c < 0 || c > 65536 || c / 2 == 0)
		{
			c = init_random.NextInt() / 32768 + 1;
		}
		BigInteger C = BigInteger.ValueOf(c);
		BigInteger constA16 = BigInteger.ValueOf(19381L);
		BigInteger[] y = new BigInteger[1] { BigInteger.ValueOf(x0) };
		int[] t = new int[1] { size };
		int s = 0;
		for (int i = 0; t[i] >= 17; i++)
		{
			int[] tmp_t = new int[t.Length + 1];
			Array.Copy(t, 0, tmp_t, 0, t.Length);
			t = new int[tmp_t.Length];
			Array.Copy(tmp_t, 0, t, 0, tmp_t.Length);
			t[i + 1] = t[i] / 2;
			s = i + 1;
		}
		BigInteger[] p = new BigInteger[s + 1];
		p[s] = new BigInteger("8003", 16);
		int m = s - 1;
		for (int j = 0; j < s; j++)
		{
			int rm = t[m] / 16;
			while (true)
			{
				BigInteger[] tmp_y = new BigInteger[y.Length];
				Array.Copy(y, 0, tmp_y, 0, y.Length);
				y = new BigInteger[rm + 1];
				Array.Copy(tmp_y, 0, y, 0, tmp_y.Length);
				for (int k = 0; k < rm; k++)
				{
					y[k + 1] = y[k].Multiply(constA16).Add(C).Mod(BigInteger.Two.Pow(16));
				}
				BigInteger Ym = BigInteger.Zero;
				for (int l = 0; l < rm; l++)
				{
					Ym = Ym.Add(y[l].ShiftLeft(16 * l));
				}
				y[0] = y[rm];
				BigInteger N = BigInteger.One.ShiftLeft(t[m] - 1).Divide(p[m + 1]).Add(Ym.ShiftLeft(t[m] - 1).Divide(p[m + 1].ShiftLeft(16 * rm)));
				if (N.TestBit(0))
				{
					N = N.Add(BigInteger.One);
				}
				while (true)
				{
					BigInteger NByLastP = N.Multiply(p[m + 1]);
					if (NByLastP.BitLength > t[m])
					{
						break;
					}
					p[m] = NByLastP.Add(BigInteger.One);
					if (BigInteger.Two.ModPow(NByLastP, p[m]).CompareTo(BigInteger.One) == 0 && BigInteger.Two.ModPow(N, p[m]).CompareTo(BigInteger.One) != 0)
					{
						goto end_IL_0106;
					}
					N = N.Add(BigInteger.Two);
				}
				continue;
				end_IL_0106:
				break;
			}
			if (--m < 0)
			{
				pq[0] = p[0];
				pq[1] = p[1];
				return y[0].IntValue;
			}
		}
		return y[0].IntValue;
	}

	private long procedure_Aa(long x0, long c, BigInteger[] pq, int size)
	{
		while (x0 < 0 || x0 > 4294967296L)
		{
			x0 = init_random.NextInt() * 2;
		}
		while (c < 0 || c > 4294967296L || c / 2 == 0L)
		{
			c = init_random.NextInt() * 2 + 1;
		}
		BigInteger C = BigInteger.ValueOf(c);
		BigInteger constA32 = BigInteger.ValueOf(97781173L);
		BigInteger[] y = new BigInteger[1] { BigInteger.ValueOf(x0) };
		int[] t = new int[1] { size };
		int s = 0;
		for (int i = 0; t[i] >= 33; i++)
		{
			int[] tmp_t = new int[t.Length + 1];
			Array.Copy(t, 0, tmp_t, 0, t.Length);
			t = new int[tmp_t.Length];
			Array.Copy(tmp_t, 0, t, 0, tmp_t.Length);
			t[i + 1] = t[i] / 2;
			s = i + 1;
		}
		BigInteger[] p = new BigInteger[s + 1];
		p[s] = new BigInteger("8000000B", 16);
		int m = s - 1;
		for (int j = 0; j < s; j++)
		{
			int rm = t[m] / 32;
			while (true)
			{
				BigInteger[] tmp_y = new BigInteger[y.Length];
				Array.Copy(y, 0, tmp_y, 0, y.Length);
				y = new BigInteger[rm + 1];
				Array.Copy(tmp_y, 0, y, 0, tmp_y.Length);
				for (int k = 0; k < rm; k++)
				{
					y[k + 1] = y[k].Multiply(constA32).Add(C).Mod(BigInteger.Two.Pow(32));
				}
				BigInteger Ym = BigInteger.Zero;
				for (int l = 0; l < rm; l++)
				{
					Ym = Ym.Add(y[l].ShiftLeft(32 * l));
				}
				y[0] = y[rm];
				BigInteger N = BigInteger.One.ShiftLeft(t[m] - 1).Divide(p[m + 1]).Add(Ym.ShiftLeft(t[m] - 1).Divide(p[m + 1].ShiftLeft(32 * rm)));
				if (N.TestBit(0))
				{
					N = N.Add(BigInteger.One);
				}
				while (true)
				{
					BigInteger NByLastP = N.Multiply(p[m + 1]);
					if (NByLastP.BitLength > t[m])
					{
						break;
					}
					p[m] = NByLastP.Add(BigInteger.One);
					if (BigInteger.Two.ModPow(NByLastP, p[m]).CompareTo(BigInteger.One) == 0 && BigInteger.Two.ModPow(N, p[m]).CompareTo(BigInteger.One) != 0)
					{
						goto end_IL_0109;
					}
					N = N.Add(BigInteger.Two);
				}
				continue;
				end_IL_0109:
				break;
			}
			if (--m < 0)
			{
				pq[0] = p[0];
				pq[1] = p[1];
				return y[0].LongValue;
			}
		}
		return y[0].LongValue;
	}

	private void procedure_B(int x0, int c, BigInteger[] pq)
	{
		while (x0 < 0 || x0 > 65536)
		{
			x0 = init_random.NextInt() / 32768;
		}
		while (c < 0 || c > 65536 || c / 2 == 0)
		{
			c = init_random.NextInt() / 32768 + 1;
		}
		BigInteger[] qp = new BigInteger[2];
		BigInteger q = null;
		BigInteger Q = null;
		BigInteger p = null;
		BigInteger C = BigInteger.ValueOf(c);
		BigInteger constA16 = BigInteger.ValueOf(19381L);
		x0 = procedure_A(x0, c, qp, 256);
		q = qp[0];
		x0 = procedure_A(x0, c, qp, 512);
		Q = qp[0];
		BigInteger[] y = new BigInteger[65];
		y[0] = BigInteger.ValueOf(x0);
		BigInteger qQ = q.Multiply(Q);
		while (true)
		{
			for (int j = 0; j < 64; j++)
			{
				y[j + 1] = y[j].Multiply(constA16).Add(C).Mod(BigInteger.Two.Pow(16));
			}
			BigInteger Y = BigInteger.Zero;
			for (int i = 0; i < 64; i++)
			{
				Y = Y.Add(y[i].ShiftLeft(16 * i));
			}
			y[0] = y[64];
			BigInteger N = BigInteger.One.ShiftLeft(1023).Divide(qQ).Add(Y.ShiftLeft(1023).Divide(qQ.ShiftLeft(1024)));
			if (N.TestBit(0))
			{
				N = N.Add(BigInteger.One);
			}
			while (true)
			{
				BigInteger qQN = qQ.Multiply(N);
				if (qQN.BitLength > 1024)
				{
					break;
				}
				p = qQN.Add(BigInteger.One);
				if (BigInteger.Two.ModPow(qQN, p).CompareTo(BigInteger.One) == 0 && BigInteger.Two.ModPow(q.Multiply(N), p).CompareTo(BigInteger.One) != 0)
				{
					pq[0] = p;
					pq[1] = q;
					return;
				}
				N = N.Add(BigInteger.Two);
			}
		}
	}

	private void procedure_Bb(long x0, long c, BigInteger[] pq)
	{
		while (x0 < 0 || x0 > 4294967296L)
		{
			x0 = init_random.NextInt() * 2;
		}
		while (c < 0 || c > 4294967296L || c / 2 == 0L)
		{
			c = init_random.NextInt() * 2 + 1;
		}
		BigInteger[] qp = new BigInteger[2];
		BigInteger q = null;
		BigInteger Q = null;
		BigInteger p = null;
		BigInteger C = BigInteger.ValueOf(c);
		BigInteger constA32 = BigInteger.ValueOf(97781173L);
		x0 = procedure_Aa(x0, c, qp, 256);
		q = qp[0];
		x0 = procedure_Aa(x0, c, qp, 512);
		Q = qp[0];
		BigInteger[] y = new BigInteger[33];
		y[0] = BigInteger.ValueOf(x0);
		BigInteger qQ = q.Multiply(Q);
		while (true)
		{
			for (int j = 0; j < 32; j++)
			{
				y[j + 1] = y[j].Multiply(constA32).Add(C).Mod(BigInteger.Two.Pow(32));
			}
			BigInteger Y = BigInteger.Zero;
			for (int i = 0; i < 32; i++)
			{
				Y = Y.Add(y[i].ShiftLeft(32 * i));
			}
			y[0] = y[32];
			BigInteger N = BigInteger.One.ShiftLeft(1023).Divide(qQ).Add(Y.ShiftLeft(1023).Divide(qQ.ShiftLeft(1024)));
			if (N.TestBit(0))
			{
				N = N.Add(BigInteger.One);
			}
			while (true)
			{
				BigInteger qQN = qQ.Multiply(N);
				if (qQN.BitLength > 1024)
				{
					break;
				}
				p = qQN.Add(BigInteger.One);
				if (BigInteger.Two.ModPow(qQN, p).CompareTo(BigInteger.One) == 0 && BigInteger.Two.ModPow(q.Multiply(N), p).CompareTo(BigInteger.One) != 0)
				{
					pq[0] = p;
					pq[1] = q;
					return;
				}
				N = N.Add(BigInteger.Two);
			}
		}
	}

	private BigInteger procedure_C(BigInteger p, BigInteger q)
	{
		BigInteger pSub1 = p.Subtract(BigInteger.One);
		BigInteger pSub1Divq = pSub1.Divide(q);
		BigInteger a;
		while (true)
		{
			BigInteger d = new BigInteger(p.BitLength, init_random);
			if (d.CompareTo(BigInteger.One) > 0 && d.CompareTo(pSub1) < 0)
			{
				a = d.ModPow(pSub1Divq, p);
				if (a.CompareTo(BigInteger.One) != 0)
				{
					break;
				}
			}
		}
		return a;
	}

	public Gost3410Parameters GenerateParameters()
	{
		BigInteger[] pq = new BigInteger[2];
		BigInteger q = null;
		BigInteger p = null;
		BigInteger a = null;
		if (typeproc == 1)
		{
			int x0 = init_random.NextInt();
			int c = init_random.NextInt();
			switch (size)
			{
			case 512:
				procedure_A(x0, c, pq, 512);
				break;
			case 1024:
				procedure_B(x0, c, pq);
				break;
			default:
				throw new ArgumentException("Ooops! key size 512 or 1024 bit.");
			}
			p = pq[0];
			q = pq[1];
			a = procedure_C(p, q);
			return new Gost3410Parameters(p, q, a, new Gost3410ValidationParameters(x0, c));
		}
		long x0L = init_random.NextLong();
		long cL = init_random.NextLong();
		switch (size)
		{
		case 512:
			procedure_Aa(x0L, cL, pq, 512);
			break;
		case 1024:
			procedure_Bb(x0L, cL, pq);
			break;
		default:
			throw new InvalidOperationException("Ooops! key size 512 or 1024 bit.");
		}
		p = pq[0];
		q = pq[1];
		a = procedure_C(p, q);
		return new Gost3410Parameters(p, q, a, new Gost3410ValidationParameters(x0L, cL));
	}
}
