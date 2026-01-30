using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
public class Workspace : ContentControl, iy, IDockTarget, wH, lX
{
	private DockHost YJh;

	private Size QJg;

	private static Workspace EHT;

	public DockHost DockHost
	{
		get
		{
			return YJh;
		}
		private set
		{
			if (YJh == value)
			{
				return;
			}
			if (YJh != null && YJh.Workspace == this)
			{
				YJh.Workspace = null;
			}
			YJh = value;
			if (YJh != null)
			{
				YJh.Workspace = this;
			}
			if (base.Content is wH wH)
			{
				int num = 0;
				if (jHR() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				wH.DockHost = value;
			}
		}
	}

	public DockSite DockSite
	{
		get
		{
			if (YJh == null)
			{
				return null;
			}
			return YJh.DockSite;
		}
	}

	bool iy.HasDockGuides => qJb() == null;

	bool iy.RequiresReverseOrderInsertion => false;

	bool wH.ContainsDockingWindows => qJb()?.ContainsDockingWindows ?? false;

	bool wH.ContainsWorkspace => true;

	Size wH.DockedSize
	{
		get
		{
			return QJg;
		}
		set
		{
			QJg = value;
			if (base.Content is wH wH)
			{
				wH.DockedSize = QJg;
			}
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

	Size wH.MaxSize
	{
		get
		{
			if (base.Content is wH wH)
			{
				return wH.MaxSize;
			}
			return new Size(double.PositiveInfinity, double.PositiveInfinity);
		}
	}

	Size wH.MinSize
	{
		get
		{
			if (base.Content is wH { MinSize: var minSize })
			{
				return new Size(Math.Max(base.MinWidth, minSize.Width), Math.Max(base.MinHeight, minSize.Height));
			}
			return new Size(base.MinWidth, base.MinHeight);
		}
	}

	IEnumerable<lX> lX.ChildNodes
	{
		get
		{
			if (base.Content is lX lX)
			{
				yield return lX;
			}
		}
	}

	public Workspace()
	{
		IVH.CecNqz();
		QJg = new Size(200.0, 200.0);
		base._002Ector();
		base.DefaultStyleKey = typeof(Workspace);
	}

	[SpecialName]
	internal jJ qJb()
	{
		return base.Content as jJ;
	}

	[SpecialName]
	internal void oJA(jJ value)
	{
		base.Content = value;
	}

	protected override void OnContentChanged(object oldContent, object newContent)
	{
		base.OnContentChanged(oldContent, newContent);
		DockSite dockSite = DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().TM5(YJh, oldContent as jJ, newContent as jJ);
			dockSite.fN6();
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new WorkspaceAutomationPeer(this);
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
		return true;
	}

	int wH.GetVisibleToolWindowContainerCount()
	{
		return 0;
	}

	internal static bool rHx()
	{
		return EHT == null;
	}

	internal static Workspace jHR()
	{
		return EHT;
	}
}
