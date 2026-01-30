using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Tagging.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

[SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces")]
public interface ICurrentStatementIndicatorManager : ISingleTextRangeIndicatorManager<CurrentStatementIndicatorTagger, CurrentStatementIndicatorTag>
{
}
