using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class Ps : INavigableRequestContext, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string m3W;

	internal static Ps OLP;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return m3W;
		}
		[CompilerGenerated]
		private set
		{
			m3W = text;
		}
	}

	public Ps(string P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = P_0;
	}

	internal static bool zLo()
	{
		return OLP == null;
	}

	internal static Ps vLQ()
	{
		return OLP;
	}
}
