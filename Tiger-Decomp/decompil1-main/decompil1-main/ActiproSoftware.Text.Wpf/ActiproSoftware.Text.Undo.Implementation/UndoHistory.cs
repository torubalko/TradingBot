using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Undo.Implementation;

internal class UndoHistory : IUndoHistory
{
	internal class LineUndoVersionSet : List<IList<int?>>
	{
		internal static LineUndoVersionSet rc9;

		public LineUndoVersionSet()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool ec8()
		{
			return rc9 == null;
		}

		internal static LineUndoVersionSet NcL()
		{
			return rc9;
		}
	}

	private int vBQ;

	private ITextDocument CBn;

	private bool kBG;

	private List<int?> fBe;

	private UndoableTextChangeStack aBy;

	private int qBz;

	private SavePointType k9S;

	private UndoableTextChangeStack R9V;

	private int r9B;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler B99;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<UndoRedoRequestEventArgs> T9A;

	internal static UndoHistory Pnc;

	internal SavePointType SavePointAvailable => k9S;

	public bool CanRedo => aBy.Count > 0;

	public bool CanUndo => R9V.Count > 0;

	public IUndoableTextChangeStack RedoStack => aBy;

	public IUndoableTextChangeStack UndoStack => R9V;

	public event EventHandler Cleared
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = B99;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref B99, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = B99;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref B99, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<UndoRedoRequestEventArgs> UndoRedoRequested
	{
		[CompilerGenerated]
		add
		{
			EventHandler<UndoRedoRequestEventArgs> eventHandler = T9A;
			EventHandler<UndoRedoRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UndoRedoRequestEventArgs> value2 = (EventHandler<UndoRedoRequestEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref T9A, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<UndoRedoRequestEventArgs> eventHandler = T9A;
			EventHandler<UndoRedoRequestEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UndoRedoRequestEventArgs> value2 = (EventHandler<UndoRedoRequestEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref T9A, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	internal UndoHistory(ITextDocument document)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		vBQ = 1;
		k9S = SavePointType.Original;
		base._002Ector();
		CBn = document;
		R9V = new UndoableTextChangeStack
		{
			ContainsOrigin = true
		};
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		aBy = new UndoableTextChangeStack();
		r9B = R9V.Capacity;
		aBy.CapacityChanged += PBN;
		R9V.CapacityChanged += FBR;
		document.IsModifiedChanged += vBJ;
		document.AddTextChangedEventHandler(fBX, EventHandlerPriority.High);
	}

	private void xB1(ITextChange P_0, LineUndoVersionSet P_1)
	{
		UndoableTextChange textChange = new UndoableTextChange(P_0, P_1);
		bool flag = P_0.CanMergeIntoPreviousChange && !P_0.IsUndo && !P_0.IsRedo;
		if (R9V.Count > 0 && (flag || !R9V.IsAtSavePoint) && R9V.Peek() is UndoableTextChange undoableTextChange && undoableTextChange.Merge(P_0, P_1, flag))
		{
			R9V.Pop();
			textChange = undoableTextChange;
		}
		if (R9V.Push(textChange) && k9S == SavePointType.Original)
		{
			k9S = SavePointType.None;
		}
		aBy.Clear(containsOrigin: false);
	}

	private IList<int?> yB4(int P_0, int P_1, int P_2, bool P_3, int? P_4)
	{
		if (fBe == null)
		{
			fBe = new List<int?>();
		}
		int?[] array = new int?[P_1 + 1];
		for (int num = P_1; num >= 0; num--)
		{
			int? num2 = UBr(P_0 + num);
			array[num] = num2;
		}
		int num3 = P_0 + P_1 + 1;
		while (num3 > fBe.Count)
		{
			fBe.Add(null);
		}
		int num4 = P_2 - P_1;
		if (num4 > 0)
		{
			fBe.InsertRange(P_0 + 1, new int?[num4]);
		}
		else if (num4 < 0)
		{
			fBe.RemoveRange(P_0 + 1, -num4);
		}
		if (P_3)
		{
			for (int i = P_0; i <= P_0 + P_2; i++)
			{
				fBe[i] = P_4;
			}
		}
		return array;
	}

	private void iBK(UndoableTextChange P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		IList<ITextChangeOperation> operations = P_0.Operations;
		if (operations == null)
		{
			return;
		}
		LineUndoVersionSet versionSet = P_0.VersionSet;
		LineUndoVersionSet lineUndoVersionSet = (P_0.VersionSet = new LineUndoVersionSet());
		for (int i = 0; i < operations.Count; i++)
		{
			ITextChangeOperation textChangeOperation = operations[i];
			IList<int?> item = yB4(textChangeOperation.StartPosition.Line, textChangeOperation.LinesDeleted, textChangeOperation.LinesInserted, _0020: false, null);
			lineUndoVersionSet?.Add(item);
			if (versionSet == null)
			{
				continue;
			}
			item = versionSet[i];
			int line = textChangeOperation.StartPosition.Line;
			if (item == null || line + item.Count > fBe.Count)
			{
				continue;
			}
			for (int num = item.Count - 1; num >= 0; num--)
			{
				int? value = item[num];
				if (value.HasValue && k9S == SavePointType.UndoTextChange)
				{
					value = qBz + 1;
				}
				fBe[line + num] = value;
			}
		}
	}

	private void wBk(UndoableTextChange P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		IList<ITextChangeOperation> operations = P_0.Operations;
		if (operations == null)
		{
			return;
		}
		LineUndoVersionSet versionSet = P_0.VersionSet;
		LineUndoVersionSet lineUndoVersionSet = (P_0.VersionSet = new LineUndoVersionSet());
		for (int num = operations.Count - 1; num >= 0; num--)
		{
			ITextChangeOperation textChangeOperation = operations[num];
			IList<int?> item = yB4(textChangeOperation.StartPosition.Line, textChangeOperation.LinesInserted, textChangeOperation.LinesDeleted, _0020: false, null);
			lineUndoVersionSet?.Add(item);
			if (versionSet != null)
			{
				item = versionSet[num];
				int line = textChangeOperation.StartPosition.Line;
				if (item != null && line + item.Count <= fBe.Count)
				{
					for (int num2 = item.Count - 1; num2 >= 0; num2--)
					{
						int? value = item[num2];
						if (!value.HasValue && k9S == SavePointType.RedoTextChange)
						{
							value = 0;
						}
						fBe[line + num2] = value;
					}
				}
			}
		}
		lineUndoVersionSet.Reverse();
	}

	private void qBE(bool P_0)
	{
		k9S = (P_0 ? SavePointType.Original : SavePointType.None);
		R9V.Clear(P_0);
		aBy.Clear(containsOrigin: false);
		if (P_0)
		{
			fBf();
		}
	}

	private int? UBr(int P_0)
	{
		if (fBe != null && P_0 < fBe.Count)
		{
			return fBe[P_0];
		}
		return null;
	}

	private void XB3()
	{
		if (R9V.Count > 0 || !R9V.ContainsOrigin)
		{
			k9S = SavePointType.UndoTextChange;
			R9V.IsAtSavePoint = true;
			aBy.IsAtSavePoint = false;
			qBz = vBQ++;
			if (fBe == null)
			{
				return;
			}
			for (int i = 0; i < fBe.Count; i++)
			{
				if (fBe[i].HasValue)
				{
					fBe[i] = qBz;
				}
			}
		}
		else
		{
			k9S = SavePointType.Original;
			R9V.IsAtSavePoint = false;
			aBy.IsAtSavePoint = false;
			fBf();
		}
	}

	private void vBJ(object P_0, EventArgs P_1)
	{
		if (!kBG && !CBn.IsModified)
		{
			XB3();
		}
	}

	private void fBX(object P_0, TextSnapshotChangedEventArgs P_1)
	{
		IList<ITextChangeOperation> operations = P_1.TextChange.Operations;
		if (P_1.TextChange.IsUndo || P_1.TextChange.IsRedo)
		{
			return;
		}
		int num = 2;
		if (!Vnf())
		{
			num = 2;
		}
		int num3 = default(int);
		LineUndoVersionSet lineUndoVersionSet;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (operations.Count == 0)
				{
					return;
				}
				num2 = operations.Count - 1;
				num = 0;
				if (qnM() != null)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
			while (num2 >= 0 && !operations[num2].IsProgrammaticTextReplacement)
			{
				num2--;
			}
			if (num2 > -1)
			{
				qBE(_0020: true);
				if (num2 == operations.Count - 1)
				{
					num = 1;
					if (!Vnf())
					{
						num = num3;
					}
					continue;
				}
			}
			if (vBQ < int.MaxValue)
			{
				vBQ++;
			}
			lineUndoVersionSet = new LineUndoVersionSet();
			for (num2++; num2 < operations.Count; num2++)
			{
				ITextChangeOperation textChangeOperation = operations[num2];
				lineUndoVersionSet.Add(yB4(textChangeOperation.StartPosition.Line, textChangeOperation.LinesDeleted, textChangeOperation.LinesInserted, _0020: true, vBQ));
			}
			break;
		}
		xB1(P_1.TextChange, lineUndoVersionSet);
	}

	private void PBN(object P_0, EventArgs P_1)
	{
		SavePointType savePointType = k9S;
		SavePointType savePointType2 = savePointType;
		if (savePointType2 == SavePointType.RedoTextChange && !aBy.ContainsSavePoint)
		{
			k9S = SavePointType.None;
		}
	}

	private void FBR(object P_0, EventArgs P_1)
	{
		if (k9S == SavePointType.Original && R9V.Capacity < r9B)
		{
			k9S = SavePointType.None;
		}
		r9B = R9V.Capacity;
	}

	private void fBf()
	{
		fBe = null;
		qBz = 0;
		vBQ = 1;
	}

	private void GBt()
	{
		switch (k9S)
		{
		case SavePointType.UndoTextChange:
			if (!R9V.ContainsSavePoint)
			{
				k9S = SavePointType.None;
			}
			break;
		case SavePointType.Original:
			k9S = SavePointType.None;
			break;
		}
	}

	public void Clear()
	{
		Clear(resetChangeTracking: false);
	}

	public void Clear(bool resetChangeTracking)
	{
		qBE(resetChangeTracking);
		OnCleared(EventArgs.Empty);
	}

	public SavePointChangeType GetChangeTypeForLineRange(int startLineIndex, int endLineIndex)
	{
		SavePointChangeType result = SavePointChangeType.None;
		if (fBe != null)
		{
			int count = fBe.Count;
			for (int i = startLineIndex; i <= endLineIndex && i < count; i++)
			{
				int? num = UBr(i);
				if (!num.HasValue)
				{
					continue;
				}
				bool flag = num != 0;
				bool flag2 = num != qBz;
				if (!flag)
				{
					if (flag2)
					{
						result = SavePointChangeType.RevertedChanges;
						break;
					}
					continue;
				}
				if (flag2)
				{
					result = SavePointChangeType.UnsavedChanges;
					break;
				}
				result = SavePointChangeType.SavedChanges;
			}
		}
		return result;
	}

	protected virtual void OnCleared(EventArgs e)
	{
		B99?.Invoke(this, e);
	}

	protected virtual void OnUndoRedoRequested(UndoRedoRequestEventArgs e)
	{
		T9A?.Invoke(this, e);
	}

	public bool Redo()
	{
		return Redo(1) > 0;
	}

	public int Redo(int count)
	{
		int num = 0;
		bool isAtSavePoint = default(bool);
		int num3 = default(int);
		int result = default(int);
		while (count-- > 0)
		{
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (aBy.Count <= 0)
					{
						break;
					}
					isAtSavePoint = aBy.IsAtSavePoint;
					num2 = 0;
					if (!Vnf())
					{
						num2 = num3;
					}
					continue;
				case 1:
					return result;
				default:
				{
					UndoableTextChange undoableTextChange = aBy.Pop() as UndoableTextChange;
					UndoRedoRequestEventArgs e = new UndoRedoRequestEventArgs(null, undoableTextChange, isUndo: false);
					try
					{
						kBG = true;
						OnUndoRedoRequested(e);
					}
					finally
					{
						kBG = false;
					}
					if (e.Cancel)
					{
						aBy.Push(undoableTextChange);
						break;
					}
					iBK(undoableTextChange);
					if (R9V.Push(e.TextChange))
					{
						GBt();
					}
					if (isAtSavePoint)
					{
						k9S = SavePointType.UndoTextChange;
						R9V.IsAtSavePoint = true;
					}
					try
					{
						kBG = true;
						CBn.IsModified = !isAtSavePoint;
					}
					finally
					{
						kBG = false;
					}
					goto end_IL_0009;
				}
				}
				goto end_IL_0083;
				continue;
				end_IL_0009:
				break;
			}
			num++;
			continue;
			end_IL_0083:
			break;
		}
		return num;
	}

	public bool Undo()
	{
		return Undo(1) > 0;
	}

	public int Undo(int count)
	{
		int num = 0;
		while (count-- > 0 && R9V.Count > 0)
		{
			bool isAtSavePoint = R9V.IsAtSavePoint;
			UndoableTextChange undoableTextChange = R9V.Pop() as UndoableTextChange;
			UndoRedoRequestEventArgs e = new UndoRedoRequestEventArgs(null, undoableTextChange, isUndo: true);
			try
			{
				kBG = true;
				OnUndoRedoRequested(e);
			}
			finally
			{
				kBG = false;
			}
			if (e.Cancel)
			{
				R9V.Push(undoableTextChange);
				break;
			}
			aBy.Push(e.TextChange);
			if (isAtSavePoint)
			{
				k9S = SavePointType.RedoTextChange;
				aBy.IsAtSavePoint = true;
			}
			wBk(undoableTextChange);
			num++;
		}
		return num;
	}

	internal static bool Vnf()
	{
		return Pnc == null;
	}

	internal static UndoHistory qnM()
	{
		return Pnc;
	}
}
