using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Data.Filtering;

namespace ActiproSoftware.Internal;

internal class oT
{
	[Flags]
	private enum dG
	{
		IsExpanded = 8
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public oT gTe;

		public PropertyChangedEventArgs TTr;

		internal static _003C_003Ec__DisplayClass29_0 PXL;

		public _003C_003Ec__DisplayClass29_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal void kTM()
		{
			gTe.JKU(TTr.PropertyName);
		}

		internal static bool wXB()
		{
			return PXL == null;
		}

		internal static _003C_003Ec__DisplayClass29_0 cXt()
		{
			return PXL;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public bool VTu;

		public oT ETO;

		private static _003C_003Ec__DisplayClass47_0 kX4;

		public _003C_003Ec__DisplayClass47_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal object sTG(oT n)
		{
			VTu |= n.MKg(TreeExpansionKind.Branch, ETO.hNX);
			return null;
		}

		internal static bool rXl()
		{
			return kX4 == null;
		}

		internal static _003C_003Ec__DisplayClass47_0 WXI()
		{
			return kX4;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public bool ATX;

		public oT zT2;

		internal static _003C_003Ec__DisplayClass56_0 uXY;

		public _003C_003Ec__DisplayClass56_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal object CTw(oT n)
		{
			ATX |= n.PKY(TreeExpansionKind.Branch, zT2.hNX);
			return null;
		}

		internal static bool TXM()
		{
			return uXY == null;
		}

		internal static _003C_003Ec__DisplayClass56_0 oXy()
		{
			return uXY;
		}
	}

	private IList<oT> cNG;

	private WeakReference zNu;

	private int? SNO;

	private dG ONw;

	private object hNX;

	private IEnumerable HN2;

	private TreeListBox jNv;

	private oT WN8;

	private static oT PsU;

	public bool IsEditable => jNv.ItemAdapter?.GetIsEditable(jNv, hNX) ?? false;

	public bool IsExpandable
	{
		get
		{
			if (hNX == null)
			{
				return false;
			}
			TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
			if (itemAdapter != null && itemAdapter.GetExpandability(jNv, hNX, LKi()) == TreeItemExpandability.Never)
			{
				return false;
			}
			TreeItemChildrenQueryMode treeItemChildrenQueryMode = TreeItemChildrenQueryMode.OnDisplay;
			if (itemAdapter != null)
			{
				treeItemChildrenQueryMode = itemAdapter.GetChildrenQueryMode(jNv, hNX);
			}
			if (treeItemChildrenQueryMode != TreeItemChildrenQueryMode.OnExpansion)
			{
				if (!oNP())
				{
					return qKB();
				}
				return true;
			}
			if (GKv() || itemAdapter.CanHaveChildren(jNv, hNX))
			{
				if (GKv() || IsExpanded)
				{
					if (oNP())
					{
						return true;
					}
					int num = 0;
					if (xsa() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					return num switch
					{
						_ => qKB(), 
					};
				}
				return true;
			}
			zK8(_0020: true);
			return false;
		}
	}

	public bool IsExpanded
	{
		get
		{
			return (ONw & dG.IsExpanded) == dG.IsExpanded;
		}
		set
		{
			IK5(flag, jNv.ItemAdapter, TreeExpansionKind.Single, hNX, null);
		}
	}

	public bool IsSelectable
	{
		get
		{
			if (!TN5())
			{
				IsSelectable = (jNv?.ItemAdapter)?.GetIsSelectable(jNv, hNX) ?? true;
			}
			return (ONw & (dG)64) == (dG)64;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						if ((ONw & (dG)64) == (dG)64 != flag)
						{
							if (!flag)
							{
								ONw &= (dG)(-65);
								IsSelected = false;
							}
							else
							{
								ONw |= (dG)64;
							}
							TreeListBoxItem treeListBoxItem = AKj();
							if (treeListBoxItem != null)
							{
								treeListBoxItem.IsSelectable = flag;
							}
						}
						return;
					}
					LNW(_0020: true);
					num2 = 0;
				}
				while (Vs5());
			}
		}
	}

	public bool IsSelected
	{
		get
		{
			return (ONw & (dG)128) == (dG)128;
		}
		set
		{
			if (lKW(flag, jNv.ItemAdapter))
			{
				if (flag)
				{
					jNv.o1O(this, _0020: true, _0020: false);
				}
				else
				{
					jNv.M13(this);
				}
			}
		}
	}

