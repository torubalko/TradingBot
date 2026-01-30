using System;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using JFTYgsac0q3XUbNNjxGO;
using K1GcsD5GTtMSlaiJI0Xh;
using Org.BouncyCastle.Crypto.Parameters;
using x97CE55GhEYKgt7TSVZT;

namespace PYGx2kBMFKFtMm0RBunX;

internal sealed class pqunSQBMJAkeA7ZcCPt9
{
	private readonly string fDsBMpQiGAc;

	private readonly Ed25519PrivateKeyParameters kYYBMuDdvYK;

	internal static pqunSQBMJAkeA7ZcCPt9 y50cuMx6lkfqjrjZ76yJ;

	public pqunSQBMJAkeA7ZcCPt9(string P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		fDsBMpQiGAc = P_0;
	}

	public pqunSQBMJAkeA7ZcCPt9(Ed25519PrivateKeyParameters P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		kYYBMuDdvYK = P_0;
	}

	public string Fe0BM3IvgBN(string P_0)
	{
		if (!string.IsNullOrEmpty(fDsBMpQiGAc))
		{
			HMACSHA256 hMACSHA = new HMACSHA256(((Encoding)FS87pYx6bCI4ySNReyx8()).GetBytes(fDsBMpQiGAc));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				try
				{
					return (string)ALg1MOx65YoTCq2fn1VU(kCoMjqx619ywUOyD9WBy(SL576gx6kAkOVDm0vP2S(hMACSHA, fKHr2Ax6NkLFlujWoehs(Encoding.UTF8, P_0))), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--927068468 ^ 0x37411BF6), "");
				}
				finally
				{
					if (hMACSHA != null)
					{
						g33oawx6S9Nx2TecUL5b(hMACSHA);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
				}
			}
		}
		return ua2OrTaXzxs2PyC5iUL0.WQ5acHCha3E(kYYBMuDdvYK, P_0);
	}

	static pqunSQBMJAkeA7ZcCPt9()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WTjHhpx646vlWFoxA0GV()
	{
		return y50cuMx6lkfqjrjZ76yJ == null;
	}

	internal static pqunSQBMJAkeA7ZcCPt9 SKpDndx6Du0c9Z0Ktsty()
	{
		return y50cuMx6lkfqjrjZ76yJ;
	}

	internal static object FS87pYx6bCI4ySNReyx8()
	{
		return Encoding.UTF8;
	}

	internal static object fKHr2Ax6NkLFlujWoehs(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object SL576gx6kAkOVDm0vP2S(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object kCoMjqx619ywUOyD9WBy(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object ALg1MOx65YoTCq2fn1VU(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void g33oawx6S9Nx2TecUL5b(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
