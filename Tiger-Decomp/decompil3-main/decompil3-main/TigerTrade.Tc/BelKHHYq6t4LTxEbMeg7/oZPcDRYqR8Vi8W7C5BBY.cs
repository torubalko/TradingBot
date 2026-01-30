using System.IO;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace BelKHHYq6t4LTxEbMeg7;

internal sealed class oZPcDRYqR8Vi8W7C5BBY
{
	private readonly MemoryStream a00Yqyhc0CX;

	private readonly BinaryWriter FBQYqZS66xX;

	internal static oZPcDRYqR8Vi8W7C5BBY d5QrquSX8VEABODh8o8Y;

	public oZPcDRYqR8Vi8W7C5BBY()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		a00Yqyhc0CX = new MemoryStream();
		FBQYqZS66xX = new BinaryWriter(a00Yqyhc0CX);
	}

	public void jIvYqM8fFV6(long P_0)
	{
		if (P_0 >= 0)
		{
			goto IL_009c;
		}
		goto IL_0134;
		IL_009c:
		int num = (int)(P_0 & 0x7F);
		P_0 >>= 7;
		int num2 = 4;
		goto IL_0009;
		IL_0009:
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
				FBQYqZS66xX.BaseStream.WriteByte((byte)num);
				return;
			case 2:
				break;
			default:
				FBQYqZS66xX.BaseStream.WriteByte((byte)(num | 0x80));
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				if (P_0 == 0L)
				{
					num2 = 5;
					continue;
				}
				goto default;
			case 1:
				goto IL_0101;
			case 5:
				if ((num & 0x40) != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 3:
				goto IL_018a;
			}
			break;
			IL_018a:
			P_0 >>= 7;
			if (P_0 == -1)
			{
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			goto IL_004d;
			IL_0101:
			if ((num3 & 0x40) == 0)
			{
				goto IL_004d;
			}
			HIMgicSXJpf8oBHll09I(FBQYqZS66xX.BaseStream, (byte)num3);
			return;
		}
		goto IL_009c;
		IL_0134:
		num3 = (int)(P_0 & 0x7F);
		num2 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
		{
			num2 = 3;
		}
		goto IL_0009;
		IL_004d:
		FBQYqZS66xX.BaseStream.WriteByte((byte)(num3 | 0x80));
		goto IL_0134;
	}

	public void z9fYqOmQ8rU(bool P_0)
	{
		FBQYqZS66xX.Write(P_0);
	}

	public void scHYqqsruqP(byte P_0)
	{
		uGqUA7SXFBpVr5FqummG(FBQYqZS66xX, P_0);
	}

	public void F1CYqIH4WLR(int P_0)
	{
		FBQYqZS66xX.Write(P_0);
	}

	public void t9jYqWOXb32(long P_0)
	{
		FBQYqZS66xX.Write(P_0);
	}

	public void YUCYqthxbj9(double P_0)
	{
		FBQYqZS66xX.Write(P_0);
	}

	public void sd6YqUIuYB8(string P_0)
	{
		sCal6USX3acbsFPMcmi4(FBQYqZS66xX, P_0);
	}

	public byte[] a2EYqTmVn0T()
	{
		return (byte[])y3To5rSXp62K4q410lGU(a00Yqyhc0CX);
	}

	static oZPcDRYqR8Vi8W7C5BBY()
	{
		TjKJsCSXuaH2cGekf8tR();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool iX0EkpSXAOcfjTdCGiYJ()
	{
		return d5QrquSX8VEABODh8o8Y == null;
	}

	internal static oZPcDRYqR8Vi8W7C5BBY QlCk4fSXPjAoYoWDTfXY()
	{
		return d5QrquSX8VEABODh8o8Y;
	}

	internal static void HIMgicSXJpf8oBHll09I(object P_0, byte P_1)
	{
		((Stream)P_0).WriteByte(P_1);
	}

	internal static void uGqUA7SXFBpVr5FqummG(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void sCal6USX3acbsFPMcmi4(object P_0, object P_1)
	{
		((BinaryWriter)P_0).Write((string)P_1);
	}

	internal static object y3To5rSXp62K4q410lGU(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void TjKJsCSXuaH2cGekf8tR()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
