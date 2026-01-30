using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MimeKit;
using MimeKit.Utils;

namespace MailKit;

public class Envelope
{
	public InternetAddressList From { get; private set; }

	public InternetAddressList Sender { get; private set; }

	public InternetAddressList ReplyTo { get; private set; }

	public InternetAddressList To { get; private set; }

	public InternetAddressList Cc { get; private set; }

	public InternetAddressList Bcc { get; private set; }

	public string InReplyTo { get; set; }

	public DateTimeOffset? Date { get; set; }

	public string MessageId { get; set; }

	public string Subject { get; set; }

	public Envelope()
	{
		From = new InternetAddressList();
		Sender = new InternetAddressList();
		ReplyTo = new InternetAddressList();
		To = new InternetAddressList();
		Cc = new InternetAddressList();
		Bcc = new InternetAddressList();
	}

	private static void EncodeMailbox(StringBuilder builder, MailboxAddress mailbox)
	{
		builder.Append('(');
		if (mailbox.Name != null)
		{
			MimeUtils.AppendQuoted(builder, mailbox.Name);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (mailbox.Route.Count != 0)
		{
			MimeUtils.AppendQuoted(builder, mailbox.Route.ToString());
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		int num = mailbox.Address.LastIndexOf('@');
		if (num >= 0)
		{
			string text = mailbox.Address.Substring(num + 1);
			string text2 = mailbox.Address.Substring(0, num);
			MimeUtils.AppendQuoted(builder, text2);
			builder.Append(' ');
			MimeUtils.AppendQuoted(builder, text);
		}
		else
		{
			MimeUtils.AppendQuoted(builder, mailbox.Address);
			builder.Append(" \"localhost\"");
		}
		builder.Append(')');
	}

	private static void EncodeInternetAddressListAddresses(StringBuilder builder, InternetAddressList addresses)
	{
		foreach (InternetAddress address in addresses)
		{
			MailboxAddress mailboxAddress = address as MailboxAddress;
			GroupAddress groupAddress = address as GroupAddress;
			if (mailboxAddress != null)
			{
				EncodeMailbox(builder, mailboxAddress);
			}
			else if (groupAddress != null)
			{
				EncodeGroup(builder, groupAddress);
			}
		}
	}

	private static void EncodeGroup(StringBuilder builder, GroupAddress group)
	{
		builder.Append("(NIL NIL ");
		MimeUtils.AppendQuoted(builder, group.Name);
		builder.Append(" NIL)");
		EncodeInternetAddressListAddresses(builder, group.Members);
		builder.Append("(NIL NIL NIL NIL)");
	}

	private static void EncodeAddressList(StringBuilder builder, InternetAddressList list)
	{
		builder.Append('(');
		EncodeInternetAddressListAddresses(builder, list);
		builder.Append(')');
	}

	internal void Encode(StringBuilder builder)
	{
		builder.Append('(');
		if (Date.HasValue)
		{
			builder.AppendFormat("\"{0}\" ", DateUtils.FormatDate(Date.Value));
		}
		else
		{
			builder.Append("NIL ");
		}
		if (Subject != null)
		{
			MimeUtils.AppendQuoted(builder, Subject);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (From.Count > 0)
		{
			EncodeAddressList(builder, From);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (Sender.Count > 0)
		{
			EncodeAddressList(builder, Sender);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (ReplyTo.Count > 0)
		{
			EncodeAddressList(builder, ReplyTo);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (To.Count > 0)
		{
			EncodeAddressList(builder, To);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (Cc.Count > 0)
		{
			EncodeAddressList(builder, Cc);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (Bcc.Count > 0)
		{
			EncodeAddressList(builder, Bcc);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (InReplyTo != null)
		{
			string text = ((InReplyTo.Length <= 1 || InReplyTo[0] == '<' || InReplyTo[InReplyTo.Length - 1] == '>') ? InReplyTo : ("<" + InReplyTo + ">"));
			MimeUtils.AppendQuoted(builder, text);
			builder.Append(' ');
		}
		else
		{
			builder.Append("NIL ");
		}
		if (MessageId != null)
		{
			string text2 = ((MessageId.Length <= 1 || MessageId[0] == '<' || MessageId[MessageId.Length - 1] == '>') ? MessageId : ("<" + MessageId + ">"));
			MimeUtils.AppendQuoted(builder, text2);
		}
		else
		{
			builder.Append("NIL");
		}
		builder.Append(')');
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Encode(stringBuilder);
		return stringBuilder.ToString();
	}

	private static bool TryParse(string text, ref int index, out string nstring)
	{
		nstring = null;
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		if (index >= text.Length)
		{
			return false;
		}
		if (text[index] != '"')
		{
			if (index + 3 <= text.Length && text.Substring(index, 3) == "NIL")
			{
				index += 3;
				return true;
			}
			return false;
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		index++;
		while (index < text.Length && (text[index] != '"' || flag))
		{
			if (flag || text[index] != '\\')
			{
				stringBuilder.Append(text[index]);
				flag = false;
			}
			else
			{
				flag = true;
			}
			index++;
		}
		if (index >= text.Length)
		{
			return false;
		}
		nstring = stringBuilder.ToString();
		index++;
		return true;
	}

	private static bool TryParse(string text, ref int index, out InternetAddress addr)
	{
		addr = null;
		if (text[index] != '(')
		{
			return false;
		}
		index++;
		if (!TryParse(text, ref index, out string nstring))
		{
			return false;
		}
		if (!TryParse(text, ref index, out string nstring2))
		{
			return false;
		}
		if (!TryParse(text, ref index, out string nstring3))
		{
			return false;
		}
		if (!TryParse(text, ref index, out string nstring4))
		{
			return false;
		}
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		index++;
		if (nstring4 != null)
		{
			string address = nstring3 + "@" + nstring4;
			if (nstring2 != null && DomainList.TryParse(nstring2, out var route))
			{
				addr = new MailboxAddress(nstring, route, address);
			}
			else
			{
				addr = new MailboxAddress(nstring, address);
			}
		}
		else if (nstring3 != null)
		{
			addr = new GroupAddress(nstring3);
		}
		return true;
	}

	private static bool TryParse(string text, ref int index, out InternetAddressList list)
	{
		list = null;
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		if (index >= text.Length)
		{
			return false;
		}
		if (text[index] != '(')
		{
			if (index + 3 <= text.Length && text.Substring(index, 3) == "NIL")
			{
				list = new InternetAddressList();
				index += 3;
				return true;
			}
			return false;
		}
		index++;
		if (index >= text.Length)
		{
			return false;
		}
		list = new InternetAddressList();
		List<InternetAddressList> list2 = new List<InternetAddressList>();
		int num = 0;
		list2.Add(list);
		while (text[index] != ')')
		{
			if (!TryParse(text, ref index, out InternetAddress addr))
			{
				return false;
			}
			if (addr != null)
			{
				GroupAddress groupAddress = addr as GroupAddress;
				list2[num].Add(addr);
				if (groupAddress != null)
				{
					list2.Add(groupAddress.Members);
					num++;
				}
			}
			else if (num > 0)
			{
				list2.RemoveAt(num);
				num--;
			}
			while (index < text.Length && text[index] == ' ')
			{
				index++;
			}
			if (index >= text.Length)
			{
				break;
			}
		}
		if (index >= text.Length)
		{
			return false;
		}
		index++;
		return true;
	}

	internal static bool TryParse(string text, ref int index, out Envelope envelope)
	{
		DateTimeOffset? date = null;
		envelope = null;
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		if (index >= text.Length || text[index] != '(')
		{
			if (index + 3 <= text.Length && text.Substring(index, 3) == "NIL")
			{
				index += 3;
				return true;
			}
			return false;
		}
		index++;
		if (!TryParse(text, ref index, out string nstring))
		{
			return false;
		}
		if (nstring != null)
		{
			if (!DateUtils.TryParse(nstring, out var date2))
			{
				return false;
			}
			date = date2;
		}
		if (!TryParse(text, ref index, out string nstring2))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list2))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list3))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list4))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list5))
		{
			return false;
		}
		if (!TryParse(text, ref index, out InternetAddressList list6))
		{
			return false;
		}
		if (!TryParse(text, ref index, out string nstring3))
		{
			return false;
		}
		if (!TryParse(text, ref index, out string nstring4))
		{
			return false;
		}
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		index++;
		envelope = new Envelope
		{
			Date = date,
			Subject = nstring2,
			From = list,
			Sender = list2,
			ReplyTo = list3,
			To = list4,
			Cc = list5,
			Bcc = list6,
			InReplyTo = ((nstring3 != null) ? (MimeUtils.EnumerateReferences(nstring3).FirstOrDefault() ?? nstring3) : null),
			MessageId = ((nstring4 != null) ? (MimeUtils.EnumerateReferences(nstring4).FirstOrDefault() ?? nstring4) : null)
		};
		return true;
	}

	public static bool TryParse(string text, out Envelope envelope)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		int index = 0;
		if (TryParse(text, ref index, out envelope))
		{
			return index == text.Length;
		}
		return false;
	}
}
