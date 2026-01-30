using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;
using MimeKit.Utils;

namespace MailKit.Net.Imap;

internal static class ImapUtils
{
	private class UniqueHeaderSet : HashSet<string>
	{
		public UniqueHeaderSet()
			: base((IEqualityComparer<string>)StringComparer.Ordinal)
		{
		}
	}

	private struct EnvelopeAddress
	{
		public readonly string Name;

		public readonly string Route;

		public readonly string Mailbox;

		public readonly string Domain;

		public bool IsGroupStart
		{
			get
			{
				if (Name == null && Route == null && Mailbox != null)
				{
					return Domain == null;
				}
				return false;
			}
		}

		public bool IsGroupEnd
		{
			get
			{
				if (Name == null && Route == null && Mailbox == null)
				{
					return Domain == null;
				}
				return false;
			}
		}

		public EnvelopeAddress(string[] values)
		{
			Name = values[0];
			Route = values[1];
			Mailbox = values[2];
			Domain = values[3];
		}

		public MailboxAddress ToMailboxAddress(ImapEngine engine)
		{
			string text = Mailbox;
			string text2 = Domain;
			string name = null;
			if (Name != null)
			{
				Encoding encoding = (engine.UTF8Enabled ? ImapEngine.UTF8 : ImapEngine.Latin1);
				name = Rfc2047.DecodePhrase(encoding.GetBytes(Name));
			}
			switch (text2)
			{
			case "MISSING_DOMAIN":
			case ".MISSING-HOST-NAME.":
				text2 = null;
				break;
			default:
				text2 = text2.TrimEnd('>');
				break;
			case null:
				break;
			}
			if (text != null)
			{
				text = text.TrimStart('<');
			}
			string address = ((text2 != null) ? (text + "@" + text2) : text);
			if (Route != null && DomainList.TryParse(Route, out var route))
			{
				return new MailboxAddress(name, route, address);
			}
			return new MailboxAddress(name, address);
		}

		public GroupAddress ToGroupAddress(ImapEngine engine)
		{
			string name = string.Empty;
			if (Mailbox != null)
			{
				Encoding encoding = (engine.UTF8Enabled ? ImapEngine.UTF8 : ImapEngine.Latin1);
				name = Rfc2047.DecodePhrase(encoding.GetBytes(Mailbox));
			}
			return new GroupAddress(name);
		}
	}

	private const FolderAttributes SpecialUseAttributes = FolderAttributes.All | FolderAttributes.Archive | FolderAttributes.Drafts | FolderAttributes.Flagged | FolderAttributes.Important | FolderAttributes.Inbox | FolderAttributes.Junk | FolderAttributes.Sent | FolderAttributes.Trash;

	private const string QuotedSpecials = " \t()<>@,;:\\\"/[]?=";

	private static readonly int InboxLength = "INBOX".Length;

	private static readonly string[] Months = new string[12]
	{
		"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct",
		"Nov", "Dec"
	};

