using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Internal;

internal class kAg : ClassificationType, IOrderable, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> kIy;

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return kIy;
		}
		[CompilerGenerated]
		private set
		{
			kIy = enumerable;
		}
	}

	public kAg(string P_0, string P_1, IEnumerable<Ordering> P_2)
	{
		grA.DaB7cz();
		base._002Ector(P_0, P_1);
		Orderings = P_2;
	}
}
