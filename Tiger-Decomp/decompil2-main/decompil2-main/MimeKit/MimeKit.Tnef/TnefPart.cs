using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MimeKit.IO;
using MimeKit.IO.Filters;
using MimeKit.Text;
using MimeKit.Utils;

namespace MimeKit.Tnef;

public class TnefPart : MimePart
{
	private class EmailAddress
	{
		public string AddrType = "SMTP";

		public string SearchKey;

		public string Name;

		public string Addr;

		private bool CanUseSearchKey
		{
			get
			{
				if (SearchKey != null && SearchKey.Equals("SMTP", StringComparison.OrdinalIgnoreCase) && SearchKey.Length > AddrType.Length && SearchKey.StartsWith(AddrType, StringComparison.Ordinal))
				{
					return SearchKey[AddrType.Length] == ':';
				}
				return false;
			}
		}

		public bool TryGetMailboxAddress(out MailboxAddress mailbox)
		{
			string text = ((!string.IsNullOrEmpty(Addr) || !CanUseSearchKey) ? Addr : SearchKey.Substring(AddrType.Length + 1));
			if (string.IsNullOrEmpty(text) || !MailboxAddress.TryParse(text, out mailbox))
			{
				mailbox = null;
				return false;
			}
			mailbox.Name = Name;
			return true;
		}
	}

