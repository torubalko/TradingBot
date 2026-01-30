using System.Collections.Generic;

namespace MailKit;

public class MetadataCollection : List<Metadata>
{
	public MetadataCollection()
	{
	}

	public MetadataCollection(IEnumerable<Metadata> collection)
		: base(collection)
	{
	}
}
