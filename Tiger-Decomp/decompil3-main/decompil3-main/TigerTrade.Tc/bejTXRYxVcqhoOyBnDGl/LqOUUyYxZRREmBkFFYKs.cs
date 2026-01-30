using System;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using Dj8HDoYxlnY3q8BFWiWA;
using K1GcsD5GTtMSlaiJI0Xh;
using KmrA8oYxgReC915xXAok;
using kZKenUYLv0ApHh7vqrs9;
using x97CE55GhEYKgt7TSVZT;

namespace bejTXRYxVcqhoOyBnDGl;

internal sealed class LqOUUyYxZRREmBkFFYKs : GSmpvHYxdci6k38dPXof<SOquTYYLoauEnburNGkL>
{
	[Flags]
	internal enum HhQUDpaWxHVxlKRuBQZi
	{
		None = 0,
		Volume = 0x10,
		OpenPos = 0x20
	}

	private long t4mYxrVQLu9;

	private long p8DYxKU9dH2;

	private long kAkYxmiwLfo;

	private long gutYxhZSe61;

	private long gCjYxwOCpGN;

	internal static LqOUUyYxZRREmBkFFYKs I3nIZOSN5hOPW1nWvsrf;

	[SpecialName]
	public override int KjplotVIc0m()
	{
		return 1;
	}

	public LqOUUyYxZRREmBkFFYKs(WguQRvYxiy6xOxYF24IV P_0)
	{
		QiNklMSNLYdtllfKBRyW();
		base._002Ector(P_0);
	}

	public override void cFSloqb3PWY()
	{
		HhQUDpaWxHVxlKRuBQZi hhQUDpaWxHVxlKRuBQZi = (HhQUDpaWxHVxlKRuBQZi)bBKYxqcojA1.ReadUInt16();
		if ((hhQUDpaWxHVxlKRuBQZi & (HhQUDpaWxHVxlKRuBQZi)4) != HhQUDpaWxHVxlKRuBQZi.None)
		{
			t4mYxrVQLu9 = bBKYxqcojA1.MdEYxb2TmTZ(t4mYxrVQLu9);
		}
		int num;
		if ((hhQUDpaWxHVxlKRuBQZi & (HhQUDpaWxHVxlKRuBQZi)2) != HhQUDpaWxHVxlKRuBQZi.None)
		{
			p8DYxKU9dH2 = bBKYxqcojA1.MdEYxb2TmTZ(p8DYxKU9dH2);
			num = 4;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		}
		goto IL_01ba;
		IL_0027:
		if ((hhQUDpaWxHVxlKRuBQZi & HhQUDpaWxHVxlKRuBQZi.Volume) != HhQUDpaWxHVxlKRuBQZi.None)
		{
			num = 3;
			goto IL_0009;
		}
		goto IL_01ab;
		IL_01ba:
		if ((hhQUDpaWxHVxlKRuBQZi & (HhQUDpaWxHVxlKRuBQZi)8) != HhQUDpaWxHVxlKRuBQZi.None)
		{
			kAkYxmiwLfo += bBKYxqcojA1.i0MYx46Ra5S();
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0027;
		IL_01ab:
		if ((hhQUDpaWxHVxlKRuBQZi & HhQUDpaWxHVxlKRuBQZi.OpenPos) != HhQUDpaWxHVxlKRuBQZi.None)
		{
			gCjYxwOCpGN += bBKYxqcojA1.i0MYx46Ra5S();
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00f2;
		IL_00f2:
		iMMYxRFrQPi(new SOquTYYLoauEnburNGkL
		{
			kGdYLiK53kZ = ((hhQUDpaWxHVxlKRuBQZi & (HhQUDpaWxHVxlKRuBQZi)1) != 0),
			DerYLBbsjlX = p8DYxKU9dH2,
			Time = new DateTime(t4mYxrVQLu9 * 10000),
			svxYLau4VHy = kAkYxmiwLfo,
			Volume = gutYxhZSe61,
			OpenPos = gCjYxwOCpGN
		});
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 2:
			break;
		case 1:
			return;
		case 3:
			goto IL_00dc;
		default:
			goto IL_00f2;
		case 4:
			goto IL_01ba;
		}
		goto IL_0027;
		IL_00dc:
		gutYxhZSe61 = bBKYxqcojA1.i0MYx46Ra5S();
		goto IL_01ab;
	}

	public void DI3YxCl0aMR()
	{
		t4mYxrVQLu9 = 0L;
		p8DYxKU9dH2 = 0L;
		kAkYxmiwLfo = 0L;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				gCjYxwOCpGN = 0L;
				return;
			}
			gutYxhZSe61 = 0L;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
			{
				num = 1;
			}
		}
	}

	static LqOUUyYxZRREmBkFFYKs()
	{
		EnRsccSNe3De65wtn2Sf();
		mCj8u3SNs2TfVUJbFvaY();
	}

	internal static void QiNklMSNLYdtllfKBRyW()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool oUFCm2SNSciNEvQjDYjf()
	{
		return I3nIZOSN5hOPW1nWvsrf == null;
	}

	internal static LqOUUyYxZRREmBkFFYKs h51qACSNxkAaSuB42BbE()
	{
		return I3nIZOSN5hOPW1nWvsrf;
	}

	internal static void EnRsccSNe3De65wtn2Sf()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void mCj8u3SNs2TfVUJbFvaY()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
