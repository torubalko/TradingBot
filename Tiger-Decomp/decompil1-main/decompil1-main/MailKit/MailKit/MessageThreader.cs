using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Search;
using MimeKit;
using MimeKit.Utils;

namespace MailKit;

public static class MessageThreader
{
	internal class ThreadableNode : IMessageSummary
	{
		public readonly List<ThreadableNode> Children = new List<ThreadableNode>();

		public IMessageSummary Message;

		public ThreadableNode Parent;

		public bool HasParent => Parent != null;

		public bool HasChildren => Children.Count > 0;

		public IMailFolder Folder => null;

		public MessageSummaryItems Fields => MessageSummaryItems.Envelope | MessageSummaryItems.Size | MessageSummaryItems.ModSeq | MessageSummaryItems.UniqueId;

		public BodyPart Body => null;

		public BodyPartText TextBody => null;

		public BodyPartText HtmlBody => null;

		public IEnumerable<BodyPartBasic> BodyParts => null;

		public IEnumerable<BodyPartBasic> Attachments => null;

		public string PreviewText => null;

		public Envelope Envelope
		{
			get
			{
				if (Message == null)
				{
					return Children[0].Envelope;
				}
				return Message.Envelope;
			}
		}

		public string NormalizedSubject
		{
			get
			{
				if (Message == null)
				{
					return Children[0].NormalizedSubject;
				}
				return Message.NormalizedSubject;
			}
		}

		public DateTimeOffset Date
		{
			get
			{
				if (Message == null)
				{
					return Children[0].Date;
				}
				return Message.Date;
			}
		}

		public bool IsReply
		{
			get
			{
				if (Message != null)
				{
					return Message.IsReply;
				}
				return false;
			}
		}

		public MessageFlags? Flags => null;

		public HashSet<string> Keywords => null;

		[Obsolete]
		public HashSet<string> UserFlags => null;

		public IList<Annotation> Annotations
		{
			get
			{
				if (Message == null)
				{
					return Children[0].Annotations;
				}
				return Message.Annotations;
			}
		}

		public HeaderList Headers => null;

		public DateTimeOffset? InternalDate => null;

		public DateTimeOffset? SaveDate => null;

		public uint? Size
		{
			get
			{
				if (Message == null)
				{
					return Children[0].Size;
				}
				return Message.Size;
			}
		}

		public ulong? ModSeq
		{
			get
			{
				if (Message == null)
				{
					return Children[0].ModSeq;
				}
				return Message.ModSeq;
			}
		}

		public MessageIdList References
		{
			get
			{
				if (Message == null)
				{
					return Children[0].References;
				}
				return Message.References;
			}
		}

		public string EmailId => null;

		[Obsolete]
		public string Id => null;

		public string ThreadId => null;

		public UniqueId UniqueId
		{
			get
			{
				if (Message == null)
				{
					return Children[0].UniqueId;
				}
				return Message.UniqueId;
			}
		}

		public int Index
		{
			get
			{
				if (Message == null)
				{
					return Children[0].Index;
				}
				return Message.Index;
			}
		}

		public ulong? GMailMessageId => null;

		public ulong? GMailThreadId => null;

		public IList<string> GMailLabels => null;

		public ThreadableNode(IMessageSummary message)
		{
			Message = message;
		}
	}

	private static IDictionary<string, ThreadableNode> CreateIdTable(IEnumerable<IMessageSummary> messages)
	{
		Dictionary<string, ThreadableNode> dictionary = new Dictionary<string, ThreadableNode>(StringComparer.OrdinalIgnoreCase);
		foreach (IMessageSummary message in messages)
		{
			if (message.Envelope == null)
			{
				throw new ArgumentException("One or more messages is missing information needed for threading.", "messages");
			}
			string text = message.Envelope.MessageId;
			if (string.IsNullOrEmpty(text))
			{
				text = MimeUtils.GenerateMessageId();
			}
			if (dictionary.TryGetValue(text, out var value))
			{
				if (value.Message == null)
				{
					value.Message = message;
				}
				else
				{
					text = MimeUtils.GenerateMessageId();
					value = null;
				}
			}
			if (value == null)
			{
				value = new ThreadableNode(message);
				dictionary.Add(text, value);
			}
			ThreadableNode threadableNode = null;
			foreach (string reference in message.References)
			{
				if (!dictionary.TryGetValue(reference, out var value2))
				{
					value2 = new ThreadableNode(null);
					dictionary.Add(reference, value2);
				}
				if (threadableNode != null && value2.Parent == null && threadableNode != value2 && !threadableNode.Children.Contains(value2))
				{
					threadableNode.Children.Add(value2);
					value2.Parent = threadableNode;
				}
				threadableNode = value2;
			}
			if (threadableNode != null && (threadableNode == value || value.Children.Contains(threadableNode)))
			{
				threadableNode = null;
			}
			if (value.HasParent)
			{
				value.Parent.Children.Remove(value);
				value.Parent = null;
			}
			if (threadableNode != null)
			{
				threadableNode.Children.Add(value);
				value.Parent = threadableNode;
			}
		}
		return dictionary;
	}

