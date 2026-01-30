using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

public abstract class SwitcherBase : Control
{
	private bool rr5;

	private ReadOnlyDockingWindowCollection sry;

	private DockingWindowCollection zro;

	private Popup drt;

	private ReadOnlyToolWindowCollection pru;

	private ToolWindowCollection Crz;

	public static readonly DependencyProperty DockSiteProperty;

	public static readonly DependencyProperty IsOpenProperty;

	public static readonly DependencyProperty SelectedWindowProperty;

	public static readonly DependencyProperty SelectNextDocumentKeyGestureProperty;

	public static readonly DependencyProperty SelectNextToolWindowKeyGestureProperty;

	public static readonly DependencyProperty SelectPreviousDocumentKeyGestureProperty;

	public static readonly DependencyProperty SelectPreviousToolWindowKeyGestureProperty;

	private static SwitcherBase cA1;

	public DockSite DockSite
	{
		get
		{
			return (DockSite)GetValue(DockSiteProperty);
		}
		private set
		{
			SetValue(DockSiteProperty, value);
		}
	}

	public ReadOnlyDockingWindowCollection Documents => sry;

	public bool IsOpen
	{
		get
		{
			return (bool)GetValue(IsOpenProperty);
		}
		private set
		{
			SetValue(IsOpenProperty, value);
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

	public ReadOnlyToolWindowCollection ToolWindows => pru;

	public KeyGesture SelectNextDocumentKeyGesture
	{
		get
		{
			return (KeyGesture)GetValue(SelectNextDocumentKeyGestureProperty);
		}
		set
		{
			SetValue(SelectNextDocumentKeyGestureProperty, value);
		}
	}

	public KeyGesture SelectNextToolWindowKeyGesture
	{
		get
		{
			return (KeyGesture)GetValue(SelectNextToolWindowKeyGestureProperty);
		}
		set
		{
			SetValue(SelectNextToolWindowKeyGestureProperty, value);
		}
	}

	public KeyGesture SelectPreviousDocumentKeyGesture
	{
		get
		{
			return (KeyGesture)GetValue(SelectPreviousDocumentKeyGestureProperty);
		}
		set
		{
			SetValue(SelectPreviousDocumentKeyGestureProperty, value);
		}
	}

	public KeyGesture SelectPreviousToolWindowKeyGesture
	{
		get
		{
			return (KeyGesture)GetValue(SelectPreviousToolWindowKeyGestureProperty);
		}
		set
		{
			SetValue(SelectPreviousToolWindowKeyGestureProperty, value);
		}
	}

	protected SwitcherBase(bool canSortByLastFocusedDateTime)
	{
		IVH.CecNqz();
		base._002Ector();
		rr5 = canSortByLastFocusedDateTime;
		zro = new DockingWindowCollection();
		sry = new ReadOnlyDockingWindowCollection(zro);
		Crz = new ToolWindowCollection();
		pru = new ReadOnlyToolWindowCollection(Crz);
	}

	private void xrj()
	{
		DockSite = null;
		zro.Clear();
		Crz.Clear();
		SelectedWindow = null;
	}

	private void TrZ()
	{
		if (drt != null && drt.IsOpen)
		{
			drt.IsOpen = false;
		}
	}

	private void Urb(object P_0, object P_1)
	{
		TrZ();
		if (IsOpen)
		{
			Close();
		}
	}

	private static void IrA(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((SwitcherBase)P_0).OnSelectedWindowChanged((DockingWindow)P_1.OldValue, (DockingWindow)P_1.NewValue);
	}

	private void zrH()
	{
		DockSite dockSite = DockSite;
		if (IsOpen || dockSite == null)
		{
			return;
		}
		zro.BeginUpdate();
		try
		{
			IEnumerable<DockingWindow> enumerable = dockSite.Documents;
			if (rr5)
			{
				enumerable = enumerable.OrderByDescending((DockingWindow w) => w.LastActiveDateTime);
			}
			zro.Clear();
			zro.AddRange(enumerable);
		}
		finally
		{
			zro.EndUpdate();
		}
		Crz.BeginUpdate();
		try
		{
			IEnumerable<ToolWindow> enumerable2 = dockSite.ToolWindows.Where((ToolWindow w) => w.IsCurrentlyOpen && w.QkM() != DockingWindowState.Document);
			if (rr5)
			{
				enumerable2 = enumerable2.OrderByDescending((ToolWindow w) => w.LastActiveDateTime);
			}
			Crz.Clear();
			Crz.AddRange(enumerable2);
		}
		finally
		{
			Crz.EndUpdate();
		}
		if (sry.Count + pru.Count == 0)
		{
			return;
		}
		DockingWindow activeWindow = dockSite.ActiveWindow;
		ToolWindow toolWindow;
		int num;
		if (activeWindow != null)
		{
			if (!sry.Contains(activeWindow))
			{
				toolWindow = activeWindow as ToolWindow;
				if (toolWindow != null)
				{
					num = 0;
					if (rAf() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_0288;
			}
			SelectedWindow = activeWindow;
		}
		else
		{
			SelectedWindow = sry.FirstOrDefault() ?? pru.FirstOrDefault();
		}
		goto IL_0161;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0161:
		IsOpen = true;
		OnOpened();
		return;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0266;
		}
		goto IL_0161;
		IL_0288:
		SelectedWindow = sry.FirstOrDefault() ?? pru.FirstOrDefault();
		num = 1;
		if (!mAH())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0266:
		if (pru.Contains(toolWindow))
		{
			SelectedWindow = activeWindow;
			goto IL_0161;
		}
		goto IL_0288;
	}

	internal void Jr0(DockSite P_0, KeyEventArgs P_1)
	{
		if (DockSite != null && DockSite != P_0)
		{
			Close();
		}
		if (!IsOpen)
		{
			DockSite = P_0;
			if (!IsActivationKey(P_1))
			{
				xrj();
				return;
			}
			zrH();
			int num = 0;
			if (rAf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		OnKeyDown(P_1);
		P_1.Handled = true;
	}

	internal void urh()
	{
		if (IsOpen && (Yp.aR4() & (ModifierKeys.Alt | ModifierKeys.Control)) == 0)
		{
			Close();
		}
	}

	public void Close()
	{
		if (IsOpen)
		{
			IsOpen = false;
			OnClosed();
			xrj();
		}
	}

	protected virtual Popup CreatePopup()
	{
		return new Popup
		{
			AllowsTransparency = true,
			Child = this,
			Placement = PlacementMode.Center,
			PlacementTarget = DockSite
		};
	}

	protected internal virtual bool IsActivationKey(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		ModifierKeys modifierKeys = Yp.aR4();
		Key key = ((e.Key == Key.System) ? e.SystemKey : e.Key);
		if (SelectNextDocumentKeyGesture != null && SelectNextDocumentKeyGesture.Key == key && SelectNextDocumentKeyGesture.Modifiers == modifierKeys)
		{
			return true;
		}
		if (SelectNextToolWindowKeyGesture != null && SelectNextToolWindowKeyGesture.Key == key)
		{
			int num = 0;
			if (rAf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (SelectNextToolWindowKeyGesture.Modifiers == modifierKeys)
			{
				return true;
			}
		}
		if (SelectPreviousDocumentKeyGesture != null && SelectPreviousDocumentKeyGesture.Key == key && SelectPreviousDocumentKeyGesture.Modifiers == modifierKeys)
		{
			return true;
		}
		if (SelectPreviousToolWindowKeyGesture != null && SelectPreviousToolWindowKeyGesture.Key == key && SelectPreviousToolWindowKeyGesture.Modifiers == modifierKeys)
		{
			return true;
		}
		return false;
	}

	protected virtual void OnClosed()
	{
		TrZ();
		DockingWindow selectedWindow = SelectedWindow;
		SelectedWindow = null;
		if (selectedWindow != null && !cP.NlZ(selectedWindow) && selectedWindow.DockSite != null)
		{
			selectedWindow.Activate();
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(vVK.ssH(3942));
		}
		ModifierKeys modifierKeys = Yp.aR4();
		Key key = ((e.Key == Key.System) ? e.SystemKey : e.Key);
		if (SelectNextDocumentKeyGesture != null && SelectNextDocumentKeyGesture.Key == key && SelectNextDocumentKeyGesture.Modifiers == modifierKeys)
		{
			SelectNextDocument();
			e.Handled = true;
		}
		else if (SelectNextToolWindowKeyGesture != null && SelectNextToolWindowKeyGesture.Key == key && SelectNextToolWindowKeyGesture.Modifiers == modifierKeys)
		{
			SelectNextToolWindow();
			e.Handled = true;
		}
		else if (SelectPreviousDocumentKeyGesture != null && SelectPreviousDocumentKeyGesture.Key == key && SelectPreviousDocumentKeyGesture.Modifiers == modifierKeys)
		{
			SelectPreviousDocument();
			e.Handled = true;
		}
		else if (SelectPreviousToolWindowKeyGesture != null && SelectPreviousToolWindowKeyGesture.Key == key && SelectPreviousToolWindowKeyGesture.Modifiers == modifierKeys)
		{
			SelectPreviousToolWindow();
			e.Handled = true;
		}
		base.OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		urh();
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		if (IsOpen && drt != null && !drt.IsFocused)
		{
			Close();
		}
	}

	protected virtual void OnOpened()
	{
		if (drt == null)
		{
			drt = CreatePopup();
			drt.Closed += Urb;
		}
		DockSite dockSite = DockSite;
		if (dockSite != null)
		{
			bool isDockGuideAnimationEnabled = dockSite.IsDockGuideAnimationEnabled;
			bool flag = false;
			zn.PxP(this, 0.2, isDockGuideAnimationEnabled, flag, _0020: false, 0.0, 0.92);
		}
		drt.IsOpen = true;
		Focus();
	}

	protected virtual void OnSelectedWindowChanged(DockingWindow oldValue, DockingWindow newValue)
	{
	}

	protected virtual void SelectNextDocument()
	{
		if (Documents.Count <= 0)
		{
			if (ToolWindows.Count > 0)
			{
				SelectNextToolWindow();
			}
			return;
		}
		int num = Documents.IndexOf(SelectedWindow) + 1;
		if (num > Documents.Count - 1)
		{
			num = 0;
		}
		SelectedWindow = Documents[num];
	}

	protected virtual void SelectNextToolWindow()
	{
		if (ToolWindows.Count <= 0)
		{
			if (Documents.Count > 0)
			{
				SelectNextDocument();
			}
			return;
		}
		ToolWindow value = SelectedWindow as ToolWindow;
		int num = ToolWindows.IndexOf(value) + 1;
		if (num > ToolWindows.Count - 1)
		{
			num = 0;
		}
		SelectedWindow = ToolWindows[num];
	}

	protected virtual void SelectPreviousDocument()
	{
		if (Documents.Count > 0)
		{
			int num = Documents.IndexOf(SelectedWindow) - 1;
			if (num < 0)
			{
				num = Documents.Count - 1;
			}
			SelectedWindow = Documents[num];
		}
		else if (ToolWindows.Count > 0)
		{
			SelectPreviousToolWindow();
		}
	}

	protected virtual void SelectPreviousToolWindow()
	{
		if (ToolWindows.Count <= 0)
		{
			if (Documents.Count > 0)
			{
				SelectPreviousDocument();
			}
			return;
		}
		ToolWindow value = SelectedWindow as ToolWindow;
		int num = ToolWindows.IndexOf(value) - 1;
		if (num < 0)
		{
			num = ToolWindows.Count - 1;
		}
		SelectedWindow = ToolWindows[num];
	}

	static SwitcherBase()
	{
		IVH.CecNqz();
		DockSiteProperty = DependencyProperty.Register(vVK.ssH(7352), typeof(DockSite), typeof(SwitcherBase), new PropertyMetadata(null));
		IsOpenProperty = DependencyProperty.Register(vVK.ssH(8328), typeof(bool), typeof(SwitcherBase), new PropertyMetadata(false));
		SelectedWindowProperty = DependencyProperty.Register(vVK.ssH(21272), typeof(DockingWindow), typeof(SwitcherBase), new PropertyMetadata(null, IrA));
		SelectNextDocumentKeyGestureProperty = DependencyProperty.Register(vVK.ssH(21680), typeof(KeyGesture), typeof(SwitcherBase), new PropertyMetadata(new KeyGesture(Key.Tab, ModifierKeys.Control)));
		SelectNextToolWindowKeyGestureProperty = DependencyProperty.Register(vVK.ssH(21740), typeof(KeyGesture), typeof(SwitcherBase), new PropertyMetadata(new KeyGesture(Key.F7, ModifierKeys.Alt)));
		SelectPreviousDocumentKeyGestureProperty = DependencyProperty.Register(vVK.ssH(21804), typeof(KeyGesture), typeof(SwitcherBase), new PropertyMetadata(new KeyGesture(Key.Tab, ModifierKeys.Control | ModifierKeys.Shift)));
		SelectPreviousToolWindowKeyGestureProperty = DependencyProperty.Register(vVK.ssH(21872), typeof(KeyGesture), typeof(SwitcherBase), new PropertyMetadata(new KeyGesture(Key.F7, ModifierKeys.Alt | ModifierKeys.Shift)));
	}

	internal static bool mAH()
	{
		return cA1 == null;
	}

	internal static SwitcherBase rAf()
	{
		return cA1;
	}
}
