using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class zTV : ObservableObjectBase, IEditorViewSelection
{
	private class i7l : DisposableObject
	{
		private zTV vsE;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EditorViewSelectionBatchOptions vsc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IEditorViewSelectionState Jsa;

		internal static i7l OMa;

		public i7l(zTV P_0, EditorViewSelectionBatchOptions P_1)
		{
			grA.DaB7cz();
			base._002Ector();
			vsE = P_0;
			brN(P_1);
			P_0.noX(this);
		}

		protected override void Dispose(bool P_0)
		{
			if (vsE != null)
			{
				vsE.poG(this);
				vsE = null;
			}
			base.Dispose(P_0);
		}

		[SpecialName]
		[CompilerGenerated]
		public EditorViewSelectionBatchOptions Rrh()
		{
			return vsc;
		}

		[SpecialName]
		[CompilerGenerated]
		private void brN(EditorViewSelectionBatchOptions P_0)
		{
			vsc = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public IEditorViewSelectionState arz()
		{
			return Jsa;
		}

		[SpecialName]
		[CompilerGenerated]
		public void msW(IEditorViewSelectionState P_0)
		{
			Jsa = P_0;
		}

		internal static bool nML()
		{
			return OMa == null;
		}

		internal static i7l jMg()
		{
			return OMa;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public zTV wsG;

		public i7l wsX;

		private static _003C_003Ec__DisplayClass4_0 CMA;

		public _003C_003Ec__DisplayClass4_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void Csx(object o)
		{
			if (wsG.Uoj != null && (wsX.Rrh() & EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory) != EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory)
			{
				wsG.Uoj.IYc();
			}
			EditorViewSelectionEventArgs e = new EditorViewSelectionEventArgs(wsG.do6, wsX.arz().Ranges, wsX.Rrh());
			wsG.do6.CK0(e);
			wsG.NotifyPropertyChanged(string.Empty);
		}

		internal static bool SMl()
		{
			return CMA == null;
		}

		internal static _003C_003Ec__DisplayClass4_0 kMW()
		{
			return CMA;
		}
	}

	private int ooY;

	private object Fo4;

	private bool Ooo;

	private iTm Uoj;

	private UTd yow;

	private EditorView do6;

	internal static zTV uAr;

	public bool IsReadOnly
	{
		get
		{
			IEditorDocument document = do6.SyntaxEditor.Document;
			if (document.IsReadOnly)
			{
				return true;
			}
			if (yow.Mode == SelectionModes.Block)
			{
				if (IsZeroLength)
				{
					return document.IsTextRangeReadOnly(new TextRange(EndOffset, EndOffset + 1));
				}
				foreach (TextRange textRange2 in GetTextRanges())
				{
					if (document.IsTextRangeReadOnly(textRange2))
					{
						return true;
					}
				}
			}
			else
			{
				foreach (TextPositionRange item in yow)
				{
					if (IsZeroLength)
					{
						int num = do6.PositionToOffset(item.EndPosition);
						if (document.IsTextRangeReadOnly(new TextRange(num, num + 1)))
						{
							return true;
						}
					}
					else
					{
						TextRange textRange = new TextRange(do6.PositionToOffset(item.StartPosition), do6.PositionToOffset(item.EndPosition));
						if (document.IsTextRangeReadOnly(textRange))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	public SelectionModes Mode => yow.Mode;

	public ITextPositionRangeCollection Ranges => yow;

	public int CaretCharacterColumn => do6.GetCharacterColumn(CaretPosition);

	public int CaretDisplayCharacterColumn => CaretCharacterColumn + 1;

	public int CaretOffset
	{
		get
		{
			return EndOffset;
		}
		set
		{
			StartOffset = startOffset;
		}
	}

	public TextPosition CaretPosition
	{
		get
		{
			return EndPosition;
		}
		set
		{
			StartPosition = startPosition;
		}
	}

	public int EndOffset
	{
		get
		{
			return do6.PositionToOffset(EndPosition);
		}
		set
		{
			int offset = Qog(num);
			VoF(new TextPositionRange(StartPosition, do6.OffsetToPosition(offset)));
		}
	}

	public TextPosition EndPosition
	{
		get
		{
			return yow.Primary.EndPosition;
		}
		set
		{
			VoF(new TextPositionRange(StartPosition, endPosition));
		}
	}

	public TextSnapshotOffset EndSnapshotOffset => new TextSnapshotOffset(do6.CurrentSnapshot, EndOffset);

	public int FirstOffset => do6.PositionToOffset(FirstPosition);

	public TextPosition FirstPosition => yow.Primary.FirstPosition;

	public bool IsNormalized => yow.Primary.IsNormalized;

	public bool IsZeroLength => yow.Primary.IsZeroLength;

	public int LastOffset => do6.PositionToOffset(LastPosition);

	public TextPosition LastPosition => yow.Primary.LastPosition;

	public int Length => TextRange.AbsoluteLength;

	public TextPositionRange PositionRange
	{
		get
		{
			return yow.Primary;
		}
		set
		{
			VoF(textPositionRange);
		}
	}

	public TextSnapshotRange SnapshotRange => new TextSnapshotRange(do6.CurrentSnapshot, TextRange);

	public int StartOffset
	{
		get
		{
			return do6.PositionToOffset(StartPosition);
		}
		set
		{
			int offset = Qog(num);
			TextPosition position = do6.OffsetToPosition(offset);
			VoF(new TextPositionRange(position));
		}
	}

	public TextPosition StartPosition
	{
		get
		{
			return yow.Primary.StartPosition;
		}
		set
		{
			VoF(new TextPositionRange(position), SelectionModes.ContinuousStream);
		}
	}

	public TextSnapshotOffset StartSnapshotOffset => new TextSnapshotOffset(do6.CurrentSnapshot, StartOffset);

	public TextRange TextRange
	{
		get
		{
			return new TextRange(StartOffset, EndOffset);
		}
		set
		{
			SelectRange(textRange);
		}
	}

	private void poG(i7l P_0)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals11.wsG = this;
		CS_0024_003C_003E8__locals11.wsX = P_0;
		bool flag = false;
		lock (Fo4)
		{
			if (ooY > 0)
			{
				ooY--;
			}
			flag = ooY == 0;
		}
		Ooo |= (CS_0024_003C_003E8__locals11.wsX.Rrh() & EditorViewSelectionBatchOptions.ForceSelectionChangedEvent) == EditorViewSelectionBatchOptions.ForceSelectionChangedEvent;
		int num = 0;
		if (zAE() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag || !Ooo)
		{
			return;
		}
		Ooo = false;
		vAE.l0x<object>(do6.SyntaxEditor, delegate
		{
			if (CS_0024_003C_003E8__locals11.wsG.Uoj != null && (CS_0024_003C_003E8__locals11.wsX.Rrh() & EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory) != EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory)
			{
				CS_0024_003C_003E8__locals11.wsG.Uoj.IYc();
			}
			EditorViewSelectionEventArgs e = new EditorViewSelectionEventArgs(CS_0024_003C_003E8__locals11.wsG.do6, CS_0024_003C_003E8__locals11.wsX.arz().Ranges, CS_0024_003C_003E8__locals11.wsX.Rrh());
			CS_0024_003C_003E8__locals11.wsG.do6.CK0(e);
			CS_0024_003C_003E8__locals11.wsG.NotifyPropertyChanged(string.Empty);
		}, null);
	}

	private void noX(i7l P_0)
	{
		lock (Fo4)
		{
			if (ooY++ == 0)
			{
				P_0.msW(CaptureState());
				Ooo = false;
				if ((P_0.Rrh() & EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate) == EditorViewSelectionBatchOptions.NoPreferredCaretHorizontalLocationsUpdate)
				{
					Xol();
				}
				else
				{
					jov();
				}
			}
		}
	}

	public IDisposable CreateBatch(EditorViewSelectionBatchOptions P_0)
	{
		return new i7l(this, P_0);
	}

	public zTV(EditorView P_0)
	{
		grA.DaB7cz();
		Fo4 = new object();
		Uoj = new iTm();
		yow = new UTd();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		do6 = P_0;
	}

	private bool ToK(TextPositionRange P_0, bool P_1)
	{
		if (yow.Mode == SelectionModes.Block)
		{
			VoF(P_0, SelectionModes.ContinuousStream);
			return true;
		}
		yow.CoL(SelectionModes.ContinuousStream);
		P_0 = MoQ(P_0);
		using (CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			Ooo = true;
			return yow.ToT(P_0, _0020: true, P_1);
		}
	}

	internal void Fof()
	{
		if (do6 != null)
		{
			do6.Closed += oo1;
			do6.SyntaxEditor.DocumentChanged += Gou;
		}
	}

	private IEditorViewSelectionState poD(TextRangeTrackingModes P_0, ITextSnapshot P_1)
	{
		ITextPositionRangeCollection textPositionRangeCollection = TextPositionRange.CreateCollection(yow, yow.PrimaryIndex);
		return new oT3(do6, textPositionRangeCollection, yow.Mode, P_1, P_0);
	}

	private int Qog(int P_0)
	{
		ITextSnapshot currentSnapshot = do6.CurrentSnapshot;
		P_0 = Math.Max(0, Math.Min(currentSnapshot.Length, P_0));
		if (P_0 < currentSnapshot.Length && char.IsLowSurrogate(currentSnapshot[P_0]))
		{
			P_0++;
		}
		return P_0;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private TextPositionRange MoQ(TextPositionRange P_0)
	{
		return P_0;
	}

	private TextRange Soe(TextRange P_0)
	{
		if (!P_0.IsZeroLength)
		{
			return new TextRange(Qog(P_0.StartOffset), Qog(P_0.EndOffset));
		}
		return new TextRange(Qog(P_0.StartOffset));
	}

	private void Xol()
	{
		if (yow.Yo0() == null)
		{
			GetPreferredCaretHorizontalLocations();
		}
	}

	internal IList<TextPositionRange> uoA(int P_0 = 1)
	{
		if (P_0 < 1)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(193470), SR.GetString(SRName.ExValueGreaterThanZero));
		}
		if (yow.Mode == SelectionModes.Block)
		{
			List<TextPositionRange> list = new List<TextPositionRange>();
			ITextViewLine textViewLine = do6.GetViewLine(FirstPosition);
			IList<Range> characterIndexRanges = do6.GetCharacterIndexRanges(PositionRange, P_0);
			foreach (Range item in characterIndexRanges)
			{
				TextPosition textPosition = textViewLine.CharacterIndexToPosition(item.Min);
				TextPosition endPosition = ((item.Length == 0) ? textPosition : textViewLine.CharacterIndexToPosition(item.Max));
				list.Add(new TextPositionRange(textPosition, endPosition));
				textViewLine = textViewLine.NextLine;
			}
			if (list.Count > 0)
			{
				return list.ToArray();
			}
		}
		else if (yow.Count > 1)
		{
			return yow.ToArray();
		}
		return new TextPositionRange[1] { PositionRange };
	}

	private void jov()
	{
		yow.Ron();
	}

	internal void lom()
	{
		bool flag = false;
		ICollapsedRegionManager collapsedRegionManager = do6.CollapsedRegionManager;
		ITextSnapshot currentSnapshot = do6.CurrentSnapshot;
		TextPositionRange[] array = yow.ToArray();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			TextPositionRange textPositionRange = array[num];
			int num2 = currentSnapshot.PositionToOffset(textPositionRange.StartPosition);
			int offset = (textPositionRange.IsZeroLength ? num2 : currentSnapshot.PositionToOffset(textPositionRange.EndPosition));
			TextSnapshotRange collapsedRange = collapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(currentSnapshot, num2));
			TextSnapshotRange textSnapshotRange = (textPositionRange.IsZeroLength ? collapsedRange : collapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(currentSnapshot, offset)));
			if (collapsedRange != textSnapshotRange)
			{
				if (!collapsedRange.IsDeleted)
				{
					if (!textSnapshotRange.IsDeleted)
					{
						array[num] = new TextPositionRange(currentSnapshot.OffsetToPosition(collapsedRange.StartOffset), currentSnapshot.OffsetToPosition(textSnapshotRange.StartOffset));
						flag = true;
					}
					else
					{
						array[num] = new TextPositionRange(currentSnapshot.OffsetToPosition(collapsedRange.StartOffset), textPositionRange.EndPosition);
						flag = true;
					}
				}
				else if (!textSnapshotRange.IsDeleted)
				{
					array[num] = new TextPositionRange(textPositionRange.StartPosition, currentSnapshot.OffsetToPosition(textSnapshotRange.StartOffset));
					flag = true;
				}
			}
			else if (!collapsedRange.IsDeleted)
			{
				array[num] = new TextPositionRange(currentSnapshot.OffsetToPosition(collapsedRange.StartOffset));
				flag = true;
			}
		}
		if (flag)
		{
			SelectRanges(array);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal void BoC(EditorSnapshotChangedEventArgs P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		ITextChange textChange = P_0.TextChange;
		if (textChange == null)
		{
			return;
		}
		int count = textChange.Operations.Count;
		if (count == 0)
		{
			return;
		}
		ITextChangeOperation textChangeOperation = textChange.Operations[count - 1];
		EditorViewSelectionBatchOptions options = ((textChangeOperation.IsProgrammaticTextReplacement || (textChangeOperation.HasDeletion && IsZeroLength)) ? EditorViewSelectionBatchOptions.ForceSelectionChangedEvent : EditorViewSelectionBatchOptions.None);
		using (do6.Selection.CreateBatch(options))
		{
			bool flag = do6.IsActive && (textChange.Source == null || textChange.Source == do6);
			if (flag && textChange.IsUndo && textChange.PreSelectionPositionRanges != null && textChange.PreSelectionPositionRanges.Count >= 1)
			{
				ITextSnapshot newSnapshot = P_0.NewSnapshot;
				if (textChange.PreSelectionPositionRanges.IsBlock && textChange.PreSelectionPositionRanges.Count == 1)
				{
					SelectRange(textChange.PreSelectionPositionRanges[0], SelectionModes.Block);
				}
				else
				{
					SelectRanges(textChange.PreSelectionPositionRanges, textChange.PreSelectionPositionRanges.PrimaryIndex);
				}
				return;
			}
			if (flag && textChange.PostSelectionPositionRanges != null && textChange.PostSelectionPositionRanges.Count >= 1)
			{
				ITextSnapshot newSnapshot2 = P_0.NewSnapshot;
				if (textChange.PostSelectionPositionRanges.IsBlock && textChange.PostSelectionPositionRanges.Count == 1)
				{
					SelectRange(textChange.PostSelectionPositionRanges[0], SelectionModes.Block);
				}
				else
				{
					SelectRanges(textChange.PostSelectionPositionRanges, textChange.PostSelectionPositionRanges.PrimaryIndex);
				}
				return;
			}
			if (textChangeOperation.IsProgrammaticTextReplacement)
			{
				StartOffset = 0;
				return;
			}
			if (flag && !textChange.RetainSelection)
			{
				if (textChange.IsUndo)
				{
					if (textChangeOperation.InsertionLength > 1 || !textChangeOperation.InsertedText.Equals(Q7Z.tqM(7894)))
					{
						SelectRange(new TextRange(textChangeOperation.StartOffset, textChangeOperation.InsertionEndOffset));
					}
					else
					{
						StartOffset = textChangeOperation.StartOffset;
					}
				}
				else if (textChange.IsRedo)
				{
					StartOffset = textChangeOperation.InsertionEndOffset;
				}
				else if (textChangeOperation.HasInsertion)
				{
					StartOffset = textChangeOperation.InsertionEndOffset;
				}
				else if (textChangeOperation.HasDeletion)
				{
					StartOffset = textChangeOperation.StartOffset;
				}
				return;
			}
			if (flag && count > 1 && do6.CurrentSnapshot == P_0.NewSnapshot && P_0.OldSnapshot != null)
			{
				TextRangeTrackingModes textRangeTrackingModes = (textChange.RetainSelection ? TextRangeTrackingModes.NegativeWhenZeroLength : TextRangeTrackingModes.ExpandBothEdges);
				IEditorViewSelectionState editorViewSelectionState = poD(textRangeTrackingModes, P_0.OldSnapshot);
				editorViewSelectionState.Restore();
				return;
			}
			TextRange textRange = ((P_0.OldSnapshot != null) ? P_0.OldSnapshot.PositionRangeToTextRange(PositionRange) : TextRange);
			int lastTextReplacementOperationIndex = textChange.LastTextReplacementOperationIndex;
			if (lastTextReplacementOperationIndex != -1)
			{
				textRange = new TextRange((!textChange.Operations[lastTextReplacementOperationIndex].IsProgrammaticTextReplacement) ? textChange.Operations[lastTextReplacementOperationIndex].InsertionLength : 0);
				lastTextReplacementOperationIndex++;
			}
			else
			{
				lastTextReplacementOperationIndex = 0;
			}
			bool flag2 = false;
			for (int i = lastTextReplacementOperationIndex; i < textChange.Operations.Count; i++)
			{
				ITextChangeOperation textChangeOperation2 = textChange.Operations[i];
				int num = 0;
				bool flag3 = textChangeOperation2.StartOffset == textRange.FirstOffset && !textRange.IsZeroLength;
				if (textChangeOperation2.HasDeletion)
				{
					if (textChangeOperation2.DeletionEndOffset <= textRange.FirstOffset)
					{
						flag3 = textChangeOperation2.DeletionEndOffset == textRange.FirstOffset;
						textRange = new TextRange(textRange.FirstOffset - textChangeOperation2.DeletionLength, textRange.LastOffset - textChangeOperation2.DeletionLength);
						flag2 = true;
					}
					else if (textChangeOperation2.StartOffset >= textRange.FirstOffset && textChangeOperation2.DeletionEndOffset <= textRange.LastOffset)
					{
						num = textChangeOperation2.StartOffset - textRange.FirstOffset;
						flag3 = textChangeOperation2.DeletionEndOffset == textRange.LastOffset;
						textRange = new TextRange(textRange.FirstOffset, textRange.LastOffset - textChangeOperation2.DeletionLength);
						flag2 = true;
					}
					else if (textChangeOperation2.StartOffset < textRange.LastOffset)
					{
						num = textRange.FirstOffset - textChangeOperation2.StartOffset;
						flag3 = false;
						textRange = new TextRange(Math.Min(textRange.EndOffset, do6.CurrentSnapshot.Length));
						flag2 = true;
					}
					else
					{
						flag3 = false;
					}
				}
				if (textChangeOperation2.HasInsertion)
				{
					if ((flag3 && textChangeOperation2.StartOffset == textRange.FirstOffset) || textChangeOperation2.StartOffset < textRange.FirstOffset + ((num > 0) ? 1 : 0))
					{
						textRange = new TextRange(textRange.FirstOffset + textChangeOperation2.InsertionLength - num, textRange.LastOffset + textChangeOperation2.InsertionLength - num);
						flag2 = true;
					}
					else if (textChangeOperation2.StartOffset >= textRange.FirstOffset + 1 && textChangeOperation2.StartOffset < textRange.LastOffset + (flag3 ? 1 : 0))
					{
						textRange = new TextRange(textRange.FirstOffset, textRange.LastOffset + textChangeOperation2.InsertionLength);
						flag2 = true;
					}
				}
			}
			if (flag2)
			{
				SelectRange(textRange);
			}
		}
	}

	private void Gou(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		if (P_1.NewValue != null)
		{
			using (do6.Selection.CreateBatch(EditorViewSelectionBatchOptions.NoScrollToCaret))
			{
				StartOffset = 0;
			}
			do6.lfz().ScrollToCaret();
		}
	}

	private void oo1(object P_0, object P_1)
	{
		do6.Closed += oo1;
		do6.SyntaxEditor.DocumentChanged -= Gou;
	}

	private void VoF(TextPositionRange P_0, SelectionModes P_1 = SelectionModes.None)
	{
		if (yow.Count == 1 && StartPosition == P_0.StartPosition && EndPosition == P_0.EndPosition && (P_1 == SelectionModes.None || P_1 == yow.Mode))
		{
			return;
		}
		yow.CoL(P_1);
		P_0 = MoQ(P_0);
		using (CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			Ooo = true;
			yow.Uo8(P_0);
		}
	}

	private void xo3(IEnumerable<TextPositionRange> P_0, int? P_1)
	{
		TextPositionRange[] array = P_0.ToArray();
		if (array.Length == 0)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(193498));
		}
		yow.CoL(SelectionModes.ContinuousStream);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			array[num] = MoQ(array[num]);
		}
		using (CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			Ooo = true;
			yow.goI(array, P_1);
		}
	}

	internal void IoR(TextPositionRange P_0)
	{
		if (yow.Count > 1)
		{
			if (!(yow.Primary == P_0))
			{
				TextPositionRange[] array = yow.ToArray();
				array[yow.PrimaryIndex] = P_0;
				SelectRanges(array);
			}
		}
		else
		{
			PositionRange = P_0;
		}
	}

	public void AddRange(TextPositionRange P_0)
	{
		ToK(P_0, _0020: false);
	}

	public IEditorViewSelectionState CaptureState()
	{
		return CaptureState(TextRangeTrackingModes.ExpandBothEdges);
	}

	public IEditorViewSelectionState CaptureState(TextRangeTrackingModes P_0)
	{
		return poD(P_0, null);
	}

	public bool CodeBlockContract()
	{
		TextSnapshotRange textSnapshotRange = Uoj.xYa();
		if (textSnapshotRange.IsDeleted)
		{
			return false;
		}
		using (CreateBatch(EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory))
		{
			SelectRange(textSnapshotRange, SelectionModes.ContinuousStream);
		}
		return true;
	}

	public bool CodeBlockExpand()
	{
		TextSnapshotRange textSnapshotRange = Uoj.QYx(SnapshotRange);
		if (textSnapshotRange.IsDeleted)
		{
			return false;
		}
		using (CreateBatch(EditorViewSelectionBatchOptions.NoClearCodeBlockSelectionHistory))
		{
			SelectRange(textSnapshotRange, SelectionModes.ContinuousStream);
		}
		return true;
	}

	public void Collapse()
	{
		do6.ExecuteEditAction(EditorCommands.CollapseSelection);
	}

	public void CollapseLeft()
	{
		do6.ExecuteEditAction(EditorCommands.CollapseSelectionLeft);
	}

	public void CollapseRight()
	{
		do6.ExecuteEditAction(EditorCommands.CollapseSelectionRight);
	}

	public bool Contains(int P_0)
	{
		IList<TextRange> textRanges = GetTextRanges();
		if (textRanges != null)
		{
			foreach (TextRange item in textRanges)
			{
				if (item.Contains(P_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool Contains(TextPosition P_0)
	{
		foreach (TextPositionRange item in uoA())
		{
			if (item.Contains(P_0))
			{
				return true;
			}
		}
		return false;
	}

	public IList<double> GetPreferredCaretHorizontalLocations()
	{
		IList<double> list = yow.Yo0();
		if (list == null || list.Count != yow.Count)
		{
			list = new List<double>(yow.Count);
			for (int i = 0; i < yow.Count; i++)
			{
				list.Add(do6.YfA(yow[i].EndPosition));
			}
			yow.uoB(list);
		}
		return list;
	}

	public IList<TextRange> GetTextRanges()
	{
		return GetTextRanges(1);
	}

	public IList<TextRange> GetTextRanges(int P_0)
	{
		if (P_0 < 1)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(193470), SR.GetString(SRName.ExValueGreaterThanZero));
		}
		if (yow.Mode == SelectionModes.Block)
		{
			List<TextRange> list = new List<TextRange>();
			ITextViewLine textViewLine = do6.GetViewLine(FirstPosition);
			IList<Range> characterIndexRanges = do6.GetCharacterIndexRanges(PositionRange, P_0);
			foreach (Range item in characterIndexRanges)
			{
				int num = textViewLine.CharacterIndexToOffset(item.Min);
				int endOffset = ((item.Length == 0) ? num : textViewLine.CharacterIndexToOffset(item.Max));
				list.Add(new TextRange(num, endOffset));
				textViewLine = textViewLine.NextLine;
			}
			if (list.Count > 0)
			{
				return list.ToArray();
			}
		}
		else if (yow.Count > 1)
		{
			ITextSnapshot currentSnapshot = do6.CurrentSnapshot;
			TextRange[] array = new TextRange[yow.Count];
			for (int num2 = yow.Count - 1; num2 >= 0; num2--)
			{
				TextPositionRange textPositionRange = yow[num2];
				int num3 = do6.PositionToOffset(textPositionRange.FirstPosition);
				int endOffset2 = (textPositionRange.IsZeroLength ? num3 : do6.PositionToOffset(textPositionRange.LastPosition));
				array[num2] = new TextRange(num3, endOffset2);
			}
			return array;
		}
		return new TextRange[1] { TextRange };
	}

	public void MoveDown()
	{
		do6.ExecuteEditAction(EditorCommands.MoveDown);
	}

	public void MoveLeft()
	{
		do6.ExecuteEditAction(EditorCommands.MoveLeft);
	}

	public void MovePageDown()
	{
		do6.ExecuteEditAction(EditorCommands.MovePageDown);
	}

	public void MovePageUp()
	{
		do6.ExecuteEditAction(EditorCommands.MovePageUp);
	}

	public void MoveRight()
	{
		do6.ExecuteEditAction(EditorCommands.MoveRight);
	}

	public void MoveToDocumentEnd()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToDocumentEnd);
	}

	public void MoveToDocumentStart()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToDocumentStart);
	}

	public void MoveToLineEnd()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToLineEnd);
	}

	public void MoveToLineStart()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToLineStart);
	}

	public void MoveToLineStartAfterIndentation()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToLineStartAfterIndentation);
	}

	public void MoveToMatchingBracket()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToMatchingBracket);
	}

	public void MoveToNextLineStartAfterIndentation()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToNextLineStartAfterIndentation);
	}

	public void MoveToNextWord()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToNextWord);
	}

	public void MoveToPreviousLineStartAfterIndentation()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToPreviousLineStartAfterIndentation);
	}

	public void MoveToPreviousWord()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToPreviousWord);
	}

	public void MoveToVisibleBottom()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToVisibleBottom);
	}

	public void MoveToVisibleTop()
	{
		do6.ExecuteEditAction(EditorCommands.MoveToVisibleTop);
	}

	public void MoveUp()
	{
		do6.ExecuteEditAction(EditorCommands.MoveUp);
	}

	public void SelectAll()
	{
		do6.ExecuteEditAction(EditorCommands.SelectAll);
	}

	public void SelectBlockDown()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockDown);
	}

	public void SelectBlockLeft()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockLeft);
	}

	public void SelectBlockRight()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockRight);
	}

	public void SelectBlockToNextWord()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockToNextWord);
	}

	public void SelectBlockToPreviousWord()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockToPreviousWord);
	}

	public void SelectBlockUp()
	{
		do6.ExecuteEditAction(EditorCommands.SelectBlockUp);
	}

	public void SelectDown()
	{
		do6.ExecuteEditAction(EditorCommands.SelectDown);
	}

	public void SelectLeft()
	{
		do6.ExecuteEditAction(EditorCommands.SelectLeft);
	}

	public void SelectPageDown()
	{
		do6.ExecuteEditAction(EditorCommands.SelectPageDown);
	}

	public void SelectPageUp()
	{
		do6.ExecuteEditAction(EditorCommands.SelectPageUp);
	}

	public void SelectRanges(IEnumerable<TextPositionRange> P_0)
	{
		SelectRanges(P_0, null);
	}

	public void SelectRanges(IEnumerable<TextPositionRange> P_0, int? P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193498));
		}
		xo3(P_0, P_1);
	}

	public void SelectRight()
	{
		do6.ExecuteEditAction(EditorCommands.SelectRight);
	}

	public void SelectToDocumentEnd()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToDocumentEnd);
	}

	public void SelectToDocumentStart()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToDocumentStart);
	}

	public void SelectToLineEnd()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToLineEnd);
	}

	public void SelectToLineStart()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToLineStart);
	}

	public void SelectToLineStartAfterIndentation()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToLineStartAfterIndentation);
	}

	public void SelectToMatchingBracket()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToMatchingBracket);
	}

	public void SelectToNextWord()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToNextWord);
	}

	public void SelectToPreviousWord()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToPreviousWord);
	}

	public void SelectToVisibleBottom()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToVisibleBottom);
	}

	public void SelectToVisibleTop()
	{
		do6.ExecuteEditAction(EditorCommands.SelectToVisibleTop);
	}

	public void SelectUp()
	{
		do6.ExecuteEditAction(EditorCommands.SelectUp);
	}

	public void SelectWord()
	{
		do6.ExecuteEditAction(EditorCommands.SelectWord);
	}

	public bool ToggleRange(TextPositionRange P_0)
	{
		return ToK(P_0, _0020: true);
	}

	public void SelectRange(int P_0, int P_1)
	{
		SelectRange(new TextRange(P_0, P_0 + P_1), yow.Mode);
	}

	public void SelectRange(int P_0, int P_1, SelectionModes P_2)
	{
		SelectRange(new TextRange(P_0, P_0 + P_1), P_2);
	}

	public void SelectRange(TextRange P_0)
	{
		SelectRange(P_0, yow.Mode);
	}

	public void SelectRange(TextRange P_0, SelectionModes P_1)
	{
		TextRange textRange = Soe(P_0);
		TextPosition textPosition = do6.OffsetToPosition(textRange.StartOffset);
		TextPosition endPosition = (textRange.IsZeroLength ? textPosition : do6.OffsetToPosition(textRange.EndOffset));
		SelectRange(new TextPositionRange(textPosition, endPosition), P_1);
	}

	public void SelectRange(TextPosition P_0, TextPosition P_1)
	{
		SelectRange(new TextPositionRange(P_0, P_1), yow.Mode);
	}

	public void SelectRange(TextPositionRange P_0)
	{
		SelectRange(P_0, yow.Mode);
	}

	public void SelectRange(TextPosition P_0, TextPosition P_1, SelectionModes P_2)
	{
		SelectRange(new TextPositionRange(P_0, P_1), P_2);
	}

	public void SelectRange(TextPositionRange P_0, SelectionModes P_1)
	{
		VoF(P_0, P_1);
	}

	internal static bool QAX()
	{
		return uAr == null;
	}

	internal static zTV zAE()
	{
		return uAr;
	}
}
