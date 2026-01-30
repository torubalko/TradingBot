using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class uTb
{
	private double F44;

	private EditorView w4o;

	private EditorView j4j;

	private static uTb JAQ;

	public bool HasHorizontalSplit => R4D(EditorViewPlacement.Upper);

	public double HorizontalSplitPercentage
	{
		get
		{
			return F44;
		}
		private set
		{
			F44 = Math.Max(0.0, Math.Min(1.0, val));
		}
	}

	private void R4X(SyntaxEditor P_0, EditorViewPlacement P_1)
	{
		if (R4D(P_1))
		{
			return;
		}
		EditorView editorView = new EditorView(P_0, P_1);
		int num;
		if (!f4C())
		{
			num = 1;
			if (OAh() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_001d;
		IL_001d:
		EditorViewPlacement editorViewPlacement = P_1;
		if (editorViewPlacement == EditorViewPlacement.Default)
		{
			w4o = editorView;
			goto IL_0103;
		}
		num = 0;
		if (OAh() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_00ad:
		if (editorViewPlacement == EditorViewPlacement.Upper)
		{
			j4j = editorView;
		}
		goto IL_0103;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00ad;
		}
		P_0.ActiveView = editorView;
		editorView.IsActive = true;
		goto IL_001d;
		IL_0103:
		P_0.mG4()?.Kgn(P_0, _0020: false);
		A4m(P_0);
		P_0.TxT(new TextViewEventArgs(editorView));
	}

	private void t4K(SyntaxEditor P_0, EditorViewPlacement P_1)
	{
		if (!R4D(P_1))
		{
			return;
		}
		EditorView editorView = c4Q(P_1);
		editorView.IsActive = false;
		int num;
		if (editorView.Placement != EditorViewPlacement.Default)
		{
			num = 1;
			if (!wAy())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		P_0.ActiveView = null;
		goto IL_011f;
		IL_00dd:
		A4m(P_0);
		return;
		IL_00e9:
		EditorViewHost editorViewHost = default(EditorViewHost);
		editorViewHost.Kgn(P_0, _0020: false);
		goto IL_00dd;
		IL_011f:
		editorView.Close();
		if (P_1 != EditorViewPlacement.Default)
		{
			if (P_1 == EditorViewPlacement.Upper)
			{
				j4j = null;
			}
		}
		else
		{
			w4o = null;
		}
		editorViewHost = P_0.mG4();
		if (editorViewHost != null)
		{
			num = 0;
			if (!wAy())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00dd;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00e9;
		}
		K4g(w4o);
		goto IL_011f;
	}

	[SpecialName]
	private bool f4C()
	{
		return w4o != null || j4j != null;
	}

	private void f4f()
	{
		EditorView editorView = j4j;
		j4j = w4o;
		w4o = editorView;
		if (j4j != null)
		{
			j4j.Placement = EditorViewPlacement.Upper;
		}
		if (w4o != null)
		{
			w4o.Placement = EditorViewPlacement.Default;
		}
	}

	private bool R4D(EditorViewPlacement P_0)
	{
		return c4Q(P_0) != null;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public void K4g(EditorView P_0, bool P_1 = true)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		EditorView editorView = P_0.SyntaxEditor.ActiveView as EditorView;
		if (P_0 != editorView)
		{
			if (editorView != null)
			{
				editorView.IsActive = false;
			}
			P_0.SyntaxEditor.ActiveView = P_0;
			P_0.IsActive = true;
			if (P_1 && editorView != null && vAE.y0m(editorView))
			{
				P_0.Focus();
			}
			P_0.SyntaxEditor.bxQ(new EditorViewChangedEventArgs(editorView, P_0));
			if (UIElementAutomationPeer.FromElement(P_0.SyntaxEditor) is SyntaxEditorAutomationPeer syntaxEditorAutomationPeer)
			{
				syntaxEditorAutomationPeer.Mnl(editorView, P_0);
			}
		}
	}

	public EditorView c4Q(EditorViewPlacement P_0)
	{
		return P_0 switch
		{
			EditorViewPlacement.Default => w4o, 
			EditorViewPlacement.Upper => j4j, 
			_ => null, 
		};
	}

	public void j4e(EditorSnapshotChangedEventArgs P_0)
	{
		foreach (EditorView item in O4R())
		{
			item.aKT(P_0);
		}
	}

	public void X4l(SyntaxEditor P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		HorizontalSplitPercentage = P_0.HorizontalSplitPercentage;
		if (!f4C())
		{
			return;
		}
		if (F44 == 0.0)
		{
			int num = 0;
			if (!wAy())
			{
				int num2 = default(int);
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					t4K(P_0, EditorViewPlacement.Upper);
					P_0.Gx5();
					if (UIElementAutomationPeer.FromElement(P_0) is SyntaxEditorAutomationPeer syntaxEditorAutomationPeer)
					{
						syntaxEditorAutomationPeer.env();
						num = 1;
						if (!wAy())
						{
							num = 0;
						}
						continue;
					}
					goto IL_01b0;
				case 2:
					break;
				case 1:
					goto IL_01b0;
				}
				break;
			}
		}
		else
		{
			if (!P_0.CanSplitHorizontally)
			{
				P_0.HorizontalSplitPercentage = 0.0;
				return;
			}
			if (!HasHorizontalSplit)
			{
				R4X(P_0, EditorViewPlacement.Upper);
				c4Q(EditorViewPlacement.Upper).hAm(c4Q(EditorViewPlacement.Default).ScrollState);
				P_0.mx8();
				if (UIElementAutomationPeer.FromElement(P_0) is SyntaxEditorAutomationPeer syntaxEditorAutomationPeer2)
				{
					syntaxEditorAutomationPeer2.KnA();
				}
				goto IL_01b0;
			}
		}
		P_0.KxI();
		goto IL_01b0;
		IL_01b0:
		P_0.mG4()?.Egb();
	}

	public void w4A(SyntaxEditor P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		if (!P_1 && j4j != null)
		{
			f4f();
		}
		P_0.HasHorizontalSplit = false;
	}

	public void y4v(SyntaxEditor P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		if (f4C())
		{
			if (R4D(EditorViewPlacement.Upper))
			{
				t4K(P_0, EditorViewPlacement.Upper);
			}
		}
		else
		{
			R4X(P_0, EditorViewPlacement.Default);
		}
	}

	public void A4m(SyntaxEditor P_0)
	{
		if (w4o != null)
		{
			w4o.CanSplitHorizontally = P_0.CanSplitHorizontally && P_0.HorizontalSplitPercentage == 0.0 && P_0.IsMultiLine;
		}
		if (!P_0.CanSplitHorizontally && HasHorizontalSplit)
		{
			P_0.HorizontalSplitPercentage = 0.0;
		}
	}

	[SpecialName]
	public IEnumerable<EditorView> O4R()
	{
		if (j4j != null)
		{
			yield return j4j;
		}
		if (w4o != null)
		{
			yield return w4o;
		}
	}

	public uTb()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool wAy()
	{
		return JAQ == null;
	}

	internal static uTb OAh()
	{
		return JAQ;
	}
}
