using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class JsonWriter : IJsonWriter
{
	private sealed class EmptyObjectDetector : IJsonWriter
	{
		public bool IsEmpty { get; set; }

		public void WriteStartArray()
		{
		}

		public void WriteStartObject()
		{
		}

		public void WriteEndArray()
		{
		}

		public void WriteEndObject()
		{
		}

		public void WriteComma()
		{
		}

		public void WriteProperty(string name, string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, bool? value)
		{
			if (value.HasValue)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, int? value)
		{
			if (value.HasValue)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, double? value)
		{
			if (value.HasValue)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, TimeSpan? value)
		{
			if (value.HasValue)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, DateTimeOffset? value)
		{
			if (value.HasValue)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, IDictionary<string, double> value)
		{
			if (value != null && value.Count > 0)
			{
				IsEmpty = false;
			}
		}

		public void WriteProperty(string name, IDictionary<string, string> value)
		{
			if (value != null && value.Count > 0)
			{
				IsEmpty = false;
			}
		}

		public void WritePropertyName(string name)
		{
		}

		public void WriteRawValue(object value)
		{
			if (value != null)
			{
				IsEmpty = false;
			}
		}
	}

	private readonly EmptyObjectDetector emptyObjectDetector;

	private readonly TextWriter textWriter;

	private bool currentObjectHasProperties;

	internal JsonWriter(TextWriter textWriter)
	{
		emptyObjectDetector = new EmptyObjectDetector();
		this.textWriter = textWriter;
	}

	public void WriteStartArray()
	{
		textWriter.Write('[');
	}

	public void WriteStartObject()
	{
		textWriter.Write('{');
		currentObjectHasProperties = false;
	}

	public void WriteEndArray()
	{
		textWriter.Write(']');
	}

	public void WriteEndObject()
	{
		textWriter.Write('}');
	}

	public void WriteComma()
	{
		textWriter.Write(',');
	}

	public void WriteRawValue(object value)
	{
		textWriter.Write(string.Format(CultureInfo.InvariantCulture, "{0}", value));
	}

	public void WriteProperty(string name, string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			WritePropertyName(name);
			WriteString(value);
		}
	}

	public void WriteProperty(string name, bool? value)
	{
		if (value.HasValue)
		{
			WritePropertyName(name);
			textWriter.Write(value.Value ? "true" : "false");
		}
	}

	public void WriteProperty(string name, int? value)
	{
		if (value.HasValue)
		{
			WritePropertyName(name);
			textWriter.Write(value.Value.ToString(CultureInfo.InvariantCulture));
		}
	}

	public void WriteProperty(string name, double? value)
	{
		if (value.HasValue)
		{
			WritePropertyName(name);
			textWriter.Write(value.Value.ToString(CultureInfo.InvariantCulture));
		}
	}

	public void WriteProperty(string name, TimeSpan? value)
	{
		if (value.HasValue)
		{
			WriteProperty(name, value.Value.ToString(string.Empty, CultureInfo.InvariantCulture));
		}
	}

	public void WriteProperty(string name, DateTimeOffset? value)
	{
		if (value.HasValue)
		{
			WriteProperty(name, value.Value.ToString("o", CultureInfo.InvariantCulture));
		}
	}

	public void WriteProperty(string name, IDictionary<string, double> values)
	{
		if (values == null || values.Count <= 0)
		{
			return;
		}
		WritePropertyName(name);
		WriteStartObject();
		foreach (KeyValuePair<string, double> value in values)
		{
			WriteProperty(value.Key, value.Value);
		}
		WriteEndObject();
	}

	public void WriteProperty(string name, IDictionary<string, string> values)
	{
		if (values == null || values.Count <= 0)
		{
			return;
		}
		WritePropertyName(name);
		WriteStartObject();
		foreach (KeyValuePair<string, string> value in values)
		{
			WriteProperty(value.Key, value.Value);
		}
		WriteEndObject();
	}

	public void WritePropertyName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("name");
		}
		if (currentObjectHasProperties)
		{
			textWriter.Write(',');
		}
		else
		{
			currentObjectHasProperties = true;
		}
		WriteString(name);
		textWriter.Write(':');
	}

	protected void WriteString(string value)
	{
		textWriter.Write('"');
		foreach (char c in value)
		{
			switch (c)
			{
			case '\\':
				textWriter.Write("\\\\");
				continue;
			case '"':
				textWriter.Write("\\\"");
				continue;
			case '\n':
				textWriter.Write("\\n");
				continue;
			case '\b':
				textWriter.Write("\\b");
				continue;
			case '\f':
				textWriter.Write("\\f");
				continue;
			case '\r':
				textWriter.Write("\\r");
				continue;
			case '\t':
				textWriter.Write("\\t");
				continue;
			}
			if (!char.IsControl(c))
			{
				textWriter.Write(c);
				continue;
			}
			textWriter.Write("\\u");
			TextWriter obj = textWriter;
			ushort num = c;
			obj.Write(num.ToString("x4", CultureInfo.InvariantCulture));
		}
		textWriter.Write('"');
	}
}
