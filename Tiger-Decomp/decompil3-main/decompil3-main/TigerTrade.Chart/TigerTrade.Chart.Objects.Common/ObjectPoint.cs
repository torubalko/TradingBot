using System;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Objects.Common;

[DataContract(Name = "ObjectPoint", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public struct ObjectPoint
{
	private static object fWvy8ReYHlTyVTpY7XZR;

	[DataMember(Name = "X")]
	public double X { get; set; }

	[DataMember(Name = "Y")]
	public double Y { get; set; }

	public static ObjectPoint Empty
	{
		get
		{
			ObjectPoint result = new ObjectPoint
			{
				X = double.NaN
			};
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				result.Y = double.NaN;
				return result;
			}
		}
	}

	public ObjectPoint(double x, double y)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		X = x;
		Y = y;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDC9DF), DateTime.FromOADate(X).ToShortDateString(), DateTime.FromOADate(X), Y);
	}

	static ObjectPoint()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ASLcTceYn3VCsfZlBx7R();
	}

	internal static bool bcs6hSeYfBuOfuSkNKGS()
	{
		return fWvy8ReYHlTyVTpY7XZR == null;
	}

	internal static object vhZ0u1eY9vR9osu4GQyY()
	{
		return fWvy8ReYHlTyVTpY7XZR;
	}

	internal static void ASLcTceYn3VCsfZlBx7R()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
