using System;
using System.Collections.Generic;
using System.Text;

namespace MailKit.Net.Imap;

public sealed class ImapEventGroup
{
	public ImapMailboxFilter MailboxFilter { get; private set; }

	public IList<ImapEvent> Events { get; private set; }

	public ImapEventGroup(ImapMailboxFilter mailboxFilter, IList<ImapEvent> events)
	{
		if (mailboxFilter == null)
		{
			throw new ArgumentNullException("mailboxFilter");
		}
		if (events == null)
		{
			throw new ArgumentNullException("events");
		}
		MailboxFilter = mailboxFilter;
		Events = events;
	}

	internal void Format(ImapEngine engine, StringBuilder command, IList<object> args, ref bool notifySelectedNewExpunge)
	{
		bool flag = MailboxFilter == ImapMailboxFilter.Selected || MailboxFilter == ImapMailboxFilter.SelectedDelayed;
		command.Append("(");
		MailboxFilter.Format(engine, command, args);
		command.Append(" ");
		if (Events.Count > 0)
		{
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			command.Append("(");
			for (int i = 0; i < Events.Count; i++)
			{
				ImapEvent imapEvent = Events[i];
				if (flag && !imapEvent.IsMessageEvent)
				{
					throw new InvalidOperationException("Only message events may be specified when SELECTED or SELECTED-DELAYED is used.");
				}
				if (imapEvent is ImapEvent.MessageNew)
				{
					flag4 = true;
				}
				else if (imapEvent == ImapEvent.MessageExpunge)
				{
					flag3 = true;
				}
				else if (imapEvent == ImapEvent.FlagChange)
				{
					flag5 = true;
				}
				else if (imapEvent == ImapEvent.AnnotationChange)
				{
					flag2 = true;
				}
				if (i > 0)
				{
					command.Append(" ");
				}
				imapEvent.Format(engine, command, args, flag);
			}
			command.Append(")");
			if ((flag4 && !flag3) || (!flag4 && flag3))
			{
				throw new InvalidOperationException("If MessageNew or MessageExpunge is specified, both must be specified.");
			}
			if ((flag5 || flag2) && (!flag4 || !flag3))
			{
				throw new InvalidOperationException("If FlagChange and/or AnnotationChange are specified, MessageNew and MessageExpunge must also be specified.");
			}
			notifySelectedNewExpunge = (flag4 || flag3) && MailboxFilter == ImapMailboxFilter.Selected;
		}
		else
		{
			command.Append("NONE");
		}
		command.Append(")");
	}
}
