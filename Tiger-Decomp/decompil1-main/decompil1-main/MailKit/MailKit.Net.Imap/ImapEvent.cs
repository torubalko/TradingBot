using System;
using System.Collections.Generic;
using System.Text;
using MimeKit;

namespace MailKit.Net.Imap;

public class ImapEvent
{
	public class MessageNew : ImapEvent
	{
		private readonly MessageSummaryItems items;

		private readonly HashSet<string> headers;

		public MessageNew(MessageSummaryItems items = MessageSummaryItems.None)
			: base("MessageNew", isMessageEvent: true)
		{
			headers = ImapFolder.EmptyHeaderFields;
			this.items = items;
		}

		public MessageNew(MessageSummaryItems items, HashSet<HeaderId> headers)
			: this(items)
		{
			this.headers = ImapUtils.GetUniqueHeaders(headers);
		}

		public MessageNew(MessageSummaryItems items, HashSet<string> headers)
			: this(items)
		{
			this.headers = ImapUtils.GetUniqueHeaders(headers);
		}

		internal override void Format(ImapEngine engine, StringBuilder command, IList<object> args, bool isSelectedFilter)
		{
			command.Append(base.Name);
			if (items != MessageSummaryItems.None || headers.Count != 0)
			{
				if (!isSelectedFilter)
				{
					throw new InvalidOperationException("The MessageNew event cannot have any parameters for mailbox filters other than SELECTED and SELECTED-DELAYED.");
				}
				MessageSummaryItems messageSummaryItems = items;
				command.Append(" ");
				command.Append(ImapFolder.FormatSummaryItems(engine, ref messageSummaryItems, headers, out var _, isNotify: true));
			}
		}
	}

	public static readonly ImapEvent MessageExpunge = new ImapEvent("MessageExpunge", isMessageEvent: true);

	public static readonly ImapEvent FlagChange = new ImapEvent("FlagChange", isMessageEvent: true);

	public static readonly ImapEvent AnnotationChange = new ImapEvent("AnnotationChange", isMessageEvent: true);

	public static readonly ImapEvent MailboxName = new ImapEvent("MailboxName", isMessageEvent: false);

	public static readonly ImapEvent SubscriptionChange = new ImapEvent("SubscriptionChange", isMessageEvent: false);

	public static readonly ImapEvent MailboxMetadataChange = new ImapEvent("MailboxMetadataChange", isMessageEvent: false);

	public static readonly ImapEvent ServerMetadataChange = new ImapEvent("ServerMetadataChange", isMessageEvent: false);

	internal bool IsMessageEvent { get; private set; }

	public string Name { get; private set; }

	internal ImapEvent(string name, bool isMessageEvent)
	{
		IsMessageEvent = isMessageEvent;
		Name = name;
	}

	internal virtual void Format(ImapEngine engine, StringBuilder command, IList<object> args, bool isSelectedFilter)
	{
		command.Append(Name);
	}
}
