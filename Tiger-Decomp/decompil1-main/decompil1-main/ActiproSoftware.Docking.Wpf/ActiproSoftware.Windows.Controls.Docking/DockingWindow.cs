using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public abstract class DockingWindow : ContentControl, INotifyPropertyChanged, iy, IDockTarget, lX
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass211_0
	{
		public bool GLe;

		internal static _003C_003Ec__DisplayClass211_0 KGn;

		public _003C_003Ec__DisplayClass211_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool mLw(DockingWindow w)
		{
			if (GLe)
			{
				return w.CanCloseResolved;
			}
			return true;
		}

		internal bool OL2(DockingWindow w)
		{
			if (GLe)
			{
				return w.CanCloseResolved;
			}
			return true;
		}

		internal static bool QGA()
		{
			return KGn == null;
		}

		internal static _003C_003Ec__DisplayClass211_0 NGY()
		{
			return KGn;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass216_0
	{
		public DockingWindow dLk;

		public bool GLC;

		internal static _003C_003Ec__DisplayClass216_0 LGC;

		public _003C_003Ec__DisplayClass216_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool DLG(DockingWindow w)
		{
			if (w != dLk)
			{
				if (GLC)
				{
					return w.CanCloseResolved;
				}
				return true;
			}
			return false;
		}

		internal bool JLI(DockingWindow w)
		{
			if (w != dLk)
			{
				if (GLC)
				{
					return w.CanCloseResolved;
				}
				return true;
			}
			return false;
		}

		internal static bool mGK()
		{
			return LGC == null;
		}

		internal static _003C_003Ec__DisplayClass216_0 eGG()
		{
			return LGC;
		}
	}

	private InputAdapter Uko;

	private DockingWindowState xkt;

	private DockSite Jku;

	private WeakReference vkz;

	private WeakReference nCi;

	private DelegateCommand<object> yCd;

	private DelegateCommand<object> jCw;

	private DelegateCommand<object> SC2;

	private DelegateCommand<object> aCe;

	private DelegateCommand<object> jCG;

	private DelegateCommand<object> hCI;

	private DelegateCommand<object> lCk;

	private DelegateCommand<object> LCC;

	private DelegateCommand<object> nC1;

	private DelegateCommand<object> xCN;

	private DelegateCommand<object> vCQ;

	private DelegateCommand<object> aCm;

	private DelegateCommand<object> jCa;

	private DelegateCommand<object> GCW;

	public static readonly DependencyProperty CanAttachProperty;

	public static readonly DependencyProperty CanAttachResolvedProperty;

	public static readonly DependencyProperty CanBecomeDocumentResolvedProperty;

	public static readonly DependencyProperty CanCloseProperty;

	public static readonly DependencyProperty CanCloseResolvedProperty;

	public static readonly DependencyProperty CanDockProperty;

	public static readonly DependencyProperty CanDockResolvedProperty;

	public static readonly DependencyProperty CanDragTabProperty;

	public static readonly DependencyProperty CanDragTabResolvedProperty;

	public static readonly DependencyProperty CanDragToLinkedDockSitesProperty;

	public static readonly DependencyProperty CanDragToLinkedDockSitesResolvedProperty;

	public static readonly DependencyProperty CanFloatProperty;

	public static readonly DependencyProperty CanFloatResolvedProperty;

	public static readonly DependencyProperty CanSerializeProperty;

	public static readonly DependencyProperty CanStandardMdiMaximizeProperty;

	public static readonly DependencyProperty CanStandardMdiMaximizeResolvedProperty;

	public static readonly DependencyProperty CanStandardMdiMinimizeProperty;

	public static readonly DependencyProperty CanStandardMdiMinimizeResolvedProperty;

	public static readonly DependencyProperty ContainerDockedSizeProperty;

	public static readonly DependencyProperty ContainerMaxSizeProperty;

	public static readonly DependencyProperty ContainerMinSizeProperty;

	public static readonly DependencyProperty DescriptionProperty;

	public static readonly DependencyProperty ImageSourceProperty;

	public static readonly DependencyProperty IsActiveProperty;

	internal static readonly DependencyProperty ACB;

	public static readonly DependencyProperty IsFloatingProperty;

	public static readonly DependencyProperty IsOpenProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	public static readonly DependencyProperty LastActiveDateTimeProperty;

	internal static readonly DependencyProperty qCK;

	public static readonly DependencyProperty SerializationIdProperty;

	public static readonly DependencyProperty SizeToContentModesProperty;

	public static readonly DependencyProperty StandardMdiBoundsProperty;

	public static readonly DependencyProperty StandardMdiTitleBarContextContentTemplateProperty;

	public static readonly DependencyProperty StandardMdiWindowStateProperty;

	public static readonly DependencyProperty StateProperty;

	public static readonly DependencyProperty TabFlashColorProperty;

	public static readonly DependencyProperty TabFlashModeProperty;

	public static readonly DependencyProperty TabbedMdiLayoutKindProperty;

	public static readonly DependencyProperty TabbedMdiTabContextContentTemplateProperty;

	public static readonly DependencyProperty TabTextProperty;

	public static readonly DependencyProperty TabTextResolvedProperty;

	public static readonly DependencyProperty TabTintColorProperty;

	public static readonly DependencyProperty TabToolTipProperty;

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty UniqueIdProperty;

	public static readonly DependencyProperty WindowGroupNameProperty;

	[CompilerGenerated]
	private PropertyChangedEventHandler BCJ;

	[CompilerGenerated]
	private bool tCn;

	[CompilerGenerated]
	private bool DCO;

	[CompilerGenerated]
	private bool SCT;

	[CompilerGenerated]
	private bool FC8;

	[CompilerGenerated]
	private bool HCD;

	public static readonly RoutedEvent DefaultLocationRequestedEvent;

	internal static DockingWindow b1c;

	public Size ContainerMaxSizeResolved
	{
		get
		{
			Size containerMaxSize = ContainerMaxSize;
			Size containerMinSizeResolved = ContainerMinSizeResolved;
			return new Size(Math.Max(containerMinSizeResolved.Width, containerMaxSize.Width), Math.Max(containerMinSizeResolved.Height, containerMaxSize.Height));
		}
	}

	public Size ContainerMinSizeResolved
	{
		get
		{
			Size containerMinSize = ContainerMinSize;
			return new Size(Math.Max(0.0, containerMinSize.Width), Math.Max(0.0, containerMinSize.Height));
		}
	}

	internal bool IsCurrentlyOpen
	{
		get
		{
			return (bool)GetValue(ACB);
		}
		set
		{
			SetValue(ACB, value);
		}
	}

	internal wU LastCloseReason
	{
		get
		{
			return (wU)GetValue(qCK);
		}
		set
		{
			SetValue(qCK, value);
		}
	}

	public ICommand ActivateCommand => yCd;

	public bool? CanAttach
	{
		get
		{
			return (bool?)GetValue(CanAttachProperty);
		}
		set
		{
			SetValue(CanAttachProperty, value);
		}
	}

	public bool CanAttachResolved
	{
		get
		{
			return (bool)GetValue(CanAttachResolvedProperty);
		}
		protected set
		{
			SetValue(CanAttachResolvedProperty, value);
		}
	}

	public bool CanBecomeDocumentResolved
	{
		get
		{
			return (bool)GetValue(CanBecomeDocumentResolvedProperty);
		}
		protected set
		{
			SetValue(CanBecomeDocumentResolvedProperty, value);
		}
	}

	public bool? CanClose
	{
		get
		{
			return (bool?)GetValue(CanCloseProperty);
		}
		set
		{
			SetValue(CanCloseProperty, value);
		}
	}

	public bool CanCloseResolved
	{
		get
		{
			return (bool)GetValue(CanCloseResolvedProperty);
		}
		protected set
		{
			SetValue(CanCloseResolvedProperty, value);
		}
	}

	public bool? CanDock
	{
		get
		{
			return (bool?)GetValue(CanDockProperty);
		}
		set
		{
			SetValue(CanDockProperty, value);
		}
	}

	public bool CanDockResolved
	{
		get
		{
			return (bool)GetValue(CanDockResolvedProperty);
		}
		protected set
		{
			SetValue(CanDockResolvedProperty, value);
		}
	}

	public bool? CanDragTab
	{
		get
		{
			return (bool?)GetValue(CanDragTabProperty);
		}
		set
		{
			SetValue(CanDragTabProperty, value);
		}
	}

	public bool CanDragTabResolved
	{
		get
		{
			return (bool)GetValue(CanDragTabResolvedProperty);
		}
		protected set
		{
			SetValue(CanDragTabResolvedProperty, value);
		}
	}

	public bool? CanDragToLinkedDockSites
	{
		get
		{
			return (bool?)GetValue(CanDragToLinkedDockSitesProperty);
		}
		set
		{
			SetValue(CanDragToLinkedDockSitesProperty, value);
		}
	}

	public bool CanDragToLinkedDockSitesResolved
	{
		get
		{
			return (bool)GetValue(CanDragToLinkedDockSitesResolvedProperty);
		}
		protected set
		{
			SetValue(CanDragToLinkedDockSitesResolvedProperty, value);
		}
	}

	public bool? CanFloat
	{
		get
		{
			return (bool?)GetValue(CanFloatProperty);
		}
		set
		{
			SetValue(CanFloatProperty, value);
		}
	}

	public bool CanFloatResolved
	{
		get
		{
			return (bool)GetValue(CanFloatResolvedProperty);
		}
		protected set
		{
			SetValue(CanFloatResolvedProperty, value);
		}
	}

	public bool CanMoveToNewHorizontalContainer
	{
		get
		{
			TabbedMdiContainer tabbedMdiContainer = MkZ() as TabbedMdiContainer;
			if (CanDockResolved && tabbedMdiContainer != null)
			{
				return tabbedMdiContainer.Windows.Count > 1;
			}
			return false;
		}
	}

	public bool CanMoveToNewVerticalContainer
	{
		get
		{
			TabbedMdiContainer tabbedMdiContainer = MkZ() as TabbedMdiContainer;
			if (CanDockResolved && tabbedMdiContainer != null)
			{
				return tabbedMdiContainer.Windows.Count > 1;
			}
			return false;
		}
	}

	public bool CanMoveToNextContainer
	{
		get
		{
			if (MkZ() is TabbedMdiContainer tabbedMdiContainer)
			{
				return SplitContainer.Omh<TabbedMdiContainer>(tabbedMdiContainer, _0020: true) != null;
			}
			return false;
		}
	}

	public bool CanMoveToPreviousContainer
	{
		get
		{
			if (MkZ() is TabbedMdiContainer tabbedMdiContainer)
			{
				return SplitContainer.Omh<TabbedMdiContainer>(tabbedMdiContainer, _0020: false) != null;
			}
			return false;
		}
	}

	public bool CanMoveToPrimaryMdiHost
	{
		get
		{
			if (CanBecomeDocumentResolved && Jku != null && Jku.cQ4() != null)
			{
				if (IsCurrentlyOpen && QkM() == DockingWindowState.Document)
				{
					return DockHost != Jku.PrimaryDockHost;
				}
				return true;
			}
			return false;
		}
	}

	public bool CanSerialize
	{
		get
		{
			return (bool)GetValue(CanSerializeProperty);
		}
		set
		{
			SetValue(CanSerializeProperty, value);
		}
	}

	public bool? CanStandardMdiMaximize
	{
		get
		{
			return (bool?)GetValue(CanStandardMdiMaximizeProperty);
		}
		set
		{
			SetValue(CanStandardMdiMaximizeProperty, value);
		}
	}

	public bool CanStandardMdiMaximizeResolved
	{
		get
		{
			return (bool)GetValue(CanStandardMdiMaximizeResolvedProperty);
		}
		private set
		{
			SetValue(CanStandardMdiMaximizeResolvedProperty, value);
		}
	}

	public bool? CanStandardMdiMinimize
	{
		get
		{
			return (bool?)GetValue(CanStandardMdiMinimizeProperty);
		}
		set
		{
			SetValue(CanStandardMdiMinimizeProperty, value);
		}
	}

	public bool CanStandardMdiMinimizeResolved
	{
		get
		{
			return (bool)GetValue(CanStandardMdiMinimizeResolvedProperty);
		}
		private set
		{
			SetValue(CanStandardMdiMinimizeResolvedProperty, value);
		}
	}

	public ICommand CloseAllInContainerCommand => jCw;

	public ICommand CloseCommand => SC2;

	public ICommand CloseOthersCommand => aCe;

	public Size ContainerDockedSize
	{
		get
		{
			return (Size)GetValue(ContainerDockedSizeProperty);
		}
		set
		{
			SetValue(ContainerDockedSizeProperty, value);
		}
	}

	public Size ContainerMaxSize
	{
		get
		{
			return (Size)GetValue(ContainerMaxSizeProperty);
		}
		set
		{
			SetValue(ContainerMaxSizeProperty, value);
		}
	}

	public Size ContainerMinSize
	{
		get
		{
			return (Size)GetValue(ContainerMinSizeProperty);
		}
		set
		{
			SetValue(ContainerMinSizeProperty, value);
		}
	}

	[Localizability(LocalizationCategory.ToolTip)]
	public string Description
	{
		get
		{
			return (string)GetValue(DescriptionProperty);
		}
		set
		{
			SetValue(DescriptionProperty, value);
		}
	}

	public ICommand DestroyCommand => jCG;

	public DockHost DockHost => MkZ()?.DockHost;

	public DockSite DockSite
	{
		get
		{
			return Jku;
		}
		internal set
		{
			if (Jku == value)
			{
				return;
			}
			bool flag = false;
			DockSite jku = Jku;
			if (Jku != null)
			{
				flag = Jku.yNs(this);
			}
			Jku = value;
			if (Jku != null)
			{
				int num = 0;
				if (!k1M())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Jku.vNp(this, flag);
			}
			OnDockSiteChanged(jku, Jku);
			NotifyPropertyChanged(vVK.ssH(7352));
		}
	}

	public ICommand FloatCommand => hCI;

	public ImageSource ImageSource
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceProperty);
		}
		set
		{
			SetValue(ImageSourceProperty, value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(IsActiveProperty);
		}
		set
		{
			SetValue(IsActiveProperty, value);
		}
	}

	public bool IsContainerForItem
	{
		[CompilerGenerated]
		get
		{
			return HCD;
		}
		[CompilerGenerated]
		internal set
		{
			HCD = value;
		}
	}

	public bool IsFloating
	{
		get
		{
			return (bool)GetValue(IsFloatingProperty);
		}
		set
		{
			SetValue(IsFloatingProperty, value);
		}
	}

	public bool IsOpen
	{
		get
		{
			return (bool)GetValue(IsOpenProperty);
		}
		set
		{
			SetValue(IsOpenProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public DateTime LastActiveDateTime
	{
		get
		{
			return (DateTime)GetValue(LastActiveDateTimeProperty);
		}
		internal set
		{
			SetValue(LastActiveDateTimeProperty, value);
		}
	}

	public ICommand MoveToMdiCommand => lCk;

	public ICommand MoveToNewHorizontalContainerCommand => LCC;

	public ICommand MoveToNewVerticalContainerCommand => nC1;

	public ICommand MoveToNextContainerCommand => xCN;

	public ICommand MoveToPreviousContainerCommand => vCQ;

	public ICommand MoveToPrimaryMdiHostCommand => aCm;

	public ICommand OpenCommand => jCa;

	public DockingWindowContainerBase ParentContainer => MkZ() as DockingWindowContainerBase;

	[Localizability(LocalizationCategory.NeverLocalize)]
	public string SerializationId
	{
		get
		{
			return (string)GetValue(SerializationIdProperty);
		}
		set
		{
			SetValue(SerializationIdProperty, value);
		}
	}

	public ICommand SetTabbedMdiLayoutKindCommand => GCW;

	public SizeToContentModes SizeToContentModes
	{
		get
		{
			return (SizeToContentModes)GetValue(SizeToContentModesProperty);
		}
		set
		{
			SetValue(SizeToContentModesProperty, value);
		}
	}

	public Rect StandardMdiBounds
	{
		get
		{
			return (Rect)GetValue(StandardMdiBoundsProperty);
		}
		set
		{
			SetValue(StandardMdiBoundsProperty, value);
		}
	}

	public DataTemplate StandardMdiTitleBarContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(StandardMdiTitleBarContextContentTemplateProperty);
		}
		set
		{
			SetValue(StandardMdiTitleBarContextContentTemplateProperty, value);
		}
	}

	public WindowState StandardMdiWindowState
	{
		get
		{
			return (WindowState)GetValue(StandardMdiWindowStateProperty);
		}
		set
		{
			SetValue(StandardMdiWindowStateProperty, value);
		}
	}

	public DockingWindowState State
	{
		get
		{
			return (DockingWindowState)GetValue(StateProperty);
		}
		set
		{
			SetValue(StateProperty, value);
		}
	}

	public Color TabFlashColor
	{
		get
		{
			return (Color)GetValue(TabFlashColorProperty);
		}
		set
		{
			SetValue(TabFlashColorProperty, value);
		}
	}

	public TabFlashMode TabFlashMode
	{
		get
		{
			return (TabFlashMode)GetValue(TabFlashModeProperty);
		}
		set
		{
			SetValue(TabFlashModeProperty, value);
		}
	}

	public TabLayoutKind TabbedMdiLayoutKind
	{
		get
		{
			return (TabLayoutKind)GetValue(TabbedMdiLayoutKindProperty);
		}
		set
		{
			SetValue(TabbedMdiLayoutKindProperty, value);
		}
	}

	public DataTemplate TabbedMdiTabContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(TabbedMdiTabContextContentTemplateProperty);
		}
		set
		{
			SetValue(TabbedMdiTabContextContentTemplateProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string TabText
	{
		get
		{
			return (string)GetValue(TabTextProperty);
		}
		set
		{
			SetValue(TabTextProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string TabTextResolved
	{
		get
		{
			return (string)GetValue(TabTextResolvedProperty);
		}
		private set
		{
			SetValue(TabTextResolvedProperty, value);
		}
	}

	public Color TabTintColor
	{
		get
		{
			return (Color)GetValue(TabTintColorProperty);
		}
		set
		{
			SetValue(TabTintColorProperty, value);
		}
	}

	[Localizability(LocalizationCategory.ToolTip)]
	public object TabToolTip
	{
		get
		{
			return GetValue(TabToolTipProperty);
		}
		set
		{
			SetValue(TabToolTipProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		set
		{
			SetValue(TitleProperty, value);
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

	[Localizability(LocalizationCategory.NeverLocalize)]
	public string WindowGroupName
	{
		get
		{
			return (string)GetValue(WindowGroupNameProperty);
		}
		set
		{
			SetValue(WindowGroupNameProperty, value);
		}
	}

	DockHost IDockTarget.DockHost => DockHost;

	bool iy.HasDockGuides => false;

	bool iy.RequiresReverseOrderInsertion => false;

	IEnumerable<lX> lX.ChildNodes
	{
		get
		{
			yield break;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = BCJ;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref BCJ, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = BCJ;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref BCJ, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public event EventHandler<DockingWindowDefaultLocationEventArgs> DefaultLocationRequested
	{
		add
		{
			AddHandler(DefaultLocationRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(DefaultLocationRequestedEvent, value);
		}
	}

	protected DockingWindow()
	{
		IVH.CecNqz();
		this._002Ector(isContainerForItem: false);
	}

	protected DockingWindow(bool isContainerForItem)
	{
		IVH.CecNqz();
		base._002Ector();
		IsContainerForItem = isContainerForItem;
		UniqueId = Guid.NewGuid();
		XIx();
		OIM();
	}

	private void XIx()
	{
		Uko = new InputAdapter(this);
		Uko.PointerPressed += gI4;
		Uko.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	internal void iIl()
	{
		G0 g = MkZ();
		if (g != null && g.SelectedWindow != this)
		{
			g.SelectedWindow = this;
		}
	}

	[SpecialName]
	internal Size Skx()
	{
		Size containerDockedSize = ContainerDockedSize;
		if (containerDockedSize.Width == double.MaxValue || double.IsPositiveInfinity(containerDockedSize.Width))
		{
			containerDockedSize.Width = 200.0;
		}
		if (containerDockedSize.Height == double.MaxValue || double.IsPositiveInfinity(containerDockedSize.Height))
		{
			containerDockedSize.Height = 200.0;
		}
		return new Size(Math.Max(0.0, containerDockedSize.Width), Math.Max(0.0, containerDockedSize.Height));
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void OIM()
	{
		yCd = new DelegateCommand<object>(delegate
		{
			Activate();
		}, (object P_0) => Jku != null);
		jCw = new DelegateCommand<object>(delegate
		{
			CloseAllInContainer();
		}, delegate
		{
			G0 g = MkZ();
			return g != null && ((g is ac { IsWrapper: not false, MdiHost: not null } ac) ? (from w in ac.MdiHost.GetDocuments()
				where w.CanCloseResolved
				select w).Any() : g.Windows.Where((DockingWindow w) => w.CanCloseResolved).Any());
		});
		SC2 = new DelegateCommand<object>(delegate
		{
			Close();
		}, (object P_0) => Jku != null && IsCurrentlyOpen && CanCloseResolved);
		aCe = new DelegateCommand<object>(delegate
		{
			CloseOthers();
		}, delegate
		{
			G0 g = MkZ();
			return g != null && ((g is ac { IsWrapper: not false, MdiHost: not null } ac) ? (from dockingWindow in ac.MdiHost.GetDocuments()
				where dockingWindow != this && dockingWindow.CanCloseResolved
				select dockingWindow).Any() : g.Windows.Where((DockingWindow dockingWindow) => dockingWindow != this && dockingWindow.CanCloseResolved).Any());
		});
		jCG = new DelegateCommand<object>(delegate
		{
			Destroy();
		}, (object P_0) => Jku != null);
		hCI = new DelegateCommand<object>(delegate
		{
			Float();
		}, delegate
		{
			DockHost dockHost = DockHost;
			if (dockHost != null && CanFloatResolved)
			{
				if (dockHost.xGd())
				{
					return true;
				}
				switch (State)
				{
				case DockingWindowState.AutoHide:
					return true;
				case DockingWindowState.Docked:
				{
					if (dockHost.LayoutKind != (kq)1)
					{
						return true;
					}
					DockingWindowContainerBase parentContainer = ParentContainer;
					if (parentContainer != null)
					{
						return parentContainer.WindowsCore.Count > 1;
					}
					return false;
				}
				case DockingWindowState.Document:
				{
					MdiHostBase mdiHost = dockHost.MdiHost;
					if (mdiHost != null)
					{
						return mdiHost.GetDocuments().Count > 1;
					}
					return false;
				}
				}
			}
			return false;
		});
		lCk = new DelegateCommand<object>(delegate(object P_0)
		{
			MoveToMdi(P_0 as DockHost);
		}, delegate
		{
			bool flag = CanBecomeDocumentResolved && Jku != null && Jku.cQ4() != null;
			return (QkM() == DockingWindowState.Document) ? (flag && !IsCurrentlyOpen) : flag;
		});
		int num = 0;
		if (L1h() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		LCC = new DelegateCommand<object>(delegate
		{
			MoveToNewHorizontalContainer();
		}, (object P_0) => CanMoveToNewHorizontalContainer);
		nC1 = new DelegateCommand<object>(delegate
		{
			MoveToNewVerticalContainer();
		}, (object P_0) => CanMoveToNewVerticalContainer);
		xCN = new DelegateCommand<object>(delegate
		{
			MoveToNextContainer();
		}, (object P_0) => CanMoveToNextContainer);
		vCQ = new DelegateCommand<object>(delegate
		{
			MoveToPreviousContainer();
		}, (object P_0) => CanMoveToPreviousContainer);
		aCm = new DelegateCommand<object>(delegate
		{
			if (Jku != null && Jku.cQ4() != null && (!IsCurrentlyOpen || QkM() != DockingWindowState.Document || DockHost != Jku.PrimaryDockHost))
			{
				MoveToMdi(Jku.PrimaryDockHost);
			}
		}, (object P_0) => CanMoveToPrimaryMdiHost);
		jCa = new DelegateCommand<object>(delegate
		{
			Open();
		}, (object P_0) => Jku != null && !IsCurrentlyOpen);
		GCW = new DelegateCommand<object>(delegate(object P_0)
		{
			TabbedMdiLayoutKind = (P_0 as TabLayoutKind?).GetValueOrDefault();
		});
	}

	[SpecialName]
	internal DockingWindowState QkM()
	{
		return xkt;
	}

	internal int sIv()
	{
		if (MkZ() is ac { MdiHost: var mdiHost })
		{
			if (mdiHost != null)
			{
				return mdiHost.GetIndexInContainer(this);
			}
		}
		else if (this is ToolWindow toolWindow)
		{
			ToolWindowContainer toolWindowContainer = toolWindow.DBR();
			if (toolWindowContainer != null)
			{
				return toolWindowContainer.Windows.IndexOf(toolWindow);
			}
		}
		return -1;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Kk7()
	{
		return tCn;
	}

	[SpecialName]
	[CompilerGenerated]
	private void dkR(bool value)
	{
		tCn = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool UkL()
	{
		return DCO;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void mk3(bool value)
	{
		DCO = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool Vk9()
	{
		return SCT;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void UkY(bool value)
	{
		SCT = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool Gks()
	{
		return FC8;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Jkq(bool value)
	{
		FC8 = value;
	}

	[SpecialName]
	internal UIElement Hkc()
	{
		if (vkz != null)
		{
			if (vkz.IsAlive)
			{
				return vkz.Target as UIElement;
			}
			vkz = null;
		}
		return null;
	}

	[SpecialName]
	internal void gk4(UIElement value)
	{
		if (value != null)
		{
			vkz = new WeakReference(value);
		}
		else
		{
			vkz = null;
		}
	}

	internal void wI7()
	{
		AI0();
		fIh();
	}

	private static void HIR(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).UpdateCanAttachResolved();
	}

	private static void fIS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		dockingWindow.UpdateCanCloseResolved();
		if (dockingWindow.Jku != null && dockingWindow.IsCurrentlyOpen && dockingWindow.QkM() == DockingWindowState.Document)
		{
			dockingWindow.Jku.m1v();
		}
	}

	private static void mIL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).DockHost?.i2Z();
		IIq(P_0, P_1);
	}

	private static void NI3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).UpdateCanDockResolved();
	}

	private static void XI6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).UpdateCanDragTabResolved();
	}

	private static void fI9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).UpdateCanDragToLinkedDockSitesResolved();
	}

	private static void eIY(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).UpdateCanFloatResolved();
	}

	private static void bIp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).AI0();
	}

	private static void gIs(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((DockingWindow)P_0).fIh();
	}

	private static void IIq(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow obj = (DockingWindow)P_0;
		obj.UpdateCommands();
		if (obj.MkZ() is ToolWindowContainer toolWindowContainer)
		{
			toolWindowContainer.CDs();
		}
	}

	private static void lIF(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (dockingWindow.State != DockingWindowState.AutoHide || P_1.OldValue != null == (P_1.NewValue != null))
		{
			return;
		}
		DockHost dockHost = dockingWindow.DockHost;
		if (dockHost == null)
		{
			return;
		}
		foreach (AutoHideTabStrip item in dockHost.s25())
		{
			item?.T88();
		}
	}

	private static void lIV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (true.Equals(P_1.NewValue))
		{
			dockingWindow.LastActiveDateTime = DateTime.Now;
			if (dockingWindow.Jku != null && dockingWindow.Jku.ActiveWindow != dockingWindow)
			{
				dockingWindow.Activate();
			}
		}
	}

	private static void vIP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (dockingWindow.DockSite == null)
		{
			dockingWindow.UIX();
		}
		dockingWindow.UpdateCommands();
	}

	private static void MIf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (dockingWindow.Kk7() || dockingWindow.Jku == null || !dockingWindow.IsCurrentlyOpen)
		{
			return;
		}
		if (!(bool)P_1.NewValue)
		{
			Nx nx = dockingWindow.Jku.s1t();
			if (dockingWindow is ToolWindow toolWindow && dockingWindow.QkM() == DockingWindowState.Docked)
			{
				nx.evd(toolWindow, dockingWindow.QkM(), dockingWindow.Jku.PrimaryDockHost);
			}
			else if (dockingWindow.Jku.cQ4() != null)
			{
				nx.Nv1(dockingWindow, dockingWindow.Jku.PrimaryDockHost);
			}
		}
		else
		{
			dockingWindow.Float();
		}
	}

	private static void HIU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (!dockingWindow.UkL() && dockingWindow.Jku != null)
		{
			if (!(bool)P_1.NewValue)
			{
				dockingWindow.Close();
			}
			else
			{
				dockingWindow.Open();
			}
		}
	}

	private static void rIc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		if (true.Equals(P_1.NewValue))
		{
			dockingWindow.iIl();
		}
		dockingWindow.OnIsSelectedChanged();
	}

	private void gI4(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (!P_1.Handled && Jku != null && !cP.NlZ(this))
		{
			Activate();
		}
	}

	private static void kIj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow obj = (DockingWindow)P_0;
		DockingWindowState oldValue = (DockingWindowState)P_1.OldValue;
		DockingWindowState newValue = (DockingWindowState)P_1.NewValue;
		obj.OnStateChanged(oldValue, newValue);
		obj.xkt = newValue;
		obj.UpdateCommands();
	}

	private static void xIZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DockingWindow dockingWindow = (DockingWindow)P_0;
		dockingWindow.TabTextResolved = ((dockingWindow.TabText != null) ? dockingWindow.TabText : dockingWindow.Title);
	}

	[SpecialName]
	internal G0 MkZ()
	{
		if (nCi != null)
		{
			if (nCi.IsAlive)
			{
				return nCi.Target as G0;
			}
			nCi = null;
		}
		return null;
	}

	[SpecialName]
	internal void qkb(G0 value)
	{
		if (value != null)
		{
			nCi = new WeakReference(value);
		}
		else
		{
			nCi = null;
		}
	}

	private void kIb(bool P_0)
	{
		dkR(value: true);
		try
		{
			IsFloating = P_0;
		}
		finally
		{
			dkR(value: false);
		}
	}

	internal void TIA(bool P_0)
	{
		mk3(value: true);
		try
		{
			IsOpen = P_0;
		}
		finally
		{
			mk3(value: false);
		}
	}

	internal void zIH(DockingWindowState P_0)
	{
		try
		{
			UkY(value: true);
			State = P_0;
		}
		finally
		{
			UkY(value: false);
		}
	}

	internal void AI0()
	{
		int num = 1;
		bool? canStandardMdiMaximize = default(bool?);
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
				{
					if (canStandardMdiMaximize.HasValue)
					{
						CanStandardMdiMaximizeResolved = CanStandardMdiMaximize.Value;
						return;
					}
					StandardMdiHost standardMdiHost = ((Jku != null) ? (Jku.cQ4() as StandardMdiHost) : null);
					if (standardMdiHost == null)
					{
						CanStandardMdiMaximizeResolved = true;
					}
					else
					{
						CanStandardMdiMaximizeResolved = standardMdiHost.CanWindowsMaximize;
					}
					return;
				}
				}
				canStandardMdiMaximize = CanStandardMdiMaximize;
				num2 = 0;
			}
			while (k1M());
		}
	}

	internal void fIh()
	{
		if (CanStandardMdiMinimize.HasValue)
		{
			CanStandardMdiMinimizeResolved = CanStandardMdiMinimize.Value;
			return;
		}
		StandardMdiHost standardMdiHost = ((Jku != null) ? (Jku.cQ4() as StandardMdiHost) : null);
		if (standardMdiHost != null)
		{
			CanStandardMdiMinimizeResolved = standardMdiHost.CanWindowsMinimize;
		}
		else
		{
			CanStandardMdiMinimizeResolved = true;
		}
	}

	internal void PIg()
	{
		if (Jku != null)
		{
			DockHost dockHost = DockHost;
			if (dockHost != null && dockHost.DockSite == Jku)
			{
				kIb(Jku.PrimaryDockHost != dockHost);
			}
		}
	}

	internal void UIX()
	{
		TIA(IsCurrentlyOpen);
	}

	internal void uI5()
	{
		UpdateCanAttachResolved();
		UpdateCanBecomeDocumentResolved();
		UpdateCanCloseResolved();
		UpdateCanDockResolved();
		UpdateCanDragTabResolved();
		UpdateCanDragToLinkedDockSitesResolved();
		UpdateCanFloatResolved();
		AI0();
		fIh();
		int num = 0;
		if (L1h() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		PIg();
	}

	public void Activate()
	{
		Activate(focus: true);
	}

	public void Activate(bool focus)
	{
		if (Jku != null)
		{
			Jku.s1t().Activate(this, focus);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public bool Close()
	{
		if (Jku != null)
		{
			return Jku.s1t().Close(this, wU.Close, force: false, allowDocumentDestroy: true);
		}
		return false;
	}

	[SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
	public bool CloseAllInContainer(bool onlyCloseable = true)
	{
		_003C_003Ec__DisplayClass211_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass211_0();
		CS_0024_003C_003E8__locals3.GLe = onlyCloseable;
		if (Jku != null)
		{
			G0 g = MkZ();
			if (g != null)
			{
				int num = 0;
				if (L1h() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
				{
					IEnumerable<DockingWindow> windows = ((!(g is ac { IsWrapper: not false, MdiHost: not null } ac)) ? g.Windows.Where((DockingWindow w) => !CS_0024_003C_003E8__locals3.GLe || w.CanCloseResolved) : (from w in ac.MdiHost.GetDocuments()
						where !CS_0024_003C_003E8__locals3.GLe || w.CanCloseResolved
						select w));
					return Jku.s1t().Close(windows, (wU)2, force: false, allowDocumentDestroy: true);
				}
				}
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
	public bool CloseOthers(bool onlyCloseable = true)
	{
		int num = 1;
		_003C_003Ec__DisplayClass216_0 _003C_003Ec__DisplayClass216_ = default(_003C_003Ec__DisplayClass216_0);
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
					_003C_003Ec__DisplayClass216_.dLk = this;
					_003C_003Ec__DisplayClass216_.GLC = onlyCloseable;
					if (Jku != null)
					{
						G0 g = MkZ();
						if (g != null)
						{
							IEnumerable<DockingWindow> windows = ((g is ac { IsWrapper: not false, MdiHost: not null } ac) ? ac.MdiHost.GetDocuments().Where(_003C_003Ec__DisplayClass216_.DLG) : g.Windows.Where(_003C_003Ec__DisplayClass216_.JLI));
							return Jku.s1t().Close(windows, (wU)2, force: false, allowDocumentDestroy: true);
						}
					}
					return false;
				}
				_003C_003Ec__DisplayClass216_ = new _003C_003Ec__DisplayClass216_0();
				num2 = 0;
			}
			while (L1h() == null);
		}
	}

	public void Destroy()
	{
		if (Jku != null)
		{
			Jku.s1t().fMt(this);
		}
	}

	public void DragMove(InputPointerButtonEventArgs sourceEventArgs)
	{
		if (sourceEventArgs == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		if (IsCurrentlyOpen)
		{
			ParentContainer?.TabControl?.XdF()?.DragMove(sourceEventArgs);
		}
		else if (Jku != null)
		{
			Jku.s1t().HvI(this, default(Point), sourceEventArgs);
		}
	}

	public void Float()
	{
		Float(null, null);
	}

	public void Float(Point location)
	{
		Float(location, null);
	}

	public void Float(Size size)
	{
		Float(null, size);
	}

	public abstract void Float(Point? location, Size? size);

	public void MoveToFirst()
	{
		MoveToIndex(0);
	}

	public void MoveToIndex(int index)
	{
		if (Jku != null)
		{
			Jku.s1t().ivC(this, index);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public void MoveToLast()
	{
		MoveToIndex(int.MaxValue);
	}

	public void MoveToLinkedDockSite(DockSite targetDockSite)
	{
		if (targetDockSite == null)
		{
			throw new ArgumentNullException(vVK.ssH(7372));
		}
		if (Jku == targetDockSite)
		{
			return;
		}
		if (Jku != null)
		{
			if (!Jku.qN4(targetDockSite))
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowTargetNotLinked));
			}
			Destroy();
		}
		DockSite = targetDockSite;
	}

	public void MoveToMdi()
	{
		MoveToMdi(null);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void MoveToMdi(DockHost dockHost)
	{
		if (Jku != null)
		{
			Jku.s1t().Nv1(this, dockHost);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public bool MoveToNewHorizontalContainer()
	{
		if (!CanMoveToNewHorizontalContainer)
		{
			return false;
		}
		if (Jku != null && MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			double height = ((tabbedMdiContainer.ActualHeight > 0.0) ? (tabbedMdiContainer.ActualHeight / 2.0) : ContainerDockedSize.Height);
			ContainerDockedSize = new Size(ContainerDockedSize.Width, height);
			Jku.s1t().Evi(this, tabbedMdiContainer, Side.Bottom);
			return true;
		}
		return false;
	}

	public bool MoveToNewVerticalContainer()
	{
		if (!CanMoveToNewVerticalContainer)
		{
			return false;
		}
		if (Jku != null && MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			double num3;
			if (!(tabbedMdiContainer.ActualWidth > 0.0))
			{
				int num = 0;
				if (L1h() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				num3 = ContainerDockedSize.Width;
			}
			else
			{
				num3 = tabbedMdiContainer.ActualWidth / 2.0;
			}
			double width = num3;
			ContainerDockedSize = new Size(width, ContainerDockedSize.Height);
			Jku.s1t().Evi(this, tabbedMdiContainer, Side.Right);
			return true;
		}
		return false;
	}

	public bool MoveToNextContainer()
	{
		if (MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			TabbedMdiContainer tabbedMdiContainer2 = SplitContainer.Omh<TabbedMdiContainer>(tabbedMdiContainer, _0020: true);
			if (tabbedMdiContainer2 != null)
			{
				Jku.s1t().WMz(new DockingWindow[1] { this }, tabbedMdiContainer2.State, tabbedMdiContainer2);
				return true;
			}
		}
		return false;
	}

	public bool MoveToPreviousContainer()
	{
		if (MkZ() is TabbedMdiContainer tabbedMdiContainer)
		{
			TabbedMdiContainer tabbedMdiContainer2 = SplitContainer.Omh<TabbedMdiContainer>(tabbedMdiContainer, _0020: false);
			if (tabbedMdiContainer2 != null)
			{
				Jku.s1t().WMz(new DockingWindow[1] { this }, tabbedMdiContainer2.State, tabbedMdiContainer2);
				return true;
			}
		}
		return false;
	}

	protected void NotifyPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	protected virtual void OnDockSiteChanged(DockSite oldValue, DockSite newValue)
	{
		uI5();
		UpdateCommands();
	}

	protected virtual void OnIsSelectedChanged()
	{
	}

	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		BCJ?.Invoke(this, e);
	}

	protected virtual void OnStateChanged(DockingWindowState oldValue, DockingWindowState newValue)
	{
	}

	public void Open()
	{
		if (Jku != null)
		{
			Jku.s1t().wvN(this);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, vVK.ssH(7404), new object[2]
		{
			GetType().Name,
			Title
		});
	}

	protected internal abstract void UpdateCanAttachResolved();

	protected internal virtual void UpdateCanBecomeDocumentResolved()
	{
		CanBecomeDocumentResolved = true;
	}

	protected internal abstract void UpdateCanCloseResolved();

	protected internal abstract void UpdateCanDockResolved();

	protected internal abstract void UpdateCanDragTabResolved();

	protected internal abstract void UpdateCanDragToLinkedDockSitesResolved();

	protected internal abstract void UpdateCanFloatResolved();

	protected internal virtual void UpdateCommands()
	{
		yCd.RaiseCanExecuteChanged();
		jCw.RaiseCanExecuteChanged();
		SC2.RaiseCanExecuteChanged();
		int num = 0;
		if (!k1M())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		aCe.RaiseCanExecuteChanged();
		jCG.RaiseCanExecuteChanged();
		hCI.RaiseCanExecuteChanged();
		lCk.RaiseCanExecuteChanged();
		LCC.RaiseCanExecuteChanged();
		nC1.RaiseCanExecuteChanged();
		jCa.RaiseCanExecuteChanged();
		GCW.RaiseCanExecuteChanged();
	}

	internal void oIy(DockingWindowDefaultLocationEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = DefaultLocationRequestedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnDefaultLocationRequested(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnDefaultLocationRequested(DockingWindowDefaultLocationEventArgs e)
	{
	}

	DockingWindowState IDockTarget.GetState(Side? side)
	{
		return QkM();
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
		return false;
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		if (e != null && base.IsLoaded)
		{
			gk4(e.NewFocus as UIElement);
		}
		base.OnGotKeyboardFocus(e);
	}

	static DockingWindow()
	{
		IVH.CecNqz();
		CanAttachProperty = DependencyProperty.Register(vVK.ssH(7436), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, HIR));
		CanAttachResolvedProperty = DependencyProperty.Register(vVK.ssH(7458), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
		CanBecomeDocumentResolvedProperty = DependencyProperty.Register(vVK.ssH(7496), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true, IIq));
		CanCloseProperty = DependencyProperty.Register(vVK.ssH(5326), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, fIS));
		CanCloseResolvedProperty = DependencyProperty.Register(vVK.ssH(7550), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true, mIL));
		CanDockProperty = DependencyProperty.Register(vVK.ssH(7586), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, NI3));
		CanDockResolvedProperty = DependencyProperty.Register(vVK.ssH(7604), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true, IIq));
		CanDragTabProperty = DependencyProperty.Register(vVK.ssH(7638), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, XI6));
		CanDragTabResolvedProperty = DependencyProperty.Register(vVK.ssH(7662), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
		CanDragToLinkedDockSitesProperty = DependencyProperty.Register(vVK.ssH(7702), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, fI9));
		int num = 3;
		if (1 == 0)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				CanDragToLinkedDockSitesResolvedProperty = DependencyProperty.Register(vVK.ssH(7754), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
				CanFloatProperty = DependencyProperty.Register(vVK.ssH(7822), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, eIY));
				CanFloatResolvedProperty = DependencyProperty.Register(vVK.ssH(7842), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true, IIq));
				CanSerializeProperty = DependencyProperty.Register(vVK.ssH(7878), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
				CanStandardMdiMaximizeProperty = DependencyProperty.Register(vVK.ssH(7906), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, bIp));
				num = 2;
				continue;
			default:
				TabTextResolvedProperty = DependencyProperty.Register(vVK.ssH(8892), typeof(string), typeof(DockingWindow), new PropertyMetadata(null));
				TabTintColorProperty = DependencyProperty.Register(vVK.ssH(8926), typeof(Color), typeof(DockingWindow), new PropertyMetadata(Colors.Transparent));
				TabToolTipProperty = DependencyProperty.Register(vVK.ssH(8954), typeof(object), typeof(DockingWindow), new PropertyMetadata(null));
				TitleProperty = DependencyProperty.Register(vVK.ssH(7338), typeof(string), typeof(DockingWindow), new PropertyMetadata(null, xIZ));
				UniqueIdProperty = DependencyProperty.Register(vVK.ssH(7306), typeof(Guid), typeof(DockingWindow), new PropertyMetadata(Guid.Empty));
				WindowGroupNameProperty = DependencyProperty.Register(vVK.ssH(8978), typeof(string), typeof(DockingWindow), new PropertyMetadata(null));
				DefaultLocationRequestedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(9012), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowDefaultLocationEventArgs>), typeof(DockingWindow));
				return;
			case 2:
				CanStandardMdiMaximizeResolvedProperty = DependencyProperty.Register(vVK.ssH(7954), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
				CanStandardMdiMinimizeProperty = DependencyProperty.Register(vVK.ssH(8018), typeof(bool?), typeof(DockingWindow), new PropertyMetadata(null, gIs));
				CanStandardMdiMinimizeResolvedProperty = DependencyProperty.Register(vVK.ssH(8066), typeof(bool), typeof(DockingWindow), new PropertyMetadata(true));
				ContainerDockedSizeProperty = DependencyProperty.Register(vVK.ssH(8130), typeof(Size), typeof(DockingWindow), new PropertyMetadata(new Size(200.0, 200.0)));
				ContainerMaxSizeProperty = DependencyProperty.Register(vVK.ssH(8172), typeof(Size), typeof(DockingWindow), new PropertyMetadata(new Size(double.PositiveInfinity, double.PositiveInfinity)));
				num2 = 4;
				break;
			case 4:
				ContainerMinSizeProperty = DependencyProperty.Register(vVK.ssH(8208), typeof(Size), typeof(DockingWindow), new PropertyMetadata(new Size(30.0, 30.0)));
				DescriptionProperty = DependencyProperty.Register(vVK.ssH(8244), typeof(string), typeof(DockingWindow), new PropertyMetadata(null));
				ImageSourceProperty = DependencyProperty.Register(vVK.ssH(6138), typeof(ImageSource), typeof(DockingWindow), new PropertyMetadata(null, lIF));
				IsActiveProperty = DependencyProperty.Register(vVK.ssH(878), typeof(bool), typeof(DockingWindow), new PropertyMetadata(false, lIV));
				ACB = DependencyProperty.Register(vVK.ssH(8270), typeof(bool), typeof(DockingWindow), new PropertyMetadata(false, vIP));
				IsFloatingProperty = DependencyProperty.Register(vVK.ssH(8304), typeof(bool), typeof(DockingWindow), new PropertyMetadata(false, MIf));
				IsOpenProperty = DependencyProperty.Register(vVK.ssH(8328), typeof(bool), typeof(DockingWindow), new PropertyMetadata(false, HIU));
				IsSelectedProperty = DependencyProperty.Register(vVK.ssH(8344), typeof(bool), typeof(DockingWindow), new PropertyMetadata(false, rIc));
				LastActiveDateTimeProperty = DependencyProperty.Register(vVK.ssH(8368), typeof(DateTime), typeof(DockingWindow), new PropertyMetadata(DateTime.MinValue));
				qCK = DependencyProperty.Register(vVK.ssH(8408), typeof(wU), typeof(DockingWindow), new PropertyMetadata((wU)0));
				SerializationIdProperty = DependencyProperty.Register(vVK.ssH(8442), typeof(string), typeof(DockingWindow), new PropertyMetadata(null));
				SizeToContentModesProperty = DependencyProperty.Register(vVK.ssH(8476), typeof(SizeToContentModes), typeof(DockingWindow), new PropertyMetadata(SizeToContentModes.None));
				StandardMdiBoundsProperty = DependencyProperty.Register(vVK.ssH(8516), typeof(Rect), typeof(DockingWindow), new PropertyMetadata(Rect.Empty));
				StandardMdiTitleBarContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(8554), typeof(DataTemplate), typeof(DockingWindow), new PropertyMetadata(new DataTemplate()));
				StandardMdiWindowStateProperty = DependencyProperty.Register(vVK.ssH(8640), typeof(WindowState), typeof(DockingWindow), new PropertyMetadata(WindowState.Normal));
				StateProperty = DependencyProperty.Register(vVK.ssH(8688), typeof(DockingWindowState), typeof(DockingWindow), new PropertyMetadata(DockingWindowState.Docked, kIj));
				TabFlashColorProperty = DependencyProperty.Register(vVK.ssH(8702), typeof(Color), typeof(DockingWindow), new PropertyMetadata(Color.FromArgb(128, byte.MaxValue, 160, 0)));
				TabFlashModeProperty = DependencyProperty.Register(vVK.ssH(8732), typeof(TabFlashMode), typeof(DockingWindow), new PropertyMetadata(TabFlashMode.None));
				TabbedMdiLayoutKindProperty = DependencyProperty.Register(vVK.ssH(8760), typeof(TabLayoutKind), typeof(DockingWindow), new PropertyMetadata(TabLayoutKind.Normal));
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 1:
				TabbedMdiTabContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(8802), typeof(DataTemplate), typeof(DockingWindow), new PropertyMetadata(new DataTemplate()));
				TabTextProperty = DependencyProperty.Register(vVK.ssH(8874), typeof(string), typeof(DockingWindow), new PropertyMetadata(null, xIZ));
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			}
			break;
		}
		goto IL_0005;
	}

	[CompilerGenerated]
	private void fIo(object P_0)
	{
		Activate();
	}

	[CompilerGenerated]
	private bool mIt(object P_0)
	{
		return Jku != null;
	}

	[CompilerGenerated]
	private void RIu(object P_0)
	{
		CloseAllInContainer();
	}

	[CompilerGenerated]
	private bool PIz(object P_0)
	{
		G0 g = MkZ();
		if (g != null)
		{
			if (g is ac { IsWrapper: not false, MdiHost: not null } ac)
			{
				return (from w in ac.MdiHost.GetDocuments()
					where w.CanCloseResolved
					select w).Any();
			}
			return g.Windows.Where((DockingWindow w) => w.CanCloseResolved).Any();
		}
		return false;
	}

	[CompilerGenerated]
	private void Eki(object P_0)
	{
		Close();
	}

	[CompilerGenerated]
	private bool Xkd(object P_0)
	{
		if (Jku != null && IsCurrentlyOpen)
		{
			return CanCloseResolved;
		}
		return false;
	}

	[CompilerGenerated]
	private void ckw(object P_0)
	{
		CloseOthers();
	}

	[CompilerGenerated]
	private bool Tk2(object P_0)
	{
		G0 g = MkZ();
		if (g == null)
		{
			return false;
		}
		if (!(g is ac { IsWrapper: not false, MdiHost: not null } ac))
		{
			return g.Windows.Where((DockingWindow dockingWindow) => dockingWindow != this && dockingWindow.CanCloseResolved).Any();
		}
		return (from dockingWindow in ac.MdiHost.GetDocuments()
			where dockingWindow != this && dockingWindow.CanCloseResolved
			select dockingWindow).Any();
	}

	[CompilerGenerated]
	private bool Tke(DockingWindow P_0)
	{
		if (P_0 != this)
		{
			return P_0.CanCloseResolved;
		}
		return false;
	}

	[CompilerGenerated]
	private bool vkG(DockingWindow P_0)
	{
		if (P_0 != this)
		{
			return P_0.CanCloseResolved;
		}
		return false;
	}

	[CompilerGenerated]
	private void ykI(object P_0)
	{
		Destroy();
	}

	[CompilerGenerated]
	private bool fkk(object P_0)
	{
		return Jku != null;
	}

	[CompilerGenerated]
	private void ekC(object P_0)
	{
		Float();
	}

	[CompilerGenerated]
	private bool uk1(object P_0)
	{
		DockHost dockHost = DockHost;
		if (dockHost != null && CanFloatResolved)
		{
			if (dockHost.xGd())
			{
				return true;
			}
			switch (State)
			{
			case DockingWindowState.AutoHide:
				return true;
			case DockingWindowState.Docked:
			{
				if (dockHost.LayoutKind != (kq)1)
				{
					return true;
				}
				DockingWindowContainerBase parentContainer = ParentContainer;
				if (parentContainer != null)
				{
					return parentContainer.WindowsCore.Count > 1;
				}
				return false;
			}
			case DockingWindowState.Document:
			{
				MdiHostBase mdiHost = dockHost.MdiHost;
				if (mdiHost != null)
				{
					return mdiHost.GetDocuments().Count > 1;
				}
				return false;
			}
			}
		}
		return false;
	}

	[CompilerGenerated]
	private void DkN(object P_0)
	{
		MoveToMdi(P_0 as DockHost);
	}

	[CompilerGenerated]
	private bool EkQ(object P_0)
	{
		bool flag = CanBecomeDocumentResolved && Jku != null && Jku.cQ4() != null;
		if (QkM() == DockingWindowState.Document)
		{
			if (flag)
			{
				return !IsCurrentlyOpen;
			}
			return false;
		}
		return flag;
	}

	[CompilerGenerated]
	private void jkm(object P_0)
	{
		MoveToNewHorizontalContainer();
	}

	[CompilerGenerated]
	private bool Lka(object P_0)
	{
		return CanMoveToNewHorizontalContainer;
	}

	[CompilerGenerated]
	private void IkW(object P_0)
	{
		MoveToNewVerticalContainer();
	}

	[CompilerGenerated]
	private bool bkB(object P_0)
	{
		return CanMoveToNewVerticalContainer;
	}

	[CompilerGenerated]
	private void qkK(object P_0)
	{
		MoveToNextContainer();
	}

	[CompilerGenerated]
	private bool FkJ(object P_0)
	{
		return CanMoveToNextContainer;
	}

	[CompilerGenerated]
	private void Ikn(object P_0)
	{
		MoveToPreviousContainer();
	}

	[CompilerGenerated]
	private bool KkO(object P_0)
	{
		return CanMoveToPreviousContainer;
	}

	[CompilerGenerated]
	private void VkT(object P_0)
	{
		if (Jku != null && Jku.cQ4() != null && (!IsCurrentlyOpen || QkM() != DockingWindowState.Document || DockHost != Jku.PrimaryDockHost))
		{
			MoveToMdi(Jku.PrimaryDockHost);
		}
	}

	[CompilerGenerated]
	private bool uk8(object P_0)
	{
		return CanMoveToPrimaryMdiHost;
	}

	[CompilerGenerated]
	private void dkD(object P_0)
	{
		Open();
	}

	[CompilerGenerated]
	private bool ikE(object P_0)
	{
		if (Jku != null)
		{
			return !IsCurrentlyOpen;
		}
		return false;
	}

	[CompilerGenerated]
	private void mkr(object P_0)
	{
		TabbedMdiLayoutKind = (P_0 as TabLayoutKind?).GetValueOrDefault();
	}

	internal static bool k1M()
	{
		return b1c == null;
	}

	internal static DockingWindow L1h()
	{
		return b1c;
	}
}
