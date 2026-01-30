using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Parsing.Implementation;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class CodeDocument : TextDocumentBase, ICodeDocument, IParseTarget, ITextDocument
{
	private bool ume;

	private ISyntaxLanguage cmy;

	private object Qmz;

	private IParseData UcS;

	private PropertyDictionary tcV;

	private ITagAggregator<IReadOnlyRegionTag> McB;

	private Guid Ic9;

	private EventHandler<SyntaxLanguageChangedEventArgs> GcA;

	private EventHandler<SyntaxLanguageChangedEventArgs> jcu;

	private EventHandler<SyntaxLanguageChangedEventArgs> Wc8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<ParseDataPropertyChangedEventArgs> wcT;

	internal static CodeDocument vUr;

	Guid IParseTarget.UniqueId => Ic9;

	internal bool IsParsingEnabled
	{
		get
		{
			return ume;
		}
		set
		{
			if (ume != value)
			{
				ume = value;
				if (ume)
				{
					QueueParseRequest();
				}
			}
		}
	}

	public ISyntaxLanguage Language
	{
		get
		{
			return cmy;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008));
			}
			if (cmy == value)
			{
				return;
			}
			ISyntaxLanguage syntaxLanguage = cmy;
			cmy = value;
			if (syntaxLanguage != null)
			{
				IList<ICodeDocumentLifecycleEventSink> list = YmG<ICodeDocumentLifecycleEventSink>(syntaxLanguage);
				foreach (ICodeDocumentLifecycleEventSink item in list)
				{
					item.NotifyDocumentDetached(this);
				}
			}
			OnLanguageChanged(new SyntaxLanguageChangedEventArgs(syntaxLanguage, cmy));
			NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8662));
			if (cmy != null)
			{
				IList<ICodeDocumentTaggerProvider> list2 = YmG<ICodeDocumentTaggerProvider>(cmy);
				foreach (ICodeDocumentTaggerProvider item2 in list2)
				{
					if (item2.TagTypes == null)
					{
						continue;
					}
					foreach (Type tagType in item2.TagTypes)
					{
						if (tagType == typeof(ITokenTag))
						{
							item2.GetTagger<ITokenTag>(this);
						}
					}
				}
				IList<ICodeDocumentLifecycleEventSink> list3 = YmG<ICodeDocumentLifecycleEventSink>(cmy);
				foreach (ICodeDocumentLifecycleEventSink item3 in list3)
				{
					item3.NotifyDocumentAttached(this);
				}
			}
			if (ume && (UcS != null || base.CurrentSnapshot.Version.Number != 0 || !(syntaxLanguage is PlainTextSyntaxLanguage)))
			{
				QueueParseRequest();
			}
		}
	}

	public object LanguageData
	{
		get
		{
			return Qmz;
		}
		set
		{
			if (Qmz != value)
			{
				Qmz = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8682));
			}
		}
	}

	public IParseData ParseData
	{
		get
		{
			return UcS;
		}
		set
		{
			if (UcS != value)
			{
				IParseData ucS = UcS;
				UcS = value;
				OnParseDataChanged(new ParseDataPropertyChangedEventArgs(ucS, UcS));
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8710));
			}
		}
	}

	public PropertyDictionary Properties => tcV;

	public event EventHandler<SyntaxLanguageChangedEventArgs> LanguageChanged
	{
		add
		{
			AddLanguageChangedEventHandler(value, EventHandlerPriority.Medium);
		}
		remove
		{
			RemoveLanguageChangedEventHandler(value, EventHandlerPriority.Medium);
		}
	}

	public event EventHandler<ParseDataPropertyChangedEventArgs> ParseDataChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ParseDataPropertyChangedEventArgs> eventHandler = wcT;
			EventHandler<ParseDataPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ParseDataPropertyChangedEventArgs> value2 = (EventHandler<ParseDataPropertyChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wcT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ParseDataPropertyChangedEventArgs> eventHandler = wcT;
			EventHandler<ParseDataPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ParseDataPropertyChangedEventArgs> value2 = (EventHandler<ParseDataPropertyChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wcT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public CodeDocument()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		ume = true;
		cmy = SyntaxLanguage.PlainText;
		tcV = new PropertyDictionary();
		Ic9 = Guid.NewGuid();
		base._002Ector();
		McB = CreateTagAggregator<IReadOnlyRegionTag>();
	}

	void IParseTarget.NotifyParseComplete(IParseRequest request, IParseData result)
	{
		NotifyParseComplete(request, result);
	}

	private static IList<E8> YmG<E8>(ISyntaxLanguage P_0) where E8 : class
	{
		List<E8> list = new List<E8>();
		if (P_0 != null)
		{
			E8 service = P_0.GetService<E8>();
			if (service != null)
			{
				list.Add(service);
			}
			lock (P_0.SyncRoot)
			{
				foreach (object allServiceType in P_0.GetAllServiceTypes())
				{
					if (P_0.GetService(allServiceType) is E8 item && !list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
		}
		return list;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void AddLanguageChangedEventHandler(EventHandler<SyntaxLanguageChangedEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			GcA = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Combine(GcA, handler);
			break;
		case EventHandlerPriority.Low:
			Wc8 = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Combine(Wc8, handler);
			break;
		default:
			jcu = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Combine(jcu, handler);
			break;
		}
	}

	protected virtual IParseRequest CreateParseRequest()
	{
		if (cmy == null)
		{
			return null;
		}
		if (cmy.GetService<IParser>() == null)
		{
			return null;
		}
		ITextBufferReader mergedBufferReader = base.CurrentSnapshot.GetMergedBufferReader();
		ParseRequest parseRequest = new ParseRequest(string.IsNullOrEmpty(base.FileName) ? Ic9.ToString() : base.FileName, mergedBufferReader, cmy, this);
		parseRequest.Snapshot = base.CurrentSnapshot;
		parseRequest.Tag = Qmz;
		return parseRequest;
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public ITagAggregator<T> CreateTagAggregator<T>() where T : ITag
	{
		return new CodeDocumentTagAggregator<T>(this);
	}

	protected override IEnumerable<TagSnapshotRange<IReadOnlyRegionTag>> GetReadOnlyRegions(TextRange textRange)
	{
		return McB.GetTags(new TextSnapshotRange(base.CurrentSnapshot, textRange))?.Where((TagSnapshotRange<IReadOnlyRegionTag> r) => r.Tag != null && r.Tag.IsReadOnly).ToArray();
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public IList<TService> GetServices<TService>() where TService : class
	{
		return YmG<TService>(cmy);
	}

	protected virtual void NotifyParseComplete(IParseRequest request, IParseData result)
	{
		ParseData = result;
	}

	protected override void OnFileNameChanged(StringPropertyChangedEventArgs e)
	{
		if (cmy != null)
		{
			IList<ICodeDocumentPropertyChangeEventSink> list = YmG<ICodeDocumentPropertyChangeEventSink>(cmy);
			foreach (ICodeDocumentPropertyChangeEventSink item in list)
			{
				item.NotifyFileNameChanged(this, e);
			}
		}
		base.OnFileNameChanged(e);
	}

	protected virtual void OnLanguageChanged(SyntaxLanguageChangedEventArgs e)
	{
		GcA?.Invoke(this, e);
		jcu?.Invoke(this, e);
		Wc8?.Invoke(this, e);
	}

	protected virtual void OnParseDataChanged(ParseDataPropertyChangedEventArgs e)
	{
		if (cmy != null)
		{
			IList<ICodeDocumentPropertyChangeEventSink> list = YmG<ICodeDocumentPropertyChangeEventSink>(cmy);
			foreach (ICodeDocumentPropertyChangeEventSink item in list)
			{
				item.NotifyParseDataChanged(this, e);
			}
		}
		EventHandler<ParseDataPropertyChangedEventArgs> eventHandler = wcT;
		if (eventHandler != null)
		{
			eventHandler(this, e);
			int num = 0;
			if (!mUj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	protected override void OnTextChanged(TextSnapshotChangedEventArgs e)
	{
		if (ume)
		{
			QueueParseRequest();
		}
		base.OnTextChanged(e);
	}

	public void QueueParseRequest()
	{
		IParseRequest parseRequest = CreateParseRequest();
		if (parseRequest == null || parseRequest.Parser == null)
		{
			return;
		}
		IParseRequestDispatcher dispatcher = AmbientParseRequestDispatcherProvider.Dispatcher;
		if (dispatcher != null)
		{
			dispatcher.QueueRequest(parseRequest);
			return;
		}
		IParseData result = parseRequest.Parser.Parse(parseRequest);
		if (parseRequest.Target != null)
		{
			parseRequest.Target.NotifyParseComplete(parseRequest, result);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void RemoveLanguageChangedEventHandler(EventHandler<SyntaxLanguageChangedEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			GcA = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Remove(GcA, handler);
			break;
		case EventHandlerPriority.Low:
			Wc8 = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Remove(Wc8, handler);
			break;
		default:
			jcu = (EventHandler<SyntaxLanguageChangedEventArgs>)Delegate.Remove(jcu, handler);
			break;
		}
	}

	internal static bool mUj()
	{
		return vUr == null;
	}

	internal static CodeDocument XUK()
	{
		return vUr;
	}
}
