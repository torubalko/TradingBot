using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MimeKit.IO;
using MimeKit.Utils;

namespace MimeKit;

public class MessagePartial : MimePart
{
	public string Id => base.ContentType.Parameters["id"];

	public int? Number
	{
		get
		{
			string text = base.ContentType.Parameters["number"];
			if (text == null || !int.TryParse(text, out var result))
			{
				return null;
			}
			return result;
		}
	}

	public int? Total
	{
		get
		{
			string text = base.ContentType.Parameters["total"];
			if (text == null || !int.TryParse(text, out var result))
			{
				return null;
			}
			return result;
		}
	}

	public MessagePartial(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MessagePartial(string id, int number, int total)
		: base("message", "partial")
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (number < 1)
		{
			throw new ArgumentOutOfRangeException("number");
		}
		if (total < number)
		{
			throw new ArgumentOutOfRangeException("total");
		}
		base.ContentType.Parameters.Add(new Parameter("id", id));
		base.ContentType.Parameters.Add(new Parameter("number", number.ToString()));
		base.ContentType.Parameters.Add(new Parameter("total", total.ToString()));
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMessagePartial(this);
	}

	private static MimeMessage CloneMessage(MimeMessage message)
	{
		ParserOptions options = message.Headers.Options;
		MimeMessage mimeMessage = new MimeMessage(options);
		foreach (Header header in message.Headers)
		{
			mimeMessage.Headers.Add(header.Clone());
		}
		return mimeMessage;
	}

