using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Controls.Grids.Primitives;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Grids;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
[ContentProperty("RootItem")]
[TemplatePart(Name = "PART_ScrollViewer", Type = typeof(ScrollViewer))]
public class TreeListBox : ItemsControl
{
	private enum Ik
	{
		Top = 1,
		Bottom = 3
	}

	private class PQ : IDisposable
	{
		private bool Blc;

		private HashSet<object> nlV;

		private TreeListBox olf;

		[CompilerGenerated]
		private int hl0;

		internal static PQ xcr;

		[SpecialName]
		internal bool jlZ()
		{
			return Blc;
		}

		[SpecialName]
		internal void XlH(bool P_0)
		{
			if (jlZ() != P_0)
			{
				Blc = P_0;
				if (!P_0)
				{
					olf.YtM.ENj();
				}
				else
				{
					olf.YtM.TN9();
				}
			}
		}

		internal PQ(TreeListBox P_0)
		{
			fc.taYSkz();
			nlV = new HashSet<object>();
			base._002Ector();
			olf = P_0;
			if (P_0.atB == null)
			{
				foreach (object selectedItem in P_0.SelectedItems)
				{
					if (selectedItem != null)
					{
						nlV.Add(selectedItem);
					}
				}
				P_0.atB = this;
			}
			PQ atB = P_0.atB;
			int num = atB.cl7();
			atB.Cls(num + 1);
		}

		internal PQ(TreeListBox P_0, object P_1)
		{
			fc.taYSkz();
			nlV = new HashSet<object>();
			base._002Ector();
			olf = P_0;
			if (P_1 != null)
			{
				nlV.Add(P_1);
			}
			P_0.atB = this;
			PQ atB = P_0.atB;
			int num = atB.cl7();
			atB.Cls(num + 1);
		}

		private void Dlh()
		{
			HashSet<object> hashSet = new HashSet<object>();
			HashSet<object> hashSet2 = new HashSet<object>();
			HashSet<object> hashSet3 = new HashSet<object>();
			foreach (object selectedItem in olf.SelectedItems)
			{
				if (selectedItem != null)
				{
					hashSet3.Add(selectedItem);
					if (!nlV.Contains(selectedItem))
					{
						hashSet.Add(selectedItem);
					}
				}
			}
			foreach (object item in nlV)
			{
				if (item != null && !hashSet3.Contains(item))
				{
					hashSet2.Add(item);
				}
			}
			if (hashSet.Count + hashSet2.Count > 0)
			{
				olf.D1o(hashSet2.ToArray(), hashSet.ToArray());
			}
		}

