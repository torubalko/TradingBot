using Org.BouncyCastle.Bcpg.Attr;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpUserAttributeSubpacketVector
{
	private readonly UserAttributeSubpacket[] packets;

	public static PgpUserAttributeSubpacketVector FromSubpackets(UserAttributeSubpacket[] packets)
	{
		if (packets == null)
		{
			packets = new UserAttributeSubpacket[0];
		}
		return new PgpUserAttributeSubpacketVector(packets);
	}

	internal PgpUserAttributeSubpacketVector(UserAttributeSubpacket[] packets)
	{
		this.packets = packets;
	}

	public UserAttributeSubpacket GetSubpacket(UserAttributeSubpacketTag type)
	{
		for (int i = 0; i != packets.Length; i++)
		{
			if (packets[i].SubpacketType == type)
			{
				return packets[i];
			}
		}
		return null;
	}

	public ImageAttrib GetImageAttribute()
	{
		UserAttributeSubpacket p = GetSubpacket(UserAttributeSubpacketTag.ImageAttribute);
		if (p != null)
		{
			return (ImageAttrib)p;
		}
		return null;
	}

	internal UserAttributeSubpacket[] ToSubpacketArray()
	{
		return packets;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is PgpUserAttributeSubpacketVector other))
		{
			return false;
		}
		if (other.packets.Length != packets.Length)
		{
			return false;
		}
		for (int i = 0; i != packets.Length; i++)
		{
			if (!other.packets[i].Equals(packets[i]))
			{
				return false;
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		int code = 0;
		UserAttributeSubpacket[] array = packets;
		foreach (object o in array)
		{
			code ^= o.GetHashCode();
		}
		return code;
	}
}
