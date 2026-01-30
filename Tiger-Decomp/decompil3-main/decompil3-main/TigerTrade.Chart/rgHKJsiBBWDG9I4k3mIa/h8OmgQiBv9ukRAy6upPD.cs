using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.List;

namespace rgHKJsiBBWDG9I4k3mIa;

[ChartObject("ElliottWaveImpulse", "ChartObjectsElliottImpulseWave", 6, Type = typeof(h8OmgQiBv9ukRAy6upPD))]
[DataContract(Name = "ElliottWaveImpulseObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
internal sealed class h8OmgQiBv9ukRAy6upPD : ElliottWaveObject
{
	internal static h8OmgQiBv9ukRAy6upPD BwLJBeLzYxBhr7nbdHPF;

	protected override string GetDegreeText(int P_0)
	{
		int num = 2;
		string[] array = default(string[]);
		ElliottWaveDegree degree = default(ElliottWaveDegree);
		string[] array2 = default(string[]);
		string[] array3 = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				default:
					return (string)X9cj1MLzBEI4b4XeTi78(-673683647 ^ -673702717) + array[P_0] + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435569255);
				case 4:
					switch (degree)
					{
					case ElliottWaveDegree.GrandSupercycle:
						break;
					case ElliottWaveDegree.Supercycle:
						return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490969794) + array[P_0] + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D1883F6);
					case ElliottWaveDegree.Cycle:
						return array[P_0];
					case ElliottWaveDegree.Primary:
						return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774599287) + array2[P_0] + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741BFE43);
					case ElliottWaveDegree.Intermediate:
						return (string)X9cj1MLzBEI4b4XeTi78(-1127423276 ^ -1127442086) + array2[P_0] + (string)X9cj1MLzBEI4b4XeTi78(-1127423276 ^ -1127442112);
					case ElliottWaveDegree.Minor:
						return array2[P_0];
					case ElliottWaveDegree.Minute:
						return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x126279EA) + array3[P_0] + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x11D1040B ^ 0x11D17F83);
					case ElliottWaveDegree.Minuette:
						return (string)iRT4KRLzaWaK4m5XQN7h(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165448521), array3[P_0], yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28C965BE ^ 0x28C91E2A));
					case ElliottWaveDegree.Subminuette:
						return array3[P_0];
					default:
						return "";
					}
					goto default;
				case 2:
					if (P_0 >= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_015e;
				case 1:
					{
						if (P_0 <= 5)
						{
							array = new string[6]
							{
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90277828),
								(string)X9cj1MLzBEI4b4XeTi78(0x4662F6AF ^ 0x46628DA3),
								(string)X9cj1MLzBEI4b4XeTi78(-673683647 ^ -673702829),
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774599407),
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x7394A956),
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602167457)
							};
							array2 = new string[6]
							{
								(string)X9cj1MLzBEI4b4XeTi78(-57768881 ^ -57737347),
								(string)X9cj1MLzBEI4b4XeTi78(0x446AB724 ^ 0x446ACC1C),
								(string)X9cj1MLzBEI4b4XeTi78(0x684F243E ^ 0x684F5F00),
								(string)X9cj1MLzBEI4b4XeTi78(--500511424 ^ 0x1DD54984),
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24B0B9E6 ^ 0x24B0C2AC),
								yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-602153869 ^ -602167517)
							};
							num2 = 3;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto IL_015e;
					}
					IL_015e:
					return "";
				}
				break;
			}
			array3 = new string[6]
			{
				yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4220DA8 ^ 0x42276FE),
				yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x404ED0BE ^ 0x404EABE2),
				(string)X9cj1MLzBEI4b4XeTi78(-1522697859 ^ -1522728417),
				yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA88440),
				yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736547340),
				(string)X9cj1MLzBEI4b4XeTi78(-1878953018 ^ -1878980422)
			};
			degree = base.Degree;
			num = 4;
		}
	}

	public h8OmgQiBv9ukRAy6upPD()
	{
		VALHVeLzi0sx8JpD89lX();
		base._002Ector();
	}

	static h8OmgQiBv9ukRAy6upPD()
	{
		BbslUtLzlpDUbO3JGUoZ();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object X9cj1MLzBEI4b4XeTi78(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object iRT4KRLzaWaK4m5XQN7h(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool XLZOLTLzopAYUSpUHVoG()
	{
		return BwLJBeLzYxBhr7nbdHPF == null;
	}

	internal static h8OmgQiBv9ukRAy6upPD RMRA5aLzvhTGt1C5RipK()
	{
		return BwLJBeLzYxBhr7nbdHPF;
	}

	internal static void VALHVeLzi0sx8JpD89lX()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void BbslUtLzlpDUbO3JGUoZ()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
