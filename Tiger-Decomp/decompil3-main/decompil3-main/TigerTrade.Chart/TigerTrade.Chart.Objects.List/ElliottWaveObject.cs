using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "ElliottWaveObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class ElliottWaveObject : LineObjectBase
{
	private ElliottWaveDegree _degree;

	private bool _showWave;

	internal static ElliottWaveObject WxrlWuLuznvJogp0shuN;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "Degree")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsDegree")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsWave")]
	public ElliottWaveDegree Degree
	{
		get
		{
			return _degree;
		}
		set
		{
			if (value != _degree)
			{
				_degree = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)Gc45Z5LzHPmqSBD1yEv9(0x1A5F1B9E ^ 0x1A5F617C));
			}
		}
	}

	[DataMember(Name = "ShowWave")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsWave")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowWave")]
	public bool ShowWave
	{
		get
		{
			return _showWave;
		}
		set
		{
			if (value != _showWave)
			{
				_showWave = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1D7BA1ED ^ 0x1D7BDB1F));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
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

	protected ElliottWaveObject()
	{
		mEItwkLzfjnHqfr6ntqg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Degree = ElliottWaveDegree.Intermediate;
		ShowWave = true;
	}

	protected abstract string GetDegreeText(int num);

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		Point[] array = ToPoints();
		int num;
		if (!InSetup)
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_00b4;
		IL_0009:
		double num3 = default(double);
		Size size = default(Size);
		int num2 = default(int);
		bool flag = default(bool);
		string text = default(string);
		double num4 = default(double);
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 -= size.Height * 2.0;
				goto IL_029e;
			case 9:
				num3 += size.Height;
				goto IL_029e;
			case 7:
				break;
			case 1:
				if (ShowWave)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
					{
						num = 7;
					}
					continue;
				}
				goto case 11;
			case 8:
				if (num2 % 2 != 0)
				{
					goto case 2;
				}
				goto case 9;
			case 11:
				if (array.Length < 2)
				{
					return;
				}
				flag = array[0].Y > array[1].Y;
				num = 6;
				continue;
			case 4:
				num3 = array[num2].Y;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num = 0;
				}
				continue;
			default:
				if (!flag)
				{
					if (num2 % 2 == 0)
					{
						num = 3;
						continue;
					}
					num3 += size.Height;
					goto IL_029e;
				}
				num = 8;
				continue;
			case 3:
				num3 -= size.Height * 2.0;
				goto IL_029e;
			case 6:
				num2 = 0;
				goto case 10;
			case 5:
				text = (string)XwAAaRLz9BfDWAIW35kO(this, num2);
				size = base.Canvas.ChartFont.GetSize(text);
				num4 = array[num2].X - size.Width / 2.0;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
				{
					num = 3;
				}
				continue;
			case 10:
				{
					if (num2 >= array.Length)
					{
						return;
					}
					if (InMove)
					{
						goto case 5;
					}
					num = 5;
					continue;
				}
				IL_029e:
				sEilyTLznIVqn4JQIvcg(visual, text, base.Canvas.ChartFont, base.LineBrush, num4, num3, XTextAlignment.Center);
				num2++;
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f != 0)
				{
					num = 2;
				}
				continue;
			}
			break;
		}
		goto IL_00b4;
		IL_00b4:
		visual.DrawLines(base.LinePen, array);
		num = 11;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
		{
			num = 11;
		}
		goto IL_0009;
	}

	private Point[] ToPoints()
	{
		if (!InSetup)
		{
			return ToPoints(base.ControlPoints);
		}
		Point[] array = ToPoints(base.ControlPoints);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
		{
			num = 0;
		}
		List<Point> list = default(List<Point>);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				return (Point[])Hdb3aYLzGrEC6mg1jsGT(list);
			default:
				if (num2 == 0 || array[0] != array[num2])
				{
					break;
				}
				goto case 2;
			case 2:
				num2++;
				goto IL_0052;
			case 1:
				{
					list = new List<Point>();
					num2 = 0;
					goto IL_0052;
				}
				IL_0052:
				if (num2 >= array.Length)
				{
					num = 3;
					continue;
				}
				goto default;
			}
			list.Add(array[num2]);
			num = 2;
		}
	}

	protected override bool InObject(int x, int y)
	{
		int num = 2;
		int num2 = num;
		Point[] array = default(Point[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				array = ToPoints();
				num3 = 0;
				goto IL_008c;
			case 2:
				if (ShowWave)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				{
					if (XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(x, y, array[num3], array[num3 + 1], base.LineWidth + 2))
					{
						return true;
					}
					num3++;
					goto IL_008c;
				}
				IL_008c:
				if (num3 >= array.Length - 1)
				{
					return false;
				}
				goto case 3;
			}
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is ElliottWaveObject elliottWaveObject)
		{
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					Degree = elliottWaveObject.Degree;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			ShowWave = elliottWaveObject.ShowWave;
		}
		base.CopyTemplate(objectBase, style);
	}

	static ElliottWaveObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Gc45Z5LzHPmqSBD1yEv9(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool Wb9Mn5Lz0eKstRSyeQuK()
	{
		return WxrlWuLuznvJogp0shuN == null;
	}

	internal static ElliottWaveObject l5mMluLz23lxbB2Sv2Rd()
	{
		return WxrlWuLuznvJogp0shuN;
	}

	internal static void mEItwkLzfjnHqfr6ntqg()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object XwAAaRLz9BfDWAIW35kO(object P_0, int num)
	{
		return ((ElliottWaveObject)P_0).GetDegreeText(num);
	}

	internal static void sEilyTLznIVqn4JQIvcg(object P_0, object P_1, object P_2, object P_3, double P_4, double P_5, XTextAlignment P_6)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5, P_6);
	}

	internal static object Hdb3aYLzGrEC6mg1jsGT(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}
}
