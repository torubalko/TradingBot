using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Products.Shared;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class EnumerableView<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IList<T>, IList, INotifyCollectionChanged
{
	private class Mn
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int zqs;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool pqL;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private T cqd;

		internal static object E8M;

		public int Index
		{
			[CompilerGenerated]
			get
			{
				return zqs;
			}
			[CompilerGenerated]
			set
			{
				zqs = num;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public bool vqH()
		{
			return pqL;
		}

		[SpecialName]
		[CompilerGenerated]
		public void mq6(bool P_0)
		{
			pqL = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public T Hq5()
		{
			return cqd;
		}

		[SpecialName]
		[CompilerGenerated]
		public void qqR(T mk)
		{
			cqd = mk;
		}

		public override string ToString()
		{
			if (!vqH())
			{
				return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136254), new object[2]
				{
					Hq5(),
					Index
				});
			}
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136202), new object[2]
			{
				Hq5(),
				Index
			});
		}

		public Mn()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool G8Y()
		{
			return E8M == null;
		}

		internal static object Q8t()
		{
			return E8M;
		}
	}

	private DeferrableObservableCollection<T> HO;

	private DeferrableObservableCollection<T> r0;

	private List<Mn> Ak;

	private Predicate<T> ml;

	private Comparison<T> LA;

	private IComparer<T> LC;

	private IEnumerable<T> zY;

	private bool gI;

	private Queue<int> Nx;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler Tr;

	private static object mI;

	public int Count => HO.Count;

	public bool IsReadOnly => true;

	int ICollection.Count => HO.Count;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool ICollection.IsSynchronized => ((ICollection)HO).IsSynchronized;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	object ICollection.SyncRoot => this;

	public T this[int index]
	{
		get
		{
			return HO[index];
		}
		set
		{
			throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	bool IList.IsFixedSize => false;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
		}
	}

	public Predicate<T> FilterPredicate
	{
		get
		{
			return ml;
		}
		set
		{
			if (ml != value)
			{
				ml = value;
				GQ();
			}
		}
	}

	public bool IsSorting => LA != null || LC != null;

	public IComparer<T> SortComparer
	{
		get
		{
			return LC;
		}
		set
		{
			if (LC != value)
			{
				LC = value;
				GQ();
			}
		}
	}

	public Comparison<T> SortComparison
	{
		get
		{
			return LA;
		}
		set
		{
			if (LA != value)
			{
				LA = value;
				GQ();
			}
		}
	}

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = Tr;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref Tr, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = Tr;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref Tr, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	public EnumerableView(IEnumerable<T> collection)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, (Predicate<T>)null, (Comparison<T>)null, (IComparer<T>)null);
	}

	public EnumerableView(IEnumerable<T> collection, Predicate<T> filter)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, filter, (Comparison<T>)null, (IComparer<T>)null);
	}

	public EnumerableView(IEnumerable<T> collection, Comparison<T> sort)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, (Predicate<T>)null, sort, (IComparer<T>)null);
	}

	public EnumerableView(IEnumerable<T> collection, IComparer<T> sort)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, (Predicate<T>)null, (Comparison<T>)null, sort);
	}

	public EnumerableView(IEnumerable<T> collection, Predicate<T> filter, Comparison<T> sort)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, filter, sort, (IComparer<T>)null);
	}

	public EnumerableView(IEnumerable<T> collection, Predicate<T> filter, IComparer<T> sort)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(collection, filter, (Comparison<T>)null, sort);
	}

	private EnumerableView(IEnumerable<T> collection, Predicate<T> filter, Comparison<T> sortComparison, IComparer<T> sortComparer)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (collection == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132));
		}
		HO = new DeferrableObservableCollection<T>();
		HO.CollectionChanged += Re;
		r0 = new DeferrableObservableCollection<T>();
		Ak = new List<Mn>();
		ml = filter;
		LA = sortComparison;
		LC = sortComparer;
		zY = collection;
		if (collection is INotifyCollectionChanged notifyCollectionChanged)
		{
			notifyCollectionChanged.CollectionChanged += A7;
		}
		GQ();
	}

	public void Add(T item)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	public void Clear()
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	public bool Contains(T item)
	{
		return HO.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		HO.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	void ICollection.CopyTo(Array array, int index)
	{
		((ICollection)HO).CopyTo(array, index);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return HO.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)HO).GetEnumerator();
	}

	public int IndexOf(T item)
	{
		throw new NotImplementedException();
	}

	public void Insert(int index, T item)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	public void RemoveAt(int index)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	int IList.Add(object value)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	public bool Contains(object value)
	{
		if (!(value is T))
		{
			return false;
		}
		return Contains((T)value);
	}

	public int IndexOf(object value)
	{
		if (value is T)
		{
			return IndexOf((T)value);
		}
		return -1;
	}

	public void Insert(int index, object value)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	void IList.Remove(object value)
	{
		throw new NotSupportedException(SR.GetString(SRName.ExNotSupportedReadOnlyCollection));
	}

	private void qm(T k3, int P_1)
	{
		if (ml != null && ml(k3))
		{
			if (P_1 == -1)
			{
				r0.Add(k3);
				List<Mn> ak = Ak;
				Mn mn = new Mn();
				mn.mq6(_0020: true);
				mn.Index = r0.Count - 1;
				mn.qqR(k3);
				ak.Add(mn);
				return;
			}
			Mn mn2 = new Mn();
			mn2.mq6(_0020: true);
			mn2.Index = -1;
			mn2.qqR(k3);
			Mn mn3 = mn2;
			for (int i = P_1; i < Ak.Count; i++)
			{
				Mn mn4 = Ak[i];
				if (mn4.vqH())
				{
					if (mn3.Index == -1)
					{
						mn3.Index = mn4.Index;
					}
					mn4.Index++;
				}
			}
			if (mn3.Index == -1)
			{
				mn3.Index = r0.Count;
			}
			r0.Insert(mn3.Index, k3);
			Ak.Insert(P_1, mn3);
			return;
		}
		Mn mn5 = new Mn();
		mn5.mq6(_0020: false);
		mn5.Index = Aw(k3, P_1, _0020: true);
		mn5.qqR(k3);
		Mn mn6 = mn5;
		for (int j = 0; j < Ak.Count; j++)
		{
			Mn mn7 = Ak[j];
			if (!mn7.vqH() && mn7.Index >= mn6.Index)
			{
				mn7.Index++;
			}
		}
		Ak.Insert((P_1 != -1) ? P_1 : Ak.Count, mn6);
		HO.Insert(mn6.Index, k3);
	}

	private int Aw(T Vy, int P_1, bool P_2)
	{
		int num = -1;
		if (IsSorting)
		{
			if (HO.Count != 0)
			{
				bool flag = false;
				for (int i = 0; i < HO.Count; i++)
				{
					int num2 = y4(Vy, HO[i]);
					if (num2 < 0)
					{
						num = i;
						break;
					}
					if (flag || num2 != 0)
					{
						continue;
					}
					num = i;
					int num3 = 0;
					for (int j = 0; j < Ak.Count; j++)
					{
						Mn mn = Ak[j];
						if (!mn.vqH() && mn.Index == i)
						{
							num3 = j;
							break;
						}
					}
					if (!P_2 && num3 == P_1)
					{
						flag = true;
						continue;
					}
					if (num3 >= P_1)
					{
						break;
					}
					if (num3 < P_1 && i == HO.Count - 1)
					{
						num++;
						break;
					}
				}
			}
		}
		else if (P_1 >= 0 && P_1 < Ak.Count)
		{
			num = Ak[P_1].Index;
		}
		if (num == -1)
		{
			return HO.Count;
		}
		return Math.Min(Math.Max(num, 0), HO.Count);
	}

	private int y4(T Xv, T pb)
	{
		if (LC != null)
		{
			return LC.Compare(Xv, pb);
		}
		if (LA != null)
		{
			return LA(Xv, pb);
		}
		return 0;
	}

	private void Ku(int P_0, int P_1, int P_2)
	{
		if (P_0 < 0 || P_0 >= Ak.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(156));
		}
		if (P_1 < 0 || P_1 > Ak.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(176));
		}
		if (P_0 == P_1)
		{
			return;
		}
		if (P_0 + P_2 > Ak.Count)
		{
			P_2 = Ak.Count - P_0;
		}
		if (P_2 == 0)
		{
			return;
		}
		if (P_0 < P_1)
		{
			for (int i = 0; i < P_2; i++)
			{
				Mn mn = Ak[P_0];
				Ak.RemoveAt(P_0);
				Ak.Insert(P_1, mn);
				int num = mn.Index;
				if (IsSorting && !mn.vqH())
				{
					continue;
				}
				bool flag = true;
				for (int num2 = P_1 + i - 1; num2 >= 0; num2--)
				{
					Mn mn2 = Ak[num2];
					if (mn2.vqH() == mn.vqH())
					{
						if (flag)
						{
							mn.Index = mn2.Index;
						}
						flag = false;
						mn2.Index--;
					}
				}
				if (num != mn.Index)
				{
					if (mn.vqH())
					{
						r0.Move(num, mn.Index);
					}
					else
					{
						HO.Move(num, mn.Index);
					}
				}
			}
			return;
		}
		for (int j = 0; j < P_2; j++)
		{
			Mn mn3 = Ak[P_0 + j];
			Ak.RemoveAt(P_0 + j);
			Ak.Insert(P_1 + j, mn3);
			int num3 = mn3.Index;
			if (IsSorting && !mn3.vqH())
			{
				continue;
			}
			bool flag2 = true;
			for (int k = P_1 + j + 1; k < Ak.Count; k++)
			{
				Mn mn4 = Ak[k];
				if (mn4.vqH() == mn3.vqH())
				{
					if (flag2)
					{
						mn3.Index = mn4.Index;
					}
					flag2 = false;
					mn4.Index++;
				}
			}
			if (num3 != mn3.Index)
			{
				if (mn3.vqH())
				{
					r0.Move(num3, mn3.Index);
				}
				else
				{
					HO.Move(num3, mn3.Index);
				}
			}
		}
	}

	private void d2(NotifyCollectionChangedEventArgs P_0)
	{
		Tr?.Invoke(this, P_0);
	}

	private void Re(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		d2(P_1);
	}

	private void A7(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		switch (P_1.Action)
		{
		case NotifyCollectionChangedAction.Add:
			if (P_1.NewItems != null)
			{
				for (int j = 0; j < P_1.NewItems.Count; j++)
				{
					qm((T)P_1.NewItems[j], (P_1.NewStartingIndex != -1) ? (P_1.NewStartingIndex + j) : (-1));
				}
			}
			break;
		case NotifyCollectionChangedAction.Move:
			if (P_1.OldItems != null && P_1.NewItems != null && P_1.OldItems.Count == P_1.NewItems.Count)
			{
				Ku(P_1.OldStartingIndex, P_1.NewStartingIndex, P_1.OldItems.Count);
			}
			break;
		case NotifyCollectionChangedAction.Remove:
			if (P_1.OldItems != null)
			{
				MF(P_1.OldStartingIndex, P_1.OldItems.Count);
			}
			break;
		case NotifyCollectionChangedAction.Replace:
			if (P_1.OldItems != null && P_1.NewItems != null && P_1.OldItems.Count == P_1.NewItems.Count)
			{
				for (int i = 0; i < P_1.OldItems.Count; i++)
				{
					Io(P_1.OldStartingIndex + i, (T)P_1.NewItems[i], _0020: true);
				}
			}
			break;
		default:
			GQ();
			break;
		}
	}

	private void MF(int P_0, int P_1)
	{
		if (P_0 < 0 || P_0 >= Ak.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(196));
		}
		if (P_0 + P_1 > Ak.Count)
		{
			P_1 = Ak.Count - P_0;
		}
		if (P_1 == 0)
		{
			return;
		}
		for (int num = P_0 + P_1 - 1; num >= P_0; num--)
		{
			Mn mn = Ak[num];
			Ak.RemoveAt(num);
			for (int i = 0; i < Ak.Count; i++)
			{
				Mn mn2 = Ak[i];
				if (mn2.vqH() == mn.vqH() && mn2.Index > mn.Index)
				{
					mn2.Index--;
				}
			}
			if (mn.vqH())
			{
				r0.RemoveAt(mn.Index);
			}
			else
			{
				HO.RemoveAt(mn.Index);
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void Io(int P_0, T n1, bool P_2)
	{
		if (P_0 < 0 || P_0 >= Ak.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(196));
		}
		Mn mn = Ak[P_0];
		mn.qqR(n1);
		bool flag = ml != null && ml(n1);
		if (mn.vqH() == flag)
		{
			if (flag)
			{
				r0[mn.Index] = n1;
				return;
			}
			int num = Aw(n1, P_0, P_2);
			if (num < mn.Index)
			{
				for (int i = 0; i < Ak.Count; i++)
				{
					Mn mn2 = Ak[i];
					if (!mn2.vqH() && mn2.Index > num && mn2.Index < mn.Index)
					{
						mn2.Index++;
					}
				}
				int num2 = mn.Index;
				HO[num2] = n1;
				mn.Index = num;
				HO.Move(num2, num);
			}
			else if (num > mn.Index)
			{
				num--;
				for (int j = 0; j < Ak.Count; j++)
				{
					Mn mn3 = Ak[j];
					if (!mn3.vqH() && mn3.Index > mn.Index && mn3.Index < num)
					{
						mn3.Index--;
					}
				}
				int num3 = mn.Index;
				HO[num3] = n1;
				mn.Index = num;
				HO.Move(num3, num);
			}
			else
			{
				HO[mn.Index] = n1;
			}
			return;
		}
		HO.BeginUpdate();
		r0.BeginUpdate();
		try
		{
			mn.mq6(flag);
			IList<T> list = null;
			IList<T> list2 = null;
			if (flag)
			{
				list = HO;
				list2 = r0;
			}
			else
			{
				list = r0;
				list2 = HO;
			}
			list.RemoveAt(mn.Index);
			for (int k = 0; k < Ak.Count; k++)
			{
				Mn mn4 = Ak[k];
				if (mn4.vqH() == !flag && mn4.Index > mn.Index)
				{
					mn4.Index--;
				}
			}
			if (!flag && IsSorting)
			{
				mn.Index = Aw(n1, P_0, P_2);
				for (int l = 0; l < Ak.Count; l++)
				{
					Mn mn5 = Ak[l];
					if (mn5 != mn && !mn5.vqH() && mn5.Index >= mn.Index)
					{
						mn5.Index++;
					}
				}
			}
			else
			{
				bool flag2 = false;
				for (int m = P_0 + 1; m < Ak.Count; m++)
				{
					Mn mn6 = Ak[m];
					if (mn6.vqH() == mn.vqH())
					{
						if (!flag2)
						{
							mn.Index = mn6.Index;
						}
						flag2 = true;
						mn6.Index++;
					}
				}
				if (!flag2)
				{
					mn.Index = list2.Count;
				}
			}
			list2.Insert(mn.Index, n1);
		}
		finally
		{
			r0.EndUpdate();
			HO.EndUpdate();
		}
	}

	private void GQ()
	{
		HO.BeginUpdate();
		try
		{
			HO.Clear();
			r0.Clear();
			Ak.Clear();
			foreach (T item in zY)
			{
				qm(item, -1);
			}
		}
		finally
		{
			HO.EndUpdate();
		}
	}

	public void Reevaluate(T item)
	{
		for (int i = 0; i < Ak.Count; i++)
		{
			if ((object)Ak[i].Hq5() == (object)item)
			{
				ReevaluateAt(i);
				break;
			}
		}
	}

	public void ReevaluateAt(int index)
	{
		if (index < 0 || index >= Ak.Count)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(196));
		}
		if (gI)
		{
			if (Nx == null)
			{
				Nx = new Queue<int>();
			}
			Nx.Enqueue(index);
			return;
		}
		gI = true;
		try
		{
			Mn mn = Ak[index];
			bool flag = false;
			if (mn.vqH() != (ml != null && ml(mn.Hq5())))
			{
				flag = true;
			}
			else if (!mn.vqH())
			{
				int num = Aw(mn.Hq5(), index, _0020: false);
				if (mn.Index != num && (mn.Index != HO.Count - 1 || num != HO.Count))
				{
					flag = true;
				}
			}
			if (flag)
			{
				Io(index, mn.Hq5(), _0020: false);
			}
		}
		finally
		{
			gI = false;
		}
		if (Nx != null && Nx.Count != 0)
		{
			while (Nx.Count != 0)
			{
				ReevaluateAt(Nx.Dequeue());
			}
		}
	}

	internal static bool uD()
	{
		return mI == null;
	}

	internal static object w2()
	{
		return mI;
	}
}
