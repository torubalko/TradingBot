using System;
using System.Net;
using MailKit.Security.Ntlm;

namespace MailKit.Security;

public class SaslMechanismNtlm : SaslMechanism
{
	private enum LoginState
	{
		Initial,
		Challenge
	}

	private LoginState state;

	public override string MechanismName => "NTLM";

	public override bool SupportsInitialResponse => true;

	internal NtlmAuthLevel Level { get; set; }

	public Version OSVersion { get; set; }

	public string Workstation { get; set; }

	[Obsolete("Use SaslMechanismNtlm(NetworkCredential) instead.")]
	public SaslMechanismNtlm(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
		Level = NtlmAuthLevel.NTLMv2_only;
	}

	[Obsolete("Use SaslMechanismNtlm(string, string) instead.")]
	public SaslMechanismNtlm(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
		Level = NtlmAuthLevel.NTLMv2_only;
	}

	public SaslMechanismNtlm(NetworkCredential credentials)
		: base(credentials)
	{
		Level = NtlmAuthLevel.NTLMv2_only;
	}

	public SaslMechanismNtlm(string userName, string password)
		: base(userName, password)
	{
		Level = NtlmAuthLevel.NTLMv2_only;
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return null;
		}
		string text = base.Credentials.UserName;
		string text2 = base.Credentials.Domain;
		MessageBase messageBase = null;
		if (string.IsNullOrEmpty(text2))
		{
			int num = text.IndexOf('\\');
			if (num == -1)
			{
				num = text.IndexOf('/');
			}
			if (num >= 0)
			{
				text2 = text.Substring(0, num);
				text = text.Substring(num + 1);
			}
		}
		switch (state)
		{
		case LoginState.Initial:
			messageBase = new Type1Message(Workstation, text2, OSVersion);
			state = LoginState.Challenge;
			break;
		case LoginState.Challenge:
		{
			string password = base.Credentials.Password ?? string.Empty;
			messageBase = GetChallengeResponse(text, password, token, startIndex, length);
			base.IsAuthenticated = true;
			break;
		}
		}
		return messageBase?.Encode();
	}

	private MessageBase GetChallengeResponse(string userName, string password, byte[] token, int startIndex, int length)
	{
		Type2Message type = new Type2Message(token, startIndex, length);
		return new Type3Message(type, OSVersion, Level, userName, password, Workstation);
	}

	public override void Reset()
	{
		state = LoginState.Initial;
		base.Reset();
	}
}
