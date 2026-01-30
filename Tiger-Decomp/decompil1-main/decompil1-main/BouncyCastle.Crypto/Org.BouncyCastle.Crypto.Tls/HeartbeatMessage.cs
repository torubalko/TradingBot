using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

public class HeartbeatMessage
{
	internal class PayloadBuffer : MemoryStream
	{
		internal byte[] ToTruncatedByteArray(int payloadLength)
		{
			int minimumCount = payloadLength + 16;
			if (Length < minimumCount)
			{
				return null;
			}
			return Arrays.CopyOf(GetBuffer(), payloadLength);
		}
	}

	protected readonly byte mType;

	protected readonly byte[] mPayload;

	protected readonly int mPaddingLength;

	public HeartbeatMessage(byte type, byte[] payload, int paddingLength)
	{
		if (!HeartbeatMessageType.IsValid(type))
		{
			throw new ArgumentException("not a valid HeartbeatMessageType value", "type");
		}
		if (payload == null || payload.Length >= 65536)
		{
			throw new ArgumentException("must have length < 2^16", "payload");
		}
		if (paddingLength < 16)
		{
			throw new ArgumentException("must be at least 16", "paddingLength");
		}
		mType = type;
		mPayload = payload;
		mPaddingLength = paddingLength;
	}

	public virtual void Encode(TlsContext context, Stream output)
	{
		TlsUtilities.WriteUint8(mType, output);
		TlsUtilities.CheckUint16(mPayload.Length);
		TlsUtilities.WriteUint16(mPayload.Length, output);
		output.Write(mPayload, 0, mPayload.Length);
		byte[] padding = new byte[mPaddingLength];
		context.NonceRandomGenerator.NextBytes(padding);
		output.Write(padding, 0, padding.Length);
	}

	public static HeartbeatMessage Parse(Stream input)
	{
		byte type = TlsUtilities.ReadUint8(input);
		if (!HeartbeatMessageType.IsValid(type))
		{
			throw new TlsFatalAlert(47);
		}
		int payload_length = TlsUtilities.ReadUint16(input);
		PayloadBuffer buf = new PayloadBuffer();
		Streams.PipeAll(input, buf);
		byte[] payload = buf.ToTruncatedByteArray(payload_length);
		if (payload == null)
		{
			return null;
		}
		TlsUtilities.CheckUint16(buf.Length);
		int padding_length = (int)buf.Length - payload.Length;
		return new HeartbeatMessage(type, payload, padding_length);
	}
}
