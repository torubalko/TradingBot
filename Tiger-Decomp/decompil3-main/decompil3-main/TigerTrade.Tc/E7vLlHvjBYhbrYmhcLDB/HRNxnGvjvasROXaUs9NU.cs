using System;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace E7vLlHvjBYhbrYmhcLDB;

internal sealed class HRNxnGvjvasROXaUs9NU
{
	private readonly string Gq7vj4roEO8;

	internal static HRNxnGvjvasROXaUs9NU RRFDKyx4ZpHIC5MGGbZb;

	public HRNxnGvjvasROXaUs9NU(string P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Gq7vj4roEO8 = P_0;
	}

	public string MBmvja0OGvQ(string P_0)
	{
		byte[] array = zmRvji5Kkqd(((Encoding)FsutUOx4rnbUtZN22c8V()).GetBytes(Gq7vj4roEO8), ((Encoding)FsutUOx4rnbUtZN22c8V()).GetBytes(P_0));
		return XXyvjl2neQ2(array);
	}

	private byte[] zmRvji5Kkqd(byte[] P_0, byte[] P_1)
	{
		HMACSHA256 hMACSHA = new HMACSHA256(P_0);
		try
		{
			return (byte[])OV9p8Xx4Kx2CDHeOaQ53(hMACSHA, P_1);
		}
		finally
		{
			if (hMACSHA != null)
			{
				jTltcpx4mdXe2d7cLww7(hMACSHA);
			}
		}
	}

	private string XXyvjl2neQ2(byte[] P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(P_0.Length * 2);
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
		{
			num2 = 0;
		}
		byte b = default(byte);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stringBuilder.AppendFormat((string)fKYpFmx4hyViCjahSO36(0x1A5F1B9E ^ 0x1A5E8C58), b);
				num++;
				break;
			case 2:
				return stringBuilder.ToString();
			}
			if (num < P_0.Length)
			{
				b = P_0[num];
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	static HRNxnGvjvasROXaUs9NU()
	{
		DvFkDwx4wUkqZ0x2e6Gr();
		Fi9kLex47a3OZiLxAuDs();
	}

	internal static bool FaDAN7x4VGSgpyqY8cZA()
	{
		return RRFDKyx4ZpHIC5MGGbZb == null;
	}

	internal static HRNxnGvjvasROXaUs9NU EvjRZbx4CF8pPY1tiHZw()
	{
		return RRFDKyx4ZpHIC5MGGbZb;
	}

	internal static object FsutUOx4rnbUtZN22c8V()
	{
		return Encoding.UTF8;
	}

	internal static object OV9p8Xx4Kx2CDHeOaQ53(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static void jTltcpx4mdXe2d7cLww7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object fKYpFmx4hyViCjahSO36(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void DvFkDwx4wUkqZ0x2e6Gr()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void Fi9kLex47a3OZiLxAuDs()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
