using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
public interface IIndexedTextRangeProviderCollection
{
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	int GetCount();

	ITextRangeProvider GetItem(int index);
}
