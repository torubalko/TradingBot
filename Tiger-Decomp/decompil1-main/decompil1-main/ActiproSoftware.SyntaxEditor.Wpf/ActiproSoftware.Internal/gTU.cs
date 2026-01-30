using System;
using System.Windows.Input;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Searching.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class gTU : IActiveEditorViewChangeEventSink, IEditorDocumentTextChangeEventSink, IEditorViewKeyInputEventSink, IEditorViewSelectionChangeEventSink
{
	private EditorView BwP;

	private TextRange? hwE;

	private bool bwc;

	private bool hwa;

	private IEditorSearchOptions Gwx;

	private SyntaxEditor HwG;

	internal static gTU plg;

	public bool IsActive
	{
		get
		{
			return Gwx != null && BwP != null;
		}
		set
		{
			if (IsActive != flag)
			{
				if (!flag)
				{
					Sjh();
				}
				else
				{
					ijZ(_0020: false);
				}
			}
		}
	}

	public IEditorSearchOptions SearchOptions => Gwx;

	internal gTU(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		HwG = P_0;
	}

	void IActiveEditorViewChangeEventSink.NotifyActiveEditorViewChanged(SyntaxEditor P_0, EditorViewChangedEventArgs P_1)
	{
		YGW(P_0, P_1);
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor P_0, EditorSnapshotChangedEventArgs P_1)
	{
		OnDocumentTextChanged(P_0, P_1);
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanging(SyntaxEditor P_0, EditorSnapshotChangingEventArgs P_1)
	{
		OnDocumentTextChanging(P_0, P_1);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyDown(IEditorView P_0, KeyEventArgs P_1)
	{
		OnViewKeyDown(P_0, P_1);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyUp(IEditorView P_0, KeyEventArgs P_1)
	{
		OnViewKeyUp(P_0, P_1);
	}

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView P_0, EditorViewSelectionEventArgs P_1)
	{
		OnViewSelectionChanged(P_0, P_1);
	}

	private bool ojM(string P_0)
	{
		if (!bwc)
		{
			if (Gwx == null)
			{
				return false;
			}
			string text = Gwx.FindText ?? string.Empty;
			Gwx.FindText = text + P_0;
			return true;
		}
		return false;
	}

	private ISearchResultSet XjO()
	{
		return new SearchResultSet(SearchOperationType.FindNextIncremental, Gwx ?? new EditorSearchOptions(), wrapped: false);
	}

	private ISearchResultSet QjU(bool P_0)
	{
		bwc = false;
		ISearchResultSet searchResultSet;
		if (Gwx != null && !string.IsNullOrEmpty(Gwx.FindText))
		{
			try
			{
				hwa = true;
				searchResultSet = BwP.hfj(SearchOperationType.FindNextIncremental, Gwx, P_0);
				if (HwG.CanIncrementalSearchTrimUnmatchedFindText)
				{
					bwc = searchResultSet == null || searchResultSet.Results == null || searchResultSet.Results.Count == 0;
				}
			}
			finally
			{
				hwa = false;
			}
		}
		else
		{
			searchResultSet = XjO();
		}
		EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(BwP, searchResultSet);
		HwG.qxL(e);
		ISearchResultSet searchResultSet2 = searchResultSet;
		int num = 0;
		if (pll() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => searchResultSet2, 
		};
	}

	private void CjJ()
	{
		if (Gwx != null)
		{
			string text = Gwx.FindText ?? string.Empty;
			if (!string.IsNullOrEmpty(text))
			{
				Gwx.FindText = text.Substring(0, text.Length - 1);
			}
		}
	}

	private void Djt(Cursor P_0)
	{
		if (BwP != null)
		{
			BwP.DAb().XAE(P_0);
		}
	}

	private bool ijZ(bool P_0)
	{
		bool flag = IsActive;
		if (!flag)
		{
			Gwx = new EditorSearchOptions();
			BwP = HwG.ActiveView as EditorView;
		}
		Gwx.SearchUp = P_0;
		Djt(P_0 ? CustomCursors.IncrementalSearchBackward : CustomCursors.IncrementalSearchForward);
		if (!flag && BwP != null)
		{
			HwG.dxb(new TextViewEventArgs(BwP));
		}
		return true;
	}

	private void Sjh()
	{
		Djt(null);
		EditorView bwP = BwP;
		BwP = null;
		Gwx = null;
		bwc = false;
		if (bwP != null)
		{
			HwG.dxb(new TextViewEventArgs(bwP));
		}
	}

	public ISearchResultSet qjN(bool P_0)
	{
		if (ijZ(P_0))
		{
			return QjU(_0020: false);
		}
		return XjO();
	}

	protected virtual void YGW(SyntaxEditor P_0, EditorViewChangedEventArgs P_1)
	{
		IsActive = false;
	}

	protected virtual void OnDocumentTextChanged(SyntaxEditor P_0, EditorSnapshotChangedEventArgs P_1)
	{
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor P_0, EditorSnapshotChangingEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (!IsActive)
		{
			return;
		}
		string typedText = P_1.TypedText;
		if (!string.IsNullOrEmpty(typedText))
		{
			int num = 0;
			if (!PlA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (ojM(typedText))
			{
				QjU(_0020: true);
				hwE = BwP.Selection.TextRange;
			}
			P_1.Cancel = true;
			P_1.Handled = true;
		}
		else
		{
			IsActive = false;
		}
	}

	protected virtual void OnViewKeyDown(IEditorView P_0, KeyEventArgs P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (!IsActive || P_0 != BwP)
		{
			return;
		}
		Key key = P_1.Key;
		int num = 0;
		if (PlA())
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				switch (key)
				{
				case Key.Escape:
					IsActive = false;
					P_1.Handled = true;
					P_0.Selection.Collapse();
					return;
				default:
					num = 0;
					if (pll() != null)
					{
						num = num2;
					}
					break;
				case Key.Back:
					CjJ();
					P_1.Handled = true;
					QjU(_0020: true);
					return;
				}
				break;
			}
		}
	}

	protected virtual void OnViewKeyUp(IEditorView P_0, KeyEventArgs P_1)
	{
	}

	protected virtual void OnViewSelectionChanged(IEditorView P_0, EditorViewSelectionEventArgs P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (!IsActive)
		{
			return;
		}
		if (!hwa && P_0 == BwP)
		{
			if (hwE.HasValue)
			{
				TextRange textRange = P_0.Selection.TextRange;
				TextRange? textRange2 = hwE;
				if (!(textRange != textRange2))
				{
					goto IL_00ac;
				}
			}
			IsActive = false;
		}
		goto IL_00ac;
		IL_00ac:
		hwE = null;
	}

	internal static bool PlA()
	{
		return plg == null;
	}

	internal static gTU pll()
	{
		return plg;
	}
}
