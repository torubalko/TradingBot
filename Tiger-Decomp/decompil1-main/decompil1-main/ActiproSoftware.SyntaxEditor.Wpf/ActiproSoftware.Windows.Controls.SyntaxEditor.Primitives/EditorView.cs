using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Searching.Implementation;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[ToolboxItem(false)]
public class EditorView : TextView, IEditorView, ITextView, ITextViewTaggerProvider, IEditorViewIntelliPrompt, IEditorViewSearcher, IEditorViewTextChangeActions, ITextPositionFinder
{
	[Flags]
	private enum gAJ
	{

	}

	private class VAW
	{
		private gAJ fB3;

		internal static VAW PNT;

		public VAW(gAJ P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			fB3 = P_0;
		}

		internal bool RB1(gAJ P_0)
		{
			return (fB3 & P_0) == P_0;
		}

		internal void KBF(gAJ P_0, bool P_1)
		{
			if (!P_1)
			{
				fB3 &= ~P_0;
			}
			else
			{
				fB3 |= P_0;
			}
		}

		internal static bool oNt()
		{
			return PNT == null;
		}

		internal static VAW KNY()
		{
			return PNT;
		}
	}

	private class vA8
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int? NBB;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point NBV;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GAj yBr;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Point cBs;

		private static vA8 SNb;

		public GAj Kind
		{
			[CompilerGenerated]
			get
			{
				return yBr;
			}
			[CompilerGenerated]
			set
			{
				yBr = gAj;
			}
		}

		[SpecialName]
		public bool zBY()
		{
			return FBo().HasValue;
		}

		[SpecialName]
		[CompilerGenerated]
		public int? FBo()
		{
			return NBB;
		}

		[SpecialName]
		[CompilerGenerated]
		public void sBj(int? P_0)
		{
			NBB = P_0;
		}

		public Point xBR(Point P_0)
		{
			return new Point(P_0.X + EB6().X, P_0.Y + EB6().Y);
		}

		[SpecialName]
		[CompilerGenerated]
		public Point EB6()
		{
			return NBV;
		}

		[SpecialName]
		[CompilerGenerated]
		public void GBH(Point P_0)
		{
			NBV = P_0;
		}

		[SpecialName]
		public bool nBT()
		{
			return Kind != (GAj)6;
		}

		[SpecialName]
		[CompilerGenerated]
		public Point iBI()
		{
			return cBs;
		}

		[SpecialName]
		[CompilerGenerated]
		public void yB5(Point P_0)
		{
			cBs = P_0;
		}

		public vA8()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool KNs()
		{
			return SNb == null;
		}

