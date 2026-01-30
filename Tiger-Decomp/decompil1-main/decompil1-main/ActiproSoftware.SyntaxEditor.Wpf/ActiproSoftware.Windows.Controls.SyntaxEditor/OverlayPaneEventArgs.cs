using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class OverlayPaneEventArgs : TextViewEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IOverlayPane iai;

	internal static OverlayPaneEventArgs u4K;

	public IOverlayPane Pane
	{
		[CompilerGenerated]
		get
		{
			return iai;
		}
		[CompilerGenerated]
		private set
		{
			iai = value;
		}
	}

	public OverlayPaneEventArgs(IEditorView view, IOverlayPane pane)
	{
		grA.DaB7cz();
		base._002Ector(view);
		if (pane == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1704));
		}
		Pane = pane;
	}

	internal static bool H4C()
	{
		return u4K == null;
	}

	internal static OverlayPaneEventArgs a4r()
	{
		return u4K;
	}
}
