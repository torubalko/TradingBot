using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Search;
using MimeKit;

namespace MailKit;

public static class MessageSorter
{
	private class MessageComparer<T> : IComparer<T> where T : IMessageSummary
	{
		private readonly IList<OrderBy> orderBy;

		public MessageComparer(IList<OrderBy> orderBy)
		{
			this.orderBy = orderBy;
		}

		private static int CompareDisplayNames(InternetAddressList list1, InternetAddressList list2)
		{
			IEnumerator<MailboxAddress> enumerator = list1.Mailboxes.GetEnumerator();
			IEnumerator<MailboxAddress> enumerator2 = list2.Mailboxes.GetEnumerator();
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator2.MoveNext();
			while (flag && flag2)
			{
				string strA = enumerator.Current.Name ?? string.Empty;
				string strB = enumerator2.Current.Name ?? string.Empty;
				int result;
				if ((result = string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase)) != 0)
				{
					return result;
				}
				flag = enumerator.MoveNext();
				flag2 = enumerator2.MoveNext();
			}
			if (!flag)
			{
				if (!flag2)
				{
					return 0;
				}
				return -1;
			}
			return 1;
		}

		private static int CompareMailboxAddresses(InternetAddressList list1, InternetAddressList list2)
		{
			IEnumerator<MailboxAddress> enumerator = list1.Mailboxes.GetEnumerator();
			IEnumerator<MailboxAddress> enumerator2 = list2.Mailboxes.GetEnumerator();
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator2.MoveNext();
			while (flag && flag2)
			{
				int result;
				if ((result = string.Compare(enumerator.Current.Address, enumerator2.Current.Address, StringComparison.OrdinalIgnoreCase)) != 0)
				{
					return result;
				}
				flag = enumerator.MoveNext();
				flag2 = enumerator2.MoveNext();
			}
			if (!flag)
			{
				if (!flag2)
				{
					return 0;
				}
				return -1;
			}
			return 1;
		}

		public int Compare(T x, T y)
		{
			int num = 0;
			for (int i = 0; i < orderBy.Count; i++)
			{
				switch (orderBy[i].Type)
				{
				case OrderByType.Annotation:
				{
					OrderByAnnotation annotation = (OrderByAnnotation)orderBy[i];
					Annotation annotation2 = x.Annotations?.FirstOrDefault((Annotation a) => a.Entry == annotation.Entry);
					Annotation annotation3 = y.Annotations?.FirstOrDefault((Annotation a) => a.Entry == annotation.Entry);
					string strA2 = annotation2?.Properties[annotation.Attribute] ?? string.Empty;
					string strB2 = annotation3?.Properties[annotation.Attribute] ?? string.Empty;
					num = string.Compare(strA2, strB2, StringComparison.OrdinalIgnoreCase);
					break;
				}
				case OrderByType.Arrival:
					num = x.Index.CompareTo(y.Index);
					break;
				case OrderByType.Cc:
					num = CompareMailboxAddresses(x.Envelope.Cc, y.Envelope.Cc);
					break;
				case OrderByType.Date:
					num = x.Date.CompareTo(y.Date);
					break;
				case OrderByType.DisplayFrom:
					num = CompareDisplayNames(x.Envelope.From, y.Envelope.From);
					break;
				case OrderByType.From:
					num = CompareMailboxAddresses(x.Envelope.From, y.Envelope.From);
					break;
				case OrderByType.ModSeq:
				{
					ulong valueOrDefault3 = x.ModSeq.GetValueOrDefault();
					ulong valueOrDefault4 = y.ModSeq.GetValueOrDefault();
					num = valueOrDefault3.CompareTo(valueOrDefault4);
					break;
				}
				case OrderByType.Size:
				{
					uint valueOrDefault = x.Size.GetValueOrDefault();
					uint valueOrDefault2 = y.Size.GetValueOrDefault();
					num = valueOrDefault.CompareTo(valueOrDefault2);
					break;
				}
				case OrderByType.Subject:
				{
					string strA = x.Envelope.Subject ?? string.Empty;
					string strB = y.Envelope.Subject ?? string.Empty;
					num = string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase);
					break;
				}
				case OrderByType.DisplayTo:
					num = CompareDisplayNames(x.Envelope.To, y.Envelope.To);
					break;
				case OrderByType.To:
					num = CompareMailboxAddresses(x.Envelope.To, y.Envelope.To);
					break;
				}
				if (num != 0)
				{
					if (orderBy[i].Order != SortOrder.Descending)
					{
						return num;
					}
					return num * -1;
				}
			}
			return num;
		}
	}

	private static MessageSummaryItems GetMessageSummaryItems(IList<OrderBy> orderBy)
	{
		MessageSummaryItems messageSummaryItems = MessageSummaryItems.None;
		for (int i = 0; i < orderBy.Count; i++)
		{
			switch (orderBy[i].Type)
			{
			case OrderByType.Annotation:
				messageSummaryItems |= MessageSummaryItems.Annotations;
				break;
			case OrderByType.Cc:
			case OrderByType.Date:
			case OrderByType.DisplayFrom:
			case OrderByType.DisplayTo:
			case OrderByType.From:
			case OrderByType.Subject:
			case OrderByType.To:
				messageSummaryItems |= MessageSummaryItems.Envelope;
				break;
			case OrderByType.ModSeq:
				messageSummaryItems |= MessageSummaryItems.ModSeq;
				break;
			case OrderByType.Size:
				messageSummaryItems |= MessageSummaryItems.Size;
				break;
			}
		}
		return messageSummaryItems;
	}

	public static IList<T> Sort<T>(this IEnumerable<T> messages, IList<OrderBy> orderBy) where T : IMessageSummary
	{
		if (messages == null)
		{
			throw new ArgumentNullException("messages");
		}
		if (orderBy == null)
		{
			throw new ArgumentNullException("orderBy");
		}
		if (orderBy.Count == 0)
		{
			throw new ArgumentException("No sort order provided.", "orderBy");
		}
		MessageSummaryItems messageSummaryItems = GetMessageSummaryItems(orderBy);
		List<T> list = new List<T>();
		foreach (T message in messages)
		{
			if ((message.Fields & messageSummaryItems) != messageSummaryItems)
			{
				throw new ArgumentException("One or more messages is missing information needed for sorting.", "messages");
			}
			list.Add(message);
		}
		if (list.Count < 2)
		{
			return list;
		}
		MessageComparer<T> comparer = new MessageComparer<T>(orderBy);
		list.Sort(comparer);
		return list;
	}

	public static void Sort<T>(this List<T> messages, IList<OrderBy> orderBy) where T : IMessageSummary
	{
		if (messages == null)
		{
			throw new ArgumentNullException("messages");
		}
		if (orderBy == null)
		{
			throw new ArgumentNullException("orderBy");
		}
		if (orderBy.Count == 0)
		{
			throw new ArgumentException("No sort order provided.", "orderBy");
		}
		MessageSummaryItems messageSummaryItems = GetMessageSummaryItems(orderBy);
		for (int i = 0; i < messages.Count; i++)
		{
			if ((messages[i].Fields & messageSummaryItems) != messageSummaryItems)
			{
				throw new ArgumentException("One or more messages is missing information needed for sorting.", "messages");
			}
		}
		if (messages.Count >= 2)
		{
			MessageComparer<T> comparer = new MessageComparer<T>(orderBy);
			messages.Sort(comparer);
		}
	}
}
