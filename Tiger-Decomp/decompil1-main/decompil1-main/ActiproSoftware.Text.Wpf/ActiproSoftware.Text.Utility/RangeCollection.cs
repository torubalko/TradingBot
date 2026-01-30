using System;
using System.Collections;
using System.Collections.Generic;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class RangeCollection : IEnumerable<Range>, IEnumerable
{
	private string MB8;

	private List<Range> LBT;

	internal static RangeCollection mW6;

	public int Count => LBT.Count;

	public string Key => MB8;

	public Range this[int index] => LBT[index];

	public RangeCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(null);
	}

	public RangeCollection(string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		LBT = new List<Range>();
		base._002Ector();
		MB8 = key;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return LBT.GetEnumerator();
	}

	internal void Adjust(int startValue, int deletedLength, int insertedLength)
	{
		int num = BinarySearch(startValue);
		bool flag = true;
		if (num < 0)
		{
			num = ~num;
			flag = false;
		}
		int num2 = Count;
		int num3 = insertedLength - deletedLength;
		int num4 = startValue + deletedLength;
		if (flag && num < num2)
		{
			if (num3 > 0)
			{
				LBT[num] = new Range(LBT[num].Min, LBT[num].Max + num3);
				num++;
			}
			else if (LBT[num].Min == startValue)
			{
				if (num4 >= LBT[num].Max)
				{
					LBT.RemoveAt(num);
					num2--;
				}
				else
				{
					LBT[num] = new Range(LBT[num].Min, LBT[num].Max - (num4 - LBT[num].Min));
					num++;
				}
			}
			else if (num3 < 0)
			{
				int num5 = Math.Min(LBT[num].Max, num4);
				LBT[num] = new Range(LBT[num].Min, LBT[num].Max - (num5 - startValue));
				num++;
			}
		}
		if (deletedLength > 0)
		{
			while (num < num2 && num4 >= LBT[num].Min)
			{
				if (num4 >= LBT[num].Max)
				{
					LBT.RemoveAt(num);
					num2--;
					continue;
				}
				LBT[num] = new Range(num4, LBT[num].Max);
				break;
			}
		}
		for (int i = num; i < num2; i++)
		{
			LBT[i] = new Range(LBT[i].Min + num3, LBT[i].Max + num3);
		}
	}

	public int BinarySearch(int value)
	{
		int num = 0;
		int num2 = LBT.Count - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			if (LBT[num3].Contains(value))
			{
				return num3;
			}
			if (LBT[num3].Max > value)
			{
				num2 = num3 - 1;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if (num2 >= 0)
		{
			if (LBT[num2].Max > value)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	public void Clear()
	{
		LBT.Clear();
	}

	public bool Contains(int value)
	{
		return IndexOf(value) != -1;
	}

	public void CopyTo(Range[] array, int arrayIndex)
	{
		LBT.CopyTo(array, arrayIndex);
	}

	public IEnumerator<Range> GetEnumerator()
	{
		return LBT.GetEnumerator();
	}

	public int IndexOf(int value)
	{
		int num = BinarySearch(value);
		return (num >= 0) ? num : (-1);
	}

	public Range[] Merge(Range range)
	{
		if (range.Length == 0)
		{
			return new Range[0];
		}
		range.Normalize();
		List<Range> list = new List<Range>();
		int num = BinarySearch(range.Min);
		if (num < 0)
		{
			num = ~num;
		}
		int count = Count;
		if (num < count)
		{
			Range range2 = LBT[num];
			if (range2.Contains(range))
			{
				return list.ToArray();
			}
			if (range.Max < range2.Min)
			{
				list.Add(range);
				if (num > 0 && LBT[num - 1].Max == range.Min)
				{
					LBT[num - 1] = new Range(LBT[num - 1].Min, range.Max);
				}
				else
				{
					LBT.Insert(num, range);
				}
				return list.ToArray();
			}
			if (range.Max <= range2.Max)
			{
				list.Add(new Range(range.Min, range2.Min));
				if (num > 0 && LBT[num - 1].Max == range.Min)
				{
					LBT[num - 1] = new Range(LBT[num - 1].Min, range2.Max);
					LBT.RemoveAt(num);
				}
				else
				{
					LBT[num] = new Range(range.Min, range2.Max);
				}
				return list.ToArray();
			}
			if (num > 0 && LBT[num - 1].Max == range.Min)
			{
				num--;
			}
			else if (range.Min < range2.Min)
			{
				list.Add(new Range(range.Min, range2.Min));
			}
			int num2 = num;
			int num3 = num;
			for (num++; num < count && range.Max >= LBT[num].Min; num++)
			{
				list.Add(new Range(LBT[num - 1].Max, LBT[num].Min));
				num3 = num;
			}
			if (range.Max > LBT[num3].Max)
			{
				list.Add(new Range(LBT[num3].Max, range.Max));
			}
			LBT.Insert(num2, new Range(Math.Min(range.Min, LBT[num2].Min), Math.Max(range.Max, LBT[num3].Max)));
			LBT.RemoveRange(num2 + 1, num3 - num2 + 1);
			return list.ToArray();
		}
		num = count - 1;
		if (num >= 0 && LBT[num].Max == range.Min)
		{
			list.Add(new Range(LBT[num].Max, range.Max));
			LBT[num] = new Range(LBT[num].Min, range.Max);
		}
		else
		{
			list.Add(range);
			LBT.Add(range);
		}
		return list.ToArray();
	}

	public bool OverlapsWith(Range range)
	{
		int num = BinarySearch(range.Min);
		if (num < 0)
		{
			int num2 = 0;
			if (UWG() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			num = ~num;
		}
		return num < LBT.Count && LBT[num].OverlapsWith(range);
	}

	public Range[] Unmerge(Range range)
	{
		if (range.Length == 0)
		{
			return new Range[0];
		}
		range.Normalize();
		List<Range> list = new List<Range>();
		int num = 0;
		if (UWG() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		bool flag = default(bool);
		Range range2 = default(Range);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!flag)
				{
					goto case 2;
				}
				range2 = LBT[num2];
				if (!range.OverlapsWith(range2))
				{
					num = 0;
					if (JWE())
					{
						num = 2;
					}
					continue;
				}
				if (range.Min <= range2.Min)
				{
					if (range.Max < range2.Max)
					{
						list.Add(new Range(range2.Min, range.Max));
						LBT[num2] = new Range(range.Max, range2.Max);
						goto case 2;
					}
					list.Add(range2);
					LBT.RemoveAt(num2);
					num3--;
				}
				else
				{
					if (range.Max < range2.Max)
					{
						list.Add(range);
						num = 1;
						if (JWE())
						{
							continue;
						}
						break;
					}
					list.Add(new Range(range.Min, range2.Max));
					LBT[num2] = new Range(range2.Min, range.Min);
					num2++;
				}
				goto IL_00af;
			case 2:
				return list.ToArray();
			default:
				num2 = BinarySearch(range.Min);
				if (num2 < 0)
				{
					num2 = ~num2;
				}
				num3 = Count;
				goto IL_00af;
			case 1:
				{
					Range item = new Range(range.Max, range2.Max);
					LBT[num2] = new Range(range2.Min, range.Min);
					LBT.Insert(num2 + 1, item);
					goto case 2;
				}
				IL_00af:
				flag = num2 < num3;
				num = 3;
				if (UWG() == null)
				{
					continue;
				}
				break;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num4 = default(int);
		num = num4;
		goto IL_0009;
	}

	internal static bool JWE()
	{
		return mW6 == null;
	}

	internal static RangeCollection UWG()
	{
		return mW6;
	}
}
