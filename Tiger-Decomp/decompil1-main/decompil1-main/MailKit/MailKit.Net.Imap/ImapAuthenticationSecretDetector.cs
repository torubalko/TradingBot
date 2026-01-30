using System;
using System.Collections.Generic;

namespace MailKit.Net.Imap;

internal class ImapAuthenticationSecretDetector : IAuthenticationSecretDetector
{
	private enum ImapAuthCommandState
	{
		None,
		Command,
		Authenticate,
		AuthMechanism,
		AuthNewLine,
		AuthToken,
		Login,
		UserName,
		Password,
		LoginNewLine,
		Error
	}

	private enum ImapLoginTokenType
	{
		None,
		Atom,
		QString,
		Literal
	}

	private enum ImapLiteralState
	{
		None,
		Octets,
		Plus,
		CloseBrace,
		Literal,
		Complete
	}

	private enum ImapQStringState
	{
		None,
		Escaped,
		EndQuote,
		Complete
	}

	private static readonly IList<AuthenticationSecret> EmptyAuthSecrets;

	private ImapAuthCommandState commandState;

	private ImapLiteralState literalState;

	private ImapQStringState qstringState;

	private ImapLoginTokenType tokenType;

	private bool isAuthenticating;

	private int literalOctets;

	private int literalSeen;

	private int textIndex;

	public bool IsAuthenticating
	{
		get
		{
			return isAuthenticating;
		}
		set
		{
			commandState = ImapAuthCommandState.None;
			isAuthenticating = value;
			ClearLoginTokenState();
			textIndex = 0;
		}
	}

	static ImapAuthenticationSecretDetector()
	{
		EmptyAuthSecrets = Array.Empty<AuthenticationSecret>();
	}

	private void ClearLoginTokenState()
	{
		literalState = ImapLiteralState.None;
		qstringState = ImapQStringState.None;
		tokenType = ImapLoginTokenType.None;
		literalOctets = 0;
		literalSeen = 0;
	}

	private bool SkipText(string text, byte[] buffer, ref int index, int endIndex)
	{
		while (index < endIndex && textIndex < text.Length)
		{
			if (buffer[index] != (byte)text[textIndex])
			{
				commandState = ImapAuthCommandState.Error;
				break;
			}
			textIndex++;
			index++;
		}
		return textIndex == text.Length;
	}

