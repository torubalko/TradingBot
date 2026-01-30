using System;

namespace Org.BouncyCastle.Utilities.Zlib;

internal sealed class InfBlocks
{
	private const int MANY = 1440;

	private static readonly int[] inflate_mask = new int[17]
	{
		0, 1, 3, 7, 15, 31, 63, 127, 255, 511,
		1023, 2047, 4095, 8191, 16383, 32767, 65535
	};

	private static readonly int[] border = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
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

	private const int TYPE = 0;

	private const int LENS = 1;

	private const int STORED = 2;

	private const int TABLE = 3;

	private const int BTREE = 4;

	private const int DTREE = 5;

	private const int CODES = 6;

	private const int DRY = 7;

	private const int DONE = 8;

	private const int BAD = 9;

	internal int mode;

	internal int left;

	internal int table;

	internal int index;

	internal int[] blens;

	internal int[] bb = new int[1];

	internal int[] tb = new int[1];

	internal InfCodes codes = new InfCodes();

	private int last;

	internal int bitk;

	internal int bitb;

	internal int[] hufts;

	internal byte[] window;

	internal int end;

	internal int read;

	internal int write;

	internal object checkfn;

	internal long check;

	internal InfTree inftree = new InfTree();

	internal InfBlocks(ZStream z, object checkfn, int w)
	{
		hufts = new int[4320];
		window = new byte[w];
		end = w;
		this.checkfn = checkfn;
		mode = 0;
		reset(z, null);
	}

	internal void reset(ZStream z, long[] c)
	{
		if (c != null)
		{
			c[0] = check;
		}
		if (mode != 4)
		{
			_ = mode;
			_ = 5;
		}
		if (mode == 6)
		{
			codes.free(z);
		}
		mode = 0;
		bitk = 0;
		bitb = 0;
		read = (write = 0);
		if (checkfn != null)
		{
			z.adler = (check = z._adler.adler32(0L, null, 0, 0));
		}
	}

