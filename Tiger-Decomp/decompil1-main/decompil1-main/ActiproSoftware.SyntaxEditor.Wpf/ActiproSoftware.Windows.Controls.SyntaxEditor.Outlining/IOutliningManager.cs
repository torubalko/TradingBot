using System.Collections.Generic;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

public interface IOutliningManager : ITagger<ICollapsedRegionTag>, IOrderable, IKeyedObject, ITagger<IIntraTextSpacerTag>, ITextViewTaggerProvider
{
	OutliningMode ActiveMode { get; set; }

	IEditorDocument Document { get; }

	IOutliningNode RootNode { get; }

	void AddManualNode(TextSnapshotRange snapshotRange, IOutliningNodeDefinition definition);

	void ApplyDefaultOutliningExpansion();

	void CollapseToDefinitions();

	void EnsureExpanded(TextSnapshotOffset snapshotOffset);

	void ExpandAllOutlining();

	OutliningState GetOutliningState(TextSnapshotRange snapshotRange);

	IEnumerable<IOutliningNode> GetStartingNodes(TextSnapshotRange snapshotRange);

	void RemoveAllManualNodes();

	void RemoveManualNode(TextSnapshotOffset snapshotOffset);

	void ToggleAllOutliningExpansion();

	void ToggleOutliningExpansion(TextSnapshotOffset snapshotOffset);

	void ToggleOutliningExpansion(ITextViewLine viewLine);
}
