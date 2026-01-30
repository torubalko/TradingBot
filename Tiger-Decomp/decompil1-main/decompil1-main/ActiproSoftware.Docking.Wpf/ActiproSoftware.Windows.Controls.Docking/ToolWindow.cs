using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
public class ToolWindow : DockingWindow
{
	private DelegateCommand<object> wBY;

	private DelegateCommand<object> TBp;

	public static readonly DependencyProperty AutoHideTabContextContentTemplateProperty;

	public static readonly DependencyProperty CanAutoHideProperty;

	public static readonly DependencyProperty CanAutoHideResolvedProperty;

	public static readonly DependencyProperty CanBecomeDocumentProperty;

	public static readonly DependencyProperty ContainerAutoHideSizeProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "DockSide")]
	public static readonly DependencyProperty DefaultDockSideProperty;

	public static readonly DependencyProperty HasOptionsButtonProperty;

	public static readonly DependencyProperty HasOptionsButtonResolvedProperty;

	public static readonly DependencyProperty HasTitleBarProperty;

	public static readonly DependencyProperty HasTitleBarResolvedProperty;

	public static readonly DependencyProperty IsAutoHidePopupOpenProperty;

	public static readonly DependencyProperty ToolWindowContainerTabContextContentTemplateProperty;

	public static readonly DependencyProperty ToolWindowContainerTitleBarContextContentTemplateProperty;

	internal static ToolWindow KHP;

	private bool AutoHidePerContainer => base.DockSite?.AutoHidePerContainer ?? true;

	public ICommand AutoHideCommand => wBY;

	public DataTemplate AutoHideTabContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(AutoHideTabContextContentTemplateProperty);
		}
		set
		{
			SetValue(AutoHideTabContextContentTemplateProperty, value);
		}
	}

	public bool? CanAutoHide
	{
		get
		{
			return (bool?)GetValue(CanAutoHideProperty);
		}
		set
		{
			SetValue(CanAutoHideProperty, value);
		}
	}

	public bool CanAutoHideResolved
	{
		get
		{
			return (bool)GetValue(CanAutoHideResolvedProperty);
		}
		private set
		{
			SetValue(CanAutoHideResolvedProperty, value);
		}
	}

	public bool? CanBecomeDocument
	{
		get
		{
			return (bool?)GetValue(CanBecomeDocumentProperty);
		}
		set
		{
			SetValue(CanBecomeDocumentProperty, value);
		}
	}

	public Size ContainerAutoHideSize
	{
		get
		{
			return (Size)GetValue(ContainerAutoHideSizeProperty);
		}
		set
		{
			SetValue(ContainerAutoHideSizeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "DockSide")]
	public Side DefaultDockSide
	{
		get
		{
			return (Side)GetValue(DefaultDockSideProperty);
		}
		set
		{
			SetValue(DefaultDockSideProperty, value);
		}
	}

	public ICommand DockCommand => TBp;

	public bool? HasOptionsButton
	{
		get
		{
			return (bool?)GetValue(HasOptionsButtonProperty);
		}
		set
		{
			SetValue(HasOptionsButtonProperty, value);
		}
	}

	public bool HasOptionsButtonResolved
	{
		get
		{
			return (bool)GetValue(HasOptionsButtonResolvedProperty);
		}
		private set
		{
			SetValue(HasOptionsButtonResolvedProperty, value);
		}
	}

	public bool? HasTitleBar
	{
		get
		{
			return (bool?)GetValue(HasTitleBarProperty);
		}
		set
		{
			SetValue(HasTitleBarProperty, value);
		}
	}

	public bool HasTitleBarResolved
	{
		get
		{
			return (bool)GetValue(HasTitleBarResolvedProperty);
		}
		private set
		{
			SetValue(HasTitleBarResolvedProperty, value);
		}
	}

	public bool IsAutoHidePopupOpen
	{
		get
		{
			return (bool)GetValue(IsAutoHidePopupOpenProperty);
		}
		internal set
		{
			SetValue(IsAutoHidePopupOpenProperty, value);
		}
	}

	public DataTemplate ToolWindowContainerTabContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ToolWindowContainerTabContextContentTemplateProperty);
		}
		set
		{
			SetValue(ToolWindowContainerTabContextContentTemplateProperty, value);
		}
	}

	public DataTemplate ToolWindowContainerTitleBarContextContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ToolWindowContainerTitleBarContextContentTemplateProperty);
		}
		set
		{
			SetValue(ToolWindowContainerTitleBarContextContentTemplateProperty, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ToolWindow()
	{
		IVH.CecNqz();
		this._002Ector(null);
	}

	public ToolWindow(DockSite dockSite)
	{
		IVH.CecNqz();
		this._002Ector(dockSite, null, null, null, null);
	}

	public ToolWindow(DockSite dockSite, string serializationId, string title, ImageSource imageSource, object content)
	{
		IVH.CecNqz();
		this._002Ector(isContainerForItem: false);
		if (serializationId != null)
		{
			base.SerializationId = serializationId;
		}
		if (title != null)
		{
			base.Title = title;
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (imageSource != null)
		{
			base.ImageSource = imageSource;
		}
		if (content != null)
		{
			base.Content = content;
		}
		dockSite?.vNp(this, _0020: false);
	}

	public ToolWindow(bool isContainerForItem)
	{
		IVH.CecNqz();
		base._002Ector(isContainerForItem);
		base.DefaultStyleKey = typeof(ToolWindow);
		zBQ();
	}

	private void bBN(Side? P_0)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().AutoHide(this, P_0);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	[SpecialName]
	internal Side? uBl()
	{
		return DBR()?.xKI();
	}

	[SpecialName]
	internal Size iBv()
	{
		Size containerAutoHideSize = ContainerAutoHideSize;
		return new Size(Math.Max(0.0, containerAutoHideSize.Width), Math.Max(0.0, containerAutoHideSize.Height));
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void zBQ()
	{
		wBY = new DelegateCommand<object>(delegate(object P_0)
		{
			if (QkM() != DockingWindowState.AutoHide && AutoHidePerContainer)
			{
				ToolWindowContainer toolWindowContainer = DBR();
				if (toolWindowContainer != null && toolWindowContainer.AutoHideCommand != null && toolWindowContainer.AutoHideCommand.CanExecute(P_0))
				{
					toolWindowContainer.AutoHideCommand.Execute(P_0);
					return;
				}
			}
			AutoHide();
		}, delegate
		{
			switch (QkM())
			{
			case DockingWindowState.AutoHide:
				if (CanAutoHideResolved)
				{
					return !base.IsCurrentlyOpen;
				}
				return false;
			case DockingWindowState.Docked:
			{
				DockHost dockHost = base.DockHost;
				if (dockHost != null && dockHost.Meg())
				{
					kq kq = dockHost.LayoutKind;
					if ((uint)kq <= 2u)
					{
						return false;
					}
				}
				return CanAutoHideResolved;
			}
			default:
				return false;
			}
		});
		TBp = new DelegateCommand<object>(delegate(object P_0)
		{
			if (QkM() == DockingWindowState.AutoHide && AutoHidePerContainer)
			{
				ToolWindowContainer toolWindowContainer = DBR();
				if (toolWindowContainer != null && toolWindowContainer.DockCommand != null && toolWindowContainer.DockCommand.CanExecute(P_0))
				{
					toolWindowContainer.DockCommand.Execute(P_0);
					return;
				}
			}
			Dock();
		}, delegate
		{
			if (QkM() == DockingWindowState.Docked)
			{
				if (base.CanDockResolved)
				{
					if (!base.IsCurrentlyOpen)
					{
						return true;
					}
					DockHost dockHost = base.DockHost;
					if (dockHost != null && dockHost.Meg())
					{
						kq kq = dockHost.LayoutKind;
						if ((uint)(kq - 1) <= 1u)
						{
							return true;
						}
					}
				}
				return false;
			}
			return base.CanDockResolved;
		});
	}

	private static IList<Tuple<SplitContainer, int>> zBm(DependencyObject P_0)
	{
		List<Tuple<SplitContainer, int>> list = new List<Tuple<SplitContainer, int>>();
		while (P_0 != null)
		{
			DependencyObject parent = VisualTreeHelper.GetParent(P_0);
			if (parent is SplitContainerPanel)
			{
				parent = VisualTreeHelper.GetParent(parent);
			}
			if (parent is DockHost)
			{
				break;
			}
			if (parent is SplitContainer splitContainer)
			{
				int item = splitContainer.Children.IndexOf(P_0 as FrameworkElement);
				list.Insert(0, Tuple.Create(splitContainer, item));
			}
			P_0 = parent;
		}
		return list;
	}

	private static void CBa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindow)P_0).zBn();
	}

	private static void xBW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindow)P_0).UpdateCanBecomeDocumentResolved();
	}

	private static void eBB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ToolWindow obj = (ToolWindow)P_0;
		obj.UpdateCommands();
		obj.DBR()?.CDs();
	}

	private static void sBK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindow)P_0).CBO();
	}

	private static void HBJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((ToolWindow)P_0).rBT();
	}

	[SpecialName]
	internal ToolWindowContainer DBR()
	{
		return MkZ() as ToolWindowContainer;
	}

	internal void zBn()
	{
		if (CanAutoHide.HasValue)
		{
			CanAutoHideResolved = CanAutoHide.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite == null)
		{
			CanAutoHideResolved = true;
		}
		else
		{
			CanAutoHideResolved = dockSite.CanToolWindowsAutoHide;
		}
	}

	internal void CBO()
	{
		if (HasOptionsButton.HasValue)
		{
			HasOptionsButtonResolved = HasOptionsButton.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			HasOptionsButtonResolved = dockSite.ToolWindowsHaveOptionsButtons;
		}
		else
		{
			HasOptionsButtonResolved = true;
		}
	}

	internal void rBT()
	{
		if (HasTitleBar.HasValue)
		{
			HasTitleBarResolved = HasTitleBar.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			HasTitleBarResolved = dockSite.ToolWindowsHaveTitleBars;
		}
		else
		{
			HasTitleBarResolved = true;
		}
	}

	public void Attach(IDockTarget target)
	{
		if (target == null)
		{
			throw new ArgumentNullException(vVK.ssH(9148));
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().evd(this, target.GetState(null), target);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public void AutoHide()
	{
		bBN(null);
	}

	public void AutoHide(Side side)
	{
		bBN(side);
	}

	public void Dock()
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().evd(this, DockingWindowState.Docked, null);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public void Dock(IDockTarget target, Side side)
	{
		if (target == null)
		{
			throw new ArgumentNullException(vVK.ssH(9148));
		}
		if (target.GetState(side) == DockingWindowState.AutoHide)
		{
			throw new ArgumentException(vVK.ssH(17096), vVK.ssH(9148));
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().Evi(this, target, side);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	public override void Float(Point? location, Size? size)
	{
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().Sve(new ToolWindow[1] { this }, location, size);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public Side? GetCurrentSide()
	{
		if (base.IsCurrentlyOpen)
		{
			FrameworkElement frameworkElement = null;
			DockHost dockHost = null;
			ToolWindowContainer toolWindowContainer = DBR();
			if (toolWindowContainer == null)
			{
				return null;
			}
			Side? side = toolWindowContainer.xKI();
			if (side.HasValue)
			{
				return side.Value;
			}
			frameworkElement = toolWindowContainer;
			dockHost = toolWindowContainer.DockHost;
			if (frameworkElement != null && dockHost != null)
			{
				IList<Tuple<SplitContainer, int>> list = zBm(frameworkElement);
				IList<Tuple<SplitContainer, int>> list2 = zBm(dockHost.Workspace);
				SplitContainer splitContainer = null;
				int num = 0;
				int num2 = 0;
				for (int i = 0; i < list.Count && i < list2.Count && list[i].Item1 == list2[i].Item1; i++)
				{
					splitContainer = list[i].Item1;
					num = list[i].Item2;
					num2 = list2[i].Item2;
				}
				if (splitContainer == null && list.Count > 0)
				{
					foreach (Tuple<SplitContainer, int> item in list)
					{
						splitContainer = item.Item1;
						num = item.Item2;
						if ((splitContainer.Orientation == Orientation.Horizontal && splitContainer.Children[num].ActualWidth < splitContainer.ActualWidth / 2.0) || (splitContainer.Orientation == Orientation.Vertical && splitContainer.Children[num].ActualHeight < splitContainer.ActualHeight / 2.0))
						{
							break;
						}
						splitContainer = null;
					}
					if (splitContainer == null)
					{
						int i = list.Count - 1;
						splitContainer = list[i].Item1;
						num = list[i].Item2;
					}
					if (splitContainer != null && num >= 0 && num < splitContainer.Children.Count)
					{
						frameworkElement = splitContainer.Children[num];
						if (frameworkElement != null)
						{
							Rect rect = new Rect(0.0, 0.0, frameworkElement.ActualWidth, frameworkElement.ActualHeight);
							rect = frameworkElement.TransformToVisual(dockHost).TransformBounds(rect);
							Rect rect2 = new Rect(0.0, 0.0, dockHost.ActualWidth, dockHost.ActualHeight);
							if (splitContainer.Orientation == Orientation.Horizontal)
							{
								double num3 = rect.Left + rect.Width / 2.0;
								double num4 = rect2.Left + rect2.Width / 2.0;
								return (!(num3 < num4)) ? Side.Right : Side.Left;
							}
							double num5 = rect.Top + rect.Height / 2.0;
							double num6 = rect2.Top + rect2.Height / 2.0;
							return (num5 < num6) ? Side.Top : Side.Bottom;
						}
					}
				}
				if (splitContainer != null)
				{
					if (splitContainer.Orientation == Orientation.Horizontal)
					{
						return (num >= num2) ? Side.Right : Side.Left;
					}
					return (num < num2) ? Side.Top : Side.Bottom;
				}
			}
		}
		return null;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new ToolWindowAutomationPeer(this);
	}

	protected override void OnDockSiteChanged(DockSite oldValue, DockSite newValue)
	{
		zBn();
		CBO();
		rBT();
		base.OnDockSiteChanged(oldValue, newValue);
	}

	protected override void OnStateChanged(DockingWindowState oldValue, DockingWindowState newValue)
	{
		base.OnStateChanged(oldValue, newValue);
		if (Vk9() || oldValue == newValue || !base.IsCurrentlyOpen)
		{
			return;
		}
		switch (newValue)
		{
		case DockingWindowState.AutoHide:
		{
			int num = 0;
			if (!oHe())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				AutoHide();
				break;
			}
			break;
		}
		case DockingWindowState.Docked:
			Dock();
			break;
		default:
			MoveToMdi();
			break;
		}
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, vVK.ssH(17194), new object[3]
		{
			GetType().Name,
			base.Title,
			base.State
		});
	}

	protected internal override void UpdateCanAttachResolved()
	{
		int num = 1;
		bool? canAttach = default(bool?);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (!canAttach.HasValue)
					{
						TabbedMdiHost tabbedMdiHost = ((MkZ() is TabbedMdiContainer tabbedMdiContainer) ? tabbedMdiContainer.hWg() : null);
						if (tabbedMdiHost != null)
						{
							base.CanAttachResolved = tabbedMdiHost.CanDocumentsAttach;
							return;
						}
						DockSite dockSite = base.DockSite;
						if (dockSite == null)
						{
							base.CanAttachResolved = true;
						}
						else
						{
							base.CanAttachResolved = dockSite.CanToolWindowsAttach;
						}
					}
					else
					{
						base.CanAttachResolved = base.CanAttach.Value;
					}
					return;
				case 1:
					break;
				}
				canAttach = base.CanAttach;
				num2 = 0;
			}
			while (oHe());
		}
	}

	protected internal override void UpdateCanBecomeDocumentResolved()
	{
		if (CanBecomeDocument.HasValue)
		{
			base.CanBecomeDocumentResolved = CanBecomeDocument.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite == null)
		{
			base.CanBecomeDocumentResolved = true;
		}
		else
		{
			base.CanBecomeDocumentResolved = dockSite.CanToolWindowsBecomeDocuments;
		}
	}

	protected internal override void UpdateCanCloseResolved()
	{
		if (!base.CanClose.HasValue)
		{
			DockSite dockSite = base.DockSite;
			if (dockSite != null)
			{
				base.CanCloseResolved = dockSite.CanToolWindowsClose;
			}
			else
			{
				base.CanCloseResolved = true;
			}
		}
		else
		{
			base.CanCloseResolved = base.CanClose.Value;
		}
	}

	protected internal override void UpdateCanDockResolved()
	{
		if (base.CanDock.HasValue)
		{
			base.CanDockResolved = base.CanDock.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			base.CanDockResolved = dockSite.CanToolWindowsDock;
		}
		else
		{
			base.CanDockResolved = true;
		}
	}

	protected internal override void UpdateCanDragTabResolved()
	{
		if (base.CanDragTab.HasValue)
		{
			base.CanDragTabResolved = base.CanDragTab.Value;
			return;
		}
		TabbedMdiHost tabbedMdiHost = ((MkZ() is TabbedMdiContainer tabbedMdiContainer) ? tabbedMdiContainer.hWg() : null);
		if (tabbedMdiHost != null)
		{
			base.CanDragTabResolved = tabbedMdiHost.CanDocumentTabsDrag;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			base.CanDragTabResolved = dockSite.CanToolWindowTabsDrag;
		}
		else
		{
			base.CanDragTabResolved = true;
		}
	}

	protected internal override void UpdateCanDragToLinkedDockSitesResolved()
	{
		if (base.CanDragToLinkedDockSites.HasValue)
		{
			base.CanDragToLinkedDockSitesResolved = base.CanDragToLinkedDockSites.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			base.CanDragToLinkedDockSitesResolved = dockSite.CanToolWindowsDragToLinkedDockSites;
		}
		else
		{
			base.CanDragToLinkedDockSitesResolved = true;
		}
	}

	protected internal override void UpdateCanFloatResolved()
	{
		if (base.CanFloat.HasValue)
		{
			base.CanFloatResolved = base.CanFloat.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite == null)
		{
			base.CanFloatResolved = true;
		}
		else
		{
			base.CanFloatResolved = dockSite.CanToolWindowsFloat;
		}
	}

	protected internal override void UpdateCommands()
	{
		base.UpdateCommands();
		wBY.RaiseCanExecuteChanged();
		TBp.RaiseCanExecuteChanged();
	}

	static ToolWindow()
	{
		IVH.CecNqz();
		AutoHideTabContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(17248), typeof(DataTemplate), typeof(ToolWindow), new PropertyMetadata(new DataTemplate()));
		CanAutoHideProperty = DependencyProperty.Register(vVK.ssH(17318), typeof(bool?), typeof(ToolWindow), new PropertyMetadata(null, CBa));
		CanAutoHideResolvedProperty = DependencyProperty.Register(vVK.ssH(17344), typeof(bool), typeof(ToolWindow), new PropertyMetadata(true, eBB));
		CanBecomeDocumentProperty = DependencyProperty.Register(vVK.ssH(17386), typeof(bool?), typeof(ToolWindow), new PropertyMetadata(null, xBW));
		ContainerAutoHideSizeProperty = DependencyProperty.Register(vVK.ssH(17424), typeof(Size), typeof(ToolWindow), new PropertyMetadata(new Size(200.0, 200.0)));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		DefaultDockSideProperty = DependencyProperty.Register(vVK.ssH(17470), typeof(Side), typeof(ToolWindow), new PropertyMetadata(Side.Right));
		HasOptionsButtonProperty = DependencyProperty.Register(vVK.ssH(17504), typeof(bool?), typeof(ToolWindow), new PropertyMetadata(null, sBK));
		HasOptionsButtonResolvedProperty = DependencyProperty.Register(vVK.ssH(17540), typeof(bool), typeof(ToolWindow), new PropertyMetadata(true, eBB));
		HasTitleBarProperty = DependencyProperty.Register(vVK.ssH(17592), typeof(bool?), typeof(ToolWindow), new PropertyMetadata(null, HBJ));
		HasTitleBarResolvedProperty = DependencyProperty.Register(vVK.ssH(17618), typeof(bool), typeof(ToolWindow), new PropertyMetadata(true));
		IsAutoHidePopupOpenProperty = DependencyProperty.Register(vVK.ssH(17660), typeof(bool), typeof(ToolWindow), new PropertyMetadata(false));
		ToolWindowContainerTabContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(17702), typeof(DataTemplate), typeof(ToolWindow), new PropertyMetadata(new DataTemplate()));
		ToolWindowContainerTitleBarContextContentTemplateProperty = DependencyProperty.Register(vVK.ssH(17794), typeof(DataTemplate), typeof(ToolWindow), new PropertyMetadata(new DataTemplate()));
	}

	[CompilerGenerated]
	private void WB8(object P_0)
	{
		if (QkM() != DockingWindowState.AutoHide && AutoHidePerContainer)
		{
			ToolWindowContainer toolWindowContainer = DBR();
			if (toolWindowContainer != null && toolWindowContainer.AutoHideCommand != null && toolWindowContainer.AutoHideCommand.CanExecute(P_0))
			{
				toolWindowContainer.AutoHideCommand.Execute(P_0);
				return;
			}
		}
		AutoHide();
	}

	[CompilerGenerated]
	private bool lBD(object P_0)
	{
		switch (QkM())
		{
		case DockingWindowState.AutoHide:
			if (CanAutoHideResolved)
			{
				return !base.IsCurrentlyOpen;
			}
			return false;
		case DockingWindowState.Docked:
		{
			DockHost dockHost = base.DockHost;
			if (dockHost != null && dockHost.Meg())
			{
				kq kq = dockHost.LayoutKind;
				if ((uint)kq <= 2u)
				{
					return false;
				}
			}
			return CanAutoHideResolved;
		}
		default:
			return false;
		}
	}

	[CompilerGenerated]
	private void UBE(object P_0)
	{
		if (QkM() == DockingWindowState.AutoHide && AutoHidePerContainer)
		{
			ToolWindowContainer toolWindowContainer = DBR();
			if (toolWindowContainer != null && toolWindowContainer.DockCommand != null && toolWindowContainer.DockCommand.CanExecute(P_0))
			{
				toolWindowContainer.DockCommand.Execute(P_0);
				return;
			}
		}
		Dock();
	}

	[CompilerGenerated]
	private bool NBr(object P_0)
	{
		if (QkM() == DockingWindowState.Docked)
		{
			if (base.CanDockResolved)
			{
				if (!base.IsCurrentlyOpen)
				{
					return true;
				}
				DockHost dockHost = base.DockHost;
				if (dockHost != null && dockHost.Meg())
				{
					kq kq = dockHost.LayoutKind;
					if ((uint)(kq - 1) <= 1u)
					{
						return true;
					}
				}
			}
			return false;
		}
		return base.CanDockResolved;
	}

	internal static bool oHe()
	{
		return KHP == null;
	}

	internal static ToolWindow PHJ()
	{
		return KHP;
	}
}
