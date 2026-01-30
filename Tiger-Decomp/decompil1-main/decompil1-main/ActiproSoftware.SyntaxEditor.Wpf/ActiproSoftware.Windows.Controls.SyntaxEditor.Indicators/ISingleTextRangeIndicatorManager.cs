using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

public interface ISingleTextRangeIndicatorManager<TTagger, TTag> where TTagger : class, ICollectionTagger<TTag> where TTag : IIndicatorTag, new()
{
	TagVersionRange<TTag> this[TTag tag] { get; }

	void Clear();

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	TagVersionRange<TTag> GetInstance();

	TagVersionRange<TTag> SetInstance(TextSnapshotRange snapshotRange);

	TagVersionRange<TTag> SetInstance(TextSnapshotRange snapshotRange, TTag tag);
}