	internal int proc(ZStream z, int r)
	{
		int p = z.next_in_index;
		int n = z.avail_in;
		int b = bitb;
		int k = bitk;
		int q = write;
		int m = ((q < read) ? (read - q - 1) : (end - q));
		while (true)
		{
			switch (mode)
			{
			case 0:
			{
				for (; k < 3; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				int t = b & 7;
				last = t & 1;
				switch (t >> 1)
				{
				case 0:
					b >>= 3;
					k -= 3;
					t = k & 7;
					b >>= t;
					k -= t;
					mode = 1;
					break;
				case 1:
				{
					int[] bl = new int[1];
					int[] bd = new int[1];
					int[][] tl = new int[1][];
					int[][] td = new int[1][];
					InfTree.inflate_trees_fixed(bl, bd, tl, td, z);
					codes.init(bl[0], bd[0], tl[0], 0, td[0], 0, z);
					b >>= 3;
					k -= 3;
					mode = 6;
					break;
				}
				case 2:
					b >>= 3;
					k -= 3;
					mode = 3;
					break;
				case 3:
					b >>= 3;
					k -= 3;
					mode = 9;
					z.msg = "invalid block type";
					r = -3;
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				break;
			}
			case 1:
				for (; k < 32; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				if (((~b >> 16) & 0xFFFF) != (b & 0xFFFF))
				{
					mode = 9;
					z.msg = "invalid stored block lengths";
					r = -3;
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				left = b & 0xFFFF;
				b = (k = 0);
				mode = ((left != 0) ? 2 : ((last != 0) ? 7 : 0));
				break;
			case 2:
			{
				if (n == 0)
				{
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				if (m == 0)
				{
					if (q == end && read != 0)
					{
						q = 0;
						m = ((q < read) ? (read - q - 1) : (end - q));
					}
					if (m == 0)
					{
						write = q;
						r = inflate_flush(z, r);
						q = write;
						m = ((q < read) ? (read - q - 1) : (end - q));
						if (q == end && read != 0)
						{
							q = 0;
							m = ((q < read) ? (read - q - 1) : (end - q));
						}
						if (m == 0)
						{
							bitb = b;
							bitk = k;
							z.avail_in = n;
							z.total_in += p - z.next_in_index;
							z.next_in_index = p;
							write = q;
							return inflate_flush(z, r);
						}
					}
				}
				r = 0;
				int t = left;
				if (t > n)
				{
					t = n;
				}
				if (t > m)
				{
					t = m;
				}
				Array.Copy(z.next_in, p, window, q, t);
				p += t;
				n -= t;
				q += t;
				m -= t;
				if ((left -= t) == 0)
				{
					mode = ((last != 0) ? 7 : 0);
				}
				break;
			}
			case 3:
			{
				for (; k < 14; k += 8)
				{
					if (n != 0)
					{
						r = 0;
						n--;
						b |= (z.next_in[p++] & 0xFF) << k;
						continue;
					}
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				int t = (table = b & 0x3FFF);
				if ((t & 0x1F) > 29 || ((t >> 5) & 0x1F) > 29)
				{
					mode = 9;
					z.msg = "too many length or distance symbols";
					r = -3;
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				t = 258 + (t & 0x1F) + ((t >> 5) & 0x1F);
				if (blens == null || blens.Length < t)
				{
					blens = new int[t];
				}
				else
				{
					for (int i = 0; i < t; i++)
					{
						blens[i] = 0;
					}
				}
				b >>= 14;
				k -= 14;
				index = 0;
				mode = 4;
				goto case 4;
			}
			case 4:
			{
				while (index < 4 + (table >> 10))
				{
					for (; k < 3; k += 8)
					{
						if (n != 0)
						{
							r = 0;
							n--;
							b |= (z.next_in[p++] & 0xFF) << k;
							continue;
						}
						bitb = b;
						bitk = k;
						z.avail_in = n;
						z.total_in += p - z.next_in_index;
						z.next_in_index = p;
						write = q;
						return inflate_flush(z, r);
					}
					blens[border[index++]] = b & 7;
					b >>= 3;
					k -= 3;
				}
				while (index < 19)
				{
					blens[border[index++]] = 0;
				}
				bb[0] = 7;
				int t = inftree.inflate_trees_bits(blens, bb, tb, hufts, z);
				if (t != 0)
				{
					r = t;
					if (r == -3)
					{
						blens = null;
						mode = 9;
					}
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				index = 0;
				mode = 5;
				goto case 5;
			}
			case 5:
			{
				int t;
				while (true)
				{
					t = table;
					if (index >= 258 + (t & 0x1F) + ((t >> 5) & 0x1F))
					{
						break;
					}
					for (t = bb[0]; k < t; k += 8)
					{
						if (n != 0)
						{
							r = 0;
							n--;
							b |= (z.next_in[p++] & 0xFF) << k;
							continue;
						}
						bitb = b;
						bitk = k;
						z.avail_in = n;
						z.total_in += p - z.next_in_index;
						z.next_in_index = p;
						write = q;
						return inflate_flush(z, r);
					}
					_ = tb[0];
					_ = -1;
					t = hufts[(tb[0] + (b & inflate_mask[t])) * 3 + 1];
					int c = hufts[(tb[0] + (b & inflate_mask[t])) * 3 + 2];
					if (c < 16)
					{
						b >>= t;
						k -= t;
						blens[index++] = c;
						continue;
					}
					int i2 = ((c == 18) ? 7 : (c - 14));
					int j = ((c == 18) ? 11 : 3);
					for (; k < t + i2; k += 8)
					{
						if (n != 0)
						{
							r = 0;
							n--;
							b |= (z.next_in[p++] & 0xFF) << k;
							continue;
						}
						bitb = b;
						bitk = k;
						z.avail_in = n;
						z.total_in += p - z.next_in_index;
						z.next_in_index = p;
						write = q;
						return inflate_flush(z, r);
					}
					b >>= t;
					k -= t;
					j += b & inflate_mask[i2];
					b >>= i2;
					k -= i2;
					i2 = index;
					t = table;
					if (i2 + j > 258 + (t & 0x1F) + ((t >> 5) & 0x1F) || (c == 16 && i2 < 1))
					{
						blens = null;
						mode = 9;
						z.msg = "invalid bit length repeat";
						r = -3;
						bitb = b;
						bitk = k;
						z.avail_in = n;
						z.total_in += p - z.next_in_index;
						z.next_in_index = p;
						write = q;
						return inflate_flush(z, r);
					}
					c = ((c == 16) ? blens[i2 - 1] : 0);
					do
					{
						blens[i2++] = c;
					}
					while (--j != 0);
					index = i2;
				}
				tb[0] = -1;
				int[] bl2 = new int[1];
				int[] bd2 = new int[1];
				int[] tl2 = new int[1];
				int[] td2 = new int[1];
				bl2[0] = 9;
				bd2[0] = 6;
				t = table;
				t = inftree.inflate_trees_dynamic(257 + (t & 0x1F), 1 + ((t >> 5) & 0x1F), blens, bl2, bd2, tl2, td2, hufts, z);
				if (t != 0)
				{
					if (t == -3)
					{
						blens = null;
						mode = 9;
					}
					r = t;
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				codes.init(bl2[0], bd2[0], hufts, tl2[0], hufts, td2[0], z);
				mode = 6;
				goto case 6;
			}
			case 6:
				bitb = b;
				bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				write = q;
				if ((r = codes.proc(this, z, r)) != 1)
				{
					return inflate_flush(z, r);
				}
				r = 0;
				codes.free(z);
				p = z.next_in_index;
				n = z.avail_in;
				b = bitb;
				k = bitk;
				q = write;
				m = ((q < read) ? (read - q - 1) : (end - q));
				if (last == 0)
				{
					mode = 0;
					break;
				}
				mode = 7;
				goto case 7;
			case 7:
				write = q;
				r = inflate_flush(z, r);
				q = write;
				m = ((q < read) ? (read - q - 1) : (end - q));
				if (read != write)
				{
					bitb = b;
					bitk = k;
					z.avail_in = n;
					z.total_in += p - z.next_in_index;
					z.next_in_index = p;
					write = q;
					return inflate_flush(z, r);
				}
				mode = 8;
				goto case 8;
			case 8:
				r = 1;
				bitb = b;
				bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				write = q;
				return inflate_flush(z, r);
			case 9:
				r = -3;
				bitb = b;
				bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				write = q;
				return inflate_flush(z, r);
			default:
				r = -2;
				bitb = b;
				bitk = k;
				z.avail_in = n;
				z.total_in += p - z.next_in_index;
				z.next_in_index = p;
				write = q;
				return inflate_flush(z, r);
			}
		}
	}

	internal void free(ZStream z)
	{
		reset(z, null);
		window = null;
		hufts = null;
	}

	internal void set_dictionary(byte[] d, int start, int n)
	{
		Array.Copy(d, start, window, 0, n);
		read = (write = n);
	}

	internal int sync_point()
	{
		if (mode != 1)
		{
			return 0;
		}
		return 1;
	}

	internal int inflate_flush(ZStream z, int r)
	{
		int p = z.next_out_index;
		int q = read;
		int n = ((q <= write) ? write : end) - q;
		if (n > z.avail_out)
		{
			n = z.avail_out;
		}
		if (n != 0 && r == -5)
		{
			r = 0;
		}
		z.avail_out -= n;
		z.total_out += n;
		if (checkfn != null)
		{
			z.adler = (check = z._adler.adler32(check, window, q, n));
		}
		Array.Copy(window, q, z.next_out, p, n);
		p += n;
		q += n;
		if (q == end)
		{
			q = 0;
			if (write == end)
			{
				write = 0;
			}
			n = write - q;
			if (n > z.avail_out)
			{
				n = z.avail_out;
			}
			if (n != 0 && r == -5)
			{
				r = 0;
			}
			z.avail_out -= n;
			z.total_out += n;
			if (checkfn != null)
			{
				z.adler = (check = z._adler.adler32(check, window, q, n));
			}
			Array.Copy(window, q, z.next_out, p, n);
			p += n;
			q += n;
		}
		z.next_out_index = p;
		read = q;
		return r;
	}
}
