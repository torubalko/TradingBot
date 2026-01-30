#define DEBUG
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class oAY
{
	private class R7s
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool aSx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private CanvasControl aSG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ITagAggregator<IClassificationTag> qSX;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string USK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float xSf;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private FontStyle VSD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FontWeight uSg;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Color FSQ;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IHighlightingStyleRegistry lSe;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ITagAggregator<IIntraLineSpacerTag> MSl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ITagAggregator<IIntraTextSpacerTag> zSA;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private HashSet<ITextViewLine> OSv;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextViewScrollState vSm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int hSC;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Thickness cSu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Size SS1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IDisposable NSF;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TextLayoutWrapping wS3;

		internal static R7s e3k;

		public IHighlightingStyleRegistry HighlightingStyleRegistry
		{
			[CompilerGenerated]
			get
			{
				return lSe;
			}
			[CompilerGenerated]
			set
			{
				lSe = highlightingStyleRegistry;
			}
		}

		public bool IsWordWrapEnabled => jSE() != TextLayoutWrapping.NoWrap;

		public TextViewScrollState ScrollState
		{
			[CompilerGenerated]
			get
			{
				return vSm;
			}
			[CompilerGenerated]
			set
			{
				vSm = textViewScrollState;
			}
		}

		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		public IDisposable TSP
		{
			[CompilerGenerated]
			get
			{
				return NSF;
			}
			[CompilerGenerated]
			set
			{
				NSF = nSF;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public bool Dkl()
		{
			return aSx;
		}

		[SpecialName]
		[CompilerGenerated]
		public void jkA(bool P_0)
		{
			aSx = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public CanvasControl Rkm()
		{
			return aSG;
		}

		[SpecialName]
		[CompilerGenerated]
		public void CkC(CanvasControl P_0)
		{
			aSG = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITagAggregator<IClassificationTag> Pk1()
		{
			return qSX;
		}

		[SpecialName]
		[CompilerGenerated]
		public void jkF(ITagAggregator<IClassificationTag> P_0)
		{
			qSX = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string mkR()
		{
			return USK;
		}

		[SpecialName]
		[CompilerGenerated]
		public void FkY(string P_0)
		{
			USK = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public float Pko()
		{
			return xSf;
		}

		[SpecialName]
		[CompilerGenerated]
		public void jkj(float P_0)
		{
			xSf = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public FontStyle ok6()
		{
			return VSD;
		}

		[SpecialName]
		[CompilerGenerated]
		public void nkH(FontStyle P_0)
		{
			VSD = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public FontWeight KkT()
		{
			return uSg;
		}

		[SpecialName]
		[CompilerGenerated]
		public void akL(FontWeight P_0)
		{
			uSg = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public Color Bk8()
		{
			return FSQ;
		}

		[SpecialName]
		[CompilerGenerated]
		public void YkI(Color P_0)
		{
			FSQ = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITagAggregator<IIntraLineSpacerTag> tkV()
		{
			return MSl;
		}

		[SpecialName]
		[CompilerGenerated]
		public void ukr(ITagAggregator<IIntraLineSpacerTag> P_0)
		{
			MSl = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITagAggregator<IIntraTextSpacerTag> ykk()
		{
			return zSA;
		}

		[SpecialName]
		[CompilerGenerated]
		public void vkS(ITagAggregator<IIntraTextSpacerTag> P_0)
		{
			zSA = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public HashSet<ITextViewLine> Akq()
		{
			return OSv;
		}

		[SpecialName]
		[CompilerGenerated]
		public void ak2(HashSet<ITextViewLine> P_0)
		{
			OSv = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int XkM()
		{
			return hSC;
		}

		[SpecialName]
		[CompilerGenerated]
		public void lkO(int P_0)
		{
			hSC = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public Thickness kkJ()
		{
			return cSu;
		}

		[SpecialName]
		[CompilerGenerated]
		public void Hkt(Thickness P_0)
		{
			cSu = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public Size kkh()
		{
			return SS1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void KkN(Size P_0)
		{
			SS1 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public TextLayoutWrapping jSE()
		{
			return wS3;
		}

		[SpecialName]
		[CompilerGenerated]
		public void LSc(TextLayoutWrapping P_0)
		{
			wS3 = P_0;
		}

		public R7s()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool E3Z()
		{
			return e3k == null;
		}

		internal static R7s k3F()
		{
			return e3k;
		}
	}

	private ITextSnapshot JTI;

	private Size? xT5;

	private bool AT0;

	private bool wTB;

	private bool uTV;

	private bool gTr;

	private TextView lTs;

	private fAF VTk;

	private AAo zTS;

	private static oAY HWH;

	public oAY(TextView P_0, ITextSnapshot P_1, Size? P_2 = null)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194256));
		}
		lTs = P_0;
		JTI = P_1;
		xT5 = P_2;
		VTk = new fAF();
		zTS = new AAo();
	}

	private void STX(R7s P_0, QAR P_1)
	{
		IHighlightingStyleRegistry highlightingStyleRegistry = P_0.HighlightingStyleRegistry;
		if (highlightingStyleRegistry == null)
		{
			return;
		}
		ITagAggregator<IClassificationTag> tagAggregator = P_0.Pk1();
		if (tagAggregator == null)
		{
			return;
		}
		ITextProvider textProvider = P_1.TextProvider;
		foreach (TextRange item in P_1.j6d())
		{
			TextSnapshotRange textSnapshotRange = new TextSnapshotRange(JTI, item);
			IEnumerable<TagSnapshotRange<IClassificationTag>> tags = tagAggregator.GetTags(new NormalizedTextSnapshotRangeCollection(textSnapshotRange), textSnapshotRange);
			foreach (TagSnapshotRange<IClassificationTag> item2 in tags)
			{
				IClassificationTag tag = item2.Tag;
				if (tag == null)
				{
					continue;
				}
				IClassificationType classificationType = tag.ClassificationType;
				if (classificationType == null)
				{
					continue;
				}
				TextRange textRange = TextRange.Intersect(item, item2.SnapshotRange);
				if (textRange.IsZeroLength)
				{
					continue;
				}
				IHighlightingStyle highlightingStyle = highlightingStyleRegistry.oLD(tag, classificationType);
				if (highlightingStyle == null || highlightingStyle.HasDefaultFormatting)
				{
					continue;
				}
				int num = textProvider.Translate(textRange.StartOffset, TextProviderTranslateModes.FromSourceText);
				int num2 = textProvider.Translate(textRange.EndOffset, TextProviderTranslateModes.FromSourceText);
				int num3 = num2 - num;
				if (highlightingStyle.Foreground.HasValue)
				{
					P_1.SetForeground(num, num3, highlightingStyle.Foreground.Value);
				}
				bool? bold = highlightingStyle.Bold;
				if (bold.HasValue)
				{
					P_1.SetFontWeight(num, num3, true.Equals(bold) ? FontWeights.Bold : FontWeights.Normal);
				}
				bool? italic = highlightingStyle.Italic;
				if (italic.HasValue)
				{
					P_1.SetFontStyle(num, num3, true.Equals(italic) ? FontStyles.Italic : FontStyles.Normal);
				}
				if (highlightingStyle.HasFontChange)
				{
					if (!string.IsNullOrEmpty(highlightingStyle.FontFamilyName))
					{
						P_1.SetFontFamily(num, num3, highlightingStyle.FontFamilyName);
					}
					if (highlightingStyle.FontSize > 0f)
					{
						P_1.SetFontSize(num, num3, highlightingStyle.FontSize);
					}
				}
				if (highlightingStyle.HasBackground || highlightingStyle.HasBorder)
				{
					P_1.e6M(item2.SnapshotRange, highlightingStyle);
				}
				if (highlightingStyle.HasUnderline)
				{
					P_1.SetUnderline(num, num3, highlightingStyle.UnderlineKind, highlightingStyle.UnderlineColor, highlightingStyle.UnderlineWeight);
				}
				if (highlightingStyle.HasStrikethrough)
				{
					P_1.SetStrikethrough(num, num3, highlightingStyle.StrikethroughKind, highlightingStyle.StrikethroughColor, highlightingStyle.StrikethroughWeight);
				}
			}
		}
	}

	private void ATK(R7s P_0)
	{
		HashSet<ITextViewLine> hashSet = P_0.Akq();
		int num2 = default(int);
		foreach (DAp visibleViewLine in lTs.VisibleViewLines)
		{
			bool flag = hashSet.Remove(visibleViewLine);
			if (flag)
			{
				visibleViewLine.Change = ((visibleViewLine.TranslationY != 0.0) ? TextViewLineChange.Translated : TextViewLineChange.None);
			}
			Rect bounds = visibleViewLine.Bounds;
			visibleViewLine.Visibility = ((!(bounds.Y < 0.0) && !(bounds.Bottom > P_0.kkh().Height)) ? TextViewLineVisibility.FullyVisible : TextViewLineVisibility.PartiallyVisible);
			if (!flag)
			{
				visibleViewLine.Change = TextViewLineChange.AddedOrUpdated;
				int num = 0;
				if (TWM() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		foreach (DAp item in hashSet)
		{
			item.Change = TextViewLineChange.Removed;
			item.Visibility = TextViewLineVisibility.Hidden;
		}
	}

	private static void LTf(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		if (P_0.Count <= 0)
		{
			return;
		}
		ITextViewLine textViewLine = P_0[0];
		if (!textViewLine.IsFirstLine)
		{
			return;
		}
		double num = textViewLine.Bounds.Y - P_1.kkJ().Top;
		if (!(num > 0.0))
		{
			return;
		}
		foreach (DAp item in P_0)
		{
			item.Nbm(item.Tb4() - num, _0020: true);
		}
	}

	private static bool LTD(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		bool result = false;
		if (P_0.Count > 0)
		{
			ITextViewLine textViewLine = P_0[P_0.Count - 1];
			if (textViewLine.IsLastLine)
			{
				if (!P_1.ScrollState.CanScrollPastDocumentEnd)
				{
					double num = textViewLine.Bounds.Bottom - P_1.kkh().Height;
					if (num < 0.0)
					{
						foreach (DAp item in P_0)
						{
							item.Nbm(item.Tb4() - num, _0020: true);
						}
					}
					result = num < 0.0;
				}
				double y = textViewLine.Bounds.Y;
				if (y < 0.0)
				{
					foreach (DAp item2 in P_0)
					{
						item2.Nbm(item2.Tb4() - y, _0020: true);
					}
				}
			}
		}
		return result;
	}

	private void pTg(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		TextViewScrollState textViewScrollState = P_1.ScrollState;
		int count = P_0.Count;
		if (count > 0)
		{
			ITextViewLine textViewLine = P_0.FirstOrDefault((ITextViewLine vl) => vl.Bounds.Y >= 0.0) ?? P_0[0];
			textViewScrollState.VerticalAnchorTextPosition = textViewLine.StartPosition;
			textViewScrollState.VerticalAnchorPlacement = TextViewVerticalAnchorPlacement.Top;
			textViewScrollState.VerticalAmountOffset = 0.0 - textViewLine.Bounds.Y;
		}
		if (textViewScrollState.HorizontalAmount != 0.0 && (count == 0 || lTs.WordWrapMode != WordWrapMode.None))
		{
			textViewScrollState.HorizontalAmount = 0.0;
		}
		else if (gTr)
		{
			double num = JTl(P_1.kkh().Width);
			if (num < 0.0)
			{
				textViewScrollState.HorizontalAmount = Math.Max(0.0, textViewScrollState.HorizontalAmount + num);
			}
		}
		lTs.hAm(textViewScrollState);
		gTr = false;
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	private QAR iTQ(R7s P_0, TextSnapshotRange P_1)
	{
		NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection = lTs.CollapsedRegionManager?.GetCollapsedRanges(P_1);
		int num;
		if (normalizedTextSnapshotRangeCollection == null)
		{
			num = 1;
			if (!bWj())
			{
				num = 0;
			}
			goto IL_0009;
		}
		NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection2 = normalizedTextSnapshotRangeCollection.GetInverse(P_1);
		goto IL_01d8;
		IL_01d8:
		NormalizedTextSnapshotRangeCollection normalizedTextSnapshotRangeCollection3 = normalizedTextSnapshotRangeCollection2;
		NA5 nA = new NA5(P_1, normalizedTextSnapshotRangeCollection3);
		IList<TagSnapshotRange<IIntraLineSpacerTag>> list = CTA(P_0, P_1, normalizedTextSnapshotRangeCollection3);
		IList<ITextSpacer> spacers = sTv(P_0, P_1, normalizedTextSnapshotRangeCollection, normalizedTextSnapshotRangeCollection3, nA);
		float maxWidth = (float)Math.Max(1.0, P_0.kkh().Width - P_0.kkJ().Left - 1.0);
		QAR qAR = new QAR(nA, P_0.Rkm().CreateTextLayout(nA, maxWidth, P_0.mkR(), P_0.Pko(), P_0.Bk8(), P_0.KkT(), P_0.ok6(), spacers), list);
		qAR.TabSize = P_0.XkM();
		qAR.TextWrapping = P_0.jSE();
		if (!P_1.IsZeroLength)
		{
			STX(P_0, qAR);
		}
		qAR.RunTextFormatter(P_0.TSP);
		num = 0;
		if (!bWj())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			return qAR;
		}
		normalizedTextSnapshotRangeCollection2 = new NormalizedTextSnapshotRangeCollection(P_1);
		goto IL_01d8;
	}

	private R7s nTe()
	{
		SyntaxEditor syntaxEditor = lTs.SyntaxEditor;
		TextLayoutWrapping textLayoutWrapping = TextLayoutWrapping.NoWrap;
		WordWrapMode wordWrapMode = lTs.WordWrapMode;
		WordWrapMode wordWrapMode2 = wordWrapMode;
		if (wordWrapMode2 == WordWrapMode.Word)
		{
			goto IL_00f9;
		}
		goto IL_0143;
		IL_0143:
		int num2 = default(int);
		while (true)
		{
			R7s r7s = new R7s();
			r7s.jkA(lTs.ArePartiallyVisibleViewLinesAllowed);
			r7s.CkC(lTs.aAY());
			r7s.jkF(lTs.ClassificationTagAggregator);
			r7s.FkY(lTs.DefaultFontFamilyName);
			int num = 1;
			if (!bWj())
			{
				num = num2;
			}
			switch (num)
			{
			case 2:
				break;
			default:
				continue;
			case 1:
			{
				r7s.jkj(lTs.DefaultFontSize);
				r7s.nkH(lTs.DefaultFontStyle);
				r7s.akL(lTs.DefaultFontWeight);
				r7s.YkI(lTs.DefaultForegroundColor);
				r7s.HighlightingStyleRegistry = lTs.HighlightingStyleRegistry;
				r7s.ukr(lTs.IntraLineSpacerTagAggregator);
				r7s.vkS(lTs.IntraTextSpacerTagAggregator);
				IEnumerable<ITextViewLine> collection;
				if (!xT5.HasValue)
				{
					IEnumerable<ITextViewLine> visibleViewLines = lTs.VisibleViewLines;
					collection = visibleViewLines;
				}
				else
				{
					IEnumerable<ITextViewLine> visibleViewLines = new ITextViewLine[0];
					collection = visibleViewLines;
				}
				r7s.ak2(new HashSet<ITextViewLine>(collection));
				r7s.ScrollState = lTs.ScrollState;
				r7s.lkO(syntaxEditor.Document.TabSize);
				r7s.Hkt(lTs.TextAreaPadding);
				r7s.KkN(xT5 ?? lTs.TextAreaSize);
				r7s.LSc(textLayoutWrapping);
				return r7s;
			}
			}
			break;
		}
		goto IL_00f9;
		IL_00f9:
		textLayoutWrapping = TextLayoutWrapping.Wrap;
		goto IL_0143;
	}

	private double JTl(double P_0)
	{
		if (lTs != null)
		{
			TextViewScrollState scrollState = lTs.ScrollState;
			if (scrollState.HorizontalAmount > 0.0)
			{
				double num = lTs.VisibleViewLines.MaxWidth - scrollState.HorizontalAmount;
				double num2 = Math.Max(0.0 - scrollState.HorizontalAmount, num - (double)(int)(0.85 * P_0));
				if (num2 < 0.0)
				{
					return num2;
				}
			}
		}
		return 0.0;
	}

	private IList<TagSnapshotRange<IIntraLineSpacerTag>> CTA(R7s P_0, TextSnapshotRange P_1, NormalizedTextSnapshotRangeCollection P_2)
	{
		List<TagSnapshotRange<IIntraLineSpacerTag>> list = null;
		ITagAggregator<IIntraLineSpacerTag> tagAggregator = P_0.tkV();
		if (tagAggregator != null)
		{
			IEnumerable<TagSnapshotRange<IIntraLineSpacerTag>> tags = tagAggregator.GetTags(P_2, lTs);
			if (tags != null)
			{
				foreach (TagSnapshotRange<IIntraLineSpacerTag> item in tags)
				{
					if (item.Tag != null && (item.Tag.TopMargin > 0.0 || item.Tag.BottomMargin > 0.0) && P_1.IntersectsWith(item.SnapshotRange.StartOffset) && (P_1.IsZeroLength || item.SnapshotRange.StartOffset < P_1.EndOffset))
					{
						if (list == null)
						{
							list = new List<TagSnapshotRange<IIntraLineSpacerTag>>();
						}
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
		}
		return list;
	}

	private IList<ITextSpacer> sTv(R7s P_0, TextSnapshotRange P_1, NormalizedTextSnapshotRangeCollection P_2, NormalizedTextSnapshotRangeCollection P_3, NA5 P_4)
	{
		List<TagSnapshotRange<IIntraTextSpacerTag>> list = null;
		ITagAggregator<IIntraTextSpacerTag> tagAggregator = P_0.ykk();
		if (tagAggregator != null)
		{
			IEnumerable<TagSnapshotRange<IIntraTextSpacerTag>> tags = tagAggregator.GetTags(P_3, lTs);
			if (tags != null)
			{
				foreach (TagSnapshotRange<IIntraTextSpacerTag> item2 in tags)
				{
					if (P_1.IntersectsWith(item2.SnapshotRange.StartOffset) && (P_1.IsZeroLength || item2.SnapshotRange.StartOffset < P_1.EndOffset))
					{
						if (list == null)
						{
							list = new List<TagSnapshotRange<IIntraTextSpacerTag>>();
						}
						if (!list.Contains(item2))
						{
							list.Add(item2);
						}
					}
				}
			}
			if (P_2 != null)
			{
				foreach (TextSnapshotRange item3 in P_2)
				{
					tags = tagAggregator.GetTags(new NormalizedTextSnapshotRangeCollection(new TextSnapshotRange(item3.Snapshot, item3.StartOffset, item3.StartOffset + 1)), lTs);
					if (tags == null)
					{
						continue;
					}
					foreach (TagSnapshotRange<IIntraTextSpacerTag> item4 in tags)
					{
						if (item4.SnapshotRange == item3)
						{
							if (list == null)
							{
								list = new List<TagSnapshotRange<IIntraTextSpacerTag>>();
							}
							list.Add(item4);
							break;
						}
					}
				}
			}
		}
		if (list != null)
		{
			if (list.Count > 1)
			{
				list.Sort((TagSnapshotRange<IIntraTextSpacerTag> x, TagSnapshotRange<IIntraTextSpacerTag> y) => x.SnapshotRange.StartOffset.CompareTo(y.SnapshotRange.StartOffset));
			}
			List<ITextSpacer> list2 = new List<ITextSpacer>();
			foreach (TagSnapshotRange<IIntraTextSpacerTag> item5 in list)
			{
				IIntraTextSpacerTag tag = item5.Tag;
				if (tag != null)
				{
					int count = list2.Count;
					int characterIndex = P_4.Translate(item5.SnapshotRange.StartOffset, TextProviderTranslateModes.FromSourceText) + count;
					ITextSpacer item = P_0.Rkm().CreateTextSpacer(characterIndex, item5, tag.Size, tag.Baseline);
					list2.Add(item);
				}
			}
			return list2;
		}
		return null;
	}

	private TextSnapshotRange xTm(int P_0, TextPosition? P_1)
	{
		if (!P_1.HasValue)
		{
			P_1 = JTI.OffsetToPosition(P_0);
		}
		int num = Math.Max(0, Math.Min(JTI.Lines.Count - 1, P_1.Value.Line));
		ITextSnapshotLineCollection lines = JTI.Lines;
		int count = lines.Count;
		ITextSnapshotLine textSnapshotLine = lines[num];
		int startOffset = textSnapshotLine.StartOffset;
		int endOffset = textSnapshotLine.EndOffset;
		int endOffsetIncludingLineTerminator = textSnapshotLine.EndOffsetIncludingLineTerminator;
		ICollapsedRegionManager collapsedRegionManager = lTs.CollapsedRegionManager;
		if (collapsedRegionManager != null)
		{
			int num2 = num;
			while (num2 > 0)
			{
				TextSnapshotRange collapsedRange = collapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(JTI, startOffset - 1));
				if (!collapsedRange.IsDeleted && collapsedRange.StartOffset < startOffset)
				{
					textSnapshotLine = lines[--num2];
					startOffset = textSnapshotLine.StartOffset;
					continue;
				}
				break;
			}
			while (num < count)
			{
				TextSnapshotRange collapsedRange2 = collapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(JTI, endOffset));
				if (!collapsedRange2.IsDeleted && collapsedRange2.EndOffset > endOffset)
				{
					textSnapshotLine = lines[num++];
					endOffset = textSnapshotLine.EndOffset;
					endOffsetIncludingLineTerminator = textSnapshotLine.EndOffsetIncludingLineTerminator;
					continue;
				}
				break;
			}
		}
		return new TextSnapshotRange(JTI, startOffset, endOffsetIncludingLineTerminator);
	}

	private DAp oTC(R7s P_0, int P_1, bool P_2, TextPosition? P_3, double P_4, TextViewVerticalAnchorPlacement? P_5)
	{
		if (!VTk.abz(P_1, P_2, out var dAp))
		{
			TextSnapshotRange textSnapshotRange = xTm(P_1, P_3);
			QAR qAR = iTQ(P_0, textSnapshotRange);
			int num = qAR.TextProvider.Translate(P_1, TextProviderTranslateModes.FromSourceText);
			foreach (DAp item in VTk.rbt(lTs, textSnapshotRange, qAR))
			{
				item.pbv(P_0.kkJ().Left, P_0.kkJ().Right);
				if (dAp == null)
				{
					int startCharacterIndex = item.pbR().StartCharacterIndex;
					int characterCount = item.pbR().CharacterCount;
					if (num >= startCharacterIndex && (num < startCharacterIndex + characterCount || item.HasHardLineBreak || item.IsLastLine || (!P_2 && num <= startCharacterIndex + characterCount)))
					{
						dAp = item;
					}
				}
			}
		}
		if (dAp != null && P_5.HasValue)
		{
			switch (P_5)
			{
			case TextViewVerticalAnchorPlacement.Bottom:
				dAp.Nbm(P_4 - dAp.Size.Height, _0020: false);
				break;
			case TextViewVerticalAnchorPlacement.Center:
				dAp.Nbm(P_4 - dAp.Size.Height / 2.0, _0020: false);
				break;
			case TextViewVerticalAnchorPlacement.TextBottom:
				dAp.Nbm(P_4 - dAp.TopMargin - dAp.TextSize.Height, _0020: false);
				break;
			case TextViewVerticalAnchorPlacement.TextCenter:
				dAp.Nbm(P_4 - dAp.TopMargin - dAp.TextSize.Height / 2.0, _0020: false);
				break;
			case TextViewVerticalAnchorPlacement.TextTop:
				dAp.Nbm(P_4 - dAp.TopMargin, _0020: false);
				break;
			default:
				dAp.Nbm(P_4, _0020: false);
				break;
			}
		}
		Debug.Assert(dAp != null, Q7Z.tqM(194290));
		return dAp;
	}

	private void qTu(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		ITextViewLine textViewLine = P_0.FirstOrDefault();
		if (textViewLine == null)
		{
			return;
		}
		double y = textViewLine.Bounds.Y;
		while (y >= 0.0 && !textViewLine.IsFirstLine)
		{
			textViewLine = oTC(P_1, textViewLine.StartOffset - 1, _0020: true, null, y, TextViewVerticalAnchorPlacement.Bottom);
			if (textViewLine == null)
			{
				break;
			}
			y = textViewLine.Bounds.Y;
			P_0.Insert(0, textViewLine);
		}
	}

	private void LT1(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		TextViewScrollState textViewScrollState = P_1.ScrollState;
		double num = 0.0 - textViewScrollState.VerticalAmountOffset;
		switch (textViewScrollState.VerticalAnchorPlacement)
		{
		case TextViewVerticalAnchorPlacement.Top:
		case TextViewVerticalAnchorPlacement.TextTop:
			num += P_1.kkJ().Top;
			break;
		case TextViewVerticalAnchorPlacement.Center:
		case TextViewVerticalAnchorPlacement.TextCenter:
			num += P_1.kkh().Height / 2.0;
			break;
		case TextViewVerticalAnchorPlacement.Bottom:
		case TextViewVerticalAnchorPlacement.TextBottom:
			num += P_1.kkh().Height - P_1.kkJ().Bottom;
			break;
		}
		int num2 = JTI.Lines.Count - 1;
		TextPosition textPosition = TextPosition.First(position2: new TextPosition(num2, JTI.Lines[num2].Length), position1: textViewScrollState.VerticalAnchorTextPosition);
		int num3 = JTI.PositionToOffset(textPosition);
		DAp dAp = oTC(P_1, num3, textPosition.HasFarAffinity, textPosition, num, textViewScrollState.VerticalAnchorPlacement);
		if (dAp != null)
		{
			P_0.Add(dAp);
		}
	}

	private void pTF(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		ITextViewLine textViewLine = P_0.LastOrDefault();
		if (textViewLine == null)
		{
			return;
		}
		double bottom = textViewLine.Bounds.Bottom;
		Size size = P_1.kkh();
		while (bottom <= size.Height && !textViewLine.IsLastLine)
		{
			textViewLine = oTC(P_1, textViewLine.EndOffsetIncludingLineTerminator, _0020: true, null, bottom, TextViewVerticalAnchorPlacement.Top);
			if (textViewLine == null)
			{
				break;
			}
			bottom = textViewLine.Bounds.Bottom;
			P_0.Add(textViewLine);
		}
	}

	private HashSet<ITextViewLine> ST3()
	{
		if (lTs != null)
		{
			DTb();
			R7s r7s = nTe();
			ObservableCollection<ITextViewLine> observableCollection = new ObservableCollection<ITextViewLine>();
			if (r7s.Rkm() != null)
			{
				using (IDisposable disposable = r7s.Rkm().CreateTextBatch())
				{
					r7s.TSP = disposable;
					LT1(observableCollection, r7s);
					qTu(observableCollection, r7s);
					LTf(observableCollection, r7s);
					pTF(observableCollection, r7s);
					if (LTD(observableCollection, r7s))
					{
						qTu(observableCollection, r7s);
						LTf(observableCollection, r7s);
					}
				}
				GTR(observableCollection, r7s);
				lTs.VisibleViewLines = new lAn(observableCollection, r7s.kkh(), lTs.DefaultLineHeight);
				GTR(observableCollection, r7s);
				pTg(observableCollection, r7s);
				if (!r7s.IsWordWrapEnabled)
				{
					zTS.hTi(observableCollection);
				}
				DTY(observableCollection);
				ATK(r7s);
				wTB = true;
				r7s.Rkm().InvalidateRender();
			}
			return r7s.Akq();
		}
		return null;
	}

	private static void GTR(ObservableCollection<ITextViewLine> P_0, R7s P_1)
	{
		Size size = P_1.kkh();
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			Rect bounds = P_0[num].Bounds;
			if (bounds.Bottom <= 0.0 || bounds.Top > size.Height || (!P_1.Dkl() && num > 0 && bounds.Bottom > size.Height))
			{
				P_0.RemoveAt(num);
			}
		}
	}

	[Conditional("DEBUG")]
	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private void DTY(ObservableCollection<ITextViewLine> P_0)
	{
		VTk.YTW();
		if (P_0.Count <= 0)
		{
			return;
		}
		int num = P_0[0].StartOffset - 1;
		foreach (ITextViewLine item in P_0)
		{
			if (item.StartOffset < num + ((!item.IsWrapped) ? 1 : 0))
			{
				throw new InvalidOperationException();
			}
			num = item.EndOffset;
		}
	}

	[SpecialName]
	public ITextSnapshot WTT()
	{
		return JTI;
	}

	public ITextViewLine PT4(int P_0, bool P_1)
	{
		R7s r7s = nTe();
		return oTC(r7s, P_0, P_1, null, 0.0, null);
	}

	public void ITo()
	{
		VTk.Sbh();
		zTS.PTq();
		wTB = false;
	}

	public void LTj()
	{
		wTB = false;
	}

	public void HTw(Size P_0, Size P_1)
	{
		if (lTs == null)
		{
			return;
		}
		bool flag = P_0.Width != P_1.Width;
		bool flag2 = P_0.Height != P_1.Height;
		bool flag3 = lTs.WordWrapMode != WordWrapMode.None;
		wTB &= !flag2 && !(flag && flag3);
		if (!flag)
		{
			return;
		}
		gTr = true;
		int num;
		if (wTB)
		{
			if (!(JTl(P_1.Width) < 0.0))
			{
				num = 1;
				if (!bWj())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			wTB = false;
			return;
		}
		if (flag3)
		{
			ITo();
		}
		return;
		IL_0009:
		do
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			}
			lTs.gA1();
			num = 0;
		}
		while (TWM() == null);
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public void pT6(TextSnapshotRange P_0)
	{
		if (P_0.IsDeleted || P_0.Snapshot.Document != WTT().Document)
		{
			ITo();
			return;
		}
		VTk.qbN(P_0);
		zTS.jT2(P_0);
		wTB = false;
	}

	public bool gTH()
	{
		bool flag = !wTB && !uTV && lTs != null;
		int num = 0;
		if (TWM() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (flag)
			{
				try
				{
					uTV = true;
					int num3 = 0;
					if (TWM() != null)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
					{
						HashSet<ITextViewLine> removedViewLines = null;
						FAi fAi = lTs.aAY();
						if (fAi != null)
						{
							removedViewLines = fAi.ExecuteFunc(ST3);
						}
						nR nR2 = lTs.DAb();
						if (nR2 != null)
						{
							lTs.DAb().Ylh();
						}
						TextViewTextAreaLayoutEventArgs e = new TextViewTextAreaLayoutEventArgs(lTs, removedViewLines, AT0);
						lTs.eAF(e);
						AT0 = false;
						VTk.RbZ(lTs.VisibleViewLines);
						return true;
					}
					}
				}
				finally
				{
					uTV = false;
				}
			}
			return false;
		}
	}

	public void DTb(ITextChange P_0 = null)
	{
		if (lTs == null)
		{
			return;
		}
		ITextSnapshot jTI = JTI;
		JTI = lTs.SyntaxEditor.Document.CurrentSnapshot;
		if (JTI == jTI)
		{
			return;
		}
		AT0 = true;
		if (P_0 != null && P_0.LastTextReplacementOperationIndex != -1)
		{
			int num = 0;
			if (TWM() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			ITo();
		}
		else
		{
			VTk.Qbd(jTI, JTI);
			zTS.LT7(jTI, JTI);
			VTk.YTW();
			wTB = false;
		}
	}

	[SpecialName]
	public AAo WTn()
	{
		return zTS;
	}

	internal static bool bWj()
	{
		return HWH == null;
	}

	internal static oAY TWM()
	{
		return HWH;
	}
}
