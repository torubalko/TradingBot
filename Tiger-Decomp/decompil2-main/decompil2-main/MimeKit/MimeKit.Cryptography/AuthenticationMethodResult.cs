using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

public class AuthenticationMethodResult
{
	public string Office365AuthenticationServiceIdentifier { get; internal set; }

	public string Method { get; private set; }

	public int? Version { get; set; }

	public string Result { get; internal set; }

	public string ResultComment { get; set; }

	public string Action { get; internal set; }

	public string Reason { get; set; }

	public List<AuthenticationMethodProperty> Properties { get; private set; }

	internal AuthenticationMethodResult(string method)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		Properties = new List<AuthenticationMethodProperty>();
		Method = method;
	}

	public AuthenticationMethodResult(string method, string result)
		: this(method)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		Result = result;
	}

	internal void Encode(FormatOptions options, StringBuilder builder, ref int lineLength)
	{
		string text = ToString();
		if (text.Length + 1 < options.MaxLineLength)
		{
			if (lineLength + text.Length + 1 > options.MaxLineLength)
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
			lineLength += text.Length;
			builder.Append(text);
			return;
		}
		List<string> list = new List<string>();
		list.Add(" ");
		if (Office365AuthenticationServiceIdentifier != null)
		{
			list.Add(Office365AuthenticationServiceIdentifier);
			list.Add(";");
			list.Add(" ");
		}
		if (Version.HasValue)
		{
			string text2 = Version.Value.ToString(CultureInfo.InvariantCulture);
			if (Method.Length + 1 + text2.Length + 1 + Result.Length < options.MaxLineLength)
			{
				list.Add(Method + "/" + text2 + "=" + Result);
			}
			else if (Method.Length + 1 + text2.Length < options.MaxLineLength)
			{
				list.Add(Method + "/" + text2);
				list.Add("=");
				list.Add(Result);
			}
			else
			{
				list.Add(Method);
				list.Add("/");
				list.Add(text2);
				list.Add("=");
				list.Add(Result);
			}
		}
		else if (Method.Length + 1 + Result.Length < options.MaxLineLength)
		{
			list.Add(Method + "=" + Result);
		}
		else
		{
			list.Add(Method);
			list.Add("=");
			list.Add(Result);
		}
		if (!string.IsNullOrEmpty(ResultComment))
		{
			list.Add(" ");
			list.Add("(" + ResultComment + ")");
		}
		if (!string.IsNullOrEmpty(Reason))
		{
			string text3 = MimeUtils.Quote(Reason);
			list.Add(" ");
			if ("reason=".Length + text3.Length < options.MaxLineLength)
			{
				list.Add("reason=" + text3);
			}
			else
			{
				list.Add("reason=");
				list.Add(text3);
			}
		}
		else if (!string.IsNullOrEmpty(Action))
		{
			string text4 = MimeUtils.Quote(Action);
			list.Add(" ");
			if ("action=".Length + text4.Length < options.MaxLineLength)
			{
				list.Add("action=" + text4);
			}
			else
			{
				list.Add("action=");
				list.Add(text4);
			}
		}
		for (int i = 0; i < Properties.Count; i++)
		{
			Properties[i].AppendTokens(options, list);
		}
		builder.AppendTokens(options, ref lineLength, list);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Office365AuthenticationServiceIdentifier != null)
		{
			stringBuilder.Append(Office365AuthenticationServiceIdentifier);
			stringBuilder.Append("; ");
		}
		stringBuilder.Append(Method);
		if (Version.HasValue)
		{
			stringBuilder.Append('/');
			stringBuilder.Append(Version.Value.ToString(CultureInfo.InvariantCulture));
		}
		stringBuilder.Append('=');
		stringBuilder.Append(Result);
		if (!string.IsNullOrEmpty(ResultComment))
		{
			stringBuilder.Append(" (");
			stringBuilder.Append(ResultComment);
			stringBuilder.Append(')');
		}
		if (!string.IsNullOrEmpty(Reason))
		{
			stringBuilder.Append(" reason=");
			MimeUtils.AppendQuoted(stringBuilder, Reason);
		}
		else if (!string.IsNullOrEmpty(Action))
		{
			stringBuilder.Append(" action=");
			MimeUtils.AppendQuoted(stringBuilder, Action);
		}
		for (int i = 0; i < Properties.Count; i++)
		{
			stringBuilder.Append(' ');
			stringBuilder.Append(Properties[i]);
		}
		return stringBuilder.ToString();
	}
}
