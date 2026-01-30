using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class TextSnapshotChangedEventArgs : EventArgs
{
	private TextSnapshotRange? QVm;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot QVc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextSnapshot wVh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextChange oVd;

	private static TextSnapshotChangedEventArgs MtR;

	public TextSnapshotRange ChangedSnapshotRange
	{
		get
		{
			if (!QVm.HasValue)
			{
				QVm = nVu();
			}
			return QVm.Value;
		}
	}

	public ITextSnapshot NewSnapshot
	{
		[CompilerGenerated]
		get
		{
			return QVc;
		}
		[CompilerGenerated]
		private set
		{
			QVc = value;
		}
	}

	public ITextSnapshot OldSnapshot
	{
		[CompilerGenerated]
		get
		{
			return wVh;
		}
		[CompilerGenerated]
		private set
		{
			wVh = value;
		}
	}

	public ITextChange TextChange
	{
		[CompilerGenerated]
		get
		{
			return oVd;
		}
		[CompilerGenerated]
		private set
		{
			oVd = value;
		}
	}

	public TextSnapshotChangedEventArgs(ITextSnapshot oldSnapshot, ITextSnapshot newSnapshot, ITextChange textChange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		OldSnapshot = oldSnapshot;
		NewSnapshot = newSnapshot;
		TextChange = textChange;
	}

	private TextSnapshotRange nVu()
	{
		if (TextChange != null)
		{
			int num = int.MaxValue;
			int num2 = 0;
			for (int num3 = TextChange.Operations.Count - 1; num3 >= 0; num3--)
			{
				ITextChangeOperation textChangeOperation = TextChange.Operations[num3];
				if (textChangeOperation.IsTextReplacement)
				{
					return NewSnapshot.SnapshotRange;
				}
				num = Math.Min(num, textChangeOperation.StartOffset);
				num2 = Math.Max(num2, Math.Max(textChangeOperation.DeletionEndOffset, textChangeOperation.InsertionEndOffset));
			}
			if (num != int.MaxValue)
			{
				return new TextSnapshotRange(NewSnapshot, num, num2);
			}
		}
		return TextSnapshotRange.Deleted;
	}

	internal static bool vt0()
	{
		return MtR == null;
	}

	internal static TextSnapshotChangedEventArgs LtN()
	{
		return MtR;
	}
}
