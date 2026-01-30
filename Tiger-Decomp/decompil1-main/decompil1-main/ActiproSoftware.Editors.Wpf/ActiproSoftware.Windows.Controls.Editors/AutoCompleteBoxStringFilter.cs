using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Data.Filtering;

namespace ActiproSoftware.Windows.Controls.Editors;

public class AutoCompleteBoxStringFilter : StringFilterBase
{
	internal static AutoCompleteBoxStringFilter gZ;

	public override DataFilterResult Filter(object item, object context)
	{
		string test = (context as string) ?? string.Empty;
		string source = (item as string) ?? string.Empty;
		return FilterByString(source, test) ? base.IncludedFilterResult : DataFilterResult.IncludedByDescendants;
	}

	public AutoCompleteBoxStringFilter()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool HR()
	{
		return gZ == null;
	}

	internal static AutoCompleteBoxStringFilter Wi()
	{
		return gZ;
	}
}
