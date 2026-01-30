using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsBlockCipher : TlsCipher
{
	protected readonly TlsContext context;

	protected readonly byte[] randomData;

	protected readonly bool useExplicitIV;

	protected readonly bool encryptThenMac;

	protected readonly IBlockCipher encryptCipher;

	protected readonly IBlockCipher decryptCipher;

	protected readonly TlsMac mWriteMac;

	protected readonly TlsMac mReadMac;

	public virtual TlsMac WriteMac => mWriteMac;

	public virtual TlsMac ReadMac => mReadMac;

	public TlsBlockCipher(TlsContext context, IBlockCipher clientWriteCipher, IBlockCipher serverWriteCipher, IDigest clientWriteDigest, IDigest serverWriteDigest, int cipherKeySize)
	{
		this.context = context;
		randomData = new byte[256];
		context.NonceRandomGenerator.NextBytes(randomData);
		useExplicitIV = TlsUtilities.IsTlsV11(context);
		encryptThenMac = context.SecurityParameters.encryptThenMac;
		int key_block_size = 2 * cipherKeySize + clientWriteDigest.GetDigestSize() + serverWriteDigest.GetDigestSize();
		if (!useExplicitIV)
		{
			key_block_size += clientWriteCipher.GetBlockSize() + serverWriteCipher.GetBlockSize();
		}
		byte[] key_block = TlsUtilities.CalculateKeyBlock(context, key_block_size);
		int offset = 0;
		TlsMac clientWriteMac = new TlsMac(context, clientWriteDigest, key_block, offset, clientWriteDigest.GetDigestSize());
		offset += clientWriteDigest.GetDigestSize();
		TlsMac serverWriteMac = new TlsMac(context, serverWriteDigest, key_block, offset, serverWriteDigest.GetDigestSize());
		offset += serverWriteDigest.GetDigestSize();
		KeyParameter client_write_key = new KeyParameter(key_block, offset, cipherKeySize);
		offset += cipherKeySize;
		KeyParameter server_write_key = new KeyParameter(key_block, offset, cipherKeySize);
		offset += cipherKeySize;
		byte[] client_write_IV;
		byte[] server_write_IV;
		if (useExplicitIV)
		{
			client_write_IV = new byte[clientWriteCipher.GetBlockSize()];
			server_write_IV = new byte[serverWriteCipher.GetBlockSize()];
		}
		else
		{
			client_write_IV = Arrays.CopyOfRange(key_block, offset, offset + clientWriteCipher.GetBlockSize());
			offset += clientWriteCipher.GetBlockSize();
			server_write_IV = Arrays.CopyOfRange(key_block, offset, offset + serverWriteCipher.GetBlockSize());
			offset += serverWriteCipher.GetBlockSize();
		}
		if (offset != key_block_size)
		{
			throw new TlsFatalAlert(80);
		}
		ICipherParameters encryptParams;
		ICipherParameters decryptParams;
		if (context.IsServer)
		{
			mWriteMac = serverWriteMac;
			mReadMac = clientWriteMac;
			encryptCipher = serverWriteCipher;
			decryptCipher = clientWriteCipher;
			encryptParams = new ParametersWithIV(server_write_key, server_write_IV);
			decryptParams = new ParametersWithIV(client_write_key, client_write_IV);
		}
		else
		{
			mWriteMac = clientWriteMac;
			mReadMac = serverWriteMac;
			encryptCipher = clientWriteCipher;
			decryptCipher = serverWriteCipher;
			encryptParams = new ParametersWithIV(client_write_key, client_write_IV);
			decryptParams = new ParametersWithIV(server_write_key, server_write_IV);
		}
		encryptCipher.Init(forEncryption: true, encryptParams);
		decryptCipher.Init(forEncryption: false, decryptParams);
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		int blockSize = encryptCipher.GetBlockSize();
		int macSize = mWriteMac.Size;
		int plaintextLimit = ciphertextLimit;
		if (useExplicitIV)
		{
			plaintextLimit -= blockSize;
		}
		if (encryptThenMac)
		{
			plaintextLimit -= macSize;
			plaintextLimit -= plaintextLimit % blockSize;
		}
		else
		{
			plaintextLimit -= plaintextLimit % blockSize;
			plaintextLimit -= macSize;
		}
		return plaintextLimit - 1;
	}

	public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
	{
		int blockSize = encryptCipher.GetBlockSize();
		int macSize = mWriteMac.Size;
		ProtocolVersion version = context.ServerVersion;
		int enc_input_length = len;
		if (!encryptThenMac)
		{
			enc_input_length += macSize;
		}
		int padding_length = blockSize - 1 - enc_input_length % blockSize;
		if ((encryptThenMac || !context.SecurityParameters.truncatedHMac) && !version.IsDtls && !version.IsSsl)
		{
			int maxExtraPadBlocks = (255 - padding_length) / blockSize;
			int actualExtraPadBlocks = ChooseExtraPadBlocks(context.SecureRandom, maxExtraPadBlocks);
			padding_length += actualExtraPadBlocks * blockSize;
		}
		int totalSize = len + macSize + padding_length + 1;
		if (useExplicitIV)
		{
			totalSize += blockSize;
		}
		byte[] outBuf = new byte[totalSize];
		int outOff = 0;
		if (useExplicitIV)
		{
			byte[] explicitIV = new byte[blockSize];
			context.NonceRandomGenerator.NextBytes(explicitIV);
			encryptCipher.Init(forEncryption: true, new ParametersWithIV(null, explicitIV));
			Array.Copy(explicitIV, 0, outBuf, outOff, blockSize);
			outOff += blockSize;
		}
		int blocks_start = outOff;
		Array.Copy(plaintext, offset, outBuf, outOff, len);
		outOff += len;
		if (!encryptThenMac)
		{
			byte[] mac = mWriteMac.CalculateMac(seqNo, type, plaintext, offset, len);
			Array.Copy(mac, 0, outBuf, outOff, mac.Length);
			outOff += mac.Length;
		}
		for (int i = 0; i <= padding_length; i++)
		{
			outBuf[outOff++] = (byte)padding_length;
		}
		for (int j = blocks_start; j < outOff; j += blockSize)
		{
			encryptCipher.ProcessBlock(outBuf, j, outBuf, j);
		}
		if (encryptThenMac)
		{
			byte[] mac2 = mWriteMac.CalculateMac(seqNo, type, outBuf, 0, outOff);
			Array.Copy(mac2, 0, outBuf, outOff, mac2.Length);
			outOff += mac2.Length;
		}
		return outBuf;
	}

	public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
	{
		int blockSize = decryptCipher.GetBlockSize();
		int macSize = mReadMac.Size;
		int minLen = blockSize;
		minLen = ((!encryptThenMac) ? System.Math.Max(minLen, macSize + 1) : (minLen + macSize));
		if (useExplicitIV)
		{
			minLen += blockSize;
		}
		if (len < minLen)
		{
			throw new TlsFatalAlert(50);
		}
		int blocks_length = len;
		if (encryptThenMac)
		{
			blocks_length -= macSize;
		}
		if (blocks_length % blockSize != 0)
		{
			throw new TlsFatalAlert(21);
		}
		if (encryptThenMac)
		{
			int end = offset + len;
			byte[] receivedMac = Arrays.CopyOfRange(ciphertext, end - macSize, end);
			if (!Arrays.ConstantTimeAreEqual(mReadMac.CalculateMac(seqNo, type, ciphertext, offset, len - macSize), receivedMac))
			{
				throw new TlsFatalAlert(20);
			}
		}
		if (useExplicitIV)
		{
			decryptCipher.Init(forEncryption: false, new ParametersWithIV(null, ciphertext, offset, blockSize));
			offset += blockSize;
			blocks_length -= blockSize;
		}
		for (int i = 0; i < blocks_length; i += blockSize)
		{
			decryptCipher.ProcessBlock(ciphertext, offset + i, ciphertext, offset + i);
		}
		int totalPad = CheckPaddingConstantTime(ciphertext, offset, blocks_length, blockSize, (!encryptThenMac) ? macSize : 0);
		bool badMac = totalPad == 0;
		int dec_output_length = blocks_length - totalPad;
		if (!encryptThenMac)
		{
			dec_output_length -= macSize;
			int macInputLen = dec_output_length;
			int macOff = offset + macInputLen;
			byte[] receivedMac2 = Arrays.CopyOfRange(ciphertext, macOff, macOff + macSize);
			byte[] calculatedMac = mReadMac.CalculateMacConstantTime(seqNo, type, ciphertext, offset, macInputLen, blocks_length - macSize, randomData);
			badMac |= !Arrays.ConstantTimeAreEqual(calculatedMac, receivedMac2);
		}
		if (badMac)
		{
			throw new TlsFatalAlert(20);
		}
		return Arrays.CopyOfRange(ciphertext, offset, offset + dec_output_length);
	}

	protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
	{
		int end = off + len;
		byte lastByte = buf[end - 1];
		int totalPad = (lastByte & 0xFF) + 1;
		int dummyIndex = 0;
		byte padDiff = 0;
		if ((TlsUtilities.IsSsl(context) && totalPad > blockSize) || macSize + totalPad > len)
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
		byte[] dummyPad = randomData;
		while (dummyIndex < 256)
		{
			padDiff |= (byte)(dummyPad[dummyIndex++] ^ lastByte);
		}
		dummyPad[0] ^= padDiff;
		return totalPad;
	}

	protected virtual int ChooseExtraPadBlocks(SecureRandom r, int max)
	{
		int x = r.NextInt();
		return System.Math.Min(LowestBitSet(x), max);
	}

	protected virtual int LowestBitSet(int x)
	{
		if (x == 0)
		{
			return 32;
		}
		uint ux = (uint)x;
		int n = 0;
		while ((ux & 1) == 0)
		{
			n++;
			ux >>= 1;
		}
		return n;
	}
}
