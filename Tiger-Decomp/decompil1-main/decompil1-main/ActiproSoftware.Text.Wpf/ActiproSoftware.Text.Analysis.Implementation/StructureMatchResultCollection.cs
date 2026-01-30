using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class StructureMatchResultCollection : SimpleObservableCollection<IStructureMatchResult>, IStructureMatchResultCollection, IList<IStructureMatchResult>, ICollection<IStructureMatchResult>, IEnumerable<IStructureMatchResult>, IEnumerable
{
	private static IStructureMatchResultCollection xL2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool uLm;

	private static StructureMatchResultCollection HqN;

	internal static IStructureMatchResultCollection Empty
	{
		get
		{
			if (xL2 == null)
			{
				xL2 = new StructureMatchResultCollection
				{
					IsReadOnlyCore = true
				};
			}
			return xL2;
		}
	}

	internal bool IsReadOnlyCore
	{
		[CompilerGenerated]
		get
		{
			return uLm;
		}
		[CompilerGenerated]
		set
		{
			uLm = value;
		}
	}

	public override bool IsReadOnly => IsReadOnlyCore;

	public StructureMatchResultCollection()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool qqr()
	{
		return HqN == null;
	}

	internal static StructureMatchResultCollection yqj()
	{
		return HqN;
	}
}
