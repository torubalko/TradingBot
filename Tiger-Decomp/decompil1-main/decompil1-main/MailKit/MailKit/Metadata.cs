namespace MailKit;

public class Metadata
{
	internal string EncodedName;

	public MetadataTag Tag { get; private set; }

	public string Value { get; private set; }

	public Metadata(MetadataTag tag, string value)
	{
		Value = value;
		Tag = tag;
	}
}
