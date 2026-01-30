using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

public abstract class MdiHostBase : Control
{
	private DockHost jEf;

	private DockSite SEU;

	public static readonly DependencyProperty IsEmptyProperty;

	public static readonly DependencyProperty PrimaryWindowProperty;

	public static readonly RoutedEvent PrimaryWindowChangedEvent;

	private static MdiHostBase cnW;

	public DockHost DockHost
	{
		get
		{
			return jEf;
		}
		internal set
		{
			if (jEf != value)
			{
				DockHost oldValue = jEf;
				jEf = value;
				DockSite = ((jEf != null) ? jEf.DockSite : null);
				VEs();
				OnDockHostChanged(oldValue, jEf);
			}
		}
	}

	public DockSite DockSite
	{
		get
		{
			return SEU;
		}
		internal set
		{
			if (SEU == value)
			{
				return;
			}
			if (SEU != null)
			{
				SEU.WindowActivated -= YEY;
			}
			SEU = value;
			if (SEU == null)
			{
				return;
			}
			SEU.WindowActivated += YEY;
			foreach (DockingWindow document in GetDocuments())
			{
				if (document != null)
				{
					document.DockSite = SEU;
				}
			}
		}
	}

	public bool IsEmpty
	{
		get
		{
			return (bool)GetValue(IsEmptyProperty);
		}
		protected set
		{
			SetValue(IsEmptyProperty, value);
		}
	}

	public DockingWindow PrimaryWindow
	{
		get
		{
			return (DockingWindow)GetValue(PrimaryWindowProperty);
		}
		internal set
		{
			SetValue(PrimaryWindowProperty, value);
		}
	}

	public event EventHandler<DockingWindowEventArgs> PrimaryWindowChanged
	{
		add
		{
			AddHandler(PrimaryWindowChangedEvent, value);
		}
		remove
		{
			RemoveHandler(PrimaryWindowChangedEvent, value);
		}
	}

	private void YEY(object P_0, DockingWindowEventArgs P_1)
	{
		DockingWindow dockingWindow = P_1?.Window;
		if (GetDocuments().Contains(dockingWindow))
		{
			PrimaryWindow = dockingWindow;
		}
	}

	private static void hEp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		MdiHostBase obj = (MdiHostBase)P_0;
		DockingWindow oldValue = P_1.OldValue as DockingWindow;
		DockingWindow dockingWindow = P_1.NewValue as DockingWindow;
		obj.OnPrimaryWindowChanged(oldValue, dockingWindow);
		obj.rEq(dockingWindow);
	}

	private void VEs()
	{
		DockingWindowState dockingWindowState = DockingWindowState.Document;
		IList<DockingWindow> documents = GetDocuments();
		if (documents == null)
		{
			return;
		}
		foreach (DockingWindow item in documents)
		{
			if (item != null && item.QkM() != dockingWindowState)
			{
				item.zIH(dockingWindowState);
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public abstract IList<DockingWindow> GetDocuments();

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		DockSite = ((jEf != null) ? jEf.DockSite : null);
		VEs();
	}

	protected virtual void OnDockHostChanged(DockHost oldValue, DockHost newValue)
	{
	}

	protected virtual void OnPrimaryWindowChanged(DockingWindow oldValue, DockingWindow newValue)
	{
	}

	internal void rEq(DockingWindow P_0)
	{
		DockingWindowEventArgs e = new DockingWindowEventArgs
		{
			RoutedEvent = PrimaryWindowChangedEvent,
			Source = this,
			Window = P_0
		};
		RaiseEvent(e);
	}

	protected MdiHostBase()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	static MdiHostBase()
	{
		IVH.CecNqz();
		IsEmptyProperty = DependencyProperty.Register(vVK.ssH(21356), typeof(bool), typeof(MdiHostBase), new PropertyMetadata(true));
		PrimaryWindowProperty = DependencyProperty.Register(vVK.ssH(21374), typeof(DockingWindow), typeof(MdiHostBase), new PropertyMetadata(null, hEp));
		PrimaryWindowChangedEvent = EventManager.RegisterRoutedEvent(vVK.ssH(21404), RoutingStrategy.Bubble, typeof(EventHandler<DockingWindowEventArgs>), typeof(MdiHostBase));
	}

	internal static bool XnI()
	{
		return cnW == null;
	}

	internal static MdiHostBase Rna()
	{
		return cnW;
	}
}
