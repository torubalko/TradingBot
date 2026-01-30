using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using MjpeuniVvbkhs4Cg0PHI;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Properties;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "LineObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Line", "ChartObjectsTrendLine", 2, Type = typeof(LineObject))]
public sealed class LineObject : LineObjectBase
{
	private ChartAlertSettings _alert;

	private int _alertMinDistance;

	private bool _openStart;

	private bool _openEnd;

	private static DateTime _lastErrorTime;

	private double _lastAlertValue;

	private int _lastAlertIndex;

	private static LineObject LROTB4efna3tYs7UwXt0;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	[DataMember(Name = "Alert")]
	[Browsable(true)]
	public ChartAlertSettings Alert
	{
		get
		{
			return _alert ?? (_alert = new ChartAlertSettings());
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
					_alert = value;
					OnPropertyChanged((string)dXmGHBefvrg576Tbe25h(-962524685 ^ -962497419));
					return;
				case 1:
					if (lnK8fjefo2snCCors3ji(value, _alert))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSignalMinDistance")]
	[DataMember(Name = "AlertMinDistance")]
	public int AlertMinDistance
	{
		get
		{
			return _alertMinDistance;
		}
		set
		{
			if (value != _alertMinDistance)
			{
				_alertMinDistance = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)dXmGHBefvrg576Tbe25h(-1763895751 ^ -1763873875));
			}
		}
	}

	[DataMember(Name = "OpenStart")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandStart")]
	public bool OpenStart
	{
		get
		{
			return _openStart;
		}
		set
		{
			if (value != _openStart)
			{
				_openStart = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165448569));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineExpandEnd")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "OpenEnd")]
	public bool OpenEnd
	{
		get
		{
			return _openEnd;
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
					if (value == _openEnd)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_openEnd = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769C02E5));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "RefPoint")]
	public ObjectPoint? RefPoint { get; set; }

	public LineObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		AlertMinDistance = 3;
		OpenStart = false;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			OpenEnd = false;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 1;
		int num2 = num;
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			default:
				if (array.Length != 2 || kwTpydiVo3I5Kh12vqxo.QrGiVB71CFw(array[0], array[1], base.Canvas.Rect))
				{
					visual.DrawLines(base.LinePen, array);
				}
				return;
			case 1:
				array = ToPoints();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Point[] ToPoints()
	{
		Point[] array = ToPoints(base.ControlPoints);
		if (array.Length < 2)
		{
			return array;
		}
		Point point = array[0];
		Point point2 = array[1];
		int num;
		if (OpenStart)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0069;
		IL_0045:
		return array;
		IL_0009:
		Point point3 = default(Point);
		while (true)
		{
			switch (num)
			{
			case 3:
				goto IL_0069;
			case 1:
				XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, point2, point, out point3);
				num = 2;
				continue;
			case 2:
				array[0] = point3;
				num = 3;
				continue;
			}
			break;
		}
		goto IL_0045;
		IL_0069:
		if (OpenEnd)
		{
			XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, point, point2, out var point4);
			array[1] = point4;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0045;
	}

	protected override bool InObject(int x, int y)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				goto IL_003e;
			case 1:
				array = ToPoints();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num3++;
				goto IL_003e;
			case 3:
				{
					return false;
				}
				IL_003e:
				if (num3 >= array.Length - 1)
				{
					num2 = 3;
					break;
				}
				if (!FUcnXaefBQNo7jHSUJ5p(x, y, array[num3], array[num3 + 1], base.LineWidth + 2))
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
					{
						num2 = 2;
					}
					break;
				}
				return true;
			}
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num;
		if (objectBase is LineObject lineObject)
		{
			if (!N2Ofteefah1Z6cJNbeTW(Alert, lineObject.Alert))
			{
				Alert.Copy(lineObject.Alert, !style);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			goto IL_0023;
		}
		goto IL_0098;
		IL_0023:
		AlertMinDistance = lineObject.AlertMinDistance;
		OpenStart = lineObject.OpenStart;
		num = 3;
		goto IL_0009;
		IL_0098:
		base.CopyTemplate(objectBase, style);
		return;
		IL_0083:
		RefPoint = null;
		goto IL_0098;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710481434));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num = 0;
				}
				continue;
			case 2:
				goto IL_0083;
			case 3:
				OpenEnd = lineObject.OpenEnd;
				num = 2;
				continue;
			}
			break;
		}
		goto IL_0023;
	}

	protected override bool IsObjectOnChart()
	{
		if (OpenEnd)
		{
			return true;
		}
		return base.IsObjectOnChart();
	}

	public override void CheckAlert(List<IndicatorBase> indicators)
	{
		if (!Alert.IsActive || base.Canvas == null)
		{
			return;
		}
		try
		{
			IChartDataProvider dataProvider = base.DataProvider;
			Point[] array = ToPoints(base.ControlPoints);
			Point point = array[0];
			Point point2 = array[1];
			double x = GetX(dataProvider.Count - 1);
			if (point.X < point2.X)
			{
				if ((!OpenEnd && x > point2.X) || (!OpenStart && x < point.X))
				{
					return;
				}
			}
			else if ((!OpenStart && x > point2.X) || (!OpenEnd && x < point.X))
			{
				return;
			}
			double y = (x - point.X) * (point2.Y - point.Y) / (point2.X - point.X) + point.Y;
			double value = base.Canvas.GetValue(y);
			foreach (IndicatorBase indicator in indicators)
			{
				if (indicator.CheckAlert(value, AlertMinDistance, ref _lastAlertIndex, ref _lastAlertValue))
				{
					string message = string.Format(Resources.ChartObjectsTrendLineObjectAlert, indicator.Name, dataProvider.Symbol.FormatPrice((decimal)value));
					AddAlert(Alert, message);
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	static LineObject()
	{
		OawutEefi267gRaQUbLm();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		_lastErrorTime = DateTime.MinValue;
	}

	internal static bool nTqLnQefGkjFYXOiHaih()
	{
		return LROTB4efna3tYs7UwXt0 == null;
	}

	internal static LineObject WT2mdPefYltMq5QXxrPd()
	{
		return LROTB4efna3tYs7UwXt0;
	}

	internal static bool lnK8fjefo2snCCors3ji(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object dXmGHBefvrg576Tbe25h(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool FUcnXaefBQNo7jHSUJ5p(int P_0, int P_1, Point P_2, Point P_3, int P_4)
	{
		return XyaVo8ilJa9AfK2KZEye.yd5ilujJMuv(P_0, P_1, P_2, P_3, P_4);
	}

	internal static bool N2Ofteefah1Z6cJNbeTW(object P_0, object P_1)
	{
		return ((ChartAlertSettings)P_0).Equals((ChartAlertSettings)P_1);
	}

	internal static void OawutEefi267gRaQUbLm()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
