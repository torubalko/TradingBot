using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsAeadCipher : TlsCipher
{
	public const int NONCE_RFC5288 = 1;

	internal const int NONCE_DRAFT_CHACHA20_POLY1305 = 2;

	protected readonly TlsContext context;

	protected readonly int macSize;

	protected readonly int record_iv_length;

	protected readonly IAeadBlockCipher encryptCipher;

	protected readonly IAeadBlockCipher decryptCipher;

	protected readonly byte[] encryptImplicitNonce;

	protected readonly byte[] decryptImplicitNonce;

	protected readonly int nonceMode;

	public TlsAeadCipher(TlsContext context, IAeadBlockCipher clientWriteCipher, IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize)
		: this(context, clientWriteCipher, serverWriteCipher, cipherKeySize, macSize, 1)
	{
	}

	internal TlsAeadCipher(TlsContext context, IAeadBlockCipher clientWriteCipher, IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize, int nonceMode)
	{
		if (!TlsUtilities.IsTlsV12(context))
		{
			throw new TlsFatalAlert(80);
		}
		this.nonceMode = nonceMode;
		int fixed_iv_length;
		switch (nonceMode)
		{
		case 1:
			fixed_iv_length = 4;
			record_iv_length = 8;
			break;
		case 2:
			fixed_iv_length = 12;
			record_iv_length = 0;
			break;
		default:
			throw new TlsFatalAlert(80);
		}
		this.context = context;
		this.macSize = macSize;
		int key_block_size = 2 * cipherKeySize + 2 * fixed_iv_length;
		byte[] array = TlsUtilities.CalculateKeyBlock(context, key_block_size);
		int offset = 0;
		KeyParameter client_write_key = new KeyParameter(array, offset, cipherKeySize);
		offset += cipherKeySize;
		KeyParameter server_write_key = new KeyParameter(array, offset, cipherKeySize);
		offset += cipherKeySize;
		byte[] client_write_IV = Arrays.CopyOfRange(array, offset, offset + fixed_iv_length);
		offset += fixed_iv_length;
		byte[] server_write_IV = Arrays.CopyOfRange(array, offset, offset + fixed_iv_length);
		offset += fixed_iv_length;
		if (offset != key_block_size)
		{
			throw new TlsFatalAlert(80);
		}
		KeyParameter encryptKey;
		KeyParameter decryptKey;
		if (context.IsServer)
		{
			encryptCipher = serverWriteCipher;
			decryptCipher = clientWriteCipher;
			encryptImplicitNonce = server_write_IV;
			decryptImplicitNonce = client_write_IV;
			encryptKey = server_write_key;
			decryptKey = client_write_key;
		}
		else
		{
			encryptCipher = clientWriteCipher;
			decryptCipher = serverWriteCipher;
			encryptImplicitNonce = client_write_IV;
			decryptImplicitNonce = server_write_IV;
			encryptKey = client_write_key;
			decryptKey = server_write_key;
		}
		byte[] dummyNonce = new byte[fixed_iv_length + record_iv_length];
		dummyNonce[0] = (byte)(~encryptImplicitNonce[0]);
		dummyNonce[1] = (byte)(~decryptImplicitNonce[1]);
		encryptCipher.Init(forEncryption: true, new AeadParameters(encryptKey, 8 * macSize, dummyNonce));
		decryptCipher.Init(forEncryption: false, new AeadParameters(decryptKey, 8 * macSize, dummyNonce));
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit - macSize - record_iv_length;
	}

	public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
	{
		byte[] nonce = new byte[encryptImplicitNonce.Length + record_iv_length];
		switch (nonceMode)
		{
		case 1:
			Array.Copy(encryptImplicitNonce, 0, nonce, 0, encryptImplicitNonce.Length);
			TlsUtilities.WriteUint64(seqNo, nonce, encryptImplicitNonce.Length);
			break;
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
			for (int i = 0; i < encryptImplicitNonce.Length; i++)
			{
				nonce[i] ^= encryptImplicitNonce[i];
			}
			break;
		}
		default:
			throw new TlsFatalAlert(80);
		}
		int ciphertextLength = encryptCipher.GetOutputSize(len);
		byte[] output = new byte[record_iv_length + ciphertextLength];
		if (record_iv_length != 0)
		{
			Array.Copy(nonce, nonce.Length - record_iv_length, output, 0, record_iv_length);
		}
		int outputPos = record_iv_length;
		byte[] additionalData = GetAdditionalData(seqNo, type, len);
		AeadParameters parameters = new AeadParameters(null, 8 * macSize, nonce, additionalData);
		try
		{
			encryptCipher.Init(forEncryption: true, parameters);
			outputPos += encryptCipher.ProcessBytes(plaintext, offset, len, output, outputPos);
			outputPos += encryptCipher.DoFinal(output, outputPos);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(80, alertCause);
		}
		if (outputPos != output.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return output;
	}

	public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
	{
		if (GetPlaintextLimit(len) < 0)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] nonce = new byte[decryptImplicitNonce.Length + record_iv_length];
		switch (nonceMode)
		{
		case 1:
			Array.Copy(decryptImplicitNonce, 0, nonce, 0, decryptImplicitNonce.Length);
			Array.Copy(ciphertext, offset, nonce, nonce.Length - record_iv_length, record_iv_length);
			break;
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
			for (int i = 0; i < decryptImplicitNonce.Length; i++)
			{
				nonce[i] ^= decryptImplicitNonce[i];
			}
			break;
		}
		default:
			throw new TlsFatalAlert(80);
		}
		int ciphertextOffset = offset + record_iv_length;
		int ciphertextLength = len - record_iv_length;
		int plaintextLength = decryptCipher.GetOutputSize(ciphertextLength);
		byte[] output = new byte[plaintextLength];
		int outputPos = 0;
		byte[] additionalData = GetAdditionalData(seqNo, type, plaintextLength);
		AeadParameters parameters = new AeadParameters(null, 8 * macSize, nonce, additionalData);
		try
		{
			decryptCipher.Init(forEncryption: false, parameters);
			outputPos += decryptCipher.ProcessBytes(ciphertext, ciphertextOffset, ciphertextLength, output, outputPos);
			outputPos += decryptCipher.DoFinal(output, outputPos);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(20, alertCause);
		}
		if (outputPos != output.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return output;
	}

	protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
	{
		byte[] additional_data = new byte[13];
		TlsUtilities.WriteUint64(seqNo, additional_data, 0);
		TlsUtilities.WriteUint8(type, additional_data, 8);
		TlsUtilities.WriteVersion(context.ServerVersion, additional_data, 9);
		TlsUtilities.WriteUint16(len, additional_data, 11);
		return additional_data;
	}
}
