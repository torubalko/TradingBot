using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

public class CanvasDrawEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CanvasDrawContext FYk;

	internal static CanvasDrawEventArgs Snv;

	public CanvasDrawContext Context
	{
		[CompilerGenerated]
		get
		{
			return FYk;
		}
		[CompilerGenerated]
		private set
		{
			FYk = value;
		}
	}

	public CanvasDrawEventArgs(CanvasDrawContext context)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (context == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117002));
		}
		Context = context;
	}

	internal static bool rna()
	{
		return Snv == null;
	}

	internal static CanvasDrawEventArgs Nny()
	{
		return Snv;
	}
}
