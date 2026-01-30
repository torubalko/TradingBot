using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class TextSnapshotReaderOptions : ITextSnapshotReaderOptions
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Yd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int fL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextScanDirection? lq;

	private static TextSnapshotReaderOptions iT;

	public int DefaultTokenLoadBufferLength
	{
		[CompilerGenerated]
		get
		{
			return Yd;
		}
		[CompilerGenerated]
		set
		{
			Yd = value;
		}
	}

	public int InitialTokenLoadBufferLength
	{
		[CompilerGenerated]
		get
		{
			return fL;
		}
		[CompilerGenerated]
		set
		{
			fL = value;
		}
	}

	public TextScanDirection? PrimaryScanDirection
	{
		[CompilerGenerated]
		get
		{
			return lq;
		}
		[CompilerGenerated]
		set
		{
			lq = value;
		}
	}

	internal TextSnapshotReaderOptions()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		InitialTokenLoadBufferLength = 100;
		DefaultTokenLoadBufferLength = 700;
	}

	internal static bool xk()
	{
		return iT == null;
	}

	internal static TextSnapshotReaderOptions dX()
	{
		return iT;
	}
}
