using System;

namespace MailKit;

public struct AccessRight : IEquatable<AccessRight>
{
	public static readonly AccessRight LookupFolder = new AccessRight('l');

	public static readonly AccessRight OpenFolder = new AccessRight('r');

	public static readonly AccessRight SetMessageSeen = new AccessRight('s');

	public static readonly AccessRight SetMessageFlags = new AccessRight('w');

	public static readonly AccessRight AppendMessages = new AccessRight('i');

	public static readonly AccessRight CreateFolder = new AccessRight('k');

	public static readonly AccessRight DeleteFolder = new AccessRight('x');

	public static readonly AccessRight SetMessageDeleted = new AccessRight('t');

	public static readonly AccessRight ExpungeFolder = new AccessRight('e');

	public static readonly AccessRight Administer = new AccessRight('a');

	public readonly char Right;

	public AccessRight(char right)
	{
		Right = right;
	}

	public bool Equals(AccessRight other)
	{
		return other.Right == Right;
	}

	public static bool operator ==(AccessRight right1, AccessRight right2)
	{
		return right1.Right == right2.Right;
	}

	public static bool operator !=(AccessRight right1, AccessRight right2)
	{
		return right1.Right != right2.Right;
	}

	public override bool Equals(object obj)
	{
		if (obj is AccessRight)
		{
			return ((AccessRight)obj).Right == Right;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Right.GetHashCode();
	}

	public override string ToString()
	{
		return Right.ToString();
	}
}
