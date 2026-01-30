using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Internal;

internal static class cT
{
	private static IClassificationType IP6;

	private static IClassificationType EPH;

	private static IClassificationType pPb;

	private static IClassificationType tPT;

	private static IClassificationType ePL;

	private static IClassificationType WPn;

	private static IClassificationType RP8;

	private static IClassificationType yPI;

	private static IClassificationType gP5;

	private static IClassificationType SP0;

	private static IClassificationType vPB;

	private static IClassificationType PPV;

	private static IClassificationType BPr;

	private static IClassificationType IPs;

	private static IClassificationType uPk;

	private static IClassificationType APS;

	private static IClassificationType SP9;

	private static IClassificationType GPy;

	private static IClassificationType SPq;

	private static IClassificationType vP2;

	private static IClassificationType UP7;

	private static IClassificationType APi;

	private static IClassificationType uPp;

	private static cT cR;

	public static IClassificationType BreakpointDisabled
	{
		get
		{
			if (IP6 == null)
			{
				IP6 = new ClassificationType(Q7Z.tqM(84), SR.GetString(SRName.UIClassificationTypeBreakpointDisabled));
			}
			return IP6;
		}
	}

	public static IClassificationType BreakpointEnabled
	{
		get
		{
			if (EPH == null)
			{
				EPH = new ClassificationType(Q7Z.tqM(124), SR.GetString(SRName.UIClassificationTypeBreakpointEnabled));
			}
			return EPH;
		}
	}

	public static IClassificationType CodeSnippetDependentField
	{
		get
		{
			if (pPb == null)
			{
				pPb = new ClassificationType(Q7Z.tqM(162), SR.GetString(SRName.UIClassificationTypeCodeSnippetDependentField));
			}
			return pPb;
		}
	}

	public static IClassificationType CodeSnippetField
	{
		get
		{
			if (tPT == null)
			{
				tPT = new ClassificationType(Q7Z.tqM(216), SR.GetString(SRName.UIClassificationTypeCodeSnippetField));
			}
			return tPT;
		}
	}

	public static IClassificationType CollapsedText
	{
		get
		{
			if (ePL == null)
			{
				ePL = new ClassificationType(Q7Z.tqM(252), SR.GetString(SRName.UIClassificationTypeCollapsedText));
			}
			return ePL;
		}
	}

	public static IClassificationType CollapsibleRegion
	{
		get
		{
			if (WPn == null)
			{
				WPn = new ClassificationType(Q7Z.tqM(282), SR.GetString(SRName.UIClassificationTypeCollapsibleRegion));
			}
			return WPn;
		}
	}

	public static IClassificationType CurrentLine
	{
		get
		{
			if (RP8 == null)
			{
				RP8 = new ClassificationType(Q7Z.tqM(320), SR.GetString(SRName.UIClassificationTypeCurrentLine));
			}
			return RP8;
		}
	}

	public static IClassificationType CurrentStatement
	{
		get
		{
			if (yPI == null)
			{
				yPI = new ClassificationType(Q7Z.tqM(346), SR.GetString(SRName.UIClassificationTypeCurrentStatement));
			}
			return yPI;
		}
	}

	public static IClassificationType DelimiterMatching
	{
		get
		{
			if (gP5 == null)
			{
				gP5 = new ClassificationType(Q7Z.tqM(382), SR.GetString(SRName.UIClassificationTypeDelimiterMatching));
			}
			return gP5;
		}
	}

	public static IClassificationType FindMatchHighlight
	{
		get
		{
			if (SP0 == null)
			{
				SP0 = new ClassificationType(Q7Z.tqM(420), SR.GetString(SRName.UIClassificationTypeFindMatchHighlight));
			}
			return SP0;
		}
	}

	public static IClassificationType FindScopeHighlight
	{
		get
		{
			if (vPB == null)
			{
				vPB = new ClassificationType(Q7Z.tqM(460), SR.GetString(SRName.UIClassificationTypeFindScopeHighlight));
			}
			return vPB;
		}
	}

	public static IClassificationType InactiveSelectedText
	{
		get
		{
			if (PPV == null)
			{
				PPV = new kAg(Q7Z.tqM(500), SR.GetString(SRName.UIClassificationTypeInactiveSelectedText), new Ordering[2]
				{
					new Ordering(PlainText.Key, OrderPlacement.After),
					new Ordering(SelectedText.Key, OrderPlacement.After)
				});
			}
			return PPV;
		}
	}

