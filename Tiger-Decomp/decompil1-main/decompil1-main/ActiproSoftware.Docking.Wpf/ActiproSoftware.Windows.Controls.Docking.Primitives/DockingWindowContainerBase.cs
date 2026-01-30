using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[TemplateVisualState(Name = "TabStripLeft", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "TabStripBottom", GroupName = "TabStripPlacementStates")]
[TemplatePart(Name = "PART_TabControl", Type = typeof(AdvancedTabControl))]
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[TemplateVisualState(Name = "TabStripTop", GroupName = "TabStripPlacementStates")]
[TemplateVisualState(Name = "TabStripRight", GroupName = "TabStripPlacementStates")]
public abstract class DockingWindowContainerBase : Control, G0, Xk, wH, lX, IOrientedElement
{
	[CompilerGenerated]
	private sealed class _003CGetVisibleTabs_003Ed__36 : IEnumerable<AdvancedTabItem>, IEnumerable, IEnumerator<AdvancedTabItem>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private AdvancedTabItem _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DockingWindowContainerBase _003C_003E4__this;

		private int _003Cindex_003E5__2;

		internal static _003CGetVisibleTabs_003Ed__36 lci;

		AdvancedTabItem IEnumerator<AdvancedTabItem>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetVisibleTabs_003Ed__36(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			DockingWindowContainerBase dockingWindowContainerBase = _003C_003E4__this;
			if (num == 0)
			{
				_003C_003E1__state = -1;
				if (dockingWindowContainerBase.rEJ != null)
				{
					if (dockingWindowContainerBase.IsTabStripVisible)
					{
						_003Cindex_003E5__2 = 0;
						goto IL_0114;
					}
					int num2 = 0;
					if (!ucZ())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_00f1;
					}
				}
				goto IL_00ef;
			}
			if (num == 1)
			{
				_003C_003E1__state = -1;
				goto IL_005c;
			}
			return false;
			IL_00ef:
			return false;
			IL_005c:
			_003Cindex_003E5__2++;
			goto IL_0114;
			IL_00f1:
			if (dockingWindowContainerBase.rEJ.ItemContainerGenerator.ContainerFromIndex(_003Cindex_003E5__2) is AdvancedTabItem advancedTabItem)
			{
				_003C_003E2__current = advancedTabItem;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_005c;
			IL_0114:
			if (_003Cindex_003E5__2 >= dockingWindowContainerBase.rEJ.Items.Count)
			{
				goto IL_00ef;
			}
			goto IL_00f1;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<AdvancedTabItem> IEnumerable<AdvancedTabItem>.GetEnumerator()
		{
			_003CGetVisibleTabs_003Ed__36 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetVisibleTabs_003Ed__36(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<AdvancedTabItem>)this).GetEnumerator();
		}

		internal static bool ucZ()
		{
			return lci == null;
		}

