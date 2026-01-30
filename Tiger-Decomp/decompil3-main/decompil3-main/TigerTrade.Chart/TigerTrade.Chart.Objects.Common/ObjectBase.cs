using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Annotations;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Core.UI.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.Common;

[DataContract(Name = "ObjectBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public abstract class ObjectBase : INotifyPropertyChanged, IDynamicProperty, ICloneable
{
	[CompilerGenerated]
	private sealed class F4xGLKirB8HSKjGYePnF
	{
		public double bOgirirNReS;

		private static F4xGLKirB8HSKjGYePnF PjMed6etrueJ4iJATPHa;

		public F4xGLKirB8HSKjGYePnF()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		internal bool x18iraekVYH(ObjectPoint p)
		{
			return p.X < bOgirirNReS;
		}

		static F4xGLKirB8HSKjGYePnF()
		{
			YKDGVSethbLZyyehFt98();
			KmqxB1etw6OeFpQ4Sspb();
		}

		internal static bool RPG2EhetKm3KDZ8m7msH()
		{
			return PjMed6etrueJ4iJATPHa == null;
		}

		internal static F4xGLKirB8HSKjGYePnF HanBoLetmW9yd5ZUXgtD()
		{
			return PjMed6etrueJ4iJATPHa;
		}

		internal static void YKDGVSethbLZyyehFt98()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}

		internal static void KmqxB1etw6OeFpQ4Sspb()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private ChartObjectAttribute _attribute;

	private string _id;

	private string _name;

	private int _controlPointNum;

	private ObjectPoint[] _controlPoints;

	private ObjectPoint[] _extraPoints;

	[Browsable(false)]
	public bool InMove;

	[Browsable(false)]
	public bool InSetup;

	private ObjectPeriods _periods;

	private ObjectPosition _position;

	private bool _lock;

	private List<ChartAlertInfo> _alerts;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ObjectBase lDWbSqeG9NRpiLoghMFy;

	[Browsable(false)]
	public string ID
	{
		get
		{
			if (!string.IsNullOrEmpty(_id))
			{
				return _id;
			}
			ChartObjectAttribute attribute = GetAttribute();
			_id = ((attribute != null) ? attribute.ID : yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671172039));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => _id, 
			};
		}
	}

	[Browsable(false)]
	public string Name
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					if (!string.IsNullOrEmpty(_name))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
						{
							num2 = 0;
						}
						break;
					}
					ChartObjectAttribute attribute = GetAttribute();
					_name = (string)((attribute != null) ? NYBEQ2eGBKKYQY9y8Ipk(attribute) : ARmu4jeGvEZjwjapqy53(-1774602229 ^ -1774633425));
					return _name;
				}
				default:
					return _name;
				}
			}
		}
	}

	[Browsable(false)]
	public string Title => ToString();

	[Browsable(false)]
	public int ControlPointNum
	{
		get
		{
			if (_controlPointNum > 0)
			{
				return _controlPointNum;
			}
			ChartObjectAttribute attribute = GetAttribute();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				_controlPointNum = attribute?.Points ?? 0;
				return _controlPointNum;
			}
		}
	}

	[Browsable(false)]
	public virtual ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	[DataMember(Name = "SymbolID")]
	public string SymbolID { get; set; }

	[Browsable(false)]
	[DataMember(Name = "ObjectID")]
	public string ObjectID { get; set; }

	[Browsable(false)]
	[DataMember(Name = "ControlPoints")]
	public ObjectPoint[] ControlPoints
	{
		get
		{
			return _controlPoints ?? (_controlPoints = new ObjectPoint[ControlPointNum]);
		}
		set
		{
			_controlPoints = value;
		}
	}

	[Browsable(false)]
	public virtual ObjectPoint[] ExtraPoints => _extraPoints ?? (_extraPoints = new ObjectPoint[0]);

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsVisibility")]
	[DataMember(Name = "Periods")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsObject")]
	public ObjectPeriods Periods
	{
		get
		{
			return _periods ?? (_periods = new ObjectPeriods());
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
					if (!object.Equals(value, _periods))
					{
						_periods = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338800894));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Position")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsObject")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPosition")]
	public ObjectPosition Position
	{
		get
		{
			return _position;
		}
		set
		{
			if (value != _position)
			{
				_position = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x735715F1 ^ 0x735793B7));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsControlPoints")]
	[ReadOnly(true)]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsObject")]
	public ObjectPointInfo[] ControlPointsList => ControlPoints.Select((ObjectPoint t, int i) => new ObjectPointInfo(ControlPoints, i)).ToArray();

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLock")]
	[DataMember(Name = "Lock")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsObject")]
	public bool Lock
	{
		get
		{
			return _lock;
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
					if (value != _lock)
					{
						_lock = value;
						OnPropertyChanged((string)ARmu4jeGvEZjwjapqy53(0x1D7BA1ED ^ 0x1D7B27B7));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual int PenWidth => 0;

	protected IChartDataProvider DataProvider { get; private set; }

	protected IChartSettings Settings { get; private set; }

	protected IChartCanvas Canvas { get; private set; }

	protected IChartTheme Theme { get; private set; }

	[Browsable(false)]
	public virtual bool SnapGrid => true;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
						{
							num = 0;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)myx49LeGslhYE19mUqpD(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	private ChartObjectAttribute GetAttribute()
	{
		return _attribute ?? (_attribute = (ChartObjectAttribute)u7nBrqeGotKoSlcAZLYc(f7ENGDeGYynMdgR5PtBb(this), Type.GetTypeFromHandle(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554558))));
	}

	protected ObjectBase()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Position = ObjectPosition.Front;
		Lock = false;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void SetDataProvider(IChartDataProvider dp)
	{
		DataProvider = dp;
	}

	public void SetSettings(IChartSettings settings)
	{
		Settings = settings;
	}

	public void SetCanvas(IChartCanvas canvas)
	{
		Canvas = canvas;
		Theme = (IChartTheme)((canvas != null) ? WO6ymfeGarwjpFu3KmYh(canvas) : null);
	}

	public virtual void ControlPointEditing(int index)
	{
	}

	public virtual void DragObject(double dx, double dy)
	{
	}

	public virtual void BeginDrag()
	{
	}

	protected virtual void Prepare()
	{
	}

	protected abstract void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels);

	public void DrawObject(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		if (Canvas == null)
		{
			return;
		}
		Y1ZlLAeGimaO67WP7MOu(this);
		if (!IsObjectOnChart())
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			}
		}
		if (IsObjectInArea())
		{
			Draw(visual, ref labels);
		}
	}

	public virtual void DrawControlPoints(DxVisualQueue visual)
	{
		if (Canvas == null)
		{
			return;
		}
		Point[] array = ToPoints(ControlPoints);
		int num = 0;
		int num2 = 4;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
			{
				Point point2 = array[num];
				DrawControlPoint(visual, point2);
				num++;
				goto case 5;
			}
			case 2:
				if (ExtraPoints.Length == 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					array = ToPoints((ObjectPoint[])VybrKQeGlU0fK3bipF6L(this));
					num = 0;
					num2 = 5;
				}
				break;
			case 3:
				num++;
				goto case 4;
			case 4:
			{
				if (num >= array.Length)
				{
					num2 = 2;
					break;
				}
				Point point = array[num];
				DrawControlPoint(visual, point);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				return;
			case 5:
				if (num >= array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 0:
				return;
			}
		}
	}

	protected void DrawControlPoint(DxVisualQueue visual, Point point)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Rect rect = new Rect(point.X - num3 / 2.0, point.Y - num3 / 2.0, num3, num3);
				visual.FillRectangle((XBrush)tVpXK9eG4a9QSGJTPbug(Theme), rect);
				visual.DrawRectangle((XPen)IgAA8XeGD3wEHTfBSfQh(Theme), rect);
				return;
			}
			case 1:
				num3 = (double)PenWidth / 2.0 + 7.0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void ControlPointsChanged()
	{
	}

	public virtual void ExtraPointChanged(int index, ObjectPoint op)
	{
	}

	public virtual int GetControlPoint(int x, int y)
	{
		if (Canvas == null)
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			int num4;
			if (num < ControlPoints.Length)
			{
				double num2 = ToPoint(ControlPoints[num]).X - (double)x;
				double num3 = ToPoint(ControlPoints[num]).Y - (double)y;
				if (num2 * num2 + num3 * num3 < 9.0 + (double)PenWidth / 2.0)
				{
					num4 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num4 = 0;
					}
				}
				else
				{
					num++;
					num4 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
					{
						num4 = 1;
					}
				}
			}
			else
			{
				num4 = 2;
			}
			switch (num4)
			{
			case 2:
				return -1;
			case 1:
				break;
			default:
				return num;
			}
		}
	}

	public virtual int GetExtraPoint(int x, int y)
	{
		if (Canvas != null && ExtraPoints.Length != 0)
		{
			int num = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
			{
				num = 1;
			}
			Point point = default(Point);
			int num4 = default(int);
			while (true)
			{
				switch (num)
				{
				case 2:
					point = ToPoint(ExtraPoints[num4]);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
					{
						num = 1;
					}
					break;
				case 3:
					num4 = 0;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
					{
						num = 0;
					}
					break;
				default:
					if (num4 >= ExtraPoints.Length)
					{
						return -1;
					}
					goto case 2;
				case 1:
				{
					double num2 = point.X - (double)x;
					double num3 = ToPoint(ExtraPoints[num4]).Y - (double)y;
					if (num2 * num2 + num3 * num3 < 9.0 + (double)PenWidth / 2.0)
					{
						return num4;
					}
					num4++;
					goto default;
				}
				}
			}
		}
		return -1;
	}

	protected virtual bool IsObjectOnChart()
	{
		int num = 1;
		int num2 = num;
		F4xGLKirB8HSKjGYePnF f4xGLKirB8HSKjGYePnF = default(F4xGLKirB8HSKjGYePnF);
		while (true)
		{
			switch (num2)
			{
			default:
				if (DataProvider == null || DataProvider.Dates.Count == 0)
				{
					return false;
				}
				f4xGLKirB8HSKjGYePnF.bOgirirNReS = DataProvider.Dates[0];
				return !ControlPoints.All(f4xGLKirB8HSKjGYePnF.x18iraekVYH);
			case 1:
				f4xGLKirB8HSKjGYePnF = new F4xGLKirB8HSKjGYePnF();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual bool IsObjectInArea()
	{
		return true;
	}

	protected virtual bool InObject(int x, int y)
	{
		return false;
	}

	protected virtual int GetMinDist(int x, int y)
	{
		return 0;
	}

	public int GetMinDistance(int x, int y)
	{
		if (Canvas == null || !d7STTOeGbqPAgUYXR672(this) || !IsObjectInArea() || !InObject(x, y))
		{
			return -1;
		}
		return tErS2NeGN0D323ypBVXA(this, x, y);
	}

	protected double GetX(int i)
	{
		return M8HZVIeGk77djyedu3bY(Canvas, i);
	}

	protected double GetY(double d)
	{
		return Canvas.GetY(d);
	}

	public Point ToPoint(ObjectPoint op)
	{
		if (!I8kBKeeG1wE7n2gjg1QR(this))
		{
			return new Point(xr5F7JeG54xDJW3hcGJV(Canvas, op.X), Canvas.GetY(op.Y));
		}
		if (DataProvider.Count > 0)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				if (Canvas != null)
				{
					return new Point(GetX(Canvas.DateToIndex(op.X, -1)), GetY(op.Y));
				}
				break;
			}
		}
		return default(Point);
	}

	protected Point[] ToPoints(ObjectPoint[] ops)
	{
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		Point[] array = default(Point[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = 0;
				break;
			case 2:
				array = new Point[ops.Length];
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			if (num3 >= array.Length)
			{
				break;
			}
			array[num3] = ToPoint(ops[num3]);
			num3++;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
			{
				num2 = 0;
			}
		}
		return array;
	}

	public virtual void ApplyTheme(IChartTheme theme)
	{
	}

	public virtual void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Position = TiUODQeGS0mfxeFw5ACZ(objectBase);
				Lock = lAD4nKeGxMR85mKAmEh6(objectBase);
				return;
			case 1:
				Periods = objectBase.Periods.Copy();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void CheckAlert(List<IndicatorBase> indicators)
	{
	}

	protected void AddAlert(ChartAlertSettings settings, string message)
	{
		if (cx2RxYeGLU9tRSHHowTh(settings) == ChartAlertExecution.OnlyOnce)
		{
			etOvmGeGetbiVmnwJ8l3(settings, false);
		}
		int num;
		if (_alerts == null)
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_001b:
		_alerts.Add(new ChartAlertInfo(settings, message));
		num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		_alerts = new List<ChartAlertInfo>();
		goto IL_001b;
	}

	public List<ChartAlertInfo> GetAlerts()
	{
		if (_alerts == null)
		{
			_alerts = new List<ChartAlertInfo>();
		}
		List<ChartAlertInfo> result = _alerts.ToList();
		_alerts.Clear();
		return result;
	}

	public virtual bool GetPropertyVisibility(string propertyName)
	{
		return true;
	}

	public virtual bool GetPropertyHasStandardValues(string propertyName)
	{
		return false;
	}

	public virtual bool GetPropertyReadOnly(string propertyName)
	{
		return false;
	}

	public virtual IEnumerable<object> GetPropertyStandardValues(string propertyName)
	{
		return null;
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[OnDeserializing]
	protected void SetValuesOnDeserializing(StreamingContext context)
	{
		CopyTemplate((ObjectBase)Activator.CreateInstance(f7ENGDeGYynMdgR5PtBb(this)), style: false);
	}

	public override string ToString()
	{
		return Name;
	}

	public virtual object Clone()
	{
		return yhP2MaeGXi8cAjq0aAJV(this);
	}

	static ObjectBase()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static Type f7ENGDeGYynMdgR5PtBb(object P_0)
	{
		return P_0.GetType();
	}

	internal static object u7nBrqeGotKoSlcAZLYc(object P_0, Type P_1)
	{
		return Attribute.GetCustomAttribute((MemberInfo)P_0, P_1);
	}

	internal static bool hdt9X6eGn7LS7jtriXBX()
	{
		return lDWbSqeG9NRpiLoghMFy == null;
	}

	internal static ObjectBase mo3ej4eGG8A4JG40kwDL()
	{
		return lDWbSqeG9NRpiLoghMFy;
	}

	internal static object ARmu4jeGvEZjwjapqy53(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object NYBEQ2eGBKKYQY9y8Ipk(object P_0)
	{
		return ((ChartObjectAttribute)P_0).Name;
	}

	internal static object WO6ymfeGarwjpFu3KmYh(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static void Y1ZlLAeGimaO67WP7MOu(object P_0)
	{
		((ObjectBase)P_0).Prepare();
	}

	internal static object VybrKQeGlU0fK3bipF6L(object P_0)
	{
		return ((ObjectBase)P_0).ExtraPoints;
	}

	internal static object tVpXK9eG4a9QSGJTPbug(object P_0)
	{
		return ((IChartTheme)P_0).ChartCpFillBrush;
	}

	internal static object IgAA8XeGD3wEHTfBSfQh(object P_0)
	{
		return ((IChartTheme)P_0).ChartCpLinePen;
	}

	internal static bool d7STTOeGbqPAgUYXR672(object P_0)
	{
		return ((ObjectBase)P_0).IsObjectOnChart();
	}

	internal static int tErS2NeGN0D323ypBVXA(object P_0, int x, int y)
	{
		return ((ObjectBase)P_0).GetMinDist(x, y);
	}

	internal static double M8HZVIeGk77djyedu3bY(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static bool I8kBKeeG1wE7n2gjg1QR(object P_0)
	{
		return ((ObjectBase)P_0).SnapGrid;
	}

	internal static double xr5F7JeG54xDJW3hcGJV(object P_0, double x)
	{
		return ((IChartCanvas)P_0).GetXScreen(x);
	}

	internal static ObjectPosition TiUODQeGS0mfxeFw5ACZ(object P_0)
	{
		return ((ObjectBase)P_0).Position;
	}

	internal static bool lAD4nKeGxMR85mKAmEh6(object P_0)
	{
		return ((ObjectBase)P_0).Lock;
	}

	internal static ChartAlertExecution cx2RxYeGLU9tRSHHowTh(object P_0)
	{
		return ((ChartAlertSettings)P_0).Execution;
	}

	internal static void etOvmGeGetbiVmnwJ8l3(object P_0, bool value)
	{
		((ChartAlertSettings)P_0).Active = value;
	}

	internal static object myx49LeGslhYE19mUqpD(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object yhP2MaeGXi8cAjq0aAJV(object P_0)
	{
		return P_0.MemberwiseClone();
	}
}
