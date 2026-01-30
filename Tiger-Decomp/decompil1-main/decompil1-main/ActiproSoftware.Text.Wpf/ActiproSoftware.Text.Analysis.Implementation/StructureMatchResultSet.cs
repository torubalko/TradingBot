using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class StructureMatchResultSet : IStructureMatchResultSet
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IStructureMatchResultCollection NLh;

	private static StructureMatchResultSet JqK;

	public IStructureMatchResultCollection Results
	{
		[CompilerGenerated]
		get
		{
			return NLh;
		}
		[CompilerGenerated]
		private set
		{
			NLh = value;
		}
	}

	public StructureMatchResultSet(IStructureMatchResultCollection results)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Results = results ?? StructureMatchResultCollection.Empty;
	}

	internal static bool Tql()
	{
		return JqK == null;
	}

	internal static StructureMatchResultSet fqo()
	{
		return JqK;
	}
}
