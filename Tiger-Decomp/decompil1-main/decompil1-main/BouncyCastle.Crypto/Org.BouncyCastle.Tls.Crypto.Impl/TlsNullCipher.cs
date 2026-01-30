using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsNullCipher : TlsCipher
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly TlsSuiteHmac m_readMac;

	protected readonly TlsSuiteHmac m_writeMac;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsNullCipher(TlsCryptoParameters cryptoParams, TlsHmac clientMac, TlsHmac serverMac)
	{
		if (TlsImplUtilities.IsTlsV13(cryptoParams))
		{
			throw new TlsFatalAlert(80);
		}
		m_cryptoParams = cryptoParams;
		int key_block_size = clientMac.MacLength + serverMac.MacLength;
		byte[] key_block = TlsImplUtilities.CalculateKeyBlock(cryptoParams, key_block_size);
		int offset = 0;
		clientMac.SetKey(key_block, offset, clientMac.MacLength);
		offset += clientMac.MacLength;
		serverMac.SetKey(key_block, offset, serverMac.MacLength);
		offset += serverMac.MacLength;
		if (offset != key_block_size)
		{
			throw new TlsFatalAlert(80);
		}
		if (cryptoParams.IsServer)
		{
			m_writeMac = new TlsSuiteHmac(cryptoParams, serverMac);
			m_readMac = new TlsSuiteHmac(cryptoParams, clientMac);
		}
		else
		{
			m_writeMac = new TlsSuiteHmac(cryptoParams, clientMac);
			m_readMac = new TlsSuiteHmac(cryptoParams, serverMac);
		}
	}

	public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return plaintextLimit + m_writeMac.Size;
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		return plaintextLength + m_writeMac.Size;
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit - m_writeMac.Size;
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		byte[] mac = m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
		byte[] ciphertext = new byte[headerAllocation + len + mac.Length];
		Array.Copy(plaintext, offset, ciphertext, headerAllocation, len);
		Array.Copy(mac, 0, ciphertext, headerAllocation + len, mac.Length);
		return new TlsEncodeResult(ciphertext, 0, ciphertext.Length, contentType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		int macSize = m_readMac.Size;
		if (len < macSize)
		{
			throw new TlsFatalAlert(50);
		}
		int macInputLen = len - macSize;
		byte[] expectedMac = m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, macInputLen);
		if (!TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac, 0, ciphertext, offset + macInputLen))
		{
			throw new TlsFatalAlert(20);
		}
		return new TlsDecodeResult(ciphertext, offset, macInputLen, recordType);
	}

	public virtual void RekeyDecoder()
	{
		throw new TlsFatalAlert(80);
	}

	public virtual void RekeyEncoder()
	{
		throw new TlsFatalAlert(80);
	}
}
