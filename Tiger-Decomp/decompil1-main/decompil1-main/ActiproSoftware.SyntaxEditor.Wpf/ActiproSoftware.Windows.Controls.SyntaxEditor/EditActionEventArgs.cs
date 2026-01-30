using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditActionEventArgs : CancelRoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEditAction TPU;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEditorView OPJ;

	private static EditActionEventArgs K5;

	public IEditAction Action
	{
		[CompilerGenerated]
		get
		{
			return TPU;
		}
		[CompilerGenerated]
		private set
		{
			TPU = value;
		}
	}

	public IEditorView View
	{
		[CompilerGenerated]
		get
		{
			return OPJ;
		}
		[CompilerGenerated]
		private set
		{
			OPJ = value;
		}
	}

	public EditActionEventArgs(IEditorView view, IEditAction action)
	{
		grA.DaB7cz();
		base._002Ector();
		View = view;
		Action = action;
	}

	internal static bool AG()
	{
		return K5 == null;
	}

	internal static EditActionEventArgs MN()
	{
		return K5;
	}
}
