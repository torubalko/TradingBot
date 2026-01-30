using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Undo;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text;

public interface ITextDocument
{
	CharacterCasing AutoCharacterCasing { get; set; }

	bool AutoConvertTabsToSpaces { get; set; }

	ITextSnapshot CurrentSnapshot { get; }

	string FileName { get; set; }

	bool IsModified { get; set; }

	bool IsReadOnly { get; set; }

	int TabSize { get; set; }

	IUndoHistory UndoHistory { get; }

	event EventHandler<StringPropertyChangedEventArgs> FileNameChanged;

	event EventHandler IsModifiedChanged;

	event EventHandler IsReadOnlyChanged;

	event EventHandler TabSizeChanged;

	event EventHandler<TextSnapshotChangedEventArgs> TextChanged;

	event EventHandler<TextSnapshotChangingEventArgs> TextChanging;

	[EditorBrowsable(EditorBrowsableState.Never)]
	void AddTextChangedEventHandler(EventHandler<TextSnapshotChangedEventArgs> handler, EventHandlerPriority priority);

	[EditorBrowsable(EditorBrowsableState.Never)]
	void AddTextChangingEventHandler(EventHandler<TextSnapshotChangingEventArgs> handler, EventHandlerPriority priority);

	bool AppendText(ITextChangeType type, string text);

	bool AppendText(ITextChangeType type, string text, ITextChangeOptions options);

	ITextChange CreateTextChange(ITextChangeType type);

	ITextChange CreateTextChange(ITextChangeType type, ITextChangeOptions options);

	bool DeleteText(ITextChangeType type, TextRange textRange);

	bool DeleteText(ITextChangeType type, TextRange textRange, ITextChangeOptions options);

	bool DeleteText(ITextChangeType type, int offset, int length);

	bool DeleteText(ITextChangeType type, int offset, int length, ITextChangeOptions options);

	bool InsertText(ITextChangeType type, int offset, string text);

	bool InsertText(ITextChangeType type, int offset, string text, ITextChangeOptions options);

	LineTerminator LoadFile(string path);

	LineTerminator LoadFile(string path, Encoding encoding);

	LineTerminator LoadFile(Stream stream, Encoding encoding);

	bool IsTextRangeReadOnly(TextRange textRange);

	[EditorBrowsable(EditorBrowsableState.Never)]
	void RemoveTextChangedEventHandler(EventHandler<TextSnapshotChangedEventArgs> handler, EventHandlerPriority priority);

	[EditorBrowsable(EditorBrowsableState.Never)]
	void RemoveTextChangingEventHandler(EventHandler<TextSnapshotChangingEventArgs> handler, EventHandlerPriority priority);

	ISearchResultSet ReplaceAll(ISearchOptions options);

	ISearchResultSet ReplaceAll(ISearchOptions options, params TextRange[] searchTextRanges);

	ISearchResultSet ReplaceNext(ISearchOptions options, int startOffset, bool canWrap);

	ISearchResultSet ReplaceNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange);

	bool ReplaceText(ITextChangeType type, TextRange textRange, string text);

	bool ReplaceText(ITextChangeType type, TextRange textRange, string text, ITextChangeOptions options);

	bool ReplaceText(ITextChangeType type, int offset, int length, string text);

	bool ReplaceText(ITextChangeType type, int offset, int length, string text, ITextChangeOptions options);

	void SaveFile(string path, LineTerminator lineTerminator);

	void SaveFile(string path, Encoding encoding, LineTerminator lineTerminator);

	void SaveFile(Stream stream, Encoding encoding, LineTerminator lineTerminator);

	bool SetHeaderAndFooterText(string headerText, string footerText);

	bool SetText(string text);

	bool SetText(ITextChangeType type, string text);

	bool SetText(ITextChangeType type, string text, ITextChangeOptions options);
}
