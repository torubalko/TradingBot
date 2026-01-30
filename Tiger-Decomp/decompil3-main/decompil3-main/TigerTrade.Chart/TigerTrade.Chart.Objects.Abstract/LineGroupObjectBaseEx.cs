using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Objects.Common;

namespace TigerTrade.Chart.Objects.Abstract;

[DataContract(Name = "LineGroupObjectBaseEx", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class LineGroupObjectBaseEx : LineGroupObjectBase
{
	private bool _openStart;

	private bool _openEnd;

	internal static LineGroupObjectBaseEx NfV2ofeYNnDuZxLTNbw9;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandStart")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "OpenStart")]
	public bool OpenStart
	{
		get
		{
			return _openStart;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (value == _openStart)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
						{
							num2 = 0;
						}
						break;
					}
					_openStart = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x3301EC11));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "OpenEnd")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandEnd")]
	public bool OpenEnd
	{
		get
		{
			return _openEnd;
		}
		set
		{
			if (value != _openEnd)
			{
				_openEnd = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1347025559));
			}
		}
	}

	protected void OpenStartEnd(bool openStart, bool openEnd)
	{
		if (StartPoints == null)
		{
			return;
		}
		int num = 0;
		Point point = default(Point);
		Point point2 = default(Point);
		Point point4 = default(Point);
		while (true)
		{
			int num2;
			if (num < StartPoints.Length)
			{
				point = StartPoints[num];
				point2 = EndPoints[num];
				if (!openStart)
				{
					goto IL_0119;
				}
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 3;
			}
			goto IL_0009;
			IL_0119:
			if (!openEnd)
			{
				goto IL_002b;
			}
			num2 = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
			{
				num2 = 3;
			}
			goto IL_0009;
			IL_0139:
			XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, point2, point, out var point3);
			StartPoints[num] = point3;
			goto IL_0119;
			IL_002b:
			num++;
			continue;
			IL_0009:
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 4:
					XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, point, point2, out point4);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				default:
				{
					EndPoints[num] = point4;
					int num3 = 5;
					num2 = num3;
					continue;
				}
				case 1:
					goto IL_0139;
				case 2:
					return;
				}
				break;
			}
			goto IL_002b;
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is LineGroupObjectBaseEx lineGroupObjectBaseEx)
		{
			OpenStart = lineGroupObjectBaseEx.OpenStart;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OpenEnd = lineGroupObjectBaseEx.OpenEnd;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
		base.CopyTemplate(objectBase, style);
	}

	protected LineGroupObjectBaseEx()
	{
		OCd0WDeY5ny7D5UNaAf7();
		base._002Ector();
	}

	static LineGroupObjectBaseEx()
	{
		wvrRSSeYStrUe7pnEbSe();
		PeUaVZeYxx90B6VqcUwh();
	}

	internal static bool xBeUreeYkbj1RklGoHIn()
	{
		return NfV2ofeYNnDuZxLTNbw9 == null;
	}

	internal static LineGroupObjectBaseEx cXtMu8eY1mAhiWy8lMub()
	{
		return NfV2ofeYNnDuZxLTNbw9;
	}

	internal static void OCd0WDeY5ny7D5UNaAf7()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void wvrRSSeYStrUe7pnEbSe()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void PeUaVZeYxx90B6VqcUwh()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
