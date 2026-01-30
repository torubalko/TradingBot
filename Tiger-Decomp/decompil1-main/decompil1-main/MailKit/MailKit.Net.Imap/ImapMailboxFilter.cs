using System;
using System.Collections.Generic;
using System.Text;

namespace MailKit.Net.Imap;

public class ImapMailboxFilter
{
	public class Mailboxes : ImapMailboxFilter
	{
		private readonly ImapFolder[] folders;

		public Mailboxes(IList<IMailFolder> folders)
			: this("MAILBOXES", folders)
		{
		}

		public Mailboxes(params IMailFolder[] folders)
			: this("MAILBOXES", folders)
		{
		}

		internal Mailboxes(string name, IList<IMailFolder> folders)
			: base(name)
		{
			if (folders == null)
			{
				throw new ArgumentNullException("folders");
			}
			if (folders.Count == 0)
			{
				throw new ArgumentException("Must supply at least one folder.", "folders");
			}
			this.folders = new ImapFolder[folders.Count];
			for (int i = 0; i < folders.Count; i++)
			{
				if (!(folders[i] is ImapFolder imapFolder))
				{
					throw new ArgumentException("All folders must be ImapFolders.", "folders");
				}
				this.folders[i] = imapFolder;
			}
		}

		internal override void Format(ImapEngine engine, StringBuilder command, IList<object> args)
		{
			command.Append(base.Name);
			command.Append(' ');
			if (folders.Length == 1)
			{
				command.Append("%F");
				args.Add(folders[0]);
				return;
			}
			command.Append("(");
			for (int i = 0; i < folders.Length; i++)
			{
				if (i > 0)
				{
					command.Append(" ");
				}
				command.Append("%F");
				args.Add(folders[i]);
			}
			command.Append(")");
		}
	}

	public class Subtree : Mailboxes
	{
		public Subtree(IList<IMailFolder> folders)
			: base("SUBTREE", folders)
		{
		}

		public Subtree(params IMailFolder[] folders)
			: base("SUBTREE", folders)
		{
		}
	}

	public static readonly ImapMailboxFilter Selected = new ImapMailboxFilter("SELECTED");

	public static readonly ImapMailboxFilter SelectedDelayed = new ImapMailboxFilter("SELECTED-DELAYED");

	public static readonly ImapMailboxFilter Inboxes = new ImapMailboxFilter("INBOXES");

	public static readonly ImapMailboxFilter Personal = new ImapMailboxFilter("PERSONAL");

	public static readonly ImapMailboxFilter Subscribed = new ImapMailboxFilter("SUBSCRIBED");

	public string Name { get; private set; }

	internal ImapMailboxFilter(string name)
	{
		Name = name;
	}

	internal virtual void Format(ImapEngine engine, StringBuilder command, IList<object> args)
	{
		command.Append(Name);
	}
}
