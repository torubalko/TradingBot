using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Windows.Controls.Grids;

namespace ActiproSoftware.Internal;

internal class ug : ObservableCollection<TreeListViewColumn>
{
	internal class mM : NotifyCollectionChangedEventArgs
	{
		[CompilerGenerated]
		private TreeListViewColumn Cma;

		[CompilerGenerated]
		private string qmi;

		internal static mM MXm;

		public TreeListViewColumn Column
		{
			[CompilerGenerated]
			get
			{
				return Cma;
			}
			[CompilerGenerated]
			private set
			{
				Cma = cma;
			}
		}

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return qmi;
			}
			[CompilerGenerated]
			private set
			{
				qmi = text;
			}
		}

		public mM(TreeListViewColumn P_0, string P_1)
		{
			fc.taYSkz();
			base._002Ector(NotifyCollectionChangedAction.Reset);
			Column = P_0;
			PropertyName = P_1;
		}

		internal static bool pXi()
		{
			return MXm == null;
		}

		internal static mM eXA()
		{
			return MXm;
		}
	}

	[CompilerGenerated]
	private EventHandler<NotifyCollectionChangedEventArgs> xES;

	internal static ug WsG;

	[SpecialName]
	[CompilerGenerated]
	internal void OE0(EventHandler<NotifyCollectionChangedEventArgs> P_0)
	{
		EventHandler<NotifyCollectionChangedEventArgs> eventHandler = xES;
		EventHandler<NotifyCollectionChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<NotifyCollectionChangedEventArgs> value = (EventHandler<NotifyCollectionChangedEventArgs>)Delegate.Combine(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref xES, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void LEA(EventHandler<NotifyCollectionChangedEventArgs> P_0)
	{
		EventHandler<NotifyCollectionChangedEventArgs> eventHandler = xES;
		EventHandler<NotifyCollectionChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<NotifyCollectionChangedEventArgs> value = (EventHandler<NotifyCollectionChangedEventArgs>)Delegate.Remove(eventHandler2, P_0);
			eventHandler = Interlocked.CompareExchange(ref xES, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void EEF()
	{
		using IEnumerator<TreeListViewColumn> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			TreeListViewColumn current = enumerator.Current;
			if (current != null)
			{
				current.lqI();
				OnCollectionChanged(new mM(current, xv.hTz(7256)));
			}
		}
	}

	private void sEc(object P_0, PropertyChangedEventArgs P_1)
	{
		if (P_0 is TreeListViewColumn treeListViewColumn)
		{
			OnCollectionChanged(new mM(treeListViewColumn, P_1.PropertyName));
		}
	}

	private void eEV(NotifyCollectionChangedEventArgs P_0)
	{
		xES?.Invoke(this, P_0);
	}

	private void AEf()
	{
		for (int num = base.Count - 1; num >= 0; num--)
		{
			base[num].Index = num;
		}
	}

	protected override void ClearItems()
	{
		using (IEnumerator<TreeListViewColumn> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TreeListViewColumn current = enumerator.Current;
				if (current != null)
				{
					current.PropertyChanged -= sEc;
				}
			}
		}
		base.ClearItems();
	}

	protected override void InsertItem(int P_0, TreeListViewColumn P_1)
	{
		if (P_1 != null)
		{
			P_1.PropertyChanged += sEc;
		}
		base.InsertItem(P_0, P_1);
	}

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs P_0)
	{
		AEf();
		base.OnCollectionChanged(P_0);
		if (P_0 != null && !(P_0 is mM))
		{
			eEV(P_0);
		}
	}

	protected override void RemoveItem(int P_0)
	{
		if (P_0 < base.Count)
		{
			TreeListViewColumn treeListViewColumn = base[P_0];
			if (treeListViewColumn != null)
			{
				treeListViewColumn.PropertyChanged -= sEc;
			}
		}
		base.RemoveItem(P_0);
	}

	protected override void SetItem(int P_0, TreeListViewColumn P_1)
	{
		if (P_0 < base.Count)
		{
			TreeListViewColumn treeListViewColumn = base[P_0];
			if (treeListViewColumn != null)
			{
				treeListViewColumn.PropertyChanged -= sEc;
			}
		}
		if (P_1 != null)
		{
			P_1.PropertyChanged += sEc;
		}
		base.SetItem(P_0, P_1);
	}

	public ug()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool ss0()
	{
		return WsG == null;
	}

	internal static ug ksj()
	{
		return WsG;
	}
}
