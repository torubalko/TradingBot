using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[ContentProperty("Document")]
[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
[TemplatePart(Name = "PART_EditorViewHost", Type = typeof(EditorViewHost))]
public class SyntaxEditor : Control
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public IEditorDocument G0r;

		private static _003C_003Ec__DisplayClass57_0 RNa;

		public _003C_003Ec__DisplayClass57_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void n0L(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			G0r.IsModifiedChanged -= weakEventListener.OnEvent;
		}

		internal void Q0n(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			G0r.IsReadOnlyChanged -= weakEventListener.OnEvent;
		}

		internal void i08(WeakEventListener<SyntaxEditor, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			G0r.LanguageChanged -= weakEventListener.OnEvent;
		}

		internal void g0I(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			G0r.ParseDataChanged -= weakEventListener.OnEvent;
		}

		internal void b05(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			G0r.TabSizeChanged -= weakEventListener.OnEvent;
		}

		internal void D00(WeakEventListener<SyntaxEditor, TextSnapshotChangedEventArgs> weakEventListener)
		{
			G0r.RemoveTextChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		}

		internal void c0B(WeakEventListener<SyntaxEditor, TextSnapshotChangingEventArgs> weakEventListener)
		{
			G0r.RemoveTextChangingEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		}

		internal void v0V(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			G0r.UndoHistory.Cleared -= weakEventListener.OnEvent;
		}

		internal static bool iNL()
		{
			return RNa == null;
		}

		internal static _003C_003Ec__DisplayClass57_0 fNg()
		{
			return RNa;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass631_0
	{
		public IHighlightingStyleRegistry QBE;

		internal static _003C_003Ec__DisplayClass631_0 FNS;

		public _003C_003Ec__DisplayClass631_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void kBP(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			QBE.Changed -= weakEventListener.OnEvent;
		}

		internal static bool SNk()
		{
			return FNS == null;
		}

		internal static _003C_003Ec__DisplayClass631_0 hNZ()
		{
			return FNS;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass638_0
	{
		public SyntaxEditor yBa;

		public int sBx;

		private static _003C_003Ec__DisplayClass638_0 MNF;

		public _003C_003Ec__DisplayClass638_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void EBc(object o)
		{
			if (yBa.fXc != sBx)
			{
				return;
			}
			foreach (EditorView item in yBa.mG5())
			{
				item.PAl();
			}
			yBa.SGx((vTP)8);
		}

		internal static bool IN9()
		{
			return MNF == null;
		}

		internal static _003C_003Ec__DisplayClass638_0 zNJ()
		{
			return MNF;
		}
	}

	private zTB UGs;

	private tTD LGk;

	private zTL wGS;

	private gTU zG9;

	private nK hGy;

	private IMacroRecording oGq;

	private DT2 bG2;

	private VAy zG7;

	private BTZ EGi;

	private EditorViewHost fGp;

	private uTb lGM;

	internal AssemblyLicenseType jGO;

	private WeakEventListener<SyntaxEditor, EventArgs> xGU;

	private WeakEventListener<SyntaxEditor, EventArgs> EGJ;

	private WeakEventListener<SyntaxEditor, SyntaxLanguageChangedEventArgs> bGt;

	private WeakEventListener<SyntaxEditor, EventArgs> uGZ;

	private WeakEventListener<SyntaxEditor, EventArgs> OGh;

	private WeakEventListener<SyntaxEditor, TextSnapshotChangedEventArgs> SGN;

	private WeakEventListener<SyntaxEditor, TextSnapshotChangingEventArgs> RGd;

	private WeakEventListener<SyntaxEditor, EventArgs> lGz;

	public static readonly RoutedEvent ActiveViewChangedEvent;

	public static readonly RoutedEvent CutCopyDragEvent;

	public static readonly RoutedEvent DocumentChangedEvent;

	public static readonly RoutedEvent DocumentIsModifiedChangedEvent;

	public static readonly RoutedEvent DocumentIsReadOnlyChangedEvent;

	public static readonly RoutedEvent DocumentLanguageChangedEvent;

	public static readonly RoutedEvent DocumentParseDataChangedEvent;

	public static readonly RoutedEvent DocumentTextChangedEvent;

	public static readonly RoutedEvent DocumentTextChangingEvent;

	public static readonly RoutedEvent IsOverwriteModeActiveChangedEvent;

	public static readonly RoutedEvent MacroRecordingStateChangedEvent;

	public static readonly RoutedEvent MenuRequestedEvent;

	public static readonly RoutedEvent OverlayPaneClosedEvent;

	public static readonly RoutedEvent OverlayPaneOpenedEvent;

	public static readonly RoutedEvent PasteDragDropEvent;

	public static readonly RoutedEvent UserInterfaceUpdateEvent;

	public static readonly RoutedEvent ViewActionExecutingEvent;

	public static readonly RoutedEvent ViewClosedEvent;

	public static readonly RoutedEvent ViewIsIncrementalSearchActiveChangedEvent;

	public static readonly RoutedEvent ViewOpenedEvent;

	public static readonly RoutedEvent ViewSearchEvent;

	public static readonly RoutedEvent ViewSelectionChangedEvent;

	public static readonly RoutedEvent ViewSplitAddedEvent;

	public static readonly RoutedEvent ViewSplitMovedEvent;

	public static readonly RoutedEvent ViewSplitRemovedEvent;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static EventHandler<oAA> xXW;

	public static readonly DependencyProperty AcceptsTabProperty;

	public static readonly DependencyProperty ActiveViewProperty;

	public static readonly DependencyProperty AllowDragProperty;

	public static readonly DependencyProperty AreIndentationGuidesVisibleProperty;

	public static readonly DependencyProperty AreLineModificationMarksVisibleProperty;

	public static readonly DependencyProperty AreMultipleSelectionRangesEnabledProperty;

	public static readonly DependencyProperty AreSelectionGrippersEnabledProperty;

	public static readonly DependencyProperty AreWordWrapGlyphsVisibleProperty;

	public static readonly DependencyProperty CanBackspaceOverSpacesToTabStopProperty;

	public static readonly DependencyProperty CanCutCopyBlankLineWhenNoSelectionProperty;

	public static readonly DependencyProperty CanCutCopyDragWithHtmlProperty;

	public static readonly DependencyProperty CanCutCopyDragWithRtfProperty;

	public static readonly DependencyProperty CanIncrementalSearchTrimUnmatchedFindTextProperty;

	public static readonly DependencyProperty CanMoveCaretForSecondaryPointerButtonProperty;

	public static readonly DependencyProperty CanMoveCaretToNextLineAtLineEndProperty;

	public static readonly DependencyProperty CanMoveCaretToPreviousLineAtLineStartProperty;

	public static readonly DependencyProperty CanScrollPastDocumentEndProperty;

	public static readonly DependencyProperty CanSplitHorizontallyProperty;

	public static readonly DependencyProperty CaretBlinkIntervalProperty;

	public static readonly DependencyProperty CaretBrushProperty;

	public static readonly DependencyProperty CaretInsertKindProperty;

	public static readonly DependencyProperty CaretInsertWidthProperty;

	public static readonly DependencyProperty CaretOverwriteKindProperty;

	public static readonly DependencyProperty CaretOverwriteWidthProperty;

	public static readonly DependencyProperty DocumentProperty;

	public static readonly DependencyProperty HasHorizontalSplitProperty;

	public static readonly DependencyProperty HasSearchOverlayPaneKeyBindingsProperty;

	public static readonly DependencyProperty HighlightingStyleRegistryProperty;

	public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;

	public static readonly DependencyProperty HorizontalSplitPercentageProperty;

	public static readonly DependencyProperty InactiveSelectedTextBackgroundProperty;

	public static readonly DependencyProperty IndicatorMarginBackgroundProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrect")]
	public static readonly DependencyProperty IsAutoCorrectEnabledProperty;

	public static readonly DependencyProperty IsCollapsibleRegionHighlightingEnabledProperty;

	public static readonly DependencyProperty IsCurrentLineHighlightingEnabledProperty;

	public static readonly DependencyProperty IsDefaultContextMenuEnabledProperty;

	public static readonly DependencyProperty IsDelimiterAutoCompleteEnabledProperty;

	public static readonly DependencyProperty IsDelimiterHighlightingEnabledProperty;

	public static readonly DependencyProperty IsDocumentReadOnlyProperty;

	public static readonly DependencyProperty IsDragDropTextReselectEnabledProperty;

	public static readonly DependencyProperty IsImeEnabledProperty;

	public static readonly DependencyProperty IsIndicatorMarginVisibleProperty;

	public static readonly DependencyProperty IsLineNumberMarginVisibleProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine")]
	public static readonly DependencyProperty IsMultiLineProperty;

	public static readonly DependencyProperty IsOutliningMarginVisibleProperty;

	public static readonly DependencyProperty IsOverwriteModeActiveProperty;

	public static readonly DependencyProperty IsRulerMarginVisibleProperty;

	public static readonly DependencyProperty IsSearchResultHighlightingEnabledProperty;

	public static readonly DependencyProperty IsSelectionMarginVisibleProperty;

	public static readonly DependencyProperty IsTextDataBindingEnabledProperty;

	public static readonly DependencyProperty IsViewLineMeasureEnabledProperty;

	internal static readonly DependencyProperty oXP;

	public static readonly DependencyProperty IsVirtualSpaceAtLineEndEnabledProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static readonly DependencyProperty IsWhitespaceVisibleProperty;

	public static readonly DependencyProperty IsWordWrapEnabledProperty;

	public static readonly DependencyProperty IsWordWrapGlyphMarginVisibleProperty;

	public static readonly DependencyProperty LineNumberMarginBackgroundProperty;

	public static readonly DependencyProperty LineNumberMarginFontFamilyProperty;

	public static readonly DependencyProperty LineNumberMarginFontSizeProperty;

	public static readonly DependencyProperty LineNumberMarginForegroundProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static readonly DependencyProperty MaxIntelliPromptZoomLevelProperty;

	public static readonly DependencyProperty MaxZoomLevelProperty;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public static readonly DependencyProperty MinIntelliPromptZoomLevelProperty;

	public static readonly DependencyProperty MinZoomLevelProperty;

	public static readonly DependencyProperty OutliningMarginBackgroundProperty;

	public static readonly DependencyProperty PrintSettingsProperty;

	public static readonly DependencyProperty RulerMarginBackgroundProperty;

	public static readonly DependencyProperty RulerMarginForegroundProperty;

	public static readonly DependencyProperty ScrollBarAccelerationIntervalProperty;

	public static readonly DependencyProperty ScrollBarAccelerationMaximumProperty;

	public static readonly DependencyProperty ScrollBarTrayBottomTemplateProperty;

	public static readonly DependencyProperty ScrollBarTrayLeftTemplateProperty;

	public static readonly DependencyProperty ScrollBarTrayRightTemplateProperty;

	public static readonly DependencyProperty ScrollBarTrayTopTemplateProperty;

	public static readonly DependencyProperty ScrollToCaretOnSelectAllProperty;

	public static readonly DependencyProperty SearchOptionsProperty;

	public static readonly DependencyProperty SelectedTextBackgroundProperty;

	public static readonly DependencyProperty SelectionCollapsesOnCopyProperty;

	public static readonly DependencyProperty SelectionCollapsesToAnchorProperty;

	public static readonly DependencyProperty SelectionMarginBackgroundProperty;

	public static readonly DependencyProperty SelectionModesAllowedProperty;

	public static readonly DependencyProperty TextProperty;

	public static readonly DependencyProperty TextAreaFontSizeProperty;

	public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public static readonly DependencyProperty VisibleWhitespaceForegroundProperty;

	public static readonly DependencyProperty WordWrapGlyphMarginBackgroundProperty;

	public static readonly DependencyProperty WordWrapGlyphMarginForegroundProperty;

	public static readonly DependencyProperty WordWrapModeProperty;

	public static readonly DependencyProperty ZoomAnimationDurationProperty;

	public static readonly DependencyProperty ZoomLevelAnimatedProperty;

	public static readonly DependencyProperty ZoomLevelProperty;

	public static readonly DependencyProperty ZoomLevelIncrementProperty;

	public static readonly DependencyProperty ZoomModesAllowedProperty;

	private WeakEventListener<SyntaxEditor, EventArgs> NXE;

	private int fXc;

	private EditorViewMarginFactoryCollection UXa;

	private IEditorDocument FXx;

	private PrintTicket SXG;

	private static SyntaxEditor aDn;

	internal tTD ElementTransparencyManager => LGk;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public IIntelliPromptManager IntelliPrompt => hGy;

	public IMacroRecording MacroRecording => oGq;

	public bool AcceptsTab
	{
		get
		{
			return (bool)GetValue(AcceptsTabProperty);
		}
		set
		{
			SetValue(AcceptsTabProperty, value);
		}
	}

	public IEditorView ActiveView
	{
		get
		{
			return (IEditorView)GetValue(ActiveViewProperty);
		}
		internal set
		{
			SetValue(ActiveViewProperty, value);
		}
	}

	public bool AllowDrag
	{
		get
		{
			return (bool)GetValue(AllowDragProperty);
		}
		set
		{
			SetValue(AllowDragProperty, value);
		}
	}

	public bool AreIndentationGuidesVisible
	{
		get
		{
			return (bool)GetValue(AreIndentationGuidesVisibleProperty);
		}
		set
		{
			SetValue(AreIndentationGuidesVisibleProperty, value);
		}
	}

	public bool AreLineModificationMarksVisible
	{
		get
		{
			return (bool)GetValue(AreLineModificationMarksVisibleProperty);
		}
		set
		{
			SetValue(AreLineModificationMarksVisibleProperty, value);
		}
	}

	public bool AreMultipleSelectionRangesEnabled
	{
		get
		{
			return (bool)GetValue(AreMultipleSelectionRangesEnabledProperty);
		}
		set
		{
			SetValue(AreMultipleSelectionRangesEnabledProperty, value);
		}
	}

	public bool AreSelectionGrippersEnabled
	{
		get
		{
			return (bool)GetValue(AreSelectionGrippersEnabledProperty);
		}
		set
		{
			SetValue(AreSelectionGrippersEnabledProperty, value);
		}
	}

	public bool AreWordWrapGlyphsVisible
	{
		get
		{
			return (bool)GetValue(AreWordWrapGlyphsVisibleProperty);
		}
		set
		{
			SetValue(AreWordWrapGlyphsVisibleProperty, value);
		}
	}

	public bool CanBackspaceOverSpacesToTabStop
	{
		get
		{
			return (bool)GetValue(CanBackspaceOverSpacesToTabStopProperty);
		}
		set
		{
			SetValue(CanBackspaceOverSpacesToTabStopProperty, value);
		}
	}

	public bool CanCutCopyBlankLineWhenNoSelection
	{
		get
		{
			return (bool)GetValue(CanCutCopyBlankLineWhenNoSelectionProperty);
		}
		set
		{
			SetValue(CanCutCopyBlankLineWhenNoSelectionProperty, value);
		}
	}

	public bool CanCutCopyDragWithHtml
	{
		get
		{
			return (bool)GetValue(CanCutCopyDragWithHtmlProperty);
		}
		set
		{
			SetValue(CanCutCopyDragWithHtmlProperty, value);
		}
	}

	public bool CanCutCopyDragWithRtf
	{
		get
		{
			return (bool)GetValue(CanCutCopyDragWithRtfProperty);
		}
		set
		{
			SetValue(CanCutCopyDragWithRtfProperty, value);
		}
	}

	public bool CanIncrementalSearchTrimUnmatchedFindText
	{
		get
		{
			return (bool)GetValue(CanIncrementalSearchTrimUnmatchedFindTextProperty);
		}
		set
		{
			SetValue(CanIncrementalSearchTrimUnmatchedFindTextProperty, value);
		}
	}

	public bool CanMoveCaretForSecondaryPointerButton
	{
		get
		{
			return (bool)GetValue(CanMoveCaretForSecondaryPointerButtonProperty);
		}
		set
		{
			SetValue(CanMoveCaretForSecondaryPointerButtonProperty, value);
		}
	}

	public bool CanMoveCaretToNextLineAtLineEnd
	{
		get
		{
			return (bool)GetValue(CanMoveCaretToNextLineAtLineEndProperty);
		}
		set
		{
			SetValue(CanMoveCaretToNextLineAtLineEndProperty, value);
		}
	}

	public bool CanMoveCaretToPreviousLineAtLineStart
	{
		get
		{
			return (bool)GetValue(CanMoveCaretToPreviousLineAtLineStartProperty);
		}
		set
		{
			SetValue(CanMoveCaretToPreviousLineAtLineStartProperty, value);
		}
	}

	public bool CanScrollPastDocumentEnd
	{
		get
		{
			return (bool)GetValue(CanScrollPastDocumentEndProperty);
		}
		set
		{
			SetValue(CanScrollPastDocumentEndProperty, value);
		}
	}

	public bool CanSplitHorizontally
	{
		get
		{
			return (bool)GetValue(CanSplitHorizontallyProperty);
		}
		set
		{
			SetValue(CanSplitHorizontallyProperty, value);
		}
	}

	public int CaretBlinkInterval
	{
		get
		{
			return (int)GetValue(CaretBlinkIntervalProperty);
		}
		set
		{
			SetValue(CaretBlinkIntervalProperty, value);
		}
	}

	public Brush CaretBrush
	{
		get
		{
			return (Brush)GetValue(CaretBrushProperty);
		}
		set
		{
			SetValue(CaretBrushProperty, value);
		}
	}

	public CaretKind CaretInsertKind
	{
		get
		{
			return (CaretKind)GetValue(CaretInsertKindProperty);
		}
		set
		{
			SetValue(CaretInsertKindProperty, value);
		}
	}

	public int CaretInsertWidth
	{
		get
		{
			return (int)GetValue(CaretInsertWidthProperty);
		}
		set
		{
			SetValue(CaretInsertWidthProperty, value);
		}
	}

	public CaretKind CaretOverwriteKind
	{
		get
		{
			return (CaretKind)GetValue(CaretOverwriteKindProperty);
		}
		set
		{
			SetValue(CaretOverwriteKindProperty, value);
		}
	}

	public int CaretOverwriteWidth
	{
		get
		{
			return (int)GetValue(CaretOverwriteWidthProperty);
		}
		set
		{
			SetValue(CaretOverwriteWidthProperty, value);
		}
	}

	public IEditorDocument Document
	{
		get
		{
			return (IEditorDocument)GetValue(DocumentProperty);
		}
		set
		{
			SetValue(DocumentProperty, value);
		}
	}

	public bool HasHorizontalSplit
	{
		get
		{
			return (bool)GetValue(HasHorizontalSplitProperty);
		}
		set
		{
			SetValue(HasHorizontalSplitProperty, value);
		}
	}

	public bool HasSearchOverlayPaneKeyBindings
	{
		get
		{
			return (bool)GetValue(HasSearchOverlayPaneKeyBindingsProperty);
		}
		set
		{
			SetValue(HasSearchOverlayPaneKeyBindingsProperty, value);
		}
	}

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		get
		{
			return (IHighlightingStyleRegistry)GetValue(HighlightingStyleRegistryProperty);
		}
		set
		{
			SetValue(HighlightingStyleRegistryProperty, value);
		}
	}

	public ScrollBarVisibility HorizontalScrollBarVisibility
	{
		get
		{
			return (ScrollBarVisibility)GetValue(HorizontalScrollBarVisibilityProperty);
		}
		set
		{
			SetValue(HorizontalScrollBarVisibilityProperty, value);
		}
	}

	public double HorizontalSplitPercentage
	{
		get
		{
			return (double)GetValue(HorizontalSplitPercentageProperty);
		}
		set
		{
			SetValue(HorizontalSplitPercentageProperty, value);
		}
	}

	public Brush InactiveSelectedTextBackground
	{
		get
		{
			return (Brush)GetValue(InactiveSelectedTextBackgroundProperty);
		}
		set
		{
			SetValue(InactiveSelectedTextBackgroundProperty, value);
		}
	}

	public Brush IndicatorMarginBackground
	{
		get
		{
			return (Brush)GetValue(IndicatorMarginBackgroundProperty);
		}
		set
		{
			SetValue(IndicatorMarginBackgroundProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrect")]
	public bool IsAutoCorrectEnabled
	{
		get
		{
			return (bool)GetValue(IsAutoCorrectEnabledProperty);
		}
		set
		{
			SetValue(IsAutoCorrectEnabledProperty, value);
		}
	}

	public bool IsCollapsibleRegionHighlightingEnabled
	{
		get
		{
			return (bool)GetValue(IsCollapsibleRegionHighlightingEnabledProperty);
		}
		set
		{
			SetValue(IsCollapsibleRegionHighlightingEnabledProperty, value);
		}
	}

	public bool IsCurrentLineHighlightingEnabled
	{
		get
		{
			return (bool)GetValue(IsCurrentLineHighlightingEnabledProperty);
		}
		set
		{
			SetValue(IsCurrentLineHighlightingEnabledProperty, value);
		}
	}

	public bool IsDefaultContextMenuEnabled
	{
		get
		{
			return (bool)GetValue(IsDefaultContextMenuEnabledProperty);
		}
		set
		{
			SetValue(IsDefaultContextMenuEnabledProperty, value);
		}
	}

	public bool IsDelimiterAutoCompleteEnabled
	{
		get
		{
			return (bool)GetValue(IsDelimiterAutoCompleteEnabledProperty);
		}
		set
		{
			SetValue(IsDelimiterAutoCompleteEnabledProperty, value);
		}
	}

	public bool IsDelimiterHighlightingEnabled
	{
		get
		{
			return (bool)GetValue(IsDelimiterHighlightingEnabledProperty);
		}
		set
		{
			SetValue(IsDelimiterHighlightingEnabledProperty, value);
		}
	}

	public bool IsDocumentReadOnly
	{
		get
		{
			return (bool)GetValue(IsDocumentReadOnlyProperty);
		}
		private set
		{
			SetValue(IsDocumentReadOnlyProperty, value);
		}
	}

	public bool IsDragDropTextReselectEnabled
	{
		get
		{
			return (bool)GetValue(IsDragDropTextReselectEnabledProperty);
		}
		set
		{
			SetValue(IsDragDropTextReselectEnabledProperty, value);
		}
	}

	public bool IsImeEnabled
	{
		get
		{
			return (bool)GetValue(IsImeEnabledProperty);
		}
		set
		{
			SetValue(IsImeEnabledProperty, value);
		}
	}

	public bool IsIndicatorMarginVisible
	{
		get
		{
			return (bool)GetValue(IsIndicatorMarginVisibleProperty);
		}
		set
		{
			SetValue(IsIndicatorMarginVisibleProperty, value);
		}
	}

	public bool IsLineNumberMarginVisible
	{
		get
		{
			return (bool)GetValue(IsLineNumberMarginVisibleProperty);
		}
		set
		{
			SetValue(IsLineNumberMarginVisibleProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	public bool IsMultiLine
	{
		get
		{
			return (bool)GetValue(IsMultiLineProperty);
		}
		set
		{
			SetValue(IsMultiLineProperty, value);
		}
	}

	public bool IsOutliningMarginVisible
	{
		get
		{
			return (bool)GetValue(IsOutliningMarginVisibleProperty);
		}
		set
		{
			SetValue(IsOutliningMarginVisibleProperty, value);
		}
	}

	public bool IsOverwriteModeActive
	{
		get
		{
			return (bool)GetValue(IsOverwriteModeActiveProperty);
		}
		set
		{
			SetValue(IsOverwriteModeActiveProperty, value);
		}
	}

	public bool IsRulerMarginVisible
	{
		get
		{
			return (bool)GetValue(IsRulerMarginVisibleProperty);
		}
		set
		{
			SetValue(IsRulerMarginVisibleProperty, value);
		}
	}

	public bool IsSearchResultHighlightingEnabled
	{
		get
		{
			return (bool)GetValue(IsSearchResultHighlightingEnabledProperty);
		}
		set
		{
			SetValue(IsSearchResultHighlightingEnabledProperty, value);
		}
	}

	public bool IsSelectionMarginVisible
	{
		get
		{
			return (bool)GetValue(IsSelectionMarginVisibleProperty);
		}
		set
		{
			SetValue(IsSelectionMarginVisibleProperty, value);
		}
	}

	public bool IsTextDataBindingEnabled
	{
		get
		{
			return (bool)GetValue(IsTextDataBindingEnabledProperty);
		}
		set
		{
			SetValue(IsTextDataBindingEnabledProperty, value);
		}
	}

	public bool IsViewLineMeasureEnabled
	{
		get
		{
			return (bool)GetValue(IsViewLineMeasureEnabledProperty);
		}
		set
		{
			SetValue(IsViewLineMeasureEnabledProperty, value);
		}
	}

	internal bool IsVirtualSpaceAtDocumentEndEnabled
	{
		get
		{
			return (bool)GetValue(oXP);
		}
		set
		{
			SetValue(oXP, value);
		}
	}

	public bool IsVirtualSpaceAtLineEndEnabled
	{
		get
		{
			return (bool)GetValue(IsVirtualSpaceAtLineEndEnabledProperty);
		}
		set
		{
			SetValue(IsVirtualSpaceAtLineEndEnabledProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public bool IsWhitespaceVisible
	{
		get
		{
			return (bool)GetValue(IsWhitespaceVisibleProperty);
		}
		set
		{
			SetValue(IsWhitespaceVisibleProperty, value);
		}
	}

	public bool IsWordWrapEnabled
	{
		get
		{
			return (bool)GetValue(IsWordWrapEnabledProperty);
		}
		set
		{
			SetValue(IsWordWrapEnabledProperty, value);
		}
	}

	public bool IsWordWrapGlyphMarginVisible
	{
		get
		{
			return (bool)GetValue(IsWordWrapGlyphMarginVisibleProperty);
		}
		private set
		{
			SetValue(IsWordWrapGlyphMarginVisibleProperty, value);
		}
	}

	public Brush LineNumberMarginBackground
	{
		get
		{
			return (Brush)GetValue(LineNumberMarginBackgroundProperty);
		}
		set
		{
			SetValue(LineNumberMarginBackgroundProperty, value);
		}
	}

	public FontFamily LineNumberMarginFontFamily
	{
		get
		{
			return (FontFamily)GetValue(LineNumberMarginFontFamilyProperty);
		}
		set
		{
			SetValue(LineNumberMarginFontFamilyProperty, value);
		}
	}

	[TypeConverter(typeof(FontSizeConverter))]
	public double LineNumberMarginFontSize
	{
		get
		{
			return (double)GetValue(LineNumberMarginFontSizeProperty);
		}
		set
		{
			SetValue(LineNumberMarginFontSizeProperty, value);
		}
	}

	public Brush LineNumberMarginForeground
	{
		get
		{
			return (Brush)GetValue(LineNumberMarginForegroundProperty);
		}
		set
		{
			SetValue(LineNumberMarginForegroundProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public double MaxIntelliPromptZoomLevel
	{
		get
		{
			return (double)GetValue(MaxIntelliPromptZoomLevelProperty);
		}
		set
		{
			SetValue(MaxIntelliPromptZoomLevelProperty, value);
		}
	}

	public double MaxZoomLevel
	{
		get
		{
			return (double)GetValue(MaxZoomLevelProperty);
		}
		set
		{
			SetValue(MaxZoomLevelProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
	public double MinIntelliPromptZoomLevel
	{
		get
		{
			return (double)GetValue(MinIntelliPromptZoomLevelProperty);
		}
		set
		{
			SetValue(MinIntelliPromptZoomLevelProperty, value);
		}
	}

	public double MinZoomLevel
	{
		get
		{
			return (double)GetValue(MinZoomLevelProperty);
		}
		set
		{
			SetValue(MinZoomLevelProperty, value);
		}
	}

	public Brush OutliningMarginBackground
	{
		get
		{
			return (Brush)GetValue(OutliningMarginBackgroundProperty);
		}
		set
		{
			SetValue(OutliningMarginBackgroundProperty, value);
		}
	}

	public IPrintSettings PrintSettings
	{
		get
		{
			return (IPrintSettings)GetValue(PrintSettingsProperty);
		}
		set
		{
			SetValue(PrintSettingsProperty, value);
		}
	}

	public Brush RulerMarginBackground
	{
		get
		{
			return (Brush)GetValue(RulerMarginBackgroundProperty);
		}
		set
		{
			SetValue(RulerMarginBackgroundProperty, value);
		}
	}

	public Brush RulerMarginForeground
	{
		get
		{
			return (Brush)GetValue(RulerMarginForegroundProperty);
		}
		set
		{
			SetValue(RulerMarginForegroundProperty, value);
		}
	}

	public TimeSpan ScrollBarAccelerationInterval
	{
		get
		{
			return (TimeSpan)GetValue(ScrollBarAccelerationIntervalProperty);
		}
		set
		{
			SetValue(ScrollBarAccelerationIntervalProperty, value);
		}
	}

	public int ScrollBarAccelerationMaximum
	{
		get
		{
			return (int)GetValue(ScrollBarAccelerationMaximumProperty);
		}
		set
		{
			SetValue(ScrollBarAccelerationMaximumProperty, value);
		}
	}

	public DataTemplate ScrollBarTrayBottomTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollBarTrayBottomTemplateProperty);
		}
		set
		{
			SetValue(ScrollBarTrayBottomTemplateProperty, value);
		}
	}

	public DataTemplate ScrollBarTrayLeftTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollBarTrayLeftTemplateProperty);
		}
		set
		{
			SetValue(ScrollBarTrayLeftTemplateProperty, value);
		}
	}

	public DataTemplate ScrollBarTrayRightTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollBarTrayRightTemplateProperty);
		}
		set
		{
			SetValue(ScrollBarTrayRightTemplateProperty, value);
		}
	}

	public DataTemplate ScrollBarTrayTopTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ScrollBarTrayTopTemplateProperty);
		}
		set
		{
			SetValue(ScrollBarTrayTopTemplateProperty, value);
		}
	}

	public bool ScrollToCaretOnSelectAll
	{
		get
		{
			return (bool)GetValue(ScrollToCaretOnSelectAllProperty);
		}
		set
		{
			SetValue(ScrollToCaretOnSelectAllProperty, value);
		}
	}

	public IEditorSearchOptions SearchOptions
	{
		get
		{
			return (IEditorSearchOptions)GetValue(SearchOptionsProperty);
		}
		set
		{
			SetValue(SearchOptionsProperty, value);
		}
	}

	public Brush SelectedTextBackground
	{
		get
		{
			return (Brush)GetValue(SelectedTextBackgroundProperty);
		}
		set
		{
			SetValue(SelectedTextBackgroundProperty, value);
		}
	}

	public bool SelectionCollapsesOnCopy
	{
		get
		{
			return (bool)GetValue(SelectionCollapsesOnCopyProperty);
		}
		set
		{
			SetValue(SelectionCollapsesOnCopyProperty, value);
		}
	}

	public bool SelectionCollapsesToAnchor
	{
		get
		{
			return (bool)GetValue(SelectionCollapsesToAnchorProperty);
		}
		set
		{
			SetValue(SelectionCollapsesToAnchorProperty, value);
		}
	}

	public Brush SelectionMarginBackground
	{
		get
		{
			return (Brush)GetValue(SelectionMarginBackgroundProperty);
		}
		set
		{
			SetValue(SelectionMarginBackgroundProperty, value);
		}
	}

	public SelectionModes SelectionModesAllowed
	{
		get
		{
			return (SelectionModes)GetValue(SelectionModesAllowedProperty);
		}
		set
		{
			SetValue(SelectionModesAllowedProperty, value);
		}
	}

	public string Text
	{
		get
		{
			if (IsTextDataBindingEnabled)
			{
				return (string)GetValue(TextProperty);
			}
			IEditorDocument document = Document;
			if (document == null)
			{
				return string.Empty;
			}
			int num = 0;
			if (!NDq())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => document.CurrentSnapshot.Text, 
			};
		}
		set
		{
			if (!IsTextDataBindingEnabled)
			{
				Document?.SetText(value);
			}
			else
			{
				SetValue(TextProperty, value);
			}
		}
	}

	public double TextAreaFontSize
	{
		get
		{
			return (double)GetValue(TextAreaFontSizeProperty);
		}
		set
		{
			SetValue(TextAreaFontSizeProperty, value);
		}
	}

	public ScrollBarVisibility VerticalScrollBarVisibility
	{
		get
		{
			return (ScrollBarVisibility)GetValue(VerticalScrollBarVisibilityProperty);
		}
		set
		{
			SetValue(VerticalScrollBarVisibilityProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public Brush VisibleWhitespaceForeground
	{
		get
		{
			return (Brush)GetValue(VisibleWhitespaceForegroundProperty);
		}
		set
		{
			SetValue(VisibleWhitespaceForegroundProperty, value);
		}
	}

	public Brush WordWrapGlyphMarginBackground
	{
		get
		{
			return (Brush)GetValue(WordWrapGlyphMarginBackgroundProperty);
		}
		set
		{
			SetValue(WordWrapGlyphMarginBackgroundProperty, value);
		}
	}

	public Brush WordWrapGlyphMarginForeground
	{
		get
		{
			return (Brush)GetValue(WordWrapGlyphMarginForegroundProperty);
		}
		set
		{
			SetValue(WordWrapGlyphMarginForegroundProperty, value);
		}
	}

	public WordWrapMode WordWrapMode
	{
		get
		{
			return (WordWrapMode)GetValue(WordWrapModeProperty);
		}
		set
		{
			SetValue(WordWrapModeProperty, value);
		}
	}

	public double ZoomAnimationDuration
	{
		get
		{
			return (double)GetValue(ZoomAnimationDurationProperty);
		}
		set
		{
			SetValue(ZoomAnimationDurationProperty, value);
		}
	}

	public double ZoomLevelAnimated
	{
		get
		{
			return (double)GetValue(ZoomLevelAnimatedProperty);
		}
		set
		{
			SetValue(ZoomLevelAnimatedProperty, value);
		}
	}

	public double ZoomLevel
	{
		get
		{
			return (double)GetValue(ZoomLevelProperty);
		}
		set
		{
			SetValue(ZoomLevelProperty, value);
		}
	}

	public double ZoomLevelIncrement
	{
		get
		{
			return (double)GetValue(ZoomLevelIncrementProperty);
		}
		set
		{
			SetValue(ZoomLevelIncrementProperty, value);
		}
	}

	public ZoomModes ZoomModesAllowed
	{
		get
		{
			return (ZoomModes)GetValue(ZoomModesAllowedProperty);
		}
		set
		{
			SetValue(ZoomModesAllowedProperty, value);
		}
	}

	public IEditorViewMarginFactoryCollection ViewMarginFactories => UXa;

	public event EventHandler<EditorViewChangedEventArgs> ActiveViewChanged
	{
		add
		{
			AddHandler(ActiveViewChangedEvent, value);
		}
		remove
		{
			RemoveHandler(ActiveViewChangedEvent, value);
		}
	}

	public event EventHandler<CutCopyDragEventArgs> CutCopyDrag
	{
		add
		{
			AddHandler(CutCopyDragEvent, value);
		}
		remove
		{
			RemoveHandler(CutCopyDragEvent, value);
		}
	}

	public event EventHandler<EditorDocumentChangedEventArgs> DocumentChanged
	{
		add
		{
			AddHandler(DocumentChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentChangedEvent, value);
		}
	}

	public event RoutedEventHandler DocumentIsModifiedChanged
	{
		add
		{
			AddHandler(DocumentIsModifiedChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentIsModifiedChangedEvent, value);
		}
	}

	public event RoutedEventHandler DocumentIsReadOnlyChanged
	{
		add
		{
			AddHandler(DocumentIsReadOnlyChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentIsReadOnlyChangedEvent, value);
		}
	}

	public event EventHandler<EditorDocumentLanguageChangedEventArgs> DocumentLanguageChanged
	{
		add
		{
			AddHandler(DocumentLanguageChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentLanguageChangedEvent, value);
		}
	}

	public event RoutedEventHandler DocumentParseDataChanged
	{
		add
		{
			AddHandler(DocumentParseDataChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentParseDataChangedEvent, value);
		}
	}

	public event EventHandler<EditorSnapshotChangedEventArgs> DocumentTextChanged
	{
		add
		{
			AddHandler(DocumentTextChangedEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentTextChangedEvent, value);
		}
	}

	public event EventHandler<EditorSnapshotChangingEventArgs> DocumentTextChanging
	{
		add
		{
			AddHandler(DocumentTextChangingEvent, value);
		}
		remove
		{
			RemoveHandler(DocumentTextChangingEvent, value);
		}
	}

	public event RoutedEventHandler IsOverwriteModeActiveChanged
	{
		add
		{
			AddHandler(IsOverwriteModeActiveChangedEvent, value);
		}
		remove
		{
			RemoveHandler(IsOverwriteModeActiveChangedEvent, value);
		}
	}

	public event RoutedEventHandler MacroRecordingStateChanged
	{
		add
		{
			AddHandler(MacroRecordingStateChangedEvent, value);
		}
		remove
		{
			RemoveHandler(MacroRecordingStateChangedEvent, value);
		}
	}

	public event EventHandler<SyntaxEditorMenuEventArgs> MenuRequested
	{
		add
		{
			AddHandler(MenuRequestedEvent, value);
		}
		remove
		{
			RemoveHandler(MenuRequestedEvent, value);
		}
	}

	public event EventHandler<OverlayPaneEventArgs> OverlayPaneClosed
	{
		add
		{
			AddHandler(OverlayPaneClosedEvent, value);
		}
		remove
		{
			RemoveHandler(OverlayPaneClosedEvent, value);
		}
	}

	public event EventHandler<OverlayPaneEventArgs> OverlayPaneOpened
	{
		add
		{
			AddHandler(OverlayPaneOpenedEvent, value);
		}
		remove
		{
			RemoveHandler(OverlayPaneOpenedEvent, value);
		}
	}

	public event EventHandler<PasteDragDropEventArgs> PasteDragDrop
	{
		add
		{
			AddHandler(PasteDragDropEvent, value);
		}
		remove
		{
			RemoveHandler(PasteDragDropEvent, value);
		}
	}

	public event RoutedEventHandler UserInterfaceUpdate
	{
		add
		{
			AddHandler(UserInterfaceUpdateEvent, value);
		}
		remove
		{
			RemoveHandler(UserInterfaceUpdateEvent, value);
		}
	}

	public event EventHandler<EditActionEventArgs> ViewActionExecuting
	{
		add
		{
			AddHandler(ViewActionExecutingEvent, value);
		}
		remove
		{
			RemoveHandler(ViewActionExecutingEvent, value);
		}
	}

	public event EventHandler<TextViewEventArgs> ViewClosed
	{
		add
		{
			AddHandler(ViewClosedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewClosedEvent, value);
		}
	}

	public event EventHandler<TextViewEventArgs> ViewIsIncrementalSearchActiveChanged
	{
		add
		{
			AddHandler(ViewIsIncrementalSearchActiveChangedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewIsIncrementalSearchActiveChangedEvent, value);
		}
	}

	public event EventHandler<TextViewEventArgs> ViewOpened
	{
		add
		{
			AddHandler(ViewOpenedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewOpenedEvent, value);
		}
	}

	public event EventHandler<EditorViewSearchEventArgs> ViewSearch
	{
		add
		{
			AddHandler(ViewSearchEvent, value);
		}
		remove
		{
			RemoveHandler(ViewSearchEvent, value);
		}
	}

	public event EventHandler<EditorViewSelectionEventArgs> ViewSelectionChanged
	{
		add
		{
			AddHandler(ViewSelectionChangedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewSelectionChangedEvent, value);
		}
	}

	public event RoutedEventHandler ViewSplitAdded
	{
		add
		{
			AddHandler(ViewSplitAddedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewSplitAddedEvent, value);
		}
	}

	public event RoutedEventHandler ViewSplitMoved
	{
		add
		{
			AddHandler(ViewSplitMovedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewSplitMovedEvent, value);
		}
	}

	public event RoutedEventHandler ViewSplitRemoved
	{
		add
		{
			AddHandler(ViewSplitRemovedEvent, value);
		}
		remove
		{
			RemoveHandler(ViewSplitRemovedEvent, value);
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public SyntaxEditor()
	{
		grA.DaB7cz();
		base._002Ector();
		jGO = ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.SyntaxEditor.AssemblyInfo.Instance, GetType(), this);
		base.DefaultStyleKey = typeof(SyntaxEditor);
		QGa();
		zG7 = new VAy();
		UGs = new zTB(this);
		LGk = new tTD(this);
		wGS = new zTL(this);
		zG9 = new gTU(this);
		hGy = new nK(this);
		oGq = CreateMacroRecording() ?? new MacroRecording(this);
		bG2 = new DT2(this);
		lGM = new uTb();
		PrintSettings = new PrintSettings();
		EGi = FGR().PLW(Q7Z.tqM(1746), Oad);
		dxP();
		int num = 1;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ResetCommandBindings();
				ResetInputBindings();
				base.Loaded += fah;
				base.Unloaded += PaN;
				return;
			case 1:
				lGM.y4v(this);
				num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	internal zTB LGl()
	{
		return UGs;
	}

	[SpecialName]
	internal zTL IGv()
	{
		return wGS;
	}

	[SpecialName]
	internal gTU eGu()
	{
		return zG9;
	}

	private void fah(object P_0, object P_1)
	{
		SGc(null, HG8());
		SGx((vTP)0);
		if (IsTextDataBindingEnabled)
		{
			rxc(_0020: true);
		}
	}

	private void PaN(object P_0, object P_1)
	{
		if (hGy != null)
		{
			hGy.CloseAllSessions();
		}
		SGc(HG8(), null);
	}

	private void Oad()
	{
		kxw();
	}

	[SpecialName]
	internal DT2 jGF()
	{
		return bG2;
	}

	[SpecialName]
	internal VAy FGR()
	{
		return zG7;
	}

	internal void Taz()
	{
		if (!IsMultiLine)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1810), useTransitions: false);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(1788), useTransitions: false);
		}
	}

	[SpecialName]
	internal EditorViewHost mG4()
	{
		return fGp;
	}

	[SpecialName]
	private void PGo(EditorViewHost value)
	{
		if (fGp == value)
		{
			return;
		}
		if (fGp != null)
		{
			fGp.Kgn(this, _0020: true);
		}
		fGp = value;
		int num = 0;
		if (MDx() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (fGp != null)
		{
			fGp.Kgn(this, _0020: false);
		}
	}

	[SpecialName]
	internal uTb gGw()
	{
		return lGM;
	}

	protected virtual IMacroRecording CreateMacroRecording()
	{
		return new MacroRecording(this);
	}

	public bool IsSelectionModeAllowed(SelectionModes mode)
	{
		if ((SelectionModesAllowed & mode) != mode)
		{
			return false;
		}
		return true;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		PGo(GetTemplateChild(Q7Z.tqM(1834)) as EditorViewHost);
		Taz();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new SyntaxEditorAutomationPeer(this);
	}

	public void ResumeCaretBlinking()
	{
		UGs.XRH();
	}

	public void SuspendCaretBlinking(bool show)
	{
		UGs.GRL(show);
	}

	private void zxW(IEditorDocument P_0)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass57_0();
		CS_0024_003C_003E8__locals17.G0r = P_0;
		xGU = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
		{
			instance.Mxa(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.IsModifiedChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.IsModifiedChanged += xGU.OnEvent;
		EGJ = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
		{
			instance.Yxx(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.IsReadOnlyChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.IsReadOnlyChanged += EGJ.OnEvent;
		bGt = new WeakEventListener<SyntaxEditor, SyntaxLanguageChangedEventArgs>(this, delegate(SyntaxEditor instance, object source, SyntaxLanguageChangedEventArgs eventArgs)
		{
			instance.HxG(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.LanguageChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.LanguageChanged += bGt.OnEvent;
		uGZ = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
		{
			instance.IxX(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.ParseDataChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.ParseDataChanged += uGZ.OnEvent;
		OGh = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
		{
			instance.kGG(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.TabSizeChanged -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.TabSizeChanged += OGh.OnEvent;
		SGN = new WeakEventListener<SyntaxEditor, TextSnapshotChangedEventArgs>(this, delegate(SyntaxEditor instance, object source, TextSnapshotChangedEventArgs eventArgs)
		{
			instance.QxK(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, TextSnapshotChangedEventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.RemoveTextChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		});
		CS_0024_003C_003E8__locals17.G0r.AddTextChangedEventHandler(SGN.OnEvent, EventHandlerPriority.Low);
		RGd = new WeakEventListener<SyntaxEditor, TextSnapshotChangingEventArgs>(this, delegate(SyntaxEditor instance, object source, TextSnapshotChangingEventArgs eventArgs)
		{
			instance.Wxf(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, TextSnapshotChangingEventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.RemoveTextChangingEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		});
		CS_0024_003C_003E8__locals17.G0r.AddTextChangingEventHandler(RGd.OnEvent, EventHandlerPriority.Low);
		lGz = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
		{
			instance.kGG(source, eventArgs);
		}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals17.G0r.UndoHistory.Cleared -= weakEventListener.OnEvent;
		});
		CS_0024_003C_003E8__locals17.G0r.UndoHistory.Cleared += lGz.OnEvent;
	}

	private void dxP()
	{
		CoerceValue(DocumentProperty);
	}

	private void sxE()
	{
		if (xGU != null)
		{
			xGU.Detach();
			xGU = null;
		}
		if (EGJ != null)
		{
			EGJ.Detach();
			EGJ = null;
		}
		bool flag = bGt != null;
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				lGz = null;
				return;
			default:
				if (uGZ != null)
				{
					uGZ.Detach();
					uGZ = null;
				}
				if (OGh != null)
				{
					OGh.Detach();
					OGh = null;
				}
				if (SGN != null)
				{
					SGN.Detach();
					SGN = null;
				}
				if (RGd != null)
				{
					RGd.Detach();
					RGd = null;
				}
				if (lGz != null)
				{
					lGz.Detach();
					num = 1;
					if (NDq())
					{
						break;
					}
					goto IL_0005;
				}
				return;
			case 2:
				{
					if (flag)
					{
						bGt.Detach();
						bGt = null;
						num = 0;
						if (MDx() == null)
						{
							break;
						}
						goto IL_0005;
					}
					goto default;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	private void rxc(bool P_0)
	{
		IEditorDocument document = Document;
		bool flag = document != null;
		int num = 0;
		if (MDx() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag)
		{
			return;
		}
		string text = (string)GetValue(TextProperty);
		string text2 = document.CurrentSnapshot.Text;
		if (text != text2)
		{
			if (!P_0)
			{
				document.SetText(text);
			}
			else
			{
				SetValue(TextProperty, text2);
			}
		}
	}

	private void Mxa(object P_0, EventArgs P_1)
	{
		lxA();
		SGx((vTP)4);
	}

	private void Yxx(object P_0, EventArgs P_1)
	{
		bxg();
	}

	private void HxG(object P_0, SyntaxLanguageChangedEventArgs P_1)
	{
		if (P_1.OldLanguage != null && bG2 != null)
		{
			bG2.z6D(P_1.OldLanguage);
			bG2.r6l(P_1.OldLanguage);
		}
		if (P_1.NewLanguage != null && bG2 != null)
		{
			bG2.e6f(P_1.NewLanguage);
		}
		pxm(new EditorDocumentLanguageChangedEventArgs(P_1.OldLanguage, P_1.NewLanguage));
		if (P_1.NewLanguage != null && bG2 != null)
		{
			bG2.q6e(P_1.NewLanguage);
		}
		SGx((vTP)0);
	}

	private void IxX(object P_0, EventArgs P_1)
	{
		vAE.l0x<object>(this, delegate
		{
			TxC();
			EGi.Start(1000);
		}, null);
	}

	private void QxK(object P_0, TextSnapshotChangedEventArgs P_1)
	{
		EditorSnapshotChangedEventArgs e = new EditorSnapshotChangedEventArgs(P_1.OldSnapshot, P_1.NewSnapshot, P_1.TextChange);
		Qxu(e);
		if (IsTextDataBindingEnabled)
		{
			rxc(_0020: true);
		}
		EGi.Start(1000);
	}

	private void Wxf(object P_0, TextSnapshotChangingEventArgs P_1)
	{
		if (IsMultiLine || P_1.NewSnapshot == null)
		{
			goto IL_006c;
		}
		goto IL_020c;
		IL_020c:
		if (P_1.NewSnapshot.Lines.Count > 1)
		{
			P_1.Cancel = true;
			return;
		}
		goto IL_006c;
		IL_006c:
		EditorSnapshotChangingEventArgs e = new EditorSnapshotChangingEventArgs(P_1.OldSnapshot, P_1.NewSnapshot, P_1.TextChange);
		Jx1(e);
		P_1.Cancel |= e.Cancel;
		bool flag = P_1.TextChange.PreSelectionPositionRanges == null && !P_1.Cancel && !P_1.TextChange.IsUndo && !P_1.TextChange.IsRedo;
		int num = 1;
		if (MDx() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		bool flag2 = default(bool);
		IEditorViewSelection editorViewSelection = default(IEditorViewSelection);
		IEditorView editorView = default(IEditorView);
		while (true)
		{
			switch (num)
			{
			default:
				if (flag2)
				{
					editorViewSelection = editorView.Selection;
				}
				goto IL_0184;
			case 1:
				if (!flag)
				{
					return;
				}
				editorView = P_1.TextChange.Source as IEditorView;
				editorViewSelection = null;
				if (editorView == null)
				{
					if (ActiveView != null)
					{
						editorViewSelection = ActiveView.Selection;
					}
					goto IL_0184;
				}
				goto IL_00a2;
			case 2:
				break;
				IL_0184:
				if (editorViewSelection != null)
				{
					P_1.TextChange.PreSelectionPositionRanges = ((editorViewSelection.Mode == SelectionModes.Block && editorViewSelection.Ranges.Count == 1) ? TextPositionRange.CreateCollection(editorViewSelection.Ranges[0], isBlock: true) : TextPositionRange.CreateCollection(editorViewSelection.Ranges, editorViewSelection.Ranges.PrimaryIndex));
				}
				return;
			}
			break;
			IL_00a2:
			flag2 = editorView.SyntaxEditor == this;
			num = 0;
			if (NDq())
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_020c;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void rxD()
	{
		IEditorDocument document = Document;
		if (document != null)
		{
			ITextSnapshot currentSnapshot = document.CurrentSnapshot;
			if (currentSnapshot.Lines.Count > 1)
			{
				document.SetText(TextChangeTypes.Custom, currentSnapshot.Lines[0].Text);
				document.UndoHistory.Clear();
			}
		}
	}

	private void bxg()
	{
		IEditorDocument document = Document;
		bool isDocumentReadOnly = IsDocumentReadOnly;
		bool flag = document?.IsReadOnly ?? true;
		if (flag == isDocumentReadOnly)
		{
			return;
		}
		IsDocumentReadOnly = flag;
		foreach (EditorView item in mG5())
		{
			if (UIElementAutomationPeer.FromElement(this) is EditorViewAutomationPeer editorViewAutomationPeer)
			{
				editorViewAutomationPeer.fnQ(isDocumentReadOnly, IsDocumentReadOnly);
			}
		}
		lxv();
	}

	protected virtual void OnDocumentPropertyChanged(IEditorDocument oldValue, IEditorDocument newValue)
	{
		if (oldValue == newValue)
		{
			return;
		}
		if (IntelliPrompt != null)
		{
			IntelliPrompt.CloseAllSessions();
		}
		if (oldValue != null)
		{
			sxE();
			if (bG2 != null)
			{
				bG2.z6D(oldValue.Language);
				bG2.r6l(oldValue.Language);
			}
		}
		if (bG2 != null)
		{
			bG2.n6g();
		}
		if (lGM != null && newValue != null)
		{
			lGM.j4e(new EditorSnapshotChangedEventArgs(null, newValue.CurrentSnapshot, null));
		}
		bxg();
		if (newValue != null && bG2 != null)
		{
			bG2.e6f(newValue.Language);
		}
		pxl(new EditorDocumentChangedEventArgs(oldValue, newValue));
		if (newValue != null)
		{
			if (bG2 != null)
			{
				bG2.q6e(newValue.Language);
			}
			zxW(newValue);
			if (IsTextDataBindingEnabled)
			{
				bool flag = true;
				BindingExpression bindingExpression = GetBindingExpression(TextProperty);
				if (bindingExpression != null && bindingExpression.ParentBinding != null)
				{
					flag = bindingExpression.ParentBinding.Mode == BindingMode.OneWayToSource || base.IsLoaded;
					rxc(flag);
				}
			}
		}
		if (!IsMultiLine)
		{
			rxD();
		}
		SGx((vTP)0);
		EGi.Start(1000);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void uGB(EventHandler<oAA> value)
	{
		EventHandler<oAA> eventHandler = xXW;
		EventHandler<oAA> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<oAA> value2 = (EventHandler<oAA>)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref xXW, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void RGV(EventHandler<oAA> value)
	{
		EventHandler<oAA> eventHandler = xXW;
		EventHandler<oAA> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<oAA> value2 = (EventHandler<oAA>)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref xXW, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	internal void bxQ(EditorViewChangedEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ActiveViewChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnActiveViewChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void mxe(CutCopyDragEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = CutCopyDragEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnCutCopyDrag(P_0);
		RaiseEvent(P_0);
	}

	internal void pxl(EditorDocumentChangedEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = DocumentChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnDocumentChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void lxA()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DocumentIsModifiedChangedEvent;
			int num = 0;
			if (!NDq())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDocumentIsModifiedChanged(e);
		RaiseEvent(e);
	}

	internal void lxv()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = DocumentIsReadOnlyChangedEvent;
			int num = 0;
			if (MDx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDocumentIsReadOnlyChanged(e);
		RaiseEvent(e);
	}

	internal void pxm(EditorDocumentLanguageChangedEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = DocumentLanguageChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnDocumentLanguageChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void TxC()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			int num = 0;
			if (!NDq())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			e.RoutedEvent = DocumentParseDataChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnDocumentParseDataChanged(e);
		RaiseEvent(e);
	}

	internal void Qxu(EditorSnapshotChangedEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = DocumentTextChangedEvent;
		}
		bool flag = P_0.Source == null;
		int num = 0;
		if (!NDq())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			P_0.Source = this;
		}
		if (lGM != null)
		{
			lGM.j4e(P_0);
		}
		OnDocumentTextChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void Jx1(EditorSnapshotChangingEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = DocumentTextChangingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnDocumentTextChanging(P_0);
		RaiseEvent(P_0);
	}

	internal void dxF()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = IsOverwriteModeActiveChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnIsOverwriteModeActiveChanged(e);
		RaiseEvent(e);
	}

	internal void Gx3()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = MacroRecordingStateChangedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnMacroRecordingStateChanged(e);
		RaiseEvent(e);
	}

	internal void AxR(SyntaxEditorMenuEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = MenuRequestedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnMenuRequested(P_0);
		RaiseEvent(P_0);
	}

	internal static void bxY(string P_0)
	{
		xXW?.Invoke(null, new oAA(P_0));
	}

	internal void Qx4(OverlayPaneEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = OverlayPaneClosedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnOverlayPaneClosed(P_0);
		RaiseEvent(P_0);
	}

	internal void gxo(OverlayPaneEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = OverlayPaneOpenedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnOverlayPaneOpened(P_0);
		RaiseEvent(P_0);
	}

	internal void Uxj(PasteDragDropEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = PasteDragDropEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnPasteDragDrop(P_0);
		RaiseEvent(P_0);
	}

	internal void kxw()
	{
		int num = 1;
		int num2 = num;
		RoutedEventArgs e = default(RoutedEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 1:
				e = new RoutedEventArgs();
				num2 = 0;
				if (NDq())
				{
					num2 = 0;
				}
				continue;
			}
			if (e.RoutedEvent == null)
			{
				e.RoutedEvent = UserInterfaceUpdateEvent;
			}
			if (e.Source == null)
			{
				e.Source = this;
			}
			OnUserInterfaceUpdate(e);
			RaiseEvent(e);
			return;
		}
	}

	internal void Ax6(EditActionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewActionExecutingEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnViewActionExecuting(P_0);
		RaiseEvent(P_0);
	}

	internal void VxH(TextViewEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewClosedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnViewClosed(P_0);
		RaiseEvent(P_0);
	}

	internal void dxb(TextViewEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewIsIncrementalSearchActiveChangedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnViewIsIncrementalSearchActiveChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void TxT(TextViewEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewOpenedEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnViewOpened(P_0);
		RaiseEvent(P_0);
	}

	internal void qxL(EditorViewSearchEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewSearchEvent;
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		OnViewSearch(P_0);
		RaiseEvent(P_0);
	}

	internal void ixn(EditorViewSelectionEventArgs P_0)
	{
		if (P_0.RoutedEvent == null)
		{
			P_0.RoutedEvent = ViewSelectionChangedEvent;
			int num = 0;
			if (!NDq())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (P_0.Source == null)
		{
			P_0.Source = this;
		}
		EGi.Start(1000);
		OnViewSelectionChanged(P_0);
		RaiseEvent(P_0);
	}

	internal void mx8()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ViewSplitAddedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnViewSplitAdded(e);
		RaiseEvent(e);
	}

	internal void KxI()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ViewSplitMovedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
			int num = 0;
			if (MDx() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		OnViewSplitMoved(e);
		RaiseEvent(e);
	}

	internal void Gx5()
	{
		RoutedEventArgs e = new RoutedEventArgs();
		if (e.RoutedEvent == null)
		{
			e.RoutedEvent = ViewSplitRemovedEvent;
		}
		if (e.Source == null)
		{
			e.Source = this;
		}
		OnViewSplitRemoved(e);
		RaiseEvent(e);
	}

	protected virtual void OnActiveViewChanged(EditorViewChangedEventArgs e)
	{
		foreach (IActiveEditorViewChangeEventSink item in bG2.g6Q<IActiveEditorViewChangeEventSink>(_0020: true))
		{
			item.NotifyActiveEditorViewChanged(this, e);
		}
	}

	protected virtual void OnCutCopyDrag(CutCopyDragEventArgs e)
	{
	}

	protected virtual void OnDocumentChanged(EditorDocumentChangedEventArgs e)
	{
	}

	protected virtual void OnDocumentIsModifiedChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnDocumentIsReadOnlyChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnDocumentLanguageChanged(EditorDocumentLanguageChangedEventArgs e)
	{
	}

	protected virtual void OnDocumentParseDataChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnDocumentTextChanged(EditorSnapshotChangedEventArgs e)
	{
		if (e == null || e.Handled)
		{
			return;
		}
		foreach (IEditorDocumentTextChangeEventSink item in bG2.g6Q<IEditorDocumentTextChangeEventSink>(_0020: true))
		{
			item.NotifyDocumentTextChanged(this, e);
			if (!e.Handled)
			{
				continue;
			}
			break;
		}
	}

	protected virtual void OnDocumentTextChanging(EditorSnapshotChangingEventArgs e)
	{
		if (e == null || e.Handled)
		{
			return;
		}
		foreach (IEditorDocumentTextChangeEventSink item in bG2.g6Q<IEditorDocumentTextChangeEventSink>(_0020: true))
		{
			item.NotifyDocumentTextChanging(this, e);
			if (e.Handled)
			{
				break;
			}
		}
	}

	protected virtual void OnIsOverwriteModeActiveChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnMacroRecordingStateChanged(RoutedEventArgs e)
	{
	}

	protected virtual void OnMenuRequested(SyntaxEditorMenuEventArgs e)
	{
	}

	protected virtual void OnPasteDragDrop(PasteDragDropEventArgs e)
	{
	}

	protected virtual void OnOverlayPaneClosed(OverlayPaneEventArgs e)
	{
	}

	protected virtual void OnOverlayPaneOpened(OverlayPaneEventArgs e)
	{
	}

	protected virtual void OnUserInterfaceUpdate(RoutedEventArgs e)
	{
	}

	protected virtual void OnViewActionExecuting(EditActionEventArgs e)
	{
	}

	protected virtual void OnViewClosed(TextViewEventArgs e)
	{
		if (e != null)
		{
			bG2.u6v(e.View);
		}
	}

	protected virtual void OnViewIsIncrementalSearchActiveChanged(TextViewEventArgs e)
	{
	}

	protected virtual void OnViewOpened(TextViewEventArgs e)
	{
		if (e != null)
		{
			bG2.k6A(e.View);
		}
	}

	protected virtual void OnViewSearch(EditorViewSearchEventArgs e)
	{
	}

	protected virtual void OnViewSelectionChanged(EditorViewSelectionEventArgs e)
	{
	}

	protected virtual void OnViewSplitAdded(RoutedEventArgs e)
	{
	}

	protected virtual void OnViewSplitMoved(RoutedEventArgs e)
	{
	}

	protected virtual void OnViewSplitRemoved(RoutedEventArgs e)
	{
	}

	public virtual void ResetCommandBindings()
	{
		base.CommandBindings.Clear();
		base.CommandBindings.Add(EditorCommands.CopyAndAppendToClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CopyToClipboard.CreateCommandBinding(ApplicationCommands.Copy));
		base.CommandBindings.Add(EditorCommands.CopyToClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CutAndAppendToClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CutLineToClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CutToClipboard.CreateCommandBinding(ApplicationCommands.Cut));
		base.CommandBindings.Add(EditorCommands.CutToClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.PasteFromClipboard.CreateCommandBinding(ApplicationCommands.Paste));
		base.CommandBindings.Add(EditorCommands.PasteFromClipboard.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Redo.CreateCommandBinding(ApplicationCommands.Redo));
		base.CommandBindings.Add(EditorCommands.Redo.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Undo.CreateCommandBinding(ApplicationCommands.Undo));
		base.CommandBindings.Add(EditorCommands.Undo.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Backspace.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.BackspaceToPreviousWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Delete.CreateCommandBinding(ApplicationCommands.Delete));
		base.CommandBindings.Add(EditorCommands.Delete.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteBlankLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteHorizontalWhitespace.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteLine.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteToLineEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteToLineStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.DeleteToNextWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.InsertLineBreak.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.OpenLineAbove.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.OpenLineBelow.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptAutoComplete.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptCompletionSession.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptInsertSnippetSession.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptParameterInfoSession.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptQuickInfoSession.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RequestIntelliPromptSurroundWithSession.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CancelMacroRecording.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.PauseResumeMacroRecording.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RunMacro.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ToggleMacroRecording.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Capitalize.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CommentLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ConvertSpacesToTabs.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ConvertTabsToSpaces.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Duplicate.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FormatDocument.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FormatSelection.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Indent.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.InsertTabStopOrIndent.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MakeLowercase.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MakeUppercase.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveSelectedLinesDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveSelectedLinesUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Outdent.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.RemoveTabStopOrOutdent.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ResetZoomLevel.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TabifySelectedLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ToggleCharacterCasing.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ToggleOverwriteMode.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TransposeCharacters.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TransposeLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TransposeWords.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TrimAllTrailingWhitespace.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.TrimTrailingWhitespace.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.UncommentLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.UntabifySelectedLines.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ZoomIn.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ZoomOut.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveLeft.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MovePageDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MovePageUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveRight.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToDocumentEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToDocumentStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToLineEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToLineStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToLineStartAfterIndentation.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToMatchingBracket.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToNextLineStartAfterIndentation.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToNextWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToPreviousLineStartAfterIndentation.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToPreviousWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToVisibleBottom.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveToVisibleTop.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.MoveUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ApplyDefaultOutliningExpansion.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CollapseToDefinitions.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ExpandAllOutlining.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.HideSelection.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.StartAutomaticOutlining.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.StopHidingCurrent.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.StopOutlining.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ToggleAllOutliningExpansion.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ToggleOutliningExpansion.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollLeft.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollLineToVisibleBottom.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollLineToVisibleMiddle.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollLineToVisibleTop.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollPageDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollPageUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollRight.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollToDocumentEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollToDocumentStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ScrollUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Find.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FindNext.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FindNextSelected.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FindPrevious.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.FindPreviousSelected.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.IncrementalSearch.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.Replace.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.ReverseIncrementalSearch.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CodeBlockSelectionContract.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CodeBlockSelectionExpand.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CollapseSelection.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CollapseSelectionLeft.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.CollapseSelectionRight.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectAll.CreateCommandBinding(ApplicationCommands.SelectAll));
		base.CommandBindings.Add(EditorCommands.SelectAll.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockLeft.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockRight.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockToNextWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockToPreviousWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectBlockUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectLeft.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectPageDown.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectPageUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectRight.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToDocumentEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToDocumentStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToLineEnd.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToLineStart.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToLineStartAfterIndentation.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToMatchingBracket.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToNextWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToPreviousWord.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToVisibleBottom.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectToVisibleTop.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectUp.CreateCommandBinding());
		base.CommandBindings.Add(EditorCommands.SelectWord.CreateCommandBinding());
	}

	public virtual void ResetInputBindings()
	{
		InputBindingCollection inputBindings = base.InputBindings;
		inputBindings.Clear();
		ModifierKeys modifierKeys = ModifierKeys.Alt;
		inputBindings.Add(new KeyBinding(EditorCommands.CopyToClipboard, Key.C, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.CopyToClipboard, Key.Insert, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.CutToClipboard, Key.X, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.CutToClipboard, Key.Delete, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.CutLineToClipboard, Key.L, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.PasteFromClipboard, Key.V, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.PasteFromClipboard, Key.Insert, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.Redo, Key.Y, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.Redo, Key.Z, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.Undo, Key.Z, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.Backspace, Key.Back, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.Backspace, Key.Back, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.BackspaceToPreviousWord, Key.Back, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.Delete, Key.Delete, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.DeleteLine, Key.L, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.DeleteToNextWord, Key.Delete, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.InsertLineBreak, Key.Return, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.InsertLineBreak, Key.Return, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.OpenLineAbove, Key.Return, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.OpenLineBelow, Key.Return, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.RequestIntelliPromptAutoComplete, Key.Space, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.RequestIntelliPromptParameterInfoSession, Key.Space, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.InsertTabStopOrIndent, Key.Tab, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MakeLowercase, Key.U, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MakeUppercase, Key.U, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveSelectedLinesDown, Key.Down, modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveSelectedLinesUp, Key.Up, modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.RemoveTabStopOrOutdent, Key.Tab, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.ResetZoomLevel, Key.D0, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ResetZoomLevel, Key.NumPad0, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ToggleOverwriteMode, Key.Insert, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.TransposeCharacters, Key.T, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.TransposeLines, Key.T, ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.TransposeWords, Key.T, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.ZoomOut, Key.OemMinus, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ZoomIn, Key.OemPlus, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ZoomOut, Key.Subtract, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ZoomIn, Key.Add, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveDown, Key.Down, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveLeft, Key.Left, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MovePageDown, Key.Next, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MovePageUp, Key.Prior, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveRight, Key.Right, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToDocumentEnd, Key.End, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToDocumentStart, Key.Home, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToLineEnd, Key.End, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToLineStart, Key.Home, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToMatchingBracket, Key.Oem6, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToNextWord, Key.Right, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToPreviousWord, Key.Left, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToVisibleBottom, Key.Next, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveToVisibleTop, Key.Prior, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.MoveUp, Key.Up, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.ScrollDown, Key.Down, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ScrollUp, Key.Up, ModifierKeys.Control));
		if (HasSearchOverlayPaneKeyBindings)
		{
			inputBindings.Add(new KeyBinding(EditorCommands.Find, Key.F, ModifierKeys.Control));
			inputBindings.Add(new KeyBinding(EditorCommands.FindNext, Key.F3, ModifierKeys.None));
			inputBindings.Add(new KeyBinding(EditorCommands.FindNextSelected, Key.F3, ModifierKeys.Control));
			inputBindings.Add(new KeyBinding(EditorCommands.FindPrevious, Key.F3, ModifierKeys.Shift));
			inputBindings.Add(new KeyBinding(EditorCommands.FindPreviousSelected, Key.F3, ModifierKeys.Control | ModifierKeys.Shift));
			inputBindings.Add(new KeyBinding(EditorCommands.Replace, Key.H, ModifierKeys.Control));
		}
		inputBindings.Add(new KeyBinding(EditorCommands.IncrementalSearch, Key.I, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.ReverseIncrementalSearch, Key.I, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.CodeBlockSelectionContract, Key.Subtract, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.CodeBlockSelectionExpand, Key.Add, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.CollapseSelection, Key.Escape, ModifierKeys.None));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectAll, Key.A, ModifierKeys.Control));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockDown, Key.Down, ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockLeft, Key.Left, ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockRight, Key.Right, ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockToNextWord, Key.Right, ModifierKeys.Control | ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockToPreviousWord, Key.Left, ModifierKeys.Control | ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectBlockUp, Key.Up, ModifierKeys.Shift | modifierKeys));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectDown, Key.Down, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectLeft, Key.Left, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectPageDown, Key.Next, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectPageUp, Key.Prior, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectRight, Key.Right, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToDocumentEnd, Key.End, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToDocumentStart, Key.Home, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToLineEnd, Key.End, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToLineStart, Key.Home, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToMatchingBracket, Key.Oem6, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToNextWord, Key.Right, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToPreviousWord, Key.Left, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToVisibleBottom, Key.Next, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectToVisibleTop, Key.Prior, ModifierKeys.Control | ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectUp, Key.Up, ModifierKeys.Shift));
		inputBindings.Add(new KeyBinding(EditorCommands.SelectWord, Key.W, ModifierKeys.Control | ModifierKeys.Shift));
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "targetView")]
	private MenuItem bx0(IEditorView P_0, string P_1, ICommand P_2)
	{
		MenuItem menuItem = new MenuItem();
		menuItem.CommandTarget = this;
		menuItem.Command = P_2;
		menuItem.Header = P_1;
		return menuItem;
	}

	private static Separator DxB()
	{
		return new Separator();
	}

	private void LxV(ContextMenu P_0, IHitTestResult P_1)
	{
		try
		{
			if (P_1 != null)
			{
				P_0.Placement = PlacementMode.RelativePoint;
				P_0.PlacementRectangle = new Rect(P_1.Location, default(Size));
				P_0.PlacementTarget = this;
				P_0.IsOpen = true;
				return;
			}
			IEditorView activeView = ActiveView;
			TextBounds characterBounds = activeView.GetCharacterBounds(activeView.Selection.EndPosition);
			if (characterBounds.IsYValid)
			{
				P_0.Placement = PlacementMode.Bottom;
				P_0.PlacementRectangle = activeView.TransformFromTextArea(characterBounds.Rect);
				P_0.PlacementTarget = activeView.VisualElement;
				P_0.IsOpen = true;
			}
			else
			{
				Rect textAreaViewportBounds = activeView.TextAreaViewportBounds;
				P_0.Placement = PlacementMode.RelativePoint;
				P_0.PlacementRectangle = new Rect(textAreaViewportBounds.TopLeft, default(Size));
				P_0.PlacementTarget = activeView.VisualElement;
				P_0.IsOpen = true;
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	internal bool Hxr(SyntaxEditorMenuEventArgs P_0)
	{
		if (P_0 != null)
		{
			IHitTestResult hitTestResult = P_0.HitTestResult;
			if (IsDefaultContextMenuEnabled)
			{
				bool flag = hitTestResult == null || P_0.Kind == SyntaxEditorMenuKind.SelectionGripperMenu;
				if (!flag)
				{
					HitTestResultType type = hitTestResult.Type;
					HitTestResultType hitTestResultType = type;
					if ((uint)(hitTestResultType - 2) <= 4u)
					{
						flag = true;
					}
				}
				if (flag)
				{
					IEditorView targetView = ((hitTestResult != null) ? hitTestResult.View : ActiveView);
					P_0.Menu = CreateDefaultContextMenu(targetView);
				}
			}
			AxR(P_0);
			if (P_0.Menu != null && P_0.Menu.Items.Count > 0)
			{
				LxV(P_0.Menu, hitTestResult);
				return true;
			}
		}
		return false;
	}

	protected virtual ContextMenu CreateDefaultContextMenu(IEditorView targetView)
	{
		if (targetView == null)
		{
			targetView = ActiveView;
		}
		ContextMenu contextMenu = new ContextMenu();
		ItemCollection items = contextMenu.Items;
		items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemUndoText), EditorCommands.Undo));
		items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemRedoText), EditorCommands.Redo));
		items.Add(DxB());
		int num = 0;
		if (!NDq())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemCutText), EditorCommands.CutToClipboard));
			items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemCopyText), EditorCommands.CopyToClipboard));
			items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemPasteText), EditorCommands.PasteFromClipboard));
			items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemDeleteText), EditorCommands.Delete));
			items.Add(DxB());
			items.Add(bx0(targetView, SR.GetString(SRName.UIMenuItemSelectAllText), EditorCommands.SelectAll));
			return contextMenu;
		}
	}

	internal double axs(double P_0, bool P_1)
	{
		bool isMultiLine = IsMultiLine;
		double num = (isMultiLine ? MinZoomLevel : 1.0);
		if (P_1 && P_0 > num)
		{
			double num2 = Math.Max(0.1, ZoomLevelIncrement);
			double num3 = (P_0 - num) % num2;
			if (num3 > 0.001)
			{
				double num4 = num3 / num2;
				P_0 = ((!(num4 < 0.5)) ? (P_0 + (num2 - num3)) : (P_0 - num3));
			}
		}
		double val = (isMultiLine ? MaxZoomLevel : 1.0);
		return Math.Max(num, Math.Min(val, Math.Round(P_0, 2, MidpointRounding.AwayFromZero)));
	}

	private static void Exk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnAreWordWrapGlyphsVisiblePropertyChanged(oldValue, newValue);
	}

	private static void txS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnCanSplitHorizontallyPropertyChanged(oldValue, newValue);
	}

	private static void sx9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		syntaxEditor.SGx((vTP)9);
		syntaxEditor.LGl()?.jRb();
	}

	private static void uxy(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		IEditorDocument oldValue = (IEditorDocument)P_1.OldValue;
		IEditorDocument newValue = (IEditorDocument)P_1.NewValue;
		syntaxEditor.OnDocumentPropertyChanged(oldValue, newValue);
	}

	private static void Kxq(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnHasHorizontalSplitPropertyChanged(oldValue, newValue);
	}

	private static void Tx2(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnHasSearchOverlayPaneKeyBindingsPropertyChanged(oldValue, newValue);
	}

	private static void Kx7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		IHighlightingStyleRegistry oldValue = (IHighlightingStyleRegistry)P_1.OldValue;
		IHighlightingStyleRegistry newValue = (IHighlightingStyleRegistry)P_1.NewValue;
		syntaxEditor.OnHighlightingStyleRegistryPropertyChanged(oldValue, newValue);
	}

	private static void Kxi(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		double oldValue = (double)P_1.OldValue;
		double newValue = (double)P_1.NewValue;
		syntaxEditor.OnHorizontalSplitPercentagePropertyChanged(oldValue, newValue);
	}

	private static void axp(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		syntaxEditor.SGx((vTP)4);
	}

	private static void nxM(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		syntaxEditor.SGx((vTP)0);
	}

	private static void DxO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		syntaxEditor.SGx((vTP)2);
	}

	private static void OxU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnIsSearchResultHighlightingEnabledPropertyChanged(oldValue, newValue);
	}

	private static void PxJ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnIsMultiLinePropertyChanged(oldValue, newValue);
	}

	private static void Qxt(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		sx9(P_0, P_1);
		syntaxEditor.dxF();
	}

	private static void hxZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		if ((bool)P_1.NewValue)
		{
			if (syntaxEditor.IsLoaded)
			{
				syntaxEditor.rxc(_0020: true);
			}
		}
		else
		{
			syntaxEditor.ClearValue(TextProperty);
		}
	}

	private static void qxh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnIsVirtualSpaceAtLineEndEnabledPropertyChanged(oldValue, newValue);
	}

	private static void vxN(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnIsVirtualSpaceAtLineEndEnabledPropertyChanged(oldValue, newValue);
	}

	private static void cxd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		bool oldValue = (bool)P_1.OldValue;
		bool newValue = (bool)P_1.NewValue;
		syntaxEditor.OnIsWordWrapEnabledPropertyChanged(oldValue, newValue);
	}

	private static void kxz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		syntaxEditor.SGx((vTP)1);
	}

	private static void WGW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		IEditorDocument document = syntaxEditor.Document;
		if (document == null)
		{
			return;
		}
		string text = ((string)P_1.NewValue) ?? string.Empty;
		if (document.CurrentSnapshot.Text == text)
		{
			return;
		}
		IEditorView activeView = syntaxEditor.ActiveView;
		using (activeView.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			int endOffset = activeView.Selection.EndOffset;
			document.SetText(text);
			activeView.Selection.StartOffset = endOffset;
		}
	}

	private static void AGP(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		WordWrapMode oldValue = (WordWrapMode)P_1.OldValue;
		WordWrapMode newValue = (WordWrapMode)P_1.NewValue;
		syntaxEditor.OnWordWrapModePropertyChanged(oldValue, newValue);
	}

	private static void lGE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		bool flag = true;
		double oldValue = (double)P_1.OldValue;
		double newValue = (double)P_1.NewValue;
		syntaxEditor.OnZoomLevelPropertyChanged(oldValue, newValue);
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	{
		if (e.Property == TextOptions.TextFormattingModeProperty)
		{
			InvalidateViews();
		}
		base.OnPropertyChanged(e);
	}

	private void SGc(IHighlightingStyleRegistry P_0, IHighlightingStyleRegistry P_1)
	{
		_003C_003Ec__DisplayClass631_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass631_0();
		CS_0024_003C_003E8__locals5.QBE = P_1;
		if (P_0 == CS_0024_003C_003E8__locals5.QBE)
		{
			return;
		}
		if (NXE != null)
		{
			NXE.Detach();
			NXE = null;
		}
		if (CS_0024_003C_003E8__locals5.QBE != null)
		{
			NXE = new WeakEventListener<SyntaxEditor, EventArgs>(this, delegate(SyntaxEditor instance, object source, EventArgs eventArgs)
			{
				instance.BGK(source, eventArgs);
			}, delegate(WeakEventListener<SyntaxEditor, EventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals5.QBE.Changed -= weakEventListener.OnEvent;
			});
			CS_0024_003C_003E8__locals5.QBE.Changed += NXE.OnEvent;
		}
	}

	private void QGa()
	{
		UXa = new EditorViewMarginFactoryCollection();
		UXa.Add(new DefaultEditorViewMarginFactory());
		UXa.CollectionChanged += VGf;
	}

	[SpecialName]
	internal IHighlightingStyleRegistry HG8()
	{
		return HighlightingStyleRegistry ?? AmbientHighlightingStyleRegistry.Instance;
	}

	internal void SGx(vTP P_0)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = (P_0 & (vTP)8) == (vTP)8;
				num2 = 0;
				if (MDx() == null)
				{
					num2 = 0;
				}
				continue;
			}
			if (flag && UGs != null)
			{
				UGs.bR6();
			}
			if (lGM == null)
			{
				return;
			}
			foreach (EditorView item in lGM.O4R())
			{
				item.Gf1(P_0);
			}
			return;
		}
	}

	private void kGG(object P_0, EventArgs P_1)
	{
		SGx((vTP)0);
	}

	internal static bool gGX(double P_0, double P_1)
	{
		bool flag = P_0 >= 1.1;
		bool flag2 = P_1 >= 1.1;
		return flag != flag2;
	}

	private void BGK(object P_0, EventArgs P_1)
	{
		_003C_003Ec__DisplayClass638_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass638_0();
		CS_0024_003C_003E8__locals6.yBa = this;
		fXc = (fXc + 1) % 100000;
		CS_0024_003C_003E8__locals6.sBx = fXc;
		vAE.d0c<object>(this, delegate
		{
			if (CS_0024_003C_003E8__locals6.yBa.fXc == CS_0024_003C_003E8__locals6.sBx)
			{
				foreach (EditorView item in CS_0024_003C_003E8__locals6.yBa.mG5())
				{
					item.PAl();
				}
				CS_0024_003C_003E8__locals6.yBa.SGx((vTP)8);
			}
		}, null);
	}

	private void VGf(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		if (lGM == null)
		{
			return;
		}
		foreach (EditorView item in lGM.O4R())
		{
			item.Gfu();
		}
	}

	private void UGD()
	{
		IsWordWrapGlyphMarginVisible = WordWrapMode != WordWrapMode.None && AreWordWrapGlyphsVisible;
	}

	[SpecialName]
	internal IEnumerable<EditorView> mG5()
	{
		if (lGM == null)
		{
			yield break;
		}
		foreach (EditorView item in lGM.O4R())
		{
			yield return item;
		}
	}

	public static void CloseOverlayPanes(string key)
	{
		bxY(key);
	}

	public IEditorView GetView(EditorViewPlacement viewPlacement)
	{
		return (lGM != null) ? lGM.c4Q(viewPlacement) : null;
	}

	public IHitTestResult HitTest(Point point)
	{
		return new ATk(this, point, _0020: false);
	}

	public void InvalidateViews()
	{
		SGx((vTP)0);
	}

	protected virtual void OnAreWordWrapGlyphsVisiblePropertyChanged(bool oldValue, bool newValue)
	{
		UGD();
	}

	protected virtual void OnCanSplitHorizontallyPropertyChanged(bool oldValue, bool newValue)
	{
		lGM.A4m(this);
	}

	protected virtual void OnHasHorizontalSplitPropertyChanged(bool oldValue, bool newValue)
	{
		if (newValue)
		{
			if (HorizontalSplitPercentage == 0.0)
			{
				HorizontalSplitPercentage = 0.5;
			}
		}
		else if (HorizontalSplitPercentage != 0.0)
		{
			HorizontalSplitPercentage = 0.0;
		}
	}

	protected virtual void OnHasSearchOverlayPaneKeyBindingsPropertyChanged(bool oldValue, bool newValue)
	{
		ResetInputBindings();
	}

	protected virtual void OnHighlightingStyleRegistryPropertyChanged(IHighlightingStyleRegistry oldValue, IHighlightingStyleRegistry newValue)
	{
		IHighlightingStyleRegistry highlightingStyleRegistry = oldValue ?? AmbientHighlightingStyleRegistry.Instance;
		IHighlightingStyleRegistry highlightingStyleRegistry2 = newValue ?? AmbientHighlightingStyleRegistry.Instance;
		SGc(highlightingStyleRegistry, highlightingStyleRegistry2);
		foreach (EditorView item in mG5())
		{
			item.PAl();
		}
		SGx((vTP)8);
	}

	protected virtual void OnHorizontalSplitPercentagePropertyChanged(double oldValue, double newValue)
	{
		lGM.X4l(this);
		HasHorizontalSplit = lGM.HorizontalSplitPercentage > 0.0;
	}

	protected virtual void OnIsSearchResultHighlightingEnabledPropertyChanged(bool oldValue, bool newValue)
	{
		if (newValue)
		{
			foreach (EditorView item in mG5())
			{
				if (item.OverlayPanes.FirstOrDefault((IOverlayPane p) => p is SearchOverlayPane) is SearchOverlayPane searchOverlayPane)
				{
					item.HighlightedResultSearchOptions = searchOverlayPane.SearchOptions;
				}
			}
		}
		else
		{
			foreach (EditorView item2 in mG5())
			{
				item2.HighlightedResultSearchOptions = null;
			}
		}
		SGx((vTP)0);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MultiLine")]
	protected virtual void OnIsMultiLinePropertyChanged(bool oldValue, bool newValue)
	{
		if (!newValue)
		{
			rxD();
		}
		lGM.A4m(this);
		SGx((vTP)0);
		Taz();
	}

	protected virtual void OnIsVirtualSpaceAtLineEndEnabledPropertyChanged(bool oldValue, bool newValue)
	{
		if (newValue && WordWrapMode != WordWrapMode.None)
		{
			WordWrapMode = WordWrapMode.None;
		}
		if (newValue)
		{
			return;
		}
		foreach (EditorView item in mG5())
		{
			bool flag = false;
			ITextPositionRangeCollection ranges = item.Selection.Ranges;
			foreach (TextPositionRange item2 in ranges)
			{
				if (item.IsVirtualCharacter(item2.StartPosition, lineTerminatorsAreVirtual: false) || item.IsVirtualCharacter(item2.EndPosition, lineTerminatorsAreVirtual: false))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				item.Selection.SelectRange(item.Selection.TextRange);
			}
		}
	}

	protected virtual void OnIsWordWrapEnabledPropertyChanged(bool oldValue, bool newValue)
	{
		bool flag = WordWrapMode != WordWrapMode.None;
		if (flag != newValue)
		{
			WordWrapMode = (newValue ? WordWrapMode.Word : WordWrapMode.None);
		}
	}

	protected virtual void OnWordWrapModePropertyChanged(WordWrapMode oldValue, WordWrapMode newValue)
	{
		if (newValue != WordWrapMode.None)
		{
			if (IsVirtualSpaceAtDocumentEndEnabled)
			{
				IsVirtualSpaceAtDocumentEndEnabled = false;
			}
			if (IsVirtualSpaceAtLineEndEnabled)
			{
				IsVirtualSpaceAtLineEndEnabled = false;
			}
		}
		bool flag = newValue != WordWrapMode.None;
		if (IsWordWrapEnabled != flag)
		{
			IsWordWrapEnabled = flag;
		}
		UGD();
		SGx((vTP)0);
	}

	protected virtual void OnZoomLevelPropertyChanged(double oldValue, double newValue)
	{
		newValue = axs(newValue, _0020: false);
		if (gGX(oldValue, newValue))
		{
			if (!(newValue >= 1.1))
			{
				ClearValue(TextOptions.TextFormattingModeProperty);
			}
			else
			{
				TextOptions.SetTextFormattingMode(this, TextFormattingMode.Ideal);
			}
		}
		this.AnimateDoubleProperty(Q7Z.tqM(1876), newValue, ZoomAnimationDuration / 1000.0);
		int num = 0;
		if (MDx() != null)
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

	public void ResetViews()
	{
		lGM.y4v(this);
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	static SyntaxEditor()
	{
		grA.DaB7cz();
		ActiveViewChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(1914), RoutingStrategy.Bubble, typeof(EventHandler<EditorViewChangedEventArgs>), typeof(SyntaxEditor));
		CutCopyDragEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(1952), RoutingStrategy.Bubble, typeof(EventHandler<CutCopyDragEventArgs>), typeof(SyntaxEditor));
		DocumentChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(1978), RoutingStrategy.Bubble, typeof(EventHandler<EditorDocumentChangedEventArgs>), typeof(SyntaxEditor));
		DocumentIsModifiedChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2012), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		DocumentIsReadOnlyChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2066), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		DocumentLanguageChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2120), RoutingStrategy.Bubble, typeof(EventHandler<EditorDocumentLanguageChangedEventArgs>), typeof(SyntaxEditor));
		DocumentParseDataChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2170), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		DocumentTextChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2222), RoutingStrategy.Bubble, typeof(EventHandler<EditorSnapshotChangedEventArgs>), typeof(SyntaxEditor));
		DocumentTextChangingEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2264), RoutingStrategy.Bubble, typeof(EventHandler<EditorSnapshotChangingEventArgs>), typeof(SyntaxEditor));
		IsOverwriteModeActiveChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2308), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		MacroRecordingStateChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2368), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		MenuRequestedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2424), RoutingStrategy.Bubble, typeof(EventHandler<SyntaxEditorMenuEventArgs>), typeof(SyntaxEditor));
		OverlayPaneClosedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2454), RoutingStrategy.Bubble, typeof(EventHandler<OverlayPaneEventArgs>), typeof(SyntaxEditor));
		OverlayPaneOpenedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2492), RoutingStrategy.Bubble, typeof(EventHandler<OverlayPaneEventArgs>), typeof(SyntaxEditor));
		PasteDragDropEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2530), RoutingStrategy.Bubble, typeof(EventHandler<PasteDragDropEventArgs>), typeof(SyntaxEditor));
		UserInterfaceUpdateEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(1746), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		ViewActionExecutingEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2560), RoutingStrategy.Bubble, typeof(EventHandler<EditActionEventArgs>), typeof(SyntaxEditor));
		ViewClosedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2602), RoutingStrategy.Bubble, typeof(EventHandler<TextViewEventArgs>), typeof(SyntaxEditor));
		ViewIsIncrementalSearchActiveChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2626), RoutingStrategy.Bubble, typeof(EventHandler<TextViewEventArgs>), typeof(SyntaxEditor));
		ViewOpenedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2702), RoutingStrategy.Bubble, typeof(EventHandler<TextViewEventArgs>), typeof(SyntaxEditor));
		ViewSearchEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2726), RoutingStrategy.Bubble, typeof(EventHandler<EditorViewSearchEventArgs>), typeof(SyntaxEditor));
		ViewSelectionChangedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2750), RoutingStrategy.Bubble, typeof(EventHandler<EditorViewSelectionEventArgs>), typeof(SyntaxEditor));
		ViewSplitAddedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2794), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		ViewSplitMovedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2826), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		ViewSplitRemovedEvent = EventManager.RegisterRoutedEvent(Q7Z.tqM(2858), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SyntaxEditor));
		AcceptsTabProperty = DependencyProperty.Register(Q7Z.tqM(2894), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		ActiveViewProperty = DependencyProperty.Register(Q7Z.tqM(2918), typeof(IEditorView), typeof(SyntaxEditor), new PropertyMetadata(null));
		AllowDragProperty = DependencyProperty.Register(Q7Z.tqM(2942), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		AreIndentationGuidesVisibleProperty = DependencyProperty.Register(Q7Z.tqM(2964), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, nxM));
		AreLineModificationMarksVisibleProperty = DependencyProperty.Register(Q7Z.tqM(3022), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, axp));
		AreMultipleSelectionRangesEnabledProperty = DependencyProperty.Register(Q7Z.tqM(3088), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		AreSelectionGrippersEnabledProperty = DependencyProperty.Register(Q7Z.tqM(3158), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		AreWordWrapGlyphsVisibleProperty = DependencyProperty.Register(Q7Z.tqM(3216), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, Exk));
		CanBackspaceOverSpacesToTabStopProperty = DependencyProperty.Register(Q7Z.tqM(3268), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanCutCopyBlankLineWhenNoSelectionProperty = DependencyProperty.Register(Q7Z.tqM(3334), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanCutCopyDragWithHtmlProperty = DependencyProperty.Register(Q7Z.tqM(3406), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false));
		CanCutCopyDragWithRtfProperty = DependencyProperty.Register(Q7Z.tqM(3454), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanIncrementalSearchTrimUnmatchedFindTextProperty = DependencyProperty.Register(Q7Z.tqM(3500), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanMoveCaretForSecondaryPointerButtonProperty = DependencyProperty.Register(Q7Z.tqM(3586), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanMoveCaretToNextLineAtLineEndProperty = DependencyProperty.Register(Q7Z.tqM(3664), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanMoveCaretToPreviousLineAtLineStartProperty = DependencyProperty.Register(Q7Z.tqM(3730), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanScrollPastDocumentEndProperty = DependencyProperty.Register(Q7Z.tqM(3808), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		CanSplitHorizontallyProperty = DependencyProperty.Register(Q7Z.tqM(3860), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, txS));
		CaretBlinkIntervalProperty = DependencyProperty.Register(Q7Z.tqM(3904), typeof(int), typeof(SyntaxEditor), new PropertyMetadata(500, sx9));
		CaretBrushProperty = DependencyProperty.Register(Q7Z.tqM(3944), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, sx9));
		CaretInsertKindProperty = DependencyProperty.Register(Q7Z.tqM(3968), typeof(CaretKind), typeof(SyntaxEditor), new PropertyMetadata(CaretKind.VerticalLine, sx9));
		CaretInsertWidthProperty = DependencyProperty.Register(Q7Z.tqM(4002), typeof(int), typeof(SyntaxEditor), new PropertyMetadata(1, sx9));
		CaretOverwriteKindProperty = DependencyProperty.Register(Q7Z.tqM(4038), typeof(CaretKind), typeof(SyntaxEditor), new PropertyMetadata(CaretKind.Block, sx9));
		CaretOverwriteWidthProperty = DependencyProperty.Register(Q7Z.tqM(4078), typeof(int), typeof(SyntaxEditor), new PropertyMetadata(1, sx9));
		DocumentProperty = DependencyProperty.Register(Q7Z.tqM(4120), typeof(IEditorDocument), typeof(SyntaxEditor), new PropertyMetadata(null, uxy, UGg));
		HasHorizontalSplitProperty = DependencyProperty.Register(Q7Z.tqM(4140), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, Kxq));
		HasSearchOverlayPaneKeyBindingsProperty = DependencyProperty.Register(Q7Z.tqM(4180), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, Tx2));
		HighlightingStyleRegistryProperty = DependencyProperty.Register(Q7Z.tqM(4246), typeof(IHighlightingStyleRegistry), typeof(SyntaxEditor), new PropertyMetadata(null, Kx7));
		HorizontalScrollBarVisibilityProperty = DependencyProperty.Register(Q7Z.tqM(4300), typeof(ScrollBarVisibility), typeof(SyntaxEditor), new PropertyMetadata(ScrollBarVisibility.Visible, nxM));
		HorizontalSplitPercentageProperty = DependencyProperty.Register(Q7Z.tqM(4362), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(0.0, Kxi));
		InactiveSelectedTextBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(4416), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		IndicatorMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(4480), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		IsAutoCorrectEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4534), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsCollapsibleRegionHighlightingEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4578), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsCurrentLineHighlightingEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4658), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, nxM));
		IsDefaultContextMenuEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4726), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsDelimiterAutoCompleteEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4784), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsDelimiterHighlightingEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4848), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, nxM));
		IsDocumentReadOnlyProperty = DependencyProperty.Register(Q7Z.tqM(4912), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false));
		IsDragDropTextReselectEnabledProperty = DependencyProperty.Register(Q7Z.tqM(4952), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsImeEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5014), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		IsIndicatorMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5042), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, DxO));
		IsLineNumberMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5094), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, DxO));
		IsMultiLineProperty = DependencyProperty.Register(Q7Z.tqM(5148), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, PxJ));
		IsOutliningMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5174), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, DxO));
		IsOverwriteModeActiveProperty = DependencyProperty.Register(Q7Z.tqM(5226), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, Qxt));
		IsRulerMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5272), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, DxO));
		IsSearchResultHighlightingEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5316), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, OxU));
		IsSelectionMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5386), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true, DxO));
		IsTextDataBindingEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5438), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, hxZ));
		IsViewLineMeasureEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5490), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, nxM));
		oXP = DependencyProperty.Register(Q7Z.tqM(5542), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, qxh));
		IsVirtualSpaceAtLineEndEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5614), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, vxN));
		IsWhitespaceVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5678), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, axp));
		IsWordWrapEnabledProperty = DependencyProperty.Register(Q7Z.tqM(5720), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, cxd));
		IsWordWrapGlyphMarginVisibleProperty = DependencyProperty.Register(Q7Z.tqM(5758), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false, DxO));
		LineNumberMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(5818), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		LineNumberMarginFontFamilyProperty = DependencyProperty.Register(Q7Z.tqM(5874), typeof(FontFamily), typeof(SyntaxEditor), new PropertyMetadata(null, nxM));
		LineNumberMarginFontSizeProperty = DependencyProperty.Register(Q7Z.tqM(5930), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(0.0, nxM));
		LineNumberMarginForegroundProperty = DependencyProperty.Register(Q7Z.tqM(5982), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		MaxIntelliPromptZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(6038), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(3.0));
		MaxZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(6092), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(3.0));
		MinIntelliPromptZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(6120), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(1.0));
		MinZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(6174), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(0.5));
		OutliningMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(6202), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		PrintSettingsProperty = DependencyProperty.Register(Q7Z.tqM(6256), typeof(IPrintSettings), typeof(SyntaxEditor), new PropertyMetadata(null));
		RulerMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(6286), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		RulerMarginForegroundProperty = DependencyProperty.Register(Q7Z.tqM(6332), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		ScrollBarAccelerationIntervalProperty = DependencyProperty.Register(Q7Z.tqM(6378), typeof(TimeSpan), typeof(SyntaxEditor), new PropertyMetadata(TimeSpan.FromSeconds(3.0)));
		ScrollBarAccelerationMaximumProperty = DependencyProperty.Register(Q7Z.tqM(6440), typeof(int), typeof(SyntaxEditor), new PropertyMetadata(4));
		ScrollBarTrayBottomTemplateProperty = DependencyProperty.Register(Q7Z.tqM(6500), typeof(DataTemplate), typeof(SyntaxEditor), new PropertyMetadata(null, kxz));
		ScrollBarTrayLeftTemplateProperty = DependencyProperty.Register(Q7Z.tqM(6558), typeof(DataTemplate), typeof(SyntaxEditor), new PropertyMetadata(null, kxz));
		ScrollBarTrayRightTemplateProperty = DependencyProperty.Register(Q7Z.tqM(6612), typeof(DataTemplate), typeof(SyntaxEditor), new PropertyMetadata(null, kxz));
		ScrollBarTrayTopTemplateProperty = DependencyProperty.Register(Q7Z.tqM(6668), typeof(DataTemplate), typeof(SyntaxEditor), new PropertyMetadata(null, kxz));
		ScrollToCaretOnSelectAllProperty = DependencyProperty.Register(Q7Z.tqM(6720), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(true));
		SearchOptionsProperty = DependencyProperty.Register(Q7Z.tqM(6772), typeof(IEditorSearchOptions), typeof(SyntaxEditor), new PropertyMetadata(EditorSearchOptions.Default));
		SelectedTextBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(6802), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		SelectionCollapsesOnCopyProperty = DependencyProperty.Register(Q7Z.tqM(6850), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false));
		SelectionCollapsesToAnchorProperty = DependencyProperty.Register(Q7Z.tqM(6902), typeof(bool), typeof(SyntaxEditor), new PropertyMetadata(false));
		SelectionMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(6958), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		SelectionModesAllowedProperty = DependencyProperty.Register(Q7Z.tqM(7012), typeof(SelectionModes), typeof(SyntaxEditor), new PropertyMetadata(SelectionModes.ContinuousStream | SelectionModes.Block));
		TextProperty = DependencyProperty.Register(Q7Z.tqM(7058), typeof(string), typeof(SyntaxEditor), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, WGW));
		TextAreaFontSizeProperty = DependencyProperty.Register(Q7Z.tqM(7070), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(0.0, axp));
		VerticalScrollBarVisibilityProperty = DependencyProperty.Register(Q7Z.tqM(7106), typeof(ScrollBarVisibility), typeof(SyntaxEditor), new PropertyMetadata(ScrollBarVisibility.Visible, nxM));
		VisibleWhitespaceForegroundProperty = DependencyProperty.Register(Q7Z.tqM(7164), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		WordWrapGlyphMarginBackgroundProperty = DependencyProperty.Register(Q7Z.tqM(7222), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		WordWrapGlyphMarginForegroundProperty = DependencyProperty.Register(Q7Z.tqM(7284), typeof(Brush), typeof(SyntaxEditor), new PropertyMetadata(null, axp));
		WordWrapModeProperty = DependencyProperty.Register(Q7Z.tqM(7346), typeof(WordWrapMode), typeof(SyntaxEditor), new PropertyMetadata(WordWrapMode.None, AGP));
		ZoomAnimationDurationProperty = DependencyProperty.Register(Q7Z.tqM(7374), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(200.0));
		ZoomLevelAnimatedProperty = DependencyProperty.Register(Q7Z.tqM(1876), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(1.0));
		ZoomLevelProperty = DependencyProperty.Register(Q7Z.tqM(7420), typeof(double), typeof(SyntaxEditor), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, lGE));
		ZoomLevelIncrementProperty = DependencyProperty.Register(Q7Z.tqM(7442), typeof(double), typeof(SyntaxEditor), new PropertyMetadata(0.25));
		ZoomModesAllowedProperty = DependencyProperty.Register(Q7Z.tqM(7482), typeof(ZoomModes), typeof(SyntaxEditor), new PropertyMetadata(ZoomModes.All));
		Control.BackgroundProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata(SystemColors.WindowBrush, nxM));
		Control.ForegroundProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata(SystemColors.WindowTextBrush, nxM));
		Control.FontFamilyProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata(new FontFamily(DisplayItemClassificationTypeProvider.rPa), nxM));
		Control.FontSizeProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata((double)DisplayItemClassificationTypeProvider.jPx, nxM));
		Control.FontStyleProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata(nxM));
		Control.FontWeightProperty.OverrideMetadata(typeof(SyntaxEditor), new FrameworkPropertyMetadata(nxM));
	}

	private static object UGg(DependencyObject P_0, object P_1)
	{
		SyntaxEditor syntaxEditor = (SyntaxEditor)P_0;
		if (P_1 != null)
		{
			if (syntaxEditor.FXx != null && syntaxEditor.FXx != P_1)
			{
				syntaxEditor.FXx = null;
			}
		}
		else
		{
			if (syntaxEditor.FXx == null)
			{
				syntaxEditor.FXx = new EditorDocument();
			}
			P_1 = syntaxEditor.FXx;
		}
		return P_1;
	}

	internal ICommand MGQ(ModifierKeys P_0, Key P_1)
	{
		int num = base.InputBindings.Count - 1;
		int num3 = default(int);
		while (true)
		{
			bool flag = num >= 0;
			int num2 = 0;
			if (MDx() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (!flag)
			{
				return null;
			}
			if (base.InputBindings[num] is KeyBinding keyBinding && keyBinding.Key == P_1 && keyBinding.Modifiers == P_0 && keyBinding.Command != null)
			{
				return keyBinding.Command;
			}
			num--;
		}
	}

	protected override void OnContextMenuOpening(ContextMenuEventArgs e)
	{
		base.OnContextMenuOpening(e);
		if (e == null || e.Handled || base.ContextMenu != null)
		{
			return;
		}
		int num = 0;
		if (NDq())
		{
			num = 0;
		}
		IHitTestResult hitTestResult = default(IHitTestResult);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				Point point = new Point(e.CursorLeft, e.CursorTop);
				if (point.X != -1.0)
				{
					if (e.OriginalSource is UIElement uIElement)
					{
						point = uIElement.TransformToVisual(this).Transform(point);
					}
					hitTestResult = HitTest(point);
				}
				SyntaxEditorMenuEventArgs e2 = new SyntaxEditorMenuEventArgs(SyntaxEditorMenuKind.DefaultContextMenu, hitTestResult);
				e.Handled |= Hxr(e2);
				return;
			}
			}
			if (ContextMenuService.GetIsEnabled(this))
			{
				hitTestResult = null;
				num = 1;
				if (!NDq())
				{
					num = num2;
				}
				continue;
			}
			return;
		}
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		base.OnGotKeyboardFocus(e);
		if (base.IsKeyboardFocused && Keyboard.FocusedElement == this)
		{
			IEditorView activeView = ActiveView;
			if (activeView != null && activeView.VisualElement != null && !activeView.VisualElement.IsKeyboardFocused)
			{
				activeView.VisualElement.Focus();
			}
		}
	}

	public bool ShowPrintDialog()
	{
		IPrintSettings printSettings = PrintSettings;
		int num;
		string description = default(string);
		if (printSettings == null)
		{
			num = 1;
			if (!NDq())
			{
				goto IL_0005;
			}
		}
		else
		{
			description = Document?.FileName ?? printSettings.DocumentTitle;
			num = 0;
			if (NDq())
			{
				num = 0;
			}
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		bool result = default(bool);
		do
		{
			switch (num)
			{
			case 1:
				result = false;
				break;
			case 2:
				break;
			default:
			{
				PrintDialog printDialog = new PrintDialog();
				if (SXG != null)
				{
					printDialog.PrintQueue.MergeAndValidatePrintTicket(printDialog.PrintQueue.DefaultPrintTicket, SXG);
					printDialog.PrintTicket = SXG;
				}
				bool? flag = printDialog.ShowDialog();
				SXG = printDialog.PrintTicket;
				if (flag == true)
				{
					Size pageSize = printSettings.PageSize;
					printSettings.PageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
					FixedDocument fixedDocument = printSettings.CreateFixedDocument(this);
					printSettings.PageSize = pageSize;
					if (fixedDocument != null)
					{
						printDialog.PrintDocument(fixedDocument.DocumentPaginator, description);
						result = true;
					}
					else
					{
						result = false;
					}
					break;
				}
				goto IL_0143;
			}
			}
			return result;
			IL_0143:
			result = false;
			num = 2;
		}
		while (MDx() == null);
		goto IL_0005;
	}

	public bool ShowPrintPreviewDialog()
	{
		IPrintSettings printSettings = PrintSettings;
		if (printSettings == null || !SecurityHelper.IsFullTrust)
		{
			return false;
		}
		FixedDocument fixedDocument = printSettings.CreateFixedDocument(this);
		if (fixedDocument == null)
		{
			return false;
		}
		Window window = Window.GetWindow(this);
		PrintPreviewWindow printPreviewWindow = new PrintPreviewWindow();
		if (window != null)
		{
			printPreviewWindow.Owner = window;
		}
		printPreviewWindow.Document = fixedDocument;
		printPreviewWindow.SyntaxEditor = this;
		printPreviewWindow.ShowDialog();
		return true;
	}

	[CompilerGenerated]
	private void QGe(object P_0)
	{
		TxC();
		EGi.Start(1000);
	}

	internal static bool NDq()
	{
		return aDn == null;
	}

	internal static SyntaxEditor MDx()
	{
		return aDn;
	}
}
