using System;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security.Ntlm;

internal static class ChallengeResponse2
{
	private static readonly byte[] Magic = new byte[8] { 75, 71, 83, 33, 64, 35, 36, 37 };

	private static readonly byte[] NullEncMagic = new byte[8] { 170, 211, 180, 53, 181, 20, 4, 238 };

	private static byte[] ComputeLM(string password, byte[] challenge)
	{
		byte[] array = new byte[21];
		using (DES dES = DES.Create())
		{
			dES.Mode = CipherMode.ECB;
			if (string.IsNullOrEmpty(password))
			{
				Buffer.BlockCopy(NullEncMagic, 0, array, 0, 8);
			}
			else
			{
				dES.Key = PasswordToKey(password, 0);
				using ICryptoTransform cryptoTransform = dES.CreateEncryptor();
				cryptoTransform.TransformBlock(Magic, 0, 8, array, 0);
			}
			if (password == null || password.Length < 8)
			{
				Buffer.BlockCopy(NullEncMagic, 0, array, 8, 8);
			}
			else
			{
				dES.Key = PasswordToKey(password, 7);
				using ICryptoTransform cryptoTransform2 = dES.CreateEncryptor();
				cryptoTransform2.TransformBlock(Magic, 0, 8, array, 8);
			}
		}
		return GetResponse(challenge, array);
	}

	private static byte[] ComputeNtlmPassword(string password)
	{
		byte[] array = new byte[21];
		using MD4 mD = new MD4();
		byte[] array2 = ((password == null) ? new byte[0] : Encoding.Unicode.GetBytes(password));
		byte[] array3 = mD.ComputeHash(array2);
		Buffer.BlockCopy(array3, 0, array, 0, 16);
		Array.Clear(array2, 0, array2.Length);
		Array.Clear(array3, 0, array3.Length);
		return array;
	}

	private static byte[] ComputeNtlm(string password, byte[] challenge)
	{
		byte[] pwd = ComputeNtlmPassword(password);
		return GetResponse(challenge, pwd);
	}

