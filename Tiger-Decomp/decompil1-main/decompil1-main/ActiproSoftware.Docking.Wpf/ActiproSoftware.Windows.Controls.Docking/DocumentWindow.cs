using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
public class DocumentWindow : DockingWindow
{
	public static readonly DependencyProperty FileNameProperty;

	public static readonly DependencyProperty IsReadOnlyProperty;

	internal static DocumentWindow G1b;

	[Localizability(LocalizationCategory.NeverLocalize)]
	public string FileName
	{
		get
		{
			return (string)GetValue(FileNameProperty);
		}
		set
		{
			SetValue(FileNameProperty, value);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (bool)GetValue(IsReadOnlyProperty);
		}
		set
		{
			SetValue(IsReadOnlyProperty, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public DocumentWindow()
	{
		IVH.CecNqz();
		this._002Ector(null);
	}

	public DocumentWindow(DockSite dockSite)
	{
		IVH.CecNqz();
		this._002Ector(dockSite, null, null, null, null);
	}

	public DocumentWindow(DockSite dockSite, string serializationId, string title, ImageSource imageSource, object content)
	{
		IVH.CecNqz();
		this._002Ector(isContainerForItem: false);
		if (serializationId != null)
		{
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			base.SerializationId = serializationId;
		}
		if (title != null)
		{
			base.Title = title;
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

	public DocumentWindow(bool isContainerForItem)
	{
		IVH.CecNqz();
		base._002Ector(isContainerForItem);
		base.DefaultStyleKey = typeof(DocumentWindow);
		zIH(DockingWindowState.Document);
	}

	public void Attach(IDockTarget target)
	{
		if (target == null)
		{
			throw new ArgumentNullException(vVK.ssH(9148));
		}
		if (!(target is DocumentWindow) && !(target is TabbedMdiContainer))
		{
			throw new ArgumentOutOfRangeException(vVK.ssH(9148));
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			dockSite.s1t().Nv1(this, target);
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
		if (!(target is DocumentWindow) && !(target is TabbedMdiContainer))
		{
			throw new ArgumentOutOfRangeException(vVK.ssH(9148));
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
			dockSite.s1t().gv2(this, location, size);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExDockingWindowNoDockSiteRegistered));
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new DocumentWindowAutomationPeer(this);
	}

	protected override void OnStateChanged(DockingWindowState oldValue, DockingWindowState newValue)
	{
		if (newValue != DockingWindowState.Document)
		{
			throw new ArgumentOutOfRangeException(vVK.ssH(15238));
		}
		base.OnStateChanged(oldValue, newValue);
	}

	protected internal override void UpdateCanAttachResolved()
	{
		if (base.CanAttach.HasValue)
		{
			base.CanAttachResolved = base.CanAttach.Value;
			return;
		}
		TabbedMdiHost tabbedMdiHost = ((MkZ() is TabbedMdiContainer tabbedMdiContainer) ? tabbedMdiContainer.hWg() : null);
		if (tabbedMdiHost != null)
		{
			base.CanAttachResolved = tabbedMdiHost.CanDocumentsAttach;
			int num = 0;
			if (!B1T())
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
		else
		{
			base.CanAttachResolved = true;
		}
	}

	protected internal override void UpdateCanCloseResolved()
	{
		if (base.CanClose.HasValue)
		{
			base.CanCloseResolved = base.CanClose.Value;
			return;
		}
		DockSite dockSite = base.DockSite;
		if (dockSite != null)
		{
			base.CanCloseResolved = dockSite.CanDocumentWindowsClose;
		}
		else
		{
			base.CanCloseResolved = true;
		}
	}

	protected internal override void UpdateCanDockResolved()
	{
		if (base.CanDock.HasValue)
		{
			base.CanDockResolved = base.CanDock.Value;
			return;
		}
		TabbedMdiHost tabbedMdiHost = ((MkZ() is TabbedMdiContainer tabbedMdiContainer) ? tabbedMdiContainer.hWg() : null);
		if (tabbedMdiHost != null)
		{
			base.CanDockResolved = tabbedMdiHost.CanDocumentsDock;
		}
		else
		{
			base.CanDockResolved = true;
		}
	}

	protected internal override void UpdateCanDragTabResolved()
	{
		if (!base.CanDragTab.HasValue)
		{
			TabbedMdiHost tabbedMdiHost = ((MkZ() is TabbedMdiContainer tabbedMdiContainer) ? tabbedMdiContainer.hWg() : null);
			if (tabbedMdiHost != null)
			{
				base.CanDragTabResolved = tabbedMdiHost.CanDocumentTabsDrag;
				int num = 0;
				if (!B1T())
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
			else
			{
				base.CanDragTabResolved = true;
			}
		}
		else
		{
			base.CanDragTabResolved = base.CanDragTab.Value;
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
			base.CanDragToLinkedDockSitesResolved = dockSite.CanDocumentWindowsDragToLinkedDockSites;
		}
		else
		{
			base.CanDragToLinkedDockSitesResolved = true;
		}
	}

	protected internal override void UpdateCanFloatResolved()
	{
		if (!base.CanFloat.HasValue)
		{
			DockSite dockSite = base.DockSite;
			if (dockSite == null)
			{
				base.CanFloatResolved = true;
			}
			else
			{
				base.CanFloatResolved = dockSite.CanDocumentWindowsFloat;
			}
		}
		else
		{
			base.CanFloatResolved = base.CanFloat.Value;
		}
	}

	static DocumentWindow()
	{
		IVH.CecNqz();
		FileNameProperty = DependencyProperty.Register(vVK.ssH(15258), typeof(string), typeof(DocumentWindow), new PropertyMetadata(null));
		IsReadOnlyProperty = DependencyProperty.Register(vVK.ssH(6330), typeof(bool), typeof(DocumentWindow), new PropertyMetadata(false));
	}

	internal static bool B1T()
	{
		return G1b == null;
	}

	internal static DocumentWindow F1x()
	{
		return G1b;
	}
}
