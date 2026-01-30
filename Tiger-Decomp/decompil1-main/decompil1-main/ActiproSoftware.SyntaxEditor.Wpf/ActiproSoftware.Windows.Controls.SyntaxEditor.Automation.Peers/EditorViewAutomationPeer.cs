using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorViewAutomationPeer : FrameworkElementAutomationPeer, IScrollProvider, ITextProvider, IValueProvider
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public IEditorView gyg;

		private static _003C_003Ec__DisplayClass18_0 afp;

		public _003C_003Ec__DisplayClass18_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextRangeProvider lyD(TextRange r)
		{
			return new TextRangeProvider(gyg, r);
		}

		internal static bool hf4()
		{
			return afp == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 efD()
		{
			return afp;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public IEditorView zye;

		internal static _003C_003Ec__DisplayClass19_0 LfB;

		public _003C_003Ec__DisplayClass19_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal TextRangeProvider VyQ(ITextViewLine vl)
		{
			return new TextRangeProvider(zye, vl.TextRange);
		}

		internal static bool qf0()
		{
			return LfB == null;
		}

		internal static _003C_003Ec__DisplayClass19_0 xf7()
		{
			return LfB;
		}
	}

	internal static EditorViewAutomationPeer SOx;

	public double HorizontalScrollPercent => 0.0;

	public double HorizontalViewSize => 0.0;

	public bool HorizontallyScrollable => true;

	public double VerticalScrollPercent
	{
		get
		{
			IEditorView editorView = (IEditorView)base.Owner;
			int startOffset = editorView.VisibleViewLines.First().StartOffset;
			return (double)startOffset / Math.Max(1.0, editorView.CurrentSnapshot.Length);
		}
	}

	public double VerticalViewSize
	{
		get
		{
			IEditorView editorView = (IEditorView)base.Owner;
			int num = editorView.VisibleViewLines.Last().EndOffsetIncludingLineTerminator - editorView.VisibleViewLines.First().StartOffset;
			return (double)num / Math.Max(1.0, editorView.CurrentSnapshot.Length);
		}
	}

	bool IScrollProvider.VerticallyScrollable => true;

	public System.Windows.Automation.Provider.ITextRangeProvider DocumentRange
	{
		get
		{
			IEditorView editorView = (IEditorView)base.Owner;
			return new TextRangeProvider(editorView, editorView.CurrentSnapshot.TextRange);
		}
	}

	public SupportedTextSelection SupportedTextSelection => SupportedTextSelection.Single;

	public bool IsReadOnly
	{
		get
		{
			IEditorView editorView = (IEditorView)base.Owner;
			if (editorView.SyntaxEditor.Document.IsReadOnly)
			{
				return true;
			}
			return false;
		}
	}

	public string Value
	{
		get
		{
			IEditorView editorView = (IEditorView)base.Owner;
			return editorView.SyntaxEditor.Document.CurrentSnapshot.Text;
		}
	}

	public EditorViewAutomationPeer(EditorView owner)
	{
		grA.DaB7cz();
		base._002Ector(owner);
	}

	internal void fnQ(bool P_0, bool P_1)
	{
		if (P_0 != P_1)
		{
			RaisePropertyChangedEvent(ValuePatternIdentifiers.IsReadOnlyProperty, P_0, P_1);
		}
	}

	public void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount)
	{
		EditorView editorView = (EditorView)base.Owner;
		switch (horizontalAmount)
		{
		case ScrollAmount.SmallIncrement:
		{
			editorView.lfz().ScrollRight();
			int num = 0;
			if (ROL() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto IL_012f;
			}
			break;
		}
		case ScrollAmount.LargeDecrement:
			editorView.lfz().ScrollLeft();
			break;
		case ScrollAmount.SmallDecrement:
			goto IL_012f;
		case ScrollAmount.LargeIncrement:
			{
				editorView.lfz().ScrollRight();
				break;
			}
			IL_012f:
			editorView.lfz().ScrollLeft();
			break;
		}
		switch (verticalAmount)
		{
		case ScrollAmount.NoAmount:
			break;
		case ScrollAmount.SmallDecrement:
			editorView.lfz().ScrollUp();
			break;
		case ScrollAmount.LargeDecrement:
			editorView.lfz().ScrollPageUp();
			break;
		case ScrollAmount.LargeIncrement:
			editorView.lfz().ScrollPageDown();
			break;
		case ScrollAmount.SmallIncrement:
			editorView.lfz().ScrollDown();
			break;
		}
	}

	public void SetScrollPercent(double horizontalPercent, double verticalPercent)
	{
		IEditorView editorView = (IEditorView)base.Owner;
		verticalPercent = Math.Max(0.0, Math.Min(1.0, verticalPercent));
		int offset = (int)((double)editorView.CurrentSnapshot.Length * verticalPercent);
		TextPosition verticalAnchorTextPosition = editorView.OffsetToPosition(offset);
		TextViewScrollState scrollState = new TextViewScrollState(verticalAnchorTextPosition);
		editorView.Scroller.ScrollTo(scrollState);
	}

	public System.Windows.Automation.Provider.ITextRangeProvider[] GetSelection()
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals3.gyg = (IEditorView)base.Owner;
		return (from r in CS_0024_003C_003E8__locals3.gyg.Selection.GetTextRanges()
			select new TextRangeProvider(CS_0024_003C_003E8__locals3.gyg, r)).ToArray();
	}

	public System.Windows.Automation.Provider.ITextRangeProvider[] GetVisibleRanges()
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals3.zye = (IEditorView)base.Owner;
		return CS_0024_003C_003E8__locals3.zye.VisibleViewLines.Select((ITextViewLine vl) => new TextRangeProvider(CS_0024_003C_003E8__locals3.zye, vl.TextRange)).ToArray();
	}

	public System.Windows.Automation.Provider.ITextRangeProvider RangeFromChild(IRawElementProviderSimple childElement)
	{
		return null;
	}

	public System.Windows.Automation.Provider.ITextRangeProvider RangeFromPoint(Point screenLocation)
	{
		IEditorView editorView = (IEditorView)base.Owner;
		Point location = editorView.SyntaxEditor.PointFromScreen(screenLocation);
		TextPosition position = editorView.LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
		int offset = editorView.PositionToOffset(position);
		return new TextRangeProvider(editorView, TextRange.FromSpan(offset, 0));
	}

	public void SetValue(string value)
	{
		((IEditorView)base.Owner)?.SyntaxEditor.Document.SetText(value);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Pane;
	}

	protected override string GetAutomationIdCore()
	{
		EditorView editorView = (EditorView)base.Owner;
		return base.GetAutomationIdCore() + editorView.Placement;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196762);
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Value || patternInterface == PatternInterface.Scroll || patternInterface == PatternInterface.Text)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	internal static bool UOa()
	{
		return SOx == null;
	}

	internal static EditorViewAutomationPeer ROL()
	{
		return SOx;
	}
}
