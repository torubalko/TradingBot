using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class PasteDragDropEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PasteDragDropAction OaU;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IDataStore faJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DragEventArgs rat;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string jaZ;

	private static PasteDragDropEventArgs pDp;

	public PasteDragDropAction Action
	{
		[CompilerGenerated]
		get
		{
			return OaU;
		}
		[CompilerGenerated]
		private set
		{
			OaU = value;
		}
	}

	public IDataStore DataStore
	{
		[CompilerGenerated]
		get
		{
			return faJ;
		}
		[CompilerGenerated]
		private set
		{
			faJ = value;
		}
	}

	public DragEventArgs DragEventArgs
	{
		[CompilerGenerated]
		get
		{
			return rat;
		}
		[CompilerGenerated]
		private set
		{
			rat = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return jaZ;
		}
		[CompilerGenerated]
		set
		{
			jaZ = value;
		}
	}

	public PasteDragDropEventArgs(PasteDragDropAction action, IDataStore dataStore, string text)
	{
		grA.DaB7cz();
		base._002Ector();
		Action = action;
		DataStore = dataStore;
		Text = text;
	}

	public PasteDragDropEventArgs(PasteDragDropAction action, DragEventArgs dragEventArgs, string text)
	{
		grA.DaB7cz();
		base._002Ector();
		if (dragEventArgs == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1716));
		}
		Action = action;
		DragEventArgs = dragEventArgs;
		Text = text;
		DataStore = new cTH(dragEventArgs.Data);
	}

	internal static bool MD4()
	{
		return pDp == null;
	}

	internal static PasteDragDropEventArgs KDD()
	{
		return pDp;
	}
}
