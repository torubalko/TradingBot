using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsNullCipher : TlsCipher
{
	protected readonly TlsContext context;

	protected readonly TlsMac writeMac;

	protected readonly TlsMac readMac;

	public TlsNullCipher(TlsContext context)
	{
		this.context = context;
		writeMac = null;
		readMac = null;
	}

	public TlsNullCipher(TlsContext context, IDigest clientWriteDigest, IDigest serverWriteDigest)
	{
		if (clientWriteDigest == null != (serverWriteDigest == null))
		{
			throw new TlsFatalAlert(80);
		}
		this.context = context;
		TlsMac clientWriteMac = null;
		TlsMac serverWriteMac = null;
		if (clientWriteDigest != null)
		{
			int key_block_size = clientWriteDigest.GetDigestSize() + serverWriteDigest.GetDigestSize();
			byte[] key_block = TlsUtilities.CalculateKeyBlock(context, key_block_size);
			int offset = 0;
			clientWriteMac = new TlsMac(context, clientWriteDigest, key_block, offset, clientWriteDigest.GetDigestSize());
			offset += clientWriteDigest.GetDigestSize();
			serverWriteMac = new TlsMac(context, serverWriteDigest, key_block, offset, serverWriteDigest.GetDigestSize());
			offset += serverWriteDigest.GetDigestSize();
			if (offset != key_block_size)
			{
				throw new TlsFatalAlert(80);
			}
		}
		if (context.IsServer)
		{
			writeMac = serverWriteMac;
			readMac = clientWriteMac;
		}
		else
		{
			writeMac = clientWriteMac;
			readMac = serverWriteMac;
		}
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		int result = ciphertextLimit;
		if (writeMac != null)
		{
			result -= writeMac.Size;
		}
		return result;
	}

	public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
	{
		if (writeMac == null)
		{
			return Arrays.CopyOfRange(plaintext, offset, offset + len);
		}
		byte[] mac = writeMac.CalculateMac(seqNo, type, plaintext, offset, len);
		byte[] ciphertext = new byte[len + mac.Length];
		Array.Copy(plaintext, offset, ciphertext, 0, len);
		Array.Copy(mac, 0, ciphertext, len, mac.Length);
		return ciphertext;
	}

	public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
	{
		if (readMac == null)
		{
			return Arrays.CopyOfRange(ciphertext, offset, offset + len);
		}
		int macSize = readMac.Size;
		if (len < macSize)
		{
			throw new TlsFatalAlert(50);
		}
		int macInputLen = len - macSize;
		byte[] a = Arrays.CopyOfRange(ciphertext, offset + macInputLen, offset + len);
		byte[] computedMac = readMac.CalculateMac(seqNo, type, ciphertext, offset, macInputLen);
		if (!Arrays.ConstantTimeAreEqual(a, computedMac))
		{
			throw new TlsFatalAlert(20);
		}
		return Arrays.CopyOfRange(ciphertext, offset, offset + macInputLen);
	}
}
