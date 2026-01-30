using System;

namespace MimeKit.Tnef;

[Flags]
public enum TnefComplianceStatus
{
	Compliant = 0,
	AttributeOverflow = 1,
	InvalidAttribute = 2,
	InvalidAttributeChecksum = 4,
	InvalidAttributeLength = 8,
	InvalidAttributeLevel = 0x10,
	InvalidAttributeValue = 0x20,
	InvalidDate = 0x40,
	InvalidMessageClass = 0x80,
	InvalidMessageCodepage = 0x100,
	InvalidPropertyLength = 0x200,
	InvalidRowCount = 0x400,
	InvalidTnefSignature = 0x800,
	InvalidTnefVersion = 0x1000,
	NestingTooDeep = 0x2000,
	StreamTruncated = 0x4000,
	UnsupportedPropertyType = 0x8000
}