	public bool IsVisible
	{
		get
		{
			return (ONw & (dG)4) == (dG)4;
		}
		set
		{
			if (!flag)
			{
				ONw &= (dG)(-5);
			}
			else
			{
				ONw |= (dG)4;
			}
		}
	}

	public oT(TreeListBox P_0, oT P_1, object P_2)
	{
		fc.taYSkz();
		ONw = (dG)64;
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(9926));
		}
		jNv = P_0;
		WN8 = P_1;
		hNX = P_2;
		sC0(_0020: true);
	}

	private DataFilterResult SCf(TreeListBox P_0, object P_1)
	{
		return DataFilterResult.Included;
	}

	private void sC0(bool P_0)
	{
		if (hNX != null && hNX is INotifyPropertyChanged notifyPropertyChanged)
		{
			if (P_0)
			{
				notifyPropertyChanged.PropertyChanged += GK1;
			}
			else
			{
				notifyPropertyChanged.PropertyChanged -= GK1;
			}
		}
	}

	private void eCA(bool P_0)
	{
		if (HN2 != null && HN2 is INotifyCollectionChanged notifyCollectionChanged)
		{
			if (!P_0)
			{
				notifyCollectionChanged.CollectionChanged -= fKt;
			}
			else
			{
				notifyCollectionChanged.CollectionChanged += fKt;
			}
		}
	}

	[SpecialName]
	internal bool lKe()
	{
		if (!pKD() && IsEditable)
		{
			return jNv.w1F() == this;
		}
		return false;
	}

	internal void UC4()
	{
		if (!zKw())
		{
			uKX(_0020: true);
			sC0(_0020: false);
			eCA(_0020: false);
			IsSelectable = true;
			LNW(_0020: false);
			IsSelected = false;
			zN1(_0020: false);
			oK7(_0020: false);
			DNK(_0020: false);
			IsVisible = false;
		}
	}

	[SpecialName]
	internal tP HKG()
	{
		if ((ONw & (dG)2048) == (dG)2048)
		{
			if ((ONw & (dG)4096) == (dG)4096)
			{
				return (tP)1;
			}
			if ((ONw & (dG)8192) == (dG)8192)
			{
				return (tP)2;
			}
			return (tP)3;
		}
		return (tP)0;
	}

	[SpecialName]
	private void OKu(tP P_0)
	{
		switch (P_0)
		{
		default:
			ONw &= (dG)(-14337);
			break;
		case (tP)1:
		{
			ONw &= (dG)(-8193);
			int num = 0;
			if (!Vs5())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				ONw |= (dG)6144;
				break;
			}
			break;
		}
		case (tP)3:
			ONw &= (dG)(-12289);
			ONw |= (dG)2048;
			break;
		case (tP)2:
			ONw &= (dG)(-4097);
			ONw |= (dG)10240;
			break;
		}
	}

	private List<oT> RCS()
	{
		List<oT> list = new List<oT>();
		oT oT2 = tNd();
		while (oT2 != null && !oT2.HNU())
		{
			list.Add(oT2);
			oT2 = oT2.tNd();
		}
		return list;
	}

	private Pt LCz()
	{
		if (jNv.IsFilterActive)
		{
			TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
			if (itemAdapter != null)
			{
				return itemAdapter.Filter;
			}
		}
		return null;
	}

	internal oT hKI()
	{
		foreach (oT item in RCS())
		{
			if (item.IsVisible)
			{
				return item;
			}
		}
		return null;
	}

	internal oT sKP()
	{
		oT oT2 = this;
		for (oT oT3 = oT2; oT3 != null; oT3 = oT2.cNG?.LastOrDefault((oT n) => n.IsVisible))
		{
			oT2 = oT3;
		}
		return oT2;
	}

	[SpecialName]
	private bool zKw()
	{
		return (ONw & (dG)1) == (dG)1;
	}

	[SpecialName]
	private void uKX(bool P_0)
	{
		if (!P_0)
		{
			ONw &= (dG)(-2);
		}
		else
		{
			ONw |= (dG)1;
		}
	}

	[SpecialName]
	private bool GKv()
	{
		return (ONw & (dG)2) == (dG)2;
	}

	[SpecialName]
	private void zK8(bool P_0)
	{
		if (!P_0)
		{
			ONw &= (dG)(-3);
		}
		else
		{
			ONw |= (dG)2;
		}
	}

	private void GK1(object P_0, PropertyChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals6.gTe = this;
		CS_0024_003C_003E8__locals6.TTr = P_1;
		if (CS_0024_003C_003E8__locals6.TTr == null)
		{
			return;
		}
		if (jNv != null)
		{
			Dispatcher dispatcher = jNv.Dispatcher;
			if (dispatcher != null && !dispatcher.CheckAccess())
			{
				dispatcher.Invoke(DispatcherPriority.Send, (Action)delegate
				{
					CS_0024_003C_003E8__locals6.gTe.JKU(CS_0024_003C_003E8__locals6.TTr.PropertyName);
				});
				int num = 0;
				if (xsa() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				return;
			}
		}
		JKU(CS_0024_003C_003E8__locals6.TTr.PropertyName);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void fKt(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		ONw |= (dG)16;
		if (P_1 != null)
		{
			switch (P_1.Action)
			{
			case NotifyCollectionChangedAction.Add:
				if (P_1.NewItems != null)
				{
					if (cNG == null)
					{
						cNG = new List<oT>();
					}
					bool flag = IsExpanded && (IsVisible || HNU());
					int num = Math.Min(cNG.Count, P_1.NewStartingIndex);
					int num2 = 0;
					if (flag)
					{
						if (num == 0)
						{
							num2 = SNe() + 1;
						}
						else
						{
							oT oT3 = cNG[num - 1].sKP();
							if (oT3 != null)
							{
								num2 = oT3.SNe() + 1;
							}
						}
					}
					Pt pt = LCz();
					bool autoExpandItemsOnFilter = jNv.AutoExpandItemsOnFilter;
					foreach (object newItem in P_1.NewItems)
					{
						if (newItem != null)
						{
							oT oT4 = jNv.kPa(this, newItem, _0020: true, null);
							cNG.Insert(num++, oT4);
							oT4.yKC(pt, autoExpandItemsOnFilter);
							if (flag)
							{
								num2 = jNv.XPH(num2, oT4) + 1;
							}
						}
					}
				}
				LKK();
				return;
			case NotifyCollectionChangedAction.Move:
			{
				if (cNG == null || P_1.OldStartingIndex < 0 || P_1.OldStartingIndex >= cNG.Count || P_1.NewStartingIndex < 0 || P_1.NewStartingIndex >= cNG.Count || P_1.OldItems == null || P_1.OldItems.Count != 1 || P_1.NewItems == null || P_1.NewItems.Count != 1 || P_1.OldItems[0] != P_1.NewItems[0])
				{
					break;
				}
				oT oT5 = jNv.kPa(this, P_1.OldItems[0], _0020: false, null);
				if (oT5 != null && cNG[P_1.OldStartingIndex] == oT5)
				{
					cNG.RemoveAt(P_1.OldStartingIndex);
					cNG.Insert(P_1.NewStartingIndex, oT5);
					if (IsExpanded && (IsVisible || HNU()))
					{
						jNv.qP7(oT5, P_1.NewStartingIndex);
					}
					return;
				}
				break;
			}
			case NotifyCollectionChangedAction.Remove:
				if (P_1.OldItems != null)
				{
					foreach (object oldItem in P_1.OldItems)
					{
						if (oldItem != null)
						{
							oT oT2 = jNv.kPa(this, oldItem, _0020: false, null);
							if (oT2 != null)
							{
								cNG.Remove(oT2);
								jNv.U11(oT2, _0020: true, _0020: true, _0020: false);
							}
						}
					}
				}
				LKK();
				return;
			}
		}
		jNv.U11(this, _0020: true, _0020: false, _0020: true);
		tKp(fNY(), null);
		if (IsExpanded)
		{
			jNv.FPD(this);
		}
	}

	internal void JKU(string P_0)
	{
		TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
		if (itemAdapter == null)
		{
			return;
		}
		bool num = string.IsNullOrEmpty(P_0);
		if (num || P_0 == itemAdapter.SUl())
		{
			IK5(itemAdapter.GetIsExpanded(jNv, hNX), null, TreeExpansionKind.Single, hNX, null);
		}
		if ((num || P_0 == itemAdapter.mUE()) && GKv())
		{
			ONw |= (dG)16;
			NKn(itemAdapter.CanHaveChildren(jNv, hNX) ? itemAdapter.GetChildren(jNv, hNX) : null, _0020: false, null);
		}
		if (num || P_0 == itemAdapter.uUo())
		{
			IsSelectable = itemAdapter.GetIsSelectable(jNv, hNX);
		}
		if (num || P_0 == itemAdapter.FUk())
		{
			bool isSelected = itemAdapter.GetIsSelected(jNv, hNX);
			if (lKW(isSelected, null))
			{
				if (isSelected)
				{
					jNv.o1O(this, _0020: true, _0020: false);
				}
				else
				{
					jNv.M13(this);
				}
			}
		}
		if (num || P_0 == itemAdapter.VUK())
		{
			JKJ(itemAdapter.GetIsEditing(jNv, hNX), null);
		}
		if (num || P_0 == itemAdapter.pUm())
		{
			zN1(itemAdapter.GetIsLoading(jNv, hNX));
		}
	}

	internal bool PK6()
	{
		if (BNC())
		{
			ITreeItemVirtualPlaceholder treeItemVirtualPlaceholder = hNX as ITreeItemVirtualPlaceholder;
			int num = 0;
			if (xsa() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (treeItemVirtualPlaceholder != null && WN8 != null && WN8.fNY() is IList list && treeItemVirtualPlaceholder.Index < list.Count)
			{
				DNK(_0020: false);
				jNT(list[treeItemVirtualPlaceholder.Index]);
				jNv.S1q(this, treeItemVirtualPlaceholder);
				return true;
			}
		}
		return false;
	}

	private void qKq(tP P_0)
	{
		OKu(P_0);
		if (cNG == null)
		{
			return;
		}
		foreach (oT item in cNG)
		{
			item?.qKq(P_0);
		}
	}

	internal bool JKJ(bool P_0, TreeListBoxItemAdapter P_1)
	{
		if ((ONw & (dG)512) == (dG)512 == P_0)
		{
			return false;
		}
		if (!P_0)
		{
			ONw &= (dG)(-513);
		}
		else
		{
			ONw |= (dG)512;
		}
		jNv.mP9(this);
		P_1?.SetIsEditing(jNv, hNX, P_0);
		return true;
	}

	internal void IK5(bool P_0, TreeListBoxItemAdapter P_1, TreeExpansionKind P_2, object P_3, Queue<Tuple<oT, object>> P_4)
	{
		if ((ONw & dG.IsExpanded) == dG.IsExpanded == P_0)
		{
			return;
		}
		TreeListBoxItem treeListBoxItem = AKj();
		bool flag = HNU();
		if (!flag)
		{
			TreeListBoxItemExpansionEventArgs e = new TreeListBoxItemExpansionEventArgs(sNm(), AKj(), P_2, P_3);
			if (P_0)
			{
				jNv.U1l(e);
			}
			else
			{
				jNv.w1C(e);
			}
			if (e.Cancel)
			{
				if (treeListBoxItem != null)
				{
					treeListBoxItem.IsExpanded = !P_0;
				}
				return;
			}
		}
		if (P_0)
		{
			ONw |= dG.IsExpanded;
		}
		else
		{
			ONw &= ~dG.IsExpanded;
		}
		ONw &= (dG)(-17);
		if (treeListBoxItem != null)
		{
			treeListBoxItem.IsExpanded = P_0;
		}
		P_1?.SetIsExpanded(jNv, hNX, P_0);
		if ((ONw & (dG)16) != (dG)16)
		{
			if (P_0)
			{
				if (GKv())
				{
					jNv.FPD(this);
				}
				else
				{
					xKN(P_4);
				}
			}
			else
			{
				jNv.U11(this, _0020: false, _0020: false, _0020: false);
			}
		}
		if (!flag)
		{
			TreeListBoxItemExpansionEventArgs e2 = new TreeListBoxItemExpansionEventArgs(sNm(), AKj(), P_2, P_3);
			if (P_0)
			{
				jNv.J1N(e2);
			}
			else
			{
				jNv.D1E(e2);
			}
		}
	}

	internal bool lKW(bool P_0, TreeListBoxItemAdapter P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					if ((ONw & (dG)128) == (dG)128 != P_0)
					{
						if (P_0)
						{
							ONw |= (dG)128;
						}
						else
						{
							ONw &= (dG)(-129);
						}
						PK6();
						TreeListBoxItem treeListBoxItem = AKj();
						if (treeListBoxItem != null)
						{
							treeListBoxItem.IsSelected = P_0;
						}
						P_1?.SetIsSelected(jNv, hNX, P_0);
						return true;
					}
					break;
				default:
					return false;
				}
				num2 = 0;
			}
			while (xsa() == null);
		}
	}

	internal void NKn(IEnumerable P_0, bool P_1, Queue<Tuple<oT, object>> P_2)
	{
		if (!P_1 && HN2 == P_0)
		{
			return;
		}
		if (HN2 != null)
		{
			eCA(_0020: false);
			jNv.U11(this, _0020: true, _0020: false, _0020: false);
			tKp(null, P_2);
		}
		HN2 = P_0;
		if (HN2 != null)
		{
			eCA(_0020: true);
			tKp(P_0, P_2);
			if (IsVisible && IsExpanded)
			{
				jNv.FPD(this);
			}
		}
	}

	private void tKp(IEnumerable P_0, Queue<Tuple<oT, object>> P_1)
	{
		cNG = null;
		if (P_0 != null)
		{
			Pt pt = LCz();
			bool autoExpandItemsOnFilter = jNv.AutoExpandItemsOnFilter;
			if (P_0 is IList list && jNv.IsDataVirtualizationEnabled)
			{
				TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (cNG == null)
					{
						cNG = new List<oT>();
					}
					ITreeItemVirtualPlaceholder treeItemVirtualPlaceholder = itemAdapter?.CreateVirtualPlaceholder(jNv, hNX, i) ?? new Fl(i);
					oT oT2 = jNv.kPa(this, treeItemVirtualPlaceholder, _0020: true, P_1);
					oT2.DNK(_0020: true);
					cNG.Add(oT2);
					oT2.yKC(pt, autoExpandItemsOnFilter);
				}
			}
			else
			{
				foreach (object item in P_0)
				{
					if (cNG == null)
					{
						cNG = new List<oT>();
					}
					oT oT3 = jNv.kPa(this, item, _0020: true, P_1);
					cNG.Add(oT3);
					oT3.yKC(pt, autoExpandItemsOnFilter);
				}
			}
		}
		LKK();
	}

	internal void oKE()
	{
		yKC(LCz(), jNv.AutoExpandItemsOnFilter);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private bool yKC(Pt P_0, bool P_1)
	{
		bool flag = hNX == null && HNU();
		bool num = WKz();
		bool flag2 = P_0 != null;
		bool flag3 = false;
		if (!num)
		{
			if (!flag2)
			{
				return false;
			}
			vK0(IsExpanded);
		}
		else if (!flag2)
		{
			flag3 = true;
		}
		DataFilterResult dataFilterResult = ((flag2 && !flag) ? P_0(jNv, hNX) : DataFilterResult.Included);
		TreeItemChildrenQueryMode treeItemChildrenQueryMode = TreeItemChildrenQueryMode.OnDisplay;
		if (!flag)
		{
			TreeListBoxItemAdapter treeListBoxItemAdapter = ((jNv != null) ? jNv.ItemAdapter : null);
			if (treeListBoxItemAdapter != null)
			{
				treeItemChildrenQueryMode = treeListBoxItemAdapter.GetChildrenQueryMode(jNv, hNX);
			}
		}
		bool flag4 = treeItemChildrenQueryMode == TreeItemChildrenQueryMode.OnDisplay || (flag2 && P_1);
		bool flag5 = false;
		if (aKd(flag4))
		{
			switch (dataFilterResult)
			{
			case DataFilterResult.Included:
			case DataFilterResult.IncludedByDescendants:
				foreach (oT item in cNG)
				{
					if (item != null)
					{
						flag5 |= item.yKC(P_0, P_1);
					}
				}
				break;
			case DataFilterResult.IncludedWithDescendants:
				foreach (oT item2 in cNG)
				{
					if (item2 != null)
					{
						flag5 |= item2.yKC(SCf, P_1);
					}
				}
				break;
			default:
				if (!flag2)
				{
					break;
				}
				foreach (oT item3 in cNG)
				{
					item3?.qKq((tP)3);
				}
				break;
			}
		}
		bool flag6 = false;
		if (flag2)
		{
			if (dataFilterResult == DataFilterResult.Included || dataFilterResult == DataFilterResult.IncludedWithDescendants)
			{
				OKu((tP)1);
			}
			else if (dataFilterResult == DataFilterResult.IncludedByDescendants && flag5)
			{
				OKu((tP)2);
			}
			else
			{
				OKu((tP)3);
				flag6 = true;
			}
		}
		else
		{
			OKu((tP)0);
		}
		LKK();
		if (P_1)
		{
			if (flag2 && !flag6)
			{
				gKQ();
			}
			else if (flag3)
			{
				IsExpanded = DKf();
			}
		}
		return !flag6;
	}

	private void LKK()
	{
		bool isExpandable = IsExpandable;
		TreeListBoxItem treeListBoxItem = AKj();
		if (treeListBoxItem != null)
		{
			treeListBoxItem.IsExpandable = isExpandable;
		}
	}

	private void xKN(Queue<Tuple<oT, object>> P_0)
	{
		if (!GKv())
		{
			TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
			IEnumerable enumerable = ((itemAdapter != null && itemAdapter.CanHaveChildren(jNv, hNX)) ? itemAdapter.GetChildren(jNv, hNX) : null);
			zK8(_0020: true);
			NKn(enumerable, _0020: false, P_0);
		}
	}

	[SpecialName]
	public IList<oT> kK3()
	{
		return cNG ?? new oT[0];
	}

	public bool xKl()
	{
		return MKg(TreeExpansionKind.Single, hNX);
	}

	public bool MKg(TreeExpansionKind P_0, object P_1)
	{
		if (IsExpanded && IsExpandable)
		{
			IK5(_0020: false, jNv.ItemAdapter, P_0, P_1, null);
			return !IsExpanded;
		}
		return false;
	}

	public bool IKm()
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals5.ETO = this;
		CS_0024_003C_003E8__locals5.VTu = false;
		jNv.TP3(this, _0020: false, _0020: false, _0020: false, delegate(oT n)
		{
			CS_0024_003C_003E8__locals5.VTu |= n.MKg(TreeExpansionKind.Branch, CS_0024_003C_003E8__locals5.ETO.hNX);
			return (object)null;
		});
		return CS_0024_003C_003E8__locals5.VTu;
	}

	[SpecialName]
	public TreeListBoxItem AKj()
	{
		if (zNu != null)
		{
			if (zNu.IsAlive)
			{
				return zNu.Target as TreeListBoxItem;
			}
			zNu = null;
		}
		return null;
	}

	[SpecialName]
	public void aKx(TreeListBoxItem P_0)
	{
		zNu = ((P_0 != null) ? new WeakReference(P_0) : null);
	}

	[SpecialName]
	public int LKi()
	{
		if (!SNO.HasValue)
		{
			int num = -1;
			int num2 = 0;
			for (oT oT2 = WN8; oT2 != null; oT2 = oT2.tNd())
			{
				num2++;
				if (oT2.SNO.HasValue)
				{
					num = oT2.SNO.Value;
					break;
				}
			}
			SNO = num + num2;
		}
		return SNO.Value;
	}

	public void JKT()
	{
		jNv.RPL(this);
	}

	public bool SKo()
	{
		return PKY(TreeExpansionKind.Single, hNX);
	}

	public bool PKY(TreeExpansionKind P_0, object P_1)
	{
		if (!IsExpanded && IsExpandable)
		{
			IK5(_0020: true, jNv.ItemAdapter, P_0, P_1, null);
			return IsExpanded;
		}
		return false;
	}

	public bool JKk()
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals5.zT2 = this;
		CS_0024_003C_003E8__locals5.ATX = false;
		jNv.TP3(this, _0020: false, _0020: true, _0020: true, delegate(oT n)
		{
			CS_0024_003C_003E8__locals5.ATX |= n.PKY(TreeExpansionKind.Branch, CS_0024_003C_003E8__locals5.zT2.hNX);
			return (object)null;
		});
		return CS_0024_003C_003E8__locals5.ATX;
	}

	public bool gKQ()
	{
		bool flag = false;
		foreach (oT item in RCS())
		{
			flag |= item.SKo();
		}
		return flag;
	}

	[SpecialName]
	public string QKh()
	{
		TreeListBoxItemAdapter itemAdapter = jNv.ItemAdapter;
		if (itemAdapter == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		List<oT> list = RCS();
		string pathSeparator = jNv.PathSeparator;
		for (int num = list.Count - 1; num >= 0; num--)
		{
			stringBuilder.Append(itemAdapter.GetPath(jNv, list[num].sNm()));
			stringBuilder.Append(pathSeparator);
		}
		stringBuilder.Append(itemAdapter.GetPath(jNv, hNX));
		return stringBuilder.ToString();
	}

	public override int GetHashCode()
	{
		if (hNX == null)
		{
			return base.GetHashCode();
		}
		return hNX.GetHashCode();
	}

	public int fKy(int P_0)
	{
		if (P_0 >= 0 && P_0 < jNv.lt1().Count)
		{
			return jNv.lt1().vNb(this, P_0);
		}
		return kNR();
	}

	public bool aKd(bool P_0)
	{
		if (P_0 && !GKv())
		{
			xKN(null);
		}
		if (cNG == null)
		{
			return false;
		}
		return cNG.Any();
	}

	public bool qKB()
	{
		if (aKd(_0020: true))
		{
			if (!WKz())
			{
				return true;
			}
			if (cNG != null)
			{
				foreach (oT item in cNG)
				{
					if (item != null && !item.FK4())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	public void AKR()
	{
		zK8(_0020: false);
		NKn(null, _0020: false, null);
		LKK();
	}

	[SpecialName]
	public bool pKD()
	{
		return (ONw & (dG)512) == (dG)512;
	}

	[SpecialName]
	public void oK7(bool P_0)
	{
		JKJ(P_0, jNv.ItemAdapter);
	}

	[SpecialName]
	public bool DKf()
	{
		return (ONw & (dG)16384) == (dG)16384;
	}

	[SpecialName]
	public void vK0(bool P_0)
	{
		if ((ONw & (dG)16384) == (dG)16384 != P_0)
		{
			if (P_0)
			{
				ONw |= (dG)16384;
			}
			else
			{
				ONw &= (dG)(-16385);
			}
		}
	}

	[SpecialName]
	public bool FK4()
	{
		return HKG() == (tP)3;
	}

	[SpecialName]
	public bool WKz()
	{
		return (ONw & (dG)2048) == (dG)2048;
	}

	[SpecialName]
	public bool oNP()
	{
		return (ONw & (dG)256) == (dG)256;
	}

	[SpecialName]
	public void zN1(bool P_0)
	{
		if ((ONw & (dG)256) == (dG)256 == P_0)
		{
			return;
		}
		if (!P_0)
		{
			ONw &= (dG)(-257);
			if (!aKd(_0020: false))
			{
				IsExpanded = false;
			}
			LKK();
		}
		else
		{
			ONw |= (dG)256;
		}
	}

	[SpecialName]
	public bool HNU()
	{
		return WN8 == null;
	}

	[SpecialName]
	public bool TN5()
	{
		return (ONw & (dG)32) == (dG)32;
	}

	[SpecialName]
	public void LNW(bool P_0)
	{
		if ((ONw & (dG)32) == (dG)32 != P_0)
		{
			if (!P_0)
			{
				ONw &= (dG)(-33);
			}
			else
			{
				ONw |= (dG)32;
			}
		}
	}

	[SpecialName]
	public bool BNC()
	{
		return (ONw & (dG)1024) == (dG)1024;
	}

	[SpecialName]
	public void DNK(bool P_0)
	{
		if (P_0)
		{
			ONw |= (dG)1024;
		}
		else
		{
			ONw &= (dG)(-1025);
		}
	}

	[SpecialName]
	public object sNm()
	{
		return hNX;
	}

	[SpecialName]
	public void jNT(object P_0)
	{
		if (hNX != P_0)
		{
			if (hNX != null)
			{
				sC0(_0020: false);
			}
			hNX = P_0;
			if (hNX != null)
			{
				sC0(_0020: true);
			}
		}
	}

	[SpecialName]
	public IEnumerable fNY()
	{
		return HN2;
	}

	[SpecialName]
	public TreeListBox nNQ()
	{
		return jNv;
	}

	[SpecialName]
	public oT tNd()
	{
		return WN8;
	}

	public void CKM()
	{
		if (IsExpanded)
		{
			xKl();
		}
		else
		{
			SKo();
		}
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, xv.hTz(10112), new object[2]
		{
			LKi(),
			sNm()
		});
	}

	[SpecialName]
	public int kNR()
	{
		return jNv.lt1().GNi(this);
	}

	[SpecialName]
	public int SNe()
	{
		if (!IsVisible)
		{
			for (oT oT2 = WN8; oT2 != null; oT2 = oT2.tNd())
			{
				if (oT2.IsVisible)
				{
					return oT2.kNR();
				}
			}
		}
		return kNR();
	}

	internal static bool Vs5()
	{
		return PsU == null;
	}

	internal static oT xsa()
	{
		return PsU;
	}
}
