using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

public interface IOutliningSource
{
	[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#")]
	[SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
	OutliningNodeAction GetNodeAction(ref int offset, out IOutliningNodeDefinition definition);
}
