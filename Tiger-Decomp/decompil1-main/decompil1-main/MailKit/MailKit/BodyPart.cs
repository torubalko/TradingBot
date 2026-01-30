using System;
using System.Collections.Generic;
using System.Text;
using MimeKit;
using MimeKit.Utils;

namespace MailKit;

public abstract class BodyPart
{
	public ContentType ContentType { get; set; }

	public string PartSpecifier { get; set; }

	public abstract void Accept(BodyPartVisitor visitor);

	internal static void Encode(StringBuilder builder, uint value)
	{
		builder.Append(value.ToString());
	}

	internal static void Encode(StringBuilder builder, string value)
	{
		if (value != null)
		{
			MimeUtils.AppendQuoted(builder, value);
		}
		else
		{
			builder.Append("NIL");
		}
	}

	internal static void Encode(StringBuilder builder, Uri location)
	{
		if (location != null)
		{
			MimeUtils.AppendQuoted(builder, location.ToString());
		}
		else
		{
			builder.Append("NIL");
		}
	}

	internal static void Encode(StringBuilder builder, string[] values)
	{
		if (values == null || values.Length == 0)
		{
			builder.Append("NIL");
			return;
		}
		builder.Append('(');
		for (int i = 0; i < values.Length; i++)
		{
			if (i > 0)
			{
				builder.Append(' ');
			}
			Encode(builder, values[i]);
		}
		builder.Append(')');
	}

	internal static void Encode(StringBuilder builder, IList<Parameter> parameters)
	{
		if (parameters == null || parameters.Count == 0)
		{
			builder.Append("NIL");
			return;
		}
		builder.Append('(');
		for (int i = 0; i < parameters.Count; i++)
		{
			if (i > 0)
			{
				builder.Append(' ');
			}
			Encode(builder, parameters[i].Name);
			builder.Append(' ');
			Encode(builder, parameters[i].Value);
		}
		builder.Append(')');
	}

	internal static void Encode(StringBuilder builder, ContentDisposition disposition)
	{
		if (disposition == null)
		{
			builder.Append("NIL");
			return;
		}
		builder.Append('(');
		Encode(builder, disposition.Disposition);
		builder.Append(' ');
		Encode(builder, disposition.Parameters);
		builder.Append(')');
	}

	internal static void Encode(StringBuilder builder, ContentType contentType)
	{
		Encode(builder, contentType.MediaType);
		builder.Append(' ');
		Encode(builder, contentType.MediaSubtype);
		builder.Append(' ');
		Encode(builder, contentType.Parameters);
	}

	internal static void Encode(StringBuilder builder, BodyPartCollection parts)
	{
		if (parts == null || parts.Count == 0)
		{
			builder.Append("NIL");
			return;
		}
		for (int i = 0; i < parts.Count; i++)
		{
			if (i > 0)
			{
				builder.Append(' ');
			}
			Encode(builder, parts[i]);
		}
	}

	internal static void Encode(StringBuilder builder, Envelope envelope)
	{
		if (envelope == null)
		{
			builder.Append("NIL");
		}
		else
		{
			envelope.Encode(builder);
		}
	}

	internal static void Encode(StringBuilder builder, BodyPart body)
	{
		if (body == null)
		{
			builder.Append("NIL");
			return;
		}
		builder.Append('(');
		body.Encode(builder);
		builder.Append(')');
	}

	protected abstract void Encode(StringBuilder builder);

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		Encode(stringBuilder);
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	private static bool TryParse(string text, ref int index, out uint value)
	{
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		int num = index;
		value = 0u;
		while (index < text.Length && char.IsDigit(text[index]))
		{
			value = value * 10 + (uint)(text[index++] - 48);
		}
		return index > num;
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

	private static bool TryParse(string text, ref int index, out string[] values)
	{
		values = null;
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
		List<string> list = new List<string>();
		while (text[index] != ')')
		{
			if (!TryParse(text, ref index, out string nstring))
			{
				return false;
			}
			list.Add(nstring);
			if (index >= text.Length)
			{
				break;
			}
		}
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		values = list.ToArray();
		index++;
		return true;
	}

	private static bool TryParse(string text, ref int index, out Uri uri)
	{
		uri = null;
		if (!TryParse(text, ref index, out string nstring))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(nstring))
		{
			if (Uri.IsWellFormedUriString(nstring, UriKind.Absolute))
			{
				uri = new Uri(nstring, UriKind.Absolute);
			}
			else if (Uri.IsWellFormedUriString(nstring, UriKind.Relative))
			{
				uri = new Uri(nstring, UriKind.Relative);
			}
		}
		return true;
	}

	private static bool TryParse(string text, ref int index, out IList<Parameter> parameters)
	{
		parameters = null;
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
				parameters = new List<Parameter>();
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
		parameters = new List<Parameter>();
		while (text[index] != ')')
		{
			if (!TryParse(text, ref index, out string nstring))
			{
				return false;
			}
			if (!TryParse(text, ref index, out string nstring2))
			{
				return false;
			}
			parameters.Add(new Parameter(nstring, nstring2));
			if (index >= text.Length)
			{
				break;
			}
		}
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		index++;
		return true;
	}

	private static bool TryParse(string text, ref int index, out ContentDisposition disposition)
	{
		disposition = null;
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
		if (!TryParse(text, ref index, out IList<Parameter> parameters))
		{
			return false;
		}
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		index++;
		disposition = new ContentDisposition(nstring);
		foreach (Parameter item in parameters)
		{
			disposition.Parameters.Add(item);
		}
		return true;
	}

