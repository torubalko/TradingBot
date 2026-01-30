using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows;

namespace ActiproSoftware.Products.SyntaxEditor;

public static class CustomCursors
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Cursor G5t;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Cursor d5Z;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Cursor w5h;

	internal static CustomCursors nGP;

	public static Cursor IncrementalSearchBackward
	{
		[CompilerGenerated]
		get
		{
			return G5t;
		}
		[CompilerGenerated]
		set
		{
			G5t = value;
		}
	}

	public static Cursor IncrementalSearchForward
	{
		[CompilerGenerated]
		get
		{
			return d5Z;
		}
		[CompilerGenerated]
		set
		{
			d5Z = value;
		}
	}

	public static Cursor ReverseArrow
	{
		[CompilerGenerated]
		get
		{
			return w5h;
		}
		[CompilerGenerated]
		set
		{
			w5h = value;
		}
	}

	static CustomCursors()
	{
		grA.DaB7cz();
		I5O();
		t5U();
		m5J();
	}

	private static Cursor m5M(string P_0)
	{
		try
		{
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Q7Z.tqM(202206) + P_0 + Q7Z.tqM(202302));
			if (stream != null)
			{
				return new Cursor(stream);
			}
		}
		catch (IOException)
		{
		}
		return null;
	}

	private static void I5O()
	{
		if (SecurityHelper.IsFullTrust)
		{
			IncrementalSearchBackward = m5M(Q7Z.tqM(202314));
		}
	}

	private static void t5U()
	{
		if (SecurityHelper.IsFullTrust)
		{
			IncrementalSearchForward = m5M(Q7Z.tqM(202368));
		}
	}

	private static void m5J()
	{
		if (SecurityHelper.IsFullTrust)
		{
			ReverseArrow = m5M(Q7Z.tqM(202420));
		}
	}

	internal static bool bGo()
	{
		return nGP == null;
	}

	internal static CustomCursors xGQ()
	{
		return nGP;
	}
}