	public TnefPart(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public TnefPart()
		: base("application", "vnd.ms-tnef")
	{
		base.FileName = "winmail.dat";
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitTnefPart(this);
	}

	private static void ExtractRecipientTable(TnefReader reader, MimeMessage message)
	{
		TnefPropertyReader tnefPropertyReader = reader.TnefPropertyReader;
		while (tnefPropertyReader.ReadNextRow())
		{
			string text = null;
			string text2 = null;
			string text3 = string.Empty;
			InternetAddressList internetAddressList = null;
			string text4 = null;
			while (tnefPropertyReader.ReadNextProperty())
			{
				switch (tnefPropertyReader.PropertyTag.Id)
				{
				case TnefPropertyId.RecipientType:
					switch (tnefPropertyReader.ReadValueAsInt32())
					{
					case 1:
						internetAddressList = message.To;
						break;
					case 2:
						internetAddressList = message.Cc;
						break;
					case 3:
						internetAddressList = message.Bcc;
						break;
					}
					break;
				case TnefPropertyId.TransmitableDisplayName:
					text = tnefPropertyReader.ReadValueAsString();
					break;
				case TnefPropertyId.RecipientDisplayName:
					text2 = tnefPropertyReader.ReadValueAsString();
					break;
				case TnefPropertyId.DisplayName:
					text3 = tnefPropertyReader.ReadValueAsString();
					break;
				case TnefPropertyId.EmailAddress:
					if (string.IsNullOrEmpty(text4))
					{
						text4 = tnefPropertyReader.ReadValueAsString();
					}
					break;
				case TnefPropertyId.SmtpAddress:
					text4 = tnefPropertyReader.ReadValueAsString();
					break;
				}
			}
			if (internetAddressList != null && !string.IsNullOrEmpty(text4))
			{
				string name = text2 ?? text ?? text3;
				internetAddressList.Add(new MailboxAddress(name, text4));
			}
		}
	}

	private static string GetHtmlBody(TnefPropertyReader prop, int codepage, out Encoding encoding)
	{
		byte[] array = prop.ReadValueAsBytes();
		int num = array.Length;
		while (num > 0 && array[num - 1] == 0)
		{
			num--;
		}
		using MemoryStream stream = new MemoryStream(array, 0, num);
		using StreamReader reader = new StreamReader(stream, CharsetUtils.Latin1, detectEncodingFromByteOrderMarks: true);
		HtmlTokenizer htmlTokenizer = new HtmlTokenizer(reader);
		HtmlToken token;
		while (htmlTokenizer.ReadNextToken(out token))
		{
			if (token.Kind != HtmlTokenKind.Tag)
			{
				continue;
			}
			HtmlTagToken htmlTagToken = (HtmlTagToken)token;
			if (htmlTagToken.Id == HtmlTagId.Body || (htmlTagToken.Id == HtmlTagId.Head && htmlTagToken.IsEndTag))
			{
				break;
			}
			if (htmlTagToken.Id != HtmlTagId.Meta || htmlTagToken.IsEndTag)
			{
				continue;
			}
			string text = null;
			string text2 = null;
			for (int i = 0; i < htmlTagToken.Attributes.Count; i++)
			{
				switch (htmlTagToken.Attributes[i].Id)
				{
				case HtmlAttributeId.HttpEquiv:
					text = text ?? htmlTagToken.Attributes[i].Value;
					break;
				case HtmlAttributeId.Content:
					text2 = text2 ?? htmlTagToken.Attributes[i].Value;
					break;
				}
			}
			if (text == null || !text.Equals("Content-Type", StringComparison.OrdinalIgnoreCase))
			{
				continue;
			}
			if (ContentType.TryParse(text2, out var type) && !string.IsNullOrEmpty(type.Charset))
			{
				try
				{
					encoding = Encoding.GetEncoding(type.Charset, EncoderFallback.ExceptionFallback, DecoderFallback.ExceptionFallback);
					return encoding.GetString(array, 0, num);
				}
				catch
				{
				}
			}
			break;
		}
		encoding = Encoding.GetEncoding(codepage);
		return encoding.GetString(array, 0, num);
	}

	private static void ExtractMapiProperties(TnefReader reader, MimeMessage message, BodyBuilder builder)
	{
		TnefPropertyReader tnefPropertyReader = reader.TnefPropertyReader;
		EmailAddress emailAddress = new EmailAddress();
		EmailAddress emailAddress2 = new EmailAddress();
		string text = null;
		string text2 = null;
		bool flag = false;
		while (tnefPropertyReader.ReadNextProperty())
		{
			switch (tnefPropertyReader.PropertyTag.Id)
			{
			case TnefPropertyId.InternetMessageId:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					message.MessageId = tnefPropertyReader.ReadValueAsString();
					flag = true;
				}
				break;
			case TnefPropertyId.TnefCorrelationKey:
				if ((tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Binary) && !flag)
				{
					string text4 = tnefPropertyReader.ReadValueAsString();
					if (text4.Length > 5 && text4[0] == '<' && text4[text4.Length - 1] == '>' && text4.IndexOf('@') != -1)
					{
						message.MessageId = text4;
					}
				}
				break;
			case TnefPropertyId.Subject:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					message.Subject = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.SubjectPrefix:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					text2 = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.NormalizedSubject:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					text = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.SenderName:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress2.Name = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.SenderEmailAddress:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress2.Addr = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.SenderSearchKey:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Binary)
				{
					emailAddress2.SearchKey = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.SenderAddrtype:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress2.AddrType = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.ReceivedByName:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress.Name = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.ReceivedByEmailAddress:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress.Addr = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.ReceivedBySearchKey:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Binary)
				{
					emailAddress.SearchKey = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.ReceivedByAddrtype:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode)
				{
					emailAddress.AddrType = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefPropertyId.RtfCompressed:
			{
				if (tnefPropertyReader.PropertyTag.ValueTnefType != TnefPropertyType.String8 && tnefPropertyReader.PropertyTag.ValueTnefType != TnefPropertyType.Unicode && tnefPropertyReader.PropertyTag.ValueTnefType != TnefPropertyType.Binary)
				{
					break;
				}
				TextPart textPart3 = new TextPart("rtf");
				RtfCompressedToRtf filter = new RtfCompressedToRtf();
				MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
				using (FilteredStream filteredStream = new FilteredStream(memoryBlockStream))
				{
					filteredStream.Add(filter);
					using Stream stream = tnefPropertyReader.GetRawValueReadStream();
					stream.CopyTo(filteredStream, 4096);
					filteredStream.Flush();
				}
				textPart3.Content = new MimeContent(memoryBlockStream);
				memoryBlockStream.Position = 0L;
				builder.Attachments.Add(textPart3);
				break;
			}
			case TnefPropertyId.BodyHtml:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Binary)
				{
					TextPart textPart2 = new TextPart("html");
					string text3;
					Encoding uTF;
					if (tnefPropertyReader.PropertyTag.ValueTnefType != TnefPropertyType.Unicode)
					{
						text3 = GetHtmlBody(tnefPropertyReader, reader.MessageCodepage, out uTF);
					}
					else
					{
						text3 = tnefPropertyReader.ReadValueAsString();
						uTF = CharsetUtils.UTF8;
					}
					textPart2.SetText(uTF, text3);
					builder.Attachments.Add(textPart2);
				}
				break;
			case TnefPropertyId.Body:
				if (tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.String8 || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode || tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Binary)
				{
					TextPart textPart = new TextPart("plain");
					Encoding encoding = ((tnefPropertyReader.PropertyTag.ValueTnefType == TnefPropertyType.Unicode) ? CharsetUtils.UTF8 : Encoding.GetEncoding(reader.MessageCodepage));
					textPart.SetText(encoding, tnefPropertyReader.ReadValueAsString());
					builder.Attachments.Add(textPart);
				}
				break;
			case TnefPropertyId.Importance:
				switch (tnefPropertyReader.ReadValueAsInt32())
				{
				case 2:
					message.Importance = MessageImportance.High;
					break;
				case 1:
					message.Importance = MessageImportance.Normal;
					break;
				case 0:
					message.Importance = MessageImportance.Low;
					break;
				}
				break;
			case TnefPropertyId.Priority:
				switch (tnefPropertyReader.ReadValueAsInt32())
				{
				case 1:
					message.Priority = MessagePriority.Urgent;
					break;
				case 0:
					message.Priority = MessagePriority.Normal;
					break;
				case -1:
					message.Priority = MessagePriority.NonUrgent;
					break;
				}
				break;
			case TnefPropertyId.Sensitivity:
				switch (tnefPropertyReader.ReadValueAsInt32())
				{
				case 1:
					message.Headers[HeaderId.Sensitivity] = "Personal";
					break;
				case 2:
					message.Headers[HeaderId.Sensitivity] = "Private";
					break;
				case 3:
					message.Headers[HeaderId.Sensitivity] = "Company-Confidential";
					break;
				case 0:
					message.Headers.Remove(HeaderId.Sensitivity);
					break;
				}
				break;
			}
		}
		if (string.IsNullOrEmpty(message.Subject) && !string.IsNullOrEmpty(text))
		{
			if (!string.IsNullOrEmpty(text2))
			{
				message.Subject = text2 + text;
			}
			else
			{
				message.Subject = text;
			}
		}
		if (emailAddress2.TryGetMailboxAddress(out var mailbox))
		{
			message.From.Add(mailbox);
		}
		if (emailAddress.TryGetMailboxAddress(out mailbox))
		{
			message.To.Add(mailbox);
		}
	}

	private static TnefPart PromoteToTnefPart(MimePart part)
	{
		TnefPart tnefPart = new TnefPart();
		foreach (Parameter parameter in part.ContentType.Parameters)
		{
			tnefPart.ContentType.Parameters[parameter.Name] = parameter.Value;
		}
		if (part.ContentDisposition != null)
		{
			tnefPart.ContentDisposition = part.ContentDisposition;
		}
		tnefPart.ContentTransferEncoding = part.ContentTransferEncoding;
		return tnefPart;
	}

	private static void ExtractAttachments(TnefReader reader, BodyBuilder builder)
	{
		TnefAttachMethod tnefAttachMethod = TnefAttachMethod.ByValue;
		BestEncodingFilter bestEncodingFilter = new BestEncodingFilter();
		TnefPropertyReader tnefPropertyReader = reader.TnefPropertyReader;
		MimePart mimePart = null;
		while (reader.AttributeLevel == TnefAttributeLevel.Attachment)
		{
			int outputIndex;
			int outputLength;
			switch (reader.AttributeTag)
			{
			case TnefAttributeTag.AttachRenderData:
				tnefAttachMethod = TnefAttachMethod.ByValue;
				mimePart = new MimePart();
				break;
			case TnefAttributeTag.Attachment:
			{
				if (mimePart == null)
				{
					break;
				}
				byte[] array = null;
				while (tnefPropertyReader.ReadNextProperty())
				{
					switch (tnefPropertyReader.PropertyTag.Id)
					{
					case TnefPropertyId.AttachLongFilename:
						mimePart.FileName = tnefPropertyReader.ReadValueAsString();
						break;
					case TnefPropertyId.AttachFilename:
						if (mimePart.FileName == null)
						{
							mimePart.FileName = tnefPropertyReader.ReadValueAsString();
						}
						break;
					case TnefPropertyId.AttachContentLocation:
						mimePart.ContentLocation = tnefPropertyReader.ReadValueAsUri();
						break;
					case TnefPropertyId.AttachContentBase:
						mimePart.ContentBase = tnefPropertyReader.ReadValueAsUri();
						break;
					case TnefPropertyId.AttachContentId:
					{
						string text = tnefPropertyReader.ReadValueAsString();
						byte[] bytes = CharsetUtils.UTF8.GetBytes(text);
						int index = 0;
						if (ParseUtils.TryParseMsgId(bytes, ref index, bytes.Length, requireAngleAddr: false, throwOnError: false, out var msgid))
						{
							mimePart.ContentId = msgid;
						}
						break;
					}
					case TnefPropertyId.AttachDisposition:
					{
						string text = tnefPropertyReader.ReadValueAsString();
						if (ContentDisposition.TryParse(text, out var contentDisposition))
						{
							mimePart.ContentDisposition = contentDisposition;
						}
						break;
					}
					case TnefPropertyId.AttachData:
						array = tnefPropertyReader.ReadValueAsBytes();
						break;
					case TnefPropertyId.AttachMethod:
						tnefAttachMethod = (TnefAttachMethod)tnefPropertyReader.ReadValueAsInt32();
						break;
					case TnefPropertyId.AttachMimeTag:
					{
						string[] array2 = tnefPropertyReader.ReadValueAsString().Split('/');
						if (array2.Length == 2)
						{
							mimePart.ContentType.MediaType = array2[0].Trim();
							mimePart.ContentType.MediaSubtype = array2[1].Trim();
						}
						break;
					}
					case TnefPropertyId.AttachFlags:
					{
						TnefAttachFlags tnefAttachFlags = (TnefAttachFlags)tnefPropertyReader.ReadValueAsInt32();
						if ((tnefAttachFlags & TnefAttachFlags.RenderedInBody) != TnefAttachFlags.None)
						{
							if (mimePart.ContentDisposition == null)
							{
								mimePart.ContentDisposition = new ContentDisposition("inline");
							}
							else
							{
								mimePart.ContentDisposition.Disposition = "inline";
							}
						}
						break;
					}
					case TnefPropertyId.AttachSize:
						if (mimePart.ContentDisposition == null)
						{
							mimePart.ContentDisposition = new ContentDisposition();
						}
						mimePart.ContentDisposition.Size = tnefPropertyReader.ReadValueAsInt64();
						break;
					case TnefPropertyId.DisplayName:
						mimePart.ContentType.Name = tnefPropertyReader.ReadValueAsString();
						break;
					}
				}
				if (array != null)
				{
					int num = array.Length;
					int num2 = 0;
					if (tnefAttachMethod == TnefAttachMethod.EmbeddedMessage)
					{
						mimePart.ContentTransferEncoding = ContentEncoding.Base64;
						mimePart = PromoteToTnefPart(mimePart);
						num -= 16;
						num2 = 16;
					}
					else if (mimePart.ContentType.IsMimeType("text", "*"))
					{
						bestEncodingFilter.Flush(array, num2, num, out outputIndex, out outputLength);
						mimePart.ContentTransferEncoding = bestEncodingFilter.GetBestEncoding(EncodingConstraint.SevenBit);
						bestEncodingFilter.Reset();
					}
					else
					{
						mimePart.ContentTransferEncoding = ContentEncoding.Base64;
					}
					mimePart.Content = new MimeContent(new MemoryStream(array, num2, num, writable: false));
					builder.Attachments.Add(mimePart);
				}
				break;
			}
			case TnefAttributeTag.AttachCreateDate:
				if (mimePart != null)
				{
					if (mimePart.ContentDisposition == null)
					{
						mimePart.ContentDisposition = new ContentDisposition();
					}
					mimePart.ContentDisposition.CreationDate = tnefPropertyReader.ReadValueAsDateTime();
				}
				break;
			case TnefAttributeTag.AttachModifyDate:
				if (mimePart != null)
				{
					if (mimePart.ContentDisposition == null)
					{
						mimePart.ContentDisposition = new ContentDisposition();
					}
					mimePart.ContentDisposition.ModificationDate = tnefPropertyReader.ReadValueAsDateTime();
				}
				break;
			case TnefAttributeTag.AttachTitle:
				if (mimePart != null && string.IsNullOrEmpty(mimePart.FileName))
				{
					mimePart.FileName = tnefPropertyReader.ReadValueAsString();
				}
				break;
			case TnefAttributeTag.AttachMetaFile:
				if (mimePart != null)
				{
				}
				break;
			case TnefAttributeTag.AttachData:
				if (mimePart != null && tnefAttachMethod == TnefAttachMethod.ByValue)
				{
					byte[] array = tnefPropertyReader.ReadValueAsBytes();
					if (mimePart.ContentType.IsMimeType("text", "*"))
					{
						bestEncodingFilter.Flush(array, 0, array.Length, out outputIndex, out outputLength);
						mimePart.ContentTransferEncoding = bestEncodingFilter.GetBestEncoding(EncodingConstraint.SevenBit);
						bestEncodingFilter.Reset();
					}
					else
					{
						mimePart.ContentTransferEncoding = ContentEncoding.Base64;
					}
					mimePart.Content = new MimeContent(new MemoryStream(array, writable: false));
					builder.Attachments.Add(mimePart);
				}
				break;
			}
			if (!reader.ReadNextAttribute())
			{
				break;
			}
		}
	}

	private static MimeMessage ExtractTnefMessage(TnefReader reader)
	{
		BodyBuilder bodyBuilder = new BodyBuilder();
		MimeMessage mimeMessage = new MimeMessage();
		mimeMessage.Headers.Remove(HeaderId.Date);
		while (reader.ReadNextAttribute() && reader.AttributeLevel != TnefAttributeLevel.Attachment)
		{
			TnefPropertyReader tnefPropertyReader = reader.TnefPropertyReader;
			switch (reader.AttributeTag)
			{
			case TnefAttributeTag.RecipientTable:
				ExtractRecipientTable(reader, mimeMessage);
				break;
			case TnefAttributeTag.MapiProperties:
				ExtractMapiProperties(reader, mimeMessage, bodyBuilder);
				break;
			case TnefAttributeTag.DateSent:
				mimeMessage.Date = tnefPropertyReader.ReadValueAsDateTime();
				break;
			case TnefAttributeTag.Body:
				bodyBuilder.TextBody = tnefPropertyReader.ReadValueAsString();
				break;
			}
		}
		if (reader.AttributeLevel == TnefAttributeLevel.Attachment)
		{
			ExtractAttachments(reader, bodyBuilder);
		}
		mimeMessage.Body = bodyBuilder.ToMessageBody();
		return mimeMessage;
	}

	public MimeMessage ConvertToMessage()
	{
		if (base.Content == null)
		{
			throw new InvalidOperationException("Cannot parse null TNEF data.");
		}
		int defaultMessageCodepage = 0;
		if (!string.IsNullOrEmpty(base.ContentType.Charset) && (defaultMessageCodepage = CharsetUtils.GetCodePage(base.ContentType.Charset)) == -1)
		{
			defaultMessageCodepage = 0;
		}
		using TnefReader reader = new TnefReader(base.Content.Open(), defaultMessageCodepage, TnefComplianceMode.Loose);
		return ExtractTnefMessage(reader);
	}

	public IEnumerable<MimeEntity> ExtractAttachments()
	{
		MimeMessage mimeMessage = ConvertToMessage();
		foreach (MimeEntity bodyPart in mimeMessage.BodyParts)
		{
			yield return bodyPart;
		}
	}
}
