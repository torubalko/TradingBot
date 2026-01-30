using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Text.Parsing;

public static class AmbientParseRequestDispatcherProvider
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static IParseRequestDispatcher f83;

	public static IParseRequestDispatcher Dispatcher
	{
		[CompilerGenerated]
		get
		{
			return f83;
		}
		[CompilerGenerated]
		set
		{
			f83 = value;
		}
	}
}
