using System;

namespace MailKit;

public struct MetadataTag
{
	public static readonly MetadataTag SharedAdmin = new MetadataTag("/shared/admin");

	public static readonly MetadataTag PrivateComment = new MetadataTag("/private/comment");

	public static readonly MetadataTag SharedComment = new MetadataTag("/shared/comment");

	public static readonly MetadataTag PrivateSpecialUse = new MetadataTag("/private/specialuse");

	public string Id { get; private set; }

	public MetadataTag(string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (id.Length == 0)
		{
			throw new ArgumentException("A metadata tag identifier cannot be empty.");
		}
		Id = id;
	}

	public override bool Equals(object obj)
	{
		if (obj is MetadataTag metadataTag)
		{
			return metadataTag.Id == Id;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Id.GetHashCode();
	}

	public override string ToString()
	{
		return Id;
	}

	internal static MetadataTag Create(string id)
	{
		return id switch
		{
			"/shared/admin" => SharedAdmin, 
			"/private/comment" => PrivateComment, 
			"/shared/comment" => SharedComment, 
			"/private/specialuse" => PrivateSpecialUse, 
			_ => new MetadataTag(id), 
		};
	}
}
