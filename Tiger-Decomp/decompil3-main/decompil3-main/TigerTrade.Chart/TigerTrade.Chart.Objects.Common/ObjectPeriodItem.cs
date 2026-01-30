using System;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Objects.Common;

[DataContract(Name = "ObjectPeriodItem", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class ObjectPeriodItem
{
	private static ObjectPeriodItem MwuobBeGhO9FJSO73obE;

	[DataMember(Name = "Min")]
	public int Min { get; set; }

	[DataMember(Name = "Max")]
	public int Max { get; set; }

	[DataMember(Name = "CheckRange")]
	public bool CheckRange { get; set; }

	public bool CheckInterval(int interval)
	{
		if (CheckRange)
		{
			if (interval < Min)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => false, 
				};
			}
			return interval <= Max;
		}
		return true;
	}

	private bool Equals(ObjectPeriodItem other)
	{
		if (Min == lGiwIMeG8mIWn1oNaabD(other) && Max == KQyN5AeGA1p9UqDNptXO(other))
		{
			return CheckRange == other.CheckRange;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this != obj)
		{
			if (r29tD1eGJVd8W8L9gTvk(obj.GetType(), UIYvPBeGPAO9ahpigA7a(this)))
			{
				return Equals((ObjectPeriodItem)obj);
			}
			return false;
		}
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => true, 
		};
	}

	public ObjectPeriodItem()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static ObjectPeriodItem()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool QZRJdZeGwhymZWIsG3rt()
	{
		return MwuobBeGhO9FJSO73obE == null;
	}

	internal static ObjectPeriodItem M9hZSOeG78ZIuSpNyvRN()
	{
		return MwuobBeGhO9FJSO73obE;
	}

	internal static int lGiwIMeG8mIWn1oNaabD(object P_0)
	{
		return ((ObjectPeriodItem)P_0).Min;
	}

	internal static int KQyN5AeGA1p9UqDNptXO(object P_0)
	{
		return ((ObjectPeriodItem)P_0).Max;
	}

	internal static Type UIYvPBeGPAO9ahpigA7a(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool r29tD1eGJVd8W8L9gTvk(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
