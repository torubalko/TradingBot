using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Controls.Docking.Serialization;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[ContentProperty("Child")]
[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
[TemplatePart(Name = "PART_AdornmentHost", Type = typeof(Panel))]
[TemplatePart(Name = "PART_DockHost", Type = typeof(DockHost))]
public class DockSite : Control, IDockTarget, lX
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public FloatingWindowControl MLP;

		internal static _003C_003Ec__DisplayClass26_0 DGp;

		public _003C_003Ec__DisplayClass26_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal int QLV(FloatingWindowControl w)
		{
			if (MLP == null || MLP != w)
			{
				return Panel.GetZIndex(w);
			}
			return 10000;
		}

		internal static bool FG4()
		{
			return DGp == null;
		}

		internal static _003C_003Ec__DisplayClass26_0 QG2()
		{
			return DGp;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass522_0
	{
		public Guid PLU;

		internal static _003C_003Ec__DisplayClass522_0 HG6;

		public _003C_003Ec__DisplayClass522_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool uLf(DockHost dh)
		{
			return dh.UniqueId == PLU;
		}

		internal static bool uGW()
		{
			return HG6 == null;
		}

		internal static _003C_003Ec__DisplayClass522_0 kGI()
		{
			return HG6;
		}
	}

	[CompilerGenerated]
	private sealed class _003Cget_AllLinkedDockHosts_003Ed__645 : IEnumerable<DockHost>, IEnumerable, IEnumerator<DockHost>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private DockHost _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DockSite _003C_003E4__this;

		private IEnumerator<DockHost> _003C_003E7__wrap1;

		private IEnumerator<DockSite> _003C_003E7__wrap2;

		private static _003Cget_AllLinkedDockHosts_003Ed__645 kGa;

		DockHost IEnumerator<DockHost>.Current
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
		public _003Cget_AllLinkedDockHosts_003Ed__645(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			switch (num)
			{
			case -5:
			case -4:
			case 2:
				try
				{
					if (num != -5 && num != 2)
					{
						break;
					}
					try
					{
						break;
					}
					finally
					{
						_003C_003Em__Finally3();
					}
				}
				finally
				{
					_003C_003Em__Finally2();
				}
			case -2:
			case -1:
			case 0:
				break;
			case -3:
			case 1:
				try
				{
					break;
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
				DockSite dockSite = _003C_003E4__this;
				int num2;
				int num3 = default(int);
				DockSite current2;
				DockHost current3;
				switch (num)
				{
				default:
					return false;
				case 1:
					_003C_003E1__state = -3;
					num2 = 3;
					if (tGs() != null)
					{
						goto IL_000e;
					}
					goto IL_0012;
				case 2:
					_003C_003E1__state = -5;
					goto IL_010e;
				case 0:
					{
						_003C_003E1__state = -1;
						_003C_003E7__wrap1 = dockSite.eQY().GetEnumerator();
						_003C_003E1__state = -3;
						goto IL_0209;
					}
					IL_0012:
					while (true)
					{
						switch (num2)
						{
						case 1:
							_003C_003Em__Finally3();
							_003C_003E7__wrap1 = null;
							goto IL_0088;
						default:
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = dockSite.LinkedDockSites.GetEnumerator();
							_003C_003E1__state = -4;
							goto IL_0088;
						case 2:
							_003C_003Em__Finally2();
							_003C_003E7__wrap2 = null;
							return false;
						case 3:
							break;
							IL_0088:
							if (!_003C_003E7__wrap2.MoveNext())
							{
								num2 = 2;
								continue;
							}
							goto IL_00c8;
						}
						break;
					}
					goto IL_0209;
					IL_0209:
					if (_003C_003E7__wrap1.MoveNext())
					{
						DockHost current = _003C_003E7__wrap1.Current;
						_003C_003E2__current = current;
						_003C_003E1__state = 1;
						return true;
					}
					_003C_003Em__Finally1();
					num2 = 0;
					if (!zGX())
					{
						goto IL_000e;
					}
					goto IL_0012;
					IL_000e:
					num2 = num3;
					goto IL_0012;
					IL_00c8:
					current2 = _003C_003E7__wrap2.Current;
					_003C_003E7__wrap1 = current2.eQY().GetEnumerator();
					_003C_003E1__state = -5;
					goto IL_010e;
					IL_010e:
					if (!_003C_003E7__wrap1.MoveNext())
					{
						num2 = 1;
						if (!zGX())
						{
							goto IL_000e;
						}
						goto IL_0012;
					}
					current3 = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current3;
					_003C_003E1__state = 2;
					return true;
				}
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

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		private void _003C_003Em__Finally3()
		{
			_003C_003E1__state = -4;
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

		[DebuggerHidden]
		IEnumerator<DockHost> IEnumerable<DockHost>.GetEnumerator()
		{
			_003Cget_AllLinkedDockHosts_003Ed__645 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003Cget_AllLinkedDockHosts_003Ed__645(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DockHost>)this).GetEnumerator();
		}

		internal static bool zGX()
		{
			return kGa == null;
		}

		internal static _003Cget_AllLinkedDockHosts_003Ed__645 tGs()
		{
			return kGa;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAllUnusedLazyLayoutData_003Ed__659<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator where T : XmlDockingWindow
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public DockSite _003C_003E4__this;

		private List<XmlDockingWindow>.Enumerator _003C_003E7__wrap1;

		internal static object xGQ;

		T IEnumerator<T>.Current
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
		public _003CGetAllUnusedLazyLayoutData_003Ed__659(int _003C_003E1__state)
		{
			IVH.CecNqz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
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
				DockSite dockSite = _003C_003E4__this;
				if (num == 0)
				{
					_003C_003E1__state = -1;
					if (dockSite.ImT == null)
					{
						goto IL_0147;
					}
					_003C_003E7__wrap1 = dockSite.ImT.GetEnumerator();
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
				T val = default(T);
				int num3 = default(int);
				while (true)
				{
					int num2;
					if (_003C_003E7__wrap1.MoveNext())
					{
						val = _003C_003E7__wrap1.Current as T;
						num2 = 1;
						if (VGN() != null)
						{
							goto IL_0016;
						}
					}
					else
					{
						_003C_003Em__Finally1();
						num2 = 0;
						if (VGN() != null)
						{
							goto IL_0016;
						}
					}
					goto IL_001a;
					IL_001a:
					switch (num2)
					{
					case 1:
						goto IL_007a;
					}
					break;
					IL_007a:
					if (val != null)
					{
						_003C_003E2__current = val;
						_003C_003E1__state = 1;
						return true;
					}
					continue;
					IL_0016:
					num2 = num3;
					goto IL_001a;
				}
				_003C_003E7__wrap1 = default(List<XmlDockingWindow>.Enumerator);
				goto IL_0147;
				IL_0147:
				return false;
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
			((IDisposable)_003C_003E7__wrap1/*cast due to .constrained prefix*/).Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CGetAllUnusedLazyLayoutData_003Ed__659<T> result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetAllUnusedLazyLayoutData_003Ed__659<T>(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool MGv()
		{
			return xGQ == null;
		}

		internal static object VGN()
		{
			return xGQ;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass662_0
	{
		public DockSite AL4;

		internal static _003C_003Ec__DisplayClass662_0 OGS;

		public _003C_003Ec__DisplayClass662_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool FLc(WeakReference r)
		{
			return r.Target == AL4;
		}

		internal static bool LGP()
		{
			return OGS == null;
		}

		internal static _003C_003Ec__DisplayClass662_0 AGe()
		{
			return OGS;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass683_0
	{
		public DockSite JLZ;

		private static _003C_003Ec__DisplayClass683_0 YGJ;

		public _003C_003Ec__DisplayClass683_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool JLj(WeakReference r)
		{
			return r.Target == JLZ;
		}

		internal static bool XGU()
		{
			return YGJ == null;
		}

		internal static _003C_003Ec__DisplayClass683_0 CGF()
		{
			return YGJ;
		}
	}

	private Panel MQh;

	private QK lQg;

	private Rect? TQX;

	public static readonly DependencyProperty HostedFloatingWindowContainerProperty;

	public static readonly DependencyProperty InactiveFloatingWindowFadeDelayProperty;

	public static readonly DependencyProperty InactiveFloatingWindowFadeDurationProperty;

	public static readonly DependencyProperty InactiveFloatingWindowFadeOpacityProperty;

	public static readonly DependencyProperty IsInactiveFloatingWindowFadeEnabledProperty;

	private ToolWindowContainerCollection tQ5;

	private ToolWindowContainerCollection UQy;

	private ToolWindowContainerCollection jQo;

	private ToolWindowContainerCollection dQt;

	private Guid aQu;

	private DateTime mQz;

	public static readonly DependencyProperty AutoHidePerContainerProperty;

	public static readonly DependencyProperty AutoHidePopupCloseAnimationDurationProperty;

	public static readonly DependencyProperty AutoHidePopupCloseDelayProperty;

	public static readonly DependencyProperty AutoHidePopupClosesOnLostFocusProperty;

	public static readonly DependencyProperty AutoHidePopupOpenAnimationDurationProperty;

	public static readonly DependencyProperty AutoHidePopupOpenDelayProperty;

	public static readonly DependencyProperty AutoHidePopupOpensOnMouseHoverProperty;

	public static readonly DependencyProperty AutoHideTabItemTemplateProperty;

	public static readonly DependencyProperty AutoHideTabItemTemplateSelectorProperty;

	public static readonly DependencyProperty CanToolWindowsAutoHideProperty;

	private DelegateCommand<object> lmi;

	private DelegateCommand<object> Tmd;

	private DelegateCommand<object> Rmw;

	private DelegateCommand<object> Km2;

	private DelegateCommand<object> xme;

	private DelegateCommand<object> UmG;

	private DelegateCommand<object> fmI;

	private DelegateCommand<object> mmk;

	private DelegateCommand<object> pmC;

	private bool em1;

	private WeakReference YmN;

	public static readonly DependencyProperty ActiveWindowProperty;

	public static readonly DependencyProperty AreDocumentWindowsDestroyedOnCloseProperty;

	public static readonly DependencyProperty AreNewTabsInsertedBeforeExistingTabsProperty;

	public static readonly DependencyProperty CanDocumentWindowsCloseProperty;

	public static readonly DependencyProperty CanDocumentWindowsDragToLinkedDockSitesProperty;

	public static readonly DependencyProperty CanDocumentWindowsFloatProperty;

	public static readonly DependencyProperty CanFloatingDockHostsHideOnDockSiteUnloadProperty;

	public static readonly DependencyProperty CanToolWindowsAttachProperty;

	public static readonly DependencyProperty CanToolWindowsBecomeDocumentsProperty;

	public static readonly DependencyProperty CanToolWindowsCloseProperty;

	public static readonly DependencyProperty CanToolWindowsCloseOnMiddleClickProperty;

	public static readonly DependencyProperty CanToolWindowsDockProperty;

	public static readonly DependencyProperty CanToolWindowsDragToFloatingDockHostsWithWorkspacesProperty;

	public static readonly DependencyProperty CanToolWindowsDragToLinkedDockSitesProperty;

	public static readonly DependencyProperty CanToolWindowsFloatProperty;

	public static readonly DependencyProperty CanToolWindowTabsDragProperty;

	public static readonly DependencyProperty ChildProperty;

	public static readonly DependencyProperty ClosePerContainerProperty;

	public static readonly DependencyProperty FloatingToolWindowContainersHaveMaximizeButtonsProperty;

	public static readonly DependencyProperty FloatingToolWindowContainersHaveMinimizeButtonsProperty;

	public static readonly DependencyProperty FloatingWindowIconProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TaskBar")]
	public static readonly DependencyProperty FloatingWindowShowInTaskBarModeProperty;

	public static readonly DependencyProperty FloatingWindowSnapToScreenThresholdProperty;

	public static readonly DependencyProperty FloatingWindowTitleProperty;

	public static readonly DependencyProperty IsDockGuideAnimationEnabledProperty;

	public static readonly DependencyProperty IsFloatingWindowSnapToScreenEnabledProperty;

	public static readonly DependencyProperty IsLiveSplittingEnabledProperty;

	public static readonly DependencyProperty IsTabLayoutAnimationEnabledProperty;

	public static readonly DependencyProperty MagnetismGapDistanceProperty;

	public static readonly DependencyProperty MagnetismSnapDistanceProperty;

	public static readonly DependencyProperty MdiKindProperty;

	public static readonly DependencyProperty PrimaryDocumentProperty;

	public static readonly DependencyProperty SplitterSizeProperty;

	public static readonly DependencyProperty SwitcherProperty;

	public static readonly DependencyProperty ToolWindowsHaveCloseButtonsProperty;

	public static readonly DependencyProperty ToolWindowsHaveOptionsButtonsProperty;

	public static readonly DependencyProperty ToolWindowsHaveTabImagesProperty;

	public static readonly DependencyProperty ToolWindowsHaveTitleBarIconsProperty;

	public static readonly DependencyProperty ToolWindowsHaveTitleBarsProperty;

	public static readonly DependencyProperty ToolWindowsHaveToggleAutoHideButtonsProperty;

	public static readonly DependencyProperty ToolWindowsSingleTabLayoutBehaviorProperty;

	public static readonly DependencyProperty ToolWindowsTabOverflowBehaviorProperty;

	public static readonly DependencyProperty ToolWindowsTabStripPlacementProperty;

	public static readonly DependencyProperty ToolWindowsTitleBarContextContentAlignmentProperty;

	public static readonly DependencyProperty ToolWindowTabItemContainerStyleProperty;

	public static readonly DependencyProperty UseDragFloatPreviewsProperty;

	public static readonly DependencyProperty UseHostedFloatingWindowsProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Popups")]
	public static readonly DependencyProperty UseHostedPopupsProperty;

	[CompilerGenerated]
	private bool bmQ;

	private il ymm;

	public static readonly RoutedEvent FloatingWindowOpeningEvent;

	public static readonly RoutedEvent MdiKindChangedEvent;

	public static readonly RoutedEvent MenuOpeningEvent;

	public static readonly RoutedEvent NewWindowRequestedEvent;

	public static readonly RoutedEvent PrimaryDocumentChangedEvent;

	public static readonly RoutedEvent WindowActivatedEvent;

	public static readonly RoutedEvent WindowAutoHidePopupClosedEvent;

	public static readonly RoutedEvent WindowAutoHidePopupOpenedEvent;

	public static readonly RoutedEvent WindowDeactivatedEvent;

	public static readonly RoutedEvent WindowDefaultLocationRequestedEvent;

	public static readonly RoutedEvent WindowRegisteredEvent;

	public static readonly RoutedEvent WindowsAutoHidingEvent;

	public static readonly RoutedEvent WindowsClosedEvent;

	public static readonly RoutedEvent WindowsClosingEvent;

	public static readonly RoutedEvent WindowsDockHostChangedEvent;

	public static readonly RoutedEvent WindowsDraggedEvent;

	public static readonly RoutedEvent WindowsDraggingEvent;

	public static readonly RoutedEvent WindowsDragOverEvent;

	public static readonly RoutedEvent WindowsOpenedEvent;

	public static readonly RoutedEvent WindowsOpeningEvent;

	public static readonly RoutedEvent WindowsStateChangedEvent;

	public static readonly RoutedEvent WindowUnregisteredEvent;

	[CompilerGenerated]
	private EventHandler Wma;

	private List<DockingWindow> pmW;

	private bool pmB;

	private DockingWindow QmK;

	private List<DockingWindow> wmJ;

	public static readonly DependencyProperty CanUpdateItemsSourceOnUnregisterProperty;

	public static readonly DependencyProperty DocumentItemContainerStyleProperty;

	public static readonly DependencyProperty DocumentItemContainerStyleSelectorProperty;

	public static readonly DependencyProperty DocumentItemsSourceProperty;

	public static readonly DependencyProperty DocumentItemTemplateProperty;

	public static readonly DependencyProperty DocumentItemTemplateSelectorProperty;

	public static readonly DependencyProperty ToolItemContainerStyleProperty;

	public static readonly DependencyProperty ToolItemContainerStyleSelectorProperty;

	public static readonly DependencyProperty ToolItemsSourceProperty;

	public static readonly DependencyProperty ToolItemTemplateProperty;

	public static readonly DependencyProperty ToolItemTemplateSelectorProperty;

	private DocumentWindowCollection fmn;

	private ObservableCollection<DockHost> OmO;

	private List<XmlDockingWindow> ImT;

	private List<WeakReference> Vm8;

	private ReadOnlyDockingWindowCollection mmD;

	private DockingWindowCollection mmE;

	private bool Tmr;

	private DockHost kmx;

	private WeakReference Bml;

	private ReadOnlyObservableCollection<DockHost> amM;

	private ToolWindowCollection Omv;

	private bool em7;

	private bool qmR;

	internal static DockSite r1d;

	public FrameworkElement HostedFloatingWindowContainer
	{
		get
		{
			return (FrameworkElement)GetValue(HostedFloatingWindowContainerProperty);
		}
		set
		{
			SetValue(HostedFloatingWindowContainerProperty, value);
		}
	}

	public double InactiveFloatingWindowFadeDelay
	{
		get
		{
			return (double)GetValue(InactiveFloatingWindowFadeDelayProperty);
		}
		set
		{
			SetValue(InactiveFloatingWindowFadeDelayProperty, value);
		}
	}

	public double InactiveFloatingWindowFadeDuration
	{
		get
		{
			return (double)GetValue(InactiveFloatingWindowFadeDurationProperty);
		}
		set
		{
			SetValue(InactiveFloatingWindowFadeDurationProperty, value);
		}
	}

	public double InactiveFloatingWindowFadeOpacity
	{
		get
		{
			return (double)GetValue(InactiveFloatingWindowFadeOpacityProperty);
		}
		set
		{
			SetValue(InactiveFloatingWindowFadeOpacityProperty, value);
		}
	}

	public bool IsInactiveFloatingWindowFadeEnabled
	{
		get
		{
			return (bool)GetValue(IsInactiveFloatingWindowFadeEnabledProperty);
		}
		set
		{
			SetValue(IsInactiveFloatingWindowFadeEnabledProperty, value);
		}
	}

	internal ToolWindow AutoHidePopupToolWindow
	{
		get
		{
			foreach (DockHost item in eQY())
			{
				if (item != null && item.AutoHidePopupToolWindow != null)
				{
					return item.AutoHidePopupToolWindow;
				}
			}
			return null;
		}
	}

	public ToolWindowContainerCollection AutoHideBottomContainers
	{
		get
		{
			if (kmx == null)
			{
				return tQ5;
			}
			return kmx.AutoHideBottomContainers;
		}
	}

	public ToolWindowContainerCollection AutoHideLeftContainers
	{
		get
		{
			if (kmx == null)
			{
				return UQy;
			}
			return kmx.AutoHideLeftContainers;
		}
	}

	public bool AutoHidePerContainer
	{
		get
		{
			return (bool)GetValue(AutoHidePerContainerProperty);
		}
		set
		{
			SetValue(AutoHidePerContainerProperty, value);
		}
	}

	public double AutoHidePopupCloseAnimationDuration
	{
		get
		{
			return (double)GetValue(AutoHidePopupCloseAnimationDurationProperty);
		}
		set
		{
			SetValue(AutoHidePopupCloseAnimationDurationProperty, value);
		}
	}

	public double AutoHidePopupCloseDelay
	{
		get
		{
			return (double)GetValue(AutoHidePopupCloseDelayProperty);
		}
		set
		{
			SetValue(AutoHidePopupCloseDelayProperty, value);
		}
	}

	public bool AutoHidePopupClosesOnLostFocus
	{
		get
		{
			return (bool)GetValue(AutoHidePopupClosesOnLostFocusProperty);
		}
		set
		{
			SetValue(AutoHidePopupClosesOnLostFocusProperty, value);
		}
	}

	public double AutoHidePopupOpenAnimationDuration
	{
		get
		{
			return (double)GetValue(AutoHidePopupOpenAnimationDurationProperty);
		}
		set
		{
			SetValue(AutoHidePopupOpenAnimationDurationProperty, value);
		}
	}

	public double AutoHidePopupOpenDelay
	{
		get
		{
			return (double)GetValue(AutoHidePopupOpenDelayProperty);
		}
		set
		{
			SetValue(AutoHidePopupOpenDelayProperty, value);
		}
	}

	public bool AutoHidePopupOpensOnMouseHover
	{
		get
		{
			return (bool)GetValue(AutoHidePopupOpensOnMouseHoverProperty);
		}
		set
		{
			SetValue(AutoHidePopupOpensOnMouseHoverProperty, value);
		}
	}

	public ToolWindowContainerCollection AutoHideRightContainers
	{
		get
		{
			if (kmx == null)
			{
				return jQo;
			}
			return kmx.AutoHideRightContainers;
		}
	}

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

	public ToolWindowContainerCollection AutoHideTopContainers
	{
		get
		{
			if (kmx == null)
			{
				return dQt;
			}
			return kmx.AutoHideTopContainers;
		}
	}

	public bool CanToolWindowsAutoHide
	{
		get
		{
			return (bool)GetValue(CanToolWindowsAutoHideProperty);
		}
		set
		{
			SetValue(CanToolWindowsAutoHideProperty, value);
		}
	}

	public ICommand ActivateNextDocumentCommand => lmi;

	public ICommand ActivatePreviousDocumentCommand => Tmd;

	public ICommand ActivatePrimaryDocumentCommand => Rmw;

	public DockingWindow ActiveWindow
	{
		get
		{
			return (DockingWindow)GetValue(ActiveWindowProperty);
		}
		internal set
		{
			SetValue(ActiveWindowProperty, value);
		}
	}

	public bool AreDocumentWindowsDestroyedOnClose
	{
		get
		{
			return (bool)GetValue(AreDocumentWindowsDestroyedOnCloseProperty);
		}
		set
		{
			SetValue(AreDocumentWindowsDestroyedOnCloseProperty, value);
		}
	}

	public bool AreNewTabsInsertedBeforeExistingTabs
	{
		get
		{
			return (bool)GetValue(AreNewTabsInsertedBeforeExistingTabsProperty);
		}
		set
		{
			SetValue(AreNewTabsInsertedBeforeExistingTabsProperty, value);
		}
	}

	public bool CanDocumentWindowsClose
	{
		get
		{
			return (bool)GetValue(CanDocumentWindowsCloseProperty);
		}
		set
		{
			SetValue(CanDocumentWindowsCloseProperty, value);
		}
	}

	public bool CanDocumentWindowsDragToLinkedDockSites
	{
		get
		{
			return (bool)GetValue(CanDocumentWindowsDragToLinkedDockSitesProperty);
		}
		set
		{
			SetValue(CanDocumentWindowsDragToLinkedDockSitesProperty, value);
		}
	}

	public bool CanDocumentWindowsFloat
	{
		get
		{
			return (bool)GetValue(CanDocumentWindowsFloatProperty);
		}
		set
		{
			SetValue(CanDocumentWindowsFloatProperty, value);
		}
	}

	public bool CanFloatingDockHostsHideOnDockSiteUnload
	{
		get
		{
			return (bool)GetValue(CanFloatingDockHostsHideOnDockSiteUnloadProperty);
		}
		set
		{
			SetValue(CanFloatingDockHostsHideOnDockSiteUnloadProperty, value);
		}
	}

	public bool CanToolWindowsAttach
	{
		get
		{
			return (bool)GetValue(CanToolWindowsAttachProperty);
		}
		set
		{
			SetValue(CanToolWindowsAttachProperty, value);
		}
	}

	public bool CanToolWindowsBecomeDocuments
	{
		get
		{
			return (bool)GetValue(CanToolWindowsBecomeDocumentsProperty);
		}
		set
		{
			SetValue(CanToolWindowsBecomeDocumentsProperty, value);
		}
	}

	public bool CanToolWindowsClose
	{
		get
		{
			return (bool)GetValue(CanToolWindowsCloseProperty);
		}
		set
		{
			SetValue(CanToolWindowsCloseProperty, value);
		}
	}

	public bool CanToolWindowsCloseOnMiddleClick
	{
		get
		{
			return (bool)GetValue(CanToolWindowsCloseOnMiddleClickProperty);
		}
		set
		{
			SetValue(CanToolWindowsCloseOnMiddleClickProperty, value);
		}
	}

	public bool CanToolWindowsDock
	{
		get
		{
			return (bool)GetValue(CanToolWindowsDockProperty);
		}
		set
		{
			SetValue(CanToolWindowsDockProperty, value);
		}
	}

	public bool CanToolWindowsDragToFloatingDockHostsWithWorkspaces
	{
		get
		{
			return (bool)GetValue(CanToolWindowsDragToFloatingDockHostsWithWorkspacesProperty);
		}
		set
		{
			SetValue(CanToolWindowsDragToFloatingDockHostsWithWorkspacesProperty, value);
		}
	}

	public bool CanToolWindowsDragToLinkedDockSites
	{
		get
		{
			return (bool)GetValue(CanToolWindowsDragToLinkedDockSitesProperty);
		}
		set
		{
			SetValue(CanToolWindowsDragToLinkedDockSitesProperty, value);
		}
	}

	public bool CanToolWindowsFloat
	{
		get
		{
			return (bool)GetValue(CanToolWindowsFloatProperty);
		}
		set
		{
			SetValue(CanToolWindowsFloatProperty, value);
		}
	}

	public bool CanToolWindowTabsDrag
	{
		get
		{
			return (bool)GetValue(CanToolWindowTabsDragProperty);
		}
		set
		{
			SetValue(CanToolWindowTabsDragProperty, value);
		}
	}

	public ICommand CascadeDocumentsCommand => Km2;

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

	public ICommand CloseAllDocumentsCommand => xme;

	public bool ClosePerContainer
	{
		get
		{
			return (bool)GetValue(ClosePerContainerProperty);
		}
		set
		{
			SetValue(ClosePerContainerProperty, value);
		}
	}

	public ICommand ClosePrimaryDocumentCommand => UmG;

	public bool FloatingToolWindowContainersHaveMaximizeButtons
	{
		get
		{
			return (bool)GetValue(FloatingToolWindowContainersHaveMaximizeButtonsProperty);
		}
		set
		{
			SetValue(FloatingToolWindowContainersHaveMaximizeButtonsProperty, value);
		}
	}

	public bool FloatingToolWindowContainersHaveMinimizeButtons
	{
		get
		{
			return (bool)GetValue(FloatingToolWindowContainersHaveMinimizeButtonsProperty);
		}
		set
		{
			SetValue(FloatingToolWindowContainersHaveMinimizeButtonsProperty, value);
		}
	}

	public ImageSource FloatingWindowIcon
	{
		get
		{
			return (ImageSource)GetValue(FloatingWindowIconProperty);
		}
		set
		{
			SetValue(FloatingWindowIconProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TaskBar")]
	public FloatingWindowShowInTaskBarMode FloatingWindowShowInTaskBarMode
	{
		get
		{
			return (FloatingWindowShowInTaskBarMode)GetValue(FloatingWindowShowInTaskBarModeProperty);
		}
		set
		{
			SetValue(FloatingWindowShowInTaskBarModeProperty, value);
		}
	}

	public double FloatingWindowSnapToScreenThreshold
	{
		get
		{
			return (double)GetValue(FloatingWindowSnapToScreenThresholdProperty);
		}
		set
		{
			SetValue(FloatingWindowSnapToScreenThresholdProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string FloatingWindowTitle
	{
		get
		{
			return (string)GetValue(FloatingWindowTitleProperty);
		}
		set
		{
			SetValue(FloatingWindowTitleProperty, value);
		}
	}

	public bool IsDockGuideAnimationEnabled
	{
		get
		{
			return (bool)GetValue(IsDockGuideAnimationEnabledProperty);
		}
		set
		{
			SetValue(IsDockGuideAnimationEnabledProperty, value);
		}
	}

	public bool IsFloatingWindowSnapToScreenEnabled
	{
		get
		{
			return (bool)GetValue(IsFloatingWindowSnapToScreenEnabledProperty);
		}
		set
		{
			SetValue(IsFloatingWindowSnapToScreenEnabledProperty, value);
		}
	}

	public bool IsLiveSplittingEnabled
	{
		get
		{
			return (bool)GetValue(IsLiveSplittingEnabledProperty);
		}
		set
		{
			SetValue(IsLiveSplittingEnabledProperty, value);
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

	public double MagnetismGapDistance
	{
		get
		{
			return (double)GetValue(MagnetismGapDistanceProperty);
		}
		set
		{
			SetValue(MagnetismGapDistanceProperty, value);
		}
	}

	public double MagnetismSnapDistance
	{
		get
		{
			return (double)GetValue(MagnetismSnapDistanceProperty);
		}
		set
		{
			SetValue(MagnetismSnapDistanceProperty, value);
		}
	}

	public MdiKind MdiKind
	{
		get
		{
			return (MdiKind)GetValue(MdiKindProperty);
		}
		set
		{
			SetValue(MdiKindProperty, value);
		}
	}

	public DockingWindow PrimaryDocument
	{
		get
		{
			return (DockingWindow)GetValue(PrimaryDocumentProperty);
		}
		internal set
		{
			SetValue(PrimaryDocumentProperty, value);
		}
	}

	public ICommand SetMdiKindCommand => fmI;

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

	public SwitcherBase Switcher
	{
		get
		{
			return (SwitcherBase)GetValue(SwitcherProperty);
		}
		set
		{
			SetValue(SwitcherProperty, value);
		}
	}

	public ICommand TileDocumentsHorizontallyCommand => mmk;

	public ICommand TileDocumentsVerticallyCommand => pmC;

	public bool ToolWindowsHaveCloseButtons
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveCloseButtonsProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveCloseButtonsProperty, value);
		}
	}

	public bool ToolWindowsHaveOptionsButtons
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveOptionsButtonsProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveOptionsButtonsProperty, value);
		}
	}

	public bool ToolWindowsHaveTabImages
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveTabImagesProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveTabImagesProperty, value);
		}
	}

	public bool ToolWindowsHaveTitleBarIcons
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveTitleBarIconsProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveTitleBarIconsProperty, value);
		}
	}

	public bool ToolWindowsHaveTitleBars
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveTitleBarsProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveTitleBarsProperty, value);
		}
	}

	public bool ToolWindowsHaveToggleAutoHideButtons
	{
		get
		{
			return (bool)GetValue(ToolWindowsHaveToggleAutoHideButtonsProperty);
		}
		set
		{
			SetValue(ToolWindowsHaveToggleAutoHideButtonsProperty, value);
		}
	}

	public SingleTabLayoutBehavior ToolWindowsSingleTabLayoutBehavior
	{
		get
		{
			return (SingleTabLayoutBehavior)GetValue(ToolWindowsSingleTabLayoutBehaviorProperty);
		}
		set
		{
			SetValue(ToolWindowsSingleTabLayoutBehaviorProperty, value);
		}
	}

	public TabOverflowBehavior ToolWindowsTabOverflowBehavior
	{
		get
		{
			return (TabOverflowBehavior)GetValue(ToolWindowsTabOverflowBehaviorProperty);
		}
		set
		{
			SetValue(ToolWindowsTabOverflowBehaviorProperty, value);
		}
	}

	public Side ToolWindowsTabStripPlacement
	{
		get
		{
			return (Side)GetValue(ToolWindowsTabStripPlacementProperty);
		}
		set
		{
			SetValue(ToolWindowsTabStripPlacementProperty, value);
		}
	}

	public ContextContentAlignment ToolWindowsTitleBarContextContentAlignment
	{
		get
		{
			return (ContextContentAlignment)GetValue(ToolWindowsTitleBarContextContentAlignmentProperty);
		}
		set
		{
			SetValue(ToolWindowsTitleBarContextContentAlignmentProperty, value);
		}
	}

	public Style ToolWindowTabItemContainerStyle
	{
		get
		{
			return (Style)GetValue(ToolWindowTabItemContainerStyleProperty);
		}
		set
		{
			SetValue(ToolWindowTabItemContainerStyleProperty, value);
		}
	}

	public bool UseDragFloatPreviews
	{
		get
		{
			return (bool)GetValue(UseDragFloatPreviewsProperty);
		}
		set
		{
			SetValue(UseDragFloatPreviewsProperty, value);
		}
	}

	public bool UseHostedFloatingWindows
	{
		get
		{
			return (bool)GetValue(UseHostedFloatingWindowsProperty);
		}
		set
		{
			SetValue(UseHostedFloatingWindowsProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Popups")]
	public bool UseHostedPopups
	{
		get
		{
			return (bool)GetValue(UseHostedPopupsProperty);
		}
		set
		{
			SetValue(UseHostedPopupsProperty, value);
		}
	}

	public bool CanUpdateItemsSourceOnUnregister
	{
		get
		{
			return (bool)GetValue(CanUpdateItemsSourceOnUnregisterProperty);
		}
		set
		{
			SetValue(CanUpdateItemsSourceOnUnregisterProperty, value);
		}
	}

	public Style DocumentItemContainerStyle
	{
		get
		{
			return (Style)GetValue(DocumentItemContainerStyleProperty);
		}
		set
		{
			SetValue(DocumentItemContainerStyleProperty, value);
		}
	}

	public StyleSelector DocumentItemContainerStyleSelector
	{
		get
		{
			return (StyleSelector)GetValue(DocumentItemContainerStyleSelectorProperty);
		}
		set
		{
			SetValue(DocumentItemContainerStyleSelectorProperty, value);
		}
	}

	public IEnumerable DocumentItemsSource
	{
		get
		{
			return (IEnumerable)GetValue(DocumentItemsSourceProperty);
		}
		set
		{
			SetValue(DocumentItemsSourceProperty, value);
		}
	}

	public DataTemplate DocumentItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(DocumentItemTemplateProperty);
		}
		set
		{
			SetValue(DocumentItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector DocumentItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(DocumentItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(DocumentItemTemplateSelectorProperty, value);
		}
	}

	public Style ToolItemContainerStyle
	{
		get
		{
			return (Style)GetValue(ToolItemContainerStyleProperty);
		}
		set
		{
			SetValue(ToolItemContainerStyleProperty, value);
		}
	}

	public StyleSelector ToolItemContainerStyleSelector
	{
		get
		{
			return (StyleSelector)GetValue(ToolItemContainerStyleSelectorProperty);
		}
		set
		{
			SetValue(ToolItemContainerStyleSelectorProperty, value);
		}
	}

	public IEnumerable ToolItemsSource
	{
		get
		{
			return (IEnumerable)GetValue(ToolItemsSourceProperty);
		}
		set
		{
			SetValue(ToolItemsSourceProperty, value);
		}
	}

	public DataTemplate ToolItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ToolItemTemplateProperty);
		}
		set
		{
			SetValue(ToolItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector ToolItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(ToolItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(ToolItemTemplateSelectorProperty, value);
		}
	}

	DockHost IDockTarget.DockHost => PrimaryDockHost;

	DockSite IDockTarget.DockSite => this;

	IEnumerable<lX> lX.ChildNodes => eQY().OfType<lX>();

	public ReadOnlyDockingWindowCollection Documents
	{
		get
		{
			rNq();
			return mmD;
		}
	}

	public DocumentWindowCollection DocumentWindows => fmn;

	public ReadOnlyObservableCollection<DockHost> FloatingDockHosts => amM;

	public bool HasDocuments => Documents.Count > 0;

	public IEnumerable<DockSite> LinkedDockSites
	{
		get
		{
			if (Vm8 == null)
			{
				yield break;
			}
			foreach (WeakReference item in Vm8)
			{
				if (item.IsAlive && item.Target is DockSite dockSite)
				{
					yield return dockSite;
				}
			}
		}
	}

	public DockHost PrimaryDockHost
	{
		get
		{
			return kmx;
		}
		private set
		{
			if (kmx == value)
			{
				return;
			}
			if (kmx != null)
			{
				kmx.DockSite = null;
				UQy.G2T(kmx.AutoHideLeftContainers);
				dQt.G2T(kmx.AutoHideTopContainers);
				int num = 0;
				if (j1O() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				jQo.G2T(kmx.AutoHideRightContainers);
				tQ5.G2T(kmx.AutoHideBottomContainers);
			}
			kmx = value;
			if (kmx != null)
			{
				kmx.DockSite = this;
				kmx.AutoHideLeftContainers.G2T(UQy);
				kmx.AutoHideTopContainers.G2T(dQt);
				kmx.AutoHideRightContainers.G2T(jQo);
				kmx.AutoHideBottomContainers.G2T(tQ5);
			}
			fN6();
		}
	}

	public ToolWindowCollection ToolWindows => Omv;

	public event EventHandler<FloatingWindowOpeningEventArgs> FloatingWindowOpening
	{
		add
		{
			AddHandler(FloatingWindowOpeningEvent, value);
		}
		remove
		{
			RemoveHandler(FloatingWindowOpeningEvent, value);
		}
	}

	public event RoutedEventHandler MdiKindChanged
	{
		add
		{
			AddHandler(MdiKindChangedEvent, value);
		}
		remove
		{
			RemoveHandler(MdiKindChangedEvent, value);
		}
	}

	public event EventHandler<DockingMenuEventArgs> MenuOpening
	{
		add
		{
			AddHandler(MenuOpeningEvent, value);
		}
		remove
		{
			RemoveHandler(MenuOpeningEvent, value);
		}
	}

	public event RoutedEventHandler NewWindowRequested
	{
		add
		{
			AddHandler(NewWindowRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(NewWindowRequestedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> PrimaryDocumentChanged
	{
		add
		{
			AddHandler(PrimaryDocumentChangedEvent, value);
		}
		remove
		{
			RemoveHandler(PrimaryDocumentChangedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowActivated
	{
		add
		{
			AddHandler(WindowActivatedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowActivatedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowAutoHidePopupClosed
	{
		add
		{
			AddHandler(WindowAutoHidePopupClosedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowAutoHidePopupClosedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowAutoHidePopupOpened
	{
		add
		{
			AddHandler(WindowAutoHidePopupOpenedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowAutoHidePopupOpenedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowDeactivated
	{
		add
		{
			AddHandler(WindowDeactivatedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowDeactivatedEvent, value);
		}
	}

	public event EventHandler<DockingWindowDefaultLocationEventArgs> WindowDefaultLocationRequested
	{
		add
		{
			AddHandler(WindowDefaultLocationRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowDefaultLocationRequestedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowRegistered
	{
		add
		{
			AddHandler(WindowRegisteredEvent, value);
		}
		remove
		{
			RemoveHandler(WindowRegisteredEvent, value);
		}
	}

	public event EventHandler<DockingWindowsAutoHidingEventArgs> WindowsAutoHiding
	{
		add
		{
			AddHandler(WindowsAutoHidingEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsAutoHidingEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsClosed
	{
		add
		{
			AddHandler(WindowsClosedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsClosedEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsClosing
	{
		add
		{
			AddHandler(WindowsClosingEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsClosingEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsDockHostChanged
	{
		add
		{
			AddHandler(WindowsDockHostChangedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsDockHostChangedEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsDragged
	{
		add
		{
			AddHandler(WindowsDraggedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsDraggedEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsDragging
	{
		add
		{
			AddHandler(WindowsDraggingEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsDraggingEvent, value);
		}
	}

	public event EventHandler<DockingWindowsDragOverEventArgs> WindowsDragOver
	{
		add
		{
			AddHandler(WindowsDragOverEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsDragOverEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsOpened
	{
		add
		{
			AddHandler(WindowsOpenedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsOpenedEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsOpening
	{
		add
		{
			AddHandler(WindowsOpeningEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsOpeningEvent, value);
		}
	}

	public event EventHandler<DockingWindowsEventArgs> WindowsStateChanged
	{
		add
		{
			AddHandler(WindowsStateChangedEvent, value);
		}
		remove
		{
			RemoveHandler(WindowsStateChangedEvent, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> WindowUnregistered
	{
		add
		{
			AddHandler(WindowUnregisteredEvent, value);
		}
		remove
		{
			RemoveHandler(WindowUnregisteredEvent, value);
		}
	}

	internal void YCA(FloatingWindowControl P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (MQh != null && !MQh.Children.Contains(P_0))
		{
			int value = dCt(null);
			Panel.SetZIndex(P_0, value);
			MQh.Children.Add(P_0);
		}
	}

	[SpecialName]
	private Panel SQW()
	{
		return MQh;
	}

	[SpecialName]
	private void FQB(Panel value)
	{
		if (MQh != null)
		{
			IQn(null);
			MQh.Children.Clear();
		}
		MQh = value;
	}

	private void iCH()
	{
		if (!qQv() || MQh == null || MQh.Children.Count <= 0)
		{
			return;
		}
		DockingWindow activeWindow = ActiveWindow;
		if (activeWindow == null)
		{
			return;
		}
		DockHost dockHost = activeWindow.DockHost;
		int num = 0;
		if (!K17())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (dockHost != null && dockHost.Meg())
		{
			FloatingWindowControl ancestor = VisualTreeHelperExtended.GetAncestor<FloatingWindowControl>(dockHost);
			if (ancestor != null)
			{
				dCt(ancestor);
			}
		}
	}

	internal void cC0(FloatingWindowControl P_0)
	{
		dCt(P_0);
	}

	internal IEnumerable<FloatingWindowControl> SCh()
	{
		if (MQh != null)
		{
			return MQh.Children.OfType<FloatingWindowControl>();
		}
		return new FloatingWindowControl[0];
	}

	[SpecialName]
	internal QK dQJ()
	{
		return lQg;
	}

	[SpecialName]
	internal void IQn(QK value)
	{
		if (lQg == value)
		{
			return;
		}
		int num;
		if (lQg != null)
		{
			num = 1;
			if (K17())
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0076;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0042;
		}
		if (MQh != null && MQh.Children.Contains(lQg))
		{
			MQh.Children.Remove(lQg);
		}
		goto IL_0076;
		IL_0076:
		lQg = value;
		if (lQg == null || MQh == null || MQh.Children.Contains(lQg))
		{
			return;
		}
		Panel.SetZIndex(lQg, 10000);
		DockHost dockHost = lQg.j8o();
		if (dockHost != null)
		{
			Point point = dockHost.TransformToVisual(MQh).Transform(default(Point));
			Canvas.SetLeft(lQg, point.X);
			Canvas.SetTop(lQg, point.Y);
			lQg.Width = dockHost.ActualWidth;
			lQg.Height = dockHost.ActualHeight;
			num = 0;
			if (!K17())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		goto IL_0042;
		IL_0042:
		MQh.Children.Add(lQg);
	}

	[SpecialName]
	internal Rect FQT()
	{
		if (!TQX.HasValue)
		{
			FrameworkElement frameworkElement = HostedFloatingWindowContainer ?? this;
			if (frameworkElement is Window window)
			{
				frameworkElement = (window.Content as FrameworkElement) ?? this;
			}
			if (frameworkElement.IsAncestorOf(this))
			{
				Rect rect = new Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
				TQX = frameworkElement.TransformToVisual(this).TransformBounds(rect);
			}
			else
			{
				TQX = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
			}
		}
		return TQX.Value;
	}

	internal void MCg()
	{
		TQX = null;
	}

	internal bool rCX(FloatingWindowControl P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (MQh != null)
		{
			return MQh.Children.Contains(P_0);
		}
		return false;
	}

	internal void rC5(FloatingWindowControl P_0, FloatingWindowControl P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		FloatingWindowControl[] array = (from w in MQh.Children.OfType<FloatingWindowControl>()
			orderby Panel.GetZIndex(w)
			select w).ToArray();
		int num = Array.IndexOf(array, P_0);
		int num2 = Array.IndexOf(array, P_1);
		if (num == -1 || num2 == -1)
		{
			return;
		}
		if (num <= num2)
		{
			if (num < num2 - 1)
			{
				int zIndex = Panel.GetZIndex(array[num2]);
				Panel.SetZIndex(array[num], --zIndex);
				for (int num3 = num2 - 1; num3 > num; num3--)
				{
					Panel.SetZIndex(array[num3], --zIndex);
				}
			}
			return;
		}
		int num4 = Panel.GetZIndex(array[num]);
		int num5 = num - 1;
		int num6 = 1;
		if (j1O() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num7 = default(int);
		num6 = num7;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num6)
			{
			case 1:
				break;
			default:
				num5--;
				break;
			}
			if (num5 >= num2)
			{
				Panel.SetZIndex(array[num5], --num4);
				num6 = 0;
				continue;
			}
			Panel.SetZIndex(array[num], --num4);
			return;
		}
		while (j1O() == null);
		goto IL_0005;
	}

	private static void DCy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		if (!dockSite.qQv())
		{
			return;
		}
		foreach (FloatingWindowControl item in dockSite.SCh())
		{
			item?.eEv();
		}
	}

	internal void GCo(FloatingWindowControl P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (MQh != null && MQh.Children.Contains(P_0))
		{
			MQh.Children.Remove(P_0);
		}
	}

	private int dCt(FloatingWindowControl P_0)
	{
		_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass26_0();
		CS_0024_003C_003E8__locals3.MLP = P_0;
		int result = 1;
		FloatingWindowControl[] array = (from w in MQh.Children.OfType<FloatingWindowControl>()
			orderby (CS_0024_003C_003E8__locals3.MLP == null || CS_0024_003C_003E8__locals3.MLP != w) ? Panel.GetZIndex(w) : 10000
			select w).ToArray();
		for (int num = 0; num < array.Length; num++)
		{
			Panel.SetZIndex(array[num], result++);
		}
		return result;
	}

	internal void CCu(bool P_0)
	{
		foreach (DockHost item in eQY())
		{
			if (item != null && item.IsAutoHidePopupOpen)
			{
				item.CloseAutoHidePopup(P_0, blurFocus: false);
			}
		}
	}

	internal bool jCz(ToolWindow P_0)
	{
		bool num = P_0 != null && aQu == P_0.UniqueId && DateTime.Now.Subtract(mQz).Milliseconds < 250;
		aQu = Guid.Empty;
		return !num;
	}

	private void M1i(ToolWindow P_0)
	{
		if (P_0 != null && !IQR())
		{
			aQu = P_0.UniqueId;
			mQz = DateTime.Now;
		}
		else
		{
			aQu = Guid.Empty;
		}
	}

	private static void x1d(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.zBn();
		}
	}

	public DockSite()
	{
		IVH.CecNqz();
		tQ5 = new ToolWindowContainerCollection();
		UQy = new ToolWindowContainerCollection();
		jQo = new ToolWindowContainerCollection();
		dQt = new ToolWindowContainerCollection();
		mQz = DateTime.Now;
		pmW = new List<DockingWindow>();
		wmJ = new List<DockingWindow>();
		fmn = new DocumentWindowCollection();
		OmO = new ObservableCollection<DockHost>();
		Omv = new ToolWindowCollection();
		em7 = true;
		base._002Ector();
		base.DefaultStyleKey = typeof(DockSite);
		c1w();
		o12();
		DockSiteRegistryConstructor();
		base.Loaded += L1O;
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Docking.AssemblyInfo.Instance, GetType(), this);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void c1w()
	{
		lmi = new DelegateCommand<object>(delegate
		{
			ActivateNextDocument();
		}, (object P_0) => HasDocuments);
		Tmd = new DelegateCommand<object>(delegate
		{
			ActivatePreviousDocument();
		}, (object P_0) => HasDocuments);
		Rmw = new DelegateCommand<object>(delegate
		{
			ActivatePrimaryDocument();
		}, (object P_0) => PrimaryDocument != null);
		Km2 = new DelegateCommand<object>(delegate
		{
			CascadeDocuments();
		}, (object P_0) => cQ4()?.CanCascade ?? false);
		xme = new DelegateCommand<object>(delegate
		{
			CloseAllDocuments();
		}, (object P_0) => jQP().Any((DockingWindow w) => w.CanCloseResolved));
		UmG = new DelegateCommand<object>(delegate
		{
			ClosePrimaryDocument();
		}, (object P_0) => PrimaryDocument?.CanCloseResolved ?? false);
		fmI = new DelegateCommand<object>(delegate(object P_0)
		{
			if (!(P_0 is MdiKind) && !(P_0 is int))
			{
				MdiKind = MdiKind.None;
			}
			else
			{
				MdiKind = (MdiKind)P_0;
			}
		});
		mmk = new DelegateCommand<object>(delegate
		{
			TileDocumentsHorizontally();
		}, (object P_0) => cQ4()?.CanTile ?? false);
		pmC = new DelegateCommand<object>(delegate
		{
			TileDocumentsVertically();
		}, (object P_0) => cQ4()?.CanTile ?? false);
	}

	private void o12()
	{
		Switcher = new StandardSwitcher();
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool WQE()
	{
		return bmQ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void LQr(bool value)
	{
		bmQ = value;
	}

	private static void f1e(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		DockingWindow dockingWindow = P_1.OldValue as DockingWindow;
		DockingWindow dockingWindow2 = P_1.NewValue as DockingWindow;
		if (dockingWindow != null)
		{
			dockingWindow.IsActive = false;
			dockSite.V1P(dockingWindow);
			if (dockSite.AutoHidePopupToolWindow == dockingWindow)
			{
				dockSite.M1i(dockingWindow as ToolWindow);
				dockSite.CCu(_0020: false);
			}
		}
		if (dockingWindow2 != null)
		{
			dockingWindow2.IsActive = true;
			dockSite.iCH();
			if (dockingWindow2.QkM() == DockingWindowState.Document)
			{
				dockSite.PrimaryDocument = dockingWindow2;
			}
			dockSite.g1q(dockingWindow2);
			int num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static void g1G(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		foreach (DocumentWindow documentWindow in dockSite.DocumentWindows)
		{
			documentWindow.UpdateCanCloseResolved();
		}
		if (dockSite.DocumentWindows.Any((DocumentWindow w) => w.IsCurrentlyOpen))
		{
			dockSite.m1v();
		}
	}

	private static void q1I(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DocumentWindow documentWindow in ((DockSite)P_0).DocumentWindows)
		{
			documentWindow.UpdateCanDragToLinkedDockSitesResolved();
		}
	}

	private static void j1k(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DocumentWindow documentWindow in ((DockSite)P_0).DocumentWindows)
		{
			documentWindow.UpdateCanFloatResolved();
		}
	}

	private static void r1C(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanAttachResolved();
		}
	}

	private static void G11(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanBecomeDocumentResolved();
		}
	}

	private static void q1N(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		foreach (ToolWindow toolWindow in dockSite.ToolWindows)
		{
			toolWindow.UpdateCanCloseResolved();
		}
		if (dockSite.ToolWindows.Any((ToolWindow w) => w.IsCurrentlyOpen && w.QkM() == DockingWindowState.Document))
		{
			dockSite.m1v();
		}
	}

	private static void p1Q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanDockResolved();
		}
	}

	private static void Q1m(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanDragToLinkedDockSitesResolved();
		}
	}

	private static void E1a(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanFloatResolved();
		}
	}

	private static void i1W(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.UpdateCanDragTabResolved();
		}
	}

	private static void W1B(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		if (P_1.OldValue != null)
		{
			dockSite.xNg(P_1.OldValue as FrameworkElement, _0020: false);
		}
		if (P_1.NewValue != null)
		{
			dockSite.xNg(P_1.NewValue as FrameworkElement, _0020: true);
		}
	}

	private static void E1K(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockSite)P_0).FN0();
	}

	private static void p1J(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockSite)P_0).FN0();
	}

	private static void i1n(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DockHost item in ((DockSite)P_0).eQY())
		{
			item?.p2h();
		}
	}

	private void L1O(object P_0, RoutedEventArgs P_1)
	{
		DockingWindow dockingWindow = PrimaryDocument;
		if (dockingWindow == null)
		{
			if (cQ4() != null)
			{
				dockingWindow = cQ4().PrimaryWindow;
			}
			if (dockingWindow == null || !jQP().Contains(dockingWindow))
			{
				dockingWindow = (from w in jQP()
					orderby w.LastActiveDateTime descending
					select w).FirstOrDefault();
			}
			if (dockingWindow != null)
			{
				int num = 0;
				if (j1O() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				PrimaryDocument = dockingWindow;
			}
		}
		if (!em1 && VisualTreeHelper.GetChildrenCount(this) > 0)
		{
			em1 = true;
			DockingWindow[] array = (from r in pL.Mxl(this, (DockingWindow w) => !w.IsOpen)
				select r.dx3()).ToArray();
			if (array.Length != 0)
			{
				new Nx(this).Close(array, (wU)0, force: true, allowDocumentDestroy: true);
			}
		}
	}

	private static void y1T(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		switch (dockSite.MdiKind)
		{
		case MdiKind.Standard:
			if (!(dockSite.cQ4() is StandardMdiHost))
			{
				dockSite.HQj(XNi());
			}
			break;
		case MdiKind.Tabbed:
			if (!(dockSite.cQ4() is TabbedMdiHost))
			{
				dockSite.HQj(PNw());
			}
			break;
		default:
			if (dockSite.cQ4() != null)
			{
				dockSite.HQj(null);
			}
			break;
		}
		dockSite.v17();
		dockSite.a16();
	}

	private static void b18(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockSite dockSite = (DockSite)P_0;
		DockingWindow dockingWindow = P_1.NewValue as DockingWindow;
		if (!dockSite.pmB)
		{
			dockSite.W1s(dockingWindow);
		}
	}

	private static void s1D(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.OldValue is SwitcherBase { IsOpen: not false } switcherBase)
		{
			switcherBase.Close();
		}
	}

	private static void c1E(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.CBO();
		}
	}

	private static void r1r(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (DockHost item in ((DockSite)P_0).eQY())
		{
			if (item == null)
			{
				continue;
			}
			foreach (AutoHideTabStrip item2 in item.s25())
			{
				item2?.T88();
			}
		}
	}

	private static void l1x(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		foreach (ToolWindow toolWindow in ((DockSite)P_0).ToolWindows)
		{
			toolWindow.rBT();
		}
	}

	private static void U1l(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockHost[] array = ((DockSite)P_0).FloatingDockHosts.ToArray();
		foreach (DockHost dockHost in array)
		{
			if (dockHost != null && dockHost.Meg() && dockHost.Re5())
			{
				dockHost.Close(forceDestroy: false);
			}
		}
	}

	internal void s1M(G0 P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9202));
		}
		if (!P_1)
		{
			if (YmN != null && !YmN.IsAlive)
			{
				YmN = null;
			}
		}
		else
		{
			if (YmN != null)
			{
				int num = 0;
				if (j1O() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (YmN.IsAlive)
				{
					G0 g = (G0)YmN.Target;
					if (g != null && g != P_0)
					{
						g.IsActive = false;
					}
				}
			}
			YmN = new WeakReference(P_0);
		}
		P_0.IsActive = P_1;
	}

	internal void m1v()
	{
		lmi.RaiseCanExecuteChanged();
		Tmd.RaiseCanExecuteChanged();
		Rmw.RaiseCanExecuteChanged();
		xme.RaiseCanExecuteChanged();
		UmG.RaiseCanExecuteChanged();
	}

	private void v17()
	{
		Km2.RaiseCanExecuteChanged();
		mmk.RaiseCanExecuteChanged();
		pmC.RaiseCanExecuteChanged();
	}

	[SpecialName]
	internal bool RQl()
	{
		if (UseDragFloatPreviews)
		{
			return true;
		}
		if (!BrowserInteropHelper.IsBrowserHosted)
		{
			return !SystemParameters.DragFullWindows;
		}
		return false;
	}

	[SpecialName]
	internal bool qQv()
	{
		if (!UseHostedFloatingWindows && !BrowserInteropHelper.IsBrowserHosted)
		{
			return !SecurityHelper.IsFullTrust;
		}
		return true;
	}

	[SpecialName]
	internal bool IQR()
	{
		if (!UseHostedPopups && !BrowserInteropHelper.IsBrowserHosted)
		{
			return !SecurityHelper.IsFullTrust;
		}
		return true;
	}

	public void ActivateNextDocument()
	{
		ReadOnlyDockingWindowCollection documents = Documents;
		if (documents.Count > 0)
		{
			DockingWindow primaryDocument = PrimaryDocument;
			int num = ((primaryDocument != null) ? (documents.IndexOf(primaryDocument) + 1) : 0);
			if (num >= documents.Count)
			{
				num = 0;
			}
			documents[num].Activate();
		}
	}

	public void ActivatePreviousDocument()
	{
		ReadOnlyDockingWindowCollection documents = Documents;
		if (documents.Count <= 0)
		{
			return;
		}
		DockingWindow primaryDocument = PrimaryDocument;
		int num = ((primaryDocument != null) ? (documents.IndexOf(primaryDocument) - 1) : (documents.Count - 1));
		int num2 = 0;
		if (!K17())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (num < 0)
		{
			num = documents.Count - 1;
		}
		documents[num].Activate();
	}

	public void ActivatePrimaryDocument()
	{
		PrimaryDocument?.Activate();
	}

	public void CascadeDocuments()
	{
		foreach (DockHost item in eQY())
		{
			if (item != null)
			{
				jJ jJ = item.veR();
				if (jJ != null && jJ.CanCascade)
				{
					jJ.Cascade();
				}
			}
		}
	}

	public bool CloseAllDocuments()
	{
		return s1t().Close(from w in jQP()
			where w.CanCloseResolved
			select w, (wU)3, force: false, allowDocumentDestroy: true);
	}

	public bool ClosePrimaryDocument()
	{
		DockingWindow primaryDocument = PrimaryDocument;
		if (primaryDocument != null && primaryDocument.CanCloseResolved)
		{
			return s1t().Close(primaryDocument, wU.Close, force: false, allowDocumentDestroy: true);
		}
		return false;
	}

	public override void OnApplyTemplate()
	{
		CCu(_0020: true);
		base.OnApplyTemplate();
		FQB(GetTemplateChild(vVK.ssH(9224)) as Panel);
		PrimaryDockHost = GetTemplateChild(vVK.ssH(9264)) as DockHost;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new DockSiteAutomationPeer(this);
	}

	protected internal virtual void ProcessDockHostKeyDown(DockHost dockHost, KeyEventArgs e)
	{
		if (dockHost == null || e == null || e.Handled)
		{
			return;
		}
		Key key = e.Key;
		int num;
		if (key == Key.Escape)
		{
			if (dockHost.IsAutoHidePopupOpen)
			{
				dockHost.CloseAutoHidePopup(closeImmediately: false, blurFocus: true);
				e.Handled = true;
				return;
			}
			if (PrimaryDocument == null || PrimaryDocument == ActiveWindow)
			{
				return;
			}
			num = 0;
			if (!K17())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			if (key == Key.F4)
			{
				if (Yp.aR4() == ModifierKeys.Control)
				{
					ClosePrimaryDocument();
					e.Handled = true;
				}
				return;
			}
			if (key != Key.F6)
			{
				Switcher?.Jr0(this, e);
				return;
			}
			ModifierKeys modifierKeys = Yp.aR4();
			if (modifierKeys == ModifierKeys.Control)
			{
				ActivateNextDocument();
				num = 1;
				if (!K17())
				{
					num = 1;
				}
			}
			else
			{
				if (modifierKeys == (ModifierKeys.Control | ModifierKeys.Shift))
				{
					ActivatePreviousDocument();
					e.Handled = true;
					return;
				}
				num = 2;
			}
		}
		switch (num)
		{
		case 1:
			e.Handled = true;
			break;
		case 2:
			break;
		default:
			ActivatePrimaryDocument();
			e.Handled = true;
			break;
		}
	}

	public void TileDocumentsHorizontally()
	{
		foreach (DockHost item in eQY())
		{
			if (item != null)
			{
				jJ jJ = item.veR();
				if (jJ != null && jJ.CanTile)
				{
					jJ.TileHorizontally();
				}
			}
		}
	}

	public void TileDocumentsVertically()
	{
		foreach (DockHost item in eQY())
		{
			if (item != null)
			{
				jJ jJ = item.veR();
				if (jJ != null && jJ.CanTile)
				{
					jJ.TileVertically();
				}
			}
		}
	}

	[SpecialName]
	internal bool gQ6()
	{
		return ymm != null;
	}

	internal void Q1R(Point P_0)
	{
		ymm?.u74(P_0);
	}

	internal il Q1S(gh P_0)
	{
		J1L(P_0, _0020: false, null);
		il il = (ymm = (qQv() ? ((il)new NI(this, P_0)) : ((il)new vE(this, P_0))));
		il.z7j();
		if (P_0 != null)
		{
			D1A(from r in pL.Mxl<DockingWindow>(P_0.DockHost, null)
				select r.dx3());
		}
		return il;
	}

	internal bool J1L(gh P_0, bool P_1, Action P_2)
	{
		il il = ymm;
		if (il != null)
		{
			IEnumerable<DockingWindow> enumerable = ((P_0 != null) ? (from r in pL.Mxl<DockingWindow>(P_0.DockHost, null)
				select r.dx3()) : null);
			ymm = null;
			bool num = il.l7Z(P_1);
			if (!num)
			{
				P_2?.Invoke();
			}
			if (enumerable != null)
			{
				O1b(enumerable);
			}
			return num;
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void nQA(EventHandler value)
	{
		EventHandler eventHandler = Wma;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref Wma, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void FQH(EventHandler value)
	{
		EventHandler eventHandler = Wma;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref Wma, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void f13(FloatingWindowOpeningEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = FloatingWindowOpeningEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnFloatingWindowOpening(P_0);
		RaiseEvent(P_0);
	}

	internal void a16()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = MdiKindChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnMdiKindChanged(e);
		RaiseEvent(e);
	}

	internal void C19(DockingMenuEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = MenuOpeningEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnMenuOpening(P_0);
		RaiseEvent(P_0);
	}

	internal void N1Y()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = NewWindowRequestedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnNewWindowRequested(e);
		RaiseEvent(e);
	}

	private void w1p()
	{
		Wma?.Invoke(this, EventArgs.Empty);
	}

	private void W1s(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = PrimaryDocumentChangedEvent,
			Source = this,
			Window = P_0
		};
		OnPrimaryDocumentChanged(e);
		RaiseEvent(e);
	}

	private void g1q(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowActivatedEvent,
			Source = this,
			Window = P_0
		};
		OnWindowActivated(e);
		RaiseEvent(e);
	}

	internal void o1F(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowAutoHidePopupClosedEvent,
			Source = this,
			Window = P_0
		};
		OnWindowAutoHidePopupClosed(e);
		RaiseEvent(e);
	}

	internal void P1V(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowAutoHidePopupOpenedEvent,
			Source = this,
			Window = P_0
		};
		OnWindowAutoHidePopupOpened(e);
		RaiseEvent(e);
	}

	private void V1P(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowDeactivatedEvent,
			Source = this,
			Window = P_0
		};
		OnWindowDeactivated(e);
		RaiseEvent(e);
	}

	internal void n1f(DockingWindowDefaultLocationEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = WindowDefaultLocationRequestedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnWindowDefaultLocationRequested(P_0);
		RaiseEvent(P_0);
	}

	private void m1U(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowRegisteredEvent,
			Source = this,
			Window = P_0
		};
		OnWindowRegistered(e);
		RaiseEvent(e);
	}

	internal void L1c(DockingWindowsAutoHidingEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = WindowsAutoHidingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnWindowsAutoHiding(P_0);
		RaiseEvent(P_0);
	}

	internal void n14(IEnumerable<DockingWindow> P_0)
	{
		if (P_0 != null)
		{
			foreach (DockingWindow item in P_0)
			{
				item.UIX();
			}
		}
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsClosedEvent,
			Source = this
		};
		OnWindowsClosed(e);
		RaiseEvent(e);
	}

	internal bool j1j(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsClosingEvent,
			Source = this
		};
		OnWindowsClosing(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	internal void g1Z(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsDockHostChangedEvent,
			Source = this
		};
		OnWindowsDockHostChanged(e);
		RaiseEvent(e);
	}

	internal bool O1b(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsDraggedEvent,
			Source = this
		};
		OnWindowsDragged(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	internal bool D1A(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsDraggingEvent,
			Source = this
		};
		OnWindowsDragging(e);
		RaiseEvent(e);
		return e.Cancel;
	}

	internal DockGuideKinds R1H(DockHost P_0, IDockTarget P_1, DockGuideKinds P_2)
	{
		DockingWindowsDragOverEventArgs e = new DockingWindowsDragOverEventArgs(P_0, P_1, P_2)
		{
			RoutedEvent = WindowsDragOverEvent,
			Source = this
		};
		OnWindowsDragOver(e);
		RaiseEvent(e);
		return e.AllowedDockGuideKinds & P_2;
	}

	internal void d10(IEnumerable<DockingWindow> P_0)
	{
		if (P_0 != null)
		{
			foreach (DockingWindow item in P_0)
			{
				item.UIX();
			}
		}
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsOpenedEvent,
			Source = this
		};
		OnWindowsOpened(e);
		RaiseEvent(e);
	}

	internal void R1h(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsOpeningEvent,
			Source = this
		};
		OnWindowsOpening(e);
		RaiseEvent(e);
	}

	internal void X1g(IEnumerable<DockingWindow> P_0)
	{
		DockingWindowsEventArgs e = new DockingWindowsEventArgs(P_0)
		{
			RoutedEvent = WindowsStateChangedEvent,
			Source = this
		};
		OnWindowsStateChanged(e);
		RaiseEvent(e);
	}

	private void m1X(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = WindowUnregisteredEvent,
			Source = this,
			Window = P_0
		};
		OnWindowUnregistered(e);
		RaiseEvent(e);
	}

	protected virtual void OnFloatingWindowOpening(FloatingWindowOpeningEventArgs e)
	{
	}

	protected virtual void OnMdiKindChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnMenuOpening(DockingMenuEventArgs e)
	{
	}

	protected virtual void OnNewWindowRequested(RoutedEventArgs e)
	{
	}

	protected virtual void OnPrimaryDocumentChanged(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowActivated(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowAutoHidePopupClosed(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowAutoHidePopupOpened(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowDeactivated(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowDefaultLocationRequested(DockingWindowDefaultLocationEventArgs e)
	{
	}

	protected virtual void OnWindowRegistered(DockingWindowEventArgs e)
	{
	}

	protected virtual void OnWindowsAutoHiding(DockingWindowsAutoHidingEventArgs e)
	{
	}

	protected virtual void OnWindowsClosed(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsClosing(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsDockHostChanged(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsDragged(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsDragging(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsDragOver(DockingWindowsDragOverEventArgs e)
	{
	}

	protected virtual void OnWindowsOpened(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsOpening(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowsStateChanged(DockingWindowsEventArgs e)
	{
	}

	protected virtual void OnWindowUnregistered(DockingWindowEventArgs e)
	{
	}

	internal DockHost i15()
	{
		DockHost dockHost = new DockHost
		{
			DockSite = this
		};
		OmO.Add(dockHost);
		return dockHost;
	}

	internal DockHost m1y(Guid P_0)
	{
		_003C_003Ec__DisplayClass522_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass522_0();
		CS_0024_003C_003E8__locals4.PLU = P_0;
		if (CS_0024_003C_003E8__locals4.PLU == Guid.Empty)
		{
			return i15();
		}
		DockHost dockHost = OmO.FirstOrDefault((DockHost dh) => dh.UniqueId == CS_0024_003C_003E8__locals4.PLU);
		if (dockHost != null)
		{
			return dockHost;
		}
		dockHost = i15();
		dockHost.UniqueId = CS_0024_003C_003E8__locals4.PLU;
		return dockHost;
	}

	internal gh I1o(DockHost P_0, Control P_1, Point P_2, bool P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		if (!qQv())
		{
			return r1u(P_0, P_1, P_2, P_3);
		}
		Rect rect = default(Rect);
		int num;
		Size size = default(Size);
		if (P_1 != null)
		{
			if (MQh != null)
			{
				rect = P_1.TransformToVisual(MQh).TransformBounds(new Rect(default(Point), P_1.RenderSize));
				num = 2;
				goto IL_0009;
			}
			P_0.XeK(P_2);
			P_0.beO(P_1.RenderSize);
		}
		else if (P_0.reo() && P_0.DockSite != null && MQh != null)
		{
			Point point = P_0.DockSite.TransformToVisual(MQh).Transform(P_2);
			P_0.XeK(new Point(point.X - Math.Round(P_0.Hen().Width / 2.0), point.Y - 10.0));
		}
		else if (!P_0.GeB().HasValue)
		{
			size = P_0.Hen();
			if (size.Width > 0.0)
			{
				num = 0;
				if (!K17())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_0108;
		IL_0108:
		if (!P_3)
		{
			return new x6(P_0);
		}
		return new cC(P_0);
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (size.Height > 0.0)
				{
					P_0.XeK(new Point(Math.Max(0.0, Math.Round((MQh.ActualWidth - P_0.Hen().Width) / 2.0)), Math.Max(0.0, Math.Round((MQh.ActualHeight - P_0.Hen().Height) / 2.0))));
				}
				break;
			case 2:
				P_0.XeK(new Point(rect.X + P_2.X, rect.Y + P_2.Y));
				P_0.beO(new Size(rect.Width, rect.Height));
				break;
			default:
				goto IL_00d4;
			}
			break;
			IL_00d4:
			size = P_0.Hen();
			num = 1;
			if (j1O() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0108;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	internal Nx s1t()
	{
		return new Nx(this);
	}

	private gh r1u(DockHost P_0, Control P_1, Point P_2, bool P_3)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		int num;
		Point point2 = default(Point);
		Point point3 = default(Point);
		if (P_1 == null)
		{
			if (!P_0.reo() || P_0.DockSite == null)
			{
				goto IL_0123;
			}
			Point point = hV.JJ(P_0.DockSite, P_2);
			P_0.XeK(new Point(point.X - Math.Round(P_0.Hen().Width / 2.0), point.Y - 10.0));
			num = 0;
			if (!K17())
			{
				goto IL_0005;
			}
		}
		else
		{
			bool flag = bO.SO8(P_1);
			point2 = hV.JJ(P_1, P_2);
			point3 = hV.JJ(P_1, new Point(P_1.ActualWidth + P_2.X, P_1.ActualHeight + P_2.Y));
			P_0.XeK(flag ? new Point(point3.X, point2.Y) : point2);
			num = 1;
			if (j1O() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			P_0.beO(new Size(Math.Abs(point3.X - point2.X), Math.Abs(point3.Y - point2.Y)));
			break;
		}
		goto IL_0123;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0123:
		AM aM;
		if (!P_3)
		{
			aM = new JZ(P_0);
			InitializeFloatingWindow(aM.Bvp());
			aM.nvV(aM.Bvp().MinWidth == 0.0 || aM.Bvp().MinHeight == 0.0);
		}
		else
		{
			aM = new EY(P_0);
		}
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		TextOptions.SetTextFormattingMode(aM.Bvp(), textFormattingMode);
		return aM;
	}

	internal static SplitContainer y1z(DockHost P_0, Orientation P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		return new SplitContainer(P_0)
		{
			Orientation = P_1
		};
	}

	private static StandardMdiHost XNi()
	{
		return new StandardMdiHost();
	}

	internal static TabbedMdiContainer gNd(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		return new TabbedMdiContainer
		{
			DockHost = P_0
		};
	}

	private static TabbedMdiHost PNw()
	{
		return new TabbedMdiHost();
	}

	internal static ToolWindowContainer dN2(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		return new ToolWindowContainer
		{
			DockHost = P_0
		};
	}

	internal static Workspace HNe()
	{
		return new Workspace();
	}

	internal void VNG(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		if (OmO.Contains(P_0))
		{
			P_0.veR()?.DetachFromPrimaryDockHost();
			OmO.Remove(P_0);
		}
		if (kmx == P_0)
		{
			PrimaryDockHost = null;
		}
		P_0.DockSite = null;
	}

	protected internal virtual void InitializeAutoHidePopupWindow(Window window)
	{
	}

	protected internal virtual void InitializeDockingAdornmentWindow(Window window)
	{
	}

	protected virtual void InitializeFloatingWindow(Window window)
	{
	}

	private void VNI(IList<DockingWindow> P_0, IList P_1, int P_2, DockingWindowItemKind P_3)
	{
		if (P_1 == null || P_1.Count == 0)
		{
			return;
		}
		foreach (object item in P_1)
		{
			DockingWindow dockingWindow = item as DockingWindow;
			if (dockingWindow == null || !IsItemItsOwnContainerOverride(item, P_3))
			{
				dockingWindow = QmK ?? GetContainerForItemOverride(P_3);
				dockingWindow.DataContext = item;
			}
			else
			{
				dockingWindow.IsContainerForItem = true;
			}
			PrepareContainerForItemOverride(dockingWindow, item, P_3);
			if (P_2 < 0 || P_2 >= P_0.Count)
			{
				P_0.Add(dockingWindow);
			}
			else
			{
				P_0.Insert(P_2, dockingWindow);
			}
			dockingWindow.DockSite = this;
			P_2++;
		}
	}

	public static void ApplyContainerStyle(object item, DockingWindow container, StyleSelector styleSelector, Style style)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (container == null)
					{
						return;
					}
					num2 = 0;
					if (K17())
					{
						continue;
					}
					goto end_IL_0012;
				}
				if (style == null && styleSelector != null)
				{
					style = styleSelector.SelectStyle(item, container);
				}
				if (container.Gks() || DependencyPropertyHelper.GetValueSource(container, FrameworkElement.StyleProperty).BaseValueSource != BaseValueSource.Local)
				{
					container.Jkq(style != null);
					if (!container.Gks())
					{
						container.ClearValue(FrameworkElement.StyleProperty);
					}
					else
					{
						container.SetValue(FrameworkElement.StyleProperty, style);
					}
				}
				return;
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	private static void INk(DockingWindow P_0)
	{
		if (P_0 != null && (P_0.Gks() || DependencyPropertyHelper.GetValueSource(P_0, FrameworkElement.StyleProperty).BaseValueSource != BaseValueSource.Local))
		{
			P_0.ClearValue(FrameworkElement.StyleProperty);
			P_0.Jkq(value: false);
		}
	}

	private static void zNC(IList<DockingWindow> P_0, IList P_1, int P_2, int P_3)
	{
		if (P_1 != null && P_1.Count != 0 && P_2 >= 0 && P_2 < P_0.Count && P_3 >= 0 && P_3 < P_0.Count && P_2 != P_3)
		{
			if (P_1.Count != 1)
			{
				throw new NotSupportedException();
			}
			DockingWindow item = P_0[P_2];
			P_0.RemoveAt(P_2);
			P_0.Insert(P_3, item);
		}
	}

	private static void cN1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is DockSite dockSite)
		{
			dockSite.bNJ();
		}
	}

	private void JNN(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		switch (P_1.Action)
		{
		case NotifyCollectionChangedAction.Remove:
			aNO(pmW, P_1.OldItems, P_1.OldStartingIndex, DockingWindowItemKind.Document);
			break;
		case NotifyCollectionChangedAction.Add:
			VNI(pmW, P_1.NewItems, P_1.NewStartingIndex, DockingWindowItemKind.Document);
			break;
		case NotifyCollectionChangedAction.Reset:
			bNJ();
			break;
		case NotifyCollectionChangedAction.Move:
			zNC(pmW, P_1.NewItems, P_1.OldStartingIndex, P_1.NewStartingIndex);
			break;
		case NotifyCollectionChangedAction.Replace:
			BNT(pmW, P_1.OldItems, P_1.NewItems, P_1.NewStartingIndex, DockingWindowItemKind.Document);
			break;
		}
	}

	private static void rNQ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		DockSite dockSite = default(DockSite);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dockSite = P_0 as DockSite;
				num2 = 0;
				if (j1O() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (dockSite != null)
			{
				if (P_1.OldValue is INotifyCollectionChanged notifyCollectionChanged)
				{
					notifyCollectionChanged.CollectionChanged -= dockSite.JNN;
				}
				if (P_1.NewValue is INotifyCollectionChanged notifyCollectionChanged2)
				{
					notifyCollectionChanged2.CollectionChanged += dockSite.JNN;
				}
				dockSite.bNJ();
				dockSite.OnDocumentItemsSourceChanged(P_1.OldValue as IEnumerable, P_1.NewValue as IEnumerable);
			}
			return;
		}
	}

	private static void CNm(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is DockSite dockSite)
		{
			dockSite.vNn();
		}
	}

	private void QNa(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		switch (P_1.Action)
		{
		case NotifyCollectionChangedAction.Remove:
			aNO(wmJ, P_1.OldItems, P_1.OldStartingIndex, DockingWindowItemKind.Tool);
			break;
		case NotifyCollectionChangedAction.Add:
			VNI(wmJ, P_1.NewItems, P_1.NewStartingIndex, DockingWindowItemKind.Tool);
			break;
		case NotifyCollectionChangedAction.Reset:
			vNn();
			break;
		case NotifyCollectionChangedAction.Replace:
			BNT(wmJ, P_1.OldItems, P_1.NewItems, P_1.NewStartingIndex, DockingWindowItemKind.Tool);
			break;
		case NotifyCollectionChangedAction.Move:
			zNC(wmJ, P_1.NewItems, P_1.OldStartingIndex, P_1.NewStartingIndex);
			break;
		}
	}

	private static void GNW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is DockSite dockSite))
		{
			return;
		}
		if (P_1.OldValue is INotifyCollectionChanged notifyCollectionChanged)
		{
			notifyCollectionChanged.CollectionChanged -= dockSite.QNa;
		}
		if (P_1.NewValue is INotifyCollectionChanged notifyCollectionChanged2)
		{
			notifyCollectionChanged2.CollectionChanged += dockSite.QNa;
			int num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		dockSite.vNn();
		dockSite.OnToolItemsSourceChanged(P_1.OldValue as IEnumerable, P_1.NewValue as IEnumerable);
	}

	private void yNB(DockingWindow P_0)
	{
		if (!base.IsInitialized || P_0 == null || !P_0.IsContainerForItem || P_0.IsCurrentlyOpen || P_0.DockSite != this)
		{
			return;
		}
		XmlDockingWindow xmlDockingWindow = NNP(P_0);
		if (xmlDockingWindow != null)
		{
			P_0.IsOpen = xmlDockingWindow.IsOpen;
		}
		if (P_0.IsCurrentlyOpen)
		{
			return;
		}
		if (!P_0.IsOpen)
		{
			int num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!P_0.IsActive)
			{
				return;
			}
		}
		P_0.Open();
	}

	private void INK(IList<DockingWindow> P_0, IEnumerable P_1, DockingWindowItemKind P_2)
	{
		object[] array = P_1?.OfType<object>().ToArray();
		DockingWindow primaryDocument = PrimaryDocument;
		DockingWindow dockingWindow = null;
		pmB = true;
		try
		{
			DockingWindow[] array2 = P_0.ToArray();
			foreach (DockingWindow dockingWindow2 in array2)
			{
				dockingWindow2.Destroy();
				ClearContainerForItemOverride(dockingWindow2, dockingWindow2.DataContext, P_2);
			}
			P_0.Clear();
			if (array != null)
			{
				object[] array3 = array;
				foreach (object obj in array3)
				{
					DockingWindow dockingWindow3 = obj as DockingWindow;
					if (dockingWindow3 == null || !IsItemItsOwnContainerOverride(obj, P_2))
					{
						dockingWindow3 = GetContainerForItemOverride(P_2);
						dockingWindow3.DataContext = obj;
					}
					else
					{
						dockingWindow3.IsContainerForItem = true;
					}
					PrepareContainerForItemOverride(dockingWindow3, obj, P_2);
					P_0.Add(dockingWindow3);
					dockingWindow3.DockSite = this;
					if (dockingWindow3.IsActive && ActiveWindow != dockingWindow3)
					{
						dockingWindow = dockingWindow3;
					}
				}
			}
		}
		finally
		{
			pmB = false;
		}
		DockingWindow primaryDocument2 = PrimaryDocument;
		if (primaryDocument2 != primaryDocument)
		{
			W1s(primaryDocument2);
		}
		dockingWindow?.Activate();
	}

	private void bNJ()
	{
		INK(pmW, DocumentItemsSource, DockingWindowItemKind.Document);
	}

	private void vNn()
	{
		INK(wmJ, ToolItemsSource, DockingWindowItemKind.Tool);
	}

	private void aNO(IList<DockingWindow> P_0, IList P_1, int P_2, DockingWindowItemKind P_3)
	{
		if (P_1 == null || P_1.Count == 0)
		{
			return;
		}
		foreach (object item in P_1)
		{
			DockingWindow dockingWindow = null;
			if (P_2 >= 0 && P_2 < P_0.Count)
			{
				dockingWindow = P_0[P_2];
				P_0.RemoveAt(P_2);
			}
			if (dockingWindow != null)
			{
				dockingWindow.Destroy();
				ClearContainerForItemOverride(dockingWindow, item, P_3);
			}
		}
	}

	private void BNT(IList<DockingWindow> P_0, IList P_1, IList P_2, int P_3, DockingWindowItemKind P_4)
	{
		if (P_1 == null || P_2 == null || P_1.Count != P_2.Count || P_3 < 0 || P_3 >= P_0.Count)
		{
			return;
		}
		for (int i = 0; i < P_2.Count; i++)
		{
			object item = P_1[i];
			DockingWindow dockingWindow = P_0[P_3 + i];
			dockingWindow.Destroy();
			ClearContainerForItemOverride(dockingWindow, item, P_4);
			item = P_2[i];
			dockingWindow = item as DockingWindow;
			if (dockingWindow == null || !IsItemItsOwnContainerOverride(item, P_4))
			{
				dockingWindow = GetContainerForItemOverride(P_4);
				dockingWindow.DataContext = item;
			}
			else
			{
				dockingWindow.IsContainerForItem = true;
			}
			PrepareContainerForItemOverride(dockingWindow, item, P_4);
			P_0[P_3 + i] = dockingWindow;
			dockingWindow.DockSite = this;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	internal bool rN8(DockingWindow P_0, object P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9202));
		}
		IEnumerable enumerable = null;
		if (!(P_0 is ToolWindow))
		{
			if (P_0 is DocumentWindow)
			{
				enumerable = DocumentItemsSource;
			}
		}
		else
		{
			enumerable = ToolItemsSource;
		}
		if (enumerable == null)
		{
			int num = 0;
			if (!K17())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (enumerable is IList { IsReadOnly: false, IsFixedSize: false } list)
		{
			try
			{
				QmK = P_0;
				list.Add(P_1);
				return true;
			}
			catch
			{
			}
			finally
			{
				QmK = null;
			}
		}
		return false;
	}

	internal bool vND(DockingWindow P_0, object P_1)
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
					if (P_0 == null)
					{
						break;
					}
					if (!pmB)
					{
						IEnumerable enumerable = null;
						if (!(P_0 is ToolWindow))
						{
							if (P_0 is DocumentWindow)
							{
								enumerable = DocumentItemsSource;
							}
						}
						else
						{
							enumerable = ToolItemsSource;
						}
						if (enumerable != null && enumerable is IList { IsReadOnly: false, IsFixedSize: false } list)
						{
							int num3 = list.IndexOf(P_1);
							if (num3 != -1)
							{
								list.RemoveAt(num3);
								return true;
							}
						}
					}
					return false;
				default:
					throw new ArgumentNullException(vVK.ssH(9202));
				}
				num2 = 0;
			}
			while (j1O() == null);
		}
	}

	protected virtual void ClearContainerForItemOverride(DockingWindow container, object item, DockingWindowItemKind kind)
	{
		if (container == null)
		{
			throw new ArgumentNullException(vVK.ssH(9202));
		}
		INk(container);
		container.ContentTemplateSelector = null;
		container.ContentTemplate = null;
		container.Content = item;
	}

	public DocumentWindow ContainerFromDocumentItem(object item)
	{
		if (item != null)
		{
			if (item is DocumentWindow result)
			{
				return result;
			}
			foreach (DocumentWindow documentWindow in DocumentWindows)
			{
				if (documentWindow != null && documentWindow.IsContainerForItem && documentWindow.DataContext == item)
				{
					return documentWindow;
				}
			}
		}
		return null;
	}

	public DockingWindow ContainerFromItem(object item)
	{
		return (DockingWindow)(((object)ContainerFromDocumentItem(item)) ?? ((object)ContainerFromToolItem(item)));
	}

	public ToolWindow ContainerFromToolItem(object item)
	{
		if (item != null)
		{
			if (item is ToolWindow result)
			{
				return result;
			}
			foreach (ToolWindow toolWindow in ToolWindows)
			{
				if (toolWindow != null && toolWindow.IsContainerForItem && toolWindow.DataContext == item)
				{
					return toolWindow;
				}
			}
		}
		return null;
	}

	protected virtual DockingWindow GetContainerForItemOverride(DockingWindowItemKind kind)
	{
		if (kind == DockingWindowItemKind.Document)
		{
			return new DocumentWindow(isContainerForItem: true);
		}
		return new ToolWindow(isContainerForItem: true);
	}

	protected virtual bool IsItemItsOwnContainerOverride(object item, DockingWindowItemKind kind)
	{
		if (kind == DockingWindowItemKind.Document)
		{
			return item is DocumentWindow;
		}
		return item is ToolWindow;
	}

	protected virtual void OnDocumentItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
	{
	}

	protected virtual void OnToolItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
	{
	}

	protected virtual void PrepareContainerForItemOverride(DockingWindow container, object item, DockingWindowItemKind kind)
	{
		if (container == null)
		{
			throw new ArgumentNullException(vVK.ssH(9202));
		}
		if (kind != DockingWindowItemKind.Document)
		{
			container.ContentTemplate = ToolItemTemplate;
			container.ContentTemplateSelector = ToolItemTemplateSelector;
			ApplyContainerStyle(item, container, ToolItemContainerStyleSelector, ToolItemContainerStyle);
		}
		else
		{
			container.ContentTemplate = DocumentItemTemplate;
			container.ContentTemplateSelector = DocumentItemTemplateSelector;
			ApplyContainerStyle(item, container, DocumentItemContainerStyleSelector, DocumentItemContainerStyle);
		}
		container.Content = item;
	}

	internal static ContextMenu pNE(DockHost P_0, Side P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9182));
		}
		List<object> list = new List<object>();
		ToolWindowContainerCollection toolWindowContainerCollection = P_0.a2E(P_1);
		if (toolWindowContainerCollection != null)
		{
			foreach (ToolWindowContainer item2 in toolWindowContainerCollection)
			{
				if (item2 == null || item2.Windows == null)
				{
					continue;
				}
				int num = 0;
				foreach (DockingWindow window in item2.Windows)
				{
					if (window != null)
					{
						string text = vVK.ssH(9294);
						int num2 = ++num;
						MenuItem item = sNx(text + num2 + vVK.ssH(3908), window.ImageSource, window.Title, window.ActivateCommand);
						list.Add(item);
					}
				}
			}
		}
		return BNr(list);
	}

	private static ContextMenu BNr(IEnumerable<object> P_0)
	{
		ContextMenu contextMenu = new ContextMenu();
		if (P_0 != null)
		{
			foreach (FrameworkElement item in P_0)
			{
				contextMenu.Items.Add(item);
			}
		}
		return contextMenu;
	}

	private static MenuItem sNx(string P_0, ImageSource P_1, string P_2, ICommand P_3, object P_4 = null, bool? P_5 = null)
	{
		MenuItem menuItem = new MenuItem();
		if (P_5.HasValue)
		{
			menuItem.IsCheckable = true;
			menuItem.IsChecked = P_5.Value;
		}
		menuItem.Name = P_0;
		menuItem.Command = P_3;
		menuItem.CommandParameter = P_4;
		if (P_2 != null)
		{
			menuItem.Header = P_2.Replace(vVK.ssH(3928), vVK.ssH(3934));
		}
		else
		{
			menuItem.Header = null;
		}
		if (P_1 != null)
		{
			DynamicImage dynamicImage = new DynamicImage();
			dynamicImage.Width = 16.0;
			dynamicImage.Height = 16.0;
			dynamicImage.Stretch = Stretch.Uniform;
			dynamicImage.Source = P_1;
			menuItem.Icon = dynamicImage;
		}
		return menuItem;
	}

	private static Separator gNl()
	{
		return new Separator();
	}

	internal ContextMenu iNM(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9314));
		}
		ToolWindow toolWindow = P_0 as ToolWindow;
		List<object> list = new List<object>();
		list.Add(sNx(vVK.ssH(9344), null, SR.GetString(SRName.UICommandCloseWindowText), P_0.CloseCommand));
		list.Add(sNx(vVK.ssH(9386), null, SR.GetString(SRName.UICommandCloseOthersText), P_0.CloseOthersCommand));
		list.Add(sNx(vVK.ssH(9426), null, SR.GetString(SRName.UICommandCloseAllDocumentsText), CloseAllDocumentsCommand));
		if (toolWindow != null)
		{
			if (list.Count > 0)
			{
				list.Add(gNl());
			}
			list.Add(sNx(vVK.ssH(9480), null, SR.GetString(SRName.UICommandMakeFloatingWindowText), toolWindow.FloatCommand));
			list.Add(sNx(vVK.ssH(9536), null, SR.GetString(SRName.UICommandMakeDockedWindowText), toolWindow.DockCommand));
		}
		return BNr(list);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal ContextMenu INv(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9314));
		}
		ToolWindow toolWindow = P_0 as ToolWindow;
		bool flag = toolWindow != null;
		if (P_0.MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			tabbedMdiContainer.hWg();
		}
		DockHost dockHost = P_0.DockHost;
		List<object> list = new List<object>();
		list.Add(sNx(vVK.ssH(9344), null, SR.GetString(SRName.UICommandCloseWindowText), P_0.CloseCommand));
		list.Add(sNx(vVK.ssH(9588), null, SR.GetString(SRName.UICommandCloseOthersText), P_0.CloseOthersCommand));
		list.Add(sNx(vVK.ssH(9630), null, SR.GetString(SRName.UICommandCloseAllInContainerText), P_0.CloseAllInContainerCommand));
		list.Add(sNx(vVK.ssH(9426), null, SR.GetString(SRName.UICommandCloseAllDocumentsText), CloseAllDocumentsCommand));
		bool flag2 = P_0.FloatCommand.CanExecute(null) || (flag && CanToolWindowsFloat) || (!flag && CanDocumentWindowsFloat);
		if (flag2)
		{
			if (list.Count > 0)
			{
				list.Add(gNl());
			}
			list.Add(sNx(vVK.ssH(9480), null, SR.GetString(SRName.UICommandMakeFloatingWindowText), P_0.FloatCommand));
		}
		if (flag)
		{
			if (!flag2 && list.Count > 0)
			{
				list.Add(gNl());
			}
			list.Add(sNx(vVK.ssH(9536), null, SR.GetString(SRName.UICommandMakeDockedWindowText), toolWindow.DockCommand));
			if (dockHost != null && dockHost.Meg())
			{
				if (!flag2 && list.Count > 0)
				{
					list.Add(gNl());
				}
				list.Add(sNx(vVK.ssH(9688), null, SR.GetString(SRName.UICommandMakeDocumentWindowText), P_0.MoveToMdiCommand, PrimaryDockHost));
			}
		}
		if (list.Count > 0)
		{
			list.Add(gNl());
		}
		list.Add(sNx(vVK.ssH(9744), null, SR.GetString(SRName.UICommandPinTabText), P_0.SetTabbedMdiLayoutKindCommand, (P_0.TabbedMdiLayoutKind != TabLayoutKind.Pinned) ? TabLayoutKind.Pinned : TabLayoutKind.Normal, P_0.TabbedMdiLayoutKind == TabLayoutKind.Pinned));
		if (P_0.TabbedMdiLayoutKind == TabLayoutKind.Preview)
		{
			list.Add(sNx(vVK.ssH(9776), null, SR.GetString(SRName.UICommandKeepTabOpenText), P_0.SetTabbedMdiLayoutKindCommand, TabLayoutKind.Normal));
		}
		bool canMoveToNewHorizontalContainer = P_0.CanMoveToNewHorizontalContainer;
		bool canMoveToNewVerticalContainer = P_0.CanMoveToNewVerticalContainer;
		bool canMoveToPreviousContainer = P_0.CanMoveToPreviousContainer;
		bool canMoveToNextContainer = P_0.CanMoveToNextContainer;
		bool flag3 = P_0.DockHost != null && P_0.DockHost.Meg() && PrimaryDockHost != null;
		if ((canMoveToNewHorizontalContainer || canMoveToNewVerticalContainer || canMoveToPreviousContainer || canMoveToNextContainer || flag3) && list.Count > 0)
		{
			list.Add(gNl());
		}
		if (canMoveToNewHorizontalContainer)
		{
			list.Add(sNx(vVK.ssH(9818), null, SR.GetString(SRName.UICommandMoveToNewHorizontalContainerText), P_0.MoveToNewHorizontalContainerCommand));
		}
		if (canMoveToNewVerticalContainer)
		{
			list.Add(sNx(vVK.ssH(9894), null, SR.GetString(SRName.UICommandMoveToNewVerticalContainerText), P_0.MoveToNewVerticalContainerCommand));
		}
		if (canMoveToPreviousContainer)
		{
			list.Add(sNx(vVK.ssH(9966), null, SR.GetString(SRName.UICommandMoveToPreviousContainerText), P_0.MoveToPreviousContainerCommand));
		}
		if (canMoveToNextContainer)
		{
			list.Add(sNx(vVK.ssH(10032), null, SR.GetString(SRName.UICommandMoveToNextContainerText), P_0.MoveToNextContainerCommand));
		}
		if (flag3)
		{
			list.Add(sNx(vVK.ssH(10090), null, SR.GetString(SRName.UICommandMoveToPrimaryMdiHostText), P_0.MoveToPrimaryMdiHostCommand));
		}
		return BNr(list);
	}

	internal static ContextMenu nN7(ToolWindowContainer P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10150));
		}
		DockingWindow selectedWindow = P_0.SelectedWindow;
		if (selectedWindow != null && P_0.Windows.Count > 0)
		{
			int num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				DockSite dockSite = selectedWindow.DockSite;
				bool num3 = dockSite != null && dockSite.MdiKind != MdiKind.None;
				List<object> list = new List<object>
				{
					sNx(vVK.ssH(9480), null, SR.GetString(SRName.UICommandMakeFloatingWindowText), selectedWindow.FloatCommand),
					sNx(vVK.ssH(9536), null, SR.GetString(SRName.UICommandMakeDockedWindowText), P_0.DockCommand)
				};
				if (num3)
				{
					list.Add(sNx(vVK.ssH(9688), null, SR.GetString(SRName.UICommandMakeDocumentWindowText), selectedWindow.MoveToMdiCommand));
				}
				list.Add(sNx(vVK.ssH(10192), null, SR.GetString(SRName.UICommandToggleWindowAutoHideStateText), P_0.AutoHideCommand));
				MenuItem menuItem = sNx(vVK.ssH(9344), null, SR.GetString(SRName.UICommandCloseWindowText), P_0.CloseCommand);
				menuItem.InputGestureText = vVK.ssH(10262);
				list.Add(menuItem);
				return BNr(list);
			}
			}
		}
		return null;
	}

	internal static ContextMenu TNR(ToolWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(10284));
		}
		DockSite dockSite = P_0.DockSite;
		bool num = dockSite != null && dockSite.MdiKind != MdiKind.None;
		List<object> list = new List<object>
		{
			sNx(vVK.ssH(9480), null, SR.GetString(SRName.UICommandMakeFloatingWindowText), P_0.FloatCommand),
			sNx(vVK.ssH(9536), null, SR.GetString(SRName.UICommandMakeDockedWindowText), P_0.DockCommand)
		};
		if (num)
		{
			list.Add(sNx(vVK.ssH(9688), null, SR.GetString(SRName.UICommandMakeDocumentWindowText), P_0.MoveToMdiCommand));
		}
		list.Add(sNx(vVK.ssH(10192), null, SR.GetString(SRName.UICommandToggleWindowAutoHideStateText), P_0.AutoHideCommand));
		MenuItem menuItem = sNx(vVK.ssH(9344), null, SR.GetString(SRName.UICommandCloseWindowText), P_0.CloseCommand);
		menuItem.InputGestureText = vVK.ssH(10262);
		list.Add(menuItem);
		return BNr(list);
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		return DockingWindowState.Docked;
	}

	public string ToHierarchyString()
	{
		return pL.mx7(this);
	}

	public void DockSiteRegistryConstructor()
	{
		fmn.CollectionChanged += GNZ;
		Omv.CollectionChanged += DNb;
		mmE = new DockingWindowCollection();
		mmD = new ReadOnlyDockingWindowCollection(mmE);
		amM = new ReadOnlyObservableCollection<DockHost>(OmO);
	}

	internal void oNS(XmlDockingWindow P_0)
	{
		if (ImT == null)
		{
			ImT = new List<XmlDockingWindow>();
		}
		ImT.Add(P_0);
	}

	[SpecialName]
	internal IEnumerable<DockHost> eQY()
	{
		if (kmx != null)
		{
			return OmO.Union(new DockHost[1] { kmx });
		}
		return OmO;
	}

	[SpecialName]
	internal IEnumerable<DockingWindow> lQs()
	{
		if (fmn.Count == 0)
		{
			return Omv;
		}
		if (Omv.Count == 0)
		{
			return fmn;
		}
		return fmn.OfType<DockingWindow>().Union(Omv);
	}

	[SpecialName]
	internal IEnumerable<DockHost> OQF()
	{
		int num;
		using (IEnumerator<DockHost> enumerator = eQY().GetEnumerator())
		{
			goto IL_0209;
			IL_0209:
			if (enumerator.MoveNext())
			{
				yield return enumerator.Current;
				num = 3;
				if (_003Cget_AllLinkedDockHosts_003Ed__645.tGs() != null)
				{
					goto IL_000e;
				}
				goto IL_0012;
			}
		}
		num = 0;
		if (!_003Cget_AllLinkedDockHosts_003Ed__645.zGX())
		{
			goto IL_000e;
		}
		goto IL_0012;
		IL_0012:
		IEnumerator<DockSite> enumerator2 = default(IEnumerator<DockSite>);
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				LinkedDockSites.GetEnumerator();
				goto IL_0088;
			case 3:
				goto end_IL_0012;
			case 2:
				yield break;
			}
			try
			{
				goto IL_0088;
				IL_0088:
				if (!enumerator2.MoveNext())
				{
					num = 2;
					continue;
				}
				DockSite current = enumerator2.Current;
				using IEnumerator<DockHost> enumerator = current.eQY().GetEnumerator();
				while (enumerator.MoveNext())
				{
					yield return enumerator.Current;
				}
				num = 1;
				if (!_003Cget_AllLinkedDockHosts_003Ed__645.zGX())
				{
					goto IL_000e;
				}
			}
			finally
			{
				enumerator2?.Dispose();
			}
			continue;
			end_IL_0012:
			break;
		}
		goto IL_0209;
		IL_000e:
		int num2 = default(int);
		num = num2;
		goto IL_0012;
	}

	[SpecialName]
	internal IEnumerable<DockingWindow> jQP()
	{
		return from w in lQs()
			where w.QkM() == DockingWindowState.Document && w.IsCurrentlyOpen
			select w;
	}

	internal void ONL(DockingWindow P_0)
	{
		XmlDockingWindow xmlDockingWindow = NNP(P_0);
		if (xmlDockingWindow != null)
		{
			xmlDockingWindow.Deserialize(P_0);
			ImT.Remove(xmlDockingWindow);
		}
	}

	private void dN3()
	{
		jJ jJ = cQ4();
		foreach (DockHost item in OmO)
		{
			item?.JeS(jJ?.CloneForFloatingDockHost());
		}
	}

	internal void fN6()
	{
		if (!em7)
		{
			return;
		}
		jJ jJ = null;
		int num = 0;
		if (!K17())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (Bml != null)
		{
			if (!Bml.IsAlive)
			{
				Bml = null;
			}
			else
			{
				jJ = Bml.Target as jJ;
			}
		}
		jJ jJ2 = cQ4();
		if (jJ != jJ2)
		{
			MdiKind = jJ2?.Kind ?? MdiKind.None;
			Bml = ((jJ2 != null) ? new WeakReference(jJ2) : null);
			BNj();
			dN3();
			w1p();
		}
	}

	private void wN9()
	{
		if (Vm8 == null)
		{
			return;
		}
		for (int num = Vm8.Count - 1; num >= 0; num--)
		{
			if (!Vm8[num].IsAlive || Vm8[num].Target == null)
			{
				Vm8.RemoveAt(num);
			}
		}
	}

	internal void kNY()
	{
		if (ImT != null)
		{
			ImT = null;
		}
	}

	internal void vNp(DockingWindow P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		if (P_1 && CanUpdateItemsSourceOnUnregister)
		{
			bool value = P_0.UkL();
			P_0.mk3(value: true);
			try
			{
				if (rN8(P_0, P_0.DataContext))
				{
					P_0.IsContainerForItem = true;
				}
			}
			finally
			{
				P_0.mk3(value);
			}
		}
		if (P_0 is ToolWindow item)
		{
			if (!Omv.Contains(item))
			{
				Omv.Add(item);
			}
		}
		else if (P_0 is DocumentWindow item2 && !fmn.Contains(item2))
		{
			fmn.Add(item2);
		}
		m1U(P_0);
		yNB(P_0);
	}

	internal bool yNs(DockingWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(9098));
		}
		bool flag = false;
		int num;
		if (!(P_0 is ToolWindow item))
		{
			if (P_0 is DocumentWindow item2 && fmn.Contains(item2))
			{
				flag = true;
				fmn.Remove(item2);
				m1X(P_0);
			}
		}
		else if (Omv.Contains(item))
		{
			flag = true;
			Omv.Remove(item);
			m1X(P_0);
			num = 0;
			if (j1O() == null)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_001b:
		if (!flag || !P_0.IsContainerForItem)
		{
			return false;
		}
		P_0.IsContainerForItem = false;
		if (CanUpdateItemsSourceOnUnregister)
		{
			vND(P_0, P_0.DataContext);
			num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0009;
		}
		goto IL_00fd;
		IL_00fd:
		return true;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00fd;
		}
		goto IL_001b;
	}

	private void rNq()
	{
		if (!Tmr)
		{
			yNH();
		}
	}

	internal DockingWindow KNF(Guid P_0)
	{
		return (DockingWindow)(((object)Omv[P_0]) ?? ((object)fmn[P_0]));
	}

	internal IEnumerable<DockHost> ENV()
	{
		return FloatingDockHosts.OrderBy((DockHost dh) => dh.MeM());
	}

	private XmlDockingWindow NNP(DockingWindow P_0)
	{
		if (ImT != null && ImT.Count > 0 && P_0 != null)
		{
			int num2 = default(int);
			for (int i = 0; i < ImT.Count; i++)
			{
				XmlDockingWindow xmlDockingWindow = ImT[i];
				if (xmlDockingWindow == null || ((string.IsNullOrEmpty(xmlDockingWindow.SerializationId) || !(P_0.SerializationId == xmlDockingWindow.SerializationId)) && (string.IsNullOrEmpty(xmlDockingWindow.Name) || !(P_0.Name == xmlDockingWindow.Name))))
				{
					continue;
				}
				if (P_0 is DocumentWindow)
				{
					int num = 0;
					if (!K17())
					{
						num = num2;
					}
					switch (num)
					{
					}
					if (xmlDockingWindow is XmlDocumentWindow)
					{
						goto IL_012b;
					}
				}
				if (!(P_0 is ToolWindow) || !(xmlDockingWindow is XmlToolWindow))
				{
					continue;
				}
				goto IL_012b;
				IL_012b:
				return xmlDockingWindow;
			}
		}
		return null;
	}

	internal IEnumerable<hR> tNf<hR>() where hR : XmlDockingWindow
	{
		if (ImT == null)
		{
			yield break;
		}
		hR val = default(hR);
		int num;
		using (List<XmlDockingWindow>.Enumerator enumerator = ImT.GetEnumerator())
		{
			goto IL_00ea;
			IL_00ea:
			if (enumerator.MoveNext())
			{
				val = enumerator.Current as hR;
				num = 1;
				if (_003CGetAllUnusedLazyLayoutData_003Ed__659<hR>.VGN() != null)
				{
					goto IL_0016;
				}
				goto IL_001a;
			}
		}
		num = 0;
		if (_003CGetAllUnusedLazyLayoutData_003Ed__659<hR>.VGN() != null)
		{
			goto IL_0016;
		}
		goto IL_001a;
		IL_0016:
		int num2 = default(int);
		num = num2;
		goto IL_001a;
		IL_001a:
		switch (num)
		{
		default:
			yield break;
		case 1:
			if (val != null)
			{
				yield return val;
			}
			break;
		}
		goto IL_00ea;
	}

	internal bool vNU(Guid P_0, bool P_1)
	{
		if (ImT != null && ImT.Count > 0)
		{
			int num2 = default(int);
			for (int i = 0; i < ImT.Count; i++)
			{
				XmlDockingWindow xmlDockingWindow = ImT[i];
				if (xmlDockingWindow == null || !(xmlDockingWindow.UniqueId == P_0))
				{
					continue;
				}
				if (P_1)
				{
					if (!(xmlDockingWindow is XmlToolWindow))
					{
						break;
					}
					int num = 0;
					if (j1O() != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
				}
				return true;
			}
		}
		return false;
	}

	internal void jNc()
	{
		Tmr = false;
		Yp.gRf<object>(this, delegate
		{
			rNq();
		}, null);
	}

	internal bool qN4(DockSite P_0)
	{
		_003C_003Ec__DisplayClass662_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass662_0();
		CS_0024_003C_003E8__locals2.AL4 = P_0;
		if (Vm8 != null)
		{
			return Vm8.Any((WeakReference r) => r.Target == CS_0024_003C_003E8__locals2.AL4);
		}
		return false;
	}

	[SpecialName]
	internal DockHost kQU()
	{
		return (from d in eQY()
			where d.IsOpen
			orderby d.MeM() descending
			select d).FirstOrDefault() ?? PrimaryDockHost;
	}

	internal void BNj()
	{
		foreach (DockingWindow item in lQs())
		{
			item?.wI7();
		}
	}

	private void GNZ(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		vNA(P_1);
	}

	private void DNb(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		vNA(P_1);
	}

	[SpecialName]
	internal jJ cQ4()
	{
		if (kmx == null)
		{
			return null;
		}
		return kmx.veR();
	}

	[SpecialName]
	private void HQj(jJ value)
	{
		if (kmx != null)
		{
			kmx.JeS(value);
		}
	}

	private void vNA(NotifyCollectionChangedEventArgs P_0)
	{
		sNh();
		switch (P_0.Action)
		{
		case NotifyCollectionChangedAction.Add:
		{
			IEnumerable<DockingWindow> enumerable2 = P_0.NewItems.OfType<DockingWindow>();
			if (enumerable2 == null)
			{
				break;
			}
			{
				foreach (DockingWindow item in enumerable2)
				{
					if (item != null && item.DockSite != this)
					{
						if (item.DockSite != null)
						{
							throw new InvalidOperationException(SR.GetString(SRName.ExDockSiteDockingWindowAlreadyRegistered, item.Title));
						}
						item.DockSite = this;
					}
				}
				break;
			}
		}
		case NotifyCollectionChangedAction.Replace:
			if (!DesignerProperties.GetIsInDesignMode(this))
			{
				throw new NotSupportedException();
			}
			break;
		default:
		{
			int num = 0;
			if (j1O() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
			break;
		}
		case NotifyCollectionChangedAction.Move:
			break;
		case NotifyCollectionChangedAction.Reset:
			if (DesignerProperties.GetIsInDesignMode(this))
			{
				break;
			}
			throw new NotSupportedException();
		case NotifyCollectionChangedAction.Remove:
		{
			IEnumerable<DockingWindow> enumerable = P_0.OldItems.OfType<DockingWindow>();
			if (enumerable == null)
			{
				break;
			}
			{
				foreach (DockingWindow item2 in enumerable)
				{
					if (item2 != null && item2.DockSite == this)
					{
						item2.Destroy();
					}
				}
				break;
			}
		}
		}
	}

	internal void yNH()
	{
		mmE.BeginUpdate();
		try
		{
			mmE.Clear();
			foreach (DockHost item in eQY())
			{
				if (item == null)
				{
					continue;
				}
				jJ jJ = item.veR();
				if (jJ != null)
				{
					IList<DockingWindow> documents = jJ.GetDocuments();
					if (documents != null)
					{
						mmE.AddRange(documents);
					}
				}
			}
			Tmr = true;
		}
		finally
		{
			mmE.EndUpdate();
		}
		m1v();
	}

	private void FN0()
	{
		foreach (DockHost item in OmO)
		{
			if (item == null)
			{
				continue;
			}
			item.o24();
			IList<b4<ToolWindowContainer>> list = pL.Mxl<ToolWindowContainer>(item, null);
			if (list == null)
			{
				continue;
			}
			foreach (b4<ToolWindowContainer> item2 in list)
			{
				item2.dx3().CDs();
			}
		}
	}

	private void sNh()
	{
		Dictionary<Guid, bool> dictionary = new Dictionary<Guid, bool>();
		foreach (ToolWindow item in Omv)
		{
			if (dictionary.ContainsKey(item.UniqueId))
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExDockSiteRegistryAlreadyContainsDockingWindow, item.UniqueId));
			}
			dictionary[item.UniqueId] = true;
		}
		foreach (DocumentWindow item2 in fmn)
		{
			if (dictionary.ContainsKey(item2.UniqueId))
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExDockSiteRegistryAlreadyContainsDockingWindow, item2.UniqueId));
			}
			dictionary[item2.UniqueId] = true;
		}
	}

	public void LinkDockSite(DockSite dockSite)
	{
		_003C_003Ec__DisplayClass683_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass683_0();
		CS_0024_003C_003E8__locals6.JLZ = dockSite;
		if (CS_0024_003C_003E8__locals6.JLZ == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		wN9();
		if (CS_0024_003C_003E8__locals6.JLZ == this)
		{
			return;
		}
		if (Vm8 != null)
		{
			if (Vm8.Any((WeakReference r) => r.Target == CS_0024_003C_003E8__locals6.JLZ))
			{
				return;
			}
		}
		else
		{
			Vm8 = new List<WeakReference>();
		}
		Vm8.Add(new WeakReference(CS_0024_003C_003E8__locals6.JLZ));
		CS_0024_003C_003E8__locals6.JLZ.LinkDockSite(this);
	}

	public void UnlinkDockSite(DockSite dockSite)
	{
		if (dockSite == null)
		{
			throw new ArgumentNullException(vVK.ssH(10308));
		}
		if (Vm8 == null)
		{
			return;
		}
		wN9();
		int num = Vm8.Count - 1;
		int num3 = default(int);
		while (num >= 0)
		{
			if (Vm8[num].Target != dockSite)
			{
				num--;
				int num2 = 0;
				if (!K17())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				continue;
			}
			Vm8.RemoveAt(num);
			dockSite.UnlinkDockSite(this);
			break;
		}
		if (Vm8 != null && Vm8.Count == 0)
		{
			Vm8 = null;
		}
	}

	internal void xNg(FrameworkElement P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		if (P_1)
		{
			if (P_0.Parent == null && VisualTreeHelper.GetParent(P_0) == null)
			{
				AddLogicalChild(P_0);
			}
		}
		else if (P_0.Parent == this)
		{
			RemoveLogicalChild(P_0);
		}
	}

	private void BNX(bool P_0)
	{
		if (!P_0)
		{
			base.Dispatcher.BeginInvoke(DispatcherPriority.Render, (Action)delegate
			{
				if (!base.IsVisible && CanFloatingDockHostsHideOnDockSiteUnload && !qQv())
				{
					foreach (DockHost item in OmO)
					{
						item?.m2q();
					}
				}
			});
			return;
		}
		base.Dispatcher.BeginInvoke(DispatcherPriority.Render, (Action)delegate
		{
			if (!base.IsVisible)
			{
				return;
			}
			foreach (DockHost item2 in OmO)
			{
				if (item2 != null && !item2.Re5() && item2.Child is wH { ContainsDockingWindows: not false })
				{
					item2.o2F(_0020: false);
				}
			}
		});
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		if (e != null && !e.Handled && e.NewFocus == this)
		{
			DockingWindow primaryDocument = PrimaryDocument;
			if (primaryDocument != null && primaryDocument.DockHost == kmx)
			{
				primaryDocument.Activate();
			}
		}
	}

	protected override void OnInitialized(EventArgs e)
	{
		base.OnInitialized(e);
		if (qmR || !base.IsInitialized)
		{
			return;
		}
		qmR = true;
		DockingWindow[] array = lQs().ToArray();
		int num2 = default(int);
		for (int i = 0; i < array.Length; i++)
		{
			int num = 0;
			if (j1O() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			DockingWindow dockingWindow = array[i];
			yNB(dockingWindow);
		}
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	{
		if (e.Property == Control.TemplateProperty)
		{
			em7 = false;
			try
			{
				base.OnPropertyChanged(e);
			}
			finally
			{
				em7 = true;
			}
		}
		else
		{
			base.OnPropertyChanged(e);
		}
		if (e.Property == UIElement.IsVisibleProperty)
		{
			BNX((bool)e.NewValue);
		}
	}

	static DockSite()
	{
		IVH.CecNqz();
		HostedFloatingWindowContainerProperty = DependencyProperty.Register(vVK.ssH(10328), typeof(FrameworkElement), typeof(DockSite), new PropertyMetadata(null));
		InactiveFloatingWindowFadeDelayProperty = DependencyProperty.Register(vVK.ssH(10390), typeof(double), typeof(DockSite), new PropertyMetadata(20000.0));
		InactiveFloatingWindowFadeDurationProperty = DependencyProperty.Register(vVK.ssH(10456), typeof(double), typeof(DockSite), new PropertyMetadata(20000.0));
		InactiveFloatingWindowFadeOpacityProperty = DependencyProperty.Register(vVK.ssH(10528), typeof(double), typeof(DockSite), new PropertyMetadata(0.25, DCy));
		IsInactiveFloatingWindowFadeEnabledProperty = DependencyProperty.Register(vVK.ssH(10598), typeof(bool), typeof(DockSite), new PropertyMetadata(true, DCy));
		AutoHidePerContainerProperty = DependencyProperty.Register(vVK.ssH(10672), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		AutoHidePopupCloseAnimationDurationProperty = DependencyProperty.Register(vVK.ssH(10716), typeof(double), typeof(DockSite), new PropertyMetadata(150.0));
		AutoHidePopupCloseDelayProperty = DependencyProperty.Register(vVK.ssH(10790), typeof(double), typeof(DockSite), new PropertyMetadata(500.0));
		AutoHidePopupClosesOnLostFocusProperty = DependencyProperty.Register(vVK.ssH(10840), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		AutoHidePopupOpenAnimationDurationProperty = DependencyProperty.Register(vVK.ssH(10904), typeof(double), typeof(DockSite), new PropertyMetadata(150.0));
		AutoHidePopupOpenDelayProperty = DependencyProperty.Register(vVK.ssH(10976), typeof(double), typeof(DockSite), new PropertyMetadata(200.0));
		AutoHidePopupOpensOnMouseHoverProperty = DependencyProperty.Register(vVK.ssH(11024), typeof(bool), typeof(DockSite), new PropertyMetadata(false));
		AutoHideTabItemTemplateProperty = DependencyProperty.Register(vVK.ssH(6764), typeof(DataTemplate), typeof(DockSite), new PropertyMetadata(null));
		AutoHideTabItemTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(6814), typeof(DataTemplateSelector), typeof(DockSite), new PropertyMetadata(null));
		CanToolWindowsAutoHideProperty = DependencyProperty.Register(vVK.ssH(11088), typeof(bool), typeof(DockSite), new PropertyMetadata(true, x1d));
		ActiveWindowProperty = DependencyProperty.Register(vVK.ssH(11136), typeof(DockingWindow), typeof(DockSite), new PropertyMetadata(null, f1e));
		AreDocumentWindowsDestroyedOnCloseProperty = DependencyProperty.Register(vVK.ssH(11164), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		AreNewTabsInsertedBeforeExistingTabsProperty = DependencyProperty.Register(vVK.ssH(11236), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		CanDocumentWindowsCloseProperty = DependencyProperty.Register(vVK.ssH(11312), typeof(bool), typeof(DockSite), new PropertyMetadata(true, g1G));
		CanDocumentWindowsDragToLinkedDockSitesProperty = DependencyProperty.Register(vVK.ssH(11362), typeof(bool), typeof(DockSite), new PropertyMetadata(true, q1I));
		CanDocumentWindowsFloatProperty = DependencyProperty.Register(vVK.ssH(11444), typeof(bool), typeof(DockSite), new PropertyMetadata(false, j1k));
		CanFloatingDockHostsHideOnDockSiteUnloadProperty = DependencyProperty.Register(vVK.ssH(11494), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		CanToolWindowsAttachProperty = DependencyProperty.Register(vVK.ssH(11578), typeof(bool), typeof(DockSite), new PropertyMetadata(true, r1C));
		CanToolWindowsBecomeDocumentsProperty = DependencyProperty.Register(vVK.ssH(11622), typeof(bool), typeof(DockSite), new PropertyMetadata(true, G11));
		CanToolWindowsCloseProperty = DependencyProperty.Register(vVK.ssH(11684), typeof(bool), typeof(DockSite), new PropertyMetadata(true, q1N));
		CanToolWindowsCloseOnMiddleClickProperty = DependencyProperty.Register(vVK.ssH(11726), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		CanToolWindowsDockProperty = DependencyProperty.Register(vVK.ssH(11794), typeof(bool), typeof(DockSite), new PropertyMetadata(true, p1Q));
		CanToolWindowsDragToFloatingDockHostsWithWorkspacesProperty = DependencyProperty.Register(vVK.ssH(11834), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		CanToolWindowsDragToLinkedDockSitesProperty = DependencyProperty.Register(vVK.ssH(11940), typeof(bool), typeof(DockSite), new PropertyMetadata(true, Q1m));
		CanToolWindowsFloatProperty = DependencyProperty.Register(vVK.ssH(12014), typeof(bool), typeof(DockSite), new PropertyMetadata(true, E1a));
		CanToolWindowTabsDragProperty = DependencyProperty.Register(vVK.ssH(12056), typeof(bool), typeof(DockSite), new PropertyMetadata(true, i1W));
		ChildProperty = DependencyProperty.Register(vVK.ssH(7292), typeof(FrameworkElement), typeof(DockSite), new PropertyMetadata(null, W1B));
		ClosePerContainerProperty = DependencyProperty.Register(vVK.ssH(12102), typeof(bool), typeof(DockSite), new PropertyMetadata(false));
		FloatingToolWindowContainersHaveMaximizeButtonsProperty = DependencyProperty.Register(vVK.ssH(12140), typeof(bool), typeof(DockSite), new PropertyMetadata(true, E1K));
		FloatingToolWindowContainersHaveMinimizeButtonsProperty = DependencyProperty.Register(vVK.ssH(12238), typeof(bool), typeof(DockSite), new PropertyMetadata(false, p1J));
		FloatingWindowIconProperty = DependencyProperty.Register(vVK.ssH(12336), typeof(ImageSource), typeof(DockSite), new PropertyMetadata(null, i1n));
		FloatingWindowShowInTaskBarModeProperty = DependencyProperty.Register(vVK.ssH(12376), typeof(FloatingWindowShowInTaskBarMode), typeof(DockSite), new PropertyMetadata(FloatingWindowShowInTaskBarMode.Default));
		FloatingWindowSnapToScreenThresholdProperty = DependencyProperty.Register(vVK.ssH(12442), typeof(double), typeof(DockSite), new PropertyMetadata(70.0));
		FloatingWindowTitleProperty = DependencyProperty.Register(vVK.ssH(12516), typeof(string), typeof(DockSite), new PropertyMetadata(string.Empty, i1n));
		IsDockGuideAnimationEnabledProperty = DependencyProperty.Register(vVK.ssH(12558), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		IsFloatingWindowSnapToScreenEnabledProperty = DependencyProperty.Register(vVK.ssH(12616), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		IsLiveSplittingEnabledProperty = DependencyProperty.Register(vVK.ssH(12690), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		IsTabLayoutAnimationEnabledProperty = DependencyProperty.Register(vVK.ssH(12738), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		MagnetismGapDistanceProperty = DependencyProperty.Register(vVK.ssH(12796), typeof(double), typeof(DockSite), new PropertyMetadata(1.0));
		MagnetismSnapDistanceProperty = DependencyProperty.Register(vVK.ssH(12840), typeof(double), typeof(DockSite), new PropertyMetadata(5.0));
		MdiKindProperty = DependencyProperty.Register(vVK.ssH(12886), typeof(MdiKind), typeof(DockSite), new PropertyMetadata(MdiKind.None, y1T));
		PrimaryDocumentProperty = DependencyProperty.Register(vVK.ssH(12904), typeof(DockingWindow), typeof(DockSite), new PropertyMetadata(null, b18));
		SplitterSizeProperty = DependencyProperty.Register(vVK.ssH(6880), typeof(double), typeof(DockSite), new PropertyMetadata(5.0));
		SwitcherProperty = DependencyProperty.Register(vVK.ssH(12938), typeof(SwitcherBase), typeof(DockSite), new PropertyMetadata(null, s1D));
		ToolWindowsHaveCloseButtonsProperty = DependencyProperty.Register(vVK.ssH(12958), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		ToolWindowsHaveOptionsButtonsProperty = DependencyProperty.Register(vVK.ssH(13016), typeof(bool), typeof(DockSite), new PropertyMetadata(true, c1E));
		ToolWindowsHaveTabImagesProperty = DependencyProperty.Register(vVK.ssH(13078), typeof(bool), typeof(DockSite), new PropertyMetadata(false, r1r));
		ToolWindowsHaveTitleBarIconsProperty = DependencyProperty.Register(vVK.ssH(13130), typeof(bool), typeof(DockSite), new PropertyMetadata(false));
		ToolWindowsHaveTitleBarsProperty = DependencyProperty.Register(vVK.ssH(13190), typeof(bool), typeof(DockSite), new PropertyMetadata(true, l1x));
		ToolWindowsHaveToggleAutoHideButtonsProperty = DependencyProperty.Register(vVK.ssH(13242), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		ToolWindowsSingleTabLayoutBehaviorProperty = DependencyProperty.Register(vVK.ssH(13318), typeof(SingleTabLayoutBehavior), typeof(DockSite), new PropertyMetadata(SingleTabLayoutBehavior.Hide));
		ToolWindowsTabOverflowBehaviorProperty = DependencyProperty.Register(vVK.ssH(13390), typeof(TabOverflowBehavior), typeof(DockSite), new PropertyMetadata(TabOverflowBehavior.Shrink));
		ToolWindowsTabStripPlacementProperty = DependencyProperty.Register(vVK.ssH(13454), typeof(Side), typeof(DockSite), new PropertyMetadata(Side.Bottom));
		ToolWindowsTitleBarContextContentAlignmentProperty = DependencyProperty.Register(vVK.ssH(13514), typeof(ContextContentAlignment), typeof(DockSite), new PropertyMetadata(ContextContentAlignment.Far));
		ToolWindowTabItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(13602), typeof(Style), typeof(DockSite), new PropertyMetadata(null));
		UseDragFloatPreviewsProperty = DependencyProperty.Register(vVK.ssH(13668), typeof(bool), typeof(DockSite), new PropertyMetadata(false));
		UseHostedFloatingWindowsProperty = DependencyProperty.Register(vVK.ssH(13712), typeof(bool), typeof(DockSite), new PropertyMetadata(false, U1l));
		UseHostedPopupsProperty = DependencyProperty.Register(vVK.ssH(13764), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		FloatingWindowOpeningEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13798), RoutingStrategy.Bubble, typeof(EventHandler<FloatingWindowOpeningEventArgs>), typeof(DockSite));
		MdiKindChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13844), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DockSite));
		MenuOpeningEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13876), RoutingStrategy.Bubble, typeof(EventHandler<DockingMenuEventArgs>), typeof(DockSite));
		NewWindowRequestedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13902), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DockSite));
		PrimaryDocumentChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13942), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowActivatedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(13990), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowAutoHidePopupClosedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14024), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowAutoHidePopupOpenedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14078), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowDeactivatedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14132), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowDefaultLocationRequestedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14170), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowDefaultLocationEventArgs>), typeof(DockSite));
		WindowRegisteredEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14234), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		WindowsAutoHidingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14270), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsAutoHidingEventArgs>), typeof(DockSite));
		WindowsClosedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14308), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsClosingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14338), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsDockHostChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14370), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsDraggedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14418), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsDraggingEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14450), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsDragOverEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14484), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsDragOverEventArgs>), typeof(DockSite));
		WindowsOpenedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14518), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsOpeningEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14548), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowsStateChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14580), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowsEventArgs>), typeof(DockSite));
		WindowUnregisteredEvent = EventManager.RegisterRoutedEvent(vVK.ssH(14622), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(DockSite));
		CanUpdateItemsSourceOnUnregisterProperty = DependencyProperty.Register(vVK.ssH(14662), typeof(bool), typeof(DockSite), new PropertyMetadata(true));
		DocumentItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(14730), typeof(Style), typeof(DockSite), new PropertyMetadata(null, cN1));
		DocumentItemContainerStyleSelectorProperty = DependencyProperty.Register(vVK.ssH(14786), typeof(StyleSelector), typeof(DockSite), new PropertyMetadata(null, cN1));
		DocumentItemsSourceProperty = DependencyProperty.Register(vVK.ssH(14858), typeof(IEnumerable), typeof(DockSite), new PropertyMetadata(null, rNQ));
		DocumentItemTemplateProperty = DependencyProperty.Register(vVK.ssH(14900), typeof(DataTemplate), typeof(DockSite), new PropertyMetadata(null, cN1));
		DocumentItemTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(14944), typeof(DataTemplateSelector), typeof(DockSite), new PropertyMetadata(null, cN1));
		ToolItemContainerStyleProperty = DependencyProperty.Register(vVK.ssH(15004), typeof(Style), typeof(DockSite), new PropertyMetadata(null, CNm));
		ToolItemContainerStyleSelectorProperty = DependencyProperty.Register(vVK.ssH(15052), typeof(StyleSelector), typeof(DockSite), new PropertyMetadata(null, CNm));
		ToolItemsSourceProperty = DependencyProperty.Register(vVK.ssH(15116), typeof(IEnumerable), typeof(DockSite), new PropertyMetadata(null, GNW));
		ToolItemTemplateProperty = DependencyProperty.Register(vVK.ssH(15150), typeof(DataTemplate), typeof(DockSite), new PropertyMetadata(null, CNm));
		ToolItemTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(15186), typeof(DataTemplateSelector), typeof(DockSite), new PropertyMetadata(null, CNm));
	}

	[CompilerGenerated]
	private void WN5(object P_0)
	{
		ActivateNextDocument();
	}

	[CompilerGenerated]
	private bool tNy(object P_0)
	{
		return HasDocuments;
	}

	[CompilerGenerated]
	private void hNo(object P_0)
	{
		ActivatePreviousDocument();
	}

	[CompilerGenerated]
	private bool gNt(object P_0)
	{
		return HasDocuments;
	}

	[CompilerGenerated]
	private void sNu(object P_0)
	{
		ActivatePrimaryDocument();
	}

	[CompilerGenerated]
	private bool KNz(object P_0)
	{
		return PrimaryDocument != null;
	}

	[CompilerGenerated]
	private void GQi(object P_0)
	{
		CascadeDocuments();
	}

	[CompilerGenerated]
	private bool dQd(object P_0)
	{
		return cQ4()?.CanCascade ?? false;
	}

	[CompilerGenerated]
	private void zQw(object P_0)
	{
		CloseAllDocuments();
	}

	[CompilerGenerated]
	private bool YQ2(object P_0)
	{
		return jQP().Any((DockingWindow w) => w.CanCloseResolved);
	}

	[CompilerGenerated]
	private void dQe(object P_0)
	{
		ClosePrimaryDocument();
	}

	[CompilerGenerated]
	private bool zQG(object P_0)
	{
		return PrimaryDocument?.CanCloseResolved ?? false;
	}

	[CompilerGenerated]
	private void vQI(object P_0)
	{
		if (!(P_0 is MdiKind) && !(P_0 is int))
		{
			MdiKind = MdiKind.None;
		}
		else
		{
			MdiKind = (MdiKind)P_0;
		}
	}

	[CompilerGenerated]
	private void iQk(object P_0)
	{
		TileDocumentsHorizontally();
	}

	[CompilerGenerated]
	private bool tQC(object P_0)
	{
		return cQ4()?.CanTile ?? false;
	}

	[CompilerGenerated]
	private void QQ1(object P_0)
	{
		TileDocumentsVertically();
	}

	[CompilerGenerated]
	private bool yQN(object P_0)
	{
		return cQ4()?.CanTile ?? false;
	}

	[CompilerGenerated]
	private void HQQ(object P_0)
	{
		rNq();
	}

	[CompilerGenerated]
	private void bQm()
	{
		if (!base.IsVisible)
		{
			return;
		}
		foreach (DockHost item in OmO)
		{
			if (item != null && !item.Re5() && item.Child is wH { ContainsDockingWindows: not false })
			{
				item.o2F(_0020: false);
			}
		}
	}

	[CompilerGenerated]
	private void GQa()
	{
		if (base.IsVisible || !CanFloatingDockHostsHideOnDockSiteUnload || qQv())
		{
			return;
		}
		foreach (DockHost item in OmO)
		{
			item?.m2q();
		}
	}

	internal static bool K17()
	{
		return r1d == null;
	}

	internal static DockSite j1O()
	{
		return r1d;
	}
}
