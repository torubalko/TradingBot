using System;
using System.IO;
using b1blkEHqcM0qO0TqYSj5;
using ECOEgqlSad8NUJZ2Dr9n;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using TuAMtrl1Nd3XoZQQUXf0;

namespace H9wws1Hqe74hfxSCJKlP;

internal class gkiF1DHqL5mLMFgW0pKU : Hr4mPhHqX29rnbPnS5kr
{
	private ECDomainParameters ECmHqsORZ3f;

	internal static gkiF1DHqL5mLMFgW0pKU x2fOo3DM2heEqMWIxuDd;

	public gkiF1DHqL5mLMFgW0pKU(ECDomainParameters P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ECmHqsORZ3f = P_0;
	}

	public AsymmetricKeyParameter Qhel9NaghP8(ArraySegment<byte> P_0, out byte[] P_1)
	{
		P_1 = null;
		byte b = P_0.Array[0];
		switch (b)
		{
		case 0:
			throw new IOException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x44695BB4));
		case 2:
		case 3:
			P_1 = new byte[1 + (ECmHqsORZ3f.Curve.FieldSize + 7) / 8];
			break;
		case 4:
		case 6:
		case 7:
			P_1 = new byte[1 + 2 * ((ECmHqsORZ3f.Curve.FieldSize + 7) / 8)];
			break;
		default:
			throw new IOException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x7354F93D) + b.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E05315C)));
		}
		Array.Copy(P_0.Array, P_1, P_1.Length);
		return new ECPublicKeyParameters(ECmHqsORZ3f.Curve.DecodePoint(P_1), ECmHqsORZ3f);
	}

	static gkiF1DHqL5mLMFgW0pKU()
	{
		H6nT8kDM94omF7BMmYwe();
	}

	internal static bool X6uKNIDMHL04GK27WPtO()
	{
		return x2fOo3DM2heEqMWIxuDd == null;
	}

	internal static gkiF1DHqL5mLMFgW0pKU stu7A4DMfojkfsmCtdXN()
	{
		return x2fOo3DM2heEqMWIxuDd;
	}

	internal static void H6nT8kDM94omF7BMmYwe()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
