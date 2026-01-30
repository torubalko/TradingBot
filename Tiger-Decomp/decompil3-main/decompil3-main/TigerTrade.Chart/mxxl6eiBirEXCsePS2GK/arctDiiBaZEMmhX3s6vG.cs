using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.List;

namespace mxxl6eiBirEXCsePS2GK;

[ChartObject("ElliottWaveCorrection", "ChartObjectsElliottCorrectionWave", 4, Type = typeof(arctDiiBaZEMmhX3s6vG))]
[DataContract(Name = "ElliottWaveCorrectionObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
internal sealed class arctDiiBaZEMmhX3s6vG : ElliottWaveObject
{
	internal static arctDiiBaZEMmhX3s6vG FNTDv3Lz4kq7AK8PI09R;

	protected override string GetDegreeText(int P_0)
	{
		int num = 3;
		string[] array3 = default(string[]);
		string[] array2 = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (P_0 >= 0)
					{
						goto end_IL_0012;
					}
					goto IL_00da;
				case 1:
					array3 = new string[4]
					{
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-371631841 ^ -371645927),
						(string)Ty5UCCLzNFPqKK3wsFXK(0x28BBDCA ^ 0x28BC666),
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x809C179),
						(string)Ty5UCCLzNFPqKK3wsFXK(--18459671 ^ 0x119D7AF)
					};
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (P_0 > 3)
					{
						goto IL_00da;
					}
					array2 = new string[4]
					{
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -5983597),
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1380525184 ^ -1380540390),
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842071841),
						yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774599251)
					};
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					{
						string[] array = new string[4]
						{
							yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x1262793E),
							yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28B345BB ^ 0x28B33E21),
							(string)Ty5UCCLzNFPqKK3wsFXK(-1380525184 ^ -1380540384),
							(string)Ty5UCCLzNFPqKK3wsFXK(0x6AB40973 ^ 0x6AB472D5)
						};
						return base.Degree switch
						{
							ElliottWaveDegree.GrandSupercycle => (string)OSigasLzkLubv8PiGuul(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D8E237), array2[P_0], Ty5UCCLzNFPqKK3wsFXK(-1774602229 ^ -1774599293)), 
							ElliottWaveDegree.Supercycle => (string)Ty5UCCLzNFPqKK3wsFXK(0x3544E813 ^ 0x3544939D) + array2[P_0] + (string)Ty5UCCLzNFPqKK3wsFXK(-490987856 ^ -490969820), 
							ElliottWaveDegree.Cycle => array2[P_0], 
							ElliottWaveDegree.Primary => (string)OSigasLzkLubv8PiGuul(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x60627443), array3[P_0], yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1251569705 ^ -1251543969)), 
							ElliottWaveDegree.Intermediate => yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490969794) + array3[P_0] + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1AB79299 ^ 0x1AB7E90D), 
							ElliottWaveDegree.Minor => array3[P_0], 
							ElliottWaveDegree.Minute => (string)OSigasLzkLubv8PiGuul(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D314BCA), array[P_0], Ty5UCCLzNFPqKK3wsFXK(0x315AB1E3 ^ 0x315ACA6B)), 
							ElliottWaveDegree.Minuette => (string)OSigasLzkLubv8PiGuul(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2017337494 ^ -2017352476), array[P_0], yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838848116)), 
							ElliottWaveDegree.Subminuette => array[P_0], 
							_ => "", 
						};
					}
					IL_00da:
					return "";
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public arctDiiBaZEMmhX3s6vG()
	{
		auAcmNLz1I3XtY6Ksns0();
		base._002Ector();
	}

	static arctDiiBaZEMmhX3s6vG()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Ty5UCCLzNFPqKK3wsFXK(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object OSigasLzkLubv8PiGuul(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool i67NcuLzDWZKI5Q98xPN()
	{
		return FNTDv3Lz4kq7AK8PI09R == null;
	}

	internal static arctDiiBaZEMmhX3s6vG mvHyWyLzbX3yBxXhNHjt()
	{
		return FNTDv3Lz4kq7AK8PI09R;
	}

	internal static void auAcmNLz1I3XtY6Ksns0()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}
}
