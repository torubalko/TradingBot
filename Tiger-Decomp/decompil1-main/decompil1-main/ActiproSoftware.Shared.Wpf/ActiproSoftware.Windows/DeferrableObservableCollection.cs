using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

public class DeferrableObservableCollection<T> : ObservableCollection<T>
{
	private NotifyCollectionChangedEventArgs FS;

	private int x3;

	private bool Pt;

	private bool yJ;

	private IComparer<T> F9;

	private int ch;

	internal static object Md;

	public bool IsDirty => Pt;

	public bool IsPropertyChangeSuspended => ch > 0;

	public DeferrableObservableCollection()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector((IComparer<T>)null, useStableSort: false);
	}

	public DeferrableObservableCollection(IComparer<T> sortComparer)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(sortComparer, useStableSort: false);
	}

	public DeferrableObservableCollection(IComparer<T> sortComparer, bool useStableSort)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		F9 = sortComparer;
		yJ = useStableSort;
	}

	private int Di(T kI, int P_1)
	{
		if (F9 != null)
		{
			int count = base.Count;
			if (count > 0)
			{
				int num = -1;
				if (yJ)
				{
					for (int i = 0; i < count; i++)
					{
						int num2 = F9.Compare(kI, base[i]);
						if (num2 <= 0)
						{
							num = i;
							if (num2 != 0 || i >= P_1)
							{
								break;
							}
							if (i < P_1 && i == count - 1)
							{
								num++;
								break;
							}
						}
					}
				}
				else
				{
					int num3 = 0;
					int num4 = count - 1;
					while (num3 <= num4)
					{
						int num5 = num3 + (num4 - num3) / 2;
						int num6 = F9.Compare(kI, base[num5]);
						if (num6 < 0)
						{
							num4 = num5 - 1;
							num = num5;
							continue;
						}
						if (num6 == 0)
						{
							num = num5;
							break;
						}
						num3 = num5 + 1;
					}
				}
				P_1 = ((-1 != num) ? num : count);
			}
		}
		return P_1;
	}

	public void AddRange(IEnumerable<T> items)
	{
		if (items == null)
		{
			return;
		}
		foreach (T item in items)
		{
			Add(item);
		}
	}

	public void BeginUpdate()
	{
		ch = Math.Min(2147483646, ch + 1);
	}

	public void EndUpdate()
	{
		if (ch > 0)
		{
			ch = Math.Max(0, ch - 1);
			if (ch == 0 && Pt)
			{
				Pt = false;
				x3 = 0;
				OnPropertyChanged(new PropertyChangedEventArgs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102)));
				OnPropertyChanged(new PropertyChangedEventArgs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118)));
				NotifyCollectionChangedEventArgs e = FS ?? new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
				FS = null;
				OnCollectionChanged(e);
			}
		}
	}

	protected override void InsertItem(int index, T item)
	{
		index = Di(item, index);
		base.InsertItem(index, item);
	}

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
		if (IsPropertyChangeSuspended)
		{
			Pt = true;
			FS = ((x3++ == 0) ? e : null);
		}
		else
		{
			base.OnCollectionChanged(e);
		}
	}

	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		if (IsPropertyChangeSuspended)
		{
			Pt = true;
		}
		else
		{
			base.OnPropertyChanged(e);
		}
	}

	protected override void SetItem(int index, T item)
	{
		index = Di(item, index);
		base.SetItem(index, item);
	}

	public T[] ToArray()
	{
		T[] array = new T[base.Count];
		CopyTo(array, 0);
		return array;
	}

	internal static bool nv()
	{
		return Md == null;
	}

	internal static object ta()
	{
		return Md;
	}
}