	private static bool TryParse(string text, ref int index, bool multipart, out ContentType contentType)
	{
		contentType = null;
		while (index < text.Length && text[index] == ' ')
		{
			index++;
		}
		if (index >= text.Length)
		{
			return false;
		}
		string nstring;
		if (!multipart)
		{
			if (!TryParse(text, ref index, out nstring))
			{
				return false;
			}
		}
		else
		{
			nstring = "multipart";
		}
		if (!TryParse(text, ref index, out string nstring2))
		{
			return false;
		}
		if (!TryParse(text, ref index, out IList<Parameter> parameters))
		{
			return false;
		}
		contentType = new ContentType(nstring ?? "application", nstring2 ?? "octet-stream");
		foreach (Parameter item in parameters)
		{
			contentType.Parameters.Add(item);
		}
		return true;
	}

	private static bool TryParse(string text, ref int index, string prefix, out IList<BodyPart> children)
	{
		int num = 1;
		children = null;
		if (index >= text.Length)
		{
			return false;
		}
		children = new List<BodyPart>();
		while (text[index] == '(')
		{
			string path = prefix + num;
			if (!TryParse(text, ref index, path, out BodyPart part))
			{
				return false;
			}
			while (index < text.Length && text[index] == ' ')
			{
				index++;
			}
			children.Add(part);
			num++;
			if (index >= text.Length)
			{
				break;
			}
		}
		return index < text.Length;
	}

	private static bool TryParse(string text, ref int index, string path, out BodyPart part)
	{
		part = null;
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
		if (index >= text.Length)
		{
			return false;
		}
		ContentType contentType;
		ContentDisposition disposition;
		string[] values;
		Uri uri;
		if (text[index] == '(')
		{
			string prefix = ((path.Length > 0) ? (path + ".") : string.Empty);
			BodyPartMultipart bodyPartMultipart = new BodyPartMultipart();
			if (!TryParse(text, ref index, prefix, out IList<BodyPart> children))
			{
				return false;
			}
			foreach (BodyPart item in children)
			{
				bodyPartMultipart.BodyParts.Add(item);
			}
			if (!TryParse(text, ref index, multipart: true, out contentType))
			{
				return false;
			}
			bodyPartMultipart.ContentType = contentType;
			if (!TryParse(text, ref index, out disposition))
			{
				return false;
			}
			bodyPartMultipart.ContentDisposition = disposition;
			if (!TryParse(text, ref index, out values))
			{
				return false;
			}
			bodyPartMultipart.ContentLanguage = values;
			if (!TryParse(text, ref index, out uri))
			{
				return false;
			}
			bodyPartMultipart.ContentLocation = uri;
			part = bodyPartMultipart;
		}
		else
		{
			BodyPartMessage bodyPartMessage = null;
			BodyPartText bodyPartText = null;
			if (!TryParse(text, ref index, multipart: false, out contentType))
			{
				return false;
			}
			BodyPartBasic bodyPartBasic = (contentType.IsMimeType("message", "rfc822") ? (bodyPartMessage = new BodyPartMessage()) : ((!contentType.IsMimeType("text", "*")) ? new BodyPartBasic() : (bodyPartText = new BodyPartText())));
			bodyPartBasic.ContentType = contentType;
			if (!TryParse(text, ref index, out string nstring))
			{
				return false;
			}
			bodyPartBasic.ContentId = nstring;
			if (!TryParse(text, ref index, out nstring))
			{
				return false;
			}
			bodyPartBasic.ContentDescription = nstring;
			if (!TryParse(text, ref index, out nstring))
			{
				return false;
			}
			bodyPartBasic.ContentTransferEncoding = nstring;
			if (!TryParse(text, ref index, out uint value))
			{
				return false;
			}
			bodyPartBasic.Octets = value;
			if (!TryParse(text, ref index, out nstring))
			{
				return false;
			}
			bodyPartBasic.ContentMd5 = nstring;
			if (!TryParse(text, ref index, out disposition))
			{
				return false;
			}
			bodyPartBasic.ContentDisposition = disposition;
			if (!TryParse(text, ref index, out values))
			{
				return false;
			}
			bodyPartBasic.ContentLanguage = values;
			if (!TryParse(text, ref index, out uri))
			{
				return false;
			}
			bodyPartBasic.ContentLocation = uri;
			if (bodyPartMessage != null)
			{
				if (!Envelope.TryParse(text, ref index, out var envelope))
				{
					return false;
				}
				bodyPartMessage.Envelope = envelope;
				if (!TryParse(text, ref index, path, out BodyPart part2))
				{
					return false;
				}
				bodyPartMessage.Body = part2;
				if (!TryParse(text, ref index, out value))
				{
					return false;
				}
				bodyPartMessage.Lines = value;
			}
			else if (bodyPartText != null)
			{
				if (!TryParse(text, ref index, out value))
				{
					return false;
				}
				bodyPartText.Lines = value;
			}
			part = bodyPartBasic;
		}
		part.PartSpecifier = path;
		if (index >= text.Length || text[index] != ')')
		{
			return false;
		}
		index++;
		return true;
	}

	public static bool TryParse(string text, out BodyPart part)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		int index = 0;
		if (TryParse(text, ref index, string.Empty, out part))
		{
			return index == text.Length;
		}
		return false;
	}
}
