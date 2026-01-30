using System;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace Mb7gLGv2IdM2MvvJJaDx;

internal sealed class XA1bLov2q9n0NrgrYJMu
{
	internal static XA1bLov2q9n0NrgrYJMu lvBHc8xGRBJ5q2R4C7yD;

	public string bahv2WAdaDI(string P_0, string P_1)
	{
		byte[] array = U25v2tvT9EA((byte[])MUjUyZxGO2o9WvTCW9nV(Encoding.UTF8, P_0), Encoding.UTF8.GetBytes(P_1));
		return Chsv2UbPjgW(array);
	}

	private byte[] U25v2tvT9EA(byte[] P_0, byte[] P_1)
	{
		HMACSHA256 hMACSHA = new HMACSHA256(P_0);
		try
		{
			return (byte[])wra4MMxGql1svDZsYwdt(hMACSHA, P_1);
		}
		finally
		{
			if (hMACSHA != null)
			{
				PkHaQtxGIcPZf3jJm28Y(hMACSHA);
			}
		}
	}

	public string Chsv2UbPjgW(byte[] P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(P_0.Length * 2);
		int num = 0;
		int num2 = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
			{
				byte b = P_0[num];
				stringBuilder.AppendFormat(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7A362B), b);
				num++;
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
			case 2:
				if (num < P_0.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num2 = 0;
					}
					break;
				}
				return stringBuilder.ToString();
			}
		}
	}

	public XA1bLov2q9n0NrgrYJMu()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static XA1bLov2q9n0NrgrYJMu()
	{
		F3V6AcxGWCVXQsTfDOMP();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object MUjUyZxGO2o9WvTCW9nV(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static bool FlJM6dxG6pMNEjpWk4Rf()
	{
		return lvBHc8xGRBJ5q2R4C7yD == null;
	}

	internal static XA1bLov2q9n0NrgrYJMu GuT2oQxGMi4QvrcIgBmp()
	{
		return lvBHc8xGRBJ5q2R4C7yD;
	}

	internal static object wra4MMxGql1svDZsYwdt(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static void PkHaQtxGIcPZf3jJm28Y(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void F3V6AcxGWCVXQsTfDOMP()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
