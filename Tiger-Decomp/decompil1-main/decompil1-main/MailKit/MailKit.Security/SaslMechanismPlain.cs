using System;
using System.Net;
using System.Text;

namespace MailKit.Security;

public class SaslMechanismPlain : SaslMechanism
{
	private readonly Encoding encoding;

	public string AuthorizationId { get; set; }

	public override string MechanismName => "PLAIN";

	public override bool SupportsInitialResponse => true;

	[Obsolete("Use SaslMechanismPlain(Encoding, NetworkCredential) instead.")]
	public SaslMechanismPlain(Uri uri, Encoding encoding, ICredentials credentials)
		: base(uri, credentials)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	[Obsolete("Use SaslMechanismPlain(Encoding, string, string) instead.")]
	public SaslMechanismPlain(Uri uri, Encoding encoding, string userName, string password)
		: base(uri, userName, password)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	[Obsolete("Use SaslMechanismPlain(NetworkCredential) instead.")]
	public SaslMechanismPlain(Uri uri, ICredentials credentials)
		: this(uri, Encoding.UTF8, credentials)
	{
	}

	[Obsolete("Use SaslMechanismPlain(string, string) instead.")]
	public SaslMechanismPlain(Uri uri, string userName, string password)
		: this(uri, Encoding.UTF8, userName, password)
	{
	}

	public SaslMechanismPlain(Encoding encoding, NetworkCredential credentials)
		: base(credentials)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	public SaslMechanismPlain(Encoding encoding, string userName, string password)
		: base(userName, password)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		this.encoding = encoding;
	}

	public SaslMechanismPlain(NetworkCredential credentials)
		: this(Encoding.UTF8, credentials)
	{
	}

	public SaslMechanismPlain(string userName, string password)
		: this(Encoding.UTF8, userName, password)
	{
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return null;
		}
		byte[] bytes = encoding.GetBytes(AuthorizationId ?? string.Empty);
		byte[] bytes2 = encoding.GetBytes(base.Credentials.UserName);
		byte[] bytes3 = encoding.GetBytes(base.Credentials.Password);
		byte[] array = new byte[bytes.Length + bytes2.Length + bytes3.Length + 2];
		int num = 0;
		for (int i = 0; i < bytes.Length; i++)
		{
			array[num++] = bytes[i];
		}
		array[num++] = 0;
		for (int j = 0; j < bytes2.Length; j++)
		{
			array[num++] = bytes2[j];
		}
		array[num++] = 0;
		for (int k = 0; k < bytes3.Length; k++)
		{
			array[num++] = bytes3[k];
		}
		Array.Clear(bytes3, 0, bytes3.Length);
		base.IsAuthenticated = true;
		return array;
	}
}
