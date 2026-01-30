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

[DataContract(Name = "PoligonObjectBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class PolygonObjectBase : ObjectBase
{
	private bool _drawBorder;

	private XColor _lineColor;

	private int _lineWidth;

	private XDashStyle _lineStyle;

	private bool _drawBack;

	private XColor _backColor;

	internal static PolygonObjectBase o2vrhjeYgPPRkufMDiWm;

	[DataMember(Name = "DrawBorder")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBorder")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsBorder")]
	public bool DrawBorder
	{
		get
		{
			return _drawBorder;
		}
		set
		{
			if (value != _drawBorder)
			{
				_drawBorder = value;
				OnPropertyChanged((string)CJCTqweYML4WYD4Wd4xE(-1962651919 ^ -1962620427));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
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

	[Browsable(false)]
	protected XBrush LineBrush { get; private set; }

	[Browsable(false)]
	protected XPen LinePen { get; private set; }

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBorder")]
	[DataMember(Name = "LineColor")]
	public XColor LineColor
	{
		get
		{
			return _lineColor;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161588590));
					return;
				case 2:
					if (!(value == _lineColor))
					{
						_lineColor = value;
						LineBrush = new XBrush(_lineColor);
						LinePen = new XPen(LineBrush, LineWidth, LineStyle);
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
						{
							num2 = 1;
						}
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBorder")]
	[DataMember(Name = "LineWidth")]
	public int LineWidth
	{
		get
		{
			return _lineWidth;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value == _lineWidth)
					{
						return;
					}
					_lineWidth = value;
					LinePen = new XPen(LineBrush, _lineWidth, LineStyle);
					OnPropertyChanged((string)CJCTqweYML4WYD4Wd4xE(0x385FFAB ^ 0x3857935));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					value = Math.Max(1, Math.Min(10, value));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "LineStyle")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBorder")]
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
				LinePen = new XPen(LineBrush, LineWidth, _lineStyle);
				OnPropertyChanged((string)CJCTqweYML4WYD4Wd4xE(-1878953018 ^ -1878919822));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
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

	[DataMember(Name = "DrawBack")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBackground")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsBackground")]
	public bool DrawBack
	{
		get
		{
			return _drawBack;
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
				case 0:
					return;
				case 1:
					if (value != _drawBack)
					{
						_drawBack = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1487846E ^ 0x14870372));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Browsable(false)]
	protected XBrush BackBrush { get; private set; }

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsBackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsBackground")]
	[DataMember(Name = "BackColor")]
	public XColor BackColor
	{
		get
		{
			return _backColor;
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
				case 0:
					return;
				case 1:
					if (!(value == _backColor))
					{
						_backColor = value;
						BackBrush = new XBrush(_backColor);
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1311293279 ^ -1311258735));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override int PenWidth => LineWidth;

	protected PolygonObjectBase()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		DrawBorder = true;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				LineColor = SAiN8neYOEWo24mZwrd5(Colors.Black);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
				{
					num = 0;
				}
				continue;
			}
			LineWidth = 1;
			LineStyle = XDashStyle.Solid;
			DrawBack = true;
			BackColor = SAiN8neYOEWo24mZwrd5(Color.FromArgb(30, 0, 0, 0));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
			{
				num = 0;
			}
		}
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		LineColor = theme.ChartObjectLineColor;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		BackColor = DBYqK6eYqJnt0gptkdHK(theme);
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		PolygonObjectBase polygonObjectBase = objectBase as PolygonObjectBase;
		if (polygonObjectBase == null)
		{
			goto IL_0042;
		}
		goto IL_00b8;
		IL_0042:
		base.CopyTemplate(objectBase, style);
		int num = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_00b8:
		DrawBorder = THUAmaeYIsOLynKMFPSc(polygonObjectBase);
		LineColor = polygonObjectBase.LineColor;
		LineWidth = polygonObjectBase.LineWidth;
		LineStyle = polygonObjectBase.LineStyle;
		DrawBack = polygonObjectBase.DrawBack;
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
				BackColor = polygonObjectBase.BackColor;
				num = 3;
				continue;
			default:
				goto IL_00b8;
			case 2:
				return;
			}
			break;
		}
		goto IL_0042;
	}

	static PolygonObjectBase()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object CJCTqweYML4WYD4Wd4xE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool PvK5EjeYRaxucEBZBcYC()
	{
		return o2vrhjeYgPPRkufMDiWm == null;
	}

	internal static PolygonObjectBase fYOhAHeY6EDxbZAZi65K()
	{
		return o2vrhjeYgPPRkufMDiWm;
	}

	internal static XColor SAiN8neYOEWo24mZwrd5(Color P_0)
	{
		return P_0;
	}

	internal static XColor DBYqK6eYqJnt0gptkdHK(object P_0)
	{
		return ((IChartTheme)P_0).ChartObjectFillColor;
	}

	internal static bool THUAmaeYIsOLynKMFPSc(object P_0)
	{
		return ((PolygonObjectBase)P_0).DrawBorder;
	}
}
