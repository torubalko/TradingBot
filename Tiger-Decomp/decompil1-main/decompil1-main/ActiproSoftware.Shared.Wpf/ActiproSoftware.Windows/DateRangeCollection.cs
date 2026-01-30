using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class DateRangeCollection : ICollection<DateRange>, IEnumerable<DateRange>, IEnumerable, INotifyCollectionChanged
{
	private DeferrableObservableCollection<DateRange> Py;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler Df;

	private static DateRangeCollection Jn;

	public int Count => Py.Count;

	public int DayCount
	{
		get
		{
			int num = 0;
			foreach (DateRange item in Py)
			{
				num += item.Count;
			}
			return num;
		}
	}

	public bool IsReadOnly => false;

	public DateRange this[int index] => Py[index];

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = Df;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref Df, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = Df;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref Df, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	public DateRangeCollection()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Py = new DeferrableObservableCollection<DateRange>();
		Py.CollectionChanged += ap;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private int QT(DateTime P_0)
	{
		P_0 = P_0.Date;
		int num = 0;
		int num2 = Py.Count - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			DateRange dateRange = Py[num3];
			if (dateRange.Contains(P_0))
			{
				return num3;
			}
			if (dateRange.EndDate > P_0)
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
			if (Py[num2].EndDate > P_0)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	private void KB(int P_0, int P_1, DateRange P_2)
	{
		Py.BeginUpdate();
		try
		{
			for (int num = P_1; num >= P_0; num--)
			{
				Py.RemoveAt(num);
			}
			Py.Insert(P_0, P_2);
		}
		finally
		{
			Py.EndUpdate();
		}
	}

	private void ap(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		Wb(P_1);
	}

	private void Wb(NotifyCollectionChangedEventArgs P_0)
	{
		Df?.Invoke(this, P_0);
	}

	public void Add(DateRange item)
	{
		int num = QT(item.StartDate);
		int num2 = QT(item.EndDate);
		if (num >= 0)
		{
			if (num2 == num)
			{
				return;
			}
			if (num2 <= num)
			{
				if (num2 >= 0)
				{
					return;
				}
				num2 = ~num2;
				if (num2 < Py.Count)
				{
					DateTime endDate = item.EndDate;
					if (!((Py[num2].StartDate - endDate).TotalDays > 1.0))
					{
						endDate = Py[num2].EndDate;
					}
					else
					{
						num2--;
					}
					KB(num, num2, DateRange.FromRange(Py[num].StartDate, endDate));
				}
				else
				{
					KB(num, Py.Count - 1, DateRange.FromRange(Py[num].StartDate, item.EndDate));
				}
			}
			else
			{
				KB(num, num2, DateRange.FromRange(Py[num].StartDate, Py[num2].EndDate));
			}
			return;
		}
		num = ~num;
		DateTime startDate = item.StartDate;
		int num3 = 2;
		bool flag = default(bool);
		int num5 = default(int);
		DateTime endDate2 = default(DateTime);
		while (true)
		{
			int num4;
			switch (num3)
			{
			case 3:
				return;
			case 2:
				if (num <= 0)
				{
					num3 = 2;
					if (Pb() == null)
					{
						num3 = 4;
					}
					break;
				}
				num4 = (((item.EndDate - Py[num - 1].EndDate).TotalDays <= 1.0) ? 1 : 0);
				goto IL_04cd;
			case 1:
				if (flag)
				{
					num5 = 5;
					goto IL_0005;
				}
				goto IL_00ea;
			default:
				if (!((Py[num2].StartDate - endDate2).TotalDays > 1.0))
				{
					endDate2 = Py[num2].EndDate;
				}
				else
				{
					num2--;
				}
				KB(num, num2, DateRange.FromRange(startDate, endDate2));
				return;
			case 4:
				num4 = 0;
				goto IL_04cd;
			case 5:
				{
					num--;
					startDate = Py[num].StartDate;
					goto IL_00ea;
				}
				IL_04cd:
				flag = (byte)num4 != 0;
				num3 = 1;
				if (z0())
				{
					break;
				}
				goto IL_0005;
				IL_00ea:
				if (num2 < num)
				{
					if (num2 >= 0)
					{
						num3 = 3;
						break;
					}
					num2 = ~num2;
					if (num2 >= Py.Count)
					{
						KB(num, Py.Count - 1, DateRange.FromRange(startDate, item.EndDate));
						return;
					}
					endDate2 = item.EndDate;
					num3 = 0;
					if (Pb() == null)
					{
						break;
					}
					goto IL_0005;
				}
				KB(num, num2, DateRange.FromRange(startDate, Py[num2].EndDate));
				return;
				IL_0005:
				num3 = num5;
				break;
			}
		}
	}

	public void Clear()
	{
		Py.Clear();
	}

	public bool Contains(DateTime date)
	{
		return IndexOf(date) != -1;
	}

	public bool Contains(DateRange item)
	{
		return IndexOf(item) != -1;
	}

	public void CopyTo(DateRange[] array, int arrayIndex)
	{
		Py.CopyTo(array, arrayIndex);
	}

	public IEnumerator<DateRange> GetEnumerator()
	{
		return Py.GetEnumerator();
	}

	public int IndexOf(DateTime date)
	{
		int num = QT(date);
		return (num >= 0) ? num : (-1);
	}

	public int IndexOf(DateRange item)
	{
		return Py.IndexOf(item);
	}

	public bool OverlapsWith(DateRange range)
	{
		foreach (DateRange item in Py)
		{
			if (item.OverlapsWith(range))
			{
				return true;
			}
		}
		return false;
	}

	public bool Remove(DateRange item)
	{
		int num = QT(item.StartDate);
		int num2 = QT(item.EndDate);
		bool result = false;
		Py.BeginUpdate();
		try
		{
			if (num >= 0 && num == num2)
			{
				bool flag = Py[num].StartDate == item.StartDate;
				bool flag2 = Py[num2].EndDate == item.EndDate;
				if (flag)
				{
					if (flag2)
					{
						Py.RemoveAt(num);
						result = true;
					}
					else
					{
						Py[num] = DateRange.FromRange(item.EndDate.AddDays(1.0), Py[num].EndDate);
					}
				}
				else if (flag2)
				{
					Py[num] = DateRange.FromRange(Py[num].StartDate, item.StartDate.AddDays(-1.0));
				}
				else
				{
					DateRange value = DateRange.FromRange(Py[num].StartDate, item.StartDate.AddDays(-1.0));
					DateRange item2 = DateRange.FromRange(item.EndDate.AddDays(1.0), Py[num].EndDate);
					Py[num] = value;
					Py.Insert(num + 1, item2);
				}
			}
			else
			{
				if (num2 >= 0)
				{
					if (!(Py[num2].EndDate == item.EndDate))
					{
						Py[num2] = DateRange.FromRange(item.EndDate.AddDays(1.0), Py[num2].EndDate);
						num2--;
						result = true;
					}
				}
				else
				{
					num2 = ~num2 - 1;
				}
				if (num >= 0)
				{
					if (!(Py[num].StartDate == item.StartDate))
					{
						Py[num] = DateRange.FromRange(Py[num].StartDate, item.StartDate.AddDays(-1.0));
						num++;
						result = true;
					}
				}
				else
				{
					num = ~num;
				}
				for (int num3 = num2; num3 >= num; num3--)
				{
					Py.RemoveAt(num3);
					result = true;
				}
			}
		}
		finally
		{
			Py.EndUpdate();
		}
		return result;
	}

	public void SetToMultipleDateRanges(IEnumerable<DateRange> items)
	{
		Py.BeginUpdate();
		try
		{
			Py.Clear();
			if (items == null)
			{
				return;
			}
			IOrderedEnumerable<DateRange> orderedEnumerable = items.OrderBy((DateRange r) => r.StartDate);
			foreach (DateRange item in items)
			{
				Py.Add(item);
			}
		}
		finally
		{
			Py.EndUpdate();
		}
	}

	public void SetToSingleDateRange(DateRange item)
	{
		if (Count == 1 && Py[0] == item)
		{
			return;
		}
		Py.BeginUpdate();
		try
		{
			Py.Clear();
			Py.Add(item);
		}
		finally
		{
			Py.EndUpdate();
		}
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(40), new object[1] { DayCount });
	}

	internal static bool z0()
	{
		return Jn == null;
	}

	internal static DateRangeCollection Pb()
	{
		return Jn;
	}
}