	private static ThreadableNode CreateRoot(IDictionary<string, ThreadableNode> ids)
	{
		ThreadableNode threadableNode = new ThreadableNode(null);
		foreach (ThreadableNode value in ids.Values)
		{
			if (value.Parent == null)
			{
				threadableNode.Children.Add(value);
			}
		}
		return threadableNode;
	}

	private static void PruneEmptyContainers(ThreadableNode root)
	{
		for (int i = 0; i < root.Children.Count; i++)
		{
			ThreadableNode threadableNode = root.Children[i];
			if (threadableNode.Message == null && threadableNode.Children.Count == 0)
			{
				root.Children.RemoveAt(i);
				i--;
			}
			else if (threadableNode.Message == null && threadableNode.HasChildren && (threadableNode.HasParent || threadableNode.Children.Count == 1))
			{
				root.Children.RemoveAt(i);
				for (int j = 0; j < threadableNode.Children.Count; j++)
				{
					threadableNode.Children[j].Parent = threadableNode.Parent;
					root.Children.Add(threadableNode.Children[j]);
				}
				threadableNode.Children.Clear();
				i--;
			}
			else if (threadableNode.HasChildren)
			{
				PruneEmptyContainers(threadableNode);
			}
		}
	}

	private static void GroupBySubject(ThreadableNode root)
	{
		Dictionary<string, ThreadableNode> dictionary = new Dictionary<string, ThreadableNode>(StringComparer.OrdinalIgnoreCase);
		int num = 0;
		for (int i = 0; i < root.Children.Count; i++)
		{
			ThreadableNode threadableNode = root.Children[i];
			string normalizedSubject = threadableNode.NormalizedSubject;
			if (!string.IsNullOrEmpty(normalizedSubject) && (!dictionary.TryGetValue(normalizedSubject, out var value) || (threadableNode.Message == null && value.Message != null) || (value.Message != null && value.Message.IsReply && threadableNode.Message != null && !threadableNode.Message.IsReply)))
			{
				dictionary[normalizedSubject] = threadableNode;
				num++;
			}
		}
		if (num == 0)
		{
			return;
		}
		for (int j = 0; j < root.Children.Count; j++)
		{
			ThreadableNode threadableNode2 = root.Children[j];
			string normalizedSubject2 = threadableNode2.NormalizedSubject;
			if (string.IsNullOrEmpty(normalizedSubject2))
			{
				continue;
			}
			ThreadableNode value = dictionary[normalizedSubject2];
			if (value != threadableNode2)
			{
				root.Children.RemoveAt(j--);
				if (value.Message == null && threadableNode2.Message == null)
				{
					value.Children.AddRange(threadableNode2.Children);
					continue;
				}
				if (value.Message == null && threadableNode2.Message != null)
				{
					value.Children.Add(threadableNode2);
					continue;
				}
				if (threadableNode2.Message.IsReply && !value.Message.IsReply)
				{
					value.Children.Add(threadableNode2);
					continue;
				}
				ThreadableNode threadableNode3 = value;
				value = new ThreadableNode(threadableNode3.Message);
				value.Children.AddRange(threadableNode3.Children);
				threadableNode3.Children.Clear();
				threadableNode3.Message = null;
				threadableNode3.Children.Add(value);
				threadableNode3.Children.Add(threadableNode2);
			}
		}
	}

	private static void GetThreads(ThreadableNode root, IList<MessageThread> threads, IList<OrderBy> orderBy)
	{
		root.Children.Sort(orderBy);
		for (int i = 0; i < root.Children.Count; i++)
		{
			IMessageSummary message = root.Children[i].Message;
			MessageThread messageThread = new MessageThread(message);
			GetThreads(root.Children[i], messageThread.Children, orderBy);
			threads.Add(messageThread);
		}
	}

	private static IList<MessageThread> ThreadByReferences(IEnumerable<IMessageSummary> messages, IList<OrderBy> orderBy)
	{
		List<MessageThread> list = new List<MessageThread>();
		IDictionary<string, ThreadableNode> ids = CreateIdTable(messages);
		ThreadableNode root = CreateRoot(ids);
		PruneEmptyContainers(root);
		GroupBySubject(root);
		GetThreads(root, list, orderBy);
		return list;
	}

