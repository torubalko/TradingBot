using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

public class AuthenticationResults
{
	public string AuthenticationServiceIdentifier { get; private set; }

	public int? Instance { get; set; }

	public int? Version { get; set; }

	public List<AuthenticationMethodResult> Results { get; private set; }

	private AuthenticationResults()
	{
		Results = new List<AuthenticationMethodResult>();
	}

	public AuthenticationResults(string authservid)
		: this()
	{
		if (authservid == null)
		{
			throw new ArgumentNullException("authservid");
		}
		AuthenticationServiceIdentifier = authservid;
	}

	internal void Encode(FormatOptions options, StringBuilder builder, int lineLength)
	{
		int num = 1;
		if (Instance.HasValue)
		{
			string text = Instance.Value.ToString(CultureInfo.InvariantCulture);
			builder.AppendFormat(" i={0};", text);
			lineLength += 4 + text.Length;
		}
		if (AuthenticationServiceIdentifier != null)
		{
			if (lineLength + num + AuthenticationServiceIdentifier.Length > options.MaxLineLength)
			{
				builder.Append(options.NewLine);
				builder.Append('\t');
				lineLength = 1;
				num = 0;
			}
			if (num > 0)
			{
				builder.Append(' ');
				lineLength++;
			}
			builder.Append(AuthenticationServiceIdentifier);
			lineLength += AuthenticationServiceIdentifier.Length;
			if (Version.HasValue)
			{
				string text2 = Version.Value.ToString(CultureInfo.InvariantCulture);
				if (lineLength + 1 + text2.Length > options.MaxLineLength)
				{
					builder.Append(options.NewLine);
					builder.Append('\t');
					lineLength = 1;
				}
				else
				{
					builder.Append(' ');
					lineLength++;
				}
				lineLength += text2.Length;
				builder.Append(text2);
			}
			builder.Append(';');
			lineLength++;
		}
		if (Results.Count > 0)
		{
			for (int i = 0; i < Results.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(';');
					lineLength++;
				}
				Results[i].Encode(options, builder, ref lineLength);
			}
		}
		else
		{
			builder.Append(" none");
		}
		builder.Append(options.NewLine);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Instance.HasValue)
		{
			stringBuilder.AppendFormat("i={0}; ", Instance.Value.ToString(CultureInfo.InvariantCulture));
		}
		if (AuthenticationServiceIdentifier != null)
		{
			stringBuilder.Append(AuthenticationServiceIdentifier);
			if (Version.HasValue)
			{
				stringBuilder.Append(' ');
				stringBuilder.Append(Version.Value.ToString(CultureInfo.InvariantCulture));
			}
			stringBuilder.Append("; ");
		}
		if (Results.Count > 0)
		{
			for (int i = 0; i < Results.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append("; ");
				}
				stringBuilder.Append(Results[i]);
			}
		}
		else
		{
			stringBuilder.Append("none");
		}
		return stringBuilder.ToString();
	}

	private static bool IsKeyword(byte c)
	{
		if ((c < 65 || c > 90) && (c < 97 || c > 122) && (c < 48 || c > 57) && c != 45)
		{
			return c == 95;
		}
		return true;
	}

	private static bool SkipKeyword(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && IsKeyword(text[index]))
		{
			index++;
		}
		return index > num;
	}

	private static bool SkipValue(byte[] text, ref int index, int endIndex, out bool quoted)
	{
		if (text[index] == 34)
		{
			quoted = true;
			if (!ParseUtils.SkipQuoted(text, ref index, endIndex, throwOnError: false))
			{
				return false;
			}
		}
		else
		{
			quoted = false;
			if (!ParseUtils.SkipToken(text, ref index, endIndex))
			{
				return false;
			}
		}
		return true;
	}

	private static bool SkipDomain(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (ParseUtils.SkipAtom(text, ref index, endIndex) && index < endIndex && text[index] == 46)
		{
			index++;
		}
		if (index > num && text[index - 1] != 46)
		{
			return true;
		}
		return false;
	}

	private static bool SkipPropertyValue(byte[] text, ref int index, int endIndex, out bool quoted)
	{
		if (text[index] == 34)
		{
			quoted = true;
			if (!ParseUtils.SkipQuoted(text, ref index, endIndex, throwOnError: false))
			{
				return false;
			}
			return true;
		}
		quoted = false;
		while (index < endIndex && !text[index].IsWhitespace() && text[index] != 59 && text[index] != 40)
		{
			index++;
		}
		return true;
	}

	private static bool TryParseMethods(byte[] text, ref int index, int endIndex, bool throwOnError, AuthenticationResults authres)
	{
		while (index < endIndex)
		{
			string text2 = null;
			int num;
			while (true)
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					break;
				}
				num = index;
				if (!SkipKeyword(text, ref index, endIndex))
				{
					goto IL_0029;
				}
				if (text2 == null && index < endIndex && text[index] == 46)
				{
					index = num;
					if (!SkipDomain(text, ref index, endIndex))
					{
						goto IL_0072;
					}
					text2 = Encoding.UTF8.GetString(text, num, index - num);
					if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
					{
						return false;
					}
					if (index >= endIndex)
					{
						goto IL_00b8;
					}
					if (text[index] == 59)
					{
						index++;
						continue;
					}
					goto IL_00e3;
				}
				goto IL_0113;
			}
			break;
			IL_0072:
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid Office365 authserv-id token at offset {0}", num), num, index);
			}
			return false;
			IL_00b8:
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Missing semi-colon after Office365 authserv-id token at offset {0}", num), num, index);
			}
			return false;
			IL_0029:
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid method token at offset {0}", num), num, index);
			}
			return false;
			IL_0113:
			string text3 = Encoding.ASCII.GetString(text, num, index - num);
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				if (text3 != "none")
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete methodspec token at offset {0}", num), num, index);
					}
					return false;
				}
				if (authres.Results.Count <= 0)
				{
					break;
				}
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid no-result token at offset {0}", num), num, index);
				}
				return false;
			}
			AuthenticationMethodResult authenticationMethodResult = new AuthenticationMethodResult(text3);
			authenticationMethodResult.Office365AuthenticationServiceIdentifier = text2;
			authres.Results.Add(authenticationMethodResult);
			int num2;
			if (text[index] == 47)
			{
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				num2 = index;
				if (!ParseUtils.TryParseInt32(text, ref index, endIndex, out var value))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid method-version token at offset {0}", num2), num2, index);
					}
					return false;
				}
				authenticationMethodResult.Version = value;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete methodspec token at offset {0}", num), num, index);
					}
					return false;
				}
			}
			if (text[index] != 61)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid methodspec token at offset {0}", num), num, index);
				}
				return false;
			}
			index++;
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete methodspec token at offset {0}", num), num, index);
				}
				return false;
			}
			num2 = index;
			if (!SkipKeyword(text, ref index, endIndex))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid result token at offset {0}", num2), num2, index);
				}
				return false;
			}
			authenticationMethodResult.Result = Encoding.ASCII.GetString(text, num2, index - num2);
			ParseUtils.SkipWhiteSpace(text, ref index, endIndex);
			if (index < endIndex && text[index] == 40)
			{
				int num3 = index;
				if (!ParseUtils.SkipComment(text, ref index, endIndex))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete comment token at offset {0}", num3), num3, index);
					}
					return false;
				}
				num3++;
				authenticationMethodResult.ResultComment = Header.Unfold(Encoding.UTF8.GetString(text, num3, index - 1 - num3));
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
			}
			if (index >= endIndex)
			{
				break;
			}
			if (text[index] == 59)
			{
				index++;
				continue;
			}
			num2 = index;
			if (!SkipKeyword(text, ref index, endIndex))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid reasonspec or propspec token at offset {0}", num2), num2, index);
				}
				return false;
			}
			string text4 = Encoding.ASCII.GetString(text, num2, index - num2);
			bool quoted;
			if (text4 == "reason" || text4 == "action")
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete {0}spec token at offset {1}", text4, num2), num2, index);
					}
					return false;
				}
				if (text[index] != 61)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid {0}spec token at offset {1}", text4, num2), num2, index);
					}
					return false;
				}
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				int num4 = index;
				if (index >= endIndex || !SkipValue(text, ref index, endIndex, out quoted))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid {0}spec value token at offset {1}", text4, num4), num4, index);
					}
					return false;
				}
				string text5 = Encoding.UTF8.GetString(text, num4, index - num4);
				if (quoted)
				{
					text5 = MimeUtils.Unquote(text5);
				}
				if (text4 == "action")
				{
					authenticationMethodResult.Action = text5;
				}
				else
				{
					authenticationMethodResult.Reason = text5;
				}
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					break;
				}
				if (text[index] == 59)
				{
					index++;
					continue;
				}
				num2 = index;
				if (!SkipKeyword(text, ref index, endIndex))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				text4 = Encoding.ASCII.GetString(text, num2, index - num2);
			}
			while (true)
			{
				string ptype = text4;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				if (text[index] != 46)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				int num5 = index;
				if (!SkipKeyword(text, ref index, endIndex))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid property token at offset {0}", num5), num5, index);
					}
					return false;
				}
				string property = Encoding.ASCII.GetString(text, num5, index - num5);
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				if (text[index] != 61)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				int num6 = index;
				if (index >= text.Length || !SkipPropertyValue(text, ref index, endIndex, out quoted))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				text4 = Encoding.UTF8.GetString(text, num6, index - num6);
				if (quoted)
				{
					text4 = MimeUtils.Unquote(text4);
				}
				AuthenticationMethodProperty item = new AuthenticationMethodProperty(ptype, property, text4, quoted);
				authenticationMethodResult.Properties.Add(item);
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex || text[index] == 59)
				{
					break;
				}
				num2 = index;
				if (!SkipKeyword(text, ref index, endIndex))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid propspec token at offset {0}", num2), num2, index);
					}
					return false;
				}
				text4 = Encoding.ASCII.GetString(text, num2, index - num2);
			}
			index++;
			continue;
			IL_00e3:
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token after Office365 authserv-id token at offset {0}", index), index, index);
			}
			return false;
		}
		return true;
	}

	private static bool TryParse(byte[] text, ref int index, int endIndex, bool throwOnError, out AuthenticationResults authres)
	{
		int? instance = null;
		string text2 = null;
		authres = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		do
		{
			int num = index;
			if (index >= endIndex || !SkipValue(text, ref index, endIndex, out var quoted))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete authserv-id token at offset {0}", num), num, index);
				}
				return false;
			}
			string text3 = Encoding.UTF8.GetString(text, num, index - num);
			if (quoted)
			{
				text2 = MimeUtils.Unquote(text3);
				continue;
			}
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index < endIndex && text[index] == 61)
			{
				if (instance.HasValue)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid token at offset {0}", num), num, index);
					}
					return false;
				}
				if (text3 != "i")
				{
					authres = new AuthenticationResults();
					index = 0;
					return TryParseMethods(text, ref index, endIndex, throwOnError, authres);
				}
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				num = index;
				if (!ParseUtils.TryParseInt32(text, ref index, endIndex, out var value))
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid instance value at offset {0}", num), num, index);
					}
					return false;
				}
				instance = value;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Missing semi-colon after instance value at offset {0}", num), num, index);
					}
					return false;
				}
				if (text[index] != 59)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token after instance value at offset {0}", index), index, index);
					}
					return false;
				}
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
			}
			else
			{
				text2 = text3;
			}
		}
		while (text2 == null);
		authres = new AuthenticationResults(text2)
		{
			Instance = instance
		};
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			return true;
		}
		if (text[index] != 59)
		{
			int num2 = index;
			if (!ParseUtils.TryParseInt32(text, ref index, endIndex, out var value2))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid authres-version at offset {0}", num2), num2, index);
				}
				return false;
			}
			authres.Version = value2;
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				return true;
			}
			if (text[index] != 59)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unknown token at offset {0}", index), index, index);
				}
				return false;
			}
		}
		index++;
		return TryParseMethods(text, ref index, endIndex, throwOnError, authres);
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out AuthenticationResults authres)
	{
		ParseUtils.ValidateArguments(buffer, startIndex, length);
		int index = startIndex;
		return TryParse(buffer, ref index, startIndex + length, throwOnError: false, out authres);
	}

	public static bool TryParse(byte[] buffer, out AuthenticationResults authres)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int index = 0;
		return TryParse(buffer, ref index, buffer.Length, throwOnError: false, out authres);
	}

	public static AuthenticationResults Parse(byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(buffer, startIndex, length);
		int index = startIndex;
		TryParse(buffer, ref index, startIndex + length, throwOnError: true, out var authres);
		return authres;
	}

	public static AuthenticationResults Parse(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		int index = 0;
		TryParse(buffer, ref index, buffer.Length, throwOnError: true, out var authres);
		return authres;
	}
}
