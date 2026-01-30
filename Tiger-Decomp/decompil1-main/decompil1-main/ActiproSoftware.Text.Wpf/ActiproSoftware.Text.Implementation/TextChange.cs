using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextChange : ITextChange
{
	[Flags]
	private enum H0
	{

	}

	private class yv
	{
		private H0 dsv;

		private static yv VMu;

		internal bool bsZ(H0 P_0)
		{
			return (dsv & P_0) == P_0;
		}

		internal void Gs0(H0 P_0, bool P_1)
		{
			if (P_1)
			{
				dsv |= P_0;
			}
			else
			{
				dsv &= ~P_0;
			}
		}

		public yv()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool IMR()
		{
			return VMu == null;
		}

		internal static yv TM0()
		{
			return VMu;
		}
	}

	private interface UY
	{
		int Apply(int P_0, int P_1, int P_2);
	}

	private class No : UY
	{
		private int PsY;

		private int Cso;

		private static No oMK;

		public int Apply(int P_0, int P_1, int P_2)
		{
			int result;
			if (P_1 > 0 || P_2 > 0)
			{
				if (P_0 < PsY)
				{
					throw new ArgumentException(SR.GetString(SRName.ExTextChangeOffsetDeltaSequentialOnlyInvalidOperation), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5930));
				}
				PsY = Math.Max(PsY, P_0);
				P_0 += Cso;
				Cso += P_2 - P_1;
				result = P_0;
			}
			else
			{
				result = P_0 + Cso;
				int num = 0;
				if (!zMl())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return result;
		}

		public No()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool zMl()
		{
			return oMK == null;
		}

		internal static No EMo()
		{
			return oMK;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public IList<TextRange> esD;

		public TextRangeTrackingModes? As1;

		public TextChange ws4;

		public int HsK;

		private static _003C_003Ec__DisplayClass13_0 cMI;

		public _003C_003Ec__DisplayClass13_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool bMH()
		{
			return cMI == null;
		}

		internal static _003C_003Ec__DisplayClass13_0 eM6()
		{
			return cMI;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public ITextSnapshot ssE;

		public _003C_003Ec__DisplayClass13_0 lsr;

		private static _003C_003Ec__DisplayClass13_1 MME;

		public _003C_003Ec__DisplayClass13_1()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void nsk(ITextSnapshot pendingSnapshot)
		{
			TextPositionRange[] array = new TextPositionRange[lsr.esD.Count];
			for (int i = 0; i < lsr.esD.Count; i++)
			{
				TextRange textRange = lsr.esD[i];
				if (lsr.As1.HasValue)
				{
					textRange = textRange.Translate(ssE, pendingSnapshot, lsr.As1.Value);
				}
				TextPositionRange textPositionRange = pendingSnapshot.TextRangeToPositionRange(textRange);
				array[i] = textPositionRange;
			}
			lsr.ws4.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array, lsr.HsK);
		}

		internal static bool rMG()
		{
			return MME == null;
		}

		internal static _003C_003Ec__DisplayClass13_1 sMh()
		{
			return MME;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ITextPositionRangeCollection Ms3;

		public TextRangeTrackingModes nsJ;

		public TextChange rsX;

		internal static _003C_003Ec__DisplayClass14_0 GMQ;

		public _003C_003Ec__DisplayClass14_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool OMx()
		{
			return GMQ == null;
		}

		internal static _003C_003Ec__DisplayClass14_0 vMT()
		{
			return GMQ;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public ITextSnapshot QsR;

		public _003C_003Ec__DisplayClass14_0 Isf;

		internal static _003C_003Ec__DisplayClass14_1 DMk;

		public _003C_003Ec__DisplayClass14_1()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void PsN(ITextSnapshot pendingSnapshot)
		{
			TextPositionRange[] array = Isf.Ms3.ToArray();
			for (int num = array.Length - 1; num >= 0; num--)
			{
				TextPositionRange positionRange = array[num];
				int num2 = Math.Max(0, positionRange.StartPosition.Line + 1 - QsR.Lines.Count);
				int num3 = Math.Max(0, (num2 > 0) ? positionRange.StartPosition.Character : (positionRange.StartPosition.Character - QsR.Lines[positionRange.StartPosition.Line].Length));
				int num4;
				int num5;
				if (positionRange.IsZeroLength)
				{
					num4 = num2;
					num5 = num3;
				}
				else
				{
					num4 = Math.Max(0, positionRange.EndPosition.Line + 1 - QsR.Lines.Count);
					num5 = Math.Max(0, (num4 > 0) ? positionRange.EndPosition.Character : (positionRange.EndPosition.Character - QsR.Lines[positionRange.EndPosition.Line].Length));
				}
				TextRange textRange = QsR.PositionRangeToTextRange(positionRange);
				TextSnapshotRange textSnapshotRange = new TextSnapshotRange(QsR, textRange).TranslateTo(pendingSnapshot, Isf.nsJ);
				TextPosition textPosition = new TextPosition(textSnapshotRange.EndPosition.Line + num4, textSnapshotRange.EndPosition.Character + num5);
				TextPosition textPosition2 = new TextPosition(textSnapshotRange.StartPosition.Line + num2, textSnapshotRange.StartPosition.Character + num3);
				if (!textRange.IsNormalized)
				{
					TextPosition textPosition3 = textPosition2;
					textPosition2 = textPosition;
					textPosition = textPosition3;
				}
				array[num] = new TextPositionRange(textPosition2, textPosition);
			}
			if (Isf.Ms3.IsBlock)
			{
				Isf.rsX.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array[0], isBlock: true);
			}
			else
			{
				Isf.rsX.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array, Isf.Ms3.PrimaryIndex);
			}
		}

		internal static bool UMX()
		{
			return DMk == null;
		}

		internal static _003C_003Ec__DisplayClass14_1 CM3()
		{
			return DMk;
		}
	}

	private yv acv;

	private UY QcY;

	private List<ITextChangeOperation> aco;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object BcD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextPositionRangeCollection Vc1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextPositionRangeCollection pc4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextSnapshot pcK;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object Yck;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextChangeType dcE;

	private static TextChange lUp;

	public bool CanMergeIntoPreviousChange => acv.bsZ((H0)128);

	public bool CheckReadOnly => acv.bsZ((H0)8);

	public object CustomData
	{
		[CompilerGenerated]
		get
		{
			return BcD;
		}
		[CompilerGenerated]
		set
		{
			BcD = value;
		}
	}

	public bool IsMerged => acv.bsZ((H0)256);

	public bool IsRedo => acv.bsZ((H0)2);

	public bool IsUndo => acv.bsZ((H0)1);

	public int LastTextReplacementOperationIndex
	{
		get
		{
			for (int num = aco.Count - 1; num >= 0; num--)
			{
				if (aco[num].IsTextReplacement)
				{
					return num;
				}
			}
			return -1;
		}
	}

	public IList<ITextChangeOperation> Operations => new ReadOnlyCollection<ITextChangeOperation>(aco);

	public ITextPositionRangeCollection PostSelectionPositionRanges
	{
		[CompilerGenerated]
		get
		{
			return Vc1;
		}
		[CompilerGenerated]
		set
		{
			Vc1 = value;
		}
	}

	public ITextPositionRangeCollection PreSelectionPositionRanges
	{
		[CompilerGenerated]
		get
		{
			return pc4;
		}
		[CompilerGenerated]
		set
		{
			pc4 = value;
		}
	}

	public bool RetainSelection => acv.bsZ((H0)4);

	public ITextSnapshot Snapshot
	{
		[CompilerGenerated]
		get
		{
			return pcK;
		}
		[CompilerGenerated]
		private set
		{
			pcK = value;
		}
	}

	public object Source
	{
		[CompilerGenerated]
		get
		{
			return Yck;
		}
		[CompilerGenerated]
		private set
		{
			Yck = value;
		}
	}

	public ITextChangeType Type
	{
		[CompilerGenerated]
		get
		{
			return dcE;
		}
		[CompilerGenerated]
		private set
		{
			dcE = value;
		}
	}

	internal TextChange(ITextSnapshot snapshot, ITextChangeType type, ITextChangeOptions options)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(snapshot, type, options, isUndo: false, isRedo: false, isMerged: false);
	}

	internal TextChange(ITextSnapshot snapshot, ITextChangeType type, ITextChangeOptions options, bool isUndo, bool isRedo, bool isMerged)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		acv = new yv();
		aco = new List<ITextChangeOperation>();
		base._002Ector();
		if (type == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8776));
		}
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (!(snapshot.Document is TextDocumentBase))
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextSnapshotRequiresTextDocumentBase), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		Snapshot = snapshot;
		Type = type;
		if (isUndo)
		{
			acv.Gs0((H0)1, _0020: true);
		}
		if (isRedo)
		{
			acv.Gs0((H0)2, _0020: true);
		}
		if (isMerged)
		{
			acv.Gs0((H0)256, _0020: true);
		}
		switch (snapshot.Document.AutoCharacterCasing)
		{
		case CharacterCasing.Upper:
			acv.Gs0((H0)32, _0020: true);
			break;
		case CharacterCasing.Lower:
			acv.Gs0((H0)64, _0020: true);
			break;
		}
		if (options != null)
		{
			if (options.CanMergeIntoPreviousChange)
			{
				acv.Gs0((H0)128, _0020: true);
			}
			if (options.RetainSelection)
			{
				acv.Gs0((H0)4, _0020: true);
			}
			if (options.CheckReadOnly)
			{
				acv.Gs0((H0)8, _0020: true);
			}
			if (options.OffsetDelta == TextChangeOffsetDelta.SequentialOnly)
			{
				acv.Gs0((H0)16, _0020: true);
				QcY = new No();
			}
			Source = options.Source;
			CustomData = options.CustomData;
		}
	}

	private bool Sc5(int P_0, int P_1, string P_2, bool P_3, bool P_4)
	{
		P_2 = TextChangeOperation.ScrubInsertedText(P_2);
		if (P_2 != null)
		{
			if (acv.bsZ((H0)32))
			{
				P_2 = P_2.ToUpper(CultureInfo.CurrentCulture);
			}
			else if (acv.bsZ((H0)64))
			{
				P_2 = P_2.ToLower(CultureInfo.CurrentCulture);
			}
		}
		if (QcY != null)
		{
			P_0 = QcY.Apply(P_0, P_1, P_2?.Length ?? 0);
		}
		bool isIgnoredForTranslation = Type == TextChangeTypes.ChangeCase && P_1 == (P_2?.Length ?? 0);
		ITextChangeOperation item = new TextChangeOperation(P_0, P_1, P_2, P_3, P_4, isIgnoredForTranslation);
		aco.Add(item);
		return true;
	}

	internal void ReplaceOperation(int index, TextChangeOperation operation)
	{
		aco[index] = operation;
	}

	public void AppendText(string text)
	{
		InsertText(Snapshot.Length, text);
	}

	public bool Apply()
	{
		if (Snapshot.Document is TextDocumentBase textDocumentBase)
		{
			return textDocumentBase.ApplyTextChange(this);
		}
		return false;
	}

	public bool Apply(IList<TextRange> pendingSelectionTextRanges, int primaryIndex, TextRangeTrackingModes? translationTrackingModes)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.esD = pendingSelectionTextRanges;
		_003C_003Ec__DisplayClass13_.As1 = translationTrackingModes;
		_003C_003Ec__DisplayClass13_.ws4 = this;
		_003C_003Ec__DisplayClass13_.HsK = primaryIndex;
		if (Snapshot.Document is TextDocumentBase textDocumentBase)
		{
			Action<ITextSnapshot> snapshotCreatedAction = null;
			if (_003C_003Ec__DisplayClass13_.esD != null && _003C_003Ec__DisplayClass13_.esD.Count > 0)
			{
				_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass13_1();
				CS_0024_003C_003E8__locals10.lsr = _003C_003Ec__DisplayClass13_;
				CS_0024_003C_003E8__locals10.ssE = Snapshot;
				snapshotCreatedAction = delegate(ITextSnapshot pendingSnapshot)
				{
					TextPositionRange[] array = new TextPositionRange[CS_0024_003C_003E8__locals10.lsr.esD.Count];
					for (int i = 0; i < CS_0024_003C_003E8__locals10.lsr.esD.Count; i++)
					{
						TextRange textRange = CS_0024_003C_003E8__locals10.lsr.esD[i];
						if (CS_0024_003C_003E8__locals10.lsr.As1.HasValue)
						{
							textRange = textRange.Translate(CS_0024_003C_003E8__locals10.ssE, pendingSnapshot, CS_0024_003C_003E8__locals10.lsr.As1.Value);
						}
						TextPositionRange textPositionRange = pendingSnapshot.TextRangeToPositionRange(textRange);
						array[i] = textPositionRange;
					}
					CS_0024_003C_003E8__locals10.lsr.ws4.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array, CS_0024_003C_003E8__locals10.lsr.HsK);
				};
			}
			return textDocumentBase.ApplyTextChange(this, snapshotCreatedAction);
		}
		return false;
	}

	public bool Apply(ITextPositionRangeCollection pendingSelectionPositionRanges, TextRangeTrackingModes translationTrackingModes)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_.Ms3 = pendingSelectionPositionRanges;
		_003C_003Ec__DisplayClass14_.nsJ = translationTrackingModes;
		_003C_003Ec__DisplayClass14_.rsX = this;
		int num = 0;
		if (!gUm())
		{
			int num2 = default(int);
			num = num2;
		}
		TextDocumentBase textDocumentBase = default(TextDocumentBase);
		while (true)
		{
			Action<ITextSnapshot> snapshotCreatedAction;
			switch (num)
			{
			case 1:
			{
				_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass14_1();
				CS_0024_003C_003E8__locals14.Isf = _003C_003Ec__DisplayClass14_;
				CS_0024_003C_003E8__locals14.QsR = Snapshot;
				snapshotCreatedAction = delegate(ITextSnapshot pendingSnapshot)
				{
					TextPositionRange[] array = CS_0024_003C_003E8__locals14.Isf.Ms3.ToArray();
					for (int num3 = array.Length - 1; num3 >= 0; num3--)
					{
						TextPositionRange positionRange = array[num3];
						int num4 = Math.Max(0, positionRange.StartPosition.Line + 1 - CS_0024_003C_003E8__locals14.QsR.Lines.Count);
						int num5 = Math.Max(0, (num4 > 0) ? positionRange.StartPosition.Character : (positionRange.StartPosition.Character - CS_0024_003C_003E8__locals14.QsR.Lines[positionRange.StartPosition.Line].Length));
						int num6;
						int num7;
						if (positionRange.IsZeroLength)
						{
							num6 = num4;
							num7 = num5;
						}
						else
						{
							num6 = Math.Max(0, positionRange.EndPosition.Line + 1 - CS_0024_003C_003E8__locals14.QsR.Lines.Count);
							num7 = Math.Max(0, (num6 > 0) ? positionRange.EndPosition.Character : (positionRange.EndPosition.Character - CS_0024_003C_003E8__locals14.QsR.Lines[positionRange.EndPosition.Line].Length));
						}
						TextRange textRange = CS_0024_003C_003E8__locals14.QsR.PositionRangeToTextRange(positionRange);
						TextSnapshotRange textSnapshotRange = new TextSnapshotRange(CS_0024_003C_003E8__locals14.QsR, textRange).TranslateTo(pendingSnapshot, CS_0024_003C_003E8__locals14.Isf.nsJ);
						TextPosition textPosition = new TextPosition(textSnapshotRange.EndPosition.Line + num6, textSnapshotRange.EndPosition.Character + num7);
						TextPosition textPosition2 = new TextPosition(textSnapshotRange.StartPosition.Line + num4, textSnapshotRange.StartPosition.Character + num5);
						if (!textRange.IsNormalized)
						{
							TextPosition textPosition3 = textPosition2;
							textPosition2 = textPosition;
							textPosition = textPosition3;
						}
						array[num3] = new TextPositionRange(textPosition2, textPosition);
					}
					if (CS_0024_003C_003E8__locals14.Isf.Ms3.IsBlock)
					{
						CS_0024_003C_003E8__locals14.Isf.rsX.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array[0], isBlock: true);
					}
					else
					{
						CS_0024_003C_003E8__locals14.Isf.rsX.PostSelectionPositionRanges = TextPositionRange.CreateCollection(array, CS_0024_003C_003E8__locals14.Isf.Ms3.PrimaryIndex);
					}
				};
				goto IL_0131;
			}
			default:
				{
					textDocumentBase = Snapshot.Document as TextDocumentBase;
					if (textDocumentBase == null)
					{
						return false;
					}
					snapshotCreatedAction = null;
					if (_003C_003Ec__DisplayClass14_.Ms3 != null && _003C_003Ec__DisplayClass14_.Ms3.Count > 0)
					{
						num = 1;
						if (!gUm())
						{
							num = 1;
						}
						break;
					}
					goto IL_0131;
				}
				IL_0131:
				return textDocumentBase.ApplyTextChange(this, snapshotCreatedAction);
			}
		}
	}

	public void DeleteText(TextRange textRange)
	{
		ReplaceText(textRange.FirstOffset, textRange.AbsoluteLength, null);
	}

	public void DeleteText(int offset, int deleteLength)
	{
		ReplaceText(offset, deleteLength, null);
	}

	public void InsertText(int offset, string text)
	{
		ReplaceText(offset, 0, text);
	}

	public void ReplaceText(TextRange textRange, string insertText)
	{
		ReplaceText(textRange.FirstOffset, textRange.AbsoluteLength, insertText);
	}

	public void ReplaceText(int offset, int deleteLength, string insertText)
	{
		bool flag = false;
		if (offset == 0)
		{
			int num = deleteLength;
			if (num > 0 && QcY != null)
			{
				num = QcY.Apply(num, 0, 0);
			}
			flag = num > 0 && num == Snapshot.Length;
		}
		Sc5(offset, deleteLength, insertText, flag, _0020: false);
	}

	public void SetText(string text)
	{
		SetText(text, isProgrammatic: true);
	}

	public void SetText(string text, bool isProgrammatic)
	{
		Sc5(0, Snapshot.Length, text, _0020: true, isProgrammatic);
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8788) + Type.Key + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool gUm()
	{
		return lUp == null;
	}

	internal static TextChange BUS()
	{
		return lUp;
	}
}
