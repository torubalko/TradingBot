using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("Channel", "ChartObjectsChannel", 3, Type = typeof(ChannelObject))]
[DataContract(Name = "ChannelObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class ChannelObject : LineGroupObjectBaseEx
{
	private bool _middleLine;

	internal static ChannelObject PmNB9ELuKflX3icMdK4V;

	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsMiddleLine")]
	[DataMember(Name = "MiddleLine")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	public bool MiddleLine
	{
		get
		{
			return _middleLine;
		}
		set
		{
			if (value != _middleLine)
			{
				_middleLine = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736547766));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	public ChannelObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				MiddleLine = false;
				return;
			}
			base.OpenStart = true;
			base.OpenEnd = true;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
			{
				num = 1;
			}
		}
	}

	protected override void CalcPoint()
	{
		double[] array = ((!MiddleLine) ? new double[2] { 0.0, 1.0 } : new double[3] { 0.0, 0.5, 1.0 });
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
		{
			num = 3;
		}
		int num2 = default(int);
		Point[] array2 = default(Point[]);
		double num3 = default(double);
		double num4 = default(double);
		while (true)
		{
			switch (num)
			{
			case 5:
				num2++;
				goto IL_0089;
			case 1:
				StartPoints = new Point[array.Length];
				num = 4;
				break;
			case 4:
				EndPoints = new Point[array.Length];
				if (array2.Length == 3)
				{
					num3 = array2[2].X - array2[0].X;
					num4 = array2[2].Y - array2[0].Y;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 6;
			default:
				num2 = 0;
				goto IL_0089;
			case 3:
				array2 = ToPoints(base.ControlPoints);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 1;
				}
				break;
			case 6:
				OpenStartEnd(base.OpenStart, base.OpenEnd);
				return;
			case 2:
				{
					EndPoints[num2] = new Point(array2[1].X + num3 * array[num2], array2[1].Y + num4 * array[num2]);
					int num5 = 5;
					num = num5;
					break;
				}
				IL_0089:
				if (num2 >= array.Length)
				{
					num = 6;
					break;
				}
				StartPoints[num2] = new Point(array2[0].X + num3 * array[num2], array2[0].Y + num4 * array[num2]);
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is ChannelObject channelObject)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			MiddleLine = rU2VSZLuwrY8Fk3rmRLg(channelObject);
		}
		base.CopyTemplate(objectBase, style);
	}

	static ChannelObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool c0bRn1LumftMBt4fwP5F()
	{
		return PmNB9ELuKflX3icMdK4V == null;
	}

	internal static ChannelObject qrltenLuh0XsJ9G2pcUR()
	{
		return PmNB9ELuKflX3icMdK4V;
	}

	internal static bool rU2VSZLuwrY8Fk3rmRLg(object P_0)
	{
		return ((ChannelObject)P_0).MiddleLine;
	}
}
