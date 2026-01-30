using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public sealed class PgpUtilities
{
	private const int ReadAhead = 60;

	private PgpUtilities()
	{
	}

	public static MPInteger[] DsaSigToMpi(byte[] encoding)
	{
		DerInteger i1;
		DerInteger i2;
		try
		{
			Asn1Sequence instance = Asn1Sequence.GetInstance(encoding);
			i1 = DerInteger.GetInstance(instance[0]);
			i2 = DerInteger.GetInstance(instance[1]);
		}
		catch (Exception exception)
		{
			throw new PgpException("exception encoding signature", exception);
		}
		return new MPInteger[2]
		{
			new MPInteger(i1.Value),
			new MPInteger(i2.Value)
		};
	}

	public static MPInteger[] RsaSigToMpi(byte[] encoding)
	{
		return new MPInteger[1]
		{
			new MPInteger(new BigInteger(1, encoding))
		};
	}

	public static string GetDigestName(HashAlgorithmTag hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			HashAlgorithmTag.Sha1 => "SHA1", 
			HashAlgorithmTag.MD2 => "MD2", 
			HashAlgorithmTag.MD5 => "MD5", 
			HashAlgorithmTag.RipeMD160 => "RIPEMD160", 
			HashAlgorithmTag.Sha224 => "SHA224", 
			HashAlgorithmTag.Sha256 => "SHA256", 
			HashAlgorithmTag.Sha384 => "SHA384", 
			HashAlgorithmTag.Sha512 => "SHA512", 
			_ => throw new PgpException("unknown hash algorithm tag in GetDigestName: " + hashAlgorithm), 
		};
	}

	public static string GetSignatureName(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
	{
		string encAlg;
		switch (keyAlgorithm)
		{
		case PublicKeyAlgorithmTag.RsaGeneral:
		case PublicKeyAlgorithmTag.RsaSign:
			encAlg = "RSA";
			break;
		case PublicKeyAlgorithmTag.Dsa:
			encAlg = "DSA";
			break;
		case PublicKeyAlgorithmTag.EC:
			encAlg = "ECDH";
			break;
		case PublicKeyAlgorithmTag.ECDsa:
			encAlg = "ECDSA";
			break;
		case PublicKeyAlgorithmTag.ElGamalEncrypt:
		case PublicKeyAlgorithmTag.ElGamalGeneral:
			encAlg = "ElGamal";
			break;
		default:
			throw new PgpException("unknown algorithm tag in signature:" + keyAlgorithm);
		}
		return GetDigestName(hashAlgorithm) + "with" + encAlg;
	}

	public static string GetSymmetricCipherName(SymmetricKeyAlgorithmTag algorithm)
	{
		return algorithm switch
		{
			SymmetricKeyAlgorithmTag.Null => null, 
			SymmetricKeyAlgorithmTag.TripleDes => "DESEDE", 
			SymmetricKeyAlgorithmTag.Idea => "IDEA", 
			SymmetricKeyAlgorithmTag.Cast5 => "CAST5", 
			SymmetricKeyAlgorithmTag.Blowfish => "Blowfish", 
			SymmetricKeyAlgorithmTag.Safer => "SAFER", 
			SymmetricKeyAlgorithmTag.Des => "DES", 
			SymmetricKeyAlgorithmTag.Aes128 => "AES", 
			SymmetricKeyAlgorithmTag.Aes192 => "AES", 
			SymmetricKeyAlgorithmTag.Aes256 => "AES", 
			SymmetricKeyAlgorithmTag.Twofish => "Twofish", 
			SymmetricKeyAlgorithmTag.Camellia128 => "Camellia", 
			SymmetricKeyAlgorithmTag.Camellia192 => "Camellia", 
			SymmetricKeyAlgorithmTag.Camellia256 => "Camellia", 
			_ => throw new PgpException("unknown symmetric algorithm: " + algorithm), 
		};
	}

	public static int GetKeySize(SymmetricKeyAlgorithmTag algorithm)
	{
		switch (algorithm)
		{
		case SymmetricKeyAlgorithmTag.Des:
			return 64;
		case SymmetricKeyAlgorithmTag.Idea:
		case SymmetricKeyAlgorithmTag.Cast5:
		case SymmetricKeyAlgorithmTag.Blowfish:
		case SymmetricKeyAlgorithmTag.Safer:
		case SymmetricKeyAlgorithmTag.Aes128:
		case SymmetricKeyAlgorithmTag.Camellia128:
			return 128;
		case SymmetricKeyAlgorithmTag.TripleDes:
		case SymmetricKeyAlgorithmTag.Aes192:
		case SymmetricKeyAlgorithmTag.Camellia192:
			return 192;
		case SymmetricKeyAlgorithmTag.Aes256:
		case SymmetricKeyAlgorithmTag.Twofish:
		case SymmetricKeyAlgorithmTag.Camellia256:
			return 256;
		default:
			throw new PgpException("unknown symmetric algorithm: " + algorithm);
		}
	}

	public static KeyParameter MakeKey(SymmetricKeyAlgorithmTag algorithm, byte[] keyBytes)
	{
		return ParameterUtilities.CreateKeyParameter(GetSymmetricCipherName(algorithm), keyBytes);
	}

	public static KeyParameter MakeRandomKey(SymmetricKeyAlgorithmTag algorithm, SecureRandom random)
	{
		byte[] keyBytes = new byte[(GetKeySize(algorithm) + 7) / 8];
		random.NextBytes(keyBytes);
		return MakeKey(algorithm, keyBytes);
	}

	internal static byte[] EncodePassPhrase(char[] passPhrase, bool utf8)
	{
		if (passPhrase != null)
		{
			if (!utf8)
			{
				return Strings.ToByteArray(passPhrase);
			}
			return Encoding.UTF8.GetBytes(passPhrase);
		}
		return null;
	}

	public static KeyParameter MakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
	{
		return DoMakeKeyFromPassPhrase(algorithm, s2k, EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true);
	}

	public static KeyParameter MakeKeyFromPassPhraseUtf8(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
	{
		return DoMakeKeyFromPassPhrase(algorithm, s2k, EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true);
	}

	public static KeyParameter MakeKeyFromPassPhraseRaw(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase)
	{
		return DoMakeKeyFromPassPhrase(algorithm, s2k, rawPassPhrase, clearPassPhrase: false);
	}

	internal static KeyParameter DoMakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase, bool clearPassPhrase)
	{
		byte[] keyBytes = new byte[(GetKeySize(algorithm) + 7) / 8];
		int generatedBytes = 0;
		int loopCount = 0;
		while (generatedBytes < keyBytes.Length)
		{
			IDigest digest;
			if (s2k != null)
			{
				string digestName = GetDigestName(s2k.HashAlgorithm);
				try
				{
					digest = DigestUtilities.GetDigest(digestName);
				}
				catch (Exception exception)
				{
					throw new PgpException("can't find S2k digest", exception);
				}
				for (int i = 0; i != loopCount; i++)
				{
					digest.Update(0);
				}
				byte[] iv = s2k.GetIV();
				switch (s2k.Type)
				{
				case 0:
					digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
					break;
				case 1:
					digest.BlockUpdate(iv, 0, iv.Length);
					digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
					break;
				case 3:
				{
					long count = s2k.IterationCount;
					digest.BlockUpdate(iv, 0, iv.Length);
					digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
					count -= iv.Length + rawPassPhrase.Length;
					while (count > 0)
					{
						if (count < iv.Length)
						{
							digest.BlockUpdate(iv, 0, (int)count);
							break;
						}
						digest.BlockUpdate(iv, 0, iv.Length);
						count -= iv.Length;
						if (count < rawPassPhrase.Length)
						{
							digest.BlockUpdate(rawPassPhrase, 0, (int)count);
							count = 0L;
						}
						else
						{
							digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
							count -= rawPassPhrase.Length;
						}
					}
					break;
				}
				default:
					throw new PgpException("unknown S2k type: " + s2k.Type);
				}
			}
			else
			{
				try
				{
					digest = DigestUtilities.GetDigest("MD5");
					for (int j = 0; j != loopCount; j++)
					{
						digest.Update(0);
					}
					digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
				}
				catch (Exception exception2)
				{
					throw new PgpException("can't find MD5 digest", exception2);
				}
			}
			byte[] dig = DigestUtilities.DoFinal(digest);
			if (dig.Length > keyBytes.Length - generatedBytes)
			{
				Array.Copy(dig, 0, keyBytes, generatedBytes, keyBytes.Length - generatedBytes);
			}
			else
			{
				Array.Copy(dig, 0, keyBytes, generatedBytes, dig.Length);
			}
			generatedBytes += dig.Length;
			loopCount++;
		}
		if (clearPassPhrase && rawPassPhrase != null)
		{
			Array.Clear(rawPassPhrase, 0, rawPassPhrase.Length);
		}
		return MakeKey(algorithm, keyBytes);
	}

	public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file)
	{
		Stream pOut = new PgpLiteralDataGenerator().Open(output, fileType, file.Name, file.Length, file.LastWriteTime);
		PipeFileContents(file, pOut, 32768);
	}

	public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file, byte[] buffer)
	{
		Stream pOut = new PgpLiteralDataGenerator().Open(output, fileType, file.Name, file.LastWriteTime, buffer);
		PipeFileContents(file, pOut, buffer.Length);
	}

	private static void PipeFileContents(FileInfo file, Stream pOut, int bufSize)
	{
		FileStream inputStream = file.OpenRead();
		byte[] buf = new byte[bufSize];
		try
		{
			int len;
			while ((len = inputStream.Read(buf, 0, buf.Length)) > 0)
			{
				pOut.Write(buf, 0, len);
			}
		}
		finally
		{
			Array.Clear(buf, 0, buf.Length);
			Platform.Dispose(pOut);
			Platform.Dispose(inputStream);
		}
	}

	private static bool IsPossiblyBase64(int ch)
	{
		if ((ch < 65 || ch > 90) && (ch < 97 || ch > 122) && (ch < 48 || ch > 57) && ch != 43 && ch != 47 && ch != 13)
		{
			return ch == 10;
		}
		return true;
	}

	public static Stream GetDecoderStream(Stream inputStream)
	{
		if (!inputStream.CanSeek)
		{
			throw new ArgumentException("inputStream must be seek-able", "inputStream");
		}
		long markedPos = inputStream.Position;
		int ch = inputStream.ReadByte();
		if ((ch & 0x80) != 0)
		{
			inputStream.Position = markedPos;
			return inputStream;
		}
		if (!IsPossiblyBase64(ch))
		{
			inputStream.Position = markedPos;
			return new ArmoredInputStream(inputStream);
		}
		byte[] buf = new byte[60];
		int count = 1;
		int index = 1;
		buf[0] = (byte)ch;
		for (; count != 60; count++)
		{
			if ((ch = inputStream.ReadByte()) < 0)
			{
				break;
			}
			if (!IsPossiblyBase64(ch))
			{
				inputStream.Position = markedPos;
				return new ArmoredInputStream(inputStream);
			}
			if (ch != 10 && ch != 13)
			{
				buf[index++] = (byte)ch;
			}
		}
		inputStream.Position = markedPos;
		if (count < 4)
		{
			return new ArmoredInputStream(inputStream);
		}
		byte[] firstBlock = new byte[8];
		Array.Copy(buf, 0, firstBlock, 0, firstBlock.Length);
		try
		{
			bool hasHeaders = (Base64.Decode(firstBlock)[0] & 0x80) == 0;
			return new ArmoredInputStream(inputStream, hasHeaders);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception ex2)
		{
			throw new IOException(ex2.Message);
		}
	}

	internal static IWrapper CreateWrapper(SymmetricKeyAlgorithmTag encAlgorithm)
	{
		switch (encAlgorithm)
		{
		case SymmetricKeyAlgorithmTag.Aes128:
		case SymmetricKeyAlgorithmTag.Aes192:
		case SymmetricKeyAlgorithmTag.Aes256:
			return WrapperUtilities.GetWrapper("AESWRAP");
		case SymmetricKeyAlgorithmTag.Camellia128:
		case SymmetricKeyAlgorithmTag.Camellia192:
		case SymmetricKeyAlgorithmTag.Camellia256:
			return WrapperUtilities.GetWrapper("CAMELLIAWRAP");
		default:
			throw new PgpException("unknown wrap algorithm: " + encAlgorithm);
		}
	}

	internal static byte[] GenerateIV(int length, SecureRandom random)
	{
		byte[] iv = new byte[length];
		random.NextBytes(iv);
		return iv;
	}

	internal static S2k GenerateS2k(HashAlgorithmTag hashAlgorithm, int s2kCount, SecureRandom random)
	{
		byte[] iv = GenerateIV(8, random);
		return new S2k(hashAlgorithm, iv, s2kCount);
	}
}
