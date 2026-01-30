using System;

namespace Org.BouncyCastle.Utilities.Zlib;

internal sealed class InfCodes
{
	private static readonly int[] inflate_mask = new int[17]
	{
		0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
		1023, 2047, 4095, 8191, 16383, 32767, 65535
	};

	private const int Z_OK = 0;

	private const int Z_STREAM_END = 1;

	private const int Z_NEED_DICT = 2;

	private const int Z_ERRNO = -1;

	private const int Z_STREAM_ERROR = -2;

	private const int Z_DATA_ERROR = -3;

	private const int Z_MEM_ERROR = -4;

	private const int Z_BUF_ERROR = -5;

	private const int Z_VERSION_ERROR = -6;

	private const int START = 0;

	private const int LEN = 1;

	private const int LENEXT = 2;

	private const int DIST = 3;

	private const int DISTEXT = 4;

	private const int COPY = 5;

	private const int LIT = 6;

	private const int WASH = 7;

	private const int END = 8;

	private const int BADCODE = 9;

	private int mode;

	private int len;

	private int[] tree;

	private int tree_index;

	private int need;

	private int lit;

	private int get;

	private int dist;

	private byte lbits;

	private byte dbits;

	private int[] ltree;

	private int ltree_index;

	private int[] dtree;

	private int dtree_index;

	internal InfCodes()
	{
	}

