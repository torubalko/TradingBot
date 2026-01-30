using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text;

public interface ICodeDocument : IParseTarget, ITextDocument
{
	ISyntaxLanguage Language { get; set; }

	object LanguageData { get; set; }

	IParseData ParseData { get; set; }

	PropertyDictionary Properties { get; }

	event EventHandler<SyntaxLanguageChangedEventArgs> LanguageChanged;

	event EventHandler<ParseDataPropertyChangedEventArgs> ParseDataChanged;

	[EditorBrowsable(EditorBrowsableState.Never)]
	void AddLanguageChangedEventHandler(EventHandler<SyntaxLanguageChangedEventArgs> handler, EventHandlerPriority priority);

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	ITagAggregator<T> CreateTagAggregator<T>() where T : ITag;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	IList<TService> GetServices<TService>() where TService : class;

	void QueueParseRequest();

	[EditorBrowsable(EditorBrowsableState.Never)]
	void RemoveLanguageChangedEventHandler(EventHandler<SyntaxLanguageChangedEventArgs> handler, EventHandlerPriority priority);
}
