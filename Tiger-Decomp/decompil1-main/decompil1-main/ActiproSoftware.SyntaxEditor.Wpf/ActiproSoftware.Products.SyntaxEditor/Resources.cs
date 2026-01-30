using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.SyntaxEditor;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager s5N;

	private static CultureInfo u5d;

	internal static Resources UGy;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (s5N == null)
			{
				ResourceManager resourceManager = new ResourceManager("ActiproSoftware.Products.SyntaxEditor.Resources", typeof(Resources).Assembly);
				s5N = resourceManager;
			}
			return s5N;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return u5d;
		}
		set
		{
			u5d = value;
		}
	}

	public static string ExAdornmentManagerConstructorNotFound => ResourceManager.GetString(Q7Z.tqM(202448), u5d);

	public static string ExAdornmentManagerConstructorUnableToLoad => ResourceManager.GetString(Q7Z.tqM(202526), u5d);

	public static string ExEditActionCannotRecord => ResourceManager.GetString(Q7Z.tqM(202612), u5d);

	public static string ExExtensionMustBeSRExtension => ResourceManager.GetString(Q7Z.tqM(202664), u5d);

	public static string ExInvalidCaretWidth => ResourceManager.GetString(Q7Z.tqM(202724), u5d);

	public static string ExInvalidLanguageDefinitionStream => ResourceManager.GetString(Q7Z.tqM(202766), u5d);

	public static string ExInvalidSelectionMode => ResourceManager.GetString(Q7Z.tqM(202836), u5d);

	public static string ExInvalidStringResourceName => ResourceManager.GetString(Q7Z.tqM(202884), u5d);

	public static string ExNoAllTabFilter => ResourceManager.GetString(Q7Z.tqM(202942), u5d);

	public static string ExNoOutliningNodeDefinition => ResourceManager.GetString(Q7Z.tqM(202978), u5d);

	public static string ExNoOutliningSourceDefinitionReturned => ResourceManager.GetString(Q7Z.tqM(203036), u5d);

	public static string ExNoStringResource => ResourceManager.GetString(Q7Z.tqM(203114), u5d);

	public static string ExOneAllTabFilter => ResourceManager.GetString(Q7Z.tqM(203154), u5d);

	public static string ExOutliningSourceConstructorNotFound => ResourceManager.GetString(Q7Z.tqM(203192), u5d);

	public static string ExOutliningSourceConstructorUnableToLoad => ResourceManager.GetString(Q7Z.tqM(203268), u5d);

	public static string ExSessionAlreadyOpen => ResourceManager.GetString(Q7Z.tqM(203352), u5d);

	public static string ExTaggerConstructorNotFound => ResourceManager.GetString(Q7Z.tqM(203396), u5d);

	public static string ExTaggerConstructorUnableToLoad => ResourceManager.GetString(Q7Z.tqM(203454), u5d);

	public static string ExTypeNotFound => ResourceManager.GetString(Q7Z.tqM(203520), u5d);

	public static string ExUnableToRetrieveTextBoundsForOffset => ResourceManager.GetString(Q7Z.tqM(203552), u5d);

	public static string ExValueGreaterThanZero => ResourceManager.GetString(Q7Z.tqM(203630), u5d);

	public static string UIAmbientHighlightingStyleRegistryDescription => ResourceManager.GetString(Q7Z.tqM(203678), u5d);

	public static string UIClassificationTypeBreakpointDisabled => ResourceManager.GetString(Q7Z.tqM(203772), u5d);

	public static string UIClassificationTypeBreakpointEnabled => ResourceManager.GetString(Q7Z.tqM(203852), u5d);

	public static string UIClassificationTypeCodeSnippetDependentField => ResourceManager.GetString(Q7Z.tqM(203930), u5d);

	public static string UIClassificationTypeCodeSnippetField => ResourceManager.GetString(Q7Z.tqM(204024), u5d);

	public static string UIClassificationTypeCollapsedText => ResourceManager.GetString(Q7Z.tqM(204100), u5d);

	public static string UIClassificationTypeCollapsibleRegion => ResourceManager.GetString(Q7Z.tqM(204170), u5d);

	public static string UIClassificationTypeCurrentLine => ResourceManager.GetString(Q7Z.tqM(204248), u5d);

	public static string UIClassificationTypeCurrentStatement => ResourceManager.GetString(Q7Z.tqM(204314), u5d);

	public static string UIClassificationTypeDelimiterMatching => ResourceManager.GetString(Q7Z.tqM(204390), u5d);

	public static string UIClassificationTypeFindMatchHighlight => ResourceManager.GetString(Q7Z.tqM(204468), u5d);

	public static string UIClassificationTypeInactiveSelectedText => ResourceManager.GetString(Q7Z.tqM(204548), u5d);

	public static string UIClassificationTypeIndentationGuides => ResourceManager.GetString(Q7Z.tqM(204632), u5d);

	public static string UIClassificationTypeIndicatorMargin => ResourceManager.GetString(Q7Z.tqM(204710), u5d);

	public static string UIClassificationTypeLineNumbers => ResourceManager.GetString(Q7Z.tqM(204784), u5d);

	public static string UIClassificationTypeOutliningMarginSquare => ResourceManager.GetString(Q7Z.tqM(204850), u5d);

	public static string UIClassificationTypeOutliningMarginVerticalRule => ResourceManager.GetString(Q7Z.tqM(204936), u5d);

	public static string UIClassificationTypePlainText => ResourceManager.GetString(Q7Z.tqM(205034), u5d);

	public static string UIClassificationTypeRevertedChangesMark => ResourceManager.GetString(Q7Z.tqM(205096), u5d);

	public static string UIClassificationTypeSavedChangesMark => ResourceManager.GetString(Q7Z.tqM(205178), u5d);

	public static string UIClassificationTypeSelectedText => ResourceManager.GetString(Q7Z.tqM(205254), u5d);

	public static string UIClassificationTypeUnsavedChangesMark => ResourceManager.GetString(Q7Z.tqM(205322), u5d);

	public static string UIClassificationTypeVisibleWhitespace => ResourceManager.GetString(Q7Z.tqM(205402), u5d);

	public static string UICommandApplyDefaultOutliningExpansionText => ResourceManager.GetString(Q7Z.tqM(205480), u5d);

	public static string UICommandBackspaceText => ResourceManager.GetString(Q7Z.tqM(205570), u5d);

	public static string UICommandBackspaceToPreviousWordText => ResourceManager.GetString(Q7Z.tqM(205618), u5d);

	public static string UICommandCancelMacroRecordingText => ResourceManager.GetString(Q7Z.tqM(205694), u5d);

	public static string UICommandCapitalizeText => ResourceManager.GetString(Q7Z.tqM(205764), u5d);

	public static string UICommandCodeBlockSelectionContractText => ResourceManager.GetString(Q7Z.tqM(205814), u5d);

	public static string UICommandCodeBlockSelectionExpandText => ResourceManager.GetString(Q7Z.tqM(205896), u5d);

	public static string UICommandCollapseSelectionLeftText => ResourceManager.GetString(Q7Z.tqM(205974), u5d);

	public static string UICommandCollapseSelectionRightText => ResourceManager.GetString(Q7Z.tqM(206046), u5d);

	public static string UICommandCollapseSelectionText => ResourceManager.GetString(Q7Z.tqM(206120), u5d);

	public static string UICommandCollapseToDefinitionsText => ResourceManager.GetString(Q7Z.tqM(206184), u5d);

	public static string UICommandCommentLinesText => ResourceManager.GetString(Q7Z.tqM(206256), u5d);

	public static string UICommandConvertSpacesToTabsText => ResourceManager.GetString(Q7Z.tqM(206310), u5d);

	public static string UICommandConvertTabsToSpacesText => ResourceManager.GetString(Q7Z.tqM(206378), u5d);

	public static string UICommandCopyAndAppendToClipboardText => ResourceManager.GetString(Q7Z.tqM(206446), u5d);

	public static string UICommandCopyToClipboardText => ResourceManager.GetString(Q7Z.tqM(206524), u5d);

	public static string UICommandCutAndAppendToClipboardText => ResourceManager.GetString(Q7Z.tqM(206584), u5d);

	public static string UICommandCutLineToClipboardText => ResourceManager.GetString(Q7Z.tqM(206660), u5d);

	public static string UICommandCutToClipboardText => ResourceManager.GetString(Q7Z.tqM(206726), u5d);

	public static string UICommandDeleteBlankLinesText => ResourceManager.GetString(Q7Z.tqM(206784), u5d);

	public static string UICommandDeleteHorizontalWhitespaceText => ResourceManager.GetString(Q7Z.tqM(206846), u5d);

	public static string UICommandDeleteLineText => ResourceManager.GetString(Q7Z.tqM(206928), u5d);

	public static string UICommandDeleteText => ResourceManager.GetString(Q7Z.tqM(206978), u5d);

	public static string UICommandDeleteToLineEndText => ResourceManager.GetString(Q7Z.tqM(207020), u5d);

	public static string UICommandDeleteToLineStartText => ResourceManager.GetString(Q7Z.tqM(207080), u5d);

	public static string UICommandDeleteToNextWordText => ResourceManager.GetString(Q7Z.tqM(207144), u5d);

	public static string UICommandDuplicateText => ResourceManager.GetString(Q7Z.tqM(207206), u5d);

	public static string UICommandExpandAllOutliningText => ResourceManager.GetString(Q7Z.tqM(207254), u5d);

	public static string UICommandFindNextSelectedText => ResourceManager.GetString(Q7Z.tqM(207320), u5d);

	public static string UICommandFindNextText => ResourceManager.GetString(Q7Z.tqM(207382), u5d);

	public static string UICommandFindText => ResourceManager.GetString(Q7Z.tqM(207428), u5d);

	public static string UICommandFormatDocumentText => ResourceManager.GetString(Q7Z.tqM(207466), u5d);

	public static string UICommandFormatSelectionText => ResourceManager.GetString(Q7Z.tqM(207524), u5d);

	public static string UICommandHideSelectionText => ResourceManager.GetString(Q7Z.tqM(207584), u5d);

	public static string UICommandIncrementalSearchText => ResourceManager.GetString(Q7Z.tqM(207640), u5d);

	public static string UICommandIndentText => ResourceManager.GetString(Q7Z.tqM(207704), u5d);

	public static string UICommandInsertLineBreakText => ResourceManager.GetString(Q7Z.tqM(207746), u5d);

	public static string UICommandInsertTabStopOrIndentText => ResourceManager.GetString(Q7Z.tqM(207806), u5d);

	public static string UICommandMacroText => ResourceManager.GetString(Q7Z.tqM(207878), u5d);

	public static string UICommandMakeLowercaseText => ResourceManager.GetString(Q7Z.tqM(207918), u5d);

	public static string UICommandMakeUppercaseText => ResourceManager.GetString(Q7Z.tqM(207974), u5d);

	public static string UICommandMoveDownText => ResourceManager.GetString(Q7Z.tqM(208030), u5d);

	public static string UICommandMoveLeftText => ResourceManager.GetString(Q7Z.tqM(208076), u5d);

	public static string UICommandMovePageDownText => ResourceManager.GetString(Q7Z.tqM(208122), u5d);

	public static string UICommandMovePageUpText => ResourceManager.GetString(Q7Z.tqM(208176), u5d);

	public static string UICommandMoveRightText => ResourceManager.GetString(Q7Z.tqM(208226), u5d);

	public static string UICommandMoveSelectedLinesDownText => ResourceManager.GetString(Q7Z.tqM(208274), u5d);

	public static string UICommandMoveSelectedLinesUpText => ResourceManager.GetString(Q7Z.tqM(208346), u5d);

	public static string UICommandMoveToDocumentEndText => ResourceManager.GetString(Q7Z.tqM(208414), u5d);

	public static string UICommandMoveToDocumentStartText => ResourceManager.GetString(Q7Z.tqM(208478), u5d);

	public static string UICommandMoveToLineEndText => ResourceManager.GetString(Q7Z.tqM(208546), u5d);

	public static string UICommandMoveToLineStartAfterIndentationText => ResourceManager.GetString(Q7Z.tqM(208602), u5d);

	public static string UICommandMoveToLineStartText => ResourceManager.GetString(Q7Z.tqM(208694), u5d);

	public static string UICommandMoveToMatchingBracketText => ResourceManager.GetString(Q7Z.tqM(208754), u5d);

	public static string UICommandMoveToNextLineStartAfterIndentationText => ResourceManager.GetString(Q7Z.tqM(208826), u5d);

	public static string UICommandMoveToNextWordText => ResourceManager.GetString(Q7Z.tqM(208926), u5d);

	public static string UICommandMoveToPreviousLineStartAfterIndentationText => ResourceManager.GetString(Q7Z.tqM(208984), u5d);

	public static string UICommandMoveToPreviousWordText => ResourceManager.GetString(Q7Z.tqM(209092), u5d);

	public static string UICommandMoveToVisibleBottomText => ResourceManager.GetString(Q7Z.tqM(209158), u5d);

	public static string UICommandMoveToVisibleTopText => ResourceManager.GetString(Q7Z.tqM(209226), u5d);

	public static string UICommandMoveUpText => ResourceManager.GetString(Q7Z.tqM(209288), u5d);

	public static string UICommandOpenLineAboveText => ResourceManager.GetString(Q7Z.tqM(209330), u5d);

	public static string UICommandOpenLineBelowText => ResourceManager.GetString(Q7Z.tqM(209386), u5d);

	public static string UICommandOutdentText => ResourceManager.GetString(Q7Z.tqM(209442), u5d);

	public static string UICommandPasteFromClipboardText => ResourceManager.GetString(Q7Z.tqM(209486), u5d);

	public static string UICommandPauseResumeMacroRecordingText => ResourceManager.GetString(Q7Z.tqM(209552), u5d);

	public static string UICommandRedoText => ResourceManager.GetString(Q7Z.tqM(209632), u5d);

	public static string UICommandRemoveTabStopOrOutdentText => ResourceManager.GetString(Q7Z.tqM(209670), u5d);

	public static string UICommandReplaceNextSelectedText => ResourceManager.GetString(Q7Z.tqM(209744), u5d);

	public static string UICommandReplaceNextText => ResourceManager.GetString(Q7Z.tqM(209812), u5d);

	public static string UICommandReplaceText => ResourceManager.GetString(Q7Z.tqM(209864), u5d);

	public static string UICommandRequestIntelliPromptAutoCompleteText => ResourceManager.GetString(Q7Z.tqM(209908), u5d);

	public static string UICommandRequestIntelliPromptCompletionSessionText => ResourceManager.GetString(Q7Z.tqM(210002), u5d);

	public static string UICommandRequestIntelliPromptInsertSnippetSessionText => ResourceManager.GetString(Q7Z.tqM(210106), u5d);

	public static string UICommandRequestIntelliPromptParameterInfoSessionText => ResourceManager.GetString(Q7Z.tqM(210216), u5d);

	public static string UICommandRequestIntelliPromptQuickInfoSessionText => ResourceManager.GetString(Q7Z.tqM(210326), u5d);

	public static string UICommandRequestIntelliPromptSurroundWithSessionText => ResourceManager.GetString(Q7Z.tqM(210428), u5d);

	public static string UICommandResetZoomLevelText => ResourceManager.GetString(Q7Z.tqM(210536), u5d);

	public static string UICommandReverseIncrementalSearchText => ResourceManager.GetString(Q7Z.tqM(210594), u5d);

	public static string UICommandRunMacroText => ResourceManager.GetString(Q7Z.tqM(210672), u5d);

	public static string UICommandScrollDownText => ResourceManager.GetString(Q7Z.tqM(210718), u5d);

	public static string UICommandScrollLeftText => ResourceManager.GetString(Q7Z.tqM(210768), u5d);

	public static string UICommandScrollLineToVisibleBottomText => ResourceManager.GetString(Q7Z.tqM(210818), u5d);

	public static string UICommandScrollLineToVisibleMiddleText => ResourceManager.GetString(Q7Z.tqM(210898), u5d);

	public static string UICommandScrollLineToVisibleTopText => ResourceManager.GetString(Q7Z.tqM(210978), u5d);

	public static string UICommandScrollPageDownText => ResourceManager.GetString(Q7Z.tqM(211052), u5d);

	public static string UICommandScrollPageUpText => ResourceManager.GetString(Q7Z.tqM(211110), u5d);

	public static string UICommandScrollRightText => ResourceManager.GetString(Q7Z.tqM(211164), u5d);

	public static string UICommandScrollToDocumentEndText => ResourceManager.GetString(Q7Z.tqM(211216), u5d);

	public static string UICommandScrollToDocumentStartText => ResourceManager.GetString(Q7Z.tqM(211284), u5d);

	public static string UICommandScrollUpText => ResourceManager.GetString(Q7Z.tqM(211356), u5d);

	public static string UICommandSelectAllText => ResourceManager.GetString(Q7Z.tqM(211402), u5d);

	public static string UICommandSelectBlockDownText => ResourceManager.GetString(Q7Z.tqM(211450), u5d);

	public static string UICommandSelectBlockLeftText => ResourceManager.GetString(Q7Z.tqM(211510), u5d);

	public static string UICommandSelectBlockRightText => ResourceManager.GetString(Q7Z.tqM(211570), u5d);

	public static string UICommandSelectBlockToNextWordText => ResourceManager.GetString(Q7Z.tqM(211632), u5d);

	public static string UICommandSelectBlockToPreviousWordText => ResourceManager.GetString(Q7Z.tqM(211704), u5d);

	public static string UICommandSelectBlockUpText => ResourceManager.GetString(Q7Z.tqM(211784), u5d);

	public static string UICommandSelectDownText => ResourceManager.GetString(Q7Z.tqM(211840), u5d);

	public static string UICommandSelectLeftText => ResourceManager.GetString(Q7Z.tqM(211890), u5d);

	public static string UICommandSelectPageDownText => ResourceManager.GetString(Q7Z.tqM(211940), u5d);

	public static string UICommandSelectPageUpText => ResourceManager.GetString(Q7Z.tqM(211998), u5d);

	public static string UICommandSelectRightText => ResourceManager.GetString(Q7Z.tqM(212052), u5d);

	public static string UICommandSelectToDocumentEndText => ResourceManager.GetString(Q7Z.tqM(212104), u5d);

	public static string UICommandSelectToDocumentStartText => ResourceManager.GetString(Q7Z.tqM(212172), u5d);

	public static string UICommandSelectToLineEndText => ResourceManager.GetString(Q7Z.tqM(212244), u5d);

	public static string UICommandSelectToLineStartAfterIndentationText => ResourceManager.GetString(Q7Z.tqM(212304), u5d);

	public static string UICommandSelectToLineStartText => ResourceManager.GetString(Q7Z.tqM(212400), u5d);

	public static string UICommandSelectToMatchingBracketText => ResourceManager.GetString(Q7Z.tqM(212464), u5d);

	public static string UICommandSelectToNextWordText => ResourceManager.GetString(Q7Z.tqM(212540), u5d);

	public static string UICommandSelectToPreviousWordText => ResourceManager.GetString(Q7Z.tqM(212602), u5d);

	public static string UICommandSelectToVisibleBottomText => ResourceManager.GetString(Q7Z.tqM(212672), u5d);

	public static string UICommandSelectToVisibleTopText => ResourceManager.GetString(Q7Z.tqM(212744), u5d);

	public static string UICommandSelectUpText => ResourceManager.GetString(Q7Z.tqM(212810), u5d);

	public static string UICommandSelectWordText => ResourceManager.GetString(Q7Z.tqM(212856), u5d);

	public static string UICommandStartAutomaticOutliningText => ResourceManager.GetString(Q7Z.tqM(212906), u5d);

	public static string UICommandStopHidingCurrentText => ResourceManager.GetString(Q7Z.tqM(212982), u5d);

	public static string UICommandStopOutliningText => ResourceManager.GetString(Q7Z.tqM(213046), u5d);

	public static string UICommandTabifySelectedLinesText => ResourceManager.GetString(Q7Z.tqM(213102), u5d);

	public static string UICommandToggleAllOutliningExpansionText => ResourceManager.GetString(Q7Z.tqM(213170), u5d);

	public static string UICommandToggleCharacterCasingText => ResourceManager.GetString(Q7Z.tqM(213254), u5d);

	public static string UICommandToggleMacroRecordingText => ResourceManager.GetString(Q7Z.tqM(213326), u5d);

	public static string UICommandToggleOutliningExpansionText => ResourceManager.GetString(Q7Z.tqM(213396), u5d);

	public static string UICommandToggleOverwriteModeText => ResourceManager.GetString(Q7Z.tqM(213474), u5d);

	public static string UICommandTransposeCharactersText => ResourceManager.GetString(Q7Z.tqM(213542), u5d);

	public static string UICommandTransposeLinesText => ResourceManager.GetString(Q7Z.tqM(213610), u5d);

	public static string UICommandTransposeWordsText => ResourceManager.GetString(Q7Z.tqM(213668), u5d);

	public static string UICommandTrimAllTrailingWhitespaceText => ResourceManager.GetString(Q7Z.tqM(213726), u5d);

	public static string UICommandTrimTrailingWhitespaceText => ResourceManager.GetString(Q7Z.tqM(213806), u5d);

	public static string UICommandUncommentLinesText => ResourceManager.GetString(Q7Z.tqM(213880), u5d);

	public static string UICommandUndoText => ResourceManager.GetString(Q7Z.tqM(213938), u5d);

	public static string UICommandUntabifySelectedLinesText => ResourceManager.GetString(Q7Z.tqM(213976), u5d);

	public static string UICommandZoomInText => ResourceManager.GetString(Q7Z.tqM(214048), u5d);

	public static string UICommandZoomOutText => ResourceManager.GetString(Q7Z.tqM(214090), u5d);

	public static string UIEditorSearchScopeDocumentText => ResourceManager.GetString(Q7Z.tqM(214134), u5d);

	public static string UIEditorSearchScopeSelectionText => ResourceManager.GetString(Q7Z.tqM(214200), u5d);

	public static string UIEditorSearchViewFindAllButtonText => ResourceManager.GetString(Q7Z.tqM(214268), u5d);

	public static string UIEditorSearchViewFindModeText => ResourceManager.GetString(Q7Z.tqM(214342), u5d);

	public static string UIEditorSearchViewFindNextButtonText => ResourceManager.GetString(Q7Z.tqM(214406), u5d);

	public static string UIEditorSearchViewFindOptionsExpanderHeaderText => ResourceManager.GetString(Q7Z.tqM(214482), u5d);

	public static string UIEditorSearchViewFindWhatLabelText => ResourceManager.GetString(Q7Z.tqM(214580), u5d);

	public static string UIEditorSearchViewMatchCaseCheckBoxText => ResourceManager.GetString(Q7Z.tqM(214654), u5d);

	public static string UIEditorSearchViewMatchWholeWordCheckBoxText => ResourceManager.GetString(Q7Z.tqM(214736), u5d);

	public static string UIEditorSearchViewReplaceAllButtonText => ResourceManager.GetString(Q7Z.tqM(214828), u5d);

	public static string UIEditorSearchViewReplaceModeText => ResourceManager.GetString(Q7Z.tqM(214908), u5d);

	public static string UIEditorSearchViewReplaceNextButtonText => ResourceManager.GetString(Q7Z.tqM(214978), u5d);

	public static string UIEditorSearchViewReplaceWithLabelText => ResourceManager.GetString(Q7Z.tqM(215060), u5d);

	public static string UIEditorSearchViewSearchHiddenTextCheckBoxText => ResourceManager.GetString(Q7Z.tqM(215140), u5d);

	public static string UIEditorSearchViewSearchScopeLabelText => ResourceManager.GetString(Q7Z.tqM(215236), u5d);

	public static string UIEditorSearchViewSearchTypeLabelText => ResourceManager.GetString(Q7Z.tqM(215316), u5d);

	public static string UIEditorSearchViewSearchUpCheckBoxText => ResourceManager.GetString(Q7Z.tqM(215394), u5d);

	public static string UIIntelliPromptCodeSnippetSelectorInsertSnippetText => ResourceManager.GetString(Q7Z.tqM(215474), u5d);

	public static string UIIntelliPromptCodeSnippetSelectorSurroundWithText => ResourceManager.GetString(Q7Z.tqM(215580), u5d);

	public static string UIIntelliPromptCompletionListNoItemsText => ResourceManager.GetString(Q7Z.tqM(215684), u5d);

	public static string UIIntelliPromptPopupContentCodeSnippetShortcutPrefix => ResourceManager.GetString(Q7Z.tqM(215768), u5d);

	public static string UIKeyAddText => ResourceManager.GetString(Q7Z.tqM(215876), u5d);

	public static string UIKeyBackText => ResourceManager.GetString(Q7Z.tqM(215904), u5d);

	public static string UIKeyD0Text => ResourceManager.GetString(Q7Z.tqM(215934), u5d);

	public static string UIKeyD1Text => ResourceManager.GetString(Q7Z.tqM(215960), u5d);

	public static string UIKeyD2Text => ResourceManager.GetString(Q7Z.tqM(215986), u5d);

	public static string UIKeyD3Text => ResourceManager.GetString(Q7Z.tqM(216012), u5d);

	public static string UIKeyD4Text => ResourceManager.GetString(Q7Z.tqM(216038), u5d);

	public static string UIKeyD5Text => ResourceManager.GetString(Q7Z.tqM(216064), u5d);

	public static string UIKeyD6Text => ResourceManager.GetString(Q7Z.tqM(216090), u5d);

	public static string UIKeyD7Text => ResourceManager.GetString(Q7Z.tqM(216116), u5d);

	public static string UIKeyD8Text => ResourceManager.GetString(Q7Z.tqM(216142), u5d);

	public static string UIKeyD9Text => ResourceManager.GetString(Q7Z.tqM(216168), u5d);

	public static string UIKeyDecimalText => ResourceManager.GetString(Q7Z.tqM(216194), u5d);

	public static string UIKeyDeleteText => ResourceManager.GetString(Q7Z.tqM(216230), u5d);

	public static string UIKeyDivideText => ResourceManager.GetString(Q7Z.tqM(216264), u5d);

	public static string UIKeyDownText => ResourceManager.GetString(Q7Z.tqM(216298), u5d);

	public static string UIKeyEscapeText => ResourceManager.GetString(Q7Z.tqM(216328), u5d);

	public static string UIKeyInsertText => ResourceManager.GetString(Q7Z.tqM(216362), u5d);

	public static string UIKeyLeftText => ResourceManager.GetString(Q7Z.tqM(216396), u5d);

	public static string UIKeyLWinText => ResourceManager.GetString(Q7Z.tqM(216426), u5d);

	public static string UIKeyMultiplyText => ResourceManager.GetString(Q7Z.tqM(216456), u5d);

	public static string UIKeyNumPad0Text => ResourceManager.GetString(Q7Z.tqM(216494), u5d);

	public static string UIKeyNumPad1Text => ResourceManager.GetString(Q7Z.tqM(216530), u5d);

	public static string UIKeyNumPad2Text => ResourceManager.GetString(Q7Z.tqM(216566), u5d);

	public static string UIKeyNumPad3Text => ResourceManager.GetString(Q7Z.tqM(216602), u5d);

	public static string UIKeyNumPad4Text => ResourceManager.GetString(Q7Z.tqM(216638), u5d);

	public static string UIKeyNumPad5Text => ResourceManager.GetString(Q7Z.tqM(216674), u5d);

	public static string UIKeyNumPad6Text => ResourceManager.GetString(Q7Z.tqM(216710), u5d);

	public static string UIKeyNumPad7Text => ResourceManager.GetString(Q7Z.tqM(216746), u5d);

	public static string UIKeyNumPad8Text => ResourceManager.GetString(Q7Z.tqM(216782), u5d);

	public static string UIKeyNumPad9Text => ResourceManager.GetString(Q7Z.tqM(216818), u5d);

	public static string UIKeyOemCloseBracketsText => ResourceManager.GetString(Q7Z.tqM(216854), u5d);

	public static string UIKeyOemCommaText => ResourceManager.GetString(Q7Z.tqM(216908), u5d);

	public static string UIKeyOemMinusText => ResourceManager.GetString(Q7Z.tqM(216946), u5d);

	public static string UIKeyOemOpenBracketsText => ResourceManager.GetString(Q7Z.tqM(216984), u5d);

	public static string UIKeyOemPeriodText => ResourceManager.GetString(Q7Z.tqM(217036), u5d);

	public static string UIKeyOemPipeText => ResourceManager.GetString(Q7Z.tqM(217076), u5d);

	public static string UIKeyOemPlusText => ResourceManager.GetString(Q7Z.tqM(217112), u5d);

	public static string UIKeyOemQuestionText => ResourceManager.GetString(Q7Z.tqM(217148), u5d);

	public static string UIKeyOemQuotesText => ResourceManager.GetString(Q7Z.tqM(217192), u5d);

	public static string UIKeyOemSemicolonText => ResourceManager.GetString(Q7Z.tqM(217232), u5d);

	public static string UIKeyOemTildeText => ResourceManager.GetString(Q7Z.tqM(217278), u5d);

	public static string UIKeyPageDownText => ResourceManager.GetString(Q7Z.tqM(217316), u5d);

	public static string UIKeyPageUpText => ResourceManager.GetString(Q7Z.tqM(217354), u5d);

	public static string UIKeyPauseText => ResourceManager.GetString(Q7Z.tqM(217388), u5d);

	public static string UIKeyReturnText => ResourceManager.GetString(Q7Z.tqM(217420), u5d);

	public static string UIKeyRightText => ResourceManager.GetString(Q7Z.tqM(217454), u5d);

	public static string UIKeyRWinText => ResourceManager.GetString(Q7Z.tqM(217486), u5d);

	public static string UIKeySubtractText => ResourceManager.GetString(Q7Z.tqM(217516), u5d);

	public static string UIKeyUpText => ResourceManager.GetString(Q7Z.tqM(217554), u5d);

	public static string UIMenuItemCopyText => ResourceManager.GetString(Q7Z.tqM(217580), u5d);

	public static string UIMenuItemCutText => ResourceManager.GetString(Q7Z.tqM(217620), u5d);

	public static string UIMenuItemDeleteText => ResourceManager.GetString(Q7Z.tqM(217658), u5d);

	public static string UIMenuItemPasteText => ResourceManager.GetString(Q7Z.tqM(217702), u5d);

	public static string UIMenuItemRedoText => ResourceManager.GetString(Q7Z.tqM(217744), u5d);

	public static string UIMenuItemSelectAllText => ResourceManager.GetString(Q7Z.tqM(217784), u5d);

	public static string UIMenuItemUndoText => ResourceManager.GetString(Q7Z.tqM(217834), u5d);

	public static string UIModifierKeysAltText => ResourceManager.GetString(Q7Z.tqM(217874), u5d);

	public static string UIModifierKeysControlText => ResourceManager.GetString(Q7Z.tqM(217920), u5d);

	public static string UIModifierKeysDelimiterText => ResourceManager.GetString(Q7Z.tqM(217974), u5d);

	public static string UIModifierKeysShiftText => ResourceManager.GetString(Q7Z.tqM(218032), u5d);

	public static string UIPrinterPageNumberAndCountText => ResourceManager.GetString(Q7Z.tqM(218082), u5d);

	public static string UIPrinterPageNumberText => ResourceManager.GetString(Q7Z.tqM(218148), u5d);

	public static string UIPrintPreviewWindowTitle => ResourceManager.GetString(Q7Z.tqM(218198), u5d);

	public static string UISearchOverlayPaneCloseButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218252), u5d);

	public static string UISearchOverlayPaneFindAllButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218330), u5d);

	public static string UISearchOverlayPaneFindNextButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218412), u5d);

	public static string UISearchOverlayPaneFindWhatTextBoxPlaceholderText => ResourceManager.GetString(Q7Z.tqM(218496), u5d);

	public static string UISearchOverlayPaneMatchCaseButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218598), u5d);

	public static string UISearchOverlayPaneMatchWholeWordButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218684), u5d);

	public static string UISearchOverlayPaneReplaceAllButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218780), u5d);

	public static string UISearchOverlayPaneReplaceNextButtonToolTip => ResourceManager.GetString(Q7Z.tqM(218868), u5d);

	public static string UISearchOverlayPaneReplaceWithTextBoxPlaceholderText => ResourceManager.GetString(Q7Z.tqM(218958), u5d);

	public static string UISearchOverlayPaneSearchUpButtonToolTip => ResourceManager.GetString(Q7Z.tqM(219066), u5d);

	public static string UISearchOverlayPaneToggleReplaceButtonToolTip => ResourceManager.GetString(Q7Z.tqM(219150), u5d);

	public static string UISearchOverlayPaneUseRegularExpressionsButtonToolTip => ResourceManager.GetString(Q7Z.tqM(219244), u5d);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool aGh()
	{
		return UGy == null;
	}

	internal static Resources PG6()
	{
		return UGy;
	}
}
