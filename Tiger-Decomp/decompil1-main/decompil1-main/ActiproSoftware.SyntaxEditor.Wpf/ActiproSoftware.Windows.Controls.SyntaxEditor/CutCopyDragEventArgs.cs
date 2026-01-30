using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class CutCopyDragEventArgs : RoutedEventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CutCopyDragAction kc;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IDataStore na;

	internal static CutCopyDragEventArgs AA;

	public CutCopyDragAction Action
	{
		[CompilerGenerated]
		get
		{
			return kc;
		}
		[CompilerGenerated]
		private set
		{
			kc = value;
		}
	}

	public IDataStore DataStore
	{
		[CompilerGenerated]
		get
		{
			return na;
		}
		[CompilerGenerated]
		private set
		{
			na = value;
		}
	}

	public CutCopyDragEventArgs(CutCopyDragAction action, IDataStore dataStore)
	{
		grA.DaB7cz();
		base._002Ector();
		Action = action;
		DataStore = dataStore;
	}

	internal static bool rl()
	{
		return AA == null;
	}

	internal static CutCopyDragEventArgs fW()
	{
		return AA;
	}
}
