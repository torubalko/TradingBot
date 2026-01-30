using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class GroupAddress : InternetAddress
{
	public InternetAddressList Members { get; private set; }

	public GroupAddress(Encoding encoding, string name, IEnumerable<InternetAddress> addresses)
		: base(encoding, name)
	{
		Members = new InternetAddressList(addresses);
		Members.Changed += MembersChanged;
	}

	public GroupAddress(string name, IEnumerable<InternetAddress> addresses)
		: this(Encoding.UTF8, name, addresses)
	{
	}

	public GroupAddress(Encoding encoding, string name)
		: base(encoding, name)
	{
		Members = new InternetAddressList();
		Members.Changed += MembersChanged;
	}

	public GroupAddress(string name)
		: this(Encoding.UTF8, name)
	{
	}

	public override InternetAddress Clone()
	{
		return new GroupAddress(base.Encoding, base.Name, Members.Select((InternetAddress x) => x.Clone()));
	}

	internal override void Encode(FormatOptions options, StringBuilder builder, bool firstToken, ref int lineLength)
	{
		if (!string.IsNullOrEmpty(base.Name))
		{
			string text;
			if (!options.International)
			{
				byte[] array = Rfc2047.EncodePhrase(options, base.Encoding, base.Name);
				text = Encoding.ASCII.GetString(array, 0, array.Length);
			}
			else
			{
				text = InternetAddress.EncodeInternationalizedPhrase(base.Name);
			}
			if (lineLength + text.Length > options.MaxLineLength)
			{
				if (text.Length > options.MaxLineLength)
				{
					builder.AppendFolded(options, firstToken, text, ref lineLength);
				}
				else
				{
					if (!firstToken && lineLength > 1)
					{
						builder.LineWrap(options);
						lineLength = 1;
					}
					lineLength += text.Length;
					builder.Append(text);
				}
			}
			else
			{
				lineLength += text.Length;
				builder.Append(text);
			}
		}
		builder.Append(": ");
		lineLength += 2;
		Members.Encode(options, builder, firstToken: false, ref lineLength);
		builder.Append(';');
		lineLength++;
	}

	public override string ToString(FormatOptions options, bool encode)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (encode)
		{
			int lineLength = 0;
			Encode(options, stringBuilder, firstToken: true, ref lineLength);
		}
		else
		{
			stringBuilder.Append(base.Name);
			stringBuilder.Append(':');
			stringBuilder.Append(' ');
			for (int i = 0; i < Members.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(Members[i]);
			}
			stringBuilder.Append(';');
		}
		return stringBuilder.ToString();
	}

	public override bool Equals(InternetAddress other)
	{
		if (!(other is GroupAddress groupAddress))
		{
			return false;
		}
		if (base.Name == groupAddress.Name)
		{
			return Members.Equals(groupAddress.Members);
		}
		return false;
	}

	private void MembersChanged(object sender, EventArgs e)
	{
		OnChanged();
	}

	private static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out GroupAddress group)
	{
		AddressParserFlags addressParserFlags = AddressParserFlags.AllowGroupAddress;
		if (throwOnError)
		{
			addressParserFlags |= AddressParserFlags.ThrowOnError;
		}
		if (!InternetAddress.TryParse(options, text, ref index, endIndex, 0, addressParserFlags, out var address))
		{
			group = null;
			return false;
		}
		group = (GroupAddress)address;
		return true;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out GroupAddress group)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out group))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			group = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out GroupAddress group)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out group);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out GroupAddress group)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out group))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			group = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, int startIndex, out GroupAddress group)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out group);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out GroupAddress group)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, throwOnError: false, out group))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index != num)
		{
			group = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(byte[] buffer, out GroupAddress group)
	{
		return TryParse(ParserOptions.Default, buffer, out group);
	}

	public static bool TryParse(ParserOptions options, string text, out GroupAddress group)
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
		if (!TryParse(options, bytes, ref index, num, throwOnError: false, out group))
		{
			return false;
		}
		if (!ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: false) || index != num)
		{
			group = null;
			return false;
		}
		return true;
	}

	public static bool TryParse(string text, out GroupAddress group)
	{
		return TryParse(ParserOptions.Default, text, out group);
	}

	public new static GroupAddress Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int num = startIndex + length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var group))
		{
			throw new ParseException("No group address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return group;
	}

	public new static GroupAddress Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public new static GroupAddress Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int num = buffer.Length;
		int index = startIndex;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var group))
		{
			throw new ParseException("No group address found.", startIndex, startIndex);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return group;
	}

	public new static GroupAddress Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public new static GroupAddress Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int num = buffer.Length;
		int index = 0;
		if (!TryParse(options, buffer, ref index, num, throwOnError: true, out var group))
		{
			throw new ParseException("No group address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return group;
	}

	public new static GroupAddress Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public new static GroupAddress Parse(ParserOptions options, string text)
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
		if (!TryParse(options, bytes, ref index, num, throwOnError: true, out var group))
		{
			throw new ParseException("No group address found.", 0, 0);
		}
		ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref index, num, throwOnError: true);
		if (index != num)
		{
			throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unexpected token at offset {0}", index), index, index);
		}
		return group;
	}

	public new static GroupAddress Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}
}
