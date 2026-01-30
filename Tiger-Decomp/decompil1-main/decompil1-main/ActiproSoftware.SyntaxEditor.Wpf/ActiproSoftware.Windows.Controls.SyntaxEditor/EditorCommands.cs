using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public static class EditorCommands
{
	private static EditActionBase APt;

	private static EditActionBase WPZ;

	private static EditActionBase xPh;

	private static EditActionBase iPN;

	private static EditActionBase LPd;

	private static EditActionBase SPz;

	private static EditActionBase XEW;

	private static EditActionBase JEP;

	private static EditActionBase LEE;

	private static EditActionBase JEc;

	private static EditActionBase oEa;

	private static EditActionBase FEx;

	private static EditActionBase sEG;

	private static EditActionBase vEX;

	private static EditActionBase mEK;

	private static EditActionBase nEf;

	private static EditActionBase JED;

	private static EditActionBase zEg;

	private static EditActionBase fEQ;

	private static EditActionBase MEe;

	private static EditActionBase EEl;

	private static EditActionBase sEA;

	private static EditActionBase fEv;

	private static EditActionBase pEm;

	private static EditActionBase IEC;

	private static EditActionBase hEu;

	private static EditActionBase GE1;

	private static EditActionBase wEF;

	private static EditActionBase WE3;

	private static EditActionBase CER;

	private static EditActionBase GEY;

	private static EditActionBase cE4;

	private static EditActionBase IEo;

	private static EditActionBase sEj;

	private static EditActionBase uEw;

	private static EditActionBase QE6;

	private static EditActionBase dEH;

	private static EditActionBase eEb;

	private static EditActionBase lET;

	private static EditActionBase CEL;

	private static EditActionBase EEn;

	private static EditActionBase UE8;

	private static EditActionBase nEI;

	private static EditActionBase EE5;

	private static EditActionBase cE0;

	private static EditActionBase OEB;

	private static EditActionBase HEV;

	private static EditActionBase tEr;

	private static EditActionBase DEs;

	private static EditActionBase pEk;

	private static EditActionBase RES;

	private static EditActionBase gE9;

	private static EditActionBase IEy;

	private static EditActionBase eEq;

	private static EditActionBase aE2;

	private static EditActionBase RE7;

	private static EditActionBase OEi;

	private static EditActionBase gEp;

	private static EditActionBase wEM;

	private static EditActionBase VEO;

	private static EditActionBase bEU;

	private static EditActionBase rEJ;

	private static EditActionBase CEt;

	private static EditActionBase oEZ;

	private static EditActionBase WEh;

	private static EditActionBase XEN;

	private static EditActionBase jEd;

	private static EditActionBase zEz;

	private static EditActionBase IcW;

	private static EditActionBase hcP;

	private static EditActionBase CcE;

	private static EditActionBase Acc;

	private static EditActionBase dca;

	private static EditActionBase Mcx;

	private static EditActionBase WcG;

	private static EditActionBase mcX;

	private static EditActionBase lcK;

	private static EditActionBase Bcf;

	private static EditActionBase jcD;

	private static EditActionBase Jcg;

	private static EditActionBase VcQ;

	private static EditActionBase wce;

	private static EditActionBase Wcl;

	private static EditActionBase pcA;

	private static EditActionBase rcv;

	private static EditActionBase acm;

	private static EditActionBase RcC;

	private static EditActionBase Ncu;

	private static EditActionBase tc1;

	private static EditActionBase AcF;

	private static EditActionBase Ec3;

	private static EditActionBase AcR;

	private static EditActionBase VcY;

	private static EditActionBase yc4;

	private static EditActionBase tco;

	private static EditActionBase Scj;

	private static EditActionBase Kcw;

	private static EditActionBase Jc6;

	private static EditActionBase dcH;

	private static EditActionBase xcb;

	private static EditActionBase fcT;

	private static EditActionBase UcL;

	private static EditActionBase Ecn;

	private static EditActionBase dc8;

	private static EditActionBase TcI;

	private static EditActionBase Uc5;

	private static EditActionBase kc0;

	private static EditActionBase hcB;

	private static EditActionBase wcV;

	private static EditActionBase ocr;

	private static EditActionBase Vcs;

	private static EditActionBase Ick;

	private static EditActionBase ScS;

	private static EditActionBase mc9;

	private static EditActionBase Qcy;

	private static EditActionBase Ocq;

	private static EditActionBase gc2;

	private static EditActionBase pc7;

	private static EditActionBase fci;

	private static EditActionBase Ycp;

	private static EditActionBase mcM;

	private static EditActionBase mcO;

	private static EditActionBase tcU;

	private static EditActionBase ecJ;

	private static EditActionBase xct;

	private static EditActionBase IcZ;

	private static EditActionBase ach;

	private static EditActionBase TcN;

	private static EditActionBase dcd;

	private static EditActionBase mcz;

	private static EditActionBase gaW;

	private static EditActionBase KaP;

	private static EditActionBase faE;

	private static EditorCommands zH;

	public static EditActionBase ApplyDefaultOutliningExpansion
	{
		get
		{
			if (APt == null)
			{
				APt = new ApplyDefaultOutliningExpansionAction();
			}
			return APt;
		}
	}

	public static EditActionBase Backspace
	{
		get
		{
			if (WPZ == null)
			{
				WPZ = new BackspaceAction();
			}
			return WPZ;
		}
	}

	public static EditActionBase BackspaceToPreviousWord
	{
		get
		{
			if (xPh == null)
			{
				xPh = new BackspaceToPreviousWordAction();
			}
			return xPh;
		}
	}

	public static EditActionBase CancelMacroRecording
	{
		get
		{
			if (iPN == null)
			{
				iPN = new CancelMacroRecordingAction();
			}
			return iPN;
		}
	}

	public static EditActionBase Capitalize
	{
		get
		{
			if (LPd == null)
			{
				LPd = new CapitalizeAction();
			}
			return LPd;
		}
	}

	public static EditActionBase CodeBlockSelectionContract
	{
		get
		{
			if (SPz == null)
			{
				SPz = new CodeBlockSelectionContractAction();
			}
			return SPz;
		}
	}

	public static EditActionBase CodeBlockSelectionExpand
	{
		get
		{
			if (XEW == null)
			{
				XEW = new CodeBlockSelectionExpandAction();
			}
			return XEW;
		}
	}

	public static EditActionBase CollapseSelection
	{
		get
		{
			if (JEP == null)
			{
				JEP = new CollapseSelectionAction();
			}
			return JEP;
		}
	}

	public static EditActionBase CollapseSelectionLeft
	{
		get
		{
			if (LEE == null)
			{
				LEE = new CollapseSelectionLeftAction();
			}
			return LEE;
		}
	}

	public static EditActionBase CollapseSelectionRight
	{
		get
		{
			if (JEc == null)
			{
				JEc = new CollapseSelectionRightAction();
			}
			return JEc;
		}
	}

	public static EditActionBase CollapseToDefinitions
	{
		get
		{
			if (oEa == null)
			{
				oEa = new CollapseToDefinitionsAction();
			}
			return oEa;
		}
	}

	public static EditActionBase CommentLines
	{
		get
		{
			if (FEx == null)
			{
				FEx = new CommentLinesAction();
			}
			return FEx;
		}
	}

	public static EditActionBase ConvertSpacesToTabs
	{
		get
		{
			if (sEG == null)
			{
				sEG = new ConvertSpacesToTabsAction();
			}
			return sEG;
		}
	}

	public static EditActionBase ConvertTabsToSpaces
	{
		get
		{
			if (vEX == null)
			{
				vEX = new ConvertTabsToSpacesAction();
			}
			return vEX;
		}
	}

	public static EditActionBase CopyAndAppendToClipboard
	{
		get
		{
			if (mEK == null)
			{
				mEK = new CopyAndAppendToClipboardAction();
			}
			return mEK;
		}
	}

	public static EditActionBase CopyToClipboard
	{
		get
		{
			if (nEf == null)
			{
				nEf = new CopyToClipboardAction();
				nEf.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control));
			}
			return nEf;
		}
	}

	public static EditActionBase CutAndAppendToClipboard
	{
		get
		{
			if (JED == null)
			{
				JED = new CutAndAppendToClipboardAction();
			}
			return JED;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "CutLine")]
	public static EditActionBase CutLineToClipboard
	{
		get
		{
			if (zEg == null)
			{
				zEg = new CutLineToClipboardAction();
			}
			return zEg;
		}
	}

	public static EditActionBase CutToClipboard
	{
		get
		{
			if (fEQ == null)
			{
				fEQ = new CutToClipboardAction();
				fEQ.InputGestures.Add(new KeyGesture(Key.X, ModifierKeys.Control));
			}
			return fEQ;
		}
	}

	public static EditActionBase Delete
	{
		get
		{
			if (MEe == null)
			{
				MEe = new DeleteAction();
			}
			return MEe;
		}
	}

	public static EditActionBase DeleteBlankLines
	{
		get
		{
			if (EEl == null)
			{
				EEl = new DeleteBlankLinesAction();
			}
			return EEl;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static EditActionBase DeleteHorizontalWhitespace
	{
		get
		{
			if (sEA == null)
			{
				sEA = new DeleteHorizontalWhitespaceAction();
			}
			return sEA;
		}
	}

	public static EditActionBase DeleteLine
	{
		get
		{
			if (fEv == null)
			{
				fEv = new DeleteLineAction();
			}
			return fEv;
		}
	}

	public static EditActionBase DeleteToLineEnd
	{
		get
		{
			if (pEm == null)
			{
				pEm = new DeleteToLineEndAction();
			}
			return pEm;
		}
	}

	public static EditActionBase DeleteToLineStart
	{
		get
		{
			if (IEC == null)
			{
				IEC = new DeleteToLineStartAction();
			}
			return IEC;
		}
	}

	public static EditActionBase DeleteToNextWord
	{
		get
		{
			if (hEu == null)
			{
				hEu = new DeleteToNextWordAction();
			}
			return hEu;
		}
	}

	public static EditActionBase Duplicate
	{
		get
		{
			if (GE1 == null)
			{
				GE1 = new DuplicateAction();
			}
			return GE1;
		}
	}

	public static EditActionBase ExpandAllOutlining
	{
		get
		{
			if (wEF == null)
			{
				wEF = new ExpandAllOutliningAction();
			}
			return wEF;
		}
	}

	public static EditActionBase Find
	{
		get
		{
			if (WE3 == null)
			{
				WE3 = new FindAction();
			}
			return WE3;
		}
	}

	public static EditActionBase FindNext
	{
		get
		{
			if (CER == null)
			{
				CER = new FindNextAction();
			}
			return CER;
		}
	}

	public static EditActionBase FindNextSelected
	{
		get
		{
			if (GEY == null)
			{
				GEY = new FindNextSelectedAction();
			}
			return GEY;
		}
	}

	public static EditActionBase FindPrevious
	{
		get
		{
			if (cE4 == null)
			{
				cE4 = new FindPreviousAction();
			}
			return cE4;
		}
	}

	public static EditActionBase FindPreviousSelected
	{
		get
		{
			if (IEo == null)
			{
				IEo = new FindPreviousSelectedAction();
			}
			return IEo;
		}
	}

	public static EditActionBase FormatDocument
	{
		get
		{
			if (sEj == null)
			{
				sEj = new FormatDocumentAction();
			}
			return sEj;
		}
	}

	public static EditActionBase FormatSelection
	{
		get
		{
			if (uEw == null)
			{
				uEw = new FormatSelectionAction();
			}
			return uEw;
		}
	}

	public static EditActionBase HideSelection
	{
		get
		{
			if (QE6 == null)
			{
				QE6 = new HideSelectionAction();
			}
			return QE6;
		}
	}

	public static EditActionBase IncrementalSearch
	{
		get
		{
			if (dEH == null)
			{
				dEH = new IncrementalSearchAction();
			}
			return dEH;
		}
	}

	public static EditActionBase Indent
	{
		get
		{
			if (eEb == null)
			{
				eEb = new IndentAction();
			}
			return eEb;
		}
	}

	public static EditActionBase InsertLineBreak
	{
		get
		{
			if (lET == null)
			{
				lET = new InsertLineBreakAction();
			}
			return lET;
		}
	}

	public static EditActionBase InsertTabStopOrIndent
	{
		get
		{
			if (CEL == null)
			{
				CEL = new InsertTabStopOrIndentAction();
			}
			return CEL;
		}
	}

	public static EditActionBase MakeLowercase
	{
		get
		{
			if (UE8 == null)
			{
				UE8 = new MakeLowercaseAction();
			}
			return UE8;
		}
	}

	public static EditActionBase MakeUppercase
	{
		get
		{
			if (EEn == null)
			{
				EEn = new MakeUppercaseAction();
			}
			return EEn;
		}
	}

	public static EditActionBase MoveDown
	{
		get
		{
			if (nEI == null)
			{
				nEI = new MoveDownAction();
			}
			return nEI;
		}
	}

	public static EditActionBase MoveLeft
	{
		get
		{
			if (EE5 == null)
			{
				EE5 = new MoveLeftAction();
			}
			return EE5;
		}
	}

	public static EditActionBase MovePageDown
	{
		get
		{
			if (cE0 == null)
			{
				cE0 = new MovePageDownAction();
			}
			return cE0;
		}
	}

	public static EditActionBase MovePageUp
	{
		get
		{
			if (OEB == null)
			{
				OEB = new MovePageUpAction();
			}
			return OEB;
		}
	}

	public static EditActionBase MoveRight
	{
		get
		{
			if (HEV == null)
			{
				HEV = new MoveRightAction();
			}
			return HEV;
		}
	}

	public static EditActionBase MoveSelectedLinesDown
	{
		get
		{
			if (tEr == null)
			{
				tEr = new MoveSelectedLinesDownAction();
			}
			return tEr;
		}
	}

	public static EditActionBase MoveSelectedLinesUp
	{
		get
		{
			if (DEs == null)
			{
				DEs = new MoveSelectedLinesUpAction();
			}
			return DEs;
		}
	}

	public static EditActionBase MoveToDocumentEnd
	{
		get
		{
			if (pEk == null)
			{
				pEk = new MoveToDocumentEndAction();
			}
			return pEk;
		}
	}

	public static EditActionBase MoveToDocumentStart
	{
		get
		{
			if (RES == null)
			{
				RES = new MoveToDocumentStartAction();
			}
			return RES;
		}
	}

	public static EditActionBase MoveToLineEnd
	{
		get
		{
			if (gE9 == null)
			{
				gE9 = new MoveToLineEndAction();
			}
			return gE9;
		}
	}

	public static EditActionBase MoveToLineStart
	{
		get
		{
			if (IEy == null)
			{
				IEy = new MoveToLineStartAction();
			}
			return IEy;
		}
	}

	public static EditActionBase MoveToLineStartAfterIndentation
	{
		get
		{
			if (eEq == null)
			{
				eEq = new MoveToLineStartAfterIndentationAction();
			}
			return eEq;
		}
	}

	public static EditActionBase MoveToMatchingBracket
	{
		get
		{
			if (aE2 == null)
			{
				aE2 = new MoveToMatchingBracketAction();
			}
			return aE2;
		}
	}

	public static EditActionBase MoveToNextLineStartAfterIndentation
	{
		get
		{
			if (RE7 == null)
			{
				RE7 = new MoveToNextLineStartAfterIndentationAction();
			}
			return RE7;
		}
	}

	public static EditActionBase MoveToNextWord
	{
		get
		{
			if (OEi == null)
			{
				OEi = new MoveToNextWordAction();
			}
			return OEi;
		}
	}

	public static EditActionBase MoveToPreviousLineStartAfterIndentation
	{
		get
		{
			if (gEp == null)
			{
				gEp = new MoveToPreviousLineStartAfterIndentationAction();
			}
			return gEp;
		}
	}

	public static EditActionBase MoveToPreviousWord
	{
		get
		{
			if (wEM == null)
			{
				wEM = new MoveToPreviousWordAction();
			}
			return wEM;
		}
	}

	public static EditActionBase MoveToVisibleBottom
	{
		get
		{
			if (VEO == null)
			{
				VEO = new MoveToVisibleBottomAction();
			}
			return VEO;
		}
	}

	public static EditActionBase MoveToVisibleTop
	{
		get
		{
			if (bEU == null)
			{
				bEU = new MoveToVisibleTopAction();
			}
			return bEU;
		}
	}

	public static EditActionBase MoveUp
	{
		get
		{
			if (rEJ == null)
			{
				rEJ = new MoveUpAction();
			}
			return rEJ;
		}
	}

	public static EditActionBase OpenLineAbove
	{
		get
		{
			if (CEt == null)
			{
				CEt = new OpenLineAboveAction();
			}
			return CEt;
		}
	}

	public static EditActionBase OpenLineBelow
	{
		get
		{
			if (oEZ == null)
			{
				oEZ = new OpenLineBelowAction();
			}
			return oEZ;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
	public static EditActionBase Outdent
	{
		get
		{
			if (WEh == null)
			{
				WEh = new OutdentAction();
			}
			return WEh;
		}
	}

	public static EditActionBase PasteFromClipboard
	{
		get
		{
			if (XEN == null)
			{
				XEN = new PasteFromClipboardAction();
				XEN.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Control));
			}
			return XEN;
		}
	}

	public static EditActionBase PauseResumeMacroRecording
	{
		get
		{
			if (jEd == null)
			{
				jEd = new PauseResumeMacroRecordingAction();
			}
			return jEd;
		}
	}

	public static EditActionBase Redo
	{
		get
		{
			if (zEz == null)
			{
				zEz = new RedoAction();
			}
			return zEz;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Outdent")]
	public static EditActionBase RemoveTabStopOrOutdent
	{
		get
		{
			if (IcW == null)
			{
				IcW = new RemoveTabStopOrOutdentAction();
			}
			return IcW;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptAutoComplete
	{
		get
		{
			if (hcP == null)
			{
				hcP = new RequestIntelliPromptAutoCompleteAction();
			}
			return hcP;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptCompletionSession
	{
		get
		{
			if (CcE == null)
			{
				CcE = new RequestIntelliPromptCompletionSessionAction();
			}
			return CcE;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptInsertSnippetSession
	{
		get
		{
			if (Acc == null)
			{
				Acc = new RequestIntelliPromptInsertSnippetSessionAction();
			}
			return Acc;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptParameterInfoSession
	{
		get
		{
			if (dca == null)
			{
				dca = new RequestIntelliPromptParameterInfoSessionAction();
			}
			return dca;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptQuickInfoSession
	{
		get
		{
			if (Mcx == null)
			{
				Mcx = new RequestIntelliPromptQuickInfoSessionAction();
			}
			return Mcx;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static EditActionBase RequestIntelliPromptSurroundWithSession
	{
		get
		{
			if (WcG == null)
			{
				WcG = new RequestIntelliPromptSurroundWithSessionAction();
			}
			return WcG;
		}
	}

	public static EditActionBase Replace
	{
		get
		{
			if (mcX == null)
			{
				mcX = new ReplaceAction();
			}
			return mcX;
		}
	}

	public static EditActionBase ResetZoomLevel
	{
		get
		{
			if (lcK == null)
			{
				lcK = new ResetZoomLevelAction();
			}
			return lcK;
		}
	}

	public static EditActionBase ReverseIncrementalSearch
	{
		get
		{
			if (Bcf == null)
			{
				Bcf = new ReverseIncrementalSearchAction();
			}
			return Bcf;
		}
	}

	public static EditActionBase RunMacro
	{
		get
		{
			if (jcD == null)
			{
				jcD = new RunMacroAction();
			}
			return jcD;
		}
	}

	public static EditActionBase ScrollDown
	{
		get
		{
			if (Jcg == null)
			{
				Jcg = new ScrollDownAction();
			}
			return Jcg;
		}
	}

	public static EditActionBase ScrollLeft
	{
		get
		{
			if (VcQ == null)
			{
				VcQ = new ScrollLeftAction();
			}
			return VcQ;
		}
	}

	public static EditActionBase ScrollLineToVisibleBottom
	{
		get
		{
			if (wce == null)
			{
				wce = new ScrollLineToVisibleBottomAction();
			}
			return wce;
		}
	}

	public static EditActionBase ScrollLineToVisibleMiddle
	{
		get
		{
			if (Wcl == null)
			{
				Wcl = new ScrollLineToVisibleMiddleAction();
			}
			return Wcl;
		}
	}

	public static EditActionBase ScrollLineToVisibleTop
	{
		get
		{
			if (pcA == null)
			{
				pcA = new ScrollLineToVisibleTopAction();
			}
			return pcA;
		}
	}

	public static EditActionBase ScrollPageDown
	{
		get
		{
			if (rcv == null)
			{
				rcv = new ScrollPageDownAction();
			}
			return rcv;
		}
	}

	public static EditActionBase ScrollPageUp
	{
		get
		{
			if (acm == null)
			{
				acm = new ScrollPageUpAction();
			}
			return acm;
		}
	}

	public static EditActionBase ScrollRight
	{
		get
		{
			if (RcC == null)
			{
				RcC = new ScrollRightAction();
			}
			return RcC;
		}
	}

	public static EditActionBase ScrollToDocumentEnd
	{
		get
		{
			if (Ncu == null)
			{
				Ncu = new ScrollToDocumentEndAction();
			}
			return Ncu;
		}
	}

	public static EditActionBase ScrollToDocumentStart
	{
		get
		{
			if (tc1 == null)
			{
				tc1 = new ScrollToDocumentStartAction();
			}
			return tc1;
		}
	}

	public static EditActionBase ScrollUp
	{
		get
		{
			if (AcF == null)
			{
				AcF = new ScrollUpAction();
			}
			return AcF;
		}
	}

	public static EditActionBase SelectAll
	{
		get
		{
			if (Ec3 == null)
			{
				Ec3 = new SelectAllAction();
				Ec3.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Control));
			}
			return Ec3;
		}
	}

	public static EditActionBase SelectBlockDown
	{
		get
		{
			if (AcR == null)
			{
				AcR = new SelectBlockDownAction();
			}
			return AcR;
		}
	}

	public static EditActionBase SelectBlockLeft
	{
		get
		{
			if (VcY == null)
			{
				VcY = new SelectBlockLeftAction();
			}
			return VcY;
		}
	}

	public static EditActionBase SelectBlockRight
	{
		get
		{
			if (Scj == null)
			{
				Scj = new SelectBlockRightAction();
			}
			return Scj;
		}
	}

	public static EditActionBase SelectBlockToNextWord
	{
		get
		{
			if (yc4 == null)
			{
				yc4 = new SelectBlockToNextWordAction();
			}
			return yc4;
		}
	}

	public static EditActionBase SelectBlockToPreviousWord
	{
		get
		{
			if (tco == null)
			{
				tco = new SelectBlockToPreviousWordAction();
			}
			return tco;
		}
	}

	public static EditActionBase SelectBlockUp
	{
		get
		{
			if (Kcw == null)
			{
				Kcw = new SelectBlockUpAction();
			}
			return Kcw;
		}
	}

	public static EditActionBase SelectDown
	{
		get
		{
			if (Jc6 == null)
			{
				Jc6 = new SelectDownAction();
			}
			return Jc6;
		}
	}

	public static EditActionBase SelectLeft
	{
		get
		{
			if (dcH == null)
			{
				dcH = new SelectLeftAction();
			}
			return dcH;
		}
	}

	public static EditActionBase SelectPageDown
	{
		get
		{
			if (xcb == null)
			{
				xcb = new SelectPageDownAction();
			}
			return xcb;
		}
	}

	public static EditActionBase SelectPageUp
	{
		get
		{
			if (fcT == null)
			{
				fcT = new SelectPageUpAction();
			}
			return fcT;
		}
	}

	public static EditActionBase SelectRight
	{
		get
		{
			if (UcL == null)
			{
				UcL = new SelectRightAction();
			}
			return UcL;
		}
	}

	public static EditActionBase SelectToDocumentEnd
	{
		get
		{
			if (Ecn == null)
			{
				Ecn = new SelectToDocumentEndAction();
			}
			return Ecn;
		}
	}

	public static EditActionBase SelectToDocumentStart
	{
		get
		{
			if (dc8 == null)
			{
				dc8 = new SelectToDocumentStartAction();
			}
			return dc8;
		}
	}

	public static EditActionBase SelectToLineEnd
	{
		get
		{
			if (TcI == null)
			{
				TcI = new SelectToLineEndAction();
			}
			return TcI;
		}
	}

	public static EditActionBase SelectToLineStart
	{
		get
		{
			if (Uc5 == null)
			{
				Uc5 = new SelectToLineStartAction();
			}
			return Uc5;
		}
	}

	public static EditActionBase SelectToLineStartAfterIndentation
	{
		get
		{
			if (kc0 == null)
			{
				kc0 = new SelectToLineStartAfterIndentationAction();
			}
			return kc0;
		}
	}

	public static EditActionBase SelectToMatchingBracket
	{
		get
		{
			if (hcB == null)
			{
				hcB = new SelectToMatchingBracketAction();
			}
			return hcB;
		}
	}

	public static EditActionBase SelectToNextWord
	{
		get
		{
			if (wcV == null)
			{
				wcV = new SelectToNextWordAction();
			}
			return wcV;
		}
	}

	public static EditActionBase SelectToPreviousWord
	{
		get
		{
			if (ocr == null)
			{
				ocr = new SelectToPreviousWordAction();
			}
			return ocr;
		}
	}

	public static EditActionBase SelectToVisibleBottom
	{
		get
		{
			if (Vcs == null)
			{
				Vcs = new SelectToVisibleBottomAction();
			}
			return Vcs;
		}
	}

	public static EditActionBase SelectToVisibleTop
	{
		get
		{
			if (Ick == null)
			{
				Ick = new SelectToVisibleTopAction();
			}
			return Ick;
		}
	}

	public static EditActionBase SelectUp
	{
		get
		{
			if (ScS == null)
			{
				ScS = new SelectUpAction();
			}
			return ScS;
		}
	}

	public static EditActionBase SelectWord
	{
		get
		{
			if (mc9 == null)
			{
				mc9 = new SelectWordAction();
			}
			return mc9;
		}
	}

	public static EditActionBase StartAutomaticOutlining
	{
		get
		{
			if (Qcy == null)
			{
				Qcy = new StartAutomaticOutliningAction();
			}
			return Qcy;
		}
	}

	public static EditActionBase StopHidingCurrent
	{
		get
		{
			if (Ocq == null)
			{
				Ocq = new StopHidingCurrentAction();
			}
			return Ocq;
		}
	}

	public static EditActionBase StopOutlining
	{
		get
		{
			if (gc2 == null)
			{
				gc2 = new StopOutliningAction();
			}
			return gc2;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tabify")]
	public static EditActionBase TabifySelectedLines
	{
		get
		{
			if (pc7 == null)
			{
				pc7 = new TabifySelectedLinesAction();
			}
			return pc7;
		}
	}

	public static EditActionBase ToggleAllOutliningExpansion
	{
		get
		{
			if (fci == null)
			{
				fci = new ToggleAllOutliningExpansionAction();
			}
			return fci;
		}
	}

	public static EditActionBase ToggleCharacterCasing
	{
		get
		{
			if (Ycp == null)
			{
				Ycp = new ToggleCharacterCasingAction();
			}
			return Ycp;
		}
	}

	public static EditActionBase ToggleMacroRecording
	{
		get
		{
			if (mcM == null)
			{
				mcM = new ToggleMacroRecordingAction();
			}
			return mcM;
		}
	}

	public static EditActionBase ToggleOutliningExpansion
	{
		get
		{
			if (mcO == null)
			{
				mcO = new ToggleOutliningExpansionAction();
			}
			return mcO;
		}
	}

	public static EditActionBase ToggleOverwriteMode
	{
		get
		{
			if (tcU == null)
			{
				tcU = new ToggleOverwriteModeAction();
			}
			return tcU;
		}
	}

	public static EditActionBase TransposeCharacters
	{
		get
		{
			if (ecJ == null)
			{
				ecJ = new TransposeCharactersAction();
			}
			return ecJ;
		}
	}

	public static EditActionBase TransposeLines
	{
		get
		{
			if (xct == null)
			{
				xct = new TransposeLinesAction();
			}
			return xct;
		}
	}

	public static EditActionBase TransposeWords
	{
		get
		{
			if (IcZ == null)
			{
				IcZ = new TransposeWordsAction();
			}
			return IcZ;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static EditActionBase TrimAllTrailingWhitespace
	{
		get
		{
			if (ach == null)
			{
				ach = new TrimAllTrailingWhitespaceAction();
			}
			return ach;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static EditActionBase TrimTrailingWhitespace
	{
		get
		{
			if (TcN == null)
			{
				TcN = new TrimTrailingWhitespaceAction();
			}
			return TcN;
		}
	}

	public static EditActionBase UncommentLines
	{
		get
		{
			if (dcd == null)
			{
				dcd = new UncommentLinesAction();
			}
			return dcd;
		}
	}

	public static EditActionBase Undo
	{
		get
		{
			if (mcz == null)
			{
				mcz = new UndoAction();
			}
			return mcz;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untabify")]
	public static EditActionBase UntabifySelectedLines
	{
		get
		{
			if (gaW == null)
			{
				gaW = new UntabifySelectedLinesAction();
			}
			return gaW;
		}
	}

	public static EditActionBase ZoomIn
	{
		get
		{
			if (KaP == null)
			{
				KaP = new ZoomInAction();
			}
			return KaP;
		}
	}

	public static EditActionBase ZoomOut
	{
		get
		{
			if (faE == null)
			{
				faE = new ZoomOutAction();
			}
			return faE;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public static IEnumerable<IEditAction> GetAll()
	{
		return new IEditAction[131]
		{
			Backspace, BackspaceToPreviousWord, CancelMacroRecording, Capitalize, CodeBlockSelectionContract, CodeBlockSelectionExpand, CollapseSelection, CollapseSelectionLeft, CollapseSelectionRight, CollapseToDefinitions,
			CommentLines, ConvertSpacesToTabs, ConvertTabsToSpaces, CopyAndAppendToClipboard, CopyToClipboard, CutAndAppendToClipboard, CutLineToClipboard, CutToClipboard, Delete, DeleteBlankLines,
			DeleteHorizontalWhitespace, DeleteLine, DeleteToLineEnd, DeleteToLineStart, DeleteToNextWord, Duplicate, Find, FindNext, FindNextSelected, FindPrevious,
			FindPreviousSelected, FormatDocument, FormatSelection, HideSelection, IncrementalSearch, Indent, InsertLineBreak, InsertTabStopOrIndent, MakeUppercase, MakeLowercase,
			MoveDown, MoveLeft, MovePageDown, MovePageUp, MoveRight, MoveSelectedLinesDown, MoveSelectedLinesUp, MoveToDocumentEnd, MoveToDocumentStart, MoveToLineEnd,
			MoveToLineStart, MoveToLineStartAfterIndentation, MoveToMatchingBracket, MoveToNextLineStartAfterIndentation, MoveToNextWord, MoveToPreviousLineStartAfterIndentation, MoveToPreviousWord, MoveToVisibleBottom, MoveToVisibleTop, MoveUp,
			OpenLineAbove, OpenLineBelow, Outdent, PasteFromClipboard, PauseResumeMacroRecording, Redo, RemoveTabStopOrOutdent, RequestIntelliPromptAutoComplete, RequestIntelliPromptCompletionSession, RequestIntelliPromptInsertSnippetSession,
			RequestIntelliPromptParameterInfoSession, RequestIntelliPromptQuickInfoSession, RequestIntelliPromptSurroundWithSession, Replace, ResetZoomLevel, ReverseIncrementalSearch, RunMacro, ScrollDown, ScrollLeft, ScrollLineToVisibleBottom,
			ScrollLineToVisibleMiddle, ScrollLineToVisibleTop, ScrollPageDown, ScrollPageUp, ScrollRight, ScrollToDocumentEnd, ScrollToDocumentStart, ScrollUp, SelectAll, SelectBlockDown,
			SelectBlockLeft, SelectBlockToNextWord, SelectBlockToPreviousWord, SelectBlockRight, SelectBlockUp, SelectDown, SelectLeft, SelectPageDown, SelectPageUp, SelectRight,
			SelectToDocumentEnd, SelectToDocumentStart, SelectToLineEnd, SelectToLineStart, SelectToLineStartAfterIndentation, SelectToMatchingBracket, SelectToNextWord, SelectToPreviousWord, SelectToVisibleBottom, SelectToVisibleTop,
			SelectUp, SelectWord, StartAutomaticOutlining, StopHidingCurrent, StopOutlining, TabifySelectedLines, ToggleAllOutliningExpansion, ToggleCharacterCasing, ToggleMacroRecording, ToggleOutliningExpansion,
			ToggleOverwriteMode, TransposeCharacters, TransposeLines, TransposeWords, TrimAllTrailingWhitespace, TrimTrailingWhitespace, UncommentLines, Undo, UntabifySelectedLines, ZoomIn,
			ZoomOut
		};
	}

	internal static bool oj()
	{
		return zH == null;
	}

	internal static EditorCommands eM()
	{
		return zH;
	}
}
