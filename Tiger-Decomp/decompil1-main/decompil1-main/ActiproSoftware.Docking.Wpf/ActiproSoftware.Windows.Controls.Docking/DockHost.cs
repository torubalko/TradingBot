using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
[TemplatePart(Name = "PART_AutoHideLeftTabStrip", Type = typeof(AutoHideTabStrip))]
[TemplatePart(Name = "PART_AutoHideTopTabStrip", Type = typeof(AutoHideTabStrip))]
[TemplatePart(Name = "PART_ContentHost", Type = typeof(Panel))]
[TemplatePart(Name = "PART_AutoHideBottomTabStrip", Type = typeof(AutoHideTabStrip))]
[TemplatePart(Name = "PART_AutoHideRightTabStrip", Type = typeof(AutoHideTabStrip))]
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[ContentProperty("Child")]
public class DockHost : Control, iy, IDockTarget, lX
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public ToolWindow jSc;

		internal static _003C_003Ec__DisplayClass60_0 DKw;

		public _003C_003Ec__DisplayClass60_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool nSV(ToolWindowContainer twc)
		{
			return twc.Windows.Contains(jSc);
		}

		internal bool aSP(ToolWindowContainer twc)
		{
			return twc.Windows.Contains(jSc);
		}

		internal bool fSf(ToolWindowContainer twc)
		{
			return twc.Windows.Contains(jSc);
		}

		internal bool qSU(ToolWindowContainer twc)
		{
			return twc.Windows.Contains(jSc);
		}

		internal static bool dKg()
		{
			return DKw == null;
		}

		internal static _003C_003Ec__DisplayClass60_0 iKi()
		{
			return DKw;
		}
	}

	private ToolWindowContainerCollection jGf;

	private AutoHideTabStrip KGU;

	private ToolWindowContainerCollection fGc;

	private AutoHideTabStrip cG4;

	private ig hGj;

	private ToolWindowContainerCollection pGZ;

	private AutoHideTabStrip oGb;

	private ToolWindowContainerCollection WGA;

	private AutoHideTabStrip qGH;

	private Panel PG0;

	private DockSite FGh;

	private Workspace kGg;

	private bO PGX;

	private FD uG5;

	public static readonly DependencyProperty AutoHidePopupToolWindowProperty;

	public static readonly DependencyProperty AutoHideTabItemTemplateProperty;

	public static readonly DependencyProperty AutoHideTabItemTemplateSelectorProperty;

	public static readonly DependencyProperty ChildProperty;

	public static readonly DependencyProperty SplitterSizeProperty;

	public static readonly DependencyProperty UniqueIdProperty;

	[CompilerGenerated]
	private Point? EGy;

	[CompilerGenerated]
	private Size zGo;

	[CompilerGenerated]
	private bool iGt;

	[CompilerGenerated]
	private DateTime VGu;

	private WeakReference HGz;

	private DockingWindowState? JIi;

	private WindowState FId;

	private bool eIw;

	private Size SI2;

	public static readonly DependencyProperty IconProperty;

	private static readonly DependencyProperty uIe;

	public static readonly DependencyProperty TitleProperty;

	[CompilerGenerated]
	private EventHandler IIG;

	[CompilerGenerated]
	private EventHandler sII;

	[CompilerGenerated]
	private EventHandler<X9> rIk;

	[CompilerGenerated]
	private EventHandler AIC;

	[CompilerGenerated]
	private EventHandler pI1;

	[CompilerGenerated]
	private EventHandler oIN;

	[CompilerGenerated]
	private bool RIQ;

	[CompilerGenerated]
	private lX sIm;

	[CompilerGenerated]
	private Func<Nx, DockHost, bool, lX> EIa;

	internal static DockHost wV;

	internal bool IsOpen
	{
		get
		{
			if (xGd())
			{
				return true;
			}
			if (Meg() && VisualTreeHelper.GetParent(this) != null)
			{
				return true;
			}
			return false;
		}
	}

	public ToolWindowContainerCollection AutoHideBottomContainers => jGf;

	public ToolWindowContainerCollection AutoHideLeftContainers => fGc;

	public ToolWindow AutoHidePopupToolWindow
	{
		get
		{
			return (ToolWindow)GetValue(AutoHidePopupToolWindowProperty);
		}
		private set
		{
			SetValue(AutoHidePopupToolWindowProperty, value);
		}
	}

	public ToolWindowContainerCollection AutoHideRightContainers => pGZ;

	public DataTemplate AutoHideTabItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(AutoHideTabItemTemplateProperty);
		}
		set
		{
			SetValue(AutoHideTabItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector AutoHideTabItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(AutoHideTabItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(AutoHideTabItemTemplateSelectorProperty, value);
		}
	}

	public ToolWindowContainerCollection AutoHideTopContainers => WGA;

	public FrameworkElement Child
	{
		get
		{
			return (FrameworkElement)GetValue(ChildProperty);
		}
		set
		{
			SetValue(ChildProperty, value);
		}
	}

	public DockSite DockSite
	{
		get
		{
			return FGh;
		}
		internal set
		{
			if (FGh != value)
			{
				DockSite fGh = FGh;
				FGh = value;
				T27(fGh, FGh);
			}
		}
	}

	public bool IsAutoHidePopupOpen => AutoHidePopupToolWindow != null;

	protected override IEnumerator LogicalChildren
	{
		get
		{
			IEnumerator baseEnumerator = base.LogicalChildren;
			if (baseEnumerator != null)
			{
				while (baseEnumerator.MoveNext())
				{
					object current = baseEnumerator.Current;
					if (current != null)
					{
						yield return current;
					}
				}
			}
			foreach (ToolWindowContainer item in S2D())
			{
				if (item != null && (hGj == null || hGj.DTj() != item))
				{
					yield return item;
				}
			}
		}
	}

	public MdiHostBase MdiHost => veR() as MdiHostBase;

	public double SplitterSize
	{
		get
		{
			return (double)GetValue(SplitterSizeProperty);
		}
		set
		{
			SetValue(SplitterSizeProperty, value);
		}
	}

	public Guid UniqueId
	{
		get
		{
			return (Guid)GetValue(UniqueIdProperty);
		}
		internal set
		{
			SetValue(UniqueIdProperty, value);
		}
	}

	public Workspace Workspace
	{
		get
		{
			return kGg;
		}
		internal set
		{
			if (kGg == value)
			{
				return;
			}
			kGg = value;
			if (!Veu())
			{
				a2A();
				if (FGh != null)
				{
					FGh.fN6();
				}
			}
		}
	}

	internal bool CanClose
	{
		get
		{
			bool flag = true;
			kq kq = LayoutKind;
			if ((uint)(kq - 1) <= 1u && FGh != null)
			{
				flag = FGh.ToolWindowsHaveCloseButtons;
			}
			if (flag)
			{
				flag &= !pL.Mxl(this, (DockingWindow w) => !w.CanCloseResolved).Any();
			}
			return flag;
		}
	}

	internal bool IsEmpty
	{
		get
		{
			switch (LayoutKind)
			{
			default:
				return false;
			case (kq)0:
				return true;
			case (kq)3:
			{
				jJ jJ = veR();
				if (jJ != null)
				{
					return !jJ.ContainsDockingWindows;
				}
				return false;
			}
			}
		}
	}

	internal kq LayoutKind
	{
		get
		{
			return (kq)GetValue(uIe);
		}
		private set
		{
			SetValue(uIe, value);
		}
	}

	public ImageSource Icon
	{
		get
		{
			return (ImageSource)GetValue(IconProperty);
		}
		private set
		{
			SetValue(IconProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		private set
		{
			SetValue(TitleProperty, value);
		}
	}

	DockHost IDockTarget.DockHost => this;

	DockSite IDockTarget.DockSite => FGh;

	bool iy.HasDockGuides => true;

	bool iy.RequiresReverseOrderInsertion => false;

	IEnumerable<lX> lX.ChildNodes
	{
		get
		{
			foreach (ToolWindowContainer item in S2D())
			{
				yield return item;
			}
			lX lX = pGK() ?? (Child as lX);
			if (lX != null)
			{
				yield return lX;
			}
		}
	}

	internal event EventHandler Closed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = sII;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sII, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = sII;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sII, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DockHost()
	{
		IVH.CecNqz();
		jGf = new ToolWindowContainerCollection();
		fGc = new ToolWindowContainerCollection();
		pGZ = new ToolWindowContainerCollection();
		WGA = new ToolWindowContainerCollection();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockHost);
		UniqueId = Guid.NewGuid();
		hGj = new ig(this);
		beO(new Size(200.0, 200.0));
		base.SizeChanged += z2R;
		base.Unloaded += E2S;
		jGf.CollectionChanged += s2l;
		fGc.CollectionChanged += s2l;
		pGZ.CollectionChanged += s2l;
		WGA.CollectionChanged += s2l;
	}

	[SpecialName]
	internal IEnumerable<AutoHideTabStrip> s25()
	{
		if (cG4 != null)
		{
			yield return cG4;
		}
		if (qGH != null)
		{
			yield return qGH;
		}
		if (oGb != null)
		{
			yield return oGb;
		}
		if (KGU != null)
		{
			yield return KGU;
		}
	}

	[SpecialName]
	internal AutoHideTabStrip C2o()
	{
		return KGU;
	}

	[SpecialName]
	private void c2t(AutoHideTabStrip value)
	{
		KGU = value;
	}

	[SpecialName]
	internal AutoHideTabStrip c2z()
	{
		return cG4;
	}

	[SpecialName]
	private void Aei(AutoHideTabStrip value)
	{
		cG4 = value;
	}

	[SpecialName]
	internal FD few()
	{
		if (uG5 == null)
		{
			uG5 = new FD(this);
		}
		return uG5;
	}

	[SpecialName]
	internal ig cee()
	{
		return hGj;
	}

	[SpecialName]
	internal AutoHideTabStrip deI()
	{
		return oGb;
	}

	[SpecialName]
	private void Mek(AutoHideTabStrip value)
	{
		oGb = value;
	}

	[SpecialName]
	internal AutoHideTabStrip Re1()
	{
		return qGH;
	}

	[SpecialName]
	private void geN(AutoHideTabStrip value)
	{
		qGH = value;
	}

	private void E28()
	{
		if (PGX != null)
		{
			bO pGX = PGX;
			PGX = null;
			try
			{
				pGX.Close();
			}
			catch (InvalidOperationException)
			{
			}
		}
	}

	[SpecialName]
	internal Panel dem()
	{
		return PG0;
	}

	[SpecialName]
	private void wea(Panel value)
	{
		if (PG0 != null)
		{
			CloseAutoHidePopup(closeImmediately: true, blurFocus: false);
		}
		PG0 = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Point? GeB()
	{
		return EGy;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void XeK(Point? value)
	{
		EGy = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Size Hen()
	{
		return zGo;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void beO(Size value)
	{
		zGo = value;
	}

	internal IEnumerable<ToolWindowContainer> S2D()
	{
		return fGc.Concat(WGA).Concat(pGZ).Concat(jGf);
	}

	internal ToolWindowContainerCollection a2E(Side P_0)
	{
		return P_0 switch
		{
			Side.Left => fGc, 
			Side.Top => WGA, 
			Side.Right => pGZ, 
			_ => jGf, 
		};
	}

	internal Side? S2r(ToolWindowContainer P_0)
	{
		if (P_0 != null)
		{
			if (fGc.Contains(P_0))
			{
				return Side.Left;
			}
			if (WGA.Contains(P_0))
			{
				return Side.Top;
			}
			if (pGZ.Contains(P_0))
			{
				return Side.Right;
			}
			if (jGf.Contains(P_0))
			{
				return Side.Bottom;
			}
		}
		return null;
	}

	private Tuple<ToolWindowContainer, Side> T2x(ToolWindow P_0)
	{
		_003C_003Ec__DisplayClass60_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass60_0();
		CS_0024_003C_003E8__locals6.jSc = P_0;
		if (CS_0024_003C_003E8__locals6.jSc != null)
		{
			ToolWindowContainer toolWindowContainer = fGc.FirstOrDefault((ToolWindowContainer twc) => twc.Windows.Contains(CS_0024_003C_003E8__locals6.jSc));
			if (toolWindowContainer != null)
			{
				return Tuple.Create(toolWindowContainer, Side.Left);
			}
			toolWindowContainer = WGA.FirstOrDefault((ToolWindowContainer twc) => twc.Windows.Contains(CS_0024_003C_003E8__locals6.jSc));
			if (toolWindowContainer != null)
			{
				return Tuple.Create(toolWindowContainer, Side.Top);
			}
			toolWindowContainer = pGZ.FirstOrDefault((ToolWindowContainer twc) => twc.Windows.Contains(CS_0024_003C_003E8__locals6.jSc));
			if (toolWindowContainer != null)
			{
				return Tuple.Create(toolWindowContainer, Side.Right);
			}
			toolWindowContainer = jGf.FirstOrDefault((ToolWindowContainer twc) => twc.Windows.Contains(CS_0024_003C_003E8__locals6.jSc));
			if (toolWindowContainer != null)
			{
				return Tuple.Create(toolWindowContainer, Side.Bottom);
			}
		}
		return null;
	}

	[SpecialName]
	internal bool Ce8()
	{
		foreach (ToolWindowContainer item in S2D())
		{
			if (item.QE2())
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool teE()
	{
		return iGt;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void ner(bool value)
	{
		iGt = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal DateTime MeM()
	{
		return VGu;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Wev(DateTime value)
	{
		VGu = value;
	}

	[SpecialName]
	internal jJ veR()
	{
		if (kGg == null)
		{
			return null;
		}
		return kGg.qJb();
	}

	[SpecialName]
	internal void JeS(jJ value)
	{
		if (kGg != null)
		{
			kGg.oJA(value);
		}
	}

	private void s2l(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1.OldItems != null)
		{
			foreach (ToolWindowContainer item in P_1.OldItems.OfType<ToolWindowContainer>())
			{
				if (item != null)
				{
					S2Y(item, _0020: false);
					item.State = DockingWindowState.Docked;
					item.DockHost = null;
				}
			}
		}
		if (P_1.NewItems == null)
		{
			return;
		}
		foreach (ToolWindowContainer item2 in P_1.NewItems.OfType<ToolWindowContainer>())
		{
			if (item2 != null)
			{
				S2Y(item2, _0020: true);
				item2.State = DockingWindowState.AutoHide;
				item2.DockHost = this;
			}
		}
	}

	private static void r2M(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockHost dockHost = (DockHost)P_0;
		ToolWindow toolWindow = P_1.OldValue as ToolWindow;
		ToolWindow toolWindow2 = P_1.NewValue as ToolWindow;
		if (toolWindow != null)
		{
			toolWindow.IsAutoHidePopupOpen = false;
			if (dockHost.DockSite != null)
			{
				dockHost.DockSite.o1F(toolWindow);
			}
		}
		if (toolWindow2 != null)
		{
			toolWindow2.IsAutoHidePopupOpen = true;
			if (dockHost.DockSite != null)
			{
				dockHost.DockSite.P1V(toolWindow2);
			}
		}
	}

	private static void p2v(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockHost dockHost = (DockHost)P_0;
		wH wH = P_1.OldValue as wH;
		wH wH2 = P_1.NewValue as wH;
		if (wH == wH2)
		{
			return;
		}
		if (wH != null && !dockHost.teE())
		{
			wH.DockHost = null;
		}
		if (wH2 != null)
		{
			int num = 0;
			if (!g3())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			wH2.DockHost = dockHost;
		}
		dockHost.N29(P_1.OldValue as FrameworkElement, P_1.NewValue as FrameworkElement);
		if (!dockHost.Veu())
		{
			dockHost.a2A();
		}
	}

	private void T27(DockSite P_0, DockSite P_1)
	{
		if (P_0 != null)
		{
			BindingOperations.ClearBinding(this, AutoHideTabItemTemplateProperty);
			BindingOperations.ClearBinding(this, AutoHideTabItemTemplateSelectorProperty);
			BindingOperations.ClearBinding(this, FrameworkElement.DataContextProperty);
			BindingOperations.ClearBinding(this, SplitterSizeProperty);
		}
		int num;
		if (P_1 != null)
		{
			this.BindToProperty(AutoHideTabItemTemplateProperty, P_1, vVK.ssH(6764), BindingMode.OneWay);
			num = 1;
			if (!g3())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0205;
		IL_0205:
		MdiHostBase mdiHost = MdiHost;
		if (mdiHost != null && mdiHost.DockHost == this && mdiHost.DockSite != FGh)
		{
			num = 0;
			if (!g3())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_01bf:
		this.BindToProperty(AutoHideTabItemTemplateSelectorProperty, P_1, vVK.ssH(6814), BindingMode.OneWay);
		this.BindToProperty(FrameworkElement.DataContextProperty, P_1, vVK.ssH(3840), BindingMode.OneWay);
		this.BindToProperty(SplitterSizeProperty, P_1, vVK.ssH(6880), BindingMode.OneWay);
		IList<b4<wH>> list = pL.Mxl(this, (wH c) => c is ToolWindowContainer || c is TabbedMdiContainer);
		if (list != null)
		{
			int num3 = default(int);
			foreach (b4<wH> item in list)
			{
				ToolWindowContainer toolWindowContainer = item.dx3() as ToolWindowContainer;
				int num2 = 0;
				if (yr() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (toolWindowContainer != null)
				{
					toolWindowContainer.uDF();
				}
				else if (item.dx3() is TabbedMdiContainer tabbedMdiContainer)
				{
					tabbedMdiContainer.uDF();
				}
			}
		}
		goto IL_0205;
		IL_001b:
		b2H();
		p2h();
		return;
		IL_0005:
		int num4 = default(int);
		num = num4;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			goto IL_01bf;
		}
		mdiHost.DockSite = FGh;
		goto IL_001b;
	}

	private void z2R(object P_0, SizeChangedEventArgs P_1)
	{
		if (hGj != null)
		{
			hGj.uTF();
		}
	}

	private void E2S(object P_0, RoutedEventArgs P_1)
	{
		CloseAutoHidePopup(closeImmediately: true, blurFocus: false);
		if (hGj != null && hGj.DTj() != null)
		{
			hGj.FTZ(null);
		}
	}

	internal bool l2L(ToolWindow P_0)
	{
		CloseAutoHidePopup(closeImmediately: true, blurFocus: false);
		int num;
		if (FGh != null)
		{
			num = 1;
			if (!g3())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00cc;
		IL_0145:
		hGj.nTs();
		AutoHidePopupToolWindow = P_0;
		if (UIElementAutomationPeer.CreatePeerForElement(this) is DockHostAutomationPeer dockHostAutomationPeer)
		{
			dockHostAutomationPeer.ResetChildrenCache();
		}
		return true;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto end_IL_0009;
			default:
				goto IL_0097;
			}
			if (!PG0.Children.Contains(hGj))
			{
				num = 0;
				if (g3())
				{
					continue;
				}
				goto IL_0005;
			}
			goto IL_0145;
			IL_0097:
			PG0.Children.Add(hGj);
			goto IL_0145;
			continue;
			end_IL_0009:
			break;
		}
		FGh.CCu(_0020: false);
		goto IL_00cc;
		IL_00cc:
		if (P_0 != null && PG0 != null)
		{
			Tuple<ToolWindowContainer, Side> tuple = T2x(P_0);
			if (tuple != null)
			{
				ToolWindowContainer item = tuple.Item1;
				Side item2 = tuple.Item2;
				item.SelectedWindow = P_0;
				S2Y(item, _0020: false);
				hGj.Background = ((FGh != null) ? FGh.Background : base.Background);
				hGj.FTZ(item);
				hGj.VTc(item2);
				hGj.TTY();
				if (FGh != null && !FGh.IQR())
				{
					x23(P_0, item2);
					goto IL_0145;
				}
				num = 2;
				goto IL_0009;
			}
		}
		return false;
	}

	internal void x23(ToolWindow P_0, Side P_1)
	{
		PGX = new bO(PG0, hGj, bO.SO8(PG0), _0020: true, _0020: false, _0020: true, _0020: false);
		if (FGh != null)
		{
			FGh.InitializeAutoHidePopupWindow(PGX);
		}
		PGX.KOl(P_1);
		InteropFocusTracking.pm6(P_0);
	}

	internal void l26(DockingWindowState? P_0)
	{
		if (FGh != null)
		{
			IEnumerable<DockingWindow> enumerable = from r in pL.Mxl<DockingWindow>(this, null)
				select r.dx3();
			if (enumerable.Any())
			{
				FGh.s1t().Restore(enumerable, weP() ?? FGh.PrimaryDockHost, P_0);
			}
		}
	}

	private void N29(FrameworkElement P_0, FrameworkElement P_1)
	{
		if (PG0 == null)
		{
			return;
		}
		if (P_0 != null && PG0.Children.Contains(P_0))
		{
			PG0.Children.Remove(P_0);
			int num = 0;
			if (!g3())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (P_1 == null || PG0.Children.Contains(P_1))
		{
			return;
		}
		DependencyObject dependencyObject = VisualTreeHelper.GetParent(P_1);
		if (dependencyObject != null && dependencyObject is Panel panel && panel.Children.Contains(P_1))
		{
			panel.Children.Remove(P_1);
			dependencyObject = null;
		}
		if (dependencyObject == null)
		{
			if (FGh != null)
			{
				FGh.xNg(P_1, _0020: false);
			}
			PG0.Children.Insert(0, P_1);
		}
	}

	private void S2Y(ToolWindowContainer P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		if (!P_1)
		{
			if (P_0.Parent == this)
			{
				RemoveLogicalChild(P_0);
			}
		}
		else if (P_0.Parent == null)
		{
			AddLogicalChild(P_0);
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Size result = base.ArrangeOverride(finalSize);
		if (Child is wH wH)
		{
			wH.DockedSize = Child.RenderSize;
		}
		return result;
	}

	public void CloseAutoHidePopup(bool closeImmediately, bool blurFocus)
	{
		if (!IsAutoHidePopupOpen)
		{
			return;
		}
		if (blurFocus && FGh != null)
		{
			ToolWindow autoHidePopupToolWindow = AutoHidePopupToolWindow;
			if (autoHidePopupToolWindow != null)
			{
				FGh.s1t().SMo(autoHidePopupToolWindow);
			}
		}
		if (closeImmediately)
		{
			if (PG0 != null && PG0.Children.Contains(hGj))
			{
				PG0.Children.Remove(hGj);
			}
			if (FGh != null && !FGh.IQR())
			{
				E28();
			}
			ToolWindowContainer toolWindowContainer = hGj.DTj();
			hGj.FTZ(null);
			S2Y(toolWindowContainer, _0020: true);
			AutoHidePopupToolWindow = null;
			if (UIElementAutomationPeer.CreatePeerForElement(this) is DockHostAutomationPeer dockHostAutomationPeer)
			{
				dockHostAutomationPeer.ResetChildrenCache();
			}
		}
		else
		{
			hGj.lTp();
		}
	}

	public int GetVisibleToolWindowContainerCount(bool includeAutoHiddenContainers)
	{
		int num = 0;
		if (includeAutoHiddenContainers)
		{
			foreach (ToolWindowContainer item in S2D())
			{
				if (item.QE2())
				{
					num++;
				}
			}
		}
		if (Child is wH wH)
		{
			num += wH.GetVisibleToolWindowContainerCount();
		}
		return num;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		c2t(GetTemplateChild(vVK.ssH(6908)) as AutoHideTabStrip);
		Aei(GetTemplateChild(vVK.ssH(6966)) as AutoHideTabStrip);
		Mek(GetTemplateChild(vVK.ssH(7020)) as AutoHideTabStrip);
		geN(GetTemplateChild(vVK.ssH(7076)) as AutoHideTabStrip);
		wea(GetTemplateChild(vVK.ssH(7128)) as Panel);
		N29(null, Child);
		a2A();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new DockHostAutomationPeer(this);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, vVK.ssH(7164), new object[3]
		{
			GetType().Name,
			xGd(),
			Child
		});
	}

	[SpecialName]
	[CompilerGenerated]
	internal void RGl(EventHandler value)
	{
		EventHandler eventHandler = IIG;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref IIG, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void mGM(EventHandler value)
	{
		EventHandler eventHandler = IIG;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref IIG, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void tGS(EventHandler<X9> value)
	{
		EventHandler<X9> eventHandler = rIk;
		EventHandler<X9> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<X9> value2 = (EventHandler<X9>)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref rIk, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void JGL(EventHandler<X9> value)
	{
		EventHandler<X9> eventHandler = rIk;
		EventHandler<X9> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<X9> value2 = (EventHandler<X9>)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref rIk, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void tG6(EventHandler value)
	{
		EventHandler eventHandler = AIC;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref AIC, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void nG9(EventHandler value)
	{
		EventHandler eventHandler = AIC;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref AIC, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void IGp(EventHandler value)
	{
		EventHandler eventHandler = pI1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref pI1, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void fGs(EventHandler value)
	{
		EventHandler eventHandler = pI1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref pI1, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void GGF(EventHandler value)
	{
		EventHandler eventHandler = oIN;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref oIN, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void OGV(EventHandler value)
	{
		EventHandler eventHandler = oIN;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref oIN, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	internal bool bes()
	{
		return LayoutKind != (kq)1;
	}

	[SpecialName]
	internal bool feF()
	{
		switch (FGh.FloatingWindowShowInTaskBarMode)
		{
		case FloatingWindowShowInTaskBarMode.Always:
			return true;
		case FloatingWindowShowInTaskBarMode.Never:
			return false;
		default:
		{
			kq kq = LayoutKind;
			if ((uint)(kq - 3) <= 1u)
			{
				return true;
			}
			return false;
		}
		}
	}

	internal bool Close(bool forceDestroy)
	{
		bool flag = true;
		if (!eIw)
		{
			try
			{
				eIw = true;
				IEnumerable<DockingWindow> enumerable = from r in pL.Mxl<DockingWindow>(this, null)
					select r.dx3();
				if (enumerable != null && FGh != null)
				{
					Nx nx = FGh.s1t();
					if (nx != null)
					{
						flag = nx.Close(enumerable, (wU)5, forceDestroy, allowDocumentDestroy: true);
						int num = 0;
						if (!g3())
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						}
						if (!flag)
						{
							flag = !(from r in pL.Mxl<DockingWindow>(this, null)
								select r.dx3()).Any();
						}
					}
				}
				if (forceDestroy || flag)
				{
					I2f();
				}
				if ((forceDestroy || reH()) && FGh != null)
				{
					FGh.VNG(this);
				}
			}
			finally
			{
				eIw = false;
			}
		}
		else
		{
			flag = !(from r in pL.Mxl<DockingWindow>(this, null)
				select r.dx3()).Any();
		}
		return flag;
	}

	internal void m2p()
	{
		if (Meg() && IsEmpty)
		{
			Close(forceDestroy: false);
		}
	}

	[SpecialName]
	internal DockHost weP()
	{
		if (HGz != null)
		{
			if (HGz.IsAlive)
			{
				return HGz.Target as DockHost;
			}
			HGz = null;
		}
		return null;
	}

	[SpecialName]
	internal void Cef(DockHost value)
	{
		HGz = ((value != null) ? new WeakReference(value) : null);
	}

	internal void P2s(Point P_0, InputPointerEventArgs P_1)
	{
		F2U(new X9(P_0, P_1));
	}

	[SpecialName]
	internal DockingWindowState? Kec()
	{
		return JIi;
	}

	[SpecialName]
	internal void me4(DockingWindowState? value)
	{
		if (value == DockingWindowState.AutoHide)
		{
			value = DockingWindowState.Docked;
		}
		JIi = value;
	}

	[SpecialName]
	internal WindowState zeZ()
	{
		return FId;
	}

	[SpecialName]
	internal void Qeb(WindowState value)
	{
		if (FId != value)
		{
			FId = value;
			b2c();
			n2b();
		}
	}

	internal void m2q()
	{
		if (Meg() && Re5())
		{
			I2f();
		}
	}

	internal void o2F(bool P_0)
	{
		if (Meg() && !Re5() && FGh != null)
		{
			FGh.I1o(this, null, default(Point), _0020: false)?.Vmu(_0020: true, P_0, _0020: false);
		}
	}

	[SpecialName]
	private bool reH()
	{
		switch (LayoutKind)
		{
		default:
			return false;
		case (kq)0:
			return Child == null;
		case (kq)3:
		{
			jJ jJ = veR();
			if (jJ == null)
			{
				return false;
			}
			if (jJ.ContainsDockingWindows)
			{
				return false;
			}
			if (pL.Mxl<bv>(jJ, null).Any())
			{
				return false;
			}
			return true;
		}
		}
	}

	[SpecialName]
	internal bool Meg()
	{
		if (FGh == null)
		{
			return false;
		}
		return FGh.PrimaryDockHost != this;
	}

	[SpecialName]
	internal bool Re5()
	{
		return VisualTreeHelper.GetParent(this) != null;
	}

	[SpecialName]
	internal bool reo()
	{
		return Kec().HasValue;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool Veu()
	{
		return RIQ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void zez(bool value)
	{
		RIQ = value;
	}

	[SpecialName]
	internal bool xGd()
	{
		if (FGh == null)
		{
			return false;
		}
		return FGh.PrimaryDockHost == this;
	}

	[SpecialName]
	internal bool aG2()
	{
		return pGK() != null;
	}

	[SpecialName]
	internal bool zGG()
	{
		return pGK() is DocumentWindow;
	}

	[SpecialName]
	internal Size OG1()
	{
		return SI2;
	}

	[SpecialName]
	internal void nGN(Size value)
	{
		if (SI2 != value)
		{
			SI2 = value;
			e2j();
		}
	}

	private static void J2V(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockHost obj = (DockHost)P_0;
		obj.b2H();
		obj.n2b();
		obj.u20();
		obj.o24();
	}

	private void i2P()
	{
		IIG?.Invoke(this, EventArgs.Empty);
	}

	private void I2f()
	{
		sII?.Invoke(this, EventArgs.Empty);
	}

	private void F2U(X9 P_0)
	{
		EventHandler<X9> eventHandler = rIk;
		if (eventHandler != null)
		{
			eventHandler(this, P_0);
		}
		else
		{
			me4(null);
		}
	}

	private void b2c()
	{
		AIC?.Invoke(this, EventArgs.Empty);
	}

	internal void o24()
	{
		pI1?.Invoke(this, EventArgs.Empty);
	}

	internal void e2j()
	{
		oIN?.Invoke(this, EventArgs.Empty);
	}

	internal void i2Z()
	{
		i2P();
	}

	[SpecialName]
	internal bool wGm()
	{
		return !feF();
	}

	[SpecialName]
	internal bool BGW()
	{
		if (LayoutKind == (kq)1)
		{
			return !FGh.ToolWindowsHaveTitleBars;
		}
		return true;
	}

	internal void n2b()
	{
		IList<b4<ToolWindowContainer>> list = pL.Mxl<ToolWindowContainer>(this, null);
		if (list == null)
		{
			return;
		}
		foreach (b4<ToolWindowContainer> item in list)
		{
			ToolWindowContainer toolWindowContainer = item.dx3();
			if (toolWindowContainer == null)
			{
				continue;
			}
			toolWindowContainer.CDs();
			foreach (DockingWindow window in toolWindowContainer.Windows)
			{
				window?.UpdateCommands();
			}
		}
	}

	internal bool a2A()
	{
		kq kq = (kq)0;
		if (aG2())
		{
			kq = ((!zGG()) ? ((kq)1) : ((kq)3));
		}
		else if (kGg != null)
		{
			kq = ((GetVisibleToolWindowContainerCount(includeAutoHiddenContainers: true) <= 0) ? ((kq)3) : ((kq)4));
		}
		else
		{
			int visibleToolWindowContainerCount = GetVisibleToolWindowContainerCount(includeAutoHiddenContainers: true);
			if (visibleToolWindowContainerCount > 1)
			{
				kq = (kq)2;
			}
			else if (visibleToolWindowContainerCount == 1)
			{
				kq = ((GetVisibleToolWindowContainerCount(includeAutoHiddenContainers: false) != 0) ? ((kq)1) : ((kq)2));
			}
		}
		if (LayoutKind != kq)
		{
			LayoutKind = kq;
			return true;
		}
		return false;
	}

	private void b2H()
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (FGh != null)
					{
						if (!Meg())
						{
							flag = true;
						}
						else
						{
							kq kq = LayoutKind;
							if ((uint)(kq - 3) <= 1u)
							{
								flag = true;
							}
						}
					}
					if (flag)
					{
						this.BindToProperty(Control.PaddingProperty, FGh, vVK.ssH(3582), BindingMode.OneWay);
					}
					else
					{
						BindingOperations.ClearBinding(this, Control.PaddingProperty);
					}
					return;
				case 1:
					break;
				}
				flag = false;
				num2 = 0;
			}
			while (g3());
		}
	}

	internal void u20()
	{
		double num = 0.0;
		double num2 = 0.0;
		if (Meg())
		{
			kq kq = LayoutKind;
			if ((uint)(kq - 1) <= 1u && Child is wH { MinSize: var minSize })
			{
				num = Math.Max(num, minSize.Width);
				num2 = Math.Max(num2, minSize.Height);
			}
			num = Math.Max(num, 136.0);
			num2 = Math.Max(num2, 50.0);
		}
		nGN(new Size(num, num2));
	}

	internal void p2h()
	{
		Title = ((FGh != null) ? FGh.FloatingWindowTitle : null) ?? string.Empty;
		Icon = ((FGh != null) ? FGh.FloatingWindowIcon : null);
	}

	[SpecialName]
	[CompilerGenerated]
	internal lX pGK()
	{
		return sIm;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void MGJ(lX value)
	{
		sIm = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Func<Nx, DockHost, bool, lX> PGO()
	{
		return EIa;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void uGT(Func<Nx, DockHost, bool, lX> value)
	{
		EIa = value;
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		return DockingWindowState.Docked;
	}

	bool iy.SupportsAttach(DockHost draggedDockHost)
	{
		return false;
	}

	bool iy.SupportsInnerSideDock(DockHost draggedDockHost)
	{
		return false;
	}

	bool iy.SupportsOuterSideDock(DockHost draggedDockHost)
	{
		if (draggedDockHost != null)
		{
			kq kq = draggedDockHost.LayoutKind;
			if ((uint)(kq - 1) <= 1u)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	internal bool uGr()
	{
		ToolWindow autoHidePopupToolWindow = AutoHidePopupToolWindow;
		if (autoHidePopupToolWindow != null)
		{
			if (FGh != null && !FGh.AutoHidePopupClosesOnLostFocus)
			{
				int num = 0;
				if (yr() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => autoHidePopupToolWindow.IsActive, 
				};
			}
			if (autoHidePopupToolWindow.Parent is ToolWindowContainer { IsActive: not false })
			{
				return true;
			}
		}
		return false;
	}

	internal bool R2g(KeyEventArgs P_0)
	{
		if (P_0 != null && !P_0.Handled && FGh != null)
		{
			SwitcherBase switcher = FGh.Switcher;
			if (switcher != null)
			{
				if (!switcher.IsOpen)
				{
					return switcher.IsActivationKey(P_0);
				}
				return true;
			}
		}
		return false;
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (base.IsKeyboardFocusWithin)
		{
			Wev(DateTime.Now);
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		if (FGh != null && !R2g(e))
		{
			FGh.ProcessDockHostKeyDown(this, e);
		}
		base.OnKeyDown(e);
	}

	protected override void OnPreviewKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		if (FGh != null && R2g(e))
		{
			FGh.ProcessDockHostKeyDown(this, e);
		}
		base.OnPreviewKeyDown(e);
	}

	static DockHost()
	{
		IVH.CecNqz();
		AutoHidePopupToolWindowProperty = DependencyProperty.Register(vVK.ssH(7242), typeof(ToolWindow), typeof(DockHost), new PropertyMetadata(null, r2M));
		AutoHideTabItemTemplateProperty = DependencyProperty.Register(vVK.ssH(6764), typeof(DataTemplate), typeof(DockHost), new PropertyMetadata(null));
		AutoHideTabItemTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(6814), typeof(DataTemplateSelector), typeof(DockHost), new PropertyMetadata(null));
		ChildProperty = DependencyProperty.Register(vVK.ssH(7292), typeof(FrameworkElement), typeof(DockHost), new PropertyMetadata(null, p2v));
		SplitterSizeProperty = DependencyProperty.Register(vVK.ssH(6880), typeof(double), typeof(DockHost), new PropertyMetadata(5.0));
		UniqueIdProperty = DependencyProperty.Register(vVK.ssH(7306), typeof(Guid), typeof(DockHost), new PropertyMetadata(Guid.Empty));
		IconProperty = DependencyProperty.Register(vVK.ssH(7326), typeof(ImageSource), typeof(DockHost), new PropertyMetadata(null));
		uIe = DependencyProperty.Register(vVK.ssH(6420), typeof(kq), typeof(DockHost), new PropertyMetadata((kq)0, J2V));
		TitleProperty = DependencyProperty.Register(vVK.ssH(7338), typeof(string), typeof(DockHost), new PropertyMetadata(string.Empty));
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator o2X()
	{
		return base.LogicalChildren;
	}

	internal static bool g3()
	{
		return wV == null;
	}

	internal static DockHost yr()
	{
		return wV;
	}
}