	internal void init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, ZStream z)
	{
		mode = 0;
		lbits = (byte)bl;
		dbits = (byte)bd;
		ltree = tl;
		ltree_index = tl_index;
		dtree = td;
		dtree_index = td_index;
		tree = null;
	}

	internal int proc(InfBlocks s, ZStream z, int r)
	{
		int b = 0;
		int k = 0;
		int p = 0;
		p = z.next_in_index;
		int n = z.avail_in;
		b = s.bitb;
		k = s.bitk;
		int q = s.write;
		int m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
		while (true)
		{
			switch (mode)
			{
			case 0:
				if (m >= 258 && n >= 10)
				{
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					r = inflate_fast(lbits, dbits, ltree, ltree_index, dtree, dtree_index, s, z);
					p = z.next_in_index;
					n = z.avail_in;
					b = s.bitb;
					k = s.bitk;
					q = s.write;
					m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
					if (r != 0)
					{
						mode = ((r == 1) ? 7 : 9);
						break;
					}
				}
				need = lbits;
				tree = ltree;
				tree_index = ltree_index;
				mode = 1;
				goto case 1;
			case 1:
			{
				int j;
				for (j = need; k < j; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return s.inflate_flush(z, r);
				}
				int tindex = (tree_index + (b & inflate_mask[j])) * 3;
				b >>= tree[tindex + 1];
				k -= tree[tindex + 1];
				int e = tree[tindex];
				if (e == 0)
				{
					lit = tree[tindex + 2];
					mode = 6;
					break;
				}
				if ((e & 0x10) != 0)
				{
					get = e & 0xF;
					len = tree[tindex + 2];
					mode = 2;
					break;
				}
				if ((e & 0x40) == 0)
				{
					need = e;
					tree_index = tindex / 3 + tree[tindex + 2];
					break;
				}
				if ((e & 0x20) != 0)
				{
					mode = 7;
					break;
				}
				mode = 9;
				z.msg = "invalid literal/length code";
				r = -3;
				s.bitb = b;
				s.bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			}
			case 2:
			{
				int j;
				for (j = get; k < j; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return s.inflate_flush(z, r);
				}
				len += b & inflate_mask[j];
				b >>= j;
				k -= j;
				need = dbits;
				tree = dtree;
				tree_index = dtree_index;
				mode = 3;
				goto case 3;
			}
			case 3:
			{
				int j;
				for (j = need; k < j; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return s.inflate_flush(z, r);
				}
				int tindex = (tree_index + (b & inflate_mask[j])) * 3;
				b >>= tree[tindex + 1];
				k -= tree[tindex + 1];
				int e = tree[tindex];
				if ((e & 0x10) != 0)
				{
					get = e & 0xF;
					dist = tree[tindex + 2];
					mode = 4;
					break;
				}
				if ((e & 0x40) == 0)
				{
					need = e;
					tree_index = tindex / 3 + tree[tindex + 2];
					break;
				}
				mode = 9;
				z.msg = "invalid distance code";
				r = -3;
				s.bitb = b;
				s.bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			}
			case 4:
			{
				int j;
				for (j = get; k < j; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return s.inflate_flush(z, r);
				}
				dist += b & inflate_mask[j];
				b >>= j;
				k -= j;
				mode = 5;
				goto case 5;
			}
			case 5:
			{
				int f;
				for (f = q - dist; f < 0; f += s.end)
				{
				}
				while (len != 0)
				{
					if (m == 0)
					{
						if (q == s.end && s.read != 0)
						{
							q = 0;
							m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						}
						if (m == 0)
						{
							s.write = q;
							r = s.inflate_flush(z, r);
							q = s.write;
							m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							if (q == s.end && s.read != 0)
							{
								q = 0;
								m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							}
							if (m == 0)
							{
								s.bitb = b;
								s.bitk = k;
								z.avail_in = n;
								z.total_in += p - z.next_in_index;
								z.next_in_index = p;
								s.write = q;
								return s.inflate_flush(z, r);
							}
						}
					}
					s.window[q++] = s.window[f++];
					m--;
					if (f == s.end)
					{
						f = 0;
					}
					len--;
				}
				mode = 0;
				break;
			}
			case 6:
				if (m == 0)
				{
					if (q == s.end && s.read != 0)
					{
						q = 0;
						m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
					}
					if (m == 0)
					{
						s.write = q;
						r = s.inflate_flush(z, r);
						q = s.write;
						m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						if (q == s.end && s.read != 0)
						{
							q = 0;
							m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						}
						if (m == 0)
						{
							s.bitb = b;
							s.bitk = k;
							z.avail_in = n;
							z.total_in += p - z.next_in_index;
							z.next_in_index = p;
							s.write = q;
							return s.inflate_flush(z, r);
						}
					}
				}
				r = 0;
				s.window[q++] = (byte)lit;
				m--;
				mode = 0;
				break;
			case 7:
				if (k > 7)
				{
					k -= 8;
					n++;
					p--;
				}
				s.write = q;
				r = s.inflate_flush(z, r);
				q = s.write;
				m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
				if (s.read != s.write)
				{
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return s.inflate_flush(z, r);
				}
				mode = 8;
				goto case 8;
			case 8:
				r = 1;
				s.bitb = b;
				s.bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			case 9:
				r = -3;
				s.bitb = b;
				s.bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			default:
				r = -2;
				s.bitb = b;
				s.bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			}
		}
	}

	internal void free(ZStream z)
	{
	}

	internal int inflate_fast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InfBlocks s, ZStream z)
	{
		int p = z.next_in_index;
		int n = z.avail_in;
		int b = s.bitb;
		int k = s.bitk;
		int q = s.write;
		int m = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
		int ml = inflate_mask[bl];
		int md = inflate_mask[bd];
		int c;
		while (true)
		{
			if (k < 20)
			{
				n--;
				b |= (z.next_in[p++] & 0xFF) << k;
				k += 8;
				continue;
			}
			int t = b & ml;
			int[] tp = tl;
			int tp_index = tl_index;
			int tp_index_t_3 = (tp_index + t) * 3;
			int e;
			if ((e = tp[tp_index_t_3]) == 0)
			{
				b >>= tp[tp_index_t_3 + 1];
				k -= tp[tp_index_t_3 + 1];
				s.window[q++] = (byte)tp[tp_index_t_3 + 2];
				m--;
			}
			else
			{
				while (true)
				{
					b >>= tp[tp_index_t_3 + 1];
					k -= tp[tp_index_t_3 + 1];
					if ((e & 0x10) != 0)
					{
						e &= 0xF;
						c = tp[tp_index_t_3 + 2] + (b & inflate_mask[e]);
						b >>= e;
						for (k -= e; k < 15; k += 8)
						{
							n--;
							b |= (z.next_in[p++] & 0xFF) << k;
						}
						t = b & md;
						tp = td;
						tp_index = td_index;
						tp_index_t_3 = (tp_index + t) * 3;
						e = tp[tp_index_t_3];
						while (true)
						{
							b >>= tp[tp_index_t_3 + 1];
							k -= tp[tp_index_t_3 + 1];
							if ((e & 0x10) != 0)
							{
								break;
							}
							if ((e & 0x40) == 0)
							{
								t += tp[tp_index_t_3 + 2];
								t += b & inflate_mask[e];
								tp_index_t_3 = (tp_index + t) * 3;
								e = tp[tp_index_t_3];
								continue;
							}
							z.msg = "invalid distance code";
							c = z.avail_in - n;
							c = ((k >> 3 < c) ? (k >> 3) : c);
							n += c;
							p -= c;
							k -= c << 3;
							s.bitb = b;
							s.bitk = k;
							z.avail_in = n;
							z.total_in += p - z.next_in_index;
							z.next_in_index = p;
							s.write = q;
							return -3;
						}
						for (e &= 0xF; k < e; k += 8)
						{
							n--;
							b |= (z.next_in[p++] & 0xFF) << k;
						}
						int d = tp[tp_index_t_3 + 2] + (b & inflate_mask[e]);
						b >>= e;
						k -= e;
						m -= c;
						int r;
						if (q >= d)
						{
							r = q - d;
							if (q - r > 0 && 2 > q - r)
							{
								s.window[q++] = s.window[r++];
								s.window[q++] = s.window[r++];
								c -= 2;
							}
							else
							{
								Array.Copy(s.window, r, s.window, q, 2);
								q += 2;
								r += 2;
								c -= 2;
							}
						}
						else
						{
							r = q - d;
							do
							{
								r += s.end;
							}
							while (r < 0);
							e = s.end - r;
							if (c > e)
							{
								c -= e;
								if (q - r > 0 && e > q - r)
								{
									do
									{
										s.window[q++] = s.window[r++];
									}
									while (--e != 0);
								}
								else
								{
									Array.Copy(s.window, r, s.window, q, e);
									q += e;
									r += e;
									e = 0;
								}
								r = 0;
							}
						}
						if (q - r > 0 && c > q - r)
						{
							do
							{
								s.window[q++] = s.window[r++];
							}
							while (--c != 0);
							break;
						}
						Array.Copy(s.window, r, s.window, q, c);
						q += c;
						r += c;
						c = 0;
						break;
					}
					if ((e & 0x40) == 0)
					{
						t += tp[tp_index_t_3 + 2];
						t += b & inflate_mask[e];
						tp_index_t_3 = (tp_index + t) * 3;
						if ((e = tp[tp_index_t_3]) == 0)
						{
							b >>= tp[tp_index_t_3 + 1];
							k -= tp[tp_index_t_3 + 1];
							s.window[q++] = (byte)tp[tp_index_t_3 + 2];
							m--;
							break;
						}
						continue;
					}
					if ((e & 0x20) != 0)
					{
						c = z.avail_in - n;
						c = ((k >> 3 < c) ? (k >> 3) : c);
						n += c;
						p -= c;
						k -= c << 3;
						s.bitb = b;
						s.bitk = k;
						z.avail_in = n;
						z.total_in += p - z.next_in_index;
						z.next_in_index = p;
						s.write = q;
						return 1;
					}
					z.msg = "invalid literal/length code";
					c = z.avail_in - n;
					c = ((k >> 3 < c) ? (k >> 3) : c);
					n += c;
					p -= c;
					k -= c << 3;
					s.bitb = b;
					s.bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					s.write = q;
					return -3;
				}
			}
			if (m < 258 || n < 10)
			{
				break;
			}
		}
		c = z.avail_in - n;
		c = ((k >> 3 < c) ? (k >> 3) : c);
		n += c;
		p -= c;
		k -= c << 3;
		s.bitb = b;
		s.bitk = k;
		z.avail_in = n;
		z.total_in += p - z.next_in_index;
		z.next_in_index = p;
		s.write = q;
		return 0;
	}
}
