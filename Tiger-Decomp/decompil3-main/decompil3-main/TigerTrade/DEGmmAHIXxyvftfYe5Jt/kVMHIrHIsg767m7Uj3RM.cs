using System;
using System.IO;
using System.IO.Compression;
using TuAMtrl1Nd3XoZQQUXf0;

namespace DEGmmAHIXxyvftfYe5Jt;

internal static class kVMHIrHIsg767m7Uj3RM
{
	private static kVMHIrHIsg767m7Uj3RM lOqDZCDO9ETDtcnZRyiT;

	public static byte[] Compress(byte[] data)
	{
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = new MemoryStream(data.Length);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionLevel.Fastest))
				{
					gZipStream.Write(data, 0, data.Length);
				}
				return memoryStream.ToArray();
			}
			}
		}
	}

	public static byte[] Compress(Stream input)
	{
		using MemoryStream memoryStream = new MemoryStream((int)input.Length);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionLevel.Fastest);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				qOtJ1WDOYt3HIZ6UwHQL(input, gZipStream);
			}
			finally
			{
				if (gZipStream != null)
				{
					pgZS1LDOohCjurG8Yl63(gZipStream);
				}
			}
			return memoryStream.ToArray();
		}
	}

	static kVMHIrHIsg767m7Uj3RM()
	{
		umcSEpDOvrXwnYQIiwvU();
	}

	internal static bool nPOEkhDOnHTMuxp1GQNo()
	{
		return lOqDZCDO9ETDtcnZRyiT == null;
	}

	internal static kVMHIrHIsg767m7Uj3RM dASsZsDOGF4bN6r7A5OV()
	{
		return lOqDZCDO9ETDtcnZRyiT;
	}

	internal static void qOtJ1WDOYt3HIZ6UwHQL(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static void pgZS1LDOohCjurG8Yl63(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void umcSEpDOvrXwnYQIiwvU()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
