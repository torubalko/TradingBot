using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mail;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class MailboxAddress : InternetAddress
{
	private string address;

	private int at;

	public DomainList Route { get; private set; }

	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value == address)
			{
				return;
			}
			if (value.Length > 0)
			{
				RfcComplianceMode addressParserComplianceMode = ParserOptions.Default.AddressParserComplianceMode;
				byte[] bytes = CharsetUtils.UTF8.GetBytes(value);
				int index = 0;
				InternetAddress.TryParseAddrspec(bytes, ref index, bytes.Length, new byte[0], addressParserComplianceMode, throwOnError: true, out var addrspec, out var num);
				if (index != bytes.Length)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
				}
				address = addrspec;
				at = num;
			}
			else
			{
				address = string.Empty;
				at = -1;
			}
			OnChanged();
		}
	}

	public bool IsInternational
	{
		get
		{
			if (address == null)
			{
				return false;
			}
			if (ParseUtils.IsInternational(address))
			{
				return true;
			}
			foreach (string item in Route)
			{
				if (ParseUtils.IsInternational(item))
				{
					return true;
				}
			}
			return false;
		}
	}

	internal MailboxAddress(Encoding encoding, string name, IEnumerable<string> route, string address, int at)
		: base(encoding, name)
	{
		Route = new DomainList(route);
		Route.Changed += RouteChanged;
		this.address = address;
		this.at = at;
	}

	internal MailboxAddress(Encoding encoding, string name, string address, int at)
		: base(encoding, name)
	{
		Route = new DomainList();
		Route.Changed += RouteChanged;
		this.address = address;
		this.at = at;
	}

	public MailboxAddress(Encoding encoding, string name, IEnumerable<string> route, string address)
		: base(encoding, name)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		Route = new DomainList(route);
		Route.Changed += RouteChanged;
		Address = address;
	}

	public MailboxAddress(string name, IEnumerable<string> route, string address)
		: this(Encoding.UTF8, name, route, address)
	{
	}

	[Obsolete("This constructor will be going away. Use new MailboxAddress(string name, IEnumerable<string> route, string address) instead.")]
	public MailboxAddress(IEnumerable<string> route, string address)
		: this(Encoding.UTF8, null, route, address)
	{
	}

	public MailboxAddress(Encoding encoding, string name, string address)
		: base(encoding, name)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		Route = new DomainList();
		Route.Changed += RouteChanged;
		Address = address;
	}

	public MailboxAddress(string name, string address)
		: this(Encoding.UTF8, name, address)
	{
	}

	[Obsolete("This constructor will be going away due to it causing too much confusion. Use new MailboxAddress(string name, string address) or MailboxAddress.Parse(string) instead.")]
	public MailboxAddress(string address)
		: this(Encoding.UTF8, null, address)
	{
	}

	public override InternetAddress Clone()
	{
		return new MailboxAddress(base.Encoding, base.Name, Route, Address);
	}

	private static string EncodeAddrspec(string addrspec, int at)
	{
		if (at != -1)
		{
			string text = addrspec.Substring(at + 1);
			string text2 = addrspec.Substring(0, at);
			if (ParseUtils.IsInternational(text2))
			{
				text2 = ParseUtils.IdnEncode(text2);
			}
			if (ParseUtils.IsInternational(text))
			{
				text = ParseUtils.IdnEncode(text);
			}
			return text2 + "@" + text;
		}
		return addrspec;
	}

	public static string EncodeAddrspec(string addrspec)
	{
		if (addrspec == null)
		{
			throw new ArgumentNullException("addrspec");
		}
		if (addrspec.Length == 0)
		{
			return addrspec;
		}
		byte[] bytes = CharsetUtils.UTF8.GetBytes(addrspec);
		int index = 0;
		if (!InternetAddress.TryParseAddrspec(bytes, ref index, bytes.Length, new byte[0], RfcComplianceMode.Looser, throwOnError: false, out var addrspec2, out var num))
		{
			return addrspec;
		}
		return EncodeAddrspec(addrspec2, num);
	}

	private static string DecodeAddrspec(string addrspec, int at)
	{
		if (at != -1)
		{
			string text = addrspec.Substring(at + 1);
			string text2 = addrspec.Substring(0, at);
			if (ParseUtils.IsIdnEncoded(text2))
			{
				text2 = ParseUtils.IdnDecode(text2);
			}
			if (ParseUtils.IsIdnEncoded(text))
			{
				text = ParseUtils.IdnDecode(text);
			}
			return text2 + "@" + text;
		}
		return addrspec;
	}

	public static string DecodeAddrspec(string addrspec)
	{
		if (addrspec == null)
		{
			throw new ArgumentNullException("addrspec");
		}
		if (addrspec.Length == 0)
		{
			return addrspec;
		}
		byte[] bytes = CharsetUtils.UTF8.GetBytes(addrspec);
		int index = 0;
		if (!InternetAddress.TryParseAddrspec(bytes, ref index, bytes.Length, new byte[0], RfcComplianceMode.Looser, throwOnError: false, out var addrspec2, out var num))
		{
			return addrspec;
		}
		return DecodeAddrspec(addrspec2, num);
	}

	public string GetAddress(bool idnEncode)
	{
		if (idnEncode)
		{
			return EncodeAddrspec(address, at);
		}
		return DecodeAddrspec(address, at);
	}

	internal override void Encode(FormatOptions options, StringBuilder builder, bool firstToken, ref int lineLength)
	{
		string text = Route.Encode(options);
		if (!string.IsNullOrEmpty(text))
		{
			text += ":";
		}
		string text2 = GetAddress(!options.International);
		if (!string.IsNullOrEmpty(base.Name))
		{
			string text3;
			if (!options.International)
			{
				byte[] array = Rfc2047.EncodePhrase(options, base.Encoding, base.Name);
				text3 = Encoding.ASCII.GetString(array, 0, array.Length);
			}
			else
			{
				text3 = InternetAddress.EncodeInternationalizedPhrase(base.Name);
			}
			if (lineLength + text3.Length > options.MaxLineLength)
			{
				if (text3.Length > options.MaxLineLength)
				{
					builder.AppendFolded(options, firstToken, text3, ref lineLength);
				}
				else
				{
					if (!firstToken && lineLength > 1)
					{
						builder.LineWrap(options);
						lineLength = 1;
					}
					lineLength += text3.Length;
					builder.Append(text3);
				}
			}
			else
			{
				lineLength += text3.Length;
				builder.Append(text3);
			}
			if (lineLength + text.Length + text2.Length + 3 > options.MaxLineLength)
			{
				builder.Append(options.NewLine);
				builder.Append("\t<");
				lineLength = 2;
			}
			else
			{
				builder.Append(" <");
				lineLength += 2;
			}
			lineLength += text.Length;
			builder.Append(text);
			lineLength += text2.Length + 1;
			builder.Append(text2);
			builder.Append('>');
		}
		else if (!string.IsNullOrEmpty(text))
		{
			if (!firstToken && lineLength + text.Length + text2.Length + 2 > options.MaxLineLength)
			{
				builder.Append(options.NewLine);
				builder.Append("\t<");
				lineLength = 2;
			}
			else
			{
				builder.Append('<');
				lineLength++;
			}
			lineLength += text.Length;
			builder.Append(text);
			lineLength += text2.Length + 1;
			builder.Append(text2);
			builder.Append('>');
		}
		else
		{
			if (!firstToken && lineLength + text2.Length > options.MaxLineLength)
			{
				builder.LineWrap(options);
				lineLength = 1;
			}
			lineLength += text2.Length;
			builder.Append(text2);
		}
	}

	public override string ToString(FormatOptions options, bool encode)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (encode)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int lineLength = 0;
			Encode(options, stringBuilder, firstToken: true, ref lineLength);
			return stringBuilder.ToString();
		}
		string text = Route.ToString();
		if (!string.IsNullOrEmpty(text))
		{
			text += ":";
		}
		if (!string.IsNullOrEmpty(base.Name))
		{
			return MimeUtils.Quote(base.Name) + " <" + text + Address + ">";
		}
		if (!string.IsNullOrEmpty(text))
		{
			return "<" + text + Address + ">";
		}
		return Address;
	}

	public override bool Equals(InternetAddress other)
	{
		if (!(other is MailboxAddress mailboxAddress))
		{
			return false;
		}
		if (base.Name == mailboxAddress.Name)
		{
			return Address == mailboxAddress.Address;
		}
		return false;
	}

	private void RouteChanged(object sender, EventArgs e)
	{
		OnChanged();
	}

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out MailboxAddress mailbox)
	{
		AddressParserFlags addressParserFlags = AddressParserFlags.AllowMailboxAddress;
		if (throwOnError)
		{
			addressParserFlags |= AddressParserFlags.ThrowOnError;
		}
		if (!InternetAddress.TryParse(options, text, ref index, endIndex, 0, addressParserFlags, out var internetAddress))
		{
			mailbox = null;
			return false;
		}
		mailbox = (MailboxAddress)internetAddress;
		return true;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out MailboxAddress mailbox)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out mailbox))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			mailbox = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out MailboxAddress mailbox)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out mailbox);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out MailboxAddress mailbox)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out mailbox))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			mailbox = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, out MailboxAddress mailbox)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out mailbox);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out MailboxAddress mailbox)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out mailbox))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			mailbox = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, out MailboxAddress mailbox)
	{
		return TryParse(ParserOptions.Default, buffer, out mailbox);
	}

	public static bool TryParse(ParserOptions options, string text, out MailboxAddress mailbox)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int num = bytes.Length;
		int index = 0;
		if (!TryParse(options, bytes, ref index, num, throwOnError: false, out mailbox))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: false) || index != num)
		{
			mailbox = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(string text, out MailboxAddress mailbox)
	{
		return TryParse(ParserOptions.Default, text, out mailbox);
	}

	public new static MailboxAddress Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var mailbox))
		{
			throw new ParseException("No mailbox address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return mailbox;
	}

	public new static MailboxAddress Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public new static MailboxAddress Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var mailbox))
		{
			throw new ParseException("No mailbox address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return mailbox;
	}

	public new static MailboxAddress Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public new static MailboxAddress Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var mailbox))
		{
			throw new ParseException("No mailbox address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return mailbox;
	}

	public new static MailboxAddress Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public new static MailboxAddress Parse(ParserOptions options, string text)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int num = bytes.Length;
		int index = 0;
		if (!TryParse(options, bytes, ref index, num, throwOnError: true, out var mailbox))
		{
			throw new ParseException("No mailbox address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return mailbox;
	}

	public new static MailboxAddress Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}

	public static explicit operator MailAddress(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			return null;
		}
		return new MailAddress(mailbox.Address, mailbox.Name, mailbox.Encoding);
	}

	public static explicit operator MailboxAddress(MailAddress address)
	{
		if (address == null)
		{
			return null;
		}
		return new MailboxAddress(address.DisplayName, address.Address);
	}
}
