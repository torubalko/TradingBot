using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Internal;

internal class oAA : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string W65;

	private static oAA blP;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return W65;
		}
		[CompilerGenerated]
		private set
		{
			W65 = w;
		}
	}

	public oAA(string P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		Key = P_0;
	}

	internal static bool plo()
	{
		return blP == null;
	}

	internal static oAA tlQ()
	{
		return blP;
	}
}
