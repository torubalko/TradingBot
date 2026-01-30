using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

[ContentProperty("ContentTemplate")]
public class PartEditBoxInline
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataTemplate CfY;

	internal static PartEditBoxInline lWg;

	public DataTemplate ContentTemplate
	{
		[CompilerGenerated]
		get
		{
			return CfY;
		}
		[CompilerGenerated]
		set
		{
			CfY = value;
		}
	}

	public PartEditBoxInline()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool QWs()
	{
		return lWg == null;
	}

	internal static PartEditBoxInline XWY()
	{
		return lWg;
	}
}
