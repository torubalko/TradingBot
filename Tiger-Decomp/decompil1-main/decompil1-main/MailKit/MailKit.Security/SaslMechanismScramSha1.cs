using System;
using System.Net;
using System.Security.Cryptography;

namespace MailKit.Security;

public class SaslMechanismScramSha1 : SaslMechanismScramBase
{
	public override string MechanismName => "SCRAM-SHA-1";

	[Obsolete("Use SaslMechanismScramSha1(NetworkCredential) instead.")]
	public SaslMechanismScramSha1(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismScramSha1(string, string) instead.")]
	public SaslMechanismScramSha1(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	public SaslMechanismScramSha1(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismScramSha1(string userName, string password)
		: base(userName, password)
	{
	}

	protected override KeyedHashAlgorithm CreateHMAC(byte[] key)
	{
		return new HMACSHA1(key);
	}

	protected override byte[] Hash(byte[] str)
	{
		using SHA1 sHA = SHA1.Create();
		return sHA.ComputeHash(str);
	}
}
