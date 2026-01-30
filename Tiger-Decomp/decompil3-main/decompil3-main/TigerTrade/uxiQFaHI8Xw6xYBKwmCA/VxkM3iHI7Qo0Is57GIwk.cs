using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ABxgvYHyUBReVTOnCgrh;
using BeZUmLHycXdIKSy1sjhT;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Annotations;
using TigerTrade.Core.Utils.Binary;
using TuAMtrl1Nd3XoZQQUXf0;
using xqV2vBHWn0V9lv48Ruor;

namespace uxiQFaHI8Xw6xYBKwmCA;

internal sealed class VxkM3iHI7Qo0Is57GIwk : BinReader<Ai3xtDHyXEfq3el8VjlP>, ba3wC6HW9Z9BbFw2X25x<Ai3xtDHyXEfq3el8VjlP>
{
	internal class OawMP3nhsVPQM7ehiXGY
	{
		public static readonly byte None;

		public static readonly byte OpenPos;

		private static OawMP3nhsVPQM7ehiXGY deRsuVNQEmbkikAJB3rd;

		public OawMP3nhsVPQM7ehiXGY()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		static OawMP3nhsVPQM7ehiXGY()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					fbDUecNQRiTfmdigmfOF();
					None = 0;
					OpenPos = 1;
					return;
				case 1:
					AsdbYeNQgAwq9gBgi88c();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool sSfqeYNQQ3Ut79gSPkLo()
		{
			return deRsuVNQEmbkikAJB3rd == null;
		}

		internal static OawMP3nhsVPQM7ehiXGY A64eNfNQdfH8bdE4trqe()
		{
			return deRsuVNQEmbkikAJB3rd;
		}

		internal static void AsdbYeNQgAwq9gBgi88c()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void fbDUecNQRiTfmdigmfOF()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	private long ekdHIFIypri;

	private long V30HI326dpf;

	private readonly double gbaHIplPjqa;

	private readonly double X5oHIuSyuiM;

	private readonly Action<string> QCEHIz0sBdH;

	private readonly bool ve0HW0YkTmn;

	private readonly decimal PevHW2EwL1s;

	private readonly double SWfHWHBcu8d;

	private byte LpFHWfJFmqX;

	internal static VxkM3iHI7Qo0Is57GIwk BponsNDOgO4NfR67Y8ya;

	public VxkM3iHI7Qo0Is57GIwk(byte[] P_0, double P_1, double P_2, [CanBeNull] Action<string> onError, double P_4 = 1.0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0);
		if (!base.IsEmpty)
		{
			gbaHIplPjqa = ReadDouble();
			X5oHIuSyuiM = P_1;
			ve0HW0YkTmn = X5oHIuSyuiM > 0.0 && X5oHIuSyuiM != gbaHIplPjqa;
			if (ve0HW0YkTmn)
			{
				PevHW2EwL1s = (decimal)gbaHIplPjqa / (decimal)X5oHIuSyuiM;
			}
			SWfHWHBcu8d = P_4;
			QCEHIz0sBdH = onError;
		}
	}

	private DateTime SfdHIAFfEF2()
	{
		ekdHIFIypri += ReadLeb128();
		return new DateTime(ekdHIFIypri);
	}

	private long COxHIPSW7j1()
	{
		V30HI326dpf += ReadLeb128();
		if (ve0HW0YkTmn)
		{
			return G9oxP2DOOB01hg3hfd0D(xhmKcsDOMVOoApVVIwCd((decimal)V30HI326dpf * PevHW2EwL1s, MidpointRounding.AwayFromZero));
		}
		return V30HI326dpf;
	}

	private long e6tHIJ805XQ()
	{
		long num = ReadLeb128();
		if (SWfHWHBcu8d != 1.0)
		{
			return (long)((double)num * SWfHWHBcu8d);
		}
		return num;
	}

