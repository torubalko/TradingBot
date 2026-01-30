using System;
using System.Collections.Generic;

namespace MailKit.Net.Pop3;

internal class Pop3AuthenticationSecretDetector : IAuthenticationSecretDetector
{
	private enum Pop3AuthCommandState
	{
		None,
		A,
		Apop,
		ApopUserName,
		ApopToken,
		ApopNewLine,
		Auth,
		AuthMechanism,
		AuthNewLine,
		AuthToken,
		User,
		UserName,
		UserNewLine,
		Pass,
		Password,
		PassNewLine,
		Error
	}

	private static readonly IList<AuthenticationSecret> EmptyAuthSecrets;

	private Pop3AuthCommandState state;

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
			state = Pop3AuthCommandState.None;
			isAuthenticating = value;
			commandIndex = 0;
		}
	}

	static Pop3AuthenticationSecretDetector()
	{
		EmptyAuthSecrets = Array.Empty<AuthenticationSecret>();
	}

	private bool SkipCommand(string command, byte[] buffer, ref int index, int endIndex)
	{
		while (index < endIndex && commandIndex < command.Length)
		{
			if (buffer[index] != (byte)command[commandIndex])
			{
				state = Pop3AuthCommandState.Error;
				break;
			}
			commandIndex++;
			index++;
		}
		return commandIndex == command.Length;
	}

	private IList<AuthenticationSecret> DetectApopSecrets(byte[] buffer, int offset, int endIndex)
	{
		List<AuthenticationSecret> list = new List<AuthenticationSecret>();
		int i = offset;
		if (state == Pop3AuthCommandState.ApopNewLine)
		{
			return EmptyAuthSecrets;
		}
		if (state == Pop3AuthCommandState.Apop)
		{
			if (SkipCommand("APOP ", buffer, ref i, endIndex))
			{
				state = Pop3AuthCommandState.ApopUserName;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		int num;
		if (state == Pop3AuthCommandState.ApopUserName)
		{
			num = i;
			for (; i < endIndex && buffer[i] != 32; i++)
			{
			}
			if (i > num)
			{
				list.Add(new AuthenticationSecret(num, i - num));
			}
			if (i < endIndex)
			{
				state = Pop3AuthCommandState.ApopToken;
				i++;
			}
			if (i >= endIndex)
			{
				return list;
			}
		}
		num = i;
		for (; i < endIndex && buffer[i] != 13; i++)
		{
		}
		if (i < endIndex)
		{
			state = Pop3AuthCommandState.ApopNewLine;
		}
		if (i > num)
		{
			list.Add(new AuthenticationSecret(num, i - num));
		}
		return list;
	}

	private IList<AuthenticationSecret> DetectAuthSecrets(byte[] buffer, int offset, int endIndex)
	{
		int i = offset;
		if (state == Pop3AuthCommandState.Auth)
		{
			if (SkipCommand("AUTH ", buffer, ref i, endIndex))
			{
				state = Pop3AuthCommandState.AuthMechanism;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == Pop3AuthCommandState.AuthMechanism)
		{
			for (; i < endIndex && buffer[i] != 32 && buffer[i] != 13; i++)
			{
			}
			if (i < endIndex)
			{
				if (buffer[i] == 32)
				{
					state = Pop3AuthCommandState.AuthToken;
				}
				else
				{
					state = Pop3AuthCommandState.AuthNewLine;
				}
				i++;
			}
			if (i >= endIndex)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == Pop3AuthCommandState.AuthNewLine)
		{
			if (buffer[i] == 10)
			{
				state = Pop3AuthCommandState.AuthToken;
				i++;
			}
			else
			{
				state = Pop3AuthCommandState.Error;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		int num = i;
		for (; i < endIndex && buffer[i] != 13; i++)
		{
		}
		if (i < endIndex)
		{
			state = Pop3AuthCommandState.AuthNewLine;
		}
		if (i == num)
		{
			return EmptyAuthSecrets;
		}
		AuthenticationSecret authenticationSecret = new AuthenticationSecret(num, i - num);
		if (state == Pop3AuthCommandState.AuthNewLine)
		{
			i++;
			if (i < endIndex)
			{
				if (buffer[i] == 10)
				{
					state = Pop3AuthCommandState.AuthToken;
				}
				else
				{
					state = Pop3AuthCommandState.Error;
				}
			}
		}
		return new AuthenticationSecret[1] { authenticationSecret };
	}

	private IList<AuthenticationSecret> DetectUserPassSecrets(byte[] buffer, int offset, int endIndex)
	{
		List<AuthenticationSecret> list = new List<AuthenticationSecret>();
		int i = offset;
		if (state == Pop3AuthCommandState.User)
		{
			if (SkipCommand("USER ", buffer, ref i, endIndex))
			{
				state = Pop3AuthCommandState.UserName;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == Pop3AuthCommandState.UserName)
		{
			int num = i;
			for (; i < endIndex && buffer[i] != 13; i++)
			{
			}
			if (i > num)
			{
				list.Add(new AuthenticationSecret(num, i - num));
			}
			if (i < endIndex)
			{
				state = Pop3AuthCommandState.UserNewLine;
				i++;
			}
			if (i >= endIndex)
			{
				return list;
			}
		}
		if (state == Pop3AuthCommandState.UserNewLine)
		{
			if (buffer[i] == 10)
			{
				state = Pop3AuthCommandState.Pass;
				commandIndex = 0;
				i++;
			}
			else
			{
				state = Pop3AuthCommandState.Error;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return list;
			}
		}
		if (state == Pop3AuthCommandState.Pass)
		{
			if (SkipCommand("PASS ", buffer, ref i, endIndex))
			{
				state = Pop3AuthCommandState.Password;
			}
			if (i >= endIndex || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == Pop3AuthCommandState.Password)
		{
			int num2 = i;
			for (; i < endIndex && buffer[i] != 13; i++)
			{
			}
			if (i > num2)
			{
				list.Add(new AuthenticationSecret(num2, i - num2));
			}
			if (i < endIndex)
			{
				state = Pop3AuthCommandState.PassNewLine;
				i++;
			}
			if (i >= endIndex)
			{
				return list;
			}
		}
		if (state == Pop3AuthCommandState.PassNewLine)
		{
			if (buffer[i] == 10)
			{
				state = Pop3AuthCommandState.None;
				commandIndex = 0;
				i++;
			}
			else
			{
				state = Pop3AuthCommandState.Error;
			}
		}
		return list;
	}

	public IList<AuthenticationSecret> DetectSecrets(byte[] buffer, int offset, int count)
	{
		if (!IsAuthenticating || state == Pop3AuthCommandState.Error || count == 0)
		{
			return EmptyAuthSecrets;
		}
		int num = offset + count;
		int num2 = offset;
		if (state == Pop3AuthCommandState.None)
		{
			switch ((char)buffer[num2])
			{
			case 'A':
				state = Pop3AuthCommandState.A;
				num2++;
				break;
			case 'U':
				state = Pop3AuthCommandState.User;
				commandIndex = 1;
				num2++;
				break;
			default:
				state = Pop3AuthCommandState.Error;
				break;
			}
			if (num2 >= num || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state == Pop3AuthCommandState.A)
		{
			switch ((char)buffer[num2])
			{
			case 'P':
				state = Pop3AuthCommandState.Apop;
				commandIndex = 2;
				num2++;
				break;
			case 'U':
				state = Pop3AuthCommandState.Auth;
				commandIndex = 2;
				num2++;
				break;
			default:
				state = Pop3AuthCommandState.Error;
				break;
			}
			if (num2 >= num || state == Pop3AuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (state >= Pop3AuthCommandState.Apop && state <= Pop3AuthCommandState.ApopNewLine)
		{
			return DetectApopSecrets(buffer, num2, num);
		}
		if (state >= Pop3AuthCommandState.Auth && state <= Pop3AuthCommandState.AuthToken)
		{
			return DetectAuthSecrets(buffer, num2, num);
		}
		return DetectUserPassSecrets(buffer, num2, num);
	}
}