	public static IClassificationType IndentationGuides
	{
		get
		{
			if (BPr == null)
			{
				BPr = new ClassificationType(Q7Z.tqM(544), SR.GetString(SRName.UIClassificationTypeIndentationGuides));
			}
			return BPr;
		}
	}

	public static IClassificationType IndicatorMargin
	{
		get
		{
			if (IPs == null)
			{
				IPs = new kAg(Q7Z.tqM(582), SR.GetString(SRName.UIClassificationTypeIndicatorMargin), new Ordering[3]
				{
					new Ordering(PlainText.Key, OrderPlacement.After),
					new Ordering(SelectedText.Key, OrderPlacement.After),
					new Ordering(InactiveSelectedText.Key, OrderPlacement.After)
				});
			}
			return IPs;
		}
	}

	public static IClassificationType LineNumbers
	{
		get
		{
			if (uPk == null)
			{
				uPk = new kAg(Q7Z.tqM(616), SR.GetString(SRName.UIClassificationTypeLineNumbers), new Ordering[4]
				{
					new Ordering(PlainText.Key, OrderPlacement.After),
					new Ordering(SelectedText.Key, OrderPlacement.After),
					new Ordering(InactiveSelectedText.Key, OrderPlacement.After),
					new Ordering(IndicatorMargin.Key, OrderPlacement.After)
				});
			}
			return uPk;
		}
	}

	public static IClassificationType OutliningMarginSquare
	{
		get
		{
			if (APS == null)
			{
				APS = new ClassificationType(Q7Z.tqM(642), SR.GetString(SRName.UIClassificationTypeOutliningMarginSquare));
			}
			return APS;
		}
	}

	public static IClassificationType OutliningMarginVerticalRule
	{
		get
		{
			if (SP9 == null)
			{
				SP9 = new ClassificationType(Q7Z.tqM(688), SR.GetString(SRName.UIClassificationTypeOutliningMarginVerticalRule));
			}
			return SP9;
		}
	}

	public static IClassificationType PlainText
	{
		get
		{
			if (GPy == null)
			{
				GPy = new kAg(Q7Z.tqM(746), SR.GetString(SRName.UIClassificationTypePlainText), null);
			}
			return GPy;
		}
	}

	public static IClassificationType RevertedChangesMark
	{
		get
		{
			if (SPq == null)
			{
				SPq = new ClassificationType(Q7Z.tqM(768), SR.GetString(SRName.UIClassificationTypeRevertedChangesMark));
			}
			return SPq;
		}
	}

	public static IClassificationType SavedChangesMark
	{
		get
		{
			if (vP2 == null)
			{
				vP2 = new ClassificationType(Q7Z.tqM(810), SR.GetString(SRName.UIClassificationTypeSavedChangesMark));
			}
			return vP2;
		}
	}

	public static IClassificationType SelectedText
	{
		get
		{
			if (UP7 == null)
			{
				UP7 = new kAg(Q7Z.tqM(846), SR.GetString(SRName.UIClassificationTypeSelectedText), new Ordering[1]
				{
					new Ordering(PlainText.Key, OrderPlacement.After)
				});
			}
			return UP7;
		}
	}

	public static IClassificationType UnsavedChangesMark
	{
		get
		{
			if (APi == null)
			{
				APi = new ClassificationType(Q7Z.tqM(874), SR.GetString(SRName.UIClassificationTypeUnsavedChangesMark));
			}
			return APi;
		}
	}

	public static IClassificationType VisibleWhitespace
	{
		get
		{
			if (uPp == null)
			{
				uPp = new kAg(Q7Z.tqM(914), SR.GetString(SRName.UIClassificationTypeVisibleWhitespace), new Ordering[5]
				{
					new Ordering(PlainText.Key, OrderPlacement.After),
					new Ordering(SelectedText.Key, OrderPlacement.After),
					new Ordering(InactiveSelectedText.Key, OrderPlacement.After),
					new Ordering(IndicatorMargin.Key, OrderPlacement.After),
					new Ordering(LineNumbers.Key, OrderPlacement.After)
				});
			}
			return uPp;
		}
	}

	internal static bool dO()
	{
		return cR == null;
	}

	internal static cT W1()
	{
		return cR;
	}
}
