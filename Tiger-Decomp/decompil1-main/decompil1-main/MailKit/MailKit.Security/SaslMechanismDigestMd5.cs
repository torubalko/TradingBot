using System;
using System.Net;
using System.Text;

namespace MailKit.Security;

public class SaslMechanismDigestMd5 : SaslMechanism
{
	private enum LoginState
	{
		Auth,
		Final
	}

	private static readonly Encoding Latin1;

	private DigestChallenge challenge;

	private DigestResponse response;

	internal string cnonce;

	private Encoding encoding;

	private LoginState state;

	public string AuthorizationId { get; set; }

	public override string MechanismName => "DIGEST-MD5";

	static SaslMechanismDigestMd5()
	{
		try
		{
			Latin1 = Encoding.GetEncoding(28591);
		}
		catch (NotSupportedException)
		{
			Latin1 = Encoding.GetEncoding(1252);
		}
	}

	[Obsolete("Use SaslMechanismDigestMd5(NetworkCredential) instead.")]
	public SaslMechanismDigestMd5(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismDigestMd5(string, string) instead.")]
	public SaslMechanismDigestMd5(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	public SaslMechanismDigestMd5(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismDigestMd5(string userName, string password)
		: base(userName, password)
	{
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (token == null)
		{
			throw new NotSupportedException("DIGEST-MD5 does not support SASL-IR.");
		}
		if (base.IsAuthenticated)
		{
			return null;
		}
		switch (state)
		{
		case LoginState.Auth:
			if (token.Length > 2048)
			{
				throw new SaslException(MechanismName, SaslErrorCode.ChallengeTooLong, "Server challenge too long.");
			}
			challenge = DigestChallenge.Parse(Encoding.UTF8.GetString(token, startIndex, length));
			encoding = ((challenge.Charset != null) ? Encoding.UTF8 : Latin1);
			cnonce = cnonce ?? SaslMechanism.GenerateEntropy(15);
			response = new DigestResponse(challenge, encoding, base.Uri.Scheme, base.Uri.DnsSafeHost, AuthorizationId, base.Credentials.UserName, base.Credentials.Password, cnonce);
			state = LoginState.Final;
			return response.Encode(encoding);
		case LoginState.Final:
		{
			if (token.Length == 0)
			{
				throw new SaslException(MechanismName, SaslErrorCode.MissingChallenge, "Server response did not contain any authentication data.");
			}
			string text = encoding.GetString(token, startIndex, length);
			if (!DigestChallenge.TryParseKeyValuePair(text, out var key, out var value))
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncompleteChallenge, "Server response contained incomplete authentication data.");
			}
			if (!key.Equals("rspauth", StringComparison.OrdinalIgnoreCase))
			{
				throw new SaslException(MechanismName, SaslErrorCode.InvalidChallenge, "Server response contained invalid data.");
			}
			string text2 = response.ComputeHash(encoding, base.Credentials.Password, client: false);
			if (value != text2)
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncorrectHash, "Server response did not contain the expected hash.");
			}
			base.IsAuthenticated = true;
			break;
		}
		}
		return null;
	}

	public override void Reset()
	{
		state = LoginState.Auth;
		challenge = null;
		response = null;
		cnonce = null;
		base.Reset();
	}
}