		internal static _003CGetVisibleTabs_003Ed__36 Kcu()
		{
			return lci;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public DockingWindowContainerBase c67;

		public OB F6R;

		public DockingWindow I6S;

		private static _003C_003Ec__DisplayClass50_0 Jcy;

		public _003C_003Ec__DisplayClass50_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal void j6v()
		{
			DockHost dockHost = c67.DockHost;
			if (dockHost != null && dockHost.Meg() && pL.Mxl<DockingWindow>(dockHost, null).Count == 1)
			{
				dockHost.P2s(F6R.p2N(), F6R.G2k());
			}
			else
			{
				c67.REK.s1t().HvI(I6S, F6R.p2N(), F6R.G2k());
			}
		}

		internal static bool kcV()
		{
			return Jcy == null;
		}

		internal static _003C_003Ec__DisplayClass50_0 Wc3()
		{
			return Jcy;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_LogicalChildren_003Ed__88 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DockingWindowContainerBase _003C_003E4__this;

		private IEnumerator<DockingWindow> _003C_003E7__wrap1;

		private static _003Cget_LogicalChildren_003Ed__88 yM1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003Cget_LogicalChildren_003Ed__88(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2 = 0;
				if (!iMH())
				{
					goto IL_0026;
				}
				goto IL_002a;
				IL_0026:
				int num3 = default(int);
				num2 = num3;
				goto IL_002a;
				IL_002a:
				DockingWindowContainerBase dockingWindowContainerBase = default(DockingWindowContainerBase);
				do
				{
					switch (num2)
					{
					case 1:
						if (num == 0)
						{
							_003C_003E1__state = -1;
							_003C_003E7__wrap1 = dockingWindowContainerBase.WindowsCore.GetEnumerator();
							_003C_003E1__state = -3;
						}
						else
						{
							if (num != 1)
							{
								return false;
							}
							_003C_003E1__state = -3;
						}
						while (_003C_003E7__wrap1.MoveNext())
						{
							DockingWindow current = _003C_003E7__wrap1.Current;
							if (current != null)
							{
								_003C_003E2__current = current;
								_003C_003E1__state = 1;
								return true;
							}
						}
						_003C_003Em__Finally1();
						_003C_003E7__wrap1 = null;
						return false;
					}
					dockingWindowContainerBase = _003C_003E4__this;
					num2 = 1;
				}
				while (MMf() == null);
				goto IL_0026;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool iMH()
		{
			return yM1 == null;
		}

		internal static _003Cget_LogicalChildren_003Ed__88 MMf()
		{
			return yM1;
		}
	}

	private Size MEm;

	private Size MEa;

	private ObservableCollection<lX> hEW;

	private DockHost FEB;

	private DockSite REK;

	private AdvancedTabControl rEJ;

	private ObservableCollection<DockingWindow> NEn;

	public static readonly DependencyProperty CanTabsCloseOnMiddleClickProperty;

	public static readonly DependencyProperty HasTabImagesProperty;

	public static readonly DependencyProperty IsActiveProperty;

	public static readonly DependencyProperty IsTabLayoutAnimationEnabledProperty;

	public static readonly DependencyProperty IsTabLayoutAnimationEnabledResolvedProperty;

	public static readonly DependencyProperty IsTabStripVisibleProperty;

	public static readonly DependencyProperty MaxTabExtentProperty;

	public static readonly DependencyProperty MinTabExtentProperty;

	public static readonly DependencyProperty SelectedWindowProperty;

	public static readonly DependencyProperty StateProperty;

	public static readonly DependencyProperty TabControlStyleProperty;

	public static readonly DependencyProperty TabItemContainerStyleProperty;

	public static readonly DependencyProperty TabOverflowBehaviorProperty;

	public static readonly DependencyProperty TabStripPlacementProperty;

	[CompilerGenerated]
	private bool GEO;

	private ContextMenu YET;

	private Popup WE8;

	internal static DockingWindowContainerBase YnM;

	public bool CanTabsCloseOnMiddleClick
	{
		get
		{
			return (bool)GetValue(CanTabsCloseOnMiddleClickProperty);
		}
		set
		{
			SetValue(CanTabsCloseOnMiddleClickProperty, value);
		}
	}

	public DockHost DockHost
	{
		get
		{
			return FEB;
		}
		internal set
		{
			if (FEB != value)
			{
				FEB = value;
				uDF();
				UpdateDockingWindowStates();
			}
		}
	}

	public DockSite DockSite
	{
		get
		{
			return REK;
		}
		private set
		{
			if (REK != value)
			{
				DockSite rEK = REK;
				REK = value;
				OnDockSiteChanged(rEK, REK);
			}
		}
	}

	public bool HasTabImages
	{
		get
		{
			return (bool)GetValue(HasTabImagesProperty);
		}
		set
		{
			SetValue(HasTabImagesProperty, value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(IsActiveProperty);
		}
		private set
		{
			SetValue(IsActiveProperty, value);
		}
	}

	public bool IsTabLayoutAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsTabLayoutAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsTabLayoutAnimationEnabledProperty, value);
		}
	}

	public bool IsTabLayoutAnimationEnabledResolved
	{
		get
		{
			return (bool)GetValue(IsTabLayoutAnimationEnabledResolvedProperty);
		}
		private set
		{
			SetValue(IsTabLayoutAnimationEnabledResolvedProperty, value);
		}
	}

	public bool IsTabStripVisible
	{
		get
		{
			return (bool)GetValue(IsTabStripVisibleProperty);
		}
		protected set
		{
			SetValue(IsTabStripVisibleProperty, value);
		}
	}

