using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Windows.Markup;
using System.Xml;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Serialization;

public class XamlSerializer
{
	private static XamlSerializer ofT;

	internal static XmlWriterSettings GetXmlWriterSettings()
	{
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.OmitXmlDeclaration = true;
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.IndentChars = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106096);
		return xmlWriterSettings;
	}

	public object LoadFromFile(string path)
	{
		using Stream stream = File.OpenRead(path);
		return LoadFromStream(stream);
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public object LoadFromStream(Stream stream)
	{
		return XamlReader.Load(stream);
	}

	public object LoadFromString(string xaml)
	{
		using MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream);
		streamWriter.Write(xaml);
		streamWriter.Flush();
		memoryStream.Position = 0L;
		return LoadFromStream(memoryStream);
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public object LoadFromXmlReader(XmlReader reader)
	{
		return XamlReader.Load(reader);
	}

	public void SaveToFile(string path, object value)
	{
		using XmlWriter writer = XmlWriter.Create(path, GetXmlWriterSettings());
		SaveToXmlWriter(writer, value);
	}

	public void SaveToStream(Stream stream, object value)
	{
		using XmlWriter writer = XmlWriter.Create(stream, GetXmlWriterSettings());
		SaveToXmlWriter(writer, value);
	}

	public string SaveToString(object value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (XmlWriter writer = XmlWriter.Create(stringBuilder, GetXmlWriterSettings()))
		{
			SaveToXmlWriter(writer, value);
		}
		return stringBuilder.ToString();
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public void SaveToXmlWriter(XmlWriter writer, object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592));
		}
		XamlWriter.Save(value, writer);
	}

	public XamlSerializer()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool kfX()
	{
		return ofT == null;
	}

	internal static XamlSerializer wfU()
	{
		return ofT;
	}
}
