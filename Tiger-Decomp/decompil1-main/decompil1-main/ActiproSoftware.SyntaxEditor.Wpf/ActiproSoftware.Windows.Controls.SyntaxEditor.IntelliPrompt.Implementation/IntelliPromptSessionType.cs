using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
public class IntelliPromptSessionType : IIntelliPromptSessionType, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool xFN;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string qFd;

	internal static IntelliPromptSessionType yLY;

	public bool AreMultipleSessionsAllowed
	{
		[CompilerGenerated]
		get
		{
			return xFN;
		}
		[CompilerGenerated]
		private set
		{
			xFN = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return qFd;
		}
		[CompilerGenerated]
		private set
		{
			qFd = value;
		}
	}

	public IntelliPromptSessionType(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, areMultipleSessionsAllowed: false);
	}

	public IntelliPromptSessionType(string key, bool areMultipleSessionsAllowed)
	{
		grA.DaB7cz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		AreMultipleSessionsAllowed = areMultipleSessionsAllowed;
	}

	public override int GetHashCode()
	{
		return Key.GetHashCode();
	}

	internal static bool lLb()
	{
		return yLY == null;
	}

	internal static IntelliPromptSessionType xLs()
	{
		return yLY;
	}
}
