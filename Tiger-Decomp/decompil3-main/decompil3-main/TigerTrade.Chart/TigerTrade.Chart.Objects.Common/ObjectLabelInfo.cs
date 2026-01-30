using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.Common;

public sealed class ObjectLabelInfo
{
	internal static ObjectLabelInfo AdJSCGeGq9vvPRI9M5If;

	public double Value { get; }

	public XColor Color { get; }

	public double? Position { get; }

	public bool Extanded { get; }

	public double Y1 { get; }

	public double Y2 { get; }

	public ObjectLabelInfo(double value, XColor color, double? position = null)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Value = value;
		Color = color;
		Position = position;
	}

	public ObjectLabelInfo(double value, double y1, double y2, XColor color)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Y1 = y1;
				Y2 = y2;
				num = 2;
				break;
			case 1:
				Extanded = true;
				Value = value;
				Color = color;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	static ObjectLabelInfo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Qvh1EFeGILKbumiEIqMX()
	{
		return AdJSCGeGq9vvPRI9M5If == null;
	}

	internal static ObjectLabelInfo EdTukBeGWRkIOhVwAT5x()
	{
		return AdJSCGeGq9vvPRI9M5If;
	}
}
