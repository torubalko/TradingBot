using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace IOiWvuBcHLLCyfF8YFY4;

internal sealed class ocWJMfBc2FdCaACZ5rb4
{
	[CompilerGenerated]
	private string IuABc1UDIZZ;

	[CompilerGenerated]
	private string IGpBc5EeWFU;

	[CompilerGenerated]
	private string QGdBcSmD5ED;

	[CompilerGenerated]
	private long YMlBcxk16pS;

	[CompilerGenerated]
	private string B5WBcLetYfy;

	private static ocWJMfBc2FdCaACZ5rb4 mX2jyQxjSxIg6Qkdj0dM;

	[JsonProperty("event")]
	public string QhnBcGA1rwc
	{
		[CompilerGenerated]
		get
		{
			return IuABc1UDIZZ;
		}
		[CompilerGenerated]
		set
		{
			IuABc1UDIZZ = value;
		}
	}

	[JsonProperty("apiKey")]
	public string m6CBcv58GS7
	{
		[CompilerGenerated]
		get
		{
			return IGpBc5EeWFU;
		}
		[CompilerGenerated]
		set
		{
			IGpBc5EeWFU = value;
		}
	}

	[JsonProperty("authPayload")]
	public string SsGBciQp9NU
	{
		[CompilerGenerated]
		get
		{
			return QGdBcSmD5ED;
		}
		[CompilerGenerated]
		set
		{
			QGdBcSmD5ED = value;
		}
	}

	[JsonProperty("authNonce")]
	public long isLBcDmHnX9
	{
		[CompilerGenerated]
		get
		{
			return YMlBcxk16pS;
		}
		[CompilerGenerated]
		set
		{
			YMlBcxk16pS = value;
		}
	}

	[JsonProperty("authSig")]
	public string crDBckhB5oP
	{
		[CompilerGenerated]
		get
		{
			return B5WBcLetYfy;
		}
		[CompilerGenerated]
		set
		{
			B5WBcLetYfy = value;
		}
	}

	public static ocWJMfBc2FdCaACZ5rb4 S4OBcfNivaL(string KVe5AK1t7vTBU05BghQy, string m3Tj2C1t89gdUM3iD5vX)
	{
		long ticks = DateTime.Now.Ticks;
		HMACSHA384 hMACSHA = new HMACSHA384(((Encoding)r8rEUpxjeeDWfSWD53RY()).GetBytes(m3Tj2C1t89gdUM3iD5vX));
		string text = string.Format((string)gtaeqpxjspmgelYc9QRo(-203064540 ^ -203114876), ticks);
		byte[] buffer = (byte[])p5Oo6AxjcIqV4YG5LURh(ikytvjxjXYaGm99ODx8m(), text);
		string kI8tZK1t3T59qN5qQhpa = ((string)xwBwI9xjjx7b7FPLLbPY(hMACSHA.ComputeHash(buffer))).Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181402412), "").ToLowerInvariant();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			ocWJMfBc2FdCaACZ5rb4 obj = new ocWJMfBc2FdCaACZ5rb4
			{
				QhnBcGA1rwc = (string)gtaeqpxjspmgelYc9QRo(0x1EFE0A28 ^ 0x1EFF91A6)
			};
			QNFv3JxjE71FMfmFX3vR(obj, KVe5AK1t7vTBU05BghQy);
			mktNEZxjQ8weGfpg4nw3(obj, text);
			kbOcMjxjdDBNKVMG9728(obj, ticks);
			obj.crDBckhB5oP = kI8tZK1t3T59qN5qQhpa;
			return obj;
		}
		}
	}

	public ocWJMfBc2FdCaACZ5rb4()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static ocWJMfBc2FdCaACZ5rb4()
	{
		a4USsMxjgbLOLjtDAyhH();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool qQBMg1xjxlNQnsZ8I6UG()
	{
		return mX2jyQxjSxIg6Qkdj0dM == null;
	}

	internal static ocWJMfBc2FdCaACZ5rb4 ysPSffxjLVdBJiIjXEss()
	{
		return mX2jyQxjSxIg6Qkdj0dM;
	}

	internal static object r8rEUpxjeeDWfSWD53RY()
	{
		return Encoding.ASCII;
	}

	internal static object gtaeqpxjspmgelYc9QRo(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object ikytvjxjXYaGm99ODx8m()
	{
		return Encoding.Default;
	}

	internal static object p5Oo6AxjcIqV4YG5LURh(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object xwBwI9xjjx7b7FPLLbPY(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static void QNFv3JxjE71FMfmFX3vR(object P_0, object P_1)
	{
		((ocWJMfBc2FdCaACZ5rb4)P_0).m6CBcv58GS7 = (string)P_1;
	}

	internal static void mktNEZxjQ8weGfpg4nw3(object P_0, object P_1)
	{
		((ocWJMfBc2FdCaACZ5rb4)P_0).SsGBciQp9NU = (string)P_1;
	}

	internal static void kbOcMjxjdDBNKVMG9728(object P_0, long CbJCI41tFnxqw9YPGM38)
	{
		((ocWJMfBc2FdCaACZ5rb4)P_0).isLBcDmHnX9 = CbJCI41tFnxqw9YPGM38;
	}

	internal static void a4USsMxjgbLOLjtDAyhH()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
