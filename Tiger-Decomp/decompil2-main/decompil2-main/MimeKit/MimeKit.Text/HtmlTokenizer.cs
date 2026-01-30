using System.IO;
using System.Runtime.CompilerServices;

namespace MimeKit.Text;

public class HtmlTokenizer
{
	private const string DocType = "doctype";

	private const string CData = "[CDATA[";

	private readonly HtmlEntityDecoder entity = new HtmlEntityDecoder();

	private readonly CharBuffer data = new CharBuffer(2048);

	private readonly CharBuffer name = new CharBuffer(32);

	private readonly char[] cdata = new char[3];

	private readonly TextReader text;

	private HtmlDocTypeToken doctype;

	private HtmlAttribute attribute;

	private string activeTagName;

	private HtmlTagToken tag;

	private int cdataIndex;

	private bool isEndTag;

	private bool bang;

	private char quote;

	public bool DecodeCharacterReferences { get; set; }

	public HtmlNamespace HtmlNamespace { get; private set; }

	public bool IgnoreTruncatedTags { get; set; }

	public int LineNumber { get; private set; }

	public int LinePosition { get; private set; }

	public HtmlTokenizerState TokenizerState { get; private set; }

	public HtmlTokenizer(TextReader reader)
	{
		DecodeCharacterReferences = true;
		LinePosition = 1;
		LineNumber = 1;
		text = reader;
	}

	protected virtual HtmlDocTypeToken CreateDocType()
	{
		return new HtmlDocTypeToken();
	}

	private HtmlDocTypeToken CreateDocTypeToken(string rawTagName)
	{
		HtmlDocTypeToken htmlDocTypeToken = CreateDocType();
		htmlDocTypeToken.RawTagName = rawTagName;
		return htmlDocTypeToken;
	}

	protected virtual HtmlCommentToken CreateCommentToken(string comment, bool bogus = false)
	{
		return new HtmlCommentToken(comment, bogus);
	}

	protected virtual HtmlDataToken CreateDataToken(string data)
	{
		return new HtmlDataToken(data);
	}

	protected virtual HtmlCDataToken CreateCDataToken(string data)
	{
		return new HtmlCDataToken(data);
	}

	protected virtual HtmlScriptDataToken CreateScriptDataToken(string data)
	{
		return new HtmlScriptDataToken(data);
	}

	protected virtual HtmlTagToken CreateTagToken(string name, bool isEndTag = false)
	{
		return new HtmlTagToken(name, isEndTag);
	}

