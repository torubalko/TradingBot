using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.Abstract;

[DataContract(Name = "LineObjectBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class LineObjectBase : ObjectBase
{
	private XColor _lineColor;

	private int _lineWidth;

	private XDashStyle _lineStyle;

	private static LineObjectBase plOhRbeYLsDoex6LXDaW;

	[Browsable(false)]
	protected XBrush LineBrush { get; private set; }

	[Browsable(false)]
	public XPen LinePen { get; private set; }

	[DataMember(Name = "LineColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	public XColor LineColor
	{
		get
		{
			return _lineColor;
		}
		set
		{
			if (fljQwZeYX1ONlugDNQBq(value, _lineColor))
			{
				return;
			}
			_lineColor = value;
			LineBrush = new XBrush(_lineColor);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xAD5B8B3 ^ 0xAD53E3B));
					return;
				case 1:
					LinePen = new XPen(LineBrush, LineWidth, LineStyle);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "LineWidth")]
	public int LineWidth
	{
		get
		{
			return _lineWidth;
		}
		set
		{
			value = sQ3ITFeYjP2Xnc368lXf(1, c4cW2EeYcGIs0vPtiyfF(10, value));
			if (value == _lineWidth)
			{
				return;
			}
			_lineWidth = value;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x739454EC));
					return;
				}
				VqCDgaeYEEckLhiuvqFU(this, _lineWidth, LineStyle);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "LineStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineStyle")]
	public XDashStyle LineStyle
	{
		get
		{
			return _lineStyle;
		}
		set
		{
			if (value != _lineStyle)
			{
				_lineStyle = value;
				UpdateLinePens(LineWidth, _lineStyle);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAB99C));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
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

	protected override int PenWidth => LineWidth;

	protected virtual void UpdateLinePens(int lineWidth, XDashStyle lineStyle)
	{
		LinePen = new XPen(LineBrush, lineWidth, lineStyle);
	}

	protected LineObjectBase()
	{
		q6rVooeYQqWie0uIIJsa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LineWidth = 1;
				LineStyle = XDashStyle.Solid;
				return;
			}
			LineColor = Colors.Black;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
			{
				num = 1;
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		LineColor = theme.ChartObjectLineColor;
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		if (objectBase is LineObjectBase lineObjectBase)
		{
			LineColor = lineObjectBase.LineColor;
			LineWidth = J9EOAieYd2rRyFsgVLsE(lineObjectBase);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					LineStyle = lineObjectBase.LineStyle;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		base.CopyTemplate(objectBase, style);
	}

	static LineObjectBase()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool d8I0jIeYepPPrHUxjkWR()
	{
		return plOhRbeYLsDoex6LXDaW == null;
	}

	internal static LineObjectBase Xad03qeYsv5HxYd7ib7B()
	{
		return plOhRbeYLsDoex6LXDaW;
	}

	internal static bool fljQwZeYX1ONlugDNQBq(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static int c4cW2EeYcGIs0vPtiyfF(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int sQ3ITFeYjP2Xnc368lXf(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void VqCDgaeYEEckLhiuvqFU(object P_0, int lineWidth, XDashStyle lineStyle)
	{
		((LineObjectBase)P_0).UpdateLinePens(lineWidth, lineStyle);
	}

	internal static void q6rVooeYQqWie0uIIJsa()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static int J9EOAieYd2rRyFsgVLsE(object P_0)
	{
		return ((LineObjectBase)P_0).LineWidth;
	}
}
