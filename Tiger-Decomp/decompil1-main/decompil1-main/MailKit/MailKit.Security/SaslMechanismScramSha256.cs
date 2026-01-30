using System;
using System.Net;
using System.Security.Cryptography;

namespace MailKit.Security;

public class SaslMechanismScramSha256 : SaslMechanismScramBase
{
	public override string MechanismName => "SCRAM-SHA-256";

	[Obsolete("Use SaslMechanismScramSha256(NetworkCredential) instead.")]
	public SaslMechanismScramSha256(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismScramSha256(string, string) instead.")]
	public SaslMechanismScramSha256(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	public SaslMechanismScramSha256(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismScramSha256(string userName, string password)
		: base(userName, password)
	{
	}

	protected override KeyedHashAlgorithm CreateHMAC(byte[] key)
	{
		return new HMACSHA256(key);
	}

	protected override byte[] Hash(byte[] str)
	{
		using SHA256 sHA = SHA256.Create();
		return sHA.ComputeHash(str);
	}
}
