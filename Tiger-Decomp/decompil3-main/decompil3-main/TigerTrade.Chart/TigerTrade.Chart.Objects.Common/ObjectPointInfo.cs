using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using TigerTrade.Chart.Annotations;

namespace TigerTrade.Chart.Objects.Common;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ReadOnly(true)]
public sealed class ObjectPointInfo : INotifyPropertyChanged
{
	private readonly ObjectPoint[] _points;

	private readonly int _index;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static ObjectPointInfo dnWJ2geYGAi9pFxtEku9;

	[NotifyParentProperty(true)]
	[ye30Hki4oR4RQBdkwwe7("ObjectPointTime")]
	public DateTime Time
	{
		get
		{
			return DateTime.FromOADate(_points[_index].X);
		}
		set
		{
			double num = value.ToOADate();
			if (_points[_index].X != num)
			{
				_points[_index].X = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108495516));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[NotifyParentProperty(true)]
	[ye30Hki4oR4RQBdkwwe7("ObjectPointPrice")]
	public double Price
	{
		get
		{
			return _points[_index].Y;
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
					if (_points[_index].Y == value)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
						{
							num2 = 0;
						}
						break;
					}
					_points[_index].Y = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736547236));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
					{
						num = 1;
					}
				}
			}
		}
	}

	public ObjectPointInfo(ObjectPoint[] points, int index)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		_points = points;
		_index = index;
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			PlyM88eYvjxoAyssakof(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public override string ToString()
	{
		return _points[_index].ToString();
	}

	static ObjectPointInfo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool TiWm9AeYYbWfd7O0wWo2()
	{
		return dnWJ2geYGAi9pFxtEku9 == null;
	}

	internal static ObjectPointInfo nRcYOqeYovcyp8phDjXt()
	{
		return dnWJ2geYGAi9pFxtEku9;
	}

	internal static void PlyM88eYvjxoAyssakof(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
