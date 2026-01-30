using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.Sig;

public class SignatureCreationTime : SignatureSubpacket
{
	protected static byte[] TimeToBytes(DateTime time)
	{
		long t = DateTimeUtilities.DateTimeToUnixMs(time) / 1000;
		return new byte[4]
		{
			(byte)(t >> 24),
			(byte)(t >> 16),
			(byte)(t >> 8),
			(byte)t
		};
	}

	public SignatureCreationTime(bool critical, bool isLongLength, byte[] data)
		: base(SignatureSubpacketTag.CreationTime, critical, isLongLength, data)
	{
	}

	public SignatureCreationTime(bool critical, DateTime date)
		: base(SignatureSubpacketTag.CreationTime, critical, isLongLength: false, TimeToBytes(date))
	{
	}

	public DateTime GetTime()
	{
		return DateTimeUtilities.UnixMsToDateTime((long)(uint)((data[0] << 24) | (data[1] << 16) | (data[2] << 8) | data[3]) * 1000L);
	}
}
