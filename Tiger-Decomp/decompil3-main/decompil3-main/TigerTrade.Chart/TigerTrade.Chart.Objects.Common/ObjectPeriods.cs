using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Base;

namespace TigerTrade.Chart.Objects.Common;

[DataContract(Name = "ObjectPeriods", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class ObjectPeriods
{
	private Dictionary<string, ObjectPeriodItem> _periods;

	internal static ObjectPeriods ceBUuFeGFUPyJAlqdKUc;

	[DataMember(Name = "Periods")]
	public Dictionary<string, ObjectPeriodItem> Periods
	{
		get
		{
			return _periods ?? (_periods = new Dictionary<string, ObjectPeriodItem>());
		}
		set
		{
			_periods = value;
		}
	}

	public bool CheckPeriod(IChartPeriod dc)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 1:
				if (Periods.Count != 0)
				{
					string key = dc.Type.ToString();
					if (!Periods.ContainsKey(key))
					{
						return false;
					}
					return Periods[key].CheckInterval(dc.Interval);
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Update(string type, bool isChecked, bool checkRange, int min, int max)
	{
		int num;
		if (!isChecked && Periods.ContainsKey(type))
		{
			num = 2;
		}
		else
		{
			if (!isChecked)
			{
				goto IL_0047;
			}
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num = 1;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Periods.Remove(type);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
				{
					num = 0;
				}
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		if (!Periods.ContainsKey(type))
		{
			Dictionary<string, ObjectPeriodItem> periods = Periods;
			ObjectPeriodItem obj = new ObjectPeriodItem
			{
				CheckRange = checkRange
			};
			ljQK0EeGuAHtwLT3Qet4(obj, min);
			obj.Max = max;
			periods.Add(type, obj);
			return;
		}
		goto IL_0047;
		IL_0047:
		if (Periods.ContainsKey(type))
		{
			ObjectPeriodItem objectPeriodItem = Periods[type];
			jVHFVieGzfh0hqOPXs4f(objectPeriodItem, checkRange);
			objectPeriodItem.Min = min;
			objectPeriodItem.Max = max;
		}
	}

	public ObjectPeriods Copy()
	{
		int num = 1;
		int num2 = num;
		ObjectPeriods objectPeriods = default(ObjectPeriods);
		while (true)
		{
			switch (num2)
			{
			case 1:
				objectPeriods = new ObjectPeriods();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			foreach (KeyValuePair<string, ObjectPeriodItem> period in Periods)
			{
				Dictionary<string, ObjectPeriodItem> periods = objectPeriods.Periods;
				string key = period.Key;
				ObjectPeriodItem objectPeriodItem = new ObjectPeriodItem();
				jVHFVieGzfh0hqOPXs4f(objectPeriodItem, period.Value.CheckRange);
				objectPeriodItem.Min = QM7xdgeY0BFaTWZMtype(period.Value);
				objectPeriodItem.Max = period.Value.Max;
				periods.Add(key, objectPeriodItem);
			}
			return objectPeriods;
		}
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!(obj is ObjectPeriods))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				ObjectPeriods objectPeriods = (ObjectPeriods)obj;
				if (Periods != objectPeriods.Periods)
				{
					if (Periods.Count == objectPeriods.Periods.Count)
					{
						return !Periods.Except(objectPeriods.Periods).Any();
					}
					return false;
				}
				return true;
			}
			default:
				return false;
			}
		}
	}

	public ObjectPeriods()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static ObjectPeriods()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		CDTPTyeY2ef3R1JLAhBn();
	}

	internal static bool ubqaCyeG3aon2TciaCVh()
	{
		return ceBUuFeGFUPyJAlqdKUc == null;
	}

	internal static ObjectPeriods A2HLBheGpvWuV6W6QHMN()
	{
		return ceBUuFeGFUPyJAlqdKUc;
	}

	internal static void ljQK0EeGuAHtwLT3Qet4(object P_0, int value)
	{
		((ObjectPeriodItem)P_0).Min = value;
	}

	internal static void jVHFVieGzfh0hqOPXs4f(object P_0, bool value)
	{
		((ObjectPeriodItem)P_0).CheckRange = value;
	}

	internal static int QM7xdgeY0BFaTWZMtype(object P_0)
	{
		return ((ObjectPeriodItem)P_0).Min;
	}

	internal static void CDTPTyeY2ef3R1JLAhBn()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
