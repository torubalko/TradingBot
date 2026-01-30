using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class Ht : VTn<CurrentStatementIndicatorTagger, CurrentStatementIndicatorTag>, ICurrentStatementIndicatorManager, ISingleTextRangeIndicatorManager<CurrentStatementIndicatorTagger, CurrentStatementIndicatorTag>
{
	internal static Ht wg8;

	public Ht(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector(P_0);
	}

	internal static bool VgU()
	{
		return wg8 == null;
	}

	internal static Ht sge()
	{
		return wg8;
	}
}