	public static string FormatInternalDate(DateTimeOffset date)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0:D2}-{1}-{2:D4} {3:D2}:{4:D2}:{5:D2} {6:+00;-00}{7:00}", date.Day, Months[date.Month - 1], date.Year, date.Hour, date.Minute, date.Second, date.Offset.Hours, date.Offset.Minutes);
	}

	public static HashSet<string> GetUniqueHeaders(IEnumerable<string> headers)
	{
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		if (headers is UniqueHeaderSet result)
		{
			return result;
		}
		UniqueHeaderSet uniqueHeaderSet = new UniqueHeaderSet();
		foreach (string header in headers)
		{
			if (header.Length == 0)
			{
				throw new ArgumentException("Invalid header field: " + header, "headers");
			}
			foreach (char c in header)
			{
				if (c <= ' ' || c >= '\u007f' || c == ':')
				{
					throw new ArgumentException("Illegal characters in header field: " + header, "headers");
				}
			}
			uniqueHeaderSet.Add(header.ToUpperInvariant());
		}
		return uniqueHeaderSet;
	}

	public static HashSet<string> GetUniqueHeaders(IEnumerable<HeaderId> headers)
	{
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		UniqueHeaderSet uniqueHeaderSet = new UniqueHeaderSet();
		foreach (HeaderId header in headers)
		{
			if (header != HeaderId.Unknown)
			{
				uniqueHeaderSet.Add(header.ToHeaderName().ToUpperInvariant());
			}
		}
		return uniqueHeaderSet;
	}

	private static bool TryGetInt32(string text, ref int index, out int value)
	{
		int num = index;
		value = 0;
		while (index < text.Length && text[index] >= '0' && text[index] <= '9')
		{
			int num2 = text[index] - 48;
			if (value > 214748364 || (value == 214748364 && num2 > 7))
			{
				return false;
			}
			value = value * 10 + num2;
			index++;
		}
		return index > num;
	}

	private static bool TryGetInt32(string text, ref int index, char delim, out int value)
	{
		if (TryGetInt32(text, ref index, out value) && index < text.Length)
		{
			return text[index] == delim;
		}
		return false;
	}

	private static bool TryGetMonth(string text, ref int index, char delim, out int month)
	{
		int num = index;
		month = 0;
		if ((index = text.IndexOf(delim, index)) == -1 || index - num != 3)
		{
			return false;
		}
		for (int i = 0; i < Months.Length; i++)
		{
			if (string.Compare(Months[i], 0, text, num, 3, StringComparison.OrdinalIgnoreCase) == 0)
			{
				month = i + 1;
				return true;
			}
		}
		return false;
	}

	private static bool TryGetTimeZone(string text, ref int index, out TimeSpan timezone)
	{
		int num = 1;
		if (text[index] == '-')
		{
			num = -1;
			index++;
		}
		else if (text[index] == '+')
		{
			index++;
		}
		if (!TryGetInt32(text, ref index, out var value))
		{
			timezone = default(TimeSpan);
			return false;
		}
		for (value *= num; value < -1400; value += 2400)
		{
		}
		while (value > 1400)
		{
			value -= 2400;
		}
		int minutes = value % 100;
		int hours = value / 100;
		timezone = new TimeSpan(hours, minutes, 0);
		return true;
	}

	public static DateTimeOffset ParseInternalDate(string text)
	{
		int i;
		for (i = 0; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		if (i >= text.Length || !TryGetInt32(text, ref i, '-', out var value) || value < 1 || value > 31)
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetMonth(text, ref i, '-', out var month))
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetInt32(text, ref i, ' ', out var value2) || value2 < 1969)
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetInt32(text, ref i, ':', out var value3) || value3 > 23)
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetInt32(text, ref i, ':', out var value4) || value4 > 59)
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetInt32(text, ref i, ' ', out var value5) || value5 > 59)
		{
			return DateTimeOffset.MinValue;
		}
		i++;
		if (i >= text.Length || !TryGetTimeZone(text, ref i, out var timezone))
		{
			return DateTimeOffset.MinValue;
		}
		for (; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		if (i < text.Length)
		{
			return DateTimeOffset.MinValue;
		}
		return new DateTimeOffset(value2, month, value, value3, value4, value5, timezone);
	}

	public static void FormatAnnotations(StringBuilder command, IList<Annotation> annotations, List<object> args, bool throwOnError)
	{
		int length = command.Length;
		int num = 0;
		command.Append("ANNOTATION (");
		for (int i = 0; i < annotations.Count; i++)
		{
			Annotation annotation = annotations[i];
			if (annotation.Properties.Count == 0)
			{
				if (throwOnError)
				{
					throw new ArgumentException("One or more annotations does not define any attributes.", "annotations");
				}
				continue;
			}
			command.Append(annotation.Entry);
			command.Append(" (");
			foreach (KeyValuePair<AnnotationAttribute, string> property in annotation.Properties)
			{
				command.AppendFormat("{0} %S ", property.Key);
				args.Add(property.Value);
			}
			command[command.Length - 1] = ')';
			command.Append(' ');
			num++;
		}
		if (num > 0)
		{
			command[command.Length - 1] = ')';
		}
		else
		{
			command.Length = length;
		}
	}

	public static string FormatIndexSet(ImapEngine engine, IList<int> indexes)
	{
		if (engine == null)
		{
			throw new ArgumentNullException("engine");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (indexes.Count == 0)
		{
			throw new ArgumentException("No indexes were specified.", "indexes");
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (num < indexes.Count)
		{
			if (indexes[num] < 0)
			{
				throw new ArgumentException("One or more of the indexes is negative.", "indexes");
			}
			int num2 = indexes[num];
			int num3 = indexes[num];
			int i = num + 1;
			if (i < indexes.Count)
			{
				if (indexes[i] == num3 + 1)
				{
					for (num3 = indexes[i++]; i < indexes.Count && indexes[i] == num3 + 1; i++)
					{
						num3++;
					}
				}
				else if (indexes[i] == num3 - 1 && engine.QuirksMode != ImapQuirksMode.hMailServer)
				{
					for (num3 = indexes[i++]; i < indexes.Count && indexes[i] == num3 - 1; i++)
					{
						num3--;
					}
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(',');
			}
			if (num2 != num3)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}:{1}", num2 + 1, num3 + 1);
			}
			else
			{
				stringBuilder.Append((num2 + 1).ToString(CultureInfo.InvariantCulture));
			}
			num = i;
		}
		return stringBuilder.ToString();
	}

	public static async Task ParseImplementationAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "ID", "{0}");
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type != ImapTokenType.Nil)
		{
			ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
			imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			ImapImplementation implementation = new ImapImplementation();
			while (imapToken.Type != ImapTokenType.CloseParen)
			{
				string property = await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				string value = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				implementation.Properties[property] = value;
				imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			ic.UserData = implementation;
			await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	public static string CanonicalizeMailboxName(string mailboxName, char directorySeparator)
	{
		if (!mailboxName.StartsWith("INBOX", StringComparison.OrdinalIgnoreCase))
		{
			return mailboxName;
		}
		if (mailboxName.Length > InboxLength && mailboxName[InboxLength] == directorySeparator)
		{
			return "INBOX" + mailboxName.Substring(InboxLength);
		}
		if (mailboxName.Length == InboxLength)
		{
			return "INBOX";
		}
		return mailboxName;
	}

	public static bool IsInbox(string mailboxName)
	{
		return string.Compare(mailboxName, "INBOX", StringComparison.OrdinalIgnoreCase) == 0;
	}

	private static async Task<string> ReadFolderNameAsync(ImapEngine engine, char delim, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string encodedName;
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			encodedName = await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			encodedName = (string)imapToken.Value;
			if (engine.QuirksMode == ImapQuirksMode.Exchange)
			{
				string text = await engine.ReadLineAsync(doAsync, cancellationToken);
				int num = text.IndexOf("\r\n", StringComparison.Ordinal);
				num = ((num != -1) ? num : (text.Length - 1));
				imapToken = new ImapToken(ImapTokenType.Eoln);
				engine.Stream.UngetToken(imapToken);
				if (num > 0)
				{
					encodedName += text.Substring(0, num);
				}
			}
			break;
		case ImapTokenType.Nil:
			return "NIL";
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
		return encodedName.TrimEnd(delim);
	}

	public static async Task ParseFolderListAsync(ImapEngine engine, List<ImapFolder> list, bool isLsub, bool returnsSubscribed, bool doAsync, CancellationToken cancellationToken)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", isLsub ? "LSUB" : "LIST", "{0}");
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		FolderAttributes attrs = FolderAttributes.None;
		ImapFolder folder = null;
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (imapToken.Type == ImapTokenType.Flag || imapToken.Type == ImapTokenType.Atom)
		{
			switch (((string)imapToken.Value).ToLowerInvariant())
			{
			case "\\noinferiors":
				attrs |= FolderAttributes.NoInferiors;
				break;
			case "\\noselect":
				attrs |= FolderAttributes.NoSelect;
				break;
			case "\\marked":
				attrs |= FolderAttributes.Marked;
				break;
			case "\\unmarked":
				attrs |= FolderAttributes.Unmarked;
				break;
			case "\\nonexistent":
				attrs |= FolderAttributes.NonExistent;
				break;
			case "\\subscribed":
				attrs |= FolderAttributes.Subscribed;
				break;
			case "\\remote":
				attrs |= FolderAttributes.Remote;
				break;
			case "\\haschildren":
				attrs |= FolderAttributes.HasChildren;
				break;
			case "\\hasnochildren":
				attrs |= FolderAttributes.HasNoChildren;
				break;
			case "\\all":
				attrs |= FolderAttributes.All;
				break;
			case "\\archive":
				attrs |= FolderAttributes.Archive;
				break;
			case "\\drafts":
				attrs |= FolderAttributes.Drafts;
				break;
			case "\\flagged":
				attrs |= FolderAttributes.Flagged;
				break;
			case "\\important":
				attrs |= FolderAttributes.Important;
				break;
			case "\\junk":
				attrs |= FolderAttributes.Junk;
				break;
			case "\\sent":
				attrs |= FolderAttributes.Sent;
				break;
			case "\\trash":
				attrs |= FolderAttributes.Trash;
				break;
			case "\\allmail":
				attrs |= FolderAttributes.All;
				break;
			case "\\inbox":
				attrs |= FolderAttributes.Inbox;
				break;
			case "\\spam":
				attrs |= FolderAttributes.Junk;
				break;
			case "\\starred":
				attrs |= FolderAttributes.Flagged;
				break;
			}
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, format, imapToken);
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		char delim;
		if (imapToken.Type == ImapTokenType.QString)
		{
			string text = (string)imapToken.Value;
			delim = text[0];
		}
		else
		{
			if (imapToken.Type != ImapTokenType.Nil)
			{
				throw ImapEngine.UnexpectedToken(format, imapToken);
			}
			delim = '\0';
		}
		string encodedName = await ReadFolderNameAsync(engine, delim, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (IsInbox(encodedName))
		{
			attrs |= FolderAttributes.Inbox;
		}
		imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			bool renamed = false;
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			while (true)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.CloseParen)
				{
					break;
				}
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, format, imapToken);
				string atom = (string)imapToken.Value;
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
				while (true)
				{
					imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (imapToken.Type == ImapTokenType.CloseParen)
					{
						break;
					}
					engine.Stream.UngetToken(imapToken);
					if (renamed || !atom.Equals("OLDNAME", StringComparison.OrdinalIgnoreCase))
					{
						await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						continue;
					}
					string key = await ReadFolderNameAsync(engine, delim, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (engine.FolderCache.TryGetValue(key, out var value))
					{
						ImapFolderConstructorArgs args = new ImapFolderConstructorArgs(engine, encodedName, attrs, delim);
						engine.FolderCache.Remove(key);
						engine.FolderCache[encodedName] = value;
						value.OnRenamed(args);
						folder = value;
					}
					renamed = true;
				}
			}
		}
		else
		{
			ImapEngine.AssertToken(imapToken, ImapTokenType.Eoln, format, imapToken);
		}
		if (folder != null || engine.GetCachedFolder(encodedName, out folder))
		{
			if ((attrs & FolderAttributes.NonExistent) != FolderAttributes.None)
			{
				folder.UpdatePermanentFlags(MessageFlags.None);
				folder.UpdateAcceptedFlags(MessageFlags.None);
				folder.UpdateUidNext(UniqueId.Invalid);
				folder.UpdateHighestModSeq(0uL);
				folder.UpdateUidValidity(0u);
				folder.UpdateUnread(0);
			}
			if (isLsub)
			{
				attrs |= folder.Attributes | FolderAttributes.Subscribed;
			}
			else
			{
				attrs |= folder.Attributes & (FolderAttributes.All | FolderAttributes.Archive | FolderAttributes.Drafts | FolderAttributes.Flagged | FolderAttributes.Important | FolderAttributes.Inbox | FolderAttributes.Junk | FolderAttributes.Sent | FolderAttributes.Trash);
				if (!returnsSubscribed)
				{
					attrs |= folder.Attributes & FolderAttributes.Subscribed;
				}
			}
			folder.UpdateAttributes(attrs);
		}
		else
		{
			folder = engine.CreateImapFolder(encodedName, attrs, delim);
			engine.CacheFolder(folder);
			if (list == null)
			{
				engine.OnFolderCreated(folder);
			}
		}
		list?.Add(folder);
	}

	public static Task ParseFolderListAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		List<ImapFolder> list = (List<ImapFolder>)ic.UserData;
		return ParseFolderListAsync(engine, list, ic.Lsub, ic.ListReturnsSubscribed, doAsync, ic.CancellationToken);
	}

	public static async Task ParseMetadataAsync(ImapEngine engine, MetadataCollection metadata, bool doAsync, CancellationToken cancellationToken)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "METADATA", "{0}");
		string encodedName = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		while (imapToken.Type != ImapTokenType.CloseParen)
		{
			string tag = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			string value = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			metadata.Add(new Metadata(MetadataTag.Create(tag), value)
			{
				EncodedName = encodedName
			});
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public static Task ParseMetadataAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		MetadataCollection metadata = (MetadataCollection)ic.UserData;
		return ParseMetadataAsync(engine, metadata, doAsync, ic.CancellationToken);
	}

	internal static async Task<string> ReadStringTokenAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			return await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			return (string)imapToken.Value;
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
	}

	private static async Task<string> ReadNStringTokenAsync(ImapEngine engine, string format, bool rfc2047, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string text;
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			text = await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			text = (string)imapToken.Value;
			break;
		case ImapTokenType.Nil:
			return null;
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
		if (rfc2047)
		{
			Encoding encoding = (engine.UTF8Enabled ? ImapEngine.UTF8 : ImapEngine.Latin1);
			return Rfc2047.DecodeText(encoding.GetBytes(text));
		}
		return text;
	}

	private static async Task<uint> ReadNumberAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.Atom)
		{
			string text = (string)imapToken.Value;
			if (text.Length > 0 && text[0] == '-')
			{
				if (!int.TryParse(text, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out var _))
				{
					throw ImapEngine.UnexpectedToken(format, imapToken);
				}
				return 0u;
			}
		}
		return ImapEngine.ParseNumber(imapToken, false, format, imapToken);
	}

	private static bool NeedsQuoting(string value)
	{
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] > '\u007f' || char.IsControl(value[i]))
			{
				return true;
			}
			if (" \t()<>@,;:\\\"/[]?=".IndexOf(value[i]) != -1)
			{
				return true;
			}
		}
		return value.Length == 0;
	}

	private static async Task ParseParameterListAsync(StringBuilder builder, ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		while ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
		{
			string name = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			string text = (await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) ?? string.Empty;
			builder.Append("; ").Append(name).Append('=');
			if (NeedsQuoting(text))
			{
				MimeUtils.AppendQuoted(builder, text);
			}
			else
			{
				builder.Append(text);
			}
		}
		await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private static async Task<object> ParseContentTypeAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		string type = (await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) ?? "application";
		ImapToken imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string subtype;
		if (imapToken.Type == ImapTokenType.OpenParen || imapToken.Type == ImapTokenType.Nil)
		{
			if (engine.QuirksMode == ImapQuirksMode.GMail)
			{
				return type;
			}
			if (imapToken.Type != ImapTokenType.Nil)
			{
				subtype = type;
				type = "application";
			}
			else
			{
				await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				subtype = string.Empty;
			}
		}
		else
		{
			subtype = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.Nil)
		{
			return new ContentType(type, subtype);
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		StringBuilder builder = new StringBuilder();
		builder.AppendFormat("{0}/{1}", type, subtype);
		await ParseParameterListAsync(builder, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (!ContentType.TryParse(builder.ToString(), out var type2))
		{
			type2 = new ContentType(type, subtype);
		}
		return type2;
	}

	private static async Task<ContentDisposition> ParseContentDispositionAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.Nil)
		{
			return null;
		}
		if (imapToken.Type != ImapTokenType.OpenParen)
		{
			if (imapToken.Type == ImapTokenType.Atom || imapToken.Type == ImapTokenType.QString)
			{
				return new ContentDisposition((string)imapToken.Value);
			}
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
		string dsp = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		StringBuilder builder = new StringBuilder();
		bool isNil = false;
		if (string.IsNullOrEmpty(dsp))
		{
			builder.Append("attachment");
		}
		else
		{
			builder.Append(dsp.Trim('"'));
		}
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			await ParseParameterListAsync(builder, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else
		{
			if (imapToken.Type != ImapTokenType.Nil)
			{
				throw ImapEngine.UnexpectedToken(format, imapToken);
			}
			isNil = true;
		}
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, format, imapToken);
		if (dsp == null && isNil)
		{
			return null;
		}
		ContentDisposition.TryParse(builder.ToString(), out var disposition);
		return disposition;
	}

	private static async Task<string[]> ParseContentLanguageAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		List<string> languages = new List<string>();
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			languages.Add(await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
			break;
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
		{
			string text = (string)imapToken.Value;
			languages.Add(text);
			break;
		}
		case ImapTokenType.Nil:
			return null;
		case ImapTokenType.OpenParen:
			while ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
			{
				string text = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (text != null)
				{
					languages.Add(text);
				}
			}
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
		return languages.ToArray();
	}

	private static async Task<Uri> ParseContentLocationAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		string text = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		if (Uri.IsWellFormedUriString(text, UriKind.Absolute))
		{
			return new Uri(text, UriKind.Absolute);
		}
		if (Uri.IsWellFormedUriString(text, UriKind.Relative))
		{
			return new Uri(text, UriKind.Relative);
		}
		return null;
	}

	private static async Task SkipBodyExtensionAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		switch (imapToken.Type)
		{
		case ImapTokenType.OpenParen:
			while ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
			{
				await SkipBodyExtensionAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapTokenType.Literal:
			await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		case ImapTokenType.Nil:
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			break;
		}
	}

	private static async Task<BodyPart> ParseMultipartAsync(ImapEngine engine, string format, string path, string subtype, bool doAsync, CancellationToken cancellationToken)
	{
		string prefix = ((path.Length > 0) ? (path + ".") : string.Empty);
		BodyPartMultipart body = new BodyPartMultipart();
		int index = 1;
		ImapToken imapToken;
		if (subtype == null)
		{
			do
			{
				BodyPartCollection bodyParts = body.BodyParts;
				bodyParts.Add(await ParseBodyAsync(engine, format, prefix + index, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				index++;
			}
			while (imapToken.Type == ImapTokenType.OpenParen);
			subtype = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		body.ContentType = new ContentType("multipart", subtype);
		body.PartSpecifier = path;
		imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type != ImapTokenType.CloseParen)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, ImapTokenType.Nil, format, imapToken);
			StringBuilder builder = new StringBuilder();
			builder.AppendFormat("{0}/{1}", body.ContentType.MediaType, body.ContentType.MediaSubtype);
			if (imapToken.Type == ImapTokenType.OpenParen)
			{
				await ParseParameterListAsync(builder, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (ContentType.TryParse(builder.ToString(), out var type))
			{
				body.ContentType = type;
			}
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (imapToken.Type == ImapTokenType.QString)
		{
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		else if (imapToken.Type != ImapTokenType.CloseParen)
		{
			BodyPartMultipart bodyPartMultipart = body;
			bodyPartMultipart.ContentDisposition = await ParseContentDispositionAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (imapToken.Type != ImapTokenType.CloseParen)
		{
			BodyPartMultipart bodyPartMultipart = body;
			bodyPartMultipart.ContentLanguage = await ParseContentLanguageAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (imapToken.Type != ImapTokenType.CloseParen)
		{
			BodyPartMultipart bodyPartMultipart = body;
			bodyPartMultipart.ContentLocation = await ParseContentLocationAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		while (imapToken.Type != ImapTokenType.CloseParen)
		{
			await SkipBodyExtensionAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return body;
	}

	public static async Task<BodyPart> ParseBodyAsync(ImapEngine engine, string format, string path, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.Nil)
		{
			return null;
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.CloseParen)
		{
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return null;
		}
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			return await ParseMultipartAsync(engine, format, path, null, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		object result = await ParseContentTypeAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (result is string)
		{
			return await ParseMultipartAsync(engine, format, path, (string)result, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		string id = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string desc = await ReadNStringTokenAsync(engine, format, rfc2047: true, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string enc = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		uint octets = await ReadNumberAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ContentType type = (ContentType)result;
		bool isMultipart = false;
		BodyPartBasic body;
		if (type.IsMimeType("message", "rfc822"))
		{
			BodyPartMessage mesg = new BodyPartMessage();
			if ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type == ImapTokenType.OpenParen)
			{
				BodyPartMessage bodyPartMessage = mesg;
				bodyPartMessage.Envelope = await ParseEnvelopeAsync(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				bodyPartMessage = mesg;
				bodyPartMessage.Body = await ParseBodyAsync(engine, format, path, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				bodyPartMessage = mesg;
				bodyPartMessage.Lines = await ReadNumberAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			body = mesg;
		}
		else if (type.IsMimeType("text", "*"))
		{
			BodyPartText text = new BodyPartText();
			BodyPartText bodyPartText = text;
			bodyPartText.Lines = await ReadNumberAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			body = text;
		}
		else
		{
			isMultipart = type.IsMimeType("multipart", "*");
			body = new BodyPartBasic();
		}
		body.ContentTransferEncoding = enc;
		body.ContentDescription = desc;
		body.PartSpecifier = path;
		body.ContentType = type;
		body.ContentId = id;
		body.Octets = octets;
		imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (!isMultipart)
		{
			if (imapToken.Type != ImapTokenType.CloseParen)
			{
				BodyPartBasic bodyPartBasic = body;
				bodyPartBasic.ContentMd5 = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (imapToken.Type != ImapTokenType.CloseParen)
			{
				BodyPartBasic bodyPartBasic = body;
				bodyPartBasic.ContentDisposition = await ParseContentDispositionAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (imapToken.Type != ImapTokenType.CloseParen)
			{
				BodyPartBasic bodyPartBasic = body;
				bodyPartBasic.ContentLanguage = await ParseContentLanguageAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (imapToken.Type != ImapTokenType.CloseParen)
			{
				BodyPartBasic bodyPartBasic = body;
				bodyPartBasic.ContentLocation = await ParseContentLocationAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		while (imapToken.Type != ImapTokenType.CloseParen)
		{
			await SkipBodyExtensionAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return body;
	}

	private static async Task<EnvelopeAddress> ParseEnvelopeAddressAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		string[] values = new string[4];
		int index = 0;
		ImapToken imapToken;
		do
		{
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			switch (imapToken.Type)
			{
			case ImapTokenType.Literal:
			{
				string[] array = values;
				int num = index;
				array[num] = await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				break;
			}
			case ImapTokenType.Atom:
			case ImapTokenType.QString:
				values[index] = (string)imapToken.Value;
				break;
			default:
				throw ImapEngine.UnexpectedToken(format, imapToken);
			case ImapTokenType.Nil:
				break;
			}
			index++;
		}
		while (index < 4);
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, format, imapToken);
		return new EnvelopeAddress(values);
	}

	private static async Task ParseEnvelopeAddressListAsync(InternetAddressList list, ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (imapToken.Type == ImapTokenType.Nil)
		{
			return;
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		List<InternetAddressList> stack = new List<InternetAddressList>();
		int sp = 0;
		stack.Add(list);
		while (true)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.CloseParen)
			{
				break;
			}
			if (imapToken.Type == ImapTokenType.Nil)
			{
				continue;
			}
			ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
			EnvelopeAddress envelopeAddress = await ParseEnvelopeAddressAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (envelopeAddress.IsGroupStart && engine.QuirksMode != ImapQuirksMode.GMail)
			{
				GroupAddress groupAddress = envelopeAddress.ToGroupAddress(engine);
				stack[sp].Add(groupAddress);
				stack.Add(groupAddress.Members);
				sp++;
			}
			else if (envelopeAddress.IsGroupEnd)
			{
				if (sp > 0)
				{
					stack.RemoveAt(sp);
					sp--;
				}
			}
			else
			{
				try
				{
					MailboxAddress address = envelopeAddress.ToMailboxAddress(engine);
					stack[sp].Add(address);
				}
				catch
				{
				}
			}
		}
	}

	private static async Task<DateTimeOffset?> ParseEnvelopeDateAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		string text;
		switch (imapToken.Type)
		{
		case ImapTokenType.Literal:
			text = await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			break;
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			text = (string)imapToken.Value;
			break;
		case ImapTokenType.Nil:
			return null;
		default:
			throw ImapEngine.UnexpectedToken(format, imapToken);
		}
		if (!DateUtils.TryParse(text, out var date))
		{
			return null;
		}
		return date;
	}

	public static async Task<Envelope> ParseEnvelopeAsync(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		string format = string.Format("Syntax error in {0}. {1}", "ENVELOPE", "{0}");
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		Envelope envelope = new Envelope();
		Envelope envelope2 = envelope;
		envelope2.Date = await ParseEnvelopeDateAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		envelope2 = envelope;
		envelope2.Subject = await ReadNStringTokenAsync(engine, format, rfc2047: true, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.From, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.Sender, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.ReplyTo, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.To, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.Cc, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ParseEnvelopeAddressListAsync(envelope.Bcc, engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
		{
			string text;
			if ((text = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) != null)
			{
				envelope.InReplyTo = MimeUtils.EnumerateReferences(text).FirstOrDefault();
			}
			if ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen && (text = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) != null)
			{
				try
				{
					envelope.MessageId = MimeUtils.ParseMessageId(text);
				}
				catch
				{
					envelope.MessageId = text;
				}
			}
		}
		imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, format, imapToken);
		return envelope;
	}

	public static string FormatFlagsList(MessageFlags flags, int numKeywords)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		if ((flags & MessageFlags.Answered) != MessageFlags.None)
		{
			stringBuilder.Append("\\Answered ");
		}
		if ((flags & MessageFlags.Deleted) != MessageFlags.None)
		{
			stringBuilder.Append("\\Deleted ");
		}
		if ((flags & MessageFlags.Draft) != MessageFlags.None)
		{
			stringBuilder.Append("\\Draft ");
		}
		if ((flags & MessageFlags.Flagged) != MessageFlags.None)
		{
			stringBuilder.Append("\\Flagged ");
		}
		if ((flags & MessageFlags.Seen) != MessageFlags.None)
		{
			stringBuilder.Append("\\Seen ");
		}
		for (int i = 0; i < numKeywords; i++)
		{
			stringBuilder.Append("%S ");
		}
		if (stringBuilder.Length > 1)
		{
			stringBuilder.Length--;
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	public static async Task<MessageFlags> ParseFlagsListAsync(ImapEngine engine, string name, HashSet<string> keywords, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		MessageFlags flags = MessageFlags.None;
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", name, imapToken);
		imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (imapToken.Type == ImapTokenType.Atom || imapToken.Type == ImapTokenType.Flag || imapToken.Type == ImapTokenType.QString || imapToken.Type == ImapTokenType.Nil)
		{
			if (imapToken.Type != ImapTokenType.Nil)
			{
				string text = (string)imapToken.Value;
				switch (text)
				{
				case "\\Answered":
					flags |= MessageFlags.Answered;
					break;
				case "\\Deleted":
					flags |= MessageFlags.Deleted;
					break;
				case "\\Draft":
					flags |= MessageFlags.Draft;
					break;
				case "\\Flagged":
					flags |= MessageFlags.Flagged;
					break;
				case "\\Seen":
					flags |= MessageFlags.Seen;
					break;
				case "\\Recent":
					flags |= MessageFlags.Recent;
					break;
				case "\\*":
					flags |= MessageFlags.UserDefined;
					break;
				default:
					keywords?.Add(text);
					break;
				}
			}
			imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", name, imapToken);
		return flags;
	}

	public static async Task<ReadOnlyCollection<Annotation>> ParseAnnotationsAsync(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "ANNOTATION", "{0}");
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		List<Annotation> annotations = new List<Annotation>();
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", "ANNOTATION", imapToken);
		while ((await engine.PeekTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
		{
			AnnotationEntry entry = AnnotationEntry.Parse(await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
			Annotation annotation = new Annotation(entry);
			annotations.Add(annotation);
			if ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type == ImapTokenType.OpenParen)
			{
				await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				while ((await engine.PeekTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen)
				{
					string name = await ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					string value = await ReadNStringTokenAsync(engine, format, rfc2047: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					AnnotationAttribute key = new AnnotationAttribute(name);
					annotation.Properties[key] = value;
				}
				await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return new ReadOnlyCollection<Annotation>(annotations);
	}

	public static async Task<ReadOnlyCollection<string>> ParseLabelsListAsync(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		List<string> labels = new List<string>();
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", "X-GM-LABELS", imapToken);
		imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (imapToken.Type == ImapTokenType.Flag || imapToken.Type == ImapTokenType.Atom || imapToken.Type == ImapTokenType.QString || imapToken.Type == ImapTokenType.Nil)
		{
			if (imapToken.Type != ImapTokenType.Nil)
			{
				string item = engine.DecodeMailboxName((string)imapToken.Value);
				labels.Add(item);
			}
			else
			{
				labels.Add("NIL");
			}
			imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", "X-GM-LABELS", imapToken);
		return new ReadOnlyCollection<string>(labels);
	}

	private static async Task<MessageThread> ParseThreadAsync(ImapEngine engine, uint uidValidity, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		MessageThread thread;
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			thread = new MessageThread((UniqueId?)null);
			do
			{
				MessageThread item = await ParseThreadAsync(engine, uidValidity, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				thread.Children.Add(item);
			}
			while ((await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.CloseParen);
			return thread;
		}
		uint id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in untagged {0} response. {1}", "THREAD", imapToken);
		MessageThread messageThread;
		thread = (messageThread = new MessageThread(new UniqueId(uidValidity, id)));
		MessageThread node = messageThread;
		while (true)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.CloseParen)
			{
				break;
			}
			MessageThread item;
			if (imapToken.Type == ImapTokenType.OpenParen)
			{
				item = await ParseThreadAsync(engine, uidValidity, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				node.Children.Add(item);
				continue;
			}
			id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in untagged {0} response. {1}", "THREAD", imapToken);
			item = new MessageThread(new UniqueId(uidValidity, id));
			node.Children.Add(item);
			node = item;
		}
		return thread;
	}

	public static async Task<IList<MessageThread>> ParseThreadsAsync(ImapEngine engine, uint uidValidity, bool doAsync, CancellationToken cancellationToken)
	{
		List<MessageThread> threads = new List<MessageThread>();
		while ((await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.Eoln)
		{
			ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "THREAD", imapToken);
			List<MessageThread> list = threads;
			list.Add(await ParseThreadAsync(engine, uidValidity, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		}
		return threads;
	}
}
