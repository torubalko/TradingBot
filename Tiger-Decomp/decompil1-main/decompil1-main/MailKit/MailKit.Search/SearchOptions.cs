using System;

namespace MailKit.Search;

[Flags]
public enum SearchOptions
{
	None = 0,
	All = 1,
	Count = 2,
	Min = 4,
	Max = 8,
	Relevancy = 0x10
}
