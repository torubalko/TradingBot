namespace MimeKit.Tnef;

internal enum TnefAttributeType
{
	Triples = 0,
	String = 65536,
	Text = 131072,
	Date = 196608,
	Short = 262144,
	Long = 327680,
	Byte = 393216,
	Word = 458752,
	DWord = 524288,
	Max = 589824
}