		[SpecialName]
		[CompilerGenerated]
		private int cl7()
		{
			return hl0;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Cls(int P_0)
		{
			hl0 = P_0;
		}

		public void Dispose()
		{
			XlH(_0020: false);
			PQ atB = olf.atB;
			atB.Cls(Math.Max(0, atB.cl7() - 1));
			if (atB.cl7() == 0)
			{
				olf.atB = null;
				atB.Dlh();
			}
		}

		internal static bool Acd()
		{
			return xcr == null;
		}

		internal static PQ xcN()
		{
			return xcr;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public oT dl4;

		private static _003C_003Ec__DisplayClass49_0 Fc3;

		public _003C_003Ec__DisplayClass49_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool slA(oT n)
		{
			return n.tNd() == dl4;
		}

		internal static bool GcT()
		{
			return Fc3 == null;
		}

		internal static _003C_003Ec__DisplayClass49_0 Dc7()
		{
			return Fc3;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public object olz;

		internal static _003C_003Ec__DisplayClass51_0 wcO;

		public _003C_003Ec__DisplayClass51_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal oT qlS(oT n)
		{
			if (n.sNm() != olz)
			{
				return null;
			}
			return n;
		}

		internal static bool vcD()
		{
			return wcO == null;
		}

		internal static _003C_003Ec__DisplayClass51_0 scb()
		{
			return wcO;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public TreeListBox DgI;

		public TreeListBoxItemAdapter ugP;

		internal static _003C_003Ec__DisplayClass52_0 ocz;

		public _003C_003Ec__DisplayClass52_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal static bool xRQ()
		{
			return ocz == null;
		}

		internal static _003C_003Ec__DisplayClass52_0 NRW()
		{
			return ocz;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_1
	{
		public string Egt;

		public _003C_003Ec__DisplayClass52_0 DgU;

		private static _003C_003Ec__DisplayClass52_1 FRC;

		public _003C_003Ec__DisplayClass52_1()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool Cg1(oT n)
		{
			return DgU.ugP.GetPath(DgU.DgI, n.sNm()) == Egt;
		}

		internal static bool QR6()
		{
			return FRC == null;
		}

		internal static _003C_003Ec__DisplayClass52_1 bRF()
		{
			return FRC;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public bool ygq;

		public TreeListBox vgJ;

		public oT Lg5;

		public object pgW;

		internal static _003C_003Ec__DisplayClass69_0 xRs;

		public _003C_003Ec__DisplayClass69_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal void tg6()
		{
			if (ygq)
			{
				oT oT = vgJ.pPb(pgW, _0020: false, null);
				if (oT != null)
				{
					Lg5 = oT;
				}
			}
			vgJ.j1Q(Lg5, (UC)0);
		}

		internal static bool URc()
		{
			return xRs == null;
		}

		internal static _003C_003Ec__DisplayClass69_0 LRR()
		{
			return xRs;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public TreeListBox Jgp;

		public int WgE;

		private static _003C_003Ec__DisplayClass70_0 aRX;

		public _003C_003Ec__DisplayClass70_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal void Vgn()
		{
			if (Jgp.dtl == WgE)
			{
				Jgp.tPX();
			}
		}

		internal static bool XR9()
		{
			return aRX == null;
		}

		internal static _003C_003Ec__DisplayClass70_0 uR8()
		{
			return aRX;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public TreeListBox ggN;

		public List<oT> vgl;

		public int Kgg;

		public int Fgm;

		public int vgT;

		private static _003C_003Ec__DisplayClass80_0 LRk;

		public _003C_003Ec__DisplayClass80_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool egC(int currentIndex)
		{
			if (Kgg != -1)
			{
				ggN.otY.cND(Kgg, currentIndex - Kgg);
				Fgm = Kgg;
				Kgg = -1;
				return true;
			}
			return false;
		}

		internal bool DgK(int currentIndex)
		{
			if (vgT != -1)
			{
				ggN.otY.JNH(Fgm, vgl.Skip(vgT).Take(currentIndex - vgT));
				Fgm += currentIndex - vgT;
				vgT = -1;
				return true;
			}
			return false;
		}

		internal static bool RRm()
		{
			return LRk == null;
		}

		internal static _003C_003Ec__DisplayClass80_0 KRi()
		{
			return LRk;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass253_0
	{
		public object QgM;

		internal static _003C_003Ec__DisplayClass253_0 ORE;

		public _003C_003Ec__DisplayClass253_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool agR(object i)
		{
			return i != QgM;
		}

		internal static bool VRg()
		{
			return ORE == null;
		}

		internal static _003C_003Ec__DisplayClass253_0 mRP()
		{
			return ORE;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass260_0
	{
		public TreeListBoxItemAdapter Tgr;

		public TreeListBox xgG;

		internal static _003C_003Ec__DisplayClass260_0 nRh;

		public _003C_003Ec__DisplayClass260_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool fge(object i)
		{
			return Tgr.GetIsSelected(xgG, i);
		}

		internal static bool jRu()
		{
			return nRh == null;
		}

		internal static _003C_003Ec__DisplayClass260_0 IRq()
		{
			return nRh;
		}
	}

	private WeakReference atE;

	private bool PtC;

	private WeakReference otK;

	private DateTime utN;

	private int dtl;

	private Dictionary<object, IList<oT>> Atg;

	private oT Xtm;

	private ScrollViewer qtT;

	private EN uto;

	private TreeNodeItemCollection otY;

	public static readonly DependencyProperty AutoExpandItemsOnFilterProperty;

	public static readonly DependencyProperty CanDragItemsProperty;

	public static readonly DependencyProperty DataFilterProperty;

	public static readonly DependencyProperty EmptyContentProperty;

	public static readonly DependencyProperty EmptyContentTemplateProperty;

	public static readonly DependencyProperty IndentIncrementProperty;

	public static readonly DependencyProperty IsDataVirtualizationEnabledProperty;

	public static readonly DependencyProperty IsEmptyProperty;

	public static readonly DependencyProperty IsFilterActiveProperty;

	public static readonly DependencyProperty IsRootItemVisibleProperty;

	public static readonly DependencyProperty ItemAdapterProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	public static readonly DependencyProperty MultiDragKindProperty;

	public static readonly DependencyProperty PathSeparatorProperty;

	public static readonly DependencyProperty RootItemProperty;

	public static readonly DependencyProperty TopLevelIndentProperty;

	public const string ItemDataFormat = "ActiproSoftware.TreeListBox.Items";

	public static readonly RoutedEvent IsRootItemVisibleChangedEvent;

	public static readonly RoutedEvent ItemCollapsedEvent;

	public static readonly RoutedEvent ItemCollapsingEvent;

	public static readonly RoutedEvent ItemDefaultActionExecutingEvent;

	public static readonly RoutedEvent ItemExpandedEvent;

	public static readonly RoutedEvent ItemExpandingEvent;

	public static readonly RoutedEvent ItemMenuRequestedEvent;

	public static readonly RoutedEvent ItemSelectingEvent;

	public static readonly RoutedEvent RootItemChangedEvent;

	public static readonly RoutedEvent SelectionChangedEvent;

	private WeakReference Ktk;

	private UC btQ;

	private bool nty;

	private bool mtd;

	private PQ atB;

	private WeakReference ytR;

	private TreeNodeItemCollection YtM;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	public static readonly DependencyProperty MultiSelectionKindProperty;

	public static readonly DependencyProperty SelectionModeProperty;

	public static readonly DependencyProperty SelectedItemProperty;

	private bool nte;

	private bool jtr;

	private DependencyProperty ltG;

	private bool ctu;

	private static readonly DependencyPropertyKey ytO;

	public static readonly DependencyProperty HasTreeLinesProperty;

	public static readonly DependencyProperty IsSelectionActiveProperty;

	private static TreeListBox GWC;

	public bool AutoExpandItemsOnFilter
	{
		get
		{
			return (bool)GetValue(AutoExpandItemsOnFilterProperty);
		}
		set
		{
			SetValue(AutoExpandItemsOnFilterProperty, value);
		}
	}

	public bool CanDragItems
	{
		get
		{
			return (bool)GetValue(CanDragItemsProperty);
		}
		set
		{
			SetValue(CanDragItemsProperty, value);
		}
	}

	protected virtual bool CanExpandAll => true;

	public IDataFilter DataFilter
	{
		get
		{
			return (IDataFilter)GetValue(DataFilterProperty);
		}
		set
		{
			SetValue(DataFilterProperty, value);
		}
	}

	public object EmptyContent
	{
		get
		{
			return GetValue(EmptyContentProperty);
		}
		set
		{
			SetValue(EmptyContentProperty, value);
		}
	}

	public DataTemplate EmptyContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(EmptyContentTemplateProperty);
		}
		set
		{
			SetValue(EmptyContentTemplateProperty, value);
		}
	}

	public double IndentIncrement
	{
		get
		{
			return (double)GetValue(IndentIncrementProperty);
		}
		set
		{
			SetValue(IndentIncrementProperty, value);
		}
	}

	public bool IsDataVirtualizationEnabled
	{
		get
		{
			return (bool)GetValue(IsDataVirtualizationEnabledProperty);
		}
		set
		{
			SetValue(IsDataVirtualizationEnabledProperty, value);
		}
	}

	public bool IsEmpty
	{
		get
		{
			return (bool)GetValue(IsEmptyProperty);
		}
		private set
		{
			SetValue(IsEmptyProperty, value);
		}
	}

	public bool IsFilterActive
	{
		get
		{
			return (bool)GetValue(IsFilterActiveProperty);
		}
		set
		{
			SetValue(IsFilterActiveProperty, value);
		}
	}

	protected virtual bool IsKeyboardFocusWithinContent => base.IsKeyboardFocusWithin;

	public bool IsRootItemVisible
	{
		get
		{
			return (bool)GetValue(IsRootItemVisibleProperty);
		}
		set
		{
			SetValue(IsRootItemVisibleProperty, value);
		}
	}

	public TreeListBoxItemAdapter ItemAdapter
	{
		get
		{
			return (TreeListBoxItemAdapter)GetValue(ItemAdapterProperty);
		}
		set
		{
			SetValue(ItemAdapterProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	public TreeMultiDragKind MultiDragKind
	{
		get
		{
			return (TreeMultiDragKind)GetValue(MultiDragKindProperty);
		}
		set
		{
			SetValue(MultiDragKindProperty, value);
		}
	}

	public string PathSeparator
	{
		get
		{
			return (string)GetValue(PathSeparatorProperty);
		}
		set
		{
			SetValue(PathSeparatorProperty, value);
		}
	}

	public object RootItem
	{
		get
		{
			return GetValue(RootItemProperty);
		}
		set
		{
			SetValue(RootItemProperty, value);
		}
	}

	public double TopLevelIndent
	{
		get
		{
			return (double)GetValue(TopLevelIndentProperty);
		}
		set
		{
			SetValue(TopLevelIndentProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	public TreeMultiSelectionKind MultiSelectionKind
	{
		get
		{
			return (TreeMultiSelectionKind)GetValue(MultiSelectionKindProperty);
		}
		set
		{
			SetValue(MultiSelectionKindProperty, value);
		}
	}

	public SelectionMode SelectionMode
	{
		get
		{
			return (SelectionMode)GetValue(SelectionModeProperty);
		}
		set
		{
			SetValue(SelectionModeProperty, value);
		}
	}

	public object SelectedItem
	{
		get
		{
			return GetValue(SelectedItemProperty);
		}
		set
		{
			SetValue(SelectedItemProperty, value);
		}
	}

	public ISelectedTreeItemCollection SelectedItems => YtM;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected virtual ActiproSoftware.Products.AssemblyInfo AssemblyInfo => null;

	public bool HasTreeLines
	{
		get
		{
			return (bool)GetValue(HasTreeLinesProperty);
		}
		set
		{
			SetValue(HasTreeLinesProperty, value);
		}
	}

	public event RoutedEventHandler IsRootItemVisibleChanged
	{
		add
		{
			AddHandler(IsRootItemVisibleChangedEvent, value);
		}
		remove
		{
			RemoveHandler(IsRootItemVisibleChangedEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemExpansionEventArgs> ItemCollapsed
	{
		add
		{
			AddHandler(ItemCollapsedEvent, value);
		}
		remove
		{
			RemoveHandler(ItemCollapsedEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemExpansionEventArgs> ItemCollapsing
	{
		add
		{
			AddHandler(ItemCollapsingEvent, value);
		}
		remove
		{
			RemoveHandler(ItemCollapsingEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemEventArgs> ItemDefaultActionExecuting
	{
		add
		{
			AddHandler(ItemDefaultActionExecutingEvent, value);
		}
		remove
		{
			RemoveHandler(ItemDefaultActionExecutingEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemExpansionEventArgs> ItemExpanded
	{
		add
		{
			AddHandler(ItemExpandedEvent, value);
		}
		remove
		{
			RemoveHandler(ItemExpandedEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemExpansionEventArgs> ItemExpanding
	{
		add
		{
			AddHandler(ItemExpandingEvent, value);
		}
		remove
		{
			RemoveHandler(ItemExpandingEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemMenuEventArgs> ItemMenuRequested
	{
		add
		{
			AddHandler(ItemMenuRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(ItemMenuRequestedEvent, value);
		}
	}

	public event EventHandler<TreeListBoxItemEventArgs> ItemSelecting
	{
		add
		{
			AddHandler(ItemSelectingEvent, value);
		}
		remove
		{
			RemoveHandler(ItemSelectingEvent, value);
		}
	}

	public event RoutedEventHandler RootItemChanged
	{
		add
		{
			AddHandler(RootItemChangedEvent, value);
		}
		remove
		{
			RemoveHandler(RootItemChangedEvent, value);
		}
	}

	public event SelectionChangedEventHandler SelectionChanged
	{
		add
		{
			AddHandler(SelectionChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectionChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public TreeListBox()
	{
		fc.taYSkz();
		utN = DateTime.Now;
		Atg = new Dictionary<object, IList<oT>>();
		btQ = (UC)1;
		YtM = new TreeNodeItemCollection(useHashSet: true);
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListBox);
		ptt(new TreeNodeItemCollection(useHashSet: false));
		WPv();
		object assemblyInfo = x1Z();
		base.ItemContainerGenerator.StatusChanged += I17;
		if (assemblyInfo == null)
		{
			assemblyInfo = ActiproSoftware.Products.Grids.AssemblyInfo.Instance;
		}
		ActiproLicenseValidator.ValidateLicense((ActiproSoftware.Products.AssemblyInfo)assemblyInfo, GetType(), this);
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[SpecialName]
	internal oT w1F()
	{
		if (atE != null)
		{
			if (atE.IsAlive)
			{
				return atE.Target as oT;
			}
			atE = null;
		}
		return Xtm.kK3().FirstOrDefault();
	}

	[SpecialName]
	internal void h1c(oT value)
	{
		atE = ((value != null) ? new WeakReference(value) : null);
	}

	private void tPX()
	{
		if (Xtm == null)
		{
			return;
		}
		oT oT = w1F();
		bool num = Xtm.WKz();
		Xtm.oKE();
		if (num || Xtm.WKz())
		{
			W15();
			if (oT != null)
			{
				RP2(oT);
			}
		}
	}

	private bool RP2(oT P_0)
	{
		int num;
		if (!P_0.gKQ())
		{
			if (!PtC)
			{
				num = 1;
				if (FWF() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			goto IL_001b;
		}
		goto IL_0038;
		IL_0038:
		UpdateLayout();
		goto IL_001b;
		IL_001b:
		TreeListBoxItem treeListBoxItem = P_0.AKj();
		num = 0;
		if (FWF() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			if (treeListBoxItem != null)
			{
				treeListBoxItem.BringIntoView();
				return true;
			}
			if (qtT != null && otY.Count > 0)
			{
				int num3 = P_0.kNR();
				if (num3 != -1)
				{
					Tuple<int, int, int, int> tuple = UPi();
					int item = tuple.Item1;
					int item2 = tuple.Item2;
					int item3 = tuple.Item3;
					int item4 = tuple.Item4;
					if (num3 >= item3)
					{
						if (num3 <= item4)
						{
							return true;
						}
						num3 = Math.Max(0, num3 - item + 1);
					}
					num3 = Math.Max(0, num3 - item2);
					qtT.ScrollToVerticalOffset(num3);
					qtT.UpdateLayout();
					return true;
				}
			}
			return false;
		}
		goto IL_0038;
	}

	private void WPv()
	{
		Xtm = new oT(this, null, null);
		Xtm.IsVisible = true;
		Xtm.IsExpanded = true;
	}

	internal void FP8(oT P_0)
	{
		object obj = P_0.sNm();
		if (obj != null && Atg.TryGetValue(obj, out var value))
		{
			if (value.IsReadOnly)
			{
				if (value[0] == P_0)
				{
					Atg.Remove(obj);
				}
			}
			else if (value.Remove(P_0) && !value.Any())
			{
				int num = 0;
				if (!BW6())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Atg.Remove(obj);
			}
			if (P_0.aKd(_0020: false))
			{
				foreach (oT item in P_0.kK3())
				{
					FP8(item);
				}
			}
		}
		P_0.UC4();
	}

	[SpecialName]
	internal oT R1f()
	{
		if (otK != null)
		{
			if (otK.IsAlive)
			{
				return otK.Target as oT;
			}
			otK = null;
		}
		return null;
	}

	[SpecialName]
	internal void H10(oT value)
	{
		otK = ((value != null) ? new WeakReference(value) : null);
	}

	internal void mP9(oT P_0)
	{
		if (P_0 != null && jPj(P_0) == (Ik)0)
		{
			RP2(P_0);
		}
	}

	internal F1 TP3<F1>(oT P_0, bool P_1, bool P_2, bool P_3, Func<oT, F1> P_4) where F1 : class
	{
		if (P_4 == null)
		{
			throw new ArgumentNullException(xv.hTz(3292));
		}
		if (otY.Count == 0)
		{
			return null;
		}
		oT oT = null;
		if (P_0 != null)
		{
			yo yo = new yo(P_0);
			yo.ul5(_0020: false, _0020: false);
			oT = yo.Nln();
		}
		oT oT2 = null;
		P_0 = P_0 ?? otY.uNx(0);
		yo yo2 = new yo(P_0);
		List<oT> list = (P_3 ? new List<oT>() : null);
		while (yo2.Nln() != oT2)
		{
			oT2 = yo2.Nln();
			if (P_3)
			{
				list.Add(yo2.Nln());
			}
			else
			{
				F1 val = P_4(yo2.Nln());
				if (val != null)
				{
					return val;
				}
			}
			if (P_1)
			{
				yo2.GoToNextVisible();
			}
			else
			{
				yo2.ul5(_0020: true, yo2.Depth < 100 && P_2);
			}
			if (oT != null && yo2.Nln() == oT)
			{
				break;
			}
		}
		if (P_3)
		{
			for (int num = list.Count - 1; num >= 0; num--)
			{
				F1 val2 = P_4(list[num]);
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		return null;
	}

	internal void RPL(oT P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3304));
		}
		TreeListBoxItemEventArgs e = new TreeListBoxItemEventArgs(P_0.sNm(), P_0.AKj());
		H1K(e);
		if (e.Cancel)
		{
			return;
		}
		TreeListBoxItem treeListBoxItem = P_0.AKj();
		if (treeListBoxItem != null)
		{
			ICommand defaultActionCommand = treeListBoxItem.DefaultActionCommand;
			if (defaultActionCommand != null)
			{
				if (defaultActionCommand.CanExecute(P_0.sNm()))
				{
					int num = 0;
					if (FWF() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					defaultActionCommand.Execute(P_0.sNm());
				}
				return;
			}
		}
		P_0.CKM();
	}

	private Ik jPj(oT P_0)
	{
		if (qtT != null && otY.Count > 0)
		{
			Tuple<int, int, int, int> tuple = UPi();
			int item = tuple.Item3;
			int item2 = tuple.Item4;
			for (int i = item; i <= item2; i++)
			{
				if (otY.uNx(i) == P_0)
				{
					if (i == item)
					{
						return Ik.Top;
					}
					if (i == item2)
					{
						return Ik.Bottom;
					}
					return (Ik)2;
				}
			}
		}
		return (Ik)0;
	}

	private IList<object> MPx()
	{
		if (!CanDragItems || YtM.Count == 0)
		{
			return null;
		}
		oT[] array = YtM.PNs();
		TreeListBoxItemAdapter itemAdapter = ItemAdapter;
		if (itemAdapter != null)
		{
			oT[] array2 = array;
			foreach (oT oT in array2)
			{
				if (!itemAdapter.GetIsDraggable(this, oT.sNm()))
				{
					return null;
				}
			}
		}
		if (array.Length > 1)
		{
			oT oT2 = w1F();
			oT oT3 = ((oT2 != null && array.Contains(oT2)) ? oT2 : array[0]);
			switch (MultiDragKind)
			{
			case TreeMultiDragKind.SameDepth:
			{
				oT[] array2 = array;
				foreach (oT oT5 in array2)
				{
					if (oT5 != oT3 && oT5.LKi() != oT3.LKi())
					{
						return null;
					}
				}
				break;
			}
			case TreeMultiDragKind.SameType:
			{
				oT[] array2 = array;
				foreach (oT oT6 in array2)
				{
					if (oT6 != oT3 && oT6.sNm().GetType() != oT3.sNm().GetType())
					{
						return null;
					}
				}
				break;
			}
			case TreeMultiDragKind.Siblings:
			{
				oT[] array2 = array;
				foreach (oT oT4 in array2)
				{
					if (oT4 != oT3 && oT4.tNd() != oT3.tNd())
					{
						return null;
					}
				}
				break;
			}
			default:
				return null;
			case TreeMultiDragKind.Any:
				break;
			}
		}
		return YtM.ToArray();
	}

	internal oT kPa(oT P_0, object P_1, bool P_2, Queue<Tuple<oT, object>> P_3)
	{
		_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass49_0();
		CS_0024_003C_003E8__locals4.dl4 = P_0;
		if (CS_0024_003C_003E8__locals4.dl4 == null)
		{
			throw new ArgumentNullException(xv.hTz(3324));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(xv.hTz(3356));
		}
		if (Atg.TryGetValue(P_1, out var value))
		{
			oT oT = value.FirstOrDefault((oT n) => n.tNd() == CS_0024_003C_003E8__locals4.dl4);
			if (oT != null)
			{
				return oT;
			}
		}
		if (P_2)
		{
			oT oT = new oT(this, CS_0024_003C_003E8__locals4.dl4, P_1);
			if (value != null)
			{
				if (value.IsReadOnly)
				{
					value = new List<oT>(value);
					Atg[P_1] = value;
				}
				value.Add(oT);
			}
			else
			{
				Atg[P_1] = new oT[1] { oT };
			}
			TreeListBoxItemAdapter itemAdapter = ItemAdapter;
			if (itemAdapter != null)
			{
				if (itemAdapter.GetIsExpanded(this, P_1))
				{
					if (!oT.IsExpanded)
					{
						if (P_3 != null)
						{
							Tuple<oT, object> tuple = ((P_3.Count > 0) ? P_3.Peek() : null);
							if (tuple == null || tuple.Item1 != oT)
							{
								P_3.Enqueue(Tuple.Create(oT, P_1));
							}
						}
						else
						{
							P_3 = new Queue<Tuple<oT, object>>();
							oT.IK5(_0020: true, null, TreeExpansionKind.Single, P_1, P_3);
							while (P_3.Count > 0)
							{
								Tuple<oT, object> tuple2 = P_3.Peek();
								tuple2.Item1.IK5(_0020: true, null, TreeExpansionKind.Single, tuple2.Item2, P_3);
								P_3.Dequeue();
							}
						}
					}
				}
				else
				{
					oT.IK5(_0020: false, null, TreeExpansionKind.Single, P_1, P_3);
				}
				if (nty && otY != null && !otY.VNc() && itemAdapter.GetIsSelected(this, P_1))
				{
					oT.IsSelected = true;
				}
			}
			return oT;
		}
		return null;
	}

	private Tuple<int, int, int, int> UPi()
	{
		int num = (int)qtT.ViewportHeight;
		int num2 = 0;
		int num3 = Math.Max(0, Math.Min(otY.Count - 1, (int)qtT.VerticalOffset + num2));
		int item = Math.Max(num3, Math.Min(otY.Count - 1, num3 + num - 1));
		return Tuple.Create(num, num2, num3, item);
	}

	internal oT pPb(object P_0, bool P_1, Func<oT, bool> P_2)
	{
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals4.olz = P_0;
		if (CS_0024_003C_003E8__locals4.olz == null)
		{
			throw new ArgumentNullException(xv.hTz(3356));
		}
		if (Atg.TryGetValue(CS_0024_003C_003E8__locals4.olz, out var value))
		{
			oT oT = ((P_2 != null) ? value.FirstOrDefault(P_2) : value.FirstOrDefault());
			if (oT != null)
			{
				return oT;
			}
		}
		if (P_1)
		{
			oT oT2 = TP3(null, _0020: false, _0020: true, _0020: false, (oT n) => (n.sNm() != CS_0024_003C_003E8__locals4.olz) ? null : n);
			if (oT2 != null)
			{
				return oT2;
			}
		}
		return null;
	}

	internal oT uPh(string P_0)
	{
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
		_003C_003Ec__DisplayClass52_.DgI = this;
		string pathSeparator = PathSeparator;
		if (!string.IsNullOrEmpty(P_0) && !string.IsNullOrEmpty(pathSeparator))
		{
			_003C_003Ec__DisplayClass52_.ugP = ItemAdapter;
			if (_003C_003Ec__DisplayClass52_.ugP != null)
			{
				oT oT = Xtm;
				string[] array = P_0.Split(new string[1] { pathSeparator }, StringSplitOptions.None);
				int num = 0;
				int num3 = default(int);
				while (num < array.Length)
				{
					_003C_003Ec__DisplayClass52_1 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass52_1();
					CS_0024_003C_003E8__locals5.DgU = _003C_003Ec__DisplayClass52_;
					CS_0024_003C_003E8__locals5.Egt = array[num];
					int num2 = 1;
					if (FWF() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
					IL_0005:
					num2 = num3;
					goto IL_0009;
					IL_0009:
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						default:
							goto end_IL_0009;
						}
						if (!oT.aKd(_0020: true))
						{
							goto end_IL_0027;
						}
						oT = oT.kK3().FirstOrDefault((oT n) => CS_0024_003C_003E8__locals5.DgU.ugP.GetPath(CS_0024_003C_003E8__locals5.DgU.DgI, n.sNm()) == CS_0024_003C_003E8__locals5.Egt);
						if (oT == null)
						{
							goto end_IL_0027;
						}
						num2 = 0;
						if (BW6())
						{
							continue;
						}
						goto IL_0005;
						continue;
						end_IL_0009:
						break;
					}
					num++;
					continue;
					end_IL_0027:
					break;
				}
				return oT;
			}
		}
		return null;
	}

	private static int nPZ(List<oT> P_0, int P_1, oT P_2)
	{
		P_2.IsVisible = true;
		P_0.Add(P_2);
		if (P_2.IsExpanded && P_2.aKd(_0020: true))
		{
			Stack<IEnumerator<oT>> stack = new Stack<IEnumerator<oT>>();
			stack.Push(P_2.kK3().GetEnumerator());
			while (stack.Count > 0)
			{
				IEnumerator<oT> enumerator = stack.Peek();
				if (enumerator.MoveNext())
				{
					P_2 = enumerator.Current;
					if (!P_2.FK4())
					{
						P_2.IsVisible = true;
						P_0.Add(P_2);
						P_1++;
						if (P_2.IsExpanded && P_2.aKd(_0020: true))
						{
							stack.Push(P_2.kK3().GetEnumerator());
						}
					}
				}
				else
				{
					stack.Pop();
				}
			}
		}
		return P_1;
	}

	internal int XPH(int P_0, oT P_1)
	{
		if (P_1.FK4())
		{
			return P_0 - 1;
		}
		d1b();
		List<oT> list = new List<oT>();
		int result = nPZ(list, P_0, P_1);
		otY.JNH(P_0, list);
		return result;
	}

	internal void FPD(oT P_0)
	{
		if (!P_0.IsVisible || !P_0.aKd(_0020: false))
		{
			return;
		}
		d1b();
		int num = P_0.kNR() + 1;
		List<oT> list = new List<oT>();
		int num2 = 0;
		if (FWF() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		int num4 = num;
		foreach (oT item in P_0.kK3())
		{
			if (!item.FK4())
			{
				num4 = nPZ(list, num4, item) + 1;
			}
		}
		otY.JNH(num, list);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal void qP7(oT P_0, int P_1)
	{
		using (new PQ(this))
		{
			if (!P_0.IsVisible)
			{
				return;
			}
			int num = P_0.kNR();
			int num2 = P_0.sKP().fKy(num);
			if (num < 0 || num > num2)
			{
				return;
			}
			bool isKeyboardFocusWithinContent = IsKeyboardFocusWithinContent;
			oT oT = w1F();
			oT oT2 = null;
			for (int i = num; i <= num2; i++)
			{
				oT oT3 = otY.uNx(i);
				if (oT == oT3)
				{
					oT2 = oT3;
				}
			}
			otY.cND(num, num2 - num + 1);
			int num3 = P_0.tNd().kNR() + 1;
			oT oT4 = default(oT);
			int num4;
			if (P_1 > 0)
			{
				oT4 = P_0.tNd().kK3()[P_1 - 1];
				num4 = 1;
				if (!BW6())
				{
					num4 = 0;
				}
				goto IL_0028;
			}
			goto IL_015d;
			IL_0028:
			while (true)
			{
				switch (num4)
				{
				case 2:
					if (isKeyboardFocusWithinContent)
					{
						j1Q(oT2, (UC)0);
					}
					return;
				default:
					goto IL_0115;
				case 1:
					break;
				}
				break;
				IL_0115:
				h1c(oT2);
				num4 = 2;
			}
			if (oT4 != null)
			{
				num3 = oT4.sKP().fKy(num3) + 1;
			}
			goto IL_015d;
			IL_015d:
			XPH(num3, P_0);
			if (oT2 == null)
			{
				return;
			}
			num4 = 0;
			if (!BW6())
			{
				int num5 = default(int);
				num4 = num5;
			}
			goto IL_0028;
		}
	}

	internal TreeItemDropArea jPs(DragEventArgs P_0, TreeListBoxItem P_1, TreeItemDropArea P_2)
	{
		P_2 = ItemAdapter?.OnDragOver(P_0, this, P_1?.Content, P_2) ?? TreeItemDropArea.None;
		mPF(P_0, P_1?.ntA());
		return P_2;
	}

	private void mPF(DragEventArgs P_0, oT P_1)
	{
		if (R1f() != P_1)
		{
			H10(P_1);
			utN = DateTime.Now;
			return;
		}
		int item = default(int);
		int item2 = default(int);
		int num = default(int);
		int num2;
		if (P_1 != null)
		{
			if ((DateTime.Now - utN).TotalMilliseconds > 1000.0)
			{
				TreeListBoxItemAdapter itemAdapter = ItemAdapter;
				if (itemAdapter == null || itemAdapter.OnDragHover(P_0, this, P_1) != TreeItemExpandability.Never)
				{
					P_1.SKo();
				}
				utN = DateTime.Now;
			}
			if (qtT == null || !(qtT.ActualHeight > 28.0) || !((DateTime.Now - utN).TotalMilliseconds > 50.0))
			{
				return;
			}
			Tuple<int, int, int, int> tuple = UPi();
			item = tuple.Item3;
			item2 = tuple.Item4;
			num = P_1.kNR();
			if (num < 0 || num >= otY.Count)
			{
				goto IL_01e6;
			}
			num2 = 1;
			if (FWF() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			if (otY.Count <= 0 || qtT == null || !(qtT.ActualHeight > 28.0))
			{
				return;
			}
			num2 = 1;
			if (BW6())
			{
				num2 = 4;
			}
		}
		goto IL_0009;
		IL_01e6:
		if (P_0.GetPosition(qtT).Y < 14.0)
		{
			if (num <= 0)
			{
				return;
			}
			num2 = 0;
			if (!BW6())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		if (P_0.GetPosition(qtT).Y > qtT.ActualHeight - 14.0 && num < otY.Count - 1)
		{
			RP2(otY.uNx(num + 1));
			utN = DateTime.Now;
		}
		return;
		IL_0009:
		int item3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				break;
			case 3:
				if (item3 < otY.Count - 1)
				{
					RP2(otY.uNx(item3 + 1));
					utN = DateTime.Now;
				}
				return;
			case 1:
				goto end_IL_0009;
			default:
				RP2(otY.uNx(num - 1));
				utN = DateTime.Now;
				return;
			}
			if (!((DateTime.Now - utN).TotalMilliseconds > 50.0))
			{
				return;
			}
			Tuple<int, int, int, int> tuple2 = UPi();
			int item4 = tuple2.Item3;
			item3 = tuple2.Item4;
			if (P_0.GetPosition(qtT).Y < 14.0)
			{
				if (item4 <= 0)
				{
					return;
				}
				RP2(otY.uNx(item4 - 1));
				utN = DateTime.Now;
				num2 = 2;
				if (BW6())
				{
					continue;
				}
			}
			else
			{
				if (!(P_0.GetPosition(qtT).Y > qtT.ActualHeight - 14.0))
				{
					return;
				}
				num2 = 3;
				if (FWF() == null)
				{
					continue;
				}
			}
			goto IL_0005;
			continue;
			end_IL_0009:
			break;
		}
		if (num < item || num > item2)
		{
			RP2(otY.uNx(num));
			utN = DateTime.Now;
			return;
		}
		goto IL_01e6;
		IL_0005:
		int num3 = default(int);
		num2 = num3;
		goto IL_0009;
	}

	internal void rPc(DragEventArgs P_0, TreeListBoxItem P_1, TreeItemDropArea P_2)
	{
		ItemAdapter?.OnDrop(P_0, this, P_1?.Content, P_2);
	}

	private void hPV(object P_0, EventArgs P_1)
	{
		R1t();
	}

	private static void fPf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox treeListBox = (TreeListBox)P_0;
		if (P_1.OldValue is IDataFilter dataFilter)
		{
			dataFilter.FilterChanged -= treeListBox.hPV;
		}
		if (P_1.NewValue is IDataFilter dataFilter2)
		{
			dataFilter2.FilterChanged += treeListBox.hPV;
		}
		treeListBox.R1t();
	}

	private static void zP0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox treeListBox = (TreeListBox)P_0;
		for (int i = 0; i < treeListBox.Items.Count; i++)
		{
			if (treeListBox.ItemContainerGenerator.ContainerFromIndex(i) is TreeListBoxItem treeListBoxItem)
			{
				treeListBoxItem.ctV();
			}
		}
	}

	private static void TPA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox treeListBox = (TreeListBox)P_0;
		if (!treeListBox.IsFilterActive)
		{
			treeListBox.b1v();
		}
		treeListBox.R1t();
	}

	private static void nP4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox obj = (TreeListBox)P_0;
		obj.P16();
		obj.A1a();
		obj.p1p();
	}

	private static void zPS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox obj = (TreeListBox)P_0;
		obj.P16();
		obj.A1a();
	}

	private static void bPz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox obj = (TreeListBox)P_0;
		obj.P16();
		obj.A1a();
		obj.X1T();
	}

	private void c1I(object P_0, ScrollChangedEventArgs P_1)
	{
		if (qtT != null)
		{
			OnScrollViewerScrollChanged(P_1);
		}
	}

	private void D1P(object P_0, object P_1)
	{
		PtC = false;
		i1n();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal void U11(oT P_0, bool P_1, bool P_2, bool P_3)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass69_0();
		CS_0024_003C_003E8__locals14.ygq = P_3;
		CS_0024_003C_003E8__locals14.vgJ = this;
		using (new PQ(this))
		{
			if (P_0.HNU())
			{
				if (base.IsKeyboardFocusWithin)
				{
					Focus();
				}
				B12();
				Ctn(null);
				h1c(null);
				if (P_1)
				{
					foreach (IList<oT> value in Atg.Values)
					{
						if (value.IsReadOnly)
						{
							value[0].UC4();
							continue;
						}
						foreach (oT item in value)
						{
							item.UC4();
						}
					}
					Atg = new Dictionary<object, IList<oT>>();
				}
				else
				{
					IEnumerator<oT> enumerator3 = otY.FNa();
					while (enumerator3.MoveNext())
					{
						enumerator3.Current.IsVisible = false;
					}
				}
				otY.wN3();
				return;
			}
			if (P_0.IsVisible)
			{
				d1b();
				int num = P_0.kNR() + ((!P_2) ? 1 : 0);
				int num2 = P_0.sKP().kNR();
				if (num >= 0 && num <= num2)
				{
					oT oT = JtW();
					oT oT2 = w1F();
					bool isKeyboardFocusWithinContent = IsKeyboardFocusWithinContent;
					oT oT3 = null;
					CS_0024_003C_003E8__locals14.Lg5 = null;
					for (int i = num; i <= num2; i++)
					{
						oT oT4 = otY.uNx(i);
						M13(oT4);
						if (oT == oT4)
						{
							oT oT5 = oT4.hKI();
							if (oT5 != null && YtM.Count == 0)
							{
								oT3 = oT5;
							}
							else
							{
								Ctn(null);
							}
						}
						if (oT2 == oT4)
						{
							CS_0024_003C_003E8__locals14.Lg5 = oT4.hKI();
						}
						if (P_1)
						{
							FP8(oT4);
						}
						else
						{
							oT4.IsVisible = false;
						}
					}
					otY.cND(num, num2 - num + 1);
					if (oT3 != null)
					{
						o1O(oT3, _0020: false, _0020: true);
					}
					if (CS_0024_003C_003E8__locals14.Lg5 == null)
					{
						return;
					}
					h1c(CS_0024_003C_003E8__locals14.Lg5);
					if (!isKeyboardFocusWithinContent)
					{
						return;
					}
					CS_0024_003C_003E8__locals14.pgW = ((!CS_0024_003C_003E8__locals14.ygq) ? null : oT2?.sNm());
					base.Dispatcher.BeginInvoke(DispatcherPriority.Send, (Action)delegate
					{
						if (CS_0024_003C_003E8__locals14.ygq)
						{
							oT oT6 = CS_0024_003C_003E8__locals14.vgJ.pPb(CS_0024_003C_003E8__locals14.pgW, _0020: false, null);
							if (oT6 != null)
							{
								CS_0024_003C_003E8__locals14.Lg5 = oT6;
							}
						}
						CS_0024_003C_003E8__locals14.vgJ.j1Q(CS_0024_003C_003E8__locals14.Lg5, (UC)0);
					});
					return;
				}
			}
			if (!P_1)
			{
				return;
			}
			if (P_2)
			{
				FP8(P_0);
			}
			else
			{
				if (!P_0.aKd(_0020: false))
				{
					return;
				}
				{
					foreach (oT item2 in P_0.kK3())
					{
						FP8(item2);
					}
					return;
				}
			}
		}
	}

	private void R1t()
	{
		_003C_003Ec__DisplayClass70_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass70_0();
		CS_0024_003C_003E8__locals5.Jgp = this;
		dtl = (dtl + 1) % 1000;
		CS_0024_003C_003E8__locals5.WgE = dtl;
		base.Dispatcher.BeginInvoke(DispatcherPriority.Background, (Action)delegate
		{
			if (CS_0024_003C_003E8__locals5.Jgp.dtl == CS_0024_003C_003E8__locals5.WgE)
			{
				CS_0024_003C_003E8__locals5.Jgp.tPX();
			}
		});
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	internal void d1U(InputPointerEventArgs P_0)
	{
		IList<object> list = MPx();
		if (list == null || list.Count == 0)
		{
			return;
		}
		try
		{
			TreeListBoxItemAdapter itemAdapter = ItemAdapter;
			if (itemAdapter == null)
			{
				return;
			}
			DataObject dataObject = new DataObject();
			DragDropEffects dragDropEffects = itemAdapter.InitializeDataObject(this, dataObject, list);
			if (dragDropEffects == DragDropEffects.None)
			{
				return;
			}
			int num = 0;
			if (FWF() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (dataObject.GetFormats().Any())
			{
				itemAdapter.OnDragStart(P_0, this, dataObject, dragDropEffects);
				DragDropEffects effect = DragDrop.DoDragDrop(this, dataObject, dragDropEffects);
				itemAdapter.OnDragComplete(P_0, this, dataObject, effect);
			}
		}
		catch
		{
		}
	}

	private void P16()
	{
		if (Xtm == null)
		{
			return;
		}
		ptt(new TreeNodeItemCollection(useHashSet: false));
		otY.TN9();
		try
		{
			IEnumerable enumerable = null;
			bool isRootItemVisible = IsRootItemVisible;
			TreeListBoxItemAdapter itemAdapter = ItemAdapter;
			object rootItem = RootItem;
			if (rootItem != null)
			{
				if (isRootItemVisible)
				{
					enumerable = new object[1] { rootItem };
				}
				else if (itemAdapter != null)
				{
					enumerable = itemAdapter.GetChildren(this, rootItem);
				}
			}
			Xtm.jNT((!isRootItemVisible) ? rootItem : null);
			Xtm.NKn(null, _0020: true, null);
			tPX();
			if (enumerable != null)
			{
				Xtm.NKn(enumerable, _0020: true, null);
			}
		}
		finally
		{
			otY.ENj();
		}
		A1h();
		base.ItemsSource = otY;
	}

	internal void S1q(oT P_0, ITreeItemVirtualPlaceholder P_1)
	{
		object obj = P_0.sNm();
		int num = P_0.kNR();
		int num2 = 1;
		if (!BW6())
		{
			int num3 = default(int);
			num2 = num3;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				if (num != -1)
				{
					otY.NN7(num, obj);
				}
				if (Atg.TryGetValue(P_1, out var value))
				{
					if (value.IsReadOnly)
					{
						if (value[0] == P_0)
						{
							Atg.Remove(P_1);
						}
					}
					else if (value.Remove(P_0) && !value.Any())
					{
						Atg.Remove(P_1);
					}
				}
				if (Atg.TryGetValue(obj, out value))
				{
					if (value.IsReadOnly)
					{
						value = new List<oT>(value);
						Atg[obj] = value;
					}
					value.Add(P_0);
					return;
				}
				Atg[obj] = new oT[1] { P_0 };
				num2 = 0;
				if (FWF() != null)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[SpecialName]
	internal ScrollViewer i14()
	{
		return qtT;
	}

	[SpecialName]
	private void O1S(ScrollViewer value)
	{
		if (qtT != null)
		{
			qtT.ScrollChanged -= c1I;
		}
		qtT = value;
		if (qtT != null)
		{
			qtT.ScrollChanged += c1I;
		}
	}

	private bool d1J()
	{
		oT oT = w1F();
		if (oT != null && oT.lKe())
		{
			RP2(oT);
			oT.oK7(_0020: true);
		}
		return false;
	}

	[SpecialName]
	internal EN ptI()
	{
		if (uto == null)
		{
			uto = new EN(this);
		}
		return uto;
	}

	private void W15()
	{
		_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals42 = new _003C_003Ec__DisplayClass80_0();
		CS_0024_003C_003E8__locals42.ggN = this;
		d1b();
		CS_0024_003C_003E8__locals42.vgl = new List<oT>();
		HashSet<oT> hashSet = new HashSet<oT>();
		HashSet<oT> hashSet2 = new HashSet<oT>();
		Q1W(Xtm, CS_0024_003C_003E8__locals42.vgl, hashSet, hashSet2);
		using (new PQ(this))
		{
			YtM.TN9();
			try
			{
				bool isKeyboardFocusWithinContent = IsKeyboardFocusWithinContent;
				bool flag = SelectedItem != null;
				oT oT = JtW();
				if (oT != null && hashSet2.Contains(oT))
				{
					oT = oT.hKI();
				}
				if (hashSet.Count + hashSet2.Count >= 1000)
				{
					ptt(new TreeNodeItemCollection(useHashSet: false));
					otY.JNH(0, CS_0024_003C_003E8__locals42.vgl);
					base.ItemsSource = otY;
				}
				else
				{
					CS_0024_003C_003E8__locals42.Fgm = 0;
					int num = 0;
					int count = CS_0024_003C_003E8__locals42.vgl.Count;
					CS_0024_003C_003E8__locals42.Kgg = -1;
					CS_0024_003C_003E8__locals42.vgT = -1;
					Func<int, bool> func = delegate(int currentIndex)
					{
						if (CS_0024_003C_003E8__locals42.Kgg != -1)
						{
							CS_0024_003C_003E8__locals42.ggN.otY.cND(CS_0024_003C_003E8__locals42.Kgg, currentIndex - CS_0024_003C_003E8__locals42.Kgg);
							CS_0024_003C_003E8__locals42.Fgm = CS_0024_003C_003E8__locals42.Kgg;
							CS_0024_003C_003E8__locals42.Kgg = -1;
							return true;
						}
						return false;
					};
					Func<int, bool> func2 = delegate(int currentIndex)
					{
						if (CS_0024_003C_003E8__locals42.vgT != -1)
						{
							CS_0024_003C_003E8__locals42.ggN.otY.JNH(CS_0024_003C_003E8__locals42.Fgm, CS_0024_003C_003E8__locals42.vgl.Skip(CS_0024_003C_003E8__locals42.vgT).Take(currentIndex - CS_0024_003C_003E8__locals42.vgT));
							CS_0024_003C_003E8__locals42.Fgm += currentIndex - CS_0024_003C_003E8__locals42.vgT;
							CS_0024_003C_003E8__locals42.vgT = -1;
							return true;
						}
						return false;
					};
					while (num < count && CS_0024_003C_003E8__locals42.Fgm < otY.Count)
					{
						oT oT2 = otY.uNx(CS_0024_003C_003E8__locals42.Fgm);
						oT oT3 = CS_0024_003C_003E8__locals42.vgl[num];
						if (oT2 != oT3)
						{
							if (hashSet2.Contains(oT2))
							{
								if (CS_0024_003C_003E8__locals42.Kgg == -1)
								{
									CS_0024_003C_003E8__locals42.Kgg = CS_0024_003C_003E8__locals42.Fgm;
								}
								CS_0024_003C_003E8__locals42.Fgm++;
							}
							else if (!func(CS_0024_003C_003E8__locals42.Fgm))
							{
								if (CS_0024_003C_003E8__locals42.vgT == -1)
								{
									CS_0024_003C_003E8__locals42.vgT = num;
								}
								num++;
							}
						}
						else if (!func(CS_0024_003C_003E8__locals42.Fgm) && !func2(num))
						{
							CS_0024_003C_003E8__locals42.Fgm++;
							num++;
						}
					}
					if (CS_0024_003C_003E8__locals42.Kgg == -1 && CS_0024_003C_003E8__locals42.Fgm < otY.Count)
					{
						CS_0024_003C_003E8__locals42.Kgg = CS_0024_003C_003E8__locals42.Fgm;
					}
					func(otY.Count);
					if (CS_0024_003C_003E8__locals42.vgT == -1 && num < count)
					{
						CS_0024_003C_003E8__locals42.vgT = num;
					}
					func2(count);
				}
				h1c(oT);
				if (oT != null)
				{
					if (flag)
					{
						o1O(oT, _0020: false, _0020: true);
					}
					else
					{
						B12();
					}
					if (isKeyboardFocusWithinContent)
					{
						j1Q(oT, (UC)0);
					}
				}
				else
				{
					B12();
				}
			}
			finally
			{
				YtM.ENj();
			}
		}
	}

	private void Q1W(oT P_0, List<oT> P_1, HashSet<oT> P_2, HashSet<oT> P_3)
	{
		if (!P_0.IsVisible || !P_0.IsExpanded || !P_0.aKd(_0020: false))
		{
			return;
		}
		foreach (oT item in P_0.kK3())
		{
			if (item.IsVisible)
			{
				if (item.FK4())
				{
					P_3.Add(item);
				}
				else
				{
					P_1.Add(item);
				}
				Q1W(item, P_1, P_2, P_3);
				if (item.FK4())
				{
					item.IsVisible = false;
				}
			}
			else if (!item.FK4())
			{
				item.IsVisible = true;
				P_1.Add(item);
				P_2.Add(item);
				Q1W(item, P_1, P_2, P_3);
			}
		}
	}

	private void i1n()
	{
		bool flag = otY == null || otY.Count == 0;
		if (IsEmpty != flag)
		{
			IsEmpty = flag;
		}
	}

	[SpecialName]
	internal TreeNodeItemCollection lt1()
	{
		return otY;
	}

	[SpecialName]
	private void ptt(TreeNodeItemCollection value)
	{
		if (otY != value)
		{
			if (otY != null)
			{
				otY.CollectionChanged -= D1P;
			}
			otY = value;
			if (otY != null)
			{
				otY.CollectionChanged += D1P;
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Size result = base.ArrangeOverride(finalSize);
		PtC = true;
		return result;
	}

	public bool BringItemIntoView(object item)
	{
		if (item == null)
		{
			throw new ArgumentNullException(xv.hTz(3356));
		}
		oT oT = pPb(item, _0020: true, null);
		if (oT != null)
		{
			RP2(oT);
			return true;
		}
		return false;
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByPath")]
	public bool BringItemIntoViewByFullPath(string fullPath)
	{
		oT oT = uPh(fullPath);
		if (oT != null)
		{
			RP2(oT);
			return true;
		}
		return false;
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		if (element is TreeListBoxItem treeListBoxItem)
		{
			BindingOperations.ClearBinding(treeListBoxItem, UIElement.AllowDropProperty);
			if (treeListBoxItem.ntA() != null && treeListBoxItem.ntA() == JtW())
			{
				m1s(null);
			}
			treeListBoxItem.Et4(null);
		}
		base.ClearContainerForItemOverride(element, item);
	}

	public void CollapseAll()
	{
		TP3(null, _0020: false, _0020: false, _0020: false, delegate(oT n)
		{
			n.MKg(TreeExpansionKind.All, null);
			return (object)null;
		});
	}

	public void ExpandAll()
	{
		TP3(null, _0020: false, _0020: true, _0020: true, delegate(oT n)
		{
			n.PKY(TreeExpansionKind.All, null);
			return (object)null;
		});
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new TreeListBoxItem();
	}

	public string GetFullPath(object item)
	{
		if (item != null)
		{
			oT oT = pPb(item, _0020: true, null);
			if (oT != null)
			{
				return oT.QKh();
			}
		}
		return null;
	}

	public object GetItemByFullPath(string fullPath)
	{
		return uPh(fullPath)?.sNm();
	}

	public ITreeItemNavigator GetItemNavigator(object item)
	{
		if (item != null)
		{
			int num = otY.IndexOf(item);
			if (num != -1)
			{
				return new yo(otY.uNx(num));
			}
			return null;
		}
		throw new ArgumentNullException(xv.hTz(3356));
	}

	public void InvalidateChildren(object item)
	{
		if (item != null)
		{
			pPb(item, _0020: false, null)?.AKR();
		}
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is TreeListBoxItem;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		O1S(GetTemplateChild(xv.hTz(3368)) as ScrollViewer);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TreeListBoxAutomationPeer(this);
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragEnter(e);
		if (!e.Handled)
		{
			jPs(e, null, TreeItemDropArea.None);
			e.Handled = true;
		}
	}

	protected override void OnDragLeave(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragLeave(e);
		e.Handled = true;
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDragOver(e);
		if (!e.Handled)
		{
			jPs(e, null, TreeItemDropArea.None);
			e.Handled = true;
		}
	}

	protected override void OnDrop(DragEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		base.OnDrop(e);
		if (!e.Handled)
		{
			rPc(e, null, TreeItemDropArea.None);
			e.Handled = true;
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e != null && !e.Handled)
		{
			ProcessKeyDown(e);
		}
	}

	protected virtual void OnScrollViewerScrollChanged(ScrollChangedEventArgs e)
	{
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		TreeListBoxItem treeListBoxItem = element as TreeListBoxItem;
		oT oT = pPb(item, _0020: false, (oT n) => n.IsVisible && n.AKj() == null);
		if (treeListBoxItem != null && oT != null)
		{
			if (oT.PK6())
			{
				item = oT.sNm();
				treeListBoxItem.DataContext = item;
			}
			treeListBoxItem.BindToProperty(UIElement.AllowDropProperty, this, xv.hTz(3412), BindingMode.OneWay);
			base.PrepareContainerForItemOverride(element, item);
			treeListBoxItem.Et4(oT);
			if (HasTreeLines)
			{
				treeListBoxItem.Et0();
			}
			A1u(oT, _0020: true);
		}
		else
		{
			base.PrepareContainerForItemOverride(element, item);
		}
	}

	[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActiproSoftware.Windows.Controls.Grids.Primitives.TextSearching.PerformTyping(System.String)")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected internal virtual void ProcessKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(xv.hTz(3406));
		}
		if (e.Handled)
		{
			return;
		}
		ModifierKeys modifierKeys = LY.hle();
		Key key = ((e.Key == Key.System) ? e.SystemKey : e.Key);
		if (modifierKeys == ModifierKeys.Control)
		{
			switch (key)
			{
			case Key.A:
				if (SelectionMode != SelectionMode.Single)
				{
					o1L();
					e.Handled = true;
				}
				break;
			case Key.Add:
				w1F()?.SKo();
				e.Handled = true;
				break;
			case Key.Divide:
				CollapseAll();
				e.Handled = true;
				break;
			case Key.Down:
				q1B((UC)0);
				e.Handled = true;
				break;
			case Key.End:
				L1d((UC)0);
				e.Handled = true;
				break;
			case Key.Return:
				w1F()?.JKT();
				e.Handled = true;
				break;
			case Key.Home:
				j1y((UC)0);
				e.Handled = true;
				break;
			case Key.Multiply:
				if (CanExpandAll)
				{
					ExpandAll();
				}
				else
				{
					w1F()?.SKo();
				}
				e.Handled = true;
				break;
			case Key.Next:
				a1R((UC)0);
				e.Handled = true;
				break;
			case Key.Prior:
				B1M((UC)0);
				e.Handled = true;
				break;
			case Key.Space:
			{
				oT oT = w1F();
				if (oT != null)
				{
					if (oT.IsSelected)
					{
						M13(oT);
					}
					else
					{
						o1O(oT, _0020: true, _0020: true);
					}
					e.Handled = true;
				}
				break;
			}
			case Key.Subtract:
				w1F()?.xKl();
				e.Handled = true;
				break;
			case Key.Up:
				j1r((UC)0);
				e.Handled = true;
				break;
			}
			return;
		}
		bool flag = (modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift;
		UC uC = ((!flag || SelectionMode != SelectionMode.Extended) ? ((UC)1) : ((UC)2));
		switch (key)
		{
		case Key.Add:
			w1F()?.SKo();
			e.Handled = true;
			break;
		case Key.Back:
			if (ptI().kEi())
			{
				ptI().bEx();
			}
			else
			{
				L1e();
			}
			e.Handled = true;
			break;
		case Key.Divide:
			w1F()?.IKm();
			e.Handled = true;
			break;
		case Key.Down:
			q1B(uC);
			e.Handled = true;
			break;
		case Key.End:
			L1d(uC);
			e.Handled = true;
			break;
		case Key.Return:
			w1F()?.JKT();
			e.Handled = true;
			break;
		case Key.F2:
			if (modifierKeys == ModifierKeys.None)
			{
				e.Handled = d1J();
			}
			break;
		case Key.Home:
			j1y(uC);
			e.Handled = true;
			break;
		case Key.Left:
			D1Y();
			e.Handled = true;
			break;
		case Key.Multiply:
			if (CanExpandAll)
			{
				w1F()?.JKk();
			}
			else
			{
				w1F()?.SKo();
			}
			e.Handled = true;
			break;
		case Key.Next:
			a1R(uC);
			e.Handled = true;
			break;
		case Key.Prior:
			B1M(uC);
			e.Handled = true;
			break;
		case Key.Right:
			f1k();
			e.Handled = true;
			break;
		case Key.Space:
		{
			oT oT2 = w1F();
			if (oT2 != null)
			{
				if (ptI().kEi())
				{
					ptI().zEa(xv.hTz(3106));
				}
				else if (flag && SelectionMode == SelectionMode.Extended)
				{
					z1j(JtW(), oT2);
				}
				else
				{
					o1O(oT2, _0020: false, _0020: true);
				}
				e.Handled = true;
			}
			break;
		}
		case Key.Subtract:
			w1F()?.xKl();
			e.Handled = true;
			break;
		case Key.Up:
			j1r(uC);
			e.Handled = true;
			break;
		}
	}

	internal void p1p()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = IsRootItemVisibleChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnIsRootItemVisibleChanged(e);
		RaiseEvent(e);
	}

	internal void D1E(TreeListBoxItemExpansionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemCollapsedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemCollapsed(P_0);
		RaiseEvent(P_0);
	}

	internal void w1C(TreeListBoxItemExpansionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemCollapsingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemCollapsing(P_0);
		RaiseEvent(P_0);
	}

	internal void H1K(TreeListBoxItemEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemDefaultActionExecutingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemDefaultActionExecuting(P_0);
		RaiseEvent(P_0);
	}

	internal void J1N(TreeListBoxItemExpansionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemExpandedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemExpanded(P_0);
		RaiseEvent(P_0);
	}

	internal void U1l(TreeListBoxItemExpansionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemExpandingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemExpanding(P_0);
		RaiseEvent(P_0);
	}

	internal void U1g(TreeListBoxItemMenuEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemMenuRequestedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemMenuRequested(P_0);
		RaiseEvent(P_0);
	}

	internal void B1m(TreeListBoxItemEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ItemSelectingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnItemSelecting(P_0);
		RaiseEvent(P_0);
	}

	internal void X1T()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = RootItemChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnRootItemChanged(e);
		RaiseEvent(e);
	}

	internal void D1o(object[] P_0, object[] P_1)
	{
		SelectionChangedEventArgs e = new SelectionChangedEventArgs(SelectionChangedEvent, P_0, P_1);
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = SelectionChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnSelectionChanged(e);
		RaiseEvent(e);
	}

	protected virtual void OnIsRootItemVisibleChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnItemCollapsed(TreeListBoxItemExpansionEventArgs e)
	{
	}

	protected virtual void OnItemCollapsing(TreeListBoxItemExpansionEventArgs e)
	{
	}

	protected virtual void OnItemDefaultActionExecuting(TreeListBoxItemEventArgs e)
	{
	}

	protected virtual void OnItemExpanded(TreeListBoxItemExpansionEventArgs e)
	{
	}

	protected virtual void OnItemExpanding(TreeListBoxItemExpansionEventArgs e)
	{
	}

	protected virtual void OnItemMenuRequested(TreeListBoxItemMenuEventArgs e)
	{
	}

	protected virtual void OnItemSelecting(TreeListBoxItemEventArgs e)
	{
	}

	protected virtual void OnRootItemChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
	{
	}

	private void D1Y()
	{
		oT oT = w1F();
		if (oT == null)
		{
			return;
		}
		if (oT.IsExpanded)
		{
			bool num = oT.aKd(_0020: false);
			oT.xKl();
			if (num)
			{
				return;
			}
		}
		yo yo = new yo(oT);
		yo.GoToParent();
		j1Q(yo.Nln(), (UC)1);
	}

	private void f1k()
	{
		oT oT = w1F();
		if (oT != null)
		{
			if (oT.IsExpanded)
			{
				yo yo = new yo(oT);
				yo.GoToFirstChild();
				j1Q(yo.Nln(), (UC)1);
			}
			else
			{
				oT.SKo();
			}
		}
	}

	private bool j1Q(oT P_0, UC P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3304));
		}
		LtJ(P_0);
		btQ = P_1;
		if (jPj(P_0) == (Ik)0)
		{
			RP2(P_0);
			LtJ(P_0);
		}
		if (A1u(P_0, _0020: false))
		{
			return true;
		}
		LtJ(P_0);
		return false;
	}

	private void j1y(UC P_0)
	{
		oT oT = w1F();
		if (oT != null)
		{
			yo yo = new yo(oT);
			yo.GoToFirstVisible();
			j1Q(yo.Nln(), P_0);
		}
	}

	private void L1d(UC P_0)
	{
		oT oT = w1F();
		if (oT != null)
		{
			yo yo = new yo(oT);
			yo.GoToLastVisible();
			j1Q(yo.Nln(), P_0);
		}
	}

	private void q1B(UC P_0)
	{
		oT oT = w1F();
		if (oT == null)
		{
			return;
		}
		yo yo = new yo(oT);
		yo.GoToNextVisible();
		if (!j1Q(yo.Nln(), P_0))
		{
			while (yo.GoToNextVisible() && !j1Q(yo.Nln(), P_0))
			{
			}
		}
	}

	private void a1R(UC P_0)
	{
		if (qtT == null || otY.Count <= 0)
		{
			return;
		}
		Tuple<int, int, int, int> tuple = UPi();
		int item = tuple.Item1;
		int item2 = tuple.Item4;
		oT oT = w1F();
		if (oT != null)
		{
			Ik ik = jPj(oT);
			if ((uint)(ik - 1) <= 1u)
			{
				j1Q(otY.uNx(item2), P_0);
				return;
			}
		}
		int num = oT.kNR();
		if (num != -1)
		{
			j1Q(otY.uNx(Math.Min(otY.Count - 1, num + item - 1)), P_0);
		}
	}

	private void B1M(UC P_0)
	{
		if (qtT == null)
		{
			return;
		}
		Tuple<int, int, int, int> tuple = UPi();
		int item = tuple.Item1;
		int item2 = tuple.Item3;
		oT oT = w1F();
		if (oT != null)
		{
			Ik ik = jPj(oT);
			if ((uint)(ik - 2) <= 1u)
			{
				j1Q(otY.uNx(item2), P_0);
				int num = 0;
				if (!BW6())
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
		int num3 = oT.kNR();
		if (num3 != -1)
		{
			j1Q(otY.uNx(Math.Max(0, num3 - item + 1)), P_0);
		}
	}

	private void L1e()
	{
		oT oT = w1F();
		if (oT != null)
		{
			yo yo = new yo(oT);
			yo.GoToParent();
			j1Q(yo.Nln(), (UC)1);
		}
	}

	private void j1r(UC P_0)
	{
		oT oT = w1F();
		if (oT == null)
		{
			return;
		}
		yo yo = new yo(oT);
		yo.GoToPreviousVisible();
		if (!j1Q(yo.Nln(), P_0))
		{
			while (yo.GoToPreviousVisible() && !j1Q(yo.Nln(), P_0))
			{
			}
		}
	}

	internal void s1G(oT P_0)
	{
		j1Q(P_0, (UC)1);
	}

	[SpecialName]
	internal oT Gtq()
	{
		if (Ktk != null)
		{
			if (Ktk.IsAlive)
			{
				return Ktk.Target as oT;
			}
			Ktk = null;
		}
		return null;
	}

	[SpecialName]
	internal void LtJ(oT value)
	{
		Ktk = ((value != null) ? new WeakReference(value) : null);
	}

	private bool A1u(oT P_0, bool P_1)
	{
		bool flag = false;
		if (Gtq() == P_0)
		{
			TreeListBoxItem treeListBoxItem = P_0.AKj();
			if (treeListBoxItem != null && treeListBoxItem.Visibility == Visibility.Visible)
			{
				flag = treeListBoxItem.ztX(btQ);
			}
			if (flag || P_1)
			{
				LtJ(null);
			}
		}
		return flag;
	}

	public void FocusItem(object item)
	{
		if (item == null)
		{
			throw new ArgumentNullException(xv.hTz(3356));
		}
		oT oT = pPb(item, _0020: true, null);
		if (oT != null)
		{
			j1Q(oT, (UC)1);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByPath")]
	public void FocusItemByFullPath(string fullPath)
	{
		oT oT = uPh(fullPath);
		if (oT != null)
		{
			j1Q(oT, (UC)1);
		}
	}

	internal void o1O(oT P_0, bool P_1, bool P_2)
	{
		bool flag = SelectionMode == SelectionMode.Single;
		if (P_2 || flag)
		{
			Ctn(P_0);
		}
		if (flag)
		{
			P_1 = false;
		}
		if (P_1)
		{
			if (YtM.fNL(P_0))
			{
				return;
			}
			if (YtM.Count == 0)
			{
				P_1 = false;
			}
		}
		if (P_1)
		{
			if (!s1w(MultiSelectionKind, P_0, _0020: false))
			{
				return;
			}
			using (new PQ(this))
			{
				if (YtM.Count < 100)
				{
					YtM.DNZ(P_0);
				}
				else
				{
					YtM.xNh(YtM.Count, P_0);
				}
				P_0.lKW(_0020: true, ItemAdapter);
				f1x(P_0.sNm());
			}
		}
		else
		{
			using (new PQ(this))
			{
				YtM.TN9();
				try
				{
					if (YtM.Count > 0)
					{
						Q1X();
					}
					if (!s1w(MultiSelectionKind, P_0, _0020: false))
					{
						f1x(null);
						return;
					}
					YtM.xNh(YtM.Count, P_0);
					P_0.lKW(_0020: true, ItemAdapter);
					f1x(P_0.sNm());
				}
				finally
				{
					YtM.ENj();
				}
			}
			h1c(P_0);
		}
		if (SecurityHelper.IsFullTrust && P_0.sNm() != null)
		{
			TreeListBoxItem treeListBoxItem = base.ItemContainerGenerator.ContainerFromItem(P_0.sNm()) as TreeListBoxItem;
			if (treeListBoxItem == null && !P_1 && base.IsLoaded && P_0.IsVisible)
			{
				RP2(P_0);
				treeListBoxItem = base.ItemContainerGenerator.ContainerFromItem(P_0.sNm()) as TreeListBoxItem;
			}
			m1s(treeListBoxItem);
			if (!P_1 && treeListBoxItem != null && Keyboard.FocusedElement is TreeListBoxItem treeListBoxItem2 && treeListBoxItem2 != treeListBoxItem && ItemsControl.ItemsControlFromItemContainer(treeListBoxItem2) == this)
			{
				treeListBoxItem.Focus();
			}
		}
	}

	private bool s1w(TreeMultiSelectionKind P_0, oT P_1, bool P_2)
	{
		if (!P_1.IsSelectable)
		{
			return false;
		}
		if (P_0 != TreeMultiSelectionKind.Any && (P_2 || YtM.Count > 0))
		{
			oT oT = (P_2 ? w1F() : null) ?? YtM.uNx(0);
			switch (P_0)
			{
			case TreeMultiSelectionKind.SameDepth:
				if (oT.LKi() != P_1.LKi())
				{
					return false;
				}
				break;
			case TreeMultiSelectionKind.SameType:
				if (oT.sNm().GetType() != P_1.sNm().GetType())
				{
					return false;
				}
				break;
			case TreeMultiSelectionKind.Siblings:
				if (oT.tNd() != P_1.tNd())
				{
					return false;
				}
				break;
			}
		}
		TreeListBoxItemEventArgs e = new TreeListBoxItemEventArgs(P_1.sNm(), P_1.AKj());
		B1m(e);
		return !e.Cancel;
	}

	private void Q1X()
	{
		TreeListBoxItemAdapter itemAdapter = ItemAdapter;
		oT[] array = YtM.PNs();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].lKW(_0020: false, itemAdapter);
		}
		YtM.wN3();
	}

	private void B12()
	{
		using (new PQ(this))
		{
			if (YtM.Count > 0)
			{
				Q1X();
			}
			if (SelectedItem != null)
			{
				f1x(null);
			}
		}
	}

	private void b1v()
	{
		oT oT = null;
		oT[] array = YtM.PNs();
		foreach (oT oT2 in array)
		{
			if (oT2.tNd() != oT)
			{
				oT = oT2.tNd();
				for (oT oT3 = oT; oT3 != null; oT3 = oT3.tNd())
				{
					oT3.vK0(_0020: true);
				}
			}
		}
	}

	private static void q18(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TreeListBox treeListBox = (TreeListBox)P_0;
		SelectionMode selectionMode = treeListBox.SelectionMode;
		treeListBox.nty = selectionMode != SelectionMode.Single;
		if (selectionMode == SelectionMode.Single && treeListBox.YtM.Count > 1)
		{
			treeListBox.o1O(treeListBox.YtM.uNx(treeListBox.YtM.Count - 1), _0020: false, _0020: true);
		}
	}

	private static void c19(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		TreeListBox treeListBox = default(TreeListBox);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (!treeListBox.mtd)
					{
						if (P_1.NewValue != null)
						{
							oT oT = treeListBox.pPb(P_1.NewValue, _0020: true, null);
							if (oT != null)
							{
								treeListBox.mP9(oT);
								treeListBox.o1O(oT, _0020: false, _0020: true);
								return;
							}
						}
						else if (treeListBox.YtM.Count > 0)
						{
							treeListBox.Q1X();
						}
					}
					if (treeListBox.atB == null)
					{
						using (new PQ(treeListBox, P_1.OldValue))
						{
							return;
						}
					}
					return;
				case 1:
					break;
				}
				treeListBox = (TreeListBox)P_0;
				num2 = 0;
			}
			while (FWF() == null);
		}
	}

	internal void M13(oT P_0)
	{
		using (new PQ(this))
		{
			_003C_003Ec__DisplayClass253_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass253_0();
			if (P_0.IsSelected)
			{
				P_0.lKW(_0020: false, ItemAdapter);
			}
			int num = YtM.GNi(P_0);
			if (num != -1)
			{
				YtM.cND(num, 1);
			}
			CS_0024_003C_003E8__locals3.QgM = P_0.sNm();
			if (SelectedItem == CS_0024_003C_003E8__locals3.QgM)
			{
				f1x(YtM.LastOrDefault((object i) => i != CS_0024_003C_003E8__locals3.QgM));
			}
		}
	}

	private void o1L()
	{
		if (otY.Count == 0)
		{
			return;
		}
		using (new PQ(this))
		{
			YtM.TN9();
			try
			{
				YtM.wN3();
				TreeMultiSelectionKind multiSelectionKind = MultiSelectionKind;
				TreeListBoxItemAdapter itemAdapter = ItemAdapter;
				IEnumerator<oT> enumerator = otY.FNa();
				while (enumerator.MoveNext())
				{
					oT current = enumerator.Current;
					if (!current.IsSelected)
					{
						if (!s1w(multiSelectionKind, current, _0020: true))
						{
							continue;
						}
						current.lKW(_0020: true, itemAdapter);
					}
					else if (!s1w(multiSelectionKind, current, _0020: true))
					{
						current.lKW(_0020: false, itemAdapter);
						continue;
					}
					YtM.xNh(YtM.Count, current);
				}
				if (true.Equals(w1F()?.IsSelected))
				{
					f1x(w1F().sNm());
				}
				else
				{
					f1x(YtM.LastOrDefault());
				}
			}
			finally
			{
				YtM.ENj();
			}
		}
	}

	[SpecialName]
	internal oT JtW()
	{
		if (ytR != null)
		{
			if (ytR.IsAlive)
			{
				return ytR.Target as oT;
			}
			ytR = null;
		}
		return w1F();
	}

	[SpecialName]
	internal void Ctn(oT value)
	{
		ytR = ((value != null) ? new WeakReference(value) : null);
	}

	internal void z1j(oT P_0, oT P_1)
	{
		int num = otY.GNi(P_0);
		int num2 = otY.GNi(P_1);
		if (num == -1 || num2 == -1)
		{
			return;
		}
		using (new PQ(this))
		{
			YtM.TN9();
			try
			{
				if (YtM.Count > 0)
				{
					Q1X();
				}
				TreeListBoxItemAdapter itemAdapter = ItemAdapter;
				TreeMultiSelectionKind multiSelectionKind = MultiSelectionKind;
				int num3 = Math.Abs(num - num2) + 1;
				int num4 = ((num <= num2) ? 1 : (-1));
				int num5 = 0;
				int num6 = num;
				while (num5 < num3)
				{
					oT oT = otY.uNx(num6);
					if (!oT.IsSelected && s1w(multiSelectionKind, oT, _0020: false))
					{
						oT.lKW(_0020: true, itemAdapter);
						YtM.xNh((num4 >= 0) ? YtM.Count : 0, oT);
					}
					num5++;
					num6 += num4;
				}
				Ctn(P_0);
				h1c(P_1);
				if (P_1.IsSelected)
				{
					f1x(P_1.sNm());
				}
				else
				{
					f1x(YtM.LastOrDefault());
				}
			}
			finally
			{
				YtM.ENj();
			}
		}
	}

	private void f1x(object P_0)
	{
		mtd = true;
		try
		{
			if (SelectedItem != P_0)
			{
				SelectedItem = P_0;
			}
		}
		finally
		{
			mtd = false;
		}
	}

	private void A1a()
	{
		_003C_003Ec__DisplayClass260_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass260_0();
		CS_0024_003C_003E8__locals8.xgG = this;
		if (otY.Count == 0)
		{
			return;
		}
		CS_0024_003C_003E8__locals8.Tgr = ItemAdapter;
		if (CS_0024_003C_003E8__locals8.Tgr == null)
		{
			return;
		}
		if (SelectionMode == SelectionMode.Single)
		{
			object obj = otY.FirstOrDefault((object i) => CS_0024_003C_003E8__locals8.Tgr.GetIsSelected(CS_0024_003C_003E8__locals8.xgG, i));
			oT oT = ((obj != null) ? pPb(obj, _0020: false, null) : null);
			if (oT != null)
			{
				o1O(oT, _0020: false, _0020: true);
			}
			else
			{
				B12();
			}
			return;
		}
		List<oT> list = new List<oT>();
		IEnumerator<oT> enumerator = otY.FNa();
		while (enumerator.MoveNext())
		{
			oT current = enumerator.Current;
			if (CS_0024_003C_003E8__locals8.Tgr.GetIsSelected(this, current.sNm()))
			{
				list.Add(current);
			}
		}
		if (YtM.Count <= 0 && list.Count <= 0)
		{
			return;
		}
		using (new PQ(this))
		{
			YtM.TN9();
			try
			{
				YtM.wN3();
				TreeMultiSelectionKind multiSelectionKind = MultiSelectionKind;
				foreach (oT item in list)
				{
					if (!item.IsSelected)
					{
						if (!s1w(multiSelectionKind, item, _0020: true))
						{
							continue;
						}
						item.lKW(_0020: true, CS_0024_003C_003E8__locals8.Tgr);
					}
					else if (!s1w(multiSelectionKind, item, _0020: true))
					{
						item.lKW(_0020: false, CS_0024_003C_003E8__locals8.Tgr);
						continue;
					}
					YtM.xNh(YtM.Count, item);
				}
				if (true.Equals(w1F()?.IsSelected))
				{
					f1x(w1F().sNm());
				}
				else
				{
					f1x(YtM.LastOrDefault());
				}
			}
			finally
			{
				YtM.ENj();
			}
		}
	}

	private void c1i()
	{
		IEnumerator<oT> enumerator = YtM.FNa();
		while (enumerator.MoveNext())
		{
			enumerator.Current.AKj()?.Etf(_0020: true);
		}
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public IDisposable CreateSelectionBatch()
	{
		PQ pQ = new PQ(this);
		pQ.XlH(_0020: true);
		return pQ;
	}

	public virtual bool SelectItemByFullPath(string fullPath)
	{
		oT oT = uPh(fullPath);
		if (oT != null)
		{
			mP9(oT);
			o1O(oT, _0020: false, _0020: true);
			return true;
		}
		return false;
	}

	private void d1b()
	{
		if (HasTreeLines)
		{
			nte = true;
		}
	}

	private void A1h()
	{
		if (base.IsKeyboardFocusWithin && !base.IsKeyboardFocused)
		{
			try
			{
				jtr = true;
				Focus();
			}
			finally
			{
				jtr = false;
			}
		}
	}

	private ActiproSoftware.Products.AssemblyInfo x1Z()
	{
		ActiproSoftware.Products.AssemblyInfo assemblyInfo = AssemblyInfo;
		if (assemblyInfo != null)
		{
			string assemblyQualifiedName = assemblyInfo.GetType().AssemblyQualifiedName;
			if (assemblyQualifiedName != null && assemblyQualifiedName.StartsWith(xv.hTz(3434), StringComparison.Ordinal))
			{
				Type type = GetType();
				while (type != null && type != typeof(object))
				{
					string assemblyQualifiedName2 = type.AssemblyQualifiedName;
					if (assemblyQualifiedName2 != null && (assemblyQualifiedName2.StartsWith(xv.hTz(3580), StringComparison.Ordinal) || assemblyQualifiedName2.StartsWith(xv.hTz(3750), StringComparison.Ordinal)))
					{
						return assemblyInfo;
					}
					type = type.BaseType;
				}
			}
		}
		return null;
	}

	private void R1H()
	{
		nte = false;
		for (int num = base.Items.Count - 1; num >= 0; num--)
		{
			(base.ItemContainerGenerator.ContainerFromIndex(num) as TreeListBoxItem)?.Et0();
		}
	}

	private static void e1D(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((TreeListBox)P_0).R1H();
	}

	private void I17(object P_0, EventArgs P_1)
	{
		if (nte)
		{
			R1H();
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private void m1s(TreeListBoxItem P_0)
	{
		if (!ctu)
		{
			try
			{
				FieldInfo field = typeof(KeyboardNavigation).GetField(xv.hTz(3914), BindingFlags.Static | BindingFlags.NonPublic);
				if (field != null)
				{
					ltG = field.GetValue(null) as DependencyProperty;
				}
			}
			catch
			{
			}
			finally
			{
				ctu = true;
			}
		}
		if (ltG != null)
		{
			if (P_0 == null)
			{
				ClearValue(ltG);
			}
			else
			{
				SetValue(ltG, new WeakReference(P_0));
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static bool GetIsSelectionActive(TreeListBox obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		return (bool)obj.GetValue(IsSelectionActiveProperty);
	}

	private static void SetIsSelectionActive(TreeListBox obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		obj.SetValue(ytO, value);
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		if (!jtr && e != null && !e.Handled && e.NewFocus == this)
		{
			object selectedItem = SelectedItem;
			if (selectedItem != null)
			{
				FocusItem(selectedItem);
			}
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		c1i();
		SetIsSelectionActive(this, base.IsKeyboardFocusWithin);
	}

	protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
	{
		base.OnItemsSourceChanged(oldValue, newValue);
		if (newValue != null && newValue != otY)
		{
			throw new ArgumentException(xv.hTz(3984));
		}
	}

	static TreeListBox()
	{
		fc.taYSkz();
		AutoExpandItemsOnFilterProperty = DependencyProperty.Register(xv.hTz(4164), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false));
		CanDragItemsProperty = DependencyProperty.Register(xv.hTz(4214), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false));
		DataFilterProperty = DependencyProperty.Register(xv.hTz(4242), typeof(IDataFilter), typeof(TreeListBox), new PropertyMetadata(null, fPf));
		EmptyContentProperty = DependencyProperty.Register(xv.hTz(4266), typeof(object), typeof(TreeListBox), new PropertyMetadata(null));
		EmptyContentTemplateProperty = DependencyProperty.Register(xv.hTz(4294), typeof(DataTemplate), typeof(TreeListBox), new PropertyMetadata(null));
		IndentIncrementProperty = DependencyProperty.Register(xv.hTz(4338), typeof(double), typeof(TreeListBox), new PropertyMetadata(20.0, zP0));
		IsDataVirtualizationEnabledProperty = DependencyProperty.Register(xv.hTz(4372), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false));
		IsEmptyProperty = DependencyProperty.Register(xv.hTz(4430), typeof(bool), typeof(TreeListBox), new PropertyMetadata(true));
		int num = 0;
		if (1 == 0)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2;
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 2:
				ItemCollapsedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4714), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemExpansionEventArgs>), typeof(TreeListBox));
				ItemCollapsingEvent = EventManager.RegisterRoutedEvent(xv.hTz(4744), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemExpansionEventArgs>), typeof(TreeListBox));
				ItemDefaultActionExecutingEvent = EventManager.RegisterRoutedEvent(xv.hTz(4776), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemEventArgs>), typeof(TreeListBox));
				ItemExpandedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4832), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemExpansionEventArgs>), typeof(TreeListBox));
				ItemExpandingEvent = EventManager.RegisterRoutedEvent(xv.hTz(4860), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemExpansionEventArgs>), typeof(TreeListBox));
				ItemMenuRequestedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4890), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemMenuEventArgs>), typeof(TreeListBox));
				ItemSelectingEvent = EventManager.RegisterRoutedEvent(xv.hTz(4928), RoutingStrategy.Bubble, typeof(EventHandler<TreeListBoxItemEventArgs>), typeof(TreeListBox));
				RootItemChangedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4958), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TreeListBox));
				num = 0;
				if (0 == 0)
				{
					num = 1;
				}
				goto IL_0009_2;
			case 1:
				SelectionChangedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4992), RoutingStrategy.Bubble, typeof(SelectionChangedEventHandler), typeof(TreeListBox));
				MultiSelectionKindProperty = DependencyProperty.Register(xv.hTz(5028), typeof(TreeMultiSelectionKind), typeof(TreeListBox), new PropertyMetadata(TreeMultiSelectionKind.Any));
				SelectionModeProperty = DependencyProperty.Register(xv.hTz(5068), typeof(SelectionMode), typeof(TreeListBox), new PropertyMetadata(SelectionMode.Single, q18));
				SelectedItemProperty = DependencyProperty.Register(xv.hTz(5098), typeof(object), typeof(TreeListBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, c19));
				ytO = DependencyProperty.RegisterAttachedReadOnly(xv.hTz(5126), typeof(bool), typeof(TreeListBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
				HasTreeLinesProperty = DependencyProperty.Register(xv.hTz(5164), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false, e1D));
				IsSelectionActiveProperty = ytO.DependencyProperty;
				return;
			}
			IsFilterActiveProperty = DependencyProperty.Register(xv.hTz(4448), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false, TPA));
			IsRootItemVisibleProperty = DependencyProperty.Register(xv.hTz(4480), typeof(bool), typeof(TreeListBox), new PropertyMetadata(false, nP4));
			ItemAdapterProperty = DependencyProperty.Register(xv.hTz(4518), typeof(TreeListBoxItemAdapter), typeof(TreeListBox), new PropertyMetadata(null, zPS));
			MultiDragKindProperty = DependencyProperty.Register(xv.hTz(4544), typeof(TreeMultiDragKind), typeof(TreeListBox), new PropertyMetadata(TreeMultiDragKind.None));
			PathSeparatorProperty = DependencyProperty.Register(xv.hTz(4574), typeof(string), typeof(TreeListBox), new PropertyMetadata(xv.hTz(4604)));
			RootItemProperty = DependencyProperty.Register(xv.hTz(4610), typeof(object), typeof(TreeListBox), new PropertyMetadata(null, bPz));
			TopLevelIndentProperty = DependencyProperty.Register(xv.hTz(4630), typeof(double), typeof(TreeListBox), new PropertyMetadata(20.0, zP0));
			IsRootItemVisibleChangedEvent = EventManager.RegisterRoutedEvent(xv.hTz(4662), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TreeListBox));
			num = 2;
		}
		while (true);
		goto IL_0005;
	}

	internal static bool BW6()
	{
		return GWC == null;
	}

	internal static TreeListBox FWF()
	{
		return GWC;
	}
}