	private static void ComputeNtlmV2Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm)
	{
		byte[] array = new byte[8];
		using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
		{
			randomNumberGenerator.GetBytes(array);
		}
		byte[] array2 = new byte[challenge.Length + 8];
		challenge.CopyTo(array2, 0);
		array.CopyTo(array2, challenge.Length);
		lm = new byte[24];
		array.CopyTo(lm, 0);
		using (MD5 mD = MD5.Create())
		{
			byte[] array3 = mD.ComputeHash(array2);
			byte[] array4 = new byte[8];
			Array.Copy(array3, array4, 8);
			ntlm = ComputeNtlm(password, array4);
			Array.Clear(array4, 0, array4.Length);
			Array.Clear(array3, 0, array3.Length);
		}
		Array.Clear(array2, 0, array2.Length);
		Array.Clear(array, 0, array.Length);
	}

	private static byte[] ComputeNtlmV2(Type2Message type2, string username, string password, string domain)
	{
		byte[] array = ComputeNtlmPassword(password);
		byte[] bytes = Encoding.Unicode.GetBytes(username.ToUpperInvariant());
		byte[] bytes2 = Encoding.Unicode.GetBytes(domain);
		byte[] array2 = new byte[bytes.Length + bytes2.Length];
		bytes.CopyTo(array2, 0);
		Array.Copy(bytes2, 0, array2, bytes.Length, bytes2.Length);
		byte[] array3;
		using (HMACMD5 hMACMD = new HMACMD5(array))
		{
			array3 = hMACMD.ComputeHash(array2);
		}
		Array.Clear(array, 0, array.Length);
		using HMACMD5 hMACMD2 = new HMACMD5(array3);
		long value = DateTime.UtcNow.Ticks - 504911232000000000L;
		byte[] array4 = new byte[8];
		TargetInfo targetInfo = type2.TargetInfo;
		if (targetInfo == null || targetInfo.Timestamp != 0)
		{
			value = type2.TargetInfo.Timestamp;
		}
		using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
		{
			randomNumberGenerator.GetBytes(array4);
		}
		byte[] encodedTargetInfo = type2.EncodedTargetInfo;
		byte[] array5 = new byte[28 + encodedTargetInfo.Length];
		array5[0] = 1;
		array5[1] = 1;
		Buffer.BlockCopy(BitConverterLE.GetBytes(value), 0, array5, 8, 8);
		Buffer.BlockCopy(array4, 0, array5, 16, 8);
		Buffer.BlockCopy(encodedTargetInfo, 0, array5, 28, encodedTargetInfo.Length);
		byte[] nonce = type2.Nonce;
		byte[] array6 = new byte[nonce.Length + array5.Length];
		nonce.CopyTo(array6, 0);
		array5.CopyTo(array6, nonce.Length);
		byte[] array7 = hMACMD2.ComputeHash(array6);
		byte[] array8 = new byte[array5.Length + array7.Length];
		array7.CopyTo(array8, 0);
		array5.CopyTo(array8, array7.Length);
		Array.Clear(array3, 0, array3.Length);
		Array.Clear(array6, 0, array6.Length);
		Array.Clear(array7, 0, array7.Length);
		Array.Clear(array4, 0, array4.Length);
		Array.Clear(array5, 0, array5.Length);
		return array8;
	}

	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm)
	{
		lm = null;
		switch (level)
		{
		case NtlmAuthLevel.LM_and_NTLM:
			lm = ComputeLM(password, type2.Nonce);
			ntlm = ComputeNtlm(password, type2.Nonce);
			break;
		case NtlmAuthLevel.LM_and_NTLM_and_try_NTLMv2_Session:
			if ((type2.Flags & NtlmFlags.NegotiateNtlm2Key) != 0)
			{
				ComputeNtlmV2Session(password, type2.Nonce, out lm, out ntlm);
				break;
			}
			goto case NtlmAuthLevel.LM_and_NTLM;
		case NtlmAuthLevel.NTLM_only:
			if ((type2.Flags & NtlmFlags.NegotiateNtlm2Key) != 0)
			{
				ComputeNtlmV2Session(password, type2.Nonce, out lm, out ntlm);
			}
			else
			{
				ntlm = ComputeNtlm(password, type2.Nonce);
			}
			break;
		case NtlmAuthLevel.NTLMv2_only:
			ntlm = ComputeNtlmV2(type2, username, password, domain);
			if (type2.TargetInfo.Timestamp != 0L)
			{
				lm = new byte[24];
			}
			break;
		default:
			throw new InvalidOperationException();
		}
	}

	private static byte[] GetResponse(byte[] challenge, byte[] pwd)
	{
		byte[] array = new byte[24];
		using DES dES = DES.Create();
		dES.Mode = CipherMode.ECB;
		dES.Key = PrepareDESKey(pwd, 0);
		using (ICryptoTransform cryptoTransform = dES.CreateEncryptor())
		{
			cryptoTransform.TransformBlock(challenge, 0, 8, array, 0);
		}
		dES.Key = PrepareDESKey(pwd, 7);
		using (ICryptoTransform cryptoTransform2 = dES.CreateEncryptor())
		{
			cryptoTransform2.TransformBlock(challenge, 0, 8, array, 8);
		}
		dES.Key = PrepareDESKey(pwd, 14);
		using ICryptoTransform cryptoTransform3 = dES.CreateEncryptor();
		cryptoTransform3.TransformBlock(challenge, 0, 8, array, 16);
		return array;
	}

	private static byte[] PrepareDESKey(byte[] key56bits, int position)
	{
		return new byte[8]
		{
			key56bits[position],
			(byte)((key56bits[position] << 7) | (key56bits[position + 1] >> 1)),
			(byte)((key56bits[position + 1] << 6) | (key56bits[position + 2] >> 2)),
			(byte)((key56bits[position + 2] << 5) | (key56bits[position + 3] >> 3)),
			(byte)((key56bits[position + 3] << 4) | (key56bits[position + 4] >> 4)),
			(byte)((key56bits[position + 4] << 3) | (key56bits[position + 5] >> 5)),
			(byte)((key56bits[position + 5] << 2) | (key56bits[position + 6] >> 6)),
			(byte)(key56bits[position + 6] << 1)
		};
	}

	private static byte[] PasswordToKey(string password, int position)
	{
		int charCount = Math.Min(password.Length - position, 7);
		byte[] array = new byte[7];
		Encoding.ASCII.GetBytes(password.ToUpper(), position, charCount, array, 0);
		byte[] result = PrepareDESKey(array, 0);
		Array.Clear(array, 0, array.Length);
		return result;
	}
}
