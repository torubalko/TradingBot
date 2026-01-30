using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Undo;

public class UndoRedoRequestEventArgs : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool PBH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextDocument zBP;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool DBp;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IUndoableTextChange TBb;

	internal static UndoRedoRequestEventArgs Pnt;

	internal bool Cancel
	{
		[CompilerGenerated]
		get
		{
			return PBH;
		}
		[CompilerGenerated]
		set
		{
			PBH = value;
		}
	}

	public ITextDocument Document
	{
		[CompilerGenerated]
		get
		{
			return zBP;
		}
		[CompilerGenerated]
		private set
		{
			zBP = value;
		}
	}

	public bool IsUndo
	{
		[CompilerGenerated]
		get
		{
			return DBp;
		}
		[CompilerGenerated]
		private set
		{
			DBp = value;
		}
	}

	public IUndoableTextChange TextChange
	{
		[CompilerGenerated]
		get
		{
			return TBb;
		}
		[CompilerGenerated]
		internal set
		{
			TBb = value;
		}
	}

	public UndoRedoRequestEventArgs(ITextDocument document, IUndoableTextChange textChange, bool isUndo)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Document = document;
		TextChange = textChange;
		IsUndo = isUndo;
	}

	internal static bool jnW()
	{
		return Pnt == null;
	}

	internal static UndoRedoRequestEventArgs pnn()
	{
		return Pnt;
	}
}
