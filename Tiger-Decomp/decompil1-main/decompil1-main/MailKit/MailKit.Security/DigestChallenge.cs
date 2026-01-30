using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MailKit.Security;

internal class DigestChallenge
{
	public string[] Realms { get; private set; }

	public string Nonce { get; private set; }

	public HashSet<string> Qop { get; private set; }

	public bool? Stale { get; private set; }

	public int? MaxBuf { get; private set; }

	public string Charset { get; private set; }

	public string Algorithm { get; private set; }

	public HashSet<string> Ciphers { get; private set; }

	private DigestChallenge()
	{
		Ciphers = new HashSet<string>(StringComparer.Ordinal);
		Qop = new HashSet<string>(StringComparer.Ordinal);
	}

	private static bool SkipWhiteSpace(string text, ref int index)
	{
		int num = index;
		while (index < text.Length && char.IsWhiteSpace(text[index]))
		{
			index++;
		}
		return index > num;
	}

	private static string GetKey(string text, ref int index)
	{
		int num = index;
		while (index < text.Length && !char.IsWhiteSpace(text[index]) && text[index] != '=' && text[index] != ',')
		{
			index++;
		}
		return text.Substring(num, index - num);
	}

	private static bool TryParseQuoted(string text, ref int index, out string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		value = null;
		index++;
		while (index < text.Length)
		{
			if (text[index] == '\\')
			{
				if (flag)
				{
					stringBuilder.Append(text[index]);
				}
				flag = !flag;
			}
			else if (!flag)
			{
				if (text[index] == '"')
				{
					break;
				}
				stringBuilder.Append(text[index]);
			}
			else
			{
				flag = false;
			}
			index++;
		}
		if (index >= text.Length || text[index] != '"')
		{
			return false;
		}
		index++;
		value = stringBuilder.ToString();
		return true;
	}

	private static bool TryParseValue(string text, ref int index, out string value)
	{
		if (text[index] == '"')
		{
			return TryParseQuoted(text, ref index, out value);
		}
		int num = index;
		value = null;
		while (index < text.Length && !char.IsWhiteSpace(text[index]) && text[index] != ',')
		{
			index++;
		}
		value = text.Substring(num, index - num);
		return true;
	}

	private static bool TryParseKeyValuePair(string text, ref int index, out string key, out string value)
	{
		value = null;
		key = GetKey(text, ref index);
		SkipWhiteSpace(text, ref index);
		if (index >= text.Length || text[index] != '=')
		{
			return false;
		}
		index++;
		SkipWhiteSpace(text, ref index);
		if (index >= text.Length)
		{
			return false;
		}
		return TryParseValue(text, ref index, out value);
	}

	public static bool TryParseKeyValuePair(string text, out string key, out string value)
	{
		int index = 0;
		value = null;
		key = null;
		SkipWhiteSpace(text, ref index);
		if (index >= text.Length || !TryParseKeyValuePair(text, ref index, out key, out value))
		{
			return false;
		}
		return true;
	}

	public static DigestChallenge Parse(string token)
	{
		DigestChallenge digestChallenge = new DigestChallenge();
		int index = 0;
		SkipWhiteSpace(token, ref index);
		while (index < token.Length)
		{
			if (!TryParseKeyValuePair(token, ref index, out var key, out var value))
			{
				throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
			}
			switch (key.ToLowerInvariant())
			{
			case "realm":
				digestChallenge.Realms = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				break;
			case "nonce":
				if (digestChallenge.Nonce != null)
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				digestChallenge.Nonce = value;
				break;
			case "qop":
			{
				string[] array2 = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text2 in array2)
				{
					digestChallenge.Qop.Add(text2.Trim());
				}
				break;
			}
			case "stale":
				if (digestChallenge.Stale.HasValue)
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				digestChallenge.Stale = value.ToLowerInvariant() == "true";
				break;
			case "maxbuf":
			{
				if (digestChallenge.MaxBuf.HasValue || !int.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out var result))
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				digestChallenge.MaxBuf = result;
				break;
			}
			case "charset":
				if (digestChallenge.Charset != null || !value.Equals("utf-8", StringComparison.OrdinalIgnoreCase))
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				digestChallenge.Charset = "utf-8";
				break;
			case "algorithm":
				if (digestChallenge.Algorithm != null)
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				digestChallenge.Algorithm = value;
				break;
			case "cipher":
			{
				if (digestChallenge.Ciphers.Count > 0)
				{
					throw new SaslException("DIGEST-MD5", SaslErrorCode.InvalidChallenge, $"Invalid SASL challenge from the server: {token}");
				}
				string[] array = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text in array)
				{
					digestChallenge.Ciphers.Add(text.Trim());
				}
				break;
			}
			}
			SkipWhiteSpace(token, ref index);
			if (index < token.Length && token[index] == ',')
			{
				index++;
				SkipWhiteSpace(token, ref index);
			}
		}
		return digestChallenge;
	}
}
