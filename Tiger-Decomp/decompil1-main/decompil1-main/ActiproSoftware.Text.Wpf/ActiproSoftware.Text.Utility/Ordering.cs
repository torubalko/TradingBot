using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class Ordering
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string HVy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OrderPlacement iVz;

	internal static Ordering nW8;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return HVy;
		}
		[CompilerGenerated]
		private set
		{
			HVy = value;
		}
	}

	public OrderPlacement Placement
	{
		[CompilerGenerated]
		get
		{
			return iVz;
		}
		[CompilerGenerated]
		private set
		{
			iVz = value;
		}
	}

	public Ordering(string key, OrderPlacement placement)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		Key = key;
		Placement = placement;
	}

	public override string ToString()
	{
		return GetType().Name + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5204) + Key + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5218) + Placement.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool nWL()
	{
		return nW8 == null;
	}

	internal static Ordering qWs()
	{
		return nW8;
	}
}
