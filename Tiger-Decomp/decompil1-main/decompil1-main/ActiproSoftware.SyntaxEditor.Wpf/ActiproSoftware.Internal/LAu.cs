using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal abstract class LAu : MTG, IOrderable, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string B6y;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable<Ordering> Y6q;

	private static LAu rlX;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return B6y;
		}
		[CompilerGenerated]
		private set
		{
			B6y = b6y;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return Y6q;
		}
		[CompilerGenerated]
		private set
		{
			Y6q = y6q;
		}
	}

	public virtual UIElement VisualElement => null;

	protected LAu(string P_0, IEnumerable<Ordering> P_1)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = P_0;
		Orderings = P_1;
	}

	public abstract void Draw(TextViewDrawContext P_0);

	internal static bool UlE()
	{
		return rlX == null;
	}

	internal static LAu Nlw()
	{
		return rlX;
	}
}