	protected override Ai3xtDHyXEfq3el8VjlP ReadItem()
	{
		int num = 4;
		Ai3xtDHyXEfq3el8VjlP ai3xtDHyXEfq3el8VjlP = default(Ai3xtDHyXEfq3el8VjlP);
		BJtE02HytsgECDGsyUU4 bJtE02HytsgECDGsyUU = default(BJtE02HytsgECDGsyUU4);
		int num4 = default(int);
		long num3 = default(long);
		Dictionary<long, BJtE02HytsgECDGsyUU4> dictionary = default(Dictionary<long, BJtE02HytsgECDGsyUU4>);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					ai3xtDHyXEfq3el8VjlP.CLXHyWqXcuh = ReadLeb128();
					goto IL_0084;
				case 11:
					ai3xtDHyXEfq3el8VjlP.AmEHyIifxoV = ReadLeb128();
					num2 = 7;
					continue;
				case 6:
					bJtE02HytsgECDGsyUU.HLKHyrsbDms = ReadLeb128();
					bJtE02HytsgECDGsyUU.Pe6HyKSV4d0 = oyAWT5DOINSnVlsuLiYS(this);
					goto IL_0331;
				case 2:
					bJtE02HytsgECDGsyUU = new BJtE02HytsgECDGsyUU4(COxHIPSW7j1())
					{
						Bid = e6tHIJ805XQ(),
						Ask = e6tHIJ805XQ(),
						b6XHyyvHEfX = e6tHIJ805XQ(),
						Ks1HyZcxorY = e6tHIJ805XQ(),
						thSHyVbl7Ce = (int)ReadLeb128(),
						Sd2HyCo9Wbh = (int)ReadLeb128()
					};
					num2 = 10;
					continue;
				case 5:
					ai3xtDHyXEfq3el8VjlP.OpenPos = oyAWT5DOINSnVlsuLiYS(this);
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
					{
						num2 = 11;
					}
					continue;
				case 1:
					if (num4 >= num3)
					{
						if (num3 != dictionary.Count)
						{
							QCEHIz0sBdH(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -616843513), ai3xtDHyXEfq3el8VjlP.Time, num3, dictionary.Count));
							dictionary = new Dictionary<long, BJtE02HytsgECDGsyUU4>(dictionary);
						}
						ai3xtDHyXEfq3el8VjlP.Items = dictionary;
						return ai3xtDHyXEfq3el8VjlP;
					}
					goto case 2;
				case 8:
					if (flag)
					{
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_0084;
				case 10:
					if (flag)
					{
						num2 = 6;
						continue;
					}
					goto IL_0331;
				case 4:
					LpFHWfJFmqX = GiZKNODOqcqo3XCxYoEf(this);
					num2 = 3;
					continue;
				case 9:
					return ai3xtDHyXEfq3el8VjlP;
				case 3:
					{
						flag = (LpFHWfJFmqX & OawMP3nhsVPQM7ehiXGY.OpenPos) != 0;
						ai3xtDHyXEfq3el8VjlP = new Ai3xtDHyXEfq3el8VjlP(SfdHIAFfEF2())
						{
							OpenTime = SfdHIAFfEF2(),
							CloseTime = SfdHIAFfEF2(),
							WT4Hydamaer = COxHIPSW7j1(),
							ocgHygQL53j = COxHIPSW7j1(),
							aMKHyRo2BUc = COxHIPSW7j1(),
							Close = COxHIPSW7j1(),
							KcWHy6OudXg = e6tHIJ805XQ(),
							fcnHyMI3Ecm = e6tHIJ805XQ() * -1,
							lP0HyOXMq3O = e6tHIJ805XQ(),
							CI4HyqWu69E = e6tHIJ805XQ() * -1
						};
						num2 = 8;
						continue;
					}
					IL_0084:
					num3 = oyAWT5DOINSnVlsuLiYS(this);
					if (num3 < 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (num3 <= int.MaxValue)
					{
						dictionary = new Dictionary<long, BJtE02HytsgECDGsyUU4>((int)num3);
						num4 = 0;
						goto case 1;
					}
					QCEHIz0sBdH((string)g33S5CDOWObqejs2mtHq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B66A16), ai3xtDHyXEfq3el8VjlP.Time, num3));
					return ai3xtDHyXEfq3el8VjlP;
					IL_0331:
					dictionary[bJtE02HytsgECDGsyUU.kt5HyTQHYFD] = bJtE02HytsgECDGsyUU;
					num4++;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			QCEHIz0sBdH(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B4A5BB), ai3xtDHyXEfq3el8VjlP.Time, num3));
			num = 9;
		}
	}

	[SpecialName]
	Ai3xtDHyXEfq3el8VjlP ba3wC6HW9Z9BbFw2X25x<Ai3xtDHyXEfq3el8VjlP>.get_LastItem()
	{
		return base.LastItem;
	}

	bool ba3wC6HW9Z9BbFw2X25x<Ai3xtDHyXEfq3el8VjlP>.Read()
	{
		return Read();
	}

	static VxkM3iHI7Qo0Is57GIwk()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool lfmFX5DORcC2euZjXoBy()
	{
		return BponsNDOgO4NfR67Y8ya == null;
	}

	internal static VxkM3iHI7Qo0Is57GIwk PpCtUWDO64DbBxY1VYl2()
	{
		return BponsNDOgO4NfR67Y8ya;
	}

	internal static decimal xhmKcsDOMVOoApVVIwCd(decimal P_0, MidpointRounding P_1)
	{
		return Math.Round(P_0, P_1);
	}

	internal static long G9oxP2DOOB01hg3hfd0D(decimal P_0)
	{
		return (long)P_0;
	}

	internal static byte GiZKNODOqcqo3XCxYoEf(object P_0)
	{
		return ((BinReader<Ai3xtDHyXEfq3el8VjlP>)P_0).ReadByte();
	}

	internal static long oyAWT5DOINSnVlsuLiYS(object P_0)
	{
		return ((BinReader<Ai3xtDHyXEfq3el8VjlP>)P_0).ReadLeb128();
	}

	internal static object g33S5CDOWObqejs2mtHq(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