	protected virtual HtmlAttribute CreateAttribute(string name)
	{
		return new HtmlAttribute(name);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsAlphaNumeric(int c)
	{
		if ((uint)(c - 65) > 25u && (uint)(c - 97) > 25u)
		{
			return (uint)(c - 48) <= 9u;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsAsciiLetter(int c)
	{
		if ((uint)(c - 65) > 25u)
		{
			return (uint)(c - 97) <= 25u;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static char ToLower(int c)
	{
		if ((uint)(c - 65) <= 25u)
		{
			return (char)(c + 32);
		}
		return (char)c;
	}

	private int Peek()
	{
		return text.Peek();
	}

	private int Read()
	{
		int num;
		if ((num = text.Read()) == -1)
		{
			return -1;
		}
		if (num == 10)
		{
			LinePosition = 1;
			LineNumber++;
		}
		else
		{
			LinePosition++;
		}
		return num;
	}

	private bool NameIs(string value)
	{
		if (name.Length != value.Length)
		{
			return false;
		}
		for (int i = 0; i < name.Length; i++)
		{
			if (ToLower(name[i]) != value[i])
			{
				return false;
			}
		}
		return true;
	}

	private void EmitTagAttribute()
	{
		attribute = CreateAttribute(name.ToString());
		tag.Attributes.Add(attribute);
		name.Length = 0;
	}

	private HtmlToken EmitCommentToken(string comment, bool bogus = false)
	{
		HtmlCommentToken htmlCommentToken = CreateCommentToken(comment, bogus);
		htmlCommentToken.IsBangComment = bang;
		data.Length = 0;
		name.Length = 0;
		bang = false;
		return htmlCommentToken;
	}

	private HtmlToken EmitCommentToken(CharBuffer comment, bool bogus = false)
	{
		return EmitCommentToken(comment.ToString(), bogus);
	}

	private HtmlToken EmitDocType()
	{
		HtmlDocTypeToken result = doctype;
		data.Length = 0;
		doctype = null;
		return result;
	}

	private HtmlToken EmitDataToken(bool encodeEntities, bool truncated)
	{
		if (data.Length == 0)
		{
			return null;
		}
		if (truncated && IgnoreTruncatedTags)
		{
			data.Length = 0;
			return null;
		}
		HtmlDataToken htmlDataToken = CreateDataToken(data.ToString());
		htmlDataToken.EncodeEntities = encodeEntities;
		data.Length = 0;
		return htmlDataToken;
	}

	private HtmlToken EmitCDataToken()
	{
		if (data.Length == 0)
		{
			return null;
		}
		HtmlCDataToken result = CreateCDataToken(data.ToString());
		data.Length = 0;
		return result;
	}

	private HtmlToken EmitScriptDataToken()
	{
		if (data.Length == 0)
		{
			return null;
		}
		HtmlScriptDataToken result = CreateScriptDataToken(data.ToString());
		data.Length = 0;
		return result;
	}

	private HtmlToken EmitTagToken()
	{
		if (!tag.IsEndTag && !tag.IsEmptyElement)
		{
			switch (tag.Id)
			{
			case HtmlTagId.IFrame:
			case HtmlTagId.NoEmbed:
			case HtmlTagId.NoFrames:
			case HtmlTagId.Style:
			case HtmlTagId.Xmp:
				TokenizerState = HtmlTokenizerState.RawText;
				activeTagName = tag.Name.ToLowerInvariant();
				break;
			case HtmlTagId.TextArea:
			case HtmlTagId.Title:
				TokenizerState = HtmlTokenizerState.RcData;
				activeTagName = tag.Name.ToLowerInvariant();
				break;
			case HtmlTagId.PlainText:
				TokenizerState = HtmlTokenizerState.PlainText;
				break;
			case HtmlTagId.Script:
				TokenizerState = HtmlTokenizerState.ScriptData;
				break;
			case HtmlTagId.NoScript:
				TokenizerState = HtmlTokenizerState.RawText;
				activeTagName = tag.Name.ToLowerInvariant();
				break;
			case HtmlTagId.Html:
			{
				TokenizerState = HtmlTokenizerState.Data;
				for (int num = tag.Attributes.Count; num > 0; num--)
				{
					HtmlAttribute htmlAttribute = tag.Attributes[num - 1];
					if (htmlAttribute.Id == HtmlAttributeId.XmlNS && htmlAttribute.Value != null)
					{
						HtmlNamespace = htmlAttribute.Value.ToHtmlNamespace();
						break;
					}
				}
				break;
			}
			default:
				TokenizerState = HtmlTokenizerState.Data;
				break;
			}
		}
		else
		{
			TokenizerState = HtmlTokenizerState.Data;
		}
		HtmlTagToken result = tag;
		data.Length = 0;
		tag = null;
		return result;
	}

	private HtmlToken ReadCharacterReference(HtmlTokenizerState next)
	{
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			data.Append('&');
			return EmitDataToken(encodeEntities: true, truncated: false);
		}
		char c = (char)num;
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
		case '&':
		case '<':
			TokenizerState = next;
			data.Append('&');
			return null;
		default:
			entity.Push('&');
			while (entity.Push(c))
			{
				Read();
				if (c == ';')
				{
					break;
				}
				if ((num = Peek()) == -1)
				{
					TokenizerState = HtmlTokenizerState.EndOfFile;
					data.Append(entity.GetPushedInput());
					entity.Reset();
					return EmitDataToken(encodeEntities: true, truncated: false);
				}
				c = (char)num;
			}
			TokenizerState = next;
			data.Append(entity.GetValue());
			entity.Reset();
			return null;
		}
	}

	private HtmlToken ReadGenericRawTextLessThan(HtmlTokenizerState rawText, HtmlTokenizerState rawTextEndTagOpen)
	{
		int num = Peek();
		data.Append('<');
		char c = (char)num;
		if (c == '/')
		{
			TokenizerState = rawTextEndTagOpen;
			data.Append('/');
			name.Length = 0;
			Read();
		}
		else
		{
			TokenizerState = rawText;
		}
		return null;
	}

	private HtmlToken ReadGenericRawTextEndTagOpen(bool decoded, HtmlTokenizerState rawText, HtmlTokenizerState rawTextEndTagName)
	{
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitDataToken(decoded, truncated: true);
		}
		char c = (char)num;
		if (IsAsciiLetter(c))
		{
			TokenizerState = rawTextEndTagName;
			name.Append(c);
			data.Append(c);
			Read();
		}
		else
		{
			TokenizerState = rawText;
		}
		return null;
	}

	private HtmlToken ReadGenericRawTextEndTagName(bool decoded, HtmlTokenizerState rawText)
	{
		HtmlTokenizerState tokenizerState = TokenizerState;
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitDataToken(decoded, truncated: true);
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				if (!NameIs(activeTagName))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.BeforeAttributeName;
				continue;
			case '/':
				if (!NameIs(activeTagName))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				continue;
			case '>':
				if (NameIs(activeTagName))
				{
					HtmlTagToken result = CreateTagToken(name.ToString(), isEndTag: true);
					TokenizerState = HtmlTokenizerState.Data;
					data.Length = 0;
					name.Length = 0;
					return result;
				}
				break;
			}
			if (!IsAsciiLetter(c))
			{
				TokenizerState = rawText;
				return null;
			}
			name.Append((c == '\0') ? '\ufffd' : c);
		}
		while (TokenizerState == tokenizerState);
		tag = CreateTagToken(name.ToString(), isEndTag: true);
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadData()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				break;
			}
			char c = (char)num;
			switch (c)
			{
			case '&':
				if (DecodeCharacterReferences)
				{
					TokenizerState = HtmlTokenizerState.CharacterReferenceInData;
					return null;
				}
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.TagOpen;
				continue;
			}
			data.Append(c);
		}
		while (TokenizerState == HtmlTokenizerState.Data);
		return EmitDataToken(DecodeCharacterReferences, truncated: false);
	}

	private HtmlToken ReadCharacterReferenceInData()
	{
		return ReadCharacterReference(HtmlTokenizerState.Data);
	}

	private HtmlToken ReadRcData()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				break;
			}
			char c = (char)num;
			switch (c)
			{
			case '&':
				if (DecodeCharacterReferences)
				{
					TokenizerState = HtmlTokenizerState.CharacterReferenceInRcData;
					return null;
				}
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.RcDataLessThan;
				return EmitDataToken(DecodeCharacterReferences, truncated: false);
			}
			data.Append((c == '\0') ? '\ufffd' : c);
		}
		while (TokenizerState == HtmlTokenizerState.RcData);
		return EmitDataToken(DecodeCharacterReferences, truncated: false);
	}

	private HtmlToken ReadCharacterReferenceInRcData()
	{
		return ReadCharacterReference(HtmlTokenizerState.RcData);
	}

	private HtmlToken ReadRawText()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				break;
			}
			char c = (char)num;
			if (c == '<')
			{
				TokenizerState = HtmlTokenizerState.RawTextLessThan;
				return EmitDataToken(encodeEntities: false, truncated: false);
			}
			data.Append((c == '\0') ? '\ufffd' : c);
		}
		while (TokenizerState == HtmlTokenizerState.RawText);
		return EmitDataToken(encodeEntities: false, truncated: false);
	}

	private HtmlToken ReadScriptData()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				break;
			}
			char c = (char)num;
			if (c == '<')
			{
				TokenizerState = HtmlTokenizerState.ScriptDataLessThan;
			}
			else
			{
				data.Append((c == '\0') ? '\ufffd' : c);
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptData);
		return EmitScriptDataToken();
	}

	private HtmlToken ReadPlainText()
	{
		for (int num = Read(); num != -1; num = Read())
		{
			char c = (char)num;
			data.Append((c == '\0') ? '\ufffd' : c);
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		return EmitDataToken(encodeEntities: false, truncated: false);
	}

	private HtmlToken ReadTagOpen()
	{
		int num = Read();
		if (num == -1)
		{
			HtmlDataToken result = (IgnoreTruncatedTags ? null : CreateDataToken("<"));
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return result;
		}
		char c = (char)num;
		data.Append('<');
		data.Append(c);
		switch (c = (char)num)
		{
		case '!':
			TokenizerState = HtmlTokenizerState.MarkupDeclarationOpen;
			break;
		case '?':
			TokenizerState = HtmlTokenizerState.BogusComment;
			data.Length = 1;
			data[0] = c;
			break;
		case '/':
			TokenizerState = HtmlTokenizerState.EndTagOpen;
			break;
		default:
			if (IsAsciiLetter(c))
			{
				TokenizerState = HtmlTokenizerState.TagName;
				isEndTag = false;
				name.Append(c);
			}
			else
			{
				TokenizerState = HtmlTokenizerState.Data;
			}
			break;
		}
		return null;
	}

	private HtmlToken ReadEndTagOpen()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitDataToken(encodeEntities: false, truncated: true);
		}
		char c = (char)num;
		data.Append(c);
		if (c == '>')
		{
			TokenizerState = HtmlTokenizerState.Data;
			data.Length = 0;
		}
		else if (IsAsciiLetter(c))
		{
			TokenizerState = HtmlTokenizerState.TagName;
			isEndTag = true;
			name.Append(c);
		}
		else
		{
			TokenizerState = HtmlTokenizerState.BogusComment;
			data.Length = 1;
			data[0] = c;
		}
		return null;
	}

	private HtmlToken ReadTagName()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitDataToken(encodeEntities: false, truncated: true);
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				TokenizerState = HtmlTokenizerState.BeforeAttributeName;
				break;
			case '/':
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				break;
			case '>':
				tag = CreateTagToken(name.ToString(), isEndTag);
				data.Length = 0;
				name.Length = 0;
				return EmitTagToken();
			default:
				name.Append((c == '\0') ? '\ufffd' : c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.TagName);
		tag = CreateTagToken(name.ToString(), isEndTag);
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadRcDataLessThan()
	{
		return ReadGenericRawTextLessThan(HtmlTokenizerState.RcData, HtmlTokenizerState.RcDataEndTagOpen);
	}

	private HtmlToken ReadRcDataEndTagOpen()
	{
		return ReadGenericRawTextEndTagOpen(DecodeCharacterReferences, HtmlTokenizerState.RcData, HtmlTokenizerState.RcDataEndTagName);
	}

	private HtmlToken ReadRcDataEndTagName()
	{
		return ReadGenericRawTextEndTagName(DecodeCharacterReferences, HtmlTokenizerState.RcData);
	}

	private HtmlToken ReadRawTextLessThan()
	{
		return ReadGenericRawTextLessThan(HtmlTokenizerState.RawText, HtmlTokenizerState.RawTextEndTagOpen);
	}

	private HtmlToken ReadRawTextEndTagOpen()
	{
		return ReadGenericRawTextEndTagOpen(decoded: false, HtmlTokenizerState.RawText, HtmlTokenizerState.RawTextEndTagName);
	}

	private HtmlToken ReadRawTextEndTagName()
	{
		return ReadGenericRawTextEndTagName(decoded: false, HtmlTokenizerState.RawText);
	}

	private HtmlToken ReadScriptDataLessThan()
	{
		int num = Peek();
		data.Append('<');
		switch ((char)(ushort)num)
		{
		case '/':
			TokenizerState = HtmlTokenizerState.ScriptDataEndTagOpen;
			data.Append('/');
			name.Length = 0;
			Read();
			break;
		case '!':
			TokenizerState = HtmlTokenizerState.ScriptDataEscapeStart;
			data.Append('!');
			Read();
			break;
		default:
			TokenizerState = HtmlTokenizerState.ScriptData;
			break;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEndTagOpen()
	{
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitScriptDataToken();
		}
		char c = (char)num;
		if (c == 'S' || c == 's')
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEndTagName;
			name.Append('s');
			data.Append(c);
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptData;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEndTagName()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				if (!NameIs("script"))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.BeforeAttributeName;
				continue;
			case '/':
				if (!NameIs("script"))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				continue;
			case '>':
				if (NameIs("script"))
				{
					HtmlTagToken result = CreateTagToken(name.ToString(), isEndTag: true);
					TokenizerState = HtmlTokenizerState.Data;
					data.Length = 0;
					name.Length = 0;
					return result;
				}
				break;
			}
			if (!IsAsciiLetter(c))
			{
				TokenizerState = HtmlTokenizerState.ScriptData;
				name.Length = 0;
				return null;
			}
			name.Append((c == '\0') ? '\ufffd' : c);
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEndTagName);
		tag = CreateTagToken(name.ToString(), isEndTag: true);
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadScriptDataEscapeStart()
	{
		int num = Peek();
		if (num == 45)
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscapeStartDash;
			data.Append('-');
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptData;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEscapeStartDash()
	{
		int num = Peek();
		if (num == 45)
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscapedDashDash;
			data.Append('-');
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptData;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEscaped()
	{
		HtmlToken result = null;
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			switch (c)
			{
			case '-':
				TokenizerState = HtmlTokenizerState.ScriptDataEscapedDash;
				data.Append('-');
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.ScriptDataEscapedLessThan;
				result = EmitScriptDataToken();
				data.Append('<');
				break;
			default:
				data.Append((c == '\0') ? '\ufffd' : c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEscaped);
		return result;
	}

	private HtmlToken ReadScriptDataEscapedDash()
	{
		HtmlToken result = null;
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitScriptDataToken();
		}
		char c;
		switch (c = (char)num)
		{
		case '-':
			TokenizerState = HtmlTokenizerState.ScriptDataEscapedDashDash;
			data.Append('-');
			Read();
			break;
		case '<':
			TokenizerState = HtmlTokenizerState.ScriptDataEscapedLessThan;
			result = EmitScriptDataToken();
			data.Append('<');
			Read();
			break;
		default:
			TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
			data.Append((c == '\0') ? '\ufffd' : c);
			break;
		}
		return result;
	}

	private HtmlToken ReadScriptDataEscapedDashDash()
	{
		HtmlToken result = null;
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			switch (c)
			{
			case '-':
				data.Append('-');
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.ScriptDataEscapedLessThan;
				result = EmitScriptDataToken();
				data.Append('<');
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.ScriptData;
				data.Append('>');
				break;
			default:
				TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
				data.Append(c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEscapedDashDash);
		return result;
	}

	private HtmlToken ReadScriptDataEscapedLessThan()
	{
		int num = Peek();
		char c = (char)num;
		if (c == '/')
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscapedEndTagOpen;
			data.Append(c);
			name.Length = 0;
			Read();
		}
		else if (IsAsciiLetter(c))
		{
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapeStart;
			data.Append(c);
			name.Append(c);
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEscapedEndTagOpen()
	{
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitScriptDataToken();
		}
		char c = (char)num;
		if (IsAsciiLetter(c))
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscapedEndTagName;
			data.Append(c);
			name.Append(c);
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
		}
		return null;
	}

	private HtmlToken ReadScriptDataEscapedEndTagName()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				if (!NameIs("script"))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.BeforeAttributeName;
				continue;
			case '/':
				if (!NameIs("script"))
				{
					break;
				}
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				continue;
			case '>':
				if (NameIs("script"))
				{
					HtmlTagToken result = CreateTagToken(name.ToString(), isEndTag: true);
					TokenizerState = HtmlTokenizerState.Data;
					data.Length = 0;
					name.Length = 0;
					return result;
				}
				break;
			}
			if (!IsAsciiLetter(c))
			{
				TokenizerState = HtmlTokenizerState.ScriptData;
				return null;
			}
			name.Append(c);
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEscapedEndTagName);
		tag = CreateTagToken(name.ToString(), isEndTag: true);
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscapeStart()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
			case '/':
			case '>':
				if (NameIs("script"))
				{
					TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
				}
				else
				{
					TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
				}
				name.Length = 0;
				break;
			default:
				if (!IsAsciiLetter(c))
				{
					TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
				}
				else
				{
					name.Append(c);
				}
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataDoubleEscapeStart);
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscaped()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			switch (c)
			{
			case '-':
				TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapedDash;
				data.Append('-');
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapedLessThan;
				data.Append('<');
				break;
			default:
				data.Append((c == '\0') ? '\ufffd' : c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEscaped);
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscapedDash()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitScriptDataToken();
		}
		char c;
		switch (c = (char)num)
		{
		case '-':
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapedDashDash;
			data.Append('-');
			break;
		case '<':
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapedLessThan;
			data.Append('<');
			break;
		default:
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
			data.Append((c == '\0') ? '\ufffd' : c);
			break;
		}
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscapedDashDash()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitScriptDataToken();
			}
			char c = (char)num;
			switch (c)
			{
			case '-':
				data.Append('-');
				break;
			case '<':
				TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapedLessThan;
				data.Append('<');
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.ScriptData;
				data.Append('>');
				break;
			default:
				TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
				data.Append(c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataEscapedDashDash);
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscapedLessThan()
	{
		int num = Peek();
		if (num == 47)
		{
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscapeEnd;
			data.Append('/');
			Read();
		}
		else
		{
			TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
		}
		return null;
	}

	private HtmlToken ReadScriptDataDoubleEscapeEnd()
	{
		do
		{
			int num = Peek();
			char c = (char)num;
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
			case '/':
			case '>':
				if (NameIs("script"))
				{
					TokenizerState = HtmlTokenizerState.ScriptDataEscaped;
				}
				else
				{
					TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
				}
				data.Append(c);
				Read();
				continue;
			}
			if (!IsAsciiLetter(c))
			{
				TokenizerState = HtmlTokenizerState.ScriptDataDoubleEscaped;
				continue;
			}
			name.Append(c);
			data.Append(c);
			Read();
		}
		while (TokenizerState == HtmlTokenizerState.ScriptDataDoubleEscapeEnd);
		return null;
	}

	private HtmlToken ReadBeforeAttributeName()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '/':
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				return null;
			case '>':
				return EmitTagToken();
			default:
				TokenizerState = HtmlTokenizerState.AttributeName;
				name.Append((c == '\0') ? '\ufffd' : c);
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		tag = null;
		return EmitDataToken(encodeEntities: false, truncated: true);
	}

	private HtmlToken ReadAttributeName()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				tag = null;
				return EmitDataToken(encodeEntities: false, truncated: true);
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				TokenizerState = HtmlTokenizerState.AfterAttributeName;
				break;
			case '/':
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				break;
			case '=':
				TokenizerState = HtmlTokenizerState.BeforeAttributeValue;
				break;
			case '>':
				EmitTagAttribute();
				return EmitTagToken();
			default:
				name.Append((c == '\0') ? '\ufffd' : c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.AttributeName);
		EmitTagAttribute();
		return null;
	}

	private HtmlToken ReadAfterAttributeName()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '/':
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				return null;
			case '=':
				TokenizerState = HtmlTokenizerState.BeforeAttributeValue;
				return null;
			case '>':
				return EmitTagToken();
			default:
				TokenizerState = HtmlTokenizerState.AttributeName;
				name.Append((c == '\0') ? '\ufffd' : c);
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		tag = null;
		return EmitDataToken(encodeEntities: false, truncated: true);
	}

	private HtmlToken ReadBeforeAttributeValue()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '"':
			case '\'':
				TokenizerState = HtmlTokenizerState.AttributeValueQuoted;
				quote = c;
				return null;
			case '&':
				TokenizerState = HtmlTokenizerState.CharacterReferenceInAttributeValue;
				return null;
			case '/':
				TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
				return null;
			case '>':
				return EmitTagToken();
			default:
				TokenizerState = HtmlTokenizerState.AttributeValueUnquoted;
				name.Append((c == '\0') ? '\ufffd' : c);
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		tag = null;
		return EmitDataToken(encodeEntities: false, truncated: true);
	}

	private HtmlToken ReadAttributeValueQuoted()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitDataToken(encodeEntities: false, truncated: true);
			}
			char c = (char)num;
			data.Append(c);
			if (c == '&')
			{
				TokenizerState = HtmlTokenizerState.CharacterReferenceInAttributeValue;
				return null;
			}
			if (c == quote)
			{
				TokenizerState = HtmlTokenizerState.AfterAttributeValueQuoted;
				quote = '\0';
			}
			else
			{
				name.Append((c == '\0') ? '\ufffd' : c);
			}
		}
		while (TokenizerState == HtmlTokenizerState.AttributeValueQuoted);
		attribute.Value = name.ToString();
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadAttributeValueUnquoted()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				name.Length = 0;
				return EmitDataToken(encodeEntities: false, truncated: true);
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				TokenizerState = HtmlTokenizerState.BeforeAttributeName;
				break;
			case '&':
				TokenizerState = HtmlTokenizerState.CharacterReferenceInAttributeValue;
				return null;
			case '>':
				attribute.Value = name.ToString();
				name.Length = 0;
				return EmitTagToken();
			default:
				name.Append((c == '\0') ? '\ufffd' : c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.AttributeValueUnquoted);
		attribute.Value = name.ToString();
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadCharacterReferenceInAttributeValue()
	{
		char c = ((quote == '\0') ? '>' : quote);
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			name.Length = 0;
			return EmitDataToken(encodeEntities: false, truncated: true);
		}
		char c2 = (char)num;
		switch (c2)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
		case '&':
		case '<':
			name.Append('&');
			break;
		default:
		{
			if (c2 == c)
			{
				name.Append('&');
				break;
			}
			entity.Push('&');
			while (entity.Push(c2))
			{
				Read();
				if (c2 == ';')
				{
					break;
				}
				if ((num = Peek()) == -1)
				{
					TokenizerState = HtmlTokenizerState.EndOfFile;
					data.Length--;
					data.Append(entity.GetPushedInput());
					entity.Reset();
					return EmitDataToken(encodeEntities: false, truncated: true);
				}
				c2 = (char)num;
			}
			string pushedInput = entity.GetPushedInput();
			string str = ((c2 != '=' && !IsAlphaNumeric(c2)) ? entity.GetValue() : pushedInput);
			data.Length--;
			data.Append(pushedInput);
			name.Append(str);
			entity.Reset();
			break;
		}
		}
		if (quote == '\0')
		{
			TokenizerState = HtmlTokenizerState.AttributeValueUnquoted;
		}
		else
		{
			TokenizerState = HtmlTokenizerState.AttributeValueQuoted;
		}
		return null;
	}

	private HtmlToken ReadAfterAttributeValueQuoted()
	{
		HtmlToken result = null;
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitDataToken(encodeEntities: false, truncated: true);
		}
		char c = (char)num;
		bool flag;
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			TokenizerState = HtmlTokenizerState.BeforeAttributeName;
			data.Append(c);
			flag = true;
			break;
		case '/':
			TokenizerState = HtmlTokenizerState.SelfClosingStartTag;
			data.Append(c);
			flag = true;
			break;
		case '>':
			result = EmitTagToken();
			flag = true;
			break;
		default:
			TokenizerState = HtmlTokenizerState.BeforeAttributeName;
			flag = false;
			break;
		}
		if (flag)
		{
			Read();
		}
		return result;
	}

	private HtmlToken ReadSelfClosingStartTag()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitDataToken(encodeEntities: false, truncated: true);
		}
		char c = (char)num;
		if (c == '>')
		{
			tag.IsEmptyElement = true;
			return EmitTagToken();
		}
		TokenizerState = HtmlTokenizerState.BeforeAttributeName;
		data.Append(c);
		return null;
	}

	private HtmlToken ReadBogusComment()
	{
		while (true)
		{
			int num;
			if ((num = Read()) == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				break;
			}
			char c;
			if ((c = (char)num) == '>')
			{
				break;
			}
			data.Append((c == '\0') ? '\ufffd' : c);
		}
		TokenizerState = HtmlTokenizerState.Data;
		return EmitCommentToken(data, bogus: true);
	}

	private HtmlToken ReadMarkupDeclarationOpen()
	{
		int i = 0;
		char c = '\0';
		for (; i < 2; i++)
		{
			int num;
			if ((num = Peek()) == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitDataToken(encodeEntities: false, truncated: true);
			}
			if ((c = (char)num) != '-')
			{
				break;
			}
			data.Append(c);
			Read();
		}
		switch (i)
		{
		case 2:
			TokenizerState = HtmlTokenizerState.CommentStart;
			name.Length = 0;
			return null;
		case 0:
			switch (c)
			{
			case 'D':
			case 'd':
				data.Append(c);
				name.Append(c);
				i = 1;
				Read();
				for (; i < 7; i++)
				{
					int num;
					if ((num = Read()) == -1)
					{
						TokenizerState = HtmlTokenizerState.EndOfFile;
						return EmitDataToken(encodeEntities: false, truncated: true);
					}
					c = (char)num;
					data.Append(c);
					name.Append(c);
					if (ToLower(c) != "doctype"[i])
					{
						break;
					}
				}
				if (i == 7)
				{
					doctype = CreateDocTypeToken(name.ToString());
					TokenizerState = HtmlTokenizerState.DocType;
					name.Length = 0;
					return null;
				}
				name.Length = 0;
				break;
			case '[':
				data.Append(c);
				i = 1;
				Read();
				for (; i < 7; i++)
				{
					int num;
					if ((num = Read()) == -1)
					{
						TokenizerState = HtmlTokenizerState.EndOfFile;
						return EmitDataToken(encodeEntities: false, truncated: true);
					}
					c = (char)num;
					data.Append(c);
					if (c != "[CDATA["[i])
					{
						break;
					}
				}
				if (i == 7)
				{
					TokenizerState = HtmlTokenizerState.CDataSection;
					data.Length = 0;
					return null;
				}
				break;
			}
			break;
		}
		TokenizerState = HtmlTokenizerState.BogusComment;
		for (int j = 0; j < data.Length - 2; j++)
		{
			data[j] = data[j + 2];
		}
		data.Length -= 2;
		bang = true;
		return null;
	}

	private HtmlToken ReadCommentStart()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(string.Empty);
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '-':
			TokenizerState = HtmlTokenizerState.CommentStartDash;
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(string.Empty);
		default:
			TokenizerState = HtmlTokenizerState.Comment;
			name.Append((c == '\0') ? '\ufffd' : c);
			break;
		}
		return null;
	}

	private HtmlToken ReadCommentStartDash()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(name);
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '-':
			TokenizerState = HtmlTokenizerState.CommentEnd;
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(name);
		default:
			TokenizerState = HtmlTokenizerState.Comment;
			name.Append('-');
			name.Append((c == '\0') ? '\ufffd' : c);
			break;
		}
		return null;
	}

	private HtmlToken ReadComment()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				return EmitCommentToken(name);
			}
			char c = (char)num;
			data.Append(c);
			if (c == '-')
			{
				break;
			}
			name.Append((c == '\0') ? '\ufffd' : c);
		}
		TokenizerState = HtmlTokenizerState.CommentEndDash;
		return null;
	}

	private HtmlToken ReadCommentEndDash()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(name);
		}
		char c = (char)num;
		data.Append(c);
		if (c == '-')
		{
			TokenizerState = HtmlTokenizerState.CommentEnd;
		}
		else
		{
			TokenizerState = HtmlTokenizerState.Comment;
			name.Append('-');
			name.Append((c == '\0') ? '\ufffd' : c);
		}
		return null;
	}

	private HtmlToken ReadCommentEnd()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				return EmitCommentToken(name);
			case '!':
				TokenizerState = HtmlTokenizerState.CommentEndBang;
				return null;
			case '-':
				break;
			default:
				TokenizerState = HtmlTokenizerState.Comment;
				name.Append("--");
				name.Append((c == '\0') ? '\ufffd' : c);
				return null;
			}
			name.Append('-');
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		return EmitCommentToken(name);
	}

	private HtmlToken ReadCommentEndBang()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			return EmitCommentToken(name);
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '-':
			TokenizerState = HtmlTokenizerState.CommentEndDash;
			name.Append("--!");
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			return EmitCommentToken(name);
		default:
			TokenizerState = HtmlTokenizerState.Comment;
			name.Append("--!");
			name.Append((c == '\0') ? '\ufffd' : c);
			break;
		}
		return null;
	}

	private HtmlToken ReadDocType()
	{
		int num = Peek();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			doctype.ForceQuirksMode = true;
			name.Length = 0;
			return EmitDocType();
		}
		TokenizerState = HtmlTokenizerState.BeforeDocTypeName;
		char c = (char)num;
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			data.Append(c);
			Read();
			break;
		}
		return null;
	}

	private HtmlToken ReadBeforeDocTypeName()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.ForceQuirksMode = true;
				return EmitDocType();
			default:
				TokenizerState = HtmlTokenizerState.DocTypeName;
				name.Append((c == '\0') ? '\ufffd' : c);
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadDocTypeName()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				doctype.Name = name.ToString();
				doctype.ForceQuirksMode = true;
				name.Length = 0;
				return EmitDocType();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				TokenizerState = HtmlTokenizerState.AfterDocTypeName;
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.Name = name.ToString();
				name.Length = 0;
				return EmitDocType();
			case '\0':
				name.Append('\ufffd');
				break;
			default:
				name.Append(c);
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.DocTypeName);
		doctype.Name = name.ToString();
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadAfterDocTypeName()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				continue;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				return EmitDocType();
			}
			name.Append(c);
			if (name.Length >= 6)
			{
				if (NameIs("public"))
				{
					TokenizerState = HtmlTokenizerState.AfterDocTypePublicKeyword;
					doctype.PublicKeyword = name.ToString();
				}
				else if (NameIs("system"))
				{
					TokenizerState = HtmlTokenizerState.AfterDocTypeSystemKeyword;
					doctype.SystemKeyword = name.ToString();
				}
				else
				{
					TokenizerState = HtmlTokenizerState.BogusDocType;
				}
				name.Length = 0;
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadAfterDocTypePublicKeyword()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			doctype.ForceQuirksMode = true;
			return EmitDocType();
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			TokenizerState = HtmlTokenizerState.BeforeDocTypePublicIdentifier;
			break;
		case '"':
		case '\'':
			TokenizerState = HtmlTokenizerState.DocTypePublicIdentifierQuoted;
			doctype.PublicIdentifier = string.Empty;
			quote = c;
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			doctype.ForceQuirksMode = true;
			return EmitDocType();
		default:
			TokenizerState = HtmlTokenizerState.BogusDocType;
			doctype.ForceQuirksMode = true;
			break;
		}
		return null;
	}

	private HtmlToken ReadBeforeDocTypePublicIdentifier()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '"':
			case '\'':
				TokenizerState = HtmlTokenizerState.DocTypePublicIdentifierQuoted;
				doctype.PublicIdentifier = string.Empty;
				quote = c;
				return null;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.ForceQuirksMode = true;
				return EmitDocType();
			default:
				TokenizerState = HtmlTokenizerState.BogusDocType;
				doctype.ForceQuirksMode = true;
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadDocTypePublicIdentifierQuoted()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				doctype.PublicIdentifier = name.ToString();
				doctype.ForceQuirksMode = true;
				name.Length = 0;
				return EmitDocType();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\0':
				name.Append('\ufffd');
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.PublicIdentifier = name.ToString();
				doctype.ForceQuirksMode = true;
				name.Length = 0;
				return EmitDocType();
			default:
				if (c == quote)
				{
					TokenizerState = HtmlTokenizerState.AfterDocTypePublicIdentifier;
					quote = '\0';
				}
				else
				{
					name.Append(c);
				}
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.DocTypePublicIdentifierQuoted);
		doctype.PublicIdentifier = name.ToString();
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadAfterDocTypePublicIdentifier()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			doctype.ForceQuirksMode = true;
			return EmitDocType();
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			TokenizerState = HtmlTokenizerState.BetweenDocTypePublicAndSystemIdentifiers;
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			return EmitDocType();
		case '"':
		case '\'':
			TokenizerState = HtmlTokenizerState.DocTypeSystemIdentifierQuoted;
			doctype.SystemIdentifier = string.Empty;
			quote = c;
			break;
		default:
			TokenizerState = HtmlTokenizerState.BogusDocType;
			doctype.ForceQuirksMode = true;
			break;
		}
		return null;
	}

	private HtmlToken ReadBetweenDocTypePublicAndSystemIdentifiers()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				return EmitDocType();
			case '"':
			case '\'':
				TokenizerState = HtmlTokenizerState.DocTypeSystemIdentifierQuoted;
				doctype.SystemIdentifier = string.Empty;
				quote = c;
				return null;
			default:
				TokenizerState = HtmlTokenizerState.BogusDocType;
				doctype.ForceQuirksMode = true;
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadAfterDocTypeSystemKeyword()
	{
		int num = Read();
		if (num == -1)
		{
			TokenizerState = HtmlTokenizerState.EndOfFile;
			doctype.ForceQuirksMode = true;
			return EmitDocType();
		}
		char c = (char)num;
		data.Append(c);
		switch (c)
		{
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			TokenizerState = HtmlTokenizerState.BeforeDocTypeSystemIdentifier;
			break;
		case '"':
		case '\'':
			TokenizerState = HtmlTokenizerState.DocTypeSystemIdentifierQuoted;
			doctype.SystemIdentifier = string.Empty;
			quote = c;
			break;
		case '>':
			TokenizerState = HtmlTokenizerState.Data;
			doctype.ForceQuirksMode = true;
			return EmitDocType();
		default:
			TokenizerState = HtmlTokenizerState.BogusDocType;
			doctype.ForceQuirksMode = true;
			break;
		}
		return null;
	}

	private HtmlToken ReadBeforeDocTypeSystemIdentifier()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '"':
			case '\'':
				TokenizerState = HtmlTokenizerState.DocTypeSystemIdentifierQuoted;
				doctype.SystemIdentifier = string.Empty;
				quote = c;
				return null;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.ForceQuirksMode = true;
				return EmitDocType();
			default:
				TokenizerState = HtmlTokenizerState.BogusDocType;
				doctype.ForceQuirksMode = true;
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadDocTypeSystemIdentifierQuoted()
	{
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				doctype.SystemIdentifier = name.ToString();
				doctype.ForceQuirksMode = true;
				name.Length = 0;
				return EmitDocType();
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\0':
				name.Append('\ufffd');
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				doctype.SystemIdentifier = name.ToString();
				doctype.ForceQuirksMode = true;
				name.Length = 0;
				return EmitDocType();
			default:
				if (c == quote)
				{
					TokenizerState = HtmlTokenizerState.AfterDocTypeSystemIdentifier;
					quote = '\0';
				}
				else
				{
					name.Append(c);
				}
				break;
			}
		}
		while (TokenizerState == HtmlTokenizerState.DocTypeSystemIdentifierQuoted);
		doctype.SystemIdentifier = name.ToString();
		name.Length = 0;
		return null;
	}

	private HtmlToken ReadAfterDocTypeSystemIdentifier()
	{
		while (true)
		{
			int num = Read();
			if (num == -1)
			{
				break;
			}
			char c = (char)num;
			data.Append(c);
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
				break;
			case '>':
				TokenizerState = HtmlTokenizerState.Data;
				return EmitDocType();
			default:
				TokenizerState = HtmlTokenizerState.BogusDocType;
				return null;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		doctype.ForceQuirksMode = true;
		return EmitDocType();
	}

	private HtmlToken ReadBogusDocType()
	{
		char c;
		do
		{
			int num = Read();
			if (num == -1)
			{
				TokenizerState = HtmlTokenizerState.EndOfFile;
				doctype.ForceQuirksMode = true;
				return EmitDocType();
			}
			c = (char)num;
			data.Append(c);
		}
		while (c != '>');
		TokenizerState = HtmlTokenizerState.Data;
		return EmitDocType();
	}

	private HtmlToken ReadCDataSection()
	{
		for (int num = Read(); num != -1; num = Read())
		{
			char c = (char)num;
			if (cdataIndex >= 3)
			{
				data.Append(cdata[0]);
				cdata[0] = cdata[1];
				cdata[1] = cdata[2];
				cdata[2] = c;
				if (cdata[0] == ']' && cdata[1] == ']' && cdata[2] == '>')
				{
					TokenizerState = HtmlTokenizerState.Data;
					cdataIndex = 0;
					return EmitCDataToken();
				}
			}
			else
			{
				cdata[cdataIndex++] = c;
			}
		}
		TokenizerState = HtmlTokenizerState.EndOfFile;
		for (int i = 0; i < cdataIndex; i++)
		{
			data.Append(cdata[i]);
		}
		cdataIndex = 0;
		return EmitCDataToken();
	}

	public bool ReadNextToken(out HtmlToken token)
	{
		do
		{
			switch (TokenizerState)
			{
			case HtmlTokenizerState.Data:
				token = ReadData();
				break;
			case HtmlTokenizerState.CharacterReferenceInData:
				token = ReadCharacterReferenceInData();
				break;
			case HtmlTokenizerState.RcData:
				token = ReadRcData();
				break;
			case HtmlTokenizerState.CharacterReferenceInRcData:
				token = ReadCharacterReferenceInRcData();
				break;
			case HtmlTokenizerState.RawText:
				token = ReadRawText();
				break;
			case HtmlTokenizerState.ScriptData:
				token = ReadScriptData();
				break;
			case HtmlTokenizerState.PlainText:
				token = ReadPlainText();
				break;
			case HtmlTokenizerState.TagOpen:
				token = ReadTagOpen();
				break;
			case HtmlTokenizerState.EndTagOpen:
				token = ReadEndTagOpen();
				break;
			case HtmlTokenizerState.TagName:
				token = ReadTagName();
				break;
			case HtmlTokenizerState.RcDataLessThan:
				token = ReadRcDataLessThan();
				break;
			case HtmlTokenizerState.RcDataEndTagOpen:
				token = ReadRcDataEndTagOpen();
				break;
			case HtmlTokenizerState.RcDataEndTagName:
				token = ReadRcDataEndTagName();
				break;
			case HtmlTokenizerState.RawTextLessThan:
				token = ReadRawTextLessThan();
				break;
			case HtmlTokenizerState.RawTextEndTagOpen:
				token = ReadRawTextEndTagOpen();
				break;
			case HtmlTokenizerState.RawTextEndTagName:
				token = ReadRawTextEndTagName();
				break;
			case HtmlTokenizerState.ScriptDataLessThan:
				token = ReadScriptDataLessThan();
				break;
			case HtmlTokenizerState.ScriptDataEndTagOpen:
				token = ReadScriptDataEndTagOpen();
				break;
			case HtmlTokenizerState.ScriptDataEndTagName:
				token = ReadScriptDataEndTagName();
				break;
			case HtmlTokenizerState.ScriptDataEscapeStart:
				token = ReadScriptDataEscapeStart();
				break;
			case HtmlTokenizerState.ScriptDataEscapeStartDash:
				token = ReadScriptDataEscapeStartDash();
				break;
			case HtmlTokenizerState.ScriptDataEscaped:
				token = ReadScriptDataEscaped();
				break;
			case HtmlTokenizerState.ScriptDataEscapedDash:
				token = ReadScriptDataEscapedDash();
				break;
			case HtmlTokenizerState.ScriptDataEscapedDashDash:
				token = ReadScriptDataEscapedDashDash();
				break;
			case HtmlTokenizerState.ScriptDataEscapedLessThan:
				token = ReadScriptDataEscapedLessThan();
				break;
			case HtmlTokenizerState.ScriptDataEscapedEndTagOpen:
				token = ReadScriptDataEscapedEndTagOpen();
				break;
			case HtmlTokenizerState.ScriptDataEscapedEndTagName:
				token = ReadScriptDataEscapedEndTagName();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscapeStart:
				token = ReadScriptDataDoubleEscapeStart();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscaped:
				token = ReadScriptDataDoubleEscaped();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscapedDash:
				token = ReadScriptDataDoubleEscapedDash();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscapedDashDash:
				token = ReadScriptDataDoubleEscapedDashDash();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscapedLessThan:
				token = ReadScriptDataDoubleEscapedLessThan();
				break;
			case HtmlTokenizerState.ScriptDataDoubleEscapeEnd:
				token = ReadScriptDataDoubleEscapeEnd();
				break;
			case HtmlTokenizerState.BeforeAttributeName:
				token = ReadBeforeAttributeName();
				break;
			case HtmlTokenizerState.AttributeName:
				token = ReadAttributeName();
				break;
			case HtmlTokenizerState.AfterAttributeName:
				token = ReadAfterAttributeName();
				break;
			case HtmlTokenizerState.BeforeAttributeValue:
				token = ReadBeforeAttributeValue();
				break;
			case HtmlTokenizerState.AttributeValueQuoted:
				token = ReadAttributeValueQuoted();
				break;
			case HtmlTokenizerState.AttributeValueUnquoted:
				token = ReadAttributeValueUnquoted();
				break;
			case HtmlTokenizerState.CharacterReferenceInAttributeValue:
				token = ReadCharacterReferenceInAttributeValue();
				break;
			case HtmlTokenizerState.AfterAttributeValueQuoted:
				token = ReadAfterAttributeValueQuoted();
				break;
			case HtmlTokenizerState.SelfClosingStartTag:
				token = ReadSelfClosingStartTag();
				break;
			case HtmlTokenizerState.BogusComment:
				token = ReadBogusComment();
				break;
			case HtmlTokenizerState.MarkupDeclarationOpen:
				token = ReadMarkupDeclarationOpen();
				break;
			case HtmlTokenizerState.CommentStart:
				token = ReadCommentStart();
				break;
			case HtmlTokenizerState.CommentStartDash:
				token = ReadCommentStartDash();
				break;
			case HtmlTokenizerState.Comment:
				token = ReadComment();
				break;
			case HtmlTokenizerState.CommentEndDash:
				token = ReadCommentEndDash();
				break;
			case HtmlTokenizerState.CommentEnd:
				token = ReadCommentEnd();
				break;
			case HtmlTokenizerState.CommentEndBang:
				token = ReadCommentEndBang();
				break;
			case HtmlTokenizerState.DocType:
				token = ReadDocType();
				break;
			case HtmlTokenizerState.BeforeDocTypeName:
				token = ReadBeforeDocTypeName();
				break;
			case HtmlTokenizerState.DocTypeName:
				token = ReadDocTypeName();
				break;
			case HtmlTokenizerState.AfterDocTypeName:
				token = ReadAfterDocTypeName();
				break;
			case HtmlTokenizerState.AfterDocTypePublicKeyword:
				token = ReadAfterDocTypePublicKeyword();
				break;
			case HtmlTokenizerState.BeforeDocTypePublicIdentifier:
				token = ReadBeforeDocTypePublicIdentifier();
				break;
			case HtmlTokenizerState.DocTypePublicIdentifierQuoted:
				token = ReadDocTypePublicIdentifierQuoted();
				break;
			case HtmlTokenizerState.AfterDocTypePublicIdentifier:
				token = ReadAfterDocTypePublicIdentifier();
				break;
			case HtmlTokenizerState.BetweenDocTypePublicAndSystemIdentifiers:
				token = ReadBetweenDocTypePublicAndSystemIdentifiers();
				break;
			case HtmlTokenizerState.AfterDocTypeSystemKeyword:
				token = ReadAfterDocTypeSystemKeyword();
				break;
			case HtmlTokenizerState.BeforeDocTypeSystemIdentifier:
				token = ReadBeforeDocTypeSystemIdentifier();
				break;
			case HtmlTokenizerState.DocTypeSystemIdentifierQuoted:
				token = ReadDocTypeSystemIdentifierQuoted();
				break;
			case HtmlTokenizerState.AfterDocTypeSystemIdentifier:
				token = ReadAfterDocTypeSystemIdentifier();
				break;
			case HtmlTokenizerState.BogusDocType:
				token = ReadBogusDocType();
				break;
			case HtmlTokenizerState.CDataSection:
				token = ReadCDataSection();
				break;
			default:
				token = null;
				return false;
			}
		}
		while (token == null);
		return true;
	}
}
