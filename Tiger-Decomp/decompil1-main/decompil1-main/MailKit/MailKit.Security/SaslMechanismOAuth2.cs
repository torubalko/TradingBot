using System;
using System.Net;

namespace MailKit.Security;

public class SaslMechanismOAuth2 : SaslMechanism
{
	private const string AuthBearer = "auth=Bearer ";

	private const string UserEquals = "user=";

	public override string MechanismName => "XOAUTH2";

	public override bool SupportsInitialResponse => true;

	[Obsolete("Use SaslMechanismOAuth2(NetworkCredential) instead.")]
	public SaslMechanismOAuth2(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismOAuth2(string, string) instead.")]
	public SaslMechanismOAuth2(Uri uri, string userName, string auth_token)
		: base(uri, userName, auth_token)
	{
	}

	public SaslMechanismOAuth2(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismOAuth2(string userName, string auth_token)
		: base(userName, auth_token)
	{
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return null;
		}
		string password = base.Credentials.Password;
		string userName = base.Credentials.UserName;
		int num = 0;
		byte[] array = new byte["user=".Length + userName.Length + "auth=Bearer ".Length + password.Length + 3];
		for (int i = 0; i < "user=".Length; i++)
		{
			array[num++] = (byte)"user="[i];
		}
		for (int j = 0; j < userName.Length; j++)
		{
			array[num++] = (byte)userName[j];
		}
		array[num++] = 1;
		for (int k = 0; k < "auth=Bearer ".Length; k++)
		{
			array[num++] = (byte)"auth=Bearer "[k];
		}
		for (int l = 0; l < password.Length; l++)
		{
			array[num++] = (byte)password[l];
		}
		array[num++] = 1;
		array[num++] = 1;
		base.IsAuthenticated = true;
		return array;
	}
}
