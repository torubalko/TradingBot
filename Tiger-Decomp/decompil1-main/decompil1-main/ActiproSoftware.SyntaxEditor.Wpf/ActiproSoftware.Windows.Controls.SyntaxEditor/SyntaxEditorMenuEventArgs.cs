using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class SyntaxEditorMenuEventArgs : RoutedEventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IHitTestResult sXf;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private SyntaxEditorMenuKind hXD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ContextMenu KXg;

	internal static SyntaxEditorMenuEventArgs PDa;

	public IHitTestResult HitTestResult
	{
		[CompilerGenerated]
		get
		{
			return sXf;
		}
		[CompilerGenerated]
		private set
		{
			sXf = value;
		}
	}

	public SyntaxEditorMenuKind Kind
	{
		[CompilerGenerated]
		get
		{
			return hXD;
		}
		[CompilerGenerated]
		private set
		{
			hXD = value;
		}
	}

	public ContextMenu Menu
	{
		[CompilerGenerated]
		get
		{
			return KXg;
		}
		[CompilerGenerated]
		set
		{
			KXg = value;
		}
	}

	internal SyntaxEditorMenuEventArgs(SyntaxEditorMenuKind kind, IHitTestResult hitTestResult)
	{
		grA.DaB7cz();
		base._002Ector();
		Kind = kind;
		HitTestResult = hitTestResult;
	}

	internal static bool zDL()
	{
		return PDa == null;
	}

	internal static SyntaxEditorMenuEventArgs WDg()
	{
		return PDa;
	}
}
