using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpPbeEncryptedData : PgpEncryptedData
{
	private readonly SymmetricKeyEncSessionPacket keyData;

	internal PgpPbeEncryptedData(SymmetricKeyEncSessionPacket keyData, InputStreamPacket encData)
		: base(encData)
	{
		this.keyData = keyData;
	}

	public override Stream GetInputStream()
	{
		return encData.GetInputStream();
	}

	public Stream GetDataStream(char[] passPhrase)
	{
		return DoGetDataStream(PgpUtilities.EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true);
	}

	public Stream GetDataStreamUtf8(char[] passPhrase)
	{
		return DoGetDataStream(PgpUtilities.EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true);
	}

	public Stream GetDataStreamRaw(byte[] rawPassPhrase)
	{
		return DoGetDataStream(rawPassPhrase, clearPassPhrase: false);
	}

	internal Stream DoGetDataStream(byte[] rawPassPhrase, bool clearPassPhrase)
	{
		try
		{
			SymmetricKeyAlgorithmTag keyAlgorithm = keyData.EncAlgorithm;
			KeyParameter key = PgpUtilities.DoMakeKeyFromPassPhrase(keyAlgorithm, keyData.S2k, rawPassPhrase, clearPassPhrase);
			byte[] secKeyData = keyData.GetSecKeyData();
			if (secKeyData != null && secKeyData.Length != 0)
			{
				IBufferedCipher keyCipher = CipherUtilities.GetCipher(PgpUtilities.GetSymmetricCipherName(keyAlgorithm) + "/CFB/NoPadding");
				keyCipher.Init(forEncryption: false, new ParametersWithIV(key, new byte[keyCipher.GetBlockSize()]));
				byte[] keyBytes = keyCipher.DoFinal(secKeyData);
				keyAlgorithm = (SymmetricKeyAlgorithmTag)keyBytes[0];
				key = ParameterUtilities.CreateKeyParameter(PgpUtilities.GetSymmetricCipherName(keyAlgorithm), keyBytes, 1, keyBytes.Length - 1);
			}
			IBufferedCipher c = CreateStreamCipher(keyAlgorithm);
			byte[] iv = new byte[c.GetBlockSize()];
			c.Init(forEncryption: false, new ParametersWithIV(key, iv));
			encStream = BcpgInputStream.Wrap(new CipherStream(encData.GetInputStream(), c, null));
			if (encData is SymmetricEncIntegrityPacket)
			{
				truncStream = new TruncatedStream(encStream);
				IDigest digest = DigestUtilities.GetDigest(PgpUtilities.GetDigestName(HashAlgorithmTag.Sha1));
				encStream = new DigestStream(truncStream, digest, null);
			}
			if (Streams.ReadFully(encStream, iv, 0, iv.Length) < iv.Length)
			{
				throw new EndOfStreamException("unexpected end of stream.");
			}
			int v1 = encStream.ReadByte();
			int v2 = encStream.ReadByte();
			if (v1 < 0 || v2 < 0)
			{
				throw new EndOfStreamException("unexpected end of stream.");
			}
			bool num = iv[iv.Length - 2] == (byte)v1 && iv[iv.Length - 1] == (byte)v2;
			bool zeroesCheckPassed = v1 == 0 && v2 == 0;
			if (!num && !zeroesCheckPassed)
			{
				throw new PgpDataValidationException("quick check failed.");
			}
			return encStream;
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception creating cipher", exception);
		}
	}

	private IBufferedCipher CreateStreamCipher(SymmetricKeyAlgorithmTag keyAlgorithm)
	{
		string mode = ((encData is SymmetricEncIntegrityPacket) ? "CFB" : "OpenPGPCFB");
		return CipherUtilities.GetCipher(PgpUtilities.GetSymmetricCipherName(keyAlgorithm) + "/" + mode + "/NoPadding");
	}
}
