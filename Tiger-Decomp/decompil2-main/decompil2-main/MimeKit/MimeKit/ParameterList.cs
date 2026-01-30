using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using MimeKit.Encodings;
using MimeKit.Utils;

namespace MimeKit;

public class ParameterList : IList<Parameter>, ICollection<Parameter>, IEnumerable<Parameter>, IEnumerable
{
	private class NameValuePair : IComparable<NameValuePair>
	{
		public int ValueLength;

		public int ValueStart;

		public bool Encoded;

		public byte[] Value;

		public string Name;

		public int? Id;

		public int CompareTo(NameValuePair other)
		{
			if (!Id.HasValue)
			{
				if (!other.Id.HasValue)
				{
					return 0;
				}
				return -1;
			}
			if (!other.Id.HasValue)
			{
				return 1;
			}
			return Id.Value - other.Id.Value;
		}
	}

	private readonly Dictionary<string, Parameter> table;

	private readonly List<Parameter> parameters;

	public string this[string name]
	{
		get
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (table.TryGetValue(name, out var value))
			{
				return value.Value;
			}
			return null;
		}
		set
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (table.TryGetValue(name, out var value2))
			{
				value2.Value = value;
			}
			else
			{
				Add(name, value);
			}
		}
	}

	public int Count => parameters.Count;

	public bool IsReadOnly => false;

	public Parameter this[int index]
	{
		get
		{
			return parameters[index];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Parameter parameter = parameters[index];
			if (parameter == value)
			{
				return;
			}
			if (parameter.Name.Equals(value.Name, StringComparison.OrdinalIgnoreCase))
			{
				if (table[parameter.Name] == parameter)
				{
					table[parameter.Name] = value;
				}
			}
			else
			{
				if (table.ContainsKey(value.Name))
				{
					throw new ArgumentException("A parameter of that name already exists.", "value");
				}
				table.Add(value.Name, value);
				table.Remove(parameter.Name);
			}
			parameter.Changed -= OnParamChanged;
			value.Changed += OnParamChanged;
			parameters[index] = value;
			OnChanged();
		}
	}

	internal event EventHandler Changed;

	public ParameterList()
	{
		table = new Dictionary<string, Parameter>(MimeUtils.OrdinalIgnoreCase);
		parameters = new List<Parameter>();
	}

	public void Add(string name, string value)
	{
		Add(new Parameter(name, value));
	}

	public void Add(Encoding encoding, string name, string value)
	{
		Add(new Parameter(encoding, name, value));
	}

	public void Add(string charset, string name, string value)
	{
		Add(new Parameter(charset, name, value));
	}

	public bool Contains(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return table.ContainsKey(name);
	}

	public int IndexOf(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		for (int i = 0; i < parameters.Count; i++)
		{
			if (name.Equals(parameters[i].Name, StringComparison.OrdinalIgnoreCase))
			{
				return i;
			}
		}
		return -1;
	}

	public void Insert(int index, string name, string value)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Insert(index, new Parameter(name, value));
	}

	public bool Remove(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!table.TryGetValue(name, out var value))
		{
			return false;
		}
		return Remove(value);
	}

	public bool TryGetValue(string name, out Parameter param)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return table.TryGetValue(name, out param);
	}

	public bool TryGetValue(string name, out string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!table.TryGetValue(name, out var value2))
		{
			value = null;
			return false;
		}
		value = value2.Value;
		return true;
	}

	public void Add(Parameter param)
	{
		if (param == null)
		{
			throw new ArgumentNullException("param");
		}
		if (table.ContainsKey(param.Name))
		{
			throw new ArgumentException("A parameter of that name already exists.", "param");
		}
		param.Changed += OnParamChanged;
		table.Add(param.Name, param);
		parameters.Add(param);
		OnChanged();
	}

	public void Clear()
	{
		foreach (Parameter parameter in parameters)
		{
			parameter.Changed -= OnParamChanged;
		}
		parameters.Clear();
		table.Clear();
		OnChanged();
	}

	public bool Contains(Parameter param)
	{
		if (param == null)
		{
			throw new ArgumentNullException("param");
		}
		return parameters.Contains(param);
	}

	public void CopyTo(Parameter[] array, int arrayIndex)
	{
		parameters.CopyTo(array, arrayIndex);
	}

	public bool Remove(Parameter param)
	{
		if (param == null)
		{
			throw new ArgumentNullException("param");
		}
		if (!parameters.Remove(param))
		{
			return false;
		}
		param.Changed -= OnParamChanged;
		table.Remove(param.Name);
		OnChanged();
		return true;
	}

	public int IndexOf(Parameter param)
	{
		if (param == null)
		{
			throw new ArgumentNullException("param");
		}
		return parameters.IndexOf(param);
	}

	public void Insert(int index, Parameter param)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (param == null)
		{
			throw new ArgumentNullException("param");
		}
		if (table.ContainsKey(param.Name))
		{
			throw new ArgumentException("A parameter of that name already exists.", "param");
		}
		parameters.Insert(index, param);
		table.Add(param.Name, param);
		param.Changed += OnParamChanged;
		OnChanged();
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Parameter parameter = parameters[index];
		parameter.Changed -= OnParamChanged;
		parameters.RemoveAt(index);
		table.Remove(parameter.Name);
		OnChanged();
	}

	public IEnumerator<Parameter> GetEnumerator()
	{
		return parameters.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return parameters.GetEnumerator();
	}

	internal void Encode(FormatOptions options, StringBuilder builder, ref int lineLength, Encoding charset)
	{
		foreach (Parameter parameter in parameters)
		{
			parameter.Encode(options, builder, ref lineLength, charset);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (Parameter parameter in parameters)
		{
			stringBuilder.Append("; ");
			stringBuilder.Append(parameter.ToString());
		}
		return stringBuilder.ToString();
	}

	private void OnParamChanged(object sender, EventArgs args)
	{
		OnChanged();
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	private static bool SkipParamName(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsAttr())
		{
			index++;
		}
		return index > num;
	}

	private static bool TryParseNameValuePair(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out NameValuePair pair)
	{
		bool encoded = false;
		int? id = null;
		pair = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		int num = index;
		if (!SkipParamName(text, ref index, endIndex))
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid parameter name token at offset {0}", num), num, index);
			}
			return false;
		}
		string name = Encoding.ASCII.GetString(text, num, index - num);
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
			}
			return false;
		}
		if (text[index] == 42)
		{
			index++;
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
				}
				return false;
			}
			if (ParseUtils.TryParseInt32(text, ref index, endIndex, out var value))
			{
				if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
				if (index >= endIndex)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
					}
					return false;
				}
				if (text[index] == 42)
				{
					encoded = true;
					index++;
					if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
					{
						return false;
					}
					if (index >= endIndex)
					{
						if (throwOnError)
						{
							throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
						}
						return false;
					}
				}
				id = value;
			}
			else
			{
				encoded = true;
			}
		}
		if (text[index] != 61)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
			}
			return false;
		}
		index++;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete parameter at offset {0}", num), num, index);
			}
			return false;
		}
		int num2 = index;
		byte[] array = text;
		int num3;
		if (text[index] == 34)
		{
			ParseUtils.SkipQuoted(text, ref index, endIndex, throwOnError);
			num3 = index - num2;
		}
		else if (options.ParameterComplianceMode == RfcComplianceMode.Strict)
		{
			ParseUtils.SkipToken(text, ref index, endIndex);
			num3 = index - num2;
		}
		else
		{
			while (index < endIndex && text[index] != 59 && text[index] != 13 && text[index] != 10)
			{
				index++;
			}
			num3 = index - num2;
			if (index < endIndex && text[index] != 59)
			{
				using MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(text, num2, num3);
				while (true)
				{
					if (index < endIndex && (text[index] == 13 || text[index] == 10))
					{
						index++;
						continue;
					}
					num2 = index;
					while (index < endIndex && text[index] != 59 && text[index] != 13 && text[index] != 10)
					{
						index++;
					}
					memoryStream.Write(text, num2, index - num2);
					if (index >= endIndex || text[index] == 59)
					{
						break;
					}
				}
				array = memoryStream.ToArray();
				num3 = array.Length;
				num2 = 0;
			}
			while (num3 > num2 && array[num3 - 1].IsWhitespace())
			{
				num3--;
			}
		}
		pair = new NameValuePair
		{
			ValueLength = num3,
			ValueStart = num2,
			Encoded = encoded,
			Value = array,
			Name = name,
			Id = id
		};
		return true;
	}

	private static bool TryGetCharset(byte[] text, ref int index, int endIndex, out string charset)
	{
		int num = index;
		charset = null;
		int i;
		for (i = index; i < endIndex && text[i] != 39; i++)
		{
		}
		if (i == num || i == endIndex)
		{
			return false;
		}
		int num2 = i;
		for (i++; i < endIndex && text[i] != 39; i++)
		{
		}
		if (i == endIndex)
		{
			return false;
		}
		charset = Encoding.ASCII.GetString(text, num, num2 - num);
		index = i + 1;
		return true;
	}

	private static string DecodeRfc2231(out Encoding encoding, ref Decoder decoder, HexDecoder hex, byte[] text, int startIndex, int count, bool flush)
	{
		int num = startIndex + count;
		int index = startIndex;
		if (decoder == null)
		{
			if (TryGetCharset(text, ref index, num, out var charset))
			{
				try
				{
					encoding = CharsetUtils.GetEncoding(charset, "?");
					decoder = encoding.GetDecoder();
				}
				catch (NotSupportedException)
				{
					encoding = Encoding.GetEncoding(28591);
					decoder = encoding.GetDecoder();
				}
			}
			else
			{
				encoding = Encoding.GetEncoding(28591);
				decoder = encoding.GetDecoder();
			}
		}
		else
		{
			encoding = null;
		}
		int num2 = num - index;
		byte[] array = new byte[hex.EstimateOutputLength(num2)];
		num2 = hex.Decode(text, index, num2, array);
		int charCount = decoder.GetCharCount(array, 0, num2, flush);
		char[] array2 = new char[charCount];
		charCount = decoder.GetChars(array, 0, num2, array2, 0, flush);
		return new string(array2, 0, charCount);
	}

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out ParameterList paramList)
	{
		Dictionary<string, List<NameValuePair>> dictionary = new Dictionary<string, List<NameValuePair>>(MimeUtils.OrdinalIgnoreCase);
		List<NameValuePair> list = new List<NameValuePair>();
		paramList = null;
		while (true)
		{
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				break;
			}
			if (text[index] == 59)
			{
				index++;
				continue;
			}
			if (!TryParseNameValuePair(options, text, ref index, endIndex, throwOnError, out var pair))
			{
				return false;
			}
			if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (pair.Id.HasValue)
			{
				if (dictionary.TryGetValue(pair.Name, out var value))
				{
					value.Add(pair);
				}
				else
				{
					value = new List<NameValuePair>();
					dictionary[pair.Name] = value;
					list.Add(pair);
					value.Add(pair);
				}
			}
			else
			{
				list.Add(pair);
			}
			if (index >= endIndex)
			{
				break;
			}
			if (text[index] != 59)
			{
				if (options.ParameterComplianceMode == RfcComplianceMode.Strict)
				{
					if (throwOnError)
					{
						throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid parameter list token at offset {0}", index), index, index);
					}
					return false;
				}
			}
			else
			{
				index++;
			}
		}
		paramList = new ParameterList();
		HexDecoder hexDecoder = new HexDecoder();
		foreach (NameValuePair item in list)
		{
			ParameterEncodingMethod encodingMethod = ParameterEncodingMethod.Default;
			int num = item.ValueStart;
			int num2 = item.ValueLength;
			byte[] value2 = item.Value;
			Encoding encoding = null;
			Decoder decoder = null;
			string text2;
			if (item.Id.HasValue)
			{
				encodingMethod = ParameterEncodingMethod.Rfc2231;
				List<NameValuePair> value = dictionary[item.Name];
				value.Sort();
				text2 = string.Empty;
				for (int i = 0; i < value.Count; i++)
				{
					num = value[i].ValueStart;
					num2 = value[i].ValueLength;
					value2 = value[i].Value;
					if (value[i].Encoded)
					{
						bool flush = i + 1 >= value.Count || !value[i + 1].Encoded;
						if (num2 >= 2 && value2[num] == 34 && value2[num + num2 - 1] == 34)
						{
							num++;
							num2 -= 2;
						}
						text2 += DecodeRfc2231(out var encoding2, ref decoder, hexDecoder, value2, num, num2, flush);
						encoding = encoding ?? encoding2;
					}
					else if (num2 >= 2 && value2[num] == 34)
					{
						string text3 = CharsetUtils.ConvertToUnicode(options, value2, num, num2);
						text2 += MimeUtils.Unquote(text3);
						hexDecoder.Reset();
					}
					else if (num2 > 0)
					{
						text2 += CharsetUtils.ConvertToUnicode(options, value2, num, num2);
						hexDecoder.Reset();
					}
				}
				hexDecoder.Reset();
			}
			else if (item.Encoded)
			{
				if (num2 >= 2 && value2[num] == 34)
				{
					if (value2[num + num2 - 1] == 34)
					{
						num2--;
					}
					num++;
					num2--;
				}
				text2 = DecodeRfc2231(out encoding, ref decoder, hexDecoder, value2, num, num2, flush: true);
				encodingMethod = ParameterEncodingMethod.Rfc2231;
				hexDecoder.Reset();
			}
			else
			{
				if (paramList.Contains(item.Name))
				{
					continue;
				}
				int codepage = -1;
				if (num2 < 2 || text[num] != 34)
				{
					text2 = ((num2 <= 0) ? string.Empty : Rfc2047.DecodeText(options, value2, num, num2, out codepage));
				}
				else
				{
					string text4 = Rfc2047.DecodeText(options, value2, num, num2, out codepage);
					text2 = MimeUtils.Unquote(text4);
				}
				if (codepage != -1 && codepage != 65001)
				{
					encoding = CharsetUtils.GetEncoding(codepage);
					encodingMethod = ParameterEncodingMethod.Rfc2047;
				}
			}
			if (paramList.table.TryGetValue(item.Name, out var value3))
			{
				value3.Encoding = encoding;
				value3.Value = text2;
			}
			else if (encoding != null)
			{
				paramList.Add(encoding, item.Name, text2);
				value3 = paramList[paramList.Count - 1];
			}
			else
			{
				paramList.Add(item.Name, text2);
				value3 = paramList[paramList.Count - 1];
			}
			value3.EncodingMethod = encodingMethod;
		}
		return true;
	}
}
