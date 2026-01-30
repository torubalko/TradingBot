using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class NavigableSymbolSet : INavigableSymbolSet
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool m3K;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<INavigableSymbol> P3f;

	internal static NavigableSymbolSet OLX;

	public bool IsPartial
	{
		[CompilerGenerated]
		get
		{
			return m3K;
		}
		[CompilerGenerated]
		set
		{
			m3K = value;
		}
	}

	public IEnumerable<INavigableSymbol> Symbols
	{
		[CompilerGenerated]
		get
		{
			return P3f;
		}
		[CompilerGenerated]
		private set
		{
			P3f = value;
		}
	}

	public NavigableSymbolSet(IEnumerable<INavigableSymbol> symbols)
	{
		grA.DaB7cz();
		base._002Ector();
		Symbols = symbols ?? new INavigableSymbol[0];
	}

	internal static bool hLE()
	{
		return OLX == null;
	}

	internal static NavigableSymbolSet PLw()
	{
		return OLX;
	}
}
