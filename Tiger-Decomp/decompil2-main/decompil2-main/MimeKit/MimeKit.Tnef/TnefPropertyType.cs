namespace MimeKit.Tnef;

public enum TnefPropertyType : short
{
	Unspecified = 0,
	Null = 1,
	I2 = 2,
	Long = 3,
	R4 = 4,
	Double = 5,
	Currency = 6,
	AppTime = 7,
	Error = 10,
	Boolean = 11,
	Object = 13,
	I8 = 20,
	String8 = 30,
	Unicode = 31,
	SysTime = 64,
	ClassId = 72,
	Binary = 258,
	MultiValued = 4096
}
