using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

public class TreeNodeItemCollection : IList<object>, ICollection<object>, IEnumerable<object>, IEnumerable, ISelectedTreeItemCollection, INotifyCollectionChanged, ICollectionView
{
	internal class cu : IComparer<oT>
	{
		private static cu eXf;

		public int Compare(oT P_0, oT P_1)
		{
			if (P_0 == null || P_1 == null)
			{
				return 0;
			}
			return P_0.kNR().CompareTo(P_1.kNR());
		}

		public cu()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal static bool rXo()
		{
			return eXf == null;
		}

		internal static cu fXZ()
		{
			return eXf;
		}
	}

	private class kO : IDisposable
	{
		private object VTv;

		private TreeNodeItemCollection RT8;

		internal static kO MXx;

		internal kO(TreeNodeItemCollection P_0)
		{
			fc.taYSkz();
			base._002Ector();
			RT8 = P_0;
			VTv = P_0.CurrentItem;
			P_0.TN9();
		}

		public void Dispose()
		{
			RT8.MoveCurrentTo(VTv);
			RT8.ENj();
		}

		internal static bool fXS()
		{
			return MXx == null;
		}

		internal static kO FX1()
		{
			return MXx;
		}
	}

	private List<object> HNf;

	private int FN0;

	private List<oT> oNA;

	private HashSet<oT> fN4;

	private int YNS;

	private CultureInfo RNz;

	private int NlI;

	private Predicate<object> slP;

	private ObservableCollection<GroupDescription> Gl1;

	private SortDescriptionCollection vlt;

	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler wlU;

	[CompilerGenerated]
	private EventHandler Sl6;

	[CompilerGenerated]
	private CurrentChangingEventHandler ulq;

	private static TreeNodeItemCollection Cse;

	public int Count => HNf.Count;

	public bool IsReadOnly => true;

