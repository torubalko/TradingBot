using System.IO;

namespace Org.BouncyCastle.Asn1;

internal class DerOutputStreamNew : Asn1OutputStream
{
	internal override bool IsBer => false;

	internal DerOutputStreamNew(Stream os)
		: base(os)
	{
	}

	internal override void WritePrimitive(Asn1Object primitive, bool withID)
	{
		if (primitive is Asn1Set asn1Set)
		{
			primitive = new DerSet(asn1Set.elements);
		}
		primitive.Encode(this, withID);
	}
}
