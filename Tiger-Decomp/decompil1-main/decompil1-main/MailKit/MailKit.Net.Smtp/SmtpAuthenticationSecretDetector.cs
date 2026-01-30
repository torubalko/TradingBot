using System;
using System.Collections.Generic;

namespace MailKit.Net.Smtp;

internal class SmtpAuthenticationSecretDetector : IAuthenticationSecretDetector
{
	private enum SmtpAuthCommandState
	{
		Auth,
		AuthMechanism,
		AuthNewLine,
		AuthToken,
		Error
	}

	private static readonly IList<AuthenticationSecret> EmptyAuthSecrets;

	private SmtpAuthCommandState state;

	private bool isAuthenticating;

	private int commandIndex;

	public bool IsAuthenticating
	{
		get
		{
			return isAuthenticating;
		}
		set
		{
			state = SmtpAuthCommandState.Auth;
			isAuthenticating = value;
			commandIndex = 0;
		}
	}

	static SmtpAuthenticationSecretDetector()
	{
		EmptyAuthSecrets = Array.Empty<AuthenticationSecret>();
	}

	private bool SkipCommand(string command, byte[] buffer, ref int index, int endIndex)
	{
		while (index < endIndex && commandIndex < command.Length)
		{
			if (buffer[index] != (byte)command[commandIndex])
			{
				state = SmtpAuthCommandState.Error;
				break;
			}
			commandIndex++;
			index++;
		}
		return commandIndex == command.Length;
	}

	public IList<AuthenticationSecret> DetectSecrets(byte[] buffer, int offset, int count)
	{
		if (!IsAuthenticating || state == SmtpAuthCommandState.Error || count == 0)
		{
			return EmptyAuthSecrets;
		}
		int num = offset + count;
		int i = offset;
		if (state == SmtpAuthCommandState.Auth)
		{
			if (SkipCommand("AUTH ", buffer, ref i, num))
			{
				state = SmtpAuthCommandState.AuthMechanism;
			}
			if (i >= num || state == SmtpAuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == SmtpAuthCommandState.AuthMechanism)
		{
			for (; i < num && buffer[i] != 32 && buffer[i] != 13; i++)
			{
			}
			if (i < num)
			{
				if (buffer[i] == 32)
				{
					state = SmtpAuthCommandState.AuthToken;
				}
				else
				{
					state = SmtpAuthCommandState.AuthNewLine;
				}
				i++;
			}
			if (i >= num)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == SmtpAuthCommandState.AuthNewLine)
		{
			if (buffer[i] == 10)
			{
				state = SmtpAuthCommandState.AuthToken;
				i++;
			}
			else
			{
				state = SmtpAuthCommandState.Error;
			}
			if (i >= num || state == SmtpAuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		int num2 = i;
		for (; i < num && buffer[i] != 13; i++)
		{
		}
		if (i < num)
		{
			state = SmtpAuthCommandState.AuthNewLine;
		}
		if (i == num2)
		{
			return EmptyAuthSecrets;
		}
		AuthenticationSecret authenticationSecret = new AuthenticationSecret(num2, i - num2);
		if (state == SmtpAuthCommandState.AuthNewLine)
		{
			i++;
			if (i < num)
			{
				if (buffer[i] == 10)
				{
					state = SmtpAuthCommandState.AuthToken;
				}
				else
				{
					state = SmtpAuthCommandState.Error;
				}
			}
		}
		return new AuthenticationSecret[1] { authenticationSecret };
	}
}
