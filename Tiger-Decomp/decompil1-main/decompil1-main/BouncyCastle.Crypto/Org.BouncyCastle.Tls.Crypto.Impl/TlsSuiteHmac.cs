using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsSuiteHmac : TlsSuiteMac
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly TlsHmac m_mac;

	protected readonly int m_digestBlockSize;

	protected readonly int m_digestOverhead;

	protected readonly int m_macSize;

	public virtual int Size => m_macSize;

	protected static int GetMacSize(TlsCryptoParameters cryptoParams, TlsMac mac)
	{
		int macSize = mac.MacLength;
		if (cryptoParams.SecurityParameters.IsTruncatedHmac)
		{
			macSize = System.Math.Min(macSize, 10);
		}
		return macSize;
	}

	public TlsSuiteHmac(TlsCryptoParameters cryptoParams, TlsHmac mac)
	{
		m_cryptoParams = cryptoParams;
		m_mac = mac;
		m_macSize = GetMacSize(cryptoParams, mac);
		m_digestBlockSize = mac.InternalBlockSize;
		if (TlsImplUtilities.IsSsl(cryptoParams) && mac.MacLength == 20)
		{
			m_digestOverhead = 4;
		}
		else
		{
			m_digestOverhead = m_digestBlockSize / 8;
		}
	}

	public virtual byte[] CalculateMac(long seqNo, short type, byte[] msg, int msgOff, int msgLen)
	{
		ProtocolVersion serverVersion = m_cryptoParams.ServerVersion;
		bool isSsl = serverVersion.IsSsl;
		byte[] macHeader = new byte[isSsl ? 11 : 13];
		TlsUtilities.WriteUint64(seqNo, macHeader, 0);
		TlsUtilities.WriteUint8(type, macHeader, 8);
		if (!isSsl)
		{
			TlsUtilities.WriteVersion(serverVersion, macHeader, 9);
		}
		TlsUtilities.WriteUint16(msgLen, macHeader, macHeader.Length - 2);
		m_mac.Update(macHeader, 0, macHeader.Length);
		m_mac.Update(msg, msgOff, msgLen);
		return Truncate(m_mac.CalculateMac());
	}

	public virtual byte[] CalculateMacConstantTime(long seqNo, short type, byte[] msg, int msgOff, int msgLen, int fullLength, byte[] dummyData)
	{
		byte[] result = CalculateMac(seqNo, type, msg, msgOff, msgLen);
		int headerLength = (TlsImplUtilities.IsSsl(m_cryptoParams) ? 11 : 13);
		int extra = GetDigestBlockCount(headerLength + fullLength) - GetDigestBlockCount(headerLength + msgLen);
		while (--extra >= 0)
		{
			m_mac.Update(dummyData, 0, m_digestBlockSize);
		}
		m_mac.Update(dummyData, 0, 1);
		m_mac.Reset();
		return result;
	}

	protected virtual int GetDigestBlockCount(int inputLength)
	{
		return (inputLength + m_digestOverhead) / m_digestBlockSize;
	}

	protected virtual byte[] Truncate(byte[] bs)
	{
		if (bs.Length <= m_macSize)
		{
			return bs;
		}
		return Arrays.CopyOf(bs, m_macSize);
	}
}
