namespace MimeKit.Utils;

internal class DateToken
{
	public DateTokenFlags Flags { get; private set; }

	public int StartIndex { get; private set; }

	public int Length { get; private set; }

	public bool IsNumeric => (Flags & DateTokenFlags.NonNumeric) == 0;

	public bool IsWeekday => (Flags & DateTokenFlags.NonWeekday) == 0;

	public bool IsMonth => (Flags & DateTokenFlags.NonMonth) == 0;

	public bool IsTimeOfDay
	{
		get
		{
			if ((Flags & DateTokenFlags.NonTime) == 0)
			{
				return (Flags & DateTokenFlags.HasColon) != 0;
			}
			return false;
		}
	}

	public bool IsNumericZone
	{
		get
		{
			if ((Flags & DateTokenFlags.NonNumericZone) == 0)
			{
				return (Flags & DateTokenFlags.HasSign) != 0;
			}
			return false;
		}
	}

	public bool IsAlphaZone => (Flags & DateTokenFlags.NonAlphaZone) == 0;

	public bool IsTimeZone
	{
		get
		{
			if (!IsNumericZone)
			{
				return IsAlphaZone;
			}
			return true;
		}
	}

	public DateToken(DateTokenFlags flags, int startIndex, int length)
	{
		StartIndex = startIndex;
		Length = length;
		Flags = flags;
	}
}
