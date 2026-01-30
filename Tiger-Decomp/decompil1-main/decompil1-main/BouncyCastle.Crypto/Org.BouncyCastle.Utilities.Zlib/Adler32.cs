namespace Org.BouncyCastle.Utilities.Zlib;

internal sealed class Adler32
{
	private const int BASE = 65521;

	private const int NMAX = 5552;

	internal long adler32(long adler, byte[] buf, int index, int len)
	{
		if (buf == null)
		{
			return 1L;
		}
		long s1 = adler & 0xFFFF;
		long s2 = (adler >> 16) & 0xFFFF;
		while (len > 0)
		{
			int k = ((len < 5552) ? len : 5552);
			len -= k;
			while (k >= 16)
			{
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				s1 += buf[index++] & 0xFF;
				s2 += s1;
				k -= 16;
			}
			if (k != 0)
			{
				do
				{
					s1 += buf[index++] & 0xFF;
					s2 += s1;
				}
				while (--k != 0);
			}
			s1 %= 65521;
			s2 %= 65521;
		}
		return (s2 << 16) | s1;
	}
}
