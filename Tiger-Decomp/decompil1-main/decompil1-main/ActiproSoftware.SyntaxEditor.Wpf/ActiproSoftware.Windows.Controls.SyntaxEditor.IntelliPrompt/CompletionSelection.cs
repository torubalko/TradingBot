using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public class CompletionSelection
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICompletionItem Cmd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CompletionSelectionState Hmz;

	internal static CompletionSelection Tqx;

	public ICompletionItem Item
	{
		[CompilerGenerated]
		get
		{
			return Cmd;
		}
		[CompilerGenerated]
		private set
		{
			Cmd = value;
		}
	}

	public CompletionSelectionState State
	{
		[CompilerGenerated]
		get
		{
			return Hmz;
		}
		[CompilerGenerated]
		private set
		{
			Hmz = value;
		}
	}

	public CompletionSelection(ICompletionItem item, CompletionSelectionState state)
	{
		grA.DaB7cz();
		base._002Ector();
		if (item == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12126));
		}
		Item = item;
		State = state;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CompletionSelection completionSelection))
		{
			return false;
		}
		return Item == completionSelection.Item && State == completionSelection.State;
	}

	public override int GetHashCode()
	{
		return (Item != null) ? Item.GetHashCode() : base.GetHashCode();
	}

	internal static bool Xqa()
	{
		return Tqx == null;
	}

	internal static CompletionSelection vqL()
	{
		return Tqx;
	}
}
