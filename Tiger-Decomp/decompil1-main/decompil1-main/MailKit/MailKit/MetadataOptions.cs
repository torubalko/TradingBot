using System;

namespace MailKit;

public class MetadataOptions
{
	private int depth;

	public int Depth
	{
		get
		{
			return depth;
		}
		set
		{
			if (value != 0 && value != 1 && value != int.MaxValue)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			depth = value;
		}
	}

	public uint? MaxSize { get; set; }

	public uint LongEntries { get; set; }
}