	private static IList<MessageThread> ThreadBySubject(IEnumerable<IMessageSummary> messages, IList<OrderBy> orderBy)
	{
		List<MessageThread> list = new List<MessageThread>();
		ThreadableNode threadableNode = new ThreadableNode(null);
		foreach (IMessageSummary message in messages)
		{
			if (message.Envelope == null)
			{
				throw new ArgumentException("One or more messages is missing information needed for threading.", "messages");
			}
			ThreadableNode item = new ThreadableNode(message);
			threadableNode.Children.Add(item);
		}
		GroupBySubject(threadableNode);
		GetThreads(threadableNode, list, orderBy);
		return list;
	}

	public static IList<MessageThread> Thread(this IEnumerable<IMessageSummary> messages, ThreadingAlgorithm algorithm)
	{
		return messages.Thread(algorithm, new OrderBy[1] { OrderBy.Arrival });
	}

	public static IList<MessageThread> Thread(this IEnumerable<IMessageSummary> messages, ThreadingAlgorithm algorithm, IList<OrderBy> orderBy)
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
		return algorithm switch
		{
			ThreadingAlgorithm.OrderedSubject => ThreadBySubject(messages, orderBy), 
			ThreadingAlgorithm.References => ThreadByReferences(messages, orderBy), 
			_ => throw new ArgumentOutOfRangeException("algorithm"), 
		};
	}

	private static bool IsForward(string subject, int index)
	{
		if ((subject[index] == 'F' || subject[index] == 'f') && (subject[index + 1] == 'W' || subject[index + 1] == 'w') && (subject[index + 2] == 'D' || subject[index + 2] == 'd'))
		{
			return subject[index + 3] == ':';
		}
		return false;
	}

	private static bool IsReply(string subject, int index)
	{
		if (subject[index] == 'R' || subject[index] == 'r')
		{
			if (subject[index + 1] != 'E')
			{
				return subject[index + 1] == 'e';
			}
			return true;
		}
		return false;
	}

	private static void SkipWhiteSpace(string subject, ref int index)
	{
		while (index < subject.Length && char.IsWhiteSpace(subject[index]))
		{
			index++;
		}
	}

	private static bool IsMailingListName(char c)
	{
		if (c != '-' && c != '_')
		{
			return char.IsLetterOrDigit(c);
		}
		return true;
	}

	private static void SkipMailingListName(string subject, ref int index)
	{
		while (index < subject.Length && IsMailingListName(subject[index]))
		{
			index++;
		}
	}

	private static bool SkipDigits(string subject, ref int index, out int value)
	{
		int num = index;
		value = 0;
		while (index < subject.Length && char.IsDigit(subject[index]))
		{
			value = value * 10 + (subject[index] - 48);
			index++;
		}
		return index > num;
	}

	public static string GetThreadableSubject(string subject, out int replyDepth)
	{
		if (subject == null)
		{
			throw new ArgumentNullException("subject");
		}
		replyDepth = 0;
		int num = subject.Length;
		int index = 0;
		while (true)
		{
			SkipWhiteSpace(subject, ref index);
			int num2 = index;
			int num3;
			if ((num3 = num - num2) < 3)
			{
				break;
			}
			if (num3 >= 4 && IsForward(subject, num2))
			{
				index = num2 + 4;
				replyDepth++;
			}
			else if (IsReply(subject, num2))
			{
				if (subject[num2 + 2] == ':')
				{
					index = num2 + 3;
					replyDepth++;
					continue;
				}
				if (subject[num2 + 2] != '[' && subject[num2 + 2] != '(')
				{
					break;
				}
				char c = ((subject[num2 + 2] == '[') ? ']' : ')');
				num2 += 3;
				if (!SkipDigits(subject, ref num2, out var value) || num - num2 < 2 || subject[num2] != c || subject[num2 + 1] != ':')
				{
					break;
				}
				index = num2 + 2;
				replyDepth += value;
			}
			else
			{
				if (subject[num2] != '[' || !char.IsLetterOrDigit(subject[num2 + 1]))
				{
					break;
				}
				num2 += 2;
				SkipMailingListName(subject, ref num2);
				if (num - num2 < 1 || subject[num2] != ']')
				{
					break;
				}
				index = num2 + 1;
			}
		}
		while (num > 0 && char.IsWhiteSpace(subject[num - 1]))
		{
			num--;
		}
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		for (int i = index; i < num; i++)
		{
			if (char.IsWhiteSpace(subject[i]))
			{
				if (!flag)
				{
					stringBuilder.Append(' ');
					flag = true;
				}
			}
			else
			{
				stringBuilder.Append(subject[i]);
				flag = false;
			}
		}
		string text = stringBuilder.ToString();
		if (text.Equals("(no subject)", StringComparison.OrdinalIgnoreCase))
		{
			text = string.Empty;
		}
		return text;
	}
}