	private IList<AuthenticationSecret> DetectAuthSecrets(byte[] buffer, int offset, int endIndex)
	{
		int i = offset;
		if (commandState == ImapAuthCommandState.Authenticate)
		{
			if (SkipText("AUTHENTICATE ", buffer, ref i, endIndex))
			{
				commandState = ImapAuthCommandState.AuthMechanism;
			}
			if (i >= endIndex || commandState == ImapAuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (commandState == ImapAuthCommandState.AuthMechanism)
		{
			for (; i < endIndex && buffer[i] != 32 && buffer[i] != 13; i++)
			{
			}
			if (i < endIndex)
			{
				if (buffer[i] == 32)
				{
					commandState = ImapAuthCommandState.AuthToken;
				}
				else
				{
					commandState = ImapAuthCommandState.AuthNewLine;
				}
				i++;
			}
			if (i >= endIndex)
			{
				return EmptyAuthSecrets;
			}
		}
		if (commandState == ImapAuthCommandState.AuthNewLine)
		{
			if (buffer[i] == 10)
			{
				commandState = ImapAuthCommandState.AuthToken;
				i++;
			}
			else
			{
				commandState = ImapAuthCommandState.Error;
			}
			if (i >= endIndex || commandState == ImapAuthCommandState.Error)
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
			commandState = ImapAuthCommandState.AuthNewLine;
		}
		if (i == num)
		{
			return EmptyAuthSecrets;
		}
		AuthenticationSecret authenticationSecret = new AuthenticationSecret(num, i - num);
		if (commandState == ImapAuthCommandState.AuthNewLine)
		{
			i++;
			if (i < endIndex)
			{
				if (buffer[i] == 10)
				{
					commandState = ImapAuthCommandState.AuthToken;
				}
				else
				{
					commandState = ImapAuthCommandState.Error;
				}
			}
		}
		return new AuthenticationSecret[1] { authenticationSecret };
	}

	private bool SkipLiteralToken(List<AuthenticationSecret> secrets, byte[] buffer, ref int index, int endIndex, byte sentinel)
	{
		if (literalState == ImapLiteralState.Octets)
		{
			while (index < endIndex && buffer[index] != 43 && buffer[index] != 125)
			{
				int num = buffer[index] - 48;
				literalOctets = literalOctets * 10 + num;
				index++;
			}
			if (index < endIndex)
			{
				if (buffer[index] == 43)
				{
					literalState = ImapLiteralState.Plus;
					textIndex = 0;
				}
				else
				{
					literalState = ImapLiteralState.CloseBrace;
					textIndex = 1;
				}
				index++;
			}
			if (index >= endIndex)
			{
				return false;
			}
		}
		if (literalState < ImapLiteralState.Literal && SkipText("}\r\n", buffer, ref index, endIndex))
		{
			literalState = ImapLiteralState.Literal;
		}
		if (index >= endIndex || commandState == ImapAuthCommandState.Error)
		{
			return false;
		}
		if (literalState == ImapLiteralState.Literal)
		{
			int num2 = Math.Min(literalOctets - literalSeen, endIndex - index);
			secrets.Add(new AuthenticationSecret(index, num2));
			literalSeen += num2;
			index += num2;
			if (literalSeen == literalOctets)
			{
				literalState = ImapLiteralState.Complete;
			}
		}
		if (literalState == ImapLiteralState.Complete && index < endIndex && buffer[index] == sentinel)
		{
			index++;
			return true;
		}
		return false;
	}

	private bool SkipLoginToken(List<AuthenticationSecret> secrets, byte[] buffer, ref int index, int endIndex, byte sentinel)
	{
		if (tokenType == ImapLoginTokenType.None)
		{
			switch ((char)buffer[index])
			{
			case '{':
				literalState = ImapLiteralState.Octets;
				tokenType = ImapLoginTokenType.Literal;
				index++;
				break;
			case '"':
				tokenType = ImapLoginTokenType.QString;
				index++;
				break;
			default:
				tokenType = ImapLoginTokenType.Atom;
				break;
			}
		}
		switch (tokenType)
		{
		case ImapLoginTokenType.Literal:
			return SkipLiteralToken(secrets, buffer, ref index, endIndex, sentinel);
		case ImapLoginTokenType.QString:
			if (qstringState != ImapQStringState.Complete)
			{
				int num = index;
				while (index < endIndex)
				{
					if (qstringState == ImapQStringState.Escaped)
					{
						qstringState = ImapQStringState.None;
					}
					else if (buffer[index] == 92)
					{
						qstringState = ImapQStringState.Escaped;
					}
					else if (buffer[index] == 34)
					{
						qstringState = ImapQStringState.EndQuote;
						break;
					}
					index++;
				}
				if (index > num)
				{
					secrets.Add(new AuthenticationSecret(num, index - num));
				}
				if (qstringState == ImapQStringState.EndQuote)
				{
					qstringState = ImapQStringState.Complete;
					index++;
				}
			}
			if (index >= endIndex)
			{
				return false;
			}
			if (buffer[index] != sentinel)
			{
				commandState = ImapAuthCommandState.Error;
				return false;
			}
			index++;
			return true;
		default:
		{
			int num = index;
			while (index < endIndex && buffer[index] != sentinel)
			{
				index++;
			}
			if (index > num)
			{
				secrets.Add(new AuthenticationSecret(num, index - num));
			}
			if (index >= endIndex)
			{
				return false;
			}
			index++;
			return true;
		}
		}
	}

	private IList<AuthenticationSecret> DetectLoginSecrets(byte[] buffer, int offset, int endIndex)
	{
		List<AuthenticationSecret> list = new List<AuthenticationSecret>();
		int index = offset;
		if (commandState == ImapAuthCommandState.LoginNewLine)
		{
			return EmptyAuthSecrets;
		}
		if (commandState == ImapAuthCommandState.Login)
		{
			if (SkipText("LOGIN ", buffer, ref index, endIndex))
			{
				commandState = ImapAuthCommandState.UserName;
			}
			if (index >= endIndex || commandState == ImapAuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (commandState == ImapAuthCommandState.UserName)
		{
			if (SkipLoginToken(list, buffer, ref index, endIndex, 32))
			{
				commandState = ImapAuthCommandState.Password;
				ClearLoginTokenState();
			}
			if (index >= endIndex || commandState == ImapAuthCommandState.Error)
			{
				return list;
			}
		}
		if (commandState == ImapAuthCommandState.Password && SkipLoginToken(list, buffer, ref index, endIndex, 13))
		{
			commandState = ImapAuthCommandState.LoginNewLine;
			ClearLoginTokenState();
		}
		return list;
	}

	public IList<AuthenticationSecret> DetectSecrets(byte[] buffer, int offset, int count)
	{
		if (!IsAuthenticating || commandState == ImapAuthCommandState.Error || count == 0)
		{
			return EmptyAuthSecrets;
		}
		int num = offset + count;
		int i = offset;
		if (commandState == ImapAuthCommandState.None)
		{
			for (; i < num && buffer[i] != 32; i++)
			{
			}
			if (i < num)
			{
				commandState = ImapAuthCommandState.Command;
				i++;
			}
			if (i >= num)
			{
				return EmptyAuthSecrets;
			}
		}
		if (commandState == ImapAuthCommandState.Command)
		{
			switch ((char)buffer[i])
			{
			case 'A':
				commandState = ImapAuthCommandState.Authenticate;
				textIndex = 1;
				i++;
				break;
			case 'L':
				commandState = ImapAuthCommandState.Login;
				textIndex = 1;
				i++;
				break;
			default:
				commandState = ImapAuthCommandState.Error;
				break;
			}
			if (i >= num || commandState == ImapAuthCommandState.Error)
			{
				return EmptyAuthSecrets;
			}
		}
		if (commandState >= ImapAuthCommandState.Authenticate && commandState <= ImapAuthCommandState.AuthToken)
		{
			return DetectAuthSecrets(buffer, i, num);
		}
		return DetectLoginSecrets(buffer, i, num);
	}
}
