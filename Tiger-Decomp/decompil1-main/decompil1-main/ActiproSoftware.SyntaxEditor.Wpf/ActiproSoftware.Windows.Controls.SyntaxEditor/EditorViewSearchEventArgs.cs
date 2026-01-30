using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Searching;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class EditorViewSearchEventArgs : RoutedEventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISearchResultSet vae;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEditorView fal;

	private static EditorViewSearchEventArgs OC;

	public ISearchResultSet ResultSet
	{
		[CompilerGenerated]
		get
		{
			return vae;
		}
		[CompilerGenerated]
		private set
		{
			vae = value;
		}
	}

	public IEditorView View
	{
		[CompilerGenerated]
		get
		{
			return fal;
		}
		[CompilerGenerated]
		private set
		{
			fal = value;
		}
	}

	public EditorViewSearchEventArgs(IEditorView view, ISearchResultSet resultSet)
	{
		grA.DaB7cz();
		base._002Ector();
		View = view;
		ResultSet = resultSet;
	}

	internal static bool wr()
	{
		return OC == null;
	}

	internal static EditorViewSearchEventArgs fX()
	{
		return OC;
	}
}
