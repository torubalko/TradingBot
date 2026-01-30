using System;

namespace MailKit;

public class MetadataChangedEventArgs : EventArgs
{
	public Metadata Metadata { get; private set; }

	public MetadataChangedEventArgs(Metadata metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		Metadata = metadata;
	}
}
