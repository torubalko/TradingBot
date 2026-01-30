using System;

namespace ActiproSoftware.Text.Parsing;

public interface IParseRequest
{
	DateTime CreatedDateTime { get; }

	ISyntaxLanguage Language { get; }

	string ParseHashKey { get; }

	IParser Parser { get; }

	int Priority { get; }

	int RepeatedRequestPause { get; set; }

	ITextSnapshot Snapshot { get; }

	string SourceKey { get; }

	ParseRequestState State { get; set; }

	object Tag { get; set; }

	IParseTarget Target { get; }

	ITextBufferReader TextBufferReader { get; }
}
