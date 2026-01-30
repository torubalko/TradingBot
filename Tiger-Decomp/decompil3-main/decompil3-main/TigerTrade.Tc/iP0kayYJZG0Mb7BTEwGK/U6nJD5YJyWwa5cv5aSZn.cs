using System;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace iP0kayYJZG0Mb7BTEwGK;

internal sealed class U6nJD5YJyWwa5cv5aSZn
{
	private readonly string aJrYJKRhi8b;

	internal static U6nJD5YJyWwa5cv5aSZn fRqVl7SOagEDXIkasPVa;

	public U6nJD5YJyWwa5cv5aSZn(string P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		aJrYJKRhi8b = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public string rApYJV3AKlB(string P_0)
	{
		return So1YJrpdpc1(H4NYJCiepwU(Encoding.UTF8.GetBytes(aJrYJKRhi8b), Encoding.UTF8.GetBytes(P_0)));
	}

	private byte[] H4NYJCiepwU(byte[] P_0, byte[] P_1)
	{
		HMACSHA256 hMACSHA = new HMACSHA256(P_0);
		try
		{
			return (byte[])grUjY4SO4x6ty5Wssmyj(hMACSHA, P_1);
		}
		finally
		{
			if (hMACSHA != null)
			{
				Hlt9VxSODE2us4Gwmqx5(hMACSHA);
			}
		}
	}

	public static string So1YJrpdpc1(byte[] P_0)
	{
		return Convert.ToBase64String(P_0);
	}

	static U6nJD5YJyWwa5cv5aSZn()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool T9SBt2SOiDXB32MNlT6T()
	{
		return fRqVl7SOagEDXIkasPVa == null;
	}

	internal static U6nJD5YJyWwa5cv5aSZn MnxP6PSOljmmIYkspGTM()
	{
		return fRqVl7SOagEDXIkasPVa;
	}

	internal static object grUjY4SO4x6ty5Wssmyj(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static void Hlt9VxSODE2us4Gwmqx5(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
