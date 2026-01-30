using System;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public abstract class InternetAddress : IComparable<InternetAddress>, IEquatable<InternetAddress>
{
	[Flags]
	internal enum AddressParserFlags
	{
		AllowMailboxAddress = 1,
		AllowGroupAddress = 2,
		ThrowOnError = 4,
		TryParse = 3,
		Parse = 7
	}

	private const string AtomSpecials = "()<>@,;:\\\".[]";

	private Encoding encoding;

	private string name;

	private static readonly byte[] CommaGreaterThanOrSemiColon = new byte[3] { 44, 62, 59 };

	public Encoding Encoding
	{
		get
		{
			return encoding;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value != encoding)
			{
				encoding = value;
				OnChanged();
			}
		}
	}

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (!(value == name))
			{
				name = value;
				OnChanged();
			}
		}
	}

	internal event EventHandler Changed;

	protected InternetAddress(Encoding encoding, string name)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		Encoding = encoding;
		Name = name;
	}

	public abstract InternetAddress Clone();

	public int CompareTo(InternetAddress other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		int num;
		if ((num = string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase)) != 0)
		{
			return num;
		}
		MailboxAddress mailboxAddress = other as MailboxAddress;
		MailboxAddress mailboxAddress2 = this as MailboxAddress;
		if (mailboxAddress2 != null && mailboxAddress != null)
		{
			string address = mailboxAddress.Address;
			int num2 = address.IndexOf('@');
			string address2 = mailboxAddress2.Address;
			int num3 = address2.IndexOf('@');
			if (num3 != -1 && num2 != -1)
			{
				int length = Math.Min(address2.Length - (num3 + 1), address.Length - (num2 + 1));
				num = string.Compare(address2, num3 + 1, address, num2 + 1, length, StringComparison.OrdinalIgnoreCase);
			}
			if (num == 0)
			{
				string strB = ((num2 != -1) ? address.Substring(0, num2) : address);
				string strA = ((num3 != -1) ? address2.Substring(0, num3) : address2);
				num = string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase);
			}
			return num;
		}
		if (mailboxAddress2 != null && mailboxAddress == null)
		{
			return -1;
		}
		if (mailboxAddress2 == null && mailboxAddress != null)
		{
			return 1;
		}
		return 0;
	}

	public abstract bool Equals(InternetAddress other);

	public override bool Equals(object obj)
	{
		return Equals(obj as InternetAddress);
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	internal static string EncodeInternationalizedPhrase(string phrase)
	{
		for (int i = 0; i < phrase.Length; i++)
		{
			if ("()<>@,;:\\\".[]".IndexOf(phrase[i]) != -1)
			{
				return MimeUtils.Quote(phrase);
			}
		}
		return phrase;
	}

	internal abstract void Encode(FormatOptions options, StringBuilder builder, bool firstToken, ref int lineLength);

	public abstract string ToString(FormatOptions options, bool encode);

	public string ToString(bool encode)
	{
		return ToString(FormatOptions.Default, encode);
	}

	public override string ToString()
	{
		return ToString(FormatOptions.Default, encode: false);
	}

	protected virtual void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	internal static bool TryParseLocalPart(byte[] text, ref int index, int endIndex, RfcComplianceMode compliance, bool skipTrailingCfws, bool throwOnError, out string localpart)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = index;
		localpart = null;
		do
		{
			if (!text[index].IsAtom() && text[index] != 34)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid local-part at offset {0}", num), num, index);
				}
				return false;
			}
			int num2 = index;
			if (!ParseUtils.SkipWord(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			try
			{
				stringBuilder.Append(CharsetUtils.UTF8.GetString(text, num2, index - num2));
			}
			catch (DecoderFallbackException)
			{
				try
				{
					stringBuilder.Append(CharsetUtils.Latin1.GetString(text, num2, index - num2));
				}
				catch (DecoderFallbackException innerException)
				{
					if (throwOnError)
					{
						throw new ParseException("Internationalized local-part tokens may only contain UTF-8 characters.", num2, num2, innerException);
					}
					return false;
				}
			}
			int num3 = index;
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex || text[index] != 46)
			{
				if (!skipTrailingCfws)
				{
					index = num3;
				}
				break;
			}
			do
			{
				stringBuilder.Append('.');
				index++;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete local-part at offset {0}", num), num, index);
					}
					return false;
				}
			}
			while (compliance == RfcComplianceMode.Looser && text[index] == 46);
		}
		while (compliance != RfcComplianceMode.Looser || (index < endIndex && text[index] != 64));
		localpart = stringBuilder.ToString();
		if (ParseUtils.IsIdnEncoded(localpart))
		{
			localpart = ParseUtils.IdnDecode(localpart);
		}
		return true;
	}

	internal static bool TryParseAddrspec(byte[] text, ref int index, int endIndex, byte[] sentinels, RfcComplianceMode compliance, bool throwOnError, out string addrspec, out int at)
	{
		int num = index;
		addrspec = null;
		at = -1;
		if (!TryParseLocalPart(text, ref index, endIndex, compliance, skipTrailingCfws: true, throwOnError, out var localpart))
		{
			return false;
		}
		if (index >= endIndex || ParseUtils.IsSentinel(text[index], sentinels))
		{
			addrspec = localpart;
			return true;
		}
		if (text[index] != 64)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid addr-spec token at offset {0}", num), num, index);
			}
			return false;
		}
		index++;
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete addr-spec token at offset {0}", num), num, index);
			}
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete addr-spec token at offset {0}", num), num, index);
			}
			return false;
		}
		if (!ParseUtils.TryParseDomain(text, ref index, endIndex, sentinels, throwOnError, out var domain))
		{
			return false;
		}
		if (ParseUtils.IsIdnEncoded(domain))
		{
			domain = ParseUtils.IdnDecode(domain);
		}
		addrspec = localpart + "@" + domain;
		at = localpart.Length;
		return true;
	}

	internal static bool TryParseMailbox(ParserOptions options, byte[] text, int startIndex, ref int index, int endIndex, string name, int codepage, bool throwOnError, out InternetAddress address)
	{
		DomainList route = null;
		Encoding uTF;
		try
		{
			uTF = Encoding.GetEncoding(codepage);
		}
		catch
		{
			uTF = Encoding.UTF8;
		}
		address = null;
		index++;
		if (index < endIndex && text[index] == 60)
		{
			if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Excessive angle brackets at offset {0}", index), startIndex, index);
				}
				return false;
			}
			do
			{
				index++;
			}
			while (index < endIndex && text[index] == 60);
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete mailbox at offset {0}", startIndex), startIndex, index);
			}
			return false;
		}
		if (text[index] == 64)
		{
			if (!DomainList.TryParse(text, ref index, endIndex, throwOnError: false, out route))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid route in mailbox at offset {0}", startIndex), startIndex, index);
				}
				return false;
			}
			if (index >= endIndex || text[index] != 58)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete route in mailbox at offset {0}", startIndex), startIndex, index);
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
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete mailbox at offset {0}", startIndex), startIndex, index);
				}
				return false;
			}
		}
		if (!TryParseAddrspec(text, ref index, endIndex, CommaGreaterThanOrSemiColon, options.AddressParserComplianceMode, throwOnError, out var addrspec, out var at))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex || text[index] != 62)
		{
			if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected end of mailbox at offset {0}", startIndex), startIndex, index);
				}
				return false;
			}
		}
		else
		{
			index++;
			if (index < endIndex && text[index] == 62)
			{
				if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Excessive angle brackets at offset {0}", index), startIndex, index);
					}
					return false;
				}
				do
				{
					index++;
				}
				while (index < endIndex && text[index] == 62);
			}
		}
		if (route != null)
		{
			address = new MailboxAddress(uTF, name, route, addrspec, at);
		}
		else
		{
			address = new MailboxAddress(uTF, name, addrspec, at);
		}
		return true;
	}

	private static bool TryParseGroup(ParserOptions options, byte[] text, int startIndex, ref int index, int endIndex, int groupDepth, string name, int codepage, bool throwOnError, out InternetAddress address)
	{
		Encoding uTF;
		try
		{
			uTF = Encoding.GetEncoding(codepage);
		}
		catch
		{
			uTF = Encoding.UTF8;
		}
		address = null;
		index++;
		while (index < endIndex && (text[index] == 58 || text[index].IsBlank()))
		{
			index++;
		}
		if (InternetAddressList.TryParse(options, text, ref index, endIndex, isGroup: true, groupDepth, throwOnError, out var addresses))
		{
			address = new GroupAddress(uTF, name, addresses);
		}
		else
		{
			address = new GroupAddress(uTF, name);
		}
		if (index >= endIndex || text[index] != 59)
		{
			if (throwOnError && options.AddressParserComplianceMode == RfcComplianceMode.Strict)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Expected to find ';' at offset {0}", index), startIndex, index);
			}
			while (index < endIndex && text[index] != 59)
			{
				index++;
			}
		}
		else
		{
			index++;
		}
		return true;
	}

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, int groupDepth, AddressParserFlags flags, out InternetAddress address)
	{
		bool flag = (flags & AddressParserFlags.ThrowOnError) != 0;
		int num = ((!options.AllowUnquotedCommasInAddresses) ? 1 : 0);
		address = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag))
		{
			return false;
		}
		if (index == endIndex)
		{
			if (flag)
			{
				throw new ParseException("No address found.", index, index);
			}
			return false;
		}
		bool flag2 = false;
		int num2 = index;
		int num3 = 0;
		int num4 = 0;
		while (index < endIndex)
		{
			if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
			{
				if (!ParseUtils.SkipWord(text, ref index, endIndex, flag))
				{
					break;
				}
			}
			else if (text[index] == 34)
			{
				int num5 = index;
				if (!ParseUtils.SkipQuoted(text, ref index, endIndex, throwOnError: false))
				{
					index = num5 + 1;
					ParseUtils.SkipWhiteSpace(text, ref index, endIndex);
					if (!ParseUtils.SkipPhraseAtom(text, ref index, endIndex))
					{
						if (!flag)
						{
							break;
						}
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete quoted-string token at offset {0}", num5), num5, endIndex);
					}
					if (num2 == num5)
					{
						flag2 = true;
					}
				}
			}
			else if (!ParseUtils.SkipPhraseAtom(text, ref index, endIndex))
			{
				break;
			}
			num3 = index - num2;
			while (true)
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag))
				{
					return false;
				}
				if (index >= endIndex || text[index] != 46)
				{
					break;
				}
				index++;
				num3 = index - num2;
			}
			num4++;
			if (index < endIndex && text[index] == 44 && num4 > num)
			{
				index++;
				num3 = index - num2;
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag))
				{
					return false;
				}
			}
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag))
		{
			return false;
		}
		if (index >= endIndex || text[index] == 44 || text[index] == 62 || text[index] == 59)
		{
			byte b = (byte)((index < endIndex) ? text[index] : 44);
			if ((flags & AddressParserFlags.AllowMailboxAddress) == 0)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Addr-spec token at offset {0}", num2), num2, index);
				}
				return false;
			}
			if (!options.AllowAddressesWithoutDomain)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete addr-spec token at offset {0}", num2), num2, index);
				}
				return false;
			}
			index = num2;
			if (!TryParseLocalPart(text, ref index, endIndex, options.AddressParserComplianceMode, skipTrailingCfws: false, flag, out var localpart))
			{
				return false;
			}
			ParseUtils.SkipWhiteSpace(text, ref index, endIndex);
			string text2;
			if (index < endIndex && text[index] == 40)
			{
				int num6 = index + 1;
				ParseUtils.SkipComment(text, ref index, endIndex);
				text2 = Rfc2047.DecodePhrase(options, text, num6, index - 1 - num6).Trim();
				ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag);
			}
			else
			{
				text2 = string.Empty;
			}
			if (index < endIndex && text[index] == 62)
			{
				if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
				{
					if (flag)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected '>' token at offset {0}", index), num2, index);
					}
					return false;
				}
				index++;
			}
			if (index < endIndex && text[index] != b)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), num2, index);
				}
				return false;
			}
			address = new MailboxAddress(Encoding.UTF8, text2, localpart, -1);
			return true;
		}
		if (text[index] == 58)
		{
			int num7 = num2;
			int codepage = -1;
			if ((flags & AddressParserFlags.AllowGroupAddress) == 0)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Group address token at offset {0}", num2), num2, index);
				}
				return false;
			}
			if (groupDepth >= options.MaxAddressGroupDepth)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Exceeded maximum rfc822 group depth at offset {0}", num2), num2, index);
				}
				return false;
			}
			if (flag2)
			{
				num7++;
				num3--;
			}
			string text3 = ((num3 <= 0) ? string.Empty : Rfc2047.DecodePhrase(options, text, num7, num3, out codepage));
			if (codepage == -1)
			{
				codepage = 65001;
			}
			return TryParseGroup(options, text, num2, ref index, endIndex, groupDepth + 1, MimeUtils.Unquote(text3), codepage, flag, out address);
		}
		if ((flags & AddressParserFlags.AllowMailboxAddress) == 0)
		{
			if (flag)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Mailbox address token at offset {0}", num2), num2, index);
			}
			return false;
		}
		if (text[index] == 64)
		{
			index = num2;
			if (!TryParseAddrspec(text, ref index, endIndex, CommaGreaterThanOrSemiColon, options.AddressParserComplianceMode, flag, out var addrspec, out var at))
			{
				return false;
			}
			ParseUtils.SkipWhiteSpace(text, ref index, endIndex);
			string text4;
			if (index < endIndex && text[index] == 40)
			{
				int num8 = index;
				if (!ParseUtils.SkipComment(text, ref index, endIndex))
				{
					if (flag)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete comment token at offset {0}", num8), num8, index);
					}
					return false;
				}
				num8++;
				text4 = Rfc2047.DecodePhrase(options, text, num8, index - 1 - num8).Trim();
			}
			else
			{
				text4 = string.Empty;
			}
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, flag))
			{
				return false;
			}
			if (index >= endIndex)
			{
				address = new MailboxAddress(Encoding.UTF8, text4, addrspec, at);
				return true;
			}
			if (text[index] != 60)
			{
				if (text[index] == 62)
				{
					if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
					{
						if (flag)
						{
							throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected '>' token at offset {0}", index), num2, index);
						}
						return false;
					}
					index++;
				}
				address = new MailboxAddress(Encoding.UTF8, text4, addrspec, at);
				return true;
			}
			if (options.AddressParserComplianceMode == RfcComplianceMode.Strict)
			{
				if (flag)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected '<' token at offset {0}", index), num2, index);
				}
				return false;
			}
			int num9 = index;
			while (num9 > num2 && text[num9 - 1].IsWhitespace())
			{
				num9--;
			}
			num3 = num9 - num2;
		}
		if (text[index] == 60)
		{
			int num10 = num2;
			int codepage2 = -1;
			if (flag2)
			{
				num10++;
				num3--;
			}
			string text5 = ((num3 <= 0) ? string.Empty : Rfc2047.DecodePhrase(options, text, num10, num3, out codepage2));
			if (codepage2 == -1)
			{
				codepage2 = 65001;
			}
			return TryParseMailbox(options, text, num2, ref index, endIndex, MimeUtils.Unquote(text5), codepage2, flag, out address);
		}
		if (flag)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid address token at offset {0}", num2), num2, index);
		}
		return false;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out InternetAddress address)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.TryParse, out address))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false))
		{
			address = null;
			return false;
		}
		if (index != num)
		{
			address = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out InternetAddress address)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out address);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out InternetAddress address)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.TryParse, out address))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			address = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, out InternetAddress address)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out address);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out InternetAddress address)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.TryParse, out address))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			address = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, out InternetAddress address)
	{
		return TryParse(ParserOptions.Default, buffer, out address);
	}

	public static bool TryParse(ParserOptions options, string text, out InternetAddress address)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int num = bytes.Length;
		int index = 0;
		if (!TryParse(options, bytes, ref index, num, 0, AddressParserFlags.TryParse, out address))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: false) || index != num)
		{
			address = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(string text, out InternetAddress address)
	{
		return TryParse(ParserOptions.Default, text, out address);
	}

	public static InternetAddress Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.Parse, out var address))
		{
			throw new ParseException("No address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return address;
	}

	public static InternetAddress Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public static InternetAddress Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.Parse, out var address))
		{
			throw new ParseException("No address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return address;
	}

	public static InternetAddress Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public static InternetAddress Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, 0, AddressParserFlags.Parse, out var address))
		{
			throw new ParseException("No address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return address;
	}

	public static InternetAddress Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public static InternetAddress Parse(ParserOptions options, string text)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int num = bytes.Length;
		int index = 0;
		if (!TryParse(options, bytes, ref index, num, 0, AddressParserFlags.Parse, out var address))
		{
			throw new ParseException("No address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return address;
	}

	public static InternetAddress Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}
}
