using System;
using System.Net;
using System.Security.Cryptography;

namespace MailKit.Security;

public class SaslMechanismScramSha512 : SaslMechanismScramBase
{
	public override string MechanismName => "SCRAM-SHA-512";

	[Obsolete("Use SaslMechanismScramSha512(NetworkCredential) instead.")]
	public SaslMechanismScramSha512(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismScramSha512(string, string) instead.")]
	public SaslMechanismScramSha512(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	public SaslMechanismScramSha512(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismScramSha512(string userName, string password)
		: base(userName, password)
	{
	}

	protected override KeyedHashAlgorithm CreateHMAC(byte[] key)
	{
		return new HMACSHA512(key);
	}

	protected override byte[] Hash(byte[] str)
	{
		using SHA512 sHA = SHA512.Create();
		return sHA.ComputeHash(str);
	}
}
