using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class hTE : ObservableCollection<IOverlayPane>, IEditorViewOverlayPaneCollection, IOverlayPaneCollection, IList<IOverlayPane>, ICollection<IOverlayPane>, IEnumerable<IOverlayPane>, IEnumerable, INotifyCollectionChanged
{
	private EditorView RwA;

	private WeakEventListener<hTE, oAA> Ewv;

	private static hTE Nl1;

	public IOverlayPane this[string P_0]
	{
		get
		{
			int num = IndexOf(P_0);
			if (num != -1)
			{
				return base[num];
			}
			return null;
		}
	}

	public hTE(EditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		RwA = P_0;
		P_0.Closed += xwl;
	}

	private void zwQ(bool P_0)
	{
		if (Ewv != null)
		{
			Ewv.Detach();
			Ewv = null;
		}
		if (!P_0)
		{
			return;
		}
		Ewv = new WeakEventListener<hTE, oAA>(this, delegate(hTE instance, object source, oAA eventArgs)
		{
			if (string.IsNullOrEmpty(eventArgs.Key))
			{
				instance.Clear();
			}
			else
			{
				instance.Remove(eventArgs.Key);
			}
		}, delegate(WeakEventListener<hTE, oAA> weakEventListener)
		{
			SyntaxEditor.RGV(weakEventListener.OnEvent);
		});
		SyntaxEditor.uGB(Ewv.OnEvent);
	}

	private void Uwe(object P_0, EventArgs P_1)
	{
		IOverlayPane item = (IOverlayPane)P_0;
		Remove(item);
	}

	private void xwl(object P_0, object P_1)
	{
		Clear();
	}

	public IOverlayPane AddSearch(bool P_0)
	{
		SearchOverlayPane searchOverlayPane = new SearchOverlayPane(RwA);
		searchOverlayPane.IsReplaceVisible = P_0;
		searchOverlayPane.rlD();
		Add(searchOverlayPane);
		return searchOverlayPane;
	}

	protected override void ClearItems()
	{
		while (base.Count > 0)
		{
			RemoveItem(base.Count - 1);
		}
	}

	public bool Contains(string P_0)
	{
		return IndexOf(P_0) != -1;
	}

	public int IndexOf(string P_0)
	{
		for (int i = 0; i < base.Count; i++)
		{
			if (base[i].Key == P_0)
			{
				return i;
			}
		}
		return -1;
	}

	protected override void InsertItem(int P_0, IOverlayPane P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12126));
		}
		P_1.Closed += Uwe;
		if (base.Count == 0)
		{
			zwQ(_0020: true);
		}
		OverlayPaneInstanceKind overlayPaneInstanceKind = default(OverlayPaneInstanceKind);
		if (!string.IsNullOrEmpty(P_1.Key))
		{
			OverlayPaneInstanceKind instanceKind = P_1.InstanceKind;
			overlayPaneInstanceKind = instanceKind;
			if (overlayPaneInstanceKind != OverlayPaneInstanceKind.Single)
			{
				goto IL_003c;
			}
			SyntaxEditor.CloseOverlayPanes(P_1.Key);
		}
		goto IL_007e;
		IL_007e:
		base.InsertItem(P_0, P_1);
		YA0 yA = RwA.DAb().sld(AdornmentLayerDefinitions.OverlayPanes.Key, new Lazy<MTG>(() => new YA0())) as YA0;
		int num = 0;
		if (!rl5())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			break;
		default:
		{
			yA?.u62(P_1);
			OverlayPaneEventArgs e = new OverlayPaneEventArgs(RwA, P_1);
			RwA.SyntaxEditor.gxo(e);
			RwA.SyntaxEditor.ElementTransparencyManager.ojG(P_1.VisualElement, P_1.ControlKeyDownOpacity);
			return;
		}
		}
		goto IL_003c;
		IL_003c:
		if (overlayPaneInstanceKind == OverlayPaneInstanceKind.SinglePerView)
		{
			Remove(P_1.Key);
		}
		goto IL_007e;
	}

	public bool Remove(string P_0)
	{
		int num = IndexOf(P_0);
		if (num != -1)
		{
			RemoveAt(num);
		}
		return num != -1;
	}

	protected override void RemoveItem(int P_0)
	{
		IOverlayPane overlayPane = base[P_0];
		base.RemoveItem(P_0);
		UIElement visualElement = overlayPane.VisualElement;
		if (visualElement != null && vAE.y0m(visualElement))
		{
			RwA.Focus();
		}
		if (RwA.DAb().sld(AdornmentLayerDefinitions.OverlayPanes.Key, new Lazy<MTG>(() => new YA0())) is YA0 yA)
		{
			yA.u67(overlayPane);
		}
		RwA.SyntaxEditor.ElementTransparencyManager.UjX(overlayPane.VisualElement);
		overlayPane.Closed -= Uwe;
		if (base.Count == 0)
		{
			zwQ(_0020: false);
		}
		overlayPane.Close();
		OverlayPaneEventArgs e = new OverlayPaneEventArgs(RwA, overlayPane);
		RwA.SyntaxEditor.Qx4(e);
	}

	protected override void SetItem(int P_0, IOverlayPane P_1)
	{
		RemoveItem(P_0);
		InsertItem(P_0, P_1);
	}

	internal static bool rl5()
	{
		return Nl1 == null;
	}

	internal static hTE olG()
	{
		return Nl1;
	}
}
