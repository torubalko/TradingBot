using System.IO;

namespace Org.BouncyCastle.Utilities.IO;

public sealed class Streams
{
	private const int BufferSize = 4096;

	private Streams()
	{
	}

	public static void Drain(Stream inStr)
	{
		byte[] bs = new byte[4096];
		while (inStr.Read(bs, 0, bs.Length) > 0)
		{
		}
	}

	public static byte[] ReadAll(Stream inStr)
	{
		MemoryStream buf = new MemoryStream();
		PipeAll(inStr, buf);
		return buf.ToArray();
	}

	public static byte[] ReadAllLimited(Stream inStr, int limit)
	{
		MemoryStream buf = new MemoryStream();
		PipeAllLimited(inStr, limit, buf);
		return buf.ToArray();
	}

	public static int ReadFully(Stream inStr, byte[] buf)
	{
		return ReadFully(inStr, buf, 0, buf.Length);
	}

	public static int ReadFully(Stream inStr, byte[] buf, int off, int len)
	{
		int totalRead;
		int numRead;
		for (totalRead = 0; totalRead < len; totalRead += numRead)
		{
			numRead = inStr.Read(buf, off + totalRead, len - totalRead);
			if (numRead < 1)
			{
				break;
			}
		}
		return totalRead;
	}

	public static void PipeAll(Stream inStr, Stream outStr)
	{
		PipeAll(inStr, outStr, 4096);
	}

	public static void PipeAll(Stream inStr, Stream outStr, int bufferSize)
	{
		byte[] bs = new byte[bufferSize];
		int numRead;
		while ((numRead = inStr.Read(bs, 0, bs.Length)) > 0)
		{
			outStr.Write(bs, 0, numRead);
		}
	}

	public static long PipeAllLimited(Stream inStr, long limit, Stream outStr)
	{
		byte[] bs = new byte[4096];
		long total = 0L;
		int numRead;
		while ((numRead = inStr.Read(bs, 0, bs.Length)) > 0)
		{
			if (limit - total < numRead)
			{
				throw new StreamOverflowException("Data Overflow");
			}
			total += numRead;
			outStr.Write(bs, 0, numRead);
		}
		return total;
	}

	public static void WriteBufTo(MemoryStream buf, Stream output)
	{
		buf.WriteTo(output);
	}

	public static int WriteBufTo(MemoryStream buf, byte[] output, int offset)
	{
		int size = (int)buf.Length;
		WriteBufTo(buf, new MemoryStream(output, offset, size));
		return size;
	}

	public static void WriteZeroes(Stream outStr, long count)
	{
		byte[] zeroes = new byte[4096];
		while (count > 4096)
		{
			outStr.Write(zeroes, 0, 4096);
			count -= 4096;
		}
		outStr.Write(zeroes, 0, (int)count);
	}
}
