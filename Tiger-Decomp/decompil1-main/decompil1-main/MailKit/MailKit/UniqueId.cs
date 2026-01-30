using System;
using System.Globalization;

namespace MailKit;

public struct UniqueId : IComparable<UniqueId>, IEquatable<UniqueId>
{
	public static readonly UniqueId Invalid;

	public static readonly UniqueId MinValue = new UniqueId(1u);

	public static readonly UniqueId MaxValue = new UniqueId(uint.MaxValue);

	private readonly uint validity;

	private readonly uint id;

	public uint Id => id;

	public uint Validity => validity;

	public bool IsValid => Id != 0;

	public UniqueId(uint validity, uint id)
	{
		if (id == 0)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		this.validity = validity;
		this.id = id;
	}

	public UniqueId(uint id)
	{
		if (id == 0)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		validity = 0u;
		this.id = id;
	}

	public int CompareTo(UniqueId other)
	{
		return Id.CompareTo(other.Id);
	}

	public bool Equals(UniqueId other)
	{
		return other.Id == Id;
	}

	public static bool operator ==(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id == uid2.Id;
	}

	public static bool operator >(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id > uid2.Id;
	}

	public static bool operator >=(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id >= uid2.Id;
	}

	public static bool operator !=(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id != uid2.Id;
	}

	public static bool operator <(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id < uid2.Id;
	}

	public static bool operator <=(UniqueId uid1, UniqueId uid2)
	{
		return uid1.Id <= uid2.Id;
	}

	public override bool Equals(object obj)
	{
		if (obj is UniqueId uniqueId)
		{
			return uniqueId.Id == Id;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Id.GetHashCode();
	}

	public override string ToString()
	{
		return Id.ToString(CultureInfo.InvariantCulture);
	}

	internal static bool TryParse(string token, ref int index, out uint uid)
	{
		uint num = 0u;
		while (index < token.Length)
		{
			char c = token[index];
			if (c < '0' || c > '9')
			{
				break;
			}
			uint num2 = (uint)(c - 48);
			if (num > 429496729 || (num == 429496729 && num2 > 5))
			{
				uid = 0u;
				return false;
			}
			num = num * 10 + num2;
			index++;
		}
		uid = num;
		return uid != 0;
	}

	public static bool TryParse(string token, uint validity, out UniqueId uid)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		if (!uint.TryParse(token, NumberStyles.None, CultureInfo.InvariantCulture, out var result) || result == 0)
		{
			uid = Invalid;
			return false;
		}
		uid = new UniqueId(validity, result);
		return true;
	}

	public static bool TryParse(string token, out UniqueId uid)
	{
		return TryParse(token, 0u, out uid);
	}

	public static UniqueId Parse(string token, uint validity)
	{
		return new UniqueId(validity, uint.Parse(token, NumberStyles.None, CultureInfo.InvariantCulture));
	}

	public static UniqueId Parse(string token)
	{
		return new UniqueId(uint.Parse(token, NumberStyles.None, CultureInfo.InvariantCulture));
	}
}
