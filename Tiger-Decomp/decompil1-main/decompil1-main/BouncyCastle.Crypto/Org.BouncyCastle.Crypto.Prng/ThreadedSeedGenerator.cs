using System;
using System.Threading;

namespace Org.BouncyCastle.Crypto.Prng;

public class ThreadedSeedGenerator
{
	private class SeedGenerator
	{
		private volatile int counter;

		private volatile bool stop;

		private void Run(object ignored)
		{
			while (!stop)
			{
				counter++;
			}
		}

		public byte[] GenerateSeed(int numBytes, bool fast)
		{
			ThreadPriority originalPriority = Thread.CurrentThread.Priority;
			try
			{
				Thread.CurrentThread.Priority = ThreadPriority.Normal;
				return DoGenerateSeed(numBytes, fast);
			}
			finally
			{
				Thread.CurrentThread.Priority = originalPriority;
			}
		}

		private byte[] DoGenerateSeed(int numBytes, bool fast)
		{
			counter = 0;
			stop = false;
			byte[] result = new byte[numBytes];
			int last = 0;
			int end = (fast ? numBytes : (numBytes * 8));
			ThreadPool.QueueUserWorkItem(Run);
			for (int i = 0; i < end; i++)
			{
				while (counter == last)
				{
					try
					{
						Thread.Sleep(1);
					}
					catch (Exception)
					{
					}
				}
				last = counter;
				if (fast)
				{
					result[i] = (byte)last;
					continue;
				}
				int bytepos = i / 8;
				result[bytepos] = (byte)((result[bytepos] << 1) | (last & 1));
			}
			stop = true;
			return result;
		}
	}

	public byte[] GenerateSeed(int numBytes, bool fast)
	{
		return new SeedGenerator().GenerateSeed(numBytes, fast);
	}
}
