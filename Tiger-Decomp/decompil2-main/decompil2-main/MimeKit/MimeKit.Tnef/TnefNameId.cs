using System;

namespace MimeKit.Tnef;

public struct TnefNameId
{
	private readonly TnefNameIdKind kind;

	private readonly string name;

	private readonly Guid guid;

	private readonly int id;

	public Guid PropertySetGuid => guid;

	public TnefNameIdKind Kind => kind;

	public string Name => name;

	public int Id => id;

	public TnefNameId(Guid propertySetGuid, int id)
	{
		kind = TnefNameIdKind.Id;
		guid = propertySetGuid;
		this.id = id;
		name = null;
	}

	public TnefNameId(Guid propertySetGuid, string name)
	{
		kind = TnefNameIdKind.Name;
		guid = propertySetGuid;
		this.name = name;
		id = 0;
	}

	public override int GetHashCode()
	{
		int num = ((kind == TnefNameIdKind.Id) ? id : name.GetHashCode());
		return kind.GetHashCode() ^ guid.GetHashCode() ^ num;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is TnefNameId tnefNameId))
		{
			return false;
		}
		if (tnefNameId.kind != kind || tnefNameId.guid != guid)
		{
			return false;
		}
		if (kind != TnefNameIdKind.Id)
		{
			return tnefNameId.name == name;
		}
		return tnefNameId.id == id;
	}
}
