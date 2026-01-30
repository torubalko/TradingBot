using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace PIs41Oiaj5EGNbiEfkxo;

[DataContract(Name = "MultiArcObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("MultiArc", "ChartObjectsMultiArc", 2, Type = typeof(CXEdsXiacbOVON8ZEe0J))]
internal sealed class CXEdsXiacbOVON8ZEe0J : LineObjectBase
{
	[CompilerGenerated]
	private double[] fbViaR0pcfR;

	private static CXEdsXiacbOVON8ZEe0J HZkSVweflfZRfyRW6kxV;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Split")]
	[Browsable(false)]
	public double[] WY3iag07XBF
	{
		[CompilerGenerated]
		get
		{
			return fbViaR0pcfR;
		}
		[CompilerGenerated]
		set
		{
			fbViaR0pcfR = array;
		}
	}

	public CXEdsXiacbOVON8ZEe0J()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		WY3iag07XBF = new double[5] { 0.3333333, 0.375, 0.5, 0.625, 0.6666667 };
	}

	protected override void Draw(DxVisualQueue P_0, ref List<ObjectLabelInfo> P_1)
	{
		Point point = ToPoint(base.ControlPoints[0]);
		Point point2 = ToPoint(base.ControlPoints[1]);
		double num = XyaVo8ilJa9AfK2KZEye.pFoil3yxg7x(point, point2);
		int num2 = 2;
		double[] array = default(double[]);
		int num3 = default(int);
		double num5 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 3:
				array = WY3iag07XBF;
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (point2.Y < point.Y)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				ciBZkbefbuoTiPYEGDRP(P_0, base.LinePen, new Point(point.X + num5, point.Y), new Point(point.X - num5, point.Y), num5, 180.0);
				goto case 4;
			case 6:
				P_0.DrawLine(base.LinePen, point, point2);
				return;
			case 1:
				if (num3 < array.Length)
				{
					double num4 = array[num3];
					num5 = num * num4;
					num2 = 5;
				}
				else
				{
					num2 = 6;
				}
				break;
			default:
			{
				P_0.DrawArc(base.LinePen, new Point(point.X - num5, point.Y), new Point(point.X + num5, point.Y), num5, 180.0);
				int num6 = 4;
				num2 = num6;
				break;
			}
			case 4:
				num3++;
				goto case 1;
			case 2:
				if (num > 0.0)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	public override void CopyTemplate(ObjectBase P_0, bool P_1)
	{
		if (P_0 is CXEdsXiacbOVON8ZEe0J cXEdsXiacbOVON8ZEe0J)
		{
			WY3iag07XBF = cXEdsXiacbOVON8ZEe0J.WY3iag07XBF;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		base.CopyTemplate(P_0, P_1);
	}

	public static ObjectBase pYpiaE6qN6m(IChartTheme P_0)
	{
		CXEdsXiacbOVON8ZEe0J cXEdsXiacbOVON8ZEe0J = new CXEdsXiacbOVON8ZEe0J();
		cXEdsXiacbOVON8ZEe0J.ApplyTheme(P_0);
		return cXEdsXiacbOVON8ZEe0J;
	}

	static CXEdsXiacbOVON8ZEe0J()
	{
		dL1SNJefNK6ghilPVRTo();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool j6FXO9ef49JAYKcXiqfn()
	{
		return HZkSVweflfZRfyRW6kxV == null;
	}

	internal static CXEdsXiacbOVON8ZEe0J cYjb4VefDhdChNdWLtqb()
	{
		return HZkSVweflfZRfyRW6kxV;
	}

	internal static void ciBZkbefbuoTiPYEGDRP(object P_0, object P_1, Point P_2, Point P_3, double P_4, double P_5)
	{
		((DxVisualQueue)P_0).DrawArc((XPen)P_1, P_2, P_3, P_4, P_5);
	}

	internal static void dL1SNJefNK6ghilPVRTo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
