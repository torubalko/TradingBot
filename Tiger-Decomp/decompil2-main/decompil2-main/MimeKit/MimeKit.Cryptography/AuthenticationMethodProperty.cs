using System;
using System.Collections.Generic;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

public class AuthenticationMethodProperty
{
	private static readonly char[] TokenSpecials = "()<>@,;:\\\"/[]?=".ToCharArray();

	private bool? quoted;

	public string PropertyType { get; private set; }

	public string Property { get; private set; }

	public string Value { get; private set; }

	internal AuthenticationMethodProperty(string ptype, string property, string value, bool? quoted)
	{
		if (ptype == null)
		{
			throw new ArgumentNullException("ptype");
		}
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		this.quoted = quoted;
		PropertyType = ptype;
		Property = property;
		Value = value;
	}

	public AuthenticationMethodProperty(string ptype, string property, string value)
		: this(ptype, property, value, null)
	{
	}

	internal void AppendTokens(FormatOptions options, List<string> tokens)
	{
		string text = ((quoted.HasValue ? quoted.Value : (Value.IndexOfAny(TokenSpecials) != -1)) ? MimeUtils.Quote(Value) : Value);
		tokens.Add(" ");
		if (PropertyType.Length + 1 + Property.Length + 1 + text.Length < options.MaxLineLength)
		{
			tokens.Add(PropertyType + "." + Property + "=" + text);
		}
		else if (PropertyType.Length + 1 + Property.Length + 1 < options.MaxLineLength)
		{
			tokens.Add(PropertyType + "." + Property + "=");
			tokens.Add(text);
		}
		else
		{
			tokens.Add(PropertyType);
			tokens.Add(".");
			tokens.Add(Property);
			tokens.Add("=");
			tokens.Add(text);
		}
	}

	public override string ToString()
	{
		string text = ((quoted.HasValue ? quoted.Value : (Value.IndexOfAny(TokenSpecials) != -1)) ? MimeUtils.Quote(Value) : Value);
		return PropertyType + "." + Property + "=" + text;
	}
}
