using System;
using System.Net;
using System.Text;

namespace MailKit.Security;

public class SaslMechanismLogin : SaslMechanism
{
	private enum LoginState
	{
		UserName,
		Password
	}

	private readonly Encoding encoding;

	private LoginState state;

	public override string MechanismName => "LOGIN";

	public override bool SupportsInitialResponse => false;

	[Obsolete("Use SaslMechanismLogin(Encoding, NetworkCredential) instead.")]
	public SaslMechanismLogin(Uri uri, Encoding encoding, ICredentials credentials)
		: base(uri, credentials)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	[Obsolete("Use SaslMechanismLogin(Encoding, string, string) instead.")]
	public SaslMechanismLogin(Uri uri, Encoding encoding, string userName, string password)
		: base(uri, userName, password)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	[Obsolete("Use SaslMechanismLogin(NetworkCredential) instead.")]
	public SaslMechanismLogin(Uri uri, ICredentials credentials)
		: this(uri, Encoding.UTF8, credentials)
	{
	}

	[Obsolete("Use SaslMechanismLogin(string, string) instead.")]
	public SaslMechanismLogin(Uri uri, string userName, string password)
		: this(uri, Encoding.UTF8, userName, password)
	{
	}

	public SaslMechanismLogin(Encoding encoding, NetworkCredential credentials)
		: base(credentials)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	public SaslMechanismLogin(Encoding encoding, string userName, string password)
		: base(userName, password)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	public SaslMechanismLogin(NetworkCredential credentials)
		: this(Encoding.UTF8, credentials)
	{
	}

	public SaslMechanismLogin(string userName, string password)
		: this(Encoding.UTF8, userName, password)
	{
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return null;
		}
		byte[] result = null;
		switch (state)
		{
		case LoginState.UserName:
			if (token == null)
			{
				throw new NotSupportedException("LOGIN does not support SASL-IR.");
			}
			result = encoding.GetBytes(base.Credentials.UserName);
			state = LoginState.Password;
			break;
		case LoginState.Password:
			result = encoding.GetBytes(base.Credentials.Password);
			base.IsAuthenticated = true;
			break;
		}
		return result;
	}

	public override void Reset()
	{
		state = LoginState.UserName;
		base.Reset();
	}
}
