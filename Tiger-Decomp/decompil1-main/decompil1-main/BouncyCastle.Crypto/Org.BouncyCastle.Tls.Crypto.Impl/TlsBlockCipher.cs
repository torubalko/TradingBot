using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsBlockCipher : TlsCipher
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly byte[] m_randomData;

	protected readonly bool m_encryptThenMac;

	protected readonly bool m_useExplicitIV;

	protected readonly bool m_acceptExtraPadding;

	protected readonly bool m_useExtraPadding;

	protected readonly TlsBlockCipherImpl m_decryptCipher;

	protected readonly TlsBlockCipherImpl m_encryptCipher;

	protected readonly TlsSuiteMac m_readMac;

	protected readonly TlsSuiteMac m_writeMac;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsBlockCipher(TlsCryptoParameters cryptoParams, TlsBlockCipherImpl encryptCipher, TlsBlockCipherImpl decryptCipher, TlsHmac clientMac, TlsHmac serverMac, int cipherKeySize)
	{
		SecurityParameters securityParameters = cryptoParams.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (TlsImplUtilities.IsTlsV13(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		m_cryptoParams = cryptoParams;
		m_randomData = cryptoParams.NonceGenerator.GenerateNonce(256);
		m_encryptThenMac = securityParameters.IsEncryptThenMac;
		m_useExplicitIV = TlsImplUtilities.IsTlsV11(negotiatedVersion);
		m_acceptExtraPadding = !negotiatedVersion.IsSsl;
		m_useExtraPadding = securityParameters.IsExtendedPadding && ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(negotiatedVersion) && (m_encryptThenMac || !securityParameters.IsTruncatedHmac);
		m_encryptCipher = encryptCipher;
		m_decryptCipher = decryptCipher;
		TlsBlockCipherImpl clientCipher;
		TlsBlockCipherImpl serverCipher;
		if (cryptoParams.IsServer)
		{
			clientCipher = decryptCipher;
			serverCipher = encryptCipher;
		}
		else
		{
			clientCipher = encryptCipher;
			serverCipher = decryptCipher;
		}
		int key_block_size = 2 * cipherKeySize + clientMac.MacLength + serverMac.MacLength;
		if (!m_useExplicitIV)
		{
			key_block_size += clientCipher.GetBlockSize() + serverCipher.GetBlockSize();
		}
		byte[] key_block = TlsImplUtilities.CalculateKeyBlock(cryptoParams, key_block_size);
		int offset = 0;
		clientMac.SetKey(key_block, offset, clientMac.MacLength);
		offset += clientMac.MacLength;
		serverMac.SetKey(key_block, offset, serverMac.MacLength);
		offset += serverMac.MacLength;
		clientCipher.SetKey(key_block, offset, cipherKeySize);
		offset += cipherKeySize;
		serverCipher.SetKey(key_block, offset, cipherKeySize);
		offset += cipherKeySize;
		int clientIVLength = clientCipher.GetBlockSize();
		int serverIVLength = serverCipher.GetBlockSize();
		if (m_useExplicitIV)
		{
			clientCipher.Init(new byte[clientIVLength], 0, clientIVLength);
			serverCipher.Init(new byte[serverIVLength], 0, serverIVLength);
		}
		else
		{
			clientCipher.Init(key_block, offset, clientIVLength);
			offset += clientIVLength;
			serverCipher.Init(key_block, offset, serverIVLength);
			offset += serverIVLength;
		}
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
		int blockSize = m_decryptCipher.GetBlockSize();
		int macSize = m_readMac.Size;
		int maxPadding = 256;
		return GetCiphertextLength(blockSize, macSize, maxPadding, plaintextLimit);
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int macSize = m_writeMac.Size;
		int maxPadding = (m_useExtraPadding ? 256 : blockSize);
		return GetCiphertextLength(blockSize, macSize, maxPadding, plaintextLength);
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int macSize = m_writeMac.Size;
		int plaintextLimit = ciphertextLimit;
		if (m_encryptThenMac)
		{
			plaintextLimit -= macSize;
			plaintextLimit -= plaintextLimit % blockSize;
		}
		else
		{
			plaintextLimit -= plaintextLimit % blockSize;
			plaintextLimit -= macSize;
		}
		plaintextLimit--;
		if (m_useExplicitIV)
		{
			plaintextLimit -= blockSize;
		}
		return plaintextLimit;
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int macSize = m_writeMac.Size;
		int enc_input_length = len;
		if (!m_encryptThenMac)
		{
			enc_input_length += macSize;
		}
		int padding_length = blockSize - enc_input_length % blockSize;
		if (m_useExtraPadding)
		{
			int maxExtraPadBlocks = (256 - padding_length) / blockSize;
			int actualExtraPadBlocks = ChooseExtraPadBlocks(maxExtraPadBlocks);
			padding_length += actualExtraPadBlocks * blockSize;
		}
		int totalSize = len + macSize + padding_length;
		if (m_useExplicitIV)
		{
			totalSize += blockSize;
		}
		byte[] outBuf = new byte[headerAllocation + totalSize];
		int outOff = headerAllocation;
		if (m_useExplicitIV)
		{
			Array.Copy(m_cryptoParams.NonceGenerator.GenerateNonce(blockSize), 0, outBuf, outOff, blockSize);
			outOff += blockSize;
		}
		Array.Copy(plaintext, offset, outBuf, outOff, len);
		outOff += len;
		if (!m_encryptThenMac)
		{
			byte[] mac = m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
			Array.Copy(mac, 0, outBuf, outOff, mac.Length);
			outOff += mac.Length;
		}
		byte padByte = (byte)(padding_length - 1);
		for (int i = 0; i < padding_length; i++)
		{
			outBuf[outOff++] = padByte;
		}
		m_encryptCipher.DoFinal(outBuf, headerAllocation, outOff - headerAllocation, outBuf, headerAllocation);
		if (m_encryptThenMac)
		{
			byte[] mac2 = m_writeMac.CalculateMac(seqNo, contentType, outBuf, headerAllocation, outOff - headerAllocation);
			Array.Copy(mac2, 0, outBuf, outOff, mac2.Length);
			outOff += mac2.Length;
		}
		if (outOff != outBuf.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return new TlsEncodeResult(outBuf, 0, outBuf.Length, contentType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		int blockSize = m_decryptCipher.GetBlockSize();
		int macSize = m_readMac.Size;
		int minLen = blockSize;
		minLen = ((!m_encryptThenMac) ? System.Math.Max(minLen, macSize + 1) : (minLen + macSize));
		if (m_useExplicitIV)
		{
			minLen += blockSize;
		}
		if (len < minLen)
		{
			throw new TlsFatalAlert(50);
		}
		int blocks_length = len;
		if (m_encryptThenMac)
		{
			blocks_length -= macSize;
		}
		if (blocks_length % blockSize != 0)
		{
			throw new TlsFatalAlert(21);
		}
		if (m_encryptThenMac)
		{
			byte[] expectedMac = m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, len - macSize);
			if (!TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac, 0, ciphertext, offset + len - macSize))
			{
				throw new TlsFatalAlert(20);
			}
		}
		m_decryptCipher.DoFinal(ciphertext, offset, blocks_length, ciphertext, offset);
		if (m_useExplicitIV)
		{
			offset += blockSize;
			blocks_length -= blockSize;
		}
		int totalPad = CheckPaddingConstantTime(ciphertext, offset, blocks_length, blockSize, (!m_encryptThenMac) ? macSize : 0);
		bool badMac = totalPad == 0;
		int dec_output_length = blocks_length - totalPad;
		if (!m_encryptThenMac)
		{
			dec_output_length -= macSize;
			byte[] expectedMac2 = m_readMac.CalculateMacConstantTime(seqNo, recordType, ciphertext, offset, dec_output_length, blocks_length - macSize, m_randomData);
			badMac |= !TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac2, 0, ciphertext, offset + dec_output_length);
		}
		if (badMac)
		{
			throw new TlsFatalAlert(20);
		}
		return new TlsDecodeResult(ciphertext, offset, dec_output_length, recordType);
	}

	public virtual void RekeyDecoder()
	{
		throw new TlsFatalAlert(80);
	}

	public virtual void RekeyEncoder()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
	{
		int end = off + len;
		byte lastByte = buf[end - 1];
		int totalPad = (lastByte & 0xFF) + 1;
		int dummyIndex = 0;
		byte padDiff = 0;
		int totalPadLimit = System.Math.Min(m_acceptExtraPadding ? 256 : blockSize, len - macSize);
		if (totalPad > totalPadLimit)
		{
			totalPad = 0;
		}
		else
		{
			int padPos = end - totalPad;
			do
			{
				padDiff |= (byte)(buf[padPos++] ^ lastByte);
			}
			while (padPos < end);
			dummyIndex = totalPad;
			if (padDiff != 0)
			{
				totalPad = 0;
			}
		}
		byte[] dummyPad = m_randomData;
		while (dummyIndex < 256)
		{
			padDiff |= (byte)(dummyPad[dummyIndex++] ^ lastByte);
		}
		dummyPad[0] ^= padDiff;
		return totalPad;
	}

	protected virtual int ChooseExtraPadBlocks(int max)
	{
		return System.Math.Min(Integers.NumberOfTrailingZeros((int)Pack.LE_To_UInt32(m_cryptoParams.NonceGenerator.GenerateNonce(4), 0)), max);
	}

	protected virtual int GetCiphertextLength(int blockSize, int macSize, int maxPadding, int plaintextLength)
	{
		int ciphertextLength = plaintextLength;
		if (m_useExplicitIV)
		{
			ciphertextLength += blockSize;
		}
		ciphertextLength += maxPadding;
		if (m_encryptThenMac)
		{
			ciphertextLength -= ciphertextLength % blockSize;
			return ciphertextLength + macSize;
		}
		ciphertextLength += macSize;
		return ciphertextLength - ciphertextLength % blockSize;
	}
}
