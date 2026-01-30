using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Internal;

internal abstract class YAZ : ITextExporter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IHighlightingStyleRegistry R5Y;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LineTerminator x54;

	internal static YAZ UGM;

	public abstract string DataFormat { get; }

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		[CompilerGenerated]
		get
		{
			return R5Y;
		}
		[CompilerGenerated]
		set
		{
			R5Y = r5Y;
		}
	}

	public LineTerminator LineTerminator
	{
		[CompilerGenerated]
		get
		{
			return x54;
		}
		[CompilerGenerated]
		set
		{
			x54 = lineTerminator;
		}
	}

	protected YAZ()
	{
		grA.DaB7cz();
		base._002Ector();
		LineTerminator = LineTerminator.CarriageReturnNewline;
	}

	public abstract string Export(ITextSnapshot P_0, ICollection<TextRange> P_1);

	internal static bool gG3()
	{
		return UGM == null;
	}

	internal static YAZ JGv()
	{
		return UGM;
	}
}
