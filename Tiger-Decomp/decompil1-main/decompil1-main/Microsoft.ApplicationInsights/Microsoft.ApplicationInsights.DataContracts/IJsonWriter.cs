using System;
using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.DataContracts;

public interface IJsonWriter
{
	void WriteStartArray();

	void WriteStartObject();

	void WriteEndArray();

	void WriteEndObject();

	void WriteComma();

	void WriteProperty(string name, string value);

	void WriteProperty(string name, bool? value);

	void WriteProperty(string name, int? value);

	void WriteProperty(string name, double? value);

	void WriteProperty(string name, TimeSpan? value);

	void WriteProperty(string name, DateTimeOffset? value);

	void WriteProperty(string name, IDictionary<string, double> values);

	void WriteProperty(string name, IDictionary<string, string> values);

	void WritePropertyName(string name);

	void WriteRawValue(object value);
}
