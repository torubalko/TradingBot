using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Windows.Serialization;

namespace ActiproSoftware.Windows.Controls.Docking.Serialization;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public class DockSiteLayoutSerializer : XmlSerializerBase<DockSite, XmlDockSiteLayout>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public XmlToolWindow R3p;

		internal static _003C_003Ec__DisplayClass8_0 zcl;

		public _003C_003Ec__DisplayClass8_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool a3Y(ToolWindow w)
		{
			return w.SerializationId == R3p.SerializationId;
		}

		internal static bool zc9()
		{
			return zcl == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 Fcm()
		{
			return zcl;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public XmlDocumentWindow c3q;

		private static _003C_003Ec__DisplayClass8_1 Kco;

		public _003C_003Ec__DisplayClass8_1()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool N3s(DocumentWindow w)
		{
			return w.SerializationId == c3q.SerializationId;
		}

		internal static bool XcB()
		{
			return Kco == null;
		}

		internal static _003C_003Ec__DisplayClass8_1 Pc5()
		{
			return Kco;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_2
	{
		public XmlToolWindow R3V;

		private static _003C_003Ec__DisplayClass8_2 Dcj;

		public _003C_003Ec__DisplayClass8_2()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool l3F(ToolWindow w)
		{
			return w.SerializationId == R3V.SerializationId;
		}

		internal static bool Kct()
		{
			return Dcj == null;
		}

		internal static _003C_003Ec__DisplayClass8_2 Hcp()
		{
			return Dcj;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public XmlDocumentWindowRef M30;

		internal static _003C_003Ec__DisplayClass10_0 JcW;

		public _003C_003Ec__DisplayClass10_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool x3H(XmlDocumentWindow w)
		{
			return w.UniqueId == M30.UniqueId;
		}

		internal static bool KcI()
		{
			return JcW == null;
		}

		internal static _003C_003Ec__DisplayClass10_0 Bca()
		{
			return JcW;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public XmlToolWindowRef k3g;

		private static _003C_003Ec__DisplayClass19_0 DcX;

		public _003C_003Ec__DisplayClass19_0()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal bool y3h(XmlToolWindow w)
		{
			return w.UniqueId == k3g.UniqueId;
		}

		internal static bool ncs()
		{
			return DcX == null;
		}

		internal static _003C_003Ec__DisplayClass19_0 zcQ()
		{
			return DcX;
		}
	}

	[CompilerGenerated]
	private EventHandler<DockingWindowDeserializingEventArgs> jnS;

	[CompilerGenerated]
	private bool XnL;

	[CompilerGenerated]
	private bool Kn3;

	[CompilerGenerated]
	private DockingWindowDeserializationBehavior tn6;

	[CompilerGenerated]
	private DockSiteSerializationBehavior jn9;

	[CompilerGenerated]
	private DockingWindowDeserializationBehavior cnY;

	private static DockSiteLayoutSerializer lHy;

	public bool CanKeepExistingDocumentWindowsOpen
	{
		[CompilerGenerated]
		get
		{
			return XnL;
		}
		[CompilerGenerated]
		set
		{
			XnL = value;
		}
	}

	public bool CanSerializeUnusedLazyLoadData
	{
		[CompilerGenerated]
		get
		{
			return Kn3;
		}
		[CompilerGenerated]
		set
		{
			Kn3 = value;
		}
	}

	public DockingWindowDeserializationBehavior DocumentWindowDeserializationBehavior
	{
		[CompilerGenerated]
		get
		{
			return tn6;
		}
		[CompilerGenerated]
		set
		{
			tn6 = value;
		}
	}

	public DockSiteSerializationBehavior SerializationBehavior
	{
		[CompilerGenerated]
		get
		{
			return jn9;
		}
		[CompilerGenerated]
		set
		{
			jn9 = value;
		}
	}

	public DockingWindowDeserializationBehavior ToolWindowDeserializationBehavior
	{
		[CompilerGenerated]
		get
		{
			return cnY;
		}
		[CompilerGenerated]
		set
		{
			cnY = value;
		}
	}

	public event EventHandler<DockingWindowDeserializingEventArgs> DockingWindowDeserializing
	{
		[CompilerGenerated]
		add
		{
			EventHandler<DockingWindowDeserializingEventArgs> eventHandler = jnS;
			EventHandler<DockingWindowDeserializingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<DockingWindowDeserializingEventArgs> value2 = (EventHandler<DockingWindowDeserializingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jnS, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<DockingWindowDeserializingEventArgs> eventHandler = jnS;
			EventHandler<DockingWindowDeserializingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<DockingWindowDeserializingEventArgs> value2 = (EventHandler<DockingWindowDeserializingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jnS, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DockSiteLayoutSerializer()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	public DockSiteLayoutSerializer(XmlDockSiteLayout layout)
	{
		IVH.CecNqz();
		base._002Ector(layout);
	}

	private static void mJt(DockSite P_0)
	{
		P_0.ApplyTemplate();
		foreach (b4<wH> item in pL.Mxl<wH>(P_0, null))
		{
			if (item.dx3() is Control control)
			{
				control.ApplyTemplate();
			}
		}
	}

	private void eJu(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, XmlAutoHideHost P_3)
	{
		using (IEnumerator<XmlAutoHideTabStrip> enumerator = P_3.Children.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				XmlAutoHideTabStrip current = enumerator.Current;
				ToolWindowContainerCollection toolWindowContainerCollection = new ToolWindowContainerCollection();
				foreach (XmlToolWindowContainer child in current.Children)
				{
					ToolWindowContainer toolWindowContainer = RnN(P_0, P_1, P_2, child, DockingWindowState.AutoHide);
					if (toolWindowContainer != null && toolWindowContainer.RDA().Count > 0)
					{
						toolWindowContainerCollection.Add(toolWindowContainer);
					}
				}
				switch (current.Side)
				{
				case Side.Left:
					P_2.AutoHideLeftContainers.AddRange(toolWindowContainerCollection);
					break;
				case Side.Bottom:
					P_2.AutoHideBottomContainers.AddRange(toolWindowContainerCollection);
					break;
				case Side.Top:
					P_2.AutoHideTopContainers.AddRange(toolWindowContainerCollection);
					break;
				case Side.Right:
					P_2.AutoHideRightContainers.AddRange(toolWindowContainerCollection);
					break;
				}
			}
			int num = 0;
			if (YH3() != null)
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
		RaiseObjectDeserialized(new ItemSerializationEventArgs(P_2, P_3));
	}

	private object jJz(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, Workspace P_3, jJ P_4, XmlObjectBase P_5)
	{
		if (P_5 is XmlSplitContainer xmlSplitContainer)
		{
			return xnG(P_0, P_1, P_2, P_3, P_4, xmlSplitContainer);
		}
		if (P_5 is XmlToolWindowContainer xmlToolWindowContainer)
		{
			return RnN(P_0, P_1, P_2, xmlToolWindowContainer, DockingWindowState.Docked);
		}
		if (P_5 is XmlWorkspace xmlWorkspace)
		{
			return xna(P_0, P_1, P_2, P_3, P_4, xmlWorkspace);
		}
		if (P_5 is XmlTabbedMdiHost xmlTabbedMdiHost)
		{
			return LnC(P_0, P_1, P_2, P_3, P_4, xmlTabbedMdiHost);
		}
		if (P_5 is XmlTabbedMdiContainer xmlTabbedMdiContainer)
		{
			return Hnk(P_0, P_1, P_2, xmlTabbedMdiContainer);
		}
		if (P_5 is XmlStandardMdiHost xmlStandardMdiHost)
		{
			return XnI(P_0, P_1, P_3, P_4, xmlStandardMdiHost);
		}
		if (P_5 is XmlRaftedDocumentWindowContainer xmlRaftedDocumentWindowContainer)
		{
			return Vn2(P_0, P_1, P_2, xmlRaftedDocumentWindowContainer);
		}
		return null;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	private void Dni(DockSite P_0, XmlDockSiteLayout P_1)
	{
		DockingWindow activeWindow = P_0.ActiveWindow;
		IEnumerable<DockingWindow> enumerable = null;
		if (activeWindow != null)
		{
			bool flag = cP.NlZ(activeWindow);
			if (!flag && cP.hlj() is DockHost dockHost && dockHost.DockSite == P_0)
			{
				flag = true;
			}
			if (flag)
			{
				enumerable = from r in pL.Mxl<DockingWindow>(P_0, null)
					orderby r.dx3().LastActiveDateTime descending
					select r.dx3();
			}
		}
		mJt(P_0);
		P_0.LQr(value: true);
		List<DocumentWindow> list = ((SerializationBehavior == DockSiteSerializationBehavior.All) ? new List<DocumentWindow>(P_0.DocumentWindows.Where((DocumentWindow dw) => dw.IsCurrentlyOpen)) : null);
		P_0.kNY();
		Nx nx = P_0.s1t();
		nx.nMy(P_1.SerializationFormat == DockSiteSerializationBehavior.All, _0020: false);
		using (IEnumerator<XmlToolWindow> enumerator = P_1.ToolWindows.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals25 = new _003C_003Ec__DisplayClass8_0();
				CS_0024_003C_003E8__locals25.R3p = enumerator.Current;
				ToolWindow toolWindow = null;
				if (toolWindow == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals25.R3p.SerializationId))
				{
					toolWindow = P_0.ToolWindows.FirstOrDefault((ToolWindow w) => w.SerializationId == CS_0024_003C_003E8__locals25.R3p.SerializationId);
				}
				if (toolWindow == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals25.R3p.Name))
				{
					toolWindow = P_0.ToolWindows[CS_0024_003C_003E8__locals25.R3p.Name];
				}
				if (toolWindow == null && ToolWindowDeserializationBehavior == DockingWindowDeserializationBehavior.AutoCreate)
				{
					toolWindow = CS_0024_003C_003E8__locals25.R3p.knF() as ToolWindow;
				}
				DockingWindowDeserializingEventArgs e = new DockingWindowDeserializingEventArgs(toolWindow, CS_0024_003C_003E8__locals25.R3p);
				RaiseDockingWindowDeserializing(e);
				if (e.Window is ToolWindow toolWindow2)
				{
					if (!P_0.ToolWindows.Contains(toolWindow2))
					{
						P_0.ToolWindows.Add(toolWindow2);
					}
					bn1(CS_0024_003C_003E8__locals25.R3p, toolWindow2);
				}
				else if (ToolWindowDeserializationBehavior == DockingWindowDeserializationBehavior.LazyLoad)
				{
					P_0.oNS(CS_0024_003C_003E8__locals25.R3p);
				}
			}
		}
		using (IEnumerator<XmlDocumentWindow> enumerator2 = P_1.DocumentWindows.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass8_1();
				CS_0024_003C_003E8__locals26.c3q = enumerator2.Current;
				DocumentWindow documentWindow = null;
				if (documentWindow == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals26.c3q.SerializationId))
				{
					documentWindow = P_0.DocumentWindows.FirstOrDefault((DocumentWindow w) => w.SerializationId == CS_0024_003C_003E8__locals26.c3q.SerializationId);
				}
				if (documentWindow == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals26.c3q.Name))
				{
					documentWindow = P_0.DocumentWindows[CS_0024_003C_003E8__locals26.c3q.Name];
				}
				if (documentWindow == null && DocumentWindowDeserializationBehavior == DockingWindowDeserializationBehavior.AutoCreate)
				{
					documentWindow = CS_0024_003C_003E8__locals26.c3q.knF() as DocumentWindow;
				}
				DockingWindowDeserializingEventArgs e2 = new DockingWindowDeserializingEventArgs(documentWindow, CS_0024_003C_003E8__locals26.c3q);
				RaiseDockingWindowDeserializing(e2);
				if (e2.Window is DocumentWindow documentWindow2)
				{
					if (!P_0.DocumentWindows.Contains(documentWindow2))
					{
						P_0.DocumentWindows.Add(documentWindow2);
					}
					knd(CS_0024_003C_003E8__locals26.c3q, documentWindow2);
				}
				else if (DocumentWindowDeserializationBehavior == DockingWindowDeserializationBehavior.LazyLoad)
				{
					P_0.oNS(CS_0024_003C_003E8__locals26.c3q);
				}
			}
		}
		DockHost primaryDockHost = P_0.PrimaryDockHost;
		if (primaryDockHost != null)
		{
			if (P_1.AutoHideHost != null)
			{
				eJu(P_0, P_1, primaryDockHost, P_1.AutoHideHost);
			}
			if (P_1.Content != null)
			{
				primaryDockHost.Child = jJz(P_0, P_1, primaryDockHost, primaryDockHost.Workspace, primaryDockHost.veR(), P_1.Content) as FrameworkElement;
			}
			if (P_1.SerializationFormat == DockSiteSerializationBehavior.ToolWindowsOnly && primaryDockHost.veR() != null)
			{
				using IEnumerator<XmlToolWindow> enumerator = P_1.ToolWindows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					_003C_003Ec__DisplayClass8_2 CS_0024_003C_003E8__locals27 = new _003C_003Ec__DisplayClass8_2();
					CS_0024_003C_003E8__locals27.R3V = enumerator.Current;
					if (!CS_0024_003C_003E8__locals27.R3V.IsOpen || CS_0024_003C_003E8__locals27.R3V.State != XmlDockingWindowState.Document)
					{
						continue;
					}
					ToolWindow toolWindow3 = null;
					if (toolWindow3 == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals27.R3V.SerializationId))
					{
						toolWindow3 = P_0.ToolWindows.FirstOrDefault((ToolWindow w) => w.SerializationId == CS_0024_003C_003E8__locals27.R3V.SerializationId);
					}
					if (toolWindow3 == null && !string.IsNullOrEmpty(CS_0024_003C_003E8__locals27.R3V.Name))
					{
						toolWindow3 = P_0.ToolWindows[CS_0024_003C_003E8__locals27.R3V.Name];
					}
					if (toolWindow3 != null)
					{
						nx.Restore(new DockingWindow[1] { toolWindow3 }, primaryDockHost, DockingWindowState.Document);
					}
				}
			}
		}
		DateTime dateTime = DateTime.Now.AddDays(-1.0);
		foreach (XmlRaftingHost raftingHost in P_1.RaftingHosts)
		{
			une(P_0, P_1, raftingHost, dateTime);
			dateTime = dateTime.AddSeconds(1.0);
		}
		if (list != null)
		{
			bool areDocumentWindowsDestroyedOnClose = P_0.AreDocumentWindowsDestroyedOnClose;
			foreach (DocumentWindow item in list)
			{
				if (!item.IsCurrentlyOpen)
				{
					if (CanKeepExistingDocumentWindowsOpen)
					{
						nx.Restore(new DockingWindow[1] { item }, P_0.PrimaryDockHost, DockingWindowState.Document);
					}
					else if (areDocumentWindowsDestroyedOnClose)
					{
						nx.fMt(item);
					}
				}
			}
		}
		foreach (DockingWindow item2 in P_0.lQs())
		{
			item2.uI5();
		}
		P_0.LQr(value: false);
		nx.gvw();
		enumerable?.FirstOrDefault((DockingWindow w) => w.IsCurrentlyOpen && w.IsSelected)?.Activate(focus: true);
		RaiseObjectDeserialized(new ItemSerializationEventArgs(P_0, P_1));
	}

	private void knd(XmlDocumentWindow P_0, DocumentWindow P_1)
	{
		P_0.Deserialize(P_1);
		RaiseObjectDeserialized(new ItemSerializationEventArgs(P_1, P_0));
	}

	private object Unw(DockSite P_0, XmlDockSiteLayout P_1, XmlDocumentWindowRef P_2)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals7.M30 = P_2;
		if (CS_0024_003C_003E8__locals7.M30.UniqueId == Guid.Empty)
		{
			return null;
		}
		object obj = P_0.DocumentWindows[CS_0024_003C_003E8__locals7.M30.UniqueId];
		if (obj == null && CS_0024_003C_003E8__locals7.M30.UniqueId != Guid.Empty)
		{
			bv bv = new bv
			{
				UniqueId = CS_0024_003C_003E8__locals7.M30.UniqueId
			};
			if (P_1 != null)
			{
				XmlDocumentWindow xmlDocumentWindow = P_1.DocumentWindows.FirstOrDefault((XmlDocumentWindow w) => w.UniqueId == CS_0024_003C_003E8__locals7.M30.UniqueId);
				if (xmlDocumentWindow != null)
				{
					bv.ContainerDockedSize = xmlDocumentWindow.ContainerDockedSize;
				}
			}
			obj = bv;
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(obj, CS_0024_003C_003E8__locals7.M30));
		return obj;
	}

	private Workspace Vn2(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, XmlRaftedDocumentWindowContainer P_3)
	{
		XmlTabbedMdiContainer xmlTabbedMdiContainer = new XmlTabbedMdiContainer
		{
			DockedSize = P_3.DockedSize,
			DockedSizeSerializable = P_3.DockedSizeSerializable,
			SelectedWindowUniqueId = P_3.SelectedWindowUniqueId,
			Tag = P_3.Tag
		};
		foreach (XmlObjectBase child in P_3.Children)
		{
			xmlTabbedMdiContainer.Children.Add(child);
		}
		XmlTabbedMdiHost content = new XmlTabbedMdiHost
		{
			Content = xmlTabbedMdiContainer
		};
		XmlWorkspace xmlWorkspace = new XmlWorkspace
		{
			Content = content
		};
		return xna(P_0, P_1, P_2, null, null, xmlWorkspace);
	}

	private void une(DockSite P_0, XmlDockSiteLayout P_1, XmlRaftingHost P_2, DateTime P_3)
	{
		DockHost dockHost = P_0.m1y(P_2.UniqueId);
		P_2.Deserialize(dockHost);
		dockHost.Wev(P_3);
		if (P_2.AutoHideHost != null)
		{
			eJu(P_0, P_1, dockHost, P_2.AutoHideHost);
		}
		if (P_2.Content != null)
		{
			Workspace workspace = ((SerializationBehavior == DockSiteSerializationBehavior.ToolWindowsOnly) ? dockHost.Workspace : null);
			jJ jJ = ((SerializationBehavior == DockSiteSerializationBehavior.ToolWindowsOnly) ? dockHost.veR() : null);
			dockHost.Child = jJz(P_0, P_1, dockHost, workspace, jJ, P_2.Content) as FrameworkElement;
		}
		dockHost.a2A();
		if (dockHost.IsEmpty)
		{
			bool flag = true;
			foreach (b4<bv> item in pL.Mxl<bv>(dockHost, null))
			{
				if (P_0.KNF(item.dx3().UniqueId) != null || P_0.vNU(item.dx3().UniqueId, _0020: false))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				P_0.VNG(dockHost);
			}
		}
		else
		{
			RaiseObjectDeserialized(new ItemSerializationEventArgs(dockHost, P_2));
			if (P_0.IsVisible)
			{
				dockHost.o2F(_0020: false);
			}
		}
	}

	private SplitContainer xnG(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, Workspace P_3, jJ P_4, XmlSplitContainer P_5)
	{
		SplitContainer splitContainer = new SplitContainer();
		P_5.Deserialize(splitContainer);
		foreach (XmlObjectBase child in P_5.Children)
		{
			if (jJz(P_0, P_1, P_2, P_3, P_4, child) is FrameworkElement item)
			{
				splitContainer.Children.Add(item);
			}
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(splitContainer, P_5));
		return splitContainer;
	}

	private StandardMdiHost XnI(DockSite P_0, XmlDockSiteLayout P_1, Workspace P_2, jJ P_3, XmlStandardMdiHost P_4)
	{
		StandardMdiHost standardMdiHost = P_3 as StandardMdiHost;
		if (standardMdiHost != null)
		{
			if (P_2 != null && P_2.qJb() == P_3)
			{
				P_2.oJA(null);
			}
		}
		else
		{
			if (P_0 != null)
			{
				jJ jJ = P_0.cQ4();
				if (jJ is StandardMdiHost)
				{
					standardMdiHost = jJ.CloneForFloatingDockHost() as StandardMdiHost;
				}
			}
			if (standardMdiHost == null)
			{
				standardMdiHost = new StandardMdiHost();
			}
			standardMdiHost.IsAutoCascadeEnabled = false;
		}
		List<DockingWindow> list = new List<DockingWindow>();
		foreach (XmlObjectBase child in P_4.Children)
		{
			if (child is XmlToolWindowRef xmlToolWindowRef)
			{
				object obj = rnQ(P_0, P_1, xmlToolWindowRef);
				if (obj != null && obj is ToolWindow item)
				{
					list.Add(item);
				}
			}
			else if (child is XmlDocumentWindowRef xmlDocumentWindowRef)
			{
				object obj2 = Unw(P_0, P_1, xmlDocumentWindowRef);
				if (obj2 != null && obj2 is DocumentWindow item2)
				{
					list.Add(item2);
				}
			}
		}
		if (list.Count > 0)
		{
			P_0.R1h(list);
			foreach (DockingWindow item3 in list)
			{
				standardMdiHost.Windows.Add(item3);
			}
			P_0.d10(list);
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(standardMdiHost, P_4));
		standardMdiHost.AreWindowsMaximized = P_4.AreWindowsMaximized;
		return standardMdiHost;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private TabbedMdiContainer Hnk(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, XmlTabbedMdiContainer P_3)
	{
		TabbedMdiContainer tabbedMdiContainer = DockSite.gNd(P_2);
		P_3.Deserialize(tabbedMdiContainer);
		List<DockingWindow> list = new List<DockingWindow>();
		foreach (XmlObjectBase child in P_3.Children)
		{
			if (child is XmlToolWindowRef xmlToolWindowRef)
			{
				object obj = rnQ(P_0, P_1, xmlToolWindowRef);
				if (obj != null && obj is ToolWindow item)
				{
					list.Add(item);
				}
			}
			else if (child is XmlDocumentWindowRef xmlDocumentWindowRef)
			{
				object obj2 = Unw(P_0, P_1, xmlDocumentWindowRef);
				if (obj2 != null && obj2 is DocumentWindow item2)
				{
					list.Add(item2);
				}
			}
		}
		if (list.Count > 0)
		{
			P_0.R1h(list);
		}
		try
		{
			tabbedMdiContainer.qDX(value: true);
			foreach (XmlObjectBase child2 in P_3.Children)
			{
				if (child2 is XmlToolWindowRef xmlToolWindowRef2)
				{
					object obj3 = rnQ(P_0, P_1, xmlToolWindowRef2);
					if (obj3 == null)
					{
						continue;
					}
					if (obj3 is ToolWindow toolWindow)
					{
						tabbedMdiContainer.Windows.Add(toolWindow);
						if (xmlToolWindowRef2.UniqueId != Guid.Empty && xmlToolWindowRef2.UniqueId == P_3.SelectedWindowUniqueId)
						{
							tabbedMdiContainer.SelectedWindow = toolWindow;
						}
					}
					else if (obj3 is bv bv)
					{
						tabbedMdiContainer.sDO(bv);
					}
				}
				else if (child2 is XmlDocumentWindowRef xmlDocumentWindowRef2)
				{
					object obj4 = Unw(P_0, P_1, xmlDocumentWindowRef2);
					if (obj4 == null)
					{
						continue;
					}
					if (obj4 is DocumentWindow documentWindow)
					{
						tabbedMdiContainer.Windows.Add(documentWindow);
						if (xmlDocumentWindowRef2.UniqueId != Guid.Empty && xmlDocumentWindowRef2.UniqueId == P_3.SelectedWindowUniqueId)
						{
							tabbedMdiContainer.SelectedWindow = documentWindow;
						}
					}
					else if (obj4 is bv bv2)
					{
						tabbedMdiContainer.sDO(bv2);
					}
				}
				else if (child2 is XmlTrack xmlTrack)
				{
					bv bv3 = enm(P_0, xmlTrack);
					if (bv3 != null)
					{
						tabbedMdiContainer.sDO(bv3);
					}
				}
			}
		}
		finally
		{
			tabbedMdiContainer.qDX(value: false);
		}
		if (list.Count > 0)
		{
			P_0.d10(list);
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(tabbedMdiContainer, P_3));
		return tabbedMdiContainer;
	}

	private TabbedMdiHost LnC(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, Workspace P_3, jJ P_4, XmlTabbedMdiHost P_5)
	{
		TabbedMdiHost tabbedMdiHost = P_4 as TabbedMdiHost;
		if (tabbedMdiHost == null)
		{
			if (P_0 == null)
			{
				int num = 0;
				if (YH3() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				jJ jJ = P_0.cQ4();
				if (jJ is TabbedMdiHost)
				{
					tabbedMdiHost = jJ.CloneForFloatingDockHost() as TabbedMdiHost;
				}
			}
			if (tabbedMdiHost == null)
			{
				tabbedMdiHost = new TabbedMdiHost();
			}
		}
		else if (P_3 != null && P_3.qJb() == P_4)
		{
			P_3.oJA(null);
		}
		if (P_5.Content != null)
		{
			tabbedMdiHost.Child = jJz(P_0, P_1, P_2, P_3, P_4, P_5.Content) as FrameworkElement;
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(tabbedMdiHost, P_5));
		return tabbedMdiHost;
	}

	private void bn1(XmlToolWindow P_0, ToolWindow P_1)
	{
		P_0.Deserialize(P_1);
		RaiseObjectDeserialized(new ItemSerializationEventArgs(P_1, P_0));
	}

	private ToolWindowContainer RnN(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, XmlToolWindowContainer P_3, DockingWindowState P_4)
	{
		ToolWindowContainer toolWindowContainer = DockSite.dN2(P_2);
		P_3.Deserialize(toolWindowContainer);
		toolWindowContainer.State = P_4;
		List<DockingWindow> list = new List<DockingWindow>();
		foreach (XmlObjectBase child in P_3.Children)
		{
			if (child is XmlToolWindowRef xmlToolWindowRef)
			{
				object obj = rnQ(P_0, P_1, xmlToolWindowRef);
				if (obj != null && obj is ToolWindow item)
				{
					list.Add(item);
				}
			}
		}
		if (list.Count > 0)
		{
			P_0.R1h(list);
		}
		try
		{
			toolWindowContainer.qDX(value: true);
			foreach (XmlObjectBase child2 in P_3.Children)
			{
				if (child2 is XmlToolWindowRef xmlToolWindowRef2)
				{
					object obj2 = rnQ(P_0, P_1, xmlToolWindowRef2);
					if (obj2 == null)
					{
						continue;
					}
					if (obj2 is ToolWindow toolWindow)
					{
						toolWindowContainer.Windows.Add(toolWindow);
						if (xmlToolWindowRef2.UniqueId != Guid.Empty && xmlToolWindowRef2.UniqueId == P_3.SelectedWindowUniqueId)
						{
							toolWindowContainer.SelectedWindow = toolWindow;
						}
					}
					else if (obj2 is bv bv)
					{
						toolWindowContainer.sDO(bv);
					}
				}
				else if (child2 is XmlTrack xmlTrack)
				{
					bv bv2 = enm(P_0, xmlTrack);
					if (bv2 != null)
					{
						toolWindowContainer.sDO(bv2);
					}
				}
			}
		}
		finally
		{
			toolWindowContainer.qDX(value: false);
		}
		if (list.Count > 0)
		{
			P_0.d10(list);
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(toolWindowContainer, P_3));
		return toolWindowContainer;
	}

	private object rnQ(DockSite P_0, XmlDockSiteLayout P_1, XmlToolWindowRef P_2)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals7.k3g = P_2;
		if (CS_0024_003C_003E8__locals7.k3g.UniqueId == Guid.Empty)
		{
			return null;
		}
		object obj = P_0.ToolWindows[CS_0024_003C_003E8__locals7.k3g.UniqueId];
		if (obj == null && CS_0024_003C_003E8__locals7.k3g.UniqueId != Guid.Empty)
		{
			bv bv = new bv
			{
				UniqueId = CS_0024_003C_003E8__locals7.k3g.UniqueId
			};
			if (P_1 != null)
			{
				XmlToolWindow xmlToolWindow = P_1.ToolWindows.FirstOrDefault((XmlToolWindow w) => w.UniqueId == CS_0024_003C_003E8__locals7.k3g.UniqueId);
				if (xmlToolWindow != null)
				{
					bv.ContainerDockedSize = xmlToolWindow.ContainerDockedSize;
				}
			}
			obj = bv;
		}
		RaiseObjectDeserialized(new ItemSerializationEventArgs(obj, CS_0024_003C_003E8__locals7.k3g));
		return obj;
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "dockSite")]
	private bv enm(DockSite P_0, XmlTrack P_1)
	{
		if (P_1.UniqueId == Guid.Empty)
		{
			return null;
		}
		bv bv = new bv();
		P_1.Deserialize(bv);
		RaiseObjectDeserialized(new ItemSerializationEventArgs(bv, P_1));
		return bv;
	}

	private Workspace xna(DockSite P_0, XmlDockSiteLayout P_1, DockHost P_2, Workspace P_3, jJ P_4, XmlWorkspace P_5)
	{
		Workspace workspace = P_3;
		if (SerializationBehavior == DockSiteSerializationBehavior.All)
		{
			object obj = null;
			if (workspace != null)
			{
				if (!(workspace.Content is jJ))
				{
					obj = workspace.Content;
				}
				knW(P_2, workspace, _0020: true);
			}
			else
			{
				workspace = DockSite.HNe();
			}
			P_5.Deserialize(workspace);
			workspace.Content = jJz(P_0, P_1, P_2, P_3, P_4, P_5.Content) ?? obj;
		}
		else
		{
			if (workspace == null)
			{
				return null;
			}
			try
			{
				P_2.zez(value: true);
				knW(P_2, workspace, _0020: false);
			}
			finally
			{
				P_2.zez(value: false);
			}
			P_5.Deserialize(workspace);
			RaiseObjectDeserialized(new ItemSerializationEventArgs(workspace, P_5));
		}
		return workspace;
	}

	private static void knW(DockHost P_0, Workspace P_1, bool P_2)
	{
		if (P_1 == null)
		{
			return;
		}
		if (P_0.Child == P_1)
		{
			P_0.Child = null;
		}
		else
		{
			Tuple<SplitContainer, Control> tuple = SplitContainer.Lm5(P_1);
			if (tuple != null && tuple.Item1 != null && tuple.Item1.Children.Contains(P_1))
			{
				tuple.Item1.Children.Remove(P_1);
			}
			else
			{
				DependencyObject parent = VisualTreeHelper.GetParent(P_1);
				if (parent is Panel panel)
				{
					panel.Children.Remove(P_1);
				}
				else if (parent != null)
				{
					throw new ArgumentException(SR.GetString(SRName.ExWorkspaceCannotRemoveFromParent, parent));
				}
			}
		}
		if (P_2)
		{
			P_1.ClearValue(ContentControl.ContentProperty);
			P_1.ClearValue(ContentControl.ContentTemplateProperty);
			P_1.ClearValue(ContentControl.ContentTemplateSelectorProperty);
			P_1.UpdateLayout();
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected virtual void RaiseDockingWindowDeserializing(DockingWindowDeserializingEventArgs eventArgs)
	{
		jnS?.Invoke(this, eventArgs);
	}

	private XmlAutoHideHost qnB(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlAutoHideHost xmlAutoHideHost = new XmlAutoHideHost();
		if (P_0.AutoHideLeftContainers.Count > 0)
		{
			XmlAutoHideTabStrip xmlAutoHideTabStrip = RnK(P_0.AutoHideLeftContainers, Side.Left);
			if (xmlAutoHideTabStrip != null)
			{
				xmlAutoHideHost.Children.Add(xmlAutoHideTabStrip);
			}
		}
		XmlAutoHideTabStrip xmlAutoHideTabStrip2 = default(XmlAutoHideTabStrip);
		int num;
		if (P_0.AutoHideTopContainers.Count > 0)
		{
			xmlAutoHideTabStrip2 = RnK(P_0.AutoHideTopContainers, Side.Top);
			num = 1;
			if (!tHV())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_0083;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0173:
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlAutoHideHost));
		return xmlAutoHideHost;
		IL_0083:
		if (P_0.AutoHideRightContainers.Count > 0)
		{
			XmlAutoHideTabStrip xmlAutoHideTabStrip3 = RnK(P_0.AutoHideRightContainers, Side.Right);
			if (xmlAutoHideTabStrip3 != null)
			{
				xmlAutoHideHost.Children.Add(xmlAutoHideTabStrip3);
			}
		}
		if (P_0.AutoHideBottomContainers.Count > 0)
		{
			XmlAutoHideTabStrip xmlAutoHideTabStrip4 = RnK(P_0.AutoHideBottomContainers, Side.Bottom);
			if (xmlAutoHideTabStrip4 != null)
			{
				xmlAutoHideHost.Children.Add(xmlAutoHideTabStrip4);
				num = 0;
				if (YH3() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
		}
		goto IL_0173;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0173;
		}
		if (xmlAutoHideTabStrip2 != null)
		{
			xmlAutoHideHost.Children.Add(xmlAutoHideTabStrip2);
		}
		goto IL_0083;
	}

	private XmlAutoHideTabStrip RnK(ToolWindowContainerCollection P_0, Side P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlAutoHideTabStrip xmlAutoHideTabStrip = new XmlAutoHideTabStrip();
		xmlAutoHideTabStrip.Side = P_1;
		foreach (ToolWindowContainer item in P_0)
		{
			XmlToolWindowContainer xmlToolWindowContainer = BnM(item);
			if (xmlToolWindowContainer != null)
			{
				xmlAutoHideTabStrip.Children.Add(xmlToolWindowContainer);
			}
		}
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlAutoHideTabStrip));
		return xmlAutoHideTabStrip;
	}

	private XmlObjectBase hnJ(object P_0)
	{
		if (!(P_0 is SplitContainer splitContainer))
		{
			if (!(P_0 is ToolWindowContainer toolWindowContainer))
			{
				if (!(P_0 is Workspace workspace))
				{
					if (!(P_0 is TabbedMdiHost tabbedMdiHost))
					{
						TabbedMdiContainer tabbedMdiContainer = P_0 as TabbedMdiContainer;
						int num = 0;
						if (YH3() != null)
						{
							int num2 = default(int);
							num = num2;
						}
						switch (num)
						{
						default:
							if (tabbedMdiContainer == null)
							{
								if (P_0 is StandardMdiHost standardMdiHost)
								{
									return UnE(standardMdiHost);
								}
								return null;
							}
							return Dnr(tabbedMdiContainer);
						}
					}
					return Nnx(tabbedMdiHost);
				}
				return vnR(workspace);
			}
			return BnM(toolWindowContainer);
		}
		return knD(splitContainer);
	}

	private XmlDockSiteLayout Vnn(DockSite P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		mJt(P_0);
		XmlDockSiteLayout xmlDockSiteLayout = new XmlDockSiteLayout
		{
			SerializationFormat = SerializationBehavior
		};
		int num = 0;
		IEnumerable<XmlToolWindow> enumerable = default(IEnumerable<XmlToolWindow>);
		ToolWindow toolWindow = default(ToolWindow);
		IEnumerable<XmlDocumentWindow> enumerable2 = default(IEnumerable<XmlDocumentWindow>);
		int num3 = default(int);
		XmlDocumentWindow xmlDocumentWindow = default(XmlDocumentWindow);
		int num4 = default(int);
		while (true)
		{
			int num2;
			if (num >= P_0.ToolWindows.Count)
			{
				if (!CanSerializeUnusedLazyLoadData)
				{
					goto IL_01dd;
				}
				enumerable = P_0.tNf<XmlToolWindow>();
				num2 = 0;
				if (tHV())
				{
					num2 = 1;
				}
			}
			else
			{
				toolWindow = P_0.ToolWindows[num];
				if (toolWindow == null)
				{
					goto IL_0067;
				}
				num2 = 2;
				if (!tHV())
				{
					goto IL_0005;
				}
			}
			goto IL_0009;
			IL_00eb:
			if (enumerable2 == null)
			{
				break;
			}
			foreach (XmlDocumentWindow item in enumerable2)
			{
				xmlDockSiteLayout.DocumentWindows.Add(item);
			}
			break;
			IL_0067:
			num++;
			continue;
			IL_0305:
			if (num3 >= P_0.DocumentWindows.Count)
			{
				if (!CanSerializeUnusedLazyLoadData)
				{
					break;
				}
				enumerable2 = P_0.tNf<XmlDocumentWindow>();
				num2 = 0;
				if (YH3() != null)
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			DocumentWindow documentWindow = P_0.DocumentWindows[num3];
			if (documentWindow != null)
			{
				xmlDocumentWindow = TnO(documentWindow);
				if (xmlDocumentWindow != null)
				{
					num2 = 3;
					if (!tHV())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
			}
			goto IL_02dd;
			IL_0005:
			num2 = num4;
			goto IL_0009;
			IL_01dd:
			if (SerializationBehavior != DockSiteSerializationBehavior.All)
			{
				break;
			}
			num3 = 0;
			goto IL_0305;
			IL_0009:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_00eb;
			case 2:
				goto IL_02ce;
			case 3:
				goto IL_0326;
			}
			if (enumerable != null)
			{
				foreach (XmlToolWindow item2 in enumerable)
				{
					xmlDockSiteLayout.ToolWindows.Add(item2);
				}
			}
			goto IL_01dd;
			IL_0326:
			xmlDockSiteLayout.DocumentWindows.Add(xmlDocumentWindow);
			goto IL_02dd;
			IL_02ce:
			XmlToolWindow xmlToolWindow = bnl(toolWindow);
			if (xmlToolWindow != null)
			{
				xmlDockSiteLayout.ToolWindows.Add(xmlToolWindow);
			}
			goto IL_0067;
			IL_02dd:
			num3++;
			goto IL_0305;
		}
		if (P_0.PrimaryDockHost != null)
		{
			xmlDockSiteLayout.Content = hnJ(P_0.PrimaryDockHost.Child);
			xmlDockSiteLayout.AutoHideHost = qnB(P_0.PrimaryDockHost);
		}
		foreach (DockHost item3 in P_0.ENV())
		{
			XmlRaftingHost xmlRaftingHost = Rn8(item3);
			if (xmlRaftingHost != null)
			{
				xmlDockSiteLayout.RaftingHosts.Add(xmlRaftingHost);
			}
		}
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlDockSiteLayout));
		return xmlDockSiteLayout;
	}

	private XmlDocumentWindow TnO(DocumentWindow P_0)
	{
		if (SerializationBehavior != DockSiteSerializationBehavior.All)
		{
			return null;
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		if (!P_0.CanSerialize)
		{
			return null;
		}
		XmlDocumentWindow xmlDocumentWindow = new XmlDocumentWindow();
		xmlDocumentWindow.Serialize(P_0);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlDocumentWindow));
		return xmlDocumentWindow;
	}

	private XmlDocumentWindowRef nnT(DocumentWindow P_0)
	{
		if (SerializationBehavior != DockSiteSerializationBehavior.All)
		{
			return null;
		}
		if (P_0 != null)
		{
			if (!P_0.CanSerialize)
			{
				return null;
			}
			XmlDocumentWindowRef xmlDocumentWindowRef = new XmlDocumentWindowRef();
			xmlDocumentWindowRef.Serialize(P_0);
			RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlDocumentWindowRef));
			return xmlDocumentWindowRef;
		}
		throw new ArgumentNullException(vVK.ssH(15298));
	}

	private XmlRaftingHost Rn8(DockHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlRaftingHost xmlRaftingHost = new XmlRaftingHost();
		xmlRaftingHost.Serialize(P_0);
		xmlRaftingHost.Content = hnJ(P_0.Child);
		xmlRaftingHost.AutoHideHost = qnB(P_0);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlRaftingHost));
		return xmlRaftingHost;
	}

	private XmlSplitContainer knD(SplitContainer P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlSplitContainer xmlSplitContainer = new XmlSplitContainer();
		xmlSplitContainer.Serialize(P_0);
		foreach (FrameworkElement child in P_0.Children)
		{
			XmlObjectBase xmlObjectBase = hnJ(child);
			if (xmlObjectBase != null)
			{
				xmlSplitContainer.Children.Add(xmlObjectBase);
			}
		}
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlSplitContainer));
		return xmlSplitContainer;
	}

	private XmlStandardMdiHost UnE(StandardMdiHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlStandardMdiHost xmlStandardMdiHost = new XmlStandardMdiHost();
		xmlStandardMdiHost.AreWindowsMaximized = P_0.AreWindowsMaximized;
		foreach (DockingWindow window in P_0.Windows)
		{
			if (window is ToolWindow toolWindow)
			{
				XmlToolWindowRef xmlToolWindowRef = Xnv(toolWindow);
				if (xmlToolWindowRef != null)
				{
					xmlStandardMdiHost.Children.Add(xmlToolWindowRef);
				}
			}
			else if (window is DocumentWindow documentWindow)
			{
				XmlDocumentWindowRef xmlDocumentWindowRef = nnT(documentWindow);
				if (xmlDocumentWindowRef != null)
				{
					xmlStandardMdiHost.Children.Add(xmlDocumentWindowRef);
				}
			}
		}
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlStandardMdiHost));
		return xmlStandardMdiHost;
	}

	private XmlTabbedMdiContainer Dnr(TabbedMdiContainer P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlTabbedMdiContainer xmlTabbedMdiContainer = new XmlTabbedMdiContainer();
		xmlTabbedMdiContainer.Serialize(P_0);
		int num2 = default(int);
		foreach (lX item in P_0.RDA())
		{
			int num;
			if (!(item is ToolWindow toolWindow))
			{
				if (item is DocumentWindow documentWindow)
				{
					XmlDocumentWindowRef xmlDocumentWindowRef = nnT(documentWindow);
					if (xmlDocumentWindowRef == null)
					{
						continue;
					}
					xmlTabbedMdiContainer.Children.Add(xmlDocumentWindowRef);
					num = 0;
					if (!tHV())
					{
						goto IL_0095;
					}
				}
				else
				{
					if (!(item is bv bv))
					{
						continue;
					}
					DockSite dockSite = P_0.DockSite;
					if (dockSite == null || (dockSite.ToolWindows[bv.UniqueId] == null && dockSite.DocumentWindows[bv.UniqueId] == null && (!CanSerializeUnusedLazyLoadData || !dockSite.vNU(bv.UniqueId, _0020: false))))
					{
						continue;
					}
					XmlTrack xmlTrack = Cn7(bv);
					if (xmlTrack == null)
					{
						continue;
					}
					xmlTabbedMdiContainer.Children.Add(xmlTrack);
					num = 1;
					if (!tHV())
					{
						goto IL_0095;
					}
				}
				goto IL_0099;
			}
			XmlToolWindowRef xmlToolWindowRef = Xnv(toolWindow);
			if (xmlToolWindowRef != null)
			{
				xmlTabbedMdiContainer.Children.Add(xmlToolWindowRef);
			}
			continue;
			IL_0099:
			switch (num)
			{
			}
			continue;
			IL_0095:
			num = num2;
			goto IL_0099;
		}
		if (P_0.SelectedWindow != null)
		{
			xmlTabbedMdiContainer.SelectedWindowUniqueId = P_0.SelectedWindow.UniqueId;
		}
		else
		{
			xmlTabbedMdiContainer.SelectedWindowUniqueId = Guid.Empty;
		}
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlTabbedMdiContainer));
		return xmlTabbedMdiContainer;
	}

	private XmlTabbedMdiHost Nnx(TabbedMdiHost P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlTabbedMdiHost xmlTabbedMdiHost = new XmlTabbedMdiHost();
		xmlTabbedMdiHost.Content = hnJ(P_0.Child);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlTabbedMdiHost));
		return xmlTabbedMdiHost;
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ToolWindow")]
	private XmlToolWindow bnl(ToolWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		if (!P_0.CanSerialize)
		{
			return null;
		}
		XmlToolWindow xmlToolWindow = new XmlToolWindow();
		xmlToolWindow.Serialize(P_0);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlToolWindow));
		return xmlToolWindow;
	}

	private XmlToolWindowContainer BnM(ToolWindowContainer P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlToolWindowContainer xmlToolWindowContainer = new XmlToolWindowContainer();
		int num = 0;
		if (YH3() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			xmlToolWindowContainer.Serialize(P_0);
			int num4 = default(int);
			foreach (lX item in P_0.RDA())
			{
				if (item is ToolWindow toolWindow)
				{
					XmlToolWindowRef xmlToolWindowRef = Xnv(toolWindow);
					if (xmlToolWindowRef != null)
					{
						xmlToolWindowContainer.Children.Add(xmlToolWindowRef);
					}
					continue;
				}
				if (!(item is bv bv))
				{
					continue;
				}
				DockSite dockSite = P_0.DockSite;
				int num3 = 1;
				if (!tHV())
				{
					goto IL_00b2;
				}
				goto IL_00b6;
				IL_00b2:
				num3 = num4;
				goto IL_00b6;
				IL_00b6:
				while (true)
				{
					XmlTrack xmlTrack;
					switch (num3)
					{
					case 1:
						if (dockSite == null || (dockSite.ToolWindows[bv.UniqueId] == null && (!CanSerializeUnusedLazyLoadData || !dockSite.vNU(bv.UniqueId, _0020: true))))
						{
							break;
						}
						xmlTrack = Cn7(bv);
						if (xmlTrack == null)
						{
							break;
						}
						goto IL_0104;
					}
					break;
					IL_0104:
					xmlToolWindowContainer.Children.Add(xmlTrack);
					num3 = 0;
					if (YH3() == null)
					{
						continue;
					}
					goto IL_00b2;
				}
			}
			if (P_0.SelectedWindow != null)
			{
				xmlToolWindowContainer.SelectedWindowUniqueId = P_0.SelectedWindow.UniqueId;
			}
			else
			{
				xmlToolWindowContainer.SelectedWindowUniqueId = Guid.Empty;
			}
			RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlToolWindowContainer));
			return xmlToolWindowContainer;
		}
		}
	}

	private XmlToolWindowRef Xnv(ToolWindow P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		if (!P_0.CanSerialize)
		{
			return null;
		}
		XmlToolWindowRef xmlToolWindowRef = new XmlToolWindowRef();
		xmlToolWindowRef.Serialize(P_0);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlToolWindowRef));
		return xmlToolWindowRef;
	}

	private XmlTrack Cn7(bv P_0)
	{
		XmlTrack xmlTrack = new XmlTrack();
		xmlTrack.Serialize(P_0);
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlTrack));
		return xmlTrack;
	}

	private XmlWorkspace vnR(Workspace P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		XmlWorkspace xmlWorkspace = new XmlWorkspace();
		xmlWorkspace.Serialize(P_0);
		xmlWorkspace.Content = hnJ(P_0.qJb());
		RaiseObjectSerialized(new ItemSerializationEventArgs(P_0, xmlWorkspace));
		return xmlWorkspace;
	}

	public override void ApplyTo(DockSite obj)
	{
		if (base.RootNode != null)
		{
			Dni(obj, base.RootNode);
		}
	}

	public override XmlDockSiteLayout CreateRootNodeFor(DockSite obj)
	{
		return Vnn(obj);
	}

	protected override XmlSerializer GetXmlSerializer()
	{
		List<Type> list = new List<Type>();
		list.AddRange(new Type[15]
		{
			typeof(XmlAutoHideHost),
			typeof(XmlAutoHideTabStrip),
			typeof(XmlDocumentWindow),
			typeof(XmlDocumentWindowRef),
			typeof(XmlRaftedDocumentWindowContainer),
			typeof(XmlRaftingHost),
			typeof(XmlSplitContainer),
			typeof(XmlStandardMdiHost),
			typeof(XmlTabbedMdiContainer),
			typeof(XmlTabbedMdiHost),
			typeof(XmlToolWindow),
			typeof(XmlToolWindowContainer),
			typeof(XmlToolWindowRef),
			typeof(XmlTrack),
			typeof(XmlWorkspace)
		});
		if (base.CustomTypes.Count > 0)
		{
			list.AddRange(base.CustomTypes);
		}
		return new XmlSerializer(typeof(XmlDockSiteLayout), list.ToArray());
	}

	internal static bool tHV()
	{
		return lHy == null;
	}

	internal static DockSiteLayoutSerializer YH3()
	{
		return lHy;
	}
}
