using System;

namespace Org.BouncyCastle.Bcpg.Sig;

public class KeyFlags : SignatureSubpacket
{
	public const int CertifyOther = 1;

	public const int SignData = 2;

	public const int EncryptComms = 4;

	public const int EncryptStorage = 8;

	public const int Split = 16;

	public const int Authentication = 32;

	public const int Shared = 128;

	public int Flags
	{
		get
		{
			int flags = 0;
			for (int i = 0; i != data.Length; i++)
			{
				flags |= (data[i] & 0xFF) << i * 8;
			}
			return flags;
		}
	}

	private static byte[] IntToByteArray(int v)
	{
		byte[] tmp = new byte[4];
		int size = 0;
		for (int i = 0; i != 4; i++)
		{
			tmp[i] = (byte)(v >> i * 8);
			if (tmp[i] != 0)
			{
				size = i;
			}
		}
		byte[] data = new byte[size + 1];
		Array.Copy(tmp, 0, data, 0, data.Length);
		return data;
	}

	public KeyFlags(bool critical, bool isLongLength, byte[] data)
		: base(SignatureSubpacketTag.KeyFlags, critical, isLongLength, data)
	{
	}

	public KeyFlags(bool critical, int flags)
		: base(SignatureSubpacketTag.KeyFlags, critical, isLongLength: false, IntToByteArray(flags))
	{
	}
}