	public static IEnumerable<MimeMessage> Split(MimeMessage message, int maxSize)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (maxSize < 1)
		{
			throw new ArgumentOutOfRangeException("maxSize");
		}
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		foreach (HeaderId value in Enum.GetValues(typeof(HeaderId)))
		{
			switch (value)
			{
			case HeaderId.ContentAlternative:
			case HeaderId.ContentBase:
			case HeaderId.ContentClass:
			case HeaderId.ContentDescription:
			case HeaderId.ContentDisposition:
			case HeaderId.ContentDuration:
			case HeaderId.ContentFeatures:
			case HeaderId.ContentId:
			case HeaderId.ContentIdentifier:
			case HeaderId.ContentLanguage:
			case HeaderId.ContentLength:
			case HeaderId.ContentLocation:
			case HeaderId.ContentMd5:
			case HeaderId.ContentReturn:
			case HeaderId.ContentTransferEncoding:
			case HeaderId.ContentTranslationType:
			case HeaderId.ContentType:
			case HeaderId.Encrypted:
			case HeaderId.MessageId:
			case HeaderId.MimeVersion:
			case HeaderId.Subject:
				continue;
			}
			formatOptions.HiddenHeaders.Add(value);
		}
		MemoryStream memoryStream = new MemoryStream();
		message.WriteTo(formatOptions, memoryStream);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		if (memoryStream.Length <= maxSize)
		{
			memoryStream.Dispose();
			yield return message;
			yield break;
		}
		List<Stream> streams = new List<Stream>();
		byte[] buffer = memoryStream.GetBuffer();
		long num = 0L;
		while (num < memoryStream.Length)
		{
			long num2 = Math.Min(memoryStream.Length, num + maxSize);
			if (num2 < memoryStream.Length)
			{
				long num3 = num2;
				while (num3 > num + 1 && buffer[num3] != 10)
				{
					num3--;
				}
				if (buffer[num3] == 10)
				{
					num2 = num3 + 1;
				}
			}
			streams.Add(new BoundStream(memoryStream, num, num2, leaveOpen: true));
			num = num2;
		}
		string msgid = message.MessageId ?? MimeUtils.GenerateMessageId();
		int number = 1;
		foreach (Stream item in streams)
		{
			MessagePartial body = new MessagePartial(msgid, number++, streams.Count)
			{
				Content = new MimeContent(item)
			};
			MimeMessage mimeMessage = CloneMessage(message);
			mimeMessage.MessageId = MimeUtils.GenerateMessageId();
			mimeMessage.Body = body;
			yield return mimeMessage;
		}
	}

	private static int PartialCompare(MessagePartial partial1, MessagePartial partial2)
	{
		if (!partial1.Number.HasValue || !partial2.Number.HasValue || partial1.Id != partial2.Id)
		{
			throw new ArgumentException("Partial messages have mismatching identifiers.", "partials");
		}
		return partial1.Number.Value - partial2.Number.Value;
	}

	private static void CombineHeaders(MimeMessage message, MimeMessage joined)
	{
		List<Header> list = new List<Header>();
		int num = 0;
		while (num < joined.Headers.Count)
		{
			Header header = joined.Headers[num];
			HeaderId id = header.Id;
			if (id == HeaderId.Encrypted || (uint)(id - 77) <= 1u || id == HeaderId.Subject)
			{
				list.Add(header);
				header.Offset = null;
				num++;
			}
			else
			{
				joined.Headers.RemoveAt(num);
			}
		}
		num = 0;
		foreach (Header header4 in message.Headers)
		{
			HeaderId id2 = header4.Id;
			if (id2 == HeaderId.Encrypted || (uint)(id2 - 77) <= 1u || id2 == HeaderId.Subject)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Id == header4.Id)
					{
						Header header2 = list[i];
						joined.Headers.Remove(header2);
						joined.Headers.Insert(num++, header2);
						list.RemoveAt(i);
						break;
					}
				}
			}
			else
			{
				Header header3 = header4.Clone();
				header3.Offset = null;
				joined.Headers.Insert(num++, header3);
			}
		}
		if (joined.Body == null)
		{
			return;
		}
		foreach (Header header5 in joined.Body.Headers)
		{
			header5.Offset = null;
		}
	}

	private static MimeMessage Join(ParserOptions options, MimeMessage message, IEnumerable<MessagePartial> partials, bool allowNullMessage)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (!allowNullMessage && message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (partials == null)
		{
			throw new ArgumentNullException("partials");
		}
		List<MessagePartial> list = partials.ToList();
		if (list.Count == 0)
		{
			return null;
		}
		list.Sort(PartialCompare);
		if (!list[list.Count - 1].Total.HasValue)
		{
			throw new ArgumentException("The last partial does not have a Total.", "partials");
		}
		int value = list[list.Count - 1].Total.Value;
		if (list.Count != value)
		{
			throw new ArgumentException("The number of partials provided does not match the expected count.", "partials");
		}
		string id = list[0].Id;
		using ChainedStream chainedStream = new ChainedStream();
		for (int i = 0; i < list.Count; i++)
		{
			int value2 = list[i].Number.Value;
			if (value2 != i + 1)
			{
				throw new ArgumentException("One or more partials is missing.", "partials");
			}
			IMimeContent content = list[i].Content;
			chainedStream.Add(content.Open());
		}
		MimeParser mimeParser = new MimeParser(options, chainedStream);
		MimeMessage mimeMessage = mimeParser.ParseMessage();
		if (message != null)
		{
			CombineHeaders(message, mimeMessage);
		}
		return mimeMessage;
	}

	public static MimeMessage Join(ParserOptions options, MimeMessage message, IEnumerable<MessagePartial> partials)
	{
		return Join(options, message, partials, allowNullMessage: false);
	}

	public static MimeMessage Join(MimeMessage message, IEnumerable<MessagePartial> partials)
	{
		return Join(ParserOptions.Default, message, partials, allowNullMessage: false);
	}

	[Obsolete("Use MessagePartial.Join (ParserOptions, MimeMessage, IEnumerable<MessagePartial>) instead.")]
	public static MimeMessage Join(ParserOptions options, IEnumerable<MessagePartial> partials)
	{
		return Join(options, null, partials, allowNullMessage: true);
	}

	[Obsolete("Use MessagePartial.Join (MimeMessage, IEnumerable<MessagePartial>) instead.")]
	public static MimeMessage Join(IEnumerable<MessagePartial> partials)
	{
		return Join(ParserOptions.Default, null, partials, allowNullMessage: true);
	}
}
