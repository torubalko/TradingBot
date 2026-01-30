using System;
using System.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsAeadCipher : TlsCipher
{
	public const int AEAD_CCM = 1;

	public const int AEAD_CHACHA20_POLY1305 = 2;

	public const int AEAD_GCM = 3;

	private const int NONCE_RFC5288 = 1;

	private const int NONCE_RFC7905 = 2;

	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly int m_keySize;

	protected readonly int m_macSize;

	protected readonly int m_fixed_iv_length;

	protected readonly int m_record_iv_length;

	protected readonly TlsAeadCipherImpl m_decryptCipher;

	protected readonly TlsAeadCipherImpl m_encryptCipher;

	protected readonly byte[] m_decryptNonce;

	protected readonly byte[] m_encryptNonce;

	protected readonly bool m_isTlsV13;

	protected readonly int m_nonceMode;

	public virtual bool UsesOpaqueRecordType => m_isTlsV13;

	public TlsAeadCipher(TlsCryptoParameters cryptoParams, TlsAeadCipherImpl encryptCipher, TlsAeadCipherImpl decryptCipher, int keySize, int macSize, int aeadType)
	{
		SecurityParameters securityParameters = cryptoParams.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (!TlsImplUtilities.IsTlsV12(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		m_isTlsV13 = TlsImplUtilities.IsTlsV13(negotiatedVersion);
		m_nonceMode = GetNonceMode(m_isTlsV13, aeadType);
		switch (m_nonceMode)
		{
		case 1:
			m_fixed_iv_length = 4;
			m_record_iv_length = 8;
			break;
		case 2:
			m_fixed_iv_length = 12;
			m_record_iv_length = 0;
			break;
		default:
			throw new TlsFatalAlert(80);
		}
		m_cryptoParams = cryptoParams;
		m_keySize = keySize;
		m_macSize = macSize;
		m_decryptCipher = decryptCipher;
		m_encryptCipher = encryptCipher;
		m_decryptNonce = new byte[m_fixed_iv_length];
		m_encryptNonce = new byte[m_fixed_iv_length];
		bool isServer = cryptoParams.IsServer;
		if (m_isTlsV13)
		{
			RekeyCipher(securityParameters, decryptCipher, m_decryptNonce, !isServer);
			RekeyCipher(securityParameters, encryptCipher, m_encryptNonce, isServer);
			return;
		}
		int keyBlockSize = 2 * keySize + 2 * m_fixed_iv_length;
		byte[] keyBlock = TlsImplUtilities.CalculateKeyBlock(cryptoParams, keyBlockSize);
		int pos = 0;
		if (isServer)
		{
			decryptCipher.SetKey(keyBlock, pos, keySize);
			pos += keySize;
			encryptCipher.SetKey(keyBlock, pos, keySize);
			pos += keySize;
			Array.Copy(keyBlock, pos, m_decryptNonce, 0, m_fixed_iv_length);
			pos += m_fixed_iv_length;
			Array.Copy(keyBlock, pos, m_encryptNonce, 0, m_fixed_iv_length);
			pos += m_fixed_iv_length;
		}
		else
		{
			encryptCipher.SetKey(keyBlock, pos, keySize);
			pos += keySize;
			decryptCipher.SetKey(keyBlock, pos, keySize);
			pos += keySize;
			Array.Copy(keyBlock, pos, m_encryptNonce, 0, m_fixed_iv_length);
			pos += m_fixed_iv_length;
			Array.Copy(keyBlock, pos, m_decryptNonce, 0, m_fixed_iv_length);
			pos += m_fixed_iv_length;
		}
		if (keyBlockSize != pos)
		{
			throw new TlsFatalAlert(80);
		}
		byte[] dummyNonce = new byte[m_fixed_iv_length + m_record_iv_length];
		dummyNonce[0] = (byte)(~m_encryptNonce[0]);
		dummyNonce[1] = (byte)(~m_decryptNonce[1]);
		encryptCipher.Init(dummyNonce, macSize, null);
		decryptCipher.Init(dummyNonce, macSize, null);
	}

	public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return plaintextLimit + m_macSize + m_record_iv_length + (m_isTlsV13 ? 1 : 0);
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		int innerPlaintextLimit = plaintextLength;
		if (m_isTlsV13)
		{
			int maxPadding = 0;
			innerPlaintextLimit = 1 + System.Math.Min(plaintextLimit, plaintextLength + maxPadding);
		}
		return innerPlaintextLimit + m_macSize + m_record_iv_length;
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit - m_macSize - m_record_iv_length - (m_isTlsV13 ? 1 : 0);
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
		byte[] nonce = new byte[m_encryptNonce.Length + m_record_iv_length];
		switch (m_nonceMode)
		{
		case 1:
			Array.Copy(m_encryptNonce, 0, nonce, 0, m_encryptNonce.Length);
			TlsUtilities.WriteUint64(seqNo, nonce, m_encryptNonce.Length);
			break;
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
			for (int i = 0; i < m_encryptNonce.Length; i++)
			{
				nonce[i] ^= m_encryptNonce[i];
			}
			break;
		}
		default:
			throw new TlsFatalAlert(80);
		}
		int extraLength = (m_isTlsV13 ? 1 : 0);
		int encryptionLength = m_encryptCipher.GetOutputSize(plaintextLength + extraLength);
		int ciphertextLength = m_record_iv_length + encryptionLength;
		byte[] output = new byte[headerAllocation + ciphertextLength];
		int outputPos = headerAllocation;
		if (m_record_iv_length != 0)
		{
			Array.Copy(nonce, nonce.Length - m_record_iv_length, output, outputPos, m_record_iv_length);
			outputPos += m_record_iv_length;
		}
		short recordType = (short)(m_isTlsV13 ? 23 : contentType);
		byte[] additionalData = GetAdditionalData(seqNo, recordType, recordVersion, ciphertextLength, plaintextLength);
		try
		{
			m_encryptCipher.Init(nonce, m_macSize, additionalData);
			Array.Copy(plaintext, plaintextOffset, output, outputPos, plaintextLength);
			if (m_isTlsV13)
			{
				output[outputPos + plaintextLength] = (byte)contentType;
			}
			outputPos += m_encryptCipher.DoFinal(output, outputPos, plaintextLength + extraLength, output, outputPos);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(80, alertCause);
		}
		if (outputPos != output.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return new TlsEncodeResult(output, 0, output.Length, recordType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int ciphertextOffset, int ciphertextLength)
	{
		if (GetPlaintextLimit(ciphertextLength) < 0)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] nonce = new byte[m_decryptNonce.Length + m_record_iv_length];
		switch (m_nonceMode)
		{
		case 1:
			Array.Copy(m_decryptNonce, 0, nonce, 0, m_decryptNonce.Length);
			Array.Copy(ciphertext, ciphertextOffset, nonce, nonce.Length - m_record_iv_length, m_record_iv_length);
			break;
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
			for (int i = 0; i < m_decryptNonce.Length; i++)
			{
				nonce[i] ^= m_decryptNonce[i];
			}
			break;
		}
		default:
			throw new TlsFatalAlert(80);
		}
		int encryptionOffset = ciphertextOffset + m_record_iv_length;
		int encryptionLength = ciphertextLength - m_record_iv_length;
		int plaintextLength = m_decryptCipher.GetOutputSize(encryptionLength);
		byte[] additionalData = GetAdditionalData(seqNo, recordType, recordVersion, ciphertextLength, plaintextLength);
		int outputPos;
		try
		{
			m_decryptCipher.Init(nonce, m_macSize, additionalData);
			outputPos = m_decryptCipher.DoFinal(ciphertext, encryptionOffset, encryptionLength, ciphertext, encryptionOffset);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(20, alertCause);
		}
		if (outputPos != plaintextLength)
		{
			throw new TlsFatalAlert(80);
		}
		short contentType = recordType;
		if (m_isTlsV13)
		{
			int pos = plaintextLength;
			byte octet;
			do
			{
				if (--pos < 0)
				{
					throw new TlsFatalAlert(10);
				}
				octet = ciphertext[encryptionOffset + pos];
			}
			while (octet == 0);
			contentType = (short)(octet & 0xFF);
			plaintextLength = pos;
		}
		return new TlsDecodeResult(ciphertext, encryptionOffset, plaintextLength, contentType);
	}

	public virtual void RekeyDecoder()
	{
		RekeyCipher(m_cryptoParams.SecurityParameters, m_decryptCipher, m_decryptNonce, !m_cryptoParams.IsServer);
	}

	public virtual void RekeyEncoder()
	{
		RekeyCipher(m_cryptoParams.SecurityParameters, m_encryptCipher, m_encryptNonce, m_cryptoParams.IsServer);
	}

	protected virtual byte[] GetAdditionalData(long seqNo, short recordType, ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength)
	{
		if (m_isTlsV13)
		{
			byte[] additional_data = new byte[5];
			TlsUtilities.WriteUint8(recordType, additional_data, 0);
			TlsUtilities.WriteVersion(recordVersion, additional_data, 1);
			TlsUtilities.WriteUint16(ciphertextLength, additional_data, 3);
			return additional_data;
		}
		byte[] additional_data2 = new byte[13];
		TlsUtilities.WriteUint64(seqNo, additional_data2, 0);
		TlsUtilities.WriteUint8(recordType, additional_data2, 8);
		TlsUtilities.WriteVersion(recordVersion, additional_data2, 9);
		TlsUtilities.WriteUint16(plaintextLength, additional_data2, 11);
		return additional_data2;
	}

	protected virtual void RekeyCipher(SecurityParameters securityParameters, TlsAeadCipherImpl cipher, byte[] nonce, bool serverSecret)
	{
		if (!m_isTlsV13)
		{
			throw new TlsFatalAlert(80);
		}
		TlsSecret secret = (serverSecret ? securityParameters.TrafficSecretServer : securityParameters.TrafficSecretClient);
		if (secret == null)
		{
			throw new TlsFatalAlert(80);
		}
		Setup13Cipher(cipher, nonce, secret, securityParameters.PrfCryptoHashAlgorithm);
	}

	protected virtual void Setup13Cipher(TlsAeadCipherImpl cipher, byte[] nonce, TlsSecret secret, int cryptoHashAlgorithm)
	{
		byte[] key = TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "key", TlsUtilities.EmptyBytes, m_keySize).Extract();
		byte[] iv = TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "iv", TlsUtilities.EmptyBytes, m_fixed_iv_length).Extract();
		cipher.SetKey(key, 0, m_keySize);
		Array.Copy(iv, 0, nonce, 0, m_fixed_iv_length);
		iv[0] ^= 128;
		cipher.Init(iv, m_macSize, null);
	}

	private static int GetNonceMode(bool isTLSv13, int aeadType)
	{
		switch (aeadType)
		{
		case 1:
		case 3:
			if (!isTLSv13)
			{
				return 1;
			}
			return 2;
		case 2:
			return 2;
		default:
			throw new TlsFatalAlert(80);
		}
	}
}