		internal static vA8 zNP()
		{
			return SNb;
		}
	}

	private enum GAj
	{

	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public EditorView UVP;

		public AdornmentLayerDefinition HVE;

		private static _003C_003Ec__DisplayClass191_0 MNC;

		public _003C_003Ec__DisplayClass191_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal MTG PVW()
		{
			return new DAN(UVP, HVE);
		}

		internal static bool sNr()
		{
			return MNC == null;
		}

		internal static _003C_003Ec__DisplayClass191_0 yNX()
		{
			return MNC;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass265_0
	{
		public EditorView vVa;

		public TagsChangedEventArgs NVx;

		private static _003C_003Ec__DisplayClass265_0 HNE;

		public _003C_003Ec__DisplayClass265_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void vVc(object o)
		{
			ITextSnapshot currentSnapshot = vVa.CurrentSnapshot;
			TextSnapshotRange textSnapshotRange = NVx.SnapshotRange;
			int num = 0;
			if (YNu() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0005:
			int num2 = default(int);
			num = num2;
			goto IL_0009;
			IL_0009:
			ITextViewLine textViewLine = default(ITextViewLine);
			ITextViewLine textViewLine2 = default(ITextViewLine);
			TextRange textRange = default(TextRange);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					TextRange range = new TextRange(textViewLine.StartOffset, textViewLine2.EndOffsetIncludingLineTerminator);
					if (textRange.OverlapsWith(range))
					{
						vVa.Gf1((vTP)4);
					}
					return;
				}
				}
				if (textSnapshotRange.Snapshot.Document != currentSnapshot.Document)
				{
					textRange = currentSnapshot.SnapshotRange;
				}
				else
				{
					textSnapshotRange = NVx.SnapshotRange.TranslateTo(currentSnapshot, TextRangeTrackingModes.Default);
					textRange = textSnapshotRange.TextRange;
				}
				ITextViewLineCollection visibleViewLines = vVa.VisibleViewLines;
				textViewLine = visibleViewLines.FirstOrDefault();
				textViewLine2 = visibleViewLines.LastOrDefault();
				if (textViewLine != null && textViewLine2 != null)
				{
					num = 1;
					if (zNw())
					{
						continue;
					}
					break;
				}
				return;
			}
			goto IL_0005;
		}

		internal static bool zNw()
		{
			return HNE == null;
		}

		internal static _003C_003Ec__DisplayClass265_0 YNu()
		{
			return HNE;
		}
	}

	private VAW HDf;

	private ISearchOptions iDD;

	private hTE lDg;

	private SearchResultHighlightTagger LDQ;

	private zTV JDe;

	private ICollapsedRegionManager KDl;

	public static readonly RoutedEvent HasFocusChangedEvent;

	public static readonly RoutedEvent HighlightedResultSearchOptionsChangedEvent;

	public static readonly RoutedEvent SelectionChangedEvent;

	internal static readonly DateTime LDA;

	private InputAdapter eDv;

	private int GDm;

	private DateTime ADC;

	private Point dDu;

	private Point cD1;

	private vA8 LDF;

	private BTZ kD3;

	private InputPointerEventArgs TDR;

	private BTZ JDY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool VD4;

	private bAs FDo;

	private xA jDj;

	private EditorViewMarginCollection dDw;

	private o7 iD6;

	private PTg CDH;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EditorViewPlacement UDb;

	public static readonly DependencyProperty CanSplitHorizontallyProperty;

	public static readonly DependencyProperty IsActiveProperty;

	private TextSnapshotRange HDT;

	private TextSnapshotOffset FDL;

	private ITagAggregator<IClassificationTag> ADn;

	private ITagAggregator<IIntraLineSpacerTag> BD8;

	private ITagAggregator<IIntraTextSpacerTag> QDI;

	private ITagAggregator<ISquiggleTag> RD5;

	private WeakEventListener<EditorView, TagsChangedEventArgs> YD0;

	private WeakEventListener<EditorView, TagsChangedEventArgs> wDB;

	private WeakEventListener<EditorView, TagsChangedEventArgs> BDV;

	private WeakEventListener<EditorView, TagsChangedEventArgs> bDr;

	private static EditorView MBq;

	public bool ContainsFocus => HDf.RB1((gAJ)2);

	public ITextSnapshotLine CurrentSnapshotLine => base.CurrentSnapshot.Lines[JDe.EndPosition.Line];

	public ITextViewLine CurrentViewLine => GetViewLine(JDe.EndPosition);

	public bool HasFocus => HDf.RB1((gAJ)1);

	public ISearchOptions HighlightedResultSearchOptions
	{
		get
		{
			return iDD;
		}
		set
		{
			iDD = value;
			DK5();
		}
	}

	public override IHighlightingStyleRegistry HighlightingStyleRegistry => base.SyntaxEditor.HG8();

	public IEditorViewIntelliPrompt IntelliPrompt => this;

	public bool IsIncrementalSearchActive
	{
		get
		{
			return IsActive && base.SyntaxEditor.eGu().IsActive;
		}
		set
		{
			if (value)
			{
				Activate();
				if (!vAE.E0C(this))
				{
					Focus();
				}
			}
			base.SyntaxEditor.eGu().IsActive = value;
		}
	}

	public override bool IsWhitespaceVisible => base.SyntaxEditor.IsWhitespaceVisible;

	public IEditorViewOverlayPaneCollection OverlayPanes => lDg;

	public IEditorViewSearcher Searcher => this;

	public IEditorViewSelection Selection => JDe;

	protected internal override bool UseSyntaxEditorDisplayItemProperties => true;

	protected internal override WordWrapMode WordWrapMode => base.SyntaxEditor.WordWrapMode;

	public string SelectedText
	{
		get
		{
			if (JDe.IsZeroLength)
			{
				return string.Empty;
			}
			if (JDe.Mode == SelectionModes.Block)
			{
				StringBuilder stringBuilder = new StringBuilder();
				IList<TextRange> textRanges = JDe.GetTextRanges();
				ITextSnapshot currentSnapshot = base.CurrentSnapshot;
				for (int i = 0; i < textRanges.Count; i++)
				{
					if (i < textRanges.Count - 1)
					{
						stringBuilder.AppendLine(new TextSnapshotRange(currentSnapshot, textRanges[i]).Text);
					}
					else
					{
						stringBuilder.Append(new TextSnapshotRange(currentSnapshot, textRanges[i]).Text);
					}
				}
				return stringBuilder.ToString();
			}
			return JDe.SnapshotRange.Text;
		}
		set
		{
			ReplaceSelectedText(TextChangeTypes.TextReplacement, value, new EditorViewTextChangeOptions(this)
			{
				CheckReadOnly = true
			});
		}
	}

	public override ICollapsedRegionManager CollapsedRegionManager => KDl;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Scroller")]
	IEditorViewScroller IEditorView.Scroller => CDH;

	public IEditorViewMarginCollection Margins => dDw;

	public EditorViewPlacement Placement
	{
		[CompilerGenerated]
		get
		{
			return UDb;
		}
		[CompilerGenerated]
		internal set
		{
			UDb = value;
		}
	}

	protected internal override Rect ScrollableContentHostBounds
	{
		get
		{
			if (jDj == null)
			{
				return default(Rect);
			}
			return jDj.EDz();
		}
	}

	public override Thickness TextAreaPadding
	{
		get
		{
			if (!base.SyntaxEditor.IsMultiLine)
			{
				Thickness padding = base.SyntaxEditor.Padding;
				return new Thickness(padding.Left + 2.0, padding.Top, padding.Right + 2.0, padding.Bottom);
			}
			Thickness thickness = default(Thickness);
			int num = 0;
			if (!RBx())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => thickness, 
			};
		}
	}

	public override Size TextAreaSize
	{
		get
		{
			if (iD6 != null)
			{
				return iD6.xgy();
			}
			return default(Size);
		}
	}

	public override Rect TextAreaViewportBounds
	{
		get
		{
			if (jDj != null && iD6 != null)
			{
				Rect rect = jDj.EDz();
				Rect rect2 = iD6.Mg2();
				Thickness borderThickness = base.BorderThickness;
				return new Rect(borderThickness.Left + rect.X + rect2.X, borderThickness.Top + rect.Y + rect2.Y, rect2.Width, rect2.Height);
			}
			return default(Rect);
		}
	}

	public bool CanSplitHorizontally
	{
		get
		{
			return (bool)GetValue(CanSplitHorizontallyProperty);
		}
		internal set
		{
			SetValue(CanSplitHorizontallyProperty, value);
		}
	}

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(IsActiveProperty);
		}
		internal set
		{
			SetValue(IsActiveProperty, value);
		}
	}

	public TextSnapshotRange SelectionScopeSnapshotRange => Xfo(EditorSearchScope.Selection);

	protected internal override ITagAggregator<IClassificationTag> ClassificationTagAggregator => ADn;

	protected internal override ITagAggregator<IIntraLineSpacerTag> IntraLineSpacerTagAggregator => BD8;

	protected internal override ITagAggregator<IIntraTextSpacerTag> IntraTextSpacerTagAggregator => QDI;

	protected internal override ITagAggregator<ISquiggleTag> SquiggleTagAggregator => RD5;

	public IEnumerable<Type> TagTypes => new Type[1] { typeof(IClassificationTag) };

	public IEditorViewTextChangeActions TextChangeActions => this;

	public ITextPositionFinder PositionFinder => this;

	public event RoutedEventHandler HasFocusChanged
	{
		add
		{
			AddHandler(HasFocusChangedEvent, value);
		}
		remove
		{
			RemoveHandler(HasFocusChangedEvent, value);
		}
	}

	public event RoutedEventHandler HighlightedResultSearchOptionsChanged
	{
		add
		{
			AddHandler(HighlightedResultSearchOptionsChangedEvent, value);
		}
		remove
		{
			RemoveHandler(HighlightedResultSearchOptionsChangedEvent, value);
		}
	}

	public event EventHandler<EditorViewSelectionEventArgs> SelectionChanged
	{
		add
		{
			AddHandler(SelectionChangedEvent, value);
		}
		remove
		{
			RemoveHandler(SelectionChangedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	internal EditorView(SyntaxEditor syntaxEditor, EditorViewPlacement viewPlacement)
	{
		grA.DaB7cz();
		HDf = new VAW((gAJ)0);
		ADC = LDA;
		dDw = new EditorViewMarginCollection();
		HDT = TextSnapshotRange.Deleted;
		FDL = TextSnapshotOffset.Deleted;
		base._002Ector(syntaxEditor, syntaxEditor.Document.CurrentSnapshot);
		base.DefaultStyleKey = typeof(EditorView);
		base.RequestBringIntoView += aKM;
		Placement = viewPlacement;
		JDe = new zTV(this);
		lDg = new hTE(this);
		CDH = new PTg(this);
		jKn();
		JDe.Fof();
		xfm();
		DfC();
		Gfu();
		RfT();
		Kfb();
		ufv();
		FKB();
		eTh.Gjk(this);
	}

	internal void aKT(EditorSnapshotChangedEventArgs P_0)
	{
		WAL()?.DTb(P_0.TextChange);
		InvalidateRender();
		if (JDe == null)
		{
			return;
		}
		int num = 0;
		if (!RBx())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		using (JDe.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			JDe.BoC(P_0);
			if (gft())
			{
				DAb().InvalidateMeasure();
				DAb().UpdateLayout();
			}
		}
	}

	public void Activate()
	{
		if (!IsActive)
		{
			if (vAE.y0m(base.SyntaxEditor))
			{
				Focus();
			}
			else
			{
				base.SyntaxEditor.gGw()?.K4g(this);
			}
		}
	}

	protected internal override void Close()
	{
		ifH();
		UKL();
		base.SyntaxEditor.VxH(new TextViewEventArgs(this));
		pAC();
		XfD();
		Hfg();
		HfQ();
	}

	public bool ExecuteEditAction(IEditAction action)
	{
		if (action == null)
		{
			int num = 0;
			if (!RBx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(7788));
			}
		}
		EditActionEventArgs e = new EditActionEventArgs(this, action);
		base.SyntaxEditor.Ax6(e);
		if (e.Cancel)
		{
			return false;
		}
		base.SyntaxEditor.MacroRecording.NotifyEditAction(this, action);
		try
		{
			if (action.CanExecute(this))
			{
				action.Execute(this);
				return true;
			}
		}
		catch (OutOfMemoryException)
		{
		}
		return false;
	}

	public string ExportSelectedText(ITextExporter exporter)
	{
		if (exporter == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7804));
		}
		return exporter.Export(base.CurrentSnapshot, JDe.GetTextRanges());
	}

	public int FindCurrentWordEnd()
	{
		IWordBreakFinder wordBreakFinder = base.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		return wordBreakFinder.FindCurrentWordEnd(new TextSnapshotOffset(base.CurrentSnapshot, JDe.EndOffset));
	}

	public int FindCurrentWordStart()
	{
		IWordBreakFinder wordBreakFinder = base.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		return wordBreakFinder.FindCurrentWordStart(new TextSnapshotOffset(base.CurrentSnapshot, JDe.EndOffset));
	}

	public int FindNextWordStart()
	{
		IWordBreakFinder wordBreakFinder = base.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		return wordBreakFinder.FindNextWordStart(new TextSnapshotOffset(base.CurrentSnapshot, JDe.EndOffset));
	}

	public int FindPreviousWordStart()
	{
		IWordBreakFinder wordBreakFinder = base.SyntaxEditor.Document.Language.GetWordBreakFinder() ?? new DefaultWordBreakFinder();
		return wordBreakFinder.FindPreviousWordStart(new TextSnapshotOffset(base.CurrentSnapshot, JDe.EndOffset));
	}

	public string GetCurrentWordText()
	{
		return base.CurrentSnapshot.GetSubstring(GetCurrentWordTextRange());
	}

	public TextRange GetCurrentWordTextRange()
	{
		return base.CurrentSnapshot.GetWordTextRange(JDe.EndOffset);
	}

	public ITextSnapshotReader GetReader()
	{
		return base.CurrentSnapshot.GetReader(JDe.EndOffset);
	}

	public ITextStatistics GetTextStatisticsForSelectedText()
	{
		ITextStatistics textStatistics = null;
		if (base.SyntaxEditor.Document != null && base.SyntaxEditor.Document != null && base.SyntaxEditor.Document.Language != null)
		{
			ITextStatisticsFactory textStatisticsFactory = base.SyntaxEditor.Document.Language.GetTextStatisticsFactory();
			if (textStatisticsFactory != null)
			{
				textStatistics = textStatisticsFactory.CreateStatistics(SelectedText);
			}
		}
		if (textStatistics == null)
		{
			int num = 0;
			if (CBa() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			textStatistics = new TextStatistics(SelectedText);
		}
		return textStatistics;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorViewAutomationPeer(this);
	}

	public void CopyToClipboard()
	{
		ExecuteEditAction(new CopyToClipboardAction());
	}

	public void CopyAndAppendToClipboard()
	{
		ExecuteEditAction(new CopyAndAppendToClipboardAction());
	}

	public void CutLineToClipboard()
	{
		ExecuteEditAction(new CutLineToClipboardAction());
	}

	public void CutToClipboard()
	{
		ExecuteEditAction(new CutToClipboardAction());
	}

	public void CutAndAppendToClipboard()
	{
		ExecuteEditAction(new CutAndAppendToClipboardAction());
	}

	public bool DeleteSelectedText(ITextChangeType type)
	{
		return DeleteSelectedText(type, null);
	}

	public bool DeleteSelectedText(ITextChangeType type, IEditorViewTextChangeOptions options)
	{
		return ReplaceSelectedText(type, string.Empty, options);
	}

	public string GetVirtualCharacterFillString(TextPosition position, bool returnCharacterFill)
	{
		int num = 4;
		string text = default(string);
		ITextViewLine viewLine = default(ITextViewLine);
		int num3 = default(int);
		string result = default(string);
		int num4 = default(int);
		int num5 = default(int);
		int tabSize = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 4:
					break;
				case 3:
					if (IsVirtualLine(position.Line))
					{
						text = new string('\n', position.Line - base.CurrentSnapshot.Lines.Count + 1);
					}
					if (!returnCharacterFill)
					{
						return text;
					}
					viewLine = GetViewLine(position);
					num3 = viewLine.PositionToCharacterIndex(position);
					if (!viewLine.IsVirtualCharacter(num3, lineTerminatorsAreVirtual: true))
					{
						return text;
					}
					goto case 2;
				case 1:
					return result;
				default:
				{
					int num6 = (num4 - num5) / tabSize;
					int num7 = num4 - num5 - num6 * tabSize;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(text);
					if (num5 > 0)
					{
						stringBuilder.Append((num6 + num7 > 0) ? Q7Z.tqM(7824) : new string(' ', num5));
					}
					if (num6 > 0)
					{
						stringBuilder.Append(new string('\t', num6));
					}
					if (num7 > 0)
					{
						stringBuilder.Append(new string(' ', num7));
					}
					return stringBuilder.ToString();
				}
				case 2:
				{
					num4 = num3 - viewLine.CharacterCount;
					IEditorDocument document = base.SyntaxEditor.Document;
					if (!document.AutoConvertTabsToSpaces)
					{
						tabSize = document.TabSize;
						num5 = Math.Min(num4, tabSize - GetCharacterColumn(viewLine.EndOffset) % tabSize);
						if (num5 == tabSize)
						{
							num5 = 0;
							num2 = 0;
							if (CBa() != null)
							{
								num2 = 0;
							}
							goto IL_0012;
						}
						goto default;
					}
					return text + new string(' ', num4);
				}
				}
				text = string.Empty;
				num2 = 3;
			}
			while (CBa() == null);
		}
	}

	public void InsertFile(string path)
	{
		string text;
		using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
		{
			text = streamReader.ReadToEnd();
		}
		ReplaceSelectedText(TextChangeTypes.InsertFile, text, new EditorViewTextChangeOptions(this)
		{
			CheckReadOnly = true
		});
	}

	public bool InsertSurroundingText(string preText, string postText)
	{
		return InsertSurroundingText(TextChangeTypes.TextReplacement, preText, postText, reselect: false);
	}

	public bool InsertSurroundingText(ITextChangeType type, string preText, string postText)
	{
		return InsertSurroundingText(type, preText, postText, reselect: false);
	}

	public bool InsertSurroundingText(ITextChangeType type, string preText, string postText, bool reselect)
	{
		if (postText == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7830));
		}
		using (JDe.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			if (!string.IsNullOrEmpty(preText) || !string.IsNullOrEmpty(postText))
			{
				ITextSnapshot currentSnapshot = base.CurrentSnapshot;
				EditorViewTextChangeOptions options = new EditorViewTextChangeOptions(this)
				{
					CheckReadOnly = true
				};
				ITextChange textChange = currentSnapshot.CreateTextChange(type, options);
				int num = JDe.FirstOffset;
				int num2 = JDe.LastOffset;
				if (!string.IsNullOrEmpty(preText))
				{
					preText = preText.Replace(Q7Z.tqM(7850), string.Empty);
					textChange.InsertText(num, preText);
					int length = preText.Length;
					num += length;
					num2 += length;
				}
				if (!string.IsNullOrEmpty(postText))
				{
					postText = postText.Replace(Q7Z.tqM(7850), string.Empty);
					textChange.InsertText(num2, postText);
				}
				if (textChange.Apply())
				{
					if (reselect)
					{
						JDe.SelectRange(new TextRange(num, num2));
					}
					else
					{
						JDe.StartOffset = num2;
					}
					return true;
				}
			}
		}
		return false;
	}

	public void PasteFromClipboard()
	{
		ExecuteEditAction(new PasteFromClipboardAction());
	}

	public void PasteFromClipboard(IDataObject clipboardData)
	{
		if (clipboardData == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7856));
		}
		ExecuteEditAction(new PasteFromClipboardAction(new cTH(clipboardData)));
	}

	public bool ReplaceSelectedText(ITextChangeType type, string text)
	{
		return ReplaceSelectedText(type, text, null);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public bool ReplaceSelectedText(ITextChangeType type, string text, IEditorViewTextChangeOptions options)
	{
		if (options == null)
		{
			options = new EditorViewTextChangeOptions(this);
		}
		if (options.Source == null)
		{
			options.Source = this;
		}
		SelectionModes selectionModes = ((!JDe.IsZeroLength || JDe.Ranges.Count != 1) ? ((JDe.Mode != SelectionModes.Block || JDe.PositionRange.Lines <= 1) ? SelectionModes.ContinuousStream : SelectionModes.Block) : SelectionModes.None);
		SelectionModes selectionModes2 = ((text != null && text.Length != 0) ? ((!options.IsBlock) ? SelectionModes.ContinuousStream : SelectionModes.Block) : SelectionModes.None);
		if (text != null && text.IndexOf('\r') != -1)
		{
			text = text.Replace(Q7Z.tqM(7886), Q7Z.tqM(7894)).Replace('\r', '\n');
		}
		if (selectionModes == SelectionModes.None && selectionModes2 == SelectionModes.None)
		{
			if (options.ZeroLengthEditRangeAdjustFunc == null)
			{
				return false;
			}
			selectionModes2 = SelectionModes.ContinuousStream;
		}
		ITextSnapshot currentSnapshot = base.CurrentSnapshot;
		ITextChange textChange = currentSnapshot.CreateTextChange(type, options);
		IEditorViewSelectionState editorViewSelectionState = JDe.CaptureState();
		textChange.PreSelectionPositionRanges = ((selectionModes == SelectionModes.Block && editorViewSelectionState.Ranges.Count == 1) ? TextPositionRange.CreateCollection(editorViewSelectionState.Ranges[0], isBlock: true) : TextPositionRange.CreateCollection(editorViewSelectionState.Ranges, editorViewSelectionState.Ranges.PrimaryIndex));
		bool flag = false;
		if (selectionModes == SelectionModes.Block)
		{
			int num = -1;
			bool flag2 = false;
			if (selectionModes2 == SelectionModes.ContinuousStream)
			{
				flag2 = options.CanApplyToBlockEdit && selectionModes2 == SelectionModes.ContinuousStream && text.IndexOf('\n') == -1;
				if (!flag2)
				{
					IList<TextRange> textRanges = JDe.GetTextRanges();
					for (int num2 = textRanges.Count - 1; num2 >= 0; num2--)
					{
						TextRange textRange = textRanges[num2];
						if (textRange.Length > 0)
						{
							textChange.DeleteText(textRange);
						}
						num = ((num != -1) ? (num - textRange.Length) : textRange.StartOffset);
					}
					flag = true;
				}
			}
			if (selectionModes2 != SelectionModes.ContinuousStream || flag2)
			{
				string[] array = text.Split('\n');
				IList<Range> characterIndexRanges = GetCharacterIndexRanges(JDe.PositionRange, array.Length);
				if (flag2)
				{
					array = new string[characterIndexRanges.Count];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = text;
					}
				}
				ITextViewLine textViewLine = GetViewLine(JDe.FirstPosition);
				for (int j = 1; j < characterIndexRanges.Count; j++)
				{
					textViewLine = GetViewLine(textViewLine, 1, forceVirtualSpace: true);
				}
				for (int num3 = characterIndexRanges.Count - 1; num3 >= 0; num3--)
				{
					Range arg = characterIndexRanges[num3];
					if (options.BlockEditRangeAdjustFunc != null)
					{
						arg = options.BlockEditRangeAdjustFunc(textViewLine, arg);
					}
					TextPosition position = textViewLine.CharacterIndexToPosition(arg.Min);
					string text2 = ((num3 < array.Length) ? GetVirtualCharacterFillString(position, returnCharacterFill: true) : string.Empty);
					TextRange textRange2 = new TextRange(textViewLine.CharacterIndexToOffset(arg.Min), textViewLine.CharacterIndexToOffset(arg.Max));
					if (num == -1)
					{
						num = textRange2.EndOffset;
					}
					string text3 = text2 + ((num3 < array.Length) ? array[num3] : string.Empty);
					if (textRange2.Length > 0 || !string.IsNullOrEmpty(text3))
					{
						textChange.ReplaceText(textRange2, text3);
					}
					num += text3.Length - textRange2.Length;
					textViewLine = textViewLine.PreviousLine;
				}
				if (textChange.Apply())
				{
					if (selectionModes2 != SelectionModes.Block || options.SelectInsertedText)
					{
						editorViewSelectionState.Restore(!options.SelectInsertedText);
					}
					else if (num != -1)
					{
						JDe.StartOffset = num;
					}
					return true;
				}
				return false;
			}
		}
		if (selectionModes2 == SelectionModes.ContinuousStream || (selectionModes == SelectionModes.ContinuousStream && selectionModes2 == SelectionModes.None))
		{
			int primaryIndex = (options.CanApplyToMultipleSelections ? editorViewSelectionState.Ranges.PrimaryIndex : 0);
			TextPositionRange[] array2 = (options.CanApplyToMultipleSelections ? editorViewSelectionState.Ranges.ToArray() : new TextPositionRange[1] { editorViewSelectionState.Ranges.Primary });
			if (options.ZeroLengthEditRangeAdjustFunc != null)
			{
				for (int num4 = array2.Length - 1; num4 >= 0; num4--)
				{
					if (array2[num4].IsZeroLength)
					{
						TextPositionRange textPositionRange = options.ZeroLengthEditRangeAdjustFunc(array2[num4].EndPosition);
						if (num4 <= 0 || !(textPositionRange.StartPosition < array2[num4 - 1].EndPosition))
						{
							array2[num4] = textPositionRange;
						}
					}
				}
			}
			TextPosition[] array3 = new TextPosition[array2.Length];
			for (int num5 = array2.Length - 1; num5 >= 0; num5--)
			{
				string text4 = string.Empty;
				int num6 = 0;
				TextPositionRange positionRange = array2[num5].NormalizedTextPositionRange;
				TextRange textRange3 = currentSnapshot.PositionRangeToTextRange(positionRange);
				int firstOffset = textRange3.FirstOffset;
				int length = textRange3.Length;
				string virtualCharacterFillString = GetVirtualCharacterFillString(positionRange.StartPosition, options.VirtualCharacterFill);
				if (!string.IsNullOrEmpty(virtualCharacterFillString))
				{
					positionRange = currentSnapshot.TextRangeToPositionRange(textRange3);
				}
				if (type == TextChangeTypes.Enter)
				{
					IEditorDocument document = base.SyntaxEditor.Document;
					IIndentProvider indentProvider = document.Language.GetIndentProvider();
					if (indentProvider == null || indentProvider.Mode != IndentMode.None)
					{
						ITextSnapshotLine textSnapshotLine = base.CurrentSnapshot.Lines[JDe.FirstPosition.Line];
						int num7 = textSnapshotLine.GetIndentAmountBefore(JDe.FirstOffset);
						if (indentProvider != null && indentProvider.Mode == IndentMode.Smart)
						{
							num7 = Math.Max(0, indentProvider.GetIndentAmount(new TextSnapshotOffset(base.CurrentSnapshot, JDe.FirstOffset), num7));
							ITextBufferReader bufferReader = base.CurrentSnapshot.GetReader(JDe.LastOffset).BufferReader;
							while (!bufferReader.IsAtEnd && char.IsWhiteSpace(bufferReader.Peek()) && bufferReader.Peek() != '\n')
							{
								num6++;
								bufferReader.Read();
							}
						}
						text4 = StringHelper.GetIndentText(document.AutoConvertTabsToSpaces, document.TabSize, num7);
					}
				}
				int num8 = ((!flag) ? length : 0) + num6;
				string text5 = virtualCharacterFillString + text + text4;
				if (num8 > 0 || !string.IsNullOrEmpty(text5))
				{
					textChange.ReplaceText(firstOffset, num8, text5);
				}
				TextPosition textPosition = TextPosition.Zero;
				if (!positionRange.IsZeroLength)
				{
					int num9 = positionRange.EndPosition.Line - positionRange.StartPosition.Line;
					textPosition = ((num9 <= 0) ? new TextPosition(0, positionRange.StartPosition.Character - positionRange.EndPosition.Character) : new TextPosition(-num9, -positionRange.EndPosition.Character));
				}
				TextPosition textPositionDelta = StringHelper.GetTextPositionDelta(text5);
				array3[num5] = new TextPosition(textPosition.Line + textPositionDelta.Line, textPosition.Character + textPositionDelta.Character);
				TextPosition textPosition2 = new TextPosition(positionRange.StartPosition.Line + textPositionDelta.Line, ((textPositionDelta.Line == 0) ? positionRange.StartPosition.Character : 0) + textPositionDelta.Character);
				if (options.SelectInsertedText)
				{
					array2[num5] = new TextPositionRange(positionRange.StartPosition, textPosition2);
				}
				else
				{
					array2[num5] = new TextPositionRange(textPosition2);
				}
			}
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			for (int k = 0; k < array2.Length; k++)
			{
				TextPositionRange textPositionRange2 = array2[k];
				TextPosition textPosition3 = array3[k];
				textPositionRange2 = (array2[k] = ((textPositionRange2.StartPosition.Line != num10) ? new TextPositionRange(textPositionRange2.StartPosition.Line + num11, textPositionRange2.StartPosition.Character, textPositionRange2.EndPosition.Line + num11, textPositionRange2.EndPosition.Character) : new TextPositionRange(textPositionRange2.StartPosition.Line + num11, textPositionRange2.StartPosition.Character + num12, textPositionRange2.EndPosition.Line + num11, textPositionRange2.EndPosition.Character + ((textPositionRange2.Lines == 1) ? num12 : 0))));
				if (textPositionRange2.EndPosition.Line != num10)
				{
					num10 = textPositionRange2.EndPosition.Line;
					num12 = 0;
				}
				num11 += textPosition3.Line;
				num12 += textPosition3.Character;
			}
			textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array2, primaryIndex);
			if (!textChange.Apply())
			{
				return false;
			}
			if (JDe.Ranges.Count == 1)
			{
				ITextViewLineCollection visibleViewLines = base.VisibleViewLines;
				if (visibleViewLines != null && visibleViewLines.Count > 0 && editorViewSelectionState.Ranges.Primary.FirstPosition < visibleViewLines[0].StartPosition)
				{
					PTg cDH = CDH;
					TextViewScrollState textViewScrollState = new TextViewScrollState(JDe.CaretPosition, TextViewVerticalAnchorPlacement.Center, 0.0, base.ScrollState.HorizontalAmount)
					{
						CanScrollPastDocumentEnd = base.SyntaxEditor.CanScrollPastDocumentEnd
					};
					cDH.ScrollTo(textViewScrollState);
				}
			}
		}
		else if (selectionModes2 == SelectionModes.Block)
		{
			if (selectionModes == SelectionModes.ContinuousStream)
			{
			}
			string[] array4 = text.Split('\n');
			IList<Range> characterIndexRanges2 = GetCharacterIndexRanges(JDe.PositionRange, array4.Length);
			TextPosition firstPosition = JDe.FirstPosition;
			ITextViewLine textViewLine2 = GetViewLine(firstPosition);
			for (int l = 1; l < characterIndexRanges2.Count; l++)
			{
				textViewLine2 = GetViewLine(textViewLine2, 1, forceVirtualSpace: true);
			}
			int num13 = 0;
			if (textViewLine2.IsVirtualLine)
			{
				num13 = Math.Max(0, textViewLine2.StartPosition.Line - (base.CurrentSnapshot.Lines.Count - 1));
			}
			int num14 = -1;
			for (int num15 = characterIndexRanges2.Count - 1; num15 >= 0; num15--)
			{
				Range range = characterIndexRanges2[num15];
				TextPosition position2 = textViewLine2.CharacterIndexToPosition(range.Min);
				string text6 = ((num13 > 0) ? ((position2.Character <= 0) ? Q7Z.tqM(7894) : (Q7Z.tqM(7894) + new string(' ', position2.Character))) : ((num15 >= array4.Length) ? string.Empty : GetVirtualCharacterFillString(position2, returnCharacterFill: true)));
				TextRange textRange4 = new TextRange(textViewLine2.CharacterIndexToOffset(range.Min), textViewLine2.CharacterIndexToOffset(range.Max));
				if (selectionModes == SelectionModes.ContinuousStream && JDe.TextRange.OverlapsWith(textViewLine2.TextRange))
				{
					textRange4 = TextRange.Union(textRange4, new TextRange(Math.Max(JDe.FirstOffset, textViewLine2.StartOffset), Math.Min(JDe.LastOffset, textViewLine2.EndOffset)));
				}
				if (num14 == -1)
				{
					num14 = textRange4.EndOffset;
				}
				string text7 = text6 + ((num15 < array4.Length) ? array4[num15] : string.Empty);
				textChange.ReplaceText(textRange4, text7);
				num14 += text7.Length - textRange4.Length;
				textViewLine2 = textViewLine2.PreviousLine;
				if (num13 > 0)
				{
					num13--;
				}
			}
			if (textChange.Apply())
			{
				if (options.SelectInsertedText)
				{
					if (selectionModes2 == SelectionModes.Block)
					{
						TextPosition textPosition4 = OffsetToPosition(num14);
						JDe.SelectRange(firstPosition, textPosition4, SelectionModes.Block);
						textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(new TextPositionRange(firstPosition, textPosition4), isBlock: true);
					}
					else
					{
						editorViewSelectionState.Restore();
						textChange.PostSelectionPositionRanges = TextPositionRange.CreateCollection(JDe.Ranges, JDe.Ranges.PrimaryIndex);
					}
				}
				else if (num14 != -1)
				{
					JDe.StartOffset = num14;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private void UKL()
	{
		if (KDl != null)
		{
			KDl.RegionsChanged -= TK8;
			KDl = null;
		}
	}

	private void jKn()
	{
		KDl = new jTa(this);
		KDl.RegionsChanged += TK8;
	}

	private void TK8(object P_0, TextSnapshotRangeEventArgs P_1)
	{
		Gf1((vTP)1, P_1.SnapshotRange);
		if (JDe != null)
		{
			int num = 0;
			if (!RBx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			JDe.lom();
		}
		if (base.SyntaxEditor.IsDelimiterHighlightingEnabled)
		{
			DelimiterHighlightTagger value = null;
			if (base.Properties.TryGetValue<DelimiterHighlightTagger>(typeof(DelimiterHighlightTagger), out value))
			{
				value?.A8d(_0020: true);
			}
		}
	}

	internal void qKI()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = HasFocusChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnHasFocusChanged(e);
		RaiseEvent(e);
	}

	internal void DK5()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		bool flag = e.RoutedEvent == null;
		int num = 0;
		if (CBa() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			e.RoutedEvent = HighlightedResultSearchOptionsChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnHighlightedResultSearchOptionsChanged(e);
		RaiseEvent(e);
	}

	internal void CK0(EditorViewSelectionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = SelectionChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnSelectionChanged(P_0);
		RaiseEvent(P_0);
	}

	protected virtual void OnHasFocusChanged(RoutedEventArgs e)
	{
		Gf1((vTP)4);
	}

	protected virtual void OnHighlightedResultSearchOptionsChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnSelectionChanged(EditorViewSelectionEventArgs e)
	{
		bool isActive = IsActive;
		if (isActive)
		{
			Xfe();
		}
		if (FDo != null)
		{
			FDo.N8x();
		}
		if (isActive)
		{
			if (e != null && e.CanScrollToCaret)
			{
				lfz().ScrollToCaret();
			}
			base.SyntaxEditor.LGl()?.jRb();
		}
		if (e != null && e.CanResetSearchStartOffset)
		{
			Hfw();
		}
		DT2 dT = base.SyntaxEditor.jGF();
		if (dT != null)
		{
			foreach (IEditorViewSelectionChangeEventSink item in dT.g6Q<IEditorViewSelectionChangeEventSink>(_0020: true, this))
			{
				item.NotifySelectionChanged(this, e);
			}
		}
		base.SyntaxEditor.ixn(new EditorViewSelectionEventArgs(e));
		qf0();
		if ((e != null && e.PreviousSelectionRanges.Any((TextPositionRange pr) => !pr.IsZeroLength)) || JDe.Ranges.Any((TextPositionRange pr) => !pr.IsZeroLength) || base.SyntaxEditor.IsCurrentLineHighlightingEnabled)
		{
			Gf1((vTP)4);
		}
	}

	private void FKB()
	{
		eDv = new InputAdapter(this);
		eDv.PointerCaptureLost += wKS;
		eDv.PointerExited += gKy;
		eDv.PointerMoved += wK2;
		eDv.PointerPressed += DK7;
		eDv.PointerReleased += vKi;
		eDv.PointerWheelChanged += lKp;
		eDv.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.PointerWheelChanged;
	}

	private void hKV(InputPointerEventArgs P_0)
	{
		xfG();
		base.SyntaxEditor.IGv().RYy(this, P_0);
	}

	private void nKr()
	{
		if (!vAE.E0C(this))
		{
			HDf.KBF((gAJ)128, _0020: true);
			Focus();
			HDf.KBF((gAJ)128, _0020: false);
		}
	}

	private bool mKs(InputPointerEventArgs P_0)
	{
		return TextAreaViewportBounds.Contains(P_0.GetPosition(this));
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool yfy()
	{
		return VD4;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void ofq(bool value)
	{
		VD4 = value;
	}

	[SpecialName]
	internal bool ef7()
	{
		if (LDF != null)
		{
			GAj gAj = LDF.Kind;
			GAj gAj2 = gAj;
			if ((uint)(gAj2 - 5) <= 3u)
			{
				return true;
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void nKk()
	{
		if (LDF == null)
		{
			return;
		}
		switch (LDF.Kind)
		{
		case (GAj)9:
			hKV(null);
			return;
		case (GAj)0:
		case (GAj)1:
		case (GAj)2:
		case (GAj)3:
		case (GAj)4:
		case (GAj)6:
		case (GAj)8:
		{
			Rect textAreaViewportBounds = TextAreaViewportBounds;
			if (textAreaViewportBounds.Contains(cD1) && textAreaViewportBounds.Y != cD1.Y)
			{
				break;
			}
			TextViewScrollState scrollState = base.ScrollState;
			if (cD1.Y <= textAreaViewportBounds.Top)
			{
				if (textAreaViewportBounds.Top - cD1.Y < 10.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, -1, null, forceVirtualSpace: false);
				}
				else if (textAreaViewportBounds.Top - cD1.Y < 20.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, -2, null, forceVirtualSpace: false);
				}
				else if (textAreaViewportBounds.Top - cD1.Y < 30.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, -3, null, forceVirtualSpace: false);
				}
				else
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, -5, null, forceVirtualSpace: false);
				}
			}
			else if (cD1.Y > textAreaViewportBounds.Bottom)
			{
				if (cD1.Y - textAreaViewportBounds.Bottom < 10.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, 1, null, forceVirtualSpace: false);
				}
				else if (cD1.Y - textAreaViewportBounds.Bottom < 20.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, 2, null, forceVirtualSpace: false);
				}
				else if (cD1.Y - textAreaViewportBounds.Bottom < 30.0)
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, 3, null, forceVirtualSpace: false);
				}
				else
				{
					scrollState.VerticalAnchorTextPosition = PositionFinder.GetPositionForLineDelta(scrollState.VerticalAnchorTextPosition, 5, null, forceVirtualSpace: false);
				}
			}
			if (cD1.X < textAreaViewportBounds.Left)
			{
				if (textAreaViewportBounds.Left - cD1.X < 10.0)
				{
					scrollState.HorizontalAmount = Math.Max(0.0, scrollState.HorizontalAmount - 1.0 * base.DefaultCharacterWidth);
				}
				else if (textAreaViewportBounds.Left - cD1.X < 20.0)
				{
					scrollState.HorizontalAmount = Math.Max(0.0, scrollState.HorizontalAmount - 2.0 * base.DefaultCharacterWidth);
				}
				else if (textAreaViewportBounds.Left - cD1.X < 30.0)
				{
					scrollState.HorizontalAmount = Math.Max(0.0, scrollState.HorizontalAmount - 3.0 * base.DefaultCharacterWidth);
				}
				else
				{
					scrollState.HorizontalAmount = Math.Max(0.0, scrollState.HorizontalAmount - 5.0 * base.DefaultCharacterWidth);
				}
			}
			else if (cD1.X > textAreaViewportBounds.Right)
			{
				double maxWidth = base.VisibleViewLines.MaxWidth;
				double val = Math.Max(0.0, maxWidth - (double)(int)(0.85 * TextAreaSize.Width));
				if (cD1.X - textAreaViewportBounds.Right < 10.0)
				{
					scrollState.HorizontalAmount = Math.Min(val, scrollState.HorizontalAmount + 1.0 * base.DefaultCharacterWidth);
				}
				else if (cD1.X - textAreaViewportBounds.Right < 20.0)
				{
					scrollState.HorizontalAmount = Math.Min(val, scrollState.HorizontalAmount + 2.0 * base.DefaultCharacterWidth);
				}
				else if (cD1.X - textAreaViewportBounds.Right < 30.0)
				{
					scrollState.HorizontalAmount = Math.Min(val, scrollState.HorizontalAmount + 3.0 * base.DefaultCharacterWidth);
				}
				else
				{
					scrollState.HorizontalAmount = Math.Min(val, scrollState.HorizontalAmount + 5.0 * base.DefaultCharacterWidth);
				}
			}
			if (CDH != null && !base.ScrollState.Equals(scrollState))
			{
				CDH.ScrollTo(scrollState);
			}
			if (LDF.zBY() || TextAreaViewportBounds.Contains(cD1) || ef7())
			{
				BKN(cD1);
			}
			else
			{
				HKh(cD1);
			}
			break;
		}
		}
		Dfa(LDF.Kind);
	}

	private void wKS(object P_0, InputPointerEventArgs P_1)
	{
		xfG();
		FfX();
	}

	private void eK9(object P_0, InputPointerEventArgs P_1)
	{
		Tfx(P_1);
		if (P_1.Handled)
		{
			return;
		}
		IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
		foreach (IEditorViewPointerInputEventSink item in enumerable)
		{
			item.NotifyPointerEntered(this, P_1);
			if (P_1.Handled)
			{
				break;
			}
		}
	}

	private void gKy(object P_0, InputPointerEventArgs P_1)
	{
		FfX();
		IHitTestResult hitTestResult = base.SyntaxEditor.HitTest(P_1.GetPosition(base.SyntaxEditor));
		Pff(hitTestResult);
		if (P_1.Handled)
		{
			return;
		}
		IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
		foreach (IEditorViewPointerInputEventSink item in enumerable)
		{
			item.NotifyPointerExited(this, P_1);
			if (P_1.Handled)
			{
				break;
			}
		}
	}

	private void IKq()
	{
		if (JDY != null)
		{
			JDY.Stop();
		}
		if (TDR == null)
		{
			return;
		}
		TDR.Handled = false;
		IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
		IEnumerator<IEditorViewPointerInputEventSink> enumerator = enumerable.GetEnumerator();
		int num = 0;
		if (!RBx())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				IEditorViewPointerInputEventSink current = enumerator.Current;
				current.NotifyPointerHovered(this, TDR);
				if (TDR.Handled)
				{
					break;
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		TDR = null;
	}

	private void wK2(object P_0, InputPointerEventArgs P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (LDF != null)
					{
						cD1 = LDF.xBR(cD1);
					}
					Tfx(P_1);
					IHitTestResult hitTestResult = base.SyntaxEditor.HitTest(P_1.GetPosition(base.SyntaxEditor));
					Pff(hitTestResult);
					if (P_1.Handled)
					{
						return;
					}
					IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
					foreach (IEditorViewPointerInputEventSink item in enumerable)
					{
						item.NotifyPointerMoved(this, P_1);
						if (!P_1.Handled)
						{
							continue;
						}
						break;
					}
					if (!P_1.Handled)
					{
						xKZ(P_1);
					}
					return;
				}
				case 1:
					break;
				}
				cD1 = P_1.GetPosition(this);
				num2 = 0;
			}
			while (CBa() == null);
		}
	}

	private void DK7(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (base.SyntaxEditor.MacroRecording.State == MacroRecordingState.Recording)
		{
			nKr();
			P_1.Handled = true;
			return;
		}
		bool flag = false;
		if (!P_1.Handled)
		{
			IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
			foreach (IEditorViewPointerInputEventSink item in enumerable)
			{
				item.NotifyPointerPressed(this, P_1);
				if (P_1.Handled)
				{
					break;
				}
			}
			if (!P_1.Handled)
			{
				flag = MKd(P_1);
			}
		}
		if (!flag && P_1.IsPrimaryButton)
		{
			xfG();
		}
		DDX(EditorViewSelectionGripper.tgU(P_1) && base.SyntaxEditor.AreSelectionGrippersEnabled);
	}

	private void vKi(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (base.SyntaxEditor.MacroRecording.State == MacroRecordingState.Recording)
		{
			P_1.Handled = true;
			return;
		}
		if (!P_1.Handled)
		{
			IKz(P_1);
		}
		if (P_1.Handled)
		{
			return;
		}
		IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
		foreach (IEditorViewPointerInputEventSink item in enumerable)
		{
			item.NotifyPointerReleased(this, P_1);
			if (P_1.Handled)
			{
				break;
			}
		}
	}

	private void lKp(object P_0, InputPointerWheelEventArgs P_1)
	{
		if (P_1.Handled)
		{
			return;
		}
		IEnumerable<IEditorViewPointerInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewPointerInputEventSink>(_0020: true, this);
		foreach (IEditorViewPointerInputEventSink item in enumerable)
		{
			item.NotifyPointerWheel(this, P_1);
			if (P_1.Handled)
			{
				break;
			}
		}
		if (!P_1.Handled)
		{
			sfP(P_1);
		}
	}

	private void aKM(object P_0, RequestBringIntoViewEventArgs P_1)
	{
		if (P_1.OriginalSource == this && P_1.TargetRect.IsEmpty && HDf.RB1((gAJ)128))
		{
			P_1.Handled = true;
		}
	}

	internal void mKO()
	{
		HDf.KBF((gAJ)1, _0020: true);
		TfK(_0020: false);
		base.SyntaxEditor.gGw().K4g(this);
		base.SyntaxEditor.LGl().XRH();
		qKI();
	}

	internal void oKU(KeyEventArgs P_0)
	{
		base.SyntaxEditor.ElementTransparencyManager.wjx(P_0);
		IEnumerable<IEditorViewKeyInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewKeyInputEventSink>(_0020: true, this);
		foreach (IEditorViewKeyInputEventSink item in enumerable)
		{
			item.NotifyKeyDown(this, P_0);
			if (P_0.Handled)
			{
				break;
			}
		}
		bool flag = !P_0.Handled;
		int num = 0;
		if (!RBx())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag && P_0.Key == Key.Escape)
		{
			IOverlayPane overlayPane = lDg.LastOrDefault();
			if (overlayPane != null)
			{
				overlayPane.Close();
				P_0.Handled = true;
			}
		}
	}

	internal void HKJ(KeyEventArgs P_0)
	{
		base.SyntaxEditor.ElementTransparencyManager.wjx(P_0);
		IEnumerable<IEditorViewKeyInputEventSink> enumerable = base.SyntaxEditor.jGF().g6Q<IEditorViewKeyInputEventSink>(_0020: true, this);
		foreach (IEditorViewKeyInputEventSink item in enumerable)
		{
			item.NotifyKeyUp(this, P_0);
			if (P_0.Handled)
			{
				break;
			}
		}
	}

	internal void gKt()
	{
		HDf.KBF((gAJ)1, _0020: false);
		TfK(_0020: false);
		DDX(value: false);
		xfG();
		base.SyntaxEditor.LGl().GRL(_0020: false);
		if (IsIncrementalSearchActive && !vAE.E0C(this))
		{
			IsIncrementalSearchActive = false;
			int num = 0;
			if (!RBx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		base.SyntaxEditor.ElementTransparencyManager.sja();
		qKI();
	}

	private void xKZ(InputPointerEventArgs P_0)
	{
		if (LDF == null)
		{
			return;
		}
		P_0.Handled = true;
		Point position = P_0.GetPosition(this);
		switch (LDF.Kind)
		{
		case (GAj)5:
		case (GAj)7:
		case (GAj)9:
			if (vAE.x0v(LDF.iBI(), position, P_0.DeviceKind == InputDeviceKind.Touch))
			{
				switch (LDF.Kind)
				{
				case (GAj)9:
					hKV(P_0);
					return;
				case (GAj)7:
					afc(P_0, (GAj)8, LDF.FBo(), LDF.EB6());
					break;
				case (GAj)5:
					afc(P_0, (GAj)6, LDF.FBo(), LDF.EB6());
					break;
				}
			}
			break;
		}
		Point point = LDF.xBR(position);
		if (LDF.zBY() || mKs(P_0) || ef7())
		{
			BKN(point);
		}
		else
		{
			HKh(point);
		}
		Dfa(LDF.Kind);
	}

	private void HKh(Point P_0)
	{
		if (LDF == null || LDF.zBY())
		{
			return;
		}
		GAj gAj = LDF.Kind;
		GAj gAj2 = gAj;
		if ((uint)gAj2 > 4u)
		{
			return;
		}
		Point location = TransformToTextArea(P_0);
		TextPosition position = LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
		if (!position.IsEmpty)
		{
			ITextViewLine viewLine = GetViewLine(JDe.StartPosition);
			ITextViewLine viewLine2 = GetViewLine(position);
			if (viewLine2.StartPosition < viewLine.StartPosition)
			{
				JDe.IoR(new TextPositionRange(viewLine.EndPosition, viewLine2.StartPosition));
			}
			else if (viewLine2.IsLastLine)
			{
				JDe.IoR(new TextPositionRange(viewLine.StartPosition, viewLine2.EndPosition));
			}
			else
			{
				JDe.IoR(new TextPositionRange(viewLine.StartPosition, viewLine2.NextLine.StartPosition));
			}
		}
	}

	private void BKN(Point P_0)
	{
		if (LDF == null)
		{
			return;
		}
		Point point = TransformToTextArea(P_0);
		switch (LDF.Kind)
		{
		case (GAj)0:
		case (GAj)3:
		case (GAj)6:
		case (GAj)8:
		{
			TextPosition textPosition = BfF(point, LocationToPositionAlgorithm.BestFit, LDF.Kind == (GAj)3);
			if (textPosition.IsEmpty)
			{
				break;
			}
			if (LDF.nBT())
			{
				JDe.IoR(new TextPositionRange(JDe.StartPosition, textPosition));
				break;
			}
			using (JDe.CreateBatch(EditorViewSelectionBatchOptions.NoScrollToCaret))
			{
				JDe.IoR(new TextPositionRange(textPosition, JDe.EndPosition));
				break;
			}
		}
		case (GAj)1:
		case (GAj)4:
		{
			TextPosition position2 = BfF(point, LocationToPositionAlgorithm.BestFit, LDF.Kind == (GAj)4);
			if (!position2.IsEmpty)
			{
				int offset2 = PositionToOffset(position2);
				TextRange wordTextRange = base.CurrentSnapshot.GetWordTextRange(LDF.FBo() ?? JDe.StartOffset);
				TextRange wordTextRange2 = base.CurrentSnapshot.GetWordTextRange(offset2);
				if (wordTextRange.StartOffset <= wordTextRange2.StartOffset)
				{
					JDe.IoR(base.CurrentSnapshot.TextRangeToPositionRange(new TextRange(wordTextRange.StartOffset, wordTextRange2.EndOffset)));
				}
				else
				{
					JDe.IoR(base.CurrentSnapshot.TextRangeToPositionRange(new TextRange(wordTextRange.EndOffset, wordTextRange2.StartOffset)));
				}
			}
			break;
		}
		case (GAj)2:
		{
			TextPosition position = BfF(point, LocationToPositionAlgorithm.BestFit, _0020: false);
			if (!position.IsEmpty)
			{
				int offset = PositionToOffset(position);
				TextRange textRangeIncludingLineTerminator = GetViewLine(LDF.FBo() ?? JDe.StartOffset).TextRangeIncludingLineTerminator;
				TextRange textRangeIncludingLineTerminator2 = GetViewLine(offset).TextRangeIncludingLineTerminator;
				if (textRangeIncludingLineTerminator.StartOffset <= textRangeIncludingLineTerminator2.StartOffset)
				{
					JDe.IoR(base.CurrentSnapshot.TextRangeToPositionRange(new TextRange(textRangeIncludingLineTerminator.StartOffset, textRangeIncludingLineTerminator2.EndOffset)));
				}
				else
				{
					JDe.IoR(base.CurrentSnapshot.TextRangeToPositionRange(new TextRange(textRangeIncludingLineTerminator.EndOffset, textRangeIncludingLineTerminator2.StartOffset)));
				}
			}
			break;
		}
		case (GAj)5:
		case (GAj)7:
			break;
		}
	}

	private bool MKd(InputPointerButtonEventArgs P_0)
	{
		if (LDF != null)
		{
			P_0.Handled = true;
			return true;
		}
		bool result = false;
		InputPointerButtonKind buttonKind = P_0.ButtonKind;
		InputPointerButtonKind inputPointerButtonKind = buttonKind;
		if ((uint)inputPointerButtonKind <= 1u && mKs(P_0))
		{
			StartPointerSelection(P_0);
			result = P_0.Handled || P_0.DeviceKind == InputDeviceKind.Touch;
		}
		return result;
	}

	private void IKz(InputPointerButtonEventArgs P_0)
	{
		if (LDF != null)
		{
			if (P_0.ButtonKind == InputPointerButtonKind.Primary)
			{
				switch (LDF.Kind)
				{
				case (GAj)9:
					NfW(P_0);
					break;
				case (GAj)5:
				case (GAj)7:
					if (EditorViewSelectionGripper.tgU(P_0))
					{
						IHitTestResult hitTestResult = base.SyntaxEditor.HitTest(P_0.GetPosition(base.SyntaxEditor));
						SyntaxEditorMenuEventArgs e = new SyntaxEditorMenuEventArgs(SyntaxEditorMenuKind.SelectionGripperMenu, hitTestResult);
						base.SyntaxEditor.Hxr(e);
					}
					break;
				}
			}
			xfG();
			P_0.Handled = true;
		}
		else if (P_0.ButtonKind == InputPointerButtonKind.Primary && P_0.DeviceKind == InputDeviceKind.Touch && !yfy() && vAE.L0A(dDu, dDu, ADC, DateTime.Now, _0020: true))
		{
			NfW(P_0);
		}
	}

	private void NfW(InputPointerButtonEventArgs P_0)
	{
		if (!mKs(P_0))
		{
			return;
		}
		Point position = P_0.GetPosition(this);
		Point location = TransformToTextArea(position);
		int num = 0;
		if (CBa() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TextPosition position2 = LocationToPosition(location, LocationToPositionAlgorithm.Absolute);
		if (CollapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(base.CurrentSnapshot, PositionToOffset(position2))).IsDeleted)
		{
			TextPosition position3 = LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
			if (!position3.IsEmpty)
			{
				JDe.SelectRange(new TextPositionRange(position3), SelectionModes.ContinuousStream);
			}
		}
	}

	private void sfP(InputPointerWheelEventArgs P_0)
	{
		int delta = P_0.Delta;
		if (P_0 == null || delta == 0 || CDH == null)
		{
			return;
		}
		if (P_0.IsHorizontal)
		{
			P_0.Handled = true;
			double num = (double)(delta / Math.Max(1, P_0.SingleUnitDelta)) * base.DefaultCharacterWidth * (double)P_0.ScrollCharacters;
			CDH.ScrollHorizontallyByPixels(num);
			return;
		}
		ModifierKeys modifierKeys = vAE.A0o();
		SyntaxEditor syntaxEditor = base.SyntaxEditor;
		if ((modifierKeys & ModifierKeys.Control) == ModifierKeys.Control && syntaxEditor != null && (syntaxEditor.ZoomModesAllowed & ZoomModes.Mouse) == ZoomModes.Mouse)
		{
			P_0.Handled = true;
			int num2 = Math.Max(1, P_0.SingleUnitDelta);
			int num3 = ((delta > 0) ? Math.Max(num2, delta) : Math.Min(-num2, delta)) / num2;
			ZoomActionBase.IncrementZoomLevel(this, num3);
			return;
		}
		double num4 = Math.Max(1.0, base.DefaultLineHeight);
		if ((modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift)
		{
			P_0.Handled = true;
			if (delta >= 0 || !(base.ScrollState.HorizontalAmount >= lfz().D4U()))
			{
				double num5 = (double)(-delta / Math.Max(1, P_0.SingleUnitDelta)) * base.DefaultCharacterWidth * (double)P_0.ScrollCharacters;
				CDH.ScrollHorizontallyByPixels(num5);
			}
			return;
		}
		P_0.Handled = true;
		int scrollLines = P_0.ScrollLines;
		if (scrollLines >= 0)
		{
			int num6 = Math.Max(1, P_0.SingleUnitDelta / Math.Max(1, scrollLines));
			int num7 = -(((delta > 0) ? Math.Max(num6, delta) : Math.Min(-num6, delta)) / num6);
			double num8 = (double)num7 * num4;
			CDH.ScrollVerticallyByPixels(num8);
		}
		else
		{
			CDH.ScrollVerticallyByPixels((double)((delta <= 0) ? 1 : (-1)) * Math.Max(num4, TextAreaSize.Height - num4));
		}
	}

	internal void ufE(TextCompositionEventArgs P_0)
	{
		DDX(value: false);
		if (P_0 == null)
		{
			return;
		}
		DT2 dT = base.SyntaxEditor.jGF();
		if (dT != null)
		{
			foreach (IEditorViewTextInputEventSink item in dT.g6Q<IEditorViewTextInputEventSink>(_0020: true, this))
			{
				item.NotifyTextInput(this, P_0);
				if (P_0.Handled)
				{
					break;
				}
			}
		}
		bool flag = !P_0.Handled && !string.IsNullOrEmpty(P_0.Text) && !char.IsControl(P_0.Text[0]);
		int num = 0;
		if (CBa() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			P_0.Handled = true;
			PerformTyping(P_0.Text);
		}
	}

	private void afc(InputPointerEventArgs P_0, GAj P_1, int? P_2, Point P_3 = default(Point))
	{
		if (LDF == null || LDF.Kind != P_1)
		{
			Cursor cursor = (((uint)(P_1 - 5) > 4u) ? (P_2.HasValue ? Cursors.IBeam : CustomCursors.ReverseArrow) : Cursors.Arrow);
			vAE.P01(this, cursor);
			vA8 vA = new vA8();
			vA.sBj(P_2);
			vA.GBH(P_3);
			vA.Kind = P_1;
			vA.yB5(P_0.GetPosition(this));
			LDF = vA;
			eDv.CapturePointer(P_0);
			Dfa(P_1);
		}
	}

	private void Dfa(GAj P_0)
	{
		if (kD3 == null)
		{
			kD3 = base.SyntaxEditor.FGR().PLW(Q7Z.tqM(7900), nKk);
		}
		int num = ((P_0 == (GAj)9) ? 500 : 50);
		kD3.Start(num);
	}

	private void Tfx(InputPointerEventArgs P_0)
	{
		if (JDY == null)
		{
			JDY = base.SyntaxEditor.FGR().PLW(Q7Z.tqM(7930), IKq);
		}
		TDR = P_0;
		JDY.Start(vAE.W0w());
	}

	private void xfG()
	{
		eDv.ReleasePointerCaptures();
		LDF = null;
		if (kD3 != null)
		{
			kD3.Stop();
		}
		vAE.d0c<object>(this, delegate
		{
			vAE.P01(this, null);
		}, null);
	}

	private void FfX()
	{
		TDR = null;
		if (JDY != null)
		{
			JDY.Stop();
		}
	}

	private void TfK(bool P_0)
	{
		bool flag = HasFocus || vAE.y0m(this);
		if (ContainsFocus != flag)
		{
			HDf.KBF((gAJ)2, flag);
			InvalidateRender();
		}
	}

	private void Pff(IHitTestResult P_0)
	{
		if (LDF != null || P_0 == null)
		{
			return;
		}
		nR nR = DAb();
		if (nR == null)
		{
			return;
		}
		bool flag = P_0.Type == HitTestResultType.ViewTextAreaOverCharacter;
		if (flag)
		{
			TextPosition position = P_0.Position;
			int num = 0;
			if (!RBx())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			flag = JDe.Contains(position);
		}
		nR.XAX = flag;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void StartPointerSelection(InputPointerButtonEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (base.SyntaxEditor.MacroRecording.State == MacroRecordingState.Recording)
		{
			return;
		}
		bool flag = true;
		switch (e.ButtonKind)
		{
		default:
			return;
		case InputPointerButtonKind.Primary:
			nKr();
			break;
		case InputPointerButtonKind.Secondary:
			nKr();
			flag = false;
			break;
		}
		Point position = e.GetPosition(this);
		Point location = TransformToTextArea(position);
		TextPosition textPosition = LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
		if (textPosition.IsEmpty)
		{
			return;
		}
		if (flag)
		{
			DateTime aDC = ADC;
			Point point = dDu;
			ADC = DateTime.Now;
			dDu = position;
			bool flag2 = e.DeviceKind == InputDeviceKind.Touch;
			e.Handled = true;
			bool flag3 = vAE.L0A(point, dDu, aDC, ADC, e.DeviceKind == InputDeviceKind.Touch);
			if (flag3 && !flag2 && GDm <= 2)
			{
				GDm++;
			}
			else
			{
				GDm = 1;
			}
			ModifierKeys modifierKeys = vAE.A0o();
			bool flag4 = (modifierKeys & ModifierKeys.Control) == ModifierKeys.Control;
			bool flag5 = (modifierKeys & ModifierKeys.Shift) == ModifierKeys.Shift;
			bool flag6 = (modifierKeys & ModifierKeys.Alt) == ModifierKeys.Alt;
			if (mKs(e))
			{
				int num = PositionToOffset(textPosition);
				if (!flag5 && !flag2 && GDm < 3 && JDe.Ranges.Count == 1 && base.SyntaxEditor.AllowDrag)
				{
					TextPosition textPosition2 = LocationToPosition(location, LocationToPositionAlgorithm.Block);
					if (!textPosition2.IsEmpty && JDe.Contains(textPosition2))
					{
						afc(e, (GAj)9, num);
						return;
					}
				}
				if (flag3)
				{
					if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
					{
						if (GDm == 3)
						{
							JDe.SelectRange(CurrentViewLine.TextRangeIncludingLineTerminator, SelectionModes.ContinuousStream);
							afc(e, (GAj)2, num);
						}
						else
						{
							bool flag7 = !flag2;
							if (flag4 && !flag2 && base.SyntaxEditor.AreMultipleSelectionRangesEnabled)
							{
								flag7 = JDe.ToggleRange(base.CurrentSnapshot.TextRangeToPositionRange(base.CurrentSnapshot.GetWordTextRange(num)));
							}
							else
							{
								JDe.SelectRange(base.CurrentSnapshot.GetWordTextRange(num), SelectionModes.ContinuousStream);
							}
							if (flag7)
							{
								afc(e, (GAj)1, num);
							}
						}
					}
					else
					{
						JDe.SelectRange(new TextPositionRange(textPosition), SelectionModes.ContinuousStream);
					}
					if (flag2 || GDm >= 3)
					{
						ADC = LDA;
					}
				}
				else if (flag2)
				{
					e.Handled = false;
				}
				else if (flag4 && flag5 && flag6)
				{
					if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
					{
						TextRange wordTextRange = base.CurrentSnapshot.GetWordTextRange(JDe.StartOffset);
						TextRange wordTextRange2 = base.CurrentSnapshot.GetWordTextRange(num);
						if (wordTextRange.StartOffset <= wordTextRange2.StartOffset)
						{
							JDe.SelectRange(new TextRange(wordTextRange.StartOffset, wordTextRange2.EndOffset), SelectionModes.Block);
						}
						else
						{
							JDe.SelectRange(new TextRange(wordTextRange.EndOffset, wordTextRange2.StartOffset), SelectionModes.Block);
						}
						afc(e, (GAj)4, num);
					}
				}
				else if (flag6 && flag5)
				{
					if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block))
					{
						JDe.SelectRange(JDe.StartPosition, textPosition, SelectionModes.Block);
						afc(e, (GAj)3, num);
					}
				}
				else if (flag6)
				{
					bool flag8 = base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.Block);
					JDe.SelectRange(new TextPositionRange(textPosition), (!flag8) ? SelectionModes.ContinuousStream : SelectionModes.Block);
					if (flag8)
					{
						afc(e, (GAj)3, num);
					}
				}
				else if (flag4 && flag5)
				{
					if (base.SyntaxEditor.IsSelectionModeAllowed(JDe.Mode))
					{
						TextRange wordTextRange3 = base.CurrentSnapshot.GetWordTextRange(JDe.StartOffset);
						TextRange wordTextRange4 = base.CurrentSnapshot.GetWordTextRange(num);
						if (wordTextRange3.StartOffset <= wordTextRange4.StartOffset)
						{
							JDe.SelectRange(new TextRange(wordTextRange3.StartOffset, wordTextRange4.EndOffset));
						}
						else
						{
							JDe.SelectRange(new TextRange(wordTextRange3.EndOffset, wordTextRange4.StartOffset));
						}
						GAj gAj = ((JDe.Mode == SelectionModes.Block) ? ((GAj)3) : ((GAj)0));
						afc(e, gAj, num);
					}
				}
				else if (flag4)
				{
					if (base.SyntaxEditor.AreMultipleSelectionRangesEnabled)
					{
						if (JDe.ToggleRange(new TextPositionRange(textPosition)) && base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
						{
							afc(e, (GAj)0, num);
						}
					}
					else if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
					{
						JDe.SelectRange(base.CurrentSnapshot.GetWordTextRange(num), SelectionModes.ContinuousStream);
						afc(e, (GAj)1, num);
					}
				}
				else if (flag5)
				{
					if (base.SyntaxEditor.IsSelectionModeAllowed(JDe.Mode))
					{
						JDe.SelectRange(new TextPositionRange(JDe.StartPosition, textPosition));
						GAj gAj2 = ((JDe.Mode == SelectionModes.Block) ? ((GAj)3) : ((GAj)0));
						afc(e, gAj2, num);
					}
				}
				else
				{
					JDe.SelectRange(new TextPositionRange(textPosition), SelectionModes.ContinuousStream);
					if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
					{
						afc(e, (GAj)0, num);
					}
				}
				return;
			}
			ITextViewLine viewLine = GetViewLine(textPosition);
			if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
			{
				bool flag9 = true;
				TextPositionRange? textPositionRange = null;
				if (flag5 && JDe.Ranges.Count == 1 && JDe.Mode == SelectionModes.ContinuousStream)
				{
					ITextViewLine viewLine2 = GetViewLine(JDe.StartPosition);
					textPositionRange = new TextPositionRange(viewLine2.StartPosition, viewLine2.EndPosition);
					if (JDe.FirstPosition > textPositionRange.Value.StartPosition || JDe.LastPosition < textPositionRange.Value.EndPosition)
					{
						textPositionRange = null;
					}
				}
				if (flag4 && base.SyntaxEditor.AreMultipleSelectionRangesEnabled)
				{
					flag9 = ((!viewLine.IsLastLine) ? JDe.ToggleRange(new TextPositionRange(viewLine.StartPosition, viewLine.NextLine.StartPosition)) : JDe.ToggleRange(new TextPositionRange(viewLine.StartPosition, viewLine.EndPosition)));
				}
				else if (flag5 && textPositionRange.HasValue)
				{
					if (viewLine.StartPosition < textPositionRange.Value.StartPosition)
					{
						JDe.SelectRange(new TextPositionRange(textPositionRange.Value.EndPosition, viewLine.StartPosition), SelectionModes.ContinuousStream);
					}
					else if (viewLine.IsLastLine)
					{
						JDe.SelectRange(new TextPositionRange(textPositionRange.Value.StartPosition, viewLine.EndPosition), SelectionModes.ContinuousStream);
					}
					else
					{
						JDe.SelectRange(new TextPositionRange(textPositionRange.Value.StartPosition, viewLine.NextLine.StartPosition), SelectionModes.ContinuousStream);
					}
				}
				else if (viewLine.IsLastLine)
				{
					JDe.SelectRange(new TextPositionRange(viewLine.StartPosition, viewLine.EndPosition), SelectionModes.ContinuousStream);
				}
				else
				{
					JDe.SelectRange(new TextPositionRange(viewLine.StartPosition, viewLine.NextLine.StartPosition), SelectionModes.ContinuousStream);
				}
				if (flag9)
				{
					afc(e, (GAj)0, null);
				}
			}
			else
			{
				JDe.SelectRange(new TextPositionRange(viewLine.StartPosition, viewLine.StartPosition), SelectionModes.ContinuousStream);
			}
		}
		else if (base.SyntaxEditor.CanMoveCaretForSecondaryPointerButton && mKs(e) && !JDe.Contains(textPosition))
		{
			JDe.StartPosition = textPosition;
		}
	}

	public void RequestAutoComplete()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptAutoComplete);
	}

	public void RequestCompletionSession()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptCompletionSession);
	}

	public void RequestInsertSnippetSession()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptInsertSnippetSession);
	}

	public void RequestParameterInfoSession()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptParameterInfoSession);
	}

	public void RequestQuickInfoSession()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptQuickInfoSession);
	}

	public void RequestSurroundWithSession()
	{
		ExecuteEditAction(EditorCommands.RequestIntelliPromptSurroundWithSession);
	}

	private void XfD()
	{
		BindingOperations.ClearBinding(this, Control.BorderBrushProperty);
		BindingOperations.ClearBinding(this, Control.BorderThicknessProperty);
	}

	private void Hfg()
	{
		BindingOperations.ClearBinding(this, TextView.ZoomLevelProperty);
		AfM(null);
	}

	private void HfQ()
	{
		DAu();
		if (jDj != null)
		{
			jDj.lDS();
		}
		dDw.Clear();
	}

	private void Xfe()
	{
		TextSnapshotRange textSnapshotRange = nfl(JDe.EndSnapshotOffset);
		if (textSnapshotRange.IsDeleted || !textSnapshotRange.Contains(JDe.StartOffset) || textSnapshotRange.StartOffset == JDe.StartOffset)
		{
			nfl(JDe.StartSnapshotOffset);
		}
	}

	private TextSnapshotRange nfl(TextSnapshotOffset P_0)
	{
		TextSnapshotRange collapsedRange = KDl.GetCollapsedRange(P_0);
		if (!collapsedRange.IsDeleted && collapsedRange.StartOffset != P_0.Offset)
		{
			base.SyntaxEditor.Document.OutliningManager.EnsureExpanded(P_0);
			return collapsedRange;
		}
		return TextSnapshotRange.Deleted;
	}

	[SpecialName]
	private xA Yfp()
	{
		return jDj;
	}

	[SpecialName]
	private void AfM(xA value)
	{
		jDj = value;
		base.Content = jDj;
	}

	internal double YfA(TextPosition P_0)
	{
		TextBounds characterBounds = GetCharacterBounds(P_0);
		return characterBounds.IsLeftToRight ? characterBounds.Left : characterBounds.Right;
	}

	private void ufv()
	{
		FDo = bAs.a8c(this);
		vAC.c8l(this);
		PAB.A8u(this);
		NAO.g8j(this);
		AAH.o8I(this);
		oAt.w8S(this);
	}

	private void xfm()
	{
		SetBinding(Control.BorderBrushProperty, vAE.A0X(base.SyntaxEditor, Q7Z.tqM(7958), BindingMode.OneWay, null));
		SetBinding(Control.BorderThicknessProperty, vAE.A0X(base.SyntaxEditor, Q7Z.tqM(7984), BindingMode.OneWay, null));
	}

	private void DfC()
	{
		nR nR = DAb();
		nR.sld(AdornmentLayerDefinitions.TextBackground.Key, new Lazy<MTG>(() => new YA7()));
		nR.sld(AdornmentLayerDefinitions.Selection.Key, new Lazy<MTG>(() => new PAQ()));
		nR.sld(AdornmentLayerDefinitions.TextForeground.Key, new Lazy<MTG>(() => new VAr()));
		iD6 = new o7(this);
		AfM(new xA(this));
		BindingOperations.SetBinding(this, TextView.ZoomLevelProperty, vAE.A0X(base.SyntaxEditor, Q7Z.tqM(1876), BindingMode.OneWay, null));
	}

	internal void Gfu()
	{
		HfQ();
		if (base.SyntaxEditor == null)
		{
			return;
		}
		List<IEditorViewMargin> list = new List<IEditorViewMargin>(8);
		foreach (IEditorViewMarginFactory viewMarginFactory in base.SyntaxEditor.ViewMarginFactories)
		{
			IEditorViewMarginCollection editorViewMarginCollection = viewMarginFactory.CreateMargins(this);
			if (editorViewMarginCollection == null)
			{
				continue;
			}
			foreach (IEditorViewMargin item in editorViewMarginCollection)
			{
				list.Add(item);
			}
		}
		IEditorViewMargin[] array = OrderableHelper.Sort(list);
		IEditorViewMargin[] array2 = array;
		foreach (IEditorViewMargin editorViewMargin in array2)
		{
			switch (editorViewMargin.Placement)
			{
			case EditorViewMarginPlacement.ScrollableLeft:
			case EditorViewMarginPlacement.ScrollableRight:
			case EditorViewMarginPlacement.FixedLeft:
			case EditorViewMarginPlacement.FixedRight:
				dDw.Add(editorViewMargin);
				break;
			}
		}
		IEditorViewMargin[] array3 = array;
		foreach (IEditorViewMargin editorViewMargin2 in array3)
		{
			switch (editorViewMargin2.Placement)
			{
			case EditorViewMarginPlacement.ScrollableTop:
			case EditorViewMarginPlacement.ScrollableBottom:
			case EditorViewMarginPlacement.FixedTop:
			case EditorViewMarginPlacement.FixedBottom:
				dDw.Add(editorViewMargin2);
				break;
			}
		}
		if (jDj != null)
		{
			jDj.XDk();
		}
		if (iD6 != null)
		{
			iD6.Cg9();
		}
	}

	internal void Gf1(vTP P_0, TextSnapshotRange? P_1 = null)
	{
		switch (P_0)
		{
		case (vTP)32:
			if (FDo != null)
			{
				FDo.N8x();
			}
			return;
		case (vTP)16:
			if (FDo != null)
			{
				FDo.o8G();
			}
			return;
		case (vTP)4:
			aAY()?.InvalidateRender();
			return;
		}
		if ((P_0 & (vTP)8) == (vTP)8)
		{
			FDo.u8a();
		}
		bool flag = (P_0 & (vTP)1) != (vTP)1;
		if (flag)
		{
			PAl();
		}
		oAY oAY = WAL();
		if (oAY != null)
		{
			if (flag)
			{
				oAY.ITo();
			}
			else if (P_1.HasValue)
			{
				oAY.pT6(P_1.Value);
			}
			else
			{
				oAY.LTj();
			}
		}
		bool flag2 = (P_0 & (vTP)2) == (vTP)2;
		foreach (IEditorViewMargin item in dDw)
		{
			if (flag2 && item is EditorViewMarginBase editorViewMarginBase)
			{
				editorViewMarginBase.UpdateVisibility();
			}
			item.VisualElement.InvalidateMeasure();
		}
		if (jDj != null)
		{
			jDj.qD9();
		}
		bool flag3 = gft();
		if (flag3 || flag3 != HDf.RB1((gAJ)1024))
		{
			HDf.KBF((gAJ)1024, flag3);
			DAb().InvalidateMeasure();
		}
		if (iD6 != null)
		{
			iD6.XgS();
		}
	}

	[SpecialName]
	internal bool BfU()
	{
		return jDj != null && jDj.CDh();
	}

	[SpecialName]
	internal bool gft()
	{
		if (base.SyntaxEditor != null)
		{
			return base.SyntaxEditor.IsViewLineMeasureEnabled || !base.SyntaxEditor.IsMultiLine;
		}
		return false;
	}

	internal TextPosition BfF(Point P_0, LocationToPositionAlgorithm P_1, bool P_2)
	{
		if (P_1 == LocationToPositionAlgorithm.Absolute)
		{
			Size textAreaSize = TextAreaSize;
			Rect rect = new Rect(base.ScrollState.HorizontalAmount, 0.0, textAreaSize.Width, textAreaSize.Height);
			if (!rect.Contains(P_0))
			{
				int num = 0;
				if (!RBx())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => TextPosition.Empty, 
				};
			}
		}
		return GetViewLine(P_0.Y, P_1)?.LocationToPosition(P_0.X, P_1, P_2) ?? TextPosition.Empty;
	}

	internal Size Xf3(Size P_0)
	{
		Size result = new Size(0.0, 0.0);
		if (double.IsPositiveInfinity(P_0.Width))
		{
			P_0.Width = 3578000.0;
		}
		if (double.IsPositiveInfinity(P_0.Height))
		{
			P_0.Height = 3578000.0;
		}
		oAY oAY = new oAY(this, base.CurrentSnapshot, P_0);
		ITextViewLine textViewLine = oAY.PT4(0, _0020: false);
		while (textViewLine != null)
		{
			Size size = textViewLine.Size;
			result.Width = Math.Max(result.Width, size.Width);
			result.Height += size.Height;
			if (textViewLine.IsLastLine)
			{
				break;
			}
			int endOffsetIncludingLineTerminator = textViewLine.EndOffsetIncludingLineTerminator;
			bool flag = !textViewLine.HasHardLineBreak;
			textViewLine = oAY.PT4(endOffsetIncludingLineTerminator, flag);
		}
		result.Width += 1.0;
		if (!double.IsPositiveInfinity(P_0.Width))
		{
			result.Width = Math.Min(result.Width, P_0.Width);
		}
		if (!double.IsPositiveInfinity(P_0.Height))
		{
			result.Height = Math.Min(result.Height, P_0.Height);
		}
		return result;
	}

	internal void AfR()
	{
		if (jDj != null)
		{
			jDj.InvalidateArrange();
		}
	}

	[SpecialName]
	internal o7 ofh()
	{
		return iD6;
	}

	[SpecialName]
	private void MfN(o7 value)
	{
		iD6 = value;
	}

	[SpecialName]
	internal PTg lfz()
	{
		return CDH;
	}

	private void dfY()
	{
		if (jDj != null)
		{
			jDj.GDN(CanSplitHorizontally);
		}
	}

	[SpecialName]
	internal double QDP()
	{
		return (jDj != null) ? jDj.kgx() : 0.0;
	}

	public override IAdornmentLayer GetAdornmentLayer(AdornmentLayerDefinition layerDefinition)
	{
		_003C_003Ec__DisplayClass191_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass191_0();
		CS_0024_003C_003E8__locals6.UVP = this;
		CS_0024_003C_003E8__locals6.HVE = layerDefinition;
		if (CS_0024_003C_003E8__locals6.HVE == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8018));
		}
		if (iD6 != null)
		{
			MTG mTG = DAb().sld(CS_0024_003C_003E8__locals6.HVE.Key, new Lazy<MTG>(() => new DAN(CS_0024_003C_003E8__locals6.UVP, CS_0024_003C_003E8__locals6.HVE)));
			return mTG as IAdornmentLayer;
		}
		return null;
	}

	public TextBounds GetCharacterBounds(int offset)
	{
		return GetCharacterBounds(offset, hasFarAffinity: false);
	}

	public TextBounds GetCharacterBounds(int offset, bool hasFarAffinity)
	{
		ITextViewLine viewLine = GetViewLine(offset, hasFarAffinity);
		return viewLine.GetCharacterBounds(offset);
	}

	public TextBounds GetCharacterBounds(TextPosition position)
	{
		ITextViewLine viewLine = GetViewLine(position);
		return viewLine.GetCharacterBounds(position);
	}

	public int GetCharacterColumn(int offset)
	{
		return GetCharacterColumn(offset, hasFarAffinity: false);
	}

	public int GetCharacterColumn(int offset, bool hasFarAffinity)
	{
		ITextViewLine viewLine = GetViewLine(offset, hasFarAffinity);
		return viewLine.GetCharacterColumn(offset);
	}

	public int GetCharacterColumn(TextPosition position)
	{
		ITextViewLine viewLine = GetViewLine(position);
		return viewLine.GetCharacterColumn(position);
	}

	public IList<Range> GetCharacterIndexRanges(TextPositionRange positionRange)
	{
		return GetCharacterIndexRanges(positionRange, 1);
	}

	public IList<Range> GetCharacterIndexRanges(TextPositionRange positionRange, int minimumLines)
	{
		Range range = YAT.I66(this, positionRange);
		TextPosition lastPosition = positionRange.LastPosition;
		ITextViewLine viewLine = GetViewLine(positionRange.FirstPosition);
		List<Range> list = new List<Range>();
		while (viewLine.StartPosition <= lastPosition || minimumLines > 0)
		{
			TextPosition textPosition = viewLine.LocationToPosition(range.Min, LocationToPositionAlgorithm.BestFit, forceVirtualSpace: true);
			TextPosition textPosition2 = ((range.Length == 0) ? textPosition : viewLine.LocationToPosition(range.Max, LocationToPositionAlgorithm.BestFit, forceVirtualSpace: true));
			int num = viewLine.PositionToCharacterIndex(textPosition);
			int max = ((textPosition == textPosition2) ? num : viewLine.PositionToCharacterIndex(textPosition2));
			list.Add(new Range(num, max));
			minimumLines--;
			viewLine = GetViewLine(viewLine, 1, forceVirtualSpace: true);
		}
		return list.ToArray();
	}

	public ITextViewLine GetViewLine(double verticalLocation, LocationToPositionAlgorithm algorithm)
	{
		ITextViewLineCollection visibleViewLines = base.VisibleViewLines;
		foreach (ITextViewLine item in visibleViewLines)
		{
			Rect bounds = item.Bounds;
			if (verticalLocation >= bounds.Top)
			{
				if (verticalLocation < bounds.Bottom)
				{
					return item;
				}
				continue;
			}
			break;
		}
		if (algorithm != LocationToPositionAlgorithm.Absolute && visibleViewLines.Count > 0)
		{
			double top = visibleViewLines[0].Bounds.Top;
			double bottom = visibleViewLines[visibleViewLines.Count - 1].Bounds.Bottom;
			if (verticalLocation < top)
			{
				double num = top - verticalLocation;
				ITextViewLine textViewLine = visibleViewLines[0];
				while (!textViewLine.IsFirstLine)
				{
					textViewLine = textViewLine.PreviousLine;
					num -= textViewLine.Bounds.Height;
					if (num <= 0.0)
					{
						break;
					}
				}
				return textViewLine;
			}
			if (verticalLocation >= bottom)
			{
				double num2 = verticalLocation - bottom;
				ITextViewLine textViewLine2 = visibleViewLines[visibleViewLines.Count - 1];
				while (!textViewLine2.IsLastLine)
				{
					textViewLine2 = textViewLine2.NextLine;
					if (textViewLine2.IsVirtualLine)
					{
						break;
					}
					num2 -= textViewLine2.Bounds.Height;
					if (num2 <= 0.0)
					{
						break;
					}
				}
				return textViewLine2;
			}
		}
		return null;
	}

	public bool IsVirtualCharacter(TextPosition position, bool lineTerminatorsAreVirtual)
	{
		if (IsVirtualLine(position.Line))
		{
			return true;
		}
		ITextViewLine viewLine = GetViewLine(position);
		return viewLine.IsVirtualCharacter(viewLine.PositionToCharacterIndex(position), lineTerminatorsAreVirtual);
	}

	public bool IsVirtualLine(int positionLineIndex)
	{
		return positionLineIndex >= base.CurrentSnapshot.Lines.Count;
	}

	public bool IsVirtualLine(TextPosition position)
	{
		return IsVirtualLine(position.Line);
	}

	public TextPosition LocationToPosition(Point location, LocationToPositionAlgorithm algorithm)
	{
		return BfF(location, algorithm, _0020: false);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Gf1((vTP)0);
	}

	protected virtual void OnCanSplitHorizontallyPropertyChanged(bool oldValue, bool newValue)
	{
		dfY();
	}

	protected override void OnScrollStatePropertyChanged(TextViewScrollState oldValue, TextViewScrollState newValue)
	{
		if (CDH != null)
		{
			CDH.ScrollTo(newValue);
		}
		base.OnScrollStatePropertyChanged(oldValue, newValue);
		if (!hA6() && iD6 != null)
		{
			iD6.XgS();
		}
	}

	public override Point TransformFromTextArea(Point location)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		double zoomLevel = base.ZoomLevel;
		Point result = new Point((location.X - base.ScrollState.HorizontalAmount) * zoomLevel + textAreaViewportBounds.X, location.Y * zoomLevel + textAreaViewportBounds.Y);
		return result;
	}

	public override Rect TransformFromTextArea(Rect bounds)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		double zoomLevel = base.ZoomLevel;
		Rect result = new Rect((bounds.X - base.ScrollState.HorizontalAmount) * zoomLevel + textAreaViewportBounds.X, bounds.Y * zoomLevel + textAreaViewportBounds.Y, bounds.Width * zoomLevel, bounds.Height * zoomLevel);
		return result;
	}

	public override Point TransformToTextArea(Point location)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		double zoomLevel = base.ZoomLevel;
		Point result = new Point((location.X - textAreaViewportBounds.X) / zoomLevel + base.ScrollState.HorizontalAmount, (location.Y - textAreaViewportBounds.Y) / zoomLevel);
		return result;
	}

	public override Rect TransformToTextArea(Rect bounds)
	{
		Rect textAreaViewportBounds = TextAreaViewportBounds;
		double zoomLevel = base.ZoomLevel;
		Rect result = new Rect((bounds.X - textAreaViewportBounds.X) / zoomLevel + base.ScrollState.HorizontalAmount, (bounds.Y - textAreaViewportBounds.Y) / zoomLevel, bounds.Width / zoomLevel, bounds.Height / zoomLevel);
		return result;
	}

	private static void Qf4(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		EditorView editorView = (EditorView)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		editorView.OnCanSplitHorizontallyPropertyChanged(oldValue, newValue);
	}

	protected override void OnZoomLevelPropertyChanged(double oldValue, double newValue)
	{
		base.OnZoomLevelPropertyChanged(oldValue, newValue);
		if (iD6 != null)
		{
			iD6.RenderTransform = new ScaleTransform
			{
				ScaleX = newValue,
				ScaleY = newValue
			};
			iD6.InvalidateMeasure();
		}
		bool flag = base.SyntaxEditor.IsWordWrapEnabled;
		bool flag2 = !flag && SyntaxEditor.gGX(oldValue, newValue);
		int num = 0;
		if (!RBx())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag2)
		{
			flag = true;
		}
		Gf1((!flag) ? ((vTP)1) : ((vTP)0));
	}

	internal TextSnapshotRange Xfo(EditorSearchScope P_0)
	{
		if (P_0 == EditorSearchScope.Selection)
		{
			if (!HDT.IsDeleted && HDT.Snapshot.Document == base.CurrentSnapshot.Document)
			{
				return HDT.TranslateTo(base.CurrentSnapshot, TextRangeTrackingModes.ExpandBothEdges);
			}
			if (!JDe.IsZeroLength)
			{
				return new TextSnapshotRange(base.CurrentSnapshot, JDe.TextRange);
			}
		}
		return new TextSnapshotRange(base.CurrentSnapshot, base.CurrentSnapshot.TextRange);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal ISearchResultSet hfj(SearchOperationType P_0, IEditorSearchOptions P_1, bool P_2)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8052));
		}
		bool isZeroLength = JDe.IsZeroLength;
		TextSnapshotRange textSnapshotRange = Xfo(P_1.Scope);
		if (FDL.IsDeleted)
		{
			Mf6(P_1, _0020: false);
		}
		ISearchResultSet searchResultSet = null;
		if (P_0 == SearchOperationType.ReplaceNext && !JDe.IsZeroLength)
		{
			TextSnapshotRange textSnapshotRange2 = new TextSnapshotRange(textSnapshotRange.Snapshot, JDe.TextRange.NormalizedTextRange).TranslateTo(textSnapshotRange.Snapshot.Document.CurrentSnapshot, TextRangeTrackingModes.Default);
			searchResultSet = textSnapshotRange2.Snapshot.FindNext(P_1, JDe.FirstOffset + (P_1.SearchUp ? 1 : 0), canWrap: false, JDe.TextRange.NormalizedTextRange);
			if (searchResultSet.Results.Count > 0)
			{
				ISearchResult searchResult = searchResultSet.Results[0];
				if (searchResult.TextRange == JDe.TextRange.NormalizedTextRange)
				{
					using (JDe.CreateBatch(EditorViewSelectionBatchOptions.NoResetSearchStartOffset))
					{
						searchResultSet = TextSearcher.ReplaceNext(textSnapshotRange2.Snapshot.Document, this, P_1, JDe.FirstOffset + (P_1.SearchUp ? 1 : 0), canWrap: false, JDe.TextRange.NormalizedTextRange);
						textSnapshotRange = textSnapshotRange.TranslateTo(textSnapshotRange.Snapshot.Document.CurrentSnapshot, TextRangeTrackingModes.Default);
						if (searchResultSet.Results.Count > 0)
						{
							ISearchResult searchResult2 = searchResultSet.Results[0];
							if (!searchResult2.ReplaceSnapshotRange.IsDeleted)
							{
								JDe.SelectRange(searchResultSet.Results[0].ReplaceSnapshotRange.TextRange);
							}
						}
					}
				}
			}
		}
		ISearchResultSet searchResultSet2;
		if (P_1.SearchUp)
		{
			if (JDe.FirstOffset <= textSnapshotRange.StartOffset)
			{
				searchResultSet2 = textSnapshotRange.Snapshot.FindNext(P_1, textSnapshotRange.EndOffset, canWrap: false, textSnapshotRange.TextRange);
				searchResultSet2.Wrapped = true;
			}
			else
			{
				searchResultSet2 = textSnapshotRange.Snapshot.FindNext(P_1, Math.Min(P_2 ? JDe.LastOffset : JDe.FirstOffset, textSnapshotRange.EndOffset), canWrap: true, textSnapshotRange.TextRange);
			}
		}
		else if (JDe.LastOffset >= textSnapshotRange.EndOffset)
		{
			searchResultSet2 = textSnapshotRange.Snapshot.FindNext(P_1, textSnapshotRange.StartOffset, canWrap: false, textSnapshotRange.TextRange);
			searchResultSet2.Wrapped = true;
		}
		else
		{
			searchResultSet2 = textSnapshotRange.Snapshot.FindNext(P_1, Math.Max(P_2 ? JDe.FirstOffset : JDe.LastOffset, textSnapshotRange.StartOffset), canWrap: true, textSnapshotRange.TextRange);
		}
		if (searchResultSet2.Results.Count > 0)
		{
			ISearchResult searchResult3 = searchResultSet2.Results[0];
			TextSnapshotRange textSnapshotRange3 = searchResult3.FindSnapshotRange.TranslateTo(base.CurrentSnapshot, TextRangeTrackingModes.Default);
			if (KDl != null)
			{
				TextSnapshotOffset snapshotOffset = new TextSnapshotOffset(textSnapshotRange3.Snapshot, textSnapshotRange3.StartOffset);
				TextSnapshotRange collapsedRange = KDl.GetCollapsedRange(snapshotOffset);
				if (!collapsedRange.IsDeleted && !collapsedRange.Contains(textSnapshotRange3.EndOffset) && base.SyntaxEditor != null && base.SyntaxEditor.Document != null && base.SyntaxEditor.Document.OutliningManager != null)
				{
					base.SyntaxEditor.Document.OutliningManager.EnsureExpanded(snapshotOffset);
				}
			}
			lfz().ScrollIntoView(textSnapshotRange3.EndPosition, _0020: true);
			using (JDe.CreateBatch(EditorViewSelectionBatchOptions.NoScrollToCaret | EditorViewSelectionBatchOptions.NoResetSearchStartOffset))
			{
				JDe.SelectRange(textSnapshotRange3);
			}
		}
		if (searchResultSet != null && searchResultSet.Results.Count == 1)
		{
			searchResultSet2.Results.Insert(0, searchResultSet.Results[0]);
		}
		searchResultSet2.OperationType = P_0;
		if (searchResultSet2.Results.Count == 0 && !isZeroLength && !HDT.IsDeleted)
		{
			JDe.SelectRange(HDT.TranslateTo(base.CurrentSnapshot, TextRangeTrackingModes.Default));
		}
		return searchResultSet2;
	}

	private void Hfw()
	{
		FDL = TextSnapshotOffset.Deleted;
	}

	private void Mf6(IEditorSearchOptions P_0, bool P_1)
	{
		if (P_1)
		{
			HDT = TextSnapshotRange.Deleted;
		}
		EditorSearchScope editorSearchScope = P_0?.Scope ?? EditorSearchScope.Document;
		TextSnapshotRange hDT = Xfo(editorSearchScope);
		FDL = new TextSnapshotOffset(hDT.Snapshot, JDe.FirstOffset);
		if (P_1)
		{
			if (editorSearchScope == EditorSearchScope.Selection)
			{
				HDT = hDT;
			}
			DK5();
		}
	}

	public ISearchResultSet FindAll(IEditorSearchOptions options)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = options == null;
				num2 = 0;
				if (RBx())
				{
					num2 = 0;
				}
				continue;
			}
			if (flag)
			{
				throw new ArgumentNullException(Q7Z.tqM(8052));
			}
			TextSnapshotRange textSnapshotRange = Xfo(options.Scope);
			Hfw();
			ISearchResultSet searchResultSet = TextSearcher.FindAll(textSnapshotRange.Snapshot, options, textSnapshotRange.TextRange);
			EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(this, searchResultSet);
			base.SyntaxEditor.qxL(e);
			return searchResultSet;
		}
	}

	public ISearchResultSet FindCurrentOrNext(IEditorSearchOptions options)
	{
		ISearchResultSet searchResultSet = hfj(SearchOperationType.FindNext, options, _0020: true);
		EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(this, searchResultSet);
		base.SyntaxEditor.qxL(e);
		return searchResultSet;
	}

	public ISearchResultSet FindNext(IEditorSearchOptions options)
	{
		ISearchResultSet searchResultSet = hfj(SearchOperationType.FindNext, options, _0020: false);
		EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(this, searchResultSet);
		base.SyntaxEditor.qxL(e);
		return searchResultSet;
	}

	public ISearchResultSet FindNextIncremental(bool searchUp)
	{
		Activate();
		if (!vAE.E0C(this))
		{
			Focus();
		}
		return base.SyntaxEditor.eGu().qjN(searchUp);
	}

	public ISearchResultSet ReplaceNext(IEditorSearchOptions options)
	{
		ISearchResultSet searchResultSet = hfj(SearchOperationType.ReplaceNext, options, _0020: false);
		EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(this, searchResultSet);
		base.SyntaxEditor.qxL(e);
		return searchResultSet;
	}

	public ISearchResultSet ReplaceAll(IEditorSearchOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8052));
		}
		IEditorViewSelectionState editorViewSelectionState = JDe.CaptureState();
		TextSnapshotRange textSnapshotRange = Xfo(options.Scope);
		IList<TextRange> source = ((JDe.IsZeroLength || options.Scope != EditorSearchScope.Selection || JDe.Mode != SelectionModes.Block) ? new TextRange[1] { textSnapshotRange.TextRange } : JDe.GetTextRanges());
		Hfw();
		ISearchResultSet searchResultSet = TextSearcher.ReplaceAll(textSnapshotRange.Snapshot.Document, this, options, source.ToArray());
		editorViewSelectionState?.Restore();
		EditorViewSearchEventArgs e = new EditorViewSearchEventArgs(this, searchResultSet);
		base.SyntaxEditor.qxL(e);
		return searchResultSet;
	}

	public void SetSearchStartOffset(IEditorSearchOptions options)
	{
		Mf6(options, _0020: true);
	}

	private void ifH()
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				QDI = null;
				if (bDr != null)
				{
					bDr.Detach();
					bDr = null;
				}
				RD5 = null;
				return;
			default:
				if (flag)
				{
					YD0.Detach();
					YD0 = null;
				}
				ADn = null;
				if (wDB != null)
				{
					wDB.Detach();
					wDB = null;
				}
				BD8 = null;
				if (BDV != null)
				{
					BDV.Detach();
					BDV = null;
					num2 = 2;
					if (CBa() == null)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 1:
				flag = YD0 != null;
				num2 = 0;
				if (!RBx())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Kfb()
	{
		ADn = CreateTagAggregator<IClassificationTag>();
		YD0 = new WeakEventListener<EditorView, TagsChangedEventArgs>(this, delegate(EditorView instance, object source, TagsChangedEventArgs eventArgs)
		{
			instance.lfL(source, eventArgs);
		}, delegate(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
		{
			ADn.TagsChanged -= P_0.OnEvent;
		});
		ADn.TagsChanged += YD0.OnEvent;
		BD8 = CreateTagAggregator<IIntraLineSpacerTag>();
		wDB = new WeakEventListener<EditorView, TagsChangedEventArgs>(this, delegate(EditorView instance, object source, TagsChangedEventArgs eventArgs)
		{
			instance.lfn(source, eventArgs);
		}, delegate(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
		{
			BD8.TagsChanged -= P_0.OnEvent;
		});
		BD8.TagsChanged += wDB.OnEvent;
		QDI = CreateTagAggregator<IIntraTextSpacerTag>();
		BDV = new WeakEventListener<EditorView, TagsChangedEventArgs>(this, delegate(EditorView instance, object source, TagsChangedEventArgs eventArgs)
		{
			instance.If8(source, eventArgs);
		}, delegate(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
		{
			QDI.TagsChanged -= P_0.OnEvent;
		});
		QDI.TagsChanged += BDV.OnEvent;
		RD5 = CreateTagAggregator<ISquiggleTag>();
		bDr = new WeakEventListener<EditorView, TagsChangedEventArgs>(this, delegate(EditorView instance, object source, TagsChangedEventArgs eventArgs)
		{
			instance.pfI(source, eventArgs);
		}, delegate(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
		{
			RD5.TagsChanged -= P_0.OnEvent;
		});
		RD5.TagsChanged += bDr.OnEvent;
	}

	private void RfT()
	{
		LDQ = base.Properties.GetOrCreateSingleton(typeof(SearchResultHighlightTagger), () => new SearchResultHighlightTagger(this));
	}

	private void lfL(object P_0, TagsChangedEventArgs P_1)
	{
		Gf1((vTP)1, P_1.SnapshotRange);
	}

	private void lfn(object P_0, TagsChangedEventArgs P_1)
	{
		Gf1((vTP)1, P_1.SnapshotRange);
	}

	private void If8(object P_0, TagsChangedEventArgs P_1)
	{
		Gf1((vTP)1, P_1.SnapshotRange);
	}

	private void pfI(object P_0, TagsChangedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass265_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass265_0();
		CS_0024_003C_003E8__locals7.vVa = this;
		CS_0024_003C_003E8__locals7.NVx = P_1;
		vAE.l0x<object>(base.SyntaxEditor, delegate
		{
			ITextSnapshot currentSnapshot = CS_0024_003C_003E8__locals7.vVa.CurrentSnapshot;
			TextSnapshotRange textSnapshotRange = CS_0024_003C_003E8__locals7.NVx.SnapshotRange;
			int num = 0;
			if (_003C_003Ec__DisplayClass265_0.YNu() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0005:
			int num2 = default(int);
			num = num2;
			goto IL_0009;
			IL_0009:
			ITextViewLine textViewLine = default(ITextViewLine);
			ITextViewLine textViewLine2 = default(ITextViewLine);
			TextRange textRange = default(TextRange);
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					TextRange range = new TextRange(textViewLine.StartOffset, textViewLine2.EndOffsetIncludingLineTerminator);
					if (textRange.OverlapsWith(range))
					{
						CS_0024_003C_003E8__locals7.vVa.Gf1((vTP)4);
					}
					return;
				}
				default:
				{
					if (textSnapshotRange.Snapshot.Document != currentSnapshot.Document)
					{
						textRange = currentSnapshot.SnapshotRange;
					}
					else
					{
						textSnapshotRange = CS_0024_003C_003E8__locals7.NVx.SnapshotRange.TranslateTo(currentSnapshot, TextRangeTrackingModes.Default);
						textRange = textSnapshotRange.TextRange;
					}
					ITextViewLineCollection visibleViewLines = CS_0024_003C_003E8__locals7.vVa.VisibleViewLines;
					textViewLine = visibleViewLines.FirstOrDefault();
					textViewLine2 = visibleViewLines.LastOrDefault();
					if (textViewLine == null || textViewLine2 == null)
					{
						return;
					}
					num = 1;
					if (_003C_003Ec__DisplayClass265_0.zNw())
					{
						break;
					}
					goto end_IL_0009;
				}
				}
				continue;
				end_IL_0009:
				break;
			}
			goto IL_0005;
		}, null);
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public override ITagAggregator<T> CreateTagAggregator<T>()
	{
		return new QAP<T>(this, _0020: true);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public ITagger<T> GetTagger<T>(ITextView view) where T : ITag
	{
		if (view == this && typeof(T) == typeof(IClassificationTag))
		{
			return (ITagger<T>)LDQ;
		}
		return null;
	}

	public void Backspace()
	{
		ExecuteEditAction(EditorCommands.Backspace);
	}

	public void BackspaceToPreviousWord()
	{
		ExecuteEditAction(EditorCommands.BackspaceToPreviousWord);
	}

	public void ChangeCharacterCasing(ActiproSoftware.Text.CharacterCasing casing)
	{
		switch (casing)
		{
		case ActiproSoftware.Text.CharacterCasing.Lower:
			ExecuteEditAction(new MakeLowercaseAction());
			return;
		case ActiproSoftware.Text.CharacterCasing.Upper:
			ExecuteEditAction(new MakeUppercaseAction());
			return;
		}
		int num = 0;
		if (!RBx())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		ExecuteEditAction(new CapitalizeAction());
	}

	public void CommentLines()
	{
		ExecuteEditAction(EditorCommands.CommentLines);
	}

	public void ConvertSpacesToTabs()
	{
		ExecuteEditAction(EditorCommands.ConvertSpacesToTabs);
	}

	public void ConvertTabsToSpaces()
	{
		ExecuteEditAction(EditorCommands.ConvertTabsToSpaces);
	}

	public void Delete()
	{
		ExecuteEditAction(EditorCommands.Delete);
	}

	public void DeleteBlankLines()
	{
		ExecuteEditAction(EditorCommands.DeleteBlankLines);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public void DeleteHorizontalWhitespace()
	{
		ExecuteEditAction(EditorCommands.DeleteHorizontalWhitespace);
	}

	public void DeleteLine()
	{
		ExecuteEditAction(EditorCommands.DeleteLine);
	}

	public void DeleteToLineEnd()
	{
		ExecuteEditAction(EditorCommands.DeleteToLineEnd);
	}

	public void DeleteToLineStart()
	{
		ExecuteEditAction(EditorCommands.DeleteToLineStart);
	}

	public void DeleteToNextWord()
	{
		ExecuteEditAction(EditorCommands.DeleteToNextWord);
	}

	public void Duplicate()
	{
		ExecuteEditAction(EditorCommands.Duplicate);
	}

	public void FormatDocument()
	{
		ExecuteEditAction(EditorCommands.FormatDocument);
	}

	public void FormatSelection()
	{
		ExecuteEditAction(EditorCommands.FormatSelection);
	}

	public void Indent()
	{
		ExecuteEditAction(EditorCommands.Indent);
	}

	public void InsertLineBreak()
	{
		ExecuteEditAction(EditorCommands.InsertLineBreak);
	}

	public void MoveSelectedLinesDown()
	{
		ExecuteEditAction(EditorCommands.MoveSelectedLinesDown);
	}

	public void MoveSelectedLinesUp()
	{
		ExecuteEditAction(EditorCommands.MoveSelectedLinesUp);
	}

	public void OpenLineAbove()
	{
		ExecuteEditAction(EditorCommands.OpenLineAbove);
	}

	public void OpenLineBelow()
	{
		ExecuteEditAction(EditorCommands.OpenLineBelow);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
	public void Outdent()
	{
		ExecuteEditAction(EditorCommands.Outdent);
	}

	public void PerformInsertTyping(string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			ExecuteEditAction(new TypingAction(text, overwrite: false));
		}
	}

	public void PerformOverwriteTyping(string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			ExecuteEditAction(new TypingAction(text, overwrite: true));
		}
	}

	public void PerformTyping(string text)
	{
		if (!string.IsNullOrEmpty(text))
		{
			ExecuteEditAction(new TypingAction(text, base.SyntaxEditor.IsOverwriteModeActive));
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tabify")]
	public void TabifySelectedLines()
	{
		ExecuteEditAction(EditorCommands.TabifySelectedLines);
	}

	public void ToggleCharacterCasing()
	{
		ExecuteEditAction(EditorCommands.ToggleCharacterCasing);
	}

	public void TransposeCharacters()
	{
		ExecuteEditAction(EditorCommands.TransposeCharacters);
	}

	public void TransposeLines()
	{
		ExecuteEditAction(EditorCommands.TransposeLines);
	}

	public void TransposeWords()
	{
		ExecuteEditAction(EditorCommands.TransposeWords);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public void TrimAllTrailingWhitespace()
	{
		ExecuteEditAction(EditorCommands.TrimAllTrailingWhitespace);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public void TrimTrailingWhitespace()
	{
		ExecuteEditAction(EditorCommands.TrimTrailingWhitespace);
	}

	public void UncommentLines()
	{
		ExecuteEditAction(EditorCommands.UncommentLines);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untabify")]
	public void UntabifySelectedLines()
	{
		ExecuteEditAction(EditorCommands.UntabifySelectedLines);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public TextPosition GetPositionForCharacterDelta(TextPosition position, int characterDelta, bool wrapAtLineTerminators, bool forceVirtualSpace)
	{
		if (characterDelta == 0)
		{
			return position;
		}
		ITextViewLine viewLine = GetViewLine(position);
		if (forceVirtualSpace || base.SyntaxEditor.IsVirtualSpaceAtLineEndEnabled)
		{
			TextPosition endPosition = viewLine.EndPosition;
			if (characterDelta < 0)
			{
				int num = Math.Max(0, position.Character - endPosition.Character);
				if (num > 0)
				{
					int num2 = Math.Min(-characterDelta, num);
					characterDelta += num2;
					position = new TextPosition(position.Line, position.Character - num2);
				}
				if (characterDelta < 0)
				{
					int num3 = viewLine.PositionToCharacterIndex(position);
					while (characterDelta < 0 && num3 > 0)
					{
						TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag = viewLine.GetIntraTextSpacerTag(--num3);
						if (intraTextSpacerTag == null || (!intraTextSpacerTag.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag.SnapshotRange.Snapshot, intraTextSpacerTag.SnapshotRange.StartOffset)) == intraTextSpacerTag.SnapshotRange))
						{
							characterDelta++;
						}
					}
					position = viewLine.CharacterIndexToPosition(num3);
				}
			}
			else
			{
				if (position < endPosition)
				{
					int i = viewLine.PositionToCharacterIndex(position);
					int characterCount = viewLine.CharacterCount;
					while (characterDelta > 0 && i < characterCount)
					{
						TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag2 = viewLine.GetIntraTextSpacerTag(i++);
						if (intraTextSpacerTag2 == null || (!intraTextSpacerTag2.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag2.SnapshotRange.Snapshot, intraTextSpacerTag2.SnapshotRange.StartOffset)) == intraTextSpacerTag2.SnapshotRange))
						{
							characterDelta--;
						}
					}
					for (; i < characterCount; i++)
					{
						TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag3 = viewLine.GetIntraTextSpacerTag(i);
						if (intraTextSpacerTag3 == null || (!intraTextSpacerTag3.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag3.SnapshotRange.Snapshot, intraTextSpacerTag3.SnapshotRange.StartOffset)) == intraTextSpacerTag3.SnapshotRange))
						{
							break;
						}
					}
					position = viewLine.CharacterIndexToPosition(i);
				}
				if (characterDelta > 0 && position.Character - endPosition.Character >= 0)
				{
					position = new TextPosition(position.Line, position.Character + characterDelta);
				}
			}
			return position;
		}
		if (characterDelta < 0)
		{
			while (characterDelta < 0)
			{
				int num4 = viewLine.PositionToCharacterIndex(position);
				while (characterDelta < 0 && num4 > 0)
				{
					TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag4 = viewLine.GetIntraTextSpacerTag(--num4);
					if ((intraTextSpacerTag4 == null || (!intraTextSpacerTag4.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag4.SnapshotRange.Snapshot, intraTextSpacerTag4.SnapshotRange.StartOffset)) == intraTextSpacerTag4.SnapshotRange)) && ++characterDelta == 0 && num4 > 0)
					{
						int index = viewLine.CharacterIndexToOffset(num4);
						char c = viewLine.SnapshotRange.Snapshot[index];
						if (char.IsLowSurrogate(c))
						{
							num4--;
						}
					}
				}
				position = viewLine.CharacterIndexToPosition(num4);
				if (characterDelta >= 0 || !wrapAtLineTerminators || viewLine.StartOffset == 0)
				{
					break;
				}
				viewLine = GetViewLine(viewLine.StartOffset - 1, hasFarAffinity: false);
				position = viewLine.EndPosition;
				if (viewLine.HasHardLineBreak)
				{
					characterDelta++;
				}
			}
		}
		else
		{
			while (characterDelta > 0)
			{
				int j = viewLine.PositionToCharacterIndex(position);
				int characterCount2 = viewLine.CharacterCount;
				while (characterDelta > 0 && j < characterCount2)
				{
					TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag5 = viewLine.GetIntraTextSpacerTag(j++);
					if ((intraTextSpacerTag5 == null || (!intraTextSpacerTag5.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag5.SnapshotRange.Snapshot, intraTextSpacerTag5.SnapshotRange.StartOffset)) == intraTextSpacerTag5.SnapshotRange)) && --characterDelta == 0)
					{
						int index2 = viewLine.CharacterIndexToOffset(j);
						char c2 = viewLine.SnapshotRange.Snapshot[index2];
						if (char.IsLowSurrogate(c2))
						{
							j++;
						}
					}
				}
				for (; j < characterCount2; j++)
				{
					TagSnapshotRange<IIntraTextSpacerTag> intraTextSpacerTag6 = viewLine.GetIntraTextSpacerTag(j);
					if (intraTextSpacerTag6 == null || (!intraTextSpacerTag6.SnapshotRange.IsZeroLength && KDl != null && KDl.GetCollapsedRange(new TextSnapshotOffset(intraTextSpacerTag6.SnapshotRange.Snapshot, intraTextSpacerTag6.SnapshotRange.StartOffset)) == intraTextSpacerTag6.SnapshotRange))
					{
						break;
					}
				}
				position = viewLine.CharacterIndexToPosition(j);
				if (characterDelta <= 0 || !wrapAtLineTerminators || viewLine.EndOffset == base.CurrentSnapshot.Length)
				{
					break;
				}
				viewLine = GetViewLine(viewLine.EndOffset + 1, hasFarAffinity: true);
				position = viewLine.StartPosition;
				if (viewLine.IsWrapped && viewLine.CharacterCount > 0)
				{
					position = viewLine.CharacterIndexToPosition(1);
				}
				characterDelta--;
			}
		}
		return position;
	}

	public TextPosition GetPositionForLineDelta(TextPosition position, int lineDelta, double? preferredHorizontalLocation, bool forceVirtualSpace)
	{
		if (lineDelta == 0)
		{
			return position;
		}
		if (!preferredHorizontalLocation.HasValue)
		{
			preferredHorizontalLocation = YfA(position);
		}
		ITextViewLine viewLine = GetViewLine(position);
		viewLine = GetViewLine(viewLine, lineDelta, forceVirtualSpace: false);
		position = viewLine.LocationToPosition(preferredHorizontalLocation.Value, LocationToPositionAlgorithm.BestFit, forceVirtualSpace);
		return position;
	}

	public TextPosition GetPositionForLineEnd(TextPosition position)
	{
		ITextViewLine viewLine = GetViewLine(position);
		return viewLine.EndPosition;
	}

	public TextPosition GetPositionForLineStart(TextPosition position)
	{
		ITextViewLine viewLine = GetViewLine(position);
		return viewLine.StartPosition;
	}

	[SpecialName]
	internal bool FDG()
	{
		return HDf.RB1((gAJ)512);
	}

	[SpecialName]
	internal void DDX(bool value)
	{
		if (jDj == null)
		{
			return;
		}
		EditorViewSelectionGripper editorViewSelectionGripper = jDj.mgc();
		EditorViewSelectionGripper editorViewSelectionGripper2 = jDj.NgP();
		editorViewSelectionGripper.vgZ(DateTime.Now);
		editorViewSelectionGripper2.vgZ(DateTime.Now);
		if (FDG() != value)
		{
			HDf.KBF((gAJ)512, value);
			if (value)
			{
				qf0();
				return;
			}
			editorViewSelectionGripper.Visibility = Visibility.Collapsed;
			editorViewSelectionGripper2.Visibility = Visibility.Collapsed;
		}
	}

	private Point vf5(TextBounds P_0, double P_1, double P_2, double P_3, Thickness P_4)
	{
		Point result = TransformFromTextArea(new Point(P_0.X, P_0.Bottom));
		double num = (0.0 - P_4.Left) / P_3 - P_1 / 2.0;
		double num2 = (0.0 - P_4.Top) / P_3 - P_2;
		result.X += num;
		result.Y += num2;
		return result;
	}

	private void qf0()
	{
		if (!FDG() || jDj == null)
		{
			return;
		}
		EditorViewSelectionGripper editorViewSelectionGripper = jDj.mgc();
		EditorViewSelectionGripper editorViewSelectionGripper2 = jDj.NgP();
		double zoomLevel = base.ZoomLevel;
		Thickness borderThickness = base.BorderThickness;
		bool flag = false;
		TextBounds characterBounds = GetCharacterBounds(JDe.EndPosition);
		if (characterBounds.IsYValid)
		{
			double width = editorViewSelectionGripper2.Width;
			Point point = vf5(characterBounds, width, editorViewSelectionGripper2.Padding.Top, zoomLevel, borderThickness);
			if (editorViewSelectionGripper2.Location != point)
			{
				editorViewSelectionGripper2.Location = point;
				flag = true;
			}
			editorViewSelectionGripper2.Visibility = Visibility.Visible;
		}
		else
		{
			editorViewSelectionGripper2.Visibility = Visibility.Collapsed;
		}
		if (JDe.Length == 0)
		{
			editorViewSelectionGripper.Visibility = Visibility.Collapsed;
		}
		else
		{
			TextBounds characterBounds2 = GetCharacterBounds(JDe.StartPosition);
			if (characterBounds2.IsYValid)
			{
				double width2 = editorViewSelectionGripper.Width;
				Point point2 = vf5(characterBounds2, width2, editorViewSelectionGripper.Padding.Top, zoomLevel, borderThickness);
				if (editorViewSelectionGripper.Location != point2)
				{
					editorViewSelectionGripper.Location = point2;
					flag = true;
				}
				editorViewSelectionGripper.Visibility = Visibility.Visible;
			}
			else
			{
				editorViewSelectionGripper.Visibility = Visibility.Collapsed;
			}
		}
		if (flag)
		{
			jDj.InvalidateArrange();
		}
	}

	internal void SfB(InputPointerButtonEventArgs P_0, bool P_1, Point P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (base.SyntaxEditor.MacroRecording.State == MacroRecordingState.Recording)
		{
			return;
		}
		nKr();
		if (base.SyntaxEditor.IsSelectionModeAllowed(SelectionModes.ContinuousStream))
		{
			if (P_1)
			{
				afc(P_0, (GAj)7, JDe.StartOffset, P_2);
			}
			else
			{
				afc(P_0, (GAj)5, JDe.EndOffset, P_2);
			}
		}
		P_0.Handled = true;
	}

	protected internal override void OnRendered()
	{
		base.OnRendered();
		qf0();
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		mKO();
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
	{
		base.OnIsKeyboardFocusWithinChanged(e);
		if (HasFocus)
		{
			if (!base.IsKeyboardFocusWithin)
			{
				gKt();
			}
			else
			{
				TfK(_0020: true);
			}
		}
		else if (base.IsKeyboardFocusWithin && vAE.E0C(this))
		{
			mKO();
		}
		else
		{
			TfK(_0020: true);
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		oKU(e);
		base.OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		HKJ(e);
		base.OnKeyUp(e);
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		gKt();
	}

	protected override void OnTextInput(TextCompositionEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		ufE(e);
	}

	static EditorView()
	{
		grA.DaB7cz();
		HasFocusChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(8070), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(EditorView));
		HighlightedResultSearchOptionsChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(8104), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(EditorView));
		SelectionChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(8182), RoutingStrategy.Direct, typeof(EventHandler<EditorViewSelectionEventArgs>), typeof(EditorView));
		LDA = new DateTime(2018, 1, 1);
		CanSplitHorizontallyProperty = DependencyProperty.Register(Q7Z.tqM(3860), typeof(bool), typeof(EditorView), new PropertyMetadata(false, Qf4));
		IsActiveProperty = DependencyProperty.Register(Q7Z.tqM(8218), typeof(bool), typeof(EditorView), new PropertyMetadata(false));
	}

	[CompilerGenerated]
	private void xfV(object P_0)
	{
		vAE.P01(this, null);
	}

	[CompilerGenerated]
	private void vfr(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
	{
		ADn.TagsChanged -= P_0.OnEvent;
	}

	[CompilerGenerated]
	private void Xfs(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
	{
		BD8.TagsChanged -= P_0.OnEvent;
	}

	[CompilerGenerated]
	private void mfk(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
	{
		QDI.TagsChanged -= P_0.OnEvent;
	}

	[CompilerGenerated]
	private void gfS(WeakEventListener<EditorView, TagsChangedEventArgs> P_0)
	{
		RD5.TagsChanged -= P_0.OnEvent;
	}

	[CompilerGenerated]
	private SearchResultHighlightTagger zf9()
	{
		return new SearchResultHighlightTagger(this);
	}

	internal static bool RBx()
	{
		return MBq == null;
	}

	internal static EditorView CBa()
	{
		return MBq;
	}
}