	public object this[int index]
	{
		get
		{
			return HNf[index];
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public bool CanFilter => false;

	public bool CanGroup => false;

	public bool CanSort => false;

	public CultureInfo Culture
	{
		get
		{
			return RNz ?? CultureInfo.CurrentCulture;
		}
		set
		{
			RNz = value;
		}
	}

	public object CurrentItem
	{
		get
		{
			if (NlI < 0 || NlI >= HNf.Count)
			{
				return null;
			}
			return HNf[NlI];
		}
	}

	public int CurrentPosition => NlI;

	public Predicate<object> Filter
	{
		get
		{
			return slP;
		}
		set
		{
			slP = value;
		}
	}

	public ObservableCollection<GroupDescription> GroupDescriptions => Gl1;

	public ReadOnlyObservableCollection<object> Groups => null;

	public bool IsCurrentAfterLast => NlI >= HNf.Count;

	public bool IsCurrentBeforeFirst => NlI < 0;

	public bool IsEmpty => HNf.Count == 0;

	public SortDescriptionCollection SortDescriptions => vlt;

	public IEnumerable SourceCollection => HNf;

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = wlU;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref wlU, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = wlU;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
			do
			{
				notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
				NotifyCollectionChangedEventHandler value2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(notifyCollectionChangedEventHandler2, value);
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref wlU, value2, notifyCollectionChangedEventHandler2);
			}
			while ((object)notifyCollectionChangedEventHandler != notifyCollectionChangedEventHandler2);
		}
	}

	public event EventHandler CurrentChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Sl6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sl6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Sl6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sl6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event CurrentChangingEventHandler CurrentChanging
	{
		[CompilerGenerated]
		add
		{
			CurrentChangingEventHandler currentChangingEventHandler = ulq;
			CurrentChangingEventHandler currentChangingEventHandler2;
			do
			{
				currentChangingEventHandler2 = currentChangingEventHandler;
				CurrentChangingEventHandler value2 = (CurrentChangingEventHandler)Delegate.Combine(currentChangingEventHandler2, value);
				currentChangingEventHandler = Interlocked.CompareExchange(ref ulq, value2, currentChangingEventHandler2);
			}
			while ((object)currentChangingEventHandler != currentChangingEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			CurrentChangingEventHandler currentChangingEventHandler = ulq;
			CurrentChangingEventHandler currentChangingEventHandler2;
			do
			{
				currentChangingEventHandler2 = currentChangingEventHandler;
				CurrentChangingEventHandler value2 = (CurrentChangingEventHandler)Delegate.Remove(currentChangingEventHandler2, value);
				currentChangingEventHandler = Interlocked.CompareExchange(ref ulq, value2, currentChangingEventHandler2);
			}
			while ((object)currentChangingEventHandler != currentChangingEventHandler2);
		}
	}

	public TreeNodeItemCollection(bool useHashSet)
	{
		fc.taYSkz();
		HNf = new List<object>();
		FN0 = -1;
		oNA = new List<oT>();
		NlI = -1;
		Gl1 = new ObservableCollection<GroupDescription>();
		vlt = new SortDescriptionCollection();
		base._002Ector();
		if (useHashSet)
		{
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			fN4 = new HashSet<oT>();
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return HNf.GetEnumerator();
	}

	internal void TN9()
	{
		YNS = Math.Min(2147483646, YNS + 1);
	}

	internal void wN3()
	{
		if (HNf.Count > 1000)
		{
			HNf = new List<object>();
			oNA = new List<oT>();
			if (fN4 != null)
			{
				fN4 = new HashSet<oT>();
				int num = 0;
				if (Isn() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		else
		{
			HNf.Clear();
			oNA.Clear();
			if (fN4 != null)
			{
				fN4.Clear();
			}
		}
		if (YNS == 0)
		{
			nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}
	}

	internal bool fNL(oT P_0)
	{
		if (fN4 != null)
		{
			return fN4.Contains(P_0);
		}
		return GNi(P_0) != -1;
	}

	internal void ENj()
	{
		if (YNS > 0)
		{
			YNS = Math.Max(0, YNS - 1);
			if (YNS == 0)
			{
				nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			}
		}
	}

	internal oT uNx(int P_0)
	{
		return oNA[P_0];
	}

	internal IEnumerator<oT> FNa()
	{
		return oNA.GetEnumerator();
	}

	internal int GNi(oT P_0)
	{
		int count = oNA.Count;
		if (FN0 + 1 >= count || oNA[FN0 + 1] != P_0)
		{
			if (FN0 >= 0)
			{
				int num = 0;
				if (Isn() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (FN0 < count && oNA[FN0] == P_0)
				{
					return FN0;
				}
			}
			int num3 = oNA.IndexOf(P_0);
			if (num3 != -1)
			{
				FN0 = num3;
			}
			return num3;
		}
		return ++FN0;
	}

	internal int vNb(oT P_0, int P_1)
	{
		if (FN0 >= P_1)
		{
			int count = oNA.Count;
			if (FN0 + 1 < count && oNA[FN0 + 1] == P_0)
			{
				return ++FN0;
			}
			if (FN0 >= 0 && FN0 < count && oNA[FN0] == P_0)
			{
				return FN0;
			}
		}
		int num = oNA.IndexOf(P_0, P_1);
		if (num != -1)
		{
			FN0 = num;
		}
		return num;
	}

	internal void xNh(int P_0, oT P_1)
	{
		HNf.Insert(P_0, P_1.sNm());
		oNA.Insert(P_0, P_1);
		if (fN4 != null)
		{
			fN4.Add(P_1);
		}
		if (YNS == 0)
		{
			nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}
	}

	internal void DNZ(oT P_0)
	{
		int num = oNA.BinarySearch(P_0, new cu());
		if (num < 0)
		{
			num = ~num;
		}
		xNh(Math.Min(Count, num), P_0);
	}

	internal void JNH(int P_0, IEnumerable<oT> P_1)
	{
		object[] array = P_1.Select((oT tn) => tn.sNm()).ToArray();
		HNf.InsertRange(P_0, array);
		oNA.InsertRange(P_0, P_1);
		if (fN4 != null)
		{
			foreach (oT item in P_1)
			{
				fN4.Add(item);
			}
		}
		if (YNS == 0)
		{
			object[] array2 = array;
			foreach (object changedItem in array2)
			{
				nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, changedItem, P_0++));
			}
		}
	}

	[SpecialName]
	internal bool VNc()
	{
		return YNS > 0;
	}

	internal void cND(int P_0, int P_1)
	{
		object[] array = ((YNS == 0) ? HNf.Skip(P_0).Take(P_1).ToArray() : null);
		int num = 0;
		if (Isn() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (fN4 != null)
		{
			for (int i = 0; i < P_1; i++)
			{
				fN4.Remove(oNA[P_0 + i]);
			}
		}
		HNf.RemoveRange(P_0, P_1);
		oNA.RemoveRange(P_0, P_1);
		if (YNS == 0)
		{
			for (int num3 = array.Length - 1; num3 >= 0; num3--)
			{
				nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, array[num3], P_0 + num3));
			}
		}
	}

	internal void NN7(int P_0, object P_1)
	{
		if (P_0 < 0 || P_0 >= HNf.Count)
		{
			return;
		}
		object obj = HNf[P_0];
		if (obj != P_1)
		{
			HNf[P_0] = P_1;
			if (YNS == 0)
			{
				nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, P_1, obj));
			}
		}
	}

	internal oT[] PNs()
	{
		return oNA.ToArray();
	}

	public void Add(object item)
	{
		throw new NotImplementedException();
	}

	public void Clear()
	{
		throw new NotImplementedException();
	}

	public bool Contains(object item)
	{
		return IndexOf(item) != -1;
	}

	public void CopyTo(object[] array, int arrayIndex)
	{
		HNf.CopyTo(array, arrayIndex);
	}

	public IEnumerator<object> GetEnumerator()
	{
		return HNf.GetEnumerator();
	}

	public int IndexOf(object item)
	{
		return HNf.IndexOf(item);
	}

	public void Insert(int index, object item)
	{
		throw new NotImplementedException();
	}

	public bool Remove(object item)
	{
		throw new NotImplementedException();
	}

	public void RemoveAt(int index)
	{
		throw new NotImplementedException();
	}

	private void nNF(NotifyCollectionChangedEventArgs P_0)
	{
		wlU?.Invoke(this, P_0);
	}

	public IDisposable DeferRefresh()
	{
		return new kO(this);
	}

	public bool MoveCurrentTo(object item)
	{
		if (item == CurrentItem)
		{
			return true;
		}
		return MoveCurrentToPosition(HNf.IndexOf(item));
	}

	public bool MoveCurrentToFirst()
	{
		return MoveCurrentToPosition(0);
	}

	public bool MoveCurrentToLast()
	{
		return MoveCurrentToPosition(HNf.Count - 1);
	}

	public bool MoveCurrentToNext()
	{
		return MoveCurrentToPosition(NlI + 1);
	}

	public bool MoveCurrentToPosition(int position)
	{
		if (position >= -1 && position <= HNf.Count)
		{
			if (NlI != position)
			{
				CurrentChangingEventArgs e = new CurrentChangingEventArgs();
				ulq?.Invoke(this, e);
				if (!e.Cancel)
				{
					NlI = position;
					Sl6?.Invoke(this, EventArgs.Empty);
				}
			}
			if (NlI >= 0)
			{
				return NlI < HNf.Count;
			}
			return false;
		}
		throw new ArgumentOutOfRangeException(xv.hTz(10174));
	}

	public bool MoveCurrentToPrevious()
	{
		return MoveCurrentToPosition(NlI - 1);
	}

	public void Refresh()
	{
		if (YNS == 0)
		{
			nNF(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}
	}

	internal static bool gsv()
	{
		return Cse == null;
	}

	internal static TreeNodeItemCollection Isn()
	{
		return Cse;
	}
}
