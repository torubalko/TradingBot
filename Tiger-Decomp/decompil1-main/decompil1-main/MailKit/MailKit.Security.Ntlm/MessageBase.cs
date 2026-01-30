using System;
using System.Globalization;

namespace MailKit.Security.Ntlm;

internal abstract class MessageBase
{
	private static readonly byte[] header = new byte[8] { 78, 84, 76, 77, 83, 83, 80, 0 };

	public NtlmFlags Flags { get; set; }

	public Version OSVersion { get; protected set; }

	public int Type { get; private set; }

	protected MessageBase(int type)
	{
		Type = type;
	}

	protected byte[] PrepareMessage(int size)
	{
		byte[] array = new byte[size];
		Buffer.BlockCopy(header, 0, array, 0, 8);
		array[8] = (byte)Type;
		array[9] = (byte)(Type >> 8);
		array[10] = (byte)(Type >> 16);
		array[11] = (byte)(Type >> 24);
		return array;
	}

	private bool CheckHeader(byte[] message, int startIndex)
	{
		for (int i = 0; i < header.Length; i++)
		{
			if (message[startIndex + i] != header[i])
			{
				return false;
			}
		}
		return BitConverterLE.ToUInt32(message, startIndex + 8) == Type;
	}

	protected void ValidateArguments(byte[] message, int startIndex, int length)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (startIndex < 0 || startIndex > message.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (length < 12 || length > message.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (!CheckHeader(message, startIndex))
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid Type{0} message.", Type), "message");
		}
	}

	public abstract byte[] Encode();
}
