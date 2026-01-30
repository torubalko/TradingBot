using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorViewSelectionEventArgs : RoutedEventArgs
{
	private EditorViewSelectionBatchOptions bam;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextPositionRangeCollection aaC;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEditorView jau;

	internal static EditorViewSelectionEventArgs l8;

	public bool CanResetSearchStartOffset => (bam & EditorViewSelectionBatchOptions.NoResetSearchStartOffset) != EditorViewSelectionBatchOptions.NoResetSearchStartOffset;

	public bool CanScrollToCaret => (bam & EditorViewSelectionBatchOptions.NoScrollToCaret) != EditorViewSelectionBatchOptions.NoScrollToCaret;

	public int CaretCharacterColumn => View.Selection.CaretCharacterColumn;

	public int CaretDisplayCharacterColumn => View.Selection.CaretDisplayCharacterColumn;

	public TextPosition CaretPosition => View.Selection.CaretPosition;

	public TextPosition PreviousCaretPosition => PreviousSelectionRanges.Primary.EndPosition;

	public ITextPositionRangeCollection PreviousSelectionRanges
	{
		[CompilerGenerated]
		get
		{
			return aaC;
		}
		[CompilerGenerated]
		private set
		{
			aaC = value;
		}
	}

	public IEditorView View
	{
		[CompilerGenerated]
		get
		{
			return jau;
		}
		[CompilerGenerated]
		private set
		{
			jau = value;
		}
	}

	public EditorViewSelectionEventArgs(IEditorView view, ITextPositionRangeCollection previousSelectionRanges, EditorViewSelectionBatchOptions options)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (previousSelectionRanges == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(964));
		}
		View = view;
		PreviousSelectionRanges = previousSelectionRanges;
		bam = options;
	}

	public EditorViewSelectionEventArgs(EditorViewSelectionEventArgs e)
	{
		grA.DaB7cz();
		base._002Ector();
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		View = e.View;
		PreviousSelectionRanges = e.PreviousSelectionRanges;
		bam = e.bam;
	}

	internal static bool eU()
	{
		return l8 == null;
	}

	internal static EditorViewSelectionEventArgs Ke()
	{
		return l8;
	}
}
