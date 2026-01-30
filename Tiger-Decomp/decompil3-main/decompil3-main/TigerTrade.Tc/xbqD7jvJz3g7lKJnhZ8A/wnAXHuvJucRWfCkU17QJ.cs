using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace xbqD7jvJz3g7lKJnhZ8A;

internal class wnAXHuvJucRWfCkU17QJ
{
	[CompilerGenerated]
	private readonly string ywdvFBSbaMV;

	[CompilerGenerated]
	private readonly string GNGvFaRAocx;

	[CompilerGenerated]
	private readonly string uv8vFiQQhXE;

	private static wnAXHuvJucRWfCkU17QJ pimDRtx5qSxeLO4wclkF;

	public wnAXHuvJucRWfCkU17QJ(string P_0, string P_1, string P_2 = null)
	{
		X4QOWyx5tXUXtIisViPP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				GNGvFaRAocx = P_1;
				ywdvFBSbaMV = P_0;
				uv8vFiQQhXE = P_2;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string bPOvF9Xdf2s()
	{
		return ywdvFBSbaMV;
	}

	[SpecialName]
	[CompilerGenerated]
	private string ObVvFGaHDsA()
	{
		return GNGvFaRAocx;
	}

	[SpecialName]
	[CompilerGenerated]
	public string gKDvFoWD9DW()
	{
		return uv8vFiQQhXE;
	}

	public string rhDvF08KbZX(string P_0, string P_1, long P_2)
	{
		string s = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28A2D4A), P_0, P_1, P_2);
		using HMACSHA512 hMACSHA = new HMACSHA512((byte[])FlB6w4x5UmIZQJKRnoSM(Encoding.UTF8, ObVvFGaHDsA()));
		return BitConverter.ToString(hMACSHA.ComputeHash(((Encoding)mlYEj0x5TsIjxZrBujJK()).GetBytes(s))).Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4220DA8 ^ 0x422E76A), "").ToLowerInvariant();
	}

	public string Ag7vF24Q8OT(string P_0, string P_1, string P_2, string P_3, string P_4)
	{
		using SHA512 sHA = SHA512.Create();
		byte[] bytes = ((Encoding)mlYEj0x5TsIjxZrBujJK()).GetBytes(P_1);
		string text = ((string)WEVRKDx5ZdcWA3I43fOT(DlLu8yx5yI0ybqKfilpY(sHA, bytes))).Replace((string)jG43P2x5VcsvqwEopq1f(0x5EA8FF2A ^ 0x5EA815E8), "").ToLowerInvariant();
		string text2 = P_0 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2002318893 ^ -2002263497) + P_2 + (string)jG43P2x5VcsvqwEopq1f(0x6AB40973 ^ 0x6AB4E297) + P_3 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86E1512) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2108526692 ^ -2108521352) + P_4;
		HMACSHA512 hMACSHA = new HMACSHA512((byte[])FlB6w4x5UmIZQJKRnoSM(Encoding.UTF8, ObVvFGaHDsA()));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				return ((string)WEVRKDx5ZdcWA3I43fOT(DlLu8yx5yI0ybqKfilpY(hMACSHA, FlB6w4x5UmIZQJKRnoSM(Encoding.UTF8, text2)))).Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624693459), "").ToLowerInvariant();
			}
			finally
			{
				((IDisposable)hMACSHA)?.Dispose();
			}
		}
	}

	public string D2CvFH9MSYM(string P_0)
	{
		string text = P_0 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7A66D1);
		using HMACSHA256 hMACSHA = new HMACSHA256(Encoding.UTF8.GetBytes(ObVvFGaHDsA()));
		return Convert.ToBase64String((byte[])DlLu8yx5yI0ybqKfilpY(hMACSHA, FlB6w4x5UmIZQJKRnoSM(Encoding.UTF8, text)));
	}

	public string isYvFfkffuV(string P_0, string P_1, string P_2, string P_3, string P_4)
	{
		string text = P_4 + P_0.ToUpper() + P_1;
		int num;
		if (!Hrn49nx5ClRoEaL5V411(P_2))
		{
			text = (string)ekpLsbx5rkhTSW96xWFH(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583264954), P_2);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00a4;
		IL_003e:
		text += P_3;
		goto IL_00df;
		IL_00df:
		HMACSHA256 hMACSHA = new HMACSHA256(((Encoding)mlYEj0x5TsIjxZrBujJK()).GetBytes(ObVvFGaHDsA()));
		try
		{
			return Convert.ToBase64String(hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(text)));
		}
		finally
		{
			if (hMACSHA != null)
			{
				re6ilHx5Km0PbGKYorwH(hMACSHA);
			}
		}
		IL_0009:
		switch (num)
		{
		case 2:
			goto IL_00a4;
		case 1:
			goto IL_00df;
		}
		goto IL_003e;
		IL_00a4:
		if (Hrn49nx5ClRoEaL5V411(P_3))
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_003e;
	}

	static wnAXHuvJucRWfCkU17QJ()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		YVVTD3x5m9DHSgxZMU1E();
	}

	internal static void X4QOWyx5tXUXtIisViPP()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool hnKnb4x5IcNIDlUY6JF6()
	{
		return pimDRtx5qSxeLO4wclkF == null;
	}

	internal static wnAXHuvJucRWfCkU17QJ PsZRKMx5WFNR8qHefpvK()
	{
		return pimDRtx5qSxeLO4wclkF;
	}

	internal static object FlB6w4x5UmIZQJKRnoSM(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object mlYEj0x5TsIjxZrBujJK()
	{
		return Encoding.UTF8;
	}

	internal static object DlLu8yx5yI0ybqKfilpY(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object WEVRKDx5ZdcWA3I43fOT(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object jG43P2x5VcsvqwEopq1f(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool Hrn49nx5ClRoEaL5V411(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ekpLsbx5rkhTSW96xWFH(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void re6ilHx5Km0PbGKYorwH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void YVVTD3x5m9DHSgxZMU1E()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
