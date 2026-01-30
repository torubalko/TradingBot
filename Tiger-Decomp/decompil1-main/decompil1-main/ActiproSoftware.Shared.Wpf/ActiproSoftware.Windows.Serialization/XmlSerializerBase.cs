using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Serialization;

public abstract class XmlSerializerBase<TObj, TXmlObj> where TXmlObj : XmlObjectBase
{
	private XmlSerializer ooC;

	private ObservableCollection<Type> JoY;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<ItemSerializationEventArgs> voI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler<ItemSerializationEventArgs> Sox;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TXmlObj sor;

	internal static object wfi;

	public IList<Type> CustomTypes => JoY;

	public TXmlObj RootNode
	{
		[CompilerGenerated]
		get
		{
			return sor;
		}
		[CompilerGenerated]
		set
		{
			sor = value;
		}
	}

	[Description("Occurs when an object is deserialized.")]
	public event EventHandler<ItemSerializationEventArgs> ObjectDeserialized
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ItemSerializationEventArgs> eventHandler = voI;
			EventHandler<ItemSerializationEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemSerializationEventArgs> value2 = (EventHandler<ItemSerializationEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref voI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ItemSerializationEventArgs> eventHandler = voI;
			EventHandler<ItemSerializationEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemSerializationEventArgs> value2 = (EventHandler<ItemSerializationEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref voI, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[Description("Occurs when an object is serialized.")]
	public event EventHandler<ItemSerializationEventArgs> ObjectSerialized
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ItemSerializationEventArgs> eventHandler = Sox;
			EventHandler<ItemSerializationEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemSerializationEventArgs> value2 = (EventHandler<ItemSerializationEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sox, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ItemSerializationEventArgs> eventHandler = Sox;
			EventHandler<ItemSerializationEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ItemSerializationEventArgs> value2 = (EventHandler<ItemSerializationEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sox, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected XmlSerializerBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		JoY = new ObservableCollection<Type>();
		base._002Ector();
		JoY.CollectionChanged += woO;
	}

	protected XmlSerializerBase(TXmlObj rootNode)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		RootNode = rootNode;
	}

	private object do7(string P_0)
	{
		using Stream stream = File.OpenRead(P_0);
		return qoF(stream);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XmlSerializer")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GetXmlSerializer")]
	private object qoF(Stream P_0)
	{
		XmlSerializer xmlSerializer = ooC ?? GetXmlSerializer();
		if (xmlSerializer == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106102));
		}
		ooC = xmlSerializer;
		return xmlSerializer.Deserialize(P_0);
	}

	private object goo(string P_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		StreamWriter streamWriter = new StreamWriter(memoryStream);
		streamWriter.Write(P_0);
		streamWriter.Flush();
		memoryStream.Position = 0L;
		return qoF(memoryStream);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GetXmlSerializer")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XmlSerializer")]
	private object uoQ(XmlReader P_0)
	{
		XmlSerializer xmlSerializer = ooC ?? GetXmlSerializer();
		if (xmlSerializer == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106102));
		}
		ooC = xmlSerializer;
		return xmlSerializer.Deserialize(P_0);
	}

	private void woO(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		ooC = null;
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected virtual void RaiseObjectDeserialized(ItemSerializationEventArgs eventArgs)
	{
		voI?.Invoke(this, eventArgs);
	}

	[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
	protected virtual void RaiseObjectSerialized(ItemSerializationEventArgs eventArgs)
	{
		Sox?.Invoke(this, eventArgs);
	}

	private void do0(string P_0, object P_1)
	{
		using XmlWriter xmlWriter = XmlWriter.Create(P_0, XamlSerializer.GetXmlWriterSettings());
		eoA(xmlWriter, P_1);
	}

	private void zok(Stream P_0, object P_1)
	{
		using XmlWriter xmlWriter = XmlWriter.Create(P_0, XamlSerializer.GetXmlWriterSettings());
		eoA(xmlWriter, P_1);
	}

	private string yol(object P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, XamlSerializer.GetXmlWriterSettings()))
		{
			eoA(xmlWriter, P_0);
		}
		return stringBuilder.ToString();
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "XmlSerializer")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "GetXmlSerializer")]
	private void eoA(XmlWriter P_0, object P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		XmlSerializer xmlSerializer = ooC ?? GetXmlSerializer();
		if (xmlSerializer == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106102));
		}
		ooC = xmlSerializer;
		WriteHeader(P_0);
		xmlSerializer.Serialize(P_0, P_1);
	}

	public abstract void ApplyTo(TObj obj);

	public abstract TXmlObj CreateRootNodeFor(TObj obj);

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	protected abstract XmlSerializer GetXmlSerializer();

	public void LoadFromFile(string path)
	{
		RootNode = do7(path) as TXmlObj;
	}

	public void LoadFromFile(string path, TObj obj)
	{
		LoadFromFile(path);
		ApplyTo(obj);
	}

	public void LoadFromStream(Stream stream)
	{
		RootNode = qoF(stream) as TXmlObj;
	}

	public void LoadFromStream(Stream stream, TObj obj)
	{
		LoadFromStream(stream);
		ApplyTo(obj);
	}

	public void LoadFromString(string xml)
	{
		RootNode = goo(xml) as TXmlObj;
	}

	public void LoadFromString(string xml, TObj obj)
	{
		LoadFromString(xml);
		ApplyTo(obj);
	}

	public void LoadFromXmlReader(XmlReader reader)
	{
		RootNode = uoQ(reader) as TXmlObj;
	}

	public void LoadFromXmlReader(XmlReader reader, TObj obj)
	{
		LoadFromXmlReader(reader);
		ApplyTo(obj);
	}

	public void SaveToFile(string path)
	{
		do0(path, RootNode);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CreateRootNodeFor")]
	public void SaveToFile(string path, TObj obj)
	{
		RootNode = CreateRootNodeFor(obj);
		if (RootNode == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106206));
		}
		do0(path, RootNode);
	}

	public void SaveToStream(Stream stream)
	{
		zok(stream, RootNode);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CreateRootNodeFor")]
	public void SaveToStream(Stream stream, TObj obj)
	{
		RootNode = CreateRootNodeFor(obj);
		if (RootNode == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106206));
		}
		zok(stream, RootNode);
	}

	public string SaveToString()
	{
		return yol(RootNode);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CreateRootNodeFor")]
	public string SaveToString(TObj obj)
	{
		RootNode = CreateRootNodeFor(obj);
		if (RootNode == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106206));
		}
		return yol(RootNode);
	}

	public void SaveToXmlWriter(XmlWriter writer)
	{
		eoA(writer, RootNode);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "CreateRootNodeFor")]
	public void SaveToXmlWriter(XmlWriter writer, TObj obj)
	{
		RootNode = CreateRootNodeFor(obj);
		if (RootNode == null)
		{
			throw new SerializationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106206));
		}
		eoA(writer, RootNode);
	}

	protected virtual void WriteHeader(XmlWriter writer)
	{
	}

	internal static bool Kfp()
	{
		return wfi == null;
	}

	internal static object Xfh()
	{
		return wfi;
	}
}
