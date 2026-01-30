using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

public class AutoCompleteBoxEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool IVX;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object CVx;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string AV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AutoCompleteBoxChangeReason aVY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string LVg;

	private static AutoCompleteBoxEventArgs tO;

	public bool IsPopupAllowed
	{
		[CompilerGenerated]
		get
		{
			return IVX;
		}
		[CompilerGenerated]
		set
		{
			IVX = value;
		}
	}

	public object Item
	{
		[CompilerGenerated]
		get
		{
			return CVx;
		}
		[CompilerGenerated]
		private set
		{
			CVx = value;
		}
	}

	public string OriginalText
	{
		[CompilerGenerated]
		get
		{
			return AV0;
		}
		[CompilerGenerated]
		private set
		{
			AV0 = value;
		}
	}

	public AutoCompleteBoxChangeReason Reason
	{
		[CompilerGenerated]
		get
		{
			return aVY;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return LVg;
		}
		[CompilerGenerated]
		set
		{
			LVg = value;
		}
	}

	public AutoCompleteBoxEventArgs(AutoCompleteBoxChangeReason reason, object item)
	{
		awj.QuEwGz();
		this._002Ector(reason, item, null);
	}

	public AutoCompleteBoxEventArgs(AutoCompleteBoxChangeReason reason, object item, string originalText)
	{
		awj.QuEwGz();
		base._002Ector();
		aVY = reason;
		Item = item;
		OriginalText = originalText;
	}

	internal static bool Tm()
	{
		return tO == null;
	}

	internal static AutoCompleteBoxEventArgs gP()
	{
		return tO;
	}
}
