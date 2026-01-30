using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class TextSnapshotRangeEventArgs : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextSnapshotRange XVa;

	private static TextSnapshotRangeEventArgs ftG;

	public TextSnapshotRange SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return XVa;
		}
		[CompilerGenerated]
		private set
		{
			XVa = value;
		}
	}

	public TextSnapshotRangeEventArgs(TextSnapshotRange snapshotRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		SnapshotRange = snapshotRange;
	}

	internal static bool bth()
	{
		return ftG == null;
	}

	internal static TextSnapshotRangeEventArgs YtQ()
	{
		return ftG;
	}
}
