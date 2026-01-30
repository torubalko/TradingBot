using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MimeKit.Cryptography;

public class DigitalSignatureCollection : ReadOnlyCollection<IDigitalSignature>
{
	public DigitalSignatureCollection(IList<IDigitalSignature> signatures)
		: base(signatures)
	{
	}
}
