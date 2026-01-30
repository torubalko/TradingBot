using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security;

public class SaslMechanismCramMd5 : SaslMechanism
{
	private static readonly byte[] HexAlphabet = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		97, 98, 99, 100, 101, 102
	};

	public override string MechanismName => "CRAM-MD5";

	[Obsolete("Use SaslMechanismCramMd5(NetworkCredential) instead.")]
	public SaslMechanismCramMd5(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismCramMd5(string, string) instead.")]
	public SaslMechanismCramMd5(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	public SaslMechanismCramMd5(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismCramMd5(string userName, string password)
		: base(userName, password)
	{
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (token == null)
		{
			throw new NotSupportedException("CRAM-MD5 does not support SASL-IR.");
		}
		if (base.IsAuthenticated)
		{
			return null;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(base.Credentials.UserName);
		byte[] bytes2 = Encoding.UTF8.GetBytes(base.Credentials.Password);
		byte[] array = new byte[64];
		byte[] array2 = new byte[64];
		if (bytes2.Length > 64)
		{
			byte[] array3;
			using (MD5 mD = MD5.Create())
			{
				array3 = mD.ComputeHash(bytes2);
			}
			Array.Copy(array3, array, array3.Length);
			Array.Copy(array3, array2, array3.Length);
		}
		else
		{
			Array.Copy(bytes2, array, bytes2.Length);
			Array.Copy(bytes2, array2, bytes2.Length);
		}
		Array.Clear(bytes2, 0, bytes2.Length);
		for (int i = 0; i < 64; i++)
		{
			array[i] ^= 54;
			array2[i] ^= 92;
		}
		byte[] hash;
		using (MD5 mD2 = MD5.Create())
		{
			mD2.TransformBlock(array, 0, array.Length, null, 0);
			mD2.TransformFinalBlock(token, startIndex, length);
			hash = mD2.Hash;
		}
		using (MD5 mD3 = MD5.Create())
		{
			mD3.TransformBlock(array2, 0, array2.Length, null, 0);
			mD3.TransformFinalBlock(hash, 0, hash.Length);
			hash = mD3.Hash;
		}
		byte[] array4 = new byte[bytes.Length + 1 + hash.Length * 2];
		int num = 0;
		for (int j = 0; j < bytes.Length; j++)
		{
			array4[num++] = bytes[j];
		}
		array4[num++] = 32;
		foreach (byte b in hash)
		{
			array4[num++] = HexAlphabet[(b >> 4) & 0xF];
			array4[num++] = HexAlphabet[b & 0xF];
		}
		base.IsAuthenticated = true;
		return array4;
	}
}
