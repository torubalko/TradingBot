using System;
using System.Globalization;
using System.Net;
using System.Text;

namespace MailKit.Security;

public class SaslMechanismOAuthBearer : SaslMechanism
{
	private static readonly byte[] ErrorResponse = new byte[1] { 1 };

	private const string AuthBearer = "auth=Bearer ";

	private const string HostEquals = "host=";

	private const string PortEquals = "port=";

	public override string MechanismName => "OAUTHBEARER";

	public override bool SupportsInitialResponse => true;

	[Obsolete("Use SaslMechanismOAuthBearer(NetworkCredential) instead.")]
	public SaslMechanismOAuthBearer(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismOAuthBearer(string, string) instead.")]
	public SaslMechanismOAuthBearer(Uri uri, string userName, string auth_token)
		: base(uri, userName, auth_token)
	{
	}

	public SaslMechanismOAuthBearer(NetworkCredential credentials)
		: base(credentials)
	{
	}

	public SaslMechanismOAuthBearer(string userName, string auth_token)
		: base(userName, auth_token)
	{
	}

	private static int CalculateBufferSize(byte[] authzid, byte[] host, string port, string token)
	{
		int num = 0;
		num += 2;
		num += 2;
		num += authzid.Length;
		num++;
		num++;
		num += "host=".Length;
		num += host.Length;
		num++;
		num += "port=".Length;
		num += port.Length;
		num++;
		num += "auth=Bearer ".Length;
		num += token.Length;
		return num + 2;
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return ErrorResponse;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(base.Credentials.UserName);
		string text = base.Uri.Port.ToString(CultureInfo.InvariantCulture);
		byte[] bytes2 = Encoding.UTF8.GetBytes(base.Uri.Host);
		string password = base.Credentials.Password;
		byte[] array = new byte[CalculateBufferSize(bytes, bytes2, text, password)];
		int num = 0;
		array[num++] = 110;
		array[num++] = 44;
		array[num++] = 97;
		array[num++] = 61;
		for (int i = 0; i < bytes.Length; i++)
		{
			array[num++] = bytes[i];
		}
		array[num++] = 44;
		array[num++] = 1;
		for (int j = 0; j < "host=".Length; j++)
		{
			array[num++] = (byte)"host="[j];
		}
		for (int k = 0; k < bytes2.Length; k++)
		{
			array[num++] = bytes2[k];
		}
		array[num++] = 1;
		for (int l = 0; l < "port=".Length; l++)
		{
			array[num++] = (byte)"port="[l];
		}
		for (int m = 0; m < text.Length; m++)
		{
			array[num++] = (byte)text[m];
		}
		array[num++] = 1;
		for (int n = 0; n < "auth=Bearer ".Length; n++)
		{
			array[num++] = (byte)"auth=Bearer "[n];
		}
		for (int num2 = 0; num2 < password.Length; num2++)
		{
			array[num++] = (byte)password[num2];
		}
		array[num++] = 1;
		array[num++] = 1;
		base.IsAuthenticated = true;
		return array;
	}
}
