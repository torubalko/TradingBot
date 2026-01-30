using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class TextSnapshotChangingEventArgs : CancelEventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot JVI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot EV7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextChange hVM;

	internal static TextSnapshotChangingEventArgs Otr;

	public ITextSnapshot NewSnapshot
	{
		[CompilerGenerated]
		get
		{
			return JVI;
		}
		[CompilerGenerated]
		private set
		{
			JVI = value;
		}
	}

	public ITextSnapshot OldSnapshot
	{
		[CompilerGenerated]
		get
		{
			return EV7;
		}
		[CompilerGenerated]
		private set
		{
			EV7 = value;
		}
	}

	public ITextChange TextChange
	{
		[CompilerGenerated]
		get
		{
			return hVM;
		}
		[CompilerGenerated]
		private set
		{
			hVM = value;
		}
	}

	public TextSnapshotChangingEventArgs(ITextSnapshot oldSnapshot, ITextSnapshot newSnapshot, ITextChange textChange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		OldSnapshot = oldSnapshot;
		NewSnapshot = newSnapshot;
		TextChange = textChange;
	}

	internal static bool otj()
	{
		return Otr == null;
	}

	internal static TextSnapshotChangingEventArgs dtK()
	{
		return Otr;
	}
}