	protected override IEnumerator LogicalChildren
	{
		get
		{
			int num2 = default(int);
			DockingWindowContainerBase dockingWindowContainerBase = default(DockingWindowContainerBase);
			IEnumerator<DockingWindow> enumerator = default(IEnumerator<DockingWindow>);
			int num4 = default(int);
			while (true)
			{
				int num = num2;
				int num3 = 0;
				if (!_003Cget_LogicalChildren_003Ed__88.iMH())
				{
					goto IL_0026;
				}
				goto IL_002a;
				IL_002a:
				while (true)
				{
					switch (num3)
					{
					case 1:
						break;
					default:
						goto IL_011c;
					}
					break;
					IL_011c:
					dockingWindowContainerBase = this;
					num3 = 1;
					if (_003Cget_LogicalChildren_003Ed__88.MMf() == null)
					{
						continue;
					}
					goto IL_0026;
				}
				switch (num)
				{
				default:
					yield break;
				case 0:
					dockingWindowContainerBase.WindowsCore.GetEnumerator();
					goto IL_00e3;
				case 1:
					{
						try
						{
							goto IL_00e3;
							IL_00e3:
							while (enumerator.MoveNext())
							{
								DockingWindow current = enumerator.Current;
								if (current != null)
								{
									yield return current;
									goto end_IL_013b;
								}
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
						yield break;
					}
					end_IL_013b:
					break;
				}
				continue;
				IL_0026:
				num3 = num4;
				goto IL_002a;
			}
		}
	}

	public double MaxTabExtent
	{
		get
		{
			return (double)GetValue(MaxTabExtentProperty);
		}
		set
		{
			SetValue(MaxTabExtentProperty, value);
		}
	}

	public double MinTabExtent
	{
		get
		{
			return (double)GetValue(MinTabExtentProperty);
		}
		set
		{
			SetValue(MinTabExtentProperty, value);
		}
	}

	public DockingWindow SelectedWindow
	{
		get
		{
			return (DockingWindow)GetValue(SelectedWindowProperty);
		}
		set
		{
			SetValue(SelectedWindowProperty, value);
		}
	}

	public DockingWindowState State
	{
		get
		{
			return (DockingWindowState)GetValue(StateProperty);
		}
		internal set
		{
			SetValue(StateProperty, value);
		}
	}

	protected internal AdvancedTabControl TabControl
	{
		get
		{
			return rEJ;
		}
		private set
		{
			if (rEJ != value)
			{
				if (rEJ != null)
				{
					rEJ.MenuOpening -= BDv;
					rEJ.NewTabRequested -= FD7;
					rEJ.TabClosing -= cDR;
					rEJ.Odo(WDS);
					rEJ.TabDragReordered -= CD3;
				}
				rEJ = value;
				if (rEJ != null)
				{
					rEJ.MenuOpening += BDv;
					rEJ.NewTabRequested += FD7;
					rEJ.TabClosing += cDR;
					rEJ.Rdy(WDS);
					rEJ.TabDragReordered += CD3;
				}
			}
		}
	}

	public Style TabControlStyle
	{
		get
		{
			return (Style)GetValue(TabControlStyleProperty);
		}
		set
		{
			SetValue(TabControlStyleProperty, value);
		}
	}

	public Style TabItemContainerStyle
	{
		get
		{
			return (Style)GetValue(TabItemContainerStyleProperty);
		}
		set
		{
			SetValue(TabItemContainerStyleProperty, value);
		}
	}

	public TabOverflowBehavior TabOverflowBehavior
	{
		get
		{
			return (TabOverflowBehavior)GetValue(TabOverflowBehaviorProperty);
		}
		set
		{
			SetValue(TabOverflowBehaviorProperty, value);
		}
	}

	public Side TabStripPlacement
	{
		get
		{
			return (Side)GetValue(TabStripPlacementProperty);
		}
		set
		{
			SetValue(TabStripPlacementProperty, value);
		}
	}

	protected internal ObservableCollection<DockingWindow> WindowsCore => NEn;

	bool G0.IsActive
	{
		get
		{
			return IsActive;
		}
		set
		{
			IsActive = value;
		}
	}

	DockingWindow G0.SelectedWindow
	{
		get
		{
			return SelectedWindow;
		}
		set
		{
			if (value != null && SelectedWindow != value && WindowsCore.Contains(value))
			{
				SelectedWindow = value;
			}
		}
	}

	IEnumerable<DockingWindow> G0.Windows => WindowsCore;

	bool wH.ContainsDockingWindows => QE2();

	bool wH.ContainsWorkspace => false;

	Size wH.DockedSize
	{
		get
		{
			return cEG();
		}
		set
		{
			IEI(value);
		}
	}

	DockHost wH.DockHost
	{
		get
		{
			return DockHost;
		}
		set
		{
			DockHost = value;
		}
	}

	Size wH.MaxSize => aEC();

	Size wH.MinSize => bEN();

	IEnumerable<lX> lX.ChildNodes => hEW.OfType<lX>();

	Orientation IOrientedElement.Orientation
	{
		get
		{
			if (rEJ == null)
			{
				return Orientation.Vertical;
			}
			return rEJ.zdc();
		}
	}

	protected DockingWindowContainerBase()
	{
		IVH.CecNqz();
		MEm = new Size(double.PositiveInfinity, double.PositiveInfinity);
		MEa = new Size(30.0, 30.0);
		hEW = new ObservableCollection<lX>();
		NEn = new ObservableCollection<DockingWindow>();
		base._002Ector();
		NEn.CollectionChanged += mD6;
		base.Loaded += xDj;
	}

	internal void sDO(bv P_0)
	{
		if (P_0 != null)
		{
			hEW.Add(P_0);
		}
	}

	internal void YDT()
	{
		if (rEJ != null)
		{
			DockingWindow selectedWindow = SelectedWindow;
			if (selectedWindow != null)
			{
				rEJ.qb(selectedWindow);
			}
		}
	}

	[SpecialName]
	private bool UDZ()
	{
		if (State == DockingWindowState.AutoHide)
		{
			return IsActive;
		}
		return true;
	}

	[SpecialName]
	internal ObservableCollection<lX> RDA()
	{
		return hEW;
	}

	[SpecialName]
	internal bool BD0()
	{
		return hEW.Count > 0;
	}

	internal IEnumerable<AdvancedTabItem> zD8()
	{
		if (rEJ == null)
		{
			yield break;
		}
		int index = default(int);
		if (IsTabStripVisible)
		{
			index = 0;
			goto IL_0114;
		}
		int num = 0;
		if (!_003CGetVisibleTabs_003Ed__36.ucZ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			yield break;
		case 1:
			break;
		}
		goto IL_006b;
		IL_0114:
		if (index >= rEJ.Items.Count)
		{
			yield break;
		}
		goto IL_006b;
		IL_006b:
		if (rEJ.ItemContainerGenerator.ContainerFromIndex(index) is AdvancedTabItem advancedTabItem)
		{
			yield return advancedTabItem;
		}
		index++;
		goto IL_0114;
	}

	private void KDD()
	{
		for (DependencyObject parent = VisualTreeHelper.GetParent(this); parent != null; parent = VisualTreeHelper.GetParent(parent))
		{
			if (parent is SplitContainerPanel splitContainerPanel)
			{
				splitContainerPanel.InvalidateMeasure();
			}
			else if (parent is DockHost)
			{
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool YDg()
	{
		return GEO;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void qDX(bool value)
	{
		GEO = value;
	}

	internal bool gDE(Point P_0)
	{
		if (rEJ != null && IsTabStripVisible)
		{
			AdvancedTabPanel advancedTabPanel = rEJ.edP();
			if (advancedTabPanel != null)
			{
				return advancedTabPanel.TransformToVisual(this).TransformBounds(new Rect(default(Point), advancedTabPanel.RenderSize)).Contains(P_0);
			}
		}
		return false;
	}

	private static void LDr(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindowContainerBase dockingWindowContainerBase = (DockingWindowContainerBase)P_0;
		DockingWindow selectedWindow = dockingWindowContainerBase.SelectedWindow;
		if (selectedWindow != null)
		{
			selectedWindow.IsSelected = dockingWindowContainerBase.UDZ();
		}
		dockingWindowContainerBase.UpdateVisualState(useTransitions: true);
		dockingWindowContainerBase.oDq();
	}

	private static void bDx(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindowContainerBase)P_0).vDV();
	}

	private static void QDl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindowContainerBase dockingWindowContainerBase = (DockingWindowContainerBase)P_0;
		DockingWindow dockingWindow = (DockingWindow)P_1.OldValue;
		DockingWindow dockingWindow2 = (DockingWindow)P_1.NewValue;
		if (dockingWindow != null)
		{
			dockingWindow.IsSelected = false;
		}
		if (dockingWindow2 != null)
		{
			dockingWindow2.IsSelected = dockingWindowContainerBase.UDZ();
			int num = 0;
			if (tnL() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		dockingWindowContainerBase.CDs();
		dockingWindowContainerBase.oDq();
		dockingWindowContainerBase.OnSelectedWindowChanged(dockingWindow, dockingWindow2);
	}

	private static void HDM(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindowContainerBase dockingWindowContainerBase = (DockingWindowContainerBase)P_0;
		dockingWindowContainerBase.CDs();
		dockingWindowContainerBase.UpdateIsTabStripVisible();
		dockingWindowContainerBase.UpdateVisualState(useTransitions: false);
		DockingWindow selectedWindow = dockingWindowContainerBase.SelectedWindow;
		if (selectedWindow != null)
		{
			selectedWindow.IsSelected = dockingWindowContainerBase.UDZ();
		}
	}

	private void BDv(object P_0, AdvancedTabControlMenuEventArgs P_1)
	{
		OnTabControlMenuOpening(P_1);
	}

	private void FD7(object P_0, EventArgs P_1)
	{
		if (REK != null)
		{
			DockingWindow activeWindow = REK.ActiveWindow;
			if (activeWindow != null && SelectedWindow != activeWindow)
			{
				SelectedWindow.Activate(focus: true);
			}
			REK.N1Y();
		}
	}

	private void cDR(object P_0, AdvancedTabItemEventArgs P_1)
	{
		if (P_1 != null && P_1.TabItem != null && P_1.TabItem.DataContext is DockingWindow dockingWindow)
		{
			P_1.Cancel = true;
			if (dockingWindow.CanCloseResolved)
			{
				dockingWindow.Close();
			}
		}
	}

	private void WDS(object P_0, OB P_1)
	{
		_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass50_0();
		CS_0024_003C_003E8__locals17.c67 = this;
		CS_0024_003C_003E8__locals17.F6R = P_1;
		if (REK == null || CS_0024_003C_003E8__locals17.F6R == null || CS_0024_003C_003E8__locals17.F6R.TabItem == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals17.I6S = CS_0024_003C_003E8__locals17.F6R.TabItem.DataContext as DockingWindow;
		if (CS_0024_003C_003E8__locals17.I6S == null || !CS_0024_003C_003E8__locals17.I6S.CanDragTabResolved)
		{
			return;
		}
		CS_0024_003C_003E8__locals17.F6R.Cancel = true;
		CS_0024_003C_003E8__locals17.F6R.i2W(delegate
		{
			DockHost dockHost = CS_0024_003C_003E8__locals17.c67.DockHost;
			if (dockHost != null && dockHost.Meg() && pL.Mxl<DockingWindow>(dockHost, null).Count == 1)
			{
				dockHost.P2s(CS_0024_003C_003E8__locals17.F6R.p2N(), CS_0024_003C_003E8__locals17.F6R.G2k());
			}
			else
			{
				CS_0024_003C_003E8__locals17.c67.REK.s1t().HvI(CS_0024_003C_003E8__locals17.I6S, CS_0024_003C_003E8__locals17.F6R.p2N(), CS_0024_003C_003E8__locals17.F6R.G2k());
			}
		});
	}

	private static void dDL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindowContainerBase)P_0).UpdateVisualState(useTransitions: false);
	}

	private void CD3(object P_0, AdvancedTabItemEventArgs P_1)
	{
		if (REK != null && P_1 != null && P_1.TabItem != null && P_1.TabItem.DataContext is DockingWindow dockingWindow)
		{
			DockingWindow[] array = new DockingWindow[1] { dockingWindow };
			REK.D1A(array);
			REK.O1b(array);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void mD6(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (P_1.Action == NotifyCollectionChangedAction.Reset && !DesignerProperties.GetIsInDesignMode(this))
		{
			throw new NotSupportedException();
		}
		bool flag = P_1.Action == NotifyCollectionChangedAction.Move && P_1.OldItems != null && P_1.NewItems != null && P_1.OldItems.Count == 1 && P_1.NewItems.Count == 1 && P_1.OldItems[0] == P_1.NewItems[0];
		if (P_1.OldItems != null)
		{
			if (!flag)
			{
				DockingWindow selectedWindow = SelectedWindow;
				if (selectedWindow != null && P_1.OldItems.Contains(selectedWindow))
				{
					switch (NEn.Count)
					{
					case 0:
						SelectedWindow = null;
						break;
					case 1:
						SelectedWindow = NEn[0];
						break;
					default:
					{
						DockingWindow dockingWindow = NEn.OrderByDescending((DockingWindow w) => w.LastActiveDateTime).FirstOrDefault();
						int index = Math.Max(0, Math.Min(P_1.OldStartingIndex, NEn.Count - 1));
						if (dockingWindow.LastActiveDateTime == NEn[index].LastActiveDateTime)
						{
							SelectedWindow = NEn[index];
						}
						else
						{
							SelectedWindow = dockingWindow;
						}
						break;
					}
					}
				}
			}
			foreach (object oldItem in P_1.OldItems)
			{
				if (oldItem is DockingWindow dockingWindow2)
				{
					RemoveLogicalChild(dockingWindow2);
					hEW.Remove(dockingWindow2);
					dockingWindow2.IsCurrentlyOpen = false;
					dockingWindow2.IsSelected = false;
					dockingWindow2.qkb(null);
				}
			}
		}
		if (P_1.NewItems != null)
		{
			int num = (YDg() ? (hEW.Count - 1) : (-1));
			if (P_1.NewStartingIndex > 0 && P_1.NewStartingIndex < NEn.Count)
			{
				DockingWindow dockingWindow3 = NEn[P_1.NewStartingIndex - 1];
				if (dockingWindow3 != null)
				{
					num = hEW.IndexOf(dockingWindow3);
				}
			}
			if (num != -1)
			{
				for (; num + 1 < hEW.Count && hEW[num + 1] is bv; num++)
				{
				}
			}
			foreach (object newItem in P_1.NewItems)
			{
				if (newItem is DockingWindow dockingWindow4)
				{
					ValidateChildType(dockingWindow4);
					dockingWindow4.qkb(this);
					dockingWindow4.zIH(State);
					dockingWindow4.IsCurrentlyOpen = true;
					dockingWindow4.IsSelected = false;
					int num2 = hEW.IndexOf(dockingWindow4);
					if (num2 != -1)
					{
						num = num2;
					}
					else
					{
						hEW.Insert(++num, dockingWindow4);
					}
					AddLogicalChild(dockingWindow4);
					DockSite dockSite = DockSite;
					if (dockSite != null)
					{
						dockingWindow4.DockSite = dockSite;
					}
				}
			}
		}
		if (FEB != null)
		{
			FEB.u20();
		}
		base.Visibility = ((!QE2()) ? Visibility.Collapsed : Visibility.Visible);
		if (NEn.Count == 0)
		{
			SelectedWindow = null;
		}
		else if (SelectedWindow == null)
		{
			SelectedWindow = NEn[0];
		}
		UpdateIsTabStripVisible();
		Size mEa = MEa;
		Size mEm = MEm;
		MEa = tDf();
		MEm = BDP();
		if ((mEa != MEa || mEm != MEm) && base.IsLoaded)
		{
			KDD();
		}
		OnWindowsChanged(P_1);
	}

	internal void DD9(bv P_0)
	{
		if (P_0 != null)
		{
			int num = hEW.IndexOf(P_0);
			if (num != -1)
			{
				hEW.RemoveAt(num);
			}
		}
	}

	internal bool nDY(bv P_0, DockingWindow P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			int num = hEW.IndexOf(P_0);
			if (num != -1)
			{
				hEW.RemoveAt(num);
				hEW.Insert(num, P_1);
				if (State != DockingWindowState.AutoHide)
				{
					Tuple<SplitContainer, Control> tuple = SplitContainer.Lm5(this);
					if (FEB != null && tuple != null)
					{
						if (tuple.Item1.Orientation == Orientation.Horizontal)
						{
							P_1.ContainerDockedSize = new Size(P_0.ContainerDockedSize.Width, tuple.Item1.Daa().Height);
						}
						else
						{
							P_1.ContainerDockedSize = new Size(tuple.Item1.Daa().Width, P_0.ContainerDockedSize.Height);
						}
					}
					else if (base.ActualWidth > 0.0 && base.ActualHeight > 0.0)
					{
						P_1.ContainerDockedSize = new Size(Math.Max(P_1.ContainerMinSizeResolved.Width, Math.Min(P_1.ContainerMaxSizeResolved.Width, base.ActualWidth)), Math.Max(P_1.ContainerMinSizeResolved.Height, Math.Min(P_1.ContainerMaxSizeResolved.Height, base.ActualHeight)));
					}
				}
				int index = 0;
				if (num > 0 && num <= hEW.Count)
				{
					DockingWindow dockingWindow = null;
					for (int num2 = num - 1; num2 >= 0; num2--)
					{
						dockingWindow = hEW[num2] as DockingWindow;
						if (dockingWindow != null)
						{
							int num3 = WindowsCore.IndexOf(dockingWindow);
							if (num3 != -1)
							{
								index = num3 + 1;
								break;
							}
							dockingWindow = null;
						}
					}
					if (dockingWindow == null)
					{
						for (int i = num + 1; i < hEW.Count; i++)
						{
							if (hEW[i] is DockingWindow item)
							{
								int num4 = WindowsCore.IndexOf(item);
								if (num4 != -1)
								{
									index = num4;
									break;
								}
								DockingWindow dockingWindow2 = null;
							}
						}
					}
				}
				WindowsCore.Insert(index, P_1);
				KDD();
				return true;
			}
		}
		return false;
	}

	internal void pDp(DockingWindow P_0)
	{
		if (P_0 != null)
		{
			int num = hEW.IndexOf(P_0);
			if (num != -1)
			{
				bv item = new bv(P_0);
				hEW.Insert(num, item);
			}
			WindowsCore.Remove(P_0);
		}
	}

	[SpecialName]
	internal Size TDy()
	{
		if (rEJ != null)
		{
			AdvancedTabPanel advancedTabPanel = rEJ.edP();
			if (advancedTabPanel != null)
			{
				return advancedTabPanel.RenderSize;
			}
		}
		return default(Size);
	}

	internal void CDs()
	{
		UpdateCommands();
		UpdateTitleBarButtonVisibility();
	}

	private void oDq()
	{
		if (IsActive && SelectedWindow != null && REK != null && (FEB == null || !FEB.Veu()))
		{
			REK.ActiveWindow = SelectedWindow;
		}
	}

	internal void uDF()
	{
		DockSite = ((FEB != null) ? FEB.DockSite : null);
	}

	internal void vDV()
	{
		IsTabLayoutAnimationEnabledResolved = IsTabLayoutAnimationEnabled && base.IsLoaded && REK != null && !REK.WQE();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		uDF();
		UpdateDockingWindowStates();
		TabControl = GetTemplateChild(vVK.ssH(21098)) as AdvancedTabControl;
	}

	protected virtual void OnDockSiteChanged(DockSite oldDockSite, DockSite newDockSite)
	{
		if (newDockSite == null)
		{
			BindingOperations.ClearBinding(this, IsTabLayoutAnimationEnabledProperty);
		}
		else
		{
			this.BindToProperty(IsTabLayoutAnimationEnabledProperty, newDockSite, vVK.ssH(12738), BindingMode.OneWay);
		}
	}

	protected virtual void OnSelectedWindowChanged(DockingWindow oldSelectedWindow, DockingWindow newSelectedWindow)
	{
	}

	protected virtual void OnTabControlMenuOpening(AdvancedTabControlMenuEventArgs e)
	{
	}

	protected virtual void OnWindowsChanged(NotifyCollectionChangedEventArgs e)
	{
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, vVK.ssH(21132), new object[2]
		{
			GetType().Name,
			((SelectedWindow != null) ? SelectedWindow.Title : null) ?? vVK.ssH(21182)
		});
	}

	protected virtual void UpdateCommands()
	{
	}

	protected abstract void UpdateDockingWindowStates();

	protected virtual void UpdateIsTabStripVisible()
	{
	}

	protected virtual void UpdateTitleBarButtonVisibility()
	{
	}

	protected virtual void UpdateVisualState(bool useTransitions)
	{
		switch (TabStripPlacement)
		{
		case Side.Bottom:
			VisualStateManager.GoToState(this, vVK.ssH(3600), useTransitions);
			break;
		case Side.Right:
			VisualStateManager.GoToState(this, vVK.ssH(3660), useTransitions);
			break;
		default:
			VisualStateManager.GoToState(this, vVK.ssH(3690), useTransitions);
			break;
		case Side.Left:
			VisualStateManager.GoToState(this, vVK.ssH(3632), useTransitions);
			break;
		}
	}

	protected virtual void ValidateChildType(DockingWindow window)
	{
	}

	bool G0.RemoveWindow(DockingWindow window)
	{
		if (window == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (WindowsCore.Contains(window))
		{
			WindowsCore.Remove(window);
			return true;
		}
		return false;
	}

	void Xk.RemoveBreadcrumb(bv breadcrumb)
	{
		DD9(breadcrumb);
	}

	int wH.GetVisibleToolWindowContainerCount()
	{
		if (!(this is ToolWindowContainer) || !QE2())
		{
			return 0;
		}
		return 1;
	}

	[SpecialName]
	internal bool QE2()
	{
		return WindowsCore.Count > 0;
	}

	[SpecialName]
	internal Size cEG()
	{
		if (SelectedWindow == null)
		{
			return default(Size);
		}
		return SelectedWindow.Skx();
	}

	[SpecialName]
	internal void IEI(Size value)
	{
		int num2 = default(int);
		foreach (lX item in hEW)
		{
			if (item is DockingWindow dockingWindow)
			{
				dockingWindow.ContainerDockedSize = value;
			}
			else if (item is bv bv)
			{
				bv.ContainerDockedSize = value;
				int num = 0;
				if (tnL() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
	}

	private Size BDP()
	{
		double num = double.PositiveInfinity;
		double num2 = double.PositiveInfinity;
		foreach (DockingWindow item in WindowsCore)
		{
			if (item != null)
			{
				Size containerMaxSizeResolved = item.ContainerMaxSizeResolved;
				num = Math.Min(num, containerMaxSizeResolved.Width);
				num2 = Math.Min(num2, containerMaxSizeResolved.Height);
			}
		}
		return new Size(num, num2);
	}

	private Size tDf()
	{
		double num = 0.0;
		double num2 = 0.0;
		foreach (DockingWindow item in WindowsCore)
		{
			if (item != null)
			{
				Size containerMinSizeResolved = item.ContainerMinSizeResolved;
				num = Math.Max(num, containerMinSizeResolved.Width);
				num2 = Math.Max(num2, containerMinSizeResolved.Height);
			}
		}
		return new Size(num, num2);
	}

	[SpecialName]
	internal Size aEC()
	{
		return BDP();
	}

	[SpecialName]
	internal Size bEN()
	{
		return tDf();
	}

	private bool yDU(object P_0)
	{
		if (!(P_0 is ContextMenu { IsOpen: not false } contextMenu))
		{
			Popup popup = null;
			Visual visual = P_0 as Visual;
			int num2 = default(int);
			while (true)
			{
				if (visual == null)
				{
					int num = 0;
					if (tnL() != null)
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						goto IL_00dd;
					}
					break;
				}
				goto IL_00dd;
				IL_00dd:
				if (IsAncestorOf(visual))
				{
					if (popup == null)
					{
						break;
					}
					WE8 = popup;
					popup.Closed += AD4;
					return true;
				}
				Popup ancestorPopup = VisualTreeHelperExtended.GetAncestorPopup(visual);
				if (ancestorPopup == null)
				{
					break;
				}
				if (popup == null)
				{
					popup = ancestorPopup;
				}
				visual = ancestorPopup.Parent as Visual;
			}
			return false;
		}
		YET = contextMenu;
		YET.Closed += PDc;
		return true;
	}

	private void PDc(object P_0, RoutedEventArgs P_1)
	{
		((ContextMenu)P_0).Closed -= PDc;
		YET = null;
		if (!yDU(cP.hlj()))
		{
			cP.IlA(this);
		}
	}

	private void AD4(object P_0, EventArgs P_1)
	{
		((Popup)P_0).Closed -= AD4;
		WE8 = null;
		if (!yDU(cP.hlj()))
		{
			cP.IlA(this);
		}
	}

	private void xDj(object P_0, RoutedEventArgs P_1)
	{
		vDV();
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (!base.IsKeyboardFocusWithin && cP.hlj() is DependencyObject dependencyObject)
		{
			DependencyObject focusScope = FocusManager.GetFocusScope(this);
			if ((focusScope != null && FocusManager.GetFocusScope(dependencyObject) != focusScope) || yDU(dependencyObject))
			{
				return;
			}
		}
		cP.IlA(this);
	}

	static DockingWindowContainerBase()
	{
		IVH.CecNqz();
		CanTabsCloseOnMiddleClickProperty = DependencyProperty.Register(vVK.ssH(380), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(true));
		HasTabImagesProperty = DependencyProperty.Register(vVK.ssH(718), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(false));
		IsActiveProperty = DependencyProperty.Register(vVK.ssH(878), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(false, LDr));
		IsTabLayoutAnimationEnabledProperty = DependencyProperty.Register(vVK.ssH(12738), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(false, bDx));
		IsTabLayoutAnimationEnabledResolvedProperty = DependencyProperty.Register(vVK.ssH(21198), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(false));
		IsTabStripVisibleProperty = DependencyProperty.Register(vVK.ssH(1186), typeof(bool), typeof(DockingWindowContainerBase), new PropertyMetadata(true));
		MaxTabExtentProperty = DependencyProperty.Register(vVK.ssH(1224), typeof(double), typeof(DockingWindowContainerBase), new PropertyMetadata(260.0));
		MinTabExtentProperty = DependencyProperty.Register(vVK.ssH(1306), typeof(double), typeof(DockingWindowContainerBase), new PropertyMetadata(30.0));
		SelectedWindowProperty = DependencyProperty.Register(vVK.ssH(21272), typeof(DockingWindow), typeof(DockingWindowContainerBase), new PropertyMetadata(null, QDl));
		StateProperty = DependencyProperty.Register(vVK.ssH(8688), typeof(DockingWindowState), typeof(DockingWindowContainerBase), new PropertyMetadata(DockingWindowState.Docked, HDM));
		TabControlStyleProperty = DependencyProperty.Register(vVK.ssH(16826), typeof(Style), typeof(DockingWindowContainerBase), new PropertyMetadata(null));
		TabItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(16860), typeof(Style), typeof(DockingWindowContainerBase), new PropertyMetadata(null));
		TabOverflowBehaviorProperty = DependencyProperty.Register(vVK.ssH(2998), typeof(TabOverflowBehavior), typeof(DockingWindowContainerBase), new PropertyMetadata(TabOverflowBehavior.Shrink));
		TabStripPlacementProperty = DependencyProperty.Register(vVK.ssH(3510), typeof(Side), typeof(DockingWindowContainerBase), new PropertyMetadata(Side.Bottom, dDL));
	}

	internal static bool gnh()
	{
		return YnM == null;
	}

	internal static DockingWindowContainerBase tnL()
	{
		return YnM;
	}
}
